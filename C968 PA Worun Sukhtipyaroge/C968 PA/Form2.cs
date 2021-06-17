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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //Initializing for modifying a part
            if (Form1.modifyingItem == true)
            {
                partIDNumber.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partID);
                currentName.Text = Inventory.Parts[Form1.modifyPartIndex].partName;
                currentPrice.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partPrice);
                currentStock.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partStock);
                currentMin.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partMin);
                currentMax.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partMax);

                currentName.Visible = true;
                currentPrice.Visible = true;
                currentStock.Visible = true;
                currentMin.Visible = true;
                currentMax.Visible = true;
                currentIHO.Visible = true;

                partNameEntry.Text = Inventory.Parts[Form1.modifyPartIndex].partName;
                partPriceEntry.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partPrice);
                partStockEntry.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partStock);
                partMinEntry.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partMin);
                partMaxEntry.Text = Convert.ToString(Inventory.Parts[Form1.modifyPartIndex].partMax);

                if (Inventory.Parts[Form1.modifyPartIndex] is InHouse)
                {
                    IHOLabel.Text = "Machine ID";
                    inHouseRadio.Checked = true;
                    currentIHO.Text = Convert.ToString(((InHouse)Inventory.Parts[Form1.modifyPartIndex]).machineID);
                    IHOEntry.Text = Convert.ToString(((InHouse)Inventory.Parts[Form1.modifyPartIndex]).machineID);
                }
                else
                {
                    IHOLabel.Text = "Company Name";
                    outsourcedRadio.Checked = true;
                    currentIHO.Text = ((Outsourced)Inventory.Parts[Form1.modifyPartIndex]).companyName;
                    IHOEntry.Text = ((Outsourced)Inventory.Parts[Form1.modifyPartIndex]).companyName;
                }
            }
            //Initializing for adding a new part
            else
            {
                IHOLabel.Text = "Machine ID";

                //Auto-generate Part ID using first available number
                List<int> RecycleID = new List<int>();
                bool UsedID = false;
                foreach (var part in Inventory.Parts)
                {
                    RecycleID.Add(part.partID);
                }
                for (int i = 1; i < RecycleID.Count + 1; i++)
                {
                    if (RecycleID.Contains(i) != true)
                    {
                        partIDNumber.Text = Convert.ToString(i);
                        UsedID = true;
                        break;
                    }
                }
                if (UsedID == false)
                {
                    partIDNumber.Text = Convert.ToString(Inventory.Parts.Count + 1);
                }

                //Initializing empty textfield color
                partNameEntry.BackColor = Color.Yellow;
                partPriceEntry.BackColor = Color.Yellow;
                partStockEntry.BackColor = Color.Yellow;
                partMinEntry.BackColor = Color.Yellow;
                partMaxEntry.BackColor = Color.Yellow;
                IHOEntry.BackColor = Color.Yellow;
            }
        }

        private void outsourceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(outsourcedRadio.Checked == true)
            {
                IHOLabel.Text = "Company Name";
                if(IHOEntry.Text.Trim() != string.Empty)
                {
                    IHOEntry.BackColor = Color.White;
                }
            }
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(inHouseRadio.Checked == true)
            {
                IHOLabel.Text = "Machine ID";
                if(IHOEntry.Text.Trim() != string.Empty)
                {
                    int parsedValue;
                    if(int.TryParse(IHOEntry.Text, out parsedValue) == false)
                    {
                        IHOEntry.BackColor = Color.Yellow;
                    }
                }
                
            }
        }

        private void cancelAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Adding a part
        private void saveAddPart_Click(object sender, EventArgs e)
        {
            if(partNameEntry.BackColor == Color.Yellow || partPriceEntry.BackColor == Color.Yellow || partStockEntry.BackColor == Color.Yellow || partMinEntry.BackColor == Color.Yellow 
                || partMaxEntry.BackColor == Color.Yellow || IHOEntry.BackColor == Color.Yellow)
            {
                const string message = "One or more entries are empty or invalid.";
                const string caption = "Error Adding Part";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if(Form1.modifyingItem == true)
                {
                    ModifyPart();
                } else
                {
                    AddPart();
                }
                
                this.DialogResult = DialogResult.OK;
            }
            
        }

       

        //Function to add a part
        private void AddPart()
        {
            int id = Convert.ToInt32(partIDNumber.Text);
            string name = partNameEntry.Text;
            decimal price = Convert.ToDecimal(partPriceEntry.Text);
            int stock = Convert.ToInt32(partStockEntry.Text);
            int min = Convert.ToInt32(partMinEntry.Text);
            int max = Convert.ToInt32(partMaxEntry.Text);
            if(inHouseRadio.Checked == true)
            {
                int mid = Convert.ToInt32(IHOEntry.Text);
                Inventory.Parts.Add(new InHouse(id, name, price, stock, min, max, mid));
            } else if (outsourcedRadio.Checked == true)
            {
                string company = IHOEntry.Text;
                Inventory.Parts.Add(new Outsourced(id, name, price, stock, min, max, company));
            }
        }

        //Modify part function
        private void ModifyPart()
        {
            if (Inventory.Parts[Form1.modifyPartIndex] is InHouse && outsourcedRadio.Checked == true)
            {
                int id = Inventory.Parts[Form1.modifyPartIndex].partID;
                string name = partNameEntry.Text;
                decimal price = Convert.ToDecimal(partPriceEntry.Text);
                int stock = Convert.ToInt32(partStockEntry.Text);
                int min = Convert.ToInt32(partMinEntry.Text);
                int max = Convert.ToInt32(partMaxEntry.Text);
                string company = IHOEntry.Text;
                Inventory.Parts[Form1.modifyPartIndex] = new Outsourced(id, name, price, stock, min, max, company);
            }
            else if (Inventory.Parts[Form1.modifyPartIndex] is Outsourced && inHouseRadio.Checked == true)
            {
                int id = Inventory.Parts[Form1.modifyPartIndex].partID;
                string name = partNameEntry.Text;
                decimal price = Convert.ToDecimal(partPriceEntry.Text);
                int stock = Convert.ToInt32(partStockEntry.Text);
                int min = Convert.ToInt32(partMinEntry.Text);
                int max = Convert.ToInt32(partMaxEntry.Text);
                int mid = Convert.ToInt32(IHOEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex] = new InHouse(id, name, price, stock, min, max, mid);
            }
            else if (Inventory.Parts[Form1.modifyPartIndex] is InHouse && inHouseRadio.Checked == true)
            {
                Inventory.Parts[Form1.modifyPartIndex].partName = partNameEntry.Text;
                Inventory.Parts[Form1.modifyPartIndex].partPrice = Convert.ToDecimal(partPriceEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex].partStock = Convert.ToInt32(partStockEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex].partMin = Convert.ToInt32(partMinEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex].partMax = Convert.ToInt32(partMaxEntry.Text);
                ((InHouse)Inventory.Parts[Form1.modifyPartIndex]).machineID = Convert.ToInt32(IHOEntry.Text);
            }
            else if (Inventory.Parts[Form1.modifyPartIndex] is Outsourced && outsourcedRadio.Checked == true)
            {
                Inventory.Parts[Form1.modifyPartIndex].partName = partNameEntry.Text;
                Inventory.Parts[Form1.modifyPartIndex].partPrice = Convert.ToDecimal(partPriceEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex].partStock = Convert.ToInt32(partStockEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex].partMin = Convert.ToInt32(partMinEntry.Text);
                Inventory.Parts[Form1.modifyPartIndex].partMax = Convert.ToInt32(partMaxEntry.Text);
                ((Outsourced)Inventory.Parts[Form1.modifyPartIndex]).companyName = IHOEntry.Text;
            }
        }
         private void partNameEntry_TextChanged(object sender, EventArgs e)
        {
            if(partNameEntry.Text.Trim() == string.Empty)
            {
                partNameEntry.BackColor = Color.Yellow;
                NameWarning.Visible = true;
            }
            if (partNameEntry.Text.Trim() != string.Empty)
            {
                partNameEntry.BackColor = Color.White;
                NameWarning.Visible = false;
            }
                
        }

        private void partPriceEntry_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue;
            if (decimal.TryParse(partPriceEntry.Text, out parsedValue) == true)
            {
                if (partPriceEntry.Text.Trim() != string.Empty)
                {
                    partPriceEntry.BackColor = Color.White;
                    PriceWarning.Visible = false;
                }
            }
            else
            {
                if (partPriceEntry.Text.Trim() != string.Empty)
                {
                    partPriceEntry.BackColor = Color.Yellow;
                    PriceWarning.Visible = true;
                    PriceWarning.Text = "Must be a number.";
                }
            }
            if (partPriceEntry.Text.Trim() == string.Empty)
            {
                partPriceEntry.BackColor = Color.Yellow;
                PriceWarning.Text = "Cannot be empty.";
                PriceWarning.Visible = true;

            }

        }

        private void partStockEntry_TextChanged(object sender, EventArgs e)
        {
            int parsedStock;
            int parsedMin;
            int parsedMax;
            if(int.TryParse(partStockEntry.Text, out parsedStock) == true && int.TryParse(partMinEntry.Text, out parsedMin) == true && int.TryParse(partMaxEntry.Text, out parsedMax) == true)
            {
                if (partStockEntry.Text.Trim() != string.Empty && parsedStock <= parsedMax && parsedStock >= parsedMin)
                {
                    partStockEntry.BackColor = Color.White;
                    StockWarning.Visible = false;
                    partMinEntry.BackColor = Color.White;
                    MinWarning.Visible = false;
                    partMaxEntry.BackColor = Color.White;
                    MaxWarning.Visible = false;
                }
                else if(partStockEntry.Text.Trim() != string.Empty && parsedStock < parsedMin || parsedStock > parsedMax)
                {
                    partStockEntry.BackColor = Color.Yellow;
                    StockWarning.Visible = true;
                    StockWarning.Text = "Must be between Min and Max.";
                }
            }
            else if(partStockEntry.Text.Trim() != string.Empty && int.TryParse(partStockEntry.Text, out parsedStock) == true && int.TryParse(partMinEntry.Text, out parsedMin) == false || int.TryParse(partMaxEntry.Text, out parsedMax) == false)
            {
                partStockEntry.BackColor = Color.Yellow;
                StockWarning.Text = "Check Min and Max fields.";
                StockWarning.Visible = true;
            } else if (int.TryParse(partStockEntry.Text, out parsedStock) == false && partStockEntry.Text.Trim() != string.Empty)
            {
                partStockEntry.BackColor = Color.Yellow;
                StockWarning.Visible = true;
                StockWarning.Text = "Must be a whole number.";  
            }
            else if (partStockEntry.Text.Trim() == string.Empty)
            {
                partStockEntry.BackColor = Color.Yellow;
                StockWarning.Visible = true;
                StockWarning.Text = "Cannot be empty.";
            }
        }

        private void partMinEntry_TextChanged(object sender, EventArgs e)
        {
            int parsedStock;
            int parsedMin;
            int parsedMax;
            if (int.TryParse(partMaxEntry.Text, out parsedMax) == true && int.TryParse(partMinEntry.Text, out parsedMin) == true && int.TryParse(partStockEntry.Text, out parsedStock) == true)
            {
                if (partMinEntry.Text.Trim() != string.Empty)
                {
                    if (parsedMin < parsedMax && parsedStock >= parsedMin && parsedStock <= parsedMax)
                    {
                        partMinEntry.BackColor = Color.White;
                        MinWarning.Visible = false;
                        MaxWarning.Visible = false;
                        StockWarning.Visible = false;
                    }

                    else if (parsedMin >= parsedMax && parsedStock <= parsedMax)
                    {
                        partMinEntry.BackColor = Color.Yellow;
                        MinWarning.Text = "Must be less than Max.";
                        MinWarning.Visible = true;
                        MaxWarning.Text = "Must be greater than Min.";
                        MaxWarning.Visible = true;
                        StockWarning.Visible = true;
                        StockWarning.Text = "Check Min and Max fields.";
                        partStockEntry.BackColor = Color.Yellow;
                    }
                    else if (parsedMin > parsedStock)
                    {
                        partMinEntry.BackColor = Color.Yellow;
                        MinWarning.Text = "Check Stock field.";
                        MinWarning.Visible = true;
                        StockWarning.Visible = true;
                        StockWarning.Text = "Must be between Min and Max";
                    }
                }
                
            }
            else if (int.TryParse(partMaxEntry.Text, out parsedMax) == false && int.TryParse(partMinEntry.Text, out parsedMin) == true)
            {
                partMinEntry.BackColor = Color.Yellow;
                if (partMinEntry.Text.Trim() != string.Empty)
                {
                    MinWarning.Visible = true;
                    MinWarning.Text = "Check Max field.";
                } else
                {
                    MinWarning.Visible = true;
                    MinWarning.Text = "Cannot be empty.";
                }
            } else if(int.TryParse(partMinEntry.Text, out parsedMin) == false && partMinEntry.Text.Trim() != string.Empty)
            {
                partMinEntry.BackColor = Color.Yellow;
                MinWarning.Visible = true;
                MinWarning.Text = "Must be a whole number.";
                
            } else if (partMinEntry.Text.Trim() == string.Empty)
            {
                partMinEntry.BackColor = Color.Yellow;
                MinWarning.Visible = true;
                MinWarning.Text = "Cannot be empty.";
            }
        }

        private void partMaxEntry_TextChanged(object sender, EventArgs e)
        {
            int parsedStock;
            int parsedMax;
            int parsedMin;
            if (int.TryParse(partMaxEntry.Text, out parsedMax) == true && int.TryParse(partMinEntry.Text, out parsedMin) == true && int.TryParse(partStockEntry.Text, out parsedStock) == true)
            {
                if (partMaxEntry.Text.Trim() != string.Empty)
                {
                    if (parsedMax > parsedMin && parsedStock <= parsedMax && parsedStock >= parsedMin)
                    {
                        partMaxEntry.BackColor = Color.White;
                        partMinEntry.BackColor = Color.White;
                        partStockEntry.BackColor = Color.White;
                        MinWarning.Visible = false;
                        StockWarning.Visible = false;
                        MaxWarning.Visible = false;
                    }
                    else if (parsedMin > parsedMax && parsedMax >= parsedStock)
                    {
                        partMaxEntry.BackColor = Color.Yellow;
                        partMinEntry.BackColor = Color.Yellow;
                        partStockEntry.BackColor = Color.Yellow;
                        MinWarning.Visible = true;
                        MinWarning.Text = "Must be less than Max.";
                        MaxWarning.Visible = true;
                        MaxWarning.Text = "Must be greater than Min.";
                        StockWarning.Visible = true;
                        StockWarning.Text = "Check Min and Max fields.";
                    }
                    else if (parsedMax < parsedStock)
                    {
                        partMaxEntry.BackColor = Color.Yellow;
                        partStockEntry.BackColor = Color.Yellow;
                        StockWarning.Text = "Must be between Min and Max";
                        StockWarning.Visible = true;
                        MaxWarning.Visible = true;
                        MaxWarning.Text = "Check Stock field.";
                    }
                }
            }
            else if (int.TryParse(partMaxEntry.Text, out parsedMax) == true && int.TryParse(partMinEntry.Text, out parsedMin) == false)
            {
                partMaxEntry.BackColor = Color.Yellow;
                if (partMaxEntry.Text.Trim() != string.Empty)
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
            else if (int.TryParse(partMaxEntry.Text, out parsedMax) == false && partMaxEntry.Text.Trim() != string.Empty)
            {
                partMaxEntry.BackColor = Color.Yellow;
                MaxWarning.Visible = true;
                MaxWarning.Text = "Must be a whole number.";
            }
            
            if (partMaxEntry.Text.Trim() == string.Empty)
            {
                partMaxEntry.BackColor = Color.Yellow;
                MaxWarning.Visible = true;
                MaxWarning.Text = "Cannot be empty.";
            }
            
        }

        private void IHOEntry_TextChanged(object sender, EventArgs e)
        {
            if(inHouseRadio.Checked == true)
            {
                int parsedValue;
                if (int.TryParse(IHOEntry.Text, out parsedValue) == true)
                {
                    if (IHOEntry.Text.Trim() != string.Empty)
                    {
                        IHOEntry.BackColor = Color.White;
                        IHOWarning.Visible = false;
                    }
                }
                else if(int.TryParse(IHOEntry.Text, out parsedValue) == false)
                {
                    if (IHOEntry.Text.Trim() != string.Empty)
                    {
                        IHOEntry.BackColor = Color.Yellow;
                        IHOWarning.Text = "Must be a number.";
                        IHOWarning.Visible = true;
                    }
                }
                else if (IHOEntry.Text.Trim() == string.Empty)
                {
                    IHOEntry.BackColor = Color.Yellow;
                    IHOWarning.Text = "Cannot be empty.";
                    IHOWarning.Visible = true;
                }
            } else if (outsourcedRadio.Checked == true)
            {
                if (IHOEntry.Text.Trim() == string.Empty)
                {
                    IHOEntry.BackColor = Color.Yellow;
                    IHOWarning.Text = "Cannot be empty.";
                    IHOWarning.Visible = true;
                }
                if (IHOEntry.Text.Trim() != string.Empty)
                {
                    IHOEntry.BackColor = Color.White;
                    IHOWarning.Visible = false;
                }
            }
            
        }
    }
}
