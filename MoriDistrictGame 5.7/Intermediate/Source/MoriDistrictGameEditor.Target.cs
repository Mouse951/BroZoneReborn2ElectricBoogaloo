using UnrealBuildTool;

public class MoriDistrictGameEditorTarget : TargetRules
{
	public MoriDistrictGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MoriDistrictGame");
	}
}
