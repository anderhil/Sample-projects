using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimalPath.Triangle
{
    /// <summary>
    /// Class Triangle represents triangle in memory
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Gets the levels.
        /// </summary>
        /// <value>The levels.</value>
        public int Levels
        {
            get { return treedata.Count; }
        }

        readonly List<TriangleRow> treedata = new List<TriangleRow>();

        /// <summary>
        /// Adds the specified triangle row of numbers
        /// </summary>
        /// <param name="triangleRow">The triangleRow</param>
        public void Add(TriangleRow triangleRow)
        {
            treedata.Add(triangleRow);
        }

        private TrianglePath FindMinimum()
        {
            //selecting last nodes as last elements for every possible path ending
            List<TrianglePath> selectedPaths = treedata[Levels - 1].Select(x => new TrianglePath(x)).ToList();
            
            int secondToLastRow = Levels - 2;

            //starting from second to last row
            for (int i = secondToLastRow; i >= 0; i--)
            {
                TriangleRow currentRow = treedata[i];

                HashSet<TrianglePath> filteredPaths = new HashSet<TrianglePath>();

                for (int j = 0; j < currentRow.Count; j++)
                {
                    //int topRowElement = currentRow[j];
                    TrianglePath chosenPath;

                    //check adjacent elements on lower triangle row
                    if (selectedPaths[j].Sum > selectedPaths[j + 1].Sum)
                    {
                        chosenPath = selectedPaths[j + 1];
                    }
                    else
                    {
                        chosenPath = selectedPaths[j];
                    }

                    //check if we have same node already connected to other element
                    if (filteredPaths.Contains(chosenPath))
                    {
                        //clone the path for new element
                        chosenPath = chosenPath.Clone();
                    }

                    filteredPaths.Add(chosenPath);
                }

                //filtering out the path which has the worse sum on every triangle row
                selectedPaths = filteredPaths.ToList();

                //pushing current row elements to the paths
                for (int j = 0; j < selectedPaths.Count; j++)
                {
                    selectedPaths[j].Push(currentRow[j]);
                }
            }

            if (selectedPaths.Count != 1)
            {
                throw new Exception("Unknown exception. Please contact support to resolve this issue.");
            }

            return selectedPaths.First();
        }

        /// <summary>
        /// Finds the minimum path in triangle
        /// </summary>
        /// <returns>TrianglePath.</returns>
        public TrianglePath FindMinimumPath()
        {
            return FindMinimum();
        }
    }
}