using System;
using AlertPopUp.PopUp;
using System.Collections.Generic;
using System.Text;

namespace AlertPopUp.DoActions
{
    class Action:Base.BaseClass
    {
        public static void JsAlert()
        {
            Alert alert = new Alert(driver);
            alert.jsAlert.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickResult.Text);
            if (alert.clickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("Alert Text successful");
            }
        }
        public static void JsConfirm()
        {
            Alert alert = new Alert(driver);
            alert.jsConfirm.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickonResult.Text);
            if (alert.clickonResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Text Successful");
            }
        }
        public static void JsCancle()
        {
            Alert alert = new Alert(driver);
            alert.jsDismiss.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Dismiss();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickforResult.Text);
            if (alert.clickforResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
        public static void JsPrompt()
        {
            Alert alert = new Alert(driver);
            alert.jsDismiss.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Dismiss();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickforResult.Text);
            if (alert.Result.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }
    }
}
