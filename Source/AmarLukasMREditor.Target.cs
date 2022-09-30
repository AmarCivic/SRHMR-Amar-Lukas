// Copyright 2022 Amar und Lukas

using UnrealBuildTool;
using System.Collections.Generic;

public class AmarLukasMREditorTarget : TargetRules
{
	public AmarLukasMREditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "AmarLukasMR" } );
	}
}
