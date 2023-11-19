using Lab4.Data;
using Lab4.Models;

namespace Lab4.Helpers.Seeders
{
    public class StudentSeeder
    {
        public readonly lab4context _lab4Context;

        public StudentSeeder(lab4context lab4Context)
        {
            _lab4Context = lab4Context;
        }

        public void SeedInitialUsers()
        {
            if (!_lab4Context.Students.Any())
            {
                var student1 = new Student
                {
                    nume = "Nume Student 1",
                    prenume = "Prenume Student 1",
                    age = 20,
                    medie = 9,
                    IsDeleted = false
                };

                var student2 = new Student
                {
                    nume = "Nume Student 2",
                    prenume = "Prenume Student 2",
                    age = 20,
                    medie = 9,
                    IsDeleted = false
                };

                _lab4Context.Students.Add(student1);
                _lab4Context.Students.Add(student2);

                _lab4Context.SaveChanges();
            }
        }
    }
}
