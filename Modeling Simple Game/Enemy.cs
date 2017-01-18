using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_Simple_Game
{
    enum States
    {
        Alive, Dead
    }
    class Enemy
    {
        private int hp;
        public string characterName;
        public State currentState = State.FullHP;

        public Enemy(string _characterName)
        {
            characterName = _characterName;
            hp = 15;

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
     
        public void Attack(Fire_Mage enemy)
        {
            Console.WriteLine($"{characterName} attacked {enemy.characterName}");
            enemy.Damage();
        }
        public override string ToString()
        {
            return $"{characterName} : {hp}";
        }
    }
}
