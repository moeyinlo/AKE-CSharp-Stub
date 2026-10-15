/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 76: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89727-89741

namespace UnityEngine
{
	public delegate void AndroidJavaRunnable(); // TypeDefIndex: 89728; 0x0000000185B44B70-0x0000000185B44B80

	public sealed class AndroidJavaException : Exception // TypeDefIndex: 89729
	{
		// Fields
		private string mJavaStackTrace; // 0x90
	
		// Properties
		public override string StackTrace { get; } // 0x000000018D4B6230-0x000000018D4B625C 
	
		// Constructors
		internal AndroidJavaException(string message, string javaStackTrace); // 0x000000018D4B61C0-0x000000018D4B6230
	}

	internal class GlobalJavaObjectRef // TypeDefIndex: 89730
	{
		// Fields
		private bool m_disposed; // 0x10
		protected IntPtr m_jobject; // 0x18
	
		// Constructors
		public GlobalJavaObjectRef(IntPtr jobject); // 0x000000018D4B84EC-0x000000018D4B8518
	
		// Methods
		~GlobalJavaObjectRef(); // 0x000000018D4B8478-0x000000018D4B84EC
		public static implicit operator IntPtr(GlobalJavaObjectRef obj); // 0x000000018788A2DC-0x000000018788A2F4
		public void Dispose(); // 0x000000018D4B8450-0x000000018D4B8478
	}

	internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 89731
	{
		// Fields
		private AndroidJavaRunnable mRunnable; // 0x20
	
		// Constructors
		public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable); // 0x000000018D4B7618-0x000000018D4B7688
	}

	public class AndroidJavaProxy // TypeDefIndex: 89732
	{
		// Fields
		public readonly AndroidJavaClass javaInterface; // 0x10
		internal IntPtr proxyObject; // 0x18
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x00
		private static readonly IntPtr s_HashCodeMethodID; // 0x08
	
		// Constructors
		public AndroidJavaProxy(string javaInterface); // 0x000000018D4B7448-0x000000018D4B74C0
		public AndroidJavaProxy(AndroidJavaClass javaInterface); // 0x000000018D4B74C0-0x000000018D4B74D8
		static AndroidJavaProxy(); // 0x000000018D4B7338-0x000000018D4B7448
	
		// Methods
		~AndroidJavaProxy(); // 0x000000018D4B692C-0x000000018D4B69A4
		public virtual AndroidJavaObject Invoke(string methodName, object[] args); // 0x000000018D4B6A20-0x000000018D4B721C
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs); // 0x000000018D4B721C-0x000000018D4B7338
		public virtual bool equals(AndroidJavaObject obj); // 0x000000018D4B74D8-0x000000018D4B750C
		public virtual int hashCode(); // 0x000000018D4B750C-0x000000018D4B75BC
		public virtual string toString(); // 0x000000018D4B75BC-0x000000018D4B7618
		internal AndroidJavaObject GetProxyObject(); // 0x000000018D4B69A4-0x000000018D4B69C0
		internal IntPtr GetRawProxy(); // 0x000000018D4B69C0-0x000000018D4B6A20
	}

	public class AndroidJavaObject : IDisposable // TypeDefIndex: 89733
	{
		// Fields
		private static bool enableDebugPrints; // 0x00
		internal GlobalJavaObjectRef m_jobject; // 0x10
		internal GlobalJavaObjectRef m_jclass; // 0x18
	
		// Constructors
		public AndroidJavaObject(string className, params object[] args); // 0x000000018D4B6924-0x000000018D4B692C
		internal AndroidJavaObject(IntPtr jobject); // 0x000000018D4B6804-0x000000018D4B6924
		internal AndroidJavaObject(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x000000018D4B646C-0x000000018D4B64BC
		public FieldType Get<FieldType>(string fieldName);
		public FieldType GetStatic<FieldType>(string fieldName);
		public IntPtr GetRawObject(); // 0x000000018D4B6598-0x000000018D4B65A4
		public IntPtr GetRawClass(); // 0x000000018D4B658C-0x000000018D4B6598
		public ReturnType Call<ReturnType>(string methodName, params object[] args);
		public ReturnType CallStatic<ReturnType>(string methodName, params object[] args);
		protected void DebugPrint(string msg); // 0x000000018D4B640C-0x000000018D4B646C
		private void _AndroidJavaObject(string className, params object[] args); // 0x000000018D4B65A4-0x000000018D4B67F0
		~AndroidJavaObject(); // 0x000000018D4B6514-0x000000018D4B658C
		protected virtual void Dispose(bool disposing); // 0x000000018D4B64BC-0x000000018D4B6514
		protected ReturnType _Call<ReturnType>(string methodName, params object[] args);
		protected FieldType _Get<FieldType>(string fieldName);
		protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args);
		protected FieldType _GetStatic<FieldType>(string fieldName);
		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject); // 0x000000018D4B6334-0x000000018D4B640C
		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass); // 0x000000018D4B625C-0x000000018D4B6334
		internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject);
		protected IntPtr _GetRawObject(); // 0x000000018D4B67F0-0x000000018D4B6804
		protected IntPtr _GetRawClass(); // 0x000000018CA8CBD0-0x000000018CA8CBEC
	}

	public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 89734
	{
		// Constructors
		public AndroidJavaClass(string className); // 0x000000018D4B61B8-0x000000018D4B61C0
		internal AndroidJavaClass(IntPtr jclass); // 0x000000018D4B60DC-0x000000018D4B61B8
	
		// Methods
		private void _AndroidJavaClass(string className); // 0x000000018D4B5FF8-0x000000018D4B60DC
	}

	internal class AndroidReflection // TypeDefIndex: 89735
	{
		// Fields
		private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x00
		private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x08
		private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
		private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
		private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
		private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
		private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
		private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38
	
		// Constructors
		static AndroidReflection(); // 0x000000018D4B7FFC-0x000000018D4B82A4
	
		// Methods
		public static bool IsPrimitive(System.Type t); // 0x000000018CC9CD14-0x000000018CC9CD34
		public static bool IsAssignableFrom(System.Type t, System.Type from); // 0x000000018CE6880C-0x000000018CE68830
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature); // 0x000000018D4B7D78-0x000000018D4B7E34
		private static IntPtr GetMethodID(string clazz, string methodName, string signature); // 0x000000018D4B7ADC-0x000000018D4B7B98
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature); // 0x000000018D4B7688-0x000000018D4B77FC
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic); // 0x000000018D4B7B98-0x000000018D4B7D78
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic); // 0x000000018D4B7854-0x000000018D4B7A34
		public static IntPtr GetFieldClass(IntPtr field); // 0x000000018D4B77FC-0x000000018D4B7854
		public static string GetFieldSignature(IntPtr field); // 0x000000018D4B7A34-0x000000018D4B7ADC
		public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze); // 0x000000018D4B7E34-0x000000018D4B7F10
		public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound); // 0x000000018D4B7F10-0x000000018D4B7FFC
	}

	[UsedByNativeCode]
	internal sealed class _AndroidJNIHelper // TypeDefIndex: 89736
	{
		// Methods
		public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy); // 0x000000018D4B9AF8-0x000000018D4B9B78
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable); // 0x000000018D4B9B78-0x000000018D4B9BE0
		[RequiredByNativeCode]
		public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs); // 0x000000018D4BAF88-0x000000018D4BB220
		public static jvalue[] CreateJNIArgArray(object[] args); // 0x000000018D4B9554-0x000000018D4B9AF8
		public static object UnboxArray(AndroidJavaObject obj); // 0x000000018D4BB220-0x000000018D4BB800
		public static object Unbox(AndroidJavaObject obj); // 0x000000018D4BB800-0x000000018D4BC6D0
		public static AndroidJavaObject Box(object obj); // 0x000000018D4B8518-0x000000018D4B8E5C
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs); // 0x000000018D4B9BE0-0x000000018D4B9CE4
		public static IntPtr ConvertToJNIArray(Array array); // 0x000000018D4B8E5C-0x000000018D4B9554
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array);
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args); // 0x000000018D4B9E98-0x000000018D4B9EC4
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic);
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic);
		public static IntPtr GetConstructorID(IntPtr jclass, string signature); // 0x000000018D4B9CE4-0x000000018D4B9E98
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic); // 0x000000018D4BA1C0-0x000000018D4BA380
		private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic); // 0x000000018D4BA138-0x000000018D4BA1C0
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic); // 0x000000018D4B9EC4-0x000000018D4BA138
		public static string GetSignature(object obj); // 0x000000018D4BA464-0x000000018D4BAF88
		public static string GetSignature(object[] args); // 0x000000018D4BA380-0x000000018D4BA464
		public static string GetSignature<ReturnType>(object[] args);
	}

	[NativeType(CodegenOptions.Custom, "ScriptingJvalue")]
	public struct jvalue // TypeDefIndex: 89737
	{
		// Fields
		public bool z; // 0x00
		public sbyte b; // 0x00
		public char c; // 0x00
		public short s; // 0x00
		public int i; // 0x00
		public long j; // 0x00
		public float f; // 0x00
		public double d; // 0x00
		public IntPtr l; // 0x00
	}

	[NativeConditional("PLATFORM_ANDROID")]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[UsedByNativeCode]
	public static class AndroidJNIHelper // TypeDefIndex: 89738
	{
		// Methods
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue("")] string signature); // 0x000000018D4B2020-0x000000018D4B202C
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic); // 0x000000018D4B203C-0x000000018D4B204C
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic); // 0x000000018D4B202C-0x000000018D4B203C
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable); // 0x000000018D4B2000-0x000000018D4B200C
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy); // 0x000000018D4B1EE4-0x000000018D4B2000
		public static jvalue[] CreateJNIArgArray(object[] args); // 0x000000018D4B1ED8-0x000000018D4B1EE4
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs); // 0x000000018D4B200C-0x000000018D4B2014
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args); // 0x000000018D4B2014-0x000000018D4B2020
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array);
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic);
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic);
	}

	[NativeConditional("PLATFORM_ANDROID")]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	public static class AndroidJNI // TypeDefIndex: 89739
	{
		// Methods
		[ThreadSafe]
		public static IntPtr FindClass(string name); // 0x000000018D4B51AC-0x000000018D4B51E0
		[ThreadSafe]
		public static IntPtr FromReflectedMethod(IntPtr refMethod); // 0x000000018D4B534C-0x000000018D4B5380
		[ThreadSafe]
		public static IntPtr ExceptionOccurred(); // 0x000000018D4B5180-0x000000018D4B51AC
		[ThreadSafe]
		public static void ExceptionClear(); // 0x000000018D4B5154-0x000000018D4B5180
		[ThreadSafe]
		public static int PushLocalFrame(int capacity); // 0x000000018D4B5D5C-0x000000018D4B5D90
		[ThreadSafe]
		public static IntPtr PopLocalFrame(IntPtr ptr); // 0x000000018D4B5D28-0x000000018D4B5D5C
		[ThreadSafe]
		public static IntPtr NewGlobalRef(IntPtr obj); // 0x000000018D4B5BA8-0x000000018D4B5BDC
		[ThreadSafe]
		public static void DeleteGlobalRef(IntPtr obj); // 0x000000018D4B50B8-0x000000018D4B50EC
		[ThreadSafe]
		public static IntPtr NewWeakGlobalRef(IntPtr obj); // 0x000000018D4B5CF4-0x000000018D4B5D28
		[ThreadSafe]
		public static void DeleteWeakGlobalRef(IntPtr obj); // 0x000000018D4B5120-0x000000018D4B5154
		[ThreadSafe]
		public static IntPtr NewLocalRef(IntPtr obj); // 0x000000018D4B5BDC-0x000000018D4B5C10
		[ThreadSafe]
		public static void DeleteLocalRef(IntPtr obj); // 0x000000018D4B50EC-0x000000018D4B5120
		[ThreadSafe]
		public static bool IsSameObject(IntPtr obj1, IntPtr obj2); // 0x000000018D4B5B64-0x000000018D4B5BA8
		[ThreadSafe]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B5C60-0x000000018D4B5CB4
		[ThreadSafe]
		public static IntPtr GetObjectClass(IntPtr obj); // 0x000000018D4B569C-0x000000018D4B56D0
		[ThreadSafe]
		public static IntPtr GetMethodID(IntPtr clazz, string name, string sig); // 0x000000018D4B5608-0x000000018D4B565C
		[ThreadSafe]
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig); // 0x000000018D4B54E8-0x000000018D4B553C
		[ThreadSafe]
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig); // 0x000000018D4B5988-0x000000018D4B59DC
		[ThreadSafe]
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig); // 0x000000018D4B5868-0x000000018D4B58BC
		public static IntPtr NewString(string chars); // 0x000000018D4B5CE8-0x000000018D4B5CF4
		[ThreadSafe]
		private static IntPtr NewStringFromStr(string chars); // 0x000000018D4B5CB4-0x000000018D4B5CE8
		[ThreadSafe]
		public static string GetStringChars(IntPtr str); // 0x000000018D4B5AEC-0x000000018D4B5B20
		[ThreadSafe]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B5064-0x000000018D4B50B8
		[ThreadSafe]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4BCC-0x000000018D4B4C20
		[ThreadSafe]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4B24-0x000000018D4B4B78
		[ThreadSafe]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B49D4-0x000000018D4B4A28
		[ThreadSafe]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4C74-0x000000018D4B4CC8
		[ThreadSafe]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4C20-0x000000018D4B4C74
		[ThreadSafe]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4A28-0x000000018D4B4A7C
		[ThreadSafe]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4AD0-0x000000018D4B4B24
		[ThreadSafe]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4A7C-0x000000018D4B4AD0
		[ThreadSafe]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B4B78-0x000000018D4B4BCC
		[ThreadSafe]
		public static string GetStringField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B5B20-0x000000018D4B5B64
		[ThreadSafe]
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B56D0-0x000000018D4B5714
		[ThreadSafe]
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B541C-0x000000018D4B5460
		[ThreadSafe]
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B5714-0x000000018D4B5758
		[ThreadSafe]
		public static char GetCharField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B5460-0x000000018D4B54A4
		[ThreadSafe]
		public static short GetShortField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B5758-0x000000018D4B579C
		[ThreadSafe]
		public static int GetIntField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B5580-0x000000018D4B55C4
		[ThreadSafe]
		public static long GetLongField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B55C4-0x000000018D4B5608
		[ThreadSafe]
		public static float GetFloatField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B553C-0x000000018D4B5580
		[ThreadSafe]
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B54A4-0x000000018D4B54E8
		[ThreadSafe]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4FBC-0x000000018D4B5010
		[ThreadSafe]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4EC0-0x000000018D4B4F14
		[ThreadSafe]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4E18-0x000000018D4B4E6C
		[ThreadSafe]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4CC8-0x000000018D4B4D1C
		[ThreadSafe]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4F68-0x000000018D4B4FBC
		[ThreadSafe]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4F14-0x000000018D4B4F68
		[ThreadSafe]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4D1C-0x000000018D4B4D70
		[ThreadSafe]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4DC4-0x000000018D4B4E18
		[ThreadSafe]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4D70-0x000000018D4B4DC4
		[ThreadSafe]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4E6C-0x000000018D4B4EC0
		[ThreadSafe]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B5010-0x000000018D4B5064
		[ThreadSafe]
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B5AA8-0x000000018D4B5AEC
		[ThreadSafe]
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B59DC-0x000000018D4B5A20
		[ThreadSafe]
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B579C-0x000000018D4B57E0
		[ThreadSafe]
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B5A20-0x000000018D4B5A64
		[ThreadSafe]
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B57E0-0x000000018D4B5824
		[ThreadSafe]
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B5A64-0x000000018D4B5AA8
		[ThreadSafe]
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B5900-0x000000018D4B5944
		[ThreadSafe]
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B5944-0x000000018D4B5988
		[ThreadSafe]
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B58BC-0x000000018D4B5900
		[ThreadSafe]
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B5824-0x000000018D4B5868
		[ThreadSafe]
		public static IntPtr ToBooleanArray(bool[] array); // 0x000000018D4B5DE0-0x000000018D4B5E14
		[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
		[ThreadSafe]
		public static IntPtr ToByteArray(byte[] array); // 0x000000018D4B5E14-0x000000018D4B5E48
		[ThreadSafe]
		public static IntPtr ToSByteArray([Unmarshalled] sbyte[] array); // 0x000000018D4B5F90-0x000000018D4B5FC4
		[ThreadSafe]
		public static IntPtr ToCharArray([Unmarshalled] char[] array); // 0x000000018D4B5E48-0x000000018D4B5E7C
		[ThreadSafe]
		public static IntPtr ToShortArray([Unmarshalled] short[] array); // 0x000000018D4B5FC4-0x000000018D4B5FF8
		[ThreadSafe]
		public static IntPtr ToIntArray([Unmarshalled] int[] array); // 0x000000018D4B5EE4-0x000000018D4B5F18
		[ThreadSafe]
		public static IntPtr ToLongArray([Unmarshalled] long[] array); // 0x000000018D4B5F18-0x000000018D4B5F4C
		[ThreadSafe]
		public static IntPtr ToFloatArray([Unmarshalled] float[] array); // 0x000000018D4B5EB0-0x000000018D4B5EE4
		[ThreadSafe]
		public static IntPtr ToDoubleArray([Unmarshalled] double[] array); // 0x000000018D4B5E7C-0x000000018D4B5EB0
		[ThreadSafe]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass); // 0x000000018D4B5F4C-0x000000018D4B5F90
		[ThreadSafe]
		public static bool[] FromBooleanArray(IntPtr array); // 0x000000018D4B51E0-0x000000018D4B5214
		[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
		[ThreadSafe]
		public static byte[] FromByteArray(IntPtr array); // 0x000000018D4B5214-0x000000018D4B5248
		[ThreadSafe]
		public static sbyte[] FromSByteArray(IntPtr array); // 0x000000018D4B5380-0x000000018D4B53B4
		[ThreadSafe]
		public static char[] FromCharArray(IntPtr array); // 0x000000018D4B5248-0x000000018D4B527C
		[ThreadSafe]
		public static short[] FromShortArray(IntPtr array); // 0x000000018D4B53B4-0x000000018D4B53E8
		[ThreadSafe]
		public static int[] FromIntArray(IntPtr array); // 0x000000018D4B52E4-0x000000018D4B5318
		[ThreadSafe]
		public static long[] FromLongArray(IntPtr array); // 0x000000018D4B5318-0x000000018D4B534C
		[ThreadSafe]
		public static float[] FromFloatArray(IntPtr array); // 0x000000018D4B52B0-0x000000018D4B52E4
		[ThreadSafe]
		public static double[] FromDoubleArray(IntPtr array); // 0x000000018D4B527C-0x000000018D4B52B0
		[ThreadSafe]
		public static int GetArrayLength(IntPtr array); // 0x000000018D4B53E8-0x000000018D4B541C
		[ThreadSafe]
		public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj); // 0x000000018D4B5C10-0x000000018D4B5C60
		[ThreadSafe]
		public static IntPtr GetObjectArrayElement(IntPtr array, int index); // 0x000000018D4B565C-0x000000018D4B569C
		[ThreadSafe]
		public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj); // 0x000000018D4B5D90-0x000000018D4B5DE0
	}

	internal class AndroidJNISafe // TypeDefIndex: 89740
	{
		// Methods
		public static void CheckException(); // 0x000000018D4B2B94-0x000000018D4B2DDC
		public static void DeleteGlobalRef(IntPtr globalref); // 0x000000018D4B2DDC-0x000000018D4B2DEC
		public static void DeleteWeakGlobalRef(IntPtr globalref); // 0x000000018D4B2DFC-0x000000018D4B2E0C
		public static void DeleteLocalRef(IntPtr localref); // 0x000000018D4B2DEC-0x000000018D4B2DFC
		public static IntPtr NewString(string chars); // 0x000000018D4B43D0-0x000000018D4B445C
		public static string GetStringChars(IntPtr str); // 0x000000018D4B422C-0x000000018D4B42B8
		public static IntPtr GetObjectClass(IntPtr ptr); // 0x000000018D4B3984-0x000000018D4B3A10
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig); // 0x000000018D4B3F7C-0x000000018D4B4008
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig); // 0x000000018D4B386C-0x000000018D4B38F8
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig); // 0x000000018D4B3638-0x000000018D4B36C4
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig); // 0x000000018D4B3D48-0x000000018D4B3DD4
		public static IntPtr FromReflectedMethod(IntPtr refMethod); // 0x000000018D4B326C-0x000000018D4B32F8
		public static IntPtr FindClass(string name); // 0x000000018D4B2E0C-0x000000018D4B2E98
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B4344-0x000000018D4B43D0
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B4008-0x000000018D4B4094
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B41A0-0x000000018D4B422C
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B3C2C-0x000000018D4B3CB4
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B3CB4-0x000000018D4B3D48
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B3DD4-0x000000018D4B3E68
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B3EF0-0x000000018D4B3F7C
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B4118-0x000000018D4B41A0
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B4094-0x000000018D4B4118
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B3BA8-0x000000018D4B3C2C
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID); // 0x000000018D4B3E68-0x000000018D4B3EF0
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2A98-0x000000018D4B2B08
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2874-0x000000018D4B2900
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2A0C-0x000000018D4B2A98
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B25B0-0x000000018D4B2638
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2638-0x000000018D4B26CC
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B26CC-0x000000018D4B2760
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B27E8-0x000000018D4B2874
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2984-0x000000018D4B2A0C
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2900-0x000000018D4B2984
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B252C-0x000000018D4B25B0
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args); // 0x000000018D4B2760-0x000000018D4B27E8
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B3A10-0x000000018D4B3A9C
		public static string GetStringField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B42B8-0x000000018D4B4344
		public static char GetCharField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B351C-0x000000018D4B35A4
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B35A4-0x000000018D4B3638
		public static float GetFloatField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B36C4-0x000000018D4B3758
		public static long GetLongField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B37E0-0x000000018D4B386C
		public static short GetShortField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B3B20-0x000000018D4B3BA8
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B3A9C-0x000000018D4B3B20
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B3498-0x000000018D4B351C
		public static int GetIntField(IntPtr obj, IntPtr fieldID); // 0x000000018D4B3758-0x000000018D4B37E0
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B2394-0x000000018D4B2420
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B2B08-0x000000018D4B2B94
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B20D0-0x000000018D4B2158
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B2158-0x000000018D4B21EC
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B21EC-0x000000018D4B2280
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B2308-0x000000018D4B2394
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B24A4-0x000000018D4B252C
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B2420-0x000000018D4B24A4
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B204C-0x000000018D4B20D0
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args); // 0x000000018D4B2280-0x000000018D4B2308
		public static char[] FromCharArray(IntPtr array); // 0x000000018D4B2FB0-0x000000018D4B303C
		public static double[] FromDoubleArray(IntPtr array); // 0x000000018D4B303C-0x000000018D4B30C8
		public static float[] FromFloatArray(IntPtr array); // 0x000000018D4B30C8-0x000000018D4B3154
		public static long[] FromLongArray(IntPtr array); // 0x000000018D4B31E0-0x000000018D4B326C
		public static short[] FromShortArray(IntPtr array); // 0x000000018D4B3384-0x000000018D4B3410
		public static byte[] FromByteArray(IntPtr array); // 0x000000018D4B2F24-0x000000018D4B2FB0
		public static sbyte[] FromSByteArray(IntPtr array); // 0x000000018D4B32F8-0x000000018D4B3384
		public static bool[] FromBooleanArray(IntPtr array); // 0x000000018D4B2E98-0x000000018D4B2F24
		public static int[] FromIntArray(IntPtr array); // 0x000000018D4B3154-0x000000018D4B31E0
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type); // 0x000000018D4B4830-0x000000018D4B48BC
		public static IntPtr ToCharArray(char[] array); // 0x000000018D4B4574-0x000000018D4B4600
		public static IntPtr ToDoubleArray(double[] array); // 0x000000018D4B4600-0x000000018D4B468C
		public static IntPtr ToFloatArray(float[] array); // 0x000000018D4B468C-0x000000018D4B4718
		public static IntPtr ToLongArray(long[] array); // 0x000000018D4B47A4-0x000000018D4B4830
		public static IntPtr ToShortArray(short[] array); // 0x000000018D4B4948-0x000000018D4B49D4
		public static IntPtr ToByteArray(byte[] array); // 0x000000018D4B44E8-0x000000018D4B4574
		public static IntPtr ToSByteArray(sbyte[] array); // 0x000000018D4B48BC-0x000000018D4B4948
		public static IntPtr ToBooleanArray(bool[] array); // 0x000000018D4B445C-0x000000018D4B44E8
		public static IntPtr ToIntArray(int[] array); // 0x000000018D4B4718-0x000000018D4B47A4
		public static IntPtr GetObjectArrayElement(IntPtr array, int index); // 0x000000018D4B38F8-0x000000018D4B3984
		public static int GetArrayLength(IntPtr array); // 0x000000018D4B3410-0x000000018D4B3498
	}
}

namespace UnityEngine.Android
{
	internal static class Common // TypeDefIndex: 89741
	{
		// Fields
		private static AndroidJavaObject m_Activity; // 0x00
	
		// Methods
		public static AndroidJavaObject GetActivity(); // 0x000000018D4B82A4-0x000000018D4B8450
	}
}
