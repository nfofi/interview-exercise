
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
            //retrieve correct file path
            //check country code
            //if exists
            //throw exception
            //else
            //insert into CSV
        }

        public void Update(Country country)
        {
            //retrieve correct file path
            //check country code
            //if not exists
            //throw exception
            //else
            //update into CSV
        }

        public void Delete (string countryCode)
        {
            //retrieve correct file path
            //check country code
            //if not exists
            //throw exception
            //else
            //remove from CSV
        }

        public Country Get(string countryCode)
        {
            //retrieve correct file path
            //check country code
            //if not exists
            //throw exception
            //else
            //return country
            return new Country();
        }

        public void Clear()
        {
            //delete all files
        }
    }
}
