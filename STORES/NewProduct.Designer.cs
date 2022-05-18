
namespace STORES
{
    partial class NewProduct
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
            this.lb_Name = new System.Windows.Forms.ListBox();
            this.lb_StreetID = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SaveNewProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_NPID = new System.Windows.Forms.TextBox();
            this.txbx_NewProduct = new System.Windows.Forms.TextBox();
            this.txbx_Quantity = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.txbx_Price = new System.Windows.Forms.TextBox();
            this.txbx_Colour = new System.Windows.Forms.TextBox();
            this.txbx_Connector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_Height = new System.Windows.Forms.TextBox();
            this.txbx_Width = new System.Windows.Forms.TextBox();
            this.txbx_Barcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_StoresID = new System.Windows.Forms.ListBox();
            this.lb_NameStore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.DisplayMember = "Name";
            this.lb_Name.FormattingEnabled = true;
            this.lb_Name.Location = new System.Drawing.Point(63, 286);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(210, 43);
            this.lb_Name.TabIndex = 21;
            this.lb_Name.ValueMember = "ID";
            // 
            // lb_StreetID
            // 
            this.lb_StreetID.DisplayMember = "ID";
            this.lb_StreetID.FormattingEnabled = true;
            this.lb_StreetID.Location = new System.Drawing.Point(63, 237);
            this.lb_StreetID.Name = "lb_StreetID";
            this.lb_StreetID.Size = new System.Drawing.Size(210, 43);
            this.lb_StreetID.TabIndex = 20;
            this.lb_StreetID.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "StreetID";
            // 
            // btn_SaveNewProduct
            // 
            this.btn_SaveNewProduct.Location = new System.Drawing.Point(112, 369);
            this.btn_SaveNewProduct.Name = "btn_SaveNewProduct";
            this.btn_SaveNewProduct.Size = new System.Drawing.Size(422, 23);
            this.btn_SaveNewProduct.TabIndex = 18;
            this.btn_SaveNewProduct.Text = "Save New Product";
            this.btn_SaveNewProduct.UseVisualStyleBackColor = true;
            this.btn_SaveNewProduct.Click += new System.EventHandler(this.btn_SaveNewProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // txbx_NPID
            // 
            this.txbx_NPID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_NPID.Location = new System.Drawing.Point(63, 20);
            this.txbx_NPID.Name = "txbx_NPID";
            this.txbx_NPID.ReadOnly = true;
            this.txbx_NPID.Size = new System.Drawing.Size(210, 20);
            this.txbx_NPID.TabIndex = 15;
            // 
            // txbx_NewProduct
            // 
            this.txbx_NewProduct.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_NewProduct.Location = new System.Drawing.Point(63, 71);
            this.txbx_NewProduct.Name = "txbx_NewProduct";
            this.txbx_NewProduct.Size = new System.Drawing.Size(210, 20);
            this.txbx_NewProduct.TabIndex = 14;
            // 
            // txbx_Quantity
            // 
            this.txbx_Quantity.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Quantity.Location = new System.Drawing.Point(414, 20);
            this.txbx_Quantity.Name = "txbx_Quantity";
            this.txbx_Quantity.Size = new System.Drawing.Size(210, 20);
            this.txbx_Quantity.TabIndex = 22;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(318, 26);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 23;
            this.Quantity.Text = "Quantity";
            // 
            // txbx_Price
            // 
            this.txbx_Price.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Price.Location = new System.Drawing.Point(414, 71);
            this.txbx_Price.Name = "txbx_Price";
            this.txbx_Price.Size = new System.Drawing.Size(210, 20);
            this.txbx_Price.TabIndex = 24;
            // 
            // txbx_Colour
            // 
            this.txbx_Colour.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Colour.Location = new System.Drawing.Point(414, 114);
            this.txbx_Colour.Name = "txbx_Colour";
            this.txbx_Colour.Size = new System.Drawing.Size(210, 20);
            this.txbx_Colour.TabIndex = 25;
            // 
            // txbx_Connector
            // 
            this.txbx_Connector.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Connector.Location = new System.Drawing.Point(414, 166);
            this.txbx_Connector.Name = "txbx_Connector";
            this.txbx_Connector.Size = new System.Drawing.Size(210, 20);
            this.txbx_Connector.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Colour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Connector";
            // 
            // txbx_Height
            // 
            this.txbx_Height.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Height.Location = new System.Drawing.Point(414, 215);
            this.txbx_Height.Name = "txbx_Height";
            this.txbx_Height.Size = new System.Drawing.Size(210, 20);
            this.txbx_Height.TabIndex = 30;
            // 
            // txbx_Width
            // 
            this.txbx_Width.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Width.Location = new System.Drawing.Point(414, 262);
            this.txbx_Width.Name = "txbx_Width";
            this.txbx_Width.Size = new System.Drawing.Size(210, 20);
            this.txbx_Width.TabIndex = 31;
            // 
            // txbx_Barcode
            // 
            this.txbx_Barcode.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_Barcode.Location = new System.Drawing.Point(414, 309);
            this.txbx_Barcode.Name = "txbx_Barcode";
            this.txbx_Barcode.Size = new System.Drawing.Size(210, 20);
            this.txbx_Barcode.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Width";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Barcode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "StoresID";
            // 
            // lb_StoresID
            // 
            this.lb_StoresID.DisplayMember = "ID";
            this.lb_StoresID.FormattingEnabled = true;
            this.lb_StoresID.Location = new System.Drawing.Point(63, 114);
            this.lb_StoresID.Name = "lb_StoresID";
            this.lb_StoresID.Size = new System.Drawing.Size(210, 43);
            this.lb_StoresID.TabIndex = 37;
            this.lb_StoresID.ValueMember = "ID";
            this.lb_StoresID.SelectedIndexChanged += new System.EventHandler(this.lb_StoresID_SelectedIndexChanged);
            // 
            // lb_NameStore
            // 
            this.lb_NameStore.DisplayMember = "Name";
            this.lb_NameStore.FormattingEnabled = true;
            this.lb_NameStore.Location = new System.Drawing.Point(63, 166);
            this.lb_NameStore.Name = "lb_NameStore";
            this.lb_NameStore.Size = new System.Drawing.Size(210, 43);
            this.lb_NameStore.TabIndex = 38;
            this.lb_NameStore.ValueMember = "ID";
            this.lb_NameStore.SelectedIndexChanged += new System.EventHandler(this.lb_StoresID_SelectedIndexChanged);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 404);
            this.Controls.Add(this.lb_NameStore);
            this.Controls.Add(this.lb_StoresID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbx_Barcode);
            this.Controls.Add(this.txbx_Width);
            this.Controls.Add(this.txbx_Height);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_Connector);
            this.Controls.Add(this.txbx_Colour);
            this.Controls.Add(this.txbx_Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txbx_Quantity);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_StreetID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SaveNewProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_NPID);
            this.Controls.Add(this.txbx_NewProduct);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Name;
        private System.Windows.Forms.ListBox lb_StreetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SaveNewProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_NPID;
        private System.Windows.Forms.TextBox txbx_NewProduct;
        private System.Windows.Forms.TextBox txbx_Quantity;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txbx_Price;
        private System.Windows.Forms.TextBox txbx_Colour;
        private System.Windows.Forms.TextBox txbx_Connector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_Height;
        private System.Windows.Forms.TextBox txbx_Width;
        private System.Windows.Forms.TextBox txbx_Barcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lb_StoresID;
        private System.Windows.Forms.ListBox lb_NameStore;
    }
}