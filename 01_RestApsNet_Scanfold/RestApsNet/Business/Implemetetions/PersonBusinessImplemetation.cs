using RestApsNet.Model;
using RestApsNet.Model.Context;
using RestApsNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestApsNet.Business.Implemetetions
{
    public class PersonBusinessImplemetation : IPersonBusiness
    {

        private readonly IPersonRepository _repository;

        public PersonBusinessImplemetation(IPersonRepository repository)
        {
            _repository = repository;

        }


        public List<Person> FindAll()
        {

            return _repository.FindAll();
        }


        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }


        public Person Create(Person person)
        {
            
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
             _repository.Delete(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);

        }

      
    }
}
