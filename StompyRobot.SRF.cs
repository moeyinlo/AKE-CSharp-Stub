/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using SRF;
using SRF.Components;
using SRF.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Image 65: StompyRobot.SRF.dll - Assembly: StompyRobot.SRF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59303-59392

public static class SRDebugUtil // TypeDefIndex: 59304
{
	// Fields
	public const int LineBufferCount = 512; // Metadata: 0x020805E3
	private static bool _IsFixedUpdate_k__BackingField; // 0x00

	// Properties
	public static bool IsFixedUpdate { get; set; } // 0x000000018B7EFAF0-0x000000018B7EFB28 0x000000018B7EFB28-0x000000018B7EFB64

	// Methods
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null) {} // 0x000000018B7EF864-0x000000018B7EF9E8
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null) {} // 0x000000018B7EF9E8-0x000000018B7EFAE0
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null) {} // 0x000000018B7EFAE0-0x000000018B7EFAE8
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null) {} // 0x000000018B7EFAE8-0x000000018B7EFAF0
}

public static class SRFileUtil // TypeDefIndex: 59305
{
	// Methods
	public static void DeleteDirectory(string path) {} // 0x000000018B7F0144-0x000000018B7F01D8
	public static string GetBytesReadable(long i) => default; // 0x0000000183FC5110-0x0000000183FC5260
}

public static class SRInstantiate // TypeDefIndex: 59306
{
	// Methods
	public static T Instantiate<T>(T prefab)
		where T : UnityEngine.Component => default;
	public static GameObject Instantiate(GameObject prefab) => default; // 0x000000018B7F01D8-0x000000018B7F022C
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation)
		where T : UnityEngine.Component => default;
}

public static class SRMath // TypeDefIndex: 59309
{
	// Nested types
	public enum EaseType // TypeDefIndex: 59307
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

	private static class TweenFunctions // TypeDefIndex: 59308
	{
		// Methods
		public static float Linear(float t, float b, float c, float d) => default; // 0x0000000185FD5EA0-0x0000000185FD5EC0
		public static float ExpoEaseOut(float t, float b, float c, float d) => default; // 0x0000000185FD5E40-0x0000000185FD5EA0
		public static float ExpoEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F097C-0x000000018B7F09EC
		public static float ExpoEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F0D04-0x000000018B7F0D2C
		public static float ExpoEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F09EC-0x000000018B7F0A5C
		public static float CircEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F0D2C-0x000000018B7F0DC0
		public static float CircEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F0DC0-0x000000018B7F0DE4
		public static float CircEaseInOut(float t, float b, float c, float d) => default; // 0x0000000185FD5E30-0x0000000185FD5E40
		public static float CircEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F022C-0x000000018B7F02F0
		public static float QuadEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F02F0-0x000000018B7F097C
		public static float QuadEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F0C3C-0x000000018B7F0C8C
		public static float QuadEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F0BFC-0x000000018B7F0C3C
		public static float QuadEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F0B74-0x000000018B7F0BFC
		public static float SineEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F0C8C-0x000000018B7F0D04
		public static float SineEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F0A5C-0x000000018B7F0B74
		public static float SineEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F4A08-0x000000018B7F4A18
		public static float SineEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F49A0-0x000000018B7F4A08
		public static float CubicEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F48E0-0x000000018B7F4940
		public static float CubicEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F4830-0x000000018B7F48E0
		public static float CubicEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F4940-0x000000018B7F49A0
		public static float CubicEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F4390-0x000000018B7F43DC
		public static float QuartEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F4298-0x000000018B7F42F4
		public static float QuartEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F4204-0x000000018B7F4298
		public static float QuartEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F42F4-0x000000018B7F4390
		public static float QuartEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F4B0C-0x000000018B7F4B30
		public static float QuintEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F4A78-0x000000018B7F4A90
		public static float QuintEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F4A18-0x000000018B7F4A78
		public static float QuintEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F4A90-0x000000018B7F4B0C
		public static float QuintEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F4FAC-0x000000018B7F4FE8
		public static float ElasticEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F4EB4-0x000000018B7F4F00
		public static float ElasticEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F4E20-0x000000018B7F4EB4
		public static float ElasticEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F4F00-0x000000018B7F4FAC
		public static float ElasticEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F44F8-0x000000018B7F4524
		public static float BounceEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F444C-0x000000018B7F4468
		public static float BounceEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F43DC-0x000000018B7F444C
		public static float BounceEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F4468-0x000000018B7F44F8
		public static float BounceEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F4C70-0x000000018B7F4CA8
		public static float BackEaseOut(float t, float b, float c, float d) => default; // 0x000000018B7F4BB0-0x000000018B7F4BD0
		public static float BackEaseIn(float t, float b, float c, float d) => default; // 0x000000018B7F4B30-0x000000018B7F4BB0
		public static float BackEaseInOut(float t, float b, float c, float d) => default; // 0x000000018B7F4BD0-0x000000018B7F4C70
		public static float BackEaseOutIn(float t, float b, float c, float d) => default; // 0x000000018B7F4DEC-0x000000018B7F4E20
	}

	// Methods
	public static float LerpUnclamped(float from, float to, float t) => default; // 0x000000018B7F4D28-0x000000018B7F4D4C
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t) => default; // 0x000000018B7F4CA8-0x000000018B7F4D28
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2) => default; // 0x000000018B7F4D4C-0x000000018B7F4DEC
	public static float WrapAngle(float angle) => default; // 0x000000018B7F4770-0x000000018B7F4830
	public static float NearestAngle(float to, float angle1, float angle2) => default; // 0x000000018B7F4644-0x000000018B7F4710
	public static int Wrap(int max, int value) => default; // 0x000000018B7F4524-0x000000018B7F4644
	public static float Wrap(float max, float value) => default; // 0x000000018B7F4710-0x000000018B7F4770
	public static float Average(float v1, float v2) => default; // 0x000000018B7F4144-0x000000018B7F4204
	public static float Angle(Vector2 direction) => default; // 0x000000018B7F4068-0x000000018B7F40B4
	public static float Ease(float from, float to, float t, EaseType type) => default; // 0x000000018B7F3FD0-0x000000018B7F4068
	public static float SpringLerp(float strength, float deltaTime) => default; // 0x000000018B7F40B4-0x000000018B7F4144
	public static float SpringLerp(float from, float to, float strength, float deltaTime) => default; // 0x000000018B7F3F94-0x000000018B7F3FD0
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) => default; // 0x000000018B7F3EB8-0x000000018B7F3EE4
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime) => default; // 0x000000018B7F3E30-0x000000018B7F3EB8
	public static float SmoothClamp(float value, float min, float max, float scrollMax, EaseType easeType = EaseType.ExpoEaseOut /* Metadata: 0x020805E5 */) => default; // 0x000000018B7F3EE4-0x000000018B7F3F94
}

