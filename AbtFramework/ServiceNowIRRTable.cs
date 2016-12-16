﻿using OpenQA.Selenium;
using System;

namespace AbtFramework
{
    public class ServiceNowIRRTable : PageModel
    {
        public bool IRRExists(string IncidentReportId)
        {
            try
            {
                
                IWebElement IRR = SeleniumDriver.Instance.FindElement(By.LinkText(IncidentReportId));
                IRR.Click();
                return true;   
              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        
        }
    }
}