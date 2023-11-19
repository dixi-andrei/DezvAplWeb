using Lab4.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class StudentsControlller : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsControlller(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{name}")]
        public IActionResult GetStudentByName(string name)
        {
            var student = _studentService.GetStudentByName(name);

            if (student == null)
            {
                return NotFound($"Studentul cu numele {name} nu a fost găsit.");
            }

            return Ok(student);
        }
    }
}
