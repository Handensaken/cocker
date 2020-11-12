using System;
using Raylib_cs;
using System.Collections.Generic;

namespace test
{
    public class Paddle
    {
        
        public static List<Paddle> paddles = new List<Paddle>();
     /*   public float xPos;
        public float yPos = 300;*/
        public Rectangle rectangle;

        public KeyboardKey upKey;
        public KeyboardKey downKey;

        public Paddle(float x, KeyboardKey up, KeyboardKey down)
        {
            rectangle = new Rectangle(x, 300, 20 , 50);
            //xPos = x;
            upKey = up;
            downKey = down;
            paddles.Add(this);
        }

        public void Update()
        {
            if (Raylib.IsKeyDown(upKey) && rectangle.y >= 0)
            {
                rectangle.y -= 4f;
            }
            if (Raylib.IsKeyDown(downKey) && rectangle.y <= 550)
            {
                rectangle.y += 4f;
            }

        }
        public static void UpdateAll(){
            foreach(Paddle paddle in paddles){
                    paddle.Update();
                }
        }
        public void Draw()
        {
            Raylib.DrawRectangleRec(rectangle, Color.BLACK);

        }
        public static void DrawAll(){
            foreach(Paddle paddle in paddles){
                    paddle.Draw();
                }
        }
    }
}
