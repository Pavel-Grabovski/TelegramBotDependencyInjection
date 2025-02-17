using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBotDependencyInjection.Contracts;

namespace TelegramBotDependencyInjection.UpdateControllers;

public class TestController : IBotController
{
    public async Task HandleUpdateAsync(Update update, ITelegramBotClient bot)
    {
        if (update.Message.Text == "/test")
        {
            await bot.SendTextMessageAsync(update.Message.Chat.Id, $"test");
        }
    }

    public List<UpdateType> UpdateTypes => new() { UpdateType.Message };
}