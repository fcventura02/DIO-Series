using System;
using DIO.Series.Interfaces;
using System.Collections.Generic;

namespace DIO.Series.Classes
{
    public class SerieRepositorios : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            //listaSerie.FindAll(serie => serie.getExcluido() != true);
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {   
            if(!listaSerie.Exists(item => item.retornaId() == id))
            {
                return null;
            }
           return listaSerie[id];
        }
    }
}