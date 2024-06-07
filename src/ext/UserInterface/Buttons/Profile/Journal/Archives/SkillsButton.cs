using Discord;

namespace RPGBot.UserInterface.Buttons;

public class SkillsButton : ButtonBuilder
{
    public SkillsButton()
    {
        Label = "Skills";
        Style = ButtonStyle.Primary;
        CustomId = "skillsButton";
    }
}