// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

// ReSharper disable once InconsistentNaming
public class SARPG : ModuleRules
{
	public SARPG(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// ... add public include paths required here ...
		PublicIncludePaths.AddRange(new string[]
		{
			Path.Combine(ModuleDirectory, "Public")
		});

		// ... add other private include paths required here ...
		PrivateIncludePaths.AddRange(new string[]
		{
			Path.Combine(ModuleDirectory, "Private")
		});

		// ... add other public dependencies that you statically link with here ...
		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput"
		});

		// ... add private dependencies that you statically link with here ...
		PrivateDependencyModuleNames.AddRange(new string[]
		{
			"OnlineSubsystem"
		});

		DynamicallyLoadedModuleNames.AddRange(new string[]
		{
			"OnlineSubsystemSteam"
		});
	}
}