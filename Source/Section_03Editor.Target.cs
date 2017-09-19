// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Section_03EditorTarget : TargetRules
{
	public Section_03EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        // These two options are essential for upgrading a pre 4.17 project to use IWYU.
        // Forcing big files together with unity build hides errors from includes
        bUseUnityBuild = false;
        // Using precompiled headers hides errors from headers
        bUsePCHFiles = false;

		ExtraModuleNames.AddRange( new string[] { "Section_03" } );
	}
}
