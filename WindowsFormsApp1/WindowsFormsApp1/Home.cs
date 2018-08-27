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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            Add newadd = new Add();
            newadd.ShowDialog();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            search newsearch = new search();
            newsearch.ShowDialog();
        }

        private void AllB_Click(object sender, EventArgs e)
        {
            All newall = new All();
            newall.ShowDialog();
        }
    }
}
