
namespace C968_PA
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.partListGrid = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedGrid = new System.Windows.Forms.DataGridView();
            this.productPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPartStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductPart = new System.Windows.Forms.Button();
            this.RemoveProductPart = new System.Windows.Forms.Button();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.partsListLabel = new System.Windows.Forms.Label();
            this.associatedParts = new System.Windows.Forms.Label();
            this.prodIDLabel = new System.Windows.Forms.Label();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.prodPriceLabel = new System.Windows.Forms.Label();
            this.prodStockLabel = new System.Windows.Forms.Label();
            this.prodMinLabel = new System.Windows.Forms.Label();
            this.prodMaxLabel = new System.Windows.Forms.Label();
            this.productIDNumber = new System.Windows.Forms.Label();
            this.prodNameEntry = new System.Windows.Forms.TextBox();
            this.prodPriceEntry = new System.Windows.Forms.TextBox();
            this.prodStockEntry = new System.Windows.Forms.TextBox();
            this.prodMinEntry = new System.Windows.Forms.TextBox();
            this.prodMaxEntry = new System.Windows.Forms.TextBox();
            this.SaveAddProd = new System.Windows.Forms.Button();
            this.CancelAddProd = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.currentName = new System.Windows.Forms.Label();
            this.currentPrice = new System.Windows.Forms.Label();
            this.currentStock = new System.Windows.Forms.Label();
            this.currentMin = new System.Windows.Forms.Label();
            this.currentMax = new System.Windows.Forms.Label();
            this.AssociatedPartsSearch = new System.Windows.Forms.Button();
            this.PartListSearch = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.associatedSearchBox = new System.Windows.Forms.TextBox();
            this.NameWarning = new System.Windows.Forms.Label();
            this.PriceWarning = new System.Windows.Forms.Label();
            this.StockWarning = new System.Windows.Forms.Label();
            this.MinWarning = new System.Windows.Forms.Label();
            this.MaxWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // partListGrid
            // 
            this.partListGrid.AllowUserToAddRows = false;
            this.partListGrid.AllowUserToDeleteRows = false;
            this.partListGrid.AllowUserToResizeColumns = false;
            this.partListGrid.AllowUserToResizeRows = false;
            this.partListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partPrice,
            this.partStock});
            this.partListGrid.Location = new System.Drawing.Point(897, 130);
            this.partListGrid.Name = "partListGrid";
            this.partListGrid.ReadOnly = true;
            this.partListGrid.RowHeadersVisible = false;
            this.partListGrid.RowHeadersWidth = 62;
            this.partListGrid.RowTemplate.Height = 33;
            this.partListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partListGrid.Size = new System.Drawing.Size(605, 313);
            this.partListGrid.TabIndex = 0;
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.MinimumWidth = 8;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Width = 150;
            // 
            // partName
            // 
            this.partName.HeaderText = "Name";
            this.partName.MinimumWidth = 8;
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            this.partName.Width = 150;
            // 
            // partPrice
            // 
            this.partPrice.HeaderText = "Price";
            this.partPrice.MinimumWidth = 8;
            this.partPrice.Name = "partPrice";
            this.partPrice.ReadOnly = true;
            this.partPrice.Width = 150;
            // 
            // partStock
            // 
            this.partStock.HeaderText = "Stock";
            this.partStock.MinimumWidth = 8;
            this.partStock.Name = "partStock";
            this.partStock.ReadOnly = true;
            this.partStock.Width = 150;
            // 
            // associatedGrid
            // 
            this.associatedGrid.AllowUserToAddRows = false;
            this.associatedGrid.AllowUserToDeleteRows = false;
            this.associatedGrid.AllowUserToResizeColumns = false;
            this.associatedGrid.AllowUserToResizeRows = false;
            this.associatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productPartID,
            this.productPartName,
            this.productPartPrice,
            this.productPartStock});
            this.associatedGrid.Location = new System.Drawing.Point(897, 587);
            this.associatedGrid.Name = "associatedGrid";
            this.associatedGrid.ReadOnly = true;
            this.associatedGrid.RowHeadersVisible = false;
            this.associatedGrid.RowHeadersWidth = 62;
            this.associatedGrid.RowTemplate.Height = 33;
            this.associatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedGrid.Size = new System.Drawing.Size(605, 313);
            this.associatedGrid.TabIndex = 1;
            // 
            // productPartID
            // 
            this.productPartID.HeaderText = "Part ID";
            this.productPartID.MinimumWidth = 8;
            this.productPartID.Name = "productPartID";
            this.productPartID.ReadOnly = true;
            this.productPartID.Width = 150;
            // 
            // productPartName
            // 
            this.productPartName.HeaderText = "Name";
            this.productPartName.MinimumWidth = 8;
            this.productPartName.Name = "productPartName";
            this.productPartName.ReadOnly = true;
            this.productPartName.Width = 150;
            // 
            // productPartPrice
            // 
            this.productPartPrice.HeaderText = "Price";
            this.productPartPrice.MinimumWidth = 8;
            this.productPartPrice.Name = "productPartPrice";
            this.productPartPrice.ReadOnly = true;
            this.productPartPrice.Width = 150;
            // 
            // productPartStock
            // 
            this.productPartStock.HeaderText = "Stock";
            this.productPartStock.MinimumWidth = 8;
            this.productPartStock.Name = "productPartStock";
            this.productPartStock.ReadOnly = true;
            this.productPartStock.Width = 150;
            // 
            // AddProductPart
            // 
            this.AddProductPart.Location = new System.Drawing.Point(1352, 449);
            this.AddProductPart.Name = "AddProductPart";
            this.AddProductPart.Size = new System.Drawing.Size(150, 72);
            this.AddProductPart.TabIndex = 2;
            this.AddProductPart.Text = "Add";
            this.AddProductPart.UseVisualStyleBackColor = true;
            this.AddProductPart.Click += new System.EventHandler(this.AddProductPart_Click);
            // 
            // RemoveProductPart
            // 
            this.RemoveProductPart.Location = new System.Drawing.Point(1352, 906);
            this.RemoveProductPart.Name = "RemoveProductPart";
            this.RemoveProductPart.Size = new System.Drawing.Size(150, 72);
            this.RemoveProductPart.TabIndex = 3;
            this.RemoveProductPart.Text = "Remove";
            this.RemoveProductPart.UseVisualStyleBackColor = true;
            this.RemoveProductPart.Click += new System.EventHandler(this.RemoveProductPart_Click);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductLabel.Location = new System.Drawing.Point(669, 9);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(261, 44);
            this.addProductLabel.TabIndex = 4;
            this.addProductLabel.Text = "Add a Product";
            // 
            // partsListLabel
            // 
            this.partsListLabel.AutoSize = true;
            this.partsListLabel.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsListLabel.Location = new System.Drawing.Point(897, 83);
            this.partsListLabel.Name = "partsListLabel";
            this.partsListLabel.Size = new System.Drawing.Size(168, 44);
            this.partsListLabel.TabIndex = 5;
            this.partsListLabel.Text = "Parts List";
            // 
            // associatedParts
            // 
            this.associatedParts.AutoSize = true;
            this.associatedParts.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.associatedParts.Location = new System.Drawing.Point(897, 540);
            this.associatedParts.Name = "associatedParts";
            this.associatedParts.Size = new System.Drawing.Size(285, 44);
            this.associatedParts.TabIndex = 6;
            this.associatedParts.Text = "Associated Parts";
            // 
            // prodIDLabel
            // 
            this.prodIDLabel.AutoSize = true;
            this.prodIDLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodIDLabel.Location = new System.Drawing.Point(100, 139);
            this.prodIDLabel.Name = "prodIDLabel";
            this.prodIDLabel.Size = new System.Drawing.Size(151, 33);
            this.prodIDLabel.TabIndex = 7;
            this.prodIDLabel.Text = "Product ID";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodNameLabel.Location = new System.Drawing.Point(179, 218);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(89, 33);
            this.prodNameLabel.TabIndex = 8;
            this.prodNameLabel.Text = "Name";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodPriceLabel.Location = new System.Drawing.Point(189, 307);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(79, 33);
            this.prodPriceLabel.TabIndex = 9;
            this.prodPriceLabel.Text = "Price";
            // 
            // prodStockLabel
            // 
            this.prodStockLabel.AutoSize = true;
            this.prodStockLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodStockLabel.Location = new System.Drawing.Point(182, 391);
            this.prodStockLabel.Name = "prodStockLabel";
            this.prodStockLabel.Size = new System.Drawing.Size(86, 33);
            this.prodStockLabel.TabIndex = 10;
            this.prodStockLabel.Text = "Stock";
            // 
            // prodMinLabel
            // 
            this.prodMinLabel.AutoSize = true;
            this.prodMinLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodMinLabel.Location = new System.Drawing.Point(199, 469);
            this.prodMinLabel.Name = "prodMinLabel";
            this.prodMinLabel.Size = new System.Drawing.Size(62, 33);
            this.prodMinLabel.TabIndex = 11;
            this.prodMinLabel.Text = "Min";
            // 
            // prodMaxLabel
            // 
            this.prodMaxLabel.AutoSize = true;
            this.prodMaxLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodMaxLabel.Location = new System.Drawing.Point(194, 556);
            this.prodMaxLabel.Name = "prodMaxLabel";
            this.prodMaxLabel.Size = new System.Drawing.Size(67, 33);
            this.prodMaxLabel.TabIndex = 12;
            this.prodMaxLabel.Text = "Max";
            // 
            // productIDNumber
            // 
            this.productIDNumber.AutoSize = true;
            this.productIDNumber.Location = new System.Drawing.Point(405, 139);
            this.productIDNumber.Name = "productIDNumber";
            this.productIDNumber.Size = new System.Drawing.Size(81, 33);
            this.productIDNumber.TabIndex = 13;
            this.productIDNumber.Text = "label1";
            // 
            // prodNameEntry
            // 
            this.prodNameEntry.Location = new System.Drawing.Point(328, 218);
            this.prodNameEntry.Name = "prodNameEntry";
            this.prodNameEntry.Size = new System.Drawing.Size(222, 37);
            this.prodNameEntry.TabIndex = 14;
            this.prodNameEntry.TextChanged += new System.EventHandler(this.prodNameEntry_TextChanged);
            // 
            // prodPriceEntry
            // 
            this.prodPriceEntry.Location = new System.Drawing.Point(328, 303);
            this.prodPriceEntry.Name = "prodPriceEntry";
            this.prodPriceEntry.Size = new System.Drawing.Size(222, 37);
            this.prodPriceEntry.TabIndex = 15;
            this.prodPriceEntry.TextChanged += new System.EventHandler(this.prodPriceEntry_TextChanged);
            // 
            // prodStockEntry
            // 
            this.prodStockEntry.Location = new System.Drawing.Point(328, 387);
            this.prodStockEntry.Name = "prodStockEntry";
            this.prodStockEntry.Size = new System.Drawing.Size(222, 37);
            this.prodStockEntry.TabIndex = 16;
            this.prodStockEntry.TextChanged += new System.EventHandler(this.prodStockEntry_TextChanged);
            // 
            // prodMinEntry
            // 
            this.prodMinEntry.Location = new System.Drawing.Point(328, 471);
            this.prodMinEntry.Name = "prodMinEntry";
            this.prodMinEntry.Size = new System.Drawing.Size(222, 37);
            this.prodMinEntry.TabIndex = 17;
            this.prodMinEntry.TextChanged += new System.EventHandler(this.prodMinEntry_TextChanged);
            // 
            // prodMaxEntry
            // 
            this.prodMaxEntry.Location = new System.Drawing.Point(328, 556);
            this.prodMaxEntry.Name = "prodMaxEntry";
            this.prodMaxEntry.Size = new System.Drawing.Size(222, 37);
            this.prodMaxEntry.TabIndex = 18;
            this.prodMaxEntry.TextChanged += new System.EventHandler(this.prodMaxEntry_TextChanged);
            // 
            // SaveAddProd
            // 
            this.SaveAddProd.Location = new System.Drawing.Point(224, 683);
            this.SaveAddProd.Name = "SaveAddProd";
            this.SaveAddProd.Size = new System.Drawing.Size(150, 72);
            this.SaveAddProd.TabIndex = 19;
            this.SaveAddProd.Text = "Save";
            this.SaveAddProd.UseVisualStyleBackColor = true;
            this.SaveAddProd.Click += new System.EventHandler(this.SaveAddProd_Click);
            // 
            // CancelAddProd
            // 
            this.CancelAddProd.Location = new System.Drawing.Point(513, 683);
            this.CancelAddProd.Name = "CancelAddProd";
            this.CancelAddProd.Size = new System.Drawing.Size(150, 72);
            this.CancelAddProd.TabIndex = 20;
            this.CancelAddProd.Text = "Cancel";
            this.CancelAddProd.UseVisualStyleBackColor = true;
            this.CancelAddProd.Click += new System.EventHandler(this.CancelAddProd_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentLabel.Location = new System.Drawing.Point(609, 79);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(111, 33);
            this.currentLabel.TabIndex = 21;
            this.currentLabel.Text = "Current";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateLabel.Location = new System.Drawing.Point(387, 79);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(108, 33);
            this.updateLabel.TabIndex = 22;
            this.updateLabel.Text = "Update";
            // 
            // currentName
            // 
            this.currentName.AutoSize = true;
            this.currentName.Location = new System.Drawing.Point(609, 218);
            this.currentName.Name = "currentName";
            this.currentName.Size = new System.Drawing.Size(86, 33);
            this.currentName.TabIndex = 23;
            this.currentName.Text = "label2";
            // 
            // currentPrice
            // 
            this.currentPrice.AutoSize = true;
            this.currentPrice.Location = new System.Drawing.Point(609, 303);
            this.currentPrice.Name = "currentPrice";
            this.currentPrice.Size = new System.Drawing.Size(86, 33);
            this.currentPrice.TabIndex = 24;
            this.currentPrice.Text = "label3";
            // 
            // currentStock
            // 
            this.currentStock.AutoSize = true;
            this.currentStock.Location = new System.Drawing.Point(610, 387);
            this.currentStock.Name = "currentStock";
            this.currentStock.Size = new System.Drawing.Size(88, 33);
            this.currentStock.TabIndex = 25;
            this.currentStock.Text = "label4";
            // 
            // currentMin
            // 
            this.currentMin.AutoSize = true;
            this.currentMin.Location = new System.Drawing.Point(610, 469);
            this.currentMin.Name = "currentMin";
            this.currentMin.Size = new System.Drawing.Size(86, 33);
            this.currentMin.TabIndex = 26;
            this.currentMin.Text = "label5";
            // 
            // currentMax
            // 
            this.currentMax.AutoSize = true;
            this.currentMax.Location = new System.Drawing.Point(609, 556);
            this.currentMax.Name = "currentMax";
            this.currentMax.Size = new System.Drawing.Size(87, 33);
            this.currentMax.TabIndex = 27;
            this.currentMax.Text = "label6";
            // 
            // AssociatedPartsSearch
            // 
            this.AssociatedPartsSearch.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AssociatedPartsSearch.Location = new System.Drawing.Point(1195, 546);
            this.AssociatedPartsSearch.Name = "AssociatedPartsSearch";
            this.AssociatedPartsSearch.Size = new System.Drawing.Size(112, 35);
            this.AssociatedPartsSearch.TabIndex = 28;
            this.AssociatedPartsSearch.Text = "Search";
            this.AssociatedPartsSearch.UseVisualStyleBackColor = true;
            this.AssociatedPartsSearch.Click += new System.EventHandler(this.AssociatedPartsSearch_Click);
            // 
            // PartListSearch
            // 
            this.PartListSearch.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartListSearch.Location = new System.Drawing.Point(1195, 88);
            this.PartListSearch.Name = "PartListSearch";
            this.PartListSearch.Size = new System.Drawing.Size(112, 35);
            this.PartListSearch.TabIndex = 29;
            this.PartListSearch.Text = "Search";
            this.PartListSearch.UseVisualStyleBackColor = true;
            this.PartListSearch.Click += new System.EventHandler(this.PartListSearch_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(1313, 88);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(189, 37);
            this.partSearchBox.TabIndex = 30;
            // 
            // associatedSearchBox
            // 
            this.associatedSearchBox.Location = new System.Drawing.Point(1313, 547);
            this.associatedSearchBox.Name = "associatedSearchBox";
            this.associatedSearchBox.Size = new System.Drawing.Size(189, 37);
            this.associatedSearchBox.TabIndex = 31;
            // 
            // NameWarning
            // 
            this.NameWarning.AutoSize = true;
            this.NameWarning.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NameWarning.Location = new System.Drawing.Point(328, 199);
            this.NameWarning.Name = "NameWarning";
            this.NameWarning.Size = new System.Drawing.Size(117, 16);
            this.NameWarning.TabIndex = 32;
            this.NameWarning.Text = "Cannot be empty.";
            // 
            // PriceWarning
            // 
            this.PriceWarning.AutoSize = true;
            this.PriceWarning.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PriceWarning.Location = new System.Drawing.Point(328, 284);
            this.PriceWarning.Name = "PriceWarning";
            this.PriceWarning.Size = new System.Drawing.Size(117, 16);
            this.PriceWarning.TabIndex = 33;
            this.PriceWarning.Text = "Cannot be empty.";
            // 
            // StockWarning
            // 
            this.StockWarning.AutoSize = true;
            this.StockWarning.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.StockWarning.Location = new System.Drawing.Point(328, 368);
            this.StockWarning.Name = "StockWarning";
            this.StockWarning.Size = new System.Drawing.Size(117, 16);
            this.StockWarning.TabIndex = 34;
            this.StockWarning.Text = "Cannot be empty.";
            // 
            // MinWarning
            // 
            this.MinWarning.AutoSize = true;
            this.MinWarning.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MinWarning.Location = new System.Drawing.Point(328, 452);
            this.MinWarning.Name = "MinWarning";
            this.MinWarning.Size = new System.Drawing.Size(117, 16);
            this.MinWarning.TabIndex = 35;
            this.MinWarning.Text = "Cannot be empty.";
            // 
            // MaxWarning
            // 
            this.MaxWarning.AutoSize = true;
            this.MaxWarning.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MaxWarning.Location = new System.Drawing.Point(328, 537);
            this.MaxWarning.Name = "MaxWarning";
            this.MaxWarning.Size = new System.Drawing.Size(117, 16);
            this.MaxWarning.TabIndex = 36;
            this.MaxWarning.Text = "Cannot be empty.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 1003);
            this.Controls.Add(this.MaxWarning);
            this.Controls.Add(this.MinWarning);
            this.Controls.Add(this.StockWarning);
            this.Controls.Add(this.PriceWarning);
            this.Controls.Add(this.NameWarning);
            this.Controls.Add(this.associatedSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.PartListSearch);
            this.Controls.Add(this.AssociatedPartsSearch);
            this.Controls.Add(this.currentMax);
            this.Controls.Add(this.currentMin);
            this.Controls.Add(this.currentStock);
            this.Controls.Add(this.currentPrice);
            this.Controls.Add(this.currentName);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.CancelAddProd);
            this.Controls.Add(this.SaveAddProd);
            this.Controls.Add(this.prodMaxEntry);
            this.Controls.Add(this.prodMinEntry);
            this.Controls.Add(this.prodStockEntry);
            this.Controls.Add(this.prodPriceEntry);
            this.Controls.Add(this.prodNameEntry);
            this.Controls.Add(this.productIDNumber);
            this.Controls.Add(this.prodMaxLabel);
            this.Controls.Add(this.prodMinLabel);
            this.Controls.Add(this.prodStockLabel);
            this.Controls.Add(this.prodPriceLabel);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.prodIDLabel);
            this.Controls.Add(this.associatedParts);
            this.Controls.Add(this.partsListLabel);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.RemoveProductPart);
            this.Controls.Add(this.AddProductPart);
            this.Controls.Add(this.associatedGrid);
            this.Controls.Add(this.partListGrid);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.partListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partStock;
        private System.Windows.Forms.DataGridView associatedGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPartStock;
        private System.Windows.Forms.Button AddProductPart;
        private System.Windows.Forms.Button RemoveProductPart;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label partsListLabel;
        private System.Windows.Forms.Label associatedParts;
        private System.Windows.Forms.Label prodIDLabel;
        private System.Windows.Forms.Label prodNameLabel;
        private System.Windows.Forms.Label prodPriceLabel;
        private System.Windows.Forms.Label prodStockLabel;
        private System.Windows.Forms.Label prodMinLabel;
        private System.Windows.Forms.Label prodMaxLabel;
        private System.Windows.Forms.Label productIDNumber;
        private System.Windows.Forms.TextBox prodNameEntry;
        private System.Windows.Forms.TextBox prodPriceEntry;
        private System.Windows.Forms.TextBox prodStockEntry;
        private System.Windows.Forms.TextBox prodMinEntry;
        private System.Windows.Forms.TextBox prodMaxEntry;
        private System.Windows.Forms.Button SaveAddProd;
        private System.Windows.Forms.Button CancelAddProd;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label currentName;
        private System.Windows.Forms.Label currentPrice;
        private System.Windows.Forms.Label currentStock;
        private System.Windows.Forms.Label currentMin;
        private System.Windows.Forms.Label currentMax;
        private System.Windows.Forms.Button AssociatedPartsSearch;
        private System.Windows.Forms.Button PartListSearch;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox associatedSearchBox;
        private System.Windows.Forms.Label NameWarning;
        private System.Windows.Forms.Label PriceWarning;
        private System.Windows.Forms.Label StockWarning;
        private System.Windows.Forms.Label MinWarning;
        private System.Windows.Forms.Label MaxWarning;
    }
}