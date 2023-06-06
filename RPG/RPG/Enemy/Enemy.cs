using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal abstract class Enemy : Character
    {



        public Enemy(SpriteAnimation texture, Rectangle pos) : base (texture, pos)
        {

        }
    }
}
