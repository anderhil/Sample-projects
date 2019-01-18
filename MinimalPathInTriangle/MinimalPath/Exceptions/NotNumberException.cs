using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalPath.Exceptions
{
    /// <summary>
    /// Class NotNumberException
    /// </summary>
    public class NotNumberException : ReadingException
    {
        public NotNumberException(int fileLine, string wrongValue) : base(fileLine, wrongValue)
        {
        }

        protected override string Prefix
        {
            get { return "Invalid character(s) in number"; }
        }
    }
}
