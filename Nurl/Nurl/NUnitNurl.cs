using NUnit.Framework;
using System;
using Nurl;

namespace Nurl
{
	[TestFixture ()]
	public class NUnitNurl
	{
		[Test ()]
		public void testIfGetExist ()
		{
			string[] args = { "get", "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(typeof(Boolean), process.testFirstArgs().GetType());
		}
	}
}

