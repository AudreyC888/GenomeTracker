using UnrealBuildTool;

public class Genome_TrackerTarget : TargetRules
{
	public Genome_TrackerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Genome_Tracker");
	}
}
