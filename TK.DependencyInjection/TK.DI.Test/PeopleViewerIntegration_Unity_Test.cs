using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK.DI.PeopleView.Presentation;
using TK.DI.PersonRepository.CachingDecorator;
using TK.DI.PersonRepository.CSV;
using TK.DI.PersonRepository.Interface;
using TK.DI.PersonRepository.Service;

namespace TK.DI.Test
{
    [TestClass]
    public class PeopleViewerIntegration_Unity_Test
    {
        IUnityContainer Container;

        //Unity DI container 
        [TestInitialize]
        public void Setup()
        {
            Container = new UnityContainer();
            Container.RegisterType<IPersonRepository, CSVRepository>(
                           new ContainerControlledLifetimeManager());
        }

        [TestMethod]
        public void LooseCoupling_GetPeopleByUseOfUnityContainer_People()
        {
            var viewModel = Container.Resolve<PeopleViewerViewModel>();

            var people = viewModel.People;

            Assert.IsNotNull(people);
        }
    }
}
