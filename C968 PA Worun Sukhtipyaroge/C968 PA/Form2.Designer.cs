
namespace C968_PA
{
    partial class Form2
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
            this.partIDLabel = new System.Windows.Forms.Label();
            this.partIDNumber = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partStockLabel = new System.Windows.Forms.Label();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.IHOLabel = new System.Windows.Forms.Label();
            this.partNameEntry = new System.Windows.Forms.TextBox();
            this.partPriceEntry = new System.Windows.Forms.TextBox();
            this.partStockEntry = new System.Windows.Forms.TextBox();
            this.partMinEntry = new System.Windows.Forms.TextBox();
            this.partMaxEntry = new System.Windows.Forms.TextBox();
            this.IHOEntry = new System.Windows.Forms.TextBox();
            this.partAddTitle = new System.Windows.Forms.Label();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.saveAddPart = new System.Windows.Forms.Button();
            this.inHouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.NameWarning = new System.Windows.Forms.Label();
            this.PriceWarning = new System.Windows.Forms.Label();
            this.StockWarning = new System.Windows.Forms.Label();
            this.MinWarning = new System.Windows.Forms.Label();
            this.MaxWarning = new System.Windows.Forms.Label();
            this.IHOWarning = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.currentName = new System.Windows.Forms.Label();
            this.currentPrice = new System.Windows.Forms.Label();
            this.currentStock = new System.Windows.Forms.Label();
            this.currentMin = new System.Windows.Forms.Label();
            this.currentMax = new System.Windows.Forms.Label();
            this.currentIHO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(124, 229);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(103, 33);
            this.partIDLabel.TabIndex = 2;
            this.partIDLabel.Text = "Part ID";
            // 
            // partIDNumber
            // 
            this.partIDNumber.AutoSize = true;
            this.partIDNumber.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partIDNumber.Location = new System.Drawing.Point(432, 229);
            this.partIDNumber.Name = "partIDNumber";
            this.partIDNumber.Size = new System.Drawing.Size(81, 33);
            this.partIDNumber.TabIndex = 3;
            this.partIDNumber.Text = "label1";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(138, 302);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(89, 33);
            this.partNameLabel.TabIndex = 4;
            this.partNameLabel.Text = "Name";
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Location = new System.Drawing.Point(148, 388);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(79, 33);
            this.partPriceLabel.TabIndex = 5;
            this.partPriceLabel.Text = "Price";
            // 
            // partStockLabel
            // 
            this.partStockLabel.AutoSize = true;
            this.partStockLabel.Location = new System.Drawing.Point(141, 467);
            this.partStockLabel.Name = "partStockLabel";
            this.partStockLabel.Size = new System.Drawing.Size(86, 33);
            this.partStockLabel.TabIndex = 6;
            this.partStockLabel.Text = "Stock";
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Location = new System.Drawing.Point(165, 548);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(62, 33);
            this.partMinLabel.TabIndex = 7;
            this.partMinLabel.Text = "Min";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Location = new System.Drawing.Point(160, 629);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(67, 33);
            this.partMaxLabel.TabIndex = 8;
            this.partMaxLabel.Text = "Max";
            // 
            // IHOLabel
            // 
            this.IHOLabel.AutoSize = true;
            this.IHOLabel.Location = new System.Drawing.Point(42, 708);
            this.IHOLabel.Name = "IHOLabel";
            this.IHOLabel.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.IHOLabel.Size = new System.Drawing.Size(185, 33);
            this.IHOLabel.TabIndex = 9;
            this.IHOLabel.Text = "label1";
            this.IHOLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // partNameEntry
            // 
            this.partNameEntry.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partNameEntry.Location = new System.Drawing.Point(318, 302);
            this.partNameEntry.Name = "partNameEntry";
            this.partNameEntry.Size = new System.Drawing.Size(249, 37);
            this.partNameEntry.TabIndex = 11;
            this.partNameEntry.TextChanged += new System.EventHandler(this.partNameEntry_TextChanged);
            // 
            // partPriceEntry
            // 
            this.partPriceEntry.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partPriceEntry.Location = new System.Drawing.Point(318, 385);
            this.partPriceEntry.Name = "partPriceEntry";
            this.partPriceEntry.Size = new System.Drawing.Size(249, 37);
            this.partPriceEntry.TabIndex = 12;
            this.partPriceEntry.TextChanged += new System.EventHandler(this.partPriceEntry_TextChanged);
            // 
            // partStockEntry
            // 
            this.partStockEntry.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partStockEntry.Location = new System.Drawing.Point(318, 467);
            this.partStockEntry.Name = "partStockEntry";
            this.partStockEntry.Size = new System.Drawing.Size(249, 37);
            this.partStockEntry.TabIndex = 13;
            this.partStockEntry.TextChanged += new System.EventHandler(this.partStockEntry_TextChanged);
            // 
            // partMinEntry
            // 
            this.partMinEntry.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partMinEntry.Location = new System.Drawing.Point(318, 548);
            this.partMinEntry.Name = "partMinEntry";
            this.partMinEntry.Size = new System.Drawing.Size(249, 37);
            this.partMinEntry.TabIndex = 14;
            this.partMinEntry.TextChanged += new System.EventHandler(this.partMinEntry_TextChanged);
            // 
            // partMaxEntry
            // 
            this.partMaxEntry.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partMaxEntry.Location = new System.Drawing.Point(318, 629);
            this.partMaxEntry.Name = "partMaxEntry";
            this.partMaxEntry.Size = new System.Drawing.Size(249, 37);
            this.partMaxEntry.TabIndex = 15;
            this.partMaxEntry.TextChanged += new System.EventHandler(this.partMaxEntry_TextChanged);
            // 
            // IHOEntry
            // 
            this.IHOEntry.Location = new System.Drawing.Point(318, 708);
            this.IHOEntry.Name = "IHOEntry";
            this.IHOEntry.Size = new System.Drawing.Size(249, 37);
            this.IHOEntry.TabIndex = 16;
            this.IHOEntry.TextChanged += new System.EventHandler(this.IHOEntry_TextChanged);
            // 
            // partAddTitle
            // 
            this.partAddTitle.AutoSize = true;
            this.partAddTitle.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partAddTitle.Location = new System.Drawing.Point(316, 39);
            this.partAddTitle.Name = "partAddTitle";
            this.partAddTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partAddTitle.Size = new System.Drawing.Size(197, 44);
            this.partAddTitle.TabIndex = 17;
            this.partAddTitle.Text = "Add a Part";
            // 
            // cancelAdd
            // 
            this.cancelAdd.Location = new System.Drawing.Point(432, 801);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(158, 78);
            this.cancelAdd.TabIndex = 18;
            this.cancelAdd.Text = "Cancel";
            this.cancelAdd.UseVisualStyleBackColor = true;
            this.cancelAdd.Click += new System.EventHandler(this.cancelAdd_Click);
            // 
            // saveAddPart
            // 
            this.saveAddPart.Location = new System.Drawing.Point(216, 801);
            this.saveAddPart.Name = "saveAddPart";
            this.saveAddPart.Size = new System.Drawing.Size(158, 78);
            this.saveAddPart.TabIndex = 19;
            this.saveAddPart.Text = "Save";
            this.saveAddPart.UseVisualStyleBackColor = true;
            this.saveAddPart.Click += new System.EventHandler(this.saveAddPart_Click);
            // 
            // inHouseRadio
            // 
            this.inHouseRadio.AutoSize = true;
            this.inHouseRadio.Checked = true;
            this.inHouseRadio.Location = new System.Drawing.Point(221, 120);
            this.inHouseRadio.Name = "inHouseRadio";
            this.inHouseRadio.Size = new System.Drawing.Size(153, 37);
            this.inHouseRadio.TabIndex = 0;
            this.inHouseRadio.TabStop = true;
            this.inHouseRadio.Text = "In-House";
            this.inHouseRadio.UseVisualStyleBackColor = true;
            this.inHouseRadio.CheckedChanged += new System.EventHandler(this.inHouseRadio_CheckedChanged);
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(458, 120);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(187, 37);
            this.outsourcedRadio.TabIndex = 1;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourceRadio_CheckedChanged);
            // 
            // NameWarning
            // 
            this.NameWarning.AutoSize = true;
            this.NameWarning.Font = new System.Drawing.Font("Montserrat Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NameWarning.Location = new System.Drawing.Point(318, 283);
            this.NameWarning.Name = "NameWarning";
            this.NameWarning.Size = new System.Drawing.Size(130, 16);
            this.NameWarning.TabIndex = 20;
            this.NameWarning.Text = "Cannot be empty.";
            // 
            // PriceWarning
            // 
            this.PriceWarning.AutoSize = true;
            this.PriceWarning.Font = new System.Drawing.Font("Montserrat Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PriceWarning.Location = new System.Drawing.Point(318, 366);
            this.PriceWarning.Name = "PriceWarning";
            this.PriceWarning.Size = new System.Drawing.Size(130, 16);
            this.PriceWarning.TabIndex = 21;
            this.PriceWarning.Text = "Cannot be empty.";
            // 
            // StockWarning
            // 
            this.StockWarning.AutoSize = true;
            this.StockWarning.Font = new System.Drawing.Font("Montserrat Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StockWarning.Location = new System.Drawing.Point(318, 448);
            this.StockWarning.Name = "StockWarning";
            this.StockWarning.Size = new System.Drawing.Size(130, 16);
            this.StockWarning.TabIndex = 22;
            this.StockWarning.Text = "Cannot be empty.";
            // 
            // MinWarning
            // 
            this.MinWarning.AutoSize = true;
            this.MinWarning.Font = new System.Drawing.Font("Montserrat Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MinWarning.Location = new System.Drawing.Point(318, 529);
            this.MinWarning.Name = "MinWarning";
            this.MinWarning.Size = new System.Drawing.Size(130, 16);
            this.MinWarning.TabIndex = 23;
            this.MinWarning.Text = "Cannot be empty.";
            // 
            // MaxWarning
            // 
            this.MaxWarning.AutoSize = true;
            this.MaxWarning.Font = new System.Drawing.Font("Montserrat Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MaxWarning.Location = new System.Drawing.Point(321, 610);
            this.MaxWarning.Name = "MaxWarning";
            this.MaxWarning.Size = new System.Drawing.Size(130, 16);
            this.MaxWarning.TabIndex = 24;
            this.MaxWarning.Text = "Cannot be empty.";
            // 
            // IHOWarning
            // 
            this.IHOWarning.AutoSize = true;
            this.IHOWarning.Font = new System.Drawing.Font("Montserrat Light", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.IHOWarning.Location = new System.Drawing.Point(321, 689);
            this.IHOWarning.Name = "IHOWarning";
            this.IHOWarning.Size = new System.Drawing.Size(130, 16);
            this.IHOWarning.TabIndex = 25;
            this.IHOWarning.Text = "Cannot be empty.";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(405, 172);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(108, 33);
            this.updateLabel.TabIndex = 26;
            this.updateLabel.Text = "Update";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(619, 172);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(111, 33);
            this.currentLabel.TabIndex = 27;
            this.currentLabel.Text = "Current";
            // 
            // currentName
            // 
            this.currentName.AutoSize = true;
            this.currentName.Location = new System.Drawing.Point(637, 302);
            this.currentName.Name = "currentName";
            this.currentName.Size = new System.Drawing.Size(85, 33);
            this.currentName.TabIndex = 28;
            this.currentName.Text = "label1";
            // 
            // currentPrice
            // 
            this.currentPrice.AutoSize = true;
            this.currentPrice.Location = new System.Drawing.Point(635, 385);
            this.currentPrice.Name = "currentPrice";
            this.currentPrice.Size = new System.Drawing.Size(90, 33);
            this.currentPrice.TabIndex = 29;
            this.currentPrice.Text = "label2";
            // 
            // currentStock
            // 
            this.currentStock.AutoSize = true;
            this.currentStock.Location = new System.Drawing.Point(635, 467);
            this.currentStock.Name = "currentStock";
            this.currentStock.Size = new System.Drawing.Size(90, 33);
            this.currentStock.TabIndex = 30;
            this.currentStock.Text = "label3";
            // 
            // currentMin
            // 
            this.currentMin.AutoSize = true;
            this.currentMin.Location = new System.Drawing.Point(632, 548);
            this.currentMin.Name = "currentMin";
            this.currentMin.Size = new System.Drawing.Size(93, 33);
            this.currentMin.TabIndex = 31;
            this.currentMin.Text = "label4";
            // 
            // currentMax
            // 
            this.currentMax.AutoSize = true;
            this.currentMax.Location = new System.Drawing.Point(632, 633);
            this.currentMax.Name = "currentMax";
            this.currentMax.Size = new System.Drawing.Size(90, 33);
            this.currentMax.TabIndex = 32;
            this.currentMax.Text = "label5";
            // 
            // currentIHO
            // 
            this.currentIHO.AutoSize = true;
            this.currentIHO.Location = new System.Drawing.Point(631, 712);
            this.currentIHO.Name = "currentIHO";
            this.currentIHO.Size = new System.Drawing.Size(91, 33);
            this.currentIHO.TabIndex = 33;
            this.currentIHO.Text = "label6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 950);
            this.Controls.Add(this.currentIHO);
            this.Controls.Add(this.currentMax);
            this.Controls.Add(this.currentMin);
            this.Controls.Add(this.currentStock);
            this.Controls.Add(this.currentPrice);
            this.Controls.Add(this.currentName);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.IHOWarning);
            this.Controls.Add(this.MaxWarning);
            this.Controls.Add(this.MinWarning);
            this.Controls.Add(this.StockWarning);
            this.Controls.Add(this.PriceWarning);
            this.Controls.Add(this.NameWarning);
            this.Controls.Add(this.inHouseRadio);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.saveAddPart);
            this.Controls.Add(this.cancelAdd);
            this.Controls.Add(this.partAddTitle);
            this.Controls.Add(this.IHOEntry);
            this.Controls.Add(this.partMaxEntry);
            this.Controls.Add(this.partMinEntry);
            this.Controls.Add(this.partStockEntry);
            this.Controls.Add(this.partPriceEntry);
            this.Controls.Add(this.partNameEntry);
            this.Controls.Add(this.IHOLabel);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.partStockLabel);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partIDNumber);
            this.Controls.Add(this.partIDLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.Label partIDNumber;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Label partStockLabel;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label IHOLabel;
        private System.Windows.Forms.TextBox partNameEntry;
        private System.Windows.Forms.TextBox partPriceEntry;
        private System.Windows.Forms.TextBox partStockEntry;
        private System.Windows.Forms.TextBox partMinEntry;
        private System.Windows.Forms.TextBox partMaxEntry;
        private System.Windows.Forms.TextBox IHOEntry;
        private System.Windows.Forms.Label partAddTitle;
        private System.Windows.Forms.Button cancelAdd;
        private System.Windows.Forms.Button saveAddPart;
        private System.Windows.Forms.RadioButton inHouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.Label NameWarning;
        private System.Windows.Forms.Label PriceWarning;
        private System.Windows.Forms.Label StockWarning;
        private System.Windows.Forms.Label MinWarning;
        private System.Windows.Forms.Label MaxWarning;
        private System.Windows.Forms.Label IHOWarning;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label currentName;
        private System.Windows.Forms.Label currentPrice;
        private System.Windows.Forms.Label currentStock;
        private System.Windows.Forms.Label currentMin;
        private System.Windows.Forms.Label currentMax;
        private System.Windows.Forms.Label currentIHO;
    }
}