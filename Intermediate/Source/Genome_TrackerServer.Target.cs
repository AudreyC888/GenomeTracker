using UnrealBuildTool;

public class Genome_TrackerServerTarget : TargetRules
{
	public Genome_TrackerServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Genome_Tracker");
	}
}
