using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public static String calc;
        public static Boolean startedExpression;
        public static Boolean isDecimal;
        public Form1()
        {
            InitializeComponent();
        }

        private double Calculate()
        {
            Expression e = new Expression(calc);
            return e.calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Number_Expression(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button) ) {
                Button b = (Button)sender;
                calc += b.Text;
                txtUi.Text += b.Text;
                startedExpression = false;
            }           
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button) && isDecimal == false)
            {
                Button b = (Button)sender;
                calc += b.Text;
                txtUi.Text += b.Text;
                isDecimal = true;
            }
        }

        private void Basic_Expression(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button) && txtUi.Text != "" && startedExpression != true)
            {
                Button b = (Button)sender;
                calc += b.Text;
                txtUi.Text += b.Text;
                isDecimal = true;
                startedExpression = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false)) {
                isDecimal = false;
                String answer = Convert.ToString(Calculate());
                calc = answer;

                if (answer == "NaN")
                {
                    answer = "Invalid Expression";
                    calc = "";
                }
                else {
                    txtUi.Text = answer;
                }
                
                txtHistory.Text += txtUi.Text + "=";
                txtAnswer.Text = answer;
                
                startedExpression = false;
                txtHistory.Text += answer + "\r\n";
            }     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc = "";
            txtAnswer.Text = "";
            txtUi.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
        }
    }
}
