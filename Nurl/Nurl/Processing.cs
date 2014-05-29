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

		public bool testFirstArgsIsGet()
		{
			if(argsFirst != null || argsFirst == "get" || argsFirst == "GET")
				return true;

			return false;
		}

		public bool testFirstArgsisTest()
		{
			if(argsFirst != null || argsFirst == "test" || argsFirst == "TEST" )
				return true;

			return false;
		}

		public bool testIfUrlExist()
		{
			if(url != null)
				return true;

			return false;
		}

		public bool testIfPathFileExist()
		{
			if(pathFile != null)
				return true;

			return false;
		}

		public bool testIfPathTimeExist()
		{
			if(nTime != null)
				return true;

			return false;
		}

		public bool testIfAverageExist()
		{
			if(nTime != null)
				return true;

			return false;
		}

		public bool testIfUrlIsValid()
		{

			if(url.Contains("http://www.") || url.Contains("http:") || url.Contains("www."))
				return true;

			return false;
		}

		public bool testIfTimelIsValid()
		{
			int time = int.Parse(nTime);

			if (time >= 0) 
				return true;

			return false;
		}

		public bool testIfTimeExistWithAvg()
		{
			if (nTime != null && average != null) 
				return true;

			return false;
		}


	}
}

