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
		//test
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
			Assert.AreEqual("Øresund MC", køretøj);
		}

		[TestMethod()]
		public void RabatTest()
		{
			var MC = new MC();
			double Pris = MC.Pris();
			double Rabat = MC.Rabat(Pris);
			Assert.AreEqual(100, Rabat);
		}

	}
}