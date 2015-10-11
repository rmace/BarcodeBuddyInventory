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

        private void insertItemIntoKeyboardBuffer(inventoryItem itm)
        {
            // do stuff here
        }

        private void handHeldScanner_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            // We got a scanner event!
            String scanData = handHeldScanner.ScanData.ToString();
            scanData = xmlIOUtilities.SanitizeXmlString(scanData);
            scanData = xmlIOUtilities.removeReturns(scanData);

            handHeldScanner.ClearInput();    // clear the data buffer
            handHeldScanner.DataEventEnabled = true;   // have to set true each time or it won't rescan

            // Now that we have the scan data, let's see if that barcode is already known.
            barcode b = barcode.findBarcode(scanData);
            if (b != null)
            {
                inventoryItem itm = b.getItem();
                if (itm != null)
                {
                    insertItemIntoKeyboardBuffer(itm);
                }
            }
            else
            {
                // ask the operator to identify the item that should go
                // with this barcode and update the inventory with the
                // newly selected barcode data.
            }
        }
    }
}
