using System;

namespace Revisao
{
    class Program
    {

        static void Main(String[] args)
        {

            Aluno[] alunos = new Aluno[5];
            int indicealuno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {

                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();


                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Valor da nota deve ser decimal!");

                        }
                        alunos[indicealuno] = aluno;
                        indicealuno++;

                        break;


                    case "2":
                        //Utilizando "for"
                        // for (indicealuno = 0; indicealuno <=5; indicealuno++) {
                        // Console.WriteLine ($"Nome aluno: {alunos[indicealuno].Nome}, Nota: {alunos[indicealuno].Nota}");
                        // }

                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno {a.Nome}, Nota {a.Nota}");

                            }
                        }
                        break;


                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {

                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;

                            }

                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnum Conceito;

                        if (mediaGeral < 2)
                        {
                            Conceito = ConceitoEnum.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            Conceito = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            Conceito = ConceitoEnum.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            Conceito = ConceitoEnum.B;
                        }

                        else
                        
                        {
                            Conceito = ConceitoEnum.A;
                        }


                        
                        Console.WriteLine($"MEDIA GERAL {mediaGeral}, Conceito {Conceito}");
                            break;

                        default: 

                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();


            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - listar alunos");
            Console.WriteLine("3 - Calcular media");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }


    }
}


