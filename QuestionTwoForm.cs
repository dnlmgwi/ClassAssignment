using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment
{
    public partial class QuestionTwoForm : Form
    {
        List<int> numbers = new List<int>();

        int sumOfNumber(List<int> numbers) {
            int sum = 0;
            
            for (int index = 0; index < numbers.Count; index++)
            {
               sum += numbers[index];
            }
            
            return sum;
        }

        bool isNumber(String input)
        {
            int number;

            bool isNumber = false;

            if (int.TryParse(inputArea.Text, out number)) {
               isNumber =true;
            }

            return isNumber;
        }
        public QuestionTwoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Count how many Numbers are in the List
            arrayLengthLabel.Text = numbers.Count.ToString();

            switch (NextButton.Text) {
                case "Next":
                    if (inputArea.Text != "" && isNumber(inputArea.Text))
                    {
                        numbers.Add(int.Parse(inputArea.Text));
                        inputArea.Text = "";
                        // Update the label
                        arrayLengthLabel.Text = numbers.Count.ToString();

                        // Next Button should only allow 10 inputs and then it should show the answer
                        if (numbers.Count == 10)
                        {
                            NextButton.Text = "Answer";
                        }
                    }
                    else
                    {
                      //Show Error "Please Input a number" if user doesn't enter number
                      MessageBox.Show("Please Enter A Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Answer":
                    // Eg. total.Text == "100";
                    total.Text = "Sum: " + sumOfNumber(numbers).ToString();
                    NextButton.Text = "Done";
                    break;
                case "Done":
                    NextButton.Text = "Next";

                    //Remove the Text in the total
                    total.Text = "";
                    break;
            }

        }

        private void QuestionTwoForm_Load(object sender, EventArgs e)
        {
            arrayLengthLabel.Text = numbers.Count.ToString();
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            arrayLengthLabel.Text = numbers.Count.ToString();

        }
    }
}
