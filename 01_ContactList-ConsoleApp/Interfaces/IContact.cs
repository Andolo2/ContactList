using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ContactList_ConsoleApp.Interfaces
{
    internal interface IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string PhoneNumber { get; set; } // Set as string since no calculations are going to be needed.
        string Email { get; set; }

        string Adress { get; set; }

        string PostalCode { get; set; }

        string  City { get; set; }

        string ContactName => $"{FirstName} {LastName}";


    }
}
