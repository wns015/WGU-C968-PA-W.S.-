
namespace C968_PA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitApp = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsDataGrid = new System.Windows.Forms.DataGridView();
            this.partIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partStockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.PartsGridLabel = new System.Windows.Forms.Label();
            this.ProductGridLabel = new System.Windows.Forms.Label();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.ProdSearch = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exitApp
            // 
            this.exitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitApp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitApp.FlatAppearance.BorderSize = 2;
            this.exitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitApp.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitApp.Location = new System.Drawing.Point(1238, 762);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(230, 90);
            this.exitApp.TabIndex = 0;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // partsDataGrid
            // 
            this.partsDataGrid.AllowUserToAddRows = false;
            this.partsDataGrid.AllowUserToDeleteRows = false;
            this.partsDataGrid.AllowUserToResizeColumns = false;
            this.partsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDCol,
            this.partNameCol,
            this.partPriceCol,
            this.partStockCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.partsDataGrid.Location = new System.Drawing.Point(121, 200);
            this.partsDataGrid.MultiSelect = false;
            this.partsDataGrid.Name = "partsDataGrid";
            this.partsDataGrid.ReadOnly = true;
            this.partsDataGrid.RowHeadersVisible = false;
            this.partsDataGrid.RowHeadersWidth = 62;
            this.partsDataGrid.RowTemplate.Height = 33;
            this.partsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGrid.Size = new System.Drawing.Size(605, 372);
            this.partsDataGrid.TabIndex = 1;
            // 
            // partIDCol
            // 
            this.partIDCol.HeaderText = "ID";
            this.partIDCol.MinimumWidth = 8;
            this.partIDCol.Name = "partIDCol";
            this.partIDCol.ReadOnly = true;
            this.partIDCol.Width = 150;
            // 
            // partNameCol
            // 
            this.partNameCol.HeaderText = "Name";
            this.partNameCol.MinimumWidth = 8;
            this.partNameCol.Name = "partNameCol";
            this.partNameCol.ReadOnly = true;
            this.partNameCol.Width = 150;
            // 
            // partPriceCol
            // 
            this.partPriceCol.HeaderText = "Price";
            this.partPriceCol.MinimumWidth = 8;
            this.partPriceCol.Name = "partPriceCol";
            this.partPriceCol.ReadOnly = true;
            this.partPriceCol.Width = 150;
            // 
            // partStockCol
            // 
            this.partStockCol.HeaderText = "Stock";
            this.partStockCol.MinimumWidth = 8;
            this.partStockCol.Name = "partStockCol";
            this.partStockCol.ReadOnly = true;
            this.partStockCol.Width = 150;
            // 
            // addPart
            // 
            this.addPart.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPart.Location = new System.Drawing.Point(121, 635);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(145, 62);
            this.addPart.TabIndex = 2;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletePart.Location = new System.Drawing.Point(356, 635);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(145, 62);
            this.deletePart.TabIndex = 3;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.RemovePart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyPart.Location = new System.Drawing.Point(581, 635);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(145, 62);
            this.modifyPart.TabIndex = 4;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.AllowUserToResizeColumns = false;
            this.productsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productPrice,
            this.productStock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.productsDataGrid.Location = new System.Drawing.Point(863, 200);
            this.productsDataGrid.MultiSelect = false;
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.RowHeadersVisible = false;
            this.productsDataGrid.RowHeadersWidth = 62;
            this.productsDataGrid.RowTemplate.Height = 33;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.Size = new System.Drawing.Size(605, 372);
            this.productsDataGrid.TabIndex = 5;
            // 
            // productID
            // 
            this.productID.HeaderText = "ID";
            this.productID.MinimumWidth = 8;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 150;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 150;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 8;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 150;
            // 
            // productStock
            // 
            this.productStock.HeaderText = "Stock";
            this.productStock.MinimumWidth = 8;
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            this.productStock.Width = 150;
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProduct.Location = new System.Drawing.Point(863, 638);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(145, 62);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteProduct.Location = new System.Drawing.Point(1093, 638);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(145, 62);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyProduct.Location = new System.Drawing.Point(1323, 638);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(145, 62);
            this.ModifyProduct.TabIndex = 8;
            this.ModifyProduct.Text = "Modify";
            this.ModifyProduct.UseVisualStyleBackColor = true;
            this.ModifyProduct.Click += new System.EventHandler(this.ModifyProduct_Click);
            // 
            // PartsGridLabel
            // 
            this.PartsGridLabel.AutoSize = true;
            this.PartsGridLabel.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartsGridLabel.Location = new System.Drawing.Point(121, 139);
            this.PartsGridLabel.Name = "PartsGridLabel";
            this.PartsGridLabel.Size = new System.Drawing.Size(103, 44);
            this.PartsGridLabel.TabIndex = 9;
            this.PartsGridLabel.Text = "Parts";
            // 
            // ProductGridLabel
            // 
            this.ProductGridLabel.AutoSize = true;
            this.ProductGridLabel.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductGridLabel.Location = new System.Drawing.Point(863, 139);
            this.ProductGridLabel.Name = "ProductGridLabel";
            this.ProductGridLabel.Size = new System.Drawing.Size(165, 44);
            this.ProductGridLabel.TabIndex = 10;
            this.ProductGridLabel.Text = "Products";
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(1271, 152);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(197, 31);
            this.productSearchBox.TabIndex = 11;
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(529, 151);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(197, 31);
            this.partSearchBox.TabIndex = 12;
            // 
            // ProdSearch
            // 
            this.ProdSearch.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProdSearch.Location = new System.Drawing.Point(1137, 148);
            this.ProdSearch.Name = "ProdSearch";
            this.ProdSearch.Size = new System.Drawing.Size(112, 34);
            this.ProdSearch.TabIndex = 13;
            this.ProdSearch.Text = "Search";
            this.ProdSearch.UseVisualStyleBackColor = true;
            this.ProdSearch.Click += new System.EventHandler(this.ProdSearch_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartSearch.Location = new System.Drawing.Point(389, 148);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(112, 34);
            this.PartSearch.TabIndex = 14;
            this.PartSearch.Text = "Search";
            this.PartSearch.UseVisualStyleBackColor = true;
            this.PartSearch.Click += new System.EventHandler(this.PartSearch_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(483, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(619, 50);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Inventory Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 883);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PartSearch);
            this.Controls.Add(this.ProdSearch);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.ProductGridLabel);
            this.Controls.Add(this.PartsGridLabel);
            this.Controls.Add(this.ModifyProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.partsDataGrid);
            this.Controls.Add(this.exitApp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView partsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn partStockCol;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Label PartsGridLabel;
        private System.Windows.Forms.Label ProductGridLabel;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Button ProdSearch;
        private System.Windows.Forms.Button PartSearch;
        private System.Windows.Forms.Label TitleLabel;
    }
}

