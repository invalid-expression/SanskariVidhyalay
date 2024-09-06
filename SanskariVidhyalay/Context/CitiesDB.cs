using Microsoft.EntityFrameworkCore;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Context
{
    public class CitiesDB : DbContext
    {
        public CitiesDB(DbContextOptions <CitiesDB> options) : base(options) 
        { 
        }
        public DbSet<Cities> City { get; set; }
    }
}
