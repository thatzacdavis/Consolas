using System;
using Consolas.Repo;
using Consolas.Models;

namespace Consolas.Scenes
{
    public class Intro : Scene
    {
        private readonly PlayerRepository _playerRepository = new PlayerRepository();
        private readonly TextService _textService = new TextService();
        private readonly WeaponService _weaponService = new WeaponService();

        public override void Play(ref Player player)
        {
            Console.WriteLine("Welcome to The Realm of Consolas! What is your name?");
            string playerName = Console.ReadLine();
            player.SetName(playerName);

            _textService.DisplayGreeting(playerName);
            _textService.DisplayWeaponChoice();
            _weaponService.ReadWeaponChoice(player);

            Console.WriteLine("Saving...");
            _playerRepository.Save(player);
            Console.ReadLine();
        }
    }
}