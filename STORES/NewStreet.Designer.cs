
namespace STORES
{
    partial class NewStreet
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
            this.btn_SaveNewStreet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_NSTRID = new System.Windows.Forms.TextBox();
            this.txbx_NewStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_StoresID = new System.Windows.Forms.ListBox();
            this.lb_Name = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_SaveNewStreet
            // 
            this.btn_SaveNewStreet.Location = new System.Drawing.Point(37, 228);
            this.btn_SaveNewStreet.Name = "btn_SaveNewStreet";
            this.btn_SaveNewStreet.Size = new System.Drawing.Size(218, 23);
            this.btn_SaveNewStreet.TabIndex = 9;
            this.btn_SaveNewStreet.Text = "Save New Street";
            this.btn_SaveNewStreet.UseVisualStyleBackColor = true;
            this.btn_SaveNewStreet.Click += new System.EventHandler(this.btn_SaveNewStore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txbx_NSTRID
            // 
            this.txbx_NSTRID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_NSTRID.Location = new System.Drawing.Point(67, 15);
            this.txbx_NSTRID.Name = "txbx_NSTRID";
            this.txbx_NSTRID.ReadOnly = true;
            this.txbx_NSTRID.Size = new System.Drawing.Size(210, 20);
            this.txbx_NSTRID.TabIndex = 6;
            // 
            // txbx_NewStreet
            // 
            this.txbx_NewStreet.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_NewStreet.Location = new System.Drawing.Point(67, 66);
            this.txbx_NewStreet.Name = "txbx_NewStreet";
            this.txbx_NewStreet.Size = new System.Drawing.Size(210, 20);
            this.txbx_NewStreet.TabIndex = 5;
            this.txbx_NewStreet.TextChanged += new System.EventHandler(this.txbx_NewStreet_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "StoresID";
            // 
            // lb_StoresID
            // 
            this.lb_StoresID.DisplayMember = "ID";
            this.lb_StoresID.FormattingEnabled = true;
            this.lb_StoresID.Location = new System.Drawing.Point(66, 109);
            this.lb_StoresID.Name = "lb_StoresID";
            this.lb_StoresID.Size = new System.Drawing.Size(210, 43);
            this.lb_StoresID.TabIndex = 12;
            this.lb_StoresID.ValueMember = "ID";
            // 
            // lb_Name
            // 
            this.lb_Name.DisplayMember = "Name";
            this.lb_Name.FormattingEnabled = true;
            this.lb_Name.Location = new System.Drawing.Point(66, 161);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(210, 56);
            this.lb_Name.TabIndex = 13;
            this.lb_Name.ValueMember = "ID";
            // 
            // NewStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 263);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_StoresID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SaveNewStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_NSTRID);
            this.Controls.Add(this.txbx_NewStreet);
            this.Name = "NewStreet";
            this.Text = "NewStreet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveNewStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_NSTRID;
        private System.Windows.Forms.TextBox txbx_NewStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_StoresID;
        private System.Windows.Forms.ListBox lb_Name;
    }
}