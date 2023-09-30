using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WikiSearch.DAL;
using ILogger;

namespace WikiSearch.Core
{
    public class ParaSearch : SearchAbstract
    {
        string returnPara = "a";


        public string ReturnPara(IWebDriver driver)
        {
            bool flag = false;
            bool flag_;
            flag_ = Find("html>body>div>header>div>a>img", driver, 1200);
            if (flag_)
            {
                for (int i = 0; i < xPaths.paraCSS.Count; i++)
                {
                    flag = Find(xPaths.paraCSS[i], driver, 100);
                    if (flag)
                    {
                        returnPara = driver.FindElement(By.CssSelector(xPaths.paraCSS[i])).Text;
                        if (returnPara != "")
                        {
                            return returnPara;
                        }
                        flag = false;
                    }
                }
            }
            if (!flag || !flag_)
            {
                logger.Log(DateTime.Now.ToString() + "  -  " + "Could not find paragraph element");
            }
            return "Error";
        }
    }
}
