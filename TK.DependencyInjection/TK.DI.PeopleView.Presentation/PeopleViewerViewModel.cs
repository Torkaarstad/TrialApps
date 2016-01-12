using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TK.DI.PersonRepository.Interface;
using TK.Shared;

namespace TK.DI.PeopleView.Presentation
{
    //TK
    //Merk Dette prosjektet referer kun til IPersonRepository
    //Det er derfor lett å endre hvilket PersonRepository som skal benyttes

    public class PeopleViewerViewModel
    {
        protected IPersonRepository Repository;

        public IEnumerable<Person> People
        {
            get { return Repository.GetPeople(); }
        }

        //Constructor Injection
        public PeopleViewerViewModel(IPersonRepository repository)
        {
            Repository = repository;
        }
    }
}
