using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotDependencyInjection.Attributes;
namespace TelegramBotDependencyInjection.Commands;

[Trigger("/date")]
public class GetDataCommand : ITGCommand
{
    public async Task Execute(Update update, ITelegramBotClient bot)
    {
        await bot.SendTextMessageAsync(update.Message.Chat.Id, $"Date Time : {DateTime.Now.ToString("D")}");
    }
}