using OpenQA.Selenium;
using WikiSearch.DAL;

namespace WikiSearch.Core
{
    public class TitleSearch : SearchAbstract
    {
        public bool EnterSearchbox(IWebDriver driver, string searchPrompt)
        {
            bool flag = false;

            flag = Find("html>body>div>header>div>a>img", driver, 1200);
            if (flag)
            {

                driver.FindElement(By.CssSelector("div#p-search>a")).Click();
                driver.FindElement(By.CssSelector(xPaths.searchBoxPath)).SendKeys(searchPrompt + "\n");
                return flag;
            }

            if (!flag)
            {
                logger.Log(DateTime.Now.ToString() + "  -  " + "Could not find searchbox element");
            }
            return flag;
        }
    }
}