using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactAndCallsStorage.Models;

namespace ContactAndCallsStorage.Data
{
    public class ContactAndCallsStorageContext : DbContext
    {
        public ContactAndCallsStorageContext (DbContextOptions<ContactAndCallsStorageContext> options)
            : base(options)
        {
        }

        public DbSet<ContactAndCallsStorage.Models.ContactForm> Contact { get; set; }
    }
}
