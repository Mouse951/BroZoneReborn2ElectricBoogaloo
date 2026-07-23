using UnrealBuildTool;

public class MoriDistrictGameServerTarget : TargetRules
{
	public MoriDistrictGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MoriDistrictGame");
	}
}
