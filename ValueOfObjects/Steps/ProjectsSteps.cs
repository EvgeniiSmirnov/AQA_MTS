using OpenQA.Selenium;
using ValueOfObjects.Models;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps;

public class ProjectSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);

        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
        if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();

        AddProjectPage.AddButton.Click();

        return new ProjectsPage(Driver);
    }

    internal object GetCell(string v1, string projectName, string v2)
    {
        throw new NotImplementedException();
    }
}