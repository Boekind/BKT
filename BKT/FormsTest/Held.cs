using System;
using System.Collections.Generic;
using System.Text;

namespace FormsTest
{
    class Held
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string BildUrl { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }

        public Held(string name, int level, string bildurl, int maxhp, int currenthp)
        {
            Name = name;
            Level = level;
            BildUrl = bildurl;
            MaxHP = maxhp;
            CurrentHP = currenthp;
        }
    }
}
