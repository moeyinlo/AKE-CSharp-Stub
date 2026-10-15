/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using SRF;
using SRF.Components;
using SRF.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 67: StompyRobot.SRF.dll - Assembly: StompyRobot.SRF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89387-89476

public static class SRDebugUtil // TypeDefIndex: 89388
{
	// Fields
	public const int LineBufferCount = 512; // Metadata: 0x02648B77
	[CompilerGenerated]
	private static bool _IsFixedUpdate_k__BackingField; // 0x00

	// Properties
	public static bool IsFixedUpdate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018CE7DD7C-0x000000018CE7DDB4 0x000000018CE7DDB4-0x000000018CE7DDF0

	// Methods
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null); // 0x000000018CE7DAF0-0x000000018CE7DC74
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null); // 0x000000018CE7DC74-0x000000018CE7DD6C
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null); // 0x000000018CE7DD6C-0x000000018CE7DD74
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null); // 0x000000018CE7DD74-0x000000018CE7DD7C
}

public static class SRFileUtil // TypeDefIndex: 89389
{
	// Methods
	public static void DeleteDirectory(string path); // 0x000000018CE7E414-0x000000018CE7E4A8
	public static string GetBytesReadable(long i); // 0x0000000186DBA910-0x0000000186DBAA60
}

public static class SRInstantiate // TypeDefIndex: 89390
{
	// Methods
	public static T Instantiate<T>(T prefab)
		where T : UnityEngine.Component;
	public static GameObject Instantiate(GameObject prefab); // 0x000000018CE7E4A8-0x000000018CE7E4FC
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation)
		where T : UnityEngine.Component;
}

public static class SRMath // TypeDefIndex: 89393
{
	// Nested types
	public enum EaseType // TypeDefIndex: 89391
	{
		Linear = 0,
		QuadEaseOut = 1,
		QuadEaseIn = 2,
		QuadEaseInOut = 3,
		QuadEaseOutIn = 4,
		ExpoEaseOut = 5,
		ExpoEaseIn = 6,
		ExpoEaseInOut = 7,
		ExpoEaseOutIn = 8,
		CubicEaseOut = 9,
		CubicEaseIn = 10,
		CubicEaseInOut = 11,
		CubicEaseOutIn = 12,
		QuartEaseOut = 13,
		QuartEaseIn = 14,
		QuartEaseInOut = 15,
		QuartEaseOutIn = 16,
		QuintEaseOut = 17,
		QuintEaseIn = 18,
		QuintEaseInOut = 19,
		QuintEaseOutIn = 20,
		CircEaseOut = 21,
		CircEaseIn = 22,
		CircEaseInOut = 23,
		CircEaseOutIn = 24,
		SineEaseOut = 25,
		SineEaseIn = 26,
		SineEaseInOut = 27,
		SineEaseOutIn = 28,
		ElasticEaseOut = 29,
		ElasticEaseIn = 30,
		ElasticEaseInOut = 31,
		ElasticEaseOutIn = 32,
		BounceEaseOut = 33,
		BounceEaseIn = 34,
		BounceEaseInOut = 35,
		BounceEaseOutIn = 36,
		BackEaseOut = 37,
		BackEaseIn = 38,
		BackEaseInOut = 39,
		BackEaseOutIn = 40
	}

	private static class TweenFunctions // TypeDefIndex: 89392
	{
		// Methods
		public static float Linear(float t, float b, float c, float d); // 0x000000018CE82D18-0x000000018CE82D28
		public static float ExpoEaseOut(float t, float b, float c, float d); // 0x000000018CE82CB0-0x000000018CE82D18
		public static float ExpoEaseIn(float t, float b, float c, float d); // 0x000000018CE82BEC-0x000000018CE82C4C
		public static float ExpoEaseInOut(float t, float b, float c, float d); // 0x000000018CE82B3C-0x000000018CE82BEC
		public static float ExpoEaseOutIn(float t, float b, float c, float d); // 0x000000018CE82C4C-0x000000018CE82CB0
		public static float CircEaseOut(float t, float b, float c, float d); // 0x000000018CE82698-0x000000018CE826E4
		public static float CircEaseIn(float t, float b, float c, float d); // 0x000000018CE8259C-0x000000018CE825F8
		public static float CircEaseInOut(float t, float b, float c, float d); // 0x000000018CE82508-0x000000018CE8259C
		public static float CircEaseOutIn(float t, float b, float c, float d); // 0x000000018CE825F8-0x000000018CE82698
		public static float QuadEaseOut(float t, float b, float c, float d); // 0x000000018CE82E20-0x000000018CE82E44
		public static float QuadEaseIn(float t, float b, float c, float d); // 0x000000018CE82D88-0x000000018CE82DA0
		public static float QuadEaseInOut(float t, float b, float c, float d); // 0x000000018CE82D28-0x000000018CE82D88
		public static float QuadEaseOutIn(float t, float b, float c, float d); // 0x000000018CE82DA0-0x000000018CE82E20
		public static float SineEaseOut(float t, float b, float c, float d); // 0x000000018CE832C0-0x000000018CE832FC
		public static float SineEaseIn(float t, float b, float c, float d); // 0x000000018CE831C8-0x000000018CE83214
		public static float SineEaseInOut(float t, float b, float c, float d); // 0x000000018CE83134-0x000000018CE831C8
		public static float SineEaseOutIn(float t, float b, float c, float d); // 0x000000018CE83214-0x000000018CE832C0
		public static float CubicEaseOut(float t, float b, float c, float d); // 0x000000018CE82800-0x000000018CE8282C
		public static float CubicEaseIn(float t, float b, float c, float d); // 0x000000018CE82754-0x000000018CE82770
		public static float CubicEaseInOut(float t, float b, float c, float d); // 0x000000018CE826E4-0x000000018CE82754
		public static float CubicEaseOutIn(float t, float b, float c, float d); // 0x000000018CE82770-0x000000018CE82800
		public static float QuartEaseOut(float t, float b, float c, float d); // 0x000000018CE82F84-0x000000018CE82FBC
		public static float QuartEaseIn(float t, float b, float c, float d); // 0x000000018CE82EC4-0x000000018CE82EE4
		public static float QuartEaseInOut(float t, float b, float c, float d); // 0x000000018CE82E44-0x000000018CE82EC4
		public static float QuartEaseOutIn(float t, float b, float c, float d); // 0x000000018CE82EE4-0x000000018CE82F84
		public static float QuintEaseOut(float t, float b, float c, float d); // 0x000000018CE83100-0x000000018CE83134
		public static float QuintEaseIn(float t, float b, float c, float d); // 0x000000018CE8303C-0x000000018CE83060
		public static float QuintEaseInOut(float t, float b, float c, float d); // 0x000000018CE82FBC-0x000000018CE8303C
		public static float QuintEaseOutIn(float t, float b, float c, float d); // 0x000000018CE83060-0x000000018CE83100
		public static float ElasticEaseOut(float t, float b, float c, float d); // 0x000000018CE82A7C-0x000000018CE82B3C
		public static float ElasticEaseIn(float t, float b, float c, float d); // 0x000000018CE8294C-0x000000018CE82A18
		public static float ElasticEaseInOut(float t, float b, float c, float d); // 0x000000018CE8282C-0x000000018CE8294C
		public static float ElasticEaseOutIn(float t, float b, float c, float d); // 0x000000018CE82A18-0x000000018CE82A7C
		public static float BounceEaseOut(float t, float b, float c, float d); // 0x000000018CE82434-0x000000018CE82508
		public static float BounceEaseIn(float t, float b, float c, float d); // 0x000000018CE82354-0x000000018CE823A0
		public static float BounceEaseInOut(float t, float b, float c, float d); // 0x000000018CE822BC-0x000000018CE82354
		public static float BounceEaseOutIn(float t, float b, float c, float d); // 0x000000018CE823A0-0x000000018CE82434
		public static float BackEaseOut(float t, float b, float c, float d); // 0x000000018CE82280-0x000000018CE822BC
		public static float BackEaseIn(float t, float b, float c, float d); // 0x000000018CE821A4-0x000000018CE821D0
		public static float BackEaseInOut(float t, float b, float c, float d); // 0x000000018CE8211C-0x000000018CE821A4
		public static float BackEaseOutIn(float t, float b, float c, float d); // 0x000000018CE821D0-0x000000018CE82280
	}

