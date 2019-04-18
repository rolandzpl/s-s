namespace Messenger.Views
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartView));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblFavoritesCaption = new System.Windows.Forms.Label();
			this.lblDefinedMessagesCaption = new System.Windows.Forms.Label();
			this.lbFavorites = new System.Windows.Forms.ListBox();
			this.lvDefinedMessages = new System.Windows.Forms.ListView();
			this.tsFavoritesCommands = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tsDefinedMessagesCommands = new System.Windows.Forms.ToolStrip();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tsFavoritesCommands.SuspendLayout();
			this.tsDefinedMessagesCommands.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lbFavorites);
			this.splitContainer1.Panel1.Controls.Add(this.tsFavoritesCommands);
			this.splitContainer1.Panel1.Controls.Add(this.lblFavoritesCaption);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lvDefinedMessages);
			this.splitContainer1.Panel2.Controls.Add(this.tsDefinedMessagesCommands);
			this.splitContainer1.Panel2.Controls.Add(this.lblDefinedMessagesCaption);
			this.splitContainer1.Size = new System.Drawing.Size(554, 368);
			this.splitContainer1.SplitterDistance = 184;
			this.splitContainer1.TabIndex = 1;
			// 
			// lblFavoritesCaption
			// 
			this.lblFavoritesCaption.BackColor = System.Drawing.Color.Navy;
			this.lblFavoritesCaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblFavoritesCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblFavoritesCaption.ForeColor = System.Drawing.Color.White;
			this.lblFavoritesCaption.Location = new System.Drawing.Point(0, 0);
			this.lblFavoritesCaption.Name = "lblFavoritesCaption";
			this.lblFavoritesCaption.Size = new System.Drawing.Size(184, 25);
			this.lblFavoritesCaption.TabIndex = 0;
			this.lblFavoritesCaption.Text = "Favorites";
			// 
			// lblDefinedMessagesCaption
			// 
			this.lblDefinedMessagesCaption.BackColor = System.Drawing.Color.Navy;
			this.lblDefinedMessagesCaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDefinedMessagesCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblDefinedMessagesCaption.ForeColor = System.Drawing.Color.White;
			this.lblDefinedMessagesCaption.Location = new System.Drawing.Point(0, 0);
			this.lblDefinedMessagesCaption.Name = "lblDefinedMessagesCaption";
			this.lblDefinedMessagesCaption.Size = new System.Drawing.Size(366, 25);
			this.lblDefinedMessagesCaption.TabIndex = 1;
			this.lblDefinedMessagesCaption.Text = "Defined Messages";
			// 
			// lbFavorites
			// 
			this.lbFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbFavorites.FormattingEnabled = true;
			this.lbFavorites.Location = new System.Drawing.Point(0, 50);
			this.lbFavorites.Name = "lbFavorites";
			this.lbFavorites.Size = new System.Drawing.Size(184, 318);
			this.lbFavorites.TabIndex = 1;
			// 
			// lvDefinedMessages
			// 
			this.lvDefinedMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvDefinedMessages.Location = new System.Drawing.Point(0, 50);
			this.lvDefinedMessages.Name = "lvDefinedMessages";
			this.lvDefinedMessages.Size = new System.Drawing.Size(366, 318);
			this.lvDefinedMessages.TabIndex = 2;
			this.lvDefinedMessages.UseCompatibleStateImageBehavior = false;
			// 
			// tsFavoritesCommands
			// 
			this.tsFavoritesCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.tsFavoritesCommands.Location = new System.Drawing.Point(0, 25);
			this.tsFavoritesCommands.Name = "tsFavoritesCommands";
			this.tsFavoritesCommands.Size = new System.Drawing.Size(184, 25);
			this.tsFavoritesCommands.TabIndex = 2;
			this.tsFavoritesCommands.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// tsDefinedMessagesCommands
			// 
			this.tsDefinedMessagesCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
			this.tsDefinedMessagesCommands.Location = new System.Drawing.Point(0, 25);
			this.tsDefinedMessagesCommands.Name = "tsDefinedMessagesCommands";
			this.tsDefinedMessagesCommands.Size = new System.Drawing.Size(366, 25);
			this.tsDefinedMessagesCommands.TabIndex = 3;
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton1";
			// 
			// StartView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "StartView";
			this.Size = new System.Drawing.Size(554, 368);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tsFavoritesCommands.ResumeLayout(false);
			this.tsFavoritesCommands.PerformLayout();
			this.tsDefinedMessagesCommands.ResumeLayout(false);
			this.tsDefinedMessagesCommands.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox lbFavorites;
		private System.Windows.Forms.Label lblFavoritesCaption;
		private System.Windows.Forms.ListView lvDefinedMessages;
		private System.Windows.Forms.Label lblDefinedMessagesCaption;
		private System.Windows.Forms.ToolStrip tsFavoritesCommands;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip tsDefinedMessagesCommands;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}
