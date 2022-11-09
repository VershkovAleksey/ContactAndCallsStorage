using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactAndCallsStorage.Models
{
    public class Call
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public Guid FirstSubscriberPhoneID { get; set; }
        public Guid SecondSubscriberPhoneID { get; set; }
        public CallType CallType { get; set; }

        [DataType(DataType.Date)]
        public DateTime CallTime { get; set; }

        [DataType(DataType.Date)]
        public TimeSpan Duration { get; set; }

    }
}
