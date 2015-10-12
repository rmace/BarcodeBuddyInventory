namespace BarcodeBuddyScan
{
    partial class Inventory
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
            this.inventoryFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(367, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(12, 13);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(104, 13);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "Inventory File Name:";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(501, 8);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(65, 28);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Browse...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // txtItemCount
            // 
            this.txtItemCount.Location = new System.Drawing.Point(121, 41);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.Size = new System.Drawing.Size(122, 20);
            this.txtItemCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Count:";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 106);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtFileName);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog inventoryFileDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox txtItemCount;
        private System.Windows.Forms.Label label1;
    }
}