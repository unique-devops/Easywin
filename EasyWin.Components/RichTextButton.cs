using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWin.Components
{
    public class RichTextButton : Button
    {
        public string ShortcutText { get; set; } = "Key:";
        public string ActionText { get; set; } = "Text";

        public Color ShortcutColor { get; set; } = Color.Red;
        public Color ActionColor { get; set; } = Color.Green;

        public Font ShortcutFont { get; set; } = new Font("Segoe UI", 10, FontStyle.Bold);

        public RichTextButton()
        {
            //this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.LightGray;
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent); // Keep base to retain focus rectangle, etc.
            this.Text = "";
            //pevent.Graphics.Clear(this.BackColor);

            // Draw border
            //ControlPaint.DrawBorder(pevent.Graphics, this.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

            // Measure text sizes
            var shortcutSize = pevent.Graphics.MeasureString(ShortcutText, ShortcutFont);
            var actionSize = pevent.Graphics.MeasureString(ActionText, Font);
            var totalWidth = shortcutSize.Width + actionSize.Width;
            var totalHeight = Math.Max(shortcutSize.Height, actionSize.Height);

            float x = 0, y = 0;

            // Handle horizontal alignment
            switch (this.TextAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    x = 5;
                    break;

                case ContentAlignment.TopCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.BottomCenter:
                    x = (this.Width - totalWidth) / 2;
                    break;

                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    x = this.Width - totalWidth - 5;
                    break;
            }

            // Handle vertical alignment
            switch (this.TextAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    y = 3;
                    break;

                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    y = (this.Height - totalHeight) / 2;
                    break;

                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    y = this.Height - totalHeight - 3;
                    break;
            }

            // Draw colored texts
            pevent.Graphics.DrawString(ShortcutText, ShortcutFont, new SolidBrush(ShortcutColor), x, y);
            pevent.Graphics.DrawString(ActionText, Font, new SolidBrush(ActionColor), x + shortcutSize.Width, y);

        }
    }
}
