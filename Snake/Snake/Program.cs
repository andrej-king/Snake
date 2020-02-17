using System;
using System.Diagnostics;
using System.Threading;


namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.SetBufferSize(120, 50); // Set width and height window

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // draw points
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // create food
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw(ConsoleColor.Red);

            // Пути и настройки
            Params settings = new Params();

            // Audio player
            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.Play();
            
            Sounds sound1 = new Sounds(settings.GetResourceFolder());

            // Score
            Score score = new Score(settings.GetResourceFolder());

            // Timer
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw(ConsoleColor.Red);
                    sound1.PlayEat();
                    score.UpCurrentPoints();
                    score.ShowCurrentPoints();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    // ConsoleKeyInfo key = Console.ReadKey();
                    // snake.HandeKey(key.Key);
                    // snake.HandeKey(key);

                    snake.HandeKey(Console.ReadKey(true).Key,
                        score); // Передается значение нажатой клавиши, но не отображается в консоли    
                }

                // Timer show info
                TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                Console.SetCursorPosition(93, 23);
                Console.Write(timeSpan.ToString("mm':'ss"));
                Console.Write('\r');
            }

            score.WriteBestResult();
            score.WriteGameOver();


            // Console.ReadKey();
        }
    }
}