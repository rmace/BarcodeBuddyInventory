
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Class Name:  CustomApplicationContext
Derives From:  ApplicationContext
Description:  Custom Application Context
   This class is used to implement a system tray application.  It acts as the main controller
   for the application, and kind of takes the place of the main form for the app.

Theory of Operation

  During the program startup, in the Program.cs main, an instance of this
  CustomApplicationContext is created, and then the Run method is called on it.
  When that Run method is called, then this class takes over the application and
  manages it from there.

  The first thing that happens is the constructor is called, and everything gets
  initialized.   We create a notifyIcon on the system tray and give it a menu.
  We create a Scanner Configuration Form and then tell it to connect
  to the scanner. 
  We create a Load Inventory Form and then tell it to load the inventory file
  into memory.
  Finally, we create a Choose Item Form.

  After that, the application reacts to the following events:

    the scanner triggers an event and sends us some data - this event is handled
    by an event handler on the Scanner Configuration Form.  It basically looks up
    the item corresponding to the scanned data and puts it in the keyboard buffer.
    In the event that the scanned barcode data isn't in memory and has never been
    assigned to an item, then the application opens the Choose Item form and allows
    the user to select the item that he wishes to associate with the new barcode.
    You can look at the Scanner Configuration Form for details.

    the user opens the system tray icon menu and selects "Scanner Configuration".
    When that happens, we load the Scanner Configuration Form and give it focus.
    The user can use the scanner configuration form to check the health of the
    scanner.

    the user opens the system tray icon menu and selects "Load Inventory File".
    When that happens, we load the Inventory Form and give it focus.  The user can
    use the Inventory form to specify the Inventory filename and load it into memory.
    
Date:  10/09/2015
Programmer:  Russell Mace 
*/

using System;
using System.Drawing;
using System.Windows.Forms;  // gives us the ApplicationContext classs
using System.Reflection;

namespace BarcodeBuddyScan
{
    /// <summary>
    /// Framework for running application as a tray app.
    /// </summary>
    /// <remarks>
    /// Tray app code adapted from "Creating Applications with NotifyIcon 
    /// in Windows Forms", Jessica Fosler,
    /// http://windowsclient.net/articles/notifyiconapplications.aspx
    /// </remarks>
    public class CustomApplicationContext : ApplicationContext
    {
        // Icon graphic from www.iconarchive.com
        private static readonly string DefaultTooltip = "Barcode Buddy Scan Tool";

        /// <summary>
        /// This class should be created and passed into Application.Run( ... )
        /// </summary>

        /// <summary>
        /// The constructor for the CustomApplicationContext class.
        /// It performs all the initialization for the program, putting the icon
        /// in the system tray, building a menu for it, and then initializing all
        /// the forms with their data.
        /// </summary>
        public CustomApplicationContext()
        {
            InitializeContext();
            BuildMenu();
            InitializeScannerConfigForm();
            InitializeInventoryForm();
        }

        #region Initialization Methods

        /// <summary>
        /// BuildMenu populates the context menu.  It will have the following entries:
        /// Scanner Configuration
        /// Load Inventory File
        /// Exit
        /// </summary>
        private void BuildMenu()
        {
            ToolStripMenuItem t;
            t = CreateToolStripItemWithHandler(
                "&Scanner Configuration",
                "Open the Scanner Configuration Window to Troubleshoot the Scanner",
                scannerConfiguration_Click);
            if (t != null) notifyIcon.ContextMenuStrip.Items.Add(t);
            t = CreateToolStripItemWithHandler(
                "&Load Inventory File",
                "Specify and Load the file that contains all the inventory items.",
                loadInventory_Click);
            if (t != null) notifyIcon.ContextMenuStrip.Items.Add(t);
            t = CreateToolStripItemWithHandler(
                "&Exit",
                "Exit the Barcode Buddy Scan application",
                exitItem_Click);
            if (t != null) notifyIcon.ContextMenuStrip.Items.Add(t);
        }

