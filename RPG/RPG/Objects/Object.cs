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
        protected int Id;
        protected Condition condition;
        protected enum Condition
        {
            Lying, Standing
        }

        public Object(SpriteAnimation texture, Rectangle position, int id)
        {
            Texture = texture;
            Position = position;
            Id = id;
        }
        public abstract void Update(GameTime gameTime);

        public void Draw(SpriteBatch _spritebatch)
        {

        }
    }
}
