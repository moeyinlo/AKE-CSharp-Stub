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

// Image 68: StompyRobot.SRF.dll - Assembly: StompyRobot.SRF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62077-62166
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public static class SRDebugUtil // TypeDefIndex: 62078
{
	// Fields
	public const int LineBufferCount = 512; // Metadata: 0x0235017E
	[CompilerGenerated]
	private static bool _IsFixedUpdate_k__BackingField; // 0x00

	// Properties
	public static bool IsFixedUpdate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018ACA7DF4-0x000000018ACA7E2C 0x000000018ACA7E2C-0x000000018ACA7E68

	// Methods
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null); // 0x000000018ACA7B68-0x000000018ACA7CEC
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null); // 0x000000018ACA7CEC-0x000000018ACA7DE4
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null); // 0x000000018ACA7DE4-0x000000018ACA7DEC
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null); // 0x000000018ACA7DEC-0x000000018ACA7DF4
}

public static class SRFileUtil // TypeDefIndex: 62079
{
	// Methods
	public static void DeleteDirectory(string path); // 0x000000018ACA8484-0x000000018ACA8518
	public static string GetBytesReadable(long i); // 0x00000001841A7E60-0x00000001841A7FB0
}

public static class SRInstantiate // TypeDefIndex: 62080
{
	// Methods
	public static T Instantiate<T>(T prefab)
		where T : UnityEngine.Component;
	public static GameObject Instantiate(GameObject prefab); // 0x000000018ACA8518-0x000000018ACA856C
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation)
		where T : UnityEngine.Component;
}

public static class SRMath // TypeDefIndex: 62083
{
	// Nested types
	public enum EaseType // TypeDefIndex: 62081
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

	private static class TweenFunctions // TypeDefIndex: 62082
	{
		// Methods
		public static float Linear(float t, float b, float c, float d); // 0x000000018ACACD54-0x000000018ACACD64
		public static float ExpoEaseOut(float t, float b, float c, float d); // 0x000000018ACACCEC-0x000000018ACACD54
		public static float ExpoEaseIn(float t, float b, float c, float d); // 0x000000018ACACC2C-0x000000018ACACC8C
		public static float ExpoEaseInOut(float t, float b, float c, float d); // 0x000000018ACACB7C-0x000000018ACACC2C
		public static float ExpoEaseOutIn(float t, float b, float c, float d); // 0x000000018ACACC8C-0x000000018ACACCEC
		public static float CircEaseOut(float t, float b, float c, float d); // 0x000000018ACAC6DC-0x000000018ACAC728
		public static float CircEaseIn(float t, float b, float c, float d); // 0x000000018ACAC5E4-0x000000018ACAC640
		public static float CircEaseInOut(float t, float b, float c, float d); // 0x000000018ACAC550-0x000000018ACAC5E4
		public static float CircEaseOutIn(float t, float b, float c, float d); // 0x000000018ACAC640-0x000000018ACAC6DC
		public static float QuadEaseOut(float t, float b, float c, float d); // 0x000000018ACACE58-0x000000018ACACE7C
		public static float QuadEaseIn(float t, float b, float c, float d); // 0x000000018ACACDC4-0x000000018ACACDDC
		public static float QuadEaseInOut(float t, float b, float c, float d); // 0x000000018ACACD64-0x000000018ACACDC4
		public static float QuadEaseOutIn(float t, float b, float c, float d); // 0x000000018ACACDDC-0x000000018ACACE58
		public static float SineEaseOut(float t, float b, float c, float d); // 0x000000018ACAD2F8-0x000000018ACAD334
		public static float SineEaseIn(float t, float b, float c, float d); // 0x000000018ACAD200-0x000000018ACAD24C
		public static float SineEaseInOut(float t, float b, float c, float d); // 0x000000018ACAD16C-0x000000018ACAD200
		public static float SineEaseOutIn(float t, float b, float c, float d); // 0x000000018ACAD24C-0x000000018ACAD2F8
		public static float CubicEaseOut(float t, float b, float c, float d); // 0x000000018ACAC844-0x000000018ACAC870
		public static float CubicEaseIn(float t, float b, float c, float d); // 0x000000018ACAC798-0x000000018ACAC7B4
		public static float CubicEaseInOut(float t, float b, float c, float d); // 0x000000018ACAC728-0x000000018ACAC798
		public static float CubicEaseOutIn(float t, float b, float c, float d); // 0x000000018ACAC7B4-0x000000018ACAC844
		public static float QuartEaseOut(float t, float b, float c, float d); // 0x000000018ACACFBC-0x000000018ACACFF4
		public static float QuartEaseIn(float t, float b, float c, float d); // 0x000000018ACACEFC-0x000000018ACACF1C
		public static float QuartEaseInOut(float t, float b, float c, float d); // 0x000000018ACACE7C-0x000000018ACACEFC
		public static float QuartEaseOutIn(float t, float b, float c, float d); // 0x000000018ACACF1C-0x000000018ACACFBC
		public static float QuintEaseOut(float t, float b, float c, float d); // 0x000000018ACAD138-0x000000018ACAD16C
		public static float QuintEaseIn(float t, float b, float c, float d); // 0x000000018ACAD074-0x000000018ACAD098
		public static float QuintEaseInOut(float t, float b, float c, float d); // 0x000000018ACACFF4-0x000000018ACAD074
		public static float QuintEaseOutIn(float t, float b, float c, float d); // 0x000000018ACAD098-0x000000018ACAD138
		public static float ElasticEaseOut(float t, float b, float c, float d); // 0x000000018ACACABC-0x000000018ACACB7C
		public static float ElasticEaseIn(float t, float b, float c, float d); // 0x000000018ACAC990-0x000000018ACACA5C
		public static float ElasticEaseInOut(float t, float b, float c, float d); // 0x000000018ACAC870-0x000000018ACAC990
		public static float ElasticEaseOutIn(float t, float b, float c, float d); // 0x000000018ACACA5C-0x000000018ACACABC
		public static float BounceEaseOut(float t, float b, float c, float d); // 0x000000018ACAC490-0x000000018ACAC550
		public static float BounceEaseIn(float t, float b, float c, float d); // 0x000000018ACAC3B4-0x000000018ACAC400
		public static float BounceEaseInOut(float t, float b, float c, float d); // 0x000000018ACAC31C-0x000000018ACAC3B4
		public static float BounceEaseOutIn(float t, float b, float c, float d); // 0x000000018ACAC400-0x000000018ACAC490
		public static float BackEaseOut(float t, float b, float c, float d); // 0x000000018ACAC2E0-0x000000018ACAC31C
		public static float BackEaseIn(float t, float b, float c, float d); // 0x000000018ACAC204-0x000000018ACAC230
		public static float BackEaseInOut(float t, float b, float c, float d); // 0x000000018ACAC17C-0x000000018ACAC204
		public static float BackEaseOutIn(float t, float b, float c, float d); // 0x000000018ACAC230-0x000000018ACAC2E0
	}

