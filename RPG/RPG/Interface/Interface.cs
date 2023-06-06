using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    internal struct Picture
    {
        Rectangle Position;
        SpriteAnimation Texture;
        public Picture(Rectangle Position, SpriteAnimation Texture)
        {
            this.Position = Position;
            this.Texture = Texture;
        }

        public void Draw(SpriteBatch SB)
        {
            Texture.Draw(SB, null, Position);
        }
    }


    internal class Interface
    {
        private Rectangle Border;
        private SpriteAnimation BG;
        
        private List<Button> Buttons = new List<Button>();
        private List<Picture> Pictures = new List<Picture>();

        

        public Interface(SpriteAnimation texture, Rectangle rect, List<Button> btn)
        {
            BG = texture;
            Border = rect;
            Buttons = btn;
        }

        public Interface(SpriteAnimation texture, Rectangle rect)
        {
            BG = texture;
            Border = rect;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            BG.Draw(spriteBatch, null, Border);
            foreach(Picture pic in Pictures)
            {
                pic.Draw(spriteBatch);
            }
            foreach (Button button in Buttons)
            {
                button.Draw(spriteBatch);
            }
        }

        public void AddButton(Button button)
        {
            Buttons.Add(button);
        }

        public void AddPicture(Picture pic)
        {
            Pictures.Add(pic);
        }


    }
}
