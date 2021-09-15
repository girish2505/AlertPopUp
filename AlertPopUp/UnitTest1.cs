using NUnit.Framework;

namespace AlertPopUp
{
    public class Tests : Base.BaseClass
    {
        [Test, Order(0)]
        public void test_alert()
        {
            DoActions.Action.JsAlert();

        }
        [Test, Order(1)]
        public void test_confirm()
        {
            DoActions.Action.JsConfirm();
        }
        [Test, Order(2)]
        public void test_Dismiss()
        {
            DoActions.Action.JsCancle();
        }
        [Test, Order(3)]
        public void test_Prompt()
        {
            DoActions.Action.JsPrompt();
        }
    }
}