namespace SRF
{
	public static class Json // TypeDefIndex: 59313
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 59311
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x0208060F
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get => default; } // 0x000000018B7EDC24-0x000000018B7EDC2C 
			private char NextChar { get => default; } // 0x000000018B7EE708-0x000000018B7EE780 
			private string NextWord { get => default; } // 0x000000018B7EEAB0-0x000000018B7EEB0C 
			private TOKEN NextToken { get => default; } // 0x000000018B7EE780-0x000000018B7EE7DC 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 59310
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
			public Parser() {} // Dummy constructor
			private Parser(string jsonString) {} // 0x000000018B7EDC08-0x000000018B7EDC24
	
			// Methods
			public void Dispose() {} // 0x000000018B7EEA00-0x000000018B7EEAB0
			public static bool IsWordBreak(char c) => default; // 0x000000018B7EE7DC-0x000000018B7EEA00
			public static object Parse(string jsonString) => default; // 0x000000018A8DC720-0x000000018A8DC758
			private Dictionary<string, object> ParseObject() => default; // 0x000000018B7EDFFC-0x000000018B7EE074
			private List<object> ParseArray() => default; // 0x000000018B7EE610-0x000000018B7EE708
			private object ParseValue() => default; // 0x000000018B7EE2B4-0x000000018B7EE3C0
			private object ParseByToken(TOKEN token) => default; // 0x000000018B7EE074-0x000000018B7EE13C
			private string ParseString() => default; // 0x000000018B7EE5EC-0x000000018B7EE610
			private object ParseNumber() => default; // 0x000000018B7EE13C-0x000000018B7EE1F0
			private void EatWhitespace() {} // 0x000000018B7EE3C0-0x000000018B7EE5EC
		}
	
		private sealed class Serializer // TypeDefIndex: 59312
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x000000018B7EE1F0-0x000000018B7EE2B4
	
			// Methods
			public static string Serialize(object obj) => default; // 0x000000018B7EDF6C-0x000000018B7EDFFC
			private void SerializeValue(object value) {} // 0x000000018B7F3124-0x000000018B7F3188
			private void SerializeObject(IDictionary obj) {} // 0x000000018B7F30AC-0x000000018B7F3124
			private void SerializeArray(IList anArray) {} // 0x000000018B7F2F28-0x000000018B7F30AC
			private void SerializeString(string str) {} // 0x000000018B7F2648-0x000000018B7F2A50
			private void SerializeOther(object value) {} // 0x000000018B7F22C4-0x000000018B7F2648
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x000000018B7F2CB0-0x000000018B7F2F28
		public static string Serialize(object obj) => default; // 0x000000018B7F2A50-0x000000018B7F2CB0
	}

	[Serializable]
	public class SRList<T> : IList<T>, ISerializationCallbackReceiver // TypeDefIndex: 59315
	{
		// Fields
		private T[] _buffer;
		private int _count;
		private EqualityComparer<T> _equalityComparer;
		private ReadOnlyCollection<T> _readOnlyWrapper;
	
		// Properties
		public T[] Buffer { get => default; private set {} }
		private EqualityComparer<T> EqualityComparer { get => default; }
		public int Count { get => default; private set {} }
		public bool IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		private sealed class _GetEnumerator_d__15 : IEnumerator<T> // TypeDefIndex: 59314
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public SRList<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__15() {} // Dummy constructor
			public _GetEnumerator_d__15(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public SRList() {}
		public SRList(int capacity) {}
		public SRList(IEnumerable<T> source) {}
	
		// Methods
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		public void OnBeforeSerialize() {}
		public void OnAfterDeserialize() {}
		public void AddRange(IEnumerable<T> range) {}
		public void Clear(bool clean) {}
		public void Clean() {}
		public ReadOnlyCollection<T> AsReadOnly() => default;
		private void Expand() {}
		public void Trim() {}
		public void Sort(Comparison<T> comparer) {}
	}

	public abstract class SRMonoBehaviour : MonoBehaviour // TypeDefIndex: 59316
	{
		// Fields
		private Collider _collider; // 0x18
		private Transform _transform; // 0x20
		private Rigidbody _rigidBody; // 0x28
		private GameObject _gameObject; // 0x30
		private Rigidbody2D _rigidbody2D; // 0x38
		private Collider2D _collider2D; // 0x40
	
		// Properties
		public Transform CachedTransform { get; } // 0x0000000184A82E00-0x0000000184A82E80 
		public Collider CachedCollider { get; } // 0x000000018B7F0E9C-0x000000018B7F0F20 
		public Collider2D CachedCollider2D { get; } // 0x000000018B7F0E18-0x000000018B7F0E9C 
		public Rigidbody CachedRigidBody { get; } // 0x000000018B7F0FA4-0x000000018B7F1028 
		public Rigidbody2D CachedRigidBody2D { get; } // 0x000000018B7F0F20-0x000000018B7F0FA4 
		public GameObject CachedGameObject { get; } // 0x0000000184A82D80-0x0000000184A82E00 
		public new Transform transform { get; } // 0x000000018B7F1028-0x000000018B7F1030 
	
		// Constructors
		protected SRMonoBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected void AssertNotNull(object value, string fieldName = null) {} // 0x000000018B7F0DE4-0x000000018B7F0DFC
		protected void Assert(bool condition, string message = null) {} // 0x000000018B7F0DFC-0x000000018B7F0E18
		protected void EditorAssertNotNull(object value, string fieldName = null) {} // 0x000000018B7F0DE4-0x000000018B7F0DFC
		protected void EditorAssert(bool condition, string message = null) {} // 0x000000018B7F0DFC-0x000000018B7F0E18
	}

	public sealed class RequiredFieldAttribute : Attribute // TypeDefIndex: 59317
	{
		// Fields
		private bool _autoCreate; // 0x10
		private bool _autoSearch; // 0x11
		private bool _editorOnly; // 0x12
	
		// Properties
		public bool AutoSearch { get => default; set {} } // 0x0000000185FB22C0-0x0000000185FB22D0 0x0000000185FB2560-0x0000000185FB2570
		public bool AutoCreate { get => default; set {} } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public bool EditorOnly { get => default; set {} } // 0x0000000185FB22D0-0x0000000185FB22E0 0x0000000183B7E590-0x0000000183B7E5A0
	
		// Constructors
		public RequiredFieldAttribute(bool autoSearch) {} // 0x0000000185FD5E20-0x0000000185FD5E30
		public RequiredFieldAttribute() {} // 0x0000000185FC5B90-0x0000000185FC5BA0
	}

	public class ImportAttribute : Attribute // TypeDefIndex: 59318
	{
		// Fields
		public readonly System.Type Service; // 0x10
	
		// Constructors
		public ImportAttribute() {} // 0x0000000185492010-0x0000000185492020
		public ImportAttribute(System.Type serviceType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public abstract class SRMonoBehaviourEx : SRMonoBehaviour // TypeDefIndex: 59320
	{
		// Fields
		private static Dictionary<System.Type, IList<FieldInfo>> _checkedFields; // 0x00
	
		// Nested types
		private struct FieldInfo // TypeDefIndex: 59319
		{
			// Fields
			public bool AutoCreate; // 0x00
			public bool AutoSet; // 0x01
			public System.Reflection.FieldInfo Field; // 0x08
			public bool Import; // 0x10
			public System.Type ImportType; // 0x18
		}
	
		// Constructors
		protected SRMonoBehaviourEx() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false /* Metadata: 0x02080623 */) {} // 0x00000001844B73A0-0x00000001844B7540
		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet) {} // 0x00000001844B7540-0x00000001844B7630
		private static List<FieldInfo> ScanType(System.Type t) => default; // 0x00000001844B5A10-0x00000001844B5BA0
		protected virtual void Awake() {} // 0x0000000186475278-0x0000000186475284
		protected virtual void Start() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void Update() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void FixedUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDisable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class Coroutines // TypeDefIndex: 59322
	{
		// Nested types
		private sealed class _WaitForSecondsRealTime_d__0 : IEnumerator<object> // TypeDefIndex: 59321
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float time; // 0x20
			private float _endTime_5__2; // 0x24
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B7F533C-0x000000018B7F53A0 
			object IEnumerator.Current { get => default; } // 0x000000018B7F53A0-0x000000018B7F53EC 
	
			// Constructors
			public _WaitForSecondsRealTime_d__0() {} // Dummy constructor
			public _WaitForSecondsRealTime_d__0(int __1__state) {} // 0x000000018B7EC6E0-0x000000018B7EC734
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Methods
		public static IEnumerator WaitForSecondsRealTime(float time) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public static class SRFFloatExtensions // TypeDefIndex: 59323
	{
		// Methods
		public static float Sqr(float f) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static float SqrRt(float f) => default; // 0x0000000185FB2AC0-0x0000000185FB2AE0
		public static bool ApproxZero(float f) => default; // 0x000000018B7EFB64-0x000000018B7EFB70
		public static bool Approx(float f, float f2) => default; // 0x000000018B7EFB70-0x000000018B7EFB78
	}

	public static class SRFGameObjectExtensions // TypeDefIndex: 59324
	{
		// Methods
		public static T GetIComponent<T>(GameObject t)
			where T : class => default;
		public static T GetComponentOrAdd<T>(GameObject obj)
			where T : UnityEngine.Component => default;
		public static void RemoveComponentIfExists<T>(GameObject obj)
			where T : UnityEngine.Component {}
		public static void RemoveComponentsIfExists<T>(GameObject obj)
			where T : UnityEngine.Component {}
		public static bool EnableComponentIfExists<T>(GameObject obj, bool enable = true /* Metadata: 0x02080624 */)
			where T : MonoBehaviour => default;
		public static void SetLayerRecursive(GameObject o, int layer) {} // 0x000000018B7EFD10-0x000000018B7EFD3C
		private static void SetLayerInternal(Transform t, int layer) {} // 0x000000018B7EFB78-0x000000018B7EFD10
	}

	public static class SRFIListExtensions // TypeDefIndex: 59325
	{
		// Methods
		public static T Random<T>(IList<T> list) => default;
		public static T RandomOrDefault<T>(IList<T> list) => default;
		public static T PopLast<T>(IList<T> list) => default;
	}

	public static class SRFStringExtensions // TypeDefIndex: 59326
	{
		// Methods
		public static string Fmt(string formatString, object[] args) => default; // 0x000000018646D4D8-0x000000018646D4E0
	}

	public static class SRFTransformExtensions // TypeDefIndex: 59328
	{
		// Nested types
		private sealed class _GetChildren_d__0 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 59327
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform t; // 0x28
			public Transform __3__t; // 0x30
			private int _i_5__2; // 0x38
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { get => default; } // 0x000000018B7F0124-0x000000018B7F0144 
			object IEnumerator.Current { get => default; } // 0x000000018B7F0008-0x000000018B7F0090 
	
			// Constructors
			public _GetChildren_d__0() {} // Dummy constructor
			public _GetChildren_d__0(int __1__state) {} // 0x000000018B7EFF98-0x000000018B7F0008
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B7F0090-0x000000018B7F0124
			private bool MoveNext() => default; // 0x000000018B7EFD3C-0x000000018B7EFE04
			void IEnumerator.Reset() {} // 0x000000018B7C1BB4-0x000000018B7C1C70
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator() => default; // 0x000000018B7EFE04-0x000000018B7EFF98
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184775050-0x0000000184775070
		}
	
		// Methods
		public static IEnumerable<Transform> GetChildren(Transform t) => default; // 0x0000000185492010-0x0000000185492020
		public static void ResetLocal(Transform t) {} // 0x000000018B7F4FE8-0x000000018B7F5064
		public static GameObject CreateChild(Transform t, string name) => default; // 0x0000000181377E40-0x0000000181377E50
		public static void SetParentMaintainLocals(Transform t, Transform parent) {} // 0x000000018B7F5100-0x000000018B7F514C
		public static void SetLocals(Transform t, Transform from) {} // 0x0000000181377E40-0x0000000181377E50
		public static void Match(Transform t, Transform from) {} // 0x000000018B7F5064-0x000000018B7F50F8
		public static void DestroyChildren(Transform t) {} // 0x000000018B7F50F8-0x000000018B7F5100
	}

	public class Hierarchy // TypeDefIndex: 59329
	{
		// Fields
		private static readonly char[] Seperator; // 0x00
		private static readonly Dictionary<string, Transform> Cache; // 0x08
	
		// Properties
		public Transform this[string key] { get => default; } // 0x000000018B7EDA80-0x000000018B7EDACC 
	
		// Constructors
		public Hierarchy() {} // 0x0000000185492010-0x0000000185492020
		static Hierarchy() {} // 0x0000000185EBABE0-0x0000000185EBACD0
	
		// Methods
		public static Transform Get(string key) => default; // 0x0000000184A83C40-0x0000000184A83E40
		public static void RuntimeInitialize() {} // 0x0000000185F608E0-0x0000000185F60960
	}
}

namespace SRF.Components
{
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour // TypeDefIndex: 59390
		where T : SRAutoSingleton<T>
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { get; }
		public static bool HasInstance { get; }
	
		// Constructors
		protected SRAutoSingleton() {}
	
		// Methods
		protected virtual void Awake() {}
		protected virtual void OnEnable() {}
		private void OnApplicationQuit() {}
	}

	public abstract class SRSingleton<T> : SRMonoBehaviour // TypeDefIndex: 59391
		where T : SRSingleton<T>
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { get; }
		public static bool HasInstance { get; }
	
		// Constructors
		protected SRSingleton() {}
	
		// Methods
		private void Register() {}
		protected virtual void Awake() {}
		protected virtual void OnEnable() {}
		private void OnApplicationQuit() {}
	}
}

