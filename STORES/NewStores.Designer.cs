
namespace STORES
{
    partial class NewStores
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
            this.txbx_NewStores = new System.Windows.Forms.TextBox();
            this.txbx_NSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SaveNewStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_NewStores
            // 
            this.txbx_NewStores.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_NewStores.Location = new System.Drawing.Point(53, 79);
            this.txbx_NewStores.Name = "txbx_NewStores";
            this.txbx_NewStores.Size = new System.Drawing.Size(210, 20);
            this.txbx_NewStores.TabIndex = 0;
            this.txbx_NewStores.TextChanged += new System.EventHandler(this.txbx_NewStores_TextChanged);
            // 
            // txbx_NSID
            // 
            this.txbx_NSID.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_NSID.Location = new System.Drawing.Point(53, 28);
            this.txbx_NSID.Name = "txbx_NSID";
            this.txbx_NSID.ReadOnly = true;
            this.txbx_NSID.Size = new System.Drawing.Size(210, 20);
            this.txbx_NSID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_SaveNewStore
            // 
            this.btn_SaveNewStore.Location = new System.Drawing.Point(30, 120);
            this.btn_SaveNewStore.Name = "btn_SaveNewStore";
            this.btn_SaveNewStore.Size = new System.Drawing.Size(218, 23);
            this.btn_SaveNewStore.TabIndex = 4;
            this.btn_SaveNewStore.Text = "Save New Store";
            this.btn_SaveNewStore.UseVisualStyleBackColor = true;
            this.btn_SaveNewStore.Click += new System.EventHandler(this.btn_SaveNewStore_Click);
            // 
            // NewStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 155);
            this.Controls.Add(this.btn_SaveNewStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_NSID);
            this.Controls.Add(this.txbx_NewStores);
            this.Name = "NewStores";
            this.Text = "NewStores";
            this.Load += new System.EventHandler(this.NewStores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_NewStores;
        private System.Windows.Forms.TextBox txbx_NSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SaveNewStore;
    }
}