using System;
using NUnit.Framework;
using Rhino.Mocks;
using Interview_Exercise;

namespace Interview_Exercise_Tests.UnitTests
{
    class DatabaseTest
    {
        public class When_checking_a_country_that_does_not_already_exist : TestFixtureBase
        {
            private bool _actualResult;

            protected override void Act()
            {
                _actualResult = new Database().Exists("USA");
            }

            [Test]
            public void Should_return_false()
            {
                Assert.That(_actualResult, Is.False);
            }
        }

        public class When_checking_a_country_that_already_exists : TestFixtureBase
        {
            
        }


        //This test only existed to see if my implementation actually wrote the correct data to a file. It does.

        //public class When_inserting_new_country_to_DB : TestFixtureBase
        //{
        //    private bool _actualResult;
        //    private Country _country;

        //    protected override void Act()
        //    {
        //        _country = new Country("Usa", "United States");
        //        new Database().Insert(_country);
        //        _actualResult = true;
        //    }

        //    [Test]
        //    public void Should_executed_with_success()
        //    {
        //        Assert.That(_actualResult, Is.True);
        //    }
        //}
    }
}
