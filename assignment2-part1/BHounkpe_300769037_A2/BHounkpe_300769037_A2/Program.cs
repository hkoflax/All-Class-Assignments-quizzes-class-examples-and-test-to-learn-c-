﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 swimmers
            Registrant swimmer1;
            Registrant swimmer2;
            Registrant swimmer3;
            CreateSwimmers(out swimmer1, out swimmer2, out swimmer3);

            //Create two clubs
            Club club1;
            Club club2;
            CreateClubs(out club1, out club2);

            //Assigne swimmers to club
            AssigneSwimmersToClubs(swimmer1, swimmer2, swimmer3, club1, club2);

            //Create swim meets

            SwimMeet meet1;
            SwimMeet meet2;
            CreateSwimMeets(out meet1, out meet2);

            Event _50free1;
            Event _100fly;
            Event _200breast;
            Event _400free;
            Event _1500free;
            CreateEvents(out _50free1, out _100fly, out _200breast, out _400free, out _1500free);

            AddEventsToSwimMeets(meet1, meet2, _50free1, _100fly, _200breast, _400free, _1500free);

            AddSwimmersToEvents(swimmer1, swimmer2, swimmer3, meet1, meet2,
                                _50free1, _100fly, _200breast, _400free, _1500free);

            SeedMeets(meet1, meet2);

            EnterTimesForSwims(swimmer1, swimmer2, swimmer3, meet1, meet2,
                               _50free1, _100fly, _200breast, _400free, _1500free);
        }

        private static void EnterTimesForSwims(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free)
        {
            Console.WriteLine("********** Adding swim times for swimmers *********");

            _50free1.EnterSwimmersTime(swimmer1, "00:30.13");
            _50free1.EnterSwimmersTime(swimmer2, "00:28.87");
            _50free1.EnterSwimmersTime(swimmer3, "00:29.54");

            _100fly.EnterSwimmersTime(swimmer1, "01:17.23");
            _100fly.EnterSwimmersTime(swimmer2, "01:05.16");

            _200breast.EnterSwimmersTime(swimmer1, "02:25.23");
            _200breast.EnterSwimmersTime(swimmer3, "02:17.03");

            _400free.EnterSwimmersTime(swimmer2, "04:55.23");

            _1500free.EnterSwimmersTime(swimmer1, "15:17.23");
            _1500free.EnterSwimmersTime(swimmer2, "16:17.23");
            _1500free.EnterSwimmersTime(swimmer3, "17:17.23");

            try
            {
                _400free.EnterSwimmersTime(swimmer1, "04:55.23");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            DisplayInfo("meet1", meet1.GetInfo());
            DisplayInfo("meet2", meet2.GetInfo());
        }

        private static void SeedMeets(SwimMeet meet1, SwimMeet meet2)
        {
            meet1.Seed();
            meet2.Seed();

            DisplayInfo("meet1", meet1.GetInfo());
            DisplayInfo("meet2", meet2.GetInfo());
        }

        private static void AddSwimmersToEvents(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free)
        {
            //Add swimmers to event
            _50free1.AddSwimmer(swimmer1);
            _50free1.AddSwimmer(swimmer2);
            _50free1.AddSwimmer(swimmer3);
            try
            {
                _50free1.AddSwimmer(swimmer3);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            _100fly.AddSwimmer(swimmer1);
            _100fly.AddSwimmer(swimmer2);

            _200breast.AddSwimmer(swimmer1);
            _200breast.AddSwimmer(swimmer2);
            _200breast.AddSwimmer(swimmer3);

            _400free.AddSwimmer(swimmer2);

            _1500free.AddSwimmer(swimmer1);
            _1500free.AddSwimmer(swimmer2);
            _1500free.AddSwimmer(swimmer3);

            DisplayInfo("meet1", meet1.GetInfo());
            DisplayInfo("meet2", meet2.GetInfo());
        }

        private static void AddEventsToSwimMeets(SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free)
        {
            meet1.AddEvent(_50free1);
            meet1.AddEvent(_100fly);
            meet1.AddEvent(_200breast);

            meet2.AddEvent(_400free);
            meet2.AddEvent(_1500free);

            DisplayInfo("meet1", meet1.GetInfo());
            DisplayInfo("meet2", meet2.GetInfo());
        }

        private static void CreateEvents(out Event _50free1, out Event _100fly, out Event _200breast, out Event _400free, out Event _1500free)
        {
            _50free1 = new Event();
            _50free1.Distance = EventDistance._50;
            _50free1.Stroke = Stroke.Freestyle;

            _100fly = new Event(EventDistance._100, Stroke.Butterfly);
            _200breast = new Event(EventDistance._200, Stroke.Breaststroke);
            _400free = new Event(EventDistance._400, Stroke.Freestyle);
            _1500free = new Event(EventDistance._1500, Stroke.Freestyle);
        }

        private static void CreateSwimMeets(out SwimMeet meet1, out SwimMeet meet2)
        {
            Console.WriteLine("*******meets and events ******\n***********************************");
            meet1 = new SwimMeet();
            meet1.Name = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            DisplayInfo("meet1", meet1.GetInfo());


            meet2 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.LCM, 2);
            DisplayInfo("meet2", meet2.GetInfo());
        }

        private static void AssigneSwimmersToClubs(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, Club club1, Club club2)
        {
            Console.WriteLine("*******Adding swimmers to clubs ******\n***********************************");

            club1.AddSwimmer(swimmer1);
            DisplayInfo("club1", club1.GetInfo());
            DisplayInfo("swimmer1", swimmer1.GetInfo());

            club2.AddSwimmer(swimmer2);
            DisplayInfo("club2", club2.GetInfo());
            DisplayInfo("swimmer2", swimmer2.GetInfo());

            try
            {
                swimmer2.Club = club1;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                swimmer3.Club = club1;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            DisplayInfo("swimmer3", swimmer3.GetInfo());
            DisplayInfo("club1", club1.GetInfo());
        }

        private static void CreateClubs(out Club club1, out Club club2)
        {
            club1 = new Club();
            club1.PhoneNumber = 4164444444;
            club1.Name = "NYAC";
            DisplayInfo("club1", club1.GetInfo());

            club2 = new Club("CCAC", new Address("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            DisplayInfo("club2", club2.GetInfo());
        }

        private static void CreateSwimmers(out Registrant swimmer1, out Registrant swimmer2, out Registrant swimmer3)
        {
            swimmer1 = new Registrant("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Address("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            DisplayInfo("swimmer1", swimmer1.GetInfo());

            swimmer2 = new Registrant();
            DisplayInfo("swimmer2", swimmer2.GetInfo());
            swimmer2.Address = new Address("1 King St", "Toronto", "ON", "M2M 3M3");
            swimmer2.Name = "John Lee";
            swimmer2.PhoneNumber = 4162222222;
            swimmer2.DateOfBirth = new DateTime(1950, 12, 1);
            DisplayInfo("swimmer2", swimmer2.GetInfo());

            swimmer3 = new Registrant("Ann Smith", new DateTime(1975, 1, 1),
                                                    new Address("5 Queen St", "Toronto", "ON", "M2M 4M4"), 4163333333);
            DisplayInfo("swimmer3", swimmer3.GetInfo());
        }

        public static void DisplayInfo(string firstLineMessage, string info)
        {
            Console.WriteLine("--{0}---------------------", firstLineMessage);
            Console.WriteLine(info);
            Console.WriteLine("--------------------------\n");
        }
    }
}
