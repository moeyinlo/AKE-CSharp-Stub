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

// Image 64: StompyRobot.SRF.dll - Assembly: StompyRobot.SRF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58155-58244
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public static class SRDebugUtil // TypeDefIndex: 58156
{
	// Fields
	public const int LineBufferCount = 512; // Metadata: 0x01FDAC4F

	// Properties
	public static bool IsFixedUpdate { get; set; } // 0x00000001896C99B4-0x00000001896C99EC 0x00000001896C99EC-0x00000001896C9A28

	// Methods
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null) {} // 0x00000001896C9728-0x00000001896C98AC
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null) {} // 0x00000001896C98AC-0x00000001896C99A4
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null) {} // 0x00000001896C99A4-0x00000001896C99AC
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null) {} // 0x00000001896C99AC-0x00000001896C99B4
}

public static class SRFileUtil // TypeDefIndex: 58157
{
	// Methods
	public static void DeleteDirectory(string path) {} // 0x00000001896CA008-0x00000001896CA09C
	public static string GetBytesReadable(long i) => default; // 0x000000018315D010-0x000000018315D160
}

public static class SRInstantiate // TypeDefIndex: 58158
{
	// Methods
	public static T Instantiate<T>(T prefab)
		where T : UnityEngine.Component => default;
	public static GameObject Instantiate(GameObject prefab) => default; // 0x00000001896CA09C-0x00000001896CA0F0
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation)
		where T : UnityEngine.Component => default;
}

public static class SRMath // TypeDefIndex: 58161
{
	// Nested types
	public enum EaseType // TypeDefIndex: 58159
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

	private static class TweenFunctions // TypeDefIndex: 58160
	{
		// Methods
		public static float Linear(float t, float b, float c, float d) => default; // 0x00000001896CE8CC-0x00000001896CE8DC
		public static float ExpoEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CE864-0x00000001896CE8CC
		public static float ExpoEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CE7A4-0x00000001896CE804
		public static float ExpoEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CE6F4-0x00000001896CE7A4
		public static float ExpoEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CE804-0x00000001896CE864
		public static float CircEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CE254-0x00000001896CE2A0
		public static float CircEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CE15C-0x00000001896CE1B8
		public static float CircEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CE0C8-0x00000001896CE15C
		public static float CircEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CE1B8-0x00000001896CE254
		public static float QuadEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CE9D0-0x00000001896CE9F4
		public static float QuadEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CE93C-0x00000001896CE954
		public static float QuadEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CE8DC-0x00000001896CE93C
		public static float QuadEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CE954-0x00000001896CE9D0
		public static float SineEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CEE70-0x00000001896CEEAC
		public static float SineEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CED78-0x00000001896CEDC4
		public static float SineEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CECE4-0x00000001896CED78
		public static float SineEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CEDC4-0x00000001896CEE70
		public static float CubicEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CE3BC-0x00000001896CE3E8
		public static float CubicEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CE310-0x00000001896CE32C
		public static float CubicEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CE2A0-0x00000001896CE310
		public static float CubicEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CE32C-0x00000001896CE3BC
		public static float QuartEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CEB34-0x00000001896CEB6C
		public static float QuartEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CEA74-0x00000001896CEA94
		public static float QuartEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CE9F4-0x00000001896CEA74
		public static float QuartEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CEA94-0x00000001896CEB34
		public static float QuintEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CECB0-0x00000001896CECE4
		public static float QuintEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CEBEC-0x00000001896CEC10
		public static float QuintEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CEB6C-0x00000001896CEBEC
		public static float QuintEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CEC10-0x00000001896CECB0
		public static float ElasticEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CE634-0x00000001896CE6F4
		public static float ElasticEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CE508-0x00000001896CE5D4
		public static float ElasticEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CE3E8-0x00000001896CE508
		public static float ElasticEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CE5D4-0x00000001896CE634
		public static float BounceEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CE008-0x00000001896CE0C8
		public static float BounceEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CDF2C-0x00000001896CDF78
		public static float BounceEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CDE94-0x00000001896CDF2C
		public static float BounceEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CDF78-0x00000001896CE008
		public static float BackEaseOut(float t, float b, float c, float d) => default; // 0x00000001896CDE58-0x00000001896CDE94
		public static float BackEaseIn(float t, float b, float c, float d) => default; // 0x00000001896CDD7C-0x00000001896CDDA8
		public static float BackEaseInOut(float t, float b, float c, float d) => default; // 0x00000001896CDCF4-0x00000001896CDD7C
		public static float BackEaseOutIn(float t, float b, float c, float d) => default; // 0x00000001896CDDA8-0x00000001896CDE58
	}

	// Methods
	public static float LerpUnclamped(float from, float to, float t) => default; // 0x0000000183D75240-0x0000000183D75260
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t) => default; // 0x0000000183D751E0-0x0000000183D75240
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2) => default; // 0x00000001896CA840-0x00000001896CA8B0
	public static float WrapAngle(float angle) => default; // 0x00000001896CABC8-0x00000001896CABF0
	public static float NearestAngle(float to, float angle1, float angle2) => default; // 0x00000001896CA8B0-0x00000001896CA920
	public static int Wrap(int max, int value) => default; // 0x00000001896CABF0-0x00000001896CAC84
	public static float Wrap(float max, float value) => default; // 0x00000001896CAC84-0x00000001896CACA8
	public static float Average(float v1, float v2) => default; // 0x0000000183D751D0-0x0000000183D751E0
	public static float Angle(Vector2 direction) => default; // 0x00000001896CA0F0-0x00000001896CA1B4
	public static float Ease(float from, float to, float t, EaseType type) => default; // 0x00000001896CA1B4-0x00000001896CA840
	public static float SpringLerp(float strength, float deltaTime) => default; // 0x00000001896CAB00-0x00000001896CAB50
	public static float SpringLerp(float from, float to, float strength, float deltaTime) => default; // 0x00000001896CAAC0-0x00000001896CAB00
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) => default; // 0x00000001896CAA38-0x00000001896CAAC0
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime) => default; // 0x00000001896CAB50-0x00000001896CABC8
	public static float SmoothClamp(float value, float min, float max, float scrollMax, EaseType easeType = EaseType.ExpoEaseOut /* Metadata: 0x01FDAC51 */) => default; // 0x00000001896CA920-0x00000001896CAA38
}

