using Discord;

namespace RPGBot.UserInterface.Buttons;

public class EnemyButton : ButtonBuilder
{
    public EnemyButton()
    {
        Label = "Enemy";
        Style = ButtonStyle.Primary;
        CustomId = "enemyButton";
    }
}