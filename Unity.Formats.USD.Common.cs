/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using USD.NET.Unity;

// Image 151: Unity.Formats.USD.Common.dll - Assembly: Unity.Formats.USD.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63887-63896
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Unity.Formats.USD
{
	public static class InitUsd // TypeDefIndex: 63888
	{
		// Fields
		private static bool m_usdInitialized; // 0x00
		private static bool m_usdInitializeFailed; // 0x01
		private static DiagnosticHandler m_handler; // 0x08
	
		// Methods
		public static bool Initialize(); // 0x000000018B165660-0x000000018B165900
		private static void SetupUsdPath([CallerFilePath] string sourceFilePath = "" /* Metadata: 0x023536D0 */); // 0x000000018B165900-0x000000018B165A38
	}

	public enum ImportType // TypeDefIndex: 63889
	{
		Initial = 0,
		ForceRebuild = 1,
		Refresh = 2,
		Streaming = 3
	}

	public static class UsdEditorAnalytics // TypeDefIndex: 63896
	{
		// Fields
		private const int k_MaxEventsPerHour = 1000; // Metadata: 0x023536D8
		private const int k_MaxNumberOfElements = 100; // Metadata: 0x023536DA
		private const string k_VendorKey = "unity.formats.usd"; // Metadata: 0x023536DC
		private const string k_UsageEventName = "USDPackageUsage"; // Metadata: 0x023536EE
		private const string k_ImportEventName = "USDFileImport"; // Metadata: 0x023536FE
		private const string k_ReimportEventName = "USDFileReimport"; // Metadata: 0x0235370C
		private const string k_ExportEventName = "USDFileExport"; // Metadata: 0x0235371C
		private const string k_RecorderExportEventName = "USDFileRecorderExport"; // Metadata: 0x0235372A
		public static Dictionary<string, bool> sUsdEditorAnalyticsEvents; // 0x00
	
		// Nested types
		private struct UsageAnalyticsData // TypeDefIndex: 63890
		{
			// Fields
			public bool InitSucceeded; // 0x00
			public double TimeTakenMs; // 0x08
		}
	
		private struct ImportAnalyticsData // TypeDefIndex: 63891
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
	
		public struct ImportResult // TypeDefIndex: 63892
		{
			// Fields
			public bool Success; // 0x00
			public ImportType ImportType; // 0x04
			public bool ContainsMeshes; // 0x08
			public bool ContainsPointInstancer; // 0x09
			public bool ContainsSkel; // 0x0A
			public bool ContainsMaterials; // 0x0B
	
			// Properties
			public static ImportResult Default { get; } // 0x0000000184D85DC0-0x0000000184D85DD0 
		}
	
		private struct ReimportAnalyticsData // TypeDefIndex: 63893
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
	
		private struct ExportAnalyticsData // TypeDefIndex: 63894
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
		}
	
		private struct RecorderExportAnalyticsData // TypeDefIndex: 63895
		{
			// Fields
			public string FileExtension; // 0x00
			public double TimeTakenMs; // 0x08
			public bool Succeeded; // 0x10
			public bool OnlyOverrides; // 0x11
			public int FrameCount; // 0x14
		}
	
		// Constructors
		static UsdEditorAnalytics(); // 0x000000018B165A38-0x000000018B165B8C
	
		// Methods
		private static bool RegisterAnalytics(string eventName); // 0x00000001812081B0-0x0000000181208610
		public static void SendUsageEvent(bool success, double timeTakenMs); // 0x00000001841E1670-0x00000001841E1680
		public static void SendImportEvent(string fileExtension, double timeTakenMs, ImportResult importResult); // 0x00000001841E1670-0x00000001841E1680
		public static void SendReimportEvent(string fileExtension, double timeTakenMs, ImportResult importResult); // 0x00000001841E1670-0x00000001841E1680
		public static void SendExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x023536D5 */); // 0x00000001841E1670-0x00000001841E1680
		public static void SendRecorderExportEvent(string fileExtension, double timeTakenMs, bool exportSucceeded, bool onlyOverrides = false /* Metadata: 0x023536D6 */, int frameCount = 0 /* Metadata: 0x023536D7 */); // 0x00000001841E1670-0x00000001841E1680
	}
}
