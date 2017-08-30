using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLibrary.Tests
{
	[TestClass()]
	public class BaseBilTests
	{
		[TestMethod()]
		public void PrisTest()
		{
			var MC = new MC();
			int pris = MC.Pris();
			Assert.AreEqual(125, pris);
		}

		[TestMethod()]
		public void KøretøjTest()
		{
			var MC = new MC();
			string køretøj = MC.Køretøj();
			Assert.AreEqual("MC", køretøj);
		}

		[TestMethod()]
		public void BaseBilTest()
		{
			Assert.Fail();
		}
	}
}