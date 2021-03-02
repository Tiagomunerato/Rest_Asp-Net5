
using System.Collections.Generic;

using RestApsNet.Model;

namespace RestApsNet.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindByID(long id);
        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);
        bool Exists(long id);



    }
}
