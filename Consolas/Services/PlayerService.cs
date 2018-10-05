using System;

public class PlayerService
{
    private PlayerRepository _playerRepository;

    public void PlayerService(PlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public string ReadPlayerName()
    {
        Console.WriteLine("Welcome to The Realm of Consolas! What is your name?");
        string playerName = Console.ReadLine();
    }

    public void SavePlayer()
    {
        Console.WriteLine("Saving...");
        _playerRepository.Save(player);
        Console.ReadLine();
    }
}