	// Methods
	public static float LerpUnclamped(float from, float to, float t); // 0x0000000187257E80-0x0000000187257EA0
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t); // 0x0000000187257E20-0x0000000187257E80
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2); // 0x000000018CE7EC4C-0x000000018CE7ECBC
	public static float WrapAngle(float angle); // 0x000000018CE7EFD8-0x000000018CE7F000
	public static float NearestAngle(float to, float angle1, float angle2); // 0x000000018CE7ECBC-0x000000018CE7ED2C
	public static int Wrap(int max, int value); // 0x000000018CE7F000-0x000000018CE7F094
	public static float Wrap(float max, float value); // 0x000000018CE7F094-0x000000018CE7F0B8
	public static float Average(float v1, float v2); // 0x0000000187257E10-0x0000000187257E20
	public static float Angle(Vector2 direction); // 0x000000018CE7E4FC-0x000000018CE7E5C0
	public static float Ease(float from, float to, float t, EaseType type); // 0x000000018CE7E5C0-0x000000018CE7EC4C
	public static float SpringLerp(float strength, float deltaTime); // 0x000000018CE7EF10-0x000000018CE7EF60
	public static float SpringLerp(float from, float to, float strength, float deltaTime); // 0x000000018CE7EED0-0x000000018CE7EF10
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime); // 0x000000018CE7EE48-0x000000018CE7EED0
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime); // 0x000000018CE7EF60-0x000000018CE7EFD8
	public static float SmoothClamp(float value, float min, float max, float scrollMax, EaseType easeType = EaseType.ExpoEaseOut /* Metadata: 0x02648B79 */); // 0x000000018CE7ED2C-0x000000018CE7EE48
}

