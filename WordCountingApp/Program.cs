// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using WordCountingApp;
using WordCountingApp.Services;

ServiceCollection services = new ServiceCollection();

services.ConfigureServices();

ServiceProvider serviceProvider = services.BuildServiceProvider();

CountingService counting = serviceProvider.GetService<CountingService>();


counting.Count();