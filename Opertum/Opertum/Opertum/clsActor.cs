using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Opertum
{
   abstract class clsActor
    {
        protected Rectangle Position;

        public Rectangle position
        {
            get { return position; }
            set { position = value; }
        }

        protected Texture2D Texture;

        public Texture2D texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public void Dibujar(SpriteBatch sb)
        {
            sb.Draw(texture, position, Color.White);
        }

    }
}
