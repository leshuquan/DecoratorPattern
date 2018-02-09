using System;

namespace DecoratorPattern
{
	public class Soy:CondimentDecorator
	{
		Beverage beverage;

		#region implemented abstract members of Beverage

		public override double Cost ()
		{
			return beverage.Cost () + .15;
		}

		#endregion

		#region implemented abstract members of CondimentDecorator

		public override string GetDescription ()
		{
			return beverage.GetDescription () + ",Soy";
		}

		#endregion

		public Soy (Beverage beverage)
		{
			this.beverage = beverage;
		}
	}
}

