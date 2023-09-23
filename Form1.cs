namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
            
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text += "." ;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            Operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            Operation = "-";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            Operation = "/";
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            Operation = "*";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double result=0;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if(Operation=="+")
            {
                result = SecondNumber + FirstNumber;
            }else if(Operation=="-")
            {
                result = FirstNumber - SecondNumber;
            }else if (Operation=="/") 
            {
                result = FirstNumber / SecondNumber;
            }else if (Operation == "*")
            {
                result = SecondNumber * FirstNumber;
            }

            textBox1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}