using _02_ContactList_WpfApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _02_ContactList_WpfApp.Services
{
    public class Fileservice
    {
        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WpfContact.json";
        private List<Contact> contact;

        public Fileservice()
        {
            ReadFromFile();
        }

        private void ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(filePath);
                contact = JsonConvert.DeserializeObject<List<Contact>>(sr.ReadToEnd())!;
            }
            catch { contact = new List<Contact>(); }
        }

        public void SaveToFile()
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(contact));
        }

        public void AddToList(Contact contacts)
        {
            contact.Add(contacts);
            SaveToFile();
        }

        public void RemoveFromList(Contact contacts)
        {
            contact.Remove(contacts);
          
            SaveToFile();


            

        }



        public ObservableCollection<Contact> Contact()
        {
            ReadFromFile();
            var items = new ObservableCollection<Contact>();
            foreach (var contacts in contact)
                items.Add(contacts);

            return items;
        }
    }
}
