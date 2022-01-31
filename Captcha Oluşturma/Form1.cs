using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == textBox1.Text)
            {
                MessageBox.Show(" İŞLEM BAŞARILI","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İŞLEM BAŞARISIZ", "BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "/", "+", "&" };
            string[] sembol3 = { "A", "B", "C", "D", "E" };

            Random r = new Random();
            int s1, s2, s3,s4;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(1, 10);
            s4 = r.Next(0, sembol3.Length);
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString()+sembol3[s4].ToString();
        }
    }
}
