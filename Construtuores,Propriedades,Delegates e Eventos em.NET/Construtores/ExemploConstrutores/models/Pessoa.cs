namespace ExemploConstrutores.models
{
    public class Pessoa
    {
        public readonly string  nome = "Denis"; 
        public string sobrenome;

        // public  Pessoa () {
        //     nome = String.Empty;
        //     sobrenome = String.Empty;

        // }

        public Pessoa (string nome, string sobrenome) {
                this.nome = nome;
                this.sobrenome = sobrenome;
                
                System.Console.WriteLine("Construtor Classe Pessoa");

        }

        public virtual void Apresentar () {
            System.Console.WriteLine($"Olá meu nomé é {nome} {sobrenome}");

        }
        
    }
}