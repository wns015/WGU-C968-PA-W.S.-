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
    
    public partial class Form1 : Form
    {
        

        //index of the item to be modified based on the datagridview
        public static int modifyPartIndex;
        public static int modifyProductIndex;
        public static bool modifyingItem;

        public Form1()
        {
            Inventory.Parts = new BindingList<Part>();
            Inventory.Products = new BindingList<Product>();

            //Empty list of associated parts to initialize sample products
            BindingList<Part> initial = new BindingList<Part>();

            InitializeComponent();
            
            //loading initial parts and products data
            Inventory.Parts.Add(new InHouse(Inventory.Parts.Count + 1, "Bolt", (decimal)0.39, 120, 20, 200, 2509));
            Inventory.Parts.Add(new InHouse(Inventory.Parts.Count + 1, "Nut", (decimal)0.28, 113, 20, 200, 2439));
            Inventory.Parts.Add(new Outsourced(Inventory.Parts.Count + 1, "Plank", (decimal)4.50, 13, 2, 30, "LumberYard"));
            Inventory.Products.Add(new Product(Inventory.Products.Count + 1, "Skateboard", (decimal)34.99, 4, 2, 20, initial)); //FIX LIST PARAMETER
            Inventory.Products.Add(new Product(Inventory.Products.Count + 1, "Longboard", (decimal)40.25, 6, 1, 20, initial));
            Inventory.Products.Add(new Product(Inventory.Products.Count + 1, "Helmet", (decimal)17.50, 5, 0, 15, initial)) ;

            //populating grids
            PopulateProductsGrid();
            PopulatePartsGrid();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();
            PopulatePartsGrid();
        }

        private void RemovePart_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < Inventory.Parts.Count; i++)
            {
                if(partsDataGrid.Rows[i].Selected == true)
                {
                    const string message = "Do you want to delete this part?";
                    const string caption = "Delete Part";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Inventory.Parts.RemoveAt(i);
                    }
                    
                    break;
                }
            }
            PopulatePartsGrid();
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyingItem = true;
            Form2 f2 = new Form2();
            for(int i = 0; i < Inventory.Parts.Count; i++)
            {
                if(partsDataGrid.Rows[i].Selected == true)
                {
                    modifyPartIndex = i;
                    break;
                }
            }
            f2.ShowDialog();
            modifyingItem = false;
            this.Show();
            PopulatePartsGrid();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Show();
            PopulateProductsGrid();
        }
        
        //functions for populating the grids in Form1
        private void PopulatePartsGrid()
        {
            partsDataGrid.Rows.Clear();
            foreach (var part in Inventory.Parts)
            {
                var id = Convert.ToString(part.partID);
                var name = part.partName;
                var price = Convert.ToString(part.partPrice);
                var stock = Convert.ToString(part.partStock);
                string[] row = { id, name, price, stock };
                partsDataGrid.Rows.Add(row);
            }
        }

        private void PopulateProductsGrid()
        {
            productsDataGrid.Rows.Clear();
            foreach (var product in Inventory.Products)
            {
                var id = Convert.ToString(product.productID);
                var name = product.productName;
                var price = Convert.ToString(product.productPrice);
                var stock = Convert.ToString(product.productStock);
                string[] row = { id, name, price, stock };
                productsDataGrid.Rows.Add(row);
            }
        }

        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyingItem = true;
            Form3 f3 = new Form3();
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (productsDataGrid.Rows[i].Selected == true)
                {
                    modifyProductIndex = i;
                    break;
                }
            }
            f3.ShowDialog();
            this.Show();
            modifyingItem = false;
            PopulateProductsGrid();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (productsDataGrid.Rows[i].Selected == true)
                {
                    if(Inventory.Products[i].AssociatedParts.Count > 0)
                    {
                        const string message = "This item has associated parts and cannot be deleted.";
                        const string caption = "Delete Error";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else if (Inventory.Products[i].AssociatedParts.Count == 0)
                    {
                        const string message = "Do you want to delete this product?";
                        const string caption = "Delete Product";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if(result == DialogResult.OK)
                        {
                            Inventory.Products.RemoveAt(i);
                        }
                    }
                    
                    break;
                }
            }
            PopulateProductsGrid();
        }

        private void ProdSearch_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Inventory.Products.Count; i++)
            {

                if (Inventory.Products[i].productName.Contains(productSearchBox.Text, StringComparison.OrdinalIgnoreCase) == true)
                {
                    productsDataGrid.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void PartSearch_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Inventory.Parts.Count; i++)
            {
                if(Inventory.Parts[i].partName.Contains(partSearchBox.Text, StringComparison.OrdinalIgnoreCase) == true)
                {
                    partsDataGrid.Rows[i].Selected = true;
                    break;
                }
            }
        }
    }


    public static class Inventory
    {
        public static BindingList<Product> Products;
        public static BindingList<Part> Parts;
        /*
        --Functions handled in Form1 button click events
        public void removeProduct(int)
        {
            DeleteProduct button click event
        }
        
        public void removePart(int)
        {
            DeletePart button click event
        }

        public Product lookupProduct(int)
        {
            ProdSearch button click event
        }

        public Part lookupPart(int)
        {
            PartSearch click event
        }

        --Function handled in Form2
        public void addPart(Part)
        {
            AddPart function
        }

        public void updatePart(int, Part)
        {
            ModifyPart function
        }

        --Function handled in Form3
        public void addProduct(Product)
        {
            SaveAddProd button click event
        }

        public void updateProduct(int, Product)
        {
            SaveAddProd button click event
        }
        */
    }

    //Parts class and In house and outsource subclasses
    public abstract class Part
    {
        public int partID;
        public string partName;
        public decimal partPrice;
        public int partStock;
        public int partMin;
        public int partMax;

    }

    public class InHouse : Part
    {
        public int machineID;


        public InHouse(int id, string name, decimal price, int stock, int min, int max, int mid)
        {
            this.partID = id;
            this.partName = name;
            this.partPrice = price;
            this.partStock = stock;
            this.partMin = min;
            this.partMax = max;
            this.machineID = mid;
        }
    }

    public class Outsourced : Part
    {
        public string companyName;

        public Outsourced(int id, string name, decimal price, int stock, int min, int max, string company)
        {
            this.partID = id;
            this.partName = name;
            this.partPrice = price;
            this.partStock = stock;
            this.partMin = min;
            this.partMax = max;
            this.companyName = company;

        }
    }

    public class Product
    {
        public int productID;
        public string productName;
        public decimal productPrice;
        public int productStock;
        public int productMin;
        public int productMax;
        public BindingList<Part> AssociatedParts;

        public Product(int id, string name, decimal price, int stock, int min, int max, BindingList<Part> AParts)
        {
            this.productID = id;
            this.productName = name;
            this.productPrice = price;
            this.productStock = stock;
            this.productMin = min;
            this.productMax = max;
            this.AssociatedParts = AParts;
        }

        /* 
        --All three functions are handled in Form3
        public void addAssociatedPart(Part)
        {
            AddProductPart button click event
        }
        
        public bool removeAssociatedPart(int)
        {
            RemoveProductPart button click event
        }

        public Part lookupAssociatedPart(int)
        {
            AssociatedPartsSearch button click event
        }
         */

    }








}
