using OpenQA.Selenium;

namespace ChainOfInvocations.Pages;

public class DashboardPage : BasePage
{
    private static string END_POINT = "index.php?/dashboard";

    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("page_title");

    // Инициализация класса
    public DashboardPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    public DashboardPage(IWebDriver driver) : base(driver) { }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("All Projects");
    }

    // Атомарные Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
}