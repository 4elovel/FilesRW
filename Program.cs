using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FilesRW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "file.txt";
            Console.WriteLine("Write text that you want to append:");
            string text = Console.ReadLine();
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
