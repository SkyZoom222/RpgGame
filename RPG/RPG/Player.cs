using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace RPG
{
    public class Player
    {

        public Rectangle Position { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }

        private Direction direction; 
        private Texture2D textureRun;
        private Texture2D textureStay;
        private KeyboardState keyState;

        public Player(int x, int y)
        {
            this.Position = new Rectangle(x, y, 50, 75);
            Health = 100;
            Damage = 10;
            direction = Direction.Stay;
        }

        public void ContentLoad(SpriteBatch _spriteBatch)
        {

        }
        public void Update(GameTime gameTime) 
        {
            KeyboardIn();
            Movement();
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            
        }
        private void Movement()
        {
            int X = Position.X;
            int Y = Position.Y;
            if (direction == Direction.Stay) return;
            else if (direction == Direction.Left) X -= 10;
            else if (direction == Direction.Right) X += 10;
            else if (direction == Direction.Up) Y -= 10;
            else if (direction == Direction.Down) Y += 10;
            Position = new Rectangle(X, Y, 50, 100);
        }
        enum Direction
        { 
            Left, Right, Up, Down, Stay
        }
        private void KeyboardIn()
        {
            keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.A)) direction = Direction.Left;
            if (keyState.IsKeyDown(Keys.D)) direction = Direction.Right;
            if (keyState.IsKeyDown(Keys.W)) direction = Direction.Up;
            if (keyState.IsKeyDown(Keys.S)) direction = Direction.Down;
            else direction = Direction.Stay;
        }
    }   
}
