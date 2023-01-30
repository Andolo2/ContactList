using _03_CobtactAppWpf.MVVM.Models;
using _03_CobtactAppWpf.MVVM.Services;
using CommunityToolkit.Mvvm.Messaging;
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

namespace _03_CobtactAppWpf.MVVM.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {
        public ContactsView()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;
            
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Delete Contact", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                // No action needed.
            }
            else
            {
                var button = (Button)sender;
                var contact = (ContactModel)button.DataContext;

                ContactService.Remove(contact);
            }
            ;
           
        }

       
    }
}
