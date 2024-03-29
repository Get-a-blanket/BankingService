﻿using System.Reflection;

namespace Gab_BankingService;

public static class ConfigurationManager
{
    public static string currentPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
    public static IConfiguration AppSetting { get; }
    static ConfigurationManager()
    {
        AppSetting = new ConfigurationBuilder()
                .SetBasePath(currentPath)
                .AddJsonFile("appsettings.json")
                .Build();
        ConnectionStringProtectedDb = AppSetting["ConnectionStringProtectedDb"];
    }

    public static string ConnectionStringProtectedDb;
}
