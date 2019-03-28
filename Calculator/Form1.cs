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
    public partial class Calculator : Form
    {
        public static String calc;
        public static Boolean startedExpression;
        private int decCount = 0;
        public Calculator()
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
            if (sender.GetType() == typeof(Button) && decCount < 1)
            {
                Button b = (Button)sender;
                calc += b.Text;
                txtUi.Text += b.Text;
                decCount++;
            }
        }

        private void Basic_Expression(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button) && txtUi.Text != "" && startedExpression != true)
            {
                Button b = (Button)sender;
                calc += b.Text;
                txtUi.Text += b.Text;
                decCount = 0;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false)) {
                
                String answer = Convert.ToString(Calculate());
                calc = answer;

                if (answer == "NaN")
                {
                    answer = "Invalid Expression";
                    calc = "";
                }
                else {
                    txtHistory.Text += txtUi.Text + "=";
                    txtUi.Text = answer;
                }
                
                
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
            decCount = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
        }
    }
}
