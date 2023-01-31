using _03_CobtactAppWpf.MVVM.Services;
using _03_CobtactAppWpf.MVVM.ViewModels;

namespace _03_CobtactAppWpf.Tests
{
    public class ContactServiceTest
    {
        // Found info on this site: https://stackoverflow.com/questions/53672121/how-to-unit-test-string-value-in-an-object-class
        private ContactsViewModel title;

        public ContactServiceTest()
        {
            title = new ContactsViewModel();
        }

        [Fact]
        public void Check_If_Title_is_Correct()
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