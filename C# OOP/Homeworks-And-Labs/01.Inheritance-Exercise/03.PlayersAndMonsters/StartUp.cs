namespace PlayersAndMonsters
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var soulMaster = new SoulMaster("Gosho", 35);

            Console.WriteLine(soulMaster);
        }
    }
}