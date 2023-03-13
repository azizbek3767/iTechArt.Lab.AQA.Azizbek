using Saucedemo.Core.BrowserUtils;
using Saucedemo.Core.Elements;

namespace Saucedemo.Core.PageUtils
{
    public abstract class Page
    {
        protected Page(BaseElement uniqueElement, string pageName)
        {
            UniqueElement = uniqueElement;
        }

        public Browser Browser => BrowserService.Browser;

        private BaseElement UniqueElement { get; }

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
