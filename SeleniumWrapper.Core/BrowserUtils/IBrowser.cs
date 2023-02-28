

namespace SeleniumWrapper.Core.BrowserUtils
{
    public interface IBrowser
    {
        public bool IsStarted { get; }
        void GoToUrl(Uri uri);
        void GoToUrl(string uri);
        void Quit();
    }
}
