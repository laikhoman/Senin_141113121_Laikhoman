using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static long fakto(long n)
        {
            if (n == 1 || n == 0)
                return 1;
            return fakto(n - 1) * n;
        }
        /*
        public static long modInverse(long a, long n)
        {
            long i = n, v = 0, d = 1;
            while (a > 0)
            {
                long t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }
        */
        public static long modPow(long a, long x, long p)
        {
            // return a^x mod p
            long res = 1;
            while (x > 0)
            {   
                if ((x % 2) == 1) 
                    res = (res * a) % p;
                a = (a * a) % p;
                x /= 2;
            }
            return res%p;
        }
        /*
        public static long modInverse(long a, long p)
        {
            // return modular multiplicative of: a mod p, assuming p is prime
            return modPow(a, p - 2, p)%p;
        }
        */
        
        public static long modInverse(long a, long n)
        {
            long i = n, v = 0, d = 1;
            while (a > 0)
            {
                long t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            if (v < 0) v = (v + n) % n;
            return v;
        }
        public static long modBinomial(long n, long k, long p)
        {
            // return C(n,k) mod p, assuming p is prime
            long numerator = 1; // n*(n-1)* ... * (n-k+1)
            int i;
            for (i = 0; i < k; i++)
            {
                numerator *= (n - i);
                numerator %= p;
            }
            long denominator = 1; // k!
            for (i = 2; i <= k; i++)
            {
                denominator *= modInverse(i, p);
                denominator %= p;
            }
            //long res = modInverse(denominator, p);
            //denominator %= p;
            long res = (denominator * numerator) % p;
            return res;
        }
        public static long combNmodulus(long n, long r, long p)
        {
            long result = 1;

            for (long idx1 = n - r + 1; idx1 <= n; idx1++)
            {
                result = (result * idx1)%p;
                if (result > p)
                    result = result % p;
            }
            
            for (long idx2 = 2; idx2 <= r;idx2++ )
            {
                result = (result * idx2) % p;
                long invers = modInverse(idx2, p);
                result = (result * invers) % p;
                if (result > p)
                    result = result % p;
            }
            
            return result;
        }
        
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a = long.Parse(Txt1.Text);
            long b = long.Parse(Txt2.Text);
            long combi = 0;
            
            if ((a >= 0 && a <= 1000000000) && (b >= 0 && b <= 1000000000))
            {
                if (((a == 25 && b < 24) || (b == 25 && a < 24)) || ((a >= 24 && b >= 24) && System.Math.Abs(a - b) == 2))
                {
                    long sum = a + b - 1;
                    if (a > b)
                    {
                        //combi = combNmodulus(sum, b, 1000000007);
                        combi = modBinomial(sum, b, 1000000007);
                    }
                    else
                    {
                        //combi = combNmodulus(sum, a, 1000000007);
                        combi = modBinomial(sum, a, 1000000007);
                    }
                }
                else
                {
                    combi = 0;
                }
                WarnTxt.Text = "";
            }
            else
            {
                WarnTxt.Text = "range nilai skor harus 0<=a,b<=10^9";
            }
            TxtHasil.Text = combi.ToString();
        }

    }
}
