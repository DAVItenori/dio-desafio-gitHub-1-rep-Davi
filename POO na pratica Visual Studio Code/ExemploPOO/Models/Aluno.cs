
namespace ExemploPOO.Models
{
    public class Aluno: Pessoas 
    {
        public float Nota { get; set; }

        public override void Apresentar() {
           Console.WriteLine($"Olá sou um aluno, meu nome é {Nome}, minha nota é {Nota}");



        }
        
    }
}