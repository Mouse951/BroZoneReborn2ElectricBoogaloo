using UnrealBuildTool;

public class MoriDistrictGameTarget : TargetRules
{
	public MoriDistrictGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MoriDistrictGame");
	}
}
