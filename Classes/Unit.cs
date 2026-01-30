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
            Damage = 5;
            Armor = 0.6f;
        }

        public float Armor { get; }
        
        public float RealHealth()
        {
            return _health * (1f + Armor);
        }


        public bool SetDamage(float damage)           
            {
            _health -= damage * Armor;
            return _health <= 0f;
                
            

            




        }



        }    
    }

}
