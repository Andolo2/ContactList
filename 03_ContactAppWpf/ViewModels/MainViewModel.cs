using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ContactList_WpfApp.ViewModels
{
    public partial class MainViewModel : ObservableObject // from CommunityToolKit.MVVM, update changes dynamicly
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;


        [RelayCommand]
        private void GoToAddContact() // => currentViewModel = new AddContactViewModel();
        {
            CurrentViewModel = new AddContactViewModel();
        }

        [RelayCommand]
        private void GoToAddContacts() // => currentViewModel = new ContactsViewModel();
        {
            CurrentViewModel = new ContactsViewModel();
        }

        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel();
        }
    }
}
