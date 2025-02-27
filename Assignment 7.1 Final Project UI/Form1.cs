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

            //check if the input is an integer
            if (int.TryParse(textBoxnumber.Text, out int number))
            {
                string result = $"Multiplication Table of {number}\n";

                //loop through the numbers from 1 to 10 and display the result
                for (int i = 1; i < 10; i++)
                {

                    //add the result to the string
                    result += $"{number} x {i} = {number * i}\n";
                }

                //display the result
                MessageBox.Show(result);
            }
            else
            {

                //display an error message
                MessageBox.Show("Please enter an integer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
