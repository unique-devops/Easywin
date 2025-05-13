namespace EasyWin.Forms
{
    partial class FrmSupplier
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            richTextButton1 = new Components.RichTextButton();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            btnNew = new Components.RichTextButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(richTextButton1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 38);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // richTextButton1
            // 
            richTextButton1.ActionColor = Color.Green;
            richTextButton1.ActionText = "Text";
            richTextButton1.BackColor = Color.LightGray;
            richTextButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            richTextButton1.Location = new Point(507, 4);
            richTextButton1.Name = "richTextButton1";
            richTextButton1.ShortcutColor = Color.Red;
            richTextButton1.ShortcutFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            richTextButton1.ShortcutText = "Key:";
            richTextButton1.Size = new Size(106, 29);
            richTextButton1.TabIndex = 1;
            richTextButton1.TextAlign = ContentAlignment.MiddleLeft;
            richTextButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Supplier..";
            textBox1.Size = new Size(480, 27);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 531);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 43);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(746, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 460);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(746, 460);
            dataGridView1.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.ActionColor = Color.Green;
            btnNew.ActionText = "New";
            btnNew.BackColor = Color.LightGray;
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.Location = new Point(619, 4);
            btnNew.Name = "btnNew";
            btnNew.ShortcutColor = Color.Red;
            btnNew.ShortcutFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNew.ShortcutText = "N:";
            btnNew.Size = new Size(106, 29);
            btnNew.TabIndex = 2;
            btnNew.TextAlign = ContentAlignment.MiddleLeft;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // FrmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 574);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmSupplier";
            Text = "FrmSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Components.RichTextButton richTextButton1;
        private Components.RichTextButton btnNew;
    }
}