using OpenQA.Selenium;

namespace SeleniumLocators.Tests;

public class CssSelectors
{
    private void Selectors()
    {
        By classSelector = By.CssSelector(".radio"); //Поиск по классу radio
        By classSelector1 = By.ClassName("radio"); //Поиск по классу radio

        By idSelector = By.CssSelector("#suite_mode_single"); //Поиск по id
        By idSelector1 = By.Id("#suite_mode_single"); //Поиск по id

        By tagSelector = By.CssSelector("label"); //Поиск по tag
        By tagSelector1 = By.TagName("label"); //Поиск по tag

        By tagAttributeSelector = By.CssSelector("label[for='name']"); //Поиск по tag и аттрибуту с значением
        By tagAttributeSelector1 = By.CssSelector("label[for]"); //Поиск по tag и присутсвием аттрибута

        By multipleClassesSelector = By.CssSelector(".column.overflow-content"); //Поиск по двум классам в элементе
        By simpleHierarchicalSelector = By.CssSelector(".table .content-inner"); //Поиск простого дочернего элемента

        By fullHierarchicalSelector =
            By.CssSelector(
                "body .table .content-inner"); //Использование 3х уровневой иерархии для поиска дочернего элемента

        By searchLikeContainsSelector =
            By.CssSelector("form[action*='admin']"); //Поиск с вхождением подстроки в значении аттрибута
        By searchByWordSelector =
            By.CssSelector("div[class~='column']"); //Поиск с вхождением слова в значении аттрибута

        By valueStartsFromSelector =
            By.CssSelector("a[href^='https://']"); //Поиск элемента с аттрибутом значение которого начинается с

        By valueEndsWithSelector =
            By.CssSelector("a[href$='@gmail.com']"); //Поиск элемента с аттрибутом значение которого аканчивается на

        By childRightAfterParentSelector = By.CssSelector("ul>li"); //Поиск дочернего li у которого родитель ul

        By elementRightAfterElementSelector =
            By.CssSelector("form+script"); //Поиск элемента script который идет сразу после элемента #form
        By elementOnTheSameLevelSelector =
            By.CssSelector("form~script"); //Поиск элемента script которым предшествует элемент #form

        By firstChildSelector = By.CssSelector("li:first-child"); //Поиск 1го дочернего элемента
        By lastChildSelector = By.CssSelector("li:last-child"); //Поиск последнего дочернего элемента
        By nthChildFromBeginSelector = By.CssSelector("li:nth-child(2)"); //Поиск n-го дочернего элемента с начала
        By nthChildFromEndSelector = By.CssSelector("li:nth-last-child(3)"); //Поиск n-го дочернего элемента с конца
    }
}