using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;

namespace RPG
{
    internal abstract class Object
    {
        protected SpriteAnimation Texture;
        protected Rectangle Position;

        public Object(SpriteAnimation texture, Rectangle position)
        {
            Texture = texture;
            Position = position;
        }
        public abstract void Update(GameTime gameTime);

        public void Draw(SpriteBatch _spritebatch)
        {
            Texture.Draw(_spritebatch, null, Position);
        }
        public abstract bool Use(int damage, Game1.Item items);
    }
}
