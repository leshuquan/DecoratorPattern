using System;

namespace DecoratorPattern
{
	public class Mocha : CondimentDecorator
	{
		Beverage beverage;

		#region implemented abstract members of Beverage

		public override double Cost ()
		{
			return beverage.Cost () + .20;
		}

		#endregion

		#region implemented abstract members of CondimentDecorator

		public override string GetDescription ()
		{
			return beverage.GetDescription () + ",Mocha";
		}

		#endregion

		public Mocha (Beverage beverage)
		{
			this.beverage = beverage;
		}
	}
}

