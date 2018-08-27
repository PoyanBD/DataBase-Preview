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
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        public string Alltext
        {
            get
            {
                return this.TextAll.Text;
            }
            set
            {
                this.TextAll.Text = value;
            }
        }
    }
}
