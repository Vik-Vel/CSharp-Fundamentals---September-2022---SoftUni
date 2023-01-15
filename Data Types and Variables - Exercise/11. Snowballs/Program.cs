using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowBalls = int.Parse(Console.ReadLine());
            BigInteger snowBallValue2 = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            int snowBallQuality = 0;

            BigInteger hightScore = int.MinValue;
             

            string bestSnowBallForula = "";

            for (int i = 1; i <= numOfSnowBalls; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = snowBallSnow / snowBallTime;
                snowBallValue2 = BigInteger.Pow(snowballValue, snowBallQuality);
                if (snowBallValue2 > hightScore )
                {
                    hightScore = snowBallValue2;
                    bestSnowBallForula =$"{snowBallSnow} : {snowBallTime} = {snowBallValue2} ({snowBallQuality})";
                }
            }

            Console.WriteLine(bestSnowBallForula);
        }
    }
}
