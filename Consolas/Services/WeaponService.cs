using System;
using Consolas.Models;

public class WeaponService
{
    public string ReadWeaponChoice(Player player)
    {
        string weaponChoice = Console.ReadLine();
        string playerWeapon = ConvertWeaponChoiceToWeaponName(weaponChoice);
        Console.WriteLine($"You pick up the {playerWeapon}, it has some blood on it, hopefully the blood of enemies.");
        Console.ReadLine();
    }

    internal string ConvertWeaponChoiceToWeaponName(string weaponChoice)
    {
        switch (weaponChoice.ToLower())
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