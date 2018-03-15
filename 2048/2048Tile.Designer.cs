namespace _2048
{
	partial class _2048Tile
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tileValueLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tileValueLabel
			// 
			this.tileValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tileValueLabel.BackColor = System.Drawing.Color.Transparent;
			this.tileValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tileValueLabel.Location = new System.Drawing.Point(5, 5);
			this.tileValueLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tileValueLabel.Name = "tileValueLabel";
			this.tileValueLabel.Padding = new System.Windows.Forms.Padding(5);
			this.tileValueLabel.Size = new System.Drawing.Size(110, 110);
			this.tileValueLabel.TabIndex = 0;
			this.tileValueLabel.Text = "0";
			this.tileValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _2048Tile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tileValueLabel);
			this.Name = "_2048Tile";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Size = new System.Drawing.Size(120, 120);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label tileValueLabel;
	}
}
