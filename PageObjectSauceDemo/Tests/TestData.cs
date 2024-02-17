namespace PageObjectSauceDemo.Tests;

public class TestData
{
    public static object[] AcessedUsenames =
    [
        new object[] { "standard_user" },
        new object[] { "problem_user" },
        new object[] { "performance_glitch_user" },
        new object[] { "error_user" },
        new object[] { "visual_user" }
    ];

    public static object[] BlockedUsenames =
    [
        new object[] { "locked_out_user" }
    ];

    public static string[] AcessedUsenames1 =
    [
        "standard_user",
        "problem_user",
        "performance_glitch_user",
        "error_user",
        "visual_user"
    ];
}