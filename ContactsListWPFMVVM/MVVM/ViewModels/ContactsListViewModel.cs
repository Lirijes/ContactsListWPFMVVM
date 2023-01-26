using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class ContactsListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string pageTitle = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactsModel> contacts = FileService.GetContacts();
    }
}
