using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    /// <summary>
    /// Exception, displayed after attempt to add already existing value
    /// </summary>
    public class AddExistingException : ApplicationException
    {
        public AddExistingException()
        {
        }

        public AddExistingException(string message)
            : base(message)
        {
        }
    }
}
