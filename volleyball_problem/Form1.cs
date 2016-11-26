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
        public static long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        public static long modInverse(long a, long n)
        {
            long i = n, v = 0, d = 1;
            if (n <= 1 || gcd(a, n) != 1) return -1;
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
                numerator *= (n-i);
                numerator %= p;
            }
            long denominator1 = 1; // k!
            for (long j = 1; j <= k; j++)
            {
                denominator1 *= modInverse(j,p);
                denominator1 %= p;
            }
            long res = (denominator1 * numerator) % p;
            return res%p;
        }
        
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a = long.Parse(Txt1.Text);
            long b = long.Parse(Txt2.Text);
            long combi = 0;
            
            if ((a >= 0 && a <= 1000000000) && (b >= 0 && b <= 1000000000))
            {
                if ((a == 25 && b < 24) || (b == 25 && a < 24))
                {
                    long sum = a + b - 1;
                    if (a > b)
                    {
                        combi = modBinomial(sum, b, 1000000007);

                    }
                    else
                    {
                        combi = modBinomial(sum, a, 1000000007);
                    }
                }
                else if ((a >= 24 && b >= 24) && System.Math.Abs(a - b) == 2)
                {
                    long combi24 = modBinomial(48, 24, 1000000007);
                    long sum = a + b;
                    if (a > b)
                    {
                        combi = modBinomial(sum-48-2, b-24, 1000000007);
                        combi *= combi24;
                    }
                    else
                    {
                        combi = modBinomial(sum-48-2, a-24, 1000000007);
                        combi *= combi24;
                    }
                    if (combi > 1000000007)
                        combi %= 1000000007;
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
