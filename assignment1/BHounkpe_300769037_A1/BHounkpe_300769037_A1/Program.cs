using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Club koflaxClub = new Club();
            Club test = new Club("barbara");
            Club koflaxClub1 = new Club("marc", 6472354482);
            koflaxClub.Address = new Address(150, "Willamere Drive", "M1M 1Z8", "ON", "Canada");
            koflaxClub.TelephoneNumber = 647223752168856;
            test.Address = new Address(12);
            Console.WriteLine(test.GetInfo());
            Console.WriteLine(koflaxClub.GetInfo());
            Console.WriteLine(koflaxClub1.GetInfo());

            int year = 1992, month = 12, day = 4;
            DateTime dateOfBirth = new DateTime(year, month, day);
            Registrant barbara = new Registrant();
            Registrant koflax = new Registrant("koflax");
            barbara.Address = new Address(76, "Willamere drive", "M1M 1W8", "ON", "Canada");
            barbara.DateOfBirth = dateOfBirth;
            barbara.TelephoneNumber = 6472237521015556;
            Console.WriteLine(barbara.GetInfo());
            Console.WriteLine(koflax.GetInfo());

            int startYear = 2017, startMonth = 06, startDay = 1;
            DateTime startDate = new DateTime(startYear, startMonth, startDay);
            SwimMeet beginner = new SwimMeet();
            SwimMeet advance = new SwimMeet("Advance Swimmer");
            beginner.StartDate = startDate;
            beginner.EndDate = startDate.AddMonths(1);
            beginner.Ptype = SwimMeet.poolType.SCY;
            Console.WriteLine(advance.GetInfo());
            Console.WriteLine(beginner.GetInfo());

            Event race = new Event();
            Event challenge = new Event(Event.Distance.d4, (Event.Stroke)3);
            Console.WriteLine(race.GetInfo());
            Console.WriteLine(challenge.GetInfo());

            int hours = 5, min = 25, sec = 50;
            TimeSpan aTime = new TimeSpan(hours, min, sec);
            Swim swimming = new Swim();
            Swim diving = new Swim(aTime);
            diving.NumberOfLane = 25;
            diving.NumberOfTheHeat = 6;
            Console.WriteLine(swimming.GetInfo());
            Console.WriteLine(diving.GetInfo());
        }
    }
}
