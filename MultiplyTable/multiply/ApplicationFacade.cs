using System.Collections.Generic;
using multiply.Interfaces;

namespace multiply
{
    /// <summary>
    /// Class that aggregates all the application logic inside
    /// </summary>
    public class ApplicationFacade
    {
        readonly Dictionary<OutputFormat, IOutputFormatter> _formattersDictionary = new Dictionary<OutputFormat, IOutputFormatter>();
        private readonly IMultiplier _multiplier;

        public ApplicationFacade(IMultiplier multiplier, IEnumerable<IOutputFormatter> formatters)
        {
            _multiplier = multiplier;
            foreach (IOutputFormatter outputFormatter in formatters)
            {
                _formattersDictionary.Add(outputFormatter.Format, outputFormatter);
            }
        }

        public void BuildMultiplyTable(int rows, int cols, OutputFormat format)
        {
            if (_formattersDictionary.ContainsKey(format))
            {
                int[,] resultMatrix = _multiplier.BuildMultiplierTable(rows, cols);
                _formattersDictionary[format].WriteResult(resultMatrix);
            }
        }
    }
}