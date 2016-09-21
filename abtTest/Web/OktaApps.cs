﻿using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;

namespace abtTest.Web
{

    public class OktaApps
    {

      //  [Fact(DisplayName = "Should Go to WeSpire Home Page using Okta")]
        public void Should_Go_to_WeSpire_Test_HomePage() //no access
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.WeSpireHomePage.isAt());
            SeleniumDriver.Close();

        }

     //   [Fact(DisplayName = "Should Go to WeSpire Home Page using Simieo")]
        public void Should_Go_to_WeSpire_Production_HomePage() //Done
        {
            SeleniumDriver.RemoteInit();
            AbtPages.WeSpireHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.WeSpireHomePage.isAt());
            SeleniumDriver.Close();
        }

     //   [Fact(DisplayName = "Should Go to Ebsco UAT Home Page")]
        public void Should_Go_to_Ebsco_Test_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.EbscoHomePage.Go(WebEnvironment.TestEnvironment);
            AbtPages.EbscoHomePage.GoToMyAccount();
            Assert.True(AbtPages.EbscoMyAccountPage.IsUserLoggedIn());

        }

      //  [Fact(DisplayName = "Should Go to Ebsco Production Home Page")]
        public void Should_Go_to_Ebsco_Production_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.EbscoHomePage.Go(WebEnvironment.ProductionEnvironment);
            AbtPages.EbscoHomePage.GoToMyAccount();
            Assert.True(AbtPages.EbscoMyAccountPage.IsUserLoggedIn());

        }


       // [Fact(DisplayName = "Should Go to Success Factor (Test) Home Page")]
        public void Should_Go_to_SuccessFactor_Test_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.WeSpireHomePage.GoWithNoOutputResult();
            AbtPages.SuccessFactorHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.SuccessFactorHomePage.isUserLoggedIn());
            SeleniumDriver.Close();
            
        }

      //  [Fact(DisplayName = "Should Go to Success Factor Production Home Page")]
        public void Should_Go_to_SuccessFactor_Production_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.SuccessFactorHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.SuccessFactorHomePage.isUserLoggedIn());
            SeleniumDriver.Close();
        }

         //Wants to go Trough AGI???
      //  [Fact(DisplayName = "Should Go to AbtKnowledge Production Home Page")]
        public void Should_Go_to_AbtKnowledge_Production_HomePage()
        {
            SeleniumDriver.RemoteInitDavidsPc(Browser.IE);
            AbtPages.AbtKnowledgePage.Go();
           Assert.True(AbtPages.AbtKnowledgePage.IsUserLoggedIn());
        }


     //   [Fact(DisplayName = "Should Go to BCD Travel Portal Production Home Page")]
        public void Should_Go_to_BCD_Travel_Production_HomePage()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AbtTravelPage.Go();
            Assert.True(AbtPages.AbtTravelPage.isUserLoggedIn());
        }


     // [Fact(DisplayName = "Should Go to Concur UAT Home Page using Okta")]
        public void Should_Go_to_Concur_Testing_HomePage()
        {
            SeleniumDriver.RemoteInit();
            AbtPages.ConcurHomePage.Go();
             Assert.True(AbtPages.ConcurHomePage.isUserLoggedIn());
            SeleniumDriver.Close();

        }

     //   [Fact(DisplayName = "Should Go to Concur Production Home Page using Simieo")]
        public void Should_Go_to_Concur_Production_HomePage()
        {
            SeleniumDriver.RemoteInit();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HoverOverTools();
            AbtPages.AbtTravelPage.HoverOverAbtTravelOnline();
            AbtPages.AbtTravelPage.AbtTravelOnlineDropdown.BookOrSearchUsTravel();
            
            Assert.True(AbtPages.ConcurHomePage.isUserLoggedIn());
            SeleniumDriver.Close();

        }

       //   [Fact(DisplayName = "Should Go to Right Find UAT Home Page")]
        public void Should_Go_to_RightFind_Test_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.RightFindHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.RightFindHomePage.IsUserLoggedIn());

        }

      //  [Fact(DisplayName = "Should Go to Right Find Production Home Page")]
        public void Should_Go_to_RightFind_Production_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
           AbtPages.RightFindHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.RightFindHomePage.IsUserLoggedIn());
        }

      //  [Fact(DisplayName = "Should Go to Oracle Production Home Page")]
        public void Should_Go_to_Oracle_Production_HomePage()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiHomePage.QuickLinks.GoTo(quickLinks.Oracle);
            Assert.True(AbtPages.OraclePage.isAt());

        }

      //  [Fact(DisplayName = "Should Go to Rep Cap Database Production Home Page")]
        public void Should_Go_to_RepCapDatabase_Production_HomePage()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.ReputationalCapDBPage.Go();
            Assert.True(AbtPages.ReputationalCapDBPage.isUserLoggedIn());
        }

     //   [Fact(DisplayName = "Should Go to Rep Cap Planner Production Home Page")]
        public void Should_Go_to_RepCapPlanner_Production_HomePage()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.RepCapPlannerPage.Go();
            Assert.True(AbtPages.RepCapPlannerPage.isUserLoggedIn());
        }

       // [Fact(DisplayName = "Should Go to Service Now UAT Home Page")]
        public void Should_Go_to_ServiceNow_UAT_HomePage()
        {
            SeleniumDriver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.ServiceNowHomepage.isUserLoggedIn());
        }

      // [Fact(DisplayName = "Should Go to Service Now Production Home Page")]
        public void Should_Go_to_ServiceNow_Production_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.ServiceNowHomepage.isUserLoggedIn());
        }

       [Fact(DisplayName = "Should Go to WebEx UAT Home Page")]
        public void Should_Go_to_WebEx_Test_HomePage()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.WebExPage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.WebExPage.isAt());

        }

        [Fact(DisplayName = "Should Go to WebEx Production Home Page")]
        public void Should_Go_to_WebEx_Production_HomePage()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.WebExPage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.WebExPage.isAt());
        }

       // [Fact(DisplayName ="Should Go to Success Factor (Production) Through AGI")]
        public void Should_Go_SuccessFactor_Through_Agi()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsAndResources();
           AbtPages.ToolsAndResourcesPage.GoToAtlas();
            AbtPages.SuccessFactorHomePage.isUserLoggedIn();
            SeleniumDriver.CloseAll();
        }

    }
}
