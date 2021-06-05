using System;
using DIO.Series.Classes;

namespace DIO.Series.Controller
{
    public static class FilmeController
    {
        static FilmeRepository repositorio = new FilmeRepository();

        public static void ListarSerie()
        {
            Console.WriteLine("Listar filmes");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nemhum filme cadastrada");
                return;
            }

            foreach (var item in lista)
            {
                Console.WriteLine("#ID {0} - {1} {2}", item.retornaId(), item.retornaTitulo(), item.getExcluido() ? "- Excluido" : "");
            }
        }
        public static void Insere()
        {
            Console.WriteLine("Inserir filme");
            foreach (int item in System.Enum.GetValues(typeof(Enum.Genero)))
            {
                Console.WriteLine("{0} - {1}", item, System.Enum.GetName(typeof(Enum.Genero), item));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titulo da filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano de início da filme: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da filme: ");
            string entradaDescicao = Console.ReadLine();

            Filme novaFilme = new Filme(id: repositorio.ProximoId(), (Enum.Genero)entradaGenero, entradaTitulo, entradaDescicao, entradaAno);
            repositorio.Insere(novaFilme);
        }
        public static void Excluir()
        {
            Console.WriteLine("Excluir filme");
            Console.WriteLine("Insira o ID da filme para ser excluída");
            int id = int.Parse(Console.ReadLine());
            Filme filme = repositorio.RetornaPorId(id);
            if (filme == null)
            {
                Console.WriteLine("Filme não encontrada");
                return;
            }
            if (filme.getExcluido())
            {
                Console.WriteLine("Filme já foi excluído");
                return;
            }
            repositorio.Excluir(id);

        }
        public static void Atualizar()
        {

            Console.WriteLine("Atualizar filme");
            Console.WriteLine("Insira o ID da filme para ser Atualizada");
            int id = int.Parse(Console.ReadLine());
            Filme filme = repositorio.RetornaPorId(id);
            if (filme == null)
            {
                Console.WriteLine("filme não encontrada");
                return;
            }
            foreach (int item in System.Enum.GetValues(typeof(Enum.Genero)))
            {
                Console.WriteLine("{0} - {1}", item, System.Enum.GetName(typeof(Enum.Genero), item));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titulo da filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o ano de início da filme: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a descrição da filme: ");
            string entradaDescicao = Console.ReadLine();

            filme = new Filme(id, (Enum.Genero)entradaGenero, entradaTitulo, entradaDescicao, entradaAno);
            repositorio.Atualiza(id, filme);
        }
        public static void RetornaPorId()
        {
            Console.WriteLine("Selecione uma filme");
            Console.WriteLine("Insira o ID da filme para ser apresentada");
            int id = int.Parse(Console.ReadLine());
            Filme filme = repositorio.RetornaPorId(id);
            if (filme == null)
            {
                Console.WriteLine("filme não encontrada");
                return;
            }
            Console.WriteLine(filme.ToString());

        }
    }
}