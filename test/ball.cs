using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace test
{
    public class ball
    {
        public Rectangle rect;
        public Vector2 speed = new Vector2(1, 1);

        public ball()
        {
            rect = new Rectangle(800 / 2 - 10, 600 / 2 - 10, 20, 20);
        }
        public void Update()
        {
            rect.x += speed.X;
            rect.y += speed.Y;
            if (rect.x > 800 - 20 || rect.x < 0)
            {
                speed.X = -speed.X;
            }

            if (rect.y > 600 - 20 || rect.y < 0)
            {
                speed.Y = -speed.Y;
            }

            foreach(Paddle p in Paddle.paddles){
                if(Raylib.CheckCollisionRecs(rect, p.rectangle)){
                    speed.X = -speed.X;
                }
            }

        }
    }
}
