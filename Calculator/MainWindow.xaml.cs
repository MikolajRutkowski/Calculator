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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Match match = new Match();

        public MainWindow()
        {
            InitializeComponent();

            Fild.DataContext = match;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {

            match.ReturValue = 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            match.ReturValue = 2;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            match.add();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
