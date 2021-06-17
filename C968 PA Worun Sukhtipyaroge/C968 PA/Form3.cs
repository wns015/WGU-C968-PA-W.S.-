using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_PA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (Form1.modifyingItem == true)
            {
                //Make modify labels visible and set to current values
                currentLabel.Visible = true;
                updateLabel.Visible = true;
                currentName.Visible = true;
                currentPrice.Visible = true;
                currentStock.Visible = true;
                currentMin.Visible = true;
                currentMax.Visible = true;

                productIDNumber.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productID);
                currentName.Text = Inventory.Products[Form1.modifyProductIndex].productName;
                currentPrice.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productPrice);
                currentStock.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productStock);
                currentMin.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productMin);
                currentMax.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productMax);

                prodNameEntry.Text = Inventory.Products[Form1.modifyProductIndex].productName;
                prodPriceEntry.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productPrice);
                prodStockEntry.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productStock);
                prodMinEntry.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productMin);
                prodMaxEntry.Text = Convert.ToString(Inventory.Products[Form1.modifyProductIndex].productMax);

                NameWarning.Visible = false;
                PriceWarning.Visible = false;
                StockWarning.Visible = false;
                MinWarning.Visible = false;
                MaxWarning.Visible = false;

            } else
            {
                //Turn off visibility of modify labels for Add Part
                currentLabel.Visible = false;
                updateLabel.Visible = false;
                currentName.Visible = false;
                currentPrice.Visible = false;
                currentStock.Visible = false;
                currentMin.Visible = false;
                currentMax.Visible = false;

                //Initializing empty textfield color
                prodNameEntry.BackColor = Color.Yellow;
                prodPriceEntry.BackColor = Color.Yellow;
                prodStockEntry.BackColor = Color.Yellow;
                prodMinEntry.BackColor = Color.Yellow;
                prodMaxEntry.BackColor = Color.Yellow;

                //Auto-generate Product ID using first available number
                List<int> RecycleID = new List<int>();
                bool UsedID = false;
                foreach(var prod in Inventory.Products)
                {
                    RecycleID.Add(prod.productID);
                }
                for(int i = 1; i < RecycleID.Count + 1; i++)
                {
                    if(RecycleID.Contains(i) != true)
                    {
                        productIDNumber.Text = Convert.ToString(i);
                        UsedID = true;
                        break;
                    }
                }
                if (UsedID == false)
                {
                    productIDNumber.Text = Convert.ToString(Inventory.Products.Count + 1);
                }
                
                
            }
            addParts = new BindingList<Part>();
            if (Form1.modifyingItem == true)
            {
                PopulateAssociatedPartsGrid();
            }
            PopulatePartListGrid();

        }
        public static BindingList<Part> addParts;

        private void CancelAddProd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PopulatePartListGrid()
        {
            partListGrid.Rows.Clear();
            foreach (var part in Inventory.Parts)
            {
                var id = Convert.ToString(part.partID);
                var name = part.partName;
                var price = Convert.ToString(part.partPrice);
                var stock = Convert.ToString(part.partStock);
                string[] row = { id, name, price, stock };
                partListGrid.Rows.Add(row);
            }
        }

        private void PopulateAssociatedPartsGrid()
        {
            associatedGrid.Rows.Clear();
            if(Form1.modifyingItem == true)
            {
                foreach (var part in Inventory.Products[Form1.modifyProductIndex].AssociatedParts)
                {
                    addParts.Add(part);
                }
            }
            foreach (var addition in addParts)
            {
                var id = Convert.ToString(addition.partID);
                var name = addition.partName;
                var price = Convert.ToString(addition.partPrice);
                var stock = Convert.ToString(addition.partStock);
                string[] row = { id, name, price, stock };
                associatedGrid.Rows.Add(row);
            }

        }

        
        //Add Associated Part
        private void AddProductPart_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Inventory.Parts.Count; i++)
            {
                if (partListGrid.Rows[i].Selected == true)
                {
                    if(addParts.Contains(Inventory.Parts[i]) != true)
                    {
                        addParts.Add(Inventory.Parts[i]);
                        PopulateAssociatedPartsGrid();
                    }
                    
                }
            }
        }

        //Remove Associated Part
        private void RemoveProductPart_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < addParts.Count; i++)
            {
                if(associatedGrid.Rows[i].Selected == true)
                {
                    addParts.RemoveAt(i);
                    associatedGrid.Rows.RemoveAt(i);
                    PopulateAssociatedPartsGrid();
                }
            }    
        }

        //Adding or modifying a product
        private void SaveAddProd_Click(object sender, EventArgs e)
        {
            if(prodNameEntry.BackColor == Color.Yellow || prodPriceEntry.BackColor == Color.Yellow || prodStockEntry.BackColor == Color.Yellow || prodMinEntry.BackColor == Color.Yellow ||
                prodMaxEntry.BackColor == Color.Yellow)
            {
                const string message = "One or more entries are invalid or empty.";
                const string caption = "Add Product Error";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(productIDNumber.Text);
                string name = prodNameEntry.Text;
                decimal price = Convert.ToDecimal(prodPriceEntry.Text);
                int stock = Convert.ToInt32(prodStockEntry.Text);
                int min = Convert.ToInt32(prodMinEntry.Text);
                int max = Convert.ToInt32(prodMaxEntry.Text);
                Product newProduct = new Product(id, name, price, stock, min, max, addParts);
                
                if(addParts.Count == 0)
                {
                    const string message = "There are no associated parts. Do you want to continue adding/modifying this product?";
                    const string caption = "No Associated Parts";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if(result == DialogResult.OK)
                    {
                        if (Form1.modifyingItem == true)
                        {
                            Inventory.Products[Form1.modifyProductIndex] = newProduct;
                        }
                        else
                        {
                            Inventory.Products.Add(newProduct);
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                } else
                {
                    if (Form1.modifyingItem == true)
                    {
                        Inventory.Products[Form1.modifyProductIndex] = newProduct;
                    }
                    else
                    {
                        Inventory.Products.Add(newProduct);
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            
            

            
            
            
        }

        //Search funcitons for Parts and Associated Parts lists
        private void PartListSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Inventory.Parts.Count; i++)
            {
                if (Inventory.Parts[i].partName.Contains(partSearchBox.Text, StringComparison.OrdinalIgnoreCase) == true)
                {
                    partListGrid.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void AssociatedPartsSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < addParts.Count; i++)
            {
                if (addParts[i].partName.Contains(associatedSearchBox.Text, StringComparison.OrdinalIgnoreCase) == true)
                {
                    associatedGrid.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void prodNameEntry_TextChanged(object sender, EventArgs e)
        {
            if (prodNameEntry.Text.Trim() == string.Empty)
            {
                prodNameEntry.BackColor = Color.Yellow;
                NameWarning.Visible = true;
            }
            if (prodNameEntry.Text.Trim() != string.Empty)
            {
                prodNameEntry.BackColor = Color.White;
                NameWarning.Visible = false;
            }

        }

        private void prodPriceEntry_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;
            if (decimal.TryParse(prodPriceEntry.Text, out parsedValue) == true)
            {
                if (prodPriceEntry.Text.Trim() != string.Empty)
                {
                    prodPriceEntry.BackColor = Color.White;
                    PriceWarning.Visible = false;
                }
            }
            else
            {
                if (prodPriceEntry.Text.Trim() != string.Empty)
                {
                    prodPriceEntry.BackColor = Color.Yellow;
                    PriceWarning.Visible = true;
                    PriceWarning.Text = "Must be a number.";
                }
            }
            if (prodPriceEntry.Text.Trim() == string.Empty)
            {
                prodPriceEntry.BackColor = Color.Yellow;
                PriceWarning.Text = "Cannot be empty.";
                PriceWarning.Visible = true;

            }

        }

        private void prodStockEntry_TextChanged(object sender, EventArgs e)
        {
            int parsedStock;
            int parsedMin;
            int parsedMax;
            if (int.TryParse(prodStockEntry.Text, out parsedStock) == true && int.TryParse(prodMinEntry.Text, out parsedMin) == true && int.TryParse(prodMaxEntry.Text, out parsedMax) == true)
            {
                if (prodStockEntry.Text.Trim() != string.Empty && parsedStock <= parsedMax && parsedStock >= parsedMin)
                {
                    prodStockEntry.BackColor = Color.White;
                    StockWarning.Visible = false;
                    prodMinEntry.BackColor = Color.White;
                    MinWarning.Visible = false;
                    prodMaxEntry.BackColor = Color.White;
                    MaxWarning.Visible = false;
                }
                else if (prodStockEntry.Text.Trim() != string.Empty && parsedStock < parsedMin || parsedStock > parsedMax)
                {
                    prodStockEntry.BackColor = Color.Yellow;
                    StockWarning.Visible = true;
                    StockWarning.Text = "Must be between Min and Max.";
                }
            }
            else if (prodStockEntry.Text.Trim() != string.Empty && int.TryParse(prodStockEntry.Text, out parsedStock) == true && int.TryParse(prodMinEntry.Text, out parsedMin) == false || int.TryParse(prodMaxEntry.Text, out parsedMax) == false)
            {
                prodStockEntry.BackColor = Color.Yellow;
                StockWarning.Text = "Check Min and Max fields.";
                StockWarning.Visible = true;
            }
            else if (int.TryParse(prodStockEntry.Text, out parsedStock) == false && prodStockEntry.Text.Trim() != string.Empty)
            {
                prodStockEntry.BackColor = Color.Yellow;
                StockWarning.Visible = true;
                StockWarning.Text = "Must be a whole number.";
            }
            else if (prodStockEntry.Text.Trim() == string.Empty)
            {
                prodStockEntry.BackColor = Color.Yellow;
                StockWarning.Visible = true;
                StockWarning.Text = "Cannot be empty.";
            }
        }

        private void prodMinEntry_TextChanged(object sender, EventArgs e)
        {
            int parsedStock;
            int parsedMin;
            int parsedMax;
            if (int.TryParse(prodMaxEntry.Text, out parsedMax) == true && int.TryParse(prodMinEntry.Text, out parsedMin) == true && int.TryParse(prodStockEntry.Text, out parsedStock) == true)
            {
                if (prodMinEntry.Text.Trim() != string.Empty)
                {
                    if (parsedMin < parsedMax && parsedStock >= parsedMin && parsedStock <= parsedMax)
                    {
                        prodMinEntry.BackColor = Color.White;
                        MinWarning.Visible = false;
                        MaxWarning.Visible = false;
                        StockWarning.Visible = false;
                    }

                    else if (parsedMin >= parsedMax && parsedStock <= parsedMax)
                    {
                        prodMinEntry.BackColor = Color.Yellow;
                        MinWarning.Text = "Must be less than Max.";
                        MinWarning.Visible = true;
                        MaxWarning.Text = "Must be greater than Min.";
                        MaxWarning.Visible = true;
                        StockWarning.Visible = true;
                        StockWarning.Text = "Check Min and Max fields.";
                        prodStockEntry.BackColor = Color.Yellow;
                    }
                    else if (parsedMin > parsedStock)
                    {
                        prodMinEntry.BackColor = Color.Yellow;
                        MinWarning.Text = "Check Stock field.";
                        MinWarning.Visible = true;
                        StockWarning.Visible = true;
                        StockWarning.Text = "Must be between Min and Max";
                    }
                }

            }
            else if (int.TryParse(prodMaxEntry.Text, out parsedMax) == false && int.TryParse(prodMinEntry.Text, out parsedMin) == true)
            {
                prodMinEntry.BackColor = Color.Yellow;
                if (prodMinEntry.Text.Trim() != string.Empty)
                {
                    MinWarning.Visible = true;
                    MinWarning.Text = "Check Max field.";
                }
                else
                {
                    MinWarning.Visible = true;
                    MinWarning.Text = "Cannot be empty.";
                }
            }
            else if (int.TryParse(prodMinEntry.Text, out parsedMin) == false && prodMinEntry.Text.Trim() != string.Empty)
            {
                prodMinEntry.BackColor = Color.Yellow;
                MinWarning.Visible = true;
                MinWarning.Text = "Must be a whole number.";

            }
            else if (prodMinEntry.Text.Trim() == string.Empty)
            {
                prodMinEntry.BackColor = Color.Yellow;
                MinWarning.Visible = true;
                MinWarning.Text = "Cannot be empty.";
            }
        }

        private void prodMaxEntry_TextChanged(object sender, EventArgs e)
        {
            int parsedStock;
            int parsedMax;
            int parsedMin;
            if (int.TryParse(prodMaxEntry.Text, out parsedMax) == true && int.TryParse(prodMinEntry.Text, out parsedMin) == true && int.TryParse(prodStockEntry.Text, out parsedStock) == true)
            {
                if (prodMaxEntry.Text.Trim() != string.Empty)
                {
                    if (parsedMax > parsedMin && parsedStock <= parsedMax && parsedStock >= parsedMin)
                    {
                        prodMaxEntry.BackColor = Color.White;
                        prodMinEntry.BackColor = Color.White;
                        prodStockEntry.BackColor = Color.White;
                        MinWarning.Visible = false;
                        StockWarning.Visible = false;
                        MaxWarning.Visible = false;
                    }
                    else if (parsedMin > parsedMax && parsedMax >= parsedStock)
                    {
                        prodMaxEntry.BackColor = Color.Yellow;
                        prodMinEntry.BackColor = Color.Yellow;
                        prodStockEntry.BackColor = Color.Yellow;
                        MinWarning.Visible = true;
                        MinWarning.Text = "Must be less than Max.";
                        MaxWarning.Visible = true;
                        MaxWarning.Text = "Must be greater than Min.";
                        StockWarning.Visible = true;
                        StockWarning.Text = "Check Min and Max fields.";
                    }
                    else if (parsedMax < parsedStock)
                    {
                        prodMaxEntry.BackColor = Color.Yellow;
                        prodStockEntry.BackColor = Color.Yellow;
                        StockWarning.Text = "Must be between Min and Max";
                        StockWarning.Visible = true;
                        MaxWarning.Visible = true;
                        MaxWarning.Text = "Check Stock field.";
                    }
                }
            }
            else if (int.TryParse(prodMaxEntry.Text, out parsedMax) == true && int.TryParse(prodMinEntry.Text, out parsedMin) == false)
            {
                prodMaxEntry.BackColor = Color.Yellow;
                if (prodMaxEntry.Text.Trim() != string.Empty)
                {
                    MaxWarning.Visible = true;
                    MaxWarning.Text = "Check Min field.";
                }
                else
                {
                    MaxWarning.Visible = true;
                    MaxWarning.Text = "Cannot be empty.";
                }
            }
            else if (int.TryParse(prodMaxEntry.Text, out parsedMax) == false && prodMaxEntry.Text.Trim() != string.Empty)
            {
                prodMaxEntry.BackColor = Color.Yellow;
                MaxWarning.Visible = true;
                MaxWarning.Text = "Must be a whole number.";
            }

            if (prodMaxEntry.Text.Trim() == string.Empty)
            {
                prodMaxEntry.BackColor = Color.Yellow;
                MaxWarning.Visible = true;
                MaxWarning.Text = "Cannot be empty.";
            }

        }
    }
}
