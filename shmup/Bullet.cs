using SFML.Graphics;
using SFML.System;

namespace shmup {
    class Bullet
    {
        private RectangleShape rectangle;
        public const float BULLET_SPEED = 20f;
        Vector2f position;
        Vector2f size = new Vector2f(5, 10);
        
        public Vector2f Position { get { return position; } }
        public RectangleShape RectangleBullet { get { return this.rectangle; } }

        public Bullet (Vector2f position) 
        {
            this.rectangle = new RectangleShape(size);
            this.rectangle.FillColor = Color.White;
            this.rectangle.Position = position;
            this.position = position;
        }

        public void update() {
            this.position.Y -= BULLET_SPEED;
            this.rectangle.Position = this.position;                
        }
    }
}