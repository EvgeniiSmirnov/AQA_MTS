using OpenQA.Selenium;
using SeleniumLocators.Helpers.Configuration;

namespace SeleniumLocators.Tests;

public class XPathSelectors : BaseTest
{
    private static String absolutePath = "/html/body/div";

    private static String allElementsInHTMLPath = "//*"; // Все элементы на странице начиная с html - тэга

    private static String bodyPath = "//body"; // Элемент по тэгу

    private static String childPath = "//form/input"; // Дочерний элемент относительно родителя

    private static String tagWithAttrPath = "//span[@id='access--1']"; // Поиск элемента с аттрибутом и его значением

    private static String
        parentPath1 = "//span[@id='access--1']//.."; // Поиск родителя у элемента с аттрибутом и его значением

    private static String
        parentPath2 =
            "//*[@id='suite_mode_single']/parent::label;"; // Поиск родителя у элемента с аттрибутом и его значением

    private static String elementByIndeXPath = "(//form)[4]"; // Поиск элемента по индексу

    private static String
        searchByTextPath = "//*[text()='New Widget']"; // Поиск элемента по полному соответствию по тексту

    private static String searchByTextPath1 = "//*[.='New Widget']"; // Поиск элемента по полному соответствию по тексту

    private static String
        searchBySubstringPath = "//*[contains(text(),'Widget')]"; // Поиск элемента по подстроке в тексте

    private static String
        searchByStartsWithPath =
            "//input[starts-with(@type, 'hi')]"; //Поиск элемента по аттрибуту значение которого начинается с

    private static String
        searchByTwoAttrPath = "//*[@class='form-control ' and @type='text']"; // Использование логического оператора

    private static String
        searchBySpecificAttrPath = "//input[@type != 'hidden']"; // Использование логического оператора

    //Axes - Оси
    //Использование ancestor - все предки текущего узла
    private static String path1 = "//*[@id='suite_mode_single_baseline']/ancestor::div";

    //Использование child - все предки текущего узла зависят от уровня
    private static String path2_1 = "//ul/child::li";
    private static String path2_2 = "//ul/li"; // аналог только проще

    //Использование descendant - Все предки текущего узла не зависимо от уровня
    private static String path3_1 = "//ul/descendant::span";
    private static String path3_2 = "//ul//span"; // аналог только проще

    //Использование following - Выбирает всё в документе после закрытия тэга текущего узла
    private static String path4_1 = "//label[@for='announcement']/following::form";
    private static String path4_2 = "(//label[@for='announcement']/following::div/*[@class='checkbox'])[1]";

    //Использование following-sibling - Выбирает все узлы одного уровня после текущего узла
    private static String path5_1 = "//label[@for='announcement']/following-sibling::div";

    //Использование preceding- Выбирает все узлы, которые появляются перед текущим узлом в документе
    private static String path6_1 = "//label[@for='announcement']/preceding::div";

    //Использование preceding-sibling - Выбирает все узлы одного уровня до текущего узла
    private static String path7_1 = "//label[@for='announcement']/preceding-sibling::div";

    [Test]
    public void BasicXPathSelectors()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        // Абсолютный XPath
        Assert.That(Driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/div[1]/div/div[2]")).Displayed);

        // Все эелемнты на странице начина с HTML
        Driver.FindElements(By.XPath("//*"));

        // Аналог поиска по tagName
        Assert.That(Driver.FindElement(By.XPath("//h1")).Displayed);

        // Аналог родительского div и на один уровень ниже р1
        Assert.That(Driver.FindElement(By.XPath("//div/h1")).Displayed);

        // Аналог родительского div и на любом уровене ниже div
        Assert.That(Driver.FindElement(By.XPath("//div//div")).Displayed);

        // Поиск элемента с тэгом div у которого есть аьттрибут id
        Assert.That(Driver.FindElement(By.XPath("//div[@id]")).Displayed);

        // Поиск элемента у которого есть аттрибут id cо значением top-logo
        Assert.That(Driver.FindElement(By.XPath("//*[@id = 'top-logo']")).Displayed);

        // Поиск элемента у которого есть аттрибут method cо значением и фттрибут target со значением
        Assert.That(Driver.FindElement(By.XPath("//*[@method='post' and @target='_blank']")).Displayed);

        // Поиск элемента у которого значение аттрибута начинается с
        Assert.That(Driver.FindElement(By.XPath("//*[starts-with(@id, 'new')]")).Displayed);

        // Поиск элемента у которого значение аттрибута содержит подстроку
        Assert.That(Driver.FindElement(By.XPath("//div[contains(@id, 'Template')]")).Displayed);

        // Поиск элемента у которого текстовое значение содержит равно
        Assert.That(Driver.FindElement(By.XPath("//div[text() = 'All Projects']")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[. = 'Todos']")).Displayed);

        // Поиск элемента у которого текстовое значение содержит подстроку
        Assert.That(Driver.FindElement(By.XPath("//*[contains(text(), 'All Projects')]")).Displayed);

        // Поиск элемента по индексу
        Assert.That(Driver.FindElement(By.XPath("//div[@class = 'summary-links text-secondary']/a[2]"))
            .Displayed);
    }

    [Test]
    public void AxesXPathTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        // Поиск родителя у элемента с тэгом h1
        Assert.That(Driver.FindElement(By.XPath("//h1/..")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//h1/parent::div")).Displayed);

        // Поиск всех предков с тэгом div у элемента с тэгом h1
        Assert.That(Driver.FindElement(By.XPath("//h1/ancestor::div")).Displayed);

        // Использование child - все дочерние элементы с тэго a от div
        Assert.That(Driver.FindElement(By.XPath("//div/child::a")).Displayed);

        // Использование child - все дочерние элементы с тэго a от div
        Assert.That(Driver.FindElement(By.XPath("//div/descendant::a")).Displayed);

        //Использование following - Выбирает всё в документе после закрытия тэга текущего узла
        Assert.That(Driver.FindElement(By.XPath("//*[@class='dialog-title']/following::form")).Displayed);

        //Использование following-sibling - Выбирает все узлы одного уровня после текущего узла
        Assert.That(Driver.FindElement(By.XPath("//*[@class='dialog-title']/following-sibling::form"))
            .Displayed);

        //Использование preceding- Выбирает все узлы, которые появляются перед текущим узлом в документе
        Assert.That(Driver.FindElement(By.XPath("//*[@class=\"dialog-title\"]/preceding::form")).Displayed);

        //Использование preceding-sibling - Выбирает все узлы одного уровня до текущего узла
        Assert.That(Driver.FindElement(By.XPath("//*[@class='dialog-title']/preceding-sibling::form"))
            .Displayed);
    }
}