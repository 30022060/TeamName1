using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN1_CLASS;

namespace TN1WinForm
{
    public partial class Form1 : Form
    {
        Employee e1 = new Employee();

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
            e1.Name = text_name.Text;
            label1.Text = text_name.Text;
            e1.Age = int.Parse(text_age.Text);
            label2.Text = text_age.Text;
            e1.Ird = text_ird.Text;
            label3.Text = text_ird.Text;
            e1.Bank = text_bank.Text;
            label4.Text = text_bank.Text;
            e1.Pay = double.Parse(text_pay.Text);
            label5.Text = text_pay.Text;
            e1.Hrs = int.Parse(text_hr.Text);
            label6.Text = text_hr.Text;
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }


        //USELESS

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
