using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STORES
{
    public partial class NewStores : Form
    {
        DAL dal = new DAL();
        public NewStores()
        {
            InitializeComponent();
            txbx_NSID.Text = Guid.NewGuid().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewStores_Load(object sender, EventArgs e)
        {

        }

        private void btn_SaveNewStore_Click(object sender, EventArgs e)
        {
            if(dal.SaveNewStore(txbx_NSID.Text.Trim(), txbx_NewStores.Text.Trim()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void txbx_NewStores_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
