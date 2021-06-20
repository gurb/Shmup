using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace shmup
{
    class Animation
    {
        private Sprite sprite;
        private int count = 0;

        private bool destroyIt = false;

        private List<Texture> textures = new List<Texture>();

        public bool DestroyIt { get { return destroyIt; }}

        public Animation(List<Texture> textures, Vector2f position)
        {
            this.sprite = new Sprite();
            this.sprite.Position = position;
            this.sprite.Texture = textures[0];
            this.textures = textures;
        }

        public void update()
        {
            if (this.count == this.textures.Count - 1) 
            {
                this.destroyIt = true;
            }
            else 
            {
                this.count += 1;
                this.sprite.Texture = this.textures[count];
            }
        }

        public void draw(RenderTarget window)
        {
            window.Draw(this.sprite);
        }
    }
}