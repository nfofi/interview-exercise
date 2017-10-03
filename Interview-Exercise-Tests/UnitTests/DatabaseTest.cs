﻿using System;
using NUnit.Framework;
using Rhino.Mocks;
using Interview_Exercise;

namespace Interview_Exercise_Tests.UnitTests
{
    class DatabaseTest
    {
        public class WhenCheckingACountryThatDoesNotAlreadyExist : TestFixtureBase
        {
            private bool _actualResult;
            private Country _country;

            protected override void Arrange()
            {
                _country = new DummyData().Country;
            }

            protected override void Act()
            {
                _actualResult = new Database().Exists(_country.Code);
            }

            [Test]
            public void Should_return_false()
            {
                Assert.That(_actualResult, Is.False);
            }
        }

        public class WhenCheckingACountryThatAlreadyExists : TestFixtureBase
        {
            //would check against DummyData to return true if Exists had full implementation
        }


        //for remaining cases, give appropriate DummyData so we're not testing Exists
        public class WhenTryingToInsertANewCountry : TestFixtureBase
        {
            
        }

        public class WhenTryingToInsertAnExistingCountry : TestFixtureBase
        {
            
        }

        public class WhenTryingToUpdateAnExistingCountry : TestFixtureBase
        {
            
        }

        public class WhenTryingToUpdateANonExistingCountry : TestFixtureBase
        {

        }

        public class WhenTryingToRemoveAnExistingCountry : TestFixtureBase
        {

        }

        public class WhenTryingToRemoveANonExistingCountry : TestFixtureBase
        {

        }

        public class WhenTryingToReadAnExistingCountry : TestFixtureBase
        {

        }

        public class WhenTryingToReadANonExistingCountry : TestFixtureBase
        {

        }

        public class WhenClearingARepoWithOneOrMoreFiles : TestFixtureBase
        {
            
        }

        public class WhenClearingAnEmptyRepo : TestFixtureBase
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
