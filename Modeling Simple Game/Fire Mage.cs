
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_Simple_Game
{
    enum State
    {
        FullHP, Wounded, Dead
    }

    class Fire_Mage
    {
        private int hp;
        public string characterName;
        public int hpPot;
        public State currentState = State.FullHP;

        public Fire_Mage(string _characterName)
        {
            characterName = _characterName;
            hp = 100;
            hpPot = 2;
        }
        public void PotHeal()
        {
            if (hpPot > 0)
            {
                hp += 10;
            }
            else
            {
                Console.WriteLine("You don't have any potions left");
            }


        }
        public void Damage()
        {
            if (hp <= 5)
            {
                Console.WriteLine($"{characterName} is Dead.");
                hp = 0;
                currentState = State.Dead;
            }
            else
            {
                hp -= 5;
            }
        }
        public void Wounded()
        {
            if (hp < 50)
            {
                Console.WriteLine($"{characterName} is wonded heal or lose a turn");
                currentState = State.Wounded;
            }
        }
        public void Attack(Fire_Mage enemy)
        {
            Console.WriteLine($"{characterName} attacked {enemy.characterName}");
            enemy.Damage();
        }
        public override string ToString()
        {
            return $"{characterName} : {hp}";
        }
        ///ENEMY

    }
}


