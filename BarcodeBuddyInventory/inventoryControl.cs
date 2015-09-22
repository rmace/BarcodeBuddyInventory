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
            LinkedList<inventoryItem> items = inventoryItem.itemList;
            lstItems.Items.Clear();
            foreach (inventoryItem item in items)
            {
                lstItems.Items.Add(item);
            }
        }
    }
}
