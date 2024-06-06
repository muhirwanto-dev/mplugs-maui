using MPlugs.Contract.Enums;

namespace MPlugs.Contract.Exceptions.Popup
{
    public class PageLoadingException : Exception
    {
        public ELoadingExceptionType ExceptionType { get; }

        public PageLoadingException(ELoadingExceptionType type, string? message = null)
            : base(message)
        {
            ExceptionType = type;
        }
    }
}
