/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;

// Image 126: HG.RenderPipelines.ScriptBridge.dll - Assembly: HG.RenderPipelines.ScriptBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61104-61108

namespace HG.Rendering.ScriptBridge
{
	public static class HGRenderBridgeStatics // TypeDefIndex: 61105
	{
		// Methods
		public static Camera AttachHGCamera(GameObject camObject) => default; // 0x000000018A8D6774-0x000000018A8D6840
		public static Material GetHGDecalProjectorMaterialInChildren(GameObject go) => default; // 0x000000018A8D68E8-0x000000018A8D6A20
		public static HGDecalProjector GetHGDecalProjectorInChildren(GameObject go) => default; // 0x000000018A8D6840-0x000000018A8D68E8
		public static void SetHGDecalProjectorProgress(UnityEngine.Object component, float progress) {} // 0x000000018A8D6C20-0x000000018A8D6CCC
		public static void SetHGDecalProjectorHollow(UnityEngine.Object component, float hollow) {} // 0x000000018A8D6B78-0x000000018A8D6C20
		public static void HGCharacterHelperFindRenderers(GameObject go) {} // 0x0000000184A970D0-0x0000000184A97170
		public static void SetHGDecalProjectorAngle(GameObject go, float angle) {} // 0x000000018A8D6A98-0x000000018A8D6B78
		public static void UpdateCurrentPlayerCenter(Transform centerTransform) {} // 0x0000000184403390-0x0000000184404750
		public static void UpdateCurrentEnvCenter(Transform centerTransform) {} // 0x00000001838F1DF0-0x00000001838F2E40
		public static void UpdateAnchorBrightParams(Vector2 anchorPosition, float anchorRadius, float anchorBrightIntensity, bool anchorBrightFlag) {} // 0x000000018A8D6E88-0x000000018A8D6F20
		public static void SetVFXPPPriorityFilterCinematic() {} // 0x000000018A8D6D84-0x000000018A8D6DDC
		public static void SetVFXPPPriorityFilterNormal() {} // 0x000000018A8D6DDC-0x000000018A8D6E30
		public static void SetVFXPPPriorityFilterUltiSkillCam() {} // 0x000000018A8D6E30-0x000000018A8D6E88
		public static void SetVFXPPActive(bool isActive) {} // 0x000000018A8D6D28-0x000000018A8D6D84
		public static void SetSceneDarkEnabled(bool enabled) {} // 0x000000018A8D6CCC-0x000000018A8D6D28
		public static string GetWorldUIKeyword() => default; // 0x000000018A8D6A20-0x000000018A8D6A98
		public static void SetCharacterPositionsHeights(List<Vector3> characterPositions, List<float> characterRadiuses, List<float> characterHeights) {} // 0x00000001846E3250-0x00000001846E3520
		public static void SetGameplayTime(double gameplayTime) {} // 0x0000000184EC3970-0x0000000184EC39E0
		public static void SetLastGameplayTime(double lastGameplayTime) {} // 0x0000000184EC39E0-0x0000000184EC3A50
		public static void RequestDisableFrameGenTemporarily(Camera camera, bool disable) {} // 0x000000018425F720-0x000000018425F7B0
		public static void PauseMobileFrameGenTemporarily(bool pause) {} // 0x0000000185DAF780-0x0000000185DAF870
	}

	public class TAAUControlBridge // TypeDefIndex: 61106
	{
		// Properties
		public static bool taauFastConverge { set {} } // 0x0000000185D57130-0x0000000185D571C0
	
