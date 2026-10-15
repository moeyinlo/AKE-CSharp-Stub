/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 138: HG.RenderPipelines.ScriptBridge.dll - Assembly: HG.RenderPipelines.ScriptBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91300-91302

namespace HG.Rendering.ScriptBridge
{
	public static class HGRenderBridgeStatics // TypeDefIndex: 91301
	{
		// Properties
		public static int UIPrefabMaxNodeCount { get; } // 0x000000018C16D978-0x000000018C16D9B4 
	
		// Methods
		public static Camera AttachHGCamera(GameObject camObject); // 0x000000018C16D1BC-0x000000018C16D28C
		public static Material GetHGDecalProjectorMaterialInChildren(GameObject go); // 0x000000018C16D28C-0x000000018C16D3C4
		public static HGDecalProjector GetHGDecalProjectorInChildren(GameObject go); // 0x0000000186DDF700-0x0000000186DDF7C0
		public static void SetHGDecalProjectorProgress(UnityEngine.Object component, float progress); // 0x000000018C16D768-0x000000018C16D7F4
		public static void SetHGDecalProjectorHollow(UnityEngine.Object component, float hollow); // 0x0000000186CE2150-0x0000000186CE21F0
		public static void HGCharacterHelperFindRenderers(GameObject go); // 0x00000001855F9020-0x00000001855F9110
		public static void SetHGDecalProjectorAngle(GameObject go, float angle); // 0x000000018C16D678-0x000000018C16D768
		public static void UpdateCurrentPlayerCenter(Transform centerTransform); // 0x00000001858785A0-0x0000000185878970
		public static void UpdateCurrentEnvCenter(Transform centerTransform); // 0x0000000185878420-0x00000001858785A0
		public static void UpdateAnchorBrightParams(Vector2 anchorPosition, float anchorRadius, float anchorBrightIntensity, bool anchorBrightFlag); // 0x000000018C16D8B0-0x000000018C16D978
		public static void SetVFXPPPriorityFilterCinematic(); // 0x000000018699F4A0-0x000000018699F4F0
		public static void SetVFXPPPriorityFilterNormal(); // 0x0000000186D31980-0x0000000186D319D0
		public static void SetVFXPPPriorityFilterUltiSkillCam(); // 0x000000018C16D854-0x000000018C16D8B0
		public static void SetVFXPPActive(bool isActive); // 0x000000018C16D7F4-0x000000018C16D854
		public static void SetSceneDarkEnabled(bool enabled); // 0x00000001868C40F0-0x00000001868C4170
		public static string GetWorldUIKeyword(); // 0x000000018C16D3C4-0x000000018C16D444
		public static void SetCharacterPositionsHeights(List<Vector3> characterPositions, List<float> characterRadiuses, List<float> characterHeights); // 0x000000018567ADF0-0x000000018567B130
		public static void SetCapsuleDitherParams(float radius, float transition); // 0x000000018C16D5E4-0x000000018C16D678
		public static void SetCapsuleDitherCenter(Vector3 position); // 0x000000018C16D540-0x000000018C16D5E4
		public static void SetGameplayTime(double gameplayTime); // 0x00000001857B4AC0-0x00000001857B4BA0
		public static void SetLastGameplayTime(double lastGameplayTime); // 0x00000001857B49E0-0x00000001857B4AC0
		public static void RequestDisableFrameGenTemporarily(Camera camera, bool disable); // 0x00000001867A2D40-0x00000001867A2DE0
		public static void PauseMobileFrameGenTemporarily(bool pause); // 0x000000018C16D444-0x000000018C16D540
	}

	public class TAAUControlBridge // TypeDefIndex: 91302
	{
		// Properties
		public static bool taauFastConverge { set; } // 0x000000018C16EB7C-0x000000018C16ECC8
	
		// Constructors
		public TAAUControlBridge(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void SetRenderingScale(Camera camera, float scale); // 0x000000018C16E650-0x000000018C16E6FC
		public static void ToggleTAAU(Camera camera); // 0x000000018C16E9F4-0x000000018C16EA8C
		public static void ToggleMetalFXSpatial(Camera camera); // 0x000000018C16E794-0x000000018C16E82C
		public static void ToggleMetalFXTemporal(Camera camera); // 0x000000018C16E8C4-0x000000018C16E95C
		public static void ToggleTAAUWithMetalFXSpatial(Camera camera); // 0x000000018C16E95C-0x000000018C16E9F4
		public static void ToggleMetalFXTemporalWithMetalFXSpatial(Camera camera); // 0x000000018C16E82C-0x000000018C16E8C4
		public static void ChangeHistoryWeight(float val); // 0x000000018C16DB24-0x000000018C16DBDC
		public static float GetHistoryWeight(); // 0x000000018C16DD4C-0x000000018C16DDF0
		public static void ChangeHistoryWeightInMotion(float val); // 0x000000018C16DA6C-0x000000018C16DB24
		public static void ChangeDepthDiff(float val); // 0x000000018C16D9B4-0x000000018C16DA6C
		public static void MinMVConsideredDynamic(float val); // 0x000000018C16DF60-0x000000018C16E018
		public static void MaxMVConsideredDynamic(float val); // 0x000000018C16DEA8-0x000000018C16DF60
		public static void CharacterMotionSensitivity(float val); // 0x000000018C16DBDC-0x000000018C16DC94
		public static void FastConvergeHistoryWeight(float val); // 0x000000018C16DC94-0x000000018C16DD4C
		public static void InputSampleLumaWeight(float val); // 0x000000018C16DDF0-0x000000018C16DEA8
		public static void ToggleTargetFrameRate(int val); // 0x000000018C16EA8C-0x000000018C16EAC4
		public static void NotifyTimeScale(float timeScale); // 0x0000000186065EE0-0x0000000186065F00
		public static void SetDLSSQuality(Camera camera, int quality); // 0x000000018C16E27C-0x000000018C16E35C
		public static void ToggleDLSS(Camera camera); // 0x000000018C16E6FC-0x000000018C16E794
		public static void SetDLSSFG(Camera camera, int mode); // 0x000000018C16E0D0-0x000000018C16E1C4
		public static void SetDLSSFGModeGenFrames(int numFramesToGenerate = 0 /* Metadata: 0x0264C021 */); // 0x000000018C16E018-0x000000018C16E0D0
		public static void SetDLSSReflex(int mode = 0 /* Metadata: 0x0264C022 */); // 0x000000018C16E35C-0x000000018C16E414
		public static void SetDLSSPCLEnable(bool enable); // 0x000000018C16E1C4-0x000000018C16E27C
		public static void SetDLSSSharpenStrength(float sharpenStrength); // 0x000000018C16E414-0x000000018C16E4D0
		public static void SetForceJitterPhaseIdx(Camera camera, int idx); // 0x000000018C16E5B0-0x000000018C16E650
		public static void UseDLSSExposure(bool use); // 0x000000018C16EAC4-0x000000018C16EB7C
		public static void SetFSR3Quality(Camera camera, int quality); // 0x000000018C16E4D0-0x000000018C16E5B0
	}
}
