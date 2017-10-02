using System;
using System.IO;

namespace Interview_Exercise
{
    class Database : IDatabase
    {
        public string getDataPath()
        {
            string dataPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),"Interview-Exercise");

            return dataPath;
        }
    }
}
