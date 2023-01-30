using _03_CobtactAppWpf.MVVM.Services;
using _03_CobtactAppWpf.MVVM.ViewModels;

namespace _03_CobtactAppWpf.Tests
{
    public class ContactServiceTest
    {

        private ContactsViewModel title;

        public ContactServiceTest()
        {
            title = new ContactsViewModel();
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            string expected = "Contacts";
            title.Title = expected;

            //Act

            string implemented = title.Title;

            //Assert

            Assert.Equal(expected, implemented);
        }
    }
}