using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace S5W6C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;
            Write("Enter a filename >> ");
            fileName = ReadLine();
            if (File.Exists(fileName))
            {
                WriteLine("File exists");
                WriteLine("File was created " +
                   File.GetCreationTime(fileName));
                WriteLine("File was last accessed " +
                   File.GetLastAccessTime(fileName));
                WriteLine("File was last written to " +
                   File.GetLastWriteTime(fileName));
            }
            else
            {
                WriteLine("File does not exist");
            }
        }
    }
}
