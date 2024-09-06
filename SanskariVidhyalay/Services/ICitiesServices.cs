using SanskariVidhyalay.Context;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Services
{
    public class ICitiesServices : ICities
    {
        private readonly CitiesDB _context;
        public ICitiesServices(CitiesDB context)
        {
            _context = context;
        }
        public IEnumerable<Cities> GetAllCities()
        {
            return _context.City.ToList();
        }
    }
}
