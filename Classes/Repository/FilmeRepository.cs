using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class FilmeRepository: IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();

        public void Atualiza(int id, Filme entidade)
        {
            listaFilme[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaFilme[id].Exclui();
        }

        public void Insere(Filme entidade)
        {
            listaFilme.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return listaFilme.FindAll(Filme => Filme.getExcluido() != true);;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {   
            if(!listaFilme.Exists(item => item.retornaId() == id))
            {
                return null;
            }
           return listaFilme[id];
        }
    }
}