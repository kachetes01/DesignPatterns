using System.Drawing;
using System.Windows.Forms;

namespace Decorator
{
	public class BorderedPhoto: Photo
	{
		Photo photo;
		Color color;
		public BorderedPhoto(Photo p, Color c)
		{
			photo = p;
			color = c;
		}
		public override void Drawer(object source, PaintEventArgs e)
		{
			// paint or draw the original picture
			photo.Drawer(source, e);
			// add a rectangle to the original picture
			e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
		}
	}
}
