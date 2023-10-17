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

        bool isNumber(String value)
        {
            return int.TryParse(value.ToString(), out int result);
        }

        string combineNumbers(string currentValue, string previousValue, string temp)
        {
            //Console.WriteLine("Current " + currentValue + " Prev " + previousValue);

            // if Prev is a number combine Prev + Current
            
            // Eg. PrevCurrent
            if (isNumber(previousValue) && isNumber(currentValue))
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
            calculation = inputArea.Text.Split(' ').ToList();

            // loop through the list


            for (int item = 0; item < calculation.Count; item++)
            {
                
                if (item > 0)
                    {
                        string currentValue = calculation[item];
                        string previousValue = calculation[item - 1];


                        if (isNumber(currentValue) && isNumber(previousValue) && temp == "")
                        {
                            if (temp == "")
                            {
                                temp = previousValue.ToString() + currentValue.ToString();
                                Console.WriteLine("Temp" + temp);
                            }

                            else if (temp != "")
                            {

                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + currentValue.ToString());

                            }

                        }
                        else if (isNumber(currentValue) && isNumber(previousValue) && temp != "")
                        {
                            temp += currentValue.ToString();
                            Console.WriteLine("Temp" + temp);

                        }
                        else if (isNumber(currentValue) && !isNumber(previousValue) && temp != "")
                        {
                            temp += currentValue.ToString();
                            Console.WriteLine("Temp" + temp);

                        }
                        else if (isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                        {
                            if (temp == "")
                            {
                                temp += currentValue.ToString();
                                Console.WriteLine("Temp" + temp);
                            }

                            else if (temp != "")
                            {

                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + currentValue.ToString());

                            }
                        }
                        else if (!isNumber(currentValue) && isNumber(previousValue) && temp == "")
                        {
                            if (temp == "")
                            {
                                temp = previousValue.ToString() + currentValue.ToString();
                            }
                            else if (temp != "")
                            {
                                calculation.Add(temp);
                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + temp);

                                temp = "";
                            }


                        }
                        else if (!isNumber(currentValue) && isNumber(previousValue) && temp != "")
                        {

                            calculation.Add(temp);
                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + temp);

                            temp = "";


                            if (temp != "")
                            {

                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + currentValue.ToString());

                            }

                        }
                        else if (!isNumber(currentValue) && !isNumber(previousValue) && temp != "")
                        {

                            temp += currentValue.ToString();


                            Console.WriteLine("Temp" + temp);




                        }
                        else if (isNumber(currentValue) && isNumber(previousValue) && temp != "")
                        {
                            temp += currentValue.ToString();
                            Console.WriteLine("Temp" + temp);
                        }
                        else if (isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                        {
                            if (temp == "")
                            {
                                temp += currentValue.ToString();
                                Console.WriteLine("Temp" + temp);

                            }
                            else if (temp != "")
                            {

                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + currentValue.ToString());

                            }
                        }
                        else if (!isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                        {
                            if (temp == "")
                            {
                                temp += currentValue.ToString();

                                Console.WriteLine("Temp" + temp);

                            }
                            if (temp != "")
                            {

                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + currentValue.ToString());

                            }
                        }
                        else if (isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                        {
                            if (temp == "")
                            {
                                calculation.Add(temp);
                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + temp);

                                temp = "";


                                Console.WriteLine("Temp" + temp);
                            }
                            else
                             if (temp != "")
                            {

                                calculation.Add(currentValue.ToString());

                                Console.WriteLine("Added" + currentValue.ToString());

                            }
                        }
                        
                    }
                
                //I need to identify each arithmatic symbols
                switch (calculation[item])
                {
                    //B – Brackets
                    //I – Order of powers or roots
                    //D – Division
                    //M – Multiplication
                    //A – Addition
                    //S – Subtraction
                    case "(":

                    break;

                    case "^":

                        break;
                    case "/":
                        
                        break;
                    case "*":

                        break;
                    case "+":

                        break;
                    case "-":

                        break;
                }
            }

            
            

            /*
            Console.WriteLine("Parts: "+calculationParts.Length);

            for (int i = 0; i < calculationParts.Length; i++)
            {
                if (i > 0)
                {
                    char currentValue = calculationParts[i];
                    char previousValue = calculationParts[i - 1];


                    if (isNumber(currentValue) && isNumber(previousValue) && temp == "")
                    {
                        if (temp == "")
                        {
                            temp = previousValue.ToString() + currentValue.ToString();
                            Console.WriteLine("Temp" + temp);
                        }

                        else if (temp != "")
                        {

                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + currentValue.ToString());

                        }

                    }
                    else if (isNumber(currentValue) && isNumber(previousValue) && temp != "")
                    {
                        temp += currentValue.ToString();
                        Console.WriteLine("Temp" + temp);

                    }
                    else if (isNumber(currentValue) && !isNumber(previousValue) && temp != "")
                    {
                        temp += currentValue.ToString();
                        Console.WriteLine("Temp" + temp);

                    }
                    else if (isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                    {
                        if (temp =="") {
                            temp += currentValue.ToString();
                            Console.WriteLine("Temp" + temp);
                        }
                        
                        else if (temp != "")
                        {

                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + currentValue.ToString());

                        }
                    }
                    else if (!isNumber(currentValue) && isNumber(previousValue) && temp == "")
                    {
                        if (temp == "")
                        {
                            temp = previousValue.ToString() + currentValue.ToString();
                        }
                        else if (temp != "")
                        {
                            calculation.Add(temp);
                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + temp);

                            temp = "";
                        }


                    }
                    else if (!isNumber(currentValue) && isNumber(previousValue) && temp != "")
                    {
                        
                            calculation.Add(temp);
                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + temp);

                            temp = "";


                         if (temp != "")
                        {

                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + currentValue.ToString());

                        }

                    }
                    else if (!isNumber(currentValue) && !isNumber(previousValue) && temp != "")
                    {

                        temp += currentValue.ToString();


                        Console.WriteLine("Temp" + temp);




                    }
                    else if (isNumber(currentValue) && isNumber(previousValue) && temp != "")
                    {
                        temp += currentValue.ToString();
                        Console.WriteLine("Temp" + temp);
                    }
                    else if (isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                    {
                        if (temp =="") {
                            temp += currentValue.ToString();
                            Console.WriteLine("Temp" + temp);

                        }
                        else if (temp != "")
                        {

                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + currentValue.ToString());

                        }
                    }
                    else if (!isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                    {
                        if (temp == "") {
                            temp += currentValue.ToString();

                            Console.WriteLine("Temp" + temp);

                        }
                        if (temp != "")
                        {

                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + currentValue.ToString());

                        }
                    }
                    else if (isNumber(currentValue) && !isNumber(previousValue) && temp == "")
                    {
                        if (temp =="")
                        {
                            calculation.Add(temp);
                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + temp);

                            temp = "";


                            Console.WriteLine("Temp" + temp);
                        }
                          else
                         if (temp != "")
                        {

                            calculation.Add(currentValue.ToString());

                            Console.WriteLine("Added" + currentValue.ToString());

                        }
                    }
                    else if (temp != "")
                    {

                        calculation.Add(currentValue.ToString());

                        Console.WriteLine("Added" + currentValue.ToString());

                    }
                }
            }

            */
        }

        private void QuestionFourForm_Load(object sender, EventArgs e)
        {
            inputArea.Text = "( 59 - 15 ) % 27";
        }
    }
}
