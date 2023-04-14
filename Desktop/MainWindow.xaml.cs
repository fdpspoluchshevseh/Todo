﻿using Desktop.Repository;
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

namespace Desktop
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
        private void Registracia(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            reg.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserRepository.CheckUser(Login.Text, Password.Text))
            {
                var MainEmptyWindow = new Main_empty(Login.Text);
                MainEmptyWindow.Show(); 
                this.Close();
            }
        }
    }
}
