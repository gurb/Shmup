using System;
using SFML.Graphics;
using SFML.Window;

namespace shmup
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.run();        
        }
    }
}