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
    public class FileService
    {
        public string FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ContactsWPFMVVM.json";

        private List<ContactsModel> contacts = new List<ContactsModel>();

        public FileService()
        {
            Read();
        }

        public void Read()
        {
            try
            {
                using var sr = new StreamReader(FilePath);
                contacts = JsonConvert.DeserializeObject<List<ContactsModel>>(sr.ReadToEnd())!;
            }
            catch 
            {
                contacts = new List<ContactsModel>();
            }
        }

        public void SaveContact()
        {
            using var sw = new StreamWriter(FilePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts));
        }

        public void AddContact(ContactsModel contact)
        {
            contacts.Add(contact);
            SaveContact();
        }

        public void RemoveContact(ContactsModel contact)
        {
            contacts.Remove(contact);
            SaveContact();
        }

        public ObservableCollection<ContactsModel> Contacts()
        {
            var contactItems = new ObservableCollection<ContactsModel>();
            foreach (ContactsModel contact in contacts) 
                contactItems.Add(contact);
            return contactItems;
        }
    }
}
