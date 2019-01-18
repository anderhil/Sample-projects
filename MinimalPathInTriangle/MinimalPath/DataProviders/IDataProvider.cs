using System.Collections.Generic;
using MinimalPath.Triangle;

namespace MinimalPath.DataProviders
{
    /// <summary>
    /// Interface IDataProvider for reading triangle rows from abstract input
    /// </summary>
    public interface IDataProvider
    {
        /// <summary>
        /// Reads the triangle lines from abstract input
        /// </summary>
        /// <returns>IEnumerable&lt;TriangleRow&gt;.</returns>
        IEnumerable<TriangleRow> ReadTriangleLines();
    }
}