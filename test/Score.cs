using System;
using Raylib_cs;
namespace test
{
    public class Score
    {

        public int leftScore = 0;
        public int rightScore = 0;
        public void CalculateScore(bool side)
        {
            if (!side)
            {
                leftScore++;
            }
            else{
                rightScore++;
            }
        }
        public void DrawScore(){
            Raylib.DrawText(leftScore.ToString(), 300,100 , 64, Color.BLACK);
            Raylib.DrawText(rightScore.ToString(), 800-300, 100, 64, Color.BLACK);
        }

    }
}
