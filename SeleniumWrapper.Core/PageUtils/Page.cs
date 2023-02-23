using SeleniumWrapper.Core.BrowserUtils;
using SeleniumWrapper.Core.Elements;

namespace SeleniumWrapper.Core.PageUtils
{
    public abstract class Page
    {
        protected Page(BaseForm uniqueElement, string pageName)
        {
            UniqueElement = uniqueElement;
        }

        public Browser Browser => BrowserService.Browser;

        private BaseForm UniqueElement { get; }

        public bool IsPageOpened()
        {
            return UniqueElement.IsDisplayed();
        }

        public void WaitForPageOpened()
        {
            throw new NotImplementedException();
        }
    }
}
