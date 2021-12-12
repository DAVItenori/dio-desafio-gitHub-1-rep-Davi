namespace Global
{

    interface IPessoa
    {
        void nome(string nome);
        void idade(int idade);
        void endereco(string endereco);
        void statusCivil(string statusCivil);



    }

    class Pessoa : IPessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string endereco { get; set; }
        public string statusCivil { get; set; }

        public string Bairro { get; set; }

        void IPessoa.nome(string nome)
        {
            this.nome = nome;
        }

        void IPessoa.idade(int idade)
        {
            this.idade = idade;
        }

        void IPessoa.endereco(string endereco)
        {
            this.endereco = endereco;
        }

        void IPessoa.statusCivil(string statusCivil)
        {
            this.statusCivil = statusCivil;
        }

    }


}

