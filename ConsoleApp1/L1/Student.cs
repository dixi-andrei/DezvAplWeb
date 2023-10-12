using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class Student : Interface1
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int varsta { get; set; }
        public List<Materie> materii { get; set; }

        public Student(string nume, string prenume, int varsta)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.materii = new List<Materie>();

        }

        public void adaugaMaterie(Materie materie)
        {
            materii.Add(materie);
        }

        public void afiseazaDetalii()
        {
            Console.WriteLine($"Date despre studentul");
            Console.WriteLine($"Nume: {this.nume}");
            Console.WriteLine($"Prenume: {this.prenume}");
            Console.WriteLine($"Varsta: {this.varsta}");
            Console.WriteLine("Materii");
            foreach (Materie materie in materii)
            {
                Console.WriteLine($"Titlu: {materie.titlu}, Durata: {materie.durata}, An de studiu: {materie.AnDeStudiu}");
            }
            Console.WriteLine();
        }

    }
}