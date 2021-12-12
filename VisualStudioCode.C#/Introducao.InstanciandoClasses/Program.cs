using Global;
using Global2;


namespace Geral
{
    class ProgramaGeral
    {
        static void Main(String[] args)
        {


            Pessoa Pessoa = new Pessoa();
            Pessoa.nome = "Davi";
            Pessoa.idade = 22;
            Pessoa.endereco = "Rua Pascoal R. M.";

            Pessoa Pessoa2 = new Pessoa();
            Pessoa2.nome = "Gabriela";
            Pessoa2.idade = 21;
            Pessoa2.endereco = "Iguatemi";



            Animal Animal = new Animal();
            Animal.donoAnimal = "Davi";
            Animal.nomeAnimal = "Alfredo";
            Animal.idadeAnimal = 5;
            Animal.especieAnimal = "Cachorro";


            Animal Animal2 = new Animal();
            Animal2.donoAnimal = "Gabriela";
            Animal2.nomeAnimal = "Alfredo";
            Animal2.idadeAnimal = 5;
            Animal2.especieAnimal = "Cachorro";


            Console.WriteLine(Animal.nomeAnimal + Animal.donoAnimal);
        }
    }
}






