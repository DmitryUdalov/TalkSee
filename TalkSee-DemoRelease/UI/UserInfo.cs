using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SpeechToTextSampleApp
{
    
    public class UserInfo
    {
        public String UserName { get; set; }
        public String Number { get; set; }
        public int UserID { get; set; }
        public String Status { get; set; }
        //Status: Available = 0, Offline = 1, Busy = 2

        public UserInfo(string name, string number, int id, string status)
        {
            // TODO: Complete member initialization
            this.UserName = name;
            this.Number = number;
            this.UserID = id;
            this.Status = status;
        }
    }
}
