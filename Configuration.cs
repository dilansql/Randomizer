using System;
using System;
using System.Text;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

public class Class1
{
    public void Configuration()
    {
        InitializeComponent();

        var configuration =
            new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings2.json")
                .Build();

        var serviceProvider =
            new ServiceCollection()
            .AddServices()
            .AddRandomiserOptions(configuration)
            .BuildServiceProvider();

        var randomzer = serviceProvider.GetRequiredService<IRandomzer>();
    }
}
