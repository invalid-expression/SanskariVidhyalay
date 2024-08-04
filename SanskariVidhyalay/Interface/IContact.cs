using System.Collections.Generic;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Services 
{
    public interface IContact 
    {
        IEnumerable<Contact> GetAllContact(); 
        void AddContact(Contact contact) { }
    }

}
