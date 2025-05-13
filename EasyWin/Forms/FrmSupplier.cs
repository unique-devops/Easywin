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
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmSupplierEdit frmSupplierEdit = new FrmSupplierEdit();
            frmSupplierEdit.MdiParent = this.MdiParent;
            frmSupplierEdit.Show();
        }
    }
}
