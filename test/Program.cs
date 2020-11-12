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

            ball theBall = new ball();

            Score score = new Score();
            while (!Raylib.WindowShouldClose())
            {
                Paddle.UpdateAll();
                theBall.Update();
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GOLD);
                Paddle.DrawAll();
                theBall.Draw();
                score.DrawScore();
                Raylib.EndDrawing();
            }

        }
    }
}
