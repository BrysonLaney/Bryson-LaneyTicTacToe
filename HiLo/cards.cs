class card {
    private int card1 = 0;
    private int card2 = 0;
    public draw(int card){
        if(card = 1){
            card1 = next(1, 13);
        }
        if(card = 2){
            card2 = next(1, 13);
        }
    }
    public char CompareCard(){
        if(card1 > card2){
            return 'l';
        }
        if(card1 < card2){
            return 'h';
        }
    }
}