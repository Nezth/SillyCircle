using System;

namespace Circle
{
	class Circle {

		/**
		 * Opretter er cirkle med centrum i x,y og med radius r
		 * Skal kaste en exception hvis r er negativ!
		 */

		public Circle(float x, float y, float r) {
			
		}

		public bool IsInside(float x, float y) {
			throw new System.NotImplementedException();
		}

	}

	class MainClass
	{
		/**
		 * Udskriver `name` og venter på at brugeren indtaster et tal
		 * note: skal tjekke og håndtere exceptions 
		 */
		static float GetValue(string name) {
			throw new System.NotImplementedException();
		}




		public static void Main (string[] args)
		{
			Console.WriteLine ("Cirkelregner 2000");

			Circle c = new Circle (10, 10, 20);

			Console.WriteLine ("Der findes en cirkel: ", c);
			Console.WriteLine ("Skriv et punkt for at teste om det ligger i cirklen");

			float x = GetValue ("X? ");
			float y = GetValue ("Y? ");

			if (c.IsInside (x, y)) {
				Console.WriteLine ("{0},{1} var i cirklen!");
			} else {
				Console.WriteLine ("{0},{1} var IKKE cirklen!");
			}


			Console.ReadKey ();
		}
	}
}
