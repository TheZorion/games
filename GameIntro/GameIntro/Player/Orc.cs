using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Player
{
    public class Orc : Creature
    {
        public Orc(String name, TypesOfRaces.Race race, int health)
            : base(name, race, health)
        {

        }

        public override int getAttack()
        {
            return 5;
        }
        public override int getDefense()
        {
            return 5;
        }
    }
}
