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

        private void btn0_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "0";
        }

        private void btn1_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "1";
        }

        private void btn2_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "2";
        }

        private void btn3_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "3";
        }

        private void btn4_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "4";
        }

        private void btn5_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "5";
        }

        private void btn6_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "6";
        }

        private void btn7_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "7";
        }

        private void btn8_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "8";
        }

        private void btn9_click(object sender, RoutedEventArgs e)
        {
            mainLbl.Content += "9";
        }

        public class Equation
        {
            public int[] nums = new int[2];
            public string op;

            public void appendNum(int num)
            {
                nums[0] = calc(nums, op);
                nums[1] = num;
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
                    res = nums[0] / nums[1];
                    break;
                default:
                    res = -1;
                    break;
            }
            return res;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eqBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
