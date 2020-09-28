using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.knight;
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }

    public enum RpgClass
    {
        knight = 1,
        Mage = 2,
        Cleric = 3
    }
}
