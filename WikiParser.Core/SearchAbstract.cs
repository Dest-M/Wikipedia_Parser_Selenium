using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WikiSearch.DAL;
using ILogger;
using System.IO;

namespace WikiSearch.Core
{

    public class SearchAbstract
    {
        internal _ILogger logger = new FileLogger();
        internal _Paths xPaths = new _Paths();

        internal bool Find(string path, IWebDriver driver, int time)
        {
            bool flag = false;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    driver.FindElement(By.CssSelector((path)));
                    flag = true;
                    Task.Delay(time);
                    break;
                }
                catch (Exception)
                {
                    Task.Delay(time);
                    if (i == 9)
                    {

                    }
                }

            }

            return flag;
        }
    }
}
