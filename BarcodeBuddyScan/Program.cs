using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Project/Program Name:  BarcodeBuddyScan
Description:  Program.cs
The BarcodeBuddyScan program resides in the System Tray in Window 7.  On startup, it claims the
UPS barcode scanner and loads the Barcode Buddy Inventory Item file.  It pops up a dialog asking
the user to select the inventory file.  After that, it simply waits for a scan input.  When it
detects a scanner input, it finds the associated item in the item file, and then insert that
item into the keyboard buffer followed by a carriage return character.  If it does not find an
associated item, it pops up a window and asks the user to select an item from the list.  After
the user selects the item and doesn't hit cancel, the new item is inserted into the keyboard
buffer and the new item association is saved to the inventory file.

Purpose:  This is the main entry point of the application.  It implements a system tray app
    
Theory of Operation:

    A large portion of the code used in this progam is described in an article I found online
    at this link:

https://www.simple-talk.com/dotnet/.net-framework/creating-tray-applications-in-.net-a-practical-guide/

In order to create a system tray application, we have to modify how this Windows Forms application
starts up by default.  Normally, the first thing it does is open up a form.  We replace that
behavior with opening up a custom application that doesn't have a form, but instead has a
NotifyIcon.  Instantiating the NotifyIcon is what puts the icon in the system tray.

Classes used by this program.

    CustomApplicationContext - this class takes the place of the main form.

Date:  10/09/2015
Programmer:  Russell Mace 
*/

using AppControlUtilities;

namespace BarcodeBuddyScan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // First, we make sure that there are no other instances of this
            // program already running. If there are, then we just quit.
            if(!SingleInstance.Start()) { return; }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Here, we deviate from the default behavior and we don't open the main form
            // for the application.  Instead, we create a custom application environment
            // for our program to run in.
            try
            {
                var applicationContext = new CustomApplicationContext();
                Application.Run(applicationContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Terminated Unexpectedly",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                SingleInstance.Stop();
                Properties.Settings.Default.Save();
            }
        }
    }
}
