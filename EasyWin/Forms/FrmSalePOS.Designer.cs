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
            dataGridView1 = new DataGridView();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.41854F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5814581F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0994473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.90055F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Size = new Size(1111, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_srno, col_code, col_name, col_batch, col_exp, col_qty, col_free_qty, col_mrp, col_sale_rate, col_discount, col_total_amount });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(943, 413);
            dataGridView1.TabIndex = 0;
            // 
            // col_srno
            // 
            col_srno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_srno.HeaderText = "SrNo";
            col_srno.Name = "col_srno";
            col_srno.ReadOnly = true;
            col_srno.Width = 50;
            // 
            // col_code
            // 
            col_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_code.HeaderText = "Code";
            col_code.MinimumWidth = 100;
            col_code.Name = "col_code";
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
            // FrmSalePOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 621);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "FrmSalePOS";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSalePOS";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
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
    }
}