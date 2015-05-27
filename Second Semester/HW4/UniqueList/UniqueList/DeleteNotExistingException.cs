using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    /// <summary>
    /// Exception, displayed after attempt to delete not existing value
    /// </summary>
    public class DeleteNotExistingException : ApplicationException
    {
        public DeleteNotExistingException()
        {
        }

        public DeleteNotExistingException(string message)
            : base(message)
        {
        }
    }
}
