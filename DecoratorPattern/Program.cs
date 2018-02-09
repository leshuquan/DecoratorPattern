using System;

namespace DecoratorPattern
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Beverage beve1 = new Espresso();
			Console.WriteLine(beve1.GetDescription()+"$:"+beve1.Cost());

			Beverage beve2 = new DarkRoast();
			beve2 = new Mocha(beve2);
			//beve2 = new Mocha(beve2);
			//beve2 = new Whip(beve2);
			Console.WriteLine(beve2.GetDescription()+"$:"+beve2.Cost());

			Beverage beve3 = new HouseBlend();
			beve3 = new Soy(beve3);
			beve3 = new Mocha(beve3);
			beve3 = new Whip(beve3);
			Console.WriteLine(beve3.GetDescription()+"$:"+beve3.Cost());
		}
	}
}
