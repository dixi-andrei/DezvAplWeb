using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class Materie
    {
        public string titlu {  get; set; }

        public int durata { get; set; }

        public int AnDeStudiu { get; set; }

        public Materie(string titlu, int durata, int AnDeStudiu)
        {
            this.titlu = titlu;
            this.durata = durata;
       
            try
            {
                if (AnDeStudiu < 0 || AnDeStudiu > 4)
                {
                    throw new ArgumentOutOfRangeException("Anul de studiu trebuie să fie între 0 și 4.");
                }
                this.AnDeStudiu = AnDeStudiu;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}