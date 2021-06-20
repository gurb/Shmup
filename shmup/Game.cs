using SFML.Graphics;
using SFML.Window;
using System.Collections.Generic;

namespace shmup {
    class Game
    {
        private const int WIDTH = 640;
        private const int HEIGHT = 480;
        private const string TITLE = "SHMUP";
        private RenderWindow window;
        private VideoMode mode = new VideoMode(WIDTH, HEIGHT);
        Sprite background;        
        Player player;
        
        EnemyManager enemies;

        public Game()
        {
            this.window = new RenderWindow(this.mode, TITLE);
            
            this.window.SetVerticalSyncEnabled(true);
            this.window.SetFramerateLimit(60);

            TextureManager.LoadTexture();
            
            background = new Sprite();
            background.Texture = TextureManager.BackgroundTexture;

            player = new Player();
            enemies = new EnemyManager();

            // events
            this.window.Closed += (sender, args) => {
                this.window.Close(); 
            };
        }

        public void run() 
        {
            while(this.window.IsOpen)
            {
                this.handleEvents();
                this.update();
                this.draw();            
            }
        }

        private void handleEvents()
        {
            this.window.DispatchEvents();
        }

        private void update() 
        {
            this.player.update();
            this.enemies.update(this.player);
            AnimationManager.update();
        }

        private void draw() 
        {
            this.window.Clear(Color.Blue);
            
            this.window.Draw(this.background); 
            this.player.draw(this.window);
            this.enemies.draw(this.window);
            AnimationManager.draw(this.window);

            this.window.Display();
        }
    }
}