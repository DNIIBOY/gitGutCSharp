using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
            mainLbl.Content = eq.equate();
            eq.nums[0] = 0;
            eq.nums[1] = 0;
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content = "";
        }

        public class Equation
        {
            public int[] nums = new int[2];
            public string op = "n";

            public bool nextNumIsNew = true;

            public void AppendNum(int num, string newOp)
            {
                if (op != "n")
                {
                    nums[0] = calc(nums, op);
                }
                nextNumIsNew = true;
                nums[1] = num;
                op = newOp;
            }
            public int equate()
            {
                nums[0] = calc(nums, op);
                nums[1] = 0;
                return nums[0];
            }
        }

        static int calc(int[] nums, string op)
        {
            int res;
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
            int num = Convert.ToInt32(mainLbl.Content);
            eq.AppendNum(num, new_op);
            mainLbl.Content = eq.nums[0];
        }
    }
}
