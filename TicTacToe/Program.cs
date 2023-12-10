namespace MyGame;

class MainClass
{
   public static void Main(string[] args)
   {

      // Repeat the game until [isGameOver] == true.
      do
      {
         TicTacToe.PrintGame();

         TicTacToe.GetPlayerMove();

         if (TicTacToe.CheckForWin())
         {
            TicTacToe.HandleIfWin();
         }
         else if (TicTacToe.CheckForTie())
         {
            TicTacToe.HandleIfTie();
         }

         TicTacToe.SwitchPlayer();

      } while (!TicTacToe.isGameOver);

      Console.ReadKey();

   }
}
