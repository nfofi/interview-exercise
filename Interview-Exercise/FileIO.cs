using System.IO;

namespace Interview_Exercise
{
    public class FileIO : IFileIO
    {
        public void WriteToFile(string path, string[] data)
        {
            File.AppendAllLines(path, data);
        }

        public void ReadFromFile()
        {
            
        }
    }
}
