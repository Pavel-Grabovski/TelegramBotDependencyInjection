using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotDependencyInjection.Commands;

public class GetDataCommand : ITGCommand
{
    public async Task Execute(Update update, ITelegramBotClient bot)
    {
        await bot.SendTextMessageAsync(update.Message.Chat.Id, $"Date Time : {DateTime.Now.ToString("D")}");
    }
}