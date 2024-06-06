using MPlugs.Contract.Exceptions.Popup;

namespace MPlugs.Popup
{
    public partial class PageLoading
    {
        private string? _scope = null;

        public void Show(string message, string scope = "")
        {
            if (_scope != null)
            {
                throw new LoadingScopeException(LoadingScopeException.EExceptionType.ScopeAlreadyExist);
            }

            _scope = scope;
        }
    }
}
