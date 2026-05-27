/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 114: Sirenix.Utilities.dll - Assembly: Sirenix.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59850-59862
[assembly: AssemblyCompany("Sirenix ApS")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 2022")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("Sirenix.Utilities")]
[assembly: AssemblyTitle("Sirenix.Utilities")]
[assembly: AssemblyTrademark("")]
[assembly: CLSCompliant(false)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("22731b01-1f5d-477a-811c-df6f1e873a2a")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Sirenix.Utilities
{
	public static class LinqExtensions // TypeDefIndex: 59851
	{
		// Extension methods
		public static void Sort<T>(this IList<T> list, Comparison<T> comparison) {}
	}

	public static class TypeExtensions // TypeDefIndex: 59852
	{
		// Fields
		private static readonly Func<float, float, bool> FloatEqualityComparerFunc; // 0x00
		private static readonly Func<double, double, bool> DoubleEqualityComparerFunc; // 0x08
		private static readonly Func<Quaternion, Quaternion, bool> QuaternionEqualityComparerFunc; // 0x10
		private static readonly object GenericConstraintsSatisfaction_LOCK; // 0x18
		private static readonly Dictionary<System.Type, System.Type> GenericConstraintsSatisfactionInferredParameters; // 0x20
		private static readonly Dictionary<System.Type, System.Type> GenericConstraintsSatisfactionResolvedMap; // 0x28
		private static readonly HashSet<System.Type> GenericConstraintsSatisfactionProcessedParams; // 0x30
		private static readonly HashSet<System.Type> GenericConstraintsSatisfactionTypesToCheck; // 0x38
		private static readonly List<System.Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd; // 0x40
		private static readonly System.Type GenericListInterface; // 0x48
		private static readonly System.Type GenericCollectionInterface; // 0x50
		private static readonly object WeaklyTypedTypeCastDelegates_LOCK; // 0x58
		private static readonly object StronglyTypedTypeCastDelegates_LOCK; // 0x60
		private static readonly DoubleLookupDictionary<System.Type, System.Type, Func<object, object>> WeaklyTypedTypeCastDelegates; // 0x68
		private static readonly DoubleLookupDictionary<System.Type, System.Type, Delegate> StronglyTypedTypeCastDelegates; // 0x70
		private static readonly System.Type[] TwoLengthTypeArray_Cached; // 0x78
		private static readonly Stack<System.Type> GenericArgumentsContainsTypes_ArgsToCheckCached; // 0x80
		private static HashSet<string> ReservedCSharpKeywords; // 0x88
		public static readonly Dictionary<System.Type, string> TypeNameAlternatives; // 0x90
		private static readonly object CachedNiceNames_LOCK; // 0x98
		private static readonly Dictionary<System.Type, string> CachedNiceNames; // 0xA0
		private static readonly System.Type VoidPointerType; // 0xA8
		private static readonly Dictionary<System.Type, HashSet<System.Type>> PrimitiveImplicitCasts; // 0xB0
		private static readonly HashSet<System.Type> ExplicitCastIntegrals; // 0xB8
	
		// Constructors
		static TypeExtensions() {} // 0x0000000189668608-0x000000018966AD10
	
		// Methods
		private static string GetCachedNiceName(System.Type type) => default; // 0x00000001896681AC-0x0000000189668354
		private static string CreateNiceName(System.Type type) => default; // 0x0000000189667E18-0x0000000189668160
		private static bool FloatEqualityComparer(float a, float b) => default; // 0x0000000189668188-0x00000001896681AC
		private static bool DoubleEqualityComparer(double a, double b) => default; // 0x0000000189668160-0x0000000189668188
		private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b) => default; // 0x00000001822CDA10-0x00000001822CDA50
	
		// Extension methods
		private static string GetMaybeSimplifiedTypeName(this System.Type type) => default; // 0x0000000189668354-0x00000001896683F0
		public static string GetNiceName(this System.Type type) => default; // 0x00000001896683F0-0x00000001896684BC
		public static T GetCustomAttribute<T>(this System.Type type, bool inherit)
			where T : Attribute => default;
		public static T GetCustomAttribute<T>(this System.Type type)
			where T : Attribute => default;
		public static bool InheritsFrom(this System.Type type, System.Type baseType) => default; // 0x00000001896684BC-0x0000000189668608
	}

	[Serializable]
	[DefaultMember("Item")]
	public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> // TypeDefIndex: 59853
	{
		// Fields
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;
	
		// Constructors
		public DoubleLookupDictionary() {}
	}

	public interface IGlobalConfigEvents // TypeDefIndex: 59854
	{
		// Methods
		void OnConfigAutoCreated();
		void OnConfigInstanceFirstAccessed();
	}

	public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents // TypeDefIndex: 59855
		where T : GlobalConfig<T>, new()
	{
		// Fields
		private static GlobalConfigAttribute configAttribute;
		private static T instance;
	
		// Properties
		public static GlobalConfigAttribute ConfigAttribute { get; }
		public static bool HasInstanceLoaded { get; }
		public static T Instance { get; }
	
		// Constructors
		protected GlobalConfig() {}
	
		// Methods
		public static void LoadInstanceIfAssetExists() {}
		public void OpenInEditor() {}
		protected virtual void OnConfigInstanceFirstAccessed() {}
		protected virtual void OnConfigAutoCreated() {}
		void IGlobalConfigEvents.OnConfigAutoCreated() {}
		void IGlobalConfigEvents.OnConfigInstanceFirstAccessed() {}
	}

	public static class GlobalConfigUtility<T> // TypeDefIndex: 59856
		where T : ScriptableObject
	{
		// Fields
		private static T instance;
	
		// Properties
		public static bool HasInstanceLoaded { get; }
	
		// Methods
		public static T GetInstance(string defaultAssetFolderPath, string defaultFileNameWithoutExtension = null) => default;
		internal static void LoadInstanceIfAssetExists(string assetPath, string defaultFileNameWithoutExtension = null) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class GlobalConfigAttribute : Attribute // TypeDefIndex: 59857
	{
		// Fields
		private string assetPath; // 0x10
	
		// Properties
		public string AssetPath { get => default; } // 0x0000000189667A64-0x0000000189667B8C 
	
		// Constructors
		public GlobalConfigAttribute() {} // Dummy constructor
		public GlobalConfigAttribute(string assetPath) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class PersistentAssemblyAttribute : Attribute // TypeDefIndex: 59858
	{
		// Constructors
		public PersistentAssemblyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class ProjectPathFinder : ScriptableObject // TypeDefIndex: 59859
	{
		// Constructors
		public ProjectPathFinder() {} // 0x000000018286F540-0x000000018286F550
	}

	public static class SirenixAssetPaths // TypeDefIndex: 59860
	{
		// Fields
		public static readonly string OdinPath; // 0x00
		public static readonly string SirenixAssetsPath; // 0x08
		public static readonly string SirenixPluginPath; // 0x10
		public static readonly string SirenixAssembliesPath; // 0x18
		public static readonly string OdinResourcesPath; // 0x20
		public static readonly string OdinEditorConfigsPath; // 0x28
		public static readonly string OdinResourcesConfigsPath; // 0x30
	
		// Constructors
		static SirenixAssetPaths() {} // 0x0000000189667B8C-0x0000000189667DC4
	}

	public class SirenixGlobalConfigAttribute : GlobalConfigAttribute // TypeDefIndex: 59861
	{
		// Constructors
		public SirenixGlobalConfigAttribute() {} // 0x0000000189667DC4-0x0000000189667E18
	}

	public static class UnityVersion // TypeDefIndex: 59862
	{
		// Fields
		public static readonly int Major; // 0x00
		public static readonly int Minor; // 0x04
	
		// Constructors
		static UnityVersion() {} // 0x000000018267D070-0x000000018267D1A0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void EnsureLoaded() {} // 0x000000018350B670-0x000000018350B680
	}
}
