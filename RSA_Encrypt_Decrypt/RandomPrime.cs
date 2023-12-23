using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encrypt_Decrypt
{
    class RSA_Class
    {
        static Random random = new Random();

        static bool IsPrime(BigInteger number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            BigInteger sqrt = (BigInteger)Math.Sqrt((double)number);
            for (BigInteger i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public BigInteger GenerateRandomPrime(int min, int max)
        {
            BigInteger randomNumber;
            do
            {
                randomNumber = random.Next(min, max);
            } while (!IsPrime(randomNumber));

            return randomNumber;
        }

        // Hàm tính ước chung lớn nhất (GCD)
        private static BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tìm số e hợp lệ dựa trên phi(n)
        public static BigInteger FindValidE(BigInteger phiN)
        {
            int[] e = [3, 5, 17, 65537]; // Starting from a small prime number
            for (int i = 0; i < e.Length; i++)
            { 
                if (phiN % e[i] != 0)
                    return e[i];
            }
            return 0;
        }

        // Hàm kiểm tra và chọn số e hợp lệ
        public static BigInteger ValidateE(BigInteger e, BigInteger phiN)
        {
            if (GCD(e, phiN) == 1 && IsPrime(e))
            {
                return e;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Invalid \"e\", try again or generating a valid one?", "Error", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                    return FindValidE(phiN);
                return 0;
            }
        }

        public static BigInteger ModInverse(BigInteger e, BigInteger phi)
        {
            BigInteger m0 = phi;
            BigInteger t, q;
            BigInteger x0 = 0, x1 = 1;

            if (phi == 1)
                return 0;

            while (e > 1)
            {
                // q is quotient
                q = e / phi;
                t = phi;

                // phi is remainder now, process same as Euclid's algo
                phi = e % phi;
                e = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            // Make x1 positive if it's negative
            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        public static BigInteger Encrypt(BigInteger m, BigInteger e, BigInteger n)
        {
            return BigInteger.ModPow(m, e, n);
        }

        public static BigInteger Decrypt(BigInteger c, BigInteger d, BigInteger n)
        {
            return BigInteger.ModPow(c, d, n);
        }
    }
}
