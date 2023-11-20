using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            int sayac = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayac++;
            }

            if (sayac == 0)
            {
                MessageBox.Show("Bulunamadı");
            }
            else
            {
                MessageBox.Show(sayac+"Bulundu");
            }
        }
    }
}
