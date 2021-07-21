namespace GameOfLife
{
    public interface IGameEngine
    {
        Board Board {get;}
        void NextStep();
    }
}