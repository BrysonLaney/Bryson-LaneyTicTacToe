class game{
    public run(){
        bool continuegame = true;
        while(continuegame){
            Console.WriteLine($"The card is: " + card.draw(1));
            Console.WriteLine($"Higher or lower? [h/l] ");
            PlayerChoice choose = Console.ReadLine();
            Console.WriteLine($"Next card was: " + card.draw(2));
            if(card.CompareCard() = choose){
                Player.pointadd();
            }
            else{
                Player.pointsubtract();
            }
            Cosnole.WriteLine($"Your score is: " + player.points());
            Console.WriteLine("Play again? [y/n] ");
            char choice = Console.ReadLine();
            if(choice = 'y'){
                continuegame = true;
            }
            if(choice = 'n');{
                continuegame = false;
                Player.restart();
            }
        }
    }

}