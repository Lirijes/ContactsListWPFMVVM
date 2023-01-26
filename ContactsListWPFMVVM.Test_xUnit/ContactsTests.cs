using ContactsListWPFMVVM.MVVM.Models;
using ContactsListWPFMVVM.Services;
using System.Collections.ObjectModel;

namespace ContactsListWPFMVVM.Test_xUnit
{
    public class ContactsTests
    {
        private FileService readContact;
        public ContactsTests()
        {
            readContact = new FileService();
        }

        [Fact]
        public void Should_Add_Contact_To_ContactList()
        {
            ContactsModel contact = new ContactsModel { FirstName = "Lirije", LastName = "Shabani" };
            readContact.Contacts.Add(contact);

            readContact.Contacts.Should().BeOfType<ObservableCollection<ContactsModel>>();
            readContact.Contacts.Should().Contain(contact);
        }
    }
}