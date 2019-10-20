// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class XR_RadialMenuEditorTarget : TargetRules
{
	public XR_RadialMenuEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "XR_RadialMenu" } );
	}
}
