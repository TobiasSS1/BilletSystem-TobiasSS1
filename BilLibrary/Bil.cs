using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLibrary
{
	public class Bil : BaseBil
	{
		public override string Nummerplade { get; set; }
		public override DateTime Dato { get; set; }

		public Bil()
		{

		}

		public override int Pris()
		{
			return 300;
		}

		public override string Køretøj()
		{
			return "Mercedes";
		}

		public int weekendrabat()
		{
			//kan ikke konverter til datetime
			//if ( DayOfWeek.Saturday == DateTime.Today || DayOfWeek.Sunday == DateTime.Today)
			//{

			//}
			return 200; 
		}

		
	}
}
