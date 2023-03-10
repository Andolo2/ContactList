using _03_CobtactAppWpf.MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace _03_CobtactAppWpf.MVVM.Services
{
    public static class ContactService
    {
        private static ObservableCollection<ContactModel> contacts;
        private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\list.json");



        static ContactService()
        {
            try
            {
                contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(fileService.Read())!;
            }
            catch
            {
               contacts = new ObservableCollection<ContactModel>();
            }
        }

        public static void Add(ContactModel model)
        {
            contacts.Add(model);
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }

        public static void Remove(ContactModel model)
        {
            contacts.Remove(model);
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }

        public static void Update(ContactModel model)
        {
         
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }


        public static ObservableCollection<ContactModel> Contacts()
        {
            return contacts;
        }

    }

}
