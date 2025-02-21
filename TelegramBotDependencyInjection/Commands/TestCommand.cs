﻿using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotDependencyInjection.Attributes;

namespace TelegramBotDependencyInjection.Commands;

[Trigger("/test")]
public class TestCommand : ITGCommand
{
    public async Task Execute(Update update, ITelegramBotClient bot)
    {
        await bot.SendTextMessageAsync(update.Message.Chat.Id, $"test");
    }
}