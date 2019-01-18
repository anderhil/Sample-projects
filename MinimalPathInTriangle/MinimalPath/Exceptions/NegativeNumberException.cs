using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalPath.Exceptions
{
    /// <summary>
    /// Class NegativeNumberException
    /// </summary>
    public class NegativeNumberException : ReadingException
    {
        public NegativeNumberException(int fileLine, string wrongValue) : base(fileLine, wrongValue)
        {
        }

        protected override string Prefix
        {
            get { return "Negative number"; }
        }
    }
}
