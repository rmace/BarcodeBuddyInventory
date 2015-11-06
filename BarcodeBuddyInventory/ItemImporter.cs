using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   // needed for MessageBox

/*
Namespace:  BarcodeBuddyInventory
Class Names:  ItemImporter  
Description:  This class simply imports items from a comma-separated value file
into the list of inventory items.

Theory of Operation:

    This isn't really a class that is intended to have instances of the class created.
    Its real intent is to just contain static methods that can be used in other parts of the program.

Date:  09/18/2015
Programmer:  Russell Mace 
*/

using ReadWriteCsv;
using scanToolClasses;

namespace BarcodeBuddyInventory
{
    class ItemImporter
    {
        /// <summary>
        /// Opens a csv file and imports the items into the inventory Item list
        /// </summary>
        /// <param name="itemFile">The .csv File containing the items to import</param>
        public static int importItems(string itemFile)
        {
            int importCount = 0;
            int parseItemCount = 0;
            string itemNumber = null;
            string itemDescription = null;
            inventoryItem foundItem;
            try
            {
                // The file is assumed to be a comma-seperated value file
                // with the first value being an item number and the second
                // value being a description
                CsvFileReader reader = new CsvFileReader(itemFile);
                CsvRow row = new CsvRow();

                // let's parse each row in the file one at a time.
                while (reader.ReadRow(row))
                {
                    parseItemCount = 0;
                    itemNumber = null;
                    itemDescription = null;
                    // let's examine the values in each row.  There should be two, an item number and a description.
                    foreach (string s in row)
                    {
                        if (parseItemCount == 0) itemNumber = xmlIOUtilities.SanitizeXmlString(s);   // the first value should be the item ID
                        if (parseItemCount == 1) itemDescription = xmlIOUtilities.SanitizeXmlString(s);   // the second value should be the description
                        parseItemCount++;
                    }
                    // ok, so we've parsed that line and thrown away anything except the first two values.
                    // let's make sure we got a valid item ID value
                    if (itemNumber != null && itemNumber.Length > 0)
                    {
                        // we did get a valid item ID value, so let's check if it's already in our list of items
                        if (inventoryItem.itemDictionary.TryGetValue(itemNumber, out foundItem))
                        {
                            // it is already in our list of items, so let's update the description
                            // but only if the description is also a valid string.
                            if (itemDescription != null && itemDescription.Length > 0 && itemDescription != foundItem.Description)
                            {
                                foundItem.Description = itemDescription;
                                importCount++;
                            }
                        }
                        else
                        {
                            foundItem = new inventoryItem(itemNumber, itemDescription);
                            importCount++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to open import file " + itemFile + ": " + ex.ToString());
            }

            return importCount;
        }
    }
}
