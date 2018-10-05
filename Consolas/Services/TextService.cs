using System;

public class TextService
{
    public void DisplayGreeting(string playerName)
    {
        Console.WriteLine($"Pleased to meet you {playerName}. There are many adventures to be had here in Consolas," +
            "but first you must prove your worth...");

        // Pause for dramatic effect.
        System.Threading.Thread.Sleep(1000);
    }

    public void DisplayWeaponChoice()
    {
        Console.WriteLine("Step up, and choose your weapon wisely.");

        Console.WriteLine("You take 15 paces forward and see various weapons laid out across two makeshift tables.");
        Console.WriteLine("<----- Select A Weapon ----->");
        Console.WriteLine("Axe   - a");
        Console.WriteLine("Bow   - b");
        Console.WriteLine("Knife - k");
        Console.WriteLine("Sword - s");
        Console.WriteLine("Wand  - w");
        Console.WriteLine("<---------------------------->");
    }
}