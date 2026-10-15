/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 137: UnityEngine.VRModule.dll - Assembly: UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91296-91299

namespace UnityEngine.XR
{
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
	[NativeHeader("Modules/VR/VRModule.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
	public static class XRSettings // TypeDefIndex: 91298
	{
		// Properties
		public static bool enabled { [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)] get; } // 0x000000018D6BA04C-0x000000018D6BA078 
		[NativeName("Active")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static bool isDeviceActive { get; } // 0x000000018D6BA15C-0x000000018D6BA188 
		[NativeName("RenderScale")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static float eyeTextureResolutionScale { get; set; } // 0x000000018D6BA104-0x000000018D6BA130 0x000000018D6BA244-0x000000018D6BA280
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureWidth { get; } // 0x000000018D6BA130-0x000000018D6BA15C 
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureHeight { get; } // 0x000000018D6BA0D8-0x000000018D6BA104 
		[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
		[NativeName("IntermediateEyeTextureDesc")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static RenderTextureDescriptor eyeTextureDesc { get; } // 0x000000018D6BA0AC-0x000000018D6BA0D8 
		public static float renderViewportScale { get; } // 0x000000018D6BA1E0-0x000000018D6BA1EC 
		[NativeName("RenderViewportScale")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		internal static float renderViewportScaleInternal { get; } // 0x000000018D6BA1B4-0x000000018D6BA1E0 
		[NativeName("DeviceName")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static string loadedDeviceName { get; } // 0x000000018D6BA188-0x000000018D6BA1B4 
		public static string[] supportedDevices { get; } // 0x000000018D6BA218-0x000000018D6BA244 
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static StereoRenderingMode stereoRenderingMode { get; } // 0x000000018D6BA1EC-0x000000018D6BA218 
	
		// Nested types
		public enum StereoRenderingMode // TypeDefIndex: 91297
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiview = 3
		}
	
		// Methods
		private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret); // 0x000000018D6BA078-0x000000018D6BA0AC
	}

	[NativeConditional("ENABLE_VR")]
	public static class XRDevice // TypeDefIndex: 91299
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string> deviceLoaded; // 0x00
	
		// Methods
		[NativeName("DisableAutoVRCameraTracking")]
		[StaticAccessor("GetIVRDevice()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static void DisableAutoXRCameraTracking([NotNull("ArgumentNullException")] Camera camera, bool disabled); // 0x000000018D6B9FB8-0x000000018D6B9FFC
		[RequiredByNativeCode]
		private static void InvokeDeviceLoaded(string loadedDeviceName); // 0x000000018D6B9FFC-0x000000018D6BA04C
	}
}
