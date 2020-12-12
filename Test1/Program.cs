namespace Test1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var gameState = new GameState();
            gameState.Initialize();
            gameState.LaunchGameLoop();
        }
    }
}