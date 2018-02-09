using System;

namespace DecoratorPattern
{
	public class Whip:CondimentDecorator
	{
		Beverage beverage;

		#region implemented abstract members of Beverage

		public override double Cost ()
		{
			return beverage.Cost () + .10;
		}

		#endregion

		#region implemented abstract members of CondimentDecorator

		public override string GetDescription ()
		{
			return beverage.GetDescription () + ",Whip";
		}

		#endregion

		public Whip (Beverage beverage)
		{
			this.beverage = beverage;
		}
	}
}

