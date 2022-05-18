
namespace STORES
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_Stores = new System.Windows.Forms.GroupBox();
            this.dgv_Stores = new System.Windows.Forms.DataGridView();
            this.grbx_Street = new System.Windows.Forms.GroupBox();
            this.dgv_Street = new System.Windows.Forms.DataGridView();
            this.grbx_Product = new System.Windows.Forms.GroupBox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.grbx_Specifications = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Barcode = new System.Windows.Forms.TextBox();
            this.txbx_Width = new System.Windows.Forms.TextBox();
            this.txbx_Height = new System.Windows.Forms.TextBox();
            this.txbx_Connector = new System.Windows.Forms.TextBox();
            this.txbx_Colour = new System.Windows.Forms.TextBox();
            this.grbx_Search = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStreetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbx_BarcodeName = new System.Windows.Forms.TextBox();
            this.txbx_ProductName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.grbx_Stores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stores)).BeginInit();
            this.grbx_Street.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Street)).BeginInit();
            this.grbx_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.grbx_Specifications.SuspendLayout();
            this.grbx_Search.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Stores
            // 
            this.grbx_Stores.Controls.Add(this.dgv_Stores);
            this.grbx_Stores.Location = new System.Drawing.Point(12, 106);
            this.grbx_Stores.Name = "grbx_Stores";
            this.grbx_Stores.Size = new System.Drawing.Size(214, 128);
            this.grbx_Stores.TabIndex = 0;
            this.grbx_Stores.TabStop = false;
            this.grbx_Stores.Text = "Stores";
            // 
            // dgv_Stores
            // 
            this.dgv_Stores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Stores.Location = new System.Drawing.Point(3, 16);
            this.dgv_Stores.Name = "dgv_Stores";
            this.dgv_Stores.Size = new System.Drawing.Size(208, 109);
            this.dgv_Stores.TabIndex = 0;
            this.dgv_Stores.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // grbx_Street
            // 
            this.grbx_Street.Controls.Add(this.dgv_Street);
            this.grbx_Street.Location = new System.Drawing.Point(298, 106);
            this.grbx_Street.Name = "grbx_Street";
            this.grbx_Street.Size = new System.Drawing.Size(532, 128);
            this.grbx_Street.TabIndex = 1;
            this.grbx_Street.TabStop = false;
            this.grbx_Street.Text = "Street";
            // 
            // dgv_Street
            // 
            this.dgv_Street.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Street.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Street.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Street.Location = new System.Drawing.Point(3, 16);
            this.dgv_Street.Name = "dgv_Street";
            this.dgv_Street.Size = new System.Drawing.Size(526, 109);
            this.dgv_Street.TabIndex = 0;
            this.dgv_Street.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // grbx_Product
            // 
            this.grbx_Product.Controls.Add(this.dgv_Product);
            this.grbx_Product.Location = new System.Drawing.Point(13, 244);
            this.grbx_Product.Name = "grbx_Product";
            this.grbx_Product.Size = new System.Drawing.Size(370, 230);
            this.grbx_Product.TabIndex = 2;
            this.grbx_Product.TabStop = false;
            this.grbx_Product.Text = "Product";
            // 
            // dgv_Product
            // 
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.Location = new System.Drawing.Point(3, 16);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.Size = new System.Drawing.Size(364, 211);
            this.dgv_Product.TabIndex = 1;
            this.dgv_Product.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // grbx_Specifications
            // 
            this.grbx_Specifications.Controls.Add(this.label5);
            this.grbx_Specifications.Controls.Add(this.label4);
            this.grbx_Specifications.Controls.Add(this.label3);
            this.grbx_Specifications.Controls.Add(this.label2);
            this.grbx_Specifications.Controls.Add(this.label1);
            this.grbx_Specifications.Controls.Add(this.txbx_Barcode);
            this.grbx_Specifications.Controls.Add(this.txbx_Width);
            this.grbx_Specifications.Controls.Add(this.txbx_Height);
            this.grbx_Specifications.Controls.Add(this.txbx_Connector);
            this.grbx_Specifications.Controls.Add(this.txbx_Colour);
            this.grbx_Specifications.Location = new System.Drawing.Point(415, 244);
            this.grbx_Specifications.Name = "grbx_Specifications";
            this.grbx_Specifications.Size = new System.Drawing.Size(415, 230);
            this.grbx_Specifications.TabIndex = 3;
            this.grbx_Specifications.TabStop = false;
            this.grbx_Specifications.Text = "Specifications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Connector";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Colour";
            // 
            // txbx_Barcode
            // 
            this.txbx_Barcode.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Barcode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbx_Barcode.Location = new System.Drawing.Point(99, 189);
            this.txbx_Barcode.Name = "txbx_Barcode";
            this.txbx_Barcode.ReadOnly = true;
            this.txbx_Barcode.Size = new System.Drawing.Size(310, 20);
            this.txbx_Barcode.TabIndex = 4;
            // 
            // txbx_Width
            // 
            this.txbx_Width.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Width.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbx_Width.Location = new System.Drawing.Point(99, 151);
            this.txbx_Width.Name = "txbx_Width";
            this.txbx_Width.ReadOnly = true;
            this.txbx_Width.Size = new System.Drawing.Size(310, 20);
            this.txbx_Width.TabIndex = 3;
            // 
            // txbx_Height
            // 
            this.txbx_Height.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Height.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbx_Height.Location = new System.Drawing.Point(99, 112);
            this.txbx_Height.Name = "txbx_Height";
            this.txbx_Height.ReadOnly = true;
            this.txbx_Height.Size = new System.Drawing.Size(310, 20);
            this.txbx_Height.TabIndex = 2;
            // 
            // txbx_Connector
            // 
            this.txbx_Connector.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Connector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbx_Connector.Location = new System.Drawing.Point(99, 74);
            this.txbx_Connector.Name = "txbx_Connector";
            this.txbx_Connector.ReadOnly = true;
            this.txbx_Connector.Size = new System.Drawing.Size(310, 20);
            this.txbx_Connector.TabIndex = 1;
            // 
            // txbx_Colour
            // 
            this.txbx_Colour.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Colour.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbx_Colour.Location = new System.Drawing.Point(99, 35);
            this.txbx_Colour.Name = "txbx_Colour";
            this.txbx_Colour.ReadOnly = true;
            this.txbx_Colour.Size = new System.Drawing.Size(310, 20);
            this.txbx_Colour.TabIndex = 0;
            // 
            // grbx_Search
            // 
            this.grbx_Search.Controls.Add(this.btn_Next);
            this.grbx_Search.Controls.Add(this.label7);
            this.grbx_Search.Controls.Add(this.label6);
            this.grbx_Search.Controls.Add(this.btn_Search);
            this.grbx_Search.Controls.Add(this.txbx_ProductName);
            this.grbx_Search.Controls.Add(this.txbx_BarcodeName);
            this.grbx_Search.Location = new System.Drawing.Point(12, 27);
            this.grbx_Search.Name = "grbx_Search";
            this.grbx_Search.Size = new System.Drawing.Size(818, 73);
            this.grbx_Search.TabIndex = 4;
            this.grbx_Search.TabStop = false;
            this.grbx_Search.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.storesToolStripMenuItem,
            this.streetToolStripMenuItem,
            this.productToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Save data to CSV";
            this.saveDataToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveDataToCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStoreToolStripMenuItem});
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.storesToolStripMenuItem.Text = "Stores";
            // 
            // addNewStoreToolStripMenuItem
            // 
            this.addNewStoreToolStripMenuItem.Name = "addNewStoreToolStripMenuItem";
            this.addNewStoreToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addNewStoreToolStripMenuItem.Text = "Add new store";
            this.addNewStoreToolStripMenuItem.Click += new System.EventHandler(this.addNewStoreToolStripMenuItem_Click);
            // 
            // streetToolStripMenuItem
            // 
            this.streetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStreetToolStripMenuItem});
            this.streetToolStripMenuItem.Name = "streetToolStripMenuItem";
            this.streetToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.streetToolStripMenuItem.Text = "Street";
            // 
            // addNewStreetToolStripMenuItem
            // 
            this.addNewStreetToolStripMenuItem.Name = "addNewStreetToolStripMenuItem";
            this.addNewStreetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addNewStreetToolStripMenuItem.Text = "Add new street";
            this.addNewStreetToolStripMenuItem.Click += new System.EventHandler(this.addNewStreetToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addNewProductToolStripMenuItem.Text = "Add new product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // txbx_BarcodeName
            // 
            this.txbx_BarcodeName.Location = new System.Drawing.Point(289, 38);
            this.txbx_BarcodeName.Name = "txbx_BarcodeName";
            this.txbx_BarcodeName.Size = new System.Drawing.Size(234, 20);
            this.txbx_BarcodeName.TabIndex = 0;
            // 
            // txbx_ProductName
            // 
            this.txbx_ProductName.Location = new System.Drawing.Point(6, 38);
            this.txbx_ProductName.Name = "txbx_ProductName";
            this.txbx_ProductName.Size = new System.Drawing.Size(271, 20);
            this.txbx_ProductName.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(549, 33);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Barcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Product";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(690, 33);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(122, 23);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 496);
            this.Controls.Add(this.grbx_Search);
            this.Controls.Add(this.grbx_Specifications);
            this.Controls.Add(this.grbx_Product);
            this.Controls.Add(this.grbx_Street);
            this.Controls.Add(this.grbx_Stores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "STORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbx_Stores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stores)).EndInit();
            this.grbx_Street.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Street)).EndInit();
            this.grbx_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.grbx_Specifications.ResumeLayout(false);
            this.grbx_Specifications.PerformLayout();
            this.grbx_Search.ResumeLayout(false);
            this.grbx_Search.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Stores;
        private System.Windows.Forms.GroupBox grbx_Street;
        private System.Windows.Forms.GroupBox grbx_Product;
        private System.Windows.Forms.DataGridView dgv_Stores;
        private System.Windows.Forms.DataGridView dgv_Street;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.GroupBox grbx_Specifications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Barcode;
        private System.Windows.Forms.TextBox txbx_Width;
        private System.Windows.Forms.TextBox txbx_Height;
        private System.Windows.Forms.TextBox txbx_Connector;
        private System.Windows.Forms.TextBox txbx_Colour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbx_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStreetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txbx_ProductName;
        private System.Windows.Forms.TextBox txbx_BarcodeName;
        private System.Windows.Forms.Button btn_Next;
    }
}

