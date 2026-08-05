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

// Image 17: ParadoxNotion.dll - Assembly: ParadoxNotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 51561-52895
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[Category("\u272B Blackboard")]
public class SetEnumFlag : ActionTask // TypeDefIndex: 51562
{
	// Fields
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70
	public readonly BBParameter<bool> Clear; // 0x78

	// Properties
	protected override string info { get; } // 0x000000018A921FEC-0x000000018A922084 

	// Constructors
	public SetEnumFlag(); // 0x000000018A921EC0-0x000000018A921FEC

	// Methods
	protected override void OnExecute(); // 0x000000018A921D4C-0x000000018A921EC0
}

[Category("\u272B Blackboard")]
public class CheckEnumFlag : ConditionTask // TypeDefIndex: 51563
{
	// Fields
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70

	// Properties
	protected override string info { get; } // 0x000000018A914B88-0x000000018A914BCC 

	// Constructors
	public CheckEnumFlag(); // 0x000000018A914A98-0x000000018A914B88

	// Methods
	protected override bool OnCheck(); // 0x000000018A9149E0-0x000000018A914A98
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 51565
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 51566
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 51567
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 51568
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 51569
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace FlowCanvas
{
	public class BinderConnection<T> : BinderConnection // TypeDefIndex: 51570
	{
		// Constructors
		public BinderConnection();
	
		// Methods
		public override void Bind();
		public override void UnBind();
	}

	[CancelSpoofAOT]
	public class BinderConnection : Connection // TypeDefIndex: 51572
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
		public string sourcePortID { get; private set; } // 0x000000018A912E04-0x000000018A912E40 0x0000000185396200-0x0000000185396210
		public string targetPortID { get; private set; } // 0x000000018A912EEC-0x000000018A912F28 0x00000001846A91B0-0x00000001846A91C0
		public Port sourcePort { get; } // 0x000000018A912E40-0x000000018A912EEC 
		public Port targetPort { get; } // 0x000000018A912F28-0x000000018A912FD4 
		public System.Type bindingType { get; } // 0x000000018A912D34-0x000000018A912E04 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 51571
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueHandlerObject __9__19_0; // 0x08
			public static FlowHandler __9__20_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018A925804-0x000000018A925868
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _GatherAndValidateSourcePort_b__19_0(); // 0x000000018A925108-0x000000018A925164
			internal void _GatherAndValidateTargetPort_b__20_0(Flow f); // 0x000000018A925164-0x000000018A9251C0
		}
	
		// Constructors
		public BinderConnection(); // 0x0000000184D92320-0x0000000184D92330
	
		// Methods
		public static BinderConnection Create(Port source, Port target, bool recodeUndo = true /* Metadata: 0x02331C07 */, bool invokeGraphChanged = true /* Metadata: 0x02331C08 */); // 0x000000018A911ACC-0x000000018A911FE8
		public void SetSourcePort(Port newSourcePort); // 0x000000018A9129F0-0x000000018A912B4C
		public void SetTargetPort(Port newTargetPort); // 0x000000018A912B4C-0x000000018A912CA8
		public void GatherAndValidateSourcePort(); // 0x000000018A911FE8-0x000000018A9123D0
		public void GatherAndValidateTargetPort(); // 0x000000018A9123D0-0x000000018A912854
		public static bool CanBeBound(Port source, Port target, BinderConnection refConnection); // 0x000000018A911AAC-0x000000018A911ACC
		public static bool CanBeBoundVerbosed(Port source, Port target, BinderConnection refConnection, out string verbose); // 0x000000018A911A80-0x000000018A911AAC
		private static string CanBeBoundVerbosed_Internal(Port source, Port target, BinderConnection refConnection); // 0x000000018A911808-0x000000018A911A80
		public override void OnDestroy(); // 0x000000018A9128E8-0x000000018A9129F0
		public override void OnDestroyAfterConnectionRemoved(); // 0x000000018A912854-0x000000018A9128E8
		public virtual void Bind(); // 0x000000018A9116E8-0x000000018A911808
		public virtual void UnBind(); // 0x000000018A912CA8-0x000000018A912D34
	}

	public delegate void FlowHandler(Flow f); // TypeDefIndex: 51573; 0x000000018622185C-0x0000000186221894

	[SpoofAOT]
	public delegate T ValueHandler<T>(); // TypeDefIndex: 51574; 0x00000000-0x00000000

	public delegate object ValueHandlerObject(); // TypeDefIndex: 51575; 0x0000000187378308-0x0000000187378318

	public delegate void FlowBreak(); // TypeDefIndex: 51576; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void FlowReturn(object value); // TypeDefIndex: 51577; 0x0000000182B46B90-0x0000000182B46BA0

	[SpoofAOT]
	public struct Flow // TypeDefIndex: 51579
	{
		// Fields
		[CompilerGenerated]
		private int _ticks_k__BackingField; // 0x00
		private Dictionary<string, object> parameters; // 0x08
		private ReturnData returnData; // 0x10
		private FlowBreak breakCall; // 0x20
	
		// Properties
		public int ticks { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public static Flow New { get; } // 0x0000000184D9D920-0x0000000184D9D940 
	
		// Nested types
		public struct ReturnData // TypeDefIndex: 51578
		{
			// Fields
			[CompilerGenerated]
			private FlowReturn _returnCall_k__BackingField; // 0x00
			[CompilerGenerated]
			private System.Type _returnType_k__BackingField; // 0x08
	
			// Properties
			public FlowReturn returnCall { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
			public System.Type returnType { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
	
			// Constructors
			public ReturnData(FlowReturn call, System.Type type); // 0x00000001839CF630-0x00000001839CF660
		}
	
		// Methods
		public void Call(FlowOutput port); // 0x000000018A91C648-0x000000018A91C68C
		public T ReadParameter<T>(string name);
		public void WriteParameter<T>(string name, T value);
		public void SetReturnData(FlowReturn call, System.Type expectedType); // 0x000000018A91C830-0x000000018A91C868
		public void Return(object value, FlowNode context); // 0x000000018A91C6A8-0x000000018A91C830
		public void BeginBreakBlock(FlowBreak callback); // 0x0000000185390F40-0x0000000185390F50
		public void EndBreakBlock(); // 0x000000018A91C68C-0x000000018A91C6A8
		public void Break(FlowNode context); // 0x000000018A91C5F0-0x000000018A91C648
	}

	[Serializable]
	[GraphInfo(packageName = "FlowCanvas", docsURL = "https://flowcanvas.paradoxnotion.com/documentation/", resourcesURL = "https://flowcanvas.paradoxnotion.com/downloads/", forumsURL = "https://flowcanvas.paradoxnotion.com/forums-page/")]
	public abstract class FlowGraph : NodeCanvas.Framework.Graph // TypeDefIndex: 51580
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private List<MacroNodeWrapper> macroWrappers; // 0xA8
		private Dictionary<string, IInvokable> functions; // 0xB0
		private Dictionary<System.Type, Component> cachedAgentComponents; // 0xB8
	
		// Properties
		public override System.Type baseNodeType { get; } // 0x000000018A918C80-0x000000018A918CD0 
		public override bool allowBlackboardOverrides { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool requiresAgent { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool requiresPrimeNode { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool isTree { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool canAcceptVariableDrops { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		protected FlowGraph(); // 0x000000018A918C34-0x000000018A918C80
	
		// Methods
		public T CallFunction<T>(string name, params object[] args);
		public object CallFunction(string name, params object[] args); // 0x000000018A918120-0x000000018A9181D8
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args); // 0x000000018A918064-0x000000018A918120
		public UnityEngine.Object GetAgentComponent(System.Type type); // 0x000000018A9181D8-0x000000018A918478
		protected override void OnGraphInitialize(); // 0x000000018A918578-0x000000018A91896C
		private void InitSecondPass(); // 0x000000018A918478-0x000000018A918578
		protected override void OnGraphStarted(); // 0x000000018A91896C-0x000000018A918A7C
		protected override void OnGraphUpdate(); // 0x000000018A918BA0-0x000000018A918C34
		protected override void OnGraphStoped(); // 0x000000018A918A7C-0x000000018A918BA0
	}

	[CancelSpoofAOT]
	public abstract class FlowNode : NodeCanvas.Framework.Node, ISerializationCallbackReceiver // TypeDefIndex: 51591
	{
		// Fields
		[SerializeField]
		private Dictionary<string, object> _inputPortValues; // 0x98
		[NonSerialized]
		protected Dictionary<string, Port> inputPorts; // 0xA0
		[NonSerialized]
		protected Dictionary<string, Port> outputPorts; // 0xA8
	
		// Properties
		public override bool allowDragInContentRect { get; } // 0x00000001812081B0-0x0000000181208610 
		protected override float? overrideNodeWidth { get; } // 0x000000018A91C200-0x000000018A91C240 
		public sealed override int maxInConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public sealed override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public sealed override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
		public sealed override bool canSelfConnect { get; } // 0x00000001812081B0-0x0000000181208610 
		public sealed override System.Type outConnectionType { get; } // 0x000000018A91C1B0-0x000000018A91C200 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public override Alignment2x2 iconAlignment { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public FlowGraph flowGraph { get; } // 0x000000018A91C174-0x000000018A91C1B0 
		protected string SPACE { get; } // 0x000000018A91C148-0x000000018A91C174 
		public virtual bool ignoreSelfInstancePortAssignment { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Class)]
		public class ContextDefinedInputsAttribute : Attribute // TypeDefIndex: 51581
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedInputsAttribute(params System.Type[] types); // 0x00000001853908C0-0x00000001853908D0
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		public class ContextDefinedOutputsAttribute : Attribute // TypeDefIndex: 51582
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedOutputsAttribute(params System.Type[] types); // 0x00000001853908C0-0x00000001853908D0
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		public class HasRefreshButtonAttribute : Attribute // TypeDefIndex: 51583
		{
			// Constructors
			public HasRefreshButtonAttribute(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[AttributeUsage(AttributeTargets.Field)]
		public class GatherPortsCallbackAttribute : CallbackAttribute // TypeDefIndex: 51584
		{
			// Constructors
			public GatherPortsCallbackAttribute(); // 0x000000018A91C868-0x000000018A91C8A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 51585
		{
			// Fields
			public FlowNode __4__this; // 0x10
			public string ID; // 0x18
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetInputPort_b__0(Port p); // 0x000000018A925564-0x000000018A92558C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 51586
		{
			// Fields
			public FlowNode __4__this; // 0x10
			public string ID; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetOutputPort_b__0(Port p); // 0x000000018A925564-0x000000018A92558C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 51587
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetFirstInputOfType_b__1(Port p); // 0x000000018A9255C8-0x000000018A925644
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 51588
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Port, int> __9__50_0; // 0x08
			public static Func<Port, int> __9__51_0; // 0x10
			public static Func<ValueInput, bool> __9__52_0; // 0x18
			public static Func<KeyValuePair<string, object>, string> __9__78_0; // 0x20
			public static Func<KeyValuePair<string, object>, object> __9__78_1; // 0x28
	
			// Constructors
			static __c(); // 0x000000018A9257A0-0x000000018A925804
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetFirstInputOfType_b__50_0(Port p); // 0x000000018A9251C0-0x000000018A92520C
			internal int _GetFirstOutputOfType_b__51_0(Port p); // 0x000000018A92520C-0x000000018A925258
			internal bool _AssignSelfInstancePort_b__52_0(ValueInput p); // 0x000000018A9250D4-0x000000018A925108
			internal string _ReplaceWith_b__78_0(KeyValuePair<string, object> k); // 0x000000018A925258-0x000000018A92528C
			internal object _ReplaceWith_b__78_1(KeyValuePair<string, object> v); // 0x000000018A92528C-0x000000018A9252C4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 51589
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetFirstOutputOfType_b__1(Port p); // 0x000000018A925644-0x000000018A9256B4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 51590
		{
			// Fields
			public KeyValuePair<string, object> pair; // 0x10
			public FlowNode __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass56_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _DeserializeInputPortValues_b__0(Port p); // 0x000000018A9256B4-0x000000018A925708
		}
	
		// Constructors
		protected FlowNode(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A91BD78-0x000000018A91C148
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		public override void OnValidate(NodeCanvas.Framework.Graph flowGraph); // 0x000000018A91A7C4-0x000000018A91A7CC
		public sealed override void OnParentConnected(int i); // 0x00000001841E1670-0x00000001841E1680
		public sealed override void OnChildConnected(int i); // 0x00000001841E1670-0x00000001841E1680
		public sealed override void OnParentDisconnected(int i); // 0x00000001841E1670-0x00000001841E1680
		public sealed override void OnChildDisconnected(int i); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnPortConnected(Port port, Port otherPort); // 0x000000018A91A75C-0x000000018A91A7BC
		public virtual void OnPortDisconnected(Port port, Port otherPort); // 0x000000018A91A7BC-0x000000018A91A7C4
		public virtual void OnPortDisconnectedLate(Port port, Port otherPort); // 0x00000001841E1670-0x00000001841E1680
		public void BindPorts(); // 0x000000018A91970C-0x000000018A9197C0
		public void UnBindPorts(); // 0x000000018A91BCC4-0x000000018A91BD78
		public Port GetInputPort(string ID); // 0x000000018A91A324-0x000000018A91A47C
		public Port GetOutputPort(string ID); // 0x000000018A91A59C-0x000000018A91A6F4
		public IEnumerable<Port> GetAllPorts(); // 0x000000018A919E74-0x000000018A919F04
		public IEnumerable<FlowOutput> GetOutputFlowPorts(); // 0x000000018A91A534-0x000000018A91A59C
		public IEnumerable<ValueOutput> GetOutputValuePorts(); // 0x000000018A91A6F4-0x000000018A91A75C
		public IEnumerable<FlowInput> GetInputFlowPorts(); // 0x000000018A91A2BC-0x000000018A91A324
		public IEnumerable<ValueInput> GetInputValuePorts(); // 0x000000018A91A47C-0x000000018A91A4E4
		public Port GetFirstInputOfType(System.Type type); // 0x000000018A919F04-0x000000018A91A0E0
		public Port GetFirstOutputOfType(System.Type type); // 0x000000018A91A0E0-0x000000018A91A2BC
		public void AssignSelfInstancePort(); // 0x000000018A919528-0x000000018A91970C
		public void GatherPorts(); // 0x000000018A919CF0-0x000000018A919E74
		protected abstract void RegisterPorts();
		[Conditional("UNITY_EDITOR")]
		protected virtual void ValidateConnections(); // 0x00000001841E1670-0x00000001841E1680
		private void DeserializeInputPortValues(); // 0x000000018A9198D0-0x000000018A919CF0
		[Conditional("UNITY_EDITOR")]
		private void RefreshEditorPorts(); // 0x00000001841E1670-0x00000001841E1680
		public FlowInput AddFlowInput(string name, string ID, FlowHandler pointer); // 0x000000018A918DD0-0x000000018A918DE8
		public FlowInput AddFlowInput(string name, FlowHandler pointer, string ID = "" /* Metadata: 0x02331C09 */); // 0x000000018A918DE8-0x000000018A918ED0
		public FlowOutput AddFlowOutput(string name, string ID = "" /* Metadata: 0x02331C0A */); // 0x000000018A918ED0-0x000000018A918FA8
		public ValueInput<T> AddValueInput<T>(string name, string ID = "" /* Metadata: 0x02331C0B */);
		public ValueOutput<T> AddValueOutput<T>(string name, string ID, ValueHandler<T> getter);
		public ValueOutput<T> AddValueOutput<T>(string name, ValueHandler<T> getter, string ID = "" /* Metadata: 0x02331C0C */);
		public void AddValueInput(System.Type valueType, string name, string ID = "" /* Metadata: 0x02331C0D */); // 0x000000018A919070-0x000000018A919244
		public ValueOutput<T> AddValueOutput<T>(string name, string ID = "" /* Metadata: 0x02331C0E */);
		public void AddValueOutput(System.Type valueType, string name, string ID = "" /* Metadata: 0x02331C0F */); // 0x000000018A919354-0x000000018A919528
		public ValueInput AddValueInput(string name, string ID, System.Type type); // 0x000000018A919244-0x000000018A91925C
		public ValueInput AddValueInput(string name, System.Type type, string ID = "" /* Metadata: 0x02331C10 */); // 0x000000018A918FA8-0x000000018A919070
		public ValueOutput AddValueOutput(string name, string ID, System.Type type, ValueHandlerObject getter); // 0x000000018A91925C-0x000000018A91927C
		public ValueOutput AddValueOutput(string name, System.Type type, ValueHandlerObject getter, string ID = "" /* Metadata: 0x02331C11 */); // 0x000000018A91927C-0x000000018A919354
		protected void QualifyPortNameAndID(ref string name, ref string ID, IDictionary dict); // 0x000000018A91A7CC-0x000000018A91A884
		private bool CheckReverseIDEquality(Port port, string requestedID); // 0x000000018A9197C0-0x000000018A9198D0
		public void TryAddReflectionBasedRegistrationForObject(object instance); // 0x000000018A91B5D0-0x000000018A91B7A4
		public FlowInput TryAddMethodFlowInput(MethodInfo method, object instance); // 0x000000018A91B124-0x000000018A91B2D8
		public FlowOutput TryAddFieldDelegateFlowOutput(System.Reflection.FieldInfo field, object instance); // 0x000000018A91ABBC-0x000000018A91AD30
		public ValueInput TryAddFieldDelegateValueInput(System.Reflection.FieldInfo field, object instance); // 0x000000018A91AD30-0x000000018A91B124
		public ValueOutput TryAddPropertyValueOutput(PropertyInfo prop, object instance); // 0x000000018A91B2D8-0x000000018A91B5D0
		public FlowNode ReplaceWith(System.Type t); // 0x000000018A91A884-0x000000018A91ABBC
		private void TryRemovePortIfMissingAndClean(Port port); // 0x000000018A91BC10-0x000000018A91BCC4
		public virtual System.Type GetNodeWildDefinitionType(); // 0x000000018A91A4E4-0x000000018A91A534
		private void TryHandleWildPortConnection(System.Type currentType, System.Type targetType); // 0x000000018A91BB68-0x000000018A91BC10
		public static System.Type TryGetNewGenericTypeForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Type content, System.Type context); // 0x000000018A91B944-0x000000018A91BB68
		public static MethodInfo TryGetNewGenericMethodForWild(System.Type wildType, System.Type currentType, System.Type targetType, MethodInfo content); // 0x000000018A91B7A4-0x000000018A91B944
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FlowNodeNested<T> : FlowNode, IGraphAssignable<T> // TypeDefIndex: 51592
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
		[CompilerGenerated]
		private T _currentInstance_k__BackingField;
		[CompilerGenerated]
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FlowNodeNested();
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/FlowCanvas/FlowScript Asset")]
	public class FlowScript : FlowScriptBase // TypeDefIndex: 51593
	{
		// Properties
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public FlowScript(); // 0x000000018A91C444-0x000000018A91C44C
	}

	public abstract class FlowScriptBase : FlowGraph // TypeDefIndex: 51594
	{
		// Constructors
		protected FlowScriptBase(); // 0x000000018A91C444-0x000000018A91C44C
	}

	[AddComponentMenu("FlowCanvas/FlowScript Controller")]
	public class FlowScriptController : GraphOwner<FlowScript> // TypeDefIndex: 51595
	{
		// Constructors
		public FlowScriptController(); // 0x000000018A91C5BC-0x000000018A91C5F0
	
		// Methods
		public void CallFunction(string name); // 0x000000018A91C4D0-0x000000018A91C54C
		public object CallFunction(string name, params object[] args); // 0x000000018A91C54C-0x000000018A91C5BC
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args); // 0x000000018A91C44C-0x000000018A91C4D0
	}

	public interface IEditorMenuCallbackReceiver // TypeDefIndex: 51596
	{
	}

	[Category("Events/Object/Rendering")]
	[Description("Called after all rendering is complete to render image on target camera.")]
	[Name("On Render Image", 0)]
	public class RenderImageEvent : RouterEventNode<Camera> // TypeDefIndex: 51597
	{
		// Fields
		private FlowOutput fOut; // 0xC8
		private RenderTexture t1; // 0xD0
		private RenderTexture t2; // 0xD8
	
		// Constructors
		public RenderImageEvent(); // 0x000000018A921D18-0x000000018A921D4C
	
		// Methods
		protected override void Subscribe(EventRouter router); // 0x000000018A921BF8-0x000000018A921C88
		protected override void UnSubscribe(EventRouter router); // 0x000000018A921C88-0x000000018A921D18
		private void OnRenderImage(RenderTexture source, RenderTexture dest); // 0x000000018A921A20-0x000000018A921A9C
		protected override void RegisterPorts(); // 0x000000018A921A9C-0x000000018A921BF8
		[CompilerGenerated]
		private RenderTexture _RegisterPorts_b__6_0(); // 0x0000000184D876B0-0x0000000184D876C0
		[CompilerGenerated]
		private RenderTexture _RegisterPorts_b__6_1(); // 0x0000000184D88EF0-0x0000000184D88F00
	}

	public abstract class Port // TypeDefIndex: 51599
	{
		// Fields
		[CompilerGenerated]
		private bool _prettifyName_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _forceNotDraw_k__BackingField; // 0x11
		[CompilerGenerated]
		private FlowNode _parent_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _ID_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x28
		[CompilerGenerated]
		private int _connections_k__BackingField; // 0x30
		[CompilerGenerated]
		private BindStatus _bindStatus_k__BackingField; // 0x34
		[CompilerGenerated]
		private GUIContent _displayContent_k__BackingField; // 0x38
	
		// Properties
		public bool prettifyName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		public bool forceNotDraw { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88380-0x0000000184D88390 0x0000000184D88460-0x0000000184D88470
		public FlowNode parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string ID { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public int connections { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public bool isConnected { get; } // 0x000000018A921A18-0x000000018A921A20 
		internal BindStatus bindStatus { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		internal GUIContent displayContent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public abstract System.Type type { get; }
	
		// Nested types
		public enum BindStatus // TypeDefIndex: 51598
		{
			Valid = 0,
			Missing = 1,
			InvalidCast = 2
		}
	
		// Constructors
		public Port(); // 0x00000001815EFCD0-0x00000001815EFCE0
		public Port(FlowNode parent, string name, string ID); // 0x000000018A9219DC-0x000000018A921A18
	
		// Methods
		internal Port FlagMissing(); // 0x000000018A9211D0-0x000000018A9211F8
		internal Port FlagInvalidCast(); // 0x000000018A9211A8-0x000000018A9211D0
		internal Port FlagValid(); // 0x000000018A9211F8-0x000000018A92121C
		public virtual bool CanAcceptConnections(); // 0x000000018A9210F4-0x000000018A9211A8
		public IEnumerable<BinderConnection> GetPortConnections(); // 0x000000018A92139C-0x000000018A9214B0
		public BinderConnection GetFirstInputConnection(); // 0x000000018A92121C-0x000000018A9212DC
		public BinderConnection GetFirstOutputConnection(); // 0x000000018A9212DC-0x000000018A92139C
		public bool IsFlowPort(); // 0x000000018A9215A0-0x000000018A921604
		public bool IsValuePort(); // 0x000000018A921854-0x000000018A9218B8
		public bool IsInputPort(); // 0x000000018A921604-0x000000018A921668
		public bool IsOutputPort(); // 0x000000018A921668-0x000000018A9216CC
		public bool IsUnityObject(); // 0x000000018A9216CC-0x000000018A92176C
		public bool IsUnitySceneObject(); // 0x000000018A92176C-0x000000018A921854
		public bool IsDelegate(); // 0x000000018A9214B0-0x000000018A921550
		public bool IsEnumerableCollection(); // 0x000000018A921550-0x000000018A9215A0
		public bool IsWild(); // 0x000000018A9218B8-0x000000018A92192C
		public override string ToString(); // 0x000000018A92192C-0x000000018A92197C
		[CompilerGenerated]
		private bool _GetPortConnections_b__43_0(BinderConnection c); // 0x000000018A92197C-0x000000018A9219AC
		[CompilerGenerated]
		private bool _GetPortConnections_b__43_1(BinderConnection c); // 0x000000018A9219AC-0x000000018A9219DC
		[CompilerGenerated]
		private bool _GetFirstInputConnection_b__44_0(BinderConnection c); // 0x000000018A92197C-0x000000018A9219AC
		[CompilerGenerated]
		private bool _GetFirstOutputConnection_b__45_0(BinderConnection c); // 0x000000018A9219AC-0x000000018A9219DC
	}

	public class FlowInput : Port // TypeDefIndex: 51600
	{
		// Fields
		[CompilerGenerated]
		private FlowHandler _pointer_k__BackingField; // 0x40
	
		// Properties
		public FlowHandler pointer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public override System.Type type { get; } // 0x000000018A918D80-0x000000018A918DD0 
	
		// Constructors
		public FlowInput(FlowNode parent, string name, string ID, FlowHandler pointer); // 0x000000018A918D50-0x000000018A918D80
	}

	public class FlowOutput : Port // TypeDefIndex: 51601
	{
		// Fields
		[CompilerGenerated]
		private FlowHandler pointer; // 0x40
	
		// Properties
		public override System.Type type { get; } // 0x000000018A91C360-0x000000018A91C3B0 
	
		// Events
		public event FlowHandler pointer {
			add; // 0x000000018A91C2CC-0x000000018A91C360
			remove; // 0x000000018A91C3B0-0x000000018A91C444
		}
	
		// Constructors
		public FlowOutput(FlowNode parent, string name, string ID); // 0x0000000189447C84-0x0000000189447C94
	
		// Methods
		public void Call(Flow f); // 0x000000018A91C26C-0x000000018A91C2CC
		public void BindTo(FlowInput target); // 0x000000018A91C248-0x000000018A91C26C
		public void Append(FlowHandler callback); // 0x000000018A91C240-0x000000018A91C248
		public void UnBind(); // 0x0000000189AFF570-0x0000000189AFF584
	}

	public abstract class ValueInput : Port // TypeDefIndex: 51602
	{
		// Fields
		[CompilerGenerated]
		private bool _skipSelfInstanceAssignment_k__BackingField; // 0x40
	
		// Properties
		public object value { get; } // 0x000000018A928BA0-0x000000018A928BB0 
		public bool skipSelfInstanceAssignment { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public abstract object defaultValue { get; set; }
		public abstract object serializedValue { get; set; }
		public abstract bool isDefaultValue { get; }
		public abstract System.Type type { get; }
	
		// Constructors
		public ValueInput(FlowNode parent, string name, string ID); // 0x0000000189447C84-0x0000000189447C94
	
		// Methods
		public static ValueInput<T> CreateInstance<T>(FlowNode parent, string name, string ID);
		public static ValueInput CreateInstance(System.Type t, FlowNode parent, string name, string ID); // 0x000000018A9289CC-0x000000018A928B60
		public ValueInput SetDefaultAndSerializedValue(object v); // 0x000000018A928B60-0x000000018A928BA0
		public ValueInput SkipSelfInstanceAssignment(bool skip); // 0x0000000184DA6450-0x0000000184DA6460
		public abstract void BindTo(ValueOutput target);
		public abstract void UnBind();
		public abstract object GetObjectValue();
	}

	public class ValueInput<T> : ValueInput // TypeDefIndex: 51603
	{
		// Fields
		[CompilerGenerated]
		private ValueHandler<T> getter;
		private Action<T> callback;
		private T _value;
		private T _defaultValue;
	
		// Properties
		public new T value { get; }
		public override object defaultValue { get; set; }
		public override object serializedValue { get; set; }
		public override bool isDefaultValue { get; }
		public override System.Type type { get; }
	
		// Events
		public event ValueHandler<T> getter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		public ValueInput(FlowNode parent, string name, string ID);
	
		// Methods
		public ValueInput<T> SetDefaultAndSerializedValue(T v);
		public T GetValue();
		public override object GetObjectValue();
		public override void BindTo(ValueOutput source);
		public void Append(Action<T> callback);
		public override void UnBind();
		public static explicit operator T(ValueInput<T> port);
	}

	public abstract class ValueOutput : Port // TypeDefIndex: 51604
	{
		// Constructors
		public ValueOutput(FlowNode parent, string name, string ID); // 0x0000000189447C84-0x0000000189447C94
	
		// Methods
		public static ValueOutput<T> CreateInstance<T>(FlowNode parent, string name, string ID, ValueHandler<T> getter);
		public static ValueOutput CreateInstance(System.Type t, FlowNode parent, string name, string ID, ValueHandlerObject getter); // 0x000000018A928BB0-0x000000018A928D64
		public abstract object GetObjectValue();
	}

	public class ValueOutput<T> : ValueOutput // TypeDefIndex: 51606
	{
		// Fields
		[CompilerGenerated]
		private ValueHandler<T> _getter_k__BackingField;
	
		// Properties
		public ValueHandler<T> getter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override System.Type type { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51605
		{
			// Fields
			public ValueHandlerObject getter;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal T _.ctor_b__0();
		}
	
		// Constructors
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandler<T> getter);
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandlerObject getter);
		public ValueOutput(FlowNode parent, string name, string ID);
	
		// Methods
		public override object GetObjectValue();
		public static explicit operator T(ValueOutput<T> port);
	}

	public static class TypeConverter // TypeDefIndex: 51613
	{
		// Fields
		[CompilerGenerated]
		private static CustomConverter customConverter; // 0x00
		[CompilerGenerated]
		private static CustomCanConvert customCanConvert; // 0x08
	
		// Events
		public static event CustomConverter customConverter {
			add; // 0x000000018A924ED4-0x000000018A924F7C
			remove; // 0x000000018A92502C-0x000000018A9250D4
		}
		public static event CustomCanConvert customCanConvert {
			add; // 0x000000018A924E24-0x000000018A924ED4
			remove; // 0x000000018A924F7C-0x000000018A92502C
		}
	
		// Nested types
		public delegate ValueHandler<object> CustomConverter(System.Type sourceType, System.Type targetType, ValueHandler<object> func); // TypeDefIndex: 51607; 0x00000001814F3120-0x00000001814F3140
	
		public delegate bool? CustomCanConvert(System.Type sourceType, System.Type targetType); // TypeDefIndex: 51608; 0x00000001815802E0-0x00000001815802F0
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0<T> // TypeDefIndex: 51609
		{
			// Fields
			public ValueHandler<object> func;
			public System.Type targetType;
			public UnaryExpression exp;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal T _GetConverterFuncFromTo_b__0();
			internal T _GetConverterFuncFromTo_b__1();
			internal T _GetConverterFuncFromTo_b__2();
			internal T _GetConverterFuncFromTo_b__3();
			internal T _GetConverterFuncFromTo_b__4();
			internal T _GetConverterFuncFromTo_b__5();
			internal T _GetConverterFuncFromTo_b__6();
			internal T _GetConverterFuncFromTo_b__7();
			internal T _GetConverterFuncFromTo_b__8();
			internal T _GetConverterFuncFromTo_b__9();
			internal T _GetConverterFuncFromTo_b__10();
			internal T _GetConverterFuncFromTo_b__11();
			internal T _GetConverterFuncFromTo_b__12();
			internal T _GetConverterFuncFromTo_b__13();
			internal T _GetConverterFuncFromTo_b__14();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_1<T> // TypeDefIndex: 51610
		{
			// Fields
			public ValueHandler<object> converter;
	
			// Constructors
			public __c__DisplayClass8_1();
	
			// Methods
			internal T _GetConverterFuncFromTo_b__15();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_2<T> // TypeDefIndex: 51611
		{
			// Fields
			public System.Type listType;
			public __c__DisplayClass8_0<T> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass8_2();
	
			// Methods
			internal T _GetConverterFuncFromTo_b__16();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 51612
		{
			// Fields
			public object obj; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _QuickConvert_b__0(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		}
	
		// Methods
		public static ValueHandler<T> GetConverterFuncFromTo<T>(System.Type sourceType, System.Type targetType, ValueHandler<object> func);
		public static bool HasConvertion(System.Type sourceType, System.Type targetType); // 0x000000018A924C4C-0x000000018A924CF8
		public static T QuickConvert<T>(object obj);
		public static object QuickConvert(object obj, System.Type type); // 0x000000018A924CF8-0x000000018A924E24
	}

	public class Wild // TypeDefIndex: 51614
	{
		// Constructors
		public Wild(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace FlowCanvas.Macros
{
	[CreateAssetMenu(menuName = "ParadoxNotion/FlowCanvas/Macro Asset")]
	public class Macro : FlowScriptBase // TypeDefIndex: 52194
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
		public override bool allowBlackboardOverrides { get; } // 0x00000001812081B0-0x0000000181208610 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001812081B0-0x0000000181208610 
		public MacroInputNode entry { get; } // 0x000000018A94E4F8-0x000000018A94E608 
		public MacroOutputNode exit { get; } // 0x000000018A94E608-0x000000018A94E718 
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 52188
		{
			// Fields
			public List<DynamicParameterDefinition> inputDefinitions; // 0x10
			public List<DynamicParameterDefinition> outputDefinitions; // 0x18
	
			// Constructors
			public DerivedSerializationData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 52189
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddInputDefinition_b__0(DynamicParameterDefinition d); // 0x000000018A95286C-0x000000018A9528BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 52190
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddOutputDefinition_b__0(DynamicParameterDefinition d); // 0x000000018A95286C-0x000000018A9528BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0<T> // TypeDefIndex: 52191
		{
			// Fields
			public string name;
			public T value;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal bool _SetValueInput_b__0(DynamicParameterDefinition d);
			internal object _SetValueInput_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 52192
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CallFlowInput_b__0(DynamicParameterDefinition d); // 0x000000018A9528BC-0x000000018A952948
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0<T> // TypeDefIndex: 52193
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal bool _GetValueOutput_b__0(DynamicParameterDefinition d);
		}
	
		// Constructors
		public Macro(); // 0x000000018A94E2D4-0x000000018A94E4F8
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x000000018A94E1F4-0x000000018A94E264
		public override void OnDerivedDataDeserialization(object data); // 0x000000018A94E12C-0x000000018A94E1F4
		protected override void OnGraphValidate(); // 0x000000018A94E264-0x000000018A94E2D4
		public Port AddInputDefinition(DynamicParameterDefinition def); // 0x000000018A94DD10-0x000000018A94DE74
		public Port AddOutputDefinition(DynamicParameterDefinition def); // 0x000000018A94DE74-0x000000018A94DFD8
		public void AddExamplePorts(); // 0x000000018A94DB88-0x000000018A94DD10
		public void SetValueInput<T>(string name, T value);
		public void CallFlowInput(string name); // 0x000000018A94DFD8-0x000000018A94E12C
		public T GetValueOutput<T>(string name);
	}

	[Description("Defines the Input ports of the Macro.\nTo quickly create ports, you can also Drag&Drop a connection on top of this node!")]
	[DoNotList]
	[Icon("MacroIn", false, "")]
	[ProtectedSingleton]
	public class MacroInputNode : FlowNode // TypeDefIndex: 52196
	{
		// Properties
		public override Alignment2x2 iconAlignment { get; } // 0x00000001811EC580-0x00000001811EC590 
		private Macro macro { get; } // 0x000000018A94CD54-0x000000018A94CD90 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52195
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
			public MacroInputNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A952AF4-0x000000018A952B84
		}
	
		// Constructors
		public MacroInputNode(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94CA4C-0x000000018A94CD54
	}

	[Color("ffe4e1")]
	[DoNotList]
	[DropReferenceType(typeof(Macro))]
	[HasRefreshButton]
	public class MacroNodeWrapper : FlowNode, IGraphAssignable, IUpdatable // TypeDefIndex: 52200
	{
		// Fields
		[SerializeField]
		private Macro _macro; // 0xB0
		private Macro _currentInstance; // 0xB8
	
		// Properties
		public override string name { get; } // 0x000000018A94D714-0x000000018A94D79C 
		public override string description { get; } // 0x000000018A94D678-0x000000018A94D714 
		public Macro macro { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018A94D79C-0x000000018A94D83C
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018A94CFEC-0x000000018A94D040
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x000000018A94CF28-0x000000018A94CF90
		List<BBMappingParameter> IGraphAssignable.variablesMap { get; set; } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		BBParameter IGraphAssignable.subGraphParameter { get; } // 0x00000001811EC580-0x00000001811EC590 
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> IGraphAssignable.instances { get; set; } // 0x000000018A94CE94-0x000000018A94CF28 0x000000018A94CF90-0x000000018A94CFEC
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 52197
		{
			// Fields
			public Macro target; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1 // TypeDefIndex: 52198
		{
			// Fields
			public DynamicParameterDefinition defIn; // 0x10
			public __c__DisplayClass25_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass25_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A952948-0x000000018A952A00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_2 // TypeDefIndex: 52199
		{
			// Fields
			public DynamicParameterDefinition defOut; // 0x10
			public __c__DisplayClass25_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass25_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__1(); // 0x000000018A952A00-0x000000018A952A90
		}
	
		// Constructors
		public MacroNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public void MakeInstance(); // 0x000000018A94CD90-0x000000018A94CE94
		void IUpdatable.Update(); // 0x000000018A94D040-0x000000018A94D0C0
		protected override void RegisterPorts(); // 0x000000018A94D0C0-0x000000018A94D678
	}

	[Description("Defines the Output ports of the Macro.\nTo quickly create ports, you can also Drag&Drop a connection on top of this node!")]
	[DoNotList]
	[Icon("MacroOut", false, "")]
	[ProtectedSingleton]
	public class MacroOutputNode : FlowNode // TypeDefIndex: 52202
	{
		// Properties
		public override Alignment2x2 iconAlignment { get; } // 0x00000001811EC580-0x00000001811EC590 
		private Macro macro { get; } // 0x000000018A94DB4C-0x000000018A94DB88 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52201
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
			public MacroOutputNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A952B84-0x000000018A952C3C
		}
	
		// Constructors
		public MacroOutputNode(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94D83C-0x000000018A94DB4C
	}
}

namespace FlowCanvas.Nodes
{
	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public class ExternalImplementedNodeWrapper : FlowNode // TypeDefIndex: 51615
	{
		// Fields
		[SerializeField]
		private UnityEngine.Object _target; // 0xB0
	
		// Properties
		public IExternalImplementedNode target { get; set; } // 0x000000018A917E14-0x000000018A917E54 0x000000018A917E54-0x000000018A917ED0
		public override string name { get; } // 0x000000018A917D94-0x000000018A917E14 
	
		// Constructors
		public ExternalImplementedNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected System.Type GetRuntimeIconType(); // 0x000000018A917CE0-0x000000018A917D08
		protected override void RegisterPorts(); // 0x000000018A917D08-0x000000018A917D8C
		public void SetTarget(IExternalImplementedNode target); // 0x000000018A917D8C-0x000000018A917D94
	}

	public interface IDropedReferenceNode : IGraphElement // TypeDefIndex: 51616
	{
		// Methods
		void SetTarget(UnityEngine.Object target);
	}

	public interface IExternalImplementedNode // TypeDefIndex: 51617
	{
		// Methods
		void RegisterPorts(FlowNode parent);
	}

	[Category("Events/Application")]
	[Description("Called when the Application is paused or resumed")]
	[Name("On Application Pause", 0)]
	public class ApplicationPauseEvent : EventNode // TypeDefIndex: 51618
	{
		// Fields
		private FlowOutput pause; // 0xB0
		private bool isPause; // 0xB8
	
		// Constructors
		public ApplicationPauseEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A9112E4-0x000000018A91137C
		public override void OnGraphStoped(); // 0x000000018A91137C-0x000000018A911414
		private void ApplicationPause(bool isPause); // 0x000000018A911290-0x000000018A9112E4
		protected override void RegisterPorts(); // 0x000000018A911414-0x000000018A911504
		[CompilerGenerated]
		private bool _RegisterPorts_b__5_0(); // 0x0000000184D892C0-0x0000000184D892D0
	}

	[Category("Events/Application")]
	[Description("Called when the Application quit")]
	[Name("On Application Quit", 0)]
	public class ApplicationQuitEvent : EventNode // TypeDefIndex: 51619
	{
		// Fields
		private FlowOutput quit; // 0xB0
	
		// Constructors
		public ApplicationQuitEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A911554-0x000000018A9115EC
		public override void OnGraphStoped(); // 0x000000018A9115EC-0x000000018A911684
		private void ApplicationQuit(); // 0x000000018A911504-0x000000018A911554
		protected override void RegisterPorts(); // 0x000000018A911684-0x000000018A9116E8
	}

	[Description("Automatically Subscribes to the target C# Event when the graph is enabled, and is called when the event is raised")]
	[DoNotList]
	[Name("C# Event", 0)]
	public class CSharpAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 51621
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
		private EventInfo eventInfo { get; } // 0x00000001891C020C-0x00000001891C0220 
		private bool isStaticEvent { get; } // 0x000000018A913640-0x000000018A9136B0 
		public override string name { get; } // 0x000000018A9136B0-0x000000018A9137D8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 51620
		{
			// Fields
			public int i; // 0x10
			public CSharpAutoCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A9254BC-0x000000018A9254F4
		}
	
		// Constructors
		public CSharpAutoCallbackEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86250-0x0000000184D86260
		public void SetEvent(EventInfo info, object instance = null); // 0x000000018A9135B8-0x000000018A913640
		protected override void RegisterPorts(); // 0x000000018A9132A0-0x000000018A9135B8
		public override void OnGraphStarted(); // 0x000000018A913038-0x000000018A913190
		public override void OnGraphStoped(); // 0x000000018A913190-0x000000018A9132A0
		private void OnEventRaised(params object[] args); // 0x000000018A912FD4-0x000000018A913038
	}

	[Category("Events/Custom")]
	[Description("Providing a C# Event, Register a callback to be called when that event is raised.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(SharpEvent) })]
	[Name("C# Event Callback", 2)]
	public class CSharpEventCallback : EventNode, IReflectedWrapper // TypeDefIndex: 51623
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
		private System.Type type { get; set; } // 0x000000018A91404C-0x000000018A914060 0x000000018A914060-0x000000018A914110
		private bool autoHandleRegistration { get; } // 0x0000000184D88CC0-0x0000000184D88CD0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 51622
		{
			// Fields
			public int i; // 0x10
			public CSharpEventCallback __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A9254F4-0x000000018A92552C
		}
	
		// Constructors
		public CSharpEventCallback(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D85EF0-0x0000000184D85F00
		public override void OnGraphStarted(); // 0x000000018A91388C-0x000000018A9138D4
		public override void OnGraphStoped(); // 0x000000018A9138D4-0x000000018A913934
		protected override void RegisterPorts(); // 0x000000018A913A24-0x000000018A913E5C
		private void Register(Flow f = default); // 0x000000018A913E5C-0x000000018A913F78
		private void Unregister(Flow f = default); // 0x000000018A913F78-0x000000018A91404C
		private void Callback(params object[] args); // 0x000000018A9137D8-0x000000018A91383C
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018A91383C-0x000000018A91388C
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018A913934-0x000000018A913A24
	}

	[Category("Events/Custom")]
	[Description("Called when a custom event is received on target(s).\n- Receiver, is the object which received the event.\n- Sender, is the object which invoked the event.\n\n- To send an event from a graph use the SendEvent node.\n- To send an event from code use: \'FlowScriptController.SendEvent(string)\'")]
	[Name("Custom Event", 100)]
	public class CustomEvent : RouterEventNode<GraphOwner> // TypeDefIndex: 51624
	{
		// Fields
		[DelayedField]
		[RequiredField]
		public BBParameter<string> eventName; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private GraphOwner sender; // 0xD8
		private GraphOwner receiver; // 0xE0
	
		// Properties
		public override string name { get; } // 0x000000018A91722C-0x000000018A9172A4 
	
		// Constructors
		public CustomEvent(); // 0x000000018A9171B8-0x000000018A91722C
	
		// Methods
		protected override void Subscribe(EventRouter router); // 0x000000018A917098-0x000000018A917128
		protected override void UnSubscribe(EventRouter router); // 0x000000018A917128-0x000000018A9171B8
		protected override void RegisterPorts(); // 0x000000018A916F3C-0x000000018A917098
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg); // 0x000000018A916D98-0x000000018A916F3C
		[CompilerGenerated]
		private GraphOwner _RegisterPorts_b__8_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GraphOwner _RegisterPorts_b__8_1(); // 0x0000000184D88EF0-0x0000000184D88F00
	}

	[Category("Events/Custom")]
	[Description("Called when a custom event is received on target(s).\n- Receiver, is the object which received the event.\n- Sender, is the object which invoked the event.\n\n- To send an event from a graph use the SendEvent(T) node.\n- To send an event from code use: \'FlowScriptController.SendEvent(string, T)\'")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Custom Event", 100)]
	public class CustomEvent<T> : RouterEventNode<GraphOwner> // TypeDefIndex: 51625
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
		public override string name { get; }
	
		// Constructors
		public CustomEvent();
	
		// Methods
		protected override void Subscribe(EventRouter router);
		protected override void UnSubscribe(EventRouter router);
		protected override void RegisterPorts();
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg);
		[CompilerGenerated]
		private GraphOwner _RegisterPorts_b__9_0();
		[CompilerGenerated]
		private GraphOwner _RegisterPorts_b__9_1();
		[CompilerGenerated]
		private T _RegisterPorts_b__9_2();
	}

	[Category("Events/Custom")]
	[Description("The exposed Delegate points directly to the \'Callback\' output. You can connect this delegate as listener to a Unity or C# Event using the AddListener function of that Unity Event, or the += function of that C# Event. When that event is raised, this node will be called.")]
	[ContextDefinedOutputs(new System.Type[2] {typeof(Flow), typeof(Delegate) })]
	[Name("Delegate Callback", 1)]
	public class DelegateCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 51627
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB0
		private ReflectedDelegateEvent reflectedEvent; // 0xB8
		private ValueOutput delegatePort; // 0xC0
		private FlowOutput callbackPort; // 0xC8
		private object[] args; // 0xD0
	
		// Properties
		private System.Type delegateType { get; set; } // 0x00000001891C020C-0x00000001891C0220 0x000000018A917814-0x000000018A9178C4
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 51626
		{
			// Fields
			public int i; // 0x10
			public DelegateCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__1(); // 0x000000018A925768-0x000000018A9257A0
		}
	
		// Constructors
		public DelegateCallbackEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86250-0x0000000184D86260
		protected override void RegisterPorts(); // 0x000000018A917410-0x000000018A9177F4
		private void Callback(params object[] args); // 0x000000018A9172A4-0x000000018A917308
		public override void OnGraphStoped(); // 0x000000018A917308-0x000000018A917320
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018A917320-0x000000018A917410
		[CompilerGenerated]
		private object _RegisterPorts_b__9_0(); // 0x000000018A9177F4-0x000000018A917814
	}

	[Description("Returns a reference of a C# event, which can be used with the C# Event Callback node.")]
	[DoNotList]
	public class GetSharpEvent : FlowNode, IReflectedWrapper // TypeDefIndex: 51629
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo _event; // 0xB0
		private ValueInput instancePort; // 0xB8
	
		// Properties
		private EventInfo eventInfo { get; } // 0x00000001891C020C-0x00000001891C0220 
		public override string name { get; } // 0x000000018A91CB2C-0x000000018A91CCA4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 51628
		{
			// Fields
			public SharpEvent wrapper; // 0x10
			public GetSharpEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A925708-0x000000018A925768
		}
	
		// Constructors
		public GetSharpEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86250-0x0000000184D86260
		public void SetEvent(EventInfo info, object instance = null); // 0x000000018A91CAA4-0x000000018A91CB2C
		protected override void RegisterPorts(); // 0x000000018A91C8A8-0x000000018A91CAA4
	}

	[Category("Events/Signals")]
	[Description("Invoke a defined Signal. Signals are similar to name-based events but are safer to changes and support multiple parameters.")]
	[DropReferenceType(typeof(SignalDefinition))]
	[HasRefreshButton]
	public class InvokeSignal : FlowNode, IDropedReferenceNode // TypeDefIndex: 51631
	{
		// Fields
		[GatherPortsCallback]
		public BBParameter<SignalDefinition> _signalDefinition; // 0xB0
		[GatherPortsCallback]
		public bool global; // 0xB8
		private ValueInput<Transform> target; // 0xC0
		private ValueInput[] inputArgs; // 0xC8
	
		// Properties
		private SignalDefinition signalDefinition { get; set; } // 0x000000018A91DB08-0x000000018A91DB50 0x000000018A91DB50-0x000000018A91DBA8
		public override string name { get; } // 0x000000018A91DA30-0x000000018A91DB08 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 51630
		{
			// Fields
			public InvokeSignal __4__this; // 0x10
			public FlowOutput exit; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A9252C4-0x000000018A9254BC
		}
	
		// Constructors
		public InvokeSignal(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public void SetTarget(UnityEngine.Object target); // 0x000000018A91D9D0-0x000000018A91DA30
		protected override void RegisterPorts(); // 0x000000018A91D700-0x000000018A91D9D0
	}

	[Category("Events/Signals")]
	[Description("Check if a defined Signal has been invoked. Signals are similar to name-based events but are safer to changes and support multiple parameters.")]
	[DropReferenceType(typeof(SignalDefinition))]
	[ExecutionPriority(100)]
	[HasRefreshButton]
	public class SignalCallback : RouterEventNode<Transform>, IDropedReferenceNode // TypeDefIndex: 51633
	{
		// Fields
		[GatherPortsCallback]
		public BBParameter<SignalDefinition> _signalDefinition; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private Transform receiver; // 0xD8
		private Transform sender; // 0xE0
		private object[] args; // 0xE8
	
		// Properties
		private SignalDefinition signalDefinition { get; set; } // 0x000000018A922868-0x000000018A9228B0 0x000000018A9228B0-0x000000018A922908
		public override string name { get; } // 0x000000018A922780-0x000000018A922868 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 51632
		{
			// Fields
			public int i; // 0x10
			public SignalCallback __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__2(); // 0x000000018A92552C-0x000000018A925564
		}
	
		// Constructors
		public SignalCallback(); // 0x000000018A92274C-0x000000018A922780
	
		// Methods
		public void SetTarget(UnityEngine.Object target); // 0x000000018A9226EC-0x000000018A92274C
		protected override void Subscribe(EventRouter router); // 0x00000001841E1670-0x00000001841E1680
		protected override void UnSubscribe(EventRouter router); // 0x00000001841E1670-0x00000001841E1680
		public override void OnPostGraphStarted(); // 0x000000018A9222C8-0x000000018A922404
		public override void OnGraphStoped(); // 0x000000018A922084-0x000000018A922170
		protected override void RegisterPorts(); // 0x000000018A922404-0x000000018A9226EC
		private void OnInvoked(Transform sender, Transform receiver, bool isGlobal, object[] args); // 0x000000018A922170-0x000000018A9222C8
		[CompilerGenerated]
		private Transform _RegisterPorts_b__15_0(); // 0x0000000184D88EF0-0x0000000184D88F00
		[CompilerGenerated]
		private Transform _RegisterPorts_b__15_1(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
	}

	[Description("Automatically Subscribes to the target UnityEvent when the graph is enabled, and is called when the event is raised")]
	[DoNotList]
	[Name("Unity Event", 0)]
	public class UnityEventAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 51635
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
		private MemberInfo member { get; } // 0x000000018A927D58-0x000000018A927D74 
		private bool isStatic { get; } // 0x000000018A927D30-0x000000018A927D58 
		private System.Type eventType { get; } // 0x000000018A927CF8-0x000000018A927D20 
		private System.Reflection.FieldInfo field { get; } // 0x000000018A927D20-0x000000018A927D30 
		private PropertyInfo prop { get; } // 0x000000018A927E9C-0x000000018A927EAC 
		public override string name { get; } // 0x000000018A927D74-0x000000018A927E9C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 51634
		{
			// Fields
			public int i; // 0x10
			public UnityEventAutoCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A9254BC-0x000000018A9254F4
		}
	
		// Constructors
		public UnityEventAutoCallbackEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86250-0x0000000184D86260
		public void SetEvent(MemberInfo newMember, object instance = null); // 0x000000018A927C70-0x000000018A927CF8
		protected override void RegisterPorts(); // 0x000000018A927934-0x000000018A927C70
		public override void OnGraphStarted(); // 0x000000018A927670-0x000000018A927880
		public override void OnGraphStoped(); // 0x000000018A927880-0x000000018A927934
		private void OnEventRaised(params object[] args); // 0x000000018A92760C-0x000000018A927670
	}

	[Category("Events/Custom")]
	[Description("Register a callback on a UnityEvent.\nWhen that event is raised, this node will get called.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(UnityEventBase) })]
	[Name("Unity Event Callback", 3)]
	public class UnityEventCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 51637
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
		private System.Type eventType { get; set; } // 0x000000018A91404C-0x000000018A914060 0x000000018A928738-0x000000018A9287E8
		public bool autoHandleRegistration { get; } // 0x0000000184D88CC0-0x0000000184D88CD0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 51636
		{
			// Fields
			public int i; // 0x10
			public UnityEventCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A9254F4-0x000000018A92552C
		}
	
		// Constructors
		public UnityEventCallbackEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D85EF0-0x0000000184D85F00
		public override void OnGraphStarted(); // 0x000000018A927EFC-0x000000018A927F44
		public override void OnGraphStoped(); // 0x000000018A927F44-0x000000018A927F8C
		protected override void RegisterPorts(); // 0x000000018A92807C-0x000000018A928538
		private void Register(Flow f = default); // 0x000000018A928538-0x000000018A928660
		private void Unregister(Flow f = default); // 0x000000018A928660-0x000000018A928738
		private void OnEventRaised(params object[] args); // 0x000000018A9137D8-0x000000018A91383C
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018A927EAC-0x000000018A927EFC
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018A927F8C-0x000000018A92807C
	}

	[Category("Events")]
	[Color("ff5c5c")]
	[ExecutionPriority(1)]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	public abstract class EventNode : FlowNode // TypeDefIndex: 51638
	{
		// Properties
		public override string name { get; } // 0x000000018A917C84-0x000000018A917CE0 
	
		// Constructors
		protected EventNode(); // 0x000000018489BC70-0x000000018489BC80
	}

	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class EventNode<T> : EventNode // TypeDefIndex: 51639
		where T : Component
	{
		// Fields
		public BBParameter<T> target;
	
		// Properties
		public override string name { get; }
	
		// Constructors
		protected EventNode();
	
		// Methods
		public override void OnPostGraphStarted();
		protected void ResolveSelf();
	}

	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class RouterEventNode<T> : EventNode // TypeDefIndex: 51641
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
		public enum TargetMode // TypeDefIndex: 51640
		{
			SingleTarget = 0,
			MultipleTargets = 1
		}
	
		// Constructors
		protected RouterEventNode();
	
		// Methods
		protected abstract void Subscribe(EventRouter router);
		protected abstract void UnSubscribe(EventRouter router);
		public override void OnPostGraphStarted();
		public override void OnGraphStoped();
		protected T ResolveReceiver(GameObject receiver);
	}

	[Category("Events/Graph")]
	[Description("Called only once and the first time the Graph is enabled.\nUse this for initialization of this graph.")]
	[ExecutionPriority(10)]
	[Name("On Awake", 10)]
	public class ConstructionEvent : EventNode // TypeDefIndex: 51642
	{
		// Fields
		private FlowOutput awake; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public ConstructionEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A916BAC-0x000000018A916C0C
		protected override void RegisterPorts(); // 0x000000018A916C0C-0x000000018A916C70
	}

	[Category("Events/Graph")]
	[Description("Called whenever the Graph is Disabled")]
	[ExecutionPriority(4)]
	[Name("On Disable", 4)]
	public class DisableEvent : EventNode // TypeDefIndex: 51643
	{
		// Fields
		private FlowOutput disable; // 0xB0
	
		// Constructors
		public DisableEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStoped(); // 0x000000018A911504-0x000000018A911554
		protected override void RegisterPorts(); // 0x000000018A9178C4-0x000000018A917928
	}

	[Category("Events/Graph")]
	[Description("Called whenever the Graph is enabled.")]
	[ExecutionPriority(9)]
	[Name("On Enable", 9)]
	public class EnableEvent : EventNode // TypeDefIndex: 51644
	{
		// Fields
		private FlowOutput enable; // 0xB0
	
		// Constructors
		public EnableEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A911504-0x000000018A911554
		protected override void RegisterPorts(); // 0x000000018A917C20-0x000000018A917C84
	}

	[Category("Events/Graph")]
	[Description("Called every fixed framerate frame, which should be used when dealing with Physics")]
	[ExecutionPriority(5)]
	[Name("On Fixed Update", 5)]
	public class FixedUpdateEvent : EventNode // TypeDefIndex: 51645
	{
		// Fields
		private FlowOutput fixedUpdate; // 0xB0
	
		// Constructors
		public FixedUpdateEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A918000-0x000000018A918064
		public override void OnGraphStarted(); // 0x000000018A917ED0-0x000000018A917F68
		public override void OnGraphStoped(); // 0x000000018A917F68-0x000000018A918000
		private void FixedUpdate(); // 0x000000018A911504-0x000000018A911554
	}

	[Category("Events/Graph")]
	[Description("Called per-frame, but after normal Update")]
	[ExecutionPriority(6)]
	[Name("On Late Update", 6)]
	public class LateUpdateEvent : EventNode // TypeDefIndex: 51646
	{
		// Fields
		private FlowOutput lateUpdate; // 0xB0
	
		// Constructors
		public LateUpdateEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91DF88-0x000000018A91DFEC
		public override void OnGraphStarted(); // 0x000000018A91DE58-0x000000018A91DEF0
		public override void OnGraphStoped(); // 0x000000018A91DEF0-0x000000018A91DF88
		private void LateUpdate(); // 0x000000018A911504-0x000000018A911554
	}

	[Category("Events/Graph")]
	[Description("Called only once and the first time the Graph is enabled.\nThis is called after all OnAwake events of all graphs and after OnEnable events of this graph.")]
	[ExecutionPriority(8)]
	[Name("On Start", 8)]
	public class StartEvent : EventNode // TypeDefIndex: 51647
	{
		// Fields
		private FlowOutput start; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public StartEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A922908-0x000000018A9229EC
		private void OnStartCallback(); // 0x000000018A9229EC-0x000000018A922A64
		protected override void RegisterPorts(); // 0x000000018A922A64-0x000000018A922AC8
	}

	[Category("Events/Graph")]
	[Description("Called per-frame.\nUpdate Interval optionally determines the period in seconds every which update is called. Leave at 0 to call update per-frame as normal.")]
	[ExecutionPriority(7)]
	[Name("On Update", 7)]
	public class UpdateEvent : EventNode, IUpdatable // TypeDefIndex: 51648
	{
		// Fields
		public BBParameter<float> updateInterval; // 0xB0
		private FlowOutput update; // 0xB8
		private float lastUpdatedTime; // 0xC0
	
		// Constructors
		public UpdateEvent(); // 0x000000018A928974-0x000000018A9289CC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9287E8-0x000000018A92884C
		public override void OnGraphStarted(); // 0x0000000184DA6440-0x0000000184DA6450
		public void Update(); // 0x000000018A92884C-0x000000018A928974
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls out when Horizontal or Vertical Input Axis is not zero")]
	[Name("Input Axis (Preset)", 0)]
	[Obsolete("Use Input Axis")]
	public class InputAxisEvent : EventNode, IUpdatable // TypeDefIndex: 51649
	{
		// Fields
		private FlowOutput o; // 0xB0
		private float horizontal; // 0xB8
		private float vertical; // 0xBC
		private bool calledLastFrame; // 0xC0
	
		// Constructors
		public InputAxisEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91CCA4-0x000000018A91CE00
		public void Update(); // 0x000000018A91CE00-0x000000018A91CF44
		[CompilerGenerated]
		private float _RegisterPorts_b__4_0(); // 0x0000000184DA32D0-0x0000000184DA32E0
		[CompilerGenerated]
		private float _RegisterPorts_b__4_1(); // 0x0000000184DA62F0-0x0000000184DA6300
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls respective outputs when the defined Button is pressed down, held down or released.\nButtons are configured in Unity Input Manager.")]
	[Name("Input Button", 0)]
	public class InputButtonEvents : EventNode, IUpdatable // TypeDefIndex: 51650
	{
		// Fields
		[RequiredField]
		public BBParameter<string> buttonName; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018A91D1B8-0x000000018A91D208 
	
		// Constructors
		public InputButtonEvents(); // 0x000000018A91D150-0x000000018A91D1B8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91CF44-0x000000018A91D018
		public void Update(); // 0x000000018A91D018-0x000000018A91D150
	}

	[Category("Events/Input (Legacy System)")]
	[Description("You are free to define any Input Axis in this node.\nAxis can be set in \'Project Settings/Input\'.\nCalls Out when either of the Axis defined is not zero")]
	[HasRefreshButton]
	[Name("Input Axis", 0)]
	public class InputCustomAxisEvent : EventNode, IUpdatable // TypeDefIndex: 51652
	{
		// Fields
		public BBParameter<List<string>> axis; // 0xB0
		private float[] axisValues; // 0xB8
		private bool calledLastFrame; // 0xC0
		private FlowOutput o; // 0xC8
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51651
		{
			// Fields
			public int i; // 0x10
			public InputCustomAxisEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _RegisterPorts_b__0(); // 0x000000018A92558C-0x000000018A9255C8
		}
	
		// Constructors
		public InputCustomAxisEvent(); // 0x000000018A91D610-0x000000018A91D700
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91D208-0x000000018A91D470
		public void Update(); // 0x000000018A91D470-0x000000018A91D610
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls respective outputs when the defined keyboard key is pressed down, held down or released")]
	[Name("Keyboard Key", 0)]
	public class KeyboardEvents : EventNode, IUpdatable // TypeDefIndex: 51653
	{
		// Fields
		public BBParameter<KeyCode> keyCode; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018A91DE08-0x000000018A91DE58 
	
		// Constructors
		public KeyboardEvents(); // 0x000000018A91DDB0-0x000000018A91DE08
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91DBA8-0x000000018A91DC7C
		public void Update(); // 0x000000018A91DC7C-0x000000018A91DDB0
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Called when the specified mouse button is clicked down, held or released")]
	[Name("Mouse Button", 0)]
	public class MouseEvents : EventNode, IUpdatable // TypeDefIndex: 51655
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput pressed; // 0xC0
		private FlowOutput up; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018A91F990-0x000000018A91F9E0 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 51654
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MouseEvents(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91F788-0x000000018A91F85C
		public void Update(); // 0x000000018A91F85C-0x000000018A91F990
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Called when any collider is clicked with the specified mouse button. PickInfo contains the information of the raycast event")]
	[Name("Mouse Pick", 0)]
	public class MousePickEvent : EventNode, IUpdatable // TypeDefIndex: 51657
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		public BBParameter<LayerMask> mask; // 0xB8
		private FlowOutput o; // 0xC0
		private RaycastHit hit; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018A91FCA4-0x000000018A91FCF4 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 51656
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MousePickEvent(); // 0x000000018A91FC34-0x000000018A91FCA4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91F9E0-0x000000018A91FAD0
		public void Update(); // 0x000000018A91FAD0-0x000000018A91FC34
		[CompilerGenerated]
		private RaycastHit _RegisterPorts_b__7_0(); // 0x0000000184D9E330-0x0000000184D9E360
	}

	[Category("Events/Object")]
	[Description("Calls Animator based events. Note that using this node will override root motion as usual, but you can call \'Apply Builtin Root Motion\' to get it back.")]
	[Name("Animator", 0)]
	public class AnimatorEvents : RouterEventNode<Animator> // TypeDefIndex: 51658
	{
		// Fields
		private FlowOutput onAnimatorMove; // 0xC8
		private FlowOutput onAnimatorIK; // 0xD0
		private Animator receiver; // 0xD8
		private int layerIndex; // 0xE0
	
		// Constructors
		public AnimatorEvents(); // 0x000000018A91125C-0x000000018A911290
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A910EEC-0x000000018A91109C
		protected override void Subscribe(EventRouter router); // 0x000000018A91109C-0x000000018A91117C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A91117C-0x000000018A91125C
		private void OnAnimatorMove(ParadoxNotion.EventData msg); // 0x000000018A910E48-0x000000018A910EEC
		private void OnAnimatorIK(EventData<int> msg); // 0x000000018A910D80-0x000000018A910E48
		[CompilerGenerated]
		private Animator _RegisterPorts_b__4_0(); // 0x0000000184D88EF0-0x0000000184D88F00
		[CompilerGenerated]
		private int _RegisterPorts_b__4_1(); // 0x0000000184D9A880-0x0000000184D9A890
	}

	[Category("Events/Object")]
	[Description("Called when the Character Controller hits a collider while performing a Move")]
	[Name("Character Controller", 0)]
	public class CharacterControllerEvents : RouterEventNode<CharacterController>, IUpdatable // TypeDefIndex: 51659
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
		public CharacterControllerEvents(); // 0x000000018A9149AC-0x000000018A9149E0
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A91445C-0x000000018A91454C
		void IUpdatable.Update(); // 0x000000018A914110-0x000000018A914388
		protected override void RegisterPorts(); // 0x000000018A91454C-0x000000018A914838
		protected override void Subscribe(EventRouter router); // 0x000000018A914838-0x000000018A9148C8
		protected override void UnSubscribe(EventRouter router); // 0x000000018A91491C-0x000000018A9149AC
		private void OnControllerColliderHit(EventData<ControllerColliderHit> msg); // 0x000000018A914388-0x000000018A91445C
		[CompilerGenerated]
		private CharacterController _RegisterPorts_b__9_0(); // 0x0000000184D876B0-0x0000000184D876C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__9_1(); // 0x000000018A9148C8-0x000000018A9148EC
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__9_2(); // 0x000000018A9148EC-0x000000018A91491C
		[CompilerGenerated]
		private ControllerColliderHit _RegisterPorts_b__9_3(); // 0x0000000184D88EF0-0x0000000184D88F00
	}

	[Category("Events/Object")]
	[Description("Called when 2D Collision based events happen on target and expose collision information")]
	[Name("Collision2D", 0)]
	public class Collision2DEvents_Rigidbody : RouterEventNode<Rigidbody2D> // TypeDefIndex: 51660
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents_Rigidbody(); // 0x000000018A91591C-0x000000018A915950
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A915394-0x000000018A915680
		protected override void Subscribe(EventRouter router); // 0x000000018A915680-0x000000018A91579C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A915800-0x000000018A91591C
		private void OnCollisionEnter2D(EventData<Collision2D> msg); // 0x000000018A915118-0x000000018A9151EC
		private void OnCollisionStay2D(EventData<Collision2D> msg); // 0x000000018A9152C0-0x000000018A915394
		private void OnCollisionExit2D(EventData<Collision2D> msg); // 0x000000018A9151EC-0x000000018A9152C0
		[CompilerGenerated]
		private Rigidbody2D _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018A91579C-0x000000018A9157C0
		[CompilerGenerated]
		private ContactPoint2D _RegisterPorts_b__5_2(); // 0x000000018A9157C0-0x000000018A915800
		[CompilerGenerated]
		private Collision2D _RegisterPorts_b__5_3(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when 2D Collision based events happen on target and expose collision information")]
	[DoNotList]
	[Name("Collision2D", 0)]
	public class Collision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 51661
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents(); // 0x000000018A915B88-0x000000018A915BBC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A914E48-0x000000018A915118
		protected override void Subscribe(EventRouter router); // 0x000000018A915950-0x000000018A915A6C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A915A6C-0x000000018A915B88
		private void OnCollisionEnter2D(EventData<Collision2D> msg); // 0x000000018A914BCC-0x000000018A914CA0
		private void OnCollisionStay2D(EventData<Collision2D> msg); // 0x000000018A914D74-0x000000018A914E48
		private void OnCollisionExit2D(EventData<Collision2D> msg); // 0x000000018A914CA0-0x000000018A914D74
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018A91579C-0x000000018A9157C0
		[CompilerGenerated]
		private ContactPoint2D _RegisterPorts_b__5_2(); // 0x000000018A9157C0-0x000000018A915800
		[CompilerGenerated]
		private Collision2D _RegisterPorts_b__5_3(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when Collision based events happen on target and expose collision information")]
	[Name("Collision", 0)]
	public class CollisionEvents_Rigidbody : RouterEventNode<Rigidbody> // TypeDefIndex: 51662
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents_Rigidbody(); // 0x000000018A91690C-0x000000018A916940
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A916384-0x000000018A916670
		protected override void Subscribe(EventRouter router); // 0x000000018A916670-0x000000018A91678C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A9167F0-0x000000018A91690C
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg); // 0x000000018A916108-0x000000018A9161DC
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg); // 0x000000018A9162B0-0x000000018A916384
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg); // 0x000000018A9161DC-0x000000018A9162B0
		[CompilerGenerated]
		private Rigidbody _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018A91678C-0x000000018A9167B0
		[CompilerGenerated]
		private ContactPoint _RegisterPorts_b__5_2(); // 0x000000018A9167B0-0x000000018A9167F0
		[CompilerGenerated]
		private UnityEngine.Collision _RegisterPorts_b__5_3(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when Collision based events happen on target and expose collision information")]
	[DoNotList]
	[Name("Collision", 0)]
	public class CollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 51663
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents(); // 0x000000018A916B78-0x000000018A916BAC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A915E38-0x000000018A916108
		protected override void Subscribe(EventRouter router); // 0x000000018A916940-0x000000018A916A5C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A916A5C-0x000000018A916B78
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg); // 0x000000018A915BBC-0x000000018A915C90
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg); // 0x000000018A915D64-0x000000018A915E38
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg); // 0x000000018A915C90-0x000000018A915D64
		[CompilerGenerated]
		private Collider _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018A91678C-0x000000018A9167B0
		[CompilerGenerated]
		private ContactPoint _RegisterPorts_b__5_2(); // 0x000000018A9167B0-0x000000018A9167F0
		[CompilerGenerated]
		private UnityEngine.Collision _RegisterPorts_b__5_3(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when mouse based operations happen on target 2D collider")]
	[Name("Mouse2D", 0)]
	public class MouseAgent2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 51664
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
		public MouseAgent2DEvents(); // 0x000000018A91EBD4-0x000000018A91EC08
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91E40C-0x000000018A91E67C
		protected override void Subscribe(EventRouter router); // 0x000000018A91E7EC-0x000000018A91E9E0
		protected override void UnSubscribe(EventRouter router); // 0x000000018A91E9E0-0x000000018A91EBD4
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018A91E14C-0x000000018A91E1FC
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018A91E2AC-0x000000018A91E35C
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018A91E1FC-0x000000018A91E2AC
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018A91DFEC-0x000000018A91E09C
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018A91E35C-0x000000018A91E40C
		private void OnMouseDrag(ParadoxNotion.EventData msg); // 0x000000018A91E09C-0x000000018A91E14C
		private void StoreHit(); // 0x000000018A91E67C-0x000000018A91E7EC
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__8_0(); // 0x0000000184D877C0-0x0000000184D877D0
		[CompilerGenerated]
		private RaycastHit2D _RegisterPorts_b__8_1(); // 0x0000000184DA63E0-0x0000000184DA6410
	}

	[Category("Events/Object")]
	[Description("Called when mouse based operations happen on target collider")]
	[Name("Mouse", 0)]
	public class MouseAgentEvents : RouterEventNode<Collider> // TypeDefIndex: 51665
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
		public MouseAgentEvents(); // 0x000000018A91F754-0x000000018A91F788
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91F028-0x000000018A91F298
		protected override void Subscribe(EventRouter router); // 0x000000018A91F36C-0x000000018A91F560
		protected override void UnSubscribe(EventRouter router); // 0x000000018A91F560-0x000000018A91F754
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018A91ED68-0x000000018A91EE18
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018A91EEC8-0x000000018A91EF78
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018A91EE18-0x000000018A91EEC8
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018A91EC08-0x000000018A91ECB8
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018A91EF78-0x000000018A91F028
		private void OnMouseDrag(ParadoxNotion.EventData msg); // 0x000000018A91ECB8-0x000000018A91ED68
		private void StoreHit(); // 0x000000018A91F298-0x000000018A91F36C
		[CompilerGenerated]
		private Collider _RegisterPorts_b__8_0(); // 0x0000000184D877C0-0x0000000184D877D0
		[CompilerGenerated]
		private RaycastHit _RegisterPorts_b__8_1(); // 0x0000000184DA6410-0x0000000184DA6440
	}

	[Category("Events/Object")]
	[Description("OnEnable, OnDisable and OnDestroy callback events for target object")]
	[Name("Object State", 0)]
	public class ObjectStateEvents : RouterEventNode<Transform> // TypeDefIndex: 51666
	{
		// Fields
		private FlowOutput onEnable; // 0xC8
		private FlowOutput onDisable; // 0xD0
		private FlowOutput onDestroy; // 0xD8
		private GameObject receiver; // 0xE0
	
		// Constructors
		public ObjectStateEvents(); // 0x000000018A9202A8-0x000000018A9202DC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A91FF10-0x000000018A920070
		protected override void Subscribe(EventRouter router); // 0x000000018A920070-0x000000018A92018C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A92018C-0x000000018A9202A8
		private void OnEnable(ParadoxNotion.EventData msg); // 0x000000018A91FE5C-0x000000018A91FF10
		private void OnDisable(ParadoxNotion.EventData msg); // 0x000000018A91FDA8-0x000000018A91FE5C
		private void OnDestroy(ParadoxNotion.EventData msg); // 0x000000018A91FCF4-0x000000018A91FDA8
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__4_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
	}

	[Category("Events/Object")]
	[Description("Calls Gizmos")]
	[Name("Draw Gizmos", 0)]
	public class DrawGizmosEvents : RouterEventNode<Transform> // TypeDefIndex: 51667
	{
		// Fields
		private FlowOutput onDrawGizmos; // 0xC8
		private GameObject receiver; // 0xD0
	
		// Constructors
		public DrawGizmosEvents(); // 0x000000018A917BEC-0x000000018A917C20
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9179DC-0x000000018A917ACC
		protected override void Subscribe(EventRouter router); // 0x000000018A917ACC-0x000000018A917B5C
		protected override void UnSubscribe(EventRouter router); // 0x000000018A917B5C-0x000000018A917BEC
		private void OnDrawGizmos(ParadoxNotion.EventData msg); // 0x000000018A917928-0x000000018A9179DC
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__2_0(); // 0x0000000184D876B0-0x0000000184D876C0
	}

	[Category("Events/Object")]
	[Description("Called when any Particle System collided with the target collider 2D object")]
	[Name("Particle Collision 2D", 0)]
	public class ParticleCollision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 51668
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider2D receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollision2DEvents(); // 0x000000018A9209B4-0x000000018A9209E8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A920484-0x000000018A920738
		protected override void Subscribe(EventRouter router); // 0x000000018A920738-0x000000018A9207C8
		protected override void UnSubscribe(EventRouter router); // 0x000000018A920924-0x000000018A9209B4
		private void OnParticleCollision(EventData<GameObject> msg); // 0x000000018A9202DC-0x000000018A920484
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__4_0(); // 0x0000000184D876B0-0x0000000184D876C0
		[CompilerGenerated]
		private ParticleSystem _RegisterPorts_b__4_1(); // 0x0000000184D88EF0-0x0000000184D88F00
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_2(); // 0x000000018A9207C8-0x000000018A92083C
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_3(); // 0x000000018A92083C-0x000000018A9208B0
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_4(); // 0x000000018A9208B0-0x000000018A920924
	}

	[Category("Events/Object")]
	[Description("Called when any Particle System collided with the target collider object")]
	[Name("Particle Collision", 0)]
	public class ParticleCollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 51669
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollisionEvents(); // 0x000000018A9210C0-0x000000018A9210F4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A920B90-0x000000018A920E44
		protected override void Subscribe(EventRouter router); // 0x000000018A920E44-0x000000018A920ED4
		protected override void UnSubscribe(EventRouter router); // 0x000000018A921030-0x000000018A9210C0
		private void OnParticleCollision(EventData<GameObject> msg); // 0x000000018A9209E8-0x000000018A920B90
		[CompilerGenerated]
		private Collider _RegisterPorts_b__4_0(); // 0x0000000184D876B0-0x0000000184D876C0
		[CompilerGenerated]
		private ParticleSystem _RegisterPorts_b__4_1(); // 0x0000000184D88EF0-0x0000000184D88F00
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_2(); // 0x000000018A920ED4-0x000000018A920F48
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_3(); // 0x000000018A920F48-0x000000018A920FBC
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_4(); // 0x000000018A920FBC-0x000000018A921030
	}

	[Category("Events/Object")]
	[Description("Events relevant to transform changes")]
	public class TransformEvents : RouterEventNode<Transform> // TypeDefIndex: 51670
	{
		// Fields
		private FlowOutput onParentChanged; // 0xC8
		private FlowOutput onChildrenChanged; // 0xD0
		private Transform receiver; // 0xD8
		private Transform parent; // 0xE0
		private IEnumerable<Transform> children; // 0xE8
	
		// Constructors
		public TransformEvents(); // 0x000000018A923088-0x000000018A9230BC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A922CC8-0x000000018A922EE0
		protected override void Subscribe(EventRouter router); // 0x000000018A922EE0-0x000000018A922FB4
		protected override void UnSubscribe(EventRouter router); // 0x000000018A922FB4-0x000000018A923088
		private void OnTransformParentChanged(ParadoxNotion.EventData msg); // 0x000000018A922BC8-0x000000018A922CC8
		private void OnTransformChildrenChanged(ParadoxNotion.EventData msg); // 0x000000018A922AC8-0x000000018A922BC8
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_0(); // 0x0000000184D88EF0-0x0000000184D88F00
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_1(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private IEnumerable<Transform> _RegisterPorts_b__5_2(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when 2D Trigger based event happen on target when it has either a Collider2D or a Rigidbody2D")]
	[Name("Trigger2D", 0)]
	public class Trigger2DEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 51671
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents_Transform(); // 0x000000018A923D00-0x000000018A923D34
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9238E0-0x000000018A923AC8
		protected override void Subscribe(EventRouter router); // 0x000000018A923AC8-0x000000018A923BE4
		protected override void UnSubscribe(EventRouter router); // 0x000000018A923BE4-0x000000018A923D00
		private void OnTriggerEnter2D(EventData<Collider2D> msg); // 0x000000018A923640-0x000000018A923720
		private void OnTriggerStay2D(EventData<Collider2D> msg); // 0x000000018A923800-0x000000018A9238E0
		private void OnTriggerExit2D(EventData<Collider2D> msg); // 0x000000018A923720-0x000000018A923800
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when 2D Trigger based event happen on target")]
	[DoNotList]
	[Name("Trigger2D", 0)]
	public class Trigger2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 51672
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents(); // 0x000000018A923E50-0x000000018A923E84
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92335C-0x000000018A923524
		protected override void Subscribe(EventRouter router); // 0x000000018A923524-0x000000018A923640
		protected override void UnSubscribe(EventRouter router); // 0x000000018A923D34-0x000000018A923E50
		private void OnTriggerEnter2D(EventData<Collider2D> msg); // 0x000000018A9230BC-0x000000018A92319C
		private void OnTriggerStay2D(EventData<Collider2D> msg); // 0x000000018A92327C-0x000000018A92335C
		private void OnTriggerExit2D(EventData<Collider2D> msg); // 0x000000018A92319C-0x000000018A92327C
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when Trigger based event happen on target when it has either a Collider or a Rigidbody")]
	[Name("Trigger", 0)]
	public class TriggerEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 51673
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents_Transform(); // 0x000000018A924AC8-0x000000018A924AFC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9246A8-0x000000018A924890
		protected override void Subscribe(EventRouter router); // 0x000000018A924890-0x000000018A9249AC
		protected override void UnSubscribe(EventRouter router); // 0x000000018A9249AC-0x000000018A924AC8
		private void OnTriggerEnter(EventData<Collider> msg); // 0x000000018A924408-0x000000018A9244E8
		private void OnTriggerStay(EventData<Collider> msg); // 0x000000018A9245C8-0x000000018A9246A8
		private void OnTriggerExit(EventData<Collider> msg); // 0x000000018A9244E8-0x000000018A9245C8
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object")]
	[Description("Called when Trigger based event happen on target")]
	[DoNotList]
	[Name("Trigger", 0)]
	public class TriggerEvents : RouterEventNode<Collider> // TypeDefIndex: 51674
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents(); // 0x000000018A924C18-0x000000018A924C4C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A924124-0x000000018A9242EC
		protected override void Subscribe(EventRouter router); // 0x000000018A9242EC-0x000000018A924408
		protected override void UnSubscribe(EventRouter router); // 0x000000018A924AFC-0x000000018A924C18
		private void OnTriggerEnter(EventData<Collider> msg); // 0x000000018A923E84-0x000000018A923F64
		private void OnTriggerStay(EventData<Collider> msg); // 0x000000018A924044-0x000000018A924124
		private void OnTriggerExit(EventData<Collider> msg); // 0x000000018A923F64-0x000000018A924044
		[CompilerGenerated]
		private Collider _RegisterPorts_b__5_0(); // 0x0000000184D8D1C0-0x0000000184D8D1D0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x0000000184D88590-0x0000000184D885A0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Button is clicked")]
	[Name("UI Button", 0)]
	public class UIButtonEvent : EventNode<UnityEngine.UI.Button> // TypeDefIndex: 51675
	{
		// Fields
		private FlowOutput o; // 0xB8
	
		// Constructors
		public UIButtonEvent(); // 0x000000018A925BB4-0x000000018A925BE8
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A92598C-0x000000018A925A7C
		public override void OnGraphStoped(); // 0x000000018A9258B8-0x000000018A92598C
		protected override void RegisterPorts(); // 0x000000018A925A7C-0x000000018A925B6C
		private void OnClick(); // 0x000000018A925868-0x000000018A9258B8
		[CompilerGenerated]
		private UnityEngine.UI.Button _RegisterPorts_b__3_0(); // 0x000000018A925B6C-0x000000018A925BB4
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Dropdown value changed.")]
	[Name("UI Dropdown", 0)]
	public class UIDropdownEvent : EventNode<Dropdown> // TypeDefIndex: 51676
	{
		// Fields
		private FlowOutput o; // 0xB8
		private int value; // 0xC0
	
		// Constructors
		public UIDropdownEvent(); // 0x000000018A925FDC-0x000000018A926010
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A925CCC-0x000000018A925DCC
		public override void OnGraphStoped(); // 0x000000018A925BE8-0x000000018A925CCC
		protected override void RegisterPorts(); // 0x000000018A925E20-0x000000018A925F94
		private void OnValueChanged(int value); // 0x000000018A925DCC-0x000000018A925E20
		[CompilerGenerated]
		private Dropdown _RegisterPorts_b__4_0(); // 0x000000018A925F94-0x000000018A925FDC
		[CompilerGenerated]
		private int _RegisterPorts_b__4_1(); // 0x0000000184DA4B70-0x0000000184DA4B80
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Dropdown value changed.")]
	[Name("UI Field Input", 0)]
	public class UIInputFieldEvent : EventNode<InputField> // TypeDefIndex: 51677
	{
		// Fields
		private FlowOutput onValueChanged; // 0xB8
		private FlowOutput onEndEdit; // 0xC0
		private string value; // 0xC8
	
		// Constructors
		public UIInputFieldEvent(); // 0x000000018A9265C4-0x000000018A9265F8
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A9261E0-0x000000018A926368
		public override void OnGraphStoped(); // 0x000000018A926074-0x000000018A9261E0
		protected override void RegisterPorts(); // 0x000000018A9263CC-0x000000018A92657C
		private void OnValueChanged(string value); // 0x000000018A926368-0x000000018A9263CC
		private void OnEndEdit(string value); // 0x000000018A926010-0x000000018A926074
		[CompilerGenerated]
		private InputField _RegisterPorts_b__5_0(); // 0x000000018A92657C-0x000000018A9265C4
		[CompilerGenerated]
		private string _RegisterPorts_b__5_1(); // 0x0000000184D8D1D0-0x0000000184D8D1E0
	}

	[Category("Events/Object/UI")]
	[Description("Calls UI Pointer based events on target. The Unity Event system has to be set through \'GameObject/UI/Event System\'")]
	[Name("UI Pointer", 0)]
	public class UIPointerEvents : RouterEventNode<Transform> // TypeDefIndex: 51679
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
		[CompilerGenerated]
		private sealed class _UpdatePressed_d__17 : IEnumerator<object> // TypeDefIndex: 51678
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIPointerEvents __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _UpdatePressed_d__17(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A93AA98-0x000000018A93AB24
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A93AB24-0x000000018A93AB70
		}
	
		// Constructors
		public UIPointerEvents(); // 0x000000018A9275D8-0x000000018A92760C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A926D44-0x000000018A92707C
		protected override void Subscribe(EventRouter router); // 0x000000018A92707C-0x000000018A9272FC
		protected override void UnSubscribe(EventRouter router); // 0x000000018A9272FC-0x000000018A92757C
		private void OnPointerDown(EventData<PointerEventData> msg); // 0x000000018A9266DC-0x000000018A9267E0
		private void OnPointerUp(EventData<PointerEventData> msg); // 0x000000018A926C54-0x000000018A926D44
		[IteratorStateMachine(typeof(_UpdatePressed_d__17))]
		private IEnumerator UpdatePressed(); // 0x000000018A92757C-0x000000018A9275D8
		private void OnPointerEnter(EventData<PointerEventData> msg); // 0x000000018A9269A8-0x000000018A926A8C
		private void OnPointerExit(EventData<PointerEventData> msg); // 0x000000018A926A8C-0x000000018A926B70
		private void OnPointerClick(EventData<PointerEventData> msg); // 0x000000018A9265F8-0x000000018A9266DC
		private void OnPointerDrag(EventData<PointerEventData> msg); // 0x000000018A9267E0-0x000000018A9268C4
		private void OnPointerDrop(EventData<PointerEventData> msg); // 0x000000018A9268C4-0x000000018A9269A8
		private void OnPointerScroll(EventData<PointerEventData> msg); // 0x000000018A926B70-0x000000018A926C54
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__12_0(); // 0x0000000184D8D1B0-0x0000000184D8D1C0
		[CompilerGenerated]
		private PointerEventData _RegisterPorts_b__12_1(); // 0x0000000184D85F80-0x0000000184D85F90
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Scrollbar value changed.")]
	[Name("UI Scrollbar", 0)]
	public class UIScrollbarEvent : EventNode<Scrollbar> // TypeDefIndex: 51680
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UIScrollbarEvent(); // 0x000000018A93AF68-0x000000018A93AF9C
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A93AC54-0x000000018A93AD54
		public override void OnGraphStoped(); // 0x000000018A93AB70-0x000000018A93AC54
		protected override void RegisterPorts(); // 0x000000018A93ADAC-0x000000018A93AF20
		private void OnValueChanged(float value); // 0x000000018A93AD54-0x000000018A93ADAC
		[CompilerGenerated]
		private Scrollbar _RegisterPorts_b__4_0(); // 0x000000018A93AF20-0x000000018A93AF68
		[CompilerGenerated]
		private float _RegisterPorts_b__4_1(); // 0x0000000184D9DF30-0x0000000184D9DF40
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Slider value changed.")]
	[Name("UI Slider", 0)]
	public class UISliderEvent : EventNode<Slider> // TypeDefIndex: 51681
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UISliderEvent(); // 0x000000018A93B33C-0x000000018A93B370
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A93B080-0x000000018A93B180
		public override void OnGraphStoped(); // 0x000000018A93AF9C-0x000000018A93B080
		protected override void RegisterPorts(); // 0x000000018A93B180-0x000000018A93B2F4
		private void OnValueChanged(float value); // 0x000000018A93AD54-0x000000018A93ADAC
		[CompilerGenerated]
		private Slider _RegisterPorts_b__4_0(); // 0x000000018A93B2F4-0x000000018A93B33C
		[CompilerGenerated]
		private float _RegisterPorts_b__4_1(); // 0x0000000184D9DF30-0x0000000184D9DF40
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Toggle value changed.")]
	[Name("UI Toggle", 0)]
	public class UIToggleEvent : EventNode<UnityEngine.UI.Toggle> // TypeDefIndex: 51682
	{
		// Fields
		private FlowOutput o; // 0xB8
		private bool state; // 0xC0
	
		// Constructors
		public UIToggleEvent(); // 0x000000018A93B764-0x000000018A93B798
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A93B454-0x000000018A93B554
		public override void OnGraphStoped(); // 0x000000018A93B370-0x000000018A93B454
		protected override void RegisterPorts(); // 0x000000018A93B5A8-0x000000018A93B71C
		private void OnValueChanged(bool state); // 0x000000018A93B554-0x000000018A93B5A8
		[CompilerGenerated]
		private UnityEngine.UI.Toggle _RegisterPorts_b__4_0(); // 0x000000018A93B71C-0x000000018A93B764
		[CompilerGenerated]
		private bool _RegisterPorts_b__4_1(); // 0x0000000184D91920-0x0000000184D91930
	}

	[Category("Events/Object")]
	[Description("Calls events based on object\'s render visibility")]
	[Name("Visibility", 0)]
	public class VisibilityEvents : RouterEventNode<Transform> // TypeDefIndex: 51683
	{
		// Fields
		private FlowOutput onVisible; // 0xC8
		private FlowOutput onInvisible; // 0xD0
		private GameObject receiver; // 0xD8
	
		// Constructors
		public VisibilityEvents(); // 0x000000018A93C2CC-0x000000018A93C300
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A93BFFC-0x000000018A93C124
		protected override void Subscribe(EventRouter router); // 0x000000018A93C124-0x000000018A93C1F8
		protected override void UnSubscribe(EventRouter router); // 0x000000018A93C1F8-0x000000018A93C2CC
		private void OnBecameVisible(ParadoxNotion.EventData msg); // 0x000000018A93BF48-0x000000018A93BFFC
		private void OnBecameInvisible(ParadoxNotion.EventData msg); // 0x000000018A93BE94-0x000000018A93BF48
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__3_0(); // 0x0000000184D88EF0-0x0000000184D88F00
	}

	[Category("Events/Other")]
	[Description("Checks the condition boolean input per frame and calls outputs when the value has changed")]
	[Name("Conditional Event", 0)]
	public class ConditionalUpdateEvent : EventNode, IUpdatable // TypeDefIndex: 51684
	{
		// Fields
		private FlowOutput becameTrue; // 0xB0
		private FlowOutput becameFalse; // 0xB8
		private ValueInput<bool> condition; // 0xC0
		private bool lastState; // 0xC8
	
		// Constructors
		public ConditionalUpdateEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92AB9C-0x000000018A92AC80
		public void Update(); // 0x000000018A92AC80-0x000000018A92AD6C
	}

	[Category("Events/Other")]
	[Description("Use to debug send a Flow Signal in PlayMode Only")]
	public class DebugEvent : EventNode // TypeDefIndex: 51685
	{
		// Constructors
		public DebugEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("Events/Other")]
	[Description("Calls Hi when curve value is greater than 0, else calls Low.\nThe curve is evaluated over time and it\'s evaluated value is exposed")]
	[Name("OSC Pulse", 0)]
	public class OscillatorEvent : EventNode, IUpdatable // TypeDefIndex: 51686
	{
		// Fields
		public BBParameter<AnimationCurve> curve; // 0xB0
		private float time; // 0xB8
		private float value; // 0xBC
		private FlowOutput hi; // 0xC0
		private FlowOutput low; // 0xC8
	
		// Constructors
		public OscillatorEvent(); // 0x000000018A92FE3C-0x000000018A92FFEC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92FC1C-0x000000018A92FD44
		public override void OnGraphStarted(); // 0x0000000184DA6520-0x0000000184DA6530
		public void Update(); // 0x000000018A92FD44-0x000000018A92FE3C
		[CompilerGenerated]
		private float _RegisterPorts_b__6_0(); // 0x0000000184DA62F0-0x0000000184DA6300
	}

	[Category("Events/Other")]
	[Description("Called when the target variable change. (Not whenever it is set).")]
	[Name("On Variable Change", 0)]
	public class VariableChangedEvent : EventNode // TypeDefIndex: 51687
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter targetVariable; // 0xB0
		private FlowOutput fOut; // 0xB8
		private object newValue; // 0xC0
	
		// Properties
		public override string name { get; } // 0x000000018A93BB04-0x000000018A93BB54 
	
		// Constructors
		public VariableChangedEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A93B798-0x000000018A93B88C
		public override void OnGraphStoped(); // 0x000000018A93B88C-0x000000018A93B940
		protected override void RegisterPorts(); // 0x000000018A93B9F8-0x000000018A93BB04
		private void OnValueChanged(object value); // 0x000000018A93B940-0x000000018A93B9A4
		private void OnVariableRefChange(Variable newVarRef); // 0x000000018A93B9A4-0x000000018A93B9F8
		[CompilerGenerated]
		private object _RegisterPorts_b__7_0(); // 0x0000000184D892F0-0x0000000184D89300
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filter the Flow based on a percentage between min and max.\nFor example: With Min = 0, Max = 1 and Percentage = 0.5, the chance is 50%.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(float) })]
	public class Chance : FlowControlNode // TypeDefIndex: 51689
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 51688
		{
			// Fields
			public ValueInput<float> min; // 0x10
			public ValueInput<float> max; // 0x18
			public ValueInput<float> chance; // 0x20
			public FlowOutput success; // 0x28
			public FlowOutput failure; // 0x30
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A938C74-0x000000018A938D28
		}
	
		// Constructors
		public Chance(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92A8E8-0x000000018A92AAFC
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filters the flow execution so that it can\'t be called very frequently")]
	[ContextDefinedInputs(new System.Type[1] {typeof(float) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(float) })]
	public class Cooldown : FlowControlNode // TypeDefIndex: 51691
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
		public override string name { get; } // 0x000000018A92B22C-0x000000018A92B2B0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountDown_d__14 : IEnumerator<object> // TypeDefIndex: 51690
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Cooldown __4__this; // 0x20
			public Flow f; // 0x28
			private float _total_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CountDown_d__14(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A936FB8-0x000000018A9371C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9371C8-0x000000018A937214
		}
	
		// Constructors
		public Cooldown(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A92AEB0-0x000000018A92AECC
		public override void OnGraphStoped(); // 0x000000018A92ADDC-0x000000018A92AE24
		protected override void RegisterPorts(); // 0x000000018A92AECC-0x000000018A92B208
		private void Begin(Flow f); // 0x000000018A92AD6C-0x000000018A92ADDC
		private void Cancel(Flow f); // 0x000000018A92ADDC-0x000000018A92AE24
		[IteratorStateMachine(typeof(_CountDown_d__14))]
		private IEnumerator CountDown(Flow f); // 0x000000018A92AE24-0x000000018A92AEB0
		[CompilerGenerated]
		private float _RegisterPorts_b__11_0(); // 0x000000018A92B208-0x000000018A92B21C
		[CompilerGenerated]
		private float _RegisterPorts_b__11_1(); // 0x000000018A92B21C-0x000000018A92B22C
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filters Out to be called only once. After the first call, Out is no longer called until Reset is called")]
	public class DoOnce : FlowControlNode // TypeDefIndex: 51693
	{
		// Fields
		private bool called; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51692
		{
			// Fields
			public DoOnce __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A9398E0-0x000000018A939940
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A939A40-0x000000018A939A60
		}
	
		// Constructors
		public DoOnce(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000184DA6460-0x0000000184DA6470
		protected override void RegisterPorts(); // 0x000000018A92CAB8-0x000000018A92CC30
	}

	[Category("Variables/Flow")]
	[Description("Reads a named parameter from the incomming Flow and returns it\'s value.\nFlow parameters can be set with a WriteFlowParameter node.\nFlow parameters are temporary variables that exist only in the context of the same Flow.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Read Flow Param", 0)]
	public class ReadFlowParameter<T> : FlowControlNode // TypeDefIndex: 51695
	{
		// Fields
		private T flowValue;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51694
		{
			// Fields
			public ReadFlowParameter<T> __4__this;
			public ValueInput<string> pName;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReadFlowParameter();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Variables/Flow")]
	[Description("Writes (or creates) a named parameter to the incomming Flow, which you can later read with a ReadFlowParameter node.\nFlow parameters are temporary variables that exist only in the context of the same Flow.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[Name("Write Flow Param", 0)]
	public class WriteFlowParameter<T> : FlowControlNode // TypeDefIndex: 51697
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 51696
		{
			// Fields
			public ValueInput<string> pName;
			public ValueInput<T> pValue;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		public WriteFlowParameter();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Flow Controllers/Flow Convert")]
	[Description("Convert a Flow signal to boolean value")]
	[DeserializeFrom("FlowCanvas.Nodes.Latch")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(bool) })]
	[Name("Latch Condition", 0)]
	public class LatchBool : FlowControlNode // TypeDefIndex: 51699
	{
		// Fields
		private bool latched; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51698
		{
			// Fields
			public LatchBool __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939400-0x000000018A939454
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A9397F4-0x000000018A939848
			internal bool _RegisterPorts_b__2(); // 0x0000000187C376F8-0x0000000187C37718
		}
	
		// Constructors
		public LatchBool(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92E744-0x000000018A92E944
	}

	[Category("Flow Controllers/Flow Convert")]
	[Description("Convert a Flow signal to an integer value")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Latch Integer", 0)]
	public class LatchInt : FlowControlNode // TypeDefIndex: 51702
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private int latched; // 0xB4
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51700
		{
			// Fields
			public LatchInt __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _RegisterPorts_b__0(); // 0x000000018861D818-0x000000018861D838
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 51701
		{
			// Fields
			public int i; // 0x10
			public __c__DisplayClass2_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass2_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A939A60-0x000000018A939AC8
		}
	
		// Constructors
		public LatchInt(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92E944-0x000000018A92EB3C
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Await all flow inputs to be called within the max allowed await time before Out is called.\n- If MaxAwaitTime is 0, then all inputs must be called at the same time.\n- If MaxAwaitTime is -1, then the await time is infinity.")]
	[Name("AND", 0)]
	public class ANDMerge : FlowControlNode // TypeDefIndex: 51704
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 51703
		{
			// Fields
			public int i; // 0x10
			public ANDMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93A27C-0x000000018A93A2C8
		}
	
		// Constructors
		public ANDMerge(); // 0x000000018A929040-0x000000018A929054
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A928E78-0x000000018A928E80
		protected override void RegisterPorts(); // 0x000000018A928E80-0x000000018A928FFC
		private void Reset(); // 0x000000018A928FFC-0x000000018A929040
		private void Check(int index, Flow f); // 0x000000018A928D64-0x000000018A928E78
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Await all flow inputs to be called within the max allowed await time.\n- If MaxAwaitTime is 0, then all inputs must be called at the same time.\n- If MaxAwaitTime is -1, then the await time is infinity.")]
	[Obsolete("Use AND")]
	public class AwaitAll : FlowControlNode // TypeDefIndex: 51706
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 51705
		{
			// Fields
			public int i; // 0x10
			public AwaitAll __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93A27C-0x000000018A93A2C8
		}
	
		// Constructors
		public AwaitAll(); // 0x000000018A929530-0x000000018A92954C
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A928E78-0x000000018A928E80
		protected override void RegisterPorts(); // 0x000000018A9293B4-0x000000018A929530
		private void Reset(); // 0x000000018A928FFC-0x000000018A929040
		private void Check(int index, Flow f); // 0x000000018A928D64-0x000000018A928E78
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Calls Out when either input is called, but only once per frame regardless of how many inputs are called.")]
	[Name("OR", 0)]
	public class ORMerge : FlowControlNode // TypeDefIndex: 51708
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 51707
		{
			// Fields
			public int i; // 0x10
			public ORMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939BB0-0x000000018A939BFC
		}
	
		// Constructors
		public ORMerge(); // 0x000000018A929040-0x000000018A929054
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92F984-0x000000018A92FAD0
		private void Check(int index, Flow f); // 0x000000018A92F910-0x000000018A92F984
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Calls Out when either single Input is called, but no other is in the same frame.")]
	[Name("XOR", 0)]
	[Obsolete]
	public class XORMerge : FlowControlNode // TypeDefIndex: 51710
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51709
		{
			// Fields
			public int i; // 0x10
			public XORMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939DF4-0x000000018A939E40
		}
	
		// Constructors
		public XORMerge(); // 0x000000018A929040-0x000000018A929054
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A93C9B4-0x000000018A93CB30
		private void Check(int index, Flow f); // 0x000000018A93C8D4-0x000000018A93C9B4
	}

	[Category("Flow Controllers")]
	[Color("bf7fff")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Flow) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	public abstract class FlowControlNode : FlowNode // TypeDefIndex: 51711
	{
		// Constructors
		protected FlowControlNode(); // 0x000000018489BC70-0x000000018489BC80
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Can be used within a For Loop or For Each node, to Break the iteration.")]
	public class Break : FlowControlNode // TypeDefIndex: 51712
	{
		// Constructors
		public Break(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92A714-0x000000018A92A7BC
		[CompilerGenerated]
		private void _RegisterPorts_b__0_0(Flow f); // 0x000000018A92A7BC-0x000000018A92A7D8
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Enumerate a value (usualy a list or array) for each of it\'s elements. Remember that you can also enumerate a Transform for it\'s children.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IEnumerable) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(object) })]
	public class ForEach : FlowControlNode // TypeDefIndex: 51714
	{
		// Fields
		private object currentObject; // 0xB0
		private int currentIndex; // 0xB8
		private bool broken; // 0xBC
		private ValueInput<IEnumerable> enumerableInput; // 0xC0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51713
		{
			// Fields
			public ForEach __4__this; // 0x10
			public FlowOutput fFinish; // 0x18
			public FlowOutput fCurrent; // 0x20
			public FlowBreak __9__4; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x0000000188107360-0x0000000188107380
			internal int _RegisterPorts_b__1(); // 0x000000018861D898-0x000000018861D8B8
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018A939E40-0x000000018A93A224
			internal void _RegisterPorts_b__4(); // 0x0000000188622480-0x00000001886224A0
			internal void _RegisterPorts_b__3(Flow f); // 0x0000000188622480-0x00000001886224A0
		}
	
		// Constructors
		public ForEach(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92D97C-0x000000018A92DC78
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018A92D7E8-0x000000018A92D838
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018A92D838-0x000000018A92D97C
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Enumerate a value (usualy a list or array) for each of it\'s elements")]
	[ExposeAsDefinition]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class ForEach<T> : FlowControlNode // TypeDefIndex: 51716
	{
		// Fields
		private T currentObject;
		private int currentIndex;
		private bool broken;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 51715
		{
			// Fields
			public ForEach<T> __4__this;
			public ValueInput<IEnumerable<T>> list;
			public FlowOutput fFinish;
			public FlowOutput fCurrent;
			public FlowBreak __9__4;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
			internal int _RegisterPorts_b__1();
			internal void _RegisterPorts_b__2(Flow f);
			internal void _RegisterPorts_b__4();
			internal void _RegisterPorts_b__3(Flow f);
		}
	
		// Constructors
		public ForEach();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Perform a for loop")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	public class ForLoop : FlowControlNode // TypeDefIndex: 51718
	{
		// Fields
		[Tooltip("If true, loop will start from last and decrease by increment towards start")]
		public bool reverse; // 0xB0
		private int current; // 0xB4
		private bool broken; // 0xB8
		private ValueInput<int> first; // 0xC0
		private ValueInput<int> last; // 0xC8
		private ValueInput<int> step; // 0xD0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 51717
		{
			// Fields
			public ForLoop __4__this; // 0x10
			public FlowOutput fCurrent; // 0x18
			public FlowOutput fFinish; // 0x20
			public FlowBreak __9__3; // 0x28
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _RegisterPorts_b__0(); // 0x000000018861D818-0x000000018861D838
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A93A324-0x000000018A93A5FC
			internal void _RegisterPorts_b__3(); // 0x0000000188622540-0x0000000188622560
			internal void _RegisterPorts_b__2(Flow f); // 0x0000000188622540-0x0000000188622560
		}
	
		// Constructors
		public ForLoop(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92DC78-0x000000018A92DF94
	}

	[Description("Use for organization.")]
	[Name("Identity", 100)]
	public class Dummy : FlowControlNode // TypeDefIndex: 51720
	{
		// Properties
		public override string name { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51719
		{
			// Fields
			public FlowOutput fOut; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939940-0x000000018A939984
		}
	
		// Constructors
		public Dummy(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92CC30-0x000000018A92CD34
	}

	[Description("Stops and cease execution of the FlowSript")]
	public class Finish : FlowControlNode // TypeDefIndex: 51722
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 51721
		{
			// Fields
			public Finish __4__this; // 0x10
			public ValueInput<bool> c; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A938C04-0x000000018A938C74
		}
	
		// Constructors
		public Finish(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92D1A8-0x000000018A92D2CC
	}

	[Category("Flow Controllers/GOTO")]
	[Color("ff5c5c")]
	[Description("A Flow Control Label definition. Can be called with the GOTO node.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	[Name("GOTO Label Definition", 1)]
	public class GoToLabel : FlowControlNode, IEditorMenuCallbackReceiver // TypeDefIndex: 51723
	{
		// Fields
		[DelayedField]
		[Tooltip("The identifier name of the label")]
		public string identifier; // 0xB0
		[CompilerGenerated]
		private FlowOutput _port_k__BackingField; // 0xB8
	
		// Properties
		[HideInInspector]
		public FlowOutput port { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x0000000186AC5AF4-0x0000000186AC5B08
		public override string name { get; } // 0x000000018A92E0FC-0x000000018A92E154 
	
		// Constructors
		public GoToLabel(); // 0x000000018A92E0AC-0x000000018A92E0FC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92E048-0x000000018A92E0AC
	}

	[Description("Routes the Flow to the target GOTO label.")]
	[DoNotList]
	[ContextDefinedInputs(new System.Type[1] {typeof(Flow) })]
	public class GoToStatement : FlowControlNode, IHaveNodeReference // TypeDefIndex: 51724
	{
		// Fields
		[fsSerializeAs("_targetLabelUID")]
		public NodeReference<GoToLabel> _targetLabel; // 0xB0
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get; } // 0x0000000184D86250-0x0000000184D86260 
		private GoToLabel target { get; } // 0x000000018A92E38C-0x000000018A92E3DC 
		public override string name { get; } // 0x000000018A92E2FC-0x000000018A92E38C 
	
		// Constructors
		public GoToStatement(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public void SetTarget(GoToLabel newTarget); // 0x000000018A92E1FC-0x000000018A92E288
		protected override void RegisterPorts(); // 0x000000018A92E154-0x000000018A92E1FC
		[CompilerGenerated]
		private void _RegisterPorts_b__8_0(Flow f); // 0x000000018A92E288-0x000000018A92E2FC
	}

	[Description("Utility node to merge the flow. It\'s exactly the same as connecting multiple Flow outputs to the same Flow input.")]
	[Name("Merge", 89)]
	public class Merge : FlowControlNode // TypeDefIndex: 51725
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Constructors
		public Merge(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A92F434-0x000000018A92F530
	}

	[Description("Split the Flow in multiple directions. Calls all outputs in the same frame but in order")]
	[Name("Split", 90)]
	public class Split : FlowControlNode // TypeDefIndex: 51727
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51726
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public Split __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939564-0x000000018A93960C
		}
	
		// Constructors
		public Split(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A934CD8-0x000000018A934E74
	}

	[Description("Similar to Try/Catch/Finally in code")]
	public class TryCatch : FlowControlNode // TypeDefIndex: 51729
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 51728
		{
			// Fields
			public FlowOutput fTry; // 0x10
			public FlowOutput fCatch; // 0x18
			public FlowOutput fFinally; // 0x20
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A938E88-0x000000018A939018
		}
	
		// Constructors
		public TryCatch(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A936888-0x000000018A9369F4
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Start a Coroutine that will repeat until Break is signaled")]
	[Name("Coroutine", 0)]
	public class CoroutineState : FlowControlNode // TypeDefIndex: 51732
	{
		// Fields
		private bool active; // 0xB0
		private Coroutine coroutine; // 0xB8
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 51730
		{
			// Fields
			public CoroutineState __4__this; // 0x10
			public FlowOutput fStart; // 0x18
			public FlowOutput fUpdate; // 0x20
			public FlowOutput fFinish; // 0x28
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939BFC-0x000000018A939CA4
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A939A40-0x000000018A939A60
		}
	
		[CompilerGenerated]
		private sealed class _DoRepeat_d__4 : IEnumerator<object> // TypeDefIndex: 51731
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoRepeat_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A937214-0x000000018A9373E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9373E0-0x000000018A93742C
		}
	
		// Constructors
		public CoroutineState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStoped(); // 0x000000018A92B380-0x000000018A92B3B0
		protected override void RegisterPorts(); // 0x000000018A92B3B0-0x000000018A92B580
		[IteratorStateMachine(typeof(_DoRepeat_d__4))]
		private IEnumerator DoRepeat(FlowOutput fStart, FlowOutput fUpdate, FlowOutput fFinish, Flow f); // 0x000000018A92B2B0-0x000000018A92B380
		[CompilerGenerated]
		private void _DoRepeat_b__4_0(); // 0x0000000184DA6460-0x0000000184DA6470
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Once called, will continuously call \'Do\' while the input boolean condition is true. Once condition becomes or is false, \'Done\' is called")]
	[ContextDefinedInputs(new System.Type[1] {typeof(bool) })]
	[Name("While True", 0)]
	public class While : FlowControlNode // TypeDefIndex: 51736
	{
		// Fields
		private Coroutine coroutine; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 51733
		{
			// Fields
			public While __4__this; // 0x10
			public FlowOutput fUpdate; // 0x18
			public FlowOutput fFinish; // 0x20
			public ValueInput<bool> c; // 0x28
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939B18-0x000000018A939BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51734
		{
			// Fields
			public bool active; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _DoWhile_b__0(); // 0x0000000184D8CCB0-0x0000000184D8CCC0
		}
	
		[CompilerGenerated]
		private sealed class _DoWhile_d__4 : IEnumerator<object> // TypeDefIndex: 51735
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoWhile_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A93742C-0x000000018A93765C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A93765C-0x000000018A9376A8
		}
	
		// Constructors
		public While(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A93C6F0-0x000000018A93C708
		public override void OnGraphStoped(); // 0x000000018A93C708-0x000000018A93C74C
		protected override void RegisterPorts(); // 0x000000018A93C74C-0x000000018A93C8D4
		[IteratorStateMachine(typeof(_DoWhile_d__4))]
		private IEnumerator DoWhile(FlowOutput fUpdate, FlowOutput fFinish, Flow f, ValueInput<bool> condition); // 0x000000018A93C620-0x000000018A93C6F0
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the two input cases provided, based on a boolean Condition")]
	[ExposeAsDefinition]
	public class SelectOnBool<T> : FlowControlNode // TypeDefIndex: 51737
	{
		// Fields
		private ValueInput<bool> condition;
		private ValueInput<T> isTrue;
		private ValueInput<T> isFalse;
		private ValueOutput<T> result;
	
		// Constructors
		public SelectOnBool();
	
		// Methods
		protected override void RegisterPorts();
		[CompilerGenerated]
		private T _RegisterPorts_b__4_0();
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on an Enum")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(Enum) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class SelectOnEnum<T> : FlowControlNode // TypeDefIndex: 51739
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type;
	
		// Properties
		private System.Type type { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51738
		{
			// Fields
			public ValueInput selector;
			public ValueInput<T>[] cases;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
		}
	
		// Constructors
		public SelectOnEnum();
	
		// Methods
		protected override void RegisterPorts();
		public override System.Type GetNodeWildDefinitionType();
		public override void OnPortConnected(Port port, Port otherPort);
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on an Integer")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(int) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class SelectOnInt<T> : FlowControlNode // TypeDefIndex: 51741
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51740
		{
			// Fields
			public ValueInput<int> selector;
			public ValueInput<T>[] cases;
			public ValueInput<T> defaultCase;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
		}
	
		// Constructors
		public SelectOnInt();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on a String")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(string) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[HasRefreshButton]
	public class SelectOnString<T> : FlowControlNode // TypeDefIndex: 51743
	{
		// Fields
		[Name("Cases", 0)]
		public List<string> stringCases;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51742
		{
			// Fields
			public ValueInput<string> selector;
			public SelectOnString<T> __4__this;
			public ValueInput<T>[] cases;
			public ValueInput<T> defaultCase;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
		}
	
		// Constructors
		public SelectOnString();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the input cases provided, based on a GameObject\'s Tag")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[2] {typeof(Wild), typeof(GameObject) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[HasRefreshButton]
	public class SelectOnTag<T> : FlowControlNode // TypeDefIndex: 51745
	{
		// Fields
		[SerializeField]
		private string[] _tagNames;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51744
		{
			// Fields
			public ValueInput<GameObject> selector;
			public SelectOnTag<T> __4__this;
			public ValueInput<T>[] cases;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
		}
	
		// Constructors
		public SelectOnTag();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Calls one random output each time In is called.")]
	[ContextDefinedOutputs(new System.Type[2] {typeof(Flow), typeof(int) })]
	[Name("Switch Random", 0)]
	public class Random : FlowControlNode // TypeDefIndex: 51747
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
		private int current; // 0xB4
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51746
		{
			// Fields
			public Random __4__this; // 0x10
			public List<FlowOutput> outs; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939984-0x000000018A939A40
			internal int _RegisterPorts_b__1(); // 0x000000018861D818-0x000000018861D838
		}
	
		// Constructors
		public Random(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A931BAC-0x000000018A931DD4
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a conditional boolean value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(bool) })]
	[Name("Switch Condition", 0)]
	public class SwitchBool : FlowControlNode // TypeDefIndex: 51749
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 51748
		{
			// Fields
			public ValueInput<bool> selector; // 0x10
			public FlowOutput caseTrue; // 0x18
			public FlowOutput caseFalse; // 0x20
			public FlowOutput caseThen; // 0x28
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A938B88-0x000000018A938C04
		}
	
		// Constructors
		public SwitchBool(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A934E74-0x000000018A935020
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a comparison between two comparable objects")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IComparable) })]
	public class SwitchComparison : FlowControlNode // TypeDefIndex: 51751
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 51750
		{
			// Fields
			public ValueInput<IComparable> a; // 0x10
			public ValueInput<IComparable> b; // 0x18
			public FlowOutput equal; // 0x20
			public FlowOutput notEqual; // 0x28
			public FlowOutput greater; // 0x30
			public FlowOutput less; // 0x38
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A938D28-0x000000018A938E88
		}
	
		// Constructors
		public SwitchComparison(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A935020-0x000000018A935268
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an enum value.\nPlease connect an Enum first for the options to show, or directly select the enum type with the relevant button bellow.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Enum) })]
	public class SwitchEnum : FlowControlNode // TypeDefIndex: 51753
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB0
	
		// Properties
		private System.Type type { get; set; } // 0x00000001891C020C-0x00000001891C0220 0x000000018A935694-0x000000018A935744
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51752
		{
			// Fields
			public ValueInput selector; // 0x10
			public Dictionary<string, FlowOutput> cases; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939D3C-0x000000018A939DF4
		}
	
		// Constructors
		public SwitchEnum(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9353C8-0x000000018A935694
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018A935268-0x000000018A9352B8
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018A9352B8-0x000000018A9353C8
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an integer value. The Default output is called when the Index value is out of range.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[Name("Switch Integer", 0)]
	public class SwitchInt : FlowControlNode // TypeDefIndex: 51755
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51754
		{
			// Fields
			public ValueInput<int> selector; // 0x10
			public FlowOutput[] cases; // 0x18
			public FlowOutput defaultCase; // 0x20
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939770-0x000000018A9397F4
		}
	
		// Constructors
		public SwitchInt(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A935A14-0x000000018A935BFC
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an integer value. The Default output is called when the Index value is out of range.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[HasRefreshButton]
	[Name("Switch Integer Custom", 0)]
	public class SwitchIntCustom : FlowControlNode // TypeDefIndex: 51757
	{
		// Fields
		public List<int> intCases; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51756
		{
			// Fields
			public ValueInput<int> selector; // 0x10
			public SwitchIntCustom __4__this; // 0x18
			public FlowOutput[] cases; // 0x20
			public FlowOutput defaultCase; // 0x28
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93960C-0x000000018A939770
		}
	
		// Constructors
		public SwitchIntCustom(); // 0x000000018A93598C-0x000000018A935A14
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A935744-0x000000018A93598C
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Calls one output based on it\'s probability to be selected, in comparison to all other outputs. The probability of each output is respectively set by the same name float input.\nFor example, if all input values are the same (eg \'1\'), then all outputs have the same chance to be called.")]
	[ContextDefinedInputs(new System.Type[2] {typeof(Flow), typeof(float) })]
	public class SwitchProbability : FlowControlNode // TypeDefIndex: 51758
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
		public SwitchProbability(); // 0x000000018A929040-0x000000018A929054
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A935DB8-0x000000018A9360EC
		private void Enter(Flow f); // 0x000000018A935BFC-0x000000018A935DB8
		[CompilerGenerated]
		private int _RegisterPorts_b__5_0(); // 0x0000000184D9E810-0x0000000184D9E820
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a string value. The Default output is called if there is no other matching output same as the input value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(string) })]
	[HasRefreshButton]
	public class SwitchString : FlowControlNode // TypeDefIndex: 51760
	{
		// Fields
		[Name("Cases", 0)]
		public List<string> comparisonOutputs; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51759
		{
			// Fields
			public ValueInput<string> selector; // 0x10
			public SwitchString __4__this; // 0x18
			public FlowOutput[] cases; // 0x20
			public FlowOutput defaultCase; // 0x28
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93927C-0x000000018A939400
		}
	
		// Constructors
		public SwitchString(); // 0x000000018A936338-0x000000018A9363C0
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9360EC-0x000000018A936338
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on the tag of a GameObject value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(GameObject) })]
	[HasRefreshButton]
	public class SwitchTag : FlowControlNode // TypeDefIndex: 51762
	{
		// Fields
		[SerializeField]
		private string[] _tagNames; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51761
		{
			// Fields
			public SwitchTag __4__this; // 0x10
			public ValueInput<GameObject> selector; // 0x18
			public FlowOutput[] cases; // 0x20
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A939454-0x000000018A939564
		}
	
		// Constructors
		public SwitchTag(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A9363C0-0x000000018A936598
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Flip Flops between the 2 outputs each time In is called")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(bool) })]
	public class FlipFlop : FlowControlNode // TypeDefIndex: 51764
	{
		// Fields
		public bool isFlip; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get; } // 0x000000018A92D50C-0x000000018A92D584 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 51763
		{
			// Fields
			public FlipFlop __4__this; // 0x10
			public FlowOutput fFlip; // 0x18
			public FlowOutput fFlop; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93A224-0x000000018A93A27C
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A939A40-0x000000018A939A60
			internal bool _RegisterPorts_b__2(); // 0x0000000187C376F8-0x0000000187C37718
		}
	
		// Constructors
		public FlipFlop(); // 0x000000018A92D4FC-0x000000018A92D50C
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000184DA6470-0x0000000184DA6480
		public override void OnGraphStoped(); // 0x0000000184DA6480-0x0000000184DA6490
		protected override void RegisterPorts(); // 0x000000018A92D2CC-0x000000018A92D4FC
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Whenever In is called the \'current\' output is called as well. Calling \'+\' or \'-\' changes the current output respectively up or down.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Toggle (Multi)", 0)]
	public class MultiToggle : FlowControlNode // TypeDefIndex: 51766
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
		public override string name { get; } // 0x000000018A92F85C-0x000000018A92F8E0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 51765
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public MultiToggle __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93A624-0x000000018A93A6B8
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A93A7A8-0x000000018A93A7EC
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018A93A7EC-0x000000018A93A830
			internal int _RegisterPorts_b__3(); // 0x000000018A93A894-0x000000018A93A8B4
		}
	
		// Constructors
		public MultiToggle(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A92F530-0x000000018A92F56C
		public override void OnGraphStoped(); // 0x0000000184DA6510-0x0000000184DA6520
		protected override void RegisterPorts(); // 0x000000018A92F56C-0x000000018A92F85C
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Each time input is signaled, the next output in order is called. After the last output, the order loops from the start.\nReset, resets the current index to zero.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Flip Flop (Multi)", 0)]
	public class Sequence : FlowControlNode // TypeDefIndex: 51768
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
		public override string name { get; } // 0x000000018A9345F0-0x000000018A934674 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 51767
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public Sequence __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93A6B8-0x000000018A93A784
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A93A784-0x000000018A93A7A8
			internal int _RegisterPorts_b__2(); // 0x000000018A93A894-0x000000018A93A8B4
		}
	
		// Constructors
		public Sequence(); // 0x00000001891C2030-0x00000001891C2044
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A92F530-0x000000018A92F56C
		public override void OnGraphStoped(); // 0x0000000184DA6510-0x0000000184DA6520
		protected override void RegisterPorts(); // 0x000000018A934364-0x000000018A9345F0
	}

	[Category("Flow Controllers/Togglers")]
	[Description("When In is called, calls On or Off depending on the current toggle state. Whenever Toggle input is called the state changes.")]
	public class Toggle : FlowControlNode // TypeDefIndex: 51770
	{
		// Fields
		[Name("Start Open", 0)]
		public bool open; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get; } // 0x000000018A936810-0x000000018A936888 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 51769
		{
			// Fields
			public Toggle __4__this; // 0x10
			public FlowOutput fOn; // 0x18
			public FlowOutput fOff; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A93A2C8-0x000000018A93A304
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018A93A304-0x000000018A93A324
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018A939A40-0x000000018A939A60
			internal void _RegisterPorts_b__3(Flow f); // 0x000000018A93A5FC-0x000000018A93A624
		}
	
		// Constructors
		public Toggle(); // 0x000000018A92D4FC-0x000000018A92D50C
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000184DA6470-0x0000000184DA6480
		public override void OnGraphStoped(); // 0x0000000184DA6480-0x0000000184DA6490
		protected override void RegisterPorts(); // 0x000000018A936598-0x000000018A936810
	}

	[Category("Functions/Custom")]
	[Description("Calls an existing Custom Function")]
	[DeserializeFrom("FlowCanvas.Nodes.RelayFlowInput")]
	[DoNotList]
	[HasRefreshButton]
	[Name("Function Call", 0)]
	public class CustomFunctionCall : FlowControlNode // TypeDefIndex: 51771
	{
		// Fields
		[SerializeField]
		private string _sourceOutputUID; // 0xB0
		private ValueInput[] portArgs; // 0xB8
		private object[] objectArgs; // 0xC0
		private FlowOutput fOut; // 0xC8
		private WeakReference<CustomFunctionEvent> _sourceFunctionRef; // 0xD0
	
		// Properties
		private string sourceFunctionUID { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D84CE0-0x0000000184D84D00
		public CustomFunctionEvent sourceFunction { get; } // 0x000000018A92BC2C-0x000000018A92BD88 
		public override string name { get; } // 0x000000018A92BBA4-0x000000018A92BC2C 
		public override string description { get; } // 0x000000018A92BB40-0x000000018A92BBA4 
	
		// Constructors
		public CustomFunctionCall(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public void SetFunction(CustomFunctionEvent func); // 0x000000018A92BA48-0x000000018A92BB08
		protected override void RegisterPorts(); // 0x000000018A92B72C-0x000000018A92BA48
		private void Invoke(Flow f); // 0x000000018A92B580-0x000000018A92B72C
		[CompilerGenerated]
		private bool _get_sourceFunction_b__9_0(CustomFunctionEvent i); // 0x000000018A92BB08-0x000000018A92BB40
	}

	[Category("Functions/Custom")]
	[Description("A custom function, defined by any number of parameters and an optional return value. It can be called using the \'Call Custom Function\' node. To end the function and optionally return a value, the \'Return\' node should be used.")]
	[DeserializeFrom("FlowCanvas.Nodes.RelayFlowOutput")]
	[Name("New Custom Function", 10)]
	public class CustomFunctionEvent : EventNode, IInvokable, IEditorMenuCallbackReceiver // TypeDefIndex: 51776
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
		public List<DynamicParameterDefinition> parameters { get; private set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x0000000186AC5AF4-0x0000000186AC5B08
		public DynamicParameterDefinition returns { get; private set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		private System.Type returnType { get; } // 0x000000018A92C884-0x000000018A92C8A4 
		private System.Type[] parameterTypes { get; } // 0x000000018A92C75C-0x000000018A92C884 
		public override string name { get; } // 0x000000018A92C71C-0x000000018A92C75C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 51772
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<DynamicParameterDefinition, System.Type> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A93A96C-0x000000018A93A9D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal System.Type _get_parameterTypes_b__15_0(DynamicParameterDefinition p); // 0x000000018A938B70-0x000000018A938B88
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 51773
		{
			// Fields
			public int i; // 0x10
			public CustomFunctionEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A9391DC-0x000000018A939214
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 51774
		{
			// Fields
			public Action<object> callback; // 0x10
			public CustomFunctionEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _NodeCanvas.Framework.IInvokable.InvokeAsync_b__0(Flow f); // 0x000000018A939848-0x000000018A93987C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 51775
		{
			// Fields
			public CustomFunctionEvent __4__this; // 0x10
			public FlowHandler flowCallback; // 0x18
			public Flow f; // 0x20
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _InvokeAsync_b__0(object o); // 0x000000018A93987C-0x000000018A9398E0
		}
	
		// Constructors
		public CustomFunctionEvent(); // 0x000000018A92C61C-0x000000018A92C71C
	
		// Methods
		public override void OnGraphStoped(); // 0x000000018A92C41C-0x000000018A92C450
		protected override void RegisterPorts(); // 0x000000018A92C450-0x000000018A92C5EC
		string IInvokable.GetInvocationID(); // 0x0000000184D86250-0x0000000184D86260
		object IInvokable.Invoke(params object[] args); // 0x000000018A92C3DC-0x000000018A92C41C
		void IInvokable.InvokeAsync(Action<object> callback, params object[] args); // 0x000000018A92C2CC-0x000000018A92C3DC
		public object Invoke(Flow f, params object[] args); // 0x000000018A92C1C4-0x000000018A92C2CC
		public void InvokeAsync(Flow f, FlowHandler flowCallback, params object[] args); // 0x000000018A92C040-0x000000018A92C1C4
		public object GetReturnValue(); // 0x0000000184D876B0-0x0000000184D876C0
		private void AddParameter(System.Type type); // 0x000000018A92BD88-0x000000018A92BE64
		private void GatherPortsUpdateRefs(); // 0x000000018A92BE64-0x000000018A92C040
		[CompilerGenerated]
		private void _Invoke_b__23_0(object o); // 0x000000018678D7BC-0x000000018678D7D0
		[CompilerGenerated]
		private bool _GatherPortsUpdateRefs_b__27_0(CustomFunctionCall n); // 0x000000018A92C5EC-0x000000018A92C61C
	}

	[Category("Functions/Custom")]
	[Description("Should always be used to return out of a Custom Function. The return value is only required if the Custom Function returns a value as well.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(object) })]
	public class Return : FlowControlNode // TypeDefIndex: 51777
	{
		// Fields
		[GatherPortsCallback]
		public bool useReturnValue; // 0xB0
		private ValueInput<object> returnPort; // 0xB8
	
		// Constructors
		public Return(); // 0x000000018A92D4FC-0x000000018A92D50C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A934110-0x000000018A934208
		[CompilerGenerated]
		private void _RegisterPorts_b__2_0(Flow f); // 0x000000018A934208-0x000000018A934284
	}

	public abstract class CallableActionNodeBase : SimplexNode // TypeDefIndex: 51778
	{
		// Constructors
		protected CallableActionNodeBase(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class CallableActionNode : CallableActionNodeBase // TypeDefIndex: 51780
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51779
		{
			// Fields
			public CallableActionNode __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f); // 0x000000018A939214-0x000000018A93927C
		}
	
		// Constructors
		protected CallableActionNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node); // 0x000000018A92A7D8-0x000000018A92A8E8
	}

	public abstract class CallableActionNode<T1> : CallableActionNodeBase // TypeDefIndex: 51782
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51781
		{
			// Fields
			public CallableActionNode<T1> __4__this;
			public ValueInput<T1> p1;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2> : CallableActionNodeBase // TypeDefIndex: 51784
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51783
		{
			// Fields
			public CallableActionNode<T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3> : CallableActionNodeBase // TypeDefIndex: 51786
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51785
		{
			// Fields
			public CallableActionNode<T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4> : CallableActionNodeBase // TypeDefIndex: 51788
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51787
		{
			// Fields
			public CallableActionNode<T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5> : CallableActionNodeBase // TypeDefIndex: 51790
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51789
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6> : CallableActionNodeBase // TypeDefIndex: 51792
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51791
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7> : CallableActionNodeBase // TypeDefIndex: 51794
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51793
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : CallableActionNodeBase // TypeDefIndex: 51796
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51795
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableActionNodeBase // TypeDefIndex: 51798
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51797
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableActionNodeBase // TypeDefIndex: 51800
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51799
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		protected CallableActionNode();
	
		// Methods
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNodeBase : SimplexNode // TypeDefIndex: 51801
	{
		// Constructors
		protected CallableFunctionNodeBase(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class CallableFunctionNode<TResult> : CallableFunctionNodeBase // TypeDefIndex: 51803
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51802
		{
			// Fields
			public CallableFunctionNode<TResult> __4__this;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1> : CallableFunctionNodeBase // TypeDefIndex: 51805
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51804
		{
			// Fields
			public CallableFunctionNode<TResult, T1> __4__this;
			public ValueInput<T1> p1;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2> : CallableFunctionNodeBase // TypeDefIndex: 51807
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51806
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3> : CallableFunctionNodeBase // TypeDefIndex: 51809
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51808
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4> : CallableFunctionNodeBase // TypeDefIndex: 51811
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51810
		{
			// Fields
			public CallableFunctionNode<TResult, T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5> : CallableFunctionNodeBase // TypeDefIndex: 51813
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51812
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
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : CallableFunctionNodeBase // TypeDefIndex: 51815
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51814
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
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : CallableFunctionNodeBase // TypeDefIndex: 51817
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51816
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
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : CallableFunctionNodeBase // TypeDefIndex: 51819
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51818
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
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableFunctionNodeBase // TypeDefIndex: 51821
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51820
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
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableFunctionNodeBase // TypeDefIndex: 51823
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 51822
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
			public __c__DisplayClass2_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
			internal void _OnRegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		protected CallableFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class ExtractorNode : SimplexNode // TypeDefIndex: 51825
	{
		// Fields
		private static Dictionary<System.Type, System.Type> _extractors; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 51824
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A93A908-0x000000018A93A96C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetExtractorType_b__1_0(System.Type t); // 0x000000018A938B50-0x000000018A938B70
		}
	
		// Constructors
		protected ExtractorNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static System.Type GetExtractorType(System.Type type); // 0x000000018A92CD34-0x000000018A92D1A8
	}

	public abstract class ExtractorNode<TInstance, T1, T2> : ExtractorNode // TypeDefIndex: 51827
	{
		// Fields
		private T1 a;
		private T2 b;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 51826
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal T1 _OnRegisterPorts_b__0();
			internal T2 _OnRegisterPorts_b__1();
		}
	
		// Constructors
		protected ExtractorNode();
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3> : ExtractorNode // TypeDefIndex: 51829
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 51828
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _OnRegisterPorts_b__0();
			internal T2 _OnRegisterPorts_b__1();
			internal T3 _OnRegisterPorts_b__2();
		}
	
		// Constructors
		protected ExtractorNode();
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4> : ExtractorNode // TypeDefIndex: 51831
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 51830
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3, T4> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal T1 _OnRegisterPorts_b__0();
			internal T2 _OnRegisterPorts_b__1();
			internal T3 _OnRegisterPorts_b__2();
			internal T4 _OnRegisterPorts_b__3();
		}
	
		// Constructors
		protected ExtractorNode();
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5> : ExtractorNode // TypeDefIndex: 51833
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 51832
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3, T4, T5> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal T1 _OnRegisterPorts_b__0();
			internal T2 _OnRegisterPorts_b__1();
			internal T3 _OnRegisterPorts_b__2();
			internal T4 _OnRegisterPorts_b__3();
			internal T5 _OnRegisterPorts_b__4();
		}
	
		// Constructors
		protected ExtractorNode();
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d, out ref T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> : ExtractorNode // TypeDefIndex: 51835
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
		private T6 f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 51834
		{
			// Fields
			public ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> __4__this;
			public ValueInput<TInstance> i;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal T1 _OnRegisterPorts_b__0();
			internal T2 _OnRegisterPorts_b__1();
			internal T3 _OnRegisterPorts_b__2();
			internal T4 _OnRegisterPorts_b__3();
			internal T5 _OnRegisterPorts_b__4();
			internal T6 _OnRegisterPorts_b__5();
		}
	
		// Constructors
		protected ExtractorNode();
	
		// Methods
		public abstract void Invoke(TInstance instance, out ref T1 a, out ref T2 b, out ref T3 c, out ref T4 d, out ref T5 e, out ref T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class AddDictionaryItem<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string, T> // TypeDefIndex: 51836
	{
		// Constructors
		public AddDictionaryItem();
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key, T item);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class GetDictionaryItem<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 51837
	{
		// Constructors
		public GetDictionaryItem();
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class RemoveDictionaryKey<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string> // TypeDefIndex: 51838
	{
		// Constructors
		public RemoveDictionaryKey();
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class ClearDictionary : CallableFunctionNode<IDictionary, IDictionary> // TypeDefIndex: 51839
	{
		// Constructors
		public ClearDictionary(); // 0x000000018A92AB24-0x000000018A92AB4C
	
		// Methods
		public override IDictionary Invoke(IDictionary dict); // 0x000000018A92AAFC-0x000000018A92AB24
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class TryGetValue<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 51840
	{
		// Fields
		[CompilerGenerated]
		private bool _exists_k__BackingField;
	
		// Properties
		public bool exists { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public TryGetValue();
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class DictionaryContainsKey<T> : CallableFunctionNode<bool, IDictionary<string, T>, string> // TypeDefIndex: 51841
	{
		// Constructors
		public DictionaryContainsKey();
	
		// Methods
		public override bool Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Lists")]
	public class ClearList : CallableFunctionNode<IList, IList> // TypeDefIndex: 51842
	{
		// Constructors
		public ClearList(); // 0x000000018A92AB74-0x000000018A92AB9C
	
		// Methods
		public override IList Invoke(IList list); // 0x000000018A92AB4C-0x000000018A92AB74
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class AddListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 51843
	{
		// Constructors
		public AddListItem();
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class InsertListItem<T> : CallableFunctionNode<IList<T>, List<T>, int, T> // TypeDefIndex: 51844
	{
		// Constructors
		public InsertListItem();
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class RemoveListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 51845
	{
		// Constructors
		public RemoveListItem();
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class RemoveListItemAt<T> : CallableFunctionNode<IList<T>, List<T>, int> // TypeDefIndex: 51846
	{
		// Constructors
		public RemoveListItemAt();
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class SetListItem<T> : CallableFunctionNode<IList<T>, IList<T>, int, T> // TypeDefIndex: 51847
	{
		// Constructors
		public SetListItem();
	
		// Methods
		public override IList<T> Invoke(IList<T> list, int index, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class ShuffleList<T> : CallableFunctionNode<IList<T>, IList<T>> // TypeDefIndex: 51848
	{
		// Constructors
		public ShuffleList();
	
		// Methods
		public override IList<T> Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetListItem<T> : PureFunctionNode<T, IList<T>, int> // TypeDefIndex: 51849
	{
		// Constructors
		public GetListItem();
	
		// Methods
		public override T Invoke(IList<T> list, int index);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetRandomListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 51850
	{
		// Constructors
		public GetRandomListItem();
	
		// Methods
		public override T Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetLastListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 51851
	{
		// Constructors
		public GetLastListItem();
	
		// Methods
		public override T Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetFirstListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 51852
	{
		// Constructors
		public GetFirstListItem();
	
		// Methods
		public override T Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetListItemIndex : PureFunctionNode<int, IList, object> // TypeDefIndex: 51853
	{
		// Constructors
		public GetListItemIndex(); // 0x000000018A92E020-0x000000018A92E048
	
		// Methods
		public override int Invoke(IList list, object item); // 0x000000018A92DFF8-0x000000018A92E020
	}

	[Category("Operators")]
	[Description("Returns if the object is not null")]
	[Name("Is Valid", 0)]
	public class IsNotNull : PureFunctionNode<bool, object> // TypeDefIndex: 51854
	{
		// Constructors
		public IsNotNull(); // 0x000000018A92E670-0x000000018A92E698
	
		// Methods
		public override bool Invoke(object OBJECT); // 0x000000018A92E650-0x000000018A92E670
	}

	[Category("Operators")]
	[Description("Returns whether the input object is of type T as well as the object itself for convenience.")]
	public class IsOfType : PureFunctionNode<bool, object, System.Type> // TypeDefIndex: 51855
	{
		// Fields
		[CompilerGenerated]
		private object _OBJECT_k__BackingField; // 0x30
	
		// Properties
		public object OBJECT { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		public IsOfType(); // 0x000000018A92E71C-0x000000018A92E744
	
		// Methods
		public override bool Invoke(object OBJECT, System.Type type); // 0x000000018A92E698-0x000000018A92E71C
	}

	[Category("Operators/Any")]
	[Description("Any Greater Than")]
	[Name(">", 0)]
	public class AnyGreaterThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 51856
	{
		// Constructors
		public AnyGreaterThan(); // 0x000000018A92927C-0x000000018A9292A4
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018A92924C-0x000000018A92927C
	}

	[Category("Operators/Any")]
	[Description("Any Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class AnyGreaterEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 51857
	{
		// Constructors
		public AnyGreaterEqualThan(); // 0x000000018A929224-0x000000018A92924C
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018A9291D8-0x000000018A929224
	}

	[Category("Operators/Any")]
	[Description("Any Less Than")]
	[Name("<", 0)]
	public class AnyLessThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 51858
	{
		// Constructors
		public AnyLessThan(); // 0x000000018A929348-0x000000018A929370
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018A929318-0x000000018A929348
	}

	[Category("Operators/Any")]
	[Description("Any Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class AnyLessEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 51859
	{
		// Constructors
		public AnyLessEqualThan(); // 0x000000018A9292F0-0x000000018A929318
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018A9292A4-0x000000018A9292F0
	}

	[Category("Operators/Any")]
	[Description("Any Equal To")]
	[Name("=", 0)]
	public class AnyEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 51860
	{
		// Constructors
		public AnyEqual(); // 0x000000018A9291B0-0x000000018A9291D8
	
		// Methods
		public override bool Invoke(object a, object b); // 0x000000018A92919C-0x000000018A9291B0
	}

	[Category("Operators/Any")]
	[Description("Any Not Equal To")]
	[Name("\u2260", 0)]
	public class AnyNotEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 51861
	{
		// Constructors
		public AnyNotEqual(); // 0x000000018A92938C-0x000000018A9293B4
	
		// Methods
		public override bool Invoke(object a, object b); // 0x000000018A929370-0x000000018A92938C
	}

	[Category("Operators/Floats")]
	[Description("Float Add")]
	[Name("+", 0)]
	public class FloatAdd : PureFunctionNode<float, float, float> // TypeDefIndex: 51862
	{
		// Constructors
		public FloatAdd(); // 0x000000018A92D584-0x000000018A92D5AC
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000184DA6490-0x0000000184DA64A0
	}

	[Category("Operators/Floats")]
	[Description("Float Subtract")]
	[Name("-", 0)]
	public class FloatSubtract : PureFunctionNode<float, float, float> // TypeDefIndex: 51863
	{
		// Constructors
		public FloatSubtract(); // 0x000000018A92D7C0-0x000000018A92D7E8
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000184DA64C0-0x0000000184DA64D0
	}

	[Category("Operators/Floats")]
	[Description("Float Mutliply")]
	[Name("\u00D7", 0)]
	public class FloatMultiply : PureFunctionNode<float, float, float> // TypeDefIndex: 51864
	{
		// Constructors
		public FloatMultiply(); // 0x000000018A92D70C-0x000000018A92D734
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000184DA1D40-0x0000000184DA1D50
	}

	[Category("Operators/Floats")]
	[Description("Float Divide")]
	[Name("\u00F7", 0)]
	public class FloatDivide : PureFunctionNode<float, float, float> // TypeDefIndex: 51865
	{
		// Constructors
		public FloatDivide(); // 0x000000018A92D5AC-0x000000018A92D5D4
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000186989EC8-0x0000000186989ED0
	}

	[Category("Operators/Floats")]
	[Description("Float Modulo")]
	[Name("%", 0)]
	public class FloatModulo : PureFunctionNode<float, float, float> // TypeDefIndex: 51866
	{
		// Constructors
		public FloatModulo(); // 0x000000018A92D6E4-0x000000018A92D70C
	
		// Methods
		public override float Invoke(float value, float mod); // 0x0000000184DA64B0-0x0000000184DA64C0
	}

	[Category("Operators/Floats")]
	[Description("Float Greater Than")]
	[Name(">", 0)]
	public class FloatGreaterThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 51867
	{
		// Constructors
		public FloatGreaterThan(); // 0x000000018A92D634-0x000000018A92D65C
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018A92D62C-0x000000018A92D634
	}

	[Category("Operators/Floats")]
	[Description("Float Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class FloatGreaterEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 51868
	{
		// Constructors
		public FloatGreaterEqualThan(); // 0x000000018A92D604-0x000000018A92D62C
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018A92D5FC-0x000000018A92D604
	}

	[Category("Operators/Floats")]
	[Description("Float Less Than")]
	[Name("<", 0)]
	public class FloatLessThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 51869
	{
		// Constructors
		public FloatLessThan(); // 0x000000018A92D6BC-0x000000018A92D6E4
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018A92D6B4-0x000000018A92D6BC
	}

	[Category("Operators/Floats")]
	[Description("Float Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class FloatLessEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 51870
	{
		// Constructors
		public FloatLessEqualThan(); // 0x000000018A92D68C-0x000000018A92D6B4
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018A92D684-0x000000018A92D68C
	}

	[Category("Operators/Floats")]
	[Description("Float Equal To")]
	[Name("=", 0)]
	public class FloatEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 51871
	{
		// Constructors
		public FloatEqual(); // 0x000000018A92D5D4-0x000000018A92D5FC
	
		// Methods
		public override bool Invoke(float a, float b); // 0x0000000189617CE8-0x0000000189617CF8
	}

	[Category("Operators/Floats")]
	[Description("Float Not Equal To")]
	[Name("\u2260", 0)]
	public class FloatNotEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 51872
	{
		// Constructors
		public FloatNotEqual(); // 0x000000018A92D744-0x000000018A92D76C
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018A92D734-0x000000018A92D744
	}

	[Category("Operators/Floats")]
	[Description("Float Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class FloatInvert : PureFunctionNode<float, float> // TypeDefIndex: 51873
	{
		// Constructors
		public FloatInvert(); // 0x000000018A92D65C-0x000000018A92D684
	
		// Methods
		public override float Invoke(float value); // 0x0000000184DA64A0-0x0000000184DA64B0
	}

	[Category("Operators/Floats")]
	[Description("Float Round value to closest of interval ( round(value / interval) * interval )")]
	public class FloatSnap : PureFunctionNode<int, float, int> // TypeDefIndex: 51874
	{
		// Constructors
		public FloatSnap(); // 0x000000018A92D798-0x000000018A92D7C0
	
		// Methods
		public override int Invoke(float value, int interval); // 0x000000018A92D76C-0x000000018A92D798
	}

	[Category("Operators/Integers")]
	[Description("Integer Add")]
	[Name("+", 0)]
	public class IntegerAdd : PureFunctionNode<int, int, int> // TypeDefIndex: 51875
	{
		// Constructors
		public IntegerAdd(); // 0x000000018A92E3DC-0x000000018A92E404
	
		// Methods
		public override int Invoke(int a, int b); // 0x0000000184DA64D0-0x0000000184DA64E0
	}

	[Category("Operators/Integers")]
	[Description("Integer Subtract")]
	[Name("-", 0)]
	public class IntegerSubtract : PureFunctionNode<int, int, int> // TypeDefIndex: 51876
	{
		// Constructors
		public IntegerSubtract(); // 0x000000018A92E628-0x000000018A92E650
	
		// Methods
		public override int Invoke(int a, int b); // 0x0000000184DA64F0-0x0000000184DA6500
	}

	[Category("Operators/Integers")]
	[Description("Integer Multiply")]
	[Name("\u00D7", 0)]
	public class IntegerMultiply : PureFunctionNode<int, int, int> // TypeDefIndex: 51877
	{
		// Constructors
		public IntegerMultiply(); // 0x000000018A92E580-0x000000018A92E5A8
	
		// Methods
		public override int Invoke(int a, int b); // 0x0000000184DA1D30-0x0000000184DA1D40
	}

	[Category("Operators/Integers")]
	[Description("Integer Divide")]
	[Name("\u00F7", 0)]
	public class IntegerDivide : PureFunctionNode<int, int, int> // TypeDefIndex: 51878
	{
		// Constructors
		public IntegerDivide(); // 0x000000018A92E414-0x000000018A92E43C
	
		// Methods
		public override int Invoke(int a, int b); // 0x000000018A92E404-0x000000018A92E414
	}

	[Category("Operators/Integers")]
	[Description("Integer Modulo")]
	[Name("%", 0)]
	public class IntegerModulo : PureFunctionNode<int, int, int> // TypeDefIndex: 51879
	{
		// Constructors
		public IntegerModulo(); // 0x000000018A92E558-0x000000018A92E580
	
		// Methods
		public override int Invoke(int value, int mod); // 0x000000018A92E54C-0x000000018A92E558
	}

	[Category("Operators/Integers")]
	[Description("Integer Greater Than")]
	[Name(">", 0)]
	public class IntegerGreaterThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 51880
	{
		// Constructors
		public IntegerGreaterThan(); // 0x000000018A92E49C-0x000000018A92E4C4
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018A92E494-0x000000018A92E49C
	}

	[Category("Operators/Integers")]
	[Description("Integer Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class IntegerGreaterEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 51881
	{
		// Constructors
		public IntegerGreaterEqualThan(); // 0x000000018A92E46C-0x000000018A92E494
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018A92E464-0x000000018A92E46C
	}

	[Category("Operators/Integers")]
	[Description("Integer Less Than")]
	[Name("<", 0)]
	public class IntegerLessThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 51882
	{
		// Constructors
		public IntegerLessThan(); // 0x000000018A92E524-0x000000018A92E54C
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018A92E51C-0x000000018A92E524
	}

	[Category("Operators/Integers")]
	[Description("Integer Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class IntegerLessEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 51883
	{
		// Constructors
		public IntegerLessEqualThan(); // 0x000000018A92E4F4-0x000000018A92E51C
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018A92E4EC-0x000000018A92E4F4
	}

	[Category("Operators/Integers")]
	[Description("Integer Equal To")]
	[Name("=", 0)]
	public class IntegerEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 51884
	{
		// Constructors
		public IntegerEqual(); // 0x000000018A92E43C-0x000000018A92E464
	
		// Methods
		public override bool Invoke(int a, int b); // 0x0000000189619760-0x0000000189619768
	}

	[Category("Operators/Integers")]
	[Description("Integer Not Equal To")]
	[Name("\u2260", 0)]
	public class IntegerNotEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 51885
	{
		// Constructors
		public IntegerNotEqual(); // 0x000000018A92E5B0-0x000000018A92E5D8
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018A92E5A8-0x000000018A92E5B0
	}

	[Category("Operators/Integers")]
	[Description("Integer Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class IntegerInvert : PureFunctionNode<int, int> // TypeDefIndex: 51886
	{
		// Constructors
		public IntegerInvert(); // 0x000000018A92E4C4-0x000000018A92E4EC
	
		// Methods
		public override int Invoke(int value); // 0x0000000184DA64E0-0x0000000184DA64F0
	}

	[Category("Operators/Integers")]
	[Description("Integer Round value to closest of interval ( round(value / interval) * interval )")]
	public class IntegerSnap : PureFunctionNode<int, int, int> // TypeDefIndex: 51887
	{
		// Constructors
		public IntegerSnap(); // 0x000000018A92E600-0x000000018A92E628
	
		// Methods
		public override int Invoke(int value, int interval); // 0x000000018A92E5D8-0x000000018A92E600
	}

	[Category("Operators/Boolean")]
	[Description("Boolean Equal To")]
	[Name("=", 0)]
	public class BooleanEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 51888
	{
		// Constructors
		public BooleanEqual(); // 0x000000018A92A6BC-0x000000018A92A6E4
	
		// Methods
		public override bool Invoke(bool a, bool b); // 0x00000001892FCD58-0x00000001892FCD64
	}

	[Category("Operators/Boolean")]
	[Description("Boolean Not Equal To")]
	[Name("\u2260", 0)]
	public class BooleanNotEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 51889
	{
		// Constructors
		public BooleanNotEqual(); // 0x000000018A92A6EC-0x000000018A92A714
	
		// Methods
		public override bool Invoke(bool a, bool b); // 0x000000018A92A6E4-0x000000018A92A6EC
	}

	[Category("Operators/Boolean")]
	[Description("True if A and B are both true")]
	public class AND : PureFunctionNode<bool> // TypeDefIndex: 51890
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public AND(); // 0x000000018A929174-0x000000018A92919C
	
		// Methods
		public override bool Invoke(); // 0x000000018A929054-0x000000018A9290B8
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018A9290B8-0x000000018A929174
	}

	[Category("Operators/Boolean")]
	[Description("True if A or B is true")]
	public class OR : PureFunctionNode<bool> // TypeDefIndex: 51891
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public OR(); // 0x000000018A92FBF4-0x000000018A92FC1C
	
		// Methods
		public override bool Invoke(); // 0x000000018A92FAD0-0x000000018A92FB38
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018A92FB38-0x000000018A92FBF4
	}

	[Category("Operators/Boolean")]
	[Description("True if A or B is true, but not both")]
	public class XOR : PureFunctionNode<bool> // TypeDefIndex: 51892
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public XOR(); // 0x000000018A93CC64-0x000000018A93CC8C
	
		// Methods
		public override bool Invoke(); // 0x000000018A93CB30-0x000000018A93CBA8
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018A93CBA8-0x000000018A93CC64
	}

	[Category("Operators/Boolean")]
	[Description("Inverts the input")]
	public class NOT : PureFunctionNode<bool, bool> // TypeDefIndex: 51893
	{
		// Constructors
		public NOT(); // 0x000000018A92F8E8-0x000000018A92F910
	
		// Methods
		public override bool Invoke(bool value); // 0x000000018A92F8E0-0x000000018A92F8E8
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Equal To")]
	[Name("=", 0)]
	public class Vector3Equal : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 51894
	{
		// Constructors
		public Vector3Equal(); // 0x000000018A93BC8C-0x000000018A93BCB4
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b); // 0x000000018A93BC38-0x000000018A93BC8C
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Not Equal To")]
	[Name("\u2260", 0)]
	public class Vector3NotEqual : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 51895
	{
		// Constructors
		public Vector3NotEqual(); // 0x000000018A93BDE8-0x000000018A93BE10
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b); // 0x000000018A93BD94-0x000000018A93BDE8
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Add")]
	[Name("+", 0)]
	public class Vector3Add : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 51896
	{
		// Constructors
		public Vector3Add(); // 0x000000018A93BBB0-0x000000018A93BBD8
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b); // 0x000000018A93BB54-0x000000018A93BBB0
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Subtract")]
	[Name("-", 0)]
	public class Vector3Subtract : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 51897
	{
		// Constructors
		public Vector3Subtract(); // 0x000000018A93BE6C-0x000000018A93BE94
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b); // 0x000000018A93BE10-0x000000018A93BE6C
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Multiply")]
	[Name("\u00D7", 0)]
	public class Vector3Multiply : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 51898
	{
		// Constructors
		public Vector3Multiply(); // 0x000000018A93BD6C-0x000000018A93BD94
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b); // 0x000000018A93BD28-0x000000018A93BD6C
	}

	[Category("Operators/Vector3")]
	[Description("Vectro3 Divide")]
	[Name("\u00F7", 0)]
	public class Vector3Divide : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 51899
	{
		// Constructors
		public Vector3Divide(); // 0x000000018A93BC10-0x000000018A93BC38
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b); // 0x000000018A93BBD8-0x000000018A93BC10
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class Vector3Invert : PureFunctionNode<Vector3, Vector3> // TypeDefIndex: 51900
	{
		// Constructors
		public Vector3Invert(); // 0x000000018A93BD00-0x000000018A93BD28
	
		// Methods
		public override Vector3 Invoke(Vector3 value); // 0x000000018A93BCB4-0x000000018A93BD00
	}

	[Category("Operators/Flags")]
	[Description("Bitwise logical AND & operator")]
	[Name("AND", 0)]
	public class BitwiseAnd<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 51901
		where T : Enum
	{
		// Constructors
		public BitwiseAnd();
	
		// Methods
		public override T Invoke(T a, T b);
	}

	[Category("Operators/Flags")]
	[Description("Bitwise logical OR | operator")]
	[Name("OR", 0)]
	public class BitwiseOr<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 51902
		where T : Enum
	{
		// Constructors
		public BitwiseOr();
	
		// Methods
		public override T Invoke(T a, T b);
	}

	[Category("Operators/Flags")]
	[Description("Bitwise complement ~ operator")]
	[Name("Invert", 0)]
	public class BitwiseInvert<T> : PureFunctionNode<T, T> // TypeDefIndex: 51903
		where T : Enum
	{
		// Constructors
		public BitwiseInvert();
	
		// Methods
		public override T Invoke(T a);
	}

	[Category("Time")]
	[Description("Wait for a certain amount of time before continueing")]
	public class Wait : LatentActionNode<float> // TypeDefIndex: 51905
	{
		// Fields
		[CompilerGenerated]
		private float _timeLeft_k__BackingField; // 0x68
		[CompilerGenerated]
		private float _normalized_k__BackingField; // 0x6C
	
		// Properties
		public float timeLeft { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8F060-0x0000000184D8F070 0x0000000184D8F090-0x0000000184D8F0A0
		public float normalized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA3230-0x0000000184DA3240 0x0000000184DA3330-0x0000000184DA3340
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__8 : IEnumerator<object> // TypeDefIndex: 51904
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Wait __4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__8(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938A54-0x000000018A938B04
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938B04-0x000000018A938B50
		}
	
		// Constructors
		public Wait(); // 0x000000018A93C5F8-0x000000018A93C620
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__8))]
		public override IEnumerator Invoke(float time = 1f /* Metadata: 0x02331C1D */); // 0x000000018A93C58C-0x000000018A93C5F8
	}

	[Category("Time")]
	[Description("Wait for one (the next) frame")]
	public class WaitForOneFrame : LatentActionNode // TypeDefIndex: 51907
	{
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 51906
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__2(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A9381F4-0x000000018A938230
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9382A0-0x000000018A9382EC
		}
	
		// Constructors
		public WaitForOneFrame(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke(); // 0x000000018A93C344-0x000000018A93C388
	}

	[Category("Time")]
	[Description("Wait until the physics update frame")]
	public class WaitForPhysicsFrame : LatentActionNode // TypeDefIndex: 51909
	{
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 51908
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__2(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938184-0x000000018A9381F4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9382EC-0x000000018A938338
		}
	
		// Constructors
		public WaitForPhysicsFrame(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke(); // 0x000000018A93C388-0x000000018A93C3CC
	}

	[Category("Time")]
	[Description("Wait until the end of current frame")]
	public class WaitForEndOfFrame : LatentActionNode // TypeDefIndex: 51911
	{
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 51910
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__2(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938230-0x000000018A9382A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938338-0x000000018A938384
		}
	
		// Constructors
		public WaitForEndOfFrame(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke(); // 0x000000018A93C300-0x000000018A93C344
	}

	[Category("Time")]
	[Description("Wait Until condition value becomes true")]
	public class WaitUntil : LatentActionNode // TypeDefIndex: 51913
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__3 : IEnumerator<object> // TypeDefIndex: 51912
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WaitUntil __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__3(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938384-0x000000018A938468
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A93854C-0x000000018A938598
		}
	
		// Constructors
		public WaitUntil(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__3))]
		public override IEnumerator Invoke(); // 0x000000018A93C3CC-0x000000018A93C428
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018A93C428-0x000000018A93C4AC
	}

	[Category("Time")]
	[Description("Wait While condition value is true")]
	public class WaitWhile : LatentActionNode // TypeDefIndex: 51915
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__3 : IEnumerator<object> // TypeDefIndex: 51914
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WaitWhile __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__3(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938468-0x000000018A93854C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938598-0x000000018A9385E4
		}
	
		// Constructors
		public WaitWhile(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__3))]
		public override IEnumerator Invoke(); // 0x000000018A93C4AC-0x000000018A93C508
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018A93C508-0x000000018A93C58C
	}

	[Category("Time")]
	[Description("Mutliply input value by Time.deltaTime and optional multiplier")]
	[Name("Per Second (Float)", 0)]
	public class DeltaTimed : PureFunctionNode<float, float, float> // TypeDefIndex: 51916
	{
		// Constructors
		public DeltaTimed(); // 0x000000018A92CA90-0x000000018A92CAB8
	
		// Methods
		public override float Invoke(float value, float multiplier = 1f /* Metadata: 0x02331C21 */); // 0x000000018A92CA5C-0x000000018A92CA90
	}

	[Category("Time")]
	[Description("Mutliply input value by Time.deltaTime and optional multiplier")]
	[Name("Per Second (Vector3)", 0)]
	public class DeltaTimedVector3 : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 51917
	{
		// Constructors
		public DeltaTimedVector3(); // 0x000000018A92CA34-0x000000018A92CA5C
	
		// Methods
		public override Vector3 Invoke(Vector3 value, float multiplier = 1f /* Metadata: 0x02331C25 */); // 0x000000018A92C9B0-0x000000018A92CA34
	}

	[Category("Time")]
	[Description("Input values are buffered and returned in order of buffering once the buffered amount reaches the buffer size. In practice this creates a delayed value output when the node is constantly updated per-frame.\nWhen the node ceases to update, a new buffer is created.")]
	[ExposeAsDefinition]
	public class Buffer<T> : PureFunctionNode<T, T, int> // TypeDefIndex: 51918
	{
		// Fields
		private int lastFrame;
		private Queue<T> q;
	
		// Constructors
		public Buffer();
	
		// Methods
		public override T Invoke(T value, int size = 60 /* Metadata: 0x02331C29 */);
	}

	[Category("Time")]
	[Description("Returns a smoothly interpolated value towards the input value.")]
	[Name("Damp (Float)", 0)]
	public class DampFloat : PureFunctionNode<float, float, float, float> // TypeDefIndex: 51919
	{
		// Constructors
		public DampFloat(); // 0x000000018A92C8F0-0x000000018A92C918
	
		// Methods
		public override float Invoke(float current, float target, float damp = 1f /* Metadata: 0x02331C2A */); // 0x000000018A92C8A4-0x000000018A92C8F0
	}

	[Category("Time")]
	[Description("Returns a smoothly interpolated value towards the input value.")]
	[Name("Damp (Vector3)", 0)]
	public class DampVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float> // TypeDefIndex: 51920
	{
		// Constructors
		public DampVector3(); // 0x000000018A92C988-0x000000018A92C9B0
	
		// Methods
		public override Vector3 Invoke(Vector3 current, Vector3 target, float damp = 1f /* Metadata: 0x02331C2E */); // 0x000000018A92C918-0x000000018A92C988
	}

	[Category("Tweening/Values")]
	public class LerpFloat : PureFunctionNode<float, float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51921
	{
		// Constructors
		public LerpFloat(); // 0x000000018A92F2A0-0x000000018A92F2C8
	
		// Methods
		public override float Invoke(float a, float b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018A92F28C-0x000000018A92F2A0
	}

	[Category("Tweening/Values")]
	public class LerpVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51922
	{
		// Constructors
		public LerpVector3(); // 0x000000018A92F3BC-0x000000018A92F3E4
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018A92F348-0x000000018A92F3BC
	}

	[Category("Tweening/Values")]
	public class LerpQuaternion : PureFunctionNode<Quaternion, Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51923
	{
		// Constructors
		public LerpQuaternion(); // 0x000000018A92F320-0x000000018A92F348
	
		// Methods
		public override Quaternion Invoke(Quaternion a, Quaternion b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018A92F2C8-0x000000018A92F320
	}

	[Category("Tweening/Values")]
	public class LerpColor : PureFunctionNode<UnityEngine.Color, UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51924
	{
		// Constructors
		public LerpColor(); // 0x000000018A92F264-0x000000018A92F28C
	
		// Methods
		public override UnityEngine.Color Invoke(UnityEngine.Color a, UnityEngine.Color b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018A92F20C-0x000000018A92F264
	}

	[Category("Tweening/Values")]
	public class TweenFloat : LatentActionNode<float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51926
	{
		// Fields
		[CompilerGenerated]
		private float _value_k__BackingField; // 0x68
	
		// Properties
		public float value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8F060-0x0000000184D8F070 0x0000000184D8F090-0x0000000184D8F0A0
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 51925
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A9385E4-0x000000018A93868C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9389BC-0x000000018A938A08
		}
	
		// Constructors
		public TweenFloat(); // 0x000000018A936B5C-0x000000018A936B84
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(float from, float to, float duration = 1f /* Metadata: 0x02331C32 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C36 */); // 0x000000018A936ABC-0x000000018A936B5C
	}

	[Category("Tweening/Values")]
	public class TweenVector3 : LatentActionNode<Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51928
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _value_k__BackingField; // 0x68
	
		// Properties
		public Vector3 value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D91E20-0x0000000184D91E40 0x0000000184D91E40-0x0000000184D91E50
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 51927
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938834-0x000000018A938924
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938924-0x000000018A938970
		}
	
		// Constructors
		public TweenVector3(); // 0x000000018A936F90-0x000000018A936FB8
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(Vector3 from, Vector3 to, float duration = 1f /* Metadata: 0x02331C37 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C3B */); // 0x000000018A936EE0-0x000000018A936F90
	}

	[Category("Tweening/Values")]
	public class TweenQuaternion : LatentActionNode<Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51930
	{
		// Fields
		[CompilerGenerated]
		private Quaternion _value_k__BackingField; // 0x68
	
		// Properties
		public Quaternion value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA63C0-0x0000000184DA63D0 0x0000000184DA63D0-0x0000000184DA63E0
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 51929
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A93868C-0x000000018A938760
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938A08-0x000000018A938A54
		}
	
		// Constructors
		public TweenQuaternion(); // 0x000000018A936D00-0x000000018A936D28
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(Quaternion from, Quaternion to, float duration = 1f /* Metadata: 0x02331C3C */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C40 */); // 0x000000018A936C60-0x000000018A936D00
	}

	[Category("Tweening/Values")]
	public class TweenColor : LatentActionNode<UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 51932
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.Color _value_k__BackingField; // 0x68
	
		// Properties
		public UnityEngine.Color value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA63C0-0x0000000184DA63D0 0x0000000184DA63D0-0x0000000184DA63E0
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 51931
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A938760-0x000000018A938834
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938970-0x000000018A9389BC
		}
	
		// Constructors
		public TweenColor(); // 0x000000018A936A94-0x000000018A936ABC
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(UnityEngine.Color from, UnityEngine.Color to, float duration = 1f /* Metadata: 0x02331C41 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C45 */); // 0x000000018A9369F4-0x000000018A936A94
	}

	[Category("Tweening")]
	public class TweenPosition : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 51934
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 51933
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__0(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A937C48-0x000000018A937E74
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9380EC-0x000000018A938138
		}
	
		// Constructors
		public TweenPosition(); // 0x000000018A936C38-0x000000018A936C60
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 position, float duration = 0.25f /* Metadata: 0x02331C46 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C4A */, bool relative = false /* Metadata: 0x02331C4B */); // 0x000000018A936B84-0x000000018A936C38
	}

	[Category("Tweening")]
	public class TweenRotation : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 51936
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 51935
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__0(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A937A24-0x000000018A937C48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A938138-0x000000018A938184
		}
	
		// Constructors
		public TweenRotation(); // 0x000000018A936DDC-0x000000018A936E04
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 rotation, float duration = 0.25f /* Metadata: 0x02331C4C */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C50 */, bool relative = false /* Metadata: 0x02331C51 */); // 0x000000018A936D28-0x000000018A936DDC
	}

	[Category("Tweening")]
	public class TweenScale : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 51938
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 51937
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__0(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A937E74-0x000000018A9380A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9380A0-0x000000018A9380EC
		}
	
		// Constructors
		public TweenScale(); // 0x000000018A936EB8-0x000000018A936EE0
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 scale, float duration = 0.25f /* Metadata: 0x02331C52 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02331C56 */, bool relative = false /* Metadata: 0x02331C57 */); // 0x000000018A936E04-0x000000018A936EB8
	}

	[Category("Unity")]
	[Description("If \'Try Get Existing\' is true, then if there is an existing component of that type already attached to the gameobject, it will be returned instead of adding another instance.")]
	public class AddComponent<T> : CallableFunctionNode<T, GameObject, bool> // TypeDefIndex: 51939
		where T : Component
	{
		// Constructors
		public AddComponent();
	
		// Methods
		public override T Invoke(GameObject gameObject, bool tryGetExisting);
	}

	[Category("Unity")]
	[Description("Get a component attached on an object")]
	public class GetComponent<T> : PureFunctionNode<T, GameObject> // TypeDefIndex: 51940
		where T : Component
	{
		// Fields
		private T _component;
	
		// Constructors
		public GetComponent();
	
		// Methods
		public override T Invoke(GameObject gameObject);
	}

	[Category("Unity")]
	[Description("Instantiate an object")]
	[ExposeAsDefinition]
	public class Instantiate<T> : CallableFunctionNode<T, T, Vector3, Quaternion, Transform> // TypeDefIndex: 51941
		where T : UnityEngine.Object
	{
		// Constructors
		public Instantiate();
	
		// Methods
		public override T Invoke(T original, Vector3 position, Quaternion rotation, Transform parent);
	}

	[Category("Unity")]
	[Description("Creates a new ScriptableObject instance")]
	public class NewScriptableObject<T> : CallableFunctionNode<T> // TypeDefIndex: 51942
		where T : ScriptableObject
	{
		// Constructors
		public NewScriptableObject();
	
		// Methods
		public override T Invoke();
	}

	[Category("Unity")]
	[Description("Get all child transforms of specified parent")]
	public class GetChildTransforms : PureFunctionNode<IEnumerable<Transform>, Transform> // TypeDefIndex: 51943
	{
		// Constructors
		public GetChildTransforms(); // 0x000000018A92DFD0-0x000000018A92DFF8
	
		// Methods
		public override IEnumerable<Transform> Invoke(Transform parent); // 0x000000018A92DF94-0x000000018A92DFD0
	}

	[Category("Utility")]
	[Description("Custom cast input object to type T. Note that casts are already automatic at a connection-level. Use this only if necessary in your setup.")]
	[ExposeAsDefinition]
	public class Cast<T> : PureFunctionNode<T, object> // TypeDefIndex: 51944
	{
		// Constructors
		public Cast();
	
		// Methods
		public override T Invoke(object obj);
	}

	[Category("Utility")]
	[Description("Use this for organization. It returns exactly what is provided in the input.")]
	[ExposeAsDefinition]
	[Name("Identity", 10)]
	public class Identity<T> : PureFunctionNode<T, T> // TypeDefIndex: 51945
	{
		// Properties
		public override string name { get; }
	
		// Constructors
		public Identity();
	
		// Methods
		public override T Invoke(T value);
	}

	[Category("Utility")]
	[Description("Caches the value only when the node is called.")]
	[ExposeAsDefinition]
	[Name("Cache", 9)]
	public class Cache<T> : CallableFunctionNode<T, T> // TypeDefIndex: 51946
	{
		// Constructors
		public Cache();
	
		// Methods
		public override T Invoke(T value);
	}

	[Category("Utility")]
	[Description("Remaps from input min/max to output min/max, by current value provided between input min/max")]
	[Name("Remap To Float", 0)]
	public class RemapFloat : PureFunctionNode<float, float, float, float, float, float> // TypeDefIndex: 51947
	{
		// Constructors
		public RemapFloat(); // 0x000000018A934044-0x000000018A93406C
	
		// Methods
		public override float Invoke(float current, float iMin, float iMax = 1f /* Metadata: 0x02331C58 */, float oMin = 0f /* Metadata: 0x02331C5C */, float oMax = 100f /* Metadata: 0x02331C60 */); // 0x000000018A934018-0x000000018A934044
	}

	[Category("Utility")]
	[Description("Remaps from input min/max to output min/max, by current value provided between input min/max")]
	[Name("Remap To Vector3", 0)]
	public class RemapVector3 : PureFunctionNode<Vector3, float, float, float, Vector3, Vector3> // TypeDefIndex: 51948
	{
		// Constructors
		public RemapVector3(); // 0x000000018A9340E8-0x000000018A934110
	
		// Methods
		public override Vector3 Invoke(float current, float iMin, float iMax, Vector3 oMin, Vector3 oMax); // 0x000000018A93406C-0x000000018A9340E8
	}

	[Category("Utility")]
	[Description("Log input value on the console")]
	public class LogValue : CallableActionNode<object> // TypeDefIndex: 51949
	{
		// Constructors
		public LogValue(); // 0x000000018A92F40C-0x000000018A92F434
	
		// Methods
		public override void Invoke(object obj); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("Utility")]
	[Description("Log text in the console")]
	public class LogText : CallableActionNode<string> // TypeDefIndex: 51950
	{
		// Constructors
		public LogText(); // 0x000000018A92F3E4-0x000000018A92F40C
	
		// Methods
		public override void Invoke(string text); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("Utility")]
	[Description("Send a Local Event to specified graph")]
	public class SendEvent : CallableActionNode<GraphOwner, string> // TypeDefIndex: 51951
	{
		// Constructors
		public SendEvent(); // 0x000000018A9342BC-0x000000018A9342E4
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName); // 0x000000018A934284-0x000000018A9342BC
	}

	[Category("Utility")]
	[Description("Send a Local Event with 1 argument to specified graph")]
	[ExposeAsDefinition]
	public class SendEvent<T> : CallableActionNode<GraphOwner, string, T> // TypeDefIndex: 51952
	{
		// Constructors
		public SendEvent();
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName, T eventValue);
	}

	[Category("Utility")]
	[Description("Send a Global Event to all graphs")]
	public class SendGlobalEvent : CallableActionNode<string> // TypeDefIndex: 51953
	{
		// Constructors
		public SendGlobalEvent(); // 0x000000018A93433C-0x000000018A934364
	
		// Methods
		public override void Invoke(string eventName); // 0x000000018A9342E4-0x000000018A93433C
	}

	[Category("Utility")]
	[Description("Send a Global Event with 1 argument to all graphs")]
	[ExposeAsDefinition]
	public class SendGlobalEvent<T> : CallableActionNode<string, T> // TypeDefIndex: 51954
	{
		// Constructors
		public SendGlobalEvent();
	
		// Methods
		public override void Invoke(string eventName, T eventValue);
	}

	public abstract class LatentActionNodeBase : SimplexNode // TypeDefIndex: 51958
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
		public override string name { get; } // 0x000000018A92F058-0x000000018A92F0FC 
		public virtual bool allowRoutineQueueing { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Nested types
		public enum InvocationMode // TypeDefIndex: 51955
		{
			QueueCalls = 0,
			FilterCalls = 1
		}
	
		private struct RoutineData // TypeDefIndex: 51956
		{
			// Fields
			public IEnumerator enumerator; // 0x00
			public Flow flow; // 0x08
	
			// Constructors
			public RoutineData(IEnumerator enumerator, Flow flow); // 0x00000001847D81D0-0x00000001847D8210
		}
	
		[CompilerGenerated]
		private sealed class _InternalCoroutine_d__15 : IEnumerator<object> // TypeDefIndex: 51957
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RoutineData data; // 0x20
			public LatentActionNodeBase __4__this; // 0x50
			private Flow _f_5__2; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _InternalCoroutine_d__15(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A9376A8-0x000000018A9379D8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A9379D8-0x000000018A937A24
		}
	
		// Constructors
		protected LatentActionNodeBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public sealed override void OnGraphStarted(); // 0x0000000184DA6500-0x0000000184DA6510
		public sealed override void OnGraphStoped(); // 0x000000018A92EE1C-0x000000018A92EE2C
		protected void Begin(IEnumerator enumerator, Flow f); // 0x000000018A92EB3C-0x000000018A92ECD0
		protected void BreakAll(bool callFinish); // 0x000000018A92ECD0-0x000000018A92ED94
		[IteratorStateMachine(typeof(_InternalCoroutine_d__15))]
		private IEnumerator InternalCoroutine(RoutineData data); // 0x000000018A92ED94-0x000000018A92EE1C
		protected override void OnRegisterPorts(FlowNode node); // 0x000000018A92EE2C-0x000000018A92F040
		protected abstract void OnRegisterDerivedPorts(FlowNode node);
		public virtual void OnBreak(); // 0x00000001841E1670-0x00000001841E1680
		[CompilerGenerated]
		private void _InternalCoroutine_b__15_0(); // 0x000000018A92F040-0x000000018A92F04C
		[CompilerGenerated]
		private void _OnRegisterPorts_b__16_0(Flow f); // 0x000000018A92F040-0x000000018A92F04C
		[CompilerGenerated]
		private void _OnRegisterPorts_b__16_1(Flow f); // 0x000000018A92F04C-0x000000018A92F058
	}

	public abstract class LatentActionNode : LatentActionNodeBase // TypeDefIndex: 51959
	{
		// Constructors
		protected LatentActionNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract IEnumerator Invoke();
		protected sealed override void OnRegisterDerivedPorts(FlowNode node); // 0x000000018A92F0FC-0x000000018A92F1B4
		[CompilerGenerated]
		private void _OnRegisterDerivedPorts_b__1_0(Flow f); // 0x000000018A92F1B4-0x000000018A92F20C
	}

	public abstract class LatentActionNode<T1> : LatentActionNodeBase // TypeDefIndex: 51961
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51960
		{
			// Fields
			public LatentActionNode<T1> __4__this;
			public ValueInput<T1> p1;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2> : LatentActionNodeBase // TypeDefIndex: 51963
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51962
		{
			// Fields
			public LatentActionNode<T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3> : LatentActionNodeBase // TypeDefIndex: 51965
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51964
		{
			// Fields
			public LatentActionNode<T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4> : LatentActionNodeBase // TypeDefIndex: 51967
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51966
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5> : LatentActionNodeBase // TypeDefIndex: 51969
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51968
		{
			// Fields
			public LatentActionNode<T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6> : LatentActionNodeBase // TypeDefIndex: 51971
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51970
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7> : LatentActionNodeBase // TypeDefIndex: 51973
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51972
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : LatentActionNodeBase // TypeDefIndex: 51975
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51974
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : LatentActionNodeBase // TypeDefIndex: 51977
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51976
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : LatentActionNodeBase // TypeDefIndex: 51979
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51978
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _OnRegisterDerivedPorts_b__0(Flow f);
		}
	
		// Constructors
		protected LatentActionNode();
	
		// Methods
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterDerivedPorts(FlowNode node);
	}

	public abstract class PureFunctionNodeBase : SimplexNode // TypeDefIndex: 51980
	{
		// Constructors
		protected PureFunctionNodeBase(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class PureFunctionNode<TResult> : PureFunctionNodeBase // TypeDefIndex: 51981
	{
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node);
		[CompilerGenerated]
		private TResult _OnRegisterPorts_b__1_0();
	}

	public abstract class PureFunctionNode<TResult, T1> : PureFunctionNodeBase // TypeDefIndex: 51983
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51982
		{
			// Fields
			public PureFunctionNode<TResult, T1> __4__this;
			public ValueInput<T1> p1;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2> : PureFunctionNodeBase // TypeDefIndex: 51985
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51984
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3> : PureFunctionNodeBase // TypeDefIndex: 51987
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51986
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4> : PureFunctionNodeBase // TypeDefIndex: 51989
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51988
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5> : PureFunctionNodeBase // TypeDefIndex: 51991
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51990
		{
			// Fields
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ValueInput<T5> p5;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : PureFunctionNodeBase // TypeDefIndex: 51993
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51992
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : PureFunctionNodeBase // TypeDefIndex: 51995
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51994
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : PureFunctionNodeBase // TypeDefIndex: 51997
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51996
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : PureFunctionNodeBase // TypeDefIndex: 51999
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 51998
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : PureFunctionNodeBase // TypeDefIndex: 52001
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 52000
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
			public __c__DisplayClass1_0();
	
			// Methods
			internal TResult _OnRegisterPorts_b__0();
		}
	
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
		protected sealed override void OnRegisterPorts(FlowNode node);
	}

	[SpoofAOT]
	public abstract class SimplexNode // TypeDefIndex: 52002
	{
		// Fields
		[NonSerialized]
		private string _name; // 0x10
		[NonSerialized]
		private string _description; // 0x18
		[CompilerGenerated]
		private FlowNode _parentNode_k__BackingField; // 0x20
		private ParameterInfo[] _parameters; // 0x28
	
		// Properties
		protected FlowNode parentNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public virtual string name { get; } // 0x000000018A934B30-0x000000018A934C14 
		public virtual string description { get; } // 0x000000018A934A88-0x000000018A934B30 
		public ParameterInfo[] parameters { get; } // 0x000000018A934C14-0x000000018A934CD8 
	
		// Constructors
		protected SimplexNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void RegisterPorts(FlowNode node); // 0x000000018A93486C-0x000000018A93496C
		public void SetDefaultParameters(FlowNode node); // 0x000000018A93496C-0x000000018A934A88
		protected abstract void OnRegisterPorts(FlowNode node);
		protected virtual void OnRegisterExtraPorts(FlowNode node); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphStarted(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphPaused(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphUnpaused(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphStoped(); // 0x00000001841E1670-0x00000001841E1680
	}

	[DoNotList]
	public abstract class SimplexNodeWrapper : FlowNode // TypeDefIndex: 52003
	{
		// Constructors
		protected SimplexNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	}

	public class SimplexNodeWrapper<T> : SimplexNodeWrapper // TypeDefIndex: 52004
		where T : SimplexNode
	{
		// Fields
		[SerializeField]
		private T _simplexNode;
	
		// Properties
		public T simplexNode { get; }
		public override string name { get; }
		public override string description { get; }
	
		// Constructors
		public SimplexNodeWrapper();
	
		// Methods
		public override System.Type GetNodeWildDefinitionType();
		public override void OnCreate(NodeCanvas.Framework.Graph assignedGraph);
		public override void OnGraphStarted();
		public override void OnGraphPaused();
		public override void OnGraphUnpaused();
		public override void OnGraphStoped();
		protected override void RegisterPorts();
	}

	public delegate void EventUniversalDelegate(); // TypeDefIndex: 52005; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void EventUniversalDelegate<in T1>(T1 arg1); // TypeDefIndex: 52006; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2>(T1 arg1, T2 arg2); // TypeDefIndex: 52007; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 52008; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 52009; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 52010; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 52011; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7); // TypeDefIndex: 52012; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); // TypeDefIndex: 52013; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9); // TypeDefIndex: 52014; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10); // TypeDefIndex: 52015; 0x00000000-0x00000000

	[AttributeUsage(AttributeTargets.Class)]
	public class GeneratedKeyAttribute : Attribute // TypeDefIndex: 52016
	{
		// Fields
		private string memberString; // 0x10
	
		// Properties
		public string MemberName { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public GeneratedKeyAttribute(string memberName); // 0x00000001853908C0-0x00000001853908D0
	}

	public struct ParamDef // TypeDefIndex: 52017
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

	public struct ParametresDef // TypeDefIndex: 52018
	{
		// Fields
		public List<ParamDef> paramDefinitions; // 0x00
		public ParamDef instanceDef; // 0x08
		public ParamDef resultDef; // 0x40
	}

	public enum ParamMode // TypeDefIndex: 52019
	{
		Undefined = 0,
		In = 1,
		Out = 2,
		Ref = 3,
		Instance = 4,
		Result = 6
	}

	public static class ReflectedNodesHelper // TypeDefIndex: 52020
	{
		// Fields
		private const string RETURN_VALUE_NAME = "Value"; // Metadata: 0x02331C6C
	
		// Methods
		public static ParamDef GetGetterDefFromInfo(MemberInfo info); // 0x000000018A9329F4-0x000000018A932C34
		public static ParamDef GetDefFromInfo(ParameterInfo info, bool last); // 0x000000018A932740-0x000000018A932918
		public static bool InitParams(System.Type targetType, bool isStatic, MemberInfo[] infos, out ParametresDef parametres); // 0x000000018A932C34-0x000000018A932F00
		private static bool InitParams(ParameterInfo[] prms, System.Type returnType, ref ParametresDef parametres); // 0x000000018A932F00-0x000000018A9331B8
		public static bool InitParams(ConstructorInfo constructor, out ParametresDef parametres); // 0x000000018A9331B8-0x000000018A933388
		public static bool InitParams(MethodInfo method, out ParametresDef parametres); // 0x000000018A9335AC-0x000000018A9337C0
		public static bool InitParams(System.Reflection.FieldInfo field, out ParametresDef parametres); // 0x000000018A933388-0x000000018A9335AC
		public static string GetGeneratedKey(MemberInfo memberInfo); // 0x000000018A932918-0x000000018A9329F4
	}

	public delegate void UniversalDelegate(UniversalDelegateParam[] delegateParams); // TypeDefIndex: 52021; 0x0000000182B46B90-0x0000000182B46BA0

	public abstract class UniversalDelegateParam // TypeDefIndex: 52022
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
		protected UniversalDelegateParam(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract System.Type GetCurrentType();
		public abstract void RegisterAsInput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node, Action beforeReturn);
		public abstract void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn);
		public abstract void SetFromInput();
		public abstract void SetFromValue(object value);
	}

	public class UniversalDelegateParam<T> : UniversalDelegateParam // TypeDefIndex: 52024
	{
		// Fields
		public T value;
		private ValueInput<T> valueInput;
		private static System.Reflection.FieldInfo _fieldInfo;
	
		// Properties
		public override System.Reflection.FieldInfo ValueField { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 52023
		{
			// Fields
			public Delegate beforeReturn;
			public UniversalDelegateParam<T> __4__this;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal T _RegisterAsOutputInternal_b__0();
		}
	
		// Constructors
		public UniversalDelegateParam();
	
		// Methods
		public override System.Type GetCurrentType();
		public override void RegisterAsInput(FlowNode node);
		private void RegisterAsOutputInternal(FlowNode node, Delegate beforeReturn);
		public override void RegisterAsOutput(FlowNode node);
		public override void RegisterAsOutput(FlowNode node, Action beforeReturn);
		public override void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn);
		public override void SetFromInput();
		public override void SetFromValue(object newValue);
	}

	public class UniversalDelegateParam<TArray, TValue> : UniversalDelegateParam<TArray> // TypeDefIndex: 52025
	{
		// Fields
		private ValueInput<TValue>[] valueInputs;
	
		// Constructors
		public UniversalDelegateParam();
	
		// Methods
		public override void RegisterAsInput(FlowNode node);
		public override void SetFromInput();
	}

	public abstract class BaseReflectedConstructorNode // TypeDefIndex: 52026
	{
		// Fields
		[CompilerGenerated]
		private static Func<ConstructorInfo, BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode; // 0x00
		protected ConstructorInfo constructorInfo; // 0x10
		protected List<ParamDef> paramDefinitions; // 0x18
		protected ParamDef instanceDef; // 0x20
		protected ParamDef resultDef; // 0x58
		protected ReflectedMethodRegistrationOptions options; // 0x90
	
		// Events
		protected static event Func<ConstructorInfo, BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode {
			add; // 0x000000018A9298F8-0x000000018A929994
			remove; // 0x000000018A929994-0x000000018A929A30
		}
	
		// Constructors
		protected BaseReflectedConstructorNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static BaseReflectedConstructorNode GetConstructorNode(ConstructorInfo targetConstructor, ReflectedMethodRegistrationOptions options); // 0x000000018A92954C-0x000000018A929700
		protected bool Init(ConstructorInfo constructor, ParametresDef parametres); // 0x000000018A929700-0x000000018A9298F8
		protected abstract bool InitInternal(ConstructorInfo constructor);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectionConstructorNode : BaseReflectedConstructorNode // TypeDefIndex: 52030
	{
		// Fields
		private object resultObject; // 0x98
		private object[] callParams; // 0xA0
		private ValueInput[] inputs; // 0xA8
		private ValueInput[] arrayInputs; // 0xB0
		private int arrayParamsInput; // 0xB8
		private System.Type arrayParamsType; // 0xC0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 52027
		{
			// Fields
			public bool callable; // 0x10
			public PureReflectionConstructorNode __4__this; // 0x18
			public int idx; // 0x20
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterOutput_b__0(); // 0x000000018A93A8B4-0x000000018A93A908
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 52028
		{
			// Fields
			public PureReflectionConstructorNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A93906C-0x000000018A9390A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 52029
		{
			// Fields
			public FlowOutput output; // 0x10
			public __c__DisplayClass10_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass10_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__1(Flow flow); // 0x000000018A9390A8-0x000000018A939114
		}
	
		// Constructors
		public PureReflectionConstructorNode(); // 0x0000000184DA2320-0x0000000184DA2330
	
		// Methods
		protected override bool InitInternal(ConstructorInfo constructor); // 0x000000018A93142C-0x000000018A9315A0
		private void Call(); // 0x000000018A9312A0-0x000000018A93142C
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx); // 0x000000018A931758-0x000000018A931858
		private void RegisterInput(FlowNode node, ParamDef def, int idx); // 0x000000018A9315A0-0x000000018A931758
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options); // 0x000000018A931858-0x000000018A931BAC
	}

	[SpoofAOT]
	public class ReflectedDelegateEvent // TypeDefIndex: 52033
	{
		// Fields
		[CompilerGenerated]
		private DelegateEventCallback onCallback; // 0x10
		private Delegate theDelegate; // 0x18
	
		// Events
		private event DelegateEventCallback onCallback {
			add; // 0x000000018A932618-0x000000018A9326AC
			remove; // 0x000000018A9326AC-0x000000018A932740
		}
	
		// Nested types
		public delegate void DelegateEventCallback(params object[] args); // TypeDefIndex: 52031; 0x0000000182B46B90-0x0000000182B46BA0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52032
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A93A9D0-0x000000018A93AA34
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal System.Type _GetMethodForDelegateType_b__10_0(ParameterInfo p); // 0x0000000186C08908-0x0000000186C08920
		}
	
		// Constructors
		public ReflectedDelegateEvent(); // 0x00000001841E1670-0x00000001841E1680
		public ReflectedDelegateEvent(System.Type delegateType); // 0x000000018A93259C-0x000000018A932618
	
		// Methods
		public void Add(DelegateEventCallback callback); // 0x000000018A9320D0-0x000000018A9320D8
		public void Remove(DelegateEventCallback callback); // 0x000000018A932594-0x000000018A93259C
		public Delegate AsDelegate(); // 0x000000018385B100-0x000000018385B110
		private MethodInfo GetMethodForDelegateType(System.Type delegateType); // 0x000000018A932130-0x000000018A932594
		public void Callback0(); // 0x000000018A9320D8-0x000000018A932130
		public void Callback1<T0>(T0 arg0);
		public void Callback2<T0, T1>(T0 arg0, T1 arg1);
		public void Callback3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2);
		public void Callback4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
		public void Callback5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public void Callback6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public void Callback7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public void Callback8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public void Callback9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		public void Callback10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
		public static explicit operator Delegate(ReflectedDelegateEvent that); // 0x00000001853E4DA0-0x00000001853E4DB8
	}

	[SpoofAOT]
	public class ReflectedUnityEvent // TypeDefIndex: 52036
	{
		// Fields
		[CompilerGenerated]
		private UnityEventCallback _callback; // 0x10
		private System.Type _eventType; // 0x18
		private MethodInfo _addListenerMethod; // 0x20
		private MethodInfo _removeListenerMethod; // 0x28
		private ParameterInfo[] _parameters; // 0x30
		private MethodInfo _callMethod; // 0x38
	
		// Properties
		public ParameterInfo[] parameters { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public System.Type eventType { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Events
		private event UnityEventCallback _callback {
			add; // 0x000000018A933EF0-0x000000018A933F84
			remove; // 0x000000018A933F84-0x000000018A934018
		}
	
		// Nested types
		public delegate void UnityEventCallback(params object[] args); // TypeDefIndex: 52034; 0x0000000182B46B90-0x0000000182B46BA0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52035
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A93AA34-0x000000018A93AA98
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal System.Type _InitForEventType_b__15_0(ParameterInfo p); // 0x0000000186C08908-0x0000000186C08920
		}
	
		// Constructors
		public ReflectedUnityEvent(); // 0x00000001841E1670-0x00000001841E1680
		public ReflectedUnityEvent(System.Type eventType); // 0x000000018A933EE8-0x000000018A933EF0
	
		// Methods
		public void InitForEventType(System.Type eventType); // 0x000000018A933818-0x000000018A933D50
		public void StartListening(UnityEventBase targetEvent, UnityEventCallback callback); // 0x000000018A933D50-0x000000018A933E1C
		public void StopListening(UnityEventBase targetEvent, UnityEventCallback callback); // 0x000000018A933E1C-0x000000018A933EE8
		public void CallbackMethod0(); // 0x000000018A9337C0-0x000000018A933818
		public void CallbackMethod1<T0>(T0 arg0);
		public void CallbackMethod2<T0, T1>(T0 arg0, T1 arg1);
		public void CallbackMethod3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2);
		public void CallbackMethod4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
	}

	public abstract class SharpEvent // TypeDefIndex: 52037
	{
		// Fields
		[CompilerGenerated]
		private object _instance_k__BackingField; // 0x10
		[CompilerGenerated]
		private EventInfo _eventInfo_k__BackingField; // 0x18
	
		// Properties
		public object instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public EventInfo eventInfo { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		protected SharpEvent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static SharpEvent Create(EventInfo eventInfo); // 0x000000018A934674-0x000000018A9347BC
		public void SetInstance(object instance); // 0x00000001853908C0-0x00000001853908D0
		public void StartListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback); // 0x000000018A9347BC-0x000000018A934814
		public void StopListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback); // 0x000000018A934814-0x000000018A93486C
	}

	public class SharpEvent<T> : SharpEvent // TypeDefIndex: 52038
	{
		// Constructors
		public SharpEvent();
	}

	public abstract class BaseReflectedExtractorNode // TypeDefIndex: 52039
	{
		// Fields
		[CompilerGenerated]
		private static Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode; // 0x00
		[CompilerGenerated]
		private ParametresDef _Params_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type _TargetType_k__BackingField; // 0x88
	
		// Properties
		protected ParametresDef Params { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D97610-0x0000000184D97660 0x000000018A929D98-0x000000018A929DE8
		protected System.Type TargetType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
	
		// Events
		protected static event Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode {
			add; // 0x000000018A929C60-0x000000018A929CFC
			remove; // 0x000000018A929CFC-0x000000018A929D98
		}
	
		// Constructors
		protected BaseReflectedExtractorNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static BaseReflectedExtractorNode GetExtractorNode(System.Type targetType, bool isStatic, MemberInfo[] infos); // 0x000000018A929A30-0x000000018A929BE4
		protected bool Init(ParametresDef paramsDef, System.Type targetType); // 0x000000018A929BE4-0x000000018A929C60
		protected abstract bool InitInternal();
		public abstract void RegisterPorts(FlowNode node);
	}

	public class PureReflectedExtractorNode : BaseReflectedExtractorNode // TypeDefIndex: 52042
	{
		// Fields
		private static readonly object[] EmptyParams; // 0x00
		private ValueInput instanceInput; // 0x90
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52040
		{
			// Fields
			public PureReflectedExtractorNode __4__this; // 0x10
			public System.Reflection.FieldInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _GetPortHandler_b__0(); // 0x000000018A939AC8-0x000000018A939B18
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52041
		{
			// Fields
			public PureReflectedExtractorNode __4__this; // 0x10
			public MethodInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _GetPortHandler_b__0(); // 0x000000018A939CA4-0x000000018A939D3C
		}
	
		// Constructors
		public PureReflectedExtractorNode(); // 0x00000001841E1670-0x00000001841E1680
		static PureReflectedExtractorNode(); // 0x000000018A930388-0x000000018A9303EC
	
		// Methods
		protected override bool InitInternal(); // 0x000000018A93018C-0x000000018A9301B0
		private ValueHandlerObject GetPortHandler(System.Reflection.FieldInfo info); // 0x000000018A9300BC-0x000000018A93018C
		private ValueHandlerObject GetPortHandler(MethodInfo info); // 0x000000018A92FFEC-0x000000018A9300BC
		public override void RegisterPorts(FlowNode node); // 0x000000018A9301B0-0x000000018A930388
	}

	public abstract class BaseReflectedFieldNode // TypeDefIndex: 52043
	{
		// Fields
		[CompilerGenerated]
		private static Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode; // 0x00
		protected System.Reflection.FieldInfo fieldInfo; // 0x10
		protected ParamDef instanceDef; // 0x18
		protected ParamDef resultDef; // 0x50
	
		// Events
		protected static event Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode {
			add; // 0x000000018A92A0D4-0x000000018A92A170
			remove; // 0x000000018A92A170-0x000000018A92A20C
		}
	
		// Constructors
		protected BaseReflectedFieldNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static BaseReflectedFieldNode GetFieldNode(System.Reflection.FieldInfo targetField); // 0x000000018A929DE8-0x000000018A929F70
		protected bool Init(System.Reflection.FieldInfo field, ParametresDef parametres); // 0x000000018A929F70-0x000000018A92A0D4
		protected abstract bool InitInternal(System.Reflection.FieldInfo field);
		public abstract void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	public class PureReflectedFieldNode : BaseReflectedFieldNode // TypeDefIndex: 52045
	{
		// Fields
		private ValueInput instanceInput; // 0x88
		private ValueInput valueInput; // 0x90
		private object instanceObject; // 0x98
		private object valueObject; // 0xA0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 52044
		{
			// Fields
			public FlowOutput output; // 0x10
			public PureReflectedFieldNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__2(Flow flow); // 0x000000018A93A830-0x000000018A93A894
		}
	
		// Constructors
		public PureReflectedFieldNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override bool InitInternal(System.Reflection.FieldInfo method); // 0x000000018A93045C-0x000000018A9304A8
		private void SetValue(); // 0x000000018A9307EC-0x000000018A930880
		private void GetValue(); // 0x000000018A9303EC-0x000000018A93045C
		public override void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode); // 0x000000018A9304A8-0x000000018A9307EC
		[CompilerGenerated]
		private object _RegisterPorts_b__7_0(); // 0x0000000184D85EE0-0x0000000184D85EF0
		[CompilerGenerated]
		private object _RegisterPorts_b__7_1(); // 0x000000018A930880-0x000000018A9308A0
	}

	public abstract class BaseReflectedMethodNode // TypeDefIndex: 52046
	{
		// Fields
		[CompilerGenerated]
		private static Func<MethodInfo, BaseReflectedMethodNode> OnGetAotReflectedMethodNode; // 0x00
		protected MethodInfo methodInfo; // 0x10
		protected List<ParamDef> paramDefinitions; // 0x18
		protected ParamDef instanceDef; // 0x20
		protected ParamDef resultDef; // 0x58
		protected ReflectedMethodRegistrationOptions options; // 0x90
	
		// Events
		protected static event Func<MethodInfo, BaseReflectedMethodNode> OnGetAotReflectedMethodNode {
			add; // 0x000000018A92A584-0x000000018A92A620
			remove; // 0x000000018A92A620-0x000000018A92A6BC
		}
	
		// Constructors
		protected BaseReflectedMethodNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static BaseReflectedMethodNode GetMethodNode(MethodInfo targetMethod, ReflectedMethodRegistrationOptions options); // 0x000000018A92A20C-0x000000018A92A3C0
		protected bool Init(MethodInfo method, ParametresDef parametres); // 0x000000018A92A3C0-0x000000018A92A584
		protected abstract bool InitInternal(MethodInfo method);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectedMethodNode : BaseReflectedMethodNode // TypeDefIndex: 52050
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
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 52047
		{
			// Fields
			public bool callable; // 0x10
			public PureReflectedMethodNode __4__this; // 0x18
			public int idx; // 0x20
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterOutput_b__0(); // 0x000000018A939018-0x000000018A93906C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 52048
		{
			// Fields
			public PureReflectedMethodNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A939114-0x000000018A939134
			internal object _RegisterPorts_b__1(); // 0x000000018A939134-0x000000018A939170
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1 // TypeDefIndex: 52049
		{
			// Fields
			public FlowOutput output; // 0x10
			public __c__DisplayClass12_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass12_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__2(Flow flow); // 0x000000018A939170-0x000000018A9391DC
		}
	
		// Constructors
		public PureReflectedMethodNode(); // 0x0000000184DA6530-0x0000000184DA6540
	
		// Methods
		protected override bool InitInternal(MethodInfo method); // 0x000000018A930A68-0x000000018A930BF0
		private void Call(); // 0x000000018A9308A0-0x000000018A930A68
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx); // 0x000000018A930DA8-0x000000018A930EA4
		private void RegisterInput(FlowNode node, ParamDef def, int idx); // 0x000000018A930BF0-0x000000018A930DA8
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options); // 0x000000018A930EA4-0x000000018A9312A0
	}

	public class ReflectedConstructorNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 52051
	{
		// Fields
		[SerializeField]
		private SerializedConstructorInfo _constructor; // 0xB8
		[CompilerGenerated]
		private BaseReflectedConstructorNode _reflectedConstructorNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedConstructorNode reflectedConstructorNode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		private ConstructorInfo constructor { get; } // 0x000000018A931FA0-0x000000018A931FB4 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		public override string name { get; } // 0x000000018A931FB4-0x000000018A9320D0 
	
		// Constructors
		public ReflectedConstructorNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null); // 0x000000018A931F38-0x000000018A931FA0
		private void SetConstructor(ConstructorInfo newConstructor); // 0x000000018A931EA4-0x000000018A931F38
		protected override void RegisterPorts(); // 0x000000018A931DD4-0x000000018A931EA4
	}

	[Description("Chose and expose any number of fields or properties of the type. If you only require a single field / property, it\'s better to get that field / property directly without an Extractor.")]
	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public class ReflectedExtractorNodeWrapper<T> : FlowNode // TypeDefIndex: 52052
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
		public override string name { get; }
	
		// Constructors
		public ReflectedExtractorNodeWrapper();
	
		// Methods
		public System.Type GetRuntimeIconType();
		private static void PopulateInfos();
		protected override void RegisterPorts();
	}

	internal class ReflectedFieldNodeWrapper_0 // TypeDefIndex: 52053
	{
		// Fields
		[SerializeField]
		public string fieldName; // 0x10
		[SerializeField]
		public System.Type targetType; // 0x18
	
		// Constructors
		public ReflectedFieldNodeWrapper_0(); // 0x00000001841E1670-0x00000001841E1680
	}

	[DoNotList]
	[fsMigrateVersions(new System.Type[1] {typeof(ReflectedFieldNodeWrapper_0) })]
	[Icon("", false, "GetRuntimeIconType")]
	public class ReflectedFieldNodeWrapper : FlowNode, IReflectedWrapper, IMigratable<ReflectedFieldNodeWrapper_0> // TypeDefIndex: 52055
	{
		// Fields
		[SerializeField]
		private SerializedFieldInfo _field; // 0xB0
		[SerializeField]
		private AccessMode accessMode; // 0xB8
		[CompilerGenerated]
		private BaseReflectedFieldNode _reflectedFieldNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedFieldNode reflectedFieldNode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		private System.Reflection.FieldInfo field { get; } // 0x00000001891C020C-0x00000001891C0220 
		public override string name { get; } // 0x000000018A950524-0x000000018A9507A4 
	
		// Nested types
		public enum AccessMode // TypeDefIndex: 52054
		{
			GetField = 0,
			SetField = 1
		}
	
		// Constructors
		public ReflectedFieldNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		void IMigratable<ReflectedFieldNodeWrapper_0>.Migrate(ReflectedFieldNodeWrapper_0 model); // 0x000000018A950280-0x000000018A950340
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86250-0x0000000184D86260
		private System.Type GetRuntimeIconType(); // 0x000000018A950230-0x000000018A950280
		public void SetField(System.Reflection.FieldInfo newField, AccessMode mode, object instance = null); // 0x000000018A9503DC-0x000000018A950524
		protected override void RegisterPorts(); // 0x000000018A950340-0x000000018A9503DC
	}

	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public abstract class ReflectedMethodBaseNodeWrapper : FlowNode, IReflectedWrapper // TypeDefIndex: 52056
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
		private MethodBase method { get; } // 0x000000018A9509EC-0x000000018A950A58 
		public bool callable { get; set; } // 0x0000000184D88CC0-0x0000000184D88CD0 0x000000018A950A58-0x000000018A950A70
		public bool exposeParams { get; set; } // 0x0000000184D88CB0-0x0000000184D88CC0 0x000000018A950A70-0x000000018A950A9C
		public int exposedParamsCount { get; set; } // 0x0000000184D892E0-0x0000000184D892F0 0x000000018A950A9C-0x000000018A950AC0
	
		// Constructors
		protected ReflectedMethodBaseNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018A950824-0x000000018A950834
		public System.Type GetRuntimeIconType(); // 0x000000018A9507E0-0x000000018A950824
		public abstract void SetMethodBase(MethodBase newMethod, object instance = null);
		public void SetDefaultParameterValues(MethodBase newMethod); // 0x000000018A950834-0x000000018A95094C
		public void SetDropInstanceReference(MethodBase newMethod, object instance = null); // 0x000000018A95094C-0x000000018A9509EC
	}

	public class ReflectedMethodNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 52057
	{
		// Fields
		[SerializeField]
		private SerializedMethodInfo _method; // 0xB8
		[CompilerGenerated]
		private BaseReflectedMethodNode _reflectedMethodNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedMethodNode reflectedMethodNode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		private new MethodInfo method { get; } // 0x000000018A950F34-0x000000018A950F48 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		public override string name { get; } // 0x000000018A950F48-0x000000018A951220 
	
		// Constructors
		public ReflectedMethodNodeWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null); // 0x000000018A950CFC-0x000000018A950D74
		private void SetMethod(MethodInfo newMethod, object instance = null); // 0x000000018A950D74-0x000000018A950F34
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018A950B10-0x000000018A950C70
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018A950AC0-0x000000018A950B10
		protected override void RegisterPorts(); // 0x000000018A950C70-0x000000018A950CFC
	}

	public struct ReflectedMethodRegistrationOptions // TypeDefIndex: 52058
	{
		// Fields
		public bool callable; // 0x00
		public bool exposeParams; // 0x01
		public int exposedParamsCount; // 0x04
	}

	[Description("Encapsulates a SubGraph able to control independently.")]
	public abstract class FlowNestedBase<T> : FlowNodeNested<T>, IDropedReferenceNode, IUpdatable // TypeDefIndex: 52060
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
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 52059
		{
			// Fields
			public FlowNestedBase<T> __4__this;
			public Flow f;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _Start_b__0(bool result);
		}
	
		// Constructors
		protected FlowNestedBase();
	
		// Methods
		void IDropedReferenceNode.SetTarget(UnityEngine.Object target);
		protected override void RegisterPorts();
		private void Start(Flow f);
		private void Stop(Flow f);
		private void OnStop(Flow f);
		private void Pause(Flow f);
		private void Resume(Flow f);
		void IUpdatable.Update();
		[CompilerGenerated]
		private float _RegisterPorts_b__15_0();
		[CompilerGenerated]
		private bool _RegisterPorts_b__15_1();
	}

	[DropReferenceType(typeof(FlowScript))]
	[Icon("FS", false, "")]
	[Name("Sub Flow", 0)]
	public class FlowNestedFlow : FlowNestedBase<FlowScript> // TypeDefIndex: 52061
	{
		// Constructors
		public FlowNestedFlow(); // 0x000000018A94BCD4-0x000000018A94BD10
	}

	[Category("Variables/New")]
	[Description("Create a collection of <T> objects")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(List<T>) })]
	public class CreateCollection<T> : FlowNode // TypeDefIndex: 52064
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 52062
		{
			// Fields
			public List<ValueInput<T>> ins;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal T[] _RegisterPorts_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52063
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<ValueInput<T>, T> __9__1_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _RegisterPorts_b__1_1(ValueInput<T> p);
		}
	
		// Constructors
		public CreateCollection();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Variables/New")]
	[Description("Create a Dictionary of <string, T> objects")]
	[ContextDefinedInputs(new System.Type[2] {typeof(string), typeof(Wild) })]
	public class CreateDictionary<T> : FlowNode // TypeDefIndex: 52068
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 52065
		{
			// Fields
			public List<ValueInput<string>> keys;
			public List<ValueInput<T>> values;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal IDictionary<string, T> _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 52066
		{
			// Fields
			public List<T> v;
			public List<string> k;
	
			// Constructors
			public __c__DisplayClass1_1();
	
			// Methods
			internal T _RegisterPorts_b__4(string x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52067
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<ValueInput<string>, string> __9__1_1;
			public static Func<ValueInput<T>, T> __9__1_2;
			public static Func<string, string> __9__1_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _RegisterPorts_b__1_1(ValueInput<string> x);
			internal T _RegisterPorts_b__1_2(ValueInput<T> x);
			internal string _RegisterPorts_b__1_3(string x);
		}
	
		// Constructors
		public CreateDictionary();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Variables/Blackboard")]
	[Description("Use this to get a variable value from blackboards other than the one this flowscript is using")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IBlackboard) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Get Other Of Type", 0)]
	public class GetOtherVariable<T> : FlowNode // TypeDefIndex: 52070
	{
		// Properties
		public override string name { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 52069
		{
			// Fields
			public ValueInput<IBlackboard> bb;
			public ValueInput<string> varName;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
		}
	
		// Constructors
		public GetOtherVariable();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Category("Variables/New")]
	[Description("Returns a constant or linked variable value.\nYou can alter between constant or linked at any time using the radio button.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Graph Variable", 99)]
	public class GetVariable<T> : ParameterVariableNode // TypeDefIndex: 52071
	{
		// Fields
		public BBParameter<T> value;
	
		// Properties
		public override BBParameter parameter { get; }
	
		// Constructors
		public GetVariable();
	
		// Methods
		protected override void RegisterPorts();
		[CompilerGenerated]
		private T _RegisterPorts_b__3_0();
	}

	[Category("Variables/Internal")]
	[Color("866693")]
	[Description("Can be used to set an internal variable, to later be retrieved with a \'Get Internal Var\' node. If you do not call \'Set\', then the input value will work as a relay instead.")]
	[ExposeAsDefinition]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[Name("Set Internal Var", 0)]
	public abstract class RelayValueInputBase : FlowNode // TypeDefIndex: 52072
	{
		// Properties
		public abstract System.Type relayType { get; }
	
		// Constructors
		protected RelayValueInputBase(); // 0x000000018489BC70-0x000000018489BC80
	}

	public class RelayValueInput<T> : RelayValueInputBase, IEditorMenuCallbackReceiver // TypeDefIndex: 52074
	{
		// Fields
		[DelayedField]
		[Tooltip("The identifier name of the internal var")]
		public string identifier;
		[CompilerGenerated]
		private ValueInput<T> _port_k__BackingField;
		[CompilerGenerated]
		private bool _cached_k__BackingField;
		[CompilerGenerated]
		private T _cachedValue_k__BackingField;
	
		// Properties
		public ValueInput<T> port { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool cached { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public T cachedValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override System.Type relayType { get; }
		public override string name { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 52073
		{
			// Fields
			public RelayValueInput<T> __4__this;
			public FlowOutput fOut;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
		}
	
		// Constructors
		public RelayValueInput();
	
		// Methods
		protected override void RegisterPorts();
	}

	[Color("866693")]
	[Description("Returns the selected and previously set Internal Variable\'s input value.")]
	[DoNotList]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class RelayValueOutputBase : FlowNode // TypeDefIndex: 52075
	{
		// Constructors
		protected RelayValueOutputBase(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public abstract void SetSource(RelayValueInputBase source);
	}

	public class RelayValueOutput<T> : RelayValueOutputBase // TypeDefIndex: 52076
	{
		// Fields
		[SerializeField]
		private string _sourceInputUID;
		private WeakReference<RelayValueInputBase> _sourceInputRef;
	
		// Properties
		private string sourceInputUID { get; set; }
		private RelayValueInput<T> sourceInput { get; }
		public override string name { get; }
	
		// Constructors
		public RelayValueOutput();
	
		// Methods
		public override void SetSource(RelayValueInputBase source);
		protected override void RegisterPorts();
		[CompilerGenerated]
		private bool _get_sourceInput_b__6_0(RelayValueInput<T> i);
		[CompilerGenerated]
		private T _RegisterPorts_b__10_0();
	}

	[Category("Variables")]
	[Description("Simply returns a NULL")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Null", 0)]
	public class NullObject : FlowNode // TypeDefIndex: 52078
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52077
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueHandler<object> __9__0_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A952DC4-0x000000018A952E28
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0_0(); // 0x00000001811EC580-0x00000001811EC590
		}
	
		// Constructors
		public NullObject(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94EFA8-0x000000018A94F0EC
	}

	[Category("Variables")]
	[Description("Returns the Owner GameObject")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(GameObject) })]
	[Name("Self", 100)]
	public class OwnerVariable : FlowNode // TypeDefIndex: 52079
	{
		// Properties
		public override string name { get; } // 0x000000018A94F224-0x000000018A94F250 
	
		// Constructors
		public OwnerVariable(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94F0EC-0x000000018A94F1A4
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__2_0(); // 0x000000018A94F1A4-0x000000018A94F224
	}

	public abstract class ParameterVariableNode : FlowNode // TypeDefIndex: 52080
	{
		// Properties
		public abstract BBParameter parameter { get; }
	
		// Constructors
		protected ParameterVariableNode(); // 0x000000018489BC70-0x000000018489BC80
	}

	[Category("Variables/Blackboard")]
	[Description("Use this to set a variable value of blackboards other than the one this flowscript is using")]
	[ContextDefinedInputs(new System.Type[2] {typeof(NodeCanvas.Framework.Blackboard), typeof(Wild) })]
	[Name("Set Other Of Type", 0)]
	public class SetOtherVariable<T> : FlowNode // TypeDefIndex: 52082
	{
		// Fields
		public OperationMethod operation;
		private ValueInput<string> varName;
	
		// Properties
		public override string name { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52081
		{
			// Fields
			public ValueInput<NodeCanvas.Framework.Blackboard> bb;
			public SetOtherVariable<T> __4__this;
			public ValueInput<T> v;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public SetOtherVariable();
	
		// Methods
		protected override void RegisterPorts();
		private void DoSet(NodeCanvas.Framework.Blackboard bb, string name, T value);
	}

	[Category("Variables/Blackboard")]
	[Description("Set a Blackboard variable value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[Name("Set Of Type", 10)]
	public class SetVariable<T> : ParameterVariableNode // TypeDefIndex: 52084
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> targetVariable;
		[HideInInspector]
		public OperationMethod operation;
		[HideInInspector]
		public bool perSecond;
	
		// Properties
		public override BBParameter parameter { get; }
		public override string name { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 52083
		{
			// Fields
			public SetVariable<T> __4__this;
			public ValueInput<T> v;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal T _RegisterPorts_b__0();
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public SetVariable();
	
		// Methods
		protected override void RegisterPorts();
		private void DoSet(T value);
	}

	[Obsolete]
	public abstract class CodeEventBase : EventNode<Transform> // TypeDefIndex: 52085
	{
		// Fields
		[SerializeField]
		protected string eventName; // 0xB8
		[SerializeField]
		protected System.Type targetType; // 0xC0
		protected Component targetComponent; // 0xC8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018A94ADB8-0x000000018A94AE48 
	
		// Constructors
		protected CodeEventBase(); // 0x000000018A94AD84-0x000000018A94ADB8
	
		// Methods
		public void SetEvent(EventInfo e, object instace = null); // 0x000000018A94ACF0-0x000000018A94AD84
		public override void OnPostGraphStarted(); // 0x000000018A94AB60-0x000000018A94ACF0
	}

	[Obsolete]
	public class CodeEvent : CodeEventBase // TypeDefIndex: 52086
	{
		// Fields
		private FlowOutput o; // 0xD0
		private Action pointer; // 0xD8
	
		// Constructors
		public CodeEvent(); // 0x00000001893DAC58-0x00000001893DAC60
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018A94AF58-0x000000018A94B00C
		public override void OnGraphStoped(); // 0x000000018A94AE98-0x000000018A94AF58
		protected override void RegisterPorts(); // 0x000000018A94B00C-0x000000018A94B074
		private void Call(); // 0x000000018A94AE48-0x000000018A94AE98
	}

	[Obsolete]
	public class CodeEvent<T> : CodeEventBase // TypeDefIndex: 52087
	{
		// Fields
		private FlowOutput o;
		private Action<T> pointer;
		private T eventValue;
	
		// Constructors
		public CodeEvent();
	
		// Methods
		public override void OnPostGraphStarted();
		public override void OnGraphStoped();
		private void Call(T eventValue);
		protected override void RegisterPorts();
		[CompilerGenerated]
		private T _RegisterPorts_b__6_0();
	}

	[Obsolete]
	public class NewGameObject : CallableFunctionNode<GameObject, string, Vector3, Quaternion> // TypeDefIndex: 52088
	{
		// Constructors
		public NewGameObject(); // 0x000000018A94EE38-0x000000018A94EE60
	
		// Methods
		public override GameObject Invoke(string name, Vector3 position, Quaternion rotation); // 0x000000018A94ED64-0x000000018A94EE38
	}

	[Obsolete]
	public class NewVector2 : PureFunctionNode<Vector2, float, float> // TypeDefIndex: 52089
	{
		// Constructors
		public NewVector2(); // 0x000000018A94EF30-0x000000018A94EF58
	
		// Methods
		public override Vector2 Invoke(float x, float y); // 0x0000000184DA6680-0x0000000184DA6690
	}

	[Obsolete]
	public class NewVector3 : PureFunctionNode<Vector3, float, float, float> // TypeDefIndex: 52090
	{
		// Constructors
		public NewVector3(); // 0x000000018A94EF58-0x000000018A94EF80
	
		// Methods
		public override Vector3 Invoke(float x, float y, float z); // 0x0000000184DA6690-0x0000000184DA66B0
	}

	[Obsolete]
	public class NewVector4 : PureFunctionNode<Vector4, float, float, float, float> // TypeDefIndex: 52091
	{
		// Constructors
		public NewVector4(); // 0x000000018A94EF80-0x000000018A94EFA8
	
		// Methods
		public override Vector4 Invoke(float x, float y, float z, float w); // 0x0000000184DA6650-0x0000000184DA6680
	}

	[Obsolete]
	public class NewQuaternion : PureFunctionNode<Quaternion, float, float, float, float> // TypeDefIndex: 52092
	{
		// Constructors
		public NewQuaternion(); // 0x000000018A94EE60-0x000000018A94EE88
	
		// Methods
		public override Quaternion Invoke(float x, float y, float z, float w); // 0x0000000184DA6650-0x0000000184DA6680
	}

	[Obsolete]
	public class NewColor : PureFunctionNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 52093
	{
		// Constructors
		public NewColor(); // 0x000000018A94ED3C-0x000000018A94ED64
	
		// Methods
		public override UnityEngine.Color Invoke(float r, float g, float b, float a = 1f /* Metadata: 0x02331C74 */); // 0x0000000184DA6650-0x0000000184DA6680
	}

	[Obsolete]
	public class NewBounds : PureFunctionNode<Bounds, Vector3, Vector3> // TypeDefIndex: 52094
	{
		// Constructors
		public NewBounds(); // 0x000000018A94ED14-0x000000018A94ED3C
	
		// Methods
		public override Bounds Invoke(Vector3 center, Vector3 size); // 0x000000018A94ECBC-0x000000018A94ED14
	}

	[Obsolete]
	public class NewRect : PureFunctionNode<Rect, float, float, float, float> // TypeDefIndex: 52095
	{
		// Constructors
		public NewRect(); // 0x000000018A94EF08-0x000000018A94EF30
	
		// Methods
		public override Rect Invoke(float left, float top, float width, float height); // 0x0000000184DA6650-0x0000000184DA6680
	}

	[Obsolete]
	public class NewRay : PureFunctionNode<Ray, Vector3, Vector3> // TypeDefIndex: 52096
	{
		// Constructors
		public NewRay(); // 0x000000018A94EEE0-0x000000018A94EF08
	
		// Methods
		public override Ray Invoke(Vector3 origin, Vector3 direction); // 0x000000018A94EE88-0x000000018A94EEE0
	}

	[Obsolete]
	public class ConvertTo<T> : PureFunctionNode<T, IConvertible> // TypeDefIndex: 52097
		where T : IConvertible
	{
		// Constructors
		public ConvertTo();
	
		// Methods
		public override T Invoke(IConvertible obj);
	}

	[Obsolete]
	public class CastTo<T> : PureFunctionNode<T, object> // TypeDefIndex: 52098
	{
		// Constructors
		public CastTo();
	
		// Methods
		public override T Invoke(object obj);
	}

	[Obsolete]
	public class ToArray<T> : PureFunctionNode<T[], IList<T>> // TypeDefIndex: 52099
	{
		// Constructors
		public ToArray();
	
		// Methods
		public override T[] Invoke(IList<T> list);
	}

	[Obsolete]
	public class ToList<T> : PureFunctionNode<List<T>, IList<T>> // TypeDefIndex: 52100
	{
		// Constructors
		public ToList();
	
		// Methods
		public override List<T> Invoke(IList<T> list);
	}

	[Obsolete("Use \'IReferencedObjectWrapper\' along with \'ReferencedObjectTypeAttribute\'")]
	public abstract class CustomObjectWrapper : FlowNode // TypeDefIndex: 52101
	{
		// Constructors
		protected CustomObjectWrapper(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public abstract void SetTarget(UnityEngine.Object target);
	}

	[Icon("", false, "GetRuntimeIconType")]
	[Obsolete("Use \'IReferencedObjectWrapper\' along with \'ReferencedObjectTypeAttribute\'")]
	public abstract class CustomObjectWrapper<T> : CustomObjectWrapper // TypeDefIndex: 52102
		where T : UnityEngine.Object
	{
		// Fields
		[SerializeField]
		private T _target;
	
		// Properties
		public T target { get; set; }
		public override string name { get; }
	
		// Constructors
		protected CustomObjectWrapper();
	
		// Methods
		public override void SetTarget(UnityEngine.Object target);
		protected System.Type GetRuntimeIconType();
	}

	[Obsolete]
	public class ExtractVector2 : ExtractorNode<Vector2, float, float> // TypeDefIndex: 52103
	{
		// Constructors
		public ExtractVector2(); // 0x000000018A94B84C-0x000000018A94B874
	
		// Methods
		public override void Invoke(Vector2 vector, out float x, out float y); // 0x0000000184DA6610-0x0000000184DA6630
	}

	[Obsolete]
	public class ExtractVector3 : ExtractorNode<Vector3, float, float, float> // TypeDefIndex: 52104
	{
		// Constructors
		public ExtractVector3(); // 0x000000018A94B874-0x000000018A94B89C
	
		// Methods
		public override void Invoke(Vector3 vector, out float x, out float y, out float z); // 0x0000000184DA6630-0x0000000184DA6650
	}

	[Obsolete]
	public class ExtractVector4 : ExtractorNode<Vector4, float, float, float, float> // TypeDefIndex: 52105
	{
		// Constructors
		public ExtractVector4(); // 0x000000018A94B89C-0x000000018A94B8C4
	
		// Methods
		public override void Invoke(Vector4 vector, out float x, out float y, out float z, out float w); // 0x0000000184DA6590-0x0000000184DA65B0
	}

	[Obsolete]
	public class ExtractQuaternion : ExtractorNode<Quaternion, float, float, float, float, Vector3> // TypeDefIndex: 52106
	{
		// Constructors
		public ExtractQuaternion(); // 0x000000018A94B544-0x000000018A94B56C
	
		// Methods
		public override void Invoke(Quaternion quaternion, out float x, out float y, out float z, out float w, out Vector3 eulerAngles); // 0x000000018A94B4FC-0x000000018A94B544
	}

	[Obsolete]
	public class ExtractRect : ExtractorNode<Rect, Vector2, float, float, float, float> // TypeDefIndex: 52107
	{
		// Constructors
		public ExtractRect(); // 0x000000018A94B824-0x000000018A94B84C
	
		// Methods
		public override void Invoke(Rect rect, out Vector2 center, out float xMin, out float xMax, out float yMin, out float yMax); // 0x000000018A94B7C0-0x000000018A94B824
	}

	[Obsolete]
	public class ExtractColor : ExtractorNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 52108
	{
		// Constructors
		public ExtractColor(); // 0x000000018A94B3A4-0x000000018A94B3CC
	
		// Methods
		public override void Invoke(UnityEngine.Color color, out float r, out float g, out float b, out float a); // 0x0000000184DA6590-0x0000000184DA65B0
	}

	[Obsolete]
	public class ExtractRaycastHit : ExtractorNode<RaycastHit, GameObject, float, Vector3, Vector3> // TypeDefIndex: 52109
	{
		// Constructors
		public ExtractRaycastHit(); // 0x000000018A94B798-0x000000018A94B7C0
	
		// Methods
		public override void Invoke(RaycastHit hit, out GameObject gameObject, out float distance, out Vector3 normal, out Vector3 point); // 0x000000018A94B6DC-0x000000018A94B798
	}

	[Obsolete]
	public class ExtractRaycastHit2D : ExtractorNode<RaycastHit2D, GameObject, float, float, Vector3, Vector3> // TypeDefIndex: 52110
	{
		// Constructors
		public ExtractRaycastHit2D(); // 0x000000018A94B6B4-0x000000018A94B6DC
	
		// Methods
		public override void Invoke(RaycastHit2D hit, out GameObject gameObject, out float distance, out float fraction, out Vector3 normal, out Vector3 point); // 0x000000018A94B594-0x000000018A94B6B4
	}

	[Obsolete]
	public class ExtractRay : ExtractorNode<Ray, Vector3, Vector3> // TypeDefIndex: 52111
	{
		// Constructors
		public ExtractRay(); // 0x000000018A94B56C-0x000000018A94B594
	
		// Methods
		public override void Invoke(Ray ray, out Vector3 origin, out Vector3 direction); // 0x0000000184DA65E0-0x0000000184DA6610
	}

	[Obsolete]
	public class ExtractBounds : ExtractorNode<Bounds, Vector3, Vector3, Vector3, Vector3, Vector3> // TypeDefIndex: 52112
	{
		// Constructors
		public ExtractBounds(); // 0x000000018A94B1B4-0x000000018A94B1DC
	
		// Methods
		public override void Invoke(Bounds bounds, out Vector3 center, out Vector3 extents, out Vector3 max, out Vector3 min, out Vector3 size); // 0x000000018A94B11C-0x000000018A94B1B4
	}

	[Obsolete]
	public class ExtractCollision : ExtractorNode<UnityEngine.Collision, ContactPoint[], ContactPoint, GameObject, Vector3> // TypeDefIndex: 52113
	{
		// Constructors
		public ExtractCollision(); // 0x000000018A94B37C-0x000000018A94B3A4
	
		// Methods
		public override void Invoke(UnityEngine.Collision collision, out ContactPoint[] contacts, out ContactPoint firstContact, out GameObject gameObject, out Vector3 velocity); // 0x000000018A94B2C8-0x000000018A94B37C
	}

	[Obsolete]
	public class ExtractCollision2D : ExtractorNode<Collision2D, ContactPoint2D[], ContactPoint2D, GameObject, Vector2> // TypeDefIndex: 52114
	{
		// Constructors
		public ExtractCollision2D(); // 0x000000018A94B2A0-0x000000018A94B2C8
	
		// Methods
		public override void Invoke(Collision2D collision, out ContactPoint2D[] contacts, out ContactPoint2D firstContact, out GameObject gameObject, out Vector2 velocity); // 0x000000018A94B1DC-0x000000018A94B2A0
	}

	[Obsolete]
	public class ExtractContactPoint : ExtractorNode<ContactPoint, Vector3, Vector3, Collider, Collider> // TypeDefIndex: 52115
	{
		// Constructors
		public ExtractContactPoint(); // 0x000000018A94B4AC-0x000000018A94B4D4
	
		// Methods
		public override void Invoke(ContactPoint contactPoint, out Vector3 normal, out Vector3 point, out Collider colliderA, out Collider colliderB); // 0x000000018A94B44C-0x000000018A94B4AC
	}

	[Obsolete]
	public class ExtractContactPoint2D : ExtractorNode<ContactPoint2D, Vector2, Vector2, Collider2D, Collider2D> // TypeDefIndex: 52116
	{
		// Constructors
		public ExtractContactPoint2D(); // 0x000000018A94B424-0x000000018A94B44C
	
		// Methods
		public override void Invoke(ContactPoint2D contactPoint, out Vector2 normal, out Vector2 point, out Collider2D colliderA, out Collider2D colliderB); // 0x000000018A94B3CC-0x000000018A94B424
	}

	[Obsolete]
	public class ExtractAnimationCurve : ExtractorNode<AnimationCurve, Keyframe[], float, UnityEngine.WrapMode, UnityEngine.WrapMode> // TypeDefIndex: 52117
	{
		// Constructors
		public ExtractAnimationCurve(); // 0x000000018A94B0F4-0x000000018A94B11C
	
		// Methods
		public override void Invoke(AnimationCurve curve, out Keyframe[] keys, out float length, out UnityEngine.WrapMode postWrapMode, out UnityEngine.WrapMode preWrapMode); // 0x000000018A94B074-0x000000018A94B0F4
	}

	[Obsolete]
	public class ExtractKeyFrame : ExtractorNode<Keyframe, float, float, float, float> // TypeDefIndex: 52118
	{
		// Constructors
		public ExtractKeyFrame(); // 0x000000018A94B4D4-0x000000018A94B4FC
	
		// Methods
		public override void Invoke(Keyframe key, out float inTangent, out float outTangent, out float time, out float value); // 0x0000000184DA65B0-0x0000000184DA65E0
	}

	[Obsolete]
	public class SwitchValue<T> : PureFunctionNode<T, bool, T, T> // TypeDefIndex: 52119
	{
		// Constructors
		public SwitchValue();
	
		// Methods
		public override T Invoke(bool condition, T isTrue, T isFalse);
	}

	[Obsolete]
	public class PickValue<T> : PureFunctionNode<T, int, IList<T>> // TypeDefIndex: 52120
	{
		// Constructors
		public PickValue();
	
		// Methods
		public override T Invoke(int index, IList<T> values);
	}

	[Obsolete]
	public abstract class StaticCodeEventBase : EventNode // TypeDefIndex: 52121
	{
		// Fields
		[SerializeField]
		protected string eventName; // 0xB0
		[SerializeField]
		protected System.Type targetType; // 0xB8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018A951CE0-0x000000018A951D70 
	
		// Constructors
		protected StaticCodeEventBase(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public void SetEvent(EventInfo e); // 0x000000018A951C4C-0x000000018A951CE0
		public override void OnGraphStarted(); // 0x000000018A951B98-0x000000018A951C4C
	}

	[Obsolete]
	public class StaticCodeEvent : StaticCodeEventBase // TypeDefIndex: 52122
	{
		// Fields
		private FlowOutput o; // 0xC0
		private Action pointer; // 0xC8
	
		// Constructors
		public StaticCodeEvent(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A951DC0-0x000000018A951E70
		public override void OnGraphStoped(); // 0x00000001892E9C34-0x00000001892E9C98
		private void Call(); // 0x000000018A951D70-0x000000018A951DC0
		protected override void RegisterPorts(); // 0x000000018A951E70-0x000000018A951ED8
	}

	[Obsolete]
	public class StaticCodeEvent<T> : StaticCodeEventBase // TypeDefIndex: 52123
	{
		// Fields
		private FlowOutput o;
		private Action<T> pointer;
		private T eventValue;
	
		// Constructors
		public StaticCodeEvent();
	
		// Methods
		public override void OnGraphStarted();
		public override void OnGraphStoped();
		private void Call(T value);
		protected override void RegisterPorts();
		[CompilerGenerated]
		private T _RegisterPorts_b__6_0();
	}

	[DropReferenceType(typeof(BehaviourTree))]
	[Name("Sub Tree", 0)]
	public class FlowNestedBT : FlowNestedBase<BehaviourTree> // TypeDefIndex: 52124
	{
		// Constructors
		public FlowNestedBT(); // 0x000000018A94B9DC-0x000000018A94BA18
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94B8C4-0x000000018A94B998
		[CompilerGenerated]
		private NodeCanvas.Framework.Status _RegisterPorts_b__0_0(); // 0x000000018A94B998-0x000000018A94B9DC
	}

	[DropReferenceType(typeof(FSM))]
	[Name("Sub FSM", 0)]
	public class FlowNestedFSM : FlowNestedBase<FSM> // TypeDefIndex: 52125
	{
		// Constructors
		public FlowNestedFSM(); // 0x000000018A94BC98-0x000000018A94BCD4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94BB80-0x000000018A94BC54
		[CompilerGenerated]
		private IState _RegisterPorts_b__0_0(); // 0x000000018A94BC54-0x000000018A94BC98
	}

	[DropReferenceType(typeof(DialogueTree))]
	[Name("Sub Dialogue", 0)]
	public class FlowNestedDT : FlowNestedBase<DialogueTree> // TypeDefIndex: 52126
	{
		// Constructors
		public FlowNestedDT(); // 0x000000018A94BB44-0x000000018A94BB80
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018A94BA18-0x000000018A94BAEC
		[CompilerGenerated]
		private IDialogueActor _RegisterPorts_b__0_0(); // 0x000000018A94BAEC-0x000000018A94BB44
	}

	[Description("Execute an encapsulated action without exposing any value ports")]
	public class TaskAction : FlowNode, ITaskAssignable<ActionTask> // TypeDefIndex: 52128
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0xB0
		private FlowOutput onFinish; // 0xB8
		private Coroutine coroutine; // 0xC0
	
		// Properties
		public override string name { get; } // 0x000000018A95229C-0x000000018A9522EC 
		public ActionTask action { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018A9522EC-0x000000018A952324
		NodeCanvas.Framework.Task ITaskAssignable.task { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018A952024-0x000000018A952078
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DoUpdate_d__15 : IEnumerator<object> // TypeDefIndex: 52127
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TaskAction __4__this; // 0x20
			public Flow f; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoUpdate_d__15(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A952554-0x000000018A952690
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A952690-0x000000018A9526DC
		}
	
		// Constructors
		public TaskAction(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A952094-0x000000018A9520AC
		public override void OnGraphStoped(); // 0x000000018A9520AC-0x000000018A95210C
		public override void OnGraphPaused(); // 0x000000018A952078-0x000000018A952094
		protected override void RegisterPorts(); // 0x000000018A95210C-0x000000018A9521EC
		[IteratorStateMachine(typeof(_DoUpdate_d__15))]
		private IEnumerator DoUpdate(Flow f); // 0x000000018A951F98-0x000000018A952024
		[CompilerGenerated]
		private void _RegisterPorts_b__14_0(Flow f); // 0x000000018A9521EC-0x000000018A95229C
	}

	[Description("Returns an encapsulated condition check without exposing any value ports other than the boolean check")]
	public class TaskCondition : FlowNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 52129
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018A952504-0x000000018A952554 
		public ConditionTask condition { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D84CE0-0x0000000184D84D00
		NodeCanvas.Framework.Task ITaskAssignable.task { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x000000018A952324-0x000000018A95237C
	
		// Constructors
		public TaskCondition(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A95237C-0x000000018A9523D4
		public override void OnGraphStoped(); // 0x000000018A9523D4-0x000000018A9523F0
		protected override void RegisterPorts(); // 0x000000018A9523F0-0x000000018A9524A8
		[CompilerGenerated]
		private bool _RegisterPorts_b__11_0(); // 0x000000018A9524A8-0x000000018A952504
	}
}

namespace FlowCanvas.Nodes.Legacy
{
	[Obsolete]
	public abstract class ReflectedFieldNode // TypeDefIndex: 52130
	{
		// Constructors
		protected ReflectedFieldNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ReflectedFieldNode Create(System.Reflection.FieldInfo field); // 0x000000018A9507A4-0x000000018A9507E0
		public abstract void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	[Obsolete]
	public sealed class PureReflectedFieldNode : ReflectedFieldNode // TypeDefIndex: 52135
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 52131
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1 // TypeDefIndex: 52132
		{
			// Fields
			public object constantValue; // 0x10
	
			// Constructors
			public __c__DisplayClass0_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_2 // TypeDefIndex: 52133
		{
			// Fields
			public ValueInput instanceInput; // 0x10
			public __c__DisplayClass0_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass0_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__1(); // 0x000000018A9526F0-0x000000018A952734
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_3 // TypeDefIndex: 52134
		{
			// Fields
			public object instance; // 0x10
			public ValueInput instanceInput; // 0x18
			public ValueInput valueInput; // 0x20
			public FlowOutput flowOut; // 0x28
			public __c__DisplayClass0_0 CS___8__locals2; // 0x30
	
			// Constructors
			public __c__DisplayClass0_3(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__2(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
			internal void _RegisterPorts_b__3(Flow f); // 0x000000018A952734-0x000000018A9527F4
		}
	
		// Constructors
		public PureReflectedFieldNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode); // 0x000000018A94F250-0x000000018A94F6C8
	}

	[Obsolete]
	public abstract class ReflectedMethodNode // TypeDefIndex: 52138
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 52136
		{
			// Fields
			public ParameterInfo[] parameters; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Create_b__0(ParameterInfo p); // 0x000000018A9527F4-0x000000018A95286C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52137
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__2_0; // 0x08
			public static Func<ParameterInfo, System.Type> __9__2_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018A952D60-0x000000018A952DC4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal System.Type _TryCreateJit_b__2_0(ParameterInfo p); // 0x0000000186C08908-0x0000000186C08920
			internal System.Type _TryCreateJit_b__2_1(ParameterInfo p); // 0x0000000186C08908-0x0000000186C08920
		}
	
		// Constructors
		public ReflectedMethodNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ReflectedMethodNode Create(MethodInfo method); // 0x000000018A951220-0x000000018A9513EC
		private static ReflectedMethodNode TryCreateJit(MethodInfo method); // 0x000000018A9514FC-0x000000018A951B98
		public string GetName(MethodInfo method, int i); // 0x000000018A9513EC-0x000000018A9514FC
		public abstract void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class PureReflectedMethodNode : ReflectedMethodNode // TypeDefIndex: 52142
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
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 52139
		{
			// Fields
			public PureReflectedMethodNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A952C3C-0x000000018A952C58
			internal object _RegisterPorts_b__1(); // 0x000000018A952C58-0x000000018A952C90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_1 // TypeDefIndex: 52140
		{
			// Fields
			public FlowOutput o; // 0x10
			public __c__DisplayClass8_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass8_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018A952C90-0x000000018A952CFC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_2 // TypeDefIndex: 52141
		{
			// Fields
			public int i; // 0x10
			public __c__DisplayClass8_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass8_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _RegisterPorts_b__3(); // 0x000000018A952CFC-0x000000018A952D60
		}
	
		// Constructors
		public PureReflectedMethodNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options); // 0x000000018A94F930-0x000000018A9500A8
		private object CallMethod(); // 0x000000018A94F6C8-0x000000018A94F930
	}

	[Obsolete]
	public sealed class ReflectedActionNode : ReflectedMethodNode // TypeDefIndex: 52144
	{
		// Fields
		private ActionCall call; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 52143
		{
			// Fields
			public ReflectedActionNode __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018A952A90-0x000000018A952AF4
		}
	
		// Constructors
		public ReflectedActionNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private void Call(); // 0x000000018A9500A8-0x000000018A9500CC
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options); // 0x000000018A9500CC-0x000000018A950230
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1> : ReflectedMethodNode // TypeDefIndex: 52146
	{
		// Fields
		private ActionCall<T1> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52145
		{
			// Fields
			public ReflectedActionNode<T1> __4__this;
			public ValueInput<T1> p1;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2> : ReflectedMethodNode // TypeDefIndex: 52148
	{
		// Fields
		private ActionCall<T1, T2> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52147
		{
			// Fields
			public ReflectedActionNode<T1, T2> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3> : ReflectedMethodNode // TypeDefIndex: 52150
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52149
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b, T3 c);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4> : ReflectedMethodNode // TypeDefIndex: 52152
	{
		// Fields
		private ActionCall<T1, T2, T3, T4> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52151
		{
			// Fields
			public ReflectedActionNode<T1, T2, T3, T4> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public FlowOutput o;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5> : ReflectedMethodNode // TypeDefIndex: 52154
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52153
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
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6> : ReflectedMethodNode // TypeDefIndex: 52156
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52155
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
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> : ReflectedMethodNode // TypeDefIndex: 52158
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52157
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
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : ReflectedMethodNode // TypeDefIndex: 52160
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7, T8> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52159
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
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f);
			internal T1 _RegisterPorts_b__1();
		}
	
		// Constructors
		public ReflectedActionNode();
	
		// Methods
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<TResult> : ReflectedMethodNode // TypeDefIndex: 52163
	{
		// Fields
		private FunctionCall<TResult> call;
		private TResult returnValue;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52161
		{
			// Fields
			public ReflectedFunctionNode<TResult> __4__this;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_1 // TypeDefIndex: 52162
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass3_0<TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass3_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call();
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, TResult> : ReflectedMethodNode // TypeDefIndex: 52166
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52164
		{
			// Fields
			public ReflectedFunctionNode<T1, TResult> __4__this;
			public ValueInput<T1> p1;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52165
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, TResult> : ReflectedMethodNode // TypeDefIndex: 52169
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52167
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52168
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, TResult> : ReflectedMethodNode // TypeDefIndex: 52172
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52170
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52171
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, TResult> : ReflectedMethodNode // TypeDefIndex: 52175
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52173
		{
			// Fields
			public ReflectedFunctionNode<T1, T2, T3, T4, TResult> __4__this;
			public ValueInput<T1> p1;
			public ValueInput<T2> p2;
			public ValueInput<T3> p3;
			public ValueInput<T4> p4;
			public ReflectedMethodRegistrationOptions options;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52174
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> : ReflectedMethodNode // TypeDefIndex: 52178
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52176
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
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52177
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> : ReflectedMethodNode // TypeDefIndex: 52181
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52179
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
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52180
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, T6, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> : ReflectedMethodNode // TypeDefIndex: 52184
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52182
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
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52183
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, T6, T7, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ReflectedMethodNode // TypeDefIndex: 52187
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52185
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
			public __c__DisplayClass4_0();
	
			// Methods
			internal T1 _RegisterPorts_b__2();
			internal TResult _RegisterPorts_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 52186
		{
			// Fields
			public FlowOutput o;
			public __c__DisplayClass4_0<T1, T2, T3, T4, T5, T6, T7, T8, TResult> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f);
		}
	
		// Constructors
		public ReflectedFunctionNode();
	
		// Methods
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 51564
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 52893
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x000000018A9A30D8-0x000000018A9A313C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 52894
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018A9A3180-0x000000018A9A3214
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x000000018A9A313C-0x000000018A9A3180
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 52895
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018A9A5038-0x000000018A9A509C
		public static bool IsPatched(int id); // 0x000000018A9A5128-0x000000018A9A51C0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018A9A4EF4-0x000000018A9A4FC0
		public object CreateWrapper(int id); // 0x000000018A9A4FC0-0x000000018A9A5038
		public object InitWrapperArray(int len); // 0x000000018A9A509C-0x000000018A9A5128
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018A9A4E50-0x000000018A9A4EF4
	}
}

namespace NodeCanvas
{
	public static class AssemblyWrapUtils // TypeDefIndex: 52203
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
	public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 52204
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
		public ActionList actionList { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public float elapsedTime { get; } // 0x000000018A93D20C-0x000000018A93D228 
		public float deltaTime { get; } // 0x0000000185391A8C-0x0000000185391A94 
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x000000018464E630-0x000000018464E640 
		Component ITaskSystem.agent { get; } // 0x000000018464E630-0x000000018464E640 
		public IBlackboard blackboard { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x000000018A93D228-0x000000018A93D29C
	
		// Constructors
		public ActionListPlayer(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A93CF44-0x000000018A93D070
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A93CE40-0x000000018A93CF44
		public static ActionListPlayer Create(); // 0x000000018A93CCB8-0x000000018A93CD34
		protected void Awake(); // 0x000000018A93CC8C-0x000000018A93CCB8
		public void UpdateTasksOwner(); // 0x000000018A93D070-0x000000018A93D20C
		void ITaskSystem.SendEvent(string name, object value, object sender); // 0x00000001841E1670-0x00000001841E1680
		void ITaskSystem.SendEvent<T>(string name, T value, object sender);
		[ContextMenu("Play")]
		public void Play(); // 0x000000018A93CE1C-0x000000018A93CE40
		public void Play(Action<NodeCanvas.Framework.Status> OnFinish); // 0x000000018A93CDF8-0x000000018A93CE1C
		public void Play(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> OnFinish); // 0x000000018A93CD88-0x000000018A93CDF8
		public NodeCanvas.Framework.Status Execute(); // 0x000000018A93CD5C-0x000000018A93CD88
		public NodeCanvas.Framework.Status Execute(Component agent); // 0x000000018A93CD34-0x000000018A93CD5C
	}
}

namespace NodeCanvas.BehaviourTrees
{
	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Behaviour Tree Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class BehaviourTree : NodeCanvas.Framework.Graph // TypeDefIndex: 52509
	{
		// Fields
		[NonSerialized]
		public bool repeat; // 0xA0
		[NonSerialized]
		public float updateInterval; // 0xA4
		[CompilerGenerated]
		private static Action<BehaviourTree, NodeCanvas.Framework.Status> onRootStatusChanged; // 0x00
		private float intervalCounter; // 0xA8
		private NodeCanvas.Framework.Status _rootStatus; // 0xAC
	
		// Properties
		public NodeCanvas.Framework.Status rootStatus { get; private set; } // 0x0000000184D88CA0-0x0000000184D88CB0 0x0000000184B2D320-0x0000000184B2D340
		public override System.Type baseNodeType { get; } // 0x000000018A96A080-0x000000018A96A0D0 
		public override bool requiresAgent { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool requiresPrimeNode { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool isTree { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool allowBlackboardOverrides { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001812081B0-0x0000000181208610 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Events
		public static event Action<BehaviourTree, NodeCanvas.Framework.Status> onRootStatusChanged {
			add; // 0x000000018A969FE4-0x000000018A96A080
			remove; // 0x000000018A96A0D0-0x000000018A96A16C
		}
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 52508
		{
			// Fields
			public bool repeat; // 0x10
			public float updateInterval; // 0x14
	
			// Constructors
			public DerivedSerializationData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public BehaviourTree(); // 0x0000000183CBE920-0x0000000183CBE980
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x000000018A969E58-0x000000018A969EB8
		public override void OnDerivedDataDeserialization(object data); // 0x00000001848C05F0-0x00000001848C0730
		protected override void OnGraphStarted(); // 0x0000000184B2D2E0-0x0000000184B2D320
		protected override void OnGraphUpdate(); // 0x000000018A969EB8-0x000000018A969F60
		private NodeCanvas.Framework.Status Tick(Component agent, IBlackboard blackboard); // 0x000000018A969F60-0x000000018A969FE4
	}

	[AddComponentMenu("NodeCanvas/Behaviour Tree Owner")]
	public class BehaviourTreeOwner : GraphOwner<BehaviourTree> // TypeDefIndex: 52510
	{
		// Properties
		public bool repeat { get; set; } // 0x000000018A969B54-0x000000018A969BE8 0x000000018A969D18-0x000000018A969DB8
		public float updateInterval { get; set; } // 0x000000018A969C80-0x000000018A969D18 0x000000018A969DB8-0x000000018A969E58
		public NodeCanvas.Framework.Status rootStatus { get; } // 0x000000018A969BE8-0x000000018A969C80 
	
		// Constructors
		public BehaviourTreeOwner(); // 0x0000000184D11AD0-0x0000000184D11B10
	
		// Methods
		public NodeCanvas.Framework.Status Tick(); // 0x000000018A969AB4-0x000000018A969B54
	}

	public class BTConnection : Connection // TypeDefIndex: 52511
	{
		// Constructors
		public BTConnection(); // 0x0000000184D92320-0x0000000184D92330
	}

	public abstract class BTNode : NodeCanvas.Framework.Node // TypeDefIndex: 52512
	{
		// Properties
		public sealed override System.Type outConnectionType { get; } // 0x000000018A969A64-0x000000018A969AB4 
		public sealed override bool allowAsPrime { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public sealed override bool canSelfConnect { get; } // 0x00000001812081B0-0x0000000181208610 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public override Alignment2x2 iconAlignment { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxInConnections { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		protected BTNode(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public T AddChild<T>(int childIndex)
			where T : BTNode;
		public T AddChild<T>()
			where T : BTNode;
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class BTNodeNested<T> : BTNode, IGraphAssignable<T> // TypeDefIndex: 52513
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
		[CompilerGenerated]
		private T _currentInstance_k__BackingField;
		[CompilerGenerated]
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected BTNodeNested();
	}

	public abstract class BTComposite : BTNode // TypeDefIndex: 52514
	{
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public sealed override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	
		// Constructors
		protected BTComposite(); // 0x000000018489BC70-0x000000018489BC80
	}

	public abstract class BTDecorator : BTNode // TypeDefIndex: 52515
	{
		// Properties
		public sealed override int maxOutConnections { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		protected Connection decoratedConnection { get; } // 0x000000018A969788-0x000000018A9697C0 
		protected NodeCanvas.Framework.Node decoratedNode { get; } // 0x000000018A9697C0-0x000000018A9697DC 
	
		// Constructors
		protected BTDecorator(); // 0x000000018489BC70-0x000000018489BC80
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Quick way to execute the left or the right child, based on a Condition Task.")]
	[Icon("Condition", false, "")]
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 52516
	{
		// Fields
		[Tooltip("If true, the condition will be re-evaluated per frame.")]
		public bool dynamic; // 0x98
		[SerializeField]
		private ConditionTask _condition; // 0xA0
		private int succeedIndex; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x000000018A96A29C-0x000000018A96A2F4
		private ConditionTask condition { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
	
		// Constructors
		public BinarySelector(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A96A16C-0x000000018A96A280
		protected override void OnReset(); // 0x000000018A96A280-0x000000018A96A29C
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Works like a normal Selector, but when a child returns Success, that child will be moved to the end.\nAs a result, previously Failed children will always be checked first and recently Successful children last.")]
	[Icon("FlipSelector", false, "")]
	public class FlipSelector : BTComposite // TypeDefIndex: 52517
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public FlipSelector(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A96FF18-0x000000018A96FFF8
		private void SendToBack(int i); // 0x000000018A96FFF8-0x000000018A9700A0
		protected override void OnReset(); // 0x0000000184DA67A0-0x0000000184DA67B0
	}

	[Category("Composites")]
	[Color("ff64cb")]
	[Description("Executes all children simultaneously and return Success or Failure depending on the selected Policy.")]
	[Icon("Parallel", false, "")]
	[Name("Parallel", 8)]
	public class Parallel : BTComposite // TypeDefIndex: 52519
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
		public enum ParallelPolicy // TypeDefIndex: 52518
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}
	
		// Constructors
		public Parallel(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A978768-0x000000018A9787D8
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A978584-0x000000018A978768
		protected override void OnReset(); // 0x000000018A9787D8-0x000000018A97881C
		private void ResetRunning(); // 0x000000018A97881C-0x000000018A9788BC
	}

	internal class PrioritySelector_0 : BTComposite // TypeDefIndex: 52520
	{
		// Fields
		[SerializeField]
		public List<BBParameter<float>> priorities; // 0x98
	
		// Constructors
		public PrioritySelector_0(); // 0x000000018489BC70-0x000000018489BC80
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Used for Utility AI, the Priority Selector executes the child with the highest utility weight. If it fails, the Priority Selector will continue with the next highest utility weight child until one Succeeds, or until all Fail (similar to how a normal Selector does).\n\nEach child branch represents a desire, where each desire has one or more consideration which are all averaged.\nConsiderations are a pair of input value and curve, which together produce the consideration utility weight.")]
	[fsMigrateVersions(new System.Type[1] {typeof(PrioritySelector_0) })]
	[Icon("Priority", false, "")]
	public class PrioritySelector : BTComposite, IMigratable<PrioritySelector_0> // TypeDefIndex: 52523
	{
		// Fields
		[AutoSortWithChildrenConnections]
		public List<Desire> desires; // 0x98
		private Connection[] orderedConnections; // 0xA0
		private int current; // 0xA8
	
		// Nested types
		[Serializable]
		public class Desire // TypeDefIndex: 52521
		{
			// Fields
			[fsIgnoreInBuild]
			public string name; // 0x10
			[fsIgnoreInBuild]
			public bool foldout; // 0x18
			public List<Consideration> considerations; // 0x20
	
			// Constructors
			public Desire(); // 0x000000018A96C36C-0x000000018A96C3E4
	
			// Methods
			public Consideration AddConsideration(IBlackboard bb); // 0x000000018A96C1E8-0x000000018A96C278
			public void RemoveConsideration(Consideration consideration); // 0x000000018A96C318-0x000000018A96C36C
			public float GetCompoundUtility(); // 0x000000018A96C278-0x000000018A96C318
		}
	
		[Serializable]
		public class Consideration // TypeDefIndex: 52522
		{
			// Fields
			public BBParameter<float> input; // 0x10
			public BBParameter<AnimationCurve> function; // 0x18
	
			// Properties
			public float utility { get; } // 0x000000018A96BB74-0x000000018A96BC2C 
	
			// Constructors
			public Consideration(IBlackboard blackboard); // 0x000000018A96BA88-0x000000018A96BB74
		}
	
		// Constructors
		public PrioritySelector(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		void IMigratable<PrioritySelector_0>.Migrate(PrioritySelector_0 model); // 0x000000018A978B9C-0x000000018A978DF4
		public override void OnChildConnected(int index); // 0x000000018A9788BC-0x000000018A9789D8
		public override void OnChildDisconnected(int index); // 0x000000018A9789D8-0x000000018A978A30
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A978A30-0x000000018A978B9C
		protected override void OnReset(); // 0x0000000184DA67C0-0x0000000184DA67D0
		[CompilerGenerated]
		private float _OnExecute_b__8_0(Connection c); // 0x000000018A978DF4-0x000000018A978E8C
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Selects a child to execute based on its chance to be selected and returns Success if the child returns Success, otherwise picks another child.\nReturns Failure if all children return Failure, or a direct \'Failure Chance\' is introduced.")]
	[Icon("ProbabilitySelector", false, "")]
	public class ProbabilitySelector : BTComposite // TypeDefIndex: 52524
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
		public ProbabilitySelector(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnChildConnected(int index); // 0x000000018A979054-0x000000018A9791BC
		public override void OnChildDisconnected(int index); // 0x000000018A979214-0x000000018A97926C
		public override void OnGraphStarted(); // 0x0000000184CC8C70-0x0000000184CC8C80
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97926C-0x000000018A9794A8
		protected override void OnReset(); // 0x000000018A979720-0x000000018A9797C0
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Executes its childrfen in order and returns Failure if all children return Failure. As soon as a child returns Success, the Selector will stop and return Success as well.")]
	[Icon("Selector", false, "")]
	[Name("Selector", 9)]
	public class Selector : BTComposite // TypeDefIndex: 52525
	{
		// Fields
		[Tooltip("If true, then higher priority children are re-evaluated per frame and if either returns Success, then the Selector will immediately stop and return Success as well.")]
		public bool dynamic; // 0x98
		[Tooltip("If true, the children order of execution is shuffled each time the Selector resets.")]
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Selector(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A979B48-0x000000018A979CA0
		protected override void OnReset(); // 0x0000000184B6CCE0-0x0000000184B6CD10
		public override void OnChildDisconnected(int index); // 0x000000018A979B34-0x000000018A979B48
		public override void OnGraphStarted(); // 0x0000000184CC8C70-0x0000000184CC8C80
	}

	[Category("Composites")]
	[Color("bf7fff")]
	[Description("Executes its children in order and returns Success if all children return Success. As soon as a child returns Failure, the Sequencer will stop and return Failure as well.")]
	[Icon("Sequencer", false, "")]
	[Name("Sequencer", 10)]
	public class Sequencer : BTComposite // TypeDefIndex: 52526
	{
		// Fields
		[Tooltip("If true, then higher priority children are re-evaluated per frame and if either returns Failure, then the Sequencer will immediately stop and return Failure as well.")]
		public bool dynamic; // 0x98
		[Tooltip("If true, the children order of execution is shuffled each time the Sequencer resets.")]
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Sequencer(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A979CA0-0x000000018A979DF8
		protected override void OnReset(); // 0x0000000184B6CCE0-0x0000000184B6CD10
		public override void OnChildDisconnected(int index); // 0x000000018A979B34-0x000000018A979B48
		public override void OnGraphStarted(); // 0x0000000184CC8C70-0x0000000184CC8C80
	}

	[Category("Composites")]
	[Color("bf7fff")]
	[Description("In comparison to a normal Sequencer which executes all its children until one fails, Step Sequencer executes its children one-by-one per Step Sequencer execution. The executed child status is returned regardless of Success or Failure.")]
	[Icon("StepIterator", false, "")]
	[Name("Step Sequencer", 0)]
	public class StepIterator : BTComposite // TypeDefIndex: 52527
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public StepIterator(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000184DA67A0-0x0000000184DA67B0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97A760-0x000000018A97A7F8
		protected override void OnReset(); // 0x0000000184DA67E0-0x0000000184DA67F0
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Executes one child based on the provided int or enum case and returns its status.")]
	[Icon("IndexSwitcher", false, "")]
	public class Switch : BTComposite // TypeDefIndex: 52530
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
		public enum CaseSelectionMode // TypeDefIndex: 52528
		{
			IndexBased = 0,
			EnumBased = 1
		}
	
		public enum OutOfRangeMode // TypeDefIndex: 52529
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}
	
		// Constructors
		public Switch(); // 0x000000018A97B65C-0x000000018A97B720
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A97B4D8-0x000000018A97B65C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97B2A8-0x000000018A97B4D8
	}

	[Category("Decorators")]
	[Description("Executes and returns the child status only if the condition is true. Returns Failure if the condition is false.")]
	[Icon("Accessor", false, "")]
	[Name("Conditional", 0)]
	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 52531
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
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x000000018A96AED4-0x000000018A96AF2C
		private ConditionTask condition { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
	
		// Constructors
		public ConditionalEvaluator(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A96AD94-0x000000018A96AE9C
		protected override void OnReset(); // 0x000000018A96AE9C-0x000000018A96AED4
	}

	[Category("Decorators")]
	[Description("Filters the access of its child either a specific number of times, or every specific amount of time.")]
	[Icon("Filter", false, "")]
	[Name("Filter", 0)]
	public class Filter : BTDecorator // TypeDefIndex: 52535
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
		public enum FilterMode // TypeDefIndex: 52532
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}
	
		public enum Policy // TypeDefIndex: 52533
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}
	
		[CompilerGenerated]
		private sealed class _Cooldown_d__13 : IEnumerator<object> // TypeDefIndex: 52534
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Filter __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Cooldown_d__13(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A97B914-0x000000018A97B9D8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A97B9D8-0x000000018A97BA24
		}
	
		// Constructors
		public Filter(); // 0x000000018489BD50-0x000000018489BDF0
	
		// Methods
		public override void OnGraphStoped(); // 0x00000001841E1670-0x00000001841E1680
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A96FCC8-0x000000018A96FEB8
		public override void OnClearNodeData(); // 0x0000000184DA6790-0x0000000184DA67A0
		[IteratorStateMachine(typeof(_Cooldown_d__13))]
		private IEnumerator Cooldown(); // 0x000000018A96FC6C-0x000000018A96FCC8
	}

	[Category("Decorators")]
	[Description("Protects the decorated child from running if another Guard with the same token is already guarding (Running) that token.\nGuarding is global for all of the agent Behaviour Trees.")]
	[Icon("Shield", false, "")]
	[Name("Guard", 0)]
	public class Guard : BTDecorator // TypeDefIndex: 52537
	{
		// Fields
		[Tooltip("A unique Token to use for guarding.")]
		public BBParameter<string> token; // 0x98
		[Tooltip("What to return in case the token is already guarded by another Guard.")]
		public GuardMode ifGuarded; // 0xA0
		private bool isGuarding; // 0xA4
		private static readonly Dictionary<GameObject, List<Guard>> guards; // 0x00
	
		// Nested types
		public enum GuardMode // TypeDefIndex: 52536
		{
			ReturnFailure = 0,
			WaitUntilReleased = 1
		}
	
		// Constructors
		public Guard(); // 0x000000018489BC70-0x000000018489BC80
		static Guard(); // 0x000000018A975554-0x000000018A9755E0
	
		// Methods
		private static List<Guard> AgentGuards(Component agent); // 0x000000018A974E04-0x000000018A974E8C
		public override void OnGraphStarted(); // 0x000000018A975090-0x000000018A9750B4
		public override void OnGraphStoped(); // 0x000000018A9750B4-0x000000018A975360
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A974E8C-0x000000018A975090
		protected override void OnReset(); // 0x0000000184DA67B0-0x0000000184DA67C0
		private void SetGuards(Component guardAgent); // 0x000000018A975360-0x000000018A975554
	}

	[Category("Decorators")]
	[Description("Executes and returns the child status. If the condition is or becomes true, the child is interrupted and returns Failure.")]
	[Icon("Interruptor", false, "")]
	[Name("Interrupt", 0)]
	public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 52538
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x000000018A9756C4-0x000000018A97571C
	
		// Constructors
		public Interruptor(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A9755E0-0x000000018A9756C4
		protected override void OnReset(); // 0x000000018A96ACC8-0x000000018A96ACE4
	}

	[Category("Decorators")]
	[Description("Inverts Success to Failure and Failure to Success.")]
	[Icon("Remap", false, "")]
	[Name("Invert", 0)]
	public class Inverter : BTDecorator // TypeDefIndex: 52539
	{
		// Constructors
		public Inverter(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97571C-0x000000018A9757A4
	}

	[Category("Decorators")]
	[Description("Iterates a list and executes its child once for each element in that list. Keeps iterating until the Termination Policy is met or until the whole list is iterated, in which case the last iteration child status is returned.")]
	[Icon("List", false, "")]
	[Name("Iterate", 0)]
	public class Iterator : BTDecorator // TypeDefIndex: 52541
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
		private IList list { get; } // 0x000000018A975C34-0x000000018A975C84 
	
		// Nested types
		public enum TerminationConditions // TypeDefIndex: 52540
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}
	
		// Constructors
		public Iterator(); // 0x000000018A975BD4-0x000000018A975C34
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A975968-0x000000018A975BC0
		protected override void OnReset(); // 0x000000018A975BC0-0x000000018A975BD4
	}

	[Category("Decorators")]
	[Description("Merge can accept multiple input connections and thus possible to re-use leaf nodes from multiple parents. Please note that this is experimental and can result in unexpected behaviour.")]
	[Name("Merge", -1)]
	public class Merge : BTDecorator // TypeDefIndex: 52542
	{
		// Properties
		public override int maxInConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
	
		// Constructors
		public Merge(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A975D60-0x000000018A975DCC
	}

	[Category("Decorators")]
	[Description("Monitors the decorated child for a returned Status and executes an Action when that is the case.\nThe final Status returned to the parent can either be the original decorated child Status, or the new decorator Action Status.")]
	[Icon("Eye", false, "")]
	public class Monitor : BTDecorator, ITaskAssignable<ActionTask> // TypeDefIndex: 52545
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
		public ActionTask action { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x000000018A975F00-0x000000018A975F58
	
		// Nested types
		public enum MonitorMode // TypeDefIndex: 52543
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}
	
		public enum ReturnStatusMode // TypeDefIndex: 52544
		{
			OriginalDecoratedChildStatus = 0,
			NewDecoratorActionStatus = 1
		}
	
		// Constructors
		public Monitor(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A975DCC-0x000000018A975ECC
		protected override void OnReset(); // 0x000000018A975ECC-0x000000018A975F00
	}

	[Category("Decorators")]
	[Description("Executes the decorated child as normal and returns an Optional status, thus making it optional to the parent node in regards to what status is returned.\nThis has the same effect as disabling the node, but instead it executes normaly.")]
	[Icon("UpwardsArrow", false, "")]
	[Name("Optional", 0)]
	public class Optional : BTDecorator // TypeDefIndex: 52546
	{
		// Constructors
		public Optional(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A9784EC-0x000000018A978584
	}

	[Category("Decorators")]
	[Description("Remaps the child status to another status. Used to either invert the child\'s return status or to always return a specific status.")]
	[Icon("Remap", false, "")]
	[Name("Remap", 0)]
	public class Remapper : BTDecorator // TypeDefIndex: 52548
	{
		// Fields
		public RemapStatus successRemap; // 0x98
		public RemapStatus failureRemap; // 0x9C
	
		// Nested types
		public enum RemapStatus // TypeDefIndex: 52547
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Remapper(); // 0x000000018489BE70-0x000000018489BE90
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A979848-0x000000018A9798D8
	}

	[Category("Decorators")]
	[Description("Repeats the child either x times or until it returns the specified status, or forever.")]
	[Icon("Repeat", false, "")]
	[Name("Repeat", 0)]
	public class Repeater : BTDecorator // TypeDefIndex: 52551
	{
		// Fields
		public RepeaterMode repeaterMode; // 0x98
		[ShowIf("repeaterMode", 0)]
		public BBParameter<int> repeatTimes; // 0xA0
		[ShowIf("repeaterMode", 1)]
		public RepeatUntilStatus repeatUntilStatus; // 0xA8
		private int currentIteration; // 0xAC
	
		// Nested types
		public enum RepeaterMode // TypeDefIndex: 52549
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}
	
		public enum RepeatUntilStatus // TypeDefIndex: 52550
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Repeater(); // 0x000000018A9799FC-0x000000018A979A68
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A9798D8-0x000000018A9799FC
		protected override void OnReset(); // 0x0000000184DA67D0-0x0000000184DA67E0
	}

	[Category("Decorators")]
	[Description("Set another Agent for the rest of the Tree dynamicaly from this point and on. All nodes under this will be executed with the new agent. You can also use this decorator to revert back to the original graph agent.")]
	[Icon("Agent", false, "")]
	[Name("Override Agent", 0)]
	public class Setter : BTDecorator // TypeDefIndex: 52552
	{
		// Fields
		[Tooltip("If enabled, will revert back to the original graph agent.")]
		public bool revertToOriginal; // 0x98
		[ShowIf("revertToOriginal", 0)]
		[Tooltip("The new agent to use.")]
		public BBParameter<GameObject> newAgent; // 0xA0
	
		// Constructors
		public Setter(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A979DF8-0x000000018A979EB4
	}

	[Category("Decorators")]
	[Description("Interupts decorated child node and returns Failure if the child node is still Running after the timeout period.")]
	[Icon("Timeout", false, "")]
	public class Timeout : BTDecorator // TypeDefIndex: 52553
	{
		// Fields
		[Tooltip("The timeout period in seconds.")]
		public BBParameter<float> timeout; // 0x98
	
		// Constructors
		public Timeout(); // 0x000000018A97B810-0x000000018A97B86C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97B720-0x000000018A97B810
	}

	[Category("Decorators")]
	[Description("Returns Running until the assigned condition becomes true, after which the decorated child is executed.")]
	[Icon("Halt", false, "")]
	public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 52554
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
		private bool accessed; // 0xA0
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x000000018A97CB20-0x000000018A97CE08
		private ConditionTask condition { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
	
		// Constructors
		public WaitUntil(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97C9EC-0x000000018A97CAE8
		protected override void OnReset(); // 0x000000018A97CAE8-0x000000018A97CB20
	}

	[Description("Executes an action and returns Success or Failure when the action is finished.\nReturns Running until the action is finished.")]
	[Icon("Action", false, "")]
	[Name("Action", 0)]
	public class ActionNode : BTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 52555
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x000000018A968FE4-0x000000018A96903C
		public ActionTask action { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
	
		// Constructors
		public ActionNode(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A968E1C-0x000000018A968E4C
		protected override void OnReset(); // 0x000000018A968F30-0x000000018A968F4C
		public override void OnGraphPaused(); // 0x000000018A968EF8-0x000000018A968F14
	}

	[Description("Checks a condition and returns Success or Failure.")]
	[Icon("Condition", false, "")]
	[Name("Condition", 0)]
	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 52556
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x000000018A96ACE4-0x000000018A96AD3C
		public ConditionTask condition { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
	
		// Constructors
		public ConditionNode(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A96AB38-0x000000018A96ABBC
		protected override void OnReset(); // 0x000000018A96ACC8-0x000000018A96ACE4
	}

	[Description("Executes a sub Dialogue Tree. Returns Running while the sub Dialogue Tree is active. You can Finish the Dialogue Tree with the \'Finish\' node and return Success or Failure.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue", 0)]
	public class NestedDT : BTNodeNested<DialogueTree> // TypeDefIndex: 52557
	{
		// Fields
		[ExposeField]
		[Name("Sub Tree", 0)]
		[SerializeField]
		private BBParameter<DialogueTree> _nestedDialogueTree; // 0xB0
	
		// Properties
		public override DialogueTree subGraph { get; set; } // 0x000000018A977124-0x000000018A97716C 0x000000018A97716C-0x000000018A9771C4
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public NestedDT(); // 0x000000018A9770F0-0x000000018A977124
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A976F28-0x000000018A977070
		private void OnDLGFinished(bool success); // 0x000000018A9698FC-0x000000018A969910
		protected override void OnReset(); // 0x000000018A977070-0x000000018A9770F0
	}

	[Description("Executes a sub FSM. Returns Running while the sub FSM is active. If a Success or Failure State is selected, then it will return Success or Failure as soon as the Nested FSM enters that state at which point the sub FSM will also be stoped. If the sub FSM ends otherwise, this node will return Success.")]
	[DropReferenceType(typeof(FSM))]
	[Icon("FSM", false, "")]
	[Name("Sub FSM", 0)]
	public class NestedFSM : BTNodeNested<FSM> // TypeDefIndex: 52558
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
		public override FSM subGraph { get; set; } // 0x000000018A97770C-0x000000018A977754 0x000000018A977754-0x000000018A9777AC
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public NestedFSM(); // 0x000000018A9776D8-0x000000018A97770C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97747C-0x000000018A977658
		private void OnFSMFinish(bool success); // 0x000000018A9698FC-0x000000018A969910
		protected override void OnReset(); // 0x000000018A977658-0x000000018A9776D8
	}

	[Description("Executes a sub Behaviour Tree. The status of the root node in the SubTree will be returned.")]
	[DropReferenceType(typeof(BehaviourTree))]
	[Icon("BT", false, "")]
	[Name("Sub Tree", 0)]
	public class SubTree : BTNodeNested<BehaviourTree> // TypeDefIndex: 52559
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override BehaviourTree subGraph { get; set; } // 0x0000000184CD94E0-0x0000000184CD9510 0x0000000184D19410-0x0000000184D19470
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public SubTree(); // 0x0000000184D50FB0-0x0000000184D50FF0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A97AD90-0x000000018A97AE64
		protected override void OnReset(); // 0x000000018A97AE64-0x000000018A97AEE4
	}

	[Category("Mutators (beta)")]
	[Description("Enable, Disable or Toggle one or more nodes with provided tag. In practise their incomming connections are disabled\nBeta Feature!")]
	[Name("Node Toggler", 0)]
	[Obsolete]
	public class NodeToggler : BTNode // TypeDefIndex: 52561
	{
		// Fields
		public ToggleMode toggleMode; // 0x98
		public string targetNodeTag; // 0xA0
		private List<NodeCanvas.Framework.Node> targetNodes; // 0xA8
	
		// Nested types
		public enum ToggleMode // TypeDefIndex: 52560
		{
			Enable = 0,
			Disable = 1,
			Toggle = 2
		}
	
		// Constructors
		public NodeToggler(); // 0x000000018A977C4C-0x000000018A977C60
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A977BD0-0x000000018A977C4C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A9777AC-0x000000018A977BD0
	}

	[Category("Mutators (beta)")]
	[Description("Switch the root node of the behaviour tree to a new one defined by tag\nBeta Feature!")]
	[Name("Root Switcher", 0)]
	[Obsolete]
	public class RootSwitcher : BTNode // TypeDefIndex: 52562
	{
		// Fields
		public string targetNodeTag; // 0x98
		private NodeCanvas.Framework.Node targetNode; // 0xA0
	
		// Constructors
		public RootSwitcher(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A979AD4-0x000000018A979B34
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A979A68-0x000000018A979AD4
	}

	[Description("Executes a nested FlowScript. Returns Running while the FlowScript is active. You can Finish the FlowScript with the \'Finish\' node and return Success or Failure")]
	[DropReferenceType(typeof(FlowScript))]
	[Icon("FS", false, "")]
	[Name("Sub FlowScript", 0)]
	public class BTNestedFlowScript : BTNodeNested<FlowScript> // TypeDefIndex: 52563
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xB0
	
		// Properties
		public override FlowScript subGraph { get; set; } // 0x000000018A9699C4-0x000000018A969A0C 0x000000018A969A0C-0x000000018A969A64
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public BTNestedFlowScript(); // 0x000000018A969990-0x000000018A9699C4
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A9697DC-0x000000018A9698FC
		private void OnFlowScriptFinished(bool success); // 0x000000018A9698FC-0x000000018A969910
		protected override void OnReset(); // 0x000000018A969910-0x000000018A969990
	}
}

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu("NodeCanvas/Dialogue Actor")]
	public class DialogueActor : MonoBehaviour, IDialogueActor // TypeDefIndex: 52463
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
		public new string name { get; } // 0x000000018385B100-0x000000018385B110 
		public Texture2D portrait { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Sprite portraitSprite { get; } // 0x000000018A96C44C-0x000000018A96C56C 
		public UnityEngine.Color dialogueColor { get; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 
		public Vector3 dialoguePosition { get; } // 0x000000018A96C3E4-0x000000018A96C44C 
		Transform IDialogueActor.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Constructors
		public DialogueActor(); // 0x000000018A90E334-0x000000018A90E36C
	}

	public class SubtitlesRequestInfo // TypeDefIndex: 52464
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public IStatement statement; // 0x18
		public Action Continue; // 0x20
	
		// Constructors
		public SubtitlesRequestInfo(IDialogueActor actor, IStatement statement, Action callback); // 0x00000001831D14F0-0x00000001831D1530
	}

	public class MultipleChoiceRequestInfo // TypeDefIndex: 52465
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public Dictionary<IStatement, int> options; // 0x18
		public float availableTime; // 0x20
		public bool showLastStatement; // 0x24
		public Action<int> SelectOption; // 0x28
	
		// Constructors
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback); // 0x000000018A9764E0-0x000000018A976528
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, Action<int> callback); // 0x000000018A9764A0-0x000000018A9764E0
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Dialogue Tree Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class DialogueTree : NodeCanvas.Framework.Graph // TypeDefIndex: 52474
	{
		// Fields
		public const string INSTIGATOR_NAME = "SELF"; // Metadata: 0x02331CA9
		[SerializeField]
		public List<ActorParameter> actorParameters; // 0xA0
		[CompilerGenerated]
		private static Action<DialogueTree> OnDialogueStarted; // 0x00
		[CompilerGenerated]
		private static Action<DialogueTree> OnDialoguePaused; // 0x08
		[CompilerGenerated]
		private static Action<DialogueTree> OnDialogueFinished; // 0x10
		[CompilerGenerated]
		private static Action<SubtitlesRequestInfo> OnSubtitlesRequest; // 0x18
		[CompilerGenerated]
		private static Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest; // 0x20
		[CompilerGenerated]
		private static DialogueTree _currentDialogue_k__BackingField; // 0x28
		[CompilerGenerated]
		private static DialogueTree _previousDialogue_k__BackingField; // 0x30
		[CompilerGenerated]
		private DTNode _currentNode_k__BackingField; // 0xA8
	
		// Properties
		public static DialogueTree currentDialogue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018A96DB28-0x000000018A96DB60 0x000000018A96E02C-0x000000018A96E080
		public static DialogueTree previousDialogue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018A96DCC8-0x000000018A96DD00 0x000000018A96E080-0x000000018A96E0D4
		public DTNode currentNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		public override System.Type baseNodeType { get; } // 0x000000018A96DAD8-0x000000018A96DB28 
		public override bool requiresAgent { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool requiresPrimeNode { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool isTree { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool allowBlackboardOverrides { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001812081B0-0x0000000181208610 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001812081B0-0x0000000181208610 
		public List<string> definedActorParameterNames { get; } // 0x000000018A96DB60-0x000000018A96DCC8 
	
		// Events
		public static event Action<DialogueTree> OnDialogueStarted {
			add; // 0x000000018A96D8F4-0x000000018A96D990
			remove; // 0x000000018A96DE48-0x000000018A96DEE4
		}
		public static event Action<DialogueTree> OnDialoguePaused {
			add; // 0x000000018A96D850-0x000000018A96D8F4
			remove; // 0x000000018A96DDA4-0x000000018A96DE48
		}
		public static event Action<DialogueTree> OnDialogueFinished {
			add; // 0x000000018A96D7AC-0x000000018A96D850
			remove; // 0x000000018A96DD00-0x000000018A96DDA4
		}
		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest {
			add; // 0x000000018A96DA34-0x000000018A96DAD8
			remove; // 0x000000018A96DF88-0x000000018A96E02C
		}
		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest {
			add; // 0x000000018A96D990-0x000000018A96DA34
			remove; // 0x000000018A96DEE4-0x000000018A96DF88
		}
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 52466
		{
			// Fields
			public List<ActorParameter> actorParameters; // 0x10
	
			// Constructors
			public DerivedSerializationData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class ActorParameter // TypeDefIndex: 52467
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
			public string name { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			public string ID { get; } // 0x000000018A9692B0-0x000000018A96930C 
			public IDialogueActor actor { get; set; } // 0x000000018A96930C-0x000000018A96937C 0x000000018A96937C-0x000000018A9693EC
	
			// Constructors
			public ActorParameter(); // 0x00000001841E1670-0x00000001841E1680
			public ActorParameter(string name); // 0x00000001853908C0-0x00000001853908D0
			public ActorParameter(string name, IDialogueActor actor); // 0x000000018A969284-0x000000018A9692B0
	
			// Methods
			public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52468
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ActorParameter, string> __9__48_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A97C894-0x000000018A97C8F8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _get_definedActorParameterNames_b__48_0(ActorParameter r); // 0x0000000186C08920-0x0000000186C08938
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0 // TypeDefIndex: 52469
		{
			// Fields
			public string id; // 0x10
	
			// Constructors
			public __c__DisplayClass49_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetParameterByID_b__0(ActorParameter p); // 0x000000018A97C7D0-0x000000018A97C808
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 52470
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetParameterByName_b__0(ActorParameter p); // 0x0000000186CC7538-0x0000000186CC7560
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 52471
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetActorReferenceByName_b__0(ActorParameter r); // 0x0000000186CC7538-0x0000000186CC7560
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 52472
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _SetActorReference_b__0(ActorParameter p); // 0x0000000186CC7538-0x0000000186CC7560
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 52473
		{
			// Fields
			public KeyValuePair<string, IDialogueActor> pair; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _SetActorReferences_b__0(ActorParameter p); // 0x000000018A97C808-0x000000018A97C85C
		}
	
		// Constructors
		public DialogueTree(); // 0x000000018A96D70C-0x000000018A96D7AC
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x000000018A96CFD0-0x000000018A96D02C
		public override void OnDerivedDataDeserialization(object data); // 0x000000018A96CF44-0x000000018A96CFD0
		public ActorParameter GetParameterByID(string id); // 0x000000018A96CD9C-0x000000018A96CE70
		public ActorParameter GetParameterByName(string paramName); // 0x000000018A96CE70-0x000000018A96CF44
		public IDialogueActor GetActorReferenceByID(string id); // 0x000000018A96CB08-0x000000018A96CB38
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x000000018A96CB38-0x000000018A96CD9C
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x000000018A96D3D4-0x000000018A96D4C8
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x000000018A96D4C8-0x000000018A96D70C
		public void Continue(int index = 0 /* Metadata: 0x02331CA8 */); // 0x000000018A96C980-0x000000018A96CA74
		public void EnterNode(DTNode node); // 0x000000018A96CA74-0x000000018A96CB08
		public static void RequestSubtitles(SubtitlesRequestInfo info); // 0x000000018A96D384-0x000000018A96D3D4
		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info); // 0x000000018A96D334-0x000000018A96D384
		protected override void OnGraphStarted(); // 0x000000018A96D07C-0x000000018A96D16C
		protected override void OnGraphUpdate(); // 0x000000018A96D2B8-0x000000018A96D334
		protected override void OnGraphStoped(); // 0x000000018A96D16C-0x000000018A96D20C
		protected override void OnGraphPaused(); // 0x000000018A96D02C-0x000000018A96D07C
		protected override void OnGraphUnpaused(); // 0x000000018A96D20C-0x000000018A96D2B8
	}

	[AddComponentMenu("NodeCanvas/Dialogue Tree Controller")]
	public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor // TypeDefIndex: 52475
	{
		// Properties
		string IDialogueActor.name { get; } // 0x0000000185396F58-0x0000000185396F60 
		Texture2D IDialogueActor.portrait { get; } // 0x00000001811EC580-0x00000001811EC590 
		Sprite IDialogueActor.portraitSprite { get; } // 0x00000001811EC580-0x00000001811EC590 
		UnityEngine.Color IDialogueActor.dialogueColor { get; } // 0x000000018A96C614-0x000000018A96C634 
		Vector3 IDialogueActor.dialoguePosition { get; } // 0x0000000189D954F8-0x0000000189D95510 
		Transform IDialogueActor.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Constructors
		public DialogueTreeController(); // 0x000000018A96C94C-0x000000018A96C980
	
		// Methods
		public void StartDialogue(); // 0x000000018A96C7B8-0x000000018A96C7C8
		public void StartDialogue(Action<bool> callback); // 0x000000018A96C900-0x000000018A96C910
		public void StartDialogue(IDialogueActor instigator); // 0x000000018A96C910-0x000000018A96C91C
		public void StartDialogue(DialogueTree newTree, IDialogueActor instigator, Action<bool> callback); // 0x000000018A96C7C8-0x000000018A96C810
		public void StartDialogue(IDialogueActor instigator, Action<bool> callback); // 0x000000018A96C810-0x000000018A96C900
		public void PauseDialogue(); // 0x000000018A96C634-0x000000018A96C660
		public void StopDialogue(); // 0x000000018A96C91C-0x000000018A96C94C
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x000000018A96C660-0x000000018A96C714
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x000000018A96C714-0x000000018A96C7B8
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x000000018A96C56C-0x000000018A96C614
	}

	public class DTConnection : Connection // TypeDefIndex: 52476
	{
		// Constructors
		public DTConnection(); // 0x0000000184D92320-0x0000000184D92330
	}

	public abstract class DTNode : NodeCanvas.Framework.Node // TypeDefIndex: 52477
	{
		// Fields
		[SerializeField]
		private string _actorName; // 0x98
		[SerializeField]
		private string _actorParameterID; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018A96C020-0x000000018A96C0F8 
		public virtual bool requireActorSelection { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override int maxInConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public override int maxOutConnections { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public sealed override System.Type outConnectionType { get; } // 0x000000018A96C0F8-0x000000018A96C148 
		public sealed override bool allowAsPrime { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public sealed override bool canSelfConnect { get; } // 0x00000001812081B0-0x0000000181208610 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		protected DialogueTree DLGTree { get; } // 0x000000018A96BF40-0x000000018A96BF7C 
		public string actorName { get; private set; } // 0x000000018A96BF7C-0x000000018A96BFC4 0x000000018A96C148-0x000000018A96C1E8
		public IDialogueActor finalActor { get; } // 0x000000018A96BFC4-0x000000018A96C020 
	
		// Constructors
		protected DTNode(); // 0x000000018A96BEF0-0x000000018A96BF40
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class DTNodeNested<T> : DTNode, IGraphAssignable<T> // TypeDefIndex: 52478
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
		[CompilerGenerated]
		private T _currentInstance_k__BackingField;
		[CompilerGenerated]
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected DTNodeNested();
	}

	public interface IDialogueActor // TypeDefIndex: 52479
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
	public class ProxyDialogueActor : IDialogueActor // TypeDefIndex: 52480
	{
		// Fields
		private string _name; // 0x10
		private Transform _transform; // 0x18
	
		// Properties
		public string name { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public Texture2D portrait { get; } // 0x00000001811EC580-0x00000001811EC590 
		public Sprite portraitSprite { get; } // 0x00000001811EC580-0x00000001811EC590 
		public UnityEngine.Color dialogueColor { get; } // 0x000000018A96C614-0x000000018A96C634 
		public Vector3 dialoguePosition { get; } // 0x0000000189D954F8-0x0000000189D95510 
		public Transform transform { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public ProxyDialogueActor(string name, Transform transform); // 0x00000001832AF420-0x00000001832AF450
	}

	public interface IStatement // TypeDefIndex: 52481
	{
		// Properties
		string text { get; }
		AudioClip audio { get; }
		string meta { get; }
	}

	[Serializable]
	public class Statement : IStatement // TypeDefIndex: 52483
	{
		// Fields
		[SerializeField]
		private string _text; // 0x10
		[SerializeField]
		private AudioClip _audio; // 0x18
		[SerializeField]
		private string _meta; // 0x20
	
		// Properties
		public string text { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public AudioClip audio { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string meta { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 52482
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _BlackboardReplace_b__0(string input); // 0x000000018A97C558-0x000000018A97C74C
		}
	
		// Constructors
		public Statement(); // 0x000000018A97A6F8-0x000000018A97A760
		public Statement(string text); // 0x000000018A97A528-0x000000018A97A5A8
		public Statement(string text, AudioClip audio); // 0x000000018A97A65C-0x000000018A97A6F8
		public Statement(string text, AudioClip audio, string meta); // 0x000000018A97A5A8-0x000000018A97A65C
	
		// Methods
		public IStatement BlackboardReplace(IBlackboard bb); // 0x000000018A97A3F0-0x000000018A97A528
		public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
	}

	[Description("Execute an Action Task for the Dialogue Actor selected.")]
	[Name("Task Action", 0)]
	public class ActionNode : DTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 52485
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0xA8
	
		// Properties
		public ActionTask action { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x000000018A96903C-0x000000018A969094
		public override bool requireActorSelection { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _UpdateAction_d__10 : IEnumerator<object> // TypeDefIndex: 52484
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ActionNode __4__this; // 0x20
			public Component actionAgent; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _UpdateAction_d__10(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A97C8F8-0x000000018A97C9A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A97C9A0-0x000000018A97C9EC
		}
	
		// Constructors
		public ActionNode(); // 0x0000000189876A0C-0x0000000189876A14
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A968E4C-0x000000018A968EDC
		[IteratorStateMachine(typeof(_UpdateAction_d__10))]
		private IEnumerator UpdateAction(Component actionAgent); // 0x000000018A968F4C-0x000000018A968FC0
		private void OnActionEnd(bool success); // 0x000000018A968DB0-0x000000018A968E1C
		protected override void OnReset(); // 0x000000018A968F14-0x000000018A968F30
		public override void OnGraphPaused(); // 0x000000018A968EDC-0x000000018A968EF8
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Execute the first child node if a Condition is true, or the second one if that Condition is false. The Actor selected is used for the Condition check")]
	[Icon("Condition", false, "")]
	[Name("Task Condition", 0)]
	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 52486
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0xA8
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x000000018A96AD3C-0x000000018A96AD94
		public override int maxOutConnections { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override bool requireActorSelection { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public ConditionNode(); // 0x0000000189876A0C-0x0000000189876A14
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A96ABBC-0x000000018A96ACC8
	}

	[Category("Control")]
	[Color("6ebbff")]
	[Description("End the dialogue in Success or Failure.\nNote: A Dialogue will anyway End in Succcess if it has reached a node without child connections. Thus this node is mostly useful if you want to end a Dialogue in Failure.")]
	[Icon("Halt", false, "")]
	[Name("FINISH", 0)]
	public class FinishNode : DTNode // TypeDefIndex: 52487
	{
		// Fields
		public CompactStatus finishState; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool requireActorSelection { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public FinishNode(); // 0x000000018A96FF04-0x000000018A96FF18
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A96FEB8-0x000000018A96FF04
	}

	[Category("Control")]
	[Color("6ebbff")]
	[Description("Select a target node to jump to.\nFor your convenience in identifying nodes in the dropdown, please give a Tag name to the nodes you want to use in this way.")]
	[Icon("Set", false, "")]
	[Name("JUMP", 0)]
	public class Jumper : DTNode, IHaveNodeReference // TypeDefIndex: 52488
	{
		// Fields
		[fsSerializeAs("_sourceNodeUID")]
		public NodeReference<DTNode> _targetNode; // 0xA8
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get; } // 0x0000000184D86290-0x0000000184D862A0 
		private DTNode target { get; } // 0x000000018A975D10-0x000000018A975D60 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool requireActorSelection { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public Jumper(); // 0x0000000189876A0C-0x0000000189876A14
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A975C84-0x000000018A975D10
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Prompt a Dialogue Multiple Choice. A choice will be available if the choice condition(s) are true or there is no choice conditions. The Actor selected is used for the condition checks and will also Say the selection if the option is checked.")]
	[Icon("List", false, "")]
	[Name("Multiple Choice", 0)]
	public class MultipleChoiceNode : DTNode // TypeDefIndex: 52491
	{
		// Fields
		[SliderField(0f, 10f)]
		public float availableTime; // 0xA8
		public bool saySelection; // 0xAC
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<Choice> availableChoices; // 0xB0
	
		// Properties
		public override int maxOutConnections { get; } // 0x000000018A976460-0x000000018A9764A0 
		public override bool requireActorSelection { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Nested types
		[Serializable]
		public class Choice // TypeDefIndex: 52489
		{
			// Fields
			public bool isUnfolded; // 0x10
			public Statement statement; // 0x18
			public ConditionTask condition; // 0x20
	
			// Constructors
			public Choice(); // 0x00000001815EFCD0-0x00000001815EFCE0
			public Choice(Statement statement); // 0x000000018952DB04-0x000000018952DB18
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 52490
		{
			// Fields
			public MultipleChoiceNode __4__this; // 0x10
			public int index; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnOptionSelected_b__0(); // 0x000000018A97C85C-0x000000018A97C894
		}
	
		// Constructors
		public MultipleChoiceNode(); // 0x000000018A9763D8-0x000000018A976460
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A975F58-0x000000018A976258
		private void OnOptionSelected(int index); // 0x000000018A976258-0x000000018A9763D8
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Will continue with the first child node which condition returns true. The Dialogue Actor selected will be used for the checks")]
	[Icon("Selector", false, "")]
	[Name("Multiple Task Condition", 0)]
	public class MultipleConditionNode : DTNode // TypeDefIndex: 52492
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<ConditionTask> conditions; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
	
		// Constructors
		public MultipleConditionNode(); // 0x000000018A976788-0x000000018A976810
	
		// Methods
		public override void OnChildConnected(int index); // 0x000000018A976528-0x000000018A9765B4
		public override void OnChildDisconnected(int index); // 0x000000018A9765B4-0x000000018A97660C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A97660C-0x000000018A976788
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Select a child to execute based on it\'s chance to be selected. An optional pre-Condition Task can be assigned to filter the child in or out of the selection probability.\nThe actor selected will be used for the condition checks.")]
	[Icon("ProbabilitySelector", false, "")]
	public class ProbabilitySelector : DTNode // TypeDefIndex: 52494
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<Option> childOptions; // 0xA8
		private List<int> successIndeces; // 0xB0
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
	
		// Nested types
		public class Option // TypeDefIndex: 52493
		{
			// Fields
			public BBParameter<float> weight; // 0x10
			public ConditionTask condition; // 0x18
	
			// Constructors
			public Option(float weightValue, IBlackboard bbValue); // 0x000000018A978430-0x000000018A9784EC
		}
	
		// Constructors
		public ProbabilitySelector(); // 0x000000018A9797C0-0x000000018A979848
	
		// Methods
		public override void OnChildConnected(int index); // 0x000000018A978F70-0x000000018A979054
		public override void OnChildDisconnected(int index); // 0x000000018A9791BC-0x000000018A979214
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018A9794A8-0x000000018A979720
		private float GetTotal(); // 0x000000018A978E8C-0x000000018A978F70
		protected override void OnReset(); // 0x000000018A93C6F0-0x000000018A93C708
	}

	[Description("Make the selected Dialogue Actor talk. You can make the text more dynamic by using variable names in square brackets\ne.g. [myVarName] or [Global/myVarName]")]
	[Name("Say", 0)]
	public class StatementNode : DTNode // TypeDefIndex: 52495
	{
		// Fields
		[SerializeField]
		public Statement statement; // 0xA8
	
		// Properties
		public override bool requireActorSelection { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public StatementNode(); // 0x000000018A97A368-0x000000018A97A3F0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A97A230-0x000000018A97A328
		private void OnStatementFinish(); // 0x000000018A97A328-0x000000018A97A368
	}

	[Description("Execute a Sub Dialogue Tree. When that Dialogue Tree is finished, this node will continue either in Success or Failure if it has any connections. Useful for making reusable and self-contained Dialogue Trees.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue Tree", 0)]
	public class SubDialogueTree : DTNodeNested<DialogueTree>, IUpdatable // TypeDefIndex: 52496
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<DialogueTree> _subTree; // 0xC0
		[fsSerializeAs("actorParametersMap")]
		private Dictionary<string, string> _actorParametersMap; // 0xC8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override DialogueTree subGraph { get; set; } // 0x000000018A97ACF0-0x000000018A97AD38 0x000000018A97AD38-0x000000018A97AD90
		public override BBParameter subGraphParameter { get; } // 0x0000000184D892F0-0x0000000184D89300 
	
		// Constructors
		public SubDialogueTree(); // 0x000000018A97ACBC-0x000000018A97ACF0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A97A88C-0x000000018A97AA78
		private void OnSubDialogueFinish(bool success); // 0x000000018A97AA78-0x000000018A97AAD0
		void IUpdatable.Update(); // 0x000000018A97A7F8-0x000000018A97A88C
		private void TryWriteMappedActorParameters(); // 0x000000018A97AAD0-0x000000018A97ACBC
	}

	[Obsolete("Use Jumpers instead")]
	public class GoToNode : DTNode // TypeDefIndex: 52497
	{
		// Fields
		[SerializeField]
		private DTNode _targetNode; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool requireActorSelection { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public GoToNode(); // 0x0000000189876A0C-0x0000000189876A14
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A9703AC-0x000000018A970424
	}

	[Description("Executes a FlowScript. Use the Finish flowscript node to continue the dialogue either in Success or Failure.\nThe actor selected here will also be used in the flowcript for \'Self\'.")]
	[DropReferenceType(typeof(FlowScript))]
	[Name("Sub FlowScript", 0)]
	public class DTNestedFlowScript : DTNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 52498
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xC0
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override FlowScript subGraph { get; set; } // 0x000000018A96BE50-0x000000018A96BE98 0x000000018A96BE98-0x000000018A96BEF0
		public override BBParameter subGraphParameter { get; } // 0x0000000184D892F0-0x0000000184D89300 
	
		// Constructors
		public DTNestedFlowScript(); // 0x000000018A96BE1C-0x000000018A96BE50
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A96BCC0-0x000000018A96BDCC
		void IUpdatable.Update(); // 0x000000018A96BC2C-0x000000018A96BCC0
		private void OnFlowScriptFinish(bool success); // 0x000000018A96BDCC-0x000000018A96BE1C
	}
}

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : MonoBehaviour // TypeDefIndex: 52507
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
		private AudioSource localSource { get; } // 0x000000018A96F7C8-0x000000018A96F874 
		private bool anyKeyDown { get; } // 0x000000018A96F7C0-0x000000018A96F7C8 
	
		// Nested types
		[Serializable]
		public class SubtitleDelays // TypeDefIndex: 52499
		{
			// Fields
			public float characterDelay; // 0x10
			public float sentenceDelay; // 0x14
			public float commaDelay; // 0x18
			public float finalDelay; // 0x1C
	
			// Constructors
			public SubtitleDelays(); // 0x0000000184DA67F0-0x0000000184DA6810
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 52500
		{
			// Fields
			public bool inputDown; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Internal_OnSubtitlesRequestInfo_b__0(); // 0x00000001815EFCD0-0x00000001815EFCE0
		}
	
		[CompilerGenerated]
		private sealed class _Internal_OnSubtitlesRequestInfo_d__31 : IEnumerator<object> // TypeDefIndex: 52501
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Internal_OnSubtitlesRequestInfo_d__31(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A97BC90-0x000000018A97C50C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A97C50C-0x000000018A97C558
		}
	
		[CompilerGenerated]
		private sealed class _CheckInput_d__33 : IEnumerator<object> // TypeDefIndex: 52502
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DialogueUGUI __4__this; // 0x20
			public Action Do; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CheckInput_d__33(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A97B86C-0x000000018A97B8C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A97B8C8-0x000000018A97B914
		}
	
		[CompilerGenerated]
		private sealed class _DelayPrint_d__34 : IEnumerator<object> // TypeDefIndex: 52503
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float time; // 0x20
			private float _timer_5__2; // 0x24
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DelayPrint_d__34(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A97BBD8-0x000000018A97BC44
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A97BC44-0x000000018A97BC90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 52504
		{
			// Fields
			public DialogueUGUI __4__this; // 0x10
			public MultipleChoiceRequestInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_1 // TypeDefIndex: 52505
		{
			// Fields
			public UnityEngine.UI.Button btn; // 0x10
			public __c__DisplayClass35_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass35_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnMultipleChoiceRequest_b__0(); // 0x000000018A97C74C-0x000000018A97C7D0
		}
	
		[CompilerGenerated]
		private sealed class _CountDown_d__36 : IEnumerator<object> // TypeDefIndex: 52506
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DialogueUGUI __4__this; // 0x20
			public MultipleChoiceRequestInfo info; // 0x28
			private float _timer_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CountDown_d__36(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A97BA24-0x000000018A97BB8C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A97BB8C-0x000000018A97BBD8
		}
	
		// Constructors
		public DialogueUGUI(); // 0x000000018A96F74C-0x000000018A96F7C0
	
		// Methods
		private void Awake(); // 0x000000018A96E0D4-0x000000018A96E0F4
		private void OnEnable(); // 0x000000018A96EA08-0x000000018A96EA28
		private void OnDisable(); // 0x000000018A96EA00-0x000000018A96EA08
		private void Subscribe(); // 0x000000018A96F41C-0x000000018A96F5B4
		private void UnSubscribe(); // 0x000000018A96F5B4-0x000000018A96F74C
		private void Hide(); // 0x000000018A96E51C-0x000000018A96E62C
		private void OnDialogueStarted(DialogueTree dlg); // 0x00000001841E1670-0x00000001841E1680
		private void OnDialoguePaused(DialogueTree dlg); // 0x000000018A96E940-0x000000018A96EA00
		private void OnDialogueFinished(DialogueTree dlg); // 0x000000018A96E6A0-0x000000018A96E940
		private void OnSubtitlesRequest(SubtitlesRequestInfo info); // 0x000000018A96F27C-0x000000018A96F2A0
		[IteratorStateMachine(typeof(_Internal_OnSubtitlesRequestInfo_d__31))]
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info); // 0x000000018A96E62C-0x000000018A96E6A0
		private void PlayTypeSound(); // 0x000000018A96F2A0-0x000000018A96F38C
		[IteratorStateMachine(typeof(_CheckInput_d__33))]
		private IEnumerator CheckInput(Action Do); // 0x000000018A96E0F4-0x000000018A96E168
		[IteratorStateMachine(typeof(_DelayPrint_d__34))]
		private IEnumerator DelayPrint(float time); // 0x000000018A96E1DC-0x000000018A96E230
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info); // 0x000000018A96EA28-0x000000018A96F27C
		[IteratorStateMachine(typeof(_CountDown_d__36))]
		private IEnumerator CountDown(MultipleChoiceRequestInfo info); // 0x000000018A96E168-0x000000018A96E1DC
		private void Finalize(MultipleChoiceRequestInfo info, int index); // 0x000000018A96E230-0x000000018A96E51C
		private void SetMassAlpha(RectTransform root, float alpha); // 0x000000018A96F38C-0x000000018A96F41C
	}
}

namespace NodeCanvas.Framework
{
	[AttributeUsage(AttributeTargets.Class)]
	public class GraphInfoAttribute : Attribute // TypeDefIndex: 52564
	{
		// Fields
		public string packageName; // 0x10
		public string docsURL; // 0x18
		public string resourcesURL; // 0x20
		public string forumsURL; // 0x28
	
		// Constructors
		public GraphInfoAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DropReferenceType : Attribute // TypeDefIndex: 52565
	{
		// Fields
		public readonly System.Type type; // 0x10
	
		// Constructors
		public DropReferenceType(System.Type type); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class BlackboardOnlyAttribute : Attribute // TypeDefIndex: 52566
	{
		// Constructors
		public BlackboardOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class LogTag // TypeDefIndex: 52567
	{
		// Fields
		public const string EDITOR = "Editor"; // Metadata: 0x02331CCE
		public const string EVENT = "Event"; // Metadata: 0x02331CD5
		public const string EXECUTION = "Execution"; // Metadata: 0x02331CDB
		public const string VARIABLE = "Variable"; // Metadata: 0x02331CE5
		public const string BLACKBOARD = "Blackboard"; // Metadata: 0x02331CEE
		public const string GRAPH = "Graph"; // Metadata: 0x02331CF9
		public const string INIT = "Initialization"; // Metadata: 0x02331CFF
		public const string VALIDATION = "Validation"; // Metadata: 0x02331D0E
		public const string SERIALIZATION = "Serialization"; // Metadata: 0x02331D19
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/CanvasCore/Signal Definition")]
	public class SignalDefinition : ScriptableObject // TypeDefIndex: 52570
	{
		// Fields
		[CompilerGenerated]
		private InvokeArguments onInvoke; // 0x18
		[HideInInspector]
		[SerializeField]
		private List<DynamicParameterDefinition> _parameters; // 0x20
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get; private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Events
		public event InvokeArguments onInvoke {
			add; // 0x000000018A97A108-0x000000018A97A19C
			remove; // 0x000000018A97A19C-0x000000018A97A230
		}
	
		// Nested types
		public delegate void InvokeArguments(Transform sender, Transform receiver, bool isGlobal, params object[] args); // TypeDefIndex: 52568; 0x00000001815547C0-0x00000001815547E0
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 52569
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveParameter_b__0(DynamicParameterDefinition p); // 0x000000018A8D9104-0x000000018A8D912C
		}
	
		// Constructors
		public SignalDefinition(); // 0x000000018A97A088-0x000000018A97A108
	
		// Methods
		public void Invoke(Transform sender, Transform receiver, bool isGlobal, params object[] args); // 0x000000018A979F50-0x000000018A979F80
		public void AddParameter(string name, System.Type type); // 0x000000018A979EB4-0x000000018A979F50
		public void RemoveParameter(string name); // 0x000000018A979F80-0x000000018A97A088
	}

	[Serializable]
	public class CanvasGroup // TypeDefIndex: 52571
	{
		// Fields
		public string name; // 0x10
		public Rect rect; // 0x18
		public UnityEngine.Color color; // 0x28
		public bool autoGroup; // 0x38
	
		// Constructors
		public CanvasGroup(); // 0x00000001841E1670-0x00000001841E1680
		public CanvasGroup(Rect rect, string name); // 0x000000018A96A2F4-0x000000018A96A308
	}

	[Serializable]
	[fsDeserializeOverwrite]
	[SpoofAOT]
	public abstract class Connection : IGraphElement, ISerializationCollectable // TypeDefIndex: 52572
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
		public string UID { get; } // 0x000000018A96B9DC-0x000000018A96BA38 
		public NodeCanvas.Framework.Node sourceNode { get; protected set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public NodeCanvas.Framework.Node targetNode { get; protected set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		string IGraphElement.name { get; } // 0x000000018A96B318-0x000000018A96B344 
		public bool isActive { get; set; } // 0x000000018A96BA4C-0x000000018A96BA54 0x000000018A96BA54-0x000000018A96BA88
		public NodeCanvas.Framework.Status status { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public NodeCanvas.Framework.Graph graph { get; } // 0x000000018A96BA38-0x000000018A96BA4C 
		public virtual bool drawInspector { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public Connection(); // 0x0000000184D92320-0x0000000184D92330
	
		// Methods
		public static Connection Create(NodeCanvas.Framework.Node source, NodeCanvas.Framework.Node target, int sourceIndex = -1 /* Metadata: 0x02331D27 */, int targetIndex = -1 /* Metadata: 0x02331D28 */); // 0x000000018A96AF2C-0x000000018A96B01C
		public Connection Duplicate(NodeCanvas.Framework.Node newSource, NodeCanvas.Framework.Node newTarget); // 0x000000018A96B01C-0x000000018A96B2E0
		public int SetSourceNode(NodeCanvas.Framework.Node newSource, int index = -1 /* Metadata: 0x02331D29 */, bool recodeUndo = true /* Metadata: 0x02331D2A */); // 0x000000018A96B56C-0x000000018A96B70C
		public int SetTargetNode(NodeCanvas.Framework.Node newTarget, int index = -1 /* Metadata: 0x02331D2B */, bool recodeUndo = true /* Metadata: 0x02331D2C */); // 0x000000018A96B70C-0x000000018A96B98C
		public int SetRawSourceNode(NodeCanvas.Framework.Node newSource); // 0x000000018A96B37C-0x000000018A96B474
		public int SetRawTargetNode(NodeCanvas.Framework.Node newTarget); // 0x000000018A96B474-0x000000018A96B56C
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard); // 0x000000018A96B2E0-0x000000018A96B318
		public void Reset(bool recursively = true /* Metadata: 0x02331D2D */); // 0x000000018A96B344-0x000000018A96B37C
		public virtual void OnCreate(int sourceIndex, int targetIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnValidate(int sourceIndex, int targetIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnDestroyAfterConnectionRemoved(); // 0x00000001841E1670-0x00000001841E1680
		public override string ToString(); // 0x000000018A96B98C-0x000000018A96B9DC
	}

	[SpoofAOT]
	public abstract class ExposedParameter // TypeDefIndex: 52573
	{
		// Properties
		public abstract string targetVariableID { get; }
		public abstract System.Type type { get; }
		public abstract object valueBoxed { get; set; }
		public abstract Variable varRefBoxed { get; }
	
		// Constructors
		protected ExposedParameter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void Bind(IBlackboard blackboard);
		public abstract void UnBind();
		public static ExposedParameter CreateInstance(Variable target); // 0x000000018A96FB3C-0x000000018A96FC6C
	}

	public sealed class ExposedParameter<T> : ExposedParameter // TypeDefIndex: 52574
	{
		// Fields
		[SerializeField]
		private string _targetVariableID;
		[SerializeField]
		private T _value;
		[CompilerGenerated]
		private Variable<T> _varRef_k__BackingField;
	
		// Properties
		public Variable<T> varRef { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override string targetVariableID { get; }
		public override System.Type type { get; }
		public override object valueBoxed { get; set; }
		public override Variable varRefBoxed { get; }
		public T value { get; set; }
	
		// Constructors
		public ExposedParameter();
		public ExposedParameter(Variable target);
	
		// Methods
		public override void Bind(IBlackboard blackboard);
		public override void UnBind();
		private T GetRawValue();
		private void SetRawValue(T value);
	}

	[Serializable]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver, IStringCompressProcessor // TypeDefIndex: 52589
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
		[CompilerGenerated]
		private static Action<Graph> onGraphSerialized; // 0x00
		public static Action<Graph> onGraphDeserialized; // 0x08
		[CompilerGenerated]
		private bool _isDeserialized_k__BackingField; // 0x3A
		private static List<NodeCanvas.Framework.Node> s_nodeBuffer; // 0x10
		[CompilerGenerated]
		private bool _graphValidateDirty_k__BackingField; // 0x3B
		[CompilerGenerated]
		private Action<bool> onFinish; // 0x40
		private static List<Graph> _runningGraphs; // 0x18
		[CompilerGenerated]
		private bool _hasInitialized_k__BackingField; // 0x48
		[CompilerGenerated]
		private HierarchyTree.Element _flatMetaGraph_k__BackingField; // 0x50
		[CompilerGenerated]
		private HierarchyTree.Element _fullMetaGraph_k__BackingField; // 0x58
		[CompilerGenerated]
		private HierarchyTree.Element _nestedMetaGraph_k__BackingField; // 0x60
		[CompilerGenerated]
		private Graph _parentGraph_k__BackingField; // 0x68
		[CompilerGenerated]
		private float _elapsedTime_k__BackingField; // 0x70
		[CompilerGenerated]
		private float _deltaTime_k__BackingField; // 0x74
		[CompilerGenerated]
		private int _lastUpdateFrame_k__BackingField; // 0x78
		[CompilerGenerated]
		private bool _isRunning_k__BackingField; // 0x7C
		[CompilerGenerated]
		private bool _isPaused_k__BackingField; // 0x7D
		[CompilerGenerated]
		private UpdateMode _updateMode_k__BackingField; // 0x80
		[CompilerGenerated]
		private Component _agent_k__BackingField; // 0x88
		[CompilerGenerated]
		private IBlackboard _parentBlackboard_k__BackingField; // 0x90
		[CompilerGenerated]
		private Action delayedInitCalls; // 0x98
	
		// Properties
		public virtual bool allowRuntimeSerialization { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual bool dontSerializeBinderConnectionGenericType { get; } // 0x00000001812081B0-0x0000000181208610 
		public bool isDeserialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86660-0x0000000184D86670 0x0000000184D86690-0x0000000184D866A0
		public abstract bool canDelayDeserializeAndOptimizeClone { get; }
		public bool graphValidateDirty { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86D10-0x0000000184D86D20 0x0000000184D86D20-0x0000000184D86D30
		private bool hasInitialized { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		private HierarchyTree.Element flatMetaGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		private HierarchyTree.Element fullMetaGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		private HierarchyTree.Element nestedMetaGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public abstract System.Type baseNodeType { get; }
		public abstract bool requiresAgent { get; }
		public abstract bool requiresPrimeNode { get; }
		public abstract bool isTree { get; }
		public abstract bool allowBlackboardOverrides { get; }
		public abstract bool canAcceptVariableDrops { get; }
		private GraphSource graphSource { get; set; } // 0x000000018306F4B0-0x000000018306F4D0 0x0000000185396200-0x0000000185396210
		public string category { get; set; } // 0x000000018A974814-0x000000018A974834 0x000000018A974BC8-0x000000018A974BF8
		public string comments { get; set; } // 0x000000018A974834-0x000000018A974854 0x000000018A974BF8-0x000000018A974C28
		public Vector2 translation { get; set; } // 0x000000018A974930-0x000000018A974960 0x000000018A974D9C-0x000000018A974DD4
		public float zoomFactor { get; set; } // 0x000000018A974960-0x000000018A974980 0x000000018A974DD4-0x000000018A974E04
		public List<NodeCanvas.Framework.Node> allNodes { get; set; } // 0x000000018306F380-0x000000018306F3A0 0x000000018A974B68-0x000000018A974B98
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x000000018A9747F4-0x000000018A974814 0x000000018A974B98-0x000000018A974BC8
		private BlackboardSource localBlackboard { get; set; } // 0x000000018306F3A0-0x000000018306F3C0 0x000000018A974C28-0x000000018A974C58
		private List<BBParameter> allParameters { get; } // 0x000000018306F490-0x000000018306F4B0 
		public List<NodeCanvas.Framework.Task> allTasks { get; } // 0x000000018306F360-0x000000018306F380 
		public List<Connection> allConnections { get; } // 0x000000018A9747D4-0x000000018A9747F4 
		public Graph rootGraph { get; } // 0x000000018A974874-0x000000018A9748E0 
		public bool serializationHalted { get; } // 0x00000001811F2A70-0x00000001811F2A80 
		public static IEnumerable<Graph> runningGraphs { get; } // 0x000000018A9748E0-0x000000018A974930 
		public Graph parentGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public float elapsedTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90610-0x0000000184D90620 0x0000000184D90600-0x0000000184D90610
		public float deltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA60B0-0x0000000184DA60C0 0x0000000184DA60C0-0x0000000184DA60D0
		public int lastUpdateFrame { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863C0-0x0000000184D863D0 0x0000000184D86440-0x0000000184D86450
		public bool didUpdateLastFrame { get; } // 0x000000018A974854-0x000000018A974874 
		public bool isRunning { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D92E50-0x0000000184D92E60 0x0000000184D92E60-0x0000000184D92E70
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA26A0-0x0000000184DA26B0 0x0000000184DA26B0-0x0000000184DA26C0
		public UpdateMode updateMode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863A0-0x0000000184D863B0 0x0000000184D86420-0x0000000184D86430
		public NodeCanvas.Framework.Node primeNode { get; set; } // 0x000000018306D980-0x000000018306D9F0 0x000000018A974C58-0x000000018A974D9C
		public Component agent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public IBlackboard blackboard { get; } // 0x0000000185390F2C-0x0000000185390F40 
		public IBlackboard parentBlackboard { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x000000018464E630-0x000000018464E640 
	
		// Events
		public static event Action<Graph> onGraphSerialized {
			add; // 0x000000018A974710-0x000000018A9747D4
			remove; // 0x000000018A974AA4-0x000000018A974B68
		}
		public event Action<bool> onFinish {
			add; // 0x000000018A974684-0x000000018A974710
			remove; // 0x000000018A974A18-0x000000018A974AA4
		}
		private event Action delayedInitCalls {
			add; // 0x000000018A9745EC-0x000000018A974684
			remove; // 0x000000018A974980-0x000000018A974A18
		}
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 52575
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2,
			Manual = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52576
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<NodeCanvas.Framework.Node, int> __9__174_0; // 0x08
			public static Func<NodeCanvas.Framework.Node, bool> __9__218_0; // 0x10
			public static Func<NodeCanvas.Framework.Node, bool> __9__219_0; // 0x18
			public static Func<BBParameter, bool> __9__222_0; // 0x20
	
			// Constructors
			static __c(); // 0x000000018A98D1AC-0x000000018A98D210
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _UpdateNodeIDs_b__174_0(NodeCanvas.Framework.Node n); // 0x000000018A98CA98-0x000000018A98CB04
			internal bool _GetRootNodes_b__218_0(NodeCanvas.Framework.Node n); // 0x000000018A98CA50-0x000000018A98CA98
			internal bool _GetLeafNodes_b__219_0(NodeCanvas.Framework.Node n); // 0x000000018A98CA08-0x000000018A98CA50
			internal bool _GetDefinedParameters_b__222_0(BBParameter p); // 0x000000018A98C9F0-0x000000018A98CA08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass182_0 // TypeDefIndex: 52577
		{
			// Fields
			public Graph __4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public __c__DisplayClass182_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadOverwriteAsync_b__0(); // 0x000000018A98CC14-0x000000018A98CC58
		}
	
		[CompilerGenerated]
		private struct _LoadOverwriteAsync_d__182 : IAsyncStateMachine // TypeDefIndex: 52578
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Graph __4__this; // 0x28
			public GraphLoadData data; // 0x30
			public Action callback; // 0x60
			private TaskAwaiter __u__1; // 0x68
	
			// Methods
			private void MoveNext(); // 0x000000018A98C794-0x000000018A98C9F0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass183_0 // TypeDefIndex: 52579
		{
			// Fields
			public Graph __4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public __c__DisplayClass183_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadOverwrite_b__0(); // 0x000000018A98CC58-0x000000018A98CC90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass213_0 // TypeDefIndex: 52580
		{
			// Fields
			public int searchID; // 0x10
	
			// Constructors
			public __c__DisplayClass213_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetNodeWithID_b__0(NodeCanvas.Framework.Node n); // 0x000000018A98CCE8-0x000000018A98CD08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass215_0<T> // TypeDefIndex: 52581
			where T : NodeCanvas.Framework.Node
		{
			// Fields
			public string tagName;
	
			// Constructors
			public __c__DisplayClass215_0();
	
			// Methods
			internal bool _GetNodeWithTag_b__0(T n);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass216_0<T> // TypeDefIndex: 52582
			where T : NodeCanvas.Framework.Node
		{
			// Fields
			public string tagName;
	
			// Constructors
			public __c__DisplayClass216_0();
	
			// Methods
			internal bool _GetNodesWithTag_b__0(T n);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__217<T> // TypeDefIndex: 52583
			where T : NodeCanvas.Framework.Node
		{
			// Fields
			public static readonly __c__217<T> __9;
			public static Func<T, bool> __9__217_0;
	
			// Constructors
			static __c__217();
			public __c__217();
	
			// Methods
			internal bool _GetAllTagedNodes_b__217_0(T n);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass230_0 // TypeDefIndex: 52584
		{
			// Fields
			public Stack<HierarchyTree.Element> stack; // 0x10
			public HierarchyTree.Element parentElement; // 0x18
	
			// Constructors
			public __c__DisplayClass230_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CollectSubElements_b__0(object o); // 0x000000018A98CD08-0x000000018A98CE00
			internal void _CollectSubElements_b__1(object o, fsData d); // 0x000000018A98CE00-0x000000018A98CE80
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass233_0 // TypeDefIndex: 52585
		{
			// Fields
			public List<NodeCanvas.Framework.Task> result; // 0x10
	
			// Constructors
			public __c__DisplayClass233_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetTasksInElement_b__0(object o, fsData d); // 0x000000018A98CE80-0x000000018A98CF14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass234_0 // TypeDefIndex: 52586
		{
			// Fields
			public List<BBParameter> result; // 0x10
	
			// Constructors
			public __c__DisplayClass234_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetParametersInElement_b__0(object o, fsData d); // 0x000000018A98CF14-0x000000018A98CFA8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass239_0 // TypeDefIndex: 52587
		{
			// Fields
			public NodeCanvas.Framework.Node node; // 0x10
	
			// Constructors
			public __c__DisplayClass239_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveNode_b__0(NodeCanvas.Framework.Node n); // 0x000000018A98CFA8-0x000000018A98D028
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass242_0 // TypeDefIndex: 52588
		{
			// Fields
			public Graph targetGraph; // 0x10
	
			// Constructors
			public __c__DisplayClass242_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CloneNodes_b__0(NodeCanvas.Framework.Node n); // 0x000000018A98D028-0x000000018A98D088
		}
	
		// Constructors
		protected Graph(); // 0x0000000183CBE980-0x0000000183CBE9F0
		static Graph(); // 0x0000000184D12810-0x0000000184D128B0
	
		// Methods
		public virtual Rect DrawCustomBlackboardPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos); // 0x0000000184D94BD0-0x0000000184D94BE0
		public virtual Rect DrawCustomPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos); // 0x0000000184D94BD0-0x0000000184D94BE0
		public virtual Rect DrawCustomPanel2(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos); // 0x0000000184D94BD0-0x0000000184D94BE0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A974120-0x000000018A974134
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000183113CD0-0x0000000183113D40
		public void TryDeserializeIfNot(); // 0x000000018306F4D0-0x000000018306F4F0
		protected void OnEnable(); // 0x0000000184D1ABF0-0x0000000184D1AC10
		protected void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		protected void OnDestroy(); // 0x000000018A972A6C-0x000000018A972ABC
		protected void OnValidate(); // 0x00000001841E1670-0x00000001841E1680
		protected void Reset(); // 0x000000018A973704-0x000000018A973714
		public bool SelfSerialize(bool ignoreScene = false /* Metadata: 0x02331D2E */); // 0x000000018A9739EC-0x000000018A973B70
		protected virtual void OnAfterGraphSerialized(); // 0x00000001841E1670-0x00000001841E1680
		public bool SelfDeserialize(); // 0x000000018A97394C-0x000000018A9739EC
		public string Serialize(List<UnityEngine.Object> references); // 0x000000018A973F28-0x000000018A974044
		public bool Deserialize(string serializedGraph, List<UnityEngine.Object> references, bool validate); // 0x0000000183114AB0-0x0000000183114EC0
		public bool DeserializeSelf(List<UnityEngine.Object> references, bool validate); // 0x0000000183115400-0x0000000183115600
		public GraphSource GetGraphSource(); // 0x000000018A971F14-0x000000018A971F30
		public string GetSerializedJsonData(); // 0x000000018A9724E0-0x000000018A9724F8
		public int GetSerializedJsonDataStringIndex(); // 0x0000000183115350-0x00000001831153B0
		public bool DeserializeFromGraph(Graph other, bool validate = true /* Metadata: 0x02331D2F */); // 0x00000001831151C0-0x0000000183115300
		public DataCompressManager.StringCompressUnsafeString GetSerializedJsonDataUnsafeString(); // 0x000000018A972494-0x000000018A9724E0
		public void ClearSerializedJsonData(); // 0x0000000185390C40-0x0000000185390C54
		public List<UnityEngine.Object> GetSerializedReferencesData(); // 0x0000000183115300-0x0000000183115350
		public GraphSource GetGraphSourceMetaDataCopy(); // 0x000000018A971EA4-0x000000018A971F14
		public void SetGraphSourceMetaData(GraphSource source); // 0x000000018A974044-0x000000018A974074
		public string SerializeLocalBlackboard(ref List<UnityEngine.Object> references); // 0x000000018A973E4C-0x000000018A973F28
		public bool DeserializeLocalBlackboard(string json, List<UnityEngine.Object> references); // 0x000000018A971348-0x000000018A9713E0
		public static T Clone<T>(T graph, Graph parentGraph)
			where T : Graph;
		public void Validate(); // 0x0000000182FC1CC0-0x0000000182FC1D80
		public void UpdateReferencesFromOwner(GraphOwner owner, bool force = false /* Metadata: 0x02331D30 */); // 0x000000018A974550-0x000000018A9745EC
		public void UpdateReferences(Component newAgent, IBlackboard newParentBlackboard, bool force = false /* Metadata: 0x02331D31 */); // 0x000000018306C5A0-0x000000018306D980
		private void UpdateNodeBBFields(); // 0x000000018306F3C0-0x000000018306F490
		void ITaskSystem.UpdateTasksOwner(); // 0x000000018306F2C0-0x000000018306F360
		public void UpdateNodeIDs(bool alsoReorderList); // 0x000000018A9741C8-0x000000018A974550
		public virtual void OnGraphStructureChange(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterUpdateNodeIDs(); // 0x00000001841E1670-0x00000001841E1680
		private int AssignNodeID(NodeCanvas.Framework.Node node, int lastID, ref NodeCanvas.Framework.Node[] parsed); // 0x000000018A970594-0x000000018A9706AC
		protected void ThreadSafeInitCall(Action call); // 0x000000018A9740AC-0x000000018A974120
		public async void LoadOverwriteAsync(GraphLoadData data, Action callback); // 0x000000018A97280C-0x000000018A9728EC
		public void LoadOverwrite(GraphLoadData data); // 0x000000018A9728EC-0x000000018A972A6C
		public void Initialize(Component newAgent, IBlackboard newParentBlackboard, bool preInitializeSubGraphs); // 0x0000000183113660-0x00000001831136D0
		private void PreInitializeSubGraphs(); // 0x000000018A972C40-0x000000018A972F54
		public void StartGraph(Component newAgent, IBlackboard newParentBlackboard, UpdateMode newUpdateMode, Action<bool> callback = null); // 0x000000018306EDB0-0x000000018306F100
		public void ClearGraphData(); // 0x000000018306FD40-0x00000001830718B0
		public void Stop(bool success = true /* Metadata: 0x02331D32 */); // 0x000000018306F100-0x000000018306F2C0
		public void Pause(); // 0x000000018A972ABC-0x000000018A972C40
		public void Resume(); // 0x000000018A97376C-0x000000018A97394C
		public void Restart(); // 0x000000018A973714-0x000000018A97376C
		public void UpdateGraph(); // 0x000000018A974134-0x000000018A974158
		public void UpdateGraph(float deltaTime); // 0x000000018A974158-0x000000018A9741C8
		public virtual object OnDerivedDataSerialization(); // 0x00000001811EC580-0x00000001811EC590
		public virtual void OnDerivedDataDeserialization(object data); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphInitialize(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphStarted(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphStoped(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphPaused(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphUnpaused(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphObjectEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphObjectDisable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphObjectDestroy(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnGraphValidate(); // 0x00000001841E1670-0x00000001841E1680
		public void SendEvent(string name, object value, object sender); // 0x000000018A973B70-0x000000018A973C5C
		public void SendEvent<T>(string name, T value, object sender);
		public static void SendGlobalEvent(string name, object value, object sender); // 0x000000018A973C5C-0x000000018A973E4C
		public static void SendGlobalEvent<T>(string name, T value, object sender);
		public IEnumerable<BBParameter> GetAllParameters(); // 0x000000018A9718C8-0x000000018A9718D0
		public IEnumerable<Connection> GetAllConnections(); // 0x000000018A971568-0x000000018A971570
		public IEnumerable<T> GetAllTasksOfType<T>()
			where T : NodeCanvas.Framework.Task;
		public NodeCanvas.Framework.Node GetNodeWithID(int searchID); // 0x000000018A9720E4-0x000000018A9721DC
		public IEnumerable<T> GetAllNodesOfType<T>()
			where T : NodeCanvas.Framework.Node;
		public T GetNodeWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node;
		public IEnumerable<T> GetNodesWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node;
		public IEnumerable<T> GetAllTagedNodes<T>()
			where T : NodeCanvas.Framework.Node;
		public IEnumerable<NodeCanvas.Framework.Node> GetRootNodes(); // 0x000000018A972380-0x000000018A972494
		public IEnumerable<NodeCanvas.Framework.Node> GetLeafNodes(); // 0x000000018A971F30-0x000000018A972044
		public IEnumerable<T> GetAllNestedGraphs<T>(bool recursive)
			where T : Graph;
		public IEnumerable<Graph> GetAllInstancedNestedGraphs(); // 0x000000018A971570-0x000000018A9718C8
		public IEnumerable<BBParameter> GetDefinedParameters(); // 0x000000018A9718D0-0x000000018A9719E4
		public void PromoteMissingParametersToVariables(IBlackboard bb); // 0x000000018A972FB4-0x000000018A973108
		public static Graph GetElementGraph(object obj); // 0x000000018A9719E4-0x000000018A971BDC
		public HierarchyTree.Element GetFlatMetaGraph(); // 0x000000018A971BDC-0x000000018A971D04
		public HierarchyTree.Element GetFullMetaGraph(); // 0x000000018A971D04-0x000000018A971EA4
		public HierarchyTree.Element GetNestedMetaGraph(); // 0x000000018A972044-0x000000018A9720E4
		private static void DigNestedGraphs(Graph currentGraph, HierarchyTree.Element currentElement); // 0x000000018A9713E0-0x000000018A971568
		private static HierarchyTree.Element GetTreeNodeElement(NodeCanvas.Framework.Node node, bool recurse, ref int lastID); // 0x000000018A97269C-0x000000018A97280C
		private static HierarchyTree.Element CollectSubElements(IGraphElement obj); // 0x000000018A971130-0x000000018A9712CC
		public IGraphElement GetTaskParentElement(NodeCanvas.Framework.Task targetTask); // 0x000000018A9724F8-0x000000018A972568
		public IGraphElement GetParameterParentElement(BBParameter targetParameter); // 0x000000018A9721DC-0x000000018A97224C
		public static IEnumerable<NodeCanvas.Framework.Task> GetTasksInElement(IGraphElement target); // 0x000000018A972568-0x000000018A97269C
		public static IEnumerable<BBParameter> GetParametersInElement(IGraphElement target); // 0x000000018A97224C-0x000000018A972380
		public T AddNode<T>()
			where T : NodeCanvas.Framework.Node;
		public T AddNode<T>(Vector2 pos)
			where T : NodeCanvas.Framework.Node;
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType); // 0x000000018A97051C-0x000000018A970594
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType, Vector2 pos); // 0x000000018A970424-0x000000018A97051C
		public void RemoveNode(NodeCanvas.Framework.Node node, bool recordUndo = true /* Metadata: 0x02331D33 */, bool force = false /* Metadata: 0x02331D34 */); // 0x000000018A9732C0-0x000000018A973704
		public Connection ConnectNodes(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, int sourceIndex = -1 /* Metadata: 0x02331D35 */, int targetIndex = -1 /* Metadata: 0x02331D36 */); // 0x000000018A9712CC-0x000000018A971348
		public void RemoveConnection(Connection connection, bool recordUndo = true /* Metadata: 0x02331D37 */, bool invokeGraphChanged = true /* Metadata: 0x02331D38 */); // 0x000000018A973108-0x000000018A9732C0
		public static List<NodeCanvas.Framework.Node> CloneNodes(List<NodeCanvas.Framework.Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default); // 0x000000018A970838-0x000000018A971130
		public void ClearGraph(); // 0x000000018A970790-0x000000018A970838
		[Obsolete("Use \'Graph.StartGraph\' with the \'Graph.UpdateMode\' parameter.")]
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null); // 0x000000018A974074-0x000000018A9740AC
		public void ProcessStringCompress(StringCompressVisitor visitor); // 0x000000018A972F54-0x000000018A972FB4
		public bool CheckStringCompress(); // 0x000000018A9706AC-0x000000018A970790
	}

	public abstract class GraphOwner : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 52601
	{
		// Fields
		protected bool isLazyLoadTriggered; // 0x18
		private bool m_deserializeFinish; // 0x19
		[SerializeField]
		private SerializationPair[] _serializedExposedParameters; // 0x20
		[CompilerGenerated]
		private List<ExposedParameter> _exposedParameters_k__BackingField; // 0x28
		public static Action<GraphOwner> onOwnerBehaviourStateChange; // 0x00
		[CompilerGenerated]
		private Action onMonoBehaviourStart; // 0x30
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
		[CompilerGenerated]
		private bool _initialized_k__BackingField; // 0x70
		[CompilerGenerated]
		private bool _enableCalled_k__BackingField; // 0x71
		[CompilerGenerated]
		private bool _startCalled_k__BackingField; // 0x72
	
		// Properties
		public List<ExposedParameter> exposedParameters { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public abstract NodeCanvas.Framework.Graph graph { get; set; }
		public abstract IBlackboard blackboard { get; set; }
		public abstract System.Type graphType { get; }
		public bool initialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86A50-0x0000000184D86A60 0x0000000184D86A80-0x0000000184D86A90
		public bool enableCalled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89040-0x0000000184D89050 0x0000000184D89050-0x0000000184D89060
		public bool startCalled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018157A7C0-0x000000018157A7D0 0x000000018157A800-0x000000018157A810
		public GraphSource boundGraphSource { get; private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public string boundGraphSerialization { get; protected set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public List<UnityEngine.Object> boundGraphObjectReferences { get; private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public bool lockBoundGraphPrefabOverrides { get; set; } // 0x000000018A981C64-0x000000018A981C78 0x0000000184D86DB0-0x0000000184D86DC0
		public bool lockBoundGraphFromInstance { get; set; } // 0x0000000184DA5B40-0x0000000184DA5B50 0x0000000184DA5B80-0x0000000184DA5B90
		public bool preInitializeSubGraphs { get; set; } // 0x0000000184DA5B60-0x0000000184DA5B70 0x0000000184DA5BA0-0x0000000184DA5BB0
		public FirstActivation firstActivation { get; set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
		public EnableAction enableAction { get; set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
		public DisableAction disableAction { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public NodeCanvas.Framework.Graph.UpdateMode updateMode { get; set; } // 0x0000000184D86790-0x0000000184D867A0 0x0000000184D86D50-0x0000000184D86D60
		public bool graphIsBound { get; } // 0x0000000184B88270-0x0000000184B88290 
		public bool isRunning { get; } // 0x000000018306BA60-0x000000018306BB10 
		public bool isPaused { get; } // 0x000000018A981C00-0x000000018A981C64 
		public float elapsedTime { get; } // 0x000000018A981B7C-0x000000018A981C00 
		public virtual bool canEditNonPersistantBoundGraph { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Events
		public event Action onMonoBehaviourStart {
			add; // 0x000000018A981AE8-0x000000018A981B7C
			remove; // 0x000000018A981C78-0x000000018A981D0C
		}
	
		// Nested types
		public enum EnableAction // TypeDefIndex: 52590
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}
	
		public enum DisableAction // TypeDefIndex: 52591
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}
	
		public enum FirstActivation // TypeDefIndex: 52592
		{
			OnEnable = 0,
			OnStart = 1,
			Async = 2
		}
	
		public class SubInfo // TypeDefIndex: 52593
		{
			// Fields
			public NodeCanvas.Framework.Graph graph; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public NodeCanvas.Framework.Graph parentGraph; // 0x20
			public string name; // 0x28
			public IGraphAssignable assignable; // 0x30
			public bool isSuc; // 0x38
	
			// Constructors
			public SubInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0 // TypeDefIndex: 52594
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public Action callBack; // 0x18
			public Action __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass95_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _StartBehaviourAsync_b__0(NodeCanvas.Framework.Graph instance); // 0x0000000183073770-0x00000001830738B0
			internal void _StartBehaviourAsync_b__1(); // 0x000000018306AF00-0x000000018306AFE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0 // TypeDefIndex: 52595
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public bool isSuc; // 0x20
			public NodeCanvas.Framework.Graph clone; // 0x28
	
			// Constructors
			public __c__DisplayClass96_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetInstanceAsync_b__0(); // 0x00000001831136D0-0x0000000183113720
		}
	
		[CompilerGenerated]
		private struct _GetInstanceAsync_d__96 : IAsyncStateMachine // TypeDefIndex: 52596
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
			private void MoveNext(); // 0x0000000182FC3A70-0x0000000182FC4110
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0 // TypeDefIndex: 52597
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public List<SubInfo> subInfos; // 0x18
	
			// Constructors
			public __c__DisplayClass97_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CreateSubInstanceAsync_b__0(); // 0x0000000182FC1D80-0x0000000182FC1E80
		}
	
		[CompilerGenerated]
		private struct _CreateSubInstanceAsync_d__97 : IAsyncStateMachine // TypeDefIndex: 52598
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
			private void MoveNext(); // 0x0000000182FC1E80-0x0000000182FC3A30
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0<T> // TypeDefIndex: 52599
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal bool _GetExposedParameterValue_b__0(ExposedParameter x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_0<T> // TypeDefIndex: 52600
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass106_0();
	
			// Methods
			internal bool _SetExposedParameterValue_b__0(ExposedParameter x);
		}
	
		// Constructors
		protected GraphOwner(); // 0x0000000183CBD990-0x0000000183CBDA70
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A9818C0-0x000000018A981A64
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A98176C-0x000000018A9818C0
		protected virtual void OnBeforeSerializeDoExtra(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterDeserializeDoExtra(); // 0x00000001841E1670-0x00000001841E1680
		protected NodeCanvas.Framework.Graph GetInstance(NodeCanvas.Framework.Graph originalGraph); // 0x0000000184B30270-0x0000000184B30370
		public NodeCanvas.Framework.Graph MakeRuntimeGraphInstance(); // 0x000000018A9810D8-0x000000018A981124
		public void StartBehaviour(); // 0x0000000183074AD0-0x0000000183074AE0
		public void StartBehaviour(Action<bool> callback); // 0x000000018A981670-0x000000018A981680
		public void StartBehaviour(NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null); // 0x000000018306B330-0x000000018306B480
		public void PauseBehaviour(); // 0x000000018A981438-0x000000018A9814EC
		public void StartBehaviourAsync(Action callBack); // 0x000000018306ADD0-0x000000018306AEC0
		protected async void GetInstanceAsync(NodeCanvas.Framework.Graph originalGraph, Action<NodeCanvas.Framework.Graph> callBack); // 0x00000001830738B0-0x00000001830739A0
		public async void CreateSubInstanceAsync(Action callBack); // 0x00000001830739A0-0x0000000183073A70
		public void StopBehaviour(bool success = true /* Metadata: 0x02331D3D */); // 0x000000018306B770-0x000000018306B840
		public void UpdateBehaviour(); // 0x000000018A981A64-0x000000018A981AE8
		public void RestartBehaviour(); // 0x000000018A9814EC-0x000000018A981518
		public void SendEvent(string eventName); // 0x000000018A9815D0-0x000000018A981670
		public void SendEvent(string eventName, object value, object sender); // 0x000000018A981518-0x000000018A9815D0
		public void SendEvent<T>(string eventName, T eventValue, object sender);
		public T GetExposedParameterValue<T>(string name);
		public void SetExposedParameterValue<T>(string name, T value);
		public ExposedParameter MakeNewExposedParameter<T>(string name);
		protected virtual void Awake(); // 0x0000000184B88160-0x0000000184B88170
		public void Initialize(); // 0x0000000184B88170-0x0000000184B88270
		public void BindExposedParameters(); // 0x000000018A980F98-0x000000018A981088
		public void UnBindExposedParameters(); // 0x000000018A9816E8-0x000000018A98176C
		protected virtual void OnEnable(); // 0x0000000183074A80-0x0000000183074AD0
		protected virtual void Start(); // 0x0000000184D776E0-0x0000000184D77710
		private void InvokeStartEvent(); // 0x0000000184D77710-0x0000000184D77730
		protected virtual void OnDisable(); // 0x000000018A981404-0x000000018A981438
		public void DestroyInstance(); // 0x000000018A981088-0x000000018A9810D8
		protected virtual void OnDestroy(); // 0x000000018A981124-0x000000018A981404
		[CompilerGenerated]
		private void _Initialize_b__109_0(); // 0x000000018A981680-0x000000018A9816E8
	}

	public abstract class GraphOwner<T> : GraphOwner // TypeDefIndex: 52602
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
		protected GraphOwner();
	
		// Methods
		public void StartBehaviour(T newGraph);
		public void StartBehaviour(T newGraph, Action<bool> callback);
		public void StartBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null);
		public void SwitchBehaviour(T newGraph);
		public void SwitchBehaviour(T newGraph, Action<bool> callback);
		public void SwitchBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null);
	}

	public static class IGraphAssignableExtensions // TypeDefIndex: 52604
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 52603
		{
			// Fields
			public IGraphAssignable assignable; // 0x10
			public Action<bool> callback; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _TryStartSubGraph_b__0(bool result); // 0x000000018A98CC90-0x000000018A98CCE8
		}
	
		// Extension methods
		public static NodeCanvas.Framework.Graph CheckInstance(this IGraphAssignable assignable); // 0x000000018A9828E8-0x000000018A982AC0
		public static bool TryStartSubGraph(this IGraphAssignable assignable, Component agent, Action<bool> callback = null); // 0x000000018A982D9C-0x000000018A982F48
		public static bool TryStopSubGraph(this IGraphAssignable assignable); // 0x0000000182FC18F0-0x0000000182FC1980
		public static bool TryClearSubGraphData(this IGraphAssignable assignable); // 0x0000000182FC1980-0x0000000182FC1AB0
		public static bool TryPauseSubGraph(this IGraphAssignable assignable); // 0x000000018A982AC0-0x000000018A982B44
		public static bool TryResumeSubGraph(this IGraphAssignable assignable); // 0x000000018A982D18-0x000000018A982D9C
		public static bool TryUpdateSubGraph(this IGraphAssignable assignable); // 0x000000018A982F48-0x000000018A982FF8
		public static void TryWriteAndBindMappedVariables(this IGraphAssignable assignable); // 0x000000018A982FF8-0x000000018A983214
		public static void TryReadAndUnbindMappedVariables(this IGraphAssignable assignable); // 0x000000018A982B44-0x000000018A982D18
		public static void ValidateSubGraphAndParameters(this IGraphAssignable assignable); // 0x000000018A983214-0x000000018A98330C
	}

	public interface IGraphElement // TypeDefIndex: 52605
	{
		// Properties
		string name { get; }
		string UID { get; }
		NodeCanvas.Framework.Graph graph { get; }
		NodeCanvas.Framework.Status status { get; }
	}

	public interface IUpdatable : IGraphElement // TypeDefIndex: 52606
	{
		// Methods
		void Update();
	}

	public interface IInvokable : IGraphElement // TypeDefIndex: 52607
	{
		// Methods
		string GetInvocationID();
		object Invoke(params object[] args);
		void InvokeAsync(Action<object> callback, params object[] args);
	}

	public interface IGraphAssignable : IGraphElement // TypeDefIndex: 52608
	{
		// Properties
		NodeCanvas.Framework.Graph subGraph { get; set; }
		NodeCanvas.Framework.Graph currentInstance { get; set; }
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		BBParameter subGraphParameter { get; }
		List<BBMappingParameter> variablesMap { get; set; }
	}

	public interface IGraphAssignable<T> : IGraphAssignable // TypeDefIndex: 52609
		where T : NodeCanvas.Framework.Graph
	{
		// Properties
		T subGraph { get; set; }
		T currentInstance { get; set; }
	}

	public interface ITaskAssignable : IGraphElement // TypeDefIndex: 52610
	{
		// Properties
		NodeCanvas.Framework.Task task { get; set; }
	}

	public interface ITaskAssignable<T> : ITaskAssignable // TypeDefIndex: 52611
		where T : NodeCanvas.Framework.Task
	{
	}

	public interface IHaveNodeReference : IGraphElement // TypeDefIndex: 52612
	{
		// Properties
		INodeReference targetReference { get; }
	}

	public interface IReflectedWrapper // TypeDefIndex: 52613
	{
		// Methods
		ISerializedReflectedInfo GetSerializedInfo();
	}

	[Obsolete("This is no longer used nor required")]
	public interface ISubTasksContainer // TypeDefIndex: 52614
	{
		// Methods
		NodeCanvas.Framework.Task[] GetSubTasks();
	}

	[Obsolete("This is no longer used nor required")]
	public interface ISubParametersContainer // TypeDefIndex: 52615
	{
		// Methods
		BBParameter[] GetSubParameters();
	}

	[Serializable]
	[fsDeserializeOverwrite]
	[fsSerializeAsReference]
	[SpoofAOT]
	public abstract class Node : IGraphElement, ISerializationCollectable // TypeDefIndex: 52622
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
		[CompilerGenerated]
		private readonly bool _allowResizeHorizontal_k__BackingField; // 0x84
		[CompilerGenerated]
		private bool _canResizeHorizontal_k__BackingField; // 0x85
		[CompilerGenerated]
		private bool _resizingHorizontal_k__BackingField; // 0x86
		[CompilerGenerated]
		private bool _isHighlight_k__BackingField; // 0x87
		[NonSerialized]
		[HideInInspector]
		public float highlightColorFade; // 0x88
		[CompilerGenerated]
		private float _timeStarted_k__BackingField; // 0x8C
		[CompilerGenerated]
		private bool _isChecked_k__BackingField; // 0x90
		[CompilerGenerated]
		private bool _breakPointReached_k__BackingField; // 0x91
	
		// Properties
		protected virtual float? overrideNodeWidth { get; } // 0x00000001811EC580-0x00000001811EC590 
		public NodeCanvas.Framework.Graph graph { get; internal set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public int ID { get; internal set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
		public string UID { get; } // 0x000000018A984784-0x000000018A9847BC 
		public List<Connection> inConnections { get; protected set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public List<Connection> outConnections { get; protected set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public Vector2 position { get; set; } // 0x0000000184D9E6C0-0x0000000184D9E6E0 0x00000001811F36F0-0x00000001811F3700
		private string customName { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string tag { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string comments { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public string commentForShow { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public string rawComment { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public virtual bool modifyComment { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual string modifiedComment { get; } // 0x000000018A984974-0x000000018A9849AC 
		public virtual bool isBreakpoint { get; set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public virtual string name { get; set; } // 0x000000018A9849AC-0x000000018A984AA4 0x0000000185390F40-0x0000000185390F50
		public virtual string description { get; } // 0x000000018A9847BC-0x000000018A984864 
		public virtual int priority { get; } // 0x000000018A984B4C-0x000000018A984BE4 
		public abstract int maxInConnections { get; }
		public abstract int maxOutConnections { get; }
		public abstract System.Type outConnectionType { get; }
		public abstract bool allowAsPrime { get; }
		public abstract bool canSelfConnect { get; }
		public abstract Alignment2x2 commentsAlignment { get; }
		public abstract Alignment2x2 iconAlignment { get; }
		public virtual bool isBeyondGraph { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool drawInspector { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual bool inspectorShowTag { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual bool allowResizeHorizontal { [CompilerGenerated] get; } // 0x0000000182A80FA0-0x0000000182A80FB0 
		public bool canResizeHorizontal { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D89370-0x0000000184D89380 0x0000000184DA6840-0x0000000184DA6850
		public bool resizingHorizontal { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88E70-0x0000000184D88E80 0x0000000184DA6860-0x0000000184DA6870
		public virtual bool allowDragInContentRect { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual string nodeIconKey { get; } // 0x000000018A984B14-0x000000018A984B4C 
		public virtual string nodeIconKey2 { get; } // 0x000000018A984AA4-0x000000018A984ADC 
		public virtual string nodeIconKey3 { get; } // 0x000000018A984ADC-0x000000018A984B14 
		public virtual bool isHighlight { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA6830-0x0000000184DA6840 0x0000000184DA6850-0x0000000184DA6860
		public virtual bool drawNameTagOrComment { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public NodeCanvas.Framework.Status status { get; protected set; } // 0x0000000184D86CF0-0x0000000184D86D00 0x000000018A984BE4-0x000000018A984C14
		public Component graphAgent { get; } // 0x000000018A984894-0x000000018A984904 
		public IBlackboard graphBlackboard { get; } // 0x000000018A984904-0x000000018A984974 
		public float elapsedTime { get; } // 0x000000018A984864-0x000000018A984894 
		private float timeStarted { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8E210-0x0000000184D8E220 0x0000000184D8E230-0x0000000184D8E240
		private bool isChecked { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182EC6590-0x0000000182EC65A0 0x0000000182EC65A0-0x0000000182EC65B0
		private bool breakPointReached { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88160-0x0000000184D88170 0x0000000184D88180-0x0000000184D88190
	
		// Nested types
		[AttributeUsage(AttributeTargets.Field)]
		protected class AutoSortWithChildrenConnections : Attribute // TypeDefIndex: 52616
		{
			// Constructors
			public AutoSortWithChildrenConnections(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class _YieldBreak_d__137 : IEnumerator<object> // TypeDefIndex: 52617
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action resume; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _YieldBreak_d__137(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A98D210-0x000000018A98D294
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A98D294-0x000000018A98D2E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0 // TypeDefIndex: 52618
		{
			// Fields
			public Node b; // 0x10
			public Node a; // 0x18
	
			// Constructors
			public __c__DisplayClass147_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AreNodesConnected_b__0(Connection c); // 0x000000018A98CB8C-0x000000018A98CBAC
			internal bool _AreNodesConnected_b__1(Connection c); // 0x000000018A98CBAC-0x000000018A98CBCC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52619
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Connection, Node> __9__152_0; // 0x08
			public static Func<Connection, Node> __9__153_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018A98D148-0x000000018A98D1AC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Node _GetParentNodes_b__152_0(Connection c); // 0x0000000186C08920-0x0000000186C08938
			internal Node _GetChildNodes_b__153_0(Connection c); // 0x0000000186C08908-0x0000000186C08920
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass154_0 // TypeDefIndex: 52620
		{
			// Fields
			public Node parentNode; // 0x10
	
			// Constructors
			public __c__DisplayClass154_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _IsChildOf_b__0(Connection c); // 0x000000018A98CBF4-0x000000018A98CC14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass155_0 // TypeDefIndex: 52621
		{
			// Fields
			public Node childNode; // 0x10
	
			// Constructors
			public __c__DisplayClass155_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _IsParentOf_b__0(Connection c); // 0x000000018A98CB8C-0x000000018A98CBAC
		}
	
		// Constructors
		public Node(); // 0x00000001843DB830-0x00000001843DB8D0
	
		// Methods
		protected virtual string AllocateUID(); // 0x000000018A983494-0x000000018A9834C8
		public void SetUID(string value); // 0x0000000185392C40-0x0000000185392C50
		public static Node Create(NodeCanvas.Framework.Graph targetGraph, System.Type nodeType, Vector2 pos); // 0x000000018A983624-0x000000018A9837C0
		public Node Duplicate(NodeCanvas.Framework.Graph targetGraph); // 0x000000018A9837C0-0x000000018A983B0C
		public void Validate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A984628-0x000000018A984728
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard); // 0x000000018A983BC0-0x000000018A983C38
		public void Reset(bool recursively = true /* Metadata: 0x02331D46 */); // 0x000000018306EAF0-0x000000018306EB20
		[IteratorStateMachine(typeof(_YieldBreak_d__137))]
		private IEnumerator YieldBreak(Action resume); // 0x000000018A984728-0x000000018A984784
		public NodeCanvas.Framework.Status Error(object msg); // 0x000000018A983B0C-0x000000018A983BC0
		public NodeCanvas.Framework.Status Fail(string msg); // 0x000000018A983C38-0x000000018A983C50
		public void Warn(string msg); // 0x00000001841E1670-0x00000001841E1680
		public void SetStatus(NodeCanvas.Framework.Status status); // 0x000000018A958184-0x000000018A95818C
		protected void SendEvent(string eventName); // 0x000000018A984310-0x000000018A984340
		protected void SendEvent<T>(string eventName, T value);
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null); // 0x000000018A984178-0x000000018A984244
		protected virtual bool CanConnectToTarget(Node targetNode); // 0x0000000182FFF600-0x0000000182FFF610
		protected virtual bool CanConnectFromSource(Node sourceNode); // 0x0000000182FFF600-0x0000000182FFF610
		public static bool AreNodesConnected(Node a, Node b); // 0x000000018A9834C8-0x000000018A983624
		public Coroutine StartCoroutine(IEnumerator routine); // 0x000000018A984340-0x000000018A9843C0
		public void StopCoroutine(Coroutine routine); // 0x000000018A9843C0-0x000000018A98443C
		public void StartParallelTask(Action action); // 0x00000001841E1670-0x00000001841E1680
		public void StopParallelTask(Action action); // 0x00000001841E1670-0x00000001841E1680
		public IEnumerable<Node> GetParentNodes(); // 0x000000018A983EB4-0x000000018A983FFC
		public IEnumerable<Node> GetChildNodes(); // 0x000000018A983C50-0x000000018A983D98
		public bool IsChildOf(Node parentNode); // 0x000000018A9840AC-0x000000018A984178
		public bool IsParentOf(Node childNode); // 0x000000018A984244-0x000000018A984310
		internal virtual string GetWarningOrError(); // 0x000000018A983FFC-0x000000018A9840AC
		private string GetHardError(); // 0x000000018A983D98-0x000000018A983EB4
		protected virtual NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000184D86CF0-0x0000000184D86D00
		protected virtual void OnReset(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnCreate(NodeCanvas.Framework.Graph assignedGraph); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnDuplicate(NodeCanvas.Framework.Graph assignedGraph); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnParentConnected(int connectionIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnParentDisconnected(int connectionIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnChildConnected(int connectionIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnChildDisconnected(int connectionIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnChildrenConnectionsSorted(int[] oldIndeces); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphStarted(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnPostGraphStarted(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphStoped(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnPostGraphStoped(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphPaused(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphUnpaused(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnClearNodeData(); // 0x00000001841E1670-0x00000001841E1680
		public override string ToString(); // 0x000000018A98443C-0x000000018A984628
	}

	public interface INodeReference // TypeDefIndex: 52623
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
	public class NodeReference<T> : INodeReference // TypeDefIndex: 52625
		where T : NodeCanvas.Framework.Node
	{
		// Fields
		[SerializeField]
		private string _targetNodeUID;
		[NonSerialized]
		private WeakReference<T> _targetNodeRef;
	
		// Properties
		System.Type INodeReference.type { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 52624
		{
			// Fields
			public NodeReference<T> _this;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _Get_b__0(T x);
		}
	
		// Constructors
		public NodeReference();
		public NodeReference(T target);
	
		// Methods
		NodeCanvas.Framework.Node INodeReference.Get(NodeCanvas.Framework.Graph graph);
		void INodeReference.Set(NodeCanvas.Framework.Node target);
		public T Get(NodeCanvas.Framework.Graph graph);
		public void Set(T target);
	}

	public enum Status // TypeDefIndex: 52626
	{
		Failure = 0,
		Success = 1,
		Running = 2,
		Resting = 3,
		Error = 4,
		Optional = 5
	}

	[DoNotList]
	public class ActionList : ActionTask // TypeDefIndex: 52628
	{
		// Fields
		public ActionsExecutionMode executionMode; // 0x68
		public List<ActionTask> actions; // 0x70
		private int currentActionIndex; // 0x78
		private bool[] finishedIndeces; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A97D7E0-0x000000018A97D9B8 
	
		// Nested types
		public enum ActionsExecutionMode // TypeDefIndex: 52627
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}
	
		// Constructors
		public ActionList(); // 0x000000018A97D760-0x000000018A97D7E0
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018A97CFF0-0x000000018A97D1D0
		protected override string OnInit(); // 0x000000018A97D35C-0x000000018A97D3C8
		protected override void OnExecute(); // 0x000000018A97D2F4-0x000000018A97D35C
		protected override void OnUpdate(); // 0x000000018A97D510-0x000000018A97D760
		protected override void OnStop(); // 0x000000018A97D464-0x000000018A97D510
		protected override void OnPause(); // 0x000000018A97D3C8-0x000000018A97D464
		public override void OnDrawGizmosSelected(); // 0x000000018A97D254-0x000000018A97D2F4
		public void AddAction(ActionTask action); // 0x000000018A97CE08-0x000000018A97CFF0
		internal override string GetWarningOrError(); // 0x000000018A97D1D0-0x000000018A97D254
	}

	public abstract class ActionTask<T> : ActionTask // TypeDefIndex: 52629
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ActionTask();
	}

	public abstract class ActionTask : NodeCanvas.Framework.Task // TypeDefIndex: 52631
	{
		// Fields
		private NodeCanvas.Framework.Status status; // 0x58
		private float timeStarted; // 0x5C
		private bool latch; // 0x60
		[CompilerGenerated]
		private bool _isPaused_k__BackingField; // 0x61
	
		// Properties
		public float elapsedTime { get; } // 0x000000018A97DBFC-0x000000018A97DC30 
		public bool isRunning { get; } // 0x000000018A97DC30-0x000000018A97DC38 
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D892D0-0x0000000184D892E0 0x0000000184D8FF40-0x0000000184D8FF50
	
		// Nested types
		[CompilerGenerated]
		private sealed class _IndependentActionUpdater_d__12 : IEnumerator<object> // TypeDefIndex: 52630
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ActionTask __4__this; // 0x20
			public Component agent; // 0x28
			public IBlackboard blackboard; // 0x30
			public Action<NodeCanvas.Framework.Status> callback; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _IndependentActionUpdater_d__12(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A98C6CC-0x000000018A98C748
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A98C748-0x000000018A98C794
		}
	
		// Constructors
		protected ActionTask(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		public void ExecuteIndependent(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback); // 0x000000018A97DA2C-0x000000018A97DAAC
		[IteratorStateMachine(typeof(_IndependentActionUpdater_d__12))]
		private IEnumerator IndependentActionUpdater(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback); // 0x000000018A97DB3C-0x000000018A97DBE4
		[Obsolete("Use \'Execute\'")]
		public NodeCanvas.Framework.Status ExecuteAction(Component agent, IBlackboard blackboard); // 0x000000018A97DA24-0x000000018A97DA2C
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard); // 0x000000018A97DAAC-0x000000018A97DB3C
		public void EndAction(); // 0x000000018A954718-0x000000018A954724
		public void EndAction(bool success); // 0x000000018A97DA0C-0x000000018A97DA24
		public void EndAction(bool? success); // 0x000000018A97D9B8-0x000000018A97DA0C
		public void Pause(); // 0x000000018A97DBE4-0x000000018A97DBFC
		protected virtual void OnExecute(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnStop(bool interrupted); // 0x00000001833C4B40-0x00000001833C4B50
		protected virtual void OnStop(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnPause(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnResume(); // 0x00000001841E1670-0x00000001841E1680
	}

	[DoNotList]
	public class ConditionList : ConditionTask // TypeDefIndex: 52633
	{
		// Fields
		public ConditionsCheckMode checkMode; // 0x68
		public List<ConditionTask> conditions; // 0x70
	
		// Properties
		private bool allTrueRequired { get; } // 0x000000018A9801C8-0x000000018A9801D0 
		protected override string info { get; } // 0x000000018A9801D0-0x000000018A9803CC 
	
		// Nested types
		public enum ConditionsCheckMode // TypeDefIndex: 52632
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}
	
		// Constructors
		public ConditionList(); // 0x00000001847CF4E0-0x00000001847CF540
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018A97FCE8-0x000000018A97FEC8
		protected override void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnDisable(); // 0x000000018A9800AC-0x000000018A980128
		protected override bool OnCheck(); // 0x000000018A97FF4C-0x000000018A9800AC
		public override void OnDrawGizmosSelected(); // 0x000000018A980128-0x000000018A9801C8
		public void AddCondition(ConditionTask condition); // 0x000000018A97FB00-0x000000018A97FCE8
		internal override string GetWarningOrError(); // 0x000000018A97FEC8-0x000000018A97FF4C
	}

	public abstract class ConditionTask<T> : ConditionTask // TypeDefIndex: 52634
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ConditionTask();
	}

	public abstract class ConditionTask : NodeCanvas.Framework.Task // TypeDefIndex: 52636
	{
		// Fields
		[SerializeField]
		private bool _invert; // 0x58
		private int yieldReturn; // 0x5C
		private int yields; // 0x60
		private bool isRuntimeEnabled; // 0x64
	
		// Properties
		public bool invert { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Flip_d__13 : IEnumerator<object> // TypeDefIndex: 52635
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConditionTask __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Flip_d__13(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A98C3F0-0x000000018A98C450
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A98C450-0x000000018A98C49C
		}
	
		// Constructors
		protected ConditionTask(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		public void Enable(Component agent, IBlackboard bb); // 0x000000018A980494-0x000000018A9804CC
		public void Disable(); // 0x00000001843111A0-0x00000001843111C0
		[Obsolete("Use \'Check\'")]
		public bool CheckCondition(Component agent, IBlackboard blackboard); // 0x000000018A9803CC-0x000000018A9803D4
		public bool Check(Component agent, IBlackboard blackboard); // 0x000000018A980424-0x000000018A980494
		public bool CheckOnce(Component agent, IBlackboard blackboard); // 0x000000018A9803D4-0x000000018A980424
		protected void YieldReturn(bool value, bool keepValueUntilUsed = false /* Metadata: 0x02331D51 */); // 0x000000018A980528-0x000000018A980560
		[IteratorStateMachine(typeof(_Flip_d__13))]
		private IEnumerator Flip(); // 0x000000018A9804CC-0x000000018A980528
		protected virtual void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual bool OnCheck(); // 0x0000000182FFF600-0x0000000182FFF610
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("[EventReceiver] is no longer used. Please use the \'.router\' property to subscribe/unsubscribe to events (in OnExecute/OnStop for actions and OnEnable/OnDisable for conditions). For custom events, use \'.router.onCustomEvent\'.")]
	public class EventReceiverAttribute : Attribute // TypeDefIndex: 52637
	{
		// Fields
		public readonly string[] eventMessages; // 0x10
	
		// Constructors
		public EventReceiverAttribute(params string[] args); // 0x00000001853908C0-0x00000001853908D0
	}

	public interface ITaskSystem // TypeDefIndex: 52638
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
	public abstract class Task : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 52640
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
		public ITaskSystem ownerSystem { get; private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Component ownerSystemAgent { get; } // 0x000000018A98C070-0x000000018A98C0C4 
		public IBlackboard ownerSystemBlackboard { get; } // 0x000000018A98C0C4-0x000000018A98C0E4 
		public float ownerSystemElapsedTime { get; } // 0x000000018A98C0E4-0x000000018A98C104 
		public bool isUserEnabled { get; internal set; } // 0x000000018A98BEE0-0x000000018A98BEE8 0x000000018A98C3E8-0x000000018A98C3F0
		public string obsolete { get; } // 0x000000018A98BFC4-0x000000018A98C070 
		public string name { get; } // 0x000000018A98BEE8-0x000000018A98BFC4 
		public string description { get; } // 0x000000018A98BE34-0x000000018A98BEE0 
		public string summaryInfo { get; } // 0x000000018A98C1E4-0x000000018A98C33C 
		protected virtual string info { get; } // 0x0000000186BAE448-0x0000000186BAE450 
		public virtual System.Type agentType { get; } // 0x00000001811EC580-0x00000001811EC590 
		public string agentInfo { get; } // 0x000000018A98BD44-0x000000018A98BD90 
		public string agentParameterName { get; } // 0x000000018A98BD90-0x000000018A98BDA4 
		public bool agentIsOverride { get; set; } // 0x00000001867B9E50-0x00000001867B9E5C 0x000000018A98C33C-0x000000018A98C3E8
		public Component agent { get; } // 0x000000018A98BDA4-0x000000018A98BE2C 
		public IBlackboard blackboard { get; } // 0x000000018A98BE2C-0x000000018A98BE34 
		public EventRouter router { get; } // 0x000000018A98C104-0x000000018A98C1E4 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Field)]
		protected class GetFromAgentAttribute : Attribute // TypeDefIndex: 52639
		{
			// Constructors
			public GetFromAgentAttribute(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public Task(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A98BC84-0x000000018A98BD0C
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		public static T Create<T>(ITaskSystem newOwnerSystem)
			where T : Task;
		public static Task Create(System.Type type, ITaskSystem newOwnerSystem); // 0x000000018A98AFBC-0x000000018A98B0F0
		public virtual Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018A98B0F0-0x000000018A98B188
		public void Validate(ITaskSystem ownerSystem); // 0x000000018A98BD0C-0x000000018A98BD44
		public void SetOwnerSystem(ITaskSystem newOwnerSystem); // 0x0000000185390F40-0x0000000185390F50
		protected bool Set(Component newAgent, IBlackboard newBB); // 0x000000018A98BA90-0x000000018A98BB80
		private bool Initialize(Component newAgent); // 0x000000018A98B928-0x000000018A98BA28
		private bool InitializeFieldAttributes(Component newAgent); // 0x000000018A98B72C-0x000000018A98B928
		protected bool Error(string error, string tag = "Execution" /* Metadata: 0x02331D52 */); // 0x00000001812081B0-0x0000000181208610
		protected Coroutine StartCoroutine(IEnumerator routine); // 0x000000018A98BB80-0x000000018A98BC00
		protected void StopCoroutine(Coroutine routine); // 0x000000018A98BC00-0x000000018A98BC7C
		protected void SendEvent(string name); // 0x000000018A98BA38-0x000000018A98BA90
		protected void SendEvent<T>(string name, T value);
		internal virtual string GetWarningOrError(); // 0x000000018A98B2A4-0x000000018A98B72C
		protected virtual string OnErrorCheck(); // 0x00000001811EC580-0x00000001811EC590
		private string GetHardError(); // 0x000000018A98B188-0x000000018A98B2A4
		protected virtual string OnInit(); // 0x00000001811EC580-0x00000001811EC590
		public virtual void OnCreate(ITaskSystem ownerSystem); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnValidate(ITaskSystem ownerSystem); // 0x00000001841E1670-0x00000001841E1680
		[Obsolete("Use OnDrawGizmosSelected")]
		public virtual void OnDrawGizmos(); // 0x000000018A98BA28-0x000000018A98BA38
		public virtual void OnDrawGizmosSelected(); // 0x00000001841E1670-0x00000001841E1680
		public void ClearTaskData(); // 0x0000000185390F50-0x0000000185390F60
		protected virtual void OnClearTaskData(); // 0x00000001841E1670-0x00000001841E1680
		public override string ToString(); // 0x000000018A98BC7C-0x000000018A98BC84
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/CanvasCore/Blackboard Asset")]
	public class AssetBlackboard : ScriptableObject, ISerializationCallbackReceiver, IGlobalBlackboard // TypeDefIndex: 52641
	{
		// Fields
		[CompilerGenerated]
		private Action<Variable> onVariableAdded; // 0x18
		[CompilerGenerated]
		private Action<Variable> onVariableRemoved; // 0x20
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
		Dictionary<string, Variable> IBlackboard.variables { get; set; } // 0x000000018306FCE0-0x000000018306FD40 0x000000018A97DC4C-0x000000018A97DC70
		UnityEngine.Object IBlackboard.unityContextObject { get; } // 0x000000018464E630-0x000000018464E640 
		IBlackboard IBlackboard.parent { get; } // 0x00000001811EC580-0x00000001811EC590 
		Component IBlackboard.propertiesBindTarget { get; } // 0x00000001811EC580-0x00000001811EC590 
		string IBlackboard.independantVariablesFieldName { get; } // 0x00000001811EC580-0x00000001811EC590 
		public string identifier { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public string UID { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018A97DE04-0x000000018A97DE90
			remove; // 0x000000018A97DF1C-0x000000018A97DFA8
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018A97DE90-0x000000018A97DF1C
			remove; // 0x000000018A97DFA8-0x000000018A97E034
		}
	
		// Constructors
		public AssetBlackboard(); // 0x0000000183CBDE90-0x0000000183CBDF90
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A97DDFC-0x000000018A97DE04
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001849E1A90-0x00000001849E1AA0
		private void SelfSerialize(); // 0x000000018A97DC94-0x000000018A97DD9C
		private void SelfDeserialize(); // 0x00000001849E1AA0-0x00000001849E1B50
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x000000018306DA80-0x000000018306DAA0
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018A97DC38-0x000000018A97DC4C
		[ContextMenu("Show Json")]
		private void ShowJson(); // 0x000000018A97DD9C-0x000000018A97DDFC
		public override string ToString(); // 0x0000000184D85A60-0x0000000184D85A70
		private void OnValidate(); // 0x000000018A97DC70-0x000000018A97DC94
		private void OnEnable(); // 0x0000000183113D40-0x0000000183113DB0
	}

	[Serializable]
	[fsAutoInstance(true)]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class BBParameter : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 52643
	{
		// Fields
		[SerializeField]
		private string _name; // 0x10
		[SerializeField]
		private string _targetVariableID; // 0x18
		private IBlackboard _bb; // 0x20
		private Variable _varRef; // 0x28
		[CompilerGenerated]
		private Action<Variable> onVariableReferenceChanged; // 0x30
	
		// Properties
		public string targetVariableID { get; protected set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Variable varRef { get; protected set; } // 0x0000000184D86240-0x0000000184D86250 0x000000018306F630-0x000000018306F680
		public string name { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x000000018A97EBE0-0x000000018A97EC60
		public IBlackboard bb { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x000000018306F4F0-0x000000018306F540
		public bool useBlackboard { get; set; } // 0x000000018A77DD74-0x000000018A77DD80 0x000000018A97EC60-0x000000018A97ECEC
		public bool isPresumedDynamic { get; } // 0x000000018A97EA74-0x000000018A97EB1C 
		public bool isNone { get; } // 0x00000001844FE540-0x00000001844FE560 
		public bool isNull { get; } // 0x000000018A97EA50-0x000000018A97EA74 
		public bool isNoneOrNull { get; } // 0x000000018A97EA20-0x000000018A97EA50 
		public bool isDefined { get; } // 0x000000018A97EA08-0x000000018A97EA20 
		public System.Type refType { get; } // 0x000000018A97EB1C-0x000000018A97EB44 
		public object value { get; set; } // 0x000000018A97EB44-0x000000018A97EB54 0x000000018A97ECEC-0x000000018A97ED00
		public abstract System.Type varType { get; }
	
		// Events
		public event Action<Variable> onVariableReferenceChanged {
			add; // 0x000000018A97E97C-0x000000018A97EA08
			remove; // 0x000000018A97EB54-0x000000018A97EBE0
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 52642
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SetBBFields_b__0(object o, fsData d); // 0x000000018A98CB04-0x000000018A98CB8C
		}
	
		// Constructors
		public BBParameter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A97E964-0x000000018A97E97C
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		public static BBParameter CreateInstance(System.Type t, IBlackboard bb); // 0x000000018A97E364-0x000000018A97E49C
		public static void SetBBFields(object target, IBlackboard bb); // 0x000000018A97E5C4-0x000000018A97E6B4
		protected abstract void SetDefaultValue();
		protected abstract void Bind(Variable data);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		public void SetTargetVariable(IBlackboard targetBB, Variable targetVariable); // 0x000000018A97E6B4-0x000000018A97E7F8
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID); // 0x000000018306F540-0x000000018306F630
		public Variable PromoteToVariable(IBlackboard targetBB); // 0x000000018A97E49C-0x000000018A97E5C4
		public sealed override string ToString(); // 0x000000018A97E7F8-0x000000018A97E964
	}

	[Serializable]
	public class BBParameter<T> : BBParameter // TypeDefIndex: 52647
	{
		// Fields
		[SerializeField]
		protected T _value;
		[CompilerGenerated]
		private Func<T> getter;
		[CompilerGenerated]
		private Action<T> setter;
	
		// Properties
		public new T value { get; set; }
		public override System.Type varType { get; }
	
		// Events
		private event Func<T> getter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		private event Action<T> setter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 52644
		{
			// Fields
			public Func<object> convertFunc;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal T _BindGetter_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 52645
		{
			// Fields
			public Action<object> convertFunc;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _BindSetter_b__0(T value);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52646
		{
			// Fields
			public static readonly __c<T> __9;
			public static Action<T> __9__21_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _BindSetter_b__21_1(T value);
		}
	
		// Constructors
		public BBParameter();
		public BBParameter(T value);
	
		// Methods
		public override object GetValueBoxed();
		public override void SetValueBoxed(object newValue);
		public T GetValue();
		public void SetValue(T value);
		protected override void SetDefaultValue();
		protected override void Bind(Variable variable);
		private bool BindGetter(Variable variable);
		private bool BindSetter(Variable variable);
		public static implicit operator BBParameter<T>(T value);
	}

	[SpoofAOT]
	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard // TypeDefIndex: 52648
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
		[CompilerGenerated]
		private Action<Variable> onVariableAdded; // 0x50
		[CompilerGenerated]
		private Action<Variable> onVariableRemoved; // 0x58
	
		// Properties
		public BlackboardSource blackboard { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public AssetBlackboard parentBlackboard { get; } // 0x000000018385B100-0x000000018385B110 
		string IBlackboard.identifier { get; } // 0x0000000184D86200-0x0000000184D86210 
		Dictionary<string, Variable> IBlackboard.variables { get; set; } // 0x000000018A97F198-0x000000018A97F1B4 0x000000018A97F1B4-0x000000018A97F1D8
		Component IBlackboard.propertiesBindTarget { get; } // 0x000000018464E630-0x000000018464E640 
		UnityEngine.Object IBlackboard.unityContextObject { get; } // 0x000000018464E630-0x000000018464E640 
		IBlackboard IBlackboard.parent { get; } // 0x000000018385B100-0x000000018385B110 
		string IBlackboard.independantVariablesFieldName { get; } // 0x000000018A97F16C-0x000000018A97F198 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018A97F8D0-0x000000018A97F95C
			remove; // 0x000000018A97F9E8-0x000000018A97FA74
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018A97F95C-0x000000018A97F9E8
			remove; // 0x000000018A97FA74-0x000000018A97FB00
		}
	
		// Constructors
		public Blackboard(); // 0x000000018A97F860-0x000000018A97F8D0
	
		// Methods
		public void SetParentBlackboard(AssetBlackboard bb); // 0x0000000185392C40-0x0000000185392C50
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A97F858-0x000000018A97F860
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A97F850-0x000000018A97F858
		public void SelfSerialize(); // 0x000000018A97F434-0x000000018A97F730
		public void SelfDeserialize(); // 0x000000018A97F278-0x000000018A97F434
		public string Serialize(List<UnityEngine.Object> references, bool pretyJson = false /* Metadata: 0x02331D5C */); // 0x000000018A97F730-0x000000018A97F7E8
		public bool Deserialize(string json, List<UnityEngine.Object> references, bool removeMissingVariables = true /* Metadata: 0x02331D5D */); // 0x000000018A97EFC4-0x000000018A97F070
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x000000018A97F144-0x000000018A97F158
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018A97F158-0x000000018A97F16C
		protected virtual void Awake(); // 0x000000018A97EF74-0x000000018A97EFC4
		public Variable AddVariable(string name, System.Type type); // 0x000000018A97EF6C-0x000000018A97EF74
		public Variable AddVariable(string name, object value); // 0x000000018A97EF64-0x000000018A97EF6C
		public Variable RemoveVariable(string name); // 0x000000018A97F210-0x000000018A97F218
		public Variable GetVariable(string name, System.Type ofType = null); // 0x000000018A97F078-0x000000018A97F080
		public Variable GetVariableByID(string ID); // 0x000000018A97F070-0x000000018A97F078
		public Variable<T> GetVariable<T>(string name);
		public T GetVariableValue<T>(string name);
		public Variable SetVariableValue(string name, object value); // 0x000000018A97F7E8-0x000000018A97F7F0
		[Obsolete("Use GetVariableValue")]
		public T GetValue<T>(string name);
		[Obsolete("Use SetVariableValue")]
		public Variable SetValue(string name, object value); // 0x000000018A97F7E8-0x000000018A97F7F0
		[ContextMenu("Show Json")]
		private void ShowJson(); // 0x000000018A97F7F0-0x000000018A97F850
		public string Save(); // 0x000000018A97F254-0x000000018A97F278
		public string Save(string saveKey); // 0x000000018A97F218-0x000000018A97F254
		public bool Load(); // 0x000000018A97F120-0x000000018A97F144
		public bool Load(string saveKey); // 0x000000018A97F080-0x000000018A97F120
		protected virtual void OnValidate(); // 0x000000018A97F1D8-0x000000018A97F210
		public override string ToString(); // 0x0000000184D86200-0x0000000184D86210
	}

	[ExecuteInEditMode]
	public class GlobalBlackboard : NodeCanvas.Framework.Blackboard, IGlobalBlackboard // TypeDefIndex: 52651
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
		public string identifier { get; } // 0x0000000184D86230-0x0000000184D86240 
		public string UID { get; } // 0x0000000184D86280-0x0000000184D86290 
		public new string name { get; } // 0x0000000184D86230-0x0000000184D86240 
	
		// Nested types
		public enum SingletonMode // TypeDefIndex: 52649
		{
			DestroyComponentOnly = 0,
			DestroyEntireGameObject = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 52650
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Find_b__0(GlobalBlackboard b); // 0x000000018A98CBCC-0x000000018A98CBF4
		}
	
		// Constructors
		public GlobalBlackboard(); // 0x000000018A980F44-0x000000018A980F98
		static GlobalBlackboard(); // 0x000000018A980EB8-0x000000018A980F44
	
		// Methods
		public static IEnumerable<GlobalBlackboard> GetAll(); // 0x000000018A980AB4-0x000000018A980B04
		public static GlobalBlackboard Create(); // 0x000000018A980918-0x000000018A9809C0
		public static GlobalBlackboard Find(string name); // 0x000000018A9809C0-0x000000018A980AB4
		protected void OnEnable(); // 0x000000018A980B74-0x000000018A980D48
		protected void OnDisable(); // 0x000000018A980B04-0x000000018A980B74
		protected override void OnValidate(); // 0x000000018A980D48-0x000000018A980EB8
		public override string ToString(); // 0x0000000184D86230-0x0000000184D86240
		private bool IsPrefabAsset(); // 0x00000001812081B0-0x0000000181208610
	}

	public interface IBlackboard // TypeDefIndex: 52652
	{
		// Properties
		string identifier { get; }
		IBlackboard parent { get; }
		Dictionary<string, Variable> variables { get; set; }
		Component propertiesBindTarget { get; }
		UnityEngine.Object unityContextObject { get; }
		string independantVariablesFieldName { get; }
	
		// Events
		event Action<Variable> onVariableAdded {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event Action<Variable> onVariableRemoved {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void TryInvokeOnVariableAdded(Variable variable);
		void TryInvokeOnVariableRemoved(Variable variable);
	}

	public interface IGlobalBlackboard : IBlackboard // TypeDefIndex: 52653
	{
		// Properties
		string UID { get; }
	}

	[SpoofAOT]
	public static class IBlackboardExtensions // TypeDefIndex: 52656
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _GetAllParents_d__1 : IEnumerable<IBlackboard>, IEnumerator<IBlackboard> // TypeDefIndex: 52654
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
			IBlackboard IEnumerator<NodeCanvas.Framework.IBlackboard>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllParents_d__1(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A98C49C-0x000000018A98C540
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A98C5E4-0x000000018A98C630
			[DebuggerHidden]
			IEnumerator<IBlackboard> IEnumerable<IBlackboard>.GetEnumerator(); // 0x000000018A98C540-0x000000018A98C5DC
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018A98C5DC-0x000000018A98C5E4
		}
	
		[CompilerGenerated]
		private sealed class _GetVariables_d__14 : IEnumerable<Variable>, IEnumerator<Variable> // TypeDefIndex: 52655
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
			Variable IEnumerator<NodeCanvas.Framework.Variable>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetVariables_d__14(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184CC4380-0x0000000184CC4430
			private bool MoveNext(); // 0x000000018306E380-0x000000018306E9D0
			private void __m__Finally1(); // 0x000000018A98C684-0x000000018A98C6CC
			private void __m__Finally2(); // 0x0000000184CD8F80-0x0000000184CD8FC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A98C638-0x000000018A98C684
			[DebuggerHidden]
			IEnumerator<Variable> IEnumerable<Variable>.GetEnumerator(); // 0x0000000183A112D0-0x0000000183A11360
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018A98C630-0x000000018A98C638
		}
	
		// Extension methods
		public static IBlackboard GetRoot(this IBlackboard blackboard); // 0x000000018A9821F8-0x000000018A982238
		[IteratorStateMachine(typeof(_GetAllParents_d__1))]
		public static IEnumerable<IBlackboard> GetAllParents(this IBlackboard blackboard, bool includeSelf); // 0x000000018A982178-0x000000018A9821F8
		public static bool IsPartOf(this IBlackboard blackboard, IBlackboard child); // 0x000000018A982238-0x000000018A982278
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName, T value);
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName);
		public static Variable AddVariable(this IBlackboard blackboard, string varName, object value); // 0x000000018306E310-0x000000018306E380
		public static Variable AddVariable(this IBlackboard blackboard, string varName, System.Type type); // 0x000000018306E9F0-0x000000018306EAF0
		public static Variable RemoveVariable(this IBlackboard blackboard, string varName); // 0x000000018A9826A4-0x000000018A9827D0
		public static T GetVariableValue<T>(this IBlackboard blackboard, string varName);
		public static Variable SetVariableValue(this IBlackboard blackboard, string varName, object value); // 0x000000018A9827D0-0x000000018A9828E8
		public static void InitializePropertiesBinding(this IBlackboard blackboard, Component target, bool callSetter); // 0x0000000183114EC0-0x00000001831150C0
		public static Variable<T> GetVariable<T>(this IBlackboard blackboard, string varName);
		public static Variable GetVariable(this IBlackboard blackboard, string varName, System.Type ofType = null); // 0x000000018306F680-0x000000018306F7D0
		public static Variable GetVariableByID(this IBlackboard blackboard, string ID); // 0x000000018306F7D0-0x000000018306FC40
		[IteratorStateMachine(typeof(_GetVariables_d__14))]
		public static IEnumerable<Variable> GetVariables(this IBlackboard blackboard, System.Type ofType = null); // 0x000000018306C510-0x000000018306C5A0
		public static Variable ChangeVariableType(this IBlackboard blackboard, Variable target, System.Type newType); // 0x000000018A981F9C-0x000000018A982178
		public static void OverwriteFrom(this IBlackboard blackboard, IBlackboard sourceBlackboard, bool removeMissingVariables = true /* Metadata: 0x02331D60 */); // 0x000000018A982278-0x000000018A9826A4
	}

	public static class BlackboardHelpers // TypeDefIndex: 52658
	{
		// Fields
		private static readonly ConcurrentDictionary<System.Type, System.Type> s_variableTypeCache; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52657
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, System.Type> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D4D170-0x0000000184D4D1D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal System.Type _CreateVariableType_b__1_0(System.Type t); // 0x00000001849AF370-0x00000001849AF470
		}
	
		// Constructors
		static BlackboardHelpers(); // 0x00000001839D9230-0x00000001839D92C0
	
		// Methods
		public static System.Type CreateVariableType(System.Type valueType); // 0x000000018306DAA0-0x000000018306DBD0
	}

	[Serializable]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class Variable // TypeDefIndex: 52661
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
		[CompilerGenerated]
		private Action<string> onNameChanged; // 0x28
		[CompilerGenerated]
		private Action<object> onValueChanged; // 0x30
		[CompilerGenerated]
		private Action onDestroy; // 0x38
	
		// Properties
		public string name { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x000000018306D9F0-0x000000018306DA80
		public string ID { get; } // 0x000000018306FC40-0x000000018306FCE0 
		public object value { get; set; } // 0x0000000185390F1C-0x0000000185390F2C 0x0000000185390F08-0x0000000185390F1C
		public bool isExposedPublic { get; set; } // 0x000000018A98D5D8-0x000000018A98D5F4 0x0000000184D866D0-0x0000000184D866E0
		public bool debugBoundValue { get; set; } // 0x0000000184D86850-0x0000000184D86860 0x0000000184D86860-0x0000000184D86870
		public bool isPropertyBound { get; } // 0x0000000183115190-0x00000001831151C0 
		public abstract bool isDataBound { get; }
		public abstract System.Type varType { get; }
		public abstract string propertyPath { get; set; }
	
		// Events
		public event Action<string> onNameChanged {
			add; // 0x000000018A98D4C0-0x000000018A98D54C
			remove; // 0x000000018A98D688-0x000000018A98D714
		}
		public event Action<object> onValueChanged {
			add; // 0x000000018A98D54C-0x000000018A98D5D8
			remove; // 0x000000018A98D714-0x000000018A98D7A0
		}
		public event Action onDestroy {
			add; // 0x000000018A98D42C-0x000000018A98D4C0
			remove; // 0x000000018A98D5F4-0x000000018A98D688
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 52659
		{
			// Fields
			public Variable __4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _GetGetConverter_b__0(); // 0x000000018A98D088-0x000000018A98D0AC
			internal object _GetGetConverter_b__1(); // 0x000000018A98D0AC-0x000000018A98D0E8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 52660
		{
			// Fields
			public Variable __4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetSetConverter_b__0(object x); // 0x000000018A98D0E8-0x000000018A98D10C
			internal void _GetSetConverter_b__1(object x); // 0x000000018A98D10C-0x000000018A98D148
		}
	
		// Constructors
		public Variable(); // 0x0000000183CBE700-0x0000000183CBE7A0
		public Variable(string name, string ID); // 0x00000001832AF420-0x00000001832AF450
	
		// Methods
		public abstract void BindProperty(MemberInfo prop, GameObject target = null);
		public abstract void UnBind();
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x02331D61 */);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		public abstract void ResetDefaultValue();
		public abstract void RecordDefaultValue();
		internal void OnDestroy(); // 0x000000018A98D404-0x000000018A98D418
		public Variable Duplicate(IBlackboard targetBB); // 0x000000018A98D2F8-0x000000018A98D404
		protected bool HasValueChangeEvent(); // 0x0000000184486EE0-0x0000000184486EF0
		protected void TryInvokeValueChangeEvent(object value); // 0x000000018A98D418-0x000000018A98D42C
		public bool CanConvertTo(System.Type toType); // 0x000000018306E9D0-0x000000018306E9F0
		public Func<object> GetGetConverter(System.Type toType); // 0x00000001835CD980-0x00000001835CDAA0
		public bool CanConvertFrom(System.Type fromType); // 0x000000018A98D2E0-0x000000018A98D2F8
		public Action<object> GetSetConverter(System.Type fromType); // 0x000000018321C5F0-0x000000018321C710
		public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
	}

	public class Variable<T> : Variable // TypeDefIndex: 52666
	{
		// Fields
		[SerializeField]
		private T _value;
		[SerializeField]
		private string _propertyPath;
		[CompilerGenerated]
		private Func<T> getter;
		[CompilerGenerated]
		private Action<T> setter;
		private T m_originalValue;
		private bool m_hasOriginalValue;
	
		// Properties
		public override System.Type varType { get; }
		public override bool isDataBound { get; }
		public override string propertyPath { get; set; }
		public new T value { get; set; }
	
		// Events
		private event Func<T> getter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		private event Action<T> setter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 52662
		{
			// Fields
			public System.Reflection.FieldInfo field;
			public Component instance;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal T _InitializePropertyBinding_b__0();
			internal void _InitializePropertyBinding_b__1(T o);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_1 // TypeDefIndex: 52663
		{
			// Fields
			public T value;
	
			// Constructors
			public __c__DisplayClass31_1();
	
			// Methods
			internal T _InitializePropertyBinding_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_2 // TypeDefIndex: 52664
		{
			// Fields
			public MethodInfo getMethod;
			public Component instance;
			public MethodInfo setMethod;
	
			// Constructors
			public __c__DisplayClass31_2();
	
			// Methods
			internal T _InitializePropertyBinding_b__3();
			internal void _InitializePropertyBinding_b__5(T o);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52665
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<T> __9__31_4;
			public static Action<T> __9__31_6;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _InitializePropertyBinding_b__31_4();
			internal void _InitializePropertyBinding_b__31_6(T o);
		}
	
		// Constructors
		public Variable();
		public Variable(string name, string ID);
	
		// Methods
		public override object GetValueBoxed();
		public override void SetValueBoxed(object newValue);
		public T GetValue();
		public void SetValue(T newValue);
		public override void ResetDefaultValue();
		public override void RecordDefaultValue();
		public override void BindProperty(MemberInfo prop, GameObject target = null);
		public void BindGetSet(Func<T> _get, Action<T> _set);
		public override void UnBind();
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x02331D62 */);
	}

	public class VariableSeperator // TypeDefIndex: 52667
	{
		// Fields
		[CompilerGenerated]
		private bool _isEditingName_k__BackingField; // 0x10
	
		// Properties
		public bool isEditingName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public VariableSeperator(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace NodeCanvas.Framework.Internal
{
	public struct GraphLoadData // TypeDefIndex: 52668
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
	public class GraphSource : ISerializationCollector // TypeDefIndex: 52669
	{
		// Fields
		private List<NodeCanvas.Framework.Task> m_allTasks; // 0x10
		public List<BBParameter> m_allParameters; // 0x18
		public const float FRAMEWORK_VERSION = 3.25f; // Metadata: 0x02331D63
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
		public List<NodeCanvas.Framework.Task> allTasks { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public List<BBParameter> allParameters { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float version { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public string category { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string comments { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public Vector2 translation { get; set; } // 0x0000000184DA6810-0x0000000184DA6830 0x0000000184D865B0-0x0000000184D865C0
		public float zoomFactor { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public string type { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public List<NodeCanvas.Framework.Node> nodes { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public List<Connection> connections { get; private set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public BlackboardSource localBlackboard { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public object derivedData { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
	
		// Constructors
		public GraphSource(); // 0x0000000183CBE9F0-0x0000000183CBEB90
	
		// Methods
		void ISerializationCollector.OnPush(ISerializationCollector parent); // 0x0000000183CBDA80-0x0000000183CBDB50
		void ISerializationCollector.OnCollect(ISerializationCollectable child, int depth); // 0x000000018360FBE0-0x000000018360FCA0
		void ISerializationCollector.OnPop(ISerializationCollector parent); // 0x00000001841E1670-0x00000001841E1680
		public GraphSource Pack(NodeCanvas.Framework.Graph graph); // 0x000000018A981D0C-0x000000018A981EEC
		public GraphSource Unpack(NodeCanvas.Framework.Graph graph); // 0x000000018306EB20-0x000000018306EDB0
		public GraphSource SetMetaData(GraphSource source); // 0x000000018A981F34-0x000000018A981F9C
		public void PurgeRedundantReferences(); // 0x000000018A981EEC-0x000000018A981F34
	}

	[Description("Please resolve the MissingConnection issue by either replacing the connection, importing the missing connection type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public sealed class MissingConnection : Connection, IMissingRecoverable // TypeDefIndex: 52670
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x30
		[SerializeField]
		private string _recoveryState; // 0x38
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
	
		// Constructors
		public MissingConnection(); // 0x0000000184D92320-0x0000000184D92330
	}

	[Description("Please resolve the MissingNode issue by either replacing the node, importing the missing node type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public sealed class MissingNode : NodeCanvas.Framework.Node, IMissingRecoverable // TypeDefIndex: 52671
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x98
		[SerializeField]
		private string _recoveryState; // 0xA0
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public override string name { get; } // 0x000000018A98340C-0x000000018A983460 
		public override System.Type outConnectionType { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool canSelfConnect { get; } // 0x00000001812081B0-0x0000000181208610 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override Alignment2x2 iconAlignment { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public MissingNode(); // 0x000000018489BC70-0x000000018489BC80
	}

	[Serializable]
	public class ReflectedAction : ReflectedActionWrapper // TypeDefIndex: 52672
	{
		// Fields
		private ActionCall call; // 0x18
	
		// Constructors
		public ReflectedAction(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override BBParameter[] GetVariables(); // 0x000000018A98543C-0x000000018A985470
		public override void Init(object instance); // 0x000000018A985470-0x000000018A9854F4
		public override void Call(); // 0x000000018A985418-0x000000018A98543C
	}

	[Serializable]
	[SpoofAOT]
	public class ReflectedAction<T1> : ReflectedActionWrapper // TypeDefIndex: 52673
	{
		// Fields
		private ActionCall<T1> call;
		public BBParameter<T1> p1;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}

	[Serializable]
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper // TypeDefIndex: 52674
	{
		// Fields
		private ActionCall<T1, T2> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper // TypeDefIndex: 52675
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper // TypeDefIndex: 52676
	{
		// Fields
		private ActionCall<T1, T2, T3, T4> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper // TypeDefIndex: 52677
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		public BBParameter<T5> p5;
	
		// Constructors
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}

	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper // TypeDefIndex: 52678
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
		public ReflectedAction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override void Call();
	}

	[Serializable]
	[SpoofAOT]
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper // TypeDefIndex: 52679
	{
		// Fields
		private FunctionCall<TResult> call;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper // TypeDefIndex: 52680
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		public BBParameter<T1> p1;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper // TypeDefIndex: 52681
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper // TypeDefIndex: 52682
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		[BlackboardOnly]
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper // TypeDefIndex: 52683
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
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper // TypeDefIndex: 52684
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
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper // TypeDefIndex: 52685
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
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}

	public abstract class ReflectedWrapper : IReflectedWrapper // TypeDefIndex: 52686
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo _targetMethod; // 0x10
	
		// Constructors
		public ReflectedWrapper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018A9858EC-0x000000018A985994
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public void SetVariablesBB(IBlackboard bb); // 0x000000018A9859B8-0x000000018A985A1C
		public SerializedMethodInfo GetSerializedMethod(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public MethodInfo GetMethod(); // 0x000000018A985994-0x000000018A9859A4
		public bool HasChanged(); // 0x000000018A9859A4-0x000000018A9859B8
		public string AsString(); // 0x000000018A9858CC-0x000000018A9858EC
		public override string ToString(); // 0x000000018A985A1C-0x000000018A985A24
		public abstract BBParameter[] GetVariables();
		public abstract void Init(object instance);
	}

	public abstract class ReflectedActionWrapper : ReflectedWrapper // TypeDefIndex: 52687
	{
		// Constructors
		protected ReflectedActionWrapper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static new ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018A985078-0x000000018A985418
		public abstract void Call();
	}

	public abstract class ReflectedFunctionWrapper : ReflectedWrapper // TypeDefIndex: 52688
	{
		// Constructors
		protected ReflectedFunctionWrapper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static new ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018A9854F4-0x000000018A9858CC
		public abstract object Call();
	}

	[Description("Please resolve the MissingAction issue by either replacing the action, importing the missing action type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public class MissingAction : ActionTask, IMissingRecoverable // TypeDefIndex: 52689
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x68
		[SerializeField]
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		protected override string info { get; } // 0x000000018A98330C-0x000000018A983378 
	
		// Constructors
		public MissingAction(); // 0x0000000184D8E030-0x0000000184D8E040
	}

	[Description("Please resolve the MissingCondition issue by either replacing the condition, importing the missing condition type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public class MissingCondition : ConditionTask, IMissingRecoverable // TypeDefIndex: 52690
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x68
		[SerializeField]
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		protected override string info { get; } // 0x000000018A9833A0-0x000000018A98340C 
	
		// Constructors
		public MissingCondition(); // 0x0000000184D8E020-0x0000000184D8E030
	}

	[Serializable]
	[fsAutoInstance(false)]
	public sealed class TaskAgentParameter : BBParameter<UnityEngine.Object> // TypeDefIndex: 52691
	{
		// Fields
		[SerializeField]
		private System.Type _type; // 0x50
	
		// Properties
		public override System.Type varType { get; } // 0x000000018A98AF5C-0x000000018A98AFBC 
		public new UnityEngine.Object value { get; set; } // 0x000000018A98AEB4-0x000000018A98AF5C 0x00000001846A91B0-0x00000001846A91C0
	
		// Constructors
		public TaskAgentParameter(); // 0x000000018A98AE8C-0x000000018A98AEB4
	
		// Methods
		public override object GetValueBoxed(); // 0x000000018A98AD98-0x000000018A98ADA0
		public override void SetValueBoxed(object newValue); // 0x000000018A98AE38-0x000000018A98AE8C
		public void SetType(System.Type newType); // 0x000000018A98ADA0-0x000000018A98AE38
	}

	[Serializable]
	public class BBMappingParameter : BBObjectParameter // TypeDefIndex: 52692
	{
		// Fields
		[SerializeField]
		private string _targetSubGraphVariableID; // 0x60
		[SerializeField]
		private bool _canRead; // 0x68
		[SerializeField]
		private bool _canWrite; // 0x69
	
		// Properties
		public string targetSubGraphVariableID { get; } // 0x0000000184D86280-0x0000000184D86290 
		public bool canRead { get; set; } // 0x0000000184D86B40-0x0000000184D86B50 0x0000000184D86BA0-0x0000000184D86BB0
		public bool canWrite { get; set; } // 0x0000000184D86B10-0x0000000184D86B20 0x0000000184D86B70-0x0000000184D86B80
	
		// Constructors
		public BBMappingParameter(); // 0x000000018A97E034-0x000000018A97E03C
		public BBMappingParameter(Variable subVariable); // 0x000000018A97E03C-0x000000018A97E09C
	}

	[Serializable]
	public class BBObjectParameter : BBParameter<object>, ISerializationCallbackReceiver // TypeDefIndex: 52693
	{
		// Fields
		[SerializeField]
		private string _type; // 0x50
		[CompilerGenerated]
		private System.Type _type_k__BackingField; // 0x58
	
		// Properties
		private System.Type type { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public override System.Type varType { get; } // 0x00000001845E60D0-0x00000001845E6150 
	
		// Constructors
		public BBObjectParameter(); // 0x000000018A97E2EC-0x000000018A97E364
		public BBObjectParameter(System.Type t); // 0x000000018A97E2A8-0x000000018A97E2EC
		public BBObjectParameter(BBParameter source); // 0x000000018A97E218-0x000000018A97E2A8
	
		// Methods
		new void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A97E1A8-0x000000018A97E218
		new void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001838F16C0-0x00000001838F1730
		public void SetType(System.Type t); // 0x000000018A97E09C-0x000000018A97E1A8
	}

	[Serializable]
	public class BlackboardSource : IBlackboard // TypeDefIndex: 52694
	{
		// Fields
		[SerializeField]
		private Dictionary<string, Variable> _variables; // 0x10
		[CompilerGenerated]
		private Action<Variable> onVariableAdded; // 0x18
		[CompilerGenerated]
		private Action<Variable> onVariableRemoved; // 0x20
		[CompilerGenerated]
		private IBlackboard _parent_k__BackingField; // 0x28
		[CompilerGenerated]
		private UnityEngine.Object _unityContextObject_k__BackingField; // 0x30
		[CompilerGenerated]
		private Component _propertiesBindTarget_k__BackingField; // 0x38
	
		// Properties
		public string identifier { get; } // 0x000000018A97EE20-0x000000018A97EE4C 
		public Dictionary<string, Variable> variables { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public IBlackboard parent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public UnityEngine.Object unityContextObject { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public Component propertiesBindTarget { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		string IBlackboard.independantVariablesFieldName { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018A97ED08-0x000000018A97ED94
			remove; // 0x000000018A97EE4C-0x000000018A97EED8
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018A97ED94-0x000000018A97EE20
			remove; // 0x000000018A97EED8-0x000000018A97EF64
		}
	
		// Constructors
		public BlackboardSource(); // 0x0000000183CBEB90-0x0000000183CBEC10
	
		// Methods
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x00000001891A9FF4-0x00000001891AA008
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018A97DC38-0x000000018A97DC4C
		public override string ToString(); // 0x000000018A97ED00-0x000000018A97ED08
	}

	public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType> // TypeDefIndex: 52695
	{
		// Constructors
		public fsBBParameterProcessor(); // 0x000000018A98DA20-0x000000018A98DAB8
	
		// Methods
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x000000018A98D7A0-0x000000018A98DA20
	}

	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable // TypeDefIndex: 52696
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x50
		[SerializeField]
		private string _recoveryState; // 0x58
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
	
		// Constructors
		public MissingBBParameterType(); // 0x000000018A983378-0x000000018A9833A0
	}

	public class MissingVariableType : Variable<object>, IMissingRecoverable // TypeDefIndex: 52697
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x70
		[SerializeField]
		private string _recoveryState; // 0x78
	
		// Properties
		public string missingType { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public string recoveryState { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
	
		// Constructors
		public MissingVariableType(); // 0x000000018A983460-0x000000018A983494
	}
}

namespace NodeCanvas.StateMachines
{
	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/FSM Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class FSM : NodeCanvas.Framework.Graph // TypeDefIndex: 52434
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private IStateCallbackReceiver[] callbackReceivers; // 0xA8
		private Stack<FSMState> stateStack; // 0xB0
		private bool enterStartStateFlag; // 0xB8
		[CompilerGenerated]
		private Action<IState> onStateEnter; // 0xC0
		[CompilerGenerated]
		private Action<IState> onStateUpdate; // 0xC8
		[CompilerGenerated]
		private Action<IState> onStateExit; // 0xD0
		[CompilerGenerated]
		private Action<IState> onStateTransition; // 0xD8
		[CompilerGenerated]
		private FSMState _currentState_k__BackingField; // 0xE0
		[CompilerGenerated]
		private FSMState _previousState_k__BackingField; // 0xE8
	
		// Properties
		public FSMState currentState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D1C0-0x0000000184D8D1D0 0x0000000186AC5B08-0x0000000186AC5B1C
		public FSMState previousState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88590-0x0000000184D885A0 0x0000000186AC5B1C-0x0000000186AC5B30
		public string currentStateName { get; } // 0x000000018A9595E4-0x000000018A959610 
		public string previousStateName { get; } // 0x000000018A959610-0x000000018A95963C 
		public override System.Type baseNodeType { get; } // 0x000000018A959594-0x000000018A9595E4 
		public override bool requiresAgent { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool requiresPrimeNode { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool isTree { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool allowBlackboardOverrides { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Events
		public event Action<IState> onStateEnter {
			add; // 0x000000018A959354-0x000000018A9593E4
			remove; // 0x000000018A95963C-0x000000018A9596CC
		}
		public event Action<IState> onStateUpdate {
			add; // 0x000000018A959504-0x000000018A959594
			remove; // 0x000000018A9597EC-0x000000018A95987C
		}
		public event Action<IState> onStateExit {
			add; // 0x000000018A9593E4-0x000000018A959474
			remove; // 0x000000018A9596CC-0x000000018A95975C
		}
		public event Action<IState> onStateTransition {
			add; // 0x000000018A959474-0x000000018A959504
			remove; // 0x000000018A95975C-0x000000018A9597EC
		}
	
		// Nested types
		public enum TransitionCallMode // TypeDefIndex: 52431
		{
			Normal = 0,
			Stacked = 1,
			Clean = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52432
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IUpdatable, bool> __9__45_0; // 0x08
			public static Func<NodeCanvas.Framework.Node, bool> __9__49_0; // 0x10
			public static Func<NodeCanvas.Framework.Node, string> __9__49_1; // 0x18
	
			// Constructors
			static __c(); // 0x000000018A968390-0x000000018A9683F4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _OnGraphUpdate_b__45_0(IUpdatable n); // 0x000000018A968294-0x000000018A9682B8
			internal bool _GetStateNames_b__49_0(NodeCanvas.Framework.Node n); // 0x000000018A96817C-0x000000018A9681BC
			internal string _GetStateNames_b__49_1(NodeCanvas.Framework.Node n); // 0x000000018A9681BC-0x000000018A9681DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 52433
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetStateWithName_b__0(NodeCanvas.Framework.Node n); // 0x000000018A9682B8-0x000000018A96832C
		}
	
		// Constructors
		public FSM(); // 0x000000018A959308-0x000000018A959354
	
		// Methods
		protected override void OnGraphInitialize(); // 0x000000018A958B28-0x000000018A958CE8
		protected override void OnGraphStarted(); // 0x000000018A958CE8-0x000000018A958D6C
		protected override void OnGraphUpdate(); // 0x000000018A958DE0-0x000000018A9590C4
		protected override void OnGraphStoped(); // 0x000000018A958D6C-0x000000018A958DE0
		public bool EnterState(FSMState newState, TransitionCallMode callMode); // 0x000000018A9584E0-0x000000018A958694
		public FSMState TriggerState(string stateName, TransitionCallMode callMode); // 0x000000018A959128-0x000000018A959174
		public string[] GetStateNames(); // 0x000000018A958838-0x000000018A958A34
		public FSMState GetStateWithName(string name); // 0x000000018A958A34-0x000000018A958B28
		private void GatherCallbackReceivers(); // 0x000000018A958694-0x000000018A958838
		public FSMState PeekStack(); // 0x000000018A9590C4-0x000000018A959128
		[CompilerGenerated]
		private void _GatherCallbackReceivers_b__51_0(IState x); // 0x000000018A959174-0x000000018A9591F8
		[CompilerGenerated]
		private void _GatherCallbackReceivers_b__51_1(IState x); // 0x000000018A9591F8-0x000000018A959280
		[CompilerGenerated]
		private void _GatherCallbackReceivers_b__51_2(IState x); // 0x000000018A959280-0x000000018A959308
	}

	public class FSMConnection : Connection, ITaskAssignable<ConditionTask> // TypeDefIndex: 52435
	{
		// Fields
		[SerializeField]
		private FSM.TransitionCallMode _transitionCallMode; // 0x30
		[SerializeField]
		private ConditionTask _condition; // 0x38
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x000000018A957948-0x000000018A95799C
		public FSM.TransitionCallMode transitionCallMode { get; private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	
		// Constructors
		public FSMConnection(); // 0x0000000184D92320-0x0000000184D92330
	
		// Methods
		public void EnableCondition(Component agent, IBlackboard blackboard); // 0x000000018A957880-0x000000018A957894
		public void DisableCondition(); // 0x000000018A95786C-0x000000018A957880
		public void PerformTransition(); // 0x000000018A957894-0x000000018A957948
	}

	public abstract class FSMNode : NodeCanvas.Framework.Node // TypeDefIndex: 52436
	{
		// Properties
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool canSelfConnect { get; } // 0x00000001812081B0-0x0000000181208610 
		public override int maxInConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public sealed override System.Type outConnectionType { get; } // 0x000000018A9579D8-0x000000018A957A28 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public FSM FSM { get; } // 0x000000018A95799C-0x000000018A9579D8 
	
		// Constructors
		protected FSMNode(); // 0x000000018489BC70-0x000000018489BC80
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMNodeNested<T> : FSMNode, IGraphAssignable<T> // TypeDefIndex: 52437
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
		[CompilerGenerated]
		private T _currentInstance_k__BackingField;
		[CompilerGenerated]
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FSMNodeNested();
	}

	[AddComponentMenu("NodeCanvas/FSM Owner")]
	public class FSMOwner : GraphOwner<FSM> // TypeDefIndex: 52438
	{
		// Properties
		public string currentRootStateName { get; } // 0x000000018A957EB0-0x000000018A957F48 
		public string previousRootStateName { get; } // 0x000000018A957F6C-0x000000018A958004 
		public string currentDeepStateName { get; } // 0x000000018A957E8C-0x000000018A957EB0 
		public string previousDeepStateName { get; } // 0x000000018A957F48-0x000000018A957F6C 
	
		// Constructors
		public FSMOwner(); // 0x000000018A957E58-0x000000018A957E8C
	
		// Methods
		public IState GetCurrentState(bool includeSubFSMs = true /* Metadata: 0x02331C9D */); // 0x000000018A957A28-0x000000018A957B58
		public IState GetPreviousState(bool includeSubFSMs = true /* Metadata: 0x02331C9E */); // 0x000000018A957B58-0x000000018A957CFC
		public IState TriggerState(string stateName); // 0x000000018A957D94-0x000000018A957DA0
		public IState TriggerState(string stateName, FSM.TransitionCallMode callMode); // 0x000000018A957DA0-0x000000018A957E58
		public string[] GetStateNames(); // 0x000000018A957CFC-0x000000018A957D94
	}

	[Color("ff6d53")]
	public abstract class FSMState : FSMNode, IState // TypeDefIndex: 52440
	{
		// Fields
		[SerializeField]
		private TransitionEvaluationMode _transitionEvaluation; // 0x98
		private bool _hasInit; // 0x9C
	
		// Properties
		public override bool allowAsPrime { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool canSelfConnect { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override int maxInConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public TransitionEvaluationMode transitionEvaluation { get; set; } // 0x0000000184D862D0-0x0000000184D862E0 0x0000000184D86300-0x0000000184D86310
	
		// Nested types
		public enum TransitionEvaluationMode // TypeDefIndex: 52439
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}
	
		// Constructors
		protected FSMState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public FSMConnection[] GetTransitions(); // 0x000000018A9581BC-0x000000018A9582CC
		public void Finish(); // 0x000000018A95818C-0x000000018A95819C
		public void Finish(bool inSuccess); // 0x000000018A95819C-0x000000018A9581BC
		public void Finish(NodeCanvas.Framework.Status status); // 0x000000018A958184-0x000000018A95818C
		public override void OnGraphPaused(); // 0x000000018A95840C-0x000000018A958420
		protected override bool CanConnectFromSource(NodeCanvas.Framework.Node sourceNode); // 0x000000018A958004-0x000000018A95801C
		protected override bool CanConnectToTarget(NodeCanvas.Framework.Node targetNode); // 0x000000018A95801C-0x000000018A958034
		protected sealed override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018A9582CC-0x000000018A95840C
		public bool CheckTransitions(); // 0x000000018A958034-0x000000018A958184
		protected sealed override void OnReset(); // 0x000000018A958420-0x000000018A9584E0
		protected virtual void OnInit(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnEnter(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnExit(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnPause(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMStateNested<T> : FSMState, IGraphAssignable<T> // TypeDefIndex: 52441
		where T : NodeCanvas.Framework.Graph
	{
		// Fields
		[SerializeField]
		private List<BBMappingParameter> _variablesMap;
		[CompilerGenerated]
		private T _currentInstance_k__BackingField;
		[CompilerGenerated]
		private Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> _instances_k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; }
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FSMStateNested();
	}

	public interface IState // TypeDefIndex: 52442
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

	public interface IStateCallbackReceiver // TypeDefIndex: 52443
	{
		// Methods
		void OnStateEnter(IState state);
		void OnStateUpdate(IState state);
		void OnStateExit(IState state);
	}

	[Description("Execute a number of Action Tasks OnEnter. All actions will be stoped OnExit. This state is Finished when all Actions are finished as well")]
	[Name("Action State", 100)]
	public class ActionState : FSMState, ITaskAssignable // TypeDefIndex: 52444
	{
		// Fields
		[SerializeField]
		private ActionList _actionList; // 0xA0
		[SerializeField]
		private bool _repeatStateActions; // 0xA8
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x000000018A96922C-0x000000018A969284
		public ActionList actionList { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public bool repeatStateActions { get; set; } // 0x0000000184D90720-0x0000000184D90730 0x0000000184D90750-0x0000000184D90760
	
		// Constructors
		public ActionState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A969160-0x000000018A96922C
		protected override void OnEnter(); // 0x000000018A969094-0x000000018A9690A4
		protected override void OnUpdate(); // 0x000000018A9690EC-0x000000018A969160
		protected override void OnExit(); // 0x000000018A9690A4-0x000000018A9690C8
		protected override void OnPause(); // 0x000000018A9690C8-0x000000018A9690EC
	}

	[Color("b3ff7f")]
	[Description("The transitions of this node will be constantly checked. If any becomes true, that transition will take place. This is not a state.")]
	[Name("Any State", 0)]
	public class AnyState : FSMNode, IUpdatable // TypeDefIndex: 52445
	{
		// Fields
		[Tooltip("If enabled, a transition to an already running state will not happen.")]
		public bool dontRetriggerStates; // 0x98
	
		// Properties
		public override string name { get; } // 0x000000018A96975C-0x000000018A969788 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public AnyState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A9695C0-0x000000018A9696A8
		public override void OnGraphStoped(); // 0x000000018A9696A8-0x000000018A96975C
		void IUpdatable.Update(); // 0x000000018A9693EC-0x000000018A9695C0
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub FSM in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub FSM", -1)]
	public class ConcurrentSubFSM : FSMNodeNested<FSM>, IUpdatable // TypeDefIndex: 52446
	{
		// Fields
		[ExposeField]
		[Name("Parallel FSM", 0)]
		[SerializeField]
		protected BBParameter<FSM> _subFSM; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
		public override FSM subGraph { get; set; } // 0x000000018A96A730-0x000000018A96A778 0x000000018A96A778-0x000000018A96A7D0
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public ConcurrentSubFSM(); // 0x000000018A96A6FC-0x000000018A96A730
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A96A61C-0x000000018A96A6FC
		void IUpdatable.Update(); // 0x000000018A96A614-0x000000018A96A61C
		[CompilerGenerated]
		private void _OnGraphStarted_b__14_0(bool result); // 0x000000018A95819C-0x000000018A9581BC
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub Behaviour Tree in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub Behaviour Tree", -1)]
	public class ConcurrentSubTree : FSMNodeNested<BehaviourTree>, IUpdatable // TypeDefIndex: 52447
	{
		// Fields
		[ExposeField]
		[Name("Parallel Tree", 0)]
		[SerializeField]
		protected BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
		public override BehaviourTree subGraph { get; set; } // 0x000000018A96AA98-0x000000018A96AAE0 0x000000018A96AAE0-0x000000018A96AB38
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public ConcurrentSubTree(); // 0x000000018A96AA64-0x000000018A96AA98
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A96A984-0x000000018A96AA64
		void IUpdatable.Update(); // 0x000000018A96A614-0x000000018A96A61C
		[CompilerGenerated]
		private void _OnGraphStarted_b__14_0(bool result); // 0x000000018A95819C-0x000000018A9581BC
	}

	[Color("6ebbff")]
	[Description("This node has no functionality and you can use this for organization.\nIn comparison to an empty Action State, Transitions here are immediately evaluated in the same frame that this node is entered.")]
	[Name("Pass", 98)]
	public class EmptyState : FSMState // TypeDefIndex: 52448
	{
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
	
		// Constructors
		public EmptyState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		protected override void OnEnter(); // 0x000000018A96F874-0x000000018A96F89C
	}

	[Description("Execute a Behaviour Tree OnEnter. OnExit that Behavior Tree will be stoped or paused based on the relevant specified setting. You can optionaly specify a Success Event and a Failure Event which will be sent when the BT\'s root node status returns either of the two. If so, use alongside with a CheckEvent on a transition.")]
	[DropReferenceType(typeof(BehaviourTree))]
	[Icon("BT", false, "")]
	[Name("Sub BehaviourTree", 0)]
	public class NestedBTState : FSMStateNested<BehaviourTree> // TypeDefIndex: 52451
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
		public override BehaviourTree subGraph { get; set; } // 0x000000018A976C04-0x000000018A976C4C 0x000000018A976C4C-0x000000018A976CA4
		public override BBParameter subGraphParameter { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
	
		// Nested types
		public enum BTExecutionMode // TypeDefIndex: 52449
		{
			Once = 0,
			Repeat = 1
		}
	
		public enum BTExitMode // TypeDefIndex: 52450
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedBTState(); // 0x000000018A976BC4-0x000000018A976C04
	
		// Methods
		protected override void OnEnter(); // 0x000000018A976810-0x000000018A9769DC
		protected override void OnUpdate(); // 0x000000018A976B04-0x000000018A976BC4
		private void OnFinish(bool success); // 0x000000018A976A84-0x000000018A976B04
		protected override void OnExit(); // 0x000000018A9769DC-0x000000018A976A84
	}

	[Description("Execute the assigned Dialogue Tree OnEnter and stop it OnExit. Optionaly an event can be sent for whether the dialogue ended in Success or Failure. This can be controled by using the \'Finish\' Dialogue Node inside the Dialogue Tree. Use a \'CheckEvent\' condition to make use of those events. The \'Instigator\' Actor of the Dialogue Tree will be set to this graph agent.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue", 0)]
	public class NestedDTState : FSMStateNested<DialogueTree> // TypeDefIndex: 52452
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
		public override DialogueTree subGraph { get; set; } // 0x000000018A976E88-0x000000018A976ED0 0x000000018A976ED0-0x000000018A976F28
		public override BBParameter subGraphParameter { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
	
		// Constructors
		public NestedDTState(); // 0x000000018A976E54-0x000000018A976E88
	
		// Methods
		protected override void OnEnter(); // 0x000000018A976CA4-0x000000018A976D80
		protected override void OnUpdate(); // 0x000000018A976E00-0x000000018A976E54
		protected override void OnExit(); // 0x000000018A976D80-0x000000018A976E00
		private void OnDialogueFinished(bool success); // 0x000000018A97020C-0x000000018A970284
	}

	[Description("Execute a sub FSM OnEnter, and Stop that FSM OnExit. This state is Finished only when and if the sub FSM is finished as well.")]
	[DropReferenceType(typeof(FSM))]
	[Icon("FSM", false, "")]
	[Name("Sub FSM", 0)]
	public class NestedFSMState : FSMStateNested<FSM> // TypeDefIndex: 52454
	{
		// Fields
		[ExposeField]
		[Name("Sub FSM", 0)]
		[SerializeField]
		private BBParameter<FSM> _nestedFSM; // 0xB8
		[Tooltip("What will happen to the sub FSM when this state exits.")]
		public FSMExitMode exitMode; // 0xC0
	
		// Properties
		public override FSM subGraph { get; set; } // 0x000000018A9773DC-0x000000018A977424 0x000000018A977424-0x000000018A97747C
		public override BBParameter subGraphParameter { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
	
		// Nested types
		public enum FSMExitMode // TypeDefIndex: 52453
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedFSMState(); // 0x000000018A9773A8-0x000000018A9773DC
	
		// Methods
		protected override void OnEnter(); // 0x000000018A9771C4-0x000000018A9772AC
		protected override void OnUpdate(); // 0x000000018A977354-0x000000018A9773A8
		protected override void OnExit(); // 0x000000018A9772AC-0x000000018A977354
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM starts/enters, if Conditions are met. This is not a state.")]
	[Icon("MacroIn", false, "")]
	[Name("On FSM Enter", 0)]
	public class OnFSMEnter : FSMNode, IUpdatable // TypeDefIndex: 52455
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public OnFSMEnter(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A977DF4-0x000000018A977F64
		public override void OnGraphStarted(); // 0x000000018A977CCC-0x000000018A977DA8
		public override void OnGraphStoped(); // 0x000000018A977DA8-0x000000018A977DF4
		void IUpdatable.Update(); // 0x000000018A977C60-0x000000018A977CCC
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM stops/exits, if Conditions are met. Note that the actions will only execute for 1 frame. This is not a state.")]
	[Icon("MacroOut", false, "")]
	[Name("On FSM Exit", 0)]
	public class OnFSMExit : FSMNode // TypeDefIndex: 52456
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public OnFSMExit(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A978088-0x000000018A9781F8
		public override void OnGraphStarted(); // 0x000000018A977F64-0x000000018A977FBC
		public override void OnGraphStoped(); // 0x000000018A977FBC-0x000000018A978088
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions repeatedly and in parallel to any other FSM state while the FSM is running. Conditions are optional. This is not a state.")]
	[Icon("Repeat", false, "")]
	[Name("On FSM Update", 0)]
	public class OnFSMUpdate : FSMNode, IUpdatable // TypeDefIndex: 52457
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public OnFSMUpdate(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A9782C0-0x000000018A978430
		public override void OnGraphStarted(); // 0x000000018A977F64-0x000000018A977FBC
		public override void OnGraphStoped(); // 0x000000018A977DA8-0x000000018A977DF4
		void IUpdatable.Update(); // 0x000000018A9781F8-0x000000018A9782C0
	}

	[Description("The Super Action State provides finer control on when to execute actions. This state is never Finished by it\'s own if there is any Actions in the OnUpdate list and thus OnFinish transitions will never be called in that case. OnExit Actions are only called for 1 frame when the state exits.")]
	[Name("Action State (Super)", 99)]
	public class SuperActionState : FSMState // TypeDefIndex: 52458
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
		public SuperActionState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A97B0CC-0x000000018A97B2A8
		protected override void OnEnter(); // 0x000000018A97AEE4-0x000000018A97AEF8
		protected override void OnUpdate(); // 0x000000018A97AFE4-0x000000018A97B0CC
		protected override void OnExit(); // 0x000000018A97AEF8-0x000000018A97AFA8
		protected override void OnPause(); // 0x000000018A97AFA8-0x000000018A97AFE4
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions with optional conditional requirement and in parallel to any other state, as soon as the FSM is started. All actions will prematurely be stoped as soon as the FSM stops as well. This is not a state.")]
	[Icon("Repeat", false, "")]
	[Name("Parallel", 0)]
	[Obsolete("Use On FSM Update node")]
	public class ConcurrentState : FSMNode, IUpdatable // TypeDefIndex: 52459
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
		public NodeCanvas.Framework.ConditionList conditionList { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public ActionList actionList { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public bool repeatStateActions { get; set; } // 0x0000000184D90720-0x0000000184D90730 0x0000000184D90750-0x0000000184D90760
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public ConcurrentState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A96A4C8-0x000000018A96A614
		public override void OnGraphStarted(); // 0x000000018A96A414-0x000000018A96A474
		public override void OnGraphStoped(); // 0x000000018A96A474-0x000000018A96A4C8
		public override void OnGraphPaused(); // 0x000000018A9690C8-0x000000018A9690EC
		void IUpdatable.Update(); // 0x000000018A96A308-0x000000018A96A414
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM enters/starts and when it exits/stops. This is not a state.")]
	[Icon("MacroIn", false, "")]
	[Name("Enter | Exit", 0)]
	[Obsolete("Use On FSM Enter and On FSM Exit nodes")]
	public class EnterExitState : FSMNode, IUpdatable // TypeDefIndex: 52460
	{
		// Fields
		[SerializeField]
		private ActionList _actionListEnter; // 0x98
		[SerializeField]
		private ActionList _actionListExit; // 0xA0
	
		// Properties
		public ActionList actionListEnter { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public ActionList actionListExit { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public EnterExitState(); // 0x000000018489BC70-0x000000018489BC80
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018A96FA04-0x000000018A96FB3C
		public override void OnGraphStarted(); // 0x000000018A96F908-0x000000018A96F970
		public override void OnGraphStoped(); // 0x000000018A96F970-0x000000018A96FA04
		void IUpdatable.Update(); // 0x000000018A96F89C-0x000000018A96F908
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub FlowScript in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub FlowScript", -1)]
	public class ConcurrentSubFlowScript : FSMNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 52461
	{
		// Fields
		[ExposeField]
		[Name("Parallel FlowScript", 0)]
		[SerializeField]
		protected BBParameter<FlowScript> _subFlowScript; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018A968FC0-0x000000018A968FE4 
		public override int maxInConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override int maxOutConnections { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool allowAsPrime { get; } // 0x00000001812081B0-0x0000000181208610 
		public override FlowScript subGraph { get; set; } // 0x000000018A96A8E4-0x000000018A96A92C 0x000000018A96A92C-0x000000018A96A984
		public override BBParameter subGraphParameter { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Constructors
		public ConcurrentSubFlowScript(); // 0x000000018A96A8B0-0x000000018A96A8E4
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018A96A7D0-0x000000018A96A8B0
		void IUpdatable.Update(); // 0x000000018A96A614-0x000000018A96A61C
		[CompilerGenerated]
		private void _OnGraphStarted_b__14_0(bool result); // 0x000000018A95819C-0x000000018A9581BC
	}

	[Description("Adds a FlowCanvas FlowScript as a nested State of the FSM. The FlowScript State is never finished by itself, unless a \'Finish\' node is used in the FlowScript. Success/Failure events can optionlay be used alongside with a CheckEvent on state transitions to catch whether the FlowScript Finished in success or failure.")]
	[DropReferenceType(typeof(FlowScript))]
	[Name("Sub FlowScript", 0)]
	public class FlowScriptState : FSMStateNested<FlowScript> // TypeDefIndex: 52462
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
		public override FlowScript subGraph { get; set; } // 0x000000018A97030C-0x000000018A970354 0x000000018A970354-0x000000018A9703AC
		public override BBParameter subGraphParameter { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
	
		// Constructors
		public FlowScriptState(); // 0x000000018A9702D8-0x000000018A97030C
	
		// Methods
		protected override void OnEnter(); // 0x000000018A9700A0-0x000000018A97017C
		protected override void OnUpdate(); // 0x000000018A970284-0x000000018A9702D8
		private void OnFlowScriptFinished(bool success); // 0x000000018A97020C-0x000000018A970284
		protected override void OnExit(); // 0x000000018A97017C-0x000000018A97020C
	}
}

namespace NodeCanvas.Tasks.Actions
{
	[Category("Animation")]
	public class PlayAnimationAdvanced : ActionTask<UnityEngine.Animation> // TypeDefIndex: 52287
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
		protected override string info { get; } // 0x000000018A962D4C-0x000000018A962DA4 
	
		// Constructors
		public PlayAnimationAdvanced(); // 0x000000018A962CCC-0x000000018A962D4C
	
		// Methods
		protected override string OnInit(); // 0x000000018A962B4C-0x000000018A962C30
		protected override void OnExecute(); // 0x000000018A962688-0x000000018A962B4C
		protected override void OnUpdate(); // 0x000000018A962C30-0x000000018A962CCC
		private Transform FindTransform(Transform parent, string name); // 0x000000018A9625B0-0x000000018A962688
	}

	[Category("Animation")]
	public class PlayAnimationSimple : ActionTask<UnityEngine.Animation> // TypeDefIndex: 52288
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
		protected override string info { get; } // 0x000000018A963224-0x000000018A96327C 
	
		// Constructors
		public PlayAnimationSimple(); // 0x000000018A9631E0-0x000000018A963224
		static PlayAnimationSimple(); // 0x000000018A963154-0x000000018A9631E0
	
		// Methods
		protected override string OnInit(); // 0x000000018A962FEC-0x000000018A9630D0
		protected override void OnExecute(); // 0x000000018A962DA4-0x000000018A962FEC
		protected override void OnUpdate(); // 0x000000018A9630D0-0x000000018A963154
	}

	[Category("Animator")]
	[Name("Play Animation", 0)]
	public class MecanimPlayAnimation : ActionTask<Animator> // TypeDefIndex: 52289
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
		protected override string info { get; } // 0x000000018A960AA4-0x000000018A960B0C 
	
		// Constructors
		public MecanimPlayAnimation(); // 0x000000018A960A58-0x000000018A960AA4
	
		// Methods
		protected override void OnExecute(); // 0x000000018A960764-0x000000018A9608CC
		protected override void OnUpdate(); // 0x000000018A9608CC-0x000000018A960A58
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Bool", 0)]
	public class MecanimSetBool : ActionTask<Animator> // TypeDefIndex: 52290
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<bool> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A960C98-0x000000018A960D48 
	
		// Constructors
		public MecanimSetBool(); // 0x000000018A960C5C-0x000000018A960C98
	
		// Methods
		protected override void OnExecute(); // 0x000000018A960B0C-0x000000018A960C5C
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Float", 0)]
	public class MecanimSetFloat : ActionTask<Animator> // TypeDefIndex: 52291
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<float> setTo; // 0x78
		[SliderField(0, 1)]
		public float transitTime; // 0x80
		private float currentValue; // 0x84
	
		// Properties
		protected override string info { get; } // 0x000000018A9610BC-0x000000018A96116C 
	
		// Constructors
		public MecanimSetFloat(); // 0x000000018A96106C-0x000000018A9610BC
	
		// Methods
		protected override void OnExecute(); // 0x000000018A960E34-0x000000018A960EB8
		protected override void OnUpdate(); // 0x000000018A960EB8-0x000000018A960F6C
		private float Get(); // 0x000000018A960D48-0x000000018A960E34
		private void Set(float newValue); // 0x000000018A960F6C-0x000000018A96106C
	}

	[Category("Animator")]
	[Name("Set IK", 0)]
	public class MecanimSetIK : ActionTask<Animator> // TypeDefIndex: 52292
	{
		// Fields
		public AvatarIKGoal IKGoal; // 0x68
		[RequiredField]
		public BBParameter<GameObject> goal; // 0x70
		public BBParameter<float> weight; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A961400-0x000000018A9614BC 
	
		// Constructors
		public MecanimSetIK(); // 0x000000018A9613C4-0x000000018A961400
	
		// Methods
		protected override void OnExecute(); // 0x000000018A961294-0x000000018A96132C
		protected override void OnStop(); // 0x000000018A96132C-0x000000018A9613C4
		private void OnAnimatorIK(EventData<int> msg); // 0x000000018A96116C-0x000000018A961294
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Integer", 0)]
	public class MecanimSetInt : ActionTask<Animator> // TypeDefIndex: 52293
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<int> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A96163C-0x000000018A9616EC 
	
		// Constructors
		public MecanimSetInt(); // 0x000000018A961600-0x000000018A96163C
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9614BC-0x000000018A961600
	}

	[Category("Animator")]
	[Name("Set Layer Weight", 0)]
	public class MecanimSetLayerWeight : ActionTask<Animator> // TypeDefIndex: 52294
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[SliderField(0, 1)]
		public BBParameter<float> layerWeight; // 0x70
		[SliderField(0, 1)]
		public float transitTime; // 0x78
		private float currentValue; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x000000018A9618D0-0x000000018A961970 
	
		// Constructors
		public MecanimSetLayerWeight(); // 0x000000018A961894-0x000000018A9618D0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9616EC-0x000000018A961770
		protected override void OnUpdate(); // 0x000000018A961770-0x000000018A961894
	}

	[Category("Animator")]
	[Name("Set Look At", 0)]
	public class MecanimSetLookAt : ActionTask<Animator> // TypeDefIndex: 52295
	{
		// Fields
		public BBParameter<GameObject> targetPosition; // 0x68
		public BBParameter<float> targetWeight; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A961BF4-0x000000018A961C54 
	
		// Constructors
		public MecanimSetLookAt(); // 0x000000018A961BB8-0x000000018A961BF4
	
		// Methods
		protected override void OnExecute(); // 0x000000018A961A88-0x000000018A961B20
		protected override void OnStop(); // 0x000000018A961B20-0x000000018A961BB8
		private void OnAnimatorIK(EventData<int> msg); // 0x000000018A961970-0x000000018A961A88
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Trigger", 0)]
	public class MecanimSetTrigger : ActionTask<Animator> // TypeDefIndex: 52296
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A961D88-0x000000018A961E34 
	
		// Constructors
		public MecanimSetTrigger(); // 0x000000018A961D4C-0x000000018A961D88
	
		// Methods
		protected override void OnExecute(); // 0x000000018A961C54-0x000000018A961D4C
	}

	[Category("Application")]
	public class LoadScene : ActionTask // TypeDefIndex: 52297
	{
		// Fields
		[RequiredField]
		public BBParameter<string> sceneName; // 0x68
		public BBParameter<LoadSceneMode> mode; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A960570-0x000000018A9605B0 
	
		// Constructors
		public LoadScene(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9604C0-0x000000018A960570
	}

	[Category("Audio")]
	public class PlayAudioAtPosition : ActionTask<Transform> // TypeDefIndex: 52298
	{
		// Fields
		[RequiredField]
		public BBParameter<AudioClip> audioClip; // 0x68
		[SliderField(0, 1)]
		public float volume; // 0x70
		public bool waitActionFinish; // 0x74
	
		// Properties
		protected override string info { get; } // 0x000000018A963404-0x000000018A96345C 
	
		// Constructors
		public PlayAudioAtPosition(); // 0x000000018A9633B8-0x000000018A963404
	
		// Methods
		protected override void OnExecute(); // 0x000000018A96327C-0x000000018A963338
		protected override void OnUpdate(); // 0x000000018A963338-0x000000018A9633B8
	}

	[Category("\u272B Blackboard")]
	[Description("Create a new Vector out of 3 floats and save it to the blackboard")]
	public class ComposeVector : ActionTask // TypeDefIndex: 52299
	{
		// Fields
		public BBParameter<float> x; // 0x68
		public BBParameter<float> y; // 0x70
		public BBParameter<float> z; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A953E98-0x000000018A953EFC 
	
		// Constructors
		public ComposeVector(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A953DB8-0x000000018A953E98
	}

	[Category("\u272B Blackboard")]
	[Description("Create up to 3 floats from a Vector and save them to blackboard")]
	public class DecomposeVector : ActionTask // TypeDefIndex: 52300
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
		protected override string info { get; } // 0x000000018A955128-0x000000018A955188 
	
		// Constructors
		public DecomposeVector(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A955020-0x000000018A955128
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class AddElementToDictionary<T> : ActionTask // TypeDefIndex: 52301
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public AddElementToDictionary();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class GetDictionaryElement<T> : ActionTask // TypeDefIndex: 52302
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<Dictionary<string, T>> dictionary;
		public BBParameter<string> key;
		[BlackboardOnly]
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public GetDictionaryElement();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard")]
	public class EvaluateCurve : ActionTask // TypeDefIndex: 52303
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
		public EvaluateCurve(); // 0x000000018A955440-0x000000018A9554BC
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A9552CC-0x000000018A955440
	}

	[Category("\u272B Blackboard")]
	[Description("Stores the agent gameobject on the blackboard.")]
	public class GetSelf : ActionTask // TypeDefIndex: 52304
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x68
	
		// Constructors
		public GetSelf(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95DDA0-0x000000018A95DE1C
	}

	[Category("\u272B Blackboard")]
	[Description("Use this to get a variable on any blackboard by overriding the agent")]
	public class GetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 52305
	{
		// Fields
		[RequiredField]
		public BBParameter<string> targetVariableName; // 0x68
		[BlackboardOnly]
		public BBObjectParameter saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95D0EC-0x000000018A95D130 
	
		// Constructors
		public GetOtherBlackboardVariable(); // 0x000000018A95D0B0-0x000000018A95D0EC
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95CFE4-0x000000018A95D0B0
	}

	[Category("\u272B Blackboard")]
	[Name("Get Variable To String", 0)]
	public class GetToString : ActionTask // TypeDefIndex: 52306
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> variable; // 0x68
		[BlackboardOnly]
		public BBParameter<string> toString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95DEDC-0x000000018A95DF20 
	
		// Constructors
		public GetToString(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95DE1C-0x000000018A95DEDC
	}

	[Category("\u272B Blackboard/Lists")]
	public class AddElementToList<T> : ActionTask // TypeDefIndex: 52307
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public AddElementToList();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	public class ClearList : ActionTask // TypeDefIndex: 52308
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A953D78-0x000000018A953DB8 
	
		// Constructors
		public ClearList(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A953D14-0x000000018A953D78
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Get the closer game object to the agent from within a list of game objects and save it in the blackboard.")]
	public class GetCloserGameObjectInList : ActionTask<Transform> // TypeDefIndex: 52309
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> list; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95B0D4-0x000000018A95B174 
	
		// Constructors
		public GetCloserGameObjectInList(); // 0x000000018A95B098-0x000000018A95B0D4
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95ADC8-0x000000018A95B098
	}

	[Category("\u272B Blackboard/Lists")]
	public class GetIndexOfElement<T> : ActionTask // TypeDefIndex: 52310
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
		[BlackboardOnly]
		public BBParameter<int> saveIndexAs;
	
		// Constructors
		public GetIndexOfElement();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	public class GetListCount : ActionTask // TypeDefIndex: 52311
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
		[BlackboardOnly]
		public BBParameter<int> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95CE24-0x000000018A95CE68 
	
		// Constructors
		public GetListCount(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95CD94-0x000000018A95CE24
	}

	[Category("\u272B Blackboard/Lists")]
	public class InsertElementToList<T> : ActionTask // TypeDefIndex: 52312
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
		public BBParameter<int> targetIndex;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public InsertElementToList();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	public class PickListElement<T> : ActionTask // TypeDefIndex: 52313
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		[BlackboardOnly]
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public PickListElement();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	public class PickRandomListElement<T> : ActionTask // TypeDefIndex: 52314
	{
		// Fields
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public PickRandomListElement();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Remove an element from the target list")]
	public class RemoveElementFromList<T> : ActionTask // TypeDefIndex: 52315
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> targetElement;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public RemoveElementFromList();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	public class SetListElement<T> : ActionTask // TypeDefIndex: 52316
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<int> index;
		public BBParameter<T> newValue;
	
		// Constructors
		public SetListElement();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard/Lists")]
	public class ShuffleList : ActionTask // TypeDefIndex: 52317
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Constructors
		public ShuffleList(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A967108-0x000000018A967208
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Will sort the gameobjects in the target list by their distance to the agent (closer first) and save that list to the blackboard")]
	public class SortGameObjectListByDistance : ActionTask<Transform> // TypeDefIndex: 52318
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<GameObject>> targetList; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
		public bool reverse; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A967460-0x000000018A967500 
	
		// Constructors
		public SortGameObjectListByDistance(); // 0x000000018A967424-0x000000018A967460
	
		// Methods
		protected override void OnExecute(); // 0x000000018A967208-0x000000018A967360
		[CompilerGenerated]
		private float _OnExecute_b__5_0(GameObject go); // 0x000000018A967360-0x000000018A967424
	}

	[Category("\u272B Blackboard")]
	[Description("Loads the blackboard variables previously saved in the provided PlayerPrefs key if at all. Returns false if no saves found or load was failed")]
	public class LoadBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 52319
	{
		// Fields
		[RequiredField]
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A960468-0x000000018A9604C0 
	
		// Constructors
		public LoadBlackboard(); // 0x000000018A96042C-0x000000018A960468
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9603A0-0x000000018A96042C
	}

	[Category("\u272B Blackboard")]
	public class NormalizeVector : ActionTask // TypeDefIndex: 52320
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		public BBParameter<float> multiply; // 0x70
	
		// Constructors
		public NormalizeVector(); // 0x000000018A96255C-0x000000018A9625B0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A962448-0x000000018A96255C
	}

	[Category("\u272B Blackboard")]
	public class SampleCurve : ActionTask // TypeDefIndex: 52321
	{
		// Fields
		[RequiredField]
		public BBParameter<AnimationCurve> curve; // 0x68
		[SliderField(0, 1)]
		public BBParameter<float> sampleAt; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x78
	
		// Constructors
		public SampleCurve(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A963E24-0x000000018A963EE8
	}

	[Category("\u272B Blackboard")]
	[Description("Saves the blackboard variables in the provided key and to be loaded later on")]
	public class SaveBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 52322
	{
		// Fields
		[RequiredField]
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A963FB0-0x000000018A964008 
	
		// Constructors
		public SaveBlackboard(); // 0x000000018A963F74-0x000000018A963FB0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A963EE8-0x000000018A963F74
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard boolean variable")]
	public class SetBoolean : ActionTask // TypeDefIndex: 52324
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<bool> boolVariable; // 0x68
		public BoolSetModes setTo; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A964BD4-0x000000018A964CB8 
	
		// Nested types
		public enum BoolSetModes // TypeDefIndex: 52323
		{
			False = 0,
			True = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetBoolean(); // 0x0000000184DA6730-0x0000000184DA6740
	
		// Methods
		protected override void OnExecute(); // 0x000000018A964B3C-0x000000018A964BD4
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard boolean variable at random between min and max value")]
	public class SetBooleanRandom : ActionTask // TypeDefIndex: 52325
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> boolVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A964AC8-0x000000018A964B3C 
	
		// Constructors
		public SetBooleanRandom(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A964A54-0x000000018A964AC8
	}

	[Category("\u272B Blackboard")]
	public class SetEnum : ActionTask // TypeDefIndex: 52326
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A964E30-0x000000018A964EB8 
	
		// Constructors
		public SetEnum(); // 0x000000018A964D3C-0x000000018A964E30
	
		// Methods
		protected override void OnExecute(); // 0x000000018A964CB8-0x000000018A964D3C
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard float variable")]
	public class SetFloat : ActionTask // TypeDefIndex: 52327
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<float> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A96568C-0x000000018A9657B8 
	
		// Constructors
		public SetFloat(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9655A0-0x000000018A96568C
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard float variable at random between min and max value")]
	public class SetFloatRandom : ActionTask // TypeDefIndex: 52328
	{
		// Fields
		public BBParameter<float> minValue; // 0x68
		public BBParameter<float> maxValue; // 0x70
		[BlackboardOnly]
		public BBParameter<float> floatVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A965444-0x000000018A9655A0 
	
		// Constructors
		public SetFloatRandom(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A965390-0x000000018A965444
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard integer variable")]
	[Name("Set Integer", 0)]
	public class SetInt : ActionTask // TypeDefIndex: 52329
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<int> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A965A70-0x000000018A965AEC 
	
		// Constructors
		public SetInt(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9659C4-0x000000018A965A70
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard integer variable at random between min and max value")]
	[Name("Set Integer Random", 0)]
	public class SetIntRandom : ActionTask // TypeDefIndex: 52330
	{
		// Fields
		public BBParameter<int> minValue; // 0x68
		public BBParameter<int> maxValue; // 0x70
		[BlackboardOnly]
		public BBParameter<int> intVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A965868-0x000000018A9659C4 
	
		// Constructors
		public SetIntRandom(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9657B8-0x000000018A965868
	}

	[Category("\u272B Blackboard")]
	[Description("Use this to set a variable on any blackboard by overriding the agent")]
	public class SetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 52331
	{
		// Fields
		[RequiredField]
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter newValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A966028-0x000000018A9660C4 
	
		// Constructors
		public SetOtherBlackboardVariable(); // 0x000000018A965FEC-0x000000018A966028
	
		// Methods
		protected override void OnExecute(); // 0x000000018A965F2C-0x000000018A965FEC
	}

	[Category("\u272B Blackboard")]
	public class SetVariable<T> : ActionTask // TypeDefIndex: 52332
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SetVariable();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard Vector3 variable")]
	public class SetVector3 : ActionTask // TypeDefIndex: 52333
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> valueA; // 0x68
		public OperationMethod operation; // 0x70
		public BBParameter<Vector3> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A966AAC-0x000000018A966BD8 
	
		// Constructors
		public SetVector3(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A966980-0x000000018A966AAC
	}

	[Category("\u272B Blackboard")]
	[Description("Triggers a boolean variable for 1 frame to True then back to False")]
	public class TriggerBoolean : ActionTask // TypeDefIndex: 52335
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<bool> variable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A967E1C-0x000000018A967E5C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Flip_d__4 : IEnumerator<object> // TypeDefIndex: 52334
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TriggerBoolean __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Flip_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A967E5C-0x000000018A967EDC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A967EDC-0x000000018A967F28
		}
	
		// Constructors
		public TriggerBoolean(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A967D88-0x000000018A967E1C
		[IteratorStateMachine(typeof(_Flip_d__4))]
		private IEnumerator Flip(); // 0x000000018A967D2C-0x000000018A967D88
	}

	[Category("Camera")]
	public class FadeIn : ActionTask // TypeDefIndex: 52336
	{
		// Constructors
		public FadeIn(); // 0x0000000184D8E030-0x0000000184D8E040
	}

	[Category("Camera")]
	public class FadeOut : ActionTask // TypeDefIndex: 52337
	{
		// Constructors
		public FadeOut(); // 0x0000000184D8E030-0x0000000184D8E040
	}

	[Category("Dialogue")]
	[Description("You can use a variable inline with the text by using brackets likeso: [myVarName] or [Global/myVarName].\nThe bracket will be replaced with the variable value ToString")]
	[Icon("Dialogue", false, "")]
	public class Say : ActionTask<IDialogueActor> // TypeDefIndex: 52338
	{
		// Fields
		public Statement statement; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A964384-0x000000018A9643FC 
	
		// Constructors
		public Say(); // 0x000000018A9642F8-0x000000018A964384
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9641EC-0x000000018A9642F8
	}

	[Category("Dialogue")]
	[Description("A random statement will be chosen each time for the actor to say")]
	[Icon("Dialogue", false, "")]
	public class SayRandom : ActionTask<IDialogueActor> // TypeDefIndex: 52339
	{
		// Fields
		public List<Statement> statements; // 0x68
	
		// Constructors
		public SayRandom(); // 0x000000018A964160-0x000000018A9641EC
	
		// Methods
		protected override void OnExecute(); // 0x000000018A964008-0x000000018A964160
	}

	[Category("Dialogue")]
	[Description("Starts the Dialogue Tree assigned on a Dialogue Tree Controller object with specified agent used for \'Instigator\'.")]
	[Icon("Dialogue", false, "")]
	public class StartDialogueTree : ActionTask<IDialogueActor> // TypeDefIndex: 52340
	{
		// Fields
		[RequiredField]
		public BBParameter<DialogueTreeController> dialogueTreeController; // 0x68
		public bool waitActionFinish; // 0x70
		public bool isPrefab; // 0x71
		private DialogueTreeController instance; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A9677D4-0x000000018A967814 
	
		// Constructors
		public StartDialogueTree(); // 0x000000018A967790-0x000000018A9677D4
	
		// Methods
		protected override void OnExecute(); // 0x000000018A967500-0x000000018A9676AC
		[CompilerGenerated]
		private void _OnExecute_b__6_0(bool success); // 0x000000018A9676AC-0x000000018A967730
		[CompilerGenerated]
		private void _OnExecute_b__6_1(bool success); // 0x000000018A967730-0x000000018A967790
	}

	[Category("GameObject")]
	public class CreateGameObject : ActionTask // TypeDefIndex: 52341
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x80
	
		// Constructors
		public CreateGameObject(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A953EFC-0x000000018A95407C
	}

	[Category("GameObject")]
	public class CreatePrimitive : ActionTask // TypeDefIndex: 52342
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		public BBParameter<PrimitiveType> type; // 0x80
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x88
	
		// Constructors
		public CreatePrimitive(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95407C-0x000000018A954214
	}

	[Category("GameObject")]
	public class DestroyGameObject : ActionTask<Transform> // TypeDefIndex: 52343
	{
		// Fields
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A955284-0x000000018A9552CC 
	
		// Constructors
		public DestroyGameObject(); // 0x000000018A955248-0x000000018A955284
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A955188-0x000000018A955248
	}

	[Category("GameObject")]
	[Description("Action will end in Failure if no objects are found")]
	public class FindAllWithLayer : ActionTask // TypeDefIndex: 52344
	{
		// Fields
		[RequiredField]
		public BBParameter<LayerMask> targetLayers; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95995C-0x000000018A9599FC 
	
		// Constructors
		public FindAllWithLayer(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95987C-0x000000018A95995C
	}

	[Category("GameObject")]
	[Description("Note that this is slow.\nAction will end in Failure if no objects are found")]
	public class FindAllWithName : ActionTask // TypeDefIndex: 52345
	{
		// Fields
		[RequiredField]
		public BBParameter<string> searchName; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A959BE4-0x000000018A959C84 
	
		// Constructors
		public FindAllWithName(); // 0x000000018A959B84-0x000000018A959BE4
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9599FC-0x000000018A959B84
	}

	[Category("GameObject")]
	[Description("Action will end in Failure if no objects are found")]
	public class FindAllWithTag : ActionTask // TypeDefIndex: 52346
	{
		// Fields
		[RequiredField]
		[TagField]
		public BBParameter<string> searchTag; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A959DC4-0x000000018A959E64 
	
		// Constructors
		public FindAllWithTag(); // 0x000000018A959D64-0x000000018A959DC4
	
		// Methods
		protected override void OnExecute(); // 0x000000018A959C84-0x000000018A959D64
	}

	[Category("GameObject")]
	[Description("Find a transform child by name within the agent\'s transform")]
	public class FindChildByName : ActionTask<Transform> // TypeDefIndex: 52347
	{
		// Fields
		[RequiredField]
		public BBParameter<string> childName; // 0x68
		[BlackboardOnly]
		public BBParameter<Transform> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A959FDC-0x000000018A95A03C 
	
		// Constructors
		public FindChildByName(); // 0x000000018A959FA0-0x000000018A959FDC
	
		// Methods
		protected override void OnExecute(); // 0x000000018A959E64-0x000000018A959FA0
	}

	[Category("GameObject")]
	[Description("Find the closest game object of tag to the agent")]
	public class FindClosestWithTag : ActionTask<Transform> // TypeDefIndex: 52348
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
		public FindClosestWithTag(); // 0x000000018A95A3D4-0x000000018A95A410
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95A108-0x000000018A95A3D4
	}

	[Category("GameObject")]
	[Description("Note that this is very slow")]
	public class FindObjectOfType<T> : ActionTask // TypeDefIndex: 52349
		where T : Component
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> saveComponentAs;
		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs;
	
		// Constructors
		public FindObjectOfType();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("GameObject")]
	[Description("Note that this is very slow")]
	public class FindObjectsOfType<T> : ActionTask // TypeDefIndex: 52351
		where T : Component
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveGameObjects;
		[BlackboardOnly]
		public BBParameter<List<T>> saveComponents;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52350
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<T, GameObject> __9__2_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal GameObject _OnExecute_b__2_0(T o);
		}
	
		// Constructors
		public FindObjectsOfType();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("GameObject")]
	public class FindWithName : ActionTask // TypeDefIndex: 52352
	{
		// Fields
		[RequiredField]
		public BBParameter<string> gameObjectName; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95A49C-0x000000018A95A53C 
	
		// Constructors
		public FindWithName(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95A410-0x000000018A95A49C
	}

	[Category("GameObject")]
	public class FindWithTag : ActionTask // TypeDefIndex: 52353
	{
		// Fields
		[RequiredField]
		[TagField]
		public string searchTag; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95A5F0-0x000000018A95A67C 
	
		// Constructors
		public FindWithTag(); // 0x000000018A95A5A8-0x000000018A95A5F0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95A53C-0x000000018A95A5A8
	}

	[Category("GameObject")]
	public class GetAllChildGameObjects : ActionTask<Transform> // TypeDefIndex: 52355
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x68
		public bool recursive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95AD28-0x000000018A95ADC8 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52354
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, GameObject> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A9684BC-0x000000018A968520
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal GameObject _OnExecute_b__4_0(Transform t); // 0x0000000187C183B0-0x0000000187C183D0
		}
	
		// Constructors
		public GetAllChildGameObjects(); // 0x000000018A95ACEC-0x000000018A95AD28
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95A92C-0x000000018A95ACEC
		private List<Transform> Get(Transform parent); // 0x000000018A95A71C-0x000000018A95A92C
	}

	[Category("GameObject")]
	public class GetComponent<T> : ActionTask<Transform> // TypeDefIndex: 52356
		where T : Component
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public GetComponent();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("GameObject")]
	public class GetDistance : ActionTask<Transform> // TypeDefIndex: 52357
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95B2D8-0x000000018A95B330 
	
		// Constructors
		public GetDistance(); // 0x000000018A95B29C-0x000000018A95B2D8
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95B174-0x000000018A95B29C
	}

	[Category("GameObject")]
	[Obsolete("Use Get Property instead")]
	public class GetGameObjectPosition : ActionTask<Transform> // TypeDefIndex: 52358
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A95B908-0x000000018A95B99C 
	
		// Constructors
		public GetGameObjectPosition(); // 0x000000018A95B8CC-0x000000018A95B908
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95B828-0x000000018A95B8CC
	}

	[Category("GameObject")]
	public class InstantiateGameObject : ActionTask<Transform> // TypeDefIndex: 52359
	{
		// Fields
		public BBParameter<Transform> parent; // 0x68
		public BBParameter<Vector3> clonePosition; // 0x70
		public BBParameter<Vector3> cloneRotation; // 0x78
		[BlackboardOnly]
		public BBParameter<GameObject> saveCloneAs; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A95F558-0x000000018A95F73C 
	
		// Constructors
		public InstantiateGameObject(); // 0x000000018A95F51C-0x000000018A95F558
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95F358-0x000000018A95F51C
	}

	[Category("GameObject")]
	public class LookAt : ActionTask<Transform> // TypeDefIndex: 52360
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> lookTarget; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A960704-0x000000018A960764 
	
		// Constructors
		public LookAt(); // 0x000000018A9606C8-0x000000018A960704
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9606C0-0x000000018A9606C8
		protected override void OnUpdate(); // 0x000000018A9606C0-0x000000018A9606C8
		private void DoLook(); // 0x000000018A9605B0-0x000000018A9606C0
	}

	[Category("GameObject")]
	public class RemoveComponent<T> : ActionTask<Transform> // TypeDefIndex: 52361
		where T : Component
	{
		// Fields
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public RemoveComponent();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("GameObject")]
	[Description("Set the gameobject active state.")]
	[Name("Set Active", 0)]
	public class SetObjectActive : ActionTask<Transform> // TypeDefIndex: 52363
	{
		// Fields
		public SetActiveMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A965BF0-0x000000018A965C6C 
	
		// Nested types
		public enum SetActiveMode // TypeDefIndex: 52362
		{
			Deactivate = 0,
			Activate = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectActive(); // 0x000000018A965BA4-0x000000018A965BF0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A965AEC-0x000000018A965BA4
	}

	[Category("GameObject")]
	[Description("Set the monobehaviour\'s enabled state.")]
	[Name("Set Enabled", 0)]
	public class SetObjectEnabled : ActionTask<MonoBehaviour> // TypeDefIndex: 52365
	{
		// Fields
		public SetEnableMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A965D50-0x000000018A965DCC 
	
		// Nested types
		public enum SetEnableMode // TypeDefIndex: 52364
		{
			Disable = 0,
			Enable = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectEnabled(); // 0x000000018A965D04-0x000000018A965D50
	
		// Methods
		protected override void OnExecute(); // 0x000000018A965C6C-0x000000018A965D04
	}

	[Category("GameObject")]
	[Description("Set the Renderer active state, thus making the object visible or invisible.")]
	[Name("Set Visibility", 0)]
	public class SetObjectVisibility : ActionTask<Renderer> // TypeDefIndex: 52367
	{
		// Fields
		public SetVisibleMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A965EB0-0x000000018A965F2C 
	
		// Nested types
		public enum SetVisibleMode // TypeDefIndex: 52366
		{
			Hide = 0,
			Show = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectVisibility(); // 0x000000018A965E64-0x000000018A965EB0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A965DCC-0x000000018A965E64
	}

	[Category("Input (Legacy System)")]
	public class GetInputAxis : ActionTask // TypeDefIndex: 52368
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
		public GetInputAxis(); // 0x000000018A95BC60-0x000000018A95BD20
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95BC58-0x000000018A95BC60
		protected override void OnUpdate(); // 0x000000018A95BC58-0x000000018A95BC60
		private void Do(); // 0x000000018A95B99C-0x000000018A95BC58
	}

	[Category("Input (Legacy System)")]
	public class GetMousePosition : ActionTask // TypeDefIndex: 52369
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Constructors
		public GetMousePosition(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95CEF0-0x000000018A95CEF8
		protected override void OnUpdate(); // 0x000000018A95CEF0-0x000000018A95CEF8
		private void Do(); // 0x000000018A95CE68-0x000000018A95CEF0
	}

	[Category("Input (Legacy System)")]
	public class GetMouseScrollDelta : ActionTask // TypeDefIndex: 52370
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A95CF84-0x000000018A95CFE4 
	
		// Constructors
		public GetMouseScrollDelta(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95CF7C-0x000000018A95CF84
		protected override void OnUpdate(); // 0x000000018A95CF7C-0x000000018A95CF84
		private void Do(); // 0x000000018A95CEF8-0x000000018A95CF7C
	}

	[Category("Input (Legacy System)")]
	public class WaitMousePick : ActionTask // TypeDefIndex: 52372
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
		protected override string info { get; } // 0x000000018A968A54-0x000000018A968AB8 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 52371
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick(); // 0x0000000184DA6770-0x0000000184DA6790
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A968898-0x000000018A968A54
	}

	[Category("Input (Legacy System)")]
	public class WaitMousePick2D : ActionTask // TypeDefIndex: 52374
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
		protected override string info { get; } // 0x000000018A968834-0x000000018A968898 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 52373
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick2D(); // 0x0000000184DA6770-0x0000000184DA6790
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A9685C4-0x000000018A968834
	}

	[Category("Movement/Direct")]
	[Name("Curve Tween", 0)]
	public class CurveTransformTween : ActionTask<Transform> // TypeDefIndex: 52378
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
		public enum TransformMode // TypeDefIndex: 52375
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}
	
		public enum TweenMode // TypeDefIndex: 52376
		{
			Absolute = 0,
			Additive = 1
		}
	
		public enum PlayMode // TypeDefIndex: 52377
		{
			Normal = 0,
			PingPong = 1
		}
	
		// Constructors
		public CurveTransformTween(); // 0x000000018A954668-0x000000018A954718
	
		// Methods
		protected override void OnExecute(); // 0x000000018A954214-0x000000018A954448
		protected override void OnUpdate(); // 0x000000018A954448-0x000000018A954668
	}

	[Category("Movement/Direct")]
	[Description("Move & turn the agent based on input values provided ranging from -1 to 1, per second (using delta time)")]
	public class InputMove : ActionTask<Transform> // TypeDefIndex: 52379
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
		public InputMove(); // 0x000000018A95F2CC-0x000000018A95F358
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A95ED88-0x000000018A95F2CC
	}

	[Category("Movement/Direct")]
	[Description("Moves the agent away from target per frame without pathfinding")]
	public class MoveAway : ActionTask<Transform> // TypeDefIndex: 52380
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveAway(); // 0x000000018A9620C0-0x000000018A962140
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A961E34-0x000000018A9620C0
	}

	[Category("Movement/Direct")]
	[Description("Moves the agent towards to target per frame without pathfinding")]
	public class MoveTowards : ActionTask<Transform> // TypeDefIndex: 52381
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveTowards(); // 0x000000018A9623C8-0x000000018A962448
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A962140-0x000000018A9623C8
	}

	[Category("Movement/Direct")]
	[Description("Rotate the agent away from target per frame")]
	public class RotateAway : ActionTask<Transform> // TypeDefIndex: 52382
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
		public RotateAway(); // 0x000000018A963920-0x000000018A9639E4
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A963580-0x000000018A963920
	}

	[Category("Movement/Direct")]
	[Description("Rotate the agent towards the target per frame")]
	public class RotateTowards : ActionTask<Transform> // TypeDefIndex: 52383
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
		public RotateTowards(); // 0x000000018A963D60-0x000000018A963E24
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A9639E4-0x000000018A963D60
	}

	[Category("Movement/Pathfinding")]
	[Description("Find the closes Navigation Mesh position to the target position")]
	[Name("Find Closest NavMesh Edge", 0)]
	public class FindClosestEdge : ActionTask // TypeDefIndex: 52384
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		[BlackboardOnly]
		public BBParameter<Vector3> saveFoundPosition; // 0x70
		private NavMeshHit hit; // 0x78
	
		// Constructors
		public FindClosestEdge(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95A03C-0x000000018A95A108
	}

	[Category("Physics")]
	public class GetLinecastInfo : ActionTask<Transform> // TypeDefIndex: 52385
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
		public GetLinecastInfo(); // 0x000000018A95CD38-0x000000018A95CD94
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95CACC-0x000000018A95CD38
		public override void OnDrawGizmosSelected(); // 0x000000018A95C96C-0x000000018A95CACC
	}

	[Category("Physics")]
	public class GetLinecastInfo2D : ActionTask<Transform> // TypeDefIndex: 52386
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
		public GetLinecastInfo2D(); // 0x000000018A95C920-0x000000018A95C96C
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95C640-0x000000018A95C920
		public override void OnDrawGizmosSelected(); // 0x000000018A95C4E0-0x000000018A95C640
	}

	[Category("Physics")]
	[Description("Get hit info for ALL objects in the linecast, in Lists")]
	public class GetLinecastInfo2DAll : ActionTask<Transform> // TypeDefIndex: 52388
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
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52387
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RaycastHit2D, GameObject> __9__7_0; // 0x08
			public static Func<RaycastHit2D, float> __9__7_1; // 0x10
			public static Func<RaycastHit2D, Vector3> __9__7_3; // 0x18
	
			// Constructors
			static __c(); // 0x000000018A968458-0x000000018A9684BC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal GameObject _OnExecute_b__7_0(RaycastHit2D h); // 0x000000018A968228-0x000000018A968250
			internal float _OnExecute_b__7_1(RaycastHit2D h); // 0x0000000184DA6740-0x0000000184DA6750
			internal Vector3 _OnExecute_b__7_3(RaycastHit2D h); // 0x0000000184DA6750-0x0000000184DA6770
		}
	
		// Constructors
		public GetLinecastInfo2DAll(); // 0x000000018A95C494-0x000000018A95C4E0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95BE80-0x000000018A95C3DC
		public override void OnDrawGizmosSelected(); // 0x000000018A95BD20-0x000000018A95BE80
		[CompilerGenerated]
		private Vector3 _OnExecute_b__7_2(RaycastHit2D h); // 0x000000018A95C3DC-0x000000018A95C494
	}

	[Category("Physics")]
	[Description("Gets a lists of game objects that are in the physics overlap sphere at the position of the agent, excluding the agent")]
	public class GetOverlapSphereObjects : ActionTask<Transform> // TypeDefIndex: 52390
	{
		// Fields
		public LayerMask layerMask; // 0x68
		public BBParameter<float> radius; // 0x70
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveObjectsAs; // 0x78
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52389
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ECSColliderResultProxy, GameObject> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A96832C-0x000000018A968390
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal GameObject _OnExecute_b__3_0(ECSColliderResultProxy c); // 0x000000018A9681DC-0x000000018A968228
		}
	
		// Constructors
		public GetOverlapSphereObjects(); // 0x000000018A95D4CC-0x000000018A95D530
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95D230-0x000000018A95D4CC
		public override void OnDrawGizmosSelected(); // 0x000000018A95D130-0x000000018A95D230
	}

	[Category("\u272B Reflected")]
	[Description("Execute a function on a script and save the return if any.\nIf function is an IEnumerator it will execute as a coroutine.")]
	[Name("Execute Function", 10)]
	public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 52392
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
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		public override System.Type agentType { get; } // 0x000000018A955D48-0x000000018A955E0C 
		protected override string info { get; } // 0x000000018A955E0C-0x000000018A95618C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _InternalCoroutine_d__17 : IEnumerator<object> // TypeDefIndex: 52391
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ExecuteFunction_Multiplatform __4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _InternalCoroutine_d__17(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A968048-0x000000018A968130
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A968130-0x000000018A96817C
		}
	
		// Constructors
		public ExecuteFunction_Multiplatform(); // 0x000000018A955CC8-0x000000018A955D48
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A9559C4-0x000000018A9559EC
		protected override string OnInit(); // 0x000000018A95583C-0x000000018A9559C4
		protected override void OnExecute(); // 0x000000018A9555A4-0x000000018A95583C
		protected override void OnStop(); // 0x0000000184DA66E0-0x0000000184DA66F0
		[IteratorStateMachine(typeof(_InternalCoroutine_d__17))]
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x000000018A955530-0x000000018A9555A4
		private void SetMethod(MethodInfo method); // 0x000000018A9559EC-0x000000018A955CC8
	}

	internal class GetField_0 // TypeDefIndex: 52393
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string fieldName; // 0x18
	
		// Constructors
		public GetField_0(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("\u272B Reflected")]
	[Description("Get a variable of a script and save it to the blackboard")]
	[fsMigrateVersions(new System.Type[1] {typeof(GetField_0) })]
	[Name("Get Field", 6)]
	public class GetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.GetField_0> // TypeDefIndex: 52394
	{
		// Fields
		[SerializeField]
		protected SerializedFieldInfo field; // 0x68
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter saveAs; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get; } // 0x00000001892C37DC-0x00000001892C37EC 
		public override System.Type agentType { get; } // 0x000000018A95B5E8-0x000000018A95B6B8 
		protected override string info { get; } // 0x000000018A95B6B8-0x000000018A95B828 
	
		// Constructors
		public GetField(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		void IMigratable<GetField_0>.Migrate(GetField_0 model); // 0x000000018A95B480-0x000000018A95B538
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		protected override string OnInit(); // 0x000000018A95B3E8-0x000000018A95B480
		protected override void OnExecute(); // 0x000000018A95B330-0x000000018A95B3E8
		private void SetTargetField(System.Reflection.FieldInfo newField); // 0x000000018A95B538-0x000000018A95B5E8
	}

	[Category("\u272B Reflected")]
	[Description("Get a property of a script and save it to the blackboard")]
	[Name("Get Property", 8)]
	public class GetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 52395
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter returnValue; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		public override System.Type agentType { get; } // 0x000000018A95D74C-0x000000018A95D810 
		protected override string info { get; } // 0x000000018A95D810-0x000000018A95D974 
	
		// Constructors
		public GetProperty_Multiplatform(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A95D674-0x000000018A95D69C
		protected override string OnInit(); // 0x000000018A95D5EC-0x000000018A95D674
		protected override void OnExecute(); // 0x000000018A95D530-0x000000018A95D5EC
		private void SetMethod(MethodInfo method); // 0x000000018A95D69C-0x000000018A95D74C
	}

	[Category("\u272B Reflected")]
	[Description("Calls a function that has signature of \'public Status NAME()\' or \'public Status NAME(T)\'. You should return Status.Success, Failure or Running within that function.")]
	[Name("Implemented Action", 9)]
	public class ImplementedAction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 52396
	{
		// Fields
		[SerializeField]
		private SerializedMethodInfo method; // 0x68
		[SerializeField]
		private List<BBObjectParameter> parameters; // 0x70
		private NodeCanvas.Framework.Status actionStatus; // 0x78
		private object[] args; // 0x80
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		public override System.Type agentType { get; } // 0x000000018A95E6FC-0x000000018A95E7C0 
		protected override string info { get; } // 0x000000018A95E7C0-0x000000018A95E978 
	
		// Constructors
		public ImplementedAction_Multiplatform(); // 0x000000018A95E678-0x000000018A95E6FC
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A95E4D8-0x000000018A95E500
		protected override string OnInit(); // 0x000000018A95E290-0x000000018A95E374
		protected override void OnUpdate(); // 0x000000018A95E374-0x000000018A95E4D8
		protected override void OnStop(); // 0x0000000184DA6700-0x0000000184DA6710
		private void SetMethod(MethodInfo method); // 0x000000018A95E500-0x000000018A95E678
	}

	[Category("\u272B Reflected")]
	[Description("SendMessage to the agent, optionaly with an argument")]
	public class SendMessage : ActionTask<Transform> // TypeDefIndex: 52397
	{
		// Fields
		[RequiredField]
		public BBParameter<string> methodName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A964A14-0x000000018A964A54 
	
		// Constructors
		public SendMessage(); // 0x000000018A9649D8-0x000000018A964A14
	
		// Methods
		protected override void OnExecute(); // 0x000000018A96494C-0x000000018A9649D8
	}

	[Category("\u272B Reflected")]
	[Description("SendMessage to the agent, optionaly with an argument")]
	public class SendMessage<T> : ActionTask<Transform> // TypeDefIndex: 52398
	{
		// Fields
		[RequiredField]
		public BBParameter<string> methodName;
		public BBParameter<T> argument;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendMessage();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Reflected")]
	[Description("Send a Unity message to all game objects with a component of the specified type.\nNotice: This is slow and should not be called per-fame.")]
	public class SendMessageToType<T> : ActionTask // TypeDefIndex: 52399
		where T : Component
	{
		// Fields
		[RequiredField]
		public BBParameter<string> message;
		[BlackboardOnly]
		public BBParameter<object> argument;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendMessageToType();
	
		// Methods
		protected override void OnExecute();
	}

	internal class SetField_0 // TypeDefIndex: 52400
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string fieldName; // 0x18
	
		// Constructors
		public SetField_0(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("\u272B Reflected")]
	[Description("Set a variable on a script")]
	[fsMigrateVersions(new System.Type[1] {typeof(SetField_0) })]
	[Name("Set Field", 5)]
	public class SetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.SetField_0> // TypeDefIndex: 52401
	{
		// Fields
		[SerializeField]
		protected SerializedFieldInfo field; // 0x68
		[SerializeField]
		protected BBObjectParameter setValue; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get; } // 0x00000001892C37DC-0x00000001892C37EC 
		public override System.Type agentType { get; } // 0x000000018A965170-0x000000018A965240 
		protected override string info { get; } // 0x000000018A965240-0x000000018A965390 
	
		// Constructors
		public SetField(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		void IMigratable<SetField_0>.Migrate(SetField_0 model); // 0x000000018A965008-0x000000018A9650C0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		protected override string OnInit(); // 0x000000018A964F70-0x000000018A965008
		protected override void OnExecute(); // 0x000000018A964EB8-0x000000018A964F70
		private void SetTargetField(System.Reflection.FieldInfo newField); // 0x000000018A9650C0-0x000000018A965170
	}

	[Category("\u272B Reflected")]
	[Description("Set a property on a script")]
	[Name("Set Property", 7)]
	public class SetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 52402
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected BBObjectParameter parameter; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		public override System.Type agentType { get; } // 0x000000018A96632C-0x000000018A9663F0 
		protected override string info { get; } // 0x000000018A9663F0-0x000000018A966554 
	
		// Constructors
		public SetProperty_Multiplatform(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A966238-0x000000018A966260
		protected override string OnInit(); // 0x000000018A9661B0-0x000000018A966238
		protected override void OnExecute(); // 0x000000018A9660C4-0x000000018A9661B0
		private void SetMethod(MethodInfo method); // 0x000000018A966260-0x000000018A96632C
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nExecute a function on a script, of up to 6 parameters and save the return if any. If function is an IEnumerator it will execute as a coroutine.")]
	[Name("Execute Function (Desktop Only)", 10)]
	public class ExecuteFunction : ActionTask, IReflectedWrapper // TypeDefIndex: 52404
	{
		// Fields
		[SerializeField]
		protected ReflectedWrapper functionWrapper; // 0x68
		private bool routineRunning; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		public override System.Type agentType { get; } // 0x000000018A956598-0x000000018A95665C 
		protected override string info { get; } // 0x000000018A95665C-0x000000018A956AB4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _InternalCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 52403
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ExecuteFunction __4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _InternalCoroutine_d__13(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A967F28-0x000000018A967FFC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A967FFC-0x000000018A968048
		}
	
		// Constructors
		public ExecuteFunction(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018A95618C-0x000000018A95619C
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A9564F8-0x000000018A956544
		protected override string OnInit(); // 0x000000018A95639C-0x000000018A9564F8
		protected override void OnExecute(); // 0x000000018A95619C-0x000000018A95639C
		protected override void OnStop(); // 0x0000000184DA61D0-0x0000000184DA61E0
		[IteratorStateMachine(typeof(_InternalCoroutine_d__13))]
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x000000018A9554BC-0x000000018A955530
		private void SetMethod(MethodInfo method); // 0x000000018A956544-0x000000018A956598
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nGet a property of a script and save it to the blackboard")]
	[Name("Get Property (Desktop Only)", 8)]
	public class GetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 52405
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		public override System.Type agentType { get; } // 0x000000018A95DB6C-0x000000018A95DC30 
		protected override string info { get; } // 0x000000018A95DC30-0x000000018A95DDA0 
	
		// Constructors
		public GetProperty(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018A95618C-0x000000018A95619C
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A95DACC-0x000000018A95DB18
		protected override string OnInit(); // 0x000000018A95D9B0-0x000000018A95DACC
		protected override void OnExecute(); // 0x000000018A95D974-0x000000018A95D9B0
		private void SetMethod(MethodInfo method); // 0x000000018A95DB18-0x000000018A95DB6C
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCalls a function that has signature of \'public Status NAME()\' or \'public Status NAME(T)\'. You should return Status.Success, Failure or Running within that function.")]
	[Name("Implemented Action (Desktop Only)", 9)]
	public class ImplementedAction : ActionTask, IReflectedWrapper // TypeDefIndex: 52406
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		private NodeCanvas.Framework.Status actionStatus; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		public override System.Type agentType { get; } // 0x000000018A95EB04-0x000000018A95EBC8 
		protected override string info { get; } // 0x000000018A95EBC8-0x000000018A95ED88 
	
		// Constructors
		public ImplementedAction(); // 0x0000000184DA6720-0x0000000184DA6730
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018A95618C-0x000000018A95619C
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A95DACC-0x000000018A95DB18
		protected override string OnInit(); // 0x000000018A95E978-0x000000018A95EA94
		protected override void OnUpdate(); // 0x000000018A95EA94-0x000000018A95EB04
		protected override void OnStop(); // 0x0000000184DA6710-0x0000000184DA6720
		private void SetMethod(MethodInfo method); // 0x000000018A95DB18-0x000000018A95DB6C
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nSet a property on a script.")]
	[Name("Set Property (Desktop Only)", 7)]
	public class SetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 52407
	{
		// Fields
		[SerializeField]
		protected ReflectedActionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		public override System.Type agentType { get; } // 0x000000018A96674C-0x000000018A966810 
		protected override string info { get; } // 0x000000018A966810-0x000000018A966980 
	
		// Constructors
		public SetProperty(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018A95618C-0x000000018A95619C
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A9666AC-0x000000018A9666F8
		protected override string OnInit(); // 0x000000018A966590-0x000000018A9666AC
		protected override void OnExecute(); // 0x000000018A966554-0x000000018A966590
		private void SetMethod(MethodInfo method); // 0x000000018A9666F8-0x000000018A96674C
	}

	[Category("\u272B Utility")]
	[Description("Plays a \'Beep\' in editor only")]
	public class DebugBeep : ActionTask // TypeDefIndex: 52408
	{
		// Constructors
		public DebugBeep(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A954718-0x000000018A954724
	}

	[Category("\u272B Utility")]
	public class DebugDrawLine : ActionTask // TypeDefIndex: 52409
	{
		// Fields
		public BBParameter<Vector3> from; // 0x68
		public BBParameter<Vector3> to; // 0x70
		public UnityEngine.Color color; // 0x78
		public float timeToShow; // 0x88
	
		// Constructors
		public DebugDrawLine(); // 0x000000018A95482C-0x000000018A95485C
	
		// Methods
		protected override void OnExecute(); // 0x000000018A954724-0x000000018A95482C
	}

	[Category("\u272B Utility")]
	[Description("Display a UI label on the agent\'s position if seconds to run is not 0 and also logs the message, which can also be mapped to any variable.")]
	[Name("Debug Log", 0)]
	public class DebugLogText : ActionTask<Transform> // TypeDefIndex: 52412
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
		protected override string info { get; } // 0x000000018A954E2C-0x000000018A954EFC 
	
		// Nested types
		public enum LogMode // TypeDefIndex: 52410
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}
	
		public enum VerboseMode // TypeDefIndex: 52411
		{
			LogAndDisplayLabel = 0,
			LogOnly = 1,
			DisplayLabelOnly = 2
		}
	
		// Constructors
		public DebugLogText(); // 0x000000018A954DB0-0x000000018A954E2C
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95485C-0x000000018A9549A4
		protected override void OnStop(); // 0x000000018A954CCC-0x000000018A954D7C
		protected override void OnUpdate(); // 0x000000018A954D7C-0x000000018A954DB0
		private void OnGUI(); // 0x000000018A9549A4-0x000000018A954CCC
	}

	[Category("\u272B Utility")]
	[Description("Logs the value of a variable in the console")]
	[Obsolete("Use Debug Log Text")]
	public class DebugLogVariable : ActionTask // TypeDefIndex: 52413
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> log; // 0x68
		public BBParameter<string> prefix; // 0x70
		public float secondsToRun; // 0x78
		public CompactStatus finishStatus; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x000000018A954F2C-0x000000018A955020 
	
		// Constructors
		public DebugLogVariable(); // 0x0000000184DA66C0-0x0000000184DA66E0
	
		// Methods
		protected override void OnExecute(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnUpdate(); // 0x000000018A954EFC-0x000000018A954F2C
	}

	[Category("\u272B Utility")]
	[Description("Force Finish the current graph this Task is assigned to.")]
	public class ForceFinishGraph : ActionTask // TypeDefIndex: 52414
	{
		// Fields
		public CompactStatus finishStatus; // 0x68
	
		// Constructors
		public ForceFinishGraph(); // 0x0000000184DA66F0-0x0000000184DA6700
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95A67C-0x000000018A95A71C
	}

	[Category("\u272B Utility")]
	[Description("Start, Resume, Pause, Stop a GraphOwner\'s behaviour")]
	[Name("Control Graph Owner", 0)]
	public class GraphOwnerControl : ActionTask<GraphOwner> // TypeDefIndex: 52417
	{
		// Fields
		public Control control; // 0x68
		public bool waitActionFinish; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x000000018A95E208-0x000000018A95E290 
	
		// Nested types
		public enum Control // TypeDefIndex: 52415
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		[CompilerGenerated]
		private sealed class _YieldDo_d__6 : IEnumerator<object> // TypeDefIndex: 52416
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GraphOwnerControl __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _YieldDo_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A968520-0x000000018A968578
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A968578-0x000000018A9685C4
		}
	
		// Constructors
		public GraphOwnerControl(); // 0x000000018A95E1C4-0x000000018A95E208
	
		// Methods
		protected override void OnExecute(); // 0x000000018A95DFC4-0x000000018A95E100
		[IteratorStateMachine(typeof(_YieldDo_d__6))]
		private IEnumerator YieldDo(); // 0x000000018A95E168-0x000000018A95E1C4
		private void Do(); // 0x000000018A95DF20-0x000000018A95DFC4
		protected override void OnStop(); // 0x000000018A95E100-0x000000018A95E160
		[CompilerGenerated]
		private void _OnExecute_b__5_0(bool s); // 0x000000018A95E160-0x000000018A95E168
	}

	[Category("\u272B Utility")]
	[Description("An action that will simply run forever and never finish")]
	public class RunForever : ActionTask // TypeDefIndex: 52418
	{
		// Constructors
		public RunForever(); // 0x0000000184D8E030-0x0000000184D8E040
	}

	[Category("\u272B Utility")]
	[Description("Send a graph event. If global is true, all graph owners in scene will receive this event. Use along with the \'Check Event\' Condition")]
	public class SendEvent : ActionTask<GraphOwner> // TypeDefIndex: 52419
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> delay; // 0x70
		public bool sendGlobal; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A9647B8-0x000000018A96494C 
	
		// Constructors
		public SendEvent(); // 0x000000018A96477C-0x000000018A9647B8
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A964658-0x000000018A96477C
	}

	[Category("\u272B Utility")]
	[Description("Send a graph event with T value. If global is true, all graph owners in scene will receive this event. Use along with the \'Check Event\' Condition")]
	public class SendEvent<T> : ActionTask<GraphOwner> // TypeDefIndex: 52420
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
		public BBParameter<float> delay;
		public bool sendGlobal;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendEvent();
	
		// Methods
		protected override void OnUpdate();
	}

	[Category("\u272B Utility")]
	[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
	public class SendEventToObjects : ActionTask // TypeDefIndex: 52421
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		[RequiredField]
		public BBParameter<string> eventName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A964614-0x000000018A964658 
	
		// Constructors
		public SendEventToObjects(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		protected override void OnExecute(); // 0x000000018A9643FC-0x000000018A964614
	}

	[Category("\u272B Utility")]
	[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
	public class SendEventToObjects<T> : ActionTask // TypeDefIndex: 52422
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> targetObjects;
		[RequiredField]
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendEventToObjects();
	
		// Methods
		protected override void OnExecute();
	}

	[Category("\u272B Utility")]
	[Description("Sends an event to all GraphOwners within range of the agent and over time like a shockwave.")]
	public class ShoutEvent : ActionTask<Transform> // TypeDefIndex: 52423
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
		protected override string info { get; } // 0x000000018A9670B0-0x000000018A967108 
	
		// Constructors
		public ShoutEvent(); // 0x000000018A967030-0x000000018A9670B0
	
		// Methods
		protected override void OnExecute(); // 0x000000018A966D28-0x000000018A966DCC
		protected override void OnUpdate(); // 0x000000018A966DCC-0x000000018A967030
		public override void OnDrawGizmosSelected(); // 0x000000018A966BD8-0x000000018A966D28
	}

	[Category("\u272B Utility")]
	[Description("Switch the entire Behaviour Tree of BehaviourTreeOwner")]
	public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner> // TypeDefIndex: 52424
	{
		// Fields
		[RequiredField]
		public BBParameter<BehaviourTree> behaviourTree; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A9678EC-0x000000018A96792C 
	
		// Constructors
		public SwitchBehaviourTree(); // 0x000000018A9678B0-0x000000018A9678EC
	
		// Methods
		protected override void OnExecute(); // 0x000000018A967814-0x000000018A9678B0
	}

	[Category("\u272B Utility")]
	[Description("Switch the entire FSM of FSMTreeOwner")]
	public class SwitchFSM : ActionTask<FSMOwner> // TypeDefIndex: 52425
	{
		// Fields
		[RequiredField]
		public BBParameter<FSM> fsm; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A967A04-0x000000018A967A44 
	
		// Constructors
		public SwitchFSM(); // 0x000000018A9679C8-0x000000018A967A04
	
		// Methods
		protected override void OnExecute(); // 0x000000018A96792C-0x000000018A9679C8
	}

	[Category("\u272B Utility")]
	public class Wait : ActionTask // TypeDefIndex: 52426
	{
		// Fields
		public BBParameter<float> waitTime; // 0x68
		public CompactStatus finishStatus; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A968B88-0x000000018A968DB0 
	
		// Constructors
		public Wait(); // 0x000000018A968B2C-0x000000018A968B88
	
		// Methods
		protected override void OnUpdate(); // 0x000000018A968AB8-0x000000018A968B2C
	}

	[Category("GameObject")]
	[Description("Checks the current speed of the agent against a value based on it\'s Rigidbody velocity")]
	public class CheckSpeed : ConditionTask<Rigidbody> // TypeDefIndex: 52427
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<float> value; // 0x70
		[SliderField(0f, 0.1f)]
		public float differenceThreshold; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A953718-0x000000018A953794 
	
		// Constructors
		public CheckSpeed(); // 0x000000018A9536CC-0x000000018A953718
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A953614-0x000000018A9536CC
	}

	[Obsolete("Execute Function now supports static functions as well")]
	public class ExecuteStaticFunction : ActionTask, ISubParametersContainer // TypeDefIndex: 52428
	{
		// Fields
		[SerializeField]
		protected ReflectedWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		protected override string info { get; } // 0x000000018A9574D4-0x000000018A95786C 
	
		// Constructors
		public ExecuteStaticFunction(); // 0x0000000184D8E030-0x0000000184D8E040
	
		// Methods
		BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x000000018A9572F0-0x000000018A957310
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A9564F8-0x000000018A956544
		protected override string OnInit(); // 0x000000018A9573F4-0x000000018A9574D4
		protected override void OnExecute(); // 0x000000018A957310-0x000000018A9573F4
		private void SetMethod(MethodInfo method); // 0x000000018A956544-0x000000018A956598
	}

	[Obsolete("Execute Function now supports static functions as well")]
	public class ExecuteStaticFunction_Multiplatform : ActionTask // TypeDefIndex: 52430
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
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		protected override string info { get; } // 0x000000018A956FDC-0x000000018A9572F0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52429
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<BBObjectParameter, object> __9__9_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A9683F4-0x000000018A968458
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _OnExecute_b__9_0(BBObjectParameter p); // 0x000000018A968250-0x000000018A968294
		}
	
		// Constructors
		public ExecuteStaticFunction_Multiplatform(); // 0x000000018A956F5C-0x000000018A956FDC
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A956CD4-0x000000018A956CFC
		protected override string OnInit(); // 0x000000018A956C4C-0x000000018A956CD4
		protected override void OnExecute(); // 0x000000018A956AB4-0x000000018A956C4C
		private void SetMethod(MethodInfo method); // 0x000000018A956CFC-0x000000018A956F5C
	}
}

namespace NodeCanvas.Tasks.Conditions
{
	[Category("\u272B Utility")]
	[Description("Invoke a defined Signal with agent as the target and optionally global.")]
	public class InvokeSignal : ActionTask<Transform> // TypeDefIndex: 52205
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		public bool global; // 0x70
		[SerializeField]
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x78
		private object[] args; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A94BFE8-0x000000018A94C00C 
	
		// Constructors
		public InvokeSignal(); // 0x000000018A94BF5C-0x000000018A94BFE8
	
		// Methods
		protected override string OnInit(); // 0x000000018A94BEC4-0x000000018A94BF5C
		protected override void OnExecute(); // 0x000000018A94BD10-0x000000018A94BEC4
	}

	[Category("Animator")]
	[Name("Check Parameter Bool", 0)]
	public class MecanimCheckBool : ConditionTask<Animator> // TypeDefIndex: 52206
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public BBParameter<bool> value; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A94E800-0x000000018A94E8A4 
	
		// Constructors
		public MecanimCheckBool(); // 0x000000018A94E7C4-0x000000018A94E800
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94E718-0x000000018A94E7C4
	}

	[Category("Animator")]
	[Name("Check Parameter Float", 0)]
	public class MecanimCheckFloat : ConditionTask<Animator> // TypeDefIndex: 52207
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<float> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A94E9AC-0x000000018A94EA48 
	
		// Constructors
		public MecanimCheckFloat(); // 0x000000018A94E970-0x000000018A94E9AC
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94E8A4-0x000000018A94E970
	}

	[Category("Animator")]
	[Name("Check Parameter Int", 0)]
	public class MecanimCheckInt : ConditionTask<Animator> // TypeDefIndex: 52208
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<int> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A94EB38-0x000000018A94EBD4 
	
		// Constructors
		public MecanimCheckInt(); // 0x000000018A94EAFC-0x000000018A94EB38
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94EA48-0x000000018A94EAFC
	}

	[Category("Animator")]
	[Name("Is In Transition", 0)]
	public class MecanimIsInTransition : ConditionTask<Animator> // TypeDefIndex: 52209
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A94EC90-0x000000018A94ECBC 
	
		// Constructors
		public MecanimIsInTransition(); // 0x000000018A94EC54-0x000000018A94EC90
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94EBD4-0x000000018A94EC54
	}

	[Category("\u272B Blackboard")]
	public class CheckBoolean : ConditionTask // TypeDefIndex: 52210
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> valueA; // 0x68
		public BBParameter<bool> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A94147C-0x000000018A941504 
	
		// Constructors
		public CheckBoolean(); // 0x000000018A94142C-0x000000018A94147C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9413C0-0x000000018A94142C
	}

	[Category("\u272B Blackboard")]
	[Description("Check if a boolean variable is true and if so, it is immediately reset to false.")]
	public class CheckBooleanTrigger : ConditionTask // TypeDefIndex: 52211
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> trigger; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A941380-0x000000018A9413C0 
	
		// Constructors
		public CheckBooleanTrigger(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94130C-0x000000018A941380
	}

	[Category("\u272B Blackboard")]
	public class CheckEnum : ConditionTask // TypeDefIndex: 52212
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A944BA4-0x000000018A944C2C 
	
		// Constructors
		public CheckEnum(); // 0x000000018A944AB4-0x000000018A944BA4
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A944A40-0x000000018A944AB4
	}

	[Category("\u272B Blackboard")]
	public class CheckFloat : ConditionTask // TypeDefIndex: 52213
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> valueB; // 0x78
		[SliderField(0f, 0.1f)]
		public float differenceThreshold; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A9454E0-0x000000018A94555C 
	
		// Constructors
		public CheckFloat(); // 0x0000000184DA6540-0x0000000184DA6560
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A945458-0x000000018A9454E0
	}

	[Category("\u272B Blackboard")]
	public class CheckInt : ConditionTask // TypeDefIndex: 52214
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<int> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A9454E0-0x000000018A94555C 
	
		// Constructors
		public CheckInt(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9468CC-0x000000018A946944
	}

	[Category("\u272B Blackboard")]
	[Description("Check whether or not a variable is null")]
	public class CheckNull : ConditionTask // TypeDefIndex: 52215
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> variable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A948830-0x000000018A94888C 
	
		// Constructors
		public CheckNull(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9487E4-0x000000018A948830
	}

	[Category("\u272B Blackboard")]
	public class CheckString : ConditionTask // TypeDefIndex: 52216
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<string> valueA; // 0x68
		public BBParameter<string> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A949490-0x000000018A949518 
	
		// Constructors
		public CheckString(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94941C-0x000000018A949490
	}

	[Category("\u272B Blackboard")]
	[Obsolete("Use CheckVariable(T)")]
	public class CheckUnityObject : ConditionTask // TypeDefIndex: 52217
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<UnityEngine.Object> valueA; // 0x68
		public BBParameter<UnityEngine.Object> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A94A8E8-0x000000018A94A970 
	
		// Constructors
		public CheckUnityObject(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94A858-0x000000018A94A8E8
	}

	[Category("\u272B Blackboard")]
	[Description("It\'s best to use the respective Condition for a type if existant since they support operations as well")]
	public class CheckVariable<T> : ConditionTask // TypeDefIndex: 52218
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<T> valueA;
		public BBParameter<T> valueB;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckVariable();
	
		// Methods
		protected override bool OnCheck();
	}

	[Category("\u272B Blackboard")]
	public class CheckVectorDistance : ConditionTask // TypeDefIndex: 52219
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> vectorA; // 0x68
		[BlackboardOnly]
		public BBParameter<Vector3> vectorB; // 0x70
		public CompareMethod comparison; // 0x78
		public BBParameter<float> distance; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A94AA60-0x000000018A94AB60 
	
		// Constructors
		public CheckVectorDistance(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94A970-0x000000018A94AA60
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class TryGetValue<T> : ConditionTask // TypeDefIndex: 52220
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
		protected override string info { get; }
	
		// Constructors
		public TryGetValue();
	
		// Methods
		protected override bool OnCheck();
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Check if an element is contained in the target list")]
	public class ListContainsElement<T> : ConditionTask // TypeDefIndex: 52221
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<T>> targetList;
		public BBParameter<T> checkElement;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public ListContainsElement();
	
		// Methods
		protected override bool OnCheck();
	}

	[Category("\u272B Blackboard/Lists")]
	public class ListIsEmpty : ConditionTask // TypeDefIndex: 52222
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A94CA0C-0x000000018A94CA4C 
	
		// Constructors
		public ListIsEmpty(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94C9B0-0x000000018A94CA0C
	}

	[Category("\u272B Blackboard")]
	[Name("On Variable Changed", 0)]
	public class BBVariableChanged : ConditionTask // TypeDefIndex: 52223
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter targetVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A93D42C-0x000000018A93D488 
	
		// Constructors
		public BBVariableChanged(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override string OnInit(); // 0x000000018A93D3CC-0x000000018A93D41C
		protected override void OnEnable(); // 0x000000018A93D334-0x000000018A93D3CC
		protected override void OnDisable(); // 0x000000018A93D29C-0x000000018A93D334
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void OnValueChanged(object varValue); // 0x000000018A93D41C-0x000000018A93D42C
	}

	[Category("\u272B Blackboard")]
	public class StringContains : ConditionTask // TypeDefIndex: 52224
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<string> targetString; // 0x68
		public BBParameter<string> checkString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A951F54-0x000000018A951F98 
	
		// Constructors
		public StringContains(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A951ED8-0x000000018A951F54
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget : ConditionTask<Transform> // TypeDefIndex: 52225
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
		protected override string info { get; } // 0x000000018A9412AC-0x000000018A94130C 
	
		// Constructors
		public CanSeeTarget(); // 0x000000018A9411DC-0x000000018A9412AC
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9406AC-0x000000018A940BBC
		public override void OnDrawGizmosSelected(); // 0x000000018A940BBC-0x000000018A9411DC
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget2D : ConditionTask<Transform> // TypeDefIndex: 52226
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
		protected override string info { get; } // 0x000000018A93E068-0x000000018A93E0C8 
	
		// Constructors
		public CanSeeTarget2D(); // 0x000000018A93DF98-0x000000018A93E068
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A93D488-0x000000018A93D914
		public override void OnDrawGizmosSelected(); // 0x000000018A93D914-0x000000018A93DF98
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTargetAny : ConditionTask<Transform> // TypeDefIndex: 52227
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
		protected override string info { get; } // 0x000000018A94064C-0x000000018A9406AC 
	
		// Constructors
		public CanSeeTargetAny(); // 0x000000018A94057C-0x000000018A94064C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A93F350-0x000000018A93FE9C
		public override void OnDrawGizmosSelected(); // 0x000000018A93FE9C-0x000000018A9404BC
		[CompilerGenerated]
		private float _OnCheck_b__11_0(GameObject x); // 0x000000018A9404BC-0x000000018A94057C
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTargetAny2D : ConditionTask<Transform> // TypeDefIndex: 52228
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
		protected override string info { get; } // 0x000000018A93F2F0-0x000000018A93F350 
	
		// Constructors
		public CanSeeTargetAny2D(); // 0x000000018A93F220-0x000000018A93F2F0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A93E0C8-0x000000018A93EB00
		public override void OnDrawGizmosSelected(); // 0x000000018A93EB00-0x000000018A93F160
		[CompilerGenerated]
		private float _OnCheck_b__10_0(GameObject x); // 0x000000018A93F160-0x000000018A93F220
	}

	[Category("GameObject")]
	[Name("Target Within Distance", 0)]
	public class CheckDistanceToGameObject : ConditionTask<Transform> // TypeDefIndex: 52229
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A944934-0x000000018A944A40 
	
		// Constructors
		public CheckDistanceToGameObject(); // 0x000000018A9448C4-0x000000018A944934
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9446B0-0x000000018A9447DC
		public override void OnDrawGizmosSelected(); // 0x000000018A9447DC-0x000000018A9448C4
	}

	[Category("GameObject")]
	[Name("Target Within Distance 2D", 0)]
	public class CheckDistanceToGameObject2D : ConditionTask<Transform> // TypeDefIndex: 52230
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018A943584-0x000000018A943690 
	
		// Constructors
		public CheckDistanceToGameObject2D(); // 0x000000018A943514-0x000000018A943584
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9432C4-0x000000018A943400
		public override void OnDrawGizmosSelected(); // 0x000000018A943400-0x000000018A943514
	}

	[Category("GameObject")]
	[Name("Any Target Within Distance", 0)]
	public class CheckDistanceToGameObjectAny : ConditionTask<Transform> // TypeDefIndex: 52231
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
		protected override string info { get; } // 0x000000018A9445A4-0x000000018A9446B0 
	
		// Constructors
		public CheckDistanceToGameObjectAny(); // 0x000000018A944534-0x000000018A9445A4
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A943ECC-0x000000018A94438C
		public override void OnDrawGizmosSelected(); // 0x000000018A94438C-0x000000018A944474
		[CompilerGenerated]
		private float _OnCheck_b__8_0(GameObject x); // 0x000000018A944474-0x000000018A944534
	}

	[Category("GameObject")]
	[Name("Any Target Within Distance 2D", 0)]
	public class CheckDistanceToGameObjectAny2D : ConditionTask<Transform> // TypeDefIndex: 52232
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
		protected override string info { get; } // 0x000000018A943DC0-0x000000018A943ECC 
	
		// Constructors
		public CheckDistanceToGameObjectAny2D(); // 0x000000018A943D50-0x000000018A943DC0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A943690-0x000000018A943B60
		public override void OnDrawGizmosSelected(); // 0x000000018A943B60-0x000000018A943C74
		[CompilerGenerated]
		private float _OnCheck_b__8_0(GameObject x); // 0x000000018A943C74-0x000000018A943D50
	}

	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	[Name("Target In Line Of Sight", 0)]
	public class CheckLOS : ConditionTask<Transform> // TypeDefIndex: 52233
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
		protected override string info { get; } // 0x000000018A947590-0x000000018A9475E8 
	
		// Constructors
		public CheckLOS(); // 0x000000018A947538-0x000000018A947590
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9470B8-0x000000018A947368
		public override void OnDrawGizmosSelected(); // 0x000000018A947368-0x000000018A947538
	}

	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	[Name("Target In Line Of Sight 2D", 0)]
	public class CheckLOS2D : ConditionTask<Transform> // TypeDefIndex: 52235
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
		protected override string info { get; } // 0x000000018A947060-0x000000018A9470B8 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52234
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RaycastHit2D, Collider2D> __9__7_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A952E28-0x000000018A952E8C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Collider2D _OnCheck_b__7_0(RaycastHit2D h); // 0x000000018A9526DC-0x000000018A9526F0
		}
	
		// Constructors
		public CheckLOS2D(); // 0x000000018A947008-0x000000018A947060
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A946A28-0x000000018A946E5C
		public override void OnDrawGizmosSelected(); // 0x000000018A946E5C-0x000000018A947008
	}

	[Category("GameObject")]
	public class HasComponent<T> : ConditionTask<Transform> // TypeDefIndex: 52236
		where T : Component
	{
		// Constructors
		public HasComponent();
	
		// Methods
		protected override bool OnCheck();
	}

	[Category("GameObject")]
	public class IsActive : ConditionTask<Transform> // TypeDefIndex: 52237
	{
		// Properties
		protected override string info { get; } // 0x000000018A94C0A8-0x000000018A94C0F0 
	
		// Constructors
		public IsActive(); // 0x000000018A94C06C-0x000000018A94C0A8
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94C00C-0x000000018A94C06C
	}

	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	[Name("Target In View Angle", 0)]
	public class IsInFront : ConditionTask<Transform> // TypeDefIndex: 52238
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A94C890-0x000000018A94C8EC 
	
		// Constructors
		public IsInFront(); // 0x000000018A94C834-0x000000018A94C890
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94C500-0x000000018A94C670
		public override void OnDrawGizmosSelected(); // 0x000000018A94C670-0x000000018A94C834
	}

	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	[Name("Target In View Angle 2D", 0)]
	public class IsInFront2D : ConditionTask<Transform> // TypeDefIndex: 52239
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A94C4A4-0x000000018A94C500 
	
		// Constructors
		public IsInFront2D(); // 0x000000018A94C448-0x000000018A94C4A4
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94C0F0-0x000000018A94C268
		public override void OnDrawGizmosSelected(); // 0x000000018A94C268-0x000000018A94C448
	}

	[Category("GameObject")]
	public class IsWithinLayerMask : ConditionTask<Transform> // TypeDefIndex: 52240
	{
		// Fields
		public BBParameter<LayerMask> targetLayers; // 0x68
	
		// Constructors
		public IsWithinLayerMask(); // 0x000000018A94C974-0x000000018A94C9B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A94C8EC-0x000000018A94C974
	}

	[Category("Input (Legacy System)")]
	public class CheckButtonInput : ConditionTask // TypeDefIndex: 52241
	{
		// Fields
		public PressTypes pressType; // 0x68
		[RequiredField]
		public BBParameter<string> buttonName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A941614-0x000000018A9416AC 
	
		// Constructors
		public CheckButtonInput(); // 0x000000018A9415B8-0x000000018A941614
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A941504-0x000000018A9415B8
	}

	[Category("Input (Legacy System)")]
	public class CheckKeyboardInput : ConditionTask // TypeDefIndex: 52242
	{
		// Fields
		public PressTypes pressType; // 0x68
		public KeyCode key; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x000000018A946978-0x000000018A946A28 
	
		// Constructors
		public CheckKeyboardInput(); // 0x0000000184DA6560-0x0000000184DA6570
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A946944-0x000000018A946978
	}

	[Category("Input (Legacy System)")]
	public class CheckMousePick : ConditionTask // TypeDefIndex: 52243
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
		protected override string info { get; } // 0x000000018A9483A0-0x000000018A9484B8 
	
		// Constructors
		public CheckMousePick(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9481E8-0x000000018A9483A0
	}

	[Category("Input (Legacy System)")]
	public class CheckMousePick2D : ConditionTask // TypeDefIndex: 52244
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
		protected override string info { get; } // 0x000000018A9480A0-0x000000018A9481E8 
	
		// Constructors
		public CheckMousePick2D(); // 0x0000000184DA6570-0x0000000184DA6590
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A947E38-0x000000018A9480A0
	}

	internal class CheckCSharpEvent_0 // TypeDefIndex: 52245
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckCSharpEvent_0(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class CheckCSharpEvent_0<T> // TypeDefIndex: 52246
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckCSharpEvent_0();
	}

	internal class CheckCSharpEventValue_0<T> // TypeDefIndex: 52247
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckCSharpEventValue_0();
	}

	[fsMigrateTo(typeof(CheckCSharpEvent))]
	internal class CheckStaticCSharpEvent // TypeDefIndex: 52248
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckStaticCSharpEvent(); // 0x00000001841E1670-0x00000001841E1680
	}

	[fsMigrateTo(typeof(CheckCSharpEvent<T>))]
	internal class CheckStaticCSharpEvent<T> // TypeDefIndex: 52249
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckStaticCSharpEvent();
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action type and return true when the event is raised.\n(eg public event System.Action [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEvent_0) })]
	public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent> // TypeDefIndex: 52250
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo; // 0x68
		private Delegate handler; // 0x70
	
		// Properties
		private EventInfo targetEvent { get; } // 0x00000001892C37DC-0x00000001892C37EC 
		public override System.Type agentType { get; } // 0x000000018A941B24-0x000000018A941BF8 
		protected override string info { get; } // 0x000000018A941BF8-0x000000018A941CD0 
	
		// Constructors
		public CheckCSharpEvent(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		void IMigratable<CheckCSharpEvent_0>.Migrate(CheckCSharpEvent_0 model); // 0x000000018A941914-0x000000018A9419D8
		void IMigratable<CheckStaticCSharpEvent>.Migrate(CheckStaticCSharpEvent model); // 0x000000018A9419D8-0x000000018A941A9C
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		protected override string OnInit(); // 0x000000018A9417F4-0x000000018A941914
		protected override void OnEnable(); // 0x000000018A941750-0x000000018A9417F4
		protected override void OnDisable(); // 0x000000018A9416AC-0x000000018A941750
		public void Raised(); // 0x000000018A93D41C-0x000000018A93D42C
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void SetTargetEvent(EventInfo info); // 0x000000018A941A9C-0x000000018A941B24
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised.\n(eg public event System.Action<T> [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEvent_0<T>) })]
	public class CheckCSharpEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>> // TypeDefIndex: 52251
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo;
		[BlackboardOnly]
		[SerializeField]
		private BBParameter<T> saveAs;
		private Delegate handler;
	
		// Properties
		private EventInfo targetEvent { get; }
		public override System.Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckCSharpEvent();
	
		// Methods
		void IMigratable<CheckCSharpEvent_0<T>>.Migrate(CheckCSharpEvent_0<T> model);
		void IMigratable<CheckStaticCSharpEvent<T>>.Migrate(CheckStaticCSharpEvent<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(EventInfo info);
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised and it\'s value is equal to provided value as well.\n(eg public event System.Action<T> [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEventValue_0<T>) })]
	public class CheckCSharpEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>> // TypeDefIndex: 52252
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo;
		[SerializeField]
		private BBParameter<T> checkValue;
		private Delegate handler;
	
		// Properties
		private EventInfo targetEvent { get; }
		public override System.Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckCSharpEventValue();
	
		// Methods
		void IMigratable<CheckCSharpEventValue_0<T>>.Migrate(CheckCSharpEventValue_0<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(EventInfo info);
	}

	internal class CheckField_0 // TypeDefIndex: 52253
	{
		// Fields
		[SerializeField]
		public BBParameter checkValue; // 0x10
		[SerializeField]
		public System.Type targetType; // 0x18
		[SerializeField]
		public string fieldName; // 0x20
	
		// Constructors
		public CheckField_0(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Category("\u272B Reflected")]
	[Description("Check a field on a script and return if it\'s equal or not to a value")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckField_0) })]
	[Name("Check Field", 8)]
	public class CheckField : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0> // TypeDefIndex: 52254
	{
		// Fields
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x68
		[SerializeField]
		protected CompareMethod comparison; // 0x70
		[SerializeField]
		protected SerializedFieldInfo field; // 0x78
	
		// Properties
		private System.Reflection.FieldInfo targetField { get; } // 0x000000018A945448-0x000000018A945458 
		public override System.Type agentType { get; } // 0x000000018A94517C-0x000000018A94524C 
		protected override string info { get; } // 0x000000018A94524C-0x000000018A945448 
	
		// Constructors
		public CheckField(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		void IMigratable<CheckField_0>.Migrate(CheckField_0 model); // 0x000000018A944F34-0x000000018A9450C8
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D862A0-0x0000000184D862B0
		protected override string OnInit(); // 0x000000018A944E9C-0x000000018A944F34
		protected override bool OnCheck(); // 0x000000018A944C2C-0x000000018A944E9C
		private void SetTargetField(System.Reflection.FieldInfo newField); // 0x000000018A9450C8-0x000000018A94517C
	}

	[Category("\u272B Reflected")]
	[Description("Call a function on a component and return whether or not the return value is equal to the check value")]
	[Name("Check Function", 10)]
	public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 52255
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
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		public override System.Type agentType { get; } // 0x000000018A945D70-0x000000018A945E34 
		protected override string info { get; } // 0x000000018A945E34-0x000000018A946100 
	
		// Constructors
		public CheckFunction_Multiplatform(); // 0x000000018A945CF4-0x000000018A945D70
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A945A8C-0x000000018A945AB4
		protected override string OnInit(); // 0x000000018A94590C-0x000000018A945A8C
		protected override bool OnCheck(); // 0x000000018A94555C-0x000000018A94590C
		private void SetMethod(MethodInfo method); // 0x000000018A945AB4-0x000000018A945CF4
	}

	[Category("\u272B Reflected")]
	[Description("Check a property on a script and return if it\'s equal or not to the check value")]
	[Name("Check Property", 9)]
	public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 52256
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A946100-0x000000018A946110 
		public override System.Type agentType { get; } // 0x000000018A948C50-0x000000018A948D14 
		protected override string info { get; } // 0x000000018A948D14-0x000000018A948E9C 
	
		// Constructors
		public CheckProperty_Multiplatform(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A948B74-0x000000018A948B9C
		protected override string OnInit(); // 0x000000018A948B0C-0x000000018A948B74
		protected override bool OnCheck(); // 0x000000018A94888C-0x000000018A948B0C
		private void SetMethod(MethodInfo method); // 0x000000018A948B9C-0x000000018A948C50
	}

	internal class CheckUnityEvent_0 // TypeDefIndex: 52257
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckUnityEvent_0(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class CheckUnityEvent_0<T> // TypeDefIndex: 52258
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckUnityEvent_0();
	}

	internal class CheckUnityEventValue_0<T> // TypeDefIndex: 52259
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckUnityEventValue_0();
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent and return true when that event is raised.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEvent_0) })]
	public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0> // TypeDefIndex: 52260
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo; // 0x68
		private UnityEvent unityEvent; // 0x70
	
		// Properties
		private MemberInfo targetMember { get; } // 0x000000018936B978-0x000000018936B98C 
		private bool isStatic { get; } // 0x000000018936B940-0x000000018936B960 
		private System.Type eventType { get; } // 0x0000000189369E8C-0x0000000189369EAC 
		private System.Reflection.FieldInfo targetEventField { get; } // 0x000000018936B960-0x000000018936B96C 
		private PropertyInfo targetEventProp { get; } // 0x000000018936B96C-0x000000018936B978 
		public override System.Type agentType { get; } // 0x000000018A94A6C8-0x000000018A94A780 
		protected override string info { get; } // 0x000000018A94A780-0x000000018A94A858 
	
		// Constructors
		public CheckUnityEvent(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		void IMigratable<CheckUnityEvent_0>.Migrate(CheckUnityEvent_0 model); // 0x000000018A94A588-0x000000018A94A640
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000184D86230-0x0000000184D86240
		protected override string OnInit(); // 0x000000018A94A40C-0x000000018A94A588
		protected override void OnEnable(); // 0x000000018A94A378-0x000000018A94A40C
		protected override void OnDisable(); // 0x000000018A94A2E4-0x000000018A94A378
		public void Raised(); // 0x000000018A93D41C-0x000000018A93D42C
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void SetTargetEvent(MemberInfo newMember); // 0x000000018A94A640-0x000000018A94A6C8
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEvent_0<T>) })]
	public class CheckUnityEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>> // TypeDefIndex: 52261
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo;
		[BlackboardOnly]
		[SerializeField]
		private BBParameter<T> saveAs;
		private UnityEvent<T> unityEvent;
	
		// Properties
		private MemberInfo targetMember { get; }
		private bool isStatic { get; }
		private System.Type eventType { get; }
		private System.Reflection.FieldInfo targetEventField { get; }
		private PropertyInfo targetEventProp { get; }
		public override System.Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckUnityEvent();
	
		// Methods
		void IMigratable<CheckUnityEvent_0<T>>.Migrate(CheckUnityEvent_0<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(MemberInfo newMember);
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised and it\'s value is equal to provided value as well.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEventValue_0<T>) })]
	public class CheckUnityEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T>> // TypeDefIndex: 52262
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo;
		[SerializeField]
		private BBParameter<T> checkValue;
		private UnityEvent<T> unityEvent;
	
		// Properties
		private MemberInfo targetMember { get; }
		private bool isStatic { get; }
		private System.Type eventType { get; }
		private System.Reflection.FieldInfo targetEventField { get; }
		private PropertyInfo targetEventProp { get; }
		public override System.Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckUnityEventValue();
	
		// Methods
		void IMigratable<CheckUnityEventValue_0<T>>.Migrate(CheckUnityEventValue_0<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(MemberInfo newMember);
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCall a function with none or up to 6 parameters on a component and return whether or not the return value is equal to the check value")]
	[Name("Check Function (Desktop Only)", 0)]
	public class CheckFunction : ConditionTask // TypeDefIndex: 52263
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField]
		protected BBParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		public override System.Type agentType { get; } // 0x000000018A946528-0x000000018A9465EC 
		protected override string info { get; } // 0x000000018A9465EC-0x000000018A9468AC 
	
		// Constructors
		public CheckFunction(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A946444-0x000000018A946490
		protected override string OnInit(); // 0x000000018A946328-0x000000018A946444
		protected override bool OnCheck(); // 0x000000018A946110-0x000000018A946328
		private void SetMethod(MethodInfo method); // 0x000000018A946490-0x000000018A946528
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCheck a property on a script and return if it\'s equal or not to the check value")]
	[Name("Check Property (Desktop Only)", 0)]
	public class CheckProperty : ConditionTask // TypeDefIndex: 52264
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField]
		protected BBParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018A9468AC-0x000000018A9468CC 
		public override System.Type agentType { get; } // 0x000000018A9491D0-0x000000018A949294 
		protected override string info { get; } // 0x000000018A949294-0x000000018A94941C 
	
		// Constructors
		public CheckProperty(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018A946444-0x000000018A946490
		protected override string OnInit(); // 0x000000018A9490B4-0x000000018A9491D0
		protected override bool OnCheck(); // 0x000000018A948E9C-0x000000018A9490B4
		private void SetMethod(MethodInfo method); // 0x000000018A946490-0x000000018A946528
	}

	[Category("System Events")]
	[Name("Check Collision", 0)]
	public class CheckCollision_Rigidbody : ConditionTask<Rigidbody> // TypeDefIndex: 52265
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
		protected override string info { get; } // 0x000000018A943104-0x000000018A9431BC 
	
		// Constructors
		public CheckCollision_Rigidbody(); // 0x000000018A9430B4-0x000000018A943104
	
		// Methods
		protected override void OnEnable(); // 0x000000018A942FC0-0x000000018A9430B4
		protected override void OnDisable(); // 0x000000018A942ECC-0x000000018A942FC0
		protected override bool OnCheck(); // 0x000000018A941CD0-0x000000018A941CE4
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data); // 0x000000018A942C60-0x000000018A942E00
		public void OnCollisionExit(EventData<UnityEngine.Collision> data); // 0x000000018A942E00-0x000000018A942ECC
	}

	[Category("System Events")]
	[DoNotList]
	public class CheckCollision : ConditionTask<Collider> // TypeDefIndex: 52266
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
		protected override string info { get; } // 0x000000018A94320C-0x000000018A9432C4 
	
		// Constructors
		public CheckCollision(); // 0x000000018A9431BC-0x000000018A94320C
	
		// Methods
		protected override void OnEnable(); // 0x000000018A942B6C-0x000000018A942C60
		protected override void OnDisable(); // 0x000000018A942A78-0x000000018A942B6C
		protected override bool OnCheck(); // 0x000000018A941CD0-0x000000018A941CE4
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data); // 0x000000018A94280C-0x000000018A9429AC
		public void OnCollisionExit(EventData<UnityEngine.Collision> data); // 0x000000018A9429AC-0x000000018A942A78
	}

	[Category("System Events")]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D_Rigidbody : ConditionTask<Rigidbody2D> // TypeDefIndex: 52267
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
		protected override string info { get; } // 0x000000018A94264C-0x000000018A942704 
	
		// Constructors
		public CheckCollision2D_Rigidbody(); // 0x000000018A9425FC-0x000000018A94264C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A941CD0-0x000000018A941CE4
		protected override void OnEnable(); // 0x000000018A942508-0x000000018A9425FC
		protected override void OnDisable(); // 0x000000018A942414-0x000000018A942508
		private void OnCollisionEnter2D(EventData<Collision2D> data); // 0x000000018A942170-0x000000018A942348
		private void OnCollisionExit2D(EventData<Collision2D> data); // 0x000000018A942348-0x000000018A942414
	}

	[Category("System Events")]
	[DoNotList]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D : ConditionTask<Collider2D> // TypeDefIndex: 52268
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
		protected override string info { get; } // 0x000000018A942754-0x000000018A94280C 
	
		// Constructors
		public CheckCollision2D(); // 0x000000018A942704-0x000000018A942754
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A941CD0-0x000000018A941CE4
		protected override void OnEnable(); // 0x000000018A94207C-0x000000018A942170
		protected override void OnDisable(); // 0x000000018A941F88-0x000000018A94207C
		private void OnCollisionEnter2D(EventData<Collision2D> data); // 0x000000018A941CE4-0x000000018A941EBC
		private void OnCollisionExit2D(EventData<Collision2D> data); // 0x000000018A941EBC-0x000000018A941F88
	}

	[Category("System Events")]
	public class CheckMouse : ConditionTask<Collider> // TypeDefIndex: 52269
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A948794-0x000000018A9487E4 
	
		// Constructors
		public CheckMouse(); // 0x000000018A948758-0x000000018A948794
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		protected override void OnEnable(); // 0x000000018A948608-0x000000018A948758
		protected override void OnDisable(); // 0x000000018A9484B8-0x000000018A948608
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018A947888-0x000000018A94789C
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018A94789C-0x000000018A9478B0
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018A9478B0-0x000000018A9478C4
	}

	[Category("System Events")]
	[Name("Check Mouse 2D", 0)]
	public class CheckMouse2D : ConditionTask<Collider2D> // TypeDefIndex: 52270
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A947900-0x000000018A947950 
	
		// Constructors
		public CheckMouse2D(); // 0x000000018A9478C4-0x000000018A947900
	
		// Methods
		protected override void OnEnable(); // 0x000000018A947738-0x000000018A947888
		protected override void OnDisable(); // 0x000000018A9475E8-0x000000018A947738
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018A947888-0x000000018A94789C
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018A94789C-0x000000018A9478B0
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018A9478B0-0x000000018A9478C4
	}

	[Category("System Events")]
	public class CheckMouseClick : ConditionTask<Collider> // TypeDefIndex: 52271
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A947DE8-0x000000018A947E38 
	
		// Constructors
		public CheckMouseClick(); // 0x000000018A947DAC-0x000000018A947DE8
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		protected override void OnEnable(); // 0x000000018A947CB8-0x000000018A947DAC
		protected override void OnDisable(); // 0x000000018A947BC4-0x000000018A947CB8
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018A947888-0x000000018A94789C
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018A94789C-0x000000018A9478B0
	}

	[Category("System Events")]
	[Name("Check Mouse Click 2D", 0)]
	public class CheckMouseClick2D : ConditionTask<Collider2D> // TypeDefIndex: 52272
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A947B74-0x000000018A947BC4 
	
		// Constructors
		public CheckMouseClick2D(); // 0x000000018A947B38-0x000000018A947B74
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		protected override void OnEnable(); // 0x000000018A947A44-0x000000018A947B38
		protected override void OnDisable(); // 0x000000018A947950-0x000000018A947A44
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018A947888-0x000000018A94789C
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018A94789C-0x000000018A9478B0
	}

	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	[Name("Check Trigger", 0)]
	public class CheckTrigger_Transform : ConditionTask<Transform> // TypeDefIndex: 52273
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
		protected override string info { get; } // 0x000000018A94A124-0x000000018A94A1DC 
	
		// Constructors
		public CheckTrigger_Transform(); // 0x000000018A94A0D4-0x000000018A94A124
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9499B8-0x000000018A9499CC
		protected override void OnEnable(); // 0x000000018A949E44-0x000000018A949F38
		protected override void OnDisable(); // 0x000000018A949D50-0x000000018A949E44
		public void OnTriggerEnter(EventData<Collider> data); // 0x000000018A949F38-0x000000018A94A008
		public void OnTriggerExit(EventData<Collider> data); // 0x000000018A94A008-0x000000018A94A0D4
	}

	[Category("System Events")]
	[DoNotList]
	public class CheckTrigger : ConditionTask<Collider> // TypeDefIndex: 52274
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
		protected override string info { get; } // 0x000000018A94A22C-0x000000018A94A2E4 
	
		// Constructors
		public CheckTrigger(); // 0x000000018A94A1DC-0x000000018A94A22C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A9499B8-0x000000018A9499CC
		protected override void OnEnable(); // 0x000000018A949AC0-0x000000018A949BB4
		protected override void OnDisable(); // 0x000000018A9499CC-0x000000018A949AC0
		public void OnTriggerEnter(EventData<Collider> data); // 0x000000018A949BB4-0x000000018A949C84
		public void OnTriggerExit(EventData<Collider> data); // 0x000000018A949C84-0x000000018A949D50
	}

	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	[Name("Check Trigger 2D", 0)]
	public class CheckTrigger2D_Transform : ConditionTask<Transform> // TypeDefIndex: 52275
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
		protected override string info { get; } // 0x000000018A949900-0x000000018A9499B8 
	
		// Constructors
		public CheckTrigger2D_Transform(); // 0x000000018A9498B0-0x000000018A949900
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A949518-0x000000018A94952C
		protected override void OnEnable(); // 0x000000018A949620-0x000000018A949714
		protected override void OnDisable(); // 0x000000018A94952C-0x000000018A949620
		public void OnTriggerEnter2D(EventData<Collider2D> data); // 0x000000018A949714-0x000000018A9497E4
		public void OnTriggerExit2D(EventData<Collider2D> data); // 0x000000018A9497E4-0x000000018A9498B0
	}

	[Category("System Events")]
	[DoNotList]
	[Name("Check Trigger 2D", 0)]
	public class CheckTrigger2D : ConditionTask<Collider2D> // TypeDefIndex: 52276
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
		protected override string info { get; } // 0x000000018A953C5C-0x000000018A953D14 
	
		// Constructors
		public CheckTrigger2D(); // 0x000000018A953C0C-0x000000018A953C5C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A949518-0x000000018A94952C
		protected override void OnEnable(); // 0x000000018A95397C-0x000000018A953A70
		protected override void OnDisable(); // 0x000000018A953888-0x000000018A95397C
		public void OnTriggerEnter2D(EventData<Collider2D> data); // 0x000000018A953A70-0x000000018A953B40
		public void OnTriggerExit2D(EventData<Collider2D> data); // 0x000000018A953B40-0x000000018A953C0C
	}

	[Category("UGUI")]
	public class ButtonClicked : ConditionTask // TypeDefIndex: 52277
	{
		// Fields
		[RequiredField]
		public BBParameter<UnityEngine.UI.Button> button; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A952F48-0x000000018A952FA0 
	
		// Constructors
		public ButtonClicked(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override string OnInit(); // 0x000000018A952E8C-0x000000018A952F48
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void OnClick(); // 0x000000018A93D41C-0x000000018A93D42C
	}

	[Category("UGUI")]
	[Description("Returns true when the selected event is triggered on the selected agent.\nYou can use this for both GUI and 3D objects.\nPlease make sure that Unity Event Systems are setup correctly")]
	public class InterceptEvent : ConditionTask<Transform> // TypeDefIndex: 52278
	{
		// Fields
		public EventTriggerType eventType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A960318-0x000000018A9603A0 
	
		// Constructors
		public InterceptEvent(); // 0x000000018A9602DC-0x000000018A960318
	
		// Methods
		protected override void OnEnable(); // 0x000000018A95FD0C-0x000000018A9602DC
		protected override void OnDisable(); // 0x000000018A95F73C-0x000000018A95FD0C
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void OnPointerEnter(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnPointerExit(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnPointerDown(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnPointerUp(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnPointerClick(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnDrag(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnDrop(EventData<PointerEventData> eventData); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnScroll(EventData<PointerEventData> data); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnUpdateSelected(EventData<BaseEventData> eventData); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnSelect(EventData<BaseEventData> eventData); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnDeselect(EventData<BaseEventData> eventData); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnMove(EventData<AxisEventData> eventData); // 0x000000018A93D41C-0x000000018A93D42C
		private void OnSubmit(EventData<BaseEventData> eventData); // 0x000000018A93D41C-0x000000018A93D42C
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and return true for one frame")]
	public class CheckEvent : ConditionTask<GraphOwner> // TypeDefIndex: 52279
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A95318C-0x000000018A9531F4 
	
		// Constructors
		public CheckEvent(); // 0x000000018A953150-0x000000018A95318C
	
		// Methods
		protected override void OnEnable(); // 0x000000018A9530B8-0x000000018A953150
		protected override void OnDisable(); // 0x000000018A953020-0x000000018A9530B8
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData data); // 0x000000018A952FA0-0x000000018A953020
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and return true for one frame. Optionaly save the received event\'s value")]
	public class CheckEvent<T> : ConditionTask<GraphOwner> // TypeDefIndex: 52280
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName;
		[BlackboardOnly]
		public BBParameter<T> saveEventValue;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckEvent();
	
		// Methods
		protected override void OnEnable();
		protected override void OnDisable();
		protected override bool OnCheck();
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData data);
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and it\'s value is equal to specified value, then return true for one frame")]
	public class CheckEventValue<T> : ConditionTask<GraphOwner> // TypeDefIndex: 52281
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName;
		[Name("Compare Value To", 0)]
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckEventValue();
	
		// Methods
		protected override void OnEnable();
		protected override void OnDisable();
		protected override bool OnCheck();
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg);
	}

	[Category("\u272B Utility")]
	[Description("Check for an invoked Signal with agent as the target. If Signal was invoked as global, then the target does not matter.")]
	public class CheckSignal : ConditionTask<Transform> // TypeDefIndex: 52282
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		[SerializeField]
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A94BFE8-0x000000018A94C00C 
	
		// Constructors
		public CheckSignal(); // 0x000000018A95358C-0x000000018A953614
	
		// Methods
		protected override string OnInit(); // 0x000000018A9533B0-0x000000018A953400
		protected override void OnEnable(); // 0x000000018A9532A4-0x000000018A9533B0
		protected override void OnDisable(); // 0x000000018A9531F4-0x000000018A9532A4
		private void OnSignalInvoke(Transform sender, Transform receiver, bool isGlobal, params object[] args); // 0x000000018A953400-0x000000018A95358C
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
	}

	[Category("\u272B Utility")]
	[Description("Check the parent state status. This condition is only meant to be used along with an FSM system.")]
	public class CheckStateStatus : ConditionTask // TypeDefIndex: 52283
	{
		// Fields
		public CompactStatus status; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018A953828-0x000000018A953888 
	
		// Constructors
		public CheckStateStatus(); // 0x0000000184DA66B0-0x0000000184DA66C0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018A953794-0x000000018A953828
	}

	[Category("\u272B Utility")]
	[Description("Simply use to debug return true or false by inverting the condition if needed")]
	public class DebugCondition : ConditionTask // TypeDefIndex: 52284
	{
		// Constructors
		public DebugCondition(); // 0x0000000184D8E020-0x0000000184D8E030
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812081B0-0x0000000181208610
	}

	[Category("\u272B Utility")]
	[Description("Return true or false based on the probability settings.")]
	public class Probability : ConditionTask // TypeDefIndex: 52285
	{
		// Fields
		public BBParameter<float> probability; // 0x68
		public BBParameter<float> maxValue; // 0x70
		private bool success; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018A9634DC-0x000000018A963580 
	
		// Constructors
		public Probability(); // 0x000000018489BDF0-0x000000018489BE70
	
		// Methods
		protected override void OnEnable(); // 0x000000018A96345C-0x000000018A9634DC
		protected override bool OnCheck(); // 0x0000000184D86F90-0x0000000184D86FA0
	}

	[Category("\u272B Utility")]
	[Description("Will return true after a specific amount of time has passed and false while still counting down")]
	public class Timeout : ConditionTask // TypeDefIndex: 52286
	{
		// Fields
		public BBParameter<float> timeout; // 0x68
		private float currentTime; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018A967CA8-0x000000018A967D2C 
	
		// Constructors
		public Timeout(); // 0x000000018A967C54-0x000000018A967CA8
	
		// Methods
		protected override void OnEnable(); // 0x000000018A967BBC-0x000000018A967C54
		protected override void OnDisable(); // 0x000000018A967B24-0x000000018A967BBC
		private void MoveNext(); // 0x000000018A967A44-0x000000018A967AC0
		protected override bool OnCheck(); // 0x000000018A967AC0-0x000000018A967B24
	}
}

namespace ParadoxNotion
{
	public delegate void ActionCall(); // TypeDefIndex: 52698; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void ActionCall<T1>(T1 a); // TypeDefIndex: 52699; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2>(T1 a, T2 b); // TypeDefIndex: 52700; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c); // TypeDefIndex: 52701; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 52702; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 52703; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 52704; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 52705; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 52706; 0x00000000-0x00000000

	public delegate TResult FunctionCall<TResult>(); // TypeDefIndex: 52707; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, TResult>(T1 a); // TypeDefIndex: 52708; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b); // TypeDefIndex: 52709; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c); // TypeDefIndex: 52710; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 52711; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 52712; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 52713; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 52714; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 52715; 0x00000000-0x00000000

	[Serializable]
	public sealed class DynamicParameterDefinition : ISerializationCallbackReceiver // TypeDefIndex: 52716
	{
		// Fields
		[SerializeField]
		private string _ID; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private string _type; // 0x20
		[CompilerGenerated]
		private System.Type _type_k__BackingField; // 0x28
	
		// Properties
		public string ID { get; private set; } // 0x000000018A9806A8-0x000000018A9806D8 0x00000001853908C0-0x00000001853908D0
		public string name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public System.Type type { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		public DynamicParameterDefinition(); // 0x00000001841E1670-0x00000001841E1680
		public DynamicParameterDefinition(string name, System.Type type); // 0x000000018A980630-0x000000018A9806A8
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A9805C0-0x000000018A980630
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A980560-0x000000018A9805C0
	}

	public enum CompareMethod // TypeDefIndex: 52717
	{
		EqualTo = 0,
		GreaterThan = 1,
		LessThan = 2,
		GreaterOrEqualTo = 3,
		LessOrEqualTo = 4
	}

	public enum OperationMethod // TypeDefIndex: 52718
	{
		Set = 0,
		Add = 1,
		Subtract = 2,
		Multiply = 3,
		Divide = 4
	}

	public enum ButtonKeys // TypeDefIndex: 52719
	{
		Left = 0,
		Right = 1,
		Middle = 2
	}

	public enum PressTypes // TypeDefIndex: 52720
	{
		Down = 0,
		Up = 1,
		Pressed = 2
	}

	public enum MouseClickEvent // TypeDefIndex: 52721
	{
		MouseDown = 0,
		MouseUp = 1
	}

	public enum TriggerTypes // TypeDefIndex: 52722
	{
		TriggerEnter = 0,
		TriggerExit = 1,
		TriggerStay = 2
	}

	public enum CollisionTypes // TypeDefIndex: 52723
	{
		CollisionEnter = 0,
		CollisionExit = 1,
		CollisionStay = 2
	}

	public enum MouseInteractionTypes // TypeDefIndex: 52724
	{
		MouseEnter = 0,
		MouseExit = 1,
		MouseOver = 2
	}

	public enum CompactStatus // TypeDefIndex: 52725
	{
		Failure = 0,
		Success = 1
	}

	public enum PlayDirections // TypeDefIndex: 52726
	{
		Forward = 0,
		Backward = 1,
		Toggle = 2
	}

	public enum PlanarDirection // TypeDefIndex: 52727
	{
		Horizontal = 0,
		Vertical = 1,
		Auto = 2
	}

	public enum Alignment2x2 // TypeDefIndex: 52728
	{
		Default = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4
	}

	public enum Alignment3x3 // TypeDefIndex: 52729
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

	public class HierarchyTree // TypeDefIndex: 52732
	{
		// Nested types
		public class Element // TypeDefIndex: 52731
		{
			// Fields
			private object _reference; // 0x10
			private Element _parent; // 0x18
			private List<Element> _children; // 0x20
	
			// Properties
			public object reference { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			public Element parent { get; } // 0x000000018385B100-0x000000018385B110 
			public IEnumerable<Element> children { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
			// Nested types
			[CompilerGenerated]
			private sealed class _GetAllChildrenReferencesOfType_d__15<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 52730
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
				T IEnumerator<T>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _GetAllChildrenReferencesOfType_d__15(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				private void __m__Finally1();
				[DebuggerHidden]
				void IEnumerator.Reset();
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator();
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator();
			}
	
			// Constructors
			public Element(object reference); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public Element AddChild(Element child); // 0x000000018A9806D8-0x000000018A98079C
			public void RemoveChild(Element child); // 0x000000018A980854-0x000000018A9808A8
			public Element GetRoot(); // 0x000000018A980840-0x000000018A980854
			public Element FindReferenceElement(object target); // 0x000000018A98079C-0x000000018A980840
			public T GetFirstParentReferenceOfType<T>();
			[IteratorStateMachine(typeof(_GetAllChildrenReferencesOfType_d__15<T>))]
			public IEnumerable<T> GetAllChildrenReferencesOfType<T>();
		}
	
		// Constructors
		public HierarchyTree(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface IEventData // TypeDefIndex: 52733
	{
		// Properties
		GameObject receiver { get; }
		object sender { get; }
		object valueBoxed { get; }
	}

	public struct EventData : ParadoxNotion.IEventData // TypeDefIndex: 52734
	{
		// Fields
		[CompilerGenerated]
		private GameObject _receiver_k__BackingField; // 0x00
		[CompilerGenerated]
		private object _sender_k__BackingField; // 0x08
		[CompilerGenerated]
		private object _value_k__BackingField; // 0x10
	
		// Properties
		public GameObject receiver { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public object sender { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public object value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public object valueBoxed { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public EventData(object value, GameObject receiver, object sender); // 0x000000018A9808E4-0x000000018A980918
		public EventData(GameObject receiver, object sender); // 0x000000018A9808A8-0x000000018A9808E4
	}

	public struct EventData<T> : ParadoxNotion.IEventData // TypeDefIndex: 52735
	{
		// Fields
		[CompilerGenerated]
		private GameObject _receiver_k__BackingField;
		[CompilerGenerated]
		private object _sender_k__BackingField;
		[CompilerGenerated]
		private T _value_k__BackingField;
	
		// Properties
		public GameObject receiver { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object sender { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; }
		public T value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object valueBoxed { get; }
	
		// Constructors
		public EventData(T value, GameObject receiver, object sender);
	}

	public static class OperationTools // TypeDefIndex: 52736
	{
		// Methods
		public static string GetOperationString(OperationMethod om); // 0x000000018A984D58-0x000000018A984E14
		public static float Operate(float a, float b, OperationMethod om, float delta = 1f /* Metadata: 0x02331D98 */); // 0x000000018A985030-0x000000018A985078
		public static int Operate(int a, int b, OperationMethod om); // 0x000000018A984FF4-0x000000018A985030
		public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f /* Metadata: 0x02331D9C */); // 0x000000018A984E14-0x000000018A984FF4
		public static string GetCompareString(CompareMethod cm); // 0x000000018A984C9C-0x000000018A984D58
		public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint); // 0x000000018A984C54-0x000000018A984C9C
		public static bool Compare(int a, int b, CompareMethod cm); // 0x000000018A984C14-0x000000018A984C54
	}

	public static class ReflectionTools // TypeDefIndex: 52743
	{
		// Fields
		public const System.Reflection.BindingFlags FLAGS_ALL = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.FlattenHierarchy; // Metadata: 0x02331DA7
		public const System.Reflection.BindingFlags FLAGS_ALL_DECLARED = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic; // Metadata: 0x02331DA9
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
		public const string METHOD_SPECIAL_NAME_GET = "get_"; // Metadata: 0x02331DAA
		public const string METHOD_SPECIAL_NAME_SET = "set_"; // Metadata: 0x02331DAF
		public const string METHOD_SPECIAL_NAME_ADD = "add_"; // Metadata: 0x02331DB4
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_"; // Metadata: 0x02331DB9
		public const string METHOD_SPECIAL_NAME_OP = "op_"; // Metadata: 0x02331DC1
	
		// Properties
		private static Assembly[] loadedAssemblies { get; } // 0x000000018A98ACE8-0x000000018A98AD98 
	
		// Nested types
		public enum MethodType // TypeDefIndex: 52737
		{
			Normal = 0,
			PropertyAccessor = 1,
			Event = 2,
			Operator = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 52738
		{
			// Fields
			public bool includeObsolete; // 0x10
			public Func<System.Type, bool> __9__2; // 0x18
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetAllTypes_b__2(System.Type t); // 0x000000018A99A7FC-0x000000018A99A868
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52739
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__33_0; // 0x08
			public static Func<System.Type, string> __9__33_1; // 0x10
			public static Func<ParameterInfo, System.Type> __9__102_0; // 0x18
			public static Func<ParameterInfo, System.Type> __9__110_0; // 0x20
	
			// Constructors
			static __c(); // 0x000000018A99AECC-0x000000018A99AF30
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _GetAllTypes_b__33_0(System.Type t); // 0x000000018A999FA0-0x000000018A999FC0
			internal string _GetAllTypes_b__33_1(System.Type t); // 0x000000018A999FC0-0x000000018A99A00C
			internal System.Type _RTCreateDelegate_b__102_0(ParameterInfo p); // 0x0000000186C08908-0x0000000186C08920
			internal System.Type _GetBaseDefinition_b__110_0(ParameterInfo p); // 0x0000000186C08908-0x0000000186C08920
		}
	
		[CompilerGenerated]
		private sealed class _RTGetAttributesRecursive_d__99<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 52740
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
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RTGetAttributesRecursive_d__99(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass128_0<T, TResult> // TypeDefIndex: 52741
		{
			// Fields
			public System.Reflection.FieldInfo info;
	
			// Constructors
			public __c__DisplayClass128_0();
	
			// Methods
			internal TResult _GetFieldGetter_b__0(T instance);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_0<T, TValue> // TypeDefIndex: 52742
		{
			// Fields
			public System.Reflection.FieldInfo info;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal void _GetFieldSetter_b__0(T instance, TValue value);
		}
	
		// Constructors
		static ReflectionTools(); // 0x0000000183A32DC0-0x0000000183A33990
	
		// Methods
		public static void FlushMem(); // 0x00000001845B12D0-0x00000001845B1A60
		public static System.Type GetType(string typeFullName); // 0x000000018A988334-0x000000018A988384
		public static System.Type GetType(string typeFullName, System.Type fallbackAssignable); // 0x00000001838F1470-0x00000001838F14C0
		public static System.Type GetType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x02331DA0 */, System.Type fallbackAssignable = null); // 0x00000001838F14C0-0x00000001838F1620
		private static System.Type GetTypeDirect(string typeFullName); // 0x00000001838F1620-0x00000001838F16C0
		private static System.Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x02331DA1 */, System.Type fallbackAssignable = null); // 0x000000018A98A628-0x000000018A98AB34
		private static System.Type TryResolveDeserializeFromAttribute(string typeName); // 0x000000018A98A50C-0x000000018A98A628
		private static System.Type TryResolveWithoutNamespace(string typeName, System.Type fallbackAssignable = null); // 0x000000018A98AB34-0x000000018A98ACE8
		public static System.Type[] GetAllTypes(bool includeObsolete); // 0x000000018A986DE4-0x000000018A98724C
		public static System.Type[] GetImplementationsOf(System.Type baseType); // 0x000000018A987C80-0x000000018A987E5C
		public static object[] SingleTempArgsArray(object arg); // 0x000000018A98A084-0x000000018A98A10C
		public static string FriendlyTypeName(string fullName); // 0x000000018A986C40-0x000000018A986D3C
		public static System.Type[] RTGetEmptyTypes(); // 0x000000018A988E54-0x000000018A988EA4
		private static bool MemberResolvedFromDeserializeAttribute(MemberInfo member, string targetName); // 0x000000018A988940-0x000000018A9889B8
		public static Delegate ConvertDelegate(Delegate originalDelegate, System.Type targetDelegateType); // 0x000000018A985A24-0x000000018A985A64
		public static bool TryConvert(System.Type fromType, System.Type toType, out UnaryExpression exp); // 0x000000018A98A10C-0x000000018A98A210
		public static void DigFields(object root, Predicate<System.Reflection.FieldInfo> move, Action<object> push, Action<object> pop); // 0x000000018A985B1C-0x000000018A986108
		public static Func<T, TResult> GetFieldGetter<T, TResult>(System.Reflection.FieldInfo info);
		public static Action<T, TValue> GetFieldSetter<T, TValue>(System.Reflection.FieldInfo info);
	
		// Extension methods
		public static MethodType GetMethodSpecialType(this MethodBase method); // 0x000000018A987E5C-0x000000018A9882B4
		public static string FriendlyName(this System.Type t, bool compileSafe = false /* Metadata: 0x02331DA2 */); // 0x000000018A986730-0x000000018A986C40
		public static string FriendlyName(this MemberInfo info); // 0x000000018A986634-0x000000018A986730
		public static string FriendlyName(this MethodBase method); // 0x000000018A986108-0x000000018A986160
		public static string FriendlyName(this MethodBase method, out MethodType specialNameType); // 0x000000018A986160-0x000000018A986634
		public static string SignatureName(this MethodBase method); // 0x000000018A989CA4-0x000000018A98A084
		public static System.Type RTReflectedOrDeclaredType(this MemberInfo member); // 0x000000018A989A2C-0x000000018A989AA0
		public static bool RTIsAssignableFrom(this System.Type type, System.Type other); // 0x000000018321E250-0x000000018321E280
		public static bool RTIsAssignableTo(this System.Type type, System.Type other); // 0x000000018321E200-0x000000018321E250
		public static bool RTIsAbstract(this System.Type type); // 0x000000018A989920-0x000000018A98993C
		public static bool RTIsValueType(this System.Type type); // 0x000000018A989A0C-0x000000018A989A2C
		public static bool RTIsArray(this System.Type type); // 0x000000018A98993C-0x000000018A98995C
		public static bool RTIsInterface(this System.Type type); // 0x000000018A9899CC-0x000000018A9899E8
		public static bool RTIsSubclassOf(this System.Type type, System.Type other); // 0x000000018A9899E8-0x000000018A989A0C
		public static bool RTIsGenericParameter(this System.Type type); // 0x000000018A9899AC-0x000000018A9899CC
		public static bool RTIsGenericType(this System.Type type); // 0x0000000184D83A60-0x0000000184D83A80
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop); // 0x000000018A989524-0x000000018A989540
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop); // 0x000000018A989904-0x000000018A989920
		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del); // 0x000000018A988CE8-0x000000018A988D08
		public static System.Type RTMakeGenericType(this System.Type type, params System.Type[] typeArgs); // 0x00000001849AF470-0x00000001849AF4A0
		public static System.Type[] RTGetGenericArguments(this System.Type type); // 0x0000000183F85540-0x0000000183F85650
		public static System.Type[] RTGetGenericArguments(this MethodInfo method); // 0x000000018A989420-0x000000018A989524
		public static System.Type RTGetElementType(this System.Type type); // 0x000000018A988E04-0x000000018A988E54
		public static bool RTIsByRef(this System.Type type); // 0x000000018A98995C-0x000000018A9899AC
		public static object CreateObject(this System.Type type); // 0x000000018A985ACC-0x000000018A985B1C
		public static object CreateObjectUninitialized(this System.Type type); // 0x000000018A985A64-0x000000018A985ACC
		public static ConstructorInfo RTGetDefaultConstructor(this System.Type type); // 0x00000001836042F0-0x00000001836043A0
		public static ConstructorInfo RTGetConstructor(this System.Type type, System.Type[] paramTypes); // 0x000000018A988BC0-0x000000018A988CE8
		public static MethodInfo RTGetMethod(this System.Type type, string name); // 0x000000018A989540-0x000000018A989614
		public static MethodInfo RTGetMethod(this System.Type type, string name, System.Type[] paramTypes, System.Type returnType = null, System.Type[] genericArgumentTypes = null); // 0x000000018A989614-0x000000018A989824
		public static System.Reflection.FieldInfo RTGetField(this System.Type type, string name, bool includePrivateBase = false /* Metadata: 0x02331DA3 */); // 0x000000018A989304-0x000000018A989420
		public static PropertyInfo RTGetProperty(this System.Type type, string name); // 0x0000000183F85730-0x0000000183F857E0
		public static MemberInfo RTGetFieldOrProp(this System.Type type, string name); // 0x000000018A989198-0x000000018A989304
		public static EventInfo RTGetEvent(this System.Type type, string name); // 0x000000018A988EA4-0x000000018A988F78
		public static object RTGetFieldOrPropValue(this MemberInfo member, object instance, int index = -1 /* Metadata: 0x02331DA4 */); // 0x000000018A989058-0x000000018A989198
		public static void RTSetFieldOrPropValue(this MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x02331DA5 */); // 0x000000018A989AA0-0x000000018A989BE8
		public static ConstructorInfo[] RTGetConstructors(this System.Type type); // 0x00000001836043A0-0x00000001836044C0
		public static MethodInfo[] RTGetMethods(this System.Type type); // 0x000000018A989824-0x000000018A989904
		public static System.Reflection.FieldInfo[] RTGetFields(this System.Type type); // 0x000000018321D560-0x000000018321D640
		public static PropertyInfo[] RTGetProperties(this System.Type type); // 0x0000000183F85650-0x0000000183F85730
		public static EventInfo[] RTGetEvents(this System.Type type); // 0x000000018A988F78-0x000000018A989058
		public static object[] RTGetAllAttributes(this System.Type type); // 0x000000018321E280-0x000000018321E390
		public static bool RTIsDefined<T>(this System.Type type, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this System.Type type, System.Type attributeType, bool inherited); // 0x000000018321CA70-0x000000018321CAF0
		public static T RTGetAttribute<T>(this System.Type type, bool inherited)
			where T : Attribute;
		public static Attribute RTGetAttribute(this System.Type type, System.Type attributeType, bool inherited); // 0x000000018321E0D0-0x000000018321E200
		public static object[] RTGetAllAttributes(this MemberInfo member); // 0x000000018321DF80-0x000000018321E0D0
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this MemberInfo member, System.Type attributeType, bool inherited); // 0x000000018321DDD0-0x000000018321DE40
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static Attribute RTGetAttribute(this MemberInfo member, System.Type attributeType, bool inherited); // 0x000000018321DE40-0x000000018321DF80
		[IteratorStateMachine(typeof(_RTGetAttributesRecursive_d__99<T>))]
		public static IEnumerable<T> RTGetAttributesRecursive<T>(this System.Type type)
			where T : Attribute;
		public static ParameterInfo[] RTGetDelegateTypeParameters(this System.Type delegateType); // 0x000000018A988D08-0x000000018A988E04
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
			where T : Delegate;
		public static Delegate RTCreateDelegate(this MethodInfo method, System.Type type, object instance); // 0x000000018A9889B8-0x000000018A988BC0
		public static bool IsReadOnly(this System.Reflection.FieldInfo field); // 0x000000018A988878-0x000000018A9888B0
		public static bool IsConstant(this System.Reflection.FieldInfo field); // 0x000000018A988464-0x000000018A9884C4
		public static bool IsStatic(this EventInfo info); // 0x000000018A9888F8-0x000000018A988940
		public static bool IsStatic(this PropertyInfo info); // 0x000000018A9888B0-0x000000018A9888F8
		public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters); // 0x000000018A98879C-0x000000018A988830
		public static bool IsObsolete(this MemberInfo member, bool inherited = true /* Metadata: 0x02331DA6 */); // 0x000000018A98861C-0x000000018A98879C
		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x000000018A9872C8-0x000000018A9875C8
		public static System.Reflection.FieldInfo GetBaseDefinition(this System.Reflection.FieldInfo fieldInfo); // 0x000000018A98724C-0x000000018A9872C8
		public static MethodInfo[] GetExtensionMethods(this System.Type targetType); // 0x000000018A987768-0x000000018A987A44
		public static bool IsExtensionMethod(this MethodInfo method); // 0x000000018A988598-0x000000018A9885EC
		public static bool IsPropertyAccessor(this MethodInfo method); // 0x000000018A988830-0x000000018A988878
		public static bool IsIndexerProperty(this PropertyInfo property); // 0x000000018A9885EC-0x000000018A98861C
		public static bool IsAutoProperty(this PropertyInfo property); // 0x000000018A988384-0x000000018A988464
		public static PropertyInfo GetAccessorProperty(this MethodInfo method); // 0x000000018A986D3C-0x000000018A986DE4
		public static bool IsEnumerableCollection(this System.Type type); // 0x000000018A9884C4-0x000000018A988598
		public static System.Type GetEnumerableElementType(this System.Type type); // 0x000000018A9875C8-0x000000018A987768
		public static System.Type GetSingleGenericArgument(this System.Type type); // 0x000000018A9882B4-0x000000018A988334
		public static System.Type GetFirstGenericParameterConstraintType(this System.Type type); // 0x000000018A987B58-0x000000018A987C80
		public static System.Type GetFirstGenericParameterConstraintType(this MethodInfo method); // 0x000000018A987A44-0x000000018A987B58
		public static bool TryMakeGeneric(this System.Type def, System.Type argType, out System.Type result); // 0x000000018A98A210-0x000000018A98A394
		public static bool TryMakeGeneric(this MethodInfo def, System.Type argType, out MethodInfo result); // 0x000000018A98A394-0x000000018A98A50C
		public static Array Resize(this Array array, int newSize); // 0x000000018A989BE8-0x000000018A989CA4
	}

	public static class TypeConverter // TypeDefIndex: 52747
	{
		// Fields
		[CompilerGenerated]
		private static CustomConverter customConverter; // 0x00
	
		// Events
		public static event CustomConverter customConverter {
			add; // 0x000000018A999D10-0x000000018A999DB8
			remove; // 0x000000018A999DB8-0x000000018A999E60
		}
	
		// Nested types
		public delegate Func<object, object> CustomConverter(System.Type fromType, System.Type toType); // TypeDefIndex: 52744; 0x00000001815802E0-0x00000001815802F0
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 52745
		{
			// Fields
			public System.Type toType; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _Get_b__2(object value); // 0x000000018A99A868-0x000000018A99A96C
			internal object _Get_b__4(object value); // 0x000000018A99A96C-0x000000018A99AA18
			internal object _Get_b__6(object value); // 0x000000018A99AA18-0x000000018A99AAD4
			internal object _Get_b__7(object value); // 0x000000018A99AAD4-0x000000018A99AB80
			internal object _Get_b__8(object value); // 0x000000018A99AB80-0x000000018A99AC3C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52746
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
			static __c(); // 0x0000000184D4C6F0-0x0000000184D4C750
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _Get_b__4_0(object value); // 0x0000000184D88C30-0x0000000184D88C40
			internal object _Get_b__4_1(object value); // 0x000000018A99A4D0-0x000000018A99A51C
			internal object _Get_b__4_3(object value); // 0x000000018A99A51C-0x000000018A99A560
			internal object _Get_b__4_5(object value); // 0x000000018A99A560-0x000000018A99A600
			internal object _Get_b__4_9(object value); // 0x000000018A99A600-0x000000018A99A6DC
			internal object _Get_b__4_10(object value); // 0x000000018A99A044-0x000000018A99A12C
			internal object _Get_b__4_11(object value); // 0x000000018A99A12C-0x000000018A99A200
			internal object _Get_b__4_12(object value); // 0x000000018A99A200-0x000000018A99A2E0
			internal object _Get_b__4_13(object value); // 0x000000018A99A2E0-0x000000018A99A360
			internal object _Get_b__4_14(object value); // 0x000000018A99A360-0x000000018A99A3E0
			internal object _Get_b__4_15(object value); // 0x000000018A99A3E0-0x000000018A99A458
			internal object _Get_b__4_16(object value); // 0x000000018A99A458-0x000000018A99A4D0
		}
	
		// Methods
		public static Func<object, object> Get(System.Type fromType, System.Type toType); // 0x0000000184115330-0x0000000184115640
		public static bool CanConvert(System.Type fromType, System.Type toType); // 0x000000018A999CF8-0x000000018A999D10
	}

	public static class ColorUtils // TypeDefIndex: 52748
	{
		// Fields
		private static Dictionary<Color32, string> colorHexCache; // 0x00
		private static Dictionary<string, UnityEngine.Color> hexColorCache; // 0x08
		private static Dictionary<ValueTuple<int, int, Gradient, float>, Texture2D> gradientTextureCache; // 0x10
		private static Dictionary<ValueTuple<UnityEngine.Color, float, UnityEngine.Color, float>, Gradient> gradientCache; // 0x18
		private static Dictionary<string, Gradient> menuItemRibbonGradientCache; // 0x20
	
		// Constructors
		static ColorUtils(); // 0x0000000183A32B50-0x0000000183A32DC0
	
		// Methods
		public static UnityEngine.Color Grey(float value); // 0x0000000184DA6870-0x0000000184DA6890
		public static string ColorToHex(Color32 color); // 0x000000018A98DAB8-0x000000018A98DC2C
		public static UnityEngine.Color HexToColor(string hex); // 0x000000018331D300-0x000000018331D4C0
		public static Texture2D CreateGradientTexture(int width, int height, Gradient gradient, float rotateDegree); // 0x000000018A98DC2C-0x000000018A98DED4
		public static Gradient CreateGradient(UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio); // 0x000000018A98DED4-0x000000018A98E160
		public static Gradient GetMenuItemRibbonGradientOfNodeFullPath(string fullPath); // 0x000000018A98E160-0x000000018A98E1E4
		public static void RegisterMenuItemRibbonGradientOfNodeFullPath(string fullPath, UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio); // 0x000000018A98E1E4-0x000000018A98E2BC
	
		// Extension methods
		public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha); // 0x0000000184DA6890-0x0000000184DA68B0
	}

	public static class CurveUtils // TypeDefIndex: 52749
	{
		// Fields
		private const float POS_CHECK_RES = 100f; // Metadata: 0x02331DC9
		private const float POS_CHECK_DISTANCE = 10f; // Metadata: 0x02331DCD
	
		// Methods
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t); // 0x000000018A98E2BC-0x000000018A98E3D4
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition); // 0x000000018A98E3D4-0x000000018A98E40C
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm); // 0x000000018A98E40C-0x000000018A98E5EC
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x000000018A98E7E0-0x000000018A98E898
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x000000018A98E5EC-0x000000018A98E7E0
	}

	public static class GUIStyleUtils // TypeDefIndex: 52750
	{
		// Extension methods
		public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018A993AE0-0x000000018A993B8C
		public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018A993C38-0x000000018A993CE4
		public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018A993A34-0x000000018A993AE0
		public static GUIStyle Overflow(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018A993B8C-0x000000018A993C38
		public static GUIStyle TextAlignment(this GUIStyle style, TextAnchor anchor); // 0x000000018A993D0C-0x000000018A993D34
		public static GUIStyle RichText(this GUIStyle style, bool rich); // 0x000000018A993CE4-0x000000018A993D0C
	}

	public static class LayerUtils // TypeDefIndex: 52751
	{
		// Methods
		public static LayerMask CreateFromNames(params string[] layerNames); // 0x000000018A994A28-0x000000018A994A30
		public static LayerMask CreateFromNumbers(params int[] layerNumbers); // 0x000000018A994A30-0x000000018A994A38
		public static LayerMask LayerNamesToMask(params string[] layerNames); // 0x000000018A994A38-0x000000018A994A94
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers); // 0x000000018A994A94-0x000000018A994AD4
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask mask); // 0x0000000184DA68B0-0x0000000184DA68C0
		public static LayerMask AddToMask(this LayerMask mask, params string[] layerNames); // 0x000000018A994948-0x000000018A994968
		public static LayerMask RemoveFromMask(this LayerMask mask, params string[] layerNames); // 0x000000018A994C78-0x000000018A994C9C
		public static bool ContainsAnyLayer(this LayerMask mask, params string[] layerNames); // 0x000000018A9949C8-0x000000018A994A28
		public static bool ContainsAllLayers(this LayerMask mask, params string[] layerNames); // 0x000000018A994968-0x000000018A9949C8
		public static string[] MaskToNames(this LayerMask mask); // 0x000000018A994AD4-0x000000018A994BB0
		public static string MaskToString(this LayerMask mask); // 0x000000018A994C3C-0x000000018A994C78
		public static string MaskToString(this LayerMask mask, string delimiter); // 0x000000018A994BB0-0x000000018A994C3C
	}

	public static class ObjectUtils // TypeDefIndex: 52753
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 52752
		{
			// Fields
			public GameObject exclude; // 0x10
			public LayerMask mask; // 0x18
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindGameObjectsWithinLayerMask_b__0(GameObject x); // 0x000000018A99AC3C-0x000000018A99ACB0
		}
	
		// Methods
		public static bool AnyEquals(object a, object b); // 0x000000018A996344-0x000000018A996408
		public static IEnumerable<GameObject> FindGameObjectsWithinLayerMask(LayerMask mask, GameObject exclude = null); // 0x000000018A996408-0x000000018A996504
	
		// Extension methods
		public static List<T> Shuffle<T>(this List<T> list);
		public static bool Is<T>(this object o, out ref T result);
		public static T GetAddComponent<T>(this GameObject gameObject)
			where T : Component;
		public static Component TransformToType(this Component current, System.Type type); // 0x000000018A996534-0x000000018A996634
		public static bool IsInLayerMask(this GameObject gameObject, LayerMask mask); // 0x000000018A996504-0x000000018A996534
	}

	public static class RectUtils // TypeDefIndex: 52754
	{
		// Methods
		public static Rect GetBoundRect(params Rect[] rects); // 0x000000018A996768-0x000000018A996888
		public static Rect GetBoundRect(params Vector2[] positions); // 0x000000018A996888-0x000000018A996998
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b); // 0x000000018A996634-0x000000018A996680
		public static Rect ExpandBy(this Rect rect, float margin); // 0x000000018A9966E8-0x000000018A996724
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin); // 0x000000018A996724-0x000000018A996768
		public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom); // 0x000000018A996680-0x000000018A9966E8
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer); // 0x000000018A996A18-0x000000018A996B50
		public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer); // 0x000000018A996998-0x000000018A996A18
	}

	public static class StringUtils // TypeDefIndex: 52755
	{
		// Fields
		public const string SPACE = " "; // Metadata: 0x02331DD3
		public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Metadata: 0x02331DD5
		public static readonly char[] CHAR_SPACE_ARRAY; // 0x00
		private static Dictionary<string, string> splitCaseCache; // 0x08
	
		// Constructors
		static StringUtils(); // 0x000000018A999888-0x000000018A9999A4
	
		// Methods
		public static string GetAlphabetLetter(int index); // 0x000000018A998A1C-0x000000018A998AAC
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x02331DD1 */); // 0x000000018A998DBC-0x000000018A999154
		public static bool SearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x02331DD2 */); // 0x000000018A999154-0x000000018A999480
	
		// Extension methods
		public static string SplitCamelCase(this string s); // 0x000000018A999480-0x000000018A999624
		public static string CapitalizeFirst(this string s); // 0x000000018A99892C-0x000000018A9989E0
		public static string CapLength(this string s, int max); // 0x000000018A9988B8-0x000000018A99892C
		public static string GetCapitals(this string s); // 0x000000018A998AAC-0x000000018A998BB4
		public static string FormatError(this string input); // 0x000000018A9989E0-0x000000018A998A1C
		public static string GetStringWithinOuter(this string input, char from, char to); // 0x000000018A998C58-0x000000018A998CC0
		public static string GetStringWithinInner(this string input, char from, char to); // 0x000000018A998BB4-0x000000018A998C58
		public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process); // 0x000000018A998CC0-0x000000018A998DBC
		public static string ToStringAdvanced(this object o); // 0x000000018A999624-0x000000018A999888
	}

	public class WeakReferenceList<T> // TypeDefIndex: 52756
		where T : class
	{
		// Fields
		private List<WeakReference<T>> list;
	
		// Properties
		public int Count { get; }
		public T this[int i] { get => default; set {} }
	
		// Constructors
		public WeakReferenceList();
		public WeakReferenceList(int capacity);
	
		// Methods
		public void Add(T item);
		public void Remove(T item);
		public bool Contains(T item, out int index);
		public void Clear();
		public List<T> ToReferenceList();
		public static implicit operator WeakReferenceList<T>(List<T> value);
	}

	public class WeakReferenceTable<TKey, TValue> // TypeDefIndex: 52757
		where TKey : class
		where TValue : IDisposable
	{
		// Fields
		private List<WeakReference<TKey>> keys;
		private List<TValue> values;
	
		// Properties
		public int Count { get; }
	
		// Constructors
		public WeakReferenceTable();
	
		// Methods
		public void Clear();
		public void Add(TKey key, TValue value);
		public void Remove(TKey key);
		public bool TryGetValueWithRefCheck(TKey key, out ref TValue value);
		public void RemoveMissingReferences();
		private void CheckCount();
	}
}

namespace ParadoxNotion.Animation
{
	public enum EaseType // TypeDefIndex: 52857
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

	public static class Easing // TypeDefIndex: 52858
	{
		// Methods
		public static float Ease(ParadoxNotion.Animation.EaseType type, float from, float to, float t); // 0x000000018A9A03F0-0x000000018A9A0474
		public static Vector3 Ease(ParadoxNotion.Animation.EaseType type, Vector3 from, Vector3 to, float t); // 0x000000018A9A030C-0x000000018A9A03F0
		public static Quaternion Ease(ParadoxNotion.Animation.EaseType type, Quaternion from, Quaternion to, float t); // 0x000000018A9A0248-0x000000018A9A030C
		public static UnityEngine.Color Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t); // 0x000000018A9A0474-0x000000018A9A0530
		public static Func<float, float> Function(ParadoxNotion.Animation.EaseType type); // 0x000000018A9A0700-0x000000018A9A0E30
		public static float Linear(float t); // 0x00000001841E1670-0x00000001841E1680
		public static float QuadraticIn(float t); // 0x0000000184D886E0-0x0000000184D886F0
		public static float QuadraticOut(float t); // 0x0000000184DA6AB0-0x0000000184DA6AD0
		public static float QuadraticInOut(float t); // 0x000000018A9A0E30-0x000000018A9A0E8C
		public static float QuarticIn(float t); // 0x0000000184DA6AD0-0x0000000184DA6AE0
		public static float QuarticOut(float t); // 0x0000000184DA6AE0-0x0000000184DA6B10
		public static float QuarticInOut(float t); // 0x000000018A9A0E8C-0x000000018A9A0EE0
		public static float QuinticIn(float t); // 0x0000000184DA6B10-0x0000000184DA6B30
		public static float QuinticOut(float t); // 0x0000000184DA6B30-0x0000000184DA6B60
		public static float QuinticInOut(float t); // 0x000000018A9A0EE0-0x000000018A9A0F3C
		public static float CubicIn(float t); // 0x0000000184D89930-0x0000000184D89940
		public static float CubicOut(float t); // 0x0000000184DA69A0-0x0000000184DA69C0
		public static float CubicInOut(float t); // 0x000000018A9A01E0-0x000000018A9A0248
		public static float SinusoidalIn(float t); // 0x000000018A9A0F3C-0x000000018A9A0F6C
		public static float SinusoidalOut(float t); // 0x000000018A9A0F6C-0x000000018A9A0F84
		public static float SinusoidalInOut(float t); // 0x0000000184DA6B60-0x0000000184DA6B90
		public static float ExponentialIn(float t); // 0x000000018A9A0690-0x000000018A9A06BC
		public static float ExponentialOut(float t); // 0x000000018A9A06BC-0x000000018A9A0700
		public static float ExponentialInOut(float t); // 0x000000018A9A0610-0x000000018A9A0690
		public static float CircularIn(float t); // 0x0000000184DA6910-0x0000000184DA6970
		public static float CircularOut(float t); // 0x0000000184DA6970-0x0000000184DA69A0
		public static float CircularInOut(float t); // 0x000000018A9A017C-0x000000018A9A01E0
		public static float ElasticIn(float t); // 0x0000000184DA69C0-0x0000000184DA6A40
		public static float ElasticOut(float t); // 0x0000000184DA6A40-0x0000000184DA6AB0
		public static float ElasticInOut(float t); // 0x000000018A9A0530-0x000000018A9A0610
		public static float BounceIn(float t); // 0x000000018A9A00B0-0x000000018A9A00E4
		public static float BounceOut(float t); // 0x000000018A9A00E4-0x000000018A9A017C
		public static float BounceInOut(float t); // 0x000000018A9A0044-0x000000018A9A00B0
		public static float BackIn(float t); // 0x0000000184DA68C0-0x0000000184DA68E0
		public static float BackOut(float t); // 0x0000000184DA68E0-0x0000000184DA6910
		public static float BackInOut(float t); // 0x000000018A99FFDC-0x000000018A9A0044
	}
}

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class SpoofAOTAttribute : Attribute // TypeDefIndex: 52859
	{
		// Constructors
		public SpoofAOTAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class CancelSpoofAOTAttribute : Attribute // TypeDefIndex: 52860
	{
		// Constructors
		public CancelSpoofAOTAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DoNotListAttribute : Attribute // TypeDefIndex: 52861
	{
		// Constructors
		public DoNotListAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ProtectedSingletonAttribute : Attribute // TypeDefIndex: 52862
	{
		// Constructors
		public ProtectedSingletonAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ExecutionPriorityAttribute : Attribute // TypeDefIndex: 52863
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public ExecutionPriorityAttribute(int priority); // 0x00000001814F51F0-0x00000001814F5220
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ExposeAsDefinitionAttribute : Attribute // TypeDefIndex: 52864
	{
		// Constructors
		public ExposeAsDefinitionAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ExposeFieldAttribute : Attribute // TypeDefIndex: 52865
	{
		// Constructors
		public ExposeFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class NodeCanvasOdinOnlyAttribute : Attribute // TypeDefIndex: 52866
	{
		// Constructors
		public NodeCanvasOdinOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ListInspectorOptionAttribute : Attribute // TypeDefIndex: 52867
	{
		// Fields
		public readonly bool allowAdd; // 0x10
		public readonly bool allowRemove; // 0x11
		public readonly bool showFoldout; // 0x12
	
		// Constructors
		public ListInspectorOptionAttribute(bool allowAdd, bool allowRemove, bool alwaysExpanded); // 0x0000000184DA6B90-0x0000000184DA6BA0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class NameAttribute : Attribute // TypeDefIndex: 52868
	{
		// Fields
		public readonly string name; // 0x10
		public readonly int priority; // 0x18
	
		// Constructors
		public NameAttribute(string name, int priority = 0 /* Metadata: 0x02331E59 */); // 0x000000018476C890-0x000000018476C8B0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 52869
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute(string category); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 52870
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute(string description); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class IconAttribute : Attribute // TypeDefIndex: 52871
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly bool fixedColor; // 0x18
		public readonly string runtimeIconTypeCallback; // 0x20
		public readonly System.Type fromType; // 0x28
	
		// Constructors
		public IconAttribute(string iconName = "" /* Metadata: 0x02331E5A */, bool fixedColor = false /* Metadata: 0x02331E5B */, string runtimeIconTypeCallback = "" /* Metadata: 0x02331E5C */); // 0x00000001848B7260-0x00000001848B7290
		public IconAttribute(System.Type fromType); // 0x0000000182FDB880-0x0000000182FDB890
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ColorAttribute : Attribute // TypeDefIndex: 52872
	{
		// Fields
		public readonly string hexColor; // 0x10
	
		// Constructors
		public ColorAttribute(string hexColor); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class ColorGradientAttribute : Attribute // TypeDefIndex: 52873
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get; } // 0x000000018A99FF14-0x000000018A99FF78 
		public UnityEngine.Color colorRight { get; } // 0x000000018A99FF78-0x000000018A99FFDC 
	
		// Constructors
		public ColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02331E5D */); // 0x000000018A99FED0-0x000000018A99FF14
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class NodeMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 52874
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get; } // 0x000000018A9A3A4C-0x000000018A9A3AB0 
		public UnityEngine.Color colorRight { get; } // 0x000000018A9A3AB0-0x000000018A9A3B14 
	
		// Constructors
		public NodeMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02331E61 */); // 0x000000018A99FED0-0x000000018A99FF14
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class NodeCategoryMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 52875
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get; } // 0x000000018A9A3984-0x000000018A9A39E8 
		public UnityEngine.Color colorRight { get; } // 0x000000018A9A39E8-0x000000018A9A3A4C 
	
		// Constructors
		public NodeCategoryMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02331E65 */); // 0x000000018A99FED0-0x000000018A99FF14
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class HideAttribute : Attribute // TypeDefIndex: 52876
	{
		// Constructors
		public HideAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public abstract class DrawerAttribute : Attribute // TypeDefIndex: 52877
	{
		// Properties
		public virtual int priority { get; } // 0x0000000184DA5AE0-0x0000000184DA5AF0 
		public virtual bool isDecorator { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		protected DrawerAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HeaderAttribute : DrawerAttribute // TypeDefIndex: 52878
	{
		// Fields
		public readonly string title; // 0x10
	
		// Properties
		public override bool isDecorator { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public HeaderAttribute(string title); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DimIfDefaultAttribute : DrawerAttribute // TypeDefIndex: 52879
	{
		// Properties
		public override bool isDecorator { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override int priority { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public DimIfDefaultAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : DrawerAttribute // TypeDefIndex: 52880
	{
		// Fields
		public readonly string fieldName; // 0x10
		public readonly int checkValue; // 0x18
	
		// Properties
		public override bool isDecorator { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override int priority { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public ShowIfAttribute(string fieldName, int checkValue); // 0x00000001848B52D0-0x00000001848B52F0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredFieldAttribute : DrawerAttribute // TypeDefIndex: 52881
	{
		// Properties
		public override bool isDecorator { get; } // 0x00000001812081B0-0x0000000181208610 
		public override int priority { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	
		// Constructors
		public RequiredFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowButtonAttribute : DrawerAttribute // TypeDefIndex: 52882
	{
		// Fields
		public readonly string buttonTitle; // 0x10
		public readonly string methodName; // 0x18
	
		// Properties
		public override bool isDecorator { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override int priority { get; } // 0x0000000184D8C9E0-0x0000000184D8C9F0 
	
		// Constructors
		public ShowButtonAttribute(string buttonTitle, string methodnameCallback); // 0x00000001832AF420-0x00000001832AF450
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : DrawerAttribute // TypeDefIndex: 52883
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Properties
		public override bool isDecorator { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override int priority { get; } // 0x0000000184D882B0-0x0000000184D882C0 
	
		// Constructors
		public CallbackAttribute(string methodName); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class MinValueAttribute : DrawerAttribute // TypeDefIndex: 52884
	{
		// Fields
		public readonly float min; // 0x10
	
		// Properties
		public override int priority { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
	
		// Constructors
		public MinValueAttribute(float min); // 0x0000000184D88280-0x0000000184D88290
		public MinValueAttribute(int min); // 0x0000000184DA6BA0-0x0000000184DA6BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DelayedFieldAttribute : DrawerAttribute // TypeDefIndex: 52885
	{
		// Constructors
		public DelayedFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class LayerFieldAttribute : DrawerAttribute // TypeDefIndex: 52886
	{
		// Constructors
		public LayerFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class TagFieldAttribute : DrawerAttribute // TypeDefIndex: 52887
	{
		// Constructors
		public TagFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class TextAreaFieldAttribute : DrawerAttribute // TypeDefIndex: 52888
	{
		// Fields
		public readonly int numberOfLines; // 0x10
	
		// Constructors
		public TextAreaFieldAttribute(int numberOfLines); // 0x00000001814F51F0-0x00000001814F5220
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class PopupFieldAttribute : DrawerAttribute // TypeDefIndex: 52889
	{
		// Fields
		public readonly object[] options; // 0x10
	
		// Constructors
		public PopupFieldAttribute(params object[] options); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SliderFieldAttribute : DrawerAttribute // TypeDefIndex: 52890
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public SliderFieldAttribute(float min, float max); // 0x0000000184D8D120-0x0000000184D8D130
		public SliderFieldAttribute(int min, int max); // 0x0000000184DA6BB0-0x0000000184DA6BD0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ForceObjectFieldAttribute : DrawerAttribute // TypeDefIndex: 52891
	{
		// Constructors
		public ForceObjectFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class UndoUtility // TypeDefIndex: 52892
	{
		// Fields
		[CompilerGenerated]
		private static string _lastOperationName_k__BackingField; // 0x00
	
		// Properties
		public static string lastOperationName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018A9A469C-0x000000018A9A46D4 0x000000018A9A46D4-0x000000018A9A4724
	
		// Methods
		[Conditional("UNITY_EDITOR")]
		public static void RecordObject(UnityEngine.Object target, string name, bool forceIgnoreScene = false /* Metadata: 0x02331E69 */); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("UNITY_EDITOR")]
		public static void RecordObjectComplete(UnityEngine.Object target, string name, bool forceIgnore = false /* Metadata: 0x02331E6A */); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("UNITY_EDITOR")]
		public static void SetDirty(UnityEngine.Object target); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("UNITY_EDITOR")]
		public static void RecordObject(UnityEngine.Object target, string name, Action operation); // 0x000000018A9A4680-0x000000018A9A469C
		[Conditional("UNITY_EDITOR")]
		public static void RecordObjectComplete(UnityEngine.Object target, string name, Action operation); // 0x000000018A9A4680-0x000000018A9A469C
		public static string GetLastOperationNameOr(string operation); // 0x000000018A9A4654-0x000000018A9A4680
		public static void CheckUndo(UnityEngine.Object target, string name); // 0x000000018A9A45A4-0x000000018A9A4654
		public static void CheckDirty(UnityEngine.Object target); // 0x000000018A9A4564-0x000000018A9A45A4
	}
}

namespace ParadoxNotion.Serialization
{
	public class DeserializeFromAttribute : Attribute // TypeDefIndex: 52778
	{
		// Fields
		public readonly string previousTypeFullName; // 0x10
	
		// Constructors
		public DeserializeFromAttribute(string previousTypeFullName); // 0x00000001853908C0-0x00000001853908D0
	}

	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor // TypeDefIndex: 52781
		where TMissing : TCanProcess, IMissingRecoverable
	{
		// Fields
		private const string FIELD_NAME_TYPE = "_missingType"; // Metadata: 0x02331DF3
		private const string FIELD_NAME_STATE = "_recoveryState"; // Metadata: 0x02331E00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 52779
		{
			// Fields
			public Dictionary<string, fsData> json;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal bool _OnBeforeDeserialize_b__0(KeyValuePair<string, fsData> kvp);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52780
		{
			// Fields
			public static readonly __c<TCanProcess, TMissing> __9;
			public static Func<KeyValuePair<string, fsData>, string> __9__3_1;
			public static Func<KeyValuePair<string, fsData>, fsData> __9__3_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _OnBeforeDeserialize_b__3_1(KeyValuePair<string, fsData> c);
			internal fsData _OnBeforeDeserialize_b__3_2(KeyValuePair<string, fsData> c);
		}
	
		// Constructors
		public fsRecoveryProcessor();
	
		// Methods
		public override bool CanProcess(System.Type type);
		public override void OnBeforeDeserialize(System.Type storageType, ref fsData data);
	}

	public class fsUnityObjectConverter : fsConverter // TypeDefIndex: 52782
	{
		// Constructors
		public fsUnityObjectConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018321CAF0-0x000000018321CB90
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A99F51C-0x000000018A99F708
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x0000000184250BD0-0x0000000184250D30
		public override object CreateInstance(fsData data, System.Type storageType); // 0x00000001811EC580-0x00000001811EC590
	}

	public interface IMissingRecoverable // TypeDefIndex: 52783
	{
		// Properties
		string missingType { get; set; }
		string recoveryState { get; set; }
	}

	public interface ISerializedMethodBaseInfo : ISerializedReflectedInfo // TypeDefIndex: 52784
	{
		// Methods
		MethodBase GetMethodBase();
		bool HasChanged();
	}

	public interface ISerializedReflectedInfo : ISerializationCallbackReceiver // TypeDefIndex: 52785
	{
		// Methods
		MemberInfo AsMemberInfo();
		string AsString();
	}

	public static class JSONSerializer // TypeDefIndex: 52786
	{
		// Fields
		public static bool enableCache; // 0x00
		private static object serializerLock; // 0x08
		private static fsSerializer serializer; // 0x10
		private static Dictionary<string, fsData> dataCache; // 0x18
	
		// Constructors
		static JSONSerializer(); // 0x00000001844D7850-0x00000001844D78D0
	
		// Methods
		public static void FlushMem(); // 0x00000001844D78D0-0x00000001844D7A00
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void __FlushDataCache(); // 0x00000001844D7A00-0x00000001844D7AB0
		public static string Serialize(System.Type type, object instance, List<UnityEngine.Object> references = null, bool pretyJson = false /* Metadata: 0x02331E0F */); // 0x000000018A99436C-0x000000018A9947CC
		public static T Deserialize<T>(string json, List<UnityEngine.Object> references = null);
		public static object Deserialize(System.Type type, string json, List<UnityEngine.Object> references = null); // 0x000000018A993ECC-0x000000018A993F34
		public static T TryDeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> references = null)
			where T : class;
		public static object TryDeserializeOverwrite(object instance, string json, List<UnityEngine.Object> references = null); // 0x000000018A9948BC-0x000000018A994948
		private static object Internal_Deserialize(System.Type type, string json, List<UnityEngine.Object> references, object instance); // 0x0000000183113DB0-0x0000000183114500
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object, fsData> call); // 0x000000018A993F50-0x000000018A994134
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object> beforeCall, Action<object, fsData> afterCall); // 0x000000018A994134-0x000000018A99436C
		public static T Clone<T>(T original);
		public static object Clone(object original); // 0x000000018A993D34-0x000000018A993DF8
		public static void CopySerialized(object source, object target); // 0x000000018A993DF8-0x000000018A993ECC
		public static void ShowData(string json, string fileName = "" /* Metadata: 0x02331E10 */); // 0x000000018A9947CC-0x000000018A9948BC
		public static string PrettifyJson(string json); // 0x000000018A993F34-0x000000018A993F50
	}

	[Serializable]
	public sealed class SerializationPair // TypeDefIndex: 52787
	{
		// Fields
		public string _json; // 0x10
		public List<UnityEngine.Object> _references; // 0x18
	
		// Constructors
		public SerializationPair(); // 0x000000018A996B50-0x000000018A996BC8
	}

	[Serializable]
	public class SerializedConstructorInfo : ISerializedMethodBaseInfo // TypeDefIndex: 52790
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
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52788
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, string> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A99AE68-0x000000018A99AECC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__4_0(ParameterInfo p); // 0x000000018A99A6DC-0x000000018A99A704
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 52789
		{
			// Fields
			public System.Type[] parameterTypes; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__0(ConstructorInfo c); // 0x000000018A99ACB0-0x000000018A99ACEC
		}
	
		// Constructors
		public SerializedConstructorInfo(); // 0x00000001841E1670-0x00000001841E1680
		public SerializedConstructorInfo(ConstructorInfo constructor); // 0x000000018A997214-0x000000018A997228
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A996F94-0x000000018A997214
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A996C84-0x000000018A996F94
		public MemberInfo AsMemberInfo(); // 0x0000000184D862C0-0x0000000184D862D0
		public MethodBase GetMethodBase(); // 0x0000000184D862C0-0x0000000184D862D0
		public bool HasChanged(); // 0x00000001811F33C0-0x00000001811F33D0
		public string AsString(); // 0x000000018A996BC8-0x000000018A996C7C
		public override string ToString(); // 0x000000018A996C7C-0x000000018A996C84
		public static implicit operator ConstructorInfo(SerializedConstructorInfo value); // 0x000000018A997228-0x000000018A997238
	}

	[Serializable]
	public class SerializedEventInfo : ISerializedReflectedInfo // TypeDefIndex: 52791
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private EventInfo _event; // 0x18
	
		// Constructors
		public SerializedEventInfo(); // 0x00000001841E1670-0x00000001841E1680
		public SerializedEventInfo(EventInfo info); // 0x0000000185392C40-0x0000000185392C50
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A9973A0-0x000000018A99745C
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A9972A0-0x000000018A9973A0
		public MemberInfo AsMemberInfo(); // 0x000000018385B100-0x000000018385B110
		public string AsString(); // 0x000000018A997238-0x000000018A997298
		public override string ToString(); // 0x000000018A997298-0x000000018A9972A0
		public static implicit operator EventInfo(SerializedEventInfo value); // 0x000000018A99745C-0x000000018A99746C
	}

	[Serializable]
	public class SerializedFieldInfo : ISerializedReflectedInfo // TypeDefIndex: 52792
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Reflection.FieldInfo _field; // 0x18
	
		// Constructors
		public SerializedFieldInfo(); // 0x00000001841E1670-0x00000001841E1680
		public SerializedFieldInfo(System.Reflection.FieldInfo info); // 0x0000000185392C40-0x0000000185392C50
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A9975E4-0x000000018A9976A0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A9974E4-0x000000018A9975E4
		public MemberInfo AsMemberInfo(); // 0x000000018385B100-0x000000018385B110
		public string AsString(); // 0x000000018A99746C-0x000000018A9974DC
		public override string ToString(); // 0x000000018A9974DC-0x000000018A9974E4
		public static implicit operator System.Reflection.FieldInfo(SerializedFieldInfo value); // 0x000000018A99745C-0x000000018A99746C
	}

	[Serializable]
	public class SerializedMethodInfo : ISerializedMethodBaseInfo // TypeDefIndex: 52795
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
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52793
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, string> __9__5_0; // 0x08
			public static Func<System.Type, string> __9__5_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018A99ADA0-0x000000018A99AE04
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__5_0(ParameterInfo p); // 0x000000018A99A6DC-0x000000018A99A704
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__5_1(System.Type a); // 0x000000018A99A704-0x000000018A99A724
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 52794
		{
			// Fields
			public string name; // 0x10
			public System.Type[] parameterTypes; // 0x18
			public bool isSerializedGeneric; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__0(MethodInfo m); // 0x000000018A99ACEC-0x000000018A99AD6C
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__1(MethodInfo m); // 0x000000018A99AD6C-0x000000018A99ADA0
		}
	
		// Constructors
		public SerializedMethodInfo(); // 0x00000001841E1670-0x00000001841E1680
		public SerializedMethodInfo(MethodInfo method); // 0x000000018A998134-0x000000018A998148
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A997CE0-0x000000018A998134
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A99775C-0x000000018A997CE0
		public MemberInfo AsMemberInfo(); // 0x0000000184D86240-0x0000000184D86250
		public MethodBase GetMethodBase(); // 0x0000000184D86240-0x0000000184D86250
		public bool HasChanged(); // 0x0000000184D865F0-0x0000000184D86600
		public string AsString(); // 0x000000018A9976A0-0x000000018A997754
		public override string ToString(); // 0x000000018A997754-0x000000018A99775C
		public static implicit operator MethodInfo(SerializedMethodInfo value); // 0x000000018A998148-0x000000018A998158
	}

	[Serializable]
	public class SerializedTypeInfo : ISerializedReflectedInfo // TypeDefIndex: 52796
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Type _type; // 0x18
	
		// Constructors
		public SerializedTypeInfo(); // 0x00000001841E1670-0x00000001841E1680
		public SerializedTypeInfo(System.Type info); // 0x000000018A8DA46C-0x000000018A8DA498
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A9981C0-0x000000018A998230
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A998158-0x000000018A9981C0
		public MemberInfo AsMemberInfo(); // 0x000000018385B100-0x000000018385B110
		public string AsString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public static implicit operator System.Type(SerializedTypeInfo value); // 0x000000018A99745C-0x000000018A99746C
	}

	[Serializable]
	public class SerializedUnityEventInfo : ISerializedReflectedInfo // TypeDefIndex: 52797
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private MemberInfo _memberInfo; // 0x18
	
		// Properties
		public bool isStatic { get; } // 0x000000018A998680-0x000000018A998758 
		public System.Type memberType { get; } // 0x000000018A998758-0x000000018A998828 
	
		// Constructors
		public SerializedUnityEventInfo(); // 0x00000001841E1670-0x00000001841E1680
		public SerializedUnityEventInfo(System.Reflection.FieldInfo info); // 0x0000000185392C40-0x0000000185392C50
		public SerializedUnityEventInfo(PropertyInfo info); // 0x0000000185392C40-0x0000000185392C50
		public SerializedUnityEventInfo(MemberInfo info); // 0x000000018A9985B4-0x000000018A998680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018A9984F8-0x000000018A9985B4
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018A9982A8-0x000000018A9984F8
		public MemberInfo AsMemberInfo(); // 0x000000018385B100-0x000000018385B110
		public string AsString(); // 0x000000018A998230-0x000000018A9982A0
		public override string ToString(); // 0x000000018A9982A0-0x000000018A9982A8
		public static implicit operator System.Reflection.FieldInfo(SerializedUnityEventInfo value); // 0x000000018A998870-0x000000018A9988B8
		public static implicit operator PropertyInfo(SerializedUnityEventInfo value); // 0x000000018A998828-0x000000018A998870
	}
}

namespace ParadoxNotion.Serialization.FullSerializer
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 52798
	{
		// Fields
		public string MemberName; // 0x10
	
		// Constructors
		public fsForwardAttribute(string memberName); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsWriteOnlyAttribute : Attribute // TypeDefIndex: 52799
	{
		// Constructors
		public fsWriteOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsReadOnlyAttribute : Attribute // TypeDefIndex: 52800
	{
		// Constructors
		public fsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 52801
	{
		// Constructors
		public fsIgnoreAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsIgnoreInBuildAttribute : Attribute // TypeDefIndex: 52802
	{
		// Constructors
		public fsIgnoreInBuildAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsSerializeAsAttribute : Attribute // TypeDefIndex: 52803
	{
		// Fields
		public readonly string Name; // 0x10
	
		// Constructors
		public fsSerializeAsAttribute(); // 0x00000001841E1670-0x00000001841E1680
		public fsSerializeAsAttribute(string name); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateToAttribute : Attribute // TypeDefIndex: 52804
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public fsMigrateToAttribute(System.Type targetType); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateVersionsAttribute : Attribute // TypeDefIndex: 52805
	{
		// Fields
		public readonly System.Type[] previousTypes; // 0x10
	
		// Constructors
		public fsMigrateVersionsAttribute(params System.Type[] previousTypes); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class fsSerializeAsReference : Attribute // TypeDefIndex: 52806
	{
		// Constructors
		public fsSerializeAsReference(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class fsDeserializeOverwrite : Attribute // TypeDefIndex: 52807
	{
		// Constructors
		public fsDeserializeOverwrite(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsUninitialized : Attribute // TypeDefIndex: 52808
	{
		// Constructors
		public fsUninitialized(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class fsAutoInstance : Attribute // TypeDefIndex: 52809
	{
		// Fields
		public readonly bool makeInstance; // 0x10
	
		// Constructors
		public fsAutoInstance(bool makeInstance = true /* Metadata: 0x02331E11 */); // 0x0000000184D86130-0x0000000184D86140
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 52810
	{
		// Fields
		public System.Type Converter; // 0x10
		public System.Type Processor; // 0x18
	
		// Constructors
		public fsObjectAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class fsBaseConverter // TypeDefIndex: 52812
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52811
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsDataType, string> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A99AE04-0x000000018A99AE68
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _FailExpectedType_b__6_0(fsDataType t); // 0x000000018A999F50-0x000000018A999FA0
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType); // 0x000000018360F660-0x000000018360F6A0
		public virtual bool RequestCycleSupport(System.Type storageType); // 0x000000018A99B4EC-0x000000018A99B57C
		public virtual bool RequestInheritanceSupport(System.Type storageType); // 0x000000018A99B57C-0x000000018A99B5A0
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types); // 0x000000018A99B1A8-0x000000018A99B4EC
		protected fsResult CheckType(fsData data, fsDataType type); // 0x000000018360FCA0-0x000000018360FD30
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x000000018A99AF94-0x000000018A99B000
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x000000018A99B000-0x000000018A99B1A8
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value);
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 52813
	{
		// Constructors
		protected fsConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public class fsCyclicReferenceManager // TypeDefIndex: 52815
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 52814
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x00000001841E1670-0x00000001841E1680
			static ObjectReferenceEqualityComparator(); // 0x0000000184D4DEF0-0x0000000184D4DF50
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x000000018829C278-0x000000018829C280
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000184DA3AC0-0x0000000184DA3AD0
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x00000001844D8810-0x00000001844D8910
	
		// Methods
		public void Clear(); // 0x0000000183114840-0x00000001831148B0
		public bool Enter(); // 0x000000018360ED40-0x000000018360ED50
		public bool Exit(); // 0x00000001831148B0-0x0000000183114910
		public object GetReferenceObject(int id); // 0x00000001836FD5D0-0x00000001836FD620
		public void AddReferenceWithId(int id, object reference); // 0x0000000184521F10-0x0000000184521F40
		public int GetReferenceId(object item); // 0x000000018A99B5A0-0x000000018A99B648
		public bool IsReference(object item); // 0x000000018A99B648-0x000000018A99B6B8
		public void MarkSerialized(object item); // 0x000000018A99B6B8-0x000000018A99B7E8
	}

	public enum fsDataType // TypeDefIndex: 52816
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 52817
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x000000018360FD30-0x000000018360FDF0 
		public bool IsNull { get; } // 0x000000018360ED30-0x000000018360ED40 
		public bool IsDouble { get; } // 0x000000018446EC20-0x000000018446EC40 
		public bool IsInt64 { get; } // 0x0000000184250E60-0x0000000184250E80 
		public bool IsBool { get; } // 0x000000018A99C0FC-0x000000018A99C148 
		public bool IsString { get; } // 0x0000000184250E40-0x0000000184250E60 
		public bool IsDictionary { get; } // 0x000000018360EDC0-0x000000018360EE10 
		public bool IsList { get; } // 0x000000018A99C148-0x000000018A99C18C 
		public double AsDouble { get; } // 0x000000018A99C0F0-0x000000018A99C0FC 
		public long AsInt64 { get; } // 0x0000000185397344-0x0000000185397350 
		public bool AsBool { get; } // 0x000000018A99C0E4-0x000000018A99C0F0 
		public string AsString { get; } // 0x0000000185393358-0x0000000185393364 
		public Dictionary<string, fsData> AsDictionary { get; } // 0x000000018539334C-0x0000000185393358 
		public List<fsData> AsList { get; } // 0x0000000185396A3C-0x0000000185396A48 
	
		// Constructors
		public fsData(); // 0x00000001840E20A0-0x00000001840E20C0
		public fsData(bool boolean); // 0x00000001840E2070-0x00000001840E20A0
		public fsData(double f); // 0x00000001843977A0-0x00000001843977E0
		public fsData(long i); // 0x000000018454C230-0x000000018454C270
		public fsData(string str); // 0x00000001853908C0-0x00000001853908D0
		public fsData(Dictionary<string, fsData> dict); // 0x00000001853908C0-0x00000001853908D0
		public fsData(List<fsData> list); // 0x00000001853908C0-0x00000001853908D0
		static fsData(); // 0x00000001840E1CB0-0x00000001840E1DC0
	
		// Methods
		public static fsData CreateDictionary(); // 0x000000018A99B8F8-0x000000018A99B9EC
		public static fsData CreateList(); // 0x000000018A99B9EC-0x000000018A99BA84
		public static fsData CreateList(int capacity); // 0x000000018A99BA84-0x000000018A99BB20
		internal void BecomeDictionary(); // 0x000000018A99B7E8-0x000000018A99B88C
		internal fsData Clone(); // 0x000000018A99B88C-0x000000018A99B8F8
		private T Cast<T>();
		public override string ToString(); // 0x000000018A99C0DC-0x000000018A99C0E4
		public override bool Equals(object obj); // 0x000000018A99BB20-0x000000018A99BB84
		public bool Equals(fsData other); // 0x000000018A99BB84-0x000000018A99C0DC
		public static bool operator ==(fsData a, fsData b); // 0x000000018A99C18C-0x000000018A99C25C
		public static bool operator !=(fsData a, fsData b); // 0x000000018A99C25C-0x000000018A99C2B0
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 52818
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 52819
	{
		// Properties
		public override System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter();
	
		// Methods
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref ref TModel model);
	}

	public static class fsGlobalConfig // TypeDefIndex: 52820
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
		static fsGlobalConfig(); // 0x00000001849AFAC0-0x00000001849AFD00
	}

	public class fsJsonParser // TypeDefIndex: 52821
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x000000018374B2F0-0x000000018374B3D0
	
		// Methods
		private fsResult MakeFailure(string message); // 0x000000018A99C2B0-0x000000018A99C43C
		private bool TryMoveNext(); // 0x000000018360D650-0x000000018360D680
		private bool HasValue(); // 0x0000000185393340-0x000000018539334C
		private bool HasValue(int offset); // 0x000000018360D680-0x000000018360D6C0
		private char Character(); // 0x0000000185393334-0x0000000185393340
		private char Character(int offset); // 0x000000018360D6C0-0x000000018360D700
		private void SkipSpace(); // 0x000000018360D090-0x000000018360D330
		private bool IsHex(char c); // 0x0000000183FA24C0-0x0000000183FA24E0
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x0000000183FA2570-0x0000000183FA25B0
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x0000000183FA24E0-0x0000000183FA2570
		private fsResult TryUnescapeChar(out char escaped); // 0x0000000183FA22A0-0x0000000183FA24C0
		private fsResult TryParseExact(string content); // 0x00000001840E1FB0-0x00000001840E2070
		private fsResult TryParseTrue(out fsData data); // 0x00000001840E1EE0-0x00000001840E1FB0
		private fsResult TryParseFalse(out fsData data); // 0x00000001840E1DC0-0x00000001840E1EE0
		private fsResult TryParseNull(out fsData data); // 0x000000018A99C43C-0x000000018A99C538
		private bool IsSeparator(char c); // 0x000000018360E020-0x000000018360E070
		private fsResult TryParseNumber(out fsData data); // 0x000000018360DD70-0x000000018360E020
		private fsResult TryParseString(out string str); // 0x000000018360D330-0x000000018360D650
		private fsResult TryParseArray(out fsData arr); // 0x0000000184030FC0-0x00000001840311E0
		private fsResult TryParseObject(out fsData obj); // 0x000000018360CCB0-0x000000018360D090
		private fsResult RunParse(out fsData data); // 0x000000018360D700-0x000000018360D970
		public static fsResult Parse(string input, out fsData data); // 0x00000001831145F0-0x00000001831146C0
		public static fsData Parse(string input); // 0x0000000183114500-0x00000001831145A0
	}

	public static class fsJsonPrinter // TypeDefIndex: 52822
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x000000018A99D7BC-0x000000018A99D828
		private static string EscapeString(string str); // 0x000000018A99D500-0x000000018A99D7BC
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x000000018A99C538-0x000000018A99CB14
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x000000018A99CB14-0x000000018A99D260
		public static string ToJson(fsData data, bool pretty); // 0x000000018A99D994-0x000000018A99D9B8
		public static void PrettyJson(fsData data, TextWriter outputStream); // 0x000000018A99D828-0x000000018A99D834
		public static string PrettyJson(fsData data); // 0x000000018A99D834-0x000000018A99D994
		public static void CompressedJson(fsData data, StreamWriter outputStream); // 0x000000018A99D3BC-0x000000018A99D3C4
		public static string CompressedJson(fsData data); // 0x000000018A99D260-0x000000018A99D3BC
		private static string ConvertDoubleToString(double d); // 0x000000018A99D3C4-0x000000018A99D500
	}

	public class fsMetaProperty // TypeDefIndex: 52823
	{
		// Fields
		[CompilerGenerated]
		private System.Reflection.FieldInfo _Field_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _JsonName_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _ReadOnly_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _WriteOnly_k__BackingField; // 0x21
		[CompilerGenerated]
		private bool _AutoInstance_k__BackingField; // 0x22
		[CompilerGenerated]
		private bool _AsReference_k__BackingField; // 0x23
	
		// Properties
		public System.Reflection.FieldInfo Field { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string JsonName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public System.Type StorageType { get; } // 0x000000018360E450-0x000000018360E480 
		public string MemberName { get; } // 0x000000018A99D9B8-0x000000018A99D9DC 
		public bool ReadOnly { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public bool WriteOnly { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86850-0x0000000184D86860 0x0000000184D86860-0x0000000184D86870
		public bool AutoInstance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86AD0-0x0000000184D86AE0 0x0000000184D86AE0-0x0000000184D86AF0
		public bool AsReference { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E070-0x0000000184D8E080 0x0000000184D8E080-0x0000000184D8E090
	
		// Constructors
		internal fsMetaProperty(System.Reflection.FieldInfo field); // 0x000000018321D640-0x000000018321D7D0
	
		// Methods
		public object Read(object context); // 0x0000000188B984D4-0x0000000188B984F8
		public void Write(object context, object value); // 0x000000018360F610-0x000000018360F630
	}

	public class fsMetaType // TypeDefIndex: 52827
	{
		// Fields
		private static Dictionary<System.Type, fsMetaType> _metaTypes; // 0x00
		private static Dictionary<System.Type, object> _defaultInstances; // 0x08
		private ObjectGenerator generator; // 0x10
		[CompilerGenerated]
		private System.Type _reflectedType_k__BackingField; // 0x18
		[CompilerGenerated]
		private fsMetaProperty[] _Properties_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _DeserializeOverwriteRequest_k__BackingField; // 0x28
	
		// Properties
		public System.Type reflectedType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public fsMetaProperty[] Properties { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool DeserializeOverwriteRequest { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
	
		// Nested types
		private delegate object ObjectGenerator(); // TypeDefIndex: 52824; 0x0000000187378308-0x0000000187378318
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 52825
		{
			// Fields
			public System.Type reflectedType; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _GetGenerator_b__0(); // 0x000000018A99A724-0x000000018A99A7BC
			internal object _GetGenerator_b__1(); // 0x000000018A99A7BC-0x000000018A99A7CC
			internal object _GetGenerator_b__2(); // 0x000000018A99A7CC-0x000000018A99A7FC
			internal object _GetGenerator_b__4(); // 0x00000001840E3BB0-0x00000001840E3BE0
			internal object _GetGenerator_b__5(); // 0x00000001836050C0-0x00000001836050E0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52826
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ObjectGenerator __9__21_3; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A99AF30-0x000000018A99AF94
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _GetGenerator_b__21_3(); // 0x000000018A99A00C-0x000000018A99A044
		}
	
		// Constructors
		private fsMetaType(System.Type reflectedType); // 0x00000001836048E0-0x00000001836049F0
		static fsMetaType(); // 0x00000001844D7BC0-0x00000001844D7CB0
	
		// Methods
		public static fsMetaType Get(System.Type type); // 0x0000000183604FD0-0x00000001836050C0
		public static void FlushMem(); // 0x00000001844D7AB0-0x00000001844D7BC0
		private static void CollectProperties(List<fsMetaProperty> properties, System.Type reflectedType); // 0x000000018321E390-0x000000018321E540
		public static bool CanSerializeField(System.Reflection.FieldInfo field); // 0x000000018321DA20-0x000000018321DD10
		private static ObjectGenerator GetGenerator(System.Type reflectedType); // 0x00000001836049F0-0x0000000183604CC0
		private static bool HasDefaultConstructor(System.Type reflectedType); // 0x0000000183604220-0x00000001836042F0
		public object GetDefaultInstance(); // 0x000000018A99D9DC-0x000000018A99DAD0
		public object CreateInstance(); // 0x0000000183604F50-0x0000000183604FD0
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 52828
	{
		// Constructors
		protected fsObjectProcessor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual bool CanProcess(System.Type type); // 0x000000018A99DAD0-0x000000018A99DB1C
		public virtual void OnBeforeSerialize(System.Type storageType, object instance); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnAfterDeserialize(System.Type storageType, object instance); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct fsResult // TypeDefIndex: 52829
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x00000001835291C0-0x00000001835291D0 
		public bool Succeeded { get; } // 0x0000000184D883E0-0x0000000184D883F0 
		public bool HasWarnings { get; } // 0x00000001831146C0-0x0000000183114760 
		public Exception AsException { get; } // 0x000000018A99DE34-0x000000018A99DF4C 
		public IEnumerable<string> RawMessages { get; } // 0x000000018A99E02C-0x000000018A99E084 
		public string FormattedMessages { get; } // 0x000000018A99DF4C-0x000000018A99E02C 
	
		// Constructors
		static fsResult(); // 0x0000000184CECC30-0x0000000184CECCD0
	
		// Methods
		public static fsResult Warn(string warning); // 0x000000018A99DD84-0x000000018A99DE34
		public static fsResult Fail(string warning); // 0x000000018A99DC8C-0x000000018A99DD38
		public void AddMessage(string message); // 0x000000018A99DB1C-0x000000018A99DBCC
		public void AddMessages(fsResult result); // 0x000000018360F630-0x000000018360F660
		private fsResult Merge(fsResult other); // 0x000000018360EE80-0x000000018360EEE0
		public static fsResult operator +(fsResult a, fsResult b); // 0x000000018360EE10-0x000000018360EE80
		public fsResult AssertSuccess(); // 0x00000001831145A0-0x00000001831145F0
		public fsResult AssertSuccessWithoutWarnings(); // 0x000000018A99DBCC-0x000000018A99DC8C
		public override string ToString(); // 0x000000018A99DD38-0x000000018A99DD84
	}

	public class fsSerializer // TypeDefIndex: 52832
	{
		// Fields
		public const string KEY_OBJECT_REFERENCE = "$ref"; // Metadata: 0x02331E19
		public const string KEY_OBJECT_DEFINITION = "$id"; // Metadata: 0x02331E1E
		public const string KEY_INSTANCE_TYPE = "$type"; // Metadata: 0x02331E22
		public const string KEY_VERSION = "$version"; // Metadata: 0x02331E28
		public const string KEY_CONTENT = "$content"; // Metadata: 0x02331E31
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
		[CompilerGenerated]
		private List<UnityEngine.Object> _ReferencesDatabase_k__BackingField; // 0x60
		[CompilerGenerated]
		private bool _IgnoreSerializeCycleReferences_k__BackingField; // 0x68
		[CompilerGenerated]
		private Action<object> onBeforeObjectSerialized; // 0x70
		[CompilerGenerated]
		private Action<object, fsData> onAfterObjectSerialized; // 0x78
	
		// Properties
		public List<UnityEngine.Object> ReferencesDatabase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public bool IgnoreSerializeCycleReferences { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86B40-0x0000000184D86B50 0x0000000184D86BA0-0x0000000184D86BB0
	
		// Events
		public event Action<object> onBeforeObjectSerialized {
			add; // 0x000000018A99F378-0x000000018A99F404
			remove; // 0x000000018A99F490-0x000000018A99F51C
		}
		public event Action<object, fsData> onAfterObjectSerialized {
			add; // 0x000000018A99F2EC-0x000000018A99F378
			remove; // 0x000000018A99F404-0x000000018A99F490
		}
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 52830
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x00000001844D8750-0x00000001844D8810
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x000000018A9A6628-0x000000018A9A675C
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x000000018A9A675C-0x000000018A9A6920
			public void Clear(); // 0x00000001831147D0-0x0000000183114840
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52831
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__58_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A9A4500-0x000000018A9A4564
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _TryDeserializeMigration_b__58_0(MethodInfo m); // 0x000000018A9A44AC-0x000000018A9A4500
		}
	
		// Constructors
		public fsSerializer(); // 0x00000001844D7CB0-0x00000001844D8400
	
		// Methods
		public static bool IsReservedKeyword(string key); // 0x0000000183F86AB0-0x0000000183F8D6F0
		public static void RemoveMetaData(ref fsData data); // 0x000000018A99E678-0x000000018A99E7E4
		private static void EnsureDictionary(ref fsData data); // 0x000000018A99E084-0x000000018A99E12C
		private static bool IsObjectReference(fsData data); // 0x000000018360ED50-0x000000018360EDC0
		private static bool IsObjectDefinition(fsData data); // 0x000000018360E480-0x000000018360E4F0
		private static bool IsVersioned(fsData data); // 0x000000018A99E5FC-0x000000018A99E678
		private static bool IsTypeSpecified(fsData data); // 0x000000018360E4F0-0x000000018360E560
		private static bool IsWrappedData(fsData data); // 0x000000018360E560-0x000000018360E5D0
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018A99E514-0x000000018A99E5FC
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018A99E4A8-0x000000018A99E514
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data); // 0x000000018360F200-0x000000018360F260
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018360F1A0-0x000000018360F200
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018360F2E0-0x000000018360F390
		public void PurgeTemporaryData(); // 0x0000000183114760-0x00000001831147D0
		private List<fsObjectProcessor> GetProcessors(System.Type type); // 0x000000018360EEE0-0x000000018360EFF0
		public void AddConverter(fsBaseConverter converter); // 0x00000001844D8400-0x00000001844D8540
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType); // 0x000000018360EFF0-0x000000018360F1A0
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data); // 0x000000018A99F00C-0x000000018A99F048
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType); // 0x000000018A99F048-0x000000018A99F2EC
		private fsResult Internal_Serialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType); // 0x000000018A99E12C-0x000000018A99E4A8
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result); // 0x0000000185396A48-0x0000000185396A84
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType); // 0x000000018360E5D0-0x000000018360E760
		private fsResult Internal_Deserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType); // 0x000000018360E760-0x000000018360ED30
		private void TryPush(object o); // 0x000000018360F470-0x000000018360F610
		private void TryPop(object o); // 0x000000018360F390-0x000000018360F470
		private void TrySerializeVersioning(object currentInstance, ref fsData data); // 0x000000018A99EEAC-0x000000018A99F00C
		private void TryDeserializeVersioning(ref object currentInstance, ref fsData currentData); // 0x000000018360F260-0x000000018360F2E0
		private void TryDeserializeMigration(ref object currentInstance, ref fsData currentData, System.Type previousType, object previousInstance); // 0x000000018A99E7E4-0x000000018A99EEAC
	}

	public interface IMigratable // TypeDefIndex: 52833
	{
	}

	public interface IMigratable<T> : IMigratable // TypeDefIndex: 52834
	{
		// Methods
		void Migrate(T model);
	}

	public interface ISerializationCollector : ISerializationCollectable // TypeDefIndex: 52835
	{
		// Methods
		void OnPush(ISerializationCollector parent);
		void OnCollect(ISerializationCollectable child, int depth);
		void OnPop(ISerializationCollector parent);
	}

	public interface ISerializationCollectable // TypeDefIndex: 52836
	{
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 52837
	{
		// Constructors
		public fsArrayConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000184707080-0x00000001847070A0
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A9A5480-0x000000018A9A565C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018A9A5218-0x000000018A9A5480
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A51C0-0x000000018A9A5218
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 52838
	{
		// Constructors
		public fsDictionaryConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018454B410-0x000000018454B4B0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x00000001848F6920-0x00000001848F6990
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018A9A565C-0x000000018A9A5BC4
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x0000000183F857E0-0x0000000183F86750
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 52839
	{
		// Constructors
		public fsEnumConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x00000001846929D0-0x00000001846929F0
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000184598ED0-0x0000000184599060
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A9A5BC4-0x000000018A9A6084
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x0000000184250D30-0x0000000184250E40
		private static bool ArrayContains<T>(T[] values, T value);
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 52840
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x000000018A9A6604-0x000000018A9A6628
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018A9A6084-0x000000018A9A60E0
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x000000018A9A6138-0x000000018A9A630C
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A9A6498-0x000000018A9A6604
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018A9A630C-0x000000018A9A6498
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A60E0-0x000000018A9A6138
	}

	public class fsListConverter : fsConverter // TypeDefIndex: 52841
	{
		// Constructors
		public fsListConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000184550680-0x0000000184550720
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000183604EB0-0x0000000183604F00
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018A9A6920-0x000000018A9A6B9C
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x0000000183F86750-0x0000000183F86AB0
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 52842
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000184450B30-0x0000000184450C10
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001812081B0-0x0000000181208610
		private static bool UseBool(System.Type type); // 0x000000018360FAE0-0x000000018360FB30
		private static bool UseInt64(System.Type type); // 0x000000018360FDF0-0x00000001836140A0
		private static bool UseDouble(System.Type type); // 0x000000018360FB30-0x000000018360FBE0
		private static bool UseString(System.Type type); // 0x000000018420D110-0x000000018420D160
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A9A6B9C-0x000000018A9A7150
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType); // 0x000000018360F6A0-0x000000018360FAE0
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 52843
	{
		// Constructors
		public fsReflectedConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x00000001844E5BC0-0x00000001844E5C70
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A9A7150-0x000000018A9A7490
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018360DA00-0x000000018360DD70
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000183604F00-0x0000000183604F50
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 52844
	{
		// Constructors
		public fsTypeConverter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000184510A20-0x0000000184510AB0
		public override bool RequestCycleSupport(System.Type type); // 0x00000001812081B0-0x0000000181208610
		public override bool RequestInheritanceSupport(System.Type type); // 0x00000001812081B0-0x0000000181208610
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018A9A75D8-0x000000018A9A76BC
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018A9A7490-0x000000018A9A75D8
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000184D8C7E0-0x0000000184D8C7F0
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 52845
	{
		// Constructors
		public AnimationCurve_DirectConverter(); // 0x00000001844D8540-0x00000001844D8570
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized); // 0x000000018A99F990-0x000000018A99FB64
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model); // 0x000000018A99F758-0x000000018A99F990
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A99F708-0x000000018A99F758
	}

	public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 52846
	{
		// Constructors
		public Bounds_DirectConverter(); // 0x00000001844D8570-0x00000001844D85A0
	
		// Methods
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized); // 0x000000018A99FD5C-0x000000018A99FED0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model); // 0x000000018A99FBB8-0x000000018A99FD5C
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A99FB64-0x000000018A99FBB8
	}

	public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 52847
	{
		// Constructors
		public Gradient_DirectConverter(); // 0x00000001844D8600-0x00000001844D8630
	
		// Methods
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized); // 0x000000018A9A2F4C-0x000000018A9A30D8
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model); // 0x000000018A9A2D84-0x000000018A9A2F4C
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A2D34-0x000000018A9A2D84
	}

	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState> // TypeDefIndex: 52848
	{
		// Constructors
		public GUIStyleState_DirectConverter(); // 0x00000001844D85A0-0x00000001844D85D0
	
		// Methods
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized); // 0x000000018A9A11B4-0x000000018A9A1350
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model); // 0x000000018A9A0FD4-0x000000018A9A11B4
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A0F84-0x000000018A9A0FD4
	}

	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 52849
	{
		// Constructors
		public GUIStyle_DirectConverter(); // 0x00000001844D85D0-0x00000001844D8600
	
		// Methods
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized); // 0x000000018A9A2270-0x000000018A9A2D34
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model); // 0x000000018A9A13A0-0x000000018A9A2270
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A1350-0x000000018A9A13A0
	}

	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 52850
	{
		// Constructors
		public Keyframe_DirectConverter(); // 0x00000001844D8630-0x00000001844D8660
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized); // 0x000000018A9A3504-0x000000018A9A3758
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model); // 0x000000018A9A326C-0x000000018A9A3504
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A3214-0x000000018A9A326C
	}

	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 52851
	{
		// Constructors
		public LayerMask_DirectConverter(); // 0x00000001844D8660-0x00000001844D8690
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized); // 0x000000018A9A389C-0x000000018A9A3984
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model); // 0x000000018A9A3798-0x000000018A9A389C
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A3758-0x000000018A9A3798
	}

	public class RectOffset_DirectConverter : fsDirectConverter<RectOffset> // TypeDefIndex: 52852
	{
		// Constructors
		public RectOffset_DirectConverter(); // 0x00000001844D8690-0x00000001844D86C0
	
		// Methods
		protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized); // 0x000000018A9A3E00-0x000000018A9A4010
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model); // 0x000000018A9A3B64-0x000000018A9A3E00
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A3B14-0x000000018A9A3B64
	}

	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 52853
	{
		// Constructors
		public Rect_DirectConverter(); // 0x00000001844D86C0-0x00000001844D86F0
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized); // 0x000000018A9A42AC-0x000000018A9A44AC
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model); // 0x000000018A9A4050-0x000000018A9A42AC
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A4010-0x000000018A9A4050
	}

	public class Vector2Int_DirectConverter : fsDirectConverter<Vector2Int> // TypeDefIndex: 52854
	{
		// Constructors
		public Vector2Int_DirectConverter(); // 0x00000001844D86F0-0x00000001844D8720
	
		// Methods
		protected override fsResult DoSerialize(Vector2Int model, Dictionary<string, fsData> serialized); // 0x000000018A9A4868-0x000000018A9A494C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2Int model); // 0x000000018A9A4764-0x000000018A9A4868
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A4724-0x000000018A9A4764
	}

	public class Vector2_DirectConverter : fsDirectConverter<Vector2> // TypeDefIndex: 52855
	{
		// Constructors
		public Vector2_DirectConverter(); // 0x000000018A9A4B90-0x000000018A9A4BB8
	
		// Methods
		protected override fsResult DoSerialize(Vector2 model, Dictionary<string, fsData> serialized); // 0x000000018A9A4AAC-0x000000018A9A4B90
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2 model); // 0x000000018A9A4998-0x000000018A9A4AAC
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A494C-0x000000018A9A4998
	}

	public class Vector3Int_DirectConverter : fsDirectConverter<Vector3Int> // TypeDefIndex: 52856
	{
		// Constructors
		public Vector3Int_DirectConverter(); // 0x00000001844D8720-0x00000001844D8750
	
		// Methods
		protected override fsResult DoSerialize(Vector3Int model, Dictionary<string, fsData> serialized); // 0x000000018A9A4D40-0x000000018A9A4E50
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector3Int model); // 0x000000018A9A4C08-0x000000018A9A4D40
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018A9A4BB8-0x000000018A9A4C08
	}
}

namespace ParadoxNotion.Services
{
	public class EventRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IDropHandler // TypeDefIndex: 52761
	{
		// Fields
		private EventRouterAnimatorMove _routerAnimatorMove; // 0x18
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onPointerEnter; // 0x20
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onPointerExit; // 0x28
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onPointerDown; // 0x30
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onPointerUp; // 0x38
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onPointerClick; // 0x40
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onDrag; // 0x48
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onDrop; // 0x50
		[CompilerGenerated]
		private EventDelegate<PointerEventData> onScroll; // 0x58
		[CompilerGenerated]
		private EventDelegate<BaseEventData> onUpdateSelected; // 0x60
		[CompilerGenerated]
		private EventDelegate<BaseEventData> onSelect; // 0x68
		[CompilerGenerated]
		private EventDelegate<BaseEventData> onDeselect; // 0x70
		[CompilerGenerated]
		private EventDelegate<AxisEventData> onMove; // 0x78
		[CompilerGenerated]
		private EventDelegate<BaseEventData> onSubmit; // 0x80
		[CompilerGenerated]
		private EventDelegate onMouseDown; // 0x88
		[CompilerGenerated]
		private EventDelegate onMouseDrag; // 0x90
		[CompilerGenerated]
		private EventDelegate onMouseEnter; // 0x98
		[CompilerGenerated]
		private EventDelegate onMouseExit; // 0xA0
		[CompilerGenerated]
		private EventDelegate onMouseOver; // 0xA8
		[CompilerGenerated]
		private EventDelegate onMouseUp; // 0xB0
		[CompilerGenerated]
		private EventDelegate onEnable; // 0xB8
		[CompilerGenerated]
		private EventDelegate onDisable; // 0xC0
		[CompilerGenerated]
		private EventDelegate onDestroy; // 0xC8
		[CompilerGenerated]
		private EventDelegate onTransformChildrenChanged; // 0xD0
		[CompilerGenerated]
		private EventDelegate onTransformParentChanged; // 0xD8
		[CompilerGenerated]
		private EventDelegate<int> onAnimatorIK; // 0xE0
		[CompilerGenerated]
		private EventDelegate onBecameInvisible; // 0xE8
		[CompilerGenerated]
		private EventDelegate onBecameVisible; // 0xF0
		[CompilerGenerated]
		private EventDelegate<ControllerColliderHit> onControllerColliderHit; // 0xF8
		[CompilerGenerated]
		private EventDelegate<GameObject> onParticleCollision; // 0x100
		[CompilerGenerated]
		private EventDelegate<UnityEngine.Collision> onCollisionEnter; // 0x108
		[CompilerGenerated]
		private EventDelegate<UnityEngine.Collision> onCollisionExit; // 0x110
		[CompilerGenerated]
		private EventDelegate<UnityEngine.Collision> onCollisionStay; // 0x118
		[CompilerGenerated]
		private EventDelegate<Collision2D> onCollisionEnter2D; // 0x120
		[CompilerGenerated]
		private EventDelegate<Collision2D> onCollisionExit2D; // 0x128
		[CompilerGenerated]
		private EventDelegate<Collision2D> onCollisionStay2D; // 0x130
		[CompilerGenerated]
		private EventDelegate<Collider> onTriggerEnter; // 0x138
		[CompilerGenerated]
		private EventDelegate<Collider> onTriggerExit; // 0x140
		[CompilerGenerated]
		private EventDelegate<Collider> onTriggerStay; // 0x148
		[CompilerGenerated]
		private EventDelegate<Collider2D> onTriggerEnter2D; // 0x150
		[CompilerGenerated]
		private EventDelegate<Collider2D> onTriggerExit2D; // 0x158
		[CompilerGenerated]
		private EventDelegate<Collider2D> onTriggerStay2D; // 0x160
		[CompilerGenerated]
		private Action<RenderTexture, RenderTexture> onRenderImage; // 0x168
		[CompilerGenerated]
		private EventDelegate onDrawGizmos; // 0x170
		[CompilerGenerated]
		private CustomEventDelegate onCustomEvent; // 0x178
	
		// Events
		public event EventDelegate<PointerEventData> onPointerEnter {
			add; // 0x000000018A9917B8-0x000000018A991844
			remove; // 0x000000018A99313C-0x000000018A9931C8
		}
		public event EventDelegate<PointerEventData> onPointerExit {
			add; // 0x000000018A991844-0x000000018A9918D0
			remove; // 0x000000018A9931C8-0x000000018A993254
		}
		public event EventDelegate<PointerEventData> onPointerDown {
			add; // 0x000000018A99172C-0x000000018A9917B8
			remove; // 0x000000018A9930B0-0x000000018A99313C
		}
		public event EventDelegate<PointerEventData> onPointerUp {
			add; // 0x000000018A9918D0-0x000000018A99195C
			remove; // 0x000000018A993254-0x000000018A9932E0
		}
		public event EventDelegate<PointerEventData> onPointerClick {
			add; // 0x000000018A9916A0-0x000000018A99172C
			remove; // 0x000000018A993024-0x000000018A9930B0
		}
		public event EventDelegate<PointerEventData> onDrag {
			add; // 0x000000018A990FAC-0x000000018A991038
			remove; // 0x000000018A992930-0x000000018A9929BC
		}
		public event EventDelegate<PointerEventData> onDrop {
			add; // 0x000000018A9910D0-0x000000018A99115C
			remove; // 0x000000018A992A54-0x000000018A992AE0
		}
		public event EventDelegate<PointerEventData> onScroll {
			add; // 0x000000018A9919EC-0x000000018A991A78
			remove; // 0x000000018A993370-0x000000018A9933FC
		}
		public event EventDelegate<BaseEventData> onUpdateSelected {
			add; // 0x000000018A992024-0x000000018A9920B0
			remove; // 0x000000018A9939A8-0x000000018A993A34
		}
		public event EventDelegate<BaseEventData> onSelect {
			add; // 0x000000018A991A78-0x000000018A991B04
			remove; // 0x000000018A9933FC-0x000000018A993488
		}
		public event EventDelegate<BaseEventData> onDeselect {
			add; // 0x000000018A990DF0-0x000000018A990E7C
			remove; // 0x000000018A992774-0x000000018A992800
		}
		public event EventDelegate<AxisEventData> onMove {
			add; // 0x000000018A991584-0x000000018A991610
			remove; // 0x000000018A992F08-0x000000018A992F94
		}
		public event EventDelegate<BaseEventData> onSubmit {
			add; // 0x000000018A991B04-0x000000018A991B94
			remove; // 0x000000018A993488-0x000000018A993518
		}
		public event EventDelegate onMouseDown {
			add; // 0x000000018A9911F4-0x000000018A99128C
			remove; // 0x000000018A992B78-0x000000018A992C10
		}
		public event EventDelegate onMouseDrag {
			add; // 0x000000018A99128C-0x000000018A991324
			remove; // 0x000000018A992C10-0x000000018A992CA8
		}
		public event EventDelegate onMouseEnter {
			add; // 0x000000018A991324-0x000000018A9913BC
			remove; // 0x000000018A992CA8-0x000000018A992D40
		}
		public event EventDelegate onMouseExit {
			add; // 0x000000018A9913BC-0x000000018A991454
			remove; // 0x000000018A992D40-0x000000018A992DD8
		}
		public event EventDelegate onMouseOver {
			add; // 0x000000018A991454-0x000000018A9914EC
			remove; // 0x000000018A992DD8-0x000000018A992E70
		}
		public event EventDelegate onMouseUp {
			add; // 0x000000018A9914EC-0x000000018A991584
			remove; // 0x000000018A992E70-0x000000018A992F08
		}
		public event EventDelegate onEnable {
			add; // 0x000000018A99115C-0x000000018A9911F4
			remove; // 0x000000018A992AE0-0x000000018A992B78
		}
		public event EventDelegate onDisable {
			add; // 0x000000018A990F14-0x000000018A990FAC
			remove; // 0x000000018A992898-0x000000018A992930
		}
		public event EventDelegate onDestroy {
			add; // 0x000000018A990E7C-0x000000018A990F14
			remove; // 0x000000018A992800-0x000000018A992898
		}
		public event EventDelegate onTransformChildrenChanged {
			add; // 0x000000018A991B94-0x000000018A991C2C
			remove; // 0x000000018A993518-0x000000018A9935B0
		}
		public event EventDelegate onTransformParentChanged {
			add; // 0x000000018A991C2C-0x000000018A991CC4
			remove; // 0x000000018A9935B0-0x000000018A993648
		}
		public event EventDelegate<int> onAnimatorIK {
			add; // 0x000000018A9906F8-0x000000018A990788
			remove; // 0x000000018A9920B0-0x000000018A992140
		}
		public event EventDelegate onAnimatorMove {
			add; // 0x000000018A990788-0x000000018A990838
			remove; // 0x000000018A992140-0x000000018A9921BC
		}
		public event EventDelegate onBecameInvisible {
			add; // 0x000000018A990838-0x000000018A9908D0
			remove; // 0x000000018A9921BC-0x000000018A992254
		}
		public event EventDelegate onBecameVisible {
			add; // 0x000000018A9908D0-0x000000018A990968
			remove; // 0x000000018A992254-0x000000018A9922EC
		}
		public event EventDelegate<ControllerColliderHit> onControllerColliderHit {
			add; // 0x000000018A990CC8-0x000000018A990D58
			remove; // 0x000000018A99264C-0x000000018A9926DC
		}
		public event EventDelegate<GameObject> onParticleCollision {
			add; // 0x000000018A991610-0x000000018A9916A0
			remove; // 0x000000018A992F94-0x000000018A993024
		}
		public event EventDelegate<UnityEngine.Collision> onCollisionEnter {
			add; // 0x000000018A9909F8-0x000000018A990A88
			remove; // 0x000000018A99237C-0x000000018A99240C
		}
		public event EventDelegate<UnityEngine.Collision> onCollisionExit {
			add; // 0x000000018A990B18-0x000000018A990BA8
			remove; // 0x000000018A99249C-0x000000018A99252C
		}
		public event EventDelegate<UnityEngine.Collision> onCollisionStay {
			add; // 0x000000018A990C38-0x000000018A990CC8
			remove; // 0x000000018A9925BC-0x000000018A99264C
		}
		public event EventDelegate<Collision2D> onCollisionEnter2D {
			add; // 0x000000018A990968-0x000000018A9909F8
			remove; // 0x000000018A9922EC-0x000000018A99237C
		}
		public event EventDelegate<Collision2D> onCollisionExit2D {
			add; // 0x000000018A990A88-0x000000018A990B18
			remove; // 0x000000018A99240C-0x000000018A99249C
		}
		public event EventDelegate<Collision2D> onCollisionStay2D {
			add; // 0x000000018A990BA8-0x000000018A990C38
			remove; // 0x000000018A99252C-0x000000018A9925BC
		}
		public event EventDelegate<Collider> onTriggerEnter {
			add; // 0x000000018A991D54-0x000000018A991DE4
			remove; // 0x000000018A9936D8-0x000000018A993768
		}
		public event EventDelegate<Collider> onTriggerExit {
			add; // 0x000000018A991E74-0x000000018A991F04
			remove; // 0x000000018A9937F8-0x000000018A993888
		}
		public event EventDelegate<Collider> onTriggerStay {
			add; // 0x000000018A991F94-0x000000018A992024
			remove; // 0x000000018A993918-0x000000018A9939A8
		}
		public event EventDelegate<Collider2D> onTriggerEnter2D {
			add; // 0x000000018A991CC4-0x000000018A991D54
			remove; // 0x000000018A993648-0x000000018A9936D8
		}
		public event EventDelegate<Collider2D> onTriggerExit2D {
			add; // 0x000000018A991DE4-0x000000018A991E74
			remove; // 0x000000018A993768-0x000000018A9937F8
		}
		public event EventDelegate<Collider2D> onTriggerStay2D {
			add; // 0x000000018A991F04-0x000000018A991F94
			remove; // 0x000000018A993888-0x000000018A993918
		}
		public event Action<RenderTexture, RenderTexture> onRenderImage {
			add; // 0x000000018A99195C-0x000000018A9919EC
			remove; // 0x000000018A9932E0-0x000000018A993370
		}
		public event EventDelegate onDrawGizmos {
			add; // 0x000000018A991038-0x000000018A9910D0
			remove; // 0x000000018A9929BC-0x000000018A992A54
		}
		public event CustomEventDelegate onCustomEvent {
			add; // 0x000000018A990D58-0x000000018A990DF0
			remove; // 0x000000018A9926DC-0x000000018A992774
		}
	
		// Nested types
		public delegate void EventDelegate(ParadoxNotion.EventData msg); // TypeDefIndex: 52758; 0x0000000182ABE1A0-0x0000000182ABE1D0
	
		public delegate void EventDelegate<T>(ParadoxNotion.EventData<T> msg); // TypeDefIndex: 52759; 0x00000000-0x00000000
	
		public delegate void CustomEventDelegate(string name, ParadoxNotion.IEventData data); // TypeDefIndex: 52760; 0x00000001838E1420-0x00000001838E1430
	
		// Constructors
		public EventRouter(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x000000018A990204-0x000000018A9902B8
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x000000018A9902B8-0x000000018A99036C
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018A990150-0x000000018A990204
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018A99036C-0x000000018A990420
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x000000018A99009C-0x000000018A990150
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018A98FE7C-0x000000018A98FF30
		void IDropHandler.OnDrop(PointerEventData eventData); // 0x000000018A98FF30-0x000000018A98FFE4
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x000000018A990420-0x000000018A9904D4
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData); // 0x000000018A990644-0x000000018A9906F8
		void ISelectHandler.OnSelect(BaseEventData eventData); // 0x000000018A9904D4-0x000000018A990588
		void IDeselectHandler.OnDeselect(BaseEventData eventData); // 0x000000018A98FDC8-0x000000018A98FE7C
		void IMoveHandler.OnMove(AxisEventData eventData); // 0x000000018A98FFE4-0x000000018A99009C
		void ISubmitHandler.OnSubmit(BaseEventData eventData); // 0x000000018A990588-0x000000018A990644
		private void OnMouseDown(); // 0x000000018A98F484-0x000000018A98F504
		private void OnMouseDrag(); // 0x000000018A98F504-0x000000018A98F584
		private void OnMouseEnter(); // 0x000000018A98F584-0x000000018A98F604
		private void OnMouseExit(); // 0x000000018A98F604-0x000000018A98F684
		private void OnMouseOver(); // 0x000000018A98F684-0x000000018A98F704
		private void OnMouseUp(); // 0x000000018A98F704-0x000000018A98F784
		private void OnEnable(); // 0x000000018A98F404-0x000000018A98F484
		private void OnDisable(); // 0x000000018A98F304-0x000000018A98F384
		private void OnDestroy(); // 0x000000018A98F284-0x000000018A98F304
		private void OnTransformChildrenChanged(); // 0x000000018A98F860-0x000000018A98F8E0
		private void OnTransformParentChanged(); // 0x000000018A98F8E0-0x000000018A98F960
		private void OnAnimatorIK(int layerIndex); // 0x000000018A98EBA0-0x000000018A98EC5C
		private void OnBecameInvisible(); // 0x000000018A98EC5C-0x000000018A98ECDC
		private void OnBecameVisible(); // 0x000000018A98ECDC-0x000000018A98ED5C
		private void OnControllerColliderHit(ControllerColliderHit hit); // 0x000000018A98F1C4-0x000000018A98F284
		private void OnParticleCollision(GameObject other); // 0x000000018A98F784-0x000000018A98F844
		private void OnCollisionEnter(UnityEngine.Collision collisionInfo); // 0x000000018A98EE18-0x000000018A98EED4
		private void OnCollisionExit(UnityEngine.Collision collisionInfo); // 0x000000018A98EF90-0x000000018A98F04C
		private void OnCollisionStay(UnityEngine.Collision collisionInfo); // 0x000000018A98F108-0x000000018A98F1C4
		private void OnCollisionEnter2D(Collision2D collisionInfo); // 0x000000018A98ED5C-0x000000018A98EE18
		private void OnCollisionExit2D(Collision2D collisionInfo); // 0x000000018A98EED4-0x000000018A98EF90
		private void OnCollisionStay2D(Collision2D collisionInfo); // 0x000000018A98F04C-0x000000018A98F108
		private void OnTriggerEnter(Collider other); // 0x000000018A98FA1C-0x000000018A98FAD8
		private void OnTriggerExit(Collider other); // 0x000000018A98FB94-0x000000018A98FC50
		private void OnTriggerStay(Collider other); // 0x000000018A98FD0C-0x000000018A98FDC8
		private void OnTriggerEnter2D(Collider2D other); // 0x000000018A98F960-0x000000018A98FA1C
		private void OnTriggerExit2D(Collider2D other); // 0x000000018A98FAD8-0x000000018A98FB94
		private void OnTriggerStay2D(Collider2D other); // 0x000000018A98FC50-0x000000018A98FD0C
		private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x000000018A98F844-0x000000018A98F860
		private void OnDrawGizmos(); // 0x000000018A98F384-0x000000018A98F404
		public void InvokeCustomEvent(string name, object value, object sender); // 0x000000018A98EABC-0x000000018A98EBA0
		public void InvokeCustomEvent<T>(string name, T value, object sender);
	}

	public class EventRouterAnimatorMove : MonoBehaviour // TypeDefIndex: 52762
	{
		// Fields
		[CompilerGenerated]
		private EventRouter.EventDelegate onAnimatorMove; // 0x18
	
		// Events
		public event EventRouter.EventDelegate onAnimatorMove {
			add; // 0x000000018A98E994-0x000000018A98EA28
			remove; // 0x000000018A98EA28-0x000000018A98EABC
		}
	
		// Constructors
		public EventRouterAnimatorMove(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnAnimatorMove(); // 0x000000018A98E918-0x000000018A98E994
	}

	public static class Logger // TypeDefIndex: 52765
	{
		// Fields
		private static List<LogHandler> subscribers; // 0x00
	
		// Nested types
		public struct Message // TypeDefIndex: 52763
		{
			// Fields
			private WeakReference<object> _contextRef; // 0x00
			public UnityEngine.LogType type; // 0x08
			public string text; // 0x10
			public string tag; // 0x18
	
			// Properties
			public object context { get; set; } // 0x000000018A995764-0x000000018A9957C0 0x000000018A9957C0-0x000000018A995844
	
			// Methods
			public bool IsValid(); // 0x000000018A97EA08-0x000000018A97EA20
		}
	
		public delegate bool LogHandler(Message message); // TypeDefIndex: 52764; 0x0000000182B99160-0x0000000182B99190
	
		// Constructors
		static Logger(); // 0x000000018A9956D8-0x000000018A995764
	
		// Methods
		public static void AddListener(LogHandler callback); // 0x000000018A994D1C-0x000000018A994D8C
		public static void RemoveListener(LogHandler callback); // 0x000000018A995668-0x000000018A9956D8
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void Log(object message, string tag = null, object context = null); // 0x000000018A9955FC-0x000000018A995668
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(object message, string tag = null, object context = null); // 0x000000018A995590-0x000000018A9955FC
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogError(object message, string tag = null, object context = null); // 0x000000018A9954B8-0x000000018A995524
		public static void LogException(Exception exception, string tag = null, object context = null); // 0x000000018A995524-0x000000018A995590
		private static void Internal_Log(UnityEngine.LogType type, object message, string tag, object context); // 0x000000018A994EB8-0x000000018A9954B8
		private static void ForwardToUnity(UnityEngine.LogType type, object message, string tag, object context); // 0x000000018A994D8C-0x000000018A994EB8
	}

	public class MonoManager : MonoBehaviour // TypeDefIndex: 52767
	{
		// Fields
		[CompilerGenerated]
		private Action onUpdate; // 0x18
		[CompilerGenerated]
		private Action onLateUpdate; // 0x20
		[CompilerGenerated]
		private Action onFixedUpdate; // 0x28
		[CompilerGenerated]
		private Action onApplicationQuit; // 0x30
		[CompilerGenerated]
		private Action<bool> onApplicationPause; // 0x38
		[CompilerGenerated]
		private Action onGUI; // 0x40
		private static bool isQuiting; // 0x00
		private static MonoManager _current; // 0x08
	
		// Properties
		public static MonoManager current { get; } // 0x000000018A995E28-0x000000018A995FD4 
	
		// Events
		public event Action onUpdate {
			add; // 0x000000018A995D94-0x000000018A995E28
			remove; // 0x000000018A9962B0-0x000000018A996344
		}
		public event Action onLateUpdate {
			add; // 0x000000018A995D00-0x000000018A995D94
			remove; // 0x000000018A99621C-0x000000018A9962B0
		}
		public event Action onFixedUpdate {
			add; // 0x000000018A995BD8-0x000000018A995C6C
			remove; // 0x000000018A9960F4-0x000000018A996188
		}
		public event Action onApplicationQuit {
			add; // 0x000000018A995B44-0x000000018A995BD8
			remove; // 0x000000018A996060-0x000000018A9960F4
		}
		public event Action<bool> onApplicationPause {
			add; // 0x000000018A995AB8-0x000000018A995B44
			remove; // 0x000000018A995FD4-0x000000018A996060
		}
		public event Action onGUI {
			add; // 0x000000018A995C6C-0x000000018A995D00
			remove; // 0x000000018A996188-0x000000018A99621C
		}
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 52766
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}
	
		// Constructors
		public MonoManager(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Purge(); // 0x0000000184D7A090-0x0000000184D7A0D0
		public static void Create(); // 0x000000018A995998-0x000000018A9959EC
		public void AddUpdateCall(UpdateMode mode, Action call); // 0x000000018A995844-0x000000018A995888
		public void RemoveUpdateCall(UpdateMode mode, Action call); // 0x000000018A995A74-0x000000018A995AB8
		protected void Awake(); // 0x000000018A995888-0x000000018A995998
		protected void OnApplicationQuit(); // 0x000000018A995A28-0x000000018A995A74
		protected void OnApplicationPause(bool isPause); // 0x000000018A995A14-0x000000018A995A28
		protected void Update(); // 0x0000000183EFA060-0x0000000183EFA080
		protected void LateUpdate(); // 0x000000018A995A00-0x000000018A995A14
		protected void FixedUpdate(); // 0x000000018A9959EC-0x000000018A995A00
	}

	public static class Threader // TypeDefIndex: 52777
	{
		// Fields
		[CompilerGenerated]
		private static bool _applicationIsPlaying_k__BackingField; // 0x00
	
		// Properties
		public static bool applicationIsPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018A999C28-0x000000018A999C78 0x000000018A999CA4-0x000000018A999CF8
		public static bool isMainThread { get; } // 0x000000018A999C78-0x000000018A999CA4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 52768
		{
			// Fields
			public Action function; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _StartAction_b__0(); // 0x0000000186DFA030-0x0000000186DFA04C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0<T1> // TypeDefIndex: 52769
		{
			// Fields
			public Action<T1> function;
			public T1 parameter1;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _StartAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0<T1, T2> // TypeDefIndex: 52770
		{
			// Fields
			public Action<T1, T2> function;
			public T1 parameter1;
			public T2 parameter2;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _StartAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0<T1, T2, T3> // TypeDefIndex: 52771
		{
			// Fields
			public Action<T1, T2, T3> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _StartAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0<TResult> // TypeDefIndex: 52772
		{
			// Fields
			public TResult result;
			public Func<TResult> function;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _StartFunction_b__0();
			internal void _StartFunction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0<TResult, T1> // TypeDefIndex: 52773
		{
			// Fields
			public TResult result;
			public Func<T1, TResult> function;
			public T1 parameter1;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _StartFunction_b__0();
			internal void _StartFunction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0<TResult, T1, T2> // TypeDefIndex: 52774
		{
			// Fields
			public TResult result;
			public Func<T1, T2, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _StartFunction_b__0();
			internal void _StartFunction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0<TResult, T1, T2, T3> // TypeDefIndex: 52775
		{
			// Fields
			public TResult result;
			public Func<T1, T2, T3, TResult> function;
			public T1 parameter1;
			public T2 parameter2;
			public T3 parameter3;
			public Action<TResult> callback;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _StartFunction_b__0();
			internal void _StartFunction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ThreadMonitor_d__17 : IEnumerator<object> // TypeDefIndex: 52776
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Thread thread; // 0x20
			public Action callback; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _ThreadMonitor_d__17(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A999E60-0x000000018A999F04
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A999F04-0x000000018A999F50
		}
	
		// Constructors
		static Threader(); // 0x0000000184D577F0-0x0000000184D57860
	
		// Methods
		public static void ManuallySyncIsPlaying(); // 0x000000018A999A30-0x000000018A999A80
		public static Thread StartAction(Thread thread, Action function, Action callback = null); // 0x000000018A999A80-0x000000018A999BB4
		public static Thread StartAction<T1>(Thread thread, Action<T1> function, T1 parameter1, Action callback = null);
		public static Thread StartAction<T1, T2>(Thread thread, Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null);
		public static Thread StartAction<T1, T2, T3>(Thread thread, Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null);
		public static Thread StartFunction<TResult>(Thread thread, Func<TResult> function, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1>(Thread thread, Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2>(Thread thread, Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2, T3>(Thread thread, Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null);
		private static void Begin(Thread thread, Action callback); // 0x000000018A9999A4-0x000000018A999A30
		[IteratorStateMachine(typeof(_ThreadMonitor_d__17))]
		private static IEnumerator ThreadMonitor(Thread thread, Action callback); // 0x000000018A999BB4-0x000000018A999C28
	}
}
