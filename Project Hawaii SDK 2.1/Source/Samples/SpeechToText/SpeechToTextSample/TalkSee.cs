using System;
using System.Net;
using System.Windows.Controls;
using Systems.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SpeechToTextSampleApp
{

	public class TalkSee
	{
		private string { get; set; }
		private string ownInfo { get; set; }
		private void CallHandler { get; set; }

		public TalkSee()
		{
			//TalkSee
		}

		public void Register()
		{
			//register with the directory server
		}

		public void DeRegister()
		{
			//deregister with the directory server
		}

		public void DisplayConnectError()
		{
			//display error if unable to connect
		}

		public string DisplayDirectory()
		{
			//display the directory
		}

		public void UpdateDirectory()
		{
			//update directory
		}

		public void DisplayCallScreen()
		{
			//display call screen on phone
		}

		public void UpdateServer()
		{
			//update server
		}

		public void DisplayRequestScreen()
		{
			//if call is requested, display request screen
		}

		public void DisplayRejectScreen()
		{
			//if outgoing call request is rejected, display reject screen
		}

		public void DisplayChatScreen()
		{
			//display screen containing chat messages
		}

		public void DisplaySettings()
		{
			//display settings screen
		}

		public void DisplayHelp()
		{
			//display help screen
		}
		
		public void Exit()
		{
			//exit TalkSee program
		}
	}
}
