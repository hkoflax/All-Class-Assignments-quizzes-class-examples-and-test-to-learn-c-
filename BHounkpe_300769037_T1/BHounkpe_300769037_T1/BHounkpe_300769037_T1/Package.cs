using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_T1
{
    class Package
    {
        public enum PackageTypes { Book, Music, Toy, Shoes };
        private PackageTypes packageType;
        private double height;
        private double width;
        private double lenght;
        private double volume;

        public Package(): this(PackageTypes.Book,1,1,1)
        {

        }
        public Package(PackageTypes packageType) : this(packageType,1, 1, 1)
        {

        }
        public Package(PackageTypes packageType, double height, double width, double lenght)
        {
            Height = height;
            Width = width;
            Lenght = lenght;
            PackageType = packageType;
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
                volume = height * width * lenght;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
                volume = height * width * lenght;
            }
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }

            set
            {
                lenght = value;
                volume = height * width * lenght;
            }
        }

        public double Volume
        {
            get
            {
                return volume;
            }
        }

        public PackageTypes PackageType
        {
            get
            {
                return packageType;
            }

            set
            {
                packageType = value;
            }
        }
        public static Package operator +(Package firstPackage, Package secondPackage)
        {
            Package newPackage= new Package();
            newPackage.Lenght = firstPackage.Lenght + secondPackage.Lenght;
            newPackage.Width = firstPackage.Width + secondPackage.Width;
            newPackage.Height = firstPackage.Height + secondPackage.Height;
            if(firstPackage.Volume>secondPackage.Volume)
            {
                newPackage.PackageType = firstPackage.PackageType;
            }
            else
            {
                newPackage.PackageType = secondPackage.PackageType;
            }
            return newPackage;
        }


        public string Getinfo()
        {
            return string.Format("Height:{0}\n" +
                                 "width:{1}\n" +
                                 "lenght:{2}\n" +
                                 "volume:{3}\n"+
                                 "Type:{4}\n", Height, Width, Lenght, Volume, PackageType);
        }
    }
}
