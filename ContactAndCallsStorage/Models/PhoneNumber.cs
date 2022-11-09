using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactAndCallsStorage.Models
{
    public class PhoneNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public Guid ContactFormID { get; set; }

        [Required]
        public long Number { get; set; }
        public string? Region { get; set; }
        public string? Operator { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        //Ссылка на контакт
        public ContactForm ContactForm { get; set; }
        public List<Call> Calls { get; set; }
    }
}
