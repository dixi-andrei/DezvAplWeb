using AutoMapper;
using Lab4.Models.DTOS;
using Lab4.Repository.StudentRepository;

namespace Lab4.Services
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<List<StudentDTOS>> GetAllStudents()
        {
            var studentList = await _studentRepository.GetAllAsync();
            return _mapper.Map<List<StudentDTOS>>(studentList);
        }

        public StudentDTOS GetStudentByName(string name)
        {
            var student = _studentRepository.FindByName(name);

            return _mapper.Map<StudentDTOS>(student);
        }
    }
}