namespace SRF.Helpers
{
	public static class AssetUtil // TypeDefIndex: 59380
	{
	}

	public sealed class MethodReference // TypeDefIndex: 59383
	{
		// Fields
		private readonly Func<object[], object> _method; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 59381
		{
			// Fields
			public MethodInfo method; // 0x10
			public object target; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B7EDDBC-0x000000018B7EDE9C
	
			// Methods
			internal object _.ctor_b__0(object[] o) => default; // 0x0000000184096E30-0x0000000184096EF0
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 59382
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018A6B7AE4-0x000000018A6B7B04
	
			// Methods
			internal object _op_Implicit_b__0(object[] args) => default; // 0x000000018B7EDE9C-0x000000018B7EDF6C
		}
	
		// Constructors
		public MethodReference() {} // Dummy constructor
		public MethodReference(object target, MethodInfo method) {} // 0x0000000185492010-0x0000000185492020
		public MethodReference(Func<object[], object> method) {} // 0x000000018B7F51F8-0x000000018B7F5224
	
		// Methods
		public object Invoke(object[] parameters) => default; // 0x0000000185492010-0x0000000185492020
		public static implicit operator MethodReference(Action action) => default; // 0x000000018B7F52B8-0x000000018B7F52D8
	}

	public delegate void PropertyValueChangedHandler(PropertyReference property); // TypeDefIndex: 59384; 0x00000001833EEC70-0x00000001833EEC80

	public sealed class PropertyReference // TypeDefIndex: 59388
	{
		// Fields
		private readonly PropertyInfo _property; // 0x10
		private readonly object _target; // 0x18
		private readonly Attribute[] _attributes; // 0x20
		private readonly Func<object> _getter; // 0x28
		private readonly Action<object> _setter; // 0x30
		private List<PropertyValueChangedHandler> _valueChangedListeners; // 0x38
		private System.Type _PropertyType_k__BackingField; // 0x40
	
		// Properties
		public System.Type PropertyType { get; private set; } // 0x000000018B7EED28-0x000000018B7EEE44 
		public bool CanRead { get => default; }
		public bool CanWrite { get => default; }
	
		// Events
		public event PropertyValueChangedHandler ValueChanged;
	
		// Nested types
		private sealed class __c__DisplayClass9_0<T> // TypeDefIndex: 59385
		{
			// Fields
			public Action<T> setter;
			public Func<T> getter;
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x000000018B7EF098-0x000000018B7EF204
	
			// Methods
			internal void _FromLambda_b__0(object o) {} // 0x000000018B7EF204-0x000000018B7EF324
			internal object _FromLambda_b__1() => default;
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 59386
		{
			// Fields
			public object target; // 0x10
			public PropertyInfo property; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B7EEE44-0x000000018B7EF018
	
			// Methods
			internal object _.ctor_b__0() => default; // 0x000000018B7EF018-0x000000018B7EF098
			internal void _.ctor_b__1(object v) {} // 0x00000001813FF010-0x00000001813FF020
		}
	
