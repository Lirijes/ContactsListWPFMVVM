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
        public AddContactViewModel()
        {
        }

        [ObservableProperty]
        private string pageTitle = "Add Contact";

        [ObservableProperty]
        private string firstname = string.Empty;

        private string lastname = string.Empty;

        private int phonenumber = 0;

        [ObservableProperty]
        private string address = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [RelayCommand]
        public void AddContact()
        {
            FileService.AddContact(new ContactsModel { FirstName = Firstname, LastName = lastname, Phonenumber = phonenumber, Address = Address, Email = Email });
            Firstname = string.Empty;
            lastname = string.Empty;
            phonenumber = 0;
            Address = string.Empty;
            Email = string.Empty;
        }
    }
}
