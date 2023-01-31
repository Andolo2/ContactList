using _01_ContactList_ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ContactList_ConsoleApp.Models
{
    public class Contact : IContact
    {


        public string FirstName { get; set; } = null!;
        public string LastName { get ; set ; } = null!;
        public string PhoneNumber { get ; set ; } = null!;
        public string Email { get ; set ; } = null!;
        public string Adress { get ; set ; } = null!;
        public string PostalCode { get ; set ; } = null!;
        public string City { get ; set ; } = null!;



    }

   
}
