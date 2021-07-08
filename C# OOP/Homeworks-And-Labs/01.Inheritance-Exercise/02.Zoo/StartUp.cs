namespace Zoo
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var snake = new Snake("Pesho");

            Console.WriteLine(snake.Name);
        }
    }
}