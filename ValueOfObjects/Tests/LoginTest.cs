using NUnit.Framework;
using ValueOfObjects.Helpers.Configuration;
using ValueOfObjects.Pages;

namespace ValueOfObjects.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).SidebarProjectsAddButton.Displayed);
    }
}