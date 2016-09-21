﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class ToolsAndResourcesPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "WebPartCaptionWPQ4")]
        private IWebElement LibrariesHeader;

        [FindsBy(How = How.LinkText, Using = "ATLAS (Abt Talent, Learning, and Support)")]
        private IWebElement Atlas;


        [FindsBy(How = How.LinkText, Using = "AbtKnowledge")]
        private IWebElement AbtKnowledge;

        [FindsBy(How = How.LinkText, Using = "AbtTravel Portal")]
        private IWebElement AbtTravel;

        [FindsBy(How = How.LinkText, Using = "Oracle")]
        private IWebElement Oracle;

        [FindsBy(How = How.LinkText, Using = "ISMS")]
        private IWebElement Isms;

        [FindsBy(How = How.LinkText, Using = "Outlook Web Access")]
        private IWebElement OutlookWeb;

        [FindsBy(How = How.LinkText, Using = "RepCap Planner")]
        private IWebElement RepCapLink;

        [FindsBy(How = How.LinkText, Using = "Reputational Capital Database")]
        private IWebElement repCapDBPageLink;

        private void goTo(Abtlinks Page)
        {
            switch (Page)
            {
                case Abtlinks.Oracle: 
                    StartTimer();
                    Oracle.Click();
                    wait.Until(d => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.Abt_Talent_Learning_and_Support:

                   // StartTimer();
                    OpenWindowFor(Atlas);
                    SingleSignOnProvider = "Simieo";
                    Environment = "Production";
                   
                  

                    break;

                case Abtlinks.AbtKnowledge: 
                    StartTimer();
                    wait.Until(d => this.AbtKnowledge.Displayed);
                    AbtKnowledge.Click();
                    wait.Until(d => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    SeleniumDriver.FiringDriver.FindElement(By.Id("submitbutton")).Click(); //a windows pop up with a btn "continue to abtKnowledge" finding the element withouth page factory 
                    StopTimer(); 

                    break;

                case Abtlinks.AbtTravel:  
                    StartTimer();
                    wait.Until(d => this.AbtTravel.Displayed);
                    AbtTravel.Click();
                    wait.Until(d => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.ISMS:

                    Isms.Click();
                    StartTimer();
                    break;

                case Abtlinks.Outlook: 
                    StartTimer();
                    OutlookWeb.Click();
                    wait.Until(d => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.RepCapPlanner: 
                    StartTimer();
                    RepCapLink.Click();
                    wait.Until(d => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.ReputationalCapitalDB: 
                    StartTimer();
                    OpenWindowFor(repCapDBPageLink);
                    try
                    {
                        AbtPages.AbtKnowledgePage.ContinueToAbtKnowledge();
                    }
                    catch (Exception e)
                    {

                    }
                    break;

            }

        }

        public void GoToRepCapDB()
        {
            goTo(Abtlinks.ReputationalCapitalDB);
        }

        public void GoToIsms()
        {
            goTo(Abtlinks.ISMS);
        }

        private void OpenWindowFor(IWebElement link)
        {
            finder = new PopupWindowFinder(SeleniumDriver.FiringDriver);
            popupWindowHandle = finder.Click(link);
         //   var currentHandler = SeleniumDriver.Instance.CurrentWindowHandle;
         //   Console.WriteLine("This is the first popwindowHandle:");
          //  Console.WriteLine(currentHandler);
            wait.Until(d => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
            StartTimer();
            SeleniumDriver.FiringDriver.SwitchTo().Window(popupWindowHandle);
            SeleniumDriver.FiringDriver.Manage().Window.Maximize();
        }

        public void GoToAtlas()
        {
            goTo(Abtlinks.Abt_Talent_Learning_and_Support);
        }

        public bool isAt()
        {
            
                if (LibrariesHeader.Enabled)
                {
                   
                    return true;
                }
                        
            return false;
        }

       
    }
}