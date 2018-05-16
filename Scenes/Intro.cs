using System;

namespace Consolas.Scenes 
{
    public class Intro : Scene
    {
        public override void Play()
        {
            Console.WriteLine("Welcome to The Realm of Consolas! What is your name?");
            string playerName = Console.ReadLine();
    
            Console.WriteLine($"Pleased to meet you {playerName}. There are many adventures to be had here in Consolas," + 
                "but first you must prove your worth...");

            // Pause for dramatic effect.
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Step up, and choose your weapon wisely.");

            Console.WriteLine("You take 15 paces forward and see various weapons laid out across two makeshift tables.");
            Console.WriteLine("<----- Select A Weapon ----->");
            Console.WriteLine("Axe   - a");
            Console.WriteLine("Bow   - b");
            Console.WriteLine("Knife - k");
            Console.WriteLine("Sword - s");
            Console.WriteLine("Wand  - w");
            Console.WriteLine("<---------------------------->");

            string weaponChoice = Console.ReadLine();
            Console.WriteLine($"You pick up the {ConvertWeaponChoiceToWeaponName(weaponChoice)}, it has some blood on it, hopefully the blood of enemies.");
            Console.ReadLine();
        }

        string ConvertWeaponChoiceToWeaponName(string weaponChoice)
        {
            switch(weaponChoice)
            {
                case "a":
                    return "Axe";
                case "b":
                    return "Bow";
                case "k":
                    return "Knife";
                case "s":
                    return "Sword";
                case "w":
                    return "Wand";
                default:
                    return "Fists";
            }
        }
    }
}