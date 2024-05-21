﻿using Discord;
using RPGBot.Database;
using RPGBot.UserInterface.Buttons;
using RPGBot.UserInterface.SelectMenus;

namespace RPGBot.UserInterface;

public class PresentChoiceComponent : ComponentBuilder
{
    public PresentChoiceComponent(int presentId = 0)
    {
        WithSelectMenu(new PresentSelectMenu());
        if (presentId != 0) WithButton(new SubmitPresentButton());
    }
}