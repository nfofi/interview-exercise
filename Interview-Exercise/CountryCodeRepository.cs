
namespace Interview_Exercise
{
    public class CountryCodeRepository
    {
        private IDatabase _database;

        public CountryCodeRepository(IDatabase database)
        {
            _database = database;
        }

        public void Add(Country country)
        {         
           _database.Insert(country);
        }

        public void Update(Country country)
        {
            //call data access Update
        }

        public void Delete (string countryCode)
        {
            //call data access Remove 
        }

        public Country Get(string countryCode)
        {
            //call data access Read

            //this return exists to avoid compile errors
            return new Country();
        }

        public void Clear()
        {
            //call data access Clear
        }
    }
}
