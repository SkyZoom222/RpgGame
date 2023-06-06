using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;

namespace RPG
{
    internal class Resource : Object
    {
        public int count { get;  set; }

        public Resource(SpriteAnimation texture, Rectangle position) : base(texture, position)
        {

        }
        public override void Update(GameTime gameTime)
        {

        }
        public override bool Use(int damage, Game1.Item items)
        {
            return false;
        }
        public static void DroppItems(Game1.Item items, int count)
        {
            
        }
    }
}
