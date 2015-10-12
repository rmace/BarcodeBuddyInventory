using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using scanToolClasses;

namespace BarcodeBuddyScan
{
    public partial class chooseItem : Form
    {
        private string barcodeData;
        private AutoCompleteStringCollection ItemCollection;
        private ScannerConfig scannerFormReference;

        public string BarcodeData
        {
            get { return barcodeData; }
            set
            {
                barcodeData = value;
                txtScanData.Text = barcodeData;
            }
        }

        public ScannerConfig ScannerFormReference
        {
            get { return scannerFormReference; }
            set { scannerFormReference = value; }
        }

        public chooseItem()
        {
            InitializeComponent();
        }

        private void chooseItem_Load(object sender, EventArgs e)
        {
            txtScanData.Text = barcodeData;
            updateInventoryList();
        }

        private void prepareGoToItem()
        {
            txtGoToItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtGoToItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGoToItem.AutoCompleteCustomSource = ItemCollection;
        }

        private void txtGoToItem_TextChanged(object sender, EventArgs e)
        {
            // Now that we have an item, let's position the item list at that item.
            int index = txtGoToItem.Text.IndexOf(",");
            if (index > 0)
            {
                inventoryItem itm = inventoryItem.lookUpItem(txtGoToItem.Text.Substring(0, index));
                if (itm != null)
                {
                    // position the item list to that item
                    lstItems.SelectedItem = itm;
                }
            }
        }

        private void updateInventoryList()
        {
            Dictionary<string, inventoryItem> items = inventoryItem.itemDictionary;
            lstItems.Items.Clear();
            ItemCollection = new AutoCompleteStringCollection();
            foreach (KeyValuePair<string, inventoryItem> entry in items)
            {
                lstItems.Items.Add(entry.Value);
                ItemCollection.Add(entry.Key + ", " + entry.Value.Description);
            }
            prepareGoToItem();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // So the operator has scanned a new barcode, and now he has selected the
            // associated item from the list.  We want to do several things here:
            // We want to save the new barcode association to the inventory file.
            // We want to close the current form so that the focus returns to whatever
            // screen previously had focus 
            // and finally, we want to put the newly selected item into the keyboard buffer.
            inventoryItem i = (inventoryItem)lstItems.SelectedItem;
            barcode b = new barcode(BarcodeData, i);
            inventoryItem.mergeItemsIntoExistingFile(Properties.Settings.Default.FilePath);

            this.Close();
            scannerFormReference.insertItemIntoKeyboardBuffer((inventoryItem)lstItems.SelectedItem);
        }
    }
}
