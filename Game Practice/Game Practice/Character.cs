using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Practice
{
    class Character
    {
        private string _name;
        private int _level;
        private int _exp;
        private int _hp;

        //Character info method

        public Character(string Name, int HP, int Level, int Exp)
        {
            this.Name = Name;
            this.HP = HP;
            _level = Level;
            _exp = Exp;
        }

        //Name Property

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //HP Method

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        //Get Experience

        public int GetExp()
        {
            return _exp;
        }

        //Get Level
        public int GetLevel()
        {
            return _level;
        }

        public bool isGood()
        {
            return true;
        }

        public bool isEvil()
        {
            return true;
        }
        //Attack Method for Enemy target
        //Experience Method

        public void Attack(Character target)
        {
            Console.WriteLine(this._name + " attacks " + target.Name + ".");
            target.Damage(_level * 3);


            if (target.isAlive())
            {
                Console.WriteLine(target.Name + " has " + target.HP + " health left.");
            }
            else
            {
                Console.WriteLine(target.Name + " is defeated!");

                if (!target.isAlive() && target.isGood())
                {
                    _exp = (target.GetLevel() * 3);
                    Console.WriteLine(_name + " gained " + _exp + " experience!");
                }
            }
        }


        //Damage Method

        public void Damage(int amount)
        {
            Console.WriteLine(_name + " takes " + amount + " damage.");
            _hp -= amount;
        }

        public bool isAlive()
        {
            return _hp > 0;
        }
    }
}
