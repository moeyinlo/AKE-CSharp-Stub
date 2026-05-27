/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 105: UnityEngine.XRModule.dll - Assembly: UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59644-59675

namespace UnityEngine.XR
{
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType.Dot)]
	public static class InputTracking // TypeDefIndex: 59648
	{
		// Nested types
		private enum TrackingStateEventType // TypeDefIndex: 59647
		{
			NodeAdded = 0,
			NodeRemoved = 1,
			TrackingAcquired = 2,
			TrackingLost = 3
		}
	
		// Methods
		[RequiredByNativeCode]
		private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) {} // 0x0000000189F8C4EC-0x0000000189F8C6AC
	}

	public enum XRNode // TypeDefIndex: 59649
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
	internal enum AvailableTrackingData // TypeDefIndex: 59650
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
	public struct XRNodeState // TypeDefIndex: 59651
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
		public ulong uniqueID { set {} } // 0x0000000183D4F270-0x0000000183D4F280
		public XRNode nodeType { set {} } // 0x0000000183D4E970-0x0000000183D4E980
		public bool tracked { set {} } // 0x0000000189F8CE00-0x0000000189F8CE0C
	}

	internal enum InputFeatureType : uint // TypeDefIndex: 59652
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

	internal enum ConnectionChangeType : uint // TypeDefIndex: 59653
	{
		Connected = 0,
		Disconnected = 1,
		ConfigChange = 2
	}

	[Flags]
	public enum InputDeviceCharacteristics : uint // TypeDefIndex: 59654
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
	public enum InputTrackingState : uint // TypeDefIndex: 59655
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
	public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 59656
	{
		// Fields
		internal string m_Name; // 0x00
		[NativeName("m_FeatureType")]
		internal InputFeatureType m_InternalType; // 0x08
	
		// Properties
		public string name { get => default; } // 0x000000018253BE20-0x000000018253BE30 
		internal InputFeatureType internalType { get => default; } // 0x0000000183D68070-0x0000000183D68080 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F8C404-0x0000000189F8C47C
		public bool Equals(InputFeatureUsage other) => default; // 0x0000000189F8C47C-0x0000000189F8C4BC
		public override int GetHashCode() => default; // 0x0000000189F8C4BC-0x0000000189F8C4EC
	}

	[NativeConditional("ENABLE_VR")]
	[UsedByNativeCode]
	public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 59657
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private bool m_Initialized; // 0x08
	
		// Properties
		private ulong deviceId { get => default; } // 0x0000000189F8C330-0x0000000189F8C344 
	
		// Constructors
		internal InputDevice(ulong deviceId) : this() {
			m_DeviceId = default;
			m_Initialized = default;
		} // 0x0000000183D89F90-0x0000000183D89FA0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F8C258-0x0000000189F8C2E0
		public bool Equals(InputDevice other) => default; // 0x0000000189F8C2E0-0x0000000189F8C314
		public override int GetHashCode() => default; // 0x0000000189F8C314-0x0000000189F8C330
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("XRScriptingClasses.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	public struct Hand : IEquatable<Hand> // TypeDefIndex: 59658
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get => default; } // 0x000000018253BE20-0x000000018253BE30 
		internal uint featureIndex { get => default; } // 0x0000000183D68070-0x0000000183D68080 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F8C118-0x0000000189F8C190
		public bool Equals(Hand other) => default; // 0x0000000189F8C010-0x0000000189F8C028
		public override int GetHashCode() => default; // 0x0000000183D89F20-0x0000000183D89F40
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 59659
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get => default; } // 0x000000018253BE20-0x000000018253BE30 
		internal uint featureIndex { get => default; } // 0x0000000183D68070-0x0000000183D68080 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F8C0A0-0x0000000189F8C118
		public bool Equals(Eyes other) => default; // 0x0000000189F8C010-0x0000000189F8C028
		public override int GetHashCode() => default; // 0x0000000183D89F20-0x0000000183D89F40
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	public struct Bone : IEquatable<Bone> // TypeDefIndex: 59660
	{
		// Fields
		private ulong m_DeviceId; // 0x00
		private uint m_FeatureIndex; // 0x08
	
		// Properties
		internal ulong deviceId { get => default; } // 0x000000018253BE20-0x000000018253BE30 
		internal uint featureIndex { get => default; } // 0x0000000183D68070-0x0000000183D68080 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F8C028-0x0000000189F8C0A0
		public bool Equals(Bone other) => default; // 0x0000000189F8C010-0x0000000189F8C028
		public override int GetHashCode() => default; // 0x0000000183D89F20-0x0000000183D89F40
	}

	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[UsedByNativeCode]
	public class InputDevices // TypeDefIndex: 59661
	{
		// Constructors
		public InputDevices() {} // Dummy constructor
	
		// Methods
		[RequiredByNativeCode]
		private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) {} // 0x0000000189F8C344-0x0000000189F8C404
	}

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
	[UsedByNativeCode]
	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 59664
	{
		// Nested types
		[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
		[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		public struct XRRenderPass // TypeDefIndex: 59662
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
		public struct XRMirrorViewBlitDesc // TypeDefIndex: 59663
		{
			// Fields
			private IntPtr displaySubsystemInstance; // 0x00
			public bool nativeBlitAvailable; // 0x08
			public bool nativeBlitInvalidStates; // 0x09
			public int blitParamsCount; // 0x0C
		}
	
		// Constructors
		public XRDisplaySubsystem() {} // 0x0000000189F8CBE8-0x0000000189F8CC10
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeDisplayFocusChanged(bool focus) {} // 0x0000000189F8CBCC-0x0000000189F8CBE8
	}

	[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
	[UsedByNativeCode]
	public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 59665
	{
		// Constructors
		public XRDisplaySubsystemDescriptor() {} // 0x0000000189F8CBA4-0x0000000189F8CBCC
	}

	[NativeConditional("ENABLE_XR")]
	[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
	[UsedByNativeCode]
	public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 59666
	{
		// Constructors
		public XRInputSubsystem() {} // 0x0000000189F8CD28-0x0000000189F8CD50
	
		// Methods
		[RequiredByNativeCode(GenerateProxy = true)]
		private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) {} // 0x0000000189F8CCB0-0x0000000189F8CD28
		[RequiredByNativeCode(GenerateProxy = true)]
		private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) {} // 0x0000000189F8CC38-0x0000000189F8CCB0
	}

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
	[UsedByNativeCode]
	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 59667
	{
		// Constructors
		public XRInputSubsystemDescriptor() {} // 0x0000000189F8CC10-0x0000000189F8CC38
	}

	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[UsedByNativeCode]
	public struct MeshId : IEquatable<MeshId> // TypeDefIndex: 59668
	{
		// Fields
		private static MeshId s_InvalidId; // 0x00
		private ulong m_SubId1; // 0x00
		private ulong m_SubId2; // 0x08
	
		// Constructors
		static MeshId() {
			s_InvalidId = default;
		} // 0x0000000189F8CB28-0x0000000189F8CB64
	
		// Methods
		public override string ToString() => default; // 0x0000000189F8CAAC-0x0000000189F8CB28
		public override int GetHashCode() => default; // 0x0000000183D85F30-0x0000000183D85F50
		public override bool Equals(object obj) => default; // 0x0000000189F8CA28-0x0000000189F8CAAC
		public bool Equals(MeshId other) => default; // 0x000000018558249C-0x00000001855824B4
	}

	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[RequiredByNativeCode]
	public enum MeshGenerationStatus // TypeDefIndex: 59669
	{
		Success = 0,
		InvalidMeshId = 1,
		GenerationAlreadyInProgress = 2,
		Canceled = 3,
		UnknownError = 4
	}

	internal static class HashCodeHelper // TypeDefIndex: 59670
	{
		// Methods
		public static int Combine(int hash1, int hash2) => default; // 0x0000000183D89F40-0x0000000183D89F50
		public static int Combine(int hash1, int hash2, int hash3) => default; // 0x0000000183D89F50-0x0000000183D89F70
		public static int Combine(int hash1, int hash2, int hash3, int hash4) => default; // 0x0000000183D89F70-0x0000000183D89F90
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5) => default; // 0x0000000189F8C1F4-0x0000000189F8C218
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6) => default; // 0x0000000189F8C1C8-0x0000000189F8C1F4
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7) => default; // 0x0000000189F8C190-0x0000000189F8C1C8
		public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8) => default; // 0x0000000189F8C218-0x0000000189F8C258
	}

	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[RequiredByNativeCode]
	public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 59671
	{
		// Properties
		public MeshId MeshId { [IsReadOnly] get; } // 0x0000000183D5B250-0x0000000183D5B260 
		public Mesh Mesh { [IsReadOnly] get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public MeshCollider MeshCollider { [IsReadOnly] get; } // 0x0000000181041090-0x00000001810410A0 
		public MeshGenerationStatus Status { [IsReadOnly] get; } // 0x0000000181003B50-0x0000000181003B60 
		public MeshVertexAttributes Attributes { [IsReadOnly] get; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public Vector3 Position { [IsReadOnly] get; } // 0x0000000183D51B80-0x0000000183D51BA0 
		public Quaternion Rotation { [IsReadOnly] get; } // 0x0000000183D5E660-0x0000000183D5E670 
		public Vector3 Scale { [IsReadOnly] get; } // 0x0000000183D58880-0x0000000183D588A0 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F8C6AC-0x0000000189F8C75C
		public bool Equals(MeshGenerationResult other) => default; // 0x0000000189F8C75C-0x0000000189F8C8C4
		public override int GetHashCode() => default; // 0x0000000189F8C8C4-0x0000000189F8CA28
	}

	[Flags]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[UsedByNativeCode]
	public enum MeshVertexAttributes // TypeDefIndex: 59672
	{
		None = 0,
		Normals = 1,
		Tangents = 2,
		UVs = 4,
		Colors = 8
	}

	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
	[UsedByNativeCode]
	public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 59674
	{
		// Nested types
		[IsReadOnly]
		[NativeConditional("ENABLE_XR")]
		private struct MeshTransformList : IDisposable // TypeDefIndex: 59673
		{
			// Fields
			private readonly IntPtr m_Self; // 0x00
	
			// Methods
			public void Dispose() {} // 0x0000000189F8CD78-0x0000000189F8CDD8
			[FreeFunction("UnityXRMeshTransformList_Dispose")]
			private static void Dispose(IntPtr self) {} // 0x0000000189F8CDD8-0x0000000189F8CE00
		}
	
		// Constructors
		public XRMeshSubsystem() {} // 0x0000000189F8CB70-0x0000000189F8CBA4
	
		// Methods
		[RequiredByNativeCode]
		private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) {} // 0x0000000189F8CB64-0x0000000189F8CB70
	}

	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
	[UsedByNativeCode]
	public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 59675
	{
		// Constructors
		public XRMeshSubsystemDescriptor() {} // 0x0000000189F8CD50-0x0000000189F8CD78
	}
}
