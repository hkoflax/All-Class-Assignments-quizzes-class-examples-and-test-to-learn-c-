using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace S5W6C1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName;
            string[] listOfFiles;
            Write("Enter a folder >> ");
            directoryName = ReadLine();
            if (Directory.Exists(directoryName))
            {
                WriteLine("Directory exists, and it contains the following:");
                listOfFiles = Directory.GetFiles(directoryName);
                for (int x = 0; x < listOfFiles.Length; ++x)
                {
                    Image newImage = Image.FromFile("SampImag.jpg");
                    WriteLine("   {0}", listOfFiles[x]);
                }
            }
            else
            {
                WriteLine("Directory does not exist");
            }
        }
    }
}
