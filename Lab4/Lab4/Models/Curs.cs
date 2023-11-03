namespace Lab4.Models
{
    public class Curs
    {
        public int CursId { get; set; }
        public string Title { get; set; }
      
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
