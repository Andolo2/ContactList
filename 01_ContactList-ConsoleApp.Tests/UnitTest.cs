using _01_ContactList_ConsoleApp.Models;
using _01_ContactList_ConsoleApp.Services;

namespace _01_ContactList_ConsoleApp.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Add_Contact_To_List() // Test checks if a list is populated with a contact.
        {
            //Arrenge
            Menu file = new Menu();
            Contact contact = new Contact();
            //Act

            file.ContactList.Add(contact);

            //Assert

            Assert.AreEqual(1, file.ContactList.Count);
        }
    }
}