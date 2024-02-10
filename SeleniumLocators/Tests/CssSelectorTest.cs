using OpenQA.Selenium;

namespace SeleniumLocators.Tests;

public class CssSelectorTest : BaseTest
{
    [Test]
    public void CssSelectorsTest() {
        Driver.Navigate().GoToUrl("file:/Users/aleksandr.trostyanko/Documents/Work/TeachMeSkills/Code/CSharp/AQA_MTS/Locators/Resources/index.html");

        // Поиск по id
        Assert.That(Driver.FindElement(By.CssSelector("#my-Address")).Displayed);

        // Поиск по class name
        Assert.That(Driver.FindElement(By.CssSelector(".newsletter")).Displayed);

        // Поиск по нескольким значения в аттрибуте class
        Assert.That(Driver.FindElement(By.CssSelector(".noSel.newsletter")).Displayed);

        // Поиск по tag name
        Assert.That(Driver.FindElement(By.CssSelector("h1")).Displayed);

        // Поиск по tag и значению из аттрибута class
        Assert.That(Driver.FindElement(By.CssSelector("div.intro")).Displayed);

        // Поиск по tag и значению из аттрибута class
        Assert.That(Driver.FindElements(By.CssSelector("#Lastname .markup")).Count, Is.EqualTo(2));

        // Поиск всех элементов с тэгом h1 или p
        Assert.That(Driver.FindElements(By.CssSelector("h1, p")).Count, Is.EqualTo(8));

        // Поиск всех элементов с тэгом p у которых непосредственный родитель с тэгом div
        Assert.That(Driver.FindElements(By.CssSelector("div > p")).Count, Is.EqualTo(6));

        // Поиск всех элементов с тэгом p которые идут сразу за элементом с тэго ul
        Assert.That(Driver.FindElements(By.CssSelector("ul + p")).Count, Is.EqualTo(1));

        // Поиск всех элементов с тэгом div которые являются братьями элементу с тэгом p
        Assert.That(Driver.FindElements(By.CssSelector("p ~ div")).Count, Is.EqualTo(2));

        // Поиск всех элементов у которых присутствует аттрибут title
        Assert.That(Driver.FindElements(By.CssSelector("[title]")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут style с конкретным значением
        Assert.That(Driver.FindElements(By.CssSelector("[style='overflow: auto;']")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут id со значением заканчивающимся на какое-то value
        Assert.That(Driver.FindElements(By.CssSelector("[id$='ess']")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут id со значением начинающимся на какое-то слово
        Assert.That(Driver.FindElements(By.CssSelector("[id|=my]")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут id со значением начинающимся на какое-то value
        Assert.That(Driver.FindElements(By.CssSelector("[id^=L]")).Count, Is.EqualTo(2));

        // Поиск всех элементов у которых присутствует аттрибут title со значением содержащим слово целиком
        Assert.That(Driver.FindElements(By.CssSelector("[title~=beautiful]")).Count, Is.EqualTo(1));

        // Поиск всех элементов у которых присутствует аттрибут title со значением содержащим какой текст
        Assert.That(Driver.FindElements(By.CssSelector("[title*=beaut]")).Count, Is.EqualTo(1));

        // Поиск всех disabled элементов
        Assert.That(Driver.FindElements(By.CssSelector(":disabled")).Count, Is.EqualTo(1));

        // Поиск всех enabled элементов
        Assert.That(Driver.FindElements(By.CssSelector(":enabled")).Count, Is.EqualTo(8));

        // Поиск всех выборанных элементов
        Assert.That(Driver.FindElements(By.CssSelector(":checked")).Count, Is.EqualTo(2));

        // Поиск всех элементов c пустым телом
        Assert.That(Driver.FindElements(By.CssSelector(":empty")).Count, Is.EqualTo(16));

        // Поиск элемента с тэгом p и которым является первым дочерним элементом
        Assert.That(Driver.FindElements(By.CssSelector("p:first-child")).Count, Is.EqualTo(1));

        // Поиск элемента с тэгом p и которым является последним дочерним элементом
        Assert.That(Driver.FindElements(By.CssSelector("p:last-child")).Count, Is.EqualTo(2));

        // Поиск элемента с тэгом p и которым является n-ым дочерним элементом
        Assert.That(Driver.FindElements(By.CssSelector("p:nth-child(2)")).Count, Is.EqualTo(1));
    }
}