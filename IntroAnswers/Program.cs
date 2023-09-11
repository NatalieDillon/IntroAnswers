namespace IntroAnswers
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to C#\n");

			// Question One
			Console.WriteLine("Q1");
			DrawMan();
			Console.WriteLine();

			// Question Two
			Console.WriteLine("Q2");
			const double FromCentigrade = 22;
			double toFahrenheit = Math.Round(CentigradeToFahrenheit(FromCentigrade),2);
			Console.WriteLine($"{FromCentigrade} centigrade is {toFahrenheit} fahrenheit");

			const double FromFahrenheit = 90;
			double toCentigrade = Math.Round(FahrenheitToCentigrade(FromFahrenheit));
			Console.WriteLine($"{FromFahrenheit} fahrenheit is {toCentigrade} centigrade\n");

			// Question Three
			Console.WriteLine("Q3");
			double carpetCost = CalcCarpetCost(7, 6, 17);
			Console.WriteLine($"The carpet will cost £{carpetCost}\n");

			//Question Four
			Console.WriteLine("Q4");
			double ballsToFillPit = BallsToFillPit(1, 0.5, 0.075);
			Console.WriteLine($"{ballsToFillPit} balls will be needed to fill the pit\n");
        }

		public static void DrawMan()
		{
			Console.WriteLine("*******");
			Console.WriteLine("*     *");
			Console.WriteLine("*  0  *");
			Console.WriteLine(@"* /|\ *");
			Console.WriteLine(@"* / \ *");
			Console.WriteLine("*******");
		}

		public static double CentigradeToFahrenheit(double centigrade)
		{
			return (centigrade * 1.8) + 32;
		}

		public static double FahrenheitToCentigrade(double fahrenheit)
		{
			return (fahrenheit - 32) / 1.8;
		}

		public static double CalcCarpetCost(double width, double height, double price)
		{
			const double UnderlayCost = 3;
			const double Fitting = 50;
			double area = width * height;
			double gripperCost = width * 2 + height * 2;			
			return area*(price+UnderlayCost) + gripperCost + Fitting;
		}

		public static double BallsToFillPit(double radiusBallPit, double heightBallPit, double radiusBall)
		{
			const double PackingDensity = 0.75;
			double volBallPit = Math.PI * Math.Pow(radiusBallPit, 2) * heightBallPit;
			double volBall = 4d / 3d * Math.PI * Math.Pow(radiusBall,3);
            // Find ratio first, packing density constant should decrease the number of balls
            return Math.Ceiling(volBallPit / volBall * PackingDensity); 
		}
    }
}