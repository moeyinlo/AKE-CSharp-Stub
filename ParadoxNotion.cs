/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Beyond;
using FlowCanvas;
using FlowCanvas.Macros;
using FlowCanvas.Nodes;
using IFix.Core;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using NodeCanvas.StateMachines;
using ParadoxNotion;
using ParadoxNotion.Animation;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using ParadoxNotion.Services;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Image 15: ParadoxNotion.dll - Assembly: ParadoxNotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 48126-49460

public class SetEnumFlag : ActionTask // TypeDefIndex: 48127
{
	// Fields
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70
	public readonly BBParameter<bool> Clear; // 0x78

	// Properties
	protected override string info { get => default; } // 0x000000018B45533C-0x000000018B4553D4 

	// Constructors
	public SetEnumFlag() {} // 0x000000018B455210-0x000000018B45533C

	// Methods
	protected override void OnExecute() {} // 0x000000018B45509C-0x000000018B455210
}

public class CheckEnumFlag : ConditionTask // TypeDefIndex: 48128
{
	// Fields
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70

	// Properties
	protected override string info { get => default; } // 0x000000018B447E74-0x000000018B447EB8 

	// Constructors
	public CheckEnumFlag() {} // 0x000000018B447D84-0x000000018B447E74

	// Methods
	protected override bool OnCheck() => default; // 0x000000018B447CCC-0x000000018B447D84
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 48130
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 48131
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 48132
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 48133
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 48134
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace FlowCanvas
{
	public class BinderConnection<T> : BinderConnection // TypeDefIndex: 48135
	{
		// Constructors
		public BinderConnection() {}
	
		// Methods
		public override void Bind() {}
		public override void UnBind() {}
	}

	public class BinderConnection : Connection // TypeDefIndex: 48137
	{
		// Fields
		private string _sourcePortID; // 0x30
		private string _targetPortID; // 0x38
		[NonSerialized]
		private Port _sourcePort; // 0x40
		[NonSerialized]
		private Port _targetPort; // 0x48
	
		// Properties
		public string sourcePortID { get => default; private set {} } // 0x000000018B44612C-0x000000018B4461D8 0x000000018B446214-0x000000018B4462C0
		public string targetPortID { get => default; private set {} } // 0x000000018B446020-0x000000018B4460F0 0x000000018B444DB8-0x000000018B4452D4
		public Port sourcePort { get => default; } // 0x000000018B445CDC-0x000000018B445E38 
		public Port targetPort { get => default; } // 0x000000018B445E38-0x000000018B445F94 
		public System.Type bindingType { get => default; } // 0x000000018B4452D4-0x000000018B4456BC 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48136
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueHandlerObject __9__19_0; // 0x08
			public static FlowHandler __9__20_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B4460F0-0x000000018B44612C
			public __c() {} // 0x00000001864721F0-0x0000000186472200
	
			// Methods
			internal object _GatherAndValidateSourcePort_b__19_0() => default; // 0x000000018B4461D8-0x000000018B446214
			internal void _GatherAndValidateTargetPort_b__20_0(Flow f) {} // 0x0000000185A16440-0x0000000185A16450
		}
	
		// Constructors
		public BinderConnection() {} // 0x000000018B4584B4-0x000000018B458510
	
		// Methods
		public static BinderConnection Create(Port source, Port target, bool recodeUndo = true /* Metadata: 0x02060CF7 */, bool invokeGraphChanged = true /* Metadata: 0x02060CF8 */) => default; // 0x000000018B4456BC-0x000000018B445B40
		public void SetSourcePort(Port newSourcePort) {} // 0x000000018B444D98-0x000000018B444DB8
		public void SetTargetPort(Port newTargetPort) {} // 0x000000018B444D6C-0x000000018B444D98
		public void GatherAndValidateSourcePort() {} // 0x000000018B444AF4-0x000000018B444D6C
		public void GatherAndValidateTargetPort() {} // 0x000000018B445BD4-0x000000018B445CDC
		public static bool CanBeBound(Port source, Port target, BinderConnection refConnection) => default; // 0x000000018B445B40-0x000000018B445BD4
		public static bool CanBeBoundVerbosed(Port source, Port target, BinderConnection refConnection, out string verbose) {
			verbose = default;
			return default;
		} // 0x000000018B4449D4-0x000000018B444AF4
		private static string CanBeBoundVerbosed_Internal(Port source, Port target, BinderConnection refConnection) => default; // 0x000000018B445F94-0x000000018B446020
		public override void OnDestroy() {} // 0x0000000185FBE310-0x0000000185FBE320
		public override void OnDestroyAfterConnectionRemoved() {} // 0x000000018B458B54-0x000000018B458BB8
		public virtual void Bind() {} // 0x0000000185492010-0x0000000185492020
		public virtual void UnBind() {} // 0x000000018B458458-0x000000018B4584B4
	}

	public delegate void FlowHandler(Flow f); // TypeDefIndex: 48138; 0x00000001833DBC00-0x00000001833DBC40

	public delegate T ValueHandler<T>(); // TypeDefIndex: 48139; 0x00000000-0x00000000

	public delegate object ValueHandlerObject(); // TypeDefIndex: 48140; 0x0000000183683B30-0x0000000183683B40

	public delegate void FlowBreak(); // TypeDefIndex: 48141; 0x00000001864BC320-0x00000001864BC330

	public delegate void FlowReturn(object value); // TypeDefIndex: 48142; 0x00000001833EEC70-0x00000001833EEC80

	public struct Flow // TypeDefIndex: 48144
	{
		// Fields
		private int _ticks_k__BackingField; // 0x00
		private Dictionary<string, object> parameters; // 0x08
		private ReturnData returnData; // 0x10
		private FlowBreak breakCall; // 0x20
	
		// Properties
		public int ticks { get; internal set; } // 0x000000018B44FB80-0x000000018B44FBB8
		public static Flow New { get => default; } // 0x000000018B44F9F8-0x000000018B44FB80 
	
		// Nested types
		public struct ReturnData // TypeDefIndex: 48143
		{
			// Fields
			private FlowReturn _returnCall_k__BackingField; // 0x00
			private System.Type _returnType_k__BackingField; // 0x08
	
			// Properties
			public FlowReturn returnCall { get; private set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
			public System.Type returnType { get; private set; } // 0x0000000185FC9760-0x0000000185FC9780 0x000000018B44F998-0x000000018B44F9DC
	
			// Constructors
			public ReturnData(FlowReturn call, System.Type type) : this() {
				<returnCall>k__BackingField = default;
				<returnType>k__BackingField = default;
			}
		}
	
		// Methods
		public void Call(FlowOutput port) {} // 0x000000018646EE40-0x000000018646EE50
		public T ReadParameter<T>(string name) => default; // 0x000000018B44F9DC-0x000000018B44F9F8
		public void WriteParameter<T>(string name, T value) {} // 0x000000018B44F940-0x000000018B44F998
		public void SetReturnData(FlowReturn call, System.Type expectedType) {} // 0x00000001834AFB60-0x00000001834AFB70
		public void Return(object value, FlowNode context) {} // 0x000000018646FE2C-0x000000018646FE34
		public void BeginBreakBlock(FlowBreak callback) {} // 0x000000018357A260-0x000000018357A270
		public void EndBreakBlock() {} // 0x00000001877900A4-0x00000001877900B4
		public void Break(FlowNode context) {} // 0x000000018523F5B0-0x000000018523F5E0
	}

	[Serializable]
	public abstract class FlowGraph : NodeCanvas.Framework.Graph // TypeDefIndex: 48145
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private List<MacroNodeWrapper> macroWrappers; // 0xA8
		private Dictionary<string, IInvokable> functions; // 0xB0
		private Dictionary<System.Type, Component> cachedAgentComponents; // 0xB8
	
		// Properties
		public override System.Type baseNodeType { get; } // 0x000000018B44BFD0-0x000000018B44C020 
		public override bool allowBlackboardOverrides { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool requiresAgent { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool requiresPrimeNode { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool isTree { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool canAcceptVariableDrops { get; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		protected FlowGraph() {} // 0x000000018B44BF84-0x000000018B44BFD0
	
		// Methods
		public T CallFunction<T>(string name, object[] args) => default;
		public object CallFunction(string name, object[] args) => default; // 0x000000018B44B430-0x000000018B44B508
		public void CallFunctionAsync(string name, Action<object> callback, object[] args) {} // 0x000000018B44B350-0x000000018B44B430
		public UnityEngine.Object GetAgentComponent(System.Type type) => default; // 0x000000018B44B508-0x000000018B44B7A8
		protected override void OnGraphInitialize() {} // 0x000000018B44B8A8-0x000000018B44BCBC
		private void InitSecondPass() {} // 0x000000018B44B7A8-0x000000018B44B8A8
		protected override void OnGraphStarted() {} // 0x000000018B44BCBC-0x000000018B44BDCC
		protected override void OnGraphUpdate() {} // 0x000000018B44BEF0-0x000000018B44BF84
		protected override void OnGraphStoped() {} // 0x000000018B44BDCC-0x000000018B44BEF0
	}

	public abstract class FlowNode : NodeCanvas.Framework.Node, ISerializationCallbackReceiver // TypeDefIndex: 48156
	{
		// Fields
		private Dictionary<string, object> _inputPortValues; // 0x98
		[NonSerialized]
		protected Dictionary<string, Port> inputPorts; // 0xA0
		[NonSerialized]
		protected Dictionary<string, Port> outputPorts; // 0xA8
	
		// Properties
		public override bool allowDragInContentRect { get; } // 0x0000000185492010-0x0000000185492020 
		protected override float? overrideNodeWidth { get; } // 0x000000018B44CA5C-0x000000018B44CB10 
		public sealed override int maxInConnections { get; } // 0x000000018B44F014-0x000000018B44F0C8 
		public sealed override int maxOutConnections { get; } // 0x000000018B44D674-0x000000018B44D7CC 
		public sealed override bool allowAsPrime { get; } // 0x000000018B44D8EC-0x000000018B44DA44 
		public sealed override bool canSelfConnect { get; } // 0x000000018B44D1C4-0x000000018B44D254 
		public sealed override System.Type outConnectionType { get; } // 0x000000018B44D884-0x000000018B44D8EC 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x000000018B44DA44-0x000000018B44DAAC 
		public override Alignment2x2 iconAlignment { get; } // 0x000000018B44D60C-0x000000018B44D674 
		public FlowGraph flowGraph { get; } // 0x000000018B44D7CC-0x000000018B44D834 
		protected string SPACE { get; } // 0x000000018B44D254-0x000000018B44D430 
		public virtual bool ignoreSelfInstancePortAssignment { get; } // 0x000000018B44D430-0x000000018B44D60C 
	
		// Nested types
		public class ContextDefinedInputsAttribute : Attribute // TypeDefIndex: 48146
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedInputsAttribute() {} // Dummy constructor
			public ContextDefinedInputsAttribute(System.Type[] types) {} // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		public class ContextDefinedOutputsAttribute : Attribute // TypeDefIndex: 48147
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedOutputsAttribute() {} // Dummy constructor
			public ContextDefinedOutputsAttribute(System.Type[] types) {} // 0x000000018B44F550-0x000000018B44F590
		}
	
		public class HasRefreshButtonAttribute : Attribute // TypeDefIndex: 48148
		{
			// Constructors
			public HasRefreshButtonAttribute() {} // 0x0000000185FBE2F0-0x0000000185FBE300
		}
	
		public class GatherPortsCallbackAttribute : CallbackAttribute // TypeDefIndex: 48149
		{
			// Constructors
			public GatherPortsCallbackAttribute() {} // 0x0000000185FBE2F0-0x0000000185FBE300
		}
	
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 48150
		{
			// Fields
			public FlowNode __4__this; // 0x10
			public string ID; // 0x18
	
			// Constructors
			public __c__DisplayClass43_0() {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			internal bool _GetInputPort_b__0(Port p) => default; // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 48151
		{
			// Fields
			public FlowNode __4__this; // 0x10
			public string ID; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0() {} // 0x000000018B44F500-0x000000018B44F550
	
			// Methods
			internal bool _GetOutputPort_b__0(Port p) => default; // 0x0000000181C44E90-0x0000000181C44EA0
		}
	
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 48152
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0() {} // 0x0000000181B87DE0-0x0000000181B87DF0
	
			// Methods
			internal bool _GetFirstInputOfType_b__1(Port p) => default; // 0x000000018B44F4C4-0x000000018B44F500
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48153
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Port, int> __9__50_0; // 0x08
			public static Func<Port, int> __9__51_0; // 0x10
			public static Func<ValueInput, bool> __9__52_0; // 0x18
			public static Func<KeyValuePair<string, object>, string> __9__78_0; // 0x20
			public static Func<KeyValuePair<string, object>, object> __9__78_1; // 0x28
	
			// Constructors
			static __c() {} // 0x000000018B44F498-0x000000018B44F4C4
			public __c() {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			internal int _GetFirstInputOfType_b__50_0(Port p) => default; // 0x000000018B44F0C8-0x000000018B44F498
			internal int _GetFirstOutputOfType_b__51_0(Port p) => default; // 0x0000000185492010-0x0000000185492020
			internal bool _AssignSelfInstancePort_b__52_0(ValueInput p) => default; // 0x000000018B44DB14-0x000000018B44DB1C
			internal string _ReplaceWith_b__78_0(KeyValuePair<string, object> k) => default; // 0x0000000185492010-0x0000000185492020
			internal object _ReplaceWith_b__78_1(KeyValuePair<string, object> v) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 48154
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _GetFirstOutputOfType_b__1(Port p) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 48155
		{
			// Fields
			public KeyValuePair<string, object> pair; // 0x10
			public FlowNode __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass56_0() {} // 0x000000018B44DAAC-0x000000018B44DB0C
	
			// Methods
			internal bool _DeserializeInputPortValues_b__0(Port p) => default; // 0x000000018B44DB0C-0x000000018B44DB14
		}
	
		// Constructors
		protected FlowNode() {} // 0x000000018B458A04-0x000000018B458A58
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B44C878-0x000000018B44CA5C
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B44D040-0x000000018B44D1C4
		public override void OnValidate(NodeCanvas.Framework.Graph flowGraph) {}
		public sealed override void OnParentConnected(int i) {} // 0x0000000185492010-0x0000000185492020
		public sealed override void OnChildConnected(int i) {} // 0x000000018B44CC20-0x000000018B44D040
		public sealed override void OnParentDisconnected(int i) {} // 0x0000000185492010-0x0000000185492020
		public sealed override void OnChildDisconnected(int i) {} // 0x000000018B44C120-0x000000018B44C138
		public virtual void OnPortConnected(Port port, Port otherPort) {} // 0x000000018B44C138-0x000000018B44C220
		public virtual void OnPortDisconnected(Port port, Port otherPort) {} // 0x000000018B44C220-0x000000018B44C2F8
		public virtual void OnPortDisconnectedLate(Port port, Port otherPort) {}
		public void BindPorts() {}
		public void UnBindPorts() {}
		public Port GetInputPort(string ID) => default; // 0x000000018B44C3C0-0x000000018B44C594
		public Port GetOutputPort(string ID) => default;
		public IEnumerable<Port> GetAllPorts() => default; // 0x000000018B44C6A4-0x000000018B44C878
		public IEnumerable<FlowOutput> GetOutputFlowPorts() => default; // 0x000000018B44C594-0x000000018B44C5AC
		public IEnumerable<ValueOutput> GetOutputValuePorts() => default; // 0x000000018B44C2F8-0x000000018B44C3C0
		public IEnumerable<FlowInput> GetInputFlowPorts() => default; // 0x000000018B44C5AC-0x000000018B44C5CC
		public IEnumerable<ValueInput> GetInputValuePorts() => default; // 0x000000018B44C5CC-0x000000018B44C6A4
		public Port GetFirstInputOfType(System.Type type) => default; // 0x000000018B44DB1C-0x000000018B44DBD4
		public Port GetFirstOutputOfType(System.Type type) => default; // 0x000000018B44CB10-0x000000018B44CC20
		public void AssignSelfInstancePort() {} // 0x000000018B44E920-0x000000018B44EAF4
		public void GatherPorts() {} // 0x000000018B44E474-0x000000018B44E628
		protected abstract void RegisterPorts(); // 0x000000018B44DF0C-0x000000018B44E080
		protected virtual void ValidateConnections() {} // 0x000000018B44E080-0x000000018B44E474
		private void DeserializeInputPortValues() {} // 0x000000018B44E628-0x000000018B44E920
		private void RefreshEditorPorts() {} // 0x000000018B44DBD4-0x000000018B44DF0C
		public FlowInput AddFlowInput(string name, string ID, FlowHandler pointer) => default; // 0x000000018B44EF60-0x000000018B44F014
		public FlowInput AddFlowInput(string name, FlowHandler pointer, string ID = "" /* Metadata: 0x02060CF9 */) => default; // 0x000000018B44D834-0x000000018B44D884
		public FlowOutput AddFlowOutput(string name, string ID = "" /* Metadata: 0x02060CFA */) => default; // 0x000000018B44EEB8-0x000000018B44EF60
		public ValueInput<T> AddValueInput<T>(string name, string ID = "" /* Metadata: 0x02060CFB */) => default; // 0x000000018B44EC94-0x000000018B44EEB8
		public ValueOutput<T> AddValueOutput<T>(string name, string ID, ValueHandler<T> getter) => default; // 0x000000018B44EAF4-0x000000018B44EC94
		public ValueOutput<T> AddValueOutput<T>(string name, ValueHandler<T> getter, string ID = "" /* Metadata: 0x02060CFC */) => default; // 0x0000000183055FD0-0x0000000183055FE0
		public void AddValueInput(System.Type valueType, string name, string ID = "" /* Metadata: 0x02060CFD */) {} // 0x0000000184096E30-0x0000000184096EF0
		public ValueOutput<T> AddValueOutput<T>(string name, string ID = "" /* Metadata: 0x02060CFE */) => default; // 0x0000000184096E30-0x0000000184096EF0
		public void AddValueOutput(System.Type valueType, string name, string ID = "" /* Metadata: 0x02060CFF */) {} // 0x0000000185492010-0x0000000185492020
		public ValueInput AddValueInput(string name, string ID, System.Type type) => default; // 0x000000018B44FBB8-0x000000018B44FBF8
		public ValueInput AddValueInput(string name, System.Type type, string ID = "" /* Metadata: 0x02060D00 */) => default; // 0x0000000185492010-0x0000000185492020
		public ValueOutput AddValueOutput(string name, string ID, System.Type type, ValueHandlerObject getter) => default; // 0x000000018B4588B4-0x000000018B4588DC
		public ValueOutput AddValueOutput(string name, System.Type type, ValueHandlerObject getter, string ID = "" /* Metadata: 0x02060D01 */) => default; // 0x0000000185492010-0x0000000185492020
		protected void QualifyPortNameAndID(ref string name, ref string ID, IDictionary dict) {} // 0x000000018B4588B4-0x000000018B4588DC
		private bool CheckReverseIDEquality(Port port, string requestedID) => default; // 0x0000000185492010-0x0000000185492020
		public void TryAddReflectionBasedRegistrationForObject(object instance) {} // 0x000000018B458918-0x000000018B458994
		public FlowInput TryAddMethodFlowInput(MethodInfo method, object instance) => default; // 0x000000018B458AF0-0x000000018B458B54
		public FlowOutput TryAddFieldDelegateFlowOutput(System.Reflection.FieldInfo field, object instance) => default; // 0x0000000185492010-0x0000000185492020
		public ValueInput TryAddFieldDelegateValueInput(System.Reflection.FieldInfo field, object instance) => default; // 0x000000018B458510-0x000000018B45855C
		public ValueOutput TryAddPropertyValueOutput(PropertyInfo prop, object instance) => default; // 0x000000018B45855C-0x000000018B4585A8
		public FlowNode ReplaceWith(System.Type t) => default; // 0x000000018B458424-0x000000018B458458
		private void TryRemovePortIfMissingAndClean(Port port) {} // 0x000000018B4585A8-0x000000018B4585DC
		public virtual System.Type GetNodeWildDefinitionType() => default; // 0x000000018B4585DC-0x000000018B458614
		private void TryHandleWildPortConnection(System.Type currentType, System.Type targetType) {} // 0x0000000185492010-0x0000000185492020
		public static System.Type TryGetNewGenericTypeForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Type content, System.Type context) => default; // 0x000000018B458994-0x000000018B458A04
		public static MethodInfo TryGetNewGenericMethodForWild(System.Type wildType, System.Type currentType, System.Type targetType, MethodInfo content) => default; // 0x0000000185492010-0x0000000185492020
	}

	public abstract class FlowNodeNested<T> : FlowNode, IGraphAssignable<T> // TypeDefIndex: 48157
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		private List<BBMappingParameter> _variablesMap;
		private T _currentInstance_k__BackingField;
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { get; set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FlowNodeNested() {}
	}

	public class FlowScript : FlowScriptBase // TypeDefIndex: 48158
	{
		// Properties
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public FlowScript() {} // 0x000000018B44F794-0x000000018B44F79C
	}

	public abstract class FlowScriptBase : FlowGraph // TypeDefIndex: 48159
	{
		// Constructors
		protected FlowScriptBase() {} // 0x000000018B44F794-0x000000018B44F79C
	}

	public class FlowScriptController : GraphOwner<FlowScript> // TypeDefIndex: 48160
	{
		// Constructors
		public FlowScriptController() {} // 0x000000018B44F90C-0x000000018B44F940
	
		// Methods
		public void CallFunction(string name) {} // 0x000000018B44F820-0x000000018B44F89C
		public object CallFunction(string name, object[] args) => default; // 0x000000018B44F89C-0x000000018B44F90C
		public void CallFunctionAsync(string name, Action<object> callback, object[] args) {} // 0x000000018B44F79C-0x000000018B44F820
	}

	public interface IEditorMenuCallbackReceiver // TypeDefIndex: 48161
	{
	}

	public class RenderImageEvent : RouterEventNode<Camera> // TypeDefIndex: 48162
	{
		// Fields
		private FlowOutput fOut; // 0xC8
		private RenderTexture t1; // 0xD0
		private RenderTexture t2; // 0xD8
	
		// Constructors
		public RenderImageEvent() {} // 0x000000018B455068-0x000000018B45509C
	
		// Methods
		protected override void Subscribe(EventRouter router) {} // 0x000000018B454F48-0x000000018B454FD8
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B454FD8-0x000000018B455068
		private void OnRenderImage(RenderTexture source, RenderTexture dest) {} // 0x000000018B454D70-0x000000018B454DEC
		protected override void RegisterPorts() {} // 0x000000018B454DEC-0x000000018B454F48
		private RenderTexture _RegisterPorts_b__6_0() => default; // 0x0000000185FB15A0-0x0000000185FB15B0
		private RenderTexture _RegisterPorts_b__6_1() => default; // 0x0000000185FB02F0-0x0000000185FB0300
	}

	public abstract class Port // TypeDefIndex: 48164
	{
		// Fields
		private bool _prettifyName_k__BackingField; // 0x10
		private bool _forceNotDraw_k__BackingField; // 0x11
		private FlowNode _parent_k__BackingField; // 0x18
		private string _ID_k__BackingField; // 0x20
		private string _name_k__BackingField; // 0x28
		private int _connections_k__BackingField; // 0x30
		private BindStatus _bindStatus_k__BackingField; // 0x34
		private GUIContent _displayContent_k__BackingField; // 0x38
	
		// Properties
		public bool prettifyName { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public bool forceNotDraw { get; set; } // 0x0000000185FB22C0-0x0000000185FB22D0 0x0000000185FB2560-0x0000000185FB2570
		public FlowNode parent { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string ID { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string name { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public int connections { get; internal set; } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public bool isConnected { get; } // 0x000000018B454D68-0x000000018B454D70 
		internal BindStatus bindStatus { get; private set; } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
		internal GUIContent displayContent { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public abstract System.Type type { get; }
	
		// Nested types
		public enum BindStatus // TypeDefIndex: 48163
		{
			Valid = 0,
			Missing = 1,
			InvalidCast = 2
		}
	
		// Constructors
		public Port() {} // 0x0000000181B9A230-0x0000000181B9A240
		public Port(FlowNode parent, string name, string ID) {} // 0x000000018B454D2C-0x000000018B454D68
	
		// Methods
		internal Port FlagMissing() => default; // 0x000000018B454520-0x000000018B454548
		internal Port FlagInvalidCast() => default; // 0x000000018B4544F8-0x000000018B454520
		internal Port FlagValid() => default; // 0x000000018B454548-0x000000018B45456C
		public virtual bool CanAcceptConnections() => default; // 0x000000018B454444-0x000000018B4544F8
		public IEnumerable<BinderConnection> GetPortConnections() => default; // 0x000000018B4546EC-0x000000018B454800
		public BinderConnection GetFirstInputConnection() => default; // 0x000000018B45456C-0x000000018B45462C
		public BinderConnection GetFirstOutputConnection() => default; // 0x000000018B45462C-0x000000018B4546EC
		public bool IsFlowPort() => default; // 0x000000018B4548F0-0x000000018B454954
		public bool IsValuePort() => default; // 0x000000018B454BA4-0x000000018B454C08
		public bool IsInputPort() => default; // 0x000000018B454954-0x000000018B4549B8
		public bool IsOutputPort() => default; // 0x000000018B4549B8-0x000000018B454A1C
		public bool IsUnityObject() => default; // 0x000000018B454A1C-0x000000018B454ABC
		public bool IsUnitySceneObject() => default; // 0x000000018B454ABC-0x000000018B454BA4
		public bool IsDelegate() => default; // 0x000000018B454800-0x000000018B4548A0
		public bool IsEnumerableCollection() => default; // 0x000000018B4548A0-0x000000018B4548F0
		public bool IsWild() => default; // 0x000000018B454C08-0x000000018B454C7C
		public override string ToString() => default; // 0x000000018B454C7C-0x000000018B454CCC
		private bool _GetPortConnections_b__43_0(BinderConnection c) => default; // 0x000000018B454CCC-0x000000018B454CFC
		private bool _GetPortConnections_b__43_1(BinderConnection c) => default; // 0x000000018B454CFC-0x000000018B454D2C
		private bool _GetFirstInputConnection_b__44_0(BinderConnection c) => default; // 0x000000018B454CCC-0x000000018B454CFC
		private bool _GetFirstOutputConnection_b__45_0(BinderConnection c) => default; // 0x000000018B454CFC-0x000000018B454D2C
	}

	public class FlowInput : Port // TypeDefIndex: 48165
	{
		// Fields
		private FlowHandler _pointer_k__BackingField; // 0x40
	
		// Properties
		public FlowHandler pointer { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public override System.Type type { get => default; } // 0x000000018B44C0D0-0x000000018B44C120 
	
		// Constructors
		public FlowInput() {} // Dummy constructor
		public FlowInput(FlowNode parent, string name, string ID, FlowHandler pointer) {} // 0x000000018B44C0A0-0x000000018B44C0D0
	}

	public class FlowOutput : Port // TypeDefIndex: 48166
	{
		// Fields
		private FlowHandler pointer; // 0x40
	
		// Properties
		public override System.Type type { get => default; } // 0x000000018B44F6B0-0x000000018B44F700 
	
		// Events
		public event FlowHandler pointer;
	
		// Constructors
		public FlowOutput() {} // Dummy constructor
		public FlowOutput(FlowNode parent, string name, string ID) {} // 0x000000018A00E5A8-0x000000018A00E5B8
	
		// Methods
		public void Call(Flow f) {} // 0x000000018B44F5BC-0x000000018B44F61C
		public void BindTo(FlowInput target) {} // 0x000000018B44F598-0x000000018B44F5BC
		public void Append(FlowHandler callback) {} // 0x000000018B44F590-0x000000018B44F598
		public void UnBind() {} // 0x000000018A69AD64-0x000000018A69AD78
	}

	public abstract class ValueInput : Port // TypeDefIndex: 48167
	{
		// Fields
		private bool _skipSelfInstanceAssignment_k__BackingField; // 0x40
	
		// Properties
		public object value { get; } // 0x000000018B45BEF0-0x000000018B45BF00 
		public bool skipSelfInstanceAssignment { get; private set; } // 0x0000000185FB0650-0x0000000185FB0660 0x0000000185FB0660-0x0000000185FB0670
		public abstract object defaultValue { get; set; }
		public abstract object serializedValue { get; set; }
		public abstract bool isDefaultValue { get; }
		public abstract System.Type type { get; }
	
		// Constructors
		protected ValueInput() {} // Dummy constructor
		public ValueInput(FlowNode parent, string name, string ID) {} // 0x000000018A00E5A8-0x000000018A00E5B8
	
		// Methods
		public static ValueInput<T> CreateInstance<T>(FlowNode parent, string name, string ID) => default;
		public static ValueInput CreateInstance(System.Type t, FlowNode parent, string name, string ID) => default; // 0x000000018B45BD1C-0x000000018B45BEB0
		public ValueInput SetDefaultAndSerializedValue(object v) => default; // 0x000000018B45BEB0-0x000000018B45BEF0
		public ValueInput SkipSelfInstanceAssignment(bool skip) => default; // 0x0000000185FD27C0-0x0000000185FD27D0
		public abstract void BindTo(ValueOutput target);
		public abstract void UnBind();
		public abstract object GetObjectValue();
	}

	public class ValueInput<T> : ValueInput // TypeDefIndex: 48168
	{
		// Fields
		private ValueHandler<T> getter;
		private Action<T> callback;
		private T _value;
		private T _defaultValue;
	
		// Properties
		public new T value { get => default; }
		public override object defaultValue { get => default; set {} }
		public override object serializedValue { get => default; set {} }
		public override bool isDefaultValue { get => default; }
		public override System.Type type { get => default; }
	
		// Events
		public event ValueHandler<T> getter;
	
		// Constructors
		public ValueInput() {} // Dummy constructor
		public ValueInput(FlowNode parent, string name, string ID) {}
	
		// Methods
		public ValueInput<T> SetDefaultAndSerializedValue(T v) => default;
		public T GetValue() => default;
		public override object GetObjectValue() => default;
		public override void BindTo(ValueOutput source) {}
		public void Append(Action<T> callback) {}
		public override void UnBind() {}
		public static explicit operator T(ValueInput<T> port) => default;
	}

	public abstract class ValueOutput : Port // TypeDefIndex: 48169
	{
		// Constructors
		protected ValueOutput() {} // Dummy constructor
		public ValueOutput(FlowNode parent, string name, string ID) {} // 0x000000018A00E5A8-0x000000018A00E5B8
	
		// Methods
		public static ValueOutput<T> CreateInstance<T>(FlowNode parent, string name, string ID, ValueHandler<T> getter) => default;
		public static ValueOutput CreateInstance(System.Type t, FlowNode parent, string name, string ID, ValueHandlerObject getter) => default; // 0x000000018B45BF00-0x000000018B45C0B4
		public abstract object GetObjectValue();
	}

	public class ValueOutput<T> : ValueOutput // TypeDefIndex: 48171
	{
		// Fields
		private ValueHandler<T> _getter_k__BackingField;
	
		// Properties
		public ValueHandler<T> getter { get; private set; }
		public override System.Type type { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48170
		{
			// Fields
			public ValueHandlerObject getter;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal T _.ctor_b__0() => default;
		}
	
		// Constructors
		public ValueOutput() {} // Dummy constructor
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandler<T> getter) {}
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandlerObject getter) {}
		public ValueOutput(FlowNode parent, string name, string ID) {}
	
		// Methods
		public override object GetObjectValue() => default;
		public static explicit operator T(ValueOutput<T> port) => default;
	}

	public static class TypeConverter // TypeDefIndex: 48178
	{
		// Fields
		private static CustomConverter customConverter; // 0x00
		private static CustomCanConvert customCanConvert; // 0x08
	
		// Events
		public static event CustomConverter customConverter;
		public static event CustomCanConvert customCanConvert;
	
		// Nested types
		public delegate ValueHandler<object> CustomConverter(System.Type sourceType, System.Type targetType, ValueHandler<object> func); // TypeDefIndex: 48172; 0x000000018B45837C-0x000000018B458424
	
		public delegate bool? CustomCanConvert(System.Type sourceType, System.Type targetType); // TypeDefIndex: 48173; 0x000000018B457F9C-0x000000018B458048
	
		private sealed class __c__DisplayClass8_0<T> // TypeDefIndex: 48174
		{
			// Fields
			public ValueHandler<object> func;
			public System.Type targetType;
			public UnaryExpression exp;
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018775974C-0x0000000187759874
	
			// Methods
			internal T _GetConverterFuncFromTo_b__0() => default; // 0x00000001817E31E0-0x00000001817E3200
			internal T _GetConverterFuncFromTo_b__1() => default; // 0x0000000187206B7C-0x0000000187206BB4
			internal T _GetConverterFuncFromTo_b__2() => default; // 0x00000001864750A8-0x00000001864751CC
			internal T _GetConverterFuncFromTo_b__3() => default; // 0x000000018B449F5C-0x000000018B44A084
			internal T _GetConverterFuncFromTo_b__4() => default; // 0x0000000181B59400-0x0000000181B59410
			internal T _GetConverterFuncFromTo_b__5() => default; // 0x0000000186E8C1B8-0x0000000186E8C1EC
			internal T _GetConverterFuncFromTo_b__6() => default; // 0x000000018A1CE150-0x000000018A1CE280
			internal T _GetConverterFuncFromTo_b__7() => default;
			internal T _GetConverterFuncFromTo_b__8() => default;
			internal T _GetConverterFuncFromTo_b__9() => default;
			internal T _GetConverterFuncFromTo_b__10() => default;
			internal T _GetConverterFuncFromTo_b__11() => default;
			internal T _GetConverterFuncFromTo_b__12() => default;
			internal T _GetConverterFuncFromTo_b__13() => default;
			internal T _GetConverterFuncFromTo_b__14() => default;
		}
	
		private sealed class __c__DisplayClass8_1<T> // TypeDefIndex: 48175
		{
			// Fields
			public ValueHandler<object> converter;
	
			// Constructors
			public __c__DisplayClass8_1() {}
	
			// Methods
			internal T _GetConverterFuncFromTo_b__15() => default;
		}
	
		private sealed class __c__DisplayClass8_2<T> // TypeDefIndex: 48176
		{
			// Fields
			public System.Type listType;
			public __c__DisplayClass8_0<T> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass8_2() {}
	
			// Methods
			internal T _GetConverterFuncFromTo_b__16() => default;
		}
	
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 48177
		{
			// Fields
			public object obj; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0() {}
	
			// Methods
			internal object _QuickConvert_b__0() => default;
		}
	
		// Methods
		public static ValueHandler<T> GetConverterFuncFromTo<T>(System.Type sourceType, System.Type targetType, ValueHandler<object> func) => default;
		public static bool HasConvertion(System.Type sourceType, System.Type targetType) => default;
		public static T QuickConvert<T>(object obj) => default; // 0x0000000185492010-0x0000000185492020
		public static object QuickConvert(object obj, System.Type type) => default; // 0x000000018346D130-0x000000018346D140
	}

	public class Wild // TypeDefIndex: 48179
	{
		// Constructors
		public Wild() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace FlowCanvas.Macros
{
	public class Macro : FlowScriptBase // TypeDefIndex: 48759
	{
		// Fields
		public List<DynamicParameterDefinition> inputDefinitions; // 0xC0
		public List<DynamicParameterDefinition> outputDefinitions; // 0xC8
		[NonSerialized]
		public Dictionary<string, FlowHandler> entryActionMap; // 0xD0
		[NonSerialized]
		public Dictionary<string, FlowHandler> exitActionMap; // 0xD8
		[NonSerialized]
		public Dictionary<string, ValueHandlerObject> entryFunctionMap; // 0xE0
		[NonSerialized]
		public Dictionary<string, ValueHandlerObject> exitFunctionMap; // 0xE8
		private MacroInputNode _entry; // 0xF0
		private MacroOutputNode _exit; // 0xF8
	
		// Properties
		public override bool allowBlackboardOverrides { get => default; } // 0x0000000185492010-0x0000000185492020 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x0000000185492010-0x0000000185492020 
		public MacroInputNode entry { get => default; } // 0x000000018B486010-0x000000018B486060 
		public MacroOutputNode exit { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 48753
		{
			// Fields
			public List<DynamicParameterDefinition> inputDefinitions; // 0x10
			public List<DynamicParameterDefinition> outputDefinitions; // 0x18
	
			// Constructors
			public DerivedSerializationData() {} // 0x000000018B48196C-0x000000018B4819DC
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 48754
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018B4818A4-0x000000018B48196C
	
			// Methods
			internal bool _AddInputDefinition_b__0(DynamicParameterDefinition d) => default; // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 48755
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			internal bool _AddOutputDefinition_b__0(DynamicParameterDefinition d) => default; // 0x000000018B481C70-0x000000018B481D80
		}
	
		private sealed class __c__DisplayClass23_0<T> // TypeDefIndex: 48756
		{
			// Fields
			public string name;
			public T value;
	
			// Constructors
			public __c__DisplayClass23_0() {} // 0x000000018B481D80-0x000000018B481E90
	
			// Methods
			internal bool _SetValueInput_b__0(DynamicParameterDefinition d) => default; // 0x000000018B4819DC-0x000000018B481A4C
			internal object _SetValueInput_b__1() => default; // 0x000000018B481488-0x000000018B4815EC
		}
	
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 48757
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x000000018B4815EC-0x000000018B481750
	
			// Methods
			internal bool _CallFlowInput_b__0(DynamicParameterDefinition d) => default; // 0x000000018B481300-0x000000018B481488
		}
	
		private sealed class __c__DisplayClass25_0<T> // TypeDefIndex: 48758
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass25_0() {}
	
			// Methods
			internal bool _GetValueOutput_b__0(DynamicParameterDefinition d) => default; // 0x000000018B481750-0x000000018B4818A4
		}
	
		// Constructors
		public Macro() {}
	
		// Methods
		public override object OnDerivedDataSerialization() => default;
		public override void OnDerivedDataDeserialization(object data) {} // 0x000000018B481A4C-0x000000018B481C70
		protected override void OnGraphValidate() {} // 0x000000018B486010-0x000000018B486060
		public Port AddInputDefinition(DynamicParameterDefinition def) => default;
		public Port AddOutputDefinition(DynamicParameterDefinition def) => default;
		public void AddExamplePorts() {}
		public void SetValueInput<T>(string name, T value) {} // 0x0000000185492010-0x0000000185492020
		public void CallFlowInput(string name) {} // 0x000000018B486060-0x000000018B4860EC
		public T GetValueOutput<T>(string name) => default;
	}

	public class MacroInputNode : FlowNode // TypeDefIndex: 48761
	{
		// Properties
		public override Alignment2x2 iconAlignment { get => default; } // 0x000000018B4801C4-0x000000018B4804CC 
		private Macro macro { get => default; } // 0x0000000183055FD0-0x0000000183055FE0 
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48760
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
			public MacroInputNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B4804CC-0x000000018B480508
		}
	
		// Constructors
		public MacroInputNode() {} // 0x000000018B486298-0x000000018B486328
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class MacroNodeWrapper : FlowNode, IGraphAssignable, IUpdatable // TypeDefIndex: 48765
	{
		// Fields
		private Macro _macro; // 0xB0
		private Macro _currentInstance; // 0xB8
	
		// Properties
		public override string name { get => default; } // 0x000000018B480764-0x000000018B4807B8 
		public override string description { get => default; } // 0x000000018349D710-0x000000018349D720 
		public Macro macro { get => default; set {} } // 0x000000018B4806A0-0x000000018B480708 0x00000001813AE580-0x00000001813AE590
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x00000001813AE580-0x00000001813AE590
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get => default; set {} } // 0x000000018B48060C-0x000000018B4806A0 0x000000018B480708-0x000000018B480764
		List<BBMappingParameter> IGraphAssignable.variablesMap { get => default; set {} } // 0x000000018B480508-0x000000018B48060C 0x000000018B4807B8-0x000000018B480838
		BBParameter IGraphAssignable.subGraphParameter { get => default; } // 0x000000018B480838-0x000000018B480DF0 
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> IGraphAssignable.instances { get => default; set {} } // 0x0000000183055FD0-0x0000000183055FE0 0x0000000185492010-0x0000000185492020
	
		// Nested types
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 48762
		{
			// Fields
			public Macro target; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0() {} // 0x000000018B480E8C-0x000000018B480F14
		}
	
		private sealed class __c__DisplayClass25_1 // TypeDefIndex: 48763
		{
			// Fields
			public DynamicParameterDefinition defIn; // 0x10
			public __c__DisplayClass25_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass25_1() {} // 0x000000018B480DF0-0x000000018B480E8C
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018346D8F0-0x000000018346D900
		}
	
		private sealed class __c__DisplayClass25_2 // TypeDefIndex: 48764
		{
			// Fields
			public DynamicParameterDefinition defOut; // 0x10
			public __c__DisplayClass25_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass25_2() {} // 0x000000018B480F14-0x000000018B480FB4
	
			// Methods
			internal object _RegisterPorts_b__1() => default; // 0x000000018346D8F0-0x000000018346D900
		}
	
		// Constructors
		public MacroNodeWrapper() {} // 0x000000018B4861A4-0x000000018B486234
	
		// Methods
		public void MakeInstance() {} // 0x0000000185492010-0x0000000185492020
		void IUpdatable.Update() {} // 0x000000018B4860EC-0x000000018B4861A4
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class MacroOutputNode : FlowNode // TypeDefIndex: 48767
	{
		// Properties
		public override Alignment2x2 iconAlignment { get => default; } // 0x000000018B480FB4-0x000000018B4812C4 
		private Macro macro { get => default; } // 0x0000000183055FD0-0x0000000183055FE0 
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48766
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
			public MacroOutputNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B4812C4-0x000000018B481300
		}
	
		// Constructors
		public MacroOutputNode() {} // 0x000000018B486328-0x000000018B4863E0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace FlowCanvas.Nodes
{
	public class ExternalImplementedNodeWrapper : FlowNode // TypeDefIndex: 48180
	{
		// Fields
		private UnityEngine.Object _target; // 0xB0
	
		// Properties
		public IExternalImplementedNode target { get => default; set {} } // 0x000000018B44B100-0x000000018B44B140 0x000000018B44B140-0x000000018B44B1BC
		public override string name { get => default; } // 0x000000018B44B080-0x000000018B44B100 
	
		// Constructors
		public ExternalImplementedNodeWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected System.Type GetRuntimeIconType() => default; // 0x000000018B44AFCC-0x000000018B44AFF4
		protected override void RegisterPorts() {} // 0x000000018B44AFF4-0x000000018B44B078
		public void SetTarget(IExternalImplementedNode target) {} // 0x000000018B44B078-0x000000018B44B080
	}

	public interface IDropedReferenceNode : IGraphElement // TypeDefIndex: 48181
	{
		// Methods
		void SetTarget(UnityEngine.Object target);
	}

	public interface IExternalImplementedNode // TypeDefIndex: 48182
	{
		// Methods
		void RegisterPorts(FlowNode parent);
	}

	public class ApplicationPauseEvent : EventNode // TypeDefIndex: 48183
	{
		// Fields
		private FlowOutput pause; // 0xB0
		private bool isPause; // 0xB8
	
		// Constructors
		public ApplicationPauseEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B4445D0-0x000000018B444668
		public override void OnGraphStoped() {} // 0x000000018B444668-0x000000018B444700
		private void ApplicationPause(bool isPause) {} // 0x000000018B44457C-0x000000018B4445D0
		protected override void RegisterPorts() {} // 0x000000018B444700-0x000000018B4447F0
		private bool _RegisterPorts_b__5_0() => default; // 0x0000000181EB1570-0x0000000181EB1580
	}

	public class ApplicationQuitEvent : EventNode // TypeDefIndex: 48184
	{
		// Fields
		private FlowOutput quit; // 0xB0
	
		// Constructors
		public ApplicationQuitEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B444840-0x000000018B4448D8
		public override void OnGraphStoped() {} // 0x000000018B4448D8-0x000000018B444970
		private void ApplicationQuit() {} // 0x000000018B4447F0-0x000000018B444840
		protected override void RegisterPorts() {} // 0x000000018B444970-0x000000018B4449D4
	}

	public class CSharpAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 48186
	{
		// Fields
		private SerializedEventInfo _event; // 0xB0
		private ReflectedDelegateEvent reflectedEvent; // 0xB8
		private ValueInput instancePort; // 0xC0
		private FlowOutput callback; // 0xC8
		private object instance; // 0xD0
		private object[] args; // 0xD8
	
		// Properties
		private EventInfo eventInfo { get => default; } // 0x000000018B44699C-0x000000018B446AC4 
		private bool isStaticEvent { get => default; } // 0x000000018346D8F0-0x000000018346D900 
		public override string name { get => default; } // 0x000000018B4468A4-0x000000018B44692C 
	
		// Nested types
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 48185
		{
			// Fields
			public int i; // 0x10
			public CSharpAutoCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x0000000189D7160C-0x0000000189D71620
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B44692C-0x000000018B44699C
		}
	
		// Constructors
		public CSharpAutoCallbackEvent() {} // 0x000000018B45880C-0x000000018B458844
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B44658C-0x000000018B4468A4
		public void SetEvent(EventInfo info, object instance = null) {} // 0x000000018B446324-0x000000018B44647C
		protected override void RegisterPorts() {} // 0x000000018B44647C-0x000000018B44658C
		public override void OnGraphStarted() {} // 0x000000018B4462C0-0x000000018B446324
		public override void OnGraphStoped() {} // 0x0000000183055FD0-0x0000000183055FE0
		private void OnEventRaised(object[] args) {} // 0x0000000185492010-0x0000000185492020
	}

	public class CSharpEventCallback : EventNode, IReflectedWrapper // TypeDefIndex: 48188
	{
		// Fields
		protected bool _autoHandleRegistration; // 0xB0
		private SerializedTypeInfo _type; // 0xB8
		private object[] argValues; // 0xC0
		private ValueInput eventInput; // 0xC8
		private FlowOutput flowCallback; // 0xD0
		private ReflectedDelegateEvent reflectedEvent; // 0xD8
	
		// Properties
		private System.Type type { get => default; set {} } // 0x0000000181B10450-0x0000000181B10460 0x000000018349D710-0x000000018349D720
		private bool autoHandleRegistration { get => default; } // 0x000000018B446B78-0x000000018B446BC0 
	
		// Nested types
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 48187
		{
			// Fields
			public int i; // 0x10
			public CSharpEventCallback __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x000000018B447338-0x000000018B44734C
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B44734C-0x000000018B4473FC
		}
	
		// Constructors
		public CSharpEventCallback() {} // 0x000000018B458844-0x000000018B45887C
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B446BC0-0x000000018B446C20
		public override void OnGraphStarted() {} // 0x000000018B446D10-0x000000018B447148
		public override void OnGraphStoped() {} // 0x000000018B447148-0x000000018B447264
		protected override void RegisterPorts() {} // 0x000000018B447264-0x000000018B447338
		private void Register(Flow f = default) {} // 0x000000018B446AC4-0x000000018B446B28
		private void Unregister(Flow f = default) {} // 0x000000018B446B28-0x000000018B446B78
		private void Callback(object[] args) {} // 0x000000018B446C20-0x000000018B446D10
		public override System.Type GetNodeWildDefinitionType() => default; // 0x0000000183055FD0-0x0000000183055FE0
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000185492010-0x0000000185492020
	}

	public class CustomEvent : RouterEventNode<GraphOwner> // TypeDefIndex: 48189
	{
		// Fields
		public BBParameter<string> eventName; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private GraphOwner sender; // 0xD8
		private GraphOwner receiver; // 0xE0
	
		// Properties
		public override string name { get => default; } // 0x000000018B44A518-0x000000018B44A590 
	
		// Constructors
		public CustomEvent() {} // 0x000000018B44A4A4-0x000000018B44A518
	
		// Methods
		protected override void Subscribe(EventRouter router) {} // 0x000000018B44A384-0x000000018B44A414
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B44A414-0x000000018B44A4A4
		protected override void RegisterPorts() {} // 0x000000018B44A228-0x000000018B44A384
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg) {} // 0x000000018B44A084-0x000000018B44A228
		private GraphOwner _RegisterPorts_b__8_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GraphOwner _RegisterPorts_b__8_1() => default; // 0x0000000185FB02F0-0x0000000185FB0300
	}

	public class CustomEvent<T> : RouterEventNode<GraphOwner> // TypeDefIndex: 48190
	{
		// Fields
		public BBParameter<string> eventName;
		private FlowOutput onReceived;
		private GraphOwner sender;
		private GraphOwner receiver;
		private T receivedValue;
	
		// Properties
		public override string name { get => default; }
	
		// Constructors
		public CustomEvent() {}
	
		// Methods
		protected override void Subscribe(EventRouter router) {}
		protected override void UnSubscribe(EventRouter router) {}
		protected override void RegisterPorts() {}
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg) {}
		private GraphOwner _RegisterPorts_b__9_0() => default;
		private GraphOwner _RegisterPorts_b__9_1() => default;
		private T _RegisterPorts_b__9_2() => default;
	}

	public class DelegateCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 48192
	{
		// Fields
		private SerializedTypeInfo _type; // 0xB0
		private ReflectedDelegateEvent reflectedEvent; // 0xB8
		private ValueOutput delegatePort; // 0xC0
		private FlowOutput callbackPort; // 0xC8
		private object[] args; // 0xD0
	
		// Properties
		private System.Type delegateType { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x000000018B44A6FC-0x000000018B44AAE0
	
		// Nested types
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 48191
		{
			// Fields
			public int i; // 0x10
			public DelegateCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x0000000189D7160C-0x0000000189D71620
	
			// Methods
			internal object _RegisterPorts_b__1() => default; // 0x000000018B44AB00-0x000000018B44ABB0
		}
	
		// Constructors
		public DelegateCallbackEvent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B44A590-0x000000018B44A5F4
		protected override void RegisterPorts() {} // 0x000000018B44A5F4-0x000000018B44A60C
		private void Callback(object[] args) {} // 0x000000018B44A60C-0x000000018B44A6FC
		public override void OnGraphStoped() {} // 0x0000000183055FD0-0x0000000183055FE0
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x000000018B44AAE0-0x000000018B44AB00
		private object _RegisterPorts_b__9_0() => default; // 0x000000018B458AB8-0x000000018B458AF0
	}

	public class GetSharpEvent : FlowNode, IReflectedWrapper // TypeDefIndex: 48194
	{
		// Fields
		private SerializedEventInfo _event; // 0xB0
		private ValueInput instancePort; // 0xB8
	
		// Properties
		private EventInfo eventInfo { get => default; } // 0x000000018346D8F0-0x000000018346D900 
		public override string name { get => default; } // 0x000000018B44FDF4-0x000000018B44FE7C 
	
		// Nested types
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 48193
		{
			// Fields
			public SharpEvent wrapper; // 0x10
			public GetSharpEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x0000000189D7160C-0x0000000189D71620
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B44FE7C-0x000000018B44FFF4
		}
	
		// Constructors
		public GetSharpEvent() {} // 0x000000018B458A58-0x000000018B458AB8
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B44FBF8-0x000000018B44FDF4
		public void SetEvent(EventInfo info, object instance = null) {} // 0x0000000183055FD0-0x0000000183055FE0
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class InvokeSignal : FlowNode, IDropedReferenceNode // TypeDefIndex: 48196
	{
		// Fields
		public BBParameter<SignalDefinition> _signalDefinition; // 0xB0
		public bool global; // 0xB8
		private ValueInput<Transform> target; // 0xC0
		private ValueInput[] inputArgs; // 0xC8
	
		// Properties
		private SignalDefinition signalDefinition { get => default; set {} } // 0x000000018B450D80-0x000000018B450E58 0x000000018B450D20-0x000000018B450D80
		public override string name { get => default; } // 0x000000018B450A50-0x000000018B450D20 
	
		// Nested types
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 48195
		{
			// Fields
			public InvokeSignal __4__this; // 0x10
			public FlowOutput exit; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B450E58-0x000000018B450EA0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B450EA0-0x000000018B450EF8
		}
	
		// Constructors
		public InvokeSignal() {} // 0x000000018B458614-0x000000018B45880C
	
		// Methods
		public void SetTarget(UnityEngine.Object target) {} // 0x0000000183055FD0-0x0000000183055FE0
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SignalCallback : RouterEventNode<Transform>, IDropedReferenceNode // TypeDefIndex: 48198
	{
		// Fields
		public BBParameter<SignalDefinition> _signalDefinition; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private Transform receiver; // 0xD8
		private Transform sender; // 0xE0
		private object[] args; // 0xE8
	
		// Properties
		private SignalDefinition signalDefinition { get => default; set {} } // 0x000000018B455AD0-0x000000018B455BB8 0x000000018B455A3C-0x000000018B455A9C
		public override string name { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 48197
		{
			// Fields
			public int i; // 0x10
			public SignalCallback __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x000000018B455BB8-0x000000018B455C00
	
			// Methods
			internal object _RegisterPorts_b__2() => default; // 0x000000018B455C00-0x000000018B455C58
		}
	
		// Constructors
		public SignalCallback() {} // 0x0000000185FB25D0-0x0000000185FB25E0
	
		// Methods
		public void SetTarget(UnityEngine.Object target) {} // 0x0000000185492010-0x0000000185492020
		protected override void Subscribe(EventRouter router) {} // 0x000000018B455618-0x000000018B455754
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B4553D4-0x000000018B4554C0
		public override void OnPostGraphStarted() {} // 0x000000018B455754-0x000000018B455A3C
		public override void OnGraphStoped() {} // 0x000000018B4554C0-0x000000018B455618
		protected override void RegisterPorts() {} // 0x000000018B455A9C-0x000000018B455AD0
		private void OnInvoked(Transform sender, Transform receiver, bool isGlobal, object[] args) {} // 0x0000000185FB02F0-0x0000000185FB0300
		private Transform _RegisterPorts_b__15_0() => default; // 0x0000000185492010-0x0000000185492020
		private Transform _RegisterPorts_b__15_1() => default; // 0x000000018B45887C-0x000000018B4588B4
	}

	public class UnityEventAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 48200
	{
		// Fields
		private SerializedUnityEventInfo _eventMember; // 0xB0
		private ReflectedUnityEvent reflectedEvent; // 0xB8
		private UnityEventBase unityEvent; // 0xC0
		private ValueInput instancePort; // 0xC8
		private FlowOutput callback; // 0xD0
		private object[] args; // 0xD8
	
		// Properties
		private MemberInfo member { get => default; } // 0x000000018B45B048-0x000000018B45B070 
		private bool isStatic { get => default; } // 0x000000018B45B070-0x000000018B45B080 
		private System.Type eventType { get => default; } // 0x000000018B45B1EC-0x000000018B45B1FC 
		private System.Reflection.FieldInfo field { get => default; } // 0x000000018B45B0C4-0x000000018B45B1EC 
		private PropertyInfo prop { get => default; } // 0x000000018346D8F0-0x000000018346D900 
		public override string name { get => default; } // 0x000000018B45AFC0-0x000000018B45B048 
	
		// Nested types
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 48199
		{
			// Fields
			public int i; // 0x10
			public UnityEventAutoCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018B45B0A8-0x000000018B45B0C4
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B45B080-0x000000018B45B0A8
		}
	
		// Constructors
		public UnityEventAutoCallbackEvent() {} // 0x000000018B45880C-0x000000018B458844
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B45AC84-0x000000018B45AFC0
		public void SetEvent(MemberInfo newMember, object instance = null) {} // 0x000000018B45A9C0-0x000000018B45ABD0
		protected override void RegisterPorts() {} // 0x000000018B45ABD0-0x000000018B45AC84
		public override void OnGraphStarted() {} // 0x000000018B45A95C-0x000000018B45A9C0
		public override void OnGraphStoped() {} // 0x0000000183055FD0-0x0000000183055FE0
		private void OnEventRaised(object[] args) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UnityEventCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 48202
	{
		// Fields
		protected bool _autoHandleRegistration; // 0xB0
		private SerializedTypeInfo _type; // 0xB8
		private object[] argValues; // 0xC0
		private ValueInput eventInput; // 0xC8
		private FlowOutput flowCallback; // 0xD0
		private ReflectedUnityEvent reflectedEvent; // 0xD8
	
		// Properties
		private System.Type eventType { get => default; set {} } // 0x0000000181B10450-0x0000000181B10460 0x000000018349D710-0x000000018349D720
		public bool autoHandleRegistration { get => default; } // 0x000000018B45B24C-0x000000018B45B294 
	
		// Nested types
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 48201
		{
			// Fields
			public int i; // 0x10
			public UnityEventCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x000000018B447338-0x000000018B44734C
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B45BA88-0x000000018B45BB38
		}
	
		// Constructors
		public UnityEventCallbackEvent() {} // 0x000000018B458844-0x000000018B45887C
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B45B294-0x000000018B45B2DC
		public override void OnGraphStarted() {} // 0x000000018B45B3CC-0x000000018B45B888
		public override void OnGraphStoped() {} // 0x000000018B45B888-0x000000018B45B9B0
		protected override void RegisterPorts() {} // 0x000000018B45B9B0-0x000000018B45BA88
		private void Register(Flow f = default) {} // 0x000000018B446AC4-0x000000018B446B28
		private void Unregister(Flow f = default) {} // 0x000000018B45B1FC-0x000000018B45B24C
		private void OnEventRaised(object[] args) {} // 0x000000018B45B2DC-0x000000018B45B3CC
		public override System.Type GetNodeWildDefinitionType() => default; // 0x0000000183055FD0-0x0000000183055FE0
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class EventNode : FlowNode // TypeDefIndex: 48203
	{
		// Properties
		public override string name { get; } // 0x000000018B44AF70-0x000000018B44AFCC 
	
		// Constructors
		protected EventNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public abstract class EventNode<T> : EventNode // TypeDefIndex: 48204
		where T : Component
	{
		// Fields
		public BBParameter<T> target;
	
		// Properties
		public override string name { get; }
	
		// Constructors
		protected EventNode() {}
	
		// Methods
		public override void OnPostGraphStarted() {}
		protected void ResolveSelf() {}
	}

	public abstract class RouterEventNode<T> : EventNode // TypeDefIndex: 48206
		where T : Component
	{
		// Fields
		public TargetMode targetMode;
		public BBParameter<T> target;
		public BBParameter<List<T>> targets;
	
		// Properties
		public override string name { get; }
	
		// Nested types
		public enum TargetMode // TypeDefIndex: 48205
		{
			SingleTarget = 0,
			MultipleTargets = 1
		}
	
		// Constructors
		protected RouterEventNode() {}
	
		// Methods
		protected abstract void Subscribe(EventRouter router);
		protected abstract void UnSubscribe(EventRouter router);
		public override void OnPostGraphStarted() {}
		public override void OnGraphStoped() {}
		protected T ResolveReceiver(GameObject receiver) => default;
	}

	public class ConstructionEvent : EventNode // TypeDefIndex: 48207
	{
		// Fields
		private FlowOutput awake; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public ConstructionEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B449E98-0x000000018B449EF8
		protected override void RegisterPorts() {} // 0x000000018B449EF8-0x000000018B449F5C
	}

	public class DisableEvent : EventNode // TypeDefIndex: 48208
	{
		// Fields
		private FlowOutput disable; // 0xB0
	
		// Constructors
		public DisableEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStoped() {} // 0x000000018B4447F0-0x000000018B444840
		protected override void RegisterPorts() {} // 0x000000018B44ABB0-0x000000018B44AC14
	}

	public class EnableEvent : EventNode // TypeDefIndex: 48209
	{
		// Fields
		private FlowOutput enable; // 0xB0
	
		// Constructors
		public EnableEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B4447F0-0x000000018B444840
		protected override void RegisterPorts() {} // 0x000000018B44AF0C-0x000000018B44AF70
	}

	public class FixedUpdateEvent : EventNode // TypeDefIndex: 48210
	{
		// Fields
		private FlowOutput fixedUpdate; // 0xB0
	
		// Constructors
		public FixedUpdateEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B44B2EC-0x000000018B44B350
		public override void OnGraphStarted() {} // 0x000000018B44B1BC-0x000000018B44B254
		public override void OnGraphStoped() {} // 0x000000018B44B254-0x000000018B44B2EC
		private void FixedUpdate() {} // 0x000000018B4447F0-0x000000018B444840
	}

	public class LateUpdateEvent : EventNode // TypeDefIndex: 48211
	{
		// Fields
		private FlowOutput lateUpdate; // 0xB0
	
		// Constructors
		public LateUpdateEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B4512D8-0x000000018B45133C
		public override void OnGraphStarted() {} // 0x000000018B4511A8-0x000000018B451240
		public override void OnGraphStoped() {} // 0x000000018B451240-0x000000018B4512D8
		private void LateUpdate() {} // 0x000000018B4447F0-0x000000018B444840
	}

	public class StartEvent : EventNode // TypeDefIndex: 48212
	{
		// Fields
		private FlowOutput start; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public StartEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B455C58-0x000000018B455D3C
		private void OnStartCallback() {} // 0x000000018B455D3C-0x000000018B455DB4
		protected override void RegisterPorts() {} // 0x000000018B455DB4-0x000000018B455E18
	}

	public class UpdateEvent : EventNode, IUpdatable // TypeDefIndex: 48213
	{
		// Fields
		public BBParameter<float> updateInterval; // 0xB0
		private FlowOutput update; // 0xB8
		private float lastUpdatedTime; // 0xC0
	
		// Constructors
		public UpdateEvent() {} // 0x000000018B45BCC4-0x000000018B45BD1C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B45BB38-0x000000018B45BB9C
		public override void OnGraphStarted() {} // 0x0000000185FD27B0-0x0000000185FD27C0
		public void Update() {} // 0x000000018B45BB9C-0x000000018B45BCC4
	}

	public class InputAxisEvent : EventNode, IUpdatable // TypeDefIndex: 48214
	{
		// Fields
		private FlowOutput o; // 0xB0
		private float horizontal; // 0xB8
		private float vertical; // 0xBC
		private bool calledLastFrame; // 0xC0
	
		// Constructors
		public InputAxisEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B44FFF4-0x000000018B450150
		public void Update() {} // 0x000000018B450150-0x000000018B450294
		private float _RegisterPorts_b__4_0() => default; // 0x0000000185FBAC60-0x0000000185FBAC70
		private float _RegisterPorts_b__4_1() => default; // 0x0000000185FB9B20-0x0000000185FB9B30
	}

	public class InputButtonEvents : EventNode, IUpdatable // TypeDefIndex: 48215
	{
		// Fields
		public BBParameter<string> buttonName; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018B450508-0x000000018B450558 
	
		// Constructors
		public InputButtonEvents() {} // 0x000000018B4504A0-0x000000018B450508
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B450294-0x000000018B450368
		public void Update() {} // 0x000000018B450368-0x000000018B4504A0
	}

	public class InputCustomAxisEvent : EventNode, IUpdatable // TypeDefIndex: 48217
	{
		// Fields
		public BBParameter<List<string>> axis; // 0xB0
		private float[] axisValues; // 0xB8
		private bool calledLastFrame; // 0xC0
		private FlowOutput o; // 0xC8
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48216
		{
			// Fields
			public int i; // 0x10
			public InputCustomAxisEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018B450558-0x000000018B4507C0
	
			// Methods
			internal float _RegisterPorts_b__0() => default; // 0x000000018B4507C0-0x000000018B450960
		}
	
		// Constructors
		public InputCustomAxisEvent() {} // 0x000000018B4588DC-0x000000018B458918
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B450960-0x000000018B450A50
		public void Update() {} // 0x0000000185492010-0x0000000185492020
	}

	public class KeyboardEvents : EventNode, IUpdatable // TypeDefIndex: 48218
	{
		// Fields
		public BBParameter<KeyCode> keyCode; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018B451158-0x000000018B4511A8 
	
		// Constructors
		public KeyboardEvents() {} // 0x000000018B451100-0x000000018B451158
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B450EF8-0x000000018B450FCC
		public void Update() {} // 0x000000018B450FCC-0x000000018B451100
	}

	public class MouseEvents : EventNode, IUpdatable // TypeDefIndex: 48220
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput pressed; // 0xC0
		private FlowOutput up; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018B452CE0-0x000000018B452D30 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 48219
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MouseEvents() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B452AD8-0x000000018B452BAC
		public void Update() {} // 0x000000018B452BAC-0x000000018B452CE0
	}

	public class MousePickEvent : EventNode, IUpdatable // TypeDefIndex: 48222
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		public BBParameter<LayerMask> mask; // 0xB8
		private FlowOutput o; // 0xC0
		private RaycastHit hit; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018B452FF4-0x000000018B453044 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 48221
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MousePickEvent() {} // 0x000000018B452F84-0x000000018B452FF4
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B452D30-0x000000018B452E20
		public void Update() {} // 0x000000018B452E20-0x000000018B452F84
		private RaycastHit _RegisterPorts_b__7_0() => default; // 0x0000000185FCA070-0x0000000185FCA0A0
	}

	public class AnimatorEvents : RouterEventNode<Animator> // TypeDefIndex: 48223
	{
		// Fields
		private FlowOutput onAnimatorMove; // 0xC8
		private FlowOutput onAnimatorIK; // 0xD0
		private Animator receiver; // 0xD8
		private int layerIndex; // 0xE0
	
		// Constructors
		public AnimatorEvents() {} // 0x000000018B444548-0x000000018B44457C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B4441D8-0x000000018B444388
		protected override void Subscribe(EventRouter router) {} // 0x000000018B444388-0x000000018B444468
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B444468-0x000000018B444548
		private void OnAnimatorMove(ParadoxNotion.EventData msg) {} // 0x000000018B444134-0x000000018B4441D8
		private void OnAnimatorIK(EventData<int> msg) {} // 0x000000018B44406C-0x000000018B444134
		private Animator _RegisterPorts_b__4_0() => default; // 0x0000000185FB02F0-0x0000000185FB0300
		private int _RegisterPorts_b__4_1() => default; // 0x0000000185FB2390-0x0000000185FB23A0
	}

	public class CharacterControllerEvents : RouterEventNode<CharacterController>, IUpdatable // TypeDefIndex: 48224
	{
		// Fields
		private FlowOutput onHit; // 0xC8
		private CharacterController receiver; // 0xD0
		private ControllerColliderHit hitInfo; // 0xD8
		private FlowOutput onGrounded; // 0xE0
		private FlowOutput onUnGrounded; // 0xE8
		private bool wasGrounded; // 0xF0
		private bool[] wasGroundedMulti; // 0xF8
	
		// Constructors
		public CharacterControllerEvents() {} // 0x000000018B447C98-0x000000018B447CCC
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B447748-0x000000018B447838
		void IUpdatable.Update() {} // 0x000000018B4473FC-0x000000018B447674
		protected override void RegisterPorts() {} // 0x000000018B447838-0x000000018B447B24
		protected override void Subscribe(EventRouter router) {} // 0x000000018B447B24-0x000000018B447BB4
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B447C08-0x000000018B447C98
		private void OnControllerColliderHit(EventData<ControllerColliderHit> msg) {} // 0x000000018B447674-0x000000018B447748
		private CharacterController _RegisterPorts_b__9_0() => default; // 0x0000000185FB15A0-0x0000000185FB15B0
		private GameObject _RegisterPorts_b__9_1() => default; // 0x000000018B447BB4-0x000000018B447BD8
		private Vector3 _RegisterPorts_b__9_2() => default; // 0x000000018B447BD8-0x000000018B447C08
		private ControllerColliderHit _RegisterPorts_b__9_3() => default; // 0x0000000185FB02F0-0x0000000185FB0300
	}

	public class Collision2DEvents_Rigidbody : RouterEventNode<Rigidbody2D> // TypeDefIndex: 48225
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents_Rigidbody() {} // 0x000000018B448C08-0x000000018B448C3C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B448680-0x000000018B44896C
		protected override void Subscribe(EventRouter router) {} // 0x000000018B44896C-0x000000018B448A88
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B448AEC-0x000000018B448C08
		private void OnCollisionEnter2D(EventData<Collision2D> msg) {} // 0x000000018B448404-0x000000018B4484D8
		private void OnCollisionStay2D(EventData<Collision2D> msg) {} // 0x000000018B4485AC-0x000000018B448680
		private void OnCollisionExit2D(EventData<Collision2D> msg) {} // 0x000000018B4484D8-0x000000018B4485AC
		private Rigidbody2D _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x000000018B448A88-0x000000018B448AAC
		private ContactPoint2D _RegisterPorts_b__5_2() => default; // 0x000000018B448AAC-0x000000018B448AEC
		private Collision2D _RegisterPorts_b__5_3() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class Collision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 48226
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents() {} // 0x000000018B448E74-0x000000018B448EA8
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B448134-0x000000018B448404
		protected override void Subscribe(EventRouter router) {} // 0x000000018B448C3C-0x000000018B448D58
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B448D58-0x000000018B448E74
		private void OnCollisionEnter2D(EventData<Collision2D> msg) {} // 0x000000018B447EB8-0x000000018B447F8C
		private void OnCollisionStay2D(EventData<Collision2D> msg) {} // 0x000000018B448060-0x000000018B448134
		private void OnCollisionExit2D(EventData<Collision2D> msg) {} // 0x000000018B447F8C-0x000000018B448060
		private Collider2D _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x000000018B448A88-0x000000018B448AAC
		private ContactPoint2D _RegisterPorts_b__5_2() => default; // 0x000000018B448AAC-0x000000018B448AEC
		private Collision2D _RegisterPorts_b__5_3() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class CollisionEvents_Rigidbody : RouterEventNode<Rigidbody> // TypeDefIndex: 48227
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents_Rigidbody() {} // 0x000000018B449BF8-0x000000018B449C2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B449670-0x000000018B44995C
		protected override void Subscribe(EventRouter router) {} // 0x000000018B44995C-0x000000018B449A78
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B449ADC-0x000000018B449BF8
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg) {} // 0x000000018B4493F4-0x000000018B4494C8
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg) {} // 0x000000018B44959C-0x000000018B449670
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg) {} // 0x000000018B4494C8-0x000000018B44959C
		private Rigidbody _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x000000018B449A78-0x000000018B449A9C
		private ContactPoint _RegisterPorts_b__5_2() => default; // 0x000000018B449A9C-0x000000018B449ADC
		private UnityEngine.Collision _RegisterPorts_b__5_3() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class CollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 48228
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents() {} // 0x000000018B449E64-0x000000018B449E98
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B449124-0x000000018B4493F4
		protected override void Subscribe(EventRouter router) {} // 0x000000018B449C2C-0x000000018B449D48
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B449D48-0x000000018B449E64
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg) {} // 0x000000018B448EA8-0x000000018B448F7C
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg) {} // 0x000000018B449050-0x000000018B449124
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg) {} // 0x000000018B448F7C-0x000000018B449050
		private Collider _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x000000018B449A78-0x000000018B449A9C
		private ContactPoint _RegisterPorts_b__5_2() => default; // 0x000000018B449A9C-0x000000018B449ADC
		private UnityEngine.Collision _RegisterPorts_b__5_3() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class MouseAgent2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 48229
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onOver; // 0xD0
		private FlowOutput onExit; // 0xD8
		private FlowOutput onDown; // 0xE0
		private FlowOutput onUp; // 0xE8
		private FlowOutput onDrag; // 0xF0
		private Collider2D receiver; // 0xF8
		private RaycastHit2D hit; // 0x100
	
		// Constructors
		public MouseAgent2DEvents() {} // 0x000000018B451F24-0x000000018B451F58
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B45175C-0x000000018B4519CC
		protected override void Subscribe(EventRouter router) {} // 0x000000018B451B3C-0x000000018B451D30
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B451D30-0x000000018B451F24
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x000000018B45149C-0x000000018B45154C
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x000000018B4515FC-0x000000018B4516AC
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018B45154C-0x000000018B4515FC
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x000000018B45133C-0x000000018B4513EC
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018B4516AC-0x000000018B45175C
		private void OnMouseDrag(ParadoxNotion.EventData msg) {} // 0x000000018B4513EC-0x000000018B45149C
		private void StoreHit() {} // 0x000000018B4519CC-0x000000018B451B3C
		private Collider2D _RegisterPorts_b__8_0() => default; // 0x0000000185FB16B0-0x0000000185FB16C0
		private RaycastHit2D _RegisterPorts_b__8_1() => default; // 0x0000000185FD2750-0x0000000185FD2780
	}

	public class MouseAgentEvents : RouterEventNode<Collider> // TypeDefIndex: 48230
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onOver; // 0xD0
		private FlowOutput onExit; // 0xD8
		private FlowOutput onDown; // 0xE0
		private FlowOutput onUp; // 0xE8
		private FlowOutput onDrag; // 0xF0
		private Collider receiver; // 0xF8
		private RaycastHit hit; // 0x100
	
		// Constructors
		public MouseAgentEvents() {} // 0x000000018B452AA4-0x000000018B452AD8
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B452378-0x000000018B4525E8
		protected override void Subscribe(EventRouter router) {} // 0x000000018B4526BC-0x000000018B4528B0
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B4528B0-0x000000018B452AA4
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x000000018B4520B8-0x000000018B452168
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x000000018B452218-0x000000018B4522C8
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018B452168-0x000000018B452218
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x000000018B451F58-0x000000018B452008
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018B4522C8-0x000000018B452378
		private void OnMouseDrag(ParadoxNotion.EventData msg) {} // 0x000000018B452008-0x000000018B4520B8
		private void StoreHit() {} // 0x000000018B4525E8-0x000000018B4526BC
		private Collider _RegisterPorts_b__8_0() => default; // 0x0000000185FB16B0-0x0000000185FB16C0
		private RaycastHit _RegisterPorts_b__8_1() => default; // 0x0000000185FD2780-0x0000000185FD27B0
	}

	public class ObjectStateEvents : RouterEventNode<Transform> // TypeDefIndex: 48231
	{
		// Fields
		private FlowOutput onEnable; // 0xC8
		private FlowOutput onDisable; // 0xD0
		private FlowOutput onDestroy; // 0xD8
		private GameObject receiver; // 0xE0
	
		// Constructors
		public ObjectStateEvents() {} // 0x000000018B4535F8-0x000000018B45362C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B453260-0x000000018B4533C0
		protected override void Subscribe(EventRouter router) {} // 0x000000018B4533C0-0x000000018B4534DC
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B4534DC-0x000000018B4535F8
		private void OnEnable(ParadoxNotion.EventData msg) {} // 0x000000018B4531AC-0x000000018B453260
		private void OnDisable(ParadoxNotion.EventData msg) {} // 0x000000018B4530F8-0x000000018B4531AC
		private void OnDestroy(ParadoxNotion.EventData msg) {} // 0x000000018B453044-0x000000018B4530F8
		private GameObject _RegisterPorts_b__4_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
	}

	public class DrawGizmosEvents : RouterEventNode<Transform> // TypeDefIndex: 48232
	{
		// Fields
		private FlowOutput onDrawGizmos; // 0xC8
		private GameObject receiver; // 0xD0
	
		// Constructors
		public DrawGizmosEvents() {} // 0x000000018B44AED8-0x000000018B44AF0C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B44ACC8-0x000000018B44ADB8
		protected override void Subscribe(EventRouter router) {} // 0x000000018B44ADB8-0x000000018B44AE48
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B44AE48-0x000000018B44AED8
		private void OnDrawGizmos(ParadoxNotion.EventData msg) {} // 0x000000018B44AC14-0x000000018B44ACC8
		private GameObject _RegisterPorts_b__2_0() => default; // 0x0000000185FB15A0-0x0000000185FB15B0
	}

	public class ParticleCollision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 48233
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider2D receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollision2DEvents() {} // 0x000000018B453D04-0x000000018B453D38
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B4537D4-0x000000018B453A88
		protected override void Subscribe(EventRouter router) {} // 0x000000018B453A88-0x000000018B453B18
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B453C74-0x000000018B453D04
		private void OnParticleCollision(EventData<GameObject> msg) {} // 0x000000018B45362C-0x000000018B4537D4
		private Collider2D _RegisterPorts_b__4_0() => default; // 0x0000000185FB15A0-0x0000000185FB15B0
		private ParticleSystem _RegisterPorts_b__4_1() => default; // 0x0000000185FB02F0-0x0000000185FB0300
		private Vector3 _RegisterPorts_b__4_2() => default; // 0x000000018B453B18-0x000000018B453B8C
		private Vector3 _RegisterPorts_b__4_3() => default; // 0x000000018B453B8C-0x000000018B453C00
		private Vector3 _RegisterPorts_b__4_4() => default; // 0x000000018B453C00-0x000000018B453C74
	}

	public class ParticleCollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 48234
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollisionEvents() {} // 0x000000018B454410-0x000000018B454444
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B453EE0-0x000000018B454194
		protected override void Subscribe(EventRouter router) {} // 0x000000018B454194-0x000000018B454224
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B454380-0x000000018B454410
		private void OnParticleCollision(EventData<GameObject> msg) {} // 0x000000018B453D38-0x000000018B453EE0
		private Collider _RegisterPorts_b__4_0() => default; // 0x0000000185FB15A0-0x0000000185FB15B0
		private ParticleSystem _RegisterPorts_b__4_1() => default; // 0x0000000185FB02F0-0x0000000185FB0300
		private Vector3 _RegisterPorts_b__4_2() => default; // 0x000000018B454224-0x000000018B454298
		private Vector3 _RegisterPorts_b__4_3() => default; // 0x000000018B454298-0x000000018B45430C
		private Vector3 _RegisterPorts_b__4_4() => default; // 0x000000018B45430C-0x000000018B454380
	}

	public class TransformEvents : RouterEventNode<Transform> // TypeDefIndex: 48235
	{
		// Fields
		private FlowOutput onParentChanged; // 0xC8
		private FlowOutput onChildrenChanged; // 0xD0
		private Transform receiver; // 0xD8
		private Transform parent; // 0xE0
		private IEnumerable<Transform> children; // 0xE8
	
		// Constructors
		public TransformEvents() {} // 0x000000018B4563D8-0x000000018B45640C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B456018-0x000000018B456230
		protected override void Subscribe(EventRouter router) {} // 0x000000018B456230-0x000000018B456304
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B456304-0x000000018B4563D8
		private void OnTransformParentChanged(ParadoxNotion.EventData msg) {} // 0x000000018B455F18-0x000000018B456018
		private void OnTransformChildrenChanged(ParadoxNotion.EventData msg) {} // 0x000000018B455E18-0x000000018B455F18
		private Transform _RegisterPorts_b__5_0() => default; // 0x0000000185FB02F0-0x0000000185FB0300
		private Transform _RegisterPorts_b__5_1() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private IEnumerable<Transform> _RegisterPorts_b__5_2() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class Trigger2DEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 48236
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents_Transform() {} // 0x000000018B457050-0x000000018B457084
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B456C30-0x000000018B456E18
		protected override void Subscribe(EventRouter router) {} // 0x000000018B456E18-0x000000018B456F34
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B456F34-0x000000018B457050
		private void OnTriggerEnter2D(EventData<Collider2D> msg) {} // 0x000000018B456990-0x000000018B456A70
		private void OnTriggerStay2D(EventData<Collider2D> msg) {} // 0x000000018B456B50-0x000000018B456C30
		private void OnTriggerExit2D(EventData<Collider2D> msg) {} // 0x000000018B456A70-0x000000018B456B50
		private Transform _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class Trigger2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 48237
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents() {} // 0x000000018B4571A0-0x000000018B4571D4
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B4566AC-0x000000018B456874
		protected override void Subscribe(EventRouter router) {} // 0x000000018B456874-0x000000018B456990
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B457084-0x000000018B4571A0
		private void OnTriggerEnter2D(EventData<Collider2D> msg) {} // 0x000000018B45640C-0x000000018B4564EC
		private void OnTriggerStay2D(EventData<Collider2D> msg) {} // 0x000000018B4565CC-0x000000018B4566AC
		private void OnTriggerExit2D(EventData<Collider2D> msg) {} // 0x000000018B4564EC-0x000000018B4565CC
		private Collider2D _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class TriggerEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 48238
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents_Transform() {} // 0x000000018B457E18-0x000000018B457E4C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B4579F8-0x000000018B457BE0
		protected override void Subscribe(EventRouter router) {} // 0x000000018B457BE0-0x000000018B457CFC
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B457CFC-0x000000018B457E18
		private void OnTriggerEnter(EventData<Collider> msg) {} // 0x000000018B457758-0x000000018B457838
		private void OnTriggerStay(EventData<Collider> msg) {} // 0x000000018B457918-0x000000018B4579F8
		private void OnTriggerExit(EventData<Collider> msg) {} // 0x000000018B457838-0x000000018B457918
		private Transform _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class TriggerEvents : RouterEventNode<Collider> // TypeDefIndex: 48239
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents() {} // 0x000000018B457F68-0x000000018B457F9C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B457474-0x000000018B45763C
		protected override void Subscribe(EventRouter router) {} // 0x000000018B45763C-0x000000018B457758
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B457E4C-0x000000018B457F68
		private void OnTriggerEnter(EventData<Collider> msg) {} // 0x000000018B4571D4-0x000000018B4572B4
		private void OnTriggerStay(EventData<Collider> msg) {} // 0x000000018B457394-0x000000018B457474
		private void OnTriggerExit(EventData<Collider> msg) {} // 0x000000018B4572B4-0x000000018B457394
		private Collider _RegisterPorts_b__5_0() => default; // 0x0000000185FB25D0-0x0000000185FB25E0
		private GameObject _RegisterPorts_b__5_1() => default; // 0x0000000185FB2360-0x0000000185FB2370
	}

	public class UIButtonEvent : EventNode<UnityEngine.UI.Button> // TypeDefIndex: 48240
	{
		// Fields
		private FlowOutput o; // 0xB8
	
		// Constructors
		public UIButtonEvent() {} // 0x000000018B458F04-0x000000018B458F38
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B458CDC-0x000000018B458DCC
		public override void OnGraphStoped() {} // 0x000000018B458C08-0x000000018B458CDC
		protected override void RegisterPorts() {} // 0x000000018B458DCC-0x000000018B458EBC
		private void OnClick() {} // 0x000000018B458BB8-0x000000018B458C08
		private UnityEngine.UI.Button _RegisterPorts_b__3_0() => default; // 0x000000018B458EBC-0x000000018B458F04
	}

	public class UIDropdownEvent : EventNode<Dropdown> // TypeDefIndex: 48241
	{
		// Fields
		private FlowOutput o; // 0xB8
		private int value; // 0xC0
	
		// Constructors
		public UIDropdownEvent() {} // 0x000000018B45932C-0x000000018B459360
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B45901C-0x000000018B45911C
		public override void OnGraphStoped() {} // 0x000000018B458F38-0x000000018B45901C
		protected override void RegisterPorts() {} // 0x000000018B459170-0x000000018B4592E4
		private void OnValueChanged(int value) {} // 0x000000018B45911C-0x000000018B459170
		private Dropdown _RegisterPorts_b__4_0() => default; // 0x000000018B4592E4-0x000000018B45932C
		private int _RegisterPorts_b__4_1() => default; // 0x0000000185FBE0C0-0x0000000185FBE0D0
	}

	public class UIInputFieldEvent : EventNode<InputField> // TypeDefIndex: 48242
	{
		// Fields
		private FlowOutput onValueChanged; // 0xB8
		private FlowOutput onEndEdit; // 0xC0
		private string value; // 0xC8
	
		// Constructors
		public UIInputFieldEvent() {} // 0x000000018B459914-0x000000018B459948
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B459530-0x000000018B4596B8
		public override void OnGraphStoped() {} // 0x000000018B4593C4-0x000000018B459530
		protected override void RegisterPorts() {} // 0x000000018B45971C-0x000000018B4598CC
		private void OnValueChanged(string value) {} // 0x000000018B4596B8-0x000000018B45971C
		private void OnEndEdit(string value) {} // 0x000000018B459360-0x000000018B4593C4
		private InputField _RegisterPorts_b__5_0() => default; // 0x000000018B4598CC-0x000000018B459914
		private string _RegisterPorts_b__5_1() => default; // 0x0000000185FB0300-0x0000000185FB0310
	}

	public class UIPointerEvents : RouterEventNode<Transform> // TypeDefIndex: 48244
	{
		// Fields
		private FlowOutput onPointerDown; // 0xC8
		private FlowOutput onPointerPressed; // 0xD0
		private FlowOutput onPointerUp; // 0xD8
		private FlowOutput onPointerEnter; // 0xE0
		private FlowOutput onPointerExit; // 0xE8
		private FlowOutput onPointerClick; // 0xF0
		private FlowOutput onPointerDrag; // 0xF8
		private FlowOutput onPointerDrop; // 0x100
		private FlowOutput onPointerScroll; // 0x108
		private GameObject receiver; // 0x110
		private PointerEventData eventData; // 0x118
		private bool updatePressed; // 0x120
	
		// Nested types
		private sealed class _UpdatePressed_d__17 : IEnumerator<object> // TypeDefIndex: 48243
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIPointerEvents __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B459A2C-0x000000018B459B30 
			object IEnumerator.Current { get => default; } // 0x000000018B45A8CC-0x000000018B45A928 
	
			// Constructors
			public _UpdatePressed_d__17() {} // Dummy constructor
			public _UpdatePressed_d__17(int __1__state) {} // 0x000000018B45A094-0x000000018B45A3CC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B45A3CC-0x000000018B45A64C
			private bool MoveNext() => default; // 0x000000018B45A64C-0x000000018B45A8CC
			void IEnumerator.Reset() {} // 0x000000018B459FA4-0x000000018B45A094
		}
	
		// Constructors
		public UIPointerEvents() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B459CF8-0x000000018B459DDC
		protected override void Subscribe(EventRouter router) {} // 0x000000018B459DDC-0x000000018B459EC0
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B459948-0x000000018B459A2C
		private void OnPointerDown(EventData<PointerEventData> msg) {} // 0x000000018B459B30-0x000000018B459C14
		private void OnPointerUp(EventData<PointerEventData> msg) {} // 0x000000018B459C14-0x000000018B459CF8
		private IEnumerator UpdatePressed() => default; // 0x000000018B459EC0-0x000000018B459FA4
		private void OnPointerEnter(EventData<PointerEventData> msg) {} // 0x000000018B45A928-0x000000018B45A95C
		private void OnPointerExit(EventData<PointerEventData> msg) {} // 0x0000000185FB8600-0x0000000185FB8610
		private void OnPointerClick(EventData<PointerEventData> msg) {} // 0x0000000185FB8540-0x0000000185FB8550
		private void OnPointerDrag(EventData<PointerEventData> msg) {} // 0x0000000181378230-0x0000000181378240
		private void OnPointerDrop(EventData<PointerEventData> msg) {} // 0x0000000185492010-0x0000000185492020
		private void OnPointerScroll(EventData<PointerEventData> msg) {} // 0x000000018B46DDC8-0x000000018B46DE54
		private GameObject _RegisterPorts_b__12_0() => default; // 0x000000018B46DE54-0x000000018B46DEA0
		private PointerEventData _RegisterPorts_b__12_1() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class UIScrollbarEvent : EventNode<Scrollbar> // TypeDefIndex: 48245
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UIScrollbarEvent() {} // 0x000000018B46E298-0x000000018B46E2CC
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B46DF84-0x000000018B46E084
		public override void OnGraphStoped() {} // 0x000000018B46DEA0-0x000000018B46DF84
		protected override void RegisterPorts() {} // 0x000000018B46E0DC-0x000000018B46E250
		private void OnValueChanged(float value) {} // 0x000000018B46E084-0x000000018B46E0DC
		private Scrollbar _RegisterPorts_b__4_0() => default; // 0x000000018B46E250-0x000000018B46E298
		private float _RegisterPorts_b__4_1() => default; // 0x0000000185FBECC0-0x0000000185FBECD0
	}

	public class UISliderEvent : EventNode<Slider> // TypeDefIndex: 48246
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UISliderEvent() {} // 0x000000018B46E66C-0x000000018B46E6A0
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B46E3B0-0x000000018B46E4B0
		public override void OnGraphStoped() {} // 0x000000018B46E2CC-0x000000018B46E3B0
		protected override void RegisterPorts() {} // 0x000000018B46E4B0-0x000000018B46E624
		private void OnValueChanged(float value) {} // 0x000000018B46E084-0x000000018B46E0DC
		private Slider _RegisterPorts_b__4_0() => default; // 0x000000018B46E624-0x000000018B46E66C
		private float _RegisterPorts_b__4_1() => default; // 0x0000000185FBECC0-0x0000000185FBECD0
	}

	public class UIToggleEvent : EventNode<UnityEngine.UI.Toggle> // TypeDefIndex: 48247
	{
		// Fields
		private FlowOutput o; // 0xB8
		private bool state; // 0xC0
	
		// Constructors
		public UIToggleEvent() {} // 0x000000018B46EA94-0x000000018B46EAC8
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B46E784-0x000000018B46E884
		public override void OnGraphStoped() {} // 0x000000018B46E6A0-0x000000018B46E784
		protected override void RegisterPorts() {} // 0x000000018B46E8D8-0x000000018B46EA4C
		private void OnValueChanged(bool state) {} // 0x000000018B46E884-0x000000018B46E8D8
		private UnityEngine.UI.Toggle _RegisterPorts_b__4_0() => default; // 0x000000018B46EA4C-0x000000018B46EA94
		private bool _RegisterPorts_b__4_1() => default; // 0x0000000185FB9C20-0x0000000185FB9C30
	}

	public class VisibilityEvents : RouterEventNode<Transform> // TypeDefIndex: 48248
	{
		// Fields
		private FlowOutput onVisible; // 0xC8
		private FlowOutput onInvisible; // 0xD0
		private GameObject receiver; // 0xD8
	
		// Constructors
		public VisibilityEvents() {} // 0x000000018B46F5FC-0x000000018B46F630
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B46F32C-0x000000018B46F454
		protected override void Subscribe(EventRouter router) {} // 0x000000018B46F454-0x000000018B46F528
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018B46F528-0x000000018B46F5FC
		private void OnBecameVisible(ParadoxNotion.EventData msg) {} // 0x000000018B46F278-0x000000018B46F32C
		private void OnBecameInvisible(ParadoxNotion.EventData msg) {} // 0x000000018B46F1C4-0x000000018B46F278
		private GameObject _RegisterPorts_b__3_0() => default; // 0x0000000185FB02F0-0x0000000185FB0300
	}

	public class ConditionalUpdateEvent : EventNode, IUpdatable // TypeDefIndex: 48249
	{
		// Fields
		private FlowOutput becameTrue; // 0xB0
		private FlowOutput becameFalse; // 0xB8
		private ValueInput<bool> condition; // 0xC0
		private bool lastState; // 0xC8
	
		// Constructors
		public ConditionalUpdateEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B45DEEC-0x000000018B45DFD0
		public void Update() {} // 0x000000018B45DFD0-0x000000018B45E0BC
	}

	public class DebugEvent : EventNode // TypeDefIndex: 48250
	{
		// Constructors
		public DebugEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class OscillatorEvent : EventNode, IUpdatable // TypeDefIndex: 48251
	{
		// Fields
		public BBParameter<AnimationCurve> curve; // 0xB0
		private float time; // 0xB8
		private float value; // 0xBC
		private FlowOutput hi; // 0xC0
		private FlowOutput low; // 0xC8
	
		// Constructors
		public OscillatorEvent() {} // 0x000000018B46318C-0x000000018B46333C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B462F6C-0x000000018B463094
		public override void OnGraphStarted() {} // 0x0000000185FD2880-0x0000000185FD2890
		public void Update() {} // 0x000000018B463094-0x000000018B46318C
		private float _RegisterPorts_b__6_0() => default; // 0x0000000185FB9B20-0x0000000185FB9B30
	}

	public class VariableChangedEvent : EventNode // TypeDefIndex: 48252
	{
		// Fields
		public BBObjectParameter targetVariable; // 0xB0
		private FlowOutput fOut; // 0xB8
		private object newValue; // 0xC0
	
		// Properties
		public override string name { get => default; } // 0x000000018B46EE34-0x000000018B46EE84 
	
		// Constructors
		public VariableChangedEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B46EAC8-0x000000018B46EBBC
		public override void OnGraphStoped() {} // 0x000000018B46EBBC-0x000000018B46EC70
		protected override void RegisterPorts() {} // 0x000000018B46ED28-0x000000018B46EE34
		private void OnValueChanged(object value) {} // 0x000000018B46EC70-0x000000018B46ECD4
		private void OnVariableRefChange(Variable newVarRef) {} // 0x000000018B46ECD4-0x000000018B46ED28
		private object _RegisterPorts_b__7_0() => default; // 0x0000000181B388F0-0x0000000181B38900
	}

	public class Chance : FlowControlNode // TypeDefIndex: 48254
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48253
		{
			// Fields
			public ValueInput<float> min; // 0x10
			public ValueInput<float> max; // 0x18
			public ValueInput<float> chance; // 0x20
			public FlowOutput success; // 0x28
			public FlowOutput failure; // 0x30
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018B45DC38-0x000000018B45DE4C
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public Chance() {} // 0x000000018B46BFC4-0x000000018B46C078
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Cooldown : FlowControlNode // TypeDefIndex: 48256
	{
		// Fields
		private Coroutine coroutine; // 0xB0
		private float remaining; // 0xB8
		private float remainingNormalized; // 0xBC
		private FlowOutput start; // 0xC0
		private FlowOutput finish; // 0xC8
		private FlowOutput update; // 0xD0
		private ValueInput<float> time; // 0xD8
	
		// Properties
		public override string name { get => default; } // 0x000000018B45E174-0x000000018B45E200 
	
		// Nested types
		private sealed class _CountDown_d__14 : IEnumerator<object> // TypeDefIndex: 48255
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Cooldown __4__this; // 0x20
			public Flow f; // 0x28
			private float _total_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B45E21C-0x000000018B45E558 
			object IEnumerator.Current { get => default; } // 0x000000018B45E12C-0x000000018B45E174 
	
			// Constructors
			public _CountDown_d__14() {} // Dummy constructor
			public _CountDown_d__14(int __1__state) {} // 0x000000018B45E57C-0x000000018B45E600
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B45E200-0x000000018B45E21C
			private bool MoveNext() => default; // 0x000000018B45E12C-0x000000018B45E174
			void IEnumerator.Reset() {} // 0x000000018B45E0BC-0x000000018B45E12C
		}
	
		// Constructors
		public Cooldown() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000183055FD0-0x0000000183055FE0
		public override void OnGraphStoped() {} // 0x000000018B45E558-0x000000018B45E56C
		protected override void RegisterPorts() {} // 0x000000018B45E56C-0x000000018B45E57C
		private void Begin(Flow f) {} // 0x0000000181378230-0x0000000181378240
		private void Cancel(Flow f) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator CountDown(Flow f) => default; // 0x000000018B46A308-0x000000018B46A518
		private float _RegisterPorts_b__11_0() => default; // 0x000000018B46A518-0x000000018B46A564
		private float _RegisterPorts_b__11_1() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class DoOnce : FlowControlNode // TypeDefIndex: 48258
	{
		// Fields
		private bool called; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48257
		{
			// Fields
			public DoOnce __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x0000000185FD27D0-0x0000000185FD27E0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B45FE08-0x000000018B45FF80
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public DoOnce() {} // 0x000000018B46CD70-0x000000018B46CD90
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		protected override void RegisterPorts() {} // 0x000000018B46CC10-0x000000018B46CC70
	}

	public class ReadFlowParameter<T> : FlowControlNode // TypeDefIndex: 48260
	{
		// Fields
		private T flowValue;
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48259
		{
			// Fields
			public ReadFlowParameter<T> __4__this;
			public ValueInput<string> pName;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReadFlowParameter() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class WriteFlowParameter<T> : FlowControlNode // TypeDefIndex: 48262
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48261
		{
			// Fields
			public ValueInput<string> pName;
			public ValueInput<T> pValue;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass0_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		public WriteFlowParameter() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class LatchBool : FlowControlNode // TypeDefIndex: 48264
	{
		// Fields
		private bool latched; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48263
		{
			// Fields
			public LatchBool __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B461A94-0x000000018B461C94
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000185492010-0x0000000185492020
			internal bool _RegisterPorts_b__2() => default; // 0x000000018B46C730-0x000000018B46C784
		}
	
		// Constructors
		public LatchBool() {} // 0x00000001889C0DC0-0x00000001889C0DE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B46CB24-0x000000018B46CB78
	}

	public class LatchInt : FlowControlNode // TypeDefIndex: 48267
	{
		// Fields
		private int _portCount; // 0xB0
		private int latched; // 0xB4
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48265
		{
			// Fields
			public LatchInt __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018B461C94-0x000000018B461E8C
	
			// Methods
			internal int _RegisterPorts_b__0() => default; // 0x0000000189D76630-0x0000000189D76644
		}
	
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 48266
		{
			// Fields
			public int i; // 0x10
			public __c__DisplayClass2_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass2_1() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000189378074-0x0000000189378094
		}
	
		// Constructors
		public LatchInt() {} // 0x000000018B46CD90-0x000000018B46CDF8
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ANDMerge : FlowControlNode // TypeDefIndex: 48269
	{
		// Fields
		private int _portCount; // 0xB0
		public float maxAwaitTime; // 0xB4
		private FlowOutput fOut; // 0xB8
		private float[] calls; // 0xC0
		private int lastFrameCall; // 0xC8
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48268
		{
			// Fields
			public int i; // 0x10
			public ANDMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018B45C1C8-0x000000018B45C1D0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B45C1D0-0x000000018B45C34C
		}
	
		// Constructors
		public ANDMerge() {} // 0x000000018B46D5AC-0x000000018B46D5F8
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B45C34C-0x000000018B45C390
		protected override void RegisterPorts() {} // 0x000000018B45C0B4-0x000000018B45C1C8
		private void Reset() {} // 0x000000018B45C390-0x000000018B45C3A4
		private void Check(int index, Flow f) {} // 0x0000000185492010-0x0000000185492020
	}

	public class AwaitAll : FlowControlNode // TypeDefIndex: 48271
	{
		// Fields
		private int _portCount; // 0xB0
		public float maxAwaitTime; // 0xB4
		private FlowOutput fOut; // 0xB8
		private float[] calls; // 0xC0
		private int lastFrameCall; // 0xC8
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48270
		{
			// Fields
			public int i; // 0x10
			public AwaitAll __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018B45C1C8-0x000000018B45C1D0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B45C704-0x000000018B45C880
		}
	
		// Constructors
		public AwaitAll() {} // 0x000000018B46D5AC-0x000000018B46D5F8
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B45C34C-0x000000018B45C390
		protected override void RegisterPorts() {} // 0x000000018B45C0B4-0x000000018B45C1C8
		private void Reset() {} // 0x000000018B45C880-0x000000018B45C89C
		private void Check(int index, Flow f) {} // 0x0000000185492010-0x0000000185492020
	}

	public class ORMerge : FlowControlNode // TypeDefIndex: 48273
	{
		// Fields
		private int _portCount; // 0xB0
		private FlowOutput fOut; // 0xB8
		private int lastFrameCall; // 0xC0
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48272
		{
			// Fields
			public int i; // 0x10
			public ORMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018B462CD4-0x000000018B462E20
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B462C60-0x000000018B462CD4
		}
	
		// Constructors
		public ORMerge() {} // 0x000000018B46CEE0-0x000000018B46CF2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B45C390-0x000000018B45C3A4
		private void Check(int index, Flow f) {} // 0x0000000185492010-0x0000000185492020
	}

	public class XORMerge : FlowControlNode // TypeDefIndex: 48275
	{
		// Fields
		private int _portCount; // 0xB0
		private FlowOutput fOut; // 0xB8
		private int[] calls; // 0xC0
		private int lastFrameCall; // 0xC8
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48274
		{
			// Fields
			public int i; // 0x10
			public XORMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018B46FCE4-0x000000018B46FE60
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B46FC04-0x000000018B46FCE4
		}
	
		// Constructors
		public XORMerge() {} // 0x000000018B46D124-0x000000018B46D170
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B45C390-0x000000018B45C3A4
		private void Check(int index, Flow f) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class FlowControlNode : FlowNode // TypeDefIndex: 48276
	{
		// Constructors
		protected FlowControlNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public class Break : FlowControlNode // TypeDefIndex: 48277
	{
		// Constructors
		public Break() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B45DA64-0x000000018B45DB0C
		private void _RegisterPorts_b__0_0(Flow f) {} // 0x000000018B45DB0C-0x000000018B45DB28
	}

	public class ForEach : FlowControlNode // TypeDefIndex: 48279
	{
		// Fields
		private object currentObject; // 0xB0
		private int currentIndex; // 0xB8
		private bool broken; // 0xBC
		private ValueInput<IEnumerable> enumerableInput; // 0xC0
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48278
		{
			// Fields
			public ForEach __4__this; // 0x10
			public FlowOutput fFinish; // 0x18
			public FlowOutput fCurrent; // 0x20
			public FlowBreak __9__4; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018B460CCC-0x000000018B460FC8
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B460B38-0x000000018B460B88
			internal int _RegisterPorts_b__1() => default; // 0x000000018B460B88-0x000000018B460CCC
			internal void _RegisterPorts_b__2(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
			internal void _RegisterPorts_b__4() {} // 0x0000000185492010-0x0000000185492020
			internal void _RegisterPorts_b__3(Flow f) {} // 0x00000001889C0464-0x00000001889C0484
		}
	
		// Constructors
		public ForEach() {} // 0x000000018937CC9C-0x000000018937CCBC
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000187B5E818-0x0000000187B5E838
		public override System.Type GetNodeWildDefinitionType() => default; // 0x000000018B46D170-0x000000018B46D554
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x000000018937CC9C-0x000000018937CCBC
	}

	public class ForEach<T> : FlowControlNode // TypeDefIndex: 48281
	{
		// Fields
		private T currentObject;
		private int currentIndex;
		private bool broken;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48280
		{
			// Fields
			public ForEach<T> __4__this;
			public ValueInput<IEnumerable<T>> list;
			public FlowOutput fFinish;
			public FlowOutput fCurrent;
			public FlowBreak __9__4;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
			internal int _RegisterPorts_b__1() => default;
			internal void _RegisterPorts_b__2(Flow f) {}
			internal void _RegisterPorts_b__4() {}
			internal void _RegisterPorts_b__3(Flow f) {}
		}
	
		// Constructors
		public ForEach() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class ForLoop : FlowControlNode // TypeDefIndex: 48283
	{
		// Fields
		public bool reverse; // 0xB0
		private int current; // 0xB4
		private bool broken; // 0xB8
		private ValueInput<int> first; // 0xC0
		private ValueInput<int> last; // 0xC8
		private ValueInput<int> step; // 0xD0
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48282
		{
			// Fields
			public ForLoop __4__this; // 0x10
			public FlowOutput fCurrent; // 0x18
			public FlowOutput fFinish; // 0x20
			public FlowBreak __9__3; // 0x28
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018B460FC8-0x000000018B4612E4
	
			// Methods
			internal int _RegisterPorts_b__0() => default; // 0x0000000183055FD0-0x0000000183055FE0
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000185492010-0x0000000185492020
			internal void _RegisterPorts_b__3() {} // 0x0000000189378074-0x0000000189378094
			internal void _RegisterPorts_b__2(Flow f) {} // 0x000000018B46D654-0x000000018B46D92C
		}
	
		// Constructors
		public ForLoop() {} // 0x000000018937CD5C-0x000000018937CD7C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018937CD5C-0x000000018937CD7C
	}

	public class Dummy : FlowControlNode // TypeDefIndex: 48285
	{
		// Properties
		public override string name { get => default; } // 0x0000000183055FD0-0x0000000183055FE0 
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48284
		{
			// Fields
			public FlowOutput fOut; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B45FF80-0x000000018B460084
		}
	
		// Constructors
		public Dummy() {} // 0x000000018B46CC70-0x000000018B46CCB4
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Finish : FlowControlNode // TypeDefIndex: 48287
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48286
		{
			// Fields
			public Finish __4__this; // 0x10
			public ValueInput<bool> c; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018B4604F8-0x000000018B46061C
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public Finish() {} // 0x000000018B46BF54-0x000000018B46BFC4
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class GoToLabel : FlowControlNode, IEditorMenuCallbackReceiver // TypeDefIndex: 48288
	{
		// Fields
		public string identifier; // 0xB0
		private FlowOutput _port_k__BackingField; // 0xB8
	
		// Properties
		public FlowOutput port { get; private set; } // 0x000000018349D710-0x000000018349D720 0x0000000187A47500-0x0000000187A47514
		public override string name { get => default; } // 0x000000018B46144C-0x000000018B4614A4 
	
		// Constructors
		public GoToLabel() {} // 0x000000018B4613FC-0x000000018B46144C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B461398-0x000000018B4613FC
	}

	public class GoToStatement : FlowControlNode, IHaveNodeReference // TypeDefIndex: 48289
	{
		// Fields
		public NodeReference<GoToLabel> _targetLabel; // 0xB0
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get => default; } // 0x000000018346D8F0-0x000000018346D900 
		private GoToLabel target { get => default; } // 0x000000018B4616DC-0x000000018B46172C 
		public override string name { get => default; } // 0x000000018B46164C-0x000000018B4616DC 
	
		// Constructors
		public GoToStatement() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public void SetTarget(GoToLabel newTarget) {} // 0x000000018B46154C-0x000000018B4615D8
		protected override void RegisterPorts() {} // 0x000000018B4614A4-0x000000018B46154C
		private void _RegisterPorts_b__8_0(Flow f) {} // 0x000000018B4615D8-0x000000018B46164C
	}

	public class Merge : FlowControlNode // TypeDefIndex: 48290
	{
		// Fields
		private int _portCount; // 0xB0
	
		// Constructors
		public Merge() {} // 0x0000000189D76630-0x0000000189D76644
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B462784-0x000000018B462880
	}

	public class Split : FlowControlNode // TypeDefIndex: 48292
	{
		// Fields
		private int _portCount; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48291
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public Split __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B468028-0x000000018B4681C4
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000189D76630-0x0000000189D76644
		}
	
		// Constructors
		public Split() {} // 0x000000018B46C894-0x000000018B46C93C
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TryCatch : FlowControlNode // TypeDefIndex: 48294
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48293
		{
			// Fields
			public FlowOutput fTry; // 0x10
			public FlowOutput fCatch; // 0x18
			public FlowOutput fFinally; // 0x20
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018B469BD8-0x000000018B469D44
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public TryCatch() {} // 0x000000018B46C1D8-0x000000018B46C368
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CoroutineState : FlowControlNode // TypeDefIndex: 48297
	{
		// Fields
		private bool active; // 0xB0
		private Coroutine coroutine; // 0xB8
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48295
		{
			// Fields
			public CoroutineState __4__this; // 0x10
			public FlowOutput fStart; // 0x18
			public FlowOutput fUpdate; // 0x20
			public FlowOutput fFinish; // 0x28
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018B45E6D0-0x000000018B45E700
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B45E700-0x000000018B45E8D0
			internal void _RegisterPorts_b__1(Flow f) {} // 0x000000018B45E600-0x000000018B45E6D0
		}
	
		private sealed class _DoRepeat_d__4 : IEnumerator<object> // TypeDefIndex: 48296
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FlowOutput fStart; // 0x20
			public Flow f; // 0x28
			public CoroutineState __4__this; // 0x50
			public FlowOutput fUpdate; // 0x58
			public FlowOutput fFinish; // 0x60
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B46CF2C-0x000000018B46CFD4 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public _DoRepeat_d__4() {} // Dummy constructor
			public _DoRepeat_d__4(int __1__state) {} // 0x0000000183055FD0-0x0000000183055FE0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FD27D0-0x0000000185FD27E0
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x000000018B46CD70-0x000000018B46CD90
		}
	
		// Constructors
		public CoroutineState() {} // 0x000000018B46A730-0x000000018B46A77C
	
		// Methods
		public override void OnGraphStoped() {} // 0x0000000185492010-0x0000000185492020
		protected override void RegisterPorts() {} // 0x000000018B46A564-0x000000018B46A730
		private IEnumerator DoRepeat(FlowOutput fStart, FlowOutput fUpdate, FlowOutput fFinish, Flow f) => default; // 0x0000000181377E40-0x0000000181377E50
		private void _DoRepeat_b__4_0() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class While : FlowControlNode // TypeDefIndex: 48301
	{
		// Fields
		private Coroutine coroutine; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48298
		{
			// Fields
			public While __4__this; // 0x10
			public FlowOutput fUpdate; // 0x18
			public FlowOutput fFinish; // 0x20
			public ValueInput<bool> c; // 0x28
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018B46FA20-0x000000018B46FA38
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B46FA38-0x000000018B46FA7C
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48299
		{
			// Fields
			public bool active; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018B46FA7C-0x000000018B46FC04
	
			// Methods
			internal void _DoWhile_b__0() {} // 0x000000018B46F950-0x000000018B46FA20
		}
	
		private sealed class _DoWhile_d__4 : IEnumerator<object> // TypeDefIndex: 48300
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Flow f; // 0x20
			public While __4__this; // 0x48
			public FlowOutput fUpdate; // 0x50
			private __c__DisplayClass4_0 __8__1; // 0x58
			public ValueInput<bool> condition; // 0x60
			public FlowOutput fFinish; // 0x68
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public _DoWhile_d__4() {} // Dummy constructor
			public _DoWhile_d__4(int __1__state) {} // 0x0000000183055FD0-0x0000000183055FE0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018B46CE48-0x000000018B46CEE0
			void IEnumerator.Reset() {} // 0x0000000185FB6A70-0x0000000185FB6A80
		}
	
		// Constructors
		public While() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		public override void OnGraphStoped() {} // 0x000000018B46A77C-0x000000018B46A9AC
		protected override void RegisterPorts() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator DoWhile(FlowOutput fUpdate, FlowOutput fFinish, Flow f, ValueInput<bool> condition) => default; // 0x000000018B46A9AC-0x000000018B46A9F8
	}

	public class SelectOnBool<T> : FlowControlNode // TypeDefIndex: 48302
	{
		// Fields
		private ValueInput<bool> condition;
		private ValueInput<T> isTrue;
		private ValueInput<T> isFalse;
		private ValueOutput<T> result;
	
		// Constructors
		public SelectOnBool() {}
	
		// Methods
		protected override void RegisterPorts() {}
		private T _RegisterPorts_b__4_0() => default;
	}

	public class SelectOnEnum<T> : FlowControlNode // TypeDefIndex: 48304
	{
		// Fields
		private SerializedTypeInfo _type;
	
		// Properties
		private System.Type type { get => default; set {} }
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48303
		{
			// Fields
			public ValueInput selector;
			public ValueInput<T>[] cases;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
		}
	
		// Constructors
		public SelectOnEnum() {}
	
		// Methods
		protected override void RegisterPorts() {}
		public override System.Type GetNodeWildDefinitionType() => default;
		public override void OnPortConnected(Port port, Port otherPort) {}
	}

	public class SelectOnInt<T> : FlowControlNode // TypeDefIndex: 48306
	{
		// Fields
		private int _portCount;
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48305
		{
			// Fields
			public ValueInput<int> selector;
			public ValueInput<T>[] cases;
			public ValueInput<T> defaultCase;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
		}
	
		// Constructors
		public SelectOnInt() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class SelectOnString<T> : FlowControlNode // TypeDefIndex: 48308
	{
		// Fields
		public List<string> stringCases;
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48307
		{
			// Fields
			public ValueInput<string> selector;
			public SelectOnString<T> __4__this;
			public ValueInput<T>[] cases;
			public ValueInput<T> defaultCase;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
		}
	
		// Constructors
		public SelectOnString() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class SelectOnTag<T> : FlowControlNode // TypeDefIndex: 48310
	{
		// Fields
		private string[] _tagNames;
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48309
		{
			// Fields
			public ValueInput<GameObject> selector;
			public SelectOnTag<T> __4__this;
			public ValueInput<T>[] cases;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
		}
	
		// Constructors
		public SelectOnTag() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class Random : FlowControlNode // TypeDefIndex: 48312
	{
		// Fields
		private int _portCount; // 0xB0
		private int current; // 0xB4
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48311
		{
			// Fields
			public Random __4__this; // 0x10
			public List<FlowOutput> outs; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018B464EFC-0x000000018B465124
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000189D76630-0x0000000189D76644
			internal int _RegisterPorts_b__1() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public Random() {} // 0x0000000189378074-0x0000000189378094
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B46CCB4-0x000000018B46CD70
	}

	public class SwitchBool : FlowControlNode // TypeDefIndex: 48314
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48313
		{
			// Fields
			public ValueInput<bool> selector; // 0x10
			public FlowOutput caseTrue; // 0x18
			public FlowOutput caseFalse; // 0x20
			public FlowOutput caseThen; // 0x28
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018B4681C4-0x000000018B468370
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public SwitchBool() {} // 0x000000018B46BED8-0x000000018B46BF54
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SwitchComparison : FlowControlNode // TypeDefIndex: 48316
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48315
		{
			// Fields
			public ValueInput<IComparable> a; // 0x10
			public ValueInput<IComparable> b; // 0x18
			public FlowOutput equal; // 0x20
			public FlowOutput notEqual; // 0x28
			public FlowOutput greater; // 0x30
			public FlowOutput less; // 0x38
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018B468370-0x000000018B4685B8
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public SwitchComparison() {} // 0x000000018B46C078-0x000000018B46C1D8
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SwitchEnum : FlowControlNode // TypeDefIndex: 48318
	{
		// Fields
		private SerializedTypeInfo _type; // 0xB0
	
		// Properties
		private System.Type type { get => default; set {} } // 0x000000018B468718-0x000000018B4689E4 0x000000018B4685B8-0x000000018B468608
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48317
		{
			// Fields
			public ValueInput selector; // 0x10
			public Dictionary<string, FlowOutput> cases; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x0000000189D7160C-0x0000000189D71620
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B4689E4-0x000000018B468A94
		}
	
		// Constructors
		public SwitchEnum() {} // 0x000000018B46D06C-0x000000018B46D124
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B468608-0x000000018B468718
		public override System.Type GetNodeWildDefinitionType() => default; // 0x0000000183055FD0-0x0000000183055FE0
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000185492010-0x0000000185492020
	}

	public class SwitchInt : FlowControlNode // TypeDefIndex: 48320
	{
		// Fields
		private int _portCount; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48319
		{
			// Fields
			public ValueInput<int> selector; // 0x10
			public FlowOutput[] cases; // 0x18
			public FlowOutput defaultCase; // 0x20
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B468D64-0x000000018B468F4C
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000189D76630-0x0000000189D76644
		}
	
		// Constructors
		public SwitchInt() {} // 0x000000018B46CAA0-0x000000018B46CB24
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SwitchIntCustom : FlowControlNode // TypeDefIndex: 48322
	{
		// Fields
		public List<int> intCases; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48321
		{
			// Fields
			public ValueInput<int> selector; // 0x10
			public SwitchIntCustom __4__this; // 0x18
			public FlowOutput[] cases; // 0x20
			public FlowOutput defaultCase; // 0x28
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B468A94-0x000000018B468CDC
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B468CDC-0x000000018B468D64
		}
	
		// Constructors
		public SwitchIntCustom() {} // 0x000000018B46C93C-0x000000018B46CAA0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SwitchProbability : FlowControlNode // TypeDefIndex: 48323
	{
		// Fields
		private int _portCount; // 0xB0
		private List<ValueInput<float>> probabilityValues; // 0xB8
		private List<FlowOutput> probabilityOuts; // 0xC0
		private float[] cacheValues; // 0xC8
		private int current; // 0xD0
	
		// Constructors
		public SwitchProbability() {} // 0x000000018B45C390-0x000000018B45C3A4
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B469108-0x000000018B46943C
		private void Enter(Flow f) {} // 0x000000018B468F4C-0x000000018B469108
		private int _RegisterPorts_b__5_0() => default; // 0x0000000185FB2380-0x0000000185FB2390
	}

	public class SwitchString : FlowControlNode // TypeDefIndex: 48325
	{
		// Fields
		public List<string> comparisonOutputs; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48324
		{
			// Fields
			public ValueInput<string> selector; // 0x10
			public SwitchString __4__this; // 0x18
			public FlowOutput[] cases; // 0x20
			public FlowOutput defaultCase; // 0x28
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B46943C-0x000000018B469688
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B469688-0x000000018B469710
		}
	
		// Constructors
		public SwitchString() {} // 0x000000018B46C5AC-0x000000018B46C730
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SwitchTag : FlowControlNode // TypeDefIndex: 48327
	{
		// Fields
		private string[] _tagNames; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48326
		{
			// Fields
			public SwitchTag __4__this; // 0x10
			public ValueInput<GameObject> selector; // 0x18
			public FlowOutput[] cases; // 0x20
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B469710-0x000000018B4698E8
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public SwitchTag() {} // 0x000000018B46C784-0x000000018B46C894
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class FlipFlop : FlowControlNode // TypeDefIndex: 48329
	{
		// Fields
		public bool isFlip; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get => default; } // 0x000000018B46084C-0x000000018B46085C 
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48328
		{
			// Fields
			public FlipFlop __4__this; // 0x10
			public FlowOutput fFlip; // 0x18
			public FlowOutput fFlop; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018B46085C-0x000000018B4608D4
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000185FD27E0-0x0000000185FD27F0
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000185FD27F0-0x0000000185FD2800
			internal bool _RegisterPorts_b__2() => default; // 0x000000018B46061C-0x000000018B46084C
		}
	
		// Constructors
		public FlipFlop() {} // 0x00000001889C0DC0-0x00000001889C0DE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		public override void OnGraphStoped() {} // 0x000000018B46D554-0x000000018B46D5AC
		protected override void RegisterPorts() {} // 0x000000018B46CD70-0x000000018B46CD90
	}

	public class MultiToggle : FlowControlNode // TypeDefIndex: 48331
	{
		// Fields
		private int _portCount; // 0xB0
		public int current; // 0xB4
		private int original; // 0xB8
	
		// Properties
		public override string name { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 48330
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public MultiToggle __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018B462BAC-0x000000018B462C30
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B462880-0x000000018B4628BC
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000185FD2870-0x0000000185FD2880
			internal void _RegisterPorts_b__2(Flow f) {} // 0x000000018B4628BC-0x000000018B462BAC
			internal int _RegisterPorts_b__3() => default; // 0x0000000189D76630-0x0000000189D76644
		}
	
		// Constructors
		public MultiToggle() {} // 0x000000018B46DBC4-0x000000018B46DBE4
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B46D954-0x000000018B46D9E8
		public override void OnGraphStoped() {} // 0x000000018B46DAD8-0x000000018B46DB1C
		protected override void RegisterPorts() {} // 0x000000018B46DB1C-0x000000018B46DB60
	}

	public class Sequence : FlowControlNode // TypeDefIndex: 48333
	{
		// Fields
		private int _portCount; // 0xB0
		public int current; // 0xB4
		private int original; // 0xB8
	
		// Properties
		public override string name { get => default; } // 0x000000018B46D9E8-0x000000018B46DAB4 
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 48332
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public Sequence __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018B462880-0x000000018B4628BC
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000185FD2870-0x0000000185FD2880
			internal void _RegisterPorts_b__1(Flow f) {} // 0x000000018B467940-0x000000018B4679C4
			internal int _RegisterPorts_b__2() => default; // 0x000000018B4676B4-0x000000018B467940
		}
	
		// Constructors
		public Sequence() {} // 0x000000018B46DBC4-0x000000018B46DBE4
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189D76630-0x0000000189D76644
		public override void OnGraphStoped() {} // 0x0000000185492010-0x0000000185492020
		protected override void RegisterPorts() {} // 0x000000018B46DAB4-0x000000018B46DAD8
	}

	public class Toggle : FlowControlNode // TypeDefIndex: 48335
	{
		// Fields
		public bool open; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48334
		{
			// Fields
			public Toggle __4__this; // 0x10
			public FlowOutput fOn; // 0x18
			public FlowOutput fOff; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018B469B60-0x000000018B469BD8
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x0000000185FD27E0-0x0000000185FD27F0
			internal void _RegisterPorts_b__1(Flow f) {} // 0x0000000185FD27F0-0x0000000185FD2800
			internal void _RegisterPorts_b__2(Flow f) {} // 0x000000018B4698E8-0x000000018B469B60
			internal void _RegisterPorts_b__3(Flow f) {} // 0x000000018B46084C-0x000000018B46085C
		}
	
		// Constructors
		public Toggle() {} // 0x000000018B46D92C-0x000000018B46D954
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B46D5F8-0x000000018B46D634
		public override void OnGraphStoped() {} // 0x000000018B46D634-0x000000018B46D654
		protected override void RegisterPorts() {} // 0x000000018B46CD70-0x000000018B46CD90
	}

	public class CustomFunctionCall : FlowControlNode // TypeDefIndex: 48336
	{
		// Fields
		private string _sourceOutputUID; // 0xB0
		private ValueInput[] portArgs; // 0xB8
		private object[] objectArgs; // 0xC0
		private FlowOutput fOut; // 0xC8
		private WeakReference<CustomFunctionEvent> _sourceFunctionRef; // 0xD0
	
		// Properties
		private string sourceFunctionUID { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x0000000184784C70-0x0000000184784C90
		public CustomFunctionEvent sourceFunction { get => default; } // 0x000000018B45EF7C-0x000000018B45F0D8 
		public override string name { get => default; } // 0x000000018B45EEF4-0x000000018B45EF7C 
		public override string description { get => default; } // 0x000000018B45EE90-0x000000018B45EEF4 
	
		// Constructors
		public CustomFunctionCall() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public void SetFunction(CustomFunctionEvent func) {} // 0x000000018B45ED98-0x000000018B45EE58
		protected override void RegisterPorts() {} // 0x000000018B45EA7C-0x000000018B45ED98
		private void Invoke(Flow f) {} // 0x000000018B45E8D0-0x000000018B45EA7C
		private bool _get_sourceFunction_b__9_0(CustomFunctionEvent i) => default; // 0x000000018B45EE58-0x000000018B45EE90
	}

	public class CustomFunctionEvent : EventNode, IInvokable, IEditorMenuCallbackReceiver // TypeDefIndex: 48341
	{
		// Fields
		public string identifier; // 0xB0
		private List<DynamicParameterDefinition> _parameters; // 0xB8
		private DynamicParameterDefinition _returns; // 0xC0
		private object[] args; // 0xC8
		private object returnValue; // 0xD0
		private FlowOutput onInvoke; // 0xD8
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get => default; private set {} } // 0x000000018346D8F0-0x000000018346D900 0x000000018B45F72C-0x000000018B45F76C
		public DynamicParameterDefinition returns { get => default; private set {} } // 0x000000018B45F61C-0x000000018B45F72C 0x000000018B45F514-0x000000018B45F61C
		private System.Type returnType { get => default; } // 0x000000018B45F390-0x000000018B45F514 
		private System.Type[] parameterTypes { get => default; } // 0x0000000185FB15A0-0x0000000185FB15B0 
		public override string name { get => default; } // 0x000000018B45F0D8-0x000000018B45F1B4 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48337
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<DynamicParameterDefinition, System.Type> __9__15_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018349D710-0x000000018349D720
			public __c() {} // 0x0000000187A47500-0x0000000187A47514
	
			// Methods
			internal System.Type _get_parameterTypes_b__15_0(DynamicParameterDefinition p) => default; // 0x0000000181B388F0-0x0000000181B38900
		}
	
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 48338
		{
			// Fields
			public int i; // 0x10
			public CustomFunctionEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x0000000187A47C1C-0x0000000187A47C30
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B45FBD4-0x000000018B45FBF4
		}
	
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 48339
		{
			// Fields
			public Action<object> callback; // 0x10
			public CustomFunctionEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0() {} // 0x000000018B45FAAC-0x000000018B45FBD4
	
			// Methods
			internal void _NodeCanvas.Framework.IInvokable.InvokeAsync_b__0(Flow f) {} // 0x000000018B45FA6C-0x000000018B45FAAC
		}
	
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 48340
		{
			// Fields
			public CustomFunctionEvent __4__this; // 0x10
			public FlowHandler flowCallback; // 0x18
			public Flow f; // 0x20
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x000000018B45F76C-0x000000018B45F7A0
	
			// Methods
			internal void _InvokeAsync_b__0(object o) {} // 0x000000018B45F7A0-0x000000018B45F93C
		}
	
		// Constructors
		public CustomFunctionEvent() {} // 0x000000018B46CB78-0x000000018B46CBAC
	
		// Methods
		public override void OnGraphStoped() {} // 0x000000018B45F1B4-0x000000018B45F390
		protected override void RegisterPorts() {} // 0x000000018B45F96C-0x000000018B45FA6C
		string IInvokable.GetInvocationID() => default; // 0x000000018774BD78-0x000000018774BD8C
		object IInvokable.Invoke(object[] args) => default; // 0x000000018B45F93C-0x000000018B45F96C
		void IInvokable.InvokeAsync(Action<object> callback, object[] args) {} // 0x000000018B46DC9C-0x000000018B46DD00
		public object Invoke(Flow f, object[] args) => default; // 0x0000000185492010-0x0000000185492020
		public void InvokeAsync(Flow f, FlowHandler flowCallback, object[] args) {} // 0x000000018B46BEC0-0x000000018B46BED8
		public object GetReturnValue() => default; // 0x0000000185492010-0x0000000185492020
		private void AddParameter(System.Type type) {} // 0x000000018B46C50C-0x000000018B46C544
		private void GatherPortsUpdateRefs() {} // 0x0000000185492010-0x0000000185492020
		private void _Invoke_b__23_0(object o) {} // 0x0000000185492010-0x0000000185492020
		private bool _GatherPortsUpdateRefs_b__27_0(CustomFunctionCall n) => default; // 0x000000018B46CBAC-0x000000018B46CC10
	}

	public class Return : FlowControlNode // TypeDefIndex: 48342
	{
		// Fields
		public bool useReturnValue; // 0xB0
		private ValueInput<object> returnPort; // 0xB8
	
		// Constructors
		public Return() {} // 0x000000018B46084C-0x000000018B46085C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B467460-0x000000018B467558
		private void _RegisterPorts_b__2_0(Flow f) {} // 0x000000018B467558-0x000000018B4675D4
	}

	public abstract class CallableActionNodeBase : SimplexNode // TypeDefIndex: 48343
	{
		// Constructors
		protected CallableActionNodeBase() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class CallableActionNode : CallableActionNodeBase // TypeDefIndex: 48345
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48344
		{
			// Fields
			public CallableActionNode __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {} // 0x000000018B45DB28-0x000000018B45DC38
		}
	
		// Constructors
		protected CallableActionNode() {} // 0x000000018B46C544-0x000000018B46C5AC
	
		// Methods
		public abstract void Invoke(); // 0x0000000185492010-0x0000000185492020
		protected sealed override void OnRegisterPorts(FlowNode node) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class CallableActionNode<T1> : CallableActionNodeBase // TypeDefIndex: 48347
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48346
		{
			// Fields
			public CallableActionNode<T1> __4__this;
			public ValueInput<T1> p1;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2> : CallableActionNodeBase // TypeDefIndex: 48349
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48348
		{
			// Fields
			public CallableActionNode<T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3> : CallableActionNodeBase // TypeDefIndex: 48351
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48350
		{
			// Fields
			public CallableActionNode<T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4> : CallableActionNodeBase // TypeDefIndex: 48353
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48352
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5> : CallableActionNodeBase // TypeDefIndex: 48355
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48354
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6> : CallableActionNodeBase // TypeDefIndex: 48357
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48356
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7> : CallableActionNodeBase // TypeDefIndex: 48359
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48358
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : CallableActionNodeBase // TypeDefIndex: 48361
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48360
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableActionNodeBase // TypeDefIndex: 48363
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48362
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableActionNodeBase // TypeDefIndex: 48365
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48364
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
			public ValueInput<T10> p10;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNodeBase : SimplexNode // TypeDefIndex: 48366
	{
		// Constructors
		protected CallableFunctionNodeBase() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class CallableFunctionNode<TResult> : CallableFunctionNodeBase // TypeDefIndex: 48368
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48367
		{
			// Fields
			public CallableFunctionNode<TResult> __4__this;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1> : CallableFunctionNodeBase // TypeDefIndex: 48370
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48369
		{
			// Fields
			public CallableFunctionNode<TResult, T1> __4__this;
			public ValueInput<T1> p1;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2> : CallableFunctionNodeBase // TypeDefIndex: 48372
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48371
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3> : CallableFunctionNodeBase // TypeDefIndex: 48374
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48373
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4> : CallableFunctionNodeBase // TypeDefIndex: 48376
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48375
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5> : CallableFunctionNodeBase // TypeDefIndex: 48378
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48377
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : CallableFunctionNodeBase // TypeDefIndex: 48380
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48379
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : CallableFunctionNodeBase // TypeDefIndex: 48382
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48381
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : CallableFunctionNodeBase // TypeDefIndex: 48384
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48383
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableFunctionNodeBase // TypeDefIndex: 48386
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48385
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableFunctionNodeBase // TypeDefIndex: 48388
	{
		// Fields
		private TResult result;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48387
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
			public ValueInput<T10> p10;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
			internal void _OnRegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode : SimplexNode // TypeDefIndex: 48390
	{
		// Fields
		private static Dictionary<System.Type, System.Type> _extractors; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48389
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__1_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B460084-0x000000018B4604F8
			public __c() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _GetExtractorType_b__1_0(System.Type t) => default; // 0x000000018B46DC38-0x000000018B46DC9C
		}
	
		// Constructors
		protected ExtractorNode() {} // 0x000000018B46BEA0-0x000000018B46BEC0
	
		// Methods
		public static System.Type GetExtractorType(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
	}

	public abstract class ExtractorNode<TInstance, T1, T2> : ExtractorNode // TypeDefIndex: 48392
	{
		// Fields
		private T1 a;
		private T2 b;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48391
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal T1 _OnRegisterPorts_b__0() => default;
			internal T2 _OnRegisterPorts_b__1() => default;
		}
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3> : ExtractorNode // TypeDefIndex: 48394
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48393
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _OnRegisterPorts_b__0() => default;
			internal T2 _OnRegisterPorts_b__1() => default;
			internal T3 _OnRegisterPorts_b__2() => default;
		}
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4> : ExtractorNode // TypeDefIndex: 48396
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
	
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 48395
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3, T4> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass5_0() {}
	
			// Methods
			internal T1 _OnRegisterPorts_b__0() => default;
			internal T2 _OnRegisterPorts_b__1() => default;
			internal T3 _OnRegisterPorts_b__2() => default;
			internal T4 _OnRegisterPorts_b__3() => default;
		}
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5> : ExtractorNode // TypeDefIndex: 48398
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48397
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3, T4, T5> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass6_0() {}
	
			// Methods
			internal T1 _OnRegisterPorts_b__0() => default;
			internal T2 _OnRegisterPorts_b__1() => default;
			internal T3 _OnRegisterPorts_b__2() => default;
			internal T4 _OnRegisterPorts_b__3() => default;
			internal T5 _OnRegisterPorts_b__4() => default;
		}
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d, out ref T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> : ExtractorNode // TypeDefIndex: 48400
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
		private T6 f;
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 48399
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass7_0() {}
	
			// Methods
			internal T1 _OnRegisterPorts_b__0() => default;
			internal T2 _OnRegisterPorts_b__1() => default;
			internal T3 _OnRegisterPorts_b__2() => default;
			internal T4 _OnRegisterPorts_b__3() => default;
			internal T5 _OnRegisterPorts_b__4() => default;
			internal T6 _OnRegisterPorts_b__5() => default;
		}
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d, out ref T5 e, out ref T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public class AddDictionaryItem<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string, T> // TypeDefIndex: 48401
	{
		// Constructors
		public AddDictionaryItem() {}
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key, T item) => default;
	}

	public class GetDictionaryItem<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 48402
	{
		// Constructors
		public GetDictionaryItem() {}
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key) => default;
	}

	public class RemoveDictionaryKey<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string> // TypeDefIndex: 48403
	{
		// Constructors
		public RemoveDictionaryKey() {}
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key) => default;
	}

	public class ClearDictionary : CallableFunctionNode<IDictionary, IDictionary> // TypeDefIndex: 48404
	{
		// Constructors
		public ClearDictionary() {} // 0x000000018B45DE74-0x000000018B45DE9C
	
		// Methods
		public override IDictionary Invoke(IDictionary dict) => default; // 0x000000018B45DE4C-0x000000018B45DE74
	}

	public class TryGetValue<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 48405
	{
		// Fields
		private bool _exists_k__BackingField;
	
		// Properties
		public bool exists { get; private set; }
	
		// Constructors
		public TryGetValue() {}
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key) => default;
	}

	public class DictionaryContainsKey<T> : CallableFunctionNode<bool, IDictionary<string, T>, string> // TypeDefIndex: 48406
	{
		// Constructors
		public DictionaryContainsKey() {}
	
		// Methods
		public override bool Invoke(IDictionary<string, T> dict, string key) => default;
	}

	public class ClearList : CallableFunctionNode<IList, IList> // TypeDefIndex: 48407
	{
		// Constructors
		public ClearList() {} // 0x000000018B45DEC4-0x000000018B45DEEC
	
		// Methods
		public override IList Invoke(IList list) => default; // 0x000000018B45DE9C-0x000000018B45DEC4
	}

	public class AddListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 48408
	{
		// Constructors
		public AddListItem() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item) => default;
	}

	public class InsertListItem<T> : CallableFunctionNode<IList<T>, List<T>, int, T> // TypeDefIndex: 48409
	{
		// Constructors
		public InsertListItem() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index, T item) => default;
	}

	public class RemoveListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 48410
	{
		// Constructors
		public RemoveListItem() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item) => default;
	}

	public class RemoveListItemAt<T> : CallableFunctionNode<IList<T>, List<T>, int> // TypeDefIndex: 48411
	{
		// Constructors
		public RemoveListItemAt() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index) => default;
	}

	public class SetListItem<T> : CallableFunctionNode<IList<T>, IList<T>, int, T> // TypeDefIndex: 48412
	{
		// Constructors
		public SetListItem() {}
	
		// Methods
		public override IList<T> Invoke(IList<T> list, int index, T item) => default;
	}

	public class ShuffleList<T> : CallableFunctionNode<IList<T>, IList<T>> // TypeDefIndex: 48413
	{
		// Constructors
		public ShuffleList() {}
	
		// Methods
		public override IList<T> Invoke(IList<T> list) => default;
	}

	public class GetListItem<T> : PureFunctionNode<T, IList<T>, int> // TypeDefIndex: 48414
	{
		// Constructors
		public GetListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list, int index) => default;
	}

	public class GetRandomListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 48415
	{
		// Constructors
		public GetRandomListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list) => default;
	}

	public class GetLastListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 48416
	{
		// Constructors
		public GetLastListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list) => default;
	}

	public class GetFirstListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 48417
	{
		// Constructors
		public GetFirstListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list) => default;
	}

	public class GetListItemIndex : PureFunctionNode<int, IList, object> // TypeDefIndex: 48418
	{
		// Constructors
		public GetListItemIndex() {} // 0x000000018B461370-0x000000018B461398
	
		// Methods
		public override int Invoke(IList list, object item) => default; // 0x000000018B461348-0x000000018B461370
	}

	public class IsNotNull : PureFunctionNode<bool, object> // TypeDefIndex: 48419
	{
		// Constructors
		public IsNotNull() {} // 0x000000018B4619C0-0x000000018B4619E8
	
		// Methods
		public override bool Invoke(object OBJECT) => default; // 0x000000018B4619A0-0x000000018B4619C0
	}

	public class IsOfType : PureFunctionNode<bool, object, System.Type> // TypeDefIndex: 48420
	{
		// Fields
		private object _OBJECT_k__BackingField; // 0x30
	
		// Properties
		public object OBJECT { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public IsOfType() {} // 0x000000018B461A6C-0x000000018B461A94
	
		// Methods
		public override bool Invoke(object OBJECT, System.Type type) => default; // 0x000000018B4619E8-0x000000018B461A6C
	}

	public class AnyGreaterThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 48421
	{
		// Constructors
		public AnyGreaterThan() {} // 0x000000018B45C5CC-0x000000018B45C5F4
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x000000018B45C59C-0x000000018B45C5CC
	}

	public class AnyGreaterEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 48422
	{
		// Constructors
		public AnyGreaterEqualThan() {} // 0x000000018B45C574-0x000000018B45C59C
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x000000018B45C528-0x000000018B45C574
	}

	public class AnyLessThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 48423
	{
		// Constructors
		public AnyLessThan() {} // 0x000000018B45C698-0x000000018B45C6C0
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x000000018B45C668-0x000000018B45C698
	}

	public class AnyLessEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 48424
	{
		// Constructors
		public AnyLessEqualThan() {} // 0x000000018B45C640-0x000000018B45C668
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x000000018B45C5F4-0x000000018B45C640
	}

	public class AnyEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 48425
	{
		// Constructors
		public AnyEqual() {} // 0x000000018B45C500-0x000000018B45C528
	
		// Methods
		public override bool Invoke(object a, object b) => default; // 0x000000018B45C4EC-0x000000018B45C500
	}

	public class AnyNotEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 48426
	{
		// Constructors
		public AnyNotEqual() {} // 0x000000018B45C6DC-0x000000018B45C704
	
		// Methods
		public override bool Invoke(object a, object b) => default; // 0x000000018B45C6C0-0x000000018B45C6DC
	}

	public class FloatAdd : PureFunctionNode<float, float, float> // TypeDefIndex: 48427
	{
		// Constructors
		public FloatAdd() {} // 0x000000018B4608D4-0x000000018B4608FC
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x0000000185FD2800-0x0000000185FD2810
	}

	public class FloatSubtract : PureFunctionNode<float, float, float> // TypeDefIndex: 48428
	{
		// Constructors
		public FloatSubtract() {} // 0x000000018B460B10-0x000000018B460B38
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x0000000185FD2830-0x0000000185FD2840
	}

	public class FloatMultiply : PureFunctionNode<float, float, float> // TypeDefIndex: 48429
	{
		// Constructors
		public FloatMultiply() {} // 0x000000018B460A5C-0x000000018B460A84
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x0000000183854720-0x0000000183854730
	}

	public class FloatDivide : PureFunctionNode<float, float, float> // TypeDefIndex: 48430
	{
		// Constructors
		public FloatDivide() {} // 0x000000018B4608FC-0x000000018B460924
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x000000018791DB00-0x000000018791DB08
	}

	public class FloatModulo : PureFunctionNode<float, float, float> // TypeDefIndex: 48431
	{
		// Constructors
		public FloatModulo() {} // 0x000000018B460A34-0x000000018B460A5C
	
		// Methods
		public override float Invoke(float value, float mod) => default; // 0x0000000185FD2820-0x0000000185FD2830
	}

	public class FloatGreaterThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 48432
	{
		// Constructors
		public FloatGreaterThan() {} // 0x000000018B460984-0x000000018B4609AC
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018B46097C-0x000000018B460984
	}

	public class FloatGreaterEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 48433
	{
		// Constructors
		public FloatGreaterEqualThan() {} // 0x000000018B460954-0x000000018B46097C
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018B46094C-0x000000018B460954
	}

	public class FloatLessThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 48434
	{
		// Constructors
		public FloatLessThan() {} // 0x000000018B460A0C-0x000000018B460A34
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018B460A04-0x000000018B460A0C
	}

	public class FloatLessEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 48435
	{
		// Constructors
		public FloatLessEqualThan() {} // 0x000000018B4609DC-0x000000018B460A04
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018B4609D4-0x000000018B4609DC
	}

	public class FloatEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 48436
	{
		// Constructors
		public FloatEqual() {} // 0x000000018B460924-0x000000018B46094C
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018A1D297C-0x000000018A1D298C
	}

	public class FloatNotEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 48437
	{
		// Constructors
		public FloatNotEqual() {} // 0x000000018B460A94-0x000000018B460ABC
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018B460A84-0x000000018B460A94
	}

	public class FloatInvert : PureFunctionNode<float, float> // TypeDefIndex: 48438
	{
		// Constructors
		public FloatInvert() {} // 0x000000018B4609AC-0x000000018B4609D4
	
		// Methods
		public override float Invoke(float value) => default; // 0x0000000185FD2810-0x0000000185FD2820
	}

	public class FloatSnap : PureFunctionNode<int, float, int> // TypeDefIndex: 48439
	{
		// Constructors
		public FloatSnap() {} // 0x000000018B460AE8-0x000000018B460B10
	
		// Methods
		public override int Invoke(float value, int interval) => default; // 0x000000018B460ABC-0x000000018B460AE8
	}

	public class IntegerAdd : PureFunctionNode<int, int, int> // TypeDefIndex: 48440
	{
		// Constructors
		public IntegerAdd() {} // 0x000000018B46172C-0x000000018B461754
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x0000000185FD2840-0x0000000185FD2850
	}

	public class IntegerSubtract : PureFunctionNode<int, int, int> // TypeDefIndex: 48441
	{
		// Constructors
		public IntegerSubtract() {} // 0x000000018B461978-0x000000018B4619A0
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x0000000185FBF490-0x0000000185FBF4A0
	}

	public class IntegerMultiply : PureFunctionNode<int, int, int> // TypeDefIndex: 48442
	{
		// Constructors
		public IntegerMultiply() {} // 0x000000018B4618D0-0x000000018B4618F8
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x0000000183854710-0x0000000183854720
	}

	public class IntegerDivide : PureFunctionNode<int, int, int> // TypeDefIndex: 48443
	{
		// Constructors
		public IntegerDivide() {} // 0x000000018B461764-0x000000018B46178C
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x000000018B461754-0x000000018B461764
	}

	public class IntegerModulo : PureFunctionNode<int, int, int> // TypeDefIndex: 48444
	{
		// Constructors
		public IntegerModulo() {} // 0x000000018B4618A8-0x000000018B4618D0
	
		// Methods
		public override int Invoke(int value, int mod) => default; // 0x000000018B46189C-0x000000018B4618A8
	}

	public class IntegerGreaterThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 48445
	{
		// Constructors
		public IntegerGreaterThan() {} // 0x000000018B4617EC-0x000000018B461814
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018B4617E4-0x000000018B4617EC
	}

	public class IntegerGreaterEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 48446
	{
		// Constructors
		public IntegerGreaterEqualThan() {} // 0x000000018B4617BC-0x000000018B4617E4
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018B4617B4-0x000000018B4617BC
	}

	public class IntegerLessThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 48447
	{
		// Constructors
		public IntegerLessThan() {} // 0x000000018B461874-0x000000018B46189C
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018B46186C-0x000000018B461874
	}

	public class IntegerLessEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 48448
	{
		// Constructors
		public IntegerLessEqualThan() {} // 0x000000018B461844-0x000000018B46186C
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018B46183C-0x000000018B461844
	}

	public class IntegerEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 48449
	{
		// Constructors
		public IntegerEqual() {} // 0x000000018B46178C-0x000000018B4617B4
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018A1D43F4-0x000000018A1D43FC
	}

	public class IntegerNotEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 48450
	{
		// Constructors
		public IntegerNotEqual() {} // 0x000000018B461900-0x000000018B461928
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018B4618F8-0x000000018B461900
	}

	public class IntegerInvert : PureFunctionNode<int, int> // TypeDefIndex: 48451
	{
		// Constructors
		public IntegerInvert() {} // 0x000000018B461814-0x000000018B46183C
	
		// Methods
		public override int Invoke(int value) => default; // 0x0000000185FD2850-0x0000000185FD2860
	}

	public class IntegerSnap : PureFunctionNode<int, int, int> // TypeDefIndex: 48452
	{
		// Constructors
		public IntegerSnap() {} // 0x000000018B461950-0x000000018B461978
	
		// Methods
		public override int Invoke(int value, int interval) => default; // 0x000000018B461928-0x000000018B461950
	}

	public class BooleanEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 48453
	{
		// Constructors
		public BooleanEqual() {} // 0x000000018B45DA0C-0x000000018B45DA34
	
		// Methods
		public override bool Invoke(bool a, bool b) => default; // 0x0000000189EAA3E8-0x0000000189EAA3F4
	}

	public class BooleanNotEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 48454
	{
		// Constructors
		public BooleanNotEqual() {} // 0x000000018B45DA3C-0x000000018B45DA64
	
		// Methods
		public override bool Invoke(bool a, bool b) => default; // 0x000000018B45DA34-0x000000018B45DA3C
	}

	public class AND : PureFunctionNode<bool> // TypeDefIndex: 48455
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public AND() {} // 0x000000018B45C4C4-0x000000018B45C4EC
	
		// Methods
		public override bool Invoke() => default; // 0x000000018B45C3A4-0x000000018B45C408
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018B45C408-0x000000018B45C4C4
	}

	public class OR : PureFunctionNode<bool> // TypeDefIndex: 48456
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public OR() {} // 0x000000018B462F44-0x000000018B462F6C
	
		// Methods
		public override bool Invoke() => default; // 0x000000018B462E20-0x000000018B462E88
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018B462E88-0x000000018B462F44
	}

	public class XOR : PureFunctionNode<bool> // TypeDefIndex: 48457
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public XOR() {} // 0x000000018B46FF94-0x000000018B46FFBC
	
		// Methods
		public override bool Invoke() => default; // 0x000000018B46FE60-0x000000018B46FED8
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018B46FED8-0x000000018B46FF94
	}

	public class NOT : PureFunctionNode<bool, bool> // TypeDefIndex: 48458
	{
		// Constructors
		public NOT() {} // 0x000000018B462C38-0x000000018B462C60
	
		// Methods
		public override bool Invoke(bool value) => default; // 0x000000018B462C30-0x000000018B462C38
	}

	public class Vector3Equal : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 48459
	{
		// Constructors
		public Vector3Equal() {} // 0x000000018B46EFBC-0x000000018B46EFE4
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b) => default; // 0x000000018B46EF68-0x000000018B46EFBC
	}

	public class Vector3NotEqual : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 48460
	{
		// Constructors
		public Vector3NotEqual() {} // 0x000000018B46F118-0x000000018B46F140
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b) => default; // 0x000000018B46F0C4-0x000000018B46F118
	}

	public class Vector3Add : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 48461
	{
		// Constructors
		public Vector3Add() {} // 0x000000018B46EEE0-0x000000018B46EF08
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b) => default; // 0x000000018B46EE84-0x000000018B46EEE0
	}

	public class Vector3Subtract : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 48462
	{
		// Constructors
		public Vector3Subtract() {} // 0x000000018B46F19C-0x000000018B46F1C4
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b) => default; // 0x000000018B46F140-0x000000018B46F19C
	}

	public class Vector3Multiply : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 48463
	{
		// Constructors
		public Vector3Multiply() {} // 0x000000018B46F09C-0x000000018B46F0C4
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b) => default; // 0x000000018B46F058-0x000000018B46F09C
	}

	public class Vector3Divide : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 48464
	{
		// Constructors
		public Vector3Divide() {} // 0x000000018B46EF40-0x000000018B46EF68
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b) => default; // 0x000000018B46EF08-0x000000018B46EF40
	}

	public class Vector3Invert : PureFunctionNode<Vector3, Vector3> // TypeDefIndex: 48465
	{
		// Constructors
		public Vector3Invert() {} // 0x000000018B46F030-0x000000018B46F058
	
		// Methods
		public override Vector3 Invoke(Vector3 value) => default; // 0x000000018B46EFE4-0x000000018B46F030
	}

	public class BitwiseAnd<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 48466
		where T : Enum
	{
		// Constructors
		public BitwiseAnd() {}
	
		// Methods
		public override T Invoke(T a, T b) => default;
	}

	public class BitwiseOr<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 48467
		where T : Enum
	{
		// Constructors
		public BitwiseOr() {}
	
		// Methods
		public override T Invoke(T a, T b) => default;
	}

	public class BitwiseInvert<T> : PureFunctionNode<T, T> // TypeDefIndex: 48468
		where T : Enum
	{
		// Constructors
		public BitwiseInvert() {}
	
		// Methods
		public override T Invoke(T a) => default;
	}

	public class Wait : LatentActionNode<float> // TypeDefIndex: 48470
	{
		// Fields
		private float _timeLeft_k__BackingField; // 0x68
		private float _normalized_k__BackingField; // 0x6C
	
		// Properties
		public float timeLeft { get; private set; } // 0x0000000181378230-0x0000000181378240 0x0000000185492010-0x0000000185492020
		public float normalized { get; private set; } // 0x000000018B46BDA4-0x000000018B46BE54 0x0000000181377E40-0x0000000181377E50
	
		// Nested types
		private sealed class _Invoke_d__8 : IEnumerator<object> // TypeDefIndex: 48469
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Wait __4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FBCAD0-0x0000000185FBCAE0 
			object IEnumerator.Current { get => default; } // 0x000000018B46F928-0x000000018B46F950 
	
			// Constructors
			public _Invoke_d__8() {} // Dummy constructor
			public _Invoke_d__8(int __1__state) {} // 0x0000000185FB8230-0x0000000185FB8240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FBA690-0x0000000185FBA6A0
			private bool MoveNext() => default; // 0x0000000185FB8A10-0x0000000185FB8A20
			void IEnumerator.Reset() {} // 0x000000018B46F8BC-0x000000018B46F928
		}
	
		// Constructors
		public Wait() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(float time = 1f /* Metadata: 0x02060D0D */) => default; // 0x000000018B46BE54-0x000000018B46BEA0
	}

	public class WaitForOneFrame : LatentActionNode // TypeDefIndex: 48472
	{
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 48471
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x000000018B46B544-0x000000018B46B580 
	
			// Constructors
			public _Invoke_d__2() {} // Dummy constructor
			public _Invoke_d__2(int __1__state) {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46F674-0x000000018B46F6B8
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public WaitForOneFrame() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke() => default; // 0x000000018B46B5F0-0x000000018B46B63C
	}

	public class WaitForPhysicsFrame : LatentActionNode // TypeDefIndex: 48474
	{
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 48473
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x000000018B46B4D4-0x000000018B46B544 
	
			// Constructors
			public _Invoke_d__2() {} // Dummy constructor
			public _Invoke_d__2(int __1__state) {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46F6B8-0x000000018B46F6FC
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public WaitForPhysicsFrame() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke() => default; // 0x000000018B46B63C-0x000000018B46B688
	}

	public class WaitForEndOfFrame : LatentActionNode // TypeDefIndex: 48476
	{
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 48475
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x000000018B46B580-0x000000018B46B5F0 
	
			// Constructors
			public _Invoke_d__2() {} // Dummy constructor
			public _Invoke_d__2(int __1__state) {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46F630-0x000000018B46F674
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public WaitForEndOfFrame() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke() => default; // 0x000000018B46B688-0x000000018B46B6D4
	}

	public class WaitUntil : LatentActionNode // TypeDefIndex: 48478
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018B46B6D4-0x000000018B46B7B8 
	
		// Nested types
		private sealed class _Invoke_d__3 : IEnumerator<object> // TypeDefIndex: 48477
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WaitUntil __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Invoke_d__3() {} // Dummy constructor
			public _Invoke_d__3(int __1__state) {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46F6FC-0x000000018B46F758
			private bool MoveNext() => default; // 0x000000018B46F758-0x000000018B46F7DC
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public WaitUntil() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke() => default; // 0x0000000181377E40-0x0000000181377E50
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018B46B89C-0x000000018B46B8E8
	}

	public class WaitWhile : LatentActionNode // TypeDefIndex: 48480
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018B46B7B8-0x000000018B46B89C 
	
		// Nested types
		private sealed class _Invoke_d__3 : IEnumerator<object> // TypeDefIndex: 48479
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WaitWhile __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Invoke_d__3() {} // Dummy constructor
			public _Invoke_d__3(int __1__state) {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46F7DC-0x000000018B46F838
			private bool MoveNext() => default; // 0x000000018B46F838-0x000000018B46F8BC
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public WaitWhile() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke() => default; // 0x0000000181377E40-0x0000000181377E50
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018B46B8E8-0x000000018B46B934
	}

	public class DeltaTimed : PureFunctionNode<float, float, float> // TypeDefIndex: 48481
	{
		// Constructors
		public DeltaTimed() {} // 0x000000018B45FDE0-0x000000018B45FE08
	
		// Methods
		public override float Invoke(float value, float multiplier = 1f /* Metadata: 0x02060D11 */) => default; // 0x000000018B45FDAC-0x000000018B45FDE0
	}

	public class DeltaTimedVector3 : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 48482
	{
		// Constructors
		public DeltaTimedVector3() {} // 0x000000018B45FD84-0x000000018B45FDAC
	
		// Methods
		public override Vector3 Invoke(Vector3 value, float multiplier = 1f /* Metadata: 0x02060D15 */) => default; // 0x000000018B45FD00-0x000000018B45FD84
	}

	public class Buffer<T> : PureFunctionNode<T, T, int> // TypeDefIndex: 48483
	{
		// Fields
		private int lastFrame;
		private Queue<T> q;
	
		// Constructors
		public Buffer() {}
	
		// Methods
		public override T Invoke(T value, int size = 60 /* Metadata: 0x02060D19 */) => default;
	}

	public class DampFloat : PureFunctionNode<float, float, float, float> // TypeDefIndex: 48484
	{
		// Constructors
		public DampFloat() {} // 0x000000018B45FC40-0x000000018B45FC68
	
		// Methods
		public override float Invoke(float current, float target, float damp = 1f /* Metadata: 0x02060D1A */) => default; // 0x000000018B45FBF4-0x000000018B45FC40
	}

	public class DampVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float> // TypeDefIndex: 48485
	{
		// Constructors
		public DampVector3() {} // 0x000000018B45FCD8-0x000000018B45FD00
	
		// Methods
		public override Vector3 Invoke(Vector3 current, Vector3 target, float damp = 1f /* Metadata: 0x02060D1E */) => default; // 0x000000018B45FC68-0x000000018B45FCD8
	}

	public class LerpFloat : PureFunctionNode<float, float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48486
	{
		// Constructors
		public LerpFloat() {} // 0x000000018B4625F0-0x000000018B462618
	
		// Methods
		public override float Invoke(float a, float b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018B4625DC-0x000000018B4625F0
	}

	public class LerpVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48487
	{
		// Constructors
		public LerpVector3() {} // 0x000000018B46270C-0x000000018B462734
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018B462698-0x000000018B46270C
	}

	public class LerpQuaternion : PureFunctionNode<Quaternion, Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48488
	{
		// Constructors
		public LerpQuaternion() {} // 0x000000018B462670-0x000000018B462698
	
		// Methods
		public override Quaternion Invoke(Quaternion a, Quaternion b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018B462618-0x000000018B462670
	}

	public class LerpColor : PureFunctionNode<UnityEngine.Color, UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48489
	{
		// Constructors
		public LerpColor() {} // 0x000000018B4625B4-0x000000018B4625DC
	
		// Methods
		public override UnityEngine.Color Invoke(UnityEngine.Color a, UnityEngine.Color b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018B46255C-0x000000018B4625B4
	}

	public class TweenFloat : LatentActionNode<float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48491
	{
		// Fields
		private float _value_k__BackingField; // 0x68
	
		// Properties
		public float value { get; private set; } // 0x000000018B46B934-0x000000018B46B9DC 0x0000000181377E40-0x0000000181377E50
	
		// Nested types
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 48490
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TweenFloat __4__this; // 0x20
			public ParadoxNotion.Animation.EaseType interpolation; // 0x28
			public float from; // 0x2C
			public float to; // 0x30
			public float duration; // 0x34
			private float _t_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B469EAC-0x000000018B469ED4 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Invoke_d__4() {} // Dummy constructor
			public _Invoke_d__4(int __1__state) {} // 0x0000000185FB8230-0x0000000185FB8240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FBA690-0x0000000185FBA6A0
			private bool MoveNext() => default; // 0x000000018B469E0C-0x000000018B469EAC
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public TweenFloat() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(float from, float to, float duration = 1f /* Metadata: 0x02060D22 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D26 */) => default; // 0x000000018B46BD0C-0x000000018B46BD58
	}

	public class TweenVector3 : LatentActionNode<Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48493
	{
		// Fields
		private Vector3 _value_k__BackingField; // 0x68
	
		// Properties
		public Vector3 value { get; private set; } // 0x000000018B46BB84-0x000000018B46BC74 0x0000000181377E40-0x0000000181377E50
	
		// Nested types
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 48492
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TweenVector3 __4__this; // 0x20
			public ParadoxNotion.Animation.EaseType interpolation; // 0x28
			public Vector3 from; // 0x2C
			public Vector3 to; // 0x38
			public float duration; // 0x44
			private float _t_5__2; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B46A2E0-0x000000018B46A308 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Invoke_d__4() {} // Dummy constructor
			public _Invoke_d__4(int __1__state) {} // 0x0000000185FBEAD0-0x0000000185FBEAF0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FD28A0-0x0000000185FD28B0
			private bool MoveNext() => default; // 0x000000018B46A230-0x000000018B46A2E0
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public TweenVector3() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(Vector3 from, Vector3 to, float duration = 1f /* Metadata: 0x02060D27 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D2B */) => default; // 0x000000018B46BC74-0x000000018B46BCC0
	}

	public class TweenQuaternion : LatentActionNode<Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48495
	{
		// Fields
		private Quaternion _value_k__BackingField; // 0x68
	
		// Properties
		public Quaternion value { get; private set; } // 0x000000018B46B9DC-0x000000018B46BAB0 0x0000000181377E40-0x0000000181377E50
	
		// Nested types
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 48494
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TweenQuaternion __4__this; // 0x20
			public ParadoxNotion.Animation.EaseType interpolation; // 0x28
			public Quaternion from; // 0x2C
			public Quaternion to; // 0x3C
			public float duration; // 0x4C
			private float _t_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B46A050-0x000000018B46A078 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Invoke_d__4() {} // Dummy constructor
			public _Invoke_d__4(int __1__state) {} // 0x0000000185FBECA0-0x0000000185FBECB0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FD2730-0x0000000185FD2740
			private bool MoveNext() => default; // 0x000000018B469FB0-0x000000018B46A050
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public TweenQuaternion() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(Quaternion from, Quaternion to, float duration = 1f /* Metadata: 0x02060D2C */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D30 */) => default; // 0x000000018B46BD58-0x000000018B46BDA4
	}

	public class TweenColor : LatentActionNode<UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 48497
	{
		// Fields
		private UnityEngine.Color _value_k__BackingField; // 0x68
	
		// Properties
		public UnityEngine.Color value { get; private set; } // 0x000000018B46BAB0-0x000000018B46BB84 0x0000000181377E40-0x0000000181377E50
	
		// Nested types
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 48496
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TweenColor __4__this; // 0x20
			public ParadoxNotion.Animation.EaseType interpolation; // 0x28
			public UnityEngine.Color from; // 0x2C
			public UnityEngine.Color to; // 0x3C
			public float duration; // 0x4C
			private float _t_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B469DE4-0x000000018B469E0C 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Invoke_d__4() {} // Dummy constructor
			public _Invoke_d__4(int __1__state) {} // 0x0000000185FBECA0-0x0000000185FBECB0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FD2730-0x0000000185FD2740
			private bool MoveNext() => default; // 0x000000018B469D44-0x000000018B469DE4
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public TweenColor() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(UnityEngine.Color from, UnityEngine.Color to, float duration = 1f /* Metadata: 0x02060D31 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D35 */) => default; // 0x000000018B46BCC0-0x000000018B46BD0C
	}

	public class TweenPosition : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 48499
	{
		// Nested types
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 48498
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Vector3 position; // 0x20
			public bool relative; // 0x2C
			public Transform transform; // 0x30
			public TweenPosition __4__this; // 0x38
			public ParadoxNotion.Animation.EaseType interpolation; // 0x40
			public float duration; // 0x44
			private float _t_5__2; // 0x48
			private Vector3 _from_5__3; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _Invoke_d__0() {} // Dummy constructor
			public _Invoke_d__0(int __1__state) {} // 0x000000018B469ED4-0x000000018B469F88
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B469F88-0x000000018B469FB0
			private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018B46AF98-0x000000018B46B1C4
		}
	
		// Constructors
		public TweenPosition() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(Transform transform, Vector3 position, float duration = 0.25f /* Metadata: 0x02060D36 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D3A */, bool relative = false /* Metadata: 0x02060D3B */) => default; // 0x000000018B46B43C-0x000000018B46B488
	}

	public class TweenRotation : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 48501
	{
		// Nested types
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 48500
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Vector3 rotation; // 0x20
			public bool relative; // 0x2C
			public Transform transform; // 0x30
			public TweenRotation __4__this; // 0x38
			public ParadoxNotion.Animation.EaseType interpolation; // 0x40
			public float duration; // 0x44
			private float _t_5__2; // 0x48
			private Vector3 _from_5__3; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _Invoke_d__0() {} // Dummy constructor
			public _Invoke_d__0(int __1__state) {} // 0x000000018B46A078-0x000000018B46A12C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46A12C-0x000000018B46A154
			private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018B46AD74-0x000000018B46AF98
		}
	
		// Constructors
		public TweenRotation() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(Transform transform, Vector3 rotation, float duration = 0.25f /* Metadata: 0x02060D3C */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D40 */, bool relative = false /* Metadata: 0x02060D41 */) => default; // 0x000000018B46B488-0x000000018B46B4D4
	}

	public class TweenScale : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 48503
	{
		// Nested types
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 48502
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Vector3 scale; // 0x20
			public bool relative; // 0x2C
			public Transform transform; // 0x30
			public TweenScale __4__this; // 0x38
			public ParadoxNotion.Animation.EaseType interpolation; // 0x40
			public float duration; // 0x44
			private float _t_5__2; // 0x48
			private Vector3 _from_5__3; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _Invoke_d__0() {} // Dummy constructor
			public _Invoke_d__0(int __1__state) {} // 0x000000018B46A154-0x000000018B46A208
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46A208-0x000000018B46A230
			private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018B46B1C4-0x000000018B46B3F0
		}
	
		// Constructors
		public TweenScale() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override IEnumerator Invoke(Transform transform, Vector3 scale, float duration = 0.25f /* Metadata: 0x02060D42 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02060D46 */, bool relative = false /* Metadata: 0x02060D47 */) => default; // 0x000000018B46B3F0-0x000000018B46B43C
	}

	public class AddComponent<T> : CallableFunctionNode<T, GameObject, bool> // TypeDefIndex: 48504
		where T : Component
	{
		// Constructors
		public AddComponent() {}
	
		// Methods
		public override T Invoke(GameObject gameObject, bool tryGetExisting) => default;
	}

	public class GetComponent<T> : PureFunctionNode<T, GameObject> // TypeDefIndex: 48505
		where T : Component
	{
		// Fields
		private T _component;
	
		// Constructors
		public GetComponent() {}
	
		// Methods
		public override T Invoke(GameObject gameObject) => default;
	}

	public class Instantiate<T> : CallableFunctionNode<T, T, Vector3, Quaternion, Transform> // TypeDefIndex: 48506
		where T : UnityEngine.Object
	{
		// Constructors
		public Instantiate() {}
	
		// Methods
		public override T Invoke(T original, Vector3 position, Quaternion rotation, Transform parent) => default;
	}

	public class NewScriptableObject<T> : CallableFunctionNode<T> // TypeDefIndex: 48507
		where T : ScriptableObject
	{
		// Constructors
		public NewScriptableObject() {}
	
		// Methods
		public override T Invoke() => default;
	}

	public class GetChildTransforms : PureFunctionNode<IEnumerable<Transform>, Transform> // TypeDefIndex: 48508
	{
		// Constructors
		public GetChildTransforms() {} // 0x000000018B461320-0x000000018B461348
	
		// Methods
		public override IEnumerable<Transform> Invoke(Transform parent) => default; // 0x000000018B4612E4-0x000000018B461320
	}

	public class Cast<T> : PureFunctionNode<T, object> // TypeDefIndex: 48509
	{
		// Constructors
		public Cast() {}
	
		// Methods
		public override T Invoke(object obj) => default;
	}

	public class Identity<T> : PureFunctionNode<T, T> // TypeDefIndex: 48510
	{
		// Properties
		public override string name { get => default; }
	
		// Constructors
		public Identity() {}
	
		// Methods
		public override T Invoke(T value) => default;
	}

	public class Cache<T> : CallableFunctionNode<T, T> // TypeDefIndex: 48511
	{
		// Constructors
		public Cache() {}
	
		// Methods
		public override T Invoke(T value) => default;
	}

	public class RemapFloat : PureFunctionNode<float, float, float, float, float, float> // TypeDefIndex: 48512
	{
		// Constructors
		public RemapFloat() {} // 0x000000018B467394-0x000000018B4673BC
	
		// Methods
		public override float Invoke(float current, float iMin, float iMax = 1f /* Metadata: 0x02060D48 */, float oMin = 0f /* Metadata: 0x02060D4C */, float oMax = 100f /* Metadata: 0x02060D50 */) => default; // 0x000000018B467368-0x000000018B467394
	}

	public class RemapVector3 : PureFunctionNode<Vector3, float, float, float, Vector3, Vector3> // TypeDefIndex: 48513
	{
		// Constructors
		public RemapVector3() {} // 0x000000018B467438-0x000000018B467460
	
		// Methods
		public override Vector3 Invoke(float current, float iMin, float iMax, Vector3 oMin, Vector3 oMax) => default; // 0x000000018B4673BC-0x000000018B467438
	}

	public class LogValue : CallableActionNode<object> // TypeDefIndex: 48514
	{
		// Constructors
		public LogValue() {} // 0x000000018B46275C-0x000000018B462784
	
		// Methods
		public override void Invoke(object obj) {} // 0x0000000185492010-0x0000000185492020
	}

	public class LogText : CallableActionNode<string> // TypeDefIndex: 48515
	{
		// Constructors
		public LogText() {} // 0x000000018B462734-0x000000018B46275C
	
		// Methods
		public override void Invoke(string text) {} // 0x0000000185492010-0x0000000185492020
	}

	public class SendEvent : CallableActionNode<GraphOwner, string> // TypeDefIndex: 48516
	{
		// Constructors
		public SendEvent() {} // 0x000000018B46760C-0x000000018B467634
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName) {} // 0x000000018B4675D4-0x000000018B46760C
	}

	public class SendEvent<T> : CallableActionNode<GraphOwner, string, T> // TypeDefIndex: 48517
	{
		// Constructors
		public SendEvent() {}
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName, T eventValue) {}
	}

	public class SendGlobalEvent : CallableActionNode<string> // TypeDefIndex: 48518
	{
		// Constructors
		public SendGlobalEvent() {} // 0x000000018B46768C-0x000000018B4676B4
	
		// Methods
		public override void Invoke(string eventName) {} // 0x000000018B467634-0x000000018B46768C
	}

	public class SendGlobalEvent<T> : CallableActionNode<string, T> // TypeDefIndex: 48519
	{
		// Constructors
		public SendGlobalEvent() {}
	
		// Methods
		public override void Invoke(string eventName, T eventValue) {}
	}

	public abstract class LatentActionNodeBase : SimplexNode // TypeDefIndex: 48523
	{
		// Fields
		public InvocationMode invocationMode; // 0x30
		private FlowOutput onStart; // 0x38
		private FlowOutput onUpdate; // 0x40
		private FlowOutput onFinish; // 0x48
		private Queue<RoutineData> routineQueue; // 0x50
		private Coroutine currentCoroutine; // 0x58
		private bool graphStoped; // 0x60
	
		// Properties
		public override string name { get; }
		public virtual bool allowRoutineQueueing { get; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		public enum InvocationMode // TypeDefIndex: 48520
		{
			QueueCalls = 0,
			FilterCalls = 1
		}
	
		private struct RoutineData // TypeDefIndex: 48521
		{
			// Fields
			public IEnumerator enumerator; // 0x00
			public Flow flow; // 0x08
	
			// Constructors
			public RoutineData(IEnumerator enumerator, Flow flow) {
				this.enumerator = default;
				this.flow = default;
			} // 0x000000018B4623A8-0x000000018B46244C
		}
	
		private sealed class _InternalCoroutine_d__15 : IEnumerator<object> // TypeDefIndex: 48522
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RoutineData data; // 0x20
			public LatentActionNodeBase __4__this; // 0x50
			private Flow _f_5__2; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B462020-0x000000018B4620E4 
			object IEnumerator.Current { get => default; } // 0x000000018B46217C-0x000000018B462390 
	
			// Constructors
			public _InternalCoroutine_d__15() {} // Dummy constructor
			public _InternalCoroutine_d__15(int __1__state) {} // 0x0000000185FD2860-0x0000000185FD2870
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B46216C-0x000000018B46217C
			private bool MoveNext() => default; // 0x000000018B461E8C-0x000000018B462020
			void IEnumerator.Reset() {} // 0x000000018B4620E4-0x000000018B46216C
		}
	
		// Constructors
		protected LatentActionNodeBase() {} // 0x000000018B46A9F8-0x000000018B46AD28
	
		// Methods
		public sealed override void OnGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		public sealed override void OnGraphStoped() {} // 0x00000001840A27C0-0x00000001840A27D0
		protected void Begin(IEnumerator enumerator, Flow f) {} // 0x0000000185492010-0x0000000185492020
		protected void BreakAll(bool callFinish) {} // 0x000000018B462390-0x000000018B46239C
		private IEnumerator InternalCoroutine(RoutineData data) => default; // 0x000000018B462390-0x000000018B46239C
		protected override void OnRegisterPorts(FlowNode node) {} // 0x000000018B46239C-0x000000018B4623A8
		protected abstract void OnRegisterDerivedPorts(FlowNode node); // 0x00000001859E0C30-0x00000001859E0C70
		public virtual void OnBreak() {} // 0x0000000181378230-0x0000000181378240
		private void _InternalCoroutine_b__15_0() {} // 0x0000000181377E40-0x0000000181377E50
		private void _OnRegisterPorts_b__16_0(Flow f) {} // 0x000000018B46AD28-0x000000018B46AD74
		private void _OnRegisterPorts_b__16_1(Flow f) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public abstract class LatentActionNode : LatentActionNodeBase // TypeDefIndex: 48524
	{
		// Constructors
		protected LatentActionNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract IEnumerator Invoke();
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {} // 0x000000018B46244C-0x000000018B462504
		private void _OnRegisterDerivedPorts_b__1_0(Flow f) {} // 0x000000018B462504-0x000000018B46255C
	}

	public abstract class LatentActionNode<T1> : LatentActionNodeBase // TypeDefIndex: 48526
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48525
		{
			// Fields
			public LatentActionNode<T1> __4__this;
			public ValueInput<T1> p1;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2> : LatentActionNodeBase // TypeDefIndex: 48528
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48527
		{
			// Fields
			public LatentActionNode<T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3> : LatentActionNodeBase // TypeDefIndex: 48530
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48529
		{
			// Fields
			public LatentActionNode<T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4> : LatentActionNodeBase // TypeDefIndex: 48532
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48531
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5> : LatentActionNodeBase // TypeDefIndex: 48534
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48533
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6> : LatentActionNodeBase // TypeDefIndex: 48536
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48535
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7> : LatentActionNodeBase // TypeDefIndex: 48538
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48537
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : LatentActionNodeBase // TypeDefIndex: 48540
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48539
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : LatentActionNodeBase // TypeDefIndex: 48542
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48541
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : LatentActionNodeBase // TypeDefIndex: 48544
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48543
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
			public ValueInput<T10> p10;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f) {}
		}
	
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNodeBase : SimplexNode // TypeDefIndex: 48545
	{
		// Constructors
		protected PureFunctionNodeBase() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class PureFunctionNode<TResult> : PureFunctionNodeBase // TypeDefIndex: 48546
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node) {}
		private TResult _OnRegisterPorts_b__1_0() => default;
	}

	public abstract class PureFunctionNode<TResult, T1> : PureFunctionNodeBase // TypeDefIndex: 48548
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48547
		{
			// Fields
			public PureFunctionNode<TResult, T1> __4__this;
			public ValueInput<T1> p1;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2> : PureFunctionNodeBase // TypeDefIndex: 48550
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48549
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3> : PureFunctionNodeBase // TypeDefIndex: 48552
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48551
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4> : PureFunctionNodeBase // TypeDefIndex: 48554
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48553
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5> : PureFunctionNodeBase // TypeDefIndex: 48556
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48555
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : PureFunctionNodeBase // TypeDefIndex: 48558
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48557
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : PureFunctionNodeBase // TypeDefIndex: 48560
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48559
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : PureFunctionNodeBase // TypeDefIndex: 48562
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48561
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : PureFunctionNodeBase // TypeDefIndex: 48564
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48563
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : PureFunctionNodeBase // TypeDefIndex: 48566
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48565
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ValueInput<T9> p9;
			public ValueInput<T10> p10;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal TResult _OnRegisterPorts_b__0() => default;
		}
	
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class SimplexNode // TypeDefIndex: 48567
	{
		// Fields
		[NonSerialized]
		private string _name; // 0x10
		[NonSerialized]
		private string _description; // 0x18
		private FlowNode _parentNode_k__BackingField; // 0x20
		private ParameterInfo[] _parameters; // 0x28
	
		// Properties
		protected FlowNode parentNode { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public virtual string name { get; } // 0x000000018B467E80-0x000000018B467F64 
		public virtual string description { get; } // 0x000000018B467DD8-0x000000018B467E80 
		public ParameterInfo[] parameters { get; } // 0x000000018B467F64-0x000000018B468028 
	
		// Constructors
		protected SimplexNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void RegisterPorts(FlowNode node) {} // 0x000000018B467BBC-0x000000018B467CBC
		public void SetDefaultParameters(FlowNode node) {} // 0x000000018B467CBC-0x000000018B467DD8
		protected abstract void OnRegisterPorts(FlowNode node);
		protected virtual void OnRegisterExtraPorts(FlowNode node) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphPaused() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphUnpaused() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphStoped() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class SimplexNodeWrapper : FlowNode // TypeDefIndex: 48568
	{
		// Constructors
		protected SimplexNodeWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public class SimplexNodeWrapper<T> : SimplexNodeWrapper // TypeDefIndex: 48569
		where T : SimplexNode
	{
		// Fields
		private T _simplexNode;
	
		// Properties
		public T simplexNode { get => default; }
		public override string name { get => default; }
		public override string description { get => default; }
	
		// Constructors
		public SimplexNodeWrapper() {}
	
		// Methods
		public override System.Type GetNodeWildDefinitionType() => default;
		public override void OnCreate(NodeCanvas.Framework.Graph assignedGraph) {}
		public override void OnGraphStarted() {}
		public override void OnGraphPaused() {}
		public override void OnGraphUnpaused() {}
		public override void OnGraphStoped() {}
		protected override void RegisterPorts() {}
	}

	public delegate void EventUniversalDelegate(); // TypeDefIndex: 48570; 0x00000001864BC320-0x00000001864BC330

	public delegate void EventUniversalDelegate<in T1>(T1 arg1); // TypeDefIndex: 48571; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2>(T1 arg1, T2 arg2); // TypeDefIndex: 48572; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 48573; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 48574; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 48575; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 48576; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7); // TypeDefIndex: 48577; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); // TypeDefIndex: 48578; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9); // TypeDefIndex: 48579; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10); // TypeDefIndex: 48580; 0x00000000-0x00000000

	public class GeneratedKeyAttribute : Attribute // TypeDefIndex: 48581
	{
		// Fields
		private string memberString; // 0x10
	
		// Properties
		public string MemberName { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public GeneratedKeyAttribute() {} // Dummy constructor
		public GeneratedKeyAttribute(string memberName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public struct ParamDef // TypeDefIndex: 48582
	{
		// Fields
		public System.Type paramType; // 0x00
		public System.Type arrayType; // 0x08
		public ParamMode paramMode; // 0x10
		public string portName; // 0x18
		public string portId; // 0x20
		public bool isParamsArray; // 0x28
		public MemberInfo presentedInfo; // 0x30
	}

	public struct ParametresDef // TypeDefIndex: 48583
	{
		// Fields
		public List<ParamDef> paramDefinitions; // 0x00
		public ParamDef instanceDef; // 0x08
		public ParamDef resultDef; // 0x40
	}

	public enum ParamMode // TypeDefIndex: 48584
	{
		Undefined = 0,
		In = 1,
		Out = 2,
		Ref = 3,
		Instance = 4,
		Result = 6
	}

	public static class ReflectedNodesHelper // TypeDefIndex: 48585
	{
		// Fields
		private const string RETURN_VALUE_NAME = "Value"; // Metadata: 0x02060D5C
	
		// Methods
		public static ParamDef GetGetterDefFromInfo(MemberInfo info) => default; // 0x000000018B465D44-0x000000018B465F84
		public static ParamDef GetDefFromInfo(ParameterInfo info, bool last) => default; // 0x000000018B465A90-0x000000018B465C68
		public static bool InitParams(System.Type targetType, bool isStatic, MemberInfo[] infos, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x000000018B465F84-0x000000018B466250
		private static bool InitParams(ParameterInfo[] prms, System.Type returnType, ref ParametresDef parametres) => default; // 0x000000018B466250-0x000000018B466508
		public static bool InitParams(ConstructorInfo constructor, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x000000018B466508-0x000000018B4666D8
		public static bool InitParams(MethodInfo method, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x000000018B4668FC-0x000000018B466B10
		public static bool InitParams(System.Reflection.FieldInfo field, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x000000018B4666D8-0x000000018B4668FC
		public static string GetGeneratedKey(MemberInfo memberInfo) => default; // 0x000000018B465C68-0x000000018B465D44
	}

	public delegate void UniversalDelegate(UniversalDelegateParam[] delegateParams); // TypeDefIndex: 48586; 0x00000001833EEC70-0x00000001833EEC80

	public abstract class UniversalDelegateParam // TypeDefIndex: 48587
	{
		// Fields
		public ParamDef paramDef; // 0x10
		public bool paramsArrayNeeded; // 0x48
		public int paramsArrayCount; // 0x4C
		public UniversalDelegate referencedDelegate; // 0x50
		public UniversalDelegateParam[] referencedParams; // 0x58
	
		// Properties
		public abstract System.Reflection.FieldInfo ValueField { get; }
	
		// Constructors
		protected UniversalDelegateParam() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract System.Type GetCurrentType();
		public abstract void RegisterAsInput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node, Action beforeReturn);
		public abstract void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn);
		public abstract void SetFromInput();
		public abstract void SetFromValue(object value);
	}

	public class UniversalDelegateParam<T> : UniversalDelegateParam // TypeDefIndex: 48589
	{
		// Fields
		public T value;
		private ValueInput<T> valueInput;
		private static System.Reflection.FieldInfo _fieldInfo;
	
		// Properties
		public override System.Reflection.FieldInfo ValueField { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48588
		{
			// Fields
			public Delegate beforeReturn;
			public UniversalDelegateParam<T> __4__this;
	
			// Constructors
			public __c__DisplayClass6_0() {}
	
			// Methods
			internal T _RegisterAsOutputInternal_b__0() => default;
		}
	
		// Constructors
		public UniversalDelegateParam() {}
	
		// Methods
		public override System.Type GetCurrentType() => default;
		public override void RegisterAsInput(FlowNode node) {}
		private void RegisterAsOutputInternal(FlowNode node, Delegate beforeReturn) {}
		public override void RegisterAsOutput(FlowNode node) {}
		public override void RegisterAsOutput(FlowNode node, Action beforeReturn) {}
		public override void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn) {}
		public override void SetFromInput() {}
		public override void SetFromValue(object newValue) {}
	}

	public class UniversalDelegateParam<TArray, TValue> : UniversalDelegateParam<TArray> // TypeDefIndex: 48590
	{
		// Fields
		private ValueInput<TValue>[] valueInputs;
	
		// Constructors
		public UniversalDelegateParam() {}
	
		// Methods
		public override void RegisterAsInput(FlowNode node) {}
		public override void SetFromInput() {}
	}

	public abstract class BaseReflectedConstructorNode // TypeDefIndex: 48591
	{
		// Fields
		private static Func<ConstructorInfo, BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode; // 0x00
		protected ConstructorInfo constructorInfo; // 0x10
		protected List<ParamDef> paramDefinitions; // 0x18
		protected ParamDef instanceDef; // 0x20
		protected ParamDef resultDef; // 0x58
		protected ReflectedMethodRegistrationOptions options; // 0x90
	
		// Events
		protected static event Func<ConstructorInfo, BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode;
	
		// Constructors
		protected BaseReflectedConstructorNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static BaseReflectedConstructorNode GetConstructorNode(ConstructorInfo targetConstructor, ReflectedMethodRegistrationOptions options) => default; // 0x000000018B45C89C-0x000000018B45CA50
		protected bool Init(ConstructorInfo constructor, ParametresDef parametres) => default; // 0x000000018B45CA50-0x000000018B45CC48
		protected abstract bool InitInternal(ConstructorInfo constructor);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectionConstructorNode : BaseReflectedConstructorNode // TypeDefIndex: 48595
	{
		// Fields
		private object resultObject; // 0x98
		private object[] callParams; // 0xA0
		private ValueInput[] inputs; // 0xA8
		private ValueInput[] arrayInputs; // 0xB0
		private int arrayParamsInput; // 0xB8
		private System.Type arrayParamsType; // 0xC0
	
		// Nested types
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 48592
		{
			// Fields
			public bool callable; // 0x10
			public PureReflectionConstructorNode __4__this; // 0x18
			public int idx; // 0x20
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018B46477C-0x000000018B4648F0
	
			// Methods
			internal object _RegisterOutput_b__0() => default; // 0x000000018B4645F0-0x000000018B46477C
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 48593
		{
			// Fields
			public PureReflectionConstructorNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B464AA8-0x000000018B464BA8
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B4648F0-0x000000018B464AA8
		}
	
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 48594
		{
			// Fields
			public FlowOutput output; // 0x10
			public __c__DisplayClass10_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass10_1() {} // 0x000000018B464BA8-0x000000018B464EFC
	
			// Methods
			internal void _RegisterPorts_b__1(Flow flow) {} // 0x0000000185FCDD20-0x0000000185FCDD30
		}
	
		// Constructors
		public PureReflectionConstructorNode() {} // 0x000000018B46C3F8-0x000000018B46C464
	
		// Methods
		protected override bool InitInternal(ConstructorInfo constructor) => default; // 0x0000000185492010-0x0000000185492020
		private void Call() {} // 0x000000018B46DBE4-0x000000018B46DC38
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx) {} // 0x0000000185492010-0x0000000185492020
		private void RegisterInput(FlowNode node, ParamDef def, int idx) {} // 0x000000018B46C3BC-0x000000018B46C3F8
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options) {} // 0x0000000185492010-0x0000000185492020
	}

	public class ReflectedDelegateEvent // TypeDefIndex: 48598
	{
		// Fields
		private DelegateEventCallback onCallback; // 0x10
		private Delegate theDelegate; // 0x18
	
		// Events
		private event DelegateEventCallback onCallback;
	
		// Nested types
		public delegate void DelegateEventCallback(object[] args); // TypeDefIndex: 48596; 0x000000018B4659FC-0x000000018B465A90
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48597
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__10_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B465420-0x000000018B465428
			public __c() {} // 0x000000018B4658E4-0x000000018B4658EC
	
			// Methods
			internal System.Type _GetMethodForDelegateType_b__10_0(ParameterInfo p) => default; // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public ReflectedDelegateEvent() {}
		public ReflectedDelegateEvent(System.Type delegateType) {}
	
		// Methods
		public void Add(DelegateEventCallback callback) {}
		public void Remove(DelegateEventCallback callback) {}
		public Delegate AsDelegate() => default;
		private MethodInfo GetMethodForDelegateType(System.Type delegateType) => default;
		public void Callback0() {}
		public void Callback1<T0>(T0 arg0) {}
		public void Callback2<T0, T1>(T0 arg0, T1 arg1) {}
		public void Callback3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) {}
		public void Callback4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) {} // 0x00000001864C22B8-0x00000001864C22D0
		public void Callback5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {} // 0x00000001882A83C4-0x00000001882A84E8
		public void Callback6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {} // 0x00000001833EEC70-0x00000001833EEC80
		public void Callback7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {} // 0x0000000185A264E0-0x0000000185A26510
		public void Callback8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {} // 0x00000001864BB614-0x00000001864BB734
		public void Callback9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {} // 0x000000018B46DD00-0x000000018B46DD64
		public void Callback10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {} // 0x0000000185492010-0x0000000185492020
		public static explicit operator Delegate(ReflectedDelegateEvent that) => default; // 0x0000000187AD0B74-0x0000000187AD0B8C
	}

	public class ReflectedUnityEvent // TypeDefIndex: 48601
	{
		// Fields
		private UnityEventCallback _callback; // 0x10
		private System.Type _eventType; // 0x18
		private MethodInfo _addListenerMethod; // 0x20
		private MethodInfo _removeListenerMethod; // 0x28
		private ParameterInfo[] _parameters; // 0x30
		private MethodInfo _callMethod; // 0x38
	
		// Properties
		public ParameterInfo[] parameters { get => default; } // 0x000000018B466B10-0x000000018B466B68 
		public System.Type eventType { get => default; }
	
		// Events
		private event UnityEventCallback _callback;
	
		// Nested types
		public delegate void UnityEventCallback(object[] args); // TypeDefIndex: 48599; 0x000000018B4672D4-0x000000018B467368
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48600
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__15_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x000000018B467238-0x000000018B467240
	
			// Methods
			internal System.Type _InitForEventType_b__15_0(ParameterInfo p) => default; // 0x000000018B466B68-0x000000018B4670A0
		}
	
		// Constructors
		public ReflectedUnityEvent() {}
		public ReflectedUnityEvent(System.Type eventType) {}
	
		// Methods
		public void InitForEventType(System.Type eventType) {}
		public void StartListening(UnityEventBase targetEvent, UnityEventCallback callback) {} // 0x00000001882A83C4-0x00000001882A84E8
		public void StopListening(UnityEventBase targetEvent, UnityEventCallback callback) {} // 0x00000001833EEC70-0x00000001833EEC80
		public void CallbackMethod0() {} // 0x0000000185A264E0-0x0000000185A26510
		public void CallbackMethod1<T0>(T0 arg0) {} // 0x00000001864BB614-0x00000001864BB734
		public void CallbackMethod2<T0, T1>(T0 arg0, T1 arg1) {} // 0x000000018B46DD64-0x000000018B46DDC8
		public void CallbackMethod3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) {} // 0x0000000185492010-0x0000000185492020
		public void CallbackMethod4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) {} // 0x0000000187AD0B74-0x0000000187AD0B8C
	}

	public abstract class SharpEvent // TypeDefIndex: 48602
	{
		// Fields
		private object _instance_k__BackingField; // 0x10
		private EventInfo _eventInfo_k__BackingField; // 0x18
	
		// Properties
		public object instance { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public EventInfo eventInfo { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		protected SharpEvent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static SharpEvent Create(EventInfo eventInfo) => default; // 0x000000018B4679C4-0x000000018B467B0C
		public void SetInstance(object instance) {} // 0x0000000184096E30-0x0000000184096EF0
		public void StartListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback) {} // 0x000000018B467B0C-0x000000018B467B64
		public void StopListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback) {} // 0x000000018B467B64-0x000000018B467BBC
	}

	public class SharpEvent<T> : SharpEvent // TypeDefIndex: 48603
	{
		// Constructors
		public SharpEvent() {}
	}

	public abstract class BaseReflectedExtractorNode // TypeDefIndex: 48604
	{
		// Fields
		private static Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode; // 0x00
		private ParametresDef _Params_k__BackingField; // 0x10
		private System.Type _TargetType_k__BackingField; // 0x88
	
		// Properties
		protected ParametresDef Params { get; private set; } // 0x0000000185FC3B70-0x0000000185FC3BC0 0x000000018B45D0E8-0x000000018B45D138
		protected System.Type TargetType { get; private set; } // 0x0000000185FB0510-0x0000000185FB0520 0x0000000186472AA8-0x0000000186472ABC
	
		// Events
		protected static event Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode;
	
		// Constructors
		protected BaseReflectedExtractorNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static BaseReflectedExtractorNode GetExtractorNode(System.Type targetType, bool isStatic, MemberInfo[] infos) => default; // 0x000000018B45CD80-0x000000018B45CF34
		protected bool Init(ParametresDef paramsDef, System.Type targetType) => default; // 0x000000018B45CF34-0x000000018B45CFB0
		protected abstract bool InitInternal();
		public abstract void RegisterPorts(FlowNode node);
	}

	public class PureReflectedExtractorNode : BaseReflectedExtractorNode // TypeDefIndex: 48607
	{
		// Fields
		private static readonly object[] EmptyParams; // 0x00
		private ValueInput instanceInput; // 0x90
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48605
		{
			// Fields
			public PureReflectedExtractorNode __4__this; // 0x10
			public System.Reflection.FieldInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018B4634DC-0x000000018B463500
	
			// Methods
			internal object _GetPortHandler_b__0() => default; // 0x000000018B46340C-0x000000018B4634DC
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48606
		{
			// Fields
			public PureReflectedExtractorNode __4__this; // 0x10
			public MethodInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018B46333C-0x000000018B46340C
	
			// Methods
			internal object _GetPortHandler_b__0() => default; // 0x000000018B463500-0x000000018B4636D8
		}
	
		// Constructors
		public PureReflectedExtractorNode() {} // 0x0000000185492010-0x0000000185492020
		static PureReflectedExtractorNode() {} // 0x000000018B46CFD4-0x000000018B46D06C
	
		// Methods
		protected override bool InitInternal() => default; // 0x0000000185492010-0x0000000185492020
		private ValueHandlerObject GetPortHandler(System.Reflection.FieldInfo info) => default; // 0x000000018B4636D8-0x000000018B46373C
		private ValueHandlerObject GetPortHandler(MethodInfo info) => default; // 0x0000000185492010-0x0000000185492020
		public override void RegisterPorts(FlowNode node) {} // 0x000000018B46CDF8-0x000000018B46CE48
	}

	public abstract class BaseReflectedFieldNode // TypeDefIndex: 48608
	{
		// Fields
		private static Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode; // 0x00
		protected System.Reflection.FieldInfo fieldInfo; // 0x10
		protected ParamDef instanceDef; // 0x18
		protected ParamDef resultDef; // 0x50
	
		// Events
		protected static event Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode;
	
		// Constructors
		protected BaseReflectedFieldNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static BaseReflectedFieldNode GetFieldNode(System.Reflection.FieldInfo targetField) => default; // 0x000000018B45D138-0x000000018B45D2C0
		protected bool Init(System.Reflection.FieldInfo field, ParametresDef parametres) => default; // 0x000000018B45D2C0-0x000000018B45D424
		protected abstract bool InitInternal(System.Reflection.FieldInfo field);
		public abstract void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	public class PureReflectedFieldNode : BaseReflectedFieldNode // TypeDefIndex: 48610
	{
		// Fields
		private ValueInput instanceInput; // 0x88
		private ValueInput valueInput; // 0x90
		private object instanceObject; // 0x98
		private object valueObject; // 0xA0
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 48609
		{
			// Fields
			public FlowOutput output; // 0x10
			public PureReflectedFieldNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018B4637AC-0x000000018B4637F8
	
			// Methods
			internal void _RegisterPorts_b__2(Flow flow) {} // 0x000000018B463B3C-0x000000018B463BD0
		}
	
		// Constructors
		public PureReflectedFieldNode() {} // 0x000000018B463BD0-0x000000018B463BF0
	
		// Methods
		protected override bool InitInternal(System.Reflection.FieldInfo method) => default; // 0x000000018B46373C-0x000000018B4637AC
		private void SetValue() {} // 0x000000018B4637F8-0x000000018B463B3C
		private void GetValue() {} // 0x0000000185492010-0x0000000185492020
		public override void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode) {} // 0x0000000181E336C0-0x0000000181E336D0
		private object _RegisterPorts_b__7_0() => default; // 0x0000000185492010-0x0000000185492020
		private object _RegisterPorts_b__7_1() => default; // 0x000000018B46DB60-0x000000018B46DBC4
	}

	public abstract class BaseReflectedMethodNode // TypeDefIndex: 48611
	{
		// Fields
		private static Func<MethodInfo, BaseReflectedMethodNode> OnGetAotReflectedMethodNode; // 0x00
		protected MethodInfo methodInfo; // 0x10
		protected List<ParamDef> paramDefinitions; // 0x18
		protected ParamDef instanceDef; // 0x20
		protected ParamDef resultDef; // 0x58
		protected ReflectedMethodRegistrationOptions options; // 0x90
	
		// Events
		protected static event Func<MethodInfo, BaseReflectedMethodNode> OnGetAotReflectedMethodNode;
	
		// Constructors
		protected BaseReflectedMethodNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static BaseReflectedMethodNode GetMethodNode(MethodInfo targetMethod, ReflectedMethodRegistrationOptions options) => default; // 0x000000018B45D55C-0x000000018B45D710
		protected bool Init(MethodInfo method, ParametresDef parametres) => default; // 0x000000018B45D710-0x000000018B45D8D4
		protected abstract bool InitInternal(MethodInfo method);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectedMethodNode : BaseReflectedMethodNode // TypeDefIndex: 48615
	{
		// Fields
		private ValueInput instanceInput; // 0x98
		private object instanceObject; // 0xA0
		private object resultObject; // 0xA8
		private object[] callParams; // 0xB0
		private ValueInput[] inputs; // 0xB8
		private ValueInput[] arrayInputs; // 0xC0
		private int arrayParamsInput; // 0xC8
		private System.Type arrayParamsType; // 0xD0
	
		// Nested types
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 48612
		{
			// Fields
			public bool callable; // 0x10
			public PureReflectedMethodNode __4__this; // 0x18
			public int idx; // 0x20
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B463DB8-0x000000018B463F40
	
			// Methods
			internal object _RegisterOutput_b__0() => default; // 0x000000018B463BF0-0x000000018B463DB8
		}
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 48613
		{
			// Fields
			public PureReflectedMethodNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018B4640F8-0x000000018B4641F4
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B463F40-0x000000018B4640F8
			internal object _RegisterPorts_b__1() => default; // 0x000000018B4641F4-0x000000018B4645F0
		}
	
		private sealed class __c__DisplayClass12_1 // TypeDefIndex: 48614
		{
			// Fields
			public FlowOutput output; // 0x10
			public __c__DisplayClass12_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass12_1() {} // 0x0000000185FD2890-0x0000000185FD28A0
	
			// Methods
			internal void _RegisterPorts_b__2(Flow flow) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public PureReflectedMethodNode() {} // 0x000000018B46C4A0-0x000000018B46C50C
	
		// Methods
		protected override bool InitInternal(MethodInfo method) => default; // 0x000000018B46C368-0x000000018B46C3BC
		private void Call() {} // 0x0000000185492010-0x0000000185492020
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx) {} // 0x0000000186470FA0-0x0000000186470FC0
		private void RegisterInput(FlowNode node, ParamDef def, int idx) {} // 0x000000018B46C464-0x000000018B46C4A0
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options) {} // 0x0000000185492010-0x0000000185492020
	}

	public class ReflectedConstructorNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 48616
	{
		// Fields
		private SerializedConstructorInfo _constructor; // 0xB8
		private BaseReflectedConstructorNode _reflectedConstructorNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedConstructorNode reflectedConstructorNode { get; set; } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		private ConstructorInfo constructor { get => default; } // 0x000000018B4652F0-0x000000018B465304 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get => default; } // 0x000000018349D710-0x000000018349D720 
		public override string name { get => default; } // 0x000000018B465304-0x000000018B465420 
	
		// Constructors
		public ReflectedConstructorNodeWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null) {} // 0x000000018B465288-0x000000018B4652F0
		private void SetConstructor(ConstructorInfo newConstructor) {} // 0x000000018B4651F4-0x000000018B465288
		protected override void RegisterPorts() {} // 0x000000018B465124-0x000000018B4651F4
	}

	public class ReflectedExtractorNodeWrapper<T> : FlowNode // TypeDefIndex: 48617
	{
		// Fields
		private static Dictionary<string, MemberInfo> _memberInfos;
		private static List<string> _instanceMemberNames;
		private static List<string> _staticMemberNames;
		private List<string> _selectedInstanceMembers;
		[NonSerialized]
		private BaseReflectedExtractorNode extractorNode;
	
		// Properties
		public override string name { get => default; }
	
		// Constructors
		public ReflectedExtractorNodeWrapper() {}
	
		// Methods
		public System.Type GetRuntimeIconType() => default;
		private static void PopulateInfos() {}
		protected override void RegisterPorts() {}
	}

	internal class ReflectedFieldNodeWrapper_0 // TypeDefIndex: 48618
	{
		// Fields
		public string fieldName; // 0x10
		public System.Type targetType; // 0x18
	
		// Constructors
		public ReflectedFieldNodeWrapper_0() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ReflectedFieldNodeWrapper : FlowNode, IReflectedWrapper, IMigratable<ReflectedFieldNodeWrapper_0> // TypeDefIndex: 48620
	{
		// Fields
		private SerializedFieldInfo _field; // 0xB0
		private AccessMode accessMode; // 0xB8
		private BaseReflectedFieldNode _reflectedFieldNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedFieldNode reflectedFieldNode { get; set; } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		private System.Reflection.FieldInfo field { get => default; } // 0x0000000189D7160C-0x0000000189D71620 
		public override string name { get => default; } // 0x000000018B483C9C-0x000000018B483F1C 
	
		// Nested types
		public enum AccessMode // TypeDefIndex: 48619
		{
			GetField = 0,
			SetField = 1
		}
	
		// Constructors
		public ReflectedFieldNodeWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		void IMigratable<ReflectedFieldNodeWrapper_0>.Migrate(ReflectedFieldNodeWrapper_0 model) {} // 0x000000018B4839F8-0x000000018B483AB8
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018346D8F0-0x000000018346D900
		private System.Type GetRuntimeIconType() => default; // 0x000000018B4839A8-0x000000018B4839F8
		public void SetField(System.Reflection.FieldInfo newField, AccessMode mode, object instance = null) {} // 0x000000018B483B54-0x000000018B483C9C
		protected override void RegisterPorts() {} // 0x000000018B483AB8-0x000000018B483B54
	}

	public abstract class ReflectedMethodBaseNodeWrapper : FlowNode, IReflectedWrapper // TypeDefIndex: 48621
	{
		// Fields
		protected bool _callable; // 0xB0
		protected bool _exposeParams; // 0xB1
		protected int _exposedParamsCount; // 0xB4
	
		// Properties
		protected abstract ISerializedMethodBaseInfo serializedMethodBase { get; }
		private MethodBase method { get; } // 0x000000018B484170-0x000000018B4841FC 
		public bool callable { get; set; } // 0x0000000181B10450-0x0000000181B10460 0x000000018B4841FC-0x000000018B484214
		public bool exposeParams { get; set; } // 0x0000000185FB2D00-0x0000000185FB2D10 0x000000018B484214-0x000000018B484240
		public int exposedParamsCount { get; set; } // 0x0000000185FB32D0-0x0000000185FB32E0 0x000000018B484240-0x000000018B484264
	
		// Constructors
		protected ReflectedMethodBaseNodeWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B483FA8-0x000000018B483FB8
		public System.Type GetRuntimeIconType() => default; // 0x000000018B483F58-0x000000018B483FA8
		public abstract void SetMethodBase(MethodBase newMethod, object instance = null);
		public void SetDefaultParameterValues(MethodBase newMethod) {} // 0x000000018B483FB8-0x000000018B4840D0
		public void SetDropInstanceReference(MethodBase newMethod, object instance = null) {} // 0x000000018B4840D0-0x000000018B484170
	}

	public class ReflectedMethodNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 48622
	{
		// Fields
		private SerializedMethodInfo _method; // 0xB8
		private BaseReflectedMethodNode _reflectedMethodNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedMethodNode reflectedMethodNode { get; set; } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		private new MethodInfo method { get => default; } // 0x000000018B4846D8-0x000000018B4846EC 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get => default; } // 0x000000018349D710-0x000000018349D720 
		public override string name { get => default; } // 0x000000018B4846EC-0x000000018B4849C4 
	
		// Constructors
		public ReflectedMethodNodeWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null) {} // 0x000000018B4844A0-0x000000018B484518
		private void SetMethod(MethodInfo newMethod, object instance = null) {} // 0x000000018B484518-0x000000018B4846D8
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x000000018B4842B4-0x000000018B484414
		public override System.Type GetNodeWildDefinitionType() => default; // 0x000000018B484264-0x000000018B4842B4
		protected override void RegisterPorts() {} // 0x000000018B484414-0x000000018B4844A0
	}

	public struct ReflectedMethodRegistrationOptions // TypeDefIndex: 48623
	{
		// Fields
		public bool callable; // 0x00
		public bool exposeParams; // 0x01
		public int exposedParamsCount; // 0x04
	}

	public abstract class FlowNestedBase<T> : FlowNodeNested<T>, IDropedReferenceNode, IUpdatable // TypeDefIndex: 48625
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		public BBParameter<T> _subGraph;
		private ValueInput<Component> targetAgent;
		private FlowOutput onStart;
		private FlowOutput onUpdate;
		private FlowOutput onFinish;
		private bool paused;
		private bool endResult;
	
		// Properties
		public override T subGraph { get; set; }
		public override BBParameter subGraphParameter { get; }
		public override Alignment2x2 iconAlignment { get; }
	
		// Nested types
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 48624
		{
			// Fields
			public FlowNestedBase<T> __4__this;
			public Flow f;
	
			// Constructors
			public __c__DisplayClass16_0() {}
	
			// Methods
			internal void _Start_b__0(bool result) {}
		}
	
		// Constructors
		protected FlowNestedBase() {}
	
		// Methods
		void IDropedReferenceNode.SetTarget(UnityEngine.Object target) {}
		protected override void RegisterPorts() {}
		private void Start(Flow f) {}
		private void Stop(Flow f) {}
		private void OnStop(Flow f) {}
		private void Pause(Flow f) {}
		private void Resume(Flow f) {}
		void IUpdatable.Update() {}
		private float _RegisterPorts_b__15_0() => default;
		private bool _RegisterPorts_b__15_1() => default;
	}

	public class FlowNestedFlow : FlowNestedBase<FlowScript> // TypeDefIndex: 48626
	{
		// Constructors
		public FlowNestedFlow() {} // 0x000000018B47F444-0x000000018B47F480
	}

	public class CreateCollection<T> : FlowNode // TypeDefIndex: 48629
	{
		// Fields
		private int _portCount;
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48627
		{
			// Fields
			public List<ValueInput<T>> ins;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal T[] _RegisterPorts_b__0() => default;
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48628
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<ValueInput<T>, T> __9__1_1;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal T _RegisterPorts_b__1_1(ValueInput<T> p) => default;
		}
	
		// Constructors
		public CreateCollection() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class CreateDictionary<T> : FlowNode // TypeDefIndex: 48633
	{
		// Fields
		private int _portCount;
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48630
		{
			// Fields
			public List<ValueInput<string>> keys;
			public List<ValueInput<T>> values;
	
			// Constructors
			public __c__DisplayClass1_0() {}
	
			// Methods
			internal IDictionary<string, T> _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 48631
		{
			// Fields
			public List<T> v;
			public List<string> k;
	
			// Constructors
			public __c__DisplayClass1_1() {}
	
			// Methods
			internal T _RegisterPorts_b__4(string x) => default;
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48632
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<ValueInput<string>, string> __9__1_1;
			public static Func<ValueInput<T>, T> __9__1_2;
			public static Func<string, string> __9__1_3;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal string _RegisterPorts_b__1_1(ValueInput<string> x) => default;
			internal T _RegisterPorts_b__1_2(ValueInput<T> x) => default;
			internal string _RegisterPorts_b__1_3(string x) => default;
		}
	
		// Constructors
		public CreateDictionary() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class GetOtherVariable<T> : FlowNode // TypeDefIndex: 48635
	{
		// Properties
		public override string name { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48634
		{
			// Fields
			public ValueInput<IBlackboard> bb;
			public ValueInput<string> varName;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
		}
	
		// Constructors
		public GetOtherVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public class GetVariable<T> : ParameterVariableNode // TypeDefIndex: 48636
	{
		// Fields
		public BBParameter<T> value;
	
		// Properties
		public override BBParameter parameter { get => default; }
	
		// Constructors
		public GetVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
		private T _RegisterPorts_b__3_0() => default;
	}

	public abstract class RelayValueInputBase : FlowNode // TypeDefIndex: 48637
	{
		// Properties
		public abstract System.Type relayType { get; }
	
		// Constructors
		protected RelayValueInputBase() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public class RelayValueInput<T> : RelayValueInputBase, IEditorMenuCallbackReceiver // TypeDefIndex: 48639
	{
		// Fields
		public string identifier;
		private ValueInput<T> _port_k__BackingField;
		private bool _cached_k__BackingField;
		private T _cachedValue_k__BackingField;
	
		// Properties
		public ValueInput<T> port { get; private set; }
		public bool cached { get; private set; }
		public T cachedValue { get; private set; }
		public override System.Type relayType { get => default; }
		public override string name { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 48638
		{
			// Fields
			public RelayValueInput<T> __4__this;
			public FlowOutput fOut;
	
			// Constructors
			public __c__DisplayClass17_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
		}
	
		// Constructors
		public RelayValueInput() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	public abstract class RelayValueOutputBase : FlowNode // TypeDefIndex: 48640
	{
		// Constructors
		protected RelayValueOutputBase() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public abstract void SetSource(RelayValueInputBase source);
	}

	public class RelayValueOutput<T> : RelayValueOutputBase // TypeDefIndex: 48641
	{
		// Fields
		private string _sourceInputUID;
		private WeakReference<RelayValueInputBase> _sourceInputRef;
	
		// Properties
		private string sourceInputUID { get => default; set {} }
		private RelayValueInput<T> sourceInput { get => default; }
		public override string name { get => default; }
	
		// Constructors
		public RelayValueOutput() {}
	
		// Methods
		public override void SetSource(RelayValueInputBase source) {}
		protected override void RegisterPorts() {}
		private bool _get_sourceInput_b__6_0(RelayValueInput<T> i) => default;
		private T _RegisterPorts_b__10_0() => default;
	}

	public class NullObject : FlowNode // TypeDefIndex: 48643
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48642
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueHandler<object> __9__0_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B482720-0x000000018B482864
			public __c() {} // 0x0000000183055FD0-0x0000000183055FE0
	
			// Methods
			internal object _RegisterPorts_b__0_0() => default; // 0x000000018B486568-0x000000018B4865CC
		}
	
		// Constructors
		public NullObject() {} // 0x00000001813AE580-0x00000001813AE590
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000185492010-0x0000000185492020
	}

	public class OwnerVariable : FlowNode // TypeDefIndex: 48644
	{
		// Properties
		public override string name { get => default; } // 0x000000018B48299C-0x000000018B4829C8 
	
		// Constructors
		public OwnerVariable() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B482864-0x000000018B48291C
		private GameObject _RegisterPorts_b__2_0() => default; // 0x000000018B48291C-0x000000018B48299C
	}

	public abstract class ParameterVariableNode : FlowNode // TypeDefIndex: 48645
	{
		// Properties
		public abstract BBParameter parameter { get; }
	
		// Constructors
		protected ParameterVariableNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public class SetOtherVariable<T> : FlowNode // TypeDefIndex: 48647
	{
		// Fields
		public OperationMethod operation;
		private ValueInput<string> varName;
	
		// Properties
		public override string name { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48646
		{
			// Fields
			public ValueInput<NodeCanvas.Framework.Blackboard> bb;
			public SetOtherVariable<T> __4__this;
			public ValueInput<T> v;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public SetOtherVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
		private void DoSet(NodeCanvas.Framework.Blackboard bb, string name, T value) {}
	}

	public class SetVariable<T> : ParameterVariableNode // TypeDefIndex: 48649
	{
		// Fields
		public BBParameter<T> targetVariable;
		public OperationMethod operation;
		public bool perSecond;
	
		// Properties
		public override BBParameter parameter { get => default; }
		public override string name { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 48648
		{
			// Fields
			public SetVariable<T> __4__this;
			public ValueInput<T> v;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass7_0() {}
	
			// Methods
			internal T _RegisterPorts_b__0() => default;
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public SetVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
		private void DoSet(T value) {}
	}

	public abstract class CodeEventBase : EventNode<Transform> // TypeDefIndex: 48650
	{
		// Fields
		protected string eventName; // 0xB8
		protected System.Type targetType; // 0xC0
		protected Component targetComponent; // 0xC8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018B47E528-0x000000018B47E5B8 
	
		// Constructors
		protected CodeEventBase() {} // 0x000000018B47E4F4-0x000000018B47E528
	
		// Methods
		public void SetEvent(EventInfo e, object instace = null) {} // 0x000000018B47E460-0x000000018B47E4F4
		public override void OnPostGraphStarted() {} // 0x000000018B47E2D0-0x000000018B47E460
	}

	public class CodeEvent : CodeEventBase // TypeDefIndex: 48651
	{
		// Fields
		private FlowOutput o; // 0xD0
		private Action pointer; // 0xD8
	
		// Constructors
		public CodeEvent() {} // 0x0000000189FA6CA4-0x0000000189FA6CAC
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018B47E6C8-0x000000018B47E77C
		public override void OnGraphStoped() {} // 0x000000018B47E608-0x000000018B47E6C8
		protected override void RegisterPorts() {} // 0x000000018B47E77C-0x000000018B47E7E4
		private void Call() {} // 0x000000018B47E5B8-0x000000018B47E608
	}

	public class CodeEvent<T> : CodeEventBase // TypeDefIndex: 48652
	{
		// Fields
		private FlowOutput o;
		private Action<T> pointer;
		private T eventValue;
	
		// Constructors
		public CodeEvent() {}
	
		// Methods
		public override void OnPostGraphStarted() {}
		public override void OnGraphStoped() {}
		private void Call(T eventValue) {}
		protected override void RegisterPorts() {}
		private T _RegisterPorts_b__6_0() => default;
	}

	public class NewGameObject : CallableFunctionNode<GameObject, string, Vector3, Quaternion> // TypeDefIndex: 48653
	{
		// Constructors
		public NewGameObject() {} // 0x000000018B4825B0-0x000000018B4825D8
	
		// Methods
		public override GameObject Invoke(string name, Vector3 position, Quaternion rotation) => default; // 0x000000018B4824DC-0x000000018B4825B0
	}

	public class NewVector2 : PureFunctionNode<Vector2, float, float> // TypeDefIndex: 48654
	{
		// Constructors
		public NewVector2() {} // 0x000000018B4826A8-0x000000018B4826D0
	
		// Methods
		public override Vector2 Invoke(float x, float y) => default; // 0x0000000185FD29F0-0x0000000185FD2A00
	}

	public class NewVector3 : PureFunctionNode<Vector3, float, float, float> // TypeDefIndex: 48655
	{
		// Constructors
		public NewVector3() {} // 0x000000018B4826D0-0x000000018B4826F8
	
		// Methods
		public override Vector3 Invoke(float x, float y, float z) => default; // 0x0000000185FD2A00-0x0000000185FD2A20
	}

	public class NewVector4 : PureFunctionNode<Vector4, float, float, float, float> // TypeDefIndex: 48656
	{
		// Constructors
		public NewVector4() {} // 0x000000018B4826F8-0x000000018B482720
	
		// Methods
		public override Vector4 Invoke(float x, float y, float z, float w) => default; // 0x0000000185FD29C0-0x0000000185FD29F0
	}

	public class NewQuaternion : PureFunctionNode<Quaternion, float, float, float, float> // TypeDefIndex: 48657
	{
		// Constructors
		public NewQuaternion() {} // 0x000000018B4825D8-0x000000018B482600
	
		// Methods
		public override Quaternion Invoke(float x, float y, float z, float w) => default; // 0x0000000185FD29C0-0x0000000185FD29F0
	}

	public class NewColor : PureFunctionNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 48658
	{
		// Constructors
		public NewColor() {} // 0x000000018B4824B4-0x000000018B4824DC
	
		// Methods
		public override UnityEngine.Color Invoke(float r, float g, float b, float a = 1f /* Metadata: 0x02060D64 */) => default; // 0x0000000185FD29C0-0x0000000185FD29F0
	}

	public class NewBounds : PureFunctionNode<Bounds, Vector3, Vector3> // TypeDefIndex: 48659
	{
		// Constructors
		public NewBounds() {} // 0x000000018B48248C-0x000000018B4824B4
	
		// Methods
		public override Bounds Invoke(Vector3 center, Vector3 size) => default; // 0x000000018B482434-0x000000018B48248C
	}

	public class NewRect : PureFunctionNode<Rect, float, float, float, float> // TypeDefIndex: 48660
	{
		// Constructors
		public NewRect() {} // 0x000000018B482680-0x000000018B4826A8
	
		// Methods
		public override Rect Invoke(float left, float top, float width, float height) => default; // 0x0000000185FD29C0-0x0000000185FD29F0
	}

	public class NewRay : PureFunctionNode<Ray, Vector3, Vector3> // TypeDefIndex: 48661
	{
		// Constructors
		public NewRay() {} // 0x000000018B482658-0x000000018B482680
	
		// Methods
		public override Ray Invoke(Vector3 origin, Vector3 direction) => default; // 0x000000018B482600-0x000000018B482658
	}

	public class ConvertTo<T> : PureFunctionNode<T, IConvertible> // TypeDefIndex: 48662
		where T : IConvertible
	{
		// Constructors
		public ConvertTo() {}
	
		// Methods
		public override T Invoke(IConvertible obj) => default;
	}

	public class CastTo<T> : PureFunctionNode<T, object> // TypeDefIndex: 48663
	{
		// Constructors
		public CastTo() {}
	
		// Methods
		public override T Invoke(object obj) => default;
	}

	public class ToArray<T> : PureFunctionNode<T[], IList<T>> // TypeDefIndex: 48664
	{
		// Constructors
		public ToArray() {}
	
		// Methods
		public override T[] Invoke(IList<T> list) => default;
	}

	public class ToList<T> : PureFunctionNode<List<T>, IList<T>> // TypeDefIndex: 48665
	{
		// Constructors
		public ToList() {}
	
		// Methods
		public override List<T> Invoke(IList<T> list) => default;
	}

	public abstract class CustomObjectWrapper : FlowNode // TypeDefIndex: 48666
	{
		// Constructors
		protected CustomObjectWrapper() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public abstract void SetTarget(UnityEngine.Object target);
	}

	public abstract class CustomObjectWrapper<T> : CustomObjectWrapper // TypeDefIndex: 48667
		where T : UnityEngine.Object
	{
		// Fields
		private T _target;
	
		// Properties
		public T target { get; set; }
		public override string name { get; }
	
		// Constructors
		protected CustomObjectWrapper() {}
	
		// Methods
		public override void SetTarget(UnityEngine.Object target) {}
		protected System.Type GetRuntimeIconType() => default;
	}

	public class ExtractVector2 : ExtractorNode<Vector2, float, float> // TypeDefIndex: 48668
	{
		// Constructors
		public ExtractVector2() {} // 0x000000018B47EFBC-0x000000018B47EFE4
	
		// Methods
		public override void Invoke(Vector2 vector, out float x, out float y) {
			x = default;
			y = default;
		} // 0x0000000185FD2980-0x0000000185FD29A0
	}

	public class ExtractVector3 : ExtractorNode<Vector3, float, float, float> // TypeDefIndex: 48669
	{
		// Constructors
		public ExtractVector3() {} // 0x000000018B47EFE4-0x000000018B47F00C
	
		// Methods
		public override void Invoke(Vector3 vector, out float x, out float y, out float z) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FD29A0-0x0000000185FD29C0
	}

	public class ExtractVector4 : ExtractorNode<Vector4, float, float, float, float> // TypeDefIndex: 48670
	{
		// Constructors
		public ExtractVector4() {} // 0x000000018B47F00C-0x000000018B47F034
	
		// Methods
		public override void Invoke(Vector4 vector, out float x, out float y, out float z, out float w) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FD2900-0x0000000185FD2920
	}

	public class ExtractQuaternion : ExtractorNode<Quaternion, float, float, float, float, Vector3> // TypeDefIndex: 48671
	{
		// Constructors
		public ExtractQuaternion() {} // 0x000000018B47ECB4-0x000000018B47ECDC
	
		// Methods
		public override void Invoke(Quaternion quaternion, out float x, out float y, out float z, out float w, out Vector3 eulerAngles) {
			x = default;
			y = default;
			z = default;
			w = default;
			eulerAngles = default;
		} // 0x000000018B47EC6C-0x000000018B47ECB4
	}

	public class ExtractRect : ExtractorNode<Rect, Vector2, float, float, float, float> // TypeDefIndex: 48672
	{
		// Constructors
		public ExtractRect() {} // 0x000000018B47EF94-0x000000018B47EFBC
	
		// Methods
		public override void Invoke(Rect rect, out Vector2 center, out float xMin, out float xMax, out float yMin, out float yMax) {
			center = default;
			xMin = default;
			xMax = default;
			yMin = default;
			yMax = default;
		} // 0x000000018B47EF30-0x000000018B47EF94
	}

	public class ExtractColor : ExtractorNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 48673
	{
		// Constructors
		public ExtractColor() {} // 0x000000018B47EB14-0x000000018B47EB3C
	
		// Methods
		public override void Invoke(UnityEngine.Color color, out float r, out float g, out float b, out float a) {
			r = default;
			g = default;
			b = default;
			a = default;
		} // 0x0000000185FD2900-0x0000000185FD2920
	}

	public class ExtractRaycastHit : ExtractorNode<RaycastHit, GameObject, float, Vector3, Vector3> // TypeDefIndex: 48674
	{
		// Constructors
		public ExtractRaycastHit() {} // 0x000000018B47EF08-0x000000018B47EF30
	
		// Methods
		public override void Invoke(RaycastHit hit, out GameObject gameObject, out float distance, out Vector3 normal, out Vector3 point) {
			gameObject = default;
			distance = default;
			normal = default;
			point = default;
		} // 0x000000018B47EE4C-0x000000018B47EF08
	}

	public class ExtractRaycastHit2D : ExtractorNode<RaycastHit2D, GameObject, float, float, Vector3, Vector3> // TypeDefIndex: 48675
	{
		// Constructors
		public ExtractRaycastHit2D() {} // 0x000000018B47EE24-0x000000018B47EE4C
	
		// Methods
		public override void Invoke(RaycastHit2D hit, out GameObject gameObject, out float distance, out float fraction, out Vector3 normal, out Vector3 point) {
			gameObject = default;
			distance = default;
			fraction = default;
			normal = default;
			point = default;
		} // 0x000000018B47ED04-0x000000018B47EE24
	}

	public class ExtractRay : ExtractorNode<Ray, Vector3, Vector3> // TypeDefIndex: 48676
	{
		// Constructors
		public ExtractRay() {} // 0x000000018B47ECDC-0x000000018B47ED04
	
		// Methods
		public override void Invoke(Ray ray, out Vector3 origin, out Vector3 direction) {
			origin = default;
			direction = default;
		} // 0x0000000185FD2950-0x0000000185FD2980
	}

	public class ExtractBounds : ExtractorNode<Bounds, Vector3, Vector3, Vector3, Vector3, Vector3> // TypeDefIndex: 48677
	{
		// Constructors
		public ExtractBounds() {} // 0x000000018B47E924-0x000000018B47E94C
	
		// Methods
		public override void Invoke(Bounds bounds, out Vector3 center, out Vector3 extents, out Vector3 max, out Vector3 min, out Vector3 size) {
			center = default;
			extents = default;
			max = default;
			min = default;
			size = default;
		} // 0x000000018B47E88C-0x000000018B47E924
	}

	public class ExtractCollision : ExtractorNode<UnityEngine.Collision, ContactPoint[], ContactPoint, GameObject, Vector3> // TypeDefIndex: 48678
	{
		// Constructors
		public ExtractCollision() {} // 0x000000018B47EAEC-0x000000018B47EB14
	
		// Methods
		public override void Invoke(UnityEngine.Collision collision, out ContactPoint[] contacts, out ContactPoint firstContact, out GameObject gameObject, out Vector3 velocity) {
			contacts = default;
			firstContact = default;
			gameObject = default;
			velocity = default;
		} // 0x000000018B47EA38-0x000000018B47EAEC
	}

	public class ExtractCollision2D : ExtractorNode<Collision2D, ContactPoint2D[], ContactPoint2D, GameObject, Vector2> // TypeDefIndex: 48679
	{
		// Constructors
		public ExtractCollision2D() {} // 0x000000018B47EA10-0x000000018B47EA38
	
		// Methods
		public override void Invoke(Collision2D collision, out ContactPoint2D[] contacts, out ContactPoint2D firstContact, out GameObject gameObject, out Vector2 velocity) {
			contacts = default;
			firstContact = default;
			gameObject = default;
			velocity = default;
		} // 0x000000018B47E94C-0x000000018B47EA10
	}

	public class ExtractContactPoint : ExtractorNode<ContactPoint, Vector3, Vector3, Collider, Collider> // TypeDefIndex: 48680
	{
		// Constructors
		public ExtractContactPoint() {} // 0x000000018B47EC1C-0x000000018B47EC44
	
		// Methods
		public override void Invoke(ContactPoint contactPoint, out Vector3 normal, out Vector3 point, out Collider colliderA, out Collider colliderB) {
			normal = default;
			point = default;
			colliderA = default;
			colliderB = default;
		} // 0x000000018B47EBBC-0x000000018B47EC1C
	}

	public class ExtractContactPoint2D : ExtractorNode<ContactPoint2D, Vector2, Vector2, Collider2D, Collider2D> // TypeDefIndex: 48681
	{
		// Constructors
		public ExtractContactPoint2D() {} // 0x000000018B47EB94-0x000000018B47EBBC
	
		// Methods
		public override void Invoke(ContactPoint2D contactPoint, out Vector2 normal, out Vector2 point, out Collider2D colliderA, out Collider2D colliderB) {
			normal = default;
			point = default;
			colliderA = default;
			colliderB = default;
		} // 0x000000018B47EB3C-0x000000018B47EB94
	}

	public class ExtractAnimationCurve : ExtractorNode<AnimationCurve, Keyframe[], float, UnityEngine.WrapMode, UnityEngine.WrapMode> // TypeDefIndex: 48682
	{
		// Constructors
		public ExtractAnimationCurve() {} // 0x000000018B47E864-0x000000018B47E88C
	
		// Methods
		public override void Invoke(AnimationCurve curve, out Keyframe[] keys, out float length, out UnityEngine.WrapMode postWrapMode, out UnityEngine.WrapMode preWrapMode) {
			keys = default;
			length = default;
			postWrapMode = default;
			preWrapMode = default;
		} // 0x000000018B47E7E4-0x000000018B47E864
	}

	public class ExtractKeyFrame : ExtractorNode<Keyframe, float, float, float, float> // TypeDefIndex: 48683
	{
		// Constructors
		public ExtractKeyFrame() {} // 0x000000018B47EC44-0x000000018B47EC6C
	
		// Methods
		public override void Invoke(Keyframe key, out float inTangent, out float outTangent, out float time, out float value) {
			inTangent = default;
			outTangent = default;
			time = default;
			value = default;
		} // 0x0000000185FD2920-0x0000000185FD2950
	}

	public class SwitchValue<T> : PureFunctionNode<T, bool, T, T> // TypeDefIndex: 48684
	{
		// Constructors
		public SwitchValue() {}
	
		// Methods
		public override T Invoke(bool condition, T isTrue, T isFalse) => default;
	}

	public class PickValue<T> : PureFunctionNode<T, int, IList<T>> // TypeDefIndex: 48685
	{
		// Constructors
		public PickValue() {}
	
		// Methods
		public override T Invoke(int index, IList<T> values) => default;
	}

	public abstract class StaticCodeEventBase : EventNode // TypeDefIndex: 48686
	{
		// Fields
		protected string eventName; // 0xB0
		protected System.Type targetType; // 0xB8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018B485484-0x000000018B485514 
	
		// Constructors
		protected StaticCodeEventBase() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public void SetEvent(EventInfo e) {} // 0x000000018B4853F0-0x000000018B485484
		public override void OnGraphStarted() {} // 0x000000018B48533C-0x000000018B4853F0
	}

	public class StaticCodeEvent : StaticCodeEventBase // TypeDefIndex: 48687
	{
		// Fields
		private FlowOutput o; // 0xC0
		private Action pointer; // 0xC8
	
		// Constructors
		public StaticCodeEvent() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B485564-0x000000018B485614
		public override void OnGraphStoped() {} // 0x0000000189E9B338-0x0000000189E9B39C
		private void Call() {} // 0x000000018B485514-0x000000018B485564
		protected override void RegisterPorts() {} // 0x000000018B485614-0x000000018B48567C
	}

	public class StaticCodeEvent<T> : StaticCodeEventBase // TypeDefIndex: 48688
	{
		// Fields
		private FlowOutput o;
		private Action<T> pointer;
		private T eventValue;
	
		// Constructors
		public StaticCodeEvent() {}
	
		// Methods
		public override void OnGraphStarted() {}
		public override void OnGraphStoped() {}
		private void Call(T value) {}
		protected override void RegisterPorts() {}
		private T _RegisterPorts_b__6_0() => default;
	}

	public class FlowNestedBT : FlowNestedBase<BehaviourTree> // TypeDefIndex: 48689
	{
		// Constructors
		public FlowNestedBT() {} // 0x000000018B47F14C-0x000000018B47F188
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B47F034-0x000000018B47F108
		private NodeCanvas.Framework.Status _RegisterPorts_b__0_0() => default; // 0x000000018B47F108-0x000000018B47F14C
	}

	public class FlowNestedFSM : FlowNestedBase<FSM> // TypeDefIndex: 48690
	{
		// Constructors
		public FlowNestedFSM() {} // 0x000000018B47F408-0x000000018B47F444
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B47F2F0-0x000000018B47F3C4
		private IState _RegisterPorts_b__0_0() => default; // 0x000000018B47F3C4-0x000000018B47F408
	}

	public class FlowNestedDT : FlowNestedBase<DialogueTree> // TypeDefIndex: 48691
	{
		// Constructors
		public FlowNestedDT() {} // 0x000000018B47F2B4-0x000000018B47F2F0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018B47F188-0x000000018B47F25C
		private IDialogueActor _RegisterPorts_b__0_0() => default; // 0x000000018B47F25C-0x000000018B47F2B4
	}

	public class TaskAction : FlowNode, ITaskAssignable<ActionTask> // TypeDefIndex: 48693
	{
		// Fields
		private ActionTask _action; // 0xB0
		private FlowOutput onFinish; // 0xB8
		private Coroutine coroutine; // 0xC0
	
		// Properties
		public override string name { get => default; } // 0x000000018B485850-0x000000018B4858B0 
		public ActionTask action { get => default; set {} } // 0x000000018B48581C-0x000000018B485838 0x000000018B4858B0-0x000000018B485990
		NodeCanvas.Framework.Task ITaskAssignable.task { get => default; set {} } // 0x000000018B48573C-0x000000018B4857C8 0x0000000183055FD0-0x0000000183055FE0
	
		// Nested types
		private sealed class _DoUpdate_d__15 : IEnumerator<object> // TypeDefIndex: 48692
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TaskAction __4__this; // 0x20
			public Flow f; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018346D8F0-0x000000018346D900 
			object IEnumerator.Current { get => default; } // 0x000000018B485838-0x000000018B485850 
	
			// Constructors
			public _DoUpdate_d__15() {} // Dummy constructor
			public _DoUpdate_d__15(int __1__state) {} // 0x000000018B485A40-0x000000018B485A90
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018346D8F0-0x000000018346D900
			private bool MoveNext() => default; // 0x000000018B485A90-0x000000018B485AC8
			void IEnumerator.Reset() {} // 0x000000018B4857C8-0x000000018B48581C
		}
	
		// Constructors
		public TaskAction() {} // 0x000000018B485E34-0x000000018B485E80
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B485990-0x000000018B485A40
		public override void OnGraphStoped() {} // 0x0000000181378230-0x0000000181378240
		public override void OnGraphPaused() {} // 0x0000000185492010-0x0000000185492020
		protected override void RegisterPorts() {} // 0x000000018B485CF8-0x000000018B485E34
		private IEnumerator DoUpdate(Flow f) => default; // 0x0000000181377E40-0x0000000181377E50
		private void _RegisterPorts_b__14_0(Flow f) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class TaskCondition : FlowNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 48694
	{
		// Fields
		private ConditionTask _condition; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x000000018B485CA8-0x000000018B485CF8 
		public ConditionTask condition { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x0000000184784C70-0x0000000184784C90
		NodeCanvas.Framework.Task ITaskAssignable.task { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x000000018B485AC8-0x000000018B485B20
	
		// Constructors
		public TaskCondition() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B485B20-0x000000018B485B78
		public override void OnGraphStoped() {} // 0x000000018B485B78-0x000000018B485B94
		protected override void RegisterPorts() {} // 0x000000018B485B94-0x000000018B485C4C
		private bool _RegisterPorts_b__11_0() => default; // 0x000000018B485C4C-0x000000018B485CA8
	}
}

namespace FlowCanvas.Nodes.Legacy
{
	public abstract class ReflectedFieldNode // TypeDefIndex: 48695
	{
		// Constructors
		protected ReflectedFieldNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static ReflectedFieldNode Create(System.Reflection.FieldInfo field) => default; // 0x000000018B483F1C-0x000000018B483F58
		public abstract void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	public sealed class PureReflectedFieldNode : ReflectedFieldNode // TypeDefIndex: 48700
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48696
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018B4829C8-0x000000018B482E40
		}
	
		private sealed class __c__DisplayClass0_1 // TypeDefIndex: 48697
		{
			// Fields
			public object constantValue; // 0x10
	
			// Constructors
			public __c__DisplayClass0_1() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass0_2 // TypeDefIndex: 48698
		{
			// Fields
			public ValueInput instanceInput; // 0x10
			public __c__DisplayClass0_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass0_2() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal object _RegisterPorts_b__1() => default; // 0x000000018346D130-0x000000018346D140
		}
	
		private sealed class __c__DisplayClass0_3 // TypeDefIndex: 48699
		{
			// Fields
			public object instance; // 0x10
			public ValueInput instanceInput; // 0x18
			public ValueInput valueInput; // 0x20
			public FlowOutput flowOut; // 0x28
			public __c__DisplayClass0_0 CS___8__locals2; // 0x30
	
			// Constructors
			public __c__DisplayClass0_3() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal object _RegisterPorts_b__2() => default; // 0x000000018B485E94-0x000000018B485ED8
			internal void _RegisterPorts_b__3(Flow f) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public PureReflectedFieldNode() {} // 0x000000018B485ED8-0x000000018B485F98
	
		// Methods
		public override void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode) {} // 0x000000018346D130-0x000000018346D140
	}

	public abstract class ReflectedMethodNode // TypeDefIndex: 48703
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 48701
		{
			// Fields
			public ParameterInfo[] parameters; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _Create_b__0(ParameterInfo p) => default; // 0x000000018B4849C4-0x000000018B484B90
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48702
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__2_0; // 0x08
			public static Func<ParameterInfo, System.Type> __9__2_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B484CA0-0x000000018B48533C
			public __c() {} // 0x000000018B484B90-0x000000018B484CA0
	
			// Methods
			internal System.Type _TryCreateJit_b__2_0(ParameterInfo p) => default;
			internal System.Type _TryCreateJit_b__2_1(ParameterInfo p) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public ReflectedMethodNode() {} // 0x000000018B485F98-0x000000018B486010
	
		// Methods
		public static ReflectedMethodNode Create(MethodInfo method) => default; // 0x000000018B486504-0x000000018B486568
		private static ReflectedMethodNode TryCreateJit(MethodInfo method) => default; // 0x0000000185492010-0x0000000185492020
		public string GetName(MethodInfo method, int i) => default; // 0x0000000187AD0B74-0x0000000187AD0B8C
		public abstract void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options); // 0x0000000187AD0B74-0x0000000187AD0B8C
	}

	public sealed class PureReflectedMethodNode : ReflectedMethodNode // TypeDefIndex: 48707
	{
		// Fields
		private MethodInfo method; // 0x10
		private ValueInput instanceInput; // 0x18
		private List<ValueInput> inputs; // 0x20
		private List<ValueInput> paramsInputs; // 0x28
		private System.Type paramsArrayType; // 0x30
		private object[] args; // 0x38
		private object instance; // 0x40
		private object returnValue; // 0x48
	
		// Nested types
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 48704
		{
			// Fields
			public PureReflectedMethodNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018B4830A8-0x000000018B483820
	
			// Methods
			internal object _RegisterPorts_b__0() => default; // 0x000000018B482E40-0x000000018B4830A8
			internal object _RegisterPorts_b__1() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass8_1 // TypeDefIndex: 48705
		{
			// Fields
			public FlowOutput o; // 0x10
			public __c__DisplayClass8_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass8_1() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _RegisterPorts_b__2(Flow f) {} // 0x000000018B4863E0-0x000000018B4863FC
		}
	
		private sealed class __c__DisplayClass8_2 // TypeDefIndex: 48706
		{
			// Fields
			public int i; // 0x10
			public __c__DisplayClass8_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass8_2() {} // 0x000000018B4863FC-0x000000018B486434
	
			// Methods
			internal object _RegisterPorts_b__3() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public PureReflectedMethodNode() {} // 0x000000018B4864A0-0x000000018B486504
	
		// Methods
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {} // 0x000000018B486434-0x000000018B4864A0
		private object CallMethod() => default; // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ReflectedActionNode : ReflectedMethodNode // TypeDefIndex: 48709
	{
		// Fields
		private ActionCall call; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 48708
		{
			// Fields
			public ReflectedActionNode __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018B483820-0x000000018B483844
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {} // 0x000000018B483844-0x000000018B4839A8
		}
	
		// Constructors
		public ReflectedActionNode() {} // 0x000000018B486234-0x000000018B486298
	
		// Methods
		private void Call() {} // 0x0000000185492010-0x0000000185492020
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ReflectedActionNode<T1> : ReflectedMethodNode // TypeDefIndex: 48711
	{
		// Fields
		private ActionCall<T1> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48710
		{
			// Fields
			public ReflectedActionNode<T1> __4__this;
			public ValueInput<T1> p1;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2> : ReflectedMethodNode // TypeDefIndex: 48713
	{
		// Fields
		private ActionCall<T1, T2> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48712
		{
			// Fields
			public ReflectedActionNode<T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2, T3> : ReflectedMethodNode // TypeDefIndex: 48715
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48714
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2, T3, T4> : ReflectedMethodNode // TypeDefIndex: 48717
	{
		// Fields
		private ActionCall<T1, T2, T3, T4> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48716
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5> : ReflectedMethodNode // TypeDefIndex: 48719
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48718
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6> : ReflectedMethodNode // TypeDefIndex: 48721
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48720
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> : ReflectedMethodNode // TypeDefIndex: 48723
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48722
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : ReflectedMethodNode // TypeDefIndex: 48725
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7, T8> call;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48724
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f) {}
			internal T1 _RegisterPorts_b__1() => default;
		}
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<TResult> : ReflectedMethodNode // TypeDefIndex: 48728
	{
		// Fields
		private FunctionCall<TResult> call;
		private TResult returnValue;
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48726
		{
			// Fields
			public ReflectedFunctionNode<TResult> __4__this;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass3_1 // TypeDefIndex: 48727
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass3_0<TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass3_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call() => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, TResult> : ReflectedMethodNode // TypeDefIndex: 48731
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48729
		{
			// Fields
			public ReflectedFunctionNode<T1, TResult> __4__this;
			public ValueInput<T1> p1;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48730
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, TResult> : ReflectedMethodNode // TypeDefIndex: 48734
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48732
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48733
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, T3, TResult> : ReflectedMethodNode // TypeDefIndex: 48737
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48735
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48736
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, TResult> : ReflectedMethodNode // TypeDefIndex: 48740
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48738
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, T4, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48739
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> : ReflectedMethodNode // TypeDefIndex: 48743
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48741
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48742
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> : ReflectedMethodNode // TypeDefIndex: 48746
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48744
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48745
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, T6, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> : ReflectedMethodNode // TypeDefIndex: 48749
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48747
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48748
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, T6, T7, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ReflectedMethodNode // TypeDefIndex: 48752
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 48750
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
			public ValueInput<T6> p6;
			public ValueInput<T7> p7;
			public ValueInput<T8> p8;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal T1 _RegisterPorts_b__2() => default;
			internal TResult _RegisterPorts_b__0() => default;
		}
	
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 48751
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, T6, T7, T8, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1() {}
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f) {}
		}
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 48129
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 49458
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x000000018B4E3764-0x000000018B4E37C8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 49459
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018B4E380C-0x000000018B4E38A0
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018B4E37C8-0x000000018B4E380C
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 49460
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018B4E56BC-0x000000018B4E5720
		public static bool IsPatched(int id) => default; // 0x000000018B4E57AC-0x000000018B4E5844
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018B4E5578-0x000000018B4E5644
		public object CreateWrapper(int id) => default; // 0x000000018B4E5644-0x000000018B4E56BC
		public object InitWrapperArray(int len) => default; // 0x000000018B4E5720-0x000000018B4E57AC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018B4E54D4-0x000000018B4E5578
	}
}

namespace NodeCanvas
{
	public static class AssemblyWrapUtils // TypeDefIndex: 48768
	{
		// Fields
		public static bool disableProjectPanelSuffixValidate; // 0x00
		public static Func<bool> autoLockOpenBehaviourTree; // 0x08
		public static Func<bool> autoLockOpenStateMachine; // 0x10
		public static Func<bool> autoLockOpenDialogTree; // 0x18
		public static Func<bool> autoLockOpenSAGraph; // 0x20
		public static Func<bool> autoLockOpenLevelScript; // 0x28
		public static Func<bool> autoLockOpenLevelScriptModule; // 0x30
		public static Func<bool> autoLockOpenInteractiveConfig; // 0x38
		public static Func<bool> autoLockOpenMissionGraph; // 0x40
		public static Func<bool> autoLockOpenGuideGraph; // 0x48
	}

	public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 48769
	{
		// Fields
		public bool playOnAwake; // 0x18
		private string _serializedList; // 0x20
		private List<UnityEngine.Object> _objectReferences; // 0x28
		private NodeCanvas.Framework.Blackboard _blackboard; // 0x30
		[NonSerialized]
		private ActionList _actionList; // 0x38
		private float timeStarted; // 0x40
	
		// Properties
		public ActionList actionList { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public float elapsedTime { get => default; } // 0x000000018B47053C-0x000000018B470558 
		public float deltaTime { get => default; } // 0x000000018646ED20-0x000000018646ED28 
		UnityEngine.Object ITaskSystem.contextObject { get => default; } // 0x0000000185779060-0x0000000185779070 
		Component ITaskSystem.agent { get => default; } // 0x0000000185779060-0x0000000185779070 
		public IBlackboard blackboard { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x000000018B470558-0x000000018B4705CC
	
		// Constructors
		public ActionListPlayer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B470274-0x000000018B4703A0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B470170-0x000000018B470274
		public static ActionListPlayer Create() => default; // 0x000000018B46FFE8-0x000000018B470064
		protected void Awake() {} // 0x000000018B46FFBC-0x000000018B46FFE8
		public void UpdateTasksOwner() {} // 0x000000018B4703A0-0x000000018B47053C
		void ITaskSystem.SendEvent(string name, object value, object sender) {} // 0x0000000185492010-0x0000000185492020
		void ITaskSystem.SendEvent<T>(string name, T value, object sender) {}
		public void Play() {} // 0x000000018B47014C-0x000000018B470170
		public void Play(Action<NodeCanvas.Framework.Status> OnFinish) {} // 0x000000018B470128-0x000000018B47014C
		public void Play(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> OnFinish) {} // 0x000000018B4700B8-0x000000018B470128
		public NodeCanvas.Framework.Status Execute() => default; // 0x000000018B47008C-0x000000018B4700B8
		public NodeCanvas.Framework.Status Execute(Component agent) => default; // 0x000000018B470064-0x000000018B47008C
	}
}

namespace NodeCanvas.BehaviourTrees
{
	public class BehaviourTree : NodeCanvas.Framework.Graph // TypeDefIndex: 49074
	{
		// Fields
		[NonSerialized]
		public bool repeat; // 0xA0
		[NonSerialized]
		public float updateInterval; // 0xA4
		private static Action<BehaviourTree, NodeCanvas.Framework.Status> onRootStatusChanged; // 0x00
		private float intervalCounter; // 0xA8
		private NodeCanvas.Framework.Status _rootStatus; // 0xAC
	
		// Properties
		public NodeCanvas.Framework.Status rootStatus { get => default; private set {} } // 0x000000018B49DC34-0x000000018B49DCA0 0x000000018B49DB48-0x000000018B49DB98
		public override System.Type baseNodeType { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool requiresAgent { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool requiresPrimeNode { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool isTree { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool allowBlackboardOverrides { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public sealed override bool canAcceptVariableDrops { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018B49D8E8-0x000000018B49D924 
	
		// Events
		public static event Action<BehaviourTree, NodeCanvas.Framework.Status> onRootStatusChanged;
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 49073
		{
			// Fields
			public bool repeat; // 0x10
			public float updateInterval; // 0x14
	
			// Constructors
			public DerivedSerializationData() {} // 0x000000018B49D888-0x000000018B49D8E8
		}
	
		// Constructors
		public BehaviourTree() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override object OnDerivedDataSerialization() => default; // 0x000000018B49D7DC-0x000000018B49D888
		public override void OnDerivedDataDeserialization(object data) {} // 0x000000018B49DAAC-0x000000018B49DB48
		protected override void OnGraphStarted() {} // 0x000000018B49D924-0x000000018B49D9CC
		protected override void OnGraphUpdate() {} // 0x000000018B49D9CC-0x000000018B49DA50
		private NodeCanvas.Framework.Status Tick(Component agent, IBlackboard blackboard) => default; // 0x000000018B49DA50-0x000000018B49DAAC
	}

	public class BehaviourTreeOwner : GraphOwner<BehaviourTree> // TypeDefIndex: 49075
	{
		// Properties
		public bool repeat { get => default; set {} } // 0x000000018B49D4D8-0x000000018B49D56C 0x000000018B49D69C-0x000000018B49D73C
		public float updateInterval { get => default; set {} } // 0x000000018B49D604-0x000000018B49D69C 0x000000018B49D73C-0x000000018B49D7DC
		public NodeCanvas.Framework.Status rootStatus { get => default; } // 0x000000018B49D56C-0x000000018B49D604 
	
		// Constructors
		public BehaviourTreeOwner() {} // 0x000000018B49D4A4-0x000000018B49D4D8
	
		// Methods
		public NodeCanvas.Framework.Status Tick() => default; // 0x000000018B49D404-0x000000018B49D4A4
	}

	public class BTConnection : Connection // TypeDefIndex: 49076
	{
		// Constructors
		public BTConnection() {} // 0x0000000185FBE310-0x0000000185FBE320
	}

	public abstract class BTNode : NodeCanvas.Framework.Node // TypeDefIndex: 49077
	{
		// Properties
		public sealed override System.Type outConnectionType { get; } // 0x000000018B49D3B4-0x000000018B49D404 
		public sealed override bool allowAsPrime { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public sealed override bool canSelfConnect { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000181C44E90-0x0000000181C44EA0 
		public override Alignment2x2 iconAlignment { get; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxInConnections { get; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		public override int maxOutConnections { get; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		protected BTNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public T AddChild<T>(int childIndex)
			where T : BTNode => default;
		public T AddChild<T>()
			where T : BTNode => default;
	}

	public abstract class BTNodeNested<T> : BTNode, IGraphAssignable<T> // TypeDefIndex: 49078
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		private List<BBMappingParameter> _variablesMap;
		private T _currentInstance_k__BackingField;
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { get; set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected BTNodeNested() {}
	}

	public abstract class BTComposite : BTNode // TypeDefIndex: 49079
	{
		// Properties
		public override string name { get; } // 0x000000018B49C8E4-0x000000018B49C908 
		public sealed override int maxOutConnections { get; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000181C6A970-0x0000000181C6A980 
	
		// Constructors
		protected BTComposite() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public abstract class BTDecorator : BTNode // TypeDefIndex: 49080
	{
		// Properties
		public sealed override int maxOutConnections { get; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000181C6A970-0x0000000181C6A980 
		protected Connection decoratedConnection { get; } // 0x000000018B49D0AC-0x000000018B49D110 
		protected NodeCanvas.Framework.Node decoratedNode { get; } // 0x000000018B49D110-0x000000018B49D12C 
	
		// Constructors
		protected BTDecorator() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 49081
	{
		// Fields
		public bool dynamic; // 0x98
		private ConditionTask _condition; // 0xA0
		private int succeedIndex; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override Alignment2x2 commentsAlignment { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018B49DDFC-0x000000018B49DE54
		private ConditionTask condition { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
	
		// Constructors
		public BinarySelector() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49DCA0-0x000000018B49DDE0
		protected override void OnReset() {} // 0x000000018B49DDE0-0x000000018B49DDFC
	}

	public class FlipSelector : BTComposite // TypeDefIndex: 49082
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public FlipSelector() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4A3904-0x000000018B4A39E4
		private void SendToBack(int i) {} // 0x000000018B4A39E4-0x000000018B4A3A8C
		protected override void OnReset() {} // 0x0000000185FD2B10-0x0000000185FD2B20
	}

	public class Parallel : BTComposite // TypeDefIndex: 49084
	{
		// Fields
		public ParallelPolicy policy; // 0x98
		public bool dynamic; // 0x9C
		private bool[] finishedConnections; // 0xA0
		private int finishedConnectionsCount; // 0xA8
	
		// Nested types
		public enum ParallelPolicy // TypeDefIndex: 49083
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}
	
		// Constructors
		public Parallel() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B4ADB50-0x000000018B4ADBC0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AD96C-0x000000018B4ADB50
		protected override void OnReset() {} // 0x000000018B4ADBC0-0x000000018B4ADC04
		private void ResetRunning() {} // 0x000000018B4ADC04-0x000000018B4ADCA4
	}

	internal class PrioritySelector_0 : BTComposite // TypeDefIndex: 49085
	{
		// Fields
		public List<BBParameter<float>> priorities; // 0x98
	
		// Constructors
		public PrioritySelector_0() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public class PrioritySelector : BTComposite, IMigratable<PrioritySelector_0> // TypeDefIndex: 49088
	{
		// Fields
		public List<Desire> desires; // 0x98
		private Connection[] orderedConnections; // 0xA0
		private int current; // 0xA8
	
		// Nested types
		[Serializable]
		public class Desire // TypeDefIndex: 49086
		{
			// Fields
			public string name; // 0x10
			public bool foldout; // 0x18
			public List<Consideration> considerations; // 0x20
	
			// Constructors
			public Desire() {} // 0x000000018B4ADE18-0x000000018B4ADF84
	
			// Methods
			public Consideration AddConsideration(IBlackboard bb) => default; // 0x000000018B4ADF84-0x000000018B4AE1DC
			public void RemoveConsideration(Consideration consideration) {} // 0x000000018B4ADCA4-0x000000018B4ADDC0
			public float GetCompoundUtility() => default; // 0x000000018B4ADDC0-0x000000018B4ADE18
		}
	
		[Serializable]
		public class Consideration // TypeDefIndex: 49087
		{
			// Fields
			public BBParameter<float> input; // 0x10
			public BBParameter<AnimationCurve> function; // 0x18
	
			// Properties
			public float utility { get => default; } // 0x0000000185FD2B30-0x0000000185FD2B40 
	
			// Constructors
			public Consideration() {} // Dummy constructor
			public Consideration(IBlackboard blackboard) {} // 0x0000000183055FD0-0x0000000183055FE0
		}
	
		// Constructors
		public PrioritySelector() {} // 0x000000018B49F4E4-0x000000018B49F59C
	
		// Methods
		void IMigratable<PrioritySelector_0>.Migrate(PrioritySelector_0 model) {} // 0x000000018B4AE1DC-0x000000018B4AE274
		public override void OnChildConnected(int index) {} // 0x000000018B49FB58-0x000000018B49FBE8
		public override void OnChildDisconnected(int index) {} // 0x000000018B49FC88-0x000000018B49FCDC
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49FBE8-0x000000018B49FC88
		protected override void OnReset() {} // 0x000000018B49FCDC-0x000000018B49FD54
		private float _OnExecute_b__8_0(Connection c) => default; // 0x000000018B49F3F8-0x000000018B49F4E4
	}

	public class ProbabilitySelector : BTComposite // TypeDefIndex: 49089
	{
		// Fields
		public List<BBParameter<float>> childWeights; // 0x98
		public BBParameter<float> failChance; // 0xA0
		private bool[] indexFailed; // 0xA8
		private float[] tmpWeights; // 0xB0
		private float tmpFailWeight; // 0xB8
		private float tmpTotal; // 0xBC
		private float tmpDice; // 0xC0
	
		// Constructors
		public ProbabilitySelector() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnChildConnected(int index) {} // 0x000000018B4AE43C-0x000000018B4AE5A4
		public override void OnChildDisconnected(int index) {} // 0x000000018B4AE5FC-0x000000018B4AE654
		public override void OnGraphStarted() {} // 0x000000018B4AEB54-0x000000018B4AEB64
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AE654-0x000000018B4AE8DC
		protected override void OnReset() {} // 0x000000018B4AEB64-0x000000018B4AEC04
	}

	public class Selector : BTComposite // TypeDefIndex: 49090
	{
		// Fields
		public bool dynamic; // 0x98
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Selector() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AEFA0-0x000000018B4AF120
		protected override void OnReset() {} // 0x000000018B4AF120-0x000000018B4AF178
		public override void OnChildDisconnected(int index) {} // 0x000000018B4AEF8C-0x000000018B4AEFA0
		public override void OnGraphStarted() {} // 0x000000018B4AEB54-0x000000018B4AEB64
	}

	public class Sequencer : BTComposite // TypeDefIndex: 49091
	{
		// Fields
		public bool dynamic; // 0x98
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Sequencer() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AF178-0x000000018B4AF2F8
		protected override void OnReset() {} // 0x000000018B4AF2F8-0x000000018B4AF350
		public override void OnChildDisconnected(int index) {} // 0x000000018B4AEF8C-0x000000018B4AEFA0
		public override void OnGraphStarted() {} // 0x000000018B4AEB54-0x000000018B4AEB64
	}

	public class StepIterator : BTComposite // TypeDefIndex: 49092
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public StepIterator() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000185FD2B10-0x0000000185FD2B20
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AFCB8-0x000000018B4AFD50
		protected override void OnReset() {} // 0x0000000185FD2B50-0x0000000185FD2B60
	}

	public class Switch : BTComposite // TypeDefIndex: 49095
	{
		// Fields
		public bool dynamic; // 0x98
		public CaseSelectionMode selectionMode; // 0x9C
		public BBParameter<int> intCase; // 0xA0
		public OutOfRangeMode outOfRangeMode; // 0xA8
		public BBObjectParameter enumCase; // 0xB0
		private Dictionary<int, int> enumCasePairing; // 0xB8
		private int current; // 0xC0
		private int runningIndex; // 0xC4
	
		// Nested types
		public enum CaseSelectionMode // TypeDefIndex: 49093
		{
			IndexBased = 0,
			EnumBased = 1
		}
	
		public enum OutOfRangeMode // TypeDefIndex: 49094
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}
	
		// Constructors
		public Switch() {} // 0x000000018B4B0CB0-0x000000018B4B0D74
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B4B0B2C-0x000000018B4B0CB0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4B08FC-0x000000018B4B0B2C
	}

	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 49096
	{
		// Fields
		public bool isDynamic; // 0x98
		public CompactStatus conditionFailReturn; // 0x9C
		private ConditionTask _condition; // 0xA0
		private bool accessed; // 0xA8
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018B49EA34-0x000000018B49EA8C
		private ConditionTask condition { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
	
		// Constructors
		public ConditionalEvaluator() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49E8F4-0x000000018B49E9FC
		protected override void OnReset() {} // 0x000000018B49E9FC-0x000000018B49EA34
	}

	public class Filter : BTDecorator // TypeDefIndex: 49100
	{
		// Fields
		public FilterMode filterMode; // 0x98
		public BBParameter<int> maxCount; // 0xA0
		public Policy policy; // 0xA8
		public BBParameter<float> coolDownTime; // 0xB0
		public bool inactiveWhenLimited; // 0xB8
		private int executedCount; // 0xBC
		private float currentTime; // 0xC0
		private float targetTime; // 0xC4
	
		// Nested types
		public enum FilterMode // TypeDefIndex: 49097
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}
	
		public enum Policy // TypeDefIndex: 49098
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}
	
		private sealed class _Cooldown_d__13 : IEnumerator<object> // TypeDefIndex: 49099
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Filter __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4A35BC-0x000000018B4A3618 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public _Cooldown_d__13() {} // Dummy constructor
			public _Cooldown_d__13(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4A3618-0x000000018B4A3808
			private bool MoveNext() => default; // 0x0000000185FD2B00-0x0000000185FD2B10
			void IEnumerator.Reset() {} // 0x000000018B4A3808-0x000000018B4A38A4
		}
	
		// Constructors
		public Filter() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override void OnGraphStoped() {} // 0x0000000185492010-0x0000000185492020
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4B0F68-0x000000018B4B102C
		public override void OnClearNodeData() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator Cooldown() => default; // 0x000000018B4B102C-0x000000018B4B1078
	}

	public class Guard : BTDecorator // TypeDefIndex: 49102
	{
		// Fields
		public BBParameter<string> token; // 0x98
		public GuardMode ifGuarded; // 0xA0
		private bool isGuarding; // 0xA4
		private static readonly Dictionary<GameObject, List<Guard>> guards; // 0x00
	
		// Nested types
		public enum GuardMode // TypeDefIndex: 49101
		{
			ReturnFailure = 0,
			WaitUntilReleased = 1
		}
	
		// Constructors
		public Guard() {} // 0x0000000183055FD0-0x0000000183055FE0
		static Guard() {} // 0x000000018B4AA93C-0x000000018B4AA9C8
	
		// Methods
		private static List<Guard> AgentGuards(Component agent) => default; // 0x000000018B4AA1EC-0x000000018B4AA274
		public override void OnGraphStarted() {} // 0x000000018B4AA478-0x000000018B4AA49C
		public override void OnGraphStoped() {} // 0x000000018B4AA49C-0x000000018B4AA748
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AA274-0x000000018B4AA478
		protected override void OnReset() {} // 0x0000000185FD2B20-0x0000000185FD2B30
		private void SetGuards(Component guardAgent) {} // 0x000000018B4AA748-0x000000018B4AA93C
	}

	public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 49103
	{
		// Fields
		private ConditionTask _condition; // 0x98
	
		// Properties
		public ConditionTask condition { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x000000018B4AAAAC-0x000000018B4AAB04
	
		// Constructors
		public Interruptor() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AA9C8-0x000000018B4AAAAC
		protected override void OnReset() {} // 0x000000018B49E828-0x000000018B49E844
	}

	public class Inverter : BTDecorator // TypeDefIndex: 49104
	{
		// Constructors
		public Inverter() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AAB04-0x000000018B4AAB8C
	}

	public class Iterator : BTDecorator // TypeDefIndex: 49106
	{
		// Fields
		public BBParameter<IList> targetList; // 0x98
		public BBObjectParameter current; // 0xA0
		public BBParameter<int> storeIndex; // 0xA8
		public TerminationConditions terminationCondition; // 0xB0
		public BBParameter<int> maxIteration; // 0xB8
		public bool resetIndex; // 0xC0
		private int currentIndex; // 0xC4
	
		// Properties
		private IList list { get => default; } // 0x000000018B4AB01C-0x000000018B4AB06C 
	
		// Nested types
		public enum TerminationConditions // TypeDefIndex: 49105
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}
	
		// Constructors
		public Iterator() {} // 0x000000018B4AAFBC-0x000000018B4AB01C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AAD50-0x000000018B4AAFA8
		protected override void OnReset() {} // 0x000000018B4AAFA8-0x000000018B4AAFBC
	}

	public class Merge : BTDecorator // TypeDefIndex: 49107
	{
		// Properties
		public override int maxInConnections { get => default; } // 0x0000000185FBE2F0-0x0000000185FBE300 
	
		// Constructors
		public Merge() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AB148-0x000000018B4AB1B4
	}

	public class Monitor : BTDecorator, ITaskAssignable<ActionTask> // TypeDefIndex: 49110
	{
		// Fields
		public MonitorMode monitorMode; // 0x98
		public ReturnStatusMode returnMode; // 0x9C
		private NodeCanvas.Framework.Status decoratorActionStatus; // 0xA0
		private ActionTask _action; // 0xA8
	
		// Properties
		public ActionTask action { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018774BD8C-0x000000018774BDA0
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018B4AB2E8-0x000000018B4AB340
	
		// Nested types
		public enum MonitorMode // TypeDefIndex: 49108
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}
	
		public enum ReturnStatusMode // TypeDefIndex: 49109
		{
			OriginalDecoratedChildStatus = 0,
			NewDecoratorActionStatus = 1
		}
	
		// Constructors
		public Monitor() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AB1B4-0x000000018B4AB2B4
		protected override void OnReset() {} // 0x000000018B4AB2B4-0x000000018B4AB2E8
	}

	public class Optional : BTDecorator // TypeDefIndex: 49111
	{
		// Constructors
		public Optional() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AD8D4-0x000000018B4AD96C
	}

	public class Remapper : BTDecorator // TypeDefIndex: 49113
	{
		// Fields
		public RemapStatus successRemap; // 0x98
		public RemapStatus failureRemap; // 0x9C
	
		// Nested types
		public enum RemapStatus // TypeDefIndex: 49112
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Remapper() {} // 0x000000018B4AED1C-0x000000018B4AED30
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AEC8C-0x000000018B4AED1C
	}

	public class Repeater : BTDecorator // TypeDefIndex: 49116
	{
		// Fields
		public RepeaterMode repeaterMode; // 0x98
		public BBParameter<int> repeatTimes; // 0xA0
		public RepeatUntilStatus repeatUntilStatus; // 0xA8
		private int currentIteration; // 0xAC
	
		// Nested types
		public enum RepeaterMode // TypeDefIndex: 49114
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}
	
		public enum RepeatUntilStatus // TypeDefIndex: 49115
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Repeater() {} // 0x000000018B4AEE54-0x000000018B4AEEC0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AED30-0x000000018B4AEE54
		protected override void OnReset() {} // 0x0000000185FD2B40-0x0000000185FD2B50
	}

	public class Setter : BTDecorator // TypeDefIndex: 49117
	{
		// Fields
		public bool revertToOriginal; // 0x98
		public BBParameter<GameObject> newAgent; // 0xA0
	
		// Constructors
		public Setter() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AF350-0x000000018B4AF40C
	}

	public class Timeout : BTDecorator // TypeDefIndex: 49118
	{
		// Fields
		public BBParameter<float> timeout; // 0x98
	
		// Constructors
		public Timeout() {} // 0x000000018B4B0E64-0x000000018B4B0EC0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4B0D74-0x000000018B4B0E64
	}

	public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 49119
	{
		// Fields
		private ConditionTask _condition; // 0x98
		private bool accessed; // 0xA0
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x000000018B4B215C-0x000000018B4B2764
		private ConditionTask condition { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
	
		// Constructors
		public WaitUntil() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4B2028-0x000000018B4B2124
		protected override void OnReset() {} // 0x000000018B4B2124-0x000000018B4B215C
	}

	public class ActionNode : BTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 49120
	{
		// Fields
		private ActionTask _action; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x000000018B49C908-0x000000018B49C960
		public ActionTask action { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
	
		// Constructors
		public ActionNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49C740-0x000000018B49C770
		protected override void OnReset() {} // 0x000000018B49C854-0x000000018B49C870
		public override void OnGraphPaused() {} // 0x000000018B49C81C-0x000000018B49C838
	}

	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 49121
	{
		// Fields
		private ConditionTask _condition; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x000000018B49E844-0x000000018B49E89C
		public ConditionTask condition { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
	
		// Constructors
		public ConditionNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49E698-0x000000018B49E71C
		protected override void OnReset() {} // 0x000000018B49E828-0x000000018B49E844
	}

	public class NestedDT : BTNodeNested<DialogueTree> // TypeDefIndex: 49122
	{
		// Fields
		private BBParameter<DialogueTree> _nestedDialogueTree; // 0xB0
	
		// Properties
		public override DialogueTree subGraph { get => default; set {} } // 0x000000018B4AC50C-0x000000018B4AC554 0x000000018B4AC554-0x000000018B4AC5AC
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public NestedDT() {} // 0x000000018B4AC4D8-0x000000018B4AC50C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AC310-0x000000018B4AC458
		private void OnDLGFinished(bool success) {} // 0x000000018B49D24C-0x000000018B49D260
		protected override void OnReset() {} // 0x000000018B4AC458-0x000000018B4AC4D8
	}

	public class NestedFSM : BTNodeNested<FSM> // TypeDefIndex: 49123
	{
		// Fields
		private BBParameter<FSM> _nestedFSM; // 0xB0
		public string successState; // 0xB8
		public string failureState; // 0xC0
	
		// Properties
		public override FSM subGraph { get => default; set {} } // 0x000000018B4ACAF4-0x000000018B4ACB3C 0x000000018B4ACB3C-0x000000018B4ACB94
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public NestedFSM() {} // 0x000000018B4ACAC0-0x000000018B4ACAF4
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AC864-0x000000018B4ACA40
		private void OnFSMFinish(bool success) {} // 0x000000018B49D24C-0x000000018B49D260
		protected override void OnReset() {} // 0x000000018B4ACA40-0x000000018B4ACAC0
	}

	public class SubTree : BTNodeNested<BehaviourTree> // TypeDefIndex: 49124
	{
		// Fields
		private BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override BehaviourTree subGraph { get => default; set {} } // 0x000000018B4B0498-0x000000018B4B04E0 0x000000018B4B04E0-0x000000018B4B0538
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public SubTree() {} // 0x000000018B4B0464-0x000000018B4B0498
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4B02E8-0x000000018B4B03E4
		protected override void OnReset() {} // 0x000000018B4B03E4-0x000000018B4B0464
	}

	public class NodeToggler : BTNode // TypeDefIndex: 49126
	{
		// Fields
		public ToggleMode toggleMode; // 0x98
		public string targetNodeTag; // 0xA0
		private List<NodeCanvas.Framework.Node> targetNodes; // 0xA8
	
		// Nested types
		public enum ToggleMode // TypeDefIndex: 49125
		{
			Enable = 0,
			Disable = 1,
			Toggle = 2
		}
	
		// Constructors
		public NodeToggler() {} // 0x000000018B4AD034-0x000000018B4AD048
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B4ACFB8-0x000000018B4AD034
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4ACB94-0x000000018B4ACFB8
	}

	public class RootSwitcher : BTNode // TypeDefIndex: 49127
	{
		// Fields
		public string targetNodeTag; // 0x98
		private NodeCanvas.Framework.Node targetNode; // 0xA0
	
		// Constructors
		public RootSwitcher() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B4AEF2C-0x000000018B4AEF8C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AEEC0-0x000000018B4AEF2C
	}

	public class BTNestedFlowScript : BTNodeNested<FlowScript> // TypeDefIndex: 49128
	{
		// Fields
		private BBParameter<FlowScript> _flowScript; // 0xB0
	
		// Properties
		public override FlowScript subGraph { get => default; set {} } // 0x000000018B49D314-0x000000018B49D35C 0x000000018B49D35C-0x000000018B49D3B4
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public BTNestedFlowScript() {} // 0x000000018B49D2E0-0x000000018B49D314
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49D12C-0x000000018B49D24C
		private void OnFlowScriptFinished(bool success) {} // 0x000000018B49D24C-0x000000018B49D260
		protected override void OnReset() {} // 0x000000018B49D260-0x000000018B49D2E0
	}
}

namespace NodeCanvas.DialogueTrees
{
	public class DialogueActor : MonoBehaviour, IDialogueActor // TypeDefIndex: 49028
	{
		// Fields
		protected string _name; // 0x18
		protected Texture2D _portrait; // 0x20
		protected UnityEngine.Color _dialogueColor; // 0x28
		protected Vector3 _dialogueOffset; // 0x38
		private Sprite _portraitSprite; // 0x48
	
		// Properties
		public new string name { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public Texture2D portrait { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Sprite portraitSprite { get => default; } // 0x000000018B49FDBC-0x000000018B49FEDC 
		public UnityEngine.Color dialogueColor { get => default; } // 0x0000000185FBB610-0x0000000185FBB620 
		public Vector3 dialoguePosition { get => default; } // 0x000000018B49FD54-0x000000018B49FDBC 
		Transform IDialogueActor.transform { get => default; } // 0x000000018646DBCC-0x000000018646DBD4 
	
		// Constructors
		public DialogueActor() {} // 0x000000018B4415D0-0x000000018B4415F8
	}

	public class SubtitlesRequestInfo // TypeDefIndex: 49029
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public IStatement statement; // 0x18
		public Action Continue; // 0x20
	
		// Constructors
		public SubtitlesRequestInfo() {} // Dummy constructor
		public SubtitlesRequestInfo(IDialogueActor actor, IStatement statement, Action callback) {} // 0x000000018496F6A0-0x000000018496F6E0
	}

	public class MultipleChoiceRequestInfo // TypeDefIndex: 49030
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public Dictionary<IStatement, int> options; // 0x18
		public float availableTime; // 0x20
		public bool showLastStatement; // 0x24
		public Action<int> SelectOption; // 0x28
	
		// Constructors
		public MultipleChoiceRequestInfo() {} // Dummy constructor
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback) {} // 0x000000018B4AB8C8-0x000000018B4AB910
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, Action<int> callback) {} // 0x000000018B4AB888-0x000000018B4AB8C8
	}

	public class DialogueTree : NodeCanvas.Framework.Graph // TypeDefIndex: 49039
	{
		// Fields
		public const string INSTIGATOR_NAME = "SELF"; // Metadata: 0x02060D99
		public List<ActorParameter> actorParameters; // 0xA0
		private static Action<DialogueTree> OnDialogueStarted; // 0x00
		private static Action<DialogueTree> OnDialoguePaused; // 0x08
		private static Action<DialogueTree> OnDialogueFinished; // 0x10
		private static Action<SubtitlesRequestInfo> OnSubtitlesRequest; // 0x18
		private static Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest; // 0x20
		private static DialogueTree _currentDialogue_k__BackingField; // 0x28
		private static DialogueTree _previousDialogue_k__BackingField; // 0x30
		private DTNode _currentNode_k__BackingField; // 0xA8
	
		// Properties
		public static DialogueTree currentDialogue { get; private set; } // 0x000000018B4A0C84-0x000000018B4A0CD4 0x000000018B4A09CC-0x000000018B4A0ABC
		public static DialogueTree previousDialogue { get; private set; } // 0x000000018B4A0C08-0x000000018B4A0C84 0x000000018B4A0ABC-0x000000018B4A0B5C
		public DTNode currentNode { get; private set; } // 0x000000018B4A097C-0x000000018B4A09CC 0x000000018B4A0B5C-0x000000018B4A0C08
		public override System.Type baseNodeType { get => default; } // 0x000000018B4A105C-0x000000018B4A10FC 
		public override bool requiresAgent { get => default; } // 0x0000000185492010-0x0000000185492020 
		public override bool requiresPrimeNode { get => default; } // 0x000000018346D130-0x000000018346D140 
		public override bool isTree { get => default; } // 0x0000000184096E30-0x0000000184096EF0 
		public override bool allowBlackboardOverrides { get => default; } // 0x000000018B49CBD4-0x000000018B49CC30 
		public sealed override bool canAcceptVariableDrops { get => default; } // 0x000000018B49CC30-0x000000018B49CCA0 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018B49CCA0-0x000000018B49CD10 
		public List<string> definedActorParameterNames { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Events
		public static event Action<DialogueTree> OnDialogueStarted;
		public static event Action<DialogueTree> OnDialoguePaused;
		public static event Action<DialogueTree> OnDialogueFinished;
		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest;
		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest;
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 49031
		{
			// Fields
			public List<ActorParameter> actorParameters; // 0x10
	
			// Constructors
			public DerivedSerializationData() {} // 0x000000018B4A0920-0x000000018B4A097C
		}
	
		[Serializable]
		public class ActorParameter // TypeDefIndex: 49032
		{
			// Fields
			private string _keyName; // 0x10
			private string _id; // 0x18
			private UnityEngine.Object _actorObject; // 0x20
			[NonSerialized]
			private IDialogueActor _actor; // 0x28
	
			// Properties
			public string name { get => default; set {} } // 0x000000018B4A0894-0x000000018B4A0920 0x000000018B4A1244-0x000000018B4A12E0
			public string ID { get => default; } // 0x000000018B4A1798-0x000000018B4A1834 
			public IDialogueActor actor { get => default; set {} } // 0x000000018B4A11A0-0x000000018B4A1244 0x000000018B4A16F4-0x000000018B4A1798
	
			// Constructors
			public ActorParameter() {} // 0x000000018B4A10FC-0x000000018B4A11A0
			public ActorParameter(string name) {} // 0x000000018B4A1650-0x000000018B4A16F4
			public ActorParameter(string name, IDialogueActor actor) {} // 0x000000018B4A1384-0x000000018B4A1428
	
			// Methods
			public override string ToString() => default; // 0x000000018B4A18D8-0x000000018B4A197C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49033
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ActorParameter, string> __9__48_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4A12E0-0x000000018B4A1384
			public __c() {} // 0x000000018B4A1834-0x000000018B4A18D8
	
			// Methods
			internal string _get_definedActorParameterNames_b__48_0(ActorParameter r) => default; // 0x000000018B4A1478-0x000000018B4A14B0
		}
	
		private sealed class __c__DisplayClass49_0 // TypeDefIndex: 49034
		{
			// Fields
			public string id; // 0x10
	
			// Constructors
			public __c__DisplayClass49_0() {} // 0x000000018B4A197C-0x000000018B4A19D0
	
			// Methods
			internal bool _GetParameterByID_b__0(ActorParameter p) => default; // 0x000000018B4A1618-0x000000018B4A1650
		}
	
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 49035
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0() {} // 0x000000018B4A19D0-0x000000018B4A1A24
	
			// Methods
			internal bool _GetParameterByName_b__0(ActorParameter p) => default; // 0x000000018349D730-0x000000018349D740
		}
	
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 49036
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0() {} // 0x000000018774BD8C-0x000000018774BDA0
	
			// Methods
			internal bool _GetActorReferenceByName_b__0(ActorParameter r) => default; // 0x000000018B4A1428-0x000000018B4A1478
		}
	
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 49037
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0() {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			internal bool _SetActorReference_b__0(ActorParameter p) => default; // 0x00000001840A27C0-0x00000001840A27D0
		}
	
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 49038
		{
			// Fields
			public KeyValuePair<string, IDialogueActor> pair; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0() {} // 0x00000001840A27C0-0x00000001840A27D0
	
			// Methods
			internal bool _SetActorReferences_b__0(ActorParameter p) => default; // 0x00000001840A27C0-0x00000001840A27D0
		}
	
		// Constructors
		public DialogueTree() {} // 0x000000018B4B1E44-0x000000018B4B1E98
	
		// Methods
		public override object OnDerivedDataSerialization() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override void OnDerivedDataDeserialization(object data) {} // 0x00000001814A81B0-0x00000001814A81C0
		public ActorParameter GetParameterByID(string id) => default; // 0x0000000184096E30-0x0000000184096EF0
		public ActorParameter GetParameterByName(string paramName) => default; // 0x000000018B49CBA8-0x000000018B49CBD4
		public IDialogueActor GetActorReferenceByID(string id) => default; // 0x000000018346D130-0x000000018346D140
		public IDialogueActor GetActorReferenceByName(string paramName) => default; // 0x000000018B4B1ED0-0x000000018B4B1F34
		public void SetActorReference(string paramName, IDialogueActor actor) {} // 0x0000000185492010-0x0000000185492020
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors) {} // 0x0000000187AD0B8C-0x0000000187AD0BA4
		public void Continue(int index = 0 /* Metadata: 0x02060D98 */) {} // 0x0000000185492010-0x0000000185492020
		public void EnterNode(DTNode node) {} // 0x000000018B4B1E0C-0x000000018B4B1E44
		public static void RequestSubtitles(SubtitlesRequestInfo info) {} // 0x0000000185492010-0x0000000185492020
		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info) {} // 0x0000000187C26954-0x0000000187C2697C
		protected override void OnGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnGraphUpdate() {} // 0x0000000187C26954-0x0000000187C2697C
		protected override void OnGraphStoped() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnGraphPaused() {} // 0x0000000187C26954-0x0000000187C2697C
		protected override void OnGraphUnpaused() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor // TypeDefIndex: 49040
	{
		// Properties
		string IDialogueActor.name { get => default; } // 0x00000001864746E4-0x00000001864746EC 
		Texture2D IDialogueActor.portrait { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		Sprite IDialogueActor.portraitSprite { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		UnityEngine.Color IDialogueActor.dialogueColor { get => default; } // 0x00000001880C4FCC-0x00000001880C4FEC 
		Vector3 IDialogueActor.dialoguePosition { get => default; } // 0x0000000186472A7C-0x0000000186472A94 
		Transform IDialogueActor.transform { get => default; } // 0x000000018646DBCC-0x000000018646DBD4 
	
		// Constructors
		public DialogueTreeController() {} // 0x000000018B4A029C-0x000000018B4A02D0
	
		// Methods
		public void StartDialogue() {} // 0x000000018B4A0108-0x000000018B4A0118
		public void StartDialogue(Action<bool> callback) {} // 0x000000018B4A0250-0x000000018B4A0260
		public void StartDialogue(IDialogueActor instigator) {} // 0x000000018B4A0260-0x000000018B4A026C
		public void StartDialogue(DialogueTree newTree, IDialogueActor instigator, Action<bool> callback) {} // 0x000000018B4A0118-0x000000018B4A0160
		public void StartDialogue(IDialogueActor instigator, Action<bool> callback) {} // 0x000000018B4A0160-0x000000018B4A0250
		public void PauseDialogue() {} // 0x000000018B49FF84-0x000000018B49FFB0
		public void StopDialogue() {} // 0x000000018B4A026C-0x000000018B4A029C
		public void SetActorReference(string paramName, IDialogueActor actor) {} // 0x000000018B49FFB0-0x000000018B4A0064
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors) {} // 0x000000018B4A0064-0x000000018B4A0108
		public IDialogueActor GetActorReferenceByName(string paramName) => default; // 0x000000018B49FEDC-0x000000018B49FF84
	}

	public class DTConnection : Connection // TypeDefIndex: 49041
	{
		// Constructors
		public DTConnection() {} // 0x0000000185FBE310-0x0000000185FBE320
	}

	public abstract class DTNode : NodeCanvas.Framework.Node // TypeDefIndex: 49042
	{
		// Fields
		private string _actorName; // 0x98
		private string _actorParameterID; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018B49F990-0x000000018B49FA68 
		public virtual bool requireActorSelection { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override int maxInConnections { get; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public override int maxOutConnections { get; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		public sealed override System.Type outConnectionType { get; } // 0x000000018B49FA68-0x000000018B49FAB8 
		public sealed override bool allowAsPrime { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public sealed override bool canSelfConnect { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000181C6A970-0x0000000181C6A980 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x0000000181C44E90-0x0000000181C44EA0 
		protected DialogueTree DLGTree { get; } // 0x000000018B49F8B0-0x000000018B49F8EC 
		public string actorName { get; private set; } // 0x000000018B49F8EC-0x000000018B49F934 0x000000018B49FAB8-0x000000018B49FB58
		public IDialogueActor finalActor { get; } // 0x000000018B49F934-0x000000018B49F990 
	
		// Constructors
		protected DTNode() {} // 0x000000018B49F860-0x000000018B49F8B0
	}

	public abstract class DTNodeNested<T> : DTNode, IGraphAssignable<T> // TypeDefIndex: 49043
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		private List<BBMappingParameter> _variablesMap;
		private T _currentInstance_k__BackingField;
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { get; set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected DTNodeNested() {}
	}

	public interface IDialogueActor // TypeDefIndex: 49044
	{
		// Properties
		string name { get; }
		Texture2D portrait { get; }
		Sprite portraitSprite { get; }
		UnityEngine.Color dialogueColor { get; }
		Vector3 dialoguePosition { get; }
		Transform transform { get; }
	}

	[Serializable]
	public class ProxyDialogueActor : IDialogueActor // TypeDefIndex: 49045
	{
		// Fields
		private string _name; // 0x10
		private Transform _transform; // 0x18
	
		// Properties
		public string name { get => default; } // 0x000000018346D130-0x000000018346D140 
		public Texture2D portrait { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public Sprite portraitSprite { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public UnityEngine.Color dialogueColor { get => default; } // 0x00000001880C4FCC-0x00000001880C4FEC 
		public Vector3 dialoguePosition { get => default; } // 0x0000000186472A7C-0x0000000186472A94 
		public Transform transform { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public ProxyDialogueActor() {} // Dummy constructor
		public ProxyDialogueActor(string name, Transform transform) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public interface IStatement // TypeDefIndex: 49046
	{
		// Properties
		string text { get; }
		AudioClip audio { get; }
		string meta { get; }
	}

	[Serializable]
	public class Statement : IStatement // TypeDefIndex: 49048
	{
		// Fields
		private string _text; // 0x10
		private AudioClip _audio; // 0x18
		private string _meta; // 0x20
	
		// Properties
		public string text { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public AudioClip audio { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string meta { get => default; set {} } // 0x000000018B4AFC50-0x000000018B4AFCB8 0x000000018B4AFA80-0x000000018B4AFB00
	
		// Nested types
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 49047
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x000000018346D130-0x000000018346D140
	
			// Methods
			internal string _BlackboardReplace_b__0(string input) => default; // 0x0000000184096E30-0x0000000184096EF0
		}
	
		// Constructors
		public Statement() {} // 0x000000018B4AFBB4-0x000000018B4AFC50
		public Statement(string text) {} // 0x000000018B4AFB00-0x000000018B4AFBB4
		public Statement(string text, AudioClip audio) {} // 0x000000018B4AF948-0x000000018B4AFA80
		public Statement(string text, AudioClip audio, string meta) {} // 0x000000018346D130-0x000000018346D140
	
		// Methods
		public IStatement BlackboardReplace(IBlackboard bb) => default; // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x000000018B4B1B94-0x000000018B4B1D88
	}

	public class ActionNode : DTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 49050
	{
		// Fields
		private ActionTask _action; // 0xA8
	
		// Properties
		public ActionTask action { get => default; set {} } // 0x000000018B49C870-0x000000018B49C8E4 0x000000018B49C6D4-0x000000018B49C740
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x000000018B49C838-0x000000018B49C854 0x000000018B49C800-0x000000018B49C81C
		public override bool requireActorSelection { get => default; } // 0x000000018A3E5F58-0x000000018A3E5F60 
	
		// Nested types
		private sealed class _UpdateAction_d__10 : IEnumerator<object> // TypeDefIndex: 49049
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ActionNode __4__this; // 0x20
			public Component actionAgent; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B49C960-0x000000018B49C9B8 
			object IEnumerator.Current { get => default; } // 0x000000018B49C770-0x000000018B49C800 
	
			// Constructors
			public _UpdateAction_d__10() {} // Dummy constructor
			public _UpdateAction_d__10(int __1__state) {} // 0x000000018349D730-0x000000018349D740
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018774BD8C-0x000000018774BDA0
			private bool MoveNext() => default; // 0x000000018349D730-0x000000018349D740
			void IEnumerator.Reset() {} // 0x00000001840A27C0-0x00000001840A27D0
		}
	
		// Constructors
		public ActionNode() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator UpdateAction(Component actionAgent) => default; // 0x0000000185492010-0x0000000185492020
		private void OnActionEnd(bool success) {} // 0x000000018B4B1F34-0x000000018B4B1FDC
		protected override void OnReset() {} // 0x0000000181377E40-0x0000000181377E50
		public override void OnGraphPaused() {} // 0x000000018B4B1FDC-0x000000018B4B2028
	}

	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 49051
	{
		// Fields
		private ConditionTask _condition; // 0xA8
	
		// Properties
		public ConditionTask condition { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018774BD8C-0x000000018774BDA0
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018B49E89C-0x000000018B49E8F4
		public override int maxOutConnections { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override bool requireActorSelection { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public ConditionNode() {} // 0x000000018A3E5F58-0x000000018A3E5F60
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B49E71C-0x000000018B49E828
	}

	public class FinishNode : DTNode // TypeDefIndex: 49052
	{
		// Fields
		public CompactStatus finishState; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool requireActorSelection { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public FinishNode() {} // 0x000000018B4A38F0-0x000000018B4A3904
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B4A38A4-0x000000018B4A38F0
	}

	public class Jumper : DTNode, IHaveNodeReference // TypeDefIndex: 49053
	{
		// Fields
		public NodeReference<DTNode> _targetNode; // 0xA8
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get => default; } // 0x000000018349D730-0x000000018349D740 
		private DTNode target { get => default; } // 0x000000018B4AB0F8-0x000000018B4AB148 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool requireActorSelection { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public Jumper() {} // 0x000000018A3E5F58-0x000000018A3E5F60
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B4AB06C-0x000000018B4AB0F8
	}

	public class MultipleChoiceNode : DTNode // TypeDefIndex: 49056
	{
		// Fields
		public float availableTime; // 0xA8
		public bool saySelection; // 0xAC
		private List<Choice> availableChoices; // 0xB0
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x000000018B4AB7C0-0x000000018B4AB848 
		public override bool requireActorSelection { get => default; } // 0x0000000181B9A230-0x0000000181B9A240 
	
		// Nested types
		[Serializable]
		public class Choice // TypeDefIndex: 49054
		{
			// Fields
			public bool isUnfolded; // 0x10
			public Statement statement; // 0x18
			public ConditionTask condition; // 0x20
	
			// Constructors
			public Choice() {} // 0x000000018B4AB848-0x000000018B4AB888
			public Choice(Statement statement) {} // 0x00000001840A27C0-0x00000001840A27D0
		}
	
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 49055
		{
			// Fields
			public MultipleChoiceNode __4__this; // 0x10
			public int index; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x000000018B4AB340-0x000000018B4AB640
	
			// Methods
			internal void _OnOptionSelected_b__0() {} // 0x000000018B4AB640-0x000000018B4AB7C0
		}
	
		// Constructors
		public MultipleChoiceNode() {} // 0x000000018B4B1E98-0x000000018B4B1ED0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018A0E9018-0x000000018A0E902C
		private void OnOptionSelected(int index) {} // 0x0000000185492010-0x0000000185492020
	}

	public class MultipleConditionNode : DTNode // TypeDefIndex: 49057
	{
		// Fields
		private List<ConditionTask> conditions; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000185FBE2F0-0x0000000185FBE300 
	
		// Constructors
		public MultipleConditionNode() {} // 0x000000018B4ABB70-0x000000018B4ABBF8
	
		// Methods
		public override void OnChildConnected(int index) {} // 0x000000018B4AB910-0x000000018B4AB99C
		public override void OnChildDisconnected(int index) {} // 0x000000018B4AB99C-0x000000018B4AB9F4
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B4AB9F4-0x000000018B4ABB70
	}

	public class ProbabilitySelector : DTNode // TypeDefIndex: 49059
	{
		// Fields
		private List<Option> childOptions; // 0xA8
		private List<int> successIndeces; // 0xB0
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x000000018B4AE358-0x000000018B4AE43C 
	
		// Nested types
		public class Option // TypeDefIndex: 49058
		{
			// Fields
			public BBParameter<float> weight; // 0x10
			public ConditionTask condition; // 0x18
	
			// Constructors
			public Option() {} // Dummy constructor
			public Option(float weightValue, IBlackboard bbValue) {} // 0x0000000185FBE2F0-0x0000000185FBE300
		}
	
		// Constructors
		public ProbabilitySelector() {} // 0x000000018B4AD818-0x000000018B4AD8D4
	
		// Methods
		public override void OnChildConnected(int index) {} // 0x000000018B4AE5A4-0x000000018B4AE5FC
		public override void OnChildDisconnected(int index) {} // 0x000000018B4AE8DC-0x000000018B4AEB54
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4AE274-0x000000018B4AE358
		private float GetTotal() => default; // 0x000000018B46FA20-0x000000018B46FA38
		protected override void OnReset() {} // 0x000000018B4AEC04-0x000000018B4AEC8C
	}

	public class StatementNode : DTNode // TypeDefIndex: 49060
	{
		// Fields
		public Statement statement; // 0xA8
	
		// Properties
		public override bool requireActorSelection { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public StatementNode() {} // 0x000000018B4AF8C0-0x000000018B4AF948
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B4AF788-0x000000018B4AF880
		private void OnStatementFinish() {} // 0x000000018B4AF880-0x000000018B4AF8C0
	}

	public class SubDialogueTree : DTNodeNested<DialogueTree>, IUpdatable // TypeDefIndex: 49061
	{
		// Fields
		private BBParameter<DialogueTree> _subTree; // 0xC0
		private Dictionary<string, string> _actorParametersMap; // 0xC8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override DialogueTree subGraph { get => default; set {} } // 0x000000018B4B0248-0x000000018B4B0290 0x000000018B4B0290-0x000000018B4B02E8
		public override BBParameter subGraphParameter { get => default; } // 0x0000000181B388F0-0x0000000181B38900 
	
		// Constructors
		public SubDialogueTree() {} // 0x000000018B4B0214-0x000000018B4B0248
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B4AFDE4-0x000000018B4AFFD0
		private void OnSubDialogueFinish(bool success) {} // 0x000000018B4AFFD0-0x000000018B4B0028
		void IUpdatable.Update() {} // 0x000000018B4AFD50-0x000000018B4AFDE4
		private void TryWriteMappedActorParameters() {} // 0x000000018B4B0028-0x000000018B4B0214
	}

	public class GoToNode : DTNode // TypeDefIndex: 49062
	{
		// Fields
		private DTNode _targetNode; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool requireActorSelection { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public GoToNode() {} // 0x000000018A3E5F58-0x000000018A3E5F60
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B4A3D98-0x000000018B4A3E10
	}

	public class DTNestedFlowScript : DTNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 49063
	{
		// Fields
		private BBParameter<FlowScript> _flowScript; // 0xC0
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override FlowScript subGraph { get => default; set {} } // 0x000000018B49F7C0-0x000000018B49F808 0x000000018B49F808-0x000000018B49F860
		public override BBParameter subGraphParameter { get => default; } // 0x0000000181B388F0-0x0000000181B38900 
	
		// Constructors
		public DTNestedFlowScript() {} // 0x000000018B49F78C-0x000000018B49F7C0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B49F630-0x000000018B49F73C
		void IUpdatable.Update() {} // 0x000000018B49F59C-0x000000018B49F630
		private void OnFlowScriptFinish(bool success) {} // 0x000000018B49F73C-0x000000018B49F78C
	}
}

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : MonoBehaviour // TypeDefIndex: 49072
	{
		// Fields
		public bool skipOnInput; // 0x18
		public bool waitForInput; // 0x19
		public RectTransform subtitlesGroup; // 0x20
		public UnityEngine.UI.Text actorSpeech; // 0x28
		public UnityEngine.UI.Text actorName; // 0x30
		public Image actorPortrait; // 0x38
		public RectTransform waitInputIndicator; // 0x40
		public SubtitleDelays subtitleDelays; // 0x48
		public List<AudioClip> typingSounds; // 0x50
		private AudioSource playSource; // 0x58
		public RectTransform optionsGroup; // 0x60
		public UnityEngine.UI.Button optionButton; // 0x68
		private Dictionary<UnityEngine.UI.Button, int> cachedButtons; // 0x70
		private Vector2 originalSubsPosition; // 0x78
		private bool isWaitingChoice; // 0x80
		private AudioSource _localSource; // 0x88
	
		// Properties
		private AudioSource localSource { get => default; } // 0x0000000181378230-0x0000000181378240 
		private bool anyKeyDown { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		[Serializable]
		public class SubtitleDelays // TypeDefIndex: 49064
		{
			// Fields
			public float characterDelay; // 0x10
			public float sentenceDelay; // 0x14
			public float commaDelay; // 0x18
			public float finalDelay; // 0x1C
	
			// Constructors
			public SubtitleDelays() {} // 0x000000018B4A3118-0x000000018B4A31C4
		}
	
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 49065
		{
			// Fields
			public bool inputDown; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0() {} // 0x000000018B4A3110-0x000000018B4A3118
	
			// Methods
			internal void _Internal_OnSubtitlesRequestInfo_b__0() {} // 0x000000018B4A1A24-0x000000018B4A1A44
		}
	
		private sealed class _Internal_OnSubtitlesRequestInfo_d__31 : IEnumerator<object> // TypeDefIndex: 49066
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SubtitlesRequestInfo info; // 0x20
			public DialogueUGUI __4__this; // 0x28
			private __c__DisplayClass31_0 __8__1; // 0x30
			private string _text_5__2; // 0x38
			private AudioClip _audio_5__3; // 0x40
			private float _timer_5__4; // 0x48
			private string _tempText_5__5; // 0x50
			private int _i_5__6; // 0x58
			private char _c_5__7; // 0x5C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4A2F04-0x000000018B4A309C 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Internal_OnSubtitlesRequestInfo_d__31() {} // Dummy constructor
			public _Internal_OnSubtitlesRequestInfo_d__31(int __1__state) {} // 0x000000018B4A2358-0x000000018B4A2378
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4A2350-0x000000018B4A2358
			private bool MoveNext() => default; // 0x000000018B4A2D6C-0x000000018B4A2F04
			void IEnumerator.Reset() {} // 0x000000018B4A1E6C-0x000000018B4A1F7C
		}
	
		private sealed class _CheckInput_d__33 : IEnumerator<object> // TypeDefIndex: 49067
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DialogueUGUI __4__this; // 0x20
			public Action Do; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4A1F7C-0x000000018B4A1FF0 
			object IEnumerator.Current { get => default; } // 0x000000018B4A1A44-0x000000018B4A1AB8 
	
			// Constructors
			public _CheckInput_d__33() {} // Dummy constructor
			public _CheckInput_d__33(int __1__state) {} // 0x000000018B4A2290-0x000000018B4A2350
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4A1FF0-0x000000018B4A2290
			private bool MoveNext() => default; // 0x000000018B4A2BCC-0x000000018B4A2BF0
			void IEnumerator.Reset() {} // 0x000000018B4A2BF0-0x000000018B4A2CDC
		}
	
		private sealed class _DelayPrint_d__34 : IEnumerator<object> // TypeDefIndex: 49068
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float time; // 0x20
			private float _timer_5__2; // 0x24
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4A1B80-0x000000018B4A1E6C 
			object IEnumerator.Current { get => default; } // 0x000000018B4A309C-0x000000018B4A3110 
	
			// Constructors
			public _DelayPrint_d__34() {} // Dummy constructor
			public _DelayPrint_d__34(int __1__state) {} // 0x000000018B4A1B2C-0x000000018B4A1B80
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4A2378-0x000000018B4A2BCC
			private bool MoveNext() => default; // 0x000000018B4A1AB8-0x000000018B4A1B2C
			void IEnumerator.Reset() {} // 0x000000018B4A2CDC-0x000000018B4A2D6C
		}
	
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 49069
		{
			// Fields
			public DialogueUGUI __4__this; // 0x10
			public MultipleChoiceRequestInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x0000000185FD2B60-0x0000000185FD2B80
		}
	
		private sealed class __c__DisplayClass35_1 // TypeDefIndex: 49070
		{
			// Fields
			public UnityEngine.UI.Button btn; // 0x10
			public __c__DisplayClass35_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass35_1() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _OnMultipleChoiceRequest_b__0() {} // 0x0000000181B9A230-0x0000000181B9A240
		}
	
		private sealed class _CountDown_d__36 : IEnumerator<object> // TypeDefIndex: 49071
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DialogueUGUI __4__this; // 0x20
			public MultipleChoiceRequestInfo info; // 0x28
			private float _timer_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _CountDown_d__36() {} // Dummy constructor
			public _CountDown_d__36(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018B4B12E4-0x000000018B4B1B48
			void IEnumerator.Reset() {} // 0x000000018B4B1B48-0x000000018B4B1B94
		}
	
		// Constructors
		public DialogueUGUI() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Awake() {} // 0x000000018B4B0EC0-0x000000018B4B0F1C
		private void OnEnable() {} // 0x0000000181377E40-0x0000000181377E50
		private void OnDisable() {} // 0x000000018B4B0F1C-0x000000018B4B0F68
		private void Subscribe() {} // 0x0000000181377E40-0x0000000181377E50
		private void UnSubscribe() {} // 0x0000000181378230-0x0000000181378240
		private void Hide() {} // 0x0000000185492010-0x0000000185492020
		private void OnDialogueStarted(DialogueTree dlg) {} // 0x000000018B4B122C-0x000000018B4B1298
		private void OnDialoguePaused(DialogueTree dlg) {} // 0x0000000181377E40-0x0000000181377E50
		private void OnDialogueFinished(DialogueTree dlg) {} // 0x000000018B4B1298-0x000000018B4B12E4
		private void OnSubtitlesRequest(SubtitlesRequestInfo info) {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info) => default; // 0x0000000185492010-0x0000000185492020
		private void PlayTypeSound() {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator CheckInput(Action Do) => default; // 0x000000018B4B1D88-0x000000018B4B1E0C
		private IEnumerator DelayPrint(float time) => default; // 0x0000000181378230-0x0000000181378240
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator CountDown(MultipleChoiceRequestInfo info) => default; // 0x000000018B4B1078-0x000000018B4B11E0
		private void Finalize(MultipleChoiceRequestInfo info, int index) {} // 0x0000000181377E40-0x0000000181377E50
		private void SetMassAlpha(RectTransform root, float alpha) {} // 0x000000018B4B11E0-0x000000018B4B122C
	}
}

namespace NodeCanvas.Framework
{
	public class GraphInfoAttribute : Attribute // TypeDefIndex: 49129
	{
		// Fields
		public string packageName; // 0x10
		public string docsURL; // 0x18
		public string resourcesURL; // 0x20
		public string forumsURL; // 0x28
	
		// Constructors
		public GraphInfoAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DropReferenceType : Attribute // TypeDefIndex: 49130
	{
		// Fields
		public readonly System.Type type; // 0x10
	
		// Constructors
		public DropReferenceType() {} // Dummy constructor
		public DropReferenceType(System.Type type) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class BlackboardOnlyAttribute : Attribute // TypeDefIndex: 49131
	{
		// Constructors
		public BlackboardOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class LogTag // TypeDefIndex: 49132
	{
		// Fields
		public const string EDITOR = "Editor"; // Metadata: 0x02060DBE
		public const string EVENT = "Event"; // Metadata: 0x02060DC5
		public const string EXECUTION = "Execution"; // Metadata: 0x02060DCB
		public const string VARIABLE = "Variable"; // Metadata: 0x02060DD5
		public const string BLACKBOARD = "Blackboard"; // Metadata: 0x02060DDE
		public const string GRAPH = "Graph"; // Metadata: 0x02060DE9
		public const string INIT = "Initialization"; // Metadata: 0x02060DEF
		public const string VALIDATION = "Validation"; // Metadata: 0x02060DFE
		public const string SERIALIZATION = "Serialization"; // Metadata: 0x02060E09
	}

	public class SignalDefinition : ScriptableObject // TypeDefIndex: 49135
	{
		// Fields
		private InvokeArguments onInvoke; // 0x18
		private List<DynamicParameterDefinition> _parameters; // 0x20
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get => default; private set {} } // 0x000000018B4AAC28-0x000000018B4AAD50 0x00000001832D8120-0x00000001832D8140
	
		// Events
		public event InvokeArguments onInvoke;
	
		// Nested types
		public delegate void InvokeArguments(Transform sender, Transform receiver, bool isGlobal, object[] args); // TypeDefIndex: 49133; 0x000000018B4AF6F4-0x000000018B4AF788
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 49134
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B4AF4A8-0x000000018B4AF4D8
	
			// Methods
			internal bool _RemoveParameter_b__0(DynamicParameterDefinition p) => default; // 0x000000018B4AF40C-0x000000018B4AF4A8
		}
	
		// Constructors
		public SignalDefinition() {} // 0x000000018B40BF7C-0x000000018B40BFA4
	
		// Methods
		public void Invoke(Transform sender, Transform receiver, bool isGlobal, object[] args) {} // 0x000000018B4AAB8C-0x000000018B4AAC28
		public void AddParameter(string name, System.Type type) {} // 0x00000001864BB614-0x00000001864BB734
		public void RemoveParameter(string name) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class CanvasGroup // TypeDefIndex: 49136
	{
		// Fields
		public string name; // 0x10
		public Rect rect; // 0x18
		public UnityEngine.Color color; // 0x28
		public bool autoGroup; // 0x38
	
		// Constructors
		public CanvasGroup() {} // 0x0000000185492010-0x0000000185492020
		public CanvasGroup(Rect rect, string name) {} // 0x000000018B49DE54-0x000000018B49DE68
	}

	[Serializable]
	public abstract class Connection : IGraphElement, ISerializationCollectable // TypeDefIndex: 49137
	{
		// Fields
		private NodeCanvas.Framework.Node _sourceNode; // 0x10
		private NodeCanvas.Framework.Node _targetNode; // 0x18
		private string _UID; // 0x20
		private bool _isDisabled; // 0x28
		[NonSerialized]
		private NodeCanvas.Framework.Status _status; // 0x2C
	
		// Properties
		public string UID { get; } // 0x000000018B49F34C-0x000000018B49F3A8 
		public NodeCanvas.Framework.Node sourceNode { get; protected set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public NodeCanvas.Framework.Node targetNode { get; protected set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		string IGraphElement.name { get; } // 0x000000018B49EE78-0x000000018B49EEA4 
		public bool isActive { get; set; } // 0x000000018B49F3BC-0x000000018B49F3C4 0x000000018B49F3C4-0x000000018B49F3F8
		public NodeCanvas.Framework.Status status { get; set; } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
		public NodeCanvas.Framework.Graph graph { get; } // 0x000000018B49F3A8-0x000000018B49F3BC 
		public virtual bool drawInspector { get; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public Connection() {} // 0x0000000185FBE310-0x0000000185FBE320
	
		// Methods
		public static Connection Create(NodeCanvas.Framework.Node source, NodeCanvas.Framework.Node target, int sourceIndex = -1 /* Metadata: 0x02060E17 */, int targetIndex = -1 /* Metadata: 0x02060E18 */) => default; // 0x000000018B49EA8C-0x000000018B49EB7C
		public Connection Duplicate(NodeCanvas.Framework.Node newSource, NodeCanvas.Framework.Node newTarget) => default; // 0x000000018B49EB7C-0x000000018B49EE40
		public int SetSourceNode(NodeCanvas.Framework.Node newSource, int index = -1 /* Metadata: 0x02060E19 */, bool recodeUndo = true /* Metadata: 0x02060E1A */) => default; // 0x000000018B49EEDC-0x000000018B49F07C
		public int SetTargetNode(NodeCanvas.Framework.Node newTarget, int index = -1 /* Metadata: 0x02060E1B */, bool recodeUndo = true /* Metadata: 0x02060E1C */) => default; // 0x000000018B49F07C-0x000000018B49F2FC
		public int SetRawSourceNode(NodeCanvas.Framework.Node newSource) => default; // 0x0000000183E61F30-0x0000000183E628A0
		public int SetRawTargetNode(NodeCanvas.Framework.Node newTarget) => default; // 0x0000000183E628A0-0x0000000183E63280
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard) => default; // 0x000000018B49EE40-0x000000018B49EE78
		public void Reset(bool recursively = true /* Metadata: 0x02060E1D */) {} // 0x000000018B49EEA4-0x000000018B49EEDC
		public virtual void OnCreate(int sourceIndex, int targetIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnValidate(int sourceIndex, int targetIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnDestroyAfterConnectionRemoved() {} // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x000000018B49F2FC-0x000000018B49F34C
	}

	public abstract class ExposedParameter // TypeDefIndex: 49138
	{
		// Properties
		public abstract string targetVariableID { get; }
		public abstract System.Type type { get; }
		public abstract object valueBoxed { get; set; }
		public abstract Variable varRefBoxed { get; }
	
		// Constructors
		protected ExposedParameter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract void Bind(IBlackboard blackboard);
		public abstract void UnBind();
		public static ExposedParameter CreateInstance(Variable target) => default; // 0x000000018B4A348C-0x000000018B4A35BC
	}

	public sealed class ExposedParameter<T> : ExposedParameter // TypeDefIndex: 49139
	{
		// Fields
		private string _targetVariableID;
		private T _value;
		private Variable<T> _varRef_k__BackingField;
	
		// Properties
		public Variable<T> varRef { get; private set; }
		public override string targetVariableID { get => default; }
		public override System.Type type { get => default; }
		public override object valueBoxed { get => default; set {} }
		public override Variable varRefBoxed { get => default; }
		public T value { get => default; set {} }
	
		// Constructors
		public ExposedParameter() {}
		public ExposedParameter(Variable target) {}
	
		// Methods
		public override void Bind(IBlackboard blackboard) {}
		public override void UnBind() {}
		private T GetRawValue() => default;
		private void SetRawValue(T value) {}
	}

	[Serializable]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver, IStringCompressProcessor // TypeDefIndex: 49154
	{
		// Fields
		private string _serializedGraph; // 0x18
		protected int _serializedGraphStringIndex; // 0x20
		private bool _enableGraphStringCompress; // 0x24
		private List<UnityEngine.Object> _objectReferences; // 0x28
		private GraphSource _graphSource; // 0x30
		private bool _haltSerialization; // 0x38
		[NonSerialized]
		private bool haltForUndo; // 0x39
		private static Action<Graph> onGraphSerialized; // 0x00
		public static Action<Graph> onGraphDeserialized; // 0x08
		private bool _isDeserialized_k__BackingField; // 0x3A
		private static List<NodeCanvas.Framework.Node> s_nodeBuffer; // 0x10
		private bool _graphValidateDirty_k__BackingField; // 0x3B
		private Action<bool> onFinish; // 0x40
		private static List<Graph> _runningGraphs; // 0x18
		private bool _hasInitialized_k__BackingField; // 0x48
		private HierarchyTree.Element _flatMetaGraph_k__BackingField; // 0x50
		private HierarchyTree.Element _fullMetaGraph_k__BackingField; // 0x58
		private HierarchyTree.Element _nestedMetaGraph_k__BackingField; // 0x60
		private Graph _parentGraph_k__BackingField; // 0x68
		private float _elapsedTime_k__BackingField; // 0x70
		private float _deltaTime_k__BackingField; // 0x74
		private int _lastUpdateFrame_k__BackingField; // 0x78
		private bool _isRunning_k__BackingField; // 0x7C
		private bool _isPaused_k__BackingField; // 0x7D
		private UpdateMode _updateMode_k__BackingField; // 0x80
		private Component _agent_k__BackingField; // 0x88
		private IBlackboard _parentBlackboard_k__BackingField; // 0x90
		private Action delayedInitCalls; // 0x98
	
		// Properties
		public virtual bool allowRuntimeSerialization { get; } // 0x000000018B4A5134-0x000000018B4A51CC 
		public virtual bool dontSerializeBinderConnectionGenericType { get; }
		public bool isDeserialized { get; private set; } // 0x000000018B4A93A8-0x000000018B4A980C 0x0000000185FB0B30-0x0000000185FB0B40
		public abstract bool canDelayDeserializeAndOptimizeClone { get; } // 0x0000000185FB0B60-0x0000000185FB0B70 
		public bool graphValidateDirty { get; set; } // 0x000000018B4A9B44-0x000000018B4A9B64 0x000000018B4A9FF0-0x000000018B4AA030
		private bool hasInitialized { get; set; } // 0x000000018B4A99F4-0x000000018B4A9A20 0x000000018B4A9BF8-0x000000018B4A9C64
		private HierarchyTree.Element flatMetaGraph { get; set; } // 0x0000000185FB0700-0x0000000185FB0710 0x000000018B4A9C64-0x000000018B4A9CB4
		private HierarchyTree.Element fullMetaGraph { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		private HierarchyTree.Element nestedMetaGraph { get; set; } // 0x0000000185FB89C0-0x0000000185FB89D0 0x0000000185FBD310-0x0000000185FBD320
		public abstract System.Type baseNodeType { get; } // 0x0000000185FB89F0-0x0000000185FB8A00 
		public abstract bool requiresAgent { get; } // 0x0000000185FBA030-0x0000000185FBA040 
		public abstract bool requiresPrimeNode { get; } // 0x0000000185FB0560-0x0000000185FB0570 
		public abstract bool isTree { get; } // 0x0000000185FB05C0-0x0000000185FB05D0 
		public abstract bool allowBlackboardOverrides { get; } // 0x000000018B4A9B24-0x000000018B4A9B44 
		public abstract bool canAcceptVariableDrops { get; } // 0x0000000185FBA020-0x0000000185FBA030 
		private GraphSource graphSource { get; set; } // 0x0000000185FBA040-0x0000000185FBA050 0x0000000185FCDC00-0x0000000185FCDC10
		public string category { get; set; } // 0x0000000185FCE040-0x0000000185FCE050 0x000000018140C930-0x000000018140C940
		public string comments { get; set; } // 0x000000018140C940-0x000000018140C950 0x000000018B4A9B64-0x000000018B4A9BF8
		public Vector2 translation { get; set; } // 0x000000018B4AA030-0x000000018B4AA174 0x0000000185FB0510-0x0000000185FB0520
		public float zoomFactor { get; set; } // 0x0000000186472AA8-0x0000000186472ABC 0x000000018B4A9A98-0x000000018B4A9AA0
		public List<NodeCanvas.Framework.Node> allNodes { get; set; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x00000001873CBEA8-0x00000001873CBEBC
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x0000000185779060-0x0000000185779070 0x000000018B4A918C-0x000000018B4A9228
		private BlackboardSource localBlackboard { get; set; } // 0x000000018B4A9228-0x000000018B4A93A8 0x000000018B4A8D58-0x000000018B4A8E04
		private List<BBParameter> allParameters { get; } // 0x000000018B4A6F48-0x000000018B4A6FDC 
		public List<NodeCanvas.Framework.Task> allTasks { get; } // 0x000000018B4A8E04-0x000000018B4A918C 
		public List<Connection> allConnections { get; } // 0x0000000185492010-0x0000000185492020 
		public Graph rootGraph { get; } // 0x0000000185492010-0x0000000185492020 
		public bool serializationHalted { get; } // 0x000000018B4A3F80-0x000000018B4A4098 
		public static IEnumerable<Graph> runningGraphs { get; } // 0x000000018B4A980C-0x000000018B4A98A4 
		public Graph parentGraph { get; set; } // 0x000000018B4A9D18-0x000000018B4A9DB0 0x000000018B4A8B78-0x000000018B4A8BEC
		public float elapsedTime { get; private set; } // 0x000000018B4A6CE8-0x000000018B4A6DC8 0x000000018B4A6DC8-0x000000018B4A6F48
		public float deltaTime { get; private set; } // 0x000000018B4A6C78-0x000000018B4A6CE8 0x000000018B4A71B0-0x000000018B4A74C4
		public int lastUpdateFrame { get; private set; } // 0x000000018B4A8598-0x000000018B4A88E8 0x000000018B4A417C-0x000000018B4A4478
		public bool didUpdateLastFrame { get; } // 0x000000018B4A8920-0x000000018B4A8B78 
		public bool isRunning { get; private set; } // 0x000000018B4A702C-0x000000018B4A71B0 0x000000018B4A7CDC-0x000000018B4A7E64
		public bool isPaused { get; private set; } // 0x000000018B4A7C84-0x000000018B4A7CDC 0x000000018B4A8C9C-0x000000018B4A8CC0
		public UpdateMode updateMode { get; private set; } // 0x000000018B4A8CC0-0x000000018B4A8D58 0x00000001813AE580-0x00000001813AE590
		public NodeCanvas.Framework.Node primeNode { get; set; } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		public Component agent { get; private set; } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		public IBlackboard blackboard { get; } // 0x0000000185492010-0x0000000185492020 
		public IBlackboard parentBlackboard { get; private set; } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000185492010-0x0000000185492020 
	
		// Events
		public static event Action<Graph> onGraphSerialized;
		public event Action<bool> onFinish;
		private event Action delayedInitCalls;
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 49140
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2,
			Manual = 3
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49141
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<NodeCanvas.Framework.Node, int> __9__174_0; // 0x08
			public static Func<NodeCanvas.Framework.Node, bool> __9__218_0; // 0x10
			public static Func<NodeCanvas.Framework.Node, bool> __9__219_0; // 0x18
			public static Func<BBParameter, bool> __9__222_0; // 0x20
	
			// Constructors
			static __c() {} // 0x000000018B4A9930-0x000000018B4A99F4
			public __c() {} // 0x000000018B4A9E3C-0x000000018B4A9F00
	
			// Methods
			internal int _UpdateNodeIDs_b__174_0(NodeCanvas.Framework.Node n) => default; // 0x00000001840A27C0-0x00000001840A27D0
			internal bool _GetRootNodes_b__218_0(NodeCanvas.Framework.Node n) => default; // 0x00000001814A81B0-0x00000001814A81C0
			internal bool _GetLeafNodes_b__219_0(NodeCanvas.Framework.Node n) => default; // 0x0000000185FB0B20-0x0000000185FB0B30
			internal bool _GetDefinedParameters_b__222_0(BBParameter p) => default; // 0x0000000185FB0B50-0x0000000185FB0B60
		}
	
		private sealed class __c__DisplayClass182_0 // TypeDefIndex: 49142
		{
			// Fields
			public Graph __4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public __c__DisplayClass182_0() {}
	
			// Methods
			internal void _LoadOverwriteAsync_b__0() {} // 0x000000018361A650-0x000000018361A660
		}
	
		private struct _LoadOverwriteAsync_d__182 : IAsyncStateMachine // TypeDefIndex: 49143
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Graph __4__this; // 0x28
			public GraphLoadData data; // 0x30
			public Action callback; // 0x60
			private TaskAwaiter __u__1; // 0x68
	
			// Methods
			private void MoveNext() {} // 0x000000018361A650-0x000000018361A660
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018361A650-0x000000018361A660
		}
	
		private sealed class __c__DisplayClass183_0 // TypeDefIndex: 49144
		{
			// Fields
			public Graph __4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public __c__DisplayClass183_0() {} // 0x000000018B4A8C88-0x000000018B4A8C9C
	
			// Methods
			internal void _LoadOverwrite_b__0() {} // 0x000000018B4A8C2C-0x000000018B4A8C88
		}
	
		private sealed class __c__DisplayClass213_0 // TypeDefIndex: 49145
		{
			// Fields
			public int searchID; // 0x10
	
			// Constructors
			public __c__DisplayClass213_0() {} // 0x000000018B4A8BEC-0x000000018B4A8C2C
	
			// Methods
			internal bool _GetNodeWithID_b__0(NodeCanvas.Framework.Node n) => default; // 0x0000000185FAF320-0x0000000185FAF340
		}
	
		private sealed class __c__DisplayClass215_0<T> // TypeDefIndex: 49146
			where T : NodeCanvas.Framework.Node
		{
			// Fields
			public string tagName;
	
			// Constructors
			public __c__DisplayClass215_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _GetNodeWithTag_b__0(T n) => default; // 0x000000018B4A6FDC-0x000000018B4A702C
		}
	
		private sealed class __c__DisplayClass216_0<T> // TypeDefIndex: 49147
			where T : NodeCanvas.Framework.Node
		{
			// Fields
			public string tagName;
	
			// Constructors
			public __c__DisplayClass216_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _GetNodesWithTag_b__0(T n) => default; // 0x000000018B4A7C74-0x000000018B4A7C84
		}
	
		[Serializable]
		private sealed class __c__217<T> // TypeDefIndex: 49148
			where T : NodeCanvas.Framework.Node
		{
			// Fields
			public static readonly __c__217<T> __9;
			public static Func<T, bool> __9__217_0;
	
			// Constructors
			static __c__217() {} // 0x000000018B4A7F04-0x000000018B4A8088
			public __c__217() {}
	
			// Methods
			internal bool _GetAllTagedNodes_b__217_0(T n) => default; // 0x000000018B4A7E64-0x000000018B4A7F04
		}
	
		private sealed class __c__DisplayClass230_0 // TypeDefIndex: 49149
		{
			// Fields
			public Stack<HierarchyTree.Element> stack; // 0x10
			public HierarchyTree.Element parentElement; // 0x18
	
			// Constructors
			public __c__DisplayClass230_0() {} // 0x000000018B4A8440-0x000000018B4A855C
	
			// Methods
			internal void _CollectSubElements_b__0(object o) {} // 0x000000018B4A533C-0x000000018B4A57B8
			internal void _CollectSubElements_b__1(object o, fsData d) {} // 0x000000018B4A51CC-0x000000018B4A533C
		}
	
		private sealed class __c__DisplayClass233_0 // TypeDefIndex: 49150
		{
			// Fields
			public List<NodeCanvas.Framework.Task> result; // 0x10
	
			// Constructors
			public __c__DisplayClass233_0() {} // 0x000000018B4A62EC-0x000000018B4A6308
	
			// Methods
			internal void _GetTasksInElement_b__0(object o, fsData d) {} // 0x000000018B4A6908-0x000000018B4A6920
		}
	
		private sealed class __c__DisplayClass234_0 // TypeDefIndex: 49151
		{
			// Fields
			public List<BBParameter> result; // 0x10
	
			// Constructors
			public __c__DisplayClass234_0() {} // 0x000000018B4A686C-0x000000018B4A68BC
	
			// Methods
			internal void _GetParametersInElement_b__0(object o, fsData d) {} // 0x000000018B4A502C-0x000000018B4A5134
		}
	
		private sealed class __c__DisplayClass239_0 // TypeDefIndex: 49152
		{
			// Fields
			public NodeCanvas.Framework.Node node; // 0x10
	
			// Constructors
			public __c__DisplayClass239_0() {} // 0x000000018B4A68BC-0x000000018B4A6908
	
			// Methods
			internal bool _RemoveNode_b__0(NodeCanvas.Framework.Node n) => default; // 0x000000018570A480-0x000000018570A4A0
		}
	
		private sealed class __c__DisplayClass242_0 // TypeDefIndex: 49153
		{
			// Fields
			public Graph targetGraph; // 0x10
	
			// Constructors
			public __c__DisplayClass242_0() {} // 0x000000018B4A6920-0x000000018B4A6964
	
			// Methods
			internal bool _CloneNodes_b__0(NodeCanvas.Framework.Node n) => default; // 0x000000018B4A627C-0x000000018B4A62EC
		}
	
		// Constructors
		protected Graph() {} // 0x0000000185492010-0x0000000185492020
		static Graph() {} // 0x000000018B4C7190-0x000000018B4C71F0
	
		// Methods
		public virtual Rect DrawCustomBlackboardPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos) => default; // 0x000000018B4A98A4-0x000000018B4A9930
		public virtual Rect DrawCustomPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos) => default; // 0x000000018B4A9DB0-0x000000018B4A9E3C
		public virtual Rect DrawCustomPanel2(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos) => default; // 0x0000000185FB0750-0x0000000185FB0760
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185FB0770-0x0000000185FB0780
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000181460F60-0x0000000181460F70
		public void TryDeserializeIfNot() {} // 0x0000000184A4E570-0x0000000184A4E580
		protected void OnEnable() {} // 0x00000001813F1630-0x00000001813F1640
		protected void OnDisable() {} // 0x0000000186472DB0-0x0000000186472DC0
		protected void OnDestroy() {} // 0x0000000185FB0530-0x0000000185FB0540
		protected void OnValidate() {} // 0x0000000185AE8FE0-0x0000000185AE8FF0
		protected void Reset() {}
		public bool SelfSerialize(bool ignoreScene = false /* Metadata: 0x02060E1E */) => default;
		protected virtual void OnAfterGraphSerialized() {}
		public bool SelfDeserialize() => default;
		public string Serialize(List<UnityEngine.Object> references) => default;
		public bool Deserialize(string serializedGraph, List<UnityEngine.Object> references, bool validate) => default;
		public bool DeserializeSelf(List<UnityEngine.Object> references, bool validate) => default; // 0x000000018B4A62EC-0x000000018B4A6308
		public GraphSource GetGraphSource() => default; // 0x00000001864721F0-0x0000000186472200
		public string GetSerializedJsonData() => default; // 0x000000018B4A9ACC-0x000000018B4A9AF8
		public int GetSerializedJsonDataStringIndex() => default; // 0x000000018B4A9F70-0x000000018B4A9FB0
		public bool DeserializeFromGraph(Graph other, bool validate = true /* Metadata: 0x02060E1F */) => default; // 0x000000018B4A9AF8-0x000000018B4A9B24
		public DataCompressManager.StringCompressUnsafeString GetSerializedJsonDataUnsafeString() => default; // 0x000000018B4A9FB0-0x000000018B4A9FF0
		public void ClearSerializedJsonData() {} // 0x000000018B4A9CB4-0x000000018B4A9CEC
		public List<UnityEngine.Object> GetSerializedReferencesData() => default; // 0x000000018B4AA174-0x000000018B4AA1B4
		public GraphSource GetGraphSourceMetaDataCopy() => default; // 0x000000018B4A9CEC-0x000000018B4A9D18
		public void SetGraphSourceMetaData(GraphSource source) {} // 0x000000018B4AA1B4-0x000000018B4AA1EC
		public string SerializeLocalBlackboard(ref List<UnityEngine.Object> references) => default; // 0x000000018B4A9A20-0x000000018B4A9A4C
		public bool DeserializeLocalBlackboard(string json, List<UnityEngine.Object> references) => default; // 0x000000018B4A9F00-0x000000018B4A9F30
		public static T Clone<T>(T graph, Graph parentGraph)
			where T : Graph => default; // 0x000000018B4A9AA0-0x000000018B4A9ACC
		public void Validate() {} // 0x000000018B4A9F30-0x000000018B4A9F70
		public void UpdateReferencesFromOwner(GraphOwner owner, bool force = false /* Metadata: 0x02060E20 */) {} // 0x0000000185492010-0x0000000185492020
		public void UpdateReferences(Component newAgent, IBlackboard newParentBlackboard, bool force = false /* Metadata: 0x02060E21 */) {} // 0x0000000185492010-0x0000000185492020
		private void UpdateNodeBBFields() {} // 0x0000000185492010-0x0000000185492020
		void ITaskSystem.UpdateTasksOwner() {} // 0x000000018B4A8088-0x000000018B4A8174
		public void UpdateNodeIDs(bool alsoReorderList) {}
		public virtual void OnGraphStructureChange() {} // 0x000000018B4A8174-0x000000018B4A8364
		protected virtual void OnAfterUpdateNodeIDs() {}
		private int AssignNodeID(NodeCanvas.Framework.Node node, int lastID, ref NodeCanvas.Framework.Node[] parsed) => default; // 0x000000018B4A5CA0-0x000000018B4A5CA8
		protected void ThreadSafeInitCall(Action call) {} // 0x000000018B4A64BC-0x000000018B4A65B4
		public void LoadOverwriteAsync(GraphLoadData data, Action callback) {}
		public void LoadOverwrite(GraphLoadData data) {}
		public void Initialize(Component newAgent, IBlackboard newParentBlackboard, bool preInitializeSubGraphs) {}
		private void PreInitializeSubGraphs() {}
		public void StartGraph(Component newAgent, IBlackboard newParentBlackboard, UpdateMode newUpdateMode, Action<bool> callback = null) {} // 0x000000018B4A6758-0x000000018B4A686C
		public void ClearGraphData() {} // 0x000000018B4A6308-0x000000018B4A641C
		public void Stop(bool success = true /* Metadata: 0x02060E22 */) {}
		public void Pause() {} // 0x000000018B4A5948-0x000000018B4A5CA0
		public void Resume() {} // 0x000000018B4A5CA8-0x000000018B4A5DBC
		public void Restart() {} // 0x000000018B4A7524-0x000000018B4A7678
		public void UpdateGraph() {} // 0x000000018B4A5DBC-0x000000018B4A5FB4
		public void UpdateGraph(float deltaTime) {} // 0x000000018B4A5FB4-0x000000018B4A60DC
		public virtual object OnDerivedDataSerialization() => default; // 0x000000018B4A60DC-0x000000018B4A627C
		public virtual void OnDerivedDataDeserialization(object data) {} // 0x000000018B4A641C-0x000000018B4A64BC
		protected virtual void OnGraphInitialize() {} // 0x000000018B4A57B8-0x000000018B4A5940
		protected virtual void OnGraphStarted() {} // 0x000000018B4A6B08-0x000000018B4A6C78
		protected virtual void OnGraphUpdate() {} // 0x000000018B4A4E14-0x000000018B4A4FB0
		protected virtual void OnGraphStoped() {} // 0x000000018B4A6964-0x000000018B4A69D4
		protected virtual void OnGraphPaused() {} // 0x000000018B4A65B4-0x000000018B4A6624
		protected virtual void OnGraphUnpaused() {} // 0x000000018B4A69D4-0x000000018B4A6B08
		protected virtual void OnGraphObjectEnable() {} // 0x000000018B4A6624-0x000000018B4A6758
		protected virtual void OnGraphObjectDisable() {}
		protected virtual void OnGraphObjectDestroy() {}
		protected virtual void OnGraphValidate() {} // 0x000000018B4A3F08-0x000000018B4A3F80
		public void SendEvent(string name, object value, object sender) {} // 0x000000018B4A3E10-0x000000018B4A3F08
		public void SendEvent<T>(string name, T value, object sender) {} // 0x000000018B4A7830-0x000000018B4A7C74
		public static void SendGlobalEvent(string name, object value, object sender) {} // 0x000000018B4A4FB0-0x000000018B4A502C
		public static void SendGlobalEvent<T>(string name, T value, object sender) {} // 0x000000018B4A7678-0x000000018B4A7830
		public IEnumerable<BBParameter> GetAllParameters() => default; // 0x000000018B4A4520-0x000000018B4A4E14
		public IEnumerable<Connection> GetAllConnections() => default; // 0x000000018B4A4478-0x000000018B4A4520
		public IEnumerable<T> GetAllTasksOfType<T>()
			where T : NodeCanvas.Framework.Task => default; // 0x000000018B4A88E8-0x000000018B4A8920
		public NodeCanvas.Framework.Node GetNodeWithID(int searchID) => default; // 0x000000018B4A74C4-0x000000018B4A7524
		public IEnumerable<T> GetAllNodesOfType<T>()
			where T : NodeCanvas.Framework.Node => default; // 0x000000018B4A4098-0x000000018B4A417C
		public T GetNodeWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node => default; // 0x00000001858D6FB0-0x00000001858D7020
		public IEnumerable<T> GetNodesWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node => default; // 0x00000001858D70E0-0x00000001858D7180
		public IEnumerable<T> GetAllTagedNodes<T>()
			where T : NodeCanvas.Framework.Node => default; // 0x000000018B4C7688-0x000000018B4C76EC
		public IEnumerable<NodeCanvas.Framework.Node> GetRootNodes() => default; // 0x0000000185492010-0x0000000185492020
		public IEnumerable<NodeCanvas.Framework.Node> GetLeafNodes() => default; // 0x000000018B4C6C60-0x000000018B4C6CCC
		public IEnumerable<T> GetAllNestedGraphs<T>(bool recursive)
			where T : Graph => default;
		public IEnumerable<Graph> GetAllInstancedNestedGraphs() => default; // 0x000000018B4C6BD0-0x000000018B4C6C18
		public IEnumerable<BBParameter> GetDefinedParameters() => default; // 0x000000018B4C6BB8-0x000000018B4C6BD0
		public void PromoteMissingParametersToVariables(IBlackboard bb) {} // 0x0000000185492010-0x0000000185492020
		public static Graph GetElementGraph(object obj) => default; // 0x000000018B4C6D7C-0x000000018B4C6DC0
		public HierarchyTree.Element GetFlatMetaGraph() => default; // 0x000000018B4C6888-0x000000018B4C6AE4
		public HierarchyTree.Element GetFullMetaGraph() => default; // 0x0000000186475504-0x0000000186475510
		public HierarchyTree.Element GetNestedMetaGraph() => default; // 0x0000000185492010-0x0000000185492020
		private static void DigNestedGraphs(Graph currentGraph, HierarchyTree.Element currentElement) {} // 0x000000018B4C6DC0-0x000000018B4C6DF8
		private static HierarchyTree.Element GetTreeNodeElement(NodeCanvas.Framework.Node node, bool recurse, ref int lastID) => default; // 0x0000000185492010-0x0000000185492020
		private static HierarchyTree.Element CollectSubElements(IGraphElement obj) => default; // 0x000000018B4C6E50-0x000000018B4C6E70
		public IGraphElement GetTaskParentElement(NodeCanvas.Framework.Task targetTask) => default;
		public IGraphElement GetParameterParentElement(BBParameter targetParameter) => default;
		public static IEnumerable<NodeCanvas.Framework.Task> GetTasksInElement(IGraphElement target) => default;
		public static IEnumerable<BBParameter> GetParametersInElement(IGraphElement target) => default;
		public T AddNode<T>()
			where T : NodeCanvas.Framework.Node => default;
		public T AddNode<T>(Vector2 pos)
			where T : NodeCanvas.Framework.Node => default;
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType) => default;
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType, Vector2 pos) => default; // 0x0000000185492010-0x0000000185492020
		public void RemoveNode(NodeCanvas.Framework.Node node, bool recordUndo = true /* Metadata: 0x02060E23 */, bool force = false /* Metadata: 0x02060E24 */) {} // 0x000000018B4C6E70-0x000000018B4C6F68
		public Connection ConnectNodes(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, int sourceIndex = -1 /* Metadata: 0x02060E25 */, int targetIndex = -1 /* Metadata: 0x02060E26 */) => default; // 0x000000018B4C6F68-0x000000018B4C6FE8
		public void RemoveConnection(Connection connection, bool recordUndo = true /* Metadata: 0x02060E27 */, bool invokeGraphChanged = true /* Metadata: 0x02060E28 */) {} // 0x0000000185492010-0x0000000185492020
		public static List<NodeCanvas.Framework.Node> CloneNodes(List<NodeCanvas.Framework.Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default) => default; // 0x000000018B4C6FE8-0x000000018B4C707C
		public void ClearGraph() {} // 0x0000000185492010-0x0000000185492020
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null) {} // 0x000000018B4C707C-0x000000018B4C7110
		public void ProcessStringCompress(StringCompressVisitor visitor) {} // 0x0000000185492010-0x0000000185492020
		public bool CheckStringCompress() => default; // 0x000000018B4C7110-0x000000018B4C7190
	}

	public abstract class GraphOwner : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 49166
	{
		// Fields
		protected bool isLazyLoadTriggered; // 0x18
		private bool m_deserializeFinish; // 0x19
		private SerializationPair[] _serializedExposedParameters; // 0x20
		private List<ExposedParameter> _exposedParameters_k__BackingField; // 0x28
		public static Action<GraphOwner> onOwnerBehaviourStateChange; // 0x00
		private Action onMonoBehaviourStart; // 0x30
		private string _boundGraphSerialization; // 0x38
		private List<UnityEngine.Object> _boundGraphObjectReferences; // 0x40
		private GraphSource _boundGraphSource; // 0x48
		private FirstActivation _firstActivation; // 0x50
		private EnableAction _enableAction; // 0x54
		private DisableAction _disableAction; // 0x58
		private bool _lockBoundGraphPrefabOverrides; // 0x5C
		private bool _lockBoundGraphFromInstance; // 0x5D
		private bool _preInitializeSubGraphs; // 0x5E
		private NodeCanvas.Framework.Graph.UpdateMode _updateMode; // 0x60
		protected Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances; // 0x68
		private bool _initialized_k__BackingField; // 0x70
		private bool _enableCalled_k__BackingField; // 0x71
		private bool _startCalled_k__BackingField; // 0x72
	
		// Properties
		public List<ExposedParameter> exposedParameters { get; set; } // 0x0000000185FB3070-0x0000000185FB3080 0x0000000185FBD4B0-0x0000000185FBD4C0
		public abstract NodeCanvas.Framework.Graph graph { get; set; } // 0x0000000185F05C80-0x0000000185F05C90 0x000000018B4B80F0-0x000000018B4B8104
		public abstract IBlackboard blackboard { get; set; } // 0x0000000185FB0C30-0x0000000185FB0C40 0x0000000185FD1FA0-0x0000000185FD1FB0
		public abstract System.Type graphType { get; } // 0x0000000185FD1FE0-0x0000000185FD1FF0 
		public bool initialized { get; private set; } // 0x0000000185FD1FC0-0x0000000185FD1FD0 0x0000000185FD2000-0x0000000185FD2010
		public bool enableCalled { get; private set; } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000185FB06B0-0x0000000185FB06C0
		public bool startCalled { get; private set; } // 0x0000000185FB0670-0x0000000185FB0680 0x0000000185FB06A0-0x0000000185FB06B0
		public GraphSource boundGraphSource { get; private set; } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public string boundGraphSerialization { get; private set; } // 0x000000018143E3B0-0x000000018143E3C0 0x000000018143E3C0-0x000000018143E3D0
		public List<UnityEngine.Object> boundGraphObjectReferences { get; private set; } // 0x0000000184C97060-0x0000000184C97080 0x0000000184C96200-0x0000000184C96270
		public bool lockBoundGraphPrefabOverrides { get; set; } // 0x000000018B4B8070-0x000000018B4B80F0 0x000000018B4B7FEC-0x000000018B4B8070
		public bool lockBoundGraphFromInstance { get; set; } // 0x00000001840A27C0-0x00000001840A27D0 0x0000000184C96FC0-0x0000000184C97060
		public bool preInitializeSubGraphs { get; set; } // 0x000000018B4B73A4-0x000000018B4B73F0 0x0000000184C961F0-0x0000000184C96200
		public FirstActivation firstActivation { get; set; } // 0x000000018B4B7A1C-0x000000018B4B7A2C 0x0000000184C96340-0x0000000184C96400
		public EnableAction enableAction { get; set; } // 0x000000018B4B7704-0x000000018B4B77B8 0x000000018B4B793C-0x000000018B4B7A1C
		public DisableAction disableAction { get; set; } // 0x000000018B4B72D8-0x000000018B4B73A4 0x000000018B4B71D4-0x000000018B4B7288
		public NodeCanvas.Framework.Graph.UpdateMode updateMode { get; set; } // 0x000000018B4B7A2C-0x000000018B4B7AF0 0x000000018B4B7ED4-0x000000018B4B7F58
		public bool graphIsBound { get; } // 0x000000018B4B77B8-0x000000018B4B77E4 
		public bool isRunning { get; } // 0x000000018B4B789C-0x000000018B4B793C 
		public bool isPaused { get; } // 0x000000018B4B77E4-0x000000018B4B789C 
		public float elapsedTime { get; }
		public virtual bool canEditNonPersistantBoundGraph { get; }
	
		// Events
		public event Action onMonoBehaviourStart;
	
		// Nested types
		public enum EnableAction // TypeDefIndex: 49155
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}
	
		public enum DisableAction // TypeDefIndex: 49156
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}
	
		public enum FirstActivation // TypeDefIndex: 49157
		{
			OnEnable = 0,
			OnStart = 1,
			Async = 2
		}
	
		public class SubInfo // TypeDefIndex: 49158
		{
			// Fields
			public NodeCanvas.Framework.Graph graph; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public NodeCanvas.Framework.Graph parentGraph; // 0x20
			public string name; // 0x28
			public IGraphAssignable assignable; // 0x30
			public bool isSuc; // 0x38
	
			// Constructors
			public SubInfo() {} // 0x00000001813B8590-0x00000001813B85A0
		}
	
		private sealed class __c__DisplayClass95_0 // TypeDefIndex: 49159
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public Action callBack; // 0x18
			public Action __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass95_0() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
	
			// Methods
			internal void _StartBehaviourAsync_b__0(NodeCanvas.Framework.Graph instance) {} // 0x000000018B4B7D30-0x000000018B4B7ED4
			internal void _StartBehaviourAsync_b__1() {} // 0x000000018B4B7BDC-0x000000018B4B7D30
		}
	
		private sealed class __c__DisplayClass96_0 // TypeDefIndex: 49160
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public bool isSuc; // 0x20
			public NodeCanvas.Framework.Graph clone; // 0x28
	
			// Constructors
			public __c__DisplayClass96_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _GetInstanceAsync_b__0() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct _GetInstanceAsync_d__96 : IAsyncStateMachine // TypeDefIndex: 49161
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public GraphOwner __4__this; // 0x28
			public NodeCanvas.Framework.Graph originalGraph; // 0x30
			public Action<NodeCanvas.Framework.Graph> callBack; // 0x38
			private __c__DisplayClass96_0 __8__1; // 0x40
			private System.Threading.Tasks.Task _task_5__2; // 0x48
			private float _start_5__3; // 0x50
			private YieldAwaitable.YieldAwaiter __u__1; // 0x54
	
			// Methods
			private void MoveNext() {} // 0x000000018B4B7F58-0x000000018B4B7FEC
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B4B8104-0x000000018B4B8198
		}
	
		private sealed class __c__DisplayClass97_0 // TypeDefIndex: 49162
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public List<SubInfo> subInfos; // 0x18
	
			// Constructors
			public __c__DisplayClass97_0() {}
	
			// Methods
			internal void _CreateSubInstanceAsync_b__0() {}
		}
	
		private struct _CreateSubInstanceAsync_d__97 : IAsyncStateMachine // TypeDefIndex: 49163
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public GraphOwner __4__this; // 0x28
			public Action callBack; // 0x30
			private __c__DisplayClass97_0 __8__1; // 0x38
			private System.Threading.Tasks.Task _task_5__2; // 0x40
			private float _start_5__3; // 0x48
			private YieldAwaitable.YieldAwaiter __u__1; // 0x4C
	
			// Methods
			private void MoveNext() {}
			private void SetStateMachine(IAsyncStateMachine stateMachine) {}
		}
	
		private sealed class __c__DisplayClass105_0<T> // TypeDefIndex: 49164
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass105_0() {}
	
			// Methods
			internal bool _GetExposedParameterValue_b__0(ExposedParameter x) => default; // 0x0000000185FB0950-0x0000000185FB0960
		}
	
		private sealed class __c__DisplayClass106_0<T> // TypeDefIndex: 49165
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass106_0() {} // 0x0000000185FB0970-0x0000000185FB0980
	
			// Methods
			internal bool _SetExposedParameterValue_b__0(ExposedParameter x) => default; // 0x0000000185FB3060-0x0000000185FB3070
		}
	
		// Constructors
		protected GraphOwner() {}
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185FBD4E0-0x0000000185FBD4F0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001813ECF20-0x00000001813ECF30
		protected virtual void OnBeforeSerializeDoExtra() {} // 0x000000018571FEC0-0x000000018571FED0
		protected virtual void OnAfterDeserializeDoExtra() {} // 0x00000001813ECBC0-0x00000001813ECBD0
		protected NodeCanvas.Framework.Graph GetInstance(NodeCanvas.Framework.Graph originalGraph) => default;
		public NodeCanvas.Framework.Graph MakeRuntimeGraphInstance() => default;
		public void StartBehaviour() {} // 0x0000000184C96190-0x0000000184C961A0
		public void StartBehaviour(Action<bool> callback) {} // 0x0000000184C96270-0x0000000184C96340
		public void StartBehaviour(NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null) {} // 0x000000018B4B70E4-0x000000018B4B71D4
		public void PauseBehaviour() {} // 0x000000018B4B7B58-0x000000018B4B7BDC
		public void StartBehaviourAsync(Action callBack) {} // 0x0000000184C961A0-0x0000000184C961F0
		protected void GetInstanceAsync(NodeCanvas.Framework.Graph originalGraph, Action<NodeCanvas.Framework.Graph> callBack) {} // 0x0000000185FA2870-0x0000000185FA28A0
		public void CreateSubInstanceAsync(Action callBack) {} // 0x0000000185FA28A0-0x0000000185FA28C0
		public void StopBehaviour(bool success = true /* Metadata: 0x02060E2D */) {} // 0x000000018B4B76D0-0x000000018B4B7704
		public void UpdateBehaviour() {} // 0x000000018B4B7288-0x000000018B4B72D8
		public void RestartBehaviour() {} // 0x000000018B4B73F0-0x000000018B4B76D0
		public void SendEvent(string eventName) {} // 0x00000001858D7020-0x00000001858D70E0
		public void SendEvent(string eventName, object value, object sender) {} // 0x000000018B4B7AF0-0x000000018B4B7B58
		public void SendEvent<T>(string eventName, T eventValue, object sender) {} // 0x0000000185492010-0x0000000185492020
		public T GetExposedParameterValue<T>(string name) => default; // 0x0000000185492010-0x0000000185492020
		public void SetExposedParameterValue<T>(string name, T value) {} // 0x000000018B4C72B0-0x000000018B4C73AC
		public ExposedParameter MakeNewExposedParameter<T>(string name) => default; // 0x000000018B4C73AC-0x000000018B4C747C
		protected virtual void Awake() {} // 0x0000000185492010-0x0000000185492020
		public void Initialize() {} // 0x000000018B4C747C-0x000000018B4C74C8
		public void BindExposedParameters() {} // 0x000000018B4C57FC-0x000000018B4C5F9C
		public void UnBindExposedParameters() {} // 0x0000000186475504-0x0000000186475510
		protected virtual void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void Start() {} // 0x000000018B4C74C8-0x000000018B4C75C0
		private void InvokeStartEvent() {} // 0x000000018B4C4744-0x000000018B4C55BC
		protected virtual void OnDisable() {} // 0x0000000186475504-0x0000000186475510
		public void DestroyInstance() {}
		protected virtual void OnDestroy() {}
		private void _Initialize_b__109_0() {}
	}

	public abstract class GraphOwner<T> : GraphOwner // TypeDefIndex: 49167
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		private T _graph;
		private UnityEngine.Object _blackboard;
	
		// Properties
		public sealed override NodeCanvas.Framework.Graph graph { get; set; }
		public T behaviour { get; set; }
		public sealed override IBlackboard blackboard { get; set; }
		public sealed override System.Type graphType { get; }
	
		// Constructors
		protected GraphOwner() {}
	
		// Methods
		public void StartBehaviour(T newGraph) {}
		public void StartBehaviour(T newGraph, Action<bool> callback) {}
		public void StartBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null) {}
		public void SwitchBehaviour(T newGraph) {}
		public void SwitchBehaviour(T newGraph, Action<bool> callback) {}
		public void SwitchBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null) {}
	}

	public static class IGraphAssignableExtensions // TypeDefIndex: 49169
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 49168
		{
			// Fields
			public IGraphAssignable assignable; // 0x10
			public Action<bool> callback; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B4B9898-0x000000018B4B9A70
	
			// Methods
			internal void _TryStartSubGraph_b__0(bool result) {} // 0x000000018B4B9DD0-0x000000018B4B9F7C
		}
	
		// Methods
		public static NodeCanvas.Framework.Graph CheckInstance(IGraphAssignable assignable) => default; // 0x000000018B4B9F7C-0x000000018B4BA004
		public static bool TryStartSubGraph(IGraphAssignable assignable, Component agent, Action<bool> callback = null) => default; // 0x000000018B4B9A70-0x000000018B4B9AF4
		public static bool TryStopSubGraph(IGraphAssignable assignable) => default; // 0x000000018B4B9AF4-0x000000018B4B9B78
		public static bool TryClearSubGraphData(IGraphAssignable assignable) => default; // 0x000000018B4B9D4C-0x000000018B4B9DD0
		public static bool TryPauseSubGraph(IGraphAssignable assignable) => default; // 0x000000018B4BA004-0x000000018B4BA0B4
		public static bool TryResumeSubGraph(IGraphAssignable assignable) => default; // 0x000000018B4BA0B4-0x000000018B4BA2D0
		public static bool TryUpdateSubGraph(IGraphAssignable assignable) => default; // 0x000000018B4B9B78-0x000000018B4B9D4C
		public static void TryWriteAndBindMappedVariables(IGraphAssignable assignable) {} // 0x000000018B4BA2D0-0x000000018B4BA3C8
		public static void TryReadAndUnbindMappedVariables(IGraphAssignable assignable) {} // 0x0000000185492010-0x0000000185492020
		public static void ValidateSubGraphAndParameters(IGraphAssignable assignable) {} // 0x000000018B4C6DF8-0x000000018B4C6E50
	}

	public interface IGraphElement // TypeDefIndex: 49170
	{
		// Properties
		string name { get; }
		string UID { get; }
		NodeCanvas.Framework.Graph graph { get; }
		NodeCanvas.Framework.Status status { get; }
	}

	public interface IUpdatable : IGraphElement // TypeDefIndex: 49171
	{
		// Methods
		void Update();
	}

	public interface IInvokable : IGraphElement // TypeDefIndex: 49172
	{
		// Methods
		string GetInvocationID();
		object Invoke(object[] args);
		void InvokeAsync(Action<object> callback, object[] args);
	}

	public interface IGraphAssignable : IGraphElement // TypeDefIndex: 49173
	{
		// Properties
		NodeCanvas.Framework.Graph subGraph { get; set; }
		NodeCanvas.Framework.Graph currentInstance { get; set; }
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		BBParameter subGraphParameter { get; }
		List<BBMappingParameter> variablesMap { get; set; }
	}

	public interface IGraphAssignable<T> : IGraphAssignable // TypeDefIndex: 49174
		where T : NodeCanvas.Framework.Graph
	{
		// Properties
		T subGraph { get; set; }
		T currentInstance { get; set; }
	}

	public interface ITaskAssignable : IGraphElement // TypeDefIndex: 49175
	{
		// Properties
		NodeCanvas.Framework.Task task { get; set; }
	}

	public interface ITaskAssignable<T> : ITaskAssignable // TypeDefIndex: 49176
		where T : NodeCanvas.Framework.Task
	{
	}

	public interface IHaveNodeReference : IGraphElement // TypeDefIndex: 49177
	{
		// Properties
		INodeReference targetReference { get; }
	}

	public interface IReflectedWrapper // TypeDefIndex: 49178
	{
		// Methods
		ISerializedReflectedInfo GetSerializedInfo();
	}

	public interface ISubTasksContainer // TypeDefIndex: 49179
	{
		// Methods
		NodeCanvas.Framework.Task[] GetSubTasks();
	}

	public interface ISubParametersContainer // TypeDefIndex: 49180
	{
		// Methods
		BBParameter[] GetSubParameters();
	}

	[Serializable]
	public abstract class Node : IGraphElement, ISerializationCollectable // TypeDefIndex: 49187
	{
		// Fields
		public float additionalWidth; // 0x10
		private string _UID; // 0x18
		private string _name; // 0x20
		private string _tag; // 0x28
		private Vector2 _position; // 0x30
		private string _comment; // 0x38
		private bool _isBreakpoint; // 0x40
		private NodeCanvas.Framework.Graph _graph; // 0x48
		private int _ID; // 0x50
		private List<Connection> _inConnections; // 0x58
		private List<Connection> _outConnections; // 0x60
		[NonSerialized]
		private NodeCanvas.Framework.Status _status; // 0x68
		[NonSerialized]
		private string _nameCache; // 0x70
		[NonSerialized]
		private string _descriptionCache; // 0x78
		[NonSerialized]
		private int _priorityCache; // 0x80
		private readonly bool _allowResizeHorizontal_k__BackingField; // 0x84
		private bool _canResizeHorizontal_k__BackingField; // 0x85
		private bool _resizingHorizontal_k__BackingField; // 0x86
		private bool _isHighlight_k__BackingField; // 0x87
		[NonSerialized]
		public float highlightColorFade; // 0x88
		private float _timeStarted_k__BackingField; // 0x8C
		private bool _isChecked_k__BackingField; // 0x90
		private bool _breakPointReached_k__BackingField; // 0x91
	
		// Properties
		protected virtual float? overrideNodeWidth { get; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public NodeCanvas.Framework.Graph graph { get; internal set; } // 0x0000000185A16440-0x0000000185A16450 0x00000001813ECBC0-0x00000001813ECBD0
		public int ID { get; internal set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x00000001814A81B0-0x00000001814A81C0
		public string UID { get; } // 0x000000018B4BBBB8-0x000000018B4BBBF0 
		public List<Connection> inConnections { get; protected set; } // 0x000000018B4BBBF0-0x000000018B4BBCE8 0x000000018646EE40-0x000000018646EE50
		public List<Connection> outConnections { get; protected set; } // 0x000000018B4BBA00-0x000000018B4BBAA8 0x000000018B4BBD90-0x000000018B4BBE28
		public Vector2 position { get; set; }
		private string customName { get; set; }
		public string tag { get; set; }
		public string comments { get; set; } // 0x00000001814A81B0-0x00000001814A81C0
		public string commentForShow { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public string rawComment { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public virtual bool modifyComment { get; } // 0x0000000185FB2E40-0x0000000185FB2E50 
		public virtual string modifiedComment { get; } // 0x0000000185FB3330-0x0000000185FB3340 
		public virtual bool isBreakpoint { get; set; } // 0x0000000185FD2BB0-0x0000000185FD2BC0 0x0000000185FB2E80-0x0000000185FB2E90
		public virtual string name { get; set; } // 0x0000000185FD2BD0-0x0000000185FD2BE0 0x00000001840A27C0-0x00000001840A27D0
		public virtual string description { get; } // 0x000000018B4BBD58-0x000000018B4BBD90 
		public virtual int priority { get; } // 0x000000018B4BBCE8-0x000000018B4BBD20 
		public abstract int maxInConnections { get; } // 0x000000018B4BBD20-0x000000018B4BBD58 
		public abstract int maxOutConnections { get; } // 0x0000000185FD2BA0-0x0000000185FD2BB0 
		public abstract System.Type outConnectionType { get; } // 0x0000000185FD2BC0-0x0000000185FD2BD0 
		public abstract bool allowAsPrime { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public abstract bool canSelfConnect { get; } // 0x0000000185FB0B00-0x0000000185FB0B10 
		public abstract Alignment2x2 commentsAlignment { get; } // 0x000000018B4BBE28-0x000000018B4BBE58 
		public abstract Alignment2x2 iconAlignment { get; } // 0x000000018B4BBAD8-0x000000018B4BBB48 
		public virtual bool isBeyondGraph { get; } // 0x000000018B4BBB48-0x000000018B4BBBB8 
		public virtual bool drawInspector { get; } // 0x000000018B4BBAA8-0x000000018B4BBAD8 
		public virtual bool inspectorShowTag { get; } // 0x0000000185FB9D60-0x0000000185FB9D70 
		public virtual bool allowResizeHorizontal { get; } // 0x0000000185FD2740-0x0000000185FD2750 
		public bool canResizeHorizontal { get; set; } // 0x0000000185FB2250-0x0000000185FB2260 0x0000000185FB2260-0x0000000185FB2270
		public bool resizingHorizontal { get; set; } // 0x0000000185FB2070-0x0000000185FB2080 0x0000000185FB2090-0x0000000185FB20A0
		public virtual bool allowDragInContentRect { get; } // 0x000000018B4BB904-0x000000018B4BB9C8 
		public virtual string nodeIconKey { get; } // 0x000000018B4BA6E0-0x000000018B4BA87C 
		public virtual string nodeIconKey2 { get; } // 0x000000018B4BA87C-0x000000018B4BABC8 
		public virtual string nodeIconKey3 { get; } // 0x000000018B4BB7A8-0x000000018B4BB8A8 
		public virtual bool isHighlight { get; set; } // 0x000000018B4BAC7C-0x000000018B4BACF4 0x000000018B4BB3CC-0x000000018B4BB490
		public virtual bool drawNameTagOrComment { get; } // 0x000000018B4BB8A8-0x000000018B4BB904 
		public NodeCanvas.Framework.Status status { get; protected set; } // 0x000000018B4BABC8-0x000000018B4BAC7C 0x000000018B4BACF4-0x000000018B4BAD0C
		public Component graphAgent { get; } // 0x0000000185492010-0x0000000185492020 
		public IBlackboard graphBlackboard { get; } // 0x000000018B48B928-0x000000018B48B930 
		public float elapsedTime { get; } // 0x000000018B4BB490-0x000000018B4BB4C0 
		private float timeStarted { get; set; } // 0x000000018B4BB234-0x000000018B4BB300
		private bool isChecked { get; set; } // 0x00000001840A27C0-0x00000001840A27D0 0x00000001840A27C0-0x00000001840A27D0
		private bool breakPointReached { get; set; } // 0x000000018B4BA584-0x000000018B4BA6E0 0x000000018B4BB4C0-0x000000018B4BB540
	
		// Nested types
		protected class AutoSortWithChildrenConnections : Attribute // TypeDefIndex: 49181
		{
			// Constructors
			public AutoSortWithChildrenConnections() {} // 0x00000001813AE580-0x00000001813AE590
		}
	
		private sealed class _YieldBreak_d__137 : IEnumerator<object> // TypeDefIndex: 49182
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action resume; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FB06B0-0x0000000185FB06C0 
			object IEnumerator.Current { get => default; } // 0x000000018B4BA550-0x000000018B4BA584 
	
			// Constructors
			public _YieldBreak_d__137() {} // Dummy constructor
			public _YieldBreak_d__137(int __1__state) {} // 0x00000001813ECF20-0x00000001813ECF30
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018571FEC0-0x000000018571FED0
			private bool MoveNext() => default; // 0x0000000185FB0680-0x0000000185FB0690
			void IEnumerator.Reset() {} // 0x000000018B4BB9C8-0x000000018B4BBA00
		}
	
		private sealed class __c__DisplayClass147_0 // TypeDefIndex: 49183
		{
			// Fields
			public Node b; // 0x10
			public Node a; // 0x18
	
			// Constructors
			public __c__DisplayClass147_0() {} // 0x00000001831DAB30-0x00000001831DAB90
	
			// Methods
			internal bool _AreNodesConnected_b__0(Connection c) => default; // 0x00000001813F1630-0x00000001813F1640
			internal bool _AreNodesConnected_b__1(Connection c) => default; // 0x0000000186472DB0-0x0000000186472DC0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49184
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Connection, Node> __9__152_0; // 0x08
			public static Func<Connection, Node> __9__153_0; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000185FB0530-0x0000000185FB0540
			public __c() {} // 0x0000000185AE8FE0-0x0000000185AE8FF0
	
			// Methods
			internal Node _GetParentNodes_b__152_0(Connection c) => default; // 0x0000000185FCA300-0x0000000185FCA320
			internal Node _GetChildNodes_b__153_0(Connection c) => default; // 0x00000001813B51E0-0x00000001813B51F0
		}
	
		private sealed class __c__DisplayClass154_0 // TypeDefIndex: 49185
		{
			// Fields
			public Node parentNode; // 0x10
	
			// Constructors
			public __c__DisplayClass154_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal bool _IsChildOf_b__0(Connection c) => default; // 0x000000018646EE40-0x000000018646EE50
		}
	
		private sealed class __c__DisplayClass155_0 // TypeDefIndex: 49186
		{
			// Fields
			public Node childNode; // 0x10
	
			// Constructors
			public __c__DisplayClass155_0() {} // 0x00000001813B8590-0x00000001813B85A0
	
			// Methods
			internal bool _IsParentOf_b__0(Connection c) => default; // 0x0000000184A4EDC0-0x0000000184A4EDD0
		}
	
		// Constructors
		public Node() {} // 0x000000018B4BB540-0x000000018B4BB5BC
	
		// Methods
		protected virtual string AllocateUID() => default; // 0x0000000185FB0650-0x0000000185FB0660
		public void SetUID(string value) {} // 0x0000000185FB0660-0x0000000185FB0670
		public static Node Create(NodeCanvas.Framework.Graph targetGraph, System.Type nodeType, Vector2 pos) => default; // 0x0000000185492010-0x0000000185492020
		public Node Duplicate(NodeCanvas.Framework.Graph targetGraph) => default; // 0x0000000185492010-0x0000000185492020
		public void Validate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B4BAF70-0x000000018B4BB0B8
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4BAD0C-0x000000018B4BAE54
		public void Reset(bool recursively = true /* Metadata: 0x02060E36 */) {} // 0x000000018B4BB168-0x000000018B4BB234
		private IEnumerator YieldBreak(Action resume) => default; // 0x000000018B4BB300-0x000000018B4BB3CC
		public NodeCanvas.Framework.Status Error(object msg) => default; // 0x000000018B4BB0B8-0x000000018B4BB168
		public NodeCanvas.Framework.Status Fail(string msg) => default; // 0x000000018B4BAE54-0x000000018B4BAF70
		public void Warn(string msg) {} // 0x0000000185FB0B00-0x0000000185FB0B10
		public void SetStatus(NodeCanvas.Framework.Status status) {} // 0x0000000185492010-0x0000000185492020
		protected void SendEvent(string eventName) {} // 0x0000000185492010-0x0000000185492020
		protected void SendEvent<T>(string eventName, T value) {} // 0x0000000185492010-0x0000000185492020
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null) => default; // 0x0000000185492010-0x0000000185492020
		protected virtual bool CanConnectToTarget(Node targetNode) => default; // 0x0000000185492010-0x0000000185492020
		protected virtual bool CanConnectFromSource(Node sourceNode) => default; // 0x0000000185492010-0x0000000185492020
		public static bool AreNodesConnected(Node a, Node b) => default; // 0x0000000185492010-0x0000000185492020
		public Coroutine StartCoroutine(IEnumerator routine) => default; // 0x0000000185492010-0x0000000185492020
		public void StopCoroutine(Coroutine routine) {} // 0x0000000185492010-0x0000000185492020
		public void StartParallelTask(Action action) {} // 0x0000000185492010-0x0000000185492020
		public void StopParallelTask(Action action) {} // 0x0000000185492010-0x0000000185492020
		public IEnumerable<Node> GetParentNodes() => default; // 0x0000000185492010-0x0000000185492020
		public IEnumerable<Node> GetChildNodes() => default; // 0x0000000185492010-0x0000000185492020
		public bool IsChildOf(Node parentNode) => default; // 0x0000000185492010-0x0000000185492020
		public bool IsParentOf(Node childNode) => default; // 0x0000000185492010-0x0000000185492020
		internal virtual string GetWarningOrError() => default; // 0x0000000185492010-0x0000000185492020
		private string GetHardError() => default; // 0x0000000185492010-0x0000000185492020
		protected virtual NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018B4BB5BC-0x000000018B4BB7A8
		protected virtual void OnReset() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnCreate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x0000000181378230-0x0000000181378240
		public virtual void OnDuplicate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x0000000183E63300-0x0000000183E636E0
		public virtual void OnDestroy() {} // 0x0000000181377E40-0x0000000181377E50
		public virtual void OnParentConnected(int connectionIndex) {} // 0x0000000183E636E0-0x0000000183E64050
		public virtual void OnParentDisconnected(int connectionIndex) {} // 0x0000000181377E40-0x0000000181377E50
		public virtual void OnChildConnected(int connectionIndex) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnChildDisconnected(int connectionIndex) {} // 0x0000000183075960-0x00000001830766F0
		public virtual void OnChildrenConnectionsSorted(int[] oldIndeces) {} // 0x0000000183E632C0-0x0000000183E632E0
		public virtual void OnGraphStarted() {} // 0x000000018B4C7624-0x000000018B4C7688
		public virtual void OnPostGraphStarted() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphStoped() {} // 0x0000000183E632A0-0x0000000183E632C0
		public virtual void OnPostGraphStoped() {} // 0x0000000183E63280-0x0000000183E632A0
		public virtual void OnGraphPaused() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphUnpaused() {} // 0x0000000183E632E0-0x0000000183E63300
		public virtual void OnClearNodeData() {} // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x0000000183075960-0x00000001830766F0
	}

	public interface INodeReference // TypeDefIndex: 49188
	{
		// Properties
		System.Type type { get; }
	
		// Methods
		NodeCanvas.Framework.Node Get(NodeCanvas.Framework.Graph graph);
		void Set(NodeCanvas.Framework.Node target);
	}

	[Serializable]
	public class NodeReference<T> : INodeReference // TypeDefIndex: 49190
		where T : NodeCanvas.Framework.Node
	{
		// Fields
		private string _targetNodeUID;
		[NonSerialized]
		private WeakReference<T> _targetNodeRef;
	
		// Properties
		System.Type INodeReference.type { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 49189
		{
			// Fields
			public NodeReference<T> _this;
	
			// Constructors
			public __c__DisplayClass8_0() {}
	
			// Methods
			internal bool _Get_b__0(T x) => default;
		}
	
		// Constructors
		public NodeReference() {}
		public NodeReference(T target) {}
	
		// Methods
		NodeCanvas.Framework.Node INodeReference.Get(NodeCanvas.Framework.Graph graph) => default;
		void INodeReference.Set(NodeCanvas.Framework.Node target) {}
		public T Get(NodeCanvas.Framework.Graph graph) => default;
		public void Set(T target) {}
	}

	public enum Status // TypeDefIndex: 49191
	{
		Failure = 0,
		Success = 1,
		Running = 2,
		Resting = 3,
		Error = 4,
		Optional = 5
	}

	public class ActionList : ActionTask // TypeDefIndex: 49193
	{
		// Fields
		public ActionsExecutionMode executionMode; // 0x68
		public List<ActionTask> actions; // 0x70
		private int currentActionIndex; // 0x78
		private bool[] finishedIndeces; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4B313C-0x000000018B4B3314 
	
		// Nested types
		public enum ActionsExecutionMode // TypeDefIndex: 49192
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}
	
		// Constructors
		public ActionList() {} // 0x000000018B4B30BC-0x000000018B4B313C
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem) => default; // 0x000000018B4B294C-0x000000018B4B2B2C
		protected override string OnInit() => default; // 0x000000018B4B2CB8-0x000000018B4B2D24
		protected override void OnExecute() {} // 0x000000018B4B2C50-0x000000018B4B2CB8
		protected override void OnUpdate() {} // 0x000000018B4B2E6C-0x000000018B4B30BC
		protected override void OnStop() {} // 0x000000018B4B2DC0-0x000000018B4B2E6C
		protected override void OnPause() {} // 0x000000018B4B2D24-0x000000018B4B2DC0
		public override void OnDrawGizmosSelected() {} // 0x000000018B4B2BB0-0x000000018B4B2C50
		public void AddAction(ActionTask action) {} // 0x000000018B4B2764-0x000000018B4B294C
		internal override string GetWarningOrError() => default; // 0x000000018B4B2B2C-0x000000018B4B2BB0
	}

	public abstract class ActionTask<T> : ActionTask // TypeDefIndex: 49194
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ActionTask() {}
	}

	public abstract class ActionTask : NodeCanvas.Framework.Task // TypeDefIndex: 49196
	{
		// Fields
		private NodeCanvas.Framework.Status status; // 0x58
		private float timeStarted; // 0x5C
		private bool latch; // 0x60
		private bool _isPaused_k__BackingField; // 0x61
	
		// Properties
		public float elapsedTime { get; } // 0x000000018B4B33FC-0x000000018B4B3404 
		public bool isRunning { get; } // 0x000000018B4B3484-0x000000018B4B3514 
		public bool isPaused { get; private set; } // 0x000000018B487EBC-0x000000018B487EC8 0x000000018B4B33AC-0x000000018B4B33FC
	
		// Nested types
		private sealed class _IndependentActionUpdater_d__12 : IEnumerator<object> // TypeDefIndex: 49195
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ActionTask __4__this; // 0x20
			public Component agent; // 0x28
			public IBlackboard blackboard; // 0x30
			public Action<NodeCanvas.Framework.Status> callback; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FBCA60-0x0000000185FBCA70 
			object IEnumerator.Current { get => default; } // 0x000000018B4B3514-0x000000018B4B35BC 
	
			// Constructors
			public _IndependentActionUpdater_d__12() {} // Dummy constructor
			public _IndependentActionUpdater_d__12(int __1__state) {} // 0x000000018B4B35D4-0x000000018B4B3608
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4B3608-0x000000018B4B3610
			private bool MoveNext() => default; // 0x0000000185FB32C0-0x0000000185FB32D0
			void IEnumerator.Reset() {} // 0x000000018B4B3404-0x000000018B4B3484
		}
	
		// Constructors
		protected ActionTask() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void ExecuteIndependent(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback) {} // 0x000000018B4B3314-0x000000018B4B33AC
		private IEnumerator IndependentActionUpdater(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback) => default; // 0x000000018B4B35BC-0x000000018B4B35D4
		public NodeCanvas.Framework.Status ExecuteAction(Component agent, IBlackboard blackboard) => default; // 0x0000000185492010-0x0000000185492020
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard) => default; // 0x0000000185492010-0x0000000185492020
		public void EndAction() {} // 0x0000000184635910-0x0000000184635CB0
		public void EndAction(bool success) {} // 0x0000000185492010-0x0000000185492020
		public void EndAction(bool? success) {} // 0x0000000185492010-0x0000000185492020
		public void Pause() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnExecute() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
		protected virtual void OnUpdate() {} // 0x0000000181378230-0x0000000181378240
		protected virtual void OnStop(bool interrupted) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnStop() {} // 0x000000018B4C67C0-0x000000018B4C683C
		protected virtual void OnPause() {} // 0x0000000181377E40-0x0000000181377E50
		protected virtual void OnResume() {} // 0x000000018B4C683C-0x000000018B4C6888
	}

	public class ConditionList : ConditionTask // TypeDefIndex: 49198
	{
		// Fields
		public ConditionsCheckMode checkMode; // 0x68
		public List<ConditionTask> conditions; // 0x70
	
		// Properties
		private bool allTrueRequired { get => default; } // 0x000000018B4B62F4-0x000000018B4B62FC 
		protected override string info { get => default; } // 0x000000018B4B62FC-0x000000018B4B64F8 
	
		// Nested types
		public enum ConditionsCheckMode // TypeDefIndex: 49197
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}
	
		// Constructors
		public ConditionList() {} // 0x000000018B4B6278-0x000000018B4B62F4
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem) => default; // 0x000000018B4B5D98-0x000000018B4B5F78
		protected override void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnDisable() {} // 0x000000018B4B615C-0x000000018B4B61D8
		protected override bool OnCheck() => default; // 0x000000018B4B5FFC-0x000000018B4B615C
		public override void OnDrawGizmosSelected() {} // 0x000000018B4B61D8-0x000000018B4B6278
		public void AddCondition(ConditionTask condition) {} // 0x000000018B4B5BB0-0x000000018B4B5D98
		internal override string GetWarningOrError() => default; // 0x000000018B4B5F78-0x000000018B4B5FFC
	}

	public abstract class ConditionTask<T> : ConditionTask // TypeDefIndex: 49199
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ConditionTask() {}
	}

	public abstract class ConditionTask : NodeCanvas.Framework.Task // TypeDefIndex: 49201
	{
		// Fields
		private bool _invert; // 0x58
		private int yieldReturn; // 0x5C
		private int yields; // 0x60
		private bool isRuntimeEnabled; // 0x64
	
		// Properties
		public bool invert { get; set; } // 0x000000018B4B6500-0x000000018B4B6550 0x000000018B4B6674-0x000000018B4B66AC
	
		// Nested types
		private sealed class _Flip_d__13 : IEnumerator<object> // TypeDefIndex: 49200
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConditionTask __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4B65C0-0x000000018B4B65E0 
			object IEnumerator.Current { get => default; } // 0x000000018B4B6550-0x000000018B4B65C0 
	
			// Constructors
			public _Flip_d__13() {} // Dummy constructor
			public _Flip_d__13(int __1__state) {} // 0x0000000181BE64B0-0x0000000181BE64C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181BE64C0-0x0000000181BE64D0
			private bool MoveNext() => default; // 0x000000018B4B65E0-0x000000018B4B6618
			void IEnumerator.Reset() {} // 0x000000018B4B64F8-0x000000018B4B6500
		}
	
		// Constructors
		protected ConditionTask() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void Enable(Component agent, IBlackboard bb) {} // 0x000000018B4B6618-0x000000018B4B6674
		public void Disable() {} // 0x0000000185492010-0x0000000185492020
		public bool CheckCondition(Component agent, IBlackboard blackboard) => default; // 0x0000000185492010-0x0000000185492020
		public bool Check(Component agent, IBlackboard blackboard) => default; // 0x00000001840A27C0-0x00000001840A27D0
		public bool CheckOnce(Component agent, IBlackboard blackboard) => default; // 0x0000000185FB89B0-0x0000000185FB89C0
		protected void YieldReturn(bool value, bool keepValueUntilUsed = false /* Metadata: 0x02060E41 */) {} // 0x0000000181378230-0x0000000181378240
		private IEnumerator Flip() => default; // 0x0000000185492010-0x0000000185492020
		protected virtual void OnEnable() {} // 0x000000018B4C55BC-0x000000018B4C561C
		protected virtual void OnDisable() {} // 0x0000000181377E40-0x0000000181377E50
		protected virtual bool OnCheck() => default; // 0x000000018B4C561C-0x000000018B4C5668
	}

	public class EventReceiverAttribute : Attribute // TypeDefIndex: 49202
	{
		// Fields
		public readonly string[] eventMessages; // 0x10
	
		// Constructors
		public EventReceiverAttribute() {} // Dummy constructor
		public EventReceiverAttribute(string[] args) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public interface ITaskSystem // TypeDefIndex: 49203
	{
		// Properties
		Component agent { get; }
		IBlackboard blackboard { get; }
		UnityEngine.Object contextObject { get; }
		float elapsedTime { get; }
		float deltaTime { get; }
	
		// Methods
		void UpdateTasksOwner();
		void SendEvent(string name, object value, object sender);
		void SendEvent<T>(string name, T value, object sender);
	}

	[Serializable]
	public abstract class Task : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 49205
	{
		// Fields
		private bool _isUserDisabled; // 0x10
		protected internal TaskAgentParameter _agentParameter; // 0x18
		private ITaskSystem _ownerSystem; // 0x20
		private Component _currentAgent; // 0x28
		private string _taskName; // 0x30
		private string _taskDescription; // 0x38
		private string _obsoleteInfo; // 0x40
		private bool _isRuntimeActive; // 0x48
		private bool _isInitSuccess; // 0x49
		private EventRouter _eventRouter; // 0x50
	
		// Properties
		public ITaskSystem ownerSystem { get; private set; } // 0x000000018646EE40-0x000000018646EE50 0x000000018B4C43A4-0x000000018B4C4418
		public Component ownerSystemAgent { get; } // 0x000000018B4C4418-0x000000018B4C4438 
		public IBlackboard ownerSystemBlackboard { get; } // 0x000000018B4C4438-0x000000018B4C4458 
		public float ownerSystemElapsedTime { get; } // 0x00000001855AD040-0x00000001855AD050 
		public bool isUserEnabled { get; internal set; } // 0x000000018B4C473C-0x000000018B4C4744 0x000000018B4C42F8-0x000000018B4C43A4
		public string obsolete { get; } // 0x000000018B4C421C-0x000000018B4C42F8 
		public string name { get; } // 0x000000018B4C4170-0x000000018B4C421C 
		public string description { get; } // 0x000000018B4C4538-0x000000018B4C4690 
		public string summaryInfo { get; } // 0x0000000181AD8650-0x0000000181AD8660 
		protected virtual string info { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual System.Type agentType { get; } // 0x000000018B4C4058-0x000000018B4C40A4 
		public string agentInfo { get; } // 0x000000018B4C40A4-0x000000018B4C40B8 
		public string agentParameterName { get; } // 0x00000001847EB9E0-0x00000001847EB9F0 
		public bool agentIsOverride { get; set; } // 0x000000018B4C4690-0x000000018B4C473C 0x000000018B4C40B8-0x000000018B4C4168
		public Component agent { get; } // 0x000000018B4C4168-0x000000018B4C4170 
		public IBlackboard blackboard { get; } // 0x000000018B4C4458-0x000000018B4C4538 
		public EventRouter router { get; } // 0x000000018B4C3D7C-0x000000018B4C3E94 
	
		// Nested types
		protected class GetFromAgentAttribute : Attribute // TypeDefIndex: 49204
		{
			// Constructors
			public GetFromAgentAttribute() {} // 0x000000018B4C3F98-0x000000018B4C4020
		}
	
		// Constructors
		public Task() {}
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000185492010-0x0000000185492020
		public static T Create<T>(ITaskSystem newOwnerSystem)
			where T : Task => default; // 0x000000018B4C31B8-0x000000018B4C32EC
		public static Task Create(System.Type type, ITaskSystem newOwnerSystem) => default; // 0x000000018B4C32EC-0x000000018B4C3384
		public virtual Task Duplicate(ITaskSystem newOwnerSystem) => default; // 0x000000018B4C4020-0x000000018B4C4058
		public void Validate(ITaskSystem ownerSystem) {} // 0x000000018646EE40-0x000000018646EE50
		public void SetOwnerSystem(ITaskSystem newOwnerSystem) {} // 0x00000001813B31A0-0x00000001813B31B0
		protected bool Set(Component newAgent, IBlackboard newBB) => default; // 0x000000018B4C3B88-0x000000018B4C3CDC
		private bool Initialize(Component newAgent) => default; // 0x000000018B4C3928-0x000000018B4C3B88
		private bool InitializeFieldAttributes(Component newAgent) => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected bool Error(string error, string tag = "Execution" /* Metadata: 0x02060E42 */) => default; // 0x000000018B4C3E94-0x000000018B4C3F14
		protected Coroutine StartCoroutine(IEnumerator routine) => default; // 0x000000018B4C3F14-0x000000018B4C3F90
		protected void StopCoroutine(Coroutine routine) {} // 0x000000018B4C3CEC-0x000000018B4C3D7C
		protected void SendEvent(string name) {}
		protected void SendEvent<T>(string name, T value) {} // 0x000000018B4C34A0-0x000000018B4C3928
		internal virtual string GetWarningOrError() => default; // 0x00000001813AE580-0x00000001813AE590
		protected virtual string OnErrorCheck() => default; // 0x000000018B4C3384-0x000000018B4C34A0
		private string GetHardError() => default; // 0x00000001813AE580-0x00000001813AE590
		protected virtual string OnInit() => default; // 0x0000000185492010-0x0000000185492020
		public virtual void OnCreate(ITaskSystem ownerSystem) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B4C3CDC-0x000000018B4C3CEC
		public virtual void OnDrawGizmos() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnDrawGizmosSelected() {} // 0x000000018B4C31A8-0x000000018B4C31B8
		public void ClearTaskData() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnClearTaskData() {} // 0x000000018B4C3F90-0x000000018B4C3F98
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class AssetBlackboard : ScriptableObject, ISerializationCallbackReceiver, IGlobalBlackboard // TypeDefIndex: 49206
	{
		// Fields
		private Action<Variable> onVariableAdded; // 0x18
		private Action<Variable> onVariableRemoved; // 0x20
		private string _serializedBlackboard; // 0x28
		private List<UnityEngine.Object> _objectReferences; // 0x30
		private string _UID; // 0x38
		[NonSerialized]
		private string _identifier; // 0x40
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x48
	
		// Properties
		Dictionary<string, Variable> IBlackboard.variables { get => default; set {} } // 0x000000018B4B3624-0x000000018B4B3640 0x000000018B4B3640-0x000000018B4B3664
		UnityEngine.Object IBlackboard.unityContextObject { get => default; } // 0x0000000185779060-0x0000000185779070 
		IBlackboard IBlackboard.parent { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		Component IBlackboard.propertiesBindTarget { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		string IBlackboard.independantVariablesFieldName { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public string identifier { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public string UID { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	
		// Events
		public event Action<Variable> onVariableAdded;
		public event Action<Variable> onVariableRemoved;
	
		// Constructors
		public AssetBlackboard() {} // 0x000000018B4B3914-0x000000018B4B39BC
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4B390C-0x000000018B4B3914
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4B3904-0x000000018B4B390C
		private void SelfSerialize() {} // 0x000000018B4B379C-0x000000018B4B38A4
		private void SelfDeserialize() {} // 0x000000018B4B36D8-0x000000018B4B379C
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable) {} // 0x0000000189D5AC38-0x0000000189D5AC4C
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable) {} // 0x000000018B4B3610-0x000000018B4B3624
		private void ShowJson() {} // 0x000000018B4B38A4-0x000000018B4B3904
		public override string ToString() => default; // 0x00000001813FF010-0x00000001813FF020
		private void OnValidate() {} // 0x000000018B4B36B4-0x000000018B4B36D8
		private void OnEnable() {} // 0x000000018B4B3664-0x000000018B4B36B4
	}

	[Serializable]
	public abstract class BBParameter : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 49208
	{
		// Fields
		private string _name; // 0x10
		private string _targetVariableID; // 0x18
		private IBlackboard _bb; // 0x20
		private Variable _varRef; // 0x28
		private Action<Variable> onVariableReferenceChanged; // 0x30
	
		// Properties
		public string targetVariableID { get; protected set; } // 0x00000001813B8590-0x00000001813B85A0 0x000000018B4B4B80-0x000000018B4B4BE4
		public Variable varRef { get; protected set; } // 0x000000018346D130-0x000000018346D140 0x000000018B4B4A60-0x000000018B4B4AE0
		public string name { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018B4B4A14-0x000000018B4B4A60
		public IBlackboard bb { get; set; } // 0x00000001882E0F9C-0x00000001882E0FA8 0x000000018B4B4AE0-0x000000018B4B4B6C
		public bool useBlackboard { get; set; } // 0x000000018B4B48A8-0x000000018B4B4950 0x000000018B4B483C-0x000000018B4B4884
		public bool isPresumedDynamic { get; } // 0x000000018B4B4884-0x000000018B4B48A8 
		public bool isNone { get; } // 0x000000018B4B480C-0x000000018B4B483C 
		public bool isNull { get; } // 0x00000001850AD3F0-0x00000001850AD410 
		public bool isNoneOrNull { get; } // 0x000000018B4B4950-0x000000018B4B4978 
		public bool isDefined { get; } // 0x000000018B4B4978-0x000000018B4B4988 
		public System.Type refType { get; } // 0x000000018B4B4B6C-0x000000018B4B4B80 
		public object value { get; set; }
		public abstract System.Type varType { get; }
	
		// Events
		public event Action<Variable> onVariableReferenceChanged;
	
		// Nested types
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 49207
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018B4B4768-0x000000018B4B4780
	
			// Methods
			internal void _SetBBFields_b__0(object o, fsData d) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public BBParameter() {} // 0x000000018B4B43A8-0x000000018B4B4498
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4B4780-0x000000018B4B480C
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4B4988-0x000000018B4B4A14
		public static BBParameter CreateInstance(System.Type t, IBlackboard bb) => default; // 0x0000000181377E40-0x0000000181377E50
		public static void SetBBFields(object target, IBlackboard bb) {} // 0x0000000184088E70-0x0000000184088E80
		protected abstract void SetDefaultValue();
		protected abstract void Bind(Variable data);
		public abstract object GetValueBoxed(); // 0x000000018B4B4498-0x000000018B4B45FC
		public abstract void SetValueBoxed(object value); // 0x000000018B4B4254-0x000000018B4B43A8
		public void SetTargetVariable(IBlackboard targetBB, Variable targetVariable) {} // 0x000000018B4B412C-0x000000018B4B4254
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID) => default; // 0x000000018B4B45FC-0x000000018B4B4768
		public Variable PromoteToVariable(IBlackboard targetBB) => default; // 0x0000000185492010-0x0000000185492020
		public sealed override string ToString() => default; // 0x000000018B4C6CCC-0x000000018B4C6D54
	}

	[Serializable]
	public class BBParameter<T> : BBParameter // TypeDefIndex: 49212
	{
		// Fields
		protected T _value;
		private Func<T> getter;
		private Action<T> setter;
	
		// Properties
		public new T value { get => default; set {} }
		public override System.Type varType { get => default; }
	
		// Events
		private event Func<T> getter;
		private event Action<T> setter;
	
		// Nested types
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 49209
		{
			// Fields
			public Func<object> convertFunc;
	
			// Constructors
			public __c__DisplayClass20_0() {}
	
			// Methods
			internal T _BindGetter_b__0() => default;
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 49210
		{
			// Fields
			public Action<object> convertFunc;
	
			// Constructors
			public __c__DisplayClass21_0() {}
	
			// Methods
			internal void _BindSetter_b__0(T value) {}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49211
		{
			// Fields
			public static readonly __c<T> __9;
			public static Action<T> __9__21_1;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal void _BindSetter_b__21_1(T value) {}
		}
	
		// Constructors
		public BBParameter() {}
		public BBParameter(T value) {}
	
		// Methods
		public override object GetValueBoxed() => default;
		public override void SetValueBoxed(object newValue) {}
		public T GetValue() => default;
		public void SetValue(T value) {}
		protected override void SetDefaultValue() {}
		protected override void Bind(Variable variable) {}
		private bool BindGetter(Variable variable) => default;
		private bool BindSetter(Variable variable) => default;
		public static implicit operator BBParameter<T>(T value) => default;
	}

	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard // TypeDefIndex: 49213
	{
		// Fields
		private AssetBlackboard _parentBlackboard; // 0x18
		private string _serializedBlackboard; // 0x20
		private List<UnityEngine.Object> _objectReferences; // 0x28
		private SerializationPair[] _serializedVariables; // 0x30
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x38
		[NonSerialized]
		private bool haltForUndo; // 0x40
		[NonSerialized]
		private string _identifier; // 0x48
		private Action<Variable> onVariableAdded; // 0x50
		private Action<Variable> onVariableRemoved; // 0x58
	
		// Properties
		public BlackboardSource blackboard { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public AssetBlackboard parentBlackboard { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		string IBlackboard.identifier { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		Dictionary<string, Variable> IBlackboard.variables { get => default; set {} } // 0x000000018B4B5248-0x000000018B4B5264 0x000000018B4B5264-0x000000018B4B5288
		Component IBlackboard.propertiesBindTarget { get => default; } // 0x0000000185779060-0x0000000185779070 
		UnityEngine.Object IBlackboard.unityContextObject { get => default; } // 0x0000000185779060-0x0000000185779070 
		IBlackboard IBlackboard.parent { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		string IBlackboard.independantVariablesFieldName { get => default; } // 0x000000018B4B521C-0x000000018B4B5248 
	
		// Events
		public event Action<Variable> onVariableAdded;
		public event Action<Variable> onVariableRemoved;
	
		// Constructors
		public Blackboard() {} // 0x000000018B4B5910-0x000000018B4B5980
	
		// Methods
		public void SetParentBlackboard(AssetBlackboard bb) {} // 0x0000000184088E70-0x0000000184088E80
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4B5908-0x000000018B4B5910
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4B5900-0x000000018B4B5908
		public void SelfSerialize() {} // 0x000000018B4B54E4-0x000000018B4B57E0
		public void SelfDeserialize() {} // 0x000000018B4B5328-0x000000018B4B54E4
		public string Serialize(List<UnityEngine.Object> references, bool pretyJson = false /* Metadata: 0x02060E4C */) => default; // 0x000000018B4B57E0-0x000000018B4B5898
		public bool Deserialize(string json, List<UnityEngine.Object> references, bool removeMissingVariables = true /* Metadata: 0x02060E4D */) => default; // 0x000000018B4B5074-0x000000018B4B5120
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable) {} // 0x000000018B4B51F4-0x000000018B4B5208
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable) {} // 0x000000018B4B5208-0x000000018B4B521C
		protected virtual void Awake() {} // 0x000000018B4B5024-0x000000018B4B5074
		public Variable AddVariable(string name, System.Type type) => default; // 0x000000018B4B501C-0x000000018B4B5024
		public Variable AddVariable(string name, object value) => default; // 0x000000018B4B5014-0x000000018B4B501C
		public Variable RemoveVariable(string name) => default; // 0x000000018B4B52C0-0x000000018B4B52C8
		public Variable GetVariable(string name, System.Type ofType = null) => default; // 0x000000018B4B5128-0x000000018B4B5130
		public Variable GetVariableByID(string ID) => default; // 0x000000018B4B5120-0x000000018B4B5128
		public Variable<T> GetVariable<T>(string name) => default;
		public T GetVariableValue<T>(string name) => default;
		public Variable SetVariableValue(string name, object value) => default; // 0x000000018B4B5898-0x000000018B4B58A0
		public T GetValue<T>(string name) => default;
		public Variable SetValue(string name, object value) => default; // 0x000000018B4B5898-0x000000018B4B58A0
		private void ShowJson() {} // 0x000000018B4B58A0-0x000000018B4B5900
		public string Save() => default; // 0x000000018B4B5304-0x000000018B4B5328
		public string Save(string saveKey) => default; // 0x000000018B4B52C8-0x000000018B4B5304
		public bool Load() => default; // 0x000000018B4B51D0-0x000000018B4B51F4
		public bool Load(string saveKey) => default; // 0x000000018B4B5130-0x000000018B4B51D0
		protected virtual void OnValidate() {} // 0x000000018B4B5288-0x000000018B4B52C0
		public override string ToString() => default; // 0x00000001813ECF20-0x00000001813ECF30
	}

	public class GlobalBlackboard : NodeCanvas.Framework.Blackboard, IGlobalBlackboard // TypeDefIndex: 49216
	{
		// Fields
		private string _UID; // 0x60
		private string _identifier; // 0x68
		private SingletonMode _singletonMode; // 0x70
		private bool _dontDestroyOnLoad; // 0x74
		private static List<GlobalBlackboard> _allGlobals; // 0x00
	
		// Properties
		public string identifier { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public string UID { get => default; } // 0x000000018B4B6C00-0x000000018B4B6C50 
		public new string name { get => default; } // 0x000000018B4B6A64-0x000000018B4B6B0C 
	
		// Nested types
		public enum SingletonMode // TypeDefIndex: 49214
		{
			DestroyComponentOnly = 0,
			DestroyEntireGameObject = 1
		}
	
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 49215
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x00000001813AC280-0x00000001813AC290
	
			// Methods
			internal bool _Find_b__0(GlobalBlackboard b) => default; // 0x0000000185FB0530-0x0000000185FB0540
		}
	
		// Constructors
		public GlobalBlackboard() {} // 0x0000000185492010-0x0000000185492020
		static GlobalBlackboard() {} // 0x000000018B4C6D54-0x000000018B4C6D7C
	
		// Methods
		public static IEnumerable<GlobalBlackboard> GetAll() => default; // 0x000000018B4B6B0C-0x000000018B4B6C00
		public static GlobalBlackboard Create() => default; // 0x000000018B4B6CC0-0x000000018B4B6E94
		public static GlobalBlackboard Find(string name) => default; // 0x000000018B4B6C50-0x000000018B4B6CC0
		protected void OnEnable() {} // 0x000000018B4B6E94-0x000000018B4B7004
		protected void OnDisable() {} // 0x00000001813AC280-0x00000001813AC290
		protected override void OnValidate() {} // 0x00000001814A81B0-0x00000001814A81C0
		public override string ToString() => default; // 0x000000018B4B7090-0x000000018B4B70E4
		private bool IsPrefabAsset() => default; // 0x000000018B4B7004-0x000000018B4B7090
	}

	public interface IBlackboard // TypeDefIndex: 49217
	{
		// Properties
		string identifier { get; }
		IBlackboard parent { get; }
		Dictionary<string, Variable> variables { get; set; }
		Component propertiesBindTarget { get; }
		UnityEngine.Object unityContextObject { get; }
		string independantVariablesFieldName { get; }
	
		// Events
		event Action<Variable> onVariableAdded;
		event Action<Variable> onVariableRemoved;
	
		// Methods
		void TryInvokeOnVariableAdded(Variable variable);
		void TryInvokeOnVariableRemoved(Variable variable);
	}

	public interface IGlobalBlackboard : IBlackboard // TypeDefIndex: 49218
	{
		// Properties
		string UID { get; }
	}

	public static class IBlackboardExtensions // TypeDefIndex: 49221
	{
		// Nested types
		private sealed class _GetAllParents_d__1 : IEnumerable<IBlackboard>, IEnumerator<IBlackboard> // TypeDefIndex: 49219
		{
			// Fields
			private int __1__state; // 0x10
			private IBlackboard __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private IBlackboard blackboard; // 0x28
			public IBlackboard __3__blackboard; // 0x30
			private bool includeSelf; // 0x38
			public bool __3__includeSelf; // 0x39
			private IBlackboard _current_5__2; // 0x40
	
			// Properties
			IBlackboard IEnumerator<NodeCanvas.Framework.IBlackboard>.Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x000000018B4B8864-0x000000018B4B88CC 
	
			// Constructors
			public _GetAllParents_d__1() {} // Dummy constructor
			public _GetAllParents_d__1(int __1__state) {} // 0x000000018B4B8C6C-0x000000018B4B8CAC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4B8BEC-0x000000018B4B8C6C
			private bool MoveNext() => default; // 0x000000018B4B9254-0x000000018B4B9294
			void IEnumerator.Reset() {}
			IEnumerator<IBlackboard> IEnumerable<IBlackboard>.GetEnumerator() => default; // 0x000000018B4B88CC-0x000000018B4B8A10
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B4B96C0-0x000000018B4B9780
		}
	
		private sealed class _GetVariables_d__14 : IEnumerable<Variable>, IEnumerator<Variable> // TypeDefIndex: 49220
		{
			// Fields
			private int __1__state; // 0x10
			private Variable __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private IBlackboard blackboard; // 0x28
			public IBlackboard __3__blackboard; // 0x30
			private System.Type ofType; // 0x38
			public System.Type __3__ofType; // 0x40
			private IEnumerator<Variable> __7__wrap1; // 0x48
			private Dictionary<string, Variable> __7__wrap2; // 0x50
	
			// Properties
			Variable IEnumerator<NodeCanvas.Framework.Variable>.Current { get => default; } // 0x000000018B4B8CAC-0x000000018B4B8EC4 
			object IEnumerator.Current { get => default; } // 0x000000018B4B8A10-0x000000018B4B8BEC 
	
			// Constructors
			public _GetVariables_d__14() {} // Dummy constructor
			public _GetVariables_d__14(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4B9780-0x000000018B4B9898
			private bool MoveNext() => default; // 0x000000018B4B9088-0x000000018B4B9254
			private void __m__Finally1() {}
			private void __m__Finally2() {} // 0x000000018B4B8EC4-0x000000018B4B9000
			void IEnumerator.Reset() {} // 0x000000018B4B9000-0x000000018B4B9088
			IEnumerator<Variable> IEnumerable<Variable>.GetEnumerator() => default; // 0x000000018B4B9294-0x000000018B4B96C0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184775050-0x0000000184775070
		}
	
		// Methods
		public static IBlackboard GetRoot(IBlackboard blackboard) => default; // 0x0000000185492010-0x0000000185492020
		public static IEnumerable<IBlackboard> GetAllParents(IBlackboard blackboard, bool includeSelf) => default; // 0x000000018B4C5668-0x000000018B4C570C
		public static bool IsPartOf(IBlackboard blackboard, IBlackboard child) => default; // 0x0000000181377E40-0x0000000181377E50
		public static Variable<T> AddVariable<T>(IBlackboard blackboard, string varName, T value) => default; // 0x000000018B4C57B0-0x000000018B4C57FC
		public static Variable<T> AddVariable<T>(IBlackboard blackboard, string varName) => default; // 0x0000000181377E40-0x0000000181377E50
		public static Variable AddVariable(IBlackboard blackboard, string varName, object value) => default; // 0x000000018B4C570C-0x000000018B4C57A8
		public static Variable AddVariable(IBlackboard blackboard, string varName, System.Type type) => default; // 0x000000018B4C57A8-0x000000018B4C57B0
		public static Variable RemoveVariable(IBlackboard blackboard, string varName) => default; // 0x0000000184775050-0x0000000184775070
		public static T GetVariableValue<T>(IBlackboard blackboard, string varName) => default; // 0x000000018B4C6650-0x000000018B4C673C
		public static Variable SetVariableValue(IBlackboard blackboard, string varName, object value) => default; // 0x000000018B4C5F9C-0x000000018B4C6558
		public static void InitializePropertiesBinding(IBlackboard blackboard, Component target, bool callSetter) {} // 0x000000018B4C673C-0x000000018B4C6784
		public static Variable<T> GetVariable<T>(IBlackboard blackboard, string varName) => default; // 0x000000018B4C6784-0x000000018B4C67C0
		public static Variable GetVariable(IBlackboard blackboard, string varName, System.Type ofType = null) => default; // 0x0000000181377E40-0x0000000181377E50
		public static Variable GetVariableByID(IBlackboard blackboard, string ID) => default; // 0x000000018B4C6604-0x000000018B4C6650
		public static IEnumerable<Variable> GetVariables(IBlackboard blackboard, System.Type ofType = null) => default; // 0x0000000181377E40-0x0000000181377E50
		public static Variable ChangeVariableType(IBlackboard blackboard, Variable target, System.Type newType) => default; // 0x000000018B4C6558-0x000000018B4C65FC
		public static void OverwriteFrom(IBlackboard blackboard, IBlackboard sourceBlackboard, bool removeMissingVariables = true /* Metadata: 0x02060E50 */) {} // 0x000000018B4C65FC-0x000000018B4C6604
	}

	public static class BlackboardHelpers // TypeDefIndex: 49223
	{
		// Fields
		private static readonly ConcurrentDictionary<System.Type, System.Type> s_variableTypeCache; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 49222
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, System.Type> __9__1_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4B4BE4-0x000000018B4B4D24
			public __c() {} // 0x000000018B4B4D24-0x000000018B4B4DB0
	
			// Methods
			internal System.Type _CreateVariableType_b__1_0(System.Type t) => default; // 0x000000018B4C75C0-0x000000018B4C7624
		}
	
		// Constructors
		static BlackboardHelpers() {} // 0x000000018B4C6AE4-0x000000018B4C6BB8
	
		// Methods
		public static System.Type CreateVariableType(System.Type valueType) => default; // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public abstract class Variable // TypeDefIndex: 49226
	{
		// Fields
		private string _name; // 0x10
		private string _id; // 0x18
		private bool _isPublic; // 0x20
		private bool _debugBoundValue; // 0x21
		private Action<string> onNameChanged; // 0x28
		private Action<object> onValueChanged; // 0x30
		private Action onDestroy; // 0x38
	
		// Properties
		public string name { get; set; } // 0x00000001813EE9B0-0x00000001813EE9C0 0x00000001813ECBD0-0x00000001813ECBE0
		public string ID { get; } // 0x00000001813EE990-0x00000001813EE9A0 
		public object value { get; set; } // 0x000000018B4C7CFC-0x000000018B4C7D24 
		public bool isExposedPublic { get; set; }
		public bool debugBoundValue { get; set; }
		public bool isPropertyBound { get; }
		public abstract bool isDataBound { get; }
		public abstract System.Type varType { get; }
		public abstract string propertyPath { get; set; }
	
		// Events
		public event Action<string> onNameChanged;
		public event Action<object> onValueChanged;
		public event Action onDestroy;
	
		// Nested types
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 49224
		{
			// Fields
			public Variable __4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public __c__DisplayClass50_0() {} // 0x000000018B4C7BC8-0x000000018B4C7C54
	
			// Methods
			internal object _GetGetConverter_b__0() => default; // 0x000000018B4C7DC8-0x000000018B4C7E54
			internal object _GetGetConverter_b__1() => default; // 0x000000018B4C7C54-0x000000018B4C7CE0
		}
	
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 49225
		{
			// Fields
			public Variable __4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public __c__DisplayClass52_0() {} // 0x000000018B4C7E54-0x000000018B4C7EE0
	
			// Methods
			internal void _GetSetConverter_b__0(object x) {} // 0x000000018B4C7B34-0x000000018B4C7BC8
			internal void _GetSetConverter_b__1(object x) {} // 0x000000018B4C7D34-0x000000018B4C7DC8
		}
	
		// Constructors
		public Variable() {} // 0x000000018B4C7704-0x000000018B4C771C
		public Variable(string name, string ID) {} // 0x000000018B4C7828-0x000000018B4C7978
	
		// Methods
		public abstract void BindProperty(MemberInfo prop, GameObject target = null);
		public abstract void UnBind(); // 0x000000018B4C7AF0-0x000000018B4C7B34
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x02060E51 */); // 0x00000001841BC230-0x00000001841BC260
		public abstract object GetValueBoxed(); // 0x000000018B4C7AC8-0x000000018B4C7ADC
		public abstract void SetValueBoxed(object value); // 0x000000018B4C771C-0x000000018B4C7828
		public abstract void ResetDefaultValue(); // 0x000000018A6AD3DC-0x000000018A6AD3E8
		public abstract void RecordDefaultValue(); // 0x000000018B4C7ADC-0x000000018B4C7AF0
		internal void OnDestroy() {} // 0x000000018B4C76EC-0x000000018B4C7704
		public Variable Duplicate(IBlackboard targetBB) => default; // 0x000000018B4C7978-0x000000018B4C7AC8
		protected bool HasValueChangeEvent() => default; // 0x000000018346D130-0x000000018346D140
		protected void TryInvokeValueChangeEvent(object value) {} // 0x0000000185492010-0x0000000185492020
		public bool CanConvertTo(System.Type toType) => default; // 0x000000018B4C71F0-0x000000018B4C7214
		public Func<object> GetGetConverter(System.Type toType) => default; // 0x000000018B4C7214-0x000000018B4C7250
		public bool CanConvertFrom(System.Type fromType) => default; // 0x0000000185492010-0x0000000185492020
		public Action<object> GetSetConverter(System.Type fromType) => default; // 0x000000018B4C7250-0x000000018B4C7274
		public override string ToString() => default; // 0x000000018B4C7274-0x000000018B4C72B0
	}

	public class Variable<T> : Variable // TypeDefIndex: 49231
	{
		// Fields
		private T _value;
		private string _propertyPath;
		private Func<T> getter;
		private Action<T> setter;
		private T m_originalValue;
		private bool m_hasOriginalValue;
	
		// Properties
		public override System.Type varType { get => default; }
		public override bool isDataBound { get => default; }
		public override string propertyPath { get => default; set {} }
		public new T value { get => default; set {} }
	
		// Events
		private event Func<T> getter;
		private event Action<T> setter;
	
		// Nested types
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 49227
		{
			// Fields
			public System.Reflection.FieldInfo field;
			public Component instance;
	
			// Constructors
			public __c__DisplayClass31_0() {}
	
			// Methods
			internal T _InitializePropertyBinding_b__0() => default;
			internal void _InitializePropertyBinding_b__1(T o) {}
		}
	
		private sealed class __c__DisplayClass31_1 // TypeDefIndex: 49228
		{
			// Fields
			public T value;
	
			// Constructors
			public __c__DisplayClass31_1() {}
	
			// Methods
			internal T _InitializePropertyBinding_b__2() => default;
		}
	
		private sealed class __c__DisplayClass31_2 // TypeDefIndex: 49229
		{
			// Fields
			public MethodInfo getMethod;
			public Component instance;
			public MethodInfo setMethod;
	
			// Constructors
			public __c__DisplayClass31_2() {}
	
			// Methods
			internal T _InitializePropertyBinding_b__3() => default;
			internal void _InitializePropertyBinding_b__5(T o) {}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49230
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<T> __9__31_4;
			public static Action<T> __9__31_6;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal T _InitializePropertyBinding_b__31_4() => default;
			internal void _InitializePropertyBinding_b__31_6(T o) {}
		}
	
		// Constructors
		public Variable() {}
		public Variable(string name, string ID) {}
	
		// Methods
		public override object GetValueBoxed() => default;
		public override void SetValueBoxed(object newValue) {}
		public T GetValue() => default;
		public void SetValue(T newValue) {}
		public override void ResetDefaultValue() {}
		public override void RecordDefaultValue() {}
		public override void BindProperty(MemberInfo prop, GameObject target = null) {}
		public void BindGetSet(Func<T> _get, Action<T> _set) {}
		public override void UnBind() {}
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x02060E52 */) {}
	}

	public class VariableSeperator // TypeDefIndex: 49232
	{
		// Fields
		private bool _isEditingName_k__BackingField; // 0x10
	
		// Properties
		public bool isEditingName { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public VariableSeperator() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace NodeCanvas.Framework.Internal
{
	public struct GraphLoadData // TypeDefIndex: 49233
	{
		// Fields
		public GraphSource source; // 0x00
		public string json; // 0x08
		public List<UnityEngine.Object> references; // 0x10
		public Component agent; // 0x18
		public IBlackboard parentBlackboard; // 0x20
		public bool preInitializeSubGraphs; // 0x28
	}

	[Serializable]
	public class GraphSource : ISerializationCollector // TypeDefIndex: 49234
	{
		// Fields
		private List<NodeCanvas.Framework.Task> m_allTasks; // 0x10
		public List<BBParameter> m_allParameters; // 0x18
		public const float FRAMEWORK_VERSION = 3.25f; // Metadata: 0x02060E53
		private float _version; // 0x20
		private string _category; // 0x28
		private string _comments; // 0x30
		private Vector2 _translation; // 0x38
		private float _zoomFactor; // 0x40
		private string _type; // 0x48
		private List<NodeCanvas.Framework.Node> _nodes; // 0x50
		private List<Connection> _connections; // 0x58
		private List<NodeCanvas.Framework.CanvasGroup> _canvasGroups; // 0x60
		private BlackboardSource _localBlackboard; // 0x68
		private object _derivedData; // 0x70
	
		// Properties
		public List<NodeCanvas.Framework.Task> allTasks { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public List<BBParameter> allParameters { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float version { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public string category { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public string comments { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public Vector2 translation { get => default; set {} } // 0x0000000185FD2B80-0x0000000185FD2BA0 0x0000000185FB06D0-0x0000000185FB06E0
		public float zoomFactor { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public string type { get => default; set {} } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public List<NodeCanvas.Framework.Node> nodes { get => default; set {} } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public List<Connection> connections { get => default; private set {} } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get => default; set {} } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public BlackboardSource localBlackboard { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public object derivedData { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
	
		// Constructors
		public GraphSource() {} // 0x00000001858D7180-0x00000001858D7320
	
		// Methods
		void ISerializationCollector.OnPush(ISerializationCollector parent) {} // 0x000000018B4B8470-0x000000018B4B8530
		void ISerializationCollector.OnCollect(ISerializationCollectable child, int depth) {} // 0x000000018B4B8378-0x000000018B4B8470
		void ISerializationCollector.OnPop(ISerializationCollector parent) {} // 0x0000000185492010-0x0000000185492020
		public GraphSource Pack(NodeCanvas.Framework.Graph graph) => default; // 0x000000018B4B8198-0x000000018B4B8378
		public GraphSource Unpack(NodeCanvas.Framework.Graph graph) => default; // 0x000000018B4B85E0-0x000000018B4B8864
		public GraphSource SetMetaData(GraphSource source) => default; // 0x000000018B4B8578-0x000000018B4B85E0
		public void PurgeRedundantReferences() {} // 0x000000018B4B8530-0x000000018B4B8578
	}

	public sealed class MissingConnection : Connection, IMissingRecoverable // TypeDefIndex: 49235
	{
		// Fields
		private string _missingType; // 0x30
		private string _recoveryState; // 0x38
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		public MissingConnection() {} // 0x0000000185FBE310-0x0000000185FBE320
	}

	public sealed class MissingNode : NodeCanvas.Framework.Node, IMissingRecoverable // TypeDefIndex: 49236
	{
		// Fields
		private string _missingType; // 0x98
		private string _recoveryState; // 0xA0
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public override string name { get => default; } // 0x000000018B4BA4C8-0x000000018B4BA51C 
		public override System.Type outConnectionType { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool canSelfConnect { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override Alignment2x2 commentsAlignment { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public override Alignment2x2 iconAlignment { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public MissingNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	[Serializable]
	public class ReflectedAction : ReflectedActionWrapper // TypeDefIndex: 49237
	{
		// Fields
		private ActionCall call; // 0x18
	
		// Constructors
		public ReflectedAction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override BBParameter[] GetVariables() => default; // 0x000000018B4BC680-0x000000018B4BC6B4
		public override void Init(object instance) {} // 0x000000018B4BC6B4-0x000000018B4BC738
		public override void Call() {} // 0x000000018B4BC65C-0x000000018B4BC680
	}

	[Serializable]
	public class ReflectedAction<T1> : ReflectedActionWrapper // TypeDefIndex: 49238
	{
		// Fields
		private ActionCall<T1> call;
		public BBParameter<T1> p1;
	
		// Constructors
		public ReflectedAction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override void Call() {}
	}

	[Serializable]
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper // TypeDefIndex: 49239
	{
		// Fields
		private ActionCall<T1, T2> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
	
		// Constructors
		public ReflectedAction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override void Call() {}
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper // TypeDefIndex: 49240
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
	
		// Constructors
		public ReflectedAction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override void Call() {}
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper // TypeDefIndex: 49241
	{
		// Fields
		private ActionCall<T1, T2, T3, T4> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
	
		// Constructors
		public ReflectedAction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override void Call() {}
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper // TypeDefIndex: 49242
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
	
		// Constructors
		public ReflectedAction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override void Call() {}
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper // TypeDefIndex: 49243
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
		public BBParameter<T6> p6;
	
		// Constructors
		public ReflectedAction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override void Call() {}
	}

	[Serializable]
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper // TypeDefIndex: 49244
	{
		// Fields
		private FunctionCall<TResult> call;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper // TypeDefIndex: 49245
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper // TypeDefIndex: 49246
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper // TypeDefIndex: 49247
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper // TypeDefIndex: 49248
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper // TypeDefIndex: 49249
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper // TypeDefIndex: 49250
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
		public BBParameter<T6> p6;
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	public abstract class ReflectedWrapper : IReflectedWrapper // TypeDefIndex: 49251
	{
		// Fields
		protected SerializedMethodInfo _targetMethod; // 0x10
	
		// Constructors
		public ReflectedWrapper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb) => default; // 0x000000018B4BCB30-0x000000018B4BCBD8
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018346D130-0x000000018346D140
		public void SetVariablesBB(IBlackboard bb) {} // 0x000000018B4BCBFC-0x000000018B4BCC60
		public SerializedMethodInfo GetSerializedMethod() => default; // 0x000000018346D130-0x000000018346D140
		public MethodInfo GetMethod() => default; // 0x000000018B4BCBD8-0x000000018B4BCBE8
		public bool HasChanged() => default; // 0x000000018B4BCBE8-0x000000018B4BCBFC
		public string AsString() => default; // 0x000000018B4BCB10-0x000000018B4BCB30
		public override string ToString() => default; // 0x000000018B4BCC60-0x000000018B4BCC68
		public abstract BBParameter[] GetVariables();
		public abstract void Init(object instance);
	}

	public abstract class ReflectedActionWrapper : ReflectedWrapper // TypeDefIndex: 49252
	{
		// Constructors
		protected ReflectedActionWrapper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static new ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb) => default; // 0x000000018B4BC2BC-0x000000018B4BC65C
		public abstract void Call();
	}

	public abstract class ReflectedFunctionWrapper : ReflectedWrapper // TypeDefIndex: 49253
	{
		// Constructors
		protected ReflectedFunctionWrapper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static new ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb) => default; // 0x000000018B4BC738-0x000000018B4BCB10
		public abstract object Call();
	}

	public class MissingAction : ActionTask, IMissingRecoverable // TypeDefIndex: 49254
	{
		// Fields
		private string _missingType; // 0x68
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		protected override string info { get => default; } // 0x000000018B4BA3C8-0x000000018B4BA434 
	
		// Constructors
		public MissingAction() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	}

	public class MissingCondition : ConditionTask, IMissingRecoverable // TypeDefIndex: 49255
	{
		// Fields
		private string _missingType; // 0x68
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		protected override string info { get => default; } // 0x000000018B4BA45C-0x000000018B4BA4C8 
	
		// Constructors
		public MissingCondition() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	}

	[Serializable]
	public sealed class TaskAgentParameter : BBParameter<UnityEngine.Object> // TypeDefIndex: 49256
	{
		// Fields
		private System.Type _type; // 0x50
	
		// Properties
		public override System.Type varType { get => default; } // 0x000000018B4C3148-0x000000018B4C31A8 
		public new UnityEngine.Object value { get => default; set {} } // 0x000000018B4C30A0-0x000000018B4C3148 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		public TaskAgentParameter() {} // 0x000000018B4C3078-0x000000018B4C30A0
	
		// Methods
		public override object GetValueBoxed() => default; // 0x000000018B4C2F84-0x000000018B4C2F8C
		public override void SetValueBoxed(object newValue) {} // 0x000000018B4C3024-0x000000018B4C3078
		public void SetType(System.Type newType) {} // 0x000000018B4C2F8C-0x000000018B4C3024
	}

	[Serializable]
	public class BBMappingParameter : BBObjectParameter // TypeDefIndex: 49257
	{
		// Fields
		private string _targetSubGraphVariableID; // 0x60
		private bool _canRead; // 0x68
		private bool _canWrite; // 0x69
	
		// Properties
		public string targetSubGraphVariableID { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public bool canRead { get => default; set {} } // 0x0000000185FB09E0-0x0000000185FB09F0 0x0000000185FB0A20-0x0000000185FB0A30
		public bool canWrite { get => default; set {} } // 0x0000000185FB09C0-0x0000000185FB09D0 0x0000000185FB0A00-0x0000000185FB0A10
	
		// Constructors
		public BBMappingParameter() {} // 0x000000018B4B3BEC-0x000000018B4B3BF4
		public BBMappingParameter(Variable subVariable) {} // 0x000000018B4B3BF4-0x000000018B4B3C54
	}

	[Serializable]
	public class BBObjectParameter : BBParameter<object>, ISerializationCallbackReceiver // TypeDefIndex: 49258
	{
		// Fields
		private string _type; // 0x50
		private System.Type _type_k__BackingField; // 0x58
	
		// Properties
		private System.Type type { get; set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public override System.Type varType { get => default; } // 0x000000018B4B3F7C-0x000000018B4B3FF4 
	
		// Constructors
		public BBObjectParameter() {} // 0x000000018B4B3F04-0x000000018B4B3F7C
		public BBObjectParameter(System.Type t) {} // 0x000000018B4B3EC0-0x000000018B4B3F04
		public BBObjectParameter(BBParameter source) {} // 0x000000018B4B3E30-0x000000018B4B3EC0
	
		// Methods
		new void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4B3DC0-0x000000018B4B3E30
		new void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4B3D60-0x000000018B4B3DC0
		public void SetType(System.Type t) {} // 0x000000018B4B3C54-0x000000018B4B3D60
	}

	[Serializable]
	public class BlackboardSource : IBlackboard // TypeDefIndex: 49259
	{
		// Fields
		private Dictionary<string, Variable> _variables; // 0x10
		private Action<Variable> onVariableAdded; // 0x18
		private Action<Variable> onVariableRemoved; // 0x20
		private IBlackboard _parent_k__BackingField; // 0x28
		private UnityEngine.Object _unityContextObject_k__BackingField; // 0x30
		private Component _propertiesBindTarget_k__BackingField; // 0x38
	
		// Properties
		public string identifier { get => default; } // 0x000000018B4B4ED0-0x000000018B4B4EFC 
		public Dictionary<string, Variable> variables { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public IBlackboard parent { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public UnityEngine.Object unityContextObject { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public Component propertiesBindTarget { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		string IBlackboard.independantVariablesFieldName { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Events
		public event Action<Variable> onVariableAdded;
		public event Action<Variable> onVariableRemoved;
	
		// Constructors
		public BlackboardSource() {} // 0x00000001858D7320-0x00000001858D73D0
	
		// Methods
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable) {} // 0x0000000189D5AC38-0x0000000189D5AC4C
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable) {} // 0x000000018B4B3610-0x000000018B4B3624
		public override string ToString() => default; // 0x000000018B4B4DB0-0x000000018B4B4DB8
	}

	public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType> // TypeDefIndex: 49260
	{
		// Constructors
		public fsBBParameterProcessor() {} // 0x000000018B4C81C4-0x000000018B4C82E0
	
		// Methods
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x000000018B4C7F44-0x000000018B4C81C4
	}

	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable // TypeDefIndex: 49261
	{
		// Fields
		private string _missingType; // 0x50
		private string _recoveryState; // 0x58
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
	
		// Constructors
		public MissingBBParameterType() {} // 0x000000018B4BA434-0x000000018B4BA45C
	}

	public class MissingVariableType : Variable<object>, IMissingRecoverable // TypeDefIndex: 49262
	{
		// Fields
		private string _missingType; // 0x70
		private string _recoveryState; // 0x78
	
		// Properties
		public string missingType { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public string recoveryState { get => default; set {} } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
	
		// Constructors
		public MissingVariableType() {} // 0x000000018B4BA51C-0x000000018B4BA550
	}
}

namespace NodeCanvas.StateMachines
{
	public class FSM : NodeCanvas.Framework.Graph // TypeDefIndex: 48999
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private IStateCallbackReceiver[] callbackReceivers; // 0xA8
		private Stack<FSMState> stateStack; // 0xB0
		private bool enterStartStateFlag; // 0xB8
		private Action<IState> onStateEnter; // 0xC0
		private Action<IState> onStateUpdate; // 0xC8
		private Action<IState> onStateExit; // 0xD0
		private Action<IState> onStateTransition; // 0xD8
		private FSMState _currentState_k__BackingField; // 0xE0
		private FSMState _previousState_k__BackingField; // 0xE8
	
		// Properties
		public FSMState currentState { get; private set; } // 0x00000001840A27C0-0x00000001840A27D0 0x00000001840A27C0-0x00000001840A27D0
		public FSMState previousState { get; private set; } // 0x00000001814A81B0-0x00000001814A81C0 0x00000001840A27C0-0x00000001840A27D0
		public string currentStateName { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public string previousStateName { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override System.Type baseNodeType { get => default; } // 0x000000018B48C2CC-0x000000018B48C48C 
		public override bool requiresAgent { get => default; } // 0x000000018B48C48C-0x000000018B48C510 
		public override bool requiresPrimeNode { get => default; } // 0x000000018B48C584-0x000000018B48C868 
		public override bool isTree { get => default; } // 0x000000018B48C510-0x000000018B48C584 
		public override bool allowBlackboardOverrides { get => default; } // 0x000000018B48BC84-0x000000018B48BE38 
		public sealed override bool canAcceptVariableDrops { get => default; } // 0x000000018B48C8CC-0x000000018B48C918 
		public override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018B48BFDC-0x000000018B48C1D8 
	
		// Events
		public event Action<IState> onStateEnter;
		public event Action<IState> onStateUpdate;
		public event Action<IState> onStateExit;
		public event Action<IState> onStateTransition;
	
		// Nested types
		public enum TransitionCallMode // TypeDefIndex: 48996
		{
			Normal = 0,
			Stacked = 1,
			Clean = 2
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48997
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IUpdatable, bool> __9__45_0; // 0x08
			public static Func<NodeCanvas.Framework.Node, bool> __9__49_0; // 0x10
			public static Func<NodeCanvas.Framework.Node, string> __9__49_1; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018B48CAF8-0x000000018B48CB88
			public __c() {} // 0x000000018B48CDE0-0x000000018B48CE70
	
			// Methods
			internal bool _OnGraphUpdate_b__45_0(IUpdatable n) => default; // 0x000000018B48CCA8-0x000000018B48CD38
			internal bool _GetStateNames_b__49_0(NodeCanvas.Framework.Node n) => default; // 0x000000018B48CF90-0x000000018B48D020
			internal string _GetStateNames_b__49_1(NodeCanvas.Framework.Node n) => default; // 0x000000018B48CB88-0x000000018B48CC18
		}
	
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 48998
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0() {} // 0x000000018B48CE70-0x000000018B48CF00
	
			// Methods
			internal bool _GetStateWithName_b__0(NodeCanvas.Framework.Node n) => default; // 0x000000018B48CC18-0x000000018B48CCA8
		}
	
		// Constructors
		public FSM() {} // 0x000000018B49B9A0-0x000000018B49B9E0
	
		// Methods
		protected override void OnGraphInitialize() {} // 0x000000018B48C1D8-0x000000018B48C2CC
		protected override void OnGraphStarted() {} // 0x000000018B48BE38-0x000000018B48BFDC
		protected override void OnGraphUpdate() {} // 0x000000018B48C868-0x000000018B48C8CC
		protected override void OnGraphStoped() {} // 0x000000018B48CAAC-0x000000018B48CAF8
		public bool EnterState(FSMState newState, TransitionCallMode callMode) => default; // 0x000000018B48C918-0x000000018B48C99C
		public FSMState TriggerState(string stateName, TransitionCallMode callMode) => default; // 0x000000018B48C99C-0x000000018B48CA24
		public string[] GetStateNames() => default; // 0x000000018B48CA24-0x000000018B48CAAC
		public FSMState GetStateWithName(string name) => default; // 0x000000018B49BBB4-0x000000018B49BC18
		private void GatherCallbackReceivers() {} // 0x0000000185492010-0x0000000185492020
		public FSMState PeekStack() => default; // 0x000000018B49BAB8-0x000000018B49BADC
		private void _GatherCallbackReceivers_b__51_0(IState x) {} // 0x000000018B49B9E0-0x000000018B49BA00
		private void _GatherCallbackReceivers_b__51_1(IState x) {} // 0x0000000185492010-0x0000000185492020
		private void _GatherCallbackReceivers_b__51_2(IState x) {} // 0x000000018B49BADC-0x000000018B49BB50
	}

	public class FSMConnection : Connection, ITaskAssignable<ConditionTask> // TypeDefIndex: 49000
	{
		// Fields
		private FSM.TransitionCallMode _transitionCallMode; // 0x30
		private ConditionTask _condition; // 0x38
	
		// Properties
		public ConditionTask condition { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x000000018B48B0EC-0x000000018B48B140
		public FSM.TransitionCallMode transitionCallMode { get => default; private set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
	
		// Constructors
		public FSMConnection() {} // 0x0000000185FBE310-0x0000000185FBE320
	
		// Methods
		public void EnableCondition(Component agent, IBlackboard blackboard) {} // 0x000000018B48B024-0x000000018B48B038
		public void DisableCondition() {} // 0x000000018B48B010-0x000000018B48B024
		public void PerformTransition() {} // 0x000000018B48B038-0x000000018B48B0EC
	}

	public abstract class FSMNode : NodeCanvas.Framework.Node // TypeDefIndex: 49001
	{
		// Properties
		public override bool allowAsPrime { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool canSelfConnect { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override int maxInConnections { get; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public override int maxOutConnections { get; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public sealed override System.Type outConnectionType { get; } // 0x000000018B48B17C-0x000000018B48B1CC 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000181C44E90-0x0000000181C44EA0 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x0000000181C44E90-0x0000000181C44EA0 
		public FSM FSM { get; } // 0x000000018B48B140-0x000000018B48B17C 
	
		// Constructors
		protected FSMNode() {} // 0x0000000183055FD0-0x0000000183055FE0
	}

	public abstract class FSMNodeNested<T> : FSMNode, IGraphAssignable<T> // TypeDefIndex: 49002
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		private List<BBMappingParameter> _variablesMap;
		private T _currentInstance_k__BackingField;
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { get; set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FSMNodeNested() {}
	}

	public class FSMOwner : GraphOwner<FSM> // TypeDefIndex: 49003
	{
		// Properties
		public string currentRootStateName { get => default; } // 0x000000018B48B654-0x000000018B48B6EC 
		public string previousRootStateName { get => default; } // 0x000000018B48B710-0x000000018B48B7A8 
		public string currentDeepStateName { get => default; } // 0x000000018B48B630-0x000000018B48B654 
		public string previousDeepStateName { get => default; } // 0x000000018B48B6EC-0x000000018B48B710 
	
		// Constructors
		public FSMOwner() {} // 0x000000018B48B5FC-0x000000018B48B630
	
		// Methods
		public IState GetCurrentState(bool includeSubFSMs = true /* Metadata: 0x02060D8D */) => default; // 0x000000018B48B1CC-0x000000018B48B2FC
		public IState GetPreviousState(bool includeSubFSMs = true /* Metadata: 0x02060D8E */) => default; // 0x000000018B48B2FC-0x000000018B48B4A0
		public IState TriggerState(string stateName) => default; // 0x000000018B48B538-0x000000018B48B544
		public IState TriggerState(string stateName, FSM.TransitionCallMode callMode) => default; // 0x000000018B48B544-0x000000018B48B5FC
		public string[] GetStateNames() => default; // 0x000000018B48B4A0-0x000000018B48B538
	}

	public abstract class FSMState : FSMNode, IState // TypeDefIndex: 49005
	{
		// Fields
		private TransitionEvaluationMode _transitionEvaluation; // 0x98
		private bool _hasInit; // 0x9C
	
		// Properties
		public override bool allowAsPrime { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool canSelfConnect { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override int maxInConnections { get; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public override int maxOutConnections { get; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public TransitionEvaluationMode transitionEvaluation { get; set; } // 0x00000001834A0D40-0x00000001834A0D50 0x00000001834A2250-0x00000001834A2260
	
		// Nested types
		public enum TransitionEvaluationMode // TypeDefIndex: 49004
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}
	
		// Constructors
		protected FSMState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public FSMConnection[] GetTransitions() => default; // 0x000000018B48B960-0x000000018B48BA70
		public void Finish() {} // 0x000000018B48B930-0x000000018B48B940
		public void Finish(bool inSuccess) {} // 0x000000018B48B940-0x000000018B48B960
		public void Finish(NodeCanvas.Framework.Status status) {} // 0x000000018B48B928-0x000000018B48B930
		public override void OnGraphPaused() {} // 0x000000018B48BBB0-0x000000018B48BBC4
		protected override bool CanConnectFromSource(NodeCanvas.Framework.Node sourceNode) => default; // 0x000000018B48B7A8-0x000000018B48B7C0
		protected override bool CanConnectToTarget(NodeCanvas.Framework.Node targetNode) => default; // 0x000000018B48B7C0-0x000000018B48B7D8
		protected sealed override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018B48BA70-0x000000018B48BBB0
		public bool CheckTransitions() => default; // 0x000000018B48B7D8-0x000000018B48B928
		protected sealed override void OnReset() {} // 0x000000018B48BBC4-0x000000018B48BC84
		protected virtual void OnInit() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnEnter() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnExit() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnPause() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class FSMStateNested<T> : FSMState, IGraphAssignable<T> // TypeDefIndex: 49006
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		private List<BBMappingParameter> _variablesMap;
		private T _currentInstance_k__BackingField;
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { get; set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FSMStateNested() {}
	}

	public interface IState // TypeDefIndex: 49007
	{
		// Properties
		string name { get; }
		string tag { get; }
		float elapsedTime { get; }
		FSM FSM { get; }
	
		// Methods
		FSMConnection[] GetTransitions();
		bool CheckTransitions();
		void Finish(bool success);
	}

	public interface IStateCallbackReceiver // TypeDefIndex: 49008
	{
		// Methods
		void OnStateEnter(IState state);
		void OnStateUpdate(IState state);
		void OnStateExit(IState state);
	}

	public class ActionState : FSMState, ITaskAssignable // TypeDefIndex: 49009
	{
		// Fields
		private ActionList _actionList; // 0xA0
		private bool _repeatStateActions; // 0xA8
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018B49CB50-0x000000018B49CBA8
		public ActionList actionList { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public bool repeatStateActions { get => default; set {} } // 0x0000000185FB8C10-0x0000000185FB8C20 0x0000000185FBC1E0-0x0000000185FBC1F0
	
		// Constructors
		public ActionState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B49CA84-0x000000018B49CB50
		protected override void OnEnter() {} // 0x000000018B49C9B8-0x000000018B49C9C8
		protected override void OnUpdate() {} // 0x000000018B49CA10-0x000000018B49CA84
		protected override void OnExit() {} // 0x000000018B49C9C8-0x000000018B49C9EC
		protected override void OnPause() {} // 0x000000018B49C9EC-0x000000018B49CA10
	}

	public class AnyState : FSMNode, IUpdatable // TypeDefIndex: 49010
	{
		// Fields
		public bool dontRetriggerStates; // 0x98
	
		// Properties
		public override string name { get => default; } // 0x000000018B49D080-0x000000018B49D0AC 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public AnyState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B49CEE4-0x000000018B49CFCC
		public override void OnGraphStoped() {} // 0x000000018B49CFCC-0x000000018B49D080
		void IUpdatable.Update() {} // 0x000000018B49CD10-0x000000018B49CEE4
	}

	public class ConcurrentSubFSM : FSMNodeNested<FSM>, IUpdatable // TypeDefIndex: 49011
	{
		// Fields
		protected BBParameter<FSM> _subFSM; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override FSM subGraph { get => default; set {} } // 0x000000018B49E290-0x000000018B49E2D8 0x000000018B49E2D8-0x000000018B49E330
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public ConcurrentSubFSM() {} // 0x000000018B49E25C-0x000000018B49E290
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B49E17C-0x000000018B49E25C
		void IUpdatable.Update() {} // 0x000000018B49E174-0x000000018B49E17C
		private void _OnGraphStarted_b__14_0(bool result) {} // 0x000000018B48B940-0x000000018B48B960
	}

	public class ConcurrentSubTree : FSMNodeNested<BehaviourTree>, IUpdatable // TypeDefIndex: 49012
	{
		// Fields
		protected BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override BehaviourTree subGraph { get => default; set {} } // 0x000000018B49E5F8-0x000000018B49E640 0x000000018B49E640-0x000000018B49E698
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public ConcurrentSubTree() {} // 0x000000018B49E5C4-0x000000018B49E5F8
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B49E4E4-0x000000018B49E5C4
		void IUpdatable.Update() {} // 0x000000018B49E174-0x000000018B49E17C
		private void _OnGraphStarted_b__14_0(bool result) {} // 0x000000018B48B940-0x000000018B48B960
	}

	public class EmptyState : FSMState // TypeDefIndex: 49013
	{
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
	
		// Constructors
		public EmptyState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B4A31C4-0x000000018B4A31EC
	}

	public class NestedBTState : FSMStateNested<BehaviourTree> // TypeDefIndex: 49016
	{
		// Fields
		private BBParameter<BehaviourTree> _nestedBT; // 0xB8
		public BTExitMode exitMode; // 0xC0
		public BTExecutionMode executionMode; // 0xC4
		public string successEvent; // 0xC8
		public string failureEvent; // 0xD0
	
		// Properties
		public override BehaviourTree subGraph { get => default; set {} } // 0x000000018B4ABFEC-0x000000018B4AC034 0x000000018B4AC034-0x000000018B4AC08C
		public override BBParameter subGraphParameter { get => default; } // 0x000000018349D710-0x000000018349D720 
	
		// Nested types
		public enum BTExecutionMode // TypeDefIndex: 49014
		{
			Once = 0,
			Repeat = 1
		}
	
		public enum BTExitMode // TypeDefIndex: 49015
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedBTState() {} // 0x000000018B4ABFAC-0x000000018B4ABFEC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B4ABBF8-0x000000018B4ABDC4
		protected override void OnUpdate() {} // 0x000000018B4ABEEC-0x000000018B4ABFAC
		private void OnFinish(bool success) {} // 0x000000018B4ABE6C-0x000000018B4ABEEC
		protected override void OnExit() {} // 0x000000018B4ABDC4-0x000000018B4ABE6C
	}

	public class NestedDTState : FSMStateNested<DialogueTree> // TypeDefIndex: 49017
	{
		// Fields
		private BBParameter<DialogueTree> _nestedDLG; // 0xB8
		public string successEvent; // 0xC0
		public string failureEvent; // 0xC8
	
		// Properties
		public override DialogueTree subGraph { get => default; set {} } // 0x000000018B4AC270-0x000000018B4AC2B8 0x000000018B4AC2B8-0x000000018B4AC310
		public override BBParameter subGraphParameter { get => default; } // 0x000000018349D710-0x000000018349D720 
	
		// Constructors
		public NestedDTState() {} // 0x000000018B4AC23C-0x000000018B4AC270
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B4AC08C-0x000000018B4AC168
		protected override void OnUpdate() {} // 0x000000018B4AC1E8-0x000000018B4AC23C
		protected override void OnExit() {} // 0x000000018B4AC168-0x000000018B4AC1E8
		private void OnDialogueFinished(bool success) {} // 0x000000018B4A3BF8-0x000000018B4A3C70
	}

	public class NestedFSMState : FSMStateNested<FSM> // TypeDefIndex: 49019
	{
		// Fields
		private BBParameter<FSM> _nestedFSM; // 0xB8
		public FSMExitMode exitMode; // 0xC0
	
		// Properties
		public override FSM subGraph { get => default; set {} } // 0x000000018B4AC7C4-0x000000018B4AC80C 0x000000018B4AC80C-0x000000018B4AC864
		public override BBParameter subGraphParameter { get => default; } // 0x000000018349D710-0x000000018349D720 
	
		// Nested types
		public enum FSMExitMode // TypeDefIndex: 49018
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedFSMState() {} // 0x000000018B4AC790-0x000000018B4AC7C4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B4AC5AC-0x000000018B4AC694
		protected override void OnUpdate() {} // 0x000000018B4AC73C-0x000000018B4AC790
		protected override void OnExit() {} // 0x000000018B4AC694-0x000000018B4AC73C
	}

	public class OnFSMEnter : FSMNode, IUpdatable // TypeDefIndex: 49020
	{
		// Fields
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public OnFSMEnter() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B4AD1DC-0x000000018B4AD34C
		public override void OnGraphStarted() {} // 0x000000018B4AD0B4-0x000000018B4AD190
		public override void OnGraphStoped() {} // 0x000000018B4AD190-0x000000018B4AD1DC
		void IUpdatable.Update() {} // 0x000000018B4AD048-0x000000018B4AD0B4
	}

	public class OnFSMExit : FSMNode // TypeDefIndex: 49021
	{
		// Fields
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public OnFSMExit() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B4AD470-0x000000018B4AD5E0
		public override void OnGraphStarted() {} // 0x000000018B4AD34C-0x000000018B4AD3A4
		public override void OnGraphStoped() {} // 0x000000018B4AD3A4-0x000000018B4AD470
	}

	public class OnFSMUpdate : FSMNode, IUpdatable // TypeDefIndex: 49022
	{
		// Fields
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public OnFSMUpdate() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B4AD6A8-0x000000018B4AD818
		public override void OnGraphStarted() {} // 0x000000018B4AD34C-0x000000018B4AD3A4
		public override void OnGraphStoped() {} // 0x000000018B4AD190-0x000000018B4AD1DC
		void IUpdatable.Update() {} // 0x000000018B4AD5E0-0x000000018B4AD6A8
	}

	public class SuperActionState : FSMState // TypeDefIndex: 49023
	{
		// Fields
		private ActionList _onEnterList; // 0xA0
		private ActionList _onUpdateList; // 0xA8
		private ActionList _onExitList; // 0xB0
		private bool enterListFinished; // 0xB8
	
		// Constructors
		public SuperActionState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B4B0720-0x000000018B4B08FC
		protected override void OnEnter() {} // 0x000000018B4B0538-0x000000018B4B054C
		protected override void OnUpdate() {} // 0x000000018B4B0638-0x000000018B4B0720
		protected override void OnExit() {} // 0x000000018B4B054C-0x000000018B4B05FC
		protected override void OnPause() {} // 0x000000018B4B05FC-0x000000018B4B0638
	}

	public class ConcurrentState : FSMNode, IUpdatable // TypeDefIndex: 49024
	{
		// Fields
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		private ActionList _actionList; // 0xA0
		private bool _repeatStateActions; // 0xA8
		private bool done; // 0xA9
	
		// Properties
		public NodeCanvas.Framework.ConditionList conditionList { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public ActionList actionList { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public bool repeatStateActions { get => default; set {} } // 0x0000000185FB8C10-0x0000000185FB8C20 0x0000000185FBC1E0-0x0000000185FBC1F0
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public ConcurrentState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B49E028-0x000000018B49E174
		public override void OnGraphStarted() {} // 0x000000018B49DF74-0x000000018B49DFD4
		public override void OnGraphStoped() {} // 0x000000018B49DFD4-0x000000018B49E028
		public override void OnGraphPaused() {} // 0x000000018B49C9EC-0x000000018B49CA10
		void IUpdatable.Update() {} // 0x000000018B49DE68-0x000000018B49DF74
	}

	public class EnterExitState : FSMNode, IUpdatable // TypeDefIndex: 49025
	{
		// Fields
		private ActionList _actionListEnter; // 0x98
		private ActionList _actionListExit; // 0xA0
	
		// Properties
		public ActionList actionListEnter { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public ActionList actionListExit { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public EnterExitState() {} // 0x0000000183055FD0-0x0000000183055FE0
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018B4A3354-0x000000018B4A348C
		public override void OnGraphStarted() {} // 0x000000018B4A3258-0x000000018B4A32C0
		public override void OnGraphStoped() {} // 0x000000018B4A32C0-0x000000018B4A3354
		void IUpdatable.Update() {} // 0x000000018B4A31EC-0x000000018B4A3258
	}

	public class ConcurrentSubFlowScript : FSMNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 49026
	{
		// Fields
		protected BBParameter<FlowScript> _subFlowScript; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x000000018B49C8E4-0x000000018B49C908 
		public override int maxInConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override int maxOutConnections { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool allowAsPrime { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override FlowScript subGraph { get => default; set {} } // 0x000000018B49E444-0x000000018B49E48C 0x000000018B49E48C-0x000000018B49E4E4
		public override BBParameter subGraphParameter { get => default; } // 0x000000018346D8F0-0x000000018346D900 
	
		// Constructors
		public ConcurrentSubFlowScript() {} // 0x000000018B49E410-0x000000018B49E444
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018B49E330-0x000000018B49E410
		void IUpdatable.Update() {} // 0x000000018B49E174-0x000000018B49E17C
		private void _OnGraphStarted_b__14_0(bool result) {} // 0x000000018B48B940-0x000000018B48B960
	}

	public class FlowScriptState : FSMStateNested<FlowScript> // TypeDefIndex: 49027
	{
		// Fields
		private BBParameter<FlowScript> _flowScript; // 0xB8
		public string successEvent; // 0xC0
		public string failureEvent; // 0xC8
	
		// Properties
		public override FlowScript subGraph { get => default; set {} } // 0x000000018B4A3CF8-0x000000018B4A3D40 0x000000018B4A3D40-0x000000018B4A3D98
		public override BBParameter subGraphParameter { get => default; } // 0x000000018349D710-0x000000018349D720 
	
		// Constructors
		public FlowScriptState() {} // 0x000000018B4A3CC4-0x000000018B4A3CF8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B4A3A8C-0x000000018B4A3B68
		protected override void OnUpdate() {} // 0x000000018B4A3C70-0x000000018B4A3CC4
		private void OnFlowScriptFinished(bool success) {} // 0x000000018B4A3BF8-0x000000018B4A3C70
		protected override void OnExit() {} // 0x000000018B4A3B68-0x000000018B4A3BF8
	}
}

namespace NodeCanvas.Tasks.Actions
{
	public class PlayAnimationAdvanced : ActionTask<UnityEngine.Animation> // TypeDefIndex: 48852
	{
		// Fields
		public BBParameter<AnimationClip> animationClip; // 0x68
		public UnityEngine.WrapMode animationWrap; // 0x70
		public AnimationBlendMode blendMode; // 0x74
		public float playbackSpeed; // 0x78
		public float crossFadeTime; // 0x7C
		public PlayDirections playDirection; // 0x80
		public BBParameter<string> mixTransformName; // 0x88
		public BBParameter<int> animationLayer; // 0x90
		public bool queueAnimation; // 0x98
		public bool waitActionFinish; // 0x99
		private string animationToPlay; // 0xA0
		private int dir; // 0xA8
		private Transform mixTransform; // 0xB0
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4964F4-0x000000018B49654C 
	
		// Constructors
		public PlayAnimationAdvanced() {} // 0x000000018B496474-0x000000018B4964F4
	
		// Methods
		protected override string OnInit() => default; // 0x000000018B4962F4-0x000000018B4963D8
		protected override void OnExecute() {} // 0x000000018B495E30-0x000000018B4962F4
		protected override void OnUpdate() {} // 0x000000018B4963D8-0x000000018B496474
		private Transform FindTransform(Transform parent, string name) => default; // 0x000000018B495D58-0x000000018B495E30
	}

	public class PlayAnimationSimple : ActionTask<UnityEngine.Animation> // TypeDefIndex: 48853
	{
		// Fields
		public BBParameter<AnimationClip> animationClip; // 0x68
		public float crossFadeTime; // 0x70
		public UnityEngine.WrapMode animationWrap; // 0x74
		public bool waitActionFinish; // 0x78
		private static Dictionary<UnityEngine.Animation, AnimationClip> lastPlayedClips; // 0x00
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4969CC-0x000000018B496A24 
	
		// Constructors
		public PlayAnimationSimple() {} // 0x000000018B496988-0x000000018B4969CC
		static PlayAnimationSimple() {} // 0x000000018B4968FC-0x000000018B496988
	
		// Methods
		protected override string OnInit() => default; // 0x000000018B496794-0x000000018B496878
		protected override void OnExecute() {} // 0x000000018B49654C-0x000000018B496794
		protected override void OnUpdate() {} // 0x000000018B496878-0x000000018B4968FC
	}

	public class MecanimPlayAnimation : ActionTask<Animator> // TypeDefIndex: 48854
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		public BBParameter<string> stateName; // 0x70
		public float transitTime; // 0x78
		public bool waitUntilFinish; // 0x7C
		private AnimatorStateInfo stateInfo; // 0x80
		private bool played; // 0xB4
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49424C-0x000000018B4942B4 
	
		// Constructors
		public MecanimPlayAnimation() {} // 0x000000018B494200-0x000000018B49424C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B493F0C-0x000000018B494074
		protected override void OnUpdate() {} // 0x000000018B494074-0x000000018B494200
	}

	public class MecanimSetBool : ActionTask<Animator> // TypeDefIndex: 48855
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<bool> setTo; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B494440-0x000000018B4944F0 
	
		// Constructors
		public MecanimSetBool() {} // 0x000000018B494404-0x000000018B494440
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4942B4-0x000000018B494404
	}

	public class MecanimSetFloat : ActionTask<Animator> // TypeDefIndex: 48856
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<float> setTo; // 0x78
		public float transitTime; // 0x80
		private float currentValue; // 0x84
	
		// Properties
		protected override string info { get => default; } // 0x000000018B494864-0x000000018B494914 
	
		// Constructors
		public MecanimSetFloat() {} // 0x000000018B494814-0x000000018B494864
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4945DC-0x000000018B494660
		protected override void OnUpdate() {} // 0x000000018B494660-0x000000018B494714
		private float Get() => default; // 0x000000018B4944F0-0x000000018B4945DC
		private void Set(float newValue) {} // 0x000000018B494714-0x000000018B494814
	}

	public class MecanimSetIK : ActionTask<Animator> // TypeDefIndex: 48857
	{
		// Fields
		public AvatarIKGoal IKGoal; // 0x68
		public BBParameter<GameObject> goal; // 0x70
		public BBParameter<float> weight; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B494BA8-0x000000018B494C64 
	
		// Constructors
		public MecanimSetIK() {} // 0x000000018B494B6C-0x000000018B494BA8
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B494A3C-0x000000018B494AD4
		protected override void OnStop() {} // 0x000000018B494AD4-0x000000018B494B6C
		private void OnAnimatorIK(EventData<int> msg) {} // 0x000000018B494914-0x000000018B494A3C
	}

	public class MecanimSetInt : ActionTask<Animator> // TypeDefIndex: 48858
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<int> setTo; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B494DE4-0x000000018B494E94 
	
		// Constructors
		public MecanimSetInt() {} // 0x000000018B494DA8-0x000000018B494DE4
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B494C64-0x000000018B494DA8
	}

	public class MecanimSetLayerWeight : ActionTask<Animator> // TypeDefIndex: 48859
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		public BBParameter<float> layerWeight; // 0x70
		public float transitTime; // 0x78
		private float currentValue; // 0x7C
	
		// Properties
		protected override string info { get => default; } // 0x000000018B495078-0x000000018B495118 
	
		// Constructors
		public MecanimSetLayerWeight() {} // 0x000000018B49503C-0x000000018B495078
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B494E94-0x000000018B494F18
		protected override void OnUpdate() {} // 0x000000018B494F18-0x000000018B49503C
	}

	public class MecanimSetLookAt : ActionTask<Animator> // TypeDefIndex: 48860
	{
		// Fields
		public BBParameter<GameObject> targetPosition; // 0x68
		public BBParameter<float> targetWeight; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49539C-0x000000018B4953FC 
	
		// Constructors
		public MecanimSetLookAt() {} // 0x000000018B495360-0x000000018B49539C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B495230-0x000000018B4952C8
		protected override void OnStop() {} // 0x000000018B4952C8-0x000000018B495360
		private void OnAnimatorIK(EventData<int> msg) {} // 0x000000018B495118-0x000000018B495230
	}

	public class MecanimSetTrigger : ActionTask<Animator> // TypeDefIndex: 48861
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B495530-0x000000018B4955DC 
	
		// Constructors
		public MecanimSetTrigger() {} // 0x000000018B4954F4-0x000000018B495530
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4953FC-0x000000018B4954F4
	}

	public class LoadScene : ActionTask // TypeDefIndex: 48862
	{
		// Fields
		public BBParameter<string> sceneName; // 0x68
		public BBParameter<LoadSceneMode> mode; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B493D18-0x000000018B493D58 
	
		// Constructors
		public LoadScene() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B493C68-0x000000018B493D18
	}

	public class PlayAudioAtPosition : ActionTask<Transform> // TypeDefIndex: 48863
	{
		// Fields
		public BBParameter<AudioClip> audioClip; // 0x68
		public float volume; // 0x70
		public bool waitActionFinish; // 0x74
	
		// Properties
		protected override string info { get => default; } // 0x000000018B496BAC-0x000000018B496C04 
	
		// Constructors
		public PlayAudioAtPosition() {} // 0x000000018B496B60-0x000000018B496BAC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B496A24-0x000000018B496AE0
		protected override void OnUpdate() {} // 0x000000018B496AE0-0x000000018B496B60
	}

	public class ComposeVector : ActionTask // TypeDefIndex: 48864
	{
		// Fields
		public BBParameter<float> x; // 0x68
		public BBParameter<float> y; // 0x70
		public BBParameter<float> z; // 0x78
		public BBParameter<Vector3> saveAs; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48763C-0x000000018B4876A0 
	
		// Constructors
		public ComposeVector() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48755C-0x000000018B48763C
	}

	public class DecomposeVector : ActionTask // TypeDefIndex: 48865
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		public BBParameter<float> x; // 0x70
		public BBParameter<float> y; // 0x78
		public BBParameter<float> z; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4888CC-0x000000018B48892C 
	
		// Constructors
		public DecomposeVector() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4887C4-0x000000018B4888CC
	}

	public class AddElementToDictionary<T> : ActionTask // TypeDefIndex: 48866
	{
		// Fields
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public AddElementToDictionary() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class GetDictionaryElement<T> : ActionTask // TypeDefIndex: 48867
	{
		// Fields
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public GetDictionaryElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class EvaluateCurve : ActionTask // TypeDefIndex: 48868
	{
		// Fields
		public BBParameter<AnimationCurve> curve; // 0x68
		public BBParameter<float> from; // 0x70
		public BBParameter<float> to; // 0x78
		public BBParameter<float> time; // 0x80
		public BBParameter<float> saveAs; // 0x88
	
		// Constructors
		public EvaluateCurve() {} // 0x000000018B488BE4-0x000000018B488C60
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B488A70-0x000000018B488BE4
	}

	public class GetSelf : ActionTask // TypeDefIndex: 48869
	{
		// Fields
		public BBParameter<GameObject> saveAs; // 0x68
	
		// Constructors
		public GetSelf() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B491548-0x000000018B4915C4
	}

	public class GetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 48870
	{
		// Fields
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B490890-0x000000018B4908D4 
	
		// Constructors
		public GetOtherBlackboardVariable() {} // 0x000000018B490854-0x000000018B490890
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B490788-0x000000018B490854
	}

	public class GetToString : ActionTask // TypeDefIndex: 48871
	{
		// Fields
		public BBParameter<object> variable; // 0x68
		public BBParameter<string> toString; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B491684-0x000000018B4916C8 
	
		// Constructors
		public GetToString() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4915C4-0x000000018B491684
	}

	public class AddElementToList<T> : ActionTask // TypeDefIndex: 48872
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public AddElementToList() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class ClearList : ActionTask // TypeDefIndex: 48873
	{
		// Fields
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48751C-0x000000018B48755C 
	
		// Constructors
		public ClearList() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4874B8-0x000000018B48751C
	}

	public class GetCloserGameObjectInList : ActionTask<Transform> // TypeDefIndex: 48874
	{
		// Fields
		public BBParameter<List<GameObject>> list; // 0x68
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48E878-0x000000018B48E918 
	
		// Constructors
		public GetCloserGameObjectInList() {} // 0x000000018B48E83C-0x000000018B48E878
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48E56C-0x000000018B48E83C
	}

	public class GetIndexOfElement<T> : ActionTask // TypeDefIndex: 48875
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
		public BBParameter<int> saveIndexAs;
	
		// Constructors
		public GetIndexOfElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class GetListCount : ActionTask // TypeDefIndex: 48876
	{
		// Fields
		public BBParameter<IList> targetList; // 0x68
		public BBParameter<int> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4905C8-0x000000018B49060C 
	
		// Constructors
		public GetListCount() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B490538-0x000000018B4905C8
	}

	public class InsertElementToList<T> : ActionTask // TypeDefIndex: 48877
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
		public BBParameter<int> targetIndex;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public InsertElementToList() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class PickListElement<T> : ActionTask // TypeDefIndex: 48878
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public PickListElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class PickRandomListElement<T> : ActionTask // TypeDefIndex: 48879
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public PickRandomListElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class RemoveElementFromList<T> : ActionTask // TypeDefIndex: 48880
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public RemoveElementFromList() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class SetListElement<T> : ActionTask // TypeDefIndex: 48881
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		public BBParameter<T> newValue;
	
		// Constructors
		public SetListElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class ShuffleList : ActionTask // TypeDefIndex: 48882
	{
		// Fields
		public BBParameter<IList> targetList; // 0x68
	
		// Constructors
		public ShuffleList() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49A92C-0x000000018B49AA2C
	}

	public class SortGameObjectListByDistance : ActionTask<Transform> // TypeDefIndex: 48883
	{
		// Fields
		public BBParameter<List<GameObject>> targetList; // 0x68
		public BBParameter<List<GameObject>> saveAs; // 0x70
		public bool reverse; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49AC84-0x000000018B49AD24 
	
		// Constructors
		public SortGameObjectListByDistance() {} // 0x000000018B49AC48-0x000000018B49AC84
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49AA2C-0x000000018B49AB84
		private float _OnExecute_b__5_0(GameObject go) => default; // 0x000000018B49AB84-0x000000018B49AC48
	}

	public class LoadBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 48884
	{
		// Fields
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B493C10-0x000000018B493C68 
	
		// Constructors
		public LoadBlackboard() {} // 0x000000018B493BD4-0x000000018B493C10
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B493B48-0x000000018B493BD4
	}

	public class NormalizeVector : ActionTask // TypeDefIndex: 48885
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		public BBParameter<float> multiply; // 0x70
	
		// Constructors
		public NormalizeVector() {} // 0x000000018B495D04-0x000000018B495D58
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B495BF0-0x000000018B495D04
	}

	public class SampleCurve : ActionTask // TypeDefIndex: 48886
	{
		// Fields
		public BBParameter<AnimationCurve> curve; // 0x68
		public BBParameter<float> sampleAt; // 0x70
		public BBParameter<float> saveAs; // 0x78
	
		// Constructors
		public SampleCurve() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B497640-0x000000018B497704
	}

	public class SaveBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 48887
	{
		// Fields
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4977CC-0x000000018B497824 
	
		// Constructors
		public SaveBlackboard() {} // 0x000000018B497790-0x000000018B4977CC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B497704-0x000000018B497790
	}

	public class SetBoolean : ActionTask // TypeDefIndex: 48889
	{
		// Fields
		public BBParameter<bool> boolVariable; // 0x68
		public BoolSetModes setTo; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4983F0-0x000000018B4984D4 
	
		// Nested types
		public enum BoolSetModes // TypeDefIndex: 48888
		{
			False = 0,
			True = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetBoolean() {} // 0x0000000185FD2AA0-0x0000000185FD2AB0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B498358-0x000000018B4983F0
	}

	public class SetBooleanRandom : ActionTask // TypeDefIndex: 48890
	{
		// Fields
		public BBParameter<bool> boolVariable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4982E4-0x000000018B498358 
	
		// Constructors
		public SetBooleanRandom() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B498270-0x000000018B4982E4
	}

	public class SetEnum : ActionTask // TypeDefIndex: 48891
	{
		// Fields
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49864C-0x000000018B4986D4 
	
		// Constructors
		public SetEnum() {} // 0x000000018B498558-0x000000018B49864C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4984D4-0x000000018B498558
	}

	public class SetFloat : ActionTask // TypeDefIndex: 48892
	{
		// Fields
		public BBParameter<float> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<float> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B498EA8-0x000000018B498FD4 
	
		// Constructors
		public SetFloat() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B498DBC-0x000000018B498EA8
	}

	public class SetFloatRandom : ActionTask // TypeDefIndex: 48893
	{
		// Fields
		public BBParameter<float> minValue; // 0x68
		public BBParameter<float> maxValue; // 0x70
		public BBParameter<float> floatVariable; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B498C60-0x000000018B498DBC 
	
		// Constructors
		public SetFloatRandom() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B498BAC-0x000000018B498C60
	}

	public class SetInt : ActionTask // TypeDefIndex: 48894
	{
		// Fields
		public BBParameter<int> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49928C-0x000000018B499308 
	
		// Constructors
		public SetInt() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4991E0-0x000000018B49928C
	}

	public class SetIntRandom : ActionTask // TypeDefIndex: 48895
	{
		// Fields
		public BBParameter<int> minValue; // 0x68
		public BBParameter<int> maxValue; // 0x70
		public BBParameter<int> intVariable; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B499084-0x000000018B4991E0 
	
		// Constructors
		public SetIntRandom() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B498FD4-0x000000018B499084
	}

	public class SetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 48896
	{
		// Fields
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter newValue; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B499844-0x000000018B4998E0 
	
		// Constructors
		public SetOtherBlackboardVariable() {} // 0x000000018B499808-0x000000018B499844
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B499748-0x000000018B499808
	}

	public class SetVariable<T> : ActionTask // TypeDefIndex: 48897
	{
		// Fields
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SetVariable() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class SetVector3 : ActionTask // TypeDefIndex: 48898
	{
		// Fields
		public BBParameter<Vector3> valueA; // 0x68
		public OperationMethod operation; // 0x70
		public BBParameter<Vector3> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49A2C8-0x000000018B49A3F4 
	
		// Constructors
		public SetVector3() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49A19C-0x000000018B49A2C8
	}

	public class TriggerBoolean : ActionTask // TypeDefIndex: 48900
	{
		// Fields
		public BBParameter<bool> variable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49B680-0x000000018B49B700 
	
		// Nested types
		private sealed class _Flip_d__4 : IEnumerator<object> // TypeDefIndex: 48899
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TriggerBoolean __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181ADBED0-0x0000000181ADBEE0 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _Flip_d__4() {} // Dummy constructor
			public _Flip_d__4(int __1__state) {} // 0x000000018B49B640-0x000000018B49B680
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B49B5AC-0x000000018B49B640
			private bool MoveNext() => default; // 0x000000018B49B550-0x000000018B49B5AC
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public TriggerBoolean() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override void OnExecute() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator Flip() => default; // 0x000000018B49B700-0x000000018B49B74C
	}

	public class FadeIn : ActionTask // TypeDefIndex: 48901
	{
		// Constructors
		public FadeIn() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	}

	public class FadeOut : ActionTask // TypeDefIndex: 48902
	{
		// Constructors
		public FadeOut() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	}

	public class Say : ActionTask<IDialogueActor> // TypeDefIndex: 48903
	{
		// Fields
		public Statement statement; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B497BA0-0x000000018B497C18 
	
		// Constructors
		public Say() {} // 0x000000018B497B14-0x000000018B497BA0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B497A08-0x000000018B497B14
	}

	public class SayRandom : ActionTask<IDialogueActor> // TypeDefIndex: 48904
	{
		// Fields
		public List<Statement> statements; // 0x68
	
		// Constructors
		public SayRandom() {} // 0x000000018B49797C-0x000000018B497A08
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B497824-0x000000018B49797C
	}

	public class StartDialogueTree : ActionTask<IDialogueActor> // TypeDefIndex: 48905
	{
		// Fields
		public BBParameter<DialogueTreeController> dialogueTreeController; // 0x68
		public bool waitActionFinish; // 0x70
		public bool isPrefab; // 0x71
		private DialogueTreeController instance; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49AFF8-0x000000018B49B038 
	
		// Constructors
		public StartDialogueTree() {} // 0x000000018B49AFB4-0x000000018B49AFF8
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49AD24-0x000000018B49AED0
		private void _OnExecute_b__6_0(bool success) {} // 0x000000018B49AED0-0x000000018B49AF54
		private void _OnExecute_b__6_1(bool success) {} // 0x000000018B49AF54-0x000000018B49AFB4
	}

	public class CreateGameObject : ActionTask // TypeDefIndex: 48906
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		public BBParameter<GameObject> saveAs; // 0x80
	
		// Constructors
		public CreateGameObject() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4876A0-0x000000018B487820
	}

	public class CreatePrimitive : ActionTask // TypeDefIndex: 48907
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		public BBParameter<PrimitiveType> type; // 0x80
		public BBParameter<GameObject> saveAs; // 0x88
	
		// Constructors
		public CreatePrimitive() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B487820-0x000000018B4879B8
	}

	public class DestroyGameObject : ActionTask<Transform> // TypeDefIndex: 48908
	{
		// Fields
		public bool immediately; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B488A28-0x000000018B488A70 
	
		// Constructors
		public DestroyGameObject() {} // 0x000000018B4889EC-0x000000018B488A28
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B48892C-0x000000018B4889EC
	}

	public class FindAllWithLayer : ActionTask // TypeDefIndex: 48909
	{
		// Fields
		public BBParameter<LayerMask> targetLayers; // 0x68
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48D100-0x000000018B48D1A0 
	
		// Constructors
		public FindAllWithLayer() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48D020-0x000000018B48D100
	}

	public class FindAllWithName : ActionTask // TypeDefIndex: 48910
	{
		// Fields
		public BBParameter<string> searchName; // 0x68
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48D388-0x000000018B48D428 
	
		// Constructors
		public FindAllWithName() {} // 0x000000018B48D328-0x000000018B48D388
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48D1A0-0x000000018B48D328
	}

	public class FindAllWithTag : ActionTask // TypeDefIndex: 48911
	{
		// Fields
		public BBParameter<string> searchTag; // 0x68
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48D568-0x000000018B48D608 
	
		// Constructors
		public FindAllWithTag() {} // 0x000000018B48D508-0x000000018B48D568
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48D428-0x000000018B48D508
	}

	public class FindChildByName : ActionTask<Transform> // TypeDefIndex: 48912
	{
		// Fields
		public BBParameter<string> childName; // 0x68
		public BBParameter<Transform> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48D780-0x000000018B48D7E0 
	
		// Constructors
		public FindChildByName() {} // 0x000000018B48D744-0x000000018B48D780
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48D608-0x000000018B48D744
	}

	public class FindClosestWithTag : ActionTask<Transform> // TypeDefIndex: 48913
	{
		// Fields
		public BBParameter<string> searchTag; // 0x68
		public BBParameter<bool> ignoreChildren; // 0x70
		public BBParameter<GameObject> saveObjectAs; // 0x78
		public BBParameter<float> saveDistanceAs; // 0x80
	
		// Constructors
		public FindClosestWithTag() {} // 0x000000018B48DB78-0x000000018B48DBB4
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48D8AC-0x000000018B48DB78
	}

	public class FindObjectOfType<T> : ActionTask // TypeDefIndex: 48914
		where T : Component
	{
		// Fields
		public BBParameter<T> saveComponentAs;
		public BBParameter<GameObject> saveGameObjectAs;
	
		// Constructors
		public FindObjectOfType() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class FindObjectsOfType<T> : ActionTask // TypeDefIndex: 48916
		where T : Component
	{
		// Fields
		public BBParameter<List<GameObject>> saveGameObjects;
		public BBParameter<List<T>> saveComponents;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48915
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<T, GameObject> __9__2_0;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal GameObject _OnExecute_b__2_0(T o) => default;
		}
	
		// Constructors
		public FindObjectsOfType() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class FindWithName : ActionTask // TypeDefIndex: 48917
	{
		// Fields
		public BBParameter<string> gameObjectName; // 0x68
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48DC40-0x000000018B48DCE0 
	
		// Constructors
		public FindWithName() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48DBB4-0x000000018B48DC40
	}

	public class FindWithTag : ActionTask // TypeDefIndex: 48918
	{
		// Fields
		public string searchTag; // 0x68
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48DD94-0x000000018B48DE20 
	
		// Constructors
		public FindWithTag() {} // 0x000000018B48DD4C-0x000000018B48DD94
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48DCE0-0x000000018B48DD4C
	}

	public class GetAllChildGameObjects : ActionTask<Transform> // TypeDefIndex: 48920
	{
		// Fields
		public BBParameter<List<GameObject>> saveAs; // 0x68
		public bool recursive; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48E490-0x000000018B48E4CC 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48919
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, GameObject> __9__4_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B48E4CC-0x000000018B48E56C
			public __c() {} // 0x000000018B48E0D0-0x000000018B48E490
	
			// Methods
			internal GameObject _OnExecute_b__4_0(Transform t) => default; // 0x000000018B48DEC0-0x000000018B48E0D0
		}
	
		// Constructors
		public GetAllChildGameObjects() {} // 0x00000001889A3590-0x00000001889A35B0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49BCE0-0x000000018B49BD44
		private List<Transform> Get(Transform parent) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class GetComponent<T> : ActionTask<Transform> // TypeDefIndex: 48921
		where T : Component
	{
		// Fields
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public GetComponent() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class GetDistance : ActionTask<Transform> // TypeDefIndex: 48922
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48EA7C-0x000000018B48EAD4 
	
		// Constructors
		public GetDistance() {} // 0x000000018B48EA40-0x000000018B48EA7C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48E918-0x000000018B48EA40
	}

	public class GetGameObjectPosition : ActionTask<Transform> // TypeDefIndex: 48923
	{
		// Fields
		public BBParameter<Vector3> saveAs; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B48F0AC-0x000000018B48F140 
	
		// Constructors
		public GetGameObjectPosition() {} // 0x000000018B48F070-0x000000018B48F0AC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48EFCC-0x000000018B48F070
	}

	public class InstantiateGameObject : ActionTask<Transform> // TypeDefIndex: 48924
	{
		// Fields
		public BBParameter<Transform> parent; // 0x68
		public BBParameter<Vector3> clonePosition; // 0x70
		public BBParameter<Vector3> cloneRotation; // 0x78
		public BBParameter<GameObject> saveCloneAs; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B492D00-0x000000018B492EE4 
	
		// Constructors
		public InstantiateGameObject() {} // 0x000000018B492CC4-0x000000018B492D00
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B492B00-0x000000018B492CC4
	}

	public class LookAt : ActionTask<Transform> // TypeDefIndex: 48925
	{
		// Fields
		public BBParameter<GameObject> lookTarget; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B493EAC-0x000000018B493F0C 
	
		// Constructors
		public LookAt() {} // 0x000000018B493E70-0x000000018B493EAC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B493E68-0x000000018B493E70
		protected override void OnUpdate() {} // 0x000000018B493E68-0x000000018B493E70
		private void DoLook() {} // 0x000000018B493D58-0x000000018B493E68
	}

	public class RemoveComponent<T> : ActionTask<Transform> // TypeDefIndex: 48926
		where T : Component
	{
		// Fields
		public bool immediately;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public RemoveComponent() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class SetObjectActive : ActionTask<Transform> // TypeDefIndex: 48928
	{
		// Fields
		public SetActiveMode setTo; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49940C-0x000000018B499488 
	
		// Nested types
		public enum SetActiveMode // TypeDefIndex: 48927
		{
			Deactivate = 0,
			Activate = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectActive() {} // 0x000000018B4993C0-0x000000018B49940C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B499308-0x000000018B4993C0
	}

	public class SetObjectEnabled : ActionTask<MonoBehaviour> // TypeDefIndex: 48930
	{
		// Fields
		public SetEnableMode setTo; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49956C-0x000000018B4995E8 
	
		// Nested types
		public enum SetEnableMode // TypeDefIndex: 48929
		{
			Disable = 0,
			Enable = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectEnabled() {} // 0x000000018B499520-0x000000018B49956C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B499488-0x000000018B499520
	}

	public class SetObjectVisibility : ActionTask<Renderer> // TypeDefIndex: 48932
	{
		// Fields
		public SetVisibleMode setTo; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4996CC-0x000000018B499748 
	
		// Nested types
		public enum SetVisibleMode // TypeDefIndex: 48931
		{
			Hide = 0,
			Show = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectVisibility() {} // 0x000000018B499680-0x000000018B4996CC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4995E8-0x000000018B499680
	}

	public class GetInputAxis : ActionTask // TypeDefIndex: 48933
	{
		// Fields
		public BBParameter<string> xAxisName; // 0x68
		public BBParameter<string> yAxisName; // 0x70
		public BBParameter<string> zAxisName; // 0x78
		public BBParameter<float> multiplier; // 0x80
		public BBParameter<Vector3> saveAs; // 0x88
		public BBParameter<float> saveXAs; // 0x90
		public BBParameter<float> saveYAs; // 0x98
		public BBParameter<float> saveZAs; // 0xA0
		public bool repeat; // 0xA8
	
		// Constructors
		public GetInputAxis() {} // 0x000000018B48F404-0x000000018B48F4C4
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48F3FC-0x000000018B48F404
		protected override void OnUpdate() {} // 0x000000018B48F3FC-0x000000018B48F404
		private void Do() {} // 0x000000018B48F140-0x000000018B48F3FC
	}

	public class GetMousePosition : ActionTask // TypeDefIndex: 48934
	{
		// Fields
		public BBParameter<Vector3> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Constructors
		public GetMousePosition() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B490694-0x000000018B49069C
		protected override void OnUpdate() {} // 0x000000018B490694-0x000000018B49069C
		private void Do() {} // 0x000000018B49060C-0x000000018B490694
	}

	public class GetMouseScrollDelta : ActionTask // TypeDefIndex: 48935
	{
		// Fields
		public BBParameter<float> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B490728-0x000000018B490788 
	
		// Constructors
		public GetMouseScrollDelta() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B490720-0x000000018B490728
		protected override void OnUpdate() {} // 0x000000018B490720-0x000000018B490728
		private void Do() {} // 0x000000018B49069C-0x000000018B490720
	}

	public class WaitMousePick : ActionTask // TypeDefIndex: 48937
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		public BBParameter<GameObject> saveObjectAs; // 0x70
		public BBParameter<float> saveDistanceAs; // 0x78
		public BBParameter<Vector3> savePositionAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit hit; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49C278-0x000000018B49C2DC 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 48936
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick() {} // 0x0000000185FD2AE0-0x0000000185FD2B00
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B49C0BC-0x000000018B49C278
	}

	public class WaitMousePick2D : ActionTask // TypeDefIndex: 48939
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		public BBParameter<GameObject> saveObjectAs; // 0x70
		public BBParameter<float> saveDistanceAs; // 0x78
		public BBParameter<Vector3> savePositionAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit2D hit; // 0x8C
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49C058-0x000000018B49C0BC 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 48938
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick2D() {} // 0x0000000185FD2AE0-0x0000000185FD2B00
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B49BDE8-0x000000018B49C058
	}

	public class CurveTransformTween : ActionTask<Transform> // TypeDefIndex: 48943
	{
		// Fields
		public TransformMode transformMode; // 0x68
		public TweenMode mode; // 0x6C
		public PlayMode playMode; // 0x70
		public BBParameter<Vector3> targetPosition; // 0x78
		public BBParameter<AnimationCurve> curve; // 0x80
		public BBParameter<float> time; // 0x88
		private Vector3 original; // 0x90
		private Vector3 final; // 0x9C
		private bool ponging; // 0xA8
	
		// Nested types
		public enum TransformMode // TypeDefIndex: 48940
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}
	
		public enum TweenMode // TypeDefIndex: 48941
		{
			Absolute = 0,
			Additive = 1
		}
	
		public enum PlayMode // TypeDefIndex: 48942
		{
			Normal = 0,
			PingPong = 1
		}
	
		// Constructors
		public CurveTransformTween() {} // 0x000000018B487E0C-0x000000018B487EBC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B4879B8-0x000000018B487BEC
		protected override void OnUpdate() {} // 0x000000018B487BEC-0x000000018B487E0C
	}

	public class InputMove : ActionTask<Transform> // TypeDefIndex: 48944
	{
		// Fields
		public BBParameter<float> strafe; // 0x68
		public BBParameter<float> turn; // 0x70
		public BBParameter<float> forward; // 0x78
		public BBParameter<float> up; // 0x80
		public BBParameter<float> moveSpeed; // 0x88
		public BBParameter<float> rotationSpeed; // 0x90
		public bool repeat; // 0x98
	
		// Constructors
		public InputMove() {} // 0x000000018B492A74-0x000000018B492B00
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B492530-0x000000018B492A74
	}

	public class MoveAway : ActionTask<Transform> // TypeDefIndex: 48945
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveAway() {} // 0x000000018B495868-0x000000018B4958E8
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B4955DC-0x000000018B495868
	}

	public class MoveTowards : ActionTask<Transform> // TypeDefIndex: 48946
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveTowards() {} // 0x000000018B495B70-0x000000018B495BF0
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B4958E8-0x000000018B495B70
	}

	public class RotateAway : ActionTask<Transform> // TypeDefIndex: 48947
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> angleDifference; // 0x78
		public BBParameter<Vector3> upVector; // 0x80
		public bool waitActionFinish; // 0x88
	
		// Constructors
		public RotateAway() {} // 0x000000018B49713C-0x000000018B497200
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B496D9C-0x000000018B49713C
	}

	public class RotateTowards : ActionTask<Transform> // TypeDefIndex: 48948
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> angleDifference; // 0x78
		public BBParameter<Vector3> upVector; // 0x80
		public bool waitActionFinish; // 0x88
	
		// Constructors
		public RotateTowards() {} // 0x000000018B49757C-0x000000018B497640
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B497200-0x000000018B49757C
	}

	public class FindClosestEdge : ActionTask // TypeDefIndex: 48949
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		public BBParameter<Vector3> saveFoundPosition; // 0x70
		private NavMeshHit hit; // 0x78
	
		// Constructors
		public FindClosestEdge() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48D7E0-0x000000018B48D8AC
	}

	public class GetLinecastInfo : ActionTask<Transform> // TypeDefIndex: 48950
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		public BBParameter<GameObject> saveHitGameObjectAs; // 0x78
		public BBParameter<float> saveDistanceAs; // 0x80
		public BBParameter<Vector3> savePointAs; // 0x88
		public BBParameter<Vector3> saveNormalAs; // 0x90
		private RaycastHit hit; // 0x98
	
		// Constructors
		public GetLinecastInfo() {} // 0x000000018B4904DC-0x000000018B490538
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B490270-0x000000018B4904DC
		public override void OnDrawGizmosSelected() {} // 0x000000018B490110-0x000000018B490270
	}

	public class GetLinecastInfo2D : ActionTask<Transform> // TypeDefIndex: 48951
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public LayerMask mask; // 0x70
		public BBParameter<GameObject> saveHitGameObjectAs; // 0x78
		public BBParameter<float> saveDistanceAs; // 0x80
		public BBParameter<Vector3> savePointAs; // 0x88
		public BBParameter<Vector3> saveNormalAs; // 0x90
		private RaycastHit2D hit; // 0x98
	
		// Constructors
		public GetLinecastInfo2D() {} // 0x000000018B4900C4-0x000000018B490110
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48FDE4-0x000000018B4900C4
		public override void OnDrawGizmosSelected() {} // 0x000000018B48FC84-0x000000018B48FDE4
	}

	public class GetLinecastInfo2DAll : ActionTask<Transform> // TypeDefIndex: 48953
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public LayerMask mask; // 0x70
		public BBParameter<List<GameObject>> saveHitGameObjectsAs; // 0x78
		public BBParameter<List<float>> saveDistancesAs; // 0x80
		public BBParameter<List<Vector3>> savePointsAs; // 0x88
		public BBParameter<List<Vector3>> saveNormalsAs; // 0x90
		private RaycastHit2D[] hits; // 0x98
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48952
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RaycastHit2D, GameObject> __9__7_0; // 0x08
			public static Func<RaycastHit2D, float> __9__7_1; // 0x10
			public static Func<RaycastHit2D, Vector3> __9__7_3; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018B48F624-0x000000018B48FB80
			public __c() {} // 0x000000018B48F4C4-0x000000018B48F624
	
			// Methods
			internal GameObject _OnExecute_b__7_0(RaycastHit2D h) => default; // 0x000000018B48FC38-0x000000018B48FC84
			internal float _OnExecute_b__7_1(RaycastHit2D h) => default; // 0x000000018B48FB80-0x000000018B48FC38
			internal Vector3 _OnExecute_b__7_3(RaycastHit2D h) => default; // 0x000000018B49BC7C-0x000000018B49BCE0
		}
	
		// Constructors
		public GetLinecastInfo2DAll() {} // 0x0000000185FD2AB0-0x0000000185FD2AC0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000185492010-0x0000000185492020
		public override void OnDrawGizmosSelected() {} // 0x000000018B49BA4C-0x000000018B49BA74
		private Vector3 _OnExecute_b__7_2(RaycastHit2D h) => default; // 0x0000000185FD2AC0-0x0000000185FD2AE0
	}

	public class GetOverlapSphereObjects : ActionTask<Transform> // TypeDefIndex: 48955
	{
		// Fields
		public LayerMask layerMask; // 0x68
		public BBParameter<float> radius; // 0x70
		public BBParameter<List<GameObject>> saveObjectsAs; // 0x78
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48954
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ECSColliderResultProxy, GameObject> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4909D8-0x000000018B490C74
			public __c() {} // 0x000000018B4908D4-0x000000018B4909D8
	
			// Methods
			internal GameObject _OnExecute_b__3_0(ECSColliderResultProxy c) => default; // 0x000000018B490C74-0x000000018B490CD8
		}
	
		// Constructors
		public GetOverlapSphereObjects() {} // 0x000000018B49BA00-0x000000018B49BA4C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49BB50-0x000000018B49BBB4
		public override void OnDrawGizmosSelected() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 48957
	{
		// Fields
		protected SerializedMethodInfo method; // 0x68
		protected List<BBObjectParameter> parameters; // 0x70
		protected BBObjectParameter returnValue; // 0x78
		private object[] args; // 0x80
		private bool routineRunning; // 0x88
		private bool[] parameterIsByRef; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B488D48-0x000000018B488FE0 
		public override System.Type agentType { get => default; } // 0x0000000185FD2A50-0x0000000185FD2A60 
		protected override string info { get => default; } // 0x000000018B488CD4-0x000000018B488D48 
	
		// Nested types
		private sealed class _InternalCoroutine_d__17 : IEnumerator<object> // TypeDefIndex: 48956
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ExecuteFunction_Multiplatform __4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001813AC280-0x00000001813AC290 
			object IEnumerator.Current { get => default; } // 0x000000018B488FE0-0x000000018B489168 
	
			// Constructors
			public _InternalCoroutine_d__17() {} // Dummy constructor
			public _InternalCoroutine_d__17(int __1__state) {} // 0x000000018B479870-0x000000018B479880
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4894EC-0x000000018B4895B0
			private bool MoveNext() => default; // 0x000000018B4895B0-0x000000018B489930
			void IEnumerator.Reset() {} // 0x000000018B489168-0x000000018B489190
		}
	
		// Constructors
		public ExecuteFunction_Multiplatform() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B489190-0x000000018B48946C
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B48946C-0x000000018B4894EC
		protected override string OnInit() => default; // 0x0000000181378230-0x0000000181378240
		protected override void OnExecute() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnStop() {} // 0x000000018B49B86C-0x000000018B49B954
		private IEnumerator InternalCoroutine(IEnumerator routine) => default; // 0x0000000181377E40-0x0000000181377E50
		private void SetMethod(MethodInfo method) {} // 0x000000018B49B954-0x000000018B49B9A0
	}

	internal class GetField_0 // TypeDefIndex: 48958
	{
		// Fields
		public System.Type targetType; // 0x10
		public string fieldName; // 0x18
	
		// Constructors
		public GetField_0() {} // 0x0000000185492010-0x0000000185492020
	}

	public class GetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.GetField_0> // TypeDefIndex: 48959
	{
		// Fields
		protected SerializedFieldInfo field; // 0x68
		protected BBObjectParameter saveAs; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get => default; } // 0x0000000189E6F710-0x0000000189E6F720 
		public override System.Type agentType { get => default; } // 0x000000018B48ED8C-0x000000018B48EE5C 
		protected override string info { get => default; } // 0x000000018B48EE5C-0x000000018B48EFCC 
	
		// Constructors
		public GetField() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		void IMigratable<GetField_0>.Migrate(GetField_0 model) {} // 0x000000018B48EC24-0x000000018B48ECDC
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		protected override string OnInit() => default; // 0x000000018B48EB8C-0x000000018B48EC24
		protected override void OnExecute() {} // 0x000000018B48EAD4-0x000000018B48EB8C
		private void SetTargetField(System.Reflection.FieldInfo newField) {} // 0x000000018B48ECDC-0x000000018B48ED8C
	}

	public class GetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 48960
	{
		// Fields
		protected SerializedMethodInfo method; // 0x68
		protected BBObjectParameter returnValue; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B479870-0x000000018B479880 
		public override System.Type agentType { get => default; } // 0x000000018B490EF4-0x000000018B490FB8 
		protected override string info { get => default; } // 0x000000018B490FB8-0x000000018B49111C 
	
		// Constructors
		public GetProperty_Multiplatform() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B490E1C-0x000000018B490E44
		protected override string OnInit() => default; // 0x000000018B490D94-0x000000018B490E1C
		protected override void OnExecute() {} // 0x000000018B490CD8-0x000000018B490D94
		private void SetMethod(MethodInfo method) {} // 0x000000018B490E44-0x000000018B490EF4
	}

	public class ImplementedAction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 48961
	{
		// Fields
		private SerializedMethodInfo method; // 0x68
		private List<BBObjectParameter> parameters; // 0x70
		private NodeCanvas.Framework.Status actionStatus; // 0x78
		private object[] args; // 0x80
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B479870-0x000000018B479880 
		public override System.Type agentType { get => default; } // 0x000000018B491EA4-0x000000018B491F68 
		protected override string info { get => default; } // 0x000000018B491F68-0x000000018B492120 
	
		// Constructors
		public ImplementedAction_Multiplatform() {} // 0x000000018B491E20-0x000000018B491EA4
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B491C80-0x000000018B491CA8
		protected override string OnInit() => default; // 0x000000018B491A38-0x000000018B491B1C
		protected override void OnUpdate() {} // 0x000000018B491B1C-0x000000018B491C80
		protected override void OnStop() {} // 0x0000000185FD2A70-0x0000000185FD2A80
		private void SetMethod(MethodInfo method) {} // 0x000000018B491CA8-0x000000018B491E20
	}

	public class SendMessage : ActionTask<Transform> // TypeDefIndex: 48962
	{
		// Fields
		public BBParameter<string> methodName; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B498230-0x000000018B498270 
	
		// Constructors
		public SendMessage() {} // 0x000000018B4981F4-0x000000018B498230
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B498168-0x000000018B4981F4
	}

	public class SendMessage<T> : ActionTask<Transform> // TypeDefIndex: 48963
	{
		// Fields
		public BBParameter<string> methodName;
		public BBParameter<T> argument;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendMessage() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class SendMessageToType<T> : ActionTask // TypeDefIndex: 48964
		where T : Component
	{
		// Fields
		public BBParameter<string> message;
		public BBParameter<object> argument;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendMessageToType() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	internal class SetField_0 // TypeDefIndex: 48965
	{
		// Fields
		public System.Type targetType; // 0x10
		public string fieldName; // 0x18
	
		// Constructors
		public SetField_0() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.SetField_0> // TypeDefIndex: 48966
	{
		// Fields
		protected SerializedFieldInfo field; // 0x68
		protected BBObjectParameter setValue; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get => default; } // 0x0000000189E6F710-0x0000000189E6F720 
		public override System.Type agentType { get => default; } // 0x000000018B49898C-0x000000018B498A5C 
		protected override string info { get => default; } // 0x000000018B498A5C-0x000000018B498BAC 
	
		// Constructors
		public SetField() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		void IMigratable<SetField_0>.Migrate(SetField_0 model) {} // 0x000000018B498824-0x000000018B4988DC
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		protected override string OnInit() => default; // 0x000000018B49878C-0x000000018B498824
		protected override void OnExecute() {} // 0x000000018B4986D4-0x000000018B49878C
		private void SetTargetField(System.Reflection.FieldInfo newField) {} // 0x000000018B4988DC-0x000000018B49898C
	}

	public class SetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 48967
	{
		// Fields
		protected SerializedMethodInfo method; // 0x68
		protected BBObjectParameter parameter; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B479870-0x000000018B479880 
		public override System.Type agentType { get => default; } // 0x000000018B499B48-0x000000018B499C0C 
		protected override string info { get => default; } // 0x000000018B499C0C-0x000000018B499D70 
	
		// Constructors
		public SetProperty_Multiplatform() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B499A54-0x000000018B499A7C
		protected override string OnInit() => default; // 0x000000018B4999CC-0x000000018B499A54
		protected override void OnExecute() {} // 0x000000018B4998E0-0x000000018B4999CC
		private void SetMethod(MethodInfo method) {} // 0x000000018B499A7C-0x000000018B499B48
	}

	public class ExecuteFunction : ActionTask, IReflectedWrapper // TypeDefIndex: 48969
	{
		// Fields
		protected ReflectedWrapper functionWrapper; // 0x68
		private bool routineRunning; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000185FD25D0-0x0000000185FD25E0 
		public override System.Type agentType { get => default; } // 0x000000018B488C60-0x000000018B488CD4 
		protected override string info { get => default; } // 0x000000018B489CE8-0x000000018B489D3C 
	
		// Nested types
		private sealed class _InternalCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 48968
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ExecuteFunction __4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B489E00-0x000000018B48A258 
			object IEnumerator.Current { get => default; } // 0x000000018B489B40-0x000000018B489C9C 
	
			// Constructors
			public _InternalCoroutine_d__13() {} // Dummy constructor
			public _InternalCoroutine_d__13(int __1__state) {} // 0x000000018B489930-0x000000018B489940
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B47A01C-0x000000018B47A03C
			private bool MoveNext() => default; // 0x000000018B489D3C-0x000000018B489E00
			void IEnumerator.Reset() {} // 0x000000018B489C9C-0x000000018B489CE8
		}
	
		// Constructors
		public ExecuteFunction() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B489940-0x000000018B489B40
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000181ADBED0-0x0000000181ADBEE0
		protected override string OnInit() => default; // 0x0000000181378230-0x0000000181378240
		protected override void OnExecute() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnStop() {} // 0x000000018B49B74C-0x000000018B49B820
		private IEnumerator InternalCoroutine(IEnumerator routine) => default; // 0x0000000181377E40-0x0000000181377E50
		private void SetMethod(MethodInfo method) {} // 0x000000018B49B820-0x000000018B49B86C
	}

	public class GetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 48970
	{
		// Fields
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B47A01C-0x000000018B47A03C 
		public override System.Type agentType { get => default; } // 0x000000018B491314-0x000000018B4913D8 
		protected override string info { get => default; } // 0x000000018B4913D8-0x000000018B491548 
	
		// Constructors
		public GetProperty() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B489930-0x000000018B489940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B491274-0x000000018B4912C0
		protected override string OnInit() => default; // 0x000000018B491158-0x000000018B491274
		protected override void OnExecute() {} // 0x000000018B49111C-0x000000018B491158
		private void SetMethod(MethodInfo method) {} // 0x000000018B4912C0-0x000000018B491314
	}

	public class ImplementedAction : ActionTask, IReflectedWrapper // TypeDefIndex: 48971
	{
		// Fields
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		private NodeCanvas.Framework.Status actionStatus; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B47A01C-0x000000018B47A03C 
		public override System.Type agentType { get => default; } // 0x000000018B4922AC-0x000000018B492370 
		protected override string info { get => default; } // 0x000000018B492370-0x000000018B492530 
	
		// Constructors
		public ImplementedAction() {} // 0x0000000185FD2A90-0x0000000185FD2AA0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B489930-0x000000018B489940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B491274-0x000000018B4912C0
		protected override string OnInit() => default; // 0x000000018B492120-0x000000018B49223C
		protected override void OnUpdate() {} // 0x000000018B49223C-0x000000018B4922AC
		protected override void OnStop() {} // 0x0000000185FD2A80-0x0000000185FD2A90
		private void SetMethod(MethodInfo method) {} // 0x000000018B4912C0-0x000000018B491314
	}

	public class SetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 48972
	{
		// Fields
		protected ReflectedActionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B47A01C-0x000000018B47A03C 
		public override System.Type agentType { get => default; } // 0x000000018B499F68-0x000000018B49A02C 
		protected override string info { get => default; } // 0x000000018B49A02C-0x000000018B49A19C 
	
		// Constructors
		public SetProperty() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018B489930-0x000000018B489940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B499EC8-0x000000018B499F14
		protected override string OnInit() => default; // 0x000000018B499DAC-0x000000018B499EC8
		protected override void OnExecute() {} // 0x000000018B499D70-0x000000018B499DAC
		private void SetMethod(MethodInfo method) {} // 0x000000018B499F14-0x000000018B499F68
	}

	public class DebugBeep : ActionTask // TypeDefIndex: 48973
	{
		// Constructors
		public DebugBeep() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B487EBC-0x000000018B487EC8
	}

	public class DebugDrawLine : ActionTask // TypeDefIndex: 48974
	{
		// Fields
		public BBParameter<Vector3> from; // 0x68
		public BBParameter<Vector3> to; // 0x70
		public UnityEngine.Color color; // 0x78
		public float timeToShow; // 0x88
	
		// Constructors
		public DebugDrawLine() {} // 0x000000018B487FD0-0x000000018B488000
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B487EC8-0x000000018B487FD0
	}

	public class DebugLogText : ActionTask<Transform> // TypeDefIndex: 48977
	{
		// Fields
		public BBParameter<string> log; // 0x68
		public float labelYOffset; // 0x70
		public float secondsToRun; // 0x74
		public VerboseMode verboseMode; // 0x78
		public LogMode logMode; // 0x7C
		public CompactStatus finishStatus; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4885D0-0x000000018B4886A0 
	
		// Nested types
		public enum LogMode // TypeDefIndex: 48975
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}
	
		public enum VerboseMode // TypeDefIndex: 48976
		{
			LogAndDisplayLabel = 0,
			LogOnly = 1,
			DisplayLabelOnly = 2
		}
	
		// Constructors
		public DebugLogText() {} // 0x000000018B488554-0x000000018B4885D0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B488000-0x000000018B488148
		protected override void OnStop() {} // 0x000000018B488470-0x000000018B488520
		protected override void OnUpdate() {} // 0x000000018B488520-0x000000018B488554
		private void OnGUI() {} // 0x000000018B488148-0x000000018B488470
	}

	public class DebugLogVariable : ActionTask // TypeDefIndex: 48978
	{
		// Fields
		public BBParameter<object> log; // 0x68
		public BBParameter<string> prefix; // 0x70
		public float secondsToRun; // 0x78
		public CompactStatus finishStatus; // 0x7C
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4886D0-0x000000018B4887C4 
	
		// Constructors
		public DebugLogVariable() {} // 0x0000000185FD2A30-0x0000000185FD2A50
	
		// Methods
		protected override void OnExecute() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnUpdate() {} // 0x000000018B4886A0-0x000000018B4886D0
	}

	public class ForceFinishGraph : ActionTask // TypeDefIndex: 48979
	{
		// Fields
		public CompactStatus finishStatus; // 0x68
	
		// Constructors
		public ForceFinishGraph() {} // 0x0000000185FD2A60-0x0000000185FD2A70
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B48DE20-0x000000018B48DEC0
	}

	public class GraphOwnerControl : ActionTask<GraphOwner> // TypeDefIndex: 48982
	{
		// Fields
		public Control control; // 0x68
		public bool waitActionFinish; // 0x6C
	
		// Properties
		protected override string info { get => default; } // 0x000000018B491908-0x000000018B491910 
	
		// Nested types
		public enum Control // TypeDefIndex: 48980
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		private sealed class _YieldDo_d__6 : IEnumerator<object> // TypeDefIndex: 48981
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GraphOwnerControl __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4916C8-0x000000018B49176C 
			object IEnumerator.Current { get => default; } // 0x000000018B49196C-0x000000018B4919B0 
	
			// Constructors
			public _YieldDo_d__6() {} // Dummy constructor
			public _YieldDo_d__6(int __1__state) {} // 0x000000018B4919B0-0x000000018B491A38
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B49176C-0x000000018B4918A8
			private bool MoveNext() => default; // 0x000000018B491910-0x000000018B49196C
			void IEnumerator.Reset() {} // 0x000000018B4918A8-0x000000018B491908
		}
	
		// Constructors
		public GraphOwnerControl() {} // 0x000000018B49BD9C-0x000000018B49BDE8
	
		// Methods
		protected override void OnExecute() {} // 0x0000000181378230-0x0000000181378240
		private IEnumerator YieldDo() => default; // 0x0000000185492010-0x0000000185492020
		private void Do() {} // 0x000000018B49BD44-0x000000018B49BD9C
		protected override void OnStop() {} // 0x0000000181377E40-0x0000000181377E50
		private void _OnExecute_b__5_0(bool s) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class RunForever : ActionTask // TypeDefIndex: 48983
	{
		// Constructors
		public RunForever() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	}

	public class SendEvent : ActionTask<GraphOwner> // TypeDefIndex: 48984
	{
		// Fields
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> delay; // 0x70
		public bool sendGlobal; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B497FD4-0x000000018B498168 
	
		// Constructors
		public SendEvent() {} // 0x000000018B497F98-0x000000018B497FD4
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B497E74-0x000000018B497F98
	}

	public class SendEvent<T> : ActionTask<GraphOwner> // TypeDefIndex: 48985
	{
		// Fields
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
		public BBParameter<float> delay;
		public bool sendGlobal;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendEvent() {}
	
		// Methods
		protected override void OnUpdate() {}
	}

	public class SendEventToObjects : ActionTask // TypeDefIndex: 48986
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public BBParameter<string> eventName; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B497E30-0x000000018B497E74 
	
		// Constructors
		public SendEventToObjects() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B497C18-0x000000018B497E30
	}

	public class SendEventToObjects<T> : ActionTask // TypeDefIndex: 48987
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects;
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendEventToObjects() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	public class ShoutEvent : ActionTask<Transform> // TypeDefIndex: 48988
	{
		// Fields
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> shoutRange; // 0x70
		public BBParameter<float> completionTime; // 0x78
		private GraphOwner[] owners; // 0x80
		private bool[] receivedOwners; // 0x88
		private float traveledDistance; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49A8D4-0x000000018B49A92C 
	
		// Constructors
		public ShoutEvent() {} // 0x000000018B49A854-0x000000018B49A8D4
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49A54C-0x000000018B49A5F0
		protected override void OnUpdate() {} // 0x000000018B49A5F0-0x000000018B49A854
		public override void OnDrawGizmosSelected() {} // 0x000000018B49A3F4-0x000000018B49A54C
	}

	public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner> // TypeDefIndex: 48989
	{
		// Fields
		public BBParameter<BehaviourTree> behaviourTree; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49B110-0x000000018B49B150 
	
		// Constructors
		public SwitchBehaviourTree() {} // 0x000000018B49B0D4-0x000000018B49B110
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49B038-0x000000018B49B0D4
	}

	public class SwitchFSM : ActionTask<FSMOwner> // TypeDefIndex: 48990
	{
		// Fields
		public BBParameter<FSM> fsm; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49B228-0x000000018B49B268 
	
		// Constructors
		public SwitchFSM() {} // 0x000000018B49B1EC-0x000000018B49B228
	
		// Methods
		protected override void OnExecute() {} // 0x000000018B49B150-0x000000018B49B1EC
	}

	public class Wait : ActionTask // TypeDefIndex: 48991
	{
		// Fields
		public BBParameter<float> waitTime; // 0x68
		public CompactStatus finishStatus; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49C3AC-0x000000018B49C6D4 
	
		// Constructors
		public Wait() {} // 0x000000018B49C350-0x000000018B49C3AC
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018B49C2DC-0x000000018B49C350
	}

	public class CheckSpeed : ConditionTask<Rigidbody> // TypeDefIndex: 48992
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<float> value; // 0x70
		public float differenceThreshold; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B486EBC-0x000000018B486F38 
	
		// Constructors
		public CheckSpeed() {} // 0x000000018B486E70-0x000000018B486EBC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B486DB8-0x000000018B486E70
	}

	public class ExecuteStaticFunction : ActionTask, ISubParametersContainer // TypeDefIndex: 48993
	{
		// Fields
		protected ReflectedWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B47A01C-0x000000018B47A03C 
		protected override string info { get => default; } // 0x000000018B48AC78-0x000000018B48B010 
	
		// Constructors
		public ExecuteStaticFunction() {} // 0x0000000181ADBED0-0x0000000181ADBEE0
	
		// Methods
		BBParameter[] ISubParametersContainer.GetSubParameters() => default; // 0x000000018B48AA94-0x000000018B48AAB4
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B489C9C-0x000000018B489CE8
		protected override string OnInit() => default; // 0x000000018B48AB98-0x000000018B48AC78
		protected override void OnExecute() {} // 0x000000018B48AAB4-0x000000018B48AB98
		private void SetMethod(MethodInfo method) {} // 0x000000018B489CE8-0x000000018B489D3C
	}

	public class ExecuteStaticFunction_Multiplatform : ActionTask // TypeDefIndex: 48995
	{
		// Fields
		protected SerializedMethodInfo method; // 0x68
		protected List<BBObjectParameter> parameters; // 0x70
		protected BBObjectParameter returnValue; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B48A3F0-0x000000018B48A478 
		protected override string info { get => default; } // 0x000000018B48A258-0x000000018B48A3F0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48994
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<BBObjectParameter, object> __9__9_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B479870-0x000000018B479880
			public __c() {} // 0x000000018B48A780-0x000000018B48AA94
	
			// Methods
			internal object _OnExecute_b__9_0(BBObjectParameter p) => default; // 0x000000018B48A478-0x000000018B48A4A0
		}
	
		// Constructors
		public ExecuteStaticFunction_Multiplatform() {} // 0x000000018B49BA74-0x000000018B49BAB8
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B48A4A0-0x000000018B48A700
		protected override string OnInit() => default; // 0x000000018B48A700-0x000000018B48A780
		protected override void OnExecute() {} // 0x000000018B49BC18-0x000000018B49BC7C
		private void SetMethod(MethodInfo method) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace NodeCanvas.Tasks.Conditions
{
	public class InvokeSignal : ActionTask<Transform> // TypeDefIndex: 48770
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		public bool global; // 0x70
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x78
		private object[] args; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47F758-0x000000018B47F77C 
	
		// Constructors
		public InvokeSignal() {} // 0x000000018B47F6CC-0x000000018B47F758
	
		// Methods
		protected override string OnInit() => default; // 0x000000018B47F634-0x000000018B47F6CC
		protected override void OnExecute() {} // 0x000000018B47F480-0x000000018B47F634
	}

	public class MecanimCheckBool : ConditionTask<Animator> // TypeDefIndex: 48771
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<bool> value; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B481F78-0x000000018B48201C 
	
		// Constructors
		public MecanimCheckBool() {} // 0x000000018B481F3C-0x000000018B481F78
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B481E90-0x000000018B481F3C
	}

	public class MecanimCheckFloat : ConditionTask<Animator> // TypeDefIndex: 48772
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<float> value; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B482124-0x000000018B4821C0 
	
		// Constructors
		public MecanimCheckFloat() {} // 0x000000018B4820E8-0x000000018B482124
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B48201C-0x000000018B4820E8
	}

	public class MecanimCheckInt : ConditionTask<Animator> // TypeDefIndex: 48773
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<int> value; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4822B0-0x000000018B48234C 
	
		// Constructors
		public MecanimCheckInt() {} // 0x000000018B482274-0x000000018B4822B0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B4821C0-0x000000018B482274
	}

	public class MecanimIsInTransition : ConditionTask<Animator> // TypeDefIndex: 48774
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B482408-0x000000018B482434 
	
		// Constructors
		public MecanimIsInTransition() {} // 0x000000018B4823CC-0x000000018B482408
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B48234C-0x000000018B4823CC
	}

	public class CheckBoolean : ConditionTask // TypeDefIndex: 48775
	{
		// Fields
		public BBParameter<bool> valueA; // 0x68
		public BBParameter<bool> valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4749FC-0x000000018B474A84 
	
		// Constructors
		public CheckBoolean() {} // 0x000000018B4749AC-0x000000018B4749FC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B474940-0x000000018B4749AC
	}

	public class CheckBooleanTrigger : ConditionTask // TypeDefIndex: 48776
	{
		// Fields
		public BBParameter<bool> trigger; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B474900-0x000000018B474940 
	
		// Constructors
		public CheckBooleanTrigger() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47488C-0x000000018B474900
	}

	public class CheckEnum : ConditionTask // TypeDefIndex: 48777
	{
		// Fields
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B478218-0x000000018B4782A0 
	
		// Constructors
		public CheckEnum() {} // 0x000000018B478128-0x000000018B478218
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B4780B4-0x000000018B478128
	}

	public class CheckFloat : ConditionTask // TypeDefIndex: 48778
	{
		// Fields
		public BBParameter<float> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> valueB; // 0x78
		public float differenceThreshold; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B478C50-0x000000018B478CCC 
	
		// Constructors
		public CheckFloat() {} // 0x0000000185FD28B0-0x0000000185FD28D0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B478BC8-0x000000018B478C50
	}

	public class CheckInt : ConditionTask // TypeDefIndex: 48779
	{
		// Fields
		public BBParameter<int> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B478C50-0x000000018B478CCC 
	
		// Constructors
		public CheckInt() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47A03C-0x000000018B47A0B4
	}

	public class CheckNull : ConditionTask // TypeDefIndex: 48780
	{
		// Fields
		public BBParameter<object> variable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47BFA0-0x000000018B47BFFC 
	
		// Constructors
		public CheckNull() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47BF54-0x000000018B47BFA0
	}

	public class CheckString : ConditionTask // TypeDefIndex: 48781
	{
		// Fields
		public BBParameter<string> valueA; // 0x68
		public BBParameter<string> valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47CC00-0x000000018B47CC88 
	
		// Constructors
		public CheckString() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47CB8C-0x000000018B47CC00
	}

	public class CheckUnityObject : ConditionTask // TypeDefIndex: 48782
	{
		// Fields
		public BBParameter<UnityEngine.Object> valueA; // 0x68
		public BBParameter<UnityEngine.Object> valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47E058-0x000000018B47E0E0 
	
		// Constructors
		public CheckUnityObject() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47DFC8-0x000000018B47E058
	}

	public class CheckVariable<T> : ConditionTask // TypeDefIndex: 48783
	{
		// Fields
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public CheckVariable() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	public class CheckVectorDistance : ConditionTask // TypeDefIndex: 48784
	{
		// Fields
		public BBParameter<Vector3> vectorA; // 0x68
		public BBParameter<Vector3> vectorB; // 0x70
		public CompareMethod comparison; // 0x78
		public BBParameter<float> distance; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47E1D0-0x000000018B47E2D0 
	
		// Constructors
		public CheckVectorDistance() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47E0E0-0x000000018B47E1D0
	}

	public class TryGetValue<T> : ConditionTask // TypeDefIndex: 48785
	{
		// Fields
		public BBParameter<Dictionary<string, T>> targetDictionary;
		public BBParameter<string> key;
		public BBParameter<T> saveValueAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public TryGetValue() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	public class ListContainsElement<T> : ConditionTask // TypeDefIndex: 48786
	{
		// Fields
		public BBParameter<List<T>> targetList;
		public BBParameter<T> checkElement;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public ListContainsElement() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	public class ListIsEmpty : ConditionTask // TypeDefIndex: 48787
	{
		// Fields
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B480184-0x000000018B4801C4 
	
		// Constructors
		public ListIsEmpty() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B480128-0x000000018B480184
	}

	public class BBVariableChanged : ConditionTask // TypeDefIndex: 48788
	{
		// Fields
		public BBObjectParameter targetVariable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47075C-0x000000018B4707B8 
	
		// Constructors
		public BBVariableChanged() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override string OnInit() => default; // 0x000000018B4706FC-0x000000018B47074C
		protected override void OnEnable() {} // 0x000000018B470664-0x000000018B4706FC
		protected override void OnDisable() {} // 0x000000018B4705CC-0x000000018B470664
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void OnValueChanged(object varValue) {} // 0x000000018B47074C-0x000000018B47075C
	}

	public class StringContains : ConditionTask // TypeDefIndex: 48789
	{
		// Fields
		public BBParameter<string> targetString; // 0x68
		public BBParameter<string> checkString; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4856F8-0x000000018B48573C 
	
		// Constructors
		public StringContains() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B48567C-0x000000018B4856F8
	}

	public class CanSeeTarget : ConditionTask<Transform> // TypeDefIndex: 48790
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<LayerMask> layerMask; // 0x78
		public BBParameter<float> awarnessDistance; // 0x80
		public BBParameter<float> viewAngle; // 0x88
		public Vector3 offset; // 0x90
		private RaycastHit hit; // 0xA0
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47482C-0x000000018B47488C 
	
		// Constructors
		public CanSeeTarget() {} // 0x000000018B47475C-0x000000018B47482C
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B473C1C-0x000000018B47412C
		public override void OnDrawGizmosSelected() {} // 0x000000018B47412C-0x000000018B47475C
	}

	public class CanSeeTarget2D : ConditionTask<Transform> // TypeDefIndex: 48791
	{
		// Fields
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<LayerMask> layerMask; // 0x78
		public BBParameter<float> awarnessDistance; // 0x80
		public BBParameter<float> viewAngle; // 0x88
		public Vector2 offset; // 0x90
		private RaycastHit2D hit; // 0x98
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4713A8-0x000000018B471408 
	
		// Constructors
		public CanSeeTarget2D() {} // 0x000000018B4712D8-0x000000018B4713A8
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B4707B8-0x000000018B470C44
		public override void OnDrawGizmosSelected() {} // 0x000000018B470C44-0x000000018B4712D8
	}

	public class CanSeeTargetAny : ConditionTask<Transform> // TypeDefIndex: 48792
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<LayerMask> layerMask; // 0x78
		public BBParameter<float> awarnessDistance; // 0x80
		public BBParameter<float> viewAngle; // 0x88
		public Vector3 offset; // 0x90
		public BBParameter<List<GameObject>> allResults; // 0xA0
		public BBParameter<GameObject> closerResult; // 0xA8
		private RaycastHit hit; // 0xB0
	
		// Properties
		protected override string info { get => default; } // 0x000000018B473BBC-0x000000018B473C1C 
	
		// Constructors
		public CanSeeTargetAny() {} // 0x000000018B473AEC-0x000000018B473BBC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B4727A0-0x000000018B4733FC
		public override void OnDrawGizmosSelected() {} // 0x000000018B4733FC-0x000000018B473A2C
		private float _OnCheck_b__11_0(GameObject x) => default; // 0x000000018B473A2C-0x000000018B473AEC
	}

	public class CanSeeTargetAny2D : ConditionTask<Transform> // TypeDefIndex: 48793
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<LayerMask> layerMask; // 0x78
		public BBParameter<float> awarnessDistance; // 0x80
		public BBParameter<float> viewAngle; // 0x88
		public Vector2 offset; // 0x90
		public BBParameter<List<GameObject>> allResults; // 0x98
		public BBParameter<GameObject> closerResult; // 0xA0
	
		// Properties
		protected override string info { get => default; } // 0x000000018B472740-0x000000018B4727A0 
	
		// Constructors
		public CanSeeTargetAny2D() {} // 0x000000018B472670-0x000000018B472740
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B471408-0x000000018B471F3C
		public override void OnDrawGizmosSelected() {} // 0x000000018B471F3C-0x000000018B4725B0
		private float _OnCheck_b__10_0(GameObject x) => default; // 0x000000018B4725B0-0x000000018B472670
	}

	public class CheckDistanceToGameObject : ConditionTask<Transform> // TypeDefIndex: 48794
	{
		// Fields
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B477FA8-0x000000018B4780B4 
	
		// Constructors
		public CheckDistanceToGameObject() {} // 0x000000018B477F38-0x000000018B477FA8
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B477D20-0x000000018B477E4C
		public override void OnDrawGizmosSelected() {} // 0x000000018B477E4C-0x000000018B477F38
	}

	public class CheckDistanceToGameObject2D : ConditionTask<Transform> // TypeDefIndex: 48795
	{
		// Fields
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B476B08-0x000000018B476C14 
	
		// Constructors
		public CheckDistanceToGameObject2D() {} // 0x000000018B476A98-0x000000018B476B08
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B476844-0x000000018B476980
		public override void OnDrawGizmosSelected() {} // 0x000000018B476980-0x000000018B476A98
	}

	public class CheckDistanceToGameObjectAny : ConditionTask<Transform> // TypeDefIndex: 48796
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		public float floatingPoint; // 0x80
		public BBParameter<List<GameObject>> allResults; // 0x88
		public BBParameter<GameObject> closerResult; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B477C14-0x000000018B477D20 
	
		// Constructors
		public CheckDistanceToGameObjectAny() {} // 0x000000018B477BA4-0x000000018B477C14
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B477454-0x000000018B4779F8
		public override void OnDrawGizmosSelected() {} // 0x000000018B4779F8-0x000000018B477AE4
		private float _OnCheck_b__8_0(GameObject x) => default; // 0x000000018B477AE4-0x000000018B477BA4
	}

	public class CheckDistanceToGameObjectAny2D : ConditionTask<Transform> // TypeDefIndex: 48797
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		public float floatingPoint; // 0x80
		public BBParameter<List<GameObject>> allResults; // 0x88
		public BBParameter<GameObject> closerResult; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B477348-0x000000018B477454 
	
		// Constructors
		public CheckDistanceToGameObjectAny2D() {} // 0x000000018B4772D8-0x000000018B477348
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B476C14-0x000000018B4770E4
		public override void OnDrawGizmosSelected() {} // 0x000000018B4770E4-0x000000018B4771FC
		private float _OnCheck_b__8_0(GameObject x) => default; // 0x000000018B4771FC-0x000000018B4772D8
	}

	public class CheckLOS : ConditionTask<Transform> // TypeDefIndex: 48798
	{
		// Fields
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		public Vector3 offset; // 0x78
		public BBParameter<float> saveDistanceAs; // 0x88
		private RaycastHit hit; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47AD00-0x000000018B47AD58 
	
		// Constructors
		public CheckLOS() {} // 0x000000018B47ACA8-0x000000018B47AD00
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47A828-0x000000018B47AAD8
		public override void OnDrawGizmosSelected() {} // 0x000000018B47AAD8-0x000000018B47ACA8
	}

	public class CheckLOS2D : ConditionTask<Transform> // TypeDefIndex: 48800
	{
		// Fields
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		public BBParameter<float> saveDistanceAs; // 0x78
		protected Collider2D agentCollider; // 0x80
		private RaycastHit2D[] hits; // 0x88
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47A778-0x000000018B47A7D0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 48799
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RaycastHit2D, Collider2D> __9__7_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B47A7D0-0x000000018B47A828
			public __c() {} // 0x000000018B47A198-0x000000018B47A5CC
	
			// Methods
			internal Collider2D _OnCheck_b__7_0(RaycastHit2D h) => default; // 0x000000018B47A5CC-0x000000018B47A778
		}
	
		// Constructors
		public CheckLOS2D() {} // 0x000000018B485E80-0x000000018B485E94
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B4865CC-0x000000018B486630
		public override void OnDrawGizmosSelected() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HasComponent<T> : ConditionTask<Transform> // TypeDefIndex: 48801
		where T : Component
	{
		// Constructors
		public HasComponent() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	public class IsActive : ConditionTask<Transform> // TypeDefIndex: 48802
	{
		// Properties
		protected override string info { get => default; } // 0x000000018B47F818-0x000000018B47F860 
	
		// Constructors
		public IsActive() {} // 0x000000018B47F7DC-0x000000018B47F818
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47F77C-0x000000018B47F7DC
	}

	public class IsInFront : ConditionTask<Transform> // TypeDefIndex: 48803
	{
		// Fields
		public BBParameter<GameObject> checkTarget; // 0x68
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B480008-0x000000018B480064 
	
		// Constructors
		public IsInFront() {} // 0x000000018B47FFAC-0x000000018B480008
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47FC74-0x000000018B47FDE4
		public override void OnDrawGizmosSelected() {} // 0x000000018B47FDE4-0x000000018B47FFAC
	}

	public class IsInFront2D : ConditionTask<Transform> // TypeDefIndex: 48804
	{
		// Fields
		public BBParameter<GameObject> checkTarget; // 0x68
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47FC18-0x000000018B47FC74 
	
		// Constructors
		public IsInFront2D() {} // 0x000000018B47FBBC-0x000000018B47FC18
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47F860-0x000000018B47F9D8
		public override void OnDrawGizmosSelected() {} // 0x000000018B47F9D8-0x000000018B47FBBC
	}

	public class IsWithinLayerMask : ConditionTask<Transform> // TypeDefIndex: 48805
	{
		// Fields
		public BBParameter<LayerMask> targetLayers; // 0x68
	
		// Constructors
		public IsWithinLayerMask() {} // 0x000000018B4800EC-0x000000018B480128
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B480064-0x000000018B4800EC
	}

	public class CheckButtonInput : ConditionTask // TypeDefIndex: 48806
	{
		// Fields
		public PressTypes pressType; // 0x68
		public BBParameter<string> buttonName; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B474B94-0x000000018B474C2C 
	
		// Constructors
		public CheckButtonInput() {} // 0x000000018B474B38-0x000000018B474B94
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B474A84-0x000000018B474B38
	}

	public class CheckKeyboardInput : ConditionTask // TypeDefIndex: 48807
	{
		// Fields
		public PressTypes pressType; // 0x68
		public KeyCode key; // 0x6C
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47A0E8-0x000000018B47A198 
	
		// Constructors
		public CheckKeyboardInput() {} // 0x0000000185FD28D0-0x0000000185FD28E0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47A0B4-0x000000018B47A0E8
	}

	public class CheckMousePick : ConditionTask // TypeDefIndex: 48808
	{
		// Fields
		public ParadoxNotion.ButtonKeys buttonKey; // 0x68
		public int layer; // 0x6C
		public BBParameter<GameObject> saveGoAs; // 0x70
		public BBParameter<float> saveDistanceAs; // 0x78
		public BBParameter<Vector3> savePosAs; // 0x80
		private RaycastHit hit; // 0x88
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47BB10-0x000000018B47BC28 
	
		// Constructors
		public CheckMousePick() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47B958-0x000000018B47BB10
	}

	public class CheckMousePick2D : ConditionTask // TypeDefIndex: 48809
	{
		// Fields
		public ParadoxNotion.ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		public BBParameter<GameObject> saveGoAs; // 0x70
		public BBParameter<float> saveDistanceAs; // 0x78
		public BBParameter<Vector3> savePosAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit2D hit; // 0x8C
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47B810-0x000000018B47B958 
	
		// Constructors
		public CheckMousePick2D() {} // 0x0000000185FD28E0-0x0000000185FD2900
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47B5A8-0x000000018B47B810
	}

	internal class CheckCSharpEvent_0 // TypeDefIndex: 48810
	{
		// Fields
		public System.Type targetType; // 0x10
		public string eventName; // 0x18
	
		// Constructors
		public CheckCSharpEvent_0() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CheckCSharpEvent_0<T> // TypeDefIndex: 48811
	{
		// Fields
		public System.Type targetType;
		public string eventName;
	
		// Constructors
		public CheckCSharpEvent_0() {}
	}

	internal class CheckCSharpEventValue_0<T> // TypeDefIndex: 48812
	{
		// Fields
		public System.Type targetType;
		public string eventName;
	
		// Constructors
		public CheckCSharpEventValue_0() {}
	}

	internal class CheckStaticCSharpEvent // TypeDefIndex: 48813
	{
		// Fields
		public System.Type targetType; // 0x10
		public string eventName; // 0x18
	
		// Constructors
		public CheckStaticCSharpEvent() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CheckStaticCSharpEvent<T> // TypeDefIndex: 48814
	{
		// Fields
		public System.Type targetType;
		public string eventName;
	
		// Constructors
		public CheckStaticCSharpEvent() {}
	}

	public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent> // TypeDefIndex: 48815
	{
		// Fields
		private SerializedEventInfo eventInfo; // 0x68
		private Delegate handler; // 0x70
	
		// Properties
		private EventInfo targetEvent { get => default; } // 0x0000000189E6F710-0x0000000189E6F720 
		public override System.Type agentType { get => default; } // 0x000000018B4750A4-0x000000018B475178 
		protected override string info { get => default; } // 0x000000018B475178-0x000000018B475250 
	
		// Constructors
		public CheckCSharpEvent() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		void IMigratable<CheckCSharpEvent_0>.Migrate(CheckCSharpEvent_0 model) {} // 0x000000018B474E94-0x000000018B474F58
		void IMigratable<CheckStaticCSharpEvent>.Migrate(CheckStaticCSharpEvent model) {} // 0x000000018B474F58-0x000000018B47501C
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		protected override string OnInit() => default; // 0x000000018B474D74-0x000000018B474E94
		protected override void OnEnable() {} // 0x000000018B474CD0-0x000000018B474D74
		protected override void OnDisable() {} // 0x000000018B474C2C-0x000000018B474CD0
		public void Raised() {} // 0x000000018B47074C-0x000000018B47075C
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void SetTargetEvent(EventInfo info) {} // 0x000000018B47501C-0x000000018B4750A4
	}

	public class CheckCSharpEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>> // TypeDefIndex: 48816
	{
		// Fields
		private SerializedEventInfo eventInfo;
		private BBParameter<T> saveAs;
		private Delegate handler;
	
		// Properties
		private EventInfo targetEvent { get => default; }
		public override System.Type agentType { get => default; }
		protected override string info { get => default; }
	
		// Constructors
		public CheckCSharpEvent() {}
	
		// Methods
		void IMigratable<CheckCSharpEvent_0<T>>.Migrate(CheckCSharpEvent_0<T> model) {}
		void IMigratable<CheckStaticCSharpEvent<T>>.Migrate(CheckStaticCSharpEvent<T> model) {}
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default;
		protected override string OnInit() => default;
		protected override void OnEnable() {}
		protected override void OnDisable() {}
		public void Raised(T eventValue) {}
		protected override bool OnCheck() => default;
		private void SetTargetEvent(EventInfo info) {}
	}

	public class CheckCSharpEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>> // TypeDefIndex: 48817
	{
		// Fields
		private SerializedEventInfo eventInfo;
		private BBParameter<T> checkValue;
		private Delegate handler;
	
		// Properties
		private EventInfo targetEvent { get => default; }
		public override System.Type agentType { get => default; }
		protected override string info { get => default; }
	
		// Constructors
		public CheckCSharpEventValue() {}
	
		// Methods
		void IMigratable<CheckCSharpEventValue_0<T>>.Migrate(CheckCSharpEventValue_0<T> model) {}
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default;
		protected override string OnInit() => default;
		protected override void OnEnable() {}
		protected override void OnDisable() {}
		public void Raised(T eventValue) {}
		protected override bool OnCheck() => default;
		private void SetTargetEvent(EventInfo info) {}
	}

	internal class CheckField_0 // TypeDefIndex: 48818
	{
		// Fields
		public BBParameter checkValue; // 0x10
		public System.Type targetType; // 0x18
		public string fieldName; // 0x20
	
		// Constructors
		public CheckField_0() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CheckField : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0> // TypeDefIndex: 48819
	{
		// Fields
		protected BBObjectParameter checkValue; // 0x68
		protected CompareMethod comparison; // 0x70
		protected SerializedFieldInfo field; // 0x78
	
		// Properties
		private System.Reflection.FieldInfo targetField { get => default; } // 0x000000018B478BB8-0x000000018B478BC8 
		public override System.Type agentType { get => default; } // 0x000000018B4788EC-0x000000018B4789BC 
		protected override string info { get => default; } // 0x000000018B4789BC-0x000000018B478BB8 
	
		// Constructors
		public CheckField() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		void IMigratable<CheckField_0>.Migrate(CheckField_0 model) {} // 0x000000018B4785A8-0x000000018B478838
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183060C50-0x0000000183060C60
		protected override string OnInit() => default; // 0x000000018B478510-0x000000018B4785A8
		protected override bool OnCheck() => default; // 0x000000018B4782A0-0x000000018B478510
		private void SetTargetField(System.Reflection.FieldInfo newField) {} // 0x000000018B478838-0x000000018B4788EC
	}

	public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 48820
	{
		// Fields
		protected SerializedMethodInfo method; // 0x68
		protected List<BBObjectParameter> parameters; // 0x70
		protected CompareMethod comparison; // 0x78
		protected BBObjectParameter checkValue; // 0x80
		private object[] args; // 0x88
		private bool[] parameterIsByRef; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B479870-0x000000018B479880 
		public override System.Type agentType { get => default; } // 0x000000018B4794E0-0x000000018B4795A4 
		protected override string info { get => default; } // 0x000000018B4795A4-0x000000018B479870 
	
		// Constructors
		public CheckFunction_Multiplatform() {} // 0x000000018B479464-0x000000018B4794E0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B4791FC-0x000000018B479224
		protected override string OnInit() => default; // 0x000000018B47907C-0x000000018B4791FC
		protected override bool OnCheck() => default; // 0x000000018B478CCC-0x000000018B47907C
		private void SetMethod(MethodInfo method) {} // 0x000000018B479224-0x000000018B479464
	}

	public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 48821
	{
		// Fields
		protected SerializedMethodInfo method; // 0x68
		protected BBObjectParameter checkValue; // 0x70
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B479870-0x000000018B479880 
		public override System.Type agentType { get => default; } // 0x000000018B47C3C0-0x000000018B47C484 
		protected override string info { get => default; } // 0x000000018B47C484-0x000000018B47C60C 
	
		// Constructors
		public CheckProperty_Multiplatform() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B47C2E4-0x000000018B47C30C
		protected override string OnInit() => default; // 0x000000018B47C27C-0x000000018B47C2E4
		protected override bool OnCheck() => default; // 0x000000018B47BFFC-0x000000018B47C27C
		private void SetMethod(MethodInfo method) {} // 0x000000018B47C30C-0x000000018B47C3C0
	}

	internal class CheckUnityEvent_0 // TypeDefIndex: 48822
	{
		// Fields
		public System.Type targetType; // 0x10
		public string eventName; // 0x18
	
		// Constructors
		public CheckUnityEvent_0() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CheckUnityEvent_0<T> // TypeDefIndex: 48823
	{
		// Fields
		public System.Type targetType;
		public string eventName;
	
		// Constructors
		public CheckUnityEvent_0() {}
	}

	internal class CheckUnityEventValue_0<T> // TypeDefIndex: 48824
	{
		// Fields
		public System.Type targetType;
		public string eventName;
	
		// Constructors
		public CheckUnityEventValue_0() {}
	}

	public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0> // TypeDefIndex: 48825
	{
		// Fields
		private SerializedUnityEventInfo _eventInfo; // 0x68
		private UnityEvent unityEvent; // 0x70
	
		// Properties
		private MemberInfo targetMember { get => default; } // 0x0000000189F3BE24-0x0000000189F3BE38 
		private bool isStatic { get => default; } // 0x0000000189F3BDEC-0x0000000189F3BE0C 
		private System.Type eventType { get => default; } // 0x0000000189F3A338-0x0000000189F3A358 
		private System.Reflection.FieldInfo targetEventField { get => default; } // 0x0000000189F3BE0C-0x0000000189F3BE18 
		private PropertyInfo targetEventProp { get => default; } // 0x0000000189F3BE18-0x0000000189F3BE24 
		public override System.Type agentType { get => default; } // 0x000000018B47DE38-0x000000018B47DEF0 
		protected override string info { get => default; } // 0x000000018B47DEF0-0x000000018B47DFC8 
	
		// Constructors
		public CheckUnityEvent() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		void IMigratable<CheckUnityEvent_0>.Migrate(CheckUnityEvent_0 model) {} // 0x000000018B47DCF8-0x000000018B47DDB0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001813AC280-0x00000001813AC290
		protected override string OnInit() => default; // 0x000000018B47DB7C-0x000000018B47DCF8
		protected override void OnEnable() {} // 0x000000018B47DAE8-0x000000018B47DB7C
		protected override void OnDisable() {} // 0x000000018B47DA54-0x000000018B47DAE8
		public void Raised() {} // 0x000000018B47074C-0x000000018B47075C
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void SetTargetEvent(MemberInfo newMember) {} // 0x000000018B47DDB0-0x000000018B47DE38
	}

	public class CheckUnityEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>> // TypeDefIndex: 48826
	{
		// Fields
		private SerializedUnityEventInfo _eventInfo;
		private BBParameter<T> saveAs;
		private UnityEvent<T> unityEvent;
	
		// Properties
		private MemberInfo targetMember { get => default; }
		private bool isStatic { get => default; }
		private System.Type eventType { get => default; }
		private System.Reflection.FieldInfo targetEventField { get => default; }
		private PropertyInfo targetEventProp { get => default; }
		public override System.Type agentType { get => default; }
		protected override string info { get => default; }
	
		// Constructors
		public CheckUnityEvent() {}
	
		// Methods
		void IMigratable<CheckUnityEvent_0<T>>.Migrate(CheckUnityEvent_0<T> model) {}
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default;
		protected override string OnInit() => default;
		protected override void OnEnable() {}
		protected override void OnDisable() {}
		public void Raised(T eventValue) {}
		protected override bool OnCheck() => default;
		private void SetTargetEvent(MemberInfo newMember) {}
	}

	public class CheckUnityEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T>> // TypeDefIndex: 48827
	{
		// Fields
		private SerializedUnityEventInfo _eventInfo;
		private BBParameter<T> checkValue;
		private UnityEvent<T> unityEvent;
	
		// Properties
		private MemberInfo targetMember { get => default; }
		private bool isStatic { get => default; }
		private System.Type eventType { get => default; }
		private System.Reflection.FieldInfo targetEventField { get => default; }
		private PropertyInfo targetEventProp { get => default; }
		public override System.Type agentType { get => default; }
		protected override string info { get => default; }
	
		// Constructors
		public CheckUnityEventValue() {}
	
		// Methods
		void IMigratable<CheckUnityEventValue_0<T>>.Migrate(CheckUnityEventValue_0<T> model) {}
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default;
		protected override string OnInit() => default;
		protected override void OnEnable() {}
		protected override void OnDisable() {}
		public void Raised(T eventValue) {}
		protected override bool OnCheck() => default;
		private void SetTargetEvent(MemberInfo newMember) {}
	}

	public class CheckFunction : ConditionTask // TypeDefIndex: 48828
	{
		// Fields
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		protected BBParameter checkValue; // 0x70
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B47A01C-0x000000018B47A03C 
		public override System.Type agentType { get => default; } // 0x000000018B479C98-0x000000018B479D5C 
		protected override string info { get => default; } // 0x000000018B479D5C-0x000000018B47A01C 
	
		// Constructors
		public CheckFunction() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B479BB4-0x000000018B479C00
		protected override string OnInit() => default; // 0x000000018B479A98-0x000000018B479BB4
		protected override bool OnCheck() => default; // 0x000000018B479880-0x000000018B479A98
		private void SetMethod(MethodInfo method) {} // 0x000000018B479C00-0x000000018B479C98
	}

	public class CheckProperty : ConditionTask // TypeDefIndex: 48829
	{
		// Fields
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		protected BBParameter checkValue; // 0x70
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018B47A01C-0x000000018B47A03C 
		public override System.Type agentType { get => default; } // 0x000000018B47C940-0x000000018B47CA04 
		protected override string info { get => default; } // 0x000000018B47CA04-0x000000018B47CB8C 
	
		// Constructors
		public CheckProperty() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018B479BB4-0x000000018B479C00
		protected override string OnInit() => default; // 0x000000018B47C824-0x000000018B47C940
		protected override bool OnCheck() => default; // 0x000000018B47C60C-0x000000018B47C824
		private void SetMethod(MethodInfo method) {} // 0x000000018B479C00-0x000000018B479C98
	}

	public class CheckCollision_Rigidbody : ConditionTask<Rigidbody> // TypeDefIndex: 48830
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		public BBParameter<Vector3> saveContactPoint; // 0x80
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B476684-0x000000018B47673C 
	
		// Constructors
		public CheckCollision_Rigidbody() {} // 0x000000018B476634-0x000000018B476684
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B476540-0x000000018B476634
		protected override void OnDisable() {} // 0x000000018B47644C-0x000000018B476540
		protected override bool OnCheck() => default; // 0x000000018B475250-0x000000018B475264
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data) {} // 0x000000018B4761E0-0x000000018B476380
		public void OnCollisionExit(EventData<UnityEngine.Collision> data) {} // 0x000000018B476380-0x000000018B47644C
	}

	public class CheckCollision : ConditionTask<Collider> // TypeDefIndex: 48831
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		public BBParameter<Vector3> saveContactPoint; // 0x80
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47678C-0x000000018B476844 
	
		// Constructors
		public CheckCollision() {} // 0x000000018B47673C-0x000000018B47678C
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B4760EC-0x000000018B4761E0
		protected override void OnDisable() {} // 0x000000018B475FF8-0x000000018B4760EC
		protected override bool OnCheck() => default; // 0x000000018B475250-0x000000018B475264
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data) {} // 0x000000018B475D8C-0x000000018B475F2C
		public void OnCollisionExit(EventData<UnityEngine.Collision> data) {} // 0x000000018B475F2C-0x000000018B475FF8
	}

	public class CheckCollision2D_Rigidbody : ConditionTask<Rigidbody2D> // TypeDefIndex: 48832
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		public BBParameter<Vector3> saveContactPoint; // 0x80
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B475BCC-0x000000018B475C84 
	
		// Constructors
		public CheckCollision2D_Rigidbody() {} // 0x000000018B475B7C-0x000000018B475BCC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B475250-0x000000018B475264
		protected override void OnEnable() {} // 0x000000018B475A88-0x000000018B475B7C
		protected override void OnDisable() {} // 0x000000018B475994-0x000000018B475A88
		private void OnCollisionEnter2D(EventData<Collision2D> data) {} // 0x000000018B4756F0-0x000000018B4758C8
		private void OnCollisionExit2D(EventData<Collision2D> data) {} // 0x000000018B4758C8-0x000000018B475994
	}

	public class CheckCollision2D : ConditionTask<Collider2D> // TypeDefIndex: 48833
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		public BBParameter<Vector3> saveContactPoint; // 0x80
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018B475CD4-0x000000018B475D8C 
	
		// Constructors
		public CheckCollision2D() {} // 0x000000018B475C84-0x000000018B475CD4
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B475250-0x000000018B475264
		protected override void OnEnable() {} // 0x000000018B4755FC-0x000000018B4756F0
		protected override void OnDisable() {} // 0x000000018B475508-0x000000018B4755FC
		private void OnCollisionEnter2D(EventData<Collision2D> data) {} // 0x000000018B475264-0x000000018B47543C
		private void OnCollisionExit2D(EventData<Collision2D> data) {} // 0x000000018B47543C-0x000000018B475508
	}

	public class CheckMouse : ConditionTask<Collider> // TypeDefIndex: 48834
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47BF04-0x000000018B47BF54 
	
		// Constructors
		public CheckMouse() {} // 0x000000018B47BEC8-0x000000018B47BF04
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected override void OnEnable() {} // 0x000000018B47BD78-0x000000018B47BEC8
		protected override void OnDisable() {} // 0x000000018B47BC28-0x000000018B47BD78
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x000000018B47AFF8-0x000000018B47B00C
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018B47B00C-0x000000018B47B020
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x000000018B47B020-0x000000018B47B034
	}

	public class CheckMouse2D : ConditionTask<Collider2D> // TypeDefIndex: 48835
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47B070-0x000000018B47B0C0 
	
		// Constructors
		public CheckMouse2D() {} // 0x000000018B47B034-0x000000018B47B070
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B47AEA8-0x000000018B47AFF8
		protected override void OnDisable() {} // 0x000000018B47AD58-0x000000018B47AEA8
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x000000018B47AFF8-0x000000018B47B00C
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018B47B00C-0x000000018B47B020
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x000000018B47B020-0x000000018B47B034
	}

	public class CheckMouseClick : ConditionTask<Collider> // TypeDefIndex: 48836
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47B558-0x000000018B47B5A8 
	
		// Constructors
		public CheckMouseClick() {} // 0x000000018B47B51C-0x000000018B47B558
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected override void OnEnable() {} // 0x000000018B47B428-0x000000018B47B51C
		protected override void OnDisable() {} // 0x000000018B47B334-0x000000018B47B428
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x000000018B47AFF8-0x000000018B47B00C
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018B47B00C-0x000000018B47B020
	}

	public class CheckMouseClick2D : ConditionTask<Collider2D> // TypeDefIndex: 48837
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47B2E4-0x000000018B47B334 
	
		// Constructors
		public CheckMouseClick2D() {} // 0x000000018B47B2A8-0x000000018B47B2E4
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected override void OnEnable() {} // 0x000000018B47B1B4-0x000000018B47B2A8
		protected override void OnDisable() {} // 0x000000018B47B0C0-0x000000018B47B1B4
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x000000018B47AFF8-0x000000018B47B00C
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018B47B00C-0x000000018B47B020
	}

	public class CheckTrigger_Transform : ConditionTask<Transform> // TypeDefIndex: 48838
	{
		// Fields
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47D894-0x000000018B47D94C 
	
		// Constructors
		public CheckTrigger_Transform() {} // 0x000000018B47D844-0x000000018B47D894
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47D128-0x000000018B47D13C
		protected override void OnEnable() {} // 0x000000018B47D5B4-0x000000018B47D6A8
		protected override void OnDisable() {} // 0x000000018B47D4C0-0x000000018B47D5B4
		public void OnTriggerEnter(EventData<Collider> data) {} // 0x000000018B47D6A8-0x000000018B47D778
		public void OnTriggerExit(EventData<Collider> data) {} // 0x000000018B47D778-0x000000018B47D844
	}

	public class CheckTrigger : ConditionTask<Collider> // TypeDefIndex: 48839
	{
		// Fields
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47D99C-0x000000018B47DA54 
	
		// Constructors
		public CheckTrigger() {} // 0x000000018B47D94C-0x000000018B47D99C
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47D128-0x000000018B47D13C
		protected override void OnEnable() {} // 0x000000018B47D230-0x000000018B47D324
		protected override void OnDisable() {} // 0x000000018B47D13C-0x000000018B47D230
		public void OnTriggerEnter(EventData<Collider> data) {} // 0x000000018B47D324-0x000000018B47D3F4
		public void OnTriggerExit(EventData<Collider> data) {} // 0x000000018B47D3F4-0x000000018B47D4C0
	}

	public class CheckTrigger2D_Transform : ConditionTask<Transform> // TypeDefIndex: 48840
	{
		// Fields
		public TriggerTypes CheckType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47D070-0x000000018B47D128 
	
		// Constructors
		public CheckTrigger2D_Transform() {} // 0x000000018B47D020-0x000000018B47D070
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47CC88-0x000000018B47CC9C
		protected override void OnEnable() {} // 0x000000018B47CD90-0x000000018B47CE84
		protected override void OnDisable() {} // 0x000000018B47CC9C-0x000000018B47CD90
		public void OnTriggerEnter2D(EventData<Collider2D> data) {} // 0x000000018B47CE84-0x000000018B47CF54
		public void OnTriggerExit2D(EventData<Collider2D> data) {} // 0x000000018B47CF54-0x000000018B47D020
	}

	public class CheckTrigger2D : ConditionTask<Collider2D> // TypeDefIndex: 48841
	{
		// Fields
		public TriggerTypes CheckType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		public string objectTag; // 0x70
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018B487400-0x000000018B4874B8 
	
		// Constructors
		public CheckTrigger2D() {} // 0x000000018B4873B0-0x000000018B487400
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B47CC88-0x000000018B47CC9C
		protected override void OnEnable() {} // 0x000000018B487120-0x000000018B487214
		protected override void OnDisable() {} // 0x000000018B48702C-0x000000018B487120
		public void OnTriggerEnter2D(EventData<Collider2D> data) {} // 0x000000018B487214-0x000000018B4872E4
		public void OnTriggerExit2D(EventData<Collider2D> data) {} // 0x000000018B4872E4-0x000000018B4873B0
	}

	public class ButtonClicked : ConditionTask // TypeDefIndex: 48842
	{
		// Fields
		public BBParameter<UnityEngine.UI.Button> button; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B4866EC-0x000000018B486744 
	
		// Constructors
		public ButtonClicked() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override string OnInit() => default; // 0x000000018B486630-0x000000018B4866EC
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void OnClick() {} // 0x000000018B47074C-0x000000018B47075C
	}

	public class InterceptEvent : ConditionTask<Transform> // TypeDefIndex: 48843
	{
		// Fields
		public EventTriggerType eventType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B493AC0-0x000000018B493B48 
	
		// Constructors
		public InterceptEvent() {} // 0x000000018B493A84-0x000000018B493AC0
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B4934B4-0x000000018B493A84
		protected override void OnDisable() {} // 0x000000018B492EE4-0x000000018B4934B4
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void OnPointerEnter(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnPointerExit(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnPointerDown(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnPointerUp(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnPointerClick(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnDrag(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnDrop(EventData<PointerEventData> eventData) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnScroll(EventData<PointerEventData> data) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnUpdateSelected(EventData<BaseEventData> eventData) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnSelect(EventData<BaseEventData> eventData) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnDeselect(EventData<BaseEventData> eventData) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnMove(EventData<AxisEventData> eventData) {} // 0x000000018B47074C-0x000000018B47075C
		private void OnSubmit(EventData<BaseEventData> eventData) {} // 0x000000018B47074C-0x000000018B47075C
	}

	public class CheckEvent : ConditionTask<GraphOwner> // TypeDefIndex: 48844
	{
		// Fields
		public BBParameter<string> eventName; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B486930-0x000000018B486998 
	
		// Constructors
		public CheckEvent() {} // 0x000000018B4868F4-0x000000018B486930
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B48685C-0x000000018B4868F4
		protected override void OnDisable() {} // 0x000000018B4867C4-0x000000018B48685C
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData data) {} // 0x000000018B486744-0x000000018B4867C4
	}

	public class CheckEvent<T> : ConditionTask<GraphOwner> // TypeDefIndex: 48845
	{
		// Fields
		public BBParameter<string> eventName;
		public BBParameter<T> saveEventValue;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public CheckEvent() {}
	
		// Methods
		protected override void OnEnable() {}
		protected override void OnDisable() {}
		protected override bool OnCheck() => default;
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData data) {}
	}

	public class CheckEventValue<T> : ConditionTask<GraphOwner> // TypeDefIndex: 48846
	{
		// Fields
		public BBParameter<string> eventName;
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public CheckEventValue() {}
	
		// Methods
		protected override void OnEnable() {}
		protected override void OnDisable() {}
		protected override bool OnCheck() => default;
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg) {}
	}

	public class CheckSignal : ConditionTask<Transform> // TypeDefIndex: 48847
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B47F758-0x000000018B47F77C 
	
		// Constructors
		public CheckSignal() {} // 0x000000018B486D30-0x000000018B486DB8
	
		// Methods
		protected override string OnInit() => default; // 0x000000018B486B54-0x000000018B486BA4
		protected override void OnEnable() {} // 0x000000018B486A48-0x000000018B486B54
		protected override void OnDisable() {} // 0x000000018B486998-0x000000018B486A48
		private void OnSignalInvoke(Transform sender, Transform receiver, bool isGlobal, object[] args) {} // 0x000000018B486BA4-0x000000018B486D30
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public class CheckStateStatus : ConditionTask // TypeDefIndex: 48848
	{
		// Fields
		public CompactStatus status; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018B486FCC-0x000000018B48702C 
	
		// Constructors
		public CheckStateStatus() {} // 0x0000000185FD2A20-0x0000000185FD2A30
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018B486F38-0x000000018B486FCC
	}

	public class DebugCondition : ConditionTask // TypeDefIndex: 48849
	{
		// Constructors
		public DebugCondition() {} // 0x0000000185FB89B0-0x0000000185FB89C0
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public class Probability : ConditionTask // TypeDefIndex: 48850
	{
		// Fields
		public BBParameter<float> probability; // 0x68
		public BBParameter<float> maxValue; // 0x70
		private bool success; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018B496CF8-0x000000018B496D9C 
	
		// Constructors
		public Probability() {} // 0x000000018B496C84-0x000000018B496CF8
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B496C04-0x000000018B496C84
		protected override bool OnCheck() => default; // 0x0000000185FB0DA0-0x0000000185FB0DB0
	}

	public class Timeout : ConditionTask // TypeDefIndex: 48851
	{
		// Fields
		public BBParameter<float> timeout; // 0x68
		private float currentTime; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018B49B4CC-0x000000018B49B550 
	
		// Constructors
		public Timeout() {} // 0x000000018B49B478-0x000000018B49B4CC
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B49B3E0-0x000000018B49B478
		protected override void OnDisable() {} // 0x000000018B49B348-0x000000018B49B3E0
		private void MoveNext() {} // 0x000000018B49B268-0x000000018B49B2E4
		protected override bool OnCheck() => default; // 0x000000018B49B2E4-0x000000018B49B348
	}
}

namespace ParadoxNotion
{
	public delegate void ActionCall(); // TypeDefIndex: 49263; 0x00000001864BC320-0x00000001864BC330

	public delegate void ActionCall<T1>(T1 a); // TypeDefIndex: 49264; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2>(T1 a, T2 b); // TypeDefIndex: 49265; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c); // TypeDefIndex: 49266; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 49267; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 49268; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 49269; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 49270; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 49271; 0x00000000-0x00000000

	public delegate TResult FunctionCall<TResult>(); // TypeDefIndex: 49272; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, TResult>(T1 a); // TypeDefIndex: 49273; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b); // TypeDefIndex: 49274; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c); // TypeDefIndex: 49275; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 49276; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 49277; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 49278; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 49279; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 49280; 0x00000000-0x00000000

	[Serializable]
	public sealed class DynamicParameterDefinition : ISerializationCallbackReceiver // TypeDefIndex: 49281
	{
		// Fields
		private string _ID; // 0x10
		private string _name; // 0x18
		private string _type; // 0x20
		private System.Type _type_k__BackingField; // 0x28
	
		// Properties
		public string ID { get => default; private set {} } // 0x000000018B4B67F4-0x000000018B4B6824 0x0000000184096E30-0x0000000184096EF0
		public string name { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public System.Type type { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public DynamicParameterDefinition() {} // 0x0000000185492010-0x0000000185492020
		public DynamicParameterDefinition(string name, System.Type type) {} // 0x000000018B4B677C-0x000000018B4B67F4
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4B670C-0x000000018B4B677C
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4B66AC-0x000000018B4B670C
	}

	public enum CompareMethod // TypeDefIndex: 49282
	{
		EqualTo = 0,
		GreaterThan = 1,
		LessThan = 2,
		GreaterOrEqualTo = 3,
		LessOrEqualTo = 4
	}

	public enum OperationMethod // TypeDefIndex: 49283
	{
		Set = 0,
		Add = 1,
		Subtract = 2,
		Multiply = 3,
		Divide = 4
	}

	public enum ButtonKeys // TypeDefIndex: 49284
	{
		Left = 0,
		Right = 1,
		Middle = 2
	}

	public enum PressTypes // TypeDefIndex: 49285
	{
		Down = 0,
		Up = 1,
		Pressed = 2
	}

	public enum MouseClickEvent // TypeDefIndex: 49286
	{
		MouseDown = 0,
		MouseUp = 1
	}

	public enum TriggerTypes // TypeDefIndex: 49287
	{
		TriggerEnter = 0,
		TriggerExit = 1,
		TriggerStay = 2
	}

	public enum CollisionTypes // TypeDefIndex: 49288
	{
		CollisionEnter = 0,
		CollisionExit = 1,
		CollisionStay = 2
	}

	public enum MouseInteractionTypes // TypeDefIndex: 49289
	{
		MouseEnter = 0,
		MouseExit = 1,
		MouseOver = 2
	}

	public enum CompactStatus // TypeDefIndex: 49290
	{
		Failure = 0,
		Success = 1
	}

	public enum PlayDirections // TypeDefIndex: 49291
	{
		Forward = 0,
		Backward = 1,
		Toggle = 2
	}

	public enum PlanarDirection // TypeDefIndex: 49292
	{
		Horizontal = 0,
		Vertical = 1,
		Auto = 2
	}

	public enum Alignment2x2 // TypeDefIndex: 49293
	{
		Default = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4
	}

	public enum Alignment3x3 // TypeDefIndex: 49294
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		BottomLeft = 6,
		BottomCenter = 7,
		BottomRight = 8
	}

	public class HierarchyTree // TypeDefIndex: 49297
	{
		// Nested types
		public class Element // TypeDefIndex: 49296
		{
			// Fields
			private object _reference; // 0x10
			private Element _parent; // 0x18
			private List<Element> _children; // 0x20
	
			// Properties
			public object reference { get => default; }
			public Element parent { get => default; }
			public IEnumerable<Element> children { get => default; }
	
			// Nested types
			private sealed class _GetAllChildrenReferencesOfType_d__15<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 49295
			{
				// Fields
				private int __1__state;
				private T __2__current;
				private int __l__initialThreadId;
				public Element __4__this;
				private int _i_5__2;
				private Element _element_5__3;
				private IEnumerator<T> __7__wrap3;
	
				// Properties
				T IEnumerator<T>.Current { get => default; } // 0x0000000184096E30-0x0000000184096EF0 
				object IEnumerator.Current { get => default; } // 0x000000018B4B69A0-0x000000018B4B69F4 
	
				// Constructors
				public _GetAllChildrenReferencesOfType_d__15() {} // Dummy constructor
				public _GetAllChildrenReferencesOfType_d__15(int __1__state) {}
	
				// Methods
				void IDisposable.Dispose() {}
				private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
				private void __m__Finally1() {}
				void IEnumerator.Reset() {} // 0x000000018B4B6824-0x000000018B4B68E8
				IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
				IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B4B68E8-0x000000018B4B698C
			}
	
			// Constructors
			public Element() {} // Dummy constructor
			public Element(object reference) {}
	
			// Methods
			public Element AddChild(Element child) => default;
			public void RemoveChild(Element child) {}
			public Element GetRoot() => default;
			public Element FindReferenceElement(object target) => default;
			public T GetFirstParentReferenceOfType<T>() => default;
			public IEnumerable<T> GetAllChildrenReferencesOfType<T>() => default;
		}
	
		// Constructors
		public HierarchyTree() {}
	}

	public interface IEventData // TypeDefIndex: 49298
	{
		// Properties
		GameObject receiver { get; }
		object sender { get; }
		object valueBoxed { get; }
	}

	public struct EventData : ParadoxNotion.IEventData // TypeDefIndex: 49299
	{
		// Fields
		private GameObject _receiver_k__BackingField; // 0x00
		private object _sender_k__BackingField; // 0x08
		private object _value_k__BackingField; // 0x10
	
		// Properties
		public GameObject receiver { get; private set; } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public object sender { get; private set; } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public object value { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public object valueBoxed { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public EventData(object value, GameObject receiver, object sender) : this() {
			<receiver>k__BackingField = default;
			<sender>k__BackingField = default;
			<value>k__BackingField = default;
		} // 0x000000018B4B6A30-0x000000018B4B6A64
		public EventData(GameObject receiver, object sender) : this() {
			<receiver>k__BackingField = default;
			<sender>k__BackingField = default;
			<value>k__BackingField = default;
		} // 0x000000018B4B69F4-0x000000018B4B6A30
	}

	public struct EventData<T> : ParadoxNotion.IEventData // TypeDefIndex: 49300
	{
		// Fields
		private GameObject _receiver_k__BackingField;
		private object _sender_k__BackingField;
		private T _value_k__BackingField;
	
		// Properties
		public GameObject receiver { get; private set; }
		public object sender { get; private set; }
		public T value { get; private set; }
		public object valueBoxed { get => default; }
	
		// Constructors
		public EventData(T value, GameObject receiver, object sender) : this() {
			<receiver>k__BackingField = default;
			<sender>k__BackingField = default;
			<value>k__BackingField = default;
		}
	}

	public static class OperationTools // TypeDefIndex: 49301
	{
		// Methods
		public static string GetOperationString(OperationMethod om) => default; // 0x000000018B4BBF9C-0x000000018B4BC058
		public static float Operate(float a, float b, OperationMethod om, float delta = 1f /* Metadata: 0x02060E88 */) => default; // 0x000000018B4BC274-0x000000018B4BC2BC
		public static int Operate(int a, int b, OperationMethod om) => default; // 0x000000018B4BC238-0x000000018B4BC274
		public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f /* Metadata: 0x02060E8C */) => default; // 0x000000018B4BC058-0x000000018B4BC238
		public static string GetCompareString(CompareMethod cm) => default; // 0x000000018B4BBEE0-0x000000018B4BBF9C
		public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint) => default; // 0x000000018B4BBE98-0x000000018B4BBEE0
		public static bool Compare(int a, int b, CompareMethod cm) => default; // 0x000000018B4BBE58-0x000000018B4BBE98
	}

	public static class ReflectionTools // TypeDefIndex: 49308
	{
		// Fields
		public const System.Reflection.BindingFlags FLAGS_ALL = (System.Reflection.BindingFlags) 124; // Metadata: 0x02060E97
		public const System.Reflection.BindingFlags FLAGS_ALL_DECLARED = (System.Reflection.BindingFlags) 62; // Metadata: 0x02060E99
		private static Assembly[] _loadedAssemblies; // 0x00
		private static System.Type[] _allTypes; // 0x08
		private static object[] _tempArgs; // 0x10
		private static Dictionary<string, System.Type> _typesMap; // 0x18
		private static Dictionary<System.Type, System.Type[]> _subTypesMap; // 0x20
		private static Dictionary<MethodBase, MethodType> _methodSpecialType; // 0x28
		private static Dictionary<System.Type, string> _typeFriendlyName; // 0x30
		private static Dictionary<System.Type, string> _typeFriendlyNameCompileSafe; // 0x38
		private static Dictionary<MethodBase, string> _methodSignatures; // 0x40
		private static Dictionary<System.Type, ConstructorInfo[]> _typeConstructors; // 0x48
		private static Dictionary<System.Type, MethodInfo[]> _typeMethods; // 0x50
		private static Dictionary<System.Type, System.Reflection.FieldInfo[]> _typeFields; // 0x58
		private static Dictionary<System.Type, PropertyInfo[]> _typeProperties; // 0x60
		private static Dictionary<System.Type, EventInfo[]> _typeEvents; // 0x68
		private static Dictionary<System.Type, object[]> _typeAttributes; // 0x70
		private static Dictionary<MemberInfo, object[]> _memberAttributes; // 0x78
		private static Dictionary<MemberInfo, bool> _obsoleteCache; // 0x80
		private static Dictionary<System.Type, MethodInfo[]> _typeExtensions; // 0x88
		private static Dictionary<System.Type, System.Type[]> _genericArgsTypeCache; // 0x90
		private static Dictionary<MethodInfo, System.Type[]> _genericArgsMathodCache; // 0x98
		public static readonly Dictionary<string, string> op_FriendlyNamesLong; // 0xA0
		public static readonly Dictionary<string, string> op_FriendlyNamesShort; // 0xA8
		public static readonly Dictionary<string, string> op_CSharpAliases; // 0xB0
		public const string METHOD_SPECIAL_NAME_GET = "get_"; // Metadata: 0x02060E9A
		public const string METHOD_SPECIAL_NAME_SET = "set_"; // Metadata: 0x02060E9F
		public const string METHOD_SPECIAL_NAME_ADD = "add_"; // Metadata: 0x02060EA4
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_"; // Metadata: 0x02060EA9
		public const string METHOD_SPECIAL_NAME_OP = "op_"; // Metadata: 0x02060EB1
	
		// Properties
		private static Assembly[] loadedAssemblies { get; } // 0x000000018B4C1990-0x000000018B4C19EC 
	
		// Nested types
		public enum MethodType // TypeDefIndex: 49302
		{
			Normal = 0,
			PropertyAccessor = 1,
			Event = 2,
			Operator = 3
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 49303
		{
			// Fields
			public bool includeObsolete; // 0x10
			public Func<System.Type, bool> __9__2; // 0x18
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x0000000185016600-0x00000001850171D0
	
			// Methods
			internal bool _GetAllTypes_b__2(System.Type t) => default; // 0x000000018576DFA0-0x000000018576E730
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49304
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__33_0; // 0x08
			public static Func<System.Type, string> __9__33_1; // 0x10
			public static Func<ParameterInfo, System.Type> __9__102_0; // 0x18
			public static Func<ParameterInfo, System.Type> __9__110_0; // 0x20
	
			// Constructors
			static __c() {} // 0x000000018B4C2ED4-0x000000018B4C2F84
			public __c() {} // 0x000000018B4BF74C-0x000000018B4BF79C
	
			// Methods
			internal string _GetAllTypes_b__33_0(System.Type t) => default; // 0x000000018B4BF6F8-0x000000018B4BF74C
			internal string _GetAllTypes_b__33_1(System.Type t) => default; // 0x000000018B4BF79C-0x000000018B4BF9C8
			internal System.Type _RTCreateDelegate_b__102_0(ParameterInfo p) => default; // 0x000000018B4BF578-0x000000018B4BF6F8
			internal System.Type _GetBaseDefinition_b__110_0(ParameterInfo p) => default; // 0x000000018B4C2814-0x000000018B4C2D20
		}
	
		private sealed class _RTGetAttributesRecursive_d__99<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 49305
			where T : Attribute
		{
			// Fields
			private int __1__state;
			private T __2__current;
			private int __l__initialThreadId;
			private System.Type type;
			public System.Type __3__type;
			private System.Type _current_5__2;
	
			// Properties
			T IEnumerator<T>.Current { get => default; } // 0x000000018B4BEEC4-0x000000018B4BF0A0 
			object IEnumerator.Current { get => default; } // 0x000000018B4BF0A0-0x000000018B4BF4F8 
	
			// Constructors
			public _RTGetAttributesRecursive_d__99() {} // Dummy constructor
			public _RTGetAttributesRecursive_d__99(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4C2D20-0x000000018B4C2ED4
			private bool MoveNext() => default; // 0x000000018B4BE028-0x000000018B4BE490
			void IEnumerator.Reset() {} // 0x000000018B4C2270-0x000000018B4C22F8
			IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B4BD878-0x000000018B4BD974
		}
	
		private sealed class __c__DisplayClass128_0<T, TResult> // TypeDefIndex: 49306
		{
			// Fields
			public System.Reflection.FieldInfo info;
	
			// Constructors
			public __c__DisplayClass128_0() {} // 0x000000018B4BD34C-0x000000018B4BD3A4
	
			// Methods
			internal TResult _GetFieldGetter_b__0(T instance) => default; // 0x000000018B4BD3A4-0x000000018B4BD878
		}
	
		private sealed class __c__DisplayClass129_0<T, TValue> // TypeDefIndex: 49307
		{
			// Fields
			public System.Reflection.FieldInfo info;
	
			// Constructors
			public __c__DisplayClass129_0() {} // 0x000000018B4C1E90-0x000000018B4C2270
	
			// Methods
			internal void _GetFieldSetter_b__0(T instance, TValue value) {} // 0x000000018B4BDE84-0x000000018B4BDF80
		}
	
		// Constructors
		static ReflectionTools() {} // 0x000000018B4C1C18-0x000000018B4C1C8C
	
		// Methods
		public static void FlushMem() {} // 0x00000001852605A0-0x00000001852605D0
		public static System.Type GetType(string typeFullName) => default; // 0x000000018B4C1954-0x000000018B4C1970
		public static System.Type GetType(string typeFullName, System.Type fallbackAssignable) => default; // 0x000000018B4C1BD4-0x000000018B4C1BF4
		public static System.Type GetType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x02060E90 */, System.Type fallbackAssignable = null) => default; // 0x000000018B4C1970-0x000000018B4C1990
		private static System.Type GetTypeDirect(string typeFullName) => default; // 0x000000018B4C1B94-0x000000018B4C1BB0
		private static System.Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x02060E91 */, System.Type fallbackAssignable = null) => default; // 0x000000018B4C1BB0-0x000000018B4C1BD4
		private static System.Type TryResolveDeserializeFromAttribute(string typeName) => default; // 0x000000018B4C1B54-0x000000018B4C1B74
		private static System.Type TryResolveWithoutNamespace(string typeName, System.Type fallbackAssignable = null) => default; // 0x000000018B4C1B74-0x000000018B4C1B94
		public static System.Type[] GetAllTypes(bool includeObsolete) => default; // 0x000000018B4C13A4-0x000000018B4C13C0
		public static System.Type[] GetImplementationsOf(System.Type baseType) => default; // 0x000000018B4C1938-0x000000018B4C1954
		public static object[] SingleTempArgsArray(object arg) => default; // 0x000000018B4C0984-0x000000018B4C09A4
		public static MethodType GetMethodSpecialType(MethodBase method) => default; // 0x000000018B4C1BF4-0x000000018B4C1C18
		public static string FriendlyName(System.Type t, bool compileSafe = false /* Metadata: 0x02060E92 */) => default; // 0x000000018B4C119C-0x000000018B4C12A0
		public static string FriendlyName(MemberInfo info) => default; // 0x000000018B4C12A0-0x000000018B4C13A4
		public static string FriendlyName(MethodBase method) => default; // 0x000000018B4C0AF0-0x000000018B4C0B40
		public static string FriendlyName(MethodBase method, out MethodType specialNameType) {
			specialNameType = default;
			return default;
		} // 0x000000018B4C0AA0-0x000000018B4C0AF0
		public static string SignatureName(MethodBase method) => default; // 0x000000018B4C19EC-0x000000018B4C1A3C
		public static string FriendlyTypeName(string fullName) => default; // 0x000000018B4BCD10-0x000000018B4BCD60
		public static System.Type RTReflectedOrDeclaredType(MemberInfo member) => default; // 0x000000018B4BCCA8-0x000000018B4BCD10
		public static bool RTIsAssignableFrom(System.Type type, System.Type other) => default; // 0x000000018B4C08E4-0x000000018B4C0984
		public static bool RTIsAssignableTo(System.Type type, System.Type other) => default; // 0x000000018B4C06D8-0x000000018B4C0800
		public static bool RTIsAbstract(System.Type type) => default; // 0x000000018B4BFF84-0x000000018B4BFFFC
		public static bool RTIsValueType(System.Type type) => default; // 0x000000018B4C13C0-0x000000018B4C1494
		public static bool RTIsArray(System.Type type) => default; // 0x000000018B4C1494-0x000000018B4C16A4
		public static bool RTIsInterface(System.Type type) => default; // 0x000000018B4C0FA0-0x000000018B4C10BC
		public static bool RTIsSubclassOf(System.Type type, System.Type other) => default; // 0x000000018B4C1864-0x000000018B4C1938
		public static bool RTIsGenericParameter(System.Type type) => default; // 0x000000018B4C0E34-0x000000018B4C0FA0
		public static bool RTIsGenericType(System.Type type) => default; // 0x000000018B4C0B40-0x000000018B4C0C14
		public static MethodInfo RTGetGetMethod(PropertyInfo prop) => default; // 0x000000018B4C0CF4-0x000000018B4C0E34
		public static MethodInfo RTGetSetMethod(PropertyInfo prop) => default; // 0x000000018B4C1C8C-0x000000018B4C1DD4
		public static MethodInfo RTGetDelegateMethodInfo(Delegate del) => default; // 0x000000018B4C0800-0x000000018B4C08E4
		public static System.Type RTMakeGenericType(System.Type type, System.Type[] typeArgs) => default; // 0x000000018B4C16A4-0x000000018B4C1784
		public static System.Type[] RTGetGenericArguments(System.Type type) => default; // 0x000000018B4C10BC-0x000000018B4C119C
		public static System.Type[] RTGetGenericArguments(MethodInfo method) => default; // 0x000000018B4C1784-0x000000018B4C1864
		public static System.Type[] RTGetEmptyTypes() => default; // 0x000000018B4C0C14-0x000000018B4C0CF4
		public static System.Type RTGetElementType(System.Type type) => default; // 0x000000018B4C0204-0x000000018B4C03C4
		public static bool RTIsByRef(System.Type type) => default;
		public static object CreateObject(System.Type type) => default; // 0x000000018B4C1A3C-0x000000018B4C1AC8
		public static object CreateObjectUninitialized(System.Type type) => default;
		public static ConstructorInfo RTGetDefaultConstructor(System.Type type) => default; // 0x000000018B4C05C0-0x000000018B4C06D8
		public static ConstructorInfo RTGetConstructor(System.Type type, System.Type[] paramTypes) => default; // 0x000000018B4C03C4-0x000000018B4C04A0
		private static bool MemberResolvedFromDeserializeAttribute(MemberInfo member, string targetName) => default;
		public static MethodInfo RTGetMethod(System.Type type, string name) => default; // 0x000000018B4C1AC8-0x000000018B4C1B54
		public static MethodInfo RTGetMethod(System.Type type, string name, System.Type[] paramTypes, System.Type returnType = null, System.Type[] genericArgumentTypes = null) => default;
		public static System.Reflection.FieldInfo RTGetField(System.Type type, string name, bool includePrivateBase = false /* Metadata: 0x02060E93 */) => default; // 0x000000018B4C04A0-0x000000018B4C05C0
		public static PropertyInfo RTGetProperty(System.Type type, string name) => default;
		public static MemberInfo RTGetFieldOrProp(System.Type type, string name) => default; // 0x000000018B4C09A4-0x000000018B4C0AA0
		public static EventInfo RTGetEvent(System.Type type, string name) => default;
		public static object RTGetFieldOrPropValue(MemberInfo member, object instance, int index = -1 /* Metadata: 0x02060E94 */) => default; // 0x000000018B4BFFFC-0x000000018B4C0204
		public static void RTSetFieldOrPropValue(MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x02060E95 */) {} // 0x000000018B4BCC68-0x000000018B4BCCA8
		public static ConstructorInfo[] RTGetConstructors(System.Type type) => default; // 0x000000018B4BFEBC-0x000000018B4BFEF4
		public static MethodInfo[] RTGetMethods(System.Type type) => default; // 0x000000018B4BFAA8-0x000000018B4BFB08
		public static System.Reflection.FieldInfo[] RTGetFields(System.Type type) => default; // 0x000000018B4BFF3C-0x000000018B4BFF84
		public static PropertyInfo[] RTGetProperties(System.Type type) => default; // 0x000000018B4BFEF4-0x000000018B4BFF3C
		public static EventInfo[] RTGetEvents(System.Type type) => default; // 0x000000018B4BFDE0-0x000000018B4BFE74
		public static object[] RTGetAllAttributes(System.Type type) => default; // 0x000000018B4BFC60-0x000000018B4BFDE0
		public static bool RTIsDefined<T>(System.Type type, bool inherited)
			where T : Attribute => default; // 0x000000018B4BE50C-0x000000018B4BE80C
		public static bool RTIsDefined(System.Type type, System.Type attributeType, bool inherited) => default; // 0x000000018B4BE490-0x000000018B4BE50C
		public static T RTGetAttribute<T>(System.Type type, bool inherited)
			where T : Attribute => default; // 0x000000018B4BE9AC-0x000000018B4BEC88
		public static Attribute RTGetAttribute(System.Type type, System.Type attributeType, bool inherited) => default; // 0x000000018B4BFBDC-0x000000018B4BFC30
		public static object[] RTGetAllAttributes(MemberInfo member) => default; // 0x000000018B4BFE74-0x000000018B4BFEBC
		public static bool RTIsDefined<T>(MemberInfo member, bool inherited)
			where T : Attribute => default; // 0x000000018B4BFC30-0x000000018B4BFC60
		public static bool RTIsDefined(MemberInfo member, System.Type attributeType, bool inherited) => default; // 0x000000018B4BF9C8-0x000000018B4BFAA8
		public static T RTGetAttribute<T>(MemberInfo member, bool inherited)
			where T : Attribute => default; // 0x000000018B4BDF80-0x000000018B4BE028
		public static Attribute RTGetAttribute(MemberInfo member, System.Type attributeType, bool inherited) => default; // 0x000000018B4BFB08-0x000000018B4BFBDC
		public static IEnumerable<T> RTGetAttributesRecursive<T>(System.Type type)
			where T : Attribute => default; // 0x000000018B4BE80C-0x000000018B4BE9AC
		public static ParameterInfo[] RTGetDelegateTypeParameters(System.Type delegateType) => default; // 0x000000018B4BF4F8-0x000000018B4BF578
		public static T RTCreateDelegate<T>(MethodInfo method, object instance)
			where T : Delegate => default; // 0x000000018B4BED9C-0x000000018B4BEEC4
		public static Delegate RTCreateDelegate(MethodInfo method, System.Type type, object instance) => default; // 0x000000018B4BEC88-0x000000018B4BED9C
		public static Delegate ConvertDelegate(Delegate originalDelegate, System.Type targetDelegateType) => default; // 0x000000018B4C23FC-0x000000018B4C2580
		public static bool IsReadOnly(System.Reflection.FieldInfo field) => default; // 0x000000018B4C2580-0x000000018B4C26F8
		public static bool IsConstant(System.Reflection.FieldInfo field) => default; // 0x000000018B4C1DD4-0x000000018B4C1E90
		public static bool IsStatic(EventInfo info) => default; // 0x000000018B4C22F8-0x000000018B4C23FC
		public static bool IsStatic(PropertyInfo info) => default; // 0x000000018B4BCD60-0x000000018B4BD34C
		public static bool IsParams(ParameterInfo parameter, ParameterInfo[] parameters) => default;
		public static bool IsObsolete(MemberInfo member, bool inherited = true /* Metadata: 0x02060E96 */) => default;
		public static PropertyInfo GetBaseDefinition(PropertyInfo propertyInfo) => default; // 0x0000000185492010-0x0000000185492020
		public static System.Reflection.FieldInfo GetBaseDefinition(System.Reflection.FieldInfo fieldInfo) => default; // 0x000000018B4D5604-0x000000018B4D5670
		public static MethodInfo[] GetExtensionMethods(System.Type targetType) => default; // 0x000000018B4D5CD4-0x000000018B4D5D38
		public static bool IsExtensionMethod(MethodInfo method) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsPropertyAccessor(MethodInfo method) => default; // 0x000000018B4D4CD4-0x000000018B4D4CF4
		public static bool IsIndexerProperty(PropertyInfo property) => default; // 0x000000018B4D4CF4-0x000000018B4D4D40
		public static bool IsAutoProperty(PropertyInfo property) => default; // 0x0000000187AD0B74-0x0000000187AD0B8C
		public static PropertyInfo GetAccessorProperty(MethodInfo method) => default; // 0x0000000187AD0B74-0x0000000187AD0B8C
		public static bool IsEnumerableCollection(System.Type type) => default;
		public static System.Type GetEnumerableElementType(System.Type type) => default;
		public static System.Type GetSingleGenericArgument(System.Type type) => default;
		public static System.Type GetFirstGenericParameterConstraintType(System.Type type) => default;
		public static System.Type GetFirstGenericParameterConstraintType(MethodInfo method) => default;
		public static bool TryMakeGeneric(System.Type def, System.Type argType, out System.Type result) {
			result = default;
			return default;
		}
		public static bool TryMakeGeneric(MethodInfo def, System.Type argType, out MethodInfo result) {
			result = default;
			return default;
		}
		public static Array Resize(Array array, int newSize) => default;
		public static bool TryConvert(System.Type fromType, System.Type toType, out UnaryExpression exp) {
			exp = default;
			return default;
		}
		public static void DigFields(object root, Predicate<System.Reflection.FieldInfo> move, Action<object> push, Action<object> pop) {}
		public static Func<T, TResult> GetFieldGetter<T, TResult>(System.Reflection.FieldInfo info) => default;
		public static Action<T, TValue> GetFieldSetter<T, TValue>(System.Reflection.FieldInfo info) => default;
	}

	public static class TypeConverter // TypeDefIndex: 49312
	{
		// Fields
		private static CustomConverter customConverter; // 0x00
	
		// Events
		public static event CustomConverter customConverter;
	
		// Nested types
		public delegate Func<object, object> CustomConverter(System.Type fromType, System.Type toType); // TypeDefIndex: 49309; 0x000000018B4D4AEC-0x000000018B4D4B94
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 49310
		{
			// Fields
			public System.Type toType; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018A29B308-0x000000018A29B430
	
			// Methods
			internal object _Get_b__2(object value) => default; // 0x0000000181B59400-0x0000000181B59410
			internal object _Get_b__4(object value) => default; // 0x0000000186E8C1B8-0x0000000186E8C1EC
			internal object _Get_b__6(object value) => default; // 0x00000001864750A8-0x00000001864751CC
			internal object _Get_b__7(object value) => default; // 0x0000000185492010-0x0000000185492020
			internal object _Get_b__8(object value) => default; // 0x000000018B4D5670-0x000000018B4D5774
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49311
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<object, object> __9__4_0; // 0x08
			public static Func<object, object> __9__4_1; // 0x10
			public static Func<object, object> __9__4_3; // 0x18
			public static Func<object, object> __9__4_5; // 0x20
			public static Func<object, object> __9__4_9; // 0x28
			public static Func<object, object> __9__4_10; // 0x30
			public static Func<object, object> __9__4_11; // 0x38
			public static Func<object, object> __9__4_12; // 0x40
			public static Func<object, object> __9__4_13; // 0x48
			public static Func<object, object> __9__4_14; // 0x50
			public static Func<object, object> __9__4_15; // 0x58
			public static Func<object, object> __9__4_16; // 0x60
	
			// Constructors
			static __c() {} // 0x000000018B4D5774-0x000000018B4D5820
			public __c() {} // 0x000000018B4D5820-0x000000018B4D58DC
	
			// Methods
			internal object _Get_b__4_0(object value) => default; // 0x000000018B4D58DC-0x000000018B4D5988
			internal object _Get_b__4_1(object value) => default; // 0x000000018B4D5988-0x000000018B4D5A44
			internal object _Get_b__4_3(object value) => default; // 0x0000000185F78670-0x0000000185F786D0
			internal object _Get_b__4_5(object value) => default; // 0x0000000185492010-0x0000000185492020
			internal object _Get_b__4_9(object value) => default; // 0x00000001834A4750-0x00000001834A4760
			internal object _Get_b__4_10(object value) => default; // 0x000000018B4D5204-0x000000018B4D5250
			internal object _Get_b__4_11(object value) => default; // 0x000000018B4D5250-0x000000018B4D5294
			internal object _Get_b__4_12(object value) => default; // 0x000000018B4D5294-0x000000018B4D5334
			internal object _Get_b__4_13(object value) => default; // 0x000000018B4D5334-0x000000018B4D5410
			internal object _Get_b__4_14(object value) => default; // 0x000000018B4D4D78-0x000000018B4D4E60
			internal object _Get_b__4_15(object value) => default; // 0x000000018B4D4E60-0x000000018B4D4F34
			internal object _Get_b__4_16(object value) => default; // 0x000000018B4D4F34-0x000000018B4D5014
		}
	
		// Methods
		public static Func<object, object> Get(System.Type fromType, System.Type toType) => default; // 0x000000018B4D5114-0x000000018B4D518C
		public static bool CanConvert(System.Type fromType, System.Type toType) => default; // 0x000000018B4D518C-0x000000018B4D5204
	}

	public static class ColorUtils // TypeDefIndex: 49313
	{
		// Fields
		private static Dictionary<Color32, string> colorHexCache; // 0x00
		private static Dictionary<string, UnityEngine.Color> hexColorCache; // 0x08
		private static Dictionary<ValueTuple<int, int, Gradient, float>, Texture2D> gradientTextureCache; // 0x10
		private static Dictionary<ValueTuple<UnityEngine.Color, float, UnityEngine.Color, float>, Gradient> gradientCache; // 0x18
		private static Dictionary<string, Gradient> menuItemRibbonGradientCache; // 0x20
	
		// Constructors
		static ColorUtils() {} // 0x0000000185016390-0x0000000185016600
	
		// Methods
		public static UnityEngine.Color WithAlpha(UnityEngine.Color color, float alpha) => default; // 0x0000000185FD2C00-0x0000000185FD2C20
		public static UnityEngine.Color Grey(float value) => default; // 0x0000000185FD2BE0-0x0000000185FD2C00
		public static string ColorToHex(Color32 color) => default; // 0x000000018B4C82E0-0x000000018B4C8454
		public static UnityEngine.Color HexToColor(string hex) => default; // 0x00000001849B3E90-0x00000001849B40A0
		public static Texture2D CreateGradientTexture(int width, int height, Gradient gradient, float rotateDegree) => default; // 0x000000018B4C8454-0x000000018B4C86FC
		public static Gradient CreateGradient(UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio) => default; // 0x000000018B4C86FC-0x000000018B4C8988
		public static Gradient GetMenuItemRibbonGradientOfNodeFullPath(string fullPath) => default; // 0x000000018B4C8988-0x000000018B4C8A0C
		public static void RegisterMenuItemRibbonGradientOfNodeFullPath(string fullPath, UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio) {} // 0x000000018B4C8A0C-0x000000018B4C8AE4
	}

	public static class CurveUtils // TypeDefIndex: 49314
	{
		// Fields
		private const float POS_CHECK_RES = 100f; // Metadata: 0x02060EB9
		private const float POS_CHECK_DISTANCE = 10f; // Metadata: 0x02060EBD
	
		// Methods
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t) => default; // 0x000000018B4C8AE4-0x000000018B4C8BFC
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition) => default; // 0x000000018B4C8BFC-0x000000018B4C8C34
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm) {
			norm = default;
			return default;
		} // 0x000000018B4C8C34-0x000000018B4C8E14
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent) {
			fromTangent = default;
			toTangent = default;
		} // 0x000000018B4C9008-0x000000018B4C90C0
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent) {
			fromTangent = default;
			toTangent = default;
		} // 0x000000018B4C8E14-0x000000018B4C9008
	}

	public static class GUIStyleUtils // TypeDefIndex: 49315
	{
		// Methods
		public static GUIStyle Margin(GUIStyle style, int left, int right, int top, int bottom) => default; // 0x000000018B4CE308-0x000000018B4CE3B4
		public static GUIStyle Padding(GUIStyle style, int left, int right, int top, int bottom) => default; // 0x000000018B4CE460-0x000000018B4CE50C
		public static GUIStyle Border(GUIStyle style, int left, int right, int top, int bottom) => default; // 0x000000018B4CE25C-0x000000018B4CE308
		public static GUIStyle Overflow(GUIStyle style, int left, int right, int top, int bottom) => default; // 0x000000018B4CE3B4-0x000000018B4CE460
		public static GUIStyle TextAlignment(GUIStyle style, TextAnchor anchor) => default; // 0x000000018B4CE534-0x000000018B4CE55C
		public static GUIStyle RichText(GUIStyle style, bool rich) => default; // 0x000000018B4CE50C-0x000000018B4CE534
	}

	public static class LayerUtils // TypeDefIndex: 49316
	{
		// Methods
		public static LayerMask CreateFromNames(string[] layerNames) => default; // 0x000000018B4CF698-0x000000018B4CF6A0
		public static LayerMask CreateFromNumbers(int[] layerNumbers) => default; // 0x000000018B4CF6A0-0x000000018B4CF6A8
		public static LayerMask LayerNamesToMask(string[] layerNames) => default; // 0x000000018B4CF6A8-0x000000018B4CF704
		public static LayerMask LayerNumbersToMask(int[] layerNumbers) => default; // 0x000000018B4CF704-0x000000018B4CF744
		public static LayerMask Inverse(LayerMask mask) => default; // 0x0000000185FD2C20-0x0000000185FD2C30
		public static LayerMask AddToMask(LayerMask mask, string[] layerNames) => default; // 0x000000018B4CF5B8-0x000000018B4CF5D8
		public static LayerMask RemoveFromMask(LayerMask mask, string[] layerNames) => default; // 0x000000018B4CF8E8-0x000000018B4CF90C
		public static bool ContainsAnyLayer(LayerMask mask, string[] layerNames) => default; // 0x000000018B4CF638-0x000000018B4CF698
		public static bool ContainsAllLayers(LayerMask mask, string[] layerNames) => default; // 0x000000018B4CF5D8-0x000000018B4CF638
		public static string[] MaskToNames(LayerMask mask) => default; // 0x000000018B4CF744-0x000000018B4CF820
		public static string MaskToString(LayerMask mask) => default; // 0x000000018B4CF8AC-0x000000018B4CF8E8
		public static string MaskToString(LayerMask mask, string delimiter) => default; // 0x000000018B4CF820-0x000000018B4CF8AC
	}

	public static class ObjectUtils // TypeDefIndex: 49318
	{
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 49317
		{
			// Fields
			public GameObject exclude; // 0x10
			public LayerMask mask; // 0x18
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018B4D1030-0x000000018B4D10F4
	
			// Methods
			internal bool _FindGameObjectsWithinLayerMask_b__0(GameObject x) => default;
		}
	
		// Methods
		public static bool AnyEquals(object a, object b) => default;
		public static List<T> Shuffle<T>(List<T> list) => default;
		public static bool Is<T>(object o, out ref T result) {
			result = default;
			return default;
		} // 0x000000018B4D1220-0x000000018B4D1360
		public static T GetAddComponent<T>(GameObject gameObject)
			where T : Component => default; // 0x000000018B4D10F4-0x000000018B4D11F0
		public static Component TransformToType(Component current, System.Type type) => default; // 0x000000018B4D11F0-0x000000018B4D1220
		public static IEnumerable<GameObject> FindGameObjectsWithinLayerMask(LayerMask mask, GameObject exclude = null) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsInLayerMask(GameObject gameObject, LayerMask mask) => default; // 0x000000018B4D5A44-0x000000018B4D5AB8
	}

	public static class RectUtils // TypeDefIndex: 49319
	{
		// Methods
		public static Rect GetBoundRect(Rect[] rects) => default; // 0x000000018B4D1494-0x000000018B4D15B4
		public static Rect GetBoundRect(Vector2[] positions) => default; // 0x000000018B4D15B4-0x000000018B4D16C4
		public static bool Encapsulates(Rect a, Rect b) => default; // 0x000000018B4D1360-0x000000018B4D13AC
		public static Rect ExpandBy(Rect rect, float margin) => default; // 0x000000018B4D1414-0x000000018B4D1450
		public static Rect ExpandBy(Rect rect, float xMargin, float yMargin) => default; // 0x000000018B4D1450-0x000000018B4D1494
		public static Rect ExpandBy(Rect rect, float left, float top, float right, float bottom) => default; // 0x000000018B4D13AC-0x000000018B4D1414
		public static Rect TransformSpace(Rect rect, Rect oldContainer, Rect newContainer) => default; // 0x000000018B4D1744-0x000000018B4D187C
		public static Vector2 TransformSpace(Vector2 vector, Rect oldContainer, Rect newContainer) => default; // 0x000000018B4D16C4-0x000000018B4D1744
	}

	public static class StringUtils // TypeDefIndex: 49320
	{
		// Fields
		public const string SPACE = " "; // Metadata: 0x02060EC3
		public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Metadata: 0x02060EC5
		public static readonly char[] CHAR_SPACE_ARRAY; // 0x00
		private static Dictionary<string, string> splitCaseCache; // 0x08
	
		// Constructors
		static StringUtils() {} // 0x000000018B4D45B4-0x000000018B4D46D0
	
		// Methods
		public static string SplitCamelCase(string s) => default; // 0x000000018B4D41AC-0x000000018B4D4350
		public static string CapitalizeFirst(string s) => default; // 0x000000018B4D3658-0x000000018B4D370C
		public static string CapLength(string s, int max) => default; // 0x000000018B4D35E4-0x000000018B4D3658
		public static string GetCapitals(string s) => default; // 0x000000018B4D37D8-0x000000018B4D38E0
		public static string FormatError(string input) => default; // 0x000000018B4D370C-0x000000018B4D3748
		public static string GetAlphabetLetter(int index) => default; // 0x000000018B4D3748-0x000000018B4D37D8
		public static string GetStringWithinOuter(string input, char from, char to) => default; // 0x000000018B4D3984-0x000000018B4D39EC
		public static string GetStringWithinInner(string input, char from, char to) => default; // 0x000000018B4D38E0-0x000000018B4D3984
		public static string ReplaceWithin(string text, char startChar, char endChar, Func<string, string> Process) => default; // 0x000000018B4D39EC-0x000000018B4D3AE8
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x02060EC1 */) => default; // 0x000000018B4D3AE8-0x000000018B4D3E80
		public static bool SearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x02060EC2 */) => default; // 0x000000018B4D3E80-0x000000018B4D41AC
		public static string ToStringAdvanced(object o) => default; // 0x000000018B4D4350-0x000000018B4D45B4
	}

	public class WeakReferenceList<T> // TypeDefIndex: 49321
		where T : class
	{
		// Fields
		private List<WeakReference<T>> list;
	
		// Properties
		public int Count { get => default; }
		public T this[int i] { get => default; set {} }
	
		// Constructors
		public WeakReferenceList() {}
		public WeakReferenceList(int capacity) {}
	
		// Methods
		public void Add(T item) {}
		public void Remove(T item) {}
		public bool Contains(T item, out int index) {
			index = default;
			return default;
		}
		public void Clear() {}
		public List<T> ToReferenceList() => default;
		public static implicit operator WeakReferenceList<T>(List<T> value) => default;
	}

	public class WeakReferenceTable<TKey, TValue> // TypeDefIndex: 49322
		where TKey : class
		where TValue : IDisposable
	{
		// Fields
		private List<WeakReference<TKey>> keys;
		private List<TValue> values;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public WeakReferenceTable() {}
	
		// Methods
		public void Clear() {}
		public void Add(TKey key, TValue value) {}
		public void Remove(TKey key) {}
		public bool TryGetValueWithRefCheck(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public void RemoveMissingReferences() {}
		private void CheckCount() {}
	}
}

namespace ParadoxNotion.Animation
{
	public enum EaseType // TypeDefIndex: 49422
	{
		Linear = 0,
		QuadraticIn = 1,
		QuadraticOut = 2,
		QuadraticInOut = 3,
		QuarticIn = 4,
		QuarticOut = 5,
		QuarticInOut = 6,
		QuinticIn = 7,
		QuinticOut = 8,
		QuinticInOut = 9,
		CubicIn = 10,
		CubicOut = 11,
		CubicInOut = 12,
		ExponentialIn = 13,
		ExponentialOut = 14,
		ExponentialInOut = 15,
		CircularIn = 16,
		CircularOut = 17,
		CircularInOut = 18,
		SinusoidalIn = 19,
		SinusoidalOut = 20,
		SinusoidalInOut = 21,
		ElasticIn = 22,
		ElasticOut = 23,
		ElasticInOut = 24,
		BounceIn = 25,
		BounceOut = 26,
		BounceInOut = 27,
		BackIn = 28,
		BackOut = 29,
		BackInOut = 30
	}

	public static class Easing // TypeDefIndex: 49423
	{
		// Methods
		public static float Ease(ParadoxNotion.Animation.EaseType type, float from, float to, float t) => default; // 0x000000018B4E0A7C-0x000000018B4E0B00
		public static Vector3 Ease(ParadoxNotion.Animation.EaseType type, Vector3 from, Vector3 to, float t) => default; // 0x000000018B4E0998-0x000000018B4E0A7C
		public static Quaternion Ease(ParadoxNotion.Animation.EaseType type, Quaternion from, Quaternion to, float t) => default; // 0x000000018B4E08D4-0x000000018B4E0998
		public static UnityEngine.Color Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t) => default; // 0x000000018B4E0B00-0x000000018B4E0BBC
		public static Func<float, float> Function(ParadoxNotion.Animation.EaseType type) => default; // 0x000000018B4E0D8C-0x000000018B4E14BC
		public static float Linear(float t) => default; // 0x0000000185492010-0x0000000185492020
		public static float QuadraticIn(float t) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static float QuadraticOut(float t) => default; // 0x0000000185FD2E20-0x0000000185FD2E40
		public static float QuadraticInOut(float t) => default; // 0x000000018B4E14BC-0x000000018B4E1518
		public static float QuarticIn(float t) => default; // 0x0000000185FD2E40-0x0000000185FD2E50
		public static float QuarticOut(float t) => default; // 0x0000000185FD2E50-0x0000000185FD2E80
		public static float QuarticInOut(float t) => default; // 0x000000018B4E1518-0x000000018B4E156C
		public static float QuinticIn(float t) => default; // 0x0000000185FD2E80-0x0000000185FD2EA0
		public static float QuinticOut(float t) => default; // 0x0000000185FD2EA0-0x0000000185FD2ED0
		public static float QuinticInOut(float t) => default; // 0x000000018B4E156C-0x000000018B4E15C8
		public static float CubicIn(float t) => default; // 0x0000000185FB38F0-0x0000000185FB3900
		public static float CubicOut(float t) => default; // 0x0000000185FD2D10-0x0000000185FD2D30
		public static float CubicInOut(float t) => default; // 0x000000018B4E086C-0x000000018B4E08D4
		public static float SinusoidalIn(float t) => default; // 0x000000018B4E15C8-0x000000018B4E15F8
		public static float SinusoidalOut(float t) => default; // 0x000000018B4E15F8-0x000000018B4E1610
		public static float SinusoidalInOut(float t) => default; // 0x0000000185FD2ED0-0x0000000185FD2F00
		public static float ExponentialIn(float t) => default; // 0x000000018B4E0D1C-0x000000018B4E0D48
		public static float ExponentialOut(float t) => default; // 0x000000018B4E0D48-0x000000018B4E0D8C
		public static float ExponentialInOut(float t) => default; // 0x000000018B4E0C9C-0x000000018B4E0D1C
		public static float CircularIn(float t) => default; // 0x0000000185FD2C80-0x0000000185FD2CE0
		public static float CircularOut(float t) => default; // 0x0000000185FD2CE0-0x0000000185FD2D10
		public static float CircularInOut(float t) => default; // 0x000000018B4E0808-0x000000018B4E086C
		public static float ElasticIn(float t) => default; // 0x0000000185FD2D30-0x0000000185FD2DB0
		public static float ElasticOut(float t) => default; // 0x0000000185FD2DB0-0x0000000185FD2E20
		public static float ElasticInOut(float t) => default; // 0x000000018B4E0BBC-0x000000018B4E0C9C
		public static float BounceIn(float t) => default; // 0x000000018B4E073C-0x000000018B4E0770
		public static float BounceOut(float t) => default; // 0x000000018B4E0770-0x000000018B4E0808
		public static float BounceInOut(float t) => default; // 0x000000018B4E06D0-0x000000018B4E073C
		public static float BackIn(float t) => default; // 0x0000000185FD2C30-0x0000000185FD2C50
		public static float BackOut(float t) => default; // 0x0000000185FD2C50-0x0000000185FD2C80
		public static float BackInOut(float t) => default; // 0x000000018B4E0668-0x000000018B4E06D0
	}
}

namespace ParadoxNotion.Design
{
	public class SpoofAOTAttribute : Attribute // TypeDefIndex: 49424
	{
		// Constructors
		public SpoofAOTAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CancelSpoofAOTAttribute : Attribute // TypeDefIndex: 49425
	{
		// Constructors
		public CancelSpoofAOTAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DoNotListAttribute : Attribute // TypeDefIndex: 49426
	{
		// Constructors
		public DoNotListAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ProtectedSingletonAttribute : Attribute // TypeDefIndex: 49427
	{
		// Constructors
		public ProtectedSingletonAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ExecutionPriorityAttribute : Attribute // TypeDefIndex: 49428
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public ExecutionPriorityAttribute() {} // Dummy constructor
		public ExecutionPriorityAttribute(int priority) {} // 0x0000000181378230-0x0000000181378240
	}

	public class ExposeAsDefinitionAttribute : Attribute // TypeDefIndex: 49429
	{
		// Constructors
		public ExposeAsDefinitionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ExposeFieldAttribute : Attribute // TypeDefIndex: 49430
	{
		// Constructors
		public ExposeFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class NodeCanvasOdinOnlyAttribute : Attribute // TypeDefIndex: 49431
	{
		// Constructors
		public NodeCanvasOdinOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ListInspectorOptionAttribute : Attribute // TypeDefIndex: 49432
	{
		// Fields
		public readonly bool allowAdd; // 0x10
		public readonly bool allowRemove; // 0x11
		public readonly bool showFoldout; // 0x12
	
		// Constructors
		public ListInspectorOptionAttribute() {} // Dummy constructor
		public ListInspectorOptionAttribute(bool allowAdd, bool allowRemove, bool alwaysExpanded) {} // 0x0000000185FD2F00-0x0000000185FD2F10
	}

	public class NameAttribute : Attribute // TypeDefIndex: 49433
	{
		// Fields
		public readonly string name; // 0x10
		public readonly int priority; // 0x18
	
		// Constructors
		public NameAttribute() {} // Dummy constructor
		public NameAttribute(string name, int priority = 0 /* Metadata: 0x02060F49 */) {} // 0x0000000185BCAE90-0x0000000185BCAEB0
	}

	public class CategoryAttribute : Attribute // TypeDefIndex: 49434
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute() {} // Dummy constructor
		public CategoryAttribute(string category) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class DescriptionAttribute : Attribute // TypeDefIndex: 49435
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute() {} // Dummy constructor
		public DescriptionAttribute(string description) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class IconAttribute : Attribute // TypeDefIndex: 49436
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly bool fixedColor; // 0x18
		public readonly string runtimeIconTypeCallback; // 0x20
		public readonly System.Type fromType; // 0x28
	
		// Constructors
		public IconAttribute() {} // Dummy constructor
		public IconAttribute(string iconName = "" /* Metadata: 0x02060F4A */, bool fixedColor = false /* Metadata: 0x02060F4B */, string runtimeIconTypeCallback = "" /* Metadata: 0x02060F4C */) {} // 0x0000000185C45D50-0x0000000185C45D80
		public IconAttribute(System.Type fromType) {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
	}

	public class ColorAttribute : Attribute // TypeDefIndex: 49437
	{
		// Fields
		public readonly string hexColor; // 0x10
	
		// Constructors
		public ColorAttribute() {} // Dummy constructor
		public ColorAttribute(string hexColor) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class ColorGradientAttribute : Attribute // TypeDefIndex: 49438
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get => default; } // 0x000000018B4E05A0-0x000000018B4E0604 
		public UnityEngine.Color colorRight { get => default; } // 0x000000018B4E0604-0x000000018B4E0668 
	
		// Constructors
		public ColorGradientAttribute() {} // Dummy constructor
		public ColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02060F4D */) {} // 0x000000018B4E055C-0x000000018B4E05A0
	}

	public class NodeMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 49439
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get => default; } // 0x000000018B4E40D8-0x000000018B4E413C 
		public UnityEngine.Color colorRight { get => default; } // 0x000000018B4E413C-0x000000018B4E41A0 
	
		// Constructors
		public NodeMenuItemColorGradientAttribute() {} // Dummy constructor
		public NodeMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02060F51 */) {} // 0x000000018B4E055C-0x000000018B4E05A0
	}

	public class NodeCategoryMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 49440
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get => default; } // 0x000000018B4E4010-0x000000018B4E4074 
		public UnityEngine.Color colorRight { get => default; } // 0x000000018B4E4074-0x000000018B4E40D8 
	
		// Constructors
		public NodeCategoryMenuItemColorGradientAttribute() {} // Dummy constructor
		public NodeCategoryMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02060F55 */) {} // 0x000000018B4E055C-0x000000018B4E05A0
	}

	public class HideAttribute : Attribute // TypeDefIndex: 49441
	{
		// Constructors
		public HideAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class DrawerAttribute : Attribute // TypeDefIndex: 49442
	{
		// Properties
		public virtual int priority { get; } // 0x0000000185FB89A0-0x0000000185FB89B0 
		public virtual bool isDecorator { get; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		protected DrawerAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HeaderAttribute : DrawerAttribute // TypeDefIndex: 49443
	{
		// Fields
		public readonly string title; // 0x10
	
		// Properties
		public override bool isDecorator { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public HeaderAttribute() {} // Dummy constructor
		public HeaderAttribute(string title) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class DimIfDefaultAttribute : DrawerAttribute // TypeDefIndex: 49444
	{
		// Properties
		public override bool isDecorator { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override int priority { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public DimIfDefaultAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ShowIfAttribute : DrawerAttribute // TypeDefIndex: 49445
	{
		// Fields
		public readonly string fieldName; // 0x10
		public readonly int checkValue; // 0x18
	
		// Properties
		public override bool isDecorator { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override int priority { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public ShowIfAttribute() {} // Dummy constructor
		public ShowIfAttribute(string fieldName, int checkValue) {} // 0x00000001845D7850-0x00000001845D7870
	}

	public class RequiredFieldAttribute : DrawerAttribute // TypeDefIndex: 49446
	{
		// Properties
		public override bool isDecorator { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override int priority { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
	
		// Constructors
		public RequiredFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ShowButtonAttribute : DrawerAttribute // TypeDefIndex: 49447
	{
		// Fields
		public readonly string buttonTitle; // 0x10
		public readonly string methodName; // 0x18
	
		// Properties
		public override bool isDecorator { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override int priority { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
	
		// Constructors
		public ShowButtonAttribute() {} // Dummy constructor
		public ShowButtonAttribute(string buttonTitle, string methodnameCallback) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public class CallbackAttribute : DrawerAttribute // TypeDefIndex: 49448
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Properties
		public override bool isDecorator { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override int priority { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
	
		// Constructors
		public CallbackAttribute() {} // Dummy constructor
		public CallbackAttribute(string methodName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class MinValueAttribute : DrawerAttribute // TypeDefIndex: 49449
	{
		// Fields
		public readonly float min; // 0x10
	
		// Properties
		public override int priority { get => default; } // 0x0000000181D27740-0x0000000181D27750 
	
		// Constructors
		public MinValueAttribute() {} // Dummy constructor
		public MinValueAttribute(float min) {} // 0x0000000181A6E380-0x0000000181A6E390
		public MinValueAttribute(int min) {} // 0x0000000185FD2F10-0x0000000185FD2F20
	}

	public class DelayedFieldAttribute : DrawerAttribute // TypeDefIndex: 49450
	{
		// Constructors
		public DelayedFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class LayerFieldAttribute : DrawerAttribute // TypeDefIndex: 49451
	{
		// Constructors
		public LayerFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TagFieldAttribute : DrawerAttribute // TypeDefIndex: 49452
	{
		// Constructors
		public TagFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TextAreaFieldAttribute : DrawerAttribute // TypeDefIndex: 49453
	{
		// Fields
		public readonly int numberOfLines; // 0x10
	
		// Constructors
		public TextAreaFieldAttribute() {} // Dummy constructor
		public TextAreaFieldAttribute(int numberOfLines) {} // 0x0000000181378230-0x0000000181378240
	}

	public class PopupFieldAttribute : DrawerAttribute // TypeDefIndex: 49454
	{
		// Fields
		public readonly object[] options; // 0x10
	
		// Constructors
		public PopupFieldAttribute() {} // Dummy constructor
		public PopupFieldAttribute(object[] options) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class SliderFieldAttribute : DrawerAttribute // TypeDefIndex: 49455
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public SliderFieldAttribute() {} // Dummy constructor
		public SliderFieldAttribute(float min, float max) {} // 0x0000000185FBF890-0x0000000185FBF8A0
		public SliderFieldAttribute(int min, int max) {} // 0x0000000185FD2F20-0x0000000185FD2F40
	}

	public class ForceObjectFieldAttribute : DrawerAttribute // TypeDefIndex: 49456
	{
		// Constructors
		public ForceObjectFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class UndoUtility // TypeDefIndex: 49457
	{
		// Fields
		private static string _lastOperationName_k__BackingField; // 0x00
	
		// Properties
		public static string lastOperationName { get; private set; } // 0x000000018B4E4D20-0x000000018B4E4D58 0x000000018B4E4D58-0x000000018B4E4DA8
	
		// Methods
		public static void RecordObject(UnityEngine.Object target, string name, bool forceIgnoreScene = false /* Metadata: 0x02060F59 */) {} // 0x0000000185492010-0x0000000185492020
		public static void RecordObjectComplete(UnityEngine.Object target, string name, bool forceIgnore = false /* Metadata: 0x02060F5A */) {} // 0x0000000185492010-0x0000000185492020
		public static void SetDirty(UnityEngine.Object target) {} // 0x0000000185492010-0x0000000185492020
		public static void RecordObject(UnityEngine.Object target, string name, Action operation) {} // 0x000000018B4E4D04-0x000000018B4E4D20
		public static void RecordObjectComplete(UnityEngine.Object target, string name, Action operation) {} // 0x000000018B4E4D04-0x000000018B4E4D20
		public static string GetLastOperationNameOr(string operation) => default; // 0x000000018B4E4CD8-0x000000018B4E4D04
		public static void CheckUndo(UnityEngine.Object target, string name) {} // 0x000000018B4E4C30-0x000000018B4E4CD8
		public static void CheckDirty(UnityEngine.Object target) {} // 0x000000018B4E4BF0-0x000000018B4E4C30
	}
}

namespace ParadoxNotion.Serialization
{
	public class DeserializeFromAttribute : Attribute // TypeDefIndex: 49343
	{
		// Fields
		public readonly string previousTypeFullName; // 0x10
	
		// Constructors
		public DeserializeFromAttribute() {} // Dummy constructor
		public DeserializeFromAttribute(string previousTypeFullName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor // TypeDefIndex: 49346
		where TMissing : TCanProcess, IMissingRecoverable
	{
		// Fields
		private const string FIELD_NAME_TYPE = "_missingType"; // Metadata: 0x02060EE3
		private const string FIELD_NAME_STATE = "_recoveryState"; // Metadata: 0x02060EF0
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 49344
		{
			// Fields
			public Dictionary<string, fsData> json;
	
			// Constructors
			public __c__DisplayClass3_0() {}
	
			// Methods
			internal bool _OnBeforeDeserialize_b__0(KeyValuePair<string, fsData> kvp) => default;
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49345
		{
			// Fields
			public static readonly __c<TCanProcess, TMissing> __9;
			public static Func<KeyValuePair<string, fsData>, string> __9__3_1;
			public static Func<KeyValuePair<string, fsData>, fsData> __9__3_2;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal string _OnBeforeDeserialize_b__3_1(KeyValuePair<string, fsData> c) => default;
			internal fsData _OnBeforeDeserialize_b__3_2(KeyValuePair<string, fsData> c) => default;
		}
	
		// Constructors
		public fsRecoveryProcessor() {}
	
		// Methods
		public override bool CanProcess(System.Type type) => default;
		public override void OnBeforeDeserialize(System.Type storageType, ref fsData data) {}
	}

	public class fsUnityObjectConverter : fsConverter // TypeDefIndex: 49347
	{
		// Constructors
		public fsUnityObjectConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4DF9A8-0x000000018B4DFA30
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4DFBA8-0x000000018B4DFD94
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018B4DFA30-0x000000018B4DFBA8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001813AE580-0x00000001813AE590
	}

	public interface IMissingRecoverable // TypeDefIndex: 49348
	{
		// Properties
		string missingType { get; set; }
		string recoveryState { get; set; }
	}

	public interface ISerializedMethodBaseInfo : ISerializedReflectedInfo // TypeDefIndex: 49349
	{
		// Methods
		MethodBase GetMethodBase();
		bool HasChanged();
	}

	public interface ISerializedReflectedInfo : ISerializationCallbackReceiver // TypeDefIndex: 49350
	{
		// Methods
		MemberInfo AsMemberInfo();
		string AsString();
	}

	public static class JSONSerializer // TypeDefIndex: 49351
	{
		// Fields
		public static bool enableCache; // 0x00
		private static object serializerLock; // 0x08
		private static fsSerializer serializer; // 0x10
		private static Dictionary<string, fsData> dataCache; // 0x18
	
		// Constructors
		static JSONSerializer() {} // 0x0000000185663EE0-0x0000000185663F60
	
		// Methods
		public static void FlushMem() {} // 0x0000000185663F60-0x0000000185664090
		private static void __FlushDataCache() {} // 0x0000000185664090-0x0000000185664140
		public static string Serialize(System.Type type, object instance, List<UnityEngine.Object> references = null, bool pretyJson = false /* Metadata: 0x02060EFF */) => default; // 0x000000018B4CEFDC-0x000000018B4CF43C
		public static T Deserialize<T>(string json, List<UnityEngine.Object> references = null) => default;
		public static object Deserialize(System.Type type, string json, List<UnityEngine.Object> references = null) => default; // 0x000000018B4CE6F4-0x000000018B4CE75C
		public static T TryDeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> references = null)
			where T : class => default;
		public static object TryDeserializeOverwrite(object instance, string json, List<UnityEngine.Object> references = null) => default; // 0x000000018B4CF52C-0x000000018B4CF5B8
		private static object Internal_Deserialize(System.Type type, string json, List<UnityEngine.Object> references, object instance) => default; // 0x000000018B4CE75C-0x000000018B4CEBA4
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object, fsData> call) {} // 0x000000018B4CEBC0-0x000000018B4CEDA4
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object> beforeCall, Action<object, fsData> afterCall) {} // 0x000000018B4CEDA4-0x000000018B4CEFDC
		public static T Clone<T>(T original) => default;
		public static object Clone(object original) => default; // 0x000000018B4CE55C-0x000000018B4CE620
		public static void CopySerialized(object source, object target) {} // 0x000000018B4CE620-0x000000018B4CE6F4
		public static void ShowData(string json, string fileName = "" /* Metadata: 0x02060F00 */) {} // 0x000000018B4CF43C-0x000000018B4CF52C
		public static string PrettifyJson(string json) => default; // 0x000000018B4CEBA4-0x000000018B4CEBC0
	}

	[Serializable]
	public sealed class SerializationPair // TypeDefIndex: 49352
	{
		// Fields
		public string _json; // 0x10
		public List<UnityEngine.Object> _references; // 0x18
	
		// Constructors
		public SerializationPair() {} // 0x000000018B4D187C-0x000000018B4D18F4
	}

	[Serializable]
	public class SerializedConstructorInfo : ISerializedMethodBaseInfo // TypeDefIndex: 49355
	{
		// Fields
		private string _baseInfo; // 0x10
		private string _paramsInfo; // 0x18
		[NonSerialized]
		private ConstructorInfo _constructor; // 0x20
		[NonSerialized]
		private bool _hasChanged; // 0x28
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 49353
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, string> __9__4_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4D1CC0-0x000000018B4D1F40
			public __c() {} // 0x000000018B4D19B0-0x000000018B4D1CC0
	
			// Methods
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__4_0(ParameterInfo p) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 49354
		{
			// Fields
			public System.Type[] parameterTypes; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018B4D1F40-0x000000018B4D1F54
	
			// Methods
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__0(ConstructorInfo c) => default; // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		// Constructors
		public SerializedConstructorInfo() {} // 0x000000018B4D18F4-0x000000018B4D19A8
		public SerializedConstructorInfo(ConstructorInfo constructor) {} // 0x000000018B4D19A8-0x000000018B4D19B0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001813B31A0-0x00000001813B31B0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001813B31B0-0x00000001813B31C0
		public MemberInfo AsMemberInfo() => default; // 0x000000018B4D1F54-0x000000018B4D1F64
		public MethodBase GetMethodBase() => default; // 0x000000018B4D5C70-0x000000018B4D5CD4
		public bool HasChanged() => default; // 0x0000000185492010-0x0000000185492020
		public string AsString() => default; // 0x000000018B4D5410-0x000000018B4D5438
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		public static implicit operator ConstructorInfo(SerializedConstructorInfo value) => default; // 0x000000018B4D5AB8-0x000000018B4D5AF4
	}

	[Serializable]
	public class SerializedEventInfo : ISerializedReflectedInfo // TypeDefIndex: 49356
	{
		// Fields
		private string _baseInfo; // 0x10
		[NonSerialized]
		private EventInfo _event; // 0x18
	
		// Constructors
		public SerializedEventInfo() {} // 0x0000000185492010-0x0000000185492020
		public SerializedEventInfo(EventInfo info) {} // 0x0000000184088E70-0x0000000184088E80
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4D20CC-0x000000018B4D2188
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4D1FCC-0x000000018B4D20CC
		public MemberInfo AsMemberInfo() => default; // 0x0000000181377E40-0x0000000181377E50
		public string AsString() => default; // 0x000000018B4D1F64-0x000000018B4D1FC4
		public override string ToString() => default; // 0x000000018B4D1FC4-0x000000018B4D1FCC
		public static implicit operator EventInfo(SerializedEventInfo value) => default; // 0x000000018B4D2188-0x000000018B4D2198
	}

	[Serializable]
	public class SerializedFieldInfo : ISerializedReflectedInfo // TypeDefIndex: 49357
	{
		// Fields
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Reflection.FieldInfo _field; // 0x18
	
		// Constructors
		public SerializedFieldInfo() {} // 0x0000000185492010-0x0000000185492020
		public SerializedFieldInfo(System.Reflection.FieldInfo info) {} // 0x0000000184088E70-0x0000000184088E80
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4D2310-0x000000018B4D23CC
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4D2210-0x000000018B4D2310
		public MemberInfo AsMemberInfo() => default; // 0x0000000181377E40-0x0000000181377E50
		public string AsString() => default; // 0x000000018B4D2198-0x000000018B4D2208
		public override string ToString() => default; // 0x000000018B4D2208-0x000000018B4D2210
		public static implicit operator System.Reflection.FieldInfo(SerializedFieldInfo value) => default; // 0x000000018B4D2188-0x000000018B4D2198
	}

	[Serializable]
	public class SerializedMethodInfo : ISerializedMethodBaseInfo // TypeDefIndex: 49360
	{
		// Fields
		private string _baseInfo; // 0x10
		private string _paramsInfo; // 0x18
		private string _genericArgumentsInfo; // 0x20
		[NonSerialized]
		private MethodInfo _method; // 0x28
		[NonSerialized]
		private bool _hasChanged; // 0x30
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 49358
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, string> __9__5_0; // 0x08
			public static Func<System.Type, string> __9__5_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B4D2A0C-0x000000018B4D2E60
			public __c() {} // 0x000000018B4D2488-0x000000018B4D2A0C
	
			// Methods
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__5_0(ParameterInfo p) => default; // 0x0000000185492010-0x0000000185492020
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__5_1(System.Type a) => default; // 0x000000018B4D2E60-0x000000018B4D2E74
		}
	
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 49359
		{
			// Fields
			public string name; // 0x10
			public System.Type[] parameterTypes; // 0x18
			public bool isSerializedGeneric; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x00000001813B8590-0x00000001813B85A0
	
			// Methods
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__0(MethodInfo m) => default; // 0x00000001813B8590-0x00000001813B85A0
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__1(MethodInfo m) => default; // 0x00000001814294C0-0x00000001814294D0
		}
	
		// Constructors
		public SerializedMethodInfo() {} // 0x000000018B4D2E74-0x000000018B4D2E84
		public SerializedMethodInfo(MethodInfo method) {} // 0x000000018B4D5BA8-0x000000018B4D5C0C
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4D23CC-0x000000018B4D2480
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4D2480-0x000000018B4D2488
		public MemberInfo AsMemberInfo() => default; // 0x0000000185492010-0x0000000185492020
		public MethodBase GetMethodBase() => default; // 0x000000018B4D5410-0x000000018B4D5438
		public bool HasChanged() => default; // 0x000000018B4D5438-0x000000018B4D5458
		public string AsString() => default; // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x000000018B4D5AF4-0x000000018B4D5B74
		public static implicit operator MethodInfo(SerializedMethodInfo value) => default; // 0x000000018B4D5B74-0x000000018B4D5BA8
	}

	[Serializable]
	public class SerializedTypeInfo : ISerializedReflectedInfo // TypeDefIndex: 49361
	{
		// Fields
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Type _type; // 0x18
	
		// Constructors
		public SerializedTypeInfo() {} // 0x0000000185492010-0x0000000185492020
		public SerializedTypeInfo(System.Type info) {} // 0x000000018B40D2E4-0x000000018B40D310
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4D2EEC-0x000000018B4D2F5C
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4D2E84-0x000000018B4D2EEC
		public MemberInfo AsMemberInfo() => default; // 0x0000000181377E40-0x0000000181377E50
		public string AsString() => default; // 0x000000018346D130-0x000000018346D140
		public override string ToString() => default; // 0x000000018346D130-0x000000018346D140
		public static implicit operator System.Type(SerializedTypeInfo value) => default; // 0x000000018B4D2188-0x000000018B4D2198
	}

	[Serializable]
	public class SerializedUnityEventInfo : ISerializedReflectedInfo // TypeDefIndex: 49362
	{
		// Fields
		private string _baseInfo; // 0x10
		[NonSerialized]
		private MemberInfo _memberInfo; // 0x18
	
		// Properties
		public bool isStatic { get => default; } // 0x000000018B4D33AC-0x000000018B4D3484 
		public System.Type memberType { get => default; } // 0x000000018B4D3484-0x000000018B4D3554 
	
		// Constructors
		public SerializedUnityEventInfo() {} // 0x0000000185492010-0x0000000185492020
		public SerializedUnityEventInfo(System.Reflection.FieldInfo info) {} // 0x0000000184088E70-0x0000000184088E80
		public SerializedUnityEventInfo(PropertyInfo info) {} // 0x0000000184088E70-0x0000000184088E80
		public SerializedUnityEventInfo(MemberInfo info) {} // 0x000000018B4D32E0-0x000000018B4D33AC
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018B4D3224-0x000000018B4D32E0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B4D2FD4-0x000000018B4D3224
		public MemberInfo AsMemberInfo() => default; // 0x0000000181377E40-0x0000000181377E50
		public string AsString() => default; // 0x000000018B4D2F5C-0x000000018B4D2FCC
		public override string ToString() => default; // 0x000000018B4D2FCC-0x000000018B4D2FD4
		public static implicit operator System.Reflection.FieldInfo(SerializedUnityEventInfo value) => default; // 0x000000018B4D359C-0x000000018B4D35E4
		public static implicit operator PropertyInfo(SerializedUnityEventInfo value) => default; // 0x000000018B4D3554-0x000000018B4D359C
	}
}

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 49363
	{
		// Fields
		public string MemberName; // 0x10
	
		// Constructors
		public fsForwardAttribute() {} // Dummy constructor
		public fsForwardAttribute(string memberName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class fsWriteOnlyAttribute : Attribute // TypeDefIndex: 49364
	{
		// Constructors
		public fsWriteOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class fsReadOnlyAttribute : Attribute // TypeDefIndex: 49365
	{
		// Constructors
		public fsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 49366
	{
		// Constructors
		public fsIgnoreAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class fsIgnoreInBuildAttribute : Attribute // TypeDefIndex: 49367
	{
		// Constructors
		public fsIgnoreInBuildAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class fsSerializeAsAttribute : Attribute // TypeDefIndex: 49368
	{
		// Fields
		public readonly string Name; // 0x10
	
		// Constructors
		public fsSerializeAsAttribute() {} // 0x0000000185492010-0x0000000185492020
		public fsSerializeAsAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class fsMigrateToAttribute : Attribute // TypeDefIndex: 49369
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public fsMigrateToAttribute() {} // Dummy constructor
		public fsMigrateToAttribute(System.Type targetType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class fsMigrateVersionsAttribute : Attribute // TypeDefIndex: 49370
	{
		// Fields
		public readonly System.Type[] previousTypes; // 0x10
	
		// Constructors
		public fsMigrateVersionsAttribute() {} // Dummy constructor
		public fsMigrateVersionsAttribute(System.Type[] previousTypes) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class fsSerializeAsReference : Attribute // TypeDefIndex: 49371
	{
		// Constructors
		public fsSerializeAsReference() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class fsDeserializeOverwrite : Attribute // TypeDefIndex: 49372
	{
		// Constructors
		public fsDeserializeOverwrite() {} // 0x0000000185492010-0x0000000185492020
	}

	public class fsUninitialized : Attribute // TypeDefIndex: 49373
	{
		// Constructors
		public fsUninitialized() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class fsAutoInstance : Attribute // TypeDefIndex: 49374
	{
		// Fields
		public readonly bool makeInstance; // 0x10
	
		// Constructors
		public fsAutoInstance() {} // Dummy constructor
		public fsAutoInstance(bool makeInstance = true /* Metadata: 0x02060F01 */) {} // 0x000000018184FBD0-0x000000018184FBE0
	}

	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 49375
	{
		// Fields
		public System.Type Converter; // 0x10
		public System.Type Processor; // 0x18
	
		// Constructors
		public fsObjectAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class fsBaseConverter // TypeDefIndex: 49377
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 49376
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsDataType, string> __9__6_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4D61C8-0x000000018B4D6324
			public __c() {} // 0x000000018B4D6664-0x000000018B4D66F4
	
			// Methods
			internal string _FailExpectedType_b__6_0(fsDataType t) => default; // 0x000000018B4D66F4-0x000000018B4D6718
		}
	
		// Constructors
		protected fsBaseConverter() {} // 0x000000018B4D4C84-0x000000018B4D4CD4
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType) => default;
		public virtual bool RequestCycleSupport(System.Type storageType) => default;
		public virtual bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018B4D6324-0x000000018B4D6664
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B4D5FB0-0x000000018B4D61C8
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B4D5D9C-0x000000018B4D5E08
		protected fsResult FailExpectedType(fsData data, fsDataType[] types) => default; // 0x000000018B4D5E08-0x000000018B4D5FB0
		protected fsResult CheckType(fsData data, fsDataType type) => default;
		protected fsResult CheckKey(fsData data, string key, out fsData subitem) {
			subitem = default;
			return default;
		}
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value) => default; // 0x000000018B4D5C0C-0x000000018B4D5C70
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value) {
			value = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 49378
	{
		// Constructors
		protected fsConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public class fsCyclicReferenceManager // TypeDefIndex: 49380
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 49379
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator() {} // 0x000000018B4D67EC-0x000000018B4D67FC
			static ObjectReferenceEqualityComparator() {} // 0x000000018B4D67FC-0x000000018B4D68C8
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000185664EA0-0x0000000185664FA0
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x000000018B4D677C-0x000000018B4D67EC
		}
	
		// Constructors
		public fsCyclicReferenceManager() {} // 0x000000018B4D6970-0x000000018B4D6A60
	
		// Methods
		public void Clear() {} // 0x000000018B4D6718-0x000000018B4D677C
		public bool Enter() => default; // 0x000000018B4D68C8-0x000000018B4D6970
		public bool Exit() => default; // 0x000000018B4D6A60-0x000000018B4D6AD0
		public object GetReferenceObject(int id) => default; // 0x000000018B4D6AD0-0x000000018B4D6C00
		public void AddReferenceWithId(int id, object reference) {} // 0x0000000188F44660-0x0000000188F44668
		public int GetReferenceId(object item) => default; // 0x0000000185FCF280-0x0000000185FCF290
		public bool IsReference(object item) => default; // 0x0000000185492010-0x0000000185492020
		public void MarkSerialized(object item) {} // 0x0000000185F79D50-0x0000000185F79DB0
	}

	public enum fsDataType // TypeDefIndex: 49381
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 49382
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get => default; } // 0x000000018B4D7B8C-0x000000018B4D7CE8 
		public bool IsNull { get => default; } // 0x00000001841C04C0-0x00000001841C04D0 
		public bool IsDouble { get => default; } // 0x000000018B4D7A64-0x000000018B4D7AB0 
		public bool IsInt64 { get => default; } // 0x000000018B4D7AB0-0x000000018B4D7AFC 
		public bool IsBool { get => default; } // 0x000000018B4D79D4-0x000000018B4D7A20 
		public bool IsString { get => default; } // 0x000000018B4D7B40-0x000000018B4D7B8C 
		public bool IsDictionary { get => default; } // 0x000000018B4D7A20-0x000000018B4D7A64 
		public bool IsList { get => default; } // 0x000000018B4D7AFC-0x000000018B4D7B40 
		public double AsDouble { get => default; } // 0x000000018B4D78E4-0x000000018B4D7920 
		public long AsInt64 { get => default; } // 0x000000018B4D7920-0x000000018B4D795C 
		public bool AsBool { get => default; } // 0x000000018B4D786C-0x000000018B4D78A8 
		public string AsString { get => default; } // 0x000000018B4D7998-0x000000018B4D79D4 
		public Dictionary<string, fsData> AsDictionary { get => default; } // 0x000000018B4D78A8-0x000000018B4D78E4 
		public List<fsData> AsList { get => default; } // 0x000000018B4D795C-0x000000018B4D7998 
	
		// Constructors
		public fsData() {} // 0x0000000185633D30-0x0000000185633D50
		public fsData(bool boolean) {} // 0x000000018B4D77B4-0x000000018B4D7810
		public fsData(double f) {} // 0x000000018B4D7810-0x000000018B4D786C
		public fsData(long i) {} // 0x000000018B4D7758-0x000000018B4D77B4
		public fsData(string str) {} // 0x0000000184096E30-0x0000000184096EF0
		public fsData(Dictionary<string, fsData> dict) {} // 0x0000000184096E30-0x0000000184096EF0
		public fsData(List<fsData> list) {} // 0x0000000184096E30-0x0000000184096EF0
		static fsData() {} // 0x000000018B4D764C-0x000000018B4D7758
	
		// Methods
		public static fsData CreateDictionary() => default; // 0x000000018B4D6D10-0x000000018B4D6E04
		public static fsData CreateList() => default; // 0x000000018B4D6E04-0x000000018B4D6E9C
		public static fsData CreateList(int capacity) => default; // 0x000000018B4D6E9C-0x000000018B4D6F38
		internal void BecomeDictionary() {} // 0x000000018B4D6C00-0x000000018B4D6CA4
		internal fsData Clone() => default; // 0x000000018B4D6CA4-0x000000018B4D6D10
		private T Cast<T>() => default;
		public override string ToString() => default; // 0x000000018B4D7644-0x000000018B4D764C
		public override bool Equals(object obj) => default; // 0x000000018B4D6F38-0x000000018B4D6F9C
		public bool Equals(fsData other) => default; // 0x000000018B4D6F9C-0x000000018B4D7644
		public static bool operator ==(fsData a, fsData b) => default; // 0x000000018B4D7CE8-0x000000018B4D7DB8
		public static bool operator !=(fsData a, fsData b) => default; // 0x000000018B4D7DB8-0x000000018B4D7E0C
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 49383
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 49384
	{
		// Properties
		public override System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter() {}
	
		// Methods
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		}
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default;
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref ref TModel model);
	}

	public static class fsGlobalConfig // TypeDefIndex: 49385
	{
		// Fields
		public static bool SerializeDefaultValues; // 0x00
		public static bool IsCaseSensitive; // 0x01
		public static System.Type[] IgnoreSerializeAttributes; // 0x08
		public static System.Type[] SerializeAttributes; // 0x10
		public static string CustomDateTimeFormatString; // 0x18
		public static bool Serialize64BitIntegerAsString; // 0x20
		public static bool SerializeEnumsAsInteger; // 0x21
	
		// Constructors
		static fsGlobalConfig() {} // 0x000000018B4D7E0C-0x000000018B4D8044
	}

	public class fsJsonParser // TypeDefIndex: 49386
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		public fsJsonParser() {} // Dummy constructor
		private fsJsonParser(string input) {} // 0x000000018B4DA000-0x000000018B4DA08C
	
		// Methods
		private fsResult MakeFailure(string message) => default; // 0x000000018B4D8140-0x000000018B4D82CC
		private bool TryMoveNext() => default; // 0x000000018B4D8A10-0x000000018B4D8A3C
		private bool HasValue() => default; // 0x000000018B4D80B0-0x000000018B4D80BC
		private bool HasValue(int offset) => default; // 0x000000018B4D807C-0x000000018B4D80B0
		private char Character() => default; // 0x000000018B4D8044-0x000000018B4D8050
		private char Character(int offset) => default; // 0x000000018B4D8050-0x000000018B4D807C
		private void SkipSpace() {} // 0x000000018B4D8834-0x000000018B4D8A10
		private bool IsHex(char c) => default; // 0x000000018B4D80BC-0x000000018B4D80E4
		private uint ParseSingleChar(char c1, uint multipliyer) => default; // 0x000000018B4D82CC-0x000000018B4D8310
		private uint ParseUnicode(char c1, char c2, char c3, char c4) => default; // 0x000000018B4D8310-0x000000018B4D8394
		private fsResult TryUnescapeChar(out char escaped) {
			escaped = default;
			return default;
		} // 0x000000018B4D9B08-0x000000018B4DA000
		private fsResult TryParseExact(string content) => default; // 0x000000018B4D8CF4-0x000000018B4D8E38
		private fsResult TryParseTrue(out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4D9A08-0x000000018B4D9B08
		private fsResult TryParseFalse(out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4D8E38-0x000000018B4D8F38
		private fsResult TryParseNull(out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4D8F38-0x000000018B4D9034
		private bool IsSeparator(char c) => default; // 0x000000018B4D80E4-0x000000018B4D8140
		private fsResult TryParseNumber(out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4D9034-0x000000018B4D9348
		private fsResult TryParseString(out string str) {
			str = default;
			return default;
		} // 0x000000018B4D9750-0x000000018B4D9A08
		private fsResult TryParseArray(out fsData arr) {
			arr = default;
			return default;
		} // 0x000000018B4D8A3C-0x000000018B4D8CF4
		private fsResult TryParseObject(out fsData obj) {
			obj = default;
			return default;
		} // 0x000000018B4D9348-0x000000018B4D9750
		private fsResult RunParse(out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4D84F0-0x000000018B4D8834
		public static fsResult Parse(string input, out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4D8408-0x000000018B4D84F0
		public static fsData Parse(string input) => default; // 0x000000018B4D8394-0x000000018B4D8408
	}

	public static class fsJsonPrinter // TypeDefIndex: 49387
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count) {} // 0x000000018B4DB304-0x000000018B4DB370
		private static string EscapeString(string str) => default; // 0x000000018B4DB044-0x000000018B4DB304
		private static void BuildCompressedString(fsData data, TextWriter stream) {} // 0x000000018B4DA08C-0x000000018B4DA664
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth) {} // 0x000000018B4DA664-0x000000018B4DADA4
		public static string ToJson(fsData data, bool pretty) => default; // 0x000000018B4DB4DC-0x000000018B4DB500
		public static void PrettyJson(fsData data, TextWriter outputStream) {} // 0x000000018B4DB370-0x000000018B4DB37C
		public static string PrettyJson(fsData data) => default; // 0x000000018B4DB37C-0x000000018B4DB4DC
		public static void CompressedJson(fsData data, StreamWriter outputStream) {} // 0x000000018B4DAF00-0x000000018B4DAF08
		public static string CompressedJson(fsData data) => default; // 0x000000018B4DADA4-0x000000018B4DAF00
		private static string ConvertDoubleToString(double d) => default; // 0x000000018B4DAF08-0x000000018B4DB044
	}

	public class fsMetaProperty // TypeDefIndex: 49388
	{
		// Fields
		private System.Reflection.FieldInfo _Field_k__BackingField; // 0x10
		private string _JsonName_k__BackingField; // 0x18
		private bool _ReadOnly_k__BackingField; // 0x20
		private bool _WriteOnly_k__BackingField; // 0x21
		private bool _AutoInstance_k__BackingField; // 0x22
		private bool _AsReference_k__BackingField; // 0x23
	
		// Properties
		public System.Reflection.FieldInfo Field { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string JsonName { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public System.Type StorageType { get => default; } // 0x000000018B2DDE9C-0x000000018B2DDEC0 
		public string MemberName { get => default; } // 0x000000018B4DB6A0-0x000000018B4DB6C4 
		public bool ReadOnly { get; private set; } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public bool WriteOnly { get; private set; } // 0x00000001813ECBD0-0x00000001813ECBE0 0x00000001813EE990-0x00000001813EE9A0
		public bool AutoInstance { get; private set; } // 0x00000001813FF330-0x00000001813FF340 0x00000001813FF340-0x00000001813FF350
		public bool AsReference { get; private set; } // 0x0000000185FB8A60-0x0000000185FB8A70 0x0000000185FB8A80-0x0000000185FB8A90
	
		// Constructors
		public fsMetaProperty() {} // Dummy constructor
		internal fsMetaProperty(System.Reflection.FieldInfo field) {} // 0x000000018B4DB500-0x000000018B4DB6A0
	
		// Methods
		public object Read(object context) => default; // 0x00000001898F8348-0x00000001898F836C
		public void Write(object context, object value) {} // 0x00000001889B21BC-0x00000001889B21DC
	}

	public class fsMetaType // TypeDefIndex: 49392
	{
		// Fields
		private static Dictionary<System.Type, fsMetaType> _metaTypes; // 0x00
		private static Dictionary<System.Type, object> _defaultInstances; // 0x08
		private ObjectGenerator generator; // 0x10
		private System.Type _reflectedType_k__BackingField; // 0x18
		private fsMetaProperty[] _Properties_k__BackingField; // 0x20
		private bool _DeserializeOverwriteRequest_k__BackingField; // 0x28
	
		// Properties
		public System.Type reflectedType { get; private set; } // 0x0000000185664250-0x0000000185664340 0x000000018907057C-0x0000000189070640
		public fsMetaProperty[] Properties { get; private set; } // 0x0000000183683B30-0x0000000183683B40 0x00000001864BC2FC-0x00000001864BC320
		public bool DeserializeOverwriteRequest { get; private set; } // 0x00000001864750A8-0x00000001864751CC 0x0000000185492010-0x0000000185492020
	
		// Nested types
		private delegate object ObjectGenerator(); // TypeDefIndex: 49389; 0x0000000185664140-0x0000000185664250
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 49390
		{
			// Fields
			public System.Type reflectedType; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal object _GetGenerator_b__0() => default; // 0x000000018646EE40-0x000000018646EE50
			internal object _GetGenerator_b__1() => default; // 0x00000001813B31B0-0x00000001813B31C0
			internal object _GetGenerator_b__2() => default; // 0x00000001813B4840-0x00000001813B4850
			internal object _GetGenerator_b__4() => default; // 0x000000018B4DC16C-0x000000018B4DC254
			internal object _GetGenerator_b__5() => default; // 0x000000018B4DB914-0x000000018B4DBAB4
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49391
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ObjectGenerator __9__21_3; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4DB6C4-0x000000018B4DB914
			public __c() {} // 0x000000018B4DBC6C-0x000000018B4DBFDC
	
			// Methods
			internal object _GetGenerator_b__21_3() => default; // 0x000000018B4DC0D4-0x000000018B4DC16C
		}
	
		// Constructors
		public fsMetaType() {} // Dummy constructor
		private fsMetaType(System.Type reflectedType) {} // 0x000000018B4D5458-0x000000018B4D54F0
		static fsMetaType() {} // 0x000000018B4D4D40-0x000000018B4D4D78
	
		// Methods
		public static fsMetaType Get(System.Type type) => default; // 0x000000018B4DBB78-0x000000018B4DBC6C
		public static void FlushMem() {} // 0x000000018B4DBAB4-0x000000018B4DBB78
		private static void CollectProperties(List<fsMetaProperty> properties, System.Type reflectedType) {} // 0x000000018B4D54F0-0x000000018B4D5500
		public static bool CanSerializeField(System.Reflection.FieldInfo field) => default; // 0x000000018B4D5500-0x000000018B4D5530
		private static ObjectGenerator GetGenerator(System.Type reflectedType) => default; // 0x000000018B4D5530-0x000000018B4D5580
		private static bool HasDefaultConstructor(System.Type reflectedType) => default; // 0x000000018B4D5580-0x000000018B4D5604
		public object GetDefaultInstance() => default; // 0x000000018B4D5D38-0x000000018B4D5D9C
		public object CreateInstance() => default; // 0x0000000185492010-0x0000000185492020
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 49393
	{
		// Constructors
		protected fsObjectProcessor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual bool CanProcess(System.Type type) => default; // 0x000000018B4DC254-0x000000018B4DC2A0
		public virtual void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000185492010-0x0000000185492020
	}

	public struct fsResult // TypeDefIndex: 49394
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get => default; } // 0x000000018A1D97C0-0x000000018A1D97C8 
		public bool Succeeded { get => default; } // 0x00000001835E3010-0x00000001835E3020 
		public bool HasWarnings { get => default; } // 0x000000018B4DCA78-0x000000018B4DCAC4 
		public Exception AsException { get => default; } // 0x000000018B4DC880-0x000000018B4DC998 
		public IEnumerable<string> RawMessages { get => default; } // 0x000000018B4DCAC4-0x000000018B4DCB1C 
		public string FormattedMessages { get => default; } // 0x000000018B4DC998-0x000000018B4DCA78 
	
		// Constructors
		static fsResult() {
			EmptyStringArray = default;
			Success = default;
		} // 0x000000018B4DC7E0-0x000000018B4DC880
	
		// Methods
		public static fsResult Warn(string warning) => default; // 0x000000018B4DC730-0x000000018B4DC7E0
		public static fsResult Fail(string warning) => default; // 0x000000018B4DC554-0x000000018B4DC600
		public void AddMessage(string message) {} // 0x000000018B4DC2A0-0x000000018B4DC350
		public void AddMessages(fsResult result) {} // 0x000000018B4DC350-0x000000018B4DC408
		private fsResult Merge(fsResult other) => default; // 0x000000018B4DC600-0x000000018B4DC6E4
		public static fsResult operator +(fsResult a, fsResult b) => default; // 0x000000018B4DCB1C-0x000000018B4DCB94
		public fsResult AssertSuccess() => default; // 0x000000018B4DC4C8-0x000000018B4DC554
		public fsResult AssertSuccessWithoutWarnings() => default; // 0x000000018B4DC408-0x000000018B4DC4C8
		public override string ToString() => default; // 0x000000018B4DC6E4-0x000000018B4DC730
	}

	public class fsSerializer // TypeDefIndex: 49397
	{
		// Fields
		public const string KEY_OBJECT_REFERENCE = "$ref"; // Metadata: 0x02060F09
		public const string KEY_OBJECT_DEFINITION = "$id"; // Metadata: 0x02060F0E
		public const string KEY_INSTANCE_TYPE = "$type"; // Metadata: 0x02060F12
		public const string KEY_VERSION = "$version"; // Metadata: 0x02060F18
		public const string KEY_CONTENT = "$content"; // Metadata: 0x02060F21
		private Dictionary<System.Type, fsBaseConverter> _cachedOverrideConverterInstances; // 0x10
		private Dictionary<System.Type, fsBaseConverter> _cachedConverters; // 0x18
		private readonly List<fsConverter> _availableConverters; // 0x20
		private readonly Dictionary<System.Type, fsDirectConverter> _availableDirectConverters; // 0x28
		private readonly List<fsObjectProcessor> _processors; // 0x30
		private Dictionary<System.Type, List<fsObjectProcessor>> _cachedProcessors; // 0x38
		private fsCyclicReferenceManager _references; // 0x40
		private fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x48
		private Stack<ISerializationCollector> _collectors; // 0x50
		private int _collectableDepth; // 0x58
		private List<UnityEngine.Object> _ReferencesDatabase_k__BackingField; // 0x60
		private bool _IgnoreSerializeCycleReferences_k__BackingField; // 0x68
		private Action<object> onBeforeObjectSerialized; // 0x70
		private Action<object, fsData> onAfterObjectSerialized; // 0x78
	
		// Properties
		public List<UnityEngine.Object> ReferencesDatabase { get; set; } // 0x000000018B4DF890-0x000000018B4DF91C 0x0000000185664340-0x0000000185664A90
		public bool IgnoreSerializeCycleReferences { get; set; } // 0x000000018B4DE3C4-0x000000018B4DE42C 0x000000018B4DCF9C-0x000000018B4DD220
	
		// Events
		public event Action<object> onBeforeObjectSerialized;
		public event Action<object, fsData> onAfterObjectSerialized;
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 49395
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter() {} // 0x000000018B4DE104-0x000000018B4DE180
	
			// Methods
			public void WriteDefinition(int id, fsData data) {} // 0x000000018B4DE180-0x000000018B4DE250
			public void WriteReference(int id, Dictionary<string, fsData> dict) {} // 0x000000018B4DE42C-0x000000018B4DE598
			public void Clear() {} // 0x000000018B4DCB94-0x000000018B4DCC3C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 49396
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__58_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B4DE088-0x000000018B4DE104
			public __c() {} // 0x000000018B4DE2CC-0x000000018B4DE348
	
			// Methods
			internal bool _TryDeserializeMigration_b__58_0(MethodInfo m) => default; // 0x000000018B4DE250-0x000000018B4DE2CC
		}
	
		// Constructors
		public fsSerializer() {} // 0x000000018B4DD958-0x000000018B4DDCD4
	
		// Methods
		public static bool IsReservedKeyword(string key) => default; // 0x000000018B4DE348-0x000000018B4DE3C4
		public static void RemoveMetaData(ref fsData data) {} // 0x000000018B4DDFA0-0x000000018B4DE088
		private static void EnsureDictionary(ref fsData data) {} // 0x000000018B4DDDBC-0x000000018B4DDE28
		private static bool IsObjectReference(fsData data) => default; // 0x000000018B4DDEE8-0x000000018B4DDFA0
		private static bool IsObjectDefinition(fsData data) => default; // 0x000000018B4DDE28-0x000000018B4DDEE8
		private static bool IsVersioned(fsData data) => default; // 0x000000018B4DDCD4-0x000000018B4DDDBC
		private static bool IsTypeSpecified(fsData data) => default; // 0x0000000185FB0530-0x0000000185FB0540
		private static bool IsWrappedData(fsData data) => default; // 0x0000000185AE8FE0-0x0000000185AE8FF0
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000185FB09E0-0x0000000185FB09F0
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000185FB0A20-0x0000000185FB0A30
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data) {} // 0x000000018B4DF804-0x000000018B4DF890
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x000000018B4DF91C-0x000000018B4DF9A8
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x000000018B4DF778-0x000000018B4DF804
		public void PurgeTemporaryData() {} // 0x000000018B4DEDD4-0x000000018B4DEE10
		private List<fsObjectProcessor> GetProcessors(System.Type type) => default; // 0x000000018B4DEE10-0x000000018B4DEFD8
		public void AddConverter(fsBaseConverter converter) {} // 0x000000018B4DD220-0x000000018B4DD958
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) => default; // 0x000000018B4DF118-0x000000018B4DF34C
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018B4DEFD8-0x000000018B4DF118
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType) {
			data = default;
			return default;
		} // 0x000000018B4DF34C-0x000000018B4DF4AC
		private fsResult Internal_Serialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType) {
			data = default;
			return default;
		} // 0x000000018B4DEC58-0x000000018B4DEDD4
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result) => default; // 0x000000018B4DE598-0x000000018B4DEC58
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType) => default; // 0x000000018B4E7BE4-0x000000018B4E7D18
		private fsResult Internal_Deserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType) => default; // 0x000000018B4E7D18-0x000000018B4E7EDC
		private void TryPush(object o) {} // 0x000000018B4E7B7C-0x000000018B4E7BE4
		private void TryPop(object o) {} // 0x0000000185664DE0-0x0000000185664EA0
		private void TrySerializeVersioning(object currentInstance, ref fsData data) {} // 0x000000018B4E4B8C-0x000000018B4E4BF0
		private void TryDeserializeVersioning(ref object currentInstance, ref fsData currentData) {} // 0x0000000185492010-0x0000000185492020
		private void TryDeserializeMigration(ref object currentInstance, ref fsData currentData, System.Type previousType, object previousInstance) {} // 0x000000018B4E4B38-0x000000018B4E4B8C
	}

	public interface IMigratable // TypeDefIndex: 49398
	{
	}

	public interface IMigratable<T> : IMigratable // TypeDefIndex: 49399
	{
		// Methods
		void Migrate(T model);
	}

	public interface ISerializationCollector : ISerializationCollectable // TypeDefIndex: 49400
	{
		// Methods
		void OnPush(ISerializationCollector parent);
		void OnCollect(ISerializationCollectable child, int depth);
		void OnPop(ISerializationCollector parent);
	}

	public interface ISerializationCollectable // TypeDefIndex: 49401
	{
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 49402
	{
		// Constructors
		public fsArrayConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E5844-0x000000018B4E5864
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E5B24-0x000000018B4E5D00
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018B4E58BC-0x000000018B4E5B24
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E5864-0x000000018B4E58BC
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 49403
	{
		// Constructors
		public fsDictionaryConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E5D00-0x000000018B4E5D94
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E5D94-0x000000018B4E5DEC
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E65EC-0x000000018B4E6B54
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x000000018B4E5DEC-0x000000018B4E65EC
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 49404
	{
		// Constructors
		public fsEnumConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E6B54-0x000000018B4E6B74
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E6B74-0x000000018B4E6BE8
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E6F3C-0x000000018B4E75D8
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018B4E6BE8-0x000000018B4E6F3C
		private static bool ArrayContains<T>(T[] values, T value) => default;
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 49405
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter() {} // Dummy constructor
		public fsForwardConverter(fsForwardAttribute attribute) {} // 0x000000018B4E7B58-0x000000018B4E7B7C
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E75D8-0x000000018B4E7634
		private fsResult GetProperty(object instance, out fsMetaProperty property) {
			property = default;
			return default;
		} // 0x000000018B4E768C-0x000000018B4E7860
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E79EC-0x000000018B4E7B58
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018B4E7860-0x000000018B4E79EC
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E7634-0x000000018B4E768C
	}

	public class fsListConverter : fsConverter // TypeDefIndex: 49406
	{
		// Constructors
		public fsListConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E7EDC-0x000000018B4E7F70
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E7F70-0x000000018B4E7FC8
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E83AC-0x000000018B4E8628
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x000000018B4E7FC8-0x000000018B4E83AC
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 49407
	{
		// Constructors
		public fsPrimitiveConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E8628-0x000000018B4E86D8
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		private static bool UseBool(System.Type type) => default; // 0x000000018B4E92B8-0x000000018B4E931C
		private static bool UseInt64(System.Type type) => default; // 0x000000018B4E93E0-0x000000018B4E959C
		private static bool UseDouble(System.Type type) => default; // 0x000000018B4E931C-0x000000018B4E93E0
		private static bool UseString(System.Type type) => default; // 0x000000018B4E959C-0x000000018B4E9634
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E8D04-0x000000018B4E92B8
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x000000018B4E86D8-0x000000018B4E8D04
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 49408
	{
		// Constructors
		public fsReflectedConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E9634-0x000000018B4E96C8
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E9AA8-0x000000018B4E9DE8
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018B4E9720-0x000000018B4E9AA8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E96C8-0x000000018B4E9720
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 49409
	{
		// Constructors
		public fsTypeConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E9DE8-0x000000018B4E9E60
		public override bool RequestCycleSupport(System.Type type) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type type) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018B4E9FA8-0x000000018B4EAD6C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018B4E9E60-0x000000018B4E9FA8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 49410
	{
		// Constructors
		public AnimationCurve_DirectConverter() {} // 0x0000000185664BD0-0x0000000185664C00
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E001C-0x000000018B4E01F0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model) => default; // 0x000000018B4DFDE4-0x000000018B4E001C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4DFD94-0x000000018B4DFDE4
	}

	public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 49411
	{
		// Constructors
		public Bounds_DirectConverter() {} // 0x0000000185664C00-0x0000000185664C30
	
		// Methods
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E03E8-0x000000018B4E055C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model) => default; // 0x000000018B4E0244-0x000000018B4E03E8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E01F0-0x000000018B4E0244
	}

	public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 49412
	{
		// Constructors
		public Gradient_DirectConverter() {} // 0x0000000185664C90-0x0000000185664CC0
	
		// Methods
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E35D8-0x000000018B4E3764
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model) => default; // 0x000000018B4E3410-0x000000018B4E35D8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E33C0-0x000000018B4E3410
	}

	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState> // TypeDefIndex: 49413
	{
		// Constructors
		public GUIStyleState_DirectConverter() {} // 0x0000000185664C30-0x0000000185664C60
	
		// Methods
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E1840-0x000000018B4E19DC
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model) => default; // 0x000000018B4E1660-0x000000018B4E1840
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E1610-0x000000018B4E1660
	}

	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 49414
	{
		// Constructors
		public GUIStyle_DirectConverter() {} // 0x0000000185664C60-0x0000000185664C90
	
		// Methods
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E28FC-0x000000018B4E33C0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model) => default; // 0x000000018B4E1A2C-0x000000018B4E28FC
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E19DC-0x000000018B4E1A2C
	}

	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 49415
	{
		// Constructors
		public Keyframe_DirectConverter() {} // 0x0000000185664CC0-0x0000000185664CF0
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E3B90-0x000000018B4E3DE4
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model) => default; // 0x000000018B4E38F8-0x000000018B4E3B90
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E38A0-0x000000018B4E38F8
	}

	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 49416
	{
		// Constructors
		public LayerMask_DirectConverter() {} // 0x0000000185664CF0-0x0000000185664D20
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E3F28-0x000000018B4E4010
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model) => default; // 0x000000018B4E3E24-0x000000018B4E3F28
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E3DE4-0x000000018B4E3E24
	}

	public class RectOffset_DirectConverter : fsDirectConverter<RectOffset> // TypeDefIndex: 49417
	{
		// Constructors
		public RectOffset_DirectConverter() {} // 0x0000000185664D20-0x0000000185664D50
	
		// Methods
		protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E448C-0x000000018B4E469C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model) => default; // 0x000000018B4E41F0-0x000000018B4E448C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E41A0-0x000000018B4E41F0
	}

	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 49418
	{
		// Constructors
		public Rect_DirectConverter() {} // 0x0000000185664D50-0x0000000185664D80
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E4938-0x000000018B4E4B38
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model) => default; // 0x000000018B4E46DC-0x000000018B4E4938
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E469C-0x000000018B4E46DC
	}

	public class Vector2Int_DirectConverter : fsDirectConverter<Vector2Int> // TypeDefIndex: 49419
	{
		// Constructors
		public Vector2Int_DirectConverter() {} // 0x0000000185664D80-0x0000000185664DB0
	
		// Methods
		protected override fsResult DoSerialize(Vector2Int model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E4EEC-0x000000018B4E4FD0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2Int model) => default; // 0x000000018B4E4DE8-0x000000018B4E4EEC
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E4DA8-0x000000018B4E4DE8
	}

	public class Vector2_DirectConverter : fsDirectConverter<Vector2> // TypeDefIndex: 49420
	{
		// Constructors
		public Vector2_DirectConverter() {} // 0x000000018B4E5214-0x000000018B4E523C
	
		// Methods
		protected override fsResult DoSerialize(Vector2 model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E5130-0x000000018B4E5214
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2 model) => default; // 0x000000018B4E501C-0x000000018B4E5130
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E4FD0-0x000000018B4E501C
	}

	public class Vector3Int_DirectConverter : fsDirectConverter<Vector3Int> // TypeDefIndex: 49421
	{
		// Constructors
		public Vector3Int_DirectConverter() {} // 0x0000000185664DB0-0x0000000185664DE0
	
		// Methods
		protected override fsResult DoSerialize(Vector3Int model, Dictionary<string, fsData> serialized) => default; // 0x000000018B4E53C4-0x000000018B4E54D4
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector3Int model) => default; // 0x000000018B4E528C-0x000000018B4E53C4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018B4E523C-0x000000018B4E528C
	}
}

namespace ParadoxNotion.Services
{
	public class EventRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IDropHandler // TypeDefIndex: 49326
	{
		// Fields
		private EventRouterAnimatorMove _routerAnimatorMove; // 0x18
		private EventDelegate<PointerEventData> onPointerEnter; // 0x20
		private EventDelegate<PointerEventData> onPointerExit; // 0x28
		private EventDelegate<PointerEventData> onPointerDown; // 0x30
		private EventDelegate<PointerEventData> onPointerUp; // 0x38
		private EventDelegate<PointerEventData> onPointerClick; // 0x40
		private EventDelegate<PointerEventData> onDrag; // 0x48
		private EventDelegate<PointerEventData> onDrop; // 0x50
		private EventDelegate<PointerEventData> onScroll; // 0x58
		private EventDelegate<BaseEventData> onUpdateSelected; // 0x60
		private EventDelegate<BaseEventData> onSelect; // 0x68
		private EventDelegate<BaseEventData> onDeselect; // 0x70
		private EventDelegate<AxisEventData> onMove; // 0x78
		private EventDelegate<BaseEventData> onSubmit; // 0x80
		private EventDelegate onMouseDown; // 0x88
		private EventDelegate onMouseDrag; // 0x90
		private EventDelegate onMouseEnter; // 0x98
		private EventDelegate onMouseExit; // 0xA0
		private EventDelegate onMouseOver; // 0xA8
		private EventDelegate onMouseUp; // 0xB0
		private EventDelegate onEnable; // 0xB8
		private EventDelegate onDisable; // 0xC0
		private EventDelegate onDestroy; // 0xC8
		private EventDelegate onTransformChildrenChanged; // 0xD0
		private EventDelegate onTransformParentChanged; // 0xD8
		private EventDelegate<int> onAnimatorIK; // 0xE0
		private EventDelegate onBecameInvisible; // 0xE8
		private EventDelegate onBecameVisible; // 0xF0
		private EventDelegate<ControllerColliderHit> onControllerColliderHit; // 0xF8
		private EventDelegate<GameObject> onParticleCollision; // 0x100
		private EventDelegate<UnityEngine.Collision> onCollisionEnter; // 0x108
		private EventDelegate<UnityEngine.Collision> onCollisionExit; // 0x110
		private EventDelegate<UnityEngine.Collision> onCollisionStay; // 0x118
		private EventDelegate<Collision2D> onCollisionEnter2D; // 0x120
		private EventDelegate<Collision2D> onCollisionExit2D; // 0x128
		private EventDelegate<Collision2D> onCollisionStay2D; // 0x130
		private EventDelegate<Collider> onTriggerEnter; // 0x138
		private EventDelegate<Collider> onTriggerExit; // 0x140
		private EventDelegate<Collider> onTriggerStay; // 0x148
		private EventDelegate<Collider2D> onTriggerEnter2D; // 0x150
		private EventDelegate<Collider2D> onTriggerExit2D; // 0x158
		private EventDelegate<Collider2D> onTriggerStay2D; // 0x160
		private Action<RenderTexture, RenderTexture> onRenderImage; // 0x168
		private EventDelegate onDrawGizmos; // 0x170
		private CustomEventDelegate onCustomEvent; // 0x178
	
		// Events
		public event EventDelegate<PointerEventData> onPointerEnter;
		public event EventDelegate<PointerEventData> onPointerExit;
		public event EventDelegate<PointerEventData> onPointerDown;
		public event EventDelegate<PointerEventData> onPointerUp;
		public event EventDelegate<PointerEventData> onPointerClick;
		public event EventDelegate<PointerEventData> onDrag;
		public event EventDelegate<PointerEventData> onDrop;
		public event EventDelegate<PointerEventData> onScroll;
		public event EventDelegate<BaseEventData> onUpdateSelected;
		public event EventDelegate<BaseEventData> onSelect;
		public event EventDelegate<BaseEventData> onDeselect;
		public event EventDelegate<AxisEventData> onMove;
		public event EventDelegate<BaseEventData> onSubmit;
		public event EventDelegate onMouseDown;
		public event EventDelegate onMouseDrag;
		public event EventDelegate onMouseEnter;
		public event EventDelegate onMouseExit;
		public event EventDelegate onMouseOver;
		public event EventDelegate onMouseUp;
		public event EventDelegate onEnable;
		public event EventDelegate onDisable;
		public event EventDelegate onDestroy;
		public event EventDelegate onTransformChildrenChanged;
		public event EventDelegate onTransformParentChanged;
		public event EventDelegate<int> onAnimatorIK;
		public event EventDelegate onAnimatorMove;
		public event EventDelegate onBecameInvisible;
		public event EventDelegate onBecameVisible;
		public event EventDelegate<ControllerColliderHit> onControllerColliderHit;
		public event EventDelegate<GameObject> onParticleCollision;
		public event EventDelegate<UnityEngine.Collision> onCollisionEnter;
		public event EventDelegate<UnityEngine.Collision> onCollisionExit;
		public event EventDelegate<UnityEngine.Collision> onCollisionStay;
		public event EventDelegate<Collision2D> onCollisionEnter2D;
		public event EventDelegate<Collision2D> onCollisionExit2D;
		public event EventDelegate<Collision2D> onCollisionStay2D;
		public event EventDelegate<Collider> onTriggerEnter;
		public event EventDelegate<Collider> onTriggerExit;
		public event EventDelegate<Collider> onTriggerStay;
		public event EventDelegate<Collider2D> onTriggerEnter2D;
		public event EventDelegate<Collider2D> onTriggerExit2D;
		public event EventDelegate<Collider2D> onTriggerStay2D;
		public event Action<RenderTexture, RenderTexture> onRenderImage;
		public event EventDelegate onDrawGizmos;
		public event CustomEventDelegate onCustomEvent;
	
		// Nested types
		public delegate void EventDelegate(ParadoxNotion.EventData msg); // TypeDefIndex: 49323; 0x000000018B4CD964-0x000000018B4CD9F0
	
		public delegate void EventDelegate<T>(EventData<T> msg); // TypeDefIndex: 49324; 0x000000018B4CD8D8-0x000000018B4CD964
	
		public delegate void CustomEventDelegate(string name, ParadoxNotion.IEventData data); // TypeDefIndex: 49325; 0x000000018B4CD84C-0x000000018B4CD8D8
	
		// Constructors
		public EventRouter() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {} // 0x000000018B4CADB0-0x000000018B4CAE6C
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {} // 0x000000018B4CBA1C-0x000000018B4CBAB4
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {} // 0x000000018B4CD3A0-0x000000018B4CD438
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {} // 0x000000018B4CBAB4-0x000000018B4CBB4C
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x000000018B4CD438-0x000000018B4CD4D0
		void IDragHandler.OnDrag(PointerEventData eventData) {} // 0x000000018B4CBB4C-0x000000018B4CBBE4
		void IDropHandler.OnDrop(PointerEventData eventData) {} // 0x000000018B4CD4D0-0x000000018B4CD568
		void IScrollHandler.OnScroll(PointerEventData eventData) {} // 0x000000018B4CBBE4-0x000000018B4CBC7C
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData) {} // 0x000000018B4CD568-0x000000018B4CD600
		void ISelectHandler.OnSelect(BaseEventData eventData) {} // 0x000000018B4CBC7C-0x000000018B4CBD14
		void IDeselectHandler.OnDeselect(BaseEventData eventData) {} // 0x000000018B4CD600-0x000000018B4CD698
		void IMoveHandler.OnMove(AxisEventData eventData) {} // 0x000000018B4CBD14-0x000000018B4CBDAC
		void ISubmitHandler.OnSubmit(BaseEventData eventData) {} // 0x000000018B4CD698-0x000000018B4CD730
		private void OnMouseDown() {} // 0x000000018B4C9C2C-0x000000018B4C9CAC
		private void OnMouseDrag() {} // 0x000000018B4C9B2C-0x000000018B4C9BAC
		private void OnMouseEnter() {} // 0x000000018B4C9AAC-0x000000018B4C9B2C
		private void OnMouseExit() {} // 0x000000018B4CC3BC-0x000000018B4CC454
		private void OnMouseOver() {} // 0x000000018B4CDD40-0x000000018B4CDDD8
		private void OnMouseUp() {} // 0x000000018B4CC454-0x000000018B4CC4EC
		private void OnEnable() {} // 0x000000018B4CC968-0x000000018B4CC9E4
		private void OnDisable() {} // 0x000000018B4C93C8-0x000000018B4C9484
		private void OnDestroy() {} // 0x000000018B4CB060-0x000000018B4CB0F8
		private void OnTransformChildrenChanged() {} // 0x000000018B4C9504-0x000000018B4C9584
		private void OnTransformParentChanged() {} // 0x000000018B4CB4F0-0x000000018B4CB580
		private void OnAnimatorIK(int layerIndex) {} // 0x000000018B4C9FAC-0x000000018B4CA06C
		private void OnBecameInvisible() {} // 0x000000018B4CB460-0x000000018B4CB4F0
		private void OnBecameVisible() {} // 0x000000018B4CCDE4-0x000000018B4CCE74
		private void OnControllerColliderHit(ControllerColliderHit hit) {} // 0x000000018B4CCB14-0x000000018B4CCBA4
		private void OnParticleCollision(GameObject other) {} // 0x000000018B4CB2B0-0x000000018B4CB340
		private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {} // 0x000000018B4CC57C-0x000000018B4CC60C
		private void OnCollisionExit(UnityEngine.Collision collisionInfo) {} // 0x000000018B4CDF00-0x000000018B4CDF90
		private void OnCollisionStay(UnityEngine.Collision collisionInfo) {} // 0x000000018B4CC69C-0x000000018B4CC72C
		private void OnCollisionEnter2D(Collision2D collisionInfo) {} // 0x000000018B4CC4EC-0x000000018B4CC57C
		private void OnCollisionExit2D(Collision2D collisionInfo) {} // 0x000000018B4CDE70-0x000000018B4CDF00
		private void OnCollisionStay2D(Collision2D collisionInfo) {} // 0x000000018B4CC60C-0x000000018B4CC69C
		private void OnTriggerEnter(Collider other) {} // 0x000000018B4CC184-0x000000018B4CC214
		private void OnTriggerExit(Collider other) {} // 0x000000018B4CDB08-0x000000018B4CDB98
		private void OnTriggerStay(Collider other) {} // 0x000000018B4CA06C-0x000000018B4CA088
		private void OnTriggerEnter2D(Collider2D other) {}
		private void OnTriggerExit2D(Collider2D other) {} // 0x000000018646DB20-0x000000018646DB28
		private void OnTriggerStay2D(Collider2D other) {} // 0x00000001889CAD20-0x00000001889CADE8
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00000001864BB614-0x00000001864BB734
		private void OnDrawGizmos() {}
		public void InvokeCustomEvent(string name, object value, object sender) {} // 0x00000001831C5680-0x00000001831C5690
		public void InvokeCustomEvent<T>(string name, T value, object sender) {} // 0x0000000186E8C1B8-0x0000000186E8C1EC
	}

	public class EventRouterAnimatorMove : MonoBehaviour // TypeDefIndex: 49327
	{
		// Fields
		private EventRouter.EventDelegate onAnimatorMove; // 0x18
	
		// Events
		public event EventRouter.EventDelegate onAnimatorMove;
	
		// Constructors
		public EventRouterAnimatorMove() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnAnimatorMove() {} // 0x000000018B4C9140-0x000000018B4C91BC
	}

	public static class Logger // TypeDefIndex: 49330
	{
		// Fields
		private static List<LogHandler> subscribers; // 0x00
	
		// Nested types
		public struct Message // TypeDefIndex: 49328
		{
			// Fields
			private WeakReference<object> _contextRef; // 0x00
			public UnityEngine.LogType type; // 0x08
			public string text; // 0x10
			public string tag; // 0x18
	
			// Properties
			public object context { get => default; set {} } // 0x000000018B4CF98C-0x000000018B4CF9FC 0x000000018B4D0354-0x000000018B4D03C4
	
			// Methods
			public bool IsValid() => default; // 0x000000018B4D02E8-0x000000018B4D0354
		}
	
		public delegate bool LogHandler(Message message); // TypeDefIndex: 49329; 0x000000018B4D01A4-0x000000018B4D0210
	
		// Constructors
		static Logger() {} // 0x00000001864BBBD0-0x00000001864BBD00
	
		// Methods
		public static void AddListener(LogHandler callback) {} // 0x000000018B4CF9FC-0x000000018B4CFB50
		public static void RemoveListener(LogHandler callback) {} // 0x000000018B4D03C4-0x000000018B4D0450
		public static void Log(object message, string tag = null, object context = null) {} // 0x000000018B4D0450-0x000000018B4D04AC
		public static void LogWarning(object message, string tag = null, object context = null) {} // 0x000000018B4D04AC-0x000000018B4D0530
		public static void LogError(object message, string tag = null, object context = null) {} // 0x00000001850AD3F0-0x00000001850AD410
		public static void LogException(Exception exception, string tag = null, object context = null) {} // 0x0000000189AEBA14-0x0000000189AEBADC
		private static void Internal_Log(UnityEngine.LogType type, object message, string tag, object context) {} // 0x00000001872140CC-0x00000001872140FC
		private static void ForwardToUnity(UnityEngine.LogType type, object message, string tag, object context) {} // 0x000000018B4CF90C-0x000000018B4CF98C
	}

	public class MonoManager : MonoBehaviour // TypeDefIndex: 49332
	{
		// Fields
		private Action onUpdate; // 0x18
		private Action onLateUpdate; // 0x20
		private Action onFixedUpdate; // 0x28
		private Action onApplicationQuit; // 0x30
		private Action<bool> onApplicationPause; // 0x38
		private Action onGUI; // 0x40
		private static bool isQuiting; // 0x00
		private static MonoManager _current; // 0x08
	
		// Properties
		public static MonoManager current { get => default; } // 0x000000018B4D0B14-0x000000018B4D0CC0 
	
		// Events
		public event Action onUpdate;
		public event Action onLateUpdate;
		public event Action onFixedUpdate;
		public event Action onApplicationQuit;
		public event Action<bool> onApplicationPause;
		public event Action onGUI;
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 49331
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}
	
		// Constructors
		public MonoManager() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private static void Purge() {} // 0x0000000185FA4660-0x0000000185FA46A0
		public static void Create() {} // 0x000000018B4D0684-0x000000018B4D06D8
		public void AddUpdateCall(UpdateMode mode, Action call) {} // 0x000000018B4D0530-0x000000018B4D0574
		public void RemoveUpdateCall(UpdateMode mode, Action call) {} // 0x000000018B4D0760-0x000000018B4D07A4
		protected void Awake() {} // 0x000000018B4D0574-0x000000018B4D0684
		protected void OnApplicationQuit() {} // 0x000000018B4D0714-0x000000018B4D0760
		protected void OnApplicationPause(bool isPause) {} // 0x000000018B4D0700-0x000000018B4D0714
		protected void Update() {} // 0x00000001850F1AC0-0x00000001850F1AE0
		protected void LateUpdate() {} // 0x000000018B4D06EC-0x000000018B4D0700
		protected void FixedUpdate() {} // 0x000000018B4D06D8-0x000000018B4D06EC
	}

	public static class Threader // TypeDefIndex: 49342
	{
		// Fields
		private static bool _applicationIsPlaying_k__BackingField; // 0x00
	
		// Properties
		public static bool applicationIsPlaying { get; private set; }
		public static bool isMainThread { get; }
	
		// Nested types
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 49333
		{
			// Fields
			public Action function; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018B4D4954-0x000000018B4D495C
	
			// Methods
			internal void _StartAction_b__0() {} // 0x000000018B4D495C-0x000000018B4D49AC
		}
	
		private sealed class __c__DisplayClass9_0<T1> // TypeDefIndex: 49334
		{
			// Fields
			public Action<T1> function;
			public T1 parameter1;
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x000000018B4D49D8-0x000000018B4D4A2C
	
			// Methods
			internal void _StartAction_b__0() {} // 0x000000018B4D49AC-0x000000018B4D49D8
		}
	
		private sealed class __c__DisplayClass10_0<T1, T2> // TypeDefIndex: 49335
		{
			// Fields
			public Action<T1, T2> function;
			public T1 parameter1;
			public T2 parameter2;
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B4D475C-0x000000018B4D47AC
	
			// Methods
			internal void _StartAction_b__0() {} // 0x000000018B4D47AC-0x000000018B4D48E0
		}
	
		private sealed class __c__DisplayClass11_0<T1, T2, T3> // TypeDefIndex: 49336
		{
			// Fields
			public Action<T1, T2, T3> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
	
			// Constructors
			public __c__DisplayClass11_0() {}
	
			// Methods
			internal void _StartAction_b__0() {}
		}
	
		private sealed class __c__DisplayClass12_0<TResult> // TypeDefIndex: 49337
		{
			// Fields
			public TResult result;
			public Func<TResult> function;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass12_0() {}
	
			// Methods
			internal void _StartFunction_b__0() {}
			internal void _StartFunction_b__1() {}
		}
	
		private sealed class __c__DisplayClass13_0<TResult, T1> // TypeDefIndex: 49338
		{
			// Fields
			public TResult result;
			public Func<T1, TResult> function;
			public T1 parameter1;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass13_0() {}
	
			// Methods
			internal void _StartFunction_b__0() {}
			internal void _StartFunction_b__1() {} // 0x000000018B4D46D0-0x000000018B4D475C
		}
	
		private sealed class __c__DisplayClass14_0<TResult, T1, T2> // TypeDefIndex: 49339
		{
			// Fields
			public TResult result;
			public Func<T1, T2, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x000000018B4D48E0-0x000000018B4D4954
	
			// Methods
			internal void _StartFunction_b__0() {} // 0x0000000185492010-0x0000000185492020
			internal void _StartFunction_b__1() {} // 0x0000000188052F20-0x0000000188052F3C
		}
	
		private sealed class __c__DisplayClass15_0<TResult, T1, T2, T3> // TypeDefIndex: 49340
		{
			// Fields
			public TResult result;
			public Func<T1, T2, T3, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass15_0() {}
	
			// Methods
			internal void _StartFunction_b__0() {}
			internal void _StartFunction_b__1() {}
		}
	
		private sealed class _ThreadMonitor_d__17 : IEnumerator<object> // TypeDefIndex: 49341
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Thread thread; // 0x20
			public Action callback; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _ThreadMonitor_d__17() {} // Dummy constructor
			public _ThreadMonitor_d__17(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		static Threader() {}
	
		// Methods
		public static void ManuallySyncIsPlaying() {}
		public static Thread StartAction(Thread thread, Action function, Action callback = null) => default;
		public static Thread StartAction<T1>(Thread thread, Action<T1> function, T1 parameter1, Action callback = null) => default;
		public static Thread StartAction<T1, T2>(Thread thread, Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null) => default;
		public static Thread StartAction<T1, T2, T3>(Thread thread, Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null) => default;
		public static Thread StartFunction<TResult>(Thread thread, Func<TResult> function, Action<TResult> callback = null) => default; // 0x0000000181378230-0x0000000181378240
		public static Thread StartFunction<TResult, T1>(Thread thread, Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null) => default; // 0x0000000185492010-0x0000000185492020
		public static Thread StartFunction<TResult, T1, T2>(Thread thread, Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null) => default; // 0x000000018B4D4B94-0x000000018B4D4C38
		public static Thread StartFunction<TResult, T1, T2, T3>(Thread thread, Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null) => default; // 0x0000000181377E40-0x0000000181377E50
		private static void Begin(Thread thread, Action callback) {} // 0x000000018B4D4C38-0x000000018B4D4C84
		private static IEnumerator ThreadMonitor(Thread thread, Action callback) => default; // 0x0000000181377E40-0x0000000181377E50
	}
}
