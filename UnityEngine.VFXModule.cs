/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 121: UnityEngine.VFXModule.dll - Assembly: UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59974-59984

namespace UnityEngine.VFX
{
	[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
	[RequiredByNativeCode]
	public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 59975
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
		private bool m_Owner; // 0x18
		private VisualEffectAsset m_VfxAsset; // 0x20
	
		// Constructors
		public VFXEventAttribute() {} // Dummy constructor
		private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) {} // 0x0000000189F893C0-0x0000000189F893D8
	
		// Methods
		internal static VFXEventAttribute CreateEventAttributeWrapper() => default; // 0x0000000189F890D0-0x0000000189F8912C
		internal void SetWrapValue(IntPtr ptrToEventAttribute) {} // 0x0000000189F89354-0x0000000189F893C0
		internal static IntPtr Internal_Create() => default; // 0x0000000189F891E8-0x0000000189F89214
		internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) => default; // 0x0000000189F8928C-0x0000000189F89318
		internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) {} // 0x0000000189F89248-0x0000000189F8928C
		private void Release() {} // 0x0000000189F89318-0x0000000189F89354
		~VFXEventAttribute() {} // 0x0000000189F89178-0x0000000189F891E8
		public void Dispose() {} // 0x0000000189F8912C-0x0000000189F89178
		[NativeMethod(IsThreadSafe = true)]
		internal static void Internal_Destroy(IntPtr ptr) {} // 0x0000000189F89214-0x0000000189F89248
	}

	[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
	[RequiredByNativeCode]
	public class VFXExpressionValues // TypeDefIndex: 59976
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		private VFXExpressionValues() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RequiredByNativeCode]
		internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) => default; // 0x0000000189F893D8-0x0000000189F89420
	}

	[RequiredByNativeCode]
	public struct VFXCameraXRSettings // TypeDefIndex: 59977
	{
		// Fields
		public uint viewTotal; // 0x00
		public uint viewCount; // 0x04
		public uint viewOffset; // 0x08
	}

	[NativeHeader("Modules/VFX/Public/VFXManager.h")]
	[RequiredByNativeCode]
	[StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
	public static class VFXManager // TypeDefIndex: 59978
	{
		// Fields
		private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; // 0x00
	
		// Constructors
		static VFXManager() {} // 0x0000000189F89420-0x0000000189F89474
	}

	[Serializable]
	[RequiredByNativeCode]
	public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 59979
	{
		// Constructors
		protected VFXSpawnerCallbacks() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
		public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
		public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
	}

	[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
	[RequiredByNativeCode]
	public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 59980
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
		private bool m_Owner; // 0x18
		private VFXEventAttribute m_WrapEventAttribute; // 0x20
	
		// Constructors
		public VFXSpawnerState() {} // Dummy constructor
		internal VFXSpawnerState(IntPtr ptr, bool owner) {} // 0x0000000183D89F10-0x0000000183D89F20
	
		// Methods
		[RequiredByNativeCode]
		internal static VFXSpawnerState CreateSpawnerStateWrapper() => default; // 0x0000000189F89474-0x0000000189F894CC
		private void PrepareWrapper() {} // 0x0000000189F895BC-0x0000000189F89690
		[RequiredByNativeCode]
		internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) {} // 0x0000000189F896CC-0x0000000189F897A4
		private void Release() {} // 0x0000000189F89690-0x0000000189F896CC
		~VFXSpawnerState() {} // 0x0000000189F89518-0x0000000189F89588
		public void Dispose() {} // 0x0000000189F894CC-0x0000000189F89518
		[NativeMethod(IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr) {} // 0x0000000189F89588-0x0000000189F895BC
	}

	[NativeHeader("VFXScriptingClasses.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
	[UsedByNativeCode]
	public abstract class VisualEffectObject : UnityEngine.Object // TypeDefIndex: 59981
	{
		// Constructors
		protected VisualEffectObject() {} // 0x0000000189F89828-0x0000000189F89868
	}

	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	[NativeHeader("VFXScriptingClasses.h")]
	[UsedByNativeCode]
	public class VisualEffectAsset : VisualEffectObject // TypeDefIndex: 59982
	{
		// Fields
		public static readonly int PlayEventID; // 0x00
		public static readonly int StopEventID; // 0x04
	
		// Constructors
		public VisualEffectAsset() {} // 0x0000000189F89820-0x0000000189F89828
		static VisualEffectAsset() {} // 0x0000000189F897A4-0x0000000189F89820
	}

	public struct VFXOutputEventArgs // TypeDefIndex: 59983
	{
		// Constructors
		public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute) {} // 0x00000001871AED58-0x00000001871AED68
	}

	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
	[RequireComponent(typeof(Transform))]
	public class VisualEffect : UnityEngine.Behaviour // TypeDefIndex: 59984
	{
		// Fields
		private VFXEventAttribute m_cachedEventAttribute; // 0x18
		public Action<VFXOutputEventArgs> outputEventReceived; // 0x20
	
		// Properties
		public VisualEffectAsset visualEffectAsset { get => default; } // 0x0000000189F89980-0x0000000189F899B4 
	
		// Constructors
		public VisualEffect() {} // Dummy constructor
	
		// Methods
		public VFXEventAttribute CreateVFXEventAttribute() => default; // 0x0000000189F89868-0x0000000189F898EC
		[RequiredByNativeCode]
		private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) => default; // 0x0000000189F898EC-0x0000000189F8992C
		[RequiredByNativeCode]
		private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) {} // 0x0000000189F8992C-0x0000000189F89980
	}
}
