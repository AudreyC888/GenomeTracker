using UnrealBuildTool;

public class Genome_TrackerClientTarget : TargetRules
{
	public Genome_TrackerClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Genome_Tracker");
	}
}
