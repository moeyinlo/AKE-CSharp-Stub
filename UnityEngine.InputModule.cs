/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 129: UnityEngine.InputModule.dll - Assembly: UnityEngine.InputModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60054-60060

namespace UnityEngineInternal.Input
{
	internal unsafe delegate void NativeUpdateCallback(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer); // TypeDefIndex: 60055; 0x0000000182065C10-0x0000000182065C20

	internal enum NativeInputEventType // TypeDefIndex: 60056
	{
		DeviceConfigChanged = 1145259591,
		Delta = 1145852993,
		DeviceRemoved = 1146242381,
		State = 1398030676,
		Text = 1413830740
	}

	internal struct NativeInputEventBuffer // TypeDefIndex: 60057
	{
		// Fields
		public unsafe void* eventBuffer; // 0x00
		public int eventCount; // 0x08
		public int sizeInBytes; // 0x0C
		public int capacityInBytes; // 0x10
	}

	internal struct NativeInputEvent // TypeDefIndex: 60058
	{
		// Fields
		public const int structSize = 20; // Metadata: 0x01FDE0EE
		public NativeInputEventType type; // 0x00
		public ushort sizeInBytes; // 0x04
		public ushort deviceId; // 0x06
		public double time; // 0x08
		public int eventId; // 0x10
	}

	[Flags]
	internal enum NativeInputUpdateType // TypeDefIndex: 60059
	{
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		IgnoreFocus = 2147483647
	}

	[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
	[NativeHeader("Modules/Input/Private/InputInternal.h")]
	internal class NativeInputSystem // TypeDefIndex: 60060
	{
		// Fields
		public static NativeUpdateCallback onUpdate; // 0x00
		public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x08
		public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
		private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18
	
		// Properties
		public static Action<int, string> onDeviceDiscovered { get => default; set {} } // 0x0000000189E14C70-0x0000000189E14CC0 0x0000000182EB73C0-0x0000000182EB7450
		internal static bool hasDeviceDiscoveredCallback { set {} } // 0x0000000182EB7460-0x0000000182EB74A0
		[NativeProperty(IsThreadSafe = true)]
		public static double currentTime { get => default; } // 0x00000001822B9970-0x00000001822B99B0 
		[NativeProperty(IsThreadSafe = true)]
		public static double currentTimeOffsetToRealtimeSinceStartup { get => default; } // 0x00000001824B14B0-0x00000001824B14F0 
	
		// Constructors
		public NativeInputSystem() {} // Dummy constructor
		static NativeInputSystem() {} // 0x0000000182EB7450-0x0000000182EB7460
	
		// Methods
		[RequiredByNativeCode]
		internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) {} // 0x00000001830944B0-0x0000000183094520
		[RequiredByNativeCode]
		internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) {} // 0x00000001824B1160-0x00000001824B11E0
		[RequiredByNativeCode]
		internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) {} // 0x00000001837D2840-0x00000001837D28C0
		[RequiredByNativeCode]
		internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) {
			retval = default;
		} // 0x0000000182EC49A0-0x0000000182EC4A90
		[FreeFunction("AllocateInputDeviceId")]
		public static int AllocateDeviceId() => default; // 0x0000000189E14C10-0x0000000189E14C3C
		[NativeMethod(IsThreadSafe = true)]
		public static void QueueInputEvent(IntPtr inputEvent) {} // 0x0000000189E14C3C-0x0000000189E14C70
		public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) => default; // 0x00000001833FA810-0x00000001833FA880
		public static void SetPollingFrequency(float hertz) {} // 0x0000000182EB7370-0x0000000182EB73C0
		public static void Update(NativeInputUpdateType updateType) {} // 0x0000000183A4FE40-0x0000000183A4FE80
	}
}
