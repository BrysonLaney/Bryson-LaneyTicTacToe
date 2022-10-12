class board {
    List<string> spaces = new List<string>();

    public board() {
        for (int i = 0; i <= 9; i++) {
            spaces.Add(i.ToString());
        }
    }

    public void print(){
        Console.WriteLine($"{spaces[0]}|{spaces[1]}|{spaces[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[3]}|{spaces[4]}|{spaces[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[6]}|{spaces[7]}|{spaces[8]}");
        
    }
}