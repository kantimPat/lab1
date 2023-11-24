namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxinput.Text = "CIS KKU";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = textBoxinput.Text + "9";
        }
        string number1 = string.Empty;
        string operation;
        private void button11_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "+";
        }
        //เท่ากับ
        private void button12_Click(object sender, EventArgs e)
        {
            string number2 = textBoxinput.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);


            if (operation == "+")
            {
                int output = num1 + num2;
                textBoxinput.Text = output.ToString();
            }
            else if (operation == "-")
            {
                int output = num1 - num2;
                textBoxinput.Text = output.ToString();
            }
            else if (operation == "*")
            {
                int output = num1 * num2;
                textBoxinput.Text = output.ToString();
            }


            else if (operation == "%")
            {
                int output = num1 / num2;
                textBoxinput.Text = output.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "*";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "%";
        }
    }
}
