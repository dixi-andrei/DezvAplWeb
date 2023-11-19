using Lab4.Models.Base;

namespace Lab4.Models
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        public string nume {  get; set; }

        public string prenume { get; set; }

        public int age { get; set; }

        public int medie { get; set; }

        public List<Curs> Cursuri { get; set; }
        public object Curs { get; internal set; }
        public bool IsDeleted { get; internal set; }
    }
}