namespace SRF
{
	public static class Json // TypeDefIndex: 89397
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 89395
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x02648BA3
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get; } // 0x000000018CE7CD08-0x000000018CE7CD64 
			private char NextChar { get; } // 0x000000018CE7C9C8-0x000000018CE7CA24 
			private string NextWord { get; } // 0x000000018CE7CC58-0x000000018CE7CD08 
			private TOKEN NextToken { get; } // 0x000000018CE7CA24-0x000000018CE7CC58 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 89394
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}
	
			// Constructors
			private Parser(string jsonString); // 0x000000018CE7C950-0x000000018CE7C9C8
	
			// Methods
			public void Dispose(); // 0x000000018C17321C-0x000000018C173254
			public static bool IsWordBreak(char c); // 0x000000018CE7C214-0x000000018CE7C28C
			public static object Parse(string jsonString); // 0x000000018CE7C848-0x000000018CE7C950
			private Dictionary<string, object> ParseObject(); // 0x000000018CE7C4D8-0x000000018CE7C5E4
			private List<object> ParseArray(); // 0x000000018CE7C28C-0x000000018CE7C354
			private object ParseValue(); // 0x000000018CE7C824-0x000000018CE7C848
			private object ParseByToken(TOKEN token); // 0x000000018CE7C354-0x000000018CE7C410
			private string ParseString(); // 0x000000018CE7C5E4-0x000000018CE7C824
			private object ParseNumber(); // 0x000000018CE7C410-0x000000018CE7C4D8
			private void EatWhitespace(); // 0x000000018CE7C184-0x000000018CE7C214
		}
	
		private sealed class Serializer // TypeDefIndex: 89396
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer(); // 0x000000018CE81404-0x000000018CE81468
	
			// Methods
			public static string Serialize(object obj); // 0x000000018CE8138C-0x000000018CE81404
			private void SerializeValue(object value); // 0x000000018CE81208-0x000000018CE8138C
			private void SerializeObject(IDictionary obj); // 0x000000018CE80920-0x000000018CE80D1C
			private void SerializeArray(IList anArray); // 0x000000018CE805A4-0x000000018CE80920
			private void SerializeString(string str); // 0x000000018CE80F7C-0x000000018CE81208
			private void SerializeOther(object value); // 0x000000018CE80D1C-0x000000018CE80F7C
		}
	
		// Methods
		public static object Deserialize(string json); // 0x000000018CE7BE00-0x000000018CE7BE1C
		public static string Serialize(object obj); // 0x000000018CE7BE1C-0x000000018CE7BE24
	}

	[Serializable]
	public class SRList<T> : IList<T>, ISerializationCallbackReceiver // TypeDefIndex: 89399
	{
		// Fields
		[SerializeField]
		private T[] _buffer;
		[SerializeField]
		private int _count;
		private EqualityComparer<T> _equalityComparer;
		private ReadOnlyCollection<T> _readOnlyWrapper;
	
		// Properties
		public T[] Buffer { get; private set; }
		private EqualityComparer<T> EqualityComparer { get; }
		public int Count { get; private set; }
		public bool IsReadOnly { get; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__15 : IEnumerator<T> // TypeDefIndex: 89398
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public SRList<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SRList();
		public SRList(int capacity);
		public SRList(IEnumerable<T> source);
	
		// Methods
		[IteratorStateMachine(typeof(_GetEnumerator_d__15))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public void Add(T item);
		public void Clear();
		public bool Contains(T item);
		public void CopyTo(T[] array, int arrayIndex);
		public bool Remove(T item);
		public int IndexOf(T item);
		public void Insert(int index, T item);
		public void RemoveAt(int index);
		public void OnBeforeSerialize();
		public void OnAfterDeserialize();
		public void AddRange(IEnumerable<T> range);
		public void Clear(bool clean);
		public void Clean();
		public ReadOnlyCollection<T> AsReadOnly();
		private void Expand();
		public void Trim();
		public void Sort(Comparison<T> comparer);
	}

	public abstract class SRMonoBehaviour : MonoBehaviour // TypeDefIndex: 89400
	{
		// Fields
		private Collider _collider; // 0x18
		private Transform _transform; // 0x20
		private Rigidbody _rigidBody; // 0x28
		private GameObject _gameObject; // 0x30
		private Rigidbody2D _rigidbody2D; // 0x38
		private Collider2D _collider2D; // 0x40
	
		// Properties
		public Transform CachedTransform { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x0000000186FB0060-0x0000000186FB0110 
		public Collider CachedCollider { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018CE7F170-0x000000018CE7F1F4 
		public Collider2D CachedCollider2D { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018CE7F0EC-0x000000018CE7F170 
		public Rigidbody CachedRigidBody { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018CE7F278-0x000000018CE7F2FC 
		public Rigidbody2D CachedRigidBody2D { [DebuggerStepThrough] [DebuggerNonUserCode] get; } // 0x000000018CE7F1F4-0x000000018CE7F278 
		public GameObject CachedGameObject { [DebuggerStepThrough] [DebuggerNonUserCode] get; } // 0x0000000186CFB8B0-0x0000000186CFB960 
		public new Transform transform { get; } // 0x000000018CE7F2FC-0x000000018CE7F304 
	
		// Constructors
		protected SRMonoBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, string fieldName = null); // 0x000000018CE7F0B8-0x000000018CE7F0D0
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, string message = null); // 0x000000018CE7F0D0-0x000000018CE7F0EC
		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, string fieldName = null); // 0x000000018CE7F0B8-0x000000018CE7F0D0
		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, string message = null); // 0x000000018CE7F0D0-0x000000018CE7F0EC
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class RequiredFieldAttribute : Attribute // TypeDefIndex: 89401
	{
		// Fields
		private bool _autoCreate; // 0x10
		private bool _autoSearch; // 0x11
		private bool _editorOnly; // 0x12
	
		// Properties
		public bool AutoSearch { get; set; } // 0x0000000187235410-0x0000000187235420 0x0000000187235420-0x0000000187235430
		public bool AutoCreate { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		[Obsolete]
		public bool EditorOnly { get; set; } // 0x0000000187235CB0-0x0000000187235CC0 0x000000018724EB70-0x000000018724EB80
	
		// Constructors
		public RequiredFieldAttribute(bool autoSearch); // 0x0000000187257E00-0x0000000187257E10
		public RequiredFieldAttribute(); // 0x0000000187247950-0x0000000187247960
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ImportAttribute : Attribute // TypeDefIndex: 89402
	{
		// Fields
		public readonly System.Type Service; // 0x10
	
		// Constructors
		public ImportAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public ImportAttribute(System.Type serviceType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public abstract class SRMonoBehaviourEx : SRMonoBehaviour // TypeDefIndex: 89404
	{
		// Fields
		private static Dictionary<System.Type, IList<FieldInfo>> _checkedFields; // 0x00
	
		// Nested types
		private struct FieldInfo // TypeDefIndex: 89403
		{
			// Fields
			public bool AutoCreate; // 0x00
			public bool AutoSet; // 0x01
			public System.Reflection.FieldInfo Field; // 0x08
			public bool Import; // 0x10
			public System.Type ImportType; // 0x18
		}
	
		// Constructors
		protected SRMonoBehaviourEx(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false /* Metadata: 0x02648BB7 */); // 0x0000000186A6E7E0-0x0000000186A6E980
		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet); // 0x0000000186A6EB20-0x0000000186A6EC10
		private static List<FieldInfo> ScanType(System.Type t); // 0x0000000186A6E980-0x0000000186A6EB20
		protected virtual void Awake(); // 0x000000018783D824-0x000000018783D830
		protected virtual void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void FixedUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class Coroutines // TypeDefIndex: 89406
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForSecondsRealTime_d__0 : IEnumerator<object> // TypeDefIndex: 89405
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float time; // 0x20
			private float _endTime_5__2; // 0x24
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForSecondsRealTime_d__0(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE83658-0x000000018CE836C4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE836C4-0x000000018CE83710
		}
	
		// Methods
		[IteratorStateMachine(typeof(_WaitForSecondsRealTime_d__0))]
		public static IEnumerator WaitForSecondsRealTime(float time); // 0x000000018CE7A8B8-0x000000018CE7A910
	}

	public static class SRFFloatExtensions // TypeDefIndex: 89407
	{
		// Extension methods
		public static float Sqr(this float f); // 0x00000001872355E0-0x00000001872355F0
		public static float SqrRt(this float f); // 0x0000000187235570-0x0000000187235590
		public static bool ApproxZero(this float f); // 0x000000018CE7DDF0-0x000000018CE7DE40
		public static bool Approx(this float f, float f2); // 0x00000001850277D0-0x0000000185027A80
	}

	public static class SRFGameObjectExtensions // TypeDefIndex: 89408
	{
		// Methods
		private static void SetLayerInternal(Transform t, int layer); // 0x000000018CE7DE40-0x000000018CE7DFDC
	
		// Extension methods
		public static T GetIComponent<T>(this GameObject t)
			where T : class;
		public static T GetComponentOrAdd<T>(this GameObject obj)
			where T : UnityEngine.Component;
		public static void RemoveComponentIfExists<T>(this GameObject obj)
			where T : UnityEngine.Component;
		public static void RemoveComponentsIfExists<T>(this GameObject obj)
			where T : UnityEngine.Component;
		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true /* Metadata: 0x02648BB8 */)
			where T : MonoBehaviour;
		public static void SetLayerRecursive(this GameObject o, int layer); // 0x000000018CE7DFDC-0x000000018CE7E008
	}

	public static class SRFIListExtensions // TypeDefIndex: 89409
	{
		// Extension methods
		public static T Random<T>(this IList<T> list);
		public static T RandomOrDefault<T>(this IList<T> list);
		public static T PopLast<T>(this IList<T> list);
	}

	public static class SRFStringExtensions // TypeDefIndex: 89410
	{
		// Extension methods
		public static string Fmt(this string formatString, params object[] args); // 0x000000018C8D1BFC-0x000000018C8D1C04
	}

	public static class SRFTransformExtensions // TypeDefIndex: 89412
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _GetChildren_d__0 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 89411
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform t; // 0x28
			public Transform __3__t; // 0x30
			private int _i_5__2; // 0x38
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetChildren_d__0(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE832FC-0x000000018CE83380
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE8341C-0x000000018CE83468
			[DebuggerHidden]
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x000000018CE83380-0x000000018CE83414
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CE83414-0x000000018CE8341C
		}
	
		// Extension methods
		[IteratorStateMachine(typeof(_GetChildren_d__0))]
		public static IEnumerable<Transform> GetChildren(this Transform t); // 0x000000018CE7E268-0x000000018CE7E2D8
		public static void ResetLocal(this Transform t); // 0x000000018CE7E360-0x000000018CE7E3F4
		public static GameObject CreateChild(this Transform t, string name); // 0x000000018CE7E008-0x000000018CE7E0D0
		public static void SetParentMaintainLocals(this Transform t, Transform parent); // 0x000000018CE7E3F4-0x000000018CE7E414
		public static void SetLocals(this Transform t, Transform from); // 0x000000018CE6C62C-0x000000018CE6C6E8
		public static void Match(this Transform t, Transform from); // 0x000000018CE7E2D8-0x000000018CE7E360
		public static void DestroyChildren(this Transform t); // 0x000000018CE7E0D0-0x000000018CE7E268
	}

	public class Hierarchy // TypeDefIndex: 89413
	{
		// Fields
		private static readonly char[] Seperator; // 0x00
		private static readonly Dictionary<string, Transform> Cache; // 0x08
	
		// Properties
		[Obsolete("Use static Get() instead")]
		public Transform this[string key] { get => default; } // 0x000000018CE7BC78-0x000000018CE7BCC4 
	
		// Constructors
		public Hierarchy(); // 0x0000000186805BA0-0x0000000186805BB0
		static Hierarchy(); // 0x0000000187085680-0x0000000187085770
	
		// Methods
		public static Transform Get(string key); // 0x00000001850D0620-0x00000001850D0820
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void RuntimeInitialize(); // 0x00000001871D13C0-0x00000001871D1440
	}
}

namespace SRF.Components
{
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour // TypeDefIndex: 89474
		where T : SRAutoSingleton<T>
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { [DebuggerStepThrough] get; }
		public static bool HasInstance { get; }
	
		// Constructors
		protected SRAutoSingleton();
	
		// Methods
		protected virtual void Awake();
		protected virtual void OnEnable();
		private void OnApplicationQuit();
	}

	public abstract class SRSingleton<T> : SRMonoBehaviour // TypeDefIndex: 89475
		where T : SRSingleton<T>
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { [DebuggerStepThrough] get; }
		public static bool HasInstance { [DebuggerStepThrough] get; }
	
		// Constructors
		protected SRSingleton();
	
		// Methods
		private void Register();
		protected virtual void Awake();
		protected virtual void OnEnable();
		private void OnApplicationQuit();
	}
}

namespace SRF.Helpers
{
	public static class AssetUtil // TypeDefIndex: 89464
	{
	}

	public sealed class MethodReference // TypeDefIndex: 89467
	{
		// Fields
		private readonly Func<object[], object> _method; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 89465
		{
			// Fields
			public MethodInfo method; // 0x10
			public object target; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _.ctor_b__0(object[] o); // 0x000000018CE83514-0x000000018CE83540
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 89466
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _op_Implicit_b__0(object[] args); // 0x000000018CE835D4-0x000000018CE835F4
		}
	
		// Constructors
		public MethodReference(object target, MethodInfo method); // 0x000000018CE7BFD4-0x000000018CE7C0B4
		public MethodReference(Func<object[], object> method); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public object Invoke(object[] parameters); // 0x000000018CE7BFB4-0x000000018CE7BFD4
		public static implicit operator MethodReference(Action action); // 0x000000018CE7C0B4-0x000000018CE7C184
	}

	public delegate void PropertyValueChangedHandler(PropertyReference property); // TypeDefIndex: 89468; 0x0000000185B78EA0-0x0000000185B78EB0

	public sealed class PropertyReference // TypeDefIndex: 89472
	{
		// Fields
		[CanBeNull]
		private readonly PropertyInfo _property; // 0x10
		[CanBeNull]
		private readonly object _target; // 0x18
		[CanBeNull]
		private readonly Attribute[] _attributes; // 0x20
		[CanBeNull]
		private readonly Func<object> _getter; // 0x28
		[CanBeNull]
		private readonly Action<object> _setter; // 0x30
		[CanBeNull]
		private List<PropertyValueChangedHandler> _valueChangedListeners; // 0x38
		[CompilerGenerated]
		private System.Type _PropertyType_k__BackingField; // 0x40
	
		// Properties
		public System.Type PropertyType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public bool CanRead { get; } // 0x0000000188BC4884-0x0000000188BC4890 
		public bool CanWrite { get; } // 0x000000018C1B5D60-0x000000018C1B5D6C 
	
		// Events
		public event PropertyValueChangedHandler ValueChanged {
			add; // 0x000000018CE7D304-0x000000018CE7D470
			remove; // 0x000000018CE7D470-0x000000018CE7D590
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0<T> // TypeDefIndex: 89469
		{
			// Fields
			public Action<T> setter;
			public Func<T> getter;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _FromLambda_b__0(object o);
			internal object _FromLambda_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 89470
		{
			// Fields
			public object target; // 0x10
			public PropertyInfo property; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _.ctor_b__0(); // 0x000000018CE834F0-0x000000018CE83500
			internal void _.ctor_b__1(object v); // 0x000000018CE83500-0x000000018CE83514
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__23<T> // TypeDefIndex: 89471
			where T : Attribute
		{
			// Fields
			public static readonly __c__23<T> __9;
			public static Func<Attribute, bool> __9__23_0;
	
			// Constructors
			static __c__23();
			public __c__23();
	
			// Methods
			internal bool _GetAttribute_b__23_0(Attribute p);
		}
	
		// Constructors
		public PropertyReference(object target, PropertyInfo property); // 0x000000018CE7D0B0-0x000000018CE7D284
		public PropertyReference(System.Type type, Func<object> getter = null, Action<object> setter = null, Attribute[] attributes = null); // 0x000000018CE7D284-0x000000018CE7D304
	
		// Methods
		public static PropertyReference FromLambda<T>(Func<T> getter, Action<T> setter = null, params Attribute[] attributes);
		public void NotifyValueChanged(); // 0x000000018CE7CD7C-0x000000018CE7CEA0
		public object GetValue(); // 0x000000018CE7CD64-0x000000018CE7CD7C
		public void SetValue(object value); // 0x000000018CE7CF1C-0x000000018CE7CF94
		public T GetAttribute<T>()
			where T : Attribute;
		private void OnTargetPropertyChanged(object sender, PropertyChangedEventArgs e); // 0x000000018CE7CEA0-0x000000018CE7CF1C
		public override string ToString(); // 0x000000018CE7CF94-0x000000018CE7D0B0
	}

	public static class SRReflection // TypeDefIndex: 89473
	{
		// Methods
		public static void SetPropertyValue(object obj, PropertyInfo p, object value); // 0x000000018CE7FADC-0x000000018CE7FB88
		public static object GetPropertyValue(object obj, PropertyInfo p); // 0x000000018CE7FAA0-0x000000018CE7FADC
		public static T GetAttribute<T>(MemberInfo t)
			where T : Attribute;
	}
}

namespace SRF.Internal
{
	internal static class ComponentMenuPaths // TypeDefIndex: 89476
	{
		// Fields
		public const string PathRoot = "SRF"; // Metadata: 0x02648BC7
		public const string SRServiceManager = "SRF/Service/Service Manager"; // Metadata: 0x02648BCB
		public const string BehavioursRoot = "SRF/Behaviours"; // Metadata: 0x02648BE7
		public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable"; // Metadata: 0x02648BF6
		public const string DontDestroyOnLoad = "SRF/Behaviours/Don\'t Destroy On Load"; // Metadata: 0x02648C18
		public const string MatchTransform = "SRF/Behaviours/Match Transform"; // Metadata: 0x02648C3D
		public const string LookAt = "SRF/Behaviours/LookAt"; // Metadata: 0x02648C5C
		public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction"; // Metadata: 0x02648C72
		public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)"; // Metadata: 0x02648C99
		public const string RuntimePosition = "SRF/Behaviours/Runtime Position"; // Metadata: 0x02648CCE
		public const string ScrollTexture = "SRF/Behaviours/Scroll Texture"; // Metadata: 0x02648CEE
		public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float"; // Metadata: 0x02648D0C
		public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)"; // Metadata: 0x02648D28
		public const string SpringFollow = "SRF/Behaviours/Spring Follow"; // Metadata: 0x02648D4A
		public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)"; // Metadata: 0x02648D67
		public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab"; // Metadata: 0x02648D8F
		public const string Velocity = "SRF/Behaviours/Velocity"; // Metadata: 0x02648DAB
		public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate"; // Metadata: 0x02648DC3
		public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera"; // Metadata: 0x02648DE3
		public const string ComponentsRoot = "SRF/Components"; // Metadata: 0x02648E07
		public const string SRLineRenderer = "SRF/Components/SRLineRenderer"; // Metadata: 0x02648E16
		public const string SelectionRoot = "SRF/Components/Selection Root"; // Metadata: 0x02648E34
		public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)"; // Metadata: 0x02648E52
		public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)"; // Metadata: 0x02648E78
		public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)"; // Metadata: 0x02648EA0
		public const string UIRoot = "SRF/UI"; // Metadata: 0x02648EC9
		public const string TiltOnTouch = "SRF/UI/Tilt On Touch"; // Metadata: 0x02648ED0
		public const string ScaleOnTouch = "SRF/UI/Scale On Touch"; // Metadata: 0x02648EE5
		public const string InheritColour = "SRF/UI/Inherit Colour"; // Metadata: 0x02648EFB
		public const string FlashGraphic = "SRF/UI/Flash Graphic"; // Metadata: 0x02648F11
		public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size"; // Metadata: 0x02648F26
		public const string CopyPreferredSizes = "SRF/UI/Copy Preferred Size (Multiple)"; // Metadata: 0x02648F41
		public const string CopyLayoutElement = "SRF/UI/Copy Layout Element"; // Metadata: 0x02648F67
		public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element"; // Metadata: 0x02648F82
		public const string SRText = "SRF/UI/SRText"; // Metadata: 0x02648FA7
		public const string Unselectable = "SRF/UI/Unselectable"; // Metadata: 0x02648FB5
		public const string LongPressButton = "SRF/UI/Long Press Button"; // Metadata: 0x02648FC9
		public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour"; // Metadata: 0x02648FE2
		public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group"; // Metadata: 0x02649004
		public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)"; // Metadata: 0x02649024
		public const string StyleRoot = "SRF/UI/Style Root"; // Metadata: 0x02649055
		public const string StyleComponent = "SRF/UI/Style Component"; // Metadata: 0x02649067
		public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)"; // Metadata: 0x0264907E
		public const string ResponsiveResize = "SRF/UI/Responsive (Resize)"; // Metadata: 0x02649099
		public const string RetinaScaler = "SRF/UI/Retina Scaler"; // Metadata: 0x026490B4
		public const string NumberButton = "SRF/UI/SRNumberButton"; // Metadata: 0x026490C9
		public const string NumberSpinner = "SRF/UI/SRNumberSpinner"; // Metadata: 0x026490DF
		public const string SRSpinner = "SRF/UI/Spinner"; // Metadata: 0x026490F6
		public const string ContentFitText = "SRF/UI/Content Fit Text"; // Metadata: 0x02649105
	}
}

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ServiceAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 89449
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public ServiceAttribute(System.Type serviceType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceSelectorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 89450
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public ServiceSelectorAttribute(System.Type serviceType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceConstructorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 89451
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public ServiceConstructorAttribute(System.Type serviceType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public interface IAsyncService // TypeDefIndex: 89452
	{
		// Properties
		bool IsLoaded { get; }
	}

	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 89454
		where T : class
	{
		// Fields
		private bool _isLoaded;
	
		// Properties
		protected abstract System.Type[] Dependencies { get; }
		public bool IsLoaded { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadDependencies_d__8 : IEnumerator<object> // TypeDefIndex: 89453
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SRDependencyServiceBase<T> __4__this;
			private System.Type[] __7__wrap1;
			private int __7__wrap2;
			private IAsyncService _a_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadDependencies_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		protected SRDependencyServiceBase();
	
		// Methods
		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target);
		protected override void Start();
		protected virtual void OnLoaded();
		[IteratorStateMachine(typeof(_LoadDependencies_d__8))]
		private IEnumerator LoadDependencies();
	}

	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 89456
		where T : class
		where TImpl : UnityEngine.Component
	{
		// Fields
		private TImpl _rootObject;
	
		// Properties
		protected abstract string SceneName { get; }
		protected TImpl RootObject { get; }
		public bool IsLoaded { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 89455
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SRSceneServiceBase<T, TImpl> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadCoroutine_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		protected SRSceneServiceBase();
	
		// Methods
		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target);
		protected override void Start();
		protected override void OnDestroy();
		protected virtual void OnLoaded();
		[IteratorStateMachine(typeof(_LoadCoroutine_d__11))]
		private IEnumerator LoadCoroutine();
	}

	public abstract class SRServiceBase<T> : SRMonoBehaviourEx // TypeDefIndex: 89457
		where T : class
	{
		// Constructors
		protected SRServiceBase();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
	}

	[AddComponentMenu("SRF/Service/Service Manager")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager> // TypeDefIndex: 89463
	{
		// Fields
		public const bool EnableLogging = false; // Metadata: 0x02648BC6
		public static int LoadingCount; // 0x00
		private static readonly List<Assembly> _assemblies; // 0x08
		private readonly SRList<Service> _services; // 0x48
		private List<ServiceStub> _serviceStubs; // 0x50
		private static bool _hasQuit; // 0x10
	
		// Properties
		public static bool IsLoading { get; } // 0x000000018CE7FEC4-0x000000018CE7FF0C 
	
		// Nested types
		private class Service // TypeDefIndex: 89458
		{
			// Fields
			public object Object; // 0x10
			public System.Type Type; // 0x18
	
			// Constructors
			public Service(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class ServiceStub // TypeDefIndex: 89459
		{
			// Fields
			public Func<object> Constructor; // 0x10
			public System.Type InterfaceType; // 0x18
			public Func<System.Type> Selector; // 0x20
			public System.Type Type; // 0x28
	
			// Constructors
			public ServiceStub(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override string ToString(); // 0x000000018CE81468-0x000000018CE815A8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89460
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ServiceStub, string> __9__21_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CE835F4-0x000000018CE83658
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _UpdateStubs_b__21_0(ServiceStub p); // 0x000000018CE83468-0x000000018CE834F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 89461
		{
			// Fields
			public ServiceSelectorAttribute attrib; // 0x10
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ScanTypeForSelectors_b__0(ServiceStub p); // 0x00000001870D2F40-0x00000001870D2FC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 89462
		{
			// Fields
			public ServiceConstructorAttribute attrib; // 0x10
			public MethodInfo m; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ScanTypeForConstructors_b__0(ServiceStub p); // 0x000000018CE83540-0x000000018CE835B0
			internal object _ScanTypeForConstructors_b__1(); // 0x000000018CE835B0-0x000000018CE835D4
		}
	
		// Constructors
		public SRServiceManager(); // 0x00000001870D2C20-0x00000001870D2CB0
		static SRServiceManager(); // 0x0000000187106170-0x0000000187106220
	
		// Methods
		public static void RegisterAssembly<TType>();
		public static T GetService<T>()
			where T : class;
		public static object GetService(System.Type t); // 0x000000018CE7FCCC-0x000000018CE7FE4C
		private static object GetServiceInternal(System.Type t); // 0x0000000185A04DD0-0x0000000185A05760
		public static bool HasService<T>()
			where T : class;
		public static bool HasService(System.Type t); // 0x0000000185A04B40-0x0000000185A04C70
		public static void RegisterService<T>(object service)
			where T : class;
		private static void RegisterService(System.Type t, object service); // 0x0000000185A049C0-0x0000000185A04B40
		public static void UnRegisterService<T>()
			where T : class;
		private static void UnRegisterService(System.Type t); // 0x0000000185A06050-0x0000000185A06140
		protected override void Awake(); // 0x0000000186CFB7D0-0x0000000186CFB8B0
		protected void UpdateStubs(); // 0x00000001854F6AC0-0x00000001854F7580
		protected object AutoCreateService(System.Type t); // 0x0000000185A05760-0x0000000185A05EA0
		protected new void OnApplicationQuit(); // 0x000000018CE7FE4C-0x000000018CE7FEC4
		private static object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType); // 0x0000000185A05EA0-0x0000000185A06050
		private void ScanType(System.Type type); // 0x00000001854F6690-0x00000001854F6770
		private static void ScanTypeForSelectors(System.Type t, List<ServiceStub> stubs); // 0x00000001854F6770-0x00000001854F69C0
		private static void ScanTypeForConstructors(System.Type t, List<ServiceStub> stubs); // 0x00000001854F69C0-0x00000001854F6A90
		private static MethodInfo[] GetStaticMethods(System.Type t); // 0x00000001854F6A90-0x00000001854F6AC0
	}
}

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Content Fit Text")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ContentFitText : UIBehaviour, ILayoutElement // TypeDefIndex: 89414
	{
		// Fields
		public SRText CopySource; // 0x18
		public Vector2 Padding; // 0x20
	
		// Properties
		public float minWidth { get; } // 0x000000018CE7A010-0x000000018CE7A094 
		public float preferredWidth { get; } // 0x000000018CE7A118-0x000000018CE7A19C 
		public float flexibleWidth { get; } // 0x000000018CE79F0C-0x000000018CE79F8C 
		public float minHeight { get; } // 0x000000018CE79F8C-0x000000018CE7A010 
		public float preferredHeight { get; } // 0x000000018CE7A094-0x000000018CE7A118 
		public float flexibleHeight { get; } // 0x000000018CE79E8C-0x000000018CE79F0C 
		public int layoutPriority { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public ContentFitText(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x000000018CE79CAC-0x000000018CE79CC4
		public void CalculateLayoutInputVertical(); // 0x000000018CE79CAC-0x000000018CE79CC4
		protected override void OnEnable(); // 0x000000018CE79D68-0x000000018CE79E04
		private void CopySourceOnLayoutDirty(SRText srText); // 0x000000018CE79CC4-0x000000018CE79CCC
		protected override void OnTransformParentChanged(); // 0x000000018CE79CC4-0x000000018CE79CCC
		protected override void OnDisable(); // 0x000000018CE79CCC-0x000000018CE79D68
		protected override void OnDidApplyAnimationProperties(); // 0x000000018CE79CC4-0x000000018CE79CCC
		protected override void OnBeforeTransformParentChanged(); // 0x000000018CE79CC4-0x000000018CE79CCC
		protected void SetDirty(); // 0x000000018CE79E04-0x000000018CE79E8C
	}

	[AddComponentMenu("SRF/UI/Copy Layout Element")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement // TypeDefIndex: 89415
	{
		// Fields
		public bool CopyMinHeight; // 0x18
		public bool CopyMinWidth; // 0x19
		public bool CopyPreferredHeight; // 0x1A
		public bool CopyPreferredWidth; // 0x1B
		public RectTransform CopySource; // 0x20
		public float PaddingMinHeight; // 0x28
		public float PaddingMinWidth; // 0x2C
		public float PaddingPreferredHeight; // 0x30
		public float PaddingPreferredWidth; // 0x34
	
		// Properties
		public float preferredWidth { get; } // 0x000000018CE7A334-0x000000018CE7A3BC 
		public float preferredHeight { get; } // 0x000000018CE7A2AC-0x000000018CE7A334 
		public float minWidth { get; } // 0x000000018CE7A224-0x000000018CE7A2AC 
		public float minHeight { get; } // 0x000000018CE7A19C-0x000000018CE7A224 
		public int layoutPriority { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public float flexibleHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public float flexibleWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
	
		// Constructors
		public CopyLayoutElement(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("SRF/UI/Copy Preferred Size")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyPreferredSize : LayoutElement // TypeDefIndex: 89416
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
	
		// Properties
		public override float preferredWidth { get; } // 0x000000018CE7A43C-0x000000018CE7A4BC 
		public override float preferredHeight { get; } // 0x000000018CE7A3BC-0x000000018CE7A43C 
		public override int layoutPriority { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Constructors
		public CopyPreferredSize(); // 0x00000001871DECD0-0x00000001871DECE0
	}

	[AddComponentMenu("SRF/UI/Copy Preferred Size (Multiple)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyPreferredSizes : LayoutElement // TypeDefIndex: 89419
	{
		// Fields
		public CopySource[] CopySources; // 0x38
		public Operations Operation; // 0x40
	
		// Properties
		public override float preferredWidth { get; } // 0x0000000186A2C8F0-0x0000000186A2CAE0 
		public override float preferredHeight { get; } // 0x000000018CE7A4BC-0x000000018CE7A648 
		public override int layoutPriority { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Nested types
		public enum Operations // TypeDefIndex: 89417
		{
			Max = 0,
			Min = 1
		}
	
		[Serializable]
		public class CopySource // TypeDefIndex: 89418
		{
			// Fields
			public RectTransform Rect; // 0x10
			public float PaddingHeight; // 0x18
			public float PaddingWidth; // 0x1C
	
			// Constructors
			public CopySource(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CopyPreferredSizes(); // 0x00000001871DECD0-0x00000001871DECE0
	}

	[AddComponentMenu("SRF/UI/Copy Size Into Layout Element")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopySizeIntoLayoutElement : LayoutElement // TypeDefIndex: 89420
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
		public bool SetPreferredSize; // 0x48
		public bool SetMinimumSize; // 0x49
	
		// Properties
		public override float preferredWidth { get; } // 0x000000018CE7A81C-0x000000018CE7A8B8 
		public override float preferredHeight { get; } // 0x000000018CE7A780-0x000000018CE7A81C 
		public override float minWidth { get; } // 0x000000018CE7A6E4-0x000000018CE7A780 
		public override float minHeight { get; } // 0x000000018CE7A648-0x000000018CE7A6E4 
		public override int layoutPriority { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Constructors
		public CopySizeIntoLayoutElement(); // 0x00000001871DECD0-0x00000001871DECE0
	}

	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 89421
	{
		// Fields
		private CanvasScaler _canvasScaler; // 0x18
		private float _delta; // 0x20
		private float _startValue; // 0x24
		public RectTransform.Axis Axis; // 0x28
		public bool Invert; // 0x2C
		public float MaxSize; // 0x30
		public LayoutElement TargetLayoutElement; // 0x38
		public RectTransform TargetRectTransform; // 0x40
	
		// Properties
		private float Mult { get; } // 0x000000018CE7AFF8-0x000000018CE7B014 
	
		// Constructors
		public DragHandle(); // 0x000000018CE7AFDC-0x000000018CE7AFF8
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018CE7ABCC-0x000000018CE7ABFC
		public void OnDrag(PointerEventData eventData); // 0x000000018CE7ABFC-0x000000018CE7AD2C
		public void OnEndDrag(PointerEventData eventData); // 0x000000018CE7AD2C-0x000000018CE7AD88
		private void Start(); // 0x000000018CE7AED0-0x000000018CE7AF20
		private bool Verify(); // 0x000000018CE7AF20-0x000000018CE7AFDC
		private float GetCurrentValue(); // 0x000000018CE7AA10-0x000000018CE7AB28
		private void SetCurrentValue(float value); // 0x000000018CE7AD88-0x000000018CE7AED0
		private void CommitCurrentValue(); // 0x000000018CE7A910-0x000000018CE7AA10
		private float GetMinSize(); // 0x000000018CE7AB44-0x000000018CE7ABCC
		private float GetMaxSize(); // 0x000000018CE7AB28-0x000000018CE7AB44
	}

	[AddComponentMenu("SRF/UI/Flash Graphic")]
	[ExecuteInEditMode]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 89422
	{
		// Fields
		public float DecayTime; // 0x18
		public UnityEngine.Color DefaultColor; // 0x1C
		public UnityEngine.Color FlashColor; // 0x2C
		public Graphic Target; // 0x40
		private bool _isHoldingUntilNextPress; // 0x48
	
		// Constructors
		public FlashGraphic(); // 0x000000018CE7B1AC-0x000000018CE7B1F8
	
		// Methods
		public void OnPointerDown(PointerEventData eventData); // 0x000000018CE7B118-0x000000018CE7B160
		public void OnPointerUp(PointerEventData eventData); // 0x000000018CE7B160-0x000000018CE7B1AC
		protected override void OnEnable(); // 0x000000018CE7B0D4-0x000000018CE7B118
		public void Flash(); // 0x000000018CE7B05C-0x000000018CE7B0D4
		public void FlashAndHoldUntilNextPress(); // 0x000000018CE7B014-0x000000018CE7B05C
	}

	[AddComponentMenu("SRF/UI/Inherit Colour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Graphic))]
	public class InheritColour : SRMonoBehaviour // TypeDefIndex: 89423
	{
		// Fields
		private Graphic _graphic; // 0x48
		public Graphic From; // 0x50
	
		// Properties
		private Graphic Graphic { get; } // 0x000000018CE7BD7C-0x000000018CE7BE00 
	
		// Constructors
		public InheritColour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Refresh(); // 0x000000018CE7BCC4-0x000000018CE7BD74
		private void Update(); // 0x000000018CE7BD74-0x000000018CE7BD7C
		private void Start(); // 0x000000018CE7BD74-0x000000018CE7BD7C
	}

	[AddComponentMenu("SRF/UI/Long Press Button")]
	public class LongPressButton : UnityEngine.UI.Button // TypeDefIndex: 89424
	{
		// Fields
		private bool _handled; // 0x198
		[SerializeField]
		private ButtonClickedEvent _onLongPress; // 0x1A0
		private bool _pressed; // 0x1A8
		private float _pressedTime; // 0x1AC
		public float LongPressDuration; // 0x1B0
	
		// Properties
		public ButtonClickedEvent onLongPress { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
	
		// Constructors
		public LongPressButton(); // 0x000000018CE7BF34-0x000000018CE7BFB4
	
		// Methods
		public override void OnPointerExit(PointerEventData eventData); // 0x000000018CE7BE8C-0x000000018CE7BEAC
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018CE7BE38-0x000000018CE7BE8C
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018CE7BEAC-0x000000018CE7BEDC
		public override void OnPointerClick(PointerEventData eventData); // 0x000000018CE7BE24-0x000000018CE7BE38
		private void Update(); // 0x000000018CE7BEDC-0x000000018CE7BF34
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public abstract class ResponsiveBase : SRMonoBehaviour // TypeDefIndex: 89425
	{
		// Fields
		private bool _queueRefresh; // 0x48
	
		// Properties
		protected RectTransform RectTransform { get; } // 0x000000018CE7D5B8-0x000000018CE7D608 
	
		// Constructors
		protected ResponsiveBase(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected void OnEnable(); // 0x0000000187247AD0-0x0000000187247AE0
		protected void OnRectTransformDimensionsChange(); // 0x0000000187247AD0-0x0000000187247AE0
		protected void Update(); // 0x000000018CE7D590-0x000000018CE7D5B8
		protected abstract void Refresh();
		[ContextMenu("Refresh")]
		private void DoRefresh(); // 0x000000018CDCCCA8-0x000000018CDCCCB8
	}

	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveEnable : ResponsiveBase // TypeDefIndex: 89428
	{
		// Fields
		public Entry[] Entries; // 0x50
	
		// Nested types
		public enum Modes // TypeDefIndex: 89426
		{
			EnableAbove = 0,
			EnableBelow = 1
		}
	
		[Serializable]
		public struct Entry // TypeDefIndex: 89427
		{
			// Fields
			public UnityEngine.Behaviour[] Components; // 0x00
			public GameObject[] GameObjects; // 0x08
			public Modes Mode; // 0x10
			public float ThresholdHeight; // 0x14
			public float ThresholdWidth; // 0x18
		}
	
		// Constructors
		public ResponsiveEnable(); // 0x000000018CE7D890-0x000000018CE7D8E0
	
		// Methods
		protected override void Refresh(); // 0x000000018CE7D608-0x000000018CE7D890
	}

	[AddComponentMenu("SRF/UI/Responsive (Resize)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveResize : ResponsiveBase // TypeDefIndex: 89431
	{
		// Fields
		public Element[] Elements; // 0x50
	
		// Nested types
		[Serializable]
		public struct Element // TypeDefIndex: 89430
		{
			// Fields
			public SizeDefinition[] SizeDefinitions; // 0x00
			public RectTransform Target; // 0x08
	
			// Nested types
			[Serializable]
			public struct SizeDefinition // TypeDefIndex: 89429
			{
				// Fields
				[Tooltip("Width to apply when over the threshold width")]
				public float ElementWidth; // 0x00
				[Tooltip("Threshold over which this width will take effect")]
				public float ThresholdWidth; // 0x04
			}
		}
	
		// Constructors
		public ResponsiveResize(); // 0x000000018CE7DAA0-0x000000018CE7DAF0
	
		// Methods
		protected override void Refresh(); // 0x000000018CE7D8E0-0x000000018CE7DAA0
	}

	[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ScrollToBottomBehaviour : MonoBehaviour // TypeDefIndex: 89432
	{
		// Fields
		[SerializeField]
		private ScrollRect _scrollRect; // 0x18
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x20
		[SerializeField]
		private bool _scrollToTop; // 0x28
	
		// Constructors
		public ScrollToBottomBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Start(); // 0x000000018CE803CC-0x000000018CE80528
		private void OnEnable(); // 0x000000018CE8029C-0x000000018CE802A4
		public void Trigger(); // 0x000000018CE80528-0x000000018CE80568
		private void OnScrollRectValueChanged(Vector2 position); // 0x000000018CE8029C-0x000000018CE802A4
		private void Refresh(); // 0x000000018CE802A4-0x000000018CE80348
		private void SetVisible(bool truth); // 0x000000018CE80348-0x000000018CE803CC
	}

	[AddComponentMenu("SRF/UI/SRNumberButton")]
	public class SRNumberButton : UnityEngine.UI.Button, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 89433
	{
		// Fields
		private const float ExtraThreshold = 3f; // Metadata: 0x02648BBD
		public const float Delay = 0.4f; // Metadata: 0x02648BC1
		private float _delayTime; // 0x198
		private float _downTime; // 0x19C
		private bool _isDown; // 0x1A0
		public double Amount; // 0x1A8
		public SRNumberSpinner TargetField; // 0x1B0
	
		// Constructors
		public SRNumberButton(); // 0x000000018CE7F500-0x000000018CE7F518
	
		// Methods
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018CE7F404-0x000000018CE7F454
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018CE7F454-0x000000018CE7F474
		protected virtual void Update(); // 0x000000018CE7F474-0x000000018CE7F500
		private void Apply(); // 0x000000018CE7F304-0x000000018CE7F404
	}

	[AddComponentMenu("SRF/UI/SRNumberSpinner")]
	public class SRNumberSpinner : InputField // TypeDefIndex: 89434
	{
		// Fields
		private double _currentValue; // 0x2B0
		private double _dragStartAmount; // 0x2B8
		private double _dragStep; // 0x2C0
		public float DragSensitivity; // 0x2C8
		public double MaxValue; // 0x2D0
		public double MinValue; // 0x2D8
	
		// Constructors
		public SRNumberSpinner(); // 0x000000018CE7FA34-0x000000018CE7FAA0
	
		// Methods
		protected override void Awake(); // 0x000000018CE7F518-0x000000018CE7F594
		public override void OnPointerClick(PointerEventData eventData); // 0x000000018CE7F94C-0x000000018CE7FA34
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnPointerUp(PointerEventData eventData); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnBeginDrag(PointerEventData eventData); // 0x000000018CE7F594-0x000000018CE7F798
		public override void OnDrag(PointerEventData eventData); // 0x000000018CE7F798-0x000000018CE7F900
		public override void OnEndDrag(PointerEventData eventData); // 0x000000018CE7F900-0x000000018CE7F94C
	}

	[AddComponentMenu("SRF/UI/Retina Scaler")]
	[RequireComponent(typeof(CanvasScaler))]
	public class SRRetinaScaler : SRMonoBehaviour // TypeDefIndex: 89435
	{
		// Fields
		[SerializeField]
		private bool _disablePixelPerfect; // 0x48
		[SerializeField]
		private int _designDpi; // 0x4C
		private float _lastDpi; // 0x50
	
		// Constructors
		public SRRetinaScaler(); // 0x000000018CE7FCB0-0x000000018CE7FCCC
	
		// Methods
		private void Start(); // 0x000000018CE7FC78-0x000000018CE7FC80
		private void ApplyScaling(); // 0x000000018CE7FB88-0x000000018CE7FC78
		private void Update(); // 0x000000018CE7FC80-0x000000018CE7FCB0
	}

	[AddComponentMenu("SRF/UI/Spinner")]
	public class SRSpinner : Selectable, IDragHandler, IBeginDragHandler // TypeDefIndex: 89437
	{
		// Fields
		private float _dragDelta; // 0x190
		[SerializeField]
		private SpinEvent _onSpinDecrement; // 0x198
		[SerializeField]
		private SpinEvent _onSpinIncrement; // 0x1A0
		public float DragThreshold; // 0x1A8
	
		// Properties
		public SpinEvent OnSpinIncrement { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		public SpinEvent OnSpinDecrement { get; set; } // 0x000000018723C220-0x000000018723C230 0x0000000188DC4DB8-0x0000000188DC4DCC
	
		// Nested types
		[Serializable]
		public class SpinEvent : UnityEvent // TypeDefIndex: 89436
		{
			// Constructors
			public SpinEvent(); // 0x000000018548D960-0x000000018548D970
		}
	
		// Constructors
		public SRSpinner(); // 0x000000018CE80074-0x000000018CE8013C
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000187257EA0-0x0000000187257EB0
		public void OnDrag(PointerEventData eventData); // 0x000000018CE7FF58-0x000000018CE80028
		private void OnIncrement(int amount); // 0x000000018CE80028-0x000000018CE80074
		private void OnDecrement(int amount); // 0x000000018CE7FF0C-0x000000018CE7FF58
	}

	[AddComponentMenu("SRF/UI/SRText")]
	public class SRText : UnityEngine.UI.Text // TypeDefIndex: 89438
	{
		// Fields
		[CompilerGenerated]
		private Action<SRText> LayoutDirty; // 0x118
	
		// Events
		public event Action<SRText> LayoutDirty {
			add; // 0x000000018CE8017C-0x000000018CE8020C
			remove; // 0x000000018CE8020C-0x000000018CE8029C
		}
	
		// Constructors
		public SRText(); // 0x000000018CE80174-0x000000018CE8017C
	
		// Methods
		public override void SetLayoutDirty(); // 0x000000018CE8013C-0x000000018CE80174
	}

	[AddComponentMenu("SRF/UI/Style Component")]
	[ExecuteInEditMode]
	public class StyleComponent : SRMonoBehaviour // TypeDefIndex: 89439
	{
		// Fields
		private SRF.UI.Style _activeStyle; // 0x48
		private StyleRoot _cachedRoot; // 0x50
		private Graphic _graphic; // 0x58
		private bool _hasStarted; // 0x60
		private Image _image; // 0x68
		private Selectable _selectable; // 0x70
		[FormerlySerializedAs("StyleKey")]
		[HideInInspector]
		[SerializeField]
		private string _styleKey; // 0x78
		public bool IgnoreImage; // 0x80
	
		// Properties
		public string StyleKey { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x000000018CE81C3C-0x000000018CE81C64
	
		// Constructors
		public StyleComponent(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Start(); // 0x000000018CE81C1C-0x000000018CE81C3C
		private void OnEnable(); // 0x000000018CE819E4-0x000000018CE819F8
		public void Refresh(bool invalidateCache); // 0x000000018CE819F8-0x000000018CE81BC8
		private StyleRoot GetStyleRoot(); // 0x000000018CE81894-0x000000018CE819E4
		private void ApplyStyle(); // 0x000000018CE815A8-0x000000018CE81894
		private void SRStyleDirty(); // 0x000000018CE81BC8-0x000000018CE81C1C
	}

	[AddComponentMenu("SRF/UI/Style Root")]
	[ExecuteInEditMode]
	public sealed class StyleRoot : SRMonoBehaviour // TypeDefIndex: 89440
	{
		// Fields
		private StyleSheet _activeStyleSheet; // 0x48
		public StyleSheet StyleSheet; // 0x50
	
		// Constructors
		public StyleRoot(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public SRF.UI.Style GetStyle(string key); // 0x000000018CE81C64-0x000000018CE81D20
		private void OnEnable(); // 0x000000018CE81D28-0x000000018CE81D98
		private void OnDisable(); // 0x000000018CE81D20-0x000000018CE81D28
		private void Update(); // 0x000000018CE81DEC-0x000000018CE81E5C
		private void OnStyleSheetChanged(); // 0x000000018CE81D98-0x000000018CE81DEC
		public void SetDirty(); // 0x000000018926A7E8-0x000000018926A7FC
	}

	[Serializable]
	public class Style // TypeDefIndex: 89441
	{
		// Fields
		public UnityEngine.Color ActiveColor; // 0x10
		public UnityEngine.Color DisabledColor; // 0x20
		public UnityEngine.Color HoverColor; // 0x30
		public Sprite Image; // 0x40
		public UnityEngine.Color NormalColor; // 0x48
	
		// Constructors
		public Style(); // 0x000000018CE820C4-0x000000018CE8211C
	
		// Methods
		public Style Copy(); // 0x000000018CE82058-0x000000018CE820C4
		public void CopyFrom(Style style); // 0x000000018CE81FFC-0x000000018CE82058
	}

	[Serializable]
	public class StyleSheet : ScriptableObject // TypeDefIndex: 89442
	{
		// Fields
		[SerializeField]
		private List<string> _keys; // 0x18
		[SerializeField]
		private List<SRF.UI.Style> _styles; // 0x20
		[SerializeField]
		public StyleSheet Parent; // 0x28
	
		// Constructors
		public StyleSheet(); // 0x000000018CE81F34-0x000000018CE81FFC
	
		// Methods
		public SRF.UI.Style GetStyle(string key, bool searchParent = true /* Metadata: 0x02648BC5 */); // 0x000000018CE81E5C-0x000000018CE81F34
	}

	[AddComponentMenu("SRF/UI/Unselectable")]
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler // TypeDefIndex: 89443
	{
		// Fields
		private bool _suspectedSelected; // 0x48
	
		// Constructors
		public Unselectable(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void OnSelect(BaseEventData eventData); // 0x0000000187247AD0-0x0000000187247AE0
		private void Update(); // 0x000000018CE83710-0x000000018CE837D8
	}
}

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup // TypeDefIndex: 89444
	{
		// Fields
		private readonly IList<RectTransform> _rowList; // 0x58
		private float _layoutHeight; // 0x60
		public bool ChildForceExpandHeight; // 0x64
		public bool ChildForceExpandWidth; // 0x65
		public float Spacing; // 0x68
	
		// Properties
		protected bool IsCenterAlign { get; } // 0x000000018CE7BC18-0x000000018CE7BC30 
		protected bool IsRightAlign { get; } // 0x000000018CE7BC60-0x000000018CE7BC78 
		protected bool IsMiddleAlign { get; } // 0x000000018CE7BC48-0x000000018CE7BC60 
		protected bool IsLowerAlign { get; } // 0x000000018CE7BC30-0x000000018CE7BC48 
	
		// Constructors
		public FlowLayoutGroup(); // 0x000000018CE7BB98-0x000000018CE7BC18
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x000000018CE7B1F8-0x000000018CE7B27C
		public override void SetLayoutHorizontal(); // 0x000000018CE7B6C0-0x000000018CE7B710
		public override void SetLayoutVertical(); // 0x000000018CE7B710-0x000000018CE7B760
		public override void CalculateLayoutInputVertical(); // 0x000000018CE7B27C-0x000000018CE7B2D4
		public float SetLayout(float width, int axis, bool layoutInput); // 0x000000018CE7B760-0x000000018CE7BB98
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight); // 0x000000018CE7B2D4-0x000000018CE7B358
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis); // 0x000000018CE7B3E8-0x000000018CE7B6C0
		public float GetGreatestMinimumChildWidth(); // 0x000000018CE7B358-0x000000018CE7B3E8
	}

	public interface IVirtualView // TypeDefIndex: 89445
	{
		// Methods
		void SetDataContext(object data);
	}

	[AddComponentMenu("SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler // TypeDefIndex: 89448
	{
		// Fields
		private readonly SRList<object> _itemList; // 0x58
		private readonly SRList<int> _visibleItemList; // 0x60
		private bool _isDirty; // 0x68
		private SRList<Row> _rowCache; // 0x70
		private ScrollRect _scrollRect; // 0x78
		private int _selectedIndex; // 0x80
		private object _selectedItem; // 0x88
		[SerializeField]
		private SelectedItemChangedEvent _selectedItemChanged; // 0x90
		private int _visibleItemCount; // 0x98
		private SRList<Row> _visibleRows; // 0xA0
		public StyleSheet AltRowStyleSheet; // 0xA8
		public bool EnableSelection; // 0xB0
		public RectTransform ItemPrefab; // 0xB8
		public int RowPadding; // 0xC0
		public StyleSheet RowStyleSheet; // 0xC8
		public StyleSheet SelectedRowStyleSheet; // 0xD0
		public float Spacing; // 0xD8
		public bool StickToBottom; // 0xDC
		private float _itemHeight; // 0xE0
	
		// Properties
		public SelectedItemChangedEvent SelectedItemChanged { get; set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public object SelectedItem { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x000000018CE851C0-0x000000018CE85324
		public override float minHeight { get; } // 0x000000018CE850F4-0x000000018CE851C0 
		private ScrollRect ScrollRect { get; } // 0x000000018CE85070-0x000000018CE850F4 
		private bool AlignBottom { get; } // 0x000000018CE84EF4-0x000000018CE84F0C 
		private bool AlignTop { get; } // 0x000000018CE84F0C-0x000000018CE84F24 
		private float ItemHeight { get; } // 0x000000018CE84F24-0x000000018CE85070 
	
		// Nested types
		[Serializable]
		public class SelectedItemChangedEvent : UnityEvent<object> // TypeDefIndex: 89446
		{
			// Constructors
			public SelectedItemChangedEvent(); // 0x000000018CE80568-0x000000018CE805A4
		}
	
		[Serializable]
		private class Row // TypeDefIndex: 89447
		{
			// Fields
			public object Data; // 0x10
			public int Index; // 0x18
			public RectTransform Rect; // 0x20
			public StyleRoot Root; // 0x28
			public IVirtualView View; // 0x30
	
			// Constructors
			public Row(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public VirtualVerticalLayoutGroup(); // 0x000000018CE84DD4-0x000000018CE84EF4
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018CE8404C-0x000000018CE841BC
		protected override void Awake(); // 0x000000018CE838E4-0x000000018CE83A4C
		private void OnScrollRectValueChanged(Vector2 d); // 0x000000018CE841BC-0x000000018CE84214
		protected override void Start(); // 0x000000018CE84CF0-0x000000018CE84CF8
		protected override void OnEnable(); // 0x000000018CE8402C-0x000000018CE8404C
		protected void Update(); // 0x000000018CE84CF8-0x000000018CE84DD4
		protected void InvalidateItem(int itemIndex); // 0x000000018CE83F04-0x000000018CE8402C
		protected void RefreshIndexCache(); // 0x000000018CE844F8-0x000000018CE845CC
		protected void ScrollUpdate(); // 0x000000018CE8467C-0x000000018CE849CC
		public override void CalculateLayoutInputVertical(); // 0x000000018CE83A4C-0x000000018CE83A94
		public override void SetLayoutHorizontal(); // 0x000000018CE849F8-0x000000018CE84BA8
		public override void SetLayoutVertical(); // 0x000000018CE84BA8-0x000000018CE84CF0
		private new void SetDirty(); // 0x000000018CE849CC-0x000000018CE849F8
		public void AddItem(object item); // 0x000000018CE837D8-0x000000018CE838E4
		public void RemoveItem(object item); // 0x000000018CE845CC-0x000000018CE8467C
		public void ClearItems(); // 0x000000018CE83A94-0x000000018CE83B48
		private Row GetRow(int forIndex); // 0x000000018CE83D48-0x000000018CE83F04
		private void RecycleRow(Row row); // 0x000000018CE844A4-0x000000018CE844F8
		private void PopulateRow(int index, Row row); // 0x000000018CE84214-0x000000018CE844A4
		private Row CreateRow(); // 0x000000018CE83B48-0x000000018CE83D48
	}
}
