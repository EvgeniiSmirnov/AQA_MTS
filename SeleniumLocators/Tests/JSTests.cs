using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests;

public class JSTests : BaseTest
{
    [Test]
    public void JsTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");
        
        var webElement = WaitsHelper.WaitForExists(By.CssSelector("#checkboxes input"));
        
        IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor) Driver;
        
        Thread.Sleep(2000);
        javascriptExecutor.ExecuteScript("arguments[0].click();", webElement);
        Thread.Sleep(2000);
    }

    [Test]
    public void ActionTest1()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");
        
        var source = Driver.FindElement(By.Id("column-a"));
        var target = Driver.FindElement(By.Id("column-b"));
        
        Thread.Sleep(3000);
        DragAndDropJs(source, target, Driver);
        Thread.Sleep(3000);
    }


    private void DragAndDropJs(IWebElement source, IWebElement destination, IWebDriver _driver)
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor) _driver;
        js.ExecuteScript("function createEvent(typeOfEvent) {\n"
                         + "var event =document.createEvent(\"CustomEvent\");\n"
                         + "event.initCustomEvent(typeOfEvent,true, true, null);\n"
                         + "event.dataTransfer = {\n" + "data: {},\n" + "setData: function (key, value) {\n" +
                         "this.data[key] = value;\n"
                         + "},\n" + "getData: function (key) {\n"
                         + "return this.data[key];\n" + "}\n" + "};\n" + "return event;\n" + "}\n" + "\n"
                         + "function dispatchEvent(element, event,transferData) {\n" +
                         "if (transferData !== undefined) {\n"
                         + "event.dataTransfer = transferData;\n" + "}\n" + "if (element.dispatchEvent) {\n" +
                         "element.dispatchEvent(event);\n"
                         + "} else if (element.fireEvent) {\n" + "element.fireEvent(\"on\" + event.type, event);\n" +
                         "}\n" + "}\n" + "\n"
                         + "function simulateHTML5DragAndDrop(element, destination) {\n" +
                         "var dragStartEvent =createEvent('dragstart');\n"
                         + "dispatchEvent(element, dragStartEvent);\n" + "var dropEvent = createEvent('drop');\n"
                         + "dispatchEvent(destination, dropEvent,dragStartEvent.dataTransfer);\n"
                         + "var dragEndEvent = createEvent('dragend');\n"
                         + "dispatchEvent(element, dragEndEvent,dropEvent.dataTransfer);\n" + "}\n" + "\n"
                         + "var source = arguments[0];\n" + "var destination = arguments[1];\n"
                         + "simulateHTML5DragAndDrop(source,destination);", source, destination);
    }
}