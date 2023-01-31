using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactsListWPFMVVM.MVVM.Models;
using ContactsListWPFMVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListWPFMVVM.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        public AddContactViewModel()
        {
        }

        [ObservableProperty]
        private string pageTitle = "Add Contact";

        [ObservableProperty]
        private string firstname = string.Empty;

        [ObservableProperty]
        private string lastname = string.Empty;

        [ObservableProperty]
        private int phonenumber = 0;

        [ObservableProperty]
        private string address = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [RelayCommand]
        public void AddContact()
        {
            FileService.AddContact(new ContactsModel { FirstName = Firstname, LastName = Lastname, Phonenumber = Phonenumber, Address = Address, Email = Email });
            Firstname = string.Empty;
            Lastname = string.Empty;
            Phonenumber = 0;
            Address = string.Empty;
            Email = string.Empty;
        }


        [ObservableProperty]
        private ObservableCollection<ContactsModel> contacts = FileService.Contacts();

    }
}
