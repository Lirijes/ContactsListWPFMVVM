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
    public partial class SpecContactViewModel : ObservableObject
    {
        private readonly FileService fileservie;

        public SpecContactViewModel()
        {
            fileservie = new FileService();
            contacts = fileservie.Contacts();
        }

        [ObservableProperty]
        private string pageTitle = "Edit Contact";

        [ObservableProperty]
        private ObservableCollection<ContactsModel> contacts;


        [RelayCommand]
        public void RemoveContact(ContactsModel contact)
        {
            fileservie.RemoveContact(contact);
        }

    }
}
