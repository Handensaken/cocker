using System;
using Raylib_cs;
using System.Collections.Generic;
namespace test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Game");
            Raylib.SetTargetFPS(60);

            Paddle leftPaddle = new Paddle(10 , KeyboardKey.KEY_W, KeyboardKey.KEY_S);
            Paddle rightPaddle = new Paddle(770, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);

           // Rectangle ballRect = new Rectangle(800/2-10, 600/2-10, 20,20);
           // Rectangle ballRect2 = new Rectangle(800/2-50, 600/2-50, 20,20);
            while (!Raylib.WindowShouldClose())
            {
               // ballRect.x +=0.5f;
                Paddle.UpdateAll();
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GOLD);
                Paddle.DrawAll();

             //   Raylib.DrawRectangleRec(ballRect, Color.BLACK);
              //  Raylib.DrawRectangleRec(ballRect2, Color.BLACK);

             //   if(Raylib.CheckCollisionRecs(ballRect, ballRect2)){
              //      Raylib.DrawText("collided" , 10 , 500, 64, Color.BLACK);
             //   }

                Raylib.EndDrawing();
            }

        }
    }
}
