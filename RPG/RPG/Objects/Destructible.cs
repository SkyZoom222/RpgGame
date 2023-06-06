using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace RPG
{
    internal class Destructible : Object
    {
        int HitPoint;
        Game1.Item tempItem;
        int count;
        public Destructible(SpriteAnimation texture, Rectangle position, int HP) : base(texture, position)
        {
            HitPoint = HP;
        }
        public override void Update(GameTime gameTime)
        {
            if (HitPoint <= 0)
            {
                count = rnd.Next(0, 30); // <- Resource.DroppItems(tempItem, count); <- Create new object class Resource 
            }
        }
        public override bool Use(int damage, Game1.Item items)
        {
            if (items == Game1.Item.Axe || items == Game1.Item.Pickaxe) { HitPoint -= damage; tempItem = items; return true; }
            return false;
        }
    }
}
