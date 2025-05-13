using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyWin.Forms
{
    public partial class FrmSalePOS : Form
    {
        public FrmSalePOS()
        {
            InitializeComponent();
        }

        private void FrmSalePOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvSalePOS.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                int rowIndex = dgvSalePOS.CurrentCell.RowIndex;

                ShowItemForm(rowIndex); // Pass current row index

            }
            else if (e.KeyCode == Keys.Enter && dgvSalePOS.CurrentCell.ColumnIndex == 5 && dgvSalePOS.CurrentCell != null)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                dgvSalePOS.CurrentCell = dgvSalePOS.Rows[dgvSalePOS.Rows.Count - 1].Cells[1];
                //dgvSalePOS.Rows[dgvSalePOS.Rows.Count-1].Cells[1].Selected = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }
        FrmProduct frmProduct;
        private void ShowItemForm(int rowIndex)
        {
            if (frmProduct == null || frmProduct.IsDisposed)
            {
                frmProduct = new FrmProduct();
                frmProduct.ItemSelected += (s, selectedItem) =>
                {
                    // Fill selected item into current POS grid row                   
                    dgvSalePOS.Rows[rowIndex].Cells[1].Value = selectedItem.Code;
                    dgvSalePOS.Rows[rowIndex].Cells[2].Value = selectedItem.Name;
                    dgvSalePOS.Rows[rowIndex].Cells[5].Value = 1;
                    dgvSalePOS.Rows[rowIndex].Cells[7].Value = selectedItem.Price;
                    dgvSalePOS.Rows[rowIndex].Cells[8].Value = selectedItem.Price;
                    dgvSalePOS.Rows[rowIndex].Cells[10].Value = selectedItem.Price * 1;
                    // Add more fields if needed
                    dgvSalePOS.CurrentCell = dgvSalePOS.Rows[rowIndex].Cells[5]; // move to price or quantity etc.                    
                    dgvSalePOS.Rows.Add(1);

                };
            }

            frmProduct.StartPosition = FormStartPosition.CenterParent;
            frmProduct.Show();
            frmProduct.BringToFront();
        }

        private void FrmSalePOS_Load(object sender, EventArgs e)
        {
            dgvSalePOS.Rows.Add(1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
