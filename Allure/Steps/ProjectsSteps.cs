using OpenQA.Selenium;
using Wrappers.Pages;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Steps;

public class ProjectsSteps : BaseSteps
{
    public ProjectsSteps(IWebDriver driver) : base(driver)
    {
        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        DashboardPage dashboardPage = new DashboardPage(Driver);
    }

    public void AddProductToCart(List<string> Products)
    {
        new NavigationSteps(Driver).NavigateToProducts();


        // Пройтись по всей коллекции и найти эелементы на странице
        // Нажать кнопку Добавить для каждого элемента
    }

    public void CreateProject()
    {

    }

    public void UpdateProject()
    {

    }

    public void ReadProject()
    {

    }

    public void DeleteProject()
    {

    }
}