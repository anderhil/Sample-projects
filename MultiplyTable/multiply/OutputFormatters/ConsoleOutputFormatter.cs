using System;
using System.Text;

namespace multiply.OutputFormatters
{
    public class ConsoleOutputFormatter : CSVOutputFormatter
    {
        public ConsoleOutputFormatter()
        {
        }

        protected ConsoleOutputFormatter(string separator) : base(separator)
        {
        }

        public override OutputFormat Format
        {
            get { return OutputFormat.Console; }
        }

        public override string Separator { get { return " "; } }

        protected override void WriteToFile(int[,] matrix, StringBuilder builder)
        {
            Console.Write(builder.ToString());
        }
    }
}