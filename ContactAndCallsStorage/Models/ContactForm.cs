using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactAndCallsStorage.Models
{
    public class ContactForm
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string? Surname { get; set; }

        public int? Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public Guid ContactID { get; set; }

        //Номера контакта
        public List<PhoneNumber> Numbers { get; set; }

        //Ссылка на контакт
        public Contact Contact { get; set; }

    }
}
