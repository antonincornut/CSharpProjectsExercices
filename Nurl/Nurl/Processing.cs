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
			try{
			argsFirst = args [0];
			}catch{
			}
	
			new OptionSet {
				{ "url=|URL=", Url => url = Url },
				{ "save=|SAVE=", Save => pathFile = Save },
				{ "times=|TIMES=", Time => nTime = Time },
				{ "avg|AVG", Average => average = Average },
			}.Parse (args);

		}

		public bool testFirstArgs()
		{
			if(argsFirst != null || argsFirst == "get" || argsFirst == "test" || argsFirst == "GET" || argsFirst == "TEST" )
				return true;

			return false;
		}
	}
}

