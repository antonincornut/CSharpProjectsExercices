using NUnit.Framework;
using System;
using Nurl;

namespace Nurl
{
	[TestFixture ()]
	public class NUnitNurl
	{
		/*** Test "get" ***/

		[Test ()]
		public void testIfGetExistIsBool ()
		{
			string[] args = { "get", "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(typeof(Boolean), process.testFirstArgsIsGet().GetType());
		}

		[Test]
		public void testIfDontExistGet()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testFirstArgsIsGet());
		}

		[Test ()]
		public void testIfGetExistIsTrue ()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testFirstArgsIsGet());
		}

		[Test ()]
		public void testIfGetExistIsFalse ()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testFirstArgsIsGet());
		}



		/*** Test "test" ***/

		[Test ()]
		public void testIfTestExistIsBool ()
		{
			string[] args = { "test", "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(typeof(Boolean), process.testFirstArgsisTest().GetType());
		}

		[Test]
		public void testIfDontExistTest()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testFirstArgsIsGet());
		}

		[Test ()]
		public void testIfTestExistIsTrue ()
		{
			string[] args = { "test", "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testFirstArgsisTest());
		}

		[Test ()]
		public void testIfTestExistIsFalse ()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testFirstArgsisTest());
		}


		/*** Test "Content" ***/

		/*** URL ***/

		[Test]
		public void testIfUrlExist()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfUrlExist());
		}

		[Test]
		public void testIfUrlNotExist()
		{
			string[] args = { "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfUrlExist());
		}

		/*** PathFile ***/

		[Test]
		public void testIfPathFileExist()
		{
			string[] args = { "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfPathFileExist());
		}

		[Test]
		public void testIfPathFileNotExist()
		{
			string[] args = { "-url", "\"http://abc\""};

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfPathFileExist());
		}

		/*** nTime ***/


		[Test]
		public void testIfTimeExist()
		{
			string[] args = { "test","-url","\"http://abc\"", "-times", "5", "-avg" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfPathTimeExist());
		}

		[Test]
		public void testIfTimeNotExist()
		{
			string[] args = { "test","-url","\"http://abc\""};

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfPathTimeExist());
		}

		/*** average ***/

		[Test]
		public void testIfAverageExist()
		{
			string[] args = { "test","-url","\"http://abc\"", "-times", "5", "-avg" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfAverageExist());
		}

		[Test]
		public void testIfAverageNotExist()
		{
			string[] args = { "test","-url","\"http://abc\""};

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfAverageExist());
		}


		/*** Good Syntax ***/

		/*** URL ***/

		[Test]
		public void testIfUrlHasAGoodSyntax()
		{
			string[] args = { "get", "-url", "\"http://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfUrlIsValid());
		}

		[Test]
		public void testIfUrlHasNotAGoodSyntax()
		{
			string[] args = { "get", "-url", "\"htt://abc\"", "-save", "file.txt" };

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfUrlIsValid());
		}

		/*** nTime ***/

		[Test]
		public void testIfTimeHasAGoodSyntax()
		{
			string[] args = { "test","-url","\"http://abc\"", "-times", "5", "-avg" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfTimelIsValid());
		}

		[Test]
		public void testIfTimeHasNotAGoodSyntax()
		{
			string[] args = { "test","-url","\"http://abc\"", "-times", "-5", "-avg" };

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfTimelIsValid());
		}

		/*** More Test ***/

		[Test]
		public void testIfTimeExistWithAvg()
		{
			string[] args = { "test","-url","\"http://abc\"", "-times", "5", "-avg" };

			var process = new Processing(args);

			Assert.AreEqual(true, process.testIfTimeExistWithAvg());
		}

		[Test]
		public void testIfTimeDontExistWithAvg()
		{
			string[] args = { "test","-url","\"http://abc\"", "-avg" };

			var process = new Processing(args);

			Assert.AreEqual(false, process.testIfTimeExistWithAvg());
		}

	}
}