		// Constructors
		public TAAUControlBridge() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void SetRenderingScale(Camera camera, float scale) {} // 0x000000018A8D807C-0x000000018A8D8118
		public static void ToggleTAAU(Camera camera) {} // 0x000000018A8D83C0-0x000000018A8D8448
		public static void ToggleMetalFXSpatial(Camera camera) {} // 0x000000018A8D81A0-0x000000018A8D8228
		public static void ToggleMetalFXTemporal(Camera camera) {} // 0x000000018A8D82B0-0x000000018A8D8338
		public static void ToggleTAAUWithMetalFXSpatial(Camera camera) {} // 0x000000018A8D8338-0x000000018A8D83C0
		public static void ToggleMetalFXTemporalWithMetalFXSpatial(Camera camera) {} // 0x000000018A8D8228-0x000000018A8D82B0
		public static void ChangeHistoryWeight(float val) {} // 0x000000018A8D75D0-0x000000018A8D7684
		public static float GetHistoryWeight() => default; // 0x000000018A8D77EC-0x000000018A8D7884
		public static void ChangeHistoryWeightInMotion(float val) {} // 0x000000018A8D751C-0x000000018A8D75D0
		public static void ChangeDepthDiff(float val) {} // 0x000000018A8D7468-0x000000018A8D751C
		public static void MinMVConsideredDynamic(float val) {} // 0x000000018A8D79EC-0x000000018A8D7AA0
		public static void MaxMVConsideredDynamic(float val) {} // 0x000000018A8D7938-0x000000018A8D79EC
		public static void CharacterMotionSensitivity(float val) {} // 0x000000018A8D7684-0x000000018A8D7738
		public static void FastConvergeHistoryWeight(float val) {} // 0x000000018A8D7738-0x000000018A8D77EC
		public static void InputSampleLumaWeight(float val) {} // 0x000000018A8D7884-0x000000018A8D7938
		public static void ToggleTargetFrameRate(int val) {} // 0x000000018A8D8448-0x000000018A8D8494
		public static void NotifyTimeScale(float timeScale) {} // 0x000000018429FD60-0x000000018429FE80
		public static void SetDLSSQuality(Camera camera, int quality) {} // 0x000000018A8D7CD4-0x000000018A8D7DAC
		public static void ToggleDLSS(Camera camera) {} // 0x000000018A8D8118-0x000000018A8D81A0
		public static void SetDLSSFG(Camera camera, int mode) {} // 0x000000018A8D7B48-0x000000018A8D7C2C
		public static void SetDLSSFGModeGenFrames(int numFramesToGenerate = 0 /* Metadata: 0x02082EA0 */) {} // 0x000000018A8D7AA0-0x000000018A8D7B48
		public static void SetDLSSReflex(int mode = 0 /* Metadata: 0x02082EA1 */) {} // 0x000000018A8D7DAC-0x000000018A8D7E54
		public static void SetDLSSPCLEnable(bool enable) {} // 0x000000018A8D7C2C-0x000000018A8D7CD4
		public static void SetDLSSSharpenStrength(float sharpenStrength) {} // 0x000000018A8D7E54-0x000000018A8D7F0C
		public static void SetForceJitterPhaseIdx(Camera camera, int idx) {} // 0x000000018A8D7FE4-0x000000018A8D807C
		public static void UseDLSSExposure(bool use) {} // 0x000000018A8D8494-0x000000018A8D853C
		public static void SetFSR3Quality(Camera camera, int quality) {} // 0x000000018A8D7F0C-0x000000018A8D7FE4
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61107
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F63F30-0x0000000185F63FA0
	
		// Methods
		public void __Gen_Wrap_0(bool P0) {} // 0x0000000187350984-0x0000000187350A44
		public void __Gen_Wrap_2(object P0, int P1) {} // 0x000000018A80A9F8-0x000000018A80AAC0
		public Camera __Gen_Wrap_3(object P0) => default; // 0x000000018A8D6FD8-0x000000018A8D70B4
		public Material __Gen_Wrap_4(object P0) => default; // 0x000000018A8D70B4-0x000000018A8D7190
		public HGDecalProjector __Gen_Wrap_5(object P0) => default; // 0x000000018A8D7190-0x000000018A8D726C
		public void __Gen_Wrap_6(object P0, float P1) {} // 0x000000018A8D726C-0x000000018A8D7338
		public void __Gen_Wrap_7(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_8(Vector2 P0, float P1, float P2, bool P3) {} // 0x000000018A8D7338-0x000000018A8D7468
		public void __Gen_Wrap_9() {} // 0x0000000187678160-0x00000001876781FC
		public string __Gen_Wrap_10() => default; // 0x000000018A8D6F20-0x000000018A8D6FD8
		public void __Gen_Wrap_11(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public void __Gen_Wrap_12(double P0) {} // 0x000000018A84CF0C-0x000000018A84CFCC
		public void __Gen_Wrap_13(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public void __Gen_Wrap_14(int P0) {} // 0x00000001872E71D4-0x00000001872E7280
		public void __Gen_Wrap_15(float P0) {} // 0x0000000187937D8C-0x0000000187937E4C
		public float __Gen_Wrap_16() => default; // 0x000000018735B7F8-0x000000018735B890
	}

	public class WrappersManagerImpl // TypeDefIndex: 61108
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A8D853C-0x000000018A8D8648
		public static bool IsPatched(int id) => default; // 0x00000001842A03F0-0x00000001842A0460
	}
}
