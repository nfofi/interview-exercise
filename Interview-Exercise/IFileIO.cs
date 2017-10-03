namespace Interview_Exercise
{
    public interface IFileIO
    {
        void WriteToFile(string path, string[] data);

        void ReadFromFile();
    }
}
