/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 132: UnityEngine.VRModule.dll - Assembly: UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60078-60081

namespace UnityEngine.XR
{
	[NativeConditional("ENABLE_VR")]
	[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
	[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Modules/VR/VRModule.h")]
	public static class XRSettings // TypeDefIndex: 60080
	{
		// Properties
		public static bool enabled { [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)] get; } // 0x0000000189F8BD98-0x0000000189F8BDC4 
		[NativeName("Active")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static bool isDeviceActive { get; } // 0x0000000189F8BEA8-0x0000000189F8BED4 
		[NativeName("RenderScale")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static float eyeTextureResolutionScale { get; set; } // 0x0000000189F8BE50-0x0000000189F8BE7C 0x0000000189F8BF90-0x0000000189F8BFCC
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureWidth { get; } // 0x0000000189F8BE7C-0x0000000189F8BEA8 
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureHeight { get; } // 0x0000000189F8BE24-0x0000000189F8BE50 
		[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
		[NativeName("IntermediateEyeTextureDesc")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static RenderTextureDescriptor eyeTextureDesc { get; } // 0x0000000189F8BDF8-0x0000000189F8BE24 
		public static float renderViewportScale { get; } // 0x0000000189F8BF2C-0x0000000189F8BF38 
		[NativeName("RenderViewportScale")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		internal static float renderViewportScaleInternal { get; } // 0x0000000189F8BF00-0x0000000189F8BF2C 
		[NativeName("DeviceName")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static string loadedDeviceName { get; } // 0x0000000189F8BED4-0x0000000189F8BF00 
		public static string[] supportedDevices { get; } // 0x0000000189F8BF64-0x0000000189F8BF90 
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static StereoRenderingMode stereoRenderingMode { get; } // 0x0000000189F8BF38-0x0000000189F8BF64 
	
		// Nested types
		public enum StereoRenderingMode // TypeDefIndex: 60079
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiview = 3
		}
	
		// Methods
		private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) {
			ret = default;
		} // 0x0000000189F8BDC4-0x0000000189F8BDF8
	}

	[NativeConditional("ENABLE_VR")]
	public static class XRDevice // TypeDefIndex: 60081
	{
		// Methods
		[NativeName("DisableAutoVRCameraTracking")]
		[StaticAccessor("GetIVRDevice()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static void DisableAutoXRCameraTracking([NotNull("ArgumentNullException")] Camera camera, bool disabled) {} // 0x0000000189F8BD04-0x0000000189F8BD48
		[RequiredByNativeCode]
		private static void InvokeDeviceLoaded(string loadedDeviceName) {} // 0x0000000189F8BD48-0x0000000189F8BD98
	}
}
