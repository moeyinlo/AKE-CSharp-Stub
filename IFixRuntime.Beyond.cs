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

// Image 61: IFixRuntime.Beyond.dll - Assembly: IFixRuntime.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88825-88869

namespace Beyond.HotFix
{
	public static class HotfixDownload // TypeDefIndex: 88843
	{
		// Fields
		private const string HOTFIX_SDK_TYPE = "hotfix"; // Metadata: 0x02648788
		private const string SDK_MSG_TYPE_KEY = "type"; // Metadata: 0x0264878F
		private const string SDK_MSG_CONTENT_KEY = "msg"; // Metadata: 0x02648794
		private static bool s_registered; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DownloadAndApplyCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 88842
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DownloadAndApplyCoroutine_d__11(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018C264104-0x000000018C264180
			private bool MoveNext(); // 0x00000001863A17D0-0x00000001863A2600
			private void __m__Finally1(); // 0x00000001863A2600-0x00000001863A2650
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C2640B8-0x000000018C264104
		}
	
		// Methods
		public static void RegisterSDKEvent(); // 0x00000001850CCC30-0x00000001850CCE00
		public static void UnregisterSDKEvent(); // 0x000000018C25AC88-0x000000018C25AD88
		public static bool TryProcessSDKExtraInfo(int code, Dictionary<string, object> msg); // 0x0000000186B844E0-0x0000000186B845D0
		public static void DownloadAndApply(string url); // 0x0000000186B845D0-0x0000000186B84690
		public static bool TryApplyDownloadText(string downloadText); // 0x00000001863A2650-0x00000001863A2770
		public static bool TryDecodeDownloadText(string downloadText, out string json); // 0x00000001863A2770-0x00000001863A28F0
		private static string _TryDecryptSignedAesField(string base64Data, string fieldName); // 0x00000001863A2990-0x00000001863A3310
		[IteratorStateMachine(typeof(__DownloadAndApplyCoroutine_d__11))]
		private static IEnumerator _DownloadAndApplyCoroutine(string url); // 0x0000000186B84690-0x0000000186B84710
		private static bool _IsValidHttpsUrl(string url); // 0x0000000186B84710-0x0000000186B847F0
		private static T _GetValueSafe<T>(Dictionary<string, object> dict, string key, T defaultValue = default);
	}

	public class HotFixMonobehaviour1 : MonoBehaviour // TypeDefIndex: 88844
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
		public HotFixMonobehaviour1(); // 0x00000001878364A0-0x00000001878364B8
		static HotFixMonobehaviour1(); // 0x000000018C256CD0-0x000000018C256FF4
	
