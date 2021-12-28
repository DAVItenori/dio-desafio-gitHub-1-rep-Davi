using System;

namespace ProjetoDio
{
    public class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = OpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie(); 
                        break;
                    case "4":
                        ExcluirSerie(); 
                        break;
                    case "5":
                        VisualizarSerie(); 
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();


                }

                opcaoUsuario = OpcaoUsuario();
            }
            System.Console.WriteLine("Obrigado por utilizar nossos Serviços");
            System.Console.ReadLine();
        }


        private static void ListarSeries()
        {

            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            
            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                System.Console.WriteLine("ID {0}: - {1} {2}", serie.RetornaID(), serie.RetornaTitulo(), (excluido ? "Excluido" : ""));
        
            }
                }
        
        public static void InserirSerie()
        {

            System.Console.WriteLine("Inserir Nova Série: ");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero), i));

            }
            System.Console.WriteLine("0 - Voltar ao menu anterior! ");

            System.Console.WriteLine("Digite o gênero entra as opções acime: ");

            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            Descricao: entradaDescricao);

            repositorio.Insere(novaSerie);

        }
        private static string OpcaoUsuario()
        {

            System.Console.WriteLine();
            System.Console.WriteLine("DIO Series a seu dispor!");
            System.Console.WriteLine("Informe a opção desejada!");
            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2 - Inserie nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar Tela");
            System.Console.WriteLine("x - sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        public static void AtualizarSerie() 
        {
            System.Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero), i));

            }

            System.Console.WriteLine("Digite o gênero entra as opções acime: ");

            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizarSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            Descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizarSerie);






        }
        public static void ExcluirSerie() 
        
        {
            System.Console.WriteLine("Digite o ID da série: ");
            int indiceExclusao = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceExclusao); 


        }

        public static void VisualizarSerie() 
        {
        System.Console.WriteLine("Digite o ID da Série: ");
        int indiceSerie = int.Parse(Console.ReadLine()); 
        var Serie = repositorio.RetornaID(indiceSerie); 

        System.Console.WriteLine(Serie);


        }
    }
}

