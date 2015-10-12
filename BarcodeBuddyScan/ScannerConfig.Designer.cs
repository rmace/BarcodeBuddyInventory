namespace BarcodeBuddyScan
{
    partial class ScannerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerConfig));
            this.handHeldScanner = new AxOposScanner_CCO.AxOPOSScanner();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.handHeldScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // handHeldScanner
            // 
            this.handHeldScanner.Enabled = true;
            this.handHeldScanner.Location = new System.Drawing.Point(32, 42);
            this.handHeldScanner.Name = "handHeldScanner";
            this.handHeldScanner.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("handHeldScanner.OcxState")));
            this.handHeldScanner.Size = new System.Drawing.Size(192, 23);
            this.handHeldScanner.TabIndex = 0;
            this.handHeldScanner.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.handHeldScanner_DataEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This window is for future scanner support features.";
            // 
            // ScannerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 80);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handHeldScanner);
            this.Name = "ScannerConfig";
            this.Text = "ScannerConfig";
            ((System.ComponentModel.ISupportInitialize)(this.handHeldScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxOposScanner_CCO.AxOPOSScanner handHeldScanner;
        private System.Windows.Forms.Label label1;
    }
}