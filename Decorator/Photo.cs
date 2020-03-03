using System;
using System.Drawing;
using System.Windows.Forms;

namespace Decorator
{
	// Represents the component class in the Decorator pattern
	// Implements the form class. Assume that this class was given and cannot be modified at all.
	public partial class Photo : Form
	{
		Image image;
		public Photo()
		{
			InitializeComponent();
			image = new Bitmap("C:/Users/csilva29/source/repos/DesignPatterns/Decorator/images/lemonade.jpg");
			this.Text = "Lemonade";
			this.Paint += new PaintEventHandler(Drawer);
		}

		// This is the operation that will be called by the decorator classes
		// it relies in this method being called as 'virtual' whose functionality can be extended on other implementations
		public virtual void Drawer(Object source, PaintEventArgs e)
		{
			e.Graphics.DrawImage(image, 30, 20);
		}

		private void Photo_Load(object sender, EventArgs e)
		{

		}
	}
}
