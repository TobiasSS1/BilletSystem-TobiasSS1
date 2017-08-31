using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLibrary
{
	public abstract class BaseBil
	{
		//parameter
		public abstract string Nummerplade { get; set; }
		public abstract DateTime Dato { get; set; }

		//metoder
		public virtual int Pris()
		{
			return 0;
		}

		public virtual string Køretøj()
		{
			return "Placeholder";
		}

		public double rabat(double pris)
		{
			double rabatpris = pris * 0.80;
			return rabatpris;
		}

		//konsstruktør
		public BaseBil()
		{

		}
	}
}
