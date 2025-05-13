using EasyWin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyWin
{
    public partial class MDI : Form
    {
        private int childFormNumber = 0;
        private List<Type> recentForms = new List<Type>();

        public MDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer frmUser = new FrmCustomer();
            frmUser.WindowState = FormWindowState.Maximized;
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmSalePOS>();
        }

        private void MDI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (ActiveMdiChild != null)
                {
                    Form currentActiveForm = this.ActiveMdiChild;
                    currentActiveForm.Close();
                }

            }
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmProduct>();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
            this.MdiChildActivate += MDI_MdiChildActivate;
        }

        private void MDI_MdiChildActivate(object? sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.WindowState != FormWindowState.Maximized)
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmSupplier>();
        }

        public void OpenForm<T>() where T : Form, new()
        {
            // Check if form already open
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.BringToFront();
                    child.WindowState = FormWindowState.Maximized;
                    child.Activate();
                    return;
                }
            }

            // If not open, create and show
            var form = new T
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }

        public void OpenForm(Form form)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == form.GetType())
                {
                    child.BringToFront();
                    child.WindowState = FormWindowState.Maximized;
                    child.Activate();
                    return;
                }
            }

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            // Update recent forms list
            //AddToRecentForms(typeof(T));
        }
        private void AddToRecentForms(Type formType)
        {
            if (recentForms.Contains(formType))
            {
                recentForms.Remove(formType);
            }

            recentForms.Insert(0, formType); // Add to top
            if (recentForms.Count > 10)
                recentForms.RemoveAt(10); // Keep max 10 recent

            RefreshRecentFormsMenu();
        }
        private void RefreshRecentFormsMenu()
        {
            //recentFormsToolStripMenuItem.DropDownItems.Clear();

            //foreach (var formType in recentForms)
            //{
            //    var item = new ToolStripMenuItem(formType.Name);
            //    item.Tag = formType;
            //    item.Click += (s, e) =>
            //    {
            //        Type type = (Type)((ToolStripMenuItem)s).Tag;
            //        MethodInfo method = typeof(MainForm).GetMethod("OpenForm");
            //        MethodInfo generic = method.MakeGenericMethod(type);
            //        generic.Invoke(this, null);
            //    };
            //    recentFormsToolStripMenuItem.DropDownItems.Add(item);
            //}
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Alt | Keys.C))
            {
                OpenForm<FrmCustomer>();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Alt | Keys.I))
            {
                OpenForm<FrmProduct>();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



    }
}
