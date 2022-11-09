using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAndCallsStorage.Models
{
    public class Conference
    {
        public Guid ConferenceID { get; set; }
        public Guid ContactID { get; set; }

        public List<ContactForm> Members { get; set; }
    }
}
