/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 142: UnityEngine.ImageConversionModule.dll - Assembly: UnityEngine.ImageConversionModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91311-91312

namespace UnityEngine
{
	[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
	public static class ImageConversion // TypeDefIndex: 91312
	{
		// Extension methods
		[NativeMethod(Name = "ImageConversionBindings::EncodeToTGA", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToTGA(this Texture2D tex); // 0x000000018D527020-0x000000018D527054
		[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToPNG(this Texture2D tex); // 0x000000018D526FEC-0x000000018D527020
		[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToJPG(this Texture2D tex, int quality); // 0x000000018D526F9C-0x000000018D526FDC
		public static byte[] EncodeToJPG(this Texture2D tex); // 0x000000018D526FDC-0x000000018D526FEC
		[NativeMethod(Name = "ImageConversionBindings::EncodeToEXR", IsFreeFunction = true, ThrowsException = true)]
		public static byte[] EncodeToEXR(this Texture2D tex, Texture2D.EXRFlags flags); // 0x000000018D526F5C-0x000000018D526F9C
		public static byte[] EncodeToEXR(this Texture2D tex); // 0x000000018D526F50-0x000000018D526F5C
		[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = true)]
		public static bool LoadImage([NotNull("ArgumentNullException")] this Texture2D tex, byte[] data, bool markNonReadable); // 0x000000018D527064-0x000000018D527290
		public static bool LoadImage(this Texture2D tex, byte[] data); // 0x000000018D527054-0x000000018D527064
	}
}
