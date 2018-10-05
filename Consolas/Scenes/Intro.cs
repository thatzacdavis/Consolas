using System;
using Consolas.Repo;
using Consolas.Models;

namespace Consolas.Scenes
{
    public class Intro : Scene
    {
        private readonly PlayerRepository _playerRepository = new PlayerRepository();
        private readonly PlayerService _playerService = new PlayerService(_playerRepository);
        private readonly TextService _textService = new TextService();
        private readonly WeaponService _weaponService = new WeaponService();

        public override void Play(ref Player player)
        {
            player.SetName(_playerService.ReadPlayerName());
            _textService.DisplayGreeting(playerName);

            _textService.DisplayWeaponChoice();
            player.SetWeapon(_weaponService.ReadWeaponChoice());

            _playerService.SavePlayer(player);
        }
    }
}