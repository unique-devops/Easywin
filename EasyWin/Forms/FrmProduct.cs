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
        public event EventHandler<Item> ItemSelected;
        public Acms selectedItem;
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
            selectedItem = (Acms)dataGridView1.CurrentRow.DataBoundItem;
            lblCode.Text = selectedItem.Code.ToString();
            lblContact.Text = _colon + selectedItem.Contact1Mobile;
            lblGender.Text = _colon + "Male";
            lblEmail.Text = _colon + selectedItem.Email;
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

        private void FrmProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectedItem = GetSelectedItem(); // however you select it
                ItemSelected?.Invoke(this, selectedItem);
                this.Close();
            }
        }

        private Item GetSelectedItem()
        {
           
            return new Item
            {
                Code = selectedItem.Code,
                Name = selectedItem.Name,
                Price = 99.99m
            };
        }
    }
}
