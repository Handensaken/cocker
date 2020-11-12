using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace test
{
    public class ball
    {
        public Rectangle rect;
        public Vector2 speed = new Vector2(2, 2);

        int bounceCount;
        int diffScale;

        int leftPoints;
        int rightPoints;
        public ball()
        {
            rightPoints = 0;
            leftPoints = 0;
            diffScale = 8;
            bounceCount = 0;
            rect = new Rectangle(800 / 2 - 10, 600 / 2 - 10, 20, 20);
        }
        public void Update()
        {
            if (bounceCount == 7)
            {
                if (Math.Abs(speed.X) <= diffScale)
                {
                    if (speed.X > 0)
                    {
                        speed.X += 1;
                        speed.Y += 1;
                    }
                    else
                    {
                        speed.X -= 1;
                        speed.Y -= 1;
                    }
                }
                bounceCount = 0;
            }

            rect.x += speed.X;
            rect.y += speed.Y;
            if (rect.x > 800 - 20 || rect.x < 0)
            {
                speed.X = -speed.X;
                rect.x = 800 / 2 - 10;
                rect.y = 600 / 2 - 10;
            }

            if (rect.y > 600 - 20 || rect.y < 0)
            {
                speed.Y = -speed.Y;
            }

            foreach (Paddle p in Paddle.paddles)
            {
                if (Raylib.CheckCollisionRecs(rect, p.rectangle))
                {
                    speed.X = -speed.X;
                    bounceCount++;
                }
            }

        }
        public void Draw()
        {
            Raylib.DrawRectangleRec(rect, Color.BLACK);
        }
    }
}
