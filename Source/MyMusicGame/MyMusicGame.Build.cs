// JackMyth Personal

using UnrealBuildTool;

public class MyMusicGame : ModuleRules
{
	public MyMusicGame(ReadOnlyTargetRules Target):base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "MediaAssets",
            "ImageWrapper"});

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        PrivateDependencyModuleNames.AddRange(new string[] { "HTTP" });
        PrivateIncludePathModuleNames.AddRange(new string[] { "HTTP" });
        
        //AddEngineThirdPartyPrivateStaticDependencies(Target, "libcurl");

        // Uncomment if you are using Slate UI
        //if (UEBuildConfiguration.bBuildEditor == true)
        PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        if (Target.Platform == UnrealTargetPlatform.Android)
        {
            PublicDependencyModuleNames.Add("Launch");
        }

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
