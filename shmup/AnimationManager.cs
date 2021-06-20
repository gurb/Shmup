using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace shmup
{
    class AnimationManager
    {
        private static List<Animation> animations = new List<Animation>();

        public static List<Animation> Animations { get { return animations; } }

        public static void update()
        {
            for (int i = 0; i < animations.Count; i++)
            {
                if (animations[i].DestroyIt) 
                {
                    animations.Remove(animations[i]);
                }
                else
                {
                    animations[i].update();
                }
            }
        }

        public static void draw(RenderTarget window) 
        {
            for (int i = 0; i < animations.Count; i++)
            {
                animations[i].draw(window);
            }
        }
    }
}