﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Administration.UI.BanList;

[GenerateTypedNameReferences]
public sealed partial class BanListWindow : DefaultWindow
{
    public BanListWindow()
    {
        RobustXamlLoader.Load(this);

        TabContainer.SetTabTitle(0, Loc.GetString("ban-list-bans"));
        TabContainer.SetTabTitle(1, Loc.GetString("ban-list-role-bans"));
    }

    public void SetTitlePlayer(string playerName)
    {
        Title = Loc.GetString("ban-list-title", ("player", playerName));
    }
}
