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

        public class WhenTryingToAddACountryThatAlreadyExists : TestFixtureBase
        {
            //this would test if the appropriate exception was thrown if adding an existing country
        }

        public class WhenUpdatingAnExistingCountry : TestFixtureBase
        {
            private IDatabase _database;
            private Country _country;

            protected override void Arrange()
            {
                _country = new Country("USA", "United States");

                _database = Mock<IDatabase>();
                _database.Expect(x => x.Update(_country));
            }

            protected override void Act()
            {
                var testRepo = new CountryCodeRepository(_database);
                testRepo.Update(_country);
            }

            [Test]
            public void Should_have_used_the_dependency()
            {
                _database.AssertWasCalled(x => x.Update(_country), y => y.Repeat.Once());
            }
        }

        public class WhenUpdatingACountryThatDoesNotExist : TestFixtureBase
        {
            //expectation: throw exception
        }

        public class WhenDeletingAnExistingCountry : TestFixtureBase
        {
            //expectation: Database Remove was called
        }

        public class WhenDeletingACountryThatDoesNotExist : TestFixtureBase
        {
            //expectation: throw exception
        }

        public class WhenGettingAnExistingCountry : TestFixtureBase
        {
            //expectation: Database Read was called
        }

        public class WhenGettingACountryThatDoesNotExist : TestFixtureBase
        {
            //expectation: throw exception
        }

        public class WhenClearingARepo : TestFixtureBase
        {
            //expectation: Database Clear was called
        }

        public class WhenClearingAnEmptyRepo : TestFixtureBase
        {
            //expectation: Database Clear was called
        }

    }
}