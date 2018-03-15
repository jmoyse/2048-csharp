using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
 
namespace _2048
{
	public partial class _2048Board : UserControl
	{

		List<List<_2048Tile>> _tiles = new List<List<_2048Tile>>();
		int size = 4;
		public int _score = 0;
		String cat;

		public int Score
		{
			get
			{
				return _score;
			}
			set
			{
				_score = value;
			}
		}

		public _2048Board()
		{
			
			InitializeComponent();
			updateBoard();
			_tiles.Add(new List<_2048Tile> { tite0x0, tile0x1, tile0x2, tile0x3 });
			_tiles.Add(new List<_2048Tile> { tile1x0, tile1x1, tile1x2, tile1x3 });
			_tiles.Add(new List<_2048Tile> { tile2x0, tile2x1, tile2x2, tile2x3 });
			_tiles.Add(new List<_2048Tile> { tile3x0, tile3x1, tile3x2, tile3x3 });

			setInitalPositions();
			getTileAt(3, 1).setValue(2);
			getTileAt(1, 3).setValue(2);


			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
			
		}

		private void setInitalPositions()
		{			
			int curX = 0;
			int curY = 0;

			foreach (List<_2048Tile> row in _tiles)
			{
				curX = 0;
				foreach (_2048Tile t in row)
				{
					t.xTile = curX;
					t.yTile = curY;
					t.setValue(0);

					curX++;
				}
				curY++;
			}
		}


		public void shiftLeft()
		{
			bool merged = false;
			List<int> boardInitalPosition = getBoardNumberValues();

			moveLeft();
			merged = mergeLeft();
			moveLeft();

			if (!boardsEqual(boardInitalPosition, getBoardNumberValues()))
			{
				addRandomTile();
			}
		}

		public void shiftRight()
		{
			List<int> boardInitalPosition = getBoardNumberValues();
			bool merged = false;
			moveRight();
			merged = mergeRight();
			moveRight();

			if (!boardsEqual(boardInitalPosition, getBoardNumberValues()))
			{
		
				addRandomTile();
			}
			
		}


		public void shiftUp()
		{
			List<int> boardInitalPosition = getBoardNumberValues();
			bool merged = false;
			moveUp();
			merged = mergeUp();
			moveUp();

			if (!boardsEqual(boardInitalPosition, getBoardNumberValues()))
			{
				
				addRandomTile();
			}
		}
		public void shiftDown()
		{
			List<int> boardInitalPosition = getBoardNumberValues();
			bool merged = false;
			moveDown();
			merged = mergeDown();
			moveDown();

			if (!boardsEqual(boardInitalPosition, getBoardNumberValues()))
			{
				
				addRandomTile();
			}
		}


		private bool mergeLeft()
		{
			bool performedMerge = false;

			// merge any similar numbers (start left go right)
			for (int x = 0; x <= size-1; x++)
			{
				for (int y = 0; y <= size-1; y++)
				{
					_2048Tile tile = getTileAt(x, y);
					if (x > 0)
					{
						_2048Tile leftTile = (getTileAt(x - 1, y));
						if (leftTile.getValue() == tile.getValue())
						{
							Score += leftTile.getValue();
							leftTile.setValue(leftTile.getValue() * 2);
							tile.setValue(0);
							performedMerge = true;
							
						}
					}
				}
			}
			return performedMerge;
		}

		private void moveLeft()
		{
			int rowNumber = 0;
			foreach (List<_2048Tile> row in _tiles)
			{
				List<int> tileValues = new List<int>();
				for (int i = 0; i <= size - 1; i++)
				{
					if (row[i].getValue() > 0)
						tileValues.Add(row[i].getValue());
					
				}
				for (int i = tileValues.Count; i <= size - 1; i++)
				{
					tileValues.Add(0);
				}

				for (int i = 0; i <= size - 1; i++)
				{
					
					_2048Tile tile = getTileAt(i, rowNumber);
					tile.setValue(int.Parse(tileValues[i].ToString()));						
				}
				rowNumber++;
			}
		}


		private bool mergeRight()
		{
			bool performedMerge = false;

			// merge any similar numbers (start right go left)
			for (int x = size-1; x >= 0; x--)
			{
				for (int y = size-1; y >= 0; y--)
				{
					_2048Tile tile = getTileAt(x, y);
					if (x < size-1)
					{
						_2048Tile rightTile = (getTileAt(x + 1, y));
						if (rightTile.getValue() == tile.getValue())
						{
							Score += rightTile.getValue();
							rightTile.setValue(rightTile.getValue() * 2);
							tile.setValue(0);
							performedMerge = true;
						}
					}
				}
			}
			return performedMerge;
		}


