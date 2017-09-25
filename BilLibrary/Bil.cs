using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLibrary
{
	public class Bil : BaseBil
	{

		///En string til at skrive en nummerplade 
		public override string Nummerplade { get; set; }

		/// <summary>
		/// En DateTime til at skrive en dato
		/// </summary>
		public override DateTime Dato { get; set; }

		///En boolean til at tjekke op på at man har en brobizz
		public override Boolean Brobizz { get; set; }

		public Bil()
		{

		}

		/// <summary>
		/// Sætter pris på bil
		/// </summary>
		/// <returns></returns>

		public override int Pris()
		{
			return 300;
		}

		/// <summary>
		/// Returnere hvilke køretøj
		/// </summary>
		/// <returns></returns>

		public override string Køretøj()
		{
			return "Øresund Bil";
		}

		/// <summary>
		/// Sætter rabat på bil
		/// </summary>
		/// <param name="pris"></param>
		/// <returns></returns>

		public virtual double Rabat(double pris)
		{
			if (Brobizz == true)
			{
				return 161;
			}
			else
			{
				double rabatpris = pris * 0.80;
				return rabatpris;
			}
		}
		
		/// <summary>
		/// Metode til weekendrabat
		/// </summary>
		/// <param name="pris"></param>
		/// <returns></returns>

		public double weekendrabat(double pris)
		{
		
			if ((int)DayOfWeek.Saturday == DateTime.Today.Day || (int)DayOfWeek.Sunday == DateTime.Today.Day)
			{
				double rabatpris = pris * 0.60;
				return rabatpris;
			}
			else
			{
				return pris;
			}
			 
		}

		
	}
}
