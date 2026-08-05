/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 161: AntiSDK.dll - Assembly: AntiSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63964-63965
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SDK
{
	public static class AntiSDK // TypeDefIndex: 63965
	{
		// Fields
		private const string AntiSDKLib = "HGP"; // Metadata: 0x02353759
		public const string GAME_ID = "RM42"; // Metadata: 0x0235375D
	
		// Properties
		public static bool isInterfaceDisabled { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Methods
		public static extern IntPtr GetConst(string a, int b, string c); // 0x00000001853F74FC-0x00000001853F75C8
		public static extern IntPtr TestFrom(string a, string b); // 0x00000001853F75C8-0x00000001853F7A2C
	}
}
