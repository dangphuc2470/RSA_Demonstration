using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Windows.Forms;

namespace RSA_Encrypt_Decrypt
{
    public partial class RSA : Form
    {
        BigInteger n, p, q, phiN, d;
        BigInteger E = 0;

        public RSA()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            p = RSA_Class.GenerateRandomPrime(1, 1000);
            q = RSA_Class.GenerateRandomPrime(1, 1000);
            n = p * q;
            phiN = (p - 1) * (q - 1);
            Display(p, q, n, phiN);
        }
        private void Display(BigInteger p, BigInteger q, BigInteger n, BigInteger phiN)
        {
            tbP.Text = p.ToString();
            tbQ.Text = q.ToString();
            tbN.Text = n.ToString();
            tbPhi.Text = phiN.ToString();
        }

        private void Display(BigInteger n, BigInteger phiN)
        {
            tbN.Text = n.ToString();
            tbPhi.Text = phiN.ToString();
        }
        private void btApply_Click(object sender, EventArgs e)
        {
            lbParameter.Text = "Parameter not applied!";
            if (!RSA_Class.IsPrime(p) || !RSA_Class.IsPrime(q))
            {

                MessageBox.Show("p or q is not prime. Please choose a prime number or use the generate button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (tbE.Text.Length == 0)
                {
                    tbE.Text = "0";
                }
                E = RSA_Class.ValidateE(int.Parse(tbE.Text), phiN);
                if (E != 0)
                {
                    tbE.Text = E.ToString();
                    lbParameter.Text = "Parameter applied!";
                }
                else
                    lbParameter.Text = "Parameter not applied!";

                d = RSA_Class.ModInverse(E, phiN);
                tbD.Text = d.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbP_TextChanged(object sender, EventArgs e)
        {
            lbParameter.Text = "Parameter not applied!";
            try
            {
                p = int.Parse(tbP.Text);
                q = int.Parse(tbQ.Text);

                n = p * q;
                phiN = (p - 1) * (q - 1);
                Display(n, phiN);
            }
            catch { }
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            if (lbParameter.Text == "Parameter not applied!")
            {
                MessageBox.Show("Parameter not applied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            ClearTextbox("Segments", "Numbers input in base 10 format", "Encrypted");

            string input = rtbInput.Text;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 100)
                {
                    tbBase10.Text += "0";
                    if (input[i] < 10)
                        tbBase10.Text += "0";
                }
                tbSegment.Text += input[i].ToString();
                tbBase10.Text += ((int)input[i]).ToString();
                tbOutput.Text += (RSA_Class.Encrypt((BigInteger)input[i], E, n)).ToString();

                if (i < input.Length - 1)
                {
                    tbSegment.Text += " # ";
                    tbBase10.Text += " # ";
                    tbOutput.Text += " # ";
                }
            }

            //Block 2
            //for (int i = 0; i < input.Length; i += 2)
            //{
            //    if (i + 1 < input.Length)
            //    {
            //        string pair = input.Substring(i, 2);
            //        tbSegment.Text += pair;
            //    }
            //    else
            //    {
            //        string singleChar = input.Substring(i, 1) + " "; // Thêm dấu " " cho ký tự cuối cùng nếu độ dài chuỗi là số lẻ
            //        tbSegment.Text += singleChar;
            //    }
            //    if (i + 2 < input.Length)
            //        tbSegment.Text += " # ";
            //}
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            ClearTextbox("Decrypted", "Decrypted to text", "Plaintext");

            string[] stringArray = rtbInput.Text.Split('#');

            for (int i = 0; i < stringArray.Length; i++)
            {
                // Chuyển đổi từng chuỗi thành số nguyên và thêm vào mảng số nguyên
                if (BigInteger.TryParse(stringArray[i].Trim(), out BigInteger number))
                {
                    int temp = (int)RSA_Class.Decrypt(number, d, n);
                    tbSegment.Text += temp.ToString();
                    tbBase10.Text += Convert.ToChar(temp);
                    tbOutput.Text += Convert.ToChar(temp);

                    if (i < stringArray.Length - 1)
                    {
                        tbSegment.Text += " # ";
                        tbBase10.Text += " # ";
                    }
                }
                else
                {
                    MessageBox.Show("Some thing wrong!");
                }
            }
        }

        private void ClearTextbox(string tb1, string tb2, string tb3)
        {
            tbSegment.Clear();
            tbBase10.Clear();
            tbOutput.Clear();
            lbSegment.Text = tb1;
            lbBase10.Text = tb2;
            lbOutput.Text = tb3;
        }
    }
}
