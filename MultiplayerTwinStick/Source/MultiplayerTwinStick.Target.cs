// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MultiplayerTwinStickTarget : TargetRules
{
	public MultiplayerTwinStickTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MultiplayerTwinStick" } );
	}
}
