using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddingB_Click(object sender, EventArgs e)
        {
            var detail = new List<string>();
            detail.Add(textBox1.Text);
            detail.Add(textBox2.Text);
            detail.Add(textBox3.Text);
            detail.Add(textBox4.Text);
            
            //string dom = Domcheck.Items[a1].ToString();
            //detail.Add(dom);
            string adding = string.Join(" ", detail.ToArray());
            LTest.Text = adding ;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
