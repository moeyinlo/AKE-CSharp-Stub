/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 126: UnityEngine.VFXModule.dll - Assembly: UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91161-91171

namespace UnityEngine.VFX
{
	[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
	[RequiredByNativeCode]
	public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 91162
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
		private bool m_Owner; // 0x18
		private VisualEffectAsset m_VfxAsset; // 0x20
	
		// Constructors
		private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset); // 0x000000018D6B766C-0x000000018D6B7684
	
		// Methods
		internal static VFXEventAttribute CreateEventAttributeWrapper(); // 0x000000018D6B736C-0x000000018D6B73CC
		internal void SetWrapValue(IntPtr ptrToEventAttribute); // 0x000000018D6B7600-0x000000018D6B766C
		internal static IntPtr Internal_Create(); // 0x000000018D6B748C-0x000000018D6B74B8
		internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset); // 0x000000018D6B7530-0x000000018D6B75C0
		internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset); // 0x000000018D6B74EC-0x000000018D6B7530
		private void Release(); // 0x000000018D6B75C0-0x000000018D6B7600
		~VFXEventAttribute(); // 0x000000018D6B7418-0x000000018D6B748C
		public void Dispose(); // 0x000000018D6B73CC-0x000000018D6B7418
		[NativeMethod(IsThreadSafe = true)]
		internal static void Internal_Destroy(IntPtr ptr); // 0x000000018D6B74B8-0x000000018D6B74EC
	}

	[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
	[RequiredByNativeCode]
	public class VFXExpressionValues // TypeDefIndex: 91163
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		private VFXExpressionValues(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RequiredByNativeCode]
		internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr); // 0x000000018D6B7684-0x000000018D6B76CC
	}

	[RequiredByNativeCode]
	public struct VFXCameraXRSettings // TypeDefIndex: 91164
	{
		// Fields
		public uint viewTotal; // 0x00
		public uint viewCount; // 0x04
		public uint viewOffset; // 0x08
	}

	[NativeHeader("Modules/VFX/Public/VFXManager.h")]
	[RequiredByNativeCode]
	[StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
	public static class VFXManager // TypeDefIndex: 91165
	{
		// Fields
		private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; // 0x00
	
		// Constructors
		static VFXManager(); // 0x000000018D6B76CC-0x000000018D6B7720
	}

	[Serializable]
	[RequiredByNativeCode]
	public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 91166
	{
		// Constructors
		protected VFXSpawnerCallbacks(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
		public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
		public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
	}

	[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
	[RequiredByNativeCode]
	public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 91167
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
		private bool m_Owner; // 0x18
		private VFXEventAttribute m_WrapEventAttribute; // 0x20
	
		// Constructors
		internal VFXSpawnerState(IntPtr ptr, bool owner); // 0x0000000187258EE0-0x0000000187258EF0
	
		// Methods
		[RequiredByNativeCode]
		internal static VFXSpawnerState CreateSpawnerStateWrapper(); // 0x000000018D6B7720-0x000000018D6B777C
		private void PrepareWrapper(); // 0x000000018D6B7870-0x000000018D6B7944
		[RequiredByNativeCode]
		internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute); // 0x000000018D6B7984-0x000000018D6B7A5C
		private void Release(); // 0x000000018D6B7944-0x000000018D6B7984
		~VFXSpawnerState(); // 0x000000018D6B77C8-0x000000018D6B783C
		public void Dispose(); // 0x000000018D6B777C-0x000000018D6B77C8
		[NativeMethod(IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr); // 0x000000018D6B783C-0x000000018D6B7870
	}

	[NativeHeader("VFXScriptingClasses.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
	[UsedByNativeCode]
	public abstract class VisualEffectObject : UnityEngine.Object // TypeDefIndex: 91168
	{
		// Constructors
		protected VisualEffectObject(); // 0x000000018D6B7AE0-0x000000018D6B7B20
	}

	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	[NativeHeader("VFXScriptingClasses.h")]
	[UsedByNativeCode]
	public class VisualEffectAsset : VisualEffectObject // TypeDefIndex: 91169
	{
		// Fields
		public static readonly int PlayEventID; // 0x00
		public static readonly int StopEventID; // 0x04
	
		// Constructors
		public VisualEffectAsset(); // 0x000000018D6B7AD8-0x000000018D6B7AE0
		static VisualEffectAsset(); // 0x000000018D6B7A5C-0x000000018D6B7AD8
	}

	public struct VFXOutputEventArgs // TypeDefIndex: 91170
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _nameId_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly VFXEventAttribute _eventAttribute_k__BackingField; // 0x08
	
		// Constructors
		public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute); // 0x000000018783C19C-0x000000018783C1AC
	}

	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
	[RequireComponent(typeof(Transform))]
	public class VisualEffect : UnityEngine.Behaviour // TypeDefIndex: 91171
	{
		// Fields
		private VFXEventAttribute m_cachedEventAttribute; // 0x18
		public Action<VFXOutputEventArgs> outputEventReceived; // 0x20
	
		// Properties
		public VisualEffectAsset visualEffectAsset { get; } // 0x000000018D6B7C3C-0x000000018D6B7C70 
	
		// Methods
		public VFXEventAttribute CreateVFXEventAttribute(); // 0x000000018D6B7B20-0x000000018D6B7BA4
		[RequiredByNativeCode]
		private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source); // 0x000000018D6B7BA4-0x000000018D6B7BE4
		[RequiredByNativeCode]
		private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId); // 0x000000018D6B7BE4-0x000000018D6B7C3C
	}
}
