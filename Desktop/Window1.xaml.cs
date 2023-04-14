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
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Desktop.Repository;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Manager.window = this; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.Name(name.Text) == false)
            {
                MessageBox.Show("Введены некорректные данные.\n Имя должно содержать больше двух символов");
            }
            else if(Validator.Mail(mail.Text) == false)
            {
                MessageBox.Show("Введены некорректные данные.\n Почта должна быть записана по паттерну *@*.* \n где * - текст");
            }

            else if(Validator.Regpass(regparol.Text) == false)
            {
                MessageBox.Show("Введены некорректные данные.\n Пароль не должен содержать менее 6-ти символов");
            }

            else if(Validator.Regpasstwo(regparoltwo.Text, regparol.Text) == false)
            {
                MessageBox.Show("Введены некорректные данные.\n Пароли не совпадают");
            }
            else if (UserRepository.CheckEmail(mail.Text))
            {
                UserRepository.AddUser(name.Text, mail.Text, regparol.Text);
                var MainEmptyWindow = new Main_empty(name.Text);
                MainEmptyWindow.Show();
                MessageBox.Show("Молодец, всё получилось, возьми с полки пирожок ♥");
                this.Close();
            }
            else
            {
                MessageBox.Show("Этот почтовый адрес уже занят");
            }
        }
    }
}
