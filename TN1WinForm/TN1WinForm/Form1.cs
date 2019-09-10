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
            if(text_name.Text != "" 
                && text_age.Text != ""
                && text_ird.Text != ""  //If the text boxes are empty, show error message
                && text_bank.Text != "" 
                && text_pay.Text != ""
                && text_hr.Text != "")
            {
                e1.Name = text_name.Text;
                e1.Age = int.Parse(text_age.Text);
                e1.Ird = text_ird.Text;
                e1.Bank = text_bank.Text;
                e1.Pay = double.Parse(text_pay.Text);
                e1.Hrs = int.Parse(text_hr.Text);

                listBox1.Items.Add("EMPLOYEE CREATED");
                listBox1.Items.Add("***************");
                listBox1.Items.Add("Full Name: " + e1.Name);
                listBox1.Items.Add("Age: " + e1.Age);                  //Text in text boxes get display in listbox
                listBox1.Items.Add("IRD Number: " + e1.Ird);
                listBox1.Items.Add("Bank Name: " + e1.Bank);
                listBox1.Items.Add("Weekly Salary: $" + e1.Pay);
                listBox1.Items.Add("Hours Worked in a Week: " + e1.Hrs);
                listBox1.Items.Add("***************");
            }
            else
            {
                MessageBox.Show("ERROR. EMPTY TEXTBOX DETECTED."); // error message
            }

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
