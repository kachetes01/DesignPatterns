namespace Decorator
{
	public class DecoratorA : IComponent
	{
		IComponent c;
		public DecoratorA(IComponent component)
		{
			c = component;
		}
		public string Operation()
		{
			// get the component operation plus the decoration added here
			string s = c.Operation() + " and listening to Classic FM ";
			return s;
		}
	}
}
