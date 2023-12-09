namespace MyGame;

class TicTacToe
{
   static char[] game = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
   public static int currentPlayer = 1;
   static readonly bool isGameOver = false;

   // 1st method → print the game board.
   public static void PrintGame()
   {
      string myGame =
         $"""
                  -------------
                  | {game[0]} | {game[1]} | {game[2]} | 
                  -------------
                  | {game[3]} | {game[4]} | {game[5]} | 
                  -------------
                  | {game[6]} | {game[7]} | {game[8]} | 
                  -------------
         """;

      Console.WriteLine(myGame);
   }

   // 2nd method → get the player move, make the validation and add the player symbol to the game board. 
   public static void GetPlayerMove()
   {
      int choice;
      bool isValidInput;

      do
      {
         Console.Write($"Player {currentPlayer} Enter your Number: ");

         // Take input and validation
         // Note: validation means to check if the user input is valid to use.
         isValidInput =
               int.TryParse(Console.ReadLine(), out choice) &&
               choice >= 1 && choice <= 9 &&
               game[choice - 1] == (char)(choice + '0');

         if (!isValidInput)
         {
            Console.WriteLine("Invelid Input, Try Again");
         }

      } while (!isValidInput);

      // if you reached here, the input is valid
      // add the current player symbol (X or O) to the board.
      char playerSymbol = currentPlayer == 1 ? 'X' : 'O';
      game[choice - 1] = playerSymbol;

   }

   // Note: the operator [ => ] is called lambda exepression.
   // You can search for its uses.
   public static void SwitchPlayer() => currentPlayer = currentPlayer == 1 ? 2 : 1;
   public static bool CheckForWin() =>
      (game[0] == game[1] && game[1] == game[2]) ||
      (game[3] == game[4] && game[4] == game[5]) ||
      (game[6] == game[7] && game[7] == game[8]) ||
      (game[0] == game[3] && game[3] == game[6]) ||
      (game[1] == game[4] && game[4] == game[7]) ||
      (game[2] == game[5] && game[5] == game[8]) ||
      (game[0] == game[4] && game[4] == game[8]) ||
      (game[2] == game[4] && game[4] == game[6]);

}