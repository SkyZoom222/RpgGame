using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Guns
{
    internal class Bullet
    {
        private SpriteAnimation Texture;
        private Rectangle Position;
        private int Damage;

        public Bullet(SpriteAnimation texture, Rectangle pos, int damage)
        {
            Damage = damage;
            Texture = texture;
            Position = pos;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch _spriteBatch)
        {

        }
    }
}
