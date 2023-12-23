using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encrypt_Decrypt
{
    using System.Drawing;
    using System.Windows.Forms;

    public class CustomTextBox : TextBox
    {
        private Color borderColor = Color.Gray;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // Refresh the control to reflect the new border color
            }
        }

        public CustomTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.FromArgb(247, 243, 245);
            this.ForeColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the border using the specified color
            using (Pen pen = new Pen(borderColor))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            }
        }
    }

}
