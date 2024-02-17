﻿namespace PageObjectSauceDemo.Tests;

public class TestData
{
    public static string[] AcessedUsenames =
    [
        "standard_user",
        "problem_user",
        "performance_glitch_user",
        "error_user",
        "visual_user"
    ];

    public static string[] BlockedUsenames =
    [
        "locked_out_user"
    ];

    public static object[] SuccessLoginUsers =
        {
            new object[] { "standard_user" }
            
        };
}
