using ChessChallenge.API;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        //test commit
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }
}