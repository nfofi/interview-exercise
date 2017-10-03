using NUnit.Framework;
using Rhino.Mocks;
using Interview_Exercise;

namespace Interview_Exercise_Tests.UnitTests
{
    public class CountryCodeRepositoryTest
    {
        public class WhenAddingANewCountryToTheRepo: TestFixtureBase
        {
            private IDatabase _database;
            private Country _country;

            protected override void Arrange()
            {
                _country = new Country("USA", "United States");

                _database = Mock<IDatabase>();
                _database.Expect(x => x.Insert(_country));
            }

            protected override void Act()
            {
                var testRepo = new CountryCodeRepository(_database);
                testRepo.Add(_country);
            }

            [Test]
            public void Should_have_used_the_dependency()
            {
                _database.AssertWasCalled(x => x.Insert(_country), y => y.Repeat.Once());
            }
        }
    }
}