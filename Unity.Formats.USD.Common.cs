/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using USD.NET.Unity;

// Image 152: Unity.Formats.USD.Common.dll - Assembly: Unity.Formats.USD.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91367-91376

namespace Unity.Formats.USD
{
	public static class InitUsd // TypeDefIndex: 91368
	{
		// Fields
		private static bool m_usdInitialized; // 0x00
		private static bool m_usdInitializeFailed; // 0x01
		private static DiagnosticHandler m_handler; // 0x08
	
		// Methods
		public static bool Initialize(); // 0x000000018D2AEA04-0x000000018D2AECA4
		private static void SetupUsdPath([CallerFilePath] string sourceFilePath = "" /* Metadata: 0x0264C05A */); // 0x000000018D2AECA4-0x000000018D2AEDDC
	}

	public enum ImportType // TypeDefIndex: 91369
	{
		Initial = 0,
		ForceRebuild = 1,
		Refresh = 2,
		Streaming = 3
	}

	public static class UsdEditorAnalytics // TypeDefIndex: 91376
	{
		// Fields
		private const int k_MaxEventsPerHour = 1000; // Metadata: 0x0264C062
		private const int k_MaxNumberOfElements = 100; // Metadata: 0x0264C064
		private const string k_VendorKey = "unity.formats.usd"; // Metadata: 0x0264C066
		private const string k_UsageEventName = "USDPackageUsage"; // Metadata: 0x0264C078
		private const string k_ImportEventName = "USDFileImport"; // Metadata: 0x0264C088
		private const string k_ReimportEventName = "USDFileReimport"; // Metadata: 0x0264C096
		private const string k_ExportEventName = "USDFileExport"; // Metadata: 0x0264C0A6
		private const string k_RecorderExportEventName = "USDFileRecorderExport"; // Metadata: 0x0264C0B4
		public static Dictionary<string, bool> sUsdEditorAnalyticsEvents; // 0x00
	
		// Nested types
		private struct UsageAnalyticsData // TypeDefIndex: 91370
		{
			// Fields
			public bool InitSucceeded; // 0x00
			public double TimeTakenMs; // 0x08
		}
	
		private struct ImportAnalyticsData // TypeDefIndex: 91371
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
	
		public struct ImportResult // TypeDefIndex: 91372
		{
			// Fields
			public bool Success; // 0x00
			public ImportType ImportType; // 0x04
			public bool ContainsMeshes; // 0x08
			public bool ContainsPointInstancer; // 0x09
			public bool ContainsSkel; // 0x0A
			public bool ContainsMaterials; // 0x0B
	
			// Properties
			public static ImportResult Default { get; } // 0x0000000187232AC0-0x0000000187232AD0 
		}
	
		private struct ReimportAnalyticsData // TypeDefIndex: 91373
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
	
		private struct ExportAnalyticsData // TypeDefIndex: 91374
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
		}
	
		private struct RecorderExportAnalyticsData // TypeDefIndex: 91375
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
			public int FrameCount; // 0x14
		}
	
		// Constructors
		static UsdEditorAnalytics(); // 0x000000018D2AEDDC-0x000000018D2AEF30
	
		// Methods
		private static bool RegisterAnalytics(string eventName); // 0x00000001843FFFF0-0x0000000184400000
		public static void SendUsageEvent(bool success, double timeTakenMs); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SendImportEvent(string fileExtension, double timeTakenMs, ImportResult importResult); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SendReimportEvent(string fileExtension, double timeTakenMs, ImportResult importResult); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SendExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x0264C05F */); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SendRecorderExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x0264C060 */, int frameCount = 0 /* Metadata: 0x0264C061 */); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
