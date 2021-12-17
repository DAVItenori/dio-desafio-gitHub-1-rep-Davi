namespace ExemploConstrutores.models
{
    public class Data
    {
        private int mes; 
        private bool mesValido;

        public int Mes 
        { 
        get 
        { 
            return this.mes; 
        }
        set 
        {
            if (value >0 && value <= 12) {
                this.mes = value;
                mesValido = true; 
                }
        }
        }

        public void SetMes(int mes) { 
            if (mes > 0 && mes <= 12) {

                this.mes = mes; 
                mesValido = true;
            }
        }

        public void ApresentarMes() {
                if (mesValido == true) {

                    System.Console.WriteLine(mes);
                }
                else 
                {
                    System.Console.WriteLine("Insira um número válido");

                }


        }

        }
    }
