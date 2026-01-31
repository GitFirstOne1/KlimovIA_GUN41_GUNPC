using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public struct Interval
    {
        private Random _random = new Random();

        public int Min { get; }
        public int Max { get; }
        public int Get(int Min, int Max) => (_random.Next(Min, Max));


            public Interval(int minValue, int maxValue)
            {

                if (minValue < 0) 
            {
                minValue = 0; Console.WriteLine("Incorrect data");
            }
                if (maxValue < 0) 
            {
                maxValue = 0; Console.WriteLine("Incorrect data"); 
            }


                if (minValue > maxValue)
                {
                    Console.WriteLine("Incorrect data");
                    (maxValue, minValue) = (minValue, maxValue);
                }


                if (minValue == maxValue)
                {
                    maxValue += 10;
                    Console.WriteLine("Incorrect data");
                }

                Min = minValue;
                Max = maxValue;
            }



            public class Weapon
        {
            public string Name { get; }

            public Interval DamageInterval { get; private set; }

            public float Durability { get; }

            public Weapon(string name)
            {
                Name = name;
                Durability = 1f;
                DamageInterval = new Interval(1, 10);
            }
            
            public Weapon(string name, int MinDamage, int MaxDamage) : this(name)
            {
                DamageInterval = new Interval(MinDamage, MaxDamage);

            }
            public int GetDamage() => (int)((DamageInterval.Min + DamageInterval.Max) / 2);

            
        }
    }
}

