namespace ExemploConstrutores.models
{
    public class Aluno: Pessoa
    {
    private string Disciplina; 
    public Aluno ( string nome, string sobrenome, string Disciplina): base (nome, sobrenome) 
    {
        this.Disciplina = Disciplina; 
        System.Console.WriteLine("Construtor classe aluno");}

    
    public override void Apresentar() {

        System.Console.WriteLine($"{nome}, {sobrenome}, {Disciplina}");
    }
    
    

    }

        }
        


        
    
