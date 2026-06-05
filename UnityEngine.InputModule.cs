/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 133: UnityEngine.InputModule.dll - Assembly: UnityEngine.InputModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61170-61176

namespace UnityEngineInternal.Input
{
	internal unsafe delegate void NativeUpdateCallback(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer); // TypeDefIndex: 61171; 0x00000001831C5680-0x00000001831C5690

	internal enum NativeInputEventType // TypeDefIndex: 61172
	{
		DeviceConfigChanged = 1145259591,
		Delta = 1145852993,
		DeviceRemoved = 1146242381,
		State = 1398030676,
		Text = 1413830740
	}

	internal struct NativeInputEventBuffer // TypeDefIndex: 61173
	{
		// Fields
		public unsafe void* eventBuffer; // 0x00
		public int eventCount; // 0x08
		public int sizeInBytes; // 0x0C
		public int capacityInBytes; // 0x10
	}

	internal struct NativeInputEvent // TypeDefIndex: 61174
	{
		// Fields
		public const int structSize = 20; // Metadata: 0x020839F3
		public NativeInputEventType type; // 0x00
		public ushort sizeInBytes; // 0x04
		public ushort deviceId; // 0x06
		public double time; // 0x08
		public int eventId; // 0x10
	}

	internal enum NativeInputUpdateType // TypeDefIndex: 61175
	{
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		IgnoreFocus = 2147483647
	}

	internal class NativeInputSystem // TypeDefIndex: 61176
	{
		// Fields
		public static NativeUpdateCallback onUpdate; // 0x00
		public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x08
		public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
		private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18
	
		// Properties
		public static Action<int, string> onDeviceDiscovered { get => default; set {} } // 0x000000018BF2C9AC-0x000000018BF2C9FC 0x0000000184D54820-0x0000000184D548B0
		internal static bool hasDeviceDiscoveredCallback { set {} } // 0x0000000184D548C0-0x0000000184D54900
		public static double currentTime { get => default; } // 0x0000000184580870-0x00000001845808B0 
		public static double currentTimeOffsetToRealtimeSinceStartup { get => default; } // 0x000000018457FB80-0x000000018457FBC0 
	
		// Constructors
		public NativeInputSystem() {} // Dummy constructor
		static NativeInputSystem() {} // 0x0000000184D548B0-0x0000000184D548C0
	
		// Methods
		internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) {} // 0x0000000184F3CE20-0x0000000184F3CE90
		internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) {} // 0x000000018457CB90-0x000000018457CC10
		internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) {} // 0x00000001859158E0-0x0000000185915960
		internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) {
			retval = default;
		} // 0x0000000184CACBF0-0x0000000184CACCE0
		public static int AllocateDeviceId() => default; // 0x000000018BF2C94C-0x000000018BF2C978
		public static void QueueInputEvent(IntPtr inputEvent) {} // 0x000000018BF2C978-0x000000018BF2C9AC
		public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) => default; // 0x00000001853CFC70-0x00000001853CFCE0
		public static void SetPollingFrequency(float hertz) {} // 0x0000000184D54760-0x0000000184D547B0
		public static void Update(NativeInputUpdateType updateType) {} // 0x0000000185C57980-0x0000000185C579C0
	}
}
