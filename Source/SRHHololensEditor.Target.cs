// Copyright 2022 Pascal Hirt and Adrian Pfaff

using UnrealBuildTool;
using System.Collections.Generic;

public class SRHHololensEditorTarget : TargetRules
{
	public SRHHololensEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "SRHHololens" } );
	}
}
