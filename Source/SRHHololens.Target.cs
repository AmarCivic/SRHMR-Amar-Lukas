// Copyright 2022 Pascal Hirt and Adrian Pfaff

using UnrealBuildTool;
using System.Collections.Generic;

public class SRHHololensTarget : TargetRules
{
	public SRHHololensTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "SRHHololens" } );
	}
}
