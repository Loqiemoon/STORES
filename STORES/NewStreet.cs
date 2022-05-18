using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace STORES
{
    public partial class NewStreet : Form
    {
        ArrayList allStores;
        DAL dal = new DAL();

        public NewStreet()
        {
            InitializeComponent();
            txbx_NSTRID.Text = Guid.NewGuid().ToString();

            allStores = dal.GetAllStores();
            lb_StoresID.DataSource = allStores;
            lb_Name.DataSource = allStores;
        }

        private void btn_SaveNewStore_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewStreet(new Guid(txbx_NSTRID.Text), (txbx_NewStreet.Text), new Guid(lb_StoresID.SelectedValue.ToString())))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void txbx_NewStreet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
