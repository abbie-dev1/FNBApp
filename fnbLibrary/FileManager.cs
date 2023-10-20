using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace fnbLibrary
{
    public class FileManager
    {
        public void WriteToFile(string path, string data)
        {
            File.AppendAllText(path, data + "\n");
        }

        public string ReadFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
