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

// Image 122: Sirenix.Utilities.dll - Assembly: Sirenix.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91090-91102

namespace Sirenix.Utilities
{
	public static class LinqExtensions // TypeDefIndex: 91091
	{
		// Extension methods
		public static void Sort<T>(this IList<T> list, Comparison<T> comparison);
	}

	public static class TypeExtensions // TypeDefIndex: 91092
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
		static TypeExtensions(); // 0x000000018CE39C20-0x000000018CE3C328
	
		// Methods
		private static string GetCachedNiceName(System.Type type); // 0x000000018CE3982C-0x000000018CE39994
		private static string CreateNiceName(System.Type type); // 0x000000018CE39488-0x000000018CE397E0
		private static bool FloatEqualityComparer(float a, float b); // 0x000000018CE39808-0x000000018CE3982C
		private static bool DoubleEqualityComparer(double a, double b); // 0x000000018CE397E0-0x000000018CE39808
		private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b); // 0x00000001862F2760-0x00000001862F27A0
	
		// Extension methods
		private static string GetMaybeSimplifiedTypeName(this System.Type type); // 0x000000018CE39994-0x000000018CE39A34
		public static string GetNiceName(this System.Type type); // 0x000000018CE39A34-0x000000018CE39AD4
		public static T GetCustomAttribute<T>(this System.Type type, bool inherit)
			where T : Attribute;
		public static T GetCustomAttribute<T>(this System.Type type)
			where T : Attribute;
		public static bool InheritsFrom(this System.Type type, System.Type baseType); // 0x000000018CE39AD4-0x000000018CE39C20
	}

	[Serializable]
	[DefaultMember("Item")]
	public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> // TypeDefIndex: 91093
	{
		// Fields
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;
	
		// Constructors
		public DoubleLookupDictionary();
	}

	public interface IGlobalConfigEvents // TypeDefIndex: 91094
	{
		// Methods
		void OnConfigAutoCreated();
		void OnConfigInstanceFirstAccessed();
	}

	public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents // TypeDefIndex: 91095
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
		protected GlobalConfig();
	
		// Methods
		public static void LoadInstanceIfAssetExists();
		public void OpenInEditor();
		protected virtual void OnConfigInstanceFirstAccessed();
		protected virtual void OnConfigAutoCreated();
		void IGlobalConfigEvents.OnConfigAutoCreated();
		void IGlobalConfigEvents.OnConfigInstanceFirstAccessed();
	}

	public static class GlobalConfigUtility<T> // TypeDefIndex: 91096
		where T : ScriptableObject
	{
		// Fields
		private static T instance;
	
		// Properties
		public static bool HasInstanceLoaded { get; }
	
		// Methods
		public static T GetInstance(string defaultAssetFolderPath, string defaultFileNameWithoutExtension = null);
		internal static void LoadInstanceIfAssetExists(string assetPath, string defaultFileNameWithoutExtension = null);
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class GlobalConfigAttribute : Attribute // TypeDefIndex: 91097
	{
		// Fields
		private string assetPath; // 0x10
		[CompilerGenerated]
		private bool _UseAsset_k__BackingField; // 0x18
	
		// Properties
		public string AssetPath { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public GlobalConfigAttribute(string assetPath); // 0x000000018CE390B4-0x000000018CE391FC
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class PersistentAssemblyAttribute : Attribute // TypeDefIndex: 91098
	{
		// Constructors
		public PersistentAssemblyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class ProjectPathFinder : ScriptableObject // TypeDefIndex: 91099
	{
		// Constructors
		public ProjectPathFinder(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	public static class SirenixAssetPaths // TypeDefIndex: 91100
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
		static SirenixAssetPaths(); // 0x000000018CE391FC-0x000000018CE39434
	}

	public class SirenixGlobalConfigAttribute : GlobalConfigAttribute // TypeDefIndex: 91101
	{
		// Constructors
		public SirenixGlobalConfigAttribute(); // 0x000000018CE39434-0x000000018CE39488
	}

	public static class UnityVersion // TypeDefIndex: 91102
	{
		// Fields
		public static readonly int Major; // 0x00
		public static readonly int Minor; // 0x04
	
		// Constructors
		static UnityVersion(); // 0x0000000186F83B20-0x0000000186F83C50
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void EnsureLoaded(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
