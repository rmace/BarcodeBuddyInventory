using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Class Name:  ScannerConfig
Description:  Scanner Configuration Form
   This form pops up on two conditions - if the scanner cannot be initialized
   during the program startup or if the user selects the Check USB Scanner menu
   from the system tray.
   
Purpose:  This form is used to manipulate the connection
          to the barcode scanner and to check its health.

Theory of Operation

    
Date:  10/09/2015
Programmer:  Russell Mace 
*/

using scanToolClasses;

namespace BarcodeBuddyScan
{
    public partial class ScannerConfig : Form
    {
        // private members
        private String scannerName;
        private chooseItem chooseForm;

        // The scanner name can be set and retrieved through this property
        public string ScannerName
        {
            get { return scannerName; }
            set { scannerName = value; }
        }

        public ScannerConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// connectScanner()
        /// This method attempts to connect to the scanner
        /// </summary>
        public void connectScanner()
        {
            try
            {
                handHeldScanner.BeginInit();
                if (handHeldScanner.Open(scannerName) != 0)
                {
                    MessageBox.Show("Failed to Open Connection to Scanner");
                }
                else
                {
                    handHeldScanner.ClaimDevice(0);
                    handHeldScanner.DeviceEnabled = true;
                    handHeldScanner.DataEventEnabled = true;
                    handHeldScanner.DecodeData = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("ScannerConfig:connectScanner - Failed to Open Connection to Scanner: " + exc.ToString());
            }
        }

        public void releaseScanner()
        {
            try
            {
                if (handHeldScanner != null)
                {
                    handHeldScanner.DataEventEnabled = false;
                    handHeldScanner.DeviceEnabled = false;
                    handHeldScanner.ReleaseDevice();
                    handHeldScanner.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("inventoryControl:releaseScanner - Failed to Release Connection to Scanner: " + exc.ToString());
            }
        }


        public void insertItemIntoKeyboardBuffer(inventoryItem itm)
        {
            System.Windows.Forms.SendKeys.Send(itm.ItemID + "\r");
        }

        private void handHeldScanner_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            // We got a scanner event!
            // First, let's turn it into text and get rid of any garbage characters
            // in it.  We want it safe for Xml and have no line feeds at the end.
            String scanData = handHeldScanner.ScanData.ToString();
            scanData = xmlIOUtilities.SanitizeXmlString(scanData);
            scanData = xmlIOUtilities.removeReturns(scanData);

            // release the scanner for next time so that it can give us the next scan.
            handHeldScanner.ClearInput();    // clear the data buffer
            handHeldScanner.DataEventEnabled = true;   // have to set true each time or it won't rescan

            // Now that we have the scan data, let's see if that barcode is already known.
            barcode b = barcode.findBarcode(scanData);
            if (b != null)
            {
                // Yay!  We found the barcode already in our list.
                // get the item that goes with it.
                inventoryItem itm = b.getItem();
                if (itm != null)
                {
                    // and put the item into the keyboard
                    insertItemIntoKeyboardBuffer(itm);
                }
            }
            else
            {
                // Dang.  We didn't find the barcode already in our list,
                // but that's ok.  We have a form that allows the user to
                // choose the item that goes with the barcode.
                // Create an instance of that form and populate it
                // with the barcode data, and pop it up on the screen.
                chooseForm = new chooseItem();
                chooseForm.ScannerFormReference = this;
                chooseForm.BarcodeData = scanData;
                chooseForm.Show();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (chooseForm != null)
            {
                chooseForm.Close();
            }
            base.OnFormClosed(e);
        }
    }
}
