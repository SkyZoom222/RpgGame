using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class SpriteAnimation
{
    public Rectangle[] Sprite;
    Rectangle[] W, A, S, D;
    double speed;
    double Time = 0;
    int currentSprite = 0;
    int currentWASD = 0;
    bool WASD = false;
    public Texture2D Sprites { get; set; }
    public Rectangle WSprites 
    { 
        set
        {
            WASD = true;
            W = new Rectangle[value.X];
            for(int i = value.Width; i < value.Height; i++)
            {
                W[value.Height - i - 1] = Sprite[i];
            }
        }
    }
    public Rectangle ASprites
    {
        set
        {
            WASD = true;
            A = new Rectangle[value.X];
            for (int i = value.Width; i < value.Height; i++)
            {
                A[value.Height - i - 1] = Sprite[i];
            }
        }
    }
    public Rectangle SSprites
    {
        set
        {
            WASD = true;
            S = new Rectangle[value.X];
            for (int i = value.Width; i < value.Height; i++)
            {
                S[value.Height - i - 1] = Sprite[i];
            }
        }
    }
    public Rectangle DSprites
    {
        set
        {
            WASD = true;
            D = new Rectangle[value.X];
            for (int i = value.Width; i < value.Height; i++)
            {
                D[value.Height - i - 1] = Sprite[i];
            }
        }
    }
    public List<Rectangle> Stay;
    public SpriteAnimation(int x0, int y0, int SpriteWidth, int SpriteHeight, int SpritePerSecond, int CountW, int CountH = 1)
    {
        speed = (double)SpritePerSecond / 60;
        Sprite = new Rectangle[CountH * CountW];
        Stay = new List<Rectangle>();
        int temp = 0;
        for (int i = 0; i < CountH; i++)
        {
            for (int j = 0; j < CountW; j++)
            {
                Sprite[temp] = new Rectangle(x0 + j * SpriteWidth, y0 + i * SpriteHeight, SpriteWidth, SpriteHeight);
                temp++;
            }
        }
    }

    public void SpritesCut(int offsetX, int offsetY, int width, int height)
    {
        for (int i = 0; i < Sprite.Length; i++)
        {
            Rectangle rect = Sprite[i];
            rect.X += offsetX;
            rect.Y += offsetY;
            rect.Width = width;
            rect.Height = height;
            Sprite[i] = rect;
        }
    }

    public void Update(int SpritePerSecond = -1)
    {
        if (SpritePerSecond > 0) speed = (double)SpritePerSecond / 60;
        Time += speed;
        if (!WASD && Time >= 1)
        {
            Time = 0;
            if (currentSprite < Sprite.Length - 1) currentSprite++;
            else currentSprite = 0;
        }
        if(WASD && Time >= 1)
        {
            Time = 0;
            if (currentWASD < W.Length - 1) currentWASD++;
            else currentWASD = 0;
        }

        
    }

    public void Draw(SpriteBatch SB, Texture2D ?Sprites, Rectangle pos)
    {
        if (this.Sprites != null) SB.Draw(this.Sprites, pos, Sprite[currentSprite], Color.White);
        else SB.Draw(Sprites, pos, Sprite[currentSprite], Color.White);
    }

    public void Draw(SpriteBatch SB, Rectangle pos, string dir, bool stay = false)
    {
        if(!stay)
            switch (dir)
            {
                case "W":
                    SB.Draw(Sprites, pos, W[currentWASD], Color.White);
                    break;
                case "A":
                    SB.Draw(Sprites, pos, A[currentWASD], Color.White);
                    break;
                case "S":
                    SB.Draw(Sprites, pos, S[currentWASD], Color.White);
                    break;
                case "D":
                    SB.Draw(Sprites, pos, D[currentWASD], Color.White);
                    break;
            }
        else
            switch (dir)
            {
                case "W":
                    SB.Draw(Sprites, pos, Stay[0], Color.White);
                    break;
                case "A":
                    SB.Draw(Sprites, pos, Stay[1], Color.White);
                    break;
                case "S":
                    SB.Draw(Sprites, pos, Stay[2], Color.White);
                    break;
                case "D":
                    SB.Draw(Sprites, pos, Stay[3], Color.White);
                    break;
            }
    }

    public void DrawRotation(SpriteBatch SB, Texture2D ?Sprites, Rectangle pos, float angle, Vector2 CenterOfRotation, SpriteEffects FlipEffect = SpriteEffects.None, float Layer = 1f)
    {
        if (this.Sprites != null) SB.Draw(this.Sprites, pos, Sprite[currentSprite], Color.White, angle, CenterOfRotation, FlipEffect, Layer);
        else SB.Draw(Sprites, pos, Sprite[currentSprite], Color.White, angle, CenterOfRotation, FlipEffect, Layer);
    }

    public void DrawOneSprite(SpriteBatch SB, Texture2D ?Sprites, Rectangle pos, int Sprite_num)
    {
        int temp = Sprite_num % Sprite.Length;
        if (this.Sprites != null) SB.Draw(this.Sprites, pos, Sprite[temp], Color.White);
        else SB.Draw(Sprites, pos, Sprite[temp], Color.White);
    }

    public void ResetAnimation(int StartSprite = 0)
    {
        currentSprite = StartSprite;
    }






}

