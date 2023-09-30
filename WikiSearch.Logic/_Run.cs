using OpenQA.Selenium;
using WikiSearch.Core;
using ILogger;

namespace WikiSearch.Logic
{
    public class RunSearch
    {
        _ILogger logger = new FileLogger();
        TitleSearch titleSearch = new TitleSearch();
        ParaSearch paraSearch = new ParaSearch();
        public string _run(IWebDriver driver, string SearchPrompt)
        {
            string text = "Error";
            try
            {

                titleSearch.EnterSearchbox(driver, SearchPrompt);
                text = paraSearch.ReturnPara(driver);
            }
            catch
            {
                logger.Log(DateTime.Now.ToString() + "  -  " + "Could not run search");
            }
            return text;
        }

    }
}