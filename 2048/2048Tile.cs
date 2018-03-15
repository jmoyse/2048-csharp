using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;


namespace _2048
{
	public partial class _2048Tile : UserControl
	{
		public int value = 0;
		public int xTile = 0;
		public int yTile = 0;
		private List<Tuple<int, Color>> foregroundColors = new List<Tuple<int, Color>>();
		private List<Tuple<int, Color>> backgroundColors = new List<Tuple<int, Color>>();

		public _2048Tile()
		{
			InitializeComponent();
			
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

			backgroundColors.Add(new Tuple<int, Color>(0, Color.FromArgb(205, 193, 180)));
			backgroundColors.Add(new Tuple<int, Color>(2, Color.FromArgb(238, 228, 218)));
			backgroundColors.Add(new Tuple<int, Color>(4, Color.FromArgb(237, 224, 200)));
			backgroundColors.Add(new Tuple<int, Color>(8, Color.FromArgb(242, 177, 121)));
			backgroundColors.Add(new Tuple<int, Color>(16, Color.FromArgb(245, 149, 99)));
			backgroundColors.Add(new Tuple<int, Color>(32, Color.FromArgb(246, 124, 95)));
			backgroundColors.Add(new Tuple<int, Color>(64, Color.FromArgb(246, 94, 59)));
			backgroundColors.Add(new Tuple<int, Color>(128, Color.FromArgb(237, 207, 114)));
			backgroundColors.Add(new Tuple<int, Color>(256, Color.FromArgb(237, 204, 97)));
			backgroundColors.Add(new Tuple<int, Color>(512, Color.FromArgb(237, 200, 80)));
			backgroundColors.Add(new Tuple<int, Color>(1024, Color.FromArgb(237, 197, 63)));
			backgroundColors.Add(new Tuple<int, Color>(2048, Color.FromArgb(237, 194, 46)));



			foregroundColors.Add(new Tuple<int, Color>(0, Color.FromArgb(205, 193, 180)));
			foregroundColors.Add(new Tuple<int, Color>(2, Color.FromArgb(119, 110, 101)));
			foregroundColors.Add(new Tuple<int, Color>(4, Color.FromArgb(119, 110, 101)));
			foregroundColors.Add(new Tuple<int, Color>(8, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(16, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(32, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(64, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(128, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(256, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(512, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(1024, Color.FromArgb(249, 246, 242)));
			foregroundColors.Add(new Tuple<int, Color>(2048, Color.FromArgb(249, 246, 242)));

			

		}

		public void updateForegroundColor(Color color)
		{
			this.ForeColor = color;
		}
		public void updateBackgroundColor(Color color)
		{
			this.BackColor = color;
		}

		public void setValue(int value)
		{
			this.value = value;

			tileValueLabel.Text = value > 0 ? value.ToString() : "";

			var bg = backgroundColors.Find(x => x.Item1 == value);
			var fg = foregroundColors.Find(x => x.Item1 == value);

			if (fg == null)
			{
				Console.WriteLine("null");
			}
			this.BackColor = bg != null ? bg.Item2 : Color.Fuchsia;
			this.ForeColor = fg != null ? fg.Item2 : Color.Fuchsia;

			Font currentFont = tileValueLabel.Font;
			if (value > 64)
			{
				tileValueLabel.Font = new Font(currentFont.Name, 25);
			}
			else
			{
				tileValueLabel.Font = new Font(currentFont.Name, 35);
			}

		}

		public int getValue()
		{
			return value;
		}



		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect, // x-coordinate of upper-left corner
			int nTopRect, // y-coordinate of upper-left corner
			int nRightRect, // x-coordinate of lower-right corner
			int nBottomRect, // y-coordinate of lower-right corner
			int nWidthEllipse, // height of ellipse
			int nHeightEllipse // width of ellipse
		);


	}
}
