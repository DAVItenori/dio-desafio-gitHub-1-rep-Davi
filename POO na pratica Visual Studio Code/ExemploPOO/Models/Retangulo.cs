namespace ExemploPOO.Models
{
    public class Retangulo
    {
            private double Base { get; set;}
            private double Altura { get; set; }
            private bool valido;

            public void Medidas (double Base, double Altura) {

                if (Base > 0 && Altura > 0) {
                this.Base = Base;
                this.Altura = Altura;
                valido = true;
                }
                else {
                    System.Console.WriteLine("Defina medidas positivas!");
                }
            }
    
            public double DefinirArea() {
                
                if (valido) {

                 return Base * Altura;

                }
                else {
                        System.Console.WriteLine("Necessário valores validos!");
                        return 0;

                }
                }
            }
    }
