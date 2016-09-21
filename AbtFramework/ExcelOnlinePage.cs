﻿using OpenQA.Selenium;
using System;
using System.Threading;

namespace AbtFramework
{
    public class ExcelOnlinePage : PageModel
    {
        public void Edit()
        {
            SeleniumDriver.FiringDriver.SwitchTo().Frame("WebApplicationFrame");
            Thread.Sleep(3000);
            action.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowLeft).SendKeys(Keys.ArrowLeft)
                                           .SendKeys(Keys.ArrowLeft)
                                           .SendKeys("Added this line at: " + DateTime.Now).Perform();
        }
    }
}