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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        string dosyaadi, dosyayolu;
        StreamWriter sw;

        private void button2_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu + "\\" + dosyaadi + ".txt");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }
        }
    }
}
