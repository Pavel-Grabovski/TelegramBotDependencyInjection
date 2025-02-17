using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using TelegramBotDependencyInjection.Contracts;
using TelegramBotDependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<ITelegramBotClient, TelegramBotClient>(x => new TelegramBotClient(
        token: "7471801619:AAHwWzxfG5loXb5R3wb0vlxMhtUIczzGbf8"))
    .AddSingleton<BotService>()
    .AddAllImplementationsOf<IBotController>();


var serviceProvider = services.BuildServiceProvider();
var botService = serviceProvider.GetRequiredService<BotService>();


await botService.StartBotAsync();

botService.GetMe();

Console.ReadKey();
