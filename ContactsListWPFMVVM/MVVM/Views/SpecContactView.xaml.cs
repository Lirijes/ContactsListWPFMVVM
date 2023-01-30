using ContactsListWPFMVVM.MVVM.Models;
using ContactsListWPFMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ContactsListWPFMVVM.MVVM.Views
{
    public partial class SpecContactView : UserControl
    {
        public SpecContactView()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            //var button = (Button)sender;
            //var contact = (ContactsModel)button.DataContext;

        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactsModel)button.DataContext;

            FileService.RemoveContact(contact);
        }
    }
}
