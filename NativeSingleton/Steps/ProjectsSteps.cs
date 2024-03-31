using NativeSingleton.Models;
using NativeSingleton.Pages.ProjectPages;
using OpenQA.Selenium;

namespace NativeSingleton.Steps;

public class ProjectSteps : BaseSteps
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(true);

        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
        if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();

        AddProjectPage.AddButton.Click();

        return new ProjectsPage();
    }
}