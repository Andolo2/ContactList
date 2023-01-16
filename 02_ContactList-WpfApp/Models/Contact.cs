
using _02_ContactList_WpfApp.IInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ContactList_WpfApp.Models
{
    public class Contact : IContact
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get ; set ; } = string.Empty;
        public string PhoneNumber { get ; set ; }
        public string Email { get ; set ; } = string.Empty;
        public string Adress { get ; set ; }
        public string PostalCode { get ; set ; }
        public string City { get ; set ; }
    }
}
