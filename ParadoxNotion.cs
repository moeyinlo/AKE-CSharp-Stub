/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
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
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 15: ParadoxNotion.dll - Assembly: ParadoxNotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 47165-48499
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[Category("\u272B Blackboard")]
public class SetEnumFlag : ActionTask // TypeDefIndex: 47166
{
	// Fields
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70
	public readonly BBParameter<bool> Clear; // 0x78

	// Properties
	protected override string info { get => default; } // 0x000000018932F378-0x000000018932F410 

	// Constructors
	public SetEnumFlag() {} // 0x000000018932F24C-0x000000018932F378

	// Methods
	protected override void OnExecute() {} // 0x000000018932F0D8-0x000000018932F24C
}

[Category("\u272B Blackboard")]
public class CheckEnumFlag : ConditionTask // TypeDefIndex: 47167
{
	// Fields
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70

	// Properties
	protected override string info { get => default; } // 0x0000000189321EB0-0x0000000189321EF4 

	// Constructors
	public CheckEnumFlag() {} // 0x0000000189321DC0-0x0000000189321EB0

	// Methods
	protected override bool OnCheck() => default; // 0x0000000189321D08-0x0000000189321DC0
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 47169
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 47170
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 47171
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 47172
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 47173
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace FlowCanvas
{
	public class BinderConnection<T> : BinderConnection // TypeDefIndex: 47174
	{
		// Constructors
		public BinderConnection() {}
	
		// Methods
		public override void Bind() {}
		public override void UnBind() {}
	}

	[CancelSpoofAOT]
	public class BinderConnection : Connection // TypeDefIndex: 47176
	{
		// Fields
		[fsSerializeAs("_sourcePortName")]
		private string _sourcePortID; // 0x30
		[fsSerializeAs("_targetPortName")]
		private string _targetPortID; // 0x38
		[NonSerialized]
		private Port _sourcePort; // 0x40
		[NonSerialized]
		private Port _targetPort; // 0x48
	
		// Properties
		public string sourcePortID { get => default; private set {} } // 0x000000018932012C-0x0000000189320168 0x0000000184270470-0x0000000184270480
		public string targetPortID { get => default; private set {} } // 0x0000000189320214-0x0000000189320250 0x000000018388FF30-0x000000018388FF40
		public Port sourcePort { get => default; } // 0x0000000189320168-0x0000000189320214 
		public Port targetPort { get => default; } // 0x0000000189320250-0x00000001893202FC 
		public System.Type bindingType { get => default; } // 0x000000018932005C-0x000000018932012C 
	
		// Constructors
		public BinderConnection() {} // 0x0000000183D5CDB0-0x0000000183D5CDC0
	
		// Methods
		public static BinderConnection Create(Port source, Port target, bool recodeUndo = true /* Metadata: 0x01FBB64B */, bool invokeGraphChanged = true /* Metadata: 0x01FBB64C */) => default; // 0x000000018931EDF4-0x000000018931F310
		public void SetSourcePort(Port newSourcePort) {} // 0x000000018931FD18-0x000000018931FE74
		public void SetTargetPort(Port newTargetPort) {} // 0x000000018931FE74-0x000000018931FFD0
		public void GatherAndValidateSourcePort() {} // 0x000000018931F310-0x000000018931F6F8
		public void GatherAndValidateTargetPort() {} // 0x000000018931F6F8-0x000000018931FB7C
		public static bool CanBeBound(Port source, Port target, BinderConnection refConnection) => default; // 0x000000018931EDD4-0x000000018931EDF4
		public static bool CanBeBoundVerbosed(Port source, Port target, BinderConnection refConnection, out string verbose) {
			verbose = default;
			return default;
		} // 0x000000018931EDA8-0x000000018931EDD4
		private static string CanBeBoundVerbosed_Internal(Port source, Port target, BinderConnection refConnection) => default; // 0x000000018931EB30-0x000000018931EDA8
		public override void OnDestroy() {} // 0x000000018931FC10-0x000000018931FD18
		public override void OnDestroyAfterConnectionRemoved() {} // 0x000000018931FB7C-0x000000018931FC10
		public virtual void Bind() {} // 0x000000018931EA10-0x000000018931EB30
		public virtual void UnBind() {} // 0x000000018931FFD0-0x000000018932005C
	}

	public delegate void FlowHandler(Flow f); // TypeDefIndex: 47177; 0x00000001820ABDF0-0x00000001820ABE30

	[SpoofAOT]
	public delegate T ValueHandler<T>(); // TypeDefIndex: 47178; 0x00000000-0x00000000

	public delegate object ValueHandlerObject(); // TypeDefIndex: 47179; 0x0000000186F0A8DC-0x0000000186F0A8EC

	public delegate void FlowBreak(); // TypeDefIndex: 47180; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void FlowReturn(object value); // TypeDefIndex: 47181; 0x0000000182149960-0x0000000182149970

	[SpoofAOT]
	public struct Flow // TypeDefIndex: 47183
	{
		// Fields
		private Dictionary<string, object> parameters; // 0x08
		private ReturnData returnData; // 0x10
		private FlowBreak breakCall; // 0x20
	
		// Properties
		public int ticks { [IsReadOnly] get; internal set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public static Flow New { get => default; } // 0x0000000183D68AA0-0x0000000183D68AC0 
	
		// Nested types
		public struct ReturnData // TypeDefIndex: 47182
		{
			// Properties
			public FlowReturn returnCall { [IsReadOnly] get; private set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
			public System.Type returnType { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
	
			// Constructors
			public ReturnData(FlowReturn call, System.Type type) : this() {} // 0x00000001832C7BF0-0x00000001832C7C20
		}
	
		// Methods
		public void Call(FlowOutput port) {} // 0x00000001893299D4-0x0000000189329A18
		public T ReadParameter<T>(string name) => default;
		public void WriteParameter<T>(string name, T value) {}
		public void SetReturnData(FlowReturn call, System.Type expectedType) {} // 0x0000000189329BBC-0x0000000189329BF4
		public void Return(object value, FlowNode context) {} // 0x0000000189329A34-0x0000000189329BBC
		public void BeginBreakBlock(FlowBreak callback) {} // 0x0000000184271930-0x0000000184271940
		public void EndBreakBlock() {} // 0x0000000189329A18-0x0000000189329A34
		public void Break(FlowNode context) {} // 0x000000018932997C-0x00000001893299D4
	}

	[Serializable]
	[GraphInfo(packageName = "FlowCanvas", docsURL = "https://flowcanvas.paradoxnotion.com/documentation/", resourcesURL = "https://flowcanvas.paradoxnotion.com/downloads/", forumsURL = "https://flowcanvas.paradoxnotion.com/forums-page/")]
	public abstract class FlowGraph : NodeCanvas.Framework.Graph // TypeDefIndex: 47184
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private List<MacroNodeWrapper> macroWrappers; // 0xA8
		private Dictionary<string, IInvokable> functions; // 0xB0
		private Dictionary<System.Type, Component> cachedAgentComponents; // 0xB8
	
		// Properties
		public override System.Type baseNodeType { get; } // 0x000000018932600C-0x000000018932605C 
		public override bool allowBlackboardOverrides { get; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool requiresAgent { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool requiresPrimeNode { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool isTree { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool canAcceptVariableDrops { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		protected FlowGraph() {} // 0x0000000189325FC0-0x000000018932600C
	
		// Methods
		public T CallFunction<T>(string name, params object[] args) => default;
		public object CallFunction(string name, params object[] args) => default; // 0x000000018932546C-0x0000000189325544
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args) {} // 0x000000018932538C-0x000000018932546C
		public UnityEngine.Object GetAgentComponent(System.Type type) => default; // 0x0000000189325544-0x00000001893257E4
		protected override void OnGraphInitialize() {} // 0x00000001893258E4-0x0000000189325CF8
		private void InitSecondPass() {} // 0x00000001893257E4-0x00000001893258E4
		protected override void OnGraphStarted() {} // 0x0000000189325CF8-0x0000000189325E08
		protected override void OnGraphUpdate() {} // 0x0000000189325F2C-0x0000000189325FC0
		protected override void OnGraphStoped() {} // 0x0000000189325E08-0x0000000189325F2C
	}

	[CancelSpoofAOT]
	public abstract class FlowNode : NodeCanvas.Framework.Node, ISerializationCallbackReceiver // TypeDefIndex: 47195
	{
		// Fields
		[SerializeField]
		private Dictionary<string, object> _inputPortValues; // 0x98
		[NonSerialized]
		protected Dictionary<string, Port> inputPorts; // 0xA0
		[NonSerialized]
		protected Dictionary<string, Port> outputPorts; // 0xA8
	
		// Properties
		public override bool allowDragInContentRect { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected override float? overrideNodeWidth { get; } // 0x000000018932958C-0x00000001893295CC 
		public sealed override int maxInConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public sealed override int maxOutConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public sealed override bool allowAsPrime { get; } // 0x000000018115F4C0-0x000000018115F530 
		public sealed override bool canSelfConnect { get; } // 0x000000018115F4C0-0x000000018115F530 
		public sealed override System.Type outConnectionType { get; } // 0x000000018932953C-0x000000018932958C 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public override Alignment2x2 iconAlignment { get; } // 0x0000000181168950-0x0000000181168960 
		public FlowGraph flowGraph { get; } // 0x0000000189329500-0x000000018932953C 
		protected string SPACE { get; } // 0x00000001893294D4-0x0000000189329500 
		public virtual bool ignoreSelfInstancePortAssignment { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Class)]
		public class ContextDefinedInputsAttribute : Attribute // TypeDefIndex: 47185
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedInputsAttribute() {} // Dummy constructor
			public ContextDefinedInputsAttribute(params System.Type[] types) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		public class ContextDefinedOutputsAttribute : Attribute // TypeDefIndex: 47186
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedOutputsAttribute() {} // Dummy constructor
			public ContextDefinedOutputsAttribute(params System.Type[] types) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		public class HasRefreshButtonAttribute : Attribute // TypeDefIndex: 47187
		{
			// Constructors
			public HasRefreshButtonAttribute() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[AttributeUsage(AttributeTargets.Field)]
		public class GatherPortsCallbackAttribute : CallbackAttribute // TypeDefIndex: 47188
		{
			// Constructors
			public GatherPortsCallbackAttribute() {} // 0x0000000189329BF4-0x0000000189329C34
		}
	
		// Constructors
		protected FlowNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189329104-0x00000001893294D4
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018350B670-0x000000018350B680
		public override void OnValidate(NodeCanvas.Framework.Graph flowGraph) {} // 0x0000000189327B50-0x0000000189327B58
		public sealed override void OnParentConnected(int i) {} // 0x000000018350B670-0x000000018350B680
		public sealed override void OnChildConnected(int i) {} // 0x000000018350B670-0x000000018350B680
		public sealed override void OnParentDisconnected(int i) {} // 0x000000018350B670-0x000000018350B680
		public sealed override void OnChildDisconnected(int i) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnPortConnected(Port port, Port otherPort) {} // 0x0000000189327AE8-0x0000000189327B48
		public virtual void OnPortDisconnected(Port port, Port otherPort) {} // 0x0000000189327B48-0x0000000189327B50
		public virtual void OnPortDisconnectedLate(Port port, Port otherPort) {} // 0x000000018350B670-0x000000018350B680
		public void BindPorts() {} // 0x0000000189326A98-0x0000000189326B4C
		public void UnBindPorts() {} // 0x0000000189329050-0x0000000189329104
		public Port GetInputPort(string ID) => default; // 0x00000001893276B0-0x0000000189327808
		public Port GetOutputPort(string ID) => default; // 0x0000000189327928-0x0000000189327A80
		public IEnumerable<Port> GetAllPorts() => default; // 0x0000000189327200-0x0000000189327290
		public IEnumerable<FlowOutput> GetOutputFlowPorts() => default; // 0x00000001893278C0-0x0000000189327928
		public IEnumerable<ValueOutput> GetOutputValuePorts() => default; // 0x0000000189327A80-0x0000000189327AE8
		public IEnumerable<FlowInput> GetInputFlowPorts() => default; // 0x0000000189327648-0x00000001893276B0
		public IEnumerable<ValueInput> GetInputValuePorts() => default; // 0x0000000189327808-0x0000000189327870
		public Port GetFirstInputOfType(System.Type type) => default; // 0x0000000189327290-0x000000018932746C
		public Port GetFirstOutputOfType(System.Type type) => default; // 0x000000018932746C-0x0000000189327648
		public void AssignSelfInstancePort() {} // 0x00000001893268B4-0x0000000189326A98
		public void GatherPorts() {} // 0x000000018932707C-0x0000000189327200
		protected abstract void RegisterPorts();
		[Conditional("UNITY_EDITOR")]
		protected virtual void ValidateConnections() {} // 0x000000018350B670-0x000000018350B680
		private void DeserializeInputPortValues() {} // 0x0000000189326C5C-0x000000018932707C
		[Conditional("UNITY_EDITOR")]
		private void RefreshEditorPorts() {} // 0x000000018350B670-0x000000018350B680
		public FlowInput AddFlowInput(string name, string ID, FlowHandler pointer) => default; // 0x000000018932615C-0x0000000189326174
		public FlowInput AddFlowInput(string name, FlowHandler pointer, string ID = "" /* Metadata: 0x01FBB64D */) => default; // 0x0000000189326174-0x000000018932625C
		public FlowOutput AddFlowOutput(string name, string ID = "" /* Metadata: 0x01FBB64E */) => default; // 0x000000018932625C-0x0000000189326334
		public ValueInput<T> AddValueInput<T>(string name, string ID = "" /* Metadata: 0x01FBB64F */) => default;
		public ValueOutput<T> AddValueOutput<T>(string name, string ID, ValueHandler<T> getter) => default;
		public ValueOutput<T> AddValueOutput<T>(string name, ValueHandler<T> getter, string ID = "" /* Metadata: 0x01FBB650 */) => default;
		public void AddValueInput(System.Type valueType, string name, string ID = "" /* Metadata: 0x01FBB651 */) {} // 0x00000001893263FC-0x00000001893265D0
		public ValueOutput<T> AddValueOutput<T>(string name, string ID = "" /* Metadata: 0x01FBB652 */) => default;
		public void AddValueOutput(System.Type valueType, string name, string ID = "" /* Metadata: 0x01FBB653 */) {} // 0x00000001893266E0-0x00000001893268B4
		public ValueInput AddValueInput(string name, string ID, System.Type type) => default; // 0x00000001893265D0-0x00000001893265E8
		public ValueInput AddValueInput(string name, System.Type type, string ID = "" /* Metadata: 0x01FBB654 */) => default; // 0x0000000189326334-0x00000001893263FC
		public ValueOutput AddValueOutput(string name, string ID, System.Type type, ValueHandlerObject getter) => default; // 0x00000001893265E8-0x0000000189326608
		public ValueOutput AddValueOutput(string name, System.Type type, ValueHandlerObject getter, string ID = "" /* Metadata: 0x01FBB655 */) => default; // 0x0000000189326608-0x00000001893266E0
		protected void QualifyPortNameAndID(ref string name, ref string ID, IDictionary dict) {} // 0x0000000189327B58-0x0000000189327C10
		private bool CheckReverseIDEquality(Port port, string requestedID) => default; // 0x0000000189326B4C-0x0000000189326C5C
		public void TryAddReflectionBasedRegistrationForObject(object instance) {} // 0x000000018932895C-0x0000000189328B30
		public FlowInput TryAddMethodFlowInput(MethodInfo method, object instance) => default; // 0x00000001893284B0-0x0000000189328664
		public FlowOutput TryAddFieldDelegateFlowOutput(System.Reflection.FieldInfo field, object instance) => default; // 0x0000000189327F48-0x00000001893280BC
		public ValueInput TryAddFieldDelegateValueInput(System.Reflection.FieldInfo field, object instance) => default; // 0x00000001893280BC-0x00000001893284B0
		public ValueOutput TryAddPropertyValueOutput(PropertyInfo prop, object instance) => default; // 0x0000000189328664-0x000000018932895C
		public FlowNode ReplaceWith(System.Type t) => default; // 0x0000000189327C10-0x0000000189327F48
		private void TryRemovePortIfMissingAndClean(Port port) {} // 0x0000000189328F9C-0x0000000189329050
		public virtual System.Type GetNodeWildDefinitionType() => default; // 0x0000000189327870-0x00000001893278C0
		private void TryHandleWildPortConnection(System.Type currentType, System.Type targetType) {} // 0x0000000189328EF4-0x0000000189328F9C
		public static System.Type TryGetNewGenericTypeForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Type content, System.Type context) => default; // 0x0000000189328CD0-0x0000000189328EF4
		public static MethodInfo TryGetNewGenericMethodForWild(System.Type wildType, System.Type currentType, System.Type targetType, MethodInfo content) => default; // 0x0000000189328B30-0x0000000189328CD0
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FlowNodeNested<T> : FlowNode, IGraphAssignable<T> // TypeDefIndex: 47196
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
	
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

	[CreateAssetMenu(menuName = "ParadoxNotion/FlowCanvas/FlowScript Asset")]
	public class FlowScript : FlowScriptBase // TypeDefIndex: 47197
	{
		// Properties
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public FlowScript() {} // 0x00000001893297D0-0x00000001893297D8
	}

	public abstract class FlowScriptBase : FlowGraph // TypeDefIndex: 47198
	{
		// Constructors
		protected FlowScriptBase() {} // 0x00000001893297D0-0x00000001893297D8
	}

	[AddComponentMenu("FlowCanvas/FlowScript Controller")]
	public class FlowScriptController : GraphOwner<FlowScript> // TypeDefIndex: 47199
	{
		// Constructors
		public FlowScriptController() {} // 0x0000000189329948-0x000000018932997C
	
		// Methods
		public void CallFunction(string name) {} // 0x000000018932985C-0x00000001893298D8
		public object CallFunction(string name, params object[] args) => default; // 0x00000001893298D8-0x0000000189329948
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args) {} // 0x00000001893297D8-0x000000018932985C
	}

	public interface IEditorMenuCallbackReceiver // TypeDefIndex: 47200
	{
	}

	[Category("Events/Object/Rendering")]
	[Description("Called after all rendering is complete to render image on target camera.")]
	[Name("On Render Image", 0)]
	public class RenderImageEvent : RouterEventNode<Camera> // TypeDefIndex: 47201
	{
		// Fields
		private FlowOutput fOut; // 0xC8
		private RenderTexture t1; // 0xD0
		private RenderTexture t2; // 0xD8
	
		// Constructors
		public RenderImageEvent() {} // 0x000000018932F0A4-0x000000018932F0D8
	
		// Methods
		protected override void Subscribe(EventRouter router) {} // 0x000000018932EF84-0x000000018932F014
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018932F014-0x000000018932F0A4
		private void OnRenderImage(RenderTexture source, RenderTexture dest) {} // 0x000000018932EDAC-0x000000018932EE28
		protected override void RegisterPorts() {} // 0x000000018932EE28-0x000000018932EF84
	}

	public abstract class Port // TypeDefIndex: 47203
	{
		// Properties
		public bool prettifyName { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public bool forceNotDraw { get; set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
		public FlowNode parent { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string ID { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string name { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public int connections { get; internal set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public bool isConnected { get; } // 0x000000018932EDA4-0x000000018932EDAC 
		internal BindStatus bindStatus { get; private set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		internal GUIContent displayContent { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public abstract System.Type type { get; }
	
		// Nested types
		public enum BindStatus // TypeDefIndex: 47202
		{
			Valid = 0,
			Missing = 1,
			InvalidCast = 2
		}
	
		// Constructors
		public Port() {} // 0x0000000181168960-0x0000000181168970
		public Port(FlowNode parent, string name, string ID) {} // 0x000000018932ED68-0x000000018932EDA4
	
		// Methods
		internal Port FlagMissing() => default; // 0x000000018932E55C-0x000000018932E584
		internal Port FlagInvalidCast() => default; // 0x000000018932E534-0x000000018932E55C
		internal Port FlagValid() => default; // 0x000000018932E584-0x000000018932E5A8
		public virtual bool CanAcceptConnections() => default; // 0x000000018932E480-0x000000018932E534
		public IEnumerable<BinderConnection> GetPortConnections() => default; // 0x000000018932E728-0x000000018932E83C
		public BinderConnection GetFirstInputConnection() => default; // 0x000000018932E5A8-0x000000018932E668
		public BinderConnection GetFirstOutputConnection() => default; // 0x000000018932E668-0x000000018932E728
		public bool IsFlowPort() => default; // 0x000000018932E92C-0x000000018932E990
		public bool IsValuePort() => default; // 0x000000018932EBE0-0x000000018932EC44
		public bool IsInputPort() => default; // 0x000000018932E990-0x000000018932E9F4
		public bool IsOutputPort() => default; // 0x000000018932E9F4-0x000000018932EA58
		public bool IsUnityObject() => default; // 0x000000018932EA58-0x000000018932EAF8
		public bool IsUnitySceneObject() => default; // 0x000000018932EAF8-0x000000018932EBE0
		public bool IsDelegate() => default; // 0x000000018932E83C-0x000000018932E8DC
		public bool IsEnumerableCollection() => default; // 0x000000018932E8DC-0x000000018932E92C
		public bool IsWild() => default; // 0x000000018932EC44-0x000000018932ECB8
		public override string ToString() => default; // 0x000000018932ECB8-0x000000018932ED08
	}

	public class FlowInput : Port // TypeDefIndex: 47204
	{
		// Properties
		public FlowHandler pointer { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public override System.Type type { get => default; } // 0x000000018932610C-0x000000018932615C 
	
		// Constructors
		public FlowInput() {} // Dummy constructor
		public FlowInput(FlowNode parent, string name, string ID, FlowHandler pointer) {} // 0x00000001893260DC-0x000000018932610C
	}

	public class FlowOutput : Port // TypeDefIndex: 47205
	{
		// Properties
		public override System.Type type { get => default; } // 0x00000001893296EC-0x000000018932973C 
	
		// Events
		public event FlowHandler pointer;
	
		// Constructors
		public FlowOutput() {} // Dummy constructor
		public FlowOutput(FlowNode parent, string name, string ID) {} // 0x0000000187EA374C-0x0000000187EA375C
	
		// Methods
		public void Call(Flow f) {} // 0x00000001893295F8-0x0000000189329658
		public void BindTo(FlowInput target) {} // 0x00000001893295D4-0x00000001893295F8
		public void Append(FlowHandler callback) {} // 0x00000001893295CC-0x00000001893295D4
		public void UnBind() {} // 0x0000000188571358-0x000000018857136C
	}

	public abstract class ValueInput : Port // TypeDefIndex: 47206
	{
		// Properties
		public object value { get; } // 0x0000000189335F2C-0x0000000189335F3C 
		public bool skipSelfInstanceAssignment { get; private set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public abstract object defaultValue { get; set; }
		public abstract object serializedValue { get; set; }
		public abstract bool isDefaultValue { get; }
		public abstract System.Type type { get; }
	
		// Constructors
		protected ValueInput() {} // Dummy constructor
		public ValueInput(FlowNode parent, string name, string ID) {} // 0x0000000187EA374C-0x0000000187EA375C
	
		// Methods
		public static ValueInput<T> CreateInstance<T>(FlowNode parent, string name, string ID) => default;
		public static ValueInput CreateInstance(System.Type t, FlowNode parent, string name, string ID) => default; // 0x0000000189335D58-0x0000000189335EEC
		public ValueInput SetDefaultAndSerializedValue(object v) => default; // 0x0000000189335EEC-0x0000000189335F2C
		public ValueInput SkipSelfInstanceAssignment(bool skip) => default; // 0x0000000183D71B60-0x0000000183D71B70
		public abstract void BindTo(ValueOutput target);
		public abstract void UnBind();
		public abstract object GetObjectValue();
	}

	public class ValueInput<T> : ValueInput // TypeDefIndex: 47207
	{
		// Fields
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

	public abstract class ValueOutput : Port // TypeDefIndex: 47208
	{
		// Constructors
		protected ValueOutput() {} // Dummy constructor
		public ValueOutput(FlowNode parent, string name, string ID) {} // 0x0000000187EA374C-0x0000000187EA375C
	
		// Methods
		public static ValueOutput<T> CreateInstance<T>(FlowNode parent, string name, string ID, ValueHandler<T> getter) => default;
		public static ValueOutput CreateInstance(System.Type t, FlowNode parent, string name, string ID, ValueHandlerObject getter) => default; // 0x0000000189335F3C-0x00000001893360F0
		public abstract object GetObjectValue();
	}

	public class ValueOutput<T> : ValueOutput // TypeDefIndex: 47210
	{
		// Properties
		public ValueHandler<T> getter { get; private set; }
		public override System.Type type { get => default; }
	
		// Constructors
		public ValueOutput() {} // Dummy constructor
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandler<T> getter) {}
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandlerObject getter) {}
		public ValueOutput(FlowNode parent, string name, string ID) {}
	
		// Methods
		public override object GetObjectValue() => default;
		public static explicit operator T(ValueOutput<T> port) => default;
	}

	public static class TypeConverter // TypeDefIndex: 47217
	{
		// Events
		public static event CustomConverter customConverter;
		public static event CustomCanConvert customCanConvert;
	
		// Nested types
		public delegate ValueHandler<object> CustomConverter(System.Type sourceType, System.Type targetType, ValueHandler<object> func); // TypeDefIndex: 47211; 0x0000000181035ED0-0x0000000181035EF0
	
		public delegate bool? CustomCanConvert(System.Type sourceType, System.Type targetType); // TypeDefIndex: 47212; 0x0000000181165340-0x0000000181165350
	
		// Methods
		public static ValueHandler<T> GetConverterFuncFromTo<T>(System.Type sourceType, System.Type targetType, ValueHandler<object> func) => default;
		public static bool HasConvertion(System.Type sourceType, System.Type targetType) => default; // 0x0000000189331FD8-0x0000000189332084
		public static T QuickConvert<T>(object obj) => default;
		public static object QuickConvert(object obj, System.Type type) => default; // 0x0000000189332084-0x00000001893321B0
	}

	public class Wild // TypeDefIndex: 47218
	{
		// Constructors
		public Wild() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace FlowCanvas.Macros
{
	[CreateAssetMenu(menuName = "ParadoxNotion/FlowCanvas/Macro Asset")]
	public class Macro : FlowScriptBase // TypeDefIndex: 47798
	{
		// Fields
		[SerializeField]
		public List<DynamicParameterDefinition> inputDefinitions; // 0xC0
		[SerializeField]
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
		public override bool allowBlackboardOverrides { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public MacroInputNode entry { get => default; } // 0x000000018935BC70-0x000000018935BD80 
		public MacroOutputNode exit { get => default; } // 0x000000018935BD80-0x000000018935BE90 
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 47792
		{
			// Fields
			public List<DynamicParameterDefinition> inputDefinitions; // 0x10
			public List<DynamicParameterDefinition> outputDefinitions; // 0x18
	
			// Constructors
			public DerivedSerializationData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public Macro() {} // 0x000000018935BA4C-0x000000018935BC70
	
		// Methods
		public override object OnDerivedDataSerialization() => default; // 0x000000018935B96C-0x000000018935B9DC
		public override void OnDerivedDataDeserialization(object data) {} // 0x000000018935B8A4-0x000000018935B96C
		protected override void OnGraphValidate() {} // 0x000000018935B9DC-0x000000018935BA4C
		public Port AddInputDefinition(DynamicParameterDefinition def) => default; // 0x000000018935B488-0x000000018935B5EC
		public Port AddOutputDefinition(DynamicParameterDefinition def) => default; // 0x000000018935B5EC-0x000000018935B750
		public void AddExamplePorts() {} // 0x000000018935B300-0x000000018935B488
		public void SetValueInput<T>(string name, T value) {}
		public void CallFlowInput(string name) {} // 0x000000018935B750-0x000000018935B8A4
		public T GetValueOutput<T>(string name) => default;
	}

	[Description("Defines the Input ports of the Macro.\nTo quickly create ports, you can also Drag&Drop a connection on top of this node!")]
	[DoNotList]
	[Icon("MacroIn", false, "")]
	[ProtectedSingleton]
	public class MacroInputNode : FlowNode // TypeDefIndex: 47800
	{
		// Properties
		public override Alignment2x2 iconAlignment { get => default; } // 0x0000000181002730-0x0000000181002740 
		private Macro macro { get => default; } // 0x000000018935A4CC-0x000000018935A508 
	
		// Constructors
		public MacroInputNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018935A1C4-0x000000018935A4CC
	}

	[Color("ffe4e1")]
	[DoNotList]
	[DropReferenceType(typeof(Macro))]
	[HasRefreshButton]
	public class MacroNodeWrapper : FlowNode, IGraphAssignable, IUpdatable // TypeDefIndex: 47804
	{
		// Fields
		[SerializeField]
		private Macro _macro; // 0xB0
		private Macro _currentInstance; // 0xB8
	
		// Properties
		public override string name { get => default; } // 0x000000018935AE8C-0x000000018935AF14 
		public override string description { get => default; } // 0x000000018935ADF0-0x000000018935AE8C 
		public Macro macro { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x000000018935AF14-0x000000018935AFB4
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x000000018935A764-0x000000018935A7B8
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get => default; set {} } // 0x0000000183D4E750-0x0000000183D4E760 0x000000018935A6A0-0x000000018935A708
		List<BBMappingParameter> IGraphAssignable.variablesMap { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		BBParameter IGraphAssignable.subGraphParameter { get => default; } // 0x0000000181002730-0x0000000181002740 
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> IGraphAssignable.instances { get => default; set {} } // 0x000000018935A60C-0x000000018935A6A0 0x000000018935A708-0x000000018935A764
	
		// Constructors
		public MacroNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public void MakeInstance() {} // 0x000000018935A508-0x000000018935A60C
		void IUpdatable.Update() {} // 0x000000018935A7B8-0x000000018935A838
		protected override void RegisterPorts() {} // 0x000000018935A838-0x000000018935ADF0
	}

	[Description("Defines the Output ports of the Macro.\nTo quickly create ports, you can also Drag&Drop a connection on top of this node!")]
	[DoNotList]
	[Icon("MacroOut", false, "")]
	[ProtectedSingleton]
	public class MacroOutputNode : FlowNode // TypeDefIndex: 47806
	{
		// Properties
		public override Alignment2x2 iconAlignment { get => default; } // 0x0000000181002730-0x0000000181002740 
		private Macro macro { get => default; } // 0x000000018935B2C4-0x000000018935B300 
	
		// Constructors
		public MacroOutputNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018935AFB4-0x000000018935B2C4
	}
}

namespace FlowCanvas.Nodes
{
	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public class ExternalImplementedNodeWrapper : FlowNode // TypeDefIndex: 47219
	{
		// Fields
		[SerializeField]
		private UnityEngine.Object _target; // 0xB0
	
		// Properties
		public IExternalImplementedNode target { get => default; set {} } // 0x000000018932513C-0x000000018932517C 0x000000018932517C-0x00000001893251F8
		public override string name { get => default; } // 0x00000001893250BC-0x000000018932513C 
	
		// Constructors
		public ExternalImplementedNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected System.Type GetRuntimeIconType() => default; // 0x0000000189325008-0x0000000189325030
		protected override void RegisterPorts() {} // 0x0000000189325030-0x00000001893250B4
		public void SetTarget(IExternalImplementedNode target) {} // 0x00000001893250B4-0x00000001893250BC
	}

	public interface IDropedReferenceNode : IGraphElement // TypeDefIndex: 47220
	{
		// Methods
		void SetTarget(UnityEngine.Object target);
	}

	public interface IExternalImplementedNode // TypeDefIndex: 47221
	{
		// Methods
		void RegisterPorts(FlowNode parent);
	}

	[Category("Events/Application")]
	[Description("Called when the Application is paused or resumed")]
	[Name("On Application Pause", 0)]
	public class ApplicationPauseEvent : EventNode // TypeDefIndex: 47222
	{
		// Fields
		private FlowOutput pause; // 0xB0
		private bool isPause; // 0xB8
	
		// Constructors
		public ApplicationPauseEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018931E60C-0x000000018931E6A4
		public override void OnGraphStoped() {} // 0x000000018931E6A4-0x000000018931E73C
		private void ApplicationPause(bool isPause) {} // 0x000000018931E5B8-0x000000018931E60C
		protected override void RegisterPorts() {} // 0x000000018931E73C-0x000000018931E82C
	}

	[Category("Events/Application")]
	[Description("Called when the Application quit")]
	[Name("On Application Quit", 0)]
	public class ApplicationQuitEvent : EventNode // TypeDefIndex: 47223
	{
		// Fields
		private FlowOutput quit; // 0xB0
	
		// Constructors
		public ApplicationQuitEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018931E87C-0x000000018931E914
		public override void OnGraphStoped() {} // 0x000000018931E914-0x000000018931E9AC
		private void ApplicationQuit() {} // 0x000000018931E82C-0x000000018931E87C
		protected override void RegisterPorts() {} // 0x000000018931E9AC-0x000000018931EA10
	}

	[Description("Automatically Subscribes to the target C# Event when the graph is enabled, and is called when the event is raised")]
	[DoNotList]
	[Name("C# Event", 0)]
	public class CSharpAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 47225
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo _event; // 0xB0
		private ReflectedDelegateEvent reflectedEvent; // 0xB8
		private ValueInput instancePort; // 0xC0
		private FlowOutput callback; // 0xC8
		private object instance; // 0xD0
		private object[] args; // 0xD8
	
		// Properties
		private EventInfo eventInfo { get => default; } // 0x0000000187C03DD4-0x0000000187C03DE8 
		private bool isStaticEvent { get => default; } // 0x0000000189320968-0x00000001893209D8 
		public override string name { get => default; } // 0x00000001893209D8-0x0000000189320B00 
	
		// Constructors
		public CSharpAutoCallbackEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAD0-0x0000000183D4EAE0
		public void SetEvent(EventInfo info, object instance = null) {} // 0x00000001893208E0-0x0000000189320968
		protected override void RegisterPorts() {} // 0x00000001893205C8-0x00000001893208E0
		public override void OnGraphStarted() {} // 0x0000000189320360-0x00000001893204B8
		public override void OnGraphStoped() {} // 0x00000001893204B8-0x00000001893205C8
		private void OnEventRaised(params object[] args) {} // 0x00000001893202FC-0x0000000189320360
	}

	[Category("Events/Custom")]
	[Description("Providing a C# Event, Register a callback to be called when that event is raised.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(SharpEvent) })]
	[Name("C# Event Callback", 2)]
	public class CSharpEventCallback : EventNode, IReflectedWrapper // TypeDefIndex: 47227
	{
		// Fields
		[ExposeField]
		[GatherPortsCallback]
		[SerializeField]
		[Tooltip("If enabled, registration will be handled on graph Enable/Disable automatically")]
		protected bool _autoHandleRegistration; // 0xB0
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB8
		private object[] argValues; // 0xC0
		private ValueInput eventInput; // 0xC8
		private FlowOutput flowCallback; // 0xD0
		private ReflectedDelegateEvent reflectedEvent; // 0xD8
	
		// Properties
		private System.Type type { get => default; set {} } // 0x0000000189321374-0x0000000189321388 0x0000000189321388-0x0000000189321438
		private bool autoHandleRegistration { get => default; } // 0x0000000181151530-0x0000000181151540 
	
		// Constructors
		public CSharpEventCallback() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4E750-0x0000000183D4E760
		public override void OnGraphStarted() {} // 0x0000000189320BB4-0x0000000189320BFC
		public override void OnGraphStoped() {} // 0x0000000189320BFC-0x0000000189320C5C
		protected override void RegisterPorts() {} // 0x0000000189320D4C-0x0000000189321184
		private void Register(Flow f = default) {} // 0x0000000189321184-0x00000001893212A0
		private void Unregister(Flow f = default) {} // 0x00000001893212A0-0x0000000189321374
		private void Callback(params object[] args) {} // 0x0000000189320B00-0x0000000189320B64
		public override System.Type GetNodeWildDefinitionType() => default; // 0x0000000189320B64-0x0000000189320BB4
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000189320C5C-0x0000000189320D4C
	}

	[Category("Events/Custom")]
	[Description("Called when a custom event is received on target(s).\n- Receiver, is the object which received the event.\n- Sender, is the object which invoked the event.\n\n- To send an event from a graph use the SendEvent node.\n- To send an event from code use: \'FlowScriptController.SendEvent(string)\'")]
	[Name("Custom Event", 100)]
	public class CustomEvent : RouterEventNode<GraphOwner> // TypeDefIndex: 47228
	{
		// Fields
		[DelayedField]
		[RequiredField]
		public BBParameter<string> eventName; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private GraphOwner sender; // 0xD8
		private GraphOwner receiver; // 0xE0
	
		// Properties
		public override string name { get => default; } // 0x0000000189324554-0x00000001893245CC 
	
		// Constructors
		public CustomEvent() {} // 0x00000001893244E0-0x0000000189324554
	
		// Methods
		protected override void Subscribe(EventRouter router) {} // 0x00000001893243C0-0x0000000189324450
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189324450-0x00000001893244E0
		protected override void RegisterPorts() {} // 0x0000000189324264-0x00000001893243C0
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg) {} // 0x00000001893240C0-0x0000000189324264
	}

	[Category("Events/Custom")]
	[Description("Called when a custom event is received on target(s).\n- Receiver, is the object which received the event.\n- Sender, is the object which invoked the event.\n\n- To send an event from a graph use the SendEvent(T) node.\n- To send an event from code use: \'FlowScriptController.SendEvent(string, T)\'")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Custom Event", 100)]
	public class CustomEvent<T> : RouterEventNode<GraphOwner> // TypeDefIndex: 47229
	{
		// Fields
		[DelayedField]
		[RequiredField]
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
	}

	[Category("Events/Custom")]
	[Description("The exposed Delegate points directly to the \'Callback\' output. You can connect this delegate as listener to a Unity or C# Event using the AddListener function of that Unity Event, or the += function of that C# Event. When that event is raised, this node will be called.")]
	[ContextDefinedOutputs(new System.Type[2] {typeof(Flow), typeof(Delegate) })]
	[Name("Delegate Callback", 1)]
	public class DelegateCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 47231
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB0
		private ReflectedDelegateEvent reflectedEvent; // 0xB8
		private ValueOutput delegatePort; // 0xC0
		private FlowOutput callbackPort; // 0xC8
		private object[] args; // 0xD0
	
		// Properties
		private System.Type delegateType { get => default; set {} } // 0x0000000187C03DD4-0x0000000187C03DE8 0x0000000189324B3C-0x0000000189324BEC
	
		// Constructors
		public DelegateCallbackEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAD0-0x0000000183D4EAE0
		protected override void RegisterPorts() {} // 0x0000000189324738-0x0000000189324B1C
		private void Callback(params object[] args) {} // 0x00000001893245CC-0x0000000189324630
		public override void OnGraphStoped() {} // 0x0000000189324630-0x0000000189324648
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000189324648-0x0000000189324738
	}

	[Description("Returns a reference of a C# event, which can be used with the C# Event Callback node.")]
	[DoNotList]
	public class GetSharpEvent : FlowNode, IReflectedWrapper // TypeDefIndex: 47233
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo _event; // 0xB0
		private ValueInput instancePort; // 0xB8
	
		// Properties
		private EventInfo eventInfo { get => default; } // 0x0000000187C03DD4-0x0000000187C03DE8 
		public override string name { get => default; } // 0x0000000189329EB8-0x000000018932A030 
	
		// Constructors
		public GetSharpEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAD0-0x0000000183D4EAE0
		public void SetEvent(EventInfo info, object instance = null) {} // 0x0000000189329E30-0x0000000189329EB8
		protected override void RegisterPorts() {} // 0x0000000189329C34-0x0000000189329E30
	}

	[Category("Events/Signals")]
	[Description("Invoke a defined Signal. Signals are similar to name-based events but are safer to changes and support multiple parameters.")]
	[DropReferenceType(typeof(SignalDefinition))]
	[HasRefreshButton]
	public class InvokeSignal : FlowNode, IDropedReferenceNode // TypeDefIndex: 47235
	{
		// Fields
		[GatherPortsCallback]
		public BBParameter<SignalDefinition> _signalDefinition; // 0xB0
		[GatherPortsCallback]
		public bool global; // 0xB8
		private ValueInput<Transform> target; // 0xC0
		private ValueInput[] inputArgs; // 0xC8
	
		// Properties
		private SignalDefinition signalDefinition { get => default; set {} } // 0x000000018932AE94-0x000000018932AEDC 0x000000018932AEDC-0x000000018932AF34
		public override string name { get => default; } // 0x000000018932ADBC-0x000000018932AE94 
	
		// Constructors
		public InvokeSignal() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public void SetTarget(UnityEngine.Object target) {} // 0x000000018932AD5C-0x000000018932ADBC
		protected override void RegisterPorts() {} // 0x000000018932AA8C-0x000000018932AD5C
	}

	[Category("Events/Signals")]
	[Description("Check if a defined Signal has been invoked. Signals are similar to name-based events but are safer to changes and support multiple parameters.")]
	[DropReferenceType(typeof(SignalDefinition))]
	[ExecutionPriority(100)]
	[HasRefreshButton]
	public class SignalCallback : RouterEventNode<Transform>, IDropedReferenceNode // TypeDefIndex: 47237
	{
		// Fields
		[GatherPortsCallback]
		public BBParameter<SignalDefinition> _signalDefinition; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private Transform receiver; // 0xD8
		private Transform sender; // 0xE0
		private object[] args; // 0xE8
	
		// Properties
		private SignalDefinition signalDefinition { get => default; set {} } // 0x000000018932FBF4-0x000000018932FC3C 0x000000018932FC3C-0x000000018932FC94
		public override string name { get => default; } // 0x000000018932FB0C-0x000000018932FBF4 
	
		// Constructors
		public SignalCallback() {} // 0x000000018932FAD8-0x000000018932FB0C
	
		// Methods
		public void SetTarget(UnityEngine.Object target) {} // 0x000000018932FA78-0x000000018932FAD8
		protected override void Subscribe(EventRouter router) {} // 0x000000018350B670-0x000000018350B680
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018350B670-0x000000018350B680
		public override void OnPostGraphStarted() {} // 0x000000018932F654-0x000000018932F790
		public override void OnGraphStoped() {} // 0x000000018932F410-0x000000018932F4FC
		protected override void RegisterPorts() {} // 0x000000018932F790-0x000000018932FA78
		private void OnInvoked(Transform sender, Transform receiver, bool isGlobal, object[] args) {} // 0x000000018932F4FC-0x000000018932F654
	}

	[Description("Automatically Subscribes to the target UnityEvent when the graph is enabled, and is called when the event is raised")]
	[DoNotList]
	[Name("Unity Event", 0)]
	public class UnityEventAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 47239
	{
		// Fields
		[fsSerializeAs("_field")]
		private SerializedUnityEventInfo _eventMember; // 0xB0
		private ReflectedUnityEvent reflectedEvent; // 0xB8
		private UnityEventBase unityEvent; // 0xC0
		private ValueInput instancePort; // 0xC8
		private FlowOutput callback; // 0xD0
		private object[] args; // 0xD8
	
		// Properties
		private MemberInfo member { get => default; } // 0x00000001893350E4-0x0000000189335100 
		private bool isStatic { get => default; } // 0x00000001893350BC-0x00000001893350E4 
		private System.Type eventType { get => default; } // 0x0000000189335084-0x00000001893350AC 
		private System.Reflection.FieldInfo field { get => default; } // 0x00000001893350AC-0x00000001893350BC 
		private PropertyInfo prop { get => default; } // 0x0000000189335228-0x0000000189335238 
		public override string name { get => default; } // 0x0000000189335100-0x0000000189335228 
	
		// Constructors
		public UnityEventAutoCallbackEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAD0-0x0000000183D4EAE0
		public void SetEvent(MemberInfo newMember, object instance = null) {} // 0x0000000189334FFC-0x0000000189335084
		protected override void RegisterPorts() {} // 0x0000000189334CC0-0x0000000189334FFC
		public override void OnGraphStarted() {} // 0x00000001893349FC-0x0000000189334C0C
		public override void OnGraphStoped() {} // 0x0000000189334C0C-0x0000000189334CC0
		private void OnEventRaised(params object[] args) {} // 0x0000000189334998-0x00000001893349FC
	}

	[Category("Events/Custom")]
	[Description("Register a callback on a UnityEvent.\nWhen that event is raised, this node will get called.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(UnityEventBase) })]
	[Name("Unity Event Callback", 3)]
	public class UnityEventCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 47241
	{
		// Fields
		[ExposeField]
		[GatherPortsCallback]
		[SerializeField]
		[Tooltip("If enabled, registration will be handled on graph Enable/Disable automatically")]
		protected bool _autoHandleRegistration; // 0xB0
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB8
		private object[] argValues; // 0xC0
		private ValueInput eventInput; // 0xC8
		private FlowOutput flowCallback; // 0xD0
		private ReflectedUnityEvent reflectedEvent; // 0xD8
	
		// Properties
		private System.Type eventType { get => default; set {} } // 0x0000000189321374-0x0000000189321388 0x0000000189335AC4-0x0000000189335B74
		public bool autoHandleRegistration { get => default; } // 0x0000000181151530-0x0000000181151540 
	
		// Constructors
		public UnityEventCallbackEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4E750-0x0000000183D4E760
		public override void OnGraphStarted() {} // 0x0000000189335288-0x00000001893352D0
		public override void OnGraphStoped() {} // 0x00000001893352D0-0x0000000189335318
		protected override void RegisterPorts() {} // 0x0000000189335408-0x00000001893358C4
		private void Register(Flow f = default) {} // 0x00000001893358C4-0x00000001893359EC
		private void Unregister(Flow f = default) {} // 0x00000001893359EC-0x0000000189335AC4
		private void OnEventRaised(params object[] args) {} // 0x0000000189320B00-0x0000000189320B64
		public override System.Type GetNodeWildDefinitionType() => default; // 0x0000000189335238-0x0000000189335288
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000189335318-0x0000000189335408
	}

	[Category("Events")]
	[Color("ff5c5c")]
	[ExecutionPriority(1)]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	public abstract class EventNode : FlowNode // TypeDefIndex: 47242
	{
		// Properties
		public override string name { get; } // 0x0000000189324FAC-0x0000000189325008 
	
		// Constructors
		protected EventNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class EventNode<T> : EventNode // TypeDefIndex: 47243
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

	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class RouterEventNode<T> : EventNode // TypeDefIndex: 47245
		where T : Component
	{
		// Fields
		public TargetMode targetMode;
		[ShowIf("targetMode", 0)]
		public BBParameter<T> target;
		[ShowIf("targetMode", 1)]
		public BBParameter<List<T>> targets;
	
		// Properties
		public override string name { get; }
	
		// Nested types
		public enum TargetMode // TypeDefIndex: 47244
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

	[Category("Events/Graph")]
	[Description("Called only once and the first time the Graph is enabled.\nUse this for initialization of this graph.")]
	[ExecutionPriority(10)]
	[Name("On Awake", 10)]
	public class ConstructionEvent : EventNode // TypeDefIndex: 47246
	{
		// Fields
		private FlowOutput awake; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public ConstructionEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x0000000189323ED4-0x0000000189323F34
		protected override void RegisterPorts() {} // 0x0000000189323F34-0x0000000189323F98
	}

	[Category("Events/Graph")]
	[Description("Called whenever the Graph is Disabled")]
	[ExecutionPriority(4)]
	[Name("On Disable", 4)]
	public class DisableEvent : EventNode // TypeDefIndex: 47247
	{
		// Fields
		private FlowOutput disable; // 0xB0
	
		// Constructors
		public DisableEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStoped() {} // 0x000000018931E82C-0x000000018931E87C
		protected override void RegisterPorts() {} // 0x0000000189324BEC-0x0000000189324C50
	}

	[Category("Events/Graph")]
	[Description("Called whenever the Graph is enabled.")]
	[ExecutionPriority(9)]
	[Name("On Enable", 9)]
	public class EnableEvent : EventNode // TypeDefIndex: 47248
	{
		// Fields
		private FlowOutput enable; // 0xB0
	
		// Constructors
		public EnableEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018931E82C-0x000000018931E87C
		protected override void RegisterPorts() {} // 0x0000000189324F48-0x0000000189324FAC
	}

	[Category("Events/Graph")]
	[Description("Called every fixed framerate frame, which should be used when dealing with Physics")]
	[ExecutionPriority(5)]
	[Name("On Fixed Update", 5)]
	public class FixedUpdateEvent : EventNode // TypeDefIndex: 47249
	{
		// Fields
		private FlowOutput fixedUpdate; // 0xB0
	
		// Constructors
		public FixedUpdateEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189325328-0x000000018932538C
		public override void OnGraphStarted() {} // 0x00000001893251F8-0x0000000189325290
		public override void OnGraphStoped() {} // 0x0000000189325290-0x0000000189325328
		private void FixedUpdate() {} // 0x000000018931E82C-0x000000018931E87C
	}

	[Category("Events/Graph")]
	[Description("Called per-frame, but after normal Update")]
	[ExecutionPriority(6)]
	[Name("On Late Update", 6)]
	public class LateUpdateEvent : EventNode // TypeDefIndex: 47250
	{
		// Fields
		private FlowOutput lateUpdate; // 0xB0
	
		// Constructors
		public LateUpdateEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932B314-0x000000018932B378
		public override void OnGraphStarted() {} // 0x000000018932B1E4-0x000000018932B27C
		public override void OnGraphStoped() {} // 0x000000018932B27C-0x000000018932B314
		private void LateUpdate() {} // 0x000000018931E82C-0x000000018931E87C
	}

	[Category("Events/Graph")]
	[Description("Called only once and the first time the Graph is enabled.\nThis is called after all OnAwake events of all graphs and after OnEnable events of this graph.")]
	[ExecutionPriority(8)]
	[Name("On Start", 8)]
	public class StartEvent : EventNode // TypeDefIndex: 47251
	{
		// Fields
		private FlowOutput start; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public StartEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018932FC94-0x000000018932FD78
		private void OnStartCallback() {} // 0x000000018932FD78-0x000000018932FDF0
		protected override void RegisterPorts() {} // 0x000000018932FDF0-0x000000018932FE54
	}

	[Category("Events/Graph")]
	[Description("Called per-frame.\nUpdate Interval optionally determines the period in seconds every which update is called. Leave at 0 to call update per-frame as normal.")]
	[ExecutionPriority(7)]
	[Name("On Update", 7)]
	public class UpdateEvent : EventNode, IUpdatable // TypeDefIndex: 47252
	{
		// Fields
		public BBParameter<float> updateInterval; // 0xB0
		private FlowOutput update; // 0xB8
		private float lastUpdatedTime; // 0xC0
	
		// Constructors
		public UpdateEvent() {} // 0x0000000189335D00-0x0000000189335D58
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189335B74-0x0000000189335BD8
		public override void OnGraphStarted() {} // 0x0000000183D71B50-0x0000000183D71B60
		public void Update() {} // 0x0000000189335BD8-0x0000000189335D00
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls out when Horizontal or Vertical Input Axis is not zero")]
	[Name("Input Axis (Preset)", 0)]
	[Obsolete("Use Input Axis")]
	public class InputAxisEvent : EventNode, IUpdatable // TypeDefIndex: 47253
	{
		// Fields
		private FlowOutput o; // 0xB0
		private float horizontal; // 0xB8
		private float vertical; // 0xBC
		private bool calledLastFrame; // 0xC0
	
		// Constructors
		public InputAxisEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932A030-0x000000018932A18C
		public void Update() {} // 0x000000018932A18C-0x000000018932A2D0
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls respective outputs when the defined Button is pressed down, held down or released.\nButtons are configured in Unity Input Manager.")]
	[Name("Input Button", 0)]
	public class InputButtonEvents : EventNode, IUpdatable // TypeDefIndex: 47254
	{
		// Fields
		[RequiredField]
		public BBParameter<string> buttonName; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018932A544-0x000000018932A594 
	
		// Constructors
		public InputButtonEvents() {} // 0x000000018932A4DC-0x000000018932A544
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932A2D0-0x000000018932A3A4
		public void Update() {} // 0x000000018932A3A4-0x000000018932A4DC
	}

	[Category("Events/Input (Legacy System)")]
	[Description("You are free to define any Input Axis in this node.\nAxis can be set in \'Project Settings/Input\'.\nCalls Out when either of the Axis defined is not zero")]
	[HasRefreshButton]
	[Name("Input Axis", 0)]
	public class InputCustomAxisEvent : EventNode, IUpdatable // TypeDefIndex: 47256
	{
		// Fields
		public BBParameter<List<string>> axis; // 0xB0
		private float[] axisValues; // 0xB8
		private bool calledLastFrame; // 0xC0
		private FlowOutput o; // 0xC8
	
		// Constructors
		public InputCustomAxisEvent() {} // 0x000000018932A99C-0x000000018932AA8C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932A594-0x000000018932A7FC
		public void Update() {} // 0x000000018932A7FC-0x000000018932A99C
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls respective outputs when the defined keyboard key is pressed down, held down or released")]
	[Name("Keyboard Key", 0)]
	public class KeyboardEvents : EventNode, IUpdatable // TypeDefIndex: 47257
	{
		// Fields
		public BBParameter<KeyCode> keyCode; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018932B194-0x000000018932B1E4 
	
		// Constructors
		public KeyboardEvents() {} // 0x000000018932B13C-0x000000018932B194
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932AF34-0x000000018932B008
		public void Update() {} // 0x000000018932B008-0x000000018932B13C
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Called when the specified mouse button is clicked down, held or released")]
	[Name("Mouse Button", 0)]
	public class MouseEvents : EventNode, IUpdatable // TypeDefIndex: 47259
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput pressed; // 0xC0
		private FlowOutput up; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018932CD1C-0x000000018932CD6C 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 47258
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MouseEvents() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932CB14-0x000000018932CBE8
		public void Update() {} // 0x000000018932CBE8-0x000000018932CD1C
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Called when any collider is clicked with the specified mouse button. PickInfo contains the information of the raycast event")]
	[Name("Mouse Pick", 0)]
	public class MousePickEvent : EventNode, IUpdatable // TypeDefIndex: 47261
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		public BBParameter<LayerMask> mask; // 0xB8
		private FlowOutput o; // 0xC0
		private RaycastHit hit; // 0xC8
	
		// Properties
		public override string name { get => default; } // 0x000000018932D030-0x000000018932D080 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 47260
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MousePickEvent() {} // 0x000000018932CFC0-0x000000018932D030
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932CD6C-0x000000018932CE5C
		public void Update() {} // 0x000000018932CE5C-0x000000018932CFC0
	}

	[Category("Events/Object")]
	[Description("Calls Animator based events. Note that using this node will override root motion as usual, but you can call \'Apply Builtin Root Motion\' to get it back.")]
	[Name("Animator", 0)]
	public class AnimatorEvents : RouterEventNode<Animator> // TypeDefIndex: 47262
	{
		// Fields
		private FlowOutput onAnimatorMove; // 0xC8
		private FlowOutput onAnimatorIK; // 0xD0
		private Animator receiver; // 0xD8
		private int layerIndex; // 0xE0
	
		// Constructors
		public AnimatorEvents() {} // 0x000000018931E584-0x000000018931E5B8
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018931E214-0x000000018931E3C4
		protected override void Subscribe(EventRouter router) {} // 0x000000018931E3C4-0x000000018931E4A4
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018931E4A4-0x000000018931E584
		private void OnAnimatorMove(ParadoxNotion.EventData msg) {} // 0x000000018931E170-0x000000018931E214
		private void OnAnimatorIK(EventData<int> msg) {} // 0x000000018931E0A8-0x000000018931E170
	}

	[Category("Events/Object")]
	[Description("Called when the Character Controller hits a collider while performing a Move")]
	[Name("Character Controller", 0)]
	public class CharacterControllerEvents : RouterEventNode<CharacterController>, IUpdatable // TypeDefIndex: 47263
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
		public CharacterControllerEvents() {} // 0x0000000189321CD4-0x0000000189321D08
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x0000000189321784-0x0000000189321874
		void IUpdatable.Update() {} // 0x0000000189321438-0x00000001893216B0
		protected override void RegisterPorts() {} // 0x0000000189321874-0x0000000189321B60
		protected override void Subscribe(EventRouter router) {} // 0x0000000189321B60-0x0000000189321BF0
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189321C44-0x0000000189321CD4
		private void OnControllerColliderHit(EventData<ControllerColliderHit> msg) {} // 0x00000001893216B0-0x0000000189321784
	}

	[Category("Events/Object")]
	[Description("Called when 2D Collision based events happen on target and expose collision information")]
	[Name("Collision2D", 0)]
	public class Collision2DEvents_Rigidbody : RouterEventNode<Rigidbody2D> // TypeDefIndex: 47264
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents_Rigidbody() {} // 0x0000000189322C44-0x0000000189322C78
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893226BC-0x00000001893229A8
		protected override void Subscribe(EventRouter router) {} // 0x00000001893229A8-0x0000000189322AC4
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189322B28-0x0000000189322C44
		private void OnCollisionEnter2D(EventData<Collision2D> msg) {} // 0x0000000189322440-0x0000000189322514
		private void OnCollisionStay2D(EventData<Collision2D> msg) {} // 0x00000001893225E8-0x00000001893226BC
		private void OnCollisionExit2D(EventData<Collision2D> msg) {} // 0x0000000189322514-0x00000001893225E8
	}

	[Category("Events/Object")]
	[Description("Called when 2D Collision based events happen on target and expose collision information")]
	[DoNotList]
	[Name("Collision2D", 0)]
	public class Collision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 47265
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents() {} // 0x0000000189322EB0-0x0000000189322EE4
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189322170-0x0000000189322440
		protected override void Subscribe(EventRouter router) {} // 0x0000000189322C78-0x0000000189322D94
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189322D94-0x0000000189322EB0
		private void OnCollisionEnter2D(EventData<Collision2D> msg) {} // 0x0000000189321EF4-0x0000000189321FC8
		private void OnCollisionStay2D(EventData<Collision2D> msg) {} // 0x000000018932209C-0x0000000189322170
		private void OnCollisionExit2D(EventData<Collision2D> msg) {} // 0x0000000189321FC8-0x000000018932209C
	}

	[Category("Events/Object")]
	[Description("Called when Collision based events happen on target and expose collision information")]
	[Name("Collision", 0)]
	public class CollisionEvents_Rigidbody : RouterEventNode<Rigidbody> // TypeDefIndex: 47266
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents_Rigidbody() {} // 0x0000000189323C34-0x0000000189323C68
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893236AC-0x0000000189323998
		protected override void Subscribe(EventRouter router) {} // 0x0000000189323998-0x0000000189323AB4
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189323B18-0x0000000189323C34
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg) {} // 0x0000000189323430-0x0000000189323504
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg) {} // 0x00000001893235D8-0x00000001893236AC
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg) {} // 0x0000000189323504-0x00000001893235D8
	}

	[Category("Events/Object")]
	[Description("Called when Collision based events happen on target and expose collision information")]
	[DoNotList]
	[Name("Collision", 0)]
	public class CollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 47267
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents() {} // 0x0000000189323EA0-0x0000000189323ED4
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189323160-0x0000000189323430
		protected override void Subscribe(EventRouter router) {} // 0x0000000189323C68-0x0000000189323D84
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189323D84-0x0000000189323EA0
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg) {} // 0x0000000189322EE4-0x0000000189322FB8
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg) {} // 0x000000018932308C-0x0000000189323160
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg) {} // 0x0000000189322FB8-0x000000018932308C
	}

	[Category("Events/Object")]
	[Description("Called when mouse based operations happen on target 2D collider")]
	[Name("Mouse2D", 0)]
	public class MouseAgent2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 47268
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
		public MouseAgent2DEvents() {} // 0x000000018932BF60-0x000000018932BF94
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932B798-0x000000018932BA08
		protected override void Subscribe(EventRouter router) {} // 0x000000018932BB78-0x000000018932BD6C
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018932BD6C-0x000000018932BF60
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x000000018932B4D8-0x000000018932B588
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x000000018932B638-0x000000018932B6E8
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018932B588-0x000000018932B638
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x000000018932B378-0x000000018932B428
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018932B6E8-0x000000018932B798
		private void OnMouseDrag(ParadoxNotion.EventData msg) {} // 0x000000018932B428-0x000000018932B4D8
		private void StoreHit() {} // 0x000000018932BA08-0x000000018932BB78
	}

	[Category("Events/Object")]
	[Description("Called when mouse based operations happen on target collider")]
	[Name("Mouse", 0)]
	public class MouseAgentEvents : RouterEventNode<Collider> // TypeDefIndex: 47269
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
		public MouseAgentEvents() {} // 0x000000018932CAE0-0x000000018932CB14
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932C3B4-0x000000018932C624
		protected override void Subscribe(EventRouter router) {} // 0x000000018932C6F8-0x000000018932C8EC
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018932C8EC-0x000000018932CAE0
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x000000018932C0F4-0x000000018932C1A4
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x000000018932C254-0x000000018932C304
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018932C1A4-0x000000018932C254
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x000000018932BF94-0x000000018932C044
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018932C304-0x000000018932C3B4
		private void OnMouseDrag(ParadoxNotion.EventData msg) {} // 0x000000018932C044-0x000000018932C0F4
		private void StoreHit() {} // 0x000000018932C624-0x000000018932C6F8
	}

	[Category("Events/Object")]
	[Description("OnEnable, OnDisable and OnDestroy callback events for target object")]
	[Name("Object State", 0)]
	public class ObjectStateEvents : RouterEventNode<Transform> // TypeDefIndex: 47270
	{
		// Fields
		private FlowOutput onEnable; // 0xC8
		private FlowOutput onDisable; // 0xD0
		private FlowOutput onDestroy; // 0xD8
		private GameObject receiver; // 0xE0
	
		// Constructors
		public ObjectStateEvents() {} // 0x000000018932D634-0x000000018932D668
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932D29C-0x000000018932D3FC
		protected override void Subscribe(EventRouter router) {} // 0x000000018932D3FC-0x000000018932D518
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018932D518-0x000000018932D634
		private void OnEnable(ParadoxNotion.EventData msg) {} // 0x000000018932D1E8-0x000000018932D29C
		private void OnDisable(ParadoxNotion.EventData msg) {} // 0x000000018932D134-0x000000018932D1E8
		private void OnDestroy(ParadoxNotion.EventData msg) {} // 0x000000018932D080-0x000000018932D134
	}

	[Category("Events/Object")]
	[Description("Calls Gizmos")]
	[Name("Draw Gizmos", 0)]
	public class DrawGizmosEvents : RouterEventNode<Transform> // TypeDefIndex: 47271
	{
		// Fields
		private FlowOutput onDrawGizmos; // 0xC8
		private GameObject receiver; // 0xD0
	
		// Constructors
		public DrawGizmosEvents() {} // 0x0000000189324F14-0x0000000189324F48
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189324D04-0x0000000189324DF4
		protected override void Subscribe(EventRouter router) {} // 0x0000000189324DF4-0x0000000189324E84
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189324E84-0x0000000189324F14
		private void OnDrawGizmos(ParadoxNotion.EventData msg) {} // 0x0000000189324C50-0x0000000189324D04
	}

	[Category("Events/Object")]
	[Description("Called when any Particle System collided with the target collider 2D object")]
	[Name("Particle Collision 2D", 0)]
	public class ParticleCollision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 47272
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider2D receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollision2DEvents() {} // 0x000000018932DD40-0x000000018932DD74
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932D810-0x000000018932DAC4
		protected override void Subscribe(EventRouter router) {} // 0x000000018932DAC4-0x000000018932DB54
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018932DCB0-0x000000018932DD40
		private void OnParticleCollision(EventData<GameObject> msg) {} // 0x000000018932D668-0x000000018932D810
	}

	[Category("Events/Object")]
	[Description("Called when any Particle System collided with the target collider object")]
	[Name("Particle Collision", 0)]
	public class ParticleCollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 47273
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollisionEvents() {} // 0x000000018932E44C-0x000000018932E480
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018932DF1C-0x000000018932E1D0
		protected override void Subscribe(EventRouter router) {} // 0x000000018932E1D0-0x000000018932E260
		protected override void UnSubscribe(EventRouter router) {} // 0x000000018932E3BC-0x000000018932E44C
		private void OnParticleCollision(EventData<GameObject> msg) {} // 0x000000018932DD74-0x000000018932DF1C
	}

	[Category("Events/Object")]
	[Description("Events relevant to transform changes")]
	public class TransformEvents : RouterEventNode<Transform> // TypeDefIndex: 47274
	{
		// Fields
		private FlowOutput onParentChanged; // 0xC8
		private FlowOutput onChildrenChanged; // 0xD0
		private Transform receiver; // 0xD8
		private Transform parent; // 0xE0
		private IEnumerable<Transform> children; // 0xE8
	
		// Constructors
		public TransformEvents() {} // 0x0000000189330414-0x0000000189330448
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189330054-0x000000018933026C
		protected override void Subscribe(EventRouter router) {} // 0x000000018933026C-0x0000000189330340
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189330340-0x0000000189330414
		private void OnTransformParentChanged(ParadoxNotion.EventData msg) {} // 0x000000018932FF54-0x0000000189330054
		private void OnTransformChildrenChanged(ParadoxNotion.EventData msg) {} // 0x000000018932FE54-0x000000018932FF54
	}

	[Category("Events/Object")]
	[Description("Called when 2D Trigger based event happen on target when it has either a Collider2D or a Rigidbody2D")]
	[Name("Trigger2D", 0)]
	public class Trigger2DEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 47275
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents_Transform() {} // 0x000000018933108C-0x00000001893310C0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189330C6C-0x0000000189330E54
		protected override void Subscribe(EventRouter router) {} // 0x0000000189330E54-0x0000000189330F70
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189330F70-0x000000018933108C
		private void OnTriggerEnter2D(EventData<Collider2D> msg) {} // 0x00000001893309CC-0x0000000189330AAC
		private void OnTriggerStay2D(EventData<Collider2D> msg) {} // 0x0000000189330B8C-0x0000000189330C6C
		private void OnTriggerExit2D(EventData<Collider2D> msg) {} // 0x0000000189330AAC-0x0000000189330B8C
	}

	[Category("Events/Object")]
	[Description("Called when 2D Trigger based event happen on target")]
	[DoNotList]
	[Name("Trigger2D", 0)]
	public class Trigger2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 47276
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents() {} // 0x00000001893311DC-0x0000000189331210
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893306E8-0x00000001893308B0
		protected override void Subscribe(EventRouter router) {} // 0x00000001893308B0-0x00000001893309CC
		protected override void UnSubscribe(EventRouter router) {} // 0x00000001893310C0-0x00000001893311DC
		private void OnTriggerEnter2D(EventData<Collider2D> msg) {} // 0x0000000189330448-0x0000000189330528
		private void OnTriggerStay2D(EventData<Collider2D> msg) {} // 0x0000000189330608-0x00000001893306E8
		private void OnTriggerExit2D(EventData<Collider2D> msg) {} // 0x0000000189330528-0x0000000189330608
	}

	[Category("Events/Object")]
	[Description("Called when Trigger based event happen on target when it has either a Collider or a Rigidbody")]
	[Name("Trigger", 0)]
	public class TriggerEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 47277
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents_Transform() {} // 0x0000000189331E54-0x0000000189331E88
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189331A34-0x0000000189331C1C
		protected override void Subscribe(EventRouter router) {} // 0x0000000189331C1C-0x0000000189331D38
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189331D38-0x0000000189331E54
		private void OnTriggerEnter(EventData<Collider> msg) {} // 0x0000000189331794-0x0000000189331874
		private void OnTriggerStay(EventData<Collider> msg) {} // 0x0000000189331954-0x0000000189331A34
		private void OnTriggerExit(EventData<Collider> msg) {} // 0x0000000189331874-0x0000000189331954
	}

	[Category("Events/Object")]
	[Description("Called when Trigger based event happen on target")]
	[DoNotList]
	[Name("Trigger", 0)]
	public class TriggerEvents : RouterEventNode<Collider> // TypeDefIndex: 47278
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents() {} // 0x0000000189331FA4-0x0000000189331FD8
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893314B0-0x0000000189331678
		protected override void Subscribe(EventRouter router) {} // 0x0000000189331678-0x0000000189331794
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189331E88-0x0000000189331FA4
		private void OnTriggerEnter(EventData<Collider> msg) {} // 0x0000000189331210-0x00000001893312F0
		private void OnTriggerStay(EventData<Collider> msg) {} // 0x00000001893313D0-0x00000001893314B0
		private void OnTriggerExit(EventData<Collider> msg) {} // 0x00000001893312F0-0x00000001893313D0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Button is clicked")]
	[Name("UI Button", 0)]
	public class UIButtonEvent : EventNode<UnityEngine.UI.Button> // TypeDefIndex: 47279
	{
		// Fields
		private FlowOutput o; // 0xB8
	
		// Constructors
		public UIButtonEvent() {} // 0x0000000189332F40-0x0000000189332F74
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x0000000189332D18-0x0000000189332E08
		public override void OnGraphStoped() {} // 0x0000000189332C44-0x0000000189332D18
		protected override void RegisterPorts() {} // 0x0000000189332E08-0x0000000189332EF8
		private void OnClick() {} // 0x0000000189332BF4-0x0000000189332C44
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Dropdown value changed.")]
	[Name("UI Dropdown", 0)]
	public class UIDropdownEvent : EventNode<Dropdown> // TypeDefIndex: 47280
	{
		// Fields
		private FlowOutput o; // 0xB8
		private int value; // 0xC0
	
		// Constructors
		public UIDropdownEvent() {} // 0x0000000189333368-0x000000018933339C
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x0000000189333058-0x0000000189333158
		public override void OnGraphStoped() {} // 0x0000000189332F74-0x0000000189333058
		protected override void RegisterPorts() {} // 0x00000001893331AC-0x0000000189333320
		private void OnValueChanged(int value) {} // 0x0000000189333158-0x00000001893331AC
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Dropdown value changed.")]
	[Name("UI Field Input", 0)]
	public class UIInputFieldEvent : EventNode<InputField> // TypeDefIndex: 47281
	{
		// Fields
		private FlowOutput onValueChanged; // 0xB8
		private FlowOutput onEndEdit; // 0xC0
		private string value; // 0xC8
	
		// Constructors
		public UIInputFieldEvent() {} // 0x0000000189333950-0x0000000189333984
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x000000018933356C-0x00000001893336F4
		public override void OnGraphStoped() {} // 0x0000000189333400-0x000000018933356C
		protected override void RegisterPorts() {} // 0x0000000189333758-0x0000000189333908
		private void OnValueChanged(string value) {} // 0x00000001893336F4-0x0000000189333758
		private void OnEndEdit(string value) {} // 0x000000018933339C-0x0000000189333400
	}

	[Category("Events/Object/UI")]
	[Description("Calls UI Pointer based events on target. The Unity Event system has to be set through \'GameObject/UI/Event System\'")]
	[Name("UI Pointer", 0)]
	public class UIPointerEvents : RouterEventNode<Transform> // TypeDefIndex: 47283
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
	
		// Constructors
		public UIPointerEvents() {} // 0x0000000189334964-0x0000000189334998
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893340D0-0x0000000189334408
		protected override void Subscribe(EventRouter router) {} // 0x0000000189334408-0x0000000189334688
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189334688-0x0000000189334908
		private void OnPointerDown(EventData<PointerEventData> msg) {} // 0x0000000189333A68-0x0000000189333B6C
		private void OnPointerUp(EventData<PointerEventData> msg) {} // 0x0000000189333FE0-0x00000001893340D0
		[IteratorStateMachine(typeof(_UpdatePressed_d__17))]
		private IEnumerator UpdatePressed() => default; // 0x0000000189334908-0x0000000189334964
		private void OnPointerEnter(EventData<PointerEventData> msg) {} // 0x0000000189333D34-0x0000000189333E18
		private void OnPointerExit(EventData<PointerEventData> msg) {} // 0x0000000189333E18-0x0000000189333EFC
		private void OnPointerClick(EventData<PointerEventData> msg) {} // 0x0000000189333984-0x0000000189333A68
		private void OnPointerDrag(EventData<PointerEventData> msg) {} // 0x0000000189333B6C-0x0000000189333C50
		private void OnPointerDrop(EventData<PointerEventData> msg) {} // 0x0000000189333C50-0x0000000189333D34
		private void OnPointerScroll(EventData<PointerEventData> msg) {} // 0x0000000189333EFC-0x0000000189333FE0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Scrollbar value changed.")]
	[Name("UI Scrollbar", 0)]
	public class UIScrollbarEvent : EventNode<Scrollbar> // TypeDefIndex: 47284
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UIScrollbarEvent() {} // 0x0000000189348298-0x00000001893482CC
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x0000000189347F84-0x0000000189348084
		public override void OnGraphStoped() {} // 0x0000000189347EA0-0x0000000189347F84
		protected override void RegisterPorts() {} // 0x00000001893480DC-0x0000000189348250
		private void OnValueChanged(float value) {} // 0x0000000189348084-0x00000001893480DC
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Slider value changed.")]
	[Name("UI Slider", 0)]
	public class UISliderEvent : EventNode<Slider> // TypeDefIndex: 47285
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UISliderEvent() {} // 0x000000018934866C-0x00000001893486A0
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x00000001893483B0-0x00000001893484B0
		public override void OnGraphStoped() {} // 0x00000001893482CC-0x00000001893483B0
		protected override void RegisterPorts() {} // 0x00000001893484B0-0x0000000189348624
		private void OnValueChanged(float value) {} // 0x0000000189348084-0x00000001893480DC
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Toggle value changed.")]
	[Name("UI Toggle", 0)]
	public class UIToggleEvent : EventNode<UnityEngine.UI.Toggle> // TypeDefIndex: 47286
	{
		// Fields
		private FlowOutput o; // 0xB8
		private bool state; // 0xC0
	
		// Constructors
		public UIToggleEvent() {} // 0x0000000189348A94-0x0000000189348AC8
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x0000000189348784-0x0000000189348884
		public override void OnGraphStoped() {} // 0x00000001893486A0-0x0000000189348784
		protected override void RegisterPorts() {} // 0x00000001893488D8-0x0000000189348A4C
		private void OnValueChanged(bool state) {} // 0x0000000189348884-0x00000001893488D8
	}

	[Category("Events/Object")]
	[Description("Calls events based on object\'s render visibility")]
	[Name("Visibility", 0)]
	public class VisibilityEvents : RouterEventNode<Transform> // TypeDefIndex: 47287
	{
		// Fields
		private FlowOutput onVisible; // 0xC8
		private FlowOutput onInvisible; // 0xD0
		private GameObject receiver; // 0xD8
	
		// Constructors
		public VisibilityEvents() {} // 0x00000001893495FC-0x0000000189349630
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018934932C-0x0000000189349454
		protected override void Subscribe(EventRouter router) {} // 0x0000000189349454-0x0000000189349528
		protected override void UnSubscribe(EventRouter router) {} // 0x0000000189349528-0x00000001893495FC
		private void OnBecameVisible(ParadoxNotion.EventData msg) {} // 0x0000000189349278-0x000000018934932C
		private void OnBecameInvisible(ParadoxNotion.EventData msg) {} // 0x00000001893491C4-0x0000000189349278
	}

	[Category("Events/Other")]
	[Description("Checks the condition boolean input per frame and calls outputs when the value has changed")]
	[Name("Conditional Event", 0)]
	public class ConditionalUpdateEvent : EventNode, IUpdatable // TypeDefIndex: 47288
	{
		// Fields
		private FlowOutput becameTrue; // 0xB0
		private FlowOutput becameFalse; // 0xB8
		private ValueInput<bool> condition; // 0xC0
		private bool lastState; // 0xC8
	
		// Constructors
		public ConditionalUpdateEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189337F28-0x000000018933800C
		public void Update() {} // 0x000000018933800C-0x00000001893380F8
	}

	[Category("Events/Other")]
	[Description("Use to debug send a Flow Signal in PlayMode Only")]
	public class DebugEvent : EventNode // TypeDefIndex: 47289
	{
		// Constructors
		public DebugEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("Events/Other")]
	[Description("Calls Hi when curve value is greater than 0, else calls Low.\nThe curve is evaluated over time and it\'s evaluated value is exposed")]
	[Name("OSC Pulse", 0)]
	public class OscillatorEvent : EventNode, IUpdatable // TypeDefIndex: 47290
	{
		// Fields
		public BBParameter<AnimationCurve> curve; // 0xB0
		private float time; // 0xB8
		private float value; // 0xBC
		private FlowOutput hi; // 0xC0
		private FlowOutput low; // 0xC8
	
		// Constructors
		public OscillatorEvent() {} // 0x000000018933D1C8-0x000000018933D378
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933CFA8-0x000000018933D0D0
		public override void OnGraphStarted() {} // 0x0000000183D71C20-0x0000000183D71C30
		public void Update() {} // 0x000000018933D0D0-0x000000018933D1C8
	}

	[Category("Events/Other")]
	[Description("Called when the target variable change. (Not whenever it is set).")]
	[Name("On Variable Change", 0)]
	public class VariableChangedEvent : EventNode // TypeDefIndex: 47291
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter targetVariable; // 0xB0
		private FlowOutput fOut; // 0xB8
		private object newValue; // 0xC0
	
		// Properties
		public override string name { get => default; } // 0x0000000189348E34-0x0000000189348E84 
	
		// Constructors
		public VariableChangedEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189348AC8-0x0000000189348BBC
		public override void OnGraphStoped() {} // 0x0000000189348BBC-0x0000000189348C70
		protected override void RegisterPorts() {} // 0x0000000189348D28-0x0000000189348E34
		private void OnValueChanged(object value) {} // 0x0000000189348C70-0x0000000189348CD4
		private void OnVariableRefChange(Variable newVarRef) {} // 0x0000000189348CD4-0x0000000189348D28
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filter the Flow based on a percentage between min and max.\nFor example: With Min = 0, Max = 1 and Percentage = 0.5, the chance is 50%.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(float) })]
	public class Chance : FlowControlNode // TypeDefIndex: 47293
	{
		// Constructors
		public Chance() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189337C74-0x0000000189337E88
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filters the flow execution so that it can\'t be called very frequently")]
	[ContextDefinedInputs(new System.Type[1] {typeof(float) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(float) })]
	public class Cooldown : FlowControlNode // TypeDefIndex: 47295
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
		public override string name { get => default; } // 0x00000001893385B8-0x000000018933863C 
	
		// Constructors
		public Cooldown() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018933823C-0x0000000189338258
		public override void OnGraphStoped() {} // 0x0000000189338168-0x00000001893381B0
		protected override void RegisterPorts() {} // 0x0000000189338258-0x0000000189338594
		private void Begin(Flow f) {} // 0x00000001893380F8-0x0000000189338168
		private void Cancel(Flow f) {} // 0x0000000189338168-0x00000001893381B0
		[IteratorStateMachine(typeof(_CountDown_d__14))]
		private IEnumerator CountDown(Flow f) => default; // 0x00000001893381B0-0x000000018933823C
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filters Out to be called only once. After the first call, Out is no longer called until Reset is called")]
	public class DoOnce : FlowControlNode // TypeDefIndex: 47297
	{
		// Fields
		private bool called; // 0xB0
	
		// Constructors
		public DoOnce() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000183D71B70-0x0000000183D71B80
		protected override void RegisterPorts() {} // 0x0000000189339E44-0x0000000189339FBC
	}

	[Category("Variables/Flow")]
	[Description("Reads a named parameter from the incomming Flow and returns it\'s value.\nFlow parameters can be set with a WriteFlowParameter node.\nFlow parameters are temporary variables that exist only in the context of the same Flow.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Read Flow Param", 0)]
	public class ReadFlowParameter<T> : FlowControlNode // TypeDefIndex: 47299
	{
		// Fields
		private T flowValue;
	
		// Constructors
		public ReadFlowParameter() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Variables/Flow")]
	[Description("Writes (or creates) a named parameter to the incomming Flow, which you can later read with a ReadFlowParameter node.\nFlow parameters are temporary variables that exist only in the context of the same Flow.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[Name("Write Flow Param", 0)]
	public class WriteFlowParameter<T> : FlowControlNode // TypeDefIndex: 47301
	{
		// Constructors
		public WriteFlowParameter() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Flow Controllers/Flow Convert")]
	[Description("Convert a Flow signal to boolean value")]
	[DeserializeFrom("FlowCanvas.Nodes.Latch")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(bool) })]
	[Name("Latch Condition", 0)]
	public class LatchBool : FlowControlNode // TypeDefIndex: 47303
	{
		// Fields
		private bool latched; // 0xB0
	
		// Constructors
		public LatchBool() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933BAD0-0x000000018933BCD0
	}

	[Category("Flow Controllers/Flow Convert")]
	[Description("Convert a Flow signal to an integer value")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Latch Integer", 0)]
	public class LatchInt : FlowControlNode // TypeDefIndex: 47306
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private int latched; // 0xB4
	
		// Constructors
		public LatchInt() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933BCD0-0x000000018933BEC8
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Await all flow inputs to be called within the max allowed await time before Out is called.\n- If MaxAwaitTime is 0, then all inputs must be called at the same time.\n- If MaxAwaitTime is -1, then the await time is infinity.")]
	[Name("AND", 0)]
	public class ANDMerge : FlowControlNode // TypeDefIndex: 47308
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		public float maxAwaitTime; // 0xB4
		private FlowOutput fOut; // 0xB8
		private float[] calls; // 0xC0
		private int lastFrameCall; // 0xC8
	
		// Constructors
		public ANDMerge() {} // 0x00000001893363CC-0x00000001893363E0
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189336204-0x000000018933620C
		protected override void RegisterPorts() {} // 0x000000018933620C-0x0000000189336388
		private void Reset() {} // 0x0000000189336388-0x00000001893363CC
		private void Check(int index, Flow f) {} // 0x00000001893360F0-0x0000000189336204
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Await all flow inputs to be called within the max allowed await time.\n- If MaxAwaitTime is 0, then all inputs must be called at the same time.\n- If MaxAwaitTime is -1, then the await time is infinity.")]
	[Obsolete("Use AND")]
	public class AwaitAll : FlowControlNode // TypeDefIndex: 47310
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		public float maxAwaitTime; // 0xB4
		private FlowOutput fOut; // 0xB8
		private float[] calls; // 0xC0
		private int lastFrameCall; // 0xC8
	
		// Constructors
		public AwaitAll() {} // 0x00000001893368BC-0x00000001893368D8
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189336204-0x000000018933620C
		protected override void RegisterPorts() {} // 0x0000000189336740-0x00000001893368BC
		private void Reset() {} // 0x0000000189336388-0x00000001893363CC
		private void Check(int index, Flow f) {} // 0x00000001893360F0-0x0000000189336204
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Calls Out when either input is called, but only once per frame regardless of how many inputs are called.")]
	[Name("OR", 0)]
	public class ORMerge : FlowControlNode // TypeDefIndex: 47312
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private FlowOutput fOut; // 0xB8
		private int lastFrameCall; // 0xC0
	
		// Constructors
		public ORMerge() {} // 0x00000001893363CC-0x00000001893363E0
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933CD10-0x000000018933CE5C
		private void Check(int index, Flow f) {} // 0x000000018933CC9C-0x000000018933CD10
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Calls Out when either single Input is called, but no other is in the same frame.")]
	[Name("XOR", 0)]
	[Obsolete]
	public class XORMerge : FlowControlNode // TypeDefIndex: 47314
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private FlowOutput fOut; // 0xB8
		private int[] calls; // 0xC0
		private int lastFrameCall; // 0xC8
	
		// Constructors
		public XORMerge() {} // 0x00000001893363CC-0x00000001893363E0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189349CE4-0x0000000189349E60
		private void Check(int index, Flow f) {} // 0x0000000189349C04-0x0000000189349CE4
	}

	[Category("Flow Controllers")]
	[Color("bf7fff")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Flow) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	public abstract class FlowControlNode : FlowNode // TypeDefIndex: 47315
	{
		// Constructors
		protected FlowControlNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Can be used within a For Loop or For Each node, to Break the iteration.")]
	public class Break : FlowControlNode // TypeDefIndex: 47316
	{
		// Constructors
		public Break() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189337AA0-0x0000000189337B48
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Enumerate a value (usualy a list or array) for each of it\'s elements. Remember that you can also enumerate a Transform for it\'s children.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IEnumerable) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(object) })]
	public class ForEach : FlowControlNode // TypeDefIndex: 47318
	{
		// Fields
		private object currentObject; // 0xB0
		private int currentIndex; // 0xB8
		private bool broken; // 0xBC
		private ValueInput<IEnumerable> enumerableInput; // 0xC0
	
		// Constructors
		public ForEach() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933AD08-0x000000018933B004
		public override System.Type GetNodeWildDefinitionType() => default; // 0x000000018933AB74-0x000000018933ABC4
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x000000018933ABC4-0x000000018933AD08
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Enumerate a value (usualy a list or array) for each of it\'s elements")]
	[ExposeAsDefinition]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class ForEach<T> : FlowControlNode // TypeDefIndex: 47320
	{
		// Fields
		private T currentObject;
		private int currentIndex;
		private bool broken;
	
		// Constructors
		public ForEach() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Perform a for loop")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	public class ForLoop : FlowControlNode // TypeDefIndex: 47322
	{
		// Fields
		[Tooltip("If true, loop will start from last and decrease by increment towards start")]
		public bool reverse; // 0xB0
		private int current; // 0xB4
		private bool broken; // 0xB8
		private ValueInput<int> first; // 0xC0
		private ValueInput<int> last; // 0xC8
		private ValueInput<int> step; // 0xD0
	
		// Constructors
		public ForLoop() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933B004-0x000000018933B320
	}

	[Description("Use for organization.")]
	[Name("Identity", 100)]
	public class Dummy : FlowControlNode // TypeDefIndex: 47324
	{
		// Properties
		public override string name { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public Dummy() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189339FBC-0x000000018933A0C0
	}

	[Description("Stops and cease execution of the FlowSript")]
	public class Finish : FlowControlNode // TypeDefIndex: 47326
	{
		// Constructors
		public Finish() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933A534-0x000000018933A658
	}

	[Category("Flow Controllers/GOTO")]
	[Color("ff5c5c")]
	[Description("A Flow Control Label definition. Can be called with the GOTO node.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	[Name("GOTO Label Definition", 1)]
	public class GoToLabel : FlowControlNode, IEditorMenuCallbackReceiver // TypeDefIndex: 47327
	{
		// Fields
		[DelayedField]
		[Tooltip("The identifier name of the label")]
		public string identifier; // 0xB0
	
		// Properties
		[HideInInspector]
		public FlowOutput port { get; private set; } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001858AAF64-0x00000001858AAF78
		public override string name { get => default; } // 0x000000018933B488-0x000000018933B4E0 
	
		// Constructors
		public GoToLabel() {} // 0x000000018933B438-0x000000018933B488
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933B3D4-0x000000018933B438
	}

	[Description("Routes the Flow to the target GOTO label.")]
	[DoNotList]
	[ContextDefinedInputs(new System.Type[1] {typeof(Flow) })]
	public class GoToStatement : FlowControlNode, IHaveNodeReference // TypeDefIndex: 47328
	{
		// Fields
		[fsSerializeAs("_targetLabelUID")]
		public NodeReference<GoToLabel> _targetLabel; // 0xB0
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
		private GoToLabel target { get => default; } // 0x000000018933B718-0x000000018933B768 
		public override string name { get => default; } // 0x000000018933B688-0x000000018933B718 
	
		// Constructors
		public GoToStatement() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public void SetTarget(GoToLabel newTarget) {} // 0x000000018933B588-0x000000018933B614
		protected override void RegisterPorts() {} // 0x000000018933B4E0-0x000000018933B588
	}

	[Description("Utility node to merge the flow. It\'s exactly the same as connecting multiple Flow outputs to the same Flow input.")]
	[Name("Merge", 89)]
	public class Merge : FlowControlNode // TypeDefIndex: 47329
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Constructors
		public Merge() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933C7C0-0x000000018933C8BC
	}

	[Description("Split the Flow in multiple directions. Calls all outputs in the same frame but in order")]
	[Name("Split", 90)]
	public class Split : FlowControlNode // TypeDefIndex: 47331
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Constructors
		public Split() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189342064-0x0000000189342200
	}

	[Description("Similar to Try/Catch/Finally in code")]
	public class TryCatch : FlowControlNode // TypeDefIndex: 47333
	{
		// Constructors
		public TryCatch() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189343C14-0x0000000189343D80
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Start a Coroutine that will repeat until Break is signaled")]
	[Name("Coroutine", 0)]
	public class CoroutineState : FlowControlNode // TypeDefIndex: 47336
	{
		// Fields
		private bool active; // 0xB0
		private Coroutine coroutine; // 0xB8
	
		// Constructors
		public CoroutineState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStoped() {} // 0x000000018933870C-0x000000018933873C
		protected override void RegisterPorts() {} // 0x000000018933873C-0x000000018933890C
		[IteratorStateMachine(typeof(_DoRepeat_d__4))]
		private IEnumerator DoRepeat(FlowOutput fStart, FlowOutput fUpdate, FlowOutput fFinish, Flow f) => default; // 0x000000018933863C-0x000000018933870C
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Once called, will continuously call \'Do\' while the input boolean condition is true. Once condition becomes or is false, \'Done\' is called")]
	[ContextDefinedInputs(new System.Type[1] {typeof(bool) })]
	[Name("While True", 0)]
	public class While : FlowControlNode // TypeDefIndex: 47340
	{
		// Fields
		private Coroutine coroutine; // 0xB0
	
		// Constructors
		public While() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189349A20-0x0000000189349A38
		public override void OnGraphStoped() {} // 0x0000000189349A38-0x0000000189349A7C
		protected override void RegisterPorts() {} // 0x0000000189349A7C-0x0000000189349C04
		[IteratorStateMachine(typeof(_DoWhile_d__4))]
		private IEnumerator DoWhile(FlowOutput fUpdate, FlowOutput fFinish, Flow f, ValueInput<bool> condition) => default; // 0x0000000189349950-0x0000000189349A20
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the two input cases provided, based on a boolean Condition")]
	[ExposeAsDefinition]
	public class SelectOnBool<T> : FlowControlNode // TypeDefIndex: 47341
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
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on an Enum")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(Enum) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class SelectOnEnum<T> : FlowControlNode // TypeDefIndex: 47343
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type;
	
		// Properties
		private System.Type type { get => default; set {} }
	
		// Constructors
		public SelectOnEnum() {}
	
		// Methods
		protected override void RegisterPorts() {}
		public override System.Type GetNodeWildDefinitionType() => default;
		public override void OnPortConnected(Port port, Port otherPort) {}
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on an Integer")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(int) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class SelectOnInt<T> : FlowControlNode // TypeDefIndex: 47345
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount;
	
		// Constructors
		public SelectOnInt() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on a String")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(string) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[HasRefreshButton]
	public class SelectOnString<T> : FlowControlNode // TypeDefIndex: 47347
	{
		// Fields
		[Name("Cases", 0)]
		public List<string> stringCases;
	
		// Constructors
		public SelectOnString() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on a GameObject\'s Tag")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(GameObject) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[HasRefreshButton]
	public class SelectOnTag<T> : FlowControlNode // TypeDefIndex: 47349
	{
		// Fields
		[SerializeField]
		private string[] _tagNames;
	
		// Constructors
		public SelectOnTag() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Calls one random output each time In is called.")]
	[ContextDefinedOutputs(new System.Type[2] {typeof(Flow), typeof(int) })]
	[Name("Switch Random", 0)]
	public class Random : FlowControlNode // TypeDefIndex: 47351
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private int current; // 0xB4
	
		// Constructors
		public Random() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018933EF38-0x000000018933F160
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a conditional boolean value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(bool) })]
	[Name("Switch Condition", 0)]
	public class SwitchBool : FlowControlNode // TypeDefIndex: 47353
	{
		// Constructors
		public SwitchBool() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189342200-0x00000001893423AC
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a comparison between two comparable objects")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IComparable) })]
	public class SwitchComparison : FlowControlNode // TypeDefIndex: 47355
	{
		// Constructors
		public SwitchComparison() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893423AC-0x00000001893425F4
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an enum value.\nPlease connect an Enum first for the options to show, or directly select the enum type with the relevant button bellow.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Enum) })]
	public class SwitchEnum : FlowControlNode // TypeDefIndex: 47357
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB0
	
		// Properties
		private System.Type type { get => default; set {} } // 0x0000000187C03DD4-0x0000000187C03DE8 0x0000000189342A20-0x0000000189342AD0
	
		// Constructors
		public SwitchEnum() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189342754-0x0000000189342A20
		public override System.Type GetNodeWildDefinitionType() => default; // 0x00000001893425F4-0x0000000189342644
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x0000000189342644-0x0000000189342754
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an integer value. The Default output is called when the Index value is out of range.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[Name("Switch Integer", 0)]
	public class SwitchInt : FlowControlNode // TypeDefIndex: 47359
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Constructors
		public SwitchInt() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189342DA0-0x0000000189342F88
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an integer value. The Default output is called when the Index value is out of range.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[HasRefreshButton]
	[Name("Switch Integer Custom", 0)]
	public class SwitchIntCustom : FlowControlNode // TypeDefIndex: 47361
	{
		// Fields
		public List<int> intCases; // 0xB0
	
		// Constructors
		public SwitchIntCustom() {} // 0x0000000189342D18-0x0000000189342DA0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189342AD0-0x0000000189342D18
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Calls one output based on it\'s probability to be selected, in comparison to all other outputs. The probability of each output is respectively set by the same name float input.\nFor example, if all input values are the same (eg \'1\'), then all outputs have the same chance to be called.")]
	[ContextDefinedInputs(new System.Type[2] {typeof(Flow), typeof(float) })]
	public class SwitchProbability : FlowControlNode // TypeDefIndex: 47362
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private List<ValueInput<float>> probabilityValues; // 0xB8
		private List<FlowOutput> probabilityOuts; // 0xC0
		private float[] cacheValues; // 0xC8
		private int current; // 0xD0
	
		// Constructors
		public SwitchProbability() {} // 0x00000001893363CC-0x00000001893363E0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189343144-0x0000000189343478
		private void Enter(Flow f) {} // 0x0000000189342F88-0x0000000189343144
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a string value. The Default output is called if there is no other matching output same as the input value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(string) })]
	[HasRefreshButton]
	public class SwitchString : FlowControlNode // TypeDefIndex: 47364
	{
		// Fields
		[Name("Cases", 0)]
		public List<string> comparisonOutputs; // 0xB0
	
		// Constructors
		public SwitchString() {} // 0x00000001893436C4-0x000000018934374C
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189343478-0x00000001893436C4
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on the tag of a GameObject value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(GameObject) })]
	[HasRefreshButton]
	public class SwitchTag : FlowControlNode // TypeDefIndex: 47366
	{
		// Fields
		[SerializeField]
		private string[] _tagNames; // 0xB0
	
		// Constructors
		public SwitchTag() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018934374C-0x0000000189343924
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Flip Flops between the 2 outputs each time In is called")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(bool) })]
	public class FlipFlop : FlowControlNode // TypeDefIndex: 47368
	{
		// Fields
		public bool isFlip; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get => default; } // 0x000000018933A898-0x000000018933A910 
	
		// Constructors
		public FlipFlop() {} // 0x000000018933A888-0x000000018933A898
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000183D71B80-0x0000000183D71B90
		public override void OnGraphStoped() {} // 0x0000000183D71B90-0x0000000183D71BA0
		protected override void RegisterPorts() {} // 0x000000018933A658-0x000000018933A888
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Whenever In is called the \'current\' output is called as well. Calling \'+\' or \'-\' changes the current output respectively up or down.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Toggle (Multi)", 0)]
	public class MultiToggle : FlowControlNode // TypeDefIndex: 47370
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		[Name("Start Index", 0)]
		public int current; // 0xB4
		private int original; // 0xB8
	
		// Properties
		public override string name { get => default; } // 0x000000018933CBE8-0x000000018933CC6C 
	
		// Constructors
		public MultiToggle() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018933C8BC-0x000000018933C8F8
		public override void OnGraphStoped() {} // 0x0000000183D71C10-0x0000000183D71C20
		protected override void RegisterPorts() {} // 0x000000018933C8F8-0x000000018933CBE8
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Each time input is signaled, the next output in order is called. After the last output, the order loops from the start.\nReset, resets the current index to zero.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Flip Flop (Multi)", 0)]
	public class Sequence : FlowControlNode // TypeDefIndex: 47372
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		[MinValue(0)]
		public int current; // 0xB4
		private int original; // 0xB8
	
		// Properties
		public override string name { get => default; } // 0x000000018934197C-0x0000000189341A00 
	
		// Constructors
		public Sequence() {} // 0x0000000187C05F18-0x0000000187C05F2C
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018933C8BC-0x000000018933C8F8
		public override void OnGraphStoped() {} // 0x0000000183D71C10-0x0000000183D71C20
		protected override void RegisterPorts() {} // 0x00000001893416F0-0x000000018934197C
	}

	[Category("Flow Controllers/Togglers")]
	[Description("When In is called, calls On or Off depending on the current toggle state. Whenever Toggle input is called the state changes.")]
	public class Toggle : FlowControlNode // TypeDefIndex: 47374
	{
		// Fields
		[Name("Start Open", 0)]
		public bool open; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get => default; } // 0x0000000189343B9C-0x0000000189343C14 
	
		// Constructors
		public Toggle() {} // 0x000000018933A888-0x000000018933A898
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000183D71B80-0x0000000183D71B90
		public override void OnGraphStoped() {} // 0x0000000183D71B90-0x0000000183D71BA0
		protected override void RegisterPorts() {} // 0x0000000189343924-0x0000000189343B9C
	}

	[Category("Functions/Custom")]
	[Description("Calls an existing Custom Function")]
	[DeserializeFrom("FlowCanvas.Nodes.RelayFlowInput")]
	[DoNotList]
	[HasRefreshButton]
	[Name("Function Call", 0)]
	public class CustomFunctionCall : FlowControlNode // TypeDefIndex: 47375
	{
		// Fields
		[SerializeField]
		private string _sourceOutputUID; // 0xB0
		private ValueInput[] portArgs; // 0xB8
		private object[] objectArgs; // 0xC0
		private FlowOutput fOut; // 0xC8
		private WeakReference<CustomFunctionEvent> _sourceFunctionRef; // 0xD0
	
		// Properties
		private string sourceFunctionUID { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000182B47080-0x0000000182B470A0
		public CustomFunctionEvent sourceFunction { get => default; } // 0x0000000189338FB8-0x0000000189339114 
		public override string name { get => default; } // 0x0000000189338F30-0x0000000189338FB8 
		public override string description { get => default; } // 0x0000000189338ECC-0x0000000189338F30 
	
		// Constructors
		public CustomFunctionCall() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public void SetFunction(CustomFunctionEvent func) {} // 0x0000000189338DD4-0x0000000189338E94
		protected override void RegisterPorts() {} // 0x0000000189338AB8-0x0000000189338DD4
		private void Invoke(Flow f) {} // 0x000000018933890C-0x0000000189338AB8
	}

	[Category("Functions/Custom")]
	[Description("A custom function, defined by any number of parameters and an optional return value. It can be called using the \'Call Custom Function\' node. To end the function and optionally return a value, the \'Return\' node should be used.")]
	[DeserializeFrom("FlowCanvas.Nodes.RelayFlowOutput")]
	[Name("New Custom Function", 10)]
	public class CustomFunctionEvent : EventNode, IInvokable, IEditorMenuCallbackReceiver // TypeDefIndex: 47380
	{
		// Fields
		[DelayedField]
		[Tooltip("The identifier name of the function")]
		public string identifier; // 0xB0
		[SerializeField]
		private List<DynamicParameterDefinition> _parameters; // 0xB8
		[SerializeField]
		private DynamicParameterDefinition _returns; // 0xC0
		private object[] args; // 0xC8
		private object returnValue; // 0xD0
		private FlowOutput onInvoke; // 0xD8
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get => default; private set {} } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001858AAF64-0x00000001858AAF78
		public DynamicParameterDefinition returns { get => default; private set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		private System.Type returnType { get => default; } // 0x0000000189339C10-0x0000000189339C30 
		private System.Type[] parameterTypes { get => default; } // 0x0000000189339AE8-0x0000000189339C10 
		public override string name { get => default; } // 0x0000000189339AA8-0x0000000189339AE8 
	
		// Constructors
		public CustomFunctionEvent() {} // 0x00000001893399A8-0x0000000189339AA8
	
		// Methods
		public override void OnGraphStoped() {} // 0x00000001893397A8-0x00000001893397DC
		protected override void RegisterPorts() {} // 0x00000001893397DC-0x0000000189339978
		string IInvokable.GetInvocationID() => default; // 0x0000000183D4EAD0-0x0000000183D4EAE0
		object IInvokable.Invoke(params object[] args) => default; // 0x0000000189339768-0x00000001893397A8
		void IInvokable.InvokeAsync(Action<object> callback, params object[] args) {} // 0x0000000189339658-0x0000000189339768
		public object Invoke(Flow f, params object[] args) => default; // 0x0000000189339550-0x0000000189339658
		public void InvokeAsync(Flow f, FlowHandler flowCallback, params object[] args) {} // 0x00000001893393CC-0x0000000189339550
		public object GetReturnValue() => default; // 0x0000000183D50050-0x0000000183D50060
		private void AddParameter(System.Type type) {} // 0x0000000189339114-0x00000001893391F0
		private void GatherPortsUpdateRefs() {} // 0x00000001893391F0-0x00000001893393CC
	}

	[Category("Functions/Custom")]
	[Description("Should always be used to return out of a Custom Function. The return value is only required if the Custom Function returns a value as well.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(object) })]
	public class Return : FlowControlNode // TypeDefIndex: 47381
	{
		// Fields
		[GatherPortsCallback]
		public bool useReturnValue; // 0xB0
		private ValueInput<object> returnPort; // 0xB8
	
		// Constructors
		public Return() {} // 0x000000018933A888-0x000000018933A898
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018934149C-0x0000000189341594
	}

	public abstract class CallableActionNodeBase : SimplexNode // TypeDefIndex: 47382
	{
		// Constructors
		protected CallableActionNodeBase() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class CallableActionNode : CallableActionNodeBase // TypeDefIndex: 47384
	{
		// Constructors
		protected CallableActionNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node) {} // 0x0000000189337B64-0x0000000189337C74
	}

	public abstract class CallableActionNode<T1> : CallableActionNodeBase // TypeDefIndex: 47386
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2> : CallableActionNodeBase // TypeDefIndex: 47388
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3> : CallableActionNodeBase // TypeDefIndex: 47390
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4> : CallableActionNodeBase // TypeDefIndex: 47392
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5> : CallableActionNodeBase // TypeDefIndex: 47394
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6> : CallableActionNodeBase // TypeDefIndex: 47396
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7> : CallableActionNodeBase // TypeDefIndex: 47398
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : CallableActionNodeBase // TypeDefIndex: 47400
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableActionNodeBase // TypeDefIndex: 47402
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableActionNodeBase // TypeDefIndex: 47404
	{
		// Constructors
		protected CallableActionNode() {}
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNodeBase : SimplexNode // TypeDefIndex: 47405
	{
		// Constructors
		protected CallableFunctionNodeBase() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class CallableFunctionNode<TResult> : CallableFunctionNodeBase // TypeDefIndex: 47407
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1> : CallableFunctionNodeBase // TypeDefIndex: 47409
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2> : CallableFunctionNodeBase // TypeDefIndex: 47411
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3> : CallableFunctionNodeBase // TypeDefIndex: 47413
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4> : CallableFunctionNodeBase // TypeDefIndex: 47415
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5> : CallableFunctionNodeBase // TypeDefIndex: 47417
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : CallableFunctionNodeBase // TypeDefIndex: 47419
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : CallableFunctionNodeBase // TypeDefIndex: 47421
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : CallableFunctionNodeBase // TypeDefIndex: 47423
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableFunctionNodeBase // TypeDefIndex: 47425
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableFunctionNodeBase // TypeDefIndex: 47427
	{
		// Fields
		private TResult result;
	
		// Constructors
		protected CallableFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode : SimplexNode // TypeDefIndex: 47429
	{
		// Fields
		private static Dictionary<System.Type, System.Type> _extractors; // 0x00
	
		// Constructors
		protected ExtractorNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static System.Type GetExtractorType(System.Type type) => default; // 0x000000018933A0C0-0x000000018933A534
	}

	public abstract class ExtractorNode<TInstance, T1, T2> : ExtractorNode // TypeDefIndex: 47431
	{
		// Fields
		private T1 a;
		private T2 b;
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3> : ExtractorNode // TypeDefIndex: 47433
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4> : ExtractorNode // TypeDefIndex: 47435
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5> : ExtractorNode // TypeDefIndex: 47437
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d, out ref T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> : ExtractorNode // TypeDefIndex: 47439
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
		private T6 f;
	
		// Constructors
		protected ExtractorNode() {}
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d, out ref T5 e, out ref T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class AddDictionaryItem<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string, T> // TypeDefIndex: 47440
	{
		// Constructors
		public AddDictionaryItem() {}
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key, T item) => default;
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class GetDictionaryItem<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 47441
	{
		// Constructors
		public GetDictionaryItem() {}
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key) => default;
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class RemoveDictionaryKey<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string> // TypeDefIndex: 47442
	{
		// Constructors
		public RemoveDictionaryKey() {}
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key) => default;
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class ClearDictionary : CallableFunctionNode<IDictionary, IDictionary> // TypeDefIndex: 47443
	{
		// Constructors
		public ClearDictionary() {} // 0x0000000189337EB0-0x0000000189337ED8
	
		// Methods
		public override IDictionary Invoke(IDictionary dict) => default; // 0x0000000189337E88-0x0000000189337EB0
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class TryGetValue<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 47444
	{
		// Properties
		public bool exists { get; private set; }
	
		// Constructors
		public TryGetValue() {}
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key) => default;
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class DictionaryContainsKey<T> : CallableFunctionNode<bool, IDictionary<string, T>, string> // TypeDefIndex: 47445
	{
		// Constructors
		public DictionaryContainsKey() {}
	
		// Methods
		public override bool Invoke(IDictionary<string, T> dict, string key) => default;
	}

	[Category("Collections/Lists")]
	public class ClearList : CallableFunctionNode<IList, IList> // TypeDefIndex: 47446
	{
		// Constructors
		public ClearList() {} // 0x0000000189337F00-0x0000000189337F28
	
		// Methods
		public override IList Invoke(IList list) => default; // 0x0000000189337ED8-0x0000000189337F00
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class AddListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 47447
	{
		// Constructors
		public AddListItem() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class InsertListItem<T> : CallableFunctionNode<IList<T>, List<T>, int, T> // TypeDefIndex: 47448
	{
		// Constructors
		public InsertListItem() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index, T item) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class RemoveListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 47449
	{
		// Constructors
		public RemoveListItem() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class RemoveListItemAt<T> : CallableFunctionNode<IList<T>, List<T>, int> // TypeDefIndex: 47450
	{
		// Constructors
		public RemoveListItemAt() {}
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class SetListItem<T> : CallableFunctionNode<IList<T>, IList<T>, int, T> // TypeDefIndex: 47451
	{
		// Constructors
		public SetListItem() {}
	
		// Methods
		public override IList<T> Invoke(IList<T> list, int index, T item) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class ShuffleList<T> : CallableFunctionNode<IList<T>, IList<T>> // TypeDefIndex: 47452
	{
		// Constructors
		public ShuffleList() {}
	
		// Methods
		public override IList<T> Invoke(IList<T> list) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetListItem<T> : PureFunctionNode<T, IList<T>, int> // TypeDefIndex: 47453
	{
		// Constructors
		public GetListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list, int index) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetRandomListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 47454
	{
		// Constructors
		public GetRandomListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetLastListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 47455
	{
		// Constructors
		public GetLastListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetFirstListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 47456
	{
		// Constructors
		public GetFirstListItem() {}
	
		// Methods
		public override T Invoke(IList<T> list) => default;
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetListItemIndex : PureFunctionNode<int, IList, object> // TypeDefIndex: 47457
	{
		// Constructors
		public GetListItemIndex() {} // 0x000000018933B3AC-0x000000018933B3D4
	
		// Methods
		public override int Invoke(IList list, object item) => default; // 0x000000018933B384-0x000000018933B3AC
	}

	[Category("Operators")]
	[Description("Returns if the object is not null")]
	[Name("Is Valid", 0)]
	public class IsNotNull : PureFunctionNode<bool, object> // TypeDefIndex: 47458
	{
		// Constructors
		public IsNotNull() {} // 0x000000018933B9FC-0x000000018933BA24
	
		// Methods
		public override bool Invoke(object OBJECT) => default; // 0x000000018933B9DC-0x000000018933B9FC
	}

	[Category("Operators")]
	[Description("Returns whether the input object is of type T as well as the object itself for convenience.")]
	public class IsOfType : PureFunctionNode<bool, object, System.Type> // TypeDefIndex: 47459
	{
		// Properties
		public object OBJECT { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public IsOfType() {} // 0x000000018933BAA8-0x000000018933BAD0
	
		// Methods
		public override bool Invoke(object OBJECT, System.Type type) => default; // 0x000000018933BA24-0x000000018933BAA8
	}

	[Category("Operators/Any")]
	[Description("Any Greater Than")]
	[Name(">", 0)]
	public class AnyGreaterThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 47460
	{
		// Constructors
		public AnyGreaterThan() {} // 0x0000000189336608-0x0000000189336630
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x00000001893365D8-0x0000000189336608
	}

	[Category("Operators/Any")]
	[Description("Any Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class AnyGreaterEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 47461
	{
		// Constructors
		public AnyGreaterEqualThan() {} // 0x00000001893365B0-0x00000001893365D8
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x0000000189336564-0x00000001893365B0
	}

	[Category("Operators/Any")]
	[Description("Any Less Than")]
	[Name("<", 0)]
	public class AnyLessThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 47462
	{
		// Constructors
		public AnyLessThan() {} // 0x00000001893366D4-0x00000001893366FC
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x00000001893366A4-0x00000001893366D4
	}

	[Category("Operators/Any")]
	[Description("Any Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class AnyLessEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 47463
	{
		// Constructors
		public AnyLessEqualThan() {} // 0x000000018933667C-0x00000001893366A4
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b) => default; // 0x0000000189336630-0x000000018933667C
	}

	[Category("Operators/Any")]
	[Description("Any Equal To")]
	[Name("=", 0)]
	public class AnyEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 47464
	{
		// Constructors
		public AnyEqual() {} // 0x000000018933653C-0x0000000189336564
	
		// Methods
		public override bool Invoke(object a, object b) => default; // 0x0000000189336528-0x000000018933653C
	}

	[Category("Operators/Any")]
	[Description("Any Not Equal To")]
	[Name("\u2260", 0)]
	public class AnyNotEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 47465
	{
		// Constructors
		public AnyNotEqual() {} // 0x0000000189336718-0x0000000189336740
	
		// Methods
		public override bool Invoke(object a, object b) => default; // 0x00000001893366FC-0x0000000189336718
	}

	[Category("Operators/Floats")]
	[Description("Float Add")]
	[Name("+", 0)]
	public class FloatAdd : PureFunctionNode<float, float, float> // TypeDefIndex: 47466
	{
		// Constructors
		public FloatAdd() {} // 0x000000018933A910-0x000000018933A938
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x0000000183D71BA0-0x0000000183D71BB0
	}

	[Category("Operators/Floats")]
	[Description("Float Subtract")]
	[Name("-", 0)]
	public class FloatSubtract : PureFunctionNode<float, float, float> // TypeDefIndex: 47467
	{
		// Constructors
		public FloatSubtract() {} // 0x000000018933AB4C-0x000000018933AB74
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x0000000183D71BD0-0x0000000183D71BE0
	}

	[Category("Operators/Floats")]
	[Description("Float Mutliply")]
	[Name("\u00D7", 0)]
	public class FloatMultiply : PureFunctionNode<float, float, float> // TypeDefIndex: 47468
	{
		// Constructors
		public FloatMultiply() {} // 0x000000018933AA98-0x000000018933AAC0
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x0000000182162470-0x0000000182162490
	}

	[Category("Operators/Floats")]
	[Description("Float Divide")]
	[Name("\u00F7", 0)]
	public class FloatDivide : PureFunctionNode<float, float, float> // TypeDefIndex: 47469
	{
		// Constructors
		public FloatDivide() {} // 0x000000018933A938-0x000000018933A960
	
		// Methods
		public override float Invoke(float a, float b) => default; // 0x000000018576B064-0x000000018576B06C
	}

	[Category("Operators/Floats")]
	[Description("Float Modulo")]
	[Name("%", 0)]
	public class FloatModulo : PureFunctionNode<float, float, float> // TypeDefIndex: 47470
	{
		// Constructors
		public FloatModulo() {} // 0x000000018933AA70-0x000000018933AA98
	
		// Methods
		public override float Invoke(float value, float mod) => default; // 0x0000000183D71BC0-0x0000000183D71BD0
	}

	[Category("Operators/Floats")]
	[Description("Float Greater Than")]
	[Name(">", 0)]
	public class FloatGreaterThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 47471
	{
		// Constructors
		public FloatGreaterThan() {} // 0x000000018933A9C0-0x000000018933A9E8
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018933A9B8-0x000000018933A9C0
	}

	[Category("Operators/Floats")]
	[Description("Float Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class FloatGreaterEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 47472
	{
		// Constructors
		public FloatGreaterEqualThan() {} // 0x000000018933A990-0x000000018933A9B8
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018933A988-0x000000018933A990
	}

	[Category("Operators/Floats")]
	[Description("Float Less Than")]
	[Name("<", 0)]
	public class FloatLessThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 47473
	{
		// Constructors
		public FloatLessThan() {} // 0x000000018933AA48-0x000000018933AA70
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018933AA40-0x000000018933AA48
	}

	[Category("Operators/Floats")]
	[Description("Float Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class FloatLessEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 47474
	{
		// Constructors
		public FloatLessEqualThan() {} // 0x000000018933AA18-0x000000018933AA40
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018933AA10-0x000000018933AA18
	}

	[Category("Operators/Floats")]
	[Description("Float Equal To")]
	[Name("=", 0)]
	public class FloatEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 47475
	{
		// Constructors
		public FloatEqual() {} // 0x000000018933A960-0x000000018933A988
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018806A0DC-0x000000018806A0EC
	}

	[Category("Operators/Floats")]
	[Description("Float Not Equal To")]
	[Name("\u2260", 0)]
	public class FloatNotEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 47476
	{
		// Constructors
		public FloatNotEqual() {} // 0x000000018933AAD0-0x000000018933AAF8
	
		// Methods
		public override bool Invoke(float a, float b) => default; // 0x000000018933AAC0-0x000000018933AAD0
	}

	[Category("Operators/Floats")]
	[Description("Float Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class FloatInvert : PureFunctionNode<float, float> // TypeDefIndex: 47477
	{
		// Constructors
		public FloatInvert() {} // 0x000000018933A9E8-0x000000018933AA10
	
		// Methods
		public override float Invoke(float value) => default; // 0x0000000183D71BB0-0x0000000183D71BC0
	}

	[Category("Operators/Floats")]
	[Description("Float Round value to closest of interval ( round(value / interval) * interval )")]
	public class FloatSnap : PureFunctionNode<int, float, int> // TypeDefIndex: 47478
	{
		// Constructors
		public FloatSnap() {} // 0x000000018933AB24-0x000000018933AB4C
	
		// Methods
		public override int Invoke(float value, int interval) => default; // 0x000000018933AAF8-0x000000018933AB24
	}

	[Category("Operators/Integers")]
	[Description("Integer Add")]
	[Name("+", 0)]
	public class IntegerAdd : PureFunctionNode<int, int, int> // TypeDefIndex: 47479
	{
		// Constructors
		public IntegerAdd() {} // 0x000000018933B768-0x000000018933B790
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x0000000183D71BE0-0x0000000183D71BF0
	}

	[Category("Operators/Integers")]
	[Description("Integer Subtract")]
	[Name("-", 0)]
	public class IntegerSubtract : PureFunctionNode<int, int, int> // TypeDefIndex: 47480
	{
		// Constructors
		public IntegerSubtract() {} // 0x000000018933B9B4-0x000000018933B9DC
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x0000000183D5E040-0x0000000183D5E050
	}

	[Category("Operators/Integers")]
	[Description("Integer Multiply")]
	[Name("\u00D7", 0)]
	public class IntegerMultiply : PureFunctionNode<int, int, int> // TypeDefIndex: 47481
	{
		// Constructors
		public IntegerMultiply() {} // 0x000000018933B90C-0x000000018933B934
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x0000000182162460-0x0000000182162470
	}

	[Category("Operators/Integers")]
	[Description("Integer Divide")]
	[Name("\u00F7", 0)]
	public class IntegerDivide : PureFunctionNode<int, int, int> // TypeDefIndex: 47482
	{
		// Constructors
		public IntegerDivide() {} // 0x000000018933B7A0-0x000000018933B7C8
	
		// Methods
		public override int Invoke(int a, int b) => default; // 0x000000018933B790-0x000000018933B7A0
	}

	[Category("Operators/Integers")]
	[Description("Integer Modulo")]
	[Name("%", 0)]
	public class IntegerModulo : PureFunctionNode<int, int, int> // TypeDefIndex: 47483
	{
		// Constructors
		public IntegerModulo() {} // 0x000000018933B8E4-0x000000018933B90C
	
		// Methods
		public override int Invoke(int value, int mod) => default; // 0x000000018933B8D8-0x000000018933B8E4
	}

	[Category("Operators/Integers")]
	[Description("Integer Greater Than")]
	[Name(">", 0)]
	public class IntegerGreaterThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 47484
	{
		// Constructors
		public IntegerGreaterThan() {} // 0x000000018933B828-0x000000018933B850
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018933B820-0x000000018933B828
	}

	[Category("Operators/Integers")]
	[Description("Integer Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class IntegerGreaterEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 47485
	{
		// Constructors
		public IntegerGreaterEqualThan() {} // 0x000000018933B7F8-0x000000018933B820
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018933B7F0-0x000000018933B7F8
	}

	[Category("Operators/Integers")]
	[Description("Integer Less Than")]
	[Name("<", 0)]
	public class IntegerLessThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 47486
	{
		// Constructors
		public IntegerLessThan() {} // 0x000000018933B8B0-0x000000018933B8D8
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018933B8A8-0x000000018933B8B0
	}

	[Category("Operators/Integers")]
	[Description("Integer Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class IntegerLessEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 47487
	{
		// Constructors
		public IntegerLessEqualThan() {} // 0x000000018933B880-0x000000018933B8A8
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018933B878-0x000000018933B880
	}

	[Category("Operators/Integers")]
	[Description("Integer Equal To")]
	[Name("=", 0)]
	public class IntegerEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 47488
	{
		// Constructors
		public IntegerEqual() {} // 0x000000018933B7C8-0x000000018933B7F0
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018806BB54-0x000000018806BB5C
	}

	[Category("Operators/Integers")]
	[Description("Integer Not Equal To")]
	[Name("\u2260", 0)]
	public class IntegerNotEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 47489
	{
		// Constructors
		public IntegerNotEqual() {} // 0x000000018933B93C-0x000000018933B964
	
		// Methods
		public override bool Invoke(int a, int b) => default; // 0x000000018933B934-0x000000018933B93C
	}

	[Category("Operators/Integers")]
	[Description("Integer Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class IntegerInvert : PureFunctionNode<int, int> // TypeDefIndex: 47490
	{
		// Constructors
		public IntegerInvert() {} // 0x000000018933B850-0x000000018933B878
	
		// Methods
		public override int Invoke(int value) => default; // 0x0000000183D71BF0-0x0000000183D71C00
	}

	[Category("Operators/Integers")]
	[Description("Integer Round value to closest of interval ( round(value / interval) * interval )")]
	public class IntegerSnap : PureFunctionNode<int, int, int> // TypeDefIndex: 47491
	{
		// Constructors
		public IntegerSnap() {} // 0x000000018933B98C-0x000000018933B9B4
	
		// Methods
		public override int Invoke(int value, int interval) => default; // 0x000000018933B964-0x000000018933B98C
	}

	[Category("Operators/Boolean")]
	[Description("Boolean Equal To")]
	[Name("=", 0)]
	public class BooleanEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 47492
	{
		// Constructors
		public BooleanEqual() {} // 0x0000000189337A48-0x0000000189337A70
	
		// Methods
		public override bool Invoke(bool a, bool b) => default; // 0x0000000187D39E94-0x0000000187D39EA0
	}

	[Category("Operators/Boolean")]
	[Description("Boolean Not Equal To")]
	[Name("\u2260", 0)]
	public class BooleanNotEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 47493
	{
		// Constructors
		public BooleanNotEqual() {} // 0x0000000189337A78-0x0000000189337AA0
	
		// Methods
		public override bool Invoke(bool a, bool b) => default; // 0x0000000189337A70-0x0000000189337A78
	}

	[Category("Operators/Boolean")]
	[Description("True if A and B are both true")]
	public class AND : PureFunctionNode<bool> // TypeDefIndex: 47494
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public AND() {} // 0x0000000189336500-0x0000000189336528
	
		// Methods
		public override bool Invoke() => default; // 0x00000001893363E0-0x0000000189336444
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x0000000189336444-0x0000000189336500
	}

	[Category("Operators/Boolean")]
	[Description("True if A or B is true")]
	public class OR : PureFunctionNode<bool> // TypeDefIndex: 47495
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public OR() {} // 0x000000018933CF80-0x000000018933CFA8
	
		// Methods
		public override bool Invoke() => default; // 0x000000018933CE5C-0x000000018933CEC4
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018933CEC4-0x000000018933CF80
	}

	[Category("Operators/Boolean")]
	[Description("True if A or B is true, but not both")]
	public class XOR : PureFunctionNode<bool> // TypeDefIndex: 47496
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public XOR() {} // 0x0000000189349F94-0x0000000189349FBC
	
		// Methods
		public override bool Invoke() => default; // 0x0000000189349E60-0x0000000189349ED8
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x0000000189349ED8-0x0000000189349F94
	}

	[Category("Operators/Boolean")]
	[Description("Inverts the input")]
	public class NOT : PureFunctionNode<bool, bool> // TypeDefIndex: 47497
	{
		// Constructors
		public NOT() {} // 0x000000018933CC74-0x000000018933CC9C
	
		// Methods
		public override bool Invoke(bool value) => default; // 0x000000018933CC6C-0x000000018933CC74
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Equal To")]
	[Name("=", 0)]
	public class Vector3Equal : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 47498
	{
		// Constructors
		public Vector3Equal() {} // 0x0000000189348FBC-0x0000000189348FE4
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b) => default; // 0x0000000189348F68-0x0000000189348FBC
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Not Equal To")]
	[Name("\u2260", 0)]
	public class Vector3NotEqual : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 47499
	{
		// Constructors
		public Vector3NotEqual() {} // 0x0000000189349118-0x0000000189349140
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b) => default; // 0x00000001893490C4-0x0000000189349118
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Add")]
	[Name("+", 0)]
	public class Vector3Add : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 47500
	{
		// Constructors
		public Vector3Add() {} // 0x0000000189348EE0-0x0000000189348F08
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b) => default; // 0x0000000189348E84-0x0000000189348EE0
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Subtract")]
	[Name("-", 0)]
	public class Vector3Subtract : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 47501
	{
		// Constructors
		public Vector3Subtract() {} // 0x000000018934919C-0x00000001893491C4
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b) => default; // 0x0000000189349140-0x000000018934919C
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Multiply")]
	[Name("\u00D7", 0)]
	public class Vector3Multiply : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 47502
	{
		// Constructors
		public Vector3Multiply() {} // 0x000000018934909C-0x00000001893490C4
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b) => default; // 0x0000000189349058-0x000000018934909C
	}

	[Category("Operators/Vector3")]
	[Description("Vectro3 Divide")]
	[Name("\u00F7", 0)]
	public class Vector3Divide : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 47503
	{
		// Constructors
		public Vector3Divide() {} // 0x0000000189348F40-0x0000000189348F68
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b) => default; // 0x0000000189348F08-0x0000000189348F40
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class Vector3Invert : PureFunctionNode<Vector3, Vector3> // TypeDefIndex: 47504
	{
		// Constructors
		public Vector3Invert() {} // 0x0000000189349030-0x0000000189349058
	
		// Methods
		public override Vector3 Invoke(Vector3 value) => default; // 0x0000000189348FE4-0x0000000189349030
	}

	[Category("Operators/Flags")]
	[Description("Bitwise logical AND & operator")]
	[Name("AND", 0)]
	public class BitwiseAnd<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 47505
		where T : Enum
	{
		// Constructors
		public BitwiseAnd() {}
	
		// Methods
		public override T Invoke(T a, T b) => default;
	}

	[Category("Operators/Flags")]
	[Description("Bitwise logical OR | operator")]
	[Name("OR", 0)]
	public class BitwiseOr<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 47506
		where T : Enum
	{
		// Constructors
		public BitwiseOr() {}
	
		// Methods
		public override T Invoke(T a, T b) => default;
	}

	[Category("Operators/Flags")]
	[Description("Bitwise complement ~ operator")]
	[Name("Invert", 0)]
	public class BitwiseInvert<T> : PureFunctionNode<T, T> // TypeDefIndex: 47507
		where T : Enum
	{
		// Constructors
		public BitwiseInvert() {}
	
		// Methods
		public override T Invoke(T a) => default;
	}

	[Category("Time")]
	[Description("Wait for a certain amount of time before continueing")]
	public class Wait : LatentActionNode<float> // TypeDefIndex: 47509
	{
		// Properties
		public float timeLeft { get; private set; } // 0x0000000183D56A40-0x0000000183D56A50 0x0000000183D59110-0x0000000183D59120
		public float normalized { get; private set; } // 0x0000000183D56C50-0x0000000183D56C60 0x0000000183D5B680-0x0000000183D5B690
	
		// Constructors
		public Wait() {} // 0x0000000189349928-0x0000000189349950
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__8))]
		public override IEnumerator Invoke(float time = 1f /* Metadata: 0x01FBB661 */) => default; // 0x00000001893498BC-0x0000000189349928
	}

	[Category("Time")]
	[Description("Wait for one (the next) frame")]
	public class WaitForOneFrame : LatentActionNode // TypeDefIndex: 47511
	{
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public WaitForOneFrame() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke() => default; // 0x0000000189349674-0x00000001893496B8
	}

	[Category("Time")]
	[Description("Wait until the physics update frame")]
	public class WaitForPhysicsFrame : LatentActionNode // TypeDefIndex: 47513
	{
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public WaitForPhysicsFrame() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke() => default; // 0x00000001893496B8-0x00000001893496FC
	}

	[Category("Time")]
	[Description("Wait until the end of current frame")]
	public class WaitForEndOfFrame : LatentActionNode // TypeDefIndex: 47515
	{
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public WaitForEndOfFrame() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke() => default; // 0x0000000189349630-0x0000000189349674
	}

	[Category("Time")]
	[Description("Wait Until condition value becomes true")]
	public class WaitUntil : LatentActionNode // TypeDefIndex: 47517
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public WaitUntil() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__3))]
		public override IEnumerator Invoke() => default; // 0x00000001893496FC-0x0000000189349758
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x0000000189349758-0x00000001893497DC
	}

	[Category("Time")]
	[Description("Wait While condition value is true")]
	public class WaitWhile : LatentActionNode // TypeDefIndex: 47519
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public WaitWhile() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__3))]
		public override IEnumerator Invoke() => default; // 0x00000001893497DC-0x0000000189349838
		protected override void OnRegisterExtraPorts(FlowNode node) {} // 0x0000000189349838-0x00000001893498BC
	}

	[Category("Time")]
	[Description("Mutliply input value by Time.deltaTime and optional multiplier")]
	[Name("Per Second (Float)", 0)]
	public class DeltaTimed : PureFunctionNode<float, float, float> // TypeDefIndex: 47520
	{
		// Constructors
		public DeltaTimed() {} // 0x0000000189339E1C-0x0000000189339E44
	
		// Methods
		public override float Invoke(float value, float multiplier = 1f /* Metadata: 0x01FBB665 */) => default; // 0x0000000189339DE8-0x0000000189339E1C
	}

	[Category("Time")]
	[Description("Mutliply input value by Time.deltaTime and optional multiplier")]
	[Name("Per Second (Vector3)", 0)]
	public class DeltaTimedVector3 : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 47521
	{
		// Constructors
		public DeltaTimedVector3() {} // 0x0000000189339DC0-0x0000000189339DE8
	
		// Methods
		public override Vector3 Invoke(Vector3 value, float multiplier = 1f /* Metadata: 0x01FBB669 */) => default; // 0x0000000189339D3C-0x0000000189339DC0
	}

	[Category("Time")]
	[Description("Input values are buffered and returned in order of buffering once the buffered amount reaches the buffer size. In practice this creates a delayed value output when the node is constantly updated per-frame.\nWhen the node ceases to update, a new buffer is created.")]
	[ExposeAsDefinition]
	public class Buffer<T> : PureFunctionNode<T, T, int> // TypeDefIndex: 47522
	{
		// Fields
		private int lastFrame;
		private Queue<T> q;
	
		// Constructors
		public Buffer() {}
	
		// Methods
		public override T Invoke(T value, int size = 60 /* Metadata: 0x01FBB66D */) => default;
	}

	[Category("Time")]
	[Description("Returns a smoothly interpolated value towards the input value.")]
	[Name("Damp (Float)", 0)]
	public class DampFloat : PureFunctionNode<float, float, float, float> // TypeDefIndex: 47523
	{
		// Constructors
		public DampFloat() {} // 0x0000000189339C7C-0x0000000189339CA4
	
		// Methods
		public override float Invoke(float current, float target, float damp = 1f /* Metadata: 0x01FBB66E */) => default; // 0x0000000189339C30-0x0000000189339C7C
	}

	[Category("Time")]
	[Description("Returns a smoothly interpolated value towards the input value.")]
	[Name("Damp (Vector3)", 0)]
	public class DampVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float> // TypeDefIndex: 47524
	{
		// Constructors
		public DampVector3() {} // 0x0000000189339D14-0x0000000189339D3C
	
		// Methods
		public override Vector3 Invoke(Vector3 current, Vector3 target, float damp = 1f /* Metadata: 0x01FBB672 */) => default; // 0x0000000189339CA4-0x0000000189339D14
	}

	[Category("Tweening/Values")]
	public class LerpFloat : PureFunctionNode<float, float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47525
	{
		// Constructors
		public LerpFloat() {} // 0x000000018933C62C-0x000000018933C654
	
		// Methods
		public override float Invoke(float a, float b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018933C618-0x000000018933C62C
	}

	[Category("Tweening/Values")]
	public class LerpVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47526
	{
		// Constructors
		public LerpVector3() {} // 0x000000018933C748-0x000000018933C770
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018933C6D4-0x000000018933C748
	}

	[Category("Tweening/Values")]
	public class LerpQuaternion : PureFunctionNode<Quaternion, Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47527
	{
		// Constructors
		public LerpQuaternion() {} // 0x000000018933C6AC-0x000000018933C6D4
	
		// Methods
		public override Quaternion Invoke(Quaternion a, Quaternion b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018933C654-0x000000018933C6AC
	}

	[Category("Tweening/Values")]
	public class LerpColor : PureFunctionNode<UnityEngine.Color, UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47528
	{
		// Constructors
		public LerpColor() {} // 0x000000018933C5F0-0x000000018933C618
	
		// Methods
		public override UnityEngine.Color Invoke(UnityEngine.Color a, UnityEngine.Color b, float t, ParadoxNotion.Animation.EaseType interpolation) => default; // 0x000000018933C598-0x000000018933C5F0
	}

	[Category("Tweening/Values")]
	public class TweenFloat : LatentActionNode<float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47530
	{
		// Properties
		public float value { get; private set; } // 0x0000000183D56A40-0x0000000183D56A50 0x0000000183D59110-0x0000000183D59120
	
		// Constructors
		public TweenFloat() {} // 0x0000000189343EE8-0x0000000189343F10
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(float from, float to, float duration = 1f /* Metadata: 0x01FBB676 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB67A */) => default; // 0x0000000189343E48-0x0000000189343EE8
	}

	[Category("Tweening/Values")]
	public class TweenVector3 : LatentActionNode<Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47532
	{
		// Properties
		public Vector3 value { get; private set; } // 0x0000000183D5D5B0-0x0000000183D5D5D0 0x0000000183D71C40-0x0000000183D71C50
	
		// Constructors
		public TweenVector3() {} // 0x000000018934431C-0x0000000189344344
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(Vector3 from, Vector3 to, float duration = 1f /* Metadata: 0x01FBB67B */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB67F */) => default; // 0x000000018934426C-0x000000018934431C
	}

	[Category("Tweening/Values")]
	public class TweenQuaternion : LatentActionNode<Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47534
	{
		// Properties
		public Quaternion value { get; private set; } // 0x0000000183D5D750-0x0000000183D5D760 0x0000000183D71AD0-0x0000000183D71AE0
	
		// Constructors
		public TweenQuaternion() {} // 0x000000018934408C-0x00000001893440B4
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(Quaternion from, Quaternion to, float duration = 1f /* Metadata: 0x01FBB680 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB684 */) => default; // 0x0000000189343FEC-0x000000018934408C
	}

	[Category("Tweening/Values")]
	public class TweenColor : LatentActionNode<UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 47536
	{
		// Properties
		public UnityEngine.Color value { get; private set; } // 0x0000000183D5D750-0x0000000183D5D760 0x0000000183D71AD0-0x0000000183D71AE0
	
		// Constructors
		public TweenColor() {} // 0x0000000189343E20-0x0000000189343E48
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(UnityEngine.Color from, UnityEngine.Color to, float duration = 1f /* Metadata: 0x01FBB685 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB689 */) => default; // 0x0000000189343D80-0x0000000189343E20
	}

	[Category("Tweening")]
	public class TweenPosition : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 47538
	{
		// Constructors
		public TweenPosition() {} // 0x0000000189343FC4-0x0000000189343FEC
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 position, float duration = 0.25f /* Metadata: 0x01FBB68A */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB68E */, bool relative = false /* Metadata: 0x01FBB68F */) => default; // 0x0000000189343F10-0x0000000189343FC4
	}

	[Category("Tweening")]
	public class TweenRotation : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 47540
	{
		// Constructors
		public TweenRotation() {} // 0x0000000189344168-0x0000000189344190
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 rotation, float duration = 0.25f /* Metadata: 0x01FBB690 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB694 */, bool relative = false /* Metadata: 0x01FBB695 */) => default; // 0x00000001893440B4-0x0000000189344168
	}

	[Category("Tweening")]
	public class TweenScale : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 47542
	{
		// Constructors
		public TweenScale() {} // 0x0000000189344244-0x000000018934426C
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 scale, float duration = 0.25f /* Metadata: 0x01FBB696 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x01FBB69A */, bool relative = false /* Metadata: 0x01FBB69B */) => default; // 0x0000000189344190-0x0000000189344244
	}

	[Category("Unity")]
	[Description("If \'Try Get Existing\' is true, then if there is an existing component of that type already attached to the gameobject, it will be returned instead of adding another instance.")]
	public class AddComponent<T> : CallableFunctionNode<T, GameObject, bool> // TypeDefIndex: 47543
		where T : Component
	{
		// Constructors
		public AddComponent() {}
	
		// Methods
		public override T Invoke(GameObject gameObject, bool tryGetExisting) => default;
	}

	[Category("Unity")]
	[Description("Get a component attached on an object")]
	public class GetComponent<T> : PureFunctionNode<T, GameObject> // TypeDefIndex: 47544
		where T : Component
	{
		// Fields
		private T _component;
	
		// Constructors
		public GetComponent() {}
	
		// Methods
		public override T Invoke(GameObject gameObject) => default;
	}

	[Category("Unity")]
	[Description("Instantiate an object")]
	[ExposeAsDefinition]
	public class Instantiate<T> : CallableFunctionNode<T, T, Vector3, Quaternion, Transform> // TypeDefIndex: 47545
		where T : UnityEngine.Object
	{
		// Constructors
		public Instantiate() {}
	
		// Methods
		public override T Invoke(T original, Vector3 position, Quaternion rotation, Transform parent) => default;
	}

	[Category("Unity")]
	[Description("Creates a new ScriptableObject instance")]
	public class NewScriptableObject<T> : CallableFunctionNode<T> // TypeDefIndex: 47546
		where T : ScriptableObject
	{
		// Constructors
		public NewScriptableObject() {}
	
		// Methods
		public override T Invoke() => default;
	}

	[Category("Unity")]
	[Description("Get all child transforms of specified parent")]
	public class GetChildTransforms : PureFunctionNode<IEnumerable<Transform>, Transform> // TypeDefIndex: 47547
	{
		// Constructors
		public GetChildTransforms() {} // 0x000000018933B35C-0x000000018933B384
	
		// Methods
		public override IEnumerable<Transform> Invoke(Transform parent) => default; // 0x000000018933B320-0x000000018933B35C
	}

	[Category("Utility")]
	[Description("Custom cast input object to type T. Note that casts are already automatic at a connection-level. Use this only if necessary in your setup.")]
	[ExposeAsDefinition]
	public class Cast<T> : PureFunctionNode<T, object> // TypeDefIndex: 47548
	{
		// Constructors
		public Cast() {}
	
		// Methods
		public override T Invoke(object obj) => default;
	}

	[Category("Utility")]
	[Description("Use this for organization. It returns exactly what is provided in the input.")]
	[ExposeAsDefinition]
	[Name("Identity", 10)]
	public class Identity<T> : PureFunctionNode<T, T> // TypeDefIndex: 47549
	{
		// Properties
		public override string name { get => default; }
	
		// Constructors
		public Identity() {}
	
		// Methods
		public override T Invoke(T value) => default;
	}

	[Category("Utility")]
	[Description("Caches the value only when the node is called.")]
	[ExposeAsDefinition]
	[Name("Cache", 9)]
	public class Cache<T> : CallableFunctionNode<T, T> // TypeDefIndex: 47550
	{
		// Constructors
		public Cache() {}
	
		// Methods
		public override T Invoke(T value) => default;
	}

	[Category("Utility")]
	[Description("Remaps from input min/max to output min/max, by current value provided between input min/max")]
	[Name("Remap To Float", 0)]
	public class RemapFloat : PureFunctionNode<float, float, float, float, float, float> // TypeDefIndex: 47551
	{
		// Constructors
		public RemapFloat() {} // 0x00000001893413D0-0x00000001893413F8
	
		// Methods
		public override float Invoke(float current, float iMin, float iMax = 1f /* Metadata: 0x01FBB69C */, float oMin = 0f /* Metadata: 0x01FBB6A0 */, float oMax = 100f /* Metadata: 0x01FBB6A4 */) => default; // 0x00000001893413A4-0x00000001893413D0
	}

	[Category("Utility")]
	[Description("Remaps from input min/max to output min/max, by current value provided between input min/max")]
	[Name("Remap To Vector3", 0)]
	public class RemapVector3 : PureFunctionNode<Vector3, float, float, float, Vector3, Vector3> // TypeDefIndex: 47552
	{
		// Constructors
		public RemapVector3() {} // 0x0000000189341474-0x000000018934149C
	
		// Methods
		public override Vector3 Invoke(float current, float iMin, float iMax, Vector3 oMin, Vector3 oMax) => default; // 0x00000001893413F8-0x0000000189341474
	}

	[Category("Utility")]
	[Description("Log input value on the console")]
	public class LogValue : CallableActionNode<object> // TypeDefIndex: 47553
	{
		// Constructors
		public LogValue() {} // 0x000000018933C798-0x000000018933C7C0
	
		// Methods
		public override void Invoke(object obj) {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("Utility")]
	[Description("Log text in the console")]
	public class LogText : CallableActionNode<string> // TypeDefIndex: 47554
	{
		// Constructors
		public LogText() {} // 0x000000018933C770-0x000000018933C798
	
		// Methods
		public override void Invoke(string text) {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("Utility")]
	[Description("Send a Local Event to specified graph")]
	public class SendEvent : CallableActionNode<GraphOwner, string> // TypeDefIndex: 47555
	{
		// Constructors
		public SendEvent() {} // 0x0000000189341648-0x0000000189341670
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName) {} // 0x0000000189341610-0x0000000189341648
	}

	[Category("Utility")]
	[Description("Send a Local Event with 1 argument to specified graph")]
	[ExposeAsDefinition]
	public class SendEvent<T> : CallableActionNode<GraphOwner, string, T> // TypeDefIndex: 47556
	{
		// Constructors
		public SendEvent() {}
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName, T eventValue) {}
	}

	[Category("Utility")]
	[Description("Send a Global Event to all graphs")]
	public class SendGlobalEvent : CallableActionNode<string> // TypeDefIndex: 47557
	{
		// Constructors
		public SendGlobalEvent() {} // 0x00000001893416C8-0x00000001893416F0
	
		// Methods
		public override void Invoke(string eventName) {} // 0x0000000189341670-0x00000001893416C8
	}

	[Category("Utility")]
	[Description("Send a Global Event with 1 argument to all graphs")]
	[ExposeAsDefinition]
	public class SendGlobalEvent<T> : CallableActionNode<string, T> // TypeDefIndex: 47558
	{
		// Constructors
		public SendGlobalEvent() {}
	
		// Methods
		public override void Invoke(string eventName, T eventValue) {}
	}

	public abstract class LatentActionNodeBase : SimplexNode // TypeDefIndex: 47562
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
		public override string name { get; } // 0x000000018933C3E4-0x000000018933C488 
		public virtual bool allowRoutineQueueing { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		public enum InvocationMode // TypeDefIndex: 47559
		{
			QueueCalls = 0,
			FilterCalls = 1
		}
	
		private struct RoutineData // TypeDefIndex: 47560
		{
			// Fields
			public IEnumerator enumerator; // 0x00
			public Flow flow; // 0x08
	
			// Constructors
			public RoutineData(IEnumerator enumerator, Flow flow) {
				this.enumerator = default;
				this.flow = default;
			} // 0x000000018386A6E0-0x000000018386A720
		}
	
		// Constructors
		protected LatentActionNodeBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public sealed override void OnGraphStarted() {} // 0x0000000183D71C00-0x0000000183D71C10
		public sealed override void OnGraphStoped() {} // 0x000000018933C1A8-0x000000018933C1B8
		protected void Begin(IEnumerator enumerator, Flow f) {} // 0x000000018933BEC8-0x000000018933C05C
		protected void BreakAll(bool callFinish) {} // 0x000000018933C05C-0x000000018933C120
		[IteratorStateMachine(typeof(_InternalCoroutine_d__15))]
		private IEnumerator InternalCoroutine(RoutineData data) => default; // 0x000000018933C120-0x000000018933C1A8
		protected override void OnRegisterPorts(FlowNode node) {} // 0x000000018933C1B8-0x000000018933C3CC
		protected abstract void OnRegisterDerivedPorts(FlowNode node);
		public virtual void OnBreak() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class LatentActionNode : LatentActionNodeBase // TypeDefIndex: 47563
	{
		// Constructors
		protected LatentActionNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract IEnumerator Invoke();
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {} // 0x000000018933C488-0x000000018933C540
	}

	public abstract class LatentActionNode<T1> : LatentActionNodeBase // TypeDefIndex: 47565
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2> : LatentActionNodeBase // TypeDefIndex: 47567
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3> : LatentActionNodeBase // TypeDefIndex: 47569
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4> : LatentActionNodeBase // TypeDefIndex: 47571
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5> : LatentActionNodeBase // TypeDefIndex: 47573
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6> : LatentActionNodeBase // TypeDefIndex: 47575
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7> : LatentActionNodeBase // TypeDefIndex: 47577
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : LatentActionNodeBase // TypeDefIndex: 47579
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : LatentActionNodeBase // TypeDefIndex: 47581
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : LatentActionNodeBase // TypeDefIndex: 47583
	{
		// Constructors
		protected LatentActionNode() {}
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNodeBase : SimplexNode // TypeDefIndex: 47584
	{
		// Constructors
		protected PureFunctionNodeBase() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class PureFunctionNode<TResult> : PureFunctionNodeBase // TypeDefIndex: 47585
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1> : PureFunctionNodeBase // TypeDefIndex: 47587
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2> : PureFunctionNodeBase // TypeDefIndex: 47589
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3> : PureFunctionNodeBase // TypeDefIndex: 47591
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4> : PureFunctionNodeBase // TypeDefIndex: 47593
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5> : PureFunctionNodeBase // TypeDefIndex: 47595
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : PureFunctionNodeBase // TypeDefIndex: 47597
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : PureFunctionNodeBase // TypeDefIndex: 47599
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : PureFunctionNodeBase // TypeDefIndex: 47601
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : PureFunctionNodeBase // TypeDefIndex: 47603
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : PureFunctionNodeBase // TypeDefIndex: 47605
	{
		// Constructors
		protected PureFunctionNode() {}
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node) {}
	}

	[SpoofAOT]
	public abstract class SimplexNode // TypeDefIndex: 47606
	{
		// Fields
		[NonSerialized]
		private string _name; // 0x10
		[NonSerialized]
		private string _description; // 0x18
		private ParameterInfo[] _parameters; // 0x28
	
		// Properties
		protected FlowNode parentNode { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public virtual string name { get; } // 0x0000000189341EBC-0x0000000189341FA0 
		public virtual string description { get; } // 0x0000000189341E14-0x0000000189341EBC 
		public ParameterInfo[] parameters { get; } // 0x0000000189341FA0-0x0000000189342064 
	
		// Constructors
		protected SimplexNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void RegisterPorts(FlowNode node) {} // 0x0000000189341BF8-0x0000000189341CF8
		public void SetDefaultParameters(FlowNode node) {} // 0x0000000189341CF8-0x0000000189341E14
		protected abstract void OnRegisterPorts(FlowNode node);
		protected virtual void OnRegisterExtraPorts(FlowNode node) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphStarted() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphPaused() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphUnpaused() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphStoped() {} // 0x000000018350B670-0x000000018350B680
	}

	[DoNotList]
	public abstract class SimplexNodeWrapper : FlowNode // TypeDefIndex: 47607
	{
		// Constructors
		protected SimplexNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	public class SimplexNodeWrapper<T> : SimplexNodeWrapper // TypeDefIndex: 47608
		where T : SimplexNode
	{
		// Fields
		[SerializeField]
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

	public delegate void EventUniversalDelegate(); // TypeDefIndex: 47609; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void EventUniversalDelegate<in T1>(T1 arg1); // TypeDefIndex: 47610; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2>(T1 arg1, T2 arg2); // TypeDefIndex: 47611; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 47612; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 47613; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 47614; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 47615; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7); // TypeDefIndex: 47616; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); // TypeDefIndex: 47617; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9); // TypeDefIndex: 47618; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10); // TypeDefIndex: 47619; 0x00000000-0x00000000

	[AttributeUsage(AttributeTargets.Class)]
	public class GeneratedKeyAttribute : Attribute // TypeDefIndex: 47620
	{
		// Fields
		private string memberString; // 0x10
	
		// Properties
		public string MemberName { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public GeneratedKeyAttribute() {} // Dummy constructor
		public GeneratedKeyAttribute(string memberName) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public struct ParamDef // TypeDefIndex: 47621
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

	public struct ParametresDef // TypeDefIndex: 47622
	{
		// Fields
		public List<ParamDef> paramDefinitions; // 0x00
		public ParamDef instanceDef; // 0x08
		public ParamDef resultDef; // 0x40
	}

	public enum ParamMode // TypeDefIndex: 47623
	{
		Undefined = 0,
		In = 1,
		Out = 2,
		Ref = 3,
		Instance = 4,
		Result = 6
	}

	public static class ReflectedNodesHelper // TypeDefIndex: 47624
	{
		// Fields
		private const string RETURN_VALUE_NAME = "Value"; // Metadata: 0x01FBB6B0
	
		// Methods
		public static ParamDef GetGetterDefFromInfo(MemberInfo info) => default; // 0x000000018933FD80-0x000000018933FFC0
		public static ParamDef GetDefFromInfo(ParameterInfo info, bool last) => default; // 0x000000018933FACC-0x000000018933FCA4
		public static bool InitParams(System.Type targetType, bool isStatic, MemberInfo[] infos, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x000000018933FFC0-0x000000018934028C
		private static bool InitParams(ParameterInfo[] prms, System.Type returnType, ref ParametresDef parametres) => default; // 0x000000018934028C-0x0000000189340544
		public static bool InitParams(ConstructorInfo constructor, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x0000000189340544-0x0000000189340714
		public static bool InitParams(MethodInfo method, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x0000000189340938-0x0000000189340B4C
		public static bool InitParams(System.Reflection.FieldInfo field, out ParametresDef parametres) {
			parametres = default;
			return default;
		} // 0x0000000189340714-0x0000000189340938
		public static string GetGeneratedKey(MemberInfo memberInfo) => default; // 0x000000018933FCA4-0x000000018933FD80
	}

	public delegate void UniversalDelegate(UniversalDelegateParam[] delegateParams); // TypeDefIndex: 47625; 0x0000000182149960-0x0000000182149970

	public abstract class UniversalDelegateParam // TypeDefIndex: 47626
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
		protected UniversalDelegateParam() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract System.Type GetCurrentType();
		public abstract void RegisterAsInput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node, Action beforeReturn);
		public abstract void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn);
		public abstract void SetFromInput();
		public abstract void SetFromValue(object value);
	}

	public class UniversalDelegateParam<T> : UniversalDelegateParam // TypeDefIndex: 47628
	{
		// Fields
		public T value;
		private ValueInput<T> valueInput;
		private static System.Reflection.FieldInfo _fieldInfo;
	
		// Properties
		public override System.Reflection.FieldInfo ValueField { get => default; }
	
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

	public class UniversalDelegateParam<TArray, TValue> : UniversalDelegateParam<TArray> // TypeDefIndex: 47629
	{
		// Fields
		private ValueInput<TValue>[] valueInputs;
	
		// Constructors
		public UniversalDelegateParam() {}
	
		// Methods
		public override void RegisterAsInput(FlowNode node) {}
		public override void SetFromInput() {}
	}

	public abstract class BaseReflectedConstructorNode // TypeDefIndex: 47630
	{
		// Fields
		protected ConstructorInfo constructorInfo; // 0x10
		protected List<ParamDef> paramDefinitions; // 0x18
		protected ParamDef instanceDef; // 0x20
		protected ParamDef resultDef; // 0x58
		protected ReflectedMethodRegistrationOptions options; // 0x90
	
		// Events
		protected static event Func<ConstructorInfo, BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode;
	
		// Constructors
		protected BaseReflectedConstructorNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static BaseReflectedConstructorNode GetConstructorNode(ConstructorInfo targetConstructor, ReflectedMethodRegistrationOptions options) => default; // 0x00000001893368D8-0x0000000189336A8C
		protected bool Init(ConstructorInfo constructor, ParametresDef parametres) => default; // 0x0000000189336A8C-0x0000000189336C84
		protected abstract bool InitInternal(ConstructorInfo constructor);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectionConstructorNode : BaseReflectedConstructorNode // TypeDefIndex: 47634
	{
		// Fields
		private object resultObject; // 0x98
		private object[] callParams; // 0xA0
		private ValueInput[] inputs; // 0xA8
		private ValueInput[] arrayInputs; // 0xB0
		private int arrayParamsInput; // 0xB8
		private System.Type arrayParamsType; // 0xC0
	
		// Constructors
		public PureReflectionConstructorNode() {} // 0x0000000183D6D0B0-0x0000000183D6D0C0
	
		// Methods
		protected override bool InitInternal(ConstructorInfo constructor) => default; // 0x000000018933E7B8-0x000000018933E92C
		private void Call() {} // 0x000000018933E62C-0x000000018933E7B8
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx) {} // 0x000000018933EAE4-0x000000018933EBE4
		private void RegisterInput(FlowNode node, ParamDef def, int idx) {} // 0x000000018933E92C-0x000000018933EAE4
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options) {} // 0x000000018933EBE4-0x000000018933EF38
	}

	[SpoofAOT]
	public class ReflectedDelegateEvent // TypeDefIndex: 47637
	{
		// Fields
		private Delegate theDelegate; // 0x18
	
		// Events
		private event DelegateEventCallback onCallback;
	
		// Nested types
		public delegate void DelegateEventCallback(params object[] args); // TypeDefIndex: 47635; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public ReflectedDelegateEvent() {} // 0x000000018350B670-0x000000018350B680
		public ReflectedDelegateEvent(System.Type delegateType) {} // 0x000000018933F928-0x000000018933F9A4
	
		// Methods
		public void Add(DelegateEventCallback callback) {} // 0x000000018933F45C-0x000000018933F464
		public void Remove(DelegateEventCallback callback) {} // 0x000000018933F920-0x000000018933F928
		public Delegate AsDelegate() => default; // 0x0000000181041090-0x00000001810410A0
		private MethodInfo GetMethodForDelegateType(System.Type delegateType) => default; // 0x000000018933F4BC-0x000000018933F920
		public void Callback0() {} // 0x000000018933F464-0x000000018933F4BC
		public void Callback1<T0>(T0 arg0) {}
		public void Callback2<T0, T1>(T0 arg0, T1 arg1) {}
		public void Callback3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) {}
		public void Callback4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		public void Callback5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public void Callback6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {}
		public void Callback7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
		public void Callback8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {}
		public void Callback9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {}
		public void Callback10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {}
		public static explicit operator Delegate(ReflectedDelegateEvent that) => default; // 0x00000001842C4004-0x00000001842C401C
	}

	[SpoofAOT]
	public class ReflectedUnityEvent // TypeDefIndex: 47640
	{
		// Fields
		private System.Type _eventType; // 0x18
		private MethodInfo _addListenerMethod; // 0x20
		private MethodInfo _removeListenerMethod; // 0x28
		private ParameterInfo[] _parameters; // 0x30
		private MethodInfo _callMethod; // 0x38
	
		// Properties
		public ParameterInfo[] parameters { get => default; } // 0x0000000181003830-0x0000000181003840 
		public System.Type eventType { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Events
		private event UnityEventCallback _callback;
	
		// Nested types
		public delegate void UnityEventCallback(params object[] args); // TypeDefIndex: 47638; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public ReflectedUnityEvent() {} // 0x000000018350B670-0x000000018350B680
		public ReflectedUnityEvent(System.Type eventType) {} // 0x0000000189341274-0x000000018934127C
	
		// Methods
		public void InitForEventType(System.Type eventType) {} // 0x0000000189340BA4-0x00000001893410DC
		public void StartListening(UnityEventBase targetEvent, UnityEventCallback callback) {} // 0x00000001893410DC-0x00000001893411A8
		public void StopListening(UnityEventBase targetEvent, UnityEventCallback callback) {} // 0x00000001893411A8-0x0000000189341274
		public void CallbackMethod0() {} // 0x0000000189340B4C-0x0000000189340BA4
		public void CallbackMethod1<T0>(T0 arg0) {}
		public void CallbackMethod2<T0, T1>(T0 arg0, T1 arg1) {}
		public void CallbackMethod3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) {}
		public void CallbackMethod4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
	}

	public abstract class SharpEvent // TypeDefIndex: 47641
	{
		// Properties
		public object instance { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public EventInfo eventInfo { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		protected SharpEvent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static SharpEvent Create(EventInfo eventInfo) => default; // 0x0000000189341A00-0x0000000189341B48
		public void SetInstance(object instance) {} // 0x000000018426FEE0-0x000000018426FEF0
		public void StartListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback) {} // 0x0000000189341B48-0x0000000189341BA0
		public void StopListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback) {} // 0x0000000189341BA0-0x0000000189341BF8
	}

	public class SharpEvent<T> : SharpEvent // TypeDefIndex: 47642
	{
		// Constructors
		public SharpEvent() {}
	}

	public abstract class BaseReflectedExtractorNode // TypeDefIndex: 47643
	{
		// Properties
		protected ParametresDef Params { get; private set; } // 0x0000000183D62B20-0x0000000183D62B70 0x0000000189337124-0x0000000189337174
		protected System.Type TargetType { get; private set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
	
		// Events
		protected static event Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode;
	
		// Constructors
		protected BaseReflectedExtractorNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static BaseReflectedExtractorNode GetExtractorNode(System.Type targetType, bool isStatic, MemberInfo[] infos) => default; // 0x0000000189336DBC-0x0000000189336F70
		protected bool Init(ParametresDef paramsDef, System.Type targetType) => default; // 0x0000000189336F70-0x0000000189336FEC
		protected abstract bool InitInternal();
		public abstract void RegisterPorts(FlowNode node);
	}

	public class PureReflectedExtractorNode : BaseReflectedExtractorNode // TypeDefIndex: 47646
	{
		// Fields
		private static readonly object[] EmptyParams; // 0x00
		private ValueInput instanceInput; // 0x90
	
		// Constructors
		public PureReflectedExtractorNode() {} // 0x000000018350B670-0x000000018350B680
		static PureReflectedExtractorNode() {} // 0x000000018933D714-0x000000018933D778
	
		// Methods
		protected override bool InitInternal() => default; // 0x000000018933D518-0x000000018933D53C
		private ValueHandlerObject GetPortHandler(System.Reflection.FieldInfo info) => default; // 0x000000018933D448-0x000000018933D518
		private ValueHandlerObject GetPortHandler(MethodInfo info) => default; // 0x000000018933D378-0x000000018933D448
		public override void RegisterPorts(FlowNode node) {} // 0x000000018933D53C-0x000000018933D714
	}

	public abstract class BaseReflectedFieldNode // TypeDefIndex: 47647
	{
		// Fields
		protected System.Reflection.FieldInfo fieldInfo; // 0x10
		protected ParamDef instanceDef; // 0x18
		protected ParamDef resultDef; // 0x50
	
		// Events
		protected static event Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode;
	
		// Constructors
		protected BaseReflectedFieldNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static BaseReflectedFieldNode GetFieldNode(System.Reflection.FieldInfo targetField) => default; // 0x0000000189337174-0x00000001893372FC
		protected bool Init(System.Reflection.FieldInfo field, ParametresDef parametres) => default; // 0x00000001893372FC-0x0000000189337460
		protected abstract bool InitInternal(System.Reflection.FieldInfo field);
		public abstract void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	public class PureReflectedFieldNode : BaseReflectedFieldNode // TypeDefIndex: 47649
	{
		// Fields
		private ValueInput instanceInput; // 0x88
		private ValueInput valueInput; // 0x90
		private object instanceObject; // 0x98
		private object valueObject; // 0xA0
	
		// Constructors
		public PureReflectedFieldNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override bool InitInternal(System.Reflection.FieldInfo method) => default; // 0x000000018933D7E8-0x000000018933D834
		private void SetValue() {} // 0x000000018933DB78-0x000000018933DC0C
		private void GetValue() {} // 0x000000018933D778-0x000000018933D7E8
		public override void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode) {} // 0x000000018933D834-0x000000018933DB78
	}

	public abstract class BaseReflectedMethodNode // TypeDefIndex: 47650
	{
		// Fields
		protected MethodInfo methodInfo; // 0x10
		protected List<ParamDef> paramDefinitions; // 0x18
		protected ParamDef instanceDef; // 0x20
		protected ParamDef resultDef; // 0x58
		protected ReflectedMethodRegistrationOptions options; // 0x90
	
		// Events
		protected static event Func<MethodInfo, BaseReflectedMethodNode> OnGetAotReflectedMethodNode;
	
		// Constructors
		protected BaseReflectedMethodNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static BaseReflectedMethodNode GetMethodNode(MethodInfo targetMethod, ReflectedMethodRegistrationOptions options) => default; // 0x0000000189337598-0x000000018933774C
		protected bool Init(MethodInfo method, ParametresDef parametres) => default; // 0x000000018933774C-0x0000000189337910
		protected abstract bool InitInternal(MethodInfo method);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectedMethodNode : BaseReflectedMethodNode // TypeDefIndex: 47654
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
	
		// Constructors
		public PureReflectedMethodNode() {} // 0x0000000183D71C30-0x0000000183D71C40
	
		// Methods
		protected override bool InitInternal(MethodInfo method) => default; // 0x000000018933DDF4-0x000000018933DF7C
		private void Call() {} // 0x000000018933DC2C-0x000000018933DDF4
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx) {} // 0x000000018933E134-0x000000018933E230
		private void RegisterInput(FlowNode node, ParamDef def, int idx) {} // 0x000000018933DF7C-0x000000018933E134
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options) {} // 0x000000018933E230-0x000000018933E62C
	}

	public class ReflectedConstructorNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 47655
	{
		// Fields
		[SerializeField]
		private SerializedConstructorInfo _constructor; // 0xB8
	
		// Properties
		private BaseReflectedConstructorNode reflectedConstructorNode { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		private ConstructorInfo constructor { get => default; } // 0x000000018933F32C-0x000000018933F340 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
		public override string name { get => default; } // 0x000000018933F340-0x000000018933F45C 
	
		// Constructors
		public ReflectedConstructorNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null) {} // 0x000000018933F2C4-0x000000018933F32C
		private void SetConstructor(ConstructorInfo newConstructor) {} // 0x000000018933F230-0x000000018933F2C4
		protected override void RegisterPorts() {} // 0x000000018933F160-0x000000018933F230
	}

	[Description("Chose and expose any number of fields or properties of the type. If you only require a single field / property, it\'s better to get that field / property directly without an Extractor.")]
	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public class ReflectedExtractorNodeWrapper<T> : FlowNode // TypeDefIndex: 47656
	{
		// Fields
		private static Dictionary<string, MemberInfo> _memberInfos;
		private static List<string> _instanceMemberNames;
		private static List<string> _staticMemberNames;
		[SerializeField]
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

	internal class ReflectedFieldNodeWrapper_0 // TypeDefIndex: 47657
	{
		// Fields
		[SerializeField]
		public string fieldName; // 0x10
		[SerializeField]
		public System.Type targetType; // 0x18
	
		// Constructors
		public ReflectedFieldNodeWrapper_0() {} // 0x000000018350B670-0x000000018350B680
	}

	[DoNotList]
	[fsMigrateVersions(new System.Type[1] {typeof(ReflectedFieldNodeWrapper_0) })]
	[Icon("", false, "GetRuntimeIconType")]
	public class ReflectedFieldNodeWrapper : FlowNode, IReflectedWrapper, IMigratable<ReflectedFieldNodeWrapper_0> // TypeDefIndex: 47659
	{
		// Fields
		[SerializeField]
		private SerializedFieldInfo _field; // 0xB0
		[SerializeField]
		private AccessMode accessMode; // 0xB8
	
		// Properties
		private BaseReflectedFieldNode reflectedFieldNode { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		private System.Reflection.FieldInfo field { get => default; } // 0x0000000187C03DD4-0x0000000187C03DE8 
		public override string name { get => default; } // 0x000000018935DC9C-0x000000018935DF1C 
	
		// Nested types
		public enum AccessMode // TypeDefIndex: 47658
		{
			GetField = 0,
			SetField = 1
		}
	
		// Constructors
		public ReflectedFieldNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		void IMigratable<ReflectedFieldNodeWrapper_0>.Migrate(ReflectedFieldNodeWrapper_0 model) {} // 0x000000018935D9F8-0x000000018935DAB8
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAD0-0x0000000183D4EAE0
		private System.Type GetRuntimeIconType() => default; // 0x000000018935D9A8-0x000000018935D9F8
		public void SetField(System.Reflection.FieldInfo newField, AccessMode mode, object instance = null) {} // 0x000000018935DB54-0x000000018935DC9C
		protected override void RegisterPorts() {} // 0x000000018935DAB8-0x000000018935DB54
	}

	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public abstract class ReflectedMethodBaseNodeWrapper : FlowNode, IReflectedWrapper // TypeDefIndex: 47660
	{
		// Fields
		[SerializeField]
		protected bool _callable; // 0xB0
		[SerializeField]
		protected bool _exposeParams; // 0xB1
		[SerializeField]
		protected int _exposedParamsCount; // 0xB4
	
		// Properties
		protected abstract ISerializedMethodBaseInfo serializedMethodBase { get; }
		private MethodBase method { get; } // 0x000000018935E170-0x000000018935E1FC 
		public bool callable { get; set; } // 0x0000000181151530-0x0000000181151540 0x000000018935E1FC-0x000000018935E214
		public bool exposeParams { get; set; } // 0x0000000183D51890-0x0000000183D518A0 0x000000018935E214-0x000000018935E240
		public int exposedParamsCount { get; set; } // 0x0000000183D51FA0-0x0000000183D51FB0 0x000000018935E240-0x000000018935E264
	
		// Constructors
		protected ReflectedMethodBaseNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x000000018935DFA8-0x000000018935DFB8
		public System.Type GetRuntimeIconType() => default; // 0x000000018935DF58-0x000000018935DFA8
		public abstract void SetMethodBase(MethodBase newMethod, object instance = null);
		public void SetDefaultParameterValues(MethodBase newMethod) {} // 0x000000018935DFB8-0x000000018935E0D0
		public void SetDropInstanceReference(MethodBase newMethod, object instance = null) {} // 0x000000018935E0D0-0x000000018935E170
	}

	public class ReflectedMethodNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 47661
	{
		// Fields
		[SerializeField]
		private SerializedMethodInfo _method; // 0xB8
	
		// Properties
		private BaseReflectedMethodNode reflectedMethodNode { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		private new MethodInfo method { get => default; } // 0x000000018935E6D8-0x000000018935E6EC 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
		public override string name { get => default; } // 0x000000018935E6EC-0x000000018935E9C4 
	
		// Constructors
		public ReflectedMethodNodeWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null) {} // 0x000000018935E4A0-0x000000018935E518
		private void SetMethod(MethodInfo newMethod, object instance = null) {} // 0x000000018935E518-0x000000018935E6D8
		public override void OnPortConnected(Port port, Port otherPort) {} // 0x000000018935E2B4-0x000000018935E414
		public override System.Type GetNodeWildDefinitionType() => default; // 0x000000018935E264-0x000000018935E2B4
		protected override void RegisterPorts() {} // 0x000000018935E414-0x000000018935E4A0
	}

	public struct ReflectedMethodRegistrationOptions // TypeDefIndex: 47662
	{
		// Fields
		public bool callable; // 0x00
		public bool exposeParams; // 0x01
		public int exposedParamsCount; // 0x04
	}

	[Description("Encapsulates a SubGraph able to control independently.")]
	public abstract class FlowNestedBase<T> : FlowNodeNested<T>, IDropedReferenceNode, IUpdatable // TypeDefIndex: 47664
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
	}

	[DropReferenceType(typeof(FlowScript))]
	[Icon("FS", false, "")]
	[Name("Sub Flow", 0)]
	public class FlowNestedFlow : FlowNestedBase<FlowScript> // TypeDefIndex: 47665
	{
		// Constructors
		public FlowNestedFlow() {} // 0x0000000189359444-0x0000000189359480
	}

	[Category("Variables/New")]
	[Description("Create a collection of <T> objects")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(List<T>) })]
	public class CreateCollection<T> : FlowNode // TypeDefIndex: 47668
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount;
	
		// Constructors
		public CreateCollection() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Variables/New")]
	[Description("Create a Dictionary of <string, T> objects")]
	[ContextDefinedInputs(new System.Type[2] {typeof(string), typeof(Wild) })]
	public class CreateDictionary<T> : FlowNode // TypeDefIndex: 47672
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount;
	
		// Constructors
		public CreateDictionary() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Variables/Blackboard")]
	[Description("Use this to get a variable value from blackboards other than the one this flowscript is using")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IBlackboard) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Get Other Of Type", 0)]
	public class GetOtherVariable<T> : FlowNode // TypeDefIndex: 47674
	{
		// Properties
		public override string name { get => default; }
	
		// Constructors
		public GetOtherVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Variables/New")]
	[Description("Returns a constant or linked variable value.\nYou can alter between constant or linked at any time using the radio button.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Graph Variable", 99)]
	public class GetVariable<T> : ParameterVariableNode // TypeDefIndex: 47675
	{
		// Fields
		public BBParameter<T> value;
	
		// Properties
		public override BBParameter parameter { get => default; }
	
		// Constructors
		public GetVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Category("Variables/Internal")]
	[Color("866693")]
	[Description("Can be used to set an internal variable, to later be retrieved with a \'Get Internal Var\' node. If you do not call \'Set\', then the input value will work as a relay instead.")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[Name("Set Internal Var", 0)]
	public abstract class RelayValueInputBase : FlowNode // TypeDefIndex: 47676
	{
		// Properties
		public abstract System.Type relayType { get; }
	
		// Constructors
		protected RelayValueInputBase() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	public class RelayValueInput<T> : RelayValueInputBase, IEditorMenuCallbackReceiver // TypeDefIndex: 47678
	{
		// Fields
		[DelayedField]
		[Tooltip("The identifier name of the internal var")]
		public string identifier;
	
		// Properties
		public ValueInput<T> port { get; private set; }
		public bool cached { get; private set; }
		public T cachedValue { get; private set; }
		public override System.Type relayType { get => default; }
		public override string name { get => default; }
	
		// Constructors
		public RelayValueInput() {}
	
		// Methods
		protected override void RegisterPorts() {}
	}

	[Color("866693")]
	[Description("Returns the selected and previously set Internal Variable\'s input value.")]
	[DoNotList]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class RelayValueOutputBase : FlowNode // TypeDefIndex: 47679
	{
		// Constructors
		protected RelayValueOutputBase() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public abstract void SetSource(RelayValueInputBase source);
	}

	public class RelayValueOutput<T> : RelayValueOutputBase // TypeDefIndex: 47680
	{
		// Fields
		[SerializeField]
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
	}

	[Category("Variables")]
	[Description("Simply returns a NULL")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Null", 0)]
	public class NullObject : FlowNode // TypeDefIndex: 47682
	{
		// Constructors
		public NullObject() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018935C720-0x000000018935C864
	}

	[Category("Variables")]
	[Description("Returns the Owner GameObject")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(GameObject) })]
	[Name("Self", 100)]
	public class OwnerVariable : FlowNode // TypeDefIndex: 47683
	{
		// Properties
		public override string name { get => default; } // 0x000000018935C99C-0x000000018935C9C8 
	
		// Constructors
		public OwnerVariable() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void RegisterPorts() {} // 0x000000018935C864-0x000000018935C91C
	}

	public abstract class ParameterVariableNode : FlowNode // TypeDefIndex: 47684
	{
		// Properties
		public abstract BBParameter parameter { get; }
	
		// Constructors
		protected ParameterVariableNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[Category("Variables/Blackboard")]
	[Description("Use this to set a variable value of blackboards other than the one this flowscript is using")]
	[ContextDefinedInputs(new System.Type[2] {typeof(NodeCanvas.Framework.Blackboard), typeof(Wild) })]
	[Name("Set Other Of Type", 0)]
	public class SetOtherVariable<T> : FlowNode // TypeDefIndex: 47686
	{
		// Fields
		public OperationMethod operation;
		private ValueInput<string> varName;
	
		// Properties
		public override string name { get => default; }
	
		// Constructors
		public SetOtherVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
		private void DoSet(NodeCanvas.Framework.Blackboard bb, string name, T value) {}
	}

	[Category("Variables/Blackboard")]
	[Description("Set a Blackboard variable value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[Name("Set Of Type", 10)]
	public class SetVariable<T> : ParameterVariableNode // TypeDefIndex: 47688
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> targetVariable;
		[HideInInspector]
		public OperationMethod operation;
		[HideInInspector]
		public bool perSecond;
	
		// Properties
		public override BBParameter parameter { get => default; }
		public override string name { get => default; }
	
		// Constructors
		public SetVariable() {}
	
		// Methods
		protected override void RegisterPorts() {}
		private void DoSet(T value) {}
	}

	[Obsolete]
	public abstract class CodeEventBase : EventNode<Transform> // TypeDefIndex: 47689
	{
		// Fields
		[SerializeField]
		protected string eventName; // 0xB8
		[SerializeField]
		protected System.Type targetType; // 0xC0
		protected Component targetComponent; // 0xC8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x0000000189358528-0x00000001893585B8 
	
		// Constructors
		protected CodeEventBase() {} // 0x00000001893584F4-0x0000000189358528
	
		// Methods
		public void SetEvent(EventInfo e, object instace = null) {} // 0x0000000189358460-0x00000001893584F4
		public override void OnPostGraphStarted() {} // 0x00000001893582D0-0x0000000189358460
	}

	[Obsolete]
	public class CodeEvent : CodeEventBase // TypeDefIndex: 47690
	{
		// Fields
		private FlowOutput o; // 0xD0
		private Action pointer; // 0xD8
	
		// Constructors
		public CodeEvent() {} // 0x0000000187E59944-0x0000000187E5994C
	
		// Methods
		public override void OnPostGraphStarted() {} // 0x00000001893586C8-0x000000018935877C
		public override void OnGraphStoped() {} // 0x0000000189358608-0x00000001893586C8
		protected override void RegisterPorts() {} // 0x000000018935877C-0x00000001893587E4
		private void Call() {} // 0x00000001893585B8-0x0000000189358608
	}

	[Obsolete]
	public class CodeEvent<T> : CodeEventBase // TypeDefIndex: 47691
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
	}

	[Obsolete]
	public class NewGameObject : CallableFunctionNode<GameObject, string, Vector3, Quaternion> // TypeDefIndex: 47692
	{
		// Constructors
		public NewGameObject() {} // 0x000000018935C5B0-0x000000018935C5D8
	
		// Methods
		public override GameObject Invoke(string name, Vector3 position, Quaternion rotation) => default; // 0x000000018935C4DC-0x000000018935C5B0
	}

	[Obsolete]
	public class NewVector2 : PureFunctionNode<Vector2, float, float> // TypeDefIndex: 47693
	{
		// Constructors
		public NewVector2() {} // 0x000000018935C6A8-0x000000018935C6D0
	
		// Methods
		public override Vector2 Invoke(float x, float y) => default; // 0x0000000183D71D90-0x0000000183D71DA0
	}

	[Obsolete]
	public class NewVector3 : PureFunctionNode<Vector3, float, float, float> // TypeDefIndex: 47694
	{
		// Constructors
		public NewVector3() {} // 0x000000018935C6D0-0x000000018935C6F8
	
		// Methods
		public override Vector3 Invoke(float x, float y, float z) => default; // 0x0000000183D71DA0-0x0000000183D71DC0
	}

	[Obsolete]
	public class NewVector4 : PureFunctionNode<Vector4, float, float, float, float> // TypeDefIndex: 47695
	{
		// Constructors
		public NewVector4() {} // 0x000000018935C6F8-0x000000018935C720
	
		// Methods
		public override Vector4 Invoke(float x, float y, float z, float w) => default; // 0x0000000183D71D60-0x0000000183D71D90
	}

	[Obsolete]
	public class NewQuaternion : PureFunctionNode<Quaternion, float, float, float, float> // TypeDefIndex: 47696
	{
		// Constructors
		public NewQuaternion() {} // 0x000000018935C5D8-0x000000018935C600
	
		// Methods
		public override Quaternion Invoke(float x, float y, float z, float w) => default; // 0x0000000183D71D60-0x0000000183D71D90
	}

	[Obsolete]
	public class NewColor : PureFunctionNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 47697
	{
		// Constructors
		public NewColor() {} // 0x000000018935C4B4-0x000000018935C4DC
	
		// Methods
		public override UnityEngine.Color Invoke(float r, float g, float b, float a = 1f /* Metadata: 0x01FBB6B8 */) => default; // 0x0000000183D71D60-0x0000000183D71D90
	}

	[Obsolete]
	public class NewBounds : PureFunctionNode<Bounds, Vector3, Vector3> // TypeDefIndex: 47698
	{
		// Constructors
		public NewBounds() {} // 0x000000018935C48C-0x000000018935C4B4
	
		// Methods
		public override Bounds Invoke(Vector3 center, Vector3 size) => default; // 0x000000018935C434-0x000000018935C48C
	}

	[Obsolete]
	public class NewRect : PureFunctionNode<Rect, float, float, float, float> // TypeDefIndex: 47699
	{
		// Constructors
		public NewRect() {} // 0x000000018935C680-0x000000018935C6A8
	
		// Methods
		public override Rect Invoke(float left, float top, float width, float height) => default; // 0x0000000183D71D60-0x0000000183D71D90
	}

	[Obsolete]
	public class NewRay : PureFunctionNode<Ray, Vector3, Vector3> // TypeDefIndex: 47700
	{
		// Constructors
		public NewRay() {} // 0x000000018935C658-0x000000018935C680
	
		// Methods
		public override Ray Invoke(Vector3 origin, Vector3 direction) => default; // 0x000000018935C600-0x000000018935C658
	}

	[Obsolete]
	public class ConvertTo<T> : PureFunctionNode<T, IConvertible> // TypeDefIndex: 47701
		where T : IConvertible
	{
		// Constructors
		public ConvertTo() {}
	
		// Methods
		public override T Invoke(IConvertible obj) => default;
	}

	[Obsolete]
	public class CastTo<T> : PureFunctionNode<T, object> // TypeDefIndex: 47702
	{
		// Constructors
		public CastTo() {}
	
		// Methods
		public override T Invoke(object obj) => default;
	}

	[Obsolete]
	public class ToArray<T> : PureFunctionNode<T[], IList<T>> // TypeDefIndex: 47703
	{
		// Constructors
		public ToArray() {}
	
		// Methods
		public override T[] Invoke(IList<T> list) => default;
	}

	[Obsolete]
	public class ToList<T> : PureFunctionNode<List<T>, IList<T>> // TypeDefIndex: 47704
	{
		// Constructors
		public ToList() {}
	
		// Methods
		public override List<T> Invoke(IList<T> list) => default;
	}

	[Obsolete("Use \'IReferencedObjectWrapper\' along with \'ReferencedObjectTypeAttribute\'")]
	public abstract class CustomObjectWrapper : FlowNode // TypeDefIndex: 47705
	{
		// Constructors
		protected CustomObjectWrapper() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public abstract void SetTarget(UnityEngine.Object target);
	}

	[Icon("", false, "GetRuntimeIconType")]
	[Obsolete("Use \'IReferencedObjectWrapper\' along with \'ReferencedObjectTypeAttribute\'")]
	public abstract class CustomObjectWrapper<T> : CustomObjectWrapper // TypeDefIndex: 47706
		where T : UnityEngine.Object
	{
		// Fields
		[SerializeField]
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

	[Obsolete]
	public class ExtractVector2 : ExtractorNode<Vector2, float, float> // TypeDefIndex: 47707
	{
		// Constructors
		public ExtractVector2() {} // 0x0000000189358FBC-0x0000000189358FE4
	
		// Methods
		public override void Invoke(Vector2 vector, out float x, out float y) {
			x = default;
			y = default;
		} // 0x0000000183D71D20-0x0000000183D71D40
	}

	[Obsolete]
	public class ExtractVector3 : ExtractorNode<Vector3, float, float, float> // TypeDefIndex: 47708
	{
		// Constructors
		public ExtractVector3() {} // 0x0000000189358FE4-0x000000018935900C
	
		// Methods
		public override void Invoke(Vector3 vector, out float x, out float y, out float z) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D71D40-0x0000000183D71D60
	}

	[Obsolete]
	public class ExtractVector4 : ExtractorNode<Vector4, float, float, float, float> // TypeDefIndex: 47709
	{
		// Constructors
		public ExtractVector4() {} // 0x000000018935900C-0x0000000189359034
	
		// Methods
		public override void Invoke(Vector4 vector, out float x, out float y, out float z, out float w) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D71CA0-0x0000000183D71CC0
	}

	[Obsolete]
	public class ExtractQuaternion : ExtractorNode<Quaternion, float, float, float, float, Vector3> // TypeDefIndex: 47710
	{
		// Constructors
		public ExtractQuaternion() {} // 0x0000000189358CB4-0x0000000189358CDC
	
		// Methods
		public override void Invoke(Quaternion quaternion, out float x, out float y, out float z, out float w, out Vector3 eulerAngles) {
			x = default;
			y = default;
			z = default;
			w = default;
			eulerAngles = default;
		} // 0x0000000189358C6C-0x0000000189358CB4
	}

	[Obsolete]
	public class ExtractRect : ExtractorNode<Rect, Vector2, float, float, float, float> // TypeDefIndex: 47711
	{
		// Constructors
		public ExtractRect() {} // 0x0000000189358F94-0x0000000189358FBC
	
		// Methods
		public override void Invoke(Rect rect, out Vector2 center, out float xMin, out float xMax, out float yMin, out float yMax) {
			center = default;
			xMin = default;
			xMax = default;
			yMin = default;
			yMax = default;
		} // 0x0000000189358F30-0x0000000189358F94
	}

	[Obsolete]
	public class ExtractColor : ExtractorNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 47712
	{
		// Constructors
		public ExtractColor() {} // 0x0000000189358B14-0x0000000189358B3C
	
		// Methods
		public override void Invoke(UnityEngine.Color color, out float r, out float g, out float b, out float a) {
			r = default;
			g = default;
			b = default;
			a = default;
		} // 0x0000000183D71CA0-0x0000000183D71CC0
	}

	[Obsolete]
	public class ExtractRaycastHit : ExtractorNode<RaycastHit, GameObject, float, Vector3, Vector3> // TypeDefIndex: 47713
	{
		// Constructors
		public ExtractRaycastHit() {} // 0x0000000189358F08-0x0000000189358F30
	
		// Methods
		public override void Invoke(RaycastHit hit, out GameObject gameObject, out float distance, out Vector3 normal, out Vector3 point) {
			gameObject = default;
			distance = default;
			normal = default;
			point = default;
		} // 0x0000000189358E4C-0x0000000189358F08
	}

	[Obsolete]
	public class ExtractRaycastHit2D : ExtractorNode<RaycastHit2D, GameObject, float, float, Vector3, Vector3> // TypeDefIndex: 47714
	{
		// Constructors
		public ExtractRaycastHit2D() {} // 0x0000000189358E24-0x0000000189358E4C
	
		// Methods
		public override void Invoke(RaycastHit2D hit, out GameObject gameObject, out float distance, out float fraction, out Vector3 normal, out Vector3 point) {
			gameObject = default;
			distance = default;
			fraction = default;
			normal = default;
			point = default;
		} // 0x0000000189358D04-0x0000000189358E24
	}

	[Obsolete]
	public class ExtractRay : ExtractorNode<Ray, Vector3, Vector3> // TypeDefIndex: 47715
	{
		// Constructors
		public ExtractRay() {} // 0x0000000189358CDC-0x0000000189358D04
	
		// Methods
		public override void Invoke(Ray ray, out Vector3 origin, out Vector3 direction) {
			origin = default;
			direction = default;
		} // 0x0000000183D71CF0-0x0000000183D71D20
	}

	[Obsolete]
	public class ExtractBounds : ExtractorNode<Bounds, Vector3, Vector3, Vector3, Vector3, Vector3> // TypeDefIndex: 47716
	{
		// Constructors
		public ExtractBounds() {} // 0x0000000189358924-0x000000018935894C
	
		// Methods
		public override void Invoke(Bounds bounds, out Vector3 center, out Vector3 extents, out Vector3 max, out Vector3 min, out Vector3 size) {
			center = default;
			extents = default;
			max = default;
			min = default;
			size = default;
		} // 0x000000018935888C-0x0000000189358924
	}

	[Obsolete]
	public class ExtractCollision : ExtractorNode<UnityEngine.Collision, ContactPoint[], ContactPoint, GameObject, Vector3> // TypeDefIndex: 47717
	{
		// Constructors
		public ExtractCollision() {} // 0x0000000189358AEC-0x0000000189358B14
	
		// Methods
		public override void Invoke(UnityEngine.Collision collision, out ContactPoint[] contacts, out ContactPoint firstContact, out GameObject gameObject, out Vector3 velocity) {
			contacts = default;
			firstContact = default;
			gameObject = default;
			velocity = default;
		} // 0x0000000189358A38-0x0000000189358AEC
	}

	[Obsolete]
	public class ExtractCollision2D : ExtractorNode<Collision2D, ContactPoint2D[], ContactPoint2D, GameObject, Vector2> // TypeDefIndex: 47718
	{
		// Constructors
		public ExtractCollision2D() {} // 0x0000000189358A10-0x0000000189358A38
	
		// Methods
		public override void Invoke(Collision2D collision, out ContactPoint2D[] contacts, out ContactPoint2D firstContact, out GameObject gameObject, out Vector2 velocity) {
			contacts = default;
			firstContact = default;
			gameObject = default;
			velocity = default;
		} // 0x000000018935894C-0x0000000189358A10
	}

	[Obsolete]
	public class ExtractContactPoint : ExtractorNode<ContactPoint, Vector3, Vector3, Collider, Collider> // TypeDefIndex: 47719
	{
		// Constructors
		public ExtractContactPoint() {} // 0x0000000189358C1C-0x0000000189358C44
	
		// Methods
		public override void Invoke(ContactPoint contactPoint, out Vector3 normal, out Vector3 point, out Collider colliderA, out Collider colliderB) {
			normal = default;
			point = default;
			colliderA = default;
			colliderB = default;
		} // 0x0000000189358BBC-0x0000000189358C1C
	}

	[Obsolete]
	public class ExtractContactPoint2D : ExtractorNode<ContactPoint2D, Vector2, Vector2, Collider2D, Collider2D> // TypeDefIndex: 47720
	{
		// Constructors
		public ExtractContactPoint2D() {} // 0x0000000189358B94-0x0000000189358BBC
	
		// Methods
		public override void Invoke(ContactPoint2D contactPoint, out Vector2 normal, out Vector2 point, out Collider2D colliderA, out Collider2D colliderB) {
			normal = default;
			point = default;
			colliderA = default;
			colliderB = default;
		} // 0x0000000189358B3C-0x0000000189358B94
	}

	[Obsolete]
	public class ExtractAnimationCurve : ExtractorNode<AnimationCurve, Keyframe[], float, UnityEngine.WrapMode, UnityEngine.WrapMode> // TypeDefIndex: 47721
	{
		// Constructors
		public ExtractAnimationCurve() {} // 0x0000000189358864-0x000000018935888C
	
		// Methods
		public override void Invoke(AnimationCurve curve, out Keyframe[] keys, out float length, out UnityEngine.WrapMode postWrapMode, out UnityEngine.WrapMode preWrapMode) {
			keys = default;
			length = default;
			postWrapMode = default;
			preWrapMode = default;
		} // 0x00000001893587E4-0x0000000189358864
	}

	[Obsolete]
	public class ExtractKeyFrame : ExtractorNode<Keyframe, float, float, float, float> // TypeDefIndex: 47722
	{
		// Constructors
		public ExtractKeyFrame() {} // 0x0000000189358C44-0x0000000189358C6C
	
		// Methods
		public override void Invoke(Keyframe key, out float inTangent, out float outTangent, out float time, out float value) {
			inTangent = default;
			outTangent = default;
			time = default;
			value = default;
		} // 0x0000000183D71CC0-0x0000000183D71CF0
	}

	[Obsolete]
	public class SwitchValue<T> : PureFunctionNode<T, bool, T, T> // TypeDefIndex: 47723
	{
		// Constructors
		public SwitchValue() {}
	
		// Methods
		public override T Invoke(bool condition, T isTrue, T isFalse) => default;
	}

	[Obsolete]
	public class PickValue<T> : PureFunctionNode<T, int, IList<T>> // TypeDefIndex: 47724
	{
		// Constructors
		public PickValue() {}
	
		// Methods
		public override T Invoke(int index, IList<T> values) => default;
	}

	[Obsolete]
	public abstract class StaticCodeEventBase : EventNode // TypeDefIndex: 47725
	{
		// Fields
		[SerializeField]
		protected string eventName; // 0xB0
		[SerializeField]
		protected System.Type targetType; // 0xB8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018935F484-0x000000018935F514 
	
		// Constructors
		protected StaticCodeEventBase() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public void SetEvent(EventInfo e) {} // 0x000000018935F3F0-0x000000018935F484
		public override void OnGraphStarted() {} // 0x000000018935F33C-0x000000018935F3F0
	}

	[Obsolete]
	public class StaticCodeEvent : StaticCodeEventBase // TypeDefIndex: 47726
	{
		// Fields
		private FlowOutput o; // 0xC0
		private Action pointer; // 0xC8
	
		// Constructors
		public StaticCodeEvent() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018935F564-0x000000018935F614
		public override void OnGraphStoped() {} // 0x0000000187D2ADE8-0x0000000187D2AE4C
		private void Call() {} // 0x000000018935F514-0x000000018935F564
		protected override void RegisterPorts() {} // 0x000000018935F614-0x000000018935F67C
	}

	[Obsolete]
	public class StaticCodeEvent<T> : StaticCodeEventBase // TypeDefIndex: 47727
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
	}

	[DropReferenceType(typeof(BehaviourTree))]
	[Name("Sub Tree", 0)]
	public class FlowNestedBT : FlowNestedBase<BehaviourTree> // TypeDefIndex: 47728
	{
		// Constructors
		public FlowNestedBT() {} // 0x000000018935914C-0x0000000189359188
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189359034-0x0000000189359108
	}

	[DropReferenceType(typeof(FSM))]
	[Name("Sub FSM", 0)]
	public class FlowNestedFSM : FlowNestedBase<FSM> // TypeDefIndex: 47729
	{
		// Constructors
		public FlowNestedFSM() {} // 0x0000000189359408-0x0000000189359444
	
		// Methods
		protected override void RegisterPorts() {} // 0x00000001893592F0-0x00000001893593C4
	}

	[DropReferenceType(typeof(DialogueTree))]
	[Name("Sub Dialogue", 0)]
	public class FlowNestedDT : FlowNestedBase<DialogueTree> // TypeDefIndex: 47730
	{
		// Constructors
		public FlowNestedDT() {} // 0x00000001893592B4-0x00000001893592F0
	
		// Methods
		protected override void RegisterPorts() {} // 0x0000000189359188-0x000000018935925C
	}

	[Description("Execute an encapsulated action without exposing any value ports")]
	public class TaskAction : FlowNode, ITaskAssignable<ActionTask> // TypeDefIndex: 47732
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0xB0
		private FlowOutput onFinish; // 0xB8
		private Coroutine coroutine; // 0xC0
	
		// Properties
		public override string name { get => default; } // 0x000000018935FA40-0x000000018935FA90 
		public ActionTask action { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x000000018935FA90-0x000000018935FAC8
		NodeCanvas.Framework.Task ITaskAssignable.task { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x000000018935F7C8-0x000000018935F81C
	
		// Constructors
		public TaskAction() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018935F838-0x000000018935F850
		public override void OnGraphStoped() {} // 0x000000018935F850-0x000000018935F8B0
		public override void OnGraphPaused() {} // 0x000000018935F81C-0x000000018935F838
		protected override void RegisterPorts() {} // 0x000000018935F8B0-0x000000018935F990
		[IteratorStateMachine(typeof(_DoUpdate_d__15))]
		private IEnumerator DoUpdate(Flow f) => default; // 0x000000018935F73C-0x000000018935F7C8
	}

	[Description("Returns an encapsulated condition check without exposing any value ports other than the boolean check")]
	public class TaskCondition : FlowNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 47733
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x000000018935FCA8-0x000000018935FCF8 
		public ConditionTask condition { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000182B47080-0x0000000182B470A0
		NodeCanvas.Framework.Task ITaskAssignable.task { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x000000018935FAC8-0x000000018935FB20
	
		// Constructors
		public TaskCondition() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018935FB20-0x000000018935FB78
		public override void OnGraphStoped() {} // 0x000000018935FB78-0x000000018935FB94
		protected override void RegisterPorts() {} // 0x000000018935FB94-0x000000018935FC4C
	}
}

namespace FlowCanvas.Nodes.Legacy
{
	[Obsolete]
	public abstract class ReflectedFieldNode // TypeDefIndex: 47734
	{
		// Constructors
		protected ReflectedFieldNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ReflectedFieldNode Create(System.Reflection.FieldInfo field) => default; // 0x000000018935DF1C-0x000000018935DF58
		public abstract void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	[Obsolete]
	public sealed class PureReflectedFieldNode : ReflectedFieldNode // TypeDefIndex: 47739
	{
		// Constructors
		public PureReflectedFieldNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode) {} // 0x000000018935C9C8-0x000000018935CE40
	}

	[Obsolete]
	public abstract class ReflectedMethodNode // TypeDefIndex: 47742
	{
		// Constructors
		public ReflectedMethodNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ReflectedMethodNode Create(MethodInfo method) => default; // 0x000000018935E9C4-0x000000018935EB90
		private static ReflectedMethodNode TryCreateJit(MethodInfo method) => default; // 0x000000018935ECA0-0x000000018935F33C
		public string GetName(MethodInfo method, int i) => default; // 0x000000018935EB90-0x000000018935ECA0
		public abstract void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class PureReflectedMethodNode : ReflectedMethodNode // TypeDefIndex: 47746
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
	
		// Constructors
		public PureReflectedMethodNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {} // 0x000000018935D0A8-0x000000018935D820
		private object CallMethod() => default; // 0x000000018935CE40-0x000000018935D0A8
	}

	[Obsolete]
	public sealed class ReflectedActionNode : ReflectedMethodNode // TypeDefIndex: 47748
	{
		// Fields
		private ActionCall call; // 0x10
	
		// Constructors
		public ReflectedActionNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private void Call() {} // 0x000000018935D820-0x000000018935D844
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {} // 0x000000018935D844-0x000000018935D9A8
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1> : ReflectedMethodNode // TypeDefIndex: 47750
	{
		// Fields
		private ActionCall<T1> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2> : ReflectedMethodNode // TypeDefIndex: 47752
	{
		// Fields
		private ActionCall<T1, T2> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3> : ReflectedMethodNode // TypeDefIndex: 47754
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4> : ReflectedMethodNode // TypeDefIndex: 47756
	{
		// Fields
		private ActionCall<T1, T2, T3, T4> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5> : ReflectedMethodNode // TypeDefIndex: 47758
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6> : ReflectedMethodNode // TypeDefIndex: 47760
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> : ReflectedMethodNode // TypeDefIndex: 47762
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : ReflectedMethodNode // TypeDefIndex: 47764
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7, T8> call;
		private T1 instance;
	
		// Constructors
		public ReflectedActionNode() {}
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) {}
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<TResult> : ReflectedMethodNode // TypeDefIndex: 47767
	{
		// Fields
		private FunctionCall<TResult> call;
		private TResult returnValue;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call() => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, TResult> : ReflectedMethodNode // TypeDefIndex: 47770
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, TResult> : ReflectedMethodNode // TypeDefIndex: 47773
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, TResult> : ReflectedMethodNode // TypeDefIndex: 47776
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, TResult> : ReflectedMethodNode // TypeDefIndex: 47779
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> : ReflectedMethodNode // TypeDefIndex: 47782
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> : ReflectedMethodNode // TypeDefIndex: 47785
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> : ReflectedMethodNode // TypeDefIndex: 47788
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ReflectedMethodNode // TypeDefIndex: 47791
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Constructors
		public ReflectedFunctionNode() {}
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) => default;
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options) {}
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 47168
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 48497
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x00000001893BD8A4-0x00000001893BD908
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 48498
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001893BD94C-0x00000001893BD9E0
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x00000001893BD908-0x00000001893BD94C
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 48499
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001893BF7FC-0x00000001893BF860
		public static bool IsPatched(int id) => default; // 0x00000001893BF8EC-0x00000001893BF984
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001893BF6B8-0x00000001893BF784
		public object CreateWrapper(int id) => default; // 0x00000001893BF784-0x00000001893BF7FC
		public object InitWrapperArray(int len) => default; // 0x00000001893BF860-0x00000001893BF8EC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001893BF614-0x00000001893BF6B8
	}
}

namespace NodeCanvas
{
	public static class AssemblyWrapUtils // TypeDefIndex: 47807
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

	[AddComponentMenu("NodeCanvas/Standalone Action List (Bonus)")]
	public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 47808
	{
		// Fields
		public bool playOnAwake; // 0x18
		[SerializeField]
		private string _serializedList; // 0x20
		[SerializeField]
		private List<UnityEngine.Object> _objectReferences; // 0x28
		[SerializeField]
		private NodeCanvas.Framework.Blackboard _blackboard; // 0x30
		[NonSerialized]
		private ActionList _actionList; // 0x38
		private float timeStarted; // 0x40
	
		// Properties
		public ActionList actionList { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public float elapsedTime { get => default; } // 0x000000018934A53C-0x000000018934A558 
		public float deltaTime { get => default; } // 0x000000018426F800-0x000000018426F808 
		UnityEngine.Object ITaskSystem.contextObject { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		Component ITaskSystem.agent { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		public IBlackboard blackboard { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x000000018934A558-0x000000018934A5CC
	
		// Constructors
		public ActionListPlayer() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018934A274-0x000000018934A3A0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018934A170-0x000000018934A274
		public static ActionListPlayer Create() => default; // 0x0000000189349FE8-0x000000018934A064
		protected void Awake() {} // 0x0000000189349FBC-0x0000000189349FE8
		public void UpdateTasksOwner() {} // 0x000000018934A3A0-0x000000018934A53C
		void ITaskSystem.SendEvent(string name, object value, object sender) {} // 0x000000018350B670-0x000000018350B680
		void ITaskSystem.SendEvent<T>(string name, T value, object sender) {}
		[ContextMenu("Play")]
		public void Play() {} // 0x000000018934A14C-0x000000018934A170
		public void Play(Action<NodeCanvas.Framework.Status> OnFinish) {} // 0x000000018934A128-0x000000018934A14C
		public void Play(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> OnFinish) {} // 0x000000018934A0B8-0x000000018934A128
		public NodeCanvas.Framework.Status Execute() => default; // 0x000000018934A08C-0x000000018934A0B8
		public NodeCanvas.Framework.Status Execute(Component agent) => default; // 0x000000018934A064-0x000000018934A08C
	}
}

namespace NodeCanvas.BehaviourTrees
{
	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Behaviour Tree Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class BehaviourTree : NodeCanvas.Framework.Graph // TypeDefIndex: 48113
	{
		// Fields
		[NonSerialized]
		public bool repeat; // 0xA0
		[NonSerialized]
		public float updateInterval; // 0xA4
		private float intervalCounter; // 0xA8
		private NodeCanvas.Framework.Status _rootStatus; // 0xAC
	
		// Properties
		public NodeCanvas.Framework.Status rootStatus { get => default; private set {} } // 0x0000000183D51880-0x0000000183D51890 0x0000000189377C34-0x0000000189377CA0
		public override System.Type baseNodeType { get => default; } // 0x0000000189377B48-0x0000000189377B98 
		public override bool requiresAgent { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool requiresPrimeNode { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool isTree { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool allowBlackboardOverrides { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public sealed override bool canAcceptVariableDrops { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Events
		public static event Action<BehaviourTree, NodeCanvas.Framework.Status> onRootStatusChanged;
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 48112
		{
			// Fields
			public bool repeat; // 0x10
			public float updateInterval; // 0x14
	
			// Constructors
			public DerivedSerializationData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public BehaviourTree() {} // 0x0000000189377A50-0x0000000189377AAC
	
		// Methods
		public override object OnDerivedDataSerialization() => default; // 0x0000000189377888-0x00000001893778E8
		public override void OnDerivedDataDeserialization(object data) {} // 0x00000001893777DC-0x0000000189377888
		protected override void OnGraphStarted() {} // 0x00000001893778E8-0x0000000189377924
		protected override void OnGraphUpdate() {} // 0x0000000189377924-0x00000001893779CC
		private NodeCanvas.Framework.Status Tick(Component agent, IBlackboard blackboard) => default; // 0x00000001893779CC-0x0000000189377A50
	}

	[AddComponentMenu("NodeCanvas/Behaviour Tree Owner")]
	public class BehaviourTreeOwner : GraphOwner<BehaviourTree> // TypeDefIndex: 48114
	{
		// Properties
		public bool repeat { get => default; set {} } // 0x00000001893774D8-0x000000018937756C 0x000000018937769C-0x000000018937773C
		public float updateInterval { get => default; set {} } // 0x0000000189377604-0x000000018937769C 0x000000018937773C-0x00000001893777DC
		public NodeCanvas.Framework.Status rootStatus { get => default; } // 0x000000018937756C-0x0000000189377604 
	
		// Constructors
		public BehaviourTreeOwner() {} // 0x00000001893774A4-0x00000001893774D8
	
		// Methods
		public NodeCanvas.Framework.Status Tick() => default; // 0x0000000189377404-0x00000001893774A4
	}

	public class BTConnection : Connection // TypeDefIndex: 48115
	{
		// Constructors
		public BTConnection() {} // 0x0000000183D5CDB0-0x0000000183D5CDC0
	}

	public abstract class BTNode : NodeCanvas.Framework.Node // TypeDefIndex: 48116
	{
		// Properties
		public sealed override System.Type outConnectionType { get; } // 0x00000001893773B4-0x0000000189377404 
		public sealed override bool allowAsPrime { get; } // 0x000000018232EB60-0x000000018232EB70 
		public sealed override bool canSelfConnect { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public override Alignment2x2 iconAlignment { get; } // 0x0000000181002730-0x0000000181002740 
		public override int maxInConnections { get; } // 0x0000000181168950-0x0000000181168960 
		public override int maxOutConnections { get; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		protected BTNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public T AddChild<T>(int childIndex)
			where T : BTNode => default;
		public T AddChild<T>()
			where T : BTNode => default;
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class BTNodeNested<T> : BTNode, IGraphAssignable<T> // TypeDefIndex: 48117
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
	
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

	public abstract class BTComposite : BTNode // TypeDefIndex: 48118
	{
		// Properties
		public override string name { get; } // 0x00000001893768E4-0x0000000189376908 
		public sealed override int maxOutConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		protected BTComposite() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	public abstract class BTDecorator : BTNode // TypeDefIndex: 48119
	{
		// Properties
		public sealed override int maxOutConnections { get; } // 0x0000000181168950-0x0000000181168960 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000182102C70-0x0000000182102C80 
		protected Connection decoratedConnection { get; } // 0x00000001893770AC-0x0000000189377110 
		protected NodeCanvas.Framework.Node decoratedNode { get; } // 0x0000000189377110-0x000000018937712C 
	
		// Constructors
		protected BTDecorator() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Quick way to execute the left or the right child, based on a Condition Task.")]
	[Icon("Condition", false, "")]
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 48120
	{
		// Fields
		[Tooltip("If true, the condition will be re-evaluated per frame.")]
		public bool dynamic; // 0x98
		[SerializeField]
		private ConditionTask _condition; // 0xA0
		private int succeedIndex; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override Alignment2x2 commentsAlignment { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000189377DFC-0x0000000189377E54
		private ConditionTask condition { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
	
		// Constructors
		public BinarySelector() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189377CA0-0x0000000189377DE0
		protected override void OnReset() {} // 0x0000000189377DE0-0x0000000189377DFC
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Works like a normal Selector, but when a child returns Success, that child will be moved to the end.\nAs a result, previously Failed children will always be checked first and recently Successful children last.")]
	[Icon("FlipSelector", false, "")]
	public class FlipSelector : BTComposite // TypeDefIndex: 48121
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public FlipSelector() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018937D904-0x000000018937D9E4
		private void SendToBack(int i) {} // 0x000000018937D9E4-0x000000018937DA8C
		protected override void OnReset() {} // 0x0000000183D71EB0-0x0000000183D71EC0
	}

	[Category("Composites")]
	[Color("ff64cb")]
	[Description("Executes all children simultaneously and return Success or Failure depending on the selected Policy.")]
	[Icon("Parallel", false, "")]
	[Name("Parallel", 8)]
	public class Parallel : BTComposite // TypeDefIndex: 48123
	{
		// Fields
		[Tooltip("The policy determines when the Parallel node will end and return its Status.")]
		public ParallelPolicy policy; // 0x98
		[Name("Repeat", 0)]
		[Tooltip("If true, finished children are repeated until the Policy set is met, or until all children have had a chance to finish at least once.")]
		public bool dynamic; // 0x9C
		private bool[] finishedConnections; // 0xA0
		private int finishedConnectionsCount; // 0xA8
	
		// Nested types
		public enum ParallelPolicy // TypeDefIndex: 48122
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}
	
		// Constructors
		public Parallel() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189387B50-0x0000000189387BC0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018938796C-0x0000000189387B50
		protected override void OnReset() {} // 0x0000000189387BC0-0x0000000189387C04
		private void ResetRunning() {} // 0x0000000189387C04-0x0000000189387CA4
	}

	internal class PrioritySelector_0 : BTComposite // TypeDefIndex: 48124
	{
		// Fields
		[SerializeField]
		public List<BBParameter<float>> priorities; // 0x98
	
		// Constructors
		public PrioritySelector_0() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Used for Utility AI, the Priority Selector executes the child with the highest utility weight. If it fails, the Priority Selector will continue with the next highest utility weight child until one Succeeds, or until all Fail (similar to how a normal Selector does).\n\nEach child branch represents a desire, where each desire has one or more consideration which are all averaged.\nConsiderations are a pair of input value and curve, which together produce the consideration utility weight.")]
	[fsMigrateVersions(new System.Type[1] {typeof(PrioritySelector_0) })]
	[Icon("Priority", false, "")]
	public class PrioritySelector : BTComposite, IMigratable<PrioritySelector_0> // TypeDefIndex: 48127
	{
		// Fields
		[AutoSortWithChildrenConnections]
		public List<Desire> desires; // 0x98
		private Connection[] orderedConnections; // 0xA0
		private int current; // 0xA8
	
		// Nested types
		[Serializable]
		public class Desire // TypeDefIndex: 48125
		{
			// Fields
			[fsIgnoreInBuild]
			public string name; // 0x10
			[fsIgnoreInBuild]
			public bool foldout; // 0x18
			public List<Consideration> considerations; // 0x20
	
			// Constructors
			public Desire() {} // 0x0000000189379CDC-0x0000000189379D54
	
			// Methods
			public Consideration AddConsideration(IBlackboard bb) => default; // 0x0000000189379B58-0x0000000189379BE8
			public void RemoveConsideration(Consideration consideration) {} // 0x0000000189379C88-0x0000000189379CDC
			public float GetCompoundUtility() => default; // 0x0000000189379BE8-0x0000000189379C88
		}
	
		[Serializable]
		public class Consideration // TypeDefIndex: 48126
		{
			// Fields
			public BBParameter<float> input; // 0x10
			public BBParameter<AnimationCurve> function; // 0x18
	
			// Properties
			public float utility { get => default; } // 0x00000001893794E4-0x000000018937959C 
	
			// Constructors
			public Consideration() {} // Dummy constructor
			public Consideration(IBlackboard blackboard) {} // 0x00000001893793F8-0x00000001893794E4
		}
	
		// Constructors
		public PrioritySelector() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		void IMigratable<PrioritySelector_0>.Migrate(PrioritySelector_0 model) {} // 0x0000000189387F84-0x00000001893881DC
		public override void OnChildConnected(int index) {} // 0x0000000189387CA4-0x0000000189387DC0
		public override void OnChildDisconnected(int index) {} // 0x0000000189387DC0-0x0000000189387E18
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189387E18-0x0000000189387F84
		protected override void OnReset() {} // 0x0000000183D71ED0-0x0000000183D71EE0
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Selects a child to execute based on its chance to be selected and returns Success if the child returns Success, otherwise picks another child.\nReturns Failure if all children return Failure, or a direct \'Failure Chance\' is introduced.")]
	[Icon("ProbabilitySelector", false, "")]
	public class ProbabilitySelector : BTComposite // TypeDefIndex: 48128
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[Tooltip("The weights of the children.")]
		public List<BBParameter<float>> childWeights; // 0x98
		[Tooltip("A chance for the node to fail immediately.")]
		public BBParameter<float> failChance; // 0xA0
		private bool[] indexFailed; // 0xA8
		private float[] tmpWeights; // 0xB0
		private float tmpFailWeight; // 0xB8
		private float tmpTotal; // 0xBC
		private float tmpDice; // 0xC0
	
		// Constructors
		public ProbabilitySelector() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnChildConnected(int index) {} // 0x000000018938843C-0x00000001893885A4
		public override void OnChildDisconnected(int index) {} // 0x00000001893885FC-0x0000000189388654
		public override void OnGraphStarted() {} // 0x0000000189388B54-0x0000000189388B64
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189388654-0x00000001893888DC
		protected override void OnReset() {} // 0x0000000189388B64-0x0000000189388C04
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Executes its childrfen in order and returns Failure if all children return Failure. As soon as a child returns Success, the Selector will stop and return Success as well.")]
	[Icon("Selector", false, "")]
	[Name("Selector", 9)]
	public class Selector : BTComposite // TypeDefIndex: 48129
	{
		// Fields
		[Tooltip("If true, then higher priority children are re-evaluated per frame and if either returns Success, then the Selector will immediately stop and return Success as well.")]
		public bool dynamic; // 0x98
		[Tooltip("If true, the children order of execution is shuffled each time the Selector resets.")]
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Selector() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189388FA0-0x0000000189389120
		protected override void OnReset() {} // 0x0000000189389120-0x0000000189389178
		public override void OnChildDisconnected(int index) {} // 0x0000000189388F8C-0x0000000189388FA0
		public override void OnGraphStarted() {} // 0x0000000189388B54-0x0000000189388B64
	}

	[Category("Composites")]
	[Color("bf7fff")]
	[Description("Executes its children in order and returns Success if all children return Success. As soon as a child returns Failure, the Sequencer will stop and return Failure as well.")]
	[Icon("Sequencer", false, "")]
	[Name("Sequencer", 10)]
	public class Sequencer : BTComposite // TypeDefIndex: 48130
	{
		// Fields
		[Tooltip("If true, then higher priority children are re-evaluated per frame and if either returns Failure, then the Sequencer will immediately stop and return Failure as well.")]
		public bool dynamic; // 0x98
		[Tooltip("If true, the children order of execution is shuffled each time the Sequencer resets.")]
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Sequencer() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189389178-0x00000001893892F8
		protected override void OnReset() {} // 0x00000001893892F8-0x0000000189389350
		public override void OnChildDisconnected(int index) {} // 0x0000000189388F8C-0x0000000189388FA0
		public override void OnGraphStarted() {} // 0x0000000189388B54-0x0000000189388B64
	}

	[Category("Composites")]
	[Color("bf7fff")]
	[Description("In comparison to a normal Sequencer which executes all its children until one fails, Step Sequencer executes its children one-by-one per Step Sequencer execution. The executed child status is returned regardless of Success or Failure.")]
	[Icon("StepIterator", false, "")]
	[Name("Step Sequencer", 0)]
	public class StepIterator : BTComposite // TypeDefIndex: 48131
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public StepIterator() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000183D71EB0-0x0000000183D71EC0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189389CB8-0x0000000189389D50
		protected override void OnReset() {} // 0x0000000183D71EF0-0x0000000183D71F00
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Executes one child based on the provided int or enum case and returns its status.")]
	[Icon("IndexSwitcher", false, "")]
	public class Switch : BTComposite // TypeDefIndex: 48134
	{
		// Fields
		[Tooltip("If true and the \'case\' change while a child is running, that child will immediately be interrupted and the new child will be executed.")]
		public bool dynamic; // 0x98
		[Tooltip("The selection mode used.")]
		public CaseSelectionMode selectionMode; // 0x9C
		[ShowIf("selectionMode", 0)]
		public BBParameter<int> intCase; // 0xA0
		[ShowIf("selectionMode", 0)]
		public OutOfRangeMode outOfRangeMode; // 0xA8
		[BlackboardOnly]
		[ShowIf("selectionMode", 1)]
		public BBObjectParameter enumCase; // 0xB0
		private Dictionary<int, int> enumCasePairing; // 0xB8
		private int current; // 0xC0
		private int runningIndex; // 0xC4
	
		// Nested types
		public enum CaseSelectionMode // TypeDefIndex: 48132
		{
			IndexBased = 0,
			EnumBased = 1
		}
	
		public enum OutOfRangeMode // TypeDefIndex: 48133
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}
	
		// Constructors
		public Switch() {} // 0x000000018938ACB0-0x000000018938AD74
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018938AB2C-0x000000018938ACB0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018938A8FC-0x000000018938AB2C
	}

	[Category("Decorators")]
	[Description("Executes and returns the child status only if the condition is true. Returns Failure if the condition is false.")]
	[Icon("Accessor", false, "")]
	[Name("Conditional", 0)]
	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 48135
	{
		// Fields
		[Name("Dynamic", 0)]
		[Tooltip("If enabled, the condition is re-evaluated per frame and the child is aborted if the condition becomes false.")]
		public bool isDynamic; // 0x98
		[Tooltip("The status that will be returned if the assigned condition is or becomes false.")]
		public CompactStatus conditionFailReturn; // 0x9C
		[SerializeField]
		private ConditionTask _condition; // 0xA0
		private bool accessed; // 0xA8
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000189378A34-0x0000000189378A8C
		private ConditionTask condition { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
	
		// Constructors
		public ConditionalEvaluator() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x00000001893788F4-0x00000001893789FC
		protected override void OnReset() {} // 0x00000001893789FC-0x0000000189378A34
	}

	[Category("Decorators")]
	[Description("Filters the access of its child either a specific number of times, or every specific amount of time.")]
	[Icon("Filter", false, "")]
	[Name("Filter", 0)]
	public class Filter : BTDecorator // TypeDefIndex: 48139
	{
		// Fields
		[Tooltip("The mode to use.")]
		public FilterMode filterMode; // 0x98
		[Name("Max Times", 0)]
		[ShowIf("filterMode", 0)]
		[Tooltip("The max ammount of times to allow the child to execute until the tree is completely restarted.")]
		public BBParameter<int> maxCount; // 0xA0
		[Name("Increase Count When", 0)]
		[ShowIf("filterMode", 0)]
		[Tooltip("Only increase count if the selected status is returned from the child.")]
		public Policy policy; // 0xA8
		[ShowIf("filterMode", 1)]
		[Tooltip("The time to disallow execution for.")]
		public BBParameter<float> coolDownTime; // 0xB0
		[Name("Optional When Filtered", 0)]
		[Tooltip("If enabled, the Filter Decorator will return an Optional status when it is filtered. Otherwise it will return Failure.")]
		public bool inactiveWhenLimited; // 0xB8
		private int executedCount; // 0xBC
		private float currentTime; // 0xC0
		private float targetTime; // 0xC4
	
		// Nested types
		public enum FilterMode // TypeDefIndex: 48136
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}
	
		public enum Policy // TypeDefIndex: 48137
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}
	
		// Constructors
		public Filter() {} // 0x000000018937D808-0x000000018937D8A4
	
		// Methods
		public override void OnGraphStoped() {} // 0x000000018350B670-0x000000018350B680
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018937D618-0x000000018937D808
		public override void OnClearNodeData() {} // 0x0000000183D71EA0-0x0000000183D71EB0
		[IteratorStateMachine(typeof(_Cooldown_d__13))]
		private IEnumerator Cooldown() => default; // 0x000000018937D5BC-0x000000018937D618
	}

	[Category("Decorators")]
	[Description("Protects the decorated child from running if another Guard with the same token is already guarding (Running) that token.\nGuarding is global for all of the agent Behaviour Trees.")]
	[Icon("Shield", false, "")]
	[Name("Guard", 0)]
	public class Guard : BTDecorator // TypeDefIndex: 48141
	{
		// Fields
		[Tooltip("A unique Token to use for guarding.")]
		public BBParameter<string> token; // 0x98
		[Tooltip("What to return in case the token is already guarded by another Guard.")]
		public GuardMode ifGuarded; // 0xA0
		private bool isGuarding; // 0xA4
		private static readonly Dictionary<GameObject, List<Guard>> guards; // 0x00
	
		// Nested types
		public enum GuardMode // TypeDefIndex: 48140
		{
			ReturnFailure = 0,
			WaitUntilReleased = 1
		}
	
		// Constructors
		public Guard() {} // 0x0000000185F46E3C-0x0000000185F46E44
		static Guard() {} // 0x000000018938493C-0x00000001893849C8
	
		// Methods
		private static List<Guard> AgentGuards(Component agent) => default; // 0x00000001893841EC-0x0000000189384274
		public override void OnGraphStarted() {} // 0x0000000189384478-0x000000018938449C
		public override void OnGraphStoped() {} // 0x000000018938449C-0x0000000189384748
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189384274-0x0000000189384478
		protected override void OnReset() {} // 0x0000000183D71EC0-0x0000000183D71ED0
		private void SetGuards(Component guardAgent) {} // 0x0000000189384748-0x000000018938493C
	}

	[Category("Decorators")]
	[Description("Executes and returns the child status. If the condition is or becomes true, the child is interrupted and returns Failure.")]
	[Icon("Interruptor", false, "")]
	[Name("Interrupt", 0)]
	public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 48142
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
	
		// Properties
		public ConditionTask condition { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x0000000189384AAC-0x0000000189384B04
	
		// Constructors
		public Interruptor() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x00000001893849C8-0x0000000189384AAC
		protected override void OnReset() {} // 0x0000000189378828-0x0000000189378844
	}

	[Category("Decorators")]
	[Description("Inverts Success to Failure and Failure to Success.")]
	[Icon("Remap", false, "")]
	[Name("Invert", 0)]
	public class Inverter : BTDecorator // TypeDefIndex: 48143
	{
		// Constructors
		public Inverter() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189384B04-0x0000000189384B8C
	}

	[Category("Decorators")]
	[Description("Iterates a list and executes its child once for each element in that list. Keeps iterating until the Termination Policy is met or until the whole list is iterated, in which case the last iteration child status is returned.")]
	[Icon("List", false, "")]
	[Name("Iterate", 0)]
	public class Iterator : BTDecorator // TypeDefIndex: 48145
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		[Tooltip("The list to iterate.")]
		public BBParameter<IList> targetList; // 0x98
		[BlackboardOnly]
		[Name("Current Element", 0)]
		[Tooltip("Store the currently iterated list element in a variable.")]
		public BBObjectParameter current; // 0xA0
		[BlackboardOnly]
		[Name("Current Index", 0)]
		[Tooltip("Store the currently iterated list index in a variable.")]
		public BBParameter<int> storeIndex; // 0xA8
		[Name("Termination Policy", 0)]
		[Tooltip("The condition for when to terminate the iteration and return status.")]
		public TerminationConditions terminationCondition; // 0xB0
		[Tooltip("The maximum allowed iterations. Leave at -1 to iterate the whole list.")]
		public BBParameter<int> maxIteration; // 0xB8
		[Tooltip("Should the iteration start from the begining after the Iterator node resets?")]
		public bool resetIndex; // 0xC0
		private int currentIndex; // 0xC4
	
		// Properties
		private IList list { get => default; } // 0x000000018938501C-0x000000018938506C 
	
		// Nested types
		public enum TerminationConditions // TypeDefIndex: 48144
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}
	
		// Constructors
		public Iterator() {} // 0x0000000189384FBC-0x000000018938501C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189384D50-0x0000000189384FA8
		protected override void OnReset() {} // 0x0000000189384FA8-0x0000000189384FBC
	}

	[Category("Decorators")]
	[Description("Merge can accept multiple input connections and thus possible to re-use leaf nodes from multiple parents. Please note that this is experimental and can result in unexpected behaviour.")]
	[Name("Merge", -1)]
	public class Merge : BTDecorator // TypeDefIndex: 48146
	{
		// Properties
		public override int maxInConnections { get => default; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
	
		// Constructors
		public Merge() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189385148-0x00000001893851B4
	}

	[Category("Decorators")]
	[Description("Monitors the decorated child for a returned Status and executes an Action when that is the case.\nThe final Status returned to the parent can either be the original decorated child Status, or the new decorator Action Status.")]
	[Icon("Eye", false, "")]
	public class Monitor : BTDecorator, ITaskAssignable<ActionTask> // TypeDefIndex: 48149
	{
		// Fields
		[Name("Monitor", 0)]
		[Tooltip("The Status to monitor for.")]
		public MonitorMode monitorMode; // 0x98
		[Name("Return", 0)]
		[Tooltip("The Status to return after (and if) the Action is executed.")]
		public ReturnStatusMode returnMode; // 0x9C
		private NodeCanvas.Framework.Status decoratorActionStatus; // 0xA0
		[SerializeField]
		private ActionTask _action; // 0xA8
	
		// Properties
		public ActionTask action { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x00000001893852E8-0x0000000189385340
	
		// Nested types
		public enum MonitorMode // TypeDefIndex: 48147
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}
	
		public enum ReturnStatusMode // TypeDefIndex: 48148
		{
			OriginalDecoratedChildStatus = 0,
			NewDecoratorActionStatus = 1
		}
	
		// Constructors
		public Monitor() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x00000001893851B4-0x00000001893852B4
		protected override void OnReset() {} // 0x00000001893852B4-0x00000001893852E8
	}

	[Category("Decorators")]
	[Description("Executes the decorated child as normal and returns an Optional status, thus making it optional to the parent node in regards to what status is returned.\nThis has the same effect as disabling the node, but instead it executes normaly.")]
	[Icon("UpwardsArrow", false, "")]
	[Name("Optional", 0)]
	public class Optional : BTDecorator // TypeDefIndex: 48150
	{
		// Constructors
		public Optional() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x00000001893878D4-0x000000018938796C
	}

	[Category("Decorators")]
	[Description("Remaps the child status to another status. Used to either invert the child\'s return status or to always return a specific status.")]
	[Icon("Remap", false, "")]
	[Name("Remap", 0)]
	public class Remapper : BTDecorator // TypeDefIndex: 48152
	{
		// Fields
		public RemapStatus successRemap; // 0x98
		public RemapStatus failureRemap; // 0x9C
	
		// Nested types
		public enum RemapStatus // TypeDefIndex: 48151
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Remapper() {} // 0x0000000189388D1C-0x0000000189388D30
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189388C8C-0x0000000189388D1C
	}

	[Category("Decorators")]
	[Description("Repeats the child either x times or until it returns the specified status, or forever.")]
	[Icon("Repeat", false, "")]
	[Name("Repeat", 0)]
	public class Repeater : BTDecorator // TypeDefIndex: 48155
	{
		// Fields
		public RepeaterMode repeaterMode; // 0x98
		[ShowIf("repeaterMode", 0)]
		public BBParameter<int> repeatTimes; // 0xA0
		[ShowIf("repeaterMode", 1)]
		public RepeatUntilStatus repeatUntilStatus; // 0xA8
		private int currentIteration; // 0xAC
	
		// Nested types
		public enum RepeaterMode // TypeDefIndex: 48153
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}
	
		public enum RepeatUntilStatus // TypeDefIndex: 48154
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Repeater() {} // 0x0000000189388E54-0x0000000189388EC0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189388D30-0x0000000189388E54
		protected override void OnReset() {} // 0x0000000183D71EE0-0x0000000183D71EF0
	}

	[Category("Decorators")]
	[Description("Set another Agent for the rest of the Tree dynamicaly from this point and on. All nodes under this will be executed with the new agent. You can also use this decorator to revert back to the original graph agent.")]
	[Icon("Agent", false, "")]
	[Name("Override Agent", 0)]
	public class Setter : BTDecorator // TypeDefIndex: 48156
	{
		// Fields
		[Tooltip("If enabled, will revert back to the original graph agent.")]
		public bool revertToOriginal; // 0x98
		[ShowIf("revertToOriginal", 0)]
		[Tooltip("The new agent to use.")]
		public BBParameter<GameObject> newAgent; // 0xA0
	
		// Constructors
		public Setter() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189389350-0x000000018938940C
	}

	[Category("Decorators")]
	[Description("Interupts decorated child node and returns Failure if the child node is still Running after the timeout period.")]
	[Icon("Timeout", false, "")]
	public class Timeout : BTDecorator // TypeDefIndex: 48157
	{
		// Fields
		[Tooltip("The timeout period in seconds.")]
		public BBParameter<float> timeout; // 0x98
	
		// Constructors
		public Timeout() {} // 0x000000018938AE64-0x000000018938AEC0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018938AD74-0x000000018938AE64
	}

	[Category("Decorators")]
	[Description("Returns Running until the assigned condition becomes true, after which the decorated child is executed.")]
	[Icon("Halt", false, "")]
	public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 48158
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
		private bool accessed; // 0xA0
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x000000018938C15C-0x000000018938C764
		private ConditionTask condition { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
	
		// Constructors
		public WaitUntil() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018938C028-0x000000018938C124
		protected override void OnReset() {} // 0x000000018938C124-0x000000018938C15C
	}

	[Description("Executes an action and returns Success or Failure when the action is finished.\nReturns Running until the action is finished.")]
	[Icon("Action", false, "")]
	[Name("Action", 0)]
	public class ActionNode : BTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 48159
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x0000000189376908-0x0000000189376960
		public ActionTask action { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
	
		// Constructors
		public ActionNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189376740-0x0000000189376770
		protected override void OnReset() {} // 0x0000000189376854-0x0000000189376870
		public override void OnGraphPaused() {} // 0x000000018937681C-0x0000000189376838
	}

	[Description("Checks a condition and returns Success or Failure.")]
	[Icon("Condition", false, "")]
	[Name("Condition", 0)]
	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 48160
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x0000000189378844-0x000000018937889C
		public ConditionTask condition { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
	
		// Constructors
		public ConditionNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189378698-0x000000018937871C
		protected override void OnReset() {} // 0x0000000189378828-0x0000000189378844
	}

	[Description("Executes a sub Dialogue Tree. Returns Running while the sub Dialogue Tree is active. You can Finish the Dialogue Tree with the \'Finish\' node and return Success or Failure.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue", 0)]
	public class NestedDT : BTNodeNested<DialogueTree> // TypeDefIndex: 48161
	{
		// Fields
		[ExposeField]
		[Name("Sub Tree", 0)]
		[SerializeField]
		private BBParameter<DialogueTree> _nestedDialogueTree; // 0xB0
	
		// Properties
		public override DialogueTree subGraph { get => default; set {} } // 0x000000018938650C-0x0000000189386554 0x0000000189386554-0x00000001893865AC
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public NestedDT() {} // 0x00000001893864D8-0x000000018938650C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189386310-0x0000000189386458
		private void OnDLGFinished(bool success) {} // 0x000000018937724C-0x0000000189377260
		protected override void OnReset() {} // 0x0000000189386458-0x00000001893864D8
	}

	[Description("Executes a sub FSM. Returns Running while the sub FSM is active. If a Success or Failure State is selected, then it will return Success or Failure as soon as the Nested FSM enters that state at which point the sub FSM will also be stoped. If the sub FSM ends otherwise, this node will return Success.")]
	[DropReferenceType(typeof(FSM))]
	[Icon("FSM", false, "")]
	[Name("Sub FSM", 0)]
	public class NestedFSM : BTNodeNested<FSM> // TypeDefIndex: 48162
	{
		// Fields
		[ExposeField]
		[Name("Sub FSM", 0)]
		[SerializeField]
		private BBParameter<FSM> _nestedFSM; // 0xB0
		[HideInInspector]
		public string successState; // 0xB8
		[HideInInspector]
		public string failureState; // 0xC0
	
		// Properties
		public override FSM subGraph { get => default; set {} } // 0x0000000189386AF4-0x0000000189386B3C 0x0000000189386B3C-0x0000000189386B94
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public NestedFSM() {} // 0x0000000189386AC0-0x0000000189386AF4
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189386864-0x0000000189386A40
		private void OnFSMFinish(bool success) {} // 0x000000018937724C-0x0000000189377260
		protected override void OnReset() {} // 0x0000000189386A40-0x0000000189386AC0
	}

	[Description("Executes a sub Behaviour Tree. The status of the root node in the SubTree will be returned.")]
	[DropReferenceType(typeof(BehaviourTree))]
	[Icon("BT", false, "")]
	[Name("Sub Tree", 0)]
	public class SubTree : BTNodeNested<BehaviourTree> // TypeDefIndex: 48163
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override BehaviourTree subGraph { get => default; set {} } // 0x000000018938A498-0x000000018938A4E0 0x000000018938A4E0-0x000000018938A538
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public SubTree() {} // 0x000000018938A464-0x000000018938A498
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018938A2E8-0x000000018938A3E4
		protected override void OnReset() {} // 0x000000018938A3E4-0x000000018938A464
	}

	[Category("Mutators (beta)")]
	[Description("Enable, Disable or Toggle one or more nodes with provided tag. In practise their incomming connections are disabled\nBeta Feature!")]
	[Name("Node Toggler", 0)]
	[Obsolete]
	public class NodeToggler : BTNode // TypeDefIndex: 48165
	{
		// Fields
		public ToggleMode toggleMode; // 0x98
		public string targetNodeTag; // 0xA0
		private List<NodeCanvas.Framework.Node> targetNodes; // 0xA8
	
		// Nested types
		public enum ToggleMode // TypeDefIndex: 48164
		{
			Enable = 0,
			Disable = 1,
			Toggle = 2
		}
	
		// Constructors
		public NodeToggler() {} // 0x0000000189387034-0x0000000189387048
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189386FB8-0x0000000189387034
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189386B94-0x0000000189386FB8
	}

	[Category("Mutators (beta)")]
	[Description("Switch the root node of the behaviour tree to a new one defined by tag\nBeta Feature!")]
	[Name("Root Switcher", 0)]
	[Obsolete]
	public class RootSwitcher : BTNode // TypeDefIndex: 48166
	{
		// Fields
		public string targetNodeTag; // 0x98
		private NodeCanvas.Framework.Node targetNode; // 0xA0
	
		// Constructors
		public RootSwitcher() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189388F2C-0x0000000189388F8C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000189388EC0-0x0000000189388F2C
	}

	[Description("Executes a nested FlowScript. Returns Running while the FlowScript is active. You can Finish the FlowScript with the \'Finish\' node and return Success or Failure")]
	[DropReferenceType(typeof(FlowScript))]
	[Icon("FS", false, "")]
	[Name("Sub FlowScript", 0)]
	public class BTNestedFlowScript : BTNodeNested<FlowScript> // TypeDefIndex: 48167
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xB0
	
		// Properties
		public override FlowScript subGraph { get => default; set {} } // 0x0000000189377314-0x000000018937735C 0x000000018937735C-0x00000001893773B4
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public BTNestedFlowScript() {} // 0x00000001893772E0-0x0000000189377314
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x000000018937712C-0x000000018937724C
		private void OnFlowScriptFinished(bool success) {} // 0x000000018937724C-0x0000000189377260
		protected override void OnReset() {} // 0x0000000189377260-0x00000001893772E0
	}
}

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu("NodeCanvas/Dialogue Actor")]
	public class DialogueActor : MonoBehaviour, IDialogueActor // TypeDefIndex: 48067
	{
		// Fields
		[SerializeField]
		protected string _name; // 0x18
		[SerializeField]
		protected Texture2D _portrait; // 0x20
		[SerializeField]
		protected UnityEngine.Color _dialogueColor; // 0x28
		[SerializeField]
		protected Vector3 _dialogueOffset; // 0x38
		private Sprite _portraitSprite; // 0x48
	
		// Properties
		public new string name { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public Texture2D portrait { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Sprite portraitSprite { get => default; } // 0x0000000189379DBC-0x0000000189379EDC 
		public UnityEngine.Color dialogueColor { get => default; } // 0x0000000183D59E20-0x0000000183D59E30 
		public Vector3 dialoguePosition { get => default; } // 0x0000000189379D54-0x0000000189379DBC 
		Transform IDialogueActor.transform { get => default; } // 0x0000000184273A88-0x0000000184273A90 
	
		// Constructors
		public DialogueActor() {} // 0x000000018931B60C-0x000000018931B634
	}

	public class SubtitlesRequestInfo // TypeDefIndex: 48068
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public IStatement statement; // 0x18
		public Action Continue; // 0x20
	
		// Constructors
		public SubtitlesRequestInfo() {} // Dummy constructor
		public SubtitlesRequestInfo(IDialogueActor actor, IStatement statement, Action callback) {} // 0x000000018285BDC0-0x000000018285BE00
	}

	public class MultipleChoiceRequestInfo // TypeDefIndex: 48069
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public Dictionary<IStatement, int> options; // 0x18
		public float availableTime; // 0x20
		public bool showLastStatement; // 0x24
		public Action<int> SelectOption; // 0x28
	
		// Constructors
		public MultipleChoiceRequestInfo() {} // Dummy constructor
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback) {} // 0x00000001893858C8-0x0000000189385910
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, Action<int> callback) {} // 0x0000000189385888-0x00000001893858C8
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Dialogue Tree Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class DialogueTree : NodeCanvas.Framework.Graph // TypeDefIndex: 48078
	{
		// Fields
		public const string INSTIGATOR_NAME = "SELF"; // Metadata: 0x01FBB6ED
		[SerializeField]
		public List<ActorParameter> actorParameters; // 0xA0
	
		// Properties
		public static DialogueTree currentDialogue { get; private set; } // 0x000000018937B478-0x000000018937B4B0 0x000000018937B97C-0x000000018937B9D0
		public static DialogueTree previousDialogue { get; private set; } // 0x000000018937B618-0x000000018937B650 0x000000018937B9D0-0x000000018937BA24
		public DTNode currentNode { get; private set; } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		public override System.Type baseNodeType { get => default; } // 0x000000018937B428-0x000000018937B478 
		public override bool requiresAgent { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool requiresPrimeNode { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool isTree { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool allowBlackboardOverrides { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public sealed override bool canAcceptVariableDrops { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public List<string> definedActorParameterNames { get => default; } // 0x000000018937B4B0-0x000000018937B618 
	
		// Events
		public static event Action<DialogueTree> OnDialogueStarted;
		public static event Action<DialogueTree> OnDialoguePaused;
		public static event Action<DialogueTree> OnDialogueFinished;
		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest;
		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest;
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 48070
		{
			// Fields
			public List<ActorParameter> actorParameters; // 0x10
	
			// Constructors
			public DerivedSerializationData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class ActorParameter // TypeDefIndex: 48071
		{
			// Fields
			[SerializeField]
			private string _keyName; // 0x10
			[SerializeField]
			private string _id; // 0x18
			[SerializeField]
			private UnityEngine.Object _actorObject; // 0x20
			[NonSerialized]
			private IDialogueActor _actor; // 0x28
	
			// Properties
			public string name { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public string ID { get => default; } // 0x0000000189376BD4-0x0000000189376C30 
			public IDialogueActor actor { get => default; set {} } // 0x0000000189376C30-0x0000000189376CA0 0x0000000189376CA0-0x0000000189376D10
	
			// Constructors
			public ActorParameter() {} // 0x000000018350B670-0x000000018350B680
			public ActorParameter(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
			public ActorParameter(string name, IDialogueActor actor) {} // 0x0000000189376BA8-0x0000000189376BD4
	
			// Methods
			public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
		}
	
		// Constructors
		public DialogueTree() {} // 0x000000018937B05C-0x000000018937B0FC
	
		// Methods
		public override object OnDerivedDataSerialization() => default; // 0x000000018937A920-0x000000018937A97C
		public override void OnDerivedDataDeserialization(object data) {} // 0x000000018937A894-0x000000018937A920
		public ActorParameter GetParameterByID(string id) => default; // 0x000000018937A6EC-0x000000018937A7C0
		public ActorParameter GetParameterByName(string paramName) => default; // 0x000000018937A7C0-0x000000018937A894
		public IDialogueActor GetActorReferenceByID(string id) => default; // 0x000000018937A458-0x000000018937A488
		public IDialogueActor GetActorReferenceByName(string paramName) => default; // 0x000000018937A488-0x000000018937A6EC
		public void SetActorReference(string paramName, IDialogueActor actor) {} // 0x000000018937AD24-0x000000018937AE18
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors) {} // 0x000000018937AE18-0x000000018937B05C
		public void Continue(int index = 0 /* Metadata: 0x01FBB6EC */) {} // 0x000000018937A2D0-0x000000018937A3C4
		public void EnterNode(DTNode node) {} // 0x000000018937A3C4-0x000000018937A458
		public static void RequestSubtitles(SubtitlesRequestInfo info) {} // 0x000000018937ACD4-0x000000018937AD24
		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info) {} // 0x000000018937AC84-0x000000018937ACD4
		protected override void OnGraphStarted() {} // 0x000000018937A9CC-0x000000018937AABC
		protected override void OnGraphUpdate() {} // 0x000000018937AC08-0x000000018937AC84
		protected override void OnGraphStoped() {} // 0x000000018937AABC-0x000000018937AB5C
		protected override void OnGraphPaused() {} // 0x000000018937A97C-0x000000018937A9CC
		protected override void OnGraphUnpaused() {} // 0x000000018937AB5C-0x000000018937AC08
	}

	[AddComponentMenu("NodeCanvas/Dialogue Tree Controller")]
	public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor // TypeDefIndex: 48079
	{
		// Properties
		string IDialogueActor.name { get => default; } // 0x0000000184276114-0x000000018427611C 
		Texture2D IDialogueActor.portrait { get => default; } // 0x0000000181002730-0x0000000181002740 
		Sprite IDialogueActor.portraitSprite { get => default; } // 0x0000000181002730-0x0000000181002740 
		UnityEngine.Color IDialogueActor.dialogueColor { get => default; } // 0x0000000185F47B78-0x0000000185F47B98 
		Vector3 IDialogueActor.dialoguePosition { get => default; } // 0x0000000184274B08-0x0000000184274B20 
		Transform IDialogueActor.transform { get => default; } // 0x0000000184273A88-0x0000000184273A90 
	
		// Constructors
		public DialogueTreeController() {} // 0x000000018937A29C-0x000000018937A2D0
	
		// Methods
		public void StartDialogue() {} // 0x000000018937A108-0x000000018937A118
		public void StartDialogue(Action<bool> callback) {} // 0x000000018937A250-0x000000018937A260
		public void StartDialogue(IDialogueActor instigator) {} // 0x000000018937A260-0x000000018937A26C
		public void StartDialogue(DialogueTree newTree, IDialogueActor instigator, Action<bool> callback) {} // 0x000000018937A118-0x000000018937A160
		public void StartDialogue(IDialogueActor instigator, Action<bool> callback) {} // 0x000000018937A160-0x000000018937A250
		public void PauseDialogue() {} // 0x0000000189379F84-0x0000000189379FB0
		public void StopDialogue() {} // 0x000000018937A26C-0x000000018937A29C
		public void SetActorReference(string paramName, IDialogueActor actor) {} // 0x0000000189379FB0-0x000000018937A064
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors) {} // 0x000000018937A064-0x000000018937A108
		public IDialogueActor GetActorReferenceByName(string paramName) => default; // 0x0000000189379EDC-0x0000000189379F84
	}

	public class DTConnection : Connection // TypeDefIndex: 48080
	{
		// Constructors
		public DTConnection() {} // 0x0000000183D5CDB0-0x0000000183D5CDC0
	}

	public abstract class DTNode : NodeCanvas.Framework.Node // TypeDefIndex: 48081
	{
		// Fields
		[SerializeField]
		private string _actorName; // 0x98
		[SerializeField]
		private string _actorParameterID; // 0xA0
	
		// Properties
		public override string name { get; } // 0x0000000189379990-0x0000000189379A68 
		public virtual bool requireActorSelection { get; } // 0x000000018232EB60-0x000000018232EB70 
		public override int maxInConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public override int maxOutConnections { get; } // 0x0000000181168950-0x0000000181168960 
		public sealed override System.Type outConnectionType { get; } // 0x0000000189379A68-0x0000000189379AB8 
		public sealed override bool allowAsPrime { get; } // 0x000000018232EB60-0x000000018232EB70 
		public sealed override bool canSelfConnect { get; } // 0x000000018115F4C0-0x000000018115F530 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000182102C70-0x0000000182102C80 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		protected DialogueTree DLGTree { get; } // 0x00000001893798B0-0x00000001893798EC 
		public string actorName { get; private set; } // 0x00000001893798EC-0x0000000189379934 0x0000000189379AB8-0x0000000189379B58
		public IDialogueActor finalActor { get; } // 0x0000000189379934-0x0000000189379990 
	
		// Constructors
		protected DTNode() {} // 0x0000000189379860-0x00000001893798B0
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class DTNodeNested<T> : DTNode, IGraphAssignable<T> // TypeDefIndex: 48082
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
	
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

	public interface IDialogueActor // TypeDefIndex: 48083
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
	public class ProxyDialogueActor : IDialogueActor // TypeDefIndex: 48084
	{
		// Fields
		private string _name; // 0x10
		private Transform _transform; // 0x18
	
		// Properties
		public string name { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Texture2D portrait { get => default; } // 0x0000000181002730-0x0000000181002740 
		public Sprite portraitSprite { get => default; } // 0x0000000181002730-0x0000000181002740 
		public UnityEngine.Color dialogueColor { get => default; } // 0x0000000185F47B78-0x0000000185F47B98 
		public Vector3 dialoguePosition { get => default; } // 0x0000000184274B08-0x0000000184274B20 
		public Transform transform { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public ProxyDialogueActor() {} // Dummy constructor
		public ProxyDialogueActor(string name, Transform transform) {} // 0x0000000182676770-0x00000001826767A0
	}

	public interface IStatement // TypeDefIndex: 48085
	{
		// Properties
		string text { get; }
		AudioClip audio { get; }
		string meta { get; }
	}

	[Serializable]
	public class Statement : IStatement // TypeDefIndex: 48087
	{
		// Fields
		[SerializeField]
		private string _text; // 0x10
		[SerializeField]
		private AudioClip _audio; // 0x18
		[SerializeField]
		private string _meta; // 0x20
	
		// Properties
		public string text { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public AudioClip audio { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string meta { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public Statement() {} // 0x0000000189389C50-0x0000000189389CB8
		public Statement(string text) {} // 0x0000000189389A80-0x0000000189389B00
		public Statement(string text, AudioClip audio) {} // 0x0000000189389BB4-0x0000000189389C50
		public Statement(string text, AudioClip audio, string meta) {} // 0x0000000189389B00-0x0000000189389BB4
	
		// Methods
		public IStatement BlackboardReplace(IBlackboard bb) => default; // 0x0000000189389948-0x0000000189389A80
		public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
	}

	[Description("Execute an Action Task for the Dialogue Actor selected.")]
	[Name("Task Action", 0)]
	public class ActionNode : DTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 48089
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0xA8
	
		// Properties
		public ActionTask action { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000189376960-0x00000001893769B8
		public override bool requireActorSelection { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public ActionNode() {} // 0x0000000188293154-0x000000018829315C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000189376770-0x0000000189376800
		[IteratorStateMachine(typeof(_UpdateAction_d__10))]
		private IEnumerator UpdateAction(Component actionAgent) => default; // 0x0000000189376870-0x00000001893768E4
		private void OnActionEnd(bool success) {} // 0x00000001893766D4-0x0000000189376740
		protected override void OnReset() {} // 0x0000000189376838-0x0000000189376854
		public override void OnGraphPaused() {} // 0x0000000189376800-0x000000018937681C
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Execute the first child node if a Condition is true, or the second one if that Condition is false. The Actor selected is used for the Condition check")]
	[Icon("Condition", false, "")]
	[Name("Task Condition", 0)]
	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 48090
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0xA8
	
		// Properties
		public ConditionTask condition { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018937889C-0x00000001893788F4
		public override int maxOutConnections { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override bool requireActorSelection { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public ConditionNode() {} // 0x0000000188293154-0x000000018829315C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018937871C-0x0000000189378828
	}

	[Category("Control")]
	[Color("6ebbff")]
	[Description("End the dialogue in Success or Failure.\nNote: A Dialogue will anyway End in Succcess if it has reached a node without child connections. Thus this node is mostly useful if you want to end a Dialogue in Failure.")]
	[Icon("Halt", false, "")]
	[Name("FINISH", 0)]
	public class FinishNode : DTNode // TypeDefIndex: 48091
	{
		// Fields
		public CompactStatus finishState; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool requireActorSelection { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public FinishNode() {} // 0x000000018937D8F0-0x000000018937D904
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018937D8A4-0x000000018937D8F0
	}

	[Category("Control")]
	[Color("6ebbff")]
	[Description("Select a target node to jump to.\nFor your convenience in identifying nodes in the dropdown, please give a Tag name to the nodes you want to use in this way.")]
	[Icon("Set", false, "")]
	[Name("JUMP", 0)]
	public class Jumper : DTNode, IHaveNodeReference // TypeDefIndex: 48092
	{
		// Fields
		[fsSerializeAs("_sourceNodeUID")]
		public NodeReference<DTNode> _targetNode; // 0xA8
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get => default; } // 0x0000000183D4EB10-0x0000000183D4EB20 
		private DTNode target { get => default; } // 0x00000001893850F8-0x0000000189385148 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool requireActorSelection { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public Jumper() {} // 0x0000000188293154-0x000000018829315C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018938506C-0x00000001893850F8
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Prompt a Dialogue Multiple Choice. A choice will be available if the choice condition(s) are true or there is no choice conditions. The Actor selected is used for the condition checks and will also Say the selection if the option is checked.")]
	[Icon("List", false, "")]
	[Name("Multiple Choice", 0)]
	public class MultipleChoiceNode : DTNode // TypeDefIndex: 48095
	{
		// Fields
		[SliderField(0f, 10f)]
		public float availableTime; // 0xA8
		public bool saySelection; // 0xAC
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<Choice> availableChoices; // 0xB0
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000189385848-0x0000000189385888 
		public override bool requireActorSelection { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		[Serializable]
		public class Choice // TypeDefIndex: 48093
		{
			// Fields
			public bool isUnfolded; // 0x10
			public Statement statement; // 0x18
			public ConditionTask condition; // 0x20
	
			// Constructors
			public Choice() {} // 0x0000000181168960-0x0000000181168970
			public Choice(Statement statement) {} // 0x0000000187F80224-0x0000000187F80238
		}
	
		// Constructors
		public MultipleChoiceNode() {} // 0x00000001893857C0-0x0000000189385848
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000189385340-0x0000000189385640
		private void OnOptionSelected(int index) {} // 0x0000000189385640-0x00000001893857C0
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Will continue with the first child node which condition returns true. The Dialogue Actor selected will be used for the checks")]
	[Icon("Selector", false, "")]
	[Name("Multiple Task Condition", 0)]
	public class MultipleConditionNode : DTNode // TypeDefIndex: 48096
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<ConditionTask> conditions; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
	
		// Constructors
		public MultipleConditionNode() {} // 0x0000000189385B70-0x0000000189385BF8
	
		// Methods
		public override void OnChildConnected(int index) {} // 0x0000000189385910-0x000000018938599C
		public override void OnChildDisconnected(int index) {} // 0x000000018938599C-0x00000001893859F4
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x00000001893859F4-0x0000000189385B70
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Select a child to execute based on it\'s chance to be selected. An optional pre-Condition Task can be assigned to filter the child in or out of the selection probability.\nThe actor selected will be used for the condition checks.")]
	[Icon("ProbabilitySelector", false, "")]
	public class ProbabilitySelector : DTNode // TypeDefIndex: 48098
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<Option> childOptions; // 0xA8
		private List<int> successIndeces; // 0xB0
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
	
		// Nested types
		public class Option // TypeDefIndex: 48097
		{
			// Fields
			public BBParameter<float> weight; // 0x10
			public ConditionTask condition; // 0x18
	
			// Constructors
			public Option() {} // Dummy constructor
			public Option(float weightValue, IBlackboard bbValue) {} // 0x0000000189387818-0x00000001893878D4
		}
	
		// Constructors
		public ProbabilitySelector() {} // 0x0000000189388C04-0x0000000189388C8C
	
		// Methods
		public override void OnChildConnected(int index) {} // 0x0000000189388358-0x000000018938843C
		public override void OnChildDisconnected(int index) {} // 0x00000001893885A4-0x00000001893885FC
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x00000001893888DC-0x0000000189388B54
		private float GetTotal() => default; // 0x0000000189388274-0x0000000189388358
		protected override void OnReset() {} // 0x0000000189349A20-0x0000000189349A38
	}

	[Description("Make the selected Dialogue Actor talk. You can make the text more dynamic by using variable names in square brackets\ne.g. [myVarName] or [Global/myVarName]")]
	[Name("Say", 0)]
	public class StatementNode : DTNode // TypeDefIndex: 48099
	{
		// Fields
		[SerializeField]
		public Statement statement; // 0xA8
	
		// Properties
		public override bool requireActorSelection { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public StatementNode() {} // 0x00000001893898C0-0x0000000189389948
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000189389788-0x0000000189389880
		private void OnStatementFinish() {} // 0x0000000189389880-0x00000001893898C0
	}

	[Description("Execute a Sub Dialogue Tree. When that Dialogue Tree is finished, this node will continue either in Success or Failure if it has any connections. Useful for making reusable and self-contained Dialogue Trees.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue Tree", 0)]
	public class SubDialogueTree : DTNodeNested<DialogueTree>, IUpdatable // TypeDefIndex: 48100
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<DialogueTree> _subTree; // 0xC0
		[fsSerializeAs("actorParametersMap")]
		private Dictionary<string, string> _actorParametersMap; // 0xC8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override DialogueTree subGraph { get => default; set {} } // 0x000000018938A248-0x000000018938A290 0x000000018938A290-0x000000018938A2E8
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D50E60-0x0000000183D50E70 
	
		// Constructors
		public SubDialogueTree() {} // 0x000000018938A214-0x000000018938A248
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000189389DE4-0x0000000189389FD0
		private void OnSubDialogueFinish(bool success) {} // 0x0000000189389FD0-0x000000018938A028
		void IUpdatable.Update() {} // 0x0000000189389D50-0x0000000189389DE4
		private void TryWriteMappedActorParameters() {} // 0x000000018938A028-0x000000018938A214
	}

	[Obsolete("Use Jumpers instead")]
	public class GoToNode : DTNode // TypeDefIndex: 48101
	{
		// Fields
		[SerializeField]
		private DTNode _targetNode; // 0xA8
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool requireActorSelection { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public GoToNode() {} // 0x0000000188293154-0x000000018829315C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x000000018937DD98-0x000000018937DE10
	}

	[Description("Executes a FlowScript. Use the Finish flowscript node to continue the dialogue either in Success or Failure.\nThe actor selected here will also be used in the flowcript for \'Self\'.")]
	[DropReferenceType(typeof(FlowScript))]
	[Name("Sub FlowScript", 0)]
	public class DTNestedFlowScript : DTNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 48102
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xC0
	
		// Properties
		public override int maxOutConnections { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override FlowScript subGraph { get => default; set {} } // 0x00000001893797C0-0x0000000189379808 0x0000000189379808-0x0000000189379860
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D50E60-0x0000000183D50E70 
	
		// Constructors
		public DTNestedFlowScript() {} // 0x000000018937978C-0x00000001893797C0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000189379630-0x000000018937973C
		void IUpdatable.Update() {} // 0x000000018937959C-0x0000000189379630
		private void OnFlowScriptFinish(bool success) {} // 0x000000018937973C-0x000000018937978C
	}
}

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : MonoBehaviour // TypeDefIndex: 48111
	{
		// Fields
		[UnityEngine.Header("Input Options")]
		public bool skipOnInput; // 0x18
		public bool waitForInput; // 0x19
		[UnityEngine.Header("Subtitles")]
		public RectTransform subtitlesGroup; // 0x20
		public UnityEngine.UI.Text actorSpeech; // 0x28
		public UnityEngine.UI.Text actorName; // 0x30
		public Image actorPortrait; // 0x38
		public RectTransform waitInputIndicator; // 0x40
		public SubtitleDelays subtitleDelays; // 0x48
		public List<AudioClip> typingSounds; // 0x50
		private AudioSource playSource; // 0x58
		[UnityEngine.Header("Multiple Choice")]
		public RectTransform optionsGroup; // 0x60
		public UnityEngine.UI.Button optionButton; // 0x68
		private Dictionary<UnityEngine.UI.Button, int> cachedButtons; // 0x70
		private Vector2 originalSubsPosition; // 0x78
		private bool isWaitingChoice; // 0x80
		private AudioSource _localSource; // 0x88
	
		// Properties
		private AudioSource localSource { get => default; } // 0x000000018937D118-0x000000018937D1C4 
		private bool anyKeyDown { get => default; } // 0x000000018937D110-0x000000018937D118 
	
		// Nested types
		[Serializable]
		public class SubtitleDelays // TypeDefIndex: 48103
		{
			// Fields
			public float characterDelay; // 0x10
			public float sentenceDelay; // 0x14
			public float commaDelay; // 0x18
			public float finalDelay; // 0x1C
	
			// Constructors
			public SubtitleDelays() {} // 0x0000000183D71F00-0x0000000183D71F20
		}
	
		// Constructors
		public DialogueUGUI() {} // 0x000000018937D09C-0x000000018937D110
	
		// Methods
		private void Awake() {} // 0x000000018937BA24-0x000000018937BA44
		private void OnEnable() {} // 0x000000018937C358-0x000000018937C378
		private void OnDisable() {} // 0x000000018937C350-0x000000018937C358
		private void Subscribe() {} // 0x000000018937CD6C-0x000000018937CF04
		private void UnSubscribe() {} // 0x000000018937CF04-0x000000018937D09C
		private void Hide() {} // 0x000000018937BE6C-0x000000018937BF7C
		private void OnDialogueStarted(DialogueTree dlg) {} // 0x000000018350B670-0x000000018350B680
		private void OnDialoguePaused(DialogueTree dlg) {} // 0x000000018937C290-0x000000018937C350
		private void OnDialogueFinished(DialogueTree dlg) {} // 0x000000018937BFF0-0x000000018937C290
		private void OnSubtitlesRequest(SubtitlesRequestInfo info) {} // 0x000000018937CBCC-0x000000018937CBF0
		[IteratorStateMachine(typeof(_Internal_OnSubtitlesRequestInfo_d__31))]
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info) => default; // 0x000000018937BF7C-0x000000018937BFF0
		private void PlayTypeSound() {} // 0x000000018937CBF0-0x000000018937CCDC
		[IteratorStateMachine(typeof(_CheckInput_d__33))]
		private IEnumerator CheckInput(Action Do) => default; // 0x000000018937BA44-0x000000018937BAB8
		[IteratorStateMachine(typeof(_DelayPrint_d__34))]
		private IEnumerator DelayPrint(float time) => default; // 0x000000018937BB2C-0x000000018937BB80
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info) {} // 0x000000018937C378-0x000000018937CBCC
		[IteratorStateMachine(typeof(_CountDown_d__36))]
		private IEnumerator CountDown(MultipleChoiceRequestInfo info) => default; // 0x000000018937BAB8-0x000000018937BB2C
		private void Finalize(MultipleChoiceRequestInfo info, int index) {} // 0x000000018937BB80-0x000000018937BE6C
		private void SetMassAlpha(RectTransform root, float alpha) {} // 0x000000018937CCDC-0x000000018937CD6C
	}
}

namespace NodeCanvas.Framework
{
	[AttributeUsage(AttributeTargets.Class)]
	public class GraphInfoAttribute : Attribute // TypeDefIndex: 48168
	{
		// Fields
		public string packageName; // 0x10
		public string docsURL; // 0x18
		public string resourcesURL; // 0x20
		public string forumsURL; // 0x28
	
		// Constructors
		public GraphInfoAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DropReferenceType : Attribute // TypeDefIndex: 48169
	{
		// Fields
		public readonly System.Type type; // 0x10
	
		// Constructors
		public DropReferenceType() {} // Dummy constructor
		public DropReferenceType(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class BlackboardOnlyAttribute : Attribute // TypeDefIndex: 48170
	{
		// Constructors
		public BlackboardOnlyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class LogTag // TypeDefIndex: 48171
	{
		// Fields
		public const string EDITOR = "Editor"; // Metadata: 0x01FBB712
		public const string EVENT = "Event"; // Metadata: 0x01FBB719
		public const string EXECUTION = "Execution"; // Metadata: 0x01FBB71F
		public const string VARIABLE = "Variable"; // Metadata: 0x01FBB729
		public const string BLACKBOARD = "Blackboard"; // Metadata: 0x01FBB732
		public const string GRAPH = "Graph"; // Metadata: 0x01FBB73D
		public const string INIT = "Initialization"; // Metadata: 0x01FBB743
		public const string VALIDATION = "Validation"; // Metadata: 0x01FBB752
		public const string SERIALIZATION = "Serialization"; // Metadata: 0x01FBB75D
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/CanvasCore/Signal Definition")]
	public class SignalDefinition : ScriptableObject // TypeDefIndex: 48174
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private List<DynamicParameterDefinition> _parameters; // 0x20
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get => default; private set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Events
		public event InvokeArguments onInvoke;
	
		// Nested types
		public delegate void InvokeArguments(Transform sender, Transform receiver, bool isGlobal, params object[] args); // TypeDefIndex: 48172; 0x0000000182097E50-0x0000000182097E70
	
		// Constructors
		public SignalDefinition() {} // 0x00000001893895E0-0x0000000189389660
	
		// Methods
		public void Invoke(Transform sender, Transform receiver, bool isGlobal, params object[] args) {} // 0x00000001893894A8-0x00000001893894D8
		public void AddParameter(string name, System.Type type) {} // 0x000000018938940C-0x00000001893894A8
		public void RemoveParameter(string name) {} // 0x00000001893894D8-0x00000001893895E0
	}

	[Serializable]
	public class CanvasGroup // TypeDefIndex: 48175
	{
		// Fields
		public string name; // 0x10
		public Rect rect; // 0x18
		public UnityEngine.Color color; // 0x28
		public bool autoGroup; // 0x38
	
		// Constructors
		public CanvasGroup() {} // 0x000000018350B670-0x000000018350B680
		public CanvasGroup(Rect rect, string name) {} // 0x0000000189377E54-0x0000000189377E68
	}

	[Serializable]
	[fsDeserializeOverwrite]
	[SpoofAOT]
	public abstract class Connection : IGraphElement, ISerializationCollectable // TypeDefIndex: 48176
	{
		// Fields
		[fsSerializeAsReference]
		[SerializeField]
		private NodeCanvas.Framework.Node _sourceNode; // 0x10
		[fsSerializeAsReference]
		[SerializeField]
		private NodeCanvas.Framework.Node _targetNode; // 0x18
		[SerializeField]
		private string _UID; // 0x20
		[SerializeField]
		private bool _isDisabled; // 0x28
		[NonSerialized]
		private NodeCanvas.Framework.Status _status; // 0x2C
	
		// Properties
		public string UID { get; } // 0x000000018937934C-0x00000001893793A8 
		public NodeCanvas.Framework.Node sourceNode { get; protected set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public NodeCanvas.Framework.Node targetNode { get; protected set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		string IGraphElement.name { get; } // 0x0000000189378E78-0x0000000189378EA4 
		public bool isActive { get; set; } // 0x00000001893793BC-0x00000001893793C4 0x00000001893793C4-0x00000001893793F8
		public NodeCanvas.Framework.Status status { get; set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public NodeCanvas.Framework.Graph graph { get; } // 0x00000001893793A8-0x00000001893793BC 
		public virtual bool drawInspector { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public Connection() {} // 0x0000000183D5CDB0-0x0000000183D5CDC0
	
		// Methods
		public static Connection Create(NodeCanvas.Framework.Node source, NodeCanvas.Framework.Node target, int sourceIndex = -1 /* Metadata: 0x01FBB76B */, int targetIndex = -1 /* Metadata: 0x01FBB76C */) => default; // 0x0000000189378A8C-0x0000000189378B7C
		public Connection Duplicate(NodeCanvas.Framework.Node newSource, NodeCanvas.Framework.Node newTarget) => default; // 0x0000000189378B7C-0x0000000189378E40
		public int SetSourceNode(NodeCanvas.Framework.Node newSource, int index = -1 /* Metadata: 0x01FBB76D */, bool recodeUndo = true /* Metadata: 0x01FBB76E */) => default; // 0x0000000189378EDC-0x000000018937907C
		public int SetTargetNode(NodeCanvas.Framework.Node newTarget, int index = -1 /* Metadata: 0x01FBB76F */, bool recodeUndo = true /* Metadata: 0x01FBB770 */) => default; // 0x000000018937907C-0x00000001893792FC
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard) => default; // 0x0000000189378E40-0x0000000189378E78
		public void Reset(bool recursively = true /* Metadata: 0x01FBB771 */) {} // 0x0000000189378EA4-0x0000000189378EDC
		public virtual void OnCreate(int sourceIndex, int targetIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnValidate(int sourceIndex, int targetIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnDestroy() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnDestroyAfterConnectionRemoved() {} // 0x000000018350B670-0x000000018350B680
		public override string ToString() => default; // 0x00000001893792FC-0x000000018937934C
	}

	[SpoofAOT]
	public abstract class ExposedParameter // TypeDefIndex: 48177
	{
		// Properties
		public abstract string targetVariableID { get; }
		public abstract System.Type type { get; }
		public abstract object valueBoxed { get; set; }
		public abstract Variable varRefBoxed { get; }
	
		// Constructors
		protected ExposedParameter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void Bind(IBlackboard blackboard);
		public abstract void UnBind();
		public static ExposedParameter CreateInstance(Variable target) => default; // 0x000000018937D48C-0x000000018937D5BC
	}

	public sealed class ExposedParameter<T> : ExposedParameter // TypeDefIndex: 48178
	{
		// Fields
		[SerializeField]
		private string _targetVariableID;
		[SerializeField]
		private T _value;
	
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
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver, IStringCompressProcessor // TypeDefIndex: 48193
	{
		// Fields
		[SerializeField]
		private string _serializedGraph; // 0x18
		[SerializeField]
		protected int _serializedGraphStringIndex; // 0x20
		[SerializeField]
		private bool _enableGraphStringCompress; // 0x24
		[SerializeField]
		private List<UnityEngine.Object> _objectReferences; // 0x28
		[SerializeField]
		private GraphSource _graphSource; // 0x30
		[SerializeField]
		private bool _haltSerialization; // 0x38
		[NonSerialized]
		private bool haltForUndo; // 0x39
		public static Action<Graph> onGraphDeserialized; // 0x08
		private static List<NodeCanvas.Framework.Node> s_nodeBuffer; // 0x10
		private static List<Graph> _runningGraphs; // 0x18
	
		// Properties
		public virtual bool allowRuntimeSerialization { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual bool dontSerializeBinderConnectionGenericType { get; } // 0x000000018115F4C0-0x000000018115F530 
		public bool isDeserialized { get; private set; } // 0x0000000183D4F500-0x0000000183D4F510 0x0000000183D4F530-0x0000000183D4F540
		public abstract bool canDelayDeserializeAndOptimizeClone { get; }
		public bool graphValidateDirty { get; set; } // 0x0000000183D4F510-0x0000000183D4F520 0x0000000183D4F540-0x0000000183D4F550
		private bool hasInitialized { get; set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		private HierarchyTree.Element flatMetaGraph { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		private HierarchyTree.Element fullMetaGraph { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		private HierarchyTree.Element nestedMetaGraph { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public abstract System.Type baseNodeType { get; }
		public abstract bool requiresAgent { get; }
		public abstract bool requiresPrimeNode { get; }
		public abstract bool isTree { get; }
		public abstract bool allowBlackboardOverrides { get; }
		public abstract bool canAcceptVariableDrops { get; }
		private GraphSource graphSource { get; set; } // 0x00000001893802EC-0x0000000189380308 0x0000000184270470-0x0000000184270480
		public string category { get; set; } // 0x0000000189383ACC-0x0000000189383AF8 0x0000000189383F70-0x0000000189383FB0
		public string comments { get; set; } // 0x0000000189383AF8-0x0000000189383B24 0x0000000189383FB0-0x0000000189383FF0
		public Vector2 translation { get; set; } // 0x0000000189383CB4-0x0000000189383CEC 0x0000000189384174-0x00000001893841B4
		public float zoomFactor { get; set; } // 0x0000000189383CEC-0x0000000189383D18 0x00000001893841B4-0x00000001893841EC
		public List<NodeCanvas.Framework.Node> allNodes { get; set; } // 0x0000000189383A20-0x0000000189383A4C 0x0000000189383F00-0x0000000189383F30
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x0000000189383AA0-0x0000000189383ACC 0x0000000189383F30-0x0000000189383F70
		private BlackboardSource localBlackboard { get; set; } // 0x0000000189383B44-0x0000000189383B64 0x0000000189383FF0-0x0000000189384030
		private List<BBParameter> allParameters { get; } // 0x0000000189383A4C-0x0000000189383A78 
		public List<NodeCanvas.Framework.Task> allTasks { get; } // 0x0000000189383A78-0x0000000189383A98 
		public List<Connection> allConnections { get; } // 0x00000001893839F4-0x0000000189383A20 
		public Graph rootGraph { get; } // 0x0000000189383BF8-0x0000000189383C64 
		public bool serializationHalted { get; } // 0x0000000183D4F190-0x0000000183D4F1A0 
		public static IEnumerable<Graph> runningGraphs { get; } // 0x0000000189383C64-0x0000000189383CB4 
		public Graph parentGraph { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public float elapsedTime { get; private set; } // 0x0000000183D56C00-0x0000000183D56C10 0x0000000183D5BD20-0x0000000183D5BD30
		public float deltaTime { get; private set; } // 0x0000000183D56C30-0x0000000183D56C40 0x0000000183D58A80-0x0000000183D58A90
		public int lastUpdateFrame { get; private set; } // 0x0000000183D4EC40-0x0000000183D4EC50 0x0000000183D4ECC0-0x0000000183D4ECD0
		public bool didUpdateLastFrame { get; } // 0x0000000189383B24-0x0000000189383B44 
		public bool isRunning { get; private set; } // 0x0000000183D58A60-0x0000000183D58A70 0x0000000183D58A90-0x0000000183D58AA0
		public bool isPaused { get; private set; } // 0x0000000183D6CFA0-0x0000000183D6CFB0 0x0000000183D6D3E0-0x0000000183D6D3F0
		public UpdateMode updateMode { get; private set; } // 0x0000000183D4EC20-0x0000000183D4EC30 0x0000000183D4ECA0-0x0000000183D4ECB0
		public NodeCanvas.Framework.Node primeNode { get; set; } // 0x0000000189383B64-0x0000000189383BF8 0x0000000189384030-0x0000000189384174
		public Component agent { get; private set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public IBlackboard blackboard { get; } // 0x0000000189383A98-0x0000000189383AA0 
		public IBlackboard parentBlackboard { get; private set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x000000018339AE90-0x000000018339AEA0 
	
		// Events
		public static event Action<Graph> onGraphSerialized;
		public event Action<bool> onFinish;
		private event Action delayedInitCalls;
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 48179
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2,
			Manual = 3
		}
	
		// Constructors
		protected Graph() {} // 0x00000001837AF1E0-0x00000001837AF250
		static Graph() {} // 0x00000001837AF310-0x00000001837AF3B0
	
		// Methods
		public virtual Rect DrawCustomBlackboardPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos) => default; // 0x0000000183D605F0-0x0000000183D60600
		public virtual Rect DrawCustomPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos) => default; // 0x0000000183D605F0-0x0000000183D60600
		public virtual Rect DrawCustomPanel2(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos) => default; // 0x0000000183D605F0-0x0000000183D60600
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189382C88-0x0000000189382C9C
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189382C2C-0x0000000189382C88
		public void TryDeserializeIfNot() {} // 0x0000000189382BEC-0x0000000189382C2C
		protected void OnEnable() {} // 0x0000000183D4D8D0-0x0000000183D4D8F0
		protected void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		protected void OnDestroy() {} // 0x0000000189380FDC-0x000000018938102C
		protected void OnValidate() {} // 0x000000018350B670-0x000000018350B680
		protected void Reset() {} // 0x0000000189381C74-0x0000000189381C84
		public bool SelfSerialize(bool ignoreScene = false /* Metadata: 0x01FBB772 */) => default; // 0x0000000189381F04-0x0000000189382088
		protected virtual void OnAfterGraphSerialized() {} // 0x000000018350B670-0x000000018350B680
		public bool SelfDeserialize() => default; // 0x0000000189381E64-0x0000000189381F04
		public string Serialize(List<UnityEngine.Object> references) => default; // 0x0000000189382440-0x000000018938255C
		public bool Deserialize(string serializedGraph, List<UnityEngine.Object> references, bool validate) => default; // 0x000000018937F33C-0x000000018937F7B8
		public bool DeserializeSelf(List<UnityEngine.Object> references, bool validate) => default; // 0x000000018937F1CC-0x000000018937F33C
		public GraphSource GetGraphSource() => default; // 0x00000001893802EC-0x0000000189380308
		public string GetSerializedJsonData() => default; // 0x0000000189380908-0x0000000189380920
		public int GetSerializedJsonDataStringIndex() => default; // 0x000000018938086C-0x00000001893808BC
		public bool DeserializeFromGraph(Graph other, bool validate = true /* Metadata: 0x01FBB773 */) => default; // 0x000000018937F02C-0x000000018937F134
		public DataCompressManager.StringCompressUnsafeString GetSerializedJsonDataUnsafeString() => default; // 0x00000001893808BC-0x0000000189380908
		public void ClearSerializedJsonData() {} // 0x000000018364B0F0-0x000000018364B110
		public List<UnityEngine.Object> GetSerializedReferencesData() => default; // 0x0000000189380920-0x0000000189380964
		public GraphSource GetGraphSourceMetaDataCopy() => default; // 0x000000018938027C-0x00000001893802EC
		public void SetGraphSourceMetaData(GraphSource source) {} // 0x000000018938255C-0x0000000189382598
		public string SerializeLocalBlackboard(ref List<UnityEngine.Object> references) => default; // 0x0000000189382364-0x0000000189382440
		public bool DeserializeLocalBlackboard(string json, List<UnityEngine.Object> references) => default; // 0x000000018937F134-0x000000018937F1CC
		public static T Clone<T>(T graph, Graph parentGraph)
			where T : Graph => default;
		public void Validate() {} // 0x00000001893833A8-0x000000018938380C
		public void UpdateReferencesFromOwner(GraphOwner owner, bool force = false /* Metadata: 0x01FBB774 */) {} // 0x000000018938318C-0x0000000189383228
		public void UpdateReferences(Component newAgent, IBlackboard newParentBlackboard, bool force = false /* Metadata: 0x01FBB775 */) {} // 0x0000000189383228-0x00000001893833A8
		private void UpdateNodeBBFields() {} // 0x0000000189382D58-0x0000000189382E04
		void ITaskSystem.UpdateTasksOwner() {} // 0x0000000189380F48-0x0000000189380FDC
		public void UpdateNodeIDs(bool alsoReorderList) {} // 0x0000000189382E04-0x000000018938318C
		public virtual void OnGraphStructureChange() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterUpdateNodeIDs() {} // 0x000000018350B670-0x000000018350B680
		private int AssignNodeID(NodeCanvas.Framework.Node node, int lastID, ref NodeCanvas.Framework.Node[] parsed) => default; // 0x000000018937DF80-0x000000018937E098
		protected void ThreadSafeInitCall(Action call) {} // 0x0000000189382B78-0x0000000189382BEC
		public async void LoadOverwriteAsync(GraphLoadData data, Action callback) {} // 0x0000000189380CE8-0x0000000189380DC8
		public void LoadOverwrite(GraphLoadData data) {} // 0x0000000189380DC8-0x0000000189380F48
		public void Initialize(Component newAgent, IBlackboard newParentBlackboard, bool preInitializeSubGraphs) {} // 0x0000000189380C78-0x0000000189380CE8
		private void PreInitializeSubGraphs() {} // 0x00000001893811B0-0x00000001893814C4
		public void StartGraph(Component newAgent, IBlackboard newParentBlackboard, UpdateMode newUpdateMode, Action<bool> callback = null) {} // 0x0000000189382598-0x00000001893828E8
		public void ClearGraphData() {} // 0x000000018937E17C-0x000000018937E478
		public void Stop(bool success = true /* Metadata: 0x01FBB776 */) {} // 0x0000000189382920-0x0000000189382B78
		public void Pause() {} // 0x000000018938102C-0x00000001893811B0
		public void Resume() {} // 0x0000000189381CDC-0x0000000189381E64
		public void Restart() {} // 0x0000000189381C84-0x0000000189381CDC
		public void UpdateGraph() {} // 0x0000000189382C9C-0x0000000189382CC0
		public void UpdateGraph(float deltaTime) {} // 0x0000000189382CC0-0x0000000189382D58
		public virtual object OnDerivedDataSerialization() => default; // 0x0000000181002730-0x0000000181002740
		public virtual void OnDerivedDataDeserialization(object data) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphInitialize() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphStarted() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphStoped() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphPaused() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphUnpaused() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphObjectEnable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphObjectDisable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphObjectDestroy() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnGraphValidate() {} // 0x000000018350B670-0x000000018350B680
		public void SendEvent(string name, object value, object sender) {} // 0x0000000189382088-0x0000000189382174
		public void SendEvent<T>(string name, T value, object sender) {}
		public static void SendGlobalEvent(string name, object value, object sender) {} // 0x0000000189382174-0x0000000189382364
		public static void SendGlobalEvent<T>(string name, T value, object sender) {}
		public IEnumerable<BBParameter> GetAllParameters() => default; // 0x000000018937FCA0-0x000000018937FCA8
		public IEnumerable<Connection> GetAllConnections() => default; // 0x000000018937F940-0x000000018937F948
		public IEnumerable<T> GetAllTasksOfType<T>()
			where T : NodeCanvas.Framework.Task => default;
		public NodeCanvas.Framework.Node GetNodeWithID(int searchID) => default; // 0x00000001893804BC-0x00000001893805B4
		public IEnumerable<T> GetAllNodesOfType<T>()
			where T : NodeCanvas.Framework.Node => default;
		public T GetNodeWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node => default;
		public IEnumerable<T> GetNodesWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node => default;
		public IEnumerable<T> GetAllTagedNodes<T>()
			where T : NodeCanvas.Framework.Node => default;
		public IEnumerable<NodeCanvas.Framework.Node> GetRootNodes() => default; // 0x0000000189380758-0x000000018938086C
		public IEnumerable<NodeCanvas.Framework.Node> GetLeafNodes() => default; // 0x0000000189380308-0x000000018938041C
		public IEnumerable<T> GetAllNestedGraphs<T>(bool recursive)
			where T : Graph => default;
		public IEnumerable<Graph> GetAllInstancedNestedGraphs() => default; // 0x000000018937F948-0x000000018937FCA0
		public IEnumerable<BBParameter> GetDefinedParameters() => default; // 0x000000018937FCA8-0x000000018937FDBC
		public void PromoteMissingParametersToVariables(IBlackboard bb) {} // 0x0000000189381524-0x0000000189381678
		public static Graph GetElementGraph(object obj) => default; // 0x000000018937FDBC-0x000000018937FFB4
		public HierarchyTree.Element GetFlatMetaGraph() => default; // 0x000000018937FFB4-0x00000001893800DC
		public HierarchyTree.Element GetFullMetaGraph() => default; // 0x00000001893800DC-0x000000018938027C
		public HierarchyTree.Element GetNestedMetaGraph() => default; // 0x000000018938041C-0x00000001893804BC
		private static void DigNestedGraphs(Graph currentGraph, HierarchyTree.Element currentElement) {} // 0x000000018937F7B8-0x000000018937F940
		private static HierarchyTree.Element GetTreeNodeElement(NodeCanvas.Framework.Node node, bool recurse, ref int lastID) => default; // 0x0000000189380B08-0x0000000189380C78
		private static HierarchyTree.Element CollectSubElements(IGraphElement obj) => default; // 0x000000018937EE14-0x000000018937EFB0
		public IGraphElement GetTaskParentElement(NodeCanvas.Framework.Task targetTask) => default; // 0x0000000189380964-0x00000001893809D4
		public IGraphElement GetParameterParentElement(BBParameter targetParameter) => default; // 0x00000001893805B4-0x0000000189380624
		public static IEnumerable<NodeCanvas.Framework.Task> GetTasksInElement(IGraphElement target) => default; // 0x00000001893809D4-0x0000000189380B08
		public static IEnumerable<BBParameter> GetParametersInElement(IGraphElement target) => default; // 0x0000000189380624-0x0000000189380758
		public T AddNode<T>()
			where T : NodeCanvas.Framework.Node => default;
		public T AddNode<T>(Vector2 pos)
			where T : NodeCanvas.Framework.Node => default;
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType) => default; // 0x000000018937DF08-0x000000018937DF80
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType, Vector2 pos) => default; // 0x000000018937DE10-0x000000018937DF08
		public void RemoveNode(NodeCanvas.Framework.Node node, bool recordUndo = true /* Metadata: 0x01FBB777 */, bool force = false /* Metadata: 0x01FBB778 */) {} // 0x0000000189381830-0x0000000189381C74
		public Connection ConnectNodes(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, int sourceIndex = -1 /* Metadata: 0x01FBB779 */, int targetIndex = -1 /* Metadata: 0x01FBB77A */) => default; // 0x000000018937EFB0-0x000000018937F02C
		public void RemoveConnection(Connection connection, bool recordUndo = true /* Metadata: 0x01FBB77B */, bool invokeGraphChanged = true /* Metadata: 0x01FBB77C */) {} // 0x0000000189381678-0x0000000189381830
		public static List<NodeCanvas.Framework.Node> CloneNodes(List<NodeCanvas.Framework.Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default) => default; // 0x000000018937E520-0x000000018937EE14
		public void ClearGraph() {} // 0x000000018937E478-0x000000018937E520
		[Obsolete("Use \'Graph.StartGraph\' with the \'Graph.UpdateMode\' parameter.")]
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null) {} // 0x00000001893828E8-0x0000000189382920
		public void ProcessStringCompress(StringCompressVisitor visitor) {} // 0x00000001893814C4-0x0000000189381524
		public bool CheckStringCompress() => default; // 0x000000018937E098-0x000000018937E17C
	}

	public abstract class GraphOwner : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 48205
	{
		// Fields
		protected bool isLazyLoadTriggered; // 0x18
		private bool m_deserializeFinish; // 0x19
		[SerializeField]
		private SerializationPair[] _serializedExposedParameters; // 0x20
		public static Action<GraphOwner> onOwnerBehaviourStateChange; // 0x00
		[FormerlySerializedAs("boundGraphSerialization")]
		[SerializeField]
		private string _boundGraphSerialization; // 0x38
		[FormerlySerializedAs("boundGraphObjectReferences")]
		[SerializeField]
		private List<UnityEngine.Object> _boundGraphObjectReferences; // 0x40
		[SerializeField]
		private GraphSource _boundGraphSource; // 0x48
		[FormerlySerializedAs("firstActivation")]
		[SerializeField]
		[Tooltip("When the graph will first activate. Async mode will load the graph on a separate thread (thus no spikes), but the graph will activate a few frames later.")]
		private FirstActivation _firstActivation; // 0x50
		[FormerlySerializedAs("enableAction")]
		[SerializeField]
		[Tooltip("What will happen when the GraphOwner is enabled")]
		private EnableAction _enableAction; // 0x54
		[FormerlySerializedAs("disableAction")]
		[SerializeField]
		[Tooltip("What will happen when the GraphOwner is disabled")]
		private DisableAction _disableAction; // 0x58
		[SerializeField]
		[Tooltip("If enabled, bound graph prefab overrides in instances will not be possible")]
		private bool _lockBoundGraphPrefabOverrides; // 0x5C
		[SerializeField]
		[Tooltip("If enabled, bound graph will not be able to be modified from instance.")]
		private bool _lockBoundGraphFromInstance; // 0x5D
		[SerializeField]
		[Tooltip("If enabled, all subgraphs will be pre-initialized in Awake along with the root graph, but this may have a loading performance cost")]
		private bool _preInitializeSubGraphs; // 0x5E
		[SerializeField]
		[Tooltip("Specify when (if) the behaviour is updated. Changes to this only work when the behaviour starts, or re-starts")]
		private NodeCanvas.Framework.Graph.UpdateMode _updateMode; // 0x60
		protected Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances; // 0x68
	
		// Properties
		public List<ExposedParameter> exposedParameters { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public abstract NodeCanvas.Framework.Graph graph { get; set; }
		public abstract IBlackboard blackboard { get; set; }
		public abstract System.Type graphType { get; }
		public bool initialized { get; private set; } // 0x0000000183D4F260-0x0000000183D4F270 0x0000000183D4F290-0x0000000183D4F2A0
		public bool enableCalled { get; private set; } // 0x0000000183D51CF0-0x0000000183D51D00 0x0000000183D51D00-0x0000000183D51D10
		public bool startCalled { get; private set; } // 0x0000000183D5BFA0-0x0000000183D5BFB0 0x0000000183D5BFD0-0x0000000183D5BFE0
		public GraphSource boundGraphSource { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public string boundGraphSerialization { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public List<UnityEngine.Object> boundGraphObjectReferences { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public bool lockBoundGraphPrefabOverrides { get; set; } // 0x00000001893920F0-0x0000000189392104 0x0000000183D4F620-0x0000000183D4F630
		public bool lockBoundGraphFromInstance { get; set; } // 0x0000000183D71350-0x0000000183D71360 0x0000000183D71390-0x0000000183D713A0
		public bool preInitializeSubGraphs { get; set; } // 0x0000000183D71370-0x0000000183D71380 0x0000000183D713B0-0x0000000183D713C0
		public FirstActivation firstActivation { get; set; } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public EnableAction enableAction { get; set; } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
		public DisableAction disableAction { get; set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public NodeCanvas.Framework.Graph.UpdateMode updateMode { get; set; } // 0x0000000183D4F050-0x0000000183D4F060 0x0000000183D4F5A0-0x0000000183D4F5B0
		public bool graphIsBound { get; } // 0x0000000182E9E300-0x0000000182E9E320 
		public bool isRunning { get; } // 0x0000000182E9D4A0-0x0000000182E9D510 
		public bool isPaused { get; } // 0x0000000189392070-0x00000001893920F0 
		public float elapsedTime { get; } // 0x0000000189391FEC-0x0000000189392070 
		public virtual bool canEditNonPersistantBoundGraph { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Events
		public event Action onMonoBehaviourStart;
	
		// Nested types
		public enum EnableAction // TypeDefIndex: 48194
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}
	
		public enum DisableAction // TypeDefIndex: 48195
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}
	
		public enum FirstActivation // TypeDefIndex: 48196
		{
			OnEnable = 0,
			OnStart = 1,
			Async = 2
		}
	
		public class SubInfo // TypeDefIndex: 48197
		{
			// Fields
			public NodeCanvas.Framework.Graph graph; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public NodeCanvas.Framework.Graph parentGraph; // 0x20
			public string name; // 0x28
			public IGraphAssignable assignable; // 0x30
			public bool isSuc; // 0x38
	
			// Constructors
			public SubInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		protected GraphOwner() {} // 0x00000001837AF250-0x00000001837AF310
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189391D30-0x0000000189391ED4
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189391BDC-0x0000000189391D30
		protected virtual void OnBeforeSerializeDoExtra() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterDeserializeDoExtra() {} // 0x000000018350B670-0x000000018350B680
		protected NodeCanvas.Framework.Graph GetInstance(NodeCanvas.Framework.Graph originalGraph) => default; // 0x0000000182E9E260-0x0000000182E9E300
		public NodeCanvas.Framework.Graph MakeRuntimeGraphInstance() => default; // 0x00000001893913A4-0x00000001893913F0
		public void StartBehaviour() {} // 0x0000000182E9D490-0x0000000182E9D4A0
		public void StartBehaviour(Action<bool> callback) {} // 0x0000000189391A1C-0x0000000189391A2C
		public void StartBehaviour(NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null) {} // 0x0000000182E9D5E0-0x0000000182E9D6A0
		public void PauseBehaviour() {} // 0x0000000189391704-0x00000001893917B8
		public void StartBehaviourAsync(Action callBack) {} // 0x000000018939193C-0x0000000189391A1C
		protected async void GetInstanceAsync(NodeCanvas.Framework.Graph originalGraph, Action<NodeCanvas.Framework.Graph> callBack) {} // 0x00000001893912D8-0x00000001893913A4
		public async void CreateSubInstanceAsync(Action callBack) {} // 0x00000001893911D4-0x0000000189391288
		public void StopBehaviour(bool success = true /* Metadata: 0x01FBB781 */) {} // 0x0000000189391A2C-0x0000000189391AF0
		public void UpdateBehaviour() {} // 0x0000000189391ED4-0x0000000189391F58
		public void RestartBehaviour() {} // 0x00000001893917B8-0x00000001893917E4
		public void SendEvent(string eventName) {} // 0x000000018939189C-0x000000018939193C
		public void SendEvent(string eventName, object value, object sender) {} // 0x00000001893917E4-0x000000018939189C
		public void SendEvent<T>(string eventName, T eventValue, object sender) {}
		public T GetExposedParameterValue<T>(string name) => default;
		public void SetExposedParameterValue<T>(string name, T value) {}
		public ExposedParameter MakeNewExposedParameter<T>(string name) => default;
		protected virtual void Awake() {} // 0x0000000182E9D430-0x0000000182E9D440
		public void Initialize() {} // 0x0000000182E9D510-0x0000000182E9D5E0
		public void BindExposedParameters() {} // 0x00000001893910E4-0x00000001893911D4
		public void UnBindExposedParameters() {} // 0x0000000189391B58-0x0000000189391BDC
		protected virtual void OnEnable() {} // 0x0000000182E9D440-0x0000000182E9D490
		protected virtual void Start() {} // 0x0000000183D42960-0x0000000183D42990
		private void InvokeStartEvent() {} // 0x0000000183D42990-0x0000000183D429B0
		protected virtual void OnDisable() {} // 0x00000001893916D0-0x0000000189391704
		public void DestroyInstance() {} // 0x0000000189391288-0x00000001893912D8
		protected virtual void OnDestroy() {} // 0x00000001893913F0-0x00000001893916D0
	}

	public abstract class GraphOwner<T> : GraphOwner // TypeDefIndex: 48206
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		[Tooltip("The graph to use.")]
		private T _graph;
		[SerializeField]
		[Tooltip("The GameObject Blackboard to use.")]
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

	public static class IGraphAssignableExtensions // TypeDefIndex: 48208
	{
		// Extension methods
		public static NodeCanvas.Framework.Graph CheckInstance(this IGraphAssignable assignable) => default; // 0x0000000189393898-0x0000000189393A70
		public static bool TryStartSubGraph(this IGraphAssignable assignable, Component agent, Action<bool> callback = null) => default; // 0x0000000189393DD0-0x0000000189393F7C
		public static bool TryStopSubGraph(this IGraphAssignable assignable) => default; // 0x0000000189393F7C-0x0000000189394004
		public static bool TryClearSubGraphData(this IGraphAssignable assignable) => default; // 0x0000000189393A70-0x0000000189393AF4
		public static bool TryPauseSubGraph(this IGraphAssignable assignable) => default; // 0x0000000189393AF4-0x0000000189393B78
		public static bool TryResumeSubGraph(this IGraphAssignable assignable) => default; // 0x0000000189393D4C-0x0000000189393DD0
		public static bool TryUpdateSubGraph(this IGraphAssignable assignable) => default; // 0x0000000189394004-0x00000001893940B4
		public static void TryWriteAndBindMappedVariables(this IGraphAssignable assignable) {} // 0x00000001893940B4-0x00000001893942D0
		public static void TryReadAndUnbindMappedVariables(this IGraphAssignable assignable) {} // 0x0000000189393B78-0x0000000189393D4C
		public static void ValidateSubGraphAndParameters(this IGraphAssignable assignable) {} // 0x00000001893942D0-0x00000001893943C8
	}

	public interface IGraphElement // TypeDefIndex: 48209
	{
		// Properties
		string name { get; }
		string UID { get; }
		NodeCanvas.Framework.Graph graph { get; }
		NodeCanvas.Framework.Status status { get; }
	}

	public interface IUpdatable : IGraphElement // TypeDefIndex: 48210
	{
		// Methods
		void Update();
	}

	public interface IInvokable : IGraphElement // TypeDefIndex: 48211
	{
		// Methods
		string GetInvocationID();
		object Invoke(params object[] args);
		void InvokeAsync(Action<object> callback, params object[] args);
	}

	public interface IGraphAssignable : IGraphElement // TypeDefIndex: 48212
	{
		// Properties
		NodeCanvas.Framework.Graph subGraph { get; set; }
		NodeCanvas.Framework.Graph currentInstance { get; set; }
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		BBParameter subGraphParameter { get; }
		List<BBMappingParameter> variablesMap { get; set; }
	}

	public interface IGraphAssignable<T> : IGraphAssignable // TypeDefIndex: 48213
		where T : NodeCanvas.Framework.Graph
	{
		// Properties
		T subGraph { get; set; }
		T currentInstance { get; set; }
	}

	public interface ITaskAssignable : IGraphElement // TypeDefIndex: 48214
	{
		// Properties
		NodeCanvas.Framework.Task task { get; set; }
	}

	public interface ITaskAssignable<T> : ITaskAssignable // TypeDefIndex: 48215
		where T : NodeCanvas.Framework.Task
	{
	}

	public interface IHaveNodeReference : IGraphElement // TypeDefIndex: 48216
	{
		// Properties
		INodeReference targetReference { get; }
	}

	public interface IReflectedWrapper // TypeDefIndex: 48217
	{
		// Methods
		ISerializedReflectedInfo GetSerializedInfo();
	}

	[Obsolete("This is no longer used nor required")]
	public interface ISubTasksContainer // TypeDefIndex: 48218
	{
		// Methods
		NodeCanvas.Framework.Task[] GetSubTasks();
	}

	[Obsolete("This is no longer used nor required")]
	public interface ISubParametersContainer // TypeDefIndex: 48219
	{
		// Methods
		BBParameter[] GetSubParameters();
	}

	[Serializable]
	[fsDeserializeOverwrite]
	[fsSerializeAsReference]
	[SpoofAOT]
	public abstract class Node : IGraphElement, ISerializationCollectable // TypeDefIndex: 48226
	{
		// Fields
		[HideInInspector]
		public float additionalWidth; // 0x10
		[HideInInspector]
		[SerializeField]
		private string _UID; // 0x18
		[HideInInspector]
		[SerializeField]
		private string _name; // 0x20
		[HideInInspector]
		[SerializeField]
		private string _tag; // 0x28
		[fsIgnoreInBuild]
		[HideInInspector]
		[SerializeField]
		private Vector2 _position; // 0x30
		[fsIgnoreInBuild]
		[HideInInspector]
		[SerializeField]
		private string _comment; // 0x38
		[fsIgnoreInBuild]
		[HideInInspector]
		[SerializeField]
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
		[NonSerialized]
		[HideInInspector]
		public float highlightColorFade; // 0x88
	
		// Properties
		protected virtual float? overrideNodeWidth { get; } // 0x0000000181002730-0x0000000181002740 
		public NodeCanvas.Framework.Graph graph { get; internal set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public int ID { get; internal set; } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public string UID { get; } // 0x00000001893959C8-0x0000000189395A00 
		public List<Connection> inConnections { get; protected set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public List<Connection> outConnections { get; protected set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public Vector2 position { get; set; } // 0x0000000183D69670-0x0000000183D69690 0x0000000181003840-0x0000000181003850
		private string customName { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string tag { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string comments { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public string commentForShow { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public string rawComment { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public virtual bool modifyComment { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual string modifiedComment { get; } // 0x0000000189395BB8-0x0000000189395BF0 
		public virtual bool isBreakpoint { get; set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public virtual string name { get; set; } // 0x0000000189395BF0-0x0000000189395CE8 0x0000000184271930-0x0000000184271940
		public virtual string description { get; } // 0x0000000189395A00-0x0000000189395AA8 
		public virtual int priority { get; } // 0x0000000189395D90-0x0000000189395E28 
		public abstract int maxInConnections { get; }
		public abstract int maxOutConnections { get; }
		public abstract System.Type outConnectionType { get; }
		public abstract bool allowAsPrime { get; }
		public abstract bool canSelfConnect { get; }
		public abstract Alignment2x2 commentsAlignment { get; }
		public abstract Alignment2x2 iconAlignment { get; }
		public virtual bool isBeyondGraph { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool drawInspector { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual bool inspectorShowTag { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual bool allowResizeHorizontal { get; } // 0x0000000183D51AD0-0x0000000183D51AE0 
		public bool canResizeHorizontal { get; set; } // 0x0000000183D52010-0x0000000183D52020 0x0000000183D71F50-0x0000000183D71F60
		public bool resizingHorizontal { get; set; } // 0x0000000183D51B10-0x0000000183D51B20 0x0000000183D71F70-0x0000000183D71F80
		public virtual bool allowDragInContentRect { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual string nodeIconKey { get; } // 0x0000000189395D58-0x0000000189395D90 
		public virtual string nodeIconKey2 { get; } // 0x0000000189395CE8-0x0000000189395D20 
		public virtual string nodeIconKey3 { get; } // 0x0000000189395D20-0x0000000189395D58 
		public virtual bool isHighlight { get; set; } // 0x0000000183D71F40-0x0000000183D71F50 0x0000000183D71F60-0x0000000183D71F70
		public virtual bool drawNameTagOrComment { get; } // 0x000000018232EB60-0x000000018232EB70 
		public NodeCanvas.Framework.Status status { get; protected set; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 0x0000000189395E28-0x0000000189395E58
		public Component graphAgent { get; } // 0x0000000189395AD8-0x0000000189395B48 
		public IBlackboard graphBlackboard { get; } // 0x0000000189395B48-0x0000000189395BB8 
		public float elapsedTime { get; } // 0x0000000189395AA8-0x0000000189395AD8 
		private float timeStarted { get; set; } // 0x0000000183D58550-0x0000000183D58560 0x0000000183D71AE0-0x0000000183D71AF0
		private bool isChecked { get; set; } // 0x0000000183D58A70-0x0000000183D58A80 0x0000000183D58AB0-0x0000000183D58AC0
		private bool breakPointReached { get; set; } // 0x0000000183D50B80-0x0000000183D50B90 0x0000000183D50BA0-0x0000000183D50BB0
	
		// Nested types
		[AttributeUsage(AttributeTargets.Field)]
		protected class AutoSortWithChildrenConnections : Attribute // TypeDefIndex: 48220
		{
			// Constructors
			public AutoSortWithChildrenConnections() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public Node() {} // 0x0000000189395904-0x00000001893959C8
	
		// Methods
		protected virtual string AllocateUID() => default; // 0x0000000189394550-0x0000000189394584
		public static Node Create(NodeCanvas.Framework.Graph targetGraph, System.Type nodeType, Vector2 pos) => default; // 0x00000001893946E0-0x000000018939487C
		public Node Duplicate(NodeCanvas.Framework.Graph targetGraph) => default; // 0x000000018939487C-0x0000000189394BC8
		public void Validate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x00000001893957A8-0x00000001893958A8
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard) => default; // 0x0000000189394C7C-0x0000000189394CF4
		public void Reset(bool recursively = true /* Metadata: 0x01FBB78A */) {} // 0x00000001893953CC-0x0000000189395490
		[IteratorStateMachine(typeof(_YieldBreak_d__136))]
		private IEnumerator YieldBreak(Action resume) => default; // 0x00000001893958A8-0x0000000189395904
		public NodeCanvas.Framework.Status Error(object msg) => default; // 0x0000000189394BC8-0x0000000189394C7C
		public NodeCanvas.Framework.Status Fail(string msg) => default; // 0x0000000189394CF4-0x0000000189394D0C
		public void Warn(string msg) {} // 0x000000018350B670-0x000000018350B680
		public void SetStatus(NodeCanvas.Framework.Status status) {} // 0x0000000189365928-0x0000000189365930
		protected void SendEvent(string eventName) {} // 0x0000000189395490-0x00000001893954C0
		protected void SendEvent<T>(string eventName, T value) {}
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null) => default; // 0x0000000189395234-0x0000000189395300
		protected virtual bool CanConnectToTarget(Node targetNode) => default; // 0x000000018232EB60-0x000000018232EB70
		protected virtual bool CanConnectFromSource(Node sourceNode) => default; // 0x000000018232EB60-0x000000018232EB70
		public static bool AreNodesConnected(Node a, Node b) => default; // 0x0000000189394584-0x00000001893946E0
		public Coroutine StartCoroutine(IEnumerator routine) => default; // 0x00000001893954C0-0x0000000189395540
		public void StopCoroutine(Coroutine routine) {} // 0x0000000189395540-0x00000001893955BC
		public void StartParallelTask(Action action) {} // 0x000000018350B670-0x000000018350B680
		public void StopParallelTask(Action action) {} // 0x000000018350B670-0x000000018350B680
		public IEnumerable<Node> GetParentNodes() => default; // 0x0000000189394F70-0x00000001893950B8
		public IEnumerable<Node> GetChildNodes() => default; // 0x0000000189394D0C-0x0000000189394E54
		public bool IsChildOf(Node parentNode) => default; // 0x0000000189395168-0x0000000189395234
		public bool IsParentOf(Node childNode) => default; // 0x0000000189395300-0x00000001893953CC
		internal virtual string GetWarningOrError() => default; // 0x00000001893950B8-0x0000000189395168
		private string GetHardError() => default; // 0x0000000189394E54-0x0000000189394F70
		protected virtual NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard) => default; // 0x0000000183D4EEE0-0x0000000183D4EEF0
		protected virtual void OnReset() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnCreate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnDuplicate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnDestroy() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnParentConnected(int connectionIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnParentDisconnected(int connectionIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnChildConnected(int connectionIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnChildDisconnected(int connectionIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnChildrenConnectionsSorted(int[] oldIndeces) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphStarted() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnPostGraphStarted() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphStoped() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnPostGraphStoped() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphPaused() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphUnpaused() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnClearNodeData() {} // 0x000000018350B670-0x000000018350B680
		public override string ToString() => default; // 0x00000001893955BC-0x00000001893957A8
	}

	public interface INodeReference // TypeDefIndex: 48227
	{
		// Properties
		System.Type type { get; }
	
		// Methods
		NodeCanvas.Framework.Node Get(NodeCanvas.Framework.Graph graph);
		void Set(NodeCanvas.Framework.Node target);
	}

	[Serializable]
	[fsAutoInstance(true)]
	[fsForward("_targetNodeUID")]
	public class NodeReference<T> : INodeReference // TypeDefIndex: 48229
		where T : NodeCanvas.Framework.Node
	{
		// Fields
		[SerializeField]
		private string _targetNodeUID;
		[NonSerialized]
		private WeakReference<T> _targetNodeRef;
	
		// Properties
		System.Type INodeReference.type { get => default; }
	
		// Constructors
		public NodeReference() {}
		public NodeReference(T target) {}
	
		// Methods
		NodeCanvas.Framework.Node INodeReference.Get(NodeCanvas.Framework.Graph graph) => default;
		void INodeReference.Set(NodeCanvas.Framework.Node target) {}
		public T Get(NodeCanvas.Framework.Graph graph) => default;
		public void Set(T target) {}
	}

	public enum Status // TypeDefIndex: 48230
	{
		Failure = 0,
		Success = 1,
		Running = 2,
		Resting = 3,
		Error = 4,
		Optional = 5
	}

	[DoNotList]
	public class ActionList : ActionTask // TypeDefIndex: 48232
	{
		// Fields
		public ActionsExecutionMode executionMode; // 0x68
		public List<ActionTask> actions; // 0x70
		private int currentActionIndex; // 0x78
		private bool[] finishedIndeces; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018938D13C-0x000000018938D314 
	
		// Nested types
		public enum ActionsExecutionMode // TypeDefIndex: 48231
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}
	
		// Constructors
		public ActionList() {} // 0x000000018938D0BC-0x000000018938D13C
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem) => default; // 0x000000018938C94C-0x000000018938CB2C
		protected override string OnInit() => default; // 0x000000018938CCB8-0x000000018938CD24
		protected override void OnExecute() {} // 0x000000018938CC50-0x000000018938CCB8
		protected override void OnUpdate() {} // 0x000000018938CE6C-0x000000018938D0BC
		protected override void OnStop() {} // 0x000000018938CDC0-0x000000018938CE6C
		protected override void OnPause() {} // 0x000000018938CD24-0x000000018938CDC0
		public override void OnDrawGizmosSelected() {} // 0x000000018938CBB0-0x000000018938CC50
		public void AddAction(ActionTask action) {} // 0x000000018938C764-0x000000018938C94C
		internal override string GetWarningOrError() => default; // 0x000000018938CB2C-0x000000018938CBB0
	}

	public abstract class ActionTask<T> : ActionTask // TypeDefIndex: 48233
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ActionTask() {}
	}

	public abstract class ActionTask : NodeCanvas.Framework.Task // TypeDefIndex: 48235
	{
		// Fields
		private NodeCanvas.Framework.Status status; // 0x58
		private float timeStarted; // 0x5C
		private bool latch; // 0x60
	
		// Properties
		public float elapsedTime { get; } // 0x000000018938D5D4-0x000000018938D608 
		public bool isRunning { get; } // 0x000000018938D608-0x000000018938D610 
		public bool isPaused { get; private set; } // 0x0000000183D51F90-0x0000000183D51FA0 0x0000000183D5B410-0x0000000183D5B420
	
		// Constructors
		protected ActionTask() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		public void ExecuteIndependent(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback) {} // 0x000000018938D404-0x000000018938D484
		[IteratorStateMachine(typeof(_IndependentActionUpdater_d__12))]
		private IEnumerator IndependentActionUpdater(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback) => default; // 0x000000018938D514-0x000000018938D5BC
		[Obsolete("Use \'Execute\'")]
		public NodeCanvas.Framework.Status ExecuteAction(Component agent, IBlackboard blackboard) => default; // 0x000000018938D3FC-0x000000018938D404
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard) => default; // 0x000000018938D484-0x000000018938D514
		public void EndAction() {} // 0x0000000189361EBC-0x0000000189361EC8
		public void EndAction(bool success) {} // 0x000000018938D3AC-0x000000018938D3FC
		public void EndAction(bool? success) {} // 0x000000018938D314-0x000000018938D3AC
		public void Pause() {} // 0x000000018938D5BC-0x000000018938D5D4
		protected virtual void OnExecute() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnStop(bool interrupted) {} // 0x000000018289D0F0-0x000000018289D490
		protected virtual void OnStop() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnPause() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnResume() {} // 0x000000018350B670-0x000000018350B680
	}

	[DoNotList]
	public class ConditionList : ConditionTask // TypeDefIndex: 48237
	{
		// Fields
		public ConditionsCheckMode checkMode; // 0x68
		public List<ConditionTask> conditions; // 0x70
	
		// Properties
		private bool allTrueRequired { get => default; } // 0x00000001893902F4-0x00000001893902FC 
		protected override string info { get => default; } // 0x00000001893902FC-0x00000001893904F8 
	
		// Nested types
		public enum ConditionsCheckMode // TypeDefIndex: 48236
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}
	
		// Constructors
		public ConditionList() {} // 0x0000000189390278-0x00000001893902F4
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem) => default; // 0x000000018938FD98-0x000000018938FF78
		protected override void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnDisable() {} // 0x000000018939015C-0x00000001893901D8
		protected override bool OnCheck() => default; // 0x000000018938FFFC-0x000000018939015C
		public override void OnDrawGizmosSelected() {} // 0x00000001893901D8-0x0000000189390278
		public void AddCondition(ConditionTask condition) {} // 0x000000018938FBB0-0x000000018938FD98
		internal override string GetWarningOrError() => default; // 0x000000018938FF78-0x000000018938FFFC
	}

	public abstract class ConditionTask<T> : ConditionTask // TypeDefIndex: 48238
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ConditionTask() {}
	}

	public abstract class ConditionTask : NodeCanvas.Framework.Task // TypeDefIndex: 48240
	{
		// Fields
		[SerializeField]
		private bool _invert; // 0x58
		private int yieldReturn; // 0x5C
		private int yields; // 0x60
		private bool isRuntimeEnabled; // 0x64
	
		// Properties
		public bool invert { get; set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
	
		// Constructors
		protected ConditionTask() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		public void Enable(Component agent, IBlackboard bb) {} // 0x00000001893905E0-0x0000000189390618
		public void Disable() {} // 0x00000001893905C0-0x00000001893905E0
		[Obsolete("Use \'Check\'")]
		public bool CheckCondition(Component agent, IBlackboard blackboard) => default; // 0x00000001893904F8-0x0000000189390500
		public bool Check(Component agent, IBlackboard blackboard) => default; // 0x0000000189390550-0x00000001893905C0
		public bool CheckOnce(Component agent, IBlackboard blackboard) => default; // 0x0000000189390500-0x0000000189390550
		protected void YieldReturn(bool value, bool keepValueUntilUsed = false /* Metadata: 0x01FBB795 */) {} // 0x0000000189390674-0x00000001893906AC
		[IteratorStateMachine(typeof(_Flip_d__13))]
		private IEnumerator Flip() => default; // 0x0000000189390618-0x0000000189390674
		protected virtual void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual bool OnCheck() => default; // 0x000000018232EB60-0x000000018232EB70
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("[EventReceiver] is no longer used. Please use the \'.router\' property to subscribe/unsubscribe to events (in OnExecute/OnStop for actions and OnEnable/OnDisable for conditions). For custom events, use \'.router.onCustomEvent\'.")]
	public class EventReceiverAttribute : Attribute // TypeDefIndex: 48241
	{
		// Fields
		public readonly string[] eventMessages; // 0x10
	
		// Constructors
		public EventReceiverAttribute() {} // Dummy constructor
		public EventReceiverAttribute(params string[] args) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public interface ITaskSystem // TypeDefIndex: 48242
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
	[fsDeserializeOverwrite]
	[SpoofAOT]
	public abstract class Task : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 48244
	{
		// Fields
		[fsSerializeAs("_isDisabled")]
		private bool _isUserDisabled; // 0x10
		[fsSerializeAs("overrideAgent")]
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
		public ITaskSystem ownerSystem { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Component ownerSystemAgent { get; } // 0x000000018939E3A4-0x000000018939E418 
		public IBlackboard ownerSystemBlackboard { get; } // 0x000000018939E418-0x000000018939E438 
		public float ownerSystemElapsedTime { get; } // 0x000000018939E438-0x000000018939E458 
		public bool isUserEnabled { get; internal set; } // 0x000000018354EED0-0x000000018354EEE0 0x000000018939E73C-0x000000018939E744
		public string obsolete { get; } // 0x000000018939E2F8-0x000000018939E3A4 
		public string name { get; } // 0x000000018939E21C-0x000000018939E2F8 
		public string description { get; } // 0x000000018939E170-0x000000018939E21C 
		public string summaryInfo { get; } // 0x000000018939E538-0x000000018939E690 
		protected virtual string info { get; } // 0x0000000185876F5C-0x0000000185876F64 
		public virtual System.Type agentType { get; } // 0x0000000181002730-0x0000000181002740 
		public string agentInfo { get; } // 0x000000018939E058-0x000000018939E0A4 
		public string agentParameterName { get; } // 0x000000018939E0A4-0x000000018939E0B8 
		public bool agentIsOverride { get; set; } // 0x0000000182702DB0-0x0000000182702DC0 0x000000018939E690-0x000000018939E73C
		public Component agent { get; } // 0x000000018939E0B8-0x000000018939E168 
		public IBlackboard blackboard { get; } // 0x000000018939E168-0x000000018939E170 
		public EventRouter router { get; } // 0x000000018939E458-0x000000018939E538 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Field)]
		protected class GetFromAgentAttribute : Attribute // TypeDefIndex: 48243
		{
			// Constructors
			public GetFromAgentAttribute() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public Task() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018939DF98-0x000000018939E020
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018350B670-0x000000018350B680
		public static T Create<T>(ITaskSystem newOwnerSystem)
			where T : Task => default;
		public static Task Create(System.Type type, ITaskSystem newOwnerSystem) => default; // 0x000000018939D1B8-0x000000018939D2EC
		public virtual Task Duplicate(ITaskSystem newOwnerSystem) => default; // 0x000000018939D2EC-0x000000018939D384
		public void Validate(ITaskSystem ownerSystem) {} // 0x000000018939E020-0x000000018939E058
		public void SetOwnerSystem(ITaskSystem newOwnerSystem) {} // 0x0000000184271930-0x0000000184271940
		protected bool Set(Component newAgent, IBlackboard newBB) => default; // 0x000000018939DD7C-0x000000018939DE94
		private bool Initialize(Component newAgent) => default; // 0x000000018939DB88-0x000000018939DCDC
		private bool InitializeFieldAttributes(Component newAgent) => default; // 0x000000018939D928-0x000000018939DB88
		protected bool Error(string error, string tag = "Execution" /* Metadata: 0x01FBB796 */) => default; // 0x000000018115F4C0-0x000000018115F530
		protected Coroutine StartCoroutine(IEnumerator routine) => default; // 0x000000018939DE94-0x000000018939DF14
		protected void StopCoroutine(Coroutine routine) {} // 0x000000018939DF14-0x000000018939DF90
		protected void SendEvent(string name) {} // 0x000000018939DCEC-0x000000018939DD7C
		protected void SendEvent<T>(string name, T value) {}
		internal virtual string GetWarningOrError() => default; // 0x000000018939D4A0-0x000000018939D928
		protected virtual string OnErrorCheck() => default; // 0x0000000181002730-0x0000000181002740
		private string GetHardError() => default; // 0x000000018939D384-0x000000018939D4A0
		protected virtual string OnInit() => default; // 0x0000000181002730-0x0000000181002740
		public virtual void OnCreate(ITaskSystem ownerSystem) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018350B670-0x000000018350B680
		[Obsolete("Use OnDrawGizmosSelected")]
		public virtual void OnDrawGizmos() {} // 0x000000018939DCDC-0x000000018939DCEC
		public virtual void OnDrawGizmosSelected() {} // 0x000000018350B670-0x000000018350B680
		public void ClearTaskData() {} // 0x000000018939D1A8-0x000000018939D1B8
		protected virtual void OnClearTaskData() {} // 0x000000018350B670-0x000000018350B680
		public override string ToString() => default; // 0x000000018939DF90-0x000000018939DF98
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/CanvasCore/Blackboard Asset")]
	public class AssetBlackboard : ScriptableObject, ISerializationCallbackReceiver, IGlobalBlackboard // TypeDefIndex: 48245
	{
		// Fields
		[SerializeField]
		private string _serializedBlackboard; // 0x28
		[SerializeField]
		private List<UnityEngine.Object> _objectReferences; // 0x30
		[SerializeField]
		private string _UID; // 0x38
		[NonSerialized]
		private string _identifier; // 0x40
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x48
	
		// Properties
		Dictionary<string, Variable> IBlackboard.variables { get => default; set {} } // 0x000000018938D624-0x000000018938D640 0x000000018938D640-0x000000018938D664
		UnityEngine.Object IBlackboard.unityContextObject { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		IBlackboard IBlackboard.parent { get => default; } // 0x0000000181002730-0x0000000181002740 
		Component IBlackboard.propertiesBindTarget { get => default; } // 0x0000000181002730-0x0000000181002740 
		string IBlackboard.independantVariablesFieldName { get => default; } // 0x0000000181002730-0x0000000181002740 
		public string identifier { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public string UID { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Events
		public event Action<Variable> onVariableAdded;
		public event Action<Variable> onVariableRemoved;
	
		// Constructors
		public AssetBlackboard() {} // 0x000000018938D914-0x000000018938D9BC
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018938D90C-0x000000018938D914
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018938D904-0x000000018938D90C
		private void SelfSerialize() {} // 0x000000018938D79C-0x000000018938D8A4
		private void SelfDeserialize() {} // 0x000000018938D6D8-0x000000018938D79C
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable) {} // 0x0000000187BED400-0x0000000187BED414
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable) {} // 0x000000018938D610-0x000000018938D624
		[ContextMenu("Show Json")]
		private void ShowJson() {} // 0x000000018938D8A4-0x000000018938D904
		public override string ToString() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		private void OnValidate() {} // 0x000000018938D6B4-0x000000018938D6D8
		private void OnEnable() {} // 0x000000018938D664-0x000000018938D6B4
	}

	[Serializable]
	[fsAutoInstance(true)]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class BBParameter : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 48247
	{
		// Fields
		[SerializeField]
		private string _name; // 0x10
		[SerializeField]
		private string _targetVariableID; // 0x18
		private IBlackboard _bb; // 0x20
		private Variable _varRef; // 0x28
	
		// Properties
		public string targetVariableID { get; protected set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Variable varRef { get; protected set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x000000018938EB80-0x000000018938EBE4
		public string name { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018938EA60-0x000000018938EAE0
		public IBlackboard bb { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x000000018938EA14-0x000000018938EA60
		public bool useBlackboard { get; set; } // 0x000000018246CF60-0x000000018246CF70 0x000000018938EAE0-0x000000018938EB6C
		public bool isPresumedDynamic { get; } // 0x000000018938E8A8-0x000000018938E950 
		public bool isNone { get; } // 0x000000018938E83C-0x000000018938E884 
		public bool isNull { get; } // 0x000000018938E884-0x000000018938E8A8 
		public bool isNoneOrNull { get; } // 0x000000018938E80C-0x000000018938E83C 
		public bool isDefined { get; } // 0x0000000182B74620-0x0000000182B74640 
		public System.Type refType { get; } // 0x000000018938E950-0x000000018938E978 
		public object value { get; set; } // 0x000000018938E978-0x000000018938E988 0x000000018938EB6C-0x000000018938EB80
		public abstract System.Type varType { get; }
	
		// Events
		public event Action<Variable> onVariableReferenceChanged;
	
		// Constructors
		public BBParameter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018938E768-0x000000018938E780
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018350B670-0x000000018350B680
		public static BBParameter CreateInstance(System.Type t, IBlackboard bb) => default; // 0x000000018938DFF4-0x000000018938E12C
		public static void SetBBFields(object target, IBlackboard bb) {} // 0x000000018938E3A8-0x000000018938E498
		protected abstract void SetDefaultValue();
		protected abstract void Bind(Variable data);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		public void SetTargetVariable(IBlackboard targetBB, Variable targetVariable) {} // 0x000000018938E498-0x000000018938E5FC
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID) => default; // 0x000000018938E254-0x000000018938E3A8
		public Variable PromoteToVariable(IBlackboard targetBB) => default; // 0x000000018938E12C-0x000000018938E254
		public sealed override string ToString() => default; // 0x000000018938E5FC-0x000000018938E768
	}

	[Serializable]
	public class BBParameter<T> : BBParameter // TypeDefIndex: 48251
	{
		// Fields
		[SerializeField]
		protected T _value;
	
		// Properties
		public new T value { get => default; set {} }
		public override System.Type varType { get => default; }
	
		// Events
		private event Func<T> getter;
		private event Action<T> setter;
	
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

	[SpoofAOT]
	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard // TypeDefIndex: 48252
	{
		// Fields
		[SerializeField]
		[Tooltip("An optional Parent Blackboard Asset to \'inherit\' variables from.")]
		private AssetBlackboard _parentBlackboard; // 0x18
		[SerializeField]
		private string _serializedBlackboard; // 0x20
		[SerializeField]
		private List<UnityEngine.Object> _objectReferences; // 0x28
		[SerializeField]
		private SerializationPair[] _serializedVariables; // 0x30
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x38
		[NonSerialized]
		private bool haltForUndo; // 0x40
		[NonSerialized]
		private string _identifier; // 0x48
	
		// Properties
		public BlackboardSource blackboard { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public AssetBlackboard parentBlackboard { get => default; } // 0x0000000181041090-0x00000001810410A0 
		string IBlackboard.identifier { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		Dictionary<string, Variable> IBlackboard.variables { get => default; set {} } // 0x000000018938F248-0x000000018938F264 0x000000018938F264-0x000000018938F288
		Component IBlackboard.propertiesBindTarget { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		UnityEngine.Object IBlackboard.unityContextObject { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		IBlackboard IBlackboard.parent { get => default; } // 0x0000000181041090-0x00000001810410A0 
		string IBlackboard.independantVariablesFieldName { get => default; } // 0x000000018938F21C-0x000000018938F248 
	
		// Events
		public event Action<Variable> onVariableAdded;
		public event Action<Variable> onVariableRemoved;
	
		// Constructors
		public Blackboard() {} // 0x000000018938F910-0x000000018938F980
	
		// Methods
		public void SetParentBlackboard(AssetBlackboard bb) {} // 0x00000001822C3A90-0x00000001822C3AA0
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018938F908-0x000000018938F910
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018938F900-0x000000018938F908
		public void SelfSerialize() {} // 0x000000018938F4E4-0x000000018938F7E0
		public void SelfDeserialize() {} // 0x000000018938F328-0x000000018938F4E4
		public string Serialize(List<UnityEngine.Object> references, bool pretyJson = false /* Metadata: 0x01FBB7A0 */) => default; // 0x000000018938F7E0-0x000000018938F898
		public bool Deserialize(string json, List<UnityEngine.Object> references, bool removeMissingVariables = true /* Metadata: 0x01FBB7A1 */) => default; // 0x000000018938F074-0x000000018938F120
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable) {} // 0x000000018938F1F4-0x000000018938F208
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable) {} // 0x000000018938F208-0x000000018938F21C
		protected virtual void Awake() {} // 0x000000018938F024-0x000000018938F074
		public Variable AddVariable(string name, System.Type type) => default; // 0x000000018938F01C-0x000000018938F024
		public Variable AddVariable(string name, object value) => default; // 0x000000018938F014-0x000000018938F01C
		public Variable RemoveVariable(string name) => default; // 0x000000018938F2C0-0x000000018938F2C8
		public Variable GetVariable(string name, System.Type ofType = null) => default; // 0x000000018938F128-0x000000018938F130
		public Variable GetVariableByID(string ID) => default; // 0x000000018938F120-0x000000018938F128
		public Variable<T> GetVariable<T>(string name) => default;
		public T GetVariableValue<T>(string name) => default;
		public Variable SetVariableValue(string name, object value) => default; // 0x000000018938F898-0x000000018938F8A0
		[Obsolete("Use GetVariableValue")]
		public T GetValue<T>(string name) => default;
		[Obsolete("Use SetVariableValue")]
		public Variable SetValue(string name, object value) => default; // 0x000000018938F898-0x000000018938F8A0
		[ContextMenu("Show Json")]
		private void ShowJson() {} // 0x000000018938F8A0-0x000000018938F900
		public string Save() => default; // 0x000000018938F304-0x000000018938F328
		public string Save(string saveKey) => default; // 0x000000018938F2C8-0x000000018938F304
		public bool Load() => default; // 0x000000018938F1D0-0x000000018938F1F4
		public bool Load(string saveKey) => default; // 0x000000018938F130-0x000000018938F1D0
		protected virtual void OnValidate() {} // 0x000000018938F288-0x000000018938F2C0
		public override string ToString() => default; // 0x0000000183D4EA70-0x0000000183D4EA80
	}

	[ExecuteInEditMode]
	public class GlobalBlackboard : NodeCanvas.Framework.Blackboard, IGlobalBlackboard // TypeDefIndex: 48255
	{
		// Fields
		[SerializeField]
		private string _UID; // 0x60
		[SerializeField]
		[Tooltip("A *unique* identifier of this Global Blackboard")]
		private string _identifier; // 0x68
		[SerializeField]
		[Tooltip("If a duplicate with the same identifier is encountered, destroy the previous Global Blackboard component only, or the previous Global Blackboard gameobject entirely?")]
		private SingletonMode _singletonMode; // 0x70
		[SerializeField]
		[Tooltip("If true, the Global Blackboard will not be destroyed when another scene is loaded.")]
		private bool _dontDestroyOnLoad; // 0x74
		private static List<GlobalBlackboard> _allGlobals; // 0x00
	
		// Properties
		public string identifier { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public string UID { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public new string name { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
	
		// Nested types
		public enum SingletonMode // TypeDefIndex: 48253
		{
			DestroyComponentOnly = 0,
			DestroyEntireGameObject = 1
		}
	
		// Constructors
		public GlobalBlackboard() {} // 0x0000000189391090-0x00000001893910E4
		static GlobalBlackboard() {} // 0x0000000189391004-0x0000000189391090
	
		// Methods
		public static IEnumerable<GlobalBlackboard> GetAll() => default; // 0x0000000189390C00-0x0000000189390C50
		public static GlobalBlackboard Create() => default; // 0x0000000189390A64-0x0000000189390B0C
		public static GlobalBlackboard Find(string name) => default; // 0x0000000189390B0C-0x0000000189390C00
		protected void OnEnable() {} // 0x0000000189390CC0-0x0000000189390E94
		protected void OnDisable() {} // 0x0000000189390C50-0x0000000189390CC0
		protected override void OnValidate() {} // 0x0000000189390E94-0x0000000189391004
		public override string ToString() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		private bool IsPrefabAsset() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public interface IBlackboard // TypeDefIndex: 48256
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

	public interface IGlobalBlackboard : IBlackboard // TypeDefIndex: 48257
	{
		// Properties
		string UID { get; }
	}

	[SpoofAOT]
	public static class IBlackboardExtensions // TypeDefIndex: 48260
	{
		// Extension methods
		public static IBlackboard GetRoot(this IBlackboard blackboard) => default; // 0x0000000189392C6C-0x0000000189392CAC
		[IteratorStateMachine(typeof(_GetAllParents_d__1))]
		public static IEnumerable<IBlackboard> GetAllParents(this IBlackboard blackboard, bool includeSelf) => default; // 0x0000000189392BEC-0x0000000189392C6C
		public static bool IsPartOf(this IBlackboard blackboard, IBlackboard child) => default; // 0x0000000189393254-0x0000000189393294
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName, T value) => default;
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName) => default;
		public static Variable AddVariable(this IBlackboard blackboard, string varName, object value) => default; // 0x0000000189392864-0x00000001893928CC
		public static Variable AddVariable(this IBlackboard blackboard, string varName, System.Type type) => default; // 0x00000001893928CC-0x0000000189392A10
		public static Variable RemoveVariable(this IBlackboard blackboard, string varName) => default; // 0x00000001893936C0-0x0000000189393780
		public static T GetVariableValue<T>(this IBlackboard blackboard, string varName) => default;
		public static Variable SetVariableValue(this IBlackboard blackboard, string varName, object value) => default; // 0x0000000189393780-0x0000000189393898
		public static void InitializePropertiesBinding(this IBlackboard blackboard, Component target, bool callSetter) {} // 0x0000000189393088-0x0000000189393254
		public static Variable<T> GetVariable<T>(this IBlackboard blackboard, string varName) => default;
		public static Variable GetVariable(this IBlackboard blackboard, string varName, System.Type ofType = null) => default; // 0x0000000189392EC4-0x0000000189393000
		public static Variable GetVariableByID(this IBlackboard blackboard, string ID) => default; // 0x0000000189392CAC-0x0000000189392EC4
		[IteratorStateMachine(typeof(_GetVariables_d__14))]
		public static IEnumerable<Variable> GetVariables(this IBlackboard blackboard, System.Type ofType = null) => default; // 0x0000000189393000-0x0000000189393088
		public static Variable ChangeVariableType(this IBlackboard blackboard, Variable target, System.Type newType) => default; // 0x0000000189392A10-0x0000000189392BEC
		public static void OverwriteFrom(this IBlackboard blackboard, IBlackboard sourceBlackboard, bool removeMissingVariables = true /* Metadata: 0x01FBB7A4 */) {} // 0x0000000189393294-0x00000001893936C0
	}

	public static class BlackboardHelpers // TypeDefIndex: 48262
	{
		// Fields
		private static readonly ConcurrentDictionary<System.Type, System.Type> s_variableTypeCache; // 0x00
	
		// Constructors
		static BlackboardHelpers() {} // 0x000000018938ED24-0x000000018938EDB0
	
		// Methods
		public static System.Type CreateVariableType(System.Type valueType) => default; // 0x000000018938EBE4-0x000000018938ED24
	}

	[Serializable]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class Variable // TypeDefIndex: 48265
	{
		// Fields
		[SerializeField]
		private string _name; // 0x10
		[SerializeField]
		private string _id; // 0x18
		[SerializeField]
		private bool _isPublic; // 0x20
		[fsIgnoreInBuild]
		[SerializeField]
		private bool _debugBoundValue; // 0x21
	
		// Properties
		public string name { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x00000001893A2010-0x00000001893A2060
		public string ID { get; } // 0x0000000189376BD4-0x0000000189376C30 
		public object value { get; set; } // 0x00000001893A1E54-0x00000001893A1E64 0x00000001893A2060-0x00000001893A2074
		public bool isExposedPublic { get; set; } // 0x00000001893A1E10-0x00000001893A1E2C 0x0000000183D4EFC0-0x0000000183D4EFD0
		public bool debugBoundValue { get; set; } // 0x0000000183D4F070-0x0000000183D4F080 0x0000000183D4F080-0x0000000183D4F090
		public bool isPropertyBound { get; } // 0x00000001893A1E2C-0x00000001893A1E54 
		public abstract bool isDataBound { get; }
		public abstract System.Type varType { get; }
		public abstract string propertyPath { get; set; }
	
		// Events
		public event Action<string> onNameChanged;
		public event Action<object> onValueChanged;
		public event Action onDestroy;
	
		// Constructors
		public Variable() {} // 0x00000001893A1C20-0x00000001893A1C64
		public Variable(string name, string ID) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public abstract void BindProperty(MemberInfo prop, GameObject target = null);
		public abstract void UnBind();
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x01FBB7A5 */);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		public abstract void ResetDefaultValue();
		public abstract void RecordDefaultValue();
		internal void OnDestroy() {} // 0x00000001893A1BF8-0x00000001893A1C0C
		public Variable Duplicate(IBlackboard targetBB) => default; // 0x00000001893A184C-0x00000001893A1958
		protected bool HasValueChangeEvent() => default; // 0x00000001885839D0-0x00000001885839DC
		protected void TryInvokeValueChangeEvent(object value) {} // 0x00000001893A1C0C-0x00000001893A1C20
		public bool CanConvertTo(System.Type toType) => default; // 0x00000001893A1834-0x00000001893A184C
		public Func<object> GetGetConverter(System.Type toType) => default; // 0x00000001893A1958-0x00000001893A1AA8
		public bool CanConvertFrom(System.Type fromType) => default; // 0x00000001893A181C-0x00000001893A1834
		public Action<object> GetSetConverter(System.Type fromType) => default; // 0x00000001893A1AA8-0x00000001893A1BF8
		public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
	}

	public class Variable<T> : Variable // TypeDefIndex: 48270
	{
		// Fields
		[SerializeField]
		private T _value;
		[SerializeField]
		private string _propertyPath;
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
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x01FBB7A6 */) {}
	}

	public class VariableSeperator // TypeDefIndex: 48271
	{
		// Properties
		public bool isEditingName { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public VariableSeperator() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace NodeCanvas.Framework.Internal
{
	public struct GraphLoadData // TypeDefIndex: 48272
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
	[fsDeserializeOverwrite]
	public class GraphSource : ISerializationCollector // TypeDefIndex: 48273
	{
		// Fields
		private List<NodeCanvas.Framework.Task> m_allTasks; // 0x10
		public List<BBParameter> m_allParameters; // 0x18
		public const float FRAMEWORK_VERSION = 3.25f; // Metadata: 0x01FBB7A7
		[fsIgnoreInBuild]
		[fsSerializeAs("version")]
		[fsWriteOnly]
		[SerializeField]
		private float _version; // 0x20
		[fsIgnoreInBuild]
		[fsSerializeAs("category")]
		[fsWriteOnly]
		[SerializeField]
		private string _category; // 0x28
		[fsIgnoreInBuild]
		[fsSerializeAs("comments")]
		[fsWriteOnly]
		[SerializeField]
		private string _comments; // 0x30
		[fsIgnoreInBuild]
		[fsSerializeAs("translation")]
		[fsWriteOnly]
		[SerializeField]
		private Vector2 _translation; // 0x38
		[fsIgnoreInBuild]
		[fsSerializeAs("zoomFactor")]
		[fsWriteOnly]
		[SerializeField]
		private float _zoomFactor; // 0x40
		[fsSerializeAs("type")]
		private string _type; // 0x48
		[fsSerializeAs("nodes")]
		private List<NodeCanvas.Framework.Node> _nodes; // 0x50
		[fsSerializeAs("connections")]
		private List<Connection> _connections; // 0x58
		[fsIgnoreInBuild]
		[fsSerializeAs("canvasGroups")]
		private List<NodeCanvas.Framework.CanvasGroup> _canvasGroups; // 0x60
		[fsSerializeAs("localBlackboard")]
		private BlackboardSource _localBlackboard; // 0x68
		[fsSerializeAs("derivedData")]
		private object _derivedData; // 0x70
	
		// Properties
		public List<NodeCanvas.Framework.Task> allTasks { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public List<BBParameter> allParameters { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float version { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public string category { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string comments { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public Vector2 translation { get => default; set {} } // 0x0000000183D71F20-0x0000000183D71F40 0x0000000183D4EE50-0x0000000183D4EE60
		public float zoomFactor { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public string type { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public List<NodeCanvas.Framework.Node> nodes { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public List<Connection> connections { get => default; private set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public BlackboardSource localBlackboard { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public object derivedData { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
	
		// Constructors
		public GraphSource() {} // 0x00000001837AF3B0-0x00000001837AF550
	
		// Methods
		void ISerializationCollector.OnPush(ISerializationCollector parent) {} // 0x0000000189392470-0x0000000189392530
		void ISerializationCollector.OnCollect(ISerializationCollectable child, int depth) {} // 0x0000000189392378-0x0000000189392470
		void ISerializationCollector.OnPop(ISerializationCollector parent) {} // 0x000000018350B670-0x000000018350B680
		public GraphSource Pack(NodeCanvas.Framework.Graph graph) => default; // 0x0000000189392198-0x0000000189392378
		public GraphSource Unpack(NodeCanvas.Framework.Graph graph) => default; // 0x00000001893925E0-0x0000000189392864
		public GraphSource SetMetaData(GraphSource source) => default; // 0x0000000189392578-0x00000001893925E0
		public void PurgeRedundantReferences() {} // 0x0000000189392530-0x0000000189392578
	}

	[Description("Please resolve the MissingConnection issue by either replacing the connection, importing the missing connection type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public sealed class MissingConnection : Connection, IMissingRecoverable // TypeDefIndex: 48274
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x30
		[SerializeField]
		private string _recoveryState; // 0x38
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
	
		// Constructors
		public MissingConnection() {} // 0x0000000183D5CDB0-0x0000000183D5CDC0
	}

	[Description("Please resolve the MissingNode issue by either replacing the node, importing the missing node type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public sealed class MissingNode : NodeCanvas.Framework.Node, IMissingRecoverable // TypeDefIndex: 48275
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x98
		[SerializeField]
		private string _recoveryState; // 0xA0
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public override string name { get => default; } // 0x00000001893944C8-0x000000018939451C 
		public override System.Type outConnectionType { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool canSelfConnect { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override Alignment2x2 commentsAlignment { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override Alignment2x2 iconAlignment { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public MissingNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[Serializable]
	public class ReflectedAction : ReflectedActionWrapper // TypeDefIndex: 48276
	{
		// Fields
		private ActionCall call; // 0x18
	
		// Constructors
		public ReflectedAction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override BBParameter[] GetVariables() => default; // 0x0000000189396680-0x00000001893966B4
		public override void Init(object instance) {} // 0x00000001893966B4-0x0000000189396738
		public override void Call() {} // 0x000000018939665C-0x0000000189396680
	}

	[Serializable]
	[SpoofAOT]
	public class ReflectedAction<T1> : ReflectedActionWrapper // TypeDefIndex: 48277
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
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper // TypeDefIndex: 48278
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
	public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper // TypeDefIndex: 48279
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
	public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper // TypeDefIndex: 48280
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
	public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper // TypeDefIndex: 48281
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
	public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper // TypeDefIndex: 48282
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
	[SpoofAOT]
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper // TypeDefIndex: 48283
	{
		// Fields
		private FunctionCall<TResult> call;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper // TypeDefIndex: 48284
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		public BBParameter<T1> p1;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper // TypeDefIndex: 48285
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper // TypeDefIndex: 48286
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper // TypeDefIndex: 48287
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper // TypeDefIndex: 48288
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper // TypeDefIndex: 48289
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
		public BBParameter<T6> p6;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction() {}
	
		// Methods
		public override BBParameter[] GetVariables() => default;
		public override void Init(object instance) {}
		public override object Call() => default;
	}

	public abstract class ReflectedWrapper : IReflectedWrapper // TypeDefIndex: 48290
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo _targetMethod; // 0x10
	
		// Constructors
		public ReflectedWrapper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb) => default; // 0x0000000189396B30-0x0000000189396BD8
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public void SetVariablesBB(IBlackboard bb) {} // 0x0000000189396BFC-0x0000000189396C60
		public SerializedMethodInfo GetSerializedMethod() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public MethodInfo GetMethod() => default; // 0x0000000189396BD8-0x0000000189396BE8
		public bool HasChanged() => default; // 0x0000000189396BE8-0x0000000189396BFC
		public string AsString() => default; // 0x0000000189396B10-0x0000000189396B30
		public override string ToString() => default; // 0x0000000189396C60-0x0000000189396C68
		public abstract BBParameter[] GetVariables();
		public abstract void Init(object instance);
	}

	public abstract class ReflectedActionWrapper : ReflectedWrapper // TypeDefIndex: 48291
	{
		// Constructors
		protected ReflectedActionWrapper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static new ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb) => default; // 0x00000001893962BC-0x000000018939665C
		public abstract void Call();
	}

	public abstract class ReflectedFunctionWrapper : ReflectedWrapper // TypeDefIndex: 48292
	{
		// Constructors
		protected ReflectedFunctionWrapper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static new ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb) => default; // 0x0000000189396738-0x0000000189396B10
		public abstract object Call();
	}

	[Description("Please resolve the MissingAction issue by either replacing the action, importing the missing action type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public class MissingAction : ActionTask, IMissingRecoverable // TypeDefIndex: 48293
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x68
		[SerializeField]
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		protected override string info { get => default; } // 0x00000001893943C8-0x0000000189394434 
	
		// Constructors
		public MissingAction() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	}

	[Description("Please resolve the MissingCondition issue by either replacing the condition, importing the missing condition type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public class MissingCondition : ConditionTask, IMissingRecoverable // TypeDefIndex: 48294
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x68
		[SerializeField]
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		protected override string info { get => default; } // 0x000000018939445C-0x00000001893944C8 
	
		// Constructors
		public MissingCondition() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	}

	[Serializable]
	[fsAutoInstance(false)]
	public sealed class TaskAgentParameter : BBParameter<UnityEngine.Object> // TypeDefIndex: 48295
	{
		// Fields
		[SerializeField]
		private System.Type _type; // 0x50
	
		// Properties
		public override System.Type varType { get => default; } // 0x000000018939D148-0x000000018939D1A8 
		public new UnityEngine.Object value { get => default; set {} } // 0x000000018939D0A0-0x000000018939D148 0x000000018388FF30-0x000000018388FF40
	
		// Constructors
		public TaskAgentParameter() {} // 0x000000018939D078-0x000000018939D0A0
	
		// Methods
		public override object GetValueBoxed() => default; // 0x000000018939CF84-0x000000018939CF8C
		public override void SetValueBoxed(object newValue) {} // 0x000000018939D024-0x000000018939D078
		public void SetType(System.Type newType) {} // 0x000000018939CF8C-0x000000018939D024
	}

	[Serializable]
	public class BBMappingParameter : BBObjectParameter // TypeDefIndex: 48296
	{
		// Fields
		[SerializeField]
		private string _targetSubGraphVariableID; // 0x60
		[SerializeField]
		private bool _canRead; // 0x68
		[SerializeField]
		private bool _canWrite; // 0x69
	
		// Properties
		public string targetSubGraphVariableID { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public bool canRead { get => default; set {} } // 0x0000000183D4F3F0-0x0000000183D4F400 0x0000000183D4F440-0x0000000183D4F450
		public bool canWrite { get => default; set {} } // 0x0000000183D4F3C0-0x0000000183D4F3D0 0x0000000183D4F410-0x0000000183D4F420
	
		// Constructors
		public BBMappingParameter() {} // 0x000000018938DBEC-0x000000018938DBF4
		public BBMappingParameter(Variable subVariable) {} // 0x000000018938DBF4-0x000000018938DC54
	}

	[Serializable]
	public class BBObjectParameter : BBParameter<object>, ISerializationCallbackReceiver // TypeDefIndex: 48297
	{
		// Fields
		[SerializeField]
		private string _type; // 0x50
	
		// Properties
		private System.Type type { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public override System.Type varType { get => default; } // 0x000000018938DF7C-0x000000018938DFF4 
	
		// Constructors
		public BBObjectParameter() {} // 0x000000018938DF04-0x000000018938DF7C
		public BBObjectParameter(System.Type t) {} // 0x000000018938DEC0-0x000000018938DF04
		public BBObjectParameter(BBParameter source) {} // 0x000000018938DE30-0x000000018938DEC0
	
		// Methods
		new void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018938DDC0-0x000000018938DE30
		new void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018938DD60-0x000000018938DDC0
		public void SetType(System.Type t) {} // 0x000000018938DC54-0x000000018938DD60
	}

	[Serializable]
	public class BlackboardSource : IBlackboard // TypeDefIndex: 48298
	{
		// Fields
		[SerializeField]
		private Dictionary<string, Variable> _variables; // 0x10
	
		// Properties
		public string identifier { get => default; } // 0x000000018938EED0-0x000000018938EEFC 
		public Dictionary<string, Variable> variables { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public IBlackboard parent { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public UnityEngine.Object unityContextObject { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public Component propertiesBindTarget { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		string IBlackboard.independantVariablesFieldName { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Events
		public event Action<Variable> onVariableAdded;
		public event Action<Variable> onVariableRemoved;
	
		// Constructors
		public BlackboardSource() {} // 0x00000001837AF550-0x00000001837AF600
	
		// Methods
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable) {} // 0x0000000187BED400-0x0000000187BED414
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable) {} // 0x000000018938D610-0x000000018938D624
		public override string ToString() => default; // 0x000000018938EDB0-0x000000018938EDB8
	}

	public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType> // TypeDefIndex: 48299
	{
		// Constructors
		public fsBBParameterProcessor() {} // 0x00000001893A22F4-0x00000001893A2410
	
		// Methods
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x00000001893A2074-0x00000001893A22F4
	}

	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable // TypeDefIndex: 48300
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x50
		[SerializeField]
		private string _recoveryState; // 0x58
	
		// Properties
		string IMissingRecoverable.missingType { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		string IMissingRecoverable.recoveryState { get => default; set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
	
		// Constructors
		public MissingBBParameterType() {} // 0x0000000189394434-0x000000018939445C
	}

	public class MissingVariableType : Variable<object>, IMissingRecoverable // TypeDefIndex: 48301
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x70
		[SerializeField]
		private string _recoveryState; // 0x78
	
		// Properties
		public string missingType { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public string recoveryState { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
	
		// Constructors
		public MissingVariableType() {} // 0x000000018939451C-0x0000000189394550
	}
}

namespace NodeCanvas.StateMachines
{
	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/FSM Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class FSM : NodeCanvas.Framework.Graph // TypeDefIndex: 48038
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private IStateCallbackReceiver[] callbackReceivers; // 0xA8
		private Stack<FSMState> stateStack; // 0xB0
		private bool enterStartStateFlag; // 0xB8
	
		// Properties
		public FSMState currentState { get; private set; } // 0x0000000183D51140-0x0000000183D51150 0x000000018589D964-0x000000018589D978
		public FSMState previousState { get; private set; } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001856A2B64-0x00000001856A2B78
		public string currentStateName { get => default; } // 0x0000000189366D88-0x0000000189366DB4 
		public string previousStateName { get => default; } // 0x0000000189366DB4-0x0000000189366DE0 
		public override System.Type baseNodeType { get => default; } // 0x0000000189366D38-0x0000000189366D88 
		public override bool requiresAgent { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool requiresPrimeNode { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool isTree { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool allowBlackboardOverrides { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public sealed override bool canAcceptVariableDrops { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool canDelayDeserializeAndOptimizeClone { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Events
		public event Action<IState> onStateEnter;
		public event Action<IState> onStateUpdate;
		public event Action<IState> onStateExit;
		public event Action<IState> onStateTransition;
	
		// Nested types
		public enum TransitionCallMode // TypeDefIndex: 48035
		{
			Normal = 0,
			Stacked = 1,
			Clean = 2
		}
	
		// Constructors
		public FSM() {} // 0x0000000189366AAC-0x0000000189366AF8
	
		// Methods
		protected override void OnGraphInitialize() {} // 0x00000001893662CC-0x000000018936648C
		protected override void OnGraphStarted() {} // 0x000000018936648C-0x0000000189366510
		protected override void OnGraphUpdate() {} // 0x0000000189366584-0x0000000189366868
		protected override void OnGraphStoped() {} // 0x0000000189366510-0x0000000189366584
		public bool EnterState(FSMState newState, TransitionCallMode callMode) => default; // 0x0000000189365C84-0x0000000189365E38
		public FSMState TriggerState(string stateName, TransitionCallMode callMode) => default; // 0x00000001893668CC-0x0000000189366918
		public string[] GetStateNames() => default; // 0x0000000189365FDC-0x00000001893661D8
		public FSMState GetStateWithName(string name) => default; // 0x00000001893661D8-0x00000001893662CC
		private void GatherCallbackReceivers() {} // 0x0000000189365E38-0x0000000189365FDC
		public FSMState PeekStack() => default; // 0x0000000189366868-0x00000001893668CC
	}

	public class FSMConnection : Connection, ITaskAssignable<ConditionTask> // TypeDefIndex: 48039
	{
		// Fields
		[SerializeField]
		private FSM.TransitionCallMode _transitionCallMode; // 0x30
		[SerializeField]
		private ConditionTask _condition; // 0x38
	
		// Properties
		public ConditionTask condition { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x00000001893650EC-0x0000000189365140
		public FSM.TransitionCallMode transitionCallMode { get => default; private set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
		// Constructors
		public FSMConnection() {} // 0x0000000183D5CDB0-0x0000000183D5CDC0
	
		// Methods
		public void EnableCondition(Component agent, IBlackboard blackboard) {} // 0x0000000189365024-0x0000000189365038
		public void DisableCondition() {} // 0x0000000189365010-0x0000000189365024
		public void PerformTransition() {} // 0x0000000189365038-0x00000001893650EC
	}

	public abstract class FSMNode : NodeCanvas.Framework.Node // TypeDefIndex: 48040
	{
		// Properties
		public override bool allowAsPrime { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool canSelfConnect { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override int maxInConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public override int maxOutConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public sealed override System.Type outConnectionType { get; } // 0x000000018936517C-0x00000001893651CC 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public FSM FSM { get; } // 0x0000000189365140-0x000000018936517C 
	
		// Constructors
		protected FSMNode() {} // 0x0000000185F46E3C-0x0000000185F46E44
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMNodeNested<T> : FSMNode, IGraphAssignable<T> // TypeDefIndex: 48041
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
	
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

	[AddComponentMenu("NodeCanvas/FSM Owner")]
	public class FSMOwner : GraphOwner<FSM> // TypeDefIndex: 48042
	{
		// Properties
		public string currentRootStateName { get => default; } // 0x0000000189365654-0x00000001893656EC 
		public string previousRootStateName { get => default; } // 0x0000000189365710-0x00000001893657A8 
		public string currentDeepStateName { get => default; } // 0x0000000189365630-0x0000000189365654 
		public string previousDeepStateName { get => default; } // 0x00000001893656EC-0x0000000189365710 
	
		// Constructors
		public FSMOwner() {} // 0x00000001893655FC-0x0000000189365630
	
		// Methods
		public IState GetCurrentState(bool includeSubFSMs = true /* Metadata: 0x01FBB6E1 */) => default; // 0x00000001893651CC-0x00000001893652FC
		public IState GetPreviousState(bool includeSubFSMs = true /* Metadata: 0x01FBB6E2 */) => default; // 0x00000001893652FC-0x00000001893654A0
		public IState TriggerState(string stateName) => default; // 0x0000000189365538-0x0000000189365544
		public IState TriggerState(string stateName, FSM.TransitionCallMode callMode) => default; // 0x0000000189365544-0x00000001893655FC
		public string[] GetStateNames() => default; // 0x00000001893654A0-0x0000000189365538
	}

	[Color("ff6d53")]
	public abstract class FSMState : FSMNode, IState // TypeDefIndex: 48044
	{
		// Fields
		[SerializeField]
		private TransitionEvaluationMode _transitionEvaluation; // 0x98
		private bool _hasInit; // 0x9C
	
		// Properties
		public override bool allowAsPrime { get; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool canSelfConnect { get; } // 0x000000018232EB60-0x000000018232EB70 
		public override int maxInConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public override int maxOutConnections { get; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public TransitionEvaluationMode transitionEvaluation { get; set; } // 0x0000000183D4EB50-0x0000000183D4EB60 0x0000000183D4EB80-0x0000000183D4EB90
	
		// Nested types
		public enum TransitionEvaluationMode // TypeDefIndex: 48043
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}
	
		// Constructors
		protected FSMState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public FSMConnection[] GetTransitions() => default; // 0x0000000189365960-0x0000000189365A70
		public void Finish() {} // 0x0000000189365930-0x0000000189365940
		public void Finish(bool inSuccess) {} // 0x0000000189365940-0x0000000189365960
		public void Finish(NodeCanvas.Framework.Status status) {} // 0x0000000189365928-0x0000000189365930
		public override void OnGraphPaused() {} // 0x0000000189365BB0-0x0000000189365BC4
		protected override bool CanConnectFromSource(NodeCanvas.Framework.Node sourceNode) => default; // 0x00000001893657A8-0x00000001893657C0
		protected override bool CanConnectToTarget(NodeCanvas.Framework.Node targetNode) => default; // 0x00000001893657C0-0x00000001893657D8
		protected sealed override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb) => default; // 0x0000000189365A70-0x0000000189365BB0
		public bool CheckTransitions() => default; // 0x00000001893657D8-0x0000000189365928
		protected sealed override void OnReset() {} // 0x0000000189365BC4-0x0000000189365C84
		protected virtual void OnInit() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnEnter() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnExit() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnPause() {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMStateNested<T> : FSMState, IGraphAssignable<T> // TypeDefIndex: 48045
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
	
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

	public interface IState // TypeDefIndex: 48046
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

	public interface IStateCallbackReceiver // TypeDefIndex: 48047
	{
		// Methods
		void OnStateEnter(IState state);
		void OnStateUpdate(IState state);
		void OnStateExit(IState state);
	}

	[Description("Execute a number of Action Tasks OnEnter. All actions will be stoped OnExit. This state is Finished when all Actions are finished as well")]
	[Name("Action State", 100)]
	public class ActionState : FSMState, ITaskAssignable // TypeDefIndex: 48048
	{
		// Fields
		[SerializeField]
		private ActionList _actionList; // 0xA0
		[SerializeField]
		private bool _repeatStateActions; // 0xA8
	
		// Properties
		public NodeCanvas.Framework.Task task { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000189376B50-0x0000000189376BA8
		public ActionList actionList { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public bool repeatStateActions { get => default; set {} } // 0x00000001811B9C10-0x00000001811B9C20 0x00000001811B9C20-0x00000001811B9C30
	
		// Constructors
		public ActionState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x0000000189376A84-0x0000000189376B50
		protected override void OnEnter() {} // 0x00000001893769B8-0x00000001893769C8
		protected override void OnUpdate() {} // 0x0000000189376A10-0x0000000189376A84
		protected override void OnExit() {} // 0x00000001893769C8-0x00000001893769EC
		protected override void OnPause() {} // 0x00000001893769EC-0x0000000189376A10
	}

	[Color("b3ff7f")]
	[Description("The transitions of this node will be constantly checked. If any becomes true, that transition will take place. This is not a state.")]
	[Name("Any State", 0)]
	public class AnyState : FSMNode, IUpdatable // TypeDefIndex: 48049
	{
		// Fields
		[Tooltip("If enabled, a transition to an already running state will not happen.")]
		public bool dontRetriggerStates; // 0x98
	
		// Properties
		public override string name { get => default; } // 0x0000000189377080-0x00000001893770AC 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public AnyState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189376EE4-0x0000000189376FCC
		public override void OnGraphStoped() {} // 0x0000000189376FCC-0x0000000189377080
		void IUpdatable.Update() {} // 0x0000000189376D10-0x0000000189376EE4
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub FSM in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub FSM", -1)]
	public class ConcurrentSubFSM : FSMNodeNested<FSM>, IUpdatable // TypeDefIndex: 48050
	{
		// Fields
		[ExposeField]
		[Name("Parallel FSM", 0)]
		[SerializeField]
		protected BBParameter<FSM> _subFSM; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override FSM subGraph { get => default; set {} } // 0x0000000189378290-0x00000001893782D8 0x00000001893782D8-0x0000000189378330
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public ConcurrentSubFSM() {} // 0x000000018937825C-0x0000000189378290
	
		// Methods
		public override void OnGraphStarted() {} // 0x000000018937817C-0x000000018937825C
		void IUpdatable.Update() {} // 0x0000000189378174-0x000000018937817C
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub Behaviour Tree in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub Behaviour Tree", -1)]
	public class ConcurrentSubTree : FSMNodeNested<BehaviourTree>, IUpdatable // TypeDefIndex: 48051
	{
		// Fields
		[ExposeField]
		[Name("Parallel Tree", 0)]
		[SerializeField]
		protected BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override BehaviourTree subGraph { get => default; set {} } // 0x00000001893785F8-0x0000000189378640 0x0000000189378640-0x0000000189378698
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public ConcurrentSubTree() {} // 0x00000001893785C4-0x00000001893785F8
	
		// Methods
		public override void OnGraphStarted() {} // 0x00000001893784E4-0x00000001893785C4
		void IUpdatable.Update() {} // 0x0000000189378174-0x000000018937817C
	}

	[Color("6ebbff")]
	[Description("This node has no functionality and you can use this for organization.\nIn comparison to an empty Action State, Transitions here are immediately evaluated in the same frame that this node is entered.")]
	[Name("Pass", 98)]
	public class EmptyState : FSMState // TypeDefIndex: 48052
	{
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
	
		// Constructors
		public EmptyState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		protected override void OnEnter() {} // 0x000000018937D1C4-0x000000018937D1EC
	}

	[Description("Execute a Behaviour Tree OnEnter. OnExit that Behavior Tree will be stoped or paused based on the relevant specified setting. You can optionaly specify a Success Event and a Failure Event which will be sent when the BT\'s root node status returns either of the two. If so, use alongside with a CheckEvent on a transition.")]
	[DropReferenceType(typeof(BehaviourTree))]
	[Icon("BT", false, "")]
	[Name("Sub BehaviourTree", 0)]
	public class NestedBTState : FSMStateNested<BehaviourTree> // TypeDefIndex: 48055
	{
		// Fields
		[ExposeField]
		[Name("Sub Tree", 0)]
		[SerializeField]
		private BBParameter<BehaviourTree> _nestedBT; // 0xB8
		[Tooltip("What will happen to the BT when this state exits.")]
		public BTExitMode exitMode; // 0xC0
		[Tooltip("Sould the BT repeat?")]
		public BTExecutionMode executionMode; // 0xC4
		[DimIfDefault]
		[Tooltip("The event to send when the BT finish in Success.")]
		public string successEvent; // 0xC8
		[DimIfDefault]
		[Tooltip("The event to send when the BT finish in Failure.")]
		public string failureEvent; // 0xD0
	
		// Properties
		public override BehaviourTree subGraph { get => default; set {} } // 0x0000000189385FEC-0x0000000189386034 0x0000000189386034-0x000000018938608C
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
	
		// Nested types
		public enum BTExecutionMode // TypeDefIndex: 48053
		{
			Once = 0,
			Repeat = 1
		}
	
		public enum BTExitMode // TypeDefIndex: 48054
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedBTState() {} // 0x0000000189385FAC-0x0000000189385FEC
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189385BF8-0x0000000189385DC4
		protected override void OnUpdate() {} // 0x0000000189385EEC-0x0000000189385FAC
		private void OnFinish(bool success) {} // 0x0000000189385E6C-0x0000000189385EEC
		protected override void OnExit() {} // 0x0000000189385DC4-0x0000000189385E6C
	}

	[Description("Execute the assigned Dialogue Tree OnEnter and stop it OnExit. Optionaly an event can be sent for whether the dialogue ended in Success or Failure. This can be controled by using the \'Finish\' Dialogue Node inside the Dialogue Tree. Use a \'CheckEvent\' condition to make use of those events. The \'Instigator\' Actor of the Dialogue Tree will be set to this graph agent.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue", 0)]
	public class NestedDTState : FSMStateNested<DialogueTree> // TypeDefIndex: 48056
	{
		// Fields
		[ExposeField]
		[Name("Sub Tree", 0)]
		[SerializeField]
		private BBParameter<DialogueTree> _nestedDLG; // 0xB8
		[DimIfDefault]
		[Tooltip("The event to send when the Dialogue Tree finished in Success.")]
		public string successEvent; // 0xC0
		[DimIfDefault]
		[Tooltip("The event to send when the Dialogue Tree finish in Failure.")]
		public string failureEvent; // 0xC8
	
		// Properties
		public override DialogueTree subGraph { get => default; set {} } // 0x0000000189386270-0x00000001893862B8 0x00000001893862B8-0x0000000189386310
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
	
		// Constructors
		public NestedDTState() {} // 0x000000018938623C-0x0000000189386270
	
		// Methods
		protected override void OnEnter() {} // 0x000000018938608C-0x0000000189386168
		protected override void OnUpdate() {} // 0x00000001893861E8-0x000000018938623C
		protected override void OnExit() {} // 0x0000000189386168-0x00000001893861E8
		private void OnDialogueFinished(bool success) {} // 0x000000018937DBF8-0x000000018937DC70
	}

	[Description("Execute a sub FSM OnEnter, and Stop that FSM OnExit. This state is Finished only when and if the sub FSM is finished as well.")]
	[DropReferenceType(typeof(FSM))]
	[Icon("FSM", false, "")]
	[Name("Sub FSM", 0)]
	public class NestedFSMState : FSMStateNested<FSM> // TypeDefIndex: 48058
	{
		// Fields
		[ExposeField]
		[Name("Sub FSM", 0)]
		[SerializeField]
		private BBParameter<FSM> _nestedFSM; // 0xB8
		[Tooltip("What will happen to the sub FSM when this state exits.")]
		public FSMExitMode exitMode; // 0xC0
	
		// Properties
		public override FSM subGraph { get => default; set {} } // 0x00000001893867C4-0x000000018938680C 0x000000018938680C-0x0000000189386864
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
	
		// Nested types
		public enum FSMExitMode // TypeDefIndex: 48057
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedFSMState() {} // 0x0000000189386790-0x00000001893867C4
	
		// Methods
		protected override void OnEnter() {} // 0x00000001893865AC-0x0000000189386694
		protected override void OnUpdate() {} // 0x000000018938673C-0x0000000189386790
		protected override void OnExit() {} // 0x0000000189386694-0x000000018938673C
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM starts/enters, if Conditions are met. This is not a state.")]
	[Icon("MacroIn", false, "")]
	[Name("On FSM Enter", 0)]
	public class OnFSMEnter : FSMNode, IUpdatable // TypeDefIndex: 48059
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public OnFSMEnter() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x00000001893871DC-0x000000018938734C
		public override void OnGraphStarted() {} // 0x00000001893870B4-0x0000000189387190
		public override void OnGraphStoped() {} // 0x0000000189387190-0x00000001893871DC
		void IUpdatable.Update() {} // 0x0000000189387048-0x00000001893870B4
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM stops/exits, if Conditions are met. Note that the actions will only execute for 1 frame. This is not a state.")]
	[Icon("MacroOut", false, "")]
	[Name("On FSM Exit", 0)]
	public class OnFSMExit : FSMNode // TypeDefIndex: 48060
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public OnFSMExit() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x0000000189387470-0x00000001893875E0
		public override void OnGraphStarted() {} // 0x000000018938734C-0x00000001893873A4
		public override void OnGraphStoped() {} // 0x00000001893873A4-0x0000000189387470
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions repeatedly and in parallel to any other FSM state while the FSM is running. Conditions are optional. This is not a state.")]
	[Icon("Repeat", false, "")]
	[Name("On FSM Update", 0)]
	public class OnFSMUpdate : FSMNode, IUpdatable // TypeDefIndex: 48061
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public OnFSMUpdate() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x00000001893876A8-0x0000000189387818
		public override void OnGraphStarted() {} // 0x000000018938734C-0x00000001893873A4
		public override void OnGraphStoped() {} // 0x0000000189387190-0x00000001893871DC
		void IUpdatable.Update() {} // 0x00000001893875E0-0x00000001893876A8
	}

	[Description("The Super Action State provides finer control on when to execute actions. This state is never Finished by it\'s own if there is any Actions in the OnUpdate list and thus OnFinish transitions will never be called in that case. OnExit Actions are only called for 1 frame when the state exits.")]
	[Name("Action State (Super)", 99)]
	public class SuperActionState : FSMState // TypeDefIndex: 48062
	{
		// Fields
		[SerializeField]
		private ActionList _onEnterList; // 0xA0
		[SerializeField]
		private ActionList _onUpdateList; // 0xA8
		[SerializeField]
		private ActionList _onExitList; // 0xB0
		private bool enterListFinished; // 0xB8
	
		// Constructors
		public SuperActionState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018938A720-0x000000018938A8FC
		protected override void OnEnter() {} // 0x000000018938A538-0x000000018938A54C
		protected override void OnUpdate() {} // 0x000000018938A638-0x000000018938A720
		protected override void OnExit() {} // 0x000000018938A54C-0x000000018938A5FC
		protected override void OnPause() {} // 0x000000018938A5FC-0x000000018938A638
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions with optional conditional requirement and in parallel to any other state, as soon as the FSM is started. All actions will prematurely be stoped as soon as the FSM stops as well. This is not a state.")]
	[Icon("Repeat", false, "")]
	[Name("Parallel", 0)]
	[Obsolete("Use On FSM Update node")]
	public class ConcurrentState : FSMNode, IUpdatable // TypeDefIndex: 48063
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
		[SerializeField]
		private bool _repeatStateActions; // 0xA8
		private bool done; // 0xA9
	
		// Properties
		public NodeCanvas.Framework.ConditionList conditionList { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public ActionList actionList { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public bool repeatStateActions { get => default; set {} } // 0x00000001811B9C10-0x00000001811B9C20 0x00000001811B9C20-0x00000001811B9C30
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public ConcurrentState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x0000000189378028-0x0000000189378174
		public override void OnGraphStarted() {} // 0x0000000189377F74-0x0000000189377FD4
		public override void OnGraphStoped() {} // 0x0000000189377FD4-0x0000000189378028
		public override void OnGraphPaused() {} // 0x00000001893769EC-0x0000000189376A10
		void IUpdatable.Update() {} // 0x0000000189377E68-0x0000000189377F74
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM enters/starts and when it exits/stops. This is not a state.")]
	[Icon("MacroIn", false, "")]
	[Name("Enter | Exit", 0)]
	[Obsolete("Use On FSM Enter and On FSM Exit nodes")]
	public class EnterExitState : FSMNode, IUpdatable // TypeDefIndex: 48064
	{
		// Fields
		[SerializeField]
		private ActionList _actionListEnter; // 0x98
		[SerializeField]
		private ActionList _actionListExit; // 0xA0
	
		// Properties
		public ActionList actionListEnter { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public ActionList actionListExit { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public EnterExitState() {} // 0x0000000185F46E3C-0x0000000185F46E44
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph) {} // 0x000000018937D354-0x000000018937D48C
		public override void OnGraphStarted() {} // 0x000000018937D258-0x000000018937D2C0
		public override void OnGraphStoped() {} // 0x000000018937D2C0-0x000000018937D354
		void IUpdatable.Update() {} // 0x000000018937D1EC-0x000000018937D258
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub FlowScript in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub FlowScript", -1)]
	public class ConcurrentSubFlowScript : FSMNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 48065
	{
		// Fields
		[ExposeField]
		[Name("Parallel FlowScript", 0)]
		[SerializeField]
		protected BBParameter<FlowScript> _subFlowScript; // 0xB0
	
		// Properties
		public override string name { get => default; } // 0x00000001893768E4-0x0000000189376908 
		public override int maxInConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int maxOutConnections { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool allowAsPrime { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override FlowScript subGraph { get => default; set {} } // 0x0000000189378444-0x000000018937848C 0x000000018937848C-0x00000001893784E4
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		public ConcurrentSubFlowScript() {} // 0x0000000189378410-0x0000000189378444
	
		// Methods
		public override void OnGraphStarted() {} // 0x0000000189378330-0x0000000189378410
		void IUpdatable.Update() {} // 0x0000000189378174-0x000000018937817C
	}

	[Description("Adds a FlowCanvas FlowScript as a nested State of the FSM. The FlowScript State is never finished by itself, unless a \'Finish\' node is used in the FlowScript. Success/Failure events can optionlay be used alongside with a CheckEvent on state transitions to catch whether the FlowScript Finished in success or failure.")]
	[DropReferenceType(typeof(FlowScript))]
	[Name("Sub FlowScript", 0)]
	public class FlowScriptState : FSMStateNested<FlowScript> // TypeDefIndex: 48066
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xB8
		[DimIfDefault]
		public string successEvent; // 0xC0
		[DimIfDefault]
		public string failureEvent; // 0xC8
	
		// Properties
		public override FlowScript subGraph { get => default; set {} } // 0x000000018937DCF8-0x000000018937DD40 0x000000018937DD40-0x000000018937DD98
		public override BBParameter subGraphParameter { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
	
		// Constructors
		public FlowScriptState() {} // 0x000000018937DCC4-0x000000018937DCF8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018937DA8C-0x000000018937DB68
		protected override void OnUpdate() {} // 0x000000018937DC70-0x000000018937DCC4
		private void OnFlowScriptFinished(bool success) {} // 0x000000018937DBF8-0x000000018937DC70
		protected override void OnExit() {} // 0x000000018937DB68-0x000000018937DBF8
	}
}

namespace NodeCanvas.Tasks.Actions
{
	[Category("Animation")]
	public class PlayAnimationAdvanced : ActionTask<UnityEngine.Animation> // TypeDefIndex: 47891
	{
		// Fields
		[RequiredField]
		public BBParameter<AnimationClip> animationClip; // 0x68
		public UnityEngine.WrapMode animationWrap; // 0x70
		public AnimationBlendMode blendMode; // 0x74
		[SliderField(0, 2)]
		public float playbackSpeed; // 0x78
		[SliderField(0, 1)]
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
		protected override string info { get => default; } // 0x00000001893704F4-0x000000018937054C 
	
		// Constructors
		public PlayAnimationAdvanced() {} // 0x0000000189370474-0x00000001893704F4
	
		// Methods
		protected override string OnInit() => default; // 0x00000001893702F4-0x00000001893703D8
		protected override void OnExecute() {} // 0x000000018936FE30-0x00000001893702F4
		protected override void OnUpdate() {} // 0x00000001893703D8-0x0000000189370474
		private Transform FindTransform(Transform parent, string name) => default; // 0x000000018936FD58-0x000000018936FE30
	}

	[Category("Animation")]
	public class PlayAnimationSimple : ActionTask<UnityEngine.Animation> // TypeDefIndex: 47892
	{
		// Fields
		[RequiredField]
		public BBParameter<AnimationClip> animationClip; // 0x68
		[SliderField(0, 1)]
		public float crossFadeTime; // 0x70
		public UnityEngine.WrapMode animationWrap; // 0x74
		public bool waitActionFinish; // 0x78
		private static Dictionary<UnityEngine.Animation, AnimationClip> lastPlayedClips; // 0x00
	
		// Properties
		protected override string info { get => default; } // 0x00000001893709CC-0x0000000189370A24 
	
		// Constructors
		public PlayAnimationSimple() {} // 0x0000000189370988-0x00000001893709CC
		static PlayAnimationSimple() {} // 0x00000001893708FC-0x0000000189370988
	
		// Methods
		protected override string OnInit() => default; // 0x0000000189370794-0x0000000189370878
		protected override void OnExecute() {} // 0x000000018937054C-0x0000000189370794
		protected override void OnUpdate() {} // 0x0000000189370878-0x00000001893708FC
	}

	[Category("Animator")]
	[Name("Play Animation", 0)]
	public class MecanimPlayAnimation : ActionTask<Animator> // TypeDefIndex: 47893
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[RequiredField]
		public BBParameter<string> stateName; // 0x70
		[SliderField(0, 1)]
		public float transitTime; // 0x78
		public bool waitUntilFinish; // 0x7C
		private AnimatorStateInfo stateInfo; // 0x80
		private bool played; // 0xB4
	
		// Properties
		protected override string info { get => default; } // 0x000000018936E24C-0x000000018936E2B4 
	
		// Constructors
		public MecanimPlayAnimation() {} // 0x000000018936E200-0x000000018936E24C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936DF0C-0x000000018936E074
		protected override void OnUpdate() {} // 0x000000018936E074-0x000000018936E200
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Bool", 0)]
	public class MecanimSetBool : ActionTask<Animator> // TypeDefIndex: 47894
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<bool> setTo; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018936E440-0x000000018936E4F0 
	
		// Constructors
		public MecanimSetBool() {} // 0x000000018936E404-0x000000018936E440
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936E2B4-0x000000018936E404
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Float", 0)]
	public class MecanimSetFloat : ActionTask<Animator> // TypeDefIndex: 47895
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<float> setTo; // 0x78
		[SliderField(0, 1)]
		public float transitTime; // 0x80
		private float currentValue; // 0x84
	
		// Properties
		protected override string info { get => default; } // 0x000000018936E864-0x000000018936E914 
	
		// Constructors
		public MecanimSetFloat() {} // 0x000000018936E814-0x000000018936E864
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936E5DC-0x000000018936E660
		protected override void OnUpdate() {} // 0x000000018936E660-0x000000018936E714
		private float Get() => default; // 0x000000018936E4F0-0x000000018936E5DC
		private void Set(float newValue) {} // 0x000000018936E714-0x000000018936E814
	}

	[Category("Animator")]
	[Name("Set IK", 0)]
	public class MecanimSetIK : ActionTask<Animator> // TypeDefIndex: 47896
	{
		// Fields
		public AvatarIKGoal IKGoal; // 0x68
		[RequiredField]
		public BBParameter<GameObject> goal; // 0x70
		public BBParameter<float> weight; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018936EBA8-0x000000018936EC64 
	
		// Constructors
		public MecanimSetIK() {} // 0x000000018936EB6C-0x000000018936EBA8
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936EA3C-0x000000018936EAD4
		protected override void OnStop() {} // 0x000000018936EAD4-0x000000018936EB6C
		private void OnAnimatorIK(EventData<int> msg) {} // 0x000000018936E914-0x000000018936EA3C
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Integer", 0)]
	public class MecanimSetInt : ActionTask<Animator> // TypeDefIndex: 47897
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<int> setTo; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018936EDE4-0x000000018936EE94 
	
		// Constructors
		public MecanimSetInt() {} // 0x000000018936EDA8-0x000000018936EDE4
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936EC64-0x000000018936EDA8
	}

	[Category("Animator")]
	[Name("Set Layer Weight", 0)]
	public class MecanimSetLayerWeight : ActionTask<Animator> // TypeDefIndex: 47898
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[SliderField(0, 1)]
		public BBParameter<float> layerWeight; // 0x70
		[SliderField(0, 1)]
		public float transitTime; // 0x78
		private float currentValue; // 0x7C
	
		// Properties
		protected override string info { get => default; } // 0x000000018936F078-0x000000018936F118 
	
		// Constructors
		public MecanimSetLayerWeight() {} // 0x000000018936F03C-0x000000018936F078
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936EE94-0x000000018936EF18
		protected override void OnUpdate() {} // 0x000000018936EF18-0x000000018936F03C
	}

	[Category("Animator")]
	[Name("Set Look At", 0)]
	public class MecanimSetLookAt : ActionTask<Animator> // TypeDefIndex: 47899
	{
		// Fields
		public BBParameter<GameObject> targetPosition; // 0x68
		public BBParameter<float> targetWeight; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936F39C-0x000000018936F3FC 
	
		// Constructors
		public MecanimSetLookAt() {} // 0x000000018936F360-0x000000018936F39C
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936F230-0x000000018936F2C8
		protected override void OnStop() {} // 0x000000018936F2C8-0x000000018936F360
		private void OnAnimatorIK(EventData<int> msg) {} // 0x000000018936F118-0x000000018936F230
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Trigger", 0)]
	public class MecanimSetTrigger : ActionTask<Animator> // TypeDefIndex: 47900
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936F530-0x000000018936F5DC 
	
		// Constructors
		public MecanimSetTrigger() {} // 0x000000018936F4F4-0x000000018936F530
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936F3FC-0x000000018936F4F4
	}

	[Category("Application")]
	public class LoadScene : ActionTask // TypeDefIndex: 47901
	{
		// Fields
		[RequiredField]
		public BBParameter<string> sceneName; // 0x68
		public BBParameter<LoadSceneMode> mode; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936DD18-0x000000018936DD58 
	
		// Constructors
		public LoadScene() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936DC68-0x000000018936DD18
	}

	[Category("Audio")]
	public class PlayAudioAtPosition : ActionTask<Transform> // TypeDefIndex: 47902
	{
		// Fields
		[RequiredField]
		public BBParameter<AudioClip> audioClip; // 0x68
		[SliderField(0, 1)]
		public float volume; // 0x70
		public bool waitActionFinish; // 0x74
	
		// Properties
		protected override string info { get => default; } // 0x0000000189370BAC-0x0000000189370C04 
	
		// Constructors
		public PlayAudioAtPosition() {} // 0x0000000189370B60-0x0000000189370BAC
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189370A24-0x0000000189370AE0
		protected override void OnUpdate() {} // 0x0000000189370AE0-0x0000000189370B60
	}

	[Category("\u272B Blackboard")]
	[Description("Create a new Vector out of 3 floats and save it to the blackboard")]
	public class ComposeVector : ActionTask // TypeDefIndex: 47903
	{
		// Fields
		public BBParameter<float> x; // 0x68
		public BBParameter<float> y; // 0x70
		public BBParameter<float> z; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018936163C-0x00000001893616A0 
	
		// Constructors
		public ComposeVector() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936155C-0x000000018936163C
	}

	[Category("\u272B Blackboard")]
	[Description("Create up to 3 floats from a Vector and save them to blackboard")]
	public class DecomposeVector : ActionTask // TypeDefIndex: 47904
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		[BlackboardOnly]
		public BBParameter<float> x; // 0x70
		[BlackboardOnly]
		public BBParameter<float> y; // 0x78
		[BlackboardOnly]
		public BBParameter<float> z; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x00000001893628CC-0x000000018936292C 
	
		// Constructors
		public DecomposeVector() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893627C4-0x00000001893628CC
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class AddElementToDictionary<T> : ActionTask // TypeDefIndex: 47905
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
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

	[Category("\u272B Blackboard/Dictionaries")]
	public class GetDictionaryElement<T> : ActionTask // TypeDefIndex: 47906
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		[BlackboardOnly]
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public GetDictionaryElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard")]
	public class EvaluateCurve : ActionTask // TypeDefIndex: 47907
	{
		// Fields
		[RequiredField]
		public BBParameter<AnimationCurve> curve; // 0x68
		public BBParameter<float> from; // 0x70
		public BBParameter<float> to; // 0x78
		public BBParameter<float> time; // 0x80
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x88
	
		// Constructors
		public EvaluateCurve() {} // 0x0000000189362BE4-0x0000000189362C60
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000189362A70-0x0000000189362BE4
	}

	[Category("\u272B Blackboard")]
	[Description("Stores the agent gameobject on the blackboard.")]
	public class GetSelf : ActionTask // TypeDefIndex: 47908
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x68
	
		// Constructors
		public GetSelf() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936B548-0x000000018936B5C4
	}

	[Category("\u272B Blackboard")]
	[Description("Use this to get a variable on any blackboard by overriding the agent")]
	public class GetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 47909
	{
		// Fields
		[RequiredField]
		public BBParameter<string> targetVariableName; // 0x68
		[BlackboardOnly]
		public BBObjectParameter saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936A890-0x000000018936A8D4 
	
		// Constructors
		public GetOtherBlackboardVariable() {} // 0x000000018936A854-0x000000018936A890
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936A788-0x000000018936A854
	}

	[Category("\u272B Blackboard")]
	[Name("Get Variable To String", 0)]
	public class GetToString : ActionTask // TypeDefIndex: 47910
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> variable; // 0x68
		[BlackboardOnly]
		public BBParameter<string> toString; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936B684-0x000000018936B6C8 
	
		// Constructors
		public GetToString() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936B5C4-0x000000018936B684
	}

	[Category("\u272B Blackboard/Lists")]
	public class AddElementToList<T> : ActionTask // TypeDefIndex: 47911
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public AddElementToList() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard/Lists")]
	public class ClearList : ActionTask // TypeDefIndex: 47912
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018936151C-0x000000018936155C 
	
		// Constructors
		public ClearList() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893614B8-0x000000018936151C
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Get the closer game object to the agent from within a list of game objects and save it in the blackboard.")]
	public class GetCloserGameObjectInList : ActionTask<Transform> // TypeDefIndex: 47913
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> list; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189368878-0x0000000189368918 
	
		// Constructors
		public GetCloserGameObjectInList() {} // 0x000000018936883C-0x0000000189368878
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936856C-0x000000018936883C
	}

	[Category("\u272B Blackboard/Lists")]
	public class GetIndexOfElement<T> : ActionTask // TypeDefIndex: 47914
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
		[BlackboardOnly]
		public BBParameter<int> saveIndexAs;
	
		// Constructors
		public GetIndexOfElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard/Lists")]
	public class GetListCount : ActionTask // TypeDefIndex: 47915
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
		[BlackboardOnly]
		public BBParameter<int> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936A5C8-0x000000018936A60C 
	
		// Constructors
		public GetListCount() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936A538-0x000000018936A5C8
	}

	[Category("\u272B Blackboard/Lists")]
	public class InsertElementToList<T> : ActionTask // TypeDefIndex: 47916
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
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

	[Category("\u272B Blackboard/Lists")]
	public class PickListElement<T> : ActionTask // TypeDefIndex: 47917
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		[BlackboardOnly]
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public PickListElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard/Lists")]
	public class PickRandomListElement<T> : ActionTask // TypeDefIndex: 47918
	{
		// Fields
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public PickRandomListElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Remove an element from the target list")]
	public class RemoveElementFromList<T> : ActionTask // TypeDefIndex: 47919
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public RemoveElementFromList() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard/Lists")]
	public class SetListElement<T> : ActionTask // TypeDefIndex: 47920
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		public BBParameter<T> newValue;
	
		// Constructors
		public SetListElement() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard/Lists")]
	public class ShuffleList : ActionTask // TypeDefIndex: 47921
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Constructors
		public ShuffleList() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018937492C-0x0000000189374A2C
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Will sort the gameobjects in the target list by their distance to the agent (closer first) and save that list to the blackboard")]
	public class SortGameObjectListByDistance : ActionTask<Transform> // TypeDefIndex: 47922
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<GameObject>> targetList; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
		public bool reverse; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189374C84-0x0000000189374D24 
	
		// Constructors
		public SortGameObjectListByDistance() {} // 0x0000000189374C48-0x0000000189374C84
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189374A2C-0x0000000189374B84
	}

	[Category("\u272B Blackboard")]
	[Description("Loads the blackboard variables previously saved in the provided PlayerPrefs key if at all. Returns false if no saves found or load was failed")]
	public class LoadBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 47923
	{
		// Fields
		[RequiredField]
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018936DC10-0x000000018936DC68 
	
		// Constructors
		public LoadBlackboard() {} // 0x000000018936DBD4-0x000000018936DC10
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936DB48-0x000000018936DBD4
	}

	[Category("\u272B Blackboard")]
	public class NormalizeVector : ActionTask // TypeDefIndex: 47924
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		public BBParameter<float> multiply; // 0x70
	
		// Constructors
		public NormalizeVector() {} // 0x000000018936FD04-0x000000018936FD58
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936FBF0-0x000000018936FD04
	}

	[Category("\u272B Blackboard")]
	public class SampleCurve : ActionTask // TypeDefIndex: 47925
	{
		// Fields
		[RequiredField]
		public BBParameter<AnimationCurve> curve; // 0x68
		[SliderField(0, 1)]
		public BBParameter<float> sampleAt; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x78
	
		// Constructors
		public SampleCurve() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189371640-0x0000000189371704
	}

	[Category("\u272B Blackboard")]
	[Description("Saves the blackboard variables in the provided key and to be loaded later on")]
	public class SaveBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 47926
	{
		// Fields
		[RequiredField]
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x00000001893717CC-0x0000000189371824 
	
		// Constructors
		public SaveBlackboard() {} // 0x0000000189371790-0x00000001893717CC
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189371704-0x0000000189371790
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard boolean variable")]
	public class SetBoolean : ActionTask // TypeDefIndex: 47928
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<bool> boolVariable; // 0x68
		public BoolSetModes setTo; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x00000001893723F0-0x00000001893724D4 
	
		// Nested types
		public enum BoolSetModes // TypeDefIndex: 47927
		{
			False = 0,
			True = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetBoolean() {} // 0x0000000183D71E40-0x0000000183D71E50
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189372358-0x00000001893723F0
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard boolean variable at random between min and max value")]
	public class SetBooleanRandom : ActionTask // TypeDefIndex: 47929
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> boolVariable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x00000001893722E4-0x0000000189372358 
	
		// Constructors
		public SetBooleanRandom() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189372270-0x00000001893722E4
	}

	[Category("\u272B Blackboard")]
	public class SetEnum : ActionTask // TypeDefIndex: 47930
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018937264C-0x00000001893726D4 
	
		// Constructors
		public SetEnum() {} // 0x0000000189372558-0x000000018937264C
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893724D4-0x0000000189372558
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard float variable")]
	public class SetFloat : ActionTask // TypeDefIndex: 47931
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<float> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189372EA8-0x0000000189372FD4 
	
		// Constructors
		public SetFloat() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189372DBC-0x0000000189372EA8
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard float variable at random between min and max value")]
	public class SetFloatRandom : ActionTask // TypeDefIndex: 47932
	{
		// Fields
		public BBParameter<float> minValue; // 0x68
		public BBParameter<float> maxValue; // 0x70
		[BlackboardOnly]
		public BBParameter<float> floatVariable; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189372C60-0x0000000189372DBC 
	
		// Constructors
		public SetFloatRandom() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189372BAC-0x0000000189372C60
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard integer variable")]
	[Name("Set Integer", 0)]
	public class SetInt : ActionTask // TypeDefIndex: 47933
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<int> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018937328C-0x0000000189373308 
	
		// Constructors
		public SetInt() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893731E0-0x000000018937328C
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard integer variable at random between min and max value")]
	[Name("Set Integer Random", 0)]
	public class SetIntRandom : ActionTask // TypeDefIndex: 47934
	{
		// Fields
		public BBParameter<int> minValue; // 0x68
		public BBParameter<int> maxValue; // 0x70
		[BlackboardOnly]
		public BBParameter<int> intVariable; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189373084-0x00000001893731E0 
	
		// Constructors
		public SetIntRandom() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189372FD4-0x0000000189373084
	}

	[Category("\u272B Blackboard")]
	[Description("Use this to set a variable on any blackboard by overriding the agent")]
	public class SetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 47935
	{
		// Fields
		[RequiredField]
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter newValue; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189373844-0x00000001893738E0 
	
		// Constructors
		public SetOtherBlackboardVariable() {} // 0x0000000189373808-0x0000000189373844
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189373748-0x0000000189373808
	}

	[Category("\u272B Blackboard")]
	public class SetVariable<T> : ActionTask // TypeDefIndex: 47936
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SetVariable() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard Vector3 variable")]
	public class SetVector3 : ActionTask // TypeDefIndex: 47937
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> valueA; // 0x68
		public OperationMethod operation; // 0x70
		public BBParameter<Vector3> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x00000001893742C8-0x00000001893743F4 
	
		// Constructors
		public SetVector3() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018937419C-0x00000001893742C8
	}

	[Category("\u272B Blackboard")]
	[Description("Triggers a boolean variable for 1 frame to True then back to False")]
	public class TriggerBoolean : ActionTask // TypeDefIndex: 47939
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<bool> variable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189375640-0x0000000189375680 
	
		// Constructors
		public TriggerBoolean() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893755AC-0x0000000189375640
		[IteratorStateMachine(typeof(_Flip_d__4))]
		private IEnumerator Flip() => default; // 0x0000000189375550-0x00000001893755AC
	}

	[Category("Camera")]
	public class FadeIn : ActionTask // TypeDefIndex: 47940
	{
		// Constructors
		public FadeIn() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	}

	[Category("Camera")]
	public class FadeOut : ActionTask // TypeDefIndex: 47941
	{
		// Constructors
		public FadeOut() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	}

	[Category("Dialogue")]
	[Description("You can use a variable inline with the text by using brackets likeso: [myVarName] or [Global/myVarName].\nThe bracket will be replaced with the variable value ToString")]
	[Icon("Dialogue", false, "")]
	public class Say : ActionTask<IDialogueActor> // TypeDefIndex: 47942
	{
		// Fields
		public Statement statement; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189371BA0-0x0000000189371C18 
	
		// Constructors
		public Say() {} // 0x0000000189371B14-0x0000000189371BA0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189371A08-0x0000000189371B14
	}

	[Category("Dialogue")]
	[Description("A random statement will be chosen each time for the actor to say")]
	[Icon("Dialogue", false, "")]
	public class SayRandom : ActionTask<IDialogueActor> // TypeDefIndex: 47943
	{
		// Fields
		public List<Statement> statements; // 0x68
	
		// Constructors
		public SayRandom() {} // 0x000000018937197C-0x0000000189371A08
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189371824-0x000000018937197C
	}

	[Category("Dialogue")]
	[Description("Starts the Dialogue Tree assigned on a Dialogue Tree Controller object with specified agent used for \'Instigator\'.")]
	[Icon("Dialogue", false, "")]
	public class StartDialogueTree : ActionTask<IDialogueActor> // TypeDefIndex: 47944
	{
		// Fields
		[RequiredField]
		public BBParameter<DialogueTreeController> dialogueTreeController; // 0x68
		public bool waitActionFinish; // 0x70
		public bool isPrefab; // 0x71
		private DialogueTreeController instance; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189374FF8-0x0000000189375038 
	
		// Constructors
		public StartDialogueTree() {} // 0x0000000189374FB4-0x0000000189374FF8
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189374D24-0x0000000189374ED0
	}

	[Category("GameObject")]
	public class CreateGameObject : ActionTask // TypeDefIndex: 47945
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x80
	
		// Constructors
		public CreateGameObject() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893616A0-0x0000000189361820
	}

	[Category("GameObject")]
	public class CreatePrimitive : ActionTask // TypeDefIndex: 47946
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		public BBParameter<PrimitiveType> type; // 0x80
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x88
	
		// Constructors
		public CreatePrimitive() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189361820-0x00000001893619B8
	}

	[Category("GameObject")]
	public class DestroyGameObject : ActionTask<Transform> // TypeDefIndex: 47947
	{
		// Fields
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189362A28-0x0000000189362A70 
	
		// Constructors
		public DestroyGameObject() {} // 0x00000001893629EC-0x0000000189362A28
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018936292C-0x00000001893629EC
	}

	[Category("GameObject")]
	[Description("Action will end in Failure if no objects are found")]
	public class FindAllWithLayer : ActionTask // TypeDefIndex: 47948
	{
		// Fields
		[RequiredField]
		public BBParameter<LayerMask> targetLayers; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189367100-0x00000001893671A0 
	
		// Constructors
		public FindAllWithLayer() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189367020-0x0000000189367100
	}

	[Category("GameObject")]
	[Description("Note that this is slow.\nAction will end in Failure if no objects are found")]
	public class FindAllWithName : ActionTask // TypeDefIndex: 47949
	{
		// Fields
		[RequiredField]
		public BBParameter<string> searchName; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189367388-0x0000000189367428 
	
		// Constructors
		public FindAllWithName() {} // 0x0000000189367328-0x0000000189367388
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893671A0-0x0000000189367328
	}

	[Category("GameObject")]
	[Description("Action will end in Failure if no objects are found")]
	public class FindAllWithTag : ActionTask // TypeDefIndex: 47950
	{
		// Fields
		[RequiredField]
		[TagField]
		public BBParameter<string> searchTag; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189367568-0x0000000189367608 
	
		// Constructors
		public FindAllWithTag() {} // 0x0000000189367508-0x0000000189367568
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189367428-0x0000000189367508
	}

	[Category("GameObject")]
	[Description("Find a transform child by name within the agent\'s transform")]
	public class FindChildByName : ActionTask<Transform> // TypeDefIndex: 47951
	{
		// Fields
		[RequiredField]
		public BBParameter<string> childName; // 0x68
		[BlackboardOnly]
		public BBParameter<Transform> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189367780-0x00000001893677E0 
	
		// Constructors
		public FindChildByName() {} // 0x0000000189367744-0x0000000189367780
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189367608-0x0000000189367744
	}

	[Category("GameObject")]
	[Description("Find the closest game object of tag to the agent")]
	public class FindClosestWithTag : ActionTask<Transform> // TypeDefIndex: 47952
	{
		// Fields
		[RequiredField]
		[TagField]
		public BBParameter<string> searchTag; // 0x68
		public BBParameter<bool> ignoreChildren; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x80
	
		// Constructors
		public FindClosestWithTag() {} // 0x0000000189367B78-0x0000000189367BB4
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893678AC-0x0000000189367B78
	}

	[Category("GameObject")]
	[Description("Note that this is very slow")]
	public class FindObjectOfType<T> : ActionTask // TypeDefIndex: 47953
		where T : Component
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> saveComponentAs;
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs;
	
		// Constructors
		public FindObjectOfType() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("GameObject")]
	[Description("Note that this is very slow")]
	public class FindObjectsOfType<T> : ActionTask // TypeDefIndex: 47955
		where T : Component
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveGameObjects;
		[BlackboardOnly]
		public BBParameter<List<T>> saveComponents;
	
		// Constructors
		public FindObjectsOfType() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("GameObject")]
	public class FindWithName : ActionTask // TypeDefIndex: 47956
	{
		// Fields
		[RequiredField]
		public BBParameter<string> gameObjectName; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189367C40-0x0000000189367CE0 
	
		// Constructors
		public FindWithName() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189367BB4-0x0000000189367C40
	}

	[Category("GameObject")]
	public class FindWithTag : ActionTask // TypeDefIndex: 47957
	{
		// Fields
		[RequiredField]
		[TagField]
		public string searchTag; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189367D94-0x0000000189367E20 
	
		// Constructors
		public FindWithTag() {} // 0x0000000189367D4C-0x0000000189367D94
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189367CE0-0x0000000189367D4C
	}

	[Category("GameObject")]
	public class GetAllChildGameObjects : ActionTask<Transform> // TypeDefIndex: 47959
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x68
		public bool recursive; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x00000001893684CC-0x000000018936856C 
	
		// Constructors
		public GetAllChildGameObjects() {} // 0x0000000189368490-0x00000001893684CC
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893680D0-0x0000000189368490
		private List<Transform> Get(Transform parent) => default; // 0x0000000189367EC0-0x00000001893680D0
	}

	[Category("GameObject")]
	public class GetComponent<T> : ActionTask<Transform> // TypeDefIndex: 47960
		where T : Component
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public GetComponent() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("GameObject")]
	public class GetDistance : ActionTask<Transform> // TypeDefIndex: 47961
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189368A7C-0x0000000189368AD4 
	
		// Constructors
		public GetDistance() {} // 0x0000000189368A40-0x0000000189368A7C
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189368918-0x0000000189368A40
	}

	[Category("GameObject")]
	[Obsolete("Use Get Property instead")]
	public class GetGameObjectPosition : ActionTask<Transform> // TypeDefIndex: 47962
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x00000001893690AC-0x0000000189369140 
	
		// Constructors
		public GetGameObjectPosition() {} // 0x0000000189369070-0x00000001893690AC
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189368FCC-0x0000000189369070
	}

	[Category("GameObject")]
	public class InstantiateGameObject : ActionTask<Transform> // TypeDefIndex: 47963
	{
		// Fields
		public BBParameter<Transform> parent; // 0x68
		public BBParameter<Vector3> clonePosition; // 0x70
		public BBParameter<Vector3> cloneRotation; // 0x78
		[BlackboardOnly]
		public BBParameter<GameObject> saveCloneAs; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018936CD00-0x000000018936CEE4 
	
		// Constructors
		public InstantiateGameObject() {} // 0x000000018936CCC4-0x000000018936CD00
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936CB00-0x000000018936CCC4
	}

	[Category("GameObject")]
	public class LookAt : ActionTask<Transform> // TypeDefIndex: 47964
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> lookTarget; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936DEAC-0x000000018936DF0C 
	
		// Constructors
		public LookAt() {} // 0x000000018936DE70-0x000000018936DEAC
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936DE68-0x000000018936DE70
		protected override void OnUpdate() {} // 0x000000018936DE68-0x000000018936DE70
		private void DoLook() {} // 0x000000018936DD58-0x000000018936DE68
	}

	[Category("GameObject")]
	public class RemoveComponent<T> : ActionTask<Transform> // TypeDefIndex: 47965
		where T : Component
	{
		// Fields
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public RemoveComponent() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("GameObject")]
	[Description("Set the gameobject active state.")]
	[Name("Set Active", 0)]
	public class SetObjectActive : ActionTask<Transform> // TypeDefIndex: 47967
	{
		// Fields
		public SetActiveMode setTo; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018937340C-0x0000000189373488 
	
		// Nested types
		public enum SetActiveMode // TypeDefIndex: 47966
		{
			Deactivate = 0,
			Activate = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectActive() {} // 0x00000001893733C0-0x000000018937340C
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189373308-0x00000001893733C0
	}

	[Category("GameObject")]
	[Description("Set the monobehaviour\'s enabled state.")]
	[Name("Set Enabled", 0)]
	public class SetObjectEnabled : ActionTask<MonoBehaviour> // TypeDefIndex: 47969
	{
		// Fields
		public SetEnableMode setTo; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018937356C-0x00000001893735E8 
	
		// Nested types
		public enum SetEnableMode // TypeDefIndex: 47968
		{
			Disable = 0,
			Enable = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectEnabled() {} // 0x0000000189373520-0x000000018937356C
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189373488-0x0000000189373520
	}

	[Category("GameObject")]
	[Description("Set the Renderer active state, thus making the object visible or invisible.")]
	[Name("Set Visibility", 0)]
	public class SetObjectVisibility : ActionTask<Renderer> // TypeDefIndex: 47971
	{
		// Fields
		public SetVisibleMode setTo; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x00000001893736CC-0x0000000189373748 
	
		// Nested types
		public enum SetVisibleMode // TypeDefIndex: 47970
		{
			Hide = 0,
			Show = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectVisibility() {} // 0x0000000189373680-0x00000001893736CC
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893735E8-0x0000000189373680
	}

	[Category("Input (Legacy System)")]
	public class GetInputAxis : ActionTask // TypeDefIndex: 47972
	{
		// Fields
		public BBParameter<string> xAxisName; // 0x68
		public BBParameter<string> yAxisName; // 0x70
		public BBParameter<string> zAxisName; // 0x78
		public BBParameter<float> multiplier; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x88
		[BlackboardOnly]
		public BBParameter<float> saveXAs; // 0x90
		[BlackboardOnly]
		public BBParameter<float> saveYAs; // 0x98
		[BlackboardOnly]
		public BBParameter<float> saveZAs; // 0xA0
		public bool repeat; // 0xA8
	
		// Constructors
		public GetInputAxis() {} // 0x0000000189369404-0x00000001893694C4
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893693FC-0x0000000189369404
		protected override void OnUpdate() {} // 0x00000001893693FC-0x0000000189369404
		private void Do() {} // 0x0000000189369140-0x00000001893693FC
	}

	[Category("Input (Legacy System)")]
	public class GetMousePosition : ActionTask // TypeDefIndex: 47973
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Constructors
		public GetMousePosition() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936A694-0x000000018936A69C
		protected override void OnUpdate() {} // 0x000000018936A694-0x000000018936A69C
		private void Do() {} // 0x000000018936A60C-0x000000018936A694
	}

	[Category("Input (Legacy System)")]
	public class GetMouseScrollDelta : ActionTask // TypeDefIndex: 47974
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018936A728-0x000000018936A788 
	
		// Constructors
		public GetMouseScrollDelta() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936A720-0x000000018936A728
		protected override void OnUpdate() {} // 0x000000018936A720-0x000000018936A728
		private void Do() {} // 0x000000018936A69C-0x000000018936A720
	}

	[Category("Input (Legacy System)")]
	public class WaitMousePick : ActionTask // TypeDefIndex: 47976
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		[BlackboardOnly]
		public BBParameter<GameObject> saveObjectAs; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> savePositionAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit hit; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x0000000189376278-0x00000001893762DC 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 47975
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick() {} // 0x0000000183D71E80-0x0000000183D71EA0
	
		// Methods
		protected override void OnUpdate() {} // 0x00000001893760BC-0x0000000189376278
	}

	[Category("Input (Legacy System)")]
	public class WaitMousePick2D : ActionTask // TypeDefIndex: 47978
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		[BlackboardOnly]
		public BBParameter<GameObject> saveObjectAs; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> savePositionAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit2D hit; // 0x8C
	
		// Properties
		protected override string info { get => default; } // 0x0000000189376058-0x00000001893760BC 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 47977
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick2D() {} // 0x0000000183D71E80-0x0000000183D71EA0
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000189375DE8-0x0000000189376058
	}

	[Category("Movement/Direct")]
	[Name("Curve Tween", 0)]
	public class CurveTransformTween : ActionTask<Transform> // TypeDefIndex: 47982
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
		public enum TransformMode // TypeDefIndex: 47979
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}
	
		public enum TweenMode // TypeDefIndex: 47980
		{
			Absolute = 0,
			Additive = 1
		}
	
		public enum PlayMode // TypeDefIndex: 47981
		{
			Normal = 0,
			PingPong = 1
		}
	
		// Constructors
		public CurveTransformTween() {} // 0x0000000189361E0C-0x0000000189361EBC
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893619B8-0x0000000189361BEC
		protected override void OnUpdate() {} // 0x0000000189361BEC-0x0000000189361E0C
	}

	[Category("Movement/Direct")]
	[Description("Move & turn the agent based on input values provided ranging from -1 to 1, per second (using delta time)")]
	public class InputMove : ActionTask<Transform> // TypeDefIndex: 47983
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> strafe; // 0x68
		[BlackboardOnly]
		public BBParameter<float> turn; // 0x70
		[BlackboardOnly]
		public BBParameter<float> forward; // 0x78
		[BlackboardOnly]
		public BBParameter<float> up; // 0x80
		public BBParameter<float> moveSpeed; // 0x88
		public BBParameter<float> rotationSpeed; // 0x90
		public bool repeat; // 0x98
	
		// Constructors
		public InputMove() {} // 0x000000018936CA74-0x000000018936CB00
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018936C530-0x000000018936CA74
	}

	[Category("Movement/Direct")]
	[Description("Moves the agent away from target per frame without pathfinding")]
	public class MoveAway : ActionTask<Transform> // TypeDefIndex: 47984
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveAway() {} // 0x000000018936F868-0x000000018936F8E8
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018936F5DC-0x000000018936F868
	}

	[Category("Movement/Direct")]
	[Description("Moves the agent towards to target per frame without pathfinding")]
	public class MoveTowards : ActionTask<Transform> // TypeDefIndex: 47985
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveTowards() {} // 0x000000018936FB70-0x000000018936FBF0
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018936F8E8-0x000000018936FB70
	}

	[Category("Movement/Direct")]
	[Description("Rotate the agent away from target per frame")]
	public class RotateAway : ActionTask<Transform> // TypeDefIndex: 47986
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		[SliderField(1, 180)]
		public BBParameter<float> angleDifference; // 0x78
		public BBParameter<Vector3> upVector; // 0x80
		public bool waitActionFinish; // 0x88
	
		// Constructors
		public RotateAway() {} // 0x000000018937113C-0x0000000189371200
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000189370D9C-0x000000018937113C
	}

	[Category("Movement/Direct")]
	[Description("Rotate the agent towards the target per frame")]
	public class RotateTowards : ActionTask<Transform> // TypeDefIndex: 47987
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		[SliderField(1, 180)]
		public BBParameter<float> angleDifference; // 0x78
		public BBParameter<Vector3> upVector; // 0x80
		public bool waitActionFinish; // 0x88
	
		// Constructors
		public RotateTowards() {} // 0x000000018937157C-0x0000000189371640
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000189371200-0x000000018937157C
	}

	[Category("Movement/Pathfinding")]
	[Description("Find the closes Navigation Mesh position to the target position")]
	[Name("Find Closest NavMesh Edge", 0)]
	public class FindClosestEdge : ActionTask // TypeDefIndex: 47988
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		[BlackboardOnly]
		public BBParameter<Vector3> saveFoundPosition; // 0x70
		private NavMeshHit hit; // 0x78
	
		// Constructors
		public FindClosestEdge() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x00000001893677E0-0x00000001893678AC
	}

	[Category("Physics")]
	public class GetLinecastInfo : ActionTask<Transform> // TypeDefIndex: 47989
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveHitGameObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> savePointAs; // 0x88
		[BlackboardOnly]
		public BBParameter<Vector3> saveNormalAs; // 0x90
		private RaycastHit hit; // 0x98
	
		// Constructors
		public GetLinecastInfo() {} // 0x000000018936A4DC-0x000000018936A538
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936A270-0x000000018936A4DC
		public override void OnDrawGizmosSelected() {} // 0x000000018936A110-0x000000018936A270
	}

	[Category("Physics")]
	public class GetLinecastInfo2D : ActionTask<Transform> // TypeDefIndex: 47990
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public LayerMask mask; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveHitGameObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> savePointAs; // 0x88
		[BlackboardOnly]
		public BBParameter<Vector3> saveNormalAs; // 0x90
		private RaycastHit2D hit; // 0x98
	
		// Constructors
		public GetLinecastInfo2D() {} // 0x000000018936A0C4-0x000000018936A110
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189369DE4-0x000000018936A0C4
		public override void OnDrawGizmosSelected() {} // 0x0000000189369C84-0x0000000189369DE4
	}

	[Category("Physics")]
	[Description("Get hit info for ALL objects in the linecast, in Lists")]
	public class GetLinecastInfo2DAll : ActionTask<Transform> // TypeDefIndex: 47992
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public LayerMask mask; // 0x70
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveHitGameObjectsAs; // 0x78
		[BlackboardOnly]
		public BBParameter<List<float>> saveDistancesAs; // 0x80
		[BlackboardOnly]
		public BBParameter<List<Vector3>> savePointsAs; // 0x88
		[BlackboardOnly]
		public BBParameter<List<Vector3>> saveNormalsAs; // 0x90
		private RaycastHit2D[] hits; // 0x98
	
		// Constructors
		public GetLinecastInfo2DAll() {} // 0x0000000189369C38-0x0000000189369C84
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189369624-0x0000000189369B80
		public override void OnDrawGizmosSelected() {} // 0x00000001893694C4-0x0000000189369624
	}

	[Category("Physics")]
	[Description("Gets a lists of game objects that are in the physics overlap sphere at the position of the agent, excluding the agent")]
	public class GetOverlapSphereObjects : ActionTask<Transform> // TypeDefIndex: 47994
	{
		// Fields
		public LayerMask layerMask; // 0x68
		public BBParameter<float> radius; // 0x70
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveObjectsAs; // 0x78
	
		// Constructors
		public GetOverlapSphereObjects() {} // 0x000000018936AC74-0x000000018936ACD8
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936A9D8-0x000000018936AC74
		public override void OnDrawGizmosSelected() {} // 0x000000018936A8D4-0x000000018936A9D8
	}

	[Category("\u272B Reflected")]
	[Description("Execute a function on a script and save the return if any.\nIf function is an IEnumerator it will execute as a coroutine.")]
	[Name("Execute Function", 10)]
	public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 47996
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected List<BBObjectParameter> parameters; // 0x70
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter returnValue; // 0x78
		private object[] args; // 0x80
		private bool routineRunning; // 0x88
		private bool[] parameterIsByRef; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		public override System.Type agentType { get => default; } // 0x00000001893634EC-0x00000001893635B0 
		protected override string info { get => default; } // 0x00000001893635B0-0x0000000189363930 
	
		// Constructors
		public ExecuteFunction_Multiplatform() {} // 0x000000018936346C-0x00000001893634EC
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189363168-0x0000000189363190
		protected override string OnInit() => default; // 0x0000000189362FE0-0x0000000189363168
		protected override void OnExecute() {} // 0x0000000189362D48-0x0000000189362FE0
		protected override void OnStop() {} // 0x0000000183D71DF0-0x0000000183D71E00
		[IteratorStateMachine(typeof(_InternalCoroutine_d__17))]
		private IEnumerator InternalCoroutine(IEnumerator routine) => default; // 0x0000000189362CD4-0x0000000189362D48
		private void SetMethod(MethodInfo method) {} // 0x0000000189363190-0x000000018936346C
	}

	internal class GetField_0 // TypeDefIndex: 47997
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string fieldName; // 0x18
	
		// Constructors
		public GetField_0() {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("\u272B Reflected")]
	[Description("Get a variable of a script and save it to the blackboard")]
	[fsMigrateVersions(new System.Type[1] {typeof(GetField_0) })]
	[Name("Get Field", 6)]
	public class GetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.GetField_0> // TypeDefIndex: 47998
	{
		// Fields
		[SerializeField]
		protected SerializedFieldInfo field; // 0x68
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter saveAs; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get => default; } // 0x0000000187D168B4-0x0000000187D168C4 
		public override System.Type agentType { get => default; } // 0x0000000189368D8C-0x0000000189368E5C 
		protected override string info { get => default; } // 0x0000000189368E5C-0x0000000189368FCC 
	
		// Constructors
		public GetField() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		void IMigratable<GetField_0>.Migrate(GetField_0 model) {} // 0x0000000189368C24-0x0000000189368CDC
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		protected override string OnInit() => default; // 0x0000000189368B8C-0x0000000189368C24
		protected override void OnExecute() {} // 0x0000000189368AD4-0x0000000189368B8C
		private void SetTargetField(System.Reflection.FieldInfo newField) {} // 0x0000000189368CDC-0x0000000189368D8C
	}

	[Category("\u272B Reflected")]
	[Description("Get a property of a script and save it to the blackboard")]
	[Name("Get Property", 8)]
	public class GetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 47999
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter returnValue; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		public override System.Type agentType { get => default; } // 0x000000018936AEF4-0x000000018936AFB8 
		protected override string info { get => default; } // 0x000000018936AFB8-0x000000018936B11C 
	
		// Constructors
		public GetProperty_Multiplatform() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018936AE1C-0x000000018936AE44
		protected override string OnInit() => default; // 0x000000018936AD94-0x000000018936AE1C
		protected override void OnExecute() {} // 0x000000018936ACD8-0x000000018936AD94
		private void SetMethod(MethodInfo method) {} // 0x000000018936AE44-0x000000018936AEF4
	}

	[Category("\u272B Reflected")]
	[Description("Calls a function that has signature of \'public Status NAME()\' or \'public Status NAME(T)\'. You should return Status.Success, Failure or Running within that function.")]
	[Name("Implemented Action", 9)]
	public class ImplementedAction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 48000
	{
		// Fields
		[SerializeField]
		private SerializedMethodInfo method; // 0x68
		[SerializeField]
		private List<BBObjectParameter> parameters; // 0x70
		private NodeCanvas.Framework.Status actionStatus; // 0x78
		private object[] args; // 0x80
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		public override System.Type agentType { get => default; } // 0x000000018936BEA4-0x000000018936BF68 
		protected override string info { get => default; } // 0x000000018936BF68-0x000000018936C120 
	
		// Constructors
		public ImplementedAction_Multiplatform() {} // 0x000000018936BE20-0x000000018936BEA4
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018936BC80-0x000000018936BCA8
		protected override string OnInit() => default; // 0x000000018936BA38-0x000000018936BB1C
		protected override void OnUpdate() {} // 0x000000018936BB1C-0x000000018936BC80
		protected override void OnStop() {} // 0x0000000183D71E10-0x0000000183D71E20
		private void SetMethod(MethodInfo method) {} // 0x000000018936BCA8-0x000000018936BE20
	}

	[Category("\u272B Reflected")]
	[Description("SendMessage to the agent, optionaly with an argument")]
	public class SendMessage : ActionTask<Transform> // TypeDefIndex: 48001
	{
		// Fields
		[RequiredField]
		public BBParameter<string> methodName; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189372230-0x0000000189372270 
	
		// Constructors
		public SendMessage() {} // 0x00000001893721F4-0x0000000189372230
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189372168-0x00000001893721F4
	}

	[Category("\u272B Reflected")]
	[Description("SendMessage to the agent, optionaly with an argument")]
	public class SendMessage<T> : ActionTask<Transform> // TypeDefIndex: 48002
	{
		// Fields
		[RequiredField]
		public BBParameter<string> methodName;
		public BBParameter<T> argument;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendMessage() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Reflected")]
	[Description("Send a Unity message to all game objects with a component of the specified type.\nNotice: This is slow and should not be called per-fame.")]
	public class SendMessageToType<T> : ActionTask // TypeDefIndex: 48003
		where T : Component
	{
		// Fields
		[RequiredField]
		public BBParameter<string> message;
		[BlackboardOnly]
		public BBParameter<object> argument;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendMessageToType() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	internal class SetField_0 // TypeDefIndex: 48004
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string fieldName; // 0x18
	
		// Constructors
		public SetField_0() {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("\u272B Reflected")]
	[Description("Set a variable on a script")]
	[fsMigrateVersions(new System.Type[1] {typeof(SetField_0) })]
	[Name("Set Field", 5)]
	public class SetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.SetField_0> // TypeDefIndex: 48005
	{
		// Fields
		[SerializeField]
		protected SerializedFieldInfo field; // 0x68
		[SerializeField]
		protected BBObjectParameter setValue; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get => default; } // 0x0000000187D168B4-0x0000000187D168C4 
		public override System.Type agentType { get => default; } // 0x000000018937298C-0x0000000189372A5C 
		protected override string info { get => default; } // 0x0000000189372A5C-0x0000000189372BAC 
	
		// Constructors
		public SetField() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		void IMigratable<SetField_0>.Migrate(SetField_0 model) {} // 0x0000000189372824-0x00000001893728DC
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		protected override string OnInit() => default; // 0x000000018937278C-0x0000000189372824
		protected override void OnExecute() {} // 0x00000001893726D4-0x000000018937278C
		private void SetTargetField(System.Reflection.FieldInfo newField) {} // 0x00000001893728DC-0x000000018937298C
	}

	[Category("\u272B Reflected")]
	[Description("Set a property on a script")]
	[Name("Set Property", 7)]
	public class SetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 48006
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected BBObjectParameter parameter; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		public override System.Type agentType { get => default; } // 0x0000000189373B48-0x0000000189373C0C 
		protected override string info { get => default; } // 0x0000000189373C0C-0x0000000189373D70 
	
		// Constructors
		public SetProperty_Multiplatform() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189373A54-0x0000000189373A7C
		protected override string OnInit() => default; // 0x00000001893739CC-0x0000000189373A54
		protected override void OnExecute() {} // 0x00000001893738E0-0x00000001893739CC
		private void SetMethod(MethodInfo method) {} // 0x0000000189373A7C-0x0000000189373B48
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nExecute a function on a script, of up to 6 parameters and save the return if any. If function is an IEnumerator it will execute as a coroutine.")]
	[Name("Execute Function (Desktop Only)", 10)]
	public class ExecuteFunction : ActionTask, IReflectedWrapper // TypeDefIndex: 48008
	{
		// Fields
		[SerializeField]
		protected ReflectedWrapper functionWrapper; // 0x68
		private bool routineRunning; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		public override System.Type agentType { get => default; } // 0x0000000189363D3C-0x0000000189363E00 
		protected override string info { get => default; } // 0x0000000189363E00-0x0000000189364258 
	
		// Constructors
		public ExecuteFunction() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000189363930-0x0000000189363940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189363C9C-0x0000000189363CE8
		protected override string OnInit() => default; // 0x0000000189363B40-0x0000000189363C9C
		protected override void OnExecute() {} // 0x0000000189363940-0x0000000189363B40
		protected override void OnStop() {} // 0x0000000183D71970-0x0000000183D71980
		[IteratorStateMachine(typeof(_InternalCoroutine_d__13))]
		private IEnumerator InternalCoroutine(IEnumerator routine) => default; // 0x0000000189362C60-0x0000000189362CD4
		private void SetMethod(MethodInfo method) {} // 0x0000000189363CE8-0x0000000189363D3C
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nGet a property of a script and save it to the blackboard")]
	[Name("Get Property (Desktop Only)", 8)]
	public class GetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 48009
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		public override System.Type agentType { get => default; } // 0x000000018936B314-0x000000018936B3D8 
		protected override string info { get => default; } // 0x000000018936B3D8-0x000000018936B548 
	
		// Constructors
		public GetProperty() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000189363930-0x0000000189363940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018936B274-0x000000018936B2C0
		protected override string OnInit() => default; // 0x000000018936B158-0x000000018936B274
		protected override void OnExecute() {} // 0x000000018936B11C-0x000000018936B158
		private void SetMethod(MethodInfo method) {} // 0x000000018936B2C0-0x000000018936B314
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCalls a function that has signature of \'public Status NAME()\' or \'public Status NAME(T)\'. You should return Status.Success, Failure or Running within that function.")]
	[Name("Implemented Action (Desktop Only)", 9)]
	public class ImplementedAction : ActionTask, IReflectedWrapper // TypeDefIndex: 48010
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		private NodeCanvas.Framework.Status actionStatus; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		public override System.Type agentType { get => default; } // 0x000000018936C2AC-0x000000018936C370 
		protected override string info { get => default; } // 0x000000018936C370-0x000000018936C530 
	
		// Constructors
		public ImplementedAction() {} // 0x0000000183D71E30-0x0000000183D71E40
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000189363930-0x0000000189363940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x000000018936B274-0x000000018936B2C0
		protected override string OnInit() => default; // 0x000000018936C120-0x000000018936C23C
		protected override void OnUpdate() {} // 0x000000018936C23C-0x000000018936C2AC
		protected override void OnStop() {} // 0x0000000183D71E20-0x0000000183D71E30
		private void SetMethod(MethodInfo method) {} // 0x000000018936B2C0-0x000000018936B314
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nSet a property on a script.")]
	[Name("Set Property (Desktop Only)", 7)]
	public class SetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 48011
	{
		// Fields
		[SerializeField]
		protected ReflectedActionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		public override System.Type agentType { get => default; } // 0x0000000189373F68-0x000000018937402C 
		protected override string info { get => default; } // 0x000000018937402C-0x000000018937419C 
	
		// Constructors
		public SetProperty() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000189363930-0x0000000189363940
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189373EC8-0x0000000189373F14
		protected override string OnInit() => default; // 0x0000000189373DAC-0x0000000189373EC8
		protected override void OnExecute() {} // 0x0000000189373D70-0x0000000189373DAC
		private void SetMethod(MethodInfo method) {} // 0x0000000189373F14-0x0000000189373F68
	}

	[Category("\u272B Utility")]
	[Description("Plays a \'Beep\' in editor only")]
	public class DebugBeep : ActionTask // TypeDefIndex: 48012
	{
		// Constructors
		public DebugBeep() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189361EBC-0x0000000189361EC8
	}

	[Category("\u272B Utility")]
	public class DebugDrawLine : ActionTask // TypeDefIndex: 48013
	{
		// Fields
		public BBParameter<Vector3> from; // 0x68
		public BBParameter<Vector3> to; // 0x70
		public UnityEngine.Color color; // 0x78
		public float timeToShow; // 0x88
	
		// Constructors
		public DebugDrawLine() {} // 0x0000000189361FD0-0x0000000189362000
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189361EC8-0x0000000189361FD0
	}

	[Category("\u272B Utility")]
	[Description("Display a UI label on the agent\'s position if seconds to run is not 0 and also logs the message, which can also be mapped to any variable.")]
	[Name("Debug Log", 0)]
	public class DebugLogText : ActionTask<Transform> // TypeDefIndex: 48016
	{
		// Fields
		[RequiredField]
		public BBParameter<string> log; // 0x68
		public float labelYOffset; // 0x70
		public float secondsToRun; // 0x74
		public VerboseMode verboseMode; // 0x78
		public LogMode logMode; // 0x7C
		public CompactStatus finishStatus; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x00000001893625D0-0x00000001893626A0 
	
		// Nested types
		public enum LogMode // TypeDefIndex: 48014
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}
	
		public enum VerboseMode // TypeDefIndex: 48015
		{
			LogAndDisplayLabel = 0,
			LogOnly = 1,
			DisplayLabelOnly = 2
		}
	
		// Constructors
		public DebugLogText() {} // 0x0000000189362554-0x00000001893625D0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189362000-0x0000000189362148
		protected override void OnStop() {} // 0x0000000189362470-0x0000000189362520
		protected override void OnUpdate() {} // 0x0000000189362520-0x0000000189362554
		private void OnGUI() {} // 0x0000000189362148-0x0000000189362470
	}

	[Category("\u272B Utility")]
	[Description("Logs the value of a variable in the console")]
	[Obsolete("Use Debug Log Text")]
	public class DebugLogVariable : ActionTask // TypeDefIndex: 48017
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> log; // 0x68
		public BBParameter<string> prefix; // 0x70
		public float secondsToRun; // 0x78
		public CompactStatus finishStatus; // 0x7C
	
		// Properties
		protected override string info { get => default; } // 0x00000001893626D0-0x00000001893627C4 
	
		// Constructors
		public DebugLogVariable() {} // 0x0000000183D71DD0-0x0000000183D71DF0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnUpdate() {} // 0x00000001893626A0-0x00000001893626D0
	}

	[Category("\u272B Utility")]
	[Description("Force Finish the current graph this Task is assigned to.")]
	public class ForceFinishGraph : ActionTask // TypeDefIndex: 48018
	{
		// Fields
		public CompactStatus finishStatus; // 0x68
	
		// Constructors
		public ForceFinishGraph() {} // 0x0000000183D71E00-0x0000000183D71E10
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189367E20-0x0000000189367EC0
	}

	[Category("\u272B Utility")]
	[Description("Start, Resume, Pause, Stop a GraphOwner\'s behaviour")]
	[Name("Control Graph Owner", 0)]
	public class GraphOwnerControl : ActionTask<GraphOwner> // TypeDefIndex: 48021
	{
		// Fields
		public Control control; // 0x68
		public bool waitActionFinish; // 0x6C
	
		// Properties
		protected override string info { get => default; } // 0x000000018936B9B0-0x000000018936BA38 
	
		// Nested types
		public enum Control // TypeDefIndex: 48019
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		// Constructors
		public GraphOwnerControl() {} // 0x000000018936B96C-0x000000018936B9B0
	
		// Methods
		protected override void OnExecute() {} // 0x000000018936B76C-0x000000018936B8A8
		[IteratorStateMachine(typeof(_YieldDo_d__6))]
		private IEnumerator YieldDo() => default; // 0x000000018936B910-0x000000018936B96C
		private void Do() {} // 0x000000018936B6C8-0x000000018936B76C
		protected override void OnStop() {} // 0x000000018936B8A8-0x000000018936B908
	}

	[Category("\u272B Utility")]
	[Description("An action that will simply run forever and never finish")]
	public class RunForever : ActionTask // TypeDefIndex: 48022
	{
		// Constructors
		public RunForever() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	}

	[Category("\u272B Utility")]
	[Description("Send a graph event. If global is true, all graph owners in scene will receive this event. Use along with the \'Check Event\' Condition")]
	public class SendEvent : ActionTask<GraphOwner> // TypeDefIndex: 48023
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> delay; // 0x70
		public bool sendGlobal; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189371FD4-0x0000000189372168 
	
		// Constructors
		public SendEvent() {} // 0x0000000189371F98-0x0000000189371FD4
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000189371E74-0x0000000189371F98
	}

	[Category("\u272B Utility")]
	[Description("Send a graph event with T value. If global is true, all graph owners in scene will receive this event. Use along with the \'Check Event\' Condition")]
	public class SendEvent<T> : ActionTask<GraphOwner> // TypeDefIndex: 48024
	{
		// Fields
		[RequiredField]
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

	[Category("\u272B Utility")]
	[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
	public class SendEventToObjects : ActionTask // TypeDefIndex: 48025
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		[RequiredField]
		public BBParameter<string> eventName; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189371E30-0x0000000189371E74 
	
		// Constructors
		public SendEventToObjects() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189371C18-0x0000000189371E30
	}

	[Category("\u272B Utility")]
	[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
	public class SendEventToObjects<T> : ActionTask // TypeDefIndex: 48026
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> targetObjects;
		[RequiredField]
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public SendEventToObjects() {}
	
		// Methods
		protected override void OnExecute() {}
	}

	[Category("\u272B Utility")]
	[Description("Sends an event to all GraphOwners within range of the agent and over time like a shockwave.")]
	public class ShoutEvent : ActionTask<Transform> // TypeDefIndex: 48027
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> shoutRange; // 0x70
		public BBParameter<float> completionTime; // 0x78
		private GraphOwner[] owners; // 0x80
		private bool[] receivedOwners; // 0x88
		private float traveledDistance; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x00000001893748D4-0x000000018937492C 
	
		// Constructors
		public ShoutEvent() {} // 0x0000000189374854-0x00000001893748D4
	
		// Methods
		protected override void OnExecute() {} // 0x000000018937454C-0x00000001893745F0
		protected override void OnUpdate() {} // 0x00000001893745F0-0x0000000189374854
		public override void OnDrawGizmosSelected() {} // 0x00000001893743F4-0x000000018937454C
	}

	[Category("\u272B Utility")]
	[Description("Switch the entire Behaviour Tree of BehaviourTreeOwner")]
	public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner> // TypeDefIndex: 48028
	{
		// Fields
		[RequiredField]
		public BBParameter<BehaviourTree> behaviourTree; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189375110-0x0000000189375150 
	
		// Constructors
		public SwitchBehaviourTree() {} // 0x00000001893750D4-0x0000000189375110
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189375038-0x00000001893750D4
	}

	[Category("\u272B Utility")]
	[Description("Switch the entire FSM of FSMTreeOwner")]
	public class SwitchFSM : ActionTask<FSMOwner> // TypeDefIndex: 48029
	{
		// Fields
		[RequiredField]
		public BBParameter<FSM> fsm; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189375228-0x0000000189375268 
	
		// Constructors
		public SwitchFSM() {} // 0x00000001893751EC-0x0000000189375228
	
		// Methods
		protected override void OnExecute() {} // 0x0000000189375150-0x00000001893751EC
	}

	[Category("\u272B Utility")]
	public class Wait : ActionTask // TypeDefIndex: 48030
	{
		// Fields
		public BBParameter<float> waitTime; // 0x68
		public CompactStatus finishStatus; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x00000001893763AC-0x00000001893766D4 
	
		// Constructors
		public Wait() {} // 0x0000000189376350-0x00000001893763AC
	
		// Methods
		protected override void OnUpdate() {} // 0x00000001893762DC-0x0000000189376350
	}

	[Category("GameObject")]
	[Description("Checks the current speed of the agent against a value based on it\'s Rigidbody velocity")]
	public class CheckSpeed : ConditionTask<Rigidbody> // TypeDefIndex: 48031
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<float> value; // 0x70
		[SliderField(0f, 0.1f)]
		public float differenceThreshold; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189360EBC-0x0000000189360F38 
	
		// Constructors
		public CheckSpeed() {} // 0x0000000189360E70-0x0000000189360EBC
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189360DB8-0x0000000189360E70
	}

	[Obsolete("Execute Function now supports static functions as well")]
	public class ExecuteStaticFunction : ActionTask, ISubParametersContainer // TypeDefIndex: 48032
	{
		// Fields
		[SerializeField]
		protected ReflectedWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		protected override string info { get => default; } // 0x0000000189364C78-0x0000000189365010 
	
		// Constructors
		public ExecuteStaticFunction() {} // 0x0000000183D56BE0-0x0000000183D56BF0
	
		// Methods
		BBParameter[] ISubParametersContainer.GetSubParameters() => default; // 0x0000000189364A94-0x0000000189364AB4
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189363C9C-0x0000000189363CE8
		protected override string OnInit() => default; // 0x0000000189364B98-0x0000000189364C78
		protected override void OnExecute() {} // 0x0000000189364AB4-0x0000000189364B98
		private void SetMethod(MethodInfo method) {} // 0x0000000189363CE8-0x0000000189363D3C
	}

	[Obsolete("Execute Function now supports static functions as well")]
	public class ExecuteStaticFunction_Multiplatform : ActionTask // TypeDefIndex: 48034
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected List<BBObjectParameter> parameters; // 0x70
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter returnValue; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		protected override string info { get => default; } // 0x0000000189364780-0x0000000189364A94 
	
		// Constructors
		public ExecuteStaticFunction_Multiplatform() {} // 0x0000000189364700-0x0000000189364780
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189364478-0x00000001893644A0
		protected override string OnInit() => default; // 0x00000001893643F0-0x0000000189364478
		protected override void OnExecute() {} // 0x0000000189364258-0x00000001893643F0
		private void SetMethod(MethodInfo method) {} // 0x00000001893644A0-0x0000000189364700
	}
}

namespace NodeCanvas.Tasks.Conditions
{
	[Category("\u272B Utility")]
	[Description("Invoke a defined Signal with agent as the target and optionally global.")]
	public class InvokeSignal : ActionTask<Transform> // TypeDefIndex: 47809
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		public bool global; // 0x70
		[SerializeField]
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x78
		private object[] args; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189359758-0x000000018935977C 
	
		// Constructors
		public InvokeSignal() {} // 0x00000001893596CC-0x0000000189359758
	
		// Methods
		protected override string OnInit() => default; // 0x0000000189359634-0x00000001893596CC
		protected override void OnExecute() {} // 0x0000000189359480-0x0000000189359634
	}

	[Category("Animator")]
	[Name("Check Parameter Bool", 0)]
	public class MecanimCheckBool : ConditionTask<Animator> // TypeDefIndex: 47810
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public BBParameter<bool> value; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018935BF78-0x000000018935C01C 
	
		// Constructors
		public MecanimCheckBool() {} // 0x000000018935BF3C-0x000000018935BF78
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935BE90-0x000000018935BF3C
	}

	[Category("Animator")]
	[Name("Check Parameter Float", 0)]
	public class MecanimCheckFloat : ConditionTask<Animator> // TypeDefIndex: 47811
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<float> value; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018935C124-0x000000018935C1C0 
	
		// Constructors
		public MecanimCheckFloat() {} // 0x000000018935C0E8-0x000000018935C124
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935C01C-0x000000018935C0E8
	}

	[Category("Animator")]
	[Name("Check Parameter Int", 0)]
	public class MecanimCheckInt : ConditionTask<Animator> // TypeDefIndex: 47812
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<int> value; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x000000018935C2B0-0x000000018935C34C 
	
		// Constructors
		public MecanimCheckInt() {} // 0x000000018935C274-0x000000018935C2B0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935C1C0-0x000000018935C274
	}

	[Category("Animator")]
	[Name("Is In Transition", 0)]
	public class MecanimIsInTransition : ConditionTask<Animator> // TypeDefIndex: 47813
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018935C408-0x000000018935C434 
	
		// Constructors
		public MecanimIsInTransition() {} // 0x000000018935C3CC-0x000000018935C408
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935C34C-0x000000018935C3CC
	}

	[Category("\u272B Blackboard")]
	public class CheckBoolean : ConditionTask // TypeDefIndex: 47814
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> valueA; // 0x68
		public BBParameter<bool> valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018934E9FC-0x000000018934EA84 
	
		// Constructors
		public CheckBoolean() {} // 0x000000018934E9AC-0x000000018934E9FC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934E940-0x000000018934E9AC
	}

	[Category("\u272B Blackboard")]
	[Description("Check if a boolean variable is true and if so, it is immediately reset to false.")]
	public class CheckBooleanTrigger : ConditionTask // TypeDefIndex: 47815
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> trigger; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018934E900-0x000000018934E940 
	
		// Constructors
		public CheckBooleanTrigger() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934E88C-0x000000018934E900
	}

	[Category("\u272B Blackboard")]
	public class CheckEnum : ConditionTask // TypeDefIndex: 47816
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189352218-0x00000001893522A0 
	
		// Constructors
		public CheckEnum() {} // 0x0000000189352128-0x0000000189352218
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001893520B4-0x0000000189352128
	}

	[Category("\u272B Blackboard")]
	public class CheckFloat : ConditionTask // TypeDefIndex: 47817
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> valueB; // 0x78
		[SliderField(0f, 0.1f)]
		public float differenceThreshold; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189352C50-0x0000000189352CCC 
	
		// Constructors
		public CheckFloat() {} // 0x0000000183D71C50-0x0000000183D71C70
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189352BC8-0x0000000189352C50
	}

	[Category("\u272B Blackboard")]
	public class CheckInt : ConditionTask // TypeDefIndex: 47818
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<int> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189352C50-0x0000000189352CCC 
	
		// Constructors
		public CheckInt() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935403C-0x00000001893540B4
	}

	[Category("\u272B Blackboard")]
	[Description("Check whether or not a variable is null")]
	public class CheckNull : ConditionTask // TypeDefIndex: 47819
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> variable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189355FA0-0x0000000189355FFC 
	
		// Constructors
		public CheckNull() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189355F54-0x0000000189355FA0
	}

	[Category("\u272B Blackboard")]
	public class CheckString : ConditionTask // TypeDefIndex: 47820
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<string> valueA; // 0x68
		public BBParameter<string> valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189356C00-0x0000000189356C88 
	
		// Constructors
		public CheckString() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189356B8C-0x0000000189356C00
	}

	[Category("\u272B Blackboard")]
	[Obsolete("Use CheckVariable(T)")]
	public class CheckUnityObject : ConditionTask // TypeDefIndex: 47821
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<UnityEngine.Object> valueA; // 0x68
		public BBParameter<UnityEngine.Object> valueB; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189358058-0x00000001893580E0 
	
		// Constructors
		public CheckUnityObject() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189357FC8-0x0000000189358058
	}

	[Category("\u272B Blackboard")]
	[Description("It\'s best to use the respective Condition for a type if existant since they support operations as well")]
	public class CheckVariable<T> : ConditionTask // TypeDefIndex: 47822
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public CheckVariable() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	[Category("\u272B Blackboard")]
	public class CheckVectorDistance : ConditionTask // TypeDefIndex: 47823
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> vectorA; // 0x68
		[BlackboardOnly]
		public BBParameter<Vector3> vectorB; // 0x70
		public CompareMethod comparison; // 0x78
		public BBParameter<float> distance; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x00000001893581D0-0x00000001893582D0 
	
		// Constructors
		public CheckVectorDistance() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001893580E0-0x00000001893581D0
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class TryGetValue<T> : ConditionTask // TypeDefIndex: 47824
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<Dictionary<string, T>> targetDictionary;
		[RequiredField]
		public BBParameter<string> key;
		[BlackboardOnly]
		public BBParameter<T> saveValueAs;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public TryGetValue() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Check if an element is contained in the target list")]
	public class ListContainsElement<T> : ConditionTask // TypeDefIndex: 47825
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> checkElement;
	
		// Properties
		protected override string info { get => default; }
	
		// Constructors
		public ListContainsElement() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	[Category("\u272B Blackboard/Lists")]
	public class ListIsEmpty : ConditionTask // TypeDefIndex: 47826
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018935A184-0x000000018935A1C4 
	
		// Constructors
		public ListIsEmpty() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935A128-0x000000018935A184
	}

	[Category("\u272B Blackboard")]
	[Name("On Variable Changed", 0)]
	public class BBVariableChanged : ConditionTask // TypeDefIndex: 47827
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter targetVariable; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018934A75C-0x000000018934A7B8 
	
		// Constructors
		public BBVariableChanged() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override string OnInit() => default; // 0x000000018934A6FC-0x000000018934A74C
		protected override void OnEnable() {} // 0x000000018934A664-0x000000018934A6FC
		protected override void OnDisable() {} // 0x000000018934A5CC-0x000000018934A664
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void OnValueChanged(object varValue) {} // 0x000000018934A74C-0x000000018934A75C
	}

	[Category("\u272B Blackboard")]
	public class StringContains : ConditionTask // TypeDefIndex: 47828
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<string> targetString; // 0x68
		public BBParameter<string> checkString; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018935F6F8-0x000000018935F73C 
	
		// Constructors
		public StringContains() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935F67C-0x000000018935F6F8
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget : ConditionTask<Transform> // TypeDefIndex: 47829
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		[Tooltip("Distance within which to look out for.")]
		public BBParameter<float> maxDistance; // 0x70
		[Tooltip("A layer mask to use for line of sight check.")]
		public BBParameter<LayerMask> layerMask; // 0x78
		[Tooltip("Distance within which the target can be seen (or rather sensed) regardless of view angle.")]
		public BBParameter<float> awarnessDistance; // 0x80
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x88
		public Vector3 offset; // 0x90
		private RaycastHit hit; // 0xA0
	
		// Properties
		protected override string info { get => default; } // 0x000000018934E82C-0x000000018934E88C 
	
		// Constructors
		public CanSeeTarget() {} // 0x000000018934E75C-0x000000018934E82C
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934DC1C-0x000000018934E12C
		public override void OnDrawGizmosSelected() {} // 0x000000018934E12C-0x000000018934E75C
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget2D : ConditionTask<Transform> // TypeDefIndex: 47830
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		[Tooltip("Distance within which to look out for.")]
		public BBParameter<float> maxDistance; // 0x70
		[Tooltip("A layer mask to use for the line of sight check.")]
		public BBParameter<LayerMask> layerMask; // 0x78
		[Tooltip("Distance within which the target can be seen (or rather sensed) regardless of view angle.")]
		public BBParameter<float> awarnessDistance; // 0x80
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x88
		public Vector2 offset; // 0x90
		private RaycastHit2D hit; // 0x98
	
		// Properties
		protected override string info { get => default; } // 0x000000018934B3A8-0x000000018934B408 
	
		// Constructors
		public CanSeeTarget2D() {} // 0x000000018934B2D8-0x000000018934B3A8
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934A7B8-0x000000018934AC44
		public override void OnDrawGizmosSelected() {} // 0x000000018934AC44-0x000000018934B2D8
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTargetAny : ConditionTask<Transform> // TypeDefIndex: 47831
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<LayerMask> layerMask; // 0x78
		public BBParameter<float> awarnessDistance; // 0x80
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x88
		public Vector3 offset; // 0x90
		[BlackboardOnly]
		public BBParameter<List<GameObject>> allResults; // 0xA0
		[BlackboardOnly]
		public BBParameter<GameObject> closerResult; // 0xA8
		private RaycastHit hit; // 0xB0
	
		// Properties
		protected override string info { get => default; } // 0x000000018934DBBC-0x000000018934DC1C 
	
		// Constructors
		public CanSeeTargetAny() {} // 0x000000018934DAEC-0x000000018934DBBC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934C7A0-0x000000018934D3FC
		public override void OnDrawGizmosSelected() {} // 0x000000018934D3FC-0x000000018934DA2C
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTargetAny2D : ConditionTask<Transform> // TypeDefIndex: 47832
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<LayerMask> layerMask; // 0x78
		public BBParameter<float> awarnessDistance; // 0x80
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x88
		public Vector2 offset; // 0x90
		[BlackboardOnly]
		public BBParameter<List<GameObject>> allResults; // 0x98
		[BlackboardOnly]
		public BBParameter<GameObject> closerResult; // 0xA0
	
		// Properties
		protected override string info { get => default; } // 0x000000018934C740-0x000000018934C7A0 
	
		// Constructors
		public CanSeeTargetAny2D() {} // 0x000000018934C670-0x000000018934C740
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934B408-0x000000018934BF3C
		public override void OnDrawGizmosSelected() {} // 0x000000018934BF3C-0x000000018934C5B0
	}

	[Category("GameObject")]
	[Name("Target Within Distance", 0)]
	public class CheckDistanceToGameObject : ConditionTask<Transform> // TypeDefIndex: 47833
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189351FA8-0x00000001893520B4 
	
		// Constructors
		public CheckDistanceToGameObject() {} // 0x0000000189351F38-0x0000000189351FA8
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189351D20-0x0000000189351E4C
		public override void OnDrawGizmosSelected() {} // 0x0000000189351E4C-0x0000000189351F38
	}

	[Category("GameObject")]
	[Name("Target Within Distance 2D", 0)]
	public class CheckDistanceToGameObject2D : ConditionTask<Transform> // TypeDefIndex: 47834
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189350B08-0x0000000189350C14 
	
		// Constructors
		public CheckDistanceToGameObject2D() {} // 0x0000000189350A98-0x0000000189350B08
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189350844-0x0000000189350980
		public override void OnDrawGizmosSelected() {} // 0x0000000189350980-0x0000000189350A98
	}

	[Category("GameObject")]
	[Name("Any Target Within Distance", 0)]
	public class CheckDistanceToGameObjectAny : ConditionTask<Transform> // TypeDefIndex: 47835
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
		[BlackboardOnly]
		public BBParameter<List<GameObject>> allResults; // 0x88
		[BlackboardOnly]
		public BBParameter<GameObject> closerResult; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x0000000189351C14-0x0000000189351D20 
	
		// Constructors
		public CheckDistanceToGameObjectAny() {} // 0x0000000189351BA4-0x0000000189351C14
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189351454-0x00000001893519F8
		public override void OnDrawGizmosSelected() {} // 0x00000001893519F8-0x0000000189351AE4
	}

	[Category("GameObject")]
	[Name("Any Target Within Distance 2D", 0)]
	public class CheckDistanceToGameObjectAny2D : ConditionTask<Transform> // TypeDefIndex: 47836
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
		[BlackboardOnly]
		public BBParameter<List<GameObject>> allResults; // 0x88
		[BlackboardOnly]
		public BBParameter<GameObject> closerResult; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x0000000189351348-0x0000000189351454 
	
		// Constructors
		public CheckDistanceToGameObjectAny2D() {} // 0x00000001893512D8-0x0000000189351348
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189350C14-0x00000001893510E4
		public override void OnDrawGizmosSelected() {} // 0x00000001893510E4-0x00000001893511FC
	}

	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	[Name("Target In Line Of Sight", 0)]
	public class CheckLOS : ConditionTask<Transform> // TypeDefIndex: 47837
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		public Vector3 offset; // 0x78
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x88
		private RaycastHit hit; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x0000000189354D00-0x0000000189354D58 
	
		// Constructors
		public CheckLOS() {} // 0x0000000189354CA8-0x0000000189354D00
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189354828-0x0000000189354AD8
		public override void OnDrawGizmosSelected() {} // 0x0000000189354AD8-0x0000000189354CA8
	}

	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	[Name("Target In Line Of Sight 2D", 0)]
	public class CheckLOS2D : ConditionTask<Transform> // TypeDefIndex: 47839
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x78
		[GetFromAgent]
		protected Collider2D agentCollider; // 0x80
		private RaycastHit2D[] hits; // 0x88
	
		// Properties
		protected override string info { get => default; } // 0x00000001893547D0-0x0000000189354828 
	
		// Constructors
		public CheckLOS2D() {} // 0x0000000189354778-0x00000001893547D0
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189354198-0x00000001893545CC
		public override void OnDrawGizmosSelected() {} // 0x00000001893545CC-0x0000000189354778
	}

	[Category("GameObject")]
	public class HasComponent<T> : ConditionTask<Transform> // TypeDefIndex: 47840
		where T : Component
	{
		// Constructors
		public HasComponent() {}
	
		// Methods
		protected override bool OnCheck() => default;
	}

	[Category("GameObject")]
	public class IsActive : ConditionTask<Transform> // TypeDefIndex: 47841
	{
		// Properties
		protected override string info { get => default; } // 0x0000000189359818-0x0000000189359860 
	
		// Constructors
		public IsActive() {} // 0x00000001893597DC-0x0000000189359818
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935977C-0x00000001893597DC
	}

	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	[Name("Target In View Angle", 0)]
	public class IsInFront : ConditionTask<Transform> // TypeDefIndex: 47842
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018935A008-0x000000018935A064 
	
		// Constructors
		public IsInFront() {} // 0x0000000189359FAC-0x000000018935A008
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189359C74-0x0000000189359DE4
		public override void OnDrawGizmosSelected() {} // 0x0000000189359DE4-0x0000000189359FAC
	}

	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	[Name("Target In View Angle 2D", 0)]
	public class IsInFront2D : ConditionTask<Transform> // TypeDefIndex: 47843
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189359C18-0x0000000189359C74 
	
		// Constructors
		public IsInFront2D() {} // 0x0000000189359BBC-0x0000000189359C18
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189359860-0x00000001893599D8
		public override void OnDrawGizmosSelected() {} // 0x00000001893599D8-0x0000000189359BBC
	}

	[Category("GameObject")]
	public class IsWithinLayerMask : ConditionTask<Transform> // TypeDefIndex: 47844
	{
		// Fields
		public BBParameter<LayerMask> targetLayers; // 0x68
	
		// Constructors
		public IsWithinLayerMask() {} // 0x000000018935A0EC-0x000000018935A128
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018935A064-0x000000018935A0EC
	}

	[Category("Input (Legacy System)")]
	public class CheckButtonInput : ConditionTask // TypeDefIndex: 47845
	{
		// Fields
		public PressTypes pressType; // 0x68
		[RequiredField]
		public BBParameter<string> buttonName; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x000000018934EB94-0x000000018934EC2C 
	
		// Constructors
		public CheckButtonInput() {} // 0x000000018934EB38-0x000000018934EB94
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934EA84-0x000000018934EB38
	}

	[Category("Input (Legacy System)")]
	public class CheckKeyboardInput : ConditionTask // TypeDefIndex: 47846
	{
		// Fields
		public PressTypes pressType; // 0x68
		public KeyCode key; // 0x6C
	
		// Properties
		protected override string info { get => default; } // 0x00000001893540E8-0x0000000189354198 
	
		// Constructors
		public CheckKeyboardInput() {} // 0x0000000183D71C70-0x0000000183D71C80
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001893540B4-0x00000001893540E8
	}

	[Category("Input (Legacy System)")]
	public class CheckMousePick : ConditionTask // TypeDefIndex: 47847
	{
		// Fields
		public ParadoxNotion.ButtonKeys buttonKey; // 0x68
		[LayerField]
		public int layer; // 0x6C
		[BlackboardOnly]
		public BBParameter<GameObject> saveGoAs; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> savePosAs; // 0x80
		private RaycastHit hit; // 0x88
	
		// Properties
		protected override string info { get => default; } // 0x0000000189355B10-0x0000000189355C28 
	
		// Constructors
		public CheckMousePick() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189355958-0x0000000189355B10
	}

	[Category("Input (Legacy System)")]
	public class CheckMousePick2D : ConditionTask // TypeDefIndex: 47848
	{
		// Fields
		public ParadoxNotion.ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		[BlackboardOnly]
		public BBParameter<GameObject> saveGoAs; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> savePosAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit2D hit; // 0x8C
	
		// Properties
		protected override string info { get => default; } // 0x0000000189355810-0x0000000189355958 
	
		// Constructors
		public CheckMousePick2D() {} // 0x0000000183D71C80-0x0000000183D71CA0
	
		// Methods
		protected override bool OnCheck() => default; // 0x00000001893555A8-0x0000000189355810
	}

	internal class CheckCSharpEvent_0 // TypeDefIndex: 47849
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckCSharpEvent_0() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class CheckCSharpEvent_0<T> // TypeDefIndex: 47850
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckCSharpEvent_0() {}
	}

	internal class CheckCSharpEventValue_0<T> // TypeDefIndex: 47851
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckCSharpEventValue_0() {}
	}

	[fsMigrateTo(typeof(CheckCSharpEvent))]
	internal class CheckStaticCSharpEvent // TypeDefIndex: 47852
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckStaticCSharpEvent() {} // 0x000000018350B670-0x000000018350B680
	}

	[fsMigrateTo(typeof(CheckCSharpEvent<T>))]
	internal class CheckStaticCSharpEvent<T> // TypeDefIndex: 47853
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckStaticCSharpEvent() {}
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action type and return true when the event is raised.\n(eg public event System.Action [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEvent_0) })]
	public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent> // TypeDefIndex: 47854
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo; // 0x68
		private Delegate handler; // 0x70
	
		// Properties
		private EventInfo targetEvent { get => default; } // 0x0000000187D168B4-0x0000000187D168C4 
		public override System.Type agentType { get => default; } // 0x000000018934F0A4-0x000000018934F178 
		protected override string info { get => default; } // 0x000000018934F178-0x000000018934F250 
	
		// Constructors
		public CheckCSharpEvent() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		void IMigratable<CheckCSharpEvent_0>.Migrate(CheckCSharpEvent_0 model) {} // 0x000000018934EE94-0x000000018934EF58
		void IMigratable<CheckStaticCSharpEvent>.Migrate(CheckStaticCSharpEvent model) {} // 0x000000018934EF58-0x000000018934F01C
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		protected override string OnInit() => default; // 0x000000018934ED74-0x000000018934EE94
		protected override void OnEnable() {} // 0x000000018934ECD0-0x000000018934ED74
		protected override void OnDisable() {} // 0x000000018934EC2C-0x000000018934ECD0
		public void Raised() {} // 0x000000018934A74C-0x000000018934A75C
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void SetTargetEvent(EventInfo info) {} // 0x000000018934F01C-0x000000018934F0A4
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised.\n(eg public event System.Action<T> [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEvent_0<T>) })]
	public class CheckCSharpEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>> // TypeDefIndex: 47855
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo;
		[BlackboardOnly]
		[SerializeField]
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

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised and it\'s value is equal to provided value as well.\n(eg public event System.Action<T> [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEventValue_0<T>) })]
	public class CheckCSharpEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>> // TypeDefIndex: 47856
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo;
		[SerializeField]
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

	internal class CheckField_0 // TypeDefIndex: 47857
	{
		// Fields
		[SerializeField]
		public BBParameter checkValue; // 0x10
		[SerializeField]
		public System.Type targetType; // 0x18
		[SerializeField]
		public string fieldName; // 0x20
	
		// Constructors
		public CheckField_0() {} // 0x000000018350B670-0x000000018350B680
	}

	[Category("\u272B Reflected")]
	[Description("Check a field on a script and return if it\'s equal or not to a value")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckField_0) })]
	[Name("Check Field", 8)]
	public class CheckField : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0> // TypeDefIndex: 47858
	{
		// Fields
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x68
		[SerializeField]
		protected CompareMethod comparison; // 0x70
		[SerializeField]
		protected SerializedFieldInfo field; // 0x78
	
		// Properties
		private System.Reflection.FieldInfo targetField { get => default; } // 0x0000000189352BB8-0x0000000189352BC8 
		public override System.Type agentType { get => default; } // 0x00000001893528EC-0x00000001893529BC 
		protected override string info { get => default; } // 0x00000001893529BC-0x0000000189352BB8 
	
		// Constructors
		public CheckField() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		void IMigratable<CheckField_0>.Migrate(CheckField_0 model) {} // 0x00000001893525A8-0x0000000189352838
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EB20-0x0000000183D4EB30
		protected override string OnInit() => default; // 0x0000000189352510-0x00000001893525A8
		protected override bool OnCheck() => default; // 0x00000001893522A0-0x0000000189352510
		private void SetTargetField(System.Reflection.FieldInfo newField) {} // 0x0000000189352838-0x00000001893528EC
	}

	[Category("\u272B Reflected")]
	[Description("Call a function on a component and return whether or not the return value is equal to the check value")]
	[Name("Check Function", 10)]
	public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 47859
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected List<BBObjectParameter> parameters; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x80
		private object[] args; // 0x88
		private bool[] parameterIsByRef; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		public override System.Type agentType { get => default; } // 0x00000001893534E0-0x00000001893535A4 
		protected override string info { get => default; } // 0x00000001893535A4-0x0000000189353870 
	
		// Constructors
		public CheckFunction_Multiplatform() {} // 0x0000000189353464-0x00000001893534E0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x00000001893531FC-0x0000000189353224
		protected override string OnInit() => default; // 0x000000018935307C-0x00000001893531FC
		protected override bool OnCheck() => default; // 0x0000000189352CCC-0x000000018935307C
		private void SetMethod(MethodInfo method) {} // 0x0000000189353224-0x0000000189353464
	}

	[Category("\u272B Reflected")]
	[Description("Check a property on a script and return if it\'s equal or not to the check value")]
	[Name("Check Property", 9)]
	public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 47860
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x0000000189353870-0x0000000189353880 
		public override System.Type agentType { get => default; } // 0x00000001893563C0-0x0000000189356484 
		protected override string info { get => default; } // 0x0000000189356484-0x000000018935660C 
	
		// Constructors
		public CheckProperty_Multiplatform() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x00000001893562E4-0x000000018935630C
		protected override string OnInit() => default; // 0x000000018935627C-0x00000001893562E4
		protected override bool OnCheck() => default; // 0x0000000189355FFC-0x000000018935627C
		private void SetMethod(MethodInfo method) {} // 0x000000018935630C-0x00000001893563C0
	}

	internal class CheckUnityEvent_0 // TypeDefIndex: 47861
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckUnityEvent_0() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class CheckUnityEvent_0<T> // TypeDefIndex: 47862
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckUnityEvent_0() {}
	}

	internal class CheckUnityEventValue_0<T> // TypeDefIndex: 47863
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckUnityEventValue_0() {}
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent and return true when that event is raised.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEvent_0) })]
	public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0> // TypeDefIndex: 47864
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo; // 0x68
		private UnityEvent unityEvent; // 0x70
	
		// Properties
		private MemberInfo targetMember { get => default; } // 0x0000000187DCA760-0x0000000187DCA774 
		private bool isStatic { get => default; } // 0x0000000187DCA728-0x0000000187DCA748 
		private System.Type eventType { get => default; } // 0x0000000187DC8C74-0x0000000187DC8C94 
		private System.Reflection.FieldInfo targetEventField { get => default; } // 0x0000000187DCA748-0x0000000187DCA754 
		private PropertyInfo targetEventProp { get => default; } // 0x0000000187DCA754-0x0000000187DCA760 
		public override System.Type agentType { get => default; } // 0x0000000189357E38-0x0000000189357EF0 
		protected override string info { get => default; } // 0x0000000189357EF0-0x0000000189357FC8 
	
		// Constructors
		public CheckUnityEvent() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		void IMigratable<CheckUnityEvent_0>.Migrate(CheckUnityEvent_0 model) {} // 0x0000000189357CF8-0x0000000189357DB0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		protected override string OnInit() => default; // 0x0000000189357B7C-0x0000000189357CF8
		protected override void OnEnable() {} // 0x0000000189357AE8-0x0000000189357B7C
		protected override void OnDisable() {} // 0x0000000189357A54-0x0000000189357AE8
		public void Raised() {} // 0x000000018934A74C-0x000000018934A75C
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void SetTargetEvent(MemberInfo newMember) {} // 0x0000000189357DB0-0x0000000189357E38
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEvent_0<T>) })]
	public class CheckUnityEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>> // TypeDefIndex: 47865
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo;
		[BlackboardOnly]
		[SerializeField]
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

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised and it\'s value is equal to provided value as well.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEventValue_0<T>) })]
	public class CheckUnityEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T>> // TypeDefIndex: 47866
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo;
		[SerializeField]
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

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCall a function with none or up to 6 parameters on a component and return whether or not the return value is equal to the check value")]
	[Name("Check Function (Desktop Only)", 0)]
	public class CheckFunction : ConditionTask // TypeDefIndex: 47867
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField]
		protected BBParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		public override System.Type agentType { get => default; } // 0x0000000189353C98-0x0000000189353D5C 
		protected override string info { get => default; } // 0x0000000189353D5C-0x000000018935401C 
	
		// Constructors
		public CheckFunction() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189353BB4-0x0000000189353C00
		protected override string OnInit() => default; // 0x0000000189353A98-0x0000000189353BB4
		protected override bool OnCheck() => default; // 0x0000000189353880-0x0000000189353A98
		private void SetMethod(MethodInfo method) {} // 0x0000000189353C00-0x0000000189353C98
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCheck a property on a script and return if it\'s equal or not to the check value")]
	[Name("Check Property (Desktop Only)", 0)]
	public class CheckProperty : ConditionTask // TypeDefIndex: 47868
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField]
		protected BBParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get => default; } // 0x000000018935401C-0x000000018935403C 
		public override System.Type agentType { get => default; } // 0x0000000189356940-0x0000000189356A04 
		protected override string info { get => default; } // 0x0000000189356A04-0x0000000189356B8C 
	
		// Constructors
		public CheckProperty() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem) {} // 0x0000000189353BB4-0x0000000189353C00
		protected override string OnInit() => default; // 0x0000000189356824-0x0000000189356940
		protected override bool OnCheck() => default; // 0x000000018935660C-0x0000000189356824
		private void SetMethod(MethodInfo method) {} // 0x0000000189353C00-0x0000000189353C98
	}

	[Category("System Events")]
	[Name("Check Collision", 0)]
	public class CheckCollision_Rigidbody : ConditionTask<Rigidbody> // TypeDefIndex: 47869
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactPoint; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x0000000189350684-0x000000018935073C 
	
		// Constructors
		public CheckCollision_Rigidbody() {} // 0x0000000189350634-0x0000000189350684
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189350540-0x0000000189350634
		protected override void OnDisable() {} // 0x000000018935044C-0x0000000189350540
		protected override bool OnCheck() => default; // 0x000000018934F250-0x000000018934F264
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data) {} // 0x00000001893501E0-0x0000000189350380
		public void OnCollisionExit(EventData<UnityEngine.Collision> data) {} // 0x0000000189350380-0x000000018935044C
	}

	[Category("System Events")]
	[DoNotList]
	public class CheckCollision : ConditionTask<Collider> // TypeDefIndex: 47870
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactPoint; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018935078C-0x0000000189350844 
	
		// Constructors
		public CheckCollision() {} // 0x000000018935073C-0x000000018935078C
	
		// Methods
		protected override void OnEnable() {} // 0x00000001893500EC-0x00000001893501E0
		protected override void OnDisable() {} // 0x000000018934FFF8-0x00000001893500EC
		protected override bool OnCheck() => default; // 0x000000018934F250-0x000000018934F264
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data) {} // 0x000000018934FD8C-0x000000018934FF2C
		public void OnCollisionExit(EventData<UnityEngine.Collision> data) {} // 0x000000018934FF2C-0x000000018934FFF8
	}

	[Category("System Events")]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D_Rigidbody : ConditionTask<Rigidbody2D> // TypeDefIndex: 47871
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactPoint; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018934FBCC-0x000000018934FC84 
	
		// Constructors
		public CheckCollision2D_Rigidbody() {} // 0x000000018934FB7C-0x000000018934FBCC
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934F250-0x000000018934F264
		protected override void OnEnable() {} // 0x000000018934FA88-0x000000018934FB7C
		protected override void OnDisable() {} // 0x000000018934F994-0x000000018934FA88
		private void OnCollisionEnter2D(EventData<Collision2D> data) {} // 0x000000018934F6F0-0x000000018934F8C8
		private void OnCollisionExit2D(EventData<Collision2D> data) {} // 0x000000018934F8C8-0x000000018934F994
	}

	[Category("System Events")]
	[DoNotList]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D : ConditionTask<Collider2D> // TypeDefIndex: 47872
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactPoint; // 0x80
		[BlackboardOnly]
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get => default; } // 0x000000018934FCD4-0x000000018934FD8C 
	
		// Constructors
		public CheckCollision2D() {} // 0x000000018934FC84-0x000000018934FCD4
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018934F250-0x000000018934F264
		protected override void OnEnable() {} // 0x000000018934F5FC-0x000000018934F6F0
		protected override void OnDisable() {} // 0x000000018934F508-0x000000018934F5FC
		private void OnCollisionEnter2D(EventData<Collision2D> data) {} // 0x000000018934F264-0x000000018934F43C
		private void OnCollisionExit2D(EventData<Collision2D> data) {} // 0x000000018934F43C-0x000000018934F508
	}

	[Category("System Events")]
	public class CheckMouse : ConditionTask<Collider> // TypeDefIndex: 47873
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189355F04-0x0000000189355F54 
	
		// Constructors
		public CheckMouse() {} // 0x0000000189355EC8-0x0000000189355F04
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		protected override void OnEnable() {} // 0x0000000189355D78-0x0000000189355EC8
		protected override void OnDisable() {} // 0x0000000189355C28-0x0000000189355D78
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x0000000189354FF8-0x000000018935500C
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018935500C-0x0000000189355020
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x0000000189355020-0x0000000189355034
	}

	[Category("System Events")]
	[Name("Check Mouse 2D", 0)]
	public class CheckMouse2D : ConditionTask<Collider2D> // TypeDefIndex: 47874
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189355070-0x00000001893550C0 
	
		// Constructors
		public CheckMouse2D() {} // 0x0000000189355034-0x0000000189355070
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189354EA8-0x0000000189354FF8
		protected override void OnDisable() {} // 0x0000000189354D58-0x0000000189354EA8
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void OnMouseEnter(ParadoxNotion.EventData msg) {} // 0x0000000189354FF8-0x000000018935500C
		private void OnMouseExit(ParadoxNotion.EventData msg) {} // 0x000000018935500C-0x0000000189355020
		private void OnMouseOver(ParadoxNotion.EventData msg) {} // 0x0000000189355020-0x0000000189355034
	}

	[Category("System Events")]
	public class CheckMouseClick : ConditionTask<Collider> // TypeDefIndex: 47875
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189355558-0x00000001893555A8 
	
		// Constructors
		public CheckMouseClick() {} // 0x000000018935551C-0x0000000189355558
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		protected override void OnEnable() {} // 0x0000000189355428-0x000000018935551C
		protected override void OnDisable() {} // 0x0000000189355334-0x0000000189355428
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x0000000189354FF8-0x000000018935500C
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018935500C-0x0000000189355020
	}

	[Category("System Events")]
	[Name("Check Mouse Click 2D", 0)]
	public class CheckMouseClick2D : ConditionTask<Collider2D> // TypeDefIndex: 47876
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x00000001893552E4-0x0000000189355334 
	
		// Constructors
		public CheckMouseClick2D() {} // 0x00000001893552A8-0x00000001893552E4
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		protected override void OnEnable() {} // 0x00000001893551B4-0x00000001893552A8
		protected override void OnDisable() {} // 0x00000001893550C0-0x00000001893551B4
		private void OnMouseDown(ParadoxNotion.EventData msg) {} // 0x0000000189354FF8-0x000000018935500C
		private void OnMouseUp(ParadoxNotion.EventData msg) {} // 0x000000018935500C-0x0000000189355020
	}

	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	[Name("Check Trigger", 0)]
	public class CheckTrigger_Transform : ConditionTask<Transform> // TypeDefIndex: 47877
	{
		// Fields
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[ShowIf("specifiedTagOnly", 1)]
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189357894-0x000000018935794C 
	
		// Constructors
		public CheckTrigger_Transform() {} // 0x0000000189357844-0x0000000189357894
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189357128-0x000000018935713C
		protected override void OnEnable() {} // 0x00000001893575B4-0x00000001893576A8
		protected override void OnDisable() {} // 0x00000001893574C0-0x00000001893575B4
		public void OnTriggerEnter(EventData<Collider> data) {} // 0x00000001893576A8-0x0000000189357778
		public void OnTriggerExit(EventData<Collider> data) {} // 0x0000000189357778-0x0000000189357844
	}

	[Category("System Events")]
	[DoNotList]
	public class CheckTrigger : ConditionTask<Collider> // TypeDefIndex: 47878
	{
		// Fields
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[ShowIf("specifiedTagOnly", 1)]
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x000000018935799C-0x0000000189357A54 
	
		// Constructors
		public CheckTrigger() {} // 0x000000018935794C-0x000000018935799C
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189357128-0x000000018935713C
		protected override void OnEnable() {} // 0x0000000189357230-0x0000000189357324
		protected override void OnDisable() {} // 0x000000018935713C-0x0000000189357230
		public void OnTriggerEnter(EventData<Collider> data) {} // 0x0000000189357324-0x00000001893573F4
		public void OnTriggerExit(EventData<Collider> data) {} // 0x00000001893573F4-0x00000001893574C0
	}

	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	[Name("Check Trigger 2D", 0)]
	public class CheckTrigger2D_Transform : ConditionTask<Transform> // TypeDefIndex: 47879
	{
		// Fields
		public TriggerTypes CheckType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189357070-0x0000000189357128 
	
		// Constructors
		public CheckTrigger2D_Transform() {} // 0x0000000189357020-0x0000000189357070
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189356C88-0x0000000189356C9C
		protected override void OnEnable() {} // 0x0000000189356D90-0x0000000189356E84
		protected override void OnDisable() {} // 0x0000000189356C9C-0x0000000189356D90
		public void OnTriggerEnter2D(EventData<Collider2D> data) {} // 0x0000000189356E84-0x0000000189356F54
		public void OnTriggerExit2D(EventData<Collider2D> data) {} // 0x0000000189356F54-0x0000000189357020
	}

	[Category("System Events")]
	[DoNotList]
	[Name("Check Trigger 2D", 0)]
	public class CheckTrigger2D : ConditionTask<Collider2D> // TypeDefIndex: 47880
	{
		// Fields
		public TriggerTypes CheckType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField]
		public string objectTag; // 0x70
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get => default; } // 0x0000000189361400-0x00000001893614B8 
	
		// Constructors
		public CheckTrigger2D() {} // 0x00000001893613B0-0x0000000189361400
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189356C88-0x0000000189356C9C
		protected override void OnEnable() {} // 0x0000000189361120-0x0000000189361214
		protected override void OnDisable() {} // 0x000000018936102C-0x0000000189361120
		public void OnTriggerEnter2D(EventData<Collider2D> data) {} // 0x0000000189361214-0x00000001893612E4
		public void OnTriggerExit2D(EventData<Collider2D> data) {} // 0x00000001893612E4-0x00000001893613B0
	}

	[Category("UGUI")]
	public class ButtonClicked : ConditionTask // TypeDefIndex: 47881
	{
		// Fields
		[RequiredField]
		public BBParameter<UnityEngine.UI.Button> button; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x00000001893606EC-0x0000000189360744 
	
		// Constructors
		public ButtonClicked() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override string OnInit() => default; // 0x0000000189360630-0x00000001893606EC
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void OnClick() {} // 0x000000018934A74C-0x000000018934A75C
	}

	[Category("UGUI")]
	[Description("Returns true when the selected event is triggered on the selected agent.\nYou can use this for both GUI and 3D objects.\nPlease make sure that Unity Event Systems are setup correctly")]
	public class InterceptEvent : ConditionTask<Transform> // TypeDefIndex: 47882
	{
		// Fields
		public EventTriggerType eventType; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x000000018936DAC0-0x000000018936DB48 
	
		// Constructors
		public InterceptEvent() {} // 0x000000018936DA84-0x000000018936DAC0
	
		// Methods
		protected override void OnEnable() {} // 0x000000018936D4B4-0x000000018936DA84
		protected override void OnDisable() {} // 0x000000018936CEE4-0x000000018936D4B4
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void OnPointerEnter(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnPointerExit(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnPointerDown(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnPointerUp(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnPointerClick(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnDrag(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnDrop(EventData<PointerEventData> eventData) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnScroll(EventData<PointerEventData> data) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnUpdateSelected(EventData<BaseEventData> eventData) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnSelect(EventData<BaseEventData> eventData) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnDeselect(EventData<BaseEventData> eventData) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnMove(EventData<AxisEventData> eventData) {} // 0x000000018934A74C-0x000000018934A75C
		private void OnSubmit(EventData<BaseEventData> eventData) {} // 0x000000018934A74C-0x000000018934A75C
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and return true for one frame")]
	public class CheckEvent : ConditionTask<GraphOwner> // TypeDefIndex: 47883
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189360930-0x0000000189360998 
	
		// Constructors
		public CheckEvent() {} // 0x00000001893608F4-0x0000000189360930
	
		// Methods
		protected override void OnEnable() {} // 0x000000018936085C-0x00000001893608F4
		protected override void OnDisable() {} // 0x00000001893607C4-0x000000018936085C
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData data) {} // 0x0000000189360744-0x00000001893607C4
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and return true for one frame. Optionaly save the received event\'s value")]
	public class CheckEvent<T> : ConditionTask<GraphOwner> // TypeDefIndex: 47884
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName;
		[BlackboardOnly]
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

	[Category("\u272B Utility")]
	[Description("Check if an event is received and it\'s value is equal to specified value, then return true for one frame")]
	public class CheckEventValue<T> : ConditionTask<GraphOwner> // TypeDefIndex: 47885
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName;
		[Name("Compare Value To", 0)]
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

	[Category("\u272B Utility")]
	[Description("Check for an invoked Signal with agent as the target. If Signal was invoked as global, then the target does not matter.")]
	public class CheckSignal : ConditionTask<Transform> // TypeDefIndex: 47886
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		[SerializeField]
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x0000000189359758-0x000000018935977C 
	
		// Constructors
		public CheckSignal() {} // 0x0000000189360D30-0x0000000189360DB8
	
		// Methods
		protected override string OnInit() => default; // 0x0000000189360B54-0x0000000189360BA4
		protected override void OnEnable() {} // 0x0000000189360A48-0x0000000189360B54
		protected override void OnDisable() {} // 0x0000000189360998-0x0000000189360A48
		private void OnSignalInvoke(Transform sender, Transform receiver, bool isGlobal, params object[] args) {} // 0x0000000189360BA4-0x0000000189360D30
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[Category("\u272B Utility")]
	[Description("Check the parent state status. This condition is only meant to be used along with an FSM system.")]
	public class CheckStateStatus : ConditionTask // TypeDefIndex: 47887
	{
		// Fields
		public CompactStatus status; // 0x68
	
		// Properties
		protected override string info { get => default; } // 0x0000000189360FCC-0x000000018936102C 
	
		// Constructors
		public CheckStateStatus() {} // 0x0000000183D71DC0-0x0000000183D71DD0
	
		// Methods
		protected override bool OnCheck() => default; // 0x0000000189360F38-0x0000000189360FCC
	}

	[Category("\u272B Utility")]
	[Description("Simply use to debug return true or false by inverting the condition if needed")]
	public class DebugCondition : ConditionTask // TypeDefIndex: 47888
	{
		// Constructors
		public DebugCondition() {} // 0x0000000183D56BD0-0x0000000183D56BE0
	
		// Methods
		protected override bool OnCheck() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[Category("\u272B Utility")]
	[Description("Return true or false based on the probability settings.")]
	public class Probability : ConditionTask // TypeDefIndex: 47889
	{
		// Fields
		public BBParameter<float> probability; // 0x68
		public BBParameter<float> maxValue; // 0x70
		private bool success; // 0x78
	
		// Properties
		protected override string info { get => default; } // 0x0000000189370CF8-0x0000000189370D9C 
	
		// Constructors
		public Probability() {} // 0x0000000189370C84-0x0000000189370CF8
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189370C04-0x0000000189370C84
		protected override bool OnCheck() => default; // 0x0000000183D4F800-0x0000000183D4F810
	}

	[Category("\u272B Utility")]
	[Description("Will return true after a specific amount of time has passed and false while still counting down")]
	public class Timeout : ConditionTask // TypeDefIndex: 47890
	{
		// Fields
		public BBParameter<float> timeout; // 0x68
		private float currentTime; // 0x70
	
		// Properties
		protected override string info { get => default; } // 0x00000001893754CC-0x0000000189375550 
	
		// Constructors
		public Timeout() {} // 0x0000000189375478-0x00000001893754CC
	
		// Methods
		protected override void OnEnable() {} // 0x00000001893753E0-0x0000000189375478
		protected override void OnDisable() {} // 0x0000000189375348-0x00000001893753E0
		private void MoveNext() {} // 0x0000000189375268-0x00000001893752E4
		protected override bool OnCheck() => default; // 0x00000001893752E4-0x0000000189375348
	}
}

namespace ParadoxNotion
{
	public delegate void ActionCall(); // TypeDefIndex: 48302; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void ActionCall<T1>(T1 a); // TypeDefIndex: 48303; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2>(T1 a, T2 b); // TypeDefIndex: 48304; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c); // TypeDefIndex: 48305; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 48306; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 48307; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 48308; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 48309; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 48310; 0x00000000-0x00000000

	public delegate TResult FunctionCall<TResult>(); // TypeDefIndex: 48311; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, TResult>(T1 a); // TypeDefIndex: 48312; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b); // TypeDefIndex: 48313; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c); // TypeDefIndex: 48314; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 48315; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 48316; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 48317; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 48318; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 48319; 0x00000000-0x00000000

	[Serializable]
	public sealed class DynamicParameterDefinition : ISerializationCallbackReceiver // TypeDefIndex: 48320
	{
		// Fields
		[SerializeField]
		private string _ID; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private string _type; // 0x20
	
		// Properties
		public string ID { get => default; private set {} } // 0x00000001893907F4-0x0000000189390824 0x000000018426FEE0-0x000000018426FEF0
		public string name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public System.Type type { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		public DynamicParameterDefinition() {} // 0x000000018350B670-0x000000018350B680
		public DynamicParameterDefinition(string name, System.Type type) {} // 0x000000018939077C-0x00000001893907F4
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018939070C-0x000000018939077C
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893906AC-0x000000018939070C
	}

	public enum CompareMethod // TypeDefIndex: 48321
	{
		EqualTo = 0,
		GreaterThan = 1,
		LessThan = 2,
		GreaterOrEqualTo = 3,
		LessOrEqualTo = 4
	}

	public enum OperationMethod // TypeDefIndex: 48322
	{
		Set = 0,
		Add = 1,
		Subtract = 2,
		Multiply = 3,
		Divide = 4
	}

	public enum ButtonKeys // TypeDefIndex: 48323
	{
		Left = 0,
		Right = 1,
		Middle = 2
	}

	public enum PressTypes // TypeDefIndex: 48324
	{
		Down = 0,
		Up = 1,
		Pressed = 2
	}

	public enum MouseClickEvent // TypeDefIndex: 48325
	{
		MouseDown = 0,
		MouseUp = 1
	}

	public enum TriggerTypes // TypeDefIndex: 48326
	{
		TriggerEnter = 0,
		TriggerExit = 1,
		TriggerStay = 2
	}

	public enum CollisionTypes // TypeDefIndex: 48327
	{
		CollisionEnter = 0,
		CollisionExit = 1,
		CollisionStay = 2
	}

	public enum MouseInteractionTypes // TypeDefIndex: 48328
	{
		MouseEnter = 0,
		MouseExit = 1,
		MouseOver = 2
	}

	public enum CompactStatus // TypeDefIndex: 48329
	{
		Failure = 0,
		Success = 1
	}

	public enum PlayDirections // TypeDefIndex: 48330
	{
		Forward = 0,
		Backward = 1,
		Toggle = 2
	}

	public enum PlanarDirection // TypeDefIndex: 48331
	{
		Horizontal = 0,
		Vertical = 1,
		Auto = 2
	}

	public enum Alignment2x2 // TypeDefIndex: 48332
	{
		Default = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4
	}

	public enum Alignment3x3 // TypeDefIndex: 48333
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

	public class HierarchyTree // TypeDefIndex: 48336
	{
		// Nested types
		public class Element // TypeDefIndex: 48335
		{
			// Fields
			private object _reference; // 0x10
			private Element _parent; // 0x18
			private List<Element> _children; // 0x20
	
			// Properties
			public object reference { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			public Element parent { get => default; } // 0x0000000181041090-0x00000001810410A0 
			public IEnumerable<Element> children { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
			// Constructors
			public Element() {} // Dummy constructor
			public Element(object reference) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public Element AddChild(Element child) => default; // 0x0000000189390824-0x00000001893908E8
			public void RemoveChild(Element child) {} // 0x00000001893909A0-0x00000001893909F4
			public Element GetRoot() => default; // 0x000000018939098C-0x00000001893909A0
			public Element FindReferenceElement(object target) => default; // 0x00000001893908E8-0x000000018939098C
			public T GetFirstParentReferenceOfType<T>() => default;
			[IteratorStateMachine(typeof(_GetAllChildrenReferencesOfType_d__15<T>))]
			public IEnumerable<T> GetAllChildrenReferencesOfType<T>() => default;
		}
	
		// Constructors
		public HierarchyTree() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IEventData // TypeDefIndex: 48337
	{
		// Properties
		GameObject receiver { get; }
		object sender { get; }
		object valueBoxed { get; }
	}

	public struct EventData : ParadoxNotion.IEventData // TypeDefIndex: 48338
	{
		// Properties
		public GameObject receiver { [IsReadOnly] get; private set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public object sender { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public object value { [IsReadOnly] get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public object valueBoxed { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public EventData(object value, GameObject receiver, object sender) : this() {} // 0x0000000189390A30-0x0000000189390A64
		public EventData(GameObject receiver, object sender) : this() {} // 0x00000001893909F4-0x0000000189390A30
	}

	public struct EventData<T> : ParadoxNotion.IEventData // TypeDefIndex: 48339
	{
		// Properties
		public GameObject receiver { [IsReadOnly] get; private set; }
		public object sender { [IsReadOnly] get; private set; }
		public T value { [IsReadOnly] get; private set; }
		public object valueBoxed { get => default; }
	
		// Constructors
		public EventData(T value, GameObject receiver, object sender) : this() {}
	}

	public static class OperationTools // TypeDefIndex: 48340
	{
		// Methods
		public static string GetOperationString(OperationMethod om) => default; // 0x0000000189395F9C-0x0000000189396058
		public static float Operate(float a, float b, OperationMethod om, float delta = 1f /* Metadata: 0x01FBB7DC */) => default; // 0x0000000189396274-0x00000001893962BC
		public static int Operate(int a, int b, OperationMethod om) => default; // 0x0000000189396238-0x0000000189396274
		public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f /* Metadata: 0x01FBB7E0 */) => default; // 0x0000000189396058-0x0000000189396238
		public static string GetCompareString(CompareMethod cm) => default; // 0x0000000189395EE0-0x0000000189395F9C
		public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint) => default; // 0x0000000189395E98-0x0000000189395EE0
		public static bool Compare(int a, int b, CompareMethod cm) => default; // 0x0000000189395E58-0x0000000189395E98
	}

	public static class ReflectionTools // TypeDefIndex: 48347
	{
		// Fields
		public const System.Reflection.BindingFlags FLAGS_ALL = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.FlattenHierarchy; // Metadata: 0x01FBB7EB
		public const System.Reflection.BindingFlags FLAGS_ALL_DECLARED = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic; // Metadata: 0x01FBB7ED
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
		public const string METHOD_SPECIAL_NAME_GET = "get_"; // Metadata: 0x01FBB7EE
		public const string METHOD_SPECIAL_NAME_SET = "set_"; // Metadata: 0x01FBB7F3
		public const string METHOD_SPECIAL_NAME_ADD = "add_"; // Metadata: 0x01FBB7F8
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_"; // Metadata: 0x01FBB7FD
		public const string METHOD_SPECIAL_NAME_OP = "op_"; // Metadata: 0x01FBB805
	
		// Properties
		private static Assembly[] loadedAssemblies { get; } // 0x000000018939CED4-0x000000018939CF84 
	
		// Nested types
		public enum MethodType // TypeDefIndex: 48341
		{
			Normal = 0,
			PropertyAccessor = 1,
			Event = 2,
			Operator = 3
		}
	
		// Constructors
		static ReflectionTools() {} // 0x00000001831CC090-0x00000001831CCC60
	
		// Methods
		public static void FlushMem() {} // 0x00000001836904F0-0x0000000183690C80
		public static System.Type GetType(string typeFullName) => default; // 0x000000018939974C-0x000000018939979C
		public static System.Type GetType(string typeFullName, System.Type fallbackAssignable) => default; // 0x00000001893996F8-0x000000018939974C
		public static System.Type GetType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x01FBB7E4 */, System.Type fallbackAssignable = null) => default; // 0x000000018939979C-0x00000001893999C8
		private static System.Type GetTypeDirect(string typeFullName) => default; // 0x0000000189399578-0x00000001893996F8
		private static System.Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x01FBB7E5 */, System.Type fallbackAssignable = null) => default; // 0x000000018939C814-0x000000018939CD20
		private static System.Type TryResolveDeserializeFromAttribute(string typeName) => default; // 0x000000018939C6F8-0x000000018939C814
		private static System.Type TryResolveWithoutNamespace(string typeName, System.Type fallbackAssignable = null) => default; // 0x000000018939CD20-0x000000018939CED4
		public static System.Type[] GetAllTypes(bool includeObsolete) => default; // 0x0000000189398028-0x0000000189398490
		public static System.Type[] GetImplementationsOf(System.Type baseType) => default; // 0x0000000189398EC4-0x00000001893990A0
		public static object[] SingleTempArgsArray(object arg) => default; // 0x000000018939C270-0x000000018939C2F8
		public static string FriendlyTypeName(string fullName) => default; // 0x0000000189397E84-0x0000000189397F80
		public static System.Type[] RTGetEmptyTypes() => default; // 0x000000018939AAF0-0x000000018939AB40
		private static bool MemberResolvedFromDeserializeAttribute(MemberInfo member, string targetName) => default; // 0x0000000189399F84-0x0000000189399FFC
		public static Delegate ConvertDelegate(Delegate originalDelegate, System.Type targetDelegateType) => default; // 0x0000000189396C68-0x0000000189396CA8
		public static bool TryConvert(System.Type fromType, System.Type toType, out UnaryExpression exp) {
			exp = default;
			return default;
		} // 0x000000018939C2F8-0x000000018939C3FC
		public static void DigFields(object root, Predicate<System.Reflection.FieldInfo> move, Action<object> push, Action<object> pop) {} // 0x0000000189396D60-0x000000018939734C
		public static Func<T, TResult> GetFieldGetter<T, TResult>(System.Reflection.FieldInfo info) => default;
		public static Action<T, TValue> GetFieldSetter<T, TValue>(System.Reflection.FieldInfo info) => default;
	
		// Extension methods
		public static MethodType GetMethodSpecialType(this MethodBase method) => default; // 0x00000001893990A0-0x00000001893994F8
		public static string FriendlyName(this System.Type t, bool compileSafe = false /* Metadata: 0x01FBB7E6 */) => default; // 0x0000000189397974-0x0000000189397E84
		public static string FriendlyName(this MemberInfo info) => default; // 0x0000000189397878-0x0000000189397974
		public static string FriendlyName(this MethodBase method) => default; // 0x000000018939734C-0x00000001893973A4
		public static string FriendlyName(this MethodBase method, out MethodType specialNameType) {
			specialNameType = default;
			return default;
		} // 0x00000001893973A4-0x0000000189397878
		public static string SignatureName(this MethodBase method) => default; // 0x000000018939BE90-0x000000018939C270
		public static System.Type RTReflectedOrDeclaredType(this MemberInfo member) => default; // 0x000000018939BC18-0x000000018939BC8C
		public static bool RTIsAssignableFrom(this System.Type type, System.Type other) => default; // 0x00000001832FFFC0-0x00000001832FFFF0
		public static bool RTIsAssignableTo(this System.Type type, System.Type other) => default; // 0x000000018939B990-0x000000018939B9EC
		public static bool RTIsAbstract(this System.Type type) => default; // 0x000000018939B954-0x000000018939B970
		public static bool RTIsValueType(this System.Type type) => default; // 0x000000018939BBD4-0x000000018939BBF4
		public static bool RTIsArray(this System.Type type) => default; // 0x000000018939B970-0x000000018939B990
		public static bool RTIsInterface(this System.Type type) => default; // 0x000000018939BB94-0x000000018939BBB0
		public static bool RTIsSubclassOf(this System.Type type, System.Type other) => default; // 0x000000018939BBB0-0x000000018939BBD4
		public static bool RTIsGenericParameter(this System.Type type) => default; // 0x000000018939BB54-0x000000018939BB74
		public static bool RTIsGenericType(this System.Type type) => default; // 0x000000018939BB74-0x000000018939BB94
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop) => default; // 0x000000018939B3A4-0x000000018939B3C0
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop) => default; // 0x000000018939B938-0x000000018939B954
		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del) => default; // 0x000000018939A984-0x000000018939A9A4
		public static System.Type RTMakeGenericType(this System.Type type, params System.Type[] typeArgs) => default; // 0x000000018939BBF4-0x000000018939BC18
		public static System.Type[] RTGetGenericArguments(this System.Type type) => default; // 0x000000018939B19C-0x000000018939B2A0
		public static System.Type[] RTGetGenericArguments(this MethodInfo method) => default; // 0x000000018939B2A0-0x000000018939B3A4
		public static System.Type RTGetElementType(this System.Type type) => default; // 0x000000018939AAA0-0x000000018939AAF0
		public static bool RTIsByRef(this System.Type type) => default; // 0x000000018939B9EC-0x000000018939BA3C
		public static object CreateObject(this System.Type type) => default; // 0x0000000189396D10-0x0000000189396D60
		public static object CreateObjectUninitialized(this System.Type type) => default; // 0x0000000189396CA8-0x0000000189396D10
		public static ConstructorInfo RTGetDefaultConstructor(this System.Type type) => default; // 0x000000018939A8E4-0x000000018939A984
		public static ConstructorInfo RTGetConstructor(this System.Type type, System.Type[] paramTypes) => default; // 0x000000018939A6D8-0x000000018939A800
		public static MethodInfo RTGetMethod(this System.Type type, string name) => default; // 0x000000018939B3C0-0x000000018939B494
		public static MethodInfo RTGetMethod(this System.Type type, string name, System.Type[] paramTypes, System.Type returnType = null, System.Type[] genericArgumentTypes = null) => default; // 0x000000018939B494-0x000000018939B6A4
		public static System.Reflection.FieldInfo RTGetField(this System.Type type, string name, bool includePrivateBase = false /* Metadata: 0x01FBB7E7 */) => default; // 0x000000018939AFA0-0x000000018939B0BC
		public static PropertyInfo RTGetProperty(this System.Type type, string name) => default; // 0x000000018939B864-0x000000018939B938
		public static MemberInfo RTGetFieldOrProp(this System.Type type, string name) => default; // 0x000000018939AE34-0x000000018939AFA0
		public static EventInfo RTGetEvent(this System.Type type, string name) => default; // 0x000000018939AB40-0x000000018939AC14
		public static object RTGetFieldOrPropValue(this MemberInfo member, object instance, int index = -1 /* Metadata: 0x01FBB7E8 */) => default; // 0x000000018939ACF4-0x000000018939AE34
		public static void RTSetFieldOrPropValue(this MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x01FBB7E9 */) {} // 0x000000018939BC8C-0x000000018939BDD4
		public static ConstructorInfo[] RTGetConstructors(this System.Type type) => default; // 0x000000018939A800-0x000000018939A8E4
		public static MethodInfo[] RTGetMethods(this System.Type type) => default; // 0x000000018939B6A4-0x000000018939B784
		public static System.Reflection.FieldInfo[] RTGetFields(this System.Type type) => default; // 0x000000018939B0BC-0x000000018939B19C
		public static PropertyInfo[] RTGetProperties(this System.Type type) => default; // 0x000000018939B784-0x000000018939B864
		public static EventInfo[] RTGetEvents(this System.Type type) => default; // 0x000000018939AC14-0x000000018939ACF4
		public static object[] RTGetAllAttributes(this System.Type type) => default; // 0x000000018939A204-0x000000018939A3C4
		public static bool RTIsDefined<T>(this System.Type type, bool inherited)
			where T : Attribute => default;
		public static bool RTIsDefined(this System.Type type, System.Type attributeType, bool inherited) => default; // 0x000000018939BA3C-0x000000018939BAC8
		public static T RTGetAttribute<T>(this System.Type type, bool inherited)
			where T : Attribute => default;
		public static Attribute RTGetAttribute(this System.Type type, System.Type attributeType, bool inherited) => default; // 0x000000018939A5C0-0x000000018939A6D8
		public static object[] RTGetAllAttributes(this MemberInfo member) => default; // 0x000000018939A3C4-0x000000018939A4A0
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute => default;
		public static bool RTIsDefined(this MemberInfo member, System.Type attributeType, bool inherited) => default; // 0x000000018939BAC8-0x000000018939BB54
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute => default;
		public static Attribute RTGetAttribute(this MemberInfo member, System.Type attributeType, bool inherited) => default; // 0x000000018939A4A0-0x000000018939A5C0
		[IteratorStateMachine(typeof(_RTGetAttributesRecursive_d__99<T>))]
		public static IEnumerable<T> RTGetAttributesRecursive<T>(this System.Type type)
			where T : Attribute => default;
		public static ParameterInfo[] RTGetDelegateTypeParameters(this System.Type delegateType) => default; // 0x000000018939A9A4-0x000000018939AAA0
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
			where T : Delegate => default;
		public static Delegate RTCreateDelegate(this MethodInfo method, System.Type type, object instance) => default; // 0x0000000189399FFC-0x000000018939A204
		public static bool IsReadOnly(this System.Reflection.FieldInfo field) => default; // 0x0000000189399EBC-0x0000000189399EF4
		public static bool IsConstant(this System.Reflection.FieldInfo field) => default; // 0x0000000189399AA8-0x0000000189399B08
		public static bool IsStatic(this EventInfo info) => default; // 0x0000000189399F3C-0x0000000189399F84
		public static bool IsStatic(this PropertyInfo info) => default; // 0x0000000189399EF4-0x0000000189399F3C
		public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters) => default; // 0x0000000189399DE0-0x0000000189399E74
		public static bool IsObsolete(this MemberInfo member, bool inherited = true /* Metadata: 0x01FBB7EA */) => default; // 0x0000000189399C60-0x0000000189399DE0
		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo) => default; // 0x000000018939850C-0x000000018939880C
		public static System.Reflection.FieldInfo GetBaseDefinition(this System.Reflection.FieldInfo fieldInfo) => default; // 0x0000000189398490-0x000000018939850C
		public static MethodInfo[] GetExtensionMethods(this System.Type targetType) => default; // 0x00000001893989AC-0x0000000189398C88
		public static bool IsExtensionMethod(this MethodInfo method) => default; // 0x0000000189399BDC-0x0000000189399C30
		public static bool IsPropertyAccessor(this MethodInfo method) => default; // 0x0000000189399E74-0x0000000189399EBC
		public static bool IsIndexerProperty(this PropertyInfo property) => default; // 0x0000000189399C30-0x0000000189399C60
		public static bool IsAutoProperty(this PropertyInfo property) => default; // 0x00000001893999C8-0x0000000189399AA8
		public static PropertyInfo GetAccessorProperty(this MethodInfo method) => default; // 0x0000000189397F80-0x0000000189398028
		public static bool IsEnumerableCollection(this System.Type type) => default; // 0x0000000189399B08-0x0000000189399BDC
		public static System.Type GetEnumerableElementType(this System.Type type) => default; // 0x000000018939880C-0x00000001893989AC
		public static System.Type GetSingleGenericArgument(this System.Type type) => default; // 0x00000001893994F8-0x0000000189399578
		public static System.Type GetFirstGenericParameterConstraintType(this System.Type type) => default; // 0x0000000189398D9C-0x0000000189398EC4
		public static System.Type GetFirstGenericParameterConstraintType(this MethodInfo method) => default; // 0x0000000189398C88-0x0000000189398D9C
		public static bool TryMakeGeneric(this System.Type def, System.Type argType, out System.Type result) {
			result = default;
			return default;
		} // 0x000000018939C3FC-0x000000018939C580
		public static bool TryMakeGeneric(this MethodInfo def, System.Type argType, out MethodInfo result) {
			result = default;
			return default;
		} // 0x000000018939C580-0x000000018939C6F8
		public static Array Resize(this Array array, int newSize) => default; // 0x000000018939BDD4-0x000000018939BE90
	}

	public static class TypeConverter // TypeDefIndex: 48351
	{
		// Events
		public static event CustomConverter customConverter;
	
		// Nested types
		public delegate Func<object, object> CustomConverter(System.Type fromType, System.Type toType); // TypeDefIndex: 48348; 0x0000000181165340-0x0000000181165350
	
		// Methods
		public static Func<object, object> Get(System.Type fromType, System.Type toType) => default; // 0x00000001832FFC90-0x00000001832FFFC0
		public static bool CanConvert(System.Type fromType, System.Type toType) => default; // 0x00000001893AEB70-0x00000001893AEB88
	}

	public static class ColorUtils // TypeDefIndex: 48352
	{
		// Fields
		private static Dictionary<Color32, string> colorHexCache; // 0x00
		private static Dictionary<string, UnityEngine.Color> hexColorCache; // 0x08
		private static Dictionary<ValueTuple<int, int, Gradient, float>, Texture2D> gradientTextureCache; // 0x10
		private static Dictionary<ValueTuple<UnityEngine.Color, float, UnityEngine.Color, float>, Gradient> gradientCache; // 0x18
		private static Dictionary<string, Gradient> menuItemRibbonGradientCache; // 0x20
	
		// Constructors
		static ColorUtils() {} // 0x00000001831CBE20-0x00000001831CC090
	
		// Methods
		public static UnityEngine.Color Grey(float value) => default; // 0x0000000183D71F80-0x0000000183D71FA0
		public static string ColorToHex(Color32 color) => default; // 0x00000001893A2410-0x00000001893A2584
		public static UnityEngine.Color HexToColor(string hex) => default; // 0x0000000182C03E30-0x0000000182C04040
		public static Texture2D CreateGradientTexture(int width, int height, Gradient gradient, float rotateDegree) => default; // 0x00000001893A2584-0x00000001893A282C
		public static Gradient CreateGradient(UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio) => default; // 0x00000001893A282C-0x00000001893A2AB8
		public static Gradient GetMenuItemRibbonGradientOfNodeFullPath(string fullPath) => default; // 0x00000001893A2AB8-0x00000001893A2B3C
		public static void RegisterMenuItemRibbonGradientOfNodeFullPath(string fullPath, UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio) {} // 0x00000001893A2B3C-0x00000001893A2C14
	
		// Extension methods
		public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha) => default; // 0x0000000183D71FA0-0x0000000183D71FC0
	}

	public static class CurveUtils // TypeDefIndex: 48353
	{
		// Fields
		private const float POS_CHECK_RES = 100f; // Metadata: 0x01FBB80D
		private const float POS_CHECK_DISTANCE = 10f; // Metadata: 0x01FBB811
	
		// Methods
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t) => default; // 0x00000001893A2C14-0x00000001893A2D2C
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition) => default; // 0x00000001893A2D2C-0x00000001893A2D64
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm) {
			norm = default;
			return default;
		} // 0x00000001893A2D64-0x00000001893A2F44
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent) {
			fromTangent = default;
			toTangent = default;
		} // 0x00000001893A3138-0x00000001893A31F0
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent) {
			fromTangent = default;
			toTangent = default;
		} // 0x00000001893A2F44-0x00000001893A3138
	}

	public static class GUIStyleUtils // TypeDefIndex: 48354
	{
		// Extension methods
		public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom) => default; // 0x00000001893A8438-0x00000001893A84E4
		public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom) => default; // 0x00000001893A8590-0x00000001893A863C
		public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom) => default; // 0x00000001893A838C-0x00000001893A8438
		public static GUIStyle Overflow(this GUIStyle style, int left, int right, int top, int bottom) => default; // 0x00000001893A84E4-0x00000001893A8590
		public static GUIStyle TextAlignment(this GUIStyle style, TextAnchor anchor) => default; // 0x00000001893A8664-0x00000001893A868C
		public static GUIStyle RichText(this GUIStyle style, bool rich) => default; // 0x00000001893A863C-0x00000001893A8664
	}

	public static class LayerUtils // TypeDefIndex: 48355
	{
		// Methods
		public static LayerMask CreateFromNames(params string[] layerNames) => default; // 0x00000001893A97C8-0x00000001893A97D0
		public static LayerMask CreateFromNumbers(params int[] layerNumbers) => default; // 0x00000001893A97D0-0x00000001893A97D8
		public static LayerMask LayerNamesToMask(params string[] layerNames) => default; // 0x00000001893A97D8-0x00000001893A9834
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers) => default; // 0x00000001893A9834-0x00000001893A9874
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask mask) => default; // 0x0000000183D71FC0-0x0000000183D71FD0
		public static LayerMask AddToMask(this LayerMask mask, params string[] layerNames) => default; // 0x00000001893A96E8-0x00000001893A9708
		public static LayerMask RemoveFromMask(this LayerMask mask, params string[] layerNames) => default; // 0x00000001893A9A18-0x00000001893A9A3C
		public static bool ContainsAnyLayer(this LayerMask mask, params string[] layerNames) => default; // 0x00000001893A9768-0x00000001893A97C8
		public static bool ContainsAllLayers(this LayerMask mask, params string[] layerNames) => default; // 0x00000001893A9708-0x00000001893A9768
		public static string[] MaskToNames(this LayerMask mask) => default; // 0x00000001893A9874-0x00000001893A9950
		public static string MaskToString(this LayerMask mask) => default; // 0x00000001893A99DC-0x00000001893A9A18
		public static string MaskToString(this LayerMask mask, string delimiter) => default; // 0x00000001893A9950-0x00000001893A99DC
	}

	public static class ObjectUtils // TypeDefIndex: 48357
	{
		// Methods
		public static bool AnyEquals(object a, object b) => default; // 0x00000001893AB160-0x00000001893AB224
		public static IEnumerable<GameObject> FindGameObjectsWithinLayerMask(LayerMask mask, GameObject exclude = null) => default; // 0x00000001893AB224-0x00000001893AB320
	
		// Extension methods
		public static List<T> Shuffle<T>(this List<T> list) => default;
		public static bool Is<T>(this object o, out ref T result) {
			result = default;
			return default;
		}
		public static T GetAddComponent<T>(this GameObject gameObject)
			where T : Component => default;
		public static Component TransformToType(this Component current, System.Type type) => default; // 0x00000001893AB350-0x00000001893AB490
		public static bool IsInLayerMask(this GameObject gameObject, LayerMask mask) => default; // 0x00000001893AB320-0x00000001893AB350
	}

	public static class RectUtils // TypeDefIndex: 48358
	{
		// Methods
		public static Rect GetBoundRect(params Rect[] rects) => default; // 0x00000001893AB5C4-0x00000001893AB6E4
		public static Rect GetBoundRect(params Vector2[] positions) => default; // 0x00000001893AB6E4-0x00000001893AB7F4
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b) => default; // 0x00000001893AB490-0x00000001893AB4DC
		public static Rect ExpandBy(this Rect rect, float margin) => default; // 0x00000001893AB544-0x00000001893AB580
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin) => default; // 0x00000001893AB580-0x00000001893AB5C4
		public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom) => default; // 0x00000001893AB4DC-0x00000001893AB544
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer) => default; // 0x00000001893AB874-0x00000001893AB9AC
		public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer) => default; // 0x00000001893AB7F4-0x00000001893AB874
	}

	public static class StringUtils // TypeDefIndex: 48359
	{
		// Fields
		public const string SPACE = " "; // Metadata: 0x01FBB817
		public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Metadata: 0x01FBB819
		public static readonly char[] CHAR_SPACE_ARRAY; // 0x00
		private static Dictionary<string, string> splitCaseCache; // 0x08
	
		// Constructors
		static StringUtils() {} // 0x00000001893AE6F8-0x00000001893AE814
	
		// Methods
		public static string GetAlphabetLetter(int index) => default; // 0x00000001893AD88C-0x00000001893AD91C
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x01FBB815 */) => default; // 0x00000001893ADC2C-0x00000001893ADFC4
		public static bool SearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x01FBB816 */) => default; // 0x00000001893ADFC4-0x00000001893AE2F0
	
		// Extension methods
		public static string SplitCamelCase(this string s) => default; // 0x00000001893AE2F0-0x00000001893AE494
		public static string CapitalizeFirst(this string s) => default; // 0x00000001893AD79C-0x00000001893AD850
		public static string CapLength(this string s, int max) => default; // 0x00000001893AD728-0x00000001893AD79C
		public static string GetCapitals(this string s) => default; // 0x00000001893AD91C-0x00000001893ADA24
		public static string FormatError(this string input) => default; // 0x00000001893AD850-0x00000001893AD88C
		public static string GetStringWithinOuter(this string input, char from, char to) => default; // 0x00000001893ADAC8-0x00000001893ADB30
		public static string GetStringWithinInner(this string input, char from, char to) => default; // 0x00000001893ADA24-0x00000001893ADAC8
		public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process) => default; // 0x00000001893ADB30-0x00000001893ADC2C
		public static string ToStringAdvanced(this object o) => default; // 0x00000001893AE494-0x00000001893AE6F8
	}

	public class WeakReferenceList<T> // TypeDefIndex: 48360
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

	public class WeakReferenceTable<TKey, TValue> // TypeDefIndex: 48361
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
	public enum EaseType // TypeDefIndex: 48461
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

	public static class Easing // TypeDefIndex: 48462
	{
		// Methods
		public static float Ease(ParadoxNotion.Animation.EaseType type, float from, float to, float t) => default; // 0x00000001893BABBC-0x00000001893BAC40
		public static Vector3 Ease(ParadoxNotion.Animation.EaseType type, Vector3 from, Vector3 to, float t) => default; // 0x00000001893BAAD8-0x00000001893BABBC
		public static Quaternion Ease(ParadoxNotion.Animation.EaseType type, Quaternion from, Quaternion to, float t) => default; // 0x00000001893BAA14-0x00000001893BAAD8
		public static UnityEngine.Color Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t) => default; // 0x00000001893BAC40-0x00000001893BACFC
		public static Func<float, float> Function(ParadoxNotion.Animation.EaseType type) => default; // 0x00000001893BAECC-0x00000001893BB5FC
		public static float Linear(float t) => default; // 0x000000018350B670-0x000000018350B680
		public static float QuadraticIn(float t) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static float QuadraticOut(float t) => default; // 0x0000000183D721C0-0x0000000183D721E0
		public static float QuadraticInOut(float t) => default; // 0x00000001893BB5FC-0x00000001893BB658
		public static float QuarticIn(float t) => default; // 0x0000000183D721E0-0x0000000183D721F0
		public static float QuarticOut(float t) => default; // 0x0000000183D721F0-0x0000000183D72220
		public static float QuarticInOut(float t) => default; // 0x00000001893BB658-0x00000001893BB6AC
		public static float QuinticIn(float t) => default; // 0x0000000183D72220-0x0000000183D72240
		public static float QuinticOut(float t) => default; // 0x0000000183D72240-0x0000000183D72270
		public static float QuinticInOut(float t) => default; // 0x00000001893BB6AC-0x00000001893BB708
		public static float CubicIn(float t) => default; // 0x0000000183D525D0-0x0000000183D525E0
		public static float CubicOut(float t) => default; // 0x0000000183D720B0-0x0000000183D720D0
		public static float CubicInOut(float t) => default; // 0x00000001893BA9AC-0x00000001893BAA14
		public static float SinusoidalIn(float t) => default; // 0x00000001893BB708-0x00000001893BB738
		public static float SinusoidalOut(float t) => default; // 0x00000001893BB738-0x00000001893BB750
		public static float SinusoidalInOut(float t) => default; // 0x0000000183D72270-0x0000000183D722A0
		public static float ExponentialIn(float t) => default; // 0x00000001893BAE5C-0x00000001893BAE88
		public static float ExponentialOut(float t) => default; // 0x00000001893BAE88-0x00000001893BAECC
		public static float ExponentialInOut(float t) => default; // 0x00000001893BADDC-0x00000001893BAE5C
		public static float CircularIn(float t) => default; // 0x0000000183D72020-0x0000000183D72080
		public static float CircularOut(float t) => default; // 0x0000000183D72080-0x0000000183D720B0
		public static float CircularInOut(float t) => default; // 0x00000001893BA948-0x00000001893BA9AC
		public static float ElasticIn(float t) => default; // 0x0000000183D720D0-0x0000000183D72150
		public static float ElasticOut(float t) => default; // 0x0000000183D72150-0x0000000183D721C0
		public static float ElasticInOut(float t) => default; // 0x00000001893BACFC-0x00000001893BADDC
		public static float BounceIn(float t) => default; // 0x00000001893BA87C-0x00000001893BA8B0
		public static float BounceOut(float t) => default; // 0x00000001893BA8B0-0x00000001893BA948
		public static float BounceInOut(float t) => default; // 0x00000001893BA810-0x00000001893BA87C
		public static float BackIn(float t) => default; // 0x0000000183D71FD0-0x0000000183D71FF0
		public static float BackOut(float t) => default; // 0x0000000183D71FF0-0x0000000183D72020
		public static float BackInOut(float t) => default; // 0x00000001893BA7A8-0x00000001893BA810
	}
}

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class SpoofAOTAttribute : Attribute // TypeDefIndex: 48463
	{
		// Constructors
		public SpoofAOTAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class CancelSpoofAOTAttribute : Attribute // TypeDefIndex: 48464
	{
		// Constructors
		public CancelSpoofAOTAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DoNotListAttribute : Attribute // TypeDefIndex: 48465
	{
		// Constructors
		public DoNotListAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ProtectedSingletonAttribute : Attribute // TypeDefIndex: 48466
	{
		// Constructors
		public ProtectedSingletonAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ExecutionPriorityAttribute : Attribute // TypeDefIndex: 48467
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public ExecutionPriorityAttribute() {} // Dummy constructor
		public ExecutionPriorityAttribute(int priority) {} // 0x00000001810410F0-0x0000000181041100
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ExposeAsDefinitionAttribute : Attribute // TypeDefIndex: 48468
	{
		// Constructors
		public ExposeAsDefinitionAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ExposeFieldAttribute : Attribute // TypeDefIndex: 48469
	{
		// Constructors
		public ExposeFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class NodeCanvasOdinOnlyAttribute : Attribute // TypeDefIndex: 48470
	{
		// Constructors
		public NodeCanvasOdinOnlyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ListInspectorOptionAttribute : Attribute // TypeDefIndex: 48471
	{
		// Fields
		public readonly bool allowAdd; // 0x10
		public readonly bool allowRemove; // 0x11
		public readonly bool showFoldout; // 0x12
	
		// Constructors
		public ListInspectorOptionAttribute() {} // Dummy constructor
		public ListInspectorOptionAttribute(bool allowAdd, bool allowRemove, bool alwaysExpanded) {} // 0x0000000183D722A0-0x0000000183D722B0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class NameAttribute : Attribute // TypeDefIndex: 48472
	{
		// Fields
		public readonly string name; // 0x10
		public readonly int priority; // 0x18
	
		// Constructors
		public NameAttribute() {} // Dummy constructor
		public NameAttribute(string name, int priority = 0 /* Metadata: 0x01FBB89D */) {} // 0x00000001839E26A0-0x00000001839E26C0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 48473
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute() {} // Dummy constructor
		public CategoryAttribute(string category) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 48474
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute() {} // Dummy constructor
		public DescriptionAttribute(string description) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class IconAttribute : Attribute // TypeDefIndex: 48475
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly bool fixedColor; // 0x18
		public readonly string runtimeIconTypeCallback; // 0x20
		public readonly System.Type fromType; // 0x28
	
		// Constructors
		public IconAttribute() {} // Dummy constructor
		public IconAttribute(string iconName = "" /* Metadata: 0x01FBB89E */, bool fixedColor = false /* Metadata: 0x01FBB89F */, string runtimeIconTypeCallback = "" /* Metadata: 0x01FBB8A0 */) {} // 0x0000000183A411C0-0x0000000183A411F0
		public IconAttribute(System.Type fromType) {} // 0x0000000182C92F10-0x0000000182C92F20
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ColorAttribute : Attribute // TypeDefIndex: 48476
	{
		// Fields
		public readonly string hexColor; // 0x10
	
		// Constructors
		public ColorAttribute() {} // Dummy constructor
		public ColorAttribute(string hexColor) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class ColorGradientAttribute : Attribute // TypeDefIndex: 48477
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get => default; } // 0x00000001893BA6E0-0x00000001893BA744 
		public UnityEngine.Color colorRight { get => default; } // 0x00000001893BA744-0x00000001893BA7A8 
	
		// Constructors
		public ColorGradientAttribute() {} // Dummy constructor
		public ColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x01FBB8A1 */) {} // 0x00000001893BA69C-0x00000001893BA6E0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class NodeMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 48478
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get => default; } // 0x00000001893BE218-0x00000001893BE27C 
		public UnityEngine.Color colorRight { get => default; } // 0x00000001893BE27C-0x00000001893BE2E0 
	
		// Constructors
		public NodeMenuItemColorGradientAttribute() {} // Dummy constructor
		public NodeMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x01FBB8A5 */) {} // 0x00000001893BA69C-0x00000001893BA6E0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class NodeCategoryMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 48479
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get => default; } // 0x00000001893BE150-0x00000001893BE1B4 
		public UnityEngine.Color colorRight { get => default; } // 0x00000001893BE1B4-0x00000001893BE218 
	
		// Constructors
		public NodeCategoryMenuItemColorGradientAttribute() {} // Dummy constructor
		public NodeCategoryMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x01FBB8A9 */) {} // 0x00000001893BA69C-0x00000001893BA6E0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class HideAttribute : Attribute // TypeDefIndex: 48480
	{
		// Constructors
		public HideAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public abstract class DrawerAttribute : Attribute // TypeDefIndex: 48481
	{
		// Properties
		public virtual int priority { get; } // 0x0000000183D56910-0x0000000183D56920 
		public virtual bool isDecorator { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected DrawerAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HeaderAttribute : DrawerAttribute // TypeDefIndex: 48482
	{
		// Fields
		public readonly string title; // 0x10
	
		// Properties
		public override bool isDecorator { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public HeaderAttribute() {} // Dummy constructor
		public HeaderAttribute(string title) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DimIfDefaultAttribute : DrawerAttribute // TypeDefIndex: 48483
	{
		// Properties
		public override bool isDecorator { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override int priority { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public DimIfDefaultAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : DrawerAttribute // TypeDefIndex: 48484
	{
		// Fields
		public readonly string fieldName; // 0x10
		public readonly int checkValue; // 0x18
	
		// Properties
		public override bool isDecorator { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override int priority { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public ShowIfAttribute() {} // Dummy constructor
		public ShowIfAttribute(string fieldName, int checkValue) {} // 0x0000000182738A30-0x0000000182738A50
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredFieldAttribute : DrawerAttribute // TypeDefIndex: 48485
	{
		// Properties
		public override bool isDecorator { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override int priority { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public RequiredFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowButtonAttribute : DrawerAttribute // TypeDefIndex: 48486
	{
		// Fields
		public readonly string buttonTitle; // 0x10
		public readonly string methodName; // 0x18
	
		// Properties
		public override bool isDecorator { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override int priority { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public ShowButtonAttribute() {} // Dummy constructor
		public ShowButtonAttribute(string buttonTitle, string methodnameCallback) {} // 0x0000000182676770-0x00000001826767A0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : DrawerAttribute // TypeDefIndex: 48487
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Properties
		public override bool isDecorator { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override int priority { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Constructors
		public CallbackAttribute() {} // Dummy constructor
		public CallbackAttribute(string methodName) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class MinValueAttribute : DrawerAttribute // TypeDefIndex: 48488
	{
		// Fields
		public readonly float min; // 0x10
	
		// Properties
		public override int priority { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		public MinValueAttribute() {} // Dummy constructor
		public MinValueAttribute(float min) {} // 0x0000000183D50CA0-0x0000000183D50CB0
		public MinValueAttribute(int min) {} // 0x0000000183D722B0-0x0000000183D722C0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DelayedFieldAttribute : DrawerAttribute // TypeDefIndex: 48489
	{
		// Constructors
		public DelayedFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class LayerFieldAttribute : DrawerAttribute // TypeDefIndex: 48490
	{
		// Constructors
		public LayerFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class TagFieldAttribute : DrawerAttribute // TypeDefIndex: 48491
	{
		// Constructors
		public TagFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class TextAreaFieldAttribute : DrawerAttribute // TypeDefIndex: 48492
	{
		// Fields
		public readonly int numberOfLines; // 0x10
	
		// Constructors
		public TextAreaFieldAttribute() {} // Dummy constructor
		public TextAreaFieldAttribute(int numberOfLines) {} // 0x00000001810410F0-0x0000000181041100
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class PopupFieldAttribute : DrawerAttribute // TypeDefIndex: 48493
	{
		// Fields
		public readonly object[] options; // 0x10
	
		// Constructors
		public PopupFieldAttribute() {} // Dummy constructor
		public PopupFieldAttribute(params object[] options) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SliderFieldAttribute : DrawerAttribute // TypeDefIndex: 48494
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public SliderFieldAttribute() {} // Dummy constructor
		public SliderFieldAttribute(float min, float max) {} // 0x0000000183D5E2F0-0x0000000183D5E300
		public SliderFieldAttribute(int min, int max) {} // 0x0000000183D722C0-0x0000000183D722E0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ForceObjectFieldAttribute : DrawerAttribute // TypeDefIndex: 48495
	{
		// Constructors
		public ForceObjectFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class UndoUtility // TypeDefIndex: 48496
	{
		// Properties
		public static string lastOperationName { get; private set; } // 0x00000001893BEE60-0x00000001893BEE98 0x00000001893BEE98-0x00000001893BEEE8
	
		// Methods
		[Conditional("UNITY_EDITOR")]
		public static void RecordObject(UnityEngine.Object target, string name, bool forceIgnoreScene = false /* Metadata: 0x01FBB8AD */) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("UNITY_EDITOR")]
		public static void RecordObjectComplete(UnityEngine.Object target, string name, bool forceIgnore = false /* Metadata: 0x01FBB8AE */) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("UNITY_EDITOR")]
		public static void SetDirty(UnityEngine.Object target) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("UNITY_EDITOR")]
		public static void RecordObject(UnityEngine.Object target, string name, Action operation) {} // 0x00000001893BEE44-0x00000001893BEE60
		[Conditional("UNITY_EDITOR")]
		public static void RecordObjectComplete(UnityEngine.Object target, string name, Action operation) {} // 0x00000001893BEE44-0x00000001893BEE60
		public static string GetLastOperationNameOr(string operation) => default; // 0x00000001893BEE18-0x00000001893BEE44
		public static void CheckUndo(UnityEngine.Object target, string name) {} // 0x00000001893BED70-0x00000001893BEE18
		public static void CheckDirty(UnityEngine.Object target) {} // 0x00000001893BED30-0x00000001893BED70
	}
}

namespace ParadoxNotion.Serialization
{
	public class DeserializeFromAttribute : Attribute // TypeDefIndex: 48382
	{
		// Fields
		public readonly string previousTypeFullName; // 0x10
	
		// Constructors
		public DeserializeFromAttribute() {} // Dummy constructor
		public DeserializeFromAttribute(string previousTypeFullName) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor // TypeDefIndex: 48385
		where TMissing : TCanProcess, IMissingRecoverable
	{
		// Fields
		private const string FIELD_NAME_TYPE = "_missingType"; // Metadata: 0x01FBB837
		private const string FIELD_NAME_STATE = "_recoveryState"; // Metadata: 0x01FBB844
	
		// Constructors
		public fsRecoveryProcessor() {}
	
		// Methods
		public override bool CanProcess(System.Type type) => default;
		public override void OnBeforeDeserialize(System.Type storageType, ref fsData data) {}
	}

	public class fsUnityObjectConverter : fsConverter // TypeDefIndex: 48386
	{
		// Constructors
		public fsUnityObjectConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893B9AE8-0x00000001893B9B70
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893B9CE8-0x00000001893B9ED4
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001893B9B70-0x00000001893B9CE8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000181002730-0x0000000181002740
	}

	public interface IMissingRecoverable // TypeDefIndex: 48387
	{
		// Properties
		string missingType { get; set; }
		string recoveryState { get; set; }
	}

	public interface ISerializedMethodBaseInfo : ISerializedReflectedInfo // TypeDefIndex: 48388
	{
		// Methods
		MethodBase GetMethodBase();
		bool HasChanged();
	}

	public interface ISerializedReflectedInfo : ISerializationCallbackReceiver // TypeDefIndex: 48389
	{
		// Methods
		MemberInfo AsMemberInfo();
		string AsString();
	}

	public static class JSONSerializer // TypeDefIndex: 48390
	{
		// Fields
		public static bool enableCache; // 0x00
		private static object serializerLock; // 0x08
		private static fsSerializer serializer; // 0x10
		private static Dictionary<string, fsData> dataCache; // 0x18
	
		// Constructors
		static JSONSerializer() {} // 0x00000001835C4F80-0x00000001835C5000
	
		// Methods
		public static void FlushMem() {} // 0x00000001835C5000-0x00000001835C5130
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void __FlushDataCache() {} // 0x00000001835C5130-0x00000001835C51E0
		public static string Serialize(System.Type type, object instance, List<UnityEngine.Object> references = null, bool pretyJson = false /* Metadata: 0x01FBB853 */) => default; // 0x00000001893A910C-0x00000001893A956C
		public static T Deserialize<T>(string json, List<UnityEngine.Object> references = null) => default;
		public static object Deserialize(System.Type type, string json, List<UnityEngine.Object> references = null) => default; // 0x00000001893A8824-0x00000001893A888C
		public static T TryDeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> references = null)
			where T : class => default;
		public static object TryDeserializeOverwrite(object instance, string json, List<UnityEngine.Object> references = null) => default; // 0x00000001893A965C-0x00000001893A96E8
		private static object Internal_Deserialize(System.Type type, string json, List<UnityEngine.Object> references, object instance) => default; // 0x00000001893A888C-0x00000001893A8CD4
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object, fsData> call) {} // 0x00000001893A8CF0-0x00000001893A8ED4
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object> beforeCall, Action<object, fsData> afterCall) {} // 0x00000001893A8ED4-0x00000001893A910C
		public static T Clone<T>(T original) => default;
		public static object Clone(object original) => default; // 0x00000001893A868C-0x00000001893A8750
		public static void CopySerialized(object source, object target) {} // 0x00000001893A8750-0x00000001893A8824
		public static void ShowData(string json, string fileName = "" /* Metadata: 0x01FBB854 */) {} // 0x00000001893A956C-0x00000001893A965C
		public static string PrettifyJson(string json) => default; // 0x00000001893A8CD4-0x00000001893A8CF0
	}

	[Serializable]
	public sealed class SerializationPair // TypeDefIndex: 48391
	{
		// Fields
		public string _json; // 0x10
		public List<UnityEngine.Object> _references; // 0x18
	
		// Constructors
		public SerializationPair() {} // 0x00000001893AB9AC-0x00000001893ABA24
	}

	[Serializable]
	public class SerializedConstructorInfo : ISerializedMethodBaseInfo // TypeDefIndex: 48394
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[SerializeField]
		private string _paramsInfo; // 0x18
		[NonSerialized]
		private ConstructorInfo _constructor; // 0x20
		[NonSerialized]
		private bool _hasChanged; // 0x28
	
		// Constructors
		public SerializedConstructorInfo() {} // 0x000000018350B670-0x000000018350B680
		public SerializedConstructorInfo(ConstructorInfo constructor) {} // 0x00000001893AC084-0x00000001893AC098
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001893ABE04-0x00000001893AC084
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893ABAE0-0x00000001893ABE04
		public MemberInfo AsMemberInfo() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public MethodBase GetMethodBase() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public bool HasChanged() => default; // 0x0000000183D4ED50-0x0000000183D4ED60
		public string AsString() => default; // 0x00000001893ABA24-0x00000001893ABAD8
		public override string ToString() => default; // 0x00000001893ABAD8-0x00000001893ABAE0
		public static implicit operator ConstructorInfo(SerializedConstructorInfo value) => default; // 0x00000001893AC098-0x00000001893AC0A8
	}

	[Serializable]
	public class SerializedEventInfo : ISerializedReflectedInfo // TypeDefIndex: 48395
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private EventInfo _event; // 0x18
	
		// Constructors
		public SerializedEventInfo() {} // 0x000000018350B670-0x000000018350B680
		public SerializedEventInfo(EventInfo info) {} // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001893AC210-0x00000001893AC2CC
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893AC110-0x00000001893AC210
		public MemberInfo AsMemberInfo() => default; // 0x0000000181041090-0x00000001810410A0
		public string AsString() => default; // 0x00000001893AC0A8-0x00000001893AC108
		public override string ToString() => default; // 0x00000001893AC108-0x00000001893AC110
		public static implicit operator EventInfo(SerializedEventInfo value) => default; // 0x00000001893AC2CC-0x00000001893AC2DC
	}

	[Serializable]
	public class SerializedFieldInfo : ISerializedReflectedInfo // TypeDefIndex: 48396
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Reflection.FieldInfo _field; // 0x18
	
		// Constructors
		public SerializedFieldInfo() {} // 0x000000018350B670-0x000000018350B680
		public SerializedFieldInfo(System.Reflection.FieldInfo info) {} // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001893AC454-0x00000001893AC510
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893AC354-0x00000001893AC454
		public MemberInfo AsMemberInfo() => default; // 0x0000000181041090-0x00000001810410A0
		public string AsString() => default; // 0x00000001893AC2DC-0x00000001893AC34C
		public override string ToString() => default; // 0x00000001893AC34C-0x00000001893AC354
		public static implicit operator System.Reflection.FieldInfo(SerializedFieldInfo value) => default; // 0x00000001893AC2CC-0x00000001893AC2DC
	}

	[Serializable]
	public class SerializedMethodInfo : ISerializedMethodBaseInfo // TypeDefIndex: 48399
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[SerializeField]
		private string _paramsInfo; // 0x18
		[SerializeField]
		private string _genericArgumentsInfo; // 0x20
		[NonSerialized]
		private MethodInfo _method; // 0x28
		[NonSerialized]
		private bool _hasChanged; // 0x30
	
		// Constructors
		public SerializedMethodInfo() {} // 0x000000018350B670-0x000000018350B680
		public SerializedMethodInfo(MethodInfo method) {} // 0x00000001893ACFA4-0x00000001893ACFB8
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001893ACB50-0x00000001893ACFA4
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893AC5CC-0x00000001893ACB50
		public MemberInfo AsMemberInfo() => default; // 0x0000000183D4EAC0-0x0000000183D4EAD0
		public MethodBase GetMethodBase() => default; // 0x0000000183D4EAC0-0x0000000183D4EAD0
		public bool HasChanged() => default; // 0x0000000183D4EF60-0x0000000183D4EF70
		public string AsString() => default; // 0x00000001893AC510-0x00000001893AC5C4
		public override string ToString() => default; // 0x00000001893AC5C4-0x00000001893AC5CC
		public static implicit operator MethodInfo(SerializedMethodInfo value) => default; // 0x00000001893ACFB8-0x00000001893ACFC8
	}

	[Serializable]
	public class SerializedTypeInfo : ISerializedReflectedInfo // TypeDefIndex: 48400
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Type _type; // 0x18
	
		// Constructors
		public SerializedTypeInfo() {} // 0x000000018350B670-0x000000018350B680
		public SerializedTypeInfo(System.Type info) {} // 0x00000001892E7320-0x00000001892E734C
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001893AD030-0x00000001893AD0A0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893ACFC8-0x00000001893AD030
		public MemberInfo AsMemberInfo() => default; // 0x0000000181041090-0x00000001810410A0
		public string AsString() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public static implicit operator System.Type(SerializedTypeInfo value) => default; // 0x00000001893AC2CC-0x00000001893AC2DC
	}

	[Serializable]
	public class SerializedUnityEventInfo : ISerializedReflectedInfo // TypeDefIndex: 48401
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private MemberInfo _memberInfo; // 0x18
	
		// Properties
		public bool isStatic { get => default; } // 0x00000001893AD4F0-0x00000001893AD5C8 
		public System.Type memberType { get => default; } // 0x00000001893AD5C8-0x00000001893AD698 
	
		// Constructors
		public SerializedUnityEventInfo() {} // 0x000000018350B670-0x000000018350B680
		public SerializedUnityEventInfo(System.Reflection.FieldInfo info) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public SerializedUnityEventInfo(PropertyInfo info) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public SerializedUnityEventInfo(MemberInfo info) {} // 0x00000001893AD424-0x00000001893AD4F0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001893AD368-0x00000001893AD424
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001893AD118-0x00000001893AD368
		public MemberInfo AsMemberInfo() => default; // 0x0000000181041090-0x00000001810410A0
		public string AsString() => default; // 0x00000001893AD0A0-0x00000001893AD110
		public override string ToString() => default; // 0x00000001893AD110-0x00000001893AD118
		public static implicit operator System.Reflection.FieldInfo(SerializedUnityEventInfo value) => default; // 0x00000001893AD6E0-0x00000001893AD728
		public static implicit operator PropertyInfo(SerializedUnityEventInfo value) => default; // 0x00000001893AD698-0x00000001893AD6E0
	}
}

namespace ParadoxNotion.Serialization.FullSerializer
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 48402
	{
		// Fields
		public string MemberName; // 0x10
	
		// Constructors
		public fsForwardAttribute() {} // Dummy constructor
		public fsForwardAttribute(string memberName) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsWriteOnlyAttribute : Attribute // TypeDefIndex: 48403
	{
		// Constructors
		public fsWriteOnlyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsReadOnlyAttribute : Attribute // TypeDefIndex: 48404
	{
		// Constructors
		public fsReadOnlyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 48405
	{
		// Constructors
		public fsIgnoreAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsIgnoreInBuildAttribute : Attribute // TypeDefIndex: 48406
	{
		// Constructors
		public fsIgnoreInBuildAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsSerializeAsAttribute : Attribute // TypeDefIndex: 48407
	{
		// Fields
		public readonly string Name; // 0x10
	
		// Constructors
		public fsSerializeAsAttribute() {} // 0x000000018350B670-0x000000018350B680
		public fsSerializeAsAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateToAttribute : Attribute // TypeDefIndex: 48408
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public fsMigrateToAttribute() {} // Dummy constructor
		public fsMigrateToAttribute(System.Type targetType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateVersionsAttribute : Attribute // TypeDefIndex: 48409
	{
		// Fields
		public readonly System.Type[] previousTypes; // 0x10
	
		// Constructors
		public fsMigrateVersionsAttribute() {} // Dummy constructor
		public fsMigrateVersionsAttribute(params System.Type[] previousTypes) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class fsSerializeAsReference : Attribute // TypeDefIndex: 48410
	{
		// Constructors
		public fsSerializeAsReference() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class fsDeserializeOverwrite : Attribute // TypeDefIndex: 48411
	{
		// Constructors
		public fsDeserializeOverwrite() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsUninitialized : Attribute // TypeDefIndex: 48412
	{
		// Constructors
		public fsUninitialized() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class fsAutoInstance : Attribute // TypeDefIndex: 48413
	{
		// Fields
		public readonly bool makeInstance; // 0x10
	
		// Constructors
		public fsAutoInstance() {} // Dummy constructor
		public fsAutoInstance(bool makeInstance = true /* Metadata: 0x01FBB855 */) {} // 0x0000000183D4E960-0x0000000183D4E970
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 48414
	{
		// Fields
		public System.Type Converter; // 0x10
		public System.Type Processor; // 0x18
	
		// Constructors
		public fsObjectAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class fsBaseConverter // TypeDefIndex: 48416
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Constructors
		protected fsBaseConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893B030C-0x00000001893B0468
		public virtual bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001893B07A8-0x00000001893B0838
		public virtual bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001893B0838-0x00000001893B085C
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types) => default; // 0x00000001893B0468-0x00000001893B07A8
		protected fsResult CheckType(fsData data, fsDataType type) => default; // 0x00000001893B00F4-0x00000001893B030C
		protected fsResult CheckKey(fsData data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x00000001893AFEE0-0x00000001893AFF4C
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x00000001893AFF4C-0x00000001893B00F4
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value) => default;
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value) {
			value = default;
			return default;
		}
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 48417
	{
		// Constructors
		protected fsConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public class fsCyclicReferenceManager // TypeDefIndex: 48419
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 48418
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator() {} // 0x000000018350B670-0x000000018350B680
			static ObjectReferenceEqualityComparator() {} // 0x0000000183D1B290-0x0000000183D1B2F0
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000186DDEAAC-0x0000000186DDEAB4
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x0000000183D6E640-0x0000000183D6E650
		}
	
		// Constructors
		public fsCyclicReferenceManager() {} // 0x00000001835C5F40-0x00000001835C6040
	
		// Methods
		public void Clear() {} // 0x00000001893B08C0-0x00000001893B0930
		public bool Enter() => default; // 0x00000001893B0930-0x00000001893B0940
		public bool Exit() => default; // 0x00000001893B0940-0x00000001893B0A0C
		public object GetReferenceObject(int id) => default; // 0x00000001893B0AB4-0x00000001893B0BA4
		public void AddReferenceWithId(int id, object reference) {} // 0x00000001893B085C-0x00000001893B08C0
		public int GetReferenceId(object item) => default; // 0x00000001893B0A0C-0x00000001893B0AB4
		public bool IsReference(object item) => default; // 0x00000001893B0BA4-0x00000001893B0C14
		public void MarkSerialized(object item) {} // 0x00000001893B0C14-0x00000001893B0D44
	}

	public enum fsDataType // TypeDefIndex: 48420
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 48421
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get => default; } // 0x00000001893B1CD0-0x00000001893B1E2C 
		public bool IsNull { get => default; } // 0x00000001825EB8A0-0x00000001825EB8B0 
		public bool IsDouble { get => default; } // 0x00000001893B1BA8-0x00000001893B1BF4 
		public bool IsInt64 { get => default; } // 0x00000001893B1BF4-0x00000001893B1C40 
		public bool IsBool { get => default; } // 0x00000001893B1B18-0x00000001893B1B64 
		public bool IsString { get => default; } // 0x00000001893B1C84-0x00000001893B1CD0 
		public bool IsDictionary { get => default; } // 0x00000001893B1B64-0x00000001893B1BA8 
		public bool IsList { get => default; } // 0x00000001893B1C40-0x00000001893B1C84 
		public double AsDouble { get => default; } // 0x00000001893B1A28-0x00000001893B1A64 
		public long AsInt64 { get => default; } // 0x00000001893B1A64-0x00000001893B1AA0 
		public bool AsBool { get => default; } // 0x00000001893B19B0-0x00000001893B19EC 
		public string AsString { get => default; } // 0x00000001893B1ADC-0x00000001893B1B18 
		public Dictionary<string, fsData> AsDictionary { get => default; } // 0x00000001893B19EC-0x00000001893B1A28 
		public List<fsData> AsList { get => default; } // 0x00000001893B1AA0-0x00000001893B1ADC 
	
		// Constructors
		public fsData() {} // 0x00000001835ACAA0-0x00000001835ACAC0
		public fsData(bool boolean) {} // 0x00000001893B18F8-0x00000001893B1954
		public fsData(double f) {} // 0x00000001893B1954-0x00000001893B19B0
		public fsData(long i) {} // 0x00000001893B189C-0x00000001893B18F8
		public fsData(string str) {} // 0x000000018426FEE0-0x000000018426FEF0
		public fsData(Dictionary<string, fsData> dict) {} // 0x000000018426FEE0-0x000000018426FEF0
		public fsData(List<fsData> list) {} // 0x000000018426FEE0-0x000000018426FEF0
		static fsData() {} // 0x00000001893B1790-0x00000001893B189C
	
		// Methods
		public static fsData CreateDictionary() => default; // 0x00000001893B0E54-0x00000001893B0F48
		public static fsData CreateList() => default; // 0x00000001893B0F48-0x00000001893B0FE0
		public static fsData CreateList(int capacity) => default; // 0x00000001893B0FE0-0x00000001893B107C
		internal void BecomeDictionary() {} // 0x00000001893B0D44-0x00000001893B0DE8
		internal fsData Clone() => default; // 0x00000001893B0DE8-0x00000001893B0E54
		private T Cast<T>() => default;
		public override string ToString() => default; // 0x00000001893B1788-0x00000001893B1790
		public override bool Equals(object obj) => default; // 0x00000001893B107C-0x00000001893B10E0
		public bool Equals(fsData other) => default; // 0x00000001893B10E0-0x00000001893B1788
		public static bool operator ==(fsData a, fsData b) => default; // 0x00000001893B1E2C-0x00000001893B1EFC
		public static bool operator !=(fsData a, fsData b) => default; // 0x00000001893B1EFC-0x00000001893B1F50
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 48422
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 48423
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

	public static class fsGlobalConfig // TypeDefIndex: 48424
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
		static fsGlobalConfig() {} // 0x00000001893B1F50-0x00000001893B2188
	}

	public class fsJsonParser // TypeDefIndex: 48425
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		public fsJsonParser() {} // Dummy constructor
		private fsJsonParser(string input) {} // 0x00000001893B4144-0x00000001893B41D0
	
		// Methods
		private fsResult MakeFailure(string message) => default; // 0x00000001893B2284-0x00000001893B2410
		private bool TryMoveNext() => default; // 0x00000001893B2B54-0x00000001893B2B80
		private bool HasValue() => default; // 0x00000001893B21F4-0x00000001893B2200
		private bool HasValue(int offset) => default; // 0x00000001893B21C0-0x00000001893B21F4
		private char Character() => default; // 0x00000001893B2188-0x00000001893B2194
		private char Character(int offset) => default; // 0x00000001893B2194-0x00000001893B21C0
		private void SkipSpace() {} // 0x00000001893B2978-0x00000001893B2B54
		private bool IsHex(char c) => default; // 0x00000001893B2200-0x00000001893B2228
		private uint ParseSingleChar(char c1, uint multipliyer) => default; // 0x00000001893B2410-0x00000001893B2454
		private uint ParseUnicode(char c1, char c2, char c3, char c4) => default; // 0x00000001893B2454-0x00000001893B24D8
		private fsResult TryUnescapeChar(out char escaped) {
			escaped = default;
			return default;
		} // 0x00000001893B3C4C-0x00000001893B4144
		private fsResult TryParseExact(string content) => default; // 0x00000001893B2E38-0x00000001893B2F7C
		private fsResult TryParseTrue(out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B3B4C-0x00000001893B3C4C
		private fsResult TryParseFalse(out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B2F7C-0x00000001893B307C
		private fsResult TryParseNull(out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B307C-0x00000001893B3178
		private bool IsSeparator(char c) => default; // 0x00000001893B2228-0x00000001893B2284
		private fsResult TryParseNumber(out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B3178-0x00000001893B348C
		private fsResult TryParseString(out string str) {
			str = default;
			return default;
		} // 0x00000001893B3894-0x00000001893B3B4C
		private fsResult TryParseArray(out fsData arr) {
			arr = default;
			return default;
		} // 0x00000001893B2B80-0x00000001893B2E38
		private fsResult TryParseObject(out fsData obj) {
			obj = default;
			return default;
		} // 0x00000001893B348C-0x00000001893B3894
		private fsResult RunParse(out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B2634-0x00000001893B2978
		public static fsResult Parse(string input, out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B254C-0x00000001893B2634
		public static fsData Parse(string input) => default; // 0x00000001893B24D8-0x00000001893B254C
	}

	public static class fsJsonPrinter // TypeDefIndex: 48426
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count) {} // 0x00000001893B5448-0x00000001893B54B4
		private static string EscapeString(string str) => default; // 0x00000001893B5188-0x00000001893B5448
		private static void BuildCompressedString(fsData data, TextWriter stream) {} // 0x00000001893B41D0-0x00000001893B47A8
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth) {} // 0x00000001893B47A8-0x00000001893B4EE8
		public static string ToJson(fsData data, bool pretty) => default; // 0x00000001893B5620-0x00000001893B5644
		public static void PrettyJson(fsData data, TextWriter outputStream) {} // 0x00000001893B54B4-0x00000001893B54C0
		public static string PrettyJson(fsData data) => default; // 0x00000001893B54C0-0x00000001893B5620
		public static void CompressedJson(fsData data, StreamWriter outputStream) {} // 0x00000001893B5044-0x00000001893B504C
		public static string CompressedJson(fsData data) => default; // 0x00000001893B4EE8-0x00000001893B5044
		private static string ConvertDoubleToString(double d) => default; // 0x00000001893B504C-0x00000001893B5188
	}

	public class fsMetaProperty // TypeDefIndex: 48427
	{
		// Properties
		public System.Reflection.FieldInfo Field { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string JsonName { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public System.Type StorageType { get => default; } // 0x00000001891B3B34-0x00000001891B3B58 
		public string MemberName { get => default; } // 0x00000001893B57E4-0x00000001893B5808 
		public bool ReadOnly { get; private set; } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public bool WriteOnly { get; private set; } // 0x0000000183D4F070-0x0000000183D4F080 0x0000000183D4F080-0x0000000183D4F090
		public bool AutoInstance { get; private set; } // 0x0000000183D4F740-0x0000000183D4F750 0x0000000183D4F750-0x0000000183D4F760
		public bool AsReference { get; private set; } // 0x0000000183D56CC0-0x0000000183D56CD0 0x0000000183D56CE0-0x0000000183D56CF0
	
		// Constructors
		public fsMetaProperty() {} // Dummy constructor
		internal fsMetaProperty(System.Reflection.FieldInfo field) {} // 0x00000001893B5644-0x00000001893B57E4
	
		// Methods
		public object Read(object context) => default; // 0x000000018781FB74-0x000000018781FB98
		public void Write(object context, object value) {} // 0x0000000186876BD8-0x0000000186876BF8
	}

	public class fsMetaType // TypeDefIndex: 48431
	{
		// Fields
		private static Dictionary<System.Type, fsMetaType> _metaTypes; // 0x00
		private static Dictionary<System.Type, object> _defaultInstances; // 0x08
		private ObjectGenerator generator; // 0x10
	
		// Properties
		public System.Type reflectedType { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public fsMetaProperty[] Properties { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool DeserializeOverwriteRequest { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
	
		// Nested types
		private delegate object ObjectGenerator(); // TypeDefIndex: 48428; 0x0000000186F0A8DC-0x0000000186F0A8EC
	
		// Constructors
		public fsMetaType() {} // Dummy constructor
		private fsMetaType(System.Type reflectedType) {} // 0x00000001893B62B0-0x00000001893B6398
		static fsMetaType() {} // 0x00000001835C52F0-0x00000001835C53E0
	
		// Methods
		public static fsMetaType Get(System.Type type) => default; // 0x00000001893B6120-0x00000001893B6218
		public static void FlushMem() {} // 0x00000001835C51E0-0x00000001835C52F0
		private static void CollectProperties(List<fsMetaProperty> properties, System.Type reflectedType) {} // 0x00000001893B5A58-0x00000001893B5BF8
		public static bool CanSerializeField(System.Reflection.FieldInfo field) => default; // 0x00000001893B5808-0x00000001893B5A58
		private static ObjectGenerator GetGenerator(System.Type reflectedType) => default; // 0x00000001893B5DB0-0x00000001893B6120
		private static bool HasDefaultConstructor(System.Type reflectedType) => default; // 0x00000001893B6218-0x00000001893B62B0
		public object GetDefaultInstance() => default; // 0x00000001893B5CBC-0x00000001893B5DB0
		public object CreateInstance() => default; // 0x00000001893B5BF8-0x00000001893B5CBC
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 48432
	{
		// Constructors
		protected fsObjectProcessor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual bool CanProcess(System.Type type) => default; // 0x00000001893B6398-0x00000001893B63E4
		public virtual void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x000000018350B670-0x000000018350B680
	}

	public struct fsResult // TypeDefIndex: 48433
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public bool Succeeded { get => default; } // 0x0000000183D51020-0x0000000183D51030 
		public bool HasWarnings { get => default; } // 0x00000001893B6BBC-0x00000001893B6C08 
		public Exception AsException { get => default; } // 0x00000001893B69C4-0x00000001893B6ADC 
		public IEnumerable<string> RawMessages { get => default; } // 0x00000001893B6C08-0x00000001893B6C60 
		public string FormattedMessages { get => default; } // 0x00000001893B6ADC-0x00000001893B6BBC 
	
		// Constructors
		static fsResult() {
			EmptyStringArray = default;
			Success = default;
		} // 0x00000001893B6924-0x00000001893B69C4
	
		// Methods
		public static fsResult Warn(string warning) => default; // 0x00000001893B6874-0x00000001893B6924
		public static fsResult Fail(string warning) => default; // 0x00000001893B6698-0x00000001893B6744
		public void AddMessage(string message) {} // 0x00000001893B63E4-0x00000001893B6494
		public void AddMessages(fsResult result) {} // 0x00000001893B6494-0x00000001893B654C
		private fsResult Merge(fsResult other) => default; // 0x00000001893B6744-0x00000001893B6828
		public static fsResult operator +(fsResult a, fsResult b) => default; // 0x00000001893B6C60-0x00000001893B6CD8
		public fsResult AssertSuccess() => default; // 0x00000001893B660C-0x00000001893B6698
		public fsResult AssertSuccessWithoutWarnings() => default; // 0x00000001893B654C-0x00000001893B660C
		public override string ToString() => default; // 0x00000001893B6828-0x00000001893B6874
	}

	public class fsSerializer // TypeDefIndex: 48436
	{
		// Fields
		public const string KEY_OBJECT_REFERENCE = "$ref"; // Metadata: 0x01FBB85D
		public const string KEY_OBJECT_DEFINITION = "$id"; // Metadata: 0x01FBB862
		public const string KEY_INSTANCE_TYPE = "$type"; // Metadata: 0x01FBB866
		public const string KEY_VERSION = "$version"; // Metadata: 0x01FBB86C
		public const string KEY_CONTENT = "$content"; // Metadata: 0x01FBB875
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
	
		// Properties
		public List<UnityEngine.Object> ReferencesDatabase { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public bool IgnoreSerializeCycleReferences { get; set; } // 0x0000000183D4F3F0-0x0000000183D4F400 0x0000000183D4F440-0x0000000183D4F450
	
		// Events
		public event Action<object> onBeforeObjectSerialized;
		public event Action<object, fsData> onAfterObjectSerialized;
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 48434
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter() {} // 0x00000001835C5E80-0x00000001835C5F40
	
			// Methods
			public void WriteDefinition(int id, fsData data) {} // 0x00000001893C1D24-0x00000001893C1E58
			public void WriteReference(int id, Dictionary<string, fsData> dict) {} // 0x00000001893C1E58-0x00000001893C201C
			public void Clear() {} // 0x00000001893C1CBC-0x00000001893C1D24
		}
	
		// Constructors
		public fsSerializer() {} // 0x00000001835C53E0-0x00000001835C5B30
	
		// Methods
		public static bool IsReservedKeyword(string key) => default; // 0x00000001893B82C4-0x00000001893B8394
		public static void RemoveMetaData(ref fsData data) {} // 0x00000001893B8570-0x00000001893B86DC
		private static void EnsureDictionary(ref fsData data) {} // 0x00000001893B6CD8-0x00000001893B6D80
		private static bool IsObjectReference(fsData data) => default; // 0x00000001893B8248-0x00000001893B82C4
		private static bool IsObjectDefinition(fsData data) => default; // 0x00000001893B81CC-0x00000001893B8248
		private static bool IsVersioned(fsData data) => default; // 0x00000001893B8410-0x00000001893B848C
		private static bool IsTypeSpecified(fsData data) => default; // 0x00000001893B8394-0x00000001893B8410
		private static bool IsWrappedData(fsData data) => default; // 0x00000001893B848C-0x00000001893B8508
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x00000001893B80E4-0x00000001893B81CC
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x00000001893B7F00-0x00000001893B7F6C
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data) {} // 0x00000001893B802C-0x00000001893B80E4
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x00000001893B7F6C-0x00000001893B802C
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x00000001893B7E18-0x00000001893B7F00
		public void PurgeTemporaryData() {} // 0x00000001893B8508-0x00000001893B8570
		private List<fsObjectProcessor> GetProcessors(System.Type type) => default; // 0x00000001893B70E0-0x00000001893B7364
		public void AddConverter(fsBaseConverter converter) {} // 0x00000001835C5B30-0x00000001835C5C70
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) => default; // 0x00000001893B6D80-0x00000001893B70E0
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x00000001893B95F0-0x00000001893B962C
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType) {
			data = default;
			return default;
		} // 0x00000001893B962C-0x00000001893B98B8
		private fsResult Internal_Serialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType) {
			data = default;
			return default;
		} // 0x00000001893B7A9C-0x00000001893B7E18
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result) => default; // 0x00000001893B8F18-0x00000001893B8F54
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType) => default; // 0x00000001893B8F54-0x00000001893B911C
		private fsResult Internal_Deserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType) => default; // 0x00000001893B7364-0x00000001893B7A9C
		private void TryPush(object o) {} // 0x00000001893B925C-0x00000001893B9490
		private void TryPop(object o) {} // 0x00000001893B911C-0x00000001893B925C
		private void TrySerializeVersioning(object currentInstance, ref fsData data) {} // 0x00000001893B9490-0x00000001893B95F0
		private void TryDeserializeVersioning(ref object currentInstance, ref fsData currentData) {} // 0x00000001893B8D9C-0x00000001893B8F18
		private void TryDeserializeMigration(ref object currentInstance, ref fsData currentData, System.Type previousType, object previousInstance) {} // 0x00000001893B86DC-0x00000001893B8D9C
	}

	public interface IMigratable // TypeDefIndex: 48437
	{
	}

	public interface IMigratable<T> : IMigratable // TypeDefIndex: 48438
	{
		// Methods
		void Migrate(T model);
	}

	public interface ISerializationCollector : ISerializationCollectable // TypeDefIndex: 48439
	{
		// Methods
		void OnPush(ISerializationCollector parent);
		void OnCollect(ISerializationCollectable child, int depth);
		void OnPop(ISerializationCollector parent);
	}

	public interface ISerializationCollectable // TypeDefIndex: 48440
	{
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 48441
	{
		// Constructors
		public fsArrayConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893BF984-0x00000001893BF9A4
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893BFC64-0x00000001893BFE40
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001893BF9FC-0x00000001893BFC64
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BF9A4-0x00000001893BF9FC
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 48442
	{
		// Constructors
		public fsDictionaryConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893BFE40-0x00000001893BFED4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BFED4-0x00000001893BFF2C
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C072C-0x00000001893C0C94
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x00000001893BFF2C-0x00000001893C072C
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 48443
	{
		// Constructors
		public fsEnumConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893C0C94-0x00000001893C0CB4
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893C0CB4-0x00000001893C0D28
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C107C-0x00000001893C1718
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001893C0D28-0x00000001893C107C
		private static bool ArrayContains<T>(T[] values, T value) => default;
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 48444
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter() {} // Dummy constructor
		public fsForwardConverter(fsForwardAttribute attribute) {} // 0x00000001893C1C98-0x00000001893C1CBC
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893C1718-0x00000001893C1774
		private fsResult GetProperty(object instance, out fsMetaProperty property) {
			property = default;
			return default;
		} // 0x00000001893C17CC-0x00000001893C19A0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C1B2C-0x00000001893C1C98
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001893C19A0-0x00000001893C1B2C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893C1774-0x00000001893C17CC
	}

	public class fsListConverter : fsConverter // TypeDefIndex: 48445
	{
		// Constructors
		public fsListConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893C201C-0x00000001893C20B0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893C20B0-0x00000001893C2108
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C24EC-0x00000001893C2768
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x00000001893C2108-0x00000001893C24EC
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 48446
	{
		// Constructors
		public fsPrimitiveConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893C2768-0x00000001893C2818
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		private static bool UseBool(System.Type type) => default; // 0x00000001893C33F8-0x00000001893C345C
		private static bool UseInt64(System.Type type) => default; // 0x00000001893C3520-0x00000001893C36DC
		private static bool UseDouble(System.Type type) => default; // 0x00000001893C345C-0x00000001893C3520
		private static bool UseString(System.Type type) => default; // 0x00000001893C36DC-0x00000001893C3774
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C2E44-0x00000001893C33F8
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x00000001893C2818-0x00000001893C2E44
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 48447
	{
		// Constructors
		public fsReflectedConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893C3774-0x00000001893C3808
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C3BE8-0x00000001893C3F28
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001893C3860-0x00000001893C3BE8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893C3808-0x00000001893C3860
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 48448
	{
		// Constructors
		public fsTypeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893C3F28-0x00000001893C3FA0
		public override bool RequestCycleSupport(System.Type type) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type type) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x00000001893C40E8-0x00000001893C4EAC
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x00000001893C3FA0-0x00000001893C40E8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000183D553C0-0x0000000183D553D0
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 48449
	{
		// Constructors
		public AnimationCurve_DirectConverter() {} // 0x00000001835C5C70-0x00000001835C5CA0
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BA15C-0x00000001893BA330
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model) => default; // 0x00000001893B9F24-0x00000001893BA15C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893B9ED4-0x00000001893B9F24
	}

	public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 48450
	{
		// Constructors
		public Bounds_DirectConverter() {} // 0x00000001835C5CA0-0x00000001835C5CD0
	
		// Methods
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BA528-0x00000001893BA69C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model) => default; // 0x00000001893BA384-0x00000001893BA528
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BA330-0x00000001893BA384
	}

	public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 48451
	{
		// Constructors
		public Gradient_DirectConverter() {} // 0x00000001835C5D30-0x00000001835C5D60
	
		// Methods
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BD718-0x00000001893BD8A4
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model) => default; // 0x00000001893BD550-0x00000001893BD718
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BD500-0x00000001893BD550
	}

	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState> // TypeDefIndex: 48452
	{
		// Constructors
		public GUIStyleState_DirectConverter() {} // 0x00000001835C5CD0-0x00000001835C5D00
	
		// Methods
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BB980-0x00000001893BBB1C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model) => default; // 0x00000001893BB7A0-0x00000001893BB980
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BB750-0x00000001893BB7A0
	}

	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 48453
	{
		// Constructors
		public GUIStyle_DirectConverter() {} // 0x00000001835C5D00-0x00000001835C5D30
	
		// Methods
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BCA3C-0x00000001893BD500
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model) => default; // 0x00000001893BBB6C-0x00000001893BCA3C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BBB1C-0x00000001893BBB6C
	}

	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 48454
	{
		// Constructors
		public Keyframe_DirectConverter() {} // 0x00000001835C5D60-0x00000001835C5D90
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BDCD0-0x00000001893BDF24
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model) => default; // 0x00000001893BDA38-0x00000001893BDCD0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BD9E0-0x00000001893BDA38
	}

	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 48455
	{
		// Constructors
		public LayerMask_DirectConverter() {} // 0x00000001835C5D90-0x00000001835C5DC0
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BE068-0x00000001893BE150
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model) => default; // 0x00000001893BDF64-0x00000001893BE068
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BDF24-0x00000001893BDF64
	}

	public class RectOffset_DirectConverter : fsDirectConverter<RectOffset> // TypeDefIndex: 48456
	{
		// Constructors
		public RectOffset_DirectConverter() {} // 0x00000001835C5DC0-0x00000001835C5DF0
	
		// Methods
		protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BE5CC-0x00000001893BE7DC
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model) => default; // 0x00000001893BE330-0x00000001893BE5CC
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BE2E0-0x00000001893BE330
	}

	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 48457
	{
		// Constructors
		public Rect_DirectConverter() {} // 0x00000001835C5DF0-0x00000001835C5E20
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BEA78-0x00000001893BEC78
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model) => default; // 0x00000001893BE81C-0x00000001893BEA78
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BE7DC-0x00000001893BE81C
	}

	public class Vector2Int_DirectConverter : fsDirectConverter<Vector2Int> // TypeDefIndex: 48458
	{
		// Constructors
		public Vector2Int_DirectConverter() {} // 0x00000001835C5E20-0x00000001835C5E50
	
		// Methods
		protected override fsResult DoSerialize(Vector2Int model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BF02C-0x00000001893BF110
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2Int model) => default; // 0x00000001893BEF28-0x00000001893BF02C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BEEE8-0x00000001893BEF28
	}

	public class Vector2_DirectConverter : fsDirectConverter<Vector2> // TypeDefIndex: 48459
	{
		// Constructors
		public Vector2_DirectConverter() {} // 0x00000001893BF354-0x00000001893BF37C
	
		// Methods
		protected override fsResult DoSerialize(Vector2 model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BF270-0x00000001893BF354
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2 model) => default; // 0x00000001893BF15C-0x00000001893BF270
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BF110-0x00000001893BF15C
	}

	public class Vector3Int_DirectConverter : fsDirectConverter<Vector3Int> // TypeDefIndex: 48460
	{
		// Constructors
		public Vector3Int_DirectConverter() {} // 0x00000001835C5E50-0x00000001835C5E80
	
		// Methods
		protected override fsResult DoSerialize(Vector3Int model, Dictionary<string, fsData> serialized) => default; // 0x00000001893BF504-0x00000001893BF614
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector3Int model) => default; // 0x00000001893BF3CC-0x00000001893BF504
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x00000001893BF37C-0x00000001893BF3CC
	}
}

namespace ParadoxNotion.Services
{
	public class EventRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IDropHandler // TypeDefIndex: 48365
	{
		// Fields
		private EventRouterAnimatorMove _routerAnimatorMove; // 0x18
	
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
		public delegate void EventDelegate(ParadoxNotion.EventData msg); // TypeDefIndex: 48362; 0x00000001820ABE30-0x00000001820ABE60
	
		public delegate void EventDelegate<T>(ParadoxNotion.EventData<T> msg); // TypeDefIndex: 48363; 0x00000000-0x00000000
	
		public delegate void CustomEventDelegate(string name, ParadoxNotion.IEventData data); // TypeDefIndex: 48364; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		public EventRouter() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {} // 0x00000001893A4B5C-0x00000001893A4C10
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {} // 0x00000001893A4C10-0x00000001893A4CC4
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData) {} // 0x00000001893A4AA8-0x00000001893A4B5C
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {} // 0x00000001893A4CC4-0x00000001893A4D78
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x00000001893A49F4-0x00000001893A4AA8
		void IDragHandler.OnDrag(PointerEventData eventData) {} // 0x00000001893A47D4-0x00000001893A4888
		void IDropHandler.OnDrop(PointerEventData eventData) {} // 0x00000001893A4888-0x00000001893A493C
		void IScrollHandler.OnScroll(PointerEventData eventData) {} // 0x00000001893A4D78-0x00000001893A4E2C
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData) {} // 0x00000001893A4F9C-0x00000001893A5050
		void ISelectHandler.OnSelect(BaseEventData eventData) {} // 0x00000001893A4E2C-0x00000001893A4EE0
		void IDeselectHandler.OnDeselect(BaseEventData eventData) {} // 0x00000001893A4720-0x00000001893A47D4
		void IMoveHandler.OnMove(AxisEventData eventData) {} // 0x00000001893A493C-0x00000001893A49F4
		void ISubmitHandler.OnSubmit(BaseEventData eventData) {} // 0x00000001893A4EE0-0x00000001893A4F9C
		private void OnMouseDown() {} // 0x00000001893A3DDC-0x00000001893A3E5C
		private void OnMouseDrag() {} // 0x00000001893A3E5C-0x00000001893A3EDC
		private void OnMouseEnter() {} // 0x00000001893A3EDC-0x00000001893A3F5C
		private void OnMouseExit() {} // 0x00000001893A3F5C-0x00000001893A3FDC
		private void OnMouseOver() {} // 0x00000001893A3FDC-0x00000001893A405C
		private void OnMouseUp() {} // 0x00000001893A405C-0x00000001893A40DC
		private void OnEnable() {} // 0x00000001893A3D5C-0x00000001893A3DDC
		private void OnDisable() {} // 0x00000001893A3C5C-0x00000001893A3CDC
		private void OnDestroy() {} // 0x00000001893A3BDC-0x00000001893A3C5C
		private void OnTransformChildrenChanged() {} // 0x00000001893A41B8-0x00000001893A4238
		private void OnTransformParentChanged() {} // 0x00000001893A4238-0x00000001893A42B8
		private void OnAnimatorIK(int layerIndex) {} // 0x00000001893A34F8-0x00000001893A35B4
		private void OnBecameInvisible() {} // 0x00000001893A35B4-0x00000001893A3634
		private void OnBecameVisible() {} // 0x00000001893A3634-0x00000001893A36B4
		private void OnControllerColliderHit(ControllerColliderHit hit) {} // 0x00000001893A3B1C-0x00000001893A3BDC
		private void OnParticleCollision(GameObject other) {} // 0x00000001893A40DC-0x00000001893A419C
		private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {} // 0x00000001893A3770-0x00000001893A382C
		private void OnCollisionExit(UnityEngine.Collision collisionInfo) {} // 0x00000001893A38E8-0x00000001893A39A4
		private void OnCollisionStay(UnityEngine.Collision collisionInfo) {} // 0x00000001893A3A60-0x00000001893A3B1C
		private void OnCollisionEnter2D(Collision2D collisionInfo) {} // 0x00000001893A36B4-0x00000001893A3770
		private void OnCollisionExit2D(Collision2D collisionInfo) {} // 0x00000001893A382C-0x00000001893A38E8
		private void OnCollisionStay2D(Collision2D collisionInfo) {} // 0x00000001893A39A4-0x00000001893A3A60
		private void OnTriggerEnter(Collider other) {} // 0x00000001893A4374-0x00000001893A4430
		private void OnTriggerExit(Collider other) {} // 0x00000001893A44EC-0x00000001893A45A8
		private void OnTriggerStay(Collider other) {} // 0x00000001893A4664-0x00000001893A4720
		private void OnTriggerEnter2D(Collider2D other) {} // 0x00000001893A42B8-0x00000001893A4374
		private void OnTriggerExit2D(Collider2D other) {} // 0x00000001893A4430-0x00000001893A44EC
		private void OnTriggerStay2D(Collider2D other) {} // 0x00000001893A45A8-0x00000001893A4664
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00000001893A419C-0x00000001893A41B8
		private void OnDrawGizmos() {} // 0x00000001893A3CDC-0x00000001893A3D5C
		public void InvokeCustomEvent(string name, object value, object sender) {} // 0x00000001893A3414-0x00000001893A34F8
		public void InvokeCustomEvent<T>(string name, T value, object sender) {}
	}

	public class EventRouterAnimatorMove : MonoBehaviour // TypeDefIndex: 48366
	{
		// Events
		public event EventRouter.EventDelegate onAnimatorMove;
	
		// Constructors
		public EventRouterAnimatorMove() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnAnimatorMove() {} // 0x00000001893A3270-0x00000001893A32EC
	}

	public static class Logger // TypeDefIndex: 48369
	{
		// Fields
		private static List<LogHandler> subscribers; // 0x00
	
		// Nested types
		public struct Message // TypeDefIndex: 48367
		{
			// Fields
			private WeakReference<object> _contextRef; // 0x00
			public UnityEngine.LogType type; // 0x08
			public string text; // 0x10
			public string tag; // 0x18
	
			// Properties
			public object context { get => default; set {} } // 0x00000001893AA580-0x00000001893AA5DC 0x00000001893AA5DC-0x00000001893AA660
	
			// Methods
			public bool IsValid() => default; // 0x0000000182B74620-0x0000000182B74640
		}
	
		public delegate bool LogHandler(Message message); // TypeDefIndex: 48368; 0x000000018500CBFC-0x000000018500CC2C
	
		// Constructors
		static Logger() {} // 0x00000001893AA4F4-0x00000001893AA580
	
		// Methods
		public static void AddListener(LogHandler callback) {} // 0x00000001893A9ABC-0x00000001893A9B2C
		public static void RemoveListener(LogHandler callback) {} // 0x00000001893AA484-0x00000001893AA4F4
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void Log(object message, string tag = null, object context = null) {} // 0x00000001893AA418-0x00000001893AA484
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(object message, string tag = null, object context = null) {} // 0x00000001893AA3AC-0x00000001893AA418
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogError(object message, string tag = null, object context = null) {} // 0x00000001893AA2D4-0x00000001893AA340
		public static void LogException(Exception exception, string tag = null, object context = null) {} // 0x00000001893AA340-0x00000001893AA3AC
		private static void Internal_Log(UnityEngine.LogType type, object message, string tag, object context) {} // 0x00000001893A9C80-0x00000001893AA2D4
		private static void ForwardToUnity(UnityEngine.LogType type, object message, string tag, object context) {} // 0x00000001893A9B2C-0x00000001893A9C80
	}

	public class MonoManager : MonoBehaviour // TypeDefIndex: 48371
	{
		// Fields
		private static bool isQuiting; // 0x00
		private static MonoManager _current; // 0x08
	
		// Properties
		public static MonoManager current { get => default; } // 0x00000001893AAC44-0x00000001893AADF0 
	
		// Events
		public event Action onUpdate;
		public event Action onLateUpdate;
		public event Action onFixedUpdate;
		public event Action onApplicationQuit;
		public event Action<bool> onApplicationPause;
		public event Action onGUI;
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 48370
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}
	
		// Constructors
		public MonoManager() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Purge() {} // 0x0000000183D44220-0x0000000183D44260
		public static void Create() {} // 0x00000001893AA7B4-0x00000001893AA808
		public void AddUpdateCall(UpdateMode mode, Action call) {} // 0x00000001893AA660-0x00000001893AA6A4
		public void RemoveUpdateCall(UpdateMode mode, Action call) {} // 0x00000001893AA890-0x00000001893AA8D4
		protected void Awake() {} // 0x00000001893AA6A4-0x00000001893AA7B4
		protected void OnApplicationQuit() {} // 0x00000001893AA844-0x00000001893AA890
		protected void OnApplicationPause(bool isPause) {} // 0x00000001893AA830-0x00000001893AA844
		protected void Update() {} // 0x0000000183180DF0-0x0000000183180E10
		protected void LateUpdate() {} // 0x00000001893AA81C-0x00000001893AA830
		protected void FixedUpdate() {} // 0x00000001893AA808-0x00000001893AA81C
	}

	public static class Threader // TypeDefIndex: 48381
	{
		// Properties
		public static bool applicationIsPlaying { get; private set; } // 0x00000001893AEAA0-0x00000001893AEAF0 0x00000001893AEB1C-0x00000001893AEB70
		public static bool isMainThread { get; } // 0x00000001893AEAF0-0x00000001893AEB1C 
	
		// Constructors
		static Threader() {} // 0x00000001893AEA98-0x00000001893AEAA0
	
		// Methods
		public static void ManuallySyncIsPlaying() {} // 0x00000001893AE8A0-0x00000001893AE8F0
		public static Thread StartAction(Thread thread, Action function, Action callback = null) => default; // 0x00000001893AE8F0-0x00000001893AEA24
		public static Thread StartAction<T1>(Thread thread, Action<T1> function, T1 parameter1, Action callback = null) => default;
		public static Thread StartAction<T1, T2>(Thread thread, Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null) => default;
		public static Thread StartAction<T1, T2, T3>(Thread thread, Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null) => default;
		public static Thread StartFunction<TResult>(Thread thread, Func<TResult> function, Action<TResult> callback = null) => default;
		public static Thread StartFunction<TResult, T1>(Thread thread, Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null) => default;
		public static Thread StartFunction<TResult, T1, T2>(Thread thread, Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null) => default;
		public static Thread StartFunction<TResult, T1, T2, T3>(Thread thread, Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null) => default;
		private static void Begin(Thread thread, Action callback) {} // 0x00000001893AE814-0x00000001893AE8A0
		[IteratorStateMachine(typeof(_ThreadMonitor_d__17))]
		private static IEnumerator ThreadMonitor(Thread thread, Action callback) => default; // 0x00000001893AEA24-0x00000001893AEA98
	}
}
