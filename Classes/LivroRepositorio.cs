using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class LivroRepositorio : IRepositorioL<Livro>
    {
			private List<Livro> listaLivro = new List<Livro>();
        public void AtualizaL(int id, Livro objeto)
        {
            listaLivro[id] = objeto;
        }

        public void ExcluiL(int id)
        {
            listaLivro[id].Excluir();
        }

        public void InsereL(Livro objeto)
        {
            listaLivro.Add(objeto);	
        }

        public List<Livro> ListaL()
        {
            return listaLivro;
        }

        public int ProximoIdL()
        {
            return listaLivro.Count;
        }

        public Livro RetornaPorIdL(int id)
        {
            return listaLivro[id];
        }
    }
}