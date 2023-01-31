/*
name: (Darkblood) Lionfang
description: This will finish the Lionfang quest.
tags: story, quest, chaos-saga, 13-lords-of-chaos, darkblood, lionfang
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/Story/LordsofChaos/Core13LoC.cs
//cs_include Scripts/CoreFarms.cs
using Skua.Core.Interfaces;

public class SagaDarkblood
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public CoreAdvanced Adv = new CoreAdvanced();
    public Core13LoC LOC => new Core13LoC();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        LOC.Lionfang();

        Core.SetOptions(false);
    }
}
