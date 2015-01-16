using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro;

namespace GameIntro.Player
{
    public abstract class Creature
    {
        

        String _name;
        TypesOfRaces.Race _race;
        int _health;

        public Creature(String name, TypesOfRaces.Race race, int health)
        {
            _health = health;
            _race = race;
            _name = name;
        }

        public abstract int getDefense();
        public abstract int getAttack();
        public void RecieveDamage(int damage)
        {
            _health -= damage;
        }
        public String Name
        {
            get{return _name;}
        }
        public TypesOfRaces.Race Race
        {
            get { return _race; }
        }
        public int Health
        {
            get { return _health;}
        }
    }
}
