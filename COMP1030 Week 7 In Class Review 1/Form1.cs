using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1030_Week_7_In_Class_Review_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            // declare variables
            string name = txtName.Text;

            // promt user to input name

            // promt user to input birth year
            Int32 yob = Convert.ToInt32(txtYear.Text);

            // calculate
            Int32 age = 2018 - yob;

            // conversion 
            string ageCalc = Convert.ToString(age);

            // create the output
            lblOutput.Text = "Hello " + name + ", you are " + ageCalc + " years old.";

        }
    }
}

