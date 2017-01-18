using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_Simple_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Class");
            string heroName;
            string heroType = Console.ReadLine();
            if (heroType == "1")
            {
                heroName = Console.ReadLine();

                
                Fire_Mage fireMage = new Fire_Mage(heroName);
              
                string test = fireMage.ToString();
                Console.WriteLine("Enter your Fire Mages Name");               
                Console.WriteLine(fireMage);



                while (fireMage.currentState == State.FullHP)
                {
                    Console.WriteLine(test);
                }
               
                
            }
        }
    }
}
