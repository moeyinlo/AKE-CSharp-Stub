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

// Image 91: ZSimpleJSON.dll - Assembly: ZSimpleJSON, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90234-90256

namespace ZSimpleJSON
{
	public abstract class JSONNode // TypeDefIndex: 90242
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
		public virtual decimal AsDecimal { get; set; } // 0x000000018D9F5330-0x000000018D9F53A4 0x000000018D9F76E0-0x000000018D9F773C
		public virtual char AsChar { get; set; } // 0x000000018D9F51F4-0x000000018D9F527C 0x000000018D9F75C0-0x000000018D9F7658
		public virtual uint AsUInt { get; set; } // 0x000000018D9F581C-0x000000018D9F5838 0x000000018D9F7A90-0x000000018D9F7AAC
		public virtual byte AsByte { get; set; } // 0x000000018D9F51E4-0x000000018D9F51F4 0x000000018D9F75AC-0x000000018D9F75C0
		public virtual sbyte AsSByte { get; set; } // 0x000000018D9F51E4-0x000000018D9F51F4 0x000000018D9F7890-0x000000018D9F78A4
		public virtual short AsShort { get; set; } // 0x000000018D9F51E4-0x000000018D9F51F4 0x000000018D9F78A4-0x000000018D9F78B8
		public virtual ushort AsUShort { get; set; } // 0x000000018D9F51E4-0x000000018D9F51F4 0x000000018D9F7B10-0x000000018D9F7B24
		public virtual System.DateTime AsDateTime { get; set; } // 0x000000018D9F527C-0x000000018D9F5330 0x000000018D9F7658-0x000000018D9F76E0
		public virtual TimeSpan AsTimeSpan { get; set; } // 0x000000018D9F576C-0x000000018D9F581C 0x000000018D9F7A38-0x000000018D9F7A90
		public virtual Guid AsGuid { get; set; } // 0x000000018D9F5450-0x000000018D9F54BC 0x000000018D9F77B4-0x000000018D9F7814
		public virtual byte[] AsByteArray { get; set; } // 0x000000018D9F4FF8-0x000000018D9F50E4 0x000000018D9F7430-0x000000018D9F74E8
		public virtual List<byte> AsByteList { get; set; } // 0x000000018D9F50E4-0x000000018D9F51E4 0x000000018D9F74E8-0x000000018D9F75AC
		public virtual ulong[] AsUlongArray { get; set; } // 0x000000018D9F58B8-0x000000018D9F59AC 0x000000018D9F7B24-0x000000018D9F7BDC
		public virtual string[] AsStringArray { get; set; } // 0x000000018D9F5594-0x000000018D9F5668 0x000000018D9F78B8-0x000000018D9F7970
		public virtual List<string> AsStringList { get; set; } // 0x000000018D9F5668-0x000000018D9F576C 0x000000018D9F7970-0x000000018D9F7A38
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		public virtual string Value { get; set; } // 0x000000018D9F5B84-0x000000018D9F5BB0 0x0000000186805BA0-0x0000000186805BB0
		public virtual int Count { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public virtual bool IsNumber { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsString { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsBoolean { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsNull { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsArray { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsObject { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool Inline { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__181))] get; } // 0x000000018D9F59AC-0x000000018D9F5A00 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine(typeof(_get_DeepChildren_d__183))] get; } // 0x000000018D9F5A00-0x000000018D9F5A70 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x000000018D9F5B24-0x000000018D9F5B84 
		public KeyEnumerator Keys { get; } // 0x000000018D9F5A70-0x000000018D9F5B24 
		public ValueEnumerator Values { get; } // 0x000000018D9F5A70-0x000000018D9F5B24 
		public virtual double AsDouble { get; set; } // 0x000000018D9F53A4-0x000000018D9F5434 0x000000018D9F773C-0x000000018D9F77A0
		public virtual int AsInt { get; set; } // 0x000000018D9F54BC-0x000000018D9F54D8 0x000000018D9F7814-0x000000018D9F782C
		public virtual float AsFloat { get; set; } // 0x000000018D9F5434-0x000000018D9F5450 0x000000018D9F77A0-0x000000018D9F77B4
		public virtual bool AsBool { get; set; } // 0x000000018D9F4F5C-0x000000018D9F4FF8 0x000000018D9F73C4-0x000000018D9F7430
		public virtual long AsLong { get; set; } // 0x000000018D9F54D8-0x000000018D9F5558 0x000000018D9F782C-0x000000018D9F7890
		public virtual ulong AsULong { get; set; } // 0x000000018D9F5838-0x000000018D9F58B8 0x000000018D9F7AAC-0x000000018D9F7B10
		public virtual JSONArray AsArray { get; } // 0x000000018D9F4F20-0x000000018D9F4F5C 
		public virtual JSONObject AsObject { get; } // 0x000000018D9F5558-0x000000018D9F5594 
		internal static StringBuilder EscapeBuilder { get; } // 0x0000000186149740-0x0000000186149830 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 90236
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get; } // 0x00000001889F343C-0x00000001889F3444 
			public KeyValuePair<string, JSONNode> Current { get; } // 0x0000000185AEF3D0-0x0000000185AEF400 
	
			// Nested types
			private enum Type // TypeDefIndex: 90235
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum); // 0x000000018C1FFF84-0x000000018C1FFFB8
			public Enumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000186F88940-0x0000000186F88990
	
			// Methods
			public bool MoveNext(); // 0x0000000185AEF1E0-0x0000000185AEF210
		}
	
		public struct ValueEnumerator // TypeDefIndex: 90237
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get; } // 0x000000018D9F9B48-0x000000018D9F9B88 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum); // 0x000000018C20A5C8-0x000000018C20A660
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018C20A4F4-0x000000018C20A594
			public ValueEnumerator(Enumerator aEnumerator); // 0x000000018C20A594-0x000000018C20A5C8
	
