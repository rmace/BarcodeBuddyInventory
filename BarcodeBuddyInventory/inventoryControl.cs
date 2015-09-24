﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Class Name:  inventoryControl
Description:  Inventory Control Form
   This form is the main program window for the Barcode Buddy Inventory Tool.  The Barcode
   Buddy Inventory Tool allows the user to manipulate the list of inventory items and their 
   associated barcodes.  Tihe user can open an inventory file, import inventory items into the
   inventory list, navigate through the inventory items in the list, associated barcodes with
   the inventory items, and save the inventory items back into the barcode file, save them into
   a new inventory list, or merge the items into an existing barcode file.
   
Purpose:  This form is used to view and change inventory items with their associated barcodes

Theory of Operation

    
Date:  09/12/2015
Programmer:  Russell Mace 
*/

using scanToolClasses;
using ReadWriteCsv;

namespace BarcodeBuddyInventory
{
    public partial class inventoryControl : Form
    {
 
        public inventoryControl()
        {
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this code will execute when we click or otherwise activate the File->Import... button
            // Importing a file first brings up a file menu selection dialog.  After choosing a file,
            // we open it and make sure we can parse it correctly.  We expect a comma-delimited file
            // with two columns, an inventory item and a description.
            // This program parses each line of the file, and finds the item id in the linked list of
            // inventory items.  If it does not find the item, it adds it to the linked list along
            // with the description, otherwise it just changes the description.

            // first, let's select and open the desired file.
            try
            {
                DialogResult result = importFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // the file was opened, attempt to import the items.
                    int numberOfItemsImported = ItemImporter.importItems(importFileDialog.FileName);
                    if (numberOfItemsImported > 0)
                    {
                        // We imported some items, so let's update the item inventory list.
                        MessageBox.Show("Successfully Imported " + numberOfItemsImported.ToString() + " Items.");
                        updateInventoryList();
                        txtItemCount.Text = lstItems.Items.Count.ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while trying to import item file: " + exc.ToString());
            }
        }

        private void updateInventoryList()
        {
            Dictionary<string, inventoryItem> items = inventoryItem.itemDictionary;
            lstItems.Items.Clear();
            foreach (KeyValuePair<string, inventoryItem> entry in items)
            {
                lstItems.Items.Add(entry.Value);
            }
        }

        private void updateBarcodeList(inventoryItem itm)
        {
            lstBarcodes.Items.Clear();
            Dictionary<string, barcode> bcodes = itm.BarcodeList;
            foreach (KeyValuePair<string, barcode> b in bcodes)
            {
                lstBarcodes.Items.Add(b.Value);
            }
            
        }

        private void connectScanner()
        {
            try
            {
                handHeldScanner.BeginInit();
                if (handHeldScanner.Open("USBHHScanner") != 0)
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
                MessageBox.Show("inventoryControl:connectScanner - Failed to Open Connection to Scanner: " + exc.ToString());
            }
        }

        private void inventoryControl_Load(object sender, EventArgs e)
        {
            connectScanner();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventoryItem itm = (inventoryItem) lstItems.SelectedItem;
            updateBarcodeList(itm);
        }

        private void handHeldScanner_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            // We got a scanner event!
            String scanData = handHeldScanner.ScanData.ToString();
            scanData = xmlIOUtilities.SanitizeXmlString(scanData);
            handHeldScanner.ClearInput();    // clear the data buffer
            handHeldScanner.DataEventEnabled = true;   // have to set true each timeitem  or it won't rescan

            // Now that we have the scan data, let's see if that barcode is already known.
            inventoryItem itm = lookUpItem(scanData);
            if (itm != null)
            {
                // that barcode is already known, so position the item list to that item and refresh the barcode list
                lstItems.SelectedItem = itm;
                updateBarcodeList(itm);
            }
            else
            {
                // check if an item is selected in the item list.  If it is, assign this barcode to it.
                itm = (inventoryItem) lstItems.SelectedItem;
                if (itm == null)
                {
                    MessageBox.Show("No item is selected from list.  Please select an item before scanning a new barcode.");
                }
                else
                {
                    itm.assignBarcode(scanData);
                    updateBarcodeList(itm);
                }
            }
        }

        private inventoryItem lookUpItem(string strBarCode)
        {
            inventoryItem itm = null;
            barcode bcode = barcode.findBarcode(strBarCode);
            if (bcode != null)
            {
                itm = bcode.getItem();
            }
            return itm;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this code will execute when we click or otherwise activate the File->Load... button
            // Loading data from a file first brings up a file menu selection dialog.  After choosing a file,
            // we open it and make sure we can parse it correctly.  We expect a comma-delimited file
            // with two columns, an inventory item and a description.
            // This program parses each line of the file, and finds the item id in the linked list of
            // inventory items.  If it does not find the item, it adds it to the linked list along
            // with the description, otherwise it just changes the description.

            // first, let's select and open the desired file.
            try
            {
                DialogResult result = importFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // a filename was selected, let's load the items from the file.
                    saveFileDialog.FileName = importFileDialog.FileName;   // remember the filename for when we save later
                    int numberOfItemsLoaded = inventoryItem.LoadItems(importFileDialog.FileName);
                    if (numberOfItemsLoaded > 0)
                    {
                        // We loaded some items, so let's update the item inventory list.
                        MessageBox.Show("Successfully Loaded " + numberOfItemsLoaded.ToString() + " Items.");
                        updateInventoryList();
                        txtItemCount.Text = lstItems.Items.Count.ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while trying to load item file: " + exc.ToString());
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.AddExtension = true;
                saveFileDialog.CheckFileExists = true;
                saveFileDialog.OverwritePrompt = false;
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // a filename was selected for saving, so let's save the items into the file.
                    inventoryItem.mergeItemsIntoExistingFile(saveFileDialog.FileName);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while trying to save items into file: " + exc.ToString());
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".xml";
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // a filename was selected for saving, so let's save the items into the file.
                    int numberOfItemsSaved = inventoryItem.saveItems(saveFileDialog.FileName);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while trying to save items into file: " + exc.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
