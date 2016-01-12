using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK.DI.PeopleView.Presentation;
using TK.DI.PersonRepository.CachingDecorator;
using TK.DI.PersonRepository.CSV;
using TK.DI.PersonRepository.Service;

namespace TK.DI.Test
{
    [TestClass]
    public class PeopleViewerIntegrationTest
    {
        //Constructor Injection
        [TestMethod]
        public void LooseCoupling_GetPeopleWithServiceRepo_People()
        {
            var repository = new ServiceRepository();
            var viewModel = new PeopleViewerViewModel(repository);

            var people = viewModel.People;

            Assert.IsNotNull(people);
        }

        [TestMethod]
        public void LooseCoupling_GetPeopleWithCSV_People()
        {
            var repository = new CSVRepository();
            var viewModel = new PeopleViewerViewModel(repository);

            var people = viewModel.People;

            Assert.IsNotNull(people);
        }

        [TestMethod]
        public void LooseCoupling_GetPeopleWithCaching_People()
        {
            var wrappedRepository = new ServiceRepository();
            var repository = new CachingRepository(wrappedRepository);
            var viewModel = new PeopleViewerViewModel(repository);

            var people = viewModel.People;

            Assert.IsNotNull(people);
        }


    }
}
