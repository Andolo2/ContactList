using _02_ContactList_WpfApp.Models;
using _02_ContactList_WpfApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ContactList_WpfApp.ViewModels
{
    public partial class ContactsViewModel: ObservableObject
    {
        private readonly Fileservice FileService;


        public ContactsViewModel()
        {
            FileService = new Fileservice();
            contacts = FileService.Contact();
        }

        [ObservableProperty]
        private string pageTigle = "Contacts";

        [ObservableProperty]
        private ObservableCollection<Contact> contacts;
    }
}
