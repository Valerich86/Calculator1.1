using System;
using System.Collections;

namespace Calculator1._1
{
    public partial class Form1 : Form
    {

        private string operation = "";
        private bool canInputSymbol = false, canInputDot = true, canResult = false, reset = false, explicitRes = false, ex = false;
        private List<string> memory = new List<string>();


        public Form1()
        {
            InitializeComponent();
            MainLabel.Text = "0";
            VirtualLabel.Text = "";
            ResultLabel.Text = "= ";
        }


        private void InputNumber(Button button)
        {
            if (reset == true)
                Reset();
            if (MainLabel.Text == "0")
                MainLabel.Text = button.Text;
            else
                MainLabel.Text += button.Text;
            VirtualLabel.Text += button.Text;
            if (canResult == false)
            {
                ResultLabel.Text = "";
            }
            ResultLabel.Text += button.Text;
            canInputSymbol = true;
            canResult = true;
        }


        private void InputOperation(Button button)
        {
            if (canInputSymbol)
            {
                string value;
                if (button == buttonDegree)
                    operation = "^";
                else
                    operation = button.Text;
                MainLabel.Text += operation;
                value = VirtualLabel.Text;
                memory.Add(value);
                memory.Add(operation);
                VirtualLabel.Text = "";
                canResult = false;
                canInputSymbol = false;
                canInputDot = true;
                ResultCalculation();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InputNumber(button1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            InputNumber(button2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            InputNumber(button3);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            InputNumber(button4);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            InputNumber(button5);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            InputNumber(button6);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            InputNumber(button7);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            InputNumber(button8);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            InputNumber(button9);
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            InputNumber(button0);
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (canInputSymbol)
                InputOperation(buttonAddition);
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (canInputSymbol)
                InputOperation(buttonSubtraction);
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (canInputSymbol)
                InputOperation(buttonMultiplication);
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (canInputSymbol)
                InputOperation(buttonDivision);
        }

        private void buttonDegree_Click(object sender, EventArgs e)
        {
            if (canInputSymbol)
                InputOperation(buttonDegree);
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (canInputSymbol)
            {
                string result = (MathF.Sqrt(float.Parse(VirtualLabel.Text))).ToString();
                int c = VirtualLabel.Text.Length;
                int b = MainLabel.Text.Length - c;
                MainLabel.Text = MainLabel.Text.Remove(b, c);
                ResultLabel.Text = result;
                MainLabel.Text += result;
                VirtualLabel.Text = result;
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset = true;
            Reset();
        }

        private void buttonDot_Click_1(object sender, EventArgs e)
        {
            if (canInputDot && canInputSymbol)
            {
                MainLabel.Text += ",";
                if (VirtualLabel.Text != "")
                    VirtualLabel.Text += ",";
                else
                    VirtualLabel.Text = "0,";
                if (ResultLabel.Text != "= ")
                    ResultLabel.Text += ",";
                else
                    ResultLabel.Text = "0,";

                canInputDot = false;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text != "= " && canResult && memory.Count > 1)
            {
                explicitRes = true;
                string value;
                value = VirtualLabel.Text;
                memory.Add(value);
                VirtualLabel.Text = "";
                ResultCalculation();
                canInputSymbol = false;
                canInputDot = false;
                if (ex)
                {
                    MainLabel.Text = "нельзя поделить на 0";
                    ex = false;
                }
                else
                    MainLabel.Text = ResultLabel.Text;
                explicitRes = false;
                reset = true;
            }
        }

        private void Reset()
        {
            canInputSymbol = false; canResult = false; canInputDot = true;
            MainLabel.Text = "0";
            VirtualLabel.Text = "";
            ResultLabel.Text = "= ";
            memory.Clear();
            reset = false;
        }

        private void ResultCalculation()
        {
            List<string> memoryCopy = new List<string>(memory);

            Operation("^", ref memoryCopy);
            Operation("/", ref memoryCopy);
            Operation("*", ref memoryCopy);
            Operation("-", ref memoryCopy);
            Operation("+", ref memoryCopy);

            ResultLabel.Text = "= " + memoryCopy[0];
            explicitRes = false;
            memoryCopy.Clear();
        }

        private void Operation(string operation, ref List<string> memoryCopy)
        {
            float x, y, result = 0;
            int length;
            if (explicitRes)
                length = memoryCopy.Count;
            else
                length = memoryCopy.Count - 1;
            for (int i = 0; i < length; i++)
            {
                if (memoryCopy[i] == operation)
                {
                    x = float.Parse(memoryCopy[i - 1]);
                    y = float.Parse(memoryCopy[i + 1]);
                    switch (operation)
                    {
                        case "^":
                            result = MathF.Pow(x, y); break;
                        case "/":
                            if (y == 0)
                            {
                                MainLabel.Text = "нельзя поделить на 0";
                                ex = true;
                                canInputSymbol = false;
                                reset = true;
                            }
                            result = x / y; break;
                        case "*":
                            result = x * y; break;
                        case "-":
                            result = x - y; break;
                        case "+":
                            result = x + y; break;
                    }
                    memoryCopy[i + 1] = result.ToString();
                    memoryCopy[i] = "x";
                    memoryCopy[i - 1] = "x";
                }
            }
            while (memoryCopy.Contains("x"))
            {
                for (int i = 0; i < memoryCopy.Count; i++)
                {
                    if (memoryCopy[i] == "x")
                        memoryCopy.RemoveAt(i);
                }
            }
        }

        // Changes for GitHub test
    }
}