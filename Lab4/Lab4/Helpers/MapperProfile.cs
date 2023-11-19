using AutoMapper;
using Lab4.Models;
using Lab4.Models.DTOS;
namespace Lab4.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<Student, StudentDTOS>();
            CreateMap<Student, StudentDTOS>();

            CreateMap<Student, StudentDTOS>()
                .ForMember(ud => ud.fullname,
                opts => opts.MapFrom(u => u.nume + u.prenume));
        }
    }
}
