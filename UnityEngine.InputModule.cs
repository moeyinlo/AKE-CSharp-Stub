/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 134: UnityEngine.InputModule.dll - Assembly: UnityEngine.InputModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91272-91278

namespace UnityEngineInternal.Input
{
	internal unsafe delegate void NativeUpdateCallback(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer); // TypeDefIndex: 91273; 0x00000001859B7730-0x00000001859B7740

	internal enum NativeInputEventType // TypeDefIndex: 91274
	{
		DeviceConfigChanged = 1145259591,
		Delta = 1145852993,
		DeviceRemoved = 1146242381,
		State = 1398030676,
		Text = 1413830740
	}

	internal struct NativeInputEventBuffer // TypeDefIndex: 91275
	{
		// Fields
		public unsafe void* eventBuffer; // 0x00
		public int eventCount; // 0x08
		public int sizeInBytes; // 0x0C
		public int capacityInBytes; // 0x10
	}

	internal struct NativeInputEvent // TypeDefIndex: 91276
	{
		// Fields
		public const int structSize = 20; // Metadata: 0x0264BFF7
		public NativeInputEventType type; // 0x00
		public ushort sizeInBytes; // 0x04
		public ushort deviceId; // 0x06
		public double time; // 0x08
		public int eventId; // 0x10
	}

	[Flags]
	internal enum NativeInputUpdateType // TypeDefIndex: 91277
	{
		Dynamic = 1,
		Fixed = 2,
		BeforeRender = 4,
		Editor = 8,
		IgnoreFocus = 2147483647
	}

	[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
	[NativeHeader("Modules/Input/Private/InputInternal.h")]
	internal class NativeInputSystem // TypeDefIndex: 91278
	{
		// Fields
		public static NativeUpdateCallback onUpdate; // 0x00
		public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x08
		public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
		private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18
	
		// Properties
		public static Action<int, string> onDeviceDiscovered { get; set; } // 0x000000018D542C8C-0x000000018D542CDC 0x000000018668EB30-0x000000018668EBC0
		internal static bool hasDeviceDiscoveredCallback { set; } // 0x000000018668EBD0-0x000000018668EC10
		[NativeProperty(IsThreadSafe = true)]
		public static double currentTime { get; } // 0x00000001853AE540-0x00000001853AE580 
		[NativeProperty(IsThreadSafe = true)]
		public static double currentTimeOffsetToRealtimeSinceStartup { get; } // 0x00000001853AD930-0x00000001853AD970 
	
		// Constructors
		static NativeInputSystem(); // 0x000000018668EBC0-0x000000018668EBD0
	
		// Methods
		[RequiredByNativeCode]
		internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType); // 0x00000001860B8830-0x00000001860B8880
		[RequiredByNativeCode]
		internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer); // 0x00000001853AD690-0x00000001853AD6F0
		[RequiredByNativeCode]
		internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor); // 0x0000000186D09D30-0x0000000186D09DB0
		[RequiredByNativeCode]
		internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval); // 0x0000000185E85C20-0x0000000185E85CF0
		[FreeFunction("AllocateInputDeviceId")]
		public static int AllocateDeviceId(); // 0x000000018D542C2C-0x000000018D542C58
		[NativeMethod(IsThreadSafe = true)]
		public static void QueueInputEvent(IntPtr inputEvent); // 0x000000018D542C58-0x000000018D542C8C
		public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes); // 0x0000000186608330-0x00000001866083A0
		public static void SetPollingFrequency(float hertz); // 0x000000018668EAE0-0x000000018668EB30
		public static void Update(NativeInputUpdateType updateType); // 0x0000000186F90840-0x0000000186F90880
	}
}
