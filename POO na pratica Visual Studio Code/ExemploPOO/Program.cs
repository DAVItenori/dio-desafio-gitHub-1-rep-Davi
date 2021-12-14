using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.Collections.Generic;

namespace Principal
{
    class Pessoa
    {

        static void Main(String[] args)
        {

            var caminho = "C:\\projetoGit\\dio-desafio-gitHub-1-rep-Davi\\Programando com orientacao a objeto";

            //Sempre alterar o PathCombine para o caminho desejado!
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt"); 
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt"); 
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt"); 
            var listaString = new List <string> {"Lista 1", "Lista 2 ", "Lista 3"};
            var listaStringContinuacao = new List <string> {"Lista 4", "Lista 5", "Lista 6"}; 
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-teste-stream.txt"); 

            
            fileHelper helper = new fileHelper();

            helper.DeletarArquivo(caminhoArquivoTesteCopia); 

            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false); 
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo); 
            // helper.LerArquivoStream(caminhoArquivo); 


            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString); 
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);

            // helper.CriarArquivoTexto(caminhoArquivo, "Olá, teste de escrita de arquivo! "); 
            //helper.ApagarDiretorio(caminhoPathCombine, true); 
            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);


            // var calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir);



            //Exemplo Herança System
            // Computador c1 = new Computador(); 
            // System.Console.WriteLine(c1.ToString());





            // Exemplo METODOS ABSTRATOS
            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();


            // Polimorfismo EarlyBiding
            // Calculadora c1 = new Calculadora();
            // System.Console.WriteLine($"Resultado da primeira soma{c1.Somar(1,2)}");
            // System.Console.WriteLine($"Resultado da primeira soma{c1.Somar(1,2,3)}");





            // Aluno a1 = new Aluno();
            // a1.Nome = "Davi";
            // a1.Nota = 10;
            // a1.Apresentar();

            // Professor P1 = new Professor();
            // P1.Nome = "Einstein";
            // P1.Salario = 12.000;
            // P1.Apresentar();


            //Instanciando Pessoa
            // Pessoas pessoa1 = new Pessoas();
            // pessoa1.Nome = "Davi";
            // pessoa1.Idade = 22; 
            // pessoa1.Apresentar();

            //Exemplo Retangulo:
            // Retangulo retangulo1 = new Retangulo();
            // retangulo1.Medidas(-1, -10);

            // System.Console.WriteLine($"Área do retangulo: {retangulo1.DefinirArea()}");



        }
    }
}



