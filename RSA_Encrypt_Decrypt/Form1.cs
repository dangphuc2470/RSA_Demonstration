using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace RSA_Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        BigInteger n, p, q, phiN, d;
        BigInteger e = 0;
        RSA_Class rd = new RSA_Class();

        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            p = rd.GenerateRandomPrime(1, 100);
            q = rd.GenerateRandomPrime(1, 100);
            n = p * q;
            phiN = (p - 1) * (q - 1);
            Display();
        }

        private void Display()
        {
            tbP.Text = p.ToString();
            tbQ.Text = q.ToString();
            tbN.Text = n.ToString();
            tbPhi.Text = phiN.ToString();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            lbParameter.Text = "Parameter not applied!";

            try
            {
                if (tbE.Text.Length == 0)
                {
                    tbE.Text = "0";
                }
                this.e = RSA_Class.ValidateE(int.Parse(tbE.Text), phiN);
                if (this.e != 0)
                {
                    tbE.Text = this.e.ToString();
                    lbParameter.Text = "Parameter applied!";
                }
                else
                    lbParameter.Text = "Parameter not applied!";

                d = RSA_Class.ModInverse(this.e, phiN);
                tbD.Text = d.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p = int.Parse(tbP.Text);
                q = int.Parse(tbQ.Text);
                n = p * q;
                phiN = (p - 1) * (q - 1);
                Display();
            }
            catch { }
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            // Để test cho nhanh
            //btGenerate_Click(sender, e);
            //tbE.Text = "65537";
            //btApply_Click(sender, e);


            tbSegment.Clear();
            string input = rtbInput.Text;
            for (int i = 0; i < input.Length; i += 2)
            {
                if (i + 1 < input.Length)
                {
                    string pair = input.Substring(i, 2);
                    tbSegment.Text += pair;
                }
                else
                {
                    string singleChar = input.Substring(i, 1) + " "; // Thêm dấu " " cho ký tự cuối cùng nếu độ dài chuỗi là số lẻ
                    tbSegment.Text += singleChar;
                }
                if (i + 2 < input.Length)
                    tbSegment.Text += " # ";
            }
        }
    }
}
