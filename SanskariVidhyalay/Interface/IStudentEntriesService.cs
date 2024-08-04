using System.Collections.Generic;
using SanskariVidhyalay.Models;

namespace SanskariVidhyalay.Services
{
    public interface IStudentEntriesService
    {
        IEnumerable<StudentEntries> GetAllStudents();
        void AddStudent(StudentEntries student) { }
    }
}
