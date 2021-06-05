using System;
using DIO.Series.Classes;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorios repositorio = new SerieRepositorios();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        Insere();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        RetornaPorId();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default: throw new ArgumentException("Opção informada não existe!");
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ListarSerie()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nemhuma série cadastrada");
                return;
            }

            foreach (var item in lista)
            {
                Console.WriteLine("#ID {0} - {1} {2}", item.retornaId(), item.retornaTitulo(), item.getExcluido() ? "- Excluido" : "");
            }
        }
        private static void Insere()
        {
            Console.WriteLine("Inserir Série");
            foreach (int item in System.Enum.GetValues(typeof(Enum.Genero)))
            {
                Console.WriteLine("{0} - {1}", item, System.Enum.GetName(typeof(Enum.Genero), item));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da série: ");
            string entradaDescicao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(), (Enum.Genero)entradaGenero, entradaTitulo, entradaDescicao, entradaAno);
            repositorio.Insere(novaSerie);
        }
        private static void Excluir()
        {
            Console.WriteLine("Excluir Série");
            Console.WriteLine("Insira o ID da Série para ser excluída");
            int id = int.Parse(Console.ReadLine());
            Serie serie = repositorio.RetornaPorId(id);
            if (serie == null)
            {
                Console.WriteLine("Série não encontrada");
                return;
            }
            if (serie.getExcluido())
            {
                Console.WriteLine("Série já foi excluída");
                return;
            }
            repositorio.Excluir(id);

        }
        private static void Atualizar()
        {

            Console.WriteLine("Atualizar Série");
            Console.WriteLine("Insira o ID da Série para ser Atualizada");
            int id = int.Parse(Console.ReadLine());
            Serie serie = repositorio.RetornaPorId(id);
            if (serie == null)
            {
                Console.WriteLine("Série não encontrada");
                return;
            }
            foreach (int item in System.Enum.GetValues(typeof(Enum.Genero)))
            {
                Console.WriteLine("{0} - {1}", item, System.Enum.GetName(typeof(Enum.Genero), item));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da série: ");
            string entradaDescicao = Console.ReadLine();

            serie = new Serie(id, (Enum.Genero)entradaGenero, entradaTitulo, entradaDescicao, entradaAno);
            repositorio.Atualiza(id, serie);
        }
        private static void RetornaPorId()
        {
            Console.WriteLine("Selecione uma série");
            Console.WriteLine("Insira o ID da Série para ser apresentada");
            int id = int.Parse(Console.ReadLine());
            Serie serie = repositorio.RetornaPorId(id);
            if (serie == null)
            {
                Console.WriteLine("Série não encontrada");
                return;
            }
            Console.WriteLine(serie.ToString());

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Vizualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
