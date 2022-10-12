class TicTacToe{
    static void Main(string[] args){
        board board = new board();
        string currentPlayer = "x";
        while (!IsGameOver(board)){
            board.print();

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);

            DisplayBoard(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }
        
        static void DisplayBoard(List<string> board){
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }
        static bool IsGameOver(List<string> board){
            return isWinner(board, "x") || isWinner(board, "o") || isTie(board);
        }
        static bool IsWinner(List<string> board, string player){
            if(board[0] == board[1] == board[2] == "x" || "o"){
                return true;
            }
            if(board[3] == board[4] == board[5] == "x" || "o"){
                return true;
            }
            if(board[6] == board[7] == board[8] == "x" || "o"){
                return true;
            }
            if(board[0] == board[3] == board[6] == "x" || "o"){
                return true;
            }
            if(board[1] == board[4] == board[7] == "x" || "o"){
                return true;
            }
            if(board[2] == board[5] == board[8] == "x" || "o"){
                return true;
            }
            if(board[0] == board[4] == board[8] == "x" || "o"){
                return true;
            }
            if(board[6] == board[4] == board[2] == "x" || "o"){
                return true;
            }
            return false;
        }
        static bool IsTie(List<string> board){
            foreach (string value in board){
                if(char.IsDigit(value[0])){
                    return false;
                }
            }
            return true;
        }
        static string GetNextPlayer(string currentPlayer){
            if(currentPlayer == "x"){
                return "o";
            }
            else{
                return "x";
            }
        }
        static int GetMoveChoice(string currentPlayer){
            Console.WriteLine(currentPlayer + "'s turn to choose a square (1-9): ");
            return Int32.Parse(Console.ReadLine());
        }

        static void MakeMove(List<string> board, int choice, string currentPlayer){
            board[choice] = currentPlayer;
        }
    }
}