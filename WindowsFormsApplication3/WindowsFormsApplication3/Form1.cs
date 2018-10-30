using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ogr = new Class1();
            ogr.Ad = textBox1.Text;
            ogr.Yas = Convert.ToInt32(textBox1.Text);
            ogr.Not1 = Convert.ToInt32(textBox2.Text);
            //MessageBox.Show(ogr.Ort.ToString());
            listBox1.Items.Add(ogr);

        }
    }
}
