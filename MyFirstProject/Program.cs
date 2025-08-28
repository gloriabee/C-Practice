using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the adventure game!");
            Console.WriteLine("Enter your character's name: ");
            string playerName=Console.ReadLine();
            Console.WriteLine("Choose your character type (Warrior,wizard,Archer");
            string characterType= Console.ReadLine();


            Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of dark forest");
            Console.WriteLine("Do you enter the forest or camp outside (Enter/Camp)");
            string choice1= Console.ReadLine();

            if (choice1.ToLower().Equals("enter"))
            {
                Console.WriteLine("You bravely enter the forest");
            }
            else
            {
                Console.WriteLine("You decide to camp out and wait for daylight.");

            }

            bool gameContinue = true;

            while (gameContinue)
            {
                Console.WriteLine("You come to a fork in the road. Go left or right?");
                string direction= Console.ReadLine();
                if (direction.ToLower().Equals("left"))
                {
                    Console.WriteLine("You find a treasure chest!");
                    gameContinue = false;
                }
                else
                {
                    Console.WriteLine("You encounter a wild beast!");
                    Console.WriteLine("Fight or flee? (fight/flee)");
                    string fightChoice=Console.ReadLine();
                    if (fightChoice.ToLower().Equals("fight"))
                    {
                        Random random=new Random();
                        int luck = random.Next(1, 11);
                        if (luck > 5)
                        {
                            Console.WriteLine("You beat the wild beast!");
                            if (luck > 8)
                            {
                                Console.WriteLine("The wild beast dropped a treasure");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The beast attacked you where you didn't expect");
                            gameContinue = false;
                        }
                    }
                }
            }


        }
    }
}
