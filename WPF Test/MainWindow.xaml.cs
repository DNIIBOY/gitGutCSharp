using System.Windows;
using Convert = System.Convert;

namespace WPF_Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Equation eq = new Equation();

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                mainLbl.Content = "";
                eq.nextNumIsNew = false;
            }
            mainLbl.Content += "9";
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                eq.op = "+";
            }
            else
            {
                takeInput("+");
            }
            opLbl.Content = "+";
        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                eq.op = "-";
            }
            else
            {
                takeInput("-");
            }
            opLbl.Content = "-";
        }

        private void multBtn_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                eq.op = "*";
            }
            else
            {
                takeInput("*");
            }
            opLbl.Content = "*";
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                eq.op = "/";
            }
            else
            {
                takeInput("/");
            }
            opLbl.Content = "/";
        }

        private void eqBtn_Click(object sender, RoutedEventArgs e)
        {
            if (eq.nextNumIsNew)
            {
                eq.AppendNum(0, "+");
            }
            opLbl.Content = "=";
            takeInput("+");
            mainLbl.Content = eq.equate();
            eq.nums[0] = 0;
            eq.nums[1] = 0;
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content = "";
            eq.nums[0] = 0;
            eq.nums[1] = 0;
        }

        public class Equation
        {
            public double[] nums = { 0, 0 };
            public string op = "+";

            public bool nextNumIsNew = true;

            public void AppendNum(double num, string newOp)
            {
                nums[1] = num;
                nums[0] = calc(nums, op);
                nums[1] = 0;
                nextNumIsNew = true;
                op = newOp;
            }
            public double equate()
            {
                nums[0] = calc(nums, op);
                nums[1] = 0;
                return nums[0];
            }
        }

        static double calc(double[] nums, string op)
        {
            double res;
            switch (op)
            {
                case "+":
                    res = nums[0] + nums[1];
                    break;
                case "-":
                    res = nums[0] - nums[1];
                    break;
                case "*":
                    res = nums[0] * nums[1];
                    break;
                case "/":
                    if (nums[1] == 0)
                    {
                        return 0;
                    }
                    res = nums[0] / nums[1];
                    break;
                default:
                    res = -1;
                    break;
            }
            return res;
        }

        void takeInput(string new_op)
        {
            double num = Convert.ToDouble(mainLbl.Content);
            eq.AppendNum(num, new_op);
            mainLbl.Content = eq.nums[0];
        }
    }
}
