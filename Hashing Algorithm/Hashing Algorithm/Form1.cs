using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashing_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int EulerFunction(string text)
        {
            int n = text.Length;
            int result = n;

            for (int p = 2; p * p <= n; ++p)
            {

                if (n % p == 0)
                {

                    while (n % p == 0)
                        n /= p;
                    result -= result / p;
                }
            }

            if (n > 1)
                result -= result / n;
            return result;
        }

        private string Encrypt(string text, int n)
        {
            string newText = "";

            for (int i = 0; i < n; i++)
            {
                char c = text[i % n];

                if (c == ' ')
                {
                    int j = i;
                    while (c == ' ')
                    {
                        j++;
                        c = text[j % n];
                    }
                }
                
                newText += c;
            }

            return text;
        }

        private int Sum(string text)
        {
            int result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                result += text[i];
            }

            return result;
        }

        private string Hash(string text, int n, string HMAC)
        {
            string hashSymbols = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfhgjlkzcxvnbnm1234567890" + HMAC;
            string hash = "";

            for (int i = 0; i < 40; i++)
            {
                int index = (text.Length + n * i) % hashSymbols.Length;

                while (hashSymbols[index] == ' ')
                {
                    index = (index + 1) % hashSymbols.Length;
                }

                hash += hashSymbols[index];
            }

            return hash;
        }

        private void hashButton_Click(object sender, EventArgs e)
        {
            string HMAC = "";
            if (checkBox1.Checked)
                HMAC = HMACtextBox.Text;

            string hash = originalText.Text;
            int n = EulerFunction(hash);

            hash = Encrypt(hash, n);
            n = Sum(hash);
            hash = Hash(hash, n, HMAC);

            hashText.Text = hash;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Visible = true;
                HMACtextBox.Visible = true;
            }
            else
            {
                label1.Visible = false;
                HMACtextBox.Visible = false;
            }
        }
    }
}
