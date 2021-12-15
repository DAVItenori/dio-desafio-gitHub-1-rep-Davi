
using System;

namespace ExemploPOO.Models
{
    public class Pessoas
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual void Apresentar() {
                Console.WriteLine($"Olá me chamo {Nome}, tenho {Idade} anos!");

        }
    }
}