using Colecoes;

namespace Colecoes.helper
{
    public class OperacoesLista
    {
        public void ImprimirListaDeString (List<string> lista ) {

            for (int i = 0; i < lista.Count ;i++)     
                {
                        System.Console.WriteLine("Indice {0} , Valor {1}",i, lista[i]);
                    }

        }

        }
          
        
    }
