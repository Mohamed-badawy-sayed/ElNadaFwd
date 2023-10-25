using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElNadaFwd.G_CustData
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            label2.Text = radioGroup2.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
