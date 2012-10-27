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
        private string _userName;
        private int _portNumber;
        private int _userID;
        private int _status;
        private string name;
        private int port;
        private int id;

        public UserInfo(string name, int port, int id, int status)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.port = port;
            this.id = id;
            this.Status = status;
        }
        //Available = 0, Offline = 1, Busy = 2

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = UserName;
            }
                
        }
        public int PortNumber
        {
            get
            {
                return _portNumber;
            }
            set
            {
                _portNumber = PortNumber;
            }

        }
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = UserID;
            }

        }
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = Status;
            }

        }
    }
}
