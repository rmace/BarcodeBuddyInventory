namespace BarcodeBuddyInventory
{
    partial class inventoryControl
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
            this.mnuFileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.lblitemcount = new System.Windows.Forms.Label();
            this.lstviewItems = new System.Windows.Forms.ListView();
            this.mnuFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFileMenu
            // 
            this.mnuFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFileMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuFileMenu.Name = "mnuFileMenu";
            this.mnuFileMenu.Size = new System.Drawing.Size(659, 24);
            this.mnuFileMenu.TabIndex = 0;
            this.mnuFileMenu.Text = "FileMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "&Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(35, 44);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(313, 277);
            this.lstItems.TabIndex = 1;
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "[enter file to import]";
            // 
            // txtItemCount
            // 
            this.txtItemCount.Location = new System.Drawing.Point(105, 328);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.Size = new System.Drawing.Size(100, 20);
            this.txtItemCount.TabIndex = 2;
            // 
            // lblitemcount
            // 
            this.lblitemcount.AutoSize = true;
            this.lblitemcount.Location = new System.Drawing.Point(38, 331);
            this.lblitemcount.Name = "lblitemcount";
            this.lblitemcount.Size = new System.Drawing.Size(61, 13);
            this.lblitemcount.TabIndex = 3;
            this.lblitemcount.Text = "Item Count:";
            // 
            // lstviewItems
            // 
            this.lstviewItems.Location = new System.Drawing.Point(373, 44);
            this.lstviewItems.Name = "lstviewItems";
            this.lstviewItems.Size = new System.Drawing.Size(254, 277);
            this.lstviewItems.TabIndex = 4;
            this.lstviewItems.UseCompatibleStateImageBehavior = false;
            // 
            // inventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 417);
            this.Controls.Add(this.lstviewItems);
            this.Controls.Add(this.lblitemcount);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.mnuFileMenu);
            this.MainMenuStrip = this.mnuFileMenu;
            this.Name = "inventoryControl";
            this.Text = "Barcode Buddy Inventory Control";
            this.mnuFileMenu.ResumeLayout(false);
            this.mnuFileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.TextBox txtItemCount;
        private System.Windows.Forms.Label lblitemcount;
        private System.Windows.Forms.ListView lstviewItems;
    }
}

