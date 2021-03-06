using System;
using DIO.Series.Classes;

namespace DIO.Series.Controller
{
    public static class SerieController
    {
        static SerieRepositorios repositorio = new SerieRepositorios();

        public static void ListarSerie()
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
        public static void Insere()
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
        public static void Excluir()
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
        public static void Atualizar()
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
        public static void RetornaPorId()
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
    }
}