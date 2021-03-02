
using System.Collections.Generic;

using RestApsNet.Model;

namespace RestApsNet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindByID(long id);
        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);


    }
}
