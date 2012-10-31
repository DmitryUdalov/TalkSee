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

	public class Dialer
	{
		public int OwnPortNum { get; set; }
		public int CallToPortNum { get; set; }

		public Dialer(int ownPort, int callPort)
		{
			this.OwnPortNum = ownPort;
			this.CallToPortNum = callPort;
		}

		public void StartCall()
		{
			//start call
		}

		public void EndCall()
		{
			//end call
		}

		public void AcceptCall()
		{
			//accept call
		}

		public void RejectCall()
		{
			//reject call
		}

		public void InputText()
		{
			//input text
		}

		public void DisplayText()
		{
			//display text message
		}

		public void RecordAudio()
		{
			//record audio
		}

		public void RecordVideo()
		{
			//record video
		}

		public void SendAudio()
		{
			//send audio to other client
		}

		public void SendVideo()
		{
			//send video to other client
		}
	
		public void SendReceiveSTT()
		{
			//send and recieve STT
		}

		public void SendText()
		{
			//send text to other client
		}
	}
}
