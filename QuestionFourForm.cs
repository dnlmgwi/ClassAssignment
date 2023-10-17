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
    public partial class QuestionFourForm : Form
    {
        //List<String> calculationParts;
        string temp = "";

        bool isNumberTest(char value)
        {
            return int.TryParse(value.ToString(), out int result);
        }

        string combineNumbers(char currentValue, char previousValue, string temp)
        {
            //Console.WriteLine("Current " + currentValue + " Prev " + previousValue);

            // if Prev is a number combine Prev + Current
            
            // Eg. PrevCurrent
            if (isNumberTest(previousValue) && isNumberTest(currentValue))
            {
                return previousValue.ToString() + temp;
            }

            return currentValue.ToString();
        }

        public QuestionFourForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            List<String> calculation = new List<string>();
           //Break down the equation into parts
           char[] inputParts = inputArea.Text.ToCharArray();

            // Create a new list out of the parts separating the operators from the numbers but keeping the order
            //if Previous item was a number combine it with the next char

            Console.WriteLine(inputParts.ToString());

            for (int i = 0; i < inputParts.Length; i++)
            {
                char currentValue;
                char previousValue;
                
                if (i > 0)
                {
                    currentValue = inputParts[i];
                    previousValue = inputParts[i - 1];
                    

                    //If current is a number add it to temp
                    if (isNumberTest(currentValue) && isNumberTest(previousValue))
                    {
                        if (temp == "")
                        {
                            temp = previousValue.ToString() + currentValue.ToString();
                        }
                        else if (temp != "")
                        {
                            temp += currentValue.ToString();
                        }

                    } else if (!isNumberTest(currentValue))
                    {
                        calculation.Add(temp);
                        calculation.Add(currentValue.ToString());

                        temp = "";
                    } else if (!isNumberTest(previousValue))
                    {
                        calculation.Add(currentValue.ToString());
                        temp = "";
                    }

                    

                    /*else if (isNumberTest(currentValue))
                    {
                        temp += currentValue;
                    } else if(!isNumberTest(currentValue)) {
                        
                    }
                    */

                    Console.WriteLine("Temp"+temp);
                }
                /*else
                {
                    currentValue = inputParts[i];

                    if ( isNumberTest(currentValue))
                    {
                        //Console.WriteLine("Current " + currentValue);
                        calculation.Add(currentValue.ToString());
                    }

                }
                */
                
            }

            foreach (var item in calculation)
            {
                
                Console.WriteLine(item.ToString());
            }

            //I need to identify each athematic symbols

            /*
            switch (inputParts)
            {
                case "":
            }
            */


        }

        private void QuestionFourForm_Load(object sender, EventArgs e)
        {
            inputArea.Text = "254+-40*256/5";
        }
    }
}
