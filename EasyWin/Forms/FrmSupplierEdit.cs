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
    public partial class FrmSupplierEdit : Form
    {
        public FrmSupplierEdit()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            InitializeLayout();
        }
        private void InitializeLayout()
        {
            this.Text = "Item Master";
            this.Size = new Size(700, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Title Label
            //Label lblTitle = new Label()
            //{
            //    Text = "Item Master Entry",
            //    Font = new Font("Segoe UI", 18, FontStyle.Bold),
            //    Dock = DockStyle.Top,
            //    Height = 50,
            //    TextAlign = ContentAlignment.MiddleCenter,
            //    BackColor = Color.LightSteelBlue
            //};
            //this.Controls.Add(lblTitle);

            // Tabs
            TabControl tabControl = new TabControl()
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.Controls.Add(tabControl);

            tabControl.TabPages.Add(CreateBasicTab());
            tabControl.TabPages.Add(CreatePricingTab());
            tabControl.TabPages.Add(CreateManufacturerTab());
            tabControl.TabPages.Add(CreateStockTab());
            tabControl.TabPages.Add(CreateOtherTab());

            // Bottom Panel with Buttons
            Panel bottomPanel = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.WhiteSmoke
            };

            Button btnSave = new Button()
            {
                Text = "Save",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                Width = 100,
                Height = 40,
                Location = new Point(400, 10)
            };

            Button btnCancel = new Button()
            {
                Text = "Cancel",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                Width = 100,
                Height = 40,
                Location = new Point(520, 10)
            };

            bottomPanel.Controls.Add(btnSave);
            bottomPanel.Controls.Add(btnCancel);
            this.Controls.Add(bottomPanel);
        }
        private TabPage CreateBasicTab()
        {
            TabPage tab = new TabPage("Basic Details");            
            FlowLayoutPanel panel = CreateFormPanel();

            panel.Controls.Add(CreateLabelTextBox("Item Name:", 250));
            panel.Controls.Add(CreateLabelTextBox("Barcode:", 250));
            panel.Controls.Add(CreateLabelTextBox("Category:", 250));
            panel.Controls.Add(CreateLabelTextBox("Group:", 250));
            panel.Controls.Add(CreateLabelTextBox("Unit:", 250));
            panel.Controls.Add(CreateLabelTextBox("HSN Code:", 250));
           
            tab.Controls.Add(panel);
            return tab;
        }
        private TabPage CreatePricingTab()
        {
            TabPage tab = new TabPage("Pricing");

            FlowLayoutPanel panel = CreateFormPanel();

            panel.Controls.Add(CreateLabelTextBox("MRP:", 250));
            panel.Controls.Add(CreateLabelTextBox("Sale Price:", 250));
            panel.Controls.Add(CreateLabelTextBox("Purchase Price:", 250));
            panel.Controls.Add(CreateLabelTextBox("Tax Rate (%):", 250));

            tab.Controls.Add(panel);
            return tab;
        }
        private TabPage CreateManufacturerTab()
        {
            TabPage tab = new TabPage("Manufacturer");

            FlowLayoutPanel panel = CreateFormPanel();

            panel.Controls.Add(CreateLabelTextBox("Company Name:", 250));
            panel.Controls.Add(CreateLabelTextBox("Batch No:", 250));
            panel.Controls.Add(CreateLabelTextBox("Mfg Date:", 250));
            panel.Controls.Add(CreateLabelTextBox("Exp Date:", 250));

            tab.Controls.Add(panel);
            return tab;
        }
        private TabPage CreateStockTab()
        {
            TabPage tab = new TabPage("Stock");

            FlowLayoutPanel panel = CreateFormPanel();

            panel.Controls.Add(CreateLabelTextBox("Opening Stock:", 250));
            panel.Controls.Add(CreateLabelTextBox("Min Stock Level:", 250));
            panel.Controls.Add(CreateLabelTextBox("Storage Location:", 250));

            tab.Controls.Add(panel);
            return tab;
        }

        private TabPage CreateOtherTab()
        {
            TabPage tab = new TabPage("Other Info");

            FlowLayoutPanel panel = CreateFormPanel();

            panel.Controls.Add(CreateLabelTextBox("Item Type:", 250));
            panel.Controls.Add(CreateLabelTextBox("Remarks:", 250));
            panel.Controls.Add(CreateCheckbox("Is Active"));

            tab.Controls.Add(panel);
            return tab;
        }
        private FlowLayoutPanel CreateFormPanel()
        {
            return new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false,
                //Padding = new Padding(10),
            };
        }
        private Panel CreateLabelTextBox(string labelText, int textboxWidth)
        {
            Panel panel = new Panel()
            {
                Height = 40,
                //Dock = DockStyle.Top,                
            };

            Label label = new Label()
            {
                Text = labelText,
                Width = 150,
                TextAlign = ContentAlignment.MiddleRight
            };

            TextBox textbox = new TextBox()
            {
                Width = textboxWidth,
                Margin = new Padding(10, 5, 0, 5)
            };

            panel.Controls.Add(label);
            panel.Controls.Add(textbox);
            label.Location = new Point(0, 10);
            textbox.Location = new Point(160, 5);

            return panel;
        }
        private Panel CreateCheckbox(string labelText)
        {
            Panel panel = new Panel()
            {
                Height = 40,
                //Dock = DockStyle.Top
            };

            CheckBox checkbox = new CheckBox()
            {
                Text = labelText,
                Font = new Font("Segoe UI", 10),
                AutoSize = true
            };

            panel.Controls.Add(checkbox);
            checkbox.Location = new Point(10, 10);

            return panel;
        }
    }
}
