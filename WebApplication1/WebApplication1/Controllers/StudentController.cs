using L1;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        

        List<Student> studenti = new List<Student>();
       


        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
            Student student1 = new Student(1,"Vaduva", "Rereta", 30);
            Student student2 = new Student(2,"Marian", "Viorel", 50);
            Student student3 = new Student(3,"florin", "cazimirovici", 20);
            Student student4 = new Student(4,"Marian", "Constatin", 10);
            studenti.Add(student1);
            studenti.Add(student2);
            studenti.Add(student3);
            studenti.Add(student4);
        }

        [HttpGet("students")]
      public List<Student> Get()
        {
            return studenti; 
        }
        [HttpDelete(Name = "studentDelete")]

        public List<Student> delete(int id)
        {
           
            int index = studenti.FindIndex(student => student.Id == id);
            studenti.RemoveAt(index);
            return studenti;
        }
        
        [HttpGet("getAllOrdered")]
      public List<Student> GetOrdered()
        {
            
         return studenti.OrderBy(student => student.varsta).ToList();
        }
        
    }


}