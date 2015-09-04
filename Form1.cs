using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            textBoxTime.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxIntrestRate.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            textBoxPrinciple.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            


        }

        private double CheckInputs()
        {
            decimal number;
            double tempIntrest;
             IntrestCalculator intcal = new IntrestCalculator();

            if((decimal.TryParse(textBoxPrinciple.Text, out number)) && (decimal.TryParse(textBoxTime.Text, out number)) && (decimal.TryParse( textBoxIntrestRate.Text, out number)))
            {
                intcal.principle = Convert.ToDouble(textBoxPrinciple.Text);
                intcal.time = Convert.ToDouble(textBoxTime.Text);
                intcal.rate= Convert.ToDouble(textBoxIntrestRate.Text);
                tempIntrest = intcal.totalIntrest();

            }
            else 

                 tempIntrest = -2;


            return tempIntrest;

                 

            }

        private void buttonCalculateIntrest_Click(object sender, EventArgs e)
        {
            double intrest = CheckInputs();

            if(intrest == (-2))
            {

                labelResult.Text = "Invalid Inputs";
              

            }  


            else labelResult.Text = "The Intrest is : "+intrest;
        }

        private void labelIntrestRate_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }


           

        }
    }

