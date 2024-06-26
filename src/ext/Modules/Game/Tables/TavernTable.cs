﻿using Discord.Interactions;
using Microsoft.EntityFrameworkCore;

using RPGBot.UserInterface.Embeds;
using RPGBot.UserInterface;
using RPGBot.Database.Models;
using RPGBot.Data;
using RPGBot.Modules.Game.Services;

namespace RPGBot.Modules.Game;

public class TavernTable(IServiceProvider services) : BaseModule(services)
{
    [ComponentInteraction("auctionButton")]
    public async Task AuctionHandler()
    {
        await DeferAsync();
        await FollowupAsync(
            "Auction",
            ephemeral: true
        );
    }

    [ComponentInteraction("shopButton")]
    public async Task ShopHandler()
    {
        await DeferAsync();
        await FollowupAsync(
            embed: new ShopEmbed().Build(),
            components: new ShopComponent().Build(),
            ephemeral: true
        );
    }

    [ComponentInteraction("questBoardButton")]
    public async Task QuestBoardHandler()
    {
        var player = await GetOrCreatePlayerAsync();
        var playerQuests = await _questBoard.GetPlayerQuests(player);
        await DeferAsync();
        await FollowupAsync(
            embed: new QuestBoardEmbed(playerQuests).Build(),
            components: new QuestBoardComponent(playerQuests).Build(),
            ephemeral: true
        );
    }
}
