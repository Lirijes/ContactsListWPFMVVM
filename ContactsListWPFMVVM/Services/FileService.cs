using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactsListWPFMVVM.MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListWPFMVVM.Services
{
    public static class FileService 
    {
        public static string FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ContactsWPFMVVM.json";

        public static ObservableCollection<ContactsModel> contacts = new ObservableCollection<ContactsModel>();

        static FileService()
        {
            Read();
        }

        public static void Read()
        {
            try
            {
                using var sr = new StreamReader(FilePath);
                contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactsModel>>(sr.ReadToEnd())!;
            }
            catch 
            {
                contacts = new ObservableCollection<ContactsModel>();
            }
        }

        public static void SaveContact()
        {
            using var sw = new StreamWriter(FilePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts));
        }

        public static void AddContact(ContactsModel contact)
        {
            contacts.Add(contact);
            SaveContact();
        }

        public static void RemoveContact(ContactsModel contact)
        {
            contacts.Remove(contact);
            SaveContact();
        }

        public static void EditContact(ContactsModel contact)
        {
            
        }

        public static ObservableCollection<ContactsModel> Contacts()
        {
            //var contactItems = new ObservableCollection<ContactsModel>();
            //foreach (ContactsModel contact in contacts)
            //contactItems.Add(contact);
            //return contactItems;
            return contacts;
        }
    }
}
