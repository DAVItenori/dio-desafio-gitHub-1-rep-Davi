using System; 
using ExemploConstrutores.models; 

namespace ExemploConstrutores{ 

        class Program {

           public delegate void Operacao(int x, int y); 

            static void Main (string[] args ) {


                matematica m1 = new matematica(10,20);
                m1.Somar(); 


                //Delegate:
                    // Operacao op = new Operacao(Calculadora.Somar); 
                    // //Operacao op = Calculadora.Somar; 

                    // //ADICIONAR MAIS METODOS MULTCAST
                    // op += Calculadora.Subtrair; 
                    // op.Invoke(10, 20); 
                    // //op(10,20);
                    

                //  double pi = 3.14; 
                //  System.Console.WriteLine(pi);
        

                
                
                
                // Data data = new Data();
                // data.Mes = 12; 
             // data.ApresentarMes(); 




            // Aluno a1  = new Aluno("Davi", "Palmeira", "Matemática"); 
            // a1.Apresentar(); 

            // LOG: Instanciar uma só vês para utilizar em diversas classes. 
            //    var log = Log.GetInstance();  

            //    log.PropriedadeLog = "Teste Instancia"; 

            //    Log log2 = Log.GetInstance();
              //    System.Console.WriteLine(log2.PropriedadeLog);
                
                // Console.WriteLine("Hello, World!");
                // Pessoa p1 = new Pessoa("Gustavo", "Almeida");
                // Pessoa p2 = new Pessoa();
                // p2.nome = "Davi"; 
                // p2.sobrenome = "Palmeira"; 
                // p1.Apresentar();
                // p2.Apresentar(); 

                
            }

        }
}
