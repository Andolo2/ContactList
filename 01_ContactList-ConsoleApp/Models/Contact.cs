using _01_ContactList_ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ContactList_ConsoleApp.Models
{
    public class Contact : IContact
    {
       

        public string FirstName { get ; set ; } 
        public string LastName { get ; set ; }
        public string PhoneNumber { get ; set ; }
        public string Email { get ; set ; }
        public string Adress { get ; set ; }
        public string PostalCode { get ; set ; }
        public string City { get ; set ; }

        //public Contact(string _firstname, string _lastname, string _phonenumber, string _email, string _adress, string _postalcode, string _city)
        //{
        //    FirstName = _firstname;
        //    LastName = _lastname;
        //    PhoneNumber = _phonenumber;
        //    Email = _email;
        //    Adress = _adress;
        //    PostalCode = _postalcode;
        //    City = _city;
        //}

        
    }

   
}
