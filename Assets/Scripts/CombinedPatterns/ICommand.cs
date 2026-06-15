namespace Combined
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
