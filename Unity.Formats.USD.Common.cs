/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using USD.NET.Unity;

// Image 147: Unity.Formats.USD.Common.dll - Assembly: Unity.Formats.USD.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60163-60172

namespace Unity.Formats.USD
{
	[AttributeUsage(AttributeTargets.Struct)]
	public static class InitUsd // TypeDefIndex: 60164
	{
		// Fields
		private static bool m_usdInitialized; // 0x00
		private static bool m_usdInitializeFailed; // 0x01
		private static DiagnosticHandler m_handler; // 0x08
	
		// Methods
		public static bool Initialize() => default; // 0x0000000189B68EC0-0x0000000189B69160
		private static void SetupUsdPath(string sourceFilePath = "" /* Metadata: 0x01FDE14B */) {} // 0x0000000189B69160-0x0000000189B69298
	}

	public enum ImportType // TypeDefIndex: 60165
	{
		Initial = 0,
		ForceRebuild = 1,
		Refresh = 2,
		Streaming = 3
	}

	[AttributeUsage(AttributeTargets.Class)]
	public static class UsdEditorAnalytics // TypeDefIndex: 60172
	{
		// Fields
		private const int k_MaxEventsPerHour = 1000; // Metadata: 0x01FDE153
		private const int k_MaxNumberOfElements = 100; // Metadata: 0x01FDE155
		private const string k_VendorKey = "unity.formats.usd"; // Metadata: 0x01FDE157
		private const string k_UsageEventName = "USDPackageUsage"; // Metadata: 0x01FDE169
		private const string k_ImportEventName = "USDFileImport"; // Metadata: 0x01FDE179
		private const string k_ReimportEventName = "USDFileReimport"; // Metadata: 0x01FDE187
		private const string k_ExportEventName = "USDFileExport"; // Metadata: 0x01FDE197
		private const string k_RecorderExportEventName = "USDFileRecorderExport"; // Metadata: 0x01FDE1A5
		public static Dictionary<string, bool> sUsdEditorAnalyticsEvents; // 0x00
	
		// Nested types
		[AttributeUsage(AttributeTargets.Struct)]
		private struct UsageAnalyticsData // TypeDefIndex: 60166
		{
			// Fields
			public bool InitSucceeded; // 0x00
			public double TimeTakenMs; // 0x08
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		private struct ImportAnalyticsData // TypeDefIndex: 60167
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool IncludesMeshes; // 0x11
			public bool IncludesPointInstancer; // 0x12
			public bool IncludesMaterials; // 0x13
			public bool IncludesSkel; // 0x14
		}
	
		[AttributeUsage(AttributeTargets.Struct)]
		public struct ImportResult // TypeDefIndex: 60168
		{
			// Fields
			public bool Success; // 0x00
			public ImportType ImportType; // 0x04
			public bool ContainsMeshes; // 0x08
			public bool ContainsPointInstancer; // 0x09
			public bool ContainsSkel; // 0x0A
			public bool ContainsMaterials; // 0x0B
	
			// Properties
			public static ImportResult Default { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		}
	
		private struct ReimportAnalyticsData // TypeDefIndex: 60169
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool ForceRebuild; // 0x11
			public bool IncludesMeshes; // 0x12
			public bool IncludesPointInstancer; // 0x13
			public bool IncludesMaterials; // 0x14
			public bool IncludesSkel; // 0x15
		}
	
		private struct ExportAnalyticsData // TypeDefIndex: 60170
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
		}
	
		private struct RecorderExportAnalyticsData // TypeDefIndex: 60171
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
			public int FrameCount; // 0x14
		}
	
		// Constructors
		static UsdEditorAnalytics() {} // 0x0000000183D4E630-0x0000000183D4E640
	
		// Methods
		private static bool RegisterAnalytics(string eventName) => default; // 0x000000018350B670-0x000000018350B680
		public static void SendUsageEvent(bool success, double timeTakenMs) {} // 0x000000018350B670-0x000000018350B680
		public static void SendImportEvent(string fileExtension, double timeTakenMs, ImportResult importResult) {} // 0x000000018350B670-0x000000018350B680
		public static void SendReimportEvent(string fileExtension, double timeTakenMs, ImportResult importResult) {} // 0x000000018350B670-0x000000018350B680
		public static void SendExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x01FDE150 */) {} // 0x000000018350B670-0x000000018350B680
		public static void SendRecorderExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x01FDE151 */, int frameCount = 0 /* Metadata: 0x01FDE152 */) {} // 0x0000000189B69298-0x0000000189B693EC
	}
}
