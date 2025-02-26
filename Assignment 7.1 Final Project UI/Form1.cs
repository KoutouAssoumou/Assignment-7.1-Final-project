namespace Assignment_7._1_Final_Project_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelnumber_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxnumber.Text, out int number))
            {
                string result = $"Multiplication Table of {number}\n";
                for (int i = 1; i < 10; i++)
                {
                    result += $"{number} x {i} = {number * i}\n";
                }
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Please enter an integer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
