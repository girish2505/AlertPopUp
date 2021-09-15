using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlertPopUp.PopUp
{
    class Alert
    {
        public Alert(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsAlert()']")]
        [CacheLookup]
        public IWebElement jsAlert;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
        
        [FindsBy(How = How.CssSelector, Using = "button[onclick = 'jsConfirm()']")]
        [CacheLookup]
        public IWebElement jsConfirm;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickonResult;

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()'")]
        [CacheLookup]
        public IWebElement jsDismiss;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickforResult;

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsPrompt()'")]
        [CacheLookup]
        public IWebElement jsPrompt;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement Result;

    }
}
