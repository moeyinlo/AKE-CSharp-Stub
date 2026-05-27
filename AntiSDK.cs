/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 157: AntiSDK.dll - Assembly: AntiSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60241-60242
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SDK
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public static class AntiSDK // TypeDefIndex: 60242
	{
		// Fields
		private const string AntiSDKLib = "HGP"; // Metadata: 0x01FDE1D5
		public const string GAME_ID = "RM42"; // Metadata: 0x01FDE1D9
	
		// Properties
		public static bool isInterfaceDisabled { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Methods
		public static extern IntPtr GetConst(string a, int b, string c); // 0x00000001842D6760-0x00000001842D682C
		public static extern IntPtr TestFrom(string a, string b); // 0x00000001842D682C-0x00000001842D6C70
	}
}
