using Discord;

namespace RPGBot.UserInterface.Buttons;

public class NPCButton : ButtonBuilder
{
    public NPCButton()
    {
        Label = "NPC";
        Style = ButtonStyle.Primary;
        CustomId = "npcButton";
    }
}