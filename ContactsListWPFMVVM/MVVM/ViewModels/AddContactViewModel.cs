using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactsListWPFMVVM.MVVM.Models;
using ContactsListWPFMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListWPFMVVM.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        private readonly FileService fileservice;

        public AddContactViewModel()
        {
            fileservice = new FileService();
        }

        [ObservableProperty]
        private string pageTitle = "Add Contact";

        [ObservableProperty]
        private string contact = string.Empty;

        [RelayCommand]
        private void AddContact()
        {
            fileservice.AddContact(new ContactsModel { FirstName = Contact, LastName = Contact, Address = Contact, Email = Contact });
            Contact = string.Empty;
        }

        [RelayCommand]
        private void RemoveContact(ContactsModel contact)
        {
            fileservice.RemoveContact(contact);
        }
    }
}
