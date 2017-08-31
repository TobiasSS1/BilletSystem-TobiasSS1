using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLibrary
{
	public class MC : BaseBil
	{
		public override string Nummerplade { get; set; }
		public override DateTime Dato { get; set; }
		public override Boolean Brobizz { get; set; }

		public MC()
		{

		}

		public override int Pris()
		{
			return 125;
		}

		public override string Køretøj()
		{
			return "Øresund MC";
		}

		public virtual double Rabat(double pris)
		{
			if (Brobizz == true)
			{
				return 73;
			}
			else
			{
				double rabatpris = pris * 0.80;
				return rabatpris;
			}
		}

	}
}