	// Methods
	public static float LerpUnclamped(float from, float to, float t); // 0x0000000184DA9EB0-0x0000000184DA9ED0
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t); // 0x0000000184DA9E50-0x0000000184DA9EB0
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2); // 0x000000018ACA8CBC-0x000000018ACA8D2C
	public static float WrapAngle(float angle); // 0x000000018ACA9044-0x000000018ACA906C
	public static float NearestAngle(float to, float angle1, float angle2); // 0x000000018ACA8D2C-0x000000018ACA8D9C
	public static int Wrap(int max, int value); // 0x000000018ACA906C-0x000000018ACA9100
	public static float Wrap(float max, float value); // 0x000000018ACA9100-0x000000018ACA9124
	public static float Average(float v1, float v2); // 0x0000000184DA9E40-0x0000000184DA9E50
	public static float Angle(Vector2 direction); // 0x000000018ACA856C-0x000000018ACA8630
	public static float Ease(float from, float to, float t, EaseType type); // 0x000000018ACA8630-0x000000018ACA8CBC
	public static float SpringLerp(float strength, float deltaTime); // 0x000000018ACA8F7C-0x000000018ACA8FCC
	public static float SpringLerp(float from, float to, float strength, float deltaTime); // 0x000000018ACA8F3C-0x000000018ACA8F7C
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime); // 0x000000018ACA8EB4-0x000000018ACA8F3C
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime); // 0x000000018ACA8FCC-0x000000018ACA9044
	public static float SmoothClamp(float value, float min, float max, float scrollMax, EaseType easeType = EaseType.ExpoEaseOut /* Metadata: 0x02350180 */); // 0x000000018ACA8D9C-0x000000018ACA8EB4
}

