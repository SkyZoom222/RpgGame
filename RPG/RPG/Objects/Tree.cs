using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;


namespace RPG
{
    internal class Tree : Object
    {
        int HitPoint = 20;

        public Tree(SpriteAnimation texture, Rectangle position, int id) : base(texture, position, id)
        {
            condition = Condition.Standing;
        }
        public override void Update(GameTime gameTime)
        {
            if (InputManager.Hover(Position)) HitPoint -= 1;
            if (HitPoint <= 0) DroppedItem();?
        }
    }
}
