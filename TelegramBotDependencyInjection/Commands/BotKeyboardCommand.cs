using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotDependencyInjection.Commands;

public class BotKeyboardCommand : ITGCommand
{
    public async Task Execute(Update update, ITelegramBotClient bot)
    {
        var kbtn = new InlineKeyboardButton("Click to Send DM")
        {
            Url = "https://t.me/imetrox"
        };
        var rkm = new InlineKeyboardMarkup(kbtn);

        await bot.SendTextMessageAsync(update.Message.Chat.Id, "send me a message on Telegram👇", replyMarkup: rkm);
    }

}