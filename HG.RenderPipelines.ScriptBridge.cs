/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 128: HG.RenderPipelines.ScriptBridge.dll - Assembly: HG.RenderPipelines.ScriptBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63740-63744
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace HG.Rendering.ScriptBridge
{
	public static class HGRenderBridgeStatics // TypeDefIndex: 63741
	{
		// Properties
		public static int UIPrefabMaxNodeCount { get; } // 0x0000000189D27130-0x0000000189D27170 
	
		// Methods
		public static Camera AttachHGCamera(GameObject camObject); // 0x0000000189D269E4-0x0000000189D26AB0
		public static Material GetHGDecalProjectorMaterialInChildren(GameObject go); // 0x0000000189D26B58-0x0000000189D26C90
		public static HGDecalProjector GetHGDecalProjectorInChildren(GameObject go); // 0x0000000189D26AB0-0x0000000189D26B58
		public static void SetHGDecalProjectorProgress(UnityEngine.Object component, float progress); // 0x0000000189D26F84-0x0000000189D27014
		public static void SetHGDecalProjectorHollow(UnityEngine.Object component, float hollow); // 0x0000000189D26EDC-0x0000000189D26F84
		public static void HGCharacterHelperFindRenderers(GameObject go); // 0x0000000184422250-0x0000000184422310
		public static void SetHGDecalProjectorAngle(GameObject go, float angle); // 0x0000000189D26DFC-0x0000000189D26EDC
		public static void UpdateCurrentPlayerCenter(Transform centerTransform); // 0x00000001831CBBC0-0x00000001831CC020
		public static void UpdateCurrentEnvCenter(Transform centerTransform); // 0x00000001831CC5E0-0x00000001831CC750
		public static void UpdateAnchorBrightParams(Vector2 anchorPosition, float anchorRadius, float anchorBrightIntensity, bool anchorBrightFlag); // 0x0000000189D27070-0x0000000189D27130
		public static void SetVFXPPPriorityFilterCinematic(); // 0x00000001844D5AE0-0x00000001844D5B30
		public static void SetVFXPPPriorityFilterNormal(); // 0x000000018394F090-0x000000018394F0D0
		public static void SetVFXPPPriorityFilterUltiSkillCam(); // 0x000000018394EFF0-0x000000018394F040
		public static void SetVFXPPActive(bool isActive); // 0x0000000189D27014-0x0000000189D27070
		public static void SetSceneDarkEnabled(bool enabled); // 0x000000018494F880-0x000000018494F900
		public static string GetWorldUIKeyword(); // 0x0000000189D26C90-0x0000000189D26D08
		public static void SetCharacterPositionsHeights(List<Vector3> characterPositions, List<float> characterRadiuses, List<float> characterHeights); // 0x000000018323BB30-0x000000018323BD90
		public static void SetGameplayTime(double gameplayTime); // 0x0000000183B0C640-0x0000000183B0C690
		public static void SetLastGameplayTime(double lastGameplayTime); // 0x0000000183B0C690-0x0000000183B0C6E0
		public static void RequestDisableFrameGenTemporarily(Camera camera, bool disable); // 0x000000018340BC50-0x000000018340BCE0
		public static void PauseMobileFrameGenTemporarily(bool pause); // 0x0000000189D26D08-0x0000000189D26DFC
	}

	public class TAAUControlBridge // TypeDefIndex: 63742
	{
		// Properties
		public static bool taauFastConverge { set; } // 0x0000000189D28854-0x0000000189D288EC
	
		// Constructors
		public TAAUControlBridge(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void SetRenderingScale(Camera camera, float scale); // 0x0000000189D28394-0x0000000189D28430
		public static void ToggleTAAU(Camera camera); // 0x0000000189D286D8-0x0000000189D28760
		public static void ToggleMetalFXSpatial(Camera camera); // 0x0000000189D284B8-0x0000000189D28540
		public static void ToggleMetalFXTemporal(Camera camera); // 0x0000000189D285C8-0x0000000189D28650
		public static void ToggleTAAUWithMetalFXSpatial(Camera camera); // 0x0000000189D28650-0x0000000189D286D8
		public static void ToggleMetalFXTemporalWithMetalFXSpatial(Camera camera); // 0x0000000189D28540-0x0000000189D285C8
		public static void ChangeHistoryWeight(float val); // 0x0000000189D278E8-0x0000000189D2799C
		public static float GetHistoryWeight(); // 0x0000000189D27B04-0x0000000189D27B9C
		public static void ChangeHistoryWeightInMotion(float val); // 0x0000000189D27834-0x0000000189D278E8
		public static void ChangeDepthDiff(float val); // 0x0000000189D27780-0x0000000189D27834
		public static void MinMVConsideredDynamic(float val); // 0x0000000189D27D04-0x0000000189D27DB8
		public static void MaxMVConsideredDynamic(float val); // 0x0000000189D27C50-0x0000000189D27D04
		public static void CharacterMotionSensitivity(float val); // 0x0000000189D2799C-0x0000000189D27A50
		public static void FastConvergeHistoryWeight(float val); // 0x0000000189D27A50-0x0000000189D27B04
		public static void InputSampleLumaWeight(float val); // 0x0000000189D27B9C-0x0000000189D27C50
		public static void ToggleTargetFrameRate(int val); // 0x0000000189D28760-0x0000000189D287AC
		public static void NotifyTimeScale(float timeScale); // 0x00000001830418C0-0x0000000183041920
		public static void SetDLSSQuality(Camera camera, int quality); // 0x0000000189D27FEC-0x0000000189D280C4
		public static void ToggleDLSS(Camera camera); // 0x0000000189D28430-0x0000000189D284B8
		public static void SetDLSSFG(Camera camera, int mode); // 0x0000000189D27E60-0x0000000189D27F44
		public static void SetDLSSFGModeGenFrames(int numFramesToGenerate = 0 /* Metadata: 0x02352B20 */); // 0x0000000189D27DB8-0x0000000189D27E60
		public static void SetDLSSReflex(int mode = 0 /* Metadata: 0x02352B21 */); // 0x0000000189D280C4-0x0000000189D2816C
		public static void SetDLSSPCLEnable(bool enable); // 0x0000000189D27F44-0x0000000189D27FEC
		public static void SetDLSSSharpenStrength(float sharpenStrength); // 0x0000000189D2816C-0x0000000189D28224
		public static void SetForceJitterPhaseIdx(Camera camera, int idx); // 0x0000000189D282FC-0x0000000189D28394
		public static void UseDLSSExposure(bool use); // 0x0000000189D287AC-0x0000000189D28854
		public static void SetFSR3Quality(Camera camera, int quality); // 0x0000000189D28224-0x0000000189D282FC
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63743
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		static ILFixDynamicMethodWrapper(); // 0x0000000184D36FB0-0x0000000184D37020
	
		// Methods
		public void __Gen_Wrap_0(bool P0); // 0x0000000186375088-0x0000000186375148
		public void __Gen_Wrap_2(object P0, int P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public Camera __Gen_Wrap_3(object P0); // 0x0000000189D272F0-0x0000000189D273CC
		public Material __Gen_Wrap_4(object P0); // 0x0000000189D273CC-0x0000000189D274A8
		public HGDecalProjector __Gen_Wrap_5(object P0); // 0x0000000189D274A8-0x0000000189D27584
		public void __Gen_Wrap_6(object P0, float P1); // 0x0000000189D27584-0x0000000189D27650
		public void __Gen_Wrap_7(object P0); // 0x00000001863633B4-0x0000000186363474
		public void __Gen_Wrap_8(Vector2 P0, float P1, float P2, bool P3); // 0x0000000189D27650-0x0000000189D27780
		public void __Gen_Wrap_9(); // 0x00000001863625A4-0x0000000186362640
		public string __Gen_Wrap_10(); // 0x0000000189D27170-0x0000000189D27228
		public void __Gen_Wrap_11(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public void __Gen_Wrap_12(double P0); // 0x0000000189CD5364-0x0000000189CD5424
		public void __Gen_Wrap_13(object P0, bool P1); // 0x0000000189D27228-0x0000000189D272F0
		public int __Gen_Wrap_14(); // 0x0000000186377214-0x00000001863772AC
		public void __Gen_Wrap_15(int P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_16(float P0); // 0x00000001869ABD7C-0x00000001869ABE3C
		public float __Gen_Wrap_17(); // 0x00000001866D3790-0x00000001866D3828
	}

	public class WrappersManagerImpl // TypeDefIndex: 63744
	{
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189D288EC-0x0000000189D289F8
		public static bool IsPatched(int id); // 0x0000000183041920-0x0000000183041990
	}
}
