using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPlugs.Contract.Exceptions.Popup
{
    public class LoadingScopeException : Exception
    {
        public enum EExceptionType
        {
            ScopeAlreadyExist,
            ScopeNotMatched
        }

        public LoadingScopeException(EExceptionType type, string? message = null)
            : base(message)
        {
        }
    }
}
