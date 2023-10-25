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
    public partial class Form_InCome : Form
    {
        public Form_InCome()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void Form_InCome_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup3.Text == "1")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;

            }
            else if (radioGroup3.Text == "3")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

            }
            else
            {

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }

        }
    }
}
