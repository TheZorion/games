using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Player
{
    public class TypesOfRaces{
        public enum Race{Warrior, Wizard, Cleric, Rogue};

        static public List<Race> GetRaces()
        {
            List<Race> races = new List<Race>();
            races.Add(Race.Cleric);
            races.Add(Race.Warrior);
            races.Add(Race.Wizard);
            races.Add(Race.Rogue);
            return races;
        }
    }
}
