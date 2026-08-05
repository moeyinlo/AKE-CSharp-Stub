/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 91: ZSimpleJSON.dll - Assembly: ZSimpleJSON, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62918-62940
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace ZSimpleJSON
{
	public abstract class JSONNode // TypeDefIndex: 62926
	{
		// Fields
		public static byte Color32DefaultAlpha; // 0x00
		public static float ColorDefaultAlpha; // 0x04
		public static JSONContainerType VectorContainerType; // 0x08
		public static JSONContainerType QuaternionContainerType; // 0x0C
		public static JSONContainerType RectContainerType; // 0x10
		public static JSONContainerType ColorContainerType; // 0x14
		public static bool forceASCII; // 0x18
		public static bool longAsString; // 0x19
		public static bool allowLineComments; // 0x1A
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder; // 0x80000000
	
		// Properties
		public virtual decimal AsDecimal { get; set; } // 0x000000018B8BA794-0x000000018B8BA808 0x000000018B8BCAB0-0x000000018B8BCB0C
		public virtual char AsChar { get; set; } // 0x000000018B8BA658-0x000000018B8BA6E0 0x000000018B8BC990-0x000000018B8BCA28
		public virtual uint AsUInt { get; set; } // 0x000000018B8BAC3C-0x000000018B8BAC58 0x000000018B8BCE20-0x000000018B8BCE3C
		public virtual byte AsByte { get; set; } // 0x00000001853912C0-0x00000001853912D0 0x000000018B8BC97C-0x000000018B8BC990
		public virtual sbyte AsSByte { get; set; } // 0x00000001853912C0-0x00000001853912D0 0x000000018B8BCC2C-0x000000018B8BCC40
		public virtual short AsShort { get; set; } // 0x00000001853912C0-0x00000001853912D0 0x000000018B8BCC40-0x000000018B8BCC54
		public virtual ushort AsUShort { get; set; } // 0x00000001853912C0-0x00000001853912D0 0x000000018B8BCEA0-0x000000018B8BCEB4
		public virtual System.DateTime AsDateTime { get; set; } // 0x000000018B8BA6E0-0x000000018B8BA794 0x000000018B8BCA28-0x000000018B8BCAB0
		public virtual TimeSpan AsTimeSpan { get; set; } // 0x000000018B8BAB8C-0x000000018B8BAC3C 0x000000018B8BCDC8-0x000000018B8BCE20
		public virtual Guid AsGuid { get; set; } // 0x000000018B8BA8B0-0x000000018B8BA8E0 0x000000018B8BCB84-0x000000018B8BCBB0
		public virtual byte[] AsByteArray { get; set; } // 0x000000018B8BA484-0x000000018B8BA558 0x000000018B8BC810-0x000000018B8BC8B8
		public virtual List<byte> AsByteList { get; set; } // 0x000000018B8BA558-0x000000018B8BA658 0x000000018B8BC8B8-0x000000018B8BC97C
		public virtual ulong[] AsUlongArray { get; set; } // 0x000000018B8BACD4-0x000000018B8BADAC 0x000000018B8BCEB4-0x000000018B8BCF60
		public virtual string[] AsStringArray { get; set; } // 0x000000018B8BA9B4-0x000000018B8BAA88 0x000000018B8BCC54-0x000000018B8BCD00
		public virtual List<string> AsStringList { get; set; } // 0x000000018B8BAA88-0x000000018B8BAB8C 0x000000018B8BCD00-0x000000018B8BCDC8
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		public virtual string Value { get; set; } // 0x000000018B8BAF84-0x000000018B8BAFB0 0x00000001841E1670-0x00000001841E1680
		public virtual int Count { get; } // 0x00000001811EC580-0x00000001811EC590 
		public virtual bool IsNumber { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsString { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsBoolean { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsNull { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsArray { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsObject { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool Inline { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__181))] get; } // 0x000000018B8BADAC-0x000000018B8BAE00 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine(typeof(_get_DeepChildren_d__183))] get; } // 0x000000018B8BAE00-0x000000018B8BAE70 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x000000018B8BAF24-0x000000018B8BAF84 
		public KeyEnumerator Keys { get; } // 0x000000018B8BAE70-0x000000018B8BAF24 
		public ValueEnumerator Values { get; } // 0x000000018B8BAE70-0x000000018B8BAF24 
		public virtual double AsDouble { get; set; } // 0x000000018B8BA808-0x000000018B8BA894 0x000000018B8BCB0C-0x000000018B8BCB70
		public virtual int AsInt { get; set; } // 0x000000018B8BA8E0-0x000000018B8BA8FC 0x000000018B8BCBB0-0x000000018B8BCBC8
		public virtual float AsFloat { get; set; } // 0x000000018B8BA894-0x000000018B8BA8B0 0x000000018B8BCB70-0x000000018B8BCB84
		public virtual bool AsBool { get; set; } // 0x000000018B8BA3E8-0x000000018B8BA484 0x000000018B8BC7A4-0x000000018B8BC810
		public virtual long AsLong { get; set; } // 0x000000018B8BA8FC-0x000000018B8BA978 0x000000018B8BCBC8-0x000000018B8BCC2C
		public virtual ulong AsULong { get; set; } // 0x000000018B8BAC58-0x000000018B8BACD4 0x000000018B8BCE3C-0x000000018B8BCEA0
		public virtual JSONArray AsArray { get; } // 0x000000018B8BA3AC-0x000000018B8BA3E8 
		public virtual JSONObject AsObject { get; } // 0x000000018B8BA978-0x000000018B8BA9B4 
		internal static StringBuilder EscapeBuilder { get; } // 0x000000018360CBC0-0x000000018360CCB0 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 62920
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get; } // 0x00000001868B8E74-0x00000001868B8E7C 
			public KeyValuePair<string, JSONNode> Current { get; } // 0x00000001836D56A0-0x00000001836D56D0 
	
			// Nested types
			private enum Type // TypeDefIndex: 62919
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum); // 0x0000000189DB87E4-0x0000000189DB8818
			public Enumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000184B0C3F0-0x0000000184B0C440
	
			// Methods
			public bool MoveNext(); // 0x00000001836D5670-0x00000001836D56A0
		}
	
		public struct ValueEnumerator // TypeDefIndex: 62921
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get; } // 0x000000018B8BEE84-0x000000018B8BEEC4 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum); // 0x0000000189DC2BA0-0x0000000189DC2C38
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000189DC2ACC-0x0000000189DC2B6C
			public ValueEnumerator(Enumerator aEnumerator); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
			// Methods
			public bool MoveNext(); // 0x000000018B8BDC20-0x000000018B8BDC28
			public ValueEnumerator GetEnumerator(); // 0x0000000184DA2D60-0x0000000184DA2D90
		}
	
		public struct KeyEnumerator // TypeDefIndex: 62922
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get; } // 0x000000018B8BDC28-0x000000018B8BDC68 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum); // 0x0000000189DC2BA0-0x0000000189DC2C38
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000189DC2ACC-0x0000000189DC2B6C
			public KeyEnumerator(Enumerator aEnumerator); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
			// Methods
			public bool MoveNext(); // 0x000000018B8BDC20-0x000000018B8BDC28
			public KeyEnumerator GetEnumerator(); // 0x0000000184DA2D60-0x0000000184DA2D90
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 62923
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get; } // 0x000000018B8BDEEC-0x000000018B8BDF18 
			object IEnumerator.Current { get; } // 0x000000018B8BDDE0-0x000000018B8BDE38 
	
			// Constructors
			internal LinqEnumerator(JSONNode aNode); // 0x000000018B8BDE38-0x000000018B8BDEEC
	
			// Methods
			public bool MoveNext(); // 0x000000018B8BDCCC-0x000000018B8BDCD8
			public void Dispose(); // 0x0000000189DC2C78-0x0000000189DC2CB4
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator(); // 0x000000018B8BDC68-0x000000018B8BDCCC
			public void Reset(); // 0x000000018B8BDCD8-0x000000018B8BDD7C
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B8BDD7C-0x000000018B8BDDE0
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__181 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 62924
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__181(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184D83CA0-0x0000000184D83CB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B8BDFFC-0x000000018B8BE048
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018B8BDF7C-0x000000018B8BDFF4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B8BDFF4-0x000000018B8BDFFC
		}
	
		[CompilerGenerated]
		private sealed class _get_DeepChildren_d__183 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 62925
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONNode __4__this; // 0x28
			private IEnumerator<JSONNode> __7__wrap1; // 0x30
			private IEnumerator<JSONNode> __7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_DeepChildren_d__183(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B8BED04-0x000000018B8BEDF0
			private bool MoveNext(); // 0x000000018B8BE82C-0x000000018B8BEC24
			private void __m__Finally1(); // 0x000000018B8BEDF0-0x000000018B8BEE38
			private void __m__Finally2(); // 0x000000018B8BEE38-0x000000018B8BEE84
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B8BECB8-0x000000018B8BED04
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018B8BEC24-0x000000018B8BECB0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B8BECB0-0x000000018B8BECB8
		}
	
		// Constructors
		protected JSONNode(); // 0x00000001841E1670-0x00000001841E1680
		static JSONNode(); // 0x0000000184CDC2C0-0x0000000184CDC390
	
		// Methods
		public static implicit operator JSONNode(decimal aDecimal); // 0x000000018B8BB710-0x000000018B8BB794
		public static implicit operator decimal(JSONNode aNode); // 0x000000018B8BBCD4-0x000000018B8BBD04
		public static implicit operator JSONNode(char aChar); // 0x000000018B8BC41C-0x000000018B8BC4A4
		public static implicit operator char(JSONNode aNode); // 0x000000018B8BC3E4-0x000000018B8BC400
		public static implicit operator JSONNode(uint aUInt); // 0x00000001849DD510-0x00000001849DD580
		public static implicit operator uint(JSONNode aNode); // 0x000000018B8BC344-0x000000018B8BC360
		public static implicit operator JSONNode(byte aByte); // 0x000000018B8BBED4-0x000000018B8BBF38
		public static implicit operator byte(JSONNode aNode); // 0x000000018B8BB430-0x000000018B8BB44C
		public static implicit operator JSONNode(sbyte aSByte); // 0x000000018B8BC674-0x000000018B8BC6D8
		public static implicit operator sbyte(JSONNode aNode); // 0x000000018B8BB430-0x000000018B8BB44C
		public static implicit operator JSONNode(short aShort); // 0x000000018B8BB3CC-0x000000018B8BB430
		public static implicit operator short(JSONNode aNode); // 0x000000018B8BB430-0x000000018B8BB44C
		public static implicit operator JSONNode(ushort aUShort); // 0x000000018B8BC228-0x000000018B8BC28C
		public static implicit operator ushort(JSONNode aNode); // 0x000000018B8BB430-0x000000018B8BB44C
		public static implicit operator JSONNode(System.DateTime aDateTime); // 0x000000018B8BB1DC-0x000000018B8BB28C
		public static implicit operator System.DateTime(JSONNode aNode); // 0x000000018B8BBD6C-0x000000018B8BBD88
		public static implicit operator JSONNode(TimeSpan aTimeSpan); // 0x000000018B8BB344-0x000000018B8BB3CC
		public static implicit operator TimeSpan(JSONNode aNode); // 0x000000018B8BBC9C-0x000000018B8BBCB8
		public static implicit operator JSONNode(Guid aGuid); // 0x000000018B8BB170-0x000000018B8BB1DC
		public static implicit operator Guid(JSONNode aNode); // 0x000000018B8BBEA4-0x000000018B8BBED4
		public static implicit operator JSONNode(byte[] aByteArray); // 0x000000018B8BB6A4-0x000000018B8BB710
		public static implicit operator byte[](JSONNode aNode); // 0x000000018B8BBE20-0x000000018B8BBE3C
		public static implicit operator JSONNode(List<byte> aByteList); // 0x000000018B8BC1BC-0x000000018B8BC228
		public static implicit operator List<byte>(JSONNode aNode); // 0x000000018B8BB44C-0x000000018B8BB468
		public static implicit operator JSONNode(ulong[] aStringArray); // 0x000000018B8BC51C-0x000000018B8BC588
		public static implicit operator ulong[](JSONNode aNode); // 0x000000018B8BBAE0-0x000000018B8BBAFC
		public static implicit operator JSONNode(string[] aStringArray); // 0x000000018B8BB528-0x000000018B8BB594
		public static implicit operator string[](JSONNode aNode); // 0x000000018B8BBCB8-0x000000018B8BBCD4
		public static implicit operator JSONNode(List<string> aStringList); // 0x000000018B8BBFA0-0x000000018B8BC00C
		public static implicit operator List<string>(JSONNode aNode); // 0x000000018B8BC0A0-0x000000018B8BC0BC
		public static implicit operator JSONNode(int? aValue); // 0x0000000184950E40-0x0000000184950ED0
		public static implicit operator int?(JSONNode aNode); // 0x000000018B8BBD88-0x000000018B8BBE20
		public static implicit operator JSONNode(float? aValue); // 0x000000018B8BBA24-0x000000018B8BBAE0
		public static implicit operator float?(JSONNode aNode); // 0x000000018B8BC124-0x000000018B8BC1BC
		public static implicit operator JSONNode(double? aValue); // 0x000000018B8BB974-0x000000018B8BBA24
		public static implicit operator double?(JSONNode aNode); // 0x000000018B8BB840-0x000000018B8BB8F0
		public static implicit operator JSONNode(bool? aValue); // 0x000000018B8BB088-0x000000018B8BB140
		public static implicit operator bool?(JSONNode aNode); // 0x000000018B8BC28C-0x000000018B8BC328
		public static implicit operator JSONNode(long? aValue); // 0x000000018B8BBB64-0x000000018B8BBC18
		public static implicit operator long?(JSONNode aNode); // 0x000000018B8BB794-0x000000018B8BB840
		public static implicit operator JSONNode(short? aValue); // 0x000000018B8BB28C-0x000000018B8BB344
		public static implicit operator short?(JSONNode aNode); // 0x000000018B8BC00C-0x000000018B8BC0A0
		private static JSONNode GetContainer(JSONContainerType aType); // 0x000000018B8B8250-0x000000018B8B82D4
		public static implicit operator JSONNode(Vector2 aVec); // 0x000000018B8BB594-0x000000018B8BB63C
		public static implicit operator JSONNode(Vector3 aVec); // 0x000000018B8BC6D8-0x000000018B8BC7A4
		public static implicit operator JSONNode(Vector4 aVec); // 0x000000018B8BC588-0x000000018B8BC60C
		public static implicit operator JSONNode(UnityEngine.Color aCol); // 0x000000018B8BBC18-0x000000018B8BBC9C
		public static implicit operator JSONNode(Color32 aCol); // 0x000000018B8BAFE0-0x000000018B8BB058
		public static implicit operator JSONNode(Quaternion aRot); // 0x000000018B8BB8F0-0x000000018B8BB974
		public static implicit operator JSONNode(Rect aRect); // 0x000000018B8BC360-0x000000018B8BC3E4
		public static implicit operator JSONNode(RectOffset aRect); // 0x000000018B8BC4A4-0x000000018B8BC51C
		public static implicit operator Vector2(JSONNode aNode); // 0x000000018B8BC400-0x000000018B8BC41C
		public static implicit operator Vector3(JSONNode aNode); // 0x000000018B8BB4F0-0x000000018B8BB528
		public static implicit operator Vector4(JSONNode aNode); // 0x000000018B8BBF38-0x000000018B8BBF68
		public static implicit operator UnityEngine.Color(JSONNode aNode); // 0x000000018B8BAFB0-0x000000018B8BAFE0
		public static implicit operator Color32(JSONNode aNode); // 0x000000018B8BB4D0-0x000000018B8BB4F0
		public static implicit operator Quaternion(JSONNode aNode); // 0x000000018B8BB058-0x000000018B8BB088
		public static implicit operator Rect(JSONNode aNode); // 0x000000018B8BB140-0x000000018B8BB170
		public static implicit operator RectOffset(JSONNode aNode); // 0x000000018B8BC328-0x000000018B8BC344
		public Vector2 ReadVector2(Vector2 aDefault); // 0x000000018B8B8F6C-0x000000018B8B9054
		public Vector2 ReadVector2(string aXName, string aYName); // 0x000000018B8B8ECC-0x000000018B8B8F6C
		public Vector2 ReadVector2(); // 0x000000018B8B8EB4-0x000000018B8B8ECC
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x023523CC */, string aYName = "y" /* Metadata: 0x023523CE */); // 0x000000018B8B9FA8-0x000000018B8BA0A0
		public Vector3 ReadVector3(Vector3 aDefault); // 0x000000018B8B918C-0x000000018B8B9308
		public Vector3 ReadVector3(string aXName, string aYName, string aZName); // 0x000000018B8B90A4-0x000000018B8B918C
		public Vector3 ReadVector3(); // 0x000000018B8B9054-0x000000018B8B90A4
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x023523D0 */, string aYName = "y" /* Metadata: 0x023523D2 */, string aZName = "z" /* Metadata: 0x023523D4 */); // 0x000000018B8BA0A0-0x000000018B8BA1E0
		public Vector4 ReadVector4(Vector4 aDefault); // 0x000000018B8B9308-0x000000018B8B94E4
		public Vector4 ReadVector4(); // 0x000000018B8B94E4-0x000000018B8B9520
		public JSONNode WriteVector4(Vector4 aVec); // 0x000000018B8BA1E0-0x000000018B8BA3AC
		public UnityEngine.Color ReadColor(UnityEngine.Color aDefault); // 0x000000018B8B84EC-0x000000018B8B8720
		public UnityEngine.Color ReadColor(); // 0x000000018B8B8720-0x000000018B8B875C
		public JSONNode WriteColor(UnityEngine.Color aCol); // 0x000000018B8B9778-0x000000018B8B9944
		public Color32 ReadColor32(Color32 aDefault); // 0x000000018B8B82E0-0x000000018B8B84EC
		public Color32 ReadColor32(); // 0x000000018B8B82D4-0x000000018B8B82E0
		public JSONNode WriteColor32(Color32 aCol); // 0x000000018B8B95B0-0x000000018B8B9778
		public Quaternion ReadQuaternion(Quaternion aDefault); // 0x000000018B8B8810-0x000000018B8B89EC
		public Quaternion ReadQuaternion(); // 0x000000018B8B89EC-0x000000018B8B8A28
		public JSONNode WriteQuaternion(Quaternion aRot); // 0x000000018B8B99D8-0x000000018B8B9BA4
		public Rect ReadRect(Rect aDefault); // 0x000000018B8B8CA4-0x000000018B8B8E80
		public Rect ReadRect(); // 0x000000018B8B8E80-0x000000018B8B8EB4
		public JSONNode WriteRect(Rect aRect); // 0x000000018B8B9DDC-0x000000018B8B9FA8
		public RectOffset ReadRectOffset(RectOffset aDefault); // 0x000000018B8B8A90-0x000000018B8B8CA4
		public RectOffset ReadRectOffset(); // 0x000000018B8B8A28-0x000000018B8B8A90
		public JSONNode WriteRectOffset(RectOffset aRect); // 0x000000018B8B9BA4-0x000000018B8B9DDC
		public Matrix4x4 ReadMatrix(); // 0x000000018B8B875C-0x000000018B8B8810
		public JSONNode WriteMatrix(Matrix4x4 aMatrix); // 0x000000018B8B9944-0x000000018B8B99D8
		public virtual void Add(string aKey, JSONNode aItem); // 0x00000001841E1670-0x00000001841E1680
		public virtual void Add(JSONNode aItem); // 0x0000000183B4AD90-0x0000000183B4ADB0
		public virtual JSONNode Remove(string aKey); // 0x00000001811EC580-0x00000001811EC590
		public virtual JSONNode Remove(int aIndex); // 0x00000001811EC580-0x00000001811EC590
		public virtual JSONNode Remove(JSONNode aNode); // 0x0000000184D88C30-0x0000000184D88C40
		public virtual void Clear(); // 0x00000001841E1670-0x00000001841E1680
		public virtual JSONNode Clone(); // 0x00000001811EC580-0x00000001811EC590
		public virtual bool HasKey(string aKey); // 0x00000001812081B0-0x0000000181208610
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x0000000184D8C7E0-0x0000000184D8C7F0
		public override string ToString(); // 0x0000000184610F80-0x0000000184611010
		public virtual string ToString(int aIndent); // 0x000000018B8B9520-0x000000018B8B95B0
		public virtual void ToStringBuild(ref StringBuilder sb); // 0x0000000183A756A0-0x0000000183A756F0
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s); // 0x0000000183B4AEF0-0x0000000183B4AF60
		public static implicit operator string(JSONNode d); // 0x000000018B8BB63C-0x000000018B8BB6A4
		public static implicit operator JSONNode(double n); // 0x0000000183B4AA70-0x0000000183B4AAC0
		public static implicit operator double(JSONNode d); // 0x000000018B8BBAFC-0x000000018B8BBB64
		public static implicit operator JSONNode(float n); // 0x0000000183B4AC60-0x0000000183B4ACB0
		public static implicit operator float(JSONNode d); // 0x000000018B8BBD04-0x000000018B8BBD6C
		public static implicit operator JSONNode(int n); // 0x0000000183B4ACB0-0x0000000183B4AD00
		public static implicit operator int(JSONNode d); // 0x000000018B8BBE3C-0x000000018B8BBEA4
		public static implicit operator JSONNode(long n); // 0x0000000183B4ABE0-0x0000000183B4AC60
		public static implicit operator long(JSONNode d); // 0x000000018B8BC0BC-0x000000018B8BC124
		public static implicit operator JSONNode(ulong n); // 0x0000000183A72870-0x0000000183A72960
		public static implicit operator ulong(JSONNode d); // 0x000000018B8BB468-0x000000018B8BB4D0
		public static implicit operator JSONNode(bool b); // 0x0000000183A74420-0x0000000183A74470
		public static implicit operator bool(JSONNode d); // 0x000000018B8BC60C-0x000000018B8BC674
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue); // 0x000000018B8BBF68-0x000000018B8BBFA0
		public static bool operator ==(JSONNode a, object b); // 0x0000000183D53B10-0x0000000183D53BC0
		public static bool operator !=(JSONNode a, object b); // 0x0000000183D539A0-0x0000000183D539F0
		public override bool Equals(object obj); // 0x0000000183D53990-0x0000000183D539A0
		public override int GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
		internal static string Escape(string aText); // 0x000000018360C7B0-0x000000018360CA30
		private static JSONNode ParseElement(string token, bool quoted); // 0x0000000183B4A400-0x0000000183B4A450
		public static JSONNode Parse(string aJSON); // 0x0000000183B49E20-0x0000000183B4A400
	}

	public enum JSONContainerType // TypeDefIndex: 62927
	{
		Array = 0,
		Object = 1
	}

	public enum JSONNodeType // TypeDefIndex: 62928
	{
		Array = 1,
		Object = 2,
		String = 3,
		Number = 4,
		NullValue = 5,
		Boolean = 6,
		None = 7,
		Custom = 255
	}

	public enum JSONTextMode // TypeDefIndex: 62929
	{
		Compact = 0,
		Indent = 1
	}

	public class JSONArray : JSONNode // TypeDefIndex: 62931
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public override JSONNodeType Tag { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public override bool IsArray { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018B8B7168-0x000000018B8B7208 0x0000000183D53860-0x0000000183D53900
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018B8B7108-0x000000018B8B7168 0x000000018B8B7208-0x000000018B8B72A8
		public override int Count { get; } // 0x000000018B8B70C8-0x000000018B8B7108 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__24))] get; } // 0x000000018B8B7058-0x000000018B8B70C8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_Children_d__24 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 62930
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONArray __4__this; // 0x28
			private List<JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__24(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B8BE370-0x000000018B8BE3E8
			private bool MoveNext(); // 0x000000018B8BE048-0x000000018B8BE290
			private void __m__Finally1(); // 0x000000018B8BE3E8-0x000000018B8BE424
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B8BE324-0x000000018B8BE370
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018B8BE290-0x000000018B8BE31C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B8BE31C-0x000000018B8BE324
		}
	
		// Constructors
		public JSONArray(); // 0x000000018355DBA0-0x000000018355DC40
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x000000018B8B6ECC-0x000000018B8B6F5C
		public override void Add(string aKey, JSONNode aItem); // 0x0000000183D53730-0x0000000183D537A0
		public override JSONNode Remove(int aIndex); // 0x000000018B8B6F5C-0x000000018B8B7000
		public override JSONNode Remove(JSONNode aNode); // 0x000000018B8B7000-0x000000018B8B7058
		public override void Clear(); // 0x000000018B8B6C54-0x000000018B8B6C9C
		public override JSONNode Clone(); // 0x000000018B8B6C9C-0x000000018B8B6ECC
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018360E340-0x000000018360E450
	}

	public class JSONObject : JSONNode // TypeDefIndex: 62934
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public override JSONNodeType Tag { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override bool IsObject { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018B8BD9B8-0x000000018B8BDA78 0x0000000183D539F0-0x0000000183D53B10
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018B8BD92C-0x000000018B8BD9B8 0x000000018B8BDA78-0x000000018B8BDB7C
		public override int Count { get; } // 0x000000018B8BD8EC-0x000000018B8BD92C 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__27))] get; } // 0x000000018B8BD87C-0x000000018B8BD8EC 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 62932
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Remove_b__0(KeyValuePair<string, JSONNode> k); // 0x000000018B8BDF18-0x000000018B8BDF7C
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__27 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 62933
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONObject __4__this; // 0x28
			private Dictionary<string, JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__27(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B8BE778-0x000000018B8BE7F0
			private bool MoveNext(); // 0x000000018B8BE424-0x000000018B8BE698
			private void __m__Finally1(); // 0x000000018B8BE7F0-0x000000018B8BE82C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B8BE72C-0x000000018B8BE778
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018B8BE698-0x000000018B8BE724
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B8BE724-0x000000018B8BE72C
		}
	
		// Constructors
		public JSONObject(); // 0x0000000183B490B0-0x0000000183B49120
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184B0C340-0x0000000184B0C3F0
		public override void Add(string aKey, JSONNode aItem); // 0x0000000183D537A0-0x0000000183D53860
		public override JSONNode Remove(string aKey); // 0x000000018B8BD558-0x000000018B8BD610
		public override JSONNode Remove(int aIndex); // 0x000000018B8BD610-0x000000018B8BD6D0
		public override JSONNode Remove(JSONNode aNode); // 0x000000018B8BD6D0-0x000000018B8BD87C
		public override void Clear(); // 0x0000000184553E10-0x0000000184553E40
		public override JSONNode Clone(); // 0x000000018B8BD2BC-0x000000018B8BD488
		public override bool HasKey(string aKey); // 0x000000018B8BD504-0x000000018B8BD558
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x000000018B8BD488-0x000000018B8BD504
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018360E070-0x000000018360E340
	}

	public class JSONString : JSONNode // TypeDefIndex: 62935
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D8C9E0-0x0000000184D8C9F0 
		public override bool IsString { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public JSONString(string aData); // 0x0000000183B4AF60-0x0000000183B4AFA0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		public override JSONNode Clone(); // 0x000000018B8BDBBC-0x000000018B8BDC20
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018360D970-0x000000018360DA00
		public override bool Equals(object obj); // 0x0000000183D53900-0x0000000183D53990
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
		public override void Clear(); // 0x000000018B8BDB7C-0x000000018B8BDBBC
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 62936
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public override bool IsNumber { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x000000018382D9A0-0x000000018382D9E0 0x000000018B8BD23C-0x000000018B8BD2BC
		public override double AsDouble { get; set; } // 0x0000000184D96320-0x0000000184D96330 0x0000000184D85BA0-0x0000000184D85BB0
		public override long AsLong { get; set; } // 0x0000000184DA2D40-0x0000000184DA2D50 0x0000000184DA2D50-0x0000000184DA2D60
		public override ulong AsULong { get; set; } // 0x000000018B8BD230-0x000000018B8BD23C 0x0000000184DBF6A0-0x0000000184DBF6D0
	
		// Constructors
		public JSONNumber(double aData); // 0x0000000183B4AD00-0x0000000183B4AD40
		public JSONNumber(string aData); // 0x000000018B8BD1D4-0x000000018B8BD230
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		public override JSONNode Clone(); // 0x000000018B8BD024-0x000000018B8BD08C
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x00000001840717C0-0x0000000184071830
		private static bool IsNumeric(object value); // 0x000000018B8BD08C-0x000000018B8BD1D4
		public override bool Equals(object obj); // 0x0000000184232AD0-0x0000000184232B00
		public override int GetHashCode(); // 0x0000000189DC1AD4-0x0000000189DC1AE0
		public override void Clear(); // 0x0000000184DA8180-0x0000000184DA8190
	}

	public class JSONBool : JSONNode // TypeDefIndex: 62937
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D9EC60-0x0000000184D9EC70 
		public override bool IsBoolean { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x000000018B8B73B0-0x000000018B8B7404 0x000000018B8B7404-0x000000018B8B7468
		public override bool AsBool { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public JSONBool(bool aData); // 0x0000000183A74470-0x0000000183A744B0
		public JSONBool(string aData); // 0x000000018B8B7354-0x000000018B8B73B0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		public override JSONNode Clone(); // 0x000000018B8B72A8-0x000000018B8B730C
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000184503B80-0x0000000184503BC0
		public override bool Equals(object obj); // 0x00000001845F14B0-0x00000001845F14D0
		public override int GetHashCode(); // 0x000000018B8B730C-0x000000018B8B7354
		public override void Clear(); // 0x0000000184D8CCB0-0x0000000184D8CCC0
	}

	public class JSONNull : JSONNode // TypeDefIndex: 62938
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
		public override bool IsNull { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x000000018B8BCFF8-0x000000018B8BD024 0x00000001841E1670-0x00000001841E1680
		public override bool AsBool { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
	
		// Constructors
		private JSONNull(); // 0x0000000184CE7B70-0x0000000184CE7BB0
		static JSONNull(); // 0x0000000184CE7AE0-0x0000000184CE7B70
	
		// Methods
		public static JSONNull CreateOrGet(); // 0x0000000183D53BC0-0x0000000183D53C40
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		public override JSONNode Clone(); // 0x000000018B8BCF60-0x000000018B8BCFA0
		public override bool Equals(object obj); // 0x000000018B8BCFA0-0x000000018B8BCFF8
		public override int GetHashCode(); // 0x00000001811EC580-0x00000001811EC590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x00000001845F0B90-0x00000001845F0BE0
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 62939
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D9BE00-0x0000000184D9BE10 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018B8B7B98-0x000000018B8B7BF8 0x000000018B8B81BC-0x000000018B8B8250
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018B8B7BF8-0x000000018B8B7C68 0x000000018B8B8114-0x000000018B8B81BC
		public override int AsInt { get; set; } // 0x000000018B8B78AC-0x000000018B8B7928 0x000000018B8B7E04-0x000000018B8B7E90
		public override float AsFloat { get; set; } // 0x000000018B8B782C-0x000000018B8B78AC 0x000000018B8B7D78-0x000000018B8B7E04
		public override double AsDouble { get; set; } // 0x000000018B8B77AC-0x000000018B8B782C 0x000000018B8B7CF0-0x000000018B8B7D78
		public override long AsLong { get; set; } // 0x000000018B8B7928-0x000000018B8B7A24 0x000000018B8B7E90-0x000000018B8B7FC4
		public override ulong AsULong { get; set; } // 0x000000018B8B7A9C-0x000000018B8B7B98 0x000000018B8B7FC4-0x000000018B8B8114
		public override bool AsBool { get; set; } // 0x000000018B8B7730-0x000000018B8B77AC 0x000000018B8B7C68-0x000000018B8B7CF0
		public override JSONArray AsArray { get; } // 0x000000018B8B76B8-0x000000018B8B7730 
		public override JSONObject AsObject { get; } // 0x000000018B8B7A24-0x000000018B8B7A9C 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x000000018B8B75EC-0x000000018B8B764C
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x000000018B8B764C-0x000000018B8B76B8
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		private T Set<T>(T aVal)
			where T : JSONNode;
		public override void Add(JSONNode aItem); // 0x000000018B8B7468-0x000000018B8B74FC
		public override void Add(string aKey, JSONNode aItem); // 0x000000018B8B74FC-0x000000018B8B75A4
		public static bool operator ==(JSONLazyCreator a, object b); // 0x0000000189DC0F98-0x0000000189DC0FA8
		public static bool operator !=(JSONLazyCreator a, object b); // 0x0000000189DC1438-0x0000000189DC1448
		public override bool Equals(object obj); // 0x0000000189DC0F98-0x0000000189DC0FA8
		public override int GetHashCode(); // 0x00000001811EC580-0x00000001811EC590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018B8B75A4-0x000000018B8B75EC
	}

	public static class JSON // TypeDefIndex: 62940
	{
		// Methods
		public static JSONNode Parse(string aJSON); // 0x0000000184D5DBE0-0x0000000184D5DC30
	}
}
