public class WeaponService
{
    public string ConvertWeaponChoiceToWeaponName(string weaponChoice)
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