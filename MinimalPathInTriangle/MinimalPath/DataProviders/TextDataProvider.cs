using System;
using System.Collections.Generic;
using MinimalPath.Exceptions;
using MinimalPath.Triangle;

namespace MinimalPath.DataProviders
{
    /// <summary>
    /// Class TextDataProvider is abstract provider for text based input
    /// </summary>
    public abstract class TextDataProvider : IDataProvider
    {
        /// <summary>
        /// Gets the text lines.
        /// </summary>
        /// <value>The text lines.</value>
        protected abstract IEnumerable<string> TextLines { get; }

        /// <summary>
        /// Reads the triangle lines from text input
        /// </summary>
        /// <returns>IEnumerable&lt;TriangleRow&gt;.</returns>
        /// <exception cref="NegativeNumberException"></exception>
        /// <exception cref="NotNumberException"></exception>
        public IEnumerable<TriangleRow> ReadTriangleLines()
        {
            int lineCounter = 0;
            foreach (var line in TextLines)
            {
                ++lineCounter;
                string[] splitLine = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[splitLine.Length];
                for (int i = 0; i < splitLine.Length; i++)
                {
                    int number;
                    string stringNumber = splitLine[i];
                    if (int.TryParse(stringNumber, out number))
                    {
                        if (number < 0)
                        {
                            throw new NegativeNumberException(lineCounter,stringNumber);
                        }
                        numbers[i] = number;
                    }
                    else
                    {
                        throw new NotNumberException(lineCounter, stringNumber);
                    }
                }

                yield return new TriangleRow(numbers);
            }

        }
    }
}