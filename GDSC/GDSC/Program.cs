namespace MyGame;

class MainClass
{
   public static void Main(string[] args)
   {
      bool isGameOver = false;

      // Repeat the game until [isGameOver] == true.
      do
      {
         // clear the console after each move and re-print the game.
         Console.Clear();
         TicTacToe.PrintGame();
         TicTacToe.GetPlayerMove();

         if (TicTacToe.CheckForWin())
         {
            Console.Clear();
            TicTacToe.PrintGame();
            Console.WriteLine($"Player {TicTacToe.currentPlayer} Wins !!");
            isGameOver = true;
         }

         TicTacToe.SwitchPlayer();

      } while (!isGameOver);

      Console.ReadKey();

   }
}
