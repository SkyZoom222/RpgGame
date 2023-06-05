using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal abstract class Character
    {
        protected SpriteAnimation Texture;
        public Rectangle Position;

        public Gun Weapon;

        protected Action Activity = Action.Stay;
        
        protected enum Action
        {
            Stay = 0,
            W = 1,
            A = 2,
            S = 4,
            D = 8,
            Shoot = 16
        }

        public Character(SpriteAnimation texture, Rectangle pos)
        {
            Texture = texture;
            Position = pos;
        }

        protected void CheckEvent()
        {
            int X = Position.X;
            int Y = Position.Y;
            if (Activity.HasFlag(Action.W)) Y -= 10;
            if (Activity.HasFlag(Action.A)) X -= 10;
            if (Activity.HasFlag(Action.S)) Y += 10;
            if (Activity.HasFlag(Action.D)) X += 10;
            if (Activity.HasFlag(Action.Shoot) && Weapon != null) Weapon.Use();

            Position = new Rectangle(X, Y, Position.Width, Position.Height);
        }

        public virtual void Draw(SpriteBatch _spriteBatch)
        {

        }

        public virtual void Update(GameTime gameTime)
        {
            CheckEvent();
        }
    }
}
