using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W3C2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Section comp123S1 = new Section(1, "COMP123", 30);
            Section comp123S4 = new Section(4, "COMP123", 35);
            Section copm123OnHold = new Section(6, "COMP123", 10);

            Section combinedSection;

            comp123S1.TellAboutSelf();
            comp123S4.TellAboutSelf();
            copm123OnHold.TellAboutSelf();

            combinedSection = comp123S1 + comp123S4;

            combinedSection.TellAboutSelf();

            //Section[] sections = new Section[4];
            //sections[0] = new Section(1, "COMP100", 30);
            //sections[1] = new Section(2, "COMP100", 35);
            //sections[2] = new Section(3, "COMP100", 20);
            //sections[3] = new Section(4, "COMP100", 10);

            Section[] sections =
            {
                new Section(1, "COMP100", 30),
                new Section(2, "COMP100", 35),
                new Section(3, "COMP100", 20),
                new Section(4, "COMP100", 10)
            };

            foreach (Section item in sections)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
