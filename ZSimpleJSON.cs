/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Image 89: ZSimpleJSON.dll - Assembly: ZSimpleJSON, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60334-60356

namespace ZSimpleJSON
{
	public abstract class JSONNode // TypeDefIndex: 60342
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
		private static StringBuilder m_EscapeBuilder; // 0x80000000
	
		// Properties
		public virtual decimal AsDecimal { get; set; } // 0x000000018C3D2EE8-0x000000018C3D2F04 0x000000018C3D1610-0x000000018C3D1710
		public virtual char AsChar { get; set; } // 0x000000018C3D2514-0x000000018C3D2530 0x000000018C3D1D9C-0x000000018C3D1E74
		public virtual uint AsUInt { get; set; } // 0x000000018C3D2BA8-0x000000018C3D2BC4 0x000000018C3D1A7C-0x000000018C3D1B50
		public virtual byte AsByte { get; set; } // 0x000000018C3D2D80-0x000000018C3D2D9C 0x000000018C3D1B50-0x000000018C3D1C54
		public virtual sbyte AsSByte { get; set; } // 0x000000018C3D3168-0x000000018C3D3184 0x0000000185D68360-0x0000000185D683F0
		public virtual short AsShort { get; set; } // 0x000000018C3D31EC-0x000000018C3D3284 0x000000018C3D2A3C-0x000000018C3D2AEC
		public virtual ushort AsUShort { get; set; } // 0x000000018C3D3354-0x000000018C3D33F0 0x000000018C3D2C2C-0x000000018C3D2CE0
		public virtual System.DateTime AsDateTime { get; set; } // 0x000000018C3D30D4-0x000000018C3D3168 0x000000018C3CF314-0x000000018C3CF398
		public virtual TimeSpan AsTimeSpan { get; set; } // 0x000000018C3D3650-0x000000018C3D36D4 0x000000018C3D2CE0-0x000000018C3D2D64
		public virtual Guid AsGuid { get; set; } // 0x000000018C3D3428-0x000000018C3D34AC 0x000000018C3D356C-0x000000018C3D35E4
		public virtual byte[] AsByteArray { get; set; } // 0x000000018C3D3000-0x000000018C3D3030 0x000000018C3D2078-0x000000018C3D20A8
		public virtual List<byte> AsByteList { get; set; } // 0x000000018C3D2208-0x000000018C3D2238 0x000000018C3D33F0-0x000000018C3D340C
		public virtual ulong[] AsUlongArray { get; set; } // 0x000000018C3CFF6C-0x000000018C3CFF84 0x000000018C3D1060-0x000000018C3D1158
		public virtual string[] AsStringArray { get; set; } // 0x000000018C3D010C-0x000000018C3D015C 0x000000018C3D1158-0x000000018C3D1298
		public virtual List<string> AsStringList { get; set; } // 0x000000018C3D1298-0x000000018C3D1464 0x000000018C3CF5B0-0x000000018C3CF7E4
		public abstract JSONNodeType Tag { get; } // 0x000000018C3D19C4-0x000000018C3D1A40 
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C3D3C90-0x000000018C3D3CF4 0x000000018C3D1D20-0x000000018C3D1D9C
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x000000018C3D3F04-0x000000018C3D3F68 0x000000018C3D1464-0x000000018C3D14A0
		public virtual string Value { get; set; } // 0x000000018C3D1A40-0x000000018C3D1A7C 0x0000000184DA7680-0x0000000184DA7720
		public virtual int Count { get; } // 0x000000018C3D2704-0x000000018C3D276C 
		public virtual bool IsNumber { get; } // 0x0000000184DA63C0-0x0000000184DA6430 
		public virtual bool IsString { get; } // 0x000000018C3D2BC4-0x000000018C3D2C2C 
		public virtual bool IsBoolean { get; } // 0x0000000184DA6EB0-0x0000000184DA6F20 
		public virtual bool IsNull { get; } // 0x000000018C3D2DCC-0x000000018C3D2E34 
		public virtual bool IsArray { get; } // 0x0000000184DA6F20-0x0000000184DA6F90 
		public virtual bool IsObject { get; } // 0x000000018C3D2F04-0x000000018C3D2F6C 
		public virtual bool Inline { get; set; } // 0x0000000184DA6DE0-0x0000000184DA6EB0 0x000000018C3D3184-0x000000018C3D31EC
		public virtual IEnumerable<JSONNode> Children { get; } // 0x0000000184ED0D90-0x0000000184ED0DA0 
		public IEnumerable<JSONNode> DeepChildren { get; } // 0x0000000185FB0F10-0x0000000185FB0F20 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x000000018A967278-0x000000018A9672AC 
		public KeyEnumerator Keys { get; } // 0x0000000184C6C480-0x0000000184C6C4D0 
		public ValueEnumerator Values { get; } // 0x0000000184C6E430-0x0000000184C6E4A0 
		public virtual double AsDouble { get; set; } // 0x0000000184C6E3D0-0x0000000184C6E430 0x000000018A9716B8-0x000000018A971750
		public virtual int AsInt { get; set; } // 0x000000018A9715E4-0x000000018A971684 0x000000018A971684-0x000000018A9716B8
		public virtual float AsFloat { get; set; } // 0x000000018C3D5F4C-0x000000018C3D5F8C 0x000000018C3D4CE8-0x000000018C3D4CF0
		public virtual bool AsBool { get; set; } // 0x0000000185FCE5F0-0x0000000185FCE620 0x000000018A9716B8-0x000000018A971750
		public virtual long AsLong { get; set; } // 0x000000018A9715E4-0x000000018A971684 0x000000018A971684-0x000000018A9716B8
		public virtual ulong AsULong { get; set; } // 0x000000018C3D4CF0-0x000000018C3D4D30 0x000000018C3D4CE8-0x000000018C3D4CF0
		public virtual JSONArray AsArray { get; } // 0x0000000185FCE5F0-0x0000000185FCE620 
		public virtual JSONObject AsObject { get; } // 0x000000018C3D4F00-0x000000018C3D4FB4 
		internal static StringBuilder EscapeBuilder { get; } // 0x000000018C3D5F00-0x000000018C3D5F4C 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 60336
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get => default; } // 0x000000018C3D185C-0x000000018C3D18D0 
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x000000018C3D2D9C-0x000000018C3D2DCC 
	
			// Nested types
			private enum Type // TypeDefIndex: 60335
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
			} // 0x000000018C3D3B78-0x000000018C3D3BD4
			public Enumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x000000018C3D27D8-0x000000018C3D285C
	
			// Methods
			public bool MoveNext() => default; // 0x000000018C3D1720-0x000000018C3D17A8
		}
	
		public struct ValueEnumerator // TypeDefIndex: 60337
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get => default; } // 0x000000018C3D1D04-0x000000018C3D1D20 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018C3D3A58-0x000000018C3D3AF0
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018C3D34E4-0x000000018C3D356C
			public ValueEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018C3D34AC-0x000000018C3D34C8
	
			// Methods
			public bool MoveNext() => default; // 0x000000018C3D3EE8-0x000000018C3D3F04
			public ValueEnumerator GetEnumerator() => default; // 0x0000000185D655B0-0x0000000185D65620
		}
	
		public struct KeyEnumerator // TypeDefIndex: 60338
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get => default; } // 0x000000018C3D2F9C-0x000000018C3D3000 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018C3D340C-0x000000018C3D3428
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018C3D1710-0x000000018C3D1720
			public KeyEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018C3D3A44-0x000000018C3D3A58
	
			// Methods
			public bool MoveNext() => default; // 0x000000018C3D24F8-0x000000018C3D2514
			public KeyEnumerator GetEnumerator() => default; // 0x000000018C3D1710-0x000000018C3D1720
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 60339
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x000000018C3D373C-0x000000018C3D37A0 
			object IEnumerator.Current { get => default; } // 0x000000018C3D24F8-0x000000018C3D2514 
	
			// Constructors
			public LinqEnumerator() {} // Dummy constructor
			internal LinqEnumerator(JSONNode aNode) {} // 0x000000018C3D3CF4-0x000000018C3D3D08
	
			// Methods
			public bool MoveNext() => default; // 0x000000018C3D1710-0x000000018C3D1720
			public void Dispose() {} // 0x000000018C3D3D08-0x000000018C3D3D1C
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator() => default; // 0x000000018C3D2494-0x000000018C3D24F8
			public void Reset() {} // 0x000000018C3D24F8-0x000000018C3D2514
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C3D1710-0x000000018C3D1720
		}
	
		private sealed class _get_Children_d__181 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 60340
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { get => default; } // 0x000000018C3D17A8-0x000000018C3D185C 
			object IEnumerator.Current { get => default; } // 0x000000018C3D22A4-0x000000018C3D2354 
	
			// Constructors
			public _get_Children_d__181() {} // Dummy constructor
			public _get_Children_d__181(int __1__state) {} // 0x000000018C3D3F68-0x000000018C3D3F7C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C3D32F0-0x000000018C3D3354
			private bool MoveNext() => default; // 0x000000018C3D24F8-0x000000018C3D2514
			void IEnumerator.Reset() {} // 0x000000018C3D3AF0-0x000000018C3D3B78
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018C3D2E34-0x000000018C3D2E50
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C3D1C54-0x000000018C3D1D04
		}
	
		private sealed class _get_DeepChildren_d__183 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 60341
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONNode __4__this; // 0x28
			private IEnumerator<JSONNode> __7__wrap1; // 0x30
			private IEnumerator<JSONNode> __7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { get => default; } // 0x000000018C3D2238-0x000000018C3D22A4 
			object IEnumerator.Current { get => default; } // 0x000000018C3D153C-0x000000018C3D1610 
	
			// Constructors
			public _get_DeepChildren_d__183() {} // Dummy constructor
			public _get_DeepChildren_d__183(int __1__state) {} // 0x000000018C3D3E90-0x000000018C3D3EE8
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C3D240C-0x000000018C3D2494
			private bool MoveNext() => default; // 0x000000018C3D2D64-0x000000018C3D2D80
			private void __m__Finally1() {} // 0x000000018C3D1978-0x000000018C3D19A8
			private void __m__Finally2() {} // 0x000000018C3D3C4C-0x000000018C3D3C78
			void IEnumerator.Reset() {} // 0x000000018C3D2F6C-0x000000018C3D2F9C
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018C3D38D8-0x000000018C3D3980
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C3D276C-0x000000018C3D27D8
		}
	
		// Constructors
		protected JSONNode() {} // 0x000000018C3D5CEC-0x000000018C3D5D78
		static JSONNode() {} // 0x000000018C3D5D78-0x000000018C3D5D80
	
		// Methods
		public static implicit operator JSONNode(decimal aDecimal) => default; // 0x000000018C3D3980-0x000000018C3D3A44
		public static implicit operator decimal(JSONNode aNode) => default; // 0x000000018C3D3284-0x000000018C3D32F0
		public static implicit operator JSONNode(char aChar) => default; // 0x000000018C3D3F7C-0x000000018C3D4028
		public static implicit operator char(JSONNode aNode) => default; // 0x000000018C3D35E4-0x000000018C3D3650
		public static implicit operator JSONNode(uint aUInt) => default; // 0x000000018C3D3D1C-0x000000018C3D3DC8
		public static implicit operator uint(JSONNode aNode) => default; // 0x000000018C3D25F0-0x000000018C3D265C
		public static implicit operator JSONNode(byte aByte) => default; // 0x000000018C3D3DC8-0x000000018C3D3E90
		public static implicit operator byte(JSONNode aNode) => default; // 0x000000018C3D3068-0x000000018C3D30D4
		public static implicit operator JSONNode(sbyte aSByte) => default; // 0x000000018C3D2E50-0x000000018C3D2EE8
		public static implicit operator sbyte(JSONNode aNode) => default; // 0x000000018C3D2AEC-0x000000018C3D2BA8
		public static implicit operator JSONNode(short aShort) => default; // 0x000000018C3D2908-0x000000018C3D29B8
		public static implicit operator short(JSONNode aNode) => default; // 0x000000018C3D2150-0x000000018C3D2208
		public static implicit operator JSONNode(ushort aUShort) => default; // 0x000000018C3D285C-0x000000018C3D2908
		public static implicit operator ushort(JSONNode aNode) => default; // 0x000000018C3D2354-0x000000018C3D240C
		public static implicit operator JSONNode(System.DateTime aDateTime) => default; // 0x000000018C3D265C-0x000000018C3D2704
		public static implicit operator System.DateTime(JSONNode aNode) => default; // 0x000000018C3D37A0-0x000000018C3D386C
		public static implicit operator JSONNode(TimeSpan aTimeSpan) => default; // 0x000000018C3D20A8-0x000000018C3D2120
		public static implicit operator TimeSpan(JSONNode aNode) => default; // 0x000000018C3D29B8-0x000000018C3D2A3C
		public static implicit operator JSONNode(Guid aGuid) => default; // 0x000000018C3D34C8-0x000000018C3D34E4
		public static implicit operator Guid(JSONNode aNode) => default; // 0x000000018C3D25B8-0x000000018C3D25F0
		public static implicit operator JSONNode(byte[] aByteArray) => default; // 0x000000018C3D2598-0x000000018C3D25B8
		public static implicit operator byte[](JSONNode aNode) => default; // 0x000000018C3D2120-0x000000018C3D2150
		public static implicit operator JSONNode(List<byte> aByteList) => default; // 0x000000018C3D0024-0x000000018C3D010C
		public static implicit operator List<byte>(JSONNode aNode) => default; // 0x000000018C3CFF84-0x000000018C3D0024
		public static implicit operator JSONNode(ulong[] aStringArray) => default; // 0x000000018C3D0244-0x000000018C3D03C0
		public static implicit operator ulong[](JSONNode aNode) => default; // 0x000000018C3D015C-0x000000018C3D0244
		public static implicit operator JSONNode(string[] aStringArray) => default; // 0x000000018C3D03C0-0x000000018C3D059C
		public static implicit operator string[](JSONNode aNode) => default; // 0x000000018C3D059C-0x000000018C3D05D8
		public static implicit operator JSONNode(List<string> aStringList) => default; // 0x000000018C3CF7E4-0x000000018C3CF820
		public static implicit operator List<string>(JSONNode aNode) => default; // 0x000000018C3D0830-0x000000018C3D09FC
		public static implicit operator JSONNode(int? aValue) => default; // 0x000000018C3CF3A4-0x000000018C3CF5B0
		public static implicit operator int?(JSONNode aNode) => default; // 0x000000018C3CF398-0x000000018C3CF3A4
		public static implicit operator JSONNode(float? aValue) => default; // 0x000000018C3D0668-0x000000018C3D0830
		public static implicit operator float?(JSONNode aNode) => default; // 0x000000018C3CF8C8-0x000000018C3CFAA4
		public static implicit operator JSONNode(double? aValue) => default; // 0x000000018C3CFAA4-0x000000018C3CFAE0
		public static implicit operator double?(JSONNode aNode) => default; // 0x000000018C3D0A90-0x000000018C3D0C5C
		public static implicit operator JSONNode(bool? aValue) => default; // 0x000000018C3CFD5C-0x000000018C3CFF38
		public static implicit operator bool?(JSONNode aNode) => default; // 0x000000018C3CFF38-0x000000018C3CFF6C
		public static implicit operator JSONNode(long? aValue) => default; // 0x000000018C3D0E94-0x000000018C3D1060
		public static implicit operator long?(JSONNode aNode) => default; // 0x000000018C3CFB48-0x000000018C3CFD5C
		public static implicit operator JSONNode(short? aValue) => default; // 0x000000018C3CFAE0-0x000000018C3CFB48
		public static implicit operator short?(JSONNode aNode) => default; // 0x000000018C3D0C5C-0x000000018C3D0E94
		private static JSONNode GetContainer(JSONContainerType aType) => default; // 0x000000018C3CF820-0x000000018C3CF8C8
		public static implicit operator JSONNode(Vector2 aVec) => default; // 0x000000018C3D09FC-0x000000018C3D0A90
		public static implicit operator JSONNode(Vector3 aVec) => default;
		public static implicit operator JSONNode(Vector4 aVec) => default; // 0x00000001813AE580-0x00000001813AE590
		public static implicit operator JSONNode(UnityEngine.Color aCol) => default; // 0x0000000185492010-0x0000000185492020
		public static implicit operator JSONNode(Color32 aCol) => default; // 0x00000001813AE580-0x00000001813AE590
		public static implicit operator JSONNode(Quaternion aRot) => default; // 0x0000000185492010-0x0000000185492020
		public static implicit operator JSONNode(Rect aRect) => default; // 0x000000018C3D204C-0x000000018C3D2078
		public static implicit operator JSONNode(RectOffset aRect) => default; // 0x0000000185492010-0x0000000185492020
		public static implicit operator Vector2(JSONNode aNode) => default; // 0x00000001813AE580-0x00000001813AE590
		public static implicit operator Vector3(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static implicit operator Vector4(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static implicit operator UnityEngine.Color(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static implicit operator Color32(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static implicit operator Quaternion(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static implicit operator Rect(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static implicit operator RectOffset(JSONNode aNode) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public Vector2 ReadVector2(Vector2 aDefault) => default; // 0x0000000185492010-0x0000000185492020
		public Vector2 ReadVector2(string aXName, string aYName) => default; // 0x0000000185492010-0x0000000185492020
		public Vector2 ReadVector2() => default; // 0x0000000184DA7780-0x0000000184DA77D0
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x02082885 */, string aYName = "y" /* Metadata: 0x02082887 */) => default; // 0x00000001813AE580-0x00000001813AE590
		public Vector3 ReadVector3(Vector3 aDefault) => default; // 0x00000001813AE580-0x00000001813AE590
		public Vector3 ReadVector3(string aXName, string aYName, string aZName) => default; // 0x00000001834A4750-0x00000001834A4760
		public Vector3 ReadVector3() => default; // 0x0000000185492010-0x0000000185492020
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x02082889 */, string aYName = "y" /* Metadata: 0x0208288B */, string aZName = "z" /* Metadata: 0x0208288D */) => default; // 0x00000001813AE580-0x00000001813AE590
		public Vector4 ReadVector4(Vector4 aDefault) => default; // 0x000000018C3D1E74-0x000000018C3D1EC8
		public Vector4 ReadVector4() => default; // 0x000000018C3D1EC8-0x000000018C3D1F38
		public JSONNode WriteVector4(Vector4 aVec) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public UnityEngine.Color ReadColor(UnityEngine.Color aDefault) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
		public UnityEngine.Color ReadColor() => default; // 0x0000000185804000-0x0000000185804090
		public JSONNode WriteColor(UnityEngine.Color aCol) => default; // 0x000000018C3D05D8-0x000000018C3D0668
		public Color32 ReadColor32(Color32 aDefault) => default; // 0x00000001848B79A0-0x00000001848B79F0
		public Color32 ReadColor32() => default;
		public JSONNode WriteColor32(Color32 aCol) => default;
		public Quaternion ReadQuaternion(Quaternion aDefault) => default; // 0x000000018C3D1FEC-0x000000018C3D204C
		public Quaternion ReadQuaternion() => default; // 0x000000018C3D1F38-0x000000018C3D1FEC
		public JSONNode WriteQuaternion(Quaternion aRot) => default; // 0x000000018C3D1F38-0x000000018C3D1FEC
		public Rect ReadRect(Rect aDefault) => default; // 0x000000018C3D18D0-0x000000018C3D195C
		public Rect ReadRect() => default; // 0x000000018C3D3BD4-0x000000018C3D3C38
		public JSONNode WriteRect(Rect aRect) => default; // 0x000000018C3D19A8-0x000000018C3D19C4
		public RectOffset ReadRectOffset(RectOffset aDefault) => default; // 0x000000018C3D3C78-0x000000018C3D3C90
		public RectOffset ReadRectOffset() => default; // 0x000000018C3D195C-0x000000018C3D1978
		public JSONNode WriteRectOffset(RectOffset aRect) => default; // 0x000000018C3D3C38-0x000000018C3D3C4C
		public Matrix4x4 ReadMatrix() => default; // 0x000000018C3D14A0-0x000000018C3D153C
		public JSONNode WriteMatrix(Matrix4x4 aMatrix) => default; // 0x000000018C3D386C-0x000000018C3D38D8
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x0000000184BA69B0-0x0000000184BA6AA0
		public virtual void Add(JSONNode aItem) {} // 0x000000018C3D2530-0x000000018C3D2598
		public virtual JSONNode Remove(string aKey) => default; // 0x0000000184771810-0x0000000184771880
		public virtual JSONNode Remove(int aIndex) => default; // 0x000000018C3D36D4-0x000000018C3D373C
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x000000018C3D3030-0x000000018C3D3068
		public virtual void Clear() {} // 0x0000000184ED0F40-0x0000000184ED1020
		public virtual JSONNode Clone() => default; // 0x0000000184ED0DA0-0x0000000184ED0E00
		public virtual bool HasKey(string aKey) => default; // 0x00000001841C8430-0x00000001841C8550
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) => default; // 0x00000001841C7F50-0x00000001841C8260
		public override string ToString() => default; // 0x0000000184DA75D0-0x0000000184DA7680
		public virtual string ToString(int aIndent) => default; // 0x0000000184DA6FF0-0x0000000184DA75D0
		public virtual void ToStringBuild(ref StringBuilder sb) {} // 0x0000000185492010-0x0000000185492020
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000185EF9BC0-0x0000000185EF9C90
		public abstract Enumerator GetEnumerator(); // 0x000000018646D60C-0x000000018646D614
		public static implicit operator JSONNode(string s) => default; // 0x000000018C3D4FB4-0x000000018C3D4FE0
		public static implicit operator string(JSONNode d) => default; // 0x000000018C3D4EA8-0x000000018C3D4F00
		public static implicit operator JSONNode(double n) => default; // 0x000000018C3D4D94-0x000000018C3D4DA0
		public static implicit operator double(JSONNode d) => default; // 0x000000018A971790-0x000000018A9717CC
		public static implicit operator JSONNode(float n) => default; // 0x000000018C3D4D30-0x000000018C3D4D94
		public static implicit operator float(JSONNode d) => default; // 0x000000018C3D4DA0-0x000000018C3D4E44
		public static implicit operator JSONNode(int n) => default; // 0x000000018C3D4E44-0x000000018C3D4EA8
		public static implicit operator int(JSONNode d) => default; // 0x0000000184775050-0x0000000184775070
		public static implicit operator JSONNode(long n) => default; // 0x0000000185492010-0x0000000185492020
		public static implicit operator long(JSONNode d) => default; // 0x0000000185FADBE0-0x0000000185FADBF0
		public static implicit operator JSONNode(ulong n) => default; // 0x0000000181377E40-0x0000000181377E50
		public static implicit operator ulong(JSONNode d) => default; // 0x000000018C3D50C4-0x000000018C3D5110
		public static implicit operator JSONNode(bool b) => default; // 0x0000000181377E40-0x0000000181377E50
		public static implicit operator bool(JSONNode d) => default; // 0x000000018C3D5044-0x000000018C3D50BC
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue) => default; // 0x000000018C3D50BC-0x000000018C3D50C4
		public static bool operator ==(JSONNode a, object b) => default; // 0x0000000184775050-0x0000000184775070
		public static bool operator !=(JSONNode a, object b) => default; // 0x000000018C3D5DCC-0x000000018C3D5EB8
		public override bool Equals(object obj) => default; // 0x000000018C3D58F4-0x000000018C3D5CEC
		public override int GetHashCode() => default; // 0x000000018C3D5EB8-0x000000018C3D5F00
		internal static string Escape(string aText) => default; // 0x0000000181377E40-0x0000000181377E50
		private static JSONNode ParseElement(string token, bool quoted) => default; // 0x000000018C3D5D80-0x000000018C3D5DCC
		public static JSONNode Parse(string aJSON) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public enum JSONContainerType // TypeDefIndex: 60343
	{
		Array = 0,
		Object = 1
	}

	public enum JSONNodeType // TypeDefIndex: 60344
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

	public enum JSONTextMode // TypeDefIndex: 60345
	{
		Compact = 0,
		Indent = 1
	}

	public class JSONArray : JSONNode // TypeDefIndex: 60347
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x000000018C3CE194-0x000000018C3CE1D4 0x0000000184ED0B20-0x0000000184ED0BC0
		public override JSONNodeType Tag { get => default; } // 0x000000018C3CE028-0x000000018C3CE0CC 
		public override bool IsArray { get => default; } // 0x000000018C3CE0CC-0x000000018C3CE124 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C3CDD68-0x000000018C3CDF98 0x000000018C3CE124-0x000000018C3CE194
		public override JSONNode this[string aKey] { get => default; set {} } // 0x00000001841CABF0-0x00000001841CAD30 0x0000000184DA4F60-0x0000000184DA5000
		public override int Count { get => default; } // 0x0000000184775050-0x0000000184775070 
		public override IEnumerable<JSONNode> Children { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class _get_Children_d__24 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 60346
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONArray __4__this; // 0x28
			private List<JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { get => default; } // 0x000000018C3CDF98-0x000000018C3CE028 
			object IEnumerator.Current { get => default; } // 0x0000000184ED0BC0-0x0000000184ED0CC0 
	
			// Constructors
			public _get_Children_d__24() {} // Dummy constructor
			public _get_Children_d__24(int __1__state) {} // 0x00000001813C0430-0x00000001813C0440
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001813C0520-0x00000001813C0530
			private bool MoveNext() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
			private void __m__Finally1() {} // 0x00000001840A27C0-0x00000001840A27D0
			void IEnumerator.Reset() {} // 0x000000018C3CE234-0x000000018C3CE2D4
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018C3CE1D4-0x000000018C3CE234
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C3CE2D4-0x000000018C3CE374
		}
	
		// Constructors
		public JSONArray() {} // 0x000000018C3D53E4-0x000000018C3D53EC
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018C3CDD20-0x000000018C3CDD68
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018C3D5438-0x000000018C3D54B0
		public override JSONNode Remove(int aIndex) => default; // 0x000000018C3D5110-0x000000018C3D5358
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018C3D54B0-0x000000018C3D54EC
		public override void Clear() {} // 0x0000000181377E40-0x0000000181377E50
		public override JSONNode Clone() => default; // 0x000000018C3D53EC-0x000000018C3D5438
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018C3D5358-0x000000018C3D53E4
	}

	public class JSONObject : JSONNode // TypeDefIndex: 60350
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x000000018C3D4620-0x000000018C3D46D8 0x000000018C3D46D8-0x000000018C3D4798
		public override JSONNodeType Tag { get => default; } // 0x000000018C3D4798-0x000000018C3D4944 
		public override bool IsObject { get => default; } // 0x00000001857699F0-0x0000000185769A40 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018C3D45CC-0x000000018C3D4620 0x000000018C3D4550-0x000000018C3D45CC
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C3D4944-0x000000018C3D49B4 0x00000001841C9D10-0x00000001841CA050
		public override int Count { get => default; } // 0x0000000184DA69A0-0x0000000184DA6A40 
		public override IEnumerable<JSONNode> Children { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 60348
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x00000001813C0430-0x00000001813C0440
	
			// Methods
			internal bool _Remove_b__0(KeyValuePair<string, JSONNode> k) => default; // 0x00000001813C0520-0x00000001813C0530
		}
	
		private sealed class _get_Children_d__27 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 60349
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONObject __4__this; // 0x28
			private Dictionary<string, JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { get => default; } // 0x0000000184ED0E00-0x0000000184ED0F40 
			object IEnumerator.Current { get => default; } // 0x000000018C3D4B40-0x000000018C3D4C44 
	
			// Constructors
			public _get_Children_d__27() {} // Dummy constructor
			public _get_Children_d__27(int __1__state) {} // 0x0000000181C6A970-0x0000000181C6A980
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001840A27C0-0x00000001840A27D0
			private bool MoveNext() => default; // 0x0000000184C6C980-0x0000000184C6CA90
			private void __m__Finally1() {} // 0x000000018C3D4A80-0x000000018C3D4B40
			void IEnumerator.Reset() {} // 0x000000018C3D49F4-0x000000018C3D4A80
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018C3D49B4-0x000000018C3D49F4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184ED0A00-0x0000000184ED0B20
		}
	
		// Constructors
		public JSONObject() {} // 0x000000018C3D57EC-0x000000018C3D57F4
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018C3D4384-0x000000018C3D4550
		public override void Add(string aKey, JSONNode aItem) {} // 0x0000000185492010-0x0000000185492020
		public override JSONNode Remove(string aKey) => default; // 0x000000018C3D4FE0-0x000000018C3D5044
		public override JSONNode Remove(int aIndex) => default; // 0x0000000184775050-0x0000000184775070
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018C3D5840-0x000000018C3D58B8
		public override void Clear() {} // 0x000000018C3D54EC-0x000000018C3D5760
		public override JSONNode Clone() => default; // 0x000000018C3D58B8-0x000000018C3D58F4
		public override bool HasKey(string aKey) => default; // 0x0000000181377E40-0x0000000181377E50
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) => default; // 0x000000018C3D57F4-0x000000018C3D5840
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018C3D5760-0x000000018C3D57EC
	}

	public class JSONString : JSONNode // TypeDefIndex: 60351
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
		public override bool IsString { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public JSONString() {} // Dummy constructor
		public JSONString(string aData) {} // 0x0000000184DA7720-0x0000000184DA7780
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		public override JSONNode Clone() => default; // 0x000000018C3D4C84-0x000000018C3D4CE8
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001841C4420-0x00000001841C44D0
		public override bool Equals(object obj) => default; // 0x0000000184ED0CC0-0x0000000184ED0D90
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
		public override void Clear() {} // 0x000000018C3D4C44-0x000000018C3D4C84
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 60352
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
		public override bool IsNumber { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x0000000184007380-0x00000001840073E0 0x000000018C3D4304-0x000000018C3D4384
		public override double AsDouble { get => default; set {} } // 0x0000000185FC3350-0x0000000185FC3360 0x0000000185FAFF60-0x0000000185FAFF70
		public override long AsLong { get => default; set {} } // 0x0000000185FCE5D0-0x0000000185FCE5E0 0x0000000185FCE5E0-0x0000000185FCE5F0
		public override ulong AsULong { get => default; set {} } // 0x000000018C3D42F8-0x000000018C3D4304 0x0000000185FEB030-0x0000000185FEB060
	
		// Constructors
		public JSONNumber() {} // Dummy constructor
		public JSONNumber(double aData) {} // 0x0000000184DA6F90-0x0000000184DA6FF0
		public JSONNumber(string aData) {} // 0x000000018C3D429C-0x000000018C3D42F8
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		public override JSONNode Clone() => default; // 0x000000018C3D40EC-0x000000018C3D4154
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001841C4020-0x00000001841C40B0
		private static bool IsNumeric(object value) => default; // 0x000000018C3D4154-0x000000018C3D429C
		public override bool Equals(object obj) => default; // 0x000000018541AD80-0x000000018541ADE0
		public override int GetHashCode() => default; // 0x000000018A9705EC-0x000000018A9705F8
		public override void Clear() {} // 0x0000000185FD4210-0x0000000185FD4220
	}

	public class JSONBool : JSONNode // TypeDefIndex: 60353
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181D409B0-0x0000000181D40CF0 
		public override bool IsBoolean { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018C3CE47C-0x000000018C3CE4C8 0x000000018C3CE4C8-0x000000018C3CE52C
		public override bool AsBool { get => default; set {} } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public JSONBool() {} // Dummy constructor
		public JSONBool(bool aData) {} // 0x0000000184771880-0x00000001847718E0
		public JSONBool(string aData) {} // 0x000000018C3CE420-0x000000018C3CE47C
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		public override JSONNode Clone() => default; // 0x000000018C3CE374-0x000000018C3CE3D8
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018574E460-0x000000018574E4D0
		public override bool Equals(object obj) => default; // 0x000000018581BDC0-0x000000018581BE10
		public override int GetHashCode() => default; // 0x000000018C3CE3D8-0x000000018C3CE420
		public override void Clear() {} // 0x0000000185FB6A70-0x0000000185FB6A80
	}

	public class JSONNull : JSONNode // TypeDefIndex: 60354
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181D27740-0x0000000181D27750 
		public override bool IsNull { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018C3D40C0-0x000000018C3D40EC 0x0000000185492010-0x0000000185492020
		public override bool AsBool { get => default; set {} } // 0x00000001814A81B0-0x00000001814A81C0 0x0000000185492010-0x0000000185492020
	
		// Constructors
		private JSONNull() {} // 0x0000000185F0A030-0x0000000185F0A070
		static JSONNull() {} // 0x0000000185F09FA0-0x0000000185F0A030
	
		// Methods
		public static JSONNull CreateOrGet() => default; // 0x0000000184ED1020-0x0000000184ED10A0
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		public override JSONNode Clone() => default; // 0x000000018C3D4028-0x000000018C3D4068
		public override bool Equals(object obj) => default; // 0x000000018C3D4068-0x000000018C3D40C0
		public override int GetHashCode() => default; // 0x00000001813AE580-0x00000001813AE590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x00000001858B0CC0-0x00000001858B0D10
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 60355
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181B9FE80-0x0000000181B9FE90 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C3CEC5C-0x000000018C3CECBC 0x000000018C3CF280-0x000000018C3CF314
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018C3CECBC-0x000000018C3CED2C 0x000000018C3CF1D8-0x000000018C3CF280
		public override int AsInt { get => default; set {} } // 0x000000018C3CE970-0x000000018C3CE9EC 0x000000018C3CEEC8-0x000000018C3CEF54
		public override float AsFloat { get => default; set {} } // 0x000000018C3CE8F0-0x000000018C3CE970 0x000000018C3CEE3C-0x000000018C3CEEC8
		public override double AsDouble { get => default; set {} } // 0x000000018C3CE870-0x000000018C3CE8F0 0x000000018C3CEDB4-0x000000018C3CEE3C
		public override long AsLong { get => default; set {} } // 0x000000018C3CE9EC-0x000000018C3CEAE8 0x000000018C3CEF54-0x000000018C3CF088
		public override ulong AsULong { get => default; set {} } // 0x000000018C3CEB60-0x000000018C3CEC5C 0x000000018C3CF088-0x000000018C3CF1D8
		public override bool AsBool { get => default; set {} } // 0x000000018C3CE7F4-0x000000018C3CE870 0x000000018C3CED2C-0x000000018C3CEDB4
		public override JSONArray AsArray { get => default; } // 0x000000018C3CE77C-0x000000018C3CE7F4 
		public override JSONObject AsObject { get => default; } // 0x000000018C3CEAE8-0x000000018C3CEB60 
	
		// Constructors
		public JSONLazyCreator() {} // Dummy constructor
		public JSONLazyCreator(JSONNode aNode) {} // 0x000000018C3CE6B0-0x000000018C3CE710
		public JSONLazyCreator(JSONNode aNode, string aKey) {} // 0x000000018C3CE710-0x000000018C3CE77C
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		private T Set<T>(T aVal)
			where T : JSONNode => default;
		public override void Add(JSONNode aItem) {} // 0x000000018C3CE52C-0x000000018C3CE5C0
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018C3CE5C0-0x000000018C3CE668
		public static bool operator ==(JSONLazyCreator a, object b) => default; // 0x000000018A96FAB0-0x000000018A96FAC0
		public static bool operator !=(JSONLazyCreator a, object b) => default; // 0x000000018A96FF50-0x000000018A96FF60
		public override bool Equals(object obj) => default; // 0x000000018A96FAB0-0x000000018A96FAC0
		public override int GetHashCode() => default; // 0x00000001813AE580-0x00000001813AE590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018C3CE668-0x000000018C3CE6B0
	}

	public static class JSON // TypeDefIndex: 60356
	{
		// Methods
		public static JSONNode Parse(string aJSON) => default; // 0x0000000184C6CA90-0x0000000184C6CAE0
	}
}
