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
        public static String calc = "";
        static double mem = 0;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
                startedExpression = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {

                String answer = Convert.ToString(Calculate());
                calc = answer;

                if (answer.ToString() == "NaN")
                {
                    answer = "Invalid Expression";
                    calc = "";
                }
                else
                {
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
            calc = "";
            txtUi.Text = "";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                txtUi.Text += "^3";
                calc += "^3";
            }
        }

        private void memplus_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && mem != 0)
            {
                double answer = Calculate();  
                answer += mem;
                String answerText = answer.ToString();
                calc = answerText;

                if (answer.ToString() == "NaN")
                {
                    answerText = "Invalid Expression";
                    calc = "";
                }
                else
                {
                    txtHistory.Text += txtUi.Text + " + " + mem.ToString() + "=";
                    txtUi.Text = answerText;
                }

                txtAnswer.Text = answerText;
                startedExpression = false;
                txtHistory.Text += answer + "\r\n";
            }
        }

        private void btnMemMinus_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && mem != 0)
            {
                double answer = Calculate();
                answer -= mem;
                String answerText = answer.ToString();
                calc = answerText;

                if (answer.ToString() == "NaN")
                {
                    answerText = "Invalid Expression";
                    calc = "";
                }
                else
                {
                    txtHistory.Text += txtUi.Text + " - " + mem.ToString() +  "=";
                    txtUi.Text = answerText;
                }

                txtAnswer.Text = answerText;
                startedExpression = false;
                txtHistory.Text += answer + "\r\n";
            }
        }

        private void btnMemSet_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false))
            {
                mem = Calculate();
            }
        }

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            mem = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtUi.Text = Convert.ToString(mem);
            calc = Convert.ToString(mem);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false))
            {
                double answer = Calculate();
                txtUi.Text = "sinh(" + answer.ToString() + ")";
                calc = "sinh(" + answer.ToString() + ")";
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if(startedExpression != true) {
                txtUi.Text += "%";
                calc += "#";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false))
            {
                double answer = Calculate();
                txtUi.Text = "log(" + answer.ToString() + ")";
                calc = "log10(" + answer.ToString() + ")";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "") {
                txtUi.Text += "!";
                calc += "!";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "√" + answer.ToString();
                calc = "sqrt(" + answer.ToString() + ")";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "3√" + answer.ToString();
                calc = "root(3, " + answer.ToString() + ")";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "10^" + answer.ToString();
                calc = "10^" + answer.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                txtUi.Text += "^2";
                calc += "^2";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "cosh(" + answer.ToString() + ")";
                calc = "cosh(" + answer.ToString() + ")";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "cos(" + answer.ToString() + ")";
                calc = "cos(" + answer.ToString() + ")";
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                txtUi.Text += "^";
                calc += "^";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "sin(" + answer.ToString() + ")";
                calc = "sin(" + answer.ToString() + ")";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "tanh(" + answer.ToString() + ")";
                calc = "tanh(" + answer.ToString() + ")";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (startedExpression.Equals(false) && calc != "")
            {
                double answer = Calculate();
                txtUi.Text = "tan(" + answer.ToString() + ")";
                calc = "tan(" + answer.ToString() + ")";
            }
        }

        private void rdoDeg_CheckedChanged(object sender, EventArgs e)
        {
            mXparser.setDegreesMode();
            double answer = Calculate();
            txtUi.Text = answer.ToString();
            calc = answer.ToString();
            
        }

        private void rdoRadians_CheckedChanged(object sender, EventArgs e)
        {
            mXparser.setRadiansMode();
            double answer = Calculate();
            txtUi.Text = answer.ToString();
            calc = answer.ToString();
        }
    }
}
