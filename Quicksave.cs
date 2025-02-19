using System.Diagnostics.CodeAnalysis;
using ModShardLauncher;
using ModShardLauncher.Mods;

namespace Quicksave;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
public class Quicksave : Mod
{
    public override string Name => "Quicksave";
    public override string Author => "Nylux";
    public override string Description => "Allows the player to quicksave the game by pressing F5.";
    public override string Version => "1.2.0";

    public override void PatchMod()
    {
        Msl.InsertGMLString("scr_smoothSaveAuto()", "gml_Object_o_player_KeyPress_116", 0);
    }
}