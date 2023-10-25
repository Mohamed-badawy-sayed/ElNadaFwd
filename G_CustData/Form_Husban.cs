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
    public partial class Form_Husban : Form
    {
        public Form_Husban()
        {
            InitializeComponent();
        }
        private int CalculateAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age))age--;           
            return age;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void edit_text_cus_bairth_EditValueChanged(object sender, EventArgs e)
        {
            try{
                if (CalculateAge(edit_text_cus_bairth.DateTime) < 0) label_age.Text = "";
                else label_age.Text = Convert.ToString(CalculateAge(edit_text_cus_bairth.DateTime));
            }
            catch{
                label_age.Text = "";
            }
        }
    }
}
