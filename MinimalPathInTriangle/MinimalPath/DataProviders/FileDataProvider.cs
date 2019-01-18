using System.Collections.Generic;
using System.IO;

namespace MinimalPath.DataProviders
{
    /// <summary>
    /// Class FileDataProvider reads triangle from the text file input
    /// </summary>
    public class FileDataProvider : TextDataProvider
    {
        /// <summary>
        /// The file path
        /// </summary>
        private readonly string filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDataProvider"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public FileDataProvider(string filePath)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// Gets the text lines.
        /// </summary>
        /// <value>The text lines.</value>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        protected override IEnumerable<string> TextLines
        {
            get
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException(string.Format("No file at '{0}'", filePath), filePath);
                }

                return File.ReadLines(filePath);
            }
        }
    }
}