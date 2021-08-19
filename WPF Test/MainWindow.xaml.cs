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

        public void calc(string op)
        {
            double n1 = Convert.ToInt32(input1.Text);
            double n2 = Convert.ToInt32(input2.Text);
            switch (op)
            {
                case "+":
                    output.Text = Convert.ToString(n1 + n2);
                    break;
                case "-":
                    output.Text = Convert.ToString(n1 - n2);
                    break;
                case "*":
                    output.Text = Convert.ToString(n1 * n2);
                    break;
                case "/":
                    output.Text = Convert.ToString(n1 / n2);
                    break;
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            calc("+");
        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            calc("-");
        }

        private void multBtn_Click(object sender, RoutedEventArgs e)
        {
            calc("*");
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            calc("/");
        }

        private void clrBtn_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            input1.Text = "";
            input2.Text = "";
            output.Text = "";
        }
    }
}
