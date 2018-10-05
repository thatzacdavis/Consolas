using Consolas.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace Consolas.Repo
{
    public class PlayerRepository
    {
        public Player GetById()
        {
            throw new System.NotImplementedException();
        }

        public void Save(Player player)
        {
            string playerData = JsonConvert.SerializeObject(player);

            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string filePath = Path.GetDirectoryName(path);
            string playerFilePath = filePath + "/players/" + player.Name + ".con";
            Directory.CreateDirectory(filePath + "/players");
            File.WriteAllText(playerFilePath, playerData);
        }
    }
}