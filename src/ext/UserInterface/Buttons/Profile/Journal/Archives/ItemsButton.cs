using Discord;

namespace RPGBot.UserInterface.Buttons;

public class ItemsButton : ButtonBuilder
{
    public ItemsButton()
    {
        Label = "Items";
        Style = ButtonStyle.Primary;
        CustomId = "itemsButton";
    }
}