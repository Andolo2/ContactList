using _02_ContactList_WpfApp.Models;
using _02_ContactList_WpfApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _02_ContactList_WpfApp.ViewModels
{
    public partial class DisplayContactViewModel : ObservableObject, INotifyPropertyChanged
    {

        private readonly Fileservice FileService;

        public ICommand ChangeNameCommand { get; }

        public DisplayContactViewModel()
        {
            FileService = new Fileservice();
            contacts = FileService.Contact();
        }
        [ObservableProperty]
        private string pageTigle = "Manage Contact";

        [ObservableProperty]
        private string contact = string.Empty;

        [ObservableProperty]
        private ObservableCollection<Contact> contacts;

        private void update(Contact contacts)
        {








        }
    }
}