using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Button
    {
        private SpriteAnimation Texture;
        private SpriteAnimation OnBtn;
        private Rectangle Btn;
        private bool sw;
        private ButtonAction Action;
        public enum ButtonAction
        {
            None = 0,
            Exit = 1,
            Back = 2,
        }

        public Button(SpriteAnimation onBtn, SpriteAnimation texture, Rectangle btn, ButtonAction act)
        {
            OnBtn = onBtn;
            Texture = texture;
            Btn = btn;
            Action = act;
        }

        public void Update(MouseState mState)
        {
            if (Btn.Contains(mState.Position))
            {
                sw = true;
                if (mState.LeftButton == ButtonState.Pressed) BtnClick();
            }
            else sw = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Texture != null)
            {
                if (sw) OnBtn.Draw(spriteBatch, null, Btn);
                else Texture.Draw(spriteBatch, null, Btn);
            }
        }

        public void BtnClick()
        {
            switch(Action)
            {
                case ButtonAction.Exit:
                    Game1.quit = true;
                    break;
            }
        }
    }
}
