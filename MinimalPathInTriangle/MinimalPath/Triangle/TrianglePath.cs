using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MinimalPath.Triangle
{
    /// <summary>
    /// Represents path in <see cref="Triangle"/> 
    /// </summary>
    public class TrianglePath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrianglePath"/> class.
        /// </summary>
        public TrianglePath()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrianglePath"/> class.
        /// </summary>
        /// <param name="initialValue">The initial value.</param>
        public TrianglePath(int initialValue)
        {
            Push(initialValue);
        }

        private Stack<int> pathData = new Stack<int>();

        /// <summary>
        /// Gets the sum of the path elements
        /// </summary>
        /// <value>The sum.</value>
        public int Sum { get; private set; }

        /// <summary>
        /// Pushes the specified node to the path
        /// </summary>
        /// <param name="node">The node.</param>
        public void Push(int node)
        {
            pathData.Push(node);
            Sum += node;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(pathData.Count * 2);
            builder.Append("path is: ");
            foreach (int node in pathData)
            {
                builder.Append(node).Append(" + ");
            }
            builder.Length = builder.Length - 2;
            builder.AppendFormat("= {0}", Sum);

            return builder.ToString();
        }

        public TrianglePath Clone()
        {
            var tPath = new TrianglePath();
            tPath.pathData = new Stack<int>(pathData.Reverse());
            tPath.Sum = Sum;
            return tPath;
        }
        
    }
}