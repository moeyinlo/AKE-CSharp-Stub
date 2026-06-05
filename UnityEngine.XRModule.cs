/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;
using UnityEngine.Rendering;

// Image 108: UnityEngine.XRModule.dll - Assembly: UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60748-60779

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60749
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60750
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.XR
{
	public static class InputTracking // TypeDefIndex: 60752
	{
		// Fields
		private static Action<XRNodeState> trackingAcquired; // 0x00
		private static Action<XRNodeState> trackingLost; // 0x08
		private static Action<XRNodeState> nodeAdded; // 0x10
		private static Action<XRNodeState> nodeRemoved; // 0x18
	
		// Nested types
		private enum TrackingStateEventType // TypeDefIndex: 60751
		{
			NodeAdded = 0,
			NodeRemoved = 1,
			TrackingAcquired = 2,
			TrackingLost = 3
		}
	
		// Methods
		private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) {} // 0x000000018C0A41D8-0x000000018C0A4398
	}

	public enum XRNode // TypeDefIndex: 60753
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

	internal enum AvailableTrackingData // TypeDefIndex: 60754
	{
		None = 0,
		PositionAvailable = 1,
		RotationAvailable = 2,
		VelocityAvailable = 4,
		AngularVelocityAvailable = 8,
		AccelerationAvailable = 16,
		AngularAccelerationAvailable = 32
	}

	public struct XRNodeState // TypeDefIndex: 60755
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
		public ulong uniqueID { set {} } // 0x0000000185FB0960-0x0000000185FB0970
		public XRNode nodeType { set {} } // 0x00000001818AA390-0x00000001818AA3A0
		public bool tracked { set {} } // 0x000000018C0A4AEC-0x000000018C0A4AF8
	}

	internal enum InputFeatureType : uint // TypeDefIndex: 60756
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

	internal enum ConnectionChangeType : uint // TypeDefIndex: 60757
	{
		Connected = 0,
		Disconnected = 1,
		ConfigChange = 2
	}

	public enum InputDeviceCharacteristics : uint // TypeDefIndex: 60758
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

	public enum InputTrackingState : uint // TypeDefIndex: 60759
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

	public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 60760
	{
		// Fields
		internal string m_Name; // 0x00
		internal InputFeatureType m_InternalType; // 0x08
	
		// Properties
		public string name { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		internal InputFeatureType internalType { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C0A40F0-0x000000018C0A4168
		public bool Equals(InputFeatureUsage other) => default; // 0x000000018C0A4168-0x000000018C0A41A8
		public override int GetHashCode() => default; // 0x000000018C0A41A8-0x000000018C0A41D8
	}

	public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 60761
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private bool m_Initialized; // 0x08
	
		// Properties
		private ulong deviceId { get => default; } // 0x000000018C0A401C-0x000000018C0A4030 
	
		// Constructors
		internal InputDevice(ulong deviceId) : this() {
			m_DeviceId = default;
			m_Initialized = default;
		} // 0x0000000185FEADD0-0x0000000185FEADE0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C0A3F44-0x000000018C0A3FCC
		public bool Equals(InputDevice other) => default; // 0x000000018C0A3FCC-0x000000018C0A4000
		public override int GetHashCode() => default; // 0x000000018C0A4000-0x000000018C0A401C
	}

	public struct Hand : IEquatable<Hand> // TypeDefIndex: 60762
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		internal uint featureIndex { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C0A3E04-0x000000018C0A3E7C
		public bool Equals(Hand other) => default; // 0x000000018C0A3CFC-0x000000018C0A3D14
		public override int GetHashCode() => default; // 0x0000000185FEAD60-0x0000000185FEAD80
	}

	public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 60763
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		internal uint featureIndex { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C0A3D8C-0x000000018C0A3E04
		public bool Equals(Eyes other) => default; // 0x000000018C0A3CFC-0x000000018C0A3D14
		public override int GetHashCode() => default; // 0x0000000185FEAD60-0x0000000185FEAD80
	}

	public struct Bone : IEquatable<Bone> // TypeDefIndex: 60764
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		internal uint featureIndex { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C0A3D14-0x000000018C0A3D8C
		public bool Equals(Bone other) => default; // 0x000000018C0A3CFC-0x000000018C0A3D14
		public override int GetHashCode() => default; // 0x0000000185FEAD60-0x0000000185FEAD80
	}

	public class InputDevices // TypeDefIndex: 60765
	{
		// Fields
		private static Action<InputDevice> deviceConnected; // 0x00
		private static Action<InputDevice> deviceDisconnected; // 0x08
		private static Action<InputDevice> deviceConfigChanged; // 0x10
	
		// Constructors
		public InputDevices() {} // Dummy constructor
	
		// Methods
		private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) {} // 0x000000018C0A4030-0x000000018C0A40F0
	}

	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 60768
	{
		// Fields
		private Action<bool> displayFocusChanged; // 0x20
	
		// Nested types
		public struct XRRenderPass // TypeDefIndex: 60766
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
	
		public struct XRMirrorViewBlitDesc // TypeDefIndex: 60767
		{
			// Fields
			private IntPtr displaySubsystemInstance; // 0x00
			public bool nativeBlitAvailable; // 0x08
			public bool nativeBlitInvalidStates; // 0x09
			public int blitParamsCount; // 0x0C
		}
	
		// Constructors
		public XRDisplaySubsystem() {} // 0x000000018C0A48D4-0x000000018C0A48FC
	
		// Methods
		private void InvokeDisplayFocusChanged(bool focus) {} // 0x000000018C0A48B8-0x000000018C0A48D4
	}

	public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 60769
	{
		// Constructors
		public XRDisplaySubsystemDescriptor() {} // 0x000000018C0A4890-0x000000018C0A48B8
	}

	public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 60770
	{
		// Fields
		private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
		private Action<XRInputSubsystem> boundaryChanged; // 0x28
	
		// Constructors
		public XRInputSubsystem() {} // 0x000000018C0A4A14-0x000000018C0A4A3C
	
		// Methods
		private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) {} // 0x000000018C0A499C-0x000000018C0A4A14
		private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) {} // 0x000000018C0A4924-0x000000018C0A499C
	}

	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 60771
	{
		// Constructors
		public XRInputSubsystemDescriptor() {} // 0x000000018C0A48FC-0x000000018C0A4924
	}

	public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 60772
	{
		// Fields
		private static MeshId s_InvalidId; // 0x00
		private ulong m_SubId1; // 0x00
		private ulong m_SubId2; // 0x08
	
		// Constructors
		static MeshId() {
			s_InvalidId = default;
		} // 0x000000018C0A4814-0x000000018C0A4850
	
		// Methods
		public override string ToString() => default; // 0x000000018C0A4798-0x000000018C0A4814
		public override int GetHashCode() => default; // 0x0000000185FE6BC0-0x0000000185FE6BE0
		public override bool Equals(object obj) => default; // 0x000000018C0A4714-0x000000018C0A4798
		public bool Equals(MeshId other) => default; // 0x0000000187783A50-0x0000000187783A68
	}

	public enum MeshGenerationStatus // TypeDefIndex: 60773
	{
		Success = 0,
		InvalidMeshId = 1,
		GenerationAlreadyInProgress = 2,
		Canceled = 3,
		UnknownError = 4
	}

	internal static class HashCodeHelper // TypeDefIndex: 60774
	{
		// Methods
		public static int Combine(int hash1, int hash2) => default; // 0x0000000185FEAD80-0x0000000185FEAD90
		public static int Combine(int hash1, int hash2, int hash3) => default; // 0x0000000185FEAD90-0x0000000185FEADB0
		public static int Combine(int hash1, int hash2, int hash3, int hash4) => default; // 0x0000000185FEADB0-0x0000000185FEADD0
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5) => default; // 0x000000018C0A3EE0-0x000000018C0A3F04
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6) => default; // 0x000000018C0A3EB4-0x000000018C0A3EE0
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7) => default; // 0x000000018C0A3E7C-0x000000018C0A3EB4
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8) => default; // 0x000000018C0A3F04-0x000000018C0A3F44
	}

	public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 60775
	{
		// Fields
		private readonly MeshId _MeshId_k__BackingField; // 0x00
		private readonly Mesh _Mesh_k__BackingField; // 0x10
		private readonly MeshCollider _MeshCollider_k__BackingField; // 0x18
		private readonly MeshGenerationStatus _Status_k__BackingField; // 0x20
		private readonly MeshVertexAttributes _Attributes_k__BackingField; // 0x24
		private readonly ulong _Timestamp_k__BackingField; // 0x28
		private readonly Vector3 _Position_k__BackingField; // 0x30
		private readonly Quaternion _Rotation_k__BackingField; // 0x3C
		private readonly Vector3 _Scale_k__BackingField; // 0x4C
	
		// Properties
		public MeshId MeshId { get; } // 0x0000000181D61820-0x0000000181D61830 
		public Mesh Mesh { get; } // 0x000000018346D130-0x000000018346D140 
		public MeshCollider MeshCollider { get; } // 0x0000000181377E40-0x0000000181377E50 
		public MeshGenerationStatus Status { get; } // 0x00000001813B88B0-0x00000001813B88C0 
		public MeshVertexAttributes Attributes { get; } // 0x0000000181424480-0x0000000181424490 
		public Vector3 Position { get; } // 0x0000000185FB2EF0-0x0000000185FB2F10 
		public Quaternion Rotation { get; } // 0x0000000185FBFAA0-0x0000000185FBFAB0 
		public Vector3 Scale { get; } // 0x0000000181DE28A0-0x0000000181DE28C0 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C0A4398-0x000000018C0A4448
		public bool Equals(MeshGenerationResult other) => default; // 0x000000018C0A4448-0x000000018C0A45B0
		public override int GetHashCode() => default; // 0x000000018C0A45B0-0x000000018C0A4714
	}

	public enum MeshVertexAttributes // TypeDefIndex: 60776
	{
		None = 0,
		Normals = 1,
		Tangents = 2,
		UVs = 4,
		Colors = 8
	}

	public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 60778
	{
		// Nested types
		private struct MeshTransformList : IDisposable // TypeDefIndex: 60777
		{
			// Fields
			private readonly IntPtr m_Self; // 0x00
	
			// Methods
			public void Dispose() {} // 0x000000018C0A4A64-0x000000018C0A4AC4
			private static void Dispose(IntPtr self) {} // 0x000000018C0A4AC4-0x000000018C0A4AEC
		}
	
		// Constructors
		public XRMeshSubsystem() {} // 0x000000018C0A485C-0x000000018C0A4890
	
		// Methods
		private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) {} // 0x000000018C0A4850-0x000000018C0A485C
	}

	public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 60779
	{
		// Constructors
		public XRMeshSubsystemDescriptor() {} // 0x000000018C0A4A3C-0x000000018C0A4A64
	}
}
