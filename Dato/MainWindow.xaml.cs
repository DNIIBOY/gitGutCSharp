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

namespace Dato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime date = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            date = date.AddDays(1);
            MyDate.Content = date.ToString("dd-MM-yyyy");
        }
        
        private void Button_Click_Prev(object sender, RoutedEventArgs e)
        {
            date = date.AddDays(-1);
            MyDate.Content = date.ToString("dd-MM-yyyy");
        }
    }
}
