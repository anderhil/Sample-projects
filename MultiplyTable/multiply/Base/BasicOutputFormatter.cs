using System.Linq;
using multiply.Interfaces;

namespace multiply
{
    public abstract class BasicOutputFormatter : IOutputFormatter
    {
        public abstract OutputFormat Format { get; }

        protected virtual void BeginHeader()
        {
        }

        protected virtual void EndHeader()
        {
        }

        protected virtual void BeginRow(int rowNumber)
        {
        }

        protected virtual void EndRow()
        {
        }

        protected virtual void WriteHeaders(int columnsNumber)
        {
            for (int i = 1; i <= columnsNumber; i++)
            {
                WriteHeader(i);
            }
        }

        protected virtual void WriteHeader(int value)
        {
        }

        protected virtual void WriteValue(int value)
        {
        }

        protected virtual void FinishWrite()
        {
        }

        public virtual void WriteResult(int[,] matrix)
        {
            BeginHeader();
            WriteHeaders(matrix.GetLength(1));
            EndHeader();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                BeginRow(i + 1);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    WriteValue(matrix[i,j]);
                }
                EndRow();
            }
            FinishWrite();
        }
    }
}