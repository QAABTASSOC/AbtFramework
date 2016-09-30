﻿using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class ToolsDropdown : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Abt Talent, Learning and Support (ATLAS)")]    
        private IWebElement Atlas;

       
        [FindsBy(How = How.LinkText, Using = "AbtKnowledge")]
        private IWebElement AbtKnowledge;

        [FindsBy(How = How.LinkText, Using = "AbtTravel Portal")]
        public IWebElement AbtTravel;

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

        public IWebElement ToolsAndResources { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Tools & Resources")); } }

        public void goTo(Abtlinks Page)
        {

            switch (Page)
            {


                case Abtlinks.EmergencyCommunications:

                    OpenServiceCenterLink("Emergency Communications");
                    break;

                case Abtlinks.Resources:

                    OpenServiceCenterLink("Resources");
                    

                    break;

                case Abtlinks.ExpertiseCenters:
                    OpenServiceCenterLink("Expertise Centers");
                    break;
                case Abtlinks.ProposalLibrary:
                    OpenServiceCenterLink("Proposal Resume Library");
                    break;
                case Abtlinks.PolicyLibrary:

                    OpenServiceCenterLink("Policy Library");
                    break;
                case Abtlinks.ImageLibraries:

                    OpenServiceCenterLink("Image Libraries");
                    break;

                case Abtlinks.FormLibrary:
                    OpenServiceCenterLink("Form Library");
                    break;

                case Abtlinks.AbtResearchLibrary:

                    OpenServiceCenterLink("Abt Research Library");

                    break;

                case Abtlinks.Travel:
                    OpenServiceCenterLink("Travel");

                    break;
                case Abtlinks.ReputationalCapital:

                    OpenServiceCenterLink("Reputational Capital");
                    break;

                case Abtlinks.OfficeServices:

                    OpenServiceCenterLink("Office Services");
                    break;

                case Abtlinks.ITServiceCenter:
                    OpenServiceCenterLink("IT Service Center");

                    break;

                case Abtlinks.HRServiceCenter:
                    OpenServiceCenterLink("HR Service Center");

                    break;

                case Abtlinks.Finance:
                    OpenServiceCenterLink("Finance");
                    break;

                case Abtlinks.CreativeServices:

                    OpenServiceCenterLink("Creative Services");
                    break;

                case Abtlinks.ContractOperations:
                    OpenServiceCenterLink("Contract Operations");

                    break;

                case Abtlinks.CTC:
                    OpenServiceCenterLink("Client Technology Center (CTC)");

                    break;
                case Abtlinks.BusinessDevelopment:
                    OpenServiceCenterLink("Business Development");
                    break;

                case Abtlinks.AbtLearn:

                    OpenServiceCenterLink("AbtLearn");
                    break;
                                
                    case Abtlinks.AbtExchange:

                    OpenMegaMenuLink("AbtXchange");
                    break;

                    case Abtlinks.Oracle:

                    OpenMegaMenuLink("Oracle");                         
                    break;

                    case Abtlinks.Abt_Talent_Learning_and_Support:

                    OpenMegaMenuLink("Abt Talent, Learning and Support (ATLAS)");                 
                    break;

                    case Abtlinks.AbtKnowledge:

                    OpenMegaMenuLink("AbtKnowledge");
                    try    //Sometimes you're not redirected to Abtknowledge directly
                    {      //and you need to click on a button that says continue to AbtKnowledge
                           //try clicking the button if is there, continue if is not.
                        SeleniumDriver.Instance.FindElement(By.Id("submitbutton")).Click();
                    }
                    catch
                    {

                    }
                    break;

                    case Abtlinks.AbtTravel:

                    OpenMegaMenuLink("AbtTravel Portal");                  
                    break;

                    case Abtlinks.ISMS:

                    OpenMegaMenuLink("ISMS");
                    break;

                    case Abtlinks.Outlook:

                    OpenMegaMenuLink("Outlook Web Access");
                    break;

                    case Abtlinks.RepCapPlanner:

                    OpenMegaMenuLink("RepCap Planner");
                    break;

                    case Abtlinks.ReputationalCapitalDB:

                    OpenMegaMenuLink("Reputational Capital Database");
                    try    //Sometimes you're not redirected to Abtknowledge directly
                    {      //and you need to click on a button that says continue to AbtKnowledge
                           //try clicking the button if is there, continue if is not.
                        SeleniumDriver.Instance.FindElement(By.Id("submitbutton")).Click();
                    }
                    catch
                    {

                    }
                    break;

            }
        }

        private void OpenServiceCenterLink(string linkText)
        {
            var StartDebugTimer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while (SeleniumDriver.Instance.Title.Equals("Home"))
            {
                try
                {
                    action.MoveToElement(ToolsAndResources).Perform();
                    Thread.Sleep(500);
                    SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch
                {

                }

            }


            Console.WriteLine("Clicking on dropdown Tools & Resources ->" + linkText);
            Console.WriteLine("</br>");
            
        }

        private void OpenMegaMenuLink(string linkText)
        {
            while (SeleniumDriver.Instance.WindowHandles.Count < 2)
            {
                try
                {
                    action.MoveToElement(ToolsAndResources).Perform();
                    Thread.Sleep(500);
                    SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch (Exception ex)
                {

                }

            }
            Console.WriteLine("Clicking on dropdown Tools & Resources -> "+linkText);
            Console.WriteLine("</br>");
            StartTimer();
            SeleniumDriver.Close();
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            SeleniumDriver.Instance.Manage().Window.Maximize();
        }

        public void GoTo_CreativeServices()
        {
            goTo(Abtlinks.CreativeServices);
        }

        public void GoTo_ContractOperations()
        {
            goTo(Abtlinks.ContractOperations);
        }

        public void GoTo_CTC()
        {
            goTo(Abtlinks.CTC);
        }

        public void GoTo_Finance()
        {
            goTo(Abtlinks.Finance);
        }

        public void GoToBusinessDevelopment()
        {
            goTo(Abtlinks.BusinessDevelopment);
        }

        public void GoTo_HRServiceCenter()
        {
            goTo(Abtlinks.HRServiceCenter);
        }

        public void GoToAbtLearn()
        {
            goTo(Abtlinks.AbtLearn);
        }

        public void GoToRepCap_Planner()
        {
            goTo(Abtlinks.RepCapPlanner);
        }

        public void GoTo_ITServiceCenter()
        {
            goTo(Abtlinks.ITServiceCenter);
        }

        public void GoToRepCapDB()
        {
            goTo(Abtlinks.ReputationalCapitalDB);
        }

        public void GoTo_OfficeServices()
        {
            goTo(Abtlinks.OfficeServices);
        }

        public void GoToAbtExchange()
        {
            goTo(Abtlinks.AbtExchange);
        }

        public void GoTo_ReputationalCapital()
        {
            goTo(Abtlinks.ReputationalCapital);
        }

        public void GoToISMS()
        {
            goTo(Abtlinks.ISMS);
        }

        public void GoTo_Concur()
        {
            goTo(Abtlinks.AbtTravel);
        }

        public void GoTo_Travel()
        {
            goTo(Abtlinks.Travel);
        }

        public void GoToAbtKnowledge()
        {
            goTo(Abtlinks.AbtKnowledge);
        }

        public void GoTo_OWA()
        {
            goTo(Abtlinks.Outlook);
        }

        public void GoTo_Oracle()
        {
            goTo(Abtlinks.Oracle);
        }

        public void GoTo_AbtResearchLibrary()
        {
            goTo(Abtlinks.AbtResearchLibrary);
        }

        public void GoToAtlas()
        {
            goTo(Abtlinks.Abt_Talent_Learning_and_Support);
        }

        public void GoTo_FormLibrary()
        {
            goTo(Abtlinks.FormLibrary);
        }

        internal void AbtTravelLink()
        {
            AbtTravel.Click();

        }

        public void GoTo_ImageLibraries()
        {
            goTo(Abtlinks.ImageLibraries);
        }

        internal void AbtKnowledgeLink()
        {
            AbtKnowledge.Click();
        }

        internal void AtlasLink()
        {
           
            Atlas.Click();
        }

        public void GoTo_PolicyLibrary()
        {
            goTo(Abtlinks.PolicyLibrary);
        }

        internal void OracleLink()
        {
            Oracle.Click();
        }

        public void GoTo_ProposalLibrary()
        {
            goTo(Abtlinks.ProposalLibrary);
        }

        internal void IsmsLink()
        {
            Isms.Click();
        }

        internal void OutlookLink()
        {
            OutlookWeb.Click();
        }

        public void GoTo_ExpertiseCenters()
        {
            goTo(Abtlinks.ExpertiseCenters);
        }

        public void GoTo_Resources()
        {
            goTo(Abtlinks.Resources);
        }

        public void GoTo_EmergencyCommunications()
        {
            goTo(Abtlinks.EmergencyCommunications);
        }
    }
}