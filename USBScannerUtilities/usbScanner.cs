using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OposScanner_CCO;

namespace USBScannerUtilities
{
    public class usbScanner
    {
        private string scannerName;
        private OPOSScanner handHeldScanner;

        private void connectScanner()
        {
            try
            {
                if (handHeldScanner.Open("USBHHScanner") == 0)
                { 
                    handHeldScanner.ClaimDevice(0);
                    handHeldScanner.DeviceEnabled = true;
                    handHeldScanner.DataEvent += new _IOPOSScannerEvents_DataEventEventHandler(this.handHeldScanner_DataEvent);
                    handHeldScanner.DataEventEnabled = true;
                    handHeldScanner.DecodeData = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("inventoryControl:connectScanner - Failed to Open Connection to Scanner: " + exc.ToString());
            }
        }

    }
}
