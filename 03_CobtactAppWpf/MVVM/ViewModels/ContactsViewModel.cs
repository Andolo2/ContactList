using _03_CobtactAppWpf.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CobtactAppWpf.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>()
        {
            new ContactModel() {FirstName = "Kerstin", LastName = "Olofsson", Email = "Voff@hotmail.com"},
            new ContactModel() {FirstName = "Tida", LastName = "Saarela", Email = "Bapp@hotmail.com"}
        };
    }
}
