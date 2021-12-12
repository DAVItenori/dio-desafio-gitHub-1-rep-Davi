namespace Global2
{
    interface IAnimal
    {
        void nomeAnimal(string nomeAnimal);
        void idadeAnimal(int idadeAnimal);
        void donoAnimal(string donoAnimal);
        void especieAnimal(string especieAnimal);

    }

    class Animal : IAnimal
    {
        public string nomeAnimal;
        public int idadeAnimal { get; set; }
        public string donoAnimal;
        public string especieAnimal { get; set; }

   

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
    }

}