using System;

namespace BHounkpe_300769037_A2
{
    class Event
    {
        private EventDistance eventDistance;
        private Stroke eventStroke;
        private string name;
        private Registrant[] eventRegistrantList;
        private Swim[] eventRegistrantSwim;
        private Swim swim;
        private SwimMeet swimMeet;
        public int NoOfRegistrantInEvent;

        public Event() : this(EventDistance._50, Stroke.Butterfly)
        {

        }
        public Event(EventDistance distance) : this(distance, Stroke.Butterfly)
        {

        }
        public Event(EventDistance distance, Stroke stroke)
        {
            Distance = distance;
            Stroke = stroke;
            Name = Convert.ToString(Distance) + "" + Convert.ToString(Stroke);
            SwimMeet = new SwimMeet();
            EventRegistrantList = new Registrant[100];
            EventRegistrantSwim = new Swim[100];
            NoOfRegistrantInEvent = 0;
        }
        public Swim Swims
        {
            get
            {
                return swim;
            }
            set
            {
                swim = value;
            }
        }
        public EventDistance Distance
        {
            get
            {
                return eventDistance;
            }
            set
            {
                eventDistance = value;
            }
        }
        public Stroke Stroke
        {
            get
            {
                return eventStroke;
            }
            set
            {
                eventStroke = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Swim[] EventRegistrantSwim
        {
            get
            {
                return eventRegistrantSwim;
            }

            set
            {
                eventRegistrantSwim = value;
            }
        }

        public SwimMeet SwimMeet
        {
            get
            {
                return swimMeet;
            }

            set
            {
                swimMeet = value;
            }
        }

        public Registrant[] EventRegistrantList
        {
            get
            {
                return eventRegistrantList;
            }

            set
            {
                eventRegistrantList = value;
            }
        }

        public string GetInfo()
        {
            return string.Format("{0} {1} \n" +
                                "       Swimmers:\n" +
                                "                {2}", Distance, Stroke, DisplayEventList());
        }
        public string DisplayEventList()
        {
            if (NoOfRegistrantInEvent > 0)
            {
                string result = "";
                for (int i = 0; i < NoOfRegistrantInEvent; i++)
                {
                    result = result + EventRegistrantList[i].Name + "\t" + DisplaySwimList(i) + "\n                ";
                }
                return result;
            }
            else
            {
                return "";
            }
        }
        public string DisplaySwimList(int index)
        {
            string result = "";
            Swim aSwim;
            aSwim = EventRegistrantSwim[index];
            if (this.swimMeet.SwimmMeetSeed == true)
            {
                if (aSwim.TimeSwam != "00:00.00")
                {
                    result = aSwim.GetInfo();
                    return result;
                }
                else
                {
                    result = "H" + aSwim.NumberOfTheHeat + "L" + aSwim.NumberOfLane + "\t" + "Time: no time";
                    return result;
                }
            }
            else
            {
                return "\n                     Not seeded/no swim ";
            }
        }
        public void AddSwimmer(Registrant registrant)
        {
            Swims = new Swim();
            if (NoOfRegistrantInEvent > 0)
            {
                int match = 0;
                for (int i = 0; i < NoOfRegistrantInEvent; i++)
                {
                    Registrant aRegistrantName = EventRegistrantList[i];
                    if (aRegistrantName.Name == registrant.Name)
                    {
                        match++;
                        throw new Exception("Swimmer " + registrant.Name + "," + registrant.RegistrationNumber + " already entered "+this.Name+"\n");
                    }
                }
                if (match == 0)
                {
                    EventRegistrantList[NoOfRegistrantInEvent] = registrant;
                    EventRegistrantSwim[NoOfRegistrantInEvent] = Swims;
                    if (NoOfRegistrantInEvent + 1 > SwimMeet.NumberOfLane)
                    {
                        EventRegistrantSwim[NoOfRegistrantInEvent].NumberOfLane = 1;
                        EventRegistrantSwim[NoOfRegistrantInEvent].NumberOfTheHeat += 1;
                    }
                    else
                    {
                        EventRegistrantSwim[NoOfRegistrantInEvent].NumberOfLane = NoOfRegistrantInEvent + 1;
                    }
                    NoOfRegistrantInEvent++;
                }
            }
            else
            {
                EventRegistrantList[NoOfRegistrantInEvent] = registrant;
                EventRegistrantSwim[NoOfRegistrantInEvent] = this.Swims;
                EventRegistrantSwim[NoOfRegistrantInEvent].NumberOfLane = NoOfRegistrantInEvent + 1;
                NoOfRegistrantInEvent++;
            }
        }
        public void EnterSwimmersTime(Registrant registrant, string time)
        {
            int match = 0;
            for (int i = 0; i < this.NoOfRegistrantInEvent; i++)
            {
                if (EventRegistrantList[i] == registrant)
                {
                    EventRegistrantSwim[i].TimeSwam = time;
                    match++;
                }
            }
            if (match == 0)
            {
                throw new Exception(registrant.Name + " has not entered " + this.Name);
            }
        }
    }
    public enum EventDistance { _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500 }
    public enum Stroke { Butterfly, Backstroke, Breaststroke, Freestyle, Individualmedley }
}
