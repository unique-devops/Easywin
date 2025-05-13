namespace EasyWin.Forms
{
    partial class FrmSalePOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvSalePOS = new DataGridView();
            col_srno = new DataGridViewTextBoxColumn();
            col_code = new DataGridViewTextBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            col_batch = new DataGridViewTextBoxColumn();
            col_exp = new DataGridViewTextBoxColumn();
            col_qty = new DataGridViewTextBoxColumn();
            col_free_qty = new DataGridViewTextBoxColumn();
            col_mrp = new DataGridViewTextBoxColumn();
            col_sale_rate = new DataGridViewTextBoxColumn();
            col_discount = new DataGridViewTextBoxColumn();
            col_total_amount = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalePOS).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.41854F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5814581F));
            tableLayoutPanel1.Controls.Add(dgvSalePOS, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0994473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.90055F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.Size = new Size(1270, 828);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvSalePOS
            // 
            dgvSalePOS.AllowUserToAddRows = false;
            dgvSalePOS.AllowUserToResizeRows = false;
            dgvSalePOS.BackgroundColor = Color.White;
            dgvSalePOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalePOS.Columns.AddRange(new DataGridViewColumn[] { col_srno, col_code, col_name, col_batch, col_exp, col_qty, col_free_qty, col_mrp, col_sale_rate, col_discount, col_total_amount });
            dgvSalePOS.Dock = DockStyle.Fill;
            dgvSalePOS.Location = new Point(3, 162);
            dgvSalePOS.Margin = new Padding(3, 4, 3, 4);
            dgvSalePOS.MultiSelect = false;
            dgvSalePOS.Name = "dgvSalePOS";
            dgvSalePOS.RowHeadersVisible = false;
            dgvSalePOS.RowHeadersWidth = 51;
            dgvSalePOS.Size = new Size(1078, 552);
            dgvSalePOS.TabIndex = 0;
            // 
            // col_srno
            // 
            col_srno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_srno.HeaderText = "SrNo";
            col_srno.MinimumWidth = 6;
            col_srno.Name = "col_srno";
            col_srno.SortMode = DataGridViewColumnSortMode.NotSortable;
            col_srno.Width = 50;
            // 
            // col_code
            // 
            col_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_code.HeaderText = "Code";
            col_code.MinimumWidth = 100;
            col_code.Name = "col_code";
            col_code.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // col_name
            // 
            col_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_name.HeaderText = "Name";
            col_name.MinimumWidth = 250;
            col_name.Name = "col_name";
            // 
            // col_batch
            // 
            col_batch.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_batch.HeaderText = "Batch";
            col_batch.MinimumWidth = 100;
            col_batch.Name = "col_batch";
            // 
            // col_exp
            // 
            col_exp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_exp.HeaderText = "exp";
            col_exp.MinimumWidth = 50;
            col_exp.Name = "col_exp";
            // 
            // col_qty
            // 
            col_qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_qty.HeaderText = "Qty";
            col_qty.MinimumWidth = 50;
            col_qty.Name = "col_qty";
            // 
            // col_free_qty
            // 
            col_free_qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_free_qty.HeaderText = "Free";
            col_free_qty.MinimumWidth = 50;
            col_free_qty.Name = "col_free_qty";
            // 
            // col_mrp
            // 
            col_mrp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_mrp.HeaderText = "Mrp";
            col_mrp.MinimumWidth = 70;
            col_mrp.Name = "col_mrp";
            // 
            // col_sale_rate
            // 
            col_sale_rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_sale_rate.HeaderText = "SaleRate";
            col_sale_rate.MinimumWidth = 70;
            col_sale_rate.Name = "col_sale_rate";
            // 
            // col_discount
            // 
            col_discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_discount.HeaderText = "Discount";
            col_discount.MinimumWidth = 50;
            col_discount.Name = "col_discount";
            // 
            // col_total_amount
            // 
            col_total_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_total_amount.HeaderText = "Amount";
            col_total_amount.MinimumWidth = 100;
            col_total_amount.Name = "col_total_amount";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 152);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(330, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "To Customer/Patient";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 56);
            label5.Name = "label5";
            label5.Size = new Size(80, 28);
            label5.TabIndex = 3;
            label5.Text = "Mobile:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 2;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 6);
            label2.Name = "label2";
            label2.Size = new Size(34, 28);
            label2.TabIndex = 1;
            label2.Text = "12";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 0;
            label1.Text = "Bill no         :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 45);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 3;
            label6.Text = "Date           :";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 84);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 4;
            label7.Text = "Counter no :";
            label7.Click += label7_Click;
            // 
            // FrmSalePOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 828);
            Controls.Add(tableLayoutPanel1);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmSalePOS";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSalePOS";
            WindowState = FormWindowState.Maximized;
            Load += FrmSalePOS_Load;
            KeyDown += FrmSalePOS_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSalePOS).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvSalePOS;
        private DataGridViewTextBoxColumn col_srno;
        private DataGridViewTextBoxColumn col_code;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_batch;
        private DataGridViewTextBoxColumn col_exp;
        private DataGridViewTextBoxColumn col_qty;
        private DataGridViewTextBoxColumn col_free_qty;
        private DataGridViewTextBoxColumn col_mrp;
        private DataGridViewTextBoxColumn col_sale_rate;
        private DataGridViewTextBoxColumn col_discount;
        private DataGridViewTextBoxColumn col_total_amount;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}