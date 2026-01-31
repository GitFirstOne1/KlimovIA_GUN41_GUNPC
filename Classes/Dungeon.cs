using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classes.Interval;

namespace Classes
{
    public struct Room
    {
        public Unit Unit;
        public Weapon Weapon;

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }
    public class Dungeon
    {
        public Room[] Rooms;

        public Dungeon()
        {
            Rooms = new Room[]
            {
                new(new Unit("q", 1, 5), new Weapon("qq", 1, 3)),
                new(new Unit("w", 1, 7), new Weapon("ww", 3, 6)),
                new(new Unit("e", 1, 10), new Weapon("ee", 6, 10)),
            };
            
            
        }
        public void ShowRooms()
        {
            for (int i = 0; i < Rooms.Length; i++)
            {
                var room1 = Rooms[i];
                Console.WriteLine("q" + "w");
                Console.WriteLine("ww" + "ee");
                Console.WriteLine("—");

                var room2 = Rooms[i];
                Console.WriteLine("q" + "e");
                Console.WriteLine("qq" + "ee");
                Console.WriteLine("—");

                var room3 = Rooms[i];
                Console.WriteLine("w" + "e");
                Console.WriteLine("ww" + "qq");
                Console.WriteLine("—");
            }
        }
    }
}
        

