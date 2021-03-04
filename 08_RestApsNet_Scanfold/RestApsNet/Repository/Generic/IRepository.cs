using RestApsNet.Model.Base;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    // Tipo Genérico T extends Base entity//
    // T é um tipo generico//
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        T FindByID(long id);
        List<T> FindAll();
        void Delete(long id);
        bool Exists(long id);
    }
}
