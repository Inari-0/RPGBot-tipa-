using Discord;

namespace RPGBot.UserInterface.Buttons;

public class LocationsButton : ButtonBuilder
{
    public LocationsButton()
    {
        Label = "Locations";
        Style = ButtonStyle.Primary;
        CustomId = "locationsButton";
    }
}