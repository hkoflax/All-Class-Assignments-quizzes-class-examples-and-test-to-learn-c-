using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    class Event
    {
        private Distance eventDistance;
        private Stroke eventStroke;
        public enum Distance {d1=50,d2=100,d3=200,d4=400,d5=800,d6=1500 }
        public enum Stroke { butterfly, backstroke, breaststroke, freestyle, individualmedley}

        public Event(): this(Distance.d1,Stroke.butterfly)
        {

        }
        public Event(Distance distance) : this(distance,Stroke.butterfly)
        {

        }
        public Event(Distance distance, Stroke stroke)
        {
            EventDistance = distance;
            EventStroke = stroke;
        }
        public Distance EventDistance
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
        public Stroke EventStroke
        {
            get
            {
                return eventStroke;
            }
            set
            {
                eventStroke= value;
            }
        }
        public string GetInfo()
        {
            return string.Format(
                "The Event distance is {0} \n"+
                "The Event Stroke is {1} \n"
                ,(int)EventDistance,EventStroke);
        }
    }
}