namespace SRF
{
	public static class Json // TypeDefIndex: 62087
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 62085
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x023501AA
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get; } // 0x000000018ACA6DB4-0x000000018ACA6E10 
			private char NextChar { get; } // 0x000000018ACA6A84-0x000000018ACA6AE0 
			private string NextWord { get; } // 0x000000018ACA6D04-0x000000018ACA6DB4 
			private TOKEN NextToken { get; } // 0x000000018ACA6AE0-0x000000018ACA6D04 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 62084
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
			private Parser(string jsonString); // 0x000000018ACA6A0C-0x000000018ACA6A84
	
			// Methods
			public void Dispose(); // 0x0000000189D2CEB4-0x0000000189D2CEEC
			public static bool IsWordBreak(char c); // 0x000000018ACA6300-0x000000018ACA6378
			public static object Parse(string jsonString); // 0x000000018ACA6914-0x000000018ACA6A0C
			private Dictionary<string, object> ParseObject(); // 0x000000018ACA65B8-0x000000018ACA66C4
			private List<object> ParseArray(); // 0x000000018ACA6378-0x000000018ACA6440
			private object ParseValue(); // 0x000000018ACA68F0-0x000000018ACA6914
			private object ParseByToken(TOKEN token); // 0x000000018ACA6440-0x000000018ACA64F4
			private string ParseString(); // 0x000000018ACA66C4-0x000000018ACA68F0
			private object ParseNumber(); // 0x000000018ACA64F4-0x000000018ACA65B8
			private void EatWhitespace(); // 0x000000018ACA6270-0x000000018ACA6300
		}
	
		private sealed class Serializer // TypeDefIndex: 62086
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer(); // 0x000000018ACAB470-0x000000018ACAB4D4
	
			// Methods
			public static string Serialize(object obj); // 0x000000018ACAB3F8-0x000000018ACAB470
			private void SerializeValue(object value); // 0x000000018ACAB274-0x000000018ACAB3F8
			private void SerializeObject(IDictionary obj); // 0x000000018ACAA994-0x000000018ACAAD9C
			private void SerializeArray(IList anArray); // 0x000000018ACAA610-0x000000018ACAA994
			private void SerializeString(string str); // 0x000000018ACAAFFC-0x000000018ACAB274
			private void SerializeOther(object value); // 0x000000018ACAAD9C-0x000000018ACAAFFC
		}
	
		// Methods
		public static object Deserialize(string json); // 0x000000018ACA5F0C-0x000000018ACA5F28
		public static string Serialize(object obj); // 0x000000018ACA5F28-0x000000018ACA5F30
	}

	[Serializable]
	public class SRList<T> : IList<T>, ISerializationCallbackReceiver // TypeDefIndex: 62089
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
		private sealed class _GetEnumerator_d__15 : IEnumerator<T> // TypeDefIndex: 62088
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

	public abstract class SRMonoBehaviour : MonoBehaviour // TypeDefIndex: 62090
	{
		// Fields
		private Collider _collider; // 0x18
		private Transform _transform; // 0x20
		private Rigidbody _rigidBody; // 0x28
		private GameObject _gameObject; // 0x30
		private Rigidbody2D _rigidbody2D; // 0x38
		private Collider2D _collider2D; // 0x40
	
		// Properties
		public Transform CachedTransform { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x0000000183A47940-0x0000000183A479F0 
		public Collider CachedCollider { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018ACA91DC-0x000000018ACA9260 
		public Collider2D CachedCollider2D { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018ACA9158-0x000000018ACA91DC 
		public Rigidbody CachedRigidBody { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018ACA92E4-0x000000018ACA9368 
		public Rigidbody2D CachedRigidBody2D { [DebuggerStepThrough] [DebuggerNonUserCode] get; } // 0x000000018ACA9260-0x000000018ACA92E4 
		public GameObject CachedGameObject { [DebuggerStepThrough] [DebuggerNonUserCode] get; } // 0x0000000183A47890-0x0000000183A47940 
		public new Transform transform { get; } // 0x000000018ACA9368-0x000000018ACA9370 
	
		// Constructors
		protected SRMonoBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, string fieldName = null); // 0x000000018ACA9124-0x000000018ACA913C
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, string message = null); // 0x000000018ACA913C-0x000000018ACA9158
		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, string fieldName = null); // 0x000000018ACA9124-0x000000018ACA913C
		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, string message = null); // 0x000000018ACA913C-0x000000018ACA9158
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class RequiredFieldAttribute : Attribute // TypeDefIndex: 62091
	{
		// Fields
		private bool _autoCreate; // 0x10
		private bool _autoSearch; // 0x11
		private bool _editorOnly; // 0x12
	
		// Properties
		public bool AutoSearch { get; set; } // 0x0000000184D88380-0x0000000184D88390 0x0000000184D88460-0x0000000184D88470
		public bool AutoCreate { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		[Obsolete]
		public bool EditorOnly { get; set; } // 0x0000000184D88390-0x0000000184D883A0 0x0000000184DA0900-0x0000000184DA0910
	
		// Constructors
		public RequiredFieldAttribute(bool autoSearch); // 0x0000000184DA9E30-0x0000000184DA9E40
		public RequiredFieldAttribute(); // 0x0000000184D99700-0x0000000184D99710
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ImportAttribute : Attribute // TypeDefIndex: 62092
	{
		// Fields
		public readonly System.Type Service; // 0x10
	
		// Constructors
		public ImportAttribute(); // 0x00000001841E1670-0x00000001841E1680
		public ImportAttribute(System.Type serviceType); // 0x00000001853908C0-0x00000001853908D0
	}

	public abstract class SRMonoBehaviourEx : SRMonoBehaviour // TypeDefIndex: 62094
	{
		// Fields
		private static Dictionary<System.Type, IList<FieldInfo>> _checkedFields; // 0x00
	
		// Nested types
		private struct FieldInfo // TypeDefIndex: 62093
		{
			// Fields
			public bool AutoCreate; // 0x00
			public bool AutoSet; // 0x01
			public System.Reflection.FieldInfo Field; // 0x08
			public bool Import; // 0x10
			public System.Type ImportType; // 0x18
		}
	
		// Constructors
		protected SRMonoBehaviourEx(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false /* Metadata: 0x023501BE */); // 0x0000000184582280-0x0000000184582420
		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet); // 0x00000001845825B0-0x00000001845826A0
		private static List<FieldInfo> ScanType(System.Type t); // 0x0000000184582420-0x00000001845825B0
		protected virtual void Awake(); // 0x0000000185398080-0x000000018539808C
		protected virtual void Start(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void Update(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void FixedUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class Coroutines // TypeDefIndex: 62096
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForSecondsRealTime_d__0 : IEnumerator<object> // TypeDefIndex: 62095
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float time; // 0x20
			private float _endTime_5__2; // 0x24
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForSecondsRealTime_d__0(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018ACAD688-0x000000018ACAD6EC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018ACAD6EC-0x000000018ACAD738
		}
	
		// Methods
		[IteratorStateMachine(typeof(_WaitForSecondsRealTime_d__0))]
		public static IEnumerator WaitForSecondsRealTime(float time); // 0x000000018ACA49C8-0x000000018ACA4A1C
	}

	public static class SRFFloatExtensions // TypeDefIndex: 62097
	{
		// Extension methods
		public static float Sqr(this float f); // 0x0000000184D886E0-0x0000000184D886F0
		public static float SqrRt(this float f); // 0x0000000184D88670-0x0000000184D88690
		public static bool ApproxZero(this float f); // 0x000000018ACA7E68-0x000000018ACA7EB8
		public static bool Approx(this float f, float f2); // 0x0000000182FAEEA0-0x0000000182FAEEF0
	}

	public static class SRFGameObjectExtensions // TypeDefIndex: 62098
	{
		// Methods
		private static void SetLayerInternal(Transform t, int layer); // 0x000000018ACA7EB8-0x000000018ACA8050
	
		// Extension methods
		public static T GetIComponent<T>(this GameObject t)
			where T : class;
		public static T GetComponentOrAdd<T>(this GameObject obj)
			where T : UnityEngine.Component;
		public static void RemoveComponentIfExists<T>(this GameObject obj)
			where T : UnityEngine.Component;
		public static void RemoveComponentsIfExists<T>(this GameObject obj)
			where T : UnityEngine.Component;
		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true /* Metadata: 0x023501BF */)
			where T : MonoBehaviour;
		public static void SetLayerRecursive(this GameObject o, int layer); // 0x000000018ACA8050-0x000000018ACA807C
	}

	public static class SRFIListExtensions // TypeDefIndex: 62099
	{
		// Extension methods
		public static T Random<T>(this IList<T> list);
		public static T RandomOrDefault<T>(this IList<T> list);
		public static T PopLast<T>(this IList<T> list);
	}

	public static class SRFStringExtensions // TypeDefIndex: 62100
	{
		// Extension methods
		public static string Fmt(this string formatString, params object[] args); // 0x0000000185397134-0x000000018539713C
	}

	public static class SRFTransformExtensions // TypeDefIndex: 62102
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _GetChildren_d__0 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 62101
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform t; // 0x28
			public Transform __3__t; // 0x30
			private int _i_5__2; // 0x38
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetChildren_d__0(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018ACAD334-0x000000018ACAD3B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018ACAD44C-0x000000018ACAD498
			[DebuggerHidden]
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x000000018ACAD3B0-0x000000018ACAD444
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018ACAD444-0x000000018ACAD44C
		}
	
		// Extension methods
		[IteratorStateMachine(typeof(_GetChildren_d__0))]
		public static IEnumerable<Transform> GetChildren(this Transform t); // 0x000000018ACA82D8-0x000000018ACA8348
		public static void ResetLocal(this Transform t); // 0x000000018ACA83D0-0x000000018ACA8464
		public static GameObject CreateChild(this Transform t, string name); // 0x000000018ACA807C-0x000000018ACA8144
		public static void SetParentMaintainLocals(this Transform t, Transform parent); // 0x000000018ACA8464-0x000000018ACA8484
		public static void SetLocals(this Transform t, Transform from); // 0x000000018AC7A890-0x000000018AC7A94C
		public static void Match(this Transform t, Transform from); // 0x000000018ACA8348-0x000000018ACA83D0
		public static void DestroyChildren(this Transform t); // 0x000000018ACA8144-0x000000018ACA82D8
	}

	public class Hierarchy // TypeDefIndex: 62103
	{
		// Fields
		private static readonly char[] Seperator; // 0x00
		private static readonly Dictionary<string, Transform> Cache; // 0x08
	
		// Properties
		[Obsolete("Use static Get() instead")]
		public Transform this[string key] { get => default; } // 0x000000018ACA5D84-0x000000018ACA5DD0 
	
		// Constructors
		public Hierarchy(); // 0x00000001841E1670-0x00000001841E1680
		static Hierarchy(); // 0x0000000184CA6460-0x0000000184CA6560
	
		// Methods
		public static Transform Get(string key); // 0x0000000183A479F0-0x0000000183A47BF0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void RuntimeInitialize(); // 0x0000000184D345A0-0x0000000184D34620
	}
}

namespace SRF.Components
{
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour // TypeDefIndex: 62164
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

	public abstract class SRSingleton<T> : SRMonoBehaviour // TypeDefIndex: 62165
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
	public static class AssetUtil // TypeDefIndex: 62154
	{
	}

	public sealed class MethodReference // TypeDefIndex: 62157
	{
		// Fields
		private readonly Func<object[], object> _method; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 62155
		{
			// Fields
			public MethodInfo method; // 0x10
			public object target; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _.ctor_b__0(object[] o); // 0x000000018ACAD544-0x000000018ACAD570
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 62156
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _op_Implicit_b__0(object[] args); // 0x000000018ACAD604-0x000000018ACAD624
		}
	
		// Constructors
		public MethodReference(object target, MethodInfo method); // 0x000000018ACA60C0-0x000000018ACA61A0
		public MethodReference(Func<object[], object> method); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public object Invoke(object[] parameters); // 0x0000000189B1C05C-0x0000000189B1C07C
		public static implicit operator MethodReference(Action action); // 0x000000018ACA61A0-0x000000018ACA6270
	}

	public delegate void PropertyValueChangedHandler(PropertyReference property); // TypeDefIndex: 62158; 0x0000000182B46B90-0x0000000182B46BA0

	public sealed class PropertyReference // TypeDefIndex: 62162
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
		public System.Type PropertyType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public bool CanRead { get; } // 0x00000001868C60A8-0x00000001868C60B4 
		public bool CanWrite { get; } // 0x0000000189B11948-0x0000000189B11954 
	
		// Events
		public event PropertyValueChangedHandler ValueChanged {
			add; // 0x000000018ACA739C-0x000000018ACA7508
			remove; // 0x000000018ACA7508-0x000000018ACA7628
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0<T> // TypeDefIndex: 62159
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
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 62160
		{
			// Fields
			public object target; // 0x10
			public PropertyInfo property; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _.ctor_b__0(); // 0x000000018ACAD520-0x000000018ACAD530
			internal void _.ctor_b__1(object v); // 0x000000018ACAD530-0x000000018ACAD544
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__23<T> // TypeDefIndex: 62161
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
		public PropertyReference(object target, PropertyInfo property); // 0x000000018ACA7148-0x000000018ACA731C
		public PropertyReference(System.Type type, Func<object> getter = null, Action<object> setter = null, Attribute[] attributes = null); // 0x000000018ACA731C-0x000000018ACA739C
	
		// Methods
		public static PropertyReference FromLambda<T>(Func<T> getter, Action<T> setter = null, params Attribute[] attributes);
		public void NotifyValueChanged(); // 0x000000018ACA6E28-0x000000018ACA6F38
		public object GetValue(); // 0x000000018ACA6E10-0x000000018ACA6E28
		public void SetValue(object value); // 0x000000018ACA6FB4-0x000000018ACA702C
		public T GetAttribute<T>()
			where T : Attribute;
		private void OnTargetPropertyChanged(object sender, PropertyChangedEventArgs e); // 0x000000018ACA6F38-0x000000018ACA6FB4
		public override string ToString(); // 0x000000018ACA702C-0x000000018ACA7148
	}

	public static class SRReflection // TypeDefIndex: 62163
	{
		// Methods
		public static void SetPropertyValue(object obj, PropertyInfo p, object value); // 0x000000018ACA9B48-0x000000018ACA9BF4
		public static object GetPropertyValue(object obj, PropertyInfo p); // 0x000000018ACA9B0C-0x000000018ACA9B48
		public static T GetAttribute<T>(MemberInfo t)
			where T : Attribute;
	}
}

namespace SRF.Internal
{
	internal static class ComponentMenuPaths // TypeDefIndex: 62166
	{
		// Fields
		public const string PathRoot = "SRF"; // Metadata: 0x023501CE
		public const string SRServiceManager = "SRF/Service/Service Manager"; // Metadata: 0x023501D2
		public const string BehavioursRoot = "SRF/Behaviours"; // Metadata: 0x023501EE
		public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable"; // Metadata: 0x023501FD
		public const string DontDestroyOnLoad = "SRF/Behaviours/Don\'t Destroy On Load"; // Metadata: 0x0235021F
		public const string MatchTransform = "SRF/Behaviours/Match Transform"; // Metadata: 0x02350244
		public const string LookAt = "SRF/Behaviours/LookAt"; // Metadata: 0x02350263
		public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction"; // Metadata: 0x02350279
		public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)"; // Metadata: 0x023502A0
		public const string RuntimePosition = "SRF/Behaviours/Runtime Position"; // Metadata: 0x023502D5
		public const string ScrollTexture = "SRF/Behaviours/Scroll Texture"; // Metadata: 0x023502F5
		public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float"; // Metadata: 0x02350313
		public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)"; // Metadata: 0x0235032F
		public const string SpringFollow = "SRF/Behaviours/Spring Follow"; // Metadata: 0x02350351
		public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)"; // Metadata: 0x0235036E
		public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab"; // Metadata: 0x02350396
		public const string Velocity = "SRF/Behaviours/Velocity"; // Metadata: 0x023503B2
		public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate"; // Metadata: 0x023503CA
		public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera"; // Metadata: 0x023503EA
		public const string ComponentsRoot = "SRF/Components"; // Metadata: 0x0235040E
		public const string SRLineRenderer = "SRF/Components/SRLineRenderer"; // Metadata: 0x0235041D
		public const string SelectionRoot = "SRF/Components/Selection Root"; // Metadata: 0x0235043B
		public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)"; // Metadata: 0x02350459
		public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)"; // Metadata: 0x0235047F
		public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)"; // Metadata: 0x023504A7
		public const string UIRoot = "SRF/UI"; // Metadata: 0x023504D0
		public const string TiltOnTouch = "SRF/UI/Tilt On Touch"; // Metadata: 0x023504D7
		public const string ScaleOnTouch = "SRF/UI/Scale On Touch"; // Metadata: 0x023504EC
		public const string InheritColour = "SRF/UI/Inherit Colour"; // Metadata: 0x02350502
		public const string FlashGraphic = "SRF/UI/Flash Graphic"; // Metadata: 0x02350518
		public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size"; // Metadata: 0x0235052D
		public const string CopyPreferredSizes = "SRF/UI/Copy Preferred Size (Multiple)"; // Metadata: 0x02350548
		public const string CopyLayoutElement = "SRF/UI/Copy Layout Element"; // Metadata: 0x0235056E
		public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element"; // Metadata: 0x02350589
		public const string SRText = "SRF/UI/SRText"; // Metadata: 0x023505AE
		public const string Unselectable = "SRF/UI/Unselectable"; // Metadata: 0x023505BC
		public const string LongPressButton = "SRF/UI/Long Press Button"; // Metadata: 0x023505D0
		public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour"; // Metadata: 0x023505E9
		public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group"; // Metadata: 0x0235060B
		public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)"; // Metadata: 0x0235062B
		public const string StyleRoot = "SRF/UI/Style Root"; // Metadata: 0x0235065C
		public const string StyleComponent = "SRF/UI/Style Component"; // Metadata: 0x0235066E
		public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)"; // Metadata: 0x02350685
		public const string ResponsiveResize = "SRF/UI/Responsive (Resize)"; // Metadata: 0x023506A0
		public const string RetinaScaler = "SRF/UI/Retina Scaler"; // Metadata: 0x023506BB
		public const string NumberButton = "SRF/UI/SRNumberButton"; // Metadata: 0x023506D0
		public const string NumberSpinner = "SRF/UI/SRNumberSpinner"; // Metadata: 0x023506E6
		public const string SRSpinner = "SRF/UI/Spinner"; // Metadata: 0x023506FD
		public const string ContentFitText = "SRF/UI/Content Fit Text"; // Metadata: 0x0235070C
	}
}

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ServiceAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 62139
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public ServiceAttribute(System.Type serviceType); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceSelectorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 62140
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public ServiceSelectorAttribute(System.Type serviceType); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceConstructorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 62141
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public ServiceConstructorAttribute(System.Type serviceType); // 0x00000001853908C0-0x00000001853908D0
	}

	public interface IAsyncService // TypeDefIndex: 62142
	{
		// Properties
		bool IsLoaded { get; }
	}

	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 62144
		where T : class
	{
		// Fields
		private bool _isLoaded;
	
		// Properties
		protected abstract System.Type[] Dependencies { get; }
		public bool IsLoaded { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadDependencies_d__8 : IEnumerator<object> // TypeDefIndex: 62143
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

	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 62146
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
		private sealed class _LoadCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 62145
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

	public abstract class SRServiceBase<T> : SRMonoBehaviourEx // TypeDefIndex: 62147
		where T : class
	{
		// Constructors
		protected SRServiceBase();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
	}

	[AddComponentMenu("SRF/Service/Service Manager")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager> // TypeDefIndex: 62153
	{
		// Fields
		public const bool EnableLogging = false; // Metadata: 0x023501CD
		public static int LoadingCount; // 0x00
		private static readonly List<Assembly> _assemblies; // 0x08
		private readonly SRList<Service> _services; // 0x48
		private List<ServiceStub> _serviceStubs; // 0x50
		private static bool _hasQuit; // 0x10
	
		// Properties
		public static bool IsLoading { get; } // 0x000000018ACA9F28-0x000000018ACA9F70 
	
		// Nested types
		private class Service // TypeDefIndex: 62148
		{
			// Fields
			public object Object; // 0x10
			public System.Type Type; // 0x18
	
			// Constructors
			public Service(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class ServiceStub // TypeDefIndex: 62149
		{
			// Fields
			public Func<object> Constructor; // 0x10
			public System.Type InterfaceType; // 0x18
			public Func<System.Type> Selector; // 0x20
			public System.Type Type; // 0x28
	
			// Constructors
			public ServiceStub(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public override string ToString(); // 0x000000018ACAB4D4-0x000000018ACAB614
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62150
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ServiceStub, string> __9__21_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018ACAD624-0x000000018ACAD688
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _UpdateStubs_b__21_0(ServiceStub p); // 0x000000018ACAD498-0x000000018ACAD520
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 62151
		{
			// Fields
			public ServiceSelectorAttribute attrib; // 0x10
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ScanTypeForSelectors_b__0(ServiceStub p); // 0x0000000184CCAA20-0x0000000184CCAAA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 62152
		{
			// Fields
			public ServiceConstructorAttribute attrib; // 0x10
			public MethodInfo m; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ScanTypeForConstructors_b__0(ServiceStub p); // 0x000000018ACAD570-0x000000018ACAD5E0
			internal object _ScanTypeForConstructors_b__1(); // 0x000000018ACAD5E0-0x000000018ACAD604
		}
	
		// Constructors
		public SRServiceManager(); // 0x0000000184CCA760-0x0000000184CCA7F0
		static SRServiceManager(); // 0x0000000184CE6D70-0x0000000184CE6E20
	
		// Methods
		public static void RegisterAssembly<TType>();
		public static T GetService<T>()
			where T : class;
		public static object GetService(System.Type t); // 0x000000018ACA9D30-0x000000018ACA9EB0
		private static object GetServiceInternal(System.Type t); // 0x0000000183B0F400-0x0000000183B0F510
		public static bool HasService<T>()
			where T : class;
		public static bool HasService(System.Type t); // 0x0000000183B0F510-0x0000000183B0F640
		public static void RegisterService<T>(object service)
			where T : class;
		private static void RegisterService(System.Type t, object service); // 0x0000000183B0F1A0-0x0000000183B0F320
		public static void UnRegisterService<T>()
			where T : class;
		private static void UnRegisterService(System.Type t); // 0x0000000183B0FF10-0x0000000183B10000
		protected override void Awake(); // 0x0000000183A477B0-0x0000000183A47890
		protected void UpdateStubs(); // 0x0000000183B10000-0x0000000183B10CD0
		protected object AutoCreateService(System.Type t); // 0x0000000183B0F640-0x0000000183B0FD60
		protected new void OnApplicationQuit(); // 0x000000018ACA9EB0-0x000000018ACA9F28
		private static object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType); // 0x0000000183B0FD60-0x0000000183B0FF10
		private void ScanType(System.Type type); // 0x0000000183B10CD0-0x0000000183B10DB0
		private static void ScanTypeForSelectors(System.Type t, List<ServiceStub> stubs); // 0x0000000183B10E80-0x0000000183B110C0
		private static void ScanTypeForConstructors(System.Type t, List<ServiceStub> stubs); // 0x0000000183B10DB0-0x0000000183B10E80
		private static MethodInfo[] GetStaticMethods(System.Type t); // 0x0000000182F2E150-0x0000000182F2E180
	}
}

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Content Fit Text")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ContentFitText : UIBehaviour, ILayoutElement // TypeDefIndex: 62104
	{
		// Fields
		public SRText CopySource; // 0x18
		public Vector2 Padding; // 0x20
	
		// Properties
		public float minWidth { get; } // 0x000000018ACA3F9C-0x000000018ACA4020 
		public float preferredWidth { get; } // 0x000000018ACA40A4-0x000000018ACA4128 
		public float flexibleWidth { get; } // 0x000000018ACA3E98-0x000000018ACA3F18 
		public float minHeight { get; } // 0x000000018ACA3F18-0x000000018ACA3F9C 
		public float preferredHeight { get; } // 0x000000018ACA4020-0x000000018ACA40A4 
		public float flexibleHeight { get; } // 0x000000018ACA3E18-0x000000018ACA3E98 
		public int layoutPriority { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public ContentFitText(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x000000018ACA3C38-0x000000018ACA3C50
		public void CalculateLayoutInputVertical(); // 0x000000018ACA3C38-0x000000018ACA3C50
		protected override void OnEnable(); // 0x000000018ACA3CF4-0x000000018ACA3D90
		private void CopySourceOnLayoutDirty(SRText srText); // 0x000000018ACA3C50-0x000000018ACA3C58
		protected override void OnTransformParentChanged(); // 0x000000018ACA3C50-0x000000018ACA3C58
		protected override void OnDisable(); // 0x000000018ACA3C58-0x000000018ACA3CF4
		protected override void OnDidApplyAnimationProperties(); // 0x000000018ACA3C50-0x000000018ACA3C58
		protected override void OnBeforeTransformParentChanged(); // 0x000000018ACA3C50-0x000000018ACA3C58
		protected void SetDirty(); // 0x000000018ACA3D90-0x000000018ACA3E18
	}

	[AddComponentMenu("SRF/UI/Copy Layout Element")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement // TypeDefIndex: 62105
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
		public float preferredWidth { get; } // 0x000000018ACA42C0-0x000000018ACA4348 
		public float preferredHeight { get; } // 0x000000018ACA4238-0x000000018ACA42C0 
		public float minWidth { get; } // 0x000000018ACA41B0-0x000000018ACA4238 
		public float minHeight { get; } // 0x000000018ACA4128-0x000000018ACA41B0 
		public int layoutPriority { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
	
		// Constructors
		public CopyLayoutElement(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("SRF/UI/Copy Preferred Size")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyPreferredSize : LayoutElement // TypeDefIndex: 62106
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
	
		// Properties
		public override float preferredWidth { get; } // 0x000000018ACA43C8-0x000000018ACA4448 
		public override float preferredHeight { get; } // 0x000000018ACA4348-0x000000018ACA43C8 
		public override int layoutPriority { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	
		// Constructors
		public CopyPreferredSize(); // 0x0000000184D77950-0x0000000184D77960
	}

	[AddComponentMenu("SRF/UI/Copy Preferred Size (Multiple)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyPreferredSizes : LayoutElement // TypeDefIndex: 62109
	{
		// Fields
		public CopySource[] CopySources; // 0x38
		public Operations Operation; // 0x40
	
		// Properties
		public override float preferredWidth { get; } // 0x000000018ACA45D0-0x000000018ACA4758 
		public override float preferredHeight { get; } // 0x000000018ACA4448-0x000000018ACA45D0 
		public override int layoutPriority { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	
		// Nested types
		public enum Operations // TypeDefIndex: 62107
		{
			Max = 0,
			Min = 1
		}
	
		[Serializable]
		public class CopySource // TypeDefIndex: 62108
		{
			// Fields
			public RectTransform Rect; // 0x10
			public float PaddingHeight; // 0x18
			public float PaddingWidth; // 0x1C
	
			// Constructors
			public CopySource(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CopyPreferredSizes(); // 0x0000000184D77950-0x0000000184D77960
	}

	[AddComponentMenu("SRF/UI/Copy Size Into Layout Element")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopySizeIntoLayoutElement : LayoutElement // TypeDefIndex: 62110
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
		public bool SetPreferredSize; // 0x48
		public bool SetMinimumSize; // 0x49
	
		// Properties
		public override float preferredWidth { get; } // 0x000000018ACA492C-0x000000018ACA49C8 
		public override float preferredHeight { get; } // 0x000000018ACA4890-0x000000018ACA492C 
		public override float minWidth { get; } // 0x000000018ACA47F4-0x000000018ACA4890 
		public override float minHeight { get; } // 0x000000018ACA4758-0x000000018ACA47F4 
		public override int layoutPriority { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	
		// Constructors
		public CopySizeIntoLayoutElement(); // 0x0000000184D77950-0x0000000184D77960
	}

	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 62111
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
		private float Mult { get; } // 0x000000018ACA5108-0x000000018ACA5124 
	
		// Constructors
		public DragHandle(); // 0x000000018ACA50EC-0x000000018ACA5108
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018ACA4CE0-0x000000018ACA4D10
		public void OnDrag(PointerEventData eventData); // 0x000000018ACA4D10-0x000000018ACA4E40
		public void OnEndDrag(PointerEventData eventData); // 0x000000018ACA4E40-0x000000018ACA4E98
		private void Start(); // 0x000000018ACA4FE0-0x000000018ACA5030
		private bool Verify(); // 0x000000018ACA5030-0x000000018ACA50EC
		private float GetCurrentValue(); // 0x000000018ACA4B1C-0x000000018ACA4C3C
		private void SetCurrentValue(float value); // 0x000000018ACA4E98-0x000000018ACA4FE0
		private void CommitCurrentValue(); // 0x000000018ACA4A1C-0x000000018ACA4B1C
		private float GetMinSize(); // 0x000000018ACA4C58-0x000000018ACA4CE0
		private float GetMaxSize(); // 0x000000018ACA4C3C-0x000000018ACA4C58
	}

	[AddComponentMenu("SRF/UI/Flash Graphic")]
	[ExecuteInEditMode]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 62112
	{
		// Fields
		public float DecayTime; // 0x18
		public UnityEngine.Color DefaultColor; // 0x1C
		public UnityEngine.Color FlashColor; // 0x2C
		public Graphic Target; // 0x40
		private bool _isHoldingUntilNextPress; // 0x48
	
		// Constructors
		public FlashGraphic(); // 0x000000018ACA52BC-0x000000018ACA5308
	
		// Methods
		public void OnPointerDown(PointerEventData eventData); // 0x000000018ACA5228-0x000000018ACA5270
		public void OnPointerUp(PointerEventData eventData); // 0x000000018ACA5270-0x000000018ACA52BC
		protected override void OnEnable(); // 0x000000018ACA51E4-0x000000018ACA5228
		public void Flash(); // 0x000000018ACA516C-0x000000018ACA51E4
		public void FlashAndHoldUntilNextPress(); // 0x000000018ACA5124-0x000000018ACA516C
	}

	[AddComponentMenu("SRF/UI/Inherit Colour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Graphic))]
	public class InheritColour : SRMonoBehaviour // TypeDefIndex: 62113
	{
		// Fields
		private Graphic _graphic; // 0x48
		public Graphic From; // 0x50
	
		// Properties
		private Graphic Graphic { get; } // 0x000000018ACA5E88-0x000000018ACA5F0C 
	
		// Constructors
		public InheritColour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Refresh(); // 0x000000018ACA5DD0-0x000000018ACA5E80
		private void Update(); // 0x000000018ACA5E80-0x000000018ACA5E88
		private void Start(); // 0x000000018ACA5E80-0x000000018ACA5E88
	}

	[AddComponentMenu("SRF/UI/Long Press Button")]
	public class LongPressButton : UnityEngine.UI.Button // TypeDefIndex: 62114
	{
		// Fields
		private bool _handled; // 0x190
		[SerializeField]
		private ButtonClickedEvent _onLongPress; // 0x198
		private bool _pressed; // 0x1A0
		private float _pressedTime; // 0x1A4
		public float LongPressDuration; // 0x1A8
	
		// Properties
		public ButtonClickedEvent onLongPress { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
	
		// Constructors
		public LongPressButton(); // 0x000000018ACA6040-0x000000018ACA60C0
	
		// Methods
		public override void OnPointerExit(PointerEventData eventData); // 0x000000018ACA5F98-0x000000018ACA5FB8
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018ACA5F44-0x000000018ACA5F98
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018ACA5FB8-0x000000018ACA5FE8
		public override void OnPointerClick(PointerEventData eventData); // 0x000000018ACA5F30-0x000000018ACA5F44
		private void Update(); // 0x000000018ACA5FE8-0x000000018ACA6040
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public abstract class ResponsiveBase : SRMonoBehaviour // TypeDefIndex: 62115
	{
		// Fields
		private bool _queueRefresh; // 0x48
	
		// Properties
		protected RectTransform RectTransform { get; } // 0x000000018ACA7650-0x000000018ACA76A0 
	
		// Constructors
		protected ResponsiveBase(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected void OnEnable(); // 0x0000000184D99870-0x0000000184D99880
		protected void OnRectTransformDimensionsChange(); // 0x0000000184D99870-0x0000000184D99880
		protected void Update(); // 0x000000018ACA7628-0x000000018ACA7650
		protected abstract void Refresh();
		[ContextMenu("Refresh")]
		private void DoRefresh(); // 0x000000018ABD817C-0x000000018ABD818C
	}

	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveEnable : ResponsiveBase // TypeDefIndex: 62118
	{
		// Fields
		public Entry[] Entries; // 0x50
	
		// Nested types
		public enum Modes // TypeDefIndex: 62116
		{
			EnableAbove = 0,
			EnableBelow = 1
		}
	
		[Serializable]
		public struct Entry // TypeDefIndex: 62117
		{
			// Fields
			public UnityEngine.Behaviour[] Components; // 0x00
			public GameObject[] GameObjects; // 0x08
			public Modes Mode; // 0x10
			public float ThresholdHeight; // 0x14
			public float ThresholdWidth; // 0x18
		}
	
		// Constructors
		public ResponsiveEnable(); // 0x000000018ACA791C-0x000000018ACA796C
	
		// Methods
		protected override void Refresh(); // 0x000000018ACA76A0-0x000000018ACA791C
	}

	[AddComponentMenu("SRF/UI/Responsive (Resize)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveResize : ResponsiveBase // TypeDefIndex: 62121
	{
		// Fields
		public Element[] Elements; // 0x50
	
		// Nested types
		[Serializable]
		public struct Element // TypeDefIndex: 62120
		{
			// Fields
			public SizeDefinition[] SizeDefinitions; // 0x00
			public RectTransform Target; // 0x08
	
			// Nested types
			[Serializable]
			public struct SizeDefinition // TypeDefIndex: 62119
			{
				// Fields
				[Tooltip("Width to apply when over the threshold width")]
				public float ElementWidth; // 0x00
				[Tooltip("Threshold over which this width will take effect")]
				public float ThresholdWidth; // 0x04
			}
		}
	
		// Constructors
		public ResponsiveResize(); // 0x000000018ACA7B18-0x000000018ACA7B68
	
		// Methods
		protected override void Refresh(); // 0x000000018ACA796C-0x000000018ACA7B18
	}

	[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ScrollToBottomBehaviour : MonoBehaviour // TypeDefIndex: 62122
	{
		// Fields
		[SerializeField]
		private ScrollRect _scrollRect; // 0x18
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x20
		[SerializeField]
		private bool _scrollToTop; // 0x28
	
		// Constructors
		public ScrollToBottomBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Start(); // 0x000000018ACAA438-0x000000018ACAA594
		private void OnEnable(); // 0x000000018ACAA300-0x000000018ACAA308
		public void Trigger(); // 0x000000018ACAA594-0x000000018ACAA5D4
		private void OnScrollRectValueChanged(Vector2 position); // 0x000000018ACAA300-0x000000018ACAA308
		private void Refresh(); // 0x000000018ACAA308-0x000000018ACAA3AC
		private void SetVisible(bool truth); // 0x000000018ACAA3AC-0x000000018ACAA438
	}

	[AddComponentMenu("SRF/UI/SRNumberButton")]
	public class SRNumberButton : UnityEngine.UI.Button, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 62123
	{
		// Fields
		private const float ExtraThreshold = 3f; // Metadata: 0x023501C4
		public const float Delay = 0.4f; // Metadata: 0x023501C8
		private float _delayTime; // 0x190
		private float _downTime; // 0x194
		private bool _isDown; // 0x198
		public double Amount; // 0x1A0
		public SRNumberSpinner TargetField; // 0x1A8
	
		// Constructors
		public SRNumberButton(); // 0x000000018ACA956C-0x000000018ACA9584
	
		// Methods
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018ACA9470-0x000000018ACA94C0
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018ACA94C0-0x000000018ACA94E0
		protected virtual void Update(); // 0x000000018ACA94E0-0x000000018ACA956C
		private void Apply(); // 0x000000018ACA9370-0x000000018ACA9470
	}

	[AddComponentMenu("SRF/UI/SRNumberSpinner")]
	public class SRNumberSpinner : InputField // TypeDefIndex: 62124
	{
		// Fields
		private double _currentValue; // 0x2A8
		private double _dragStartAmount; // 0x2B0
		private double _dragStep; // 0x2B8
		public float DragSensitivity; // 0x2C0
		public double MaxValue; // 0x2C8
		public double MinValue; // 0x2D0
	
		// Constructors
		public SRNumberSpinner(); // 0x000000018ACA9AA0-0x000000018ACA9B0C
	
		// Methods
		protected override void Awake(); // 0x000000018ACA9584-0x000000018ACA9600
		public override void OnPointerClick(PointerEventData eventData); // 0x000000018ACA99B8-0x000000018ACA9AA0
		public override void OnPointerDown(PointerEventData eventData); // 0x00000001841E1670-0x00000001841E1680
		public override void OnPointerUp(PointerEventData eventData); // 0x00000001841E1670-0x00000001841E1680
		public override void OnBeginDrag(PointerEventData eventData); // 0x000000018ACA9600-0x000000018ACA9804
		public override void OnDrag(PointerEventData eventData); // 0x000000018ACA9804-0x000000018ACA996C
		public override void OnEndDrag(PointerEventData eventData); // 0x000000018ACA996C-0x000000018ACA99B8
	}

	[AddComponentMenu("SRF/UI/Retina Scaler")]
	[RequireComponent(typeof(CanvasScaler))]
	public class SRRetinaScaler : SRMonoBehaviour // TypeDefIndex: 62125
	{
		// Fields
		[SerializeField]
		private bool _disablePixelPerfect; // 0x48
		[SerializeField]
		private int _designDpi; // 0x4C
		private float _lastDpi; // 0x50
	
		// Constructors
		public SRRetinaScaler(); // 0x000000018ACA9D14-0x000000018ACA9D30
	
		// Methods
		private void Start(); // 0x000000018ACA9CDC-0x000000018ACA9CE4
		private void ApplyScaling(); // 0x000000018ACA9BF4-0x000000018ACA9CDC
		private void Update(); // 0x000000018ACA9CE4-0x000000018ACA9D14
	}

	[AddComponentMenu("SRF/UI/Spinner")]
	public class SRSpinner : Selectable, IDragHandler, IBeginDragHandler // TypeDefIndex: 62127
	{
		// Fields
		private float _dragDelta; // 0x188
		[SerializeField]
		private SpinEvent _onSpinDecrement; // 0x190
		[SerializeField]
		private SpinEvent _onSpinIncrement; // 0x198
		public float DragThreshold; // 0x1A0
	
		// Properties
		public SpinEvent OnSpinIncrement { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x0000000185397218-0x000000018539722C
		public SpinEvent OnSpinDecrement { get; set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018539722C-0x0000000185397240
	
		// Nested types
		[Serializable]
		public class SpinEvent : UnityEvent // TypeDefIndex: 62126
		{
			// Constructors
			public SpinEvent(); // 0x0000000185393538-0x0000000185393540
		}
	
		// Constructors
		public SRSpinner(); // 0x000000018ACAA0D8-0x000000018ACAA1A0
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000184DA9ED0-0x0000000184DA9EE0
		public void OnDrag(PointerEventData eventData); // 0x000000018ACA9FBC-0x000000018ACAA08C
		private void OnIncrement(int amount); // 0x000000018ACAA08C-0x000000018ACAA0D8
		private void OnDecrement(int amount); // 0x000000018ACA9F70-0x000000018ACA9FBC
	}

	[AddComponentMenu("SRF/UI/SRText")]
	public class SRText : UnityEngine.UI.Text // TypeDefIndex: 62128
	{
		// Fields
		[CompilerGenerated]
		private Action<SRText> LayoutDirty; // 0x118
	
		// Events
		public event Action<SRText> LayoutDirty {
			add; // 0x000000018ACAA1E0-0x000000018ACAA270
			remove; // 0x000000018ACAA270-0x000000018ACAA300
		}
	
		// Constructors
		public SRText(); // 0x000000018ACAA1D8-0x000000018ACAA1E0
	
		// Methods
		public override void SetLayoutDirty(); // 0x000000018ACAA1A0-0x000000018ACAA1D8
	}

	[AddComponentMenu("SRF/UI/Style Component")]
	[ExecuteInEditMode]
	public class StyleComponent : SRMonoBehaviour // TypeDefIndex: 62129
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
		public string StyleKey { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x000000018ACABC9C-0x000000018ACABCC4
	
		// Constructors
		public StyleComponent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018ACABC7C-0x000000018ACABC9C
		private void OnEnable(); // 0x000000018ACABA50-0x000000018ACABA64
		public void Refresh(bool invalidateCache); // 0x000000018ACABA64-0x000000018ACABC2C
		private StyleRoot GetStyleRoot(); // 0x000000018ACAB900-0x000000018ACABA50
		private void ApplyStyle(); // 0x000000018ACAB614-0x000000018ACAB900
		private void SRStyleDirty(); // 0x000000018ACABC2C-0x000000018ACABC7C
	}

	[AddComponentMenu("SRF/UI/Style Root")]
	[ExecuteInEditMode]
	public sealed class StyleRoot : SRMonoBehaviour // TypeDefIndex: 62130
	{
		// Fields
		private StyleSheet _activeStyleSheet; // 0x48
		public StyleSheet StyleSheet; // 0x50
	
		// Constructors
		public StyleRoot(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public SRF.UI.Style GetStyle(string key); // 0x000000018ACABCC4-0x000000018ACABD80
		private void OnEnable(); // 0x000000018ACABD88-0x000000018ACABDF8
		private void OnDisable(); // 0x000000018ACABD80-0x000000018ACABD88
		private void Update(); // 0x000000018ACABE4C-0x000000018ACABEBC
		private void OnStyleSheetChanged(); // 0x000000018ACABDF8-0x000000018ACABE4C
		public void SetDirty(); // 0x00000001870A7CA8-0x00000001870A7CBC
	}

	[Serializable]
	public class Style // TypeDefIndex: 62131
	{
		// Fields
		public UnityEngine.Color ActiveColor; // 0x10
		public UnityEngine.Color DisabledColor; // 0x20
		public UnityEngine.Color HoverColor; // 0x30
		public Sprite Image; // 0x40
		public UnityEngine.Color NormalColor; // 0x48
	
		// Constructors
		public Style(); // 0x000000018ACAC124-0x000000018ACAC17C
	
		// Methods
		public Style Copy(); // 0x000000018ACAC0B8-0x000000018ACAC124
		public void CopyFrom(Style style); // 0x000000018ACAC05C-0x000000018ACAC0B8
	}

	[Serializable]
	public class StyleSheet : ScriptableObject // TypeDefIndex: 62132
	{
		// Fields
		[SerializeField]
		private List<string> _keys; // 0x18
		[SerializeField]
		private List<SRF.UI.Style> _styles; // 0x20
		[SerializeField]
		public StyleSheet Parent; // 0x28
	
		// Constructors
		public StyleSheet(); // 0x000000018ACABF94-0x000000018ACAC05C
	
		// Methods
		public SRF.UI.Style GetStyle(string key, bool searchParent = true /* Metadata: 0x023501CC */); // 0x000000018ACABEBC-0x000000018ACABF94
	}

	[AddComponentMenu("SRF/UI/Unselectable")]
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler // TypeDefIndex: 62133
	{
		// Fields
		private bool _suspectedSelected; // 0x48
	
		// Constructors
		public Unselectable(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void OnSelect(BaseEventData eventData); // 0x0000000184D99870-0x0000000184D99880
		private void Update(); // 0x000000018ACAD738-0x000000018ACAD800
	}
}

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup // TypeDefIndex: 62134
	{
		// Fields
		private readonly IList<RectTransform> _rowList; // 0x58
		private float _layoutHeight; // 0x60
		public bool ChildForceExpandHeight; // 0x64
		public bool ChildForceExpandWidth; // 0x65
		public float Spacing; // 0x68
	
		// Properties
		protected bool IsCenterAlign { get; } // 0x000000018ACA5D24-0x000000018ACA5D3C 
		protected bool IsRightAlign { get; } // 0x000000018ACA5D6C-0x000000018ACA5D84 
		protected bool IsMiddleAlign { get; } // 0x000000018ACA5D54-0x000000018ACA5D6C 
		protected bool IsLowerAlign { get; } // 0x000000018ACA5D3C-0x000000018ACA5D54 
	
		// Constructors
		public FlowLayoutGroup(); // 0x000000018ACA5CA4-0x000000018ACA5D24
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x000000018ACA5308-0x000000018ACA538C
		public override void SetLayoutHorizontal(); // 0x000000018ACA57C4-0x000000018ACA5810
		public override void SetLayoutVertical(); // 0x000000018ACA5810-0x000000018ACA585C
		public override void CalculateLayoutInputVertical(); // 0x000000018ACA538C-0x000000018ACA53E0
		public float SetLayout(float width, int axis, bool layoutInput); // 0x000000018ACA585C-0x000000018ACA5CA4
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight); // 0x000000018ACA53E0-0x000000018ACA5464
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis); // 0x000000018ACA54F4-0x000000018ACA57C4
		public float GetGreatestMinimumChildWidth(); // 0x000000018ACA5464-0x000000018ACA54F4
	}

	public interface IVirtualView // TypeDefIndex: 62135
	{
		// Methods
		void SetDataContext(object data);
	}

	[AddComponentMenu("SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler // TypeDefIndex: 62138
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
		public SelectedItemChangedEvent SelectedItemChanged { get; set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public object SelectedItem { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x000000018ACAF114-0x000000018ACAF278
		public override float minHeight { get; } // 0x000000018ACAF048-0x000000018ACAF114 
		private ScrollRect ScrollRect { get; } // 0x000000018ACAEFC4-0x000000018ACAF048 
		private bool AlignBottom { get; } // 0x000000018ACAEE48-0x000000018ACAEE60 
		private bool AlignTop { get; } // 0x000000018ACAEE60-0x000000018ACAEE78 
		private float ItemHeight { get; } // 0x000000018ACAEE78-0x000000018ACAEFC4 
	
		// Nested types
		[Serializable]
		public class SelectedItemChangedEvent : UnityEvent<object> // TypeDefIndex: 62136
		{
			// Constructors
			public SelectedItemChangedEvent(); // 0x000000018ACAA5D4-0x000000018ACAA610
		}
	
		[Serializable]
		private class Row // TypeDefIndex: 62137
		{
			// Fields
			public object Data; // 0x10
			public int Index; // 0x18
			public RectTransform Rect; // 0x20
			public StyleRoot Root; // 0x28
			public IVirtualView View; // 0x30
	
			// Constructors
			public Row(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public VirtualVerticalLayoutGroup(); // 0x000000018ACAED28-0x000000018ACAEE48
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018ACAE074-0x000000018ACAE1E4
		protected override void Awake(); // 0x000000018ACAD90C-0x000000018ACADA74
		private void OnScrollRectValueChanged(Vector2 d); // 0x000000018ACAE1E4-0x000000018ACAE23C
		protected override void Start(); // 0x000000018ACAEC44-0x000000018ACAEC4C
		protected override void OnEnable(); // 0x000000018ACAE054-0x000000018ACAE074
		protected void Update(); // 0x000000018ACAEC4C-0x000000018ACAED28
		protected void InvalidateItem(int itemIndex); // 0x000000018ACADF2C-0x000000018ACAE054
		protected void RefreshIndexCache(); // 0x000000018ACAE454-0x000000018ACAE528
		protected void ScrollUpdate(); // 0x000000018ACAE5D8-0x000000018ACAE928
		public override void CalculateLayoutInputVertical(); // 0x000000018ACADA74-0x000000018ACADABC
		public override void SetLayoutHorizontal(); // 0x000000018ACAE954-0x000000018ACAEB00
		public override void SetLayoutVertical(); // 0x000000018ACAEB00-0x000000018ACAEC44
		private new void SetDirty(); // 0x000000018ACAE928-0x000000018ACAE954
		public void AddItem(object item); // 0x000000018ACAD800-0x000000018ACAD90C
		public void RemoveItem(object item); // 0x000000018ACAE528-0x000000018ACAE5D8
		public void ClearItems(); // 0x000000018ACADABC-0x000000018ACADB70
		private Row GetRow(int forIndex); // 0x000000018ACADD70-0x000000018ACADF2C
		private void RecycleRow(Row row); // 0x000000018ACAE400-0x000000018ACAE454
		private void PopulateRow(int index, Row row); // 0x000000018ACAE23C-0x000000018ACAE400
		private Row CreateRow(); // 0x000000018ACADB70-0x000000018ACADD70
	}
}
