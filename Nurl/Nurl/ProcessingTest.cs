using System;
using System.IO;
using System.Text;
using System.Net;
using System.Diagnostics;

namespace Nurl
{
	public class ProcessingTest
	{
		public ProcessingTest ()
		{
		}

		public void timeToDownloadContentUrl(string url, int time){

			TimeSpan ts = new TimeSpan ();
			int i = 0;

			while (i < time) {

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

				System.Diagnostics.Stopwatch timer = new Stopwatch();
				timer.Start();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse ();

				timer.Stop ();

				ts = timer.Elapsed;

				Console.WriteLine ("TEMPS " + i + " >>>>> {0}", ts.ToString(@"hh\:mm\:ss"));

				i++;

			}
				
		}

		public double timeToDownloadContentUrlNTimeWithAvg(string url, int time){

			double resultMoy = 0;

			return resultMoy;

		}
	}
}

