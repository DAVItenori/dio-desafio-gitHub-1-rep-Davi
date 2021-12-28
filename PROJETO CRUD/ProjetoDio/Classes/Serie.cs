namespace ProjetoDio
{
    public class Serie: EntidadeBase
    {

        //Atributos 
        private Genero genero { get; set; }
        private String Titulo{ get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie (int id, Genero genero, string titulo, string Descricao, int ano) 
        {
            this.Id = id; 
            this.genero = genero; 
            this.Titulo = titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero = " + this.genero + Environment.NewLine;
            retorno += "Titulo = " + this.Titulo + Environment.NewLine;
            retorno += "Descricao =" + this.Descricao + Environment.NewLine;
            retorno += "Ano = " + this.Ano  + Environment.NewLine; 
            retorno += "Excluido = " + this.Excluido  + Environment.NewLine; 
            return retorno; 
        }

        public string RetornaTitulo ()
        {
        return this.Titulo;
        }

        public int RetornaID() 
        {
        return this.Id; 
        }
        public bool RetornaExcluido() 
        {
        return this.Excluido; 
        }

        public void Excluir() 
        {
            this.Excluido = true; 
        }
    }
}
