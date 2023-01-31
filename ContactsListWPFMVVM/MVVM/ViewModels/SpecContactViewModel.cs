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
using System.Windows;

namespace ContactsListWPFMVVM.MVVM.ViewModels
{
    public partial class SpecContactViewModel : ObservableObject
    {
        [ObservableProperty]
        private string pageTitle = "Edit Contact";

        [ObservableProperty]
        private ObservableCollection<ContactsModel> contacts = FileService.Contacts();

        [ObservableProperty]
        public ContactsModel selectedContact = null!;

        [RelayCommand]
        public void Edit()
        {
            MessageBox.Show($"Contact {SelectedContact.DisplayName} is updated");
            Update(SelectedContact.ID, SelectedContact);
        }
        private void Update(Guid id, ContactsModel contact)
        {
            FileService.EditContact(id, contact);
        }

        [RelayCommand]
        public void Remove()
        {
            MessageBox.Show($"Are you sure that you want to remove: {SelectedContact.DisplayName}");
            FileService.RemoveContact(SelectedContact);
        }
    }
}
