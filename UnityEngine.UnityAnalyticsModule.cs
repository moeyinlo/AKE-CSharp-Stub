/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 135: UnityEngine.UnityAnalyticsModule.dll - Assembly: UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91279-91289

namespace UnityEngine
{
	[NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
	public static class RemoteSettings // TypeDefIndex: 91281
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UpdatedEventHandler Updated; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action BeforeFetchFromServer; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<bool, bool, int> Completed; // 0x10
	
		// Nested types
		public delegate void UpdatedEventHandler(); // TypeDefIndex: 91280; 0x0000000185B44B70-0x0000000185B44B80
	
		// Methods
		[RequiredByNativeCode]
		internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer); // 0x000000018D6B25AC-0x000000018D6B25F8
		[RequiredByNativeCode]
		internal static void RemoteSettingsBeforeFetchFromServer(); // 0x000000018D6B24F0-0x000000018D6B2534
		[RequiredByNativeCode]
		internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response); // 0x000000018D6B2534-0x000000018D6B25AC
	}

	[ExcludeFromDocs]
	[NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
	public class RemoteConfigSettings // TypeDefIndex: 91282
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<bool> Updated; // 0x18
	
		// Methods
		[RequiredByNativeCode]
		internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer); // 0x000000018D6B24C8-0x000000018D6B24F0
	}

	internal static class RemoteConfigSettingsHelper // TypeDefIndex: 91284
	{
		// Nested types
		[RequiredByNativeCode]
		internal enum Tag // TypeDefIndex: 91283
		{
			kUnknown = 0,
			kIntVal = 1,
			kInt64Val = 2,
			kUInt64Val = 3,
			kDoubleVal = 4,
			kBoolVal = 5,
			kStringVal = 6,
			kArrayVal = 7,
			kMixedArrayVal = 8,
			kMapVal = 9,
			kMaxTags = 10
		}
	}
}

namespace UnityEngine.Analytics
{
	[ExcludeFromDocs]
	[NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
	[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[RequiredByNativeCode]
	public class ContinuousEvent // TypeDefIndex: 91285
	{
	}

	[RequiredByNativeCode]
	public enum AnalyticsSessionState // TypeDefIndex: 91286
	{
		kSessionStopped = 0,
		kSessionStarted = 1,
		kSessionPaused = 2,
		kSessionResumed = 3
	}

	[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[RequiredByNativeCode]
	public static class AnalyticsSessionInfo // TypeDefIndex: 91289
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static SessionStateChanged sessionStateChanged; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static IdentityTokenChanged identityTokenChanged; // 0x08
	
		// Nested types
		public delegate void SessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged); // TypeDefIndex: 91287; 0x0000000181217F60-0x0000000181217F80
	
		public delegate void IdentityTokenChanged(string token); // TypeDefIndex: 91288; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[RequiredByNativeCode]
		internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged); // 0x00000001871E4120-0x00000001871E4190
		[RequiredByNativeCode]
		internal static void CallIdentityTokenChanged(string token); // 0x000000018D6B2474-0x000000018D6B24C8
	}
}
