/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using USD.NET.Unity;

// Image 149: Unity.Formats.USD.Common.dll - Assembly: Unity.Formats.USD.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61248-61257

namespace Unity.Formats.USD
{
	public static class InitUsd // TypeDefIndex: 61249
	{
		// Fields
		private static bool m_usdInitialized; // 0x00
		private static bool m_usdInitializeFailed; // 0x01
		private static DiagnosticHandler m_handler; // 0x08
	
		// Methods
		public static bool Initialize() => default; // 0x000000018BC82734-0x000000018BC829D4
		private static void SetupUsdPath(string sourceFilePath = "" /* Metadata: 0x02083A50 */) {} // 0x000000018BC829D4-0x000000018BC82B0C
	}

	public enum ImportType // TypeDefIndex: 61250
	{
		Initial = 0,
		ForceRebuild = 1,
		Refresh = 2,
		Streaming = 3
	}

	public static class UsdEditorAnalytics // TypeDefIndex: 61257
	{
		// Fields
		private const int k_MaxEventsPerHour = 1000; // Metadata: 0x02083A58
		private const int k_MaxNumberOfElements = 100; // Metadata: 0x02083A5A
		private const string k_VendorKey = "unity.formats.usd"; // Metadata: 0x02083A5C
		private const string k_UsageEventName = "USDPackageUsage"; // Metadata: 0x02083A6E
		private const string k_ImportEventName = "USDFileImport"; // Metadata: 0x02083A7E
		private const string k_ReimportEventName = "USDFileReimport"; // Metadata: 0x02083A8C
		private const string k_ExportEventName = "USDFileExport"; // Metadata: 0x02083A9C
		private const string k_RecorderExportEventName = "USDFileRecorderExport"; // Metadata: 0x02083AAA
		public static Dictionary<string, bool> sUsdEditorAnalyticsEvents; // 0x00
	
		// Nested types
		private struct UsageAnalyticsData // TypeDefIndex: 61251
		{
			// Fields
			public bool InitSucceeded; // 0x00
			public double TimeTakenMs; // 0x08
		}
	
		private struct ImportAnalyticsData // TypeDefIndex: 61252
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
	
		public struct ImportResult // TypeDefIndex: 61253
		{
			// Fields
			public bool Success; // 0x00
			public ImportType ImportType; // 0x04
			public bool ContainsMeshes; // 0x08
			public bool ContainsPointInstancer; // 0x09
			public bool ContainsSkel; // 0x0A
			public bool ContainsMaterials; // 0x0B
	
			// Properties
			public static ImportResult Default { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		}
	
		private struct ReimportAnalyticsData // TypeDefIndex: 61254
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
	
		private struct ExportAnalyticsData // TypeDefIndex: 61255
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
		}
	
		private struct RecorderExportAnalyticsData // TypeDefIndex: 61256
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
			public int FrameCount; // 0x14
		}
	
		// Constructors
		static UsdEditorAnalytics() {} // 0x0000000185FB0190-0x0000000185FB01A0
	
		// Methods
		private static bool RegisterAnalytics(string eventName) => default; // 0x0000000185492010-0x0000000185492020
		public static void SendUsageEvent(bool success, double timeTakenMs) {} // 0x0000000185492010-0x0000000185492020
		public static void SendImportEvent(string fileExtension, double timeTakenMs, ImportResult importResult) {} // 0x0000000185492010-0x0000000185492020
		public static void SendReimportEvent(string fileExtension, double timeTakenMs, ImportResult importResult) {} // 0x0000000185492010-0x0000000185492020
		public static void SendExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x02083A55 */) {} // 0x0000000185492010-0x0000000185492020
		public static void SendRecorderExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x02083A56 */, int frameCount = 0 /* Metadata: 0x02083A57 */) {} // 0x000000018BC82B0C-0x000000018BC82C60
	}
}
