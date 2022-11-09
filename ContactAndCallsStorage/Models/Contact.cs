using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAndCallsStorage.Models
{
    public class Contact
    {
        public Guid ID { get; set; }
        public Guid ContactFormID { get; set; }

        //Ссылка на анкету контакта
        public ContactForm ContactForm { get; set; }
    }
}
