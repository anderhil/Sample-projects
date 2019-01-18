using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalPath.Triangle
{
    /// <summary>
    /// Represents row in a <see cref="Triangle"/> 
    /// </summary>
    public class TriangleRow : IEnumerable<int>
    {
        /// <summary>
        /// Gets the row element at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Int32.</returns>
        public int this[int index]
        {
            get { return rowData[index]; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleRow"/> class.
        /// </summary>
        /// <param name="triangleRow">The triangle row.</param>
        public TriangleRow(int[] triangleRow)
        {
            rowData = triangleRow;
        }

        private int[] rowData;

        /// <summary>
        /// Gets the number of elements in the row
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get { return rowData.Length; }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>) rowData).GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return rowData.GetEnumerator();
        }
    }
}
