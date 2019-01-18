using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalPath.DataProviders;
using MinimalPath.Triangle;

namespace MinimalPath
{
    /// <summary>
    /// Class AppFacade represents methods that run the whole process
    /// </summary>
    public class AppFacade
    {
        /// <summary>
        /// Runs the minimum path finding.
        /// </summary>
        /// <param name="dataProvider">The data provider.</param>
        /// <returns>TrianglePath.</returns>
        public TrianglePath RunMinimumPathFinding(IDataProvider dataProvider)
        {
            TriangleReader triangleReader = new TriangleReader(dataProvider);

            Triangle.Triangle triangle = triangleReader.ReadTriangle();

            TrianglePath trianglePath = triangle.FindMinimumPath();

            return trianglePath;
        }
    }
}
