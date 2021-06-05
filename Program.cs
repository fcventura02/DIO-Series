using System;
using DIO.Series.Controller;

namespace DIO.Series
{
    class Program
    {
        //private SerieController controller = new SerieController();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoMenuUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        MenuSerie();
                        break;
                    case "2":
                        MenuFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Saindo... Até a proxima!");
                        break;
                    default: throw new ArgumentException("Opção informada não existe!");
                }
                opcaoUsuario = ObterOpcaoMenuUsuario();
            }
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar");
            Console.WriteLine("2- Inserir");
            Console.WriteLine("3- Atualizar");
            Console.WriteLine("4- Excluir");
            Console.WriteLine("5- Vizualizar");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoMenuUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Menu Série");
            Console.WriteLine("2- Menu Filme");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine();
            return opcaoUsuario;
        }
        private static void MenuSerie()
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                Console.WriteLine("Menu Série");
                switch (opcaoUsuario)
                {
                    case "1":
                        SerieController.ListarSerie();
                        break;
                    case "2":
                        SerieController.Insere();
                        break;
                    case "3":
                        SerieController.Atualizar();
                        break;
                    case "4":
                        SerieController.Excluir();
                        break;
                    case "5":
                        SerieController.RetornaPorId();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Voltando...");
                        break;
                    default: throw new ArgumentException("Opção informada não existe!");
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static void MenuFilme()
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                Console.WriteLine("Menu Série");
               /* switch (opcaoUsuario)
                {
                    case "1":
                        SerieController.ListarSerie();
                        break;
                    case "2":
                        SerieController.Insere();
                        break;
                    case "3":
                        SerieController.Atualizar();
                        break;
                    case "4":
                        SerieController.Excluir();
                        break;
                    case "5":
                        SerieController.RetornaPorId();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Voltando...");
                        break;
                    default: throw new ArgumentException("Opção informada não existe!");
                }*/
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
    }
}
