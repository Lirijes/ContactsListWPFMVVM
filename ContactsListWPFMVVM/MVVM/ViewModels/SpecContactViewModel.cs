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
        [ObservableProperty]
        private string pageTitle = "Edit Contact";

        [ObservableProperty]
        private ObservableCollection<ContactsModel> contacts = FileService.GetContacts();
    }
}
