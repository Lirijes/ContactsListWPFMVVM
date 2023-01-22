using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListWPFMVVM.MVVM.Models
{
    public class ContactsModel
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Phonenumber { get; set; } = 0!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string DisplayName => $"{FirstName} {LastName}";
    }
}
