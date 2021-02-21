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
        static string content = "";
        static string old_content = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
           
            content = Match.print(1, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(2, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Thre_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(3, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(4, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(5, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(6, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(7, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
           
            content = Match.print(8, old_content);
            old_content = content;
            Fild.Content = content;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            content = Match.print(9, old_content);
            old_content = content;
            Fild.Content = content;
        }
    }
}
