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
Class Name:  Inventory
Description:  Inventory Form
   This form pops up whenever the user selects "Load Inventory File" from the
   context menu on the system tray icon.  From this form, the user can specify
   the file path for the inventory file and load it into memory.
   
Purpose:  This form is used to specify the Inventory Item file and load it into memory.

Theory of Operation

    At the top of the form, there is a textbox with the full path of the inventory
    filename and a Browse... button.
    When the user hits, the Browse... button,
    There is an OpenFileDialog named InventoryFileDialog that allows the user to
    select the filename.

    The form keeps up with the full path of the inventory file name and saves the
    full path to the App.config resources.

    When the form is first created, the creator should immediately follow with
    a call to the InitializeInventoryForm() method.  That method will attempt to
    load the default file path from the app.config resource and open the file and
    read the Inventory Items from it into memory.

Date:  10/09/2015
Programmer:  Russell Mace 
*/

using scanToolClasses;

namespace BarcodeBuddyScan
{
    public partial class Inventory : Form
    {
        /// <summary>
        /// This class represents the Inventory Form
        /// </summary>
        public Inventory()
        {
            InitializeComponent();
        }

        private string filePath;

        /// <summary>
        /// This method pops up an Open File Dialog to allow the user to select the
        /// Inventory file.
        /// </summary>
        private void selectFilePath()
        {
            try
            {
                inventoryFileDialog.CheckFileExists = true;
                inventoryFileDialog.CheckPathExists = true;
                inventoryFileDialog.FileName = filePath;
                inventoryFileDialog.Title = "Select Inventory Items File";
                DialogResult result = inventoryFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filePath = inventoryFileDialog.FileName;
                }
                else
                {
                    filePath = null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Inventory Form:selectFilePath() - Error while trying to select inventory file: " + exc.ToString());
            }
            txtFileName.Text = filePath;
        }

        /// <summary>
        /// This method attempts to open the inventory file and load the invenvtory
        /// items into memory.
        /// </summary>
        /// <returns>returns True if the form was initialized properly and the
        /// inventory items loaded into memory successfully.
        /// returns False otherwise
        /// </returns>
        public bool initializeInventoryForm()
        {
            bool inventoryItemsReady = false;
            filePath = Properties.Settings.Default.FilePath;
            txtFileName.Text = filePath;
            if (filePath == null || filePath.Length <= 0)
            {
                selectFilePath();
            }
            if (loadInventoryFile()) inventoryItemsReady = true;
            return inventoryItemsReady;
        }

        /// <summary>
        /// This method attempts to open the inventory file and load the invenvtory
        /// items into memory.
        /// </summary>
        /// <returns>returns True if the form was initialized properly and the
        /// inventory items loaded into memory successfully.
        /// returns False otherwise
        /// </returns>
        private bool loadInventoryFile()
        {
            bool fileLoadedSuccessfully = false;
            try
            {
                if (filePath != null && filePath.Length > 0)
                {
                    int numberOfItemsLoaded = inventoryItem.LoadItems(filePath);
                    if (numberOfItemsLoaded > 0)
                    {
                        fileLoadedSuccessfully = true;
                        Properties.Settings.Default.FilePath = filePath;
                        MessageBox.Show("Successfully Loaded " + numberOfItemsLoaded.ToString() + " Items.");
                    }
                    else
                    {
                        MessageBox.Show("No items could be loaded from file " + filePath + ". Please try again with a different filename.", "Load Inventory File", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Could not load inventory items because no filename has been given by the user.", "Inventory Form Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while trying to load item file: " + exc.ToString());
            }
            txtItemCount.Text = inventoryItem.itemDictionary.Count.ToString();
            return fileLoadedSuccessfully;
        }

        /// <summary>
        /// This method is called when the Browse... button is clicked on the form.
        /// It prompts the user for a file name and then tries to load the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            selectFilePath();
            loadInventoryFile();
            this.Hide();
        }
    }
}
