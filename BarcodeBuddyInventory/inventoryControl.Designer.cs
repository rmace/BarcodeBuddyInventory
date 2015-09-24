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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryControl));
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
            this.handHeldScanner = new AxOposScanner_CCO.AxOPOSScanner();
            this.lstBarcodes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mnuFileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handHeldScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFileMenu
            // 
            this.mnuFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFileMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuFileMenu.Name = "mnuFileMenu";
            this.mnuFileMenu.Size = new System.Drawing.Size(917, 24);
            this.mnuFileMenu.TabIndex = 0;
            this.mnuFileMenu.Text = "FileMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Load File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
            this.lstItems.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 14;
            this.lstItems.Location = new System.Drawing.Point(35, 72);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(588, 270);
            this.lstItems.TabIndex = 1;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "[enter file to import]";
            // 
            // txtItemCount
            // 
            this.txtItemCount.Location = new System.Drawing.Point(106, 349);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.Size = new System.Drawing.Size(100, 20);
            this.txtItemCount.TabIndex = 2;
            // 
            // lblitemcount
            // 
            this.lblitemcount.AutoSize = true;
            this.lblitemcount.Location = new System.Drawing.Point(39, 352);
            this.lblitemcount.Name = "lblitemcount";
            this.lblitemcount.Size = new System.Drawing.Size(61, 13);
            this.lblitemcount.TabIndex = 3;
            this.lblitemcount.Text = "Item Count:";
            // 
            // handHeldScanner
            // 
            this.handHeldScanner.Enabled = true;
            this.handHeldScanner.Location = new System.Drawing.Point(35, 375);
            this.handHeldScanner.Name = "handHeldScanner";
            this.handHeldScanner.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("handHeldScanner.OcxState")));
            this.handHeldScanner.Size = new System.Drawing.Size(192, 30);
            this.handHeldScanner.TabIndex = 4;
            this.handHeldScanner.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.handHeldScanner_DataEvent);
            // 
            // lstBarcodes
            // 
            this.lstBarcodes.FormattingEnabled = true;
            this.lstBarcodes.Location = new System.Drawing.Point(641, 88);
            this.lstBarcodes.Name = "lstBarcodes";
            this.lstBarcodes.Size = new System.Drawing.Size(173, 238);
            this.lstBarcodes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Associated Barcodes";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // inventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBarcodes);
            this.Controls.Add(this.handHeldScanner);
            this.Controls.Add(this.lblitemcount);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.mnuFileMenu);
            this.MainMenuStrip = this.mnuFileMenu;
            this.Name = "inventoryControl";
            this.Text = "Barcode Buddy Inventory Control";
            this.Load += new System.EventHandler(this.inventoryControl_Load);
            this.mnuFileMenu.ResumeLayout(false);
            this.mnuFileMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handHeldScanner)).EndInit();
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
        private AxOposScanner_CCO.AxOPOSScanner handHeldScanner;
        private System.Windows.Forms.ListBox lstBarcodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

