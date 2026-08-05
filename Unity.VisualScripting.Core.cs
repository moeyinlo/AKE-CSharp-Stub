/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using JetBrains.Annotations;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using Unity.VisualScripting.FullSerializer.Internal;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Image 40: Unity.VisualScripting.Core.dll - Assembly: Unity.VisualScripting.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58935-59194
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Tests")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.SettingsProvider.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.State")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.State.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Flow")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Flow.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Core.Editor")]
[assembly: RenamedNamespace("Ludiq", "Unity.VisualScripting")]
[assembly: RenamedNamespace("Bolt", "Unity.VisualScripting")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Unity.VisualScripting
{
	public abstract class Cloner<T> : ICloner // TypeDefIndex: 58936
	{
		// Constructors
		protected Cloner();
	
		// Methods
		public abstract bool Handles(System.Type type);
		void ICloner.BeforeClone(System.Type type, object original);
		public virtual void BeforeClone(System.Type type, T original);
		object ICloner.ConstructClone(System.Type type, object original);
		public virtual T ConstructClone(System.Type type, T original);
		void ICloner.FillClone(System.Type type, ref object clone, object original, CloningContext context);
		public virtual void FillClone(System.Type type, ref ref T clone, T original, CloningContext context);
		void ICloner.AfterClone(System.Type type, object clone);
		public virtual void AfterClone(System.Type type, T clone);
	}

	public sealed class AnimationCurveCloner : Cloner<AnimationCurve> // TypeDefIndex: 58937
	{
		// Constructors
		public AnimationCurveCloner(); // 0x00000001845BFD30-0x00000001845BFD60
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B352534-0x000000018B352598
		public override AnimationCurve ConstructClone(System.Type type, AnimationCurve original); // 0x000000018B352424-0x000000018B352474
		public override void FillClone(System.Type type, ref AnimationCurve clone, AnimationCurve original, CloningContext context); // 0x000000018B352474-0x000000018B352534
	}

	public sealed class ArrayCloner : Cloner<Array> // TypeDefIndex: 58938
	{
		// Constructors
		public ArrayCloner(); // 0x00000001845BFD00-0x00000001845BFD30
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B352868-0x000000018B352888
		public override Array ConstructClone(System.Type type, Array original); // 0x000000018B35274C-0x000000018B352778
		public override void FillClone(System.Type type, ref Array clone, Array original, CloningContext context); // 0x000000018B352778-0x000000018B352868
	}

	public sealed class DictionaryCloner : Cloner<IDictionary> // TypeDefIndex: 58939
	{
		// Constructors
		public DictionaryCloner(); // 0x00000001845BFCD0-0x00000001845BFD00
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B35706C-0x000000018B3570E4
		public override void FillClone(System.Type type, ref IDictionary clone, IDictionary original, CloningContext context); // 0x000000018B356F80-0x000000018B35706C
	}

	public sealed class EnumerableCloner : Cloner<IEnumerable> // TypeDefIndex: 58940
	{
		// Fields
		private readonly Dictionary<System.Type, IOptimizedInvoker> addMethods; // 0x10
	
		// Constructors
		public EnumerableCloner(); // 0x00000001845BFDD0-0x00000001845BFE60
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B3578E8-0x000000018B3579CC
		public override void FillClone(System.Type type, ref IEnumerable clone, IEnumerable original, CloningContext context); // 0x000000018B3574D4-0x000000018B3576EC
		private IOptimizedInvoker GetAddMethod(System.Type type); // 0x000000018B3576EC-0x000000018B3578E8
	}

	public sealed class FakeSerializationCloner : ReflectedCloner // TypeDefIndex: 58942
	{
		// Fields
		[CompilerGenerated]
		private fsConfig _config_k__BackingField; // 0x20
	
		// Properties
		public fsConfig config { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58941
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsMetaProperty, MemberInfo> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B36BBC4-0x000000018B36BC28
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MemberInfo _GetMembers_b__6_0(fsMetaProperty p); // 0x0000000186C08920-0x0000000186C08938
		}
	
		// Constructors
		public FakeSerializationCloner(); // 0x00000001845BFD60-0x00000001845BFDD0
	
		// Methods
		public override void BeforeClone(System.Type type, object original); // 0x000000018B358610-0x000000018B358658
		public override void AfterClone(System.Type type, object clone); // 0x000000018B3585C8-0x000000018B358610
		protected override IEnumerable<MemberInfo> GetMembers(System.Type type); // 0x000000018B358658-0x000000018B358798
	}

	public sealed class FieldsCloner : ReflectedCloner // TypeDefIndex: 58943
	{
		// Constructors
		public FieldsCloner(); // 0x000000018539798C-0x0000000185397994
	
		// Methods
		protected override bool IncludeField(System.Reflection.FieldInfo field); // 0x0000000182FFF600-0x0000000182FFF610
		protected override bool IncludeProperty(PropertyInfo property); // 0x00000001812081B0-0x0000000181208610
	}

	internal sealed class GradientCloner : Cloner<Gradient> // TypeDefIndex: 58944
	{
		// Constructors
		public GradientCloner(); // 0x00000001845BFCA0-0x00000001845BFCD0
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B358868-0x000000018B3588CC
		public override Gradient ConstructClone(System.Type type, Gradient original); // 0x000000018B358798-0x000000018B3587E8
		public override void FillClone(System.Type type, ref Gradient clone, Gradient original, CloningContext context); // 0x000000018B3587E8-0x000000018B358868
	}

	public sealed class ListCloner : Cloner<IList> // TypeDefIndex: 58945
	{
		// Constructors
		public ListCloner(); // 0x00000001845BFC70-0x00000001845BFCA0
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B35C140-0x000000018B35C1B8
		public override void FillClone(System.Type type, ref IList clone, IList original, CloningContext context); // 0x000000018B35BF9C-0x000000018B35C140
	}

	public abstract class ReflectedCloner : Cloner<object> // TypeDefIndex: 58946
	{
		// Fields
		private readonly Dictionary<System.Type, MemberInfo[]> accessors; // 0x10
		private readonly Dictionary<System.Type, IOptimizedAccessor[]> optimizedAccessors; // 0x18
	
		// Constructors
		protected ReflectedCloner(); // 0x00000001845BFE60-0x00000001845BFF30
	
		// Methods
		public override bool Handles(System.Type type); // 0x00000001812081B0-0x0000000181208610
		public override void FillClone(System.Type type, ref object clone, object original, CloningContext context); // 0x000000018B361738-0x000000018B361AB8
		private MemberInfo[] GetAccessors(System.Type type); // 0x000000018B361AB8-0x000000018B361B94
		private IOptimizedAccessor[] GetOptimizedAccessors(System.Type type); // 0x000000018B361D48-0x000000018B362078
		protected virtual IEnumerable<MemberInfo> GetMembers(System.Type type); // 0x000000018B361B94-0x000000018B361D48
		protected virtual bool IncludeField(System.Reflection.FieldInfo field); // 0x00000001812081B0-0x0000000181208610
		protected virtual bool IncludeProperty(PropertyInfo property); // 0x00000001812081B0-0x0000000181208610
	}

	public static class Cloning // TypeDefIndex: 58948
	{
		// Fields
		private static readonly Dictionary<System.Type, bool> skippable; // 0x00
		[CompilerGenerated]
		private static readonly HashSet<ICloner> _cloners_k__BackingField; // 0x08
		[CompilerGenerated]
		private static readonly ArrayCloner _arrayCloner_k__BackingField; // 0x10
		[CompilerGenerated]
		private static readonly DictionaryCloner _dictionaryCloner_k__BackingField; // 0x18
		[CompilerGenerated]
		private static readonly EnumerableCloner _enumerableCloner_k__BackingField; // 0x20
		[CompilerGenerated]
		private static readonly ListCloner _listCloner_k__BackingField; // 0x28
		[CompilerGenerated]
		private static readonly AnimationCurveCloner _animationCurveCloner_k__BackingField; // 0x30
		[CompilerGenerated]
		private static readonly GradientCloner _gradientCloner_k__BackingField; // 0x38
		[CompilerGenerated]
		private static readonly FieldsCloner _fieldsCloner_k__BackingField; // 0x40
		[CompilerGenerated]
		private static readonly FakeSerializationCloner _fakeSerializationCloner_k__BackingField; // 0x48
	
		// Properties
		public static HashSet<ICloner> cloners { [CompilerGenerated] get; } // 0x000000018B3532E0-0x000000018B353330 
		public static ArrayCloner arrayCloner { [CompilerGenerated] get; } // 0x000000018B353290-0x000000018B3532E0 
		public static DictionaryCloner dictionaryCloner { [CompilerGenerated] get; } // 0x000000018B353330-0x000000018B353380 
		public static EnumerableCloner enumerableCloner { [CompilerGenerated] get; } // 0x000000018B353380-0x000000018B3533D0 
		public static ListCloner listCloner { [CompilerGenerated] get; } // 0x000000018B353470-0x000000018B3534C0 
		public static AnimationCurveCloner animationCurveCloner { [CompilerGenerated] get; } // 0x000000018B353240-0x000000018B353290 
		internal static GradientCloner gradientCloner { [CompilerGenerated] get; } // 0x000000018B353420-0x000000018B353470 
		public static FakeSerializationCloner fakeSerializationCloner { [CompilerGenerated] get; } // 0x000000018B3533D0-0x000000018B353420 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 58947
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetCloner_b__0(ICloner cloner); // 0x000000018B36B81C-0x000000018B36B908
		}
	
		// Constructors
		static Cloning(); // 0x00000001845BF5F0-0x00000001845BFC70
	
		// Methods
		internal static object Clone(CloningContext context, object original); // 0x00000001839E8530-0x00000001839E85A0
		internal static void CloneInto(CloningContext context, ref object clone, object original); // 0x00000001839E8870-0x00000001839E8AE0
		[CanBeNull]
		public static ICloner GetCloner(object original, System.Type type); // 0x00000001839E8B80-0x00000001839E8CA0
		private static ICloner GetCloner(object original, System.Type type, ICloner fallbackCloner); // 0x00000001839E8AE0-0x00000001839E8B80
		private static bool Skippable(System.Type type); // 0x00000001839E9F30-0x00000001839EA130
	
		// Extension methods
		public static object Clone(this object original, ICloner fallbackCloner, bool tryPreserveInstances); // 0x00000001839E8440-0x00000001839E8530
		public static object CloneViaFakeSerialization(this object original); // 0x00000001839E83B0-0x00000001839E8440
		public static T CloneViaFakeSerialization<T>(this T original);
	}

	public sealed class CloningContext : IPoolable, IDisposable // TypeDefIndex: 58950
	{
		// Fields
		[CompilerGenerated]
		private readonly Dictionary<object, object> _clonings_k__BackingField; // 0x10
		[CompilerGenerated]
		private ICloner _fallbackCloner_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _tryPreserveInstances_k__BackingField; // 0x20
		private bool disposed; // 0x21
	
		// Properties
		public Dictionary<object, object> clonings { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public ICloner fallbackCloner { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool tryPreserveInstances { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58949
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CloningContext> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D454F0-0x0000000184D45550
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal CloningContext _New_b__15_0(); // 0x00000001839E80E0-0x00000001839E8130
		}
	
		// Constructors
		public CloningContext(); // 0x00000001839E8130-0x00000001839E81F0
	
		// Methods
		void IPoolable.New(); // 0x0000000184DBA710-0x0000000184DBA720
		void IPoolable.Free(); // 0x0000000183B7DA20-0x0000000183B7DA70
		public void Dispose(); // 0x0000000184CF4DD0-0x0000000184CF4E40
		public static CloningContext New(ICloner fallbackCloner, bool tryPreserveInstances); // 0x00000001839E85A0-0x00000001839E8710
	}

	public interface ICloner // TypeDefIndex: 58951
	{
		// Methods
		bool Handles(System.Type type);
		object ConstructClone(System.Type type, object original);
		void BeforeClone(System.Type type, object original);
		void FillClone(System.Type type, ref object clone, object original, CloningContext context);
		void AfterClone(System.Type type, object clone);
	}

	public interface ISpecifiesCloner // TypeDefIndex: 58952
	{
		// Properties
		ICloner cloner { get; }
	}

	public sealed class AotDictionary : OrderedDictionary // TypeDefIndex: 58953
	{
		// Constructors
		public AotDictionary(); // 0x000000018AFF6D1C-0x000000018AFF6D30
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void AotStubs(); // 0x000000018B352598-0x000000018B352640
	}

	public sealed class AotList : ArrayList // TypeDefIndex: 58954
	{
		// Constructors
		public AotList(); // 0x000000018AF96728-0x000000018AF96730
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void AotStubs(); // 0x000000018B352640-0x000000018B3526F8
	}

	public class GuidCollection<T> : KeyedCollection<Guid, T>, ICollection<T> // TypeDefIndex: 58955
		where T : IIdentifiable
	{
		// Methods
		protected override Guid GetKeyForItem(T item);
	}

	public interface IKeyedCollection<TKey, TItem> : ICollection<TItem> // TypeDefIndex: 58956
	{
		// Properties
		TItem this[TKey key] { get => default; }
		TItem this[int index] { get => default; }
	
		// Methods
		bool Contains(TKey key);
	}

	[DefaultMember("Item")]
	public class MergedKeyedCollection<TKey, TItem> : IEnumerable<TItem> // TypeDefIndex: 58958
	{
		// Fields
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collections;
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsLookup;
	
		// Nested types
		public struct Enumerator : IEnumerator<TItem> // TypeDefIndex: 58957
		{
			// Fields
			private Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsEnumerator;
			private TItem currentItem;
			private IKeyedCollection<TKey, TItem> currentCollection;
			private int indexInCurrentCollection;
			private bool exceeded;
	
			// Properties
			public TItem Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator(MergedKeyedCollection<TKey, TItem> merged);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			void IEnumerator.Reset();
		}
	
		// Methods
		protected IKeyedCollection<TKey, TItem> GetCollectionForItem(TItem item);
		protected IKeyedCollection<TKey, TItem> GetCollectionForType(System.Type type, bool throwOnFail = true /* Metadata: 0x0234C5F7 */);
		public virtual void Add(TItem item);
		public void Clear();
		public bool Contains(TItem item);
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator();
		public Enumerator GetEnumerator();
	}

	public class ConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, List<TConnection>> // TypeDefIndex: 58959
		where TConnection : IConnection<TSource, TDestination>
	{
		// Constructors
		public ConnectionCollection();
	}

	[DefaultMember("Item")]
	public class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : IConnectionCollection<TConnection, TSource, TDestination> // TypeDefIndex: 58960
		where TConnection : IConnection<TSource, TDestination>
		where TCollection : ICollection<TConnection>
	{
		// Fields
		private readonly Dictionary<TDestination, List<TConnection>> byDestination;
		private readonly Dictionary<TSource, List<TConnection>> bySource;
		protected readonly TCollection collection;
	
		// Properties
		public int Count { get; }
		public bool IsReadOnly { get; }
	
		// Constructors
		public ConnectionCollectionBase(TCollection collection);
	
		// Methods
		public IEnumerator<TConnection> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public IEnumerable<TConnection> WithSource(TSource source);
		public List<TConnection> WithSourceNoAlloc(TSource source);
		public TConnection SingleOrDefaultWithSource(TSource source);
		public IEnumerable<TConnection> WithDestination(TDestination destination);
		public List<TConnection> WithDestinationNoAlloc(TDestination destination);
		public TConnection SingleOrDefaultWithDestination(TDestination destination);
		public void Add(TConnection item);
		public void Clear();
		public bool Contains(TConnection item);
		public void CopyTo(TConnection[] array, int arrayIndex);
		public bool Remove(TConnection item);
		protected virtual void BeforeAdd(TConnection item);
		protected virtual void AfterAdd(TConnection item);
		protected virtual void BeforeRemove(TConnection item);
		protected virtual void AfterRemove(TConnection item);
		private void AddToDictionaries(TConnection item);
		private void RemoveFromDictionaries(TConnection item);
	}

	public class GraphConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, GraphElementCollection<TConnection>>, ICollection<TConnection> // TypeDefIndex: 58961
		where TConnection : IConnection<TSource, TDestination>, IGraphElement
	{
	}

	public interface IConnection<out TSource, out TDestination> // TypeDefIndex: 58962
	{
		// Properties
		TSource source { get; }
		TDestination destination { get; }
	}

	[DefaultMember("Item")]
	public interface IConnectionCollection<TConnection, TSource, TDestination> : ICollection<TConnection> // TypeDefIndex: 58963
		where TConnection : IConnection<TSource, TDestination>
	{
	}

	public class InvalidConnectionException : Exception // TypeDefIndex: 58964
	{
		// Constructors
		public InvalidConnectionException(); // 0x000000018B35BAB4-0x000000018B35BB08
		public InvalidConnectionException(string message); // 0x000000018B35BB08-0x000000018B35BB64
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ValueAttribute : Attribute // TypeDefIndex: 58965
	{
		// Constructors
		public ValueAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DisableAnnotationAttribute : Attribute // TypeDefIndex: 58966
	{
		// Fields
		[CompilerGenerated]
		private bool _disableIcon_k__BackingField; // 0x10
	
		// Constructors
		public DisableAnnotationAttribute(); // 0x00000001815EFCD0-0x00000001815EFCE0
	}

	public static class EditorTimeBinding // TypeDefIndex: 58968
	{
		// Fields
		public static Func<int> frameBinding; // 0x00
		public static Func<float> timeBinding; // 0x08
	
		// Properties
		public static int frame { get; } // 0x000000018B357228-0x000000018B3572C8 
		public static float time { get; } // 0x000000018B3572C8-0x000000018B357368 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58967
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018B36BC28-0x000000018B36BC8C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _.cctor_b__6_0(); // 0x000000018B36B490-0x000000018B36B498
			internal float _.cctor_b__6_1(); // 0x000000018B36B498-0x000000018B36B4A0
		}
	
		// Constructors
		static EditorTimeBinding(); // 0x000000018B3570E4-0x000000018B357228
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public sealed class IncludeInSettingsAttribute : Attribute // TypeDefIndex: 58969
	{
		// Fields
		[CompilerGenerated]
		private bool _include_k__BackingField; // 0x10
	
		// Properties
		private bool include { [CompilerGenerated] set; } // 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public IncludeInSettingsAttribute(bool include); // 0x0000000184D86130-0x0000000184D86140
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class InspectableAttribute : Attribute // TypeDefIndex: 58970
	{
		// Constructors
		public InspectableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorWideAttribute : Attribute // TypeDefIndex: 58971
	{
		// Fields
		[CompilerGenerated]
		private bool _toEdge_k__BackingField; // 0x10
	
		// Properties
		private bool toEdge { [CompilerGenerated] set; } // 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public InspectorWideAttribute(bool toEdge); // 0x0000000184D86130-0x0000000184D86140
	}

	public static class Ensure // TypeDefIndex: 58972
	{
		// Fields
		private static readonly EnsureThat instance; // 0x00
		[CompilerGenerated]
		private static bool _IsActive_k__BackingField; // 0x08
	
		// Properties
		public static bool IsActive { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B357430-0x000000018B357480 0x000000018B357480-0x000000018B3574D4
	
		// Constructors
		static Ensure(); // 0x0000000184D32510-0x0000000184D32580
	
		// Methods
		public static EnsureThat That(string paramName); // 0x0000000184727780-0x0000000184727800
		internal static void OnRuntimeMethodLoad(); // 0x0000000183FCE6A0-0x0000000183FCE770
	}

	public class EnsureThat // TypeDefIndex: 58973
	{
		// Fields
		internal string paramName; // 0x10
	
		// Constructors
		public EnsureThat(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void IsNotNull<T>([NoEnumeration] T value);
		public void IsNotNull(string value); // 0x000000018B357368-0x000000018B357430
		public void IsOfType<T>(T param, System.Type expectedType);
	}

	public static class ExceptionMessages // TypeDefIndex: 58974
	{
		// Fields
		[CompilerGenerated]
		private static readonly string _Common_IsNull_Failed_k__BackingField; // 0x00
		[CompilerGenerated]
		private static readonly string _Common_IsNotNull_Failed_k__BackingField; // 0x08
		[CompilerGenerated]
		private static readonly string _Booleans_IsTrueFailed_k__BackingField; // 0x10
		[CompilerGenerated]
		private static readonly string _Booleans_IsFalseFailed_k__BackingField; // 0x18
		[CompilerGenerated]
		private static readonly string _Collections_Any_Failed_k__BackingField; // 0x20
		[CompilerGenerated]
		private static readonly string _Collections_ContainsKey_Failed_k__BackingField; // 0x28
		[CompilerGenerated]
		private static readonly string _Collections_HasItemsFailed_k__BackingField; // 0x30
		[CompilerGenerated]
		private static readonly string _Collections_HasNoNullItemFailed_k__BackingField; // 0x38
		[CompilerGenerated]
		private static readonly string _Collections_SizeIs_Failed_k__BackingField; // 0x40
		[CompilerGenerated]
		private static readonly string _Comp_Is_Failed_k__BackingField; // 0x48
		[CompilerGenerated]
		private static readonly string _Comp_IsNot_Failed_k__BackingField; // 0x50
		[CompilerGenerated]
		private static readonly string _Comp_IsNotLt_k__BackingField; // 0x58
		[CompilerGenerated]
		private static readonly string _Comp_IsNotLte_k__BackingField; // 0x60
		[CompilerGenerated]
		private static readonly string _Comp_IsNotGt_k__BackingField; // 0x68
		[CompilerGenerated]
		private static readonly string _Comp_IsNotGte_k__BackingField; // 0x70
		[CompilerGenerated]
		private static readonly string _Comp_IsNotInRange_ToLow_k__BackingField; // 0x78
		[CompilerGenerated]
		private static readonly string _Comp_IsNotInRange_ToHigh_k__BackingField; // 0x80
		[CompilerGenerated]
		private static readonly string _Guids_IsNotEmpty_Failed_k__BackingField; // 0x88
		[CompilerGenerated]
		private static readonly string _Strings_IsEqualTo_Failed_k__BackingField; // 0x90
		[CompilerGenerated]
		private static readonly string _Strings_IsNotEqualTo_Failed_k__BackingField; // 0x98
		[CompilerGenerated]
		private static readonly string _Strings_SizeIs_Failed_k__BackingField; // 0xA0
		[CompilerGenerated]
		private static readonly string _Strings_IsNotNullOrWhiteSpace_Failed_k__BackingField; // 0xA8
		[CompilerGenerated]
		private static readonly string _Strings_IsNotNullOrEmpty_Failed_k__BackingField; // 0xB0
		[CompilerGenerated]
		private static readonly string _Strings_HasLengthBetween_Failed_ToShort_k__BackingField; // 0xB8
		[CompilerGenerated]
		private static readonly string _Strings_HasLengthBetween_Failed_ToLong_k__BackingField; // 0xC0
		[CompilerGenerated]
		private static readonly string _Strings_Matches_Failed_k__BackingField; // 0xC8
		[CompilerGenerated]
		private static readonly string _Strings_IsNotEmpty_Failed_k__BackingField; // 0xD0
		[CompilerGenerated]
		private static readonly string _Strings_IsGuid_Failed_k__BackingField; // 0xD8
		[CompilerGenerated]
		private static readonly string _Types_IsOfType_Failed_k__BackingField; // 0xE0
		[CompilerGenerated]
		private static readonly string _Reflection_HasAttribute_Failed_k__BackingField; // 0xE8
		[CompilerGenerated]
		private static readonly string _Reflection_HasConstructor_Failed_k__BackingField; // 0xF0
		[CompilerGenerated]
		private static readonly string _Reflection_HasPublicConstructor_Failed_k__BackingField; // 0xF8
		[CompilerGenerated]
		private static readonly string _ValueTypes_IsNotDefault_Failed_k__BackingField; // 0x100
	
		// Properties
		public static string Common_IsNotNull_Failed { [CompilerGenerated] get; } // 0x000000018B3581F8-0x000000018B358248 
		public static string Types_IsOfType_Failed { [CompilerGenerated] get; } // 0x000000018B358248-0x000000018B35829C 
	
		// Constructors
		static ExceptionMessages(); // 0x000000018B3579CC-0x000000018B3581F8
	}

	internal static class XString // TypeDefIndex: 58976
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58975
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, object> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B36B96C-0x000000018B36B9D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _Inject_b__1_0(string a); // 0x0000000184D88C30-0x0000000184D88C40
		}
	
		// Extension methods
		internal static string Inject(this string format, params string[] formattingArgs); // 0x000000018B36C530-0x000000018B36C66C
	}

	public struct EmptyEventArgs // TypeDefIndex: 58977
	{
	}

	public class InvalidConversionException : InvalidCastException // TypeDefIndex: 58978
	{
		// Constructors
		public InvalidConversionException(); // 0x000000018B35BB64-0x000000018B35BB6C
		public InvalidConversionException(string message); // 0x000000018A843454-0x000000018A843474
		public InvalidConversionException(string message, Exception innerException); // 0x000000018B35BB6C-0x000000018B35BB74
	}

	public class InvalidImplementationException : Exception // TypeDefIndex: 58979
	{
		// Constructors
		public InvalidImplementationException(string message); // 0x000000018B35BB74-0x000000018B35BBD0
	}

	public class UnexpectedEnumValueException<T> : Exception // TypeDefIndex: 58980
	{
		// Fields
		[CompilerGenerated]
		private T _Value_k__BackingField;
	
		// Properties
		private T Value { [CompilerGenerated] set; }
	
		// Constructors
		public UnexpectedEnumValueException(T value);
	}

	public abstract class Graph : IGraph // TypeDefIndex: 58982
	{
		// Fields
		[SerializeAs("elements")]
		private List<IGraphElement> _elements; // 0x10
		[CompilerGenerated]
		private readonly MergedGraphElementCollection _elements_k__BackingField; // 0x18
	
		// Properties
		[DoNotSerialize]
		public MergedGraphElementCollection elements { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
		public IEnumerable<ISerializationDependency> deserializationDependencies { get; } // 0x000000018B35B574-0x000000018B35B67C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58981
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IGraphElement, IEnumerable<ISerializationDependency>> __9__27_0; // 0x08
			public static Comparison<IGraphElement> __9__30_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B36BA98-0x000000018B36BAFC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal IEnumerable<ISerializationDependency> _get_deserializationDependencies_b__27_0(IGraphElement e); // 0x000000018B36B5A8-0x000000018B36B5C4
			internal int _OnAfterDependenciesDeserialized_b__30_0(IGraphElement a, IGraphElement b); // 0x000000018B36B2BC-0x000000018B36B300
		}
	
		// Methods
		public virtual void OnBeforeSerialize(); // 0x000000018B35B508-0x000000018B35B574
		public void OnAfterDeserialize(); // 0x000000018B35B4BC-0x000000018B35B508
		public virtual void OnAfterDependenciesDeserialized(); // 0x000000018B35AFD4-0x000000018B35B4BC
		public virtual void Dispose(); // 0x000000018B35AE88-0x000000018B35AFD4
	}

	public abstract class GraphElement<TGraph> : IGraphElement // TypeDefIndex: 58983
		where TGraph : class, IGraph
	{
		// Fields
		[CompilerGenerated]
		private Guid _guid_k__BackingField;
		[CompilerGenerated]
		private TGraph _graph_k__BackingField;
	
		// Properties
		[Serialize]
		public Guid guid { [CompilerGenerated] get; }
		[DoNotSerialize]
		public virtual int dependencyOrder { get; }
		[DoNotSerialize]
		public TGraph graph { [CompilerGenerated] get; }
		public virtual IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Constructors
		protected GraphElement();
	
		// Methods
		public virtual void Dispose();
		public virtual bool HandleDependencies();
		public override string ToString();
	}

	public sealed class GraphElementCollection<TElement> : GuidCollection<TElement>, IKeyedCollection<Guid, TElement> // TypeDefIndex: 58984
		where TElement : IGraphElement
	{
		// Properties
		TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.this[Guid key] { get => default; }
	
		// Methods
		bool IKeyedCollection<Guid, TElement>.Contains(Guid key);
	}

	public abstract class GraphPointer // TypeDefIndex: 58985
	{
		// Fields
		[CompilerGenerated]
		private IGraphRoot _root_k__BackingField; // 0x10
		[CompilerGenerated]
		private GameObject _gameObject_k__BackingField; // 0x18
		protected readonly List<IGraphParent> parentStack; // 0x20
		protected readonly List<IGraphParentElement> parentElementStack; // 0x28
		protected readonly List<IGraph> graphStack; // 0x30
		protected readonly List<IGraphData> dataStack; // 0x38
		protected readonly List<IGraphDebugData> debugDataStack; // 0x40
	
		// Properties
		public IGraphRoot root { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public UnityEngine.Object rootObject { get; } // 0x000000018B359E88-0x000000018B359EC4 
		public GameObject gameObject { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public GameObject self { get; } // 0x000000018385B100-0x000000018385B110 
		public UnityEngine.Object serializedObject { get; } // 0x000000018B359EC4-0x000000018B359FC8 
		public int depth { get; } // 0x000000018B359A0C-0x000000018B359A4C 
		public bool isRoot { get; } // 0x000000018B359A7C-0x000000018B359A94 
		public bool isChild { get; } // 0x000000018B359A64-0x000000018B359A7C 
		public IGraphParent parent { get; } // 0x000000018B359DE4-0x000000018B359E40 
		public IGraphParentElement parentElement { get; } // 0x000000018B359D80-0x000000018B359DE4 
		public IGraph rootGraph { get; } // 0x000000018B359E40-0x000000018B359E88 
		public bool hasDebugData { get; } // 0x000000018B359A4C-0x000000018B359A64 
		protected IGraphDebugData _debugData { get; } // 0x000000018B359990-0x000000018B3599EC 
		public IGraphDebugData debugData { get; } // 0x000000018B3599EC-0x000000018B359A0C 
		public bool isValid { get; } // 0x000000018B359A94-0x000000018B359D80 
	
		// Constructors
		internal GraphPointer(); // 0x000000018B3597EC-0x000000018B359990
	
		// Methods
		public abstract GraphReference AsReference();
		public virtual void CopyFrom(GraphPointer other); // 0x000000018B358AB4-0x000000018B3591EC
		public void EnsureChild(); // 0x000000018B3592D4-0x000000018B359350
		public void EnsureDebugDataAvailable(); // 0x000000018B359350-0x000000018B3593CC
		public T GetElementDebugData<T>(IGraphElementWithDebugData element);
		protected void ExitParentElement(); // 0x000000018B3593CC-0x000000018B359574
		public bool InstanceEquals(GraphPointer other); // 0x000000018B359574-0x000000018B359674
		public bool DefinitionEquals(GraphPointer other); // 0x000000018B3591EC-0x000000018B3592D4
		public int ComputeHashCode(); // 0x000000018B358990-0x000000018B358AB4
		public override string ToString(); // 0x000000018B359674-0x000000018B3597EC
	}

	public sealed class GraphPointerException : Exception // TypeDefIndex: 58986
	{
		// Fields
		[CompilerGenerated]
		private readonly GraphPointer _pointer_k__BackingField; // 0x90
	
		// Constructors
		public GraphPointerException(string message, GraphPointer pointer); // 0x000000018B3588CC-0x000000018B358990
	}

	public sealed class GraphReference : GraphPointer // TypeDefIndex: 58987
	{
		// Fields
		[DoNotSerialize]
		private int hashCode; // 0x48
		private static readonly Dictionary<int, List<GraphReference>> internPool; // 0x00
	
		// Constructors
		static GraphReference(); // 0x000000018B35AAF8-0x000000018B35ABD0
		private GraphReference(); // 0x000000018B35ABD0-0x000000018B35ABD8
	
		// Methods
		private static GraphReference New(GraphPointer model); // 0x000000018B35A9D8-0x000000018B35AA40
		public override void CopyFrom(GraphPointer other); // 0x000000018B35A014-0x000000018B35A07C
		public GraphReference Clone(); // 0x000000018B359FC8-0x000000018B35A014
		public override GraphReference AsReference(); // 0x000000018464E630-0x000000018464E640
		public GraphStack ToStackPooled(); // 0x000000018B35AAF0-0x000000018B35AAF8
		public override bool Equals(object obj); // 0x000000018B35A07C-0x000000018B35A0D8
		private void Hash(); // 0x000000018B35A6E8-0x000000018B35A704
		public override int GetHashCode(); // 0x0000000184D863D0-0x0000000184D863E0
		public GraphReference ParentReference(bool ensureValid); // 0x000000018B35AA40-0x000000018B35AAF0
		public static GraphReference Intern(GraphPointer pointer); // 0x000000018B35A704-0x000000018B35A9D8
		public static void FreeInvalidInterns(); // 0x000000018B35A0D8-0x000000018B35A6E8
	}

	public static class GraphsExceptionUtility // TypeDefIndex: 58988
	{
		// Extension methods
		public static void SetException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex); // 0x000000018B35BA0C-0x000000018B35BAB4
		public static void HandleException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex); // 0x000000018B35B67C-0x000000018B35B848
		private static bool HandledIn(this Exception ex, GraphReference reference); // 0x000000018B35B848-0x000000018B35BA0C
	}

	public sealed class GraphStack : GraphPointer, IPoolable, IDisposable // TypeDefIndex: 58990
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58989
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GraphStack> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B36BA34-0x000000018B36BA98
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal GraphStack _New_b__3_0(); // 0x000000018B36B26C-0x000000018B36B2BC
		}
	
		// Constructors
		private GraphStack(); // 0x000000018B35ABD0-0x000000018B35ABD8
	
		// Methods
		internal static GraphStack New(GraphPointer model); // 0x000000018B35AC34-0x000000018B35AD64
		public void Dispose(); // 0x000000018B35ABE0-0x000000018B35AC34
		void IPoolable.New(); // 0x00000001841E1670-0x00000001841E1680
		void IPoolable.Free(); // 0x000000018B35ADB0-0x000000018B35AE88
		public override GraphReference AsReference(); // 0x000000018B35ABD8-0x000000018B35ABE0
		public GraphReference ToReference(); // 0x000000018B35AD64-0x000000018B35ADB0
	}

	public interface IGraph : IDisposable, ISerializationDepender // TypeDefIndex: 58991
	{
		// Properties
		MergedGraphElementCollection elements { get; }
	}

	public interface IGraphData // TypeDefIndex: 58992
	{
	}

	public interface IGraphDebugData // TypeDefIndex: 58993
	{
		// Methods
		IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element);
	}

	public interface IGraphElement : IDisposable, IIdentifiable // TypeDefIndex: 58994
	{
		// Properties
		int dependencyOrder { get; }
		Guid guid { get; }
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		bool HandleDependencies();
	}

	public interface IGraphElementDebugData // TypeDefIndex: 58995
	{
		// Properties
		Exception runtimeException { set; }
	}

	public interface IGraphElementWithDebugData : IGraphElement // TypeDefIndex: 58996
	{
	}

	public interface IGraphParent // TypeDefIndex: 58997
	{
		// Properties
		IGraph childGraph { get; }
		bool isSerializationRoot { get; }
		UnityEngine.Object serializedObject { get; }
	}

	public interface IGraphParentElement : IGraphElement, IGraphParent // TypeDefIndex: 58998
	{
	}

	public interface IGraphRoot : IGraphParent // TypeDefIndex: 58999
	{
	}

	public sealed class MergedGraphElementCollection : MergedKeyedCollection<Guid, IGraphElement> // TypeDefIndex: 59000
	{
	}

	public static class PlatformUtility // TypeDefIndex: 59001
	{
		// Fields
		public static readonly bool supportsJit; // 0x00
	
		// Constructors
		static PlatformUtility(); // 0x0000000184D79D90-0x0000000184D79DD0
	
		// Methods
		private static bool CheckJitSupport(); // 0x00000001812081B0-0x0000000181208610
	}

	public static class GenericPool<T> // TypeDefIndex: 59002
		where T : class, IPoolable
	{
		// Fields
		private static readonly object @lock;
		private static readonly Stack<T> free;
		private static readonly HashSet<T> busy;
	
		// Constructors
		static GenericPool();
	
		// Methods
		public static T New(Func<T> constructor);
		public static void Free(T item);
	}

	public interface IPoolable // TypeDefIndex: 59003
	{
		// Methods
		void New();
		void Free();
	}

	public static class ListPool<T> // TypeDefIndex: 59004
	{
		// Fields
		private static readonly object @lock;
		private static readonly Stack<List<T>> free;
		private static readonly HashSet<List<T>> busy;
	
		// Constructors
		static ListPool();
	
		// Methods
		public static List<T> New();
		public static void Free(List<T> list);
	}

	public static class XListPool // TypeDefIndex: 59005
	{
		// Extension methods
		public static void Free<T>(this List<T> list);
	}

	public class ProfiledSegment // TypeDefIndex: 59006
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private Stopwatch _stopwatch_k__BackingField; // 0x18
		[CompilerGenerated]
		private ProfiledSegment _parent_k__BackingField; // 0x20
		[CompilerGenerated]
		private ProfiledSegmentCollection _children_k__BackingField; // 0x28
	
		// Properties
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		private Stopwatch stopwatch { [CompilerGenerated] set; } // 0x0000000185392C40-0x0000000185392C50
		private ProfiledSegment parent { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
		private ProfiledSegmentCollection children { [CompilerGenerated] set; } // 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		public ProfiledSegment(ProfiledSegment parent, string name); // 0x000000018B360B80-0x000000018B360C38
	}

	public class ProfiledSegmentCollection : KeyedCollection<string, ProfiledSegment> // TypeDefIndex: 59007
	{
		// Constructors
		public ProfiledSegmentCollection(); // 0x000000018B360B44-0x000000018B360B80
	
		// Methods
		protected override string GetKeyForItem(ProfiledSegment item); // 0x0000000186C08920-0x0000000186C08938
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 59008
	{
		// Constructors
		public ProfilingScope(string name); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class ProfilingUtility // TypeDefIndex: 59009
	{
		// Fields
		private static readonly object @lock; // 0x00
		[CompilerGenerated]
		private static ProfiledSegment _rootSegment_k__BackingField; // 0x08
		[CompilerGenerated]
		private static ProfiledSegment _currentSegment_k__BackingField; // 0x10
	
		// Properties
		private static ProfiledSegment rootSegment { [CompilerGenerated] set; } // 0x000000018B360DF0-0x000000018B360E50
		public static ProfiledSegment currentSegment { [CompilerGenerated] set; } // 0x000000018B360D90-0x000000018B360DF0
	
		// Constructors
		static ProfilingUtility(); // 0x000000018B360C38-0x000000018B360D90
	
		// Methods
		public static ProfilingScope SampleBlock(string name); // 0x00000001812081B0-0x0000000181208610
	}

	public enum ActionDirection // TypeDefIndex: 59010
	{
		Any = 0,
		Get = 1,
		Set = 2
	}

	public static class AttributeUtility // TypeDefIndex: 59012
	{
		// Fields
		private static readonly Dictionary<object, AttributeCache> optimizedCaches; // 0x00
	
		// Nested types
		private class AttributeCache // TypeDefIndex: 59011
		{
			// Fields
			[CompilerGenerated]
			private readonly List<Attribute> _inheritedAttributes_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly List<Attribute> _definedAttributes_k__BackingField; // 0x18
	
			// Properties
			public List<Attribute> inheritedAttributes { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			public List<Attribute> definedAttributes { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			public AttributeCache(MemberInfo element); // 0x000000018B352A74-0x000000018B352F6C
	
			// Methods
			private void Cache(Attribute[] attributeObjects, List<Attribute> cache); // 0x000000018B352888-0x000000018B352904
			private bool HasAttribute(System.Type attributeType, List<Attribute> cache); // 0x000000018B3529E0-0x000000018B352A74
			private Attribute GetAttribute(System.Type attributeType, List<Attribute> cache); // 0x000000018B352920-0x000000018B3529C4
			public bool HasAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x0234C5FD */); // 0x000000018B3529C4-0x000000018B3529E0
			public Attribute GetAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x0234C5FE */); // 0x000000018B352904-0x000000018B352920
			public bool HasAttribute<TAttribute>(bool inherit = true /* Metadata: 0x0234C5FF */)
				where TAttribute : Attribute;
			public TAttribute GetAttribute<TAttribute>(bool inherit = true /* Metadata: 0x0234C600 */)
				where TAttribute : Attribute;
		}
	
		// Constructors
		static AttributeUtility(); // 0x000000018B3531B4-0x000000018B353240
	
		// Methods
		private static AttributeCache GetAttributeCache(MemberInfo element); // 0x000000018B352F6C-0x000000018B3531B4
	
		// Extension methods
		internal static IEnumerable<T> GetAttributeOfEnumMember<T>(this Enum enumVal)
			where T : Attribute;
		public static bool HasAttribute<TAttribute>(this MemberInfo element, bool inherit = true /* Metadata: 0x0234C5FB */)
			where TAttribute : Attribute;
		public static TAttribute GetAttribute<TAttribute>(this MemberInfo element, bool inherit = true /* Metadata: 0x0234C5FC */)
			where TAttribute : Attribute;
	}

	public static class ConversionUtility // TypeDefIndex: 59019
	{
		// Fields
		private static readonly Dictionary<ConversionQuery, ConversionType> conversionTypesCache; // 0x00
		private static readonly Dictionary<ConversionQuery, MethodInfo[]> userConversionMethodsCache; // 0x08
		private static readonly Dictionary<System.Type, HashSet<System.Type>> implicitNumericConversions; // 0x10
		private static readonly Dictionary<System.Type, HashSet<System.Type>> explicitNumericConversions; // 0x18
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 59013
		{
			Impossible = 0,
			Identity = 1,
			Upcast = 2,
			Downcast = 3,
			NumericImplicit = 4,
			NumericExplicit = 5,
			UserDefinedImplicit = 6,
			UserDefinedExplicit = 7,
			UserDefinedThenNumericImplicit = 8,
			UserDefinedThenNumericExplicit = 9,
			UnityHierarchy = 10,
			EnumerableToArray = 11,
			EnumerableToList = 12,
			ToString = 13
		}
	
		private struct ConversionQuery : IEquatable<ConversionQuery> // TypeDefIndex: 59014
		{
			// Fields
			public readonly System.Type source; // 0x00
			public readonly System.Type destination; // 0x08
	
			// Constructors
			public ConversionQuery(System.Type source, System.Type destination); // 0x00000001839CF630-0x00000001839CF660
	
			// Methods
			public bool Equals(ConversionQuery other); // 0x000000018B35363C-0x000000018B3536AC
			public override bool Equals(object obj); // 0x000000018B3536AC-0x000000018B35371C
			public override int GetHashCode(); // 0x000000018B35371C-0x000000018B35375C
		}
	
		private struct ConversionQueryComparer : IEqualityComparer<ConversionQuery> // TypeDefIndex: 59015
		{
			// Methods
			public bool Equals(ConversionQuery x, ConversionQuery y); // 0x000000018B353604-0x000000018B353628
			public int GetHashCode(ConversionQuery obj); // 0x000000018B353628-0x000000018B35363C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 59016
		{
			// Fields
			public System.Type source; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindUserDefinedConversionMethods_b__2(MethodInfo m); // 0x000000018B36B5C4-0x000000018B36B66C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59017
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__11_0; // 0x08
			public static Func<MethodInfo, bool> __9__11_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B36BCF0-0x000000018B36BD54
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindUserDefinedConversionMethods_b__11_0(MethodInfo m); // 0x000000018B36B144-0x000000018B36B190
			internal bool _FindUserDefinedConversionMethods_b__11_1(MethodInfo m); // 0x000000018B36B190-0x000000018B36B1DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 59018
		{
			// Fields
			public System.Type destination; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetUserDefinedConversionType_b__0(MethodInfo m); // 0x000000018B36B66C-0x000000018B36B6E0
			internal bool _GetUserDefinedConversionType_b__1(MethodInfo m); // 0x000000018B36B6E0-0x000000018B36B75C
			internal bool _GetUserDefinedConversionType_b__2(MethodInfo m); // 0x000000018B36B75C-0x000000018B36B7D8
		}
	
		// Constructors
		static ConversionUtility(); // 0x000000018B355574-0x000000018B356F80
	
		// Methods
		private static bool RespectsIdentity(System.Type source, System.Type destination); // 0x000000018B35517C-0x000000018B3551D0
		private static bool IsUpcast(System.Type source, System.Type destination); // 0x000000018AD1AECC-0x000000018AD1AEEC
		private static bool IsDowncast(System.Type source, System.Type destination); // 0x000000018AC76A90-0x000000018AC76AB4
		public static bool HasImplicitNumericConversion(System.Type source, System.Type destination); // 0x000000018B354DD0-0x000000018B354EB4
		public static bool HasExplicitNumericConversion(System.Type source, System.Type destination); // 0x000000018B354CEC-0x000000018B354DD0
		public static bool HasNumericConversion(System.Type source, System.Type destination); // 0x000000018B354EB4-0x000000018B354F28
		private static IEnumerable<MethodInfo> FindUserDefinedConversionMethods(ConversionQuery query); // 0x000000018B354190-0x000000018B354438
		private static MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination); // 0x000000018B35462C-0x000000018B3547AC
		private static ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination); // 0x000000018B3547AC-0x000000018B354AF4
		private static bool HasEnumerableToArrayConversion(System.Type source, System.Type destination); // 0x000000018B354AF4-0x000000018B354BD8
		private static bool HasEnumerableToListConversion(System.Type source, System.Type destination); // 0x000000018B354BD8-0x000000018B354CEC
		private static bool HasUnityHierarchyConversion(System.Type source, System.Type destination); // 0x000000018B354F28-0x000000018B35504C
		private static bool IsValidConversion(ConversionType conversionType, bool guaranteed); // 0x000000018B35510C-0x000000018B355120
		public static bool CanConvert(object value, System.Type type, bool guaranteed); // 0x000000018B3537C8-0x000000018B353834
		public static bool CanConvert(System.Type source, System.Type destination, bool guaranteed); // 0x000000018B35375C-0x000000018B3537C8
		public static object Convert(object value, System.Type type); // 0x000000018B353834-0x000000018B353898
		public static ConversionType GetRequiredConversion(System.Type source, System.Type destination); // 0x000000018B354500-0x000000018B35462C
		private static ConversionType DetermineConversionType(ConversionQuery query); // 0x000000018B353C8C-0x000000018B353ECC
		public static ConversionType GetRequiredConversion(object value, System.Type type); // 0x000000018B354438-0x000000018B354500
		private static object NumericConversion(object value, System.Type type); // 0x000000018B355120-0x000000018B35517C
		private static object UserDefinedConversion(ConversionType conversion, object value, System.Type type); // 0x000000018B3553C0-0x000000018B355574
		private static object EnumerableToArrayConversion(object value, System.Type arrayType); // 0x000000018B353ECC-0x000000018B354004
		private static object EnumerableToListConversion(object value, System.Type listType); // 0x000000018B354004-0x000000018B354190
		private static object UnityHierarchyConversion(object value, System.Type type); // 0x000000018B3551D0-0x000000018B3553C0
		private static object Convert(object value, System.Type type, ConversionType conversionType); // 0x000000018B353898-0x000000018B353C8C
	
		// Extension methods
		public static bool IsConvertibleTo(this System.Type source, System.Type destination, bool guaranteed); // 0x000000018B3550AC-0x000000018B35510C
		public static bool IsConvertibleTo(this object source, System.Type type, bool guaranteed); // 0x000000018B35504C-0x000000018B3550AC
	}

	public struct LooseAssemblyName // TypeDefIndex: 59020
	{
		// Fields
		public readonly string name; // 0x00
	
		// Constructors
		public LooseAssemblyName(string name); // 0x000000018B35C4DC-0x000000018B35C548
	
		// Methods
		public override bool Equals(object obj); // 0x000000018B35C43C-0x000000018B35C4A0
		public override int GetHashCode(); // 0x000000018B35C4A0-0x000000018B35C4DC
		public override string ToString(); // 0x0000000182B76770-0x0000000182B76780
	}

	public static class MemberUtility // TypeDefIndex: 59022
	{
		// Fields
		private static readonly Lazy<ExtensionMethodCache> ExtensionMethodsCache; // 0x00
		private static readonly Lazy<Dictionary<System.Type, MethodInfo[]>> InheritedExtensionMethodsCache; // 0x08
		private static readonly Lazy<HashSet<MethodInfo>> GenericExtensionMethods; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59021
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018B36B908-0x000000018B36B96C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ExtensionMethodCache _.cctor_b__0_0(); // 0x000000018B36B380-0x000000018B36B3D0
			internal Dictionary<System.Type, MethodInfo[]> _.cctor_b__0_1(); // 0x000000018B36B3D0-0x000000018B36B430
			internal HashSet<MethodInfo> _.cctor_b__0_2(); // 0x000000018B36B430-0x000000018B36B490
		}
	
		// Constructors
		static MemberUtility(); // 0x000000018B35CCB0-0x000000018B35CF44
	
		// Extension methods
		public static bool IsUserDefinedConversion(this MethodInfo method); // 0x000000018B35CC10-0x000000018B35CCB0
		public static bool IsExtension(this MethodInfo methodInfo); // 0x000000018B35C9F4-0x000000018B35CA48
		public static bool IsStatic(this PropertyInfo propertyInfo); // 0x000000018B35CA48-0x000000018B35CAB0
		public static bool IsStatic(this MemberInfo memberInfo); // 0x000000018B35CAB0-0x000000018B35CC10
		public static bool CanWrite(this System.Reflection.FieldInfo fieldInfo); // 0x000000018B35C9BC-0x000000018B35C9F4
	}

	internal class ExtensionMethodCache // TypeDefIndex: 59024
	{
		// Fields
		internal readonly MethodInfo[] Cache; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59023
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__0_0; // 0x08
			public static Func<System.Type, IEnumerable<MethodInfo>> __9__0_1; // 0x10
			public static Func<MethodInfo, bool> __9__0_2; // 0x18
	
			// Constructors
			static __c(); // 0x000000018B36BAFC-0x000000018B36BB60
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _.ctor_b__0_0(System.Type type); // 0x000000018B36B4A0-0x000000018B36B514
			internal IEnumerable<MethodInfo> _.ctor_b__0_1(System.Type type); // 0x000000018B36B514-0x000000018B36B534
			internal bool _.ctor_b__0_2(MethodInfo method); // 0x000000018B36B534-0x000000018B36B580
		}
	
		// Constructors
		internal ExtensionMethodCache(); // 0x000000018B35829C-0x000000018B3585C8
	}

	public sealed class Namespace // TypeDefIndex: 59026
	{
		// Fields
		[CompilerGenerated]
		private readonly Namespace _Root_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly Namespace _Parent_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly string _FullName_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly string _Name_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly bool _IsRoot_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly bool _IsGlobal_k__BackingField; // 0x31
		private static readonly Collection collection; // 0x00
		[CompilerGenerated]
		private static readonly Namespace _Global_k__BackingField; // 0x08
	
		// Properties
		public string FullName { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public static Namespace Global { [CompilerGenerated] get; } // 0x000000018B35D57C-0x000000018B35D5CC 
	
		// Nested types
		private class Collection : KeyedCollection<string, Namespace>, IKeyedCollection<string, Namespace> // TypeDefIndex: 59025
		{
			// Properties
			Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.this[string key] { get => default; } // 0x000000018B353580-0x000000018B3535C8 
	
			// Constructors
			public Collection(); // 0x000000018B3535C8-0x000000018B353604
	
			// Methods
			protected override string GetKeyForItem(Namespace item); // 0x0000000189B24654-0x0000000189B2466C
			public new bool TryGetValue(string key, out Namespace value); // 0x000000018B3534C0-0x000000018B353538
			bool IKeyedCollection<string, Namespace>.Contains(string key); // 0x000000018B353538-0x000000018B353580
		}
	
		// Constructors
		private Namespace(string fullName); // 0x000000018B35D438-0x000000018B35D57C
		static Namespace(); // 0x000000018B35D370-0x000000018B35D438
	
		// Methods
		public override int GetHashCode(); // 0x000000018B35D348-0x000000018B35D370
		public override string ToString(); // 0x0000000184D862C0-0x0000000184D862D0
		public static Namespace FromFullName(string fullName); // 0x000000018B35D254-0x000000018B35D348
		public override bool Equals(object obj); // 0x000000018B35D1C8-0x000000018B35D254
		public static implicit operator Namespace(string fullName); // 0x000000018B35D5CC-0x000000018B35D618
		public static bool operator ==(Namespace a, Namespace b); // 0x000000018A7BED8C-0x000000018A7BEDB4
	}

	public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 59027; 0x00000000-0x00000000

	public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 59028; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 59029; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 59030; 0x00000000-0x00000000

	public abstract class InstanceActionInvokerBase<TTarget> : InstanceInvokerBase<TTarget> // TypeDefIndex: 59031
	{
		// Constructors
		protected InstanceActionInvokerBase(MethodInfo methodInfo);
	}

	public sealed class InstanceActionInvoker<TTarget> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 59032
	{
		// Fields
		private Action<TTarget> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 59033
	{
		// Fields
		private Action<TTarget, TParam0> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		private object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 59034
	{
		// Fields
		private Action<TTarget, TParam0, TParam1> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 59035
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 59036
	{
		// Fields
		private Unity.VisualScripting.Action<TTarget, TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 59037
	{
		// Fields
		private Unity.VisualScripting.Action<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public class InstanceFieldAccessor<TTarget, TField> : IOptimizedAccessor // TypeDefIndex: 59038
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TTarget, TField> getter;
		private Action<TTarget, TField> setter;
	
		// Constructors
		public InstanceFieldAccessor(System.Reflection.FieldInfo fieldInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
		[CompilerGenerated]
		private TField _Compile_b__4_0(TTarget instance);
		[CompilerGenerated]
		private void _Compile_b__4_1(TTarget instance, TField value);
	}

	public abstract class InstanceFunctionInvokerBase<TTarget, TResult> : InstanceInvokerBase<TTarget> // TypeDefIndex: 59039
	{
		// Constructors
		protected InstanceFunctionInvokerBase(MethodInfo methodInfo);
	}

	public sealed class InstanceFunctionInvoker<TTarget, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 59040
	{
		// Fields
		private Func<TTarget, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 59041
	{
		// Fields
		private Func<TTarget, TParam0, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		public object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 59042
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 59043
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 59044
	{
		// Fields
		private Unity.VisualScripting.Func<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 59045
	{
		// Fields
		private Unity.VisualScripting.Func<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public abstract class InstanceInvokerBase<TTarget> : InvokerBase // TypeDefIndex: 59046
	{
		// Constructors
		protected InstanceInvokerBase(MethodInfo methodInfo);
	
		// Methods
		protected sealed override void CompileExpression();
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target);
	}

	public class InstancePropertyAccessor<TTarget, TProperty> : IOptimizedAccessor // TypeDefIndex: 59047
	{
		// Fields
		private readonly PropertyInfo propertyInfo;
		private Func<TTarget, TProperty> getter;
		private Action<TTarget, TProperty> setter;
	
		// Constructors
		public InstancePropertyAccessor(PropertyInfo propertyInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
	}

	public abstract class InvokerBase : IOptimizedInvoker // TypeDefIndex: 59048
	{
		// Fields
		protected readonly System.Type targetType; // 0x10
		protected readonly MethodInfo methodInfo; // 0x18
	
		// Constructors
		protected InvokerBase(MethodInfo methodInfo); // 0x000000018B35BECC-0x000000018B35BF9C
	
		// Methods
		protected void VerifyArgument<TParam>(MethodInfo methodInfo, int argIndex, object arg);
		public void Compile(); // 0x000000018B35BBD0-0x000000018B35BC20
		protected ParameterExpression[] GetParameterExpressions(); // 0x000000018B35BC20-0x000000018B35BE80
		protected abstract System.Type[] GetParameterTypes();
		public virtual object Invoke(object target, object arg0); // 0x000000018B35BE80-0x000000018B35BECC
		protected abstract void CompileExpression();
		protected abstract void CreateDelegate();
		protected abstract void VerifyTarget(object target);
	}

	public interface IOptimizedAccessor // TypeDefIndex: 59049
	{
		// Methods
		void Compile();
		object GetValue(object target);
		void SetValue(object target, object value);
	}

	public interface IOptimizedInvoker // TypeDefIndex: 59050
	{
		// Methods
		void Compile();
		object Invoke(object target, object arg0);
	}

	public static class OptimizedReflection // TypeDefIndex: 59052
	{
		// Fields
		private static readonly Dictionary<System.Reflection.FieldInfo, IOptimizedAccessor> fieldAccessors; // 0x00
		private static readonly Dictionary<PropertyInfo, IOptimizedAccessor> propertyAccessors; // 0x08
		private static readonly Dictionary<MethodInfo, IOptimizedInvoker> methodInvokers; // 0x10
		public static readonly bool jitAvailable; // 0x18
		private static bool _useJitIfAvailable; // 0x19
		[CompilerGenerated]
		private static bool _safeMode_k__BackingField; // 0x1A
	
		// Properties
		internal static bool useJit { get; } // 0x000000018B360A68-0x000000018B360AF0 
		public static bool useJitIfAvailable { get; } // 0x000000018B360A18-0x000000018B360A68 
		public static bool safeMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B3609C8-0x000000018B360A18 0x000000018B360AF0-0x000000018B360B44
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59051
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, bool> __9__39_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B36BC8C-0x000000018B36BCF0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _SupportsOptimization_b__39_0(ParameterInfo parameter); // 0x000000018B36B358-0x000000018B36B380
		}
	
		// Constructors
		static OptimizedReflection(); // 0x0000000184A2CBC0-0x0000000184A2CD80
	
		// Methods
		internal static void OnRuntimeMethodLoad(); // 0x0000000183FCE770-0x0000000183FCE840
		internal static void VerifyStaticTarget(System.Type targetType, object target); // 0x000000018B360764-0x000000018B3607B8
		internal static void VerifyInstanceTarget<TTArget>(object target);
		private static void VerifyTarget(System.Type targetType, object target, bool @static); // 0x000000018B3607B8-0x000000018B3609C8
		private static bool SupportsOptimization(MemberInfo memberInfo); // 0x000000018B360498-0x000000018B360510
		private static IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo); // 0x000000018B35D618-0x000000018B35DAC8
		private static IOptimizedAccessor GetPropertyAccessor(PropertyInfo propertyInfo); // 0x000000018B35FD80-0x000000018B360258
		private static IOptimizedInvoker GetMethodInvoker(MethodInfo methodInfo); // 0x000000018B35DAC8-0x000000018B35FD80
	
		// Extension methods
		public static IOptimizedAccessor Prewarm(this System.Reflection.FieldInfo fieldInfo); // 0x000000018B3602CC-0x000000018B360318
		public static void SetValueOptimized(this System.Reflection.FieldInfo fieldInfo, object target, object value); // 0x000000018B3603B0-0x000000018B360424
		public static bool SupportsOptimization(this System.Reflection.FieldInfo fieldInfo); // 0x000000018B36071C-0x000000018B360764
		public static IOptimizedAccessor Prewarm(this PropertyInfo propertyInfo); // 0x000000018B360318-0x000000018B360364
		public static void SetValueOptimized(this PropertyInfo propertyInfo, object target, object value); // 0x000000018B360424-0x000000018B360498
		public static bool SupportsOptimization(this PropertyInfo propertyInfo); // 0x000000018B3606D4-0x000000018B36071C
		public static IOptimizedInvoker Prewarm(this MethodInfo methodInfo); // 0x000000018B360364-0x000000018B3603B0
		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0); // 0x000000018B360258-0x000000018B3602CC
		public static bool SupportsOptimization(this MethodInfo methodInfo); // 0x000000018B360510-0x000000018B3606D4
	}

	public sealed class ReflectionFieldAccessor : IOptimizedAccessor // TypeDefIndex: 59053
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo; // 0x10
	
		// Constructors
		public ReflectionFieldAccessor(System.Reflection.FieldInfo fieldInfo); // 0x000000018B362078-0x000000018B36212C
	
		// Methods
		public void Compile(); // 0x00000001841E1670-0x00000001841E1680
		public object GetValue(object target); // 0x0000000188B984D4-0x0000000188B984F8
		public void SetValue(object target, object value); // 0x0000000187C27D38-0x0000000187C27D58
	}

	public class ReflectionInvoker : IOptimizedInvoker // TypeDefIndex: 59054
	{
		// Fields
		private readonly MethodInfo methodInfo; // 0x10
		private static readonly object[] EmptyObjects; // 0x00
	
		// Constructors
		public ReflectionInvoker(MethodInfo methodInfo); // 0x000000018B362230-0x000000018B3622E4
		static ReflectionInvoker(); // 0x000000018B3621CC-0x000000018B362230
	
		// Methods
		public void Compile(); // 0x00000001841E1670-0x00000001841E1680
		public object Invoke(object target, object arg0); // 0x000000018B36212C-0x000000018B3621CC
	}

	public sealed class ReflectionPropertyAccessor : IOptimizedAccessor // TypeDefIndex: 59055
	{
		// Fields
		private readonly PropertyInfo propertyInfo; // 0x10
	
		// Constructors
		public ReflectionPropertyAccessor(PropertyInfo propertyInfo); // 0x000000018B3622E4-0x000000018B362398
	
		// Methods
		public void Compile(); // 0x00000001841E1670-0x00000001841E1680
		public object GetValue(object target); // 0x0000000188B95960-0x0000000188B95984
		public void SetValue(object target, object value); // 0x0000000189171000-0x0000000189171028
	}

	public abstract class StaticActionInvokerBase : StaticInvokerBase // TypeDefIndex: 59056
	{
		// Constructors
		protected StaticActionInvokerBase(MethodInfo methodInfo); // 0x00000001892E798C-0x00000001892E7994
	}

	public sealed class StaticActionInvoker : StaticActionInvokerBase // TypeDefIndex: 59057
	{
		// Fields
		private Action invoke; // 0x20
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo); // 0x00000001892E798C-0x00000001892E7994
	
		// Methods
		protected override System.Type[] GetParameterTypes(); // 0x000000018B367890-0x000000018B3678E0
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions); // 0x000000018B367774-0x000000018B367814
		protected override void CreateDelegate(); // 0x000000018B367814-0x000000018B367890
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(); // 0x000000018B3678E0-0x000000018B367988
	}

	public sealed class StaticActionInvoker<TParam0> : StaticActionInvokerBase // TypeDefIndex: 59058
	{
		// Fields
		private Action<TParam0> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		private object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1> : StaticActionInvokerBase // TypeDefIndex: 59059
	{
		// Fields
		private Action<TParam0, TParam1> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2> : StaticActionInvokerBase // TypeDefIndex: 59060
	{
		// Fields
		private Action<TParam0, TParam1, TParam2> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : StaticActionInvokerBase // TypeDefIndex: 59061
	{
		// Fields
		private Action<TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : StaticActionInvokerBase // TypeDefIndex: 59062
	{
		// Fields
		private Unity.VisualScripting.Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
	}

	public class StaticFieldAccessor<TField> : IOptimizedAccessor // TypeDefIndex: 59064
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TField> getter;
		private Action<TField> setter;
		private System.Type targetType;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 59063
		{
			// Fields
			public TField constant;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal TField _Compile_b__2();
		}
	
		// Constructors
		public StaticFieldAccessor(System.Reflection.FieldInfo fieldInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
		[CompilerGenerated]
		private TField _Compile_b__5_0();
		[CompilerGenerated]
		private void _Compile_b__5_1(TField value);
	}

	public abstract class StaticFunctionInvokerBase<TResult> : StaticInvokerBase // TypeDefIndex: 59065
	{
		// Constructors
		protected StaticFunctionInvokerBase(MethodInfo methodInfo);
	}

	public sealed class StaticFunctionInvoker<TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 59066
	{
		// Fields
		private Func<TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0();
	}

	public sealed class StaticFunctionInvoker<TParam0, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 59067
	{
		// Fields
		private Func<TParam0, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		public object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 59068
	{
		// Fields
		private Func<TParam0, TParam1, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 59069
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 59070
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 59071
	{
		// Fields
		private Unity.VisualScripting.Func<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
	}

	public abstract class StaticInvokerBase : InvokerBase // TypeDefIndex: 59072
	{
		// Constructors
		protected StaticInvokerBase(MethodInfo methodInfo); // 0x000000018B367A54-0x000000018B367B28
	
		// Methods
		protected sealed override void CompileExpression(); // 0x000000018B367988-0x000000018B367A00
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target); // 0x000000018B367A00-0x000000018B367A54
	}

	public class StaticPropertyAccessor<TProperty> : IOptimizedAccessor // TypeDefIndex: 59073
	{
		// Fields
		private readonly PropertyInfo propertyInfo;
		private Func<TProperty> getter;
		private Action<TProperty> setter;
		private System.Type targetType;
	
		// Constructors
		public StaticPropertyAccessor(PropertyInfo propertyInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
	}

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedAssemblyAttribute : Attribute // TypeDefIndex: 59074
	{
		// Fields
		[CompilerGenerated]
		private readonly string _previousName_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _newName_k__BackingField; // 0x18
	
		// Properties
		public string previousName { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public string newName { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class RenamedFromAttribute : Attribute // TypeDefIndex: 59075
	{
		// Fields
		[CompilerGenerated]
		private readonly string _previousName_k__BackingField; // 0x10
	
		// Properties
		public string previousName { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	}

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedNamespaceAttribute : Attribute // TypeDefIndex: 59076
	{
		// Fields
		[CompilerGenerated]
		private readonly string _previousName_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _newName_k__BackingField; // 0x18
	
		// Properties
		public string previousName { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public string newName { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public RenamedNamespaceAttribute(string previousName, string newName); // 0x00000001832AF420-0x00000001832AF450
	}

	public static class RuntimeCodebase // TypeDefIndex: 59079
	{
		// Fields
		private static readonly object @lock; // 0x00
		private static readonly List<System.Type> _types; // 0x08
		private static readonly List<Assembly> _assemblies; // 0x10
		public static HashSet<string> disallowedAssemblies; // 0x18
		private static readonly Dictionary<string, System.Type> typeSerializations; // 0x20
		private static Dictionary<string, System.Type> _renamedTypes; // 0x28
		private static Dictionary<string, string> _renamedNamespaces; // 0x30
		private static Dictionary<string, string> _renamedAssemblies; // 0x38
		private static readonly Dictionary<System.Type, Dictionary<string, string>> _renamedMembers; // 0x40
	
		// Properties
		public static IEnumerable<System.Type> types { get; } // 0x000000018B364CF4-0x000000018B364D44 
		public static IEnumerable<Assembly> assemblies { get; } // 0x000000018B364AD0-0x000000018B364B20 
		public static Dictionary<string, string> renamedNamespaces { get; } // 0x000000018B364BBC-0x000000018B364C58 
		public static Dictionary<string, string> renamedAssemblies { get; } // 0x000000018B364B20-0x000000018B364BBC 
		public static Dictionary<string, System.Type> renamedTypes { get; } // 0x000000018B364C58-0x000000018B364CF4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetAssemblyAttributes_d__15 : IEnumerable<Attribute>, IEnumerator<Attribute> // TypeDefIndex: 59077
		{
			// Fields
			private int __1__state; // 0x10
			private Attribute __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type attributeType; // 0x28
			public System.Type __3__attributeType; // 0x30
			private IEnumerable<Assembly> assemblies; // 0x38
			public IEnumerable<Assembly> __3__assemblies; // 0x40
			private IEnumerator<Assembly> __7__wrap1; // 0x48
			private IEnumerator<Attribute> __7__wrap2; // 0x50
	
			// Properties
			Attribute IEnumerator<System.Attribute>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetAssemblyAttributes_d__15(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B36AA34-0x000000018B36AB20
			private bool MoveNext(); // 0x000000018B36A458-0x000000018B36A93C
			private void __m__Finally1(); // 0x000000018B36AB20-0x000000018B36AB68
			private void __m__Finally2(); // 0x000000018B36AB68-0x000000018B36ABB4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B36A9E8-0x000000018B36AA34
			[DebuggerHidden]
			IEnumerator<Attribute> IEnumerable<Attribute>.GetEnumerator(); // 0x000000018B36A93C-0x000000018B36A9E0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B36A9E0-0x000000018B36A9E8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 59078
		{
			// Fields
			public Unity.VisualScripting.TypeName typeName; // 0x10
			public Func<Assembly, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _TrySystemTypeLookup_b__0(Assembly a); // 0x000000018B36B7D8-0x000000018B36B81C
		}
	
		// Constructors
		static RuntimeCodebase(); // 0x000000018B3644EC-0x000000018B364AD0
	
		// Methods
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType); // 0x000000018B363420-0x000000018B363474
		[IteratorStateMachine(typeof(_GetAssemblyAttributes_d__15))]
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType, IEnumerable<Assembly> assemblies); // 0x000000018B363398-0x000000018B363420
		public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>()
			where TAttribute : Attribute;
		public static string SerializeType(System.Type type); // 0x000000018B363474-0x000000018B363508
		public static bool TryDeserializeType(string typeName, out System.Type type); // 0x000000018B363588-0x000000018B363764
		public static System.Type DeserializeType(string typeName); // 0x000000018B362398-0x000000018B362484
		private static bool TryCachedTypeLookup(string typeName, out System.Type type); // 0x000000018B363508-0x000000018B363588
		private static bool TrySystemTypeLookup(string typeName, out System.Type type); // 0x000000018B363C38-0x000000018B364060
		private static bool TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, out System.Type type); // 0x000000018B364060-0x000000018B3644EC
		private static bool TryRenamedTypeLookup(string previousTypeName, out System.Type type); // 0x000000018B363764-0x000000018B363C38
		private static Dictionary<string, string> FetchRenamedNamespaces(); // 0x000000018B3627FC-0x000000018B362B74
		private static Dictionary<string, string> FetchRenamedAssemblies(); // 0x000000018B362484-0x000000018B3627FC
		private static Dictionary<string, System.Type> FetchRenamedTypes(); // 0x000000018B362B74-0x000000018B363398
	}

	public class TypeName // TypeDefIndex: 59082
	{
		// Fields
		[CompilerGenerated]
		private string _AssemblyDescription_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _AssemblyName_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _AssemblyVersion_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _AssemblyCulture_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _AssemblyPublicKeyToken_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly List<TypeName> _GenericParameters_k__BackingField; // 0x38
		private readonly List<string> names; // 0x40
		private readonly List<int> genericarities; // 0x48
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x50
	
		// Properties
		public string AssemblyDescription { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string AssemblyName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		private string AssemblyVersion { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
		private string AssemblyCulture { [CompilerGenerated] set; } // 0x0000000182FDB880-0x0000000182FDB890
		private string AssemblyPublicKeyToken { [CompilerGenerated] set; } // 0x0000000185396200-0x0000000185396210
		public List<TypeName> GenericParameters { [CompilerGenerated] get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public bool IsArray { get; } // 0x000000018B36976C-0x000000018B3697B8 
	
		// Nested types
		private enum ParseState // TypeDefIndex: 59080
		{
			Name = 0,
			Array = 1,
			Generics = 2,
			Assembly = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59081
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, string> __9__35_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B36B9D0-0x000000018B36BA34
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _.ctor_b__35_0(string x); // 0x000000018B36B580-0x000000018B36B5A8
		}
	
		// Constructors
		private TypeName(string s, ref int index); // 0x000000018B368DD0-0x000000018B36976C
	
		// Methods
		public static TypeName Parse(string s); // 0x000000018B367EB0-0x000000018B367F1C
		private static string LookForPairThenRemove(List<string> strings, string Name); // 0x000000018B367DC8-0x000000018B367EB0
		public void ReplaceNamespace(string oldNamespace, string newNamespace); // 0x000000018B368404-0x000000018B3686F0
		public void ReplaceAssembly(string oldAssembly, string newAssembly); // 0x000000018B367F1C-0x000000018B368124
		public void ReplaceName(string oldTypeName, System.Type newType); // 0x000000018B36837C-0x000000018B368404
		public void ReplaceName(string oldTypeName, string newTypeName, AssemblyName newAssemblyName = null); // 0x000000018B368124-0x000000018B36837C
		private static string ToElementTypeName(string s); // 0x000000018B368858-0x000000018B3688E0
		private static string ToArrayOrType(string oldType, string newType); // 0x000000018B3687E4-0x000000018B368858
		public void SetAssemblyName(AssemblyName newAssemblyName); // 0x000000018B3686F0-0x000000018B3687E4
		private void UpdateName(); // 0x000000018B368C80-0x000000018B368DD0
		public string ToString(TypeNameDetail specification, TypeNameDetail genericsSpecification); // 0x000000018B3688F0-0x000000018B368C70
		public override string ToString(); // 0x000000018B368C70-0x000000018B368C80
		public string ToLooseString(); // 0x000000018B3688E0-0x000000018B3688F0
	}

	public enum TypeNameDetail // TypeDefIndex: 59083
	{
		Name = 0,
		NameAndAssembly = 1,
		Full = 2
	}

	public static class TypeUtility // TypeDefIndex: 59086
	{
		// Fields
		private static readonly HashSet<System.Type> _numericTypes; // 0x00
		private static readonly HashSet<System.Type> _numericConstructTypes; // 0x08
		private static readonly HashSet<System.Type> typesWithShortStrings; // 0x10
		private static readonly Dictionary<System.Type, object> defaultPrimitives; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59084
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__35_0; // 0x08
			public static Func<System.Type, bool> __9__35_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B36BB60-0x000000018B36BBC4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetTypesSafely_b__35_0(System.Type t); // 0x000000018B36B1DC-0x000000018B36B224
			internal bool _GetTypesSafely_b__35_1(System.Type t); // 0x000000018B36B224-0x000000018B36B26C
		}
	
		[CompilerGenerated]
		private sealed class _GetTypesSafely_d__35 : IEnumerable<System.Type>, IEnumerator<System.Type> // TypeDefIndex: 59085
		{
			// Fields
			private int __1__state; // 0x10
			private System.Type __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Assembly assembly; // 0x28
			public Assembly __3__assembly; // 0x30
			private System.Type[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
	
			// Properties
			System.Type IEnumerator<System.Type>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetTypesSafely_d__35(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B36ABB4-0x000000018B36B05C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B36B0F8-0x000000018B36B144
			[DebuggerHidden]
			IEnumerator<System.Type> IEnumerable<Type>.GetEnumerator(); // 0x000000018B36B05C-0x000000018B36B0F0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B36B0F0-0x000000018B36B0F8
		}
	
		// Constructors
		static TypeUtility(); // 0x000000018B369AE4-0x000000018B36A458
	
		// Extension methods
		public static bool IsBasic(this System.Type type); // 0x000000018B369898-0x000000018B369A14
		public static bool IsStatic(this System.Type type); // 0x000000018B369AAC-0x000000018B369AE4
		public static bool IsNullable(this System.Type type); // 0x000000018B369A14-0x000000018B369A88
		public static bool IsReferenceType(this System.Type type); // 0x000000018B369A88-0x000000018B369AAC
		public static bool IsAssignableFrom(this System.Type type, object value); // 0x000000018B369828-0x000000018B369898
		[IteratorStateMachine(typeof(_GetTypesSafely_d__35))]
		public static IEnumerable<System.Type> GetTypesSafely(this Assembly assembly); // 0x000000018B3697B8-0x000000018B369828
	}

	public class LooseAssemblyNameConverter : fsDirectConverter // TypeDefIndex: 59087
	{
		// Properties
		public override System.Type ModelType { get; } // 0x000000018B35C3EC-0x000000018B35C43C 
	
		// Constructors
		public LooseAssemblyNameConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B35C1B8-0x000000018B35C1F4
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B35C31C-0x000000018B35C3EC
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B35C1F4-0x000000018B35C31C
	}

	public class NamespaceConverter : fsDirectConverter // TypeDefIndex: 59088
	{
		// Properties
		public override System.Type ModelType { get; } // 0x000000018B35D178-0x000000018B35D1C8 
	
		// Constructors
		public NamespaceConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B35CF44-0x000000018B35CF80
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B35D09C-0x000000018B35D178
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B35CF80-0x000000018B35D09C
	}

	public class Ray2DConverter : fsDirectConverter<Ray2D> // TypeDefIndex: 59089
	{
		// Constructors
		public Ray2DConverter(); // 0x000000018B361154-0x000000018B36117C
	
		// Methods
		protected override fsResult DoSerialize(Ray2D model, Dictionary<string, fsData> serialized); // 0x000000018B361000-0x000000018B361154
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray2D model); // 0x000000018B360E90-0x000000018B361000
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B360E50-0x000000018B360E90
	}

	public class RayConverter : fsDirectConverter<Ray> // TypeDefIndex: 59090
	{
		// Constructors
		public RayConverter(); // 0x000000018B3614CC-0x000000018B3614F4
	
		// Methods
		protected override fsResult DoSerialize(Ray model, Dictionary<string, fsData> serialized); // 0x000000018B361364-0x000000018B3614CC
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray model); // 0x000000018B3611D0-0x000000018B361364
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B36117C-0x000000018B3611D0
	}

	public class UnityObjectConverter : fsConverter // TypeDefIndex: 59091
	{
		// Properties
		private List<UnityEngine.Object> objectReferences { get; } // 0x000000018B36C10C-0x000000018B36C15C 
	
		// Constructors
		public UnityObjectConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B36BD54-0x000000018B36BDCC
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B36BFE0-0x000000018B36C10C
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType); // 0x000000018B36BDCC-0x000000018B36BFE0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000184D8C7E0-0x0000000184D8C7F0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class DoNotSerializeAttribute : Attribute // TypeDefIndex: 59092
	{
		// Constructors
		public DoNotSerializeAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface ISerializationDependency : ISerializationCallbackReceiver // TypeDefIndex: 59093
	{
		// Properties
		bool IsDeserialized { get; }
	}

	public interface ISerializationDepender : ISerializationCallbackReceiver // TypeDefIndex: 59094
	{
		// Properties
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		void OnAfterDependenciesDeserialized();
	}

	public static class Serialization // TypeDefIndex: 59095
	{
		// Fields
		private static readonly HashSet<SerializationOperation> freeOperations; // 0x00
		private static readonly HashSet<SerializationOperation> busyOperations; // 0x08
		private static readonly object @lock; // 0x10
		[CompilerGenerated]
		private static bool _isUnitySerializing_k__BackingField; // 0x18
		private static readonly HashSet<ISerializationDepender> awaitingDependers; // 0x20
	
		// Properties
		public static bool isUnitySerializing { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B3676D0-0x000000018B367720 0x000000018B367720-0x000000018B367774
		public static bool isCustomSerializing { get; } // 0x000000018B36766C-0x000000018B3676D0 
	
		// Constructors
		static Serialization(); // 0x000000018B3674DC-0x000000018B36766C
	
		// Methods
		private static SerializationOperation StartOperation(); // 0x000000018B3672A0-0x000000018B3674DC
		private static void EndOperation(SerializationOperation operation); // 0x000000018B3667BC-0x000000018B3669C8
		private static string SerializeJson(fsSerializer serializer, object instance, bool forceReflected); // 0x000000018B366CEC-0x000000018B366F18
		private static fsResult DeserializeJsonUtil(fsSerializer serializer, string json, ref object instance, bool forceReflected); // 0x000000018B3664D0-0x000000018B3665F8
		private static void DeserializeJson(fsSerializer serializer, string json, ref object instance, bool forceReflected); // 0x000000018B3665F8-0x000000018B366750
		private static void HandleResult(string label, fsResult result, UnityEngine.Object context = null); // 0x000000018B3669C8-0x000000018B366CD0
		public static string PrettyPrint(string json); // 0x000000018B366CD0-0x000000018B366CEC
		public static void AwaitDependencies(ISerializationDepender depender); // 0x000000018B365AB4-0x000000018B365B2C
		private static void CheckIfDependenciesMet(ISerializationDepender depender); // 0x000000018B365B2C-0x000000018B365F38
	
		// Extension methods
		public static Unity.VisualScripting.SerializationData Serialize(this object value, bool forceReflected = false /* Metadata: 0x0234C616 */); // 0x000000018B366F18-0x000000018B3672A0
		public static void DeserializeInto(this Unity.VisualScripting.SerializationData data, ref object instance, bool forceReflected = false /* Metadata: 0x0234C617 */); // 0x000000018B365F38-0x000000018B3664D0
		public static object Deserialize(this Unity.VisualScripting.SerializationData data, bool forceReflected = false /* Metadata: 0x0234C618 */); // 0x000000018B366750-0x000000018B3667BC
	}

	[Serializable]
	public struct SerializationData // TypeDefIndex: 59096
	{
		// Fields
		[SerializeField]
		private string _json; // 0x00
		[SerializeField]
		private UnityEngine.Object[] _objectReferences; // 0x08
	
		// Properties
		public string json { get; } // 0x0000000182B76770-0x0000000182B76780 
		public UnityEngine.Object[] objectReferences { get; } // 0x0000000184D88320-0x0000000184D88330 
	
		// Constructors
		public SerializationData(string json, IEnumerable<UnityEngine.Object> objectReferences); // 0x000000018B3657A0-0x000000018B365840
		public SerializationData(string json, params UnityEngine.Object[] objectReferences); // 0x000000018B365798-0x000000018B3657A0
	
		// Methods
		internal void Clear(); // 0x0000000189ACC1AC-0x0000000189ACC1D0
		public string ToString(string title); // 0x000000018B3650D0-0x000000018B36578C
		public override string ToString(); // 0x000000018B36578C-0x000000018B365798
		public void ShowString(string title = null); // 0x000000018B365004-0x000000018B3650D0
	}

	public class SerializationOperation // TypeDefIndex: 59097
	{
		// Fields
		[CompilerGenerated]
		private fsSerializer _serializer_k__BackingField; // 0x10
		[CompilerGenerated]
		private List<UnityEngine.Object> _objectReferences_k__BackingField; // 0x18
	
		// Properties
		public fsSerializer serializer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public List<UnityEngine.Object> objectReferences { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public SerializationOperation(); // 0x000000018B365888-0x000000018B365AAC
	
		// Methods
		public void Reset(); // 0x000000018B365840-0x000000018B365888
	}

	public class SerializationVersionAttribute : fsObjectAttribute // TypeDefIndex: 59098
	{
		// Constructors
		public SerializationVersionAttribute(string versionString, params System.Type[] previousModels); // 0x000000018B365AAC-0x000000018B365AB4
	}

	public class SerializeAsAttribute : fsPropertyAttribute // TypeDefIndex: 59099
	{
		// Constructors
		public SerializeAsAttribute(string name); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class SerializeAttribute : Attribute // TypeDefIndex: 59100
	{
		// Constructors
		public SerializeAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface ISingleton // TypeDefIndex: 59101
	{
	}

	public abstract class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 59102
	{
		// Fields
		[DoNotSerialize]
		[SerializeField]
		protected Unity.VisualScripting.SerializationData _data; // 0x18
		[CompilerGenerated]
		private Action OnDestroyActions; // 0x28
	
		// Events
		internal event Action OnDestroyActions {
			add; // 0x000000018B35C894-0x000000018B35C928
			remove; // 0x000000018B35C928-0x000000018B35C9BC
		}
	
		// Constructors
		protected LudiqScriptableObject(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018B35C748-0x000000018B35C894
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018B35C5E4-0x000000018B35C748
		protected virtual void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterSerialize(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnBeforeDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnPostDeserializeInEditor(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x000000018B35C548-0x000000018B35C558
		protected virtual void ShowData(); // 0x000000018B35C558-0x000000018B35C5DC
		public override string ToString(); // 0x000000018B35C5DC-0x000000018B35C5E4
	}

	public static class Singleton<T> // TypeDefIndex: 59103
		where T : MonoBehaviour, ISingleton
	{
		// Fields
		private static readonly SingletonAttribute attribute;
		private static readonly object _lock;
		private static readonly HashSet<T> awoken;
		private static T _instance;
	
		// Properties
		private static bool persistent { get; }
		private static bool automatic { get; }
		private static string name { get; }
		private static HideFlags hideFlags { get; }
		public static T instance { get; }
	
		// Constructors
		static Singleton();
	
		// Methods
		private static T[] FindObjectsOfType();
		private static T[] FindInstances();
		public static T Instantiate();
		public static void Awake(T instance);
		public static void OnDestroy(T instance);
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public sealed class SingletonAttribute : Attribute // TypeDefIndex: 59104
	{
		// Fields
		[CompilerGenerated]
		private bool _Persistent_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _Automatic_k__BackingField; // 0x11
		[CompilerGenerated]
		private HideFlags _HideFlags_k__BackingField; // 0x14
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x18
	
		// Properties
		public bool Persistent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		public bool Automatic { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88380-0x0000000184D88390 0x0000000184D88460-0x0000000184D88470
		public HideFlags HideFlags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public SingletonAttribute(); // 0x0000000184D9DD80-0x0000000184D9DD90
	}

	public static class UnityThread // TypeDefIndex: 59105
	{
		// Fields
		public static Thread thread; // 0x00
		public static ConcurrentQueue<Action> pendingQueue; // 0x08
	
		// Properties
		public static bool allowsAPI { get; } // 0x000000018B36C484-0x000000018B36C530 
	
		// Constructors
		static UnityThread(); // 0x0000000184A1D420-0x0000000184A1D4E0
	
		// Methods
		internal static void RuntimeInitialize(); // 0x0000000183FCE110-0x0000000183FCE180
	}

	public static class Empty<T> // TypeDefIndex: 59106
	{
		// Fields
		public static readonly T[] array;
		public static readonly List<T> list;
		public static readonly HashSet<T> hashSet;
	
		// Constructors
		static Empty();
	}

	public static class HashUtility // TypeDefIndex: 59107
	{
		// Methods
		public static int GetHashCode<T>(T a);
		public static int GetHashCode<T1, T2>(T1 a, T2 b);
	}

	public interface IIdentifiable // TypeDefIndex: 59108
	{
		// Properties
		Guid guid { get; }
	}

	public static class LinqUtility // TypeDefIndex: 59111
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Concat_d__0<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 59109
		{
			// Fields
			private int __1__state;
			private T __2__current;
			private int __l__initialThreadId;
			private IEnumerable[] enumerables;
			public IEnumerable[] __3__enumerables;
			private IEnumerator<IEnumerable> __7__wrap1;
			private IEnumerator<T> __7__wrap2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__0(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__2<T> // TypeDefIndex: 59110
		{
			// Fields
			public static readonly __c__2<T> __9;
			public static Func<T, bool> __9__2_0;
	
			// Constructors
			static __c__2();
			public __c__2();
	
			// Methods
			internal bool _NotNull_b__2_0(T i);
		}
	
		// Methods
		[IteratorStateMachine(typeof(_Concat_d__0<T>))]
		public static IEnumerable<T> Concat<T>(params IEnumerable[] enumerables);
	
		// Extension methods
		public static IEnumerable<T> NotNull<T>(this IEnumerable<T> enumerable);
	}

	public class Recursion<T> : IPoolable, IDisposable // TypeDefIndex: 59113
	{
		// Fields
		private readonly Stack<T> traversedOrder;
		private readonly Dictionary<T, int> traversedCount;
		private bool disposed;
		protected int maxDepth;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59112
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<Recursion<T>> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal Recursion<T> _New_b__13_0();
		}
	
		// Constructors
		protected Recursion();
	
		// Methods
		public void Enter(T o);
		public bool TryEnter(T o);
		public void Exit(T o);
		public void Dispose();
		protected virtual void Free();
		void IPoolable.New();
		void IPoolable.Free();
		public static Recursion<T> New();
		public static Recursion<T> New(int maxDepth);
	}

	public sealed class Recursion : Recursion<object> // TypeDefIndex: 59114
	{
		// Fields
		[CompilerGenerated]
		private static int _defaultMaxDepth_k__BackingField; // 0x00
		[CompilerGenerated]
		private static bool _safeMode_k__BackingField; // 0x04
	
		// Properties
		public static int defaultMaxDepth { [CompilerGenerated] get; } // 0x000000018B3614F4-0x000000018B361544 
		public static bool safeMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B361544-0x000000018B361594 0x000000018B361594-0x000000018B3615E8
	
		// Constructors
		static Recursion(); // 0x0000000184D79CD0-0x0000000184D79D10
	
		// Methods
		internal static void OnRuntimeMethodLoad(); // 0x0000000183FCE840-0x0000000183FCE910
	}

	public static class ReferenceCollector // TypeDefIndex: 59116
	{
		// Fields
		[CompilerGenerated]
		private static Action onSceneUnloaded; // 0x00
	
		// Events
		public static event Action onSceneUnloaded {
			add; // 0x000000018B3615E8-0x000000018B361690
			remove; // 0x000000018B361690-0x000000018B361738
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59115
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UnityAction<Scene> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D3FCD0-0x0000000184D3FD30
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Initialize_b__3_0(Scene scene); // 0x0000000184D54B20-0x0000000184D54B70
		}
	
		// Methods
		internal static void Initialize(); // 0x0000000183FCEDC0-0x0000000183FCEEE0
	}

	public class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 59117
	{
		// Fields
		public static readonly ReferenceEqualityComparer Instance; // 0x00
	
		// Constructors
		private ReferenceEqualityComparer(); // 0x00000001841E1670-0x00000001841E1680
		static ReferenceEqualityComparer(); // 0x0000000184D4DE30-0x0000000184D4DE90
	
		// Methods
		bool IEqualityComparer<object>.Equals(object a, object b); // 0x0000000184D7F860-0x0000000184D7F870
		int IEqualityComparer<object>.GetHashCode(object a); // 0x0000000184CC8900-0x0000000184CC8950
		public static int GetHashCode(object a); // 0x0000000184D87100-0x0000000184D87110
	}

	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 59118
	{
		// Fields
		public static readonly ReferenceEqualityComparer<T> Instance;
	
		// Constructors
		private ReferenceEqualityComparer();
		static ReferenceEqualityComparer();
	
		// Methods
		bool IEqualityComparer<T>.Equals(T a, T b);
		int IEqualityComparer<T>.GetHashCode(T a);
		public static int GetHashCode(T a);
	}

	public static class RuntimeVSUsageUtility // TypeDefIndex: 59119
	{
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RuntimeInitializeOnLoadBeforeSceneLoad(); // 0x0000000183FCE040-0x0000000183FCE110
	}

	public static class StringUtility // TypeDefIndex: 59120
	{
		// Fields
		private static readonly Regex guidRegex; // 0x00
	
		// Constructors
		static StringUtility(); // 0x000000018B367D38-0x000000018B367DC8
	
		// Extension methods
		public static string TrimStart(this string source, string value); // 0x000000018B367C98-0x000000018B367D38
		public static void PartsAround(this string s, char c, out string before, out string after); // 0x000000018B367B28-0x000000018B367C1C
		public static string ToHexString(this byte[] bytes); // 0x000000018B367C1C-0x000000018B367C98
	}

	public static class UnityObjectUtility // TypeDefIndex: 59121
	{
		// Methods
		public static bool TrulyEqual(UnityEngine.Object a, UnityEngine.Object b); // 0x000000018B36C3FC-0x000000018B36C484
	
		// Extension methods
		public static bool IsUnityNull(this object obj); // 0x000000018B36C15C-0x000000018B36C1D8
		public static string ToSafeString(this UnityEngine.Object uo); // 0x000000018B36C1D8-0x000000018B36C3FC
		public static T AsUnityNull<T>(this T obj)
			where T : UnityEngine.Object;
	}

	public static class ApplicationVariables // TypeDefIndex: 59122
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
		[CompilerGenerated]
		private static VariableDeclarations _runtime_k__BackingField; // 0x08
	
		// Properties
		public static VariablesAsset asset { get; } // 0x0000000183C91D50-0x0000000183C91E00 
		private static VariableDeclarations runtime { [CompilerGenerated] set; } // 0x000000018B3526F8-0x000000018B35274C
	
		// Methods
		public static void Load(); // 0x0000000183C91E00-0x0000000183C91E90
		internal static void OnEnterPlayMode(); // 0x0000000185396C5C-0x0000000185396C64
		internal static void OnExitPlayMode(); // 0x00000001841E1670-0x00000001841E1680
		private static void CreateRuntimeDeclarations(); // 0x0000000183C91350-0x0000000183C91410
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorVariableNameAttribute : Attribute // TypeDefIndex: 59123
	{
		// Fields
		[CompilerGenerated]
		private ActionDirection _direction_k__BackingField; // 0x10
	
		// Properties
		private ActionDirection direction { [CompilerGenerated] set; } // 0x00000001814F51F0-0x00000001814F5220
	
		// Constructors
		public InspectorVariableNameAttribute(ActionDirection direction); // 0x00000001814F51F0-0x00000001814F5220
	}

	public static class SavedVariables // TypeDefIndex: 59125
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
		[CompilerGenerated]
		private static VariableDeclarations _saved_k__BackingField; // 0x08
		[CompilerGenerated]
		private static VariableDeclarations _merged_k__BackingField; // 0x10
	
		// Properties
		public static VariablesAsset asset { get; } // 0x0000000183C91CA0-0x0000000183C91D50 
		public static VariableDeclarations initial { get; } // 0x0000000183C91C00-0x0000000183C91CA0 
		public static VariableDeclarations saved { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B364F24-0x000000018B364F5C 0x000000018B364FB0-0x000000018B365004
		public static VariableDeclarations merged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B364EEC-0x000000018B364F24 0x000000018B364F5C-0x000000018B364FB0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59124
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__8_0; // 0x08
			public static Func<VariableDeclaration, string> __9__24_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D4B0D0-0x0000000184D4B130
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnEnterPlayMode_b__8_0(); // 0x000000018B36B300-0x000000018B36B358
			internal string _MergeInitialAndSavedDeclarations_b__24_0(VariableDeclaration vd); // 0x0000000186C08920-0x0000000186C08938
		}
	
		// Methods
		public static void Load(); // 0x0000000183C91E90-0x0000000183C91F20
		internal static void OnEnterPlayMode(); // 0x0000000183C911E0-0x0000000183C91350
		internal static void OnExitPlayMode(); // 0x000000018B364D44-0x000000018B364D5C
		public static void SaveDeclarations(VariableDeclarations declarations); // 0x000000018B364D5C-0x000000018B364EEC
		public static void FetchSavedDeclarations(); // 0x0000000183C92510-0x0000000183C925B0
		private static void MergeInitialAndSavedDeclarations(); // 0x0000000183C91410-0x0000000183C91C00
		private static void WarnAndNullifyUnityObjectReferences(VariableDeclarations declarations); // 0x0000000184727250-0x0000000184727470
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclaration // TypeDefIndex: 59126
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private object _value_k__BackingField; // 0x18
	
		// Properties
		[Serialize]
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		[Serialize]
		[Value]
		public object value { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public VariableDeclaration(string name, object value); // 0x00000001832AF420-0x00000001832AF450
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclarationCollection : KeyedCollection<string, VariableDeclaration>, IKeyedCollection<string, VariableDeclaration> // TypeDefIndex: 59127
	{
		// Properties
		VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.this[string key] { get => default; } // 0x000000018B36CC80-0x000000018B36CCC8 
	
		// Constructors
		public VariableDeclarationCollection(); // 0x0000000183C93A80-0x0000000183C93AC0
	
		// Methods
		protected override string GetKeyForItem(VariableDeclaration item); // 0x0000000186C08920-0x0000000186C08938
		public new bool TryGetValue(string key, out VariableDeclaration value); // 0x000000018B36CBC0-0x000000018B36CC38
		bool IKeyedCollection<string, VariableDeclaration>.Contains(string key); // 0x000000018B36CC38-0x000000018B36CC80
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclarations : IEnumerable<VariableDeclaration>, ISpecifiesCloner // TypeDefIndex: 59128
	{
		// Fields
		public VariableKind Kind; // 0x10
		[InspectorWide(true)]
		[Serialize]
		private VariableDeclarationCollection collection; // 0x18
		internal Action OnVariableChanged; // 0x20
	
		// Properties
		public object this[[InspectorVariableName(ActionDirection.Any)] string variable] { get => default; set {} } // 0x000000018B36D0FC-0x000000018B36D104 0x000000018B36D104-0x000000018B36D10C
		ICloner ISpecifiesCloner.cloner { get; } // 0x000000018B36D0AC-0x000000018B36D0FC 
	
		// Constructors
		public VariableDeclarations(); // 0x0000000183C93A10-0x0000000183C93A80
	
		// Methods
		public void Set([InspectorVariableName(ActionDirection.Set)] string variable, object value); // 0x000000018B36CF68-0x000000018B36D064
		public object Get([InspectorVariableName(ActionDirection.Get)] string variable); // 0x000000018B36CD74-0x000000018B36CEA8
		public void Clear(); // 0x000000018B36CD2C-0x000000018B36CD74
		public bool IsDefined([InspectorVariableName(ActionDirection.Any)] string variable); // 0x000000018B36CEA8-0x000000018B36CF68
		public IEnumerator<VariableDeclaration> GetEnumerator(); // 0x0000000184727730-0x0000000184727780
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B36D064-0x000000018B36D0AC
	}

	public sealed class VariableDeclarationsCloner : Cloner<VariableDeclarations> // TypeDefIndex: 59129
	{
		// Fields
		public static readonly VariableDeclarationsCloner instance; // 0x00
	
		// Constructors
		public VariableDeclarationsCloner(); // 0x0000000184D19370-0x0000000184D193A0
		static VariableDeclarationsCloner(); // 0x0000000184D19300-0x0000000184D19370
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018B36CCC8-0x000000018B36CD2C
		public override VariableDeclarations ConstructClone(System.Type type, VariableDeclarations original); // 0x0000000183C93950-0x0000000183C939A0
		public override void FillClone(System.Type type, ref VariableDeclarations clone, VariableDeclarations original, CloningContext context); // 0x0000000184727540-0x0000000184727730
	}

	public enum VariableKind // TypeDefIndex: 59130
	{
		Flow = 0,
		Graph = 1,
		Object = 2,
		Scene = 3,
		Application = 4,
		Saved = 5
	}

	[IncludeInSettings(false)]
	public sealed class VariablesAsset : LudiqScriptableObject // TypeDefIndex: 59131
	{
		// Fields
		[CompilerGenerated]
		private VariableDeclarations _declarations_k__BackingField; // 0x30
	
		// Properties
		[Inspectable]
		[InspectorWide(true)]
		[Serialize]
		public VariableDeclarations declarations { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		public VariablesAsset(); // 0x0000000183C939A0-0x0000000183C93A10
	
		// Methods
		[ContextMenu("Show Data...")]
		protected override void ShowData(); // 0x000000018B36D10C-0x000000018B36D114
	}

	[AddComponentMenu("")]
	[DisableAnnotation]
	[IncludeInSettings(false)]
	[Singleton(Name = "VisualScripting SavedVariablesSerializer", Automatic = true, Persistent = true)]
	public class VariablesSaver : MonoBehaviour, ISingleton // TypeDefIndex: 59132
	{
		// Properties
		public static VariablesSaver instance { get; } // 0x000000018B36D224-0x000000018B36D278 
	
		// Constructors
		public VariablesSaver(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018B36D114-0x000000018B36D168
		private void OnDestroy(); // 0x000000018B36D1D0-0x000000018B36D224
		private void OnApplicationQuit(); // 0x000000018B36D1C8-0x000000018B36D1D0
		private void OnApplicationPause(bool isPaused); // 0x000000018B36D1BC-0x000000018B36D1C8
		public static void Instantiate(); // 0x000000018B36D168-0x000000018B36D1BC
	}
}

namespace Unity.VisualScripting.FullSerializer
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 59133
	{
		// Constructors
		public fsArrayConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B352868-0x000000018B352888
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B36D718-0x000000018B36D8F4
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B36D4B0-0x000000018B36D718
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B36D43C-0x000000018B36D4B0
	}

	public class fsDateConverter : fsConverter // TypeDefIndex: 59134
	{
		// Properties
		private string DateTimeFormatString { get; } // 0x000000018B370498-0x000000018B3704EC 
	
		// Constructors
		public fsDateConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B36FC48-0x000000018B36FD0C
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B370290-0x000000018B370498
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B36FD0C-0x000000018B370290
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 59135
	{
		// Constructors
		public fsDictionaryConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B37078C-0x000000018B370804
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B370804-0x000000018B370878
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x000000018B370994-0x000000018B371198
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018B371198-0x000000018B3716D4
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value); // 0x000000018B3704EC-0x000000018B37078C
		private static void GetKeyValueTypes(System.Type dictionaryType, out System.Type keyStorageType, out System.Type valueStorageType); // 0x000000018B370878-0x000000018B370994
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 59138
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 59136
		{
			// Fields
			public Enum x; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ValueTuple<Enum, string> _TryDeserialize_b__3(RenamedFromAttribute attr); // 0x000000018B36CA88-0x000000018B36CAF8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59137
		{
			// Fields
			public static readonly __c __9; // 0x00
			[TupleElementNames(new string[2] {"x", "previousName" })]
			public static Func<Enum, IEnumerable<ValueTuple<Enum, string>>> __9__5_0; // 0x08
			[TupleElementNames(new string[2] {"enumMember", "previousName" })]
			public static Func<ValueTuple<Enum, string>, string> __9__5_1; // 0x10
			[TupleElementNames(new string[2] {"enumMember", "previousName" })]
			public static Func<ValueTuple<Enum, string>, Enum> __9__5_2; // 0x18
	
			// Constructors
			static __c(); // 0x000000018B36CAF8-0x000000018B36CB5C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal IEnumerable<ValueTuple<Enum, string>> _TryDeserialize_b__5_0(Enum x); // 0x000000018B36C7D0-0x000000018B36C8D0
			internal string _TryDeserialize_b__5_1([TupleElementNames(new string[2] {"enumMember", "previousName" })] ValueTuple<Enum, string> x); // 0x0000000184D94CB0-0x0000000184D94CC0
			internal Enum _TryDeserialize_b__5_2([TupleElementNames(new string[2] {"enumMember", "previousName" })] ValueTuple<Enum, string> x); // 0x0000000182A55C30-0x0000000182A55C40
		}
	
		// Constructors
		public fsEnumConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B371838-0x000000018B371890
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B371890-0x000000018B371904
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B372070-0x000000018B372544
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B371904-0x000000018B372070
		private static bool ArrayContains<T>(T[] values, T value);
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 59139
	{
		// Fields
		public string MemberName; // 0x10
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 59140
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x000000018A9A6604-0x000000018A9A6628
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B372544-0x000000018B3725A0
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x000000018B372614-0x000000018B3727DC
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B372960-0x000000018B372AC0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B3727DC-0x000000018B372960
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B3725A0-0x000000018B372614
	}

	public class fsGuidConverter : fsConverter // TypeDefIndex: 59141
	{
		// Constructors
		public fsGuidConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B372B40-0x000000018B372BA4
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B372CEC-0x000000018B372DDC
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B372BE4-0x000000018B372CEC
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B372BA4-0x000000018B372BE4
	}

	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 59142
	{
		// Constructors
		public fsIEnumerableConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B372DDC-0x000000018B372E74
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B372E74-0x000000018B372EE8
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018B3735BC-0x000000018B373930
		private bool IsStack(System.Type type); // 0x000000018B37318C-0x000000018B373244
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x000000018B3732D8-0x000000018B3735BC
		private static int HintSize(IEnumerable collection); // 0x000000018B373114-0x000000018B37318C
		private static System.Type GetElementType(System.Type objectType); // 0x000000018B373028-0x000000018B373114
		private static void TryClear(System.Type type, object instance); // 0x000000018B373244-0x000000018B3732D8
		private static MethodInfo GetAddMethod(System.Type type); // 0x000000018B372EE8-0x000000018B373028
	}

	public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 59143
	{
		// Constructors
		public fsKeyValuePairConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B376DB0-0x000000018B376E5C
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B376E5C-0x000000018B377250
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B377250-0x000000018B377508
	}

	public class fsNullableConverter : fsConverter // TypeDefIndex: 59144
	{
		// Constructors
		public fsNullableConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B379524-0x000000018B3795D0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B379648-0x000000018B3796C0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B3795D0-0x000000018B379648
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000184D8C7E0-0x0000000184D8C7F0
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 59145
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B379F4C-0x000000018B37A014
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B37A5B8-0x000000018B37AB64
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType); // 0x000000018B37A014-0x000000018B37A5B8
		private static bool UseBool(System.Type type); // 0x000000018B37AB64-0x000000018B37ABC8
		private static bool UseInt64(System.Type type); // 0x000000018B37AC8C-0x000000018B37AE48
		private static bool UseDouble(System.Type type); // 0x000000018B37ABC8-0x000000018B37AC8C
		private static bool UseString(System.Type type); // 0x000000018B37AE48-0x000000018B37AEE0
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 59146
	{
		// Constructors
		public fsReflectedConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B37AEE0-0x000000018B37AF8C
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B37B260-0x000000018B37B4A0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B37B000-0x000000018B37B260
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B37AF8C-0x000000018B37B000
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 59147
	{
		// Constructors
		public fsTypeConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B3815DC-0x000000018B381654
		public override bool RequestCycleSupport(System.Type type); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type type); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B3817D0-0x000000018B3818C8
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B381654-0x000000018B3817D0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000184D8C7E0-0x0000000184D8C7F0
	}

	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 59148
	{
		// Constructors
		public fsWeakReferenceConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B382CDC-0x000000018B382D40
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B3830B8-0x000000018B383364
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B382D98-0x000000018B3830B8
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018B382D40-0x000000018B382D98
	}

	public class fsConverterRegistrar // TypeDefIndex: 59149
	{
		// Fields
		public static List<System.Type> Converters; // 0x00
	
		// Constructors
		static fsConverterRegistrar(); // 0x000000018B36E330-0x000000018B36E644
	}

	public class fsAotCompilationManager // TypeDefIndex: 59151
	{
		// Fields
		private static Dictionary<System.Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 59150
		{
			// Fields
			public System.Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		static fsAotCompilationManager(); // 0x000000018B36D348-0x000000018B36D43C
	
		// Methods
		public static void AddAotCompilation(System.Type type, fsMetaProperty[] members, bool isConstructorPublic); // 0x000000018B36D278-0x000000018B36D348
	}

	public abstract class fsBaseConverter // TypeDefIndex: 59153
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59152
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsDataType, string> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B36CB5C-0x000000018B36CBC0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _FailExpectedType_b__6_0(fsDataType t); // 0x000000018B36C780-0x000000018B36C7D0
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType); // 0x000000018B36DD20-0x000000018B36DE74
		public virtual bool RequestCycleSupport(System.Type storageType); // 0x000000018B36E1B4-0x000000018B36E268
		public virtual bool RequestInheritanceSupport(System.Type storageType); // 0x000000018B36E268-0x000000018B36E2B8
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types); // 0x000000018B36DE74-0x000000018B36E1B4
		protected fsResult CheckType(fsData data, fsDataType type); // 0x000000018B36DB08-0x000000018B36DD20
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x000000018B36D8F4-0x000000018B36D960
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x000000018B36D960-0x000000018B36DB08
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value);
	}

	public static class fsGlobalConfig // TypeDefIndex: 59154
	{
		// Fields
		public static bool IsCaseSensitive; // 0x00
		public static bool AllowInternalExceptions; // 0x01
		public static string InternalFieldPrefix; // 0x08
	
		// Constructors
		static fsGlobalConfig(); // 0x000000018B372AC0-0x000000018B372B40
	}

	public class fsConfig // TypeDefIndex: 59156
	{
		// Fields
		public System.Type[] SerializeAttributes; // 0x10
		public System.Type[] IgnoreSerializeAttributes; // 0x18
		public fsMemberSerialization DefaultMemberSerialization; // 0x20
		public Func<string, MemberInfo, string> GetJsonNameFromMemberName; // 0x28
		public bool EnablePropertySerialization; // 0x30
		public bool SerializeNonAutoProperties; // 0x31
		public bool SerializeNonPublicSetProperties; // 0x32
		public string CustomDateTimeFormatString; // 0x38
		public bool Serialize64BitIntegerAsString; // 0x40
		public bool SerializeEnumsAsInteger; // 0x41
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59155
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, MemberInfo, string> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D448F0-0x0000000184D44950
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _.ctor_b__10_0(string name, MemberInfo info); // 0x0000000184D88C30-0x0000000184D88C40
		}
	
		// Constructors
		public fsConfig(); // 0x00000001845BFF30-0x00000001845C0260
	}

	public sealed class fsContext // TypeDefIndex: 59157
	{
		// Fields
		private readonly Dictionary<System.Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext(); // 0x000000018B36E2B8-0x000000018B36E330
	
		// Methods
		public void Set<T>(T obj);
		public T Get<T>();
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 59158
	{
		// Constructors
		protected fsConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public enum fsDataType // TypeDefIndex: 59159
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 59160
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x000000018B36F9C8-0x000000018B36FB24 
		public bool IsNull { get; } // 0x0000000183BA32C0-0x0000000183BA32D0 
		public bool IsDouble { get; } // 0x000000018B36F8A0-0x000000018B36F8EC 
		public bool IsInt64 { get; } // 0x000000018B36F8EC-0x000000018B36F938 
		public bool IsBool { get; } // 0x000000018B36F810-0x000000018B36F85C 
		public bool IsString { get; } // 0x000000018B36F97C-0x000000018B36F9C8 
		public bool IsDictionary { get; } // 0x000000018B36F85C-0x000000018B36F8A0 
		public bool IsList { get; } // 0x000000018B36F938-0x000000018B36F97C 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public double AsDouble { get; } // 0x000000018B36F720-0x000000018B36F75C 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long AsInt64 { get; } // 0x000000018B36F75C-0x000000018B36F798 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AsBool { get; } // 0x000000018B36F6A8-0x000000018B36F6E4 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string AsString { get; } // 0x000000018B36F7D4-0x000000018B36F810 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Dictionary<string, fsData> AsDictionary { get; } // 0x000000018B36F6E4-0x000000018B36F720 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public List<fsData> AsList { get; } // 0x000000018B36F798-0x000000018B36F7D4 
	
		// Constructors
		public fsData(); // 0x00000001840E20A0-0x00000001840E20C0
		public fsData(bool boolean); // 0x000000018B36F594-0x000000018B36F5F0
		public fsData(double f); // 0x000000018B36F5F0-0x000000018B36F64C
		public fsData(long i); // 0x000000018B36F64C-0x000000018B36F6A8
		public fsData(string str); // 0x00000001853908C0-0x00000001853908D0
		public fsData(Dictionary<string, fsData> dict); // 0x00000001853908C0-0x00000001853908D0
		public fsData(List<fsData> list); // 0x00000001853908C0-0x00000001853908D0
		static fsData(); // 0x000000018B36F488-0x000000018B36F594
	
		// Methods
		public override string ToString(); // 0x000000018B36F480-0x000000018B36F488
		public static fsData CreateDictionary(); // 0x000000018B36ED34-0x000000018B36EE28
		public static fsData CreateList(int capacity); // 0x000000018B36EE28-0x000000018B36EEC4
		internal void BecomeDictionary(); // 0x000000018B36EC50-0x000000018B36ECC8
		internal fsData Clone(); // 0x000000018B36ECC8-0x000000018B36ED34
		private T Cast<T>();
		public override bool Equals(object obj); // 0x000000018B36EEC4-0x000000018B36EF28
		public bool Equals(fsData other); // 0x000000018B36EF28-0x000000018B36F480
		public static bool operator ==(fsData a, fsData b); // 0x000000018B36FB24-0x000000018B36FBF4
		public static bool operator !=(fsData a, fsData b); // 0x000000018B36FBF4-0x000000018B36FC48
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 59161
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 59162
	{
		// Properties
		public override System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter();
	
		// Methods
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref ref TModel model);
	}

	public sealed class fsMissingVersionConstructorException : Exception // TypeDefIndex: 59163
	{
		// Constructors
		public fsMissingVersionConstructorException(System.Type versionedType, System.Type constructorType); // 0x000000018B379458-0x000000018B379524
	}

	public sealed class fsDuplicateVersionNameException : Exception // TypeDefIndex: 59164
	{
		// Constructors
		public fsDuplicateVersionNameException(System.Type typeA, System.Type typeB, string version); // 0x000000018B3716D4-0x000000018B371838
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 59165
	{
	}

	public interface fsISerializationCallbacks // TypeDefIndex: 59166
	{
		// Methods
		void OnBeforeSerialize(System.Type storageType);
		void OnAfterSerialize(System.Type storageType, ref fsData data);
		void OnBeforeDeserialize(System.Type storageType, ref fsData data);
		void OnAfterDeserialize(System.Type storageType);
	}

	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 59167
	{
		// Constructors
		public fsSerializationCallbackProcessor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B37BE50-0x000000018B37BEC8
		public override void OnBeforeSerialize(System.Type storageType, object instance); // 0x000000018B37C150-0x000000018B37C1CC
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data); // 0x000000018B37BF44-0x000000018B37BFD4
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x000000018B37BFD4-0x000000018B37C150
		public override void OnAfterDeserialize(System.Type storageType, object instance); // 0x000000018B37BEC8-0x000000018B37BF44
	}

	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 59168
	{
		// Constructors
		public fsSerializationCallbackReceiverProcessor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018B37C1CC-0x000000018B37C244
		public override void OnBeforeSerialize(System.Type storageType, object instance); // 0x000000018B37C2C8-0x000000018B37C34C
		public override void OnAfterDeserialize(System.Type storageType, object instance); // 0x000000018B37C244-0x000000018B37C2C8
	}

	public class fsJsonParser // TypeDefIndex: 59169
	{
		// Fields
		private readonly StringBuilder _cachedStringBuilder; // 0x10
		private int _start; // 0x18
		private string _input; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x000000018B3758EC-0x000000018B375978
	
		// Methods
		private fsResult MakeFailure(string message); // 0x000000018B373A2C-0x000000018B373BB8
		private bool TryMoveNext(); // 0x000000018B3742FC-0x000000018B374328
		private bool HasValue(); // 0x000000018B373968-0x000000018B373974
		private bool HasValue(int offset); // 0x000000018B373974-0x000000018B3739A8
		private char Character(); // 0x000000018B373930-0x000000018B37393C
		private char Character(int offset); // 0x000000018B37393C-0x000000018B373968
		private void SkipSpace(); // 0x000000018B374120-0x000000018B3742FC
		private fsResult TryParseExact(string content); // 0x000000018B3745E0-0x000000018B374724
		private fsResult TryParseTrue(out fsData data); // 0x000000018B3752F4-0x000000018B3753F4
		private fsResult TryParseFalse(out fsData data); // 0x000000018B374724-0x000000018B374824
		private fsResult TryParseNull(out fsData data); // 0x000000018B374824-0x000000018B374920
		private bool IsSeparator(char c); // 0x000000018B3739D0-0x000000018B373A2C
		private fsResult TryParseNumber(out fsData data); // 0x000000018B374920-0x000000018B374C34
		private fsResult TryParseString(out string str); // 0x000000018B37503C-0x000000018B3752F4
		private fsResult TryParseArray(out fsData arr); // 0x000000018B374328-0x000000018B3745E0
		private fsResult TryParseObject(out fsData obj); // 0x000000018B374C34-0x000000018B37503C
		private fsResult RunParse(out fsData data); // 0x000000018B373DDC-0x000000018B374120
		public static fsResult Parse(string input, out fsData data); // 0x000000018B373CF4-0x000000018B373DDC
		public static fsData Parse(string input); // 0x000000018B373C80-0x000000018B373CF4
		private bool IsHex(char c); // 0x000000018B3739A8-0x000000018B3739D0
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x000000018B373BB8-0x000000018B373BFC
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x000000018B373BFC-0x000000018B373C80
		private fsResult TryUnescapeChar(out char escaped); // 0x000000018B3753F4-0x000000018B3758EC
	}

	public static class fsJsonPrinter // TypeDefIndex: 59170
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x000000018B376BE4-0x000000018B376C50
		private static string EscapeString(string str); // 0x000000018B376928-0x000000018B376BE4
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x000000018B375978-0x000000018B375F50
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x000000018B375F50-0x000000018B376690
		public static string PrettyJson(fsData data); // 0x000000018B376C50-0x000000018B376DB0
		public static string CompressedJson(fsData data); // 0x000000018B376690-0x000000018B3767EC
		private static string ConvertDoubleToString(double d); // 0x000000018B3767EC-0x000000018B376928
	}

	public enum fsMemberSerialization // TypeDefIndex: 59171
	{
		OptIn = 0,
		OptOut = 1,
		Default = 2
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class fsObjectAttribute : Attribute // TypeDefIndex: 59172
	{
		// Fields
		public System.Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public System.Type Converter; // 0x28
		public System.Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute(); // 0x0000000184D91810-0x0000000184D91820
		public fsObjectAttribute(string versionString, params System.Type[] previousModels); // 0x000000018B3796C0-0x000000018B3796F0
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 59173
	{
		// Constructors
		protected fsObjectProcessor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual bool CanProcess(System.Type type); // 0x000000018B3796F0-0x000000018B37973C
		public virtual void OnBeforeSerialize(System.Type storageType, object instance); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnAfterDeserialize(System.Type storageType, object instance); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class fsPropertyAttribute : Attribute // TypeDefIndex: 59174
	{
		// Fields
		public string Name; // 0x10
		public System.Type Converter; // 0x18
	
		// Constructors
		public fsPropertyAttribute(string name); // 0x00000001853908C0-0x00000001853908D0
	}

	public struct fsResult // TypeDefIndex: 59175
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x000000018961F480-0x000000018961F488 
		public bool Succeeded { get; } // 0x0000000184D883E0-0x0000000184D883F0 
		public bool HasWarnings { get; } // 0x000000018B37BD34-0x000000018B37BD80 
		public Exception AsException { get; } // 0x000000018B37BB3C-0x000000018B37BC54 
		public IEnumerable<string> RawMessages { get; } // 0x000000018B37BD80-0x000000018B37BDD8 
		public string FormattedMessages { get; } // 0x000000018B37BC54-0x000000018B37BD34 
	
		// Constructors
		static fsResult(); // 0x000000018B37BA9C-0x000000018B37BB3C
	
		// Methods
		public void AddMessage(string message); // 0x000000018B37B668-0x000000018B37B718
		public void AddMessages(fsResult result); // 0x000000018B37B718-0x000000018B37B7D0
		public fsResult Merge(fsResult other); // 0x000000018B37B908-0x000000018B37B9EC
		public static fsResult Warn(string warning); // 0x000000018B37B9EC-0x000000018B37BA9C
		public static fsResult Fail(string warning); // 0x000000018B37B85C-0x000000018B37B908
		public static fsResult operator +(fsResult a, fsResult b); // 0x000000018B37BDD8-0x000000018B37BE50
		public fsResult AssertSuccess(); // 0x000000018B37B7D0-0x000000018B37B85C
	}

	public class fsSerializer // TypeDefIndex: 59177
	{
		// Fields
		private readonly List<fsConverter> _availableConverters; // 0x10
		private readonly Dictionary<System.Type, fsDirectConverter> _availableDirectConverters; // 0x18
		private readonly List<fsObjectProcessor> _processors; // 0x20
		private readonly fsCyclicReferenceManager _references; // 0x28
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x30
		private readonly Dictionary<System.Type, System.Type> _abstractTypeRemap; // 0x38
		private Dictionary<System.Type, fsBaseConverter> _cachedConverterTypeInstances; // 0x40
		private Dictionary<System.Type, fsBaseConverter> _cachedConverters; // 0x48
		private Dictionary<System.Type, List<fsObjectProcessor>> _cachedProcessors; // 0x50
		public fsContext Context; // 0x58
		public fsConfig Config; // 0x60
		private static HashSet<string> _reservedKeywords; // 0x00
		private static readonly string Key_ObjectReference; // 0x08
		private static readonly string Key_ObjectDefinition; // 0x10
		private static readonly string Key_InstanceType; // 0x18
		private static readonly string Key_Version; // 0x20
		private static readonly string Key_Content; // 0x28
		internal static readonly string Key_UnitDefault; // 0x30
		internal static readonly string Key_UnitPosition; // 0x38
		internal static readonly string Key_UnitGuid; // 0x40
		internal static readonly string Key_UnitFormerType; // 0x48
		internal static readonly string Key_UnitFormerValue; // 0x50
		internal static readonly string TypeName_Unit; // 0x58
		private static readonly System.Type Type_Unit; // 0x60
		internal static readonly string TypeName_MissingType; // 0x68
		private static readonly System.Type Type_MissingType; // 0x70
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 59176
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x000000018B3778D4-0x000000018B377994
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x000000018B377570-0x000000018B3776C0
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x000000018B3776C0-0x000000018B3778D4
			public void Clear(); // 0x000000018B377508-0x000000018B377570
		}
	
		// Constructors
		public fsSerializer(); // 0x000000018B380B84-0x000000018B3815DC
		static fsSerializer(); // 0x000000018B380638-0x000000018B380B84
	
		// Methods
		private void RemapAbstractStorageTypeToDefaultType(ref System.Type storageType); // 0x000000018B37FC30-0x000000018B37FDC0
		public void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType); // 0x000000018B37FDC0-0x000000018B37FEBC
		private List<fsObjectProcessor> GetProcessors(System.Type type); // 0x000000018B37DB94-0x000000018B37DDF0
		public void AddConverter(fsBaseConverter converter); // 0x000000018B37C34C-0x000000018B37C5D0
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType); // 0x000000018B37C9A8-0x000000018B37CD98
		public fsResult TrySerialize<T>(T instance, out fsData data);
		public fsResult TryDeserialize<T>(fsData data, ref ref T instance);
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data); // 0x000000018B3805F8-0x000000018B380638
		public fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data); // 0x000000018B38025C-0x000000018B3805F8
		private fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data); // 0x000000018B37EAC0-0x000000018B37EE7C
		private fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data); // 0x000000018B37EE7C-0x000000018B37F118
		private fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, object instance, out fsData data); // 0x000000018B37F118-0x000000018B37F328
		private fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, object instance, out fsData data); // 0x000000018B37F328-0x000000018B37F3E0
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result); // 0x000000018B380220-0x000000018B38025C
		public fsResult TryDeserialize(fsData data, System.Type storageType, System.Type overrideConverterType, ref object result); // 0x000000018B37FEBC-0x000000018B380220
		private fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018B37DDF0-0x000000018B37DFA4
		private fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018B37DFA4-0x000000018B37E418
		private fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018B37E418-0x000000018B37E850
		private fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result); // 0x000000018B37E850-0x000000018B37E990
		private fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result); // 0x000000018B37E990-0x000000018B37EAC0
		private static System.Type GetDataType(ref fsData data, System.Type defaultType, ref fsResult deserializeResult); // 0x000000018B37CD98-0x000000018B37DB94
		private static void EnsureDictionary(fsData data); // 0x000000018B37C8F4-0x000000018B37C9A8
		public static bool IsReservedKeyword(string key); // 0x000000018B37F808-0x000000018B37F878
		private static bool IsObjectReference(fsData data); // 0x000000018B37F770-0x000000018B37F808
		private static bool IsObjectDefinition(fsData data); // 0x000000018B37F6D8-0x000000018B37F770
		private static bool IsVersioned(fsData data); // 0x000000018B37F910-0x000000018B37F9A8
		private static bool IsTypeSpecified(fsData data); // 0x000000018B37F878-0x000000018B37F910
		private static bool IsWrappedData(fsData data); // 0x000000018B37FB98-0x000000018B37FC30
		private static bool IsVisualScriptingUnit(fsData data); // 0x000000018B37F9A8-0x000000018B37FB98
		private static void ConvertLegacyData(ref fsData data); // 0x000000018B37C5D0-0x000000018B37C8F4
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018B37F63C-0x000000018B37F6D8
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018B37F478-0x000000018B37F524
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data); // 0x000000018B37F5D0-0x000000018B37F63C
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018B37F524-0x000000018B37F5D0
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018B37F3E0-0x000000018B37F478
	}

	public class fsMetaProperty // TypeDefIndex: 59178
	{
		// Fields
		internal MemberInfo _memberInfo; // 0x10
		[CompilerGenerated]
		private System.Type _StorageType_k__BackingField; // 0x18
		[CompilerGenerated]
		private System.Type _OverrideConverterType_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _CanRead_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _CanWrite_k__BackingField; // 0x29
		[CompilerGenerated]
		private string _JsonName_k__BackingField; // 0x30
		[CompilerGenerated]
		private string _MemberName_k__BackingField; // 0x38
		[CompilerGenerated]
		private bool _IsPublic_k__BackingField; // 0x40
		[CompilerGenerated]
		private bool _IsReadOnly_k__BackingField; // 0x41
	
		// Properties
		public System.Type StorageType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public System.Type OverrideConverterType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool CanRead { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public bool CanWrite { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		public string JsonName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public string MemberName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public bool IsPublic { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public bool IsReadOnly { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86F40-0x0000000184D86F50 0x0000000184D86F60-0x0000000184D86F70
	
		// Constructors
		internal fsMetaProperty(fsConfig config, System.Reflection.FieldInfo field); // 0x000000018B377E4C-0x000000018B377EF0
		internal fsMetaProperty(fsConfig config, PropertyInfo property); // 0x000000018B377D2C-0x000000018B377E4C
	
		// Methods
		private void CommonInitialize(fsConfig config); // 0x000000018B377994-0x000000018B377A6C
		public void Write(object context, object value); // 0x000000018B377B34-0x000000018B377D2C
		public object Read(object context); // 0x000000018B377A6C-0x000000018B377B34
	}

	public class fsMetaType // TypeDefIndex: 59182
	{
		// Fields
		public System.Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		private bool? _hasDefaultConstructorCache; // 0x19
		private bool _isDefaultConstructorPublic; // 0x1B
		[CompilerGenerated]
		private fsMetaProperty[] _Properties_k__BackingField; // 0x20
		private static Dictionary<fsConfig, Dictionary<System.Type, fsMetaType>> _configMetaTypes; // 0x00
	
		// Properties
		public fsMetaProperty[] Properties { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool HasDefaultConstructor { get; } // 0x000000018B3792EC-0x000000018B379458 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 59179
		{
			// Fields
			public MemberInfo member; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CollectProperties_b__0(System.Type t); // 0x000000018B36C8D0-0x000000018B36C924
			internal bool _CollectProperties_b__1(System.Type t); // 0x000000018B36C924-0x000000018B36C978
			internal bool _CollectProperties_b__2(System.Type t); // 0x000000018B36C978-0x000000018B36C9CC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 59180
		{
			// Fields
			public PropertyInfo property; // 0x10
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CanSerializeProperty_b__0(System.Type t); // 0x000000018B36C9CC-0x000000018B36CA20
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 59181
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CanSerializeField_b__0(System.Type t); // 0x000000018B36CA20-0x000000018B36CA74
		}
	
		// Constructors
		private fsMetaType(fsConfig config, System.Type reflectedType); // 0x000000018B37920C-0x000000018B3792EC
		static fsMetaType(); // 0x000000018B379180-0x000000018B37920C
	
		// Methods
		public bool EmitAotData(); // 0x000000018B378D38-0x000000018B378E10
		public object CreateInstance(); // 0x000000018B37882C-0x000000018B378D38
		public static fsMetaType Get(fsConfig config, System.Type type); // 0x000000018B378E10-0x000000018B3790B8
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, System.Type reflectedType); // 0x000000018B3783A4-0x000000018B37882C
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members); // 0x000000018B3790B8-0x000000018B379180
		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue); // 0x000000018B3780D0-0x000000018B3783A4
		private static bool CanSerializeField(fsConfig config, System.Reflection.FieldInfo field, bool annotationFreeValue); // 0x000000018B377EF0-0x000000018B3780D0
	}

	public static class fsReflectionUtility // TypeDefIndex: 59183
	{
		// Methods
		public static System.Type GetInterface(System.Type type, System.Type interfaceType); // 0x000000018B37B4A0-0x000000018B37B668
	}
}

namespace Unity.VisualScripting.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 59185
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 59184
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x00000001841E1670-0x00000001841E1680
			static ObjectReferenceEqualityComparator(); // 0x000000018B36C71C-0x000000018B36C780
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x000000018829C278-0x000000018829C280
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000184DA3AC0-0x0000000184DA3AD0
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x000000018B36EB5C-0x000000018B36EC50
	
		// Methods
		public void Enter(); // 0x0000000184D9EBD0-0x0000000184D9EBE0
		public bool Exit(); // 0x000000018B36E6A8-0x000000018B36E80C
		public object GetReferenceObject(int id); // 0x000000018B36E8B4-0x000000018B36E9BC
		public void AddReferenceWithId(int id, object reference); // 0x000000018B36E644-0x000000018B36E6A8
		public int GetReferenceId(object item); // 0x000000018B36E80C-0x000000018B36E8B4
		public bool IsReference(object item); // 0x000000018B36E9BC-0x000000018B36EA2C
		public void MarkSerialized(object item); // 0x000000018B36EA2C-0x000000018B36EB5C
	}

	public struct fsOption<T> // TypeDefIndex: 59186
	{
		// Fields
		private bool _hasValue;
		private T _value;
	
		// Properties
		public bool HasValue { get; }
		public bool IsEmpty { get; }
		public T Value { get; }
	
		// Constructors
		public fsOption(T value);
	}

	public static class fsOption // TypeDefIndex: 59187
	{
		// Methods
		public static fsOption<T> Just<T>(T value);
	}

	public static class fsPortableReflection // TypeDefIndex: 59190
	{
		// Fields
		public static System.Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static System.Reflection.BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 59188
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public System.Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 59189
		{
			// Constructors
			public AttributeQueryComparator(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y); // 0x000000018B36C66C-0x000000018B36C6D0
			public int GetHashCode(AttributeQuery obj); // 0x000000018B36C6D0-0x000000018B36C71C
		}
	
		// Constructors
		static fsPortableReflection(); // 0x000000018B379E38-0x000000018B379F4C
	
		// Methods
		public static bool HasAttribute(MemberInfo element, System.Type attributeType); // 0x000000018B379DE4-0x000000018B379E38
		public static bool HasAttribute(MemberInfo element, System.Type attributeType, bool shouldCache); // 0x000000018539131C-0x0000000185391328
		public static Attribute GetAttribute(MemberInfo element, System.Type attributeType, bool shouldCache); // 0x000000018B37973C-0x000000018B3798A4
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute;
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute;
	
		// Extension methods
		public static PropertyInfo GetDeclaredProperty(this System.Type type, string propertyName); // 0x000000018B379C30-0x000000018B379CE4
		public static MethodInfo GetDeclaredMethod(this System.Type type, string methodName); // 0x000000018B379AC4-0x000000018B379B78
		public static ConstructorInfo GetDeclaredConstructor(this System.Type type, System.Type[] parameters); // 0x000000018B3798A4-0x000000018B3799A8
		public static ConstructorInfo[] GetDeclaredConstructors(this System.Type type); // 0x000000018B3799A8-0x000000018B379A0C
		public static MethodInfo GetFlattenedMethod(this System.Type type, string methodName); // 0x000000018B379CE4-0x000000018B379DE4
		public static MethodInfo[] GetDeclaredMethods(this System.Type type); // 0x000000018B379B78-0x000000018B379BD4
		public static PropertyInfo[] GetDeclaredProperties(this System.Type type); // 0x000000018B379BD4-0x000000018B379C30
		public static System.Reflection.FieldInfo[] GetDeclaredFields(this System.Type type); // 0x000000018B379A0C-0x000000018B379A68
		public static MemberInfo[] GetDeclaredMembers(this System.Type type); // 0x000000018B379A68-0x000000018B379AC4
		public static System.Type Resolve(this System.Type type); // 0x000000018464E630-0x000000018464E640
	}

	public static class fsTypeExtensions // TypeDefIndex: 59192
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 59191
		{
			// Fields
			public bool includeNamespace; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _CSharpName_b__0(System.Type t); // 0x000000018B36CA74-0x000000018B36CA88
		}
	
		// Extension methods
		public static string CSharpName(this System.Type type); // 0x000000018B381E24-0x000000018B381E30
		public static string CSharpName(this System.Type type, bool includeNamespace); // 0x000000018B3818C8-0x000000018B381E24
	}

	public struct fsVersionedType // TypeDefIndex: 59193
	{
		// Fields
		public fsVersionedType[] Ancestors; // 0x00
		public string VersionString; // 0x08
		public System.Type ModelType; // 0x10
	
		// Methods
		public object Migrate(object ancestorInstance); // 0x000000018B382B10-0x000000018B382B9C
		public override string ToString(); // 0x000000018B382B9C-0x000000018B382CDC
		public override bool Equals(object obj); // 0x000000018B382A94-0x000000018B382B10
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
	}

	public static class fsVersionManager // TypeDefIndex: 59194
	{
		// Fields
		private static readonly Dictionary<System.Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager(); // 0x000000018B382A08-0x000000018B382A94
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path); // 0x000000018B381F58-0x000000018B382190
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current); // 0x000000018B381E30-0x000000018B381F58
		public static fsOption<fsVersionedType> GetVersionedType(System.Type type); // 0x000000018B382190-0x000000018B382614
		private static void VerifyConstructors(fsVersionedType type); // 0x000000018B382614-0x000000018B38279C
		private static void VerifyUniqueVersionStrings(fsVersionedType type); // 0x000000018B38279C-0x000000018B382A08
	}
}
