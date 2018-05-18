namespace Consolas.Models
{
    public class Player
    {
        public string Name { get; private set; }
        public string WeaponName { get; private set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetWeapon(string weapon)
        {
            this.WeaponName = weapon;
        }
    }
}