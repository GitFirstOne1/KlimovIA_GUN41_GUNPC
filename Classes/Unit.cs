using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes
{
  

        public class Unit
    {
        private float _health;

        public string Name { get; }

        public float Health => _health;

        public Interval Damage { get; } 
        public Unit(string name) : this(name, 0, 5) { }

        public Unit() : this("Unknown Unit ")
        {
        }
        public Unit(string name, int MinDamage, int MaxDamage)
        {
            Name = name;
            Damage = new Interval(MinDamage, MaxDamage);
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


