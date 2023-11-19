using Lab4_23.Repositories.GenericRepository;
using Lab4.Models;

namespace Lab4.Repository.StudentRepository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        List<Student> OrderByMedie();

        Student FindByName(string name);
 
    }
}
