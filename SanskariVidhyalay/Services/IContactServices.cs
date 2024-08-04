using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SanskariVidhyalay.Model;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Services
{
    public class IContactServices : IContact
    {
        private readonly ContactDB _context;
        public IContactServices(ContactDB context) 
        {
            _context = context;
        }

        public IEnumerable<Contact> GetAllContact()
        {
            return _context.Contact.ToList();
        }
        public void AddContact(Contact contact) 
        {
            _context.Contact.Add(contact);
            _context.SaveChanges();
        }

    }
}
