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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            MinDato dato = GetDato(MyDate.Content.ToString());
            dato.Next();
            MyDate.Content = dato.Dato_String();
        }
        
        private void Button_Click_Prev(object sender, RoutedEventArgs e)
        {
            MinDato dato = GetDato(MyDate.Content.ToString());
            dato.Previous();
            MyDate.Content = dato.Dato_String();
        }

        private MinDato GetDato(string date)
        {
            string[] dateList = date.Split("-");
            int day = Convert.ToInt32(dateList[0]);
            int month = Convert.ToInt32(dateList[1]);
            int year = Convert.ToInt32(dateList[2]);
            return new MinDato(day, month, year);
        }
    }
}
