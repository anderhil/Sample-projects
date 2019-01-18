using MinimalPath.DataProviders;
using MinimalPath.Exceptions;

namespace MinimalPath.Triangle
{
    /// <summary>
    /// Class TriangleReader is used for reading the triangle from IDataProvider
    /// </summary>
    public class TriangleReader
    {
        private readonly IDataProvider provider;

        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleReader"/> class.
        /// </summary>
        /// <param name="provider">The provider which reads lines from different inputs</param>
        public TriangleReader(IDataProvider provider)
        {
            this.provider = provider;
        }

        /// <summary>
        /// Reads the triangle from some input as lines
        /// </summary>
        /// <returns>Triangle</returns>
        /// <exception cref="NotTriangleException"></exception>
        public Triangle ReadTriangle()
        {
            Triangle triangle = new Triangle();

            int counter = 0;
            foreach (TriangleRow row in provider.ReadTriangleLines())
            {
                if (++counter == row.Count)
                {
                    triangle.Add(row);
                }
                else
                {
                    throw new NotTriangleException();
                }
            }

            return triangle;
        }
    }

}
