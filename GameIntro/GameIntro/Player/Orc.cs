using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Player
{
    public class Orc : Creature
    {
        public Orc(String name, TypesOfRaces.Race race, int health, int mana)
            : base(name, race, health, mana)
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
        public override string GetPic()
        {
            return @"..\..\Pictures\orc.jpg";
        }
    }
}
