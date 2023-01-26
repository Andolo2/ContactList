using _03_CobtactAppWpf.MVVM.Models;
using _03_CobtactAppWpf.MVVM.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CobtactAppWpf.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        

        [ObservableProperty]
        private string title = "Add Contact";

        [ObservableProperty]
        private string firstname = string.Empty;

        [ObservableProperty]
        private string lastname = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [ObservableProperty]
        private string phonenumber = string.Empty;

        [ObservableProperty]
        private string adress = string.Empty;


        [ObservableProperty]
        private string postalcode = string.Empty;

        [ObservableProperty]
        private string city = string.Empty;

        [RelayCommand]
        public void AddContact()
        {
            ContactService.Add(new ContactModel() { FirstName = firstname, LastName = lastname, Email = email, PhoneNumber = phonenumber, Adress = adress, PostalCode = postalcode, City = city, });

            firstname = string.Empty;



        }

    }


}
