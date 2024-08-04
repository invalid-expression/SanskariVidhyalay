using Microsoft.EntityFrameworkCore;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Model
{
    public class ContactDB : DbContext
    {
        public ContactDB(DbContextOptions <ContactDB> options) : base(options) 
        {
        }
        public DbSet<Contact> Contact { get; set; }
    }
}
