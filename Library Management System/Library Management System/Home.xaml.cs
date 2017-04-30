﻿using System;
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

namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Add_Book add_book_w = new Add_Book();
            add_book_w.Show();

        }

        private void btn_settigs_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Manage_System_User mb = new Manage_System_User();
            mb.Show();


        }

        private void btn_explorer_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Explore_book ex = new Explore_book();
            ex.Show();
        }
    }
}