			// Methods
			public bool MoveNext(); // 0x000000018D9F88A8-0x000000018D9F88B0
			public ValueEnumerator GetEnumerator(); // 0x00000001872415C0-0x00000001872415F0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 90238
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get; } // 0x000000018D9F88B0-0x000000018D9F88F0 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum); // 0x000000018C20A5C8-0x000000018C20A660
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018C20A4F4-0x000000018C20A594
			public KeyEnumerator(Enumerator aEnumerator); // 0x000000018C20A594-0x000000018C20A5C8
	
			// Methods
			public bool MoveNext(); // 0x000000018D9F88A8-0x000000018D9F88B0
			public KeyEnumerator GetEnumerator(); // 0x00000001872415C0-0x00000001872415F0
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 90239
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get; } // 0x000000018D9F8B74-0x000000018D9F8BA0 
			object IEnumerator.Current { get; } // 0x000000018D9F8A68-0x000000018D9F8AC0 
	
			// Constructors
			internal LinqEnumerator(JSONNode aNode); // 0x000000018D9F8AC0-0x000000018D9F8B74
	
			// Methods
			public bool MoveNext(); // 0x000000018D9F8954-0x000000018D9F8960
			public void Dispose(); // 0x000000018C20A6A0-0x000000018C20A6DC
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator(); // 0x000000018D9F88F0-0x000000018D9F8954
			public void Reset(); // 0x000000018D9F8960-0x000000018D9F8A04
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D9F8A04-0x000000018D9F8A68
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__181 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 90240
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__181(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001870F8D80-0x00000001870F8D90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D9F8C88-0x000000018D9F8CD4
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018D9F8C04-0x000000018D9F8C80
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D9F8C80-0x000000018D9F8C88
		}
	
		[CompilerGenerated]
		private sealed class _get_DeepChildren_d__183 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 90241
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONNode __4__this; // 0x28
			private IEnumerator<JSONNode> __7__wrap1; // 0x30
			private IEnumerator<JSONNode> __7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_DeepChildren_d__183(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D9F99C0-0x000000018D9F9AB0
			private bool MoveNext(); // 0x000000018D9F94CC-0x000000018D9F98DC
			private void __m__Finally1(); // 0x000000018D9F9AB0-0x000000018D9F9AFC
			private void __m__Finally2(); // 0x000000018D9F9AFC-0x000000018D9F9B48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D9F9974-0x000000018D9F99C0
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018D9F98DC-0x000000018D9F996C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D9F996C-0x000000018D9F9974
		}
	
		// Constructors
		protected JSONNode(); // 0x0000000186805BA0-0x0000000186805BB0
		static JSONNode(); // 0x00000001870F11A0-0x00000001870F1270
	
		// Methods
		public static implicit operator JSONNode(decimal aDecimal); // 0x000000018D9F6328-0x000000018D9F63AC
		public static implicit operator decimal(JSONNode aNode); // 0x000000018D9F68EC-0x000000018D9F691C
		public static implicit operator JSONNode(char aChar); // 0x000000018D9F7038-0x000000018D9F70C0
		public static implicit operator char(JSONNode aNode); // 0x000000018D9F7000-0x000000018D9F701C
		public static implicit operator JSONNode(uint aUInt); // 0x000000018672D9E0-0x000000018672DA50
		public static implicit operator uint(JSONNode aNode); // 0x000000018D9F6F60-0x000000018D9F6F7C
		public static implicit operator JSONNode(byte aByte); // 0x000000018D9F6AEC-0x000000018D9F6B50
		public static implicit operator byte(JSONNode aNode); // 0x000000018D9F6048-0x000000018D9F6064
		public static implicit operator JSONNode(sbyte aSByte); // 0x000000018D9F7290-0x000000018D9F72F4
		public static implicit operator sbyte(JSONNode aNode); // 0x000000018D9F6048-0x000000018D9F6064
		public static implicit operator JSONNode(short aShort); // 0x000000018D9F5FE4-0x000000018D9F6048
		public static implicit operator short(JSONNode aNode); // 0x000000018D9F6048-0x000000018D9F6064
		public static implicit operator JSONNode(ushort aUShort); // 0x000000018D9F6E44-0x000000018D9F6EA8
		public static implicit operator ushort(JSONNode aNode); // 0x000000018D9F6048-0x000000018D9F6064
		public static implicit operator JSONNode(System.DateTime aDateTime); // 0x000000018D9F5DF4-0x000000018D9F5EA4
		public static implicit operator System.DateTime(JSONNode aNode); // 0x000000018D9F6984-0x000000018D9F69A0
		public static implicit operator JSONNode(TimeSpan aTimeSpan); // 0x000000018D9F5F5C-0x000000018D9F5FE4
		public static implicit operator TimeSpan(JSONNode aNode); // 0x000000018D9F68B4-0x000000018D9F68D0
		public static implicit operator JSONNode(Guid aGuid); // 0x000000018D9F5D70-0x000000018D9F5DF4
		public static implicit operator Guid(JSONNode aNode); // 0x000000018D9F6ABC-0x000000018D9F6AEC
		public static implicit operator JSONNode(byte[] aByteArray); // 0x000000018D9F62BC-0x000000018D9F6328
		public static implicit operator byte[](JSONNode aNode); // 0x000000018D9F6A38-0x000000018D9F6A54
		public static implicit operator JSONNode(List<byte> aByteList); // 0x000000018D9F6DD8-0x000000018D9F6E44
		public static implicit operator List<byte>(JSONNode aNode); // 0x000000018D9F6064-0x000000018D9F6080
		public static implicit operator JSONNode(ulong[] aStringArray); // 0x000000018D9F7138-0x000000018D9F71A4
		public static implicit operator ulong[](JSONNode aNode); // 0x000000018D9F66F8-0x000000018D9F6714
		public static implicit operator JSONNode(string[] aStringArray); // 0x000000018D9F6140-0x000000018D9F61AC
		public static implicit operator string[](JSONNode aNode); // 0x000000018D9F68D0-0x000000018D9F68EC
		public static implicit operator JSONNode(List<string> aStringList); // 0x000000018D9F6BB8-0x000000018D9F6C24
		public static implicit operator List<string>(JSONNode aNode); // 0x000000018D9F6CB8-0x000000018D9F6CD4
		public static implicit operator JSONNode(int? aValue); // 0x0000000186B14820-0x0000000186B148B0
		public static implicit operator int?(JSONNode aNode); // 0x000000018D9F69A0-0x000000018D9F6A38
		public static implicit operator JSONNode(float? aValue); // 0x000000018D9F663C-0x000000018D9F66F8
		public static implicit operator float?(JSONNode aNode); // 0x000000018D9F6D3C-0x000000018D9F6DD8
		public static implicit operator JSONNode(double? aValue); // 0x000000018D9F658C-0x000000018D9F663C
		public static implicit operator double?(JSONNode aNode); // 0x000000018D9F6458-0x000000018D9F6508
		public static implicit operator JSONNode(bool? aValue); // 0x000000018D9F5C88-0x000000018D9F5D40
		public static implicit operator bool?(JSONNode aNode); // 0x000000018D9F6EA8-0x000000018D9F6F44
		public static implicit operator JSONNode(long? aValue); // 0x000000018D9F677C-0x000000018D9F6830
		public static implicit operator long?(JSONNode aNode); // 0x000000018D9F63AC-0x000000018D9F6458
		public static implicit operator JSONNode(short? aValue); // 0x000000018D9F5EA4-0x000000018D9F5F5C
		public static implicit operator short?(JSONNode aNode); // 0x000000018D9F6C24-0x000000018D9F6CB8
		private static JSONNode GetContainer(JSONContainerType aType); // 0x000000018D9F2DC4-0x000000018D9F2E48
		public static implicit operator JSONNode(Vector2 aVec); // 0x000000018D9F61AC-0x000000018D9F6254
		public static implicit operator JSONNode(Vector3 aVec); // 0x000000018D9F72F4-0x000000018D9F73C4
		public static implicit operator JSONNode(Vector4 aVec); // 0x000000018D9F71A4-0x000000018D9F7228
		public static implicit operator JSONNode(UnityEngine.Color aCol); // 0x000000018D9F6830-0x000000018D9F68B4
		public static implicit operator JSONNode(Color32 aCol); // 0x000000018D9F5BE0-0x000000018D9F5C58
		public static implicit operator JSONNode(Quaternion aRot); // 0x000000018D9F6508-0x000000018D9F658C
		public static implicit operator JSONNode(Rect aRect); // 0x000000018D9F6F7C-0x000000018D9F7000
		public static implicit operator JSONNode(RectOffset aRect); // 0x000000018D9F70C0-0x000000018D9F7138
		public static implicit operator Vector2(JSONNode aNode); // 0x000000018D9F701C-0x000000018D9F7038
		public static implicit operator Vector3(JSONNode aNode); // 0x000000018D9F6108-0x000000018D9F6140
		public static implicit operator Vector4(JSONNode aNode); // 0x000000018D9F6B50-0x000000018D9F6B80
		public static implicit operator UnityEngine.Color(JSONNode aNode); // 0x000000018D9F5BB0-0x000000018D9F5BE0
		public static implicit operator Color32(JSONNode aNode); // 0x000000018D9F60E8-0x000000018D9F6108
		public static implicit operator Quaternion(JSONNode aNode); // 0x000000018D9F5C58-0x000000018D9F5C88
		public static implicit operator Rect(JSONNode aNode); // 0x000000018D9F5D40-0x000000018D9F5D70
		public static implicit operator RectOffset(JSONNode aNode); // 0x000000018D9F6F44-0x000000018D9F6F60
		public Vector2 ReadVector2(Vector2 aDefault); // 0x000000018D9F3AE0-0x000000018D9F3BC8
		public Vector2 ReadVector2(string aXName, string aYName); // 0x000000018D9F3A40-0x000000018D9F3AE0
		public Vector2 ReadVector2(); // 0x000000018D9F3A28-0x000000018D9F3A40
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x0264AD50 */, string aYName = "y" /* Metadata: 0x0264AD52 */); // 0x000000018D9F4B1C-0x000000018D9F4C14
		public Vector3 ReadVector3(Vector3 aDefault); // 0x000000018D9F3D00-0x000000018D9F3E7C
		public Vector3 ReadVector3(string aXName, string aYName, string aZName); // 0x000000018D9F3C18-0x000000018D9F3D00
		public Vector3 ReadVector3(); // 0x000000018D9F3BC8-0x000000018D9F3C18
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x0264AD54 */, string aYName = "y" /* Metadata: 0x0264AD56 */, string aZName = "z" /* Metadata: 0x0264AD58 */); // 0x000000018D9F4C14-0x000000018D9F4D54
		public Vector4 ReadVector4(Vector4 aDefault); // 0x000000018D9F3E7C-0x000000018D9F4058
		public Vector4 ReadVector4(); // 0x000000018D9F4058-0x000000018D9F4094
		public JSONNode WriteVector4(Vector4 aVec); // 0x000000018D9F4D54-0x000000018D9F4F20
		public UnityEngine.Color ReadColor(UnityEngine.Color aDefault); // 0x000000018D9F3060-0x000000018D9F3294
		public UnityEngine.Color ReadColor(); // 0x000000018D9F3294-0x000000018D9F32D0
		public JSONNode WriteColor(UnityEngine.Color aCol); // 0x000000018D9F42EC-0x000000018D9F44B8
		public Color32 ReadColor32(Color32 aDefault); // 0x000000018D9F2E54-0x000000018D9F3060
		public Color32 ReadColor32(); // 0x000000018D9F2E48-0x000000018D9F2E54
		public JSONNode WriteColor32(Color32 aCol); // 0x000000018D9F4124-0x000000018D9F42EC
		public Quaternion ReadQuaternion(Quaternion aDefault); // 0x000000018D9F3384-0x000000018D9F3560
		public Quaternion ReadQuaternion(); // 0x000000018D9F3560-0x000000018D9F359C
		public JSONNode WriteQuaternion(Quaternion aRot); // 0x000000018D9F454C-0x000000018D9F4718
		public Rect ReadRect(Rect aDefault); // 0x000000018D9F3818-0x000000018D9F39F4
		public Rect ReadRect(); // 0x000000018D9F39F4-0x000000018D9F3A28
		public JSONNode WriteRect(Rect aRect); // 0x000000018D9F4950-0x000000018D9F4B1C
		public RectOffset ReadRectOffset(RectOffset aDefault); // 0x000000018D9F3604-0x000000018D9F3818
		public RectOffset ReadRectOffset(); // 0x000000018D9F359C-0x000000018D9F3604
		public JSONNode WriteRectOffset(RectOffset aRect); // 0x000000018D9F4718-0x000000018D9F4950
		public Matrix4x4 ReadMatrix(); // 0x000000018D9F32D0-0x000000018D9F3384
		public JSONNode WriteMatrix(Matrix4x4 aMatrix); // 0x000000018D9F44B8-0x000000018D9F454C
		public virtual void Add(string aKey, JSONNode aItem); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void Add(JSONNode aItem); // 0x0000000186AAB980-0x0000000186AAB9A0
		public virtual JSONNode Remove(string aKey); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual JSONNode Remove(int aIndex); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual JSONNode Remove(JSONNode aNode); // 0x000000018459BB50-0x000000018459BB60
		public virtual void Clear(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual JSONNode Clone(); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual bool HasKey(string aKey); // 0x00000001843FFFF0-0x0000000184400000
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x0000000187239520-0x0000000187239530
		public override string ToString(); // 0x0000000186AA8800-0x0000000186AA8890
		public virtual string ToString(int aIndent); // 0x000000018D9F4094-0x000000018D9F4124
		public virtual void ToStringBuild(ref StringBuilder sb); // 0x0000000185AEEB70-0x0000000185AEEBC0
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s); // 0x0000000185A88290-0x0000000185A88320
		public static implicit operator string(JSONNode d); // 0x000000018D9F6254-0x000000018D9F62BC
		public static implicit operator JSONNode(double n); // 0x0000000185A86B60-0x0000000185A86BB0
		public static implicit operator double(JSONNode d); // 0x000000018D9F6714-0x000000018D9F677C
		public static implicit operator JSONNode(float n); // 0x0000000185A884C0-0x0000000185A88520
		public static implicit operator float(JSONNode d); // 0x000000018D9F691C-0x000000018D9F6984
		public static implicit operator JSONNode(int n); // 0x0000000185A88520-0x0000000185A88580
		public static implicit operator int(JSONNode d); // 0x000000018D9F6A54-0x000000018D9F6ABC
		public static implicit operator JSONNode(long n); // 0x0000000185A88440-0x0000000185A884C0
		public static implicit operator long(JSONNode d); // 0x000000018D9F6CD4-0x000000018D9F6D3C
		public static implicit operator JSONNode(ulong n); // 0x0000000185EACBF0-0x0000000185EACCE0
		public static implicit operator ulong(JSONNode d); // 0x000000018D9F6080-0x000000018D9F60E8
		public static implicit operator JSONNode(bool b); // 0x0000000185A85D90-0x0000000185A85DE0
		public static implicit operator bool(JSONNode d); // 0x000000018D9F7228-0x000000018D9F7290
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue); // 0x000000018D9F6B80-0x000000018D9F6BB8
		public static bool operator ==(JSONNode a, object b); // 0x0000000185F85130-0x0000000185F851F0
		public static bool operator !=(JSONNode a, object b); // 0x0000000185F84F50-0x0000000185F84FA0
		public override bool Equals(object obj); // 0x0000000185F84F40-0x0000000185F84F50
		public override int GetHashCode(); // 0x0000000187235B50-0x0000000187235B60
		internal static string Escape(string aText); // 0x00000001851A81C0-0x00000001851A8440
		private static JSONNode ParseElement(string token, bool quoted); // 0x0000000185A86870-0x0000000185A868C0
		public static JSONNode Parse(string aJSON); // 0x0000000185A86020-0x0000000185A86600
	}

	public enum JSONContainerType // TypeDefIndex: 90243
	{
		Array = 0,
		Object = 1
	}

	public enum JSONNodeType // TypeDefIndex: 90244
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

	public enum JSONTextMode // TypeDefIndex: 90245
	{
		Compact = 0,
		Indent = 1
	}

	public class JSONArray : JSONNode // TypeDefIndex: 90247
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public override JSONNodeType Tag { get; } // 0x00000001872328C0-0x00000001872328D0 
		public override bool IsArray { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018D9F1CDC-0x000000018D9F1D7C 0x0000000185F84DF0-0x0000000185F84E90
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018D9F1C7C-0x000000018D9F1CDC 0x000000018D9F1D7C-0x000000018D9F1E1C
		public override int Count { get; } // 0x000000018D9F1C3C-0x000000018D9F1C7C 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__24))] get; } // 0x000000018D9F1BCC-0x000000018D9F1C3C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_Children_d__24 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 90246
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONArray __4__this; // 0x28
			private List<JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__24(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D9F9008-0x000000018D9F9080
			private bool MoveNext(); // 0x000000018D9F8CD4-0x000000018D9F8F24
			private void __m__Finally1(); // 0x000000018D9F9080-0x000000018D9F90BC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D9F8FBC-0x000000018D9F9008
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018D9F8F24-0x000000018D9F8FB4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D9F8FB4-0x000000018D9F8FBC
		}
	
		// Constructors
		public JSONArray(); // 0x0000000185A85E20-0x0000000185A85EC0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x000000018D9F1A40-0x000000018D9F1AD0
		public override void Add(string aKey, JSONNode aItem); // 0x0000000185F84CC0-0x0000000185F84D30
		public override JSONNode Remove(int aIndex); // 0x000000018D9F1AD0-0x000000018D9F1B74
		public override JSONNode Remove(JSONNode aNode); // 0x000000018D9F1B74-0x000000018D9F1BCC
		public override void Clear(); // 0x000000018D9F17B0-0x000000018D9F17F8
		public override JSONNode Clone(); // 0x000000018D9F17F8-0x000000018D9F1A40
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000185AEEEB0-0x0000000185AEEFC0
	}

	public class JSONObject : JSONNode // TypeDefIndex: 90250
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public override JSONNodeType Tag { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override bool IsObject { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018D9F8640-0x000000018D9F8700 0x0000000185F84FA0-0x0000000185F85130
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018D9F85B4-0x000000018D9F8640 0x000000018D9F8700-0x000000018D9F8804
		public override int Count { get; } // 0x000000018D9F8574-0x000000018D9F85B4 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__27))] get; } // 0x000000018D9F8504-0x000000018D9F8574 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 90248
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Remove_b__0(KeyValuePair<string, JSONNode> k); // 0x000000018D9F8BA0-0x000000018D9F8C04
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__27 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 90249
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONObject __4__this; // 0x28
			private Dictionary<string, JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<ZSimpleJSON.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__27(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D9F9418-0x000000018D9F9490
			private bool MoveNext(); // 0x000000018D9F90BC-0x000000018D9F9334
			private void __m__Finally1(); // 0x000000018D9F9490-0x000000018D9F94CC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D9F93CC-0x000000018D9F9418
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018D9F9334-0x000000018D9F93C4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D9F93C4-0x000000018D9F93CC
		}
	
		// Constructors
		public JSONObject(); // 0x0000000185A85BD0-0x0000000185A85C40
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000186F88890-0x0000000186F88940
		public override void Add(string aKey, JSONNode aItem); // 0x0000000185F84D30-0x0000000185F84DF0
		public override JSONNode Remove(string aKey); // 0x000000018D9F81E0-0x000000018D9F8298
		public override JSONNode Remove(int aIndex); // 0x000000018D9F8298-0x000000018D9F8358
		public override JSONNode Remove(JSONNode aNode); // 0x000000018D9F8358-0x000000018D9F8504
		public override void Clear(); // 0x00000001867F94C0-0x00000001867F94F0
		public override JSONNode Clone(); // 0x000000018D9F7F38-0x000000018D9F810C
		public override bool HasKey(string aKey); // 0x000000018D9F818C-0x000000018D9F81E0
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x000000018D9F810C-0x000000018D9F818C
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000185AEEBC0-0x0000000185AEEEB0
	}

	public class JSONString : JSONNode // TypeDefIndex: 90251
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x00000001872396E0-0x00000001872396F0 
		public override bool IsString { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public JSONString(string aData); // 0x0000000185A88320-0x0000000185A88360
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		public override JSONNode Clone(); // 0x000000018D9F8844-0x000000018D9F88A8
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018611C1D0-0x000000018611C3E0
		public override bool Equals(object obj); // 0x0000000185F84E90-0x0000000185F84F40
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
		public override void Clear(); // 0x000000018D9F8804-0x000000018D9F8844
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 90252
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x00000001845BA780-0x00000001845BA790 
		public override bool IsNumber { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x0000000185398B40-0x0000000185398BB0 0x000000018D9F7EB8-0x000000018D9F7F38
		public override double AsDouble { get; set; } // 0x0000000187244520-0x0000000187244530 0x0000000187247AC0-0x0000000187247AD0
		public override long AsLong { get; set; } // 0x0000000187250990-0x00000001872509A0 0x00000001872509A0-0x00000001872509B0
		public override ulong AsULong { get; set; } // 0x000000018D9F7EAC-0x000000018D9F7EB8 0x0000000187264AD0-0x0000000187264B00
	
		// Constructors
		public JSONNumber(double aData); // 0x0000000185A88580-0x0000000185A885C0
		public JSONNumber(string aData); // 0x000000018D9F7E50-0x000000018D9F7EAC
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		public override JSONNode Clone(); // 0x000000018D9F7CA0-0x000000018D9F7D08
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x00000001862894F0-0x0000000186289560
		private static bool IsNumeric(object value); // 0x000000018D9F7D08-0x000000018D9F7E50
		public override bool Equals(object obj); // 0x000000018641BD90-0x000000018641BDC0
		public override int GetHashCode(); // 0x000000018C2094CC-0x000000018C2094D8
		public override void Clear(); // 0x00000001872562B0-0x00000001872562C0
	}

	public class JSONBool : JSONNode // TypeDefIndex: 90253
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000187239C80-0x0000000187239C90 
		public override bool IsBoolean { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x000000018D9F1F24-0x000000018D9F1F78 0x000000018D9F1F78-0x000000018D9F1FDC
		public override bool AsBool { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public JSONBool(bool aData); // 0x0000000185A85DE0-0x0000000185A85E20
		public JSONBool(string aData); // 0x000000018D9F1EC8-0x000000018D9F1F24
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		public override JSONNode Clone(); // 0x000000018D9F1E1C-0x000000018D9F1E80
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000186734270-0x00000001867342B0
		public override bool Equals(object obj); // 0x000000018687A710-0x000000018687A730
		public override int GetHashCode(); // 0x000000018D9F1E80-0x000000018D9F1EC8
		public override void Clear(); // 0x000000018275FD80-0x000000018275FD90
	}

	public class JSONNull : JSONNode // TypeDefIndex: 90254
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000187239C70-0x0000000187239C80 
		public override bool IsNull { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x000000018D9F7C74-0x000000018D9F7CA0 0x0000000186805BA0-0x0000000186805BB0
		public override bool AsBool { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
	
		// Constructors
		private JSONNull(); // 0x00000001871097A0-0x00000001871097E0
		static JSONNull(); // 0x0000000187109710-0x00000001871097A0
	
		// Methods
		public static JSONNull CreateOrGet(); // 0x0000000185F851F0-0x0000000185F85270
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		public override JSONNode Clone(); // 0x000000018D9F7BDC-0x000000018D9F7C1C
		public override bool Equals(object obj); // 0x000000018D9F7C1C-0x000000018D9F7C74
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000186AF6650-0x0000000186AF6780
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 90255
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000187239C90-0x0000000187239CA0 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018D9F270C-0x000000018D9F276C 0x000000018D9F2D30-0x000000018D9F2DC4
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018D9F276C-0x000000018D9F27DC 0x000000018D9F2C88-0x000000018D9F2D30
		public override int AsInt { get; set; } // 0x000000018D9F2420-0x000000018D9F249C 0x000000018D9F2978-0x000000018D9F2A04
		public override float AsFloat { get; set; } // 0x000000018D9F23A0-0x000000018D9F2420 0x000000018D9F28EC-0x000000018D9F2978
		public override double AsDouble { get; set; } // 0x000000018D9F2320-0x000000018D9F23A0 0x000000018D9F2864-0x000000018D9F28EC
		public override long AsLong { get; set; } // 0x000000018D9F249C-0x000000018D9F2598 0x000000018D9F2A04-0x000000018D9F2B38
		public override ulong AsULong { get; set; } // 0x000000018D9F2610-0x000000018D9F270C 0x000000018D9F2B38-0x000000018D9F2C88
		public override bool AsBool { get; set; } // 0x000000018D9F22A4-0x000000018D9F2320 0x000000018D9F27DC-0x000000018D9F2864
		public override JSONArray AsArray { get; } // 0x000000018D9F222C-0x000000018D9F22A4 
		public override JSONObject AsObject { get; } // 0x000000018D9F2598-0x000000018D9F2610 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x000000018D9F2160-0x000000018D9F21C0
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x000000018D9F21C0-0x000000018D9F222C
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		private T Set<T>(T aVal)
			where T : JSONNode;
		public override void Add(JSONNode aItem); // 0x000000018D9F1FDC-0x000000018D9F2070
		public override void Add(string aKey, JSONNode aItem); // 0x000000018D9F2070-0x000000018D9F2118
		public static bool operator ==(JSONLazyCreator a, object b); // 0x000000018C208980-0x000000018C208990
		public static bool operator !=(JSONLazyCreator a, object b); // 0x000000018C208E30-0x000000018C208E40
		public override bool Equals(object obj); // 0x000000018C208980-0x000000018C208990
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018D9F2118-0x000000018D9F2160
	}

	public static class JSON // TypeDefIndex: 90256
	{
		// Methods
		public static JSONNode Parse(string aJSON); // 0x00000001871FC390-0x00000001871FC3E0
	}
}
