using System;
using SFML.Graphics;
using SFML.Window;
using System.Collections.Generic;

namespace shmup
{
    class EnemyManager
    {
        public List<Enemy> enemies = new List<Enemy>();    

        public void update(Player player) 
        {
            if (enemies.Count < 20){
                for (int i = 0; i < 19 - enemies.Count; i++)
                {
                    enemies.Add(new Enemy());
                }
            }
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].update();
                if (enemies[i].Position.Y > 480 || this.collisionOfBullets(enemies[i], player)) 
                {
                    AnimationManager.Animations.Add(new Animation(TextureManager.ExplosionTextures, enemies[i].Position));
                    enemies.Remove(enemies[i]);
                }
            }
        }

        public bool collisionOfBullets(Enemy enemy, Player player)
        {
            if (player.PlayerSprite.GetGlobalBounds().Intersects(enemy.EnemySprite.GetGlobalBounds()))
            {
                // game is over
                Console.WriteLine("game is over");
                
                return true;
            }
            for (int i = 0; i < player.bullets.Count; i++)
            {
                if (enemy.EnemySprite.GetGlobalBounds().Intersects(player.bullets[i].RectangleBullet.GetGlobalBounds())) 
                {
                    player.bullets.Remove(player.bullets[i]);
                    return true;
                }
            } 
            return false;
        }

        public void draw(RenderTarget window)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].draw(window);
            }
        }
    }
}