using System;

namespace DecoratorPattern
{
	public class HouseBlend :Beverage
	{
		#region implemented abstract members of Beverage

		public override double Cost ()
		{
			return 0.99d;
		}

		#endregion

		public HouseBlend ()
		{
			description = "House Blend Coffee";
		}
	}
}

