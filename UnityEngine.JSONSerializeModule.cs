/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 140: UnityEngine.JSONSerializeModule.dll - Assembly: UnityEngine.JSONSerializeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91306-91307

namespace UnityEngine
{
	[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
	public static class JsonUtility // TypeDefIndex: 91307
	{
		// Methods
		[FreeFunction("ToJsonInternal", true)]
		[ThreadSafe]
		private static string ToJsonInternal([NotNull("ArgumentNullException")] object obj, bool prettyPrint); // 0x00000001863A2940-0x00000001863A2990
		[FreeFunction("FromJsonInternal", true, ThrowsException = true)]
		[ThreadSafe]
		private static object FromJsonInternal(string json, object objectToOverwrite, System.Type type); // 0x00000001862A71A0-0x00000001862A7200
		public static string ToJson(object obj); // 0x000000018783B884-0x000000018783B890
		public static string ToJson(object obj, bool prettyPrint); // 0x00000001863A28F0-0x00000001863A2940
		public static T FromJson<T>(string json);
		public static object FromJson(string json, System.Type type); // 0x00000001862A70F0-0x00000001862A71A0
		public static void FromJsonOverwrite(string json, object objectToOverwrite); // 0x000000018D542CDC-0x000000018D542E40
	}
}
