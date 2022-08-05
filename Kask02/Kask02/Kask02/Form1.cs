using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kask02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            bool isChecked = false;
            bool isSecondNumZero = false;
            
            try{
                calculation.number1 = Convert.ToSingle(txtBox_Num1.Text);
                calculation.number2 = Convert.ToSingle(txtBox_Num2.Text);
                if (radioBtn_Add.Checked)
                {
                    calculation.transaction = "+";
                    isChecked = true;
                }
                else if (radioBtn_Subtract.Checked)
                {
                    calculation.transaction = "-";
                    isChecked = true;
                }
                else if (radioBtn_Multiply.Checked)
                {
                    calculation.transaction = "*";
                    isChecked = true;
                }
                else if (radioBtn_Divide.Checked)
                {
                    calculation.transaction = "/";
                    isChecked = true;
                    if (txtBox_Num2.Text == "0") {
                        isSecondNumZero = true;
                    }
                }


                if (isChecked)
                {
                    if (isSecondNumZero) {
                        lbl_Answer.Text = "Can`t divide by 0!";
                    }
                    else {
                        Single result = calculation.calculate(calculation.transaction);
                        lbl_Answer.Text = Convert.ToString(calculation.number1) + " " +
                            calculation.transaction + " " + Convert.ToString(calculation.number2) +
                            " = " + Convert.ToString(result);
                    }
                    
                }
                else {
                    lbl_Answer.Text = "Select operation!";
                }
                
            }
            catch {
                lbl_Answer.Text = "";
                MessageBox.Show("Enter number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
