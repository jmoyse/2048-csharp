namespace _2048
{
	partial class Application2048
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.gameBoard = new _2048._2048Board();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.applicationNameLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.gameBoard);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 62);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 459);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// gameBoard
			// 
			this.gameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
			this.gameBoard.Dock = System.Windows.Forms.DockStyle.Top;
			this.gameBoard.Location = new System.Drawing.Point(0, 0);
			this.gameBoard.Margin = new System.Windows.Forms.Padding(0);
			this.gameBoard.Name = "gameBoard";
			this.gameBoard.Padding = new System.Windows.Forms.Padding(8);
			this.gameBoard.Score = 0;
			this.gameBoard.Size = new System.Drawing.Size(450, 450);
			this.gameBoard.TabIndex = 3;
			// 
			// scoreLabel
			// 
			this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.scoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
			this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.scoreLabel.Location = new System.Drawing.Point(388, 9);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(68, 48);
			this.scoreLabel.TabIndex = 3;
			this.scoreLabel.Text = "Score";
			this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// applicationNameLabel
			// 
			this.applicationNameLabel.AutoSize = true;
			this.applicationNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applicationNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
			this.applicationNameLabel.Location = new System.Drawing.Point(12, 9);
			this.applicationNameLabel.Name = "applicationNameLabel";
			this.applicationNameLabel.Size = new System.Drawing.Size(100, 47);
			this.applicationNameLabel.TabIndex = 4;
			this.applicationNameLabel.Text = "2048";
			// 
			// Application2048
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
			this.ClientSize = new System.Drawing.Size(471, 527);
			this.Controls.Add(this.applicationNameLabel);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.KeyPreview = true;
			this.Name = "Application2048";
			this.Text = "2048";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Application2048_KeyUp);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private _2048Board gameBoard;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label applicationNameLabel;

	}
}

