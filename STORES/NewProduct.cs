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
    public partial class NewProduct : Form
    {
        ArrayList allStores;
        ArrayList allStreet;
        DAL dal = new DAL();

        public NewProduct()
        {
            InitializeComponent();
            txbx_NPID.Text = Guid.NewGuid().ToString();

            allStores = dal.GetAllStores();
            lb_StoresID.DataSource = allStores;
            lb_NameStore.DataSource = allStores;
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_SaveNewProduct_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewProduct(new Guid(txbx_NPID.Text), (txbx_NewProduct.Text), Int32.Parse(txbx_Quantity.Text), (txbx_Price.Text), 
                new Guid(lb_StreetID.SelectedValue.ToString()), (txbx_Colour.Text), (txbx_Connector.Text), (txbx_Height.Text), 
                (txbx_Width.Text), (txbx_Barcode.Text)))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void lb_StoresID_SelectedIndexChanged(object sender, EventArgs e)
        {
            allStreet = dal.GetAllSteetForStores(lb_StoresID.SelectedValue.ToString());
            lb_StreetID.DataSource = allStreet;
            lb_Name.DataSource = allStreet;
        }
    }
}
