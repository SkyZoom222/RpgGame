using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace RPG
{
    internal class Destructible : Object
    {
        int HitPoint;

        public Destructible(SpriteAnimation texture, Rectangle position, int HP) : base(texture, position)
        {
            HitPoint = HP;
        }
        public override void Update(GameTime gameTime)
        {    

        }
        public override bool Use(int damage, Game1.Item items)
        {
            if (items == Game1.Item.Axe || items == Game1.Item.Pickaxe) HitPoint -= damage;
            return false;
        }
    }
}
