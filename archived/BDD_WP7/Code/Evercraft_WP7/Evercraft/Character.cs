using System;

namespace Evercraft
{
    public class Character
    {
        public string Name { get; set; }

        public AlignmentEnum Alignment { get; set; }

        public int ArmorClass { get; set; }

        public int HitPoints { get; set; }

        public Character()
        {
            ArmorClass = 10;
            HitPoints = 5;
        }
    }
}