using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
    public interface IRepositorioF<F>
    {
        List<F> ListaF();
        F RetornaPorIdF(int id);        
        void InsereF(F entidade);        
        void ExcluiF(int id);        
        void AtualizaF(int id, F entidade);
        int ProximoIdF();
    }
     public interface IRepositorioL<L>
    {
        List<L> ListaL();
        L RetornaPorIdL(int id);        
        void InsereL(L entidade);        
        void ExcluiL(int id);        
        void AtualizaL(int id, L entidade);
        int ProximoIdL();
    }
     public interface IRepositorioJ<J>
    {
        List<J> ListaJ();
        J RetornaPorIdJ(int id);        
        void InsereJ(J entidade);        
        void ExcluiJ(int id);        
        void AtualizaJ(int id, J entidade);
        int ProximoIdJ();
    }
}