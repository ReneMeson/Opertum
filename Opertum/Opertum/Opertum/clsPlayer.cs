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
    class clsPlayer: clsActor
    {
        public clsPlayer (ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Img/Idle(1)");
        }
        public void moveRight()
        {
            int xPrevia = this.position.X;
            position = new Rectangle(xPrevia + 5, position.Y, position.Width, position.Height);
        }
        public void moveLeft()
        {
            int xPrevia = this.position.X;
            position = new Rectangle(xPrevia - 5, position.Y, position.Width, position.Height);
        }
        public void moveUp()
        {
            int yPrevia = this.position.Y;
            position = new Rectangle(yPrevia - 5, position.Y, position.Width, position.Height);
        }
        public void moveDown()
        {
            int yPrevia = this.position.Y;
            position = new Rectangle(yPrevia + 5, position.Y, position.Width, position.Height);
        }
    
    }
}
