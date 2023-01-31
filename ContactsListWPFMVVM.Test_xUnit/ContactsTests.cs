using ContactsListWPFMVVM.MVVM.Models;
using ContactsListWPFMVVM.Services;
using FluentAssertions;
using System.Collections.ObjectModel;

namespace ContactsListWPFMVVM.Test_xUnit
{
    public class ContactsTests
    {
        public ContactsTests()
        {
        }

        [Fact]
        public void Should_Add_Contact_To_ContactList()
        {
            ContactsModel contact = new ContactsModel { FirstName = "Lirije", LastName = "Shabani" };
            FileService.contacts.Add(contact);

            FileService.contacts.Should().BeOfType<ObservableCollection<ContactsModel>>();
            FileService.contacts.Should().Contain(contact);
        }
    }
}