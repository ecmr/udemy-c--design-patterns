namespace BuilderPattern
{
    class Director
    {
        public void Build(IDatabaseBuilder Builder)
        {
            Builder.BuildConnection();
            Builder.BuildCommand();
            Builder.SetSettings();
        }
    }
}