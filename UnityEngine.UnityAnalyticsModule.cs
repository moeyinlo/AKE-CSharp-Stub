/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 134: UnityEngine.UnityAnalyticsModule.dll - Assembly: UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61177-61187

namespace UnityEngine
{
	public static class RemoteSettings // TypeDefIndex: 61179
	{
		// Fields
		private static UpdatedEventHandler Updated; // 0x00
		private static Action BeforeFetchFromServer; // 0x08
		private static Action<bool, bool, int> Completed; // 0x10
	
		// Nested types
		public delegate void UpdatedEventHandler(); // TypeDefIndex: 61178; 0x000000018C09BF1C-0x000000018C09BF60
	
		// Methods
		internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) {} // 0x000000018C09BF60-0x000000018C09BFD8
		internal static void RemoteSettingsBeforeFetchFromServer() {} // 0x00000001864BC330-0x00000001864BC3F4
		internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) {} // 0x00000001864BC320-0x00000001864BC330
	}

	public class RemoteConfigSettings // TypeDefIndex: 61180
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private Action<bool> Updated; // 0x18
	
		// Constructors
		public RemoteConfigSettings() {} // Dummy constructor
	
		// Methods
		internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) {} // 0x000000018C09BEF4-0x000000018C09BF1C
	}

	internal static class RemoteConfigSettingsHelper // TypeDefIndex: 61182
	{
		// Nested types
		internal enum Tag // TypeDefIndex: 61181
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
	public class ContinuousEvent // TypeDefIndex: 61183
	{
		// Constructors
		public ContinuousEvent() {} // Dummy constructor
	}

	public enum AnalyticsSessionState // TypeDefIndex: 61184
	{
		kSessionStopped = 0,
		kSessionStarted = 1,
		kSessionPaused = 2,
		kSessionResumed = 3
	}

	public static class AnalyticsSessionInfo // TypeDefIndex: 61187
	{
		// Fields
		private static SessionStateChanged sessionStateChanged; // 0x00
		private static IdentityTokenChanged identityTokenChanged; // 0x08
	
		// Nested types
		public delegate void SessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged); // TypeDefIndex: 61185; 0x000000018C09BEA4-0x000000018C09BEF4
	
		public delegate void IdentityTokenChanged(string token); // TypeDefIndex: 61186; 0x00000001836A92C0-0x00000001836A92E0
	
		// Methods
		internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) {} // 0x0000000187759874-0x0000000187759948
		internal static void CallIdentityTokenChanged(string token) {} // 0x00000001833EEC70-0x00000001833EEC80
	}
}
