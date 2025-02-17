using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotDependencyInjection.Commands;

public interface ITGCommand
{
    public Task Execute(Update update, ITelegramBotClient bot);

}