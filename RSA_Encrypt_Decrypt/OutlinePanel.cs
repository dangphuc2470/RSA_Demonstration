using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encrypt_Decrypt
{
    using System.Drawing;
    using System.Windows.Forms;

    public class OutlinePanel : Panel
    {
        public OutlinePanel()
        {
            // Set the panel properties
            this.BackColor = Color.White; // Set the background color
            this.ForeColor = Color.Black; // Set the text color
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the border with the specified color
            using (Pen pen = new Pen(Color.FromArgb(98, 96, 51), 2)) // Border width as needed
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }


}
