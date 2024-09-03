namespace MCClone
{
    class Program
    {
        static void Main(string[] args)
        {
            using (game game = new game(500, 500)) {
                game.Run();
            }
        }
    }
}