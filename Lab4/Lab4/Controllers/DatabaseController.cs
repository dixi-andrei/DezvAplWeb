using Lab4.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Lab4.Models;

namespace Lab4_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly lab4context _lab4Context;

        public DatabaseController(lab4context lab4Context)
        {
            _lab4Context = lab4Context;
        }

       
        [HttpGet("cursuri")]
        public async Task<IActionResult> GetCursuri()
        {
            var cursuri = await _lab4Context.Cursuri.ToListAsync();
            return Ok(cursuri);
        }

       
        [HttpPost("cursuri")]
        public async Task<IActionResult> CreateCurs(Curs curs)
        {
            _lab4Context.Cursuri.Add(curs);
            await _lab4Context.SaveChangesAsync();

            return Ok(curs);
        }

     
        [HttpGet("students")]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _lab4Context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpPost("students")]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            _lab4Context.Students.Add(student);
            await _lab4Context.SaveChangesAsync();

            return Ok(student);
        }

    }
}
