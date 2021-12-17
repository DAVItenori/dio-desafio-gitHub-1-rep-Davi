namespace ExemploConstrutores.models
{
    public class matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public matematica(int x, int y)
        {
            X = x;
            Y = y;
            Calculadora.EventoCalculadora += EventHandlee;

        }
        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandlee()
        {

            System.Console.WriteLine("Metodo Executado");
        }
    }
}