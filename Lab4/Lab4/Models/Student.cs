namespace Lab4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string nume {  get; set; }

        public string prenume { get; set; }

        public int varsta { get; set; }

        public List<Curs> Cursuri { get; set; }
        public object Curs { get; internal set; }
    }
}
