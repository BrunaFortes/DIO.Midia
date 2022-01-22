 using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class JogoRepositorio : IRepositorioJ<Jogo>
    {
			private List<Jogo> listaJogo = new List<Jogo>();
        public void AtualizaJ(int id, Jogo objeto)
        {
            listaJogo[id] = objeto;
        }

        public void ExcluiJ(int id)
        {
            listaJogo[id].Excluir();
        }

        public void InsereJ(Jogo objeto)
        {
            listaJogo.Add(objeto);	
        }

        public List<Jogo> ListaJ()
        {
            return listaJogo;
        }

        public int ProximoIdJ()
        {
            return listaJogo.Count;
        }

        public Jogo RetornaPorIdJ(int id)
        {
            return listaJogo[id];
        }
    }
}