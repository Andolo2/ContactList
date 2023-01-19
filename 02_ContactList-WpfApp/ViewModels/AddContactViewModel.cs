﻿using _02_ContactList_WpfApp.Models;
using _02_ContactList_WpfApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ContactList_WpfApp.ViewModels
{
   public partial class AddContactViewModel : ObservableObject
    {
        private readonly Fileservice FileService;

        public AddContactViewModel()
        {
            FileService = new Fileservice();
        }

        [ObservableProperty]
        private string pageTigle = "Add a contact";

        [ObservableProperty]
        private string contact = string.Empty;

        [ObservableProperty]
        private string lastname = string.Empty;
        



        [RelayCommand]
        private void Add()
        {
            FileService.AddToList(new Contact() {FirstName = contact, LastName = lastname, Email = contact, PhoneNumber = contact, Adress = contact,PostalCode = contact, City=contact,  }  );
    
            contact = string.Empty;

            

        }

        

        
    }
}
