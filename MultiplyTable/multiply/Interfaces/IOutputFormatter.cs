namespace multiply.Interfaces
{
    public interface IOutputFormatter
    {
        OutputFormat Format { get; }
        void WriteResult(int[,] matrix);
    }
}