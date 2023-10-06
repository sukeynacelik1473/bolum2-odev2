using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2_ozdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt32(textBox1.Text);
            if(sayı/2 == 0)
            {
                MessageBox.Show("bu bir çift sayıdır.");

            }
            if (sayı / 2 == 1)
            {
                MessageBox.Show("bu bir tek sayıdır.");
            }
        }
    }
}
