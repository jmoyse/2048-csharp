using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2048
{
	public partial class Application2048 : Form
	{
		String mything = "a";


		
		private string _customText = "A:";


		public Application2048()
		{
			InitializeComponent();
			//scoreLabel.DataBindings.Add("Text", gameBoard, "Score");
			
			//scoreLabel.DataBindings.Add("Text", this, "Size");
			//scoreLabel.DataBindings.Add("SelectedIndex", gameBoard, "Scor", true, DataSourceUpdateMode.OnPropertyChanged).BindingComplete += (s,e) => view.Refresh()


			//var dataBinding = scoreLabel.DataBindings.Add("Text", mything, "Name");
			//dataBinding.ReadValue();
			scoreLabel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		private void Application2048_KeyUp(object sender, KeyEventArgs e)
		{
			//Console.WriteLine(e.KeyCode.ToString());

			
			if (e.KeyCode == Keys.Up)
			{
				gameBoard.shiftUp();
			}
			else if (e.KeyCode == Keys.Down)
			{
				gameBoard.shiftDown();
			}
			else if (e.KeyCode == Keys.Left)
			{
				gameBoard.shiftLeft();
			}
			else if (e.KeyCode == Keys.Right)
			{
				gameBoard.shiftRight();
			}
			scoreLabel.Text = "Score \n" + gameBoard._score.ToString();
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
