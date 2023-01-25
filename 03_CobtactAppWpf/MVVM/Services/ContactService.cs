using _03_CobtactAppWpf.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CobtactAppWpf.MVVM.Services
{
    public static class ContactService
    {
        private static ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();

    }
}
