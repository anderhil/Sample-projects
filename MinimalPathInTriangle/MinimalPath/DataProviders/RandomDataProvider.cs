using System;
using System.Collections.Generic;
using System.Linq;
using MinimalPath.Triangle;

namespace MinimalPath.DataProviders
{
    /// <summary>
    /// Class RandomDataProvider for providing some random data for testing
    /// </summary>
    public class RandomDataProvider : IDataProvider
    {
        static Random randomizer = new Random();

        /// <summary>
        /// Reads the triangle lines from abstract input
        /// </summary>
        /// <returns>IEnumerable&lt;TriangleRow&gt;.</returns>
        public IEnumerable<TriangleRow> ReadTriangleLines()
        {
            for (int i = 0; i < 500; i++)
            {
                byte[] bt = new byte[i + 1];
                randomizer.NextBytes(bt);
                yield return new TriangleRow(bt.Select(x => (int)x).ToArray());
            }
        }
    }
}