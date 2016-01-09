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
        protected Rectangle _position;

        public Rectangle position
        {
            get { return _position; }
            set { _position = value; }
        }

        protected Texture2D _texture;

        public Texture2D texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public void Dibujar(SpriteBatch sb)
        {
            sb.Draw(_texture, _position, Color.White);
        }

    }
}
