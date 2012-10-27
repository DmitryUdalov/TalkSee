// ----------------------------------------------------------
// <copyright file="Pulsar.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace PathPredictionSample
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Represents the position of prediction of user's current location
    /// </summary>
    public partial class Pulsar : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the Pulsar class
        /// </summary>
        public Pulsar()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the outer ellipse
        /// </summary>
        public Ellipse OuterEllipse
        {
            get
            {
                return this.opacity_Copy;
            }
        }

        /// <summary>
        /// Gets the inner ellipse
        /// </summary>
        public Ellipse InnerEllipse
        {
            get
            {
                return this.innerEllipse;
            }
        }

        /// <summary>
        /// Gets or sets the redius of the pulsar
        /// </summary>
        public double Radius
        {
            get
            {
                return this.opacity_Copy.Width;
            }

            set
            {
                this.opacity_Copy.Width = value;
                this.opacity_Copy.Height = value;
                this.opacity_Copy.Margin = new Thickness(-opacity_Copy.Width / 2, -opacity_Copy.Height / 2, 0, 0);
            }
        }

        /// <summary>
        /// Gets or sets the dark color of the pulsar 
        /// </summary>
        public Color DarkColor
        {
            get
            {
                return ((SolidColorBrush)this.OuterEllipse.Stroke).Color;
            }

            set
            {
                this.OuterEllipse.Stroke = new SolidColorBrush(value);
                this.InnerEllipse.Fill = new RadialGradientBrush(this.LightColor, value);
            }
        }

        /// <summary>
        /// Gets or sets the dark color of the pulsar 
        /// </summary>
        public Color LightColor
        {
            get
            {
                return ((SolidColorBrush)this.OuterEllipse.Fill).Color;
            }

            set
            {
                this.OuterEllipse.Fill = new SolidColorBrush(value);
                this.InnerEllipse.Fill = new RadialGradientBrush(value, this.DarkColor);
            }
        }
    }
}