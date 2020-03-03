namespace Decorator
{
	public class DecoratorB: IComponent
	{
		IComponent c;
		public string addedState = "past the Coffe Shop ";
		public DecoratorB(IComponent component)
		{
			c = component;
		}
		// implement IComponent
		public string Operation()
		{
			string s = c.Operation() + " to school ";
			return s;
		}
		// this is extra information that will be added to the passed component
		public string AddedBehavior()
		{
			return " and I bought a capuccino";
		}
	}
}
