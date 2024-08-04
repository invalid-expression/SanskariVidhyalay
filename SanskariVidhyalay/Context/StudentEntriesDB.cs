using Microsoft.EntityFrameworkCore;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Model 
{
	public class StudentEntriesDB : DbContext
	{
		public StudentEntriesDB(DbContextOptions <StudentEntriesDB> options) : base(options) { }
        public DbSet<StudentEntries> StudentEntries { get; set; }
    }
}
