﻿using _02_ContactList_WpfApp.Models;
using _02_ContactList_WpfApp.ViewModels;
using CommunityToolkit.Mvvm.Input;
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

namespace _02_ContactList_WpfApp.Views
{
    /// <summary>
    /// Interaction logic for ContactView.xaml
    /// </summary>
    public partial class ContactView : UserControl
    {
        public ContactView()
        {
            InitializeComponent();


        }


        private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var  contact = (ContactsViewModel)button.DataContext;
        }

    }
}
