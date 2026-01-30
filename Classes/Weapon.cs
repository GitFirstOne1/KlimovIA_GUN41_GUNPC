using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Weapon
    {
        public string Name { get; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public float Durability { get; }

        public void SetDamageParams(int min, int max)
        {
            SetDamageParams(MinDamage, MaxDamage);
            {
                if (MinDamage > MaxDamage)
                {
                    (MaxDamage, MinDamage) = (MinDamage, MaxDamage);
                    Console.WriteLine("incorrect name ");
                }
                else if (MinDamage < 1f)
                {
                    Console.WriteLine("Minimum value 1");
                }

                if (MaxDamage <= 1f)
                {
                    MaxDamage = 10;
                }
            }
        }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1;
        }

        public Weapon(string name, int MinDamage, int MaxDamage) : this(name)
        {
           


        }
    }
}
