using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.Window;

namespace shmup
{
    class TextureManager
    {
        private static string ASSETS_PATH = "bin/Assets/Textures/";
        private static string EXPLOSION_ASSETS_PATH = "bin/Assets/Textures/explosions/";

        static Texture playerTexture;
        static Texture enemyTexture;
        static Texture backgroundTexture;
        static List<Texture> explosionTextures = new List<Texture>(); 

        public static Texture PlayerTexture { get {return playerTexture; } }
        public static Texture EnemyTexture { get {return enemyTexture; } }
        public static Texture BackgroundTexture { get {return backgroundTexture; } }
        public static List<Texture> ExplosionTextures { get { return explosionTextures; } }

        public static void LoadTexture()
        {
            playerTexture = new Texture(ASSETS_PATH + "player.png");
            enemyTexture = new Texture(ASSETS_PATH + "enemy.png");
            backgroundTexture = new Texture(ASSETS_PATH + "background.png");
            
            for (int i = 0; i < 8 ; i++)
            {
                explosionTextures.Add(new Texture(EXPLOSION_ASSETS_PATH + "explosion-00" + i.ToString() +".png"));
            }
        }


    }
}