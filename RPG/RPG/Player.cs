using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace RPG
{
    internal class Player : Character
    {

        public int Health { get; private set; }
        public int Damage { get; private set; }


        public Player(SpriteAnimation texture, Rectangle pos) : base(texture, pos)
        {
            Health = 100;
            Damage = 10;
        }

        public override void Update(GameTime gameTime) 
        {
            base.Update(gameTime);
            Input();
        }
        
        private void Input()
        {
            KeyboardState keyState = Keyboard.GetState();
            MouseState mState = Mouse.GetState();
            Activity = Action.Stay;
            if (keyState.IsKeyDown(Keys.A)) Activity |= Action.A;
            if (keyState.IsKeyDown(Keys.D)) Activity |= Action.D;
            if (keyState.IsKeyDown(Keys.W)) Activity |= Action.W;
            if (keyState.IsKeyDown(Keys.S)) Activity |= Action.S;
            if (mState.LeftButton == ButtonState.Pressed) Activity |= Action.Shoot;
            if (mState.RightButton == ButtonState.Pressed) Activity |= Action.Use;
        }
    }   
}
