using System.IO;
using System.Linq;
using System.Text;

namespace multiply
{
    public abstract class FileOutputFormatter : BasicOutputFormatter
    {
        protected StringBuilder _builder = new StringBuilder();

        public string OutputString { get; private set; }

        protected virtual void WriteToFile(int[,] matrix, StringBuilder builder)
        {
            var fileName = string.Format("multiply_{0}_{1}.{2}", matrix.GetLength(0), matrix.GetLength(1), Format.ToString().ToLowerInvariant());
            OutputString = builder.ToString();
            File.WriteAllText(fileName, OutputString);
        }

        public override void WriteResult(int[,] matrix)
        {
            base.WriteResult(matrix);
            WriteToFile(matrix, _builder);
        }
    }
}