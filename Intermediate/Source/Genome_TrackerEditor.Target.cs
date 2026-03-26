using UnrealBuildTool;

public class Genome_TrackerEditorTarget : TargetRules
{
	public Genome_TrackerEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Genome_Tracker");
	}
}
