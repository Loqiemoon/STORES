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
    public partial class MainForm : Form
    {

        DAL dal = new DAL();
        public MainForm()
        {
            InitializeComponent();

            ArrayList allStores = dal.GetAllStores();

            dgv_Stores.DataSource = allStores;
            SettingDGV_Stores();
        }

        void SettingDGV_Stores()
        {
            try
            {
                dgv_Stores.Columns[0].Visible = false;
                dgv_Stores.TopLeftHeaderCell.Value = "#";
            }
            catch
            { 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgv_Stores.CellEnter += new DataGridViewCellEventHandler(dgv_Stores_CellEnter);
            //dgv_Street.CellEnter += new DataGridViewCellEventHandler(dgv_Street_CellEnter);
            //dgv_Product.CellEnter += new DataGridViewCellEventHandler(dgv_Product_CellEnter);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgv_Stores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string StoresID = dgv_Stores.CurrentRow.Cells[0].Value.ToString();
            dgv_Street.DataSource = dal.GetAllSteetForStores(StoresID);
            try
            {
                dgv_Street.Columns[0].Visible = false;
                dgv_Street.Columns[2].Visible = false;
                dgv_Street.TopLeftHeaderCell.Value = "#";
            }
            catch
            {

            }
        }

        private void dgv_Street_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string StreetID = dgv_Street.CurrentRow.Cells[0].Value.ToString();
            dgv_Product.DataSource = dal.GetAllProductForStreet(StreetID);
            try
            {
                dgv_Product.Columns[0].Visible = false;
                dgv_Product.Columns[4].Visible = false;
                dgv_Product.Columns[5].Visible = false;
                dgv_Product.Columns[6].Visible = false;
                dgv_Product.Columns[7].Visible = false;
                dgv_Product.Columns[8].Visible = false;
                dgv_Product.Columns[9].Visible = false;
                dgv_Product.TopLeftHeaderCell.Value = "#";
            }
            catch
            {

            }
        }

        private void dgv_Product_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbx_Colour.Text = dgv_Product.Rows[e.RowIndex].Cells[5].Value.ToString();
            txbx_Height.Text = dgv_Product.Rows[e.RowIndex].Cells[7].Value.ToString();
            txbx_Width.Text = dgv_Product.Rows[e.RowIndex].Cells[8].Value.ToString();
            txbx_Barcode.Text = dgv_Product.Rows[e.RowIndex].Cells[9].Value.ToString();

            string conn = dgv_Product.Rows[e.RowIndex].Cells[6].Value.ToString();
            txbx_Connector.Text = (conn == String.Empty) ? "Net razemov" : conn;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете закрыть приложение?", "Store manager", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStores newStores = new NewStores();
            if (newStores.ShowDialog() == DialogResult.OK)
            {
                dgv_Stores.DataSource = dal.GetAllStores();
                MessageBox.Show("Новый магазин создан", "Магазин", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Новый магазин не создан!", "Магазин", MessageBoxButtons.OK);
        }

        private void addNewStreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStreet newStreet = new NewStreet();
            if (newStreet.ShowDialog() == DialogResult.OK)
            {
                dgv_Street.DataSource = dal.GetAllSteetForStores(dgv_Stores.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Новая улица добавлена", "Магазин", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Новая улица не добавлена!", "Магазин", MessageBoxButtons.OK);
            }
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            if (newProduct.ShowDialog() == DialogResult.OK)
            {
                dgv_Street.DataSource = dal.GetAllSteetForStores(dgv_Stores.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Новый продукт добавлен", "Магазин", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Новый продукт не добавлен!", "Магазин", MessageBoxButtons.OK);
            }
        }

        private void saveDataToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveDBToLocalFile())
                MessageBox.Show("Данные БД были успешно сохранены в локальных файлах", "Магазин", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены в локальных файлах!", "Магазин", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (headValue == null || !headValue.Equals((e.RowIndex + 1).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        List<DataGridViewRow> searchedRows;
        int currentRow;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            string SBarcode = txbx_BarcodeName.Text.Trim();
            string ProductName = txbx_ProductName.Text.Trim();

            foreach(DataGridViewRow row in dgv_Product.Rows)
            {
                if (row.Cells["Name"].FormattedValue.ToString().Contains(ProductName) &&
                   row.Cells["Barcode"].FormattedValue.ToString().Contains(SBarcode))
                    searchedRows.Add(row);
            }
            if (searchedRows.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
                btn_Next.Enabled = false;
                return;
            }
            MessageBox.Show("Найдено " + searchedRows.Count + " записей");
            btn_Next.Enabled = true;
            currentRow = -1;
            btn_Next_Click(null, null);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRows.Count - 1)
                currentRow = 0;
            else
                currentRow++;
            dgv_Product.CurrentCell = searchedRows[currentRow].Cells[1];

        }
    }
}