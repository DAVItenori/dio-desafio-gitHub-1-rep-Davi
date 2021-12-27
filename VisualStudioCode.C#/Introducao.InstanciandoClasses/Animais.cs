namespace Global2
{
    interface IAnimal
    {
        void nomeAnimal(string nomeAnimal);
        void idadeAnimal(int idadeAnimal);
        void donoAnimal(string donoAnimal);
        void especieAnimal(string especieAnimal);

    }

    public class Animal: IAnimal 
    {
        private string nomeAnimal {get; set;}
        private int idadeAnimal { get; set; }
        private string donoAnimal { get; set; }
        private string especieAnimal { get; set;}

        void IAnimal.nomeAnimal(string nomeAnimal)
        {
            this.nomeAnimal = nomeAnimal;
        }
        void IAnimal.idadeAnimal(int idadeAnimal)
        {
            this.idadeAnimal = idadeAnimal;

        }
        void IAnimal.donoAnimal(string donoAnimal)
        {
            this.donoAnimal = donoAnimal;
        }

        void IAnimal.especieAnimal(string especieAnimal)
        {
            this.especieAnimal = especieAnimal;
        }
    

    public void SelecionarCaracteristicas(string nome, string nomedono, int idade ) 
    {
        this.nomeAnimal = nome; 
        this.donoAnimal = nomedono;
        this.idadeAnimal = idade;
    }

    public void ImprimirCaracteristicas() 
    {
        System.Console.WriteLine(nomeAnimal);
        System.Console.WriteLine(donoAnimal);
        System.Console.WriteLine(idadeAnimal);

    }


}
}