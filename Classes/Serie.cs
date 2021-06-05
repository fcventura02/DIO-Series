using System;
using DIO.Series.Enum;
namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero;
        private string Titulo;
        private string Descricao;
        private int Ano;

        private bool Excluido;

        public Serie()
        { }
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            // Enviroment
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;

            return retorno;
        }
        public string retornaTitulo()
        {
            return Titulo;
        }
        public int retornaId()
        {
            return Id;
        }

        public void Exclui()
        {
            Excluido = true;
        }

        public Boolean getExcluido(){
            return Excluido;
        }
    }
}