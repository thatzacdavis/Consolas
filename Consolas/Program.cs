using System;
using Consolas.Scenes;
using Consolas.Models;

namespace Consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Intro intro = new Intro();
            intro.Play(ref player);
        }
    }
}
