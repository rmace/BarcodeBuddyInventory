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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private string filePath;

        public void selectFilePath()
        {
            try
            {
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

        }

        public bool initializeInventoryForm()
        {
            bool inventoryItemsReady = false;
            filePath = Properties.Settings.Default.FilePath;
            if (filePath == null)
            {
                selectFilePath();
                if (filePath != null)
                {
                    try
                    {
                        if (loadInventoryFile()) inventoryItemsReady = true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Inventory Form::initializeInventoryForm() - Error while trying to load item file: " + exc.ToString());
                    }
                }
            }
            return inventoryItemsReady;
        }
        
        public bool loadInventoryFile()
        {
            bool fileLoadedSuccessfully = false;
            try
            {
                int numberOfItemsLoaded = inventoryItem.LoadItems(filePath);
                if (numberOfItemsLoaded > 0)
                {
                    // We loaded some items, so let's update the item inventory list.
                    MessageBox.Show("Successfully Loaded " + numberOfItemsLoaded.ToString() + " Items.");
                    //updateInventoryList();
                    //txtItemCount.Text = lstItems.Items.Count.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while trying to load item file: " + exc.ToString());
            }
            return fileLoadedSuccessfully;
        }
    }
}