		// Methods
		private void Awake(); // 0x000000018C2567B4-0x000000018C2567E8
		private void OnEnable(); // 0x000000018C256B8C-0x000000018C256BC0
		private void OnDisable(); // 0x000000018C256B58-0x000000018C256B8C
		private void Start(); // 0x000000018C256C68-0x000000018C256C9C
		private void Update(); // 0x000000018C256C9C-0x000000018C256CD0
		private void LateUpdate(); // 0x000000018C25693C-0x000000018C256970
		private void OnDestroy(); // 0x000000018C256B24-0x000000018C256B58
		private void FixedUpdate(); // 0x000000018C256818-0x000000018C25684C
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x000000018C256A7C-0x000000018C256AB4
		private void OnCollisionExit(UnityEngine.Collision other); // 0x000000018C256AB4-0x000000018C256AEC
		private void OnCollisionStay(UnityEngine.Collision other); // 0x000000018C256AEC-0x000000018C256B24
		private void OnTriggerEnter(Collider other); // 0x000000018C256BC0-0x000000018C256BF8
		private void OnTriggerExit(Collider other); // 0x000000018C256BF8-0x000000018C256C30
		private void OnTriggerStay(Collider other); // 0x000000018C256C30-0x000000018C256C68
		private void OnApplicationQuit(); // 0x000000018C2569E0-0x000000018C256A14
		private void OnApplicationFocus(bool hasFocus); // 0x000000018C256970-0x000000018C2569A8
		private void OnApplicationPause(bool pauseStatus); // 0x000000018C2569A8-0x000000018C2569E0
		private void OnBecameInvisible(); // 0x000000018C256A14-0x000000018C256A48
		private void OnBecameVisible(); // 0x000000018C256A48-0x000000018C256A7C
		public static void Do(); // 0x000000018C2567E8-0x000000018C256818
		public static void Func1(); // 0x000000018C25684C-0x000000018C25687C
		public static void Func2(); // 0x000000018C25687C-0x000000018C2568AC
		public static void Func3(); // 0x000000018C2568AC-0x000000018C2568DC
		public static void Func4(); // 0x000000018C2568DC-0x000000018C25690C
		public static void Func5(); // 0x000000018C25690C-0x000000018C25693C
	}

	public class HotFixMonobehaviour2 : MonoBehaviour // TypeDefIndex: 88845
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
		public HotFixMonobehaviour2(); // 0x00000001878364A0-0x00000001878364B8
		static HotFixMonobehaviour2(); // 0x000000018C257510-0x000000018C257834
	
		// Methods
		private void Awake(); // 0x000000018C256FF4-0x000000018C257028
		private void OnEnable(); // 0x000000018C2573CC-0x000000018C257400
		private void OnDisable(); // 0x000000018C257398-0x000000018C2573CC
		private void Start(); // 0x000000018C2574A8-0x000000018C2574DC
		private void Update(); // 0x000000018C2574DC-0x000000018C257510
		private void LateUpdate(); // 0x000000018C25717C-0x000000018C2571B0
		private void OnDestroy(); // 0x000000018C257364-0x000000018C257398
		private void FixedUpdate(); // 0x000000018C257058-0x000000018C25708C
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x000000018C2572BC-0x000000018C2572F4
		private void OnCollisionExit(UnityEngine.Collision other); // 0x000000018C2572F4-0x000000018C25732C
		private void OnCollisionStay(UnityEngine.Collision other); // 0x000000018C25732C-0x000000018C257364
		private void OnTriggerEnter(Collider other); // 0x000000018C257400-0x000000018C257438
		private void OnTriggerExit(Collider other); // 0x000000018C257438-0x000000018C257470
		private void OnTriggerStay(Collider other); // 0x000000018C257470-0x000000018C2574A8
		private void OnApplicationQuit(); // 0x000000018C257220-0x000000018C257254
		private void OnApplicationFocus(bool hasFocus); // 0x000000018C2571B0-0x000000018C2571E8
		private void OnApplicationPause(bool pauseStatus); // 0x000000018C2571E8-0x000000018C257220
		private void OnBecameInvisible(); // 0x000000018C257254-0x000000018C257288
		private void OnBecameVisible(); // 0x000000018C257288-0x000000018C2572BC
		public static void Do(); // 0x000000018C257028-0x000000018C257058
		public static void Func1(); // 0x000000018C25708C-0x000000018C2570BC
		public static void Func2(); // 0x000000018C2570BC-0x000000018C2570EC
		public static void Func3(); // 0x000000018C2570EC-0x000000018C25711C
		public static void Func4(); // 0x000000018C25711C-0x000000018C25714C
		public static void Func5(); // 0x000000018C25714C-0x000000018C25717C
	}

	public class HotFixMonobehaviour3 : MonoBehaviour // TypeDefIndex: 88846
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
		public HotFixMonobehaviour3(); // 0x00000001878364A0-0x00000001878364B8
		static HotFixMonobehaviour3(); // 0x000000018C257D50-0x000000018C258074
	
		// Methods
		private void Awake(); // 0x000000018C257834-0x000000018C257868
		private void OnEnable(); // 0x000000018C257C0C-0x000000018C257C40
		private void OnDisable(); // 0x000000018C257BD8-0x000000018C257C0C
		private void Start(); // 0x000000018C257CE8-0x000000018C257D1C
		private void Update(); // 0x000000018C257D1C-0x000000018C257D50
		private void LateUpdate(); // 0x000000018C2579BC-0x000000018C2579F0
		private void OnDestroy(); // 0x000000018C257BA4-0x000000018C257BD8
		private void FixedUpdate(); // 0x000000018C257898-0x000000018C2578CC
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x000000018C257AFC-0x000000018C257B34
		private void OnCollisionExit(UnityEngine.Collision other); // 0x000000018C257B34-0x000000018C257B6C
		private void OnCollisionStay(UnityEngine.Collision other); // 0x000000018C257B6C-0x000000018C257BA4
		private void OnTriggerEnter(Collider other); // 0x000000018C257C40-0x000000018C257C78
		private void OnTriggerExit(Collider other); // 0x000000018C257C78-0x000000018C257CB0
		private void OnTriggerStay(Collider other); // 0x000000018C257CB0-0x000000018C257CE8
		private void OnApplicationQuit(); // 0x000000018C257A60-0x000000018C257A94
		private void OnApplicationFocus(bool hasFocus); // 0x000000018C2579F0-0x000000018C257A28
		private void OnApplicationPause(bool pauseStatus); // 0x000000018C257A28-0x000000018C257A60
		private void OnBecameInvisible(); // 0x000000018C257A94-0x000000018C257AC8
		private void OnBecameVisible(); // 0x000000018C257AC8-0x000000018C257AFC
		public static void Do(); // 0x000000018C257868-0x000000018C257898
		public static void Func1(); // 0x000000018C2578CC-0x000000018C2578FC
		public static void Func2(); // 0x000000018C2578FC-0x000000018C25792C
		public static void Func3(); // 0x000000018C25792C-0x000000018C25795C
		public static void Func4(); // 0x000000018C25795C-0x000000018C25798C
		public static void Func5(); // 0x000000018C25798C-0x000000018C2579BC
	}

	public class HotFixPatchManagerProxy : IHotFixPatchManagerProxy // TypeDefIndex: 88847
	{
		// Fields
		private static HotfixDownloadPayload s_pendingDownloadPayload; // 0x00
		private static int s_currentAppliedVersion; // 0x08
	
		// Constructors
		public HotFixPatchManagerProxy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart(); // 0x000000018716EF50-0x000000018716EFF0
		public void InitManager(); // 0x00000001869BEE90-0x00000001869BF020
		public void ReleaseManager(); // 0x000000018C258138-0x000000018C258348
		public void OnReturnToLogin(); // 0x000000018C258074-0x000000018C258138
		public void RegisterHotfixSDKEvent(); // 0x00000001850CB990-0x00000001850CB9C0
		public void UnregisterHotfixSDKEvent(); // 0x000000018C258348-0x000000018C258384
		public bool TryProcessHotfixSDKExtraInfo(int code, Dictionary<string, object> msg); // 0x0000000186B847F0-0x0000000186B84830
		public void PatchInitAssemble(); // 0x00000001869BF230-0x00000001869BF2A0
		public void PatchRemoteInitAssemble(); // 0x00000001869BF020-0x00000001869BF0F0
		public void PatchRemoteInjectedLua(); // 0x00000001871F2930-0x00000001871F2960
		private void _OnHotfixDownloadReady([IsReadOnly] in HotfixDownloadEventData data); // 0x00000001869C3120-0x00000001869C31B0
		private static void _ApplyDownloadPayload(HotfixDownloadPayload payload); // 0x00000001869C27F0-0x00000001869C29F0
		private void _PatchRemoteInjectedLua(); // 0x0000000185B82710-0x0000000185B82800
		public void PatchMainAssemble(); // 0x00000001863C9A20-0x00000001863C9A90
		public void PatchRemoteMainAssemble(); // 0x00000001870841B0-0x0000000187084280
	}

	public class HotFixPatchManager : Singleton<HotFixPatchManager> // TypeDefIndex: 88849
	{
		// Fields
		private TickFunction m_tickFunction; // 0x10
		private static int s_currentPatchVersion; // 0x00
		private static HashSet<Assembly> s_patchedAssemble; // 0x08
		private static List<VirtualMachine> s_patchedVM; // 0x10
		private static HashSet<Assembly> s_downloadPatchedAssemble; // 0x18
		private static List<VirtualMachine> s_downloadPatchedVM; // 0x20
	
		// Properties
		public static int currentPatchVersion { get; } // 0x000000018C25AC14-0x000000018C25AC88 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88848
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__17_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E55A0-0x00000001871E5600
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PatchInitAssemble_b__17_0(string s); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		private HotFixPatchManager(); // 0x00000001871DDC30-0x00000001871DDC70
		static HotFixPatchManager(); // 0x00000001863CA070-0x00000001863CA220
	
		// Methods
		private void _Init(); // 0x00000001871DDC70-0x00000001871DDCA0
		private void _UnInit(); // 0x000000018C25ABE4-0x000000018C25AC14
		public void Release(); // 0x000000018C2589A4-0x000000018C2589D4
		private void _CreateTickFunction(); // 0x0000000185C2CDB0-0x0000000185C2CED0
		private void _ClearTickFunction(); // 0x000000018C2589D4-0x000000018C258A34
		private static void UnloadIncrementalPatchVMs(List<VirtualMachine> patchedVMs); // 0x000000018494C2E0-0x000000018494CF30
		private static void UnloadLegacyPatches(HashSet<Assembly> patchedAssemblies); // 0x000000018494CF30-0x000000018494E2F0
		private static HashSet<Assembly> CollectPatchAssemblies(List<VirtualMachine> patchedVMs); // 0x0000000184949990-0x000000018494AB60
		public static void PatchInitAssemble(); // 0x00000001863CA220-0x00000001863CA4B0
		public static void PatchMainAssemble(); // 0x00000001863C9F10-0x00000001863CA070
		public void Tick(float deltaTime); // 0x000000018559EEB0-0x000000018559EF50
		private void _ForceLocalUpdateIFix(); // 0x000000018C258A34-0x000000018C258B4C
		private void _ForceLocalUpdateLua(); // 0x000000018C258B4C-0x000000018C258C64
		public static int InjectStringPatch(string value); // 0x000000018C2583BC-0x000000018C2584E4
		public static int InjectLuaStringPatch(string value); // 0x00000001869C29F0-0x00000001869C2AA0
		public static void InjectLuaStringPatchFromUrl(string url); // 0x000000018C258384-0x000000018C2583BC
		private static int _InjectStringPatchLine(string value); // 0x000000018C259CA0-0x000000018C25A594
		private static int _InjectStringPatchJson(string value); // 0x000000018C259044-0x000000018C259CA0
		private static int _InjectLuaStringPatchLine(string value); // 0x000000018C258C64-0x000000018C259044
		private static int _InjectLuaStringPatchJson(string value); // 0x00000001869C2AA0-0x00000001869C2FA0
		private static bool _TryApplyLuaPatchBase64(string base64Data, int expectedSize, string md5, string patchName); // 0x000000018C25A594-0x000000018C25ABE4
		public static void PatchDebugAssemble(Stream stream, bool isDownload = false /* Metadata: 0x02648798 */); // 0x000000018C2584E4-0x000000018C2589A4
		public static void ReloadPatchesForRelogin(); // 0x000000018494AB60-0x000000018494C2E0
		public static int PatchAssemble(); // 0x00000001863CB7B0-0x00000001863CEFC0
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 88835
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 88836
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 88837
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 88838
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 88839
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 88840
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 88841
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 88826
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class IFixMethodPrinter // TypeDefIndex: 88833
	{
		// Fields
		private System.Reflection.FieldInfo unmanagedCodesField; // 0x10
		private PropertyInfo exceptionHandlersProperty; // 0x18
		private PropertyInfo externMethodsProperty; // 0x20
	
		// Nested types
		private class WrapperArrayCandidate // TypeDefIndex: 88827
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
			public WrapperArrayCandidate(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public object GetValue(int index); // 0x000000018C264180-0x000000018C2641A0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88828
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, string>, int> __9__7_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C264054-0x000000018C2640B8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetAllIFixMethodStrs_b__7_0(KeyValuePair<int, string> k); // 0x000000018C263FE0-0x000000018C264014
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 88829
		{
			// Fields
			public Array arr; // 0x10
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _TryGetWrapperArrayDirect_b__0(int i); // 0x000000018C264014-0x000000018C264034
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 88830
		{
			// Fields
			public Array arr; // 0x10
			public IList listValue; // 0x18
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _AddWrapperCandidate_b__0(int i); // 0x000000018C264014-0x000000018C264034
			internal object _AddWrapperCandidate_b__1(int i); // 0x000000018C264034-0x000000018C264054
		}
	
		[CompilerGenerated]
		private sealed class _GetAllFieldsIncludingBase_d__29 : IEnumerable<System.Reflection.FieldInfo>, IEnumerator<System.Reflection.FieldInfo> // TypeDefIndex: 88831
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
			System.Reflection.FieldInfo IEnumerator<System.Reflection.FieldInfo>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllFieldsIncludingBase_d__29(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C263B80-0x000000018C263CC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C263D64-0x000000018C263DB0
			[DebuggerHidden]
			IEnumerator<System.Reflection.FieldInfo> IEnumerable<FieldInfo>.GetEnumerator(); // 0x000000018C263CC0-0x000000018C263D5C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C263D5C-0x000000018C263D64
		}
	
		[CompilerGenerated]
		private sealed class _GetAllPropertiesIncludingBase_d__30 : IEnumerable<PropertyInfo>, IEnumerator<PropertyInfo> // TypeDefIndex: 88832
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
			PropertyInfo IEnumerator<System.Reflection.PropertyInfo>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllPropertiesIncludingBase_d__30(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C263DB0-0x000000018C263EF0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C263F94-0x000000018C263FE0
			[DebuggerHidden]
			IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator(); // 0x000000018C263EF0-0x000000018C263F8C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C263F8C-0x000000018C263F94
		}
	
		// Constructors
		public IFixMethodPrinter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private void InitializeReflection(); // 0x000000018C260138-0x000000018C26028C
		private int GetMethodCount(VirtualMachine vm); // 0x000000018C25F94C-0x000000018C25F9CC
		private IFix.Core.Instruction[] GetMethodInstructions(VirtualMachine vm, int methodIndex); // 0x000000018C25F9CC-0x000000018C25FD1C
		private unsafe int EstimateInstructionCount(IFix.Core.Instruction* codePtr); // 0x000000018C25DEE0-0x000000018C25DF34
		public string GetAllIFixMethodStrs(VirtualMachine vm); // 0x000000018C25E458-0x000000018C25F8CC
		private void DumpRedirectToMappings(StringBuilder sb, WrappersManager wrappersManager); // 0x000000018C25D478-0x000000018C25D7E8
		private Dictionary<int, string> BuildIdMap(Assembly preferredAssembly); // 0x000000018C25B6F0-0x000000018C25BA84
		private void ForceLoadIdMapTypes(Dictionary<int, string> result); // 0x000000018C25DF34-0x000000018C25E1C0
		private void AddIdMapFields(Dictionary<int, string> result, System.Type idMapType); // 0x000000018C25AD88-0x000000018C25AF64
		private string BuildMethodLabelFromIdMapField(System.Reflection.FieldInfo field); // 0x000000018C25BA84-0x000000018C25BC1C
		private bool IsNumericField(System.Type type); // 0x000000018C26028C-0x000000018C260448
		private List<WrapperArrayCandidate> CollectWrapperArrays(WrappersManager wrappersManager); // 0x000000018C25C0A4-0x000000018C25CC68
		private List<WrapperArrayCandidate> CollectWrapperArraysFromAssembly(Assembly asm); // 0x000000018C25BC1C-0x000000018C25C0A4
		private WrapperArrayCandidate SelectBestWrapperArray(List<WrapperArrayCandidate> candidates, Dictionary<int, string> idMap); // 0x000000018C260760-0x000000018C260938
		private WrapperArrayCandidate TryGetWrapperArrayDirect(Assembly asm); // 0x000000018C260C98-0x000000018C261000
		private string TryResolveWrapperTarget(object wrapperObj); // 0x000000018C2613A8-0x000000018C2618A8
		private string GetWrapperDebugInfo(object wrapperObj); // 0x000000018C25FD1C-0x000000018C260138
		private string SummarizeValue(object val); // 0x000000018C260938-0x000000018C260C98
		private int? TryGetWrapperMethodId(object wrapperObj); // 0x000000018C261000-0x000000018C2613A8
		private void AppendILSummary(StringBuilder sb, VirtualMachine vm, int methodId, MethodBase[] externMethods); // 0x000000018C25B340-0x000000018C25B6F0
		private string FormatOperand(VirtualMachine vm, IFix.Core.Instruction inst, MethodBase[] externMethods); // 0x000000018C25E1C0-0x000000018C25E3D8
		private int ScoreWrapperCandidate(WrapperArrayCandidate candidate, int minLen); // 0x000000018C260448-0x000000018C260760
		private void AddWrapperCandidate(List<WrapperArrayCandidate> list, string source, string ownerTypeName, string name, System.Type valueType, object value); // 0x000000018C25AF64-0x000000018C25B340
		private void DumpWrappersManagerMembers(StringBuilder sb, WrappersManager wrappersManager); // 0x000000018C25D7E8-0x000000018C25DEE0
		private void DumpAssemblyPotentialStores(StringBuilder sb, Assembly asm); // 0x000000018C25CDB4-0x000000018C25D478
		[IteratorStateMachine(typeof(_GetAllFieldsIncludingBase_d__29))]
		private IEnumerable<System.Reflection.FieldInfo> GetAllFieldsIncludingBase(System.Type type, System.Reflection.BindingFlags flags); // 0x000000018C25E3D8-0x000000018C25E458
		[IteratorStateMachine(typeof(_GetAllPropertiesIncludingBase_d__30))]
		private IEnumerable<PropertyInfo> GetAllPropertiesIncludingBase(System.Type type, System.Reflection.BindingFlags flags); // 0x000000018C25F8CC-0x000000018C25F94C
		private string DescribeValue(object value); // 0x000000018C25CC68-0x000000018C25CDB4
	}

	public class ILFixDynamicMethodWrapper // TypeDefIndex: 88850
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018C261EB0-0x000000018C261F14
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001887ED074-0x00000001887ED104
		public bool __Gen_Wrap_1(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public string __Gen_Wrap_2(object P0, object P1); // 0x000000018C2619C0-0x000000018C261AC0
		public bool __Gen_Wrap_3(object P0, out string P1); // 0x000000018C261AC0-0x000000018C261BE8
		public IEnumerator __Gen_Wrap_4(object P0); // 0x000000018C261BE8-0x000000018C261CC8
		public void __Gen_Wrap_5(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public bool __Gen_Wrap_6(int P0, object P1); // 0x000000018C261CC8-0x000000018C261DA4
		public void __Gen_Wrap_7(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public void __Gen_Wrap_8(object P0, bool P1); // 0x000000018936C508-0x000000018936C5D8
		public bool __Gen_Wrap_9(object P0, int P1, object P2, object P3); // 0x000000018C261DA4-0x000000018C261EB0
		public int __Gen_Wrap_10(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public void __Gen_Wrap_11(object P0, in HotfixDownloadEventData P1); // 0x000000018C2618A8-0x000000018C2619C0
		public HashSet<Assembly> __Gen_Wrap_12(object P0); // 0x00000001849541A0-0x0000000184954AC0
		public bool __Gen_Wrap_13(object P0, int P1, object P2); // 0x00000001827BAA70-0x00000001827BAE20
		public void __Gen_Wrap_14(string P0); // 0x0000000182510780-0x0000000182510A40
		public int __Gen_Wrap_15(); // 0x00000001825212D0-0x00000001825214A0
		public void __Gen_Wrap_16(object P0, float P1); // 0x0000000182659420-0x0000000182659700
		public void __Gen_Wrap_17(object P0, PropertyChangedEventArgs P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_18(Misc.ObjectRef P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_19(U8MockLogin P0); // 0x0000000184959A10-0x0000000184959FB0
		public SDKPromise<U8PayResult> __Gen_Wrap_20(U8PayParams P0); // 0x0000000184959FB0-0x000000018495A8D0
		public void __Gen_Wrap_21(U8PayResult P0); // 0x000000018495A8D0-0x000000018495AE70
		public SDKMeta __Gen_Wrap_22(); // 0x000000018495AE70-0x000000018495B690
		public void __Gen_Wrap_23(Dictionary<Enum, TickGroupMonitorItem> P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_24(int P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_25(float P0); // 0x0000000182541570-0x0000000182541760
		public void __Gen_Wrap_26(bool P0); // 0x0000000182521C80-0x0000000182521E70
		public void __Gen_Wrap_27(UnityEngine.HyperGryph.ECS.Entity P0, float3 P1, float3 P2, Matrix4x4 P3); // 0x000000018495B690-0x000000018495C400
		public void __Gen_Wrap_28(UnityEngine.HyperGryph.ECS.Entity P0); // 0x000000018495C400-0x000000018495C990
		public void __Gen_Wrap_29(NativeArray<UnityEngine.HyperGryph.ECS.Entity> P0, int P1); // 0x000000018495C990-0x000000018495CF50
		public void __Gen_Wrap_30(UnityEngine.HyperGryph.ECS.EntityManager P0, UnityEngine.HyperGryph.ECS.Entity P1); // 0x000000018495CF50-0x000000018495D840
		public void __Gen_Wrap_31(object P0, AudioCallbackType P1, AudioCallbackInfo P2); // 0x000000018495D840-0x000000018495DEC0
		public void __Gen_Wrap_32(TMP_TextInfo P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_33(GameObject P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_34(int P0, GameObject P1); // 0x0000000182220EE0-0x00000001822211B0
		public void __Gen_Wrap_35(int P0, bool P1); // 0x0000000183592390-0x0000000183592590
		public void __Gen_Wrap_36(int P0, UIDropdownOption P1, bool P2); // 0x00000001827BBD00-0x00000001827BC000
		public void __Gen_Wrap_37(int P0, UIDropdown P1); // 0x0000000182220EE0-0x00000001822211B0
		public void __Gen_Wrap_38(int P0, UIMultiSelectDropdown P1); // 0x0000000182220EE0-0x00000001822211B0
		public void __Gen_Wrap_39(bool P0, string P1, string P2); // 0x00000001825A9F60-0x00000001825AA300
		public void __Gen_Wrap_40(HGTerrainHelper P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_41(Vector2Int P0); // 0x000000018495DEC0-0x000000018495E460
		public bool __Gen_Wrap_42(UnityEngine.Vector2 P0); // 0x000000018495E460-0x000000018495EA10
		public void __Gen_Wrap_43(Vector2Int P0); // 0x000000018495EA10-0x000000018495EFA0
		public float __Gen_Wrap_44(); // 0x0000000182552560-0x0000000182552730
		public float __Gen_Wrap_45(Light P0, Camera P1, UnityEngine.Vector3 P2); // 0x000000018495EFA0-0x000000018495F710
		public RTHandle __Gen_Wrap_46(int P0); // 0x000000018495F710-0x000000018495FF70
		public void __Gen_Wrap_47(RenderTargetIdentifier P0, CommandBuffer P1); // 0x000000018495FF70-0x0000000184960600
		public bool __Gen_Wrap_48(System.Reflection.FieldInfo P0); // 0x00000001822262C0-0x0000000182226590
		public object __Gen_Wrap_49(); // 0x0000000184960600-0x0000000184960E20
		public bool __Gen_Wrap_50(); // 0x0000000182541760-0x0000000182541930
		public uint __Gen_Wrap_51(); // 0x00000001825212D0-0x00000001825214A0
		public void __Gen_Wrap_52(uint P0); // 0x0000000182220CF0-0x0000000182220EE0
		public Enum __Gen_Wrap_53(); // 0x0000000184960E20-0x0000000184961640
		public void __Gen_Wrap_54(Enum P0); // 0x0000000182510780-0x0000000182510A40
		public UnityEngine.Color __Gen_Wrap_55(); // 0x0000000184961640-0x0000000184961E20
		public void __Gen_Wrap_56(UnityEngine.Color P0); // 0x0000000184961E20-0x00000001849623C0
		public UnityEngine.Vector2 __Gen_Wrap_57(); // 0x00000001849623C0-0x0000000184962BC0
		public void __Gen_Wrap_58(UnityEngine.Vector2 P0); // 0x0000000184962BC0-0x0000000184963160
		public UnityEngine.Vector3 __Gen_Wrap_59(); // 0x0000000184963160-0x0000000184963950
		public void __Gen_Wrap_60(UnityEngine.Vector3 P0); // 0x0000000184963950-0x0000000184963EF0
		public Vector4 __Gen_Wrap_61(); // 0x0000000184963EF0-0x00000001849646D0
		public void __Gen_Wrap_62(Vector4 P0); // 0x00000001849646D0-0x0000000184964C70
		public void __Gen_Wrap_63(DebugUI.Panel P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_64(BaseMeshDeformer P0); // 0x0000000182510780-0x0000000182510A40
		public uint __Gen_Wrap_65(int P0); // 0x00000001824E3DB0-0x00000001824E3FB0
		public float3 __Gen_Wrap_66(int P0); // 0x0000000184964C70-0x00000001849654A0
		public quaternion __Gen_Wrap_67(int P0); // 0x00000001849654A0-0x0000000184965CC0
		public float __Gen_Wrap_68(int P0); // 0x000000018383D3B0-0x000000018383D5A0
		public Transform __Gen_Wrap_69(int P0); // 0x0000000184965CC0-0x0000000184966520
		public void __Gen_Wrap_70(MagicaAvatar P0, MagicaAvatarParts P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_71(MagicaAvatar P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_72(List<int> P0, List<int> P1, List<UnityEngine.Vector3> P2, List<UnityEngine.Vector3> P3, List<UnityEngine.Vector3> P4, List<int> P5, List<int> P6); // 0x00000001824F1940-0x00000001824F20C0
		public void __Gen_Wrap_73(CoreComponent P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_74(Animator P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_75(BaseCloth P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_76(int P0, int P1); // 0x0000000182522690-0x0000000182522890
		public void __Gen_Wrap_77(object P0, SafeSerializationEventArgs P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_78(IAsyncResult P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_79(ref NetResponse P0); // 0x0000000184966520-0x0000000184967150
		public void __Gen_Wrap_80(System.Type P0, MethodInfo P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_81(InputAction.CallbackContext P0); // 0x0000000184967150-0x00000001849676F0
		public void __Gen_Wrap_82(HGRenderPipeCallbackArgs P0); // 0x00000001849676F0-0x0000000184967C80
		public void __Gen_Wrap_83(ScriptableRenderContext P0, HGCamera P1); // 0x0000000184967C80-0x0000000184968300
		public void __Gen_Wrap_84(HGCamera P0, RTHandle P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_85(bool P0, bool P1); // 0x0000000183095940-0x0000000183095B40
		public void __Gen_Wrap_86(HttpRequestMessage P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_87(Beyond.Blackboard.DataPair P0); // 0x0000000184968300-0x00000001849688B0
		public void __Gen_Wrap_88(Beyond.Blackboard.DataPair P0); // 0x00000001849688B0-0x0000000184968E50
		public int __Gen_Wrap_89(Beyond.Blackboard.DataPair P0, Beyond.Blackboard.DataPair P1); // 0x0000000184968E50-0x0000000184969500
		public void __Gen_Wrap_90(Transform P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_91(Transform P0); // 0x00000001822262C0-0x0000000182226590
		public void __Gen_Wrap_92(Material P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_93(Texture P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_94(Shader P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_95(Mesh P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_96(Sprite P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_97(ScriptableObject P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_98(RuntimeAnimatorController P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_99(StyledBlackboard.StyledDataPair P0); // 0x0000000184969500-0x0000000184969AC0
		public void __Gen_Wrap_100(StyledBlackboard.StyledDataPair P0); // 0x000000018494E2F0-0x000000018494E8A0
		public int __Gen_Wrap_101(StyledBlackboard.StyledDataPair P0, StyledBlackboard.StyledDataPair P1); // 0x000000018494E8A0-0x000000018494EF70
		public bool __Gen_Wrap_102(GameObject P0); // 0x00000001822262C0-0x0000000182226590
		public void __Gen_Wrap_103(bool P0, IAssetLoaderHandle P1); // 0x00000001824CD140-0x00000001824CD410
		public void __Gen_Wrap_104(bool P0, FAssetProxyHandle P1); // 0x000000018494EF70-0x000000018494F520
		public void __Gen_Wrap_105(IPreloadGroup P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_106(Beyond.Resource.Runtime.Asset P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_107(BundleLoader.AssetProxy P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_108(HGRetCodeType P0, int P1); // 0x0000000182522690-0x0000000182522890
		public void __Gen_Wrap_109(HGDownloader.PauseReason P0); // 0x0000000182220CF0-0x0000000182220EE0
		public bool __Gen_Wrap_110(UnityEngine.HyperGryph.ECS.Entity P0, FlatBufferConvertContextV2 P1, EntityTransition P2); // 0x000000018494F520-0x0000000184950450
		public bool __Gen_Wrap_111(ref IntPtr P0, FlatBufferConvertContextV2 P1, EntityTransition P2); // 0x0000000184950450-0x00000001849513E0
		public bool __Gen_Wrap_112(UnityEngine.Component P0, FlatBufferConvertContextV2 P1, EntityTransition P2); // 0x00000001849513E0-0x0000000184952060
		public UnityEngine.Component __Gen_Wrap_113(GameObject P0); // 0x0000000184952060-0x0000000184952980
		public UnityEngine.Component __Gen_Wrap_114(GameObject P0, int P1); // 0x0000000184952980-0x0000000184953630
		public void __Gen_Wrap_115(ServerConfig P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_116(bool P0, LevelScriptData P1); // 0x00000001824CD140-0x00000001824CD410
		public void __Gen_Wrap_117(bool P0, InteractiveTemplateData P1); // 0x00000001824CD140-0x00000001824CD410
		public float __Gen_Wrap_118(float P0); // 0x00000001825CB750-0x00000001825CB940
		public bool __Gen_Wrap_119(ClientSingleMapMarkData P0); // 0x00000001822262C0-0x0000000182226590
		public void __Gen_Wrap_120(ClientSingleMapMarkData P0); // 0x0000000182510780-0x0000000182510A40
		public int __Gen_Wrap_121(ClientSingleMapMarkData P0, ClientSingleMapMarkData P1); // 0x0000000182224290-0x0000000182224620
		public void __Gen_Wrap_122(NodeCanvas.Framework.Graph P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_123(AICanvasGraphData P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_124(ulong P0, ulong P1, FAssetProxyHandle P2); // 0x0000000184953630-0x0000000184953C00
		public void __Gen_Wrap_125(ParamVariable P0, ParamVariable P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_126(DialogTree P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_127(CS_FACTORY_OP P0, SC_FACTORY_OP_RET P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_128(ObjectPtr<Beyond.Gameplay.Core.Entity> P0); // 0x0000000184953C00-0x00000001849541A0
		public void __Gen_Wrap_129(bool P0, EffectInstance P1); // 0x00000001824CD140-0x00000001824CD410
		public void __Gen_Wrap_130(EntityVFXControllerBase P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_131(float P0); // 0x00000001825DE800-0x00000001825DEA00
		public void __Gen_Wrap_132(FactoryUtil.TopViewBuildingInfo P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_133(AnimatorOverrideController P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_134(Beyond.Gameplay.Factory.Core.Vector2IntData P0); // 0x0000000184954AC0-0x0000000184955060
		public bool __Gen_Wrap_135(int P0, int P1); // 0x0000000182522890-0x0000000182522AA0
		public void __Gen_Wrap_136(string P0, GameObject P1); // 0x0000000182E75140-0x0000000182E754C0
		public PrefabMeshMaterialMatrixParser __Gen_Wrap_137(); // 0x0000000184955060-0x0000000184955880
		public IRemoteFactoryMessageSendable __Gen_Wrap_138(); // 0x0000000184955880-0x00000001849560A0
		public IFactoryStateProvider __Gen_Wrap_139(); // 0x00000001849560A0-0x00000001849568C0
		public bool __Gen_Wrap_140(LevelDataBlackbox P0); // 0x00000001822262C0-0x0000000182226590
		public void __Gen_Wrap_141(BeanArray<DynamicParam> P0); // 0x00000001849568C0-0x0000000184956E70
		public void __Gen_Wrap_142(ulong P0); // 0x0000000182232C20-0x0000000182232E10
		public void __Gen_Wrap_143(PossibleResponses P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_144(ResponseContext P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_145(uint P0, uint P1, VoiceResponseProcessor.EResponseDecideReason P2); // 0x0000000183C35950-0x0000000183C35B70
		public void __Gen_Wrap_146(AudioLang P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_147(AudioGameState P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_148(NodeCanvas.Framework.Status P0); // 0x0000000182220CF0-0x0000000182220EE0
		public UnityEngine.Vector3 __Gen_Wrap_149(UnityEngine.Vector3 P0); // 0x0000000184956E70-0x0000000184957A10
		public void __Gen_Wrap_150(int P0, string P1, GameObject P2); // 0x00000001825F9300-0x00000001825F96A0
		public void __Gen_Wrap_151(bool P0, BaseModelViewPart P1); // 0x00000001824CD140-0x00000001824CD410
		public void __Gen_Wrap_152(string P0, AnimMontageData P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_153(Skill.FinishType P0, int P1); // 0x0000000182522690-0x0000000182522890
		public void __Gen_Wrap_154(Skill P0); // 0x0000000182510780-0x0000000182510A40
		public Buff __Gen_Wrap_155(AbilitySystem P0, Beyond.Gameplay.Core.BuffData P1, List<Beyond.Blackboard.DataPair> P2, ulong? P3); // 0x0000000184957A10-0x00000001849587D0
		public void __Gen_Wrap_156(bool P0, Beyond.Gameplay.Core.SkillData P1); // 0x00000001824CD140-0x00000001824CD410
		public void __Gen_Wrap_157(Buff P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_158(CinematicTimelineManagerBase.TimelineHandle P0, bool P1); // 0x000000018253E590-0x000000018253E870
		public void __Gen_Wrap_159(string P0, string P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_160(Beyond.Gameplay.Core.Entity P0); // 0x0000000182510780-0x0000000182510A40
		public MovementSetting __Gen_Wrap_161(string P0); // 0x00000001849587D0-0x00000001849590F0
		public MovementSettingModifier __Gen_Wrap_162(string P0); // 0x00000001849590F0-0x0000000184959A10
		public void __Gen_Wrap_163(Section P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_164(string P0, object P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_165(Texture2D[] P0); // 0x0000000182510780-0x0000000182510A40
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 88851
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018C2641A0-0x000000018C264250 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018C264250-0x000000018C264300 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018C264300-0x000000018C2643E0
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001887F0184-0x00000001887F0204
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001887EFF14-0x00000001887EFFA4
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001887F0054-0x00000001887F00D4
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 88852
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018C2645CC-0x000000018C264630
		public static bool IsPatched(int id); // 0x000000018C2646BC-0x000000018C264738
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018C264484-0x000000018C264550
		public object CreateWrapper(int id); // 0x000000018C264550-0x000000018C2645CC
		public object InitWrapperArray(int len); // 0x000000018C264630-0x000000018C2646BC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018C2643E0-0x000000018C264484
	}

	public delegate void __HotPatchDelegate_0(); // TypeDefIndex: 88853; 0x0000000185B44B70-0x0000000185B44B80

	public enum HotPatchIDMAP0 // TypeDefIndex: 88854
	{
		Beyond-HotFix-HotfixDownload-RegisterSDKEvent0 = 0,
		Beyond-HotFix-HotfixDownload-UnregisterSDKEvent0 = 0,
		Beyond-HotFix-HotFixMonobehaviour1-Do0 = 0,
		Beyond-HotFix-HotFixMonobehaviour1-Func10 = 0,
		Beyond-HotFix-HotFixMonobehaviour1-Func20 = 0,
		Beyond-HotFix-HotFixMonobehaviour1-Func30 = 0,
		Beyond-HotFix-HotFixMonobehaviour1-Func40 = 0,
		Beyond-HotFix-HotFixMonobehaviour1-Func50 = 0,
		Beyond-HotFix-HotFixMonobehaviour2-Do0 = 0,
		Beyond-HotFix-HotFixMonobehaviour2-Func10 = 0,
		Beyond-HotFix-HotFixMonobehaviour2-Func20 = 0,
		Beyond-HotFix-HotFixMonobehaviour2-Func30 = 0,
		Beyond-HotFix-HotFixMonobehaviour2-Func40 = 0,
		Beyond-HotFix-HotFixMonobehaviour2-Func50 = 0,
		Beyond-HotFix-HotFixMonobehaviour3-Do0 = 0,
		Beyond-HotFix-HotFixMonobehaviour3-Func10 = 0,
		Beyond-HotFix-HotFixMonobehaviour3-Func20 = 0,
		Beyond-HotFix-HotFixMonobehaviour3-Func30 = 0,
		Beyond-HotFix-HotFixMonobehaviour3-Func40 = 0,
		Beyond-HotFix-HotFixMonobehaviour3-Func50 = 0,
		Beyond-HotFix-HotFixPatchManagerProxy-_RunOnStart0 = 0,
		Beyond-HotFix-HotFixPatchManager-ReloadPatchesForRelogin0 = 0,
		Beyond-HotFix-HotFixPatchManager-PatchInitAssemble0 = 0,
		Beyond-HotFix-HotFixPatchManager-PatchMainAssemble0 = 0,
		Beyond-HotFix-HotfixDownload-_IsValidHttpsUrl0 = 1,
		Beyond-HotFix-HotfixDownload-TryApplyDownloadText0 = 1,
		Beyond-HotFix-HotfixDownload-_TryDecryptSignedAesField0 = 2,
		Beyond-HotFix-HotfixDownload-TryDecodeDownloadText0 = 3,
		Beyond-HotFix-HotfixDownload-_DownloadAndApplyCoroutine0 = 4,
		Beyond-HotFix-HotfixDownload-DownloadAndApply0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-Awake0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-OnEnable0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-OnDisable0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-Start0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-Update0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-LateUpdate0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-OnDestroy0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-FixedUpdate0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-OnApplicationQuit0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-OnBecameInvisible0 = 5,
		Beyond-HotFix-HotFixMonobehaviour1-OnBecameVisible0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-Awake0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-OnEnable0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-OnDisable0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-Start0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-Update0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-LateUpdate0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-OnDestroy0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-FixedUpdate0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-OnApplicationQuit0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-OnBecameInvisible0 = 5,
		Beyond-HotFix-HotFixMonobehaviour2-OnBecameVisible0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-Awake0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-OnEnable0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-OnDisable0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-Start0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-Update0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-LateUpdate0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-OnDestroy0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-FixedUpdate0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-OnApplicationQuit0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-OnBecameInvisible0 = 5,
		Beyond-HotFix-HotFixMonobehaviour3-OnBecameVisible0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-_ApplyDownloadPayload0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-_PatchRemoteInjectedLua0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-InitManager0 = 5,
		Beyond-HotFix-HotFixPatchManager-_ClearTickFunction0 = 5,
		Beyond-HotFix-HotFixPatchManager-_UnInit0 = 5,
		Beyond-HotFix-HotFixPatchManager-Release0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-ReleaseManager0 = 5,
		Beyond-HotFix-HotFixPatchManager-UnloadIncrementalPatchVMs0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-OnReturnToLogin0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-RegisterHotfixSDKEvent0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-UnregisterHotfixSDKEvent0 = 5,
		Beyond-HotFix-HotFixPatchManager-UnloadLegacyPatches0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchInitAssemble0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchRemoteInitAssemble0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchRemoteInjectedLua0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchMainAssemble0 = 5,
		Beyond-HotFix-HotFixPatchManagerProxy-PatchRemoteMainAssemble0 = 5,
		Beyond-HotFix-HotFixPatchManager-_ForceLocalUpdateIFix0 = 5,
		Beyond-HotFix-HotFixPatchManager-_ForceLocalUpdateLua0 = 5,
		Beyond-HotFix-HotFixPatchManager-_CreateTickFunction0 = 5,
		Beyond-HotFix-HotFixPatchManager-_Init0 = 5,
		Beyond-HotFix-HotFixPatchManager-InjectLuaStringPatchFromUrl0 = 5,
		Beyond-HotFix-HotfixDownload-TryProcessSDKExtraInfo0 = 6,
		Beyond-HotFix-HotFixMonobehaviour1-OnCollisionEnter0 = 7,
		Beyond-HotFix-HotFixMonobehaviour1-OnCollisionExit0 = 7,
		Beyond-HotFix-HotFixMonobehaviour1-OnCollisionStay0 = 7,
		Beyond-HotFix-HotFixMonobehaviour1-OnTriggerEnter0 = 7,
		Beyond-HotFix-HotFixMonobehaviour1-OnTriggerExit0 = 7,
		Beyond-HotFix-HotFixMonobehaviour1-OnTriggerStay0 = 7,
		Beyond-HotFix-HotFixMonobehaviour2-OnCollisionEnter0 = 7,
		Beyond-HotFix-HotFixMonobehaviour2-OnCollisionExit0 = 7,
		Beyond-HotFix-HotFixMonobehaviour2-OnCollisionStay0 = 7,
		Beyond-HotFix-HotFixMonobehaviour2-OnTriggerEnter0 = 7,
		Beyond-HotFix-HotFixMonobehaviour2-OnTriggerExit0 = 7,
		Beyond-HotFix-HotFixMonobehaviour2-OnTriggerStay0 = 7,
		Beyond-HotFix-HotFixMonobehaviour3-OnCollisionEnter0 = 7,
		Beyond-HotFix-HotFixMonobehaviour3-OnCollisionExit0 = 7,
		Beyond-HotFix-HotFixMonobehaviour3-OnCollisionStay0 = 7,
		Beyond-HotFix-HotFixMonobehaviour3-OnTriggerEnter0 = 7,
		Beyond-HotFix-HotFixMonobehaviour3-OnTriggerExit0 = 7,
		Beyond-HotFix-HotFixMonobehaviour3-OnTriggerStay0 = 7,
		Beyond-HotFix-HotFixMonobehaviour1-OnApplicationFocus0 = 8,
		Beyond-HotFix-HotFixMonobehaviour1-OnApplicationPause0 = 8,
		Beyond-HotFix-HotFixMonobehaviour2-OnApplicationFocus0 = 8,
		Beyond-HotFix-HotFixMonobehaviour2-OnApplicationPause0 = 8,
		Beyond-HotFix-HotFixMonobehaviour3-OnApplicationFocus0 = 8,
		Beyond-HotFix-HotFixMonobehaviour3-OnApplicationPause0 = 8,
		Beyond-HotFix-HotFixPatchManager-PatchDebugAssemble0 = 8,
		Beyond-HotFix-HotFixPatchManager-_TryApplyLuaPatchBase640 = 9,
		Beyond-HotFix-HotFixPatchManager-_InjectLuaStringPatchJson0 = 10,
		Beyond-HotFix-HotFixPatchManager-_InjectLuaStringPatchLine0 = 10,
		Beyond-HotFix-HotFixPatchManager-InjectLuaStringPatch0 = 10,
		Beyond-HotFix-HotFixPatchManager-_InjectStringPatchJson0 = 10,
		Beyond-HotFix-HotFixPatchManager-_InjectStringPatchLine0 = 10,
		Beyond-HotFix-HotFixPatchManager-InjectStringPatch0 = 10,
		Beyond-HotFix-HotFixPatchManagerProxy-_OnHotfixDownloadReady0 = 11,
		Beyond-HotFix-HotFixPatchManager-CollectPatchAssemblies0 = 12,
		Beyond-HotFix-HotFixPatchManagerProxy-TryProcessHotfixSDKExtraInfo0 = 13,
		Beyond-HotFix-HotFixPatchManager-PatchAssemble0 = 14,
		Beyond-HotFix-HotFixPatchManager-get_currentPatchVersion0 = 14,
		Beyond-HotFix-HotFixPatchManager-Tick0 = 15
	}

	public delegate bool __HotPatchDelegate_1(object P0); // TypeDefIndex: 88855; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_2(object P0, object P1); // TypeDefIndex: 88856; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_3(object P0, out string P1); // TypeDefIndex: 88857; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_4(object P0); // TypeDefIndex: 88858; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_5(object P0); // TypeDefIndex: 88859; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_6(int P0, object P1); // TypeDefIndex: 88860; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_7(object P0, object P1); // TypeDefIndex: 88861; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_8(object P0, bool P1); // TypeDefIndex: 88862; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_9(object P0, int P1, object P2, object P3); // TypeDefIndex: 88863; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_10(object P0); // TypeDefIndex: 88864; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_11(object P0, in HotfixDownloadEventData P1); // TypeDefIndex: 88865; 0x00000001859B7730-0x00000001859B7740

	public delegate HashSet<Assembly> __HotPatchDelegate_12(object P0); // TypeDefIndex: 88866; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_13(object P0, int P1, object P2); // TypeDefIndex: 88867; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_14(); // TypeDefIndex: 88868; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_15(object P0, float P1); // TypeDefIndex: 88869; 0x00000001859B7730-0x00000001859B7740
}

namespace IFix.Bridge
{
	[CustomBridge]
	public static class ILFixWarpBridge // TypeDefIndex: 88834
	{
		// Fields
		private static List<System.Type> bridge; // 0x00
	
		// Constructors
		static ILFixWarpBridge(); // 0x000000018C261F14-0x000000018C263B80
	}
}
