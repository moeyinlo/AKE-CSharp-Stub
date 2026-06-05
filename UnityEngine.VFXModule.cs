/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;

// Image 124: UnityEngine.VFXModule.dll - Assembly: UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61079-61089

namespace UnityEngine.VFX
{
	public sealed class VFXEventAttribute : IDisposable // TypeDefIndex: 61080
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
		private bool m_Owner; // 0x18
		private VisualEffectAsset m_VfxAsset; // 0x20
	
		// Constructors
		public VFXEventAttribute() {} // Dummy constructor
		private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) {} // 0x000000018C0A10AC-0x000000018C0A10C4
	
		// Methods
		internal static VFXEventAttribute CreateEventAttributeWrapper() => default; // 0x000000018C0A0DBC-0x000000018C0A0E18
		internal void SetWrapValue(IntPtr ptrToEventAttribute) {} // 0x000000018C0A1040-0x000000018C0A10AC
		internal static IntPtr Internal_Create() => default; // 0x000000018C0A0ED4-0x000000018C0A0F00
		internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) => default; // 0x000000018C0A0F78-0x000000018C0A1004
		internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) {} // 0x000000018C0A0F34-0x000000018C0A0F78
		private void Release() {} // 0x000000018C0A1004-0x000000018C0A1040
		~VFXEventAttribute() {} // 0x000000018C0A0E64-0x000000018C0A0ED4
		public void Dispose() {} // 0x000000018C0A0E18-0x000000018C0A0E64
		internal static void Internal_Destroy(IntPtr ptr) {} // 0x000000018C0A0F00-0x000000018C0A0F34
	}

	public class VFXExpressionValues // TypeDefIndex: 61081
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		private VFXExpressionValues() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) => default; // 0x000000018C0A10C4-0x000000018C0A110C
	}

	public struct VFXCameraXRSettings // TypeDefIndex: 61082
	{
		// Fields
		public uint viewTotal; // 0x00
		public uint viewCount; // 0x04
		public uint viewOffset; // 0x08
	}

	public static class VFXManager // TypeDefIndex: 61083
	{
		// Fields
		private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; // 0x00
	
		// Constructors
		static VFXManager() {} // 0x000000018C0A110C-0x000000018C0A1160
	}

	[Serializable]
	public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 61084
	{
		// Constructors
		protected VFXSpawnerCallbacks() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
		public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
		public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);
	}

	public sealed class VFXSpawnerState : IDisposable // TypeDefIndex: 61085
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
		private bool m_Owner; // 0x18
		private VFXEventAttribute m_WrapEventAttribute; // 0x20
	
		// Constructors
		public VFXSpawnerState() {} // Dummy constructor
		internal VFXSpawnerState(IntPtr ptr, bool owner) {} // 0x0000000185FEAD50-0x0000000185FEAD60
	
		// Methods
		internal static VFXSpawnerState CreateSpawnerStateWrapper() => default; // 0x000000018C0A1160-0x000000018C0A11B8
		private void PrepareWrapper() {} // 0x000000018C0A12A8-0x000000018C0A137C
		internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) {} // 0x000000018C0A13B8-0x000000018C0A1490
		private void Release() {} // 0x000000018C0A137C-0x000000018C0A13B8
		~VFXSpawnerState() {} // 0x000000018C0A1204-0x000000018C0A1274
		public void Dispose() {} // 0x000000018C0A11B8-0x000000018C0A1204
		private static void Internal_Destroy(IntPtr ptr) {} // 0x000000018C0A1274-0x000000018C0A12A8
	}

	public abstract class VisualEffectObject : UnityEngine.Object // TypeDefIndex: 61086
	{
		// Constructors
		protected VisualEffectObject() {} // 0x000000018C0A1514-0x000000018C0A1554
	}

	public class VisualEffectAsset : VisualEffectObject // TypeDefIndex: 61087
	{
		// Fields
		public static readonly int PlayEventID; // 0x00
		public static readonly int StopEventID; // 0x04
	
		// Constructors
		public VisualEffectAsset() {} // 0x000000018C0A150C-0x000000018C0A1514
		static VisualEffectAsset() {} // 0x000000018C0A1490-0x000000018C0A150C
	}

	public struct VFXOutputEventArgs // TypeDefIndex: 61088
	{
		// Fields
		private readonly int _nameId_k__BackingField; // 0x00
		private readonly VFXEventAttribute _eventAttribute_k__BackingField; // 0x08
	
		// Constructors
		public VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute) {
			<nameId>k__BackingField = default;
			<eventAttribute>k__BackingField = default;
		} // 0x0000000189317CA8-0x0000000189317CB8
	}

	public class VisualEffect : UnityEngine.Behaviour // TypeDefIndex: 61089
	{
		// Fields
		private VFXEventAttribute m_cachedEventAttribute; // 0x18
		public Action<VFXOutputEventArgs> outputEventReceived; // 0x20
	
		// Properties
		public VisualEffectAsset visualEffectAsset { get => default; } // 0x000000018C0A166C-0x000000018C0A16A0 
	
		// Constructors
		public VisualEffect() {} // Dummy constructor
	
		// Methods
		public VFXEventAttribute CreateVFXEventAttribute() => default; // 0x000000018C0A1554-0x000000018C0A15D8
		private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) => default; // 0x000000018C0A15D8-0x000000018C0A1618
		private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) {} // 0x000000018C0A1618-0x000000018C0A166C
	}
}
