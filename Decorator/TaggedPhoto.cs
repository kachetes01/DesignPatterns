using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Decorator
{
	public class TaggedPhoto: Photo
	{
		Photo photo;
		string tag;
		int tagNumber;
		static int count;
		static List<string> tags = new List<string>();
		public TaggedPhoto( Photo p, string t)
		{
			photo = p;
			tag = t;
			tags.Add(tag);
			count++;
			tagNumber = count;
		}
		// Need to override photo drawer method
		public override void Drawer(object source, PaintEventArgs e)
		{
			// call main method to paint the picture
			base.Drawer(source, e);
			e.Graphics.DrawString(tag, new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(80, 100 + tagNumber * 20));
		}

		// Added behavior
		// List the tags in the tags list
		public string ListTaggedPhotos()
		{
			string result = string.Empty;
			foreach(string t in tags)
			{
				result += t + " ";
			}
			return result;
		}

	}
}
