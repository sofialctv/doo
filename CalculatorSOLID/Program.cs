using CalculatorSOLID.Services.Interfaces;
using CalculatorSOLID.Services;
using CalculatorSOLID.View;
using CalculatorSOLID.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IOperationFactory, OperationFactory>() 
            .AddSingleton<Menu>() 
            .AddSingleton<MenuController>()
            .BuildServiceProvider();

        var controller = serviceProvider.GetService<MenuController>();
        controller?.Run();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
