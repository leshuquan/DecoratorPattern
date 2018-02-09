using System;

namespace DecoratorPattern
{
	public class DarkRoast : Beverage
	{
		#region implemented abstract members of Beverage

		public override double Cost ()
		{
			return 2.99;
		}

		#endregion

		
		public DarkRoast ()
		{
			description = "DarkRoast";
		}
	}
}

