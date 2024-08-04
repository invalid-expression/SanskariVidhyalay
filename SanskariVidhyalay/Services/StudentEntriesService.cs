using System.Collections.Generic;
using System.Linq;
using SanskariVidhyalay.Model;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Services
{
    public class StudentEntriesService : IStudentEntriesService
    {
        private readonly StudentEntriesDB _context;

        public StudentEntriesService(StudentEntriesDB context)
        {
            _context = context;
        }

        public IEnumerable<StudentEntries> GetAllStudents()
        {
            return _context.StudentEntries.ToList();
        }

        public void AddStudent(StudentEntries student)
        {
            _context.StudentEntries.Add(student);
            _context.SaveChanges();
        }
    }
}

