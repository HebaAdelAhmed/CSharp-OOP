using System;
using System.Threading.Channels;

namespace RouteCSharpEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball() { Id = 4035 };
            ball.BallLocation = new Location(10, 20, 40);

            Player player11 = new Player() { Name ="Heba", TeamName = "PC" };
            Player player12 = new Player() { Name = "Amen", TeamName = "PC" };

            Player player21 = new Player() { Name ="Salah", TeamName = "Liverpool" };
            Player player22 = new Player() { Name = "Mane", TeamName = "Liverpool" };

            Refee refree = new Refee() { Name = "Hana" };

            ball.BallLocation = new Location(10, 25, 40);
            Console.WriteLine(ball.BallLocation);
            Console.WriteLine("After Match Is Starting");
            // Subscribtion [Registeration]
            ball.BallLocationChanged += player11.Run;
            ball.BallLocationChanged += player12.Run;
            ball.BallLocationChanged += player22.Run;
            ball.BallLocationChanged += player21.Run;
            ball.BallLocationChanged += refree.Look;
            ball.BallLocationChanged += () => Console.WriteLine("Extra Method");

            ball.BallLocation = new Location(60, 25, 50);

        }
    }
}
