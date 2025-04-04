namespace EasyWin.Components
{
    public class HintTextBox : TextBox
    {
        public string Hint { get; set; }
        public Color HintColor { get; set; } = Color.Gray;

        private Label HintLabel = new Label();
        public HintTextBox()
        {
            Hint = "Search...";
            HintLabel.Text = Hint;
            HintLabel.ForeColor = Color.Gray;
            HintLabel.BackColor = Color.Transparent;
            HintLabel.AutoSize = false;
            HintLabel.TextAlign = ContentAlignment.MiddleLeft;

            //HintLabel.Location = this.Location;
            //HintLabel.Size = this.Size;
            int leftMargin = 2; // Adjust this value to create desired margin
            HintLabel.Location = new Point(this.Location.X + leftMargin, this.Location.Y);
            HintLabel.Size = new Size(this.Width - leftMargin, this.Height);

            HintLabel.Click += HintLabel_Click; ;
            this.GotFocus += OnGotFocus;
            this.LostFocus += OnLostFocus;
            this.TextChanged += OnTextChanged;
            this.ForeColor = Color.Black;
            this.Controls.Add(HintLabel);
        }

        private void HintLabel_Click(object? sender, EventArgs e)
        {
            this.Focus();
        }       

        private void OnGotFocus(object sender, EventArgs e)
        {
            HintLabel.Visible = string.IsNullOrEmpty(this.Text);
            //if (this.Text == Hint)
            //{
            //    this.Text = string.Empty;
            //    this.ForeColor = Color.Black;
            //}
        }

        private void OnLostFocus(object sender, EventArgs e)
        {
            HintLabel.Visible = string.IsNullOrEmpty(this.Text);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            //if (this.Text != Hint && !string.IsNullOrWhiteSpace(this.Text))
            //{
            //    this.ForeColor = Color.Black;
            //}
            //else if (string.IsNullOrWhiteSpace(this.Text))
            //{
            //    this.ForeColor = HintColor;
            //}
            HintLabel.Visible = string.IsNullOrEmpty(this.Text);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrWhiteSpace(this.Text) && this.Focused == false)
            {
                using (Brush brush = new SolidBrush(HintColor))
                {
                    e.Graphics.DrawString(Hint, this.Font, brush, new PointF(2, 2));
                }
            }
        }
    }
}