// Copyright 2017, Institute for Artificial Intelligence - University of Bremen

using UnrealBuildTool;

public class URoboSim : ModuleRules
{
	public URoboSim(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"URoboSim/Private",
                "URoboSimEd/Private",
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
                    		"Core", "CoreUObject", "Slate", "SlateCore", "Engine",  "HeadMountedDisplay", "XmlParser", "UnrealEd", "InputCore", "PhysX", "APEX", "ROSIntegration", "URoboSimEd"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
                    		"Core", "CoreUObject", "Slate", "SlateCore", "Engine",  "HeadMountedDisplay", "XmlParser", "UnrealEd", "InputCore", "PhysX", "APEX", "ROSIntegration", "URoboSimEd"
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
