
using System;

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
            try
            {
                _database.Insert(country);
            }

            catch (Exception ex)
            {
                throw new Exception("Error adding country: " + ex);
            }
        }

        public void Update(Country country)
        {
            try
            {
                _database.Update(country);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating country: " + ex);
            }
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
