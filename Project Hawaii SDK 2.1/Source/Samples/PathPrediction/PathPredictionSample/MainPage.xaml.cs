//-----------------------------------------------------------------------
// <copyright file="MainPage.xaml.cs" company="Microsoft">
//     Copyright (c) robgruen, . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PathPredictionSample
{
    using System;
    using System.Collections.Generic;
    using System.Device.Location;
    using System.Linq;
    using System.Threading;
    using System.Windows;
    using System.Windows.Media;
    using Microsoft.Hawaii;
    using Microsoft.Hawaii.PathPrediction.Client;
    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Controls.Maps;
    using Microsoft.Phone.Shell;

    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// The maximum number of trip crumbs that we will maintain
        /// </summary>
        private const int MaxCrumbs = 100;

        /// <summary>
        /// The maximum number of destinations to retrieve from the server
        /// </summary>
        /// <remarks>More results in a better prediction but also increases bandwidth used and slows down the prediction process</remarks>
        private const int MaxDestinations = 1000;

        /// <summary>
        /// The current location
        /// </summary>
        private static LatLong currentLocation;

        /// <summary>
        /// the location service watcher
        /// </summary>
        private GeoCoordinateWatcher watcher;

        /// <summary>
        /// A counter to determine if a prediction request is in progress
        /// </summary>
        private int predictionRequestsInProgress;

        /// <summary>
        /// The list of current potential destinations
        /// </summary>
        private PossibleDestination[] possibleDestinations = new PossibleDestination[] { };

        /// <summary>
        /// The prediction request object
        /// </summary>
        private PredictLocationRequest predictionRequest = new PredictLocationRequest();

        /// <summary>
        /// The queue that stores the GPS crumbs for the current trip
        /// </summary>
        private Queue<LatLong> tripCrumbs = new Queue<LatLong>(MaxCrumbs);

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            this.VerifyHawaiiIdentity();

            // setup the target location pulsar
            this.TargetLocationPulsar = new Pulsar();
            this.TargetLocationPulsar.Visibility = System.Windows.Visibility.Collapsed;
            this.TargetLocationPulsar.OuterEllipse.Fill = new SolidColorBrush(Colors.Yellow);
            this.TargetLocationPulsar.OuterEllipse.Stroke = new SolidColorBrush(Colors.Orange);
            this.TargetLocationPulsar.InnerEllipse.Fill = new RadialGradientBrush(Colors.Yellow, Colors.Orange);

            // setup the current location pulsar
            this.CurrentLocationPulsar = new Pulsar();

            // activate the GPS
            this.watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

            // 20 m is a reasonable movement threshold to remove noise in signal
            this.watcher.MovementThreshold = 20;
            this.watcher.StatusChanged += new EventHandler<System.Device.Location.GeoPositionStatusChangedEventArgs>(this.Watcher_StatusChanged);
            this.watcher.PositionChanged += new EventHandler<System.Device.Location.GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate>>(this.Watcher_PositionChanged);
            this.watcher.Start();
        }

        /// <summary>
        /// Gets or sets the pulsar for the current location
        /// </summary>
        public Pulsar CurrentLocationPulsar { get; set; }

        /// <summary>
        /// Gets or sets the pulsar for the target location
        /// </summary>
        public Pulsar TargetLocationPulsar { get; set; }

        /// <summary>
        /// Gets or sets the radius that the pulsar should be in meters
        /// </summary>
        public double TargetLocationPulsarRadiusInMeters { get; set; }

        /// <summary>
        /// Gets or sets the predicted location
        /// </summary>
        public LatLong TargetLocation { get; set; }

        /// <summary>
        /// Retrieves the distance per pixel of the map at it's current zoom level
        /// </summary>
        /// <param name="latitude">The latitude for the resolution request</param>
        /// <param name="zoomLevel">The current zoom level of the map</param>
        /// <returns>resulution of the map</returns>
        public double GetMapResolution(double latitude, double zoomLevel)
        {
            // http://www.bing.com/toolbox/blogs/maps/archive/2006/02/25/map-control-zoom-levels-gt-resolution.aspx
            // Map resolution = 156543.04 meters/pixel * cos(latitude) / (2 ^ zoomlevel)
            double ret = 156543.04 * Math.Cos(latitude * Math.PI / 180.0) / Math.Pow(2, zoomLevel);

            return ret;
        }

        /// <summary>
        /// Event handler for the GPS device status change. Updates the UI with the latest GPS status
        /// </summary>
        /// <param name="sender">The invoking object</param>
        /// <param name="e">The event parameters</param>
        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
                {
                    switch (e.Status)
                    {
                        case GeoPositionStatus.Disabled:
                            // The Location Service is disabled or unsupported.
                            // Check to see if the user has disabled the Location Service.
                            if (watcher.Permission == GeoPositionPermission.Denied)
                            {
                                // The user has disabled the Location Service on their device.
                                gpsTextBlock.Text = "disabled.";
                            }
                            else
                            {
                                gpsTextBlock.Text = "broken";
                            }

                            break;

                        case GeoPositionStatus.Initializing:
                            // The Location Service is initializing.
                            gpsTextBlock.Text = "intializing";
                            break;

                        case GeoPositionStatus.NoData:
                            // The Location Service is working, but it cannot get location data.
                            // Alert the user and enable the Stop Location button.
                            gpsTextBlock.Text = "unavailable.";
                            break;

                        case GeoPositionStatus.Ready:
                            // The Location Service is working and is receiving location data.
                            // Show the current position and enable the Stop Location button.
                            // output the last time location updated
                            gpsTextBlock.Text = "ready.";
                            break;
                    }
                });
        }

        /// <summary>
        /// Event handler for the GPS position changed
        /// </summary>
        /// <param name="sender">The invoking object</param>
        /// <param name="e">The event parameters</param>
        private void Watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            // add the current location to the trip crumb list
            if (currentLocation.Latitude != 0.0 && currentLocation.Longitude != 0.0)
            {
                while (this.tripCrumbs.Count >= MaxCrumbs)
                {
                    this.tripCrumbs.Dequeue();
                }

                this.tripCrumbs.Enqueue(currentLocation);
            }

            // make sure that we don't exceed MAX_CRUMBS
            if (this.tripCrumbs.Count > MaxCrumbs)
            {
                this.tripCrumbs.Dequeue();
            }

            // add a crumb for the old location
            this.Dispatcher.BeginInvoke(() =>
            {
                Pulsar p = new Pulsar();
                p.Radius = 1;
                p.Opacity = 0.6;
                p.OuterEllipse.Fill = new SolidColorBrush(Colors.LightGray);
                p.OuterEllipse.Stroke = new SolidColorBrush(Colors.LightGray);
                p.InnerEllipse.Fill = new RadialGradientBrush(Colors.DarkGray, Colors.Gray);

                StaticLocations.AddChild(p, new GeoCoordinate(currentLocation.Latitude, currentLocation.Longitude), PositionOrigin.TopLeft);
            });

            // set the current location with the newly acquired position
            currentLocation = new LatLong((float)e.Position.Location.Latitude, (float)e.Position.Location.Longitude);

            // center on the current location
            this.CenterLocation(currentLocation);

            // if we have more than one point we can run a prediction...
            lock (this.tripCrumbs)
            {
                if (this.tripCrumbs.Count > 1 && this.predictionRequestsInProgress == 0)
                {
                    // run a predicted location search
                    Interlocked.Increment(ref this.predictionRequestsInProgress);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ExecutePrediction), this.tripCrumbs.ToArray());
                }
            }

            // pulsar update has to happen in the UI thread
            this.Dispatcher.BeginInvoke(() =>
            {
                GeoCoordinate gc = new GeoCoordinate(currentLocation.Latitude, currentLocation.Longitude);

                if (StaticLocations.Children.Contains(CurrentLocationPulsar))
                {
                    StaticLocations.Children.Remove(CurrentLocationPulsar);
                }

                StaticLocations.AddChild(CurrentLocationPulsar, gc, PositionOrigin.TopLeft);

                CenterLocation(currentLocation);
            });
        }

        /// <summary>
        /// Executes a prediction with the supplied GPS points
        /// </summary>
        /// <param name="o">The trip crumbs to use for running the prediction</param>
        private void ExecutePrediction(object o)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                predictionTextBlock.Text = "predicting destination...";
            });

            try
            {
                LatLong[] crumbs = (LatLong[])o;

                if (crumbs.Length == 0)
                {
                    crumbs = new LatLong[] { currentLocation };
                }

                this.predictionRequest.Path = new LatLong[crumbs.Length];
                for (int i = 0; i < crumbs.Length; i++)
                {
                    this.predictionRequest.Path[i] = new LatLong((float)crumbs[i].Latitude, (float)crumbs[i].Longitude);
                }

                this.predictionRequest.MaxDestinations = MaxDestinations;

                PathPredictionService.PredictLocationAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.predictionRequest, new ServiceAgent<PredictLocationResult>.OnCompleteDelegate(this.PredictionRequest_Completed), null);
            }
            catch
            {
                Interlocked.Decrement(ref this.predictionRequestsInProgress);

                this.Dispatcher.BeginInvoke(() =>
                {
                    predictionTextBlock.Text = "unable to make a prediction";
                });
            }
        }

        /// <summary>
        /// The event handler that handles the prediction request completion
        /// </summary>
        /// <param name="result">The results of the prediction request</param>
        private void PredictionRequest_Completed(PredictLocationResult result)
        {
            lock (this.possibleDestinations)
            {
                if (result.Status == Status.Success)
                {
                    this.possibleDestinations = result.PossibleDestinations;

                    this.Dispatcher.BeginInvoke(() =>
                    {
                        predictionTextBlock.Text = "prediction succeeded";
                    });

                    // indicate that we are done running a prediction
                    Interlocked.Decrement(ref this.predictionRequestsInProgress);
                }
                else
                {
                    this.Dispatcher.BeginInvoke(() =>
                    {
                        predictionTextBlock.Text = "prediction failed";
                    });

                    // indicate that we are done running a prediction
                    Interlocked.Decrement(ref this.predictionRequestsInProgress);
                    return;
                }

                if (this.possibleDestinations.Length > 0)
                {
                    // find the centroid of the possible destinations using weighted means
                    // for more info on weighted means see: http://en.wikipedia.org/wiki/Weighted_mean
                    LatLong centroid = new LatLong(0, 0);
                    double probabilitySum = 0;

                    // compute the weighted mean with the normalized probabilities of the top 25 percentile
                   int topPercentile = Math.Max(this.possibleDestinations.Length / 4, 1);
                   this.possibleDestinations = this.possibleDestinations.OrderByDescending(d => d.Probability).Take(topPercentile).ToArray();

                    foreach (PossibleDestination pd in this.possibleDestinations)
                    {
                        centroid.Latitude += (float)(pd.Location.Latitude * pd.Probability);
                        centroid.Longitude += (float)(pd.Location.Longitude * pd.Probability);

                        probabilitySum += pd.Probability;
                    }

                    centroid.Latitude = (float)(centroid.Latitude / probabilitySum);
                    centroid.Longitude = (float)(centroid.Longitude / probabilitySum);

                    // save the target location
                    this.TargetLocation = centroid;

                    // enable the "center on target" menu button
                    this.Dispatcher.BeginInvoke(() =>
                    {
                        ApplicationBarIconButton btn = (ApplicationBarIconButton)ApplicationBar.Buttons[0];
                        btn.IsEnabled = true;
                    });

                    // now get the standard deviation (i.e. radius of the target location pulsar)
                    double weightedMean = 0;
                    foreach (PossibleDestination pd in this.possibleDestinations)
                    {
                        weightedMean = pd.Probability * Math.Pow(centroid.DistanceMeters(new LatLong(pd.Location.Latitude, pd.Location.Longitude)), 2);
                    }

                    weightedMean = Math.Sqrt(weightedMean / probabilitySum);

                    // set the target location of the pulsar
                    this.Dispatcher.BeginInvoke(() =>
                    {
                        // make the pulsar visible
                        this.TargetLocationPulsar.Visibility = System.Windows.Visibility.Visible;
                        this.TargetLocationPulsarRadiusInMeters = weightedMean * 3.0;

                        if (this.TargetLocationPulsarRadiusInMeters / GetMapResolution(centroid.Latitude, MyMap.ZoomLevel) > 25)
                        {
                            this.TargetLocationPulsar.Radius = this.TargetLocationPulsarRadiusInMeters / GetMapResolution(centroid.Latitude, MyMap.ZoomLevel);
                        }
                        else
                        {
                            this.TargetLocationPulsar.Radius = 25;
                        }

                        GeoCoordinate gc = new GeoCoordinate(centroid.Latitude, centroid.Longitude);

                        if (StaticLocations.Children.Contains(this.TargetLocationPulsar))
                        {
                            StaticLocations.Children.Remove(this.TargetLocationPulsar);
                        }

                        StaticLocations.AddChild(this.TargetLocationPulsar, gc, PositionOrigin.TopLeft);
                    });
                }
            }
        }

        /// <summary>
        /// Centers the map control on the current location
            /// </summary>
        /// <param name="location">location to center the map</param>
        private void CenterLocation(LatLong location)
        {
            // if we don't have a location, just return
            if (location == null)
            {
                return;
            }

            // set the map's center
            GeoCoordinate gc = new GeoCoordinate();
            gc.Latitude = location.Latitude;
            gc.Longitude = location.Longitude;
            MyMap.Center = gc;
        }

        /// <summary>
        /// Handles menu item clicks on the main menu
        /// </summary>
        /// <param name="sender">the invoking object</param>
        /// <param name="e">the event arguments</param>
        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            if (ApplicationBar.MenuItems[0] == sender)
            {
                NavigationService.Navigate(new Uri("/MapLegendPage.xaml", UriKind.Relative));
            }
        }

        /// <summary>
        /// Centers the map on the current location
        /// </summary>
        /// <param name="sender">the invoking object</param>
        /// <param name="e">the event parameters</param>
        private void MenuMe_Click(object sender, EventArgs e)
        {
            this.CenterLocation(currentLocation);
        }

        /// <summary>
        /// Centers the map at the target location
        /// </summary>
        /// <param name="sender">the invoking object</param>
        /// <param name="e">the event parameters</param>
        private void MenuTarget_Click(object sender, EventArgs e)
        {
            this.CenterLocation(this.TargetLocation);
        }

        /// <summary>
        /// Clears the trip history
        /// </summary>
        /// <param name="sender">the invoking object</param>
        /// <param name="e">the event parameters</param>
        private void MenuDelete_Click(object sender, EventArgs e)
        {
            lock (this.tripCrumbs)
            {
                this.tripCrumbs.Clear();
            }
        }

        /// <summary>
        /// Verify that the Hawaii identity is set correctly.
        /// </summary>
        private void VerifyHawaiiIdentity()
        {
            if (string.IsNullOrEmpty(HawaiiClient.AdmClientId) ||
                string.IsNullOrEmpty(HawaiiClient.AdmClientSecret))
            {
                MessageBox.Show("The Adm client Id or client secret is missing. Please consult the \"Project Hawaii Installation Guide\" on how to obtain credentials");
                throw new Exception("Credentials are not set, exiting application");
            }
        }
    }
}