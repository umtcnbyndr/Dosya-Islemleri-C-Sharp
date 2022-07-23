using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_İşlemler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
        }
    }
}
