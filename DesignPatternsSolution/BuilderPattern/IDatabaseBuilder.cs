namespace BuilderPattern
{
    public interface IDatabaseBuilder
    {
        void BuildCommand();
        void BuildConnection();
        void SetSettings();
        Database Database { get; }
    }
}