		[Serializable]
		private sealed class __c__23<T> // TypeDefIndex: 59387
			where T : Attribute
		{
			// Fields
			public static readonly __c__23<T> __9;
			public static Func<Attribute, bool> __9__23_0;
	
			// Constructors
			static __c__23() {} // 0x0000000185F05C80-0x0000000185F05C90
			public __c__23() {}
	
			// Methods
			internal bool _GetAttribute_b__23_0(Attribute p) => default; // 0x000000018A6AD3DC-0x000000018A6AD3E8
		}
	
		// Constructors
		public PropertyReference() {} // Dummy constructor
		public PropertyReference(object target, PropertyInfo property) {}
		public PropertyReference(System.Type type, Func<object> getter = null, Action<object> setter = null, Attribute[] attributes = null) {} // 0x000000018B7EEC34-0x000000018B7EECB0
	
		// Methods
		public static PropertyReference FromLambda<T>(Func<T> getter, Action<T> setter = null, Attribute[] attributes) => default; // 0x000000018B7EECB0-0x000000018B7EED28
		public void NotifyValueChanged() {} // 0x0000000185492010-0x0000000185492020
		public object GetValue() => default; // 0x000000018B7F51D4-0x000000018B7F51E4
		public void SetValue(object value) {} // 0x000000018B7F51E4-0x000000018B7F51F8
		public T GetAttribute<T>()
			where T : Attribute => default;
		private void OnTargetPropertyChanged(object sender, PropertyChangedEventArgs e) {}
		public override string ToString() => default;
	}

	public static class SRReflection // TypeDefIndex: 59389
	{
		// Methods
		public static void SetPropertyValue(object obj, PropertyInfo p, object value) {} // 0x000000018B7F1808-0x000000018B7F18B4
		public static object GetPropertyValue(object obj, PropertyInfo p) => default; // 0x000000018B7F17CC-0x000000018B7F1808
		public static T GetAttribute<T>(MemberInfo t)
			where T : Attribute => default;
	}
}

namespace SRF.Internal
{
	internal static class ComponentMenuPaths // TypeDefIndex: 59392
	{
		// Fields
		public const string PathRoot = "SRF"; // Metadata: 0x02080633
		public const string SRServiceManager = "SRF/Service/Service Manager"; // Metadata: 0x02080637
		public const string BehavioursRoot = "SRF/Behaviours"; // Metadata: 0x02080653
		public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable"; // Metadata: 0x02080662
		public const string DontDestroyOnLoad = "SRF/Behaviours/Don\'t Destroy On Load"; // Metadata: 0x02080684
		public const string MatchTransform = "SRF/Behaviours/Match Transform"; // Metadata: 0x020806A9
		public const string LookAt = "SRF/Behaviours/LookAt"; // Metadata: 0x020806C8
		public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction"; // Metadata: 0x020806DE
		public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)"; // Metadata: 0x02080705
		public const string RuntimePosition = "SRF/Behaviours/Runtime Position"; // Metadata: 0x0208073A
		public const string ScrollTexture = "SRF/Behaviours/Scroll Texture"; // Metadata: 0x0208075A
		public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float"; // Metadata: 0x02080778
		public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)"; // Metadata: 0x02080794
		public const string SpringFollow = "SRF/Behaviours/Spring Follow"; // Metadata: 0x020807B6
		public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)"; // Metadata: 0x020807D3
		public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab"; // Metadata: 0x020807FB
		public const string Velocity = "SRF/Behaviours/Velocity"; // Metadata: 0x02080817
		public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate"; // Metadata: 0x0208082F
		public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera"; // Metadata: 0x0208084F
		public const string ComponentsRoot = "SRF/Components"; // Metadata: 0x02080873
		public const string SRLineRenderer = "SRF/Components/SRLineRenderer"; // Metadata: 0x02080882
		public const string SelectionRoot = "SRF/Components/Selection Root"; // Metadata: 0x020808A0
		public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)"; // Metadata: 0x020808BE
		public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)"; // Metadata: 0x020808E4
		public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)"; // Metadata: 0x0208090C
		public const string UIRoot = "SRF/UI"; // Metadata: 0x02080935
		public const string TiltOnTouch = "SRF/UI/Tilt On Touch"; // Metadata: 0x0208093C
		public const string ScaleOnTouch = "SRF/UI/Scale On Touch"; // Metadata: 0x02080951
		public const string InheritColour = "SRF/UI/Inherit Colour"; // Metadata: 0x02080967
		public const string FlashGraphic = "SRF/UI/Flash Graphic"; // Metadata: 0x0208097D
		public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size"; // Metadata: 0x02080992
		public const string CopyPreferredSizes = "SRF/UI/Copy Preferred Size (Multiple)"; // Metadata: 0x020809AD
		public const string CopyLayoutElement = "SRF/UI/Copy Layout Element"; // Metadata: 0x020809D3
		public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element"; // Metadata: 0x020809EE
		public const string SRText = "SRF/UI/SRText"; // Metadata: 0x02080A13
		public const string Unselectable = "SRF/UI/Unselectable"; // Metadata: 0x02080A21
		public const string LongPressButton = "SRF/UI/Long Press Button"; // Metadata: 0x02080A35
		public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour"; // Metadata: 0x02080A4E
		public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group"; // Metadata: 0x02080A70
		public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)"; // Metadata: 0x02080A90
		public const string StyleRoot = "SRF/UI/Style Root"; // Metadata: 0x02080AC1
		public const string StyleComponent = "SRF/UI/Style Component"; // Metadata: 0x02080AD3
		public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)"; // Metadata: 0x02080AEA
		public const string ResponsiveResize = "SRF/UI/Responsive (Resize)"; // Metadata: 0x02080B05
		public const string RetinaScaler = "SRF/UI/Retina Scaler"; // Metadata: 0x02080B20
		public const string NumberButton = "SRF/UI/SRNumberButton"; // Metadata: 0x02080B35
		public const string NumberSpinner = "SRF/UI/SRNumberSpinner"; // Metadata: 0x02080B4B
		public const string SRSpinner = "SRF/UI/Spinner"; // Metadata: 0x02080B62
		public const string ContentFitText = "SRF/UI/Content Fit Text"; // Metadata: 0x02080B71
	}
}

