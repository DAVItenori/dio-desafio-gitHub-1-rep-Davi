
namespace ExemploPOO.Models
{
    public class Aluno: Pessoas 
    {
public Aluno (string nome, string sobrenome) : base(nome,sobrenome) {
    

        }

          public override void Apresentar() {

           Console.WriteLine($"Olá sou um aluno, meu nome é {Nome}, minha nota é {ota}");
}
        
    }
}
