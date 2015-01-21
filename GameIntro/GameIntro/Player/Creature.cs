using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro;

namespace GameIntro.Player
{
    public abstract class Creature
    {
        public event EventHandler<ManaArgs> ManaChanged;
        public event EventHandler<HealthArgs> HealthChanged;

        String _name;
        TypesOfRaces.Race _race;
        int _health;
        int _currentHealth;
        int _mana;
        int _currentMana;

        public Creature(String name, TypesOfRaces.Race race, int health, int mana)
        {
            _health = health;
            _race = race;
            _name = name;
            _currentHealth = health;
            _mana = mana;
            _currentMana = mana;

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
        public int CurrentHealth
        {
            get { return _currentHealth; }
            set 
            { 
                _currentHealth = value;
                EventHandler<HealthArgs> handler = HealthChanged;
                if (handler != null)
                    handler(this, new HealthArgs(CurrentHealth));
            }
        }
        public int Mana
        {
            get { return _mana; }
        }
        public int CurrentMana
        {
            get { return _currentMana; }
            set 
            { 
                _currentMana = value;
                EventHandler<ManaArgs> handler = ManaChanged;
                if (handler != null)
                    handler(this, new ManaArgs(CurrentMana));
            }
        }
        public abstract String GetPic();
    }
    public class HealthArgs : EventArgs
    {
        int _health;
        public HealthArgs(int health)
        {
            _health = health;
        }
        public int Gethealth
        {
            get { return _health; }
            set { _health = value; }
        }
    }
    public class ManaArgs : EventArgs
    {
        int _mana;
        public ManaArgs(int mana)
        {
            _mana = mana;
        }
        public int GetMana
        {
            get { return _mana; }
            set { _mana = value; }
        }
    }
}
