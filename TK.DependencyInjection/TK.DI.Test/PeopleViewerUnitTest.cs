using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TK.DI.PeopleService2;
using TK.DI.PeopleView.Presentation;
using TK.DI.PersonRepository.CachingDecorator;
using TK.DI.PersonRepository.CSV;
using TK.DI.PersonRepository.Interface;
using TK.DI.PersonRepository.Service;
using TK.Shared;

namespace TK.DI.Test
{
    [TestClass]
    public class PeopleViewerTest
    {
        IPersonRepository _repository;

        //Mocking 
        [TestInitialize]
        public void Setup()
        {
            var people = new List<Person>()
            {
                new Person() {FirstName = "John", LastName = "Smith",
                    Rating = 7, StartDate = new DateTime(2000, 10, 1)},
                new Person() {FirstName = "Mary", LastName = "Thomas",
                    Rating = 9, StartDate = new DateTime(1971, 7, 23)},
            };

            var repoMock = new Mock<IPersonRepository>();
            repoMock.Setup(r => r.GetPeople()).Returns(people);
            repoMock.Setup(r => r.GetPerson(It.IsAny<string>()))
                .Returns((string n) => people.FirstOrDefault(p => p.LastName == n));
            _repository = repoMock.Object;
        }

        [TestMethod]
        public void LooseCoupling_GetPeopleWithServiceRepo_People()
        {
            // Arrange
            var vm = new PeopleViewerViewModel(_repository);

            // Act
            var people = vm.People;

            // Assert
            Assert.IsNotNull(vm.People);
            Assert.AreEqual(2, vm.People.Count());
        }
    }
}
