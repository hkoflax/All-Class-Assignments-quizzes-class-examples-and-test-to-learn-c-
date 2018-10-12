using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Room[] rooms = new Room[10];
            for(int i=0;i<10;i++)
            {
                int a = random.Next(1, 100);
                int b = random.Next(1, 100);
                Room oneRoom = new Room(a, b);
                rooms[i] = oneRoom;
            }
            foreach(Room room in rooms)
            {
                Console.WriteLine("the toatl boxes needed or lenght {1} and width {2} is {0}",room.numberOfBoxesOfTileNeeded,room.Length,room.Width);
            }
        }
    }
}
