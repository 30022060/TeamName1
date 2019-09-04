using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN1CLASS;

namespace TN1WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void text_age_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text_ird_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text_bank_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_pay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_hr_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            details.Text  = text_age.Text;
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }




        //USELESS
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

    
    }
}
