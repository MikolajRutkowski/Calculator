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
            BigFild.DataContext = match;
            Fild.DataContext = match;
            
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            
            match.ReturnValue = 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 2;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            match.add();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Thre_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 3;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 4;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 6;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 9;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            match.ReturnValue = 0;
        }
    }
}