        /// <summary>
        /// This method creates a ScannerConfig form and connects it to the scanner.
        /// </summary>
        private void InitializeScannerConfigForm()
        {
            if (scanForm == null)
            {
                scanForm = new ScannerConfig { ScannerName = Properties.Settings.Default.USBScannerName };
            }
            scanForm.FormClosed += scanForm_Closed;
            scanForm.connectScanner();
        }

        private void InitializeInventoryForm()
        {
            if (inventoryForm == null)
            {
                inventoryForm = new Inventory();
            }
            inventoryForm.FormClosed += inventoryForm_Closed;
            inventoryForm.initializeInventoryForm();

        }
        #endregion Initialization Methods

        #region the child forms

        private ScannerConfig scanForm;
        private Inventory inventoryForm;

          
        private void ShowScanForm()
        {
            try
            {
                if (scanForm == null)
                {
                    InitializeScannerConfigForm();
                }
                scanForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error while attempting to show the Scanner Configuration form: " + ex.ToString(), "Load Inventory File", MessageBoxButtons.OK);
            }
        }


        private void ShowInventoryLoadForm()
        {
            try
            {
                if (inventoryForm == null)
                {
                    InitializeInventoryForm();
                }
                inventoryForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error while attempting to show the Inventory Load form: " + ex.ToString(), "Load Inventory File", MessageBoxButtons.OK);
            }
        }

        // From http://stackoverflow.com/questions/2208690/invoke-notifyicons-context-menu
        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(notifyIcon, null);
            }
        }

        // null out the forms so we know to create a new one.
        private void scanForm_Closed(object sender, EventArgs e) { scanForm = null; }
        private void inventoryForm_Closed(object sender, EventArgs e) { inventoryForm = null; }

        #endregion the child forms

        #region generic code framework

        private System.ComponentModel.IContainer components;    // a list of components to dispose when the context is disposed
        private NotifyIcon notifyIcon;                          // the icon that sits in the system tray

        private void scannerConfiguration_Click(object sender, EventArgs e)
        {
            ShowScanForm();
        }

        private void loadInventory_Click(object sender, EventArgs e)
        {
            ShowInventoryLoadForm();
        }

        /// <summary>
        /// When the exit menu item is clicked, make a call to terminate the ApplicationContext.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        /// <summary>
        /// This method creates a Tool Strip Menu Item that displays the
        /// "displayText" with the "toolTipText" as a tooltip, and associates
       ///  the provided "eventHandler" so that it
        /// triggers when the item is clicked.
        /// </summary>
        /// <param name="displayText"></param>
        /// <param name="toolTipText"></param>
        /// <param name="disableCount"></param>
        /// <param name="eventHandler"></param>
        /// <returns></returns>
        private ToolStripMenuItem CreateToolStripItemWithHandler(
            string displayText, string toolTipText, EventHandler eventHandler)
        {
            var item = new ToolStripMenuItem(displayText);
            if (eventHandler != null) { item.Click += eventHandler; }
            item.ToolTipText = toolTipText;
            return item;
        }

        /// <summary>
        /// If we are presently showing a form, clean it up.
        /// </summary>
        protected override void ExitThreadCore()
        {
            // before we exit, let forms clean themselves up.
            // if we don't, the program can never really exit.
            if (scanForm != null) { scanForm.Close(); }
            if (inventoryForm != null) { inventoryForm.Close(); }

            notifyIcon.Visible = false; // should remove lingering tray icon
            base.ExitThreadCore();
        }
        
        /// <summary>
        /// InitializeContext is called upon startup.
        /// It creates the icon in the system tray.
        /// </summary>
        private void InitializeContext()
        {
            components = new System.ComponentModel.Container();
            // Instantiating this notifyIcon puts it in the system tray.
            notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Properties.Resources.BarcodeScannerIcon,
                Text = DefaultTooltip,
                Visible = true
            };
        }

        /// <summary>
        /// When the application context is disposed, dispose things like the notify icon.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) { components.Dispose(); }
        }


        #endregion generic code framework
    }
}
