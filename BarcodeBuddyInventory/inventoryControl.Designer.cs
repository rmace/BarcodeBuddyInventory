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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.lblitemcount = new System.Windows.Forms.Label();
            this.handHeldScanner = new AxOposScanner_CCO.AxOPOSScanner();
            this.lstBarcodes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoToItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoToDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGoToDescription = new System.Windows.Forms.Button();
            this.btnRemoveBarcode = new System.Windows.Forms.Button();
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
            this.mnuFileMenu.Size = new System.Drawing.Size(973, 24);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openToolStripMenuItem.Text = "&Load File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.importToolStripMenuItem.Text = "&Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.handHeldScanner.Size = new System.Drawing.Size(192, 192);
            this.handHeldScanner.TabIndex = 4;
            this.handHeldScanner.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.handHeldScanner_DataEvent);
            // 
            // lstBarcodes
            // 
            this.lstBarcodes.FormattingEnabled = true;
            this.lstBarcodes.Location = new System.Drawing.Point(639, 72);
            this.lstBarcodes.Name = "lstBarcodes";
            this.lstBarcodes.Size = new System.Drawing.Size(173, 212);
            this.lstBarcodes.TabIndex = 5;
            this.lstBarcodes.SelectedIndexChanged += new System.EventHandler(this.lstBarcodes_SelectedIndexChanged);
            this.lstBarcodes.Leave += new System.EventHandler(this.lstBarcodes_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Associated Barcodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inventory Items";
            // 
            // txtGoToItem
            // 
            this.txtGoToItem.Location = new System.Drawing.Point(315, 349);
            this.txtGoToItem.Name = "txtGoToItem";
            this.txtGoToItem.Size = new System.Drawing.Size(308, 20);
            this.txtGoToItem.TabIndex = 8;
            this.txtGoToItem.TextChanged += new System.EventHandler(this.txtGoToItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Go To Item:";
            // 
            // txtGoToDescription
            // 
            this.txtGoToDescription.Location = new System.Drawing.Point(315, 378);
            this.txtGoToDescription.Name = "txtGoToDescription";
            this.txtGoToDescription.Size = new System.Drawing.Size(307, 20);
            this.txtGoToDescription.TabIndex = 10;
            this.txtGoToDescription.TextChanged += new System.EventHandler(this.txtGoToDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGoToDescription
            // 
            this.btnGoToDescription.Location = new System.Drawing.Point(629, 366);
            this.btnGoToDescription.Name = "btnGoToDescription";
            this.btnGoToDescription.Size = new System.Drawing.Size(92, 43);
            this.btnGoToDescription.TabIndex = 12;
            this.btnGoToDescription.Text = "Search for Description";
            this.btnGoToDescription.UseVisualStyleBackColor = true;
            this.btnGoToDescription.Click += new System.EventHandler(this.btnGoToDescription_Click);
            // 
            // btnRemoveBarcode
            // 
            this.btnRemoveBarcode.Enabled = false;
            this.btnRemoveBarcode.Location = new System.Drawing.Point(818, 72);
            this.btnRemoveBarcode.Name = "btnRemoveBarcode";
            this.btnRemoveBarcode.Size = new System.Drawing.Size(75, 40);
            this.btnRemoveBarcode.TabIndex = 13;
            this.btnRemoveBarcode.Text = "Remove Barcode";
            this.btnRemoveBarcode.UseVisualStyleBackColor = true;
            this.btnRemoveBarcode.Click += new System.EventHandler(this.btnRemoveBarcode_Click);
            // 
            // inventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 417);
            this.Controls.Add(this.btnRemoveBarcode);
            this.Controls.Add(this.btnGoToDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGoToDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGoToItem);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoToItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGoToDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGoToDescription;
        private System.Windows.Forms.Button btnRemoveBarcode;
    }
}

