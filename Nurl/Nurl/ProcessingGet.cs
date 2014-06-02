using System;
using System.IO;
using System.Text;
using System.Net;
using System.Diagnostics;

namespace Nurl
{
	public class ProcessingGet
	{
		public ProcessingGet ()
		{
		}

		public string showUrl(string url){

			System.Net.WebClient wc = new System.Net.WebClient();
			string html = wc.DownloadString(url);

			return html;
		}

		public void saveUrlInPathFile(string url, string pathFile){

			if (File.Exists(pathFile))
			{
				File.Delete(pathFile);
			}
			System.IO.File.WriteAllText (pathFile, showUrl(url));

		}
	}
}

