class Player{
    private int points = 300;
    public char PlayerChoice(char chocie){
        if(chocie = 'h'){
            return 'h';
        }
        if(chocie = 'l'){
            return 'l';
        }
    }
    public int Points(){
        return points;
    }
    public Pointadd(int add){
        points += add;
    }
    public Pointsubtract(int subtract){
        points -= subtract;
    }

    public bool ContineGame(char choice){
        if(choice ='y'){
            return true;
        }
        if(choice = 'n'){
            return false;
        }
        return false;
    }
    public restart(){
        points = 300;
    }
}