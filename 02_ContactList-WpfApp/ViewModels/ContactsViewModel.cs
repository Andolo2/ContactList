using _02_ContactList_WpfApp.Models;
using _02_ContactList_WpfApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace _02_ContactList_WpfApp.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        private readonly Fileservice FileService;
        public Contact SelectedName { get; set; }

        public ContactsViewModel()
        {
            FileService = new Fileservice();
            contacts = FileService.Contact();
        }

        [ObservableProperty]
        private string pageTigle = "Contacts";

        [ObservableProperty]
        private string contact = string.Empty;

        [ObservableProperty]
        private ObservableCollection<Contact> contacts;



        [RelayCommand]
        private void Delete()
        {


            MessageBox.Show("Button pressed");


            if (SelectedName != null)
            {
                Contacts.Remove(SelectedName);
                FileService.SaveToFile();
                
            }

        }
    }
}
