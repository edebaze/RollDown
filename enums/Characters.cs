using System;
using System.Collections.Generic;

namespace Enums
{
    public class Characters
    {
        // 1 COSTS
        public static Character TRISTANA { get; } = new Character("TRISTANA", 1, Origin.YORDLE, Trait.GUNNER);
        public static Character JHIN { get; } = new Character("JHIN", 1, Origin.IONIA, Trait.DEADEYE);
        
        // 2 COSTS
        public static Character ASH { get; } = new Character("ASH", 2, Origin.FRELJORD, Trait.DEADEYE);
        
        // 3 COSTS
        public static Character AKSHAN { get; } = new Character("AKSHAN", 3, Origin.SHURIMA, Trait.DEADEYE);
        
        // 4 COSTS
        public static Character APHELIOS { get; } = new Character("APHELIOS", 4, Origin.TARGON, Trait.DEADEYE);
        
        // 5 COSTS
        public static Character SION { get; } = new Character("SION", 5, Origin.NOXUS, Trait.BRUISER);

        public static Character GetRandom(int cost)
        {
            List<Character> allChars = GetAll();
            List<Character> match = allChars.FindAll(character => character.Cost == cost);
            return match[new Random().Next(match.Count)];
        }

        public static List<Character> GetAll()
        {
            List<Character> allChars = new List<Character>();
            foreach (var property in typeof(Characters).GetProperties())
            {
                if (property.PropertyType == typeof(Character))
                {
                    Character character = (Character)property.GetValue(null);
                    allChars.Add(character);
                }
            }
            return allChars;
        }
    }
}
