﻿namespace Messenger.Views
{
	partial class StartView
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
			this.lbFavorites = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbFavorites
			// 
			this.lbFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbFavorites.FormattingEnabled = true;
			this.lbFavorites.Location = new System.Drawing.Point(0, 0);
			this.lbFavorites.Name = "lbFavorites";
			this.lbFavorites.Size = new System.Drawing.Size(150, 150);
			this.lbFavorites.TabIndex = 0;
			// 
			// StartView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbFavorites);
			this.Name = "StartView";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbFavorites;
	}
}
