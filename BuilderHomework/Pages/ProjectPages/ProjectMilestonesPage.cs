using OpenQA.Selenium;

namespace BuilderHomework.Pages.ProjectPages
{
    public class ProjectMilestonesPage(IWebDriver driver) : BasePage(driver)
    {
        public override bool IsPageOpened() => throw new NotImplementedException();
        protected override string GetEndpoint() => throw new NotImplementedException();
    }
}