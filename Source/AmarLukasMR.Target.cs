// Copyright 2022 Amar und Lukas

using UnrealBuildTool;
using System.Collections.Generic;

public class AmarLukasMRTarget : TargetRules
{
	public AmarLukasMRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "AmarLukasMR" } );
	}
}
