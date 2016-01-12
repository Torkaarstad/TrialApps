using System;
using System.Collections.Generic;
using System.Linq;
using TK.DI.PeopleService2;
using TK.DI.PersonRepository.Interface;
using TK.Shared;

namespace TK.DI.PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        //private PeopleService2.PeopleService2 _serviceProxy = null;

        private IPersonService _serviceProxy;
        public IPersonService ServiceProxy
        {
            get
            {
                if (_serviceProxy == null)
                    _serviceProxy = new PeopleService2.PeopleService2();
                return _serviceProxy;
            }
            set
            {
                if (_serviceProxy == value)
                    return;
                _serviceProxy = value;
            }
        }

        //public ServiceRepository()
        //{
        //    _serviceProxy = new PeopleService2.PeopleService2();
        //}
        public IEnumerable<Person> GetPeople()
        {
            Console.WriteLine("ServiceRepository.GetPeople()");
            return ServiceProxy.GetPeople();
        }

        public Person GetPerson(string lastName)
        {
            return ServiceProxy.GetPerson(lastName);
        }

        public void AddPerson(Person newPerson)
        {
            ServiceProxy.AddPerson(newPerson);
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            ServiceProxy.UpdatePerson(lastName, updatedPerson);
        }

        public void DeletePerson(string lastName)
        {
            ServiceProxy.DeletePerson(lastName);
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            ServiceProxy.UpdatePeople(updatedPeople.ToList());
        }
    }
}
