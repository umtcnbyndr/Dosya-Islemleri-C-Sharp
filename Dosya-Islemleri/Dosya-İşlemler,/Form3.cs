using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosya_İşlemler_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }
            }
        }
    }
}
