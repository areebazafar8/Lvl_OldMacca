using UnrealBuildTool;

public class Lvl_OldMaccaTarget : TargetRules
{
	public Lvl_OldMaccaTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Lvl_OldMacca");
	}
}
