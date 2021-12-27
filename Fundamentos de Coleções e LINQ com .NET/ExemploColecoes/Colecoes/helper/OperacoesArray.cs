namespace Colecoes.helper
{
    class OpeacoesArray
    {

        public void OrdenarArraybUBBLEshort(ref int[] array) {

            int helper = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1]) {
                        helper = array[j + 1];
                        array[j + 1] = array[j]; 
                        array[j] = helper; 


                    }
                }
            }

        }
        public void ImprimirArray(int[] array) {

            var linha = string.Join(" ,", array);
            System.Console.WriteLine(linha);
            }

            public void ImprimirString(string[] lista)
            {
            var linha = string.Join(" ",lista);
            System.Console.WriteLine(linha);


            }
        

        public void Ordenar(ref int[] array) {
            
            Array.Sort(array); 



        }

        public void CopiarArray(int[] array, int[] arrayDestino)
        {
                Array.Copy(array, arrayDestino, array.Length); 
                System.Console.WriteLine("Array Copiado! ");


        }

        public void CopiarString(string[] lista1, string[] listadestino)
        {
            Array.Copy(lista1, listadestino,lista1.Length);


        }

        public bool  Existe(int[] array, int valor) 
        {
            return Array.Exists(array,elemento => elemento == valor); 



        }

        public bool Maiorque(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor); 

        }

        public int EncontrarValor(int[] array, int valor) 
        {
            return Array.Find(array,elemento => elemento == valor);

        }

        public int ProcurarIndex(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);  

        }

        public void RedimencionarArray (ref int[] array, int novoTamanho) 
        {
            Array.Resize(ref array, novoTamanho);

        }

        public string[] AlterarArray (int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    
    }
}