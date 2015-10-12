namespace BarcodeBuddyScan
{
    partial class chooseItem
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
            this.txtScanData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoToItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScanData
            // 
            this.txtScanData.Location = new System.Drawing.Point(96, 13);
            this.txtScanData.Name = "txtScanData";
            this.txtScanData.Size = new System.Drawing.Size(194, 20);
            this.txtScanData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode Data:";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(96, 65);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(583, 225);
            this.lstItems.TabIndex = 2;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click Item to Select:";
            // 
            // txtGoToItem
            // 
            this.txtGoToItem.Location = new System.Drawing.Point(98, 300);
            this.txtGoToItem.Name = "txtGoToItem";
            this.txtGoToItem.Size = new System.Drawing.Size(369, 20);
            this.txtGoToItem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Go To Item:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(586, 300);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 38);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // chooseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 373);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGoToItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanData);
            this.Name = "chooseItem";
            this.Text = "chooseItem";
            this.Load += new System.EventHandler(this.chooseItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScanData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoToItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
    }
}