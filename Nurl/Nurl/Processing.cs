using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using  NDesk.Options;

namespace Nurl
{
	public class Processing
	{


		public String argsFirst { get; set; }
		public String url { get; set; } 
		public String pathFile { get; set; } 
		public String nTime { get; set; } 
		public String average { get; set; } 

		public Processing ()
		{
		}

		public Processing (string[] args)
		{	
	
			string dir = null;
			new OptionSet {
				{ "url=|URL=", Url => url = Url },
				{ "save=|SAVE=", Save => pathFile = Save },
				{ "times=|TIMES=", Time => nTime = Time },
				{ "avg|AVG", Average => average = Average },
			}.Parse (args);

			Console.Write(url);
			Console.Write(pathFile);
			Console.Write(nTime);
			Console.Write(average);

			if (dir == null)
				throw new InvalidOperationException ("Missing required option -o=DIR");

		}
	}
}

