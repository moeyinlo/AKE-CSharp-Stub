/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 111: UnityEngine.XRModule.dll - Assembly: UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90822-90853

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90823
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 90824
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.XR
{
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType.Dot)]
	public static class InputTracking // TypeDefIndex: 90826
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> trackingAcquired; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> trackingLost; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> nodeAdded; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> nodeRemoved; // 0x18
	
		// Nested types
		private enum TrackingStateEventType // TypeDefIndex: 90825
		{
			NodeAdded = 0,
			NodeRemoved = 1,
			TrackingAcquired = 2,
			TrackingLost = 3
		}
	
		// Methods
		[RequiredByNativeCode]
		private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked); // 0x000000018D6BA7A0-0x000000018D6BA964
	}

	public enum XRNode // TypeDefIndex: 90827
	{
		LeftEye = 0,
		RightEye = 1,
		CenterEye = 2,
		Head = 3,
		LeftHand = 4,
		RightHand = 5,
		GameController = 6,
		TrackingReference = 7,
		HardwareTracker = 8
	}

	[Flags]
	internal enum AvailableTrackingData // TypeDefIndex: 90828
	{
		None = 0,
		PositionAvailable = 1,
		RotationAvailable = 2,
		VelocityAvailable = 4,
		AngularVelocityAvailable = 8,
		AccelerationAvailable = 16,
		AngularAccelerationAvailable = 32
	}

	[UsedByNativeCode]
	public struct XRNodeState // TypeDefIndex: 90829
	{
		// Fields
		private XRNode m_Type; // 0x00
		private AvailableTrackingData m_AvailableFields; // 0x04
		private Vector3 m_Position; // 0x08
		private Quaternion m_Rotation; // 0x14
		private Vector3 m_Velocity; // 0x24
		private Vector3 m_AngularVelocity; // 0x30
		private Vector3 m_Acceleration; // 0x3C
		private Vector3 m_AngularAcceleration; // 0x48
		private int m_Tracked; // 0x54
		private ulong m_UniqueID; // 0x58
	
		// Properties
		public ulong uniqueID { set; } // 0x00000001855D97D0-0x00000001855D97E0
		public XRNode nodeType { set; } // 0x0000000184547F40-0x0000000184547F50
		public bool tracked { set; } // 0x000000018D6BB0BC-0x000000018D6BB0C8
	}

	internal enum InputFeatureType : uint // TypeDefIndex: 90830
	{
		Custom = 0,
		Binary = 1,
		DiscreteStates = 2,
		Axis1D = 3,
		Axis2D = 4,
		Axis3D = 5,
		Rotation = 6,
		Hand = 7,
		Bone = 8,
		Eyes = 9,
		kUnityXRInputFeatureTypeInvalid = 4294967295
	}

	internal enum ConnectionChangeType : uint // TypeDefIndex: 90831
	{
		Connected = 0,
		Disconnected = 1,
		ConfigChange = 2
	}

	[Flags]
	public enum InputDeviceCharacteristics : uint // TypeDefIndex: 90832
	{
		None = 0,
		HeadMounted = 1,
		Camera = 2,
		HeldInHand = 4,
		HandTracking = 8,
		EyeTracking = 16,
		TrackedDevice = 32,
		Controller = 64,
		TrackingReference = 128,
		Left = 256,
		Right = 512,
		Simulated6DOF = 1024
	}

	[Flags]
	public enum InputTrackingState : uint // TypeDefIndex: 90833
	{
		None = 0,
		Position = 1,
		Rotation = 2,
		Velocity = 4,
		AngularVelocity = 8,
		Acceleration = 16,
		AngularAcceleration = 32,
		All = 63
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[RequiredByNativeCode]
	public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 90834
	{
		// Fields
		internal string m_Name; // 0x00
		[NativeName("m_FeatureType")]
		internal InputFeatureType m_InternalType; // 0x08
	
		// Properties
		public string name { get; } // 0x000000018514D010-0x000000018514D0E0 
		internal InputFeatureType internalType { get; } // 0x000000018453A050-0x000000018453A060 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6BA6B8-0x000000018D6BA730
		public bool Equals(InputFeatureUsage other); // 0x000000018D6BA730-0x000000018D6BA770
		public override int GetHashCode(); // 0x000000018D6BA770-0x000000018D6BA7A0
	}

	[NativeConditional("ENABLE_VR")]
	[UsedByNativeCode]
	public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 90835
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private bool m_Initialized; // 0x08
	
		// Properties
		private ulong deviceId { get; } // 0x000000018D6BA5E4-0x000000018D6BA5F8 
	
		// Constructors
		internal InputDevice(ulong deviceId); // 0x00000001872642B0-0x00000001872642C0
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6BA50C-0x000000018D6BA594
		public bool Equals(InputDevice other); // 0x000000018D6BA594-0x000000018D6BA5C8
		public override int GetHashCode(); // 0x000000018D6BA5C8-0x000000018D6BA5E4
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	public struct Hand : IEquatable<Hand> // TypeDefIndex: 90836
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get; } // 0x000000018514D010-0x000000018514D0E0 
		internal uint featureIndex { get; } // 0x000000018453A050-0x000000018453A060 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6BA3CC-0x000000018D6BA444
		public bool Equals(Hand other); // 0x000000018D6BA2C4-0x000000018D6BA2DC
		public override int GetHashCode(); // 0x0000000187264240-0x0000000187264260
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 90837
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get; } // 0x000000018514D010-0x000000018514D0E0 
		internal uint featureIndex { get; } // 0x000000018453A050-0x000000018453A060 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6BA354-0x000000018D6BA3CC
		public bool Equals(Eyes other); // 0x000000018D6BA2C4-0x000000018D6BA2DC
		public override int GetHashCode(); // 0x0000000187264240-0x0000000187264260
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	public struct Bone : IEquatable<Bone> // TypeDefIndex: 90838
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get; } // 0x000000018514D010-0x000000018514D0E0 
		internal uint featureIndex { get; } // 0x000000018453A050-0x000000018453A060 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6BA2DC-0x000000018D6BA354
		public bool Equals(Bone other); // 0x000000018D6BA2C4-0x000000018D6BA2DC
		public override int GetHashCode(); // 0x0000000187264240-0x0000000187264260
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[UsedByNativeCode]
	public class InputDevices // TypeDefIndex: 90839
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<InputDevice> deviceConnected; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<InputDevice> deviceDisconnected; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<InputDevice> deviceConfigChanged; // 0x10
	
		// Methods
		[RequiredByNativeCode]
		private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change); // 0x000000018D6BA5F8-0x000000018D6BA6B8
	}

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
	[UsedByNativeCode]
	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 90842
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<bool> displayFocusChanged; // 0x20
	
		// Nested types
		[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
		public struct XRRenderPass // TypeDefIndex: 90840
		{
			// Fields
			private IntPtr displaySubsystemInstance; // 0x00
			public int renderPassIndex; // 0x08
			public RenderTargetIdentifier renderTarget; // 0x10
			public RenderTextureDescriptor renderTargetDesc; // 0x38
			public bool hasMotionVectorPass; // 0x6C
			public RenderTargetIdentifier motionVectorRenderTarget; // 0x70
			public RenderTextureDescriptor motionVectorRenderTargetDesc; // 0x98
			public bool shouldFillOutDepth; // 0xCC
			public int cullingPassIndex; // 0xD0
		}
	
		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		public struct XRMirrorViewBlitDesc // TypeDefIndex: 90841
		{
			// Fields
			private IntPtr displaySubsystemInstance; // 0x00
			public bool nativeBlitAvailable; // 0x08
			public bool nativeBlitInvalidStates; // 0x09
			public int blitParamsCount; // 0x0C
		}
	
		// Constructors
		public XRDisplaySubsystem(); // 0x000000018D6BAEA4-0x000000018D6BAECC
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeDisplayFocusChanged(bool focus); // 0x000000018D6BAE88-0x000000018D6BAEA4
	}

	[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
	[UsedByNativeCode]
	public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 90843
	{
		// Constructors
		public XRDisplaySubsystemDescriptor(); // 0x000000018D6BAE60-0x000000018D6BAE88
	}

	[NativeConditional("ENABLE_XR")]
	[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
	[UsedByNativeCode]
	public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 90844
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<XRInputSubsystem> boundaryChanged; // 0x28
	
		// Constructors
		public XRInputSubsystem(); // 0x000000018D6BAFE4-0x000000018D6BB00C
	
		// Methods
		[RequiredByNativeCode(GenerateProxy = true)]
		private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr); // 0x000000018D6BAF6C-0x000000018D6BAFE4
		[RequiredByNativeCode(GenerateProxy = true)]
		private static void InvokeBoundaryChangedEvent(IntPtr internalPtr); // 0x000000018D6BAEF4-0x000000018D6BAF6C
	}

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
	[UsedByNativeCode]
	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 90845
	{
		// Constructors
		public XRInputSubsystemDescriptor(); // 0x000000018D6BAECC-0x000000018D6BAEF4
	}

	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[UsedByNativeCode]
	public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 90846
	{
		// Fields
		private static MeshId s_InvalidId; // 0x00
		private ulong m_SubId1; // 0x00
		private ulong m_SubId2; // 0x08
	
		// Constructors
		static MeshId(); // 0x000000018D6BADE4-0x000000018D6BAE20
	
		// Methods
		public override string ToString(); // 0x000000018D6BAD68-0x000000018D6BADE4
		public override int GetHashCode(); // 0x0000000187260400-0x0000000187260420
		public override bool Equals(object obj); // 0x000000018D6BACE4-0x000000018D6BAD68
		public bool Equals(MeshId other); // 0x0000000188AAD4AC-0x0000000188AAD4C4
	}

	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[RequiredByNativeCode]
	public enum MeshGenerationStatus // TypeDefIndex: 90847
	{
		Success = 0,
		InvalidMeshId = 1,
		GenerationAlreadyInProgress = 2,
		Canceled = 3,
		UnknownError = 4
	}

	internal static class HashCodeHelper // TypeDefIndex: 90848
	{
		// Methods
		public static int Combine(int hash1, int hash2); // 0x0000000187264260-0x0000000187264270
		public static int Combine(int hash1, int hash2, int hash3); // 0x0000000187264270-0x0000000187264290
		public static int Combine(int hash1, int hash2, int hash3, int hash4); // 0x0000000187264290-0x00000001872642B0
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5); // 0x000000018D6BA4A8-0x000000018D6BA4CC
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6); // 0x000000018D6BA47C-0x000000018D6BA4A8
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7); // 0x000000018D6BA444-0x000000018D6BA47C
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8); // 0x000000018D6BA4CC-0x000000018D6BA50C
	}

	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[RequiredByNativeCode]
	public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 90849
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MeshId _MeshId_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Mesh _Mesh_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MeshCollider _MeshCollider_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MeshGenerationStatus _Status_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MeshVertexAttributes _Attributes_k__BackingField; // 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ulong _Timestamp_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector3 _Position_k__BackingField; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Quaternion _Rotation_k__BackingField; // 0x3C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector3 _Scale_k__BackingField; // 0x4C
	
		// Properties
		public MeshId MeshId { [IsReadOnly] [CompilerGenerated] get; } // 0x000000018723AC80-0x000000018723AC90 
		public Mesh Mesh { [IsReadOnly] [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public MeshCollider MeshCollider { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public MeshGenerationStatus Status { [CompilerGenerated] [IsReadOnly] get; } // 0x000000018226A850-0x000000018226A860 
		public MeshVertexAttributes Attributes { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public Vector3 Position { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187235E20-0x0000000187235E40 
		public Quaternion Rotation { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187240F20-0x0000000187240F30 
		public Vector3 Scale { [CompilerGenerated] [IsReadOnly] get; } // 0x000000018723F410-0x000000018723F430 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6BA964-0x000000018D6BAA14
		public bool Equals(MeshGenerationResult other); // 0x000000018D6BAA14-0x000000018D6BAB7C
		public override int GetHashCode(); // 0x000000018D6BAB7C-0x000000018D6BACE4
	}

	[Flags]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[UsedByNativeCode]
	public enum MeshVertexAttributes // TypeDefIndex: 90850
	{
		None = 0,
		Normals = 1,
		Tangents = 2,
		UVs = 4,
		Colors = 8
	}

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[UsedByNativeCode]
	public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 90852
	{
		// Nested types
		[IsReadOnly]
		[NativeConditional("ENABLE_XR")]
		private struct MeshTransformList : IDisposable // TypeDefIndex: 90851
		{
			// Fields
			private readonly IntPtr m_Self; // 0x00
	
			// Methods
			public void Dispose(); // 0x000000018D6BAE20-0x000000018D6BAE2C
			[FreeFunction("UnityXRMeshTransformList_Dispose")]
			private static void Dispose(IntPtr self); // 0x000000018D6BAE2C-0x000000018D6BAE60
		}
	
		// Constructors
		public XRMeshSubsystem(); // 0x000000018D6BB094-0x000000018D6BB0BC
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete); // 0x000000018D6BB034-0x000000018D6BB094
	}

	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
	[UsedByNativeCode]
	public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 90853
	{
		// Constructors
		public XRMeshSubsystemDescriptor(); // 0x000000018D6BB00C-0x000000018D6BB034
	}
}
