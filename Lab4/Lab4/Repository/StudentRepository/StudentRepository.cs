using Lab4.Data;
using Lab4.Models;
using Lab4_23.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Repository.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(lab4context lab4Context) : base(lab4Context)
        {
        }

        public Student FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Student> OrderByMedie()
        {
         
            var studentsOrderedByMedie = _table.OrderBy(student => student.medie).ToList();

            return studentsOrderedByMedie;
        }
    }
}
