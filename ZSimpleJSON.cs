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

// Image 88: ZSimpleJSON.dll - Assembly: ZSimpleJSON, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59278-59300
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace ZSimpleJSON
{
	public abstract class JSONNode // TypeDefIndex: 59286
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
		public virtual decimal AsDecimal { get; set; } // 0x000000018A2B9774-0x000000018A2B97E8 0x000000018A2BBA90-0x000000018A2BBAEC
		public virtual char AsChar { get; set; } // 0x000000018A2B9638-0x000000018A2B96C0 0x000000018A2BB970-0x000000018A2BBA08
		public virtual uint AsUInt { get; set; } // 0x000000018A2B9C1C-0x000000018A2B9C38 0x000000018A2BBE00-0x000000018A2BBE1C
		public virtual byte AsByte { get; set; } // 0x000000018A2B9628-0x000000018A2B9638 0x000000018A2BB95C-0x000000018A2BB970
		public virtual sbyte AsSByte { get; set; } // 0x000000018A2B9628-0x000000018A2B9638 0x000000018A2BBC0C-0x000000018A2BBC20
		public virtual short AsShort { get; set; } // 0x000000018A2B9628-0x000000018A2B9638 0x000000018A2BBC20-0x000000018A2BBC34
		public virtual ushort AsUShort { get; set; } // 0x000000018A2B9628-0x000000018A2B9638 0x000000018A2BBE80-0x000000018A2BBE94
		public virtual System.DateTime AsDateTime { get; set; } // 0x000000018A2B96C0-0x000000018A2B9774 0x000000018A2BBA08-0x000000018A2BBA90
		public virtual TimeSpan AsTimeSpan { get; set; } // 0x000000018A2B9B6C-0x000000018A2B9C1C 0x000000018A2BBDA8-0x000000018A2BBE00
		public virtual Guid AsGuid { get; set; } // 0x000000018A2B9890-0x000000018A2B98C0 0x000000018A2BBB64-0x000000018A2BBB90
		public virtual byte[] AsByteArray { get; set; } // 0x000000018A2B9454-0x000000018A2B9528 0x000000018A2BB7F0-0x000000018A2BB898
		public virtual List<byte> AsByteList { get; set; } // 0x000000018A2B9528-0x000000018A2B9628 0x000000018A2BB898-0x000000018A2BB95C
		public virtual ulong[] AsUlongArray { get; set; } // 0x000000018A2B9CB4-0x000000018A2B9D8C 0x000000018A2BBE94-0x000000018A2BBF40
		public virtual string[] AsStringArray { get; set; } // 0x000000018A2B9994-0x000000018A2B9A68 0x000000018A2BBC34-0x000000018A2BBCE0
		public virtual List<string> AsStringList { get; set; } // 0x000000018A2B9A68-0x000000018A2B9B6C 0x000000018A2BBCE0-0x000000018A2BBDA8
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		public virtual string Value { get; set; } // 0x000000018A2B9F64-0x000000018A2B9F90 0x000000018350B670-0x000000018350B680
		public virtual int Count { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual bool IsNumber { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsString { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsBoolean { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsNull { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsArray { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsObject { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool Inline { get; set; } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__181))] get; } // 0x000000018A2B9D8C-0x000000018A2B9DE0 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine(typeof(_get_DeepChildren_d__183))] get; } // 0x000000018A2B9DE0-0x000000018A2B9E50 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x000000018A2B9F04-0x000000018A2B9F64 
		public KeyEnumerator Keys { get; } // 0x000000018A2B9E50-0x000000018A2B9F04 
		public ValueEnumerator Values { get; } // 0x000000018A2B9E50-0x000000018A2B9F04 
		public virtual double AsDouble { get; set; } // 0x000000018A2B97E8-0x000000018A2B9874 0x000000018A2BBAEC-0x000000018A2BBB50
		public virtual int AsInt { get; set; } // 0x000000018A2B98C0-0x000000018A2B98DC 0x000000018A2BBB90-0x000000018A2BBBA8
		public virtual float AsFloat { get; set; } // 0x000000018A2B9874-0x000000018A2B9890 0x000000018A2BBB50-0x000000018A2BBB64
		public virtual bool AsBool { get; set; } // 0x000000018A2B93B8-0x000000018A2B9454 0x000000018A2BB784-0x000000018A2BB7F0
		public virtual long AsLong { get; set; } // 0x000000018A2B98DC-0x000000018A2B9958 0x000000018A2BBBA8-0x000000018A2BBC0C
		public virtual ulong AsULong { get; set; } // 0x000000018A2B9C38-0x000000018A2B9CB4 0x000000018A2BBE1C-0x000000018A2BBE80
		public virtual JSONArray AsArray { get; } // 0x000000018A2B937C-0x000000018A2B93B8 
		public virtual JSONObject AsObject { get; } // 0x000000018A2B9958-0x000000018A2B9994 
		internal static StringBuilder EscapeBuilder { get; } // 0x00000001825F39E0-0x00000001825F3B00 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 59280
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get => default; } // 0x000000018426F724-0x000000018426F72C 
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x00000001825F6B90-0x00000001825F6C00 
	
			// Nested types
			private enum Type // TypeDefIndex: 59279
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x0000000188854824-0x0000000188854858
			public Enumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x0000000183B109F0-0x0000000183B10A40
	
			// Methods
			public bool MoveNext() => default; // 0x00000001825F6930-0x00000001825F6990
		}
	
		public struct ValueEnumerator // TypeDefIndex: 59281
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get => default; } // 0x000000018A2BDE64-0x000000018A2BDEA4 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EBAC-0x000000018885EC44
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EAD8-0x000000018885EB78
			public ValueEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018885EB78-0x000000018885EBAC
	
			// Methods
			public bool MoveNext() => default; // 0x000000018A2BCC00-0x000000018A2BCC08
			public ValueEnumerator GetEnumerator() => default; // 0x0000000183D6D9B0-0x0000000183D6D9E0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 59282
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get => default; } // 0x000000018A2BCC08-0x000000018A2BCC48 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EBAC-0x000000018885EC44
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EAD8-0x000000018885EB78
			public KeyEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018885EB78-0x000000018885EBAC
	
			// Methods
			public bool MoveNext() => default; // 0x000000018A2BCC00-0x000000018A2BCC08
			public KeyEnumerator GetEnumerator() => default; // 0x0000000183D6D9B0-0x0000000183D6D9E0
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 59283
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x000000018A2BCECC-0x000000018A2BCEF8 
			object IEnumerator.Current { get => default; } // 0x000000018A2BCDC0-0x000000018A2BCE18 
	
			// Constructors
			public LinqEnumerator() {} // Dummy constructor
			internal LinqEnumerator(JSONNode aNode) {} // 0x000000018A2BCE18-0x000000018A2BCECC
	
			// Methods
			public bool MoveNext() => default; // 0x000000018A2BCCAC-0x000000018A2BCCB8
			public void Dispose() {} // 0x000000018885EC84-0x000000018885ECC0
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator() => default; // 0x000000018A2BCC48-0x000000018A2BCCAC
			public void Reset() {} // 0x000000018A2BCCB8-0x000000018A2BCD5C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A2BCD5C-0x000000018A2BCDC0
		}
	
		// Constructors
		protected JSONNode() {} // 0x000000018350B670-0x000000018350B680
		static JSONNode() {} // 0x0000000183CA8AC0-0x0000000183CA8B90
	
		// Methods
		public static implicit operator JSONNode(decimal aDecimal) => default; // 0x000000018A2BA6F0-0x000000018A2BA774
		public static implicit operator decimal(JSONNode aNode) => default; // 0x000000018A2BACB4-0x000000018A2BACE4
		public static implicit operator JSONNode(char aChar) => default; // 0x000000018A2BB3FC-0x000000018A2BB484
		public static implicit operator char(JSONNode aNode) => default; // 0x000000018A2BB3C4-0x000000018A2BB3E0
		public static implicit operator JSONNode(uint aUInt) => default; // 0x0000000183B33880-0x0000000183B338F0
		public static implicit operator uint(JSONNode aNode) => default; // 0x000000018A2BB324-0x000000018A2BB340
		public static implicit operator JSONNode(byte aByte) => default; // 0x000000018A2BAEB4-0x000000018A2BAF18
		public static implicit operator byte(JSONNode aNode) => default; // 0x000000018A2BA410-0x000000018A2BA42C
		public static implicit operator JSONNode(sbyte aSByte) => default; // 0x000000018A2BB654-0x000000018A2BB6B8
		public static implicit operator sbyte(JSONNode aNode) => default; // 0x000000018A2BA410-0x000000018A2BA42C
		public static implicit operator JSONNode(short aShort) => default; // 0x000000018A2BA3AC-0x000000018A2BA410
		public static implicit operator short(JSONNode aNode) => default; // 0x000000018A2BA410-0x000000018A2BA42C
		public static implicit operator JSONNode(ushort aUShort) => default; // 0x000000018A2BB208-0x000000018A2BB26C
		public static implicit operator ushort(JSONNode aNode) => default; // 0x000000018A2BA410-0x000000018A2BA42C
		public static implicit operator JSONNode(System.DateTime aDateTime) => default; // 0x000000018A2BA1BC-0x000000018A2BA26C
		public static implicit operator System.DateTime(JSONNode aNode) => default; // 0x000000018A2BAD4C-0x000000018A2BAD68
		public static implicit operator JSONNode(TimeSpan aTimeSpan) => default; // 0x000000018A2BA324-0x000000018A2BA3AC
		public static implicit operator TimeSpan(JSONNode aNode) => default; // 0x000000018A2BAC7C-0x000000018A2BAC98
		public static implicit operator JSONNode(Guid aGuid) => default; // 0x000000018A2BA150-0x000000018A2BA1BC
		public static implicit operator Guid(JSONNode aNode) => default; // 0x000000018A2BAE84-0x000000018A2BAEB4
		public static implicit operator JSONNode(byte[] aByteArray) => default; // 0x000000018A2BA684-0x000000018A2BA6F0
		public static implicit operator byte[](JSONNode aNode) => default; // 0x000000018A2BAE00-0x000000018A2BAE1C
		public static implicit operator JSONNode(List<byte> aByteList) => default; // 0x000000018A2BB19C-0x000000018A2BB208
		public static implicit operator List<byte>(JSONNode aNode) => default; // 0x000000018A2BA42C-0x000000018A2BA448
		public static implicit operator JSONNode(ulong[] aStringArray) => default; // 0x000000018A2BB4FC-0x000000018A2BB568
		public static implicit operator ulong[](JSONNode aNode) => default; // 0x000000018A2BAAC0-0x000000018A2BAADC
		public static implicit operator JSONNode(string[] aStringArray) => default; // 0x000000018A2BA508-0x000000018A2BA574
		public static implicit operator string[](JSONNode aNode) => default; // 0x000000018A2BAC98-0x000000018A2BACB4
		public static implicit operator JSONNode(List<string> aStringList) => default; // 0x000000018A2BAF80-0x000000018A2BAFEC
		public static implicit operator List<string>(JSONNode aNode) => default; // 0x000000018A2BB080-0x000000018A2BB09C
		public static implicit operator JSONNode(int? aValue) => default; // 0x0000000183B36560-0x0000000183B365F0
		public static implicit operator int?(JSONNode aNode) => default; // 0x000000018A2BAD68-0x000000018A2BAE00
		public static implicit operator JSONNode(float? aValue) => default; // 0x000000018A2BAA04-0x000000018A2BAAC0
		public static implicit operator float?(JSONNode aNode) => default; // 0x000000018A2BB104-0x000000018A2BB19C
		public static implicit operator JSONNode(double? aValue) => default; // 0x000000018A2BA954-0x000000018A2BAA04
		public static implicit operator double?(JSONNode aNode) => default; // 0x000000018A2BA820-0x000000018A2BA8D0
		public static implicit operator JSONNode(bool? aValue) => default; // 0x000000018A2BA068-0x000000018A2BA120
		public static implicit operator bool?(JSONNode aNode) => default; // 0x000000018A2BB26C-0x000000018A2BB308
		public static implicit operator JSONNode(long? aValue) => default; // 0x000000018A2BAB44-0x000000018A2BABF8
		public static implicit operator long?(JSONNode aNode) => default; // 0x000000018A2BA774-0x000000018A2BA820
		public static implicit operator JSONNode(short? aValue) => default; // 0x000000018A2BA26C-0x000000018A2BA324
		public static implicit operator short?(JSONNode aNode) => default; // 0x000000018A2BAFEC-0x000000018A2BB080
		private static JSONNode GetContainer(JSONContainerType aType) => default; // 0x000000018A2B722C-0x000000018A2B72B0
		public static implicit operator JSONNode(Vector2 aVec) => default; // 0x000000018A2BA574-0x000000018A2BA61C
		public static implicit operator JSONNode(Vector3 aVec) => default; // 0x000000018A2BB6B8-0x000000018A2BB784
		public static implicit operator JSONNode(Vector4 aVec) => default; // 0x000000018A2BB568-0x000000018A2BB5EC
		public static implicit operator JSONNode(UnityEngine.Color aCol) => default; // 0x000000018A2BABF8-0x000000018A2BAC7C
		public static implicit operator JSONNode(Color32 aCol) => default; // 0x000000018A2B9FC0-0x000000018A2BA038
		public static implicit operator JSONNode(Quaternion aRot) => default; // 0x000000018A2BA8D0-0x000000018A2BA954
		public static implicit operator JSONNode(Rect aRect) => default; // 0x000000018A2BB340-0x000000018A2BB3C4
		public static implicit operator JSONNode(RectOffset aRect) => default; // 0x000000018A2BB484-0x000000018A2BB4FC
		public static implicit operator Vector2(JSONNode aNode) => default; // 0x000000018A2BB3E0-0x000000018A2BB3FC
		public static implicit operator Vector3(JSONNode aNode) => default; // 0x000000018A2BA4D0-0x000000018A2BA508
		public static implicit operator Vector4(JSONNode aNode) => default; // 0x000000018A2BAF18-0x000000018A2BAF48
		public static implicit operator UnityEngine.Color(JSONNode aNode) => default; // 0x000000018A2B9F90-0x000000018A2B9FC0
		public static implicit operator Color32(JSONNode aNode) => default; // 0x000000018A2BA4B0-0x000000018A2BA4D0
		public static implicit operator Quaternion(JSONNode aNode) => default; // 0x000000018A2BA038-0x000000018A2BA068
		public static implicit operator Rect(JSONNode aNode) => default; // 0x000000018A2BA120-0x000000018A2BA150
		public static implicit operator RectOffset(JSONNode aNode) => default; // 0x000000018A2BB308-0x000000018A2BB324
		public Vector2 ReadVector2(Vector2 aDefault) => default; // 0x000000018A2B7F3C-0x000000018A2B8024
		public Vector2 ReadVector2(string aXName, string aYName) => default; // 0x000000018A2B7E9C-0x000000018A2B7F3C
		public Vector2 ReadVector2() => default; // 0x000000018A2B7E84-0x000000018A2B7E9C
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x01FDCF96 */, string aYName = "y" /* Metadata: 0x01FDCF98 */) => default; // 0x000000018A2B8F78-0x000000018A2B9070
		public Vector3 ReadVector3(Vector3 aDefault) => default; // 0x000000018A2B815C-0x000000018A2B82D8
		public Vector3 ReadVector3(string aXName, string aYName, string aZName) => default; // 0x000000018A2B8074-0x000000018A2B815C
		public Vector3 ReadVector3() => default; // 0x000000018A2B8024-0x000000018A2B8074
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x01FDCF9A */, string aYName = "y" /* Metadata: 0x01FDCF9C */, string aZName = "z" /* Metadata: 0x01FDCF9E */) => default; // 0x000000018A2B9070-0x000000018A2B91B0
		public Vector4 ReadVector4(Vector4 aDefault) => default; // 0x000000018A2B82D8-0x000000018A2B84B4
		public Vector4 ReadVector4() => default; // 0x000000018A2B84B4-0x000000018A2B84F0
		public JSONNode WriteVector4(Vector4 aVec) => default; // 0x000000018A2B91B0-0x000000018A2B937C
		public UnityEngine.Color ReadColor(UnityEngine.Color aDefault) => default; // 0x000000018A2B74C8-0x000000018A2B76FC
		public UnityEngine.Color ReadColor() => default; // 0x000000018A2B76FC-0x000000018A2B7738
		public JSONNode WriteColor(UnityEngine.Color aCol) => default; // 0x000000018A2B8748-0x000000018A2B8914
		public Color32 ReadColor32(Color32 aDefault) => default; // 0x000000018A2B72BC-0x000000018A2B74C8
		public Color32 ReadColor32() => default; // 0x000000018A2B72B0-0x000000018A2B72BC
		public JSONNode WriteColor32(Color32 aCol) => default; // 0x000000018A2B8580-0x000000018A2B8748
		public Quaternion ReadQuaternion(Quaternion aDefault) => default; // 0x000000018A2B77E0-0x000000018A2B79BC
		public Quaternion ReadQuaternion() => default; // 0x000000018A2B79BC-0x000000018A2B79F8
		public JSONNode WriteQuaternion(Quaternion aRot) => default; // 0x000000018A2B89A8-0x000000018A2B8B74
		public Rect ReadRect(Rect aDefault) => default; // 0x000000018A2B7C74-0x000000018A2B7E50
		public Rect ReadRect() => default; // 0x000000018A2B7E50-0x000000018A2B7E84
		public JSONNode WriteRect(Rect aRect) => default; // 0x000000018A2B8DAC-0x000000018A2B8F78
		public RectOffset ReadRectOffset(RectOffset aDefault) => default; // 0x000000018A2B7A60-0x000000018A2B7C74
		public RectOffset ReadRectOffset() => default; // 0x000000018A2B79F8-0x000000018A2B7A60
		public JSONNode WriteRectOffset(RectOffset aRect) => default; // 0x000000018A2B8B74-0x000000018A2B8DAC
		public Matrix4x4 ReadMatrix() => default; // 0x000000018A2B7738-0x000000018A2B77E0
		public JSONNode WriteMatrix(Matrix4x4 aMatrix) => default; // 0x000000018A2B8914-0x000000018A2B89A8
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x000000018350B670-0x000000018350B680
		public virtual void Add(JSONNode aItem) {} // 0x000000018299FA70-0x000000018299FAC0
		public virtual JSONNode Remove(string aKey) => default; // 0x0000000181002730-0x0000000181002740
		public virtual JSONNode Remove(int aIndex) => default; // 0x0000000181002730-0x0000000181002740
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x0000000183D51810-0x0000000183D51820
		public virtual void Clear() {} // 0x000000018350B670-0x000000018350B680
		public virtual JSONNode Clone() => default; // 0x0000000181002730-0x0000000181002740
		public virtual bool HasKey(string aKey) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) => default; // 0x0000000183D553C0-0x0000000183D553D0
		public override string ToString() => default; // 0x00000001837078B0-0x0000000183707940
		public virtual string ToString(int aIndent) => default; // 0x000000018A2B84F0-0x000000018A2B8580
		public virtual void ToStringBuild(ref StringBuilder sb) {} // 0x000000018267F1C0-0x000000018267F210
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s) => default; // 0x00000001829A38F0-0x00000001829A3990
		public static implicit operator string(JSONNode d) => default; // 0x000000018A2BA61C-0x000000018A2BA684
		public static implicit operator JSONNode(double n) => default; // 0x000000018268C840-0x000000018268C8B0
		public static implicit operator double(JSONNode d) => default; // 0x000000018A2BAADC-0x000000018A2BAB44
		public static implicit operator JSONNode(float n) => default; // 0x000000018299F790-0x000000018299F800
		public static implicit operator float(JSONNode d) => default; // 0x000000018A2BACE4-0x000000018A2BAD4C
		public static implicit operator JSONNode(int n) => default; // 0x000000018299F800-0x000000018299F870
		public static implicit operator int(JSONNode d) => default; // 0x000000018A2BAE1C-0x000000018A2BAE84
		public static implicit operator JSONNode(long n) => default; // 0x000000018299F6C0-0x000000018299F790
		public static implicit operator long(JSONNode d) => default; // 0x000000018A2BB09C-0x000000018A2BB104
		public static implicit operator JSONNode(ulong n) => default; // 0x0000000182BFEFD0-0x0000000182BFF0C0
		public static implicit operator ulong(JSONNode d) => default; // 0x000000018A2BA448-0x000000018A2BA4B0
		public static implicit operator JSONNode(bool b) => default; // 0x00000001829A6DA0-0x00000001829A6E10
		public static implicit operator bool(JSONNode d) => default; // 0x000000018A2BB5EC-0x000000018A2BB654
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue) => default; // 0x000000018A2BAF48-0x000000018A2BAF80
		public static bool operator ==(JSONNode a, object b) => default; // 0x00000001830467A0-0x0000000183046880
		public static bool operator !=(JSONNode a, object b) => default; // 0x0000000183046600-0x0000000183046660
		public override bool Equals(object obj) => default; // 0x00000001830465F0-0x0000000183046600
		public override int GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		internal static string Escape(string aText) => default; // 0x00000001825F3500-0x00000001825F3810
		private static JSONNode ParseElement(string token, bool quoted) => default; // 0x00000001829A3840-0x00000001829A38F0
		public static JSONNode Parse(string aJSON) => default; // 0x00000001829A3260-0x00000001829A3840
	}

	public enum JSONContainerType // TypeDefIndex: 59287
	{
		Array = 0,
		Object = 1
	}

	public enum JSONNodeType // TypeDefIndex: 59288
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

	public enum JSONTextMode // TypeDefIndex: 59289
	{
		Compact = 0,
		Indent = 1
	}

	public class JSONArray : JSONNode // TypeDefIndex: 59291
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public override JSONNodeType Tag { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override bool IsArray { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A2B614C-0x000000018A2B61EC 0x0000000183046420-0x0000000183046520
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018A2B60EC-0x000000018A2B614C 0x000000018A2B61EC-0x000000018A2B628C
		public override int Count { get => default; } // 0x000000018A2B60AC-0x000000018A2B60EC 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__24))] get => default; } // 0x000000018A2B603C-0x000000018A2B60AC 
	
		// Constructors
		public JSONArray() {} // 0x00000001829A5A60-0x00000001829A5B00
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018A2B5EB0-0x000000018A2B5F40
		public override void Add(string aKey, JSONNode aItem) {} // 0x0000000183046380-0x0000000183046420
		public override JSONNode Remove(int aIndex) => default; // 0x000000018A2B5F40-0x000000018A2B5FE4
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018A2B5FE4-0x000000018A2B603C
		public override void Clear() {} // 0x000000018A2B5C38-0x000000018A2B5C80
		public override JSONNode Clone() => default; // 0x000000018A2B5C80-0x000000018A2B5EB0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001825F6160-0x00000001825F62A0
	}

	public class JSONObject : JSONNode // TypeDefIndex: 59294
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public override JSONNodeType Tag { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override bool IsObject { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018A2BC998-0x000000018A2BCA58 0x0000000183046660-0x00000001830467A0
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A2BC90C-0x000000018A2BC998 0x000000018A2BCA58-0x000000018A2BCB5C
		public override int Count { get => default; } // 0x000000018A2BC8CC-0x000000018A2BC90C 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__27))] get => default; } // 0x000000018A2BC85C-0x000000018A2BC8CC 
	
		// Constructors
		public JSONObject() {} // 0x000000018299F420-0x000000018299F4C0
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183B10940-0x0000000183B109F0
		public override void Add(string aKey, JSONNode aItem) {} // 0x0000000183046260-0x0000000183046380
		public override JSONNode Remove(string aKey) => default; // 0x000000018A2BC538-0x000000018A2BC5F0
		public override JSONNode Remove(int aIndex) => default; // 0x000000018A2BC5F0-0x000000018A2BC6B0
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018A2BC6B0-0x000000018A2BC85C
		public override void Clear() {} // 0x000000018368EAF0-0x000000018368EB40
		public override JSONNode Clone() => default; // 0x000000018A2BC29C-0x000000018A2BC468
		public override bool HasKey(string aKey) => default; // 0x000000018A2BC4E4-0x000000018A2BC538
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) => default; // 0x000000018A2BC468-0x000000018A2BC4E4
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001825F52C0-0x00000001825F5600
	}

	public class JSONString : JSONNode // TypeDefIndex: 59295
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override bool IsString { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public JSONString() {} // Dummy constructor
		public JSONString(string aData) {} // 0x00000001829A3990-0x00000001829A39F0
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		public override JSONNode Clone() => default; // 0x000000018A2BCB9C-0x000000018A2BCC00
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001825EF9D0-0x00000001825EFA80
		public override bool Equals(object obj) => default; // 0x0000000183046520-0x00000001830465F0
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
		public override void Clear() {} // 0x000000018A2BCB5C-0x000000018A2BCB9C
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 59296
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public override bool IsNumber { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x00000001822FC830-0x00000001822FC890 0x000000018A2BC21C-0x000000018A2BC29C
		public override double AsDouble { get => default; set {} } // 0x0000000183D61CF0-0x0000000183D61D00 0x0000000183D4E410-0x0000000183D4E420
		public override long AsLong { get => default; set {} } // 0x0000000183D6D990-0x0000000183D6D9A0 0x0000000183D6D9A0-0x0000000183D6D9B0
		public override ulong AsULong { get => default; set {} } // 0x000000018A2BC210-0x000000018A2BC21C 0x0000000183D8A1F0-0x0000000183D8A220
	
		// Constructors
		public JSONNumber() {} // Dummy constructor
		public JSONNumber(double aData) {} // 0x000000018299F870-0x000000018299F8D0
		public JSONNumber(string aData) {} // 0x000000018A2BC1B4-0x000000018A2BC210
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		public override JSONNode Clone() => default; // 0x000000018A2BC004-0x000000018A2BC06C
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001825EF5D0-0x00000001825EF660
		private static bool IsNumeric(object value) => default; // 0x000000018A2BC06C-0x000000018A2BC1B4
		public override bool Equals(object obj) => default; // 0x000000018343A070-0x000000018343A0D0
		public override int GetHashCode() => default; // 0x000000018885DAE0-0x000000018885DAEC
		public override void Clear() {} // 0x0000000183D735B0-0x0000000183D735C0
	}

	public class JSONBool : JSONNode // TypeDefIndex: 59297
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D51110-0x0000000183D51120 
		public override bool IsBoolean { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x000000018A2B6394-0x000000018A2B63E0 0x000000018A2B63E0-0x000000018A2B6444
		public override bool AsBool { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public JSONBool() {} // Dummy constructor
		public JSONBool(bool aData) {} // 0x00000001829A6E10-0x00000001829A6E70
		public JSONBool(string aData) {} // 0x000000018A2B6338-0x000000018A2B6394
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		public override JSONNode Clone() => default; // 0x000000018A2B628C-0x000000018A2B62F0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018367B270-0x000000018367B2E0
		public override bool Equals(object obj) => default; // 0x000000018371BBB0-0x000000018371BC00
		public override int GetHashCode() => default; // 0x000000018A2B62F0-0x000000018A2B6338
		public override void Clear() {} // 0x0000000183D557C0-0x0000000183D557D0
	}

	public class JSONNull : JSONNode // TypeDefIndex: 59298
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D51100-0x0000000183D51110 
		public override bool IsNull { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x000000018A2BBFD8-0x000000018A2BC004 0x000000018350B670-0x000000018350B680
		public override bool AsBool { get => default; set {} } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
	
		// Constructors
		private JSONNull() {} // 0x0000000183CB7240-0x0000000183CB7280
		static JSONNull() {} // 0x0000000183CB71B0-0x0000000183CB7240
	
		// Methods
		public static JSONNull CreateOrGet() => default; // 0x0000000183046880-0x0000000183046900
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		public override JSONNode Clone() => default; // 0x000000018A2BBF40-0x000000018A2BBF80
		public override bool Equals(object obj) => default; // 0x000000018A2BBF80-0x000000018A2BBFD8
		public override int GetHashCode() => default; // 0x0000000181002730-0x0000000181002740
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001837904F0-0x0000000183790540
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 59299
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A2B6B74-0x000000018A2B6BD4 0x000000018A2B7198-0x000000018A2B722C
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018A2B6BD4-0x000000018A2B6C44 0x000000018A2B70F0-0x000000018A2B7198
		public override int AsInt { get => default; set {} } // 0x000000018A2B6888-0x000000018A2B6904 0x000000018A2B6DE0-0x000000018A2B6E6C
		public override float AsFloat { get => default; set {} } // 0x000000018A2B6808-0x000000018A2B6888 0x000000018A2B6D54-0x000000018A2B6DE0
		public override double AsDouble { get => default; set {} } // 0x000000018A2B6788-0x000000018A2B6808 0x000000018A2B6CCC-0x000000018A2B6D54
		public override long AsLong { get => default; set {} } // 0x000000018A2B6904-0x000000018A2B6A00 0x000000018A2B6E6C-0x000000018A2B6FA0
		public override ulong AsULong { get => default; set {} } // 0x000000018A2B6A78-0x000000018A2B6B74 0x000000018A2B6FA0-0x000000018A2B70F0
		public override bool AsBool { get => default; set {} } // 0x000000018A2B670C-0x000000018A2B6788 0x000000018A2B6C44-0x000000018A2B6CCC
		public override JSONArray AsArray { get => default; } // 0x000000018A2B6694-0x000000018A2B670C 
		public override JSONObject AsObject { get => default; } // 0x000000018A2B6A00-0x000000018A2B6A78 
	
		// Constructors
		public JSONLazyCreator() {} // Dummy constructor
		public JSONLazyCreator(JSONNode aNode) {} // 0x000000018A2B65C8-0x000000018A2B6628
		public JSONLazyCreator(JSONNode aNode, string aKey) {} // 0x000000018A2B6628-0x000000018A2B6694
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		private T Set<T>(T aVal)
			where T : JSONNode => default;
		public override void Add(JSONNode aItem) {} // 0x000000018A2B6444-0x000000018A2B64D8
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018A2B64D8-0x000000018A2B6580
		public static bool operator ==(JSONLazyCreator a, object b) => default; // 0x000000018885CFA4-0x000000018885CFB4
		public static bool operator !=(JSONLazyCreator a, object b) => default; // 0x000000018885D444-0x000000018885D454
		public override bool Equals(object obj) => default; // 0x000000018885CFA4-0x000000018885CFB4
		public override int GetHashCode() => default; // 0x0000000181002730-0x0000000181002740
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A2B6580-0x000000018A2B65C8
	}

	public static class JSON // TypeDefIndex: 59300
	{
		// Methods
		public static JSONNode Parse(string aJSON) => default; // 0x0000000183D2C120-0x0000000183D2C170
	}
}
