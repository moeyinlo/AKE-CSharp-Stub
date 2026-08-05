/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Beyond;
using Beyond.Audio;
using Beyond.Cfg;
using Beyond.Gameplay;
using Beyond.Gameplay.Audio;
using Beyond.Gameplay.Core;
using Beyond.Gameplay.Factory;
using Beyond.Gameplay.Factory.Core;
using Beyond.Gameplay.RemoteFactory;
using Beyond.Gameplay.View;
using Beyond.GEnums;
using Beyond.HotFix;
using Beyond.I18n;
using Beyond.Montage;
using Beyond.Network;
using Beyond.Rendering;
using Beyond.Resource;
using Beyond.Resource.Runtime;
using Beyond.SDK;
using Beyond.SparkBuffer.Runtime.Wrapper;
using Beyond.UI;
using HG.Rendering.Runtime;
using IFix;
using IFix.Core;
using MagicaCloth;
using NodeCanvas.Framework;
using Proto;
using Slate;
using TMPro;
using U8.SDK;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.HyperGryph.Streaming;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.Rendering;

// Image 61: IFixRuntime.Beyond.dll - Assembly: IFixRuntime.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61574-61600
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.HotFix
{
	public static class HotfixDownload // TypeDefIndex: 61590
	{
		// Fields
		private const string HOTFIX_SDK_TYPE = "hotfix"; // Metadata: 0x0234FD23
		private const string SDK_MSG_TYPE_KEY = "type"; // Metadata: 0x0234FD2A
		private const string SDK_MSG_CONTENT_KEY = "msg"; // Metadata: 0x0234FD2F
		private static bool s_registered; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DownloadAndApplyCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 61589
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			private string _text_5__2; // 0x28
			private string _lastError_5__3; // 0x30
			private UnityWebRequest.Result _lastResult_5__4; // 0x38
			private int _attempt_5__5; // 0x3C
			private UnityWebRequest _req_5__6; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DownloadAndApplyCoroutine_d__11(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000189E2679C-0x0000000189E26814
			private bool MoveNext(); // 0x0000000183E35330-0x0000000183E363C0
			private void __m__Finally1(); // 0x0000000183E34B50-0x0000000183E34BA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189E26750-0x0000000189E2679C
		}
	
		// Methods
		public static void RegisterSDKEvent(); // 0x0000000183A86260-0x0000000183A86440
		public static void UnregisterSDKEvent(); // 0x0000000189E19500-0x0000000189E195FC
		public static bool TryProcessSDKExtraInfo(int code, Dictionary<string, object> msg); // 0x00000001844407B0-0x0000000184441730
		public static void DownloadAndApply(string url); // 0x00000001844402A0-0x0000000184440360
		public static bool TryApplyDownloadText(string downloadText); // 0x0000000183E347F0-0x0000000183E34900
		public static bool TryDecodeDownloadText(string downloadText, out string json); // 0x0000000183E34900-0x0000000183E34A40
		private static string _TryDecryptSignedAesField(string base64Data, string fieldName); // 0x0000000189E195FC-0x0000000189E19A60
		[IteratorStateMachine(typeof(__DownloadAndApplyCoroutine_d__11))]
		private static IEnumerator _DownloadAndApplyCoroutine(string url); // 0x0000000184440360-0x00000001844403D0
		private static bool _IsValidHttpsUrl(string url); // 0x000000018443FF60-0x0000000184440030
		private static T _GetValueSafe<T>(Dictionary<string, object> dict, string key, T defaultValue = default);
	}

	public class HotFixMonobehaviour1 : MonoBehaviour // TypeDefIndex: 61591
	{
		// Fields
		public static int paramInt1; // 0x00
		public static int paramInt2; // 0x04
		public static int paramInt3; // 0x08
		public static int paramInt4; // 0x0C
		public static int paramInt5; // 0x10
		public static float paramFloat1; // 0x14
		public static float paramFloat2; // 0x18
		public static float paramFloat3; // 0x1C
		public static float paramFloat4; // 0x20
		public static float paramFloat5; // 0x24
		public static bool paramBool1; // 0x28
		public static bool paramBool2; // 0x29
		public static bool paramBool3; // 0x2A
		public static bool paramBool4; // 0x2B
		public static bool paramBool5; // 0x2C
		public static string paramString1; // 0x30
		public static string paramString2; // 0x38
		public static string paramString3; // 0x40
		public static string paramString4; // 0x48
		public static string paramString5; // 0x50
		public static object paramObject1; // 0x58
		public static object paramObject2; // 0x60
		public static object paramObject3; // 0x68
		public static object paramObject4; // 0x70
		public static object paramObject5; // 0x78
	
		// Constructors
		public HotFixMonobehaviour1(); // 0x0000000185393520-0x0000000185393538
		static HotFixMonobehaviour1(); // 0x0000000189E159BC-0x0000000189E15CE0
	
		// Methods
		private void Awake(); // 0x0000000189E152FC-0x0000000189E1533C
		private void OnEnable(); // 0x0000000189E1580C-0x0000000189E1584C
		private void OnDisable(); // 0x0000000189E157CC-0x0000000189E1580C
		private void Start(); // 0x0000000189E1593C-0x0000000189E1597C
		private void Update(); // 0x0000000189E1597C-0x0000000189E159BC
		private void LateUpdate(); // 0x0000000189E154FC-0x0000000189E1553C
		private void OnDestroy(); // 0x0000000189E1578C-0x0000000189E157CC
		private void FixedUpdate(); // 0x0000000189E1537C-0x0000000189E153BC
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x0000000189E1569C-0x0000000189E156EC
		private void OnCollisionExit(UnityEngine.Collision other); // 0x0000000189E156EC-0x0000000189E1573C
		private void OnCollisionStay(UnityEngine.Collision other); // 0x0000000189E1573C-0x0000000189E1578C
		private void OnTriggerEnter(Collider other); // 0x0000000189E1584C-0x0000000189E1589C
		private void OnTriggerExit(Collider other); // 0x0000000189E1589C-0x0000000189E158EC
		private void OnTriggerStay(Collider other); // 0x0000000189E158EC-0x0000000189E1593C
		private void OnApplicationQuit(); // 0x0000000189E155DC-0x0000000189E1561C
		private void OnApplicationFocus(bool hasFocus); // 0x0000000189E1553C-0x0000000189E1558C
		private void OnApplicationPause(bool pauseStatus); // 0x0000000189E1558C-0x0000000189E155DC
		private void OnBecameInvisible(); // 0x0000000189E1561C-0x0000000189E1565C
		private void OnBecameVisible(); // 0x0000000189E1565C-0x0000000189E1569C
		public static void Do(); // 0x0000000189E1533C-0x0000000189E1537C
		public static void Func1(); // 0x0000000189E153BC-0x0000000189E153FC
		public static void Func2(); // 0x0000000189E153FC-0x0000000189E1543C
		public static void Func3(); // 0x0000000189E1543C-0x0000000189E1547C
		public static void Func4(); // 0x0000000189E1547C-0x0000000189E154BC
		public static void Func5(); // 0x0000000189E154BC-0x0000000189E154FC
	}

	public class HotFixMonobehaviour2 : MonoBehaviour // TypeDefIndex: 61592
	{
		// Fields
		public static int paramInt1; // 0x00
		public static int paramInt2; // 0x04
		public static int paramInt3; // 0x08
		public static int paramInt4; // 0x0C
		public static int paramInt5; // 0x10
		public static float paramFloat1; // 0x14
		public static float paramFloat2; // 0x18
		public static float paramFloat3; // 0x1C
		public static float paramFloat4; // 0x20
		public static float paramFloat5; // 0x24
		public static bool paramBool1; // 0x28
		public static bool paramBool2; // 0x29
		public static bool paramBool3; // 0x2A
		public static bool paramBool4; // 0x2B
		public static bool paramBool5; // 0x2C
		public static string paramString1; // 0x30
		public static string paramString2; // 0x38
		public static string paramString3; // 0x40
		public static string paramString4; // 0x48
		public static string paramString5; // 0x50
		public static object paramObject1; // 0x58
		public static object paramObject2; // 0x60
		public static object paramObject3; // 0x68
		public static object paramObject4; // 0x70
		public static object paramObject5; // 0x78
	
		// Constructors
		public HotFixMonobehaviour2(); // 0x0000000185393520-0x0000000185393538
		static HotFixMonobehaviour2(); // 0x0000000189E163A0-0x0000000189E166C4
	
		// Methods
		private void Awake(); // 0x0000000189E15CE0-0x0000000189E15D20
		private void OnEnable(); // 0x0000000189E161F0-0x0000000189E16230
		private void OnDisable(); // 0x0000000189E161B0-0x0000000189E161F0
		private void Start(); // 0x0000000189E16320-0x0000000189E16360
		private void Update(); // 0x0000000189E16360-0x0000000189E163A0
		private void LateUpdate(); // 0x0000000189E15EE0-0x0000000189E15F20
		private void OnDestroy(); // 0x0000000189E16170-0x0000000189E161B0
		private void FixedUpdate(); // 0x0000000189E15D60-0x0000000189E15DA0
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x0000000189E16080-0x0000000189E160D0
		private void OnCollisionExit(UnityEngine.Collision other); // 0x0000000189E160D0-0x0000000189E16120
		private void OnCollisionStay(UnityEngine.Collision other); // 0x0000000189E16120-0x0000000189E16170
		private void OnTriggerEnter(Collider other); // 0x0000000189E16230-0x0000000189E16280
		private void OnTriggerExit(Collider other); // 0x0000000189E16280-0x0000000189E162D0
		private void OnTriggerStay(Collider other); // 0x0000000189E162D0-0x0000000189E16320
		private void OnApplicationQuit(); // 0x0000000189E15FC0-0x0000000189E16000
		private void OnApplicationFocus(bool hasFocus); // 0x0000000189E15F20-0x0000000189E15F70
		private void OnApplicationPause(bool pauseStatus); // 0x0000000189E15F70-0x0000000189E15FC0
		private void OnBecameInvisible(); // 0x0000000189E16000-0x0000000189E16040
		private void OnBecameVisible(); // 0x0000000189E16040-0x0000000189E16080
		public static void Do(); // 0x0000000189E15D20-0x0000000189E15D60
		public static void Func1(); // 0x0000000189E15DA0-0x0000000189E15DE0
		public static void Func2(); // 0x0000000189E15DE0-0x0000000189E15E20
		public static void Func3(); // 0x0000000189E15E20-0x0000000189E15E60
		public static void Func4(); // 0x0000000189E15E60-0x0000000189E15EA0
		public static void Func5(); // 0x0000000189E15EA0-0x0000000189E15EE0
	}

	public class HotFixMonobehaviour3 : MonoBehaviour // TypeDefIndex: 61593
	{
		// Fields
		public static int paramInt1; // 0x00
		public static int paramInt2; // 0x04
		public static int paramInt3; // 0x08
		public static int paramInt4; // 0x0C
		public static int paramInt5; // 0x10
		public static float paramFloat1; // 0x14
		public static float paramFloat2; // 0x18
		public static float paramFloat3; // 0x1C
		public static float paramFloat4; // 0x20
		public static float paramFloat5; // 0x24
		public static bool paramBool1; // 0x28
		public static bool paramBool2; // 0x29
		public static bool paramBool3; // 0x2A
		public static bool paramBool4; // 0x2B
		public static bool paramBool5; // 0x2C
		public static string paramString1; // 0x30
		public static string paramString2; // 0x38
		public static string paramString3; // 0x40
		public static string paramString4; // 0x48
		public static string paramString5; // 0x50
		public static object paramObject1; // 0x58
		public static object paramObject2; // 0x60
		public static object paramObject3; // 0x68
		public static object paramObject4; // 0x70
		public static object paramObject5; // 0x78
	
		// Constructors
		public HotFixMonobehaviour3(); // 0x0000000185393520-0x0000000185393538
		static HotFixMonobehaviour3(); // 0x0000000189E16D84-0x0000000189E170A8
	
		// Methods
		private void Awake(); // 0x0000000189E166C4-0x0000000189E16704
		private void OnEnable(); // 0x0000000189E16BD4-0x0000000189E16C14
		private void OnDisable(); // 0x0000000189E16B94-0x0000000189E16BD4
		private void Start(); // 0x0000000189E16D04-0x0000000189E16D44
		private void Update(); // 0x0000000189E16D44-0x0000000189E16D84
		private void LateUpdate(); // 0x0000000189E168C4-0x0000000189E16904
		private void OnDestroy(); // 0x0000000189E16B54-0x0000000189E16B94
		private void FixedUpdate(); // 0x0000000189E16744-0x0000000189E16784
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x0000000189E16A64-0x0000000189E16AB4
		private void OnCollisionExit(UnityEngine.Collision other); // 0x0000000189E16AB4-0x0000000189E16B04
		private void OnCollisionStay(UnityEngine.Collision other); // 0x0000000189E16B04-0x0000000189E16B54
		private void OnTriggerEnter(Collider other); // 0x0000000189E16C14-0x0000000189E16C64
		private void OnTriggerExit(Collider other); // 0x0000000189E16C64-0x0000000189E16CB4
		private void OnTriggerStay(Collider other); // 0x0000000189E16CB4-0x0000000189E16D04
		private void OnApplicationQuit(); // 0x0000000189E169A4-0x0000000189E169E4
		private void OnApplicationFocus(bool hasFocus); // 0x0000000189E16904-0x0000000189E16954
		private void OnApplicationPause(bool pauseStatus); // 0x0000000189E16954-0x0000000189E169A4
		private void OnBecameInvisible(); // 0x0000000189E169E4-0x0000000189E16A24
		private void OnBecameVisible(); // 0x0000000189E16A24-0x0000000189E16A64
		public static void Do(); // 0x0000000189E16704-0x0000000189E16744
		public static void Func1(); // 0x0000000189E16784-0x0000000189E167C4
		public static void Func2(); // 0x0000000189E167C4-0x0000000189E16804
		public static void Func3(); // 0x0000000189E16804-0x0000000189E16844
		public static void Func4(); // 0x0000000189E16844-0x0000000189E16884
		public static void Func5(); // 0x0000000189E16884-0x0000000189E168C4
	}

	public class HotFixPatchManagerProxy : IHotFixPatchManagerProxy // TypeDefIndex: 61594
	{
		// Fields
		private static HotfixDownloadPayload s_pendingDownloadPayload; // 0x00
		private static int s_currentAppliedVersion; // 0x08
	
		// Constructors
		public HotFixPatchManagerProxy(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart(); // 0x0000000184CF5480-0x0000000184CF5530
		public void InitManager(); // 0x0000000184A1A540-0x0000000184A1A6D0
		public void ReleaseManager(); // 0x0000000189E170A8-0x0000000189E172A8
		public void OnReturnToLogin(); // 0x0000000182D41A30-0x0000000182D423C0
		public void RegisterHotfixSDKEvent(); // 0x0000000184D52670-0x0000000184D526A0
		public void UnregisterHotfixSDKEvent(); // 0x0000000189E172A8-0x0000000189E172F4
		public bool TryProcessHotfixSDKExtraInfo(int code, Dictionary<string, object> msg); // 0x0000000184441730-0x0000000184441780
		public void PatchInitAssemble(); // 0x0000000183D9FDC0-0x0000000183D9FE20
		public void PatchRemoteInitAssemble(); // 0x0000000184CA5120-0x0000000184CA51E0
		public void PatchRemoteInjectedLua(); // 0x0000000184D4E8D0-0x0000000184D4E910
		private void _OnHotfixDownloadReady([IsReadOnly] in HotfixDownloadEventData data); // 0x000000018455F320-0x000000018455F3A0
		private static void _ApplyDownloadPayload(HotfixDownloadPayload payload); // 0x0000000184560EB0-0x00000001845632E0
		private void _PatchRemoteInjectedLua(); // 0x0000000183E3DF90-0x0000000183E3E070
		public void PatchMainAssemble(); // 0x0000000183D9FE20-0x0000000183D9FE80
		public void PatchRemoteMainAssemble(); // 0x0000000184CA5060-0x0000000184CA5120
	}

	public class HotFixPatchManager : Singleton<HotFixPatchManager> // TypeDefIndex: 61596
	{
		// Fields
		private TickFunction m_tickFunction; // 0x10
		private static int s_currentPatchVersion; // 0x00
		private static HashSet<Assembly> s_patchedAssemble; // 0x08
		private static List<VirtualMachine> s_patchedVM; // 0x10
		private static HashSet<Assembly> s_downloadPatchedAssemble; // 0x18
		private static List<VirtualMachine> s_downloadPatchedVM; // 0x20
	
		// Properties
		public static int currentPatchVersion { get; } // 0x0000000189E1948C-0x0000000189E19500 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61595
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__14_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D435D0-0x0000000184D43630
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PatchInitAssemble_b__14_0(string s); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		private HotFixPatchManager(); // 0x0000000184D33860-0x0000000184D338A0
		static HotFixPatchManager(); // 0x0000000183DA03A0-0x0000000183DA1330
	
		// Methods
		private void _Init(); // 0x0000000184D338A0-0x0000000184D338E0
		private void _UnInit(); // 0x0000000189E1943C-0x0000000189E1948C
		public void Release(); // 0x0000000189E17468-0x0000000189E174B8
		private void _CreateTickFunction(); // 0x000000018382A6D0-0x000000018382A7D0
		private void _ClearTickFunction(); // 0x0000000189E174B8-0x0000000189E1751C
		public static void PatchInitAssemble(); // 0x0000000183DA1330-0x0000000183DA15C0
		public static void PatchMainAssemble(); // 0x0000000183DA0240-0x0000000183DA03A0
		public void Tick(float deltaTime); // 0x000000018301FB60-0x000000018301FC10
		private void _ForceLocalUpdateIFix(); // 0x0000000189E1751C-0x0000000189E17630
		private void _ForceLocalUpdateLua(); // 0x0000000189E17630-0x0000000189E17744
		public static int InjectStringPatch(string value); // 0x0000000189E17344-0x0000000189E17468
		public static int InjectLuaStringPatch(string value); // 0x0000000184560E00-0x0000000184560EB0
		public static void InjectLuaStringPatchFromUrl(string url); // 0x0000000189E172F4-0x0000000189E17344
		private static int _InjectStringPatchLine(string value); // 0x0000000189E1862C-0x0000000189E18DF0
		private static int _InjectStringPatchJson(string value); // 0x0000000189E17AC4-0x0000000189E1862C
		private static int _InjectLuaStringPatchLine(string value); // 0x0000000189E17744-0x0000000189E17AC4
		private static int _InjectLuaStringPatchJson(string value); // 0x00000001845609E0-0x0000000184560E00
		private static bool _TryApplyLuaPatchBase64(string base64Data, int expectedSize, string md5, string patchName); // 0x0000000189E18DF0-0x0000000189E1943C
		public static void PatchDebugAssemble(Stream stream, bool isDownload = false /* Metadata: 0x0234FD33 */); // 0x0000000182D43FE0-0x0000000182D45020
		public static void ClearPatchesForRelogin(); // 0x0000000182D423C0-0x0000000182D43FE0
		public static int PatchAssemble(); // 0x0000000183DA2120-0x0000000183DA31D0
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 61584
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61585
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61586
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61587
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61588
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 61575
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class IFixMethodPrinter // TypeDefIndex: 61582
	{
		// Fields
		private System.Reflection.FieldInfo unmanagedCodesField; // 0x10
		private PropertyInfo exceptionHandlersProperty; // 0x18
		private PropertyInfo externMethodsProperty; // 0x20
	
		// Nested types
		private class WrapperArrayCandidate // TypeDefIndex: 61576
		{
			// Fields
			public string Source; // 0x10
			public string OwnerTypeName; // 0x18
			public string FieldName; // 0x20
			public string ElementTypeName; // 0x28
			public int Length; // 0x30
			public int NonNullCount; // 0x34
			public Func<int, object> Getter; // 0x38
	
			// Constructors
			public WrapperArrayCandidate(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public object GetValue(int index); // 0x0000000189E26814-0x0000000189E26838
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61577
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, string>, int> __9__7_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189E266EC-0x0000000189E26750
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetAllIFixMethodStrs_b__7_0(KeyValuePair<int, string> k); // 0x0000000189E26678-0x0000000189E266AC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 61578
		{
			// Fields
			public Array arr; // 0x10
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _TryGetWrapperArrayDirect_b__0(int i); // 0x0000000189E266AC-0x0000000189E266CC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 61579
		{
			// Fields
			public Array arr; // 0x10
			public IList listValue; // 0x18
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _AddWrapperCandidate_b__0(int i); // 0x0000000189E266AC-0x0000000189E266CC
			internal object _AddWrapperCandidate_b__1(int i); // 0x0000000189E266CC-0x0000000189E266EC
		}
	
		[CompilerGenerated]
		private sealed class _GetAllFieldsIncludingBase_d__29 : IEnumerable<System.Reflection.FieldInfo>, IEnumerator<System.Reflection.FieldInfo> // TypeDefIndex: 61580
		{
			// Fields
			private int __1__state; // 0x10
			private System.Reflection.FieldInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type type; // 0x28
			public System.Type __3__type; // 0x30
			private System.Reflection.BindingFlags flags; // 0x38
			public System.Reflection.BindingFlags __3__flags; // 0x3C
			private System.Type _t_5__2; // 0x40
			private System.Reflection.FieldInfo[] __7__wrap2; // 0x48
			private int __7__wrap3; // 0x50
	
			// Properties
			System.Reflection.FieldInfo IEnumerator<System.Reflection.FieldInfo>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllFieldsIncludingBase_d__29(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189E26238-0x0000000189E26368
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189E2640C-0x0000000189E26458
			[DebuggerHidden]
			IEnumerator<System.Reflection.FieldInfo> IEnumerable<FieldInfo>.GetEnumerator(); // 0x0000000189E26368-0x0000000189E26404
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189E26404-0x0000000189E2640C
		}
	
		[CompilerGenerated]
		private sealed class _GetAllPropertiesIncludingBase_d__30 : IEnumerable<PropertyInfo>, IEnumerator<PropertyInfo> // TypeDefIndex: 61581
		{
			// Fields
			private int __1__state; // 0x10
			private PropertyInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type type; // 0x28
			public System.Type __3__type; // 0x30
			private System.Reflection.BindingFlags flags; // 0x38
			public System.Reflection.BindingFlags __3__flags; // 0x3C
			private System.Type _t_5__2; // 0x40
			private PropertyInfo[] __7__wrap2; // 0x48
			private int __7__wrap3; // 0x50
	
			// Properties
			PropertyInfo IEnumerator<System.Reflection.PropertyInfo>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllPropertiesIncludingBase_d__30(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189E26458-0x0000000189E26588
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189E2662C-0x0000000189E26678
			[DebuggerHidden]
			IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator(); // 0x0000000189E26588-0x0000000189E26624
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189E26624-0x0000000189E2662C
		}
	
		// Constructors
		public IFixMethodPrinter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private void InitializeReflection(); // 0x0000000189E1ED50-0x0000000189E1EEA4
		private int GetMethodCount(VirtualMachine vm); // 0x0000000189E1E580-0x0000000189E1E600
		private IFix.Core.Instruction[] GetMethodInstructions(VirtualMachine vm, int methodIndex); // 0x0000000189E1E600-0x0000000189E1E93C
		private unsafe int EstimateInstructionCount(IFix.Core.Instruction* codePtr); // 0x0000000189E1CB50-0x0000000189E1CBA4
		public string GetAllIFixMethodStrs(VirtualMachine vm); // 0x0000000189E1D0BC-0x0000000189E1E500
		private void DumpRedirectToMappings(StringBuilder sb, WrappersManager wrappersManager); // 0x0000000189E1C104-0x0000000189E1C470
		private Dictionary<int, string> BuildIdMap(Assembly preferredAssembly); // 0x0000000189E1A3C4-0x0000000189E1A734
		private void ForceLoadIdMapTypes(Dictionary<int, string> result); // 0x0000000189E1CBA4-0x0000000189E1CE24
		private void AddIdMapFields(Dictionary<int, string> result, System.Type idMapType); // 0x0000000189E19A60-0x0000000189E19C3C
		private string BuildMethodLabelFromIdMapField(System.Reflection.FieldInfo field); // 0x0000000189E1A734-0x0000000189E1A8BC
		private bool IsNumericField(System.Type type); // 0x0000000189E1EEA4-0x0000000189E1F060
		private List<WrapperArrayCandidate> CollectWrapperArrays(WrappersManager wrappersManager); // 0x0000000189E1AD38-0x0000000189E1B8FC
		private List<WrapperArrayCandidate> CollectWrapperArraysFromAssembly(Assembly asm); // 0x0000000189E1A8BC-0x0000000189E1AD38
		private WrapperArrayCandidate SelectBestWrapperArray(List<WrapperArrayCandidate> candidates, Dictionary<int, string> idMap); // 0x0000000189E1F37C-0x0000000189E1F548
		private WrapperArrayCandidate TryGetWrapperArrayDirect(Assembly asm); // 0x0000000189E1F8A8-0x0000000189E1FC10
		private string TryResolveWrapperTarget(object wrapperObj); // 0x0000000189E1FFB8-0x0000000189E204B8
		private string GetWrapperDebugInfo(object wrapperObj); // 0x0000000189E1E93C-0x0000000189E1ED50
		private string SummarizeValue(object val); // 0x0000000189E1F548-0x0000000189E1F8A8
		private int? TryGetWrapperMethodId(object wrapperObj); // 0x0000000189E1FC10-0x0000000189E1FFB8
		private void AppendILSummary(StringBuilder sb, VirtualMachine vm, int methodId, MethodBase[] externMethods); // 0x0000000189E1A018-0x0000000189E1A3C4
		private string FormatOperand(VirtualMachine vm, IFix.Core.Instruction inst, MethodBase[] externMethods); // 0x0000000189E1CE24-0x0000000189E1D03C
		private int ScoreWrapperCandidate(WrapperArrayCandidate candidate, int minLen); // 0x0000000189E1F060-0x0000000189E1F37C
		private void AddWrapperCandidate(List<WrapperArrayCandidate> list, string source, string ownerTypeName, string name, System.Type valueType, object value); // 0x0000000189E19C3C-0x0000000189E1A018
		private void DumpWrappersManagerMembers(StringBuilder sb, WrappersManager wrappersManager); // 0x0000000189E1C470-0x0000000189E1CB50
		private void DumpAssemblyPotentialStores(StringBuilder sb, Assembly asm); // 0x0000000189E1BA48-0x0000000189E1C104
		[IteratorStateMachine(typeof(_GetAllFieldsIncludingBase_d__29))]
		private IEnumerable<System.Reflection.FieldInfo> GetAllFieldsIncludingBase(System.Type type, System.Reflection.BindingFlags flags); // 0x0000000189E1D03C-0x0000000189E1D0BC
		[IteratorStateMachine(typeof(_GetAllPropertiesIncludingBase_d__30))]
		private IEnumerable<PropertyInfo> GetAllPropertiesIncludingBase(System.Type type, System.Reflection.BindingFlags flags); // 0x0000000189E1E500-0x0000000189E1E580
		private string DescribeValue(object value); // 0x0000000189E1B8FC-0x0000000189E1BA48
	}

	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61597
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D376B0-0x0000000184D37720
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001863625A4-0x0000000186362640
		public bool __Gen_Wrap_1(object P0); // 0x00000001863632E4-0x00000001863633B4
		public string __Gen_Wrap_2(object P0, object P1); // 0x0000000189E2248C-0x0000000189E22598
		public bool __Gen_Wrap_3(object P0, out string P1); // 0x0000000189E226BC-0x0000000189E227F4
		public IEnumerator __Gen_Wrap_4(object P0); // 0x0000000189E22E98-0x0000000189E22F88
		public void __Gen_Wrap_5(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_6(int P0, object P1); // 0x0000000189E239F4-0x0000000189E23AE0
		public void __Gen_Wrap_7(object P0, object P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_8(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public bool __Gen_Wrap_9(object P0, int P1, object P2, object P3); // 0x0000000189E244B8-0x0000000189E245CC
		public int __Gen_Wrap_10(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_11(object P0, in HotfixDownloadEventData P1); // 0x0000000189E20DB8-0x0000000189E20EDC
		public bool __Gen_Wrap_12(object P0, int P1, object P2); // 0x00000001869ADDF8-0x00000001869ADEFC
		public void __Gen_Wrap_13(string P0); // 0x00000001866C296C-0x00000001866C2A18
		public int __Gen_Wrap_14(); // 0x00000001863621C4-0x0000000186362270
		public void __Gen_Wrap_15(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public void __Gen_Wrap_16(object P0, PropertyChangedEventArgs P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_17(Misc.ObjectRef P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_18(U8MockLogin P0); // 0x0000000189E21C78-0x0000000189E21D5C
		public SDKPromise<U8PayResult> __Gen_Wrap_19(U8PayParams P0); // 0x0000000189E21D5C-0x0000000189E21E38
		public void __Gen_Wrap_20(U8PayResult P0); // 0x0000000189E21E38-0x0000000189E21F24
		public SDKMeta __Gen_Wrap_21(); // 0x0000000189E21F24-0x0000000189E21FDC
		public void __Gen_Wrap_22(Dictionary<Enum, TickGroupMonitorItem> P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_23(int P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_24(float P0); // 0x00000001866DCCF0-0x00000001866DCD9C
		public void __Gen_Wrap_25(bool P0); // 0x00000001866DCC44-0x00000001866DCCF0
		public void __Gen_Wrap_26(UnityEngine.HyperGryph.ECS.Entity P0, float3 P1, float3 P2, Matrix4x4 P3); // 0x0000000189E21FDC-0x0000000189E22184
		public void __Gen_Wrap_27(UnityEngine.HyperGryph.ECS.Entity P0); // 0x0000000189E22184-0x0000000189E22268
		public void __Gen_Wrap_28(NativeArray<UnityEngine.HyperGryph.ECS.Entity> P0, int P1); // 0x0000000189E22268-0x0000000189E22368
		public void __Gen_Wrap_29(UnityEngine.HyperGryph.ECS.EntityManager P0, UnityEngine.HyperGryph.ECS.Entity P1); // 0x0000000189E22368-0x0000000189E2248C
		public void __Gen_Wrap_30(object P0, AudioCallbackType P1, AudioCallbackInfo P2); // 0x0000000189E22598-0x0000000189E226BC
		public void __Gen_Wrap_31(TMP_TextInfo P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_32(GameObject P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_33(int P0, GameObject P1); // 0x0000000186365664-0x000000018636572C
		public void __Gen_Wrap_34(int P0, bool P1); // 0x0000000189C9FEFC-0x0000000189C9FFC4
		public void __Gen_Wrap_35(int P0, UIDropdownOption P1, bool P2); // 0x00000001869AE148-0x00000001869AE22C
		public void __Gen_Wrap_36(int P0, UIDropdown P1); // 0x0000000186365664-0x000000018636572C
		public void __Gen_Wrap_37(int P0, UIMultiSelectDropdown P1); // 0x0000000186365664-0x000000018636572C
		public void __Gen_Wrap_38(bool P0, string P1, string P2); // 0x0000000189C86674-0x0000000189C86758
		public void __Gen_Wrap_39(HGTerrainHelper P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_40(Vector2Int P0); // 0x0000000189E227F4-0x0000000189E228E8
		public bool __Gen_Wrap_41(UnityEngine.Vector2 P0); // 0x0000000189E228E8-0x0000000189E229E0
		public void __Gen_Wrap_42(Vector2Int P0); // 0x0000000189E229E0-0x0000000189E22AC4
		public float __Gen_Wrap_43(); // 0x00000001866D3790-0x00000001866D3828
		public float __Gen_Wrap_44(Light P0, Camera P1, UnityEngine.Vector3 P2); // 0x0000000189E22AC4-0x0000000189E22BF4
		public RTHandle __Gen_Wrap_45(int P0); // 0x0000000189E22BF4-0x0000000189E22CCC
		public void __Gen_Wrap_46(RenderTargetIdentifier P0, CommandBuffer P1); // 0x0000000189E22CCC-0x0000000189E22DE0
		public bool __Gen_Wrap_47(System.Reflection.FieldInfo P0); // 0x00000001866C53B4-0x00000001866C5470
		public object __Gen_Wrap_48(); // 0x0000000189E22DE0-0x0000000189E22E98
		public bool __Gen_Wrap_49(); // 0x00000001863770B0-0x0000000186377148
		public uint __Gen_Wrap_50(); // 0x0000000186377214-0x00000001863772AC
		public void __Gen_Wrap_51(uint P0); // 0x0000000186301ED4-0x0000000186301F80
		public Enum __Gen_Wrap_52(); // 0x0000000189E22F88-0x0000000189E23040
		public void __Gen_Wrap_53(Enum P0); // 0x00000001866C296C-0x00000001866C2A18
		public UnityEngine.Color __Gen_Wrap_54(); // 0x0000000189E23040-0x0000000189E23118
		public void __Gen_Wrap_55(UnityEngine.Color P0); // 0x0000000189E23118-0x0000000189E231FC
		public UnityEngine.Vector2 __Gen_Wrap_56(); // 0x0000000189E231FC-0x0000000189E232B4
		public void __Gen_Wrap_57(UnityEngine.Vector2 P0); // 0x0000000189E232B4-0x0000000189E2339C
		public UnityEngine.Vector3 __Gen_Wrap_58(); // 0x0000000189E2339C-0x0000000189E2347C
		public void __Gen_Wrap_59(UnityEngine.Vector3 P0); // 0x0000000189E2347C-0x0000000189E23568
		public Vector4 __Gen_Wrap_60(); // 0x0000000189E23568-0x0000000189E23640
		public void __Gen_Wrap_61(Vector4 P0); // 0x0000000189E23640-0x0000000189E23724
		public void __Gen_Wrap_62(DebugUI.Panel P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_63(BaseMeshDeformer P0); // 0x00000001866C296C-0x00000001866C2A18
		public uint __Gen_Wrap_64(int P0); // 0x0000000186363EE4-0x0000000186363F9C
		public float3 __Gen_Wrap_65(int P0); // 0x0000000189E23724-0x0000000189E23824
		public quaternion __Gen_Wrap_66(int P0); // 0x0000000189E23824-0x0000000189E2391C
		public float __Gen_Wrap_67(int P0); // 0x000000018636B508-0x000000018636B5C0
		public Transform __Gen_Wrap_68(int P0); // 0x0000000189E2391C-0x0000000189E239F4
		public void __Gen_Wrap_69(MagicaAvatar P0, MagicaAvatarParts P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_70(MagicaAvatar P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_71(List<int> P0, List<int> P1, List<UnityEngine.Vector3> P2, List<UnityEngine.Vector3> P3, List<UnityEngine.Vector3> P4, List<int> P5, List<int> P6); // 0x0000000186374274-0x000000018637439C
		public void __Gen_Wrap_72(CoreComponent P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_73(Animator P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_74(BaseCloth P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_75(int P0, int P1); // 0x0000000189CB3104-0x0000000189CB31CC
		public void __Gen_Wrap_76(object P0, SafeSerializationEventArgs P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_77(IAsyncResult P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_78(ref NetResponse P0); // 0x0000000189E23AE0-0x0000000189E23C18
		public void __Gen_Wrap_79(System.Type P0, MethodInfo P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_80(InputAction.CallbackContext P0); // 0x0000000189E23C18-0x0000000189E23CFC
		public void __Gen_Wrap_81(HGRenderPipeCallbackArgs P0); // 0x0000000189E23CFC-0x0000000189E23DE0
		public void __Gen_Wrap_82(ScriptableRenderContext P0, HGCamera P1); // 0x0000000189E23DE0-0x0000000189E23EE0
		public void __Gen_Wrap_83(HGCamera P0, RTHandle P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_84(bool P0, bool P1); // 0x0000000189E23EE0-0x0000000189E23FA8
		public void __Gen_Wrap_85(HttpRequestMessage P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_86(Beyond.Blackboard.DataPair P0); // 0x0000000189E23FA8-0x0000000189E240A0
		public void __Gen_Wrap_87(Beyond.Blackboard.DataPair P0); // 0x0000000189E240A0-0x0000000189E2418C
		public int __Gen_Wrap_88(Beyond.Blackboard.DataPair P0, Beyond.Blackboard.DataPair P1); // 0x0000000189E2418C-0x0000000189E242C0
		public void __Gen_Wrap_89(Transform P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_90(Transform P0); // 0x00000001866C53B4-0x00000001866C5470
		public void __Gen_Wrap_91(Material P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_92(Texture P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_93(Shader P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_94(Mesh P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_95(Sprite P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_96(ScriptableObject P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_97(RuntimeAnimatorController P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_98(StyledBlackboard.StyledDataPair P0); // 0x0000000189E242C0-0x0000000189E243C4
		public void __Gen_Wrap_99(StyledBlackboard.StyledDataPair P0); // 0x0000000189E243C4-0x0000000189E244B8
		public int __Gen_Wrap_100(StyledBlackboard.StyledDataPair P0, StyledBlackboard.StyledDataPair P1); // 0x0000000189E204B8-0x0000000189E20600
		public bool __Gen_Wrap_101(GameObject P0); // 0x00000001866C53B4-0x00000001866C5470
		public void __Gen_Wrap_102(bool P0, IAssetLoaderHandle P1); // 0x00000001871A12AC-0x00000001871A1374
		public void __Gen_Wrap_103(bool P0, FAssetProxyHandle P1); // 0x0000000189E20600-0x0000000189E20704
		public void __Gen_Wrap_104(IPreloadGroup P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_105(Beyond.Resource.Runtime.Asset P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_106(BundleLoader.AssetProxy P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_107(HGRetCodeType P0, int P1); // 0x0000000189CB3104-0x0000000189CB31CC
		public void __Gen_Wrap_108(HGDownloader.PauseReason P0); // 0x0000000186301ED4-0x0000000186301F80
		public bool __Gen_Wrap_109(UnityEngine.HyperGryph.ECS.Entity P0, FlatBufferConvertContextV2 P1, EntityTransition P2); // 0x0000000189E20704-0x0000000189E20850
		public bool __Gen_Wrap_110(ref IntPtr P0, FlatBufferConvertContextV2 P1, EntityTransition P2); // 0x0000000189E20850-0x0000000189E209D4
		public bool __Gen_Wrap_111(UnityEngine.Component P0, FlatBufferConvertContextV2 P1, EntityTransition P2); // 0x0000000189E209D4-0x0000000189E20B00
		public UnityEngine.Component __Gen_Wrap_112(GameObject P0); // 0x0000000189E20B00-0x0000000189E20BDC
		public UnityEngine.Component __Gen_Wrap_113(GameObject P0, int P1); // 0x0000000189E20BDC-0x0000000189E20CFC
		public void __Gen_Wrap_114(ServerConfig P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_115(bool P0, LevelScriptData P1); // 0x00000001871A12AC-0x00000001871A1374
		public void __Gen_Wrap_116(bool P0, InteractiveTemplateData P1); // 0x00000001871A12AC-0x00000001871A1374
		public float __Gen_Wrap_117(float P0); // 0x0000000189E20CFC-0x0000000189E20DB8
		public bool __Gen_Wrap_118(ClientSingleMapMarkData P0); // 0x00000001866C53B4-0x00000001866C5470
		public void __Gen_Wrap_119(ClientSingleMapMarkData P0); // 0x00000001866C296C-0x00000001866C2A18
		public int __Gen_Wrap_120(ClientSingleMapMarkData P0, ClientSingleMapMarkData P1); // 0x00000001871AD678-0x00000001871AD750
		public void __Gen_Wrap_121(NodeCanvas.Framework.Graph P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_122(AICanvasGraphData P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_123(ulong P0, ulong P1, FAssetProxyHandle P2); // 0x0000000189E20EDC-0x0000000189E20FFC
		public void __Gen_Wrap_124(ParamVariable P0, ParamVariable P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_125(DialogTree P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_126(CS_FACTORY_OP P0, SC_FACTORY_OP_RET P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_127(ObjectPtr<Beyond.Gameplay.Core.Entity> P0); // 0x0000000189E20FFC-0x0000000189E210E0
		public void __Gen_Wrap_128(bool P0, EffectInstance P1); // 0x00000001871A12AC-0x00000001871A1374
		public void __Gen_Wrap_129(EntityVFXControllerBase P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_130(float P0); // 0x0000000189E210E0-0x0000000189E2119C
		public void __Gen_Wrap_131(FactoryUtil.TopViewBuildingInfo P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_132(AnimatorOverrideController P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_133(Beyond.Gameplay.Factory.Core.Vector2IntData P0); // 0x0000000189E2119C-0x0000000189E21290
		public bool __Gen_Wrap_134(int P0, int P1); // 0x0000000189E21290-0x0000000189E21364
		public void __Gen_Wrap_135(string P0, GameObject P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public PrefabMeshMaterialMatrixParser __Gen_Wrap_136(); // 0x0000000189E21364-0x0000000189E2141C
		public IRemoteFactoryMessageSendable __Gen_Wrap_137(); // 0x0000000189E2141C-0x0000000189E214D4
		public IFactoryStateProvider __Gen_Wrap_138(); // 0x0000000189E214D4-0x0000000189E2158C
		public bool __Gen_Wrap_139(LevelDataBlackbox P0); // 0x00000001866C53B4-0x00000001866C5470
		public void __Gen_Wrap_140(BeanArray<DynamicParam> P0); // 0x0000000189E2158C-0x0000000189E21680
		public void __Gen_Wrap_141(ulong P0); // 0x0000000189CD3FC4-0x0000000189CD4070
		public void __Gen_Wrap_142(PossibleResponses P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_143(ResponseContext P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_144(uint P0, uint P1, VoiceResponseProcessor.EResponseDecideReason P2); // 0x0000000189E21680-0x0000000189E21760
		public void __Gen_Wrap_145(AudioLang P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_146(AudioGameState P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_147(NodeCanvas.Framework.Status P0); // 0x0000000186301ED4-0x0000000186301F80
		public UnityEngine.Vector3 __Gen_Wrap_148(UnityEngine.Vector3 P0); // 0x0000000189E21760-0x0000000189E21890
		public void __Gen_Wrap_149(int P0, string P1, GameObject P2); // 0x0000000189E21890-0x0000000189E21974
		public void __Gen_Wrap_150(bool P0, BaseModelViewPart P1); // 0x00000001871A12AC-0x00000001871A1374
		public void __Gen_Wrap_151(string P0, AnimMontageData P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_152(Skill.FinishType P0, int P1); // 0x0000000189CB3104-0x0000000189CB31CC
		public void __Gen_Wrap_153(Skill P0); // 0x00000001866C296C-0x00000001866C2A18
		public Buff __Gen_Wrap_154(AbilitySystem P0, Beyond.Gameplay.Core.BuffData P1, List<Beyond.Blackboard.DataPair> P2, ulong? P3); // 0x0000000189E21974-0x0000000189E21AC0
		public void __Gen_Wrap_155(bool P0, Beyond.Gameplay.Core.SkillData P1); // 0x00000001871A12AC-0x00000001871A1374
		public void __Gen_Wrap_156(Buff P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_157(CinematicTimelineManagerBase.TimelineHandle P0, bool P1); // 0x0000000189D27228-0x0000000189D272F0
		public void __Gen_Wrap_158(string P0, string P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_159(Beyond.Gameplay.Core.Entity P0); // 0x00000001866C296C-0x00000001866C2A18
		public MovementSetting __Gen_Wrap_160(string P0); // 0x0000000189E21AC0-0x0000000189E21B9C
		public MovementSettingModifier __Gen_Wrap_161(string P0); // 0x0000000189E21B9C-0x0000000189E21C78
		public void __Gen_Wrap_162(Section P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_163(string P0, object P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public void __Gen_Wrap_164(Texture2D[] P0); // 0x00000001866C296C-0x00000001866C2A18
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 61598
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x0000000189E26838-0x0000000189E268E4 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x0000000189E268E4-0x0000000189E26990 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000189E26990-0x0000000189E26A6C
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x0000000186365FC0-0x000000018636603C
		[IDTag(1)]
		private bool MoveNext(); // 0x0000000186365D60-0x0000000186365DEC
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x0000000186365E98-0x0000000186365F14
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61599
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189E26C54-0x0000000189E26CB8
		public static bool IsPatched(int id); // 0x000000018301FC10-0x000000018301FC60
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000189E26B10-0x0000000189E26BDC
		public object CreateWrapper(int id); // 0x0000000189E26BDC-0x0000000189E26C54
		public object InitWrapperArray(int len); // 0x0000000189E26CB8-0x0000000189E2748C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000189E26A6C-0x0000000189E26B10
	}

	public enum IDMAP0 // TypeDefIndex: 61600
	{
		Beyond-HotFix-HotfixDownload-RegisterSDKEvent0 = 0,
		Beyond-HotFix-HotfixDownload-UnregisterSDKEvent0 = 1,
		Beyond-HotFix-HotfixDownload-TryProcessSDKExtraInfo0 = 2,
		Beyond-HotFix-HotfixDownload-DownloadAndApply0 = 3,
		Beyond-HotFix-HotfixDownload-_IsValidHttpsUrl0 = 4,
		Beyond-HotFix-HotfixDownload-_DownloadAndApplyCoroutine0 = 5,
		Beyond-HotFix-HotfixDownload-TryApplyDownloadText0 = 10,
		Beyond-HotFix-HotfixDownload-TryDecodeDownloadText0 = 11,
		Beyond-HotFix-HotfixDownload-_TryDecryptSignedAesField0 = 12,
		Beyond-HotFix-HotFixMonobehaviour1-Awake0 = 16,
		Beyond-HotFix-HotFixMonobehaviour1-OnEnable0 = 17,
		Beyond-HotFix-HotFixMonobehaviour1-OnDisable0 = 18,
		Beyond-HotFix-HotFixMonobehaviour1-Start0 = 19,
		Beyond-HotFix-HotFixMonobehaviour1-Update0 = 20,
		Beyond-HotFix-HotFixMonobehaviour1-LateUpdate0 = 21,
		Beyond-HotFix-HotFixMonobehaviour1-OnDestroy0 = 22,
		Beyond-HotFix-HotFixMonobehaviour1-FixedUpdate0 = 23,
		Beyond-HotFix-HotFixMonobehaviour1-OnCollisionEnter0 = 24,
		Beyond-HotFix-HotFixMonobehaviour1-OnCollisionExit0 = 25,
		Beyond-HotFix-HotFixMonobehaviour1-OnCollisionStay0 = 26,
		Beyond-HotFix-HotFixMonobehaviour1-OnTriggerEnter0 = 27,
		Beyond-HotFix-HotFixMonobehaviour1-OnTriggerExit0 = 28,
		Beyond-HotFix-HotFixMonobehaviour1-OnTriggerStay0 = 29,
		Beyond-HotFix-HotFixMonobehaviour1-OnApplicationQuit0 = 30,
		Beyond-HotFix-HotFixMonobehaviour1-OnApplicationFocus0 = 31,
		Beyond-HotFix-HotFixMonobehaviour1-OnApplicationPause0 = 32,
		Beyond-HotFix-HotFixMonobehaviour1-OnBecameInvisible0 = 33,
		Beyond-HotFix-HotFixMonobehaviour1-OnBecameVisible0 = 34,
		Beyond-HotFix-HotFixMonobehaviour1-Do0 = 35,
		Beyond-HotFix-HotFixMonobehaviour1-Func10 = 36,
		Beyond-HotFix-HotFixMonobehaviour1-Func20 = 37,
		Beyond-HotFix-HotFixMonobehaviour1-Func30 = 38,
		Beyond-HotFix-HotFixMonobehaviour1-Func40 = 39,
		Beyond-HotFix-HotFixMonobehaviour1-Func50 = 40,
		Beyond-HotFix-HotFixMonobehaviour2-Awake0 = 41,
		Beyond-HotFix-HotFixMonobehaviour2-OnEnable0 = 42,
		Beyond-HotFix-HotFixMonobehaviour2-OnDisable0 = 43,
		Beyond-HotFix-HotFixMonobehaviour2-Start0 = 44,
		Beyond-HotFix-HotFixMonobehaviour2-Update0 = 45,
		Beyond-HotFix-HotFixMonobehaviour2-LateUpdate0 = 46,
		Beyond-HotFix-HotFixMonobehaviour2-OnDestroy0 = 47,
		Beyond-HotFix-HotFixMonobehaviour2-FixedUpdate0 = 48,
		Beyond-HotFix-HotFixMonobehaviour2-OnCollisionEnter0 = 49,
		Beyond-HotFix-HotFixMonobehaviour2-OnCollisionExit0 = 50,
		Beyond-HotFix-HotFixMonobehaviour2-OnCollisionStay0 = 51,
		Beyond-HotFix-HotFixMonobehaviour2-OnTriggerEnter0 = 52,
		Beyond-HotFix-HotFixMonobehaviour2-OnTriggerExit0 = 53,
		Beyond-HotFix-HotFixMonobehaviour2-OnTriggerStay0 = 54,
		Beyond-HotFix-HotFixMonobehaviour2-OnApplicationQuit0 = 55,
		Beyond-HotFix-HotFixMonobehaviour2-OnApplicationFocus0 = 56,
		Beyond-HotFix-HotFixMonobehaviour2-OnApplicationPause0 = 57,
		Beyond-HotFix-HotFixMonobehaviour2-OnBecameInvisible0 = 58,
		Beyond-HotFix-HotFixMonobehaviour2-OnBecameVisible0 = 59,
		Beyond-HotFix-HotFixMonobehaviour2-Do0 = 60,
		Beyond-HotFix-HotFixMonobehaviour2-Func10 = 61,
		Beyond-HotFix-HotFixMonobehaviour2-Func20 = 62,
		Beyond-HotFix-HotFixMonobehaviour2-Func30 = 63,
		Beyond-HotFix-HotFixMonobehaviour2-Func40 = 64,
		Beyond-HotFix-HotFixMonobehaviour2-Func50 = 65,
		Beyond-HotFix-HotFixMonobehaviour3-Awake0 = 66,
		Beyond-HotFix-HotFixMonobehaviour3-OnEnable0 = 67,
		Beyond-HotFix-HotFixMonobehaviour3-OnDisable0 = 68,
		Beyond-HotFix-HotFixMonobehaviour3-Start0 = 69,
		Beyond-HotFix-HotFixMonobehaviour3-Update0 = 70,
		Beyond-HotFix-HotFixMonobehaviour3-LateUpdate0 = 71,
		Beyond-HotFix-HotFixMonobehaviour3-OnDestroy0 = 72,
		Beyond-HotFix-HotFixMonobehaviour3-FixedUpdate0 = 73,
		Beyond-HotFix-HotFixMonobehaviour3-OnCollisionEnter0 = 74,
		Beyond-HotFix-HotFixMonobehaviour3-OnCollisionExit0 = 75,
		Beyond-HotFix-HotFixMonobehaviour3-OnCollisionStay0 = 76,
		Beyond-HotFix-HotFixMonobehaviour3-OnTriggerEnter0 = 77,
		Beyond-HotFix-HotFixMonobehaviour3-OnTriggerExit0 = 78,
		Beyond-HotFix-HotFixMonobehaviour3-OnTriggerStay0 = 79,
		Beyond-HotFix-HotFixMonobehaviour3-OnApplicationQuit0 = 80,
		Beyond-HotFix-HotFixMonobehaviour3-OnApplicationFocus0 = 81,
		Beyond-HotFix-HotFixMonobehaviour3-OnApplicationPause0 = 82,
		Beyond-HotFix-HotFixMonobehaviour3-OnBecameInvisible0 = 83,
		Beyond-HotFix-HotFixMonobehaviour3-OnBecameVisible0 = 84,
		Beyond-HotFix-HotFixMonobehaviour3-Do0 = 85,
		Beyond-HotFix-HotFixMonobehaviour3-Func10 = 86,
		Beyond-HotFix-HotFixMonobehaviour3-Func20 = 87,
		Beyond-HotFix-HotFixMonobehaviour3-Func30 = 88,
		Beyond-HotFix-HotFixMonobehaviour3-Func40 = 89,
		Beyond-HotFix-HotFixMonobehaviour3-Func50 = 90,
		Beyond-HotFix-HotFixPatchManagerProxy-_RunOnStart0 = 91,
		Beyond-HotFix-HotFixPatchManagerProxy-InitManager0 = 92,
		Beyond-HotFix-HotFixPatchManagerProxy-_OnHotfixDownloadReady0 = 93,
		Beyond-HotFix-HotFixPatchManagerProxy-_ApplyDownloadPayload0 = 94,
		Beyond-HotFix-HotFixPatchManager-InjectLuaStringPatch0 = 95,
		Beyond-HotFix-HotFixPatchManager-_InjectLuaStringPatchJson0 = 96,
		Beyond-HotFix-HotFixPatchManager-_TryApplyLuaPatchBase640 = 97,
		Beyond-HotFix-HotFixPatchManager-_InjectLuaStringPatchLine0 = 98,
		Beyond-HotFix-HotFixPatchManager-InjectStringPatch0 = 99,
		Beyond-HotFix-HotFixPatchManager-_InjectStringPatchJson0 = 100,
		Beyond-HotFix-HotFixPatchManager-PatchDebugAssemble0 = 101,
		Beyond-HotFix-HotFixPatchManager-_InjectStringPatchLine0 = 102,
		Beyond-HotFix-HotFixPatchManagerProxy-_PatchRemoteInjectedLua0 = 103,
		Beyond-HotFix-HotFixPatchManagerProxy-ReleaseManager0 = 104,
		Beyond-HotFix-HotFixPatchManager-Release0 = 105,
		Beyond-HotFix-HotFixPatchManager-_UnInit0 = 106,
		Beyond-HotFix-HotFixPatchManager-_ClearTickFunction0 = 107,
		Beyond-HotFix-HotFixPatchManagerProxy-OnReturnToLogin0 = 108,
		Beyond-HotFix-HotFixPatchManager-ClearPatchesForRelogin0 = 109,
		Beyond-HotFix-HotFixPatchManagerProxy-RegisterHotfixSDKEvent0 = 110,
		Beyond-HotFix-HotFixPatchManagerProxy-UnregisterHotfixSDKEvent0 = 111,
		Beyond-HotFix-HotFixPatchManagerProxy-TryProcessHotfixSDKExtraInfo0 = 112,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchInitAssemble0 = 113,
		Beyond-HotFix-HotFixPatchManager-PatchInitAssemble0 = 114,
		Beyond-HotFix-HotFixPatchManager-PatchAssemble0 = 118,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchRemoteInitAssemble0 = 119,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchRemoteInjectedLua0 = 120,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchMainAssemble0 = 121,
		Beyond-HotFix-HotFixPatchManager-PatchMainAssemble0 = 122,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchRemoteMainAssemble0 = 123,
		Beyond-HotFix-HotFixPatchManager-get_currentPatchVersion0 = 124,
		Beyond-HotFix-HotFixPatchManager-_Init0 = 125,
		Beyond-HotFix-HotFixPatchManager-_CreateTickFunction0 = 126,
		Beyond-HotFix-HotFixPatchManager-Tick0 = 127,
		Beyond-HotFix-HotFixPatchManager-_ForceLocalUpdateIFix0 = 128,
		Beyond-HotFix-HotFixPatchManager-_ForceLocalUpdateLua0 = 129,
		Beyond-HotFix-HotFixPatchManager-InjectLuaStringPatchFromUrl0 = 130
	}
}

namespace IFix.Bridge
{
	[CustomBridge]
	public static class ILFixWarpBridge // TypeDefIndex: 61583
	{
		// Fields
		private static List<System.Type> bridge; // 0x00
	
		// Constructors
		static ILFixWarpBridge(); // 0x0000000189E245CC-0x0000000189E26238
	}
}
