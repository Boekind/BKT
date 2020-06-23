using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Label labelFocus;

        public MainWindow()
        {

            for (int i = 0; i < 4; i++)
            {
                Label lb = new Label();
                lb.Name = $"label{i}";
                lb.Content = i * 2;
                lb.Width = 20;
                //https://www.c-sharpcorner.com/UploadFile/mahesh/grid-in-wpf/
                myGrid.Children.Add(lb);
            }
        }

        //private void Test(object sender, RoutedEventArgs e, Button button)
        //{
        //    Console.WriteLine($"Klick {button.Content}!");
        //    Console.WriteLine();
        //}

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    Test(sender, e, Button1);
        //    Button2.IsEnabled = true;
        //    labelFocus.Background = Brushes.Red;
        //    //Styles?
        //}

        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    Test(sender, e, Button2);
        //    labelFocus.Background = Brushes.Blue;

        //}

        //private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var label = sender as Label;
        //    labelFocus = label;

        //}
    }
}
