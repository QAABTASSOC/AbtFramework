﻿using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {

        [FindsBy(How=How.Id,Using ="PageLayoutRN")]
        private IWebElement headerInfo;
        [FindsBy(How = How.CssSelector, Using = "#PageLayoutRN > div > div:nth-child(5) > div > div.x63 > table > tbody > tr > td > h1")]
        private IWebElement OracleWelcome;
        [FindsBy(How = How.Id, Using = "usernameField")]
        private IWebElement usernameField;
        [FindsBy(How = How.Id, Using = "passwordField")]
        private IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "SubmitButton")]
        private IWebElement submitButtond;
        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody/tr[3]/td[4]/a")]
        private IWebElement iProcurementRequest;
        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody/tr[5]/td[4]/a")]
        private IWebElement abtTimeCard;
        [FindsBy(How = How.Id, Using = "ICXPOR_NONCATALOG")]
        private IWebElement nonCatalogRequest;
        [FindsBy(How = How.Id, Using = "N55")]
        private IWebElement timeEntry;
        [FindsBy(How = How.Id, Using = "HXC_TIMECARD_DIRECT")]
        private IWebElement createTimecards;
        //    time ard creation variables
        [FindsBy(How = How.Id, Using = "A241N1display")]
        private IWebElement projectTimeCardInput;
        [FindsBy(How = How.Id, Using = "A251N1display")]
        private IWebElement tasktTimeCardInput;
        [FindsBy(How = How.Id, Using = "A261N1display")]
        private IWebElement typeTimeCardInput;
        [FindsBy(How = How.Id, Using = "B22_1_0")]
        private IWebElement timeInput1;
        [FindsBy(How = How.Id, Using = "B22_1_1")]
        private IWebElement timeInput2;
        [FindsBy(How = How.Id, Using = "B22_1_2")]
        private IWebElement timeInput3;
        [FindsBy(How = How.Id, Using = "B22_1_3")]
        private IWebElement timeInput4;
        [FindsBy(How = How.Id, Using = "B22_1_4")]
        private IWebElement timeInput5;
        [FindsBy(How = How.Id, Using = "Hxcsavebutton")]
        private IWebElement reviewThenSavebutton;
        [FindsBy(How = How.Id, Using = "HxcTcReturnButton")]
        private IWebElement returnToTimeEntryButtonTimeCard;
        //
        [FindsBy(How = How.Id, Using = "Hxccuitcsaveforlater")]
        private IWebElement completeSaveTimeCardProcess;
        [FindsBy(How = How.Id, Using = "ItemDescription")]
        private IWebElement itemDescription;
        [FindsBy(How = How.Id, Using = "Quantity")]
        private IWebElement quantity;
        [FindsBy(How = How.Id, Using = "UnitOfMeasureTl")]
        private IWebElement unitOfMeasureTl;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitPrice;
        [FindsBy(How = How.Id, Using = "SupplierOnNonCat")]
        private IWebElement supplierOnNonCat;
        [FindsBy(How = How.Id, Using = "SupplierContact")]
        private IWebElement supplierContact;
        [FindsBy(How = How.Id, Using = "SupplierContactPhone")]
        private IWebElement supplierContactPhone;
        [FindsBy(How = How.Id, Using = "AddToCart_uixr")]
        private IWebElement addToCart;
        [FindsBy(How = How.Id, Using = "Checkout")]
        private IWebElement checkout;
        [FindsBy(How = How.Id, Using = "Checkout_uixr")]
        private IWebElement checkout_uixr;
        [FindsBy(How = How.Id, Using = "ProjectOnSummaryExpense")]
        private IWebElement projectOnSummaryExpense;
        [FindsBy(How = How.Id, Using = "ExpenditureTypeOnSummary")]
        private IWebElement expenditureTypeOnSummary;
        [FindsBy(How = How.Id, Using = "TaskExpense")]
        private IWebElement taskExpense;
        [FindsBy(How = How.Id, Using = "ExpenditureItemDate")]
        private IWebElement expenditureItemDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='PageButtonsRN_uixr']/tbody/tr/td[12]/button")]
        private IWebElement nextButtons;
        [FindsBy(How = How.Id, Using = "ManageGraphButton")]
        private IWebElement manageGraphButton;
        [FindsBy(How = How.Id, Using = "NewApproverText")]
        private IWebElement newApproverText;
        [FindsBy(How = How.Id, Using = "SubmitButton_uixr")]
        private IWebElement submitButton_uixr;
        [FindsBy(How = How.Id, Using = "ApproverLocation")]
        private IWebElement approverLocation;
        [FindsBy(How = How.XPath, Using = "//*[@id='PageActionButtonsBar_uixr']/tbody/tr/td[10]/button")]
        private IWebElement ApprovalNextButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='FNDDIALOGPAGE']/div/div[5]/div/table/tbody/tr[1]/td[2]/table/tbody/tr/td[2]/button")]
        private IWebElement continueShoppingButton;

        public void GoToOracleDev()
        {
            StartTimer();
            //since its a clean session we go to agi to make o
            SeleniumDriver.Instance.Navigate().GoToUrl("http://abterp.coresys.com/OA_HTML/RF.jsp?function_id=24317&resp_id=-1&resp_appl_id=-1&security_group_id=0&lang_code=US&params=L9STfOm2w4EZ6tM3VHYS0fxBFWITbHuV04R0eGLpc4BZMIc8BGgOgIirM7zywcspX.eQNlQaz5q.TkPOntW2RUVpAFgmSx5FUA3OygYZCrtEEQSZ6g3CSmpFEMEIyqi6eWfXUIsewhd5wgnkgKWk65oeR60ebhZC-2OGBqF011b3uiMOt6dVlZRFP5r2tf-y&oas=fNizNZlXjZWYl72DJSShsw..");
        }

        public bool isAt()
        {
            //Thread.Sleep(2000);
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            try
            {

                AbtFramework.AutoIT.AutoITDriver.init();
                AbtFramework.AutoIT.AutoITDriver.AceptCertificate();

            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (wait.Until(e => OracleWelcome.Displayed))
            {
                StopTimer();
                return true;
            }

            else
            {
                return false;
            }
        }
        private string GetCurrentUser()
        {
            return headerInfo.FindElement(By.TagName("div")).FindElements(By.TagName("table"))[0].FindElements(By.TagName("span"))[1].Text;
        }
        private IWebElement getHeader()
        {
           return  headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals("Oracle Applications Home Page"));
        }
        public void inputUserName()
        {
            usernameField.SendKeys("OUMSALEMS");
        }
        public void inputPasswordField()
        {
            passwordField.Clear();
            passwordField.SendKeys("Manager01m2");
        }
        public void clickSubmitButton()
        {
            submitButtond.Click();
        }
        public void clickIProcurementRequest()
        {
            Thread.Sleep(2000);
            iProcurementRequest.Click();
            Thread.Sleep(1000);
            nonCatalogRequest.Click();
        }
        public void clickTimeCard()
        {
            Thread.Sleep(2000);
            abtTimeCard.Click();
            timeEntry.Click();
            Thread.Sleep(1000);
            createTimecards.Click();
        }
        public void fillTimeCard()
        {
            projectTimeCardInput.SendKeys("10000 \r");
            tasktTimeCardInput.Click();
            Thread.Sleep(1000);
            tasktTimeCardInput.SendKeys("1011 \r");
            typeTimeCardInput.Click();
            Thread.Sleep(1000);
            typeTimeCardInput.SendKeys("Vacation");
            timeInput1.Click();
            Thread.Sleep(1000);
            timeInput1.SendKeys("8");
            timeInput2.SendKeys("8");
            timeInput3.SendKeys("8");
            timeInput4.SendKeys("8");
            timeInput5.SendKeys("8");
            Thread.Sleep(1000);
            reviewThenSavebutton.Click();
        }
        public void completeTimeCardRequest()
        {
            completeSaveTimeCardProcess.Click();
            Thread.Sleep(1000);
            returnToTimeEntryButtonTimeCard.Click();
        }
         public void fillNonCatalogRequestForm()
        {
            Thread.Sleep(2000);
            itemDescription.SendKeys("Test Description");
            quantity.SendKeys("160");
            unitOfMeasureTl.SendKeys("Hour");
            unitPrice.Click();
            Thread.Sleep(5000);
            unitPrice.SendKeys("20");
            supplierOnNonCat.SendKeys("Think Forward Consulting");
            supplierContact.Click();
            Thread.Sleep(5000);
            supplierContact.SendKeys("Test Contant Name");
            supplierContactPhone.Click();
            supplierContactPhone.SendKeys("8099880000");
            Thread.Sleep(1000);
            addToCart.Click();
            Thread.Sleep(2000);
            checkout.Click();

        }
        public void clickCheckOut()
        {
            checkout_uixr.Click();
        }
        public void fillRequisitionInformation()
        {
            Thread.Sleep(1000);
            projectOnSummaryExpense.SendKeys("21553");
            taskExpense.Click();
            Thread.Sleep(5000);
            taskExpense.SendKeys("1100");
            expenditureTypeOnSummary.Click();
            Thread.Sleep(2000);
            expenditureTypeOnSummary.SendKeys("Misc Professional Sv");
            expenditureItemDate.Click();
            Thread.Sleep(2000);
            //Console.WriteLine(DateTime.Today.ToString("dd-MMMM-yyyy"));
            expenditureItemDate.SendKeys(string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            nextButtons.Click();
        }
        public void clickManageGraphButton()
        {
            manageGraphButton.Click();
        }
        public void addBeforeApproverAndSubmit(string approver)
        {
            newApproverText.SendKeys(approver);
            
            SelectElement selector = new SelectElement(approverLocation);
            selector.SelectByText("Before Requisition Approver Controller");

            submitButton_uixr.Click();
        }

        public void addAfterApproverAndSubmit(string approver)
        {
            manageGraphButton.Click();

            newApproverText.SendKeys(approver);

            SelectElement selector = new SelectElement(approverLocation);
            selector.SelectByText("After Requisition Approver Controller");

            submitButton_uixr.Click();
            ApprovalNextButton.Click();
        }

        public void submitApproval()
        {
            submitButton_uixr.Click();
            continueShoppingButton.Click();
        }

    }
}