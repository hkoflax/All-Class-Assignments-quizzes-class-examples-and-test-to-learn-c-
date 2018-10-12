using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BHounkpe_300769037_T1
{
    class Shipment
    {
        private string destination;
        private Package[] packages;
        private int nberOfPackages;

        public Shipment() : this("Toronto")
        {

        }
        public Shipment(string destination)
        {
            Destination = destination;
            Packages = new Package[100];
        }
        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public Package[] Packages
        {
            get
            {
                return packages;
            }

            set
            {
                packages = value;
            }
        }
        public void AddPackage(Package aPackage)
        {
            Packages[nberOfPackages++] = aPackage;
        }
        private string ShowPackageList()
        {
            string result = "";
            if (nberOfPackages > 0)
            {
                for (int i = 0; i < nberOfPackages; i++)
                {
                    result = result + Packages[i].Volume + "_" + packages[i].PackageType + "\n         \t";
                }
            }
            else
            {
                result = "No Packages";
            }
            return result;
        }
        public void Save(string filename)
        {
            try
            {
                FileStream saveFile = new FileStream(filename + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter writeInFile = new StreamWriter(saveFile);
                for (int i = 0; i < nberOfPackages; i++)
                {
                    writeInFile.WriteLine(this.packages[i].Lenght + "," +
                                          this.packages[i].Width + "," +
                                          this.packages[i].Height + "," +
                                          this.packages[i].Volume + "," +
                                          this.packages[i].PackageType);
                }
                writeInFile.Close();
                saveFile.Close();
                Console.WriteLine("Shipment Saved\n");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string Getinfo()
        {
            return string.Format("destination:\t{0}\n" +
                                 "Packages:\t{1}\n", Destination, ShowPackageList());
        }
    }
}
