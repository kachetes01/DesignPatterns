using System;
using System.Drawing;
using System.Windows.Forms;

namespace Decorator
{
	public class Client
	{
		//static void Display(string s, IComponent c)
		//{
		//	Console.WriteLine(s + c.Operation());
		//}
		static void Main()
		{
			//Console.WriteLine(" Decorator Pattern\n");

			//// Create a new IComponent 
			//IComponent component = new Component();
			//// this should print I'm walking 
			//Display("1. Basic component: ", component);
			//// Decorated A class
			//// should print I'm walking and listening to Classic FM
			//Display("2. A-Decorated: " , new DecoratorA(component));
			//// Decorated B class
			//// should print I'm walking to school
			//Display("3. B-Decorated: ", new DecoratorB(component));
			//// Decorated B and A
			//// should print I'm walking and listening to Classic FM to school
			//Display("4. B-A Decorated: ", new DecoratorB(new DecoratorA(component)));
			////  Decorated A and B
			////  using explicit B
			//// should print I'm walking to school and listening to Classic FM past the Coffe Shop and I bought a capuccino
			//DecoratorB b = new DecoratorB(new Component());
			//Display("5. a-B Decorated: ", new DecoratorA(b));
			//// print decorator B added behavior
			//Console.WriteLine(b.addedState + " " + b.AddedBehavior());

			//The below statement requires System.Windows.Form namespace
			Photo photo = new Photo();
			TaggedPhoto foodTaggedPhoto, colorTaggedPhoto, tag;
			BorderedPhoto composition;
			// draw photo alone
			Application.Run(photo);

			// add food tag to photo
			foodTaggedPhoto = new TaggedPhoto(photo, "Food");
			// add color tag to photo
			colorTaggedPhoto = new TaggedPhoto(foodTaggedPhoto, "Yellow");
			// add border color to photo
			composition = new BorderedPhoto(colorTaggedPhoto, Color.Blue);
			// draw photo
			Application.Run(composition);
			// print all tags in composition photo
			Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());

			// Compose a photo with one TaggedPhoto and a Yellow BorderedPhoto
			photo = new Photo();
			tag = new TaggedPhoto(photo, "new tag");
			composition = new BorderedPhoto(tag, Color.Yellow);
			Application.Run(composition);
			// print tags
			Console.WriteLine(tag.ListTaggedPhotos());

			// use Circle Photo
			photo = new Photo();
			CirclePhoto circlePhoto = new CirclePhoto(photo, Color.Brown);
			Application.Run(circlePhoto);


		}
	}
}
