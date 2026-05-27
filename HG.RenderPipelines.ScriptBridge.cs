/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using Sirenix.Utilities;
using UnityEngine;

// Image 123: HG.RenderPipelines.ScriptBridge.dll - Assembly: HG.RenderPipelines.ScriptBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59999-60003
[assembly: AssemblyCompany("Sirenix ApS")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 2022")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("Sirenix.Serialization.Config")]
[assembly: AssemblyTitle("Sirenix.Serialization.Config")]
[assembly: AssemblyTrademark("")]
[assembly: CLSCompliant(false)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("74721B9F-0AF4-48F5-AE2E-91102A1A5EDD")]
[assembly: PersistentAssembly]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace HG.Rendering.ScriptBridge
{
	public static class HGRenderBridgeStatics // TypeDefIndex: 60000
	{
		// Methods
		public static Camera AttachHGCamera(GameObject camObject) => default; // 0x00000001887C23F4-0x00000001887C24C0
		public static Material GetHGDecalProjectorMaterialInChildren(GameObject go) => default; // 0x00000001887C2568-0x00000001887C26A0
		public static HGDecalProjector GetHGDecalProjectorInChildren(GameObject go) => default; // 0x00000001887C24C0-0x00000001887C2568
		public static void SetHGDecalProjectorProgress(UnityEngine.Object component, float progress) {} // 0x00000001887C28A0-0x00000001887C294C
		public static void SetHGDecalProjectorHollow(UnityEngine.Object component, float hollow) {} // 0x00000001887C27F8-0x00000001887C28A0
		public static void HGCharacterHelperFindRenderers(GameObject go) {} // 0x0000000182B99300-0x0000000182B993A0
		public static void SetHGDecalProjectorAngle(GameObject go, float angle) {} // 0x00000001887C2718-0x00000001887C27F8
		public static void UpdateCurrentPlayerCenter(Transform centerTransform) {} // 0x0000000182A117A0-0x0000000182A11AD0
		public static void UpdateAnchorBrightParams(Vector2 anchorPosition, float anchorRadius, float anchorBrightIntensity, bool anchorBrightFlag) {} // 0x00000001887C2B08-0x00000001887C2BA0
		public static void SetVFXPPPriorityFilterCinematic() {} // 0x00000001887C2A04-0x00000001887C2A5C
		public static void SetVFXPPPriorityFilterNormal() {} // 0x00000001887C2A5C-0x00000001887C2AB0
		public static void SetVFXPPPriorityFilterUltiSkillCam() {} // 0x00000001887C2AB0-0x00000001887C2B08
		public static void SetVFXPPActive(bool isActive) {} // 0x00000001887C29A8-0x00000001887C2A04
		public static void SetSceneDarkEnabled(bool enabled) {} // 0x00000001887C294C-0x00000001887C29A8
		public static string GetWorldUIKeyword() => default; // 0x00000001887C26A0-0x00000001887C2718
		public static void SetCharacterPositionsHeights(List<Vector3> characterPositions, List<float> characterRadiuses, List<float> characterHeights) {} // 0x0000000182A7B950-0x0000000182A7BC20
		public static void SetGameplayTime(double gameplayTime) {} // 0x000000018303E160-0x000000018303E1D0
		public static void SetLastGameplayTime(double lastGameplayTime) {} // 0x000000018303E1D0-0x000000018303E240
		public static void RequestDisableFrameGenTemporarily(Camera camera, bool disable) {} // 0x0000000182C3D1B0-0x0000000182C3D240
		public static void PauseMobileFrameGenTemporarily(bool pause) {} // 0x0000000182AB0CE0-0x0000000182AB0EF0
	}

	public class TAAUControlBridge // TypeDefIndex: 60001
	{
		// Properties
		public static bool taauFastConverge { set {} } // 0x0000000183B2C370-0x0000000183B2C400
	
		// Constructors
		public TAAUControlBridge() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void SetRenderingScale(Camera camera, float scale) {} // 0x00000001887C3C7C-0x00000001887C3D18
		public static void ToggleTAAU(Camera camera) {} // 0x00000001887C3FC0-0x00000001887C4048
		public static void ToggleMetalFXSpatial(Camera camera) {} // 0x00000001887C3DA0-0x00000001887C3E28
		public static void ToggleMetalFXTemporal(Camera camera) {} // 0x00000001887C3EB0-0x00000001887C3F38
		public static void ToggleTAAUWithMetalFXSpatial(Camera camera) {} // 0x00000001887C3F38-0x00000001887C3FC0
		public static void ToggleMetalFXTemporalWithMetalFXSpatial(Camera camera) {} // 0x00000001887C3E28-0x00000001887C3EB0
		public static void ChangeHistoryWeight(float val) {} // 0x00000001887C3250-0x00000001887C3304
		public static float GetHistoryWeight() => default; // 0x00000001887C346C-0x00000001887C3504
		public static void ChangeHistoryWeightInMotion(float val) {} // 0x00000001887C319C-0x00000001887C3250
		public static void ChangeDepthDiff(float val) {} // 0x00000001887C30E8-0x00000001887C319C
		public static void MinMVConsideredDynamic(float val) {} // 0x00000001887C366C-0x00000001887C3720
		public static void MaxMVConsideredDynamic(float val) {} // 0x00000001887C35B8-0x00000001887C366C
		public static void CharacterMotionSensitivity(float val) {} // 0x00000001887C3304-0x00000001887C33B8
		public static void FastConvergeHistoryWeight(float val) {} // 0x00000001887C33B8-0x00000001887C346C
		public static void InputSampleLumaWeight(float val) {} // 0x00000001887C3504-0x00000001887C35B8
		public static void ToggleTargetFrameRate(int val) {} // 0x00000001887C4048-0x00000001887C4094
		public static void NotifyTimeScale(float timeScale) {} // 0x0000000182569680-0x00000001825697A0
		public static void SetDLSSQuality(Camera camera, int quality) {} // 0x00000001887C3954-0x00000001887C39EC
		public static void ToggleDLSS(Camera camera) {} // 0x00000001887C3D18-0x00000001887C3DA0
		public static void SetDLSSFG(Camera camera, int mode) {} // 0x00000001887C37C8-0x00000001887C38AC
		public static void SetDLSSFGModeGenFrames(int numFramesToGenerate = 0 /* Metadata: 0x01FDD5B5 */) {} // 0x00000001887C3720-0x00000001887C37C8
		public static void SetDLSSReflex(int mode = 0 /* Metadata: 0x01FDD5B6 */) {} // 0x00000001887C39EC-0x00000001887C3A94
		public static void SetDLSSPCLEnable(bool enable) {} // 0x00000001887C38AC-0x00000001887C3954
		public static void SetDLSSSharpenStrength(float sharpenStrength) {} // 0x00000001887C3A94-0x00000001887C3B4C
		public static void SetForceJitterPhaseIdx(Camera camera, int idx) {} // 0x00000001887C3BE4-0x00000001887C3C7C
		public static void UseDLSSExposure(bool use) {} // 0x00000001887C4094-0x00000001887C413C
		public static void SetFSR3Quality(Camera camera, int quality) {} // 0x00000001887C3B4C-0x00000001887C3BE4
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60002
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05640-0x0000000183D056B0
	
		// Methods
		public void __Gen_Wrap_0(bool P0) {} // 0x000000018514F660-0x000000018514F720
		public void __Gen_Wrap_2(object P0, int P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public Camera __Gen_Wrap_3(object P0) => default; // 0x00000001887C2C58-0x00000001887C2D34
		public Material __Gen_Wrap_4(object P0) => default; // 0x00000001887C2D34-0x00000001887C2E10
		public HGDecalProjector __Gen_Wrap_5(object P0) => default; // 0x00000001887C2E10-0x00000001887C2EEC
		public void __Gen_Wrap_6(object P0, float P1) {} // 0x00000001887C2EEC-0x00000001887C2FB8
		public void __Gen_Wrap_7(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_8(Vector2 P0, float P1, float P2, bool P3) {} // 0x00000001887C2FB8-0x00000001887C30E8
		public void __Gen_Wrap_9() {} // 0x00000001850F3444-0x00000001850F34E0
		public string __Gen_Wrap_10() => default; // 0x00000001887C2BA0-0x00000001887C2C58
		public void __Gen_Wrap_11(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public void __Gen_Wrap_12(double P0) {} // 0x0000000188738F34-0x0000000188738FF4
		public void __Gen_Wrap_13(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public void __Gen_Wrap_14(int P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_15(float P0) {} // 0x0000000185784998-0x0000000185784A58
		public float __Gen_Wrap_16() => default; // 0x00000001850F18D0-0x00000001850F1968
	}

	public class WrappersManagerImpl // TypeDefIndex: 60003
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001887C413C-0x00000001887C4248
		public static bool IsPatched(int id) => default; // 0x0000000182568500-0x0000000182568570
	}
}
