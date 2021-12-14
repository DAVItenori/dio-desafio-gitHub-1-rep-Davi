namespace ExemploPOO.Models
{
    public class Professor: Pessoas
    {
        public double Salario { get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá sou um professor, meu nome é {Nome} e meu salário {Salario}");

        }
    }
}