namespace SRF
{
	public static class Json // TypeDefIndex: 58165
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 58163
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x01FDAC7B
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get => default; } // 0x00000001896C8974-0x00000001896C89D0 
			private char NextChar { get => default; } // 0x00000001896C8644-0x00000001896C86A0 
			private string NextWord { get => default; } // 0x00000001896C88C4-0x00000001896C8974 
			private TOKEN NextToken { get => default; } // 0x00000001896C86A0-0x00000001896C88C4 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 58162
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
			private Parser(string jsonString) {} // 0x00000001896C85CC-0x00000001896C8644
	
			// Methods
			public void Dispose() {} // 0x00000001887C8320-0x00000001887C8358
			public static bool IsWordBreak(char c) => default; // 0x00000001896C7EC0-0x00000001896C7F38
			public static object Parse(string jsonString) => default; // 0x00000001896C84D4-0x00000001896C85CC
			private Dictionary<string, object> ParseObject() => default; // 0x00000001896C8178-0x00000001896C8284
			private List<object> ParseArray() => default; // 0x00000001896C7F38-0x00000001896C8000
			private object ParseValue() => default; // 0x00000001896C84B0-0x00000001896C84D4
			private object ParseByToken(TOKEN token) => default; // 0x00000001896C8000-0x00000001896C80B4
			private string ParseString() => default; // 0x00000001896C8284-0x00000001896C84B0
			private object ParseNumber() => default; // 0x00000001896C80B4-0x00000001896C8178
			private void EatWhitespace() {} // 0x00000001896C7E30-0x00000001896C7EC0
		}
	
		private sealed class Serializer // TypeDefIndex: 58164
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x00000001896CCFE8-0x00000001896CD04C
	
			// Methods
			public static string Serialize(object obj) => default; // 0x00000001896CCF70-0x00000001896CCFE8
			private void SerializeValue(object value) {} // 0x00000001896CCDEC-0x00000001896CCF70
			private void SerializeObject(IDictionary obj) {} // 0x00000001896CC50C-0x00000001896CC914
			private void SerializeArray(IList anArray) {} // 0x00000001896CC188-0x00000001896CC50C
			private void SerializeString(string str) {} // 0x00000001896CCB74-0x00000001896CCDEC
			private void SerializeOther(object value) {} // 0x00000001896CC914-0x00000001896CCB74
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x00000001896C7ACC-0x00000001896C7AE8
		public static string Serialize(object obj) => default; // 0x00000001896C7AE8-0x00000001896C7AF0
	}

	[Serializable]
	public class SRList<T> : IList<T>, ISerializationCallbackReceiver // TypeDefIndex: 58167
	{
		// Fields
		[SerializeField]
		private T[] _buffer;
		[SerializeField]
		private int _count;
		private EqualityComparer<T> _equalityComparer;
		private ReadOnlyCollection<T> _readOnlyWrapper;
	
		// Properties
		public T[] Buffer { get => default; private set {} }
		private EqualityComparer<T> EqualityComparer { get => default; }
		public int Count { get => default; private set {} }
		public bool IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public SRList() {}
		public SRList(int capacity) {}
		public SRList(IEnumerable<T> source) {}
	
		// Methods
		[IteratorStateMachine(typeof(_GetEnumerator_d__15))]
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

	public abstract class SRMonoBehaviour : MonoBehaviour // TypeDefIndex: 58168
	{
		// Fields
		private Collider _collider; // 0x18
		private Transform _transform; // 0x20
		private Rigidbody _rigidBody; // 0x28
		private GameObject _gameObject; // 0x30
		private Rigidbody2D _rigidbody2D; // 0x38
		private Collider2D _collider2D; // 0x40
	
		// Properties
		public Transform CachedTransform { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x000000018268DF90-0x000000018268E010 
		public Collider CachedCollider { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x00000001896CAD60-0x00000001896CADE4 
		public Collider2D CachedCollider2D { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x00000001896CACDC-0x00000001896CAD60 
		public Rigidbody CachedRigidBody { [DebuggerNonUserCode] [DebuggerStepThrough] get; } // 0x00000001896CAE68-0x00000001896CAEEC 
		public Rigidbody2D CachedRigidBody2D { [DebuggerStepThrough] [DebuggerNonUserCode] get; } // 0x00000001896CADE4-0x00000001896CAE68 
		public GameObject CachedGameObject { [DebuggerStepThrough] [DebuggerNonUserCode] get; } // 0x000000018268DF10-0x000000018268DF90 
		public new Transform transform { get; } // 0x00000001896CAEEC-0x00000001896CAEF4 
	
		// Constructors
		protected SRMonoBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, string fieldName = null) {} // 0x00000001896CACA8-0x00000001896CACC0
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, string message = null) {} // 0x00000001896CACC0-0x00000001896CACDC
		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, string fieldName = null) {} // 0x00000001896CACA8-0x00000001896CACC0
		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, string message = null) {} // 0x00000001896CACC0-0x00000001896CACDC
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class RequiredFieldAttribute : Attribute // TypeDefIndex: 58169
	{
		// Fields
		private bool _autoCreate; // 0x10
		private bool _autoSearch; // 0x11
		private bool _editorOnly; // 0x12
	
		// Properties
		public bool AutoSearch { get => default; set {} } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
		public bool AutoCreate { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		[Obsolete]
		public bool EditorOnly { get => default; set {} } // 0x0000000183D519E0-0x0000000183D519F0 0x0000000183D6B770-0x0000000183D6B780
	
		// Constructors
		public RequiredFieldAttribute(bool autoSearch) {} // 0x0000000183D751C0-0x0000000183D751D0
		public RequiredFieldAttribute() {} // 0x0000000183D64CD0-0x0000000183D64CE0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ImportAttribute : Attribute // TypeDefIndex: 58170
	{
		// Fields
		public readonly System.Type Service; // 0x10
	
		// Constructors
		public ImportAttribute() {} // 0x000000018350B670-0x000000018350B680
		public ImportAttribute(System.Type serviceType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public abstract class SRMonoBehaviourEx : SRMonoBehaviour // TypeDefIndex: 58172
	{
		// Fields
		private static Dictionary<System.Type, IList<FieldInfo>> _checkedFields; // 0x00
	
		// Nested types
		private struct FieldInfo // TypeDefIndex: 58171
		{
			// Fields
			public bool AutoCreate; // 0x00
			public bool AutoSet; // 0x01
			public System.Reflection.FieldInfo Field; // 0x08
			public bool Import; // 0x10
			public System.Type ImportType; // 0x18
		}
	
		// Constructors
		protected SRMonoBehaviourEx() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false /* Metadata: 0x01FDAC8F */) {} // 0x0000000182A6C2A0-0x0000000182A6C440
		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet) {} // 0x0000000182A6C1B0-0x0000000182A6C2A0
		private static List<FieldInfo> ScanType(System.Type t) => default; // 0x0000000182A6D440-0x0000000182A6D5D0
		protected virtual void Awake() {} // 0x0000000184276F4C-0x0000000184276F58
		protected virtual void Start() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void Update() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void FixedUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class Coroutines // TypeDefIndex: 58174
	{
		// Methods
		[IteratorStateMachine(typeof(_WaitForSecondsRealTime_d__0))]
		public static IEnumerator WaitForSecondsRealTime(float time) => default; // 0x00000001896C65A4-0x00000001896C65F8
	}

	public static class SRFFloatExtensions // TypeDefIndex: 58175
	{
		// Extension methods
		public static float Sqr(this float f) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static float SqrRt(this float f) => default; // 0x0000000183D51630-0x0000000183D51650
		public static bool ApproxZero(this float f) => default; // 0x00000001896C9A28-0x00000001896C9A34
		public static bool Approx(this float f, float f2) => default; // 0x00000001896C9A34-0x00000001896C9A3C
	}

	public static class SRFGameObjectExtensions // TypeDefIndex: 58176
	{
		// Methods
		private static void SetLayerInternal(Transform t, int layer) {} // 0x00000001896C9A3C-0x00000001896C9BD4
	
		// Extension methods
		public static T GetIComponent<T>(this GameObject t)
			where T : class => default;
		public static T GetComponentOrAdd<T>(this GameObject obj)
			where T : UnityEngine.Component => default;
		public static void RemoveComponentIfExists<T>(this GameObject obj)
			where T : UnityEngine.Component {}
		public static void RemoveComponentsIfExists<T>(this GameObject obj)
			where T : UnityEngine.Component {}
		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true /* Metadata: 0x01FDAC90 */)
			where T : MonoBehaviour => default;
		public static void SetLayerRecursive(this GameObject o, int layer) {} // 0x00000001896C9BD4-0x00000001896C9C00
	}

	public static class SRFIListExtensions // TypeDefIndex: 58177
	{
		// Extension methods
		public static T Random<T>(this IList<T> list) => default;
		public static T RandomOrDefault<T>(this IList<T> list) => default;
		public static T PopLast<T>(this IList<T> list) => default;
	}

	public static class SRFStringExtensions // TypeDefIndex: 58178
	{
		// Extension methods
		public static string Fmt(this string formatString, params object[] args) => default; // 0x0000000184275A04-0x0000000184275A0C
	}

	public static class SRFTransformExtensions // TypeDefIndex: 58180
	{
		// Extension methods
		[IteratorStateMachine(typeof(_GetChildren_d__0))]
		public static IEnumerable<Transform> GetChildren(this Transform t) => default; // 0x00000001896C9E5C-0x00000001896C9ECC
		public static void ResetLocal(this Transform t) {} // 0x00000001896C9F54-0x00000001896C9FE8
		public static GameObject CreateChild(this Transform t, string name) => default; // 0x00000001896C9C00-0x00000001896C9CC8
		public static void SetParentMaintainLocals(this Transform t, Transform parent) {} // 0x00000001896C9FE8-0x00000001896CA008
		public static void SetLocals(this Transform t, Transform from) {} // 0x000000018969BAA8-0x000000018969BB64
		public static void Match(this Transform t, Transform from) {} // 0x00000001896C9ECC-0x00000001896C9F54
		public static void DestroyChildren(this Transform t) {} // 0x00000001896C9CC8-0x00000001896C9E5C
	}

	public class Hierarchy // TypeDefIndex: 58181
	{
		// Fields
		private static readonly char[] Seperator; // 0x00
		private static readonly Dictionary<string, Transform> Cache; // 0x08
	
		// Properties
		[Obsolete("Use static Get() instead")]
		public Transform this[string key] { get => default; } // 0x00000001896C7944-0x00000001896C7990 
	
		// Constructors
		public Hierarchy() {} // 0x000000018350B670-0x000000018350B680
		static Hierarchy() {} // 0x0000000183C7CBB0-0x0000000183C7CCA0
	
		// Methods
		public static Transform Get(string key) => default; // 0x000000018268EDD0-0x000000018268EFD0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void RuntimeInitialize() {} // 0x0000000183D01E20-0x0000000183D01EA0
	}
}

namespace SRF.Components
{
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour // TypeDefIndex: 58242
		where T : SRAutoSingleton<T>
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { [DebuggerStepThrough] get; }
		public static bool HasInstance { get; }
	
		// Constructors
		protected SRAutoSingleton() {}
	
		// Methods
		protected virtual void Awake() {}
		protected virtual void OnEnable() {}
		private void OnApplicationQuit() {}
	}

	public abstract class SRSingleton<T> : SRMonoBehaviour // TypeDefIndex: 58243
		where T : SRSingleton<T>
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { [DebuggerStepThrough] get; }
		public static bool HasInstance { [DebuggerStepThrough] get; }
	
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
	public static class AssetUtil // TypeDefIndex: 58232
	{
	}

	public sealed class MethodReference // TypeDefIndex: 58235
	{
		// Fields
		private readonly Func<object[], object> _method; // 0x10
	
		// Constructors
		public MethodReference() {} // Dummy constructor
		public MethodReference(object target, MethodInfo method) {} // 0x00000001896C7C80-0x00000001896C7D60
		public MethodReference(Func<object[], object> method) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public object Invoke(object[] parameters) => default; // 0x000000018858E0D8-0x000000018858E0F8
		public static implicit operator MethodReference(Action action) => default; // 0x00000001896C7D60-0x00000001896C7E30
	}

	public delegate void PropertyValueChangedHandler(PropertyReference property); // TypeDefIndex: 58236; 0x0000000182149960-0x0000000182149970

	public sealed class PropertyReference // TypeDefIndex: 58240
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
	
		// Properties
		public System.Type PropertyType { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public bool CanRead { get => default; } // 0x0000000185693D38-0x0000000185693D44 
		public bool CanWrite { get => default; } // 0x00000001885839D0-0x00000001885839DC 
	
		// Events
		public event PropertyValueChangedHandler ValueChanged;
	
		// Constructors
		public PropertyReference() {} // Dummy constructor
		public PropertyReference(object target, PropertyInfo property) {} // 0x00000001896C8D08-0x00000001896C8EDC
		public PropertyReference(System.Type type, Func<object> getter = null, Action<object> setter = null, Attribute[] attributes = null) {} // 0x00000001896C8EDC-0x00000001896C8F5C
	
		// Methods
		public static PropertyReference FromLambda<T>(Func<T> getter, Action<T> setter = null, params Attribute[] attributes) => default;
		public void NotifyValueChanged() {} // 0x00000001896C89E8-0x00000001896C8AF8
		public object GetValue() => default; // 0x00000001896C89D0-0x00000001896C89E8
		public void SetValue(object value) {} // 0x00000001896C8B74-0x00000001896C8BEC
		public T GetAttribute<T>()
			where T : Attribute => default;
		private void OnTargetPropertyChanged(object sender, PropertyChangedEventArgs e) {} // 0x00000001896C8AF8-0x00000001896C8B74
		public override string ToString() => default; // 0x00000001896C8BEC-0x00000001896C8D08
	}

	public static class SRReflection // TypeDefIndex: 58241
	{
		// Methods
		public static void SetPropertyValue(object obj, PropertyInfo p, object value) {} // 0x00000001896CB6CC-0x00000001896CB778
		public static object GetPropertyValue(object obj, PropertyInfo p) => default; // 0x00000001896CB690-0x00000001896CB6CC
		public static T GetAttribute<T>(MemberInfo t)
			where T : Attribute => default;
	}
}

namespace SRF.Internal
{
	internal static class ComponentMenuPaths // TypeDefIndex: 58244
	{
		// Fields
		public const string PathRoot = "SRF"; // Metadata: 0x01FDAC9F
		public const string SRServiceManager = "SRF/Service/Service Manager"; // Metadata: 0x01FDACA3
		public const string BehavioursRoot = "SRF/Behaviours"; // Metadata: 0x01FDACBF
		public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable"; // Metadata: 0x01FDACCE
		public const string DontDestroyOnLoad = "SRF/Behaviours/Don\'t Destroy On Load"; // Metadata: 0x01FDACF0
		public const string MatchTransform = "SRF/Behaviours/Match Transform"; // Metadata: 0x01FDAD15
		public const string LookAt = "SRF/Behaviours/LookAt"; // Metadata: 0x01FDAD34
		public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction"; // Metadata: 0x01FDAD4A
		public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)"; // Metadata: 0x01FDAD71
		public const string RuntimePosition = "SRF/Behaviours/Runtime Position"; // Metadata: 0x01FDADA6
		public const string ScrollTexture = "SRF/Behaviours/Scroll Texture"; // Metadata: 0x01FDADC6
		public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float"; // Metadata: 0x01FDADE4
		public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)"; // Metadata: 0x01FDAE00
		public const string SpringFollow = "SRF/Behaviours/Spring Follow"; // Metadata: 0x01FDAE22
		public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)"; // Metadata: 0x01FDAE3F
		public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab"; // Metadata: 0x01FDAE67
		public const string Velocity = "SRF/Behaviours/Velocity"; // Metadata: 0x01FDAE83
		public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate"; // Metadata: 0x01FDAE9B
		public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera"; // Metadata: 0x01FDAEBB
		public const string ComponentsRoot = "SRF/Components"; // Metadata: 0x01FDAEDF
		public const string SRLineRenderer = "SRF/Components/SRLineRenderer"; // Metadata: 0x01FDAEEE
		public const string SelectionRoot = "SRF/Components/Selection Root"; // Metadata: 0x01FDAF0C
		public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)"; // Metadata: 0x01FDAF2A
		public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)"; // Metadata: 0x01FDAF50
		public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)"; // Metadata: 0x01FDAF78
		public const string UIRoot = "SRF/UI"; // Metadata: 0x01FDAFA1
		public const string TiltOnTouch = "SRF/UI/Tilt On Touch"; // Metadata: 0x01FDAFA8
		public const string ScaleOnTouch = "SRF/UI/Scale On Touch"; // Metadata: 0x01FDAFBD
		public const string InheritColour = "SRF/UI/Inherit Colour"; // Metadata: 0x01FDAFD3
		public const string FlashGraphic = "SRF/UI/Flash Graphic"; // Metadata: 0x01FDAFE9
		public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size"; // Metadata: 0x01FDAFFE
		public const string CopyPreferredSizes = "SRF/UI/Copy Preferred Size (Multiple)"; // Metadata: 0x01FDB019
		public const string CopyLayoutElement = "SRF/UI/Copy Layout Element"; // Metadata: 0x01FDB03F
		public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element"; // Metadata: 0x01FDB05A
		public const string SRText = "SRF/UI/SRText"; // Metadata: 0x01FDB07F
		public const string Unselectable = "SRF/UI/Unselectable"; // Metadata: 0x01FDB08D
		public const string LongPressButton = "SRF/UI/Long Press Button"; // Metadata: 0x01FDB0A1
		public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour"; // Metadata: 0x01FDB0BA
		public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group"; // Metadata: 0x01FDB0DC
		public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)"; // Metadata: 0x01FDB0FC
		public const string StyleRoot = "SRF/UI/Style Root"; // Metadata: 0x01FDB12D
		public const string StyleComponent = "SRF/UI/Style Component"; // Metadata: 0x01FDB13F
		public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)"; // Metadata: 0x01FDB156
		public const string ResponsiveResize = "SRF/UI/Responsive (Resize)"; // Metadata: 0x01FDB171
		public const string RetinaScaler = "SRF/UI/Retina Scaler"; // Metadata: 0x01FDB18C
		public const string NumberButton = "SRF/UI/SRNumberButton"; // Metadata: 0x01FDB1A1
		public const string NumberSpinner = "SRF/UI/SRNumberSpinner"; // Metadata: 0x01FDB1B7
		public const string SRSpinner = "SRF/UI/Spinner"; // Metadata: 0x01FDB1CE
		public const string ContentFitText = "SRF/UI/Content Fit Text"; // Metadata: 0x01FDB1DD
	}
}

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ServiceAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 58217
	{
		// Properties
		public System.Type ServiceType { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public ServiceAttribute() {} // Dummy constructor
		public ServiceAttribute(System.Type serviceType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceSelectorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 58218
	{
		// Properties
		public System.Type ServiceType { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public ServiceSelectorAttribute() {} // Dummy constructor
		public ServiceSelectorAttribute(System.Type serviceType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceConstructorAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 58219
	{
		// Properties
		public System.Type ServiceType { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public ServiceConstructorAttribute() {} // Dummy constructor
		public ServiceConstructorAttribute(System.Type serviceType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public interface IAsyncService // TypeDefIndex: 58220
	{
		// Properties
		bool IsLoaded { get; }
	}

	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 58222
		where T : class
	{
		// Fields
		private bool _isLoaded;
	
		// Properties
		protected abstract System.Type[] Dependencies { get; }
		public bool IsLoaded { get; }
	
		// Constructors
		protected SRDependencyServiceBase() {}
	
		// Methods
		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target) {}
		protected override void Start() {}
		protected virtual void OnLoaded() {}
		[IteratorStateMachine(typeof(_LoadDependencies_d__8))]
		private IEnumerator LoadDependencies() => default;
	}

	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 58224
		where T : class
		where TImpl : UnityEngine.Component
	{
		// Fields
		private TImpl _rootObject;
	
		// Properties
		protected abstract string SceneName { get; }
		protected TImpl RootObject { get; }
		public bool IsLoaded { get; }
	
		// Constructors
		protected SRSceneServiceBase() {}
	
		// Methods
		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target) {}
		protected override void Start() {}
		protected override void OnDestroy() {}
		protected virtual void OnLoaded() {}
		[IteratorStateMachine(typeof(_LoadCoroutine_d__11))]
		private IEnumerator LoadCoroutine() => default;
	}

	public abstract class SRServiceBase<T> : SRMonoBehaviourEx // TypeDefIndex: 58225
		where T : class
	{
		// Constructors
		protected SRServiceBase() {}
	
		// Methods
		protected override void Awake() {}
		protected override void OnDestroy() {}
	}

	[AddComponentMenu("SRF/Service/Service Manager")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager> // TypeDefIndex: 58231
	{
		// Fields
		public const bool EnableLogging = false; // Metadata: 0x01FDAC9E
		public static int LoadingCount; // 0x00
		private static readonly List<Assembly> _assemblies; // 0x08
		private readonly SRList<Service> _services; // 0x48
		private List<ServiceStub> _serviceStubs; // 0x50
		private static bool _hasQuit; // 0x10
	
		// Properties
		public static bool IsLoading { get => default; } // 0x00000001896CBAA0-0x00000001896CBAE8 
	
		// Nested types
		private class Service // TypeDefIndex: 58226
		{
			// Fields
			public object Object; // 0x10
			public System.Type Type; // 0x18
	
			// Constructors
			public Service() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class ServiceStub // TypeDefIndex: 58227
		{
			// Fields
			public Func<object> Constructor; // 0x10
			public System.Type InterfaceType; // 0x18
			public Func<System.Type> Selector; // 0x20
			public System.Type Type; // 0x28
	
			// Constructors
			public ServiceStub() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override string ToString() => default; // 0x00000001896CD04C-0x00000001896CD18C
		}
	
		// Constructors
		public SRServiceManager() {} // 0x0000000183C973E0-0x0000000183C97450
		static SRServiceManager() {} // 0x0000000183CB6850-0x0000000183CB6900
	
		// Methods
		public static void RegisterAssembly<TType>() {}
		public static T GetService<T>()
			where T : class => default;
		public static object GetService(System.Type t) => default; // 0x00000001896CB8A8-0x00000001896CBA28
		private static object GetServiceInternal(System.Type t) => default; // 0x0000000182CD72B0-0x0000000182CD7410
		public static bool HasService<T>()
			where T : class => default;
		public static bool HasService(System.Type t) => default; // 0x0000000182CD7410-0x0000000182CD7540
		public static void RegisterService<T>(object service)
			where T : class {}
		private static void RegisterService(System.Type t, object service) {} // 0x0000000182CD6FF0-0x0000000182CD7170
		public static void UnRegisterService<T>()
			where T : class {}
		private static void UnRegisterService(System.Type t) {} // 0x0000000182CD7E10-0x0000000182CD7F00
		protected override void Awake() {} // 0x000000018268DE30-0x000000018268DF10
		protected void UpdateStubs() {} // 0x0000000182840F80-0x00000001828420A0
		protected object AutoCreateService(System.Type t) => default; // 0x0000000182CD7540-0x0000000182CD7C60
		protected new void OnApplicationQuit() {} // 0x00000001896CBA28-0x00000001896CBAA0
		private static object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType) => default; // 0x0000000182CD7C60-0x0000000182CD7E10
		private void ScanType(System.Type type) {} // 0x00000001828420A0-0x00000001828421D0
		private static void ScanTypeForSelectors(System.Type t, List<ServiceStub> stubs) {} // 0x00000001828421D0-0x0000000182842530
		private static void ScanTypeForConstructors(System.Type t, List<ServiceStub> stubs) {} // 0x0000000182842530-0x00000001828426F0
		private static MethodInfo[] GetStaticMethods(System.Type t) => default; // 0x00000001828426F0-0x0000000182842720
	}
}

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Content Fit Text")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ContentFitText : UIBehaviour, ILayoutElement // TypeDefIndex: 58182
	{
		// Fields
		public SRText CopySource; // 0x18
		public Vector2 Padding; // 0x20
	
		// Properties
		public float minWidth { get => default; } // 0x00000001896C5B78-0x00000001896C5BFC 
		public float preferredWidth { get => default; } // 0x00000001896C5C80-0x00000001896C5D04 
		public float flexibleWidth { get => default; } // 0x00000001896C5A74-0x00000001896C5AF4 
		public float minHeight { get => default; } // 0x00000001896C5AF4-0x00000001896C5B78 
		public float preferredHeight { get => default; } // 0x00000001896C5BFC-0x00000001896C5C80 
		public float flexibleHeight { get => default; } // 0x00000001896C59F4-0x00000001896C5A74 
		public int layoutPriority { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public ContentFitText() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x00000001896C5814-0x00000001896C582C
		public void CalculateLayoutInputVertical() {} // 0x00000001896C5814-0x00000001896C582C
		protected override void OnEnable() {} // 0x00000001896C58D0-0x00000001896C596C
		private void CopySourceOnLayoutDirty(SRText srText) {} // 0x00000001896C582C-0x00000001896C5834
		protected override void OnTransformParentChanged() {} // 0x00000001896C582C-0x00000001896C5834
		protected override void OnDisable() {} // 0x00000001896C5834-0x00000001896C58D0
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001896C582C-0x00000001896C5834
		protected override void OnBeforeTransformParentChanged() {} // 0x00000001896C582C-0x00000001896C5834
		protected void SetDirty() {} // 0x00000001896C596C-0x00000001896C59F4
	}

	[AddComponentMenu("SRF/UI/Copy Layout Element")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement // TypeDefIndex: 58183
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
		public float preferredWidth { get => default; } // 0x00000001896C5E9C-0x00000001896C5F24 
		public float preferredHeight { get => default; } // 0x00000001896C5E14-0x00000001896C5E9C 
		public float minWidth { get => default; } // 0x00000001896C5D8C-0x00000001896C5E14 
		public float minHeight { get => default; } // 0x00000001896C5D04-0x00000001896C5D8C 
		public int layoutPriority { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public float flexibleHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public float flexibleWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
	
		// Constructors
		public CopyLayoutElement() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public void CalculateLayoutInputVertical() {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("SRF/UI/Copy Preferred Size")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyPreferredSize : LayoutElement // TypeDefIndex: 58184
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
	
		// Properties
		public override float preferredWidth { get => default; } // 0x00000001896C5FA4-0x00000001896C6024 
		public override float preferredHeight { get => default; } // 0x00000001896C5F24-0x00000001896C5FA4 
		public override int layoutPriority { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public CopyPreferredSize() {} // 0x00000001831659B0-0x00000001831659C0
	}

	[AddComponentMenu("SRF/UI/Copy Preferred Size (Multiple)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopyPreferredSizes : LayoutElement // TypeDefIndex: 58187
	{
		// Fields
		public CopySource[] CopySources; // 0x38
		public Operations Operation; // 0x40
	
		// Properties
		public override float preferredWidth { get => default; } // 0x00000001896C61AC-0x00000001896C6334 
		public override float preferredHeight { get => default; } // 0x00000001896C6024-0x00000001896C61AC 
		public override int layoutPriority { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Nested types
		public enum Operations // TypeDefIndex: 58185
		{
			Max = 0,
			Min = 1
		}
	
		[Serializable]
		public class CopySource // TypeDefIndex: 58186
		{
			// Fields
			public RectTransform Rect; // 0x10
			public float PaddingHeight; // 0x18
			public float PaddingWidth; // 0x1C
	
			// Constructors
			public CopySource() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CopyPreferredSizes() {} // 0x00000001831659B0-0x00000001831659C0
	}

	[AddComponentMenu("SRF/UI/Copy Size Into Layout Element")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class CopySizeIntoLayoutElement : LayoutElement // TypeDefIndex: 58188
	{
		// Fields
		public RectTransform CopySource; // 0x38
		public float PaddingHeight; // 0x40
		public float PaddingWidth; // 0x44
		public bool SetPreferredSize; // 0x48
		public bool SetMinimumSize; // 0x49
	
		// Properties
		public override float preferredWidth { get => default; } // 0x00000001896C6508-0x00000001896C65A4 
		public override float preferredHeight { get => default; } // 0x00000001896C646C-0x00000001896C6508 
		public override float minWidth { get => default; } // 0x00000001896C63D0-0x00000001896C646C 
		public override float minHeight { get => default; } // 0x00000001896C6334-0x00000001896C63D0 
		public override int layoutPriority { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public CopySizeIntoLayoutElement() {} // 0x00000001831659B0-0x00000001831659C0
	}

	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 58189
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
		private float Mult { get => default; } // 0x00000001896C6CD8-0x00000001896C6CF4 
	
		// Constructors
		public DragHandle() {} // 0x00000001896C6CC8-0x00000001896C6CD8
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData) {} // 0x00000001896C68BC-0x00000001896C68EC
		public void OnDrag(PointerEventData eventData) {} // 0x00000001896C68EC-0x00000001896C6A1C
		public void OnEndDrag(PointerEventData eventData) {} // 0x00000001896C6A1C-0x00000001896C6A74
		private void Start() {} // 0x00000001896C6BBC-0x00000001896C6C0C
		private bool Verify() => default; // 0x00000001896C6C0C-0x00000001896C6CC8
		private float GetCurrentValue() => default; // 0x00000001896C66F8-0x00000001896C6818
		private void SetCurrentValue(float value) {} // 0x00000001896C6A74-0x00000001896C6BBC
		private void CommitCurrentValue() {} // 0x00000001896C65F8-0x00000001896C66F8
		private float GetMinSize() => default; // 0x00000001896C6834-0x00000001896C68BC
		private float GetMaxSize() => default; // 0x00000001896C6818-0x00000001896C6834
	}

	[AddComponentMenu("SRF/UI/Flash Graphic")]
	[ExecuteInEditMode]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 58190
	{
		// Fields
		public float DecayTime; // 0x18
		public UnityEngine.Color DefaultColor; // 0x1C
		public UnityEngine.Color FlashColor; // 0x2C
		public Graphic Target; // 0x40
		private bool _isHoldingUntilNextPress; // 0x48
	
		// Constructors
		public FlashGraphic() {} // 0x00000001896C6E8C-0x00000001896C6EC8
	
		// Methods
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001896C6DF8-0x00000001896C6E40
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001896C6E40-0x00000001896C6E8C
		protected override void OnEnable() {} // 0x00000001896C6DB4-0x00000001896C6DF8
		public void Flash() {} // 0x00000001896C6D3C-0x00000001896C6DB4
		public void FlashAndHoldUntilNextPress() {} // 0x00000001896C6CF4-0x00000001896C6D3C
	}

	[AddComponentMenu("SRF/UI/Inherit Colour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Graphic))]
	public class InheritColour : SRMonoBehaviour // TypeDefIndex: 58191
	{
		// Fields
		private Graphic _graphic; // 0x48
		public Graphic From; // 0x50
	
		// Properties
		private Graphic Graphic { get => default; } // 0x00000001896C7A48-0x00000001896C7ACC 
	
		// Constructors
		public InheritColour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Refresh() {} // 0x00000001896C7990-0x00000001896C7A40
		private void Update() {} // 0x00000001896C7A40-0x00000001896C7A48
		private void Start() {} // 0x00000001896C7A40-0x00000001896C7A48
	}

	[AddComponentMenu("SRF/UI/Long Press Button")]
	public class LongPressButton : UnityEngine.UI.Button // TypeDefIndex: 58192
	{
		// Fields
		private bool _handled; // 0x188
		[SerializeField]
		private ButtonClickedEvent _onLongPress; // 0x190
		private bool _pressed; // 0x198
		private float _pressedTime; // 0x19C
		public float LongPressDuration; // 0x1A0
	
		// Properties
		public ButtonClickedEvent onLongPress { get => default; set {} } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
	
		// Constructors
		public LongPressButton() {} // 0x00000001896C7C00-0x00000001896C7C80
	
		// Methods
		public override void OnPointerExit(PointerEventData eventData) {} // 0x00000001896C7B58-0x00000001896C7B78
		public override void OnPointerDown(PointerEventData eventData) {} // 0x00000001896C7B04-0x00000001896C7B58
		public override void OnPointerUp(PointerEventData eventData) {} // 0x00000001896C7B78-0x00000001896C7BA8
		public override void OnPointerClick(PointerEventData eventData) {} // 0x00000001896C7AF0-0x00000001896C7B04
		private void Update() {} // 0x00000001896C7BA8-0x00000001896C7C00
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public abstract class ResponsiveBase : SRMonoBehaviour // TypeDefIndex: 58193
	{
		// Fields
		private bool _queueRefresh; // 0x48
	
		// Properties
		protected RectTransform RectTransform { get; } // 0x00000001896C9210-0x00000001896C9260 
	
		// Constructors
		protected ResponsiveBase() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected void OnEnable() {} // 0x0000000183D73A50-0x0000000183D73A60
		protected void OnRectTransformDimensionsChange() {} // 0x0000000183D73A50-0x0000000183D73A60
		protected void Update() {} // 0x00000001896C91E8-0x00000001896C9210
		protected abstract void Refresh();
		[ContextMenu("Refresh")]
		private void DoRefresh() {} // 0x00000001895F8FC0-0x00000001895F8FD0
	}

	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveEnable : ResponsiveBase // TypeDefIndex: 58196
	{
		// Fields
		public Entry[] Entries; // 0x50
	
		// Nested types
		public enum Modes // TypeDefIndex: 58194
		{
			EnableAbove = 0,
			EnableBelow = 1
		}
	
		[Serializable]
		public struct Entry // TypeDefIndex: 58195
		{
			// Fields
			public UnityEngine.Behaviour[] Components; // 0x00
			public GameObject[] GameObjects; // 0x08
			public Modes Mode; // 0x10
			public float ThresholdHeight; // 0x14
			public float ThresholdWidth; // 0x18
		}
	
		// Constructors
		public ResponsiveEnable() {} // 0x00000001896C94DC-0x00000001896C952C
	
		// Methods
		protected override void Refresh() {} // 0x00000001896C9260-0x00000001896C94DC
	}

	[AddComponentMenu("SRF/UI/Responsive (Resize)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveResize : ResponsiveBase // TypeDefIndex: 58199
	{
		// Fields
		public Element[] Elements; // 0x50
	
		// Nested types
		[Serializable]
		public struct Element // TypeDefIndex: 58198
		{
			// Fields
			public SizeDefinition[] SizeDefinitions; // 0x00
			public RectTransform Target; // 0x08
	
			// Nested types
			[Serializable]
			public struct SizeDefinition // TypeDefIndex: 58197
			{
				// Fields
				[Tooltip("Width to apply when over the threshold width")]
				public float ElementWidth; // 0x00
				[Tooltip("Threshold over which this width will take effect")]
				public float ThresholdWidth; // 0x04
			}
		}
	
		// Constructors
		public ResponsiveResize() {} // 0x00000001896C96D8-0x00000001896C9728
	
		// Methods
		protected override void Refresh() {} // 0x00000001896C952C-0x00000001896C96D8
	}

	[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ScrollToBottomBehaviour : MonoBehaviour // TypeDefIndex: 58200
	{
		// Fields
		[SerializeField]
		private ScrollRect _scrollRect; // 0x18
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x20
		[SerializeField]
		private bool _scrollToTop; // 0x28
	
		// Constructors
		public ScrollToBottomBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Start() {} // 0x00000001896CBFB0-0x00000001896CC10C
		private void OnEnable() {} // 0x00000001896CBE78-0x00000001896CBE80
		public void Trigger() {} // 0x00000001896CC10C-0x00000001896CC14C
		private void OnScrollRectValueChanged(Vector2 position) {} // 0x00000001896CBE78-0x00000001896CBE80
		private void Refresh() {} // 0x00000001896CBE80-0x00000001896CBF24
		private void SetVisible(bool truth) {} // 0x00000001896CBF24-0x00000001896CBFB0
	}

	[AddComponentMenu("SRF/UI/SRNumberButton")]
	public class SRNumberButton : UnityEngine.UI.Button, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 58201
	{
		// Fields
		private const float ExtraThreshold = 3f; // Metadata: 0x01FDAC95
		public const float Delay = 0.4f; // Metadata: 0x01FDAC99
		private float _delayTime; // 0x188
		private float _downTime; // 0x18C
		private bool _isDown; // 0x190
		public double Amount; // 0x198
		public SRNumberSpinner TargetField; // 0x1A0
	
		// Constructors
		public SRNumberButton() {} // 0x00000001896CB0F0-0x00000001896CB108
	
		// Methods
		public override void OnPointerDown(PointerEventData eventData) {} // 0x00000001896CAFF4-0x00000001896CB044
		public override void OnPointerUp(PointerEventData eventData) {} // 0x00000001896CB044-0x00000001896CB064
		protected virtual void Update() {} // 0x00000001896CB064-0x00000001896CB0F0
		private void Apply() {} // 0x00000001896CAEF4-0x00000001896CAFF4
	}

	[AddComponentMenu("SRF/UI/SRNumberSpinner")]
	public class SRNumberSpinner : InputField // TypeDefIndex: 58202
	{
		// Fields
		private double _currentValue; // 0x2A0
		private double _dragStartAmount; // 0x2A8
		private double _dragStep; // 0x2B0
		public float DragSensitivity; // 0x2B8
		public double MaxValue; // 0x2C0
		public double MinValue; // 0x2C8
	
		// Constructors
		public SRNumberSpinner() {} // 0x00000001896CB624-0x00000001896CB690
	
		// Methods
		protected override void Awake() {} // 0x00000001896CB108-0x00000001896CB184
		public override void OnPointerClick(PointerEventData eventData) {} // 0x00000001896CB53C-0x00000001896CB624
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018350B670-0x000000018350B680
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018350B670-0x000000018350B680
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x00000001896CB184-0x00000001896CB388
		public override void OnDrag(PointerEventData eventData) {} // 0x00000001896CB388-0x00000001896CB4F0
		public override void OnEndDrag(PointerEventData eventData) {} // 0x00000001896CB4F0-0x00000001896CB53C
	}

	[AddComponentMenu("SRF/UI/Retina Scaler")]
	[RequireComponent(typeof(CanvasScaler))]
	public class SRRetinaScaler : SRMonoBehaviour // TypeDefIndex: 58203
	{
		// Fields
		[SerializeField]
		private bool _disablePixelPerfect; // 0x48
		[SerializeField]
		private int _designDpi; // 0x4C
		private float _lastDpi; // 0x50
	
		// Constructors
		public SRRetinaScaler() {} // 0x00000001896CB898-0x00000001896CB8A8
	
		// Methods
		private void Start() {} // 0x00000001896CB860-0x00000001896CB868
		private void ApplyScaling() {} // 0x00000001896CB778-0x00000001896CB860
		private void Update() {} // 0x00000001896CB868-0x00000001896CB898
	}

	[AddComponentMenu("SRF/UI/Spinner")]
	public class SRSpinner : Selectable, IDragHandler, IBeginDragHandler // TypeDefIndex: 58205
	{
		// Fields
		private float _dragDelta; // 0x180
		[SerializeField]
		private SpinEvent _onSpinDecrement; // 0x188
		[SerializeField]
		private SpinEvent _onSpinIncrement; // 0x190
		public float DragThreshold; // 0x198
	
		// Properties
		public SpinEvent OnSpinIncrement { get => default; set {} } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000184275BAC-0x0000000184275BC0
		public SpinEvent OnSpinDecrement { get => default; set {} } // 0x0000000183D56AF0-0x0000000183D56B00 0x0000000184275C54-0x0000000184275C68
	
		// Nested types
		[Serializable]
		public class SpinEvent : UnityEvent // TypeDefIndex: 58204
		{
			// Constructors
			public SpinEvent() {} // 0x0000000184271C98-0x0000000184271CA0
		}
	
		// Constructors
		public SRSpinner() {} // 0x00000001896CBC50-0x00000001896CBD18
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000183D75260-0x0000000183D75270
		public void OnDrag(PointerEventData eventData) {} // 0x00000001896CBB34-0x00000001896CBC04
		private void OnIncrement(int amount) {} // 0x00000001896CBC04-0x00000001896CBC50
		private void OnDecrement(int amount) {} // 0x00000001896CBAE8-0x00000001896CBB34
	}

	[AddComponentMenu("SRF/UI/SRText")]
	public class SRText : UnityEngine.UI.Text // TypeDefIndex: 58206
	{
		// Events
		public event Action<SRText> LayoutDirty;
	
		// Constructors
		public SRText() {} // 0x00000001896CBD50-0x00000001896CBD58
	
		// Methods
		public override void SetLayoutDirty() {} // 0x00000001896CBD18-0x00000001896CBD50
	}

	[AddComponentMenu("SRF/UI/Style Component")]
	[ExecuteInEditMode]
	public class StyleComponent : SRMonoBehaviour // TypeDefIndex: 58207
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
		public string StyleKey { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001896CD814-0x00000001896CD83C
	
		// Constructors
		public StyleComponent() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x00000001896CD7F4-0x00000001896CD814
		private void OnEnable() {} // 0x00000001896CD5C8-0x00000001896CD5DC
		public void Refresh(bool invalidateCache) {} // 0x00000001896CD5DC-0x00000001896CD7A4
		private StyleRoot GetStyleRoot() => default; // 0x00000001896CD478-0x00000001896CD5C8
		private void ApplyStyle() {} // 0x00000001896CD18C-0x00000001896CD478
		private void SRStyleDirty() {} // 0x00000001896CD7A4-0x00000001896CD7F4
	}

	[AddComponentMenu("SRF/UI/Style Root")]
	[ExecuteInEditMode]
	public sealed class StyleRoot : SRMonoBehaviour // TypeDefIndex: 58208
	{
		// Fields
		private StyleSheet _activeStyleSheet; // 0x48
		public StyleSheet StyleSheet; // 0x50
	
		// Constructors
		public StyleRoot() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public SRF.UI.Style GetStyle(string key) => default; // 0x00000001896CD83C-0x00000001896CD8F8
		private void OnEnable() {} // 0x00000001896CD900-0x00000001896CD970
		private void OnDisable() {} // 0x00000001896CD8F8-0x00000001896CD900
		private void Update() {} // 0x00000001896CD9C4-0x00000001896CDA34
		private void OnStyleSheetChanged() {} // 0x00000001896CD970-0x00000001896CD9C4
		public void SetDirty() {} // 0x0000000185D6CFCC-0x0000000185D6CFE0
	}

	[Serializable]
	public class Style // TypeDefIndex: 58209
	{
		// Fields
		public UnityEngine.Color ActiveColor; // 0x10
		public UnityEngine.Color DisabledColor; // 0x20
		public UnityEngine.Color HoverColor; // 0x30
		public Sprite Image; // 0x40
		public UnityEngine.Color NormalColor; // 0x48
	
		// Constructors
		public Style() {} // 0x00000001896CDC9C-0x00000001896CDCF4
	
		// Methods
		public Style Copy() => default; // 0x00000001896CDC30-0x00000001896CDC9C
		public void CopyFrom(Style style) {} // 0x00000001896CDBD4-0x00000001896CDC30
	}

	[Serializable]
	public class StyleSheet : ScriptableObject // TypeDefIndex: 58210
	{
		// Fields
		[SerializeField]
		private List<string> _keys; // 0x18
		[SerializeField]
		private List<SRF.UI.Style> _styles; // 0x20
		[SerializeField]
		public StyleSheet Parent; // 0x28
	
		// Constructors
		public StyleSheet() {} // 0x00000001896CDB0C-0x00000001896CDBD4
	
		// Methods
		public SRF.UI.Style GetStyle(string key, bool searchParent = true /* Metadata: 0x01FDAC9D */) => default; // 0x00000001896CDA34-0x00000001896CDB0C
	}

	[AddComponentMenu("SRF/UI/Unselectable")]
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler // TypeDefIndex: 58211
	{
		// Fields
		private bool _suspectedSelected; // 0x48
	
		// Constructors
		public Unselectable() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnSelect(BaseEventData eventData) {} // 0x0000000183D73A50-0x0000000183D73A60
		private void Update() {} // 0x00000001896CF2B0-0x00000001896CF378
	}
}

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup // TypeDefIndex: 58212
	{
		// Fields
		private readonly IList<RectTransform> _rowList; // 0x58
		private float _layoutHeight; // 0x60
		public bool ChildForceExpandHeight; // 0x64
		public bool ChildForceExpandWidth; // 0x65
		public float Spacing; // 0x68
	
		// Properties
		protected bool IsCenterAlign { get => default; } // 0x00000001896C78E4-0x00000001896C78FC 
		protected bool IsRightAlign { get => default; } // 0x00000001896C792C-0x00000001896C7944 
		protected bool IsMiddleAlign { get => default; } // 0x00000001896C7914-0x00000001896C792C 
		protected bool IsLowerAlign { get => default; } // 0x00000001896C78FC-0x00000001896C7914 
	
		// Constructors
		public FlowLayoutGroup() {} // 0x00000001896C7864-0x00000001896C78E4
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x00000001896C6EC8-0x00000001896C6F4C
		public override void SetLayoutHorizontal() {} // 0x00000001896C7384-0x00000001896C73D0
		public override void SetLayoutVertical() {} // 0x00000001896C73D0-0x00000001896C741C
		public override void CalculateLayoutInputVertical() {} // 0x00000001896C6F4C-0x00000001896C6FA0
		public float SetLayout(float width, int axis, bool layoutInput) => default; // 0x00000001896C741C-0x00000001896C7864
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight) => default; // 0x00000001896C6FA0-0x00000001896C7024
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis) {} // 0x00000001896C70B4-0x00000001896C7384
		public float GetGreatestMinimumChildWidth() => default; // 0x00000001896C7024-0x00000001896C70B4
	}

	public interface IVirtualView // TypeDefIndex: 58213
	{
		// Methods
		void SetDataContext(object data);
	}

	[AddComponentMenu("SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler // TypeDefIndex: 58216
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
		public SelectedItemChangedEvent SelectedItemChanged { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		public object SelectedItem { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x00000001896D0C7C-0x00000001896D0DE0
		public override float minHeight { get => default; } // 0x00000001896D0BB0-0x00000001896D0C7C 
		private ScrollRect ScrollRect { get => default; } // 0x00000001896D0B2C-0x00000001896D0BB0 
		private bool AlignBottom { get => default; } // 0x00000001896D09A0-0x00000001896D09B8 
		private bool AlignTop { get => default; } // 0x00000001896D09B8-0x00000001896D09D0 
		private float ItemHeight { get => default; } // 0x00000001896D09D0-0x00000001896D0B2C 
	
		// Nested types
		[Serializable]
		public class SelectedItemChangedEvent : UnityEvent<object> // TypeDefIndex: 58214
		{
			// Constructors
			public SelectedItemChangedEvent() {} // 0x00000001896CC14C-0x00000001896CC188
		}
	
		[Serializable]
		private class Row // TypeDefIndex: 58215
		{
			// Fields
			public object Data; // 0x10
			public int Index; // 0x18
			public RectTransform Rect; // 0x20
			public StyleRoot Root; // 0x28
			public IVirtualView View; // 0x30
	
			// Constructors
			public Row() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public VirtualVerticalLayoutGroup() {} // 0x00000001896D0880-0x00000001896D09A0
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001896CFBA0-0x00000001896CFD10
		protected override void Awake() {} // 0x00000001896CF438-0x00000001896CF5A0
		private void OnScrollRectValueChanged(Vector2 d) {} // 0x00000001896CFD10-0x00000001896CFD68
		protected override void Start() {} // 0x00000001896D079C-0x00000001896D07A4
		protected override void OnEnable() {} // 0x00000001896CFB80-0x00000001896CFBA0
		protected void Update() {} // 0x00000001896D07A4-0x00000001896D0880
		protected void InvalidateItem(int itemIndex) {} // 0x00000001896CFA58-0x00000001896CFB80
		protected void RefreshIndexCache() {} // 0x00000001896CFFAC-0x00000001896D0080
		protected void ScrollUpdate() {} // 0x00000001896D0130-0x00000001896D0480
		public override void CalculateLayoutInputVertical() {} // 0x00000001896CF5A0-0x00000001896CF5E8
		public override void SetLayoutHorizontal() {} // 0x00000001896D04AC-0x00000001896D0658
		public override void SetLayoutVertical() {} // 0x00000001896D0658-0x00000001896D079C
		private new void SetDirty() {} // 0x00000001896D0480-0x00000001896D04AC
		public void AddItem(object item) {} // 0x00000001896CF378-0x00000001896CF438
		public void RemoveItem(object item) {} // 0x00000001896D0080-0x00000001896D0130
		public void ClearItems() {} // 0x00000001896CF5E8-0x00000001896CF69C
		private Row GetRow(int forIndex) => default; // 0x00000001896CF89C-0x00000001896CFA58
		private void RecycleRow(Row row) {} // 0x00000001896CFF58-0x00000001896CFFAC
		private void PopulateRow(int index, Row row) {} // 0x00000001896CFD68-0x00000001896CFF58
		private Row CreateRow() => default; // 0x00000001896CF69C-0x00000001896CF89C
	}
}
