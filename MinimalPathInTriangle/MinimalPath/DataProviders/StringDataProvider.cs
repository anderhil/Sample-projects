using System;
using System.Collections.Generic;

namespace MinimalPath.DataProviders
{
    /// <summary>
    /// Class StringDataProvider which allows to add simple string inputs
    /// </summary>
    public class StringDataProvider : TextDataProvider
    {
        private string text;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringDataProvider"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public StringDataProvider(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Gets the text lines.
        /// </summary>
        /// <value>The text lines.</value>
        protected override IEnumerable<string> TextLines
        {
            get { return text.Split(new []{Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries); }
        }
    }
}