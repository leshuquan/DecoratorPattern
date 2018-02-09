using System;

namespace DecoratorPattern
{
	public class Espresso:Beverage
	{
		#region implemented abstract members of Beverage
		public override double Cost ()
		{
			return 0.89;
		}
		#endregion

		public Espresso(){
			description = "Espresso";
		}
	}
}

