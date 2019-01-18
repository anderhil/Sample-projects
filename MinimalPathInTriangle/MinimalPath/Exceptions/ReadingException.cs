using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalPath.Exceptions
{
    /// <summary>
    /// Class ReadingException
    /// </summary>
    public class ReadingException : ApplicationException
    {
        private int fileLine;
        private string wrongValue;

        public ReadingException(int fileLine, string wrongValue)
        {
            this.wrongValue = wrongValue;
            this.fileLine = fileLine;
        }

        protected virtual string Prefix
        {
            get { return "Wrong value"; }
        }

        public override string Message
        {
            get { return string.Format("{0} '{1}' at line {2}", Prefix, wrongValue, fileLine); }
        }
    }
}
