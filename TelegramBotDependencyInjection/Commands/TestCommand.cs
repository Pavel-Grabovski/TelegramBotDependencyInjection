using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotDependencyInjection.Commands;

public class TestCommand : ITGCommand
{
    public async Task Execute(Update update, ITelegramBotClient bot)
    {
        await bot.SendTextMessageAsync(update.Message.Chat.Id, $"test");
    }
}