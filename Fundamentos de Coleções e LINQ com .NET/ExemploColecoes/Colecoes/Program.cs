using System;
using Colecoes.helper;

namespace Colecoes
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] Arraynumeros = new int[10] { 1, 4, 8, 0, 15, 15, 19, 100, 100, 100 };

            var minimo = Arraynumeros.Min();
            var maximo = Arraynumeros.Max();
            var medio = Arraynumeros.Average();
            var Soma = Arraynumeros.Sum();
            var ArrayUnico = Arraynumeros.Distinct().ToArray();

            System.Console.WriteLine("Minimo {0}\n Maximo {1}\n Medio {2}\n Soma {3}", minimo, maximo, medio, Soma);
            System.Console.WriteLine("Array: " + String.Join(", ", Arraynumeros));
            System.Console.WriteLine("Array: " + String.Join(", ", ArrayUnico));



            // var numerosParesQuery = 
            //         from num in Arraynumeros
            //         where num % 2 == 0 
            //         orderby num
            //         select num;

            // var NumerosParesMetodo = Arraynumeros.Where( x =>x % 2 == 0).OrderBy(x => x ).ToList();
            // System.Console.WriteLine("Numeros Pares Query " + String.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Numeros Pares Método " + String.Join(" ,",NumerosParesMetodo));



            // Dictionary<string, string> dicionario = new Dictionary<string, string>();
            // dicionario.Add("SP", "São Paulo");
            // dicionario.Add("MT", "Mato Grosso");
            // dicionario.Add("MG", "Minas Gerais");

            // foreach (KeyValuePair<string, string> item in dicionario)
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key},Valor: {item.Value}");
            // }

            // string ValorProcurado = "SC";

            // // var teste = dicionario["SC"];
            // if (dicionario.TryGetValue(ValorProcurado, out string estadoEncontrado)) 
            // {
            //         System.Console.WriteLine($"{estadoEncontrado} Existe!");


            // }
            // else {

            // System.Console.WriteLine($"{ValorProcurado} Não foi encontrado!");

            // }


            // System.Console.WriteLine("\nREMOVENDO O VALOR {0}",ValorProcurado);

            // dicionario.Remove(ValorProcurado); 

            //   foreach (KeyValuePair<string, string> item in dicionario)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key},Valor: {item.Value}");
            // }

            // System.Console.WriteLine("\nValor Original");
            // System.Console.WriteLine($"Estado: {dicionario[ValorProcurado]} \n");

            // dicionario[ValorProcurado] = "MG - Teste de Validação"; 

            // System.Console.WriteLine("Valor alterado");
            // System.Console.WriteLine($"Estado: {dicionario[ValorProcurado]} \n");



            // STACK PILHA
            // Stack<string> Stack = new Stack<string>(); 
            // Stack.Push("DDD");
            // Stack.Push("CODIGO LIMPO");
            // Stack.Push(".NET"); 

            // System.Console.WriteLine($"Livros para a leitura {Stack.Count}");
            // while (Stack.Count > 0)
            // {
            //         System.Console.WriteLine($"Proximo livro para a leitura: {Stack.Peek()}");
            //         System.Console.WriteLine($"{Stack.Pop()} Lido com sucesso!");


            // }
            //             System.Console.WriteLine(Stack.Count);


            //FILA queue

            // Queue<string> FILA = new Queue<string>();
            // FILA.Enqueue("Davi"); 
            // FILA.Enqueue("Monique"); 
            // FILA.Enqueue("Cida");

            // while (FILA.Count > 0) 
            // {
            //     System.Console.WriteLine($"Vez de {FILA.Peek()}");
            //     System.Console.WriteLine($"{FILA.Dequeue()} Atendido");

            // }
            // System.Console.WriteLine($"Pessoas na fila {FILA.Count}");

            // OperacoesLista opLista  = new OperacoesLista();
            // List<string> estados = new List<string>(); 
            // string[] ArrayEstados = new string[2] {"SC", "MT"};

            // estados.Add("MG"); 
            // estados.Add("SP"); 
            // estados.Add("ES"); 
            // estados.Add("PR"); 
            // estados.Add("BH"); 
            // estados.Add("AC"); 


            // estados.AddRange(ArrayEstados); 
            // estados.Insert(0, "RJ"); 
            // opLista.ImprimirListaDeString(estados); 

            // estados.Remove("MG"); 

            // opLista.ImprimirListaDeString(estados); 



            // OpeacoesArray op = new OpeacoesArray(); 

            // int[] vetor = new int[6] {6, 2 , 0 , 3 , 5 , 4}; 
            // int[] vetorCopia = new int[10]; 
            // int valordesejado = 0;
            // string[] arraystring = op.AlterarArray(vetor);


            // string[] novaarray = new string[] {"Davi,Palmeira", "Davi,Tenorio"};
            // op.ImprimirString(novaarray);

            // System.Console.WriteLine($"Capacidade atual do array {vetor.Length}");

            // op.RedimencionarArray(ref vetor, vetor.Length * 2);
            // System.Console.WriteLine($"Nova capacidade {vetor.Length}");
            // op.ImprimirArray(vetor);


            // int ProcurarIndex = op.ProcurarIndex(vetor, valordesejado);
            // if (ProcurarIndex >0)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é {1}",valordesejado, ProcurarIndex);


            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrado!");


            // }

            // int ProcurarValor = op.EncontrarValor(vetor, valordesejado); 
            // if (ProcurarValor == valordesejado) 
            // {
            //     System.Console.WriteLine("Valor Encontrado!");
            // }
            // else 
            // {
            //     System.Console.WriteLine("Valor não encontrado!");

            // }


            // bool TodosMaiorQue = op.Maiorque(vetor, valordesejado);

            // if (TodosMaiorQue) 
            // {
            //     System.Console.WriteLine("Todos Maiores que {0}",valordesejado);



            // }
            // else 
            // {
            //     System.Console.WriteLine("Nem todos são maiores que {0}",valordesejado);


            // }



            //MÉtodo para ver se existe dentro do vetor! 
            // bool Existe = op.Existe(vetor, valordesejado);

            // if (Existe) 
            // {
            //     System.Console.WriteLine("O item {0} existe!", valordesejado);


            // } 
            // else 
            // {
            //     System.Console.WriteLine("O item {0} não existe!", valordesejado);

            // }



            // System.Console.WriteLine("Vetor antes da copia");
            // op.ImprimirArray(vetorCopia);
            // op.CopiarArray(vetor, vetorCopia); 
            // op.ImprimirArray(vetorCopia);


            // System.Console.WriteLine("Imprimindo valores:");
            // op.ImprimirArray(vetor); 

            // System.Console.WriteLine("Ordenando valores");
            //op.OrdenarArraybUBBLEshort(ref vetor);

            // op.Ordenar(ref vetor);
            // op.ImprimirArray(vetor); 






            // int[,] matriz = new int[4,2] 
            // {
            //     {8, 2},
            //     {10, 20},
            //     {13, 14},
            //     {15, 20}

            // };
            //     for (int i = 0; i <matriz.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < matriz.GetLength(1); j++)
            //         {
            //             System.Console.WriteLine(matriz[i,j]);
            //         }
            //     }


            // int[] array = new int[] {10, 20, 30 , 40 , 50, 60 , 70}; 
            // int[,] matriz = new int[4,2];

            // System.Console.WriteLine("FOR");
            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);
            // }
            // System.Console.WriteLine("Foreach");
            // foreach (int item in array)
            // {
            //     System.Console.WriteLine(item);
            // }


            // System.Console.WriteLine(array[1]);
            // System.Console.WriteLine(matriz[1,1]);



        }
    }
}