		private void moveRight()
		{


			int rowNumber = 0;
			foreach (List<_2048Tile> row in _tiles)
			{
				List<int> tileValues = new List<int>();
				for (int i = 0; i <= size - 1; i++)
				{
					if (row[i].getValue() > 0)
						tileValues.Add(row[i].getValue());

				}
				for (int i = tileValues.Count; i <= size - 1; i++)
				{
					tileValues.Insert(0,0);
				}

				for (int i = 0; i <= size - 1; i++)
				{
					
					_2048Tile tile = getTileAt(i, rowNumber);
					tile.setValue(int.Parse(tileValues[i].ToString()));
				}
				rowNumber++;
			}
		}
		
		private bool mergeUp()
		{
			bool performedMerge = false;

			// merge any similar numbers (start the bottom and move up)
			for (int x = size - 1; x >= 0; x--)
			{
				for (int y = size - 1; y >= 0; y--)
				{
					_2048Tile tile = getTileAt(x, y);
					if (y > 0)
					{
						_2048Tile upTile = (getTileAt(x , y-1));
						if (upTile.getValue() == tile.getValue())
						{
							Score += upTile.getValue();
							upTile.setValue(upTile.getValue() * 2);
							tile.setValue(0);
							performedMerge = true;
						}
					}
				}
			}
			return performedMerge;
		}


		private void moveUp()
		{
			int rowNumber = 0;
			for (int x = 0; x <= size - 1; x++)
			{
				List<int> tileValues = new List<int>();

				for (int i = size - 1; i >=0 ; i--)
				{
					if (getTileAt(x,i).getValue() > 0)
						tileValues.Add(getTileAt(x, i).getValue());

				}
				for (int i = tileValues.Count; i <= size - 1; i++)
				{
					tileValues.Insert(0, 0);
				}
				tileValues.Reverse();

				for (int i = 0; i <= size - 1; i++)
				{
					
					_2048Tile tile = getTileAt(x, i);
					tile.setValue(int.Parse(tileValues[i].ToString()));
				}
				rowNumber++;

			}
				foreach (List<_2048Tile> row in _tiles)
				{

				}
		}





		private bool mergeDown()
		{
			bool performedMerge = false;

			// merge any similar numbers (start the top and move down)
			for (int x = 0; x <= size - 1; x++)
			{
				for (int y = 0; y <= size -1; y++)
				{
					_2048Tile tile = getTileAt(x, y);
					if (y < size - 1)
					{
						_2048Tile upTile = (getTileAt(x, y + 1));
						if (upTile.getValue() == tile.getValue())
						{
							Score += upTile.getValue();
							upTile.setValue(upTile.getValue() * 2);
							tile.setValue(0);
							performedMerge = true;
						}
					}
				}
			}
			return performedMerge;
		}


		private void moveDown()
		{
			int rowNumber = 0;
			for (int x = size - 1; x >= 0; x--)
			{
				List<int> tileValues = new List<int>();

				for (int i = size - 1; i >= 0; i--)
				{
					if (getTileAt(x, i).getValue() > 0)
						tileValues.Add(getTileAt(x, i).getValue());

				}
				for (int i = tileValues.Count; i <= size - 1; i++)
				{
					tileValues.Insert(0, 0);
				}
				

				for (int i = 0; i <= size - 1; i++)
				{
					
					_2048Tile tile = getTileAt(x, i);
					tile.setValue(int.Parse(tileValues[i].ToString()));
				}
				rowNumber++;
			}
			foreach (List<_2048Tile> row in _tiles)
			{

			}
		}


		public void addRandomTile()
		{
			List<_2048Tile> emptyTiles = new List<_2048Tile>();

			for (int x = 0; x <= 3; x++)
			{
				for (int y = 0; y <= 3; y++)
				{
					_2048Tile tile = getTileAt(x, y);
					//tile.updateBackgroundColor(Color.FromArgb(238, 228, 218));
					if (tile.value == 0)
					{
						emptyTiles.Add(tile);
					}
				}
			}

			if (emptyTiles.Count > 0)
			{
				Random rand = new Random();

				_2048Tile randomTile = emptyTiles.ElementAt(rand.Next(emptyTiles.Count));
				randomTile.setValue(2);
				randomTile.updateBackgroundColor(Color.Gainsboro);
			}
		}

		private _2048Tile getTileAt(int x, int y)
		{

			return _tiles.ElementAt(y).ElementAt(x);
			/*
			foreach (List<_2048Tile> row in _tiles)
			{
				foreach (_2048Tile t in row)
				{
					if (t.xTile == x && t.yTile == y)
					{
						return t;
					}
				}
			}
			return null;
			 */
		}

		public bool boardsEqual(List<int> b1, List<int> b2)
		{
			if (b1.Count != b2.Count)
			{
				return false;
			}

			for (int i = 0; i < b1.Count; i++)
			{
				if (b1.ElementAt(i).ToString() != b2.ElementAt(i).ToString())
				{
					return false;
				}
			}

			return true;
		}
		public void updateBoard()
		{
	
		}

		public List<int> getBoardNumberValues()
		{
			List<int> values = new List<int>();

			foreach (List<_2048Tile> row in _tiles)
			{
				foreach (_2048Tile t in row)
				{
					values.Add(t.getValue());
				}
			}
			return values;
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