namespace SRF.Service
{
	public sealed class ServiceAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 59365
	{
		// Fields
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public ServiceAttribute() {} // Dummy constructor
		public ServiceAttribute(System.Type serviceType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class ServiceSelectorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 59366
	{
		// Fields
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public ServiceSelectorAttribute() {} // Dummy constructor
		public ServiceSelectorAttribute(System.Type serviceType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class ServiceConstructorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 59367
	{
		// Fields
		private System.Type _ServiceType_k__BackingField; // 0x10
	
		// Properties
		public System.Type ServiceType { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public ServiceConstructorAttribute() {} // Dummy constructor
		public ServiceConstructorAttribute(System.Type serviceType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public interface IAsyncService // TypeDefIndex: 59368
	{
		// Properties
		bool IsLoaded { get; }
	}

	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 59370
		where T : class
	{
		// Fields
		private bool _isLoaded;
	
		// Properties
		protected abstract System.Type[] Dependencies { get; }
		public bool IsLoaded { get; }
	
		// Nested types
		private sealed class _LoadDependencies_d__8 : IEnumerator<object> // TypeDefIndex: 59369
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SRDependencyServiceBase<T> __4__this;
			private System.Type[] __7__wrap1;
			private int __7__wrap2;
			private IAsyncService _a_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _LoadDependencies_d__8() {} // Dummy constructor
			public _LoadDependencies_d__8(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		protected SRDependencyServiceBase() {}
	
		// Methods
		private void Log(string msg, UnityEngine.Object target) {}
		protected override void Start() {}
		protected virtual void OnLoaded() {}
		private IEnumerator LoadDependencies() => default;
	}

	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 59372
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
		private sealed class _LoadCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 59371
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SRSceneServiceBase<T, TImpl> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _LoadCoroutine_d__11() {} // Dummy constructor
			public _LoadCoroutine_d__11(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		protected SRSceneServiceBase() {}
	
		// Methods
		private void Log(string msg, UnityEngine.Object target) {}
		protected override void Start() {}
		protected override void OnDestroy() {}
		protected virtual void OnLoaded() {}
		private IEnumerator LoadCoroutine() => default;
	}

	public abstract class SRServiceBase<T> : SRMonoBehaviourEx // TypeDefIndex: 59373
		where T : class
	{
		// Constructors
		protected SRServiceBase() {}
	
		// Methods
		protected override void Awake() {}
		protected override void OnDestroy() {}
	}

	public class SRServiceManager : SRAutoSingleton<SRServiceManager> // TypeDefIndex: 59379
	{
		// Fields
		public const bool EnableLogging = false; // Metadata: 0x02080632
		public static int LoadingCount; // 0x00
		private static readonly List<Assembly> _assemblies; // 0x08
		private readonly SRList<Service> _services; // 0x48
		private List<ServiceStub> _serviceStubs; // 0x50
		private static bool _hasQuit; // 0x10
	
		// Properties
		public static bool IsLoading { get => default; } // 0x000000018480ECF0-0x000000018480FE10 
	
		// Nested types
		private class Service // TypeDefIndex: 59374
		{
			// Fields
			public object Object; // 0x10
			public System.Type Type; // 0x18
	
			// Constructors
			public Service() {}
		}
	
		private class ServiceStub // TypeDefIndex: 59375
		{
			// Fields
			public Func<object> Constructor; // 0x10
			public System.Type InterfaceType; // 0x18
			public Func<System.Type> Selector; // 0x20
			public System.Type Type; // 0x28
	
			// Constructors
			public ServiceStub() {}
	
			// Methods
			public override string ToString() => default; // 0x000000018B7F1BDC-0x000000018B7F1C24
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59376
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ServiceStub, string> __9__21_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B7F19E4-0x000000018B7F1B64
			public __c() {} // 0x0000000184A12970-0x0000000184A12AD0
	
			// Methods
			internal string _UpdateStubs_b__21_0(ServiceStub p) => default;
		}
	
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 59377
		{
			// Fields
			public ServiceSelectorAttribute attrib; // 0x10
	
			// Constructors
			public __c__DisplayClass26_0() {} // 0x0000000184A12AD0-0x0000000184A12C00
	
			// Methods
			internal bool _ScanTypeForSelectors_b__0(ServiceStub p) => default;
		}
	
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 59378
		{
			// Fields
			public ServiceConstructorAttribute attrib; // 0x10
			public MethodInfo m; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0() {} // 0x0000000184A126B0-0x0000000184A12830
	
			// Methods
			internal bool _ScanTypeForConstructors_b__0(ServiceStub p) => default;
			internal object _ScanTypeForConstructors_b__1() => default; // 0x0000000184A134D0-0x0000000184A135C0
		}
	
		// Constructors
		public SRServiceManager() {} // 0x000000018B7F5224-0x000000018B7F5294
		static SRServiceManager() {} // 0x000000018B7F5294-0x000000018B7F52B8
	
		// Methods
		public static void RegisterAssembly<TType>() {} // 0x0000000184A82CA0-0x0000000184A82D80
		public static T GetService<T>()
			where T : class => default; // 0x0000000184A12C00-0x0000000184A13320
		public static object GetService(System.Type t) => default; // 0x000000018B7F1B64-0x000000018B7F1BDC
		private static object GetServiceInternal(System.Type t) => default; // 0x0000000184A13320-0x0000000184A134D0
		public static bool HasService<T>()
			where T : class => default; // 0x000000018480FE10-0x000000018480FF40
		public static bool HasService(System.Type t) => default; // 0x000000018480FF40-0x00000001848102A0
		public static void RegisterService<T>(object service)
			where T : class {} // 0x00000001848102A0-0x0000000184810460
		private static void RegisterService(System.Type t, object service) {} // 0x0000000184810460-0x0000000184810490
		public static void UnRegisterService<T>()
			where T : class {} // 0x0000000185EE5D00-0x0000000185EE5D70
		private static void UnRegisterService(System.Type t) {} // 0x0000000185F09590-0x0000000185F09640
		protected override void Awake() {} // 0x0000000185492010-0x0000000185492020
		protected void UpdateStubs() {} // 0x000000018B7F3188-0x000000018B7F32C8
		protected object AutoCreateService(System.Type t) => default; // 0x0000000185492010-0x0000000185492020
		protected new void OnApplicationQuit() {} // 0x000000018B7F52D8-0x000000018B7F533C
		private static object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType) => default; // 0x0000000185492010-0x0000000185492020
		private void ScanType(System.Type type) {} // 0x000000018B7F514C-0x000000018B7F51D4
		private static void ScanTypeForSelectors(System.Type t, List<ServiceStub> stubs) {} // 0x0000000185492010-0x0000000185492020
		private static void ScanTypeForConstructors(System.Type t, List<ServiceStub> stubs) {} // 0x0000000185EE57D0-0x0000000185EE5850
		private static MethodInfo[] GetStaticMethods(System.Type t) => default; // 0x0000000185492010-0x0000000185492020
	}
}

namespace SRF.UI
{
	public class ContentFitText : UIBehaviour, ILayoutElement // TypeDefIndex: 59330
	{
		// Fields
		public SRText CopySource; // 0x18
		public Vector2 Padding; // 0x20
	
		// Properties
		public float minWidth { get => default; } // 0x000000018B7EBCB4-0x000000018B7EBD38 
		public float preferredWidth { get => default; } // 0x000000018B7EBDBC-0x000000018B7EBE40 
		public float flexibleWidth { get => default; } // 0x000000018B7EBBB0-0x000000018B7EBC30 
		public float minHeight { get => default; } // 0x000000018B7EBC30-0x000000018B7EBCB4 
		public float preferredHeight { get => default; } // 0x000000018B7EBD38-0x000000018B7EBDBC 
		public float flexibleHeight { get => default; } // 0x000000018B7EBB30-0x000000018B7EBBB0 
		public int layoutPriority { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public ContentFitText() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x000000018B7EB950-0x000000018B7EB968
		public void CalculateLayoutInputVertical() {} // 0x000000018B7EB950-0x000000018B7EB968
		protected override void OnEnable() {} // 0x000000018B7EBA0C-0x000000018B7EBAA8
		private void CopySourceOnLayoutDirty(SRText srText) {} // 0x000000018B7EB968-0x000000018B7EB970
		protected override void OnTransformParentChanged() {} // 0x000000018B7EB968-0x000000018B7EB970
		protected override void OnDisable() {} // 0x000000018B7EB970-0x000000018B7EBA0C
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018B7EB968-0x000000018B7EB970
		protected override void OnBeforeTransformParentChanged() {} // 0x000000018B7EB968-0x000000018B7EB970
		protected void SetDirty() {} // 0x000000018B7EBAA8-0x000000018B7EBB30
	}

	public class CopyLayoutElement : UIBehaviour, ILayoutElement // TypeDefIndex: 59331
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
		public float preferredWidth { get => default; } // 0x000000018B7EBFD8-0x000000018B7EC060 
		public float preferredHeight { get => default; } // 0x000000018B7EBF50-0x000000018B7EBFD8 
		public float minWidth { get => default; } // 0x000000018B7EBEC8-0x000000018B7EBF50 
		public float minHeight { get => default; } // 0x000000018B7EBE40-0x000000018B7EBEC8 
		public int layoutPriority { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public float flexibleHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public float flexibleWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
	
		// Constructors
		public CopyLayoutElement() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public void CalculateLayoutInputVertical() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CopyPreferredSize : LayoutElement // TypeDefIndex: 59332
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
	
		// Properties
		public override float preferredWidth { get => default; } // 0x000000018B7EC0E0-0x000000018B7EC160 
		public override float preferredHeight { get => default; } // 0x000000018B7EC060-0x000000018B7EC0E0 
		public override int layoutPriority { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
	
		// Constructors
		public CopyPreferredSize() {} // 0x0000000185FA2B00-0x0000000185FA2B10
	}

	public class CopyPreferredSizes : LayoutElement // TypeDefIndex: 59335
	{
		// Fields
		public CopySource[] CopySources; // 0x38
		public Operations Operation; // 0x40
	
		// Properties
		public override float preferredWidth { get => default; } // 0x000000018B7EC160-0x000000018B7EC2E8 
		public override float preferredHeight { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override int layoutPriority { get => default; } // 0x0000000185FA2B00-0x0000000185FA2B10 
	
		// Nested types
		public enum Operations // TypeDefIndex: 59333
		{
			Max = 0,
			Min = 1
		}
	
		[Serializable]
		public class CopySource // TypeDefIndex: 59334
		{
			// Fields
			public RectTransform Rect; // 0x10
			public float PaddingHeight; // 0x18
			public float PaddingWidth; // 0x1C
	
			// Constructors
			public CopySource() {} // 0x000000018B7EC2E8-0x000000018B7EC470
		}
	
		// Constructors
		public CopyPreferredSizes() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CopySizeIntoLayoutElement : LayoutElement // TypeDefIndex: 59336
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
		public bool SetPreferredSize; // 0x48
		public bool SetMinimumSize; // 0x49
	
		// Properties
		public override float preferredWidth { get => default; } // 0x000000018B7EC644-0x000000018B7EC6E0 
		public override float preferredHeight { get => default; } // 0x000000018B7EC5A8-0x000000018B7EC644 
		public override float minWidth { get => default; } // 0x000000018B7EC50C-0x000000018B7EC5A8 
		public override float minHeight { get => default; } // 0x000000018B7EC470-0x000000018B7EC50C 
		public override int layoutPriority { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
	
		// Constructors
		public CopySizeIntoLayoutElement() {} // 0x0000000185FA2B00-0x0000000185FA2B10
	}

	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 59337
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
		private float Mult { get => default; } // 0x000000018B7ECE14-0x000000018B7ECE30 
	
		// Constructors
		public DragHandle() {} // 0x000000018B7ECE04-0x000000018B7ECE14
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018B7EC9F8-0x000000018B7ECA28
		public void OnDrag(PointerEventData eventData) {} // 0x000000018B7ECA28-0x000000018B7ECB58
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018B7ECB58-0x000000018B7ECBB0
		private void Start() {} // 0x000000018B7ECCF8-0x000000018B7ECD48
		private bool Verify() => default; // 0x000000018B7ECD48-0x000000018B7ECE04
		private float GetCurrentValue() => default; // 0x000000018B7EC834-0x000000018B7EC954
		private void SetCurrentValue(float value) {} // 0x000000018B7ECBB0-0x000000018B7ECCF8
		private void CommitCurrentValue() {} // 0x000000018B7EC734-0x000000018B7EC834
		private float GetMinSize() => default; // 0x000000018B7EC970-0x000000018B7EC9F8
		private float GetMaxSize() => default; // 0x000000018B7EC954-0x000000018B7EC970
	}

	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 59338
	{
		// Fields
		public float DecayTime; // 0x18
		public UnityEngine.Color DefaultColor; // 0x1C
		public UnityEngine.Color FlashColor; // 0x2C
		public Graphic Target; // 0x40
		private bool _isHoldingUntilNextPress; // 0x48
	
		// Constructors
		public FlashGraphic() {} // 0x000000018B7ECFC8-0x000000018B7ED004
	
		// Methods
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018B7ECF34-0x000000018B7ECF7C
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018B7ECF7C-0x000000018B7ECFC8
		protected override void OnEnable() {} // 0x000000018B7ECEF0-0x000000018B7ECF34
		public void Flash() {} // 0x000000018B7ECE78-0x000000018B7ECEF0
		public void FlashAndHoldUntilNextPress() {} // 0x000000018B7ECE30-0x000000018B7ECE78
	}

	public class InheritColour : SRMonoBehaviour // TypeDefIndex: 59339
	{
		// Fields
		private Graphic _graphic; // 0x48
		public Graphic From; // 0x50
	
		// Properties
		private Graphic Graphic { get => default; } // 0x000000018B7EDB84-0x000000018B7EDC08 
	
		// Constructors
		public InheritColour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Refresh() {} // 0x000000018B7EDACC-0x000000018B7EDB7C
		private void Update() {} // 0x000000018B7EDB7C-0x000000018B7EDB84
		private void Start() {} // 0x000000018B7EDB7C-0x000000018B7EDB84
	}

	public class LongPressButton : UnityEngine.UI.Button // TypeDefIndex: 59340
	{
		// Fields
		private bool _handled; // 0x188
		private ButtonClickedEvent _onLongPress; // 0x190
		private bool _pressed; // 0x198
		private float _pressedTime; // 0x19C
		public float LongPressDuration; // 0x1A0
	
		// Properties
		public ButtonClickedEvent onLongPress { get => default; set {} } // 0x0000000181B44930-0x0000000181B44940 0x0000000186473498-0x00000001864734AC
	
		// Constructors
		public LongPressButton() {} // 0x000000018B7EDD3C-0x000000018B7EDDBC
	
		// Methods
		public override void OnPointerExit(PointerEventData eventData) {} // 0x000000018B7EDC94-0x000000018B7EDCB4
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018B7EDC40-0x000000018B7EDC94
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018B7EDCB4-0x000000018B7EDCE4
		public override void OnPointerClick(PointerEventData eventData) {} // 0x000000018B7EDC2C-0x000000018B7EDC40
		private void Update() {} // 0x000000018B7EDCE4-0x000000018B7EDD3C
	}

	public abstract class ResponsiveBase : SRMonoBehaviour // TypeDefIndex: 59341
	{
		// Fields
		private bool _queueRefresh; // 0x48
	
		// Properties
		protected RectTransform RectTransform { get; } // 0x000000018B7EF34C-0x000000018B7EF39C 
	
		// Constructors
		protected ResponsiveBase() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected void OnEnable() {} // 0x0000000185FD46B0-0x0000000185FD46C0
		protected void OnRectTransformDimensionsChange() {} // 0x0000000185FD46B0-0x0000000185FD46C0
		protected void Update() {} // 0x000000018B7EF324-0x000000018B7EF34C
		protected abstract void Refresh();
		private void DoRefresh() {} // 0x000000018B71F004-0x000000018B71F014
	}

	public class ResponsiveEnable : ResponsiveBase // TypeDefIndex: 59344
	{
		// Fields
		public Entry[] Entries; // 0x50
	
		// Nested types
		public enum Modes // TypeDefIndex: 59342
		{
			EnableAbove = 0,
			EnableBelow = 1
		}
	
		[Serializable]
		public struct Entry // TypeDefIndex: 59343
		{
			// Fields
			public UnityEngine.Behaviour[] Components; // 0x00
			public GameObject[] GameObjects; // 0x08
			public Modes Mode; // 0x10
			public float ThresholdHeight; // 0x14
			public float ThresholdWidth; // 0x18
		}
	
		// Constructors
		public ResponsiveEnable() {} // 0x000000018B7EF618-0x000000018B7EF668
	
		// Methods
		protected override void Refresh() {} // 0x000000018B7EF39C-0x000000018B7EF618
	}

	public class ResponsiveResize : ResponsiveBase // TypeDefIndex: 59347
	{
		// Fields
		public Element[] Elements; // 0x50
	
		// Nested types
		[Serializable]
		public struct Element // TypeDefIndex: 59346
		{
			// Fields
			public SizeDefinition[] SizeDefinitions; // 0x00
			public RectTransform Target; // 0x08
	
			// Nested types
			[Serializable]
			public struct SizeDefinition // TypeDefIndex: 59345
			{
				// Fields
				public float ElementWidth; // 0x00
				public float ThresholdWidth; // 0x04
			}
		}
	
		// Constructors
		public ResponsiveResize() {} // 0x000000018B7EF814-0x000000018B7EF864
	
		// Methods
		protected override void Refresh() {} // 0x000000018B7EF668-0x000000018B7EF814
	}

	public class ScrollToBottomBehaviour : MonoBehaviour // TypeDefIndex: 59348
	{
		// Fields
		private ScrollRect _scrollRect; // 0x18
		private CanvasGroup _canvasGroup; // 0x20
		private bool _scrollToTop; // 0x28
	
		// Constructors
		public ScrollToBottomBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Start() {} // 0x000000018B7F20EC-0x000000018B7F2248
		private void OnEnable() {} // 0x000000018B7F1FB4-0x000000018B7F1FBC
		public void Trigger() {} // 0x000000018B7F2248-0x000000018B7F2288
		private void OnScrollRectValueChanged(Vector2 position) {} // 0x000000018B7F1FB4-0x000000018B7F1FBC
		private void Refresh() {} // 0x000000018B7F1FBC-0x000000018B7F2060
		private void SetVisible(bool truth) {} // 0x000000018B7F2060-0x000000018B7F20EC
	}

	public class SRNumberButton : UnityEngine.UI.Button, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 59349
	{
		// Fields
		private const float ExtraThreshold = 3f; // Metadata: 0x02080629
		public const float Delay = 0.4f; // Metadata: 0x0208062D
		private float _delayTime; // 0x188
		private float _downTime; // 0x18C
		private bool _isDown; // 0x190
		public double Amount; // 0x198
		public SRNumberSpinner TargetField; // 0x1A0
	
		// Constructors
		public SRNumberButton() {} // 0x000000018B7F122C-0x000000018B7F1244
	
		// Methods
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018B7F1130-0x000000018B7F1180
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018B7F1180-0x000000018B7F11A0
		protected virtual void Update() {} // 0x000000018B7F11A0-0x000000018B7F122C
		private void Apply() {} // 0x000000018B7F1030-0x000000018B7F1130
	}

	public class SRNumberSpinner : InputField // TypeDefIndex: 59350
	{
		// Fields
		private double _currentValue; // 0x2A0
		private double _dragStartAmount; // 0x2A8
		private double _dragStep; // 0x2B0
		public float DragSensitivity; // 0x2B8
		public double MaxValue; // 0x2C0
		public double MinValue; // 0x2C8
	
		// Constructors
		public SRNumberSpinner() {} // 0x000000018B7F1760-0x000000018B7F17CC
	
		// Methods
		protected override void Awake() {} // 0x000000018B7F1244-0x000000018B7F12C0
		public override void OnPointerClick(PointerEventData eventData) {} // 0x000000018B7F1678-0x000000018B7F1760
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000185492010-0x0000000185492020
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000185492010-0x0000000185492020
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x000000018B7F12C0-0x000000018B7F14C4
		public override void OnDrag(PointerEventData eventData) {} // 0x000000018B7F14C4-0x000000018B7F162C
		public override void OnEndDrag(PointerEventData eventData) {} // 0x000000018B7F162C-0x000000018B7F1678
	}

	public class SRRetinaScaler : SRMonoBehaviour // TypeDefIndex: 59351
	{
		// Fields
		private bool _disablePixelPerfect; // 0x48
		private int _designDpi; // 0x4C
		private float _lastDpi; // 0x50
	
		// Constructors
		public SRRetinaScaler() {} // 0x000000018B7F19D4-0x000000018B7F19E4
	
		// Methods
		private void Start() {} // 0x000000018B7F199C-0x000000018B7F19A4
		private void ApplyScaling() {} // 0x000000018B7F18B4-0x000000018B7F199C
		private void Update() {} // 0x000000018B7F19A4-0x000000018B7F19D4
	}

	public class SRSpinner : Selectable, IDragHandler, IBeginDragHandler // TypeDefIndex: 59353
	{
		// Fields
		private float _dragDelta; // 0x180
		private SpinEvent _onSpinDecrement; // 0x188
		private SpinEvent _onSpinIncrement; // 0x190
		public float DragThreshold; // 0x198
	
		// Properties
		public SpinEvent OnSpinIncrement { get => default; set {} } // 0x0000000186473498-0x00000001864734AC 0x0000000185FB8360-0x0000000185FB8370
		public SpinEvent OnSpinDecrement { get => default; set {} } // 0x0000000186473540-0x0000000186473554 0x0000000185FD5EC0-0x0000000185FD5ED0
	
		// Nested types
		[Serializable]
		public class SpinEvent : UnityEvent // TypeDefIndex: 59352
		{
			// Constructors
			public SpinEvent() {} // 0x0000000181B44930-0x0000000181B44940
		}
	
		// Constructors
		public SRSpinner() {} // 0x0000000186470378-0x0000000186470380
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018B7F1C70-0x000000018B7F1D40
		public void OnDrag(PointerEventData eventData) {} // 0x000000018B7F1D40-0x000000018B7F1D8C
		private void OnIncrement(int amount) {} // 0x000000018B7F1C24-0x000000018B7F1C70
		private void OnDecrement(int amount) {} // 0x000000018B7F1D8C-0x000000018B7F1E54
	}

	public class SRText : UnityEngine.UI.Text // TypeDefIndex: 59354
	{
		// Fields
		private Action<SRText> LayoutDirty; // 0x118
	
		// Events
		public event Action<SRText> LayoutDirty;
	
		// Constructors
		public SRText() {} // 0x000000018B7F1E8C-0x000000018B7F1E94
	
		// Methods
		public override void SetLayoutDirty() {} // 0x000000018B7F1E54-0x000000018B7F1E8C
	}

	public class StyleComponent : SRMonoBehaviour // TypeDefIndex: 59355
	{
		// Fields
		private SRF.UI.Style _activeStyle; // 0x48
		private StyleRoot _cachedRoot; // 0x50
		private Graphic _graphic; // 0x58
		private bool _hasStarted; // 0x60
		private Image _image; // 0x68
		private Selectable _selectable; // 0x70
		private string _styleKey; // 0x78
		public bool IgnoreImage; // 0x80
	
		// Properties
		public string StyleKey { get => default; set {} } // 0x0000000183060C50-0x0000000183060C60 0x000000018B7F3950-0x000000018B7F3978
	
		// Constructors
		public StyleComponent() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x000000018B7F3930-0x000000018B7F3950
		private void OnEnable() {} // 0x000000018B7F3704-0x000000018B7F3718
		public void Refresh(bool invalidateCache) {} // 0x000000018B7F3718-0x000000018B7F38E0
		private StyleRoot GetStyleRoot() => default; // 0x000000018B7F35B4-0x000000018B7F3704
		private void ApplyStyle() {} // 0x000000018B7F32C8-0x000000018B7F35B4
		private void SRStyleDirty() {} // 0x000000018B7F38E0-0x000000018B7F3930
	}

	public sealed class StyleRoot : SRMonoBehaviour // TypeDefIndex: 59356
	{
		// Fields
		private StyleSheet _activeStyleSheet; // 0x48
		public StyleSheet StyleSheet; // 0x50
	
		// Constructors
		public StyleRoot() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public SRF.UI.Style GetStyle(string key) => default; // 0x000000018B7F3978-0x000000018B7F3A34
		private void OnEnable() {} // 0x000000018B7F3A3C-0x000000018B7F3AAC
		private void OnDisable() {} // 0x000000018B7F3A34-0x000000018B7F3A3C
		private void Update() {} // 0x000000018B7F3B00-0x000000018B7F3B70
		private void OnStyleSheetChanged() {} // 0x000000018B7F3AAC-0x000000018B7F3B00
		public void SetDirty() {} // 0x0000000187F3B9F4-0x0000000187F3BA08
	}

	[Serializable]
	public class Style // TypeDefIndex: 59357
	{
		// Fields
		public UnityEngine.Color ActiveColor; // 0x10
		public UnityEngine.Color DisabledColor; // 0x20
		public UnityEngine.Color HoverColor; // 0x30
		public Sprite Image; // 0x40
		public UnityEngine.Color NormalColor; // 0x48
	
		// Constructors
		public Style() {} // 0x000000018B7F3DD8-0x000000018B7F3E30
	
		// Methods
		public Style Copy() => default; // 0x000000018B7F3D6C-0x000000018B7F3DD8
		public void CopyFrom(Style style) {} // 0x000000018B7F3D10-0x000000018B7F3D6C
	}

	[Serializable]
	public class StyleSheet : ScriptableObject // TypeDefIndex: 59358
	{
		// Fields
		private List<string> _keys; // 0x18
		private List<SRF.UI.Style> _styles; // 0x20
		public StyleSheet Parent; // 0x28
	
		// Constructors
		public StyleSheet() {} // 0x000000018B7F3C48-0x000000018B7F3D10
	
		// Methods
		public SRF.UI.Style GetStyle(string key, bool searchParent = true /* Metadata: 0x02080631 */) => default; // 0x000000018B7F3B70-0x000000018B7F3C48
	}

	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler // TypeDefIndex: 59359
	{
		// Fields
		private bool _suspectedSelected; // 0x48
	
		// Constructors
		public Unselectable() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnSelect(BaseEventData eventData) {} // 0x0000000185FD46B0-0x0000000185FD46C0
		private void Update() {} // 0x000000018B7F53EC-0x000000018B7F54B4
	}
}

namespace SRF.UI.Layout
{
	public class FlowLayoutGroup : LayoutGroup // TypeDefIndex: 59360
	{
		// Fields
		private readonly IList<RectTransform> _rowList; // 0x58
		private float _layoutHeight; // 0x60
		public bool ChildForceExpandHeight; // 0x64
		public bool ChildForceExpandWidth; // 0x65
		public float Spacing; // 0x68
	
		// Properties
		protected bool IsCenterAlign { get => default; } // 0x000000018B7EDA20-0x000000018B7EDA38 
		protected bool IsRightAlign { get => default; } // 0x000000018B7EDA68-0x000000018B7EDA80 
		protected bool IsMiddleAlign { get => default; } // 0x000000018B7EDA50-0x000000018B7EDA68 
		protected bool IsLowerAlign { get => default; } // 0x000000018B7EDA38-0x000000018B7EDA50 
	
		// Constructors
		public FlowLayoutGroup() {} // 0x000000018B7ED9A0-0x000000018B7EDA20
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x000000018B7ED004-0x000000018B7ED088
		public override void SetLayoutHorizontal() {} // 0x000000018B7ED4C0-0x000000018B7ED50C
		public override void SetLayoutVertical() {} // 0x000000018B7ED50C-0x000000018B7ED558
		public override void CalculateLayoutInputVertical() {} // 0x000000018B7ED088-0x000000018B7ED0DC
		public float SetLayout(float width, int axis, bool layoutInput) => default; // 0x000000018B7ED558-0x000000018B7ED9A0
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight) => default; // 0x000000018B7ED0DC-0x000000018B7ED160
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis) {} // 0x000000018B7ED1F0-0x000000018B7ED4C0
		public float GetGreatestMinimumChildWidth() => default; // 0x000000018B7ED160-0x000000018B7ED1F0
	}

	public interface IVirtualView // TypeDefIndex: 59361
	{
		// Methods
		void SetDataContext(object data);
	}

	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler // TypeDefIndex: 59364
	{
		// Fields
		private readonly SRList<object> _itemList; // 0x58
		private readonly SRList<int> _visibleItemList; // 0x60
		private bool _isDirty; // 0x68
		private SRList<Row> _rowCache; // 0x70
		private ScrollRect _scrollRect; // 0x78
		private int _selectedIndex; // 0x80
		private object _selectedItem; // 0x88
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
		public SelectedItemChangedEvent SelectedItemChanged { get => default; set {} } // 0x0000000185FB0510-0x0000000185FB0520 0x000000018B7F6DB8-0x000000018B7F6F1C
		public object SelectedItem { get => default; set {} } // 0x000000018B7F6CEC-0x000000018B7F6DB8 0x000000018B7F5CDC-0x000000018B7F5E4C
		public override float minHeight { get => default; } // 0x000000018B7F5574-0x000000018B7F56DC 
		private ScrollRect ScrollRect { get => default; } // 0x000000018B7F6AF4-0x000000018B7F6B0C 
		private bool AlignBottom { get => default; } // 0x000000018B7F6B0C-0x000000018B7F6C68 
		private bool AlignTop { get => default; } // 0x000000018B7F59D8-0x000000018B7F5B94 
		private float ItemHeight { get => default; } // 0x000000018B7F6094-0x000000018B7F60E8 
	
		// Nested types
		[Serializable]
		public class SelectedItemChangedEvent : UnityEvent<object> // TypeDefIndex: 59362
		{
			// Constructors
			public SelectedItemChangedEvent() {} // 0x0000000181B5FFD0-0x0000000181B5FFE0
		}
	
		[Serializable]
		private class Row // TypeDefIndex: 59363
		{
			// Fields
			public object Data; // 0x10
			public int Index; // 0x18
			public RectTransform Rect; // 0x20
			public StyleRoot Root; // 0x28
			public IVirtualView View; // 0x30
	
			// Constructors
			public Row() {} // 0x00000001873CBEA8-0x00000001873CBEBC
		}
	
		// Constructors
		public VirtualVerticalLayoutGroup() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018B7F5E4C-0x000000018B7F5EA4
		protected override void Awake() {} // 0x000000018B7F68D8-0x000000018B7F68E0
		private void OnScrollRectValueChanged(Vector2 d) {} // 0x000000018B7F5CBC-0x000000018B7F5CDC
		protected override void Start() {} // 0x000000018B7F68E0-0x000000018B7F69BC
		protected override void OnEnable() {} // 0x000000018B7F5B94-0x000000018B7F5CBC
		protected void Update() {} // 0x000000018B7F60E8-0x000000018B7F61BC
		protected void InvalidateItem(int itemIndex) {} // 0x000000018B7F626C-0x000000018B7F65BC
		protected void RefreshIndexCache() {} // 0x000000018B7F56DC-0x000000018B7F5724
		protected void ScrollUpdate() {} // 0x000000018B7F65E8-0x000000018B7F6794
		public override void CalculateLayoutInputVertical() {} // 0x000000018B7F6794-0x000000018B7F68D8
		public override void SetLayoutHorizontal() {} // 0x000000018B7F65BC-0x000000018B7F65E8
		public override void SetLayoutVertical() {} // 0x000000018B7F54B4-0x000000018B7F5574
		private new void SetDirty() {} // 0x000000018B7F61BC-0x000000018B7F626C
		public void AddItem(object item) {} // 0x000000018B7F5724-0x000000018B7F57D8
		public void RemoveItem(object item) {} // 0x000000018B7F6C68-0x000000018B7F6CEC
		public void ClearItems() {} // 0x000000018B7F6ADC-0x000000018B7F6AF4
		private Row GetRow(int forIndex) => default; // 0x000000018B7F5EA4-0x000000018B7F6094
		private void RecycleRow(Row row) {} // 0x000000018B7F57D8-0x000000018B7F59D8
		private void PopulateRow(int index, Row row) {} // 0x000000018B7F69BC-0x000000018B7F6ADC
		private Row CreateRow() => default; // 0x000000018B7F2288-0x000000018B7F22C4
	}
}
