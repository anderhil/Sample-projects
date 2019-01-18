using System;
using multiply.Interfaces;
using multiply.Multipliers;
using multiply.OutputFormatters;

namespace multiply
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArgumentParser parser = new ArgumentParser();
            ApplicationFacade facade = new ApplicationFacade(new DefaultMultiplier(), new IOutputFormatter[]{new CSVOutputFormatter(";"), new ConsoleOutputFormatter(), new HtmlOutputFormatter(), });
            try
            {
                parser.Parse(args);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.Write(StaticResources.Help);
                return;
            }

            try
            {
                facade.BuildMultiplyTable(parser.Rows, parser.Columns, parser.Format);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown exception");
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
