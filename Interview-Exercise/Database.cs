using System;
using System.IO;

namespace Interview_Exercise
{
    public class Database : IDatabase
    {
        private string dataPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Interview-Exercise");

        public bool Exists(string countryCode)
        {
            //check to see if country already exists in the repo
            //open file with name countryCode[0].csv in data path
            //check lines for countryCode
            //(this method is specific to Database.cs because another storage system (e.g. an actual database) might not need this check.)

            //returning false automatically for the sake of Add implementation
            return false;
        }

        #region IDatabase Implementation

        public void Insert(Country country)
        {
            if (!Exists(country.Code))
            {
                string file = dataPath + "\\" + country.Code[0] + ".csv";
                string[] lines = {country.Code + "," + country.Name};
                File.AppendAllLines(file, lines);
            }
            else
            {
                throw new Exception("Country already exists in repository.");
            }
        }

        public void Update(Country country)
        {
            
        }

        public void Remove(string code)
        {
            
        }

        public void Read(string code)
        {
            
        }

        public void Clear()
        {
            
        }

        #endregion
    }
}
