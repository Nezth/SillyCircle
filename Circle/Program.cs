using System;

namespace Circle
{
	class Circle {

		/**
		 * Opretter er cirkle med centrum i x,y og med radius r
		 * Skal kaste en exception hvis r er negativ!
		 */

			
		public Circle(double x, double y, double r) {
		}

		public bool IsInside(double x, double y) {
			throw new System.NotImplementedException();
		}

	}

	class MainClass
	{
		/**
		 * note: skal tjekke og håndtere exceptions 
		 */
		static double GetValue(string name) {
			throw new System.NotImplementedException();
		}




		public static void Main (string[] args)
		{
			Console.WriteLine ("Cirkelregner 2000");

			Circle c = new Circle (10, 10, 20);

			Console.WriteLine ("Der findes en cirkel: ", c);
			Console.WriteLine ("Skriv et punkt for at teste om det ligger i cirklen");

			double x = GetValue ("X? ");
			double y = GetValue ("Y? ");

			if (c.IsInside (x, y)) {
				Console.WriteLine ("{0},{1} var i cirklen!");
			} else {
				Console.WriteLine ("{0},{1} var IKKE cirklen!");
			}


			Console.ReadKey ();
		}
	}
}
