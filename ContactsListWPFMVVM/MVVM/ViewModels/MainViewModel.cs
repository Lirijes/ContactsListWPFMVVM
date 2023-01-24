using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListWPFMVVM.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        public MainViewModel()
        {
            CurrentViewModel = new StartupViewModel();
        }

        [RelayCommand]
        private void GoToAddContact()
        {
            CurrentViewModel = new AddContactViewModel();
        }

        [RelayCommand]
        private void GoToContacts()
        {
            CurrentViewModel = new ContactsListViewModel();
        }

        [RelayCommand]
        public void GoToStartup()
        {
            CurrentViewModel = new StartupViewModel();
        }
    }
}
