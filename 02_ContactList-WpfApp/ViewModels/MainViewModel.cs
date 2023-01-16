using CommunityToolkit.Mvvm.ComponentModel;
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

        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel();
        }
    }
}
