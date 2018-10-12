using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using static System.Console;
using MyPhotoLibrary;

namespace Practice_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName;
            string[] listOfFiles;
            string[] listOfdirectories;
            Write("Enter a folder or Q to quit >> ");
            directoryName = ReadLine();
            while (directoryName!="Q")
            {
                if (Directory.Exists(directoryName))
                {
                    WriteLine("Directory exists, and it contains the following:");
                    listOfFiles = Directory.GetFiles(directoryName);
                    listOfdirectories = Directory.GetDirectories(directoryName);
                    Console.WriteLine("In "+directoryName+" Folder");
                    PhotoSize.ResizeAll(listOfFiles);
                    for(int i=0;i<listOfdirectories.Length;i++)
                    {
                        string[] fileList = Directory.GetFiles(listOfdirectories[i]);
                        Console.WriteLine("In " + listOfdirectories[i] + " Folder");
                        PhotoSize.ResizeAll(fileList);
                    }
                    Write("Enter a folder or Q to quit>> ");
                    directoryName = ReadLine();
                }
                else
                {
                    WriteLine("Directory does not exist");
                    Write("Enter a folder or Q to quit>> ");
                    directoryName = ReadLine();
                } 
            }
        }

    }
}
