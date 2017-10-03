
using Interview_Exercise;

namespace Interview_Exercise_Tests.UnitTests
{
    class DummyData : IDummyData
    {
        private static Country dummyCountry = new Country("Usa", "United States");

        public Country Country
        {
            get { return dummyCountry; }
        }
    }
}
