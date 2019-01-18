using System;
using System.Linq;

namespace multiply
{
    public class ArgumentParser
    {
        private string[] _args;

        public ArgumentParser()
        {
        }

        public void Parse(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                throw new ArgumentException(StaticResources.NoArguments);
            }

            int row, columns = 0;
            OutputFormat format = OutputFormat.Console;
            if (!int.TryParse(args.First(), out row))
            {
                throw new ArgumentException(StaticResources.RowArgument);
            }

            if (args.Length == 2)
            {
                string colOrOutput = args[1];

                if (!int.TryParse(colOrOutput, out columns) && !Enum.TryParse<OutputFormat>(colOrOutput, true, out format))
                {
                    throw new ArgumentException(StaticResources.SecondArgument);
                }
            }
            if (args.Length == 3)
            {
                string column = args[1];
                string output = args[2];
                if (!int.TryParse(column, out columns))
                {
                    throw new ArgumentException(StaticResources.ColumnArgument);
                }
                if (!Enum.TryParse<OutputFormat>(output, true, out format))
                {
                    throw new ArgumentException(StaticResources.FormatArgument);
                }
            }

            Rows = row;

            columns = columns == 0 ? Rows : columns;

            Columns = columns;

            Format = format;

            if (Rows < 1 || Rows > 20 || Columns < 1 || Columns > 20)
            {
                throw new ArgumentOutOfRangeException(StaticResources.OutOfRange);
            }
        }

        public int Rows
        {
            get; set;
        }

        public int Columns
        {
            get; set;
        }

        public OutputFormat Format
        {
            get; set;
        }
    }
}