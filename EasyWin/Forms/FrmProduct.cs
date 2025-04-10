using EasyWin.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            bindCustomer();
        }

        private async void bindCustomer()
        {
            AppDbContext appDbContext = new AppDbContext();
            dataGridView1.DataSource = await appDbContext.AcmAsync();

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string _colon = ": ";
            var selectedCustomer = (Acms)dataGridView1.CurrentRow.DataBoundItem;
            lblCode.Text = selectedCustomer.Code.ToString();
            lblContact.Text = _colon + selectedCustomer.Contact1Mobile;
            lblGender.Text = _colon + "Male";
            lblEmail.Text = _colon + selectedCustomer.Email;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                return;
            }
            AppDbContext appDbContext = new AppDbContext();
            dataGridView1.DataSource = await appDbContext.AcmSearchAsync(search);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmCustomerEdit frmCustomerEdit = new FrmCustomerEdit();
            frmCustomerEdit.ShowDialog();
        }
    }
}
