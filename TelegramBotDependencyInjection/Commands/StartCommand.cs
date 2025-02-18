using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotDependencyInjection.Attributes;

namespace TelegramBotDependencyInjection.Commands;

[Trigger("/start")]
public class StartCommand : ITGCommand
{
    public async Task Execute(Update update, ITelegramBotClient bot)
    {
        await bot.SendTextMessageAsync(update.Message.Chat.Id, "Welcome to Your Bot");
    }
}
