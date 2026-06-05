/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using UnityEngine;

// Image 118: Sirenix.Utilities.dll - Assembly: Sirenix.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60971-60983

namespace Sirenix.Utilities
{
	public static class LinqExtensions // TypeDefIndex: 60972
	{
		// Methods
		public static void Sort<T>(IList<T> list, Comparison<T> comparison) {}
	}

	public static class TypeExtensions // TypeDefIndex: 60973
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
		static TypeExtensions() {} // 0x000000018B78E724-0x000000018B790E2C
	
		// Methods
		private static string GetCachedNiceName(System.Type type) => default; // 0x000000018B78E2C8-0x000000018B78E470
		private static string CreateNiceName(System.Type type) => default; // 0x000000018B78DF34-0x000000018B78E27C
		private static bool FloatEqualityComparer(float a, float b) => default; // 0x000000018B78E2A4-0x000000018B78E2C8
		private static bool DoubleEqualityComparer(double a, double b) => default; // 0x000000018B78E27C-0x000000018B78E2A4
		private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		private static string GetMaybeSimplifiedTypeName(System.Type type) => default; // 0x000000018B78E470-0x000000018B78E50C
		public static string GetNiceName(System.Type type) => default; // 0x000000018B78E50C-0x000000018B78E5D8
		public static T GetCustomAttribute<T>(System.Type type, bool inherit)
			where T : Attribute => default;
		public static T GetCustomAttribute<T>(System.Type type)
			where T : Attribute => default;
		public static bool InheritsFrom(System.Type type, System.Type baseType) => default; // 0x000000018B78E5D8-0x000000018B78E724
	}

	[Serializable]
	public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> // TypeDefIndex: 60974
	{
		// Fields
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;
	
		// Constructors
		public DoubleLookupDictionary() {}
	}

	public interface IGlobalConfigEvents // TypeDefIndex: 60975
	{
		// Methods
		void OnConfigAutoCreated();
		void OnConfigInstanceFirstAccessed();
	}

	public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents // TypeDefIndex: 60976
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

	public static class GlobalConfigUtility<T> // TypeDefIndex: 60977
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

	public class GlobalConfigAttribute : Attribute // TypeDefIndex: 60978
	{
		// Fields
		private string assetPath; // 0x10
		private bool _UseAsset_k__BackingField; // 0x18
	
		// Properties
		public string AssetPath { get => default; } // 0x000000018B78DB80-0x000000018B78DCA8 
	
		// Constructors
		public GlobalConfigAttribute() {} // Dummy constructor
		public GlobalConfigAttribute(string assetPath) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class PersistentAssemblyAttribute : Attribute // TypeDefIndex: 60979
	{
		// Constructors
		public PersistentAssemblyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ProjectPathFinder : ScriptableObject // TypeDefIndex: 60980
	{
		// Constructors
		public ProjectPathFinder() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public static class SirenixAssetPaths // TypeDefIndex: 60981
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
		static SirenixAssetPaths() {} // 0x000000018B78DCA8-0x000000018B78DEE0
	}

	public class SirenixGlobalConfigAttribute : GlobalConfigAttribute // TypeDefIndex: 60982
	{
		// Constructors
		public SirenixGlobalConfigAttribute() {} // 0x000000018B78DEE0-0x000000018B78DF34
	}

	public static class UnityVersion // TypeDefIndex: 60983
	{
		// Fields
		public static readonly int Major; // 0x00
		public static readonly int Minor; // 0x04
	
		// Constructors
		static UnityVersion() {} // 0x0000000185D21530-0x0000000185D21660
	
		// Methods
		private static void EnsureLoaded() {} // 0x0000000185492010-0x0000000185492020
	}
}
