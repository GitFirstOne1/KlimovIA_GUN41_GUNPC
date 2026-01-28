using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Classes
{
    internal class Unit
    {
        private float _health;

        public string Name { get; }

        public float Health => _health;

        public int Damage { get; } = 5;

        public Unit() : this("Unknown Unit ")
        {
        }
        public Unit(string name)
        {
            Name = name;
        }

        public float Armor
        {
            get
            {
                return 0.6f;
            }
        }

        public float RealHealth()
        {
            return _health * (1f + Armor);
        }


        public bool SetDamage(float result, float value = 10f)
        {        
            if (Health <= 0) 
            {
                result = Health - value * Armor;
                return true;
            }
            else
            {
                return false;
            }

            




        }



        }    
    }

}
