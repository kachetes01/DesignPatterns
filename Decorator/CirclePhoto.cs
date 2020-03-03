using System.Drawing;
using System.Windows.Forms;

namespace Decorator
{
	public class CirclePhoto: Photo
	{
		Photo photo;
		Color color;
		public CirclePhoto(Photo p, Color c)
		{
			photo = p;
			color = c;
		}

		// Override Photo drawer method
		public override void Drawer(object source, PaintEventArgs e)
		{
			// paint picture
			base.Drawer(source, e);
			// add circle to photo
			e.Graphics.DrawEllipse(new Pen(color,20), 10, 50, 100, 50);
		}
	}
}
