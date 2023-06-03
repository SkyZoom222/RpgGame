using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RPG
{
    internal abstract class Gun
    {

        protected SpriteAnimation Texture;
        protected Rectangle Position;
        protected CoolDown CD;
        protected Action Activity = Action.None;

        protected enum Action
        {
            None = 0,
            Shot = 1,
            Reload = 2,
            BulletFly = 4,
            Throwed = 8,
            Explosion = 16
        }
        
        public Gun(SpriteAnimation texture, Rectangle pos, int CDInterval)
        {
            Texture = texture;
            Position = pos;
            CD = new CoolDown(CDInterval);
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch _spriteBatch)
        {

        }

        public virtual void Follow(Point pos)
        {
            Position.Location = new Point(pos.X - Position.Width / 2, pos.Y - Position.Height / 2);
        }

        public abstract bool Use();
    }
}
