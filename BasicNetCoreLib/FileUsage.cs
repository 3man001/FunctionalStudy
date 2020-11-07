using System.IO;

namespace BasicNetCoreLib
{
    public class FileUsage
    {
        private readonly string _file;
        private FileStream FileStream;
        private StreamReader StreamReader;
        private StreamWriter StreamWriter;

        FileUsage(string file)
        {
            _file = file;
        }

        public void Create()
        {
            File.Create(_file);
        }

        public bool Exist()
        {
            return File.Exists(_file);
        }

        public  void Delete()
        {
            File.Delete(_file);
        }

        public void Open()
        {
            FileStream = new FileStream(_file, FileMode.Open);
        }

        public void OpenRead()
        {
            FileStream = new FileStream(_file, FileMode.Open);
            StreamReader = new StreamReader(FileStream);
        }

        public void OpenWrite()
        {
            FileStream = new FileStream(_file, FileMode.Open);
            StreamWriter = new StreamWriter(FileStream);
        }

        public string ReadLine()
        {
            return StreamReader.ReadLine();
        }

        public void WriteLine(string str)
        {
            StreamWriter.WriteLine(str);
        }

        public void Close()
        {
            FileStream.Close();
        }
    }
}
