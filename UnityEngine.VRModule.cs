/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;

// Image 136: UnityEngine.VRModule.dll - Assembly: UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61194-61197

namespace UnityEngine.XR
{
	public static class XRSettings // TypeDefIndex: 61196
	{
		// Properties
		public static bool enabled { get; } // 0x000000018C0A3A84-0x000000018C0A3AB0 
		public static bool isDeviceActive { get; } // 0x000000018C0A3B94-0x000000018C0A3BC0 
		public static float eyeTextureResolutionScale { get; set; } // 0x000000018C0A3B3C-0x000000018C0A3B68 0x000000018C0A3C7C-0x000000018C0A3CB8
		public static int eyeTextureWidth { get; } // 0x000000018C0A3B68-0x000000018C0A3B94 
		public static int eyeTextureHeight { get; } // 0x000000018C0A3B10-0x000000018C0A3B3C 
		public static RenderTextureDescriptor eyeTextureDesc { get; } // 0x000000018C0A3AE4-0x000000018C0A3B10 
		public static float renderViewportScale { get; } // 0x000000018C0A3C18-0x000000018C0A3C24 
		internal static float renderViewportScaleInternal { get; } // 0x000000018C0A3BEC-0x000000018C0A3C18 
		public static string loadedDeviceName { get; } // 0x000000018C0A3BC0-0x000000018C0A3BEC 
		public static string[] supportedDevices { get; } // 0x000000018C0A3C50-0x000000018C0A3C7C 
		public static StereoRenderingMode stereoRenderingMode { get; } // 0x000000018C0A3C24-0x000000018C0A3C50 
	
		// Nested types
		public enum StereoRenderingMode // TypeDefIndex: 61195
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiview = 3
		}
	
		// Methods
		private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) {
			ret = default;
		} // 0x000000018C0A3AB0-0x000000018C0A3AE4
	}

	public static class XRDevice // TypeDefIndex: 61197
	{
		// Fields
		private static Action<string> deviceLoaded; // 0x00
	
		// Methods
		public static void DisableAutoXRCameraTracking(Camera camera, bool disabled) {} // 0x000000018C0A39F0-0x000000018C0A3A34
		private static void InvokeDeviceLoaded(string loadedDeviceName) {} // 0x000000018C0A3A34-0x000000018C0A3A84
	}
}
