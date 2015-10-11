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
            ((System.ComponentModel.ISupportInitialize)(this.handHeldScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // handHeldScanner
            // 
            this.handHeldScanner.Enabled = true;
            this.handHeldScanner.Location = new System.Drawing.Point(22, 227);
            this.handHeldScanner.Name = "handHeldScanner";
            this.handHeldScanner.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("handHeldScanner.OcxState")));
            this.handHeldScanner.Size = new System.Drawing.Size(192, 23);
            this.handHeldScanner.TabIndex = 0;
            this.handHeldScanner.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.handHeldScanner_DataEvent);
            // 
            // ScannerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.handHeldScanner);
            this.Name = "ScannerConfig";
            this.Text = "ScannerConfig";
            ((System.ComponentModel.ISupportInitialize)(this.handHeldScanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxOposScanner_CCO.AxOPOSScanner handHeldScanner;
    }
}