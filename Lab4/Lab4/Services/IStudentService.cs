using Lab4.Models.DTOS;
namespace Lab4.Services;

public interface IStudentService
{
    Task<List<StudentDTOS>> GetAllStudents();

    StudentDTOS GetStudentByName(string name);
}
