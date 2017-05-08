using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Texter.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Id { get; set; }

        public Contact(string name, string phoneNumber, int id = 0)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Id = id;
        }
    }


}
