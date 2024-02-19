﻿using AllureReport.Core;
using AllureReport.Helpers;
using AllureReport.Helpers.Configuration;
using OpenQA.Selenium;
using AllureReport.Steps;
using NUnit.Allure.Core;
using Allure.Net.Commons;
using System.Text;

namespace AllureReport.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    public IWebDriver Driver { get; private set; }
    public WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps NavigationSteps;

    public void TakeScreenshot(string name)
    {
        Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
        byte[] screenshotBytes = screenshot.AsByteArray;

        AllureApi.Step(name);
        AllureApi.AddAttachment($"{name}", "image/png", screenshotBytes);
    }

    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        // Инициализируем Steps
        NavigationSteps = new(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        // Ïðîâåðêà, áûë ëè òåñò ñáðîøåí
        try
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                // Ñîçäàíèå ñêðèíøîòà
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                // Ïðèêðåïëåíèå ñêðèíøîòà ê îò÷åòó Allure
                // Âàðèàíò 1
                AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);

                // Âàðèàíò 2
                AllureApi.AddAttachment(
                    "data.txt",
                    "text/plain",
                    Encoding.UTF8.GetBytes("This is the file content.")
                );
                AllureApi.AddAttachment(
                    "Screenshot",
                    "image/png",
                    screenshotBytes
                );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        Driver.Quit();
    }
}