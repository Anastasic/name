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

namespace Проверка
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void test_click(object sender, RoutedEventArgs e)
        {
            Class1 cl = new Class1();
            bool a1 = cl.telephone(ph.Text);
            if (a1 == true)
            {
                MessageBox.Show("Телефон правильный");
            }
            else
            {
                MessageBox.Show("Телефон не правильный");
            }
        }

        private void email_click(object sender, RoutedEventArgs e)
        {
            Class1 cl = new Class1();
            bool a1 = cl.email(email1.Text);
            if (a1 == true)
            {
                MessageBox.Show("Email правильный");
            }
            else
            {
                MessageBox.Show("Email не правильный");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 cl = new Class1();
            bool a1 = cl.pasport(pas.Text);
            if (a1 == true)
            {
                MessageBox.Show("Телефон правильный");
            }
            else
            {
                MessageBox.Show("Телефон не правильный");
            }
        }

        private void st2(object sender, RoutedEventArgs e)
        {
            Class1 cl = new Class1();
            bool a1 = cl.dt(dt1.Text);
            if (a1 == true)
            {
                MessageBox.Show("Телефон правильный");
            }
            else
            {
                MessageBox.Show("Телефон не правильный");
            }
        }

        private void fio2(object sender, RoutedEventArgs e)
        {
            Class1 cl = new Class1();
            bool a1 = cl.fio(fio1.Text);
            if (a1 == true)
            {
                MessageBox.Show("Телефон правильный");
            }
            else
            {
                MessageBox.Show("Телефон не правильный");
            }
        }
    }
}
