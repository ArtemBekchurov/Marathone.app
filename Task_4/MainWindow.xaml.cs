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

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Разместите на форме две кнопки рядом друг с 
        //другом (горизонтально). При нажатии на первую из них 
        //цвет второй кнопки должен стать красным, а текст на ней 
        //поменяться на RED. При нажатии на вторую кнопку 
        //первая должна стать зелёной и текст на ней поменяться
        //на GREEN.
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void One_btn_Click(object sender, RoutedEventArgs e)
        {
            two_btn.Background = Brushes.Red;
            two_btn.Content = "Red";
        }

        private void Two_btn_Click(object sender, RoutedEventArgs e)
        {
            one_btn.Background = Brushes.Green;
            one_btn.Content = "Green";
        }
    }
}
