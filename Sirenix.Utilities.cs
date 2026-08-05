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

// Image 121: Sirenix.Utilities.dll - Assembly: Sirenix.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63614-63626
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
	public static class LinqExtensions // TypeDefIndex: 63615
	{
		// Extension methods
		public static void Sort<T>(this IList<T> list, Comparison<T> comparison);
	}

	public static class TypeExtensions // TypeDefIndex: 63616
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
		static TypeExtensions(); // 0x000000018AC4813C-0x000000018AC4A844
	
		// Methods
		private static string GetCachedNiceName(System.Type type); // 0x000000018AC47D40-0x000000018AC47EB4
		private static string CreateNiceName(System.Type type); // 0x000000018AC479AC-0x000000018AC47CF4
		private static bool FloatEqualityComparer(float a, float b); // 0x000000018AC47D1C-0x000000018AC47D40
		private static bool DoubleEqualityComparer(double a, double b); // 0x000000018AC47CF4-0x000000018AC47D1C
		private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b); // 0x000000018415FC30-0x000000018415FC70
	
		// Extension methods
		private static string GetMaybeSimplifiedTypeName(this System.Type type); // 0x000000018AC47EB4-0x000000018AC47F50
		public static string GetNiceName(this System.Type type); // 0x000000018AC47F50-0x000000018AC47FF0
		public static T GetCustomAttribute<T>(this System.Type type, bool inherit)
			where T : Attribute;
		public static T GetCustomAttribute<T>(this System.Type type)
			where T : Attribute;
		public static bool InheritsFrom(this System.Type type, System.Type baseType); // 0x000000018AC47FF0-0x000000018AC4813C
	}

	[Serializable]
	[DefaultMember("Item")]
	public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> // TypeDefIndex: 63617
	{
		// Fields
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;
	
		// Constructors
		public DoubleLookupDictionary();
	}

	public interface IGlobalConfigEvents // TypeDefIndex: 63618
	{
		// Methods
		void OnConfigAutoCreated();
		void OnConfigInstanceFirstAccessed();
	}

	public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents // TypeDefIndex: 63619
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

	public static class GlobalConfigUtility<T> // TypeDefIndex: 63620
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
	public class GlobalConfigAttribute : Attribute // TypeDefIndex: 63621
	{
		// Fields
		private string assetPath; // 0x10
		[CompilerGenerated]
		private bool _UseAsset_k__BackingField; // 0x18
	
		// Properties
		public string AssetPath { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public GlobalConfigAttribute(string assetPath); // 0x000000018AC475D8-0x000000018AC47720
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public class PersistentAssemblyAttribute : Attribute // TypeDefIndex: 63622
	{
		// Constructors
		public PersistentAssemblyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class ProjectPathFinder : ScriptableObject // TypeDefIndex: 63623
	{
		// Constructors
		public ProjectPathFinder(); // 0x0000000183573370-0x0000000183573380
	}

	public static class SirenixAssetPaths // TypeDefIndex: 63624
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
		static SirenixAssetPaths(); // 0x000000018AC47720-0x000000018AC47958
	}

	public class SirenixGlobalConfigAttribute : GlobalConfigAttribute // TypeDefIndex: 63625
	{
		// Constructors
		public SirenixGlobalConfigAttribute(); // 0x000000018AC47958-0x000000018AC479AC
	}

	public static class UnityVersion // TypeDefIndex: 63626
	{
		// Fields
		public static readonly int Major; // 0x00
		public static readonly int Minor; // 0x04
	
		// Constructors
		static UnityVersion(); // 0x0000000183B0CEC0-0x0000000183B0CFF0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void EnsureLoaded(); // 0x00000001841E1670-0x00000001841E1680
	}
}
