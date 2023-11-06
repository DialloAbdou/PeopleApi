using AutoFixture;
using FluentAssertions;
using Moq;
using PeopleApi.Data;
using PeopleApi.Services;

namespace PeopleApiTest.Services
{
    public class PersonTest
    {
        private PersonService _personService;
        private Mock<IPersonRepository> personeRepoMock = new Mock<IPersonRepository>();
        private Fixture _fixture = new Fixture();
        public PersonTest()
        {
            _personService = new PersonService(personeRepoMock.Object);
        }

        [Fact]
        public async Task When_No_People_InDb_then_Empty_collection_Should_Be_Returned()
        {
            personeRepoMock.Setup(m=>m.GetAllAsync())
                .ReturnsAsync(new List<Person>());

            var result = await _personService.GetAllPerson();

            result.Should().BeEmpty();

        }

        [Fact]
        public async Task When__People_InDb_then_GetPersonById__Should_Be_Returned_Person()
        {
            // Assertion
            personeRepoMock.Setup(m => m.GetPersonAsync(It.IsAny<int>()))
                .ReturnsAsync(new Person { Id = 1, Nom = "Diallo", Prenom = "Abdou", DateNaissance = new DateTime(1980, 5, 6) });
            //Act
            var result = await _personService.GetPersonById(2);
            //Assertion
            result.Should().NotBeNull();
            result.Prenom.Should().Be("Abdou");
            result.Nom.Should().Be("Diallo");

            personeRepoMock.Verify(m=>m.GetPersonAsync(2), Times.Once());
        }

        [Fact]
        public async Task AddPerson_InDb_Should_Call_Rep()
        {
            // Assertion
            Person p = null;
            personeRepoMock.Setup(m => m.AddPersonAsync(It.IsAny<Person>()))
                .Callback((Person person) => p = person);

             var fixtureRandom = _fixture.Create<Person>();
            //Act
            await _personService.AddPersonAsync(fixtureRandom);
            //Assertion
            p.Should().NotBeNull();
            p!.Prenom.Should().Be(fixtureRandom.Prenom);
            p!.Nom.Should().Be(fixtureRandom.Nom);
      
        }
    }
}
