/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;

// Image 75: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59848-59862

namespace UnityEngine
{
	public delegate void AndroidJavaRunnable(); // TypeDefIndex: 59849; 0x00000001864BC320-0x00000001864BC330

	public sealed class AndroidJavaException : Exception // TypeDefIndex: 59850
	{
		// Fields
		private string mJavaStackTrace; // 0x90
	
		// Properties
		public override string StackTrace { get => default; } // 0x000000018BE9B3F8-0x000000018BE9B424 
	
		// Constructors
		public AndroidJavaException() {} // Dummy constructor
		internal AndroidJavaException(string message, string javaStackTrace) {} // 0x000000018BE9B388-0x000000018BE9B3F8
	}

	internal class GlobalJavaObjectRef // TypeDefIndex: 59851
	{
		// Fields
		private bool m_disposed; // 0x10
		protected IntPtr m_jobject; // 0x18
	
		// Constructors
		public GlobalJavaObjectRef() {} // Dummy constructor
		public GlobalJavaObjectRef(IntPtr jobject) {} // 0x000000018BE9D834-0x000000018BE9D860
	
		// Methods
		~GlobalJavaObjectRef() {} // 0x000000018BE9D7C4-0x000000018BE9D834
		public static implicit operator IntPtr(GlobalJavaObjectRef obj) => default; // 0x00000001864C22B8-0x00000001864C22D0
		public void Dispose() {} // 0x000000018BE9D79C-0x000000018BE9D7C4
	}

	internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 59852
	{
		// Fields
		private AndroidJavaRunnable mRunnable; // 0x20
	
		// Constructors
		public AndroidJavaRunnableProxy() {} // Dummy constructor
		public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable) {} // 0x000000018BE9C9AC-0x000000018BE9CA1C
	}

	public class AndroidJavaProxy // TypeDefIndex: 59853
	{
		// Fields
		public readonly AndroidJavaClass javaInterface; // 0x10
		internal IntPtr proxyObject; // 0x18
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x00
		private static readonly IntPtr s_HashCodeMethodID; // 0x08
	
		// Constructors
		public AndroidJavaProxy() {} // Dummy constructor
		public AndroidJavaProxy(string javaInterface) {} // 0x000000018BE9C7DC-0x000000018BE9C854
		public AndroidJavaProxy(AndroidJavaClass javaInterface) {} // 0x000000018BE9C854-0x000000018BE9C86C
		static AndroidJavaProxy() {} // 0x000000018BE9C6D0-0x000000018BE9C7DC
	
		// Methods
		~AndroidJavaProxy() {} // 0x000000018BE9BCC8-0x000000018BE9BD3C
		public virtual AndroidJavaObject Invoke(string methodName, object[] args) => default; // 0x000000018BE9BDB8-0x000000018BE9C5B8
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) => default; // 0x000000018BE9C5B8-0x000000018BE9C6D0
		public virtual bool equals(AndroidJavaObject obj) => default; // 0x000000018BE9C86C-0x000000018BE9C8A0
		public virtual int hashCode() => default; // 0x000000018BE9C8A0-0x000000018BE9C950
		public virtual string toString() => default; // 0x000000018BE9C950-0x000000018BE9C9AC
		internal AndroidJavaObject GetProxyObject() => default; // 0x000000018BE9BD3C-0x000000018BE9BD58
		internal IntPtr GetRawProxy() => default; // 0x000000018BE9BD58-0x000000018BE9BDB8
	}

	public class AndroidJavaObject : IDisposable // TypeDefIndex: 59854
	{
		// Fields
		private static bool enableDebugPrints; // 0x00
		internal GlobalJavaObjectRef m_jobject; // 0x10
		internal GlobalJavaObjectRef m_jclass; // 0x18
	
		// Constructors
		public AndroidJavaObject(string className, object[] args) {} // 0x000000018BE9BCC0-0x000000018BE9BCC8
		internal AndroidJavaObject(IntPtr jobject) {} // 0x000000018BE9BBA0-0x000000018BE9BCC0
		internal AndroidJavaObject() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x000000018BE9B804-0x000000018BE9B854
		public FieldType Get<FieldType>(string fieldName) => default;
		public FieldType GetStatic<FieldType>(string fieldName) => default;
		public IntPtr GetRawObject() => default; // 0x000000018BE9B924-0x000000018BE9B930
		public IntPtr GetRawClass() => default; // 0x000000018BE9B918-0x000000018BE9B924
		public ReturnType Call<ReturnType>(string methodName, object[] args) => default;
		public ReturnType CallStatic<ReturnType>(string methodName, object[] args) => default;
		protected void DebugPrint(string msg) {} // 0x000000018BE9B7A4-0x000000018BE9B804
		private void _AndroidJavaObject(string className, object[] args) {} // 0x000000018BE9B930-0x000000018BE9BB8C
		~AndroidJavaObject() {} // 0x000000018BE9B8A4-0x000000018BE9B918
		protected virtual void Dispose(bool disposing) {} // 0x000000018BE9B854-0x000000018BE9B8A4
		protected ReturnType _Call<ReturnType>(string methodName, object[] args) => default;
		protected FieldType _Get<FieldType>(string fieldName) => default;
		protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) => default;
		protected FieldType _GetStatic<FieldType>(string fieldName) => default;
		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) => default; // 0x000000018BE9B5E4-0x000000018BE9B7A4
		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) => default; // 0x000000018BE9B424-0x000000018BE9B5E4
		internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject) => default;
		protected IntPtr _GetRawObject() => default; // 0x000000018BE9BB8C-0x000000018BE9BBA0
		protected IntPtr _GetRawClass() => default; // 0x00000001882E7F70-0x00000001882E7F8C
	}

	public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 59855
	{
		// Constructors
		public AndroidJavaClass() {} // Dummy constructor
		public AndroidJavaClass(string className) {} // 0x000000018BE9B380-0x000000018BE9B388
		internal AndroidJavaClass(IntPtr jclass) {} // 0x000000018BE9B2A8-0x000000018BE9B380
	
		// Methods
		private void _AndroidJavaClass(string className) {} // 0x000000018BE9B1C8-0x000000018BE9B2A8
	}

	internal class AndroidReflection // TypeDefIndex: 59856
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
		public AndroidReflection() {} // Dummy constructor
		static AndroidReflection() {} // 0x000000018BE9D34C-0x000000018BE9D5F4
	
		// Methods
		public static bool IsPrimitive(System.Type t) => default; // 0x000000018B5EE7A4-0x000000018B5EE7C4
		public static bool IsAssignableFrom(System.Type t, System.Type from) => default; // 0x000000018B7BDDD8-0x000000018B7BDDFC
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) => default; // 0x000000018BE9D0D8-0x000000018BE9D184
		private static IntPtr GetMethodID(string clazz, string methodName, string signature) => default; // 0x000000018BE9CE58-0x000000018BE9CF04
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature) => default; // 0x000000018BE9CA1C-0x000000018BE9CB84
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) => default; // 0x000000018BE9CF04-0x000000018BE9D0D8
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) => default; // 0x000000018BE9CBDC-0x000000018BE9CDB0
		public static IntPtr GetFieldClass(IntPtr field) => default; // 0x000000018BE9CB84-0x000000018BE9CBDC
		public static string GetFieldSignature(IntPtr field) => default; // 0x000000018BE9CDB0-0x000000018BE9CE58
		public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) => default; // 0x000000018BE9D184-0x000000018BE9D260
		public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) {} // 0x000000018BE9D260-0x000000018BE9D34C
	}

	internal sealed class _AndroidJNIHelper // TypeDefIndex: 59857
	{
		// Constructors
		public _AndroidJNIHelper() {} // Dummy constructor
	
		// Methods
		public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) => default; // 0x000000018BE9EE08-0x000000018BE9EE88
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) => default; // 0x000000018BE9EE88-0x000000018BE9EEF0
		public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) => default; // 0x000000018BEA0590-0x000000018BEA082C
		public static jvalue[] CreateJNIArgArray(object[] args) => default; // 0x000000018BE9E874-0x000000018BE9EE08
		public static object UnboxArray(AndroidJavaObject obj) => default; // 0x000000018BEA082C-0x000000018BEA0E14
		public static object Unbox(AndroidJavaObject obj) => default; // 0x000000018BEA0E14-0x000000018BEA1D30
		public static AndroidJavaObject Box(object obj) => default; // 0x000000018BE9D860-0x000000018BE9E1A4
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) {} // 0x000000018BE9EEF0-0x000000018BE9EFE4
		public static IntPtr ConvertToJNIArray(Array array) => default; // 0x000000018BE9E1A4-0x000000018BE9E874
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) => default;
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args) => default; // 0x000000018BE9F190-0x000000018BE9F1BC
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) => default;
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic) => default;
		public static IntPtr GetConstructorID(IntPtr jclass, string signature) => default; // 0x000000018BE9EFE4-0x000000018BE9F190
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) => default; // 0x000000018BE9F5A4-0x000000018BE9F764
		private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) => default; // 0x000000018BE9F51C-0x000000018BE9F5A4
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) => default; // 0x000000018BE9F1BC-0x000000018BE9F51C
		public static string GetSignature(object obj) => default; // 0x000000018BE9F834-0x000000018BEA0590
		public static string GetSignature(object[] args) => default; // 0x000000018BE9F764-0x000000018BE9F834
		public static string GetSignature<ReturnType>(object[] args) => default;
	}

	public struct jvalue // TypeDefIndex: 59858
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

	public static class AndroidJNIHelper // TypeDefIndex: 59859
	{
		// Methods
		public static IntPtr GetConstructorID(IntPtr javaClass, string signature) => default; // 0x000000018BE972A8-0x000000018BE972B4
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) => default; // 0x000000018BE972C4-0x000000018BE972D4
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) => default; // 0x000000018BE972B4-0x000000018BE972C4
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) => default; // 0x000000018BE97288-0x000000018BE97294
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) => default; // 0x000000018BE97174-0x000000018BE97288
		public static jvalue[] CreateJNIArgArray(object[] args) => default; // 0x000000018BE97168-0x000000018BE97174
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) {} // 0x000000018BE97294-0x000000018BE9729C
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args) => default; // 0x000000018BE9729C-0x000000018BE972A8
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) => default;
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) => default;
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic) => default;
	}

	public static class AndroidJNI // TypeDefIndex: 59860
	{
		// Methods
		public static IntPtr FindClass(string name) => default; // 0x000000018BE9A37C-0x000000018BE9A3B0
		public static IntPtr FromReflectedMethod(IntPtr refMethod) => default; // 0x000000018BE9A51C-0x000000018BE9A550
		public static IntPtr ExceptionOccurred() => default; // 0x000000018BE9A350-0x000000018BE9A37C
		public static void ExceptionClear() {} // 0x000000018BE9A324-0x000000018BE9A350
		public static int PushLocalFrame(int capacity) => default; // 0x000000018BE9AF2C-0x000000018BE9AF60
		public static IntPtr PopLocalFrame(IntPtr ptr) => default; // 0x000000018BE9AEF8-0x000000018BE9AF2C
		public static IntPtr NewGlobalRef(IntPtr obj) => default; // 0x000000018BE9AD78-0x000000018BE9ADAC
		public static void DeleteGlobalRef(IntPtr obj) {} // 0x000000018BE9A288-0x000000018BE9A2BC
		public static IntPtr NewWeakGlobalRef(IntPtr obj) => default; // 0x000000018BE9AEC4-0x000000018BE9AEF8
		public static void DeleteWeakGlobalRef(IntPtr obj) {} // 0x000000018BE9A2F0-0x000000018BE9A324
		public static IntPtr NewLocalRef(IntPtr obj) => default; // 0x000000018BE9ADAC-0x000000018BE9ADE0
		public static void DeleteLocalRef(IntPtr obj) {} // 0x000000018BE9A2BC-0x000000018BE9A2F0
		public static bool IsSameObject(IntPtr obj1, IntPtr obj2) => default; // 0x000000018BE9AD34-0x000000018BE9AD78
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9AE30-0x000000018BE9AE84
		public static IntPtr GetObjectClass(IntPtr obj) => default; // 0x000000018BE9A86C-0x000000018BE9A8A0
		public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE9A7D8-0x000000018BE9A82C
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE9A6B8-0x000000018BE9A70C
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE9AB58-0x000000018BE9ABAC
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE9AA38-0x000000018BE9AA8C
		public static IntPtr NewString(string chars) => default; // 0x000000018BE9AEB8-0x000000018BE9AEC4
		private static IntPtr NewStringFromStr(string chars) => default; // 0x000000018BE9AE84-0x000000018BE9AEB8
		public static string GetStringChars(IntPtr str) => default; // 0x000000018BE9ACBC-0x000000018BE9ACF0
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9A234-0x000000018BE9A288
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99D9C-0x000000018BE99DF0
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99CF4-0x000000018BE99D48
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99BA4-0x000000018BE99BF8
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99E44-0x000000018BE99E98
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99DF0-0x000000018BE99E44
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99BF8-0x000000018BE99C4C
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99CA0-0x000000018BE99CF4
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99C4C-0x000000018BE99CA0
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99D48-0x000000018BE99D9C
		public static string GetStringField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9ACF0-0x000000018BE9AD34
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A8A0-0x000000018BE9A8E4
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A5EC-0x000000018BE9A630
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A8E4-0x000000018BE9A928
		public static char GetCharField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A630-0x000000018BE9A674
		public static short GetShortField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A928-0x000000018BE9A96C
		public static int GetIntField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A750-0x000000018BE9A794
		public static long GetLongField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A794-0x000000018BE9A7D8
		public static float GetFloatField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A70C-0x000000018BE9A750
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9A674-0x000000018BE9A6B8
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9A18C-0x000000018BE9A1E0
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9A090-0x000000018BE9A0E4
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99FE8-0x000000018BE9A03C
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99E98-0x000000018BE99EEC
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9A138-0x000000018BE9A18C
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9A0E4-0x000000018BE9A138
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99EEC-0x000000018BE99F40
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99F94-0x000000018BE99FE8
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE99F40-0x000000018BE99F94
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9A03C-0x000000018BE9A090
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) {} // 0x000000018BE9A1E0-0x000000018BE9A234
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9AC78-0x000000018BE9ACBC
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9ABAC-0x000000018BE9ABF0
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9A96C-0x000000018BE9A9B0
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9ABF0-0x000000018BE9AC34
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9A9B0-0x000000018BE9A9F4
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9AC34-0x000000018BE9AC78
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9AAD0-0x000000018BE9AB14
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9AB14-0x000000018BE9AB58
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9AA8C-0x000000018BE9AAD0
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE9A9F4-0x000000018BE9AA38
		public static IntPtr ToBooleanArray(bool[] array) => default; // 0x000000018BE9AFB0-0x000000018BE9AFE4
		public static IntPtr ToByteArray(byte[] array) => default; // 0x000000018BE9AFE4-0x000000018BE9B018
		public static IntPtr ToSByteArray(sbyte[] array) => default; // 0x000000018BE9B160-0x000000018BE9B194
		public static IntPtr ToCharArray(char[] array) => default; // 0x000000018BE9B018-0x000000018BE9B04C
		public static IntPtr ToShortArray(short[] array) => default; // 0x000000018BE9B194-0x000000018BE9B1C8
		public static IntPtr ToIntArray(int[] array) => default; // 0x000000018BE9B0B4-0x000000018BE9B0E8
		public static IntPtr ToLongArray(long[] array) => default; // 0x000000018BE9B0E8-0x000000018BE9B11C
		public static IntPtr ToFloatArray(float[] array) => default; // 0x000000018BE9B080-0x000000018BE9B0B4
		public static IntPtr ToDoubleArray(double[] array) => default; // 0x000000018BE9B04C-0x000000018BE9B080
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) => default; // 0x000000018BE9B11C-0x000000018BE9B160
		public static bool[] FromBooleanArray(IntPtr array) => default; // 0x000000018BE9A3B0-0x000000018BE9A3E4
		public static byte[] FromByteArray(IntPtr array) => default; // 0x000000018BE9A3E4-0x000000018BE9A418
		public static sbyte[] FromSByteArray(IntPtr array) => default; // 0x000000018BE9A550-0x000000018BE9A584
		public static char[] FromCharArray(IntPtr array) => default; // 0x000000018BE9A418-0x000000018BE9A44C
		public static short[] FromShortArray(IntPtr array) => default; // 0x000000018BE9A584-0x000000018BE9A5B8
		public static int[] FromIntArray(IntPtr array) => default; // 0x000000018BE9A4B4-0x000000018BE9A4E8
		public static long[] FromLongArray(IntPtr array) => default; // 0x000000018BE9A4E8-0x000000018BE9A51C
		public static float[] FromFloatArray(IntPtr array) => default; // 0x000000018BE9A480-0x000000018BE9A4B4
		public static double[] FromDoubleArray(IntPtr array) => default; // 0x000000018BE9A44C-0x000000018BE9A480
		public static int GetArrayLength(IntPtr array) => default; // 0x000000018BE9A5B8-0x000000018BE9A5EC
		public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) => default; // 0x000000018BE9ADE0-0x000000018BE9AE30
		public static IntPtr GetObjectArrayElement(IntPtr array, int index) => default; // 0x000000018BE9A82C-0x000000018BE9A86C
		public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) {} // 0x000000018BE9AF60-0x000000018BE9AFB0
	}

	internal class AndroidJNISafe // TypeDefIndex: 59861
	{
		// Constructors
		public AndroidJNISafe() {} // Dummy constructor
	
		// Methods
		public static void CheckException() {} // 0x000000018BE97DDC-0x000000018BE980C8
		public static void DeleteGlobalRef(IntPtr globalref) {} // 0x000000018BE980C8-0x000000018BE980D8
		public static void DeleteWeakGlobalRef(IntPtr globalref) {} // 0x000000018BE980E8-0x000000018BE980F8
		public static void DeleteLocalRef(IntPtr localref) {} // 0x000000018BE980D8-0x000000018BE980E8
		public static IntPtr NewString(string chars) => default; // 0x000000018BE995F4-0x000000018BE99678
		public static string GetStringChars(IntPtr str) => default; // 0x000000018BE99460-0x000000018BE994E4
		public static IntPtr GetObjectClass(IntPtr ptr) => default; // 0x000000018BE98BF0-0x000000018BE98C74
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE991C0-0x000000018BE99248
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig) => default; // 0x000000018BE98AE0-0x000000018BE98B68
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE988C0-0x000000018BE98948
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) => default; // 0x000000018BE98FA0-0x000000018BE99028
		public static IntPtr FromReflectedMethod(IntPtr refMethod) => default; // 0x000000018BE98518-0x000000018BE9859C
		public static IntPtr FindClass(string name) => default; // 0x000000018BE980F8-0x000000018BE9817C
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE9956C-0x000000018BE995F4
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE99248-0x000000018BE992D0
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE993D8-0x000000018BE99460
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE98E84-0x000000018BE98F0C
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE98F0C-0x000000018BE98FA0
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE99028-0x000000018BE990B8
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE99138-0x000000018BE991C0
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE99350-0x000000018BE993D8
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE992D0-0x000000018BE99350
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE98E04-0x000000018BE98E84
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) => default; // 0x000000018BE990B8-0x000000018BE99138
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) {} // 0x000000018BE97CE4-0x000000018BE97D54
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97ACC-0x000000018BE97B54
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97C5C-0x000000018BE97CE4
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97818-0x000000018BE978A0
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE978A0-0x000000018BE97934
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97934-0x000000018BE979C4
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97A44-0x000000018BE97ACC
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97BD4-0x000000018BE97C5C
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97B54-0x000000018BE97BD4
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97798-0x000000018BE97818
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE979C4-0x000000018BE97A44
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE98C74-0x000000018BE98CFC
		public static string GetStringField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE994E4-0x000000018BE9956C
		public static char GetCharField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE987A4-0x000000018BE9882C
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE9882C-0x000000018BE988C0
		public static float GetFloatField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE98948-0x000000018BE989D8
		public static long GetLongField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE98A58-0x000000018BE98AE0
		public static short GetShortField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE98D7C-0x000000018BE98E04
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE98CFC-0x000000018BE98D7C
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE98724-0x000000018BE987A4
		public static int GetIntField(IntPtr obj, IntPtr fieldID) => default; // 0x000000018BE989D8-0x000000018BE98A58
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97608-0x000000018BE97690
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97D54-0x000000018BE97DDC
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97354-0x000000018BE973DC
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE973DC-0x000000018BE97470
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97470-0x000000018BE97500
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97580-0x000000018BE97608
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97710-0x000000018BE97798
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97690-0x000000018BE97710
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE972D4-0x000000018BE97354
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) => default; // 0x000000018BE97500-0x000000018BE97580
		public static char[] FromCharArray(IntPtr array) => default; // 0x000000018BE98284-0x000000018BE98308
		public static double[] FromDoubleArray(IntPtr array) => default; // 0x000000018BE98308-0x000000018BE9838C
		public static float[] FromFloatArray(IntPtr array) => default; // 0x000000018BE9838C-0x000000018BE98410
		public static long[] FromLongArray(IntPtr array) => default; // 0x000000018BE98494-0x000000018BE98518
		public static short[] FromShortArray(IntPtr array) => default; // 0x000000018BE98620-0x000000018BE986A4
		public static byte[] FromByteArray(IntPtr array) => default; // 0x000000018BE98200-0x000000018BE98284
		public static sbyte[] FromSByteArray(IntPtr array) => default; // 0x000000018BE9859C-0x000000018BE98620
		public static bool[] FromBooleanArray(IntPtr array) => default; // 0x000000018BE9817C-0x000000018BE98200
		public static int[] FromIntArray(IntPtr array) => default; // 0x000000018BE98410-0x000000018BE98494
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) => default; // 0x000000018BE99A14-0x000000018BE99A9C
		public static IntPtr ToCharArray(char[] array) => default; // 0x000000018BE99780-0x000000018BE99804
		public static IntPtr ToDoubleArray(double[] array) => default; // 0x000000018BE99804-0x000000018BE99888
		public static IntPtr ToFloatArray(float[] array) => default; // 0x000000018BE99888-0x000000018BE9990C
		public static IntPtr ToLongArray(long[] array) => default; // 0x000000018BE99990-0x000000018BE99A14
		public static IntPtr ToShortArray(short[] array) => default; // 0x000000018BE99B20-0x000000018BE99BA4
		public static IntPtr ToByteArray(byte[] array) => default; // 0x000000018BE996FC-0x000000018BE99780
		public static IntPtr ToSByteArray(sbyte[] array) => default; // 0x000000018BE99A9C-0x000000018BE99B20
		public static IntPtr ToBooleanArray(bool[] array) => default; // 0x000000018BE99678-0x000000018BE996FC
		public static IntPtr ToIntArray(int[] array) => default; // 0x000000018BE9990C-0x000000018BE99990
		public static IntPtr GetObjectArrayElement(IntPtr array, int index) => default; // 0x000000018BE98B68-0x000000018BE98BF0
		public static int GetArrayLength(IntPtr array) => default; // 0x000000018BE986A4-0x000000018BE98724
	}
}

namespace UnityEngine.Android
{
	internal static class Common // TypeDefIndex: 59862
	{
		// Fields
		private static AndroidJavaObject m_Activity; // 0x00
	
		// Methods
		public static AndroidJavaObject GetActivity() => default; // 0x000000018BE9D5F4-0x000000018BE9D79C
	}
}
