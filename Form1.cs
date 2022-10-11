namespace Calculator_2
{
    public partial class calculatorUI : Form
    {
        public calculatorUI()
        {
            InitializeComponent();
        }

        string number = "";
        decimal temp1 = 0, result = 0;
        int op = 0;

        private void GetNumber(string num)
        {
            if(showTextBox.Text == "0")
            {
                number = "";
                number += num;
            }
            else
            {
                number += num;
            }
         
            temp1 = Convert.ToDecimal(number);
            showTextBox.Text = number;
            if (op == 0)
            {
                result = temp1;
            }
            //Show(temp1);
        }

        private void Show(decimal num)
        {
            showTextBox.Text = num.ToString();
        }

        private void button00_Click(object sender, EventArgs e)
        {
            GetNumber("0");
        }

        private void button01_Click(object sender, EventArgs e)
        {
            GetNumber("1");
        }

        private void button02_Click(object sender, EventArgs e)
        {
            GetNumber("2");
        }

        private void button03_Click(object sender, EventArgs e)
        {
            GetNumber("3");
        }

        private void button04_Click(object sender, EventArgs e)
        {
            GetNumber("4");
        }

        private void button05_Click(object sender, EventArgs e)
        {
            GetNumber("5");
        }

        private void button06_Click(object sender, EventArgs e)
        {
            GetNumber("6");
        }

        private void button07_Click(object sender, EventArgs e)
        {
            GetNumber("7");
        }

        private void button08_Click(object sender, EventArgs e)
        {
            GetNumber("8");
        }

        private void button09_Click(object sender, EventArgs e)
        {
            GetNumber("9");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            number = "0";
            result = 0;
            temp1 = 0;
            op = 0;
            opLabel.Text = "";
            Show(result);
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            GetNumber(".");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            op = 1;
            opLabel.Text = "+";
            temp1 = 0;
            number = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            op = 2;
            opLabel.Text = "-";
            temp1 = 0;
            number = "";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            op = 3;
            opLabel.Text = "x";
            temp1 = 0;
            number = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            op = 4;
            opLabel.Text = "/";
            temp1 = 0;
            number = "";
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            op = 5;
            opLabel.Text = "%";
            temp1 = 0;
            number = "";
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            op = 6;
            opLabel.Text = "√";
            temp1 = 0;
            number = "";
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            op = 7;
            opLabel.Text = "x²";
            temp1 = 0;
            number = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                result += temp1;
                op = 10;
            }

            else if (op == 2)
            {
                result -= temp1;
                op = 10;
            }
            else if (op == 3)
            {
                result *= temp1;
                op = 10;
            }
            else if (op == 4)
            {
                result /= temp1;
                op = 10;
            }
            else if (op == 5)
            {
                result = result*(temp1/100);
                op = 10;
            }
            else if (op == 6)
            {
                double res = Convert.ToDouble(result);
                double res2;
                res2 = Math.Sqrt(res);
                result = Convert.ToDecimal(res2);
                op = 10;
            }
            else if (op == 7)
            {
                result *= result;
                op = 10;
            }
            else
            {

            }

            Show(result);
        }

        

      

        private void calculatorUI_Load(object sender, EventArgs e)
        {
            Show(result);
        }       
    }
}