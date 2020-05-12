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

namespace Urlaubsplaner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Background = getRandomBrush();
        }

        public static Brush getRandomBrush()
        {
            string[] brushArray = typeof(Brushes).GetProperties().
                                        Select(c => c.Name).ToArray();

            Random randomGen = new Random();
            string randomColorName = brushArray[randomGen.Next(brushArray.Length)];
            SolidColorBrush color = (SolidColorBrush)new BrushConverter().ConvertFromString(randomColorName);

            return color;
        }
    }
}
