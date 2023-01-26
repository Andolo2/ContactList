using _03_CobtactAppWpf.MVVM.Models;
using _03_CobtactAppWpf.MVVM.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _03_CobtactAppWpf.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

        [ObservableProperty]
        private ContactModel selectedContact = null!;

        [RelayCommand]
        public void Remove()
        {


            ContactService.Remove(SelectedContact);
        }

        [RelayCommand]
        public void Update()
        {
            if (MessageBox.Show("Update Contact", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                // No action needed.
            }
            else
            {
                ContactService.Update(SelectedContact);
            }



            
            
        }


    }
}
