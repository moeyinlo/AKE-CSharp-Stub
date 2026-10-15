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

// Image 15: ParadoxNotion.dll - Assembly: ParadoxNotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 76162-77498

[Category("\u272B Blackboard")]
public class SetEnumFlag : ActionTask // TypeDefIndex: 76163
{
	// Fields
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70
	public readonly BBParameter<bool> Clear; // 0x78

	// Properties
	protected override string info { get; } // 0x000000018CAD4D78-0x000000018CAD4E14 

	// Constructors
	public SetEnumFlag(); // 0x000000018CAD4C4C-0x000000018CAD4D78

	// Methods
	protected override void OnExecute(); // 0x000000018CAD4AE8-0x000000018CAD4C4C
}

[Category("\u272B Blackboard")]
public class CheckEnumFlag : ConditionTask // TypeDefIndex: 76164
{
	// Fields
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable; // 0x68
	public readonly BBObjectParameter Flag; // 0x70

	// Properties
	protected override string info { get; } // 0x000000018CAC7810-0x000000018CAC7854 

	// Constructors
	public CheckEnumFlag(); // 0x000000018CAC771C-0x000000018CAC7810

	// Methods
	protected override bool OnCheck(); // 0x000000018CAC7664-0x000000018CAC771C
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 76166
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 76167
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 76168
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 76169
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 76170
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 76171
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 76172
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace FlowCanvas
{
	public class BinderConnection<T> : BinderConnection // TypeDefIndex: 76173
	{
		// Constructors
		public BinderConnection();
	
		// Methods
		public override void Bind();
		public override void UnBind();
	}

	[CancelSpoofAOT]
	public class BinderConnection : Connection // TypeDefIndex: 76175
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
		public string sourcePortID { get; private set; } // 0x000000018CAC5A78-0x000000018CAC5AB4 0x000000018783BA80-0x000000018783BA90
		public string targetPortID { get; private set; } // 0x000000018CAC5B60-0x000000018CAC5B9C 0x0000000186AB5C00-0x0000000186AB5C10
		public Port sourcePort { get; } // 0x000000018CAC5AB4-0x000000018CAC5B60 
		public Port targetPort { get; } // 0x000000018CAC5B9C-0x000000018CAC5C48 
		public System.Type bindingType { get; } // 0x000000018CAC59A8-0x000000018CAC5A78 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76174
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueHandlerObject __9__19_0; // 0x08
			public static FlowHandler __9__20_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018CAD8590-0x000000018CAD85F4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _GatherAndValidateSourcePort_b__19_0(); // 0x000000018CAD7E9C-0x000000018CAD7EF8
			internal void _GatherAndValidateTargetPort_b__20_0(Flow f); // 0x000000018CAD7EF8-0x000000018CAD7F54
		}
	
		// Constructors
		public BinderConnection(); // 0x0000000187240330-0x0000000187240340
	
		// Methods
		public static BinderConnection Create(Port source, Port target, bool recodeUndo = true /* Metadata: 0x02629CBD */, bool invokeGraphChanged = true /* Metadata: 0x02629CBE */); // 0x000000018CAC470C-0x000000018CAC4C34
		public void SetSourcePort(Port newSourcePort); // 0x000000018CAC5654-0x000000018CAC57B8
		public void SetTargetPort(Port newTargetPort); // 0x000000018CAC57B8-0x000000018CAC591C
		public void GatherAndValidateSourcePort(); // 0x000000018CAC4C34-0x000000018CAC5024
		public void GatherAndValidateTargetPort(); // 0x000000018CAC5024-0x000000018CAC54B8
		public static bool CanBeBound(Port source, Port target, BinderConnection refConnection); // 0x000000018CAC46EC-0x000000018CAC470C
		public static bool CanBeBoundVerbosed(Port source, Port target, BinderConnection refConnection, out string verbose); // 0x000000018CAC46C0-0x000000018CAC46EC
		private static string CanBeBoundVerbosed_Internal(Port source, Port target, BinderConnection refConnection); // 0x000000018CAC4448-0x000000018CAC46C0
		public override void OnDestroy(); // 0x000000018CAC554C-0x000000018CAC5654
		public override void OnDestroyAfterConnectionRemoved(); // 0x000000018CAC54B8-0x000000018CAC554C
		public virtual void Bind(); // 0x000000018CAC4320-0x000000018CAC4448
		public virtual void UnBind(); // 0x000000018CAC591C-0x000000018CAC59A8
	}

	public delegate void FlowHandler(Flow f); // TypeDefIndex: 76176; 0x0000000186CAA190-0x0000000186CAA1D0

	[SpoofAOT]
	public delegate T ValueHandler<T>(); // TypeDefIndex: 76177; 0x00000000-0x00000000

	public delegate object ValueHandlerObject(); // TypeDefIndex: 76178; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void FlowBreak(); // TypeDefIndex: 76179; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void FlowReturn(object value); // TypeDefIndex: 76180; 0x0000000185B78EA0-0x0000000185B78EB0

	[SpoofAOT]
	public struct Flow // TypeDefIndex: 76182
	{
		// Fields
		[CompilerGenerated]
		private int _ticks_k__BackingField; // 0x00
		private Dictionary<string, object> parameters; // 0x08
		private ReturnData returnData; // 0x10
		private FlowBreak breakCall; // 0x20
	
		// Properties
		public int ticks { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public static Flow New { get; } // 0x000000018724BB00-0x000000018724BB20 
	
		// Nested types
		public struct ReturnData // TypeDefIndex: 76181
		{
			// Fields
			[CompilerGenerated]
			private FlowReturn _returnCall_k__BackingField; // 0x00
			[CompilerGenerated]
			private System.Type _returnType_k__BackingField; // 0x08
	
			// Properties
			public FlowReturn returnCall { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
			public System.Type returnType { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
	
			// Constructors
			public ReturnData(FlowReturn call, System.Type type); // 0x0000000185B2C340-0x0000000185B2C370
		}
	
		// Methods
		public void Call(FlowOutput port); // 0x000000018CACF3E4-0x000000018CACF428
		public T ReadParameter<T>(string name);
		public void WriteParameter<T>(string name, T value);
		public void SetReturnData(FlowReturn call, System.Type expectedType); // 0x000000018CACF5CC-0x000000018CACF604
		public void Return(object value, FlowNode context); // 0x000000018CACF444-0x000000018CACF5CC
		public void BeginBreakBlock(FlowBreak callback); // 0x0000000187835950-0x0000000187835960
		public void EndBreakBlock(); // 0x000000018CACF428-0x000000018CACF444
		public void Break(FlowNode context); // 0x000000018CACF388-0x000000018CACF3E4
	}

	[Serializable]
	[GraphInfo(packageName = "FlowCanvas", docsURL = "https://flowcanvas.paradoxnotion.com/documentation/", resourcesURL = "https://flowcanvas.paradoxnotion.com/downloads/", forumsURL = "https://flowcanvas.paradoxnotion.com/forums-page/")]
	public abstract class FlowGraph : NodeCanvas.Framework.Graph // TypeDefIndex: 76183
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0xA0
		private List<MacroNodeWrapper> macroWrappers; // 0xA8
		private Dictionary<string, IInvokable> functions; // 0xB0
		private Dictionary<System.Type, Component> cachedAgentComponents; // 0xB8
	
		// Properties
		public override System.Type baseNodeType { get; } // 0x000000018CACB918-0x000000018CACB968 
		public override bool allowBlackboardOverrides { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool requiresAgent { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool requiresPrimeNode { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool isTree { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool canAcceptVariableDrops { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		protected FlowGraph(); // 0x000000018CACB8CC-0x000000018CACB918
	
		// Methods
		public T CallFunction<T>(string name, params object[] args);
		public object CallFunction(string name, params object[] args); // 0x000000018CACADA0-0x000000018CACAE5C
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args); // 0x000000018CACACE0-0x000000018CACADA0
		public UnityEngine.Object GetAgentComponent(System.Type type); // 0x000000018CACAE5C-0x000000018CACB108
		protected override void OnGraphInitialize(); // 0x000000018CACB208-0x000000018CACB5FC
		private void InitSecondPass(); // 0x000000018CACB108-0x000000018CACB208
		protected override void OnGraphStarted(); // 0x000000018CACB5FC-0x000000018CACB714
		protected override void OnGraphUpdate(); // 0x000000018CACB838-0x000000018CACB8CC
		protected override void OnGraphStoped(); // 0x000000018CACB714-0x000000018CACB838
	}

	[CancelSpoofAOT]
	public abstract class FlowNode : NodeCanvas.Framework.Node, ISerializationCallbackReceiver // TypeDefIndex: 76194
	{
		// Fields
		[SerializeField]
		private Dictionary<string, object> _inputPortValues; // 0x98
		[NonSerialized]
		protected Dictionary<string, Port> inputPorts; // 0xA0
		[NonSerialized]
		protected Dictionary<string, Port> outputPorts; // 0xA8
	
		// Properties
		public override bool allowDragInContentRect { get; } // 0x00000001843FFFF0-0x0000000184400000 
		protected override float? overrideNodeWidth { get; } // 0x000000018CACEF84-0x000000018CACEFC4 
		public sealed override int maxInConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public sealed override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public sealed override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public sealed override bool canSelfConnect { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public sealed override System.Type outConnectionType { get; } // 0x000000018CACEF34-0x000000018CACEF84 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x00000001845BA780-0x00000001845BA790 
		public override Alignment2x2 iconAlignment { get; } // 0x00000001872328C0-0x00000001872328D0 
		public FlowGraph flowGraph { get; } // 0x000000018CACEEF8-0x000000018CACEF34 
		protected string SPACE { get; } // 0x000000018CACEECC-0x000000018CACEEF8 
		public virtual bool ignoreSelfInstancePortAssignment { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Class)]
		public class ContextDefinedInputsAttribute : Attribute // TypeDefIndex: 76184
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedInputsAttribute(params System.Type[] types); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		public class ContextDefinedOutputsAttribute : Attribute // TypeDefIndex: 76185
		{
			// Fields
			public readonly System.Type[] types; // 0x10
	
			// Constructors
			public ContextDefinedOutputsAttribute(params System.Type[] types); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[AttributeUsage(AttributeTargets.Class)]
		public class HasRefreshButtonAttribute : Attribute // TypeDefIndex: 76186
		{
			// Constructors
			public HasRefreshButtonAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[AttributeUsage(AttributeTargets.Field)]
		public class GatherPortsCallbackAttribute : CallbackAttribute // TypeDefIndex: 76187
		{
			// Constructors
			public GatherPortsCallbackAttribute(); // 0x000000018CACF604-0x000000018CACF644
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 76188
		{
			// Fields
			public FlowNode __4__this; // 0x10
			public string ID; // 0x18
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetInputPort_b__0(Port p); // 0x000000018CAD82F0-0x000000018CAD8318
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 76189
		{
			// Fields
			public FlowNode __4__this; // 0x10
			public string ID; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetOutputPort_b__0(Port p); // 0x000000018CAD82F0-0x000000018CAD8318
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 76190
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetFirstInputOfType_b__1(Port p); // 0x000000018CAD8354-0x000000018CAD83D0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76191
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Port, int> __9__51_0; // 0x08
			public static Func<Port, int> __9__52_0; // 0x10
			public static Func<ValueInput, bool> __9__53_0; // 0x18
			public static Func<KeyValuePair<string, object>, string> __9__79_0; // 0x20
			public static Func<KeyValuePair<string, object>, object> __9__79_1; // 0x28
	
			// Constructors
			static __c(); // 0x000000018CAD852C-0x000000018CAD8590
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetFirstInputOfType_b__51_0(Port p); // 0x000000018CAD7F54-0x000000018CAD7FA0
			internal int _GetFirstOutputOfType_b__52_0(Port p); // 0x000000018CAD7FA0-0x000000018CAD7FEC
			internal bool _AssignSelfInstancePort_b__53_0(ValueInput p); // 0x000000018CAD7E68-0x000000018CAD7E9C
			internal string _ReplaceWith_b__79_0(KeyValuePair<string, object> k); // 0x000000018CAD7FEC-0x000000018CAD8020
			internal object _ReplaceWith_b__79_1(KeyValuePair<string, object> v); // 0x000000018CAD8020-0x000000018CAD8058
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 76192
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetFirstOutputOfType_b__1(Port p); // 0x000000018CAD83D0-0x000000018CAD8440
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 76193
		{
			// Fields
			public KeyValuePair<string, object> pair; // 0x10
			public FlowNode __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass57_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _DeserializeInputPortValues_b__0(Port p); // 0x000000018CAD8440-0x000000018CAD8494
		}
	
		// Constructors
		protected FlowNode(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CACEAF8-0x000000018CACEECC
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnValidate(NodeCanvas.Framework.Graph flowGraph); // 0x000000018CACD50C-0x000000018CACD514
		public sealed override void OnParentConnected(int i); // 0x0000000186805BA0-0x0000000186805BB0
		public sealed override void OnChildConnected(int i); // 0x0000000186805BA0-0x0000000186805BB0
		public sealed override void OnParentDisconnected(int i); // 0x0000000186805BA0-0x0000000186805BB0
		public sealed override void OnChildDisconnected(int i); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnPortConnected(Port port, Port otherPort); // 0x000000018CACD4A4-0x000000018CACD504
		public virtual void OnPortDisconnected(Port port, Port otherPort); // 0x000000018CACD504-0x000000018CACD50C
		public virtual void OnPortDisconnectedLate(Port port, Port otherPort); // 0x0000000186805BA0-0x0000000186805BB0
		public void BindPorts(); // 0x000000018CACC3C8-0x000000018CACC47C
		public void UnBindPorts(); // 0x000000018CACEA44-0x000000018CACEAF8
		public Port GetInputPort(string ID); // 0x000000018CACD000-0x000000018CACD15C
		public Port GetOutputPort(string ID); // 0x000000018CACD27C-0x000000018CACD3D8
		public IEnumerable<Port> GetAllPorts(); // 0x000000018CACCB50-0x000000018CACCBE0
		public int GetPortCount(); // 0x000000018CACD440-0x000000018CACD4A4
		public IEnumerable<FlowOutput> GetOutputFlowPorts(); // 0x000000018CACD214-0x000000018CACD27C
		public IEnumerable<ValueOutput> GetOutputValuePorts(); // 0x000000018CACD3D8-0x000000018CACD440
		public IEnumerable<FlowInput> GetInputFlowPorts(); // 0x000000018CACCF98-0x000000018CACD000
		public IEnumerable<ValueInput> GetInputValuePorts(); // 0x000000018CACD15C-0x000000018CACD1C4
		public Port GetFirstInputOfType(System.Type type); // 0x000000018CACCBE0-0x000000018CACCDBC
		public Port GetFirstOutputOfType(System.Type type); // 0x000000018CACCDBC-0x000000018CACCF98
		public void AssignSelfInstancePort(); // 0x000000018CACC1E4-0x000000018CACC3C8
		public void GatherPorts(); // 0x000000018CACC9C8-0x000000018CACCB50
		protected abstract void RegisterPorts();
		[Conditional("UNITY_EDITOR")]
		protected virtual void ValidateConnections(); // 0x0000000186805BA0-0x0000000186805BB0
		private void DeserializeInputPortValues(); // 0x000000018CACC58C-0x000000018CACC9C8
		[Conditional("UNITY_EDITOR")]
		private void RefreshEditorPorts(); // 0x0000000186805BA0-0x0000000186805BB0
		public FlowInput AddFlowInput(string name, string ID, FlowHandler pointer); // 0x000000018CACBA6C-0x000000018CACBA84
		public FlowInput AddFlowInput(string name, FlowHandler pointer, string ID = "" /* Metadata: 0x02629CBF */); // 0x000000018CACBA84-0x000000018CACBB74
		public FlowOutput AddFlowOutput(string name, string ID = "" /* Metadata: 0x02629CC0 */); // 0x000000018CACBB74-0x000000018CACBC50
		public ValueInput<T> AddValueInput<T>(string name, string ID = "" /* Metadata: 0x02629CC1 */);
		public ValueOutput<T> AddValueOutput<T>(string name, string ID, ValueHandler<T> getter);
		public ValueOutput<T> AddValueOutput<T>(string name, ValueHandler<T> getter, string ID = "" /* Metadata: 0x02629CC2 */);
		public void AddValueInput(System.Type valueType, string name, string ID = "" /* Metadata: 0x02629CC3 */); // 0x000000018CACBD20-0x000000018CACBEF8
		public ValueOutput<T> AddValueOutput<T>(string name, string ID = "" /* Metadata: 0x02629CC4 */);
		public void AddValueOutput(System.Type valueType, string name, string ID = "" /* Metadata: 0x02629CC5 */); // 0x000000018CACC00C-0x000000018CACC1E4
		public ValueInput AddValueInput(string name, string ID, System.Type type); // 0x000000018CACBEF8-0x000000018CACBF10
		public ValueInput AddValueInput(string name, System.Type type, string ID = "" /* Metadata: 0x02629CC6 */); // 0x000000018CACBC50-0x000000018CACBD20
		public ValueOutput AddValueOutput(string name, string ID, System.Type type, ValueHandlerObject getter); // 0x000000018CACBF10-0x000000018CACBF30
		public ValueOutput AddValueOutput(string name, System.Type type, ValueHandlerObject getter, string ID = "" /* Metadata: 0x02629CC7 */); // 0x000000018CACBF30-0x000000018CACC00C
		protected void QualifyPortNameAndID(ref string name, ref string ID, IDictionary dict); // 0x000000018CACD514-0x000000018CACD5CC
		private bool CheckReverseIDEquality(Port port, string requestedID); // 0x000000018CACC47C-0x000000018CACC58C
		public void TryAddReflectionBasedRegistrationForObject(object instance); // 0x000000018CACE328-0x000000018CACE504
		public FlowInput TryAddMethodFlowInput(MethodInfo method, object instance); // 0x000000018CACDE78-0x000000018CACE030
		public FlowOutput TryAddFieldDelegateFlowOutput(System.Reflection.FieldInfo field, object instance); // 0x000000018CACD910-0x000000018CACDA84
		public ValueInput TryAddFieldDelegateValueInput(System.Reflection.FieldInfo field, object instance); // 0x000000018CACDA84-0x000000018CACDE78
		public ValueOutput TryAddPropertyValueOutput(PropertyInfo prop, object instance); // 0x000000018CACE030-0x000000018CACE328
		public FlowNode ReplaceWith(System.Type t); // 0x000000018CACD5CC-0x000000018CACD910
		private void TryRemovePortIfMissingAndClean(Port port); // 0x000000018CACE990-0x000000018CACEA44
		public virtual System.Type GetNodeWildDefinitionType(); // 0x000000018CACD1C4-0x000000018CACD214
		private void TryHandleWildPortConnection(System.Type currentType, System.Type targetType); // 0x000000018CACE8E0-0x000000018CACE990
		public static System.Type TryGetNewGenericTypeForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Type content, System.Type context); // 0x000000018CACE6A8-0x000000018CACE8E0
		public static MethodInfo TryGetNewGenericMethodForWild(System.Type wildType, System.Type currentType, System.Type targetType, MethodInfo content); // 0x000000018CACE504-0x000000018CACE6A8
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FlowNodeNested<T> : FlowNode, IGraphAssignable<T> // TypeDefIndex: 76195
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
	public class FlowScript : FlowScriptBase // TypeDefIndex: 76196
	{
		// Properties
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public FlowScript(); // 0x000000018CACF1DC-0x000000018CACF1E4
	}

	public abstract class FlowScriptBase : FlowGraph // TypeDefIndex: 76197
	{
		// Constructors
		protected FlowScriptBase(); // 0x000000018CACF1DC-0x000000018CACF1E4
	}

	[AddComponentMenu("FlowCanvas/FlowScript Controller")]
	public class FlowScriptController : GraphOwner<FlowScript> // TypeDefIndex: 76198
	{
		// Constructors
		public FlowScriptController(); // 0x000000018CACF354-0x000000018CACF388
	
		// Methods
		public void CallFunction(string name); // 0x000000018CACF268-0x000000018CACF2E4
		public object CallFunction(string name, params object[] args); // 0x000000018CACF2E4-0x000000018CACF354
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args); // 0x000000018CACF1E4-0x000000018CACF268
	}

	public interface IEditorMenuCallbackReceiver // TypeDefIndex: 76199
	{
	}

	[Category("Events/Object/Rendering")]
	[Description("Called after all rendering is complete to render image on target camera.")]
	[Name("On Render Image", 0)]
	public class RenderImageEvent : RouterEventNode<Camera> // TypeDefIndex: 76200
	{
		// Fields
		private FlowOutput fOut; // 0xC8
		private RenderTexture t1; // 0xD0
		private RenderTexture t2; // 0xD8
	
		// Constructors
		public RenderImageEvent(); // 0x000000018CAD4AB4-0x000000018CAD4AE8
	
		// Methods
		protected override void Subscribe(EventRouter router); // 0x000000018CAD4994-0x000000018CAD4A24
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD4A24-0x000000018CAD4AB4
		private void OnRenderImage(RenderTexture source, RenderTexture dest); // 0x000000018CAD47BC-0x000000018CAD4838
		protected override void RegisterPorts(); // 0x000000018CAD4838-0x000000018CAD4994
		[CompilerGenerated]
		private RenderTexture _RegisterPorts_b__6_0(); // 0x0000000187234580-0x0000000187234590
		[CompilerGenerated]
		private RenderTexture _RegisterPorts_b__6_1(); // 0x0000000187235E40-0x0000000187235E50
	}

	public abstract class Port // TypeDefIndex: 76202
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
		public bool prettifyName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public bool forceNotDraw { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235410-0x0000000187235420 0x0000000187235420-0x0000000187235430
		public FlowNode parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string ID { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public int connections { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public bool isConnected { get; } // 0x000000018CAD47B4-0x000000018CAD47BC 
		internal BindStatus bindStatus { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		internal GUIContent displayContent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public abstract System.Type type { get; }
	
		// Nested types
		public enum BindStatus // TypeDefIndex: 76201
		{
			Valid = 0,
			Missing = 1,
			InvalidCast = 2
		}
	
		// Constructors
		public Port(); // 0x00000001829D07F0-0x00000001829D0800
		public Port(FlowNode parent, string name, string ID); // 0x000000018CAD4778-0x000000018CAD47B4
	
		// Methods
		internal Port FlagMissing(); // 0x000000018CAD3F78-0x000000018CAD3FA0
		internal Port FlagInvalidCast(); // 0x000000018CAD3F50-0x000000018CAD3F78
		internal Port FlagValid(); // 0x000000018CAD3FA0-0x000000018CAD3FC4
		public virtual bool CanAcceptConnections(); // 0x000000018CAD3E9C-0x000000018CAD3F50
		public IEnumerable<BinderConnection> GetPortConnections(); // 0x000000018CAD4144-0x000000018CAD424C
		public BinderConnection GetFirstInputConnection(); // 0x000000018CAD3FC4-0x000000018CAD4084
		public BinderConnection GetFirstOutputConnection(); // 0x000000018CAD4084-0x000000018CAD4144
		public bool IsFlowPort(); // 0x000000018CAD433C-0x000000018CAD43A0
		public bool IsValuePort(); // 0x000000018CAD45F0-0x000000018CAD4654
		public bool IsInputPort(); // 0x000000018CAD43A0-0x000000018CAD4404
		public bool IsOutputPort(); // 0x000000018CAD4404-0x000000018CAD4468
		public bool IsUnityObject(); // 0x000000018CAD4468-0x000000018CAD4508
		public bool IsUnitySceneObject(); // 0x000000018CAD4508-0x000000018CAD45F0
		public bool IsDelegate(); // 0x000000018CAD424C-0x000000018CAD42EC
		public bool IsEnumerableCollection(); // 0x000000018CAD42EC-0x000000018CAD433C
		public bool IsWild(); // 0x000000018CAD4654-0x000000018CAD46C8
		public override string ToString(); // 0x000000018CAD46C8-0x000000018CAD4718
		[CompilerGenerated]
		private bool _GetPortConnections_b__43_0(BinderConnection c); // 0x000000018CAD4718-0x000000018CAD4748
		[CompilerGenerated]
		private bool _GetPortConnections_b__43_1(BinderConnection c); // 0x000000018CAD4748-0x000000018CAD4778
		[CompilerGenerated]
		private bool _GetFirstInputConnection_b__44_0(BinderConnection c); // 0x000000018CAD4718-0x000000018CAD4748
		[CompilerGenerated]
		private bool _GetFirstOutputConnection_b__45_0(BinderConnection c); // 0x000000018CAD4748-0x000000018CAD4778
	}

	public class FlowInput : Port // TypeDefIndex: 76203
	{
		// Fields
		[CompilerGenerated]
		private FlowHandler _pointer_k__BackingField; // 0x40
	
		// Properties
		public FlowHandler pointer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public override System.Type type { get; } // 0x000000018CACBA1C-0x000000018CACBA6C 
	
		// Constructors
		public FlowInput(FlowNode parent, string name, string ID, FlowHandler pointer); // 0x000000018CACB9EC-0x000000018CACBA1C
	}

	public class FlowOutput : Port // TypeDefIndex: 76204
	{
		// Fields
		[CompilerGenerated]
		private FlowHandler pointer; // 0x40
	
		// Properties
		public override System.Type type { get; } // 0x000000018CACF0F8-0x000000018CACF148 
	
		// Events
		public event FlowHandler pointer {
			add; // 0x000000018CACF064-0x000000018CACF0F8
			remove; // 0x000000018CACF148-0x000000018CACF1DC
		}
	
		// Constructors
		public FlowOutput(FlowNode parent, string name, string ID); // 0x000000018B9E0FFC-0x000000018B9E100C
	
		// Methods
		public void Call(Flow f); // 0x000000018CACEFF0-0x000000018CACF050
		public void BindTo(FlowInput target); // 0x000000018CACEFCC-0x000000018CACEFF0
		public void Append(FlowHandler callback); // 0x000000018CACEFC4-0x000000018CACEFCC
		public void UnBind(); // 0x000000018CACF050-0x000000018CACF064
	}

	public abstract class ValueInput : Port // TypeDefIndex: 76205
	{
		// Fields
		[CompilerGenerated]
		private bool _skipSelfInstanceAssignment_k__BackingField; // 0x40
	
		// Properties
		public object value { get; } // 0x000000018CADB93C-0x000000018CADB94C 
		public bool skipSelfInstanceAssignment { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public abstract object defaultValue { get; set; }
		public abstract object serializedValue { get; set; }
		public abstract bool isDefaultValue { get; }
		public abstract System.Type type { get; }
	
		// Constructors
		public ValueInput(FlowNode parent, string name, string ID); // 0x000000018B9E0FFC-0x000000018B9E100C
	
		// Methods
		public static ValueInput<T> CreateInstance<T>(FlowNode parent, string name, string ID);
		public static ValueInput CreateInstance(System.Type t, FlowNode parent, string name, string ID); // 0x000000018CADB768-0x000000018CADB8FC
		public ValueInput SetDefaultAndSerializedValue(object v); // 0x000000018CADB8FC-0x000000018CADB93C
		public ValueInput SkipSelfInstanceAssignment(bool skip); // 0x0000000187254020-0x0000000187254030
		public abstract void BindTo(ValueOutput target);
		public abstract void UnBind();
		public abstract object GetObjectValue();
	}

	public class ValueInput<T> : ValueInput // TypeDefIndex: 76206
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

	public abstract class ValueOutput : Port // TypeDefIndex: 76207
	{
		// Constructors
		public ValueOutput(FlowNode parent, string name, string ID); // 0x000000018B9E0FFC-0x000000018B9E100C
	
		// Methods
		public static ValueOutput<T> CreateInstance<T>(FlowNode parent, string name, string ID, ValueHandler<T> getter);
		public static ValueOutput CreateInstance(System.Type t, FlowNode parent, string name, string ID, ValueHandlerObject getter); // 0x000000018CADB94C-0x000000018CADBB00
		public abstract object GetObjectValue();
	}

	public class ValueOutput<T> : ValueOutput // TypeDefIndex: 76209
	{
		// Fields
		[CompilerGenerated]
		private ValueHandler<T> _getter_k__BackingField;
	
		// Properties
		public ValueHandler<T> getter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override System.Type type { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76208
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

	public static class TypeConverter // TypeDefIndex: 76216
	{
		// Fields
		[CompilerGenerated]
		private static CustomConverter customConverter; // 0x00
		[CompilerGenerated]
		private static CustomCanConvert customCanConvert; // 0x08
	
		// Events
		public static event CustomConverter customConverter {
			add; // 0x000000018CAD7C68-0x000000018CAD7D10
			remove; // 0x000000018CAD7DC0-0x000000018CAD7E68
		}
		public static event CustomCanConvert customCanConvert {
			add; // 0x000000018CAD7BB8-0x000000018CAD7C68
			remove; // 0x000000018CAD7D10-0x000000018CAD7DC0
		}
	
		// Nested types
		public delegate ValueHandler<object> CustomConverter(System.Type sourceType, System.Type targetType, ValueHandler<object> func); // TypeDefIndex: 76210; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate bool? CustomCanConvert(System.Type sourceType, System.Type targetType); // TypeDefIndex: 76211; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0<T> // TypeDefIndex: 76212
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
		private sealed class __c__DisplayClass8_1<T> // TypeDefIndex: 76213
		{
			// Fields
			public ValueHandler<object> converter;
	
			// Constructors
			public __c__DisplayClass8_1();
	
			// Methods
			internal T _GetConverterFuncFromTo_b__15();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_2<T> // TypeDefIndex: 76214
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
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 76215
		{
			// Fields
			public object obj; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _QuickConvert_b__0(); // 0x00000001829260F0-0x0000000182926100
		}
	
		// Methods
		public static ValueHandler<T> GetConverterFuncFromTo<T>(System.Type sourceType, System.Type targetType, ValueHandler<object> func);
		public static bool HasConvertion(System.Type sourceType, System.Type targetType); // 0x000000018CAD79E0-0x000000018CAD7A8C
		public static T QuickConvert<T>(object obj);
		public static object QuickConvert(object obj, System.Type type); // 0x000000018CAD7A8C-0x000000018CAD7BB8
	}

	public class Wild // TypeDefIndex: 76217
	{
		// Constructors
		public Wild(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace FlowCanvas.Macros
{
	[CreateAssetMenu(menuName = "ParadoxNotion/FlowCanvas/Macro Asset")]
	public class Macro : FlowScriptBase // TypeDefIndex: 76797
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
		public override bool allowBlackboardOverrides { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public MacroInputNode entry { get; } // 0x000000018CB016D8-0x000000018CB017E8 
		public MacroOutputNode exit { get; } // 0x000000018CB017E8-0x000000018CB018F8 
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 76791
		{
			// Fields
			public List<DynamicParameterDefinition> inputDefinitions; // 0x10
			public List<DynamicParameterDefinition> outputDefinitions; // 0x18
	
			// Constructors
			public DerivedSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 76792
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddInputDefinition_b__0(DynamicParameterDefinition d); // 0x000000018CB05A98-0x000000018CB05AE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 76793
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddOutputDefinition_b__0(DynamicParameterDefinition d); // 0x000000018CB05A98-0x000000018CB05AE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0<T> // TypeDefIndex: 76794
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
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 76795
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CallFlowInput_b__0(DynamicParameterDefinition d); // 0x000000018CB05AE8-0x000000018CB05B74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0<T> // TypeDefIndex: 76796
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal bool _GetValueOutput_b__0(DynamicParameterDefinition d);
		}
	
		// Constructors
		public Macro(); // 0x000000018CB014B4-0x000000018CB016D8
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x000000018CB013CC-0x000000018CB0143C
		public override void OnDerivedDataDeserialization(object data); // 0x000000018CB01304-0x000000018CB013CC
		protected override void OnGraphValidate(); // 0x000000018CB0143C-0x000000018CB014B4
		public Port AddInputDefinition(DynamicParameterDefinition def); // 0x000000018CB00EE8-0x000000018CB0104C
		public Port AddOutputDefinition(DynamicParameterDefinition def); // 0x000000018CB0104C-0x000000018CB011B0
		public void AddExamplePorts(); // 0x000000018CB00D60-0x000000018CB00EE8
		public void SetValueInput<T>(string name, T value);
		public void CallFlowInput(string name); // 0x000000018CB011B0-0x000000018CB01304
		public T GetValueOutput<T>(string name);
	}

	[Description("Defines the Input ports of the Macro.\nTo quickly create ports, you can also Drag&Drop a connection on top of this node!")]
	[DoNotList]
	[Icon("MacroIn", false, "")]
	[ProtectedSingleton]
	public class MacroInputNode : FlowNode // TypeDefIndex: 76799
	{
		// Properties
		public override Alignment2x2 iconAlignment { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		private Macro macro { get; } // 0x000000018CAFFF24-0x000000018CAFFF60 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76798
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
			public MacroInputNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CB05D20-0x000000018CB05DB0
		}
	
		// Constructors
		public MacroInputNode(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAFFC18-0x000000018CAFFF24
	}

	[Color("ffe4e1")]
	[DoNotList]
	[DropReferenceType(typeof(Macro))]
	[HasRefreshButton]
	public class MacroNodeWrapper : FlowNode, IGraphAssignable, IUpdatable // TypeDefIndex: 76803
	{
		// Fields
		[SerializeField]
		private Macro _macro; // 0xB0
		private Macro _currentInstance; // 0xB8
	
		// Properties
		public override string name { get; } // 0x000000018CB008E4-0x000000018CB0096C 
		public override string description { get; } // 0x000000018CB00848-0x000000018CB008E4 
		public Macro macro { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018CB0096C-0x000000018CB00A0C
		NodeCanvas.Framework.Graph IGraphAssignable.subGraph { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018CB001BC-0x000000018CB00210
		NodeCanvas.Framework.Graph IGraphAssignable.currentInstance { get; set; } // 0x0000000187232C80-0x0000000187232C90 0x000000018CB000F8-0x000000018CB00160
		List<BBMappingParameter> IGraphAssignable.variablesMap { get; set; } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		BBParameter IGraphAssignable.subGraphParameter { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> IGraphAssignable.instances { get; set; } // 0x000000018CB00064-0x000000018CB000F8 0x000000018CB00160-0x000000018CB001BC
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 76800
		{
			// Fields
			public Macro target; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_1 // TypeDefIndex: 76801
		{
			// Fields
			public DynamicParameterDefinition defIn; // 0x10
			public __c__DisplayClass25_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass25_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CB05B74-0x000000018CB05C2C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_2 // TypeDefIndex: 76802
		{
			// Fields
			public DynamicParameterDefinition defOut; // 0x10
			public __c__DisplayClass25_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass25_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__1(); // 0x000000018CB05C2C-0x000000018CB05CBC
		}
	
		// Constructors
		public MacroNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public void MakeInstance(); // 0x000000018CAFFF60-0x000000018CB00064
		void IUpdatable.Update(); // 0x000000018CB00210-0x000000018CB00290
		protected override void RegisterPorts(); // 0x000000018CB00290-0x000000018CB00848
	}

	[Description("Defines the Output ports of the Macro.\nTo quickly create ports, you can also Drag&Drop a connection on top of this node!")]
	[DoNotList]
	[Icon("MacroOut", false, "")]
	[ProtectedSingleton]
	public class MacroOutputNode : FlowNode // TypeDefIndex: 76805
	{
		// Properties
		public override Alignment2x2 iconAlignment { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		private Macro macro { get; } // 0x000000018CB00D24-0x000000018CB00D60 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76804
		{
			// Fields
			public DynamicParameterDefinition def; // 0x10
			public MacroOutputNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CB05DB0-0x000000018CB05E68
		}
	
		// Constructors
		public MacroOutputNode(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CB00A0C-0x000000018CB00D24
	}
}

namespace FlowCanvas.Nodes
{
	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public class ExternalImplementedNodeWrapper : FlowNode // TypeDefIndex: 76218
	{
		// Fields
		[SerializeField]
		private UnityEngine.Object _target; // 0xB0
	
		// Properties
		public IExternalImplementedNode target { get; set; } // 0x000000018CACAA90-0x000000018CACAAD0 0x000000018CACAAD0-0x000000018CACAB4C
		public override string name { get; } // 0x000000018CACAA10-0x000000018CACAA90 
	
		// Constructors
		public ExternalImplementedNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected System.Type GetRuntimeIconType(); // 0x000000018CACA95C-0x000000018CACA984
		protected override void RegisterPorts(); // 0x000000018CACA984-0x000000018CACAA08
		public void SetTarget(IExternalImplementedNode target); // 0x000000018CACAA08-0x000000018CACAA10
	}

	public interface IDropedReferenceNode : IGraphElement // TypeDefIndex: 76219
	{
		// Methods
		void SetTarget(UnityEngine.Object target);
	}

	public interface IExternalImplementedNode // TypeDefIndex: 76220
	{
		// Methods
		void RegisterPorts(FlowNode parent);
	}

	[Category("Events/Application")]
	[Description("Called when the Application is paused or resumed")]
	[Name("On Application Pause", 0)]
	public class ApplicationPauseEvent : EventNode // TypeDefIndex: 76221
	{
		// Fields
		private FlowOutput pause; // 0xB0
		private bool isPause; // 0xB8
	
		// Constructors
		public ApplicationPauseEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CAC3F1C-0x000000018CAC3FB4
		public override void OnGraphStoped(); // 0x000000018CAC3FB4-0x000000018CAC404C
		private void ApplicationPause(bool isPause); // 0x000000018CAC3EC8-0x000000018CAC3F1C
		protected override void RegisterPorts(); // 0x000000018CAC404C-0x000000018CAC413C
		[CompilerGenerated]
		private bool _RegisterPorts_b__5_0(); // 0x000000018223B190-0x000000018223B1A0
	}

	[Category("Events/Application")]
	[Description("Called when the Application quit")]
	[Name("On Application Quit", 0)]
	public class ApplicationQuitEvent : EventNode // TypeDefIndex: 76222
	{
		// Fields
		private FlowOutput quit; // 0xB0
	
		// Constructors
		public ApplicationQuitEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CAC418C-0x000000018CAC4224
		public override void OnGraphStoped(); // 0x000000018CAC4224-0x000000018CAC42BC
		private void ApplicationQuit(); // 0x000000018CAC413C-0x000000018CAC418C
		protected override void RegisterPorts(); // 0x000000018CAC42BC-0x000000018CAC4320
	}

	[Description("Automatically Subscribes to the target C# Event when the graph is enabled, and is called when the event is raised")]
	[DoNotList]
	[Name("C# Event", 0)]
	public class CSharpAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 76224
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
		private EventInfo eventInfo { get; } // 0x000000018B71515C-0x000000018B715170 
		private bool isStaticEvent { get; } // 0x000000018CAC62C0-0x000000018CAC6330 
		public override string name { get; } // 0x000000018CAC6330-0x000000018CAC6458 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 76223
		{
			// Fields
			public int i; // 0x10
			public CSharpAutoCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAD8248-0x000000018CAD8280
		}
	
		// Constructors
		public CSharpAutoCallbackEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F90-0x0000000187232FA0
		public void SetEvent(EventInfo info, object instance = null); // 0x000000018CAC6238-0x000000018CAC62C0
		protected override void RegisterPorts(); // 0x000000018CAC5F1C-0x000000018CAC6238
		public override void OnGraphStarted(); // 0x000000018CAC5CAC-0x000000018CAC5E08
		public override void OnGraphStoped(); // 0x000000018CAC5E08-0x000000018CAC5F1C
		private void OnEventRaised(params object[] args); // 0x000000018CAC5C48-0x000000018CAC5CAC
	}

	[Category("Events/Custom")]
	[Description("Providing a C# Event, Register a callback to be called when that event is raised.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(SharpEvent) })]
	[Name("C# Event Callback", 2)]
	public class CSharpEventCallback : EventNode, IReflectedWrapper // TypeDefIndex: 76226
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
		private System.Type type { get; set; } // 0x000000018CAC6CD0-0x000000018CAC6CE4 0x000000018CAC6CE4-0x000000018CAC6D90
		private bool autoHandleRegistration { get; } // 0x000000018225E0F0-0x000000018225E100 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 76225
		{
			// Fields
			public int i; // 0x10
			public CSharpEventCallback __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAD8280-0x000000018CAD82B8
		}
	
		// Constructors
		public CSharpEventCallback(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232C80-0x0000000187232C90
		public override void OnGraphStarted(); // 0x000000018CAC650C-0x000000018CAC6554
		public override void OnGraphStoped(); // 0x000000018CAC6554-0x000000018CAC65B8
		protected override void RegisterPorts(); // 0x000000018CAC66A8-0x000000018CAC6AE0
		private void Register(Flow f = default); // 0x000000018CAC6AE0-0x000000018CAC6BFC
		private void Unregister(Flow f = default); // 0x000000018CAC6BFC-0x000000018CAC6CD0
		private void Callback(params object[] args); // 0x000000018CAC6458-0x000000018CAC64BC
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018CAC64BC-0x000000018CAC650C
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018CAC65B8-0x000000018CAC66A8
	}

	[Category("Events/Custom")]
	[Description("Called when a custom event is received on target(s).\n- Receiver, is the object which received the event.\n- Sender, is the object which invoked the event.\n\n- To send an event from a graph use the SendEvent node.\n- To send an event from code use: \'FlowScriptController.SendEvent(string)\'")]
	[Name("Custom Event", 100)]
	public class CustomEvent : RouterEventNode<GraphOwner> // TypeDefIndex: 76227
	{
		// Fields
		[DelayedField]
		[RequiredField]
		public BBParameter<string> eventName; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private GraphOwner sender; // 0xD8
		private GraphOwner receiver; // 0xE0
	
		// Properties
		public override string name { get; } // 0x000000018CAC9EA8-0x000000018CAC9F20 
	
		// Constructors
		public CustomEvent(); // 0x000000018CAC9E34-0x000000018CAC9EA8
	
		// Methods
		protected override void Subscribe(EventRouter router); // 0x000000018CAC9D14-0x000000018CAC9DA4
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC9DA4-0x000000018CAC9E34
		protected override void RegisterPorts(); // 0x000000018CAC9BB8-0x000000018CAC9D14
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData msg); // 0x000000018CAC9A14-0x000000018CAC9BB8
		[CompilerGenerated]
		private GraphOwner _RegisterPorts_b__8_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GraphOwner _RegisterPorts_b__8_1(); // 0x0000000187235E40-0x0000000187235E50
	}

	[Category("Events/Custom")]
	[Description("Called when a custom event is received on target(s).\n- Receiver, is the object which received the event.\n- Sender, is the object which invoked the event.\n\n- To send an event from a graph use the SendEvent(T) node.\n- To send an event from code use: \'FlowScriptController.SendEvent(string, T)\'")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Custom Event", 100)]
	public class CustomEvent<T> : RouterEventNode<GraphOwner> // TypeDefIndex: 76228
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
	public class DelegateCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 76230
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB0
		private ReflectedDelegateEvent reflectedEvent; // 0xB8
		private ValueOutput delegatePort; // 0xC0
		private FlowOutput callbackPort; // 0xC8
		private object[] args; // 0xD0
	
		// Properties
		private System.Type delegateType { get; set; } // 0x000000018B71515C-0x000000018B715170 0x000000018CACA494-0x000000018CACA540
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 76229
		{
			// Fields
			public int i; // 0x10
			public DelegateCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__1(); // 0x000000018CAD84F4-0x000000018CAD852C
		}
	
		// Constructors
		public DelegateCallbackEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F90-0x0000000187232FA0
		protected override void RegisterPorts(); // 0x000000018CACA08C-0x000000018CACA474
		private void Callback(params object[] args); // 0x000000018CAC9F20-0x000000018CAC9F84
		public override void OnGraphStoped(); // 0x000000018CAC9F84-0x000000018CAC9F9C
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018CAC9F9C-0x000000018CACA08C
		[CompilerGenerated]
		private object _RegisterPorts_b__9_0(); // 0x000000018CACA474-0x000000018CACA494
	}

	[Description("Returns a reference of a C# event, which can be used with the C# Event Callback node.")]
	[DoNotList]
	public class GetSharpEvent : FlowNode, IReflectedWrapper // TypeDefIndex: 76232
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo _event; // 0xB0
		private ValueInput instancePort; // 0xB8
	
		// Properties
		private EventInfo eventInfo { get; } // 0x000000018B71515C-0x000000018B715170 
		public override string name { get; } // 0x000000018CACF8CC-0x000000018CACFA44 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 76231
		{
			// Fields
			public SharpEvent wrapper; // 0x10
			public GetSharpEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAD8494-0x000000018CAD84F4
		}
	
		// Constructors
		public GetSharpEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F90-0x0000000187232FA0
		public void SetEvent(EventInfo info, object instance = null); // 0x000000018CACF844-0x000000018CACF8CC
		protected override void RegisterPorts(); // 0x000000018CACF644-0x000000018CACF844
	}

	[Category("Events/Signals")]
	[Description("Invoke a defined Signal. Signals are similar to name-based events but are safer to changes and support multiple parameters.")]
	[DropReferenceType(typeof(SignalDefinition))]
	[HasRefreshButton]
	public class InvokeSignal : FlowNode, IDropedReferenceNode // TypeDefIndex: 76234
	{
		// Fields
		[GatherPortsCallback]
		public BBParameter<SignalDefinition> _signalDefinition; // 0xB0
		[GatherPortsCallback]
		public bool global; // 0xB8
		private ValueInput<Transform> target; // 0xC0
		private ValueInput[] inputArgs; // 0xC8
	
		// Properties
		private SignalDefinition signalDefinition { get; set; } // 0x000000018CAD08B8-0x000000018CAD0900 0x000000018CAD0900-0x000000018CAD0958
		public override string name { get; } // 0x000000018CAD07E0-0x000000018CAD08B8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 76233
		{
			// Fields
			public InvokeSignal __4__this; // 0x10
			public FlowOutput exit; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAD8058-0x000000018CAD8248
		}
	
		// Constructors
		public InvokeSignal(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public void SetTarget(UnityEngine.Object target); // 0x000000018CAD0780-0x000000018CAD07E0
		protected override void RegisterPorts(); // 0x000000018CAD04A8-0x000000018CAD0780
	}

	[Category("Events/Signals")]
	[Description("Check if a defined Signal has been invoked. Signals are similar to name-based events but are safer to changes and support multiple parameters.")]
	[DropReferenceType(typeof(SignalDefinition))]
	[ExecutionPriority(100)]
	[HasRefreshButton]
	public class SignalCallback : RouterEventNode<Transform>, IDropedReferenceNode // TypeDefIndex: 76236
	{
		// Fields
		[GatherPortsCallback]
		public BBParameter<SignalDefinition> _signalDefinition; // 0xC8
		private FlowOutput onReceived; // 0xD0
		private Transform receiver; // 0xD8
		private Transform sender; // 0xE0
		private object[] args; // 0xE8
	
		// Properties
		private SignalDefinition signalDefinition { get; set; } // 0x000000018CAD55FC-0x000000018CAD5644 0x000000018CAD5644-0x000000018CAD569C
		public override string name { get; } // 0x000000018CAD5514-0x000000018CAD55FC 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 76235
		{
			// Fields
			public int i; // 0x10
			public SignalCallback __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__2(); // 0x000000018CAD82B8-0x000000018CAD82F0
		}
	
		// Constructors
		public SignalCallback(); // 0x000000018CAD54E0-0x000000018CAD5514
	
		// Methods
		public void SetTarget(UnityEngine.Object target); // 0x000000018CAD5480-0x000000018CAD54E0
		protected override void Subscribe(EventRouter router); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void UnSubscribe(EventRouter router); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnPostGraphStarted(); // 0x000000018CAD5058-0x000000018CAD5194
		public override void OnGraphStoped(); // 0x000000018CAD4E14-0x000000018CAD4F00
		protected override void RegisterPorts(); // 0x000000018CAD5194-0x000000018CAD5480
		private void OnInvoked(Transform sender, Transform receiver, bool isGlobal, object[] args); // 0x000000018CAD4F00-0x000000018CAD5058
		[CompilerGenerated]
		private Transform _RegisterPorts_b__15_0(); // 0x0000000187235E40-0x0000000187235E50
		[CompilerGenerated]
		private Transform _RegisterPorts_b__15_1(); // 0x00000001872360B0-0x00000001872360C0
	}

	[Description("Automatically Subscribes to the target UnityEvent when the graph is enabled, and is called when the event is raised")]
	[DoNotList]
	[Name("Unity Event", 0)]
	public class UnityEventAutoCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 76238
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
		private MemberInfo member { get; } // 0x000000018CADAAEC-0x000000018CADAB08 
		private bool isStatic { get; } // 0x000000018CADAAC4-0x000000018CADAAEC 
		private System.Type eventType { get; } // 0x000000018CADAA8C-0x000000018CADAAB4 
		private System.Reflection.FieldInfo field { get; } // 0x000000018CADAAB4-0x000000018CADAAC4 
		private PropertyInfo prop { get; } // 0x000000018CADAC30-0x000000018CADAC40 
		public override string name { get; } // 0x000000018CADAB08-0x000000018CADAC30 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 76237
		{
			// Fields
			public int i; // 0x10
			public UnityEventAutoCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAD8248-0x000000018CAD8280
		}
	
		// Constructors
		public UnityEventAutoCallbackEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F90-0x0000000187232FA0
		public void SetEvent(MemberInfo newMember, object instance = null); // 0x000000018CADAA04-0x000000018CADAA8C
		protected override void RegisterPorts(); // 0x000000018CADA6C0-0x000000018CADAA04
		public override void OnGraphStarted(); // 0x000000018CADA3FC-0x000000018CADA60C
		public override void OnGraphStoped(); // 0x000000018CADA60C-0x000000018CADA6C0
		private void OnEventRaised(params object[] args); // 0x000000018CADA398-0x000000018CADA3FC
	}

	[Category("Events/Custom")]
	[Description("Register a callback on a UnityEvent.\nWhen that event is raised, this node will get called.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(UnityEventBase) })]
	[Name("Unity Event Callback", 3)]
	public class UnityEventCallbackEvent : EventNode, IReflectedWrapper // TypeDefIndex: 76240
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
		private System.Type eventType { get; set; } // 0x000000018CAC6CD0-0x000000018CAC6CE4 0x000000018CADB4D8-0x000000018CADB584
		public bool autoHandleRegistration { get; } // 0x000000018225E0F0-0x000000018225E100 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 76239
		{
			// Fields
			public int i; // 0x10
			public UnityEventCallbackEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAD8280-0x000000018CAD82B8
		}
	
		// Constructors
		public UnityEventCallbackEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232C80-0x0000000187232C90
		public override void OnGraphStarted(); // 0x000000018CADAC90-0x000000018CADACD8
		public override void OnGraphStoped(); // 0x000000018CADACD8-0x000000018CADAD20
		protected override void RegisterPorts(); // 0x000000018CADAE10-0x000000018CADB2D8
		private void Register(Flow f = default); // 0x000000018CADB2D8-0x000000018CADB400
		private void Unregister(Flow f = default); // 0x000000018CADB400-0x000000018CADB4D8
		private void OnEventRaised(params object[] args); // 0x000000018CAC6458-0x000000018CAC64BC
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018CADAC40-0x000000018CADAC90
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018CADAD20-0x000000018CADAE10
	}

	[Category("Events")]
	[Color("ff5c5c")]
	[ExecutionPriority(1)]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	public abstract class EventNode : FlowNode // TypeDefIndex: 76241
	{
		// Properties
		public override string name { get; } // 0x000000018CACA900-0x000000018CACA95C 
	
		// Constructors
		protected EventNode(); // 0x0000000186B55770-0x0000000186B55780
	}

	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public abstract class EventNode<T> : EventNode // TypeDefIndex: 76242
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
	public abstract class RouterEventNode<T> : EventNode // TypeDefIndex: 76244
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
		public enum TargetMode // TypeDefIndex: 76243
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
	public class ConstructionEvent : EventNode // TypeDefIndex: 76245
	{
		// Fields
		private FlowOutput awake; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public ConstructionEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAC9834-0x000000018CAC9894
		protected override void RegisterPorts(); // 0x000000018CAC9894-0x000000018CAC98F8
	}

	[Category("Events/Graph")]
	[Description("Called whenever the Graph is Disabled")]
	[ExecutionPriority(4)]
	[Name("On Disable", 4)]
	public class DisableEvent : EventNode // TypeDefIndex: 76246
	{
		// Fields
		private FlowOutput disable; // 0xB0
	
		// Constructors
		public DisableEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStoped(); // 0x000000018CAC413C-0x000000018CAC418C
		protected override void RegisterPorts(); // 0x000000018CACA540-0x000000018CACA5A4
	}

	[Category("Events/Graph")]
	[Description("Called whenever the Graph is enabled.")]
	[ExecutionPriority(9)]
	[Name("On Enable", 9)]
	public class EnableEvent : EventNode // TypeDefIndex: 76247
	{
		// Fields
		private FlowOutput enable; // 0xB0
	
		// Constructors
		public EnableEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAC413C-0x000000018CAC418C
		protected override void RegisterPorts(); // 0x000000018CACA89C-0x000000018CACA900
	}

	[Category("Events/Graph")]
	[Description("Called every fixed framerate frame, which should be used when dealing with Physics")]
	[ExecutionPriority(5)]
	[Name("On Fixed Update", 5)]
	public class FixedUpdateEvent : EventNode // TypeDefIndex: 76248
	{
		// Fields
		private FlowOutput fixedUpdate; // 0xB0
	
		// Constructors
		public FixedUpdateEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CACAC7C-0x000000018CACACE0
		public override void OnGraphStarted(); // 0x000000018CACAB4C-0x000000018CACABE4
		public override void OnGraphStoped(); // 0x000000018CACABE4-0x000000018CACAC7C
		private void FixedUpdate(); // 0x000000018CAC413C-0x000000018CAC418C
	}

	[Category("Events/Graph")]
	[Description("Called per-frame, but after normal Update")]
	[ExecutionPriority(6)]
	[Name("On Late Update", 6)]
	public class LateUpdateEvent : EventNode // TypeDefIndex: 76249
	{
		// Fields
		private FlowOutput lateUpdate; // 0xB0
	
		// Constructors
		public LateUpdateEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD0D38-0x000000018CAD0D9C
		public override void OnGraphStarted(); // 0x000000018CAD0C08-0x000000018CAD0CA0
		public override void OnGraphStoped(); // 0x000000018CAD0CA0-0x000000018CAD0D38
		private void LateUpdate(); // 0x000000018CAC413C-0x000000018CAC418C
	}

	[Category("Events/Graph")]
	[Description("Called only once and the first time the Graph is enabled.\nThis is called after all OnAwake events of all graphs and after OnEnable events of this graph.")]
	[ExecutionPriority(8)]
	[Name("On Start", 8)]
	public class StartEvent : EventNode // TypeDefIndex: 76250
	{
		// Fields
		private FlowOutput start; // 0xB0
		private bool called; // 0xB8
	
		// Constructors
		public StartEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAD569C-0x000000018CAD5780
		private void OnStartCallback(); // 0x000000018CAD5780-0x000000018CAD57F8
		protected override void RegisterPorts(); // 0x000000018CAD57F8-0x000000018CAD585C
	}

	[Category("Events/Graph")]
	[Description("Called per-frame.\nUpdate Interval optionally determines the period in seconds every which update is called. Leave at 0 to call update per-frame as normal.")]
	[ExecutionPriority(7)]
	[Name("On Update", 7)]
	public class UpdateEvent : EventNode, IUpdatable // TypeDefIndex: 76251
	{
		// Fields
		public BBParameter<float> updateInterval; // 0xB0
		private FlowOutput update; // 0xB8
		private float lastUpdatedTime; // 0xC0
	
		// Constructors
		public UpdateEvent(); // 0x000000018CADB710-0x000000018CADB768
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CADB584-0x000000018CADB5E8
		public override void OnGraphStarted(); // 0x0000000187254010-0x0000000187254020
		public void Update(); // 0x000000018CADB5E8-0x000000018CADB710
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls out when Horizontal or Vertical Input Axis is not zero")]
	[Name("Input Axis (Preset)", 0)]
	[Obsolete("Use Input Axis")]
	public class InputAxisEvent : EventNode, IUpdatable // TypeDefIndex: 76252
	{
		// Fields
		private FlowOutput o; // 0xB0
		private float horizontal; // 0xB8
		private float vertical; // 0xBC
		private bool calledLastFrame; // 0xC0
	
		// Constructors
		public InputAxisEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CACFA44-0x000000018CACFBA0
		public void Update(); // 0x000000018CACFBA0-0x000000018CACFCE4
		[CompilerGenerated]
		private float _RegisterPorts_b__4_0(); // 0x000000018723F570-0x000000018723F580
		[CompilerGenerated]
		private float _RegisterPorts_b__4_1(); // 0x000000018723F5B0-0x000000018723F5C0
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls respective outputs when the defined Button is pressed down, held down or released.\nButtons are configured in Unity Input Manager.")]
	[Name("Input Button", 0)]
	public class InputButtonEvents : EventNode, IUpdatable // TypeDefIndex: 76253
	{
		// Fields
		[RequiredField]
		public BBParameter<string> buttonName; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018CACFF58-0x000000018CACFFA8 
	
		// Constructors
		public InputButtonEvents(); // 0x000000018CACFEF0-0x000000018CACFF58
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CACFCE4-0x000000018CACFDB8
		public void Update(); // 0x000000018CACFDB8-0x000000018CACFEF0
	}

	[Category("Events/Input (Legacy System)")]
	[Description("You are free to define any Input Axis in this node.\nAxis can be set in \'Project Settings/Input\'.\nCalls Out when either of the Axis defined is not zero")]
	[HasRefreshButton]
	[Name("Input Axis", 0)]
	public class InputCustomAxisEvent : EventNode, IUpdatable // TypeDefIndex: 76255
	{
		// Fields
		public BBParameter<List<string>> axis; // 0xB0
		private float[] axisValues; // 0xB8
		private bool calledLastFrame; // 0xC0
		private FlowOutput o; // 0xC8
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76254
		{
			// Fields
			public int i; // 0x10
			public InputCustomAxisEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _RegisterPorts_b__0(); // 0x000000018CAD8318-0x000000018CAD8354
		}
	
		// Constructors
		public InputCustomAxisEvent(); // 0x000000018CAD03B8-0x000000018CAD04A8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CACFFA8-0x000000018CAD0210
		public void Update(); // 0x000000018CAD0210-0x000000018CAD03B8
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Calls respective outputs when the defined keyboard key is pressed down, held down or released")]
	[Name("Keyboard Key", 0)]
	public class KeyboardEvents : EventNode, IUpdatable // TypeDefIndex: 76256
	{
		// Fields
		public BBParameter<KeyCode> keyCode; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput up; // 0xC0
		private FlowOutput pressed; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018CAD0BB8-0x000000018CAD0C08 
	
		// Constructors
		public KeyboardEvents(); // 0x000000018CAD0B60-0x000000018CAD0BB8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD0958-0x000000018CAD0A2C
		public void Update(); // 0x000000018CAD0A2C-0x000000018CAD0B60
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Called when the specified mouse button is clicked down, held or released")]
	[Name("Mouse Button", 0)]
	public class MouseEvents : EventNode, IUpdatable // TypeDefIndex: 76258
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		private FlowOutput down; // 0xB8
		private FlowOutput pressed; // 0xC0
		private FlowOutput up; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018CAD2734-0x000000018CAD2784 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 76257
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MouseEvents(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD252C-0x000000018CAD2600
		public void Update(); // 0x000000018CAD2600-0x000000018CAD2734
	}

	[Category("Events/Input (Legacy System)")]
	[Description("Called when any collider is clicked with the specified mouse button. PickInfo contains the information of the raycast event")]
	[Name("Mouse Pick", 0)]
	public class MousePickEvent : EventNode, IUpdatable // TypeDefIndex: 76260
	{
		// Fields
		public BBParameter<ButtonKeys> buttonKey; // 0xB0
		public BBParameter<LayerMask> mask; // 0xB8
		private FlowOutput o; // 0xC0
		private RaycastHit hit; // 0xC8
	
		// Properties
		public override string name { get; } // 0x000000018CAD2A4C-0x000000018CAD2A9C 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 76259
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public MousePickEvent(); // 0x000000018CAD29D8-0x000000018CAD2A4C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD2784-0x000000018CAD2874
		public void Update(); // 0x000000018CAD2874-0x000000018CAD29D8
		[CompilerGenerated]
		private RaycastHit _RegisterPorts_b__7_0(); // 0x000000018724C4B0-0x000000018724C4E0
	}

	[Category("Events/Object")]
	[Description("Calls Animator based events. Note that using this node will override root motion as usual, but you can call \'Apply Builtin Root Motion\' to get it back.")]
	[Name("Animator", 0)]
	public class AnimatorEvents : RouterEventNode<Animator> // TypeDefIndex: 76261
	{
		// Fields
		private FlowOutput onAnimatorMove; // 0xC8
		private FlowOutput onAnimatorIK; // 0xD0
		private Animator receiver; // 0xD8
		private int layerIndex; // 0xE0
	
		// Constructors
		public AnimatorEvents(); // 0x000000018CAC3E94-0x000000018CAC3EC8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAC3B24-0x000000018CAC3CD4
		protected override void Subscribe(EventRouter router); // 0x000000018CAC3CD4-0x000000018CAC3DB4
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC3DB4-0x000000018CAC3E94
		private void OnAnimatorMove(ParadoxNotion.EventData msg); // 0x000000018CAC3A80-0x000000018CAC3B24
		private void OnAnimatorIK(EventData<int> msg); // 0x000000018CAC39B8-0x000000018CAC3A80
		[CompilerGenerated]
		private Animator _RegisterPorts_b__4_0(); // 0x0000000187235E40-0x0000000187235E50
		[CompilerGenerated]
		private int _RegisterPorts_b__4_1(); // 0x00000001872406F0-0x0000000187240700
	}

	[Category("Events/Object")]
	[Description("Called when the Character Controller hits a collider while performing a Move")]
	[Name("Character Controller", 0)]
	public class CharacterControllerEvents : RouterEventNode<CharacterController>, IUpdatable // TypeDefIndex: 76262
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
		public CharacterControllerEvents(); // 0x000000018CAC7630-0x000000018CAC7664
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAC70E0-0x000000018CAC71D0
		void IUpdatable.Update(); // 0x000000018CAC6D90-0x000000018CAC700C
		protected override void RegisterPorts(); // 0x000000018CAC71D0-0x000000018CAC74BC
		protected override void Subscribe(EventRouter router); // 0x000000018CAC74BC-0x000000018CAC754C
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC75A0-0x000000018CAC7630
		private void OnControllerColliderHit(EventData<ControllerColliderHit> msg); // 0x000000018CAC700C-0x000000018CAC70E0
		[CompilerGenerated]
		private CharacterController _RegisterPorts_b__9_0(); // 0x0000000187234580-0x0000000187234590
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__9_1(); // 0x000000018CAC754C-0x000000018CAC7570
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__9_2(); // 0x000000018CAC7570-0x000000018CAC75A0
		[CompilerGenerated]
		private ControllerColliderHit _RegisterPorts_b__9_3(); // 0x0000000187235E40-0x0000000187235E50
	}

	[Category("Events/Object")]
	[Description("Called when 2D Collision based events happen on target and expose collision information")]
	[Name("Collision2D", 0)]
	public class Collision2DEvents_Rigidbody : RouterEventNode<Rigidbody2D> // TypeDefIndex: 76263
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents_Rigidbody(); // 0x000000018CAC85A4-0x000000018CAC85D8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAC801C-0x000000018CAC8308
		protected override void Subscribe(EventRouter router); // 0x000000018CAC8308-0x000000018CAC8424
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC8488-0x000000018CAC85A4
		private void OnCollisionEnter2D(EventData<Collision2D> msg); // 0x000000018CAC7DA0-0x000000018CAC7E74
		private void OnCollisionStay2D(EventData<Collision2D> msg); // 0x000000018CAC7F48-0x000000018CAC801C
		private void OnCollisionExit2D(EventData<Collision2D> msg); // 0x000000018CAC7E74-0x000000018CAC7F48
		[CompilerGenerated]
		private Rigidbody2D _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018CAC8424-0x000000018CAC8448
		[CompilerGenerated]
		private ContactPoint2D _RegisterPorts_b__5_2(); // 0x000000018CAC8448-0x000000018CAC8488
		[CompilerGenerated]
		private Collision2D _RegisterPorts_b__5_3(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when 2D Collision based events happen on target and expose collision information")]
	[DoNotList]
	[Name("Collision2D", 0)]
	public class Collision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 76264
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private Collision2D collision; // 0xE8
	
		// Constructors
		public Collision2DEvents(); // 0x000000018CAC8810-0x000000018CAC8844
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAC7AD0-0x000000018CAC7DA0
		protected override void Subscribe(EventRouter router); // 0x000000018CAC85D8-0x000000018CAC86F4
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC86F4-0x000000018CAC8810
		private void OnCollisionEnter2D(EventData<Collision2D> msg); // 0x000000018CAC7854-0x000000018CAC7928
		private void OnCollisionStay2D(EventData<Collision2D> msg); // 0x000000018CAC79FC-0x000000018CAC7AD0
		private void OnCollisionExit2D(EventData<Collision2D> msg); // 0x000000018CAC7928-0x000000018CAC79FC
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018CAC8424-0x000000018CAC8448
		[CompilerGenerated]
		private ContactPoint2D _RegisterPorts_b__5_2(); // 0x000000018CAC8448-0x000000018CAC8488
		[CompilerGenerated]
		private Collision2D _RegisterPorts_b__5_3(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when Collision based events happen on target and expose collision information")]
	[Name("Collision", 0)]
	public class CollisionEvents_Rigidbody : RouterEventNode<Rigidbody> // TypeDefIndex: 76265
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Rigidbody receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents_Rigidbody(); // 0x000000018CAC9594-0x000000018CAC95C8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAC900C-0x000000018CAC92F8
		protected override void Subscribe(EventRouter router); // 0x000000018CAC92F8-0x000000018CAC9414
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC9478-0x000000018CAC9594
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg); // 0x000000018CAC8D90-0x000000018CAC8E64
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg); // 0x000000018CAC8F38-0x000000018CAC900C
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg); // 0x000000018CAC8E64-0x000000018CAC8F38
		[CompilerGenerated]
		private Rigidbody _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018CAC9414-0x000000018CAC9438
		[CompilerGenerated]
		private ContactPoint _RegisterPorts_b__5_2(); // 0x000000018CAC9438-0x000000018CAC9478
		[CompilerGenerated]
		private UnityEngine.Collision _RegisterPorts_b__5_3(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when Collision based events happen on target and expose collision information")]
	[DoNotList]
	[Name("Collision", 0)]
	public class CollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 76266
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private UnityEngine.Collision collision; // 0xE8
	
		// Constructors
		public CollisionEvents(); // 0x000000018CAC9800-0x000000018CAC9834
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAC8AC0-0x000000018CAC8D90
		protected override void Subscribe(EventRouter router); // 0x000000018CAC95C8-0x000000018CAC96E4
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAC96E4-0x000000018CAC9800
		private void OnCollisionEnter(EventData<UnityEngine.Collision> msg); // 0x000000018CAC8844-0x000000018CAC8918
		private void OnCollisionStay(EventData<UnityEngine.Collision> msg); // 0x000000018CAC89EC-0x000000018CAC8AC0
		private void OnCollisionExit(EventData<UnityEngine.Collision> msg); // 0x000000018CAC8918-0x000000018CAC89EC
		[CompilerGenerated]
		private Collider _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x000000018CAC9414-0x000000018CAC9438
		[CompilerGenerated]
		private ContactPoint _RegisterPorts_b__5_2(); // 0x000000018CAC9438-0x000000018CAC9478
		[CompilerGenerated]
		private UnityEngine.Collision _RegisterPorts_b__5_3(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when mouse based operations happen on target 2D collider")]
	[Name("Mouse2D", 0)]
	public class MouseAgent2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 76267
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
		public MouseAgent2DEvents(); // 0x000000018CAD1978-0x000000018CAD19AC
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD11BC-0x000000018CAD142C
		protected override void Subscribe(EventRouter router); // 0x000000018CAD1590-0x000000018CAD1784
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD1784-0x000000018CAD1978
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018CAD0EFC-0x000000018CAD0FAC
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018CAD105C-0x000000018CAD110C
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018CAD0FAC-0x000000018CAD105C
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018CAD0D9C-0x000000018CAD0E4C
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018CAD110C-0x000000018CAD11BC
		private void OnMouseDrag(ParadoxNotion.EventData msg); // 0x000000018CAD0E4C-0x000000018CAD0EFC
		private void StoreHit(); // 0x000000018CAD142C-0x000000018CAD1590
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__8_0(); // 0x00000001872346D0-0x00000001872346E0
		[CompilerGenerated]
		private RaycastHit2D _RegisterPorts_b__8_1(); // 0x0000000187253FB0-0x0000000187253FE0
	}

	[Category("Events/Object")]
	[Description("Called when mouse based operations happen on target collider")]
	[Name("Mouse", 0)]
	public class MouseAgentEvents : RouterEventNode<Collider> // TypeDefIndex: 76268
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
		public MouseAgentEvents(); // 0x000000018CAD24F8-0x000000018CAD252C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD1DCC-0x000000018CAD203C
		protected override void Subscribe(EventRouter router); // 0x000000018CAD2110-0x000000018CAD2304
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD2304-0x000000018CAD24F8
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018CAD1B0C-0x000000018CAD1BBC
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018CAD1C6C-0x000000018CAD1D1C
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018CAD1BBC-0x000000018CAD1C6C
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018CAD19AC-0x000000018CAD1A5C
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018CAD1D1C-0x000000018CAD1DCC
		private void OnMouseDrag(ParadoxNotion.EventData msg); // 0x000000018CAD1A5C-0x000000018CAD1B0C
		private void StoreHit(); // 0x000000018CAD203C-0x000000018CAD2110
		[CompilerGenerated]
		private Collider _RegisterPorts_b__8_0(); // 0x00000001872346D0-0x00000001872346E0
		[CompilerGenerated]
		private RaycastHit _RegisterPorts_b__8_1(); // 0x0000000187253FE0-0x0000000187254010
	}

	[Category("Events/Object")]
	[Description("OnEnable, OnDisable and OnDestroy callback events for target object")]
	[Name("Object State", 0)]
	public class ObjectStateEvents : RouterEventNode<Transform> // TypeDefIndex: 76269
	{
		// Fields
		private FlowOutput onEnable; // 0xC8
		private FlowOutput onDisable; // 0xD0
		private FlowOutput onDestroy; // 0xD8
		private GameObject receiver; // 0xE0
	
		// Constructors
		public ObjectStateEvents(); // 0x000000018CAD3050-0x000000018CAD3084
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD2CB8-0x000000018CAD2E18
		protected override void Subscribe(EventRouter router); // 0x000000018CAD2E18-0x000000018CAD2F34
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD2F34-0x000000018CAD3050
		private void OnEnable(ParadoxNotion.EventData msg); // 0x000000018CAD2C04-0x000000018CAD2CB8
		private void OnDisable(ParadoxNotion.EventData msg); // 0x000000018CAD2B50-0x000000018CAD2C04
		private void OnDestroy(ParadoxNotion.EventData msg); // 0x000000018CAD2A9C-0x000000018CAD2B50
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__4_0(); // 0x00000001872360B0-0x00000001872360C0
	}

	[Category("Events/Object")]
	[Description("Calls Gizmos")]
	[Name("Draw Gizmos", 0)]
	public class DrawGizmosEvents : RouterEventNode<Transform> // TypeDefIndex: 76270
	{
		// Fields
		private FlowOutput onDrawGizmos; // 0xC8
		private GameObject receiver; // 0xD0
	
		// Constructors
		public DrawGizmosEvents(); // 0x000000018CACA868-0x000000018CACA89C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CACA658-0x000000018CACA748
		protected override void Subscribe(EventRouter router); // 0x000000018CACA748-0x000000018CACA7D8
		protected override void UnSubscribe(EventRouter router); // 0x000000018CACA7D8-0x000000018CACA868
		private void OnDrawGizmos(ParadoxNotion.EventData msg); // 0x000000018CACA5A4-0x000000018CACA658
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__2_0(); // 0x0000000187234580-0x0000000187234590
	}

	[Category("Events/Object")]
	[Description("Called when any Particle System collided with the target collider 2D object")]
	[Name("Particle Collision 2D", 0)]
	public class ParticleCollision2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 76271
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider2D receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollision2DEvents(); // 0x000000018CAD375C-0x000000018CAD3790
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD322C-0x000000018CAD34E0
		protected override void Subscribe(EventRouter router); // 0x000000018CAD34E0-0x000000018CAD3570
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD36CC-0x000000018CAD375C
		private void OnParticleCollision(EventData<GameObject> msg); // 0x000000018CAD3084-0x000000018CAD322C
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__4_0(); // 0x0000000187234580-0x0000000187234590
		[CompilerGenerated]
		private ParticleSystem _RegisterPorts_b__4_1(); // 0x0000000187235E40-0x0000000187235E50
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_2(); // 0x000000018CAD3570-0x000000018CAD35E4
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_3(); // 0x000000018CAD35E4-0x000000018CAD3658
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_4(); // 0x000000018CAD3658-0x000000018CAD36CC
	}

	[Category("Events/Object")]
	[Description("Called when any Particle System collided with the target collider object")]
	[Name("Particle Collision", 0)]
	public class ParticleCollisionEvents : RouterEventNode<Collider> // TypeDefIndex: 76272
	{
		// Fields
		private FlowOutput onCollision; // 0xC8
		private Collider receiver; // 0xD0
		private ParticleSystem particle; // 0xD8
		private List<ParticleCollisionEvent> collisionEvents; // 0xE0
	
		// Constructors
		public ParticleCollisionEvents(); // 0x000000018CAD3E68-0x000000018CAD3E9C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD3938-0x000000018CAD3BEC
		protected override void Subscribe(EventRouter router); // 0x000000018CAD3BEC-0x000000018CAD3C7C
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD3DD8-0x000000018CAD3E68
		private void OnParticleCollision(EventData<GameObject> msg); // 0x000000018CAD3790-0x000000018CAD3938
		[CompilerGenerated]
		private Collider _RegisterPorts_b__4_0(); // 0x0000000187234580-0x0000000187234590
		[CompilerGenerated]
		private ParticleSystem _RegisterPorts_b__4_1(); // 0x0000000187235E40-0x0000000187235E50
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_2(); // 0x000000018CAD3C7C-0x000000018CAD3CF0
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_3(); // 0x000000018CAD3CF0-0x000000018CAD3D64
		[CompilerGenerated]
		private Vector3 _RegisterPorts_b__4_4(); // 0x000000018CAD3D64-0x000000018CAD3DD8
	}

	[Category("Events/Object")]
	[Description("Events relevant to transform changes")]
	public class TransformEvents : RouterEventNode<Transform> // TypeDefIndex: 76273
	{
		// Fields
		private FlowOutput onParentChanged; // 0xC8
		private FlowOutput onChildrenChanged; // 0xD0
		private Transform receiver; // 0xD8
		private Transform parent; // 0xE0
		private IEnumerable<Transform> children; // 0xE8
	
		// Constructors
		public TransformEvents(); // 0x000000018CAD5E1C-0x000000018CAD5E50
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD5A5C-0x000000018CAD5C74
		protected override void Subscribe(EventRouter router); // 0x000000018CAD5C74-0x000000018CAD5D48
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD5D48-0x000000018CAD5E1C
		private void OnTransformParentChanged(ParadoxNotion.EventData msg); // 0x000000018CAD595C-0x000000018CAD5A5C
		private void OnTransformChildrenChanged(ParadoxNotion.EventData msg); // 0x000000018CAD585C-0x000000018CAD595C
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_0(); // 0x0000000187235E40-0x0000000187235E50
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_1(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private IEnumerable<Transform> _RegisterPorts_b__5_2(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when 2D Trigger based event happen on target when it has either a Collider2D or a Rigidbody2D")]
	[Name("Trigger2D", 0)]
	public class Trigger2DEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 76274
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents_Transform(); // 0x000000018CAD6A94-0x000000018CAD6AC8
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD6674-0x000000018CAD685C
		protected override void Subscribe(EventRouter router); // 0x000000018CAD685C-0x000000018CAD6978
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD6978-0x000000018CAD6A94
		private void OnTriggerEnter2D(EventData<Collider2D> msg); // 0x000000018CAD63D4-0x000000018CAD64B4
		private void OnTriggerStay2D(EventData<Collider2D> msg); // 0x000000018CAD6594-0x000000018CAD6674
		private void OnTriggerExit2D(EventData<Collider2D> msg); // 0x000000018CAD64B4-0x000000018CAD6594
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when 2D Trigger based event happen on target")]
	[DoNotList]
	[Name("Trigger2D", 0)]
	public class Trigger2DEvents : RouterEventNode<Collider2D> // TypeDefIndex: 76275
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider2D receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public Trigger2DEvents(); // 0x000000018CAD6BE4-0x000000018CAD6C18
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD60F0-0x000000018CAD62B8
		protected override void Subscribe(EventRouter router); // 0x000000018CAD62B8-0x000000018CAD63D4
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD6AC8-0x000000018CAD6BE4
		private void OnTriggerEnter2D(EventData<Collider2D> msg); // 0x000000018CAD5E50-0x000000018CAD5F30
		private void OnTriggerStay2D(EventData<Collider2D> msg); // 0x000000018CAD6010-0x000000018CAD60F0
		private void OnTriggerExit2D(EventData<Collider2D> msg); // 0x000000018CAD5F30-0x000000018CAD6010
		[CompilerGenerated]
		private Collider2D _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when Trigger based event happen on target when it has either a Collider or a Rigidbody")]
	[Name("Trigger", 0)]
	public class TriggerEvents_Transform : RouterEventNode<Transform> // TypeDefIndex: 76276
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Transform receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents_Transform(); // 0x000000018CAD785C-0x000000018CAD7890
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD743C-0x000000018CAD7624
		protected override void Subscribe(EventRouter router); // 0x000000018CAD7624-0x000000018CAD7740
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD7740-0x000000018CAD785C
		private void OnTriggerEnter(EventData<Collider> msg); // 0x000000018CAD719C-0x000000018CAD727C
		private void OnTriggerStay(EventData<Collider> msg); // 0x000000018CAD735C-0x000000018CAD743C
		private void OnTriggerExit(EventData<Collider> msg); // 0x000000018CAD727C-0x000000018CAD735C
		[CompilerGenerated]
		private Transform _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object")]
	[Description("Called when Trigger based event happen on target")]
	[DoNotList]
	[Name("Trigger", 0)]
	public class TriggerEvents : RouterEventNode<Collider> // TypeDefIndex: 76277
	{
		// Fields
		private FlowOutput onEnter; // 0xC8
		private FlowOutput onStay; // 0xD0
		private FlowOutput onExit; // 0xD8
		private Collider receiver; // 0xE0
		private GameObject other; // 0xE8
	
		// Constructors
		public TriggerEvents(); // 0x000000018CAD79AC-0x000000018CAD79E0
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD6EB8-0x000000018CAD7080
		protected override void Subscribe(EventRouter router); // 0x000000018CAD7080-0x000000018CAD719C
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAD7890-0x000000018CAD79AC
		private void OnTriggerEnter(EventData<Collider> msg); // 0x000000018CAD6C18-0x000000018CAD6CF8
		private void OnTriggerStay(EventData<Collider> msg); // 0x000000018CAD6DD8-0x000000018CAD6EB8
		private void OnTriggerExit(EventData<Collider> msg); // 0x000000018CAD6CF8-0x000000018CAD6DD8
		[CompilerGenerated]
		private Collider _RegisterPorts_b__5_0(); // 0x00000001872360B0-0x00000001872360C0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__5_1(); // 0x00000001872354B0-0x00000001872354C0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Button is clicked")]
	[Name("UI Button", 0)]
	public class UIButtonEvent : EventNode<UnityEngine.UI.Button> // TypeDefIndex: 76278
	{
		// Fields
		private FlowOutput o; // 0xB8
	
		// Constructors
		public UIButtonEvent(); // 0x000000018CAD8940-0x000000018CAD8974
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAD8718-0x000000018CAD8808
		public override void OnGraphStoped(); // 0x000000018CAD8644-0x000000018CAD8718
		protected override void RegisterPorts(); // 0x000000018CAD8808-0x000000018CAD88F8
		private void OnClick(); // 0x000000018CAD85F4-0x000000018CAD8644
		[CompilerGenerated]
		private UnityEngine.UI.Button _RegisterPorts_b__3_0(); // 0x000000018CAD88F8-0x000000018CAD8940
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Dropdown value changed.")]
	[Name("UI Dropdown", 0)]
	public class UIDropdownEvent : EventNode<Dropdown> // TypeDefIndex: 76279
	{
		// Fields
		private FlowOutput o; // 0xB8
		private int value; // 0xC0
	
		// Constructors
		public UIDropdownEvent(); // 0x000000018CAD8D68-0x000000018CAD8D9C
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAD8A58-0x000000018CAD8B58
		public override void OnGraphStoped(); // 0x000000018CAD8974-0x000000018CAD8A58
		protected override void RegisterPorts(); // 0x000000018CAD8BAC-0x000000018CAD8D20
		private void OnValueChanged(int value); // 0x000000018CAD8B58-0x000000018CAD8BAC
		[CompilerGenerated]
		private Dropdown _RegisterPorts_b__4_0(); // 0x000000018CAD8D20-0x000000018CAD8D68
		[CompilerGenerated]
		private int _RegisterPorts_b__4_1(); // 0x000000018723BAC0-0x000000018723BAD0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Dropdown value changed.")]
	[Name("UI Field Input", 0)]
	public class UIInputFieldEvent : EventNode<InputField> // TypeDefIndex: 76280
	{
		// Fields
		private FlowOutput onValueChanged; // 0xB8
		private FlowOutput onEndEdit; // 0xC0
		private string value; // 0xC8
	
		// Constructors
		public UIInputFieldEvent(); // 0x000000018CAD9350-0x000000018CAD9384
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAD8F6C-0x000000018CAD90F4
		public override void OnGraphStoped(); // 0x000000018CAD8E00-0x000000018CAD8F6C
		protected override void RegisterPorts(); // 0x000000018CAD9158-0x000000018CAD9308
		private void OnValueChanged(string value); // 0x000000018CAD90F4-0x000000018CAD9158
		private void OnEndEdit(string value); // 0x000000018CAD8D9C-0x000000018CAD8E00
		[CompilerGenerated]
		private InputField _RegisterPorts_b__5_0(); // 0x000000018CAD9308-0x000000018CAD9350
		[CompilerGenerated]
		private string _RegisterPorts_b__5_1(); // 0x000000018723BB00-0x000000018723BB10
	}

	[Category("Events/Object/UI")]
	[Description("Calls UI Pointer based events on target. The Unity Event system has to be set through \'GameObject/UI/Event System\'")]
	[Name("UI Pointer", 0)]
	public class UIPointerEvents : RouterEventNode<Transform> // TypeDefIndex: 76282
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
		private sealed class _UpdatePressed_d__17 : IEnumerator<object> // TypeDefIndex: 76281
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIPointerEvents __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _UpdatePressed_d__17(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEDAC4-0x000000018CAEDB5C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEDB5C-0x000000018CAEDBA8
		}
	
		// Constructors
		public UIPointerEvents(); // 0x000000018CADA364-0x000000018CADA398
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAD9AD0-0x000000018CAD9E08
		protected override void Subscribe(EventRouter router); // 0x000000018CAD9E08-0x000000018CADA088
		protected override void UnSubscribe(EventRouter router); // 0x000000018CADA088-0x000000018CADA308
		private void OnPointerDown(EventData<PointerEventData> msg); // 0x000000018CAD9468-0x000000018CAD956C
		private void OnPointerUp(EventData<PointerEventData> msg); // 0x000000018CAD99E0-0x000000018CAD9AD0
		[IteratorStateMachine(typeof(_UpdatePressed_d__17))]
		private IEnumerator UpdatePressed(); // 0x000000018CADA308-0x000000018CADA364
		private void OnPointerEnter(EventData<PointerEventData> msg); // 0x000000018CAD9734-0x000000018CAD9818
		private void OnPointerExit(EventData<PointerEventData> msg); // 0x000000018CAD9818-0x000000018CAD98FC
		private void OnPointerClick(EventData<PointerEventData> msg); // 0x000000018CAD9384-0x000000018CAD9468
		private void OnPointerDrag(EventData<PointerEventData> msg); // 0x000000018CAD956C-0x000000018CAD9650
		private void OnPointerDrop(EventData<PointerEventData> msg); // 0x000000018CAD9650-0x000000018CAD9734
		private void OnPointerScroll(EventData<PointerEventData> msg); // 0x000000018CAD98FC-0x000000018CAD99E0
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__12_0(); // 0x000000018723B410-0x000000018723B420
		[CompilerGenerated]
		private PointerEventData _RegisterPorts_b__12_1(); // 0x0000000187232D10-0x0000000187232D20
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Scrollbar value changed.")]
	[Name("UI Scrollbar", 0)]
	public class UIScrollbarEvent : EventNode<Scrollbar> // TypeDefIndex: 76283
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UIScrollbarEvent(); // 0x000000018CAEDFA0-0x000000018CAEDFD4
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAEDC8C-0x000000018CAEDD8C
		public override void OnGraphStoped(); // 0x000000018CAEDBA8-0x000000018CAEDC8C
		protected override void RegisterPorts(); // 0x000000018CAEDDE4-0x000000018CAEDF58
		private void OnValueChanged(float value); // 0x000000018CAEDD8C-0x000000018CAEDDE4
		[CompilerGenerated]
		private Scrollbar _RegisterPorts_b__4_0(); // 0x000000018CAEDF58-0x000000018CAEDFA0
		[CompilerGenerated]
		private float _RegisterPorts_b__4_1(); // 0x000000018723F5C0-0x000000018723F5D0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Slider value changed.")]
	[Name("UI Slider", 0)]
	public class UISliderEvent : EventNode<Slider> // TypeDefIndex: 76284
	{
		// Fields
		private FlowOutput o; // 0xB8
		private float value; // 0xC0
	
		// Constructors
		public UISliderEvent(); // 0x000000018CAEE374-0x000000018CAEE3A8
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAEE0B8-0x000000018CAEE1B8
		public override void OnGraphStoped(); // 0x000000018CAEDFD4-0x000000018CAEE0B8
		protected override void RegisterPorts(); // 0x000000018CAEE1B8-0x000000018CAEE32C
		private void OnValueChanged(float value); // 0x000000018CAEDD8C-0x000000018CAEDDE4
		[CompilerGenerated]
		private Slider _RegisterPorts_b__4_0(); // 0x000000018CAEE32C-0x000000018CAEE374
		[CompilerGenerated]
		private float _RegisterPorts_b__4_1(); // 0x000000018723F5C0-0x000000018723F5D0
	}

	[Category("Events/Object/UI")]
	[Description("Called when the target UI Toggle value changed.")]
	[Name("UI Toggle", 0)]
	public class UIToggleEvent : EventNode<UnityEngine.UI.Toggle> // TypeDefIndex: 76285
	{
		// Fields
		private FlowOutput o; // 0xB8
		private bool state; // 0xC0
	
		// Constructors
		public UIToggleEvent(); // 0x000000018CAEE79C-0x000000018CAEE7D0
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAEE48C-0x000000018CAEE58C
		public override void OnGraphStoped(); // 0x000000018CAEE3A8-0x000000018CAEE48C
		protected override void RegisterPorts(); // 0x000000018CAEE5E0-0x000000018CAEE754
		private void OnValueChanged(bool state); // 0x000000018CAEE58C-0x000000018CAEE5E0
		[CompilerGenerated]
		private UnityEngine.UI.Toggle _RegisterPorts_b__4_0(); // 0x000000018CAEE754-0x000000018CAEE79C
		[CompilerGenerated]
		private bool _RegisterPorts_b__4_1(); // 0x0000000184F560B0-0x0000000184F560C0
	}

	[Category("Events/Object")]
	[Description("Calls events based on object\'s render visibility")]
	[Name("Visibility", 0)]
	public class VisibilityEvents : RouterEventNode<Transform> // TypeDefIndex: 76286
	{
		// Fields
		private FlowOutput onVisible; // 0xC8
		private FlowOutput onInvisible; // 0xD0
		private GameObject receiver; // 0xD8
	
		// Constructors
		public VisibilityEvents(); // 0x000000018CAEF304-0x000000018CAEF338
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAEF034-0x000000018CAEF15C
		protected override void Subscribe(EventRouter router); // 0x000000018CAEF15C-0x000000018CAEF230
		protected override void UnSubscribe(EventRouter router); // 0x000000018CAEF230-0x000000018CAEF304
		private void OnBecameVisible(ParadoxNotion.EventData msg); // 0x000000018CAEEF80-0x000000018CAEF034
		private void OnBecameInvisible(ParadoxNotion.EventData msg); // 0x000000018CAEEECC-0x000000018CAEEF80
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__3_0(); // 0x0000000187235E40-0x0000000187235E50
	}

	[Category("Events/Other")]
	[Description("Checks the condition boolean input per frame and calls outputs when the value has changed")]
	[Name("Conditional Event", 0)]
	public class ConditionalUpdateEvent : EventNode, IUpdatable // TypeDefIndex: 76287
	{
		// Fields
		private FlowOutput becameTrue; // 0xB0
		private FlowOutput becameFalse; // 0xB8
		private ValueInput<bool> condition; // 0xC0
		private bool lastState; // 0xC8
	
		// Constructors
		public ConditionalUpdateEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CADD950-0x000000018CADDA34
		public void Update(); // 0x000000018CADDA34-0x000000018CADDB20
	}

	[Category("Events/Other")]
	[Description("Use to debug send a Flow Signal in PlayMode Only")]
	public class DebugEvent : EventNode // TypeDefIndex: 76288
	{
		// Constructors
		public DebugEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("Events/Other")]
	[Description("Calls Hi when curve value is greater than 0, else calls Low.\nThe curve is evaluated over time and it\'s evaluated value is exposed")]
	[Name("OSC Pulse", 0)]
	public class OscillatorEvent : EventNode, IUpdatable // TypeDefIndex: 76289
	{
		// Fields
		public BBParameter<AnimationCurve> curve; // 0xB0
		private float time; // 0xB8
		private float value; // 0xBC
		private FlowOutput hi; // 0xC0
		private FlowOutput low; // 0xC8
	
		// Constructors
		public OscillatorEvent(); // 0x000000018CAE2C9C-0x000000018CAE2E4C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE2A80-0x000000018CAE2BA8
		public override void OnGraphStarted(); // 0x00000001872540F0-0x0000000187254100
		public void Update(); // 0x000000018CAE2BA8-0x000000018CAE2C9C
		[CompilerGenerated]
		private float _RegisterPorts_b__6_0(); // 0x000000018723F5B0-0x000000018723F5C0
	}

	[Category("Events/Other")]
	[Description("Called when the target variable change. (Not whenever it is set).")]
	[Name("On Variable Change", 0)]
	public class VariableChangedEvent : EventNode // TypeDefIndex: 76290
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter targetVariable; // 0xB0
		private FlowOutput fOut; // 0xB8
		private object newValue; // 0xC0
	
		// Properties
		public override string name { get; } // 0x000000018CAEEB3C-0x000000018CAEEB8C 
	
		// Constructors
		public VariableChangedEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CAEE7D0-0x000000018CAEE8C4
		public override void OnGraphStoped(); // 0x000000018CAEE8C4-0x000000018CAEE978
		protected override void RegisterPorts(); // 0x000000018CAEEA30-0x000000018CAEEB3C
		private void OnValueChanged(object value); // 0x000000018CAEE978-0x000000018CAEE9DC
		private void OnVariableRefChange(Variable newVarRef); // 0x000000018CAEE9DC-0x000000018CAEEA30
		[CompilerGenerated]
		private object _RegisterPorts_b__7_0(); // 0x0000000187236200-0x0000000187236210
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filter the Flow based on a percentage between min and max.\nFor example: With Min = 0, Max = 1 and Percentage = 0.5, the chance is 50%.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(float) })]
	public class Chance : FlowControlNode // TypeDefIndex: 76292
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76291
		{
			// Fields
			public ValueInput<float> min; // 0x10
			public ValueInput<float> max; // 0x18
			public ValueInput<float> chance; // 0x20
			public FlowOutput success; // 0x28
			public FlowOutput failure; // 0x30
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEBCB4-0x000000018CAEBD6C
		}
	
		// Constructors
		public Chance(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CADD698-0x000000018CADD8B0
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filters the flow execution so that it can\'t be called very frequently")]
	[ContextDefinedInputs(new System.Type[1] {typeof(float) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(float) })]
	public class Cooldown : FlowControlNode // TypeDefIndex: 76294
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
		public override string name { get; } // 0x000000018CADDFE8-0x000000018CADE06C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountDown_d__14 : IEnumerator<object> // TypeDefIndex: 76293
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Cooldown __4__this; // 0x20
			public Flow f; // 0x28
			private float _total_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CountDown_d__14(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAE9F1C-0x000000018CAEA140
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEA140-0x000000018CAEA18C
		}
	
		// Constructors
		public Cooldown(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CADDC68-0x000000018CADDC84
		public override void OnGraphStoped(); // 0x000000018CADDB90-0x000000018CADDBD8
		protected override void RegisterPorts(); // 0x000000018CADDC84-0x000000018CADDFC4
		private void Begin(Flow f); // 0x000000018CADDB20-0x000000018CADDB90
		private void Cancel(Flow f); // 0x000000018CADDB90-0x000000018CADDBD8
		[IteratorStateMachine(typeof(_CountDown_d__14))]
		private IEnumerator CountDown(Flow f); // 0x000000018CADDBD8-0x000000018CADDC68
		[CompilerGenerated]
		private float _RegisterPorts_b__11_0(); // 0x000000018CADDFC4-0x000000018CADDFD8
		[CompilerGenerated]
		private float _RegisterPorts_b__11_1(); // 0x000000018CADDFD8-0x000000018CADDFE8
	}

	[Category("Flow Controllers/Filters")]
	[Description("Filters Out to be called only once. After the first call, Out is no longer called until Reset is called")]
	public class DoOnce : FlowControlNode // TypeDefIndex: 76296
	{
		// Fields
		private bool called; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76295
		{
			// Fields
			public DoOnce __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC920-0x000000018CAEC980
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAECA80-0x000000018CAECAA0
		}
	
		// Constructors
		public DoOnce(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000187254030-0x0000000187254040
		protected override void RegisterPorts(); // 0x000000018CADF8B4-0x000000018CADFA34
	}

	[Category("Variables/Flow")]
	[Description("Reads a named parameter from the incomming Flow and returns it\'s value.\nFlow parameters can be set with a WriteFlowParameter node.\nFlow parameters are temporary variables that exist only in the context of the same Flow.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	[Name("Read Flow Param", 0)]
	public class ReadFlowParameter<T> : FlowControlNode // TypeDefIndex: 76298
	{
		// Fields
		private T flowValue;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76297
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
	public class WriteFlowParameter<T> : FlowControlNode // TypeDefIndex: 76300
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76299
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
	public class LatchBool : FlowControlNode // TypeDefIndex: 76302
	{
		// Fields
		private bool latched; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76301
		{
			// Fields
			public LatchBool __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC430-0x000000018CAEC484
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAEC834-0x000000018CAEC888
			internal bool _RegisterPorts_b__2(); // 0x000000018A0927A0-0x000000018A0927C0
		}
	
		// Constructors
		public LatchBool(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE1578-0x000000018CAE177C
	}

	[Category("Flow Controllers/Flow Convert")]
	[Description("Convert a Flow signal to an integer value")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Latch Integer", 0)]
	public class LatchInt : FlowControlNode // TypeDefIndex: 76305
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
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76303
		{
			// Fields
			public LatchInt __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _RegisterPorts_b__0(); // 0x000000018AAC0BB0-0x000000018AAC0BD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 76304
		{
			// Fields
			public int i; // 0x10
			public __c__DisplayClass2_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass2_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAECAA0-0x000000018CAECB08
		}
	
		// Constructors
		public LatchInt(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE177C-0x000000018CAE1974
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Await all flow inputs to be called within the max allowed await time before Out is called.\n- If MaxAwaitTime is 0, then all inputs must be called at the same time.\n- If MaxAwaitTime is -1, then the await time is infinity.")]
	[Name("AND", 0)]
	public class ANDMerge : FlowControlNode // TypeDefIndex: 76307
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
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76306
		{
			// Fields
			public int i; // 0x10
			public ANDMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAED2A4-0x000000018CAED2F0
		}
	
		// Constructors
		public ANDMerge(); // 0x000000018CADBDE0-0x000000018CADBDF4
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CADBC14-0x000000018CADBC1C
		protected override void RegisterPorts(); // 0x000000018CADBC1C-0x000000018CADBD9C
		private void Reset(); // 0x000000018CADBD9C-0x000000018CADBDE0
		private void Check(int index, Flow f); // 0x000000018CADBB00-0x000000018CADBC14
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Await all flow inputs to be called within the max allowed await time.\n- If MaxAwaitTime is 0, then all inputs must be called at the same time.\n- If MaxAwaitTime is -1, then the await time is infinity.")]
	[Obsolete("Use AND")]
	public class AwaitAll : FlowControlNode // TypeDefIndex: 76309
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
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76308
		{
			// Fields
			public int i; // 0x10
			public AwaitAll __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAED2A4-0x000000018CAED2F0
		}
	
		// Constructors
		public AwaitAll(); // 0x000000018CADC2D4-0x000000018CADC2F0
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CADBC14-0x000000018CADBC1C
		protected override void RegisterPorts(); // 0x000000018CADC154-0x000000018CADC2D4
		private void Reset(); // 0x000000018CADBD9C-0x000000018CADBDE0
		private void Check(int index, Flow f); // 0x000000018CADBB00-0x000000018CADBC14
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Calls Out when either input is called, but only once per frame regardless of how many inputs are called.")]
	[Name("OR", 0)]
	public class ORMerge : FlowControlNode // TypeDefIndex: 76311
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
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76310
		{
			// Fields
			public int i; // 0x10
			public ORMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAECBF0-0x000000018CAECC3C
		}
	
		// Constructors
		public ORMerge(); // 0x000000018CADBDE0-0x000000018CADBDF4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE27E4-0x000000018CAE2934
		private void Check(int index, Flow f); // 0x000000018CAE2770-0x000000018CAE27E4
	}

	[Category("Flow Controllers/Flow Merge")]
	[Description("Calls Out when either single Input is called, but no other is in the same frame.")]
	[Name("XOR", 0)]
	[Obsolete]
	public class XORMerge : FlowControlNode // TypeDefIndex: 76313
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
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76312
		{
			// Fields
			public int i; // 0x10
			public XORMerge __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAECE34-0x000000018CAECE80
		}
	
		// Constructors
		public XORMerge(); // 0x000000018CADBDE0-0x000000018CADBDF4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAEFA00-0x000000018CAEFB80
		private void Check(int index, Flow f); // 0x000000018CAEF918-0x000000018CAEFA00
	}

	[Category("Flow Controllers")]
	[Color("bf7fff")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Flow) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	public abstract class FlowControlNode : FlowNode // TypeDefIndex: 76314
	{
		// Constructors
		protected FlowControlNode(); // 0x0000000186B55770-0x0000000186B55780
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Can be used within a For Loop or For Each node, to Break the iteration.")]
	public class Break : FlowControlNode // TypeDefIndex: 76315
	{
		// Constructors
		public Break(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CADD4B8-0x000000018CADD564
		[CompilerGenerated]
		private void _RegisterPorts_b__0_0(Flow f); // 0x000000018CADD564-0x000000018CADD580
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Enumerate a value (usualy a list or array) for each of it\'s elements. Remember that you can also enumerate a Transform for it\'s children.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IEnumerable) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(object) })]
	public class ForEach : FlowControlNode // TypeDefIndex: 76317
	{
		// Fields
		private object currentObject; // 0xB0
		private int currentIndex; // 0xB8
		private bool broken; // 0xBC
		private ValueInput<IEnumerable> enumerableInput; // 0xC0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76316
		{
			// Fields
			public ForEach __4__this; // 0x10
			public FlowOutput fFinish; // 0x18
			public FlowOutput fCurrent; // 0x20
			public FlowBreak __9__4; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018A091F2C-0x000000018A091F4C
			internal int _RegisterPorts_b__1(); // 0x000000018AAC0C30-0x000000018AAC0C50
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018CAECE80-0x000000018CAED248
			internal void _RegisterPorts_b__4(); // 0x000000018AAC5994-0x000000018AAC59B4
			internal void _RegisterPorts_b__3(Flow f); // 0x000000018AAC5994-0x000000018AAC59B4
		}
	
		// Constructors
		public ForEach(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE07A0-0x000000018CAE0AA0
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018CAE060C-0x000000018CAE065C
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018CAE065C-0x000000018CAE07A0
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Enumerate a value (usualy a list or array) for each of it\'s elements")]
	[ExposeAsDefinition]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Wild) })]
	public class ForEach<T> : FlowControlNode // TypeDefIndex: 76319
	{
		// Fields
		private T currentObject;
		private int currentIndex;
		private bool broken;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76318
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
	public class ForLoop : FlowControlNode // TypeDefIndex: 76321
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
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76320
		{
			// Fields
			public ForLoop __4__this; // 0x10
			public FlowOutput fCurrent; // 0x18
			public FlowOutput fFinish; // 0x20
			public FlowBreak __9__3; // 0x28
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _RegisterPorts_b__0(); // 0x000000018AAC0BB0-0x000000018AAC0BD0
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAED350-0x000000018CAED628
			internal void _RegisterPorts_b__3(); // 0x000000018AAC5A54-0x000000018AAC5A74
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018AAC5A54-0x000000018AAC5A74
		}
	
		// Constructors
		public ForLoop(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE0AA0-0x000000018CAE0DC4
	}

	[Description("Use for organization.")]
	[Name("Identity", 100)]
	public class Dummy : FlowControlNode // TypeDefIndex: 76323
	{
		// Properties
		public override string name { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76322
		{
			// Fields
			public FlowOutput fOut; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC980-0x000000018CAEC9C4
		}
	
		// Constructors
		public Dummy(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CADFA34-0x000000018CADFB40
	}

	[Description("Stops and cease execution of the FlowSript")]
	public class Finish : FlowControlNode // TypeDefIndex: 76325
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76324
		{
			// Fields
			public Finish __4__this; // 0x10
			public ValueInput<bool> c; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEBC44-0x000000018CAEBCB4
		}
	
		// Constructors
		public Finish(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CADFFC0-0x000000018CAE00E8
	}

	[Category("Flow Controllers/GOTO")]
	[Color("ff5c5c")]
	[Description("A Flow Control Label definition. Can be called with the GOTO node.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(Flow) })]
	[Name("GOTO Label Definition", 1)]
	public class GoToLabel : FlowControlNode, IEditorMenuCallbackReceiver // TypeDefIndex: 76326
	{
		// Fields
		[DelayedField]
		[Tooltip("The identifier name of the label")]
		public string identifier; // 0xB0
		[CompilerGenerated]
		private FlowOutput _port_k__BackingField; // 0xB8
	
		// Properties
		[HideInInspector]
		public FlowOutput port { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
		public override string name { get; } // 0x000000018CAE0F2C-0x000000018CAE0F84 
	
		// Constructors
		public GoToLabel(); // 0x000000018CAE0EDC-0x000000018CAE0F2C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE0E78-0x000000018CAE0EDC
	}

	[Description("Routes the Flow to the target GOTO label.")]
	[DoNotList]
	[ContextDefinedInputs(new System.Type[1] {typeof(Flow) })]
	public class GoToStatement : FlowControlNode, IHaveNodeReference // TypeDefIndex: 76327
	{
		// Fields
		[fsSerializeAs("_targetLabelUID")]
		public NodeReference<GoToLabel> _targetLabel; // 0xB0
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get; } // 0x0000000187232F90-0x0000000187232FA0 
		private GoToLabel target { get; } // 0x000000018CAE11C0-0x000000018CAE1210 
		public override string name { get; } // 0x000000018CAE1130-0x000000018CAE11C0 
	
		// Constructors
		public GoToStatement(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public void SetTarget(GoToLabel newTarget); // 0x000000018CAE1030-0x000000018CAE10BC
		protected override void RegisterPorts(); // 0x000000018CAE0F84-0x000000018CAE1030
		[CompilerGenerated]
		private void _RegisterPorts_b__8_0(Flow f); // 0x000000018CAE10BC-0x000000018CAE1130
	}

	[Description("Utility node to merge the flow. It\'s exactly the same as connecting multiple Flow outputs to the same Flow input.")]
	[Name("Merge", 89)]
	public class Merge : FlowControlNode // TypeDefIndex: 76328
	{
		// Fields
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[MinValue(2)]
		[SerializeField]
		private int _portCount; // 0xB0
	
		// Constructors
		public Merge(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE228C-0x000000018CAE2388
	}

	[Description("Split the Flow in multiple directions. Calls all outputs in the same frame but in order")]
	[Name("Split", 90)]
	public class Split : FlowControlNode // TypeDefIndex: 76330
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
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76329
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public Split __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC5A0-0x000000018CAEC648
		}
	
		// Constructors
		public Split(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE7BE4-0x000000018CAE7D88
	}

	[Description("Similar to Try/Catch/Finally in code")]
	public class TryCatch : FlowControlNode // TypeDefIndex: 76332
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76331
		{
			// Fields
			public FlowOutput fTry; // 0x10
			public FlowOutput fCatch; // 0x18
			public FlowOutput fFinally; // 0x20
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEBECC-0x000000018CAEC04C
		}
	
		// Constructors
		public TryCatch(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE97CC-0x000000018CAE993C
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Start a Coroutine that will repeat until Break is signaled")]
	[Name("Coroutine", 0)]
	public class CoroutineState : FlowControlNode // TypeDefIndex: 76335
	{
		// Fields
		private bool active; // 0xB0
		private Coroutine coroutine; // 0xB8
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76333
		{
			// Fields
			public CoroutineState __4__this; // 0x10
			public FlowOutput fStart; // 0x18
			public FlowOutput fUpdate; // 0x20
			public FlowOutput fFinish; // 0x28
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAECC3C-0x000000018CAECCE4
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAECA80-0x000000018CAECAA0
		}
	
		[CompilerGenerated]
		private sealed class _DoRepeat_d__4 : IEnumerator<object> // TypeDefIndex: 76334
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoRepeat_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEA18C-0x000000018CAEA36C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEA36C-0x000000018CAEA3B8
		}
	
		// Constructors
		public CoroutineState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStoped(); // 0x000000018CADE140-0x000000018CADE170
		protected override void RegisterPorts(); // 0x000000018CADE170-0x000000018CADE348
		[IteratorStateMachine(typeof(_DoRepeat_d__4))]
		private IEnumerator DoRepeat(FlowOutput fStart, FlowOutput fUpdate, FlowOutput fFinish, Flow f); // 0x000000018CADE06C-0x000000018CADE140
		[CompilerGenerated]
		private void _DoRepeat_b__4_0(); // 0x0000000187254030-0x0000000187254040
	}

	[Category("Flow Controllers/Iterators")]
	[Description("Once called, will continuously call \'Do\' while the input boolean condition is true. Once condition becomes or is false, \'Done\' is called")]
	[ContextDefinedInputs(new System.Type[1] {typeof(bool) })]
	[Name("While True", 0)]
	public class While : FlowControlNode // TypeDefIndex: 76339
	{
		// Fields
		private Coroutine coroutine; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76336
		{
			// Fields
			public While __4__this; // 0x10
			public FlowOutput fUpdate; // 0x18
			public FlowOutput fFinish; // 0x20
			public ValueInput<bool> c; // 0x28
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAECB58-0x000000018CAECBF0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76337
		{
			// Fields
			public bool active; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _DoWhile_b__0(); // 0x000000018275FD80-0x000000018275FD90
		}
	
		[CompilerGenerated]
		private sealed class _DoWhile_d__4 : IEnumerator<object> // TypeDefIndex: 76338
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoWhile_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEA3B8-0x000000018CAEA5FC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEA5FC-0x000000018CAEA648
		}
	
		// Constructors
		public While(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CAEF730-0x000000018CAEF748
		public override void OnGraphStoped(); // 0x000000018CAEF748-0x000000018CAEF78C
		protected override void RegisterPorts(); // 0x000000018CAEF78C-0x000000018CAEF918
		[IteratorStateMachine(typeof(_DoWhile_d__4))]
		private IEnumerator DoWhile(FlowOutput fUpdate, FlowOutput fFinish, Flow f, ValueInput<bool> condition); // 0x000000018CAEF65C-0x000000018CAEF730
	}

	[Category("Flow Controllers/Selectors")]
	[Description("Select a Result value out of the two input cases provided, based on a boolean Condition")]
	[ExposeAsDefinition]
	public class SelectOnBool<T> : FlowControlNode // TypeDefIndex: 76340
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
	public class SelectOnEnum<T> : FlowControlNode // TypeDefIndex: 76342
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type;
	
		// Properties
		private System.Type type { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76341
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
	public class SelectOnInt<T> : FlowControlNode // TypeDefIndex: 76344
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
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76343
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
	public class SelectOnString<T> : FlowControlNode // TypeDefIndex: 76346
	{
		// Fields
		[Name("Cases", 0)]
		public List<string> stringCases;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76345
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
	public class SelectOnTag<T> : FlowControlNode // TypeDefIndex: 76348
	{
		// Fields
		[SerializeField]
		private string[] _tagNames;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76347
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
	public class Random : FlowControlNode // TypeDefIndex: 76350
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
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76349
		{
			// Fields
			public Random __4__this; // 0x10
			public List<FlowOutput> outs; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC9C4-0x000000018CAECA80
			internal int _RegisterPorts_b__1(); // 0x000000018AAC0BB0-0x000000018AAC0BD0
		}
	
		// Constructors
		public Random(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE4A5C-0x000000018CAE4C84
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a conditional boolean value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(bool) })]
	[Name("Switch Condition", 0)]
	public class SwitchBool : FlowControlNode // TypeDefIndex: 76352
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76351
		{
			// Fields
			public ValueInput<bool> selector; // 0x10
			public FlowOutput caseTrue; // 0x18
			public FlowOutput caseFalse; // 0x20
			public FlowOutput caseThen; // 0x28
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEBBCC-0x000000018CAEBC44
		}
	
		// Constructors
		public SwitchBool(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE7D88-0x000000018CAE7F38
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a comparison between two comparable objects")]
	[ContextDefinedInputs(new System.Type[1] {typeof(IComparable) })]
	public class SwitchComparison : FlowControlNode // TypeDefIndex: 76354
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76353
		{
			// Fields
			public ValueInput<IComparable> a; // 0x10
			public ValueInput<IComparable> b; // 0x18
			public FlowOutput equal; // 0x20
			public FlowOutput notEqual; // 0x28
			public FlowOutput greater; // 0x30
			public FlowOutput less; // 0x38
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEBD6C-0x000000018CAEBECC
		}
	
		// Constructors
		public SwitchComparison(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE7F38-0x000000018CAE8184
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an enum value.\nPlease connect an Enum first for the options to show, or directly select the enum type with the relevant button bellow.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Enum) })]
	public class SwitchEnum : FlowControlNode // TypeDefIndex: 76356
	{
		// Fields
		[SerializeField]
		private SerializedTypeInfo _type; // 0xB0
	
		// Properties
		private System.Type type { get; set; } // 0x000000018B71515C-0x000000018B715170 0x000000018CAE85C0-0x000000018CAE866C
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76355
		{
			// Fields
			public ValueInput selector; // 0x10
			public Dictionary<string, FlowOutput> cases; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAECD7C-0x000000018CAECE34
		}
	
		// Constructors
		public SwitchEnum(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE82E4-0x000000018CAE85C0
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018CAE8184-0x000000018CAE81D4
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018CAE81D4-0x000000018CAE82E4
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an integer value. The Default output is called when the Index value is out of range.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[Name("Switch Integer", 0)]
	public class SwitchInt : FlowControlNode // TypeDefIndex: 76358
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
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76357
		{
			// Fields
			public ValueInput<int> selector; // 0x10
			public FlowOutput[] cases; // 0x18
			public FlowOutput defaultCase; // 0x20
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC7B0-0x000000018CAEC834
		}
	
		// Constructors
		public SwitchInt(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE8940-0x000000018CAE8B28
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on an integer value. The Default output is called when the Index value is out of range.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(int) })]
	[HasRefreshButton]
	[Name("Switch Integer Custom", 0)]
	public class SwitchIntCustom : FlowControlNode // TypeDefIndex: 76360
	{
		// Fields
		public List<int> intCases; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76359
		{
			// Fields
			public ValueInput<int> selector; // 0x10
			public SwitchIntCustom __4__this; // 0x18
			public FlowOutput[] cases; // 0x20
			public FlowOutput defaultCase; // 0x28
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC648-0x000000018CAEC7B0
		}
	
		// Constructors
		public SwitchIntCustom(); // 0x000000018CAE88B8-0x000000018CAE8940
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE866C-0x000000018CAE88B8
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Calls one output based on it\'s probability to be selected, in comparison to all other outputs. The probability of each output is respectively set by the same name float input.\nFor example, if all input values are the same (eg \'1\'), then all outputs have the same chance to be called.")]
	[ContextDefinedInputs(new System.Type[2] {typeof(Flow), typeof(float) })]
	public class SwitchProbability : FlowControlNode // TypeDefIndex: 76361
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
		public SwitchProbability(); // 0x000000018CADBDE0-0x000000018CADBDF4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE8CE4-0x000000018CAE901C
		private void Enter(Flow f); // 0x000000018CAE8B28-0x000000018CAE8CE4
		[CompilerGenerated]
		private int _RegisterPorts_b__5_0(); // 0x000000018724C8E0-0x000000018724C8F0
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on a string value. The Default output is called if there is no other matching output same as the input value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(string) })]
	[HasRefreshButton]
	public class SwitchString : FlowControlNode // TypeDefIndex: 76363
	{
		// Fields
		[Name("Cases", 0)]
		public List<string> comparisonOutputs; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76362
		{
			// Fields
			public ValueInput<string> selector; // 0x10
			public SwitchString __4__this; // 0x18
			public FlowOutput[] cases; // 0x20
			public FlowOutput defaultCase; // 0x28
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC2B0-0x000000018CAEC430
		}
	
		// Constructors
		public SwitchString(); // 0x000000018CAE926C-0x000000018CAE92F4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE901C-0x000000018CAE926C
	}

	[Category("Flow Controllers/Switchers")]
	[Description("Branch the Flow based on the tag of a GameObject value")]
	[ContextDefinedInputs(new System.Type[1] {typeof(GameObject) })]
	[HasRefreshButton]
	public class SwitchTag : FlowControlNode // TypeDefIndex: 76365
	{
		// Fields
		[SerializeField]
		private string[] _tagNames; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76364
		{
			// Fields
			public SwitchTag __4__this; // 0x10
			public ValueInput<GameObject> selector; // 0x18
			public FlowOutput[] cases; // 0x20
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAEC484-0x000000018CAEC5A0
		}
	
		// Constructors
		public SwitchTag(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE92F4-0x000000018CAE94D0
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Flip Flops between the 2 outputs each time In is called")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(bool) })]
	public class FlipFlop : FlowControlNode // TypeDefIndex: 76367
	{
		// Fields
		public bool isFlip; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get; } // 0x000000018CAE0330-0x000000018CAE03A8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76366
		{
			// Fields
			public FlipFlop __4__this; // 0x10
			public FlowOutput fFlip; // 0x18
			public FlowOutput fFlop; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAED248-0x000000018CAED2A4
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAECA80-0x000000018CAECAA0
			internal bool _RegisterPorts_b__2(); // 0x000000018A0927A0-0x000000018A0927C0
		}
	
		// Constructors
		public FlipFlop(); // 0x000000018CAE0320-0x000000018CAE0330
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000187254040-0x0000000187254050
		public override void OnGraphStoped(); // 0x0000000187254050-0x0000000187254060
		protected override void RegisterPorts(); // 0x000000018CAE00E8-0x000000018CAE0320
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Whenever In is called the \'current\' output is called as well. Calling \'+\' or \'-\' changes the current output respectively up or down.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Toggle (Multi)", 0)]
	public class MultiToggle : FlowControlNode // TypeDefIndex: 76369
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
		public override string name { get; } // 0x000000018CAE26BC-0x000000018CAE2740 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 76368
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public MultiToggle __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAED650-0x000000018CAED6E4
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAED7D4-0x000000018CAED818
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018CAED818-0x000000018CAED85C
			internal int _RegisterPorts_b__3(); // 0x000000018CAED8C0-0x000000018CAED8E0
		}
	
		// Constructors
		public MultiToggle(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CAE2388-0x000000018CAE23C4
		public override void OnGraphStoped(); // 0x00000001872540E0-0x00000001872540F0
		protected override void RegisterPorts(); // 0x000000018CAE23C4-0x000000018CAE26BC
	}

	[Category("Flow Controllers/Togglers")]
	[Description("Each time input is signaled, the next output in order is called. After the last output, the order loops from the start.\nReset, resets the current index to zero.")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(int) })]
	[Name("Flip Flop (Multi)", 0)]
	public class Sequence : FlowControlNode // TypeDefIndex: 76371
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
		public override string name { get; } // 0x000000018CAE74FC-0x000000018CAE7580 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 76370
		{
			// Fields
			public List<FlowOutput> outs; // 0x10
			public Sequence __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAED6E4-0x000000018CAED7B0
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAED7B0-0x000000018CAED7D4
			internal int _RegisterPorts_b__2(); // 0x000000018CAED8C0-0x000000018CAED8E0
		}
	
		// Constructors
		public Sequence(); // 0x000000018B71BA00-0x000000018B71BA14
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CAE2388-0x000000018CAE23C4
		public override void OnGraphStoped(); // 0x00000001872540E0-0x00000001872540F0
		protected override void RegisterPorts(); // 0x000000018CAE726C-0x000000018CAE74FC
	}

	[Category("Flow Controllers/Togglers")]
	[Description("When In is called, calls On or Off depending on the current toggle state. Whenever Toggle input is called the state changes.")]
	public class Toggle : FlowControlNode // TypeDefIndex: 76373
	{
		// Fields
		[Name("Start Open", 0)]
		public bool open; // 0xB0
		private bool original; // 0xB1
	
		// Properties
		public override string name { get; } // 0x000000018CAE9754-0x000000018CAE97CC 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76372
		{
			// Fields
			public Toggle __4__this; // 0x10
			public FlowOutput fOn; // 0x18
			public FlowOutput fOff; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CAED2F0-0x000000018CAED330
			internal void _RegisterPorts_b__1(Flow f); // 0x000000018CAED330-0x000000018CAED350
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018CAECA80-0x000000018CAECAA0
			internal void _RegisterPorts_b__3(Flow f); // 0x000000018CAED628-0x000000018CAED650
		}
	
		// Constructors
		public Toggle(); // 0x000000018CAE0320-0x000000018CAE0330
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000187254040-0x0000000187254050
		public override void OnGraphStoped(); // 0x0000000187254050-0x0000000187254060
		protected override void RegisterPorts(); // 0x000000018CAE94D0-0x000000018CAE9754
	}

	[Category("Functions/Custom")]
	[Description("Calls an existing Custom Function")]
	[DeserializeFrom("FlowCanvas.Nodes.RelayFlowInput")]
	[DoNotList]
	[HasRefreshButton]
	[Name("Function Call", 0)]
	public class CustomFunctionCall : FlowControlNode // TypeDefIndex: 76374
	{
		// Fields
		[SerializeField]
		private string _sourceOutputUID; // 0xB0
		private ValueInput[] portArgs; // 0xB8
		private object[] objectArgs; // 0xC0
		private FlowOutput fOut; // 0xC8
		private WeakReference<CustomFunctionEvent> _sourceFunctionRef; // 0xD0
	
		// Properties
		private string sourceFunctionUID { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x0000000185017130-0x0000000185017150
		public CustomFunctionEvent sourceFunction { get; } // 0x000000018CADEA00-0x000000018CADEB60 
		public override string name { get; } // 0x000000018CADE978-0x000000018CADEA00 
		public override string description { get; } // 0x000000018CADE914-0x000000018CADE978 
	
		// Constructors
		public CustomFunctionCall(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public void SetFunction(CustomFunctionEvent func); // 0x000000018CADE81C-0x000000018CADE8DC
		protected override void RegisterPorts(); // 0x000000018CADE4F4-0x000000018CADE81C
		private void Invoke(Flow f); // 0x000000018CADE348-0x000000018CADE4F4
		[CompilerGenerated]
		private bool _get_sourceFunction_b__9_0(CustomFunctionEvent i); // 0x000000018CADE8DC-0x000000018CADE914
	}

	[Category("Functions/Custom")]
	[Description("A custom function, defined by any number of parameters and an optional return value. It can be called using the \'Call Custom Function\' node. To end the function and optionally return a value, the \'Return\' node should be used.")]
	[DeserializeFrom("FlowCanvas.Nodes.RelayFlowOutput")]
	[Name("New Custom Function", 10)]
	public class CustomFunctionEvent : EventNode, IInvokable, IEditorMenuCallbackReceiver // TypeDefIndex: 76379
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
		public List<DynamicParameterDefinition> parameters { get; private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
		public DynamicParameterDefinition returns { get; private set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		private System.Type returnType { get; } // 0x000000018CADF680-0x000000018CADF6A0 
		private System.Type[] parameterTypes { get; } // 0x000000018CADF558-0x000000018CADF680 
		public override string name { get; } // 0x000000018CADF518-0x000000018CADF558 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76375
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<DynamicParameterDefinition, System.Type> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CAED998-0x000000018CAED9FC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Type _get_parameterTypes_b__15_0(DynamicParameterDefinition p); // 0x000000018CAEBBB4-0x000000018CAEBBCC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 76376
		{
			// Fields
			public int i; // 0x10
			public CustomFunctionEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAEC210-0x000000018CAEC248
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 76377
		{
			// Fields
			public Action<object> callback; // 0x10
			public CustomFunctionEvent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _NodeCanvas.Framework.IInvokable.InvokeAsync_b__0(Flow f); // 0x000000018CAEC888-0x000000018CAEC8BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 76378
		{
			// Fields
			public CustomFunctionEvent __4__this; // 0x10
			public FlowHandler flowCallback; // 0x18
			public Flow f; // 0x20
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _InvokeAsync_b__0(object o); // 0x000000018CAEC8BC-0x000000018CAEC920
		}
	
		// Constructors
		public CustomFunctionEvent(); // 0x000000018CADF418-0x000000018CADF518
	
		// Methods
		public override void OnGraphStoped(); // 0x000000018CADF214-0x000000018CADF248
		protected override void RegisterPorts(); // 0x000000018CADF248-0x000000018CADF3E8
		string IInvokable.GetInvocationID(); // 0x0000000187232F90-0x0000000187232FA0
		object IInvokable.Invoke(params object[] args); // 0x000000018CADF1D4-0x000000018CADF214
		void IInvokable.InvokeAsync(Action<object> callback, params object[] args); // 0x000000018CADF0C4-0x000000018CADF1D4
		public object Invoke(Flow f, params object[] args); // 0x000000018CADEFAC-0x000000018CADF0C4
		public void InvokeAsync(Flow f, FlowHandler flowCallback, params object[] args); // 0x000000018CADEE24-0x000000018CADEFAC
		public object GetReturnValue(); // 0x0000000187234580-0x0000000187234590
		private void AddParameter(System.Type type); // 0x000000018CADEB60-0x000000018CADEC3C
		private void GatherPortsUpdateRefs(); // 0x000000018CADEC3C-0x000000018CADEE24
		[CompilerGenerated]
		private void _Invoke_b__23_0(object o); // 0x0000000188A79A0C-0x0000000188A79A20
		[CompilerGenerated]
		private bool _GatherPortsUpdateRefs_b__27_0(CustomFunctionCall n); // 0x000000018CADF3E8-0x000000018CADF418
	}

	[Category("Functions/Custom")]
	[Description("Should always be used to return out of a Custom Function. The return value is only required if the Custom Function returns a value as well.")]
	[ContextDefinedInputs(new System.Type[1] {typeof(object) })]
	public class Return : FlowControlNode // TypeDefIndex: 76380
	{
		// Fields
		[GatherPortsCallback]
		public bool useReturnValue; // 0xB0
		private ValueInput<object> returnPort; // 0xB8
	
		// Constructors
		public Return(); // 0x000000018CAE0320-0x000000018CAE0330
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAE7014-0x000000018CAE7110
		[CompilerGenerated]
		private void _RegisterPorts_b__2_0(Flow f); // 0x000000018CAE7110-0x000000018CAE718C
	}

	public abstract class CallableActionNodeBase : SimplexNode // TypeDefIndex: 76381
	{
		// Constructors
		protected CallableActionNodeBase(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class CallableActionNode : CallableActionNodeBase // TypeDefIndex: 76383
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76382
		{
			// Fields
			public CallableActionNode __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnRegisterPorts_b__0(Flow f); // 0x000000018CAEC248-0x000000018CAEC2B0
		}
	
		// Constructors
		protected CallableActionNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node); // 0x000000018CADD580-0x000000018CADD698
	}

	public abstract class CallableActionNode<T1> : CallableActionNodeBase // TypeDefIndex: 76385
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76384
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

	public abstract class CallableActionNode<T1, T2> : CallableActionNodeBase // TypeDefIndex: 76387
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76386
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

	public abstract class CallableActionNode<T1, T2, T3> : CallableActionNodeBase // TypeDefIndex: 76389
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76388
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

	public abstract class CallableActionNode<T1, T2, T3, T4> : CallableActionNodeBase // TypeDefIndex: 76391
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76390
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

	public abstract class CallableActionNode<T1, T2, T3, T4, T5> : CallableActionNodeBase // TypeDefIndex: 76393
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76392
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

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6> : CallableActionNodeBase // TypeDefIndex: 76395
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76394
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

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7> : CallableActionNodeBase // TypeDefIndex: 76397
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76396
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

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : CallableActionNodeBase // TypeDefIndex: 76399
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76398
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

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableActionNodeBase // TypeDefIndex: 76401
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76400
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

	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableActionNodeBase // TypeDefIndex: 76403
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76402
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

	public abstract class CallableFunctionNodeBase : SimplexNode // TypeDefIndex: 76404
	{
		// Constructors
		protected CallableFunctionNodeBase(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class CallableFunctionNode<TResult> : CallableFunctionNodeBase // TypeDefIndex: 76406
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76405
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

	public abstract class CallableFunctionNode<TResult, T1> : CallableFunctionNodeBase // TypeDefIndex: 76408
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76407
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

	public abstract class CallableFunctionNode<TResult, T1, T2> : CallableFunctionNodeBase // TypeDefIndex: 76410
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76409
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3> : CallableFunctionNodeBase // TypeDefIndex: 76412
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76411
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4> : CallableFunctionNodeBase // TypeDefIndex: 76414
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76413
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5> : CallableFunctionNodeBase // TypeDefIndex: 76416
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76415
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : CallableFunctionNodeBase // TypeDefIndex: 76418
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76417
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : CallableFunctionNodeBase // TypeDefIndex: 76420
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76419
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : CallableFunctionNodeBase // TypeDefIndex: 76422
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76421
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableFunctionNodeBase // TypeDefIndex: 76424
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76423
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

	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableFunctionNodeBase // TypeDefIndex: 76426
	{
		// Fields
		private TResult result;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76425
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

	public abstract class ExtractorNode : SimplexNode // TypeDefIndex: 76428
	{
		// Fields
		private static Dictionary<System.Type, System.Type> _extractors; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76427
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CAED934-0x000000018CAED998
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetExtractorType_b__1_0(System.Type t); // 0x000000018CAEBB94-0x000000018CAEBBB4
		}
	
		// Constructors
		protected ExtractorNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static System.Type GetExtractorType(System.Type type); // 0x000000018CADFB40-0x000000018CADFFC0
	}

	public abstract class ExtractorNode<TInstance, T1, T2> : ExtractorNode // TypeDefIndex: 76430
	{
		// Fields
		private T1 a;
		private T2 b;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76429
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

	public abstract class ExtractorNode<TInstance, T1, T2, T3> : ExtractorNode // TypeDefIndex: 76432
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76431
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

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4> : ExtractorNode // TypeDefIndex: 76434
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 76433
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

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5> : ExtractorNode // TypeDefIndex: 76436
	{
		// Fields
		private T1 a;
		private T2 b;
		private T3 c;
		private T4 d;
		private T5 e;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76435
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

	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> : ExtractorNode // TypeDefIndex: 76438
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
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 76437
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
	public class AddDictionaryItem<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string, T> // TypeDefIndex: 76439
	{
		// Constructors
		public AddDictionaryItem();
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key, T item);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class GetDictionaryItem<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 76440
	{
		// Constructors
		public GetDictionaryItem();
	
		// Methods
		public override T Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class RemoveDictionaryKey<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string> // TypeDefIndex: 76441
	{
		// Constructors
		public RemoveDictionaryKey();
	
		// Methods
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class ClearDictionary : CallableFunctionNode<IDictionary, IDictionary> // TypeDefIndex: 76442
	{
		// Constructors
		public ClearDictionary(); // 0x000000018CADD8D8-0x000000018CADD900
	
		// Methods
		public override IDictionary Invoke(IDictionary dict); // 0x000000018CADD8B0-0x000000018CADD8D8
	}

	[Category("Collections/Dictionaries")]
	[ExposeAsDefinition]
	public class TryGetValue<T> : CallableFunctionNode<T, IDictionary<string, T>, string> // TypeDefIndex: 76443
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
	public class DictionaryContainsKey<T> : CallableFunctionNode<bool, IDictionary<string, T>, string> // TypeDefIndex: 76444
	{
		// Constructors
		public DictionaryContainsKey();
	
		// Methods
		public override bool Invoke(IDictionary<string, T> dict, string key);
	}

	[Category("Collections/Lists")]
	public class ClearList : CallableFunctionNode<IList, IList> // TypeDefIndex: 76445
	{
		// Constructors
		public ClearList(); // 0x000000018CADD928-0x000000018CADD950
	
		// Methods
		public override IList Invoke(IList list); // 0x000000018CADD900-0x000000018CADD928
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class AddListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 76446
	{
		// Constructors
		public AddListItem();
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class InsertListItem<T> : CallableFunctionNode<IList<T>, List<T>, int, T> // TypeDefIndex: 76447
	{
		// Constructors
		public InsertListItem();
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class RemoveListItem<T> : CallableFunctionNode<IList<T>, List<T>, T> // TypeDefIndex: 76448
	{
		// Constructors
		public RemoveListItem();
	
		// Methods
		public override IList<T> Invoke(List<T> list, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class RemoveListItemAt<T> : CallableFunctionNode<IList<T>, List<T>, int> // TypeDefIndex: 76449
	{
		// Constructors
		public RemoveListItemAt();
	
		// Methods
		public override IList<T> Invoke(List<T> list, int index);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class SetListItem<T> : CallableFunctionNode<IList<T>, IList<T>, int, T> // TypeDefIndex: 76450
	{
		// Constructors
		public SetListItem();
	
		// Methods
		public override IList<T> Invoke(IList<T> list, int index, T item);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class ShuffleList<T> : CallableFunctionNode<IList<T>, IList<T>> // TypeDefIndex: 76451
	{
		// Constructors
		public ShuffleList();
	
		// Methods
		public override IList<T> Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetListItem<T> : PureFunctionNode<T, IList<T>, int> // TypeDefIndex: 76452
	{
		// Constructors
		public GetListItem();
	
		// Methods
		public override T Invoke(IList<T> list, int index);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetRandomListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 76453
	{
		// Constructors
		public GetRandomListItem();
	
		// Methods
		public override T Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetLastListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 76454
	{
		// Constructors
		public GetLastListItem();
	
		// Methods
		public override T Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetFirstListItem<T> : PureFunctionNode<T, IList<T>> // TypeDefIndex: 76455
	{
		// Constructors
		public GetFirstListItem();
	
		// Methods
		public override T Invoke(IList<T> list);
	}

	[Category("Collections/Lists")]
	[ExposeAsDefinition]
	public class GetListItemIndex : PureFunctionNode<int, IList, object> // TypeDefIndex: 76456
	{
		// Constructors
		public GetListItemIndex(); // 0x000000018CAE0E50-0x000000018CAE0E78
	
		// Methods
		public override int Invoke(IList list, object item); // 0x000000018CAE0E28-0x000000018CAE0E50
	}

	[Category("Operators")]
	[Description("Returns if the object is not null")]
	[Name("Is Valid", 0)]
	public class IsNotNull : PureFunctionNode<bool, object> // TypeDefIndex: 76457
	{
		// Constructors
		public IsNotNull(); // 0x000000018CAE14A4-0x000000018CAE14CC
	
		// Methods
		public override bool Invoke(object OBJECT); // 0x000000018CAE1484-0x000000018CAE14A4
	}

	[Category("Operators")]
	[Description("Returns whether the input object is of type T as well as the object itself for convenience.")]
	public class IsOfType : PureFunctionNode<bool, object, System.Type> // TypeDefIndex: 76458
	{
		// Fields
		[CompilerGenerated]
		private object _OBJECT_k__BackingField; // 0x30
	
		// Properties
		public object OBJECT { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public IsOfType(); // 0x000000018CAE1550-0x000000018CAE1578
	
		// Methods
		public override bool Invoke(object OBJECT, System.Type type); // 0x000000018CAE14CC-0x000000018CAE1550
	}

	[Category("Operators/Any")]
	[Description("Any Greater Than")]
	[Name(">", 0)]
	public class AnyGreaterThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 76459
	{
		// Constructors
		public AnyGreaterThan(); // 0x000000018CADC01C-0x000000018CADC044
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018CADBFEC-0x000000018CADC01C
	}

	[Category("Operators/Any")]
	[Description("Any Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class AnyGreaterEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 76460
	{
		// Constructors
		public AnyGreaterEqualThan(); // 0x000000018CADBFC4-0x000000018CADBFEC
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018CADBF78-0x000000018CADBFC4
	}

	[Category("Operators/Any")]
	[Description("Any Less Than")]
	[Name("<", 0)]
	public class AnyLessThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 76461
	{
		// Constructors
		public AnyLessThan(); // 0x000000018CADC0E8-0x000000018CADC110
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018CADC0B8-0x000000018CADC0E8
	}

	[Category("Operators/Any")]
	[Description("Any Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class AnyLessEqualThan : PureFunctionNode<bool, IComparable, IComparable> // TypeDefIndex: 76462
	{
		// Constructors
		public AnyLessEqualThan(); // 0x000000018CADC090-0x000000018CADC0B8
	
		// Methods
		public override bool Invoke(IComparable a, IComparable b); // 0x000000018CADC044-0x000000018CADC090
	}

	[Category("Operators/Any")]
	[Description("Any Equal To")]
	[Name("=", 0)]
	public class AnyEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 76463
	{
		// Constructors
		public AnyEqual(); // 0x000000018CADBF50-0x000000018CADBF78
	
		// Methods
		public override bool Invoke(object a, object b); // 0x000000018CADBF3C-0x000000018CADBF50
	}

	[Category("Operators/Any")]
	[Description("Any Not Equal To")]
	[Name("\u2260", 0)]
	public class AnyNotEqual : PureFunctionNode<bool, object, object> // TypeDefIndex: 76464
	{
		// Constructors
		public AnyNotEqual(); // 0x000000018CADC12C-0x000000018CADC154
	
		// Methods
		public override bool Invoke(object a, object b); // 0x000000018CADC110-0x000000018CADC12C
	}

	[Category("Operators/Floats")]
	[Description("Float Add")]
	[Name("+", 0)]
	public class FloatAdd : PureFunctionNode<float, float, float> // TypeDefIndex: 76465
	{
		// Constructors
		public FloatAdd(); // 0x000000018CAE03A8-0x000000018CAE03D0
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000187254060-0x0000000187254070
	}

	[Category("Operators/Floats")]
	[Description("Float Subtract")]
	[Name("-", 0)]
	public class FloatSubtract : PureFunctionNode<float, float, float> // TypeDefIndex: 76466
	{
		// Constructors
		public FloatSubtract(); // 0x000000018CAE05E4-0x000000018CAE060C
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000187254090-0x00000001872540A0
	}

	[Category("Operators/Floats")]
	[Description("Float Mutliply")]
	[Name("\u00D7", 0)]
	public class FloatMultiply : PureFunctionNode<float, float, float> // TypeDefIndex: 76467
	{
		// Constructors
		public FloatMultiply(); // 0x000000018CAE0530-0x000000018CAE0558
	
		// Methods
		public override float Invoke(float a, float b); // 0x000000018724F9F0-0x000000018724FA00
	}

	[Category("Operators/Floats")]
	[Description("Float Divide")]
	[Name("\u00F7", 0)]
	public class FloatDivide : PureFunctionNode<float, float, float> // TypeDefIndex: 76468
	{
		// Constructors
		public FloatDivide(); // 0x000000018CAE03D0-0x000000018CAE03F8
	
		// Methods
		public override float Invoke(float a, float b); // 0x0000000188CA9638-0x0000000188CA9640
	}

	[Category("Operators/Floats")]
	[Description("Float Modulo")]
	[Name("%", 0)]
	public class FloatModulo : PureFunctionNode<float, float, float> // TypeDefIndex: 76469
	{
		// Constructors
		public FloatModulo(); // 0x000000018CAE0508-0x000000018CAE0530
	
		// Methods
		public override float Invoke(float value, float mod); // 0x0000000187254080-0x0000000187254090
	}

	[Category("Operators/Floats")]
	[Description("Float Greater Than")]
	[Name(">", 0)]
	public class FloatGreaterThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 76470
	{
		// Constructors
		public FloatGreaterThan(); // 0x000000018CAE0458-0x000000018CAE0480
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018CAE0450-0x000000018CAE0458
	}

	[Category("Operators/Floats")]
	[Description("Float Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class FloatGreaterEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 76471
	{
		// Constructors
		public FloatGreaterEqualThan(); // 0x000000018CAE0428-0x000000018CAE0450
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018CAE0420-0x000000018CAE0428
	}

	[Category("Operators/Floats")]
	[Description("Float Less Than")]
	[Name("<", 0)]
	public class FloatLessThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 76472
	{
		// Constructors
		public FloatLessThan(); // 0x000000018CAE04E0-0x000000018CAE0508
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018CAE04D8-0x000000018CAE04E0
	}

	[Category("Operators/Floats")]
	[Description("Float Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class FloatLessEqualThan : PureFunctionNode<bool, float, float> // TypeDefIndex: 76473
	{
		// Constructors
		public FloatLessEqualThan(); // 0x000000018CAE04B0-0x000000018CAE04D8
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018CAE04A8-0x000000018CAE04B0
	}

	[Category("Operators/Floats")]
	[Description("Float Equal To")]
	[Name("=", 0)]
	public class FloatEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 76474
	{
		// Constructors
		public FloatEqual(); // 0x000000018CAE03F8-0x000000018CAE0420
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018BB6FF3C-0x000000018BB6FF4C
	}

	[Category("Operators/Floats")]
	[Description("Float Not Equal To")]
	[Name("\u2260", 0)]
	public class FloatNotEqual : PureFunctionNode<bool, float, float> // TypeDefIndex: 76475
	{
		// Constructors
		public FloatNotEqual(); // 0x000000018CAE0568-0x000000018CAE0590
	
		// Methods
		public override bool Invoke(float a, float b); // 0x000000018CAE0558-0x000000018CAE0568
	}

	[Category("Operators/Floats")]
	[Description("Float Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class FloatInvert : PureFunctionNode<float, float> // TypeDefIndex: 76476
	{
		// Constructors
		public FloatInvert(); // 0x000000018CAE0480-0x000000018CAE04A8
	
		// Methods
		public override float Invoke(float value); // 0x0000000187254070-0x0000000187254080
	}

	[Category("Operators/Floats")]
	[Description("Float Round value to closest of interval ( round(value / interval) * interval )")]
	public class FloatSnap : PureFunctionNode<int, float, int> // TypeDefIndex: 76477
	{
		// Constructors
		public FloatSnap(); // 0x000000018CAE05BC-0x000000018CAE05E4
	
		// Methods
		public override int Invoke(float value, int interval); // 0x000000018CAE0590-0x000000018CAE05BC
	}

	[Category("Operators/Integers")]
	[Description("Integer Add")]
	[Name("+", 0)]
	public class IntegerAdd : PureFunctionNode<int, int, int> // TypeDefIndex: 76478
	{
		// Constructors
		public IntegerAdd(); // 0x000000018CAE1210-0x000000018CAE1238
	
		// Methods
		public override int Invoke(int a, int b); // 0x00000001872540A0-0x00000001872540B0
	}

	[Category("Operators/Integers")]
	[Description("Integer Subtract")]
	[Name("-", 0)]
	public class IntegerSubtract : PureFunctionNode<int, int, int> // TypeDefIndex: 76479
	{
		// Constructors
		public IntegerSubtract(); // 0x000000018CAE145C-0x000000018CAE1484
	
		// Methods
		public override int Invoke(int a, int b); // 0x00000001872540C0-0x00000001872540D0
	}

	[Category("Operators/Integers")]
	[Description("Integer Multiply")]
	[Name("\u00D7", 0)]
	public class IntegerMultiply : PureFunctionNode<int, int, int> // TypeDefIndex: 76480
	{
		// Constructors
		public IntegerMultiply(); // 0x000000018CAE13B4-0x000000018CAE13DC
	
		// Methods
		public override int Invoke(int a, int b); // 0x000000018724F9E0-0x000000018724F9F0
	}

	[Category("Operators/Integers")]
	[Description("Integer Divide")]
	[Name("\u00F7", 0)]
	public class IntegerDivide : PureFunctionNode<int, int, int> // TypeDefIndex: 76481
	{
		// Constructors
		public IntegerDivide(); // 0x000000018CAE1248-0x000000018CAE1270
	
		// Methods
		public override int Invoke(int a, int b); // 0x000000018CAE1238-0x000000018CAE1248
	}

	[Category("Operators/Integers")]
	[Description("Integer Modulo")]
	[Name("%", 0)]
	public class IntegerModulo : PureFunctionNode<int, int, int> // TypeDefIndex: 76482
	{
		// Constructors
		public IntegerModulo(); // 0x000000018CAE138C-0x000000018CAE13B4
	
		// Methods
		public override int Invoke(int value, int mod); // 0x000000018CAE1380-0x000000018CAE138C
	}

	[Category("Operators/Integers")]
	[Description("Integer Greater Than")]
	[Name(">", 0)]
	public class IntegerGreaterThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 76483
	{
		// Constructors
		public IntegerGreaterThan(); // 0x000000018CAE12D0-0x000000018CAE12F8
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018CAE12C8-0x000000018CAE12D0
	}

	[Category("Operators/Integers")]
	[Description("Integer Greater Or Equal Than")]
	[Name("\u2265", 0)]
	public class IntegerGreaterEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 76484
	{
		// Constructors
		public IntegerGreaterEqualThan(); // 0x000000018CAE12A0-0x000000018CAE12C8
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018CAE1298-0x000000018CAE12A0
	}

	[Category("Operators/Integers")]
	[Description("Integer Less Than")]
	[Name("<", 0)]
	public class IntegerLessThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 76485
	{
		// Constructors
		public IntegerLessThan(); // 0x000000018CAE1358-0x000000018CAE1380
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018CAE1350-0x000000018CAE1358
	}

	[Category("Operators/Integers")]
	[Description("Integer Less Or Equal Than")]
	[Name("\u2264", 0)]
	public class IntegerLessEqualThan : PureFunctionNode<bool, int, int> // TypeDefIndex: 76486
	{
		// Constructors
		public IntegerLessEqualThan(); // 0x000000018CAE1328-0x000000018CAE1350
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018CAE1320-0x000000018CAE1328
	}

	[Category("Operators/Integers")]
	[Description("Integer Equal To")]
	[Name("=", 0)]
	public class IntegerEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 76487
	{
		// Constructors
		public IntegerEqual(); // 0x000000018CAE1270-0x000000018CAE1298
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018BB719B4-0x000000018BB719BC
	}

	[Category("Operators/Integers")]
	[Description("Integer Not Equal To")]
	[Name("\u2260", 0)]
	public class IntegerNotEqual : PureFunctionNode<bool, int, int> // TypeDefIndex: 76488
	{
		// Constructors
		public IntegerNotEqual(); // 0x000000018CAE13E4-0x000000018CAE140C
	
		// Methods
		public override bool Invoke(int a, int b); // 0x000000018CAE13DC-0x000000018CAE13E4
	}

	[Category("Operators/Integers")]
	[Description("Integer Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class IntegerInvert : PureFunctionNode<int, int> // TypeDefIndex: 76489
	{
		// Constructors
		public IntegerInvert(); // 0x000000018CAE12F8-0x000000018CAE1320
	
		// Methods
		public override int Invoke(int value); // 0x00000001872540B0-0x00000001872540C0
	}

	[Category("Operators/Integers")]
	[Description("Integer Round value to closest of interval ( round(value / interval) * interval )")]
	public class IntegerSnap : PureFunctionNode<int, int, int> // TypeDefIndex: 76490
	{
		// Constructors
		public IntegerSnap(); // 0x000000018CAE1434-0x000000018CAE145C
	
		// Methods
		public override int Invoke(int value, int interval); // 0x000000018CAE140C-0x000000018CAE1434
	}

	[Category("Operators/Boolean")]
	[Description("Boolean Equal To")]
	[Name("=", 0)]
	public class BooleanEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 76491
	{
		// Constructors
		public BooleanEqual(); // 0x000000018CADD460-0x000000018CADD488
	
		// Methods
		public override bool Invoke(bool a, bool b); // 0x000000018B860344-0x000000018B860350
	}

	[Category("Operators/Boolean")]
	[Description("Boolean Not Equal To")]
	[Name("\u2260", 0)]
	public class BooleanNotEqual : PureFunctionNode<bool, bool, bool> // TypeDefIndex: 76492
	{
		// Constructors
		public BooleanNotEqual(); // 0x000000018CADD490-0x000000018CADD4B8
	
		// Methods
		public override bool Invoke(bool a, bool b); // 0x000000018CADD488-0x000000018CADD490
	}

	[Category("Operators/Boolean")]
	[Description("True if A and B are both true")]
	public class AND : PureFunctionNode<bool> // TypeDefIndex: 76493
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public AND(); // 0x000000018CADBF14-0x000000018CADBF3C
	
		// Methods
		public override bool Invoke(); // 0x000000018CADBDF4-0x000000018CADBE58
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018CADBE58-0x000000018CADBF14
	}

	[Category("Operators/Boolean")]
	[Description("True if A or B is true")]
	public class OR : PureFunctionNode<bool> // TypeDefIndex: 76494
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public OR(); // 0x000000018CAE2A58-0x000000018CAE2A80
	
		// Methods
		public override bool Invoke(); // 0x000000018CAE2934-0x000000018CAE299C
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018CAE299C-0x000000018CAE2A58
	}

	[Category("Operators/Boolean")]
	[Description("True if A or B is true, but not both")]
	public class XOR : PureFunctionNode<bool> // TypeDefIndex: 76495
	{
		// Fields
		private ValueInput<bool> a; // 0x30
		private ValueInput<bool> b; // 0x38
	
		// Constructors
		public XOR(); // 0x000000018CAEFCB4-0x000000018CAEFCDC
	
		// Methods
		public override bool Invoke(); // 0x000000018CAEFB80-0x000000018CAEFBF8
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018CAEFBF8-0x000000018CAEFCB4
	}

	[Category("Operators/Boolean")]
	[Description("Inverts the input")]
	public class NOT : PureFunctionNode<bool, bool> // TypeDefIndex: 76496
	{
		// Constructors
		public NOT(); // 0x000000018CAE2748-0x000000018CAE2770
	
		// Methods
		public override bool Invoke(bool value); // 0x000000018CAE2740-0x000000018CAE2748
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Equal To")]
	[Name("=", 0)]
	public class Vector3Equal : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 76497
	{
		// Constructors
		public Vector3Equal(); // 0x000000018CAEECC4-0x000000018CAEECEC
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b); // 0x000000018CAEEC70-0x000000018CAEECC4
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Not Equal To")]
	[Name("\u2260", 0)]
	public class Vector3NotEqual : PureFunctionNode<bool, Vector3, Vector3> // TypeDefIndex: 76498
	{
		// Constructors
		public Vector3NotEqual(); // 0x000000018CAEEE20-0x000000018CAEEE48
	
		// Methods
		public override bool Invoke(Vector3 a, Vector3 b); // 0x000000018CAEEDCC-0x000000018CAEEE20
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Add")]
	[Name("+", 0)]
	public class Vector3Add : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 76499
	{
		// Constructors
		public Vector3Add(); // 0x000000018CAEEBE8-0x000000018CAEEC10
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b); // 0x000000018CAEEB8C-0x000000018CAEEBE8
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Subtract")]
	[Name("-", 0)]
	public class Vector3Subtract : PureFunctionNode<Vector3, Vector3, Vector3> // TypeDefIndex: 76500
	{
		// Constructors
		public Vector3Subtract(); // 0x000000018CAEEEA4-0x000000018CAEEECC
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b); // 0x000000018CAEEE48-0x000000018CAEEEA4
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Multiply")]
	[Name("\u00D7", 0)]
	public class Vector3Multiply : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 76501
	{
		// Constructors
		public Vector3Multiply(); // 0x000000018CAEEDA4-0x000000018CAEEDCC
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b); // 0x000000018CAEED60-0x000000018CAEEDA4
	}

	[Category("Operators/Vector3")]
	[Description("Vectro3 Divide")]
	[Name("\u00F7", 0)]
	public class Vector3Divide : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 76502
	{
		// Constructors
		public Vector3Divide(); // 0x000000018CAEEC48-0x000000018CAEEC70
	
		// Methods
		public override Vector3 Invoke(Vector3 a, float b); // 0x000000018CAEEC10-0x000000018CAEEC48
	}

	[Category("Operators/Vector3")]
	[Description("Vector3 Invert the input ( value = value * -1 )")]
	[Name("Invert", 0)]
	public class Vector3Invert : PureFunctionNode<Vector3, Vector3> // TypeDefIndex: 76503
	{
		// Constructors
		public Vector3Invert(); // 0x000000018CAEED38-0x000000018CAEED60
	
		// Methods
		public override Vector3 Invoke(Vector3 value); // 0x000000018CAEECEC-0x000000018CAEED38
	}

	[Category("Operators/Flags")]
	[Description("Bitwise logical AND & operator")]
	[Name("AND", 0)]
	public class BitwiseAnd<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 76504
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
	public class BitwiseOr<T> : PureFunctionNode<T, T, T> // TypeDefIndex: 76505
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
	public class BitwiseInvert<T> : PureFunctionNode<T, T> // TypeDefIndex: 76506
		where T : Enum
	{
		// Constructors
		public BitwiseInvert();
	
		// Methods
		public override T Invoke(T a);
	}

	[Category("Time")]
	[Description("Wait for a certain amount of time before continueing")]
	public class Wait : LatentActionNode<float> // TypeDefIndex: 76508
	{
		// Fields
		[CompilerGenerated]
		private float _timeLeft_k__BackingField; // 0x68
		[CompilerGenerated]
		private float _normalized_k__BackingField; // 0x6C
	
		// Properties
		public float timeLeft { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723CA40-0x000000018723CA50 0x000000018723CA70-0x000000018723CA80
		public float normalized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187250E50-0x0000000187250E60 0x0000000187250F20-0x0000000187250F30
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__8 : IEnumerator<object> // TypeDefIndex: 76507
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Wait __4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__8(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEBA90-0x000000018CAEBB48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEBB48-0x000000018CAEBB94
		}
	
		// Constructors
		public Wait(); // 0x000000018CAEF634-0x000000018CAEF65C
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__8))]
		public override IEnumerator Invoke(float time = 1f /* Metadata: 0x02629CD3 */); // 0x000000018CAEF5C4-0x000000018CAEF634
	}

	[Category("Time")]
	[Description("Wait for one (the next) frame")]
	public class WaitForOneFrame : LatentActionNode // TypeDefIndex: 76510
	{
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 76509
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__2(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB1D8-0x000000018CAEB220
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB298-0x000000018CAEB2E4
		}
	
		// Constructors
		public WaitForOneFrame(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke(); // 0x000000018CAEF37C-0x000000018CAEF3C0
	}

	[Category("Time")]
	[Description("Wait until the physics update frame")]
	public class WaitForPhysicsFrame : LatentActionNode // TypeDefIndex: 76512
	{
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 76511
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__2(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB160-0x000000018CAEB1D8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB2E4-0x000000018CAEB330
		}
	
		// Constructors
		public WaitForPhysicsFrame(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke(); // 0x000000018CAEF3C0-0x000000018CAEF404
	}

	[Category("Time")]
	[Description("Wait until the end of current frame")]
	public class WaitForEndOfFrame : LatentActionNode // TypeDefIndex: 76514
	{
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__2 : IEnumerator<object> // TypeDefIndex: 76513
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__2(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB220-0x000000018CAEB298
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB330-0x000000018CAEB37C
		}
	
		// Constructors
		public WaitForEndOfFrame(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__2))]
		public override IEnumerator Invoke(); // 0x000000018CAEF338-0x000000018CAEF37C
	}

	[Category("Time")]
	[Description("Wait Until condition value becomes true")]
	public class WaitUntil : LatentActionNode // TypeDefIndex: 76516
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__3 : IEnumerator<object> // TypeDefIndex: 76515
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WaitUntil __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__3(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB37C-0x000000018CAEB464
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB54C-0x000000018CAEB598
		}
	
		// Constructors
		public WaitUntil(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__3))]
		public override IEnumerator Invoke(); // 0x000000018CAEF404-0x000000018CAEF460
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018CAEF460-0x000000018CAEF4E4
	}

	[Category("Time")]
	[Description("Wait While condition value is true")]
	public class WaitWhile : LatentActionNode // TypeDefIndex: 76518
	{
		// Fields
		private ValueInput<bool> condition; // 0x68
	
		// Properties
		public override bool allowRoutineQueueing { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__3 : IEnumerator<object> // TypeDefIndex: 76517
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WaitWhile __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__3(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB464-0x000000018CAEB54C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB598-0x000000018CAEB5E4
		}
	
		// Constructors
		public WaitWhile(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__3))]
		public override IEnumerator Invoke(); // 0x000000018CAEF4E4-0x000000018CAEF540
		protected override void OnRegisterExtraPorts(FlowNode node); // 0x000000018CAEF540-0x000000018CAEF5C4
	}

	[Category("Time")]
	[Description("Mutliply input value by Time.deltaTime and optional multiplier")]
	[Name("Per Second (Float)", 0)]
	public class DeltaTimed : PureFunctionNode<float, float, float> // TypeDefIndex: 76519
	{
		// Constructors
		public DeltaTimed(); // 0x000000018CADF88C-0x000000018CADF8B4
	
		// Methods
		public override float Invoke(float value, float multiplier = 1f /* Metadata: 0x02629CD7 */); // 0x000000018CADF858-0x000000018CADF88C
	}

	[Category("Time")]
	[Description("Mutliply input value by Time.deltaTime and optional multiplier")]
	[Name("Per Second (Vector3)", 0)]
	public class DeltaTimedVector3 : PureFunctionNode<Vector3, Vector3, float> // TypeDefIndex: 76520
	{
		// Constructors
		public DeltaTimedVector3(); // 0x000000018CADF830-0x000000018CADF858
	
		// Methods
		public override Vector3 Invoke(Vector3 value, float multiplier = 1f /* Metadata: 0x02629CDB */); // 0x000000018CADF7AC-0x000000018CADF830
	}

	[Category("Time")]
	[Description("Input values are buffered and returned in order of buffering once the buffered amount reaches the buffer size. In practice this creates a delayed value output when the node is constantly updated per-frame.\nWhen the node ceases to update, a new buffer is created.")]
	[ExposeAsDefinition]
	public class Buffer<T> : PureFunctionNode<T, T, int> // TypeDefIndex: 76521
	{
		// Fields
		private int lastFrame;
		private Queue<T> q;
	
		// Constructors
		public Buffer();
	
		// Methods
		public override T Invoke(T value, int size = 60 /* Metadata: 0x02629CDF */);
	}

	[Category("Time")]
	[Description("Returns a smoothly interpolated value towards the input value.")]
	[Name("Damp (Float)", 0)]
	public class DampFloat : PureFunctionNode<float, float, float, float> // TypeDefIndex: 76522
	{
		// Constructors
		public DampFloat(); // 0x000000018CADF6EC-0x000000018CADF714
	
		// Methods
		public override float Invoke(float current, float target, float damp = 1f /* Metadata: 0x02629CE0 */); // 0x000000018CADF6A0-0x000000018CADF6EC
	}

	[Category("Time")]
	[Description("Returns a smoothly interpolated value towards the input value.")]
	[Name("Damp (Vector3)", 0)]
	public class DampVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float> // TypeDefIndex: 76523
	{
		// Constructors
		public DampVector3(); // 0x000000018CADF784-0x000000018CADF7AC
	
		// Methods
		public override Vector3 Invoke(Vector3 current, Vector3 target, float damp = 1f /* Metadata: 0x02629CE4 */); // 0x000000018CADF714-0x000000018CADF784
	}

	[Category("Tweening/Values")]
	public class LerpFloat : PureFunctionNode<float, float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76524
	{
		// Constructors
		public LerpFloat(); // 0x000000018CAE20F0-0x000000018CAE2118
	
		// Methods
		public override float Invoke(float a, float b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018CAE20DC-0x000000018CAE20F0
	}

	[Category("Tweening/Values")]
	public class LerpVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76525
	{
		// Constructors
		public LerpVector3(); // 0x000000018CAE2214-0x000000018CAE223C
	
		// Methods
		public override Vector3 Invoke(Vector3 a, Vector3 b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018CAE219C-0x000000018CAE2214
	}

	[Category("Tweening/Values")]
	public class LerpQuaternion : PureFunctionNode<Quaternion, Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76526
	{
		// Constructors
		public LerpQuaternion(); // 0x000000018CAE2174-0x000000018CAE219C
	
		// Methods
		public override Quaternion Invoke(Quaternion a, Quaternion b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018CAE2118-0x000000018CAE2174
	}

	[Category("Tweening/Values")]
	public class LerpColor : PureFunctionNode<UnityEngine.Color, UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76527
	{
		// Constructors
		public LerpColor(); // 0x000000018CAE20B4-0x000000018CAE20DC
	
		// Methods
		public override UnityEngine.Color Invoke(UnityEngine.Color a, UnityEngine.Color b, float t, ParadoxNotion.Animation.EaseType interpolation); // 0x000000018CAE2058-0x000000018CAE20B4
	}

	[Category("Tweening/Values")]
	public class TweenFloat : LatentActionNode<float, float, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76529
	{
		// Fields
		[CompilerGenerated]
		private float _value_k__BackingField; // 0x68
	
		// Properties
		public float value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723CA40-0x000000018723CA50 0x000000018723CA70-0x000000018723CA80
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 76528
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB5E4-0x000000018CAEB698
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB9F8-0x000000018CAEBA44
		}
	
		// Constructors
		public TweenFloat(); // 0x000000018CAE9AAC-0x000000018CAE9AD4
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(float from, float to, float duration = 1f /* Metadata: 0x02629CE8 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629CEC */); // 0x000000018CAE9A08-0x000000018CAE9AAC
	}

	[Category("Tweening/Values")]
	public class TweenVector3 : LatentActionNode<Vector3, Vector3, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76531
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _value_k__BackingField; // 0x68
	
		// Properties
		public Vector3 value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187254110-0x0000000187254130 0x0000000187254130-0x0000000187254140
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 76530
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB860-0x000000018CAEB960
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB960-0x000000018CAEB9AC
		}
	
		// Constructors
		public TweenVector3(); // 0x000000018CAE9EF4-0x000000018CAE9F1C
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(Vector3 from, Vector3 to, float duration = 1f /* Metadata: 0x02629CED */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629CF1 */); // 0x000000018CAE9E40-0x000000018CAE9EF4
	}

	[Category("Tweening/Values")]
	public class TweenQuaternion : LatentActionNode<Quaternion, Quaternion, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76533
	{
		// Fields
		[CompilerGenerated]
		private Quaternion _value_k__BackingField; // 0x68
	
		// Properties
		public Quaternion value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187253FA0-0x0000000187253FB0 0x0000000187233C70-0x0000000187233C80
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 76532
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB698-0x000000018CAEB77C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEBA44-0x000000018CAEBA90
		}
	
		// Constructors
		public TweenQuaternion(); // 0x000000018CAE9C58-0x000000018CAE9C80
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(Quaternion from, Quaternion to, float duration = 1f /* Metadata: 0x02629CF2 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629CF6 */); // 0x000000018CAE9BB4-0x000000018CAE9C58
	}

	[Category("Tweening/Values")]
	public class TweenColor : LatentActionNode<UnityEngine.Color, UnityEngine.Color, float, ParadoxNotion.Animation.EaseType> // TypeDefIndex: 76535
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.Color _value_k__BackingField; // 0x68
	
		// Properties
		public UnityEngine.Color value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187253FA0-0x0000000187253FB0 0x0000000187233C70-0x0000000187233C80
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__4 : IEnumerator<object> // TypeDefIndex: 76534
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEB77C-0x000000018CAEB860
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB9AC-0x000000018CAEB9F8
		}
	
		// Constructors
		public TweenColor(); // 0x000000018CAE99E0-0x000000018CAE9A08
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__4))]
		public override IEnumerator Invoke(UnityEngine.Color from, UnityEngine.Color to, float duration = 1f /* Metadata: 0x02629CF7 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629CFB */); // 0x000000018CAE993C-0x000000018CAE99E0
	}

	[Category("Tweening")]
	public class TweenPosition : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 76537
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 76536
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__0(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEAC04-0x000000018CAEAE40
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB0C8-0x000000018CAEB114
		}
	
		// Constructors
		public TweenPosition(); // 0x000000018CAE9B8C-0x000000018CAE9BB4
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 position, float duration = 0.25f /* Metadata: 0x02629CFC */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629D00 */, bool relative = false /* Metadata: 0x02629D01 */); // 0x000000018CAE9AD4-0x000000018CAE9B8C
	}

	[Category("Tweening")]
	public class TweenRotation : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 76539
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 76538
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__0(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEA9D0-0x000000018CAEAC04
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB114-0x000000018CAEB160
		}
	
		// Constructors
		public TweenRotation(); // 0x000000018CAE9D38-0x000000018CAE9D60
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 rotation, float duration = 0.25f /* Metadata: 0x02629D02 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629D06 */, bool relative = false /* Metadata: 0x02629D07 */); // 0x000000018CAE9C80-0x000000018CAE9D38
	}

	[Category("Tweening")]
	public class TweenScale : LatentActionNode<Transform, Vector3, float, ParadoxNotion.Animation.EaseType, bool> // TypeDefIndex: 76541
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Invoke_d__0 : IEnumerator<object> // TypeDefIndex: 76540
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Invoke_d__0(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEAE40-0x000000018CAEB07C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEB07C-0x000000018CAEB0C8
		}
	
		// Constructors
		public TweenScale(); // 0x000000018CAE9E18-0x000000018CAE9E40
	
		// Methods
		[IteratorStateMachine(typeof(_Invoke_d__0))]
		public override IEnumerator Invoke(Transform transform, Vector3 scale, float duration = 0.25f /* Metadata: 0x02629D08 */, ParadoxNotion.Animation.EaseType interpolation = ParadoxNotion.Animation.EaseType.QuadraticInOut /* Metadata: 0x02629D0C */, bool relative = false /* Metadata: 0x02629D0D */); // 0x000000018CAE9D60-0x000000018CAE9E18
	}

	[Category("Unity")]
	[Description("If \'Try Get Existing\' is true, then if there is an existing component of that type already attached to the gameobject, it will be returned instead of adding another instance.")]
	public class AddComponent<T> : CallableFunctionNode<T, GameObject, bool> // TypeDefIndex: 76542
		where T : Component
	{
		// Constructors
		public AddComponent();
	
		// Methods
		public override T Invoke(GameObject gameObject, bool tryGetExisting);
	}

	[Category("Unity")]
	[Description("Get a component attached on an object")]
	public class GetComponent<T> : PureFunctionNode<T, GameObject> // TypeDefIndex: 76543
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
	public class Instantiate<T> : CallableFunctionNode<T, T, Vector3, Quaternion, Transform> // TypeDefIndex: 76544
		where T : UnityEngine.Object
	{
		// Constructors
		public Instantiate();
	
		// Methods
		public override T Invoke(T original, Vector3 position, Quaternion rotation, Transform parent);
	}

	[Category("Unity")]
	[Description("Creates a new ScriptableObject instance")]
	public class NewScriptableObject<T> : CallableFunctionNode<T> // TypeDefIndex: 76545
		where T : ScriptableObject
	{
		// Constructors
		public NewScriptableObject();
	
		// Methods
		public override T Invoke();
	}

	[Category("Unity")]
	[Description("Get all child transforms of specified parent")]
	public class GetChildTransforms : PureFunctionNode<IEnumerable<Transform>, Transform> // TypeDefIndex: 76546
	{
		// Constructors
		public GetChildTransforms(); // 0x000000018CAE0E00-0x000000018CAE0E28
	
		// Methods
		public override IEnumerable<Transform> Invoke(Transform parent); // 0x000000018CAE0DC4-0x000000018CAE0E00
	}

	[Category("Utility")]
	[Description("Custom cast input object to type T. Note that casts are already automatic at a connection-level. Use this only if necessary in your setup.")]
	[ExposeAsDefinition]
	public class Cast<T> : PureFunctionNode<T, object> // TypeDefIndex: 76547
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
	public class Identity<T> : PureFunctionNode<T, T> // TypeDefIndex: 76548
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
	public class Cache<T> : CallableFunctionNode<T, T> // TypeDefIndex: 76549
	{
		// Constructors
		public Cache();
	
		// Methods
		public override T Invoke(T value);
	}

	[Category("Utility")]
	[Description("Remaps from input min/max to output min/max, by current value provided between input min/max")]
	[Name("Remap To Float", 0)]
	public class RemapFloat : PureFunctionNode<float, float, float, float, float, float> // TypeDefIndex: 76550
	{
		// Constructors
		public RemapFloat(); // 0x000000018CAE6F48-0x000000018CAE6F70
	
		// Methods
		public override float Invoke(float current, float iMin, float iMax = 1f /* Metadata: 0x02629D0E */, float oMin = 0f /* Metadata: 0x02629D12 */, float oMax = 100f /* Metadata: 0x02629D16 */); // 0x000000018CAE6F1C-0x000000018CAE6F48
	}

	[Category("Utility")]
	[Description("Remaps from input min/max to output min/max, by current value provided between input min/max")]
	[Name("Remap To Vector3", 0)]
	public class RemapVector3 : PureFunctionNode<Vector3, float, float, float, Vector3, Vector3> // TypeDefIndex: 76551
	{
		// Constructors
		public RemapVector3(); // 0x000000018CAE6FEC-0x000000018CAE7014
	
		// Methods
		public override Vector3 Invoke(float current, float iMin, float iMax, Vector3 oMin, Vector3 oMax); // 0x000000018CAE6F70-0x000000018CAE6FEC
	}

	[Category("Utility")]
	[Description("Log input value on the console")]
	public class LogValue : CallableActionNode<object> // TypeDefIndex: 76552
	{
		// Constructors
		public LogValue(); // 0x000000018CAE2264-0x000000018CAE228C
	
		// Methods
		public override void Invoke(object obj); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("Utility")]
	[Description("Log text in the console")]
	public class LogText : CallableActionNode<string> // TypeDefIndex: 76553
	{
		// Constructors
		public LogText(); // 0x000000018CAE223C-0x000000018CAE2264
	
		// Methods
		public override void Invoke(string text); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("Utility")]
	[Description("Send a Local Event to specified graph")]
	public class SendEvent : CallableActionNode<GraphOwner, string> // TypeDefIndex: 76554
	{
		// Constructors
		public SendEvent(); // 0x000000018CAE71C4-0x000000018CAE71EC
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName); // 0x000000018CAE718C-0x000000018CAE71C4
	}

	[Category("Utility")]
	[Description("Send a Local Event with 1 argument to specified graph")]
	[ExposeAsDefinition]
	public class SendEvent<T> : CallableActionNode<GraphOwner, string, T> // TypeDefIndex: 76555
	{
		// Constructors
		public SendEvent();
	
		// Methods
		public override void Invoke(GraphOwner target, string eventName, T eventValue);
	}

	[Category("Utility")]
	[Description("Send a Global Event to all graphs")]
	public class SendGlobalEvent : CallableActionNode<string> // TypeDefIndex: 76556
	{
		// Constructors
		public SendGlobalEvent(); // 0x000000018CAE7244-0x000000018CAE726C
	
		// Methods
		public override void Invoke(string eventName); // 0x000000018CAE71EC-0x000000018CAE7244
	}

	[Category("Utility")]
	[Description("Send a Global Event with 1 argument to all graphs")]
	[ExposeAsDefinition]
	public class SendGlobalEvent<T> : CallableActionNode<string, T> // TypeDefIndex: 76557
	{
		// Constructors
		public SendGlobalEvent();
	
		// Methods
		public override void Invoke(string eventName, T eventValue);
	}

	public abstract class LatentActionNodeBase : SimplexNode // TypeDefIndex: 76561
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
		public override string name { get; } // 0x000000018CAE1EA0-0x000000018CAE1F44 
		public virtual bool allowRoutineQueueing { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		public enum InvocationMode // TypeDefIndex: 76558
		{
			QueueCalls = 0,
			FilterCalls = 1
		}
	
		private struct RoutineData // TypeDefIndex: 76559
		{
			// Fields
			public IEnumerator enumerator; // 0x00
			public Flow flow; // 0x08
	
			// Constructors
			public RoutineData(IEnumerator enumerator, Flow flow); // 0x0000000186C4F960-0x0000000186C4F9A0
		}
	
		[CompilerGenerated]
		private sealed class _InternalCoroutine_d__15 : IEnumerator<object> // TypeDefIndex: 76560
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RoutineData data; // 0x20
			public LatentActionNodeBase __4__this; // 0x50
			private Flow _f_5__2; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _InternalCoroutine_d__15(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CAEA648-0x000000018CAEA984
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CAEA984-0x000000018CAEA9D0
		}
	
		// Constructors
		protected LatentActionNodeBase(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public sealed override void OnGraphStarted(); // 0x00000001872540D0-0x00000001872540E0
		public sealed override void OnGraphStoped(); // 0x000000018CAE1C5C-0x000000018CAE1C6C
		protected void Begin(IEnumerator enumerator, Flow f); // 0x000000018CAE1974-0x000000018CAE1B08
		protected void BreakAll(bool callFinish); // 0x000000018CAE1B08-0x000000018CAE1BD0
		[IteratorStateMachine(typeof(_InternalCoroutine_d__15))]
		private IEnumerator InternalCoroutine(RoutineData data); // 0x000000018CAE1BD0-0x000000018CAE1C5C
		protected override void OnRegisterPorts(FlowNode node); // 0x000000018CAE1C6C-0x000000018CAE1E88
		protected abstract void OnRegisterDerivedPorts(FlowNode node);
		public virtual void OnBreak(); // 0x0000000186805BA0-0x0000000186805BB0
		[CompilerGenerated]
		private void _InternalCoroutine_b__15_0(); // 0x000000018CAE1E88-0x000000018CAE1E94
		[CompilerGenerated]
		private void _OnRegisterPorts_b__16_0(Flow f); // 0x000000018CAE1E88-0x000000018CAE1E94
		[CompilerGenerated]
		private void _OnRegisterPorts_b__16_1(Flow f); // 0x000000018CAE1E94-0x000000018CAE1EA0
	}

	public abstract class LatentActionNode : LatentActionNodeBase // TypeDefIndex: 76562
	{
		// Constructors
		protected LatentActionNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract IEnumerator Invoke();
		protected sealed override void OnRegisterDerivedPorts(FlowNode node); // 0x000000018CAE1F44-0x000000018CAE2000
		[CompilerGenerated]
		private void _OnRegisterDerivedPorts_b__1_0(Flow f); // 0x000000018CAE2000-0x000000018CAE2058
	}

	public abstract class LatentActionNode<T1> : LatentActionNodeBase // TypeDefIndex: 76564
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76563
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

	public abstract class LatentActionNode<T1, T2> : LatentActionNodeBase // TypeDefIndex: 76566
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76565
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

	public abstract class LatentActionNode<T1, T2, T3> : LatentActionNodeBase // TypeDefIndex: 76568
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76567
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

	public abstract class LatentActionNode<T1, T2, T3, T4> : LatentActionNodeBase // TypeDefIndex: 76570
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76569
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

	public abstract class LatentActionNode<T1, T2, T3, T4, T5> : LatentActionNodeBase // TypeDefIndex: 76572
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76571
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

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6> : LatentActionNodeBase // TypeDefIndex: 76574
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76573
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

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7> : LatentActionNodeBase // TypeDefIndex: 76576
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76575
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

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : LatentActionNodeBase // TypeDefIndex: 76578
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76577
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

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : LatentActionNodeBase // TypeDefIndex: 76580
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76579
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

	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : LatentActionNodeBase // TypeDefIndex: 76582
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76581
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

	public abstract class PureFunctionNodeBase : SimplexNode // TypeDefIndex: 76583
	{
		// Constructors
		protected PureFunctionNodeBase(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class PureFunctionNode<TResult> : PureFunctionNodeBase // TypeDefIndex: 76584
	{
		// Constructors
		protected PureFunctionNode();
	
		// Methods
		public abstract TResult Invoke();
		protected sealed override void OnRegisterPorts(FlowNode node);
		[CompilerGenerated]
		private TResult _OnRegisterPorts_b__1_0();
	}

	public abstract class PureFunctionNode<TResult, T1> : PureFunctionNodeBase // TypeDefIndex: 76586
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76585
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

	public abstract class PureFunctionNode<TResult, T1, T2> : PureFunctionNodeBase // TypeDefIndex: 76588
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76587
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3> : PureFunctionNodeBase // TypeDefIndex: 76590
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76589
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4> : PureFunctionNodeBase // TypeDefIndex: 76592
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76591
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5> : PureFunctionNodeBase // TypeDefIndex: 76594
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76593
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : PureFunctionNodeBase // TypeDefIndex: 76596
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76595
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : PureFunctionNodeBase // TypeDefIndex: 76598
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76597
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : PureFunctionNodeBase // TypeDefIndex: 76600
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76599
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : PureFunctionNodeBase // TypeDefIndex: 76602
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76601
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

	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : PureFunctionNodeBase // TypeDefIndex: 76604
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76603
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
	public abstract class SimplexNode // TypeDefIndex: 76605
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
		protected FlowNode parentNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public virtual string name { get; } // 0x000000018CAE7A3C-0x000000018CAE7B20 
		public virtual string description { get; } // 0x000000018CAE7994-0x000000018CAE7A3C 
		public ParameterInfo[] parameters { get; } // 0x000000018CAE7B20-0x000000018CAE7BE4 
	
		// Constructors
		protected SimplexNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void RegisterPorts(FlowNode node); // 0x000000018CAE7778-0x000000018CAE7878
		public void SetDefaultParameters(FlowNode node); // 0x000000018CAE7878-0x000000018CAE7994
		protected abstract void OnRegisterPorts(FlowNode node);
		protected virtual void OnRegisterExtraPorts(FlowNode node); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphStarted(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphPaused(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphUnpaused(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphStoped(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[DoNotList]
	public abstract class SimplexNodeWrapper : FlowNode // TypeDefIndex: 76606
	{
		// Constructors
		protected SimplexNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	}

	public class SimplexNodeWrapper<T> : SimplexNodeWrapper // TypeDefIndex: 76607
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

	public delegate void EventUniversalDelegate(); // TypeDefIndex: 76608; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void EventUniversalDelegate<in T1>(T1 arg1); // TypeDefIndex: 76609; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2>(T1 arg1, T2 arg2); // TypeDefIndex: 76610; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 76611; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 76612; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 76613; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 76614; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7); // TypeDefIndex: 76615; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); // TypeDefIndex: 76616; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9); // TypeDefIndex: 76617; 0x00000000-0x00000000

	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10); // TypeDefIndex: 76618; 0x00000000-0x00000000

	[AttributeUsage(AttributeTargets.Class)]
	public class GeneratedKeyAttribute : Attribute // TypeDefIndex: 76619
	{
		// Fields
		private string memberString; // 0x10
	
		// Properties
		public string MemberName { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public GeneratedKeyAttribute(string memberName); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public struct ParamDef // TypeDefIndex: 76620
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

	public struct ParametresDef // TypeDefIndex: 76621
	{
		// Fields
		public List<ParamDef> paramDefinitions; // 0x00
		public ParamDef instanceDef; // 0x08
		public ParamDef resultDef; // 0x40
	}

	public enum ParamMode // TypeDefIndex: 76622
	{
		Undefined = 0,
		In = 1,
		Out = 2,
		Ref = 3,
		Instance = 4,
		Result = 6
	}

	public static class ReflectedNodesHelper // TypeDefIndex: 76623
	{
		// Fields
		private const string RETURN_VALUE_NAME = "Value"; // Metadata: 0x02629D22
	
		// Methods
		public static ParamDef GetGetterDefFromInfo(MemberInfo info); // 0x000000018CAE58A8-0x000000018CAE5AEC
		public static ParamDef GetDefFromInfo(ParameterInfo info, bool last); // 0x000000018CAE55F0-0x000000018CAE57C8
		public static bool InitParams(System.Type targetType, bool isStatic, MemberInfo[] infos, out ParametresDef parametres); // 0x000000018CAE5AEC-0x000000018CAE5DEC
		private static bool InitParams(ParameterInfo[] prms, System.Type returnType, ref ParametresDef parametres); // 0x000000018CAE5DEC-0x000000018CAE60AC
		public static bool InitParams(ConstructorInfo constructor, out ParametresDef parametres); // 0x000000018CAE60AC-0x000000018CAE627C
		public static bool InitParams(MethodInfo method, out ParametresDef parametres); // 0x000000018CAE64A4-0x000000018CAE66B8
		public static bool InitParams(System.Reflection.FieldInfo field, out ParametresDef parametres); // 0x000000018CAE627C-0x000000018CAE64A4
		public static string GetGeneratedKey(MemberInfo memberInfo); // 0x000000018CAE57C8-0x000000018CAE58A8
	}

	public delegate void UniversalDelegate(UniversalDelegateParam[] delegateParams); // TypeDefIndex: 76624; 0x0000000185B78EA0-0x0000000185B78EB0

	public abstract class UniversalDelegateParam // TypeDefIndex: 76625
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
		protected UniversalDelegateParam(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract System.Type GetCurrentType();
		public abstract void RegisterAsInput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node);
		public abstract void RegisterAsOutput(FlowNode node, Action beforeReturn);
		public abstract void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn);
		public abstract void SetFromInput();
		public abstract void SetFromValue(object value);
	}

	public class UniversalDelegateParam<T> : UniversalDelegateParam // TypeDefIndex: 76627
	{
		// Fields
		public T value;
		private ValueInput<T> valueInput;
		private static System.Reflection.FieldInfo _fieldInfo;
	
		// Properties
		public override System.Reflection.FieldInfo ValueField { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 76626
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

	public class UniversalDelegateParam<TArray, TValue> : UniversalDelegateParam<TArray> // TypeDefIndex: 76628
	{
		// Fields
		private ValueInput<TValue>[] valueInputs;
	
		// Constructors
		public UniversalDelegateParam();
	
		// Methods
		public override void RegisterAsInput(FlowNode node);
		public override void SetFromInput();
	}

	public abstract class BaseReflectedConstructorNode // TypeDefIndex: 76629
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
			add; // 0x000000018CADC69C-0x000000018CADC738
			remove; // 0x000000018CADC738-0x000000018CADC7D4
		}
	
		// Constructors
		protected BaseReflectedConstructorNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static BaseReflectedConstructorNode GetConstructorNode(ConstructorInfo targetConstructor, ReflectedMethodRegistrationOptions options); // 0x000000018CADC2F0-0x000000018CADC4A4
		protected bool Init(ConstructorInfo constructor, ParametresDef parametres); // 0x000000018CADC4A4-0x000000018CADC69C
		protected abstract bool InitInternal(ConstructorInfo constructor);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectionConstructorNode : BaseReflectedConstructorNode // TypeDefIndex: 76633
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
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 76630
		{
			// Fields
			public bool callable; // 0x10
			public PureReflectionConstructorNode __4__this; // 0x18
			public int idx; // 0x20
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterOutput_b__0(); // 0x000000018CAED8E0-0x000000018CAED934
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 76631
		{
			// Fields
			public PureReflectionConstructorNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAEC0A0-0x000000018CAEC0DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 76632
		{
			// Fields
			public FlowOutput output; // 0x10
			public __c__DisplayClass10_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass10_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__1(Flow flow); // 0x000000018CAEC0DC-0x000000018CAEC148
		}
	
		// Constructors
		public PureReflectionConstructorNode(); // 0x0000000187250020-0x0000000187250030
	
		// Methods
		protected override bool InitInternal(ConstructorInfo constructor); // 0x000000018CAE42D4-0x000000018CAE4448
		private void Call(); // 0x000000018CAE413C-0x000000018CAE42D4
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx); // 0x000000018CAE4600-0x000000018CAE4704
		private void RegisterInput(FlowNode node, ParamDef def, int idx); // 0x000000018CAE4448-0x000000018CAE4600
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options); // 0x000000018CAE4704-0x000000018CAE4A5C
	}

	[SpoofAOT]
	public class ReflectedDelegateEvent // TypeDefIndex: 76636
	{
		// Fields
		[CompilerGenerated]
		private DelegateEventCallback onCallback; // 0x10
		private Delegate theDelegate; // 0x18
	
		// Events
		private event DelegateEventCallback onCallback {
			add; // 0x000000018CAE54C8-0x000000018CAE555C
			remove; // 0x000000018CAE555C-0x000000018CAE55F0
		}
	
		// Nested types
		public delegate void DelegateEventCallback(params object[] args); // TypeDefIndex: 76634; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76635
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CAED9FC-0x000000018CAEDA60
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Type _GetMethodForDelegateType_b__10_0(ParameterInfo p); // 0x0000000188E4BE2C-0x0000000188E4BE44
		}
	
		// Constructors
		public ReflectedDelegateEvent(); // 0x0000000186805BA0-0x0000000186805BB0
		public ReflectedDelegateEvent(System.Type delegateType); // 0x000000018CAE544C-0x000000018CAE54C8
	
		// Methods
		public void Add(DelegateEventCallback callback); // 0x000000018CAE4F80-0x000000018CAE4F88
		public void Remove(DelegateEventCallback callback); // 0x000000018CAE5444-0x000000018CAE544C
		public Delegate AsDelegate(); // 0x0000000182234E30-0x0000000182234E40
		private MethodInfo GetMethodForDelegateType(System.Type delegateType); // 0x000000018CAE4FE0-0x000000018CAE5444
		public void Callback0(); // 0x000000018CAE4F88-0x000000018CAE4FE0
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
		public static explicit operator Delegate(ReflectedDelegateEvent that); // 0x000000018788A2DC-0x000000018788A2F4
	}

	[SpoofAOT]
	public class ReflectedUnityEvent // TypeDefIndex: 76639
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
		public ParameterInfo[] parameters { get; } // 0x00000001829600D0-0x00000001829600E0 
		public System.Type eventType { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Events
		private event UnityEventCallback _callback {
			add; // 0x000000018CAE6DF4-0x000000018CAE6E88
			remove; // 0x000000018CAE6E88-0x000000018CAE6F1C
		}
	
		// Nested types
		public delegate void UnityEventCallback(params object[] args); // TypeDefIndex: 76637; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76638
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CAEDA60-0x000000018CAEDAC4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Type _InitForEventType_b__15_0(ParameterInfo p); // 0x0000000188E4BE2C-0x0000000188E4BE44
		}
	
		// Constructors
		public ReflectedUnityEvent(); // 0x0000000186805BA0-0x0000000186805BB0
		public ReflectedUnityEvent(System.Type eventType); // 0x000000018CAE6DEC-0x000000018CAE6DF4
	
		// Methods
		public void InitForEventType(System.Type eventType); // 0x000000018CAE6710-0x000000018CAE6C54
		public void StartListening(UnityEventBase targetEvent, UnityEventCallback callback); // 0x000000018CAE6C54-0x000000018CAE6D20
		public void StopListening(UnityEventBase targetEvent, UnityEventCallback callback); // 0x000000018CAE6D20-0x000000018CAE6DEC
		public void CallbackMethod0(); // 0x000000018CAE66B8-0x000000018CAE6710
		public void CallbackMethod1<T0>(T0 arg0);
		public void CallbackMethod2<T0, T1>(T0 arg0, T1 arg1);
		public void CallbackMethod3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2);
		public void CallbackMethod4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
	}

	public abstract class SharpEvent // TypeDefIndex: 76640
	{
		// Fields
		[CompilerGenerated]
		private object _instance_k__BackingField; // 0x10
		[CompilerGenerated]
		private EventInfo _eventInfo_k__BackingField; // 0x18
	
		// Properties
		public object instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public EventInfo eventInfo { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		protected SharpEvent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static SharpEvent Create(EventInfo eventInfo); // 0x000000018CAE7580-0x000000018CAE76C8
		public void SetInstance(object instance); // 0x0000000184FD2410-0x0000000184FD2420
		public void StartListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback); // 0x000000018CAE76C8-0x000000018CAE7720
		public void StopListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback); // 0x000000018CAE7720-0x000000018CAE7778
	}

	public class SharpEvent<T> : SharpEvent // TypeDefIndex: 76641
	{
		// Constructors
		public SharpEvent();
	}

	public abstract class BaseReflectedExtractorNode // TypeDefIndex: 76642
	{
		// Fields
		[CompilerGenerated]
		private static Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode; // 0x00
		[CompilerGenerated]
		private ParametresDef _Params_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type _TargetType_k__BackingField; // 0x88
	
		// Properties
		protected ParametresDef Params { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187245870-0x00000001872458C0 0x000000018CADCB3C-0x000000018CADCB8C
		protected System.Type TargetType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
	
		// Events
		protected static event Func<System.Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode {
			add; // 0x000000018CADCA04-0x000000018CADCAA0
			remove; // 0x000000018CADCAA0-0x000000018CADCB3C
		}
	
		// Constructors
		protected BaseReflectedExtractorNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static BaseReflectedExtractorNode GetExtractorNode(System.Type targetType, bool isStatic, MemberInfo[] infos); // 0x000000018CADC7D4-0x000000018CADC988
		protected bool Init(ParametresDef paramsDef, System.Type targetType); // 0x000000018CADC988-0x000000018CADCA04
		protected abstract bool InitInternal();
		public abstract void RegisterPorts(FlowNode node);
	}

	public class PureReflectedExtractorNode : BaseReflectedExtractorNode // TypeDefIndex: 76645
	{
		// Fields
		private static readonly object[] EmptyParams; // 0x00
		private ValueInput instanceInput; // 0x90
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76643
		{
			// Fields
			public PureReflectedExtractorNode __4__this; // 0x10
			public System.Reflection.FieldInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _GetPortHandler_b__0(); // 0x000000018CAECB08-0x000000018CAECB58
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76644
		{
			// Fields
			public PureReflectedExtractorNode __4__this; // 0x10
			public MethodInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _GetPortHandler_b__0(); // 0x000000018CAECCE4-0x000000018CAECD7C
		}
	
		// Constructors
		public PureReflectedExtractorNode(); // 0x0000000186805BA0-0x0000000186805BB0
		static PureReflectedExtractorNode(); // 0x000000018CAE31F0-0x000000018CAE3254
	
		// Methods
		protected override bool InitInternal(); // 0x000000018CAE2FEC-0x000000018CAE3010
		private ValueHandlerObject GetPortHandler(System.Reflection.FieldInfo info); // 0x000000018CAE2F1C-0x000000018CAE2FEC
		private ValueHandlerObject GetPortHandler(MethodInfo info); // 0x000000018CAE2E4C-0x000000018CAE2F1C
		public override void RegisterPorts(FlowNode node); // 0x000000018CAE3010-0x000000018CAE31F0
	}

	public abstract class BaseReflectedFieldNode // TypeDefIndex: 76646
	{
		// Fields
		[CompilerGenerated]
		private static Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode; // 0x00
		protected System.Reflection.FieldInfo fieldInfo; // 0x10
		protected ParamDef instanceDef; // 0x18
		protected ParamDef resultDef; // 0x50
	
		// Events
		protected static event Func<System.Reflection.FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode {
			add; // 0x000000018CADCE78-0x000000018CADCF14
			remove; // 0x000000018CADCF14-0x000000018CADCFB0
		}
	
		// Constructors
		protected BaseReflectedFieldNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static BaseReflectedFieldNode GetFieldNode(System.Reflection.FieldInfo targetField); // 0x000000018CADCB8C-0x000000018CADCD14
		protected bool Init(System.Reflection.FieldInfo field, ParametresDef parametres); // 0x000000018CADCD14-0x000000018CADCE78
		protected abstract bool InitInternal(System.Reflection.FieldInfo field);
		public abstract void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	public class PureReflectedFieldNode : BaseReflectedFieldNode // TypeDefIndex: 76648
	{
		// Fields
		private ValueInput instanceInput; // 0x88
		private ValueInput valueInput; // 0x90
		private object instanceObject; // 0x98
		private object valueObject; // 0xA0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 76647
		{
			// Fields
			public FlowOutput output; // 0x10
			public PureReflectedFieldNode __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__2(Flow flow); // 0x000000018CAED85C-0x000000018CAED8C0
		}
	
		// Constructors
		public PureReflectedFieldNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override bool InitInternal(System.Reflection.FieldInfo method); // 0x000000018CAE32C4-0x000000018CAE3310
		private void SetValue(); // 0x000000018CAE3668-0x000000018CAE36FC
		private void GetValue(); // 0x000000018CAE3254-0x000000018CAE32C4
		public override void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode); // 0x000000018CAE3310-0x000000018CAE3668
		[CompilerGenerated]
		private object _RegisterPorts_b__7_0(); // 0x0000000187232C70-0x0000000187232C80
		[CompilerGenerated]
		private object _RegisterPorts_b__7_1(); // 0x000000018CAE36FC-0x000000018CAE371C
	}

	public abstract class BaseReflectedMethodNode // TypeDefIndex: 76649
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
			add; // 0x000000018CADD328-0x000000018CADD3C4
			remove; // 0x000000018CADD3C4-0x000000018CADD460
		}
	
		// Constructors
		protected BaseReflectedMethodNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static BaseReflectedMethodNode GetMethodNode(MethodInfo targetMethod, ReflectedMethodRegistrationOptions options); // 0x000000018CADCFB0-0x000000018CADD164
		protected bool Init(MethodInfo method, ParametresDef parametres); // 0x000000018CADD164-0x000000018CADD328
		protected abstract bool InitInternal(MethodInfo method);
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);
	}

	public class PureReflectedMethodNode : BaseReflectedMethodNode // TypeDefIndex: 76653
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
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 76650
		{
			// Fields
			public bool callable; // 0x10
			public PureReflectedMethodNode __4__this; // 0x18
			public int idx; // 0x20
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterOutput_b__0(); // 0x000000018CAEC04C-0x000000018CAEC0A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 76651
		{
			// Fields
			public PureReflectedMethodNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CAEC148-0x000000018CAEC168
			internal object _RegisterPorts_b__1(); // 0x000000018CAEC168-0x000000018CAEC1A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1 // TypeDefIndex: 76652
		{
			// Fields
			public FlowOutput output; // 0x10
			public __c__DisplayClass12_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass12_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__2(Flow flow); // 0x000000018CAEC1A4-0x000000018CAEC210
		}
	
		// Constructors
		public PureReflectedMethodNode(); // 0x0000000187254100-0x0000000187254110
	
		// Methods
		protected override bool InitInternal(MethodInfo method); // 0x000000018CAE38F0-0x000000018CAE3A80
		private void Call(); // 0x000000018CAE371C-0x000000018CAE38F0
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx); // 0x000000018CAE3C38-0x000000018CAE3D3C
		private void RegisterInput(FlowNode node, ParamDef def, int idx); // 0x000000018CAE3A80-0x000000018CAE3C38
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options); // 0x000000018CAE3D3C-0x000000018CAE413C
	}

	public class ReflectedConstructorNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 76654
	{
		// Fields
		[SerializeField]
		private SerializedConstructorInfo _constructor; // 0xB8
		[CompilerGenerated]
		private BaseReflectedConstructorNode _reflectedConstructorNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedConstructorNode reflectedConstructorNode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		private ConstructorInfo constructor { get; } // 0x000000018CAE4E50-0x000000018CAE4E64 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get; } // 0x0000000187232C80-0x0000000187232C90 
		public override string name { get; } // 0x000000018CAE4E64-0x000000018CAE4F80 
	
		// Constructors
		public ReflectedConstructorNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null); // 0x000000018CAE4DE8-0x000000018CAE4E50
		private void SetConstructor(ConstructorInfo newConstructor); // 0x000000018CAE4D54-0x000000018CAE4DE8
		protected override void RegisterPorts(); // 0x000000018CAE4C84-0x000000018CAE4D54
	}

	[Description("Chose and expose any number of fields or properties of the type. If you only require a single field / property, it\'s better to get that field / property directly without an Extractor.")]
	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public class ReflectedExtractorNodeWrapper<T> : FlowNode // TypeDefIndex: 76655
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

	internal class ReflectedFieldNodeWrapper_0 // TypeDefIndex: 76656
	{
		// Fields
		[SerializeField]
		public string fieldName; // 0x10
		[SerializeField]
		public System.Type targetType; // 0x18
	
		// Constructors
		public ReflectedFieldNodeWrapper_0(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[DoNotList]
	[fsMigrateVersions(new System.Type[1] {typeof(ReflectedFieldNodeWrapper_0) })]
	[Icon("", false, "GetRuntimeIconType")]
	public class ReflectedFieldNodeWrapper : FlowNode, IReflectedWrapper, IMigratable<ReflectedFieldNodeWrapper_0> // TypeDefIndex: 76658
	{
		// Fields
		[SerializeField]
		private SerializedFieldInfo _field; // 0xB0
		[SerializeField]
		private AccessMode accessMode; // 0xB8
		[CompilerGenerated]
		private BaseReflectedFieldNode _reflectedFieldNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedFieldNode reflectedFieldNode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		private System.Reflection.FieldInfo field { get; } // 0x000000018B71515C-0x000000018B715170 
		public override string name { get; } // 0x000000018CB03740-0x000000018CB039C0 
	
		// Nested types
		public enum AccessMode // TypeDefIndex: 76657
		{
			GetField = 0,
			SetField = 1
		}
	
		// Constructors
		public ReflectedFieldNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		void IMigratable<ReflectedFieldNodeWrapper_0>.Migrate(ReflectedFieldNodeWrapper_0 model); // 0x000000018CB0349C-0x000000018CB0355C
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F90-0x0000000187232FA0
		private System.Type GetRuntimeIconType(); // 0x000000018CB0344C-0x000000018CB0349C
		public void SetField(System.Reflection.FieldInfo newField, AccessMode mode, object instance = null); // 0x000000018CB035F8-0x000000018CB03740
		protected override void RegisterPorts(); // 0x000000018CB0355C-0x000000018CB035F8
	}

	[DoNotList]
	[Icon("", false, "GetRuntimeIconType")]
	public abstract class ReflectedMethodBaseNodeWrapper : FlowNode, IReflectedWrapper // TypeDefIndex: 76659
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
		private MethodBase method { get; } // 0x000000018CB03C00-0x000000018CB03C6C 
		public bool callable { get; set; } // 0x000000018225E0F0-0x000000018225E100 0x000000018CB03C6C-0x000000018CB03C84
		public bool exposeParams { get; set; } // 0x0000000187235C00-0x0000000187235C10 0x000000018CB03C84-0x000000018CB03CB0
		public int exposedParamsCount { get; set; } // 0x00000001872361F0-0x0000000187236200 0x000000018CB03CB0-0x000000018CB03CD4
	
		// Constructors
		protected ReflectedMethodBaseNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018CB03A40-0x000000018CB03A50
		public System.Type GetRuntimeIconType(); // 0x000000018CB039FC-0x000000018CB03A40
		public abstract void SetMethodBase(MethodBase newMethod, object instance = null);
		public void SetDefaultParameterValues(MethodBase newMethod); // 0x000000018CB03A50-0x000000018CB03B60
		public void SetDropInstanceReference(MethodBase newMethod, object instance = null); // 0x000000018CB03B60-0x000000018CB03C00
	}

	public class ReflectedMethodNodeWrapper : ReflectedMethodBaseNodeWrapper // TypeDefIndex: 76660
	{
		// Fields
		[SerializeField]
		private SerializedMethodInfo _method; // 0xB8
		[CompilerGenerated]
		private BaseReflectedMethodNode _reflectedMethodNode_k__BackingField; // 0xC0
	
		// Properties
		private BaseReflectedMethodNode reflectedMethodNode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		private new MethodInfo method { get; } // 0x000000018CB04150-0x000000018CB04164 
		protected override ISerializedMethodBaseInfo serializedMethodBase { get; } // 0x0000000187232C80-0x0000000187232C90 
		public override string name { get; } // 0x000000018CB04164-0x000000018CB04438 
	
		// Constructors
		public ReflectedMethodNodeWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void SetMethodBase(MethodBase newMethod, object instance = null); // 0x000000018CB03F18-0x000000018CB03F90
		private void SetMethod(MethodInfo newMethod, object instance = null); // 0x000000018CB03F90-0x000000018CB04150
		public override void OnPortConnected(Port port, Port otherPort); // 0x000000018CB03D24-0x000000018CB03E88
		public override System.Type GetNodeWildDefinitionType(); // 0x000000018CB03CD4-0x000000018CB03D24
		protected override void RegisterPorts(); // 0x000000018CB03E88-0x000000018CB03F18
	}

	public struct ReflectedMethodRegistrationOptions // TypeDefIndex: 76661
	{
		// Fields
		public bool callable; // 0x00
		public bool exposeParams; // 0x01
		public int exposedParamsCount; // 0x04
	}

	[Description("Encapsulates a SubGraph able to control independently.")]
	public abstract class FlowNestedBase<T> : FlowNodeNested<T>, IDropedReferenceNode, IUpdatable // TypeDefIndex: 76663
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
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 76662
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
	public class FlowNestedFlow : FlowNestedBase<FlowScript> // TypeDefIndex: 76664
	{
		// Constructors
		public FlowNestedFlow(); // 0x000000018CAFEE90-0x000000018CAFEECC
	}

	[Category("Variables/New")]
	[Description("Create a collection of <T> objects")]
	[ContextDefinedInputs(new System.Type[1] {typeof(Wild) })]
	[ContextDefinedOutputs(new System.Type[1] {typeof(List<T>) })]
	public class CreateCollection<T> : FlowNode // TypeDefIndex: 76667
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
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76665
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
		private sealed class __c // TypeDefIndex: 76666
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
	public class CreateDictionary<T> : FlowNode // TypeDefIndex: 76671
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
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76668
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
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 76669
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
		private sealed class __c // TypeDefIndex: 76670
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
	public class GetOtherVariable<T> : FlowNode // TypeDefIndex: 76673
	{
		// Properties
		public override string name { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76672
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
	public class GetVariable<T> : ParameterVariableNode // TypeDefIndex: 76674
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
	public abstract class RelayValueInputBase : FlowNode // TypeDefIndex: 76675
	{
		// Properties
		public abstract System.Type relayType { get; }
	
		// Constructors
		protected RelayValueInputBase(); // 0x0000000186B55770-0x0000000186B55780
	}

	public class RelayValueInput<T> : RelayValueInputBase, IEditorMenuCallbackReceiver // TypeDefIndex: 76677
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
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 76676
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
	public abstract class RelayValueOutputBase : FlowNode // TypeDefIndex: 76678
	{
		// Constructors
		protected RelayValueOutputBase(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public abstract void SetSource(RelayValueInputBase source);
	}

	public class RelayValueOutput<T> : RelayValueOutputBase // TypeDefIndex: 76679
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
	public class NullObject : FlowNode // TypeDefIndex: 76681
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76680
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueHandler<object> __9__0_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB05FF0-0x000000018CB06054
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0_0(); // 0x0000000185829EC0-0x0000000185829ED0
		}
	
		// Constructors
		public NullObject(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CB02198-0x000000018CB022DC
	}

	[Category("Variables")]
	[Description("Returns the Owner GameObject")]
	[ContextDefinedOutputs(new System.Type[1] {typeof(GameObject) })]
	[Name("Self", 100)]
	public class OwnerVariable : FlowNode // TypeDefIndex: 76682
	{
		// Properties
		public override string name { get; } // 0x000000018CB02414-0x000000018CB02440 
	
		// Constructors
		public OwnerVariable(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CB022DC-0x000000018CB02394
		[CompilerGenerated]
		private GameObject _RegisterPorts_b__2_0(); // 0x000000018CB02394-0x000000018CB02414
	}

	public abstract class ParameterVariableNode : FlowNode // TypeDefIndex: 76683
	{
		// Properties
		public abstract BBParameter parameter { get; }
	
		// Constructors
		protected ParameterVariableNode(); // 0x0000000186B55770-0x0000000186B55780
	}

	[Category("Variables/Blackboard")]
	[Description("Use this to set a variable value of blackboards other than the one this flowscript is using")]
	[ContextDefinedInputs(new System.Type[2] {typeof(NodeCanvas.Framework.Blackboard), typeof(Wild) })]
	[Name("Set Other Of Type", 0)]
	public class SetOtherVariable<T> : FlowNode // TypeDefIndex: 76685
	{
		// Fields
		public OperationMethod operation;
		private ValueInput<string> varName;
	
		// Properties
		public override string name { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76684
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
	public class SetVariable<T> : ParameterVariableNode // TypeDefIndex: 76687
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
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 76686
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
	public abstract class CodeEventBase : EventNode<Transform> // TypeDefIndex: 76688
	{
		// Fields
		[SerializeField]
		protected string eventName; // 0xB8
		[SerializeField]
		protected System.Type targetType; // 0xC0
		protected Component targetComponent; // 0xC8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018CAFDF6C-0x000000018CAFDFFC 
	
		// Constructors
		protected CodeEventBase(); // 0x000000018CAFDF38-0x000000018CAFDF6C
	
		// Methods
		public void SetEvent(EventInfo e, object instace = null); // 0x000000018CAFDEA4-0x000000018CAFDF38
		public override void OnPostGraphStarted(); // 0x000000018CAFDD14-0x000000018CAFDEA4
	}

	[Obsolete]
	public class CodeEvent : CodeEventBase // TypeDefIndex: 76689
	{
		// Fields
		private FlowOutput o; // 0xD0
		private Action pointer; // 0xD8
	
		// Constructors
		public CodeEvent(); // 0x000000018B918478-0x000000018B918480
	
		// Methods
		public override void OnPostGraphStarted(); // 0x000000018CAFE10C-0x000000018CAFE1C0
		public override void OnGraphStoped(); // 0x000000018CAFE04C-0x000000018CAFE10C
		protected override void RegisterPorts(); // 0x000000018CAFE1C0-0x000000018CAFE228
		private void Call(); // 0x000000018CAFDFFC-0x000000018CAFE04C
	}

	[Obsolete]
	public class CodeEvent<T> : CodeEventBase // TypeDefIndex: 76690
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
	public class NewGameObject : CallableFunctionNode<GameObject, string, Vector3, Quaternion> // TypeDefIndex: 76691
	{
		// Constructors
		public NewGameObject(); // 0x000000018CB02028-0x000000018CB02050
	
		// Methods
		public override GameObject Invoke(string name, Vector3 position, Quaternion rotation); // 0x000000018CB01F54-0x000000018CB02028
	}

	[Obsolete]
	public class NewVector2 : PureFunctionNode<Vector2, float, float> // TypeDefIndex: 76692
	{
		// Constructors
		public NewVector2(); // 0x000000018CB02120-0x000000018CB02148
	
		// Methods
		public override Vector2 Invoke(float x, float y); // 0x0000000187254280-0x0000000187254290
	}

	[Obsolete]
	public class NewVector3 : PureFunctionNode<Vector3, float, float, float> // TypeDefIndex: 76693
	{
		// Constructors
		public NewVector3(); // 0x000000018CB02148-0x000000018CB02170
	
		// Methods
		public override Vector3 Invoke(float x, float y, float z); // 0x0000000187254290-0x00000001872542B0
	}

	[Obsolete]
	public class NewVector4 : PureFunctionNode<Vector4, float, float, float, float> // TypeDefIndex: 76694
	{
		// Constructors
		public NewVector4(); // 0x000000018CB02170-0x000000018CB02198
	
		// Methods
		public override Vector4 Invoke(float x, float y, float z, float w); // 0x0000000187254250-0x0000000187254280
	}

	[Obsolete]
	public class NewQuaternion : PureFunctionNode<Quaternion, float, float, float, float> // TypeDefIndex: 76695
	{
		// Constructors
		public NewQuaternion(); // 0x000000018CB02050-0x000000018CB02078
	
		// Methods
		public override Quaternion Invoke(float x, float y, float z, float w); // 0x0000000187254250-0x0000000187254280
	}

	[Obsolete]
	public class NewColor : PureFunctionNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 76696
	{
		// Constructors
		public NewColor(); // 0x000000018CB01F2C-0x000000018CB01F54
	
		// Methods
		public override UnityEngine.Color Invoke(float r, float g, float b, float a = 1f /* Metadata: 0x02629D2A */); // 0x0000000187254250-0x0000000187254280
	}

	[Obsolete]
	public class NewBounds : PureFunctionNode<Bounds, Vector3, Vector3> // TypeDefIndex: 76697
	{
		// Constructors
		public NewBounds(); // 0x000000018CB01F04-0x000000018CB01F2C
	
		// Methods
		public override Bounds Invoke(Vector3 center, Vector3 size); // 0x000000018CB01EAC-0x000000018CB01F04
	}

	[Obsolete]
	public class NewRect : PureFunctionNode<Rect, float, float, float, float> // TypeDefIndex: 76698
	{
		// Constructors
		public NewRect(); // 0x000000018CB020F8-0x000000018CB02120
	
		// Methods
		public override Rect Invoke(float left, float top, float width, float height); // 0x0000000187254250-0x0000000187254280
	}

	[Obsolete]
	public class NewRay : PureFunctionNode<Ray, Vector3, Vector3> // TypeDefIndex: 76699
	{
		// Constructors
		public NewRay(); // 0x000000018CB020D0-0x000000018CB020F8
	
		// Methods
		public override Ray Invoke(Vector3 origin, Vector3 direction); // 0x000000018CB02078-0x000000018CB020D0
	}

	[Obsolete]
	public class ConvertTo<T> : PureFunctionNode<T, IConvertible> // TypeDefIndex: 76700
		where T : IConvertible
	{
		// Constructors
		public ConvertTo();
	
		// Methods
		public override T Invoke(IConvertible obj);
	}

	[Obsolete]
	public class CastTo<T> : PureFunctionNode<T, object> // TypeDefIndex: 76701
	{
		// Constructors
		public CastTo();
	
		// Methods
		public override T Invoke(object obj);
	}

	[Obsolete]
	public class ToArray<T> : PureFunctionNode<T[], IList<T>> // TypeDefIndex: 76702
	{
		// Constructors
		public ToArray();
	
		// Methods
		public override T[] Invoke(IList<T> list);
	}

	[Obsolete]
	public class ToList<T> : PureFunctionNode<List<T>, IList<T>> // TypeDefIndex: 76703
	{
		// Constructors
		public ToList();
	
		// Methods
		public override List<T> Invoke(IList<T> list);
	}

	[Obsolete("Use \'IReferencedObjectWrapper\' along with \'ReferencedObjectTypeAttribute\'")]
	public abstract class CustomObjectWrapper : FlowNode // TypeDefIndex: 76704
	{
		// Constructors
		protected CustomObjectWrapper(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public abstract void SetTarget(UnityEngine.Object target);
	}

	[Icon("", false, "GetRuntimeIconType")]
	[Obsolete("Use \'IReferencedObjectWrapper\' along with \'ReferencedObjectTypeAttribute\'")]
	public abstract class CustomObjectWrapper<T> : CustomObjectWrapper // TypeDefIndex: 76705
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
	public class ExtractVector2 : ExtractorNode<Vector2, float, float> // TypeDefIndex: 76706
	{
		// Constructors
		public ExtractVector2(); // 0x000000018CAFEA08-0x000000018CAFEA30
	
		// Methods
		public override void Invoke(Vector2 vector, out float x, out float y); // 0x0000000187254210-0x0000000187254230
	}

	[Obsolete]
	public class ExtractVector3 : ExtractorNode<Vector3, float, float, float> // TypeDefIndex: 76707
	{
		// Constructors
		public ExtractVector3(); // 0x000000018CAFEA30-0x000000018CAFEA58
	
		// Methods
		public override void Invoke(Vector3 vector, out float x, out float y, out float z); // 0x0000000187254230-0x0000000187254250
	}

	[Obsolete]
	public class ExtractVector4 : ExtractorNode<Vector4, float, float, float, float> // TypeDefIndex: 76708
	{
		// Constructors
		public ExtractVector4(); // 0x000000018CAFEA58-0x000000018CAFEA80
	
		// Methods
		public override void Invoke(Vector4 vector, out float x, out float y, out float z, out float w); // 0x0000000187254190-0x00000001872541B0
	}

	[Obsolete]
	public class ExtractQuaternion : ExtractorNode<Quaternion, float, float, float, float, Vector3> // TypeDefIndex: 76709
	{
		// Constructors
		public ExtractQuaternion(); // 0x000000018CAFE700-0x000000018CAFE728
	
		// Methods
		public override void Invoke(Quaternion quaternion, out float x, out float y, out float z, out float w, out Vector3 eulerAngles); // 0x000000018CAFE6B8-0x000000018CAFE700
	}

	[Obsolete]
	public class ExtractRect : ExtractorNode<Rect, Vector2, float, float, float, float> // TypeDefIndex: 76710
	{
		// Constructors
		public ExtractRect(); // 0x000000018CAFE9E0-0x000000018CAFEA08
	
		// Methods
		public override void Invoke(Rect rect, out Vector2 center, out float xMin, out float xMax, out float yMin, out float yMax); // 0x000000018CAFE97C-0x000000018CAFE9E0
	}

	[Obsolete]
	public class ExtractColor : ExtractorNode<UnityEngine.Color, float, float, float, float> // TypeDefIndex: 76711
	{
		// Constructors
		public ExtractColor(); // 0x000000018CAFE558-0x000000018CAFE580
	
		// Methods
		public override void Invoke(UnityEngine.Color color, out float r, out float g, out float b, out float a); // 0x0000000187254190-0x00000001872541B0
	}

	[Obsolete]
	public class ExtractRaycastHit : ExtractorNode<RaycastHit, GameObject, float, Vector3, Vector3> // TypeDefIndex: 76712
	{
		// Constructors
		public ExtractRaycastHit(); // 0x000000018CAFE954-0x000000018CAFE97C
	
		// Methods
		public override void Invoke(RaycastHit hit, out GameObject gameObject, out float distance, out Vector3 normal, out Vector3 point); // 0x000000018CAFE898-0x000000018CAFE954
	}

	[Obsolete]
	public class ExtractRaycastHit2D : ExtractorNode<RaycastHit2D, GameObject, float, float, Vector3, Vector3> // TypeDefIndex: 76713
	{
		// Constructors
		public ExtractRaycastHit2D(); // 0x000000018CAFE870-0x000000018CAFE898
	
		// Methods
		public override void Invoke(RaycastHit2D hit, out GameObject gameObject, out float distance, out float fraction, out Vector3 normal, out Vector3 point); // 0x000000018CAFE750-0x000000018CAFE870
	}

	[Obsolete]
	public class ExtractRay : ExtractorNode<Ray, Vector3, Vector3> // TypeDefIndex: 76714
	{
		// Constructors
		public ExtractRay(); // 0x000000018CAFE728-0x000000018CAFE750
	
		// Methods
		public override void Invoke(Ray ray, out Vector3 origin, out Vector3 direction); // 0x00000001872541E0-0x0000000187254210
	}

	[Obsolete]
	public class ExtractBounds : ExtractorNode<Bounds, Vector3, Vector3, Vector3, Vector3, Vector3> // TypeDefIndex: 76715
	{
		// Constructors
		public ExtractBounds(); // 0x000000018CAFE368-0x000000018CAFE390
	
		// Methods
		public override void Invoke(Bounds bounds, out Vector3 center, out Vector3 extents, out Vector3 max, out Vector3 min, out Vector3 size); // 0x000000018CAFE2D0-0x000000018CAFE368
	}

	[Obsolete]
	public class ExtractCollision : ExtractorNode<UnityEngine.Collision, ContactPoint[], ContactPoint, GameObject, Vector3> // TypeDefIndex: 76716
	{
		// Constructors
		public ExtractCollision(); // 0x000000018CAFE530-0x000000018CAFE558
	
		// Methods
		public override void Invoke(UnityEngine.Collision collision, out ContactPoint[] contacts, out ContactPoint firstContact, out GameObject gameObject, out Vector3 velocity); // 0x000000018CAFE47C-0x000000018CAFE530
	}

	[Obsolete]
	public class ExtractCollision2D : ExtractorNode<Collision2D, ContactPoint2D[], ContactPoint2D, GameObject, Vector2> // TypeDefIndex: 76717
	{
		// Constructors
		public ExtractCollision2D(); // 0x000000018CAFE454-0x000000018CAFE47C
	
		// Methods
		public override void Invoke(Collision2D collision, out ContactPoint2D[] contacts, out ContactPoint2D firstContact, out GameObject gameObject, out Vector2 velocity); // 0x000000018CAFE390-0x000000018CAFE454
	}

	[Obsolete]
	public class ExtractContactPoint : ExtractorNode<ContactPoint, Vector3, Vector3, Collider, Collider> // TypeDefIndex: 76718
	{
		// Constructors
		public ExtractContactPoint(); // 0x000000018CAFE668-0x000000018CAFE690
	
		// Methods
		public override void Invoke(ContactPoint contactPoint, out Vector3 normal, out Vector3 point, out Collider colliderA, out Collider colliderB); // 0x000000018CAFE608-0x000000018CAFE668
	}

	[Obsolete]
	public class ExtractContactPoint2D : ExtractorNode<ContactPoint2D, Vector2, Vector2, Collider2D, Collider2D> // TypeDefIndex: 76719
	{
		// Constructors
		public ExtractContactPoint2D(); // 0x000000018CAFE5E0-0x000000018CAFE608
	
		// Methods
		public override void Invoke(ContactPoint2D contactPoint, out Vector2 normal, out Vector2 point, out Collider2D colliderA, out Collider2D colliderB); // 0x000000018CAFE580-0x000000018CAFE5E0
	}

	[Obsolete]
	public class ExtractAnimationCurve : ExtractorNode<AnimationCurve, Keyframe[], float, UnityEngine.WrapMode, UnityEngine.WrapMode> // TypeDefIndex: 76720
	{
		// Constructors
		public ExtractAnimationCurve(); // 0x000000018CAFE2A8-0x000000018CAFE2D0
	
		// Methods
		public override void Invoke(AnimationCurve curve, out Keyframe[] keys, out float length, out UnityEngine.WrapMode postWrapMode, out UnityEngine.WrapMode preWrapMode); // 0x000000018CAFE228-0x000000018CAFE2A8
	}

	[Obsolete]
	public class ExtractKeyFrame : ExtractorNode<Keyframe, float, float, float, float> // TypeDefIndex: 76721
	{
		// Constructors
		public ExtractKeyFrame(); // 0x000000018CAFE690-0x000000018CAFE6B8
	
		// Methods
		public override void Invoke(Keyframe key, out float inTangent, out float outTangent, out float time, out float value); // 0x00000001872541B0-0x00000001872541E0
	}

	[Obsolete]
	public class SwitchValue<T> : PureFunctionNode<T, bool, T, T> // TypeDefIndex: 76722
	{
		// Constructors
		public SwitchValue();
	
		// Methods
		public override T Invoke(bool condition, T isTrue, T isFalse);
	}

	[Obsolete]
	public class PickValue<T> : PureFunctionNode<T, int, IList<T>> // TypeDefIndex: 76723
	{
		// Constructors
		public PickValue();
	
		// Methods
		public override T Invoke(int index, IList<T> values);
	}

	[Obsolete]
	public abstract class StaticCodeEventBase : EventNode // TypeDefIndex: 76724
	{
		// Fields
		[SerializeField]
		protected string eventName; // 0xB0
		[SerializeField]
		protected System.Type targetType; // 0xB8
	
		// Properties
		protected EventInfo eventInfo { get; } // 0x000000018CB04EF8-0x000000018CB04F88 
	
		// Constructors
		protected StaticCodeEventBase(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public void SetEvent(EventInfo e); // 0x000000018CB04E64-0x000000018CB04EF8
		public override void OnGraphStarted(); // 0x000000018CB04DB0-0x000000018CB04E64
	}

	[Obsolete]
	public class StaticCodeEvent : StaticCodeEventBase // TypeDefIndex: 76725
	{
		// Fields
		private FlowOutput o; // 0xC0
		private Action pointer; // 0xC8
	
		// Constructors
		public StaticCodeEvent(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB04FD8-0x000000018CB05088
		public override void OnGraphStoped(); // 0x000000018B84C028-0x000000018B84C08C
		private void Call(); // 0x000000018CB04F88-0x000000018CB04FD8
		protected override void RegisterPorts(); // 0x000000018CB05088-0x000000018CB050F0
	}

	[Obsolete]
	public class StaticCodeEvent<T> : StaticCodeEventBase // TypeDefIndex: 76726
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
	public class FlowNestedBT : FlowNestedBase<BehaviourTree> // TypeDefIndex: 76727
	{
		// Constructors
		public FlowNestedBT(); // 0x000000018CAFEB98-0x000000018CAFEBD4
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAFEA80-0x000000018CAFEB54
		[CompilerGenerated]
		private NodeCanvas.Framework.Status _RegisterPorts_b__0_0(); // 0x000000018CAFEB54-0x000000018CAFEB98
	}

	[DropReferenceType(typeof(FSM))]
	[Name("Sub FSM", 0)]
	public class FlowNestedFSM : FlowNestedBase<FSM> // TypeDefIndex: 76728
	{
		// Constructors
		public FlowNestedFSM(); // 0x000000018CAFEE54-0x000000018CAFEE90
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAFED3C-0x000000018CAFEE10
		[CompilerGenerated]
		private IState _RegisterPorts_b__0_0(); // 0x000000018CAFEE10-0x000000018CAFEE54
	}

	[DropReferenceType(typeof(DialogueTree))]
	[Name("Sub Dialogue", 0)]
	public class FlowNestedDT : FlowNestedBase<DialogueTree> // TypeDefIndex: 76729
	{
		// Constructors
		public FlowNestedDT(); // 0x000000018CAFED00-0x000000018CAFED3C
	
		// Methods
		protected override void RegisterPorts(); // 0x000000018CAFEBD4-0x000000018CAFECA8
		[CompilerGenerated]
		private IDialogueActor _RegisterPorts_b__0_0(); // 0x000000018CAFECA8-0x000000018CAFED00
	}

	[Description("Execute an encapsulated action without exposing any value ports")]
	public class TaskAction : FlowNode, ITaskAssignable<ActionTask> // TypeDefIndex: 76731
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0xB0
		private FlowOutput onFinish; // 0xB8
		private Coroutine coroutine; // 0xC0
	
		// Properties
		public override string name { get; } // 0x000000018CB054BC-0x000000018CB0550C 
		public ActionTask action { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018CB0550C-0x000000018CB05544
		NodeCanvas.Framework.Task ITaskAssignable.task { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018CB05240-0x000000018CB05294
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DoUpdate_d__15 : IEnumerator<object> // TypeDefIndex: 76730
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TaskAction __4__this; // 0x20
			public Flow f; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoUpdate_d__15(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB05774-0x000000018CB058BC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB058BC-0x000000018CB05908
		}
	
		// Constructors
		public TaskAction(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB052B0-0x000000018CB052C8
		public override void OnGraphStoped(); // 0x000000018CB052C8-0x000000018CB05328
		public override void OnGraphPaused(); // 0x000000018CB05294-0x000000018CB052B0
		protected override void RegisterPorts(); // 0x000000018CB05328-0x000000018CB0540C
		[IteratorStateMachine(typeof(_DoUpdate_d__15))]
		private IEnumerator DoUpdate(Flow f); // 0x000000018CB051B0-0x000000018CB05240
		[CompilerGenerated]
		private void _RegisterPorts_b__14_0(Flow f); // 0x000000018CB0540C-0x000000018CB054BC
	}

	[Description("Returns an encapsulated condition check without exposing any value ports other than the boolean check")]
	public class TaskCondition : FlowNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 76732
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018CB05724-0x000000018CB05774 
		public ConditionTask condition { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x0000000185017130-0x0000000185017150
		NodeCanvas.Framework.Task ITaskAssignable.task { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018CB05544-0x000000018CB0559C
	
		// Constructors
		public TaskCondition(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB0559C-0x000000018CB055F4
		public override void OnGraphStoped(); // 0x000000018CB055F4-0x000000018CB05610
		protected override void RegisterPorts(); // 0x000000018CB05610-0x000000018CB056C8
		[CompilerGenerated]
		private bool _RegisterPorts_b__11_0(); // 0x000000018CB056C8-0x000000018CB05724
	}
}

namespace FlowCanvas.Nodes.Legacy
{
	[Obsolete]
	public abstract class ReflectedFieldNode // TypeDefIndex: 76733
	{
		// Constructors
		protected ReflectedFieldNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ReflectedFieldNode Create(System.Reflection.FieldInfo field); // 0x000000018CB039C0-0x000000018CB039FC
		public abstract void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode);
	}

	[Obsolete]
	public sealed class PureReflectedFieldNode : ReflectedFieldNode // TypeDefIndex: 76738
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 76734
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1 // TypeDefIndex: 76735
		{
			// Fields
			public object constantValue; // 0x10
	
			// Constructors
			public __c__DisplayClass0_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x00000001829260F0-0x0000000182926100
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_2 // TypeDefIndex: 76736
		{
			// Fields
			public ValueInput instanceInput; // 0x10
			public __c__DisplayClass0_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass0_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__1(); // 0x000000018CB0591C-0x000000018CB05960
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_3 // TypeDefIndex: 76737
		{
			// Fields
			public object instance; // 0x10
			public ValueInput instanceInput; // 0x18
			public ValueInput valueInput; // 0x20
			public FlowOutput flowOut; // 0x28
			public __c__DisplayClass0_0 CS___8__locals2; // 0x30
	
			// Constructors
			public __c__DisplayClass0_3(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__2(); // 0x00000001829260F0-0x0000000182926100
			internal void _RegisterPorts_b__3(Flow f); // 0x000000018CB05960-0x000000018CB05A20
		}
	
		// Constructors
		public PureReflectedFieldNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void RegisterPorts(FlowNode node, System.Reflection.FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode); // 0x000000018CB02440-0x000000018CB028CC
	}

	[Obsolete]
	public abstract class ReflectedMethodNode // TypeDefIndex: 76741
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 76739
		{
			// Fields
			public ParameterInfo[] parameters; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Create_b__0(ParameterInfo p); // 0x000000018CB05A20-0x000000018CB05A98
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76740
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, System.Type> __9__2_0; // 0x08
			public static Func<ParameterInfo, System.Type> __9__2_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018CB05F8C-0x000000018CB05FF0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Type _TryCreateJit_b__2_0(ParameterInfo p); // 0x0000000188E4BE2C-0x0000000188E4BE44
			internal System.Type _TryCreateJit_b__2_1(ParameterInfo p); // 0x0000000188E4BE2C-0x0000000188E4BE44
		}
	
		// Constructors
		public ReflectedMethodNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ReflectedMethodNode Create(MethodInfo method); // 0x000000018CB04438-0x000000018CB04604
		private static ReflectedMethodNode TryCreateJit(MethodInfo method); // 0x000000018CB04714-0x000000018CB04DB0
		public string GetName(MethodInfo method, int i); // 0x000000018CB04604-0x000000018CB04714
		public abstract void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}

	[Obsolete]
	public sealed class PureReflectedMethodNode : ReflectedMethodNode // TypeDefIndex: 76745
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
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 76742
		{
			// Fields
			public PureReflectedMethodNode __4__this; // 0x10
			public ReflectedMethodRegistrationOptions options; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__0(); // 0x000000018CB05E68-0x000000018CB05E84
			internal object _RegisterPorts_b__1(); // 0x000000018CB05E84-0x000000018CB05EBC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_1 // TypeDefIndex: 76743
		{
			// Fields
			public FlowOutput o; // 0x10
			public __c__DisplayClass8_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass8_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__2(Flow f); // 0x000000018CB05EBC-0x000000018CB05F28
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_2 // TypeDefIndex: 76744
		{
			// Fields
			public int i; // 0x10
			public __c__DisplayClass8_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass8_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _RegisterPorts_b__3(); // 0x000000018CB05F28-0x000000018CB05F8C
		}
	
		// Constructors
		public PureReflectedMethodNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options); // 0x000000018CB02B38-0x000000018CB032C0
		private object CallMethod(); // 0x000000018CB028CC-0x000000018CB02B38
	}

	[Obsolete]
	public sealed class ReflectedActionNode : ReflectedMethodNode // TypeDefIndex: 76747
	{
		// Fields
		private ActionCall call; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 76746
		{
			// Fields
			public ReflectedActionNode __4__this; // 0x10
			public FlowOutput o; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterPorts_b__0(Flow f); // 0x000000018CB05CBC-0x000000018CB05D20
		}
	
		// Constructors
		public ReflectedActionNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private void Call(); // 0x000000018CB032C0-0x000000018CB032E8
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options); // 0x000000018CB032E8-0x000000018CB0344C
	}

	[Obsolete]
	public sealed class ReflectedActionNode<T1> : ReflectedMethodNode // TypeDefIndex: 76749
	{
		// Fields
		private ActionCall<T1> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76748
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
	public sealed class ReflectedActionNode<T1, T2> : ReflectedMethodNode // TypeDefIndex: 76751
	{
		// Fields
		private ActionCall<T1, T2> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76750
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
	public sealed class ReflectedActionNode<T1, T2, T3> : ReflectedMethodNode // TypeDefIndex: 76753
	{
		// Fields
		private ActionCall<T1, T2, T3> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76752
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
	public sealed class ReflectedActionNode<T1, T2, T3, T4> : ReflectedMethodNode // TypeDefIndex: 76755
	{
		// Fields
		private ActionCall<T1, T2, T3, T4> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76754
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
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5> : ReflectedMethodNode // TypeDefIndex: 76757
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76756
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
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6> : ReflectedMethodNode // TypeDefIndex: 76759
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76758
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
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> : ReflectedMethodNode // TypeDefIndex: 76761
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76760
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
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : ReflectedMethodNode // TypeDefIndex: 76763
	{
		// Fields
		private ActionCall<T1, T2, T3, T4, T5, T6, T7, T8> call;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76762
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
	public sealed class ReflectedFunctionNode<TResult> : ReflectedMethodNode // TypeDefIndex: 76766
	{
		// Fields
		private FunctionCall<TResult> call;
		private TResult returnValue;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 76764
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
		private sealed class __c__DisplayClass3_1 // TypeDefIndex: 76765
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
	public sealed class ReflectedFunctionNode<T1, TResult> : ReflectedMethodNode // TypeDefIndex: 76769
	{
		// Fields
		private FunctionCall<T1, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76767
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76768
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
	public sealed class ReflectedFunctionNode<T1, T2, TResult> : ReflectedMethodNode // TypeDefIndex: 76772
	{
		// Fields
		private FunctionCall<T1, T2, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76770
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76771
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
	public sealed class ReflectedFunctionNode<T1, T2, T3, TResult> : ReflectedMethodNode // TypeDefIndex: 76775
	{
		// Fields
		private FunctionCall<T1, T2, T3, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76773
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76774
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
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, TResult> : ReflectedMethodNode // TypeDefIndex: 76778
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76776
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76777
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
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> : ReflectedMethodNode // TypeDefIndex: 76781
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76779
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76780
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
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> : ReflectedMethodNode // TypeDefIndex: 76784
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76782
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76783
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
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> : ReflectedMethodNode // TypeDefIndex: 76787
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76785
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76786
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
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ReflectedMethodNode // TypeDefIndex: 76790
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult> call;
		private TResult returnValue;
		private T1 instance;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 76788
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
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 76789
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
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 76165
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 77496
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018CB53F68-0x000000018CB53FCC
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 77497
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018CB54010-0x000000018CB540A8
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x000000018CB53FCC-0x000000018CB54010
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 77498
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018CB55ED4-0x000000018CB55F38
		public static bool IsPatched(int id); // 0x000000018CB55FC4-0x000000018CB5605C
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018CB55D8C-0x000000018CB55E58
		public object CreateWrapper(int id); // 0x000000018CB55E58-0x000000018CB55ED4
		public object InitWrapperArray(int len); // 0x000000018CB55F38-0x000000018CB55FC4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018CB55CE8-0x000000018CB55D8C
	}
}

namespace NodeCanvas
{
	public static class AssemblyWrapUtils // TypeDefIndex: 76806
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
	public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 76807
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
		public ActionList actionList { get; } // 0x0000000182986470-0x0000000182986480 
		public float elapsedTime { get; } // 0x000000018CAF0274-0x000000018CAF0290 
		public float deltaTime { get; } // 0x0000000187834D7C-0x0000000187834D84 
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		Component ITaskSystem.agent { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		public IBlackboard blackboard { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018CAF0290-0x000000018CAF0304
	
		// Constructors
		public ActionListPlayer(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CAEFF98-0x000000018CAF00C8
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CAEFE94-0x000000018CAEFF98
		public static ActionListPlayer Create(); // 0x000000018CAEFD08-0x000000018CAEFD84
		protected void Awake(); // 0x000000018CAEFCDC-0x000000018CAEFD08
		public void UpdateTasksOwner(); // 0x000000018CAF00C8-0x000000018CAF0274
		void ITaskSystem.SendEvent(string name, object value, object sender); // 0x0000000186805BA0-0x0000000186805BB0
		void ITaskSystem.SendEvent<T>(string name, T value, object sender);
		[ContextMenu("Play")]
		public void Play(); // 0x000000018CAEFE70-0x000000018CAEFE94
		public void Play(Action<NodeCanvas.Framework.Status> OnFinish); // 0x000000018CAEFE4C-0x000000018CAEFE70
		public void Play(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> OnFinish); // 0x000000018CAEFDD8-0x000000018CAEFE4C
		public NodeCanvas.Framework.Status Execute(); // 0x000000018CAEFDAC-0x000000018CAEFDD8
		public NodeCanvas.Framework.Status Execute(Component agent); // 0x000000018CAEFD84-0x000000018CAEFDAC
	}
}

namespace NodeCanvas.BehaviourTrees
{
	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Behaviour Tree Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class BehaviourTree : NodeCanvas.Framework.Graph // TypeDefIndex: 77112
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
		public NodeCanvas.Framework.Status rootStatus { get; private set; } // 0x0000000187235BF0-0x0000000187235C00 0x00000001852A6540-0x00000001852A6570
		public override System.Type baseNodeType { get; } // 0x000000018CB1D170-0x000000018CB1D1C0 
		public override bool requiresAgent { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool requiresPrimeNode { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool isTree { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool allowBlackboardOverrides { get; } // 0x00000001851A4410-0x00000001851A4420 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Events
		public static event Action<BehaviourTree, NodeCanvas.Framework.Status> onRootStatusChanged {
			add; // 0x000000018CB1D0D4-0x000000018CB1D170
			remove; // 0x000000018CB1D1C0-0x000000018CB1D25C
		}
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 77111
		{
			// Fields
			public bool repeat; // 0x10
			public float updateInterval; // 0x14
	
			// Constructors
			public DerivedSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public BehaviourTree(); // 0x0000000185959150-0x00000001859591B0
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x000000018CB1D078-0x000000018CB1D0D4
		public override void OnDerivedDataDeserialization(object data); // 0x0000000186B8A570-0x0000000186B8A620
		protected override void OnGraphStarted(); // 0x00000001852A4AF0-0x00000001852A4B30
		protected override void OnGraphUpdate(); // 0x00000001852A6570-0x00000001852A6600
		private NodeCanvas.Framework.Status Tick(Component agent, IBlackboard blackboard); // 0x00000001852A6600-0x00000001852A6690
	}

	[AddComponentMenu("NodeCanvas/Behaviour Tree Owner")]
	public class BehaviourTreeOwner : GraphOwner<BehaviourTree> // TypeDefIndex: 77113
	{
		// Properties
		public bool repeat { get; set; } // 0x000000018CB1CD74-0x000000018CB1CE08 0x000000018CB1CF38-0x000000018CB1CFD8
		public float updateInterval { get; set; } // 0x000000018CB1CEA0-0x000000018CB1CF38 0x000000018CB1CFD8-0x000000018CB1D078
		public NodeCanvas.Framework.Status rootStatus { get; } // 0x000000018CB1CE08-0x000000018CB1CEA0 
	
		// Constructors
		public BehaviourTreeOwner(); // 0x0000000186F8DA80-0x0000000186F8DAC0
	
		// Methods
		public NodeCanvas.Framework.Status Tick(); // 0x000000018CB1CCD4-0x000000018CB1CD74
	}

	public class BTConnection : Connection // TypeDefIndex: 77114
	{
		// Constructors
		public BTConnection(); // 0x0000000187240330-0x0000000187240340
	}

	public abstract class BTNode : NodeCanvas.Framework.Node // TypeDefIndex: 77115
	{
		// Properties
		public sealed override System.Type outConnectionType { get; } // 0x000000018CB1CC84-0x000000018CB1CCD4 
		public sealed override bool allowAsPrime { get; } // 0x00000001851A4410-0x00000001851A4420 
		public sealed override bool canSelfConnect { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override Alignment2x2 commentsAlignment { get; } // 0x00000001845BA780-0x00000001845BA790 
		public override Alignment2x2 iconAlignment { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxInConnections { get; } // 0x00000001872328C0-0x00000001872328D0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		protected BTNode(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public T AddChild<T>(int childIndex)
			where T : BTNode;
		public T AddChild<T>()
			where T : BTNode;
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class BTNodeNested<T> : BTNode, IGraphAssignable<T> // TypeDefIndex: 77116
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

	public abstract class BTComposite : BTNode // TypeDefIndex: 77117
	{
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public sealed override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Constructors
		protected BTComposite(); // 0x0000000186B55770-0x0000000186B55780
	}

	public abstract class BTDecorator : BTNode // TypeDefIndex: 77118
	{
		// Properties
		public sealed override int maxOutConnections { get; } // 0x00000001872328C0-0x00000001872328D0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		protected Connection decoratedConnection { get; } // 0x00000001852A84F0-0x00000001852A8540 
		protected NodeCanvas.Framework.Node decoratedNode { get; } // 0x000000018CB1C9E0-0x000000018CB1C9FC 
	
		// Constructors
		protected BTDecorator(); // 0x0000000186B55770-0x0000000186B55780
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Quick way to execute the left or the right child, based on a Condition Task.")]
	[Icon("Condition", false, "")]
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 77119
	{
		// Fields
		[Tooltip("If true, the condition will be re-evaluated per frame.")]
		public bool dynamic; // 0x98
		[SerializeField]
		private ConditionTask _condition; // 0xA0
		private int succeedIndex; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override Alignment2x2 commentsAlignment { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x000000018CB1D38C-0x000000018CB1D3E4
		private ConditionTask condition { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
	
		// Constructors
		public BinarySelector(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB1D25C-0x000000018CB1D370
		protected override void OnReset(); // 0x000000018CB1D370-0x000000018CB1D38C
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Works like a normal Selector, but when a child returns Success, that child will be moved to the end.\nAs a result, previously Failed children will always be checked first and recently Successful children last.")]
	[Icon("FlipSelector", false, "")]
	public class FlipSelector : BTComposite // TypeDefIndex: 77120
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public FlipSelector(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB22C40-0x000000018CB22D20
		private void SendToBack(int i); // 0x000000018CB22D20-0x000000018CB22DC8
		protected override void OnReset(); // 0x0000000187254390-0x00000001872543A0
	}

	[Category("Composites")]
	[Color("ff64cb")]
	[Description("Executes all children simultaneously and return Success or Failure depending on the selected Policy.")]
	[Icon("Parallel", false, "")]
	[Name("Parallel", 8)]
	public class Parallel : BTComposite // TypeDefIndex: 77122
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
		public enum ParallelPolicy // TypeDefIndex: 77121
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}
	
		// Constructors
		public Parallel(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB2AF80-0x000000018CB2AFF4
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2AD98-0x000000018CB2AF80
		protected override void OnReset(); // 0x000000018CB2AFF4-0x000000018CB2B038
		private void ResetRunning(); // 0x000000018CB2B038-0x000000018CB2B0D8
	}

	internal class PrioritySelector_0 : BTComposite // TypeDefIndex: 77123
	{
		// Fields
		[SerializeField]
		public List<BBParameter<float>> priorities; // 0x98
	
		// Constructors
		public PrioritySelector_0(); // 0x0000000186B55770-0x0000000186B55780
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Used for Utility AI, the Priority Selector executes the child with the highest utility weight. If it fails, the Priority Selector will continue with the next highest utility weight child until one Succeeds, or until all Fail (similar to how a normal Selector does).\n\nEach child branch represents a desire, where each desire has one or more consideration which are all averaged.\nConsiderations are a pair of input value and curve, which together produce the consideration utility weight.")]
	[fsMigrateVersions(new System.Type[1] {typeof(PrioritySelector_0) })]
	[Icon("Priority", false, "")]
	public class PrioritySelector : BTComposite, IMigratable<PrioritySelector_0> // TypeDefIndex: 77126
	{
		// Fields
		[AutoSortWithChildrenConnections]
		public List<Desire> desires; // 0x98
		private Connection[] orderedConnections; // 0xA0
		private int current; // 0xA8
	
		// Nested types
		[Serializable]
		public class Desire // TypeDefIndex: 77124
		{
			// Fields
			[fsIgnoreInBuild]
			public string name; // 0x10
			[fsIgnoreInBuild]
			public bool foldout; // 0x18
			public List<Consideration> considerations; // 0x20
	
			// Constructors
			public Desire(); // 0x000000018CB1F244-0x000000018CB1F2BC
	
			// Methods
			public Consideration AddConsideration(IBlackboard bb); // 0x000000018CB1F0C4-0x000000018CB1F154
			public void RemoveConsideration(Consideration consideration); // 0x000000018CB1F1F0-0x000000018CB1F244
			public float GetCompoundUtility(); // 0x000000018CB1F154-0x000000018CB1F1F0
		}
	
		[Serializable]
		public class Consideration // TypeDefIndex: 77125
		{
			// Fields
			public BBParameter<float> input; // 0x10
			public BBParameter<AnimationCurve> function; // 0x18
	
			// Properties
			public float utility { get; } // 0x000000018CB1EA50-0x000000018CB1EB08 
	
			// Constructors
			public Consideration(IBlackboard blackboard); // 0x000000018CB1E964-0x000000018CB1EA50
		}
	
		// Constructors
		public PrioritySelector(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		void IMigratable<PrioritySelector_0>.Migrate(PrioritySelector_0 model); // 0x000000018CB2B3C0-0x000000018CB2B62C
		public override void OnChildConnected(int index); // 0x000000018CB2B0D8-0x000000018CB2B1F4
		public override void OnChildDisconnected(int index); // 0x000000018CB2B1F4-0x000000018CB2B24C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2B24C-0x000000018CB2B3C0
		protected override void OnReset(); // 0x00000001872543B0-0x00000001872543C0
		[CompilerGenerated]
		private float _OnExecute_b__8_0(Connection c); // 0x000000018CB2B62C-0x000000018CB2B6C4
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Selects a child to execute based on its chance to be selected and returns Success if the child returns Success, otherwise picks another child.\nReturns Failure if all children return Failure, or a direct \'Failure Chance\' is introduced.")]
	[Icon("ProbabilitySelector", false, "")]
	public class ProbabilitySelector : BTComposite // TypeDefIndex: 77127
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
		public ProbabilitySelector(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnChildConnected(int index); // 0x000000018CB2B88C-0x000000018CB2B9F4
		public override void OnChildDisconnected(int index); // 0x000000018CB2BA4C-0x000000018CB2BAA4
		public override void OnGraphStarted(); // 0x0000000186AE6760-0x0000000186AE6770
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2BAA4-0x000000018CB2BCEC
		protected override void OnReset(); // 0x000000018CB2BF64-0x000000018CB2C004
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Executes its childrfen in order and returns Failure if all children return Failure. As soon as a child returns Success, the Selector will stop and return Success as well.")]
	[Icon("Selector", false, "")]
	[Name("Selector", 9)]
	public class Selector : BTComposite // TypeDefIndex: 77128
	{
		// Fields
		[Tooltip("If true, then higher priority children are re-evaluated per frame and if either returns Success, then the Selector will immediately stop and return Success as well.")]
		public bool dynamic; // 0x98
		[Tooltip("If true, the children order of execution is shuffled each time the Selector resets.")]
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Selector(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001852A8630-0x00000001852A8790
		protected override void OnReset(); // 0x00000001869B2AB0-0x00000001869B2AE0
		public override void OnChildDisconnected(int index); // 0x000000018CB2C2E8-0x000000018CB2C2FC
		public override void OnGraphStarted(); // 0x0000000186AE6760-0x0000000186AE6770
	}

	[Category("Composites")]
	[Color("bf7fff")]
	[Description("Executes its children in order and returns Success if all children return Success. As soon as a child returns Failure, the Sequencer will stop and return Failure as well.")]
	[Icon("Sequencer", false, "")]
	[Name("Sequencer", 10)]
	public class Sequencer : BTComposite // TypeDefIndex: 77129
	{
		// Fields
		[Tooltip("If true, then higher priority children are re-evaluated per frame and if either returns Failure, then the Sequencer will immediately stop and return Failure as well.")]
		public bool dynamic; // 0x98
		[Tooltip("If true, the children order of execution is shuffled each time the Sequencer resets.")]
		public bool random; // 0x99
		private int lastRunningNodeIndex; // 0x9C
	
		// Constructors
		public Sequencer(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001852A83D0-0x00000001852A84F0
		protected override void OnReset(); // 0x00000001869B2AB0-0x00000001869B2AE0
		public override void OnChildDisconnected(int index); // 0x000000018CB2C2E8-0x000000018CB2C2FC
		public override void OnGraphStarted(); // 0x0000000186AE6760-0x0000000186AE6770
	}

	[Category("Composites")]
	[Color("bf7fff")]
	[Description("In comparison to a normal Sequencer which executes all its children until one fails, Step Sequencer executes its children one-by-one per Step Sequencer execution. The executed child status is returned regardless of Success or Failure.")]
	[Icon("StepIterator", false, "")]
	[Name("Step Sequencer", 0)]
	public class StepIterator : BTComposite // TypeDefIndex: 77130
	{
		// Fields
		private int current; // 0x98
	
		// Constructors
		public StepIterator(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000187254390-0x00000001872543A0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2CC70-0x000000018CB2CD08
		protected override void OnReset(); // 0x00000001872543D0-0x00000001872543E0
	}

	[Category("Composites")]
	[Color("b3ff7f")]
	[Description("Executes one child based on the provided int or enum case and returns its status.")]
	[Icon("IndexSwitcher", false, "")]
	public class Switch : BTComposite // TypeDefIndex: 77133
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
		public enum CaseSelectionMode // TypeDefIndex: 77131
		{
			IndexBased = 0,
			EnumBased = 1
		}
	
		public enum OutOfRangeMode // TypeDefIndex: 77132
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}
	
		// Constructors
		public Switch(); // 0x000000018CB2DA1C-0x000000018CB2DAE0
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB2D898-0x000000018CB2DA1C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2D668-0x000000018CB2D898
	}

	[Category("Decorators")]
	[Description("Executes and returns the child status only if the condition is true. Returns Failure if the condition is false.")]
	[Icon("Accessor", false, "")]
	[Name("Conditional", 0)]
	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 77134
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
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x000000018CB1DDE8-0x000000018CB1DE40
		private ConditionTask condition { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
	
		// Constructors
		public ConditionalEvaluator(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001852A82D0-0x00000001852A83D0
		protected override void OnReset(); // 0x000000018581C7D0-0x000000018581C810
	}

	[Category("Decorators")]
	[Description("Filters the access of its child either a specific number of times, or every specific amount of time.")]
	[Icon("Filter", false, "")]
	[Name("Filter", 0)]
	public class Filter : BTDecorator // TypeDefIndex: 77138
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
		public enum FilterMode // TypeDefIndex: 77135
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}
	
		public enum Policy // TypeDefIndex: 77136
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}
	
		[CompilerGenerated]
		private sealed class _Cooldown_d__13 : IEnumerator<object> // TypeDefIndex: 77137
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Filter __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Cooldown_d__13(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB2DCE0-0x000000018CB2DDAC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB2DDAC-0x000000018CB2DDF8
		}
	
		// Constructors
		public Filter(); // 0x0000000186B55780-0x0000000186B55830
	
		// Methods
		public override void OnGraphStoped(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000186B08160-0x0000000186B08280
		public override void OnClearNodeData(); // 0x0000000187112B60-0x0000000187112B70
		[IteratorStateMachine(typeof(_Cooldown_d__13))]
		private IEnumerator Cooldown(); // 0x000000018CB22B84-0x000000018CB22BE0
	}

	[Category("Decorators")]
	[Description("Protects the decorated child from running if another Guard with the same token is already guarding (Running) that token.\nGuarding is global for all of the agent Behaviour Trees.")]
	[Icon("Shield", false, "")]
	[Name("Guard", 0)]
	public class Guard : BTDecorator // TypeDefIndex: 77140
	{
		// Fields
		[Tooltip("A unique Token to use for guarding.")]
		public BBParameter<string> token; // 0x98
		[Tooltip("What to return in case the token is already guarded by another Guard.")]
		public GuardMode ifGuarded; // 0xA0
		private bool isGuarding; // 0xA4
		private static readonly Dictionary<GameObject, List<Guard>> guards; // 0x00
	
		// Nested types
		public enum GuardMode // TypeDefIndex: 77139
		{
			ReturnFailure = 0,
			WaitUntilReleased = 1
		}
	
		// Constructors
		public Guard(); // 0x0000000186B55770-0x0000000186B55780
		static Guard(); // 0x000000018CB27EFC-0x000000018CB27F88
	
		// Methods
		private static List<Guard> AgentGuards(Component agent); // 0x000000018CB277A0-0x000000018CB27828
		public override void OnGraphStarted(); // 0x000000018CB27A2C-0x000000018CB27A50
		public override void OnGraphStoped(); // 0x000000018CB27A50-0x000000018CB27D08
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB27828-0x000000018CB27A2C
		protected override void OnReset(); // 0x00000001872543A0-0x00000001872543B0
		private void SetGuards(Component guardAgent); // 0x000000018CB27D08-0x000000018CB27EFC
	}

	[Category("Decorators")]
	[Description("Executes and returns the child status. If the condition is or becomes true, the child is interrupted and returns Failure.")]
	[Icon("Interruptor", false, "")]
	[Name("Interrupt", 0)]
	public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 77141
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x000000018CB2806C-0x000000018CB280C4
	
		// Constructors
		public Interruptor(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB27F88-0x000000018CB2806C
		protected override void OnReset(); // 0x000000018581C6D0-0x000000018581C6F0
	}

	[Category("Decorators")]
	[Description("Inverts Success to Failure and Failure to Success.")]
	[Icon("Remap", false, "")]
	[Name("Invert", 0)]
	public class Inverter : BTDecorator // TypeDefIndex: 77142
	{
		// Constructors
		public Inverter(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB280C4-0x000000018CB2814C
	}

	[Category("Decorators")]
	[Description("Iterates a list and executes its child once for each element in that list. Keeps iterating until the Termination Policy is met or until the whole list is iterated, in which case the last iteration child status is returned.")]
	[Icon("List", false, "")]
	[Name("Iterate", 0)]
	public class Iterator : BTDecorator // TypeDefIndex: 77144
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
		private IList list { get; } // 0x000000018CB284B8-0x000000018CB28508 
	
		// Nested types
		public enum TerminationConditions // TypeDefIndex: 77143
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}
	
		// Constructors
		public Iterator(); // 0x000000018CB28458-0x000000018CB284B8
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB281E8-0x000000018CB28444
		protected override void OnReset(); // 0x000000018CB28444-0x000000018CB28458
	}

	[Category("Decorators")]
	[Description("Merge can accept multiple input connections and thus possible to re-use leaf nodes from multiple parents. Please note that this is experimental and can result in unexpected behaviour.")]
	[Name("Merge", -1)]
	public class Merge : BTDecorator // TypeDefIndex: 77145
	{
		// Properties
		public override int maxInConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
	
		// Constructors
		public Merge(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB285E4-0x000000018CB28650
	}

	[Category("Decorators")]
	[Description("Monitors the decorated child for a returned Status and executes an Action when that is the case.\nThe final Status returned to the parent can either be the original decorated child Status, or the new decorator Action Status.")]
	[Icon("Eye", false, "")]
	public class Monitor : BTDecorator, ITaskAssignable<ActionTask> // TypeDefIndex: 77148
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
		public ActionTask action { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x000000018CB28780-0x000000018CB287D8
	
		// Nested types
		public enum MonitorMode // TypeDefIndex: 77146
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}
	
		public enum ReturnStatusMode // TypeDefIndex: 77147
		{
			OriginalDecoratedChildStatus = 0,
			NewDecoratorActionStatus = 1
		}
	
		// Constructors
		public Monitor(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB28650-0x000000018CB2874C
		protected override void OnReset(); // 0x000000018CB2874C-0x000000018CB28780
	}

	[Category("Decorators")]
	[Description("Executes the decorated child as normal and returns an Optional status, thus making it optional to the parent node in regards to what status is returned.\nThis has the same effect as disabling the node, but instead it executes normaly.")]
	[Icon("UpwardsArrow", false, "")]
	[Name("Optional", 0)]
	public class Optional : BTDecorator // TypeDefIndex: 77149
	{
		// Constructors
		public Optional(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001866F7480-0x00000001866F7520
	}

	[Category("Decorators")]
	[Description("Remaps the child status to another status. Used to either invert the child\'s return status or to always return a specific status.")]
	[Icon("Remap", false, "")]
	[Name("Remap", 0)]
	public class Remapper : BTDecorator // TypeDefIndex: 77151
	{
		// Fields
		public RemapStatus successRemap; // 0x98
		public RemapStatus failureRemap; // 0x9C
	
		// Nested types
		public enum RemapStatus // TypeDefIndex: 77150
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Remapper(); // 0x0000000186B55920-0x0000000186B55940
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001852A6690-0x00000001852A6740
	}

	[Category("Decorators")]
	[Description("Repeats the child either x times or until it returns the specified status, or forever.")]
	[Icon("Repeat", false, "")]
	[Name("Repeat", 0)]
	public class Repeater : BTDecorator // TypeDefIndex: 77154
	{
		// Fields
		public RepeaterMode repeaterMode; // 0x98
		[ShowIf("repeaterMode", 0)]
		public BBParameter<int> repeatTimes; // 0xA0
		[ShowIf("repeaterMode", 1)]
		public RepeatUntilStatus repeatUntilStatus; // 0xA8
		private int currentIteration; // 0xAC
	
		// Nested types
		public enum RepeaterMode // TypeDefIndex: 77152
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}
	
		public enum RepeatUntilStatus // TypeDefIndex: 77153
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Repeater(); // 0x000000018CB2C1B0-0x000000018CB2C21C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2C08C-0x000000018CB2C1B0
		protected override void OnReset(); // 0x00000001872543C0-0x00000001872543D0
	}

	[Category("Decorators")]
	[Description("Set another Agent for the rest of the Tree dynamicaly from this point and on. All nodes under this will be executed with the new agent. You can also use this decorator to revert back to the original graph agent.")]
	[Icon("Agent", false, "")]
	[Name("Override Agent", 0)]
	public class Setter : BTDecorator // TypeDefIndex: 77155
	{
		// Fields
		[Tooltip("If enabled, will revert back to the original graph agent.")]
		public bool revertToOriginal; // 0x98
		[ShowIf("revertToOriginal", 0)]
		[Tooltip("The new agent to use.")]
		public BBParameter<GameObject> newAgent; // 0xA0
	
		// Constructors
		public Setter(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2C2FC-0x000000018CB2C3B8
	}

	[Category("Decorators")]
	[Description("Interupts decorated child node and returns Failure if the child node is still Running after the timeout period.")]
	[Icon("Timeout", false, "")]
	public class Timeout : BTDecorator // TypeDefIndex: 77156
	{
		// Fields
		[Tooltip("The timeout period in seconds.")]
		public BBParameter<float> timeout; // 0x98
	
		// Constructors
		public Timeout(); // 0x000000018CB2DBD0-0x000000018CB2DC2C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2DAE0-0x000000018CB2DBD0
	}

	[Category("Decorators")]
	[Description("Returns Running until the assigned condition becomes true, after which the decorated child is executed.")]
	[Icon("Halt", false, "")]
	public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 77157
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
		private bool accessed; // 0xA0
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x000000018CB2EF3C-0x000000018CB2F1A8
		private ConditionTask condition { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
	
		// Constructors
		public WaitUntil(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2EE04-0x000000018CB2EF04
		protected override void OnReset(); // 0x000000018CB2EF04-0x000000018CB2EF3C
	}

	[Description("Executes an action and returns Success or Failure when the action is finished.\nReturns Running until the action is finished.")]
	[Icon("Action", false, "")]
	[Name("Action", 0)]
	public class ActionNode : BTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 77158
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x000000018CB1C208-0x000000018CB1C260
		public ActionTask action { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
	
		// Constructors
		public ActionNode(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018581CF30-0x000000018581CF70
		protected override void OnReset(); // 0x000000018581C340-0x000000018581C360
		public override void OnGraphPaused(); // 0x000000018CB1C134-0x000000018CB1C150
	}

	[Description("Checks a condition and returns Success or Failure.")]
	[Icon("Condition", false, "")]
	[Name("Condition", 0)]
	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 77159
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0x98
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x000000018CB1DD38-0x000000018CB1DD90
		public ConditionTask condition { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
	
		// Constructors
		public ConditionNode(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018581C650-0x000000018581C6D0
		protected override void OnReset(); // 0x000000018581C6D0-0x000000018581C6F0
	}

	[Description("Executes a sub Dialogue Tree. Returns Running while the sub Dialogue Tree is active. You can Finish the Dialogue Tree with the \'Finish\' node and return Success or Failure.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue", 0)]
	public class NestedDT : BTNodeNested<DialogueTree> // TypeDefIndex: 77160
	{
		// Fields
		[ExposeField]
		[Name("Sub Tree", 0)]
		[SerializeField]
		private BBParameter<DialogueTree> _nestedDialogueTree; // 0xB0
	
		// Properties
		public override DialogueTree subGraph { get; set; } // 0x000000018CB299B8-0x000000018CB29A00 0x000000018CB29A00-0x000000018CB29A58
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public NestedDT(); // 0x000000018CB29984-0x000000018CB299B8
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB297BC-0x000000018CB29904
		private void OnDLGFinished(bool success); // 0x000000018CB1CB1C-0x000000018CB1CB30
		protected override void OnReset(); // 0x000000018CB29904-0x000000018CB29984
	}

	[Description("Executes a sub FSM. Returns Running while the sub FSM is active. If a Success or Failure State is selected, then it will return Success or Failure as soon as the Nested FSM enters that state at which point the sub FSM will also be stoped. If the sub FSM ends otherwise, this node will return Success.")]
	[DropReferenceType(typeof(FSM))]
	[Icon("FSM", false, "")]
	[Name("Sub FSM", 0)]
	public class NestedFSM : BTNodeNested<FSM> // TypeDefIndex: 77161
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
		public override FSM subGraph { get; set; } // 0x000000018CB29FA0-0x000000018CB29FE8 0x000000018CB29FE8-0x000000018CB2A040
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public NestedFSM(); // 0x000000018CB29F6C-0x000000018CB29FA0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB29D10-0x000000018CB29EEC
		private void OnFSMFinish(bool success); // 0x000000018CB1CB1C-0x000000018CB1CB30
		protected override void OnReset(); // 0x000000018CB29EEC-0x000000018CB29F6C
	}

	[Description("Executes a sub Behaviour Tree. The status of the root node in the SubTree will be returned.")]
	[DropReferenceType(typeof(BehaviourTree))]
	[Icon("BT", false, "")]
	[Name("Sub Tree", 0)]
	public class SubTree : BTNodeNested<BehaviourTree> // TypeDefIndex: 77162
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override BehaviourTree subGraph { get; set; } // 0x0000000186C3DF30-0x0000000186C3DF60 0x0000000186E1AD30-0x0000000186E1AD90
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public SubTree(); // 0x00000001870B29A0-0x00000001870B29E0
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001866291F0-0x0000000186629320
		protected override void OnReset(); // 0x0000000186C746C0-0x0000000186C74780
	}

	[Category("Mutators (beta)")]
	[Description("Enable, Disable or Toggle one or more nodes with provided tag. In practise their incomming connections are disabled\nBeta Feature!")]
	[Name("Node Toggler", 0)]
	[Obsolete]
	public class NodeToggler : BTNode // TypeDefIndex: 77164
	{
		// Fields
		public ToggleMode toggleMode; // 0x98
		public string targetNodeTag; // 0xA0
		private List<NodeCanvas.Framework.Node> targetNodes; // 0xA8
	
		// Nested types
		public enum ToggleMode // TypeDefIndex: 77163
		{
			Enable = 0,
			Disable = 1,
			Toggle = 2
		}
	
		// Constructors
		public NodeToggler(); // 0x000000018CB2A4E8-0x000000018CB2A4FC
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB2A46C-0x000000018CB2A4E8
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2A040-0x000000018CB2A46C
	}

	[Category("Mutators (beta)")]
	[Description("Switch the root node of the behaviour tree to a new one defined by tag\nBeta Feature!")]
	[Name("Root Switcher", 0)]
	[Obsolete]
	public class RootSwitcher : BTNode // TypeDefIndex: 77165
	{
		// Fields
		public string targetNodeTag; // 0x98
		private NodeCanvas.Framework.Node targetNode; // 0xA0
	
		// Constructors
		public RootSwitcher(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB2C288-0x000000018CB2C2E8
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2C21C-0x000000018CB2C288
	}

	[Description("Executes a nested FlowScript. Returns Running while the FlowScript is active. You can Finish the FlowScript with the \'Finish\' node and return Success or Failure")]
	[DropReferenceType(typeof(FlowScript))]
	[Icon("FS", false, "")]
	[Name("Sub FlowScript", 0)]
	public class BTNestedFlowScript : BTNodeNested<FlowScript> // TypeDefIndex: 77166
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xB0
	
		// Properties
		public override FlowScript subGraph { get; set; } // 0x000000018CB1CBE4-0x000000018CB1CC2C 0x000000018CB1CC2C-0x000000018CB1CC84
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public BTNestedFlowScript(); // 0x000000018CB1CBB0-0x000000018CB1CBE4
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB1C9FC-0x000000018CB1CB1C
		private void OnFlowScriptFinished(bool success); // 0x000000018CB1CB1C-0x000000018CB1CB30
		protected override void OnReset(); // 0x000000018CB1CB30-0x000000018CB1CBB0
	}
}

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu("NodeCanvas/Dialogue Actor")]
	public class DialogueActor : MonoBehaviour, IDialogueActor // TypeDefIndex: 77066
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
		public new string name { get; } // 0x0000000182234E30-0x0000000182234E40 
		public Texture2D portrait { get; } // 0x000000018225E800-0x000000018225E810 
		public Sprite portraitSprite { get; } // 0x000000018CB1F324-0x000000018CB1F440 
		public UnityEngine.Color dialogueColor { get; } // 0x000000018723D770-0x000000018723D780 
		public Vector3 dialoguePosition { get; } // 0x000000018CB1F2BC-0x000000018CB1F324 
		Transform IDialogueActor.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Constructors
		public DialogueActor(); // 0x000000018CAC0F34-0x000000018CAC0F6C
	}

	public class SubtitlesRequestInfo // TypeDefIndex: 77067
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public IStatement statement; // 0x18
		public Action Continue; // 0x20
	
		// Constructors
		public SubtitlesRequestInfo(IDialogueActor actor, IStatement statement, Action callback); // 0x00000001854F5A50-0x00000001854F5A90
	}

	public class MultipleChoiceRequestInfo // TypeDefIndex: 77068
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public Dictionary<IStatement, int> options; // 0x18
		public float availableTime; // 0x20
		public bool showLastStatement; // 0x24
		public Action<int> SelectOption; // 0x28
	
		// Constructors
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback); // 0x000000018CB28D68-0x000000018CB28DB0
		public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, Action<int> callback); // 0x000000018CB28D28-0x000000018CB28D68
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Dialogue Tree Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class DialogueTree : NodeCanvas.Framework.Graph // TypeDefIndex: 77077
	{
		// Fields
		public const string INSTIGATOR_NAME = "SELF"; // Metadata: 0x02629D5F
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
		public static DialogueTree currentDialogue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CB20A14-0x000000018CB20A4C 0x000000018CB20F18-0x000000018CB20F6C
		public static DialogueTree previousDialogue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CB20BB4-0x000000018CB20BEC 0x000000018CB20F6C-0x000000018CB20FC0
		public DTNode currentNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		public override System.Type baseNodeType { get; } // 0x000000018CB209C4-0x000000018CB20A14 
		public override bool requiresAgent { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool requiresPrimeNode { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool isTree { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool allowBlackboardOverrides { get; } // 0x00000001851A4410-0x00000001851A4420 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public sealed override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public List<string> definedActorParameterNames { get; } // 0x000000018CB20A4C-0x000000018CB20BB4 
	
		// Events
		public static event Action<DialogueTree> OnDialogueStarted {
			add; // 0x000000018CB207E0-0x000000018CB2087C
			remove; // 0x000000018CB20D34-0x000000018CB20DD0
		}
		public static event Action<DialogueTree> OnDialoguePaused {
			add; // 0x000000018CB2073C-0x000000018CB207E0
			remove; // 0x000000018CB20C90-0x000000018CB20D34
		}
		public static event Action<DialogueTree> OnDialogueFinished {
			add; // 0x000000018CB20698-0x000000018CB2073C
			remove; // 0x000000018CB20BEC-0x000000018CB20C90
		}
		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest {
			add; // 0x000000018CB20920-0x000000018CB209C4
			remove; // 0x000000018CB20E74-0x000000018CB20F18
		}
		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest {
			add; // 0x000000018CB2087C-0x000000018CB20920
			remove; // 0x000000018CB20DD0-0x000000018CB20E74
		}
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 77069
		{
			// Fields
			public List<ActorParameter> actorParameters; // 0x10
	
			// Constructors
			public DerivedSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class ActorParameter // TypeDefIndex: 77070
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
			public string name { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public string ID { get; } // 0x000000018CB1C4D4-0x000000018CB1C558 
			public IDialogueActor actor { get; set; } // 0x000000018CB1C558-0x000000018CB1C5C8 0x000000018CB1C5C8-0x000000018CB1C638
	
			// Constructors
			public ActorParameter(); // 0x0000000186805BA0-0x0000000186805BB0
			public ActorParameter(string name); // 0x0000000184FD2410-0x0000000184FD2420
			public ActorParameter(string name, IDialogueActor actor); // 0x000000018CB1C4A8-0x000000018CB1C4D4
	
			// Methods
			public override string ToString(); // 0x00000001829260F0-0x0000000182926100
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77071
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ActorParameter, string> __9__48_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB2EC9C-0x000000018CB2ED00
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _get_definedActorParameterNames_b__48_0(ActorParameter r); // 0x0000000188E4BE44-0x0000000188E4BE5C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0 // TypeDefIndex: 77072
		{
			// Fields
			public string id; // 0x10
	
			// Constructors
			public __c__DisplayClass49_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetParameterByID_b__0(ActorParameter p); // 0x000000018CB2EBD8-0x000000018CB2EC10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 77073
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetParameterByName_b__0(ActorParameter p); // 0x0000000185624DA0-0x0000000185624DD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 77074
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetActorReferenceByName_b__0(ActorParameter r); // 0x0000000185624DA0-0x0000000185624DD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 77075
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _SetActorReference_b__0(ActorParameter p); // 0x0000000185624DA0-0x0000000185624DD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 77076
		{
			// Fields
			public KeyValuePair<string, IDialogueActor> pair; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _SetActorReferences_b__0(ActorParameter p); // 0x000000018CB2EC10-0x000000018CB2EC64
		}
	
		// Constructors
		public DialogueTree(); // 0x000000018CB205F8-0x000000018CB20698
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x000000018CB1FEA8-0x000000018CB1FF04
		public override void OnDerivedDataDeserialization(object data); // 0x000000018CB1FE1C-0x000000018CB1FEA8
		public ActorParameter GetParameterByID(string id); // 0x000000018CB1FC74-0x000000018CB1FD48
		public ActorParameter GetParameterByName(string paramName); // 0x000000018CB1FD48-0x000000018CB1FE1C
		public IDialogueActor GetActorReferenceByID(string id); // 0x000000018CB1F9E0-0x000000018CB1FA10
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x000000018CB1FA10-0x000000018CB1FC74
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x000000018CB202AC-0x000000018CB203A0
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x000000018CB203A0-0x000000018CB205F8
		public void Continue(int index = 0 /* Metadata: 0x02629D5E */); // 0x000000018CB1F858-0x000000018CB1F94C
		public void EnterNode(DTNode node); // 0x000000018CB1F94C-0x000000018CB1F9E0
		public static void RequestSubtitles(SubtitlesRequestInfo info); // 0x000000018CB2025C-0x000000018CB202AC
		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info); // 0x000000018CB2020C-0x000000018CB2025C
		protected override void OnGraphStarted(); // 0x000000018CB1FF54-0x000000018CB20044
		protected override void OnGraphUpdate(); // 0x000000018CB20190-0x000000018CB2020C
		protected override void OnGraphStoped(); // 0x000000018CB20044-0x000000018CB200E4
		protected override void OnGraphPaused(); // 0x000000018CB1FF04-0x000000018CB1FF54
		protected override void OnGraphUnpaused(); // 0x000000018CB200E4-0x000000018CB20190
	}

	[AddComponentMenu("NodeCanvas/Dialogue Tree Controller")]
	public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor // TypeDefIndex: 77078
	{
		// Properties
		string IDialogueActor.name { get; } // 0x0000000187835674-0x000000018783567C 
		Texture2D IDialogueActor.portrait { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		Sprite IDialogueActor.portraitSprite { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		UnityEngine.Color IDialogueActor.dialogueColor { get; } // 0x000000018CB1F4E8-0x000000018CB1F508 
		Vector3 IDialogueActor.dialoguePosition { get; } // 0x000000018C1DC668-0x000000018C1DC680 
		Transform IDialogueActor.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Constructors
		public DialogueTreeController(); // 0x000000018CB1F824-0x000000018CB1F858
	
		// Methods
		public void StartDialogue(); // 0x000000018CB1F68C-0x000000018CB1F69C
		public void StartDialogue(Action<bool> callback); // 0x000000018CB1F7D8-0x000000018CB1F7E8
		public void StartDialogue(IDialogueActor instigator); // 0x000000018CB1F7E8-0x000000018CB1F7F4
		public void StartDialogue(DialogueTree newTree, IDialogueActor instigator, Action<bool> callback); // 0x000000018CB1F69C-0x000000018CB1F6E4
		public void StartDialogue(IDialogueActor instigator, Action<bool> callback); // 0x000000018CB1F6E4-0x000000018CB1F7D8
		public void PauseDialogue(); // 0x000000018CB1F508-0x000000018CB1F534
		public void StopDialogue(); // 0x000000018CB1F7F4-0x000000018CB1F824
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x000000018CB1F534-0x000000018CB1F5E8
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x000000018CB1F5E8-0x000000018CB1F68C
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x000000018CB1F440-0x000000018CB1F4E8
	}

	public class DTConnection : Connection // TypeDefIndex: 77079
	{
		// Constructors
		public DTConnection(); // 0x0000000187240330-0x0000000187240340
	}

	public abstract class DTNode : NodeCanvas.Framework.Node // TypeDefIndex: 77080
	{
		// Fields
		[SerializeField]
		private string _actorName; // 0x98
		[SerializeField]
		private string _actorParameterID; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018CB1EEFC-0x000000018CB1EFD4 
		public virtual bool requireActorSelection { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override int maxInConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public override int maxOutConnections { get; } // 0x00000001872328C0-0x00000001872328D0 
		public sealed override System.Type outConnectionType { get; } // 0x000000018CB1EFD4-0x000000018CB1F024 
		public sealed override bool allowAsPrime { get; } // 0x00000001851A4410-0x00000001851A4420 
		public sealed override bool canSelfConnect { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x00000001845BA780-0x00000001845BA790 
		protected DialogueTree DLGTree { get; } // 0x000000018CB1EE1C-0x000000018CB1EE58 
		public string actorName { get; private set; } // 0x000000018CB1EE58-0x000000018CB1EEA0 0x000000018CB1F024-0x000000018CB1F0C4
		public IDialogueActor finalActor { get; } // 0x000000018CB1EEA0-0x000000018CB1EEFC 
	
		// Constructors
		protected DTNode(); // 0x000000018CB1EDCC-0x000000018CB1EE1C
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class DTNodeNested<T> : DTNode, IGraphAssignable<T> // TypeDefIndex: 77081
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

	public interface IDialogueActor // TypeDefIndex: 77082
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
	public class ProxyDialogueActor : IDialogueActor // TypeDefIndex: 77083
	{
		// Fields
		private string _name; // 0x10
		private Transform _transform; // 0x18
	
		// Properties
		public string name { get; } // 0x00000001829260F0-0x0000000182926100 
		public Texture2D portrait { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public Sprite portraitSprite { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public UnityEngine.Color dialogueColor { get; } // 0x000000018CB1F4E8-0x000000018CB1F508 
		public Vector3 dialoguePosition { get; } // 0x000000018C1DC668-0x000000018C1DC680 
		public Transform transform { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public ProxyDialogueActor(string name, Transform transform); // 0x0000000185381AC0-0x0000000185381AF0
	}

	public interface IStatement // TypeDefIndex: 77084
	{
		// Properties
		string text { get; }
		AudioClip audio { get; }
		string meta { get; }
	}

	[Serializable]
	public class Statement : IStatement // TypeDefIndex: 77086
	{
		// Fields
		[SerializeField]
		private string _text; // 0x10
		[SerializeField]
		private AudioClip _audio; // 0x18
		[SerializeField]
		private string _meta; // 0x20
	
		// Properties
		public string text { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public AudioClip audio { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string meta { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 77085
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _BlackboardReplace_b__0(string input); // 0x000000018CB2E960-0x000000018CB2EB54
		}
	
		// Constructors
		public Statement(); // 0x000000018CB2CC08-0x000000018CB2CC70
		public Statement(string text); // 0x000000018CB2CA38-0x000000018CB2CAB8
		public Statement(string text, AudioClip audio); // 0x000000018CB2CB6C-0x000000018CB2CC08
		public Statement(string text, AudioClip audio, string meta); // 0x000000018CB2CAB8-0x000000018CB2CB6C
	
		// Methods
		public IStatement BlackboardReplace(IBlackboard bb); // 0x000000018CB2C8FC-0x000000018CB2CA38
		public override string ToString(); // 0x00000001829260F0-0x0000000182926100
	}

	[Description("Execute an Action Task for the Dialogue Actor selected.")]
	[Name("Task Action", 0)]
	public class ActionNode : DTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 77088
	{
		// Fields
		[SerializeField]
		private ActionTask _action; // 0xA8
	
		// Properties
		public ActionTask action { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x000000018CB1C260-0x000000018CB1C2B8
		public override bool requireActorSelection { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _UpdateAction_d__10 : IEnumerator<object> // TypeDefIndex: 77087
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ActionNode __4__this; // 0x20
			public Component actionAgent; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _UpdateAction_d__10(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB2ED00-0x000000018CB2EDB8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB2EDB8-0x000000018CB2EE04
		}
	
		// Constructors
		public ActionNode(); // 0x000000018BD94320-0x000000018BD94328
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB1C088-0x000000018CB1C118
		[IteratorStateMachine(typeof(_UpdateAction_d__10))]
		private IEnumerator UpdateAction(Component actionAgent); // 0x000000018CB1C16C-0x000000018CB1C1E4
		private void OnActionEnd(bool success); // 0x000000018CB1C01C-0x000000018CB1C088
		protected override void OnReset(); // 0x000000018CB1C150-0x000000018CB1C16C
		public override void OnGraphPaused(); // 0x000000018CB1C118-0x000000018CB1C134
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Execute the first child node if a Condition is true, or the second one if that Condition is false. The Actor selected is used for the Condition check")]
	[Icon("Condition", false, "")]
	[Name("Task Condition", 0)]
	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 77089
	{
		// Fields
		[SerializeField]
		private ConditionTask _condition; // 0xA8
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x000000018CB1DD90-0x000000018CB1DDE8
		public override int maxOutConnections { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override bool requireActorSelection { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public ConditionNode(); // 0x000000018BD94320-0x000000018BD94328
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB1DC2C-0x000000018CB1DD38
	}

	[Category("Control")]
	[Color("6ebbff")]
	[Description("End the dialogue in Success or Failure.\nNote: A Dialogue will anyway End in Succcess if it has reached a node without child connections. Thus this node is mostly useful if you want to end a Dialogue in Failure.")]
	[Icon("Halt", false, "")]
	[Name("FINISH", 0)]
	public class FinishNode : DTNode // TypeDefIndex: 77090
	{
		// Fields
		public CompactStatus finishState; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool requireActorSelection { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public FinishNode(); // 0x000000018CB22C2C-0x000000018CB22C40
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB22BE0-0x000000018CB22C2C
	}

	[Category("Control")]
	[Color("6ebbff")]
	[Description("Select a target node to jump to.\nFor your convenience in identifying nodes in the dropdown, please give a Tag name to the nodes you want to use in this way.")]
	[Icon("Set", false, "")]
	[Name("JUMP", 0)]
	public class Jumper : DTNode, IHaveNodeReference // TypeDefIndex: 77091
	{
		// Fields
		[fsSerializeAs("_sourceNodeUID")]
		public NodeReference<DTNode> _targetNode; // 0xA8
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get; } // 0x0000000187232FB0-0x0000000187232FC0 
		private DTNode target { get; } // 0x000000018CB28594-0x000000018CB285E4 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool requireActorSelection { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public Jumper(); // 0x000000018BD94320-0x000000018BD94328
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB28508-0x000000018CB28594
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Prompt a Dialogue Multiple Choice. A choice will be available if the choice condition(s) are true or there is no choice conditions. The Actor selected is used for the condition checks and will also Say the selection if the option is checked.")]
	[Icon("List", false, "")]
	[Name("Multiple Choice", 0)]
	public class MultipleChoiceNode : DTNode // TypeDefIndex: 77094
	{
		// Fields
		[SliderField(0f, 10f)]
		public float availableTime; // 0xA8
		public bool saySelection; // 0xAC
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<Choice> availableChoices; // 0xB0
	
		// Properties
		public override int maxOutConnections { get; } // 0x000000018CB28CE8-0x000000018CB28D28 
		public override bool requireActorSelection { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		[Serializable]
		public class Choice // TypeDefIndex: 77092
		{
			// Fields
			public bool isUnfolded; // 0x10
			public Statement statement; // 0x18
			public ConditionTask condition; // 0x20
	
			// Constructors
			public Choice(); // 0x00000001829D07F0-0x00000001829D0800
			public Choice(Statement statement); // 0x000000018BAC416C-0x000000018BAC4180
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 77093
		{
			// Fields
			public MultipleChoiceNode __4__this; // 0x10
			public int index; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnOptionSelected_b__0(); // 0x000000018CB2EC64-0x000000018CB2EC9C
		}
	
		// Constructors
		public MultipleChoiceNode(); // 0x000000018CB28C60-0x000000018CB28CE8
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB287D8-0x000000018CB28AD8
		private void OnOptionSelected(int index); // 0x000000018CB28AD8-0x000000018CB28C60
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Will continue with the first child node which condition returns true. The Dialogue Actor selected will be used for the checks")]
	[Icon("Selector", false, "")]
	[Name("Multiple Task Condition", 0)]
	public class MultipleConditionNode : DTNode // TypeDefIndex: 77095
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<ConditionTask> conditions; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
	
		// Constructors
		public MultipleConditionNode(); // 0x000000018CB29010-0x000000018CB29098
	
		// Methods
		public override void OnChildConnected(int index); // 0x000000018CB28DB0-0x000000018CB28E3C
		public override void OnChildDisconnected(int index); // 0x000000018CB28E3C-0x000000018CB28E94
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB28E94-0x000000018CB29010
	}

	[Category("Branch")]
	[Color("b3ff7f")]
	[Description("Select a child to execute based on it\'s chance to be selected. An optional pre-Condition Task can be assigned to filter the child in or out of the selection probability.\nThe actor selected will be used for the condition checks.")]
	[Icon("ProbabilitySelector", false, "")]
	public class ProbabilitySelector : DTNode // TypeDefIndex: 77097
	{
		// Fields
		[AutoSortWithChildrenConnections]
		[SerializeField]
		private List<Option> childOptions; // 0xA8
		private List<int> successIndeces; // 0xB0
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
	
		// Nested types
		public class Option // TypeDefIndex: 77096
		{
			// Fields
			public BBParameter<float> weight; // 0x10
			public ConditionTask condition; // 0x18
	
			// Constructors
			public Option(float weightValue, IBlackboard bbValue); // 0x000000018CB2ACD8-0x000000018CB2AD98
		}
	
		// Constructors
		public ProbabilitySelector(); // 0x000000018CB2C004-0x000000018CB2C08C
	
		// Methods
		public override void OnChildConnected(int index); // 0x000000018CB2B7A8-0x000000018CB2B88C
		public override void OnChildDisconnected(int index); // 0x000000018CB2B9F4-0x000000018CB2BA4C
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018CB2BCEC-0x000000018CB2BF64
		private float GetTotal(); // 0x000000018CB2B6C4-0x000000018CB2B7A8
		protected override void OnReset(); // 0x000000018CAEF730-0x000000018CAEF748
	}

	[Description("Make the selected Dialogue Actor talk. You can make the text more dynamic by using variable names in square brackets\ne.g. [myVarName] or [Global/myVarName]")]
	[Name("Say", 0)]
	public class StatementNode : DTNode // TypeDefIndex: 77098
	{
		// Fields
		[SerializeField]
		public Statement statement; // 0xA8
	
		// Properties
		public override bool requireActorSelection { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public StatementNode(); // 0x000000018CB2C874-0x000000018CB2C8FC
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB2C738-0x000000018CB2C834
		private void OnStatementFinish(); // 0x000000018CB2C834-0x000000018CB2C874
	}

	[Description("Execute a Sub Dialogue Tree. When that Dialogue Tree is finished, this node will continue either in Success or Failure if it has any connections. Useful for making reusable and self-contained Dialogue Trees.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue Tree", 0)]
	public class SubDialogueTree : DTNodeNested<DialogueTree>, IUpdatable // TypeDefIndex: 77099
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<DialogueTree> _subTree; // 0xC0
		[fsSerializeAs("actorParametersMap")]
		private Dictionary<string, string> _actorParametersMap; // 0xC8
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override DialogueTree subGraph { get; set; } // 0x000000018CB2D204-0x000000018CB2D24C 0x000000018CB2D24C-0x000000018CB2D2A4
		public override BBParameter subGraphParameter { get; } // 0x0000000187236200-0x0000000187236210 
	
		// Constructors
		public SubDialogueTree(); // 0x000000018CB2D1D0-0x000000018CB2D204
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB2CD9C-0x000000018CB2CF88
		private void OnSubDialogueFinish(bool success); // 0x000000018CB2CF88-0x000000018CB2CFE0
		void IUpdatable.Update(); // 0x000000018CB2CD08-0x000000018CB2CD9C
		private void TryWriteMappedActorParameters(); // 0x000000018CB2CFE0-0x000000018CB2D1D0
	}

	[Obsolete("Use Jumpers instead")]
	public class GoToNode : DTNode // TypeDefIndex: 77100
	{
		// Fields
		[SerializeField]
		private DTNode _targetNode; // 0xA8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool requireActorSelection { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public GoToNode(); // 0x000000018BD94320-0x000000018BD94328
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB230D4-0x000000018CB2314C
	}

	[Description("Executes a FlowScript. Use the Finish flowscript node to continue the dialogue either in Success or Failure.\nThe actor selected here will also be used in the flowcript for \'Self\'.")]
	[DropReferenceType(typeof(FlowScript))]
	[Name("Sub FlowScript", 0)]
	public class DTNestedFlowScript : DTNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 77101
	{
		// Fields
		[ExposeField]
		[SerializeField]
		private BBParameter<FlowScript> _flowScript; // 0xC0
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override FlowScript subGraph { get; set; } // 0x000000018CB1ED2C-0x000000018CB1ED74 0x000000018CB1ED74-0x000000018CB1EDCC
		public override BBParameter subGraphParameter { get; } // 0x0000000187236200-0x0000000187236210 
	
		// Constructors
		public DTNestedFlowScript(); // 0x000000018CB1ECF8-0x000000018CB1ED2C
	
		// Methods
		protected override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB1EB9C-0x000000018CB1ECA8
		void IUpdatable.Update(); // 0x000000018CB1EB08-0x000000018CB1EB9C
		private void OnFlowScriptFinish(bool success); // 0x000000018CB1ECA8-0x000000018CB1ECF8
	}
}

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : MonoBehaviour // TypeDefIndex: 77110
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
		private AudioSource localSource { get; } // 0x000000018CB226E0-0x000000018CB2278C 
		private bool anyKeyDown { get; } // 0x000000018CB226D8-0x000000018CB226E0 
	
		// Nested types
		[Serializable]
		public class SubtitleDelays // TypeDefIndex: 77102
		{
			// Fields
			public float characterDelay; // 0x10
			public float sentenceDelay; // 0x14
			public float commaDelay; // 0x18
			public float finalDelay; // 0x1C
	
			// Constructors
			public SubtitleDelays(); // 0x00000001872543E0-0x0000000187254400
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 77103
		{
			// Fields
			public bool inputDown; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Internal_OnSubtitlesRequestInfo_b__0(); // 0x00000001829D07F0-0x00000001829D0800
		}
	
		[CompilerGenerated]
		private sealed class _Internal_OnSubtitlesRequestInfo_d__31 : IEnumerator<object> // TypeDefIndex: 77104
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Internal_OnSubtitlesRequestInfo_d__31(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB2E078-0x000000018CB2E914
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB2E914-0x000000018CB2E960
		}
	
		[CompilerGenerated]
		private sealed class _CheckInput_d__33 : IEnumerator<object> // TypeDefIndex: 77105
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DialogueUGUI __4__this; // 0x20
			public Action Do; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CheckInput_d__33(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB2DC2C-0x000000018CB2DC94
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB2DC94-0x000000018CB2DCE0
		}
	
		[CompilerGenerated]
		private sealed class _DelayPrint_d__34 : IEnumerator<object> // TypeDefIndex: 77106
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float time; // 0x20
			private float _timer_5__2; // 0x24
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DelayPrint_d__34(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB2DFB8-0x000000018CB2E02C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB2E02C-0x000000018CB2E078
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 77107
		{
			// Fields
			public DialogueUGUI __4__this; // 0x10
			public MultipleChoiceRequestInfo info; // 0x18
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_1 // TypeDefIndex: 77108
		{
			// Fields
			public UnityEngine.UI.Button btn; // 0x10
			public __c__DisplayClass35_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass35_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnMultipleChoiceRequest_b__0(); // 0x000000018CB2EB54-0x000000018CB2EBD8
		}
	
		[CompilerGenerated]
		private sealed class _CountDown_d__36 : IEnumerator<object> // TypeDefIndex: 77109
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DialogueUGUI __4__this; // 0x20
			public MultipleChoiceRequestInfo info; // 0x28
			private float _timer_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CountDown_d__36(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB2DDF8-0x000000018CB2DF6C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB2DF6C-0x000000018CB2DFB8
		}
	
		// Constructors
		public DialogueUGUI(); // 0x000000018CB22664-0x000000018CB226D8
	
		// Methods
		private void Awake(); // 0x000000018CB20FC0-0x000000018CB20FE0
		private void OnEnable(); // 0x000000018CB21900-0x000000018CB21920
		private void OnDisable(); // 0x000000018CB218F8-0x000000018CB21900
		private void Subscribe(); // 0x000000018CB22334-0x000000018CB224CC
		private void UnSubscribe(); // 0x000000018CB224CC-0x000000018CB22664
		private void Hide(); // 0x000000018CB21424-0x000000018CB2151C
		private void OnDialogueStarted(DialogueTree dlg); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDialoguePaused(DialogueTree dlg); // 0x000000018CB21838-0x000000018CB218F8
		private void OnDialogueFinished(DialogueTree dlg); // 0x000000018CB21594-0x000000018CB21838
		private void OnSubtitlesRequest(SubtitlesRequestInfo info); // 0x000000018CB22188-0x000000018CB221AC
		[IteratorStateMachine(typeof(_Internal_OnSubtitlesRequestInfo_d__31))]
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info); // 0x000000018CB2151C-0x000000018CB21594
		private void PlayTypeSound(); // 0x000000018CB221AC-0x000000018CB22298
		[IteratorStateMachine(typeof(_CheckInput_d__33))]
		private IEnumerator CheckInput(Action Do); // 0x000000018CB20FE0-0x000000018CB21058
		[IteratorStateMachine(typeof(_DelayPrint_d__34))]
		private IEnumerator DelayPrint(float time); // 0x000000018CB210D0-0x000000018CB21128
		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info); // 0x000000018CB21920-0x000000018CB22188
		[IteratorStateMachine(typeof(_CountDown_d__36))]
		private IEnumerator CountDown(MultipleChoiceRequestInfo info); // 0x000000018CB21058-0x000000018CB210D0
		private void Finalize(MultipleChoiceRequestInfo info, int index); // 0x000000018CB21128-0x000000018CB21424
		private void SetMassAlpha(RectTransform root, float alpha); // 0x000000018CB22298-0x000000018CB22334
	}
}

namespace NodeCanvas.Framework
{
	[AttributeUsage(AttributeTargets.Class)]
	public class GraphInfoAttribute : Attribute // TypeDefIndex: 77167
	{
		// Fields
		public string packageName; // 0x10
		public string docsURL; // 0x18
		public string resourcesURL; // 0x20
		public string forumsURL; // 0x28
	
		// Constructors
		public GraphInfoAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DropReferenceType : Attribute // TypeDefIndex: 77168
	{
		// Fields
		public readonly System.Type type; // 0x10
	
		// Constructors
		public DropReferenceType(System.Type type); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class BlackboardOnlyAttribute : Attribute // TypeDefIndex: 77169
	{
		// Constructors
		public BlackboardOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class LogTag // TypeDefIndex: 77170
	{
		// Fields
		public const string EDITOR = "Editor"; // Metadata: 0x02629D84
		public const string EVENT = "Event"; // Metadata: 0x02629D8B
		public const string EXECUTION = "Execution"; // Metadata: 0x02629D91
		public const string VARIABLE = "Variable"; // Metadata: 0x02629D9B
		public const string BLACKBOARD = "Blackboard"; // Metadata: 0x02629DA4
		public const string GRAPH = "Graph"; // Metadata: 0x02629DAF
		public const string INIT = "Initialization"; // Metadata: 0x02629DB5
		public const string VALIDATION = "Validation"; // Metadata: 0x02629DC4
		public const string SERIALIZATION = "Serialization"; // Metadata: 0x02629DCF
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/CanvasCore/Signal Definition")]
	public class SignalDefinition : ScriptableObject // TypeDefIndex: 77173
	{
		// Fields
		[CompilerGenerated]
		private InvokeArguments onInvoke; // 0x18
		[HideInInspector]
		[SerializeField]
		private List<DynamicParameterDefinition> _parameters; // 0x20
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get; private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Events
		public event InvokeArguments onInvoke {
			add; // 0x000000018CB2C610-0x000000018CB2C6A4
			remove; // 0x000000018CB2C6A4-0x000000018CB2C738
		}
	
		// Nested types
		public delegate void InvokeArguments(Transform sender, Transform receiver, bool isGlobal, params object[] args); // TypeDefIndex: 77171; 0x00000001811CDB70-0x00000001811CDB90
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 77172
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveParameter_b__0(DynamicParameterDefinition p); // 0x000000018CA8B818-0x000000018CA8B840
		}
	
		// Constructors
		public SignalDefinition(); // 0x000000018CB2C590-0x000000018CB2C610
	
		// Methods
		public void Invoke(Transform sender, Transform receiver, bool isGlobal, params object[] args); // 0x000000018CB2C454-0x000000018CB2C488
		public void AddParameter(string name, System.Type type); // 0x000000018CB2C3B8-0x000000018CB2C454
		public void RemoveParameter(string name); // 0x000000018CB2C488-0x000000018CB2C590
	}

	[Serializable]
	public class CanvasGroup // TypeDefIndex: 77174
	{
		// Fields
		public string name; // 0x10
		public Rect rect; // 0x18
		public UnityEngine.Color color; // 0x28
		public bool autoGroup; // 0x38
	
		// Constructors
		public CanvasGroup(); // 0x0000000186805BA0-0x0000000186805BB0
		public CanvasGroup(Rect rect, string name); // 0x000000018CB1D3E4-0x000000018CB1D3F8
	}

	[Serializable]
	[fsDeserializeOverwrite]
	[SpoofAOT]
	public abstract class Connection : IGraphElement, ISerializationCollectable // TypeDefIndex: 77175
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
		public string UID { get; } // 0x000000018CB1E898-0x000000018CB1E91C 
		public NodeCanvas.Framework.Node sourceNode { get; protected set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public NodeCanvas.Framework.Node targetNode { get; protected set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		string IGraphElement.name { get; } // 0x000000018CB1E20C-0x000000018CB1E238 
		public bool isActive { get; set; } // 0x00000001852A8620-0x00000001852A8630 0x000000018CB1E930-0x000000018CB1E964
		public NodeCanvas.Framework.Status status { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public NodeCanvas.Framework.Graph graph { get; } // 0x000000018CB1E91C-0x000000018CB1E930 
		public virtual bool drawInspector { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public Connection(); // 0x0000000187240330-0x0000000187240340
	
		// Methods
		public static Connection Create(NodeCanvas.Framework.Node source, NodeCanvas.Framework.Node target, int sourceIndex = -1 /* Metadata: 0x02629DDD */, int targetIndex = -1 /* Metadata: 0x02629DDE */); // 0x000000018CB1DE40-0x000000018CB1DF3C
		public Connection Duplicate(NodeCanvas.Framework.Node newSource, NodeCanvas.Framework.Node newTarget); // 0x000000018CB1DF3C-0x000000018CB1E20C
		public int SetSourceNode(NodeCanvas.Framework.Node newSource, int index = -1 /* Metadata: 0x02629DDF */, bool recodeUndo = true /* Metadata: 0x02629DE0 */); // 0x000000018CB1E428-0x000000018CB1E5C8
		public int SetTargetNode(NodeCanvas.Framework.Node newTarget, int index = -1 /* Metadata: 0x02629DE1 */, bool recodeUndo = true /* Metadata: 0x02629DE2 */); // 0x000000018CB1E5C8-0x000000018CB1E848
		public int SetRawSourceNode(NodeCanvas.Framework.Node newSource); // 0x000000018CB1E238-0x000000018CB1E330
		public int SetRawTargetNode(NodeCanvas.Framework.Node newTarget); // 0x000000018CB1E330-0x000000018CB1E428
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard); // 0x00000001852A8540-0x00000001852A8580
		public void Reset(bool recursively = true /* Metadata: 0x02629DE3 */); // 0x00000001852A8AB0-0x00000001852A8AF0
		public virtual void OnCreate(int sourceIndex, int targetIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnValidate(int sourceIndex, int targetIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnDestroyAfterConnectionRemoved(); // 0x0000000186805BA0-0x0000000186805BB0
		public override string ToString(); // 0x000000018CB1E848-0x000000018CB1E898
	}

	[SpoofAOT]
	public abstract class ExposedParameter // TypeDefIndex: 77176
	{
		// Properties
		public abstract string targetVariableID { get; }
		public abstract System.Type type { get; }
		public abstract object valueBoxed { get; set; }
		public abstract Variable varRefBoxed { get; }
	
		// Constructors
		protected ExposedParameter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void Bind(IBlackboard blackboard);
		public abstract void UnBind();
		public static ExposedParameter CreateInstance(Variable target); // 0x000000018CB22A54-0x000000018CB22B84
	}

	public sealed class ExposedParameter<T> : ExposedParameter // TypeDefIndex: 77177
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
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver, IStringCompressProcessor // TypeDefIndex: 77192
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
		public virtual bool allowRuntimeSerialization { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual bool dontSerializeBinderConnectionGenericType { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public bool isDeserialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233610-0x0000000187233620 0x0000000187233640-0x0000000187233650
		public abstract bool canDelayDeserializeAndOptimizeClone { get; }
		public bool graphValidateDirty { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233620-0x0000000187233630 0x0000000187233650-0x0000000187233660
		private bool hasInitialized { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
		private HierarchyTree.Element flatMetaGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		private HierarchyTree.Element fullMetaGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		private HierarchyTree.Element nestedMetaGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public abstract System.Type baseNodeType { get; }
		public abstract bool requiresAgent { get; }
		public abstract bool requiresPrimeNode { get; }
		public abstract bool isTree { get; }
		public abstract bool allowBlackboardOverrides { get; }
		public abstract bool canAcceptVariableDrops { get; }
		private GraphSource graphSource { get; set; } // 0x00000001852A78A0-0x00000001852A78C0 0x000000018783BA80-0x000000018783BA90
		public string category { get; set; } // 0x000000018CB271B0-0x000000018CB271D0 0x000000018CB27564-0x000000018CB27594
		public string comments { get; set; } // 0x000000018CB271D0-0x000000018CB271F0 0x000000018CB27594-0x000000018CB275C4
		public Vector2 translation { get; set; } // 0x000000018CB272CC-0x000000018CB272FC 0x000000018CB27738-0x000000018CB27770
		public float zoomFactor { get; set; } // 0x000000018CB272FC-0x000000018CB2731C 0x000000018CB27770-0x000000018CB277A0
		public List<NodeCanvas.Framework.Node> allNodes { get; set; } // 0x00000001852A7880-0x00000001852A78A0 0x000000018CB27504-0x000000018CB27534
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x000000018CB27190-0x000000018CB271B0 0x000000018CB27534-0x000000018CB27564
		private BlackboardSource localBlackboard { get; set; } // 0x00000001852A7770-0x00000001852A7790 0x000000018CB275C4-0x000000018CB275F4
		private List<BBParameter> allParameters { get; } // 0x00000001852A7860-0x00000001852A7880 
		public List<NodeCanvas.Framework.Task> allTasks { get; } // 0x00000001852A7130-0x00000001852A7150 
		public List<Connection> allConnections { get; } // 0x000000018CB27170-0x000000018CB27190 
		public Graph rootGraph { get; } // 0x000000018CB27210-0x000000018CB2727C 
		public bool serializationHalted { get; } // 0x000000018225E070-0x000000018225E080 
		public static IEnumerable<Graph> runningGraphs { get; } // 0x000000018CB2727C-0x000000018CB272CC 
		public Graph parentGraph { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public float elapsedTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E550-0x000000018723E560 0x000000018723E540-0x000000018723E550
		public float deltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187253CF0-0x0000000187253D00 0x0000000187253D00-0x0000000187253D10
		public int lastUpdateFrame { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233090-0x00000001872330A0 0x0000000187233100-0x0000000187233110
		public bool didUpdateLastFrame { get; } // 0x000000018CB271F0-0x000000018CB27210 
		public bool isRunning { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271C00-0x0000000182271C10 0x0000000182271C10-0x0000000182271C20
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E890-0x0000000184D8E8A0 0x0000000184D8E8A0-0x0000000184D8E8B0
		public UpdateMode updateMode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233080-0x0000000187233090 0x00000001872330F0-0x0000000187233100
		public NodeCanvas.Framework.Node primeNode { get; set; } // 0x00000001852A69E0-0x00000001852A6A50 0x000000018CB275F4-0x000000018CB27738
		public Component agent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		public IBlackboard blackboard { get; } // 0x0000000187835948-0x0000000187835950 
		public IBlackboard parentBlackboard { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
	
		// Events
		public static event Action<Graph> onGraphSerialized {
			add; // 0x000000018CB270AC-0x000000018CB27170
			remove; // 0x000000018CB27440-0x000000018CB27504
		}
		public event Action<bool> onFinish {
			add; // 0x000000018CB27020-0x000000018CB270AC
			remove; // 0x000000018CB273B4-0x000000018CB27440
		}
		private event Action delayedInitCalls {
			add; // 0x000000018CB26F88-0x000000018CB27020
			remove; // 0x000000018CB2731C-0x000000018CB273B4
		}
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 77178
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2,
			Manual = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77179
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<NodeCanvas.Framework.Node, int> __9__174_0; // 0x08
			public static Func<NodeCanvas.Framework.Node, bool> __9__218_0; // 0x10
			public static Func<NodeCanvas.Framework.Node, bool> __9__219_0; // 0x18
			public static Func<BBParameter, bool> __9__222_0; // 0x20
	
			// Constructors
			static __c(); // 0x000000018CB3E388-0x000000018CB3E3EC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _UpdateNodeIDs_b__174_0(NodeCanvas.Framework.Node n); // 0x000000018CB3DCF0-0x000000018CB3DD5C
			internal bool _GetRootNodes_b__218_0(NodeCanvas.Framework.Node n); // 0x000000018CB3DCA8-0x000000018CB3DCF0
			internal bool _GetLeafNodes_b__219_0(NodeCanvas.Framework.Node n); // 0x000000018CB3DC60-0x000000018CB3DCA8
			internal bool _GetDefinedParameters_b__222_0(BBParameter p); // 0x000000018CB3DC48-0x000000018CB3DC60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass182_0 // TypeDefIndex: 77180
		{
			// Fields
			public Graph __4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public __c__DisplayClass182_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadOverwriteAsync_b__0(); // 0x000000018CB3DE6C-0x000000018CB3DEB0
		}
	
		[CompilerGenerated]
		private struct _LoadOverwriteAsync_d__182 : IAsyncStateMachine // TypeDefIndex: 77181
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Graph __4__this; // 0x28
			public GraphLoadData data; // 0x30
			public Action callback; // 0x60
			private TaskAwaiter __u__1; // 0x68
	
			// Methods
			private void MoveNext(); // 0x000000018CB3D9E4-0x000000018CB3DC48
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass183_0 // TypeDefIndex: 77182
		{
			// Fields
			public Graph __4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public __c__DisplayClass183_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadOverwrite_b__0(); // 0x000000018CB3DEB0-0x000000018CB3DEE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass213_0 // TypeDefIndex: 77183
		{
			// Fields
			public int searchID; // 0x10
	
			// Constructors
			public __c__DisplayClass213_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetNodeWithID_b__0(NodeCanvas.Framework.Node n); // 0x000000018CB3DEE8-0x000000018CB3DF08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass215_0<T> // TypeDefIndex: 77184
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
		private sealed class __c__DisplayClass216_0<T> // TypeDefIndex: 77185
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
		private sealed class __c__217<T> // TypeDefIndex: 77186
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
		private sealed class __c__DisplayClass230_0 // TypeDefIndex: 77187
		{
			// Fields
			public Stack<HierarchyTree.Element> stack; // 0x10
			public HierarchyTree.Element parentElement; // 0x18
	
			// Constructors
			public __c__DisplayClass230_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CollectSubElements_b__0(object o); // 0x000000018CB3DF08-0x000000018CB3E000
			internal void _CollectSubElements_b__1(object o, fsData d); // 0x000000018CB3E000-0x000000018CB3E080
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass233_0 // TypeDefIndex: 77188
		{
			// Fields
			public List<NodeCanvas.Framework.Task> result; // 0x10
	
			// Constructors
			public __c__DisplayClass233_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetTasksInElement_b__0(object o, fsData d); // 0x000000018CB3E080-0x000000018CB3E114
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass234_0 // TypeDefIndex: 77189
		{
			// Fields
			public List<BBParameter> result; // 0x10
	
			// Constructors
			public __c__DisplayClass234_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetParametersInElement_b__0(object o, fsData d); // 0x000000018CB3E114-0x000000018CB3E1A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass239_0 // TypeDefIndex: 77190
		{
			// Fields
			public NodeCanvas.Framework.Node node; // 0x10
	
			// Constructors
			public __c__DisplayClass239_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveNode_b__0(NodeCanvas.Framework.Node n); // 0x000000018CB3E1A8-0x000000018CB3E228
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass242_0 // TypeDefIndex: 77191
		{
			// Fields
			public Graph targetGraph; // 0x10
	
			// Constructors
			public __c__DisplayClass242_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CloneNodes_b__0(NodeCanvas.Framework.Node n); // 0x000000018CB3E228-0x000000018CB3E288
		}
	
		// Constructors
		protected Graph(); // 0x00000001859591B0-0x0000000185959220
		static Graph(); // 0x000000018716F090-0x000000018716F130
	
		// Methods
		public virtual Rect DrawCustomBlackboardPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos); // 0x0000000184591DC0-0x0000000184591DD0
		public virtual Rect DrawCustomPanel(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos); // 0x0000000184591DC0-0x0000000184591DD0
		public virtual Rect DrawCustomPanel2(UnityEngine.Event e, Rect canvasRect, Vector2 canvasMousePos); // 0x0000000184591DC0-0x0000000184591DD0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB26B1C-0x000000018CB26B30
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186E676C0-0x0000000186E67730
		public void TryDeserializeIfNot(); // 0x00000001852A78C0-0x00000001852A78E0
		protected void OnEnable(); // 0x000000018709CBE0-0x000000018709CC00
		protected void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void OnDestroy(); // 0x0000000186D0A040-0x0000000186D0A0A0
		protected void OnValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void Reset(); // 0x000000018CB260F0-0x000000018CB26100
		public bool SelfSerialize(bool ignoreScene = false /* Metadata: 0x02629DE4 */); // 0x000000018CB263DC-0x000000018CB26568
		protected virtual void OnAfterGraphSerialized(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool SelfDeserialize(); // 0x000000018CB2633C-0x000000018CB263DC
		public string Serialize(List<UnityEngine.Object> references); // 0x000000018CB2692C-0x000000018CB26A48
		public bool Deserialize(string serializedGraph, List<UnityEngine.Object> references, bool validate); // 0x00000001852A4C30-0x00000001852A5030
		public bool DeserializeSelf(List<UnityEngine.Object> references, bool validate); // 0x00000001859FDB30-0x00000001859FDD20
		public GraphSource GetGraphSource(); // 0x000000018CB24924-0x000000018CB24940
		public string GetSerializedJsonData(); // 0x000000018CB24EF0-0x000000018CB24F08
		public int GetSerializedJsonDataStringIndex(); // 0x00000001859FE2C0-0x00000001859FE320
		public bool DeserializeFromGraph(Graph other, bool validate = true /* Metadata: 0x02629DE5 */); // 0x00000001859FE130-0x00000001859FE270
		public DataCompressManager.StringCompressUnsafeString GetSerializedJsonDataUnsafeString(); // 0x000000018CB24EA4-0x000000018CB24EF0
		public void ClearSerializedJsonData(); // 0x0000000187838E10-0x0000000187838E24
		public List<UnityEngine.Object> GetSerializedReferencesData(); // 0x00000001859FE270-0x00000001859FE2C0
		public GraphSource GetGraphSourceMetaDataCopy(); // 0x000000018CB248B4-0x000000018CB24924
		public void SetGraphSourceMetaData(GraphSource source); // 0x000000018CB26A48-0x000000018CB26A78
		public string SerializeLocalBlackboard(ref List<UnityEngine.Object> references); // 0x000000018CB26850-0x000000018CB2692C
		public bool DeserializeLocalBlackboard(string json, List<UnityEngine.Object> references); // 0x000000018CB24098-0x000000018CB24130
		public static T Clone<T>(T graph, Graph parentGraph)
			where T : Graph;
		public void Validate(); // 0x00000001859FCBA0-0x00000001859FCC60
		public void UpdateReferencesFromOwner(GraphOwner owner, bool force = false /* Metadata: 0x02629DE6 */); // 0x000000018CB26EEC-0x000000018CB26F88
		public void UpdateReferences(Component newAgent, IBlackboard newParentBlackboard, bool force = false /* Metadata: 0x02629DE7 */); // 0x00000001852A61B0-0x00000001852A6440
		private void UpdateNodeBBFields(); // 0x00000001852A7790-0x00000001852A7860
		void ITaskSystem.UpdateTasksOwner(); // 0x00000001852A7080-0x00000001852A7130
		public void UpdateNodeIDs(bool alsoReorderList); // 0x000000018CB26B54-0x000000018CB26EEC
		public virtual void OnGraphStructureChange(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterUpdateNodeIDs(); // 0x0000000186805BA0-0x0000000186805BB0
		private int AssignNodeID(NodeCanvas.Framework.Node node, int lastID, ref NodeCanvas.Framework.Node[] parsed); // 0x000000018CB232BC-0x000000018CB233E0
		protected void ThreadSafeInitCall(Action call); // 0x000000018CB26AA8-0x000000018CB26B1C
		public async void LoadOverwriteAsync(GraphLoadData data, Action callback); // 0x000000018CB2521C-0x000000018CB252FC
		public void LoadOverwrite(GraphLoadData data); // 0x000000018CB252FC-0x000000018CB25484
		public void Initialize(Component newAgent, IBlackboard newParentBlackboard, bool preInitializeSubGraphs); // 0x0000000186C6B4B0-0x0000000186C6B520
		private void PreInitializeSubGraphs(); // 0x000000018CB25608-0x000000018CB25924
		public void StartGraph(Component newAgent, IBlackboard newParentBlackboard, UpdateMode newUpdateMode, Action<bool> callback = null); // 0x00000001852A7150-0x00000001852A74D0
		public void ClearGraphData(); // 0x00000001852A6A50-0x00000001852A7080
		public void Stop(bool success = true /* Metadata: 0x02629DE8 */); // 0x00000001852A74D0-0x00000001852A7770
		public void Pause(); // 0x000000018CB25484-0x000000018CB25608
		public void Resume(); // 0x000000018CB2615C-0x000000018CB2633C
		public void Restart(); // 0x000000018CB26100-0x000000018CB2615C
		public void UpdateGraph(); // 0x000000018CB26B30-0x000000018CB26B54
		public void UpdateGraph(float deltaTime); // 0x0000000186629320-0x0000000186629370
		public virtual object OnDerivedDataSerialization(); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual void OnDerivedDataDeserialization(object data); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphInitialize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphStarted(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphStoped(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphPaused(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphUnpaused(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphObjectEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphObjectDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphObjectDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnGraphValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		public void SendEvent(string name, object value, object sender); // 0x000000018CB26568-0x000000018CB26658
		public void SendEvent<T>(string name, T value, object sender);
		public static void SendGlobalEvent(string name, object value, object sender); // 0x000000018CB26658-0x000000018CB26850
		public static void SendGlobalEvent<T>(string name, T value, object sender);
		public IEnumerable<BBParameter> GetAllParameters(); // 0x000000018CB242C0-0x000000018CB242C8
		public IEnumerable<Connection> GetAllConnections(); // 0x000000018CB242B8-0x000000018CB242C0
		public IEnumerable<T> GetAllTasksOfType<T>()
			where T : NodeCanvas.Framework.Task;
		public NodeCanvas.Framework.Node GetNodeWithID(int searchID); // 0x000000018CB24AF4-0x000000018CB24BEC
		public IEnumerable<T> GetAllNodesOfType<T>()
			where T : NodeCanvas.Framework.Node;
		public T GetNodeWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node;
		public IEnumerable<T> GetNodesWithTag<T>(string tagName)
			where T : NodeCanvas.Framework.Node;
		public IEnumerable<T> GetAllTagedNodes<T>()
			where T : NodeCanvas.Framework.Node;
		public IEnumerable<NodeCanvas.Framework.Node> GetRootNodes(); // 0x000000018CB24D90-0x000000018CB24EA4
		public IEnumerable<NodeCanvas.Framework.Node> GetLeafNodes(); // 0x000000018CB24940-0x000000018CB24A54
		public IEnumerable<T> GetAllNestedGraphs<T>(bool recursive)
			where T : Graph;
		public IEnumerable<Graph> GetAllInstancedNestedGraphs(); // 0x0000000185A00AF0-0x0000000185A01100
		public IEnumerable<BBParameter> GetDefinedParameters(); // 0x000000018CB242C8-0x000000018CB243DC
		public void PromoteMissingParametersToVariables(IBlackboard bb); // 0x000000018CB25988-0x000000018CB25AE8
		public static Graph GetElementGraph(object obj); // 0x000000018CB243DC-0x000000018CB245D4
		public HierarchyTree.Element GetFlatMetaGraph(); // 0x000000018CB245D4-0x000000018CB24708
		public HierarchyTree.Element GetFullMetaGraph(); // 0x000000018CB24708-0x000000018CB248B4
		public HierarchyTree.Element GetNestedMetaGraph(); // 0x000000018CB24A54-0x000000018CB24AF4
		private static void DigNestedGraphs(Graph currentGraph, HierarchyTree.Element currentElement); // 0x000000018CB24130-0x000000018CB242B8
		private static HierarchyTree.Element GetTreeNodeElement(NodeCanvas.Framework.Node node, bool recurse, ref int lastID); // 0x000000018CB250AC-0x000000018CB2521C
		private static HierarchyTree.Element CollectSubElements(IGraphElement obj); // 0x000000018CB23E78-0x000000018CB24018
		public IGraphElement GetTaskParentElement(NodeCanvas.Framework.Task targetTask); // 0x000000018CB24F08-0x000000018CB24F78
		public IGraphElement GetParameterParentElement(BBParameter targetParameter); // 0x000000018CB24BEC-0x000000018CB24C5C
		public static IEnumerable<NodeCanvas.Framework.Task> GetTasksInElement(IGraphElement target); // 0x000000018CB24F78-0x000000018CB250AC
		public static IEnumerable<BBParameter> GetParametersInElement(IGraphElement target); // 0x000000018CB24C5C-0x000000018CB24D90
		public T AddNode<T>()
			where T : NodeCanvas.Framework.Node;
		public T AddNode<T>(Vector2 pos)
			where T : NodeCanvas.Framework.Node;
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType); // 0x000000018CB23244-0x000000018CB232BC
		public NodeCanvas.Framework.Node AddNode(System.Type nodeType, Vector2 pos); // 0x000000018CB2314C-0x000000018CB23244
		public void RemoveNode(NodeCanvas.Framework.Node node, bool recordUndo = true /* Metadata: 0x02629DE9 */, bool force = false /* Metadata: 0x02629DEA */); // 0x000000018CB25CA0-0x000000018CB260F0
		public Connection ConnectNodes(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, int sourceIndex = -1 /* Metadata: 0x02629DEB */, int targetIndex = -1 /* Metadata: 0x02629DEC */); // 0x000000018CB24018-0x000000018CB24098
		public void RemoveConnection(Connection connection, bool recordUndo = true /* Metadata: 0x02629DED */, bool invokeGraphChanged = true /* Metadata: 0x02629DEE */); // 0x000000018CB25AE8-0x000000018CB25CA0
		public static List<NodeCanvas.Framework.Node> CloneNodes(List<NodeCanvas.Framework.Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default); // 0x000000018CB23588-0x000000018CB23E78
		public void ClearGraph(); // 0x000000018CB234D0-0x000000018CB23588
		[Obsolete("Use \'Graph.StartGraph\' with the \'Graph.UpdateMode\' parameter.")]
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null); // 0x000000018CB26A78-0x000000018CB26AA8
		public void ProcessStringCompress(StringCompressVisitor visitor); // 0x000000018CB25924-0x000000018CB25988
		public bool CheckStringCompress(); // 0x000000018CB233E0-0x000000018CB234D0
	}

	public abstract class GraphOwner : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 77204
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
		public List<ExposedParameter> exposedParameters { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public abstract NodeCanvas.Framework.Graph graph { get; set; }
		public abstract IBlackboard blackboard { get; set; }
		public abstract System.Type graphType { get; }
		public bool initialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A20-0x0000000182271A30 0x0000000182271A30-0x0000000182271A40
		public bool enableCalled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235F80-0x0000000187235F90 0x0000000187235F90-0x0000000187235FA0
		public bool startCalled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182909630-0x0000000182909640 0x0000000182909640-0x0000000182909650
		public GraphSource boundGraphSource { get; private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public string boundGraphSerialization { get; protected set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public List<UnityEngine.Object> boundGraphObjectReferences { get; private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public bool lockBoundGraphPrefabOverrides { get; set; } // 0x000000018CB33A14-0x000000018CB33A28 0x000000018225DFA0-0x000000018225DFB0
		public bool lockBoundGraphFromInstance { get; set; } // 0x0000000187253800-0x0000000187253810 0x0000000187253840-0x0000000187253850
		public bool preInitializeSubGraphs { get; set; } // 0x0000000187253820-0x0000000187253830 0x0000000187253860-0x0000000187253870
		public FirstActivation firstActivation { get; set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public EnableAction enableAction { get; set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public DisableAction disableAction { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public NodeCanvas.Framework.Graph.UpdateMode updateMode { get; set; } // 0x00000001872332A0-0x00000001872332B0 0x0000000185FF5E70-0x0000000185FF5F30
		public bool graphIsBound { get; } // 0x0000000187067010-0x0000000187067030 
		public bool isRunning { get; } // 0x0000000185D6F290-0x0000000185D6F340 
		public bool isPaused { get; } // 0x0000000185D6F1E0-0x0000000185D6F290 
		public float elapsedTime { get; } // 0x000000018CB33990-0x000000018CB33A14 
		public virtual bool canEditNonPersistantBoundGraph { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Events
		public event Action onMonoBehaviourStart {
			add; // 0x000000018CB338FC-0x000000018CB33990
			remove; // 0x000000018CB33A28-0x000000018CB33ABC
		}
	
		// Nested types
		public enum EnableAction // TypeDefIndex: 77193
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}
	
		public enum DisableAction // TypeDefIndex: 77194
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}
	
		public enum FirstActivation // TypeDefIndex: 77195
		{
			OnEnable = 0,
			OnStart = 1,
			Async = 2
		}
	
		public class SubInfo // TypeDefIndex: 77196
		{
			// Fields
			public NodeCanvas.Framework.Graph graph; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public NodeCanvas.Framework.Graph parentGraph; // 0x20
			public string name; // 0x28
			public IGraphAssignable assignable; // 0x30
			public bool isSuc; // 0x38
	
			// Constructors
			public SubInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0 // TypeDefIndex: 77197
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public Action callBack; // 0x18
			public Action __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass95_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _StartBehaviourAsync_b__0(NodeCanvas.Framework.Graph instance); // 0x0000000186AF57B0-0x0000000186AF5900
			internal void _StartBehaviourAsync_b__1(); // 0x0000000186BE8940-0x0000000186BE8A20
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0 // TypeDefIndex: 77198
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public NodeCanvas.Framework.Graph originalGraph; // 0x18
			public bool isSuc; // 0x20
			public NodeCanvas.Framework.Graph clone; // 0x28
	
			// Constructors
			public __c__DisplayClass96_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetInstanceAsync_b__0(); // 0x00000001859FCB50-0x00000001859FCBA0
		}
	
		[CompilerGenerated]
		private struct _GetInstanceAsync_d__96 : IAsyncStateMachine // TypeDefIndex: 77199
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
			private void MoveNext(); // 0x00000001859FCC60-0x00000001859FD310
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0 // TypeDefIndex: 77200
		{
			// Fields
			public GraphOwner __4__this; // 0x10
			public List<SubInfo> subInfos; // 0x18
	
			// Constructors
			public __c__DisplayClass97_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CreateSubInstanceAsync_b__0(); // 0x00000001859FEBE0-0x00000001859FECF0
		}
	
		[CompilerGenerated]
		private struct _CreateSubInstanceAsync_d__97 : IAsyncStateMachine // TypeDefIndex: 77201
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
			private void MoveNext(); // 0x00000001859FECF0-0x0000000185A00AF0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0<T> // TypeDefIndex: 77202
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal bool _GetExposedParameterValue_b__0(ExposedParameter x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_0<T> // TypeDefIndex: 77203
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass106_0();
	
			// Methods
			internal bool _SetExposedParameterValue_b__0(ExposedParameter x);
		}
	
		// Constructors
		protected GraphOwner(); // 0x0000000185958E50-0x0000000185958F30
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB336CC-0x000000018CB33878
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB33570-0x000000018CB336CC
		protected virtual void OnBeforeSerializeDoExtra(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterDeserializeDoExtra(); // 0x0000000186805BA0-0x0000000186805BB0
		protected NodeCanvas.Framework.Graph GetInstance(NodeCanvas.Framework.Graph originalGraph); // 0x0000000185D6F880-0x0000000185D6F9B0
		public NodeCanvas.Framework.Graph MakeRuntimeGraphInstance(); // 0x000000018CB331B8-0x000000018CB33204
		public void StartBehaviour(); // 0x0000000185D6E8F0-0x0000000185D6E900
		public void StartBehaviour(Action<bool> callback); // 0x000000018CB33474-0x000000018CB33484
		public void StartBehaviour(NodeCanvas.Framework.Graph.UpdateMode updateMode, Action<bool> callback = null); // 0x0000000185D6EBC0-0x0000000185D6ED30
		public void PauseBehaviour(); // 0x000000018CB33238-0x000000018CB332EC
		public void StartBehaviourAsync(Action callBack); // 0x0000000185D6CDC0-0x0000000185D6CEB0
		protected async void GetInstanceAsync(NodeCanvas.Framework.Graph originalGraph, Action<NodeCanvas.Framework.Graph> callBack); // 0x0000000185D6CEB0-0x0000000185D6CFA0
		public async void CreateSubInstanceAsync(Action callBack); // 0x0000000186AF5900-0x0000000186AF5B10
		public void StopBehaviour(bool success = true /* Metadata: 0x02629DF3 */); // 0x0000000185D6EE10-0x0000000185D6EEF0
		public void UpdateBehaviour(); // 0x000000018CB33878-0x000000018CB338FC
		public void RestartBehaviour(); // 0x000000018CB332EC-0x000000018CB33318
		public void SendEvent(string eventName); // 0x000000018CB333D4-0x000000018CB33474
		public void SendEvent(string eventName, object value, object sender); // 0x000000018CB33318-0x000000018CB333D4
		public void SendEvent<T>(string eventName, T eventValue, object sender);
		public T GetExposedParameterValue<T>(string name);
		public void SetExposedParameterValue<T>(string name, T value);
		public ExposedParameter MakeNewExposedParameter<T>(string name);
		protected virtual void Awake(); // 0x0000000187066EF0-0x0000000187066F00
		public void Initialize(); // 0x0000000187066F00-0x0000000187067010
		public void BindExposedParameters(); // 0x000000018CB330C8-0x000000018CB331B8
		public void UnBindExposedParameters(); // 0x000000018CB334EC-0x000000018CB33570
		protected virtual void OnEnable(); // 0x0000000185D6CC30-0x0000000185D6CC80
		protected virtual void Start(); // 0x000000018721E600-0x000000018721E630
		private void InvokeStartEvent(); // 0x000000018721E630-0x000000018721E650
		protected virtual void OnDisable(); // 0x000000018CB33204-0x000000018CB33238
		public void DestroyInstance(); // 0x0000000185A01810-0x0000000185A01870
		protected virtual void OnDestroy(); // 0x0000000185A01100-0x0000000185A01510
		[CompilerGenerated]
		private void _Initialize_b__109_0(); // 0x000000018CB33484-0x000000018CB334EC
	}

	public abstract class GraphOwner<T> : GraphOwner // TypeDefIndex: 77205
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

	public static class IGraphAssignableExtensions // TypeDefIndex: 77207
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 77206
		{
			// Fields
			public IGraphAssignable assignable; // 0x10
			public Action<bool> callback; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _TryStartSubGraph_b__0(bool result); // 0x0000000186C9B340-0x0000000186C9B3C0
		}
	
		// Extension methods
		public static NodeCanvas.Framework.Graph CheckInstance(this IGraphAssignable assignable); // 0x00000001852A3A70-0x00000001852A3BE0
		public static bool TryStartSubGraph(this IGraphAssignable assignable, Component agent, Action<bool> callback = null); // 0x00000001852A3BE0-0x00000001852A3E00
		public static bool TryStopSubGraph(this IGraphAssignable assignable); // 0x00000001852A4A40-0x00000001852A4AF0
		public static bool TryClearSubGraphData(this IGraphAssignable assignable); // 0x00000001852A4750-0x00000001852A4840
		public static bool TryPauseSubGraph(this IGraphAssignable assignable); // 0x000000018CB346BC-0x000000018CB34740
		public static bool TryResumeSubGraph(this IGraphAssignable assignable); // 0x000000018CB34740-0x000000018CB347C4
		public static bool TryUpdateSubGraph(this IGraphAssignable assignable); // 0x000000018CB347C4-0x000000018CB34874
		public static void TryWriteAndBindMappedVariables(this IGraphAssignable assignable); // 0x00000001852A5370-0x00000001852A55C0
		public static void TryReadAndUnbindMappedVariables(this IGraphAssignable assignable); // 0x00000001852A51A0-0x00000001852A5370
		public static void ValidateSubGraphAndParameters(this IGraphAssignable assignable); // 0x000000018CB34874-0x000000018CB3496C
	}

	public interface IGraphElement // TypeDefIndex: 77208
	{
		// Properties
		string name { get; }
		string UID { get; }
		NodeCanvas.Framework.Graph graph { get; }
		NodeCanvas.Framework.Status status { get; }
	}

	public interface IUpdatable : IGraphElement // TypeDefIndex: 77209
	{
		// Methods
		void Update();
	}

	public interface IInvokable : IGraphElement // TypeDefIndex: 77210
	{
		// Methods
		string GetInvocationID();
		object Invoke(params object[] args);
		void InvokeAsync(Action<object> callback, params object[] args);
	}

	public interface IGraphAssignable : IGraphElement // TypeDefIndex: 77211
	{
		// Properties
		NodeCanvas.Framework.Graph subGraph { get; set; }
		NodeCanvas.Framework.Graph currentInstance { get; set; }
		Dictionary<NodeCanvas.Framework.Graph, NodeCanvas.Framework.Graph> instances { get; set; }
		BBParameter subGraphParameter { get; }
		List<BBMappingParameter> variablesMap { get; set; }
	}

	public interface IGraphAssignable<T> : IGraphAssignable // TypeDefIndex: 77212
		where T : NodeCanvas.Framework.Graph
	{
		// Properties
		T subGraph { get; set; }
		T currentInstance { get; set; }
	}

	public interface ITaskAssignable : IGraphElement // TypeDefIndex: 77213
	{
		// Properties
		NodeCanvas.Framework.Task task { get; set; }
	}

	public interface ITaskAssignable<T> : ITaskAssignable // TypeDefIndex: 77214
		where T : NodeCanvas.Framework.Task
	{
	}

	public interface IHaveNodeReference : IGraphElement // TypeDefIndex: 77215
	{
		// Properties
		INodeReference targetReference { get; }
	}

	public interface IReflectedWrapper // TypeDefIndex: 77216
	{
		// Methods
		ISerializedReflectedInfo GetSerializedInfo();
	}

	[Obsolete("This is no longer used nor required")]
	public interface ISubTasksContainer // TypeDefIndex: 77217
	{
		// Methods
		NodeCanvas.Framework.Task[] GetSubTasks();
	}

	[Obsolete("This is no longer used nor required")]
	public interface ISubParametersContainer // TypeDefIndex: 77218
	{
		// Methods
		BBParameter[] GetSubParameters();
	}

	[Serializable]
	[fsDeserializeOverwrite]
	[fsSerializeAsReference]
	[SpoofAOT]
	public abstract class Node : IGraphElement, ISerializationCollectable // TypeDefIndex: 77225
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
		protected virtual float? overrideNodeWidth { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public NodeCanvas.Framework.Graph graph { get; internal set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public int ID { get; internal set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public string UID { get; } // 0x000000018CB35DA8-0x000000018CB35DE0 
		public List<Connection> inConnections { get; protected set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public List<Connection> outConnections { get; protected set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public Vector2 position { get; set; } // 0x000000018724C750-0x000000018724C770 0x00000001855D8A60-0x00000001855D8A70
		private string customName { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string tag { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public string comments { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public string commentForShow { get; } // 0x0000000182986470-0x0000000182986480 
		public string rawComment { get; } // 0x0000000182986470-0x0000000182986480 
		public virtual bool modifyComment { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual string modifiedComment { get; } // 0x000000018CB35F98-0x000000018CB35FD0 
		public virtual bool isBreakpoint { get; set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public virtual string name { get; set; } // 0x000000018CB35FD0-0x000000018CB360C8 0x0000000187835950-0x0000000187835960
		public virtual string description { get; } // 0x000000018CB35DE0-0x000000018CB35E88 
		public virtual int priority { get; } // 0x000000018CB36170-0x000000018CB36208 
		public abstract int maxInConnections { get; }
		public abstract int maxOutConnections { get; }
		public abstract System.Type outConnectionType { get; }
		public abstract bool allowAsPrime { get; }
		public abstract bool canSelfConnect { get; }
		public abstract Alignment2x2 commentsAlignment { get; }
		public abstract Alignment2x2 iconAlignment { get; }
		public virtual bool isBeyondGraph { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool drawInspector { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual bool inspectorShowTag { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual bool allowResizeHorizontal { [CompilerGenerated] get; } // 0x000000018224EFC0-0x000000018224EFD0 
		public bool canResizeHorizontal { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236240-0x0000000187236250 0x0000000187254430-0x0000000187254440
		public bool resizingHorizontal { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235DC0-0x0000000187235DD0 0x0000000187254450-0x0000000187254460
		public virtual bool allowDragInContentRect { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual string nodeIconKey { get; } // 0x000000018CB36138-0x000000018CB36170 
		public virtual string nodeIconKey2 { get; } // 0x000000018CB360C8-0x000000018CB36100 
		public virtual string nodeIconKey3 { get; } // 0x000000018CB36100-0x000000018CB36138 
		public virtual bool isHighlight { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187254420-0x0000000187254430 0x0000000187254440-0x0000000187254450
		public virtual bool drawNameTagOrComment { get; } // 0x00000001851A4410-0x00000001851A4420 
		public NodeCanvas.Framework.Status status { get; protected set; } // 0x0000000182271AE0-0x0000000182271AF0 0x00000001852A85E0-0x00000001852A8620
		public Component graphAgent { get; } // 0x000000018CB35EB8-0x000000018CB35F28 
		public IBlackboard graphBlackboard { get; } // 0x000000018CB35F28-0x000000018CB35F98 
		public float elapsedTime { get; } // 0x000000018CB35E88-0x000000018CB35EB8 
		private float timeStarted { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B530-0x000000018723B540 0x000000018723B550-0x000000018723B560
		private bool isChecked { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EDA0-0x000000018226EDB0 0x000000018226EDB0-0x000000018226EDC0
		private bool breakPointReached { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235110-0x0000000187235120 0x0000000187235130-0x0000000187235140
	
		// Nested types
		[AttributeUsage(AttributeTargets.Field)]
		protected class AutoSortWithChildrenConnections : Attribute // TypeDefIndex: 77219
		{
			// Constructors
			public AutoSortWithChildrenConnections(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class _YieldBreak_d__137 : IEnumerator<object> // TypeDefIndex: 77220
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action resume; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _YieldBreak_d__137(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB3E3EC-0x000000018CB3E478
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB3E478-0x000000018CB3E4C4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass147_0 // TypeDefIndex: 77221
		{
			// Fields
			public Node b; // 0x10
			public Node a; // 0x18
	
			// Constructors
			public __c__DisplayClass147_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AreNodesConnected_b__0(Connection c); // 0x000000018CB3DDE4-0x000000018CB3DE04
			internal bool _AreNodesConnected_b__1(Connection c); // 0x000000018CB3DE04-0x000000018CB3DE24
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77222
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Connection, Node> __9__152_0; // 0x08
			public static Func<Connection, Node> __9__153_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018CB3E324-0x000000018CB3E388
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Node _GetParentNodes_b__152_0(Connection c); // 0x0000000188E4BE44-0x0000000188E4BE5C
			internal Node _GetChildNodes_b__153_0(Connection c); // 0x0000000188E4BE2C-0x0000000188E4BE44
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass154_0 // TypeDefIndex: 77223
		{
			// Fields
			public Node parentNode; // 0x10
	
			// Constructors
			public __c__DisplayClass154_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _IsChildOf_b__0(Connection c); // 0x000000018CB3DE4C-0x000000018CB3DE6C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass155_0 // TypeDefIndex: 77224
		{
			// Fields
			public Node childNode; // 0x10
	
			// Constructors
			public __c__DisplayClass155_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _IsParentOf_b__0(Connection c); // 0x000000018CB3DDE4-0x000000018CB3DE04
		}
	
		// Constructors
		public Node(); // 0x00000001865EF6C0-0x00000001865EF760
	
		// Methods
		protected virtual string AllocateUID(); // 0x000000018CB34AF4-0x000000018CB34B50
		public void SetUID(string value); // 0x0000000187835500-0x0000000187835510
		public static Node Create(NodeCanvas.Framework.Graph targetGraph, System.Type nodeType, Vector2 pos); // 0x000000018CB34CAC-0x000000018CB34E48
		public Node Duplicate(NodeCanvas.Framework.Graph targetGraph); // 0x000000018CB34E48-0x000000018CB351A8
		public void Validate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB35C4C-0x000000018CB35D4C
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard); // 0x00000001852A8580-0x00000001852A85E0
		public void Reset(bool recursively = true /* Metadata: 0x02629DFC */); // 0x00000001852A8230-0x00000001852A82D0
		[IteratorStateMachine(typeof(_YieldBreak_d__137))]
		private IEnumerator YieldBreak(Action resume); // 0x000000018CB35D4C-0x000000018CB35DA8
		public NodeCanvas.Framework.Status Error(object msg); // 0x000000018CB351A8-0x000000018CB3525C
		public NodeCanvas.Framework.Status Fail(string msg); // 0x000000018CB3525C-0x000000018CB35274
		public void Warn(string msg); // 0x0000000186805BA0-0x0000000186805BB0
		public void SetStatus(NodeCanvas.Framework.Status status); // 0x000000018CB0B418-0x000000018CB0B420
		protected void SendEvent(string eventName); // 0x000000018CB35934-0x000000018CB35964
		protected void SendEvent<T>(string eventName, T value);
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null); // 0x000000018CB3579C-0x000000018CB35868
		protected virtual bool CanConnectToTarget(Node targetNode); // 0x00000001851A4410-0x00000001851A4420
		protected virtual bool CanConnectFromSource(Node sourceNode); // 0x00000001851A4410-0x00000001851A4420
		public static bool AreNodesConnected(Node a, Node b); // 0x000000018CB34B50-0x000000018CB34CAC
		public Coroutine StartCoroutine(IEnumerator routine); // 0x000000018CB35964-0x000000018CB359E4
		public void StopCoroutine(Coroutine routine); // 0x000000018CB359E4-0x000000018CB35A60
		public void StartParallelTask(Action action); // 0x0000000186805BA0-0x0000000186805BB0
		public void StopParallelTask(Action action); // 0x0000000186805BA0-0x0000000186805BB0
		public IEnumerable<Node> GetParentNodes(); // 0x000000018CB354D8-0x000000018CB35620
		public IEnumerable<Node> GetChildNodes(); // 0x000000018CB35274-0x000000018CB353BC
		public bool IsChildOf(Node parentNode); // 0x000000018CB356D0-0x000000018CB3579C
		public bool IsParentOf(Node childNode); // 0x000000018CB35868-0x000000018CB35934
		internal virtual string GetWarningOrError(); // 0x000000018CB35620-0x000000018CB356D0
		private string GetHardError(); // 0x000000018CB353BC-0x000000018CB354D8
		protected virtual NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000182271AE0-0x0000000182271AF0
		protected virtual void OnReset(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnCreate(NodeCanvas.Framework.Graph assignedGraph); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnDuplicate(NodeCanvas.Framework.Graph assignedGraph); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnParentConnected(int connectionIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnParentDisconnected(int connectionIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnChildConnected(int connectionIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnChildDisconnected(int connectionIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnChildrenConnectionsSorted(int[] oldIndeces); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphStarted(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnPostGraphStarted(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphStoped(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnPostGraphStoped(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphPaused(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphUnpaused(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnClearNodeData(); // 0x0000000186805BA0-0x0000000186805BB0
		public override string ToString(); // 0x000000018CB35A60-0x000000018CB35C4C
	}

	public interface INodeReference // TypeDefIndex: 77226
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
	public class NodeReference<T> : INodeReference // TypeDefIndex: 77228
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
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 77227
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

	public enum Status // TypeDefIndex: 77229
	{
		Failure = 0,
		Success = 1,
		Running = 2,
		Resting = 3,
		Error = 4,
		Optional = 5
	}

	[DoNotList]
	public class ActionList : ActionTask // TypeDefIndex: 77231
	{
		// Fields
		public ActionsExecutionMode executionMode; // 0x68
		public List<ActionTask> actions; // 0x70
		private int currentActionIndex; // 0x78
		private bool[] finishedIndeces; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CB2FBFC-0x000000018CB2FDF8 
	
		// Nested types
		public enum ActionsExecutionMode // TypeDefIndex: 77230
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}
	
		// Constructors
		public ActionList(); // 0x000000018CB2FB7C-0x000000018CB2FBFC
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018CB2F3A0-0x000000018CB2F594
		protected override string OnInit(); // 0x000000018CB2F730-0x000000018CB2F79C
		protected override void OnExecute(); // 0x000000018CB2F6C0-0x000000018CB2F730
		protected override void OnUpdate(); // 0x000000018CB2F8F4-0x000000018CB2FB7C
		protected override void OnStop(); // 0x000000018CB2F840-0x000000018CB2F8F4
		protected override void OnPause(); // 0x000000018CB2F79C-0x000000018CB2F840
		public override void OnDrawGizmosSelected(); // 0x000000018CB2F618-0x000000018CB2F6C0
		public void AddAction(ActionTask action); // 0x000000018CB2F1A8-0x000000018CB2F3A0
		internal override string GetWarningOrError(); // 0x000000018CB2F594-0x000000018CB2F618
	}

	public abstract class ActionTask<T> : ActionTask // TypeDefIndex: 77232
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ActionTask();
	}

	public abstract class ActionTask : NodeCanvas.Framework.Task // TypeDefIndex: 77234
	{
		// Fields
		private NodeCanvas.Framework.Status status; // 0x58
		private float timeStarted; // 0x5C
		private bool latch; // 0x60
		[CompilerGenerated]
		private bool _isPaused_k__BackingField; // 0x61
	
		// Properties
		public float elapsedTime { get; } // 0x000000018581C790-0x000000018581C7D0 
		public bool isRunning { get; } // 0x000000018581D4A0-0x000000018581D4B0 
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872361E0-0x00000001872361F0 0x000000018723EB60-0x000000018723EB70
	
		// Nested types
		[CompilerGenerated]
		private sealed class _IndependentActionUpdater_d__12 : IEnumerator<object> // TypeDefIndex: 77233
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ActionTask __4__this; // 0x20
			public Component agent; // 0x28
			public IBlackboard blackboard; // 0x30
			public Action<NodeCanvas.Framework.Status> callback; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _IndependentActionUpdater_d__12(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB3D910-0x000000018CB3D998
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB3D998-0x000000018CB3D9E4
		}
	
		// Constructors
		protected ActionTask(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		public void ExecuteIndependent(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback); // 0x000000018CB2FE00-0x000000018CB2FE88
		[IteratorStateMachine(typeof(_IndependentActionUpdater_d__12))]
		private IEnumerator IndependentActionUpdater(Component agent, IBlackboard blackboard, Action<NodeCanvas.Framework.Status> callback); // 0x000000018CB2FE88-0x000000018CB2FF34
		[Obsolete("Use \'Execute\'")]
		public NodeCanvas.Framework.Status ExecuteAction(Component agent, IBlackboard blackboard); // 0x000000018CB2FDF8-0x000000018CB2FE00
		public NodeCanvas.Framework.Status Execute(Component agent, IBlackboard blackboard); // 0x000000018581CF70-0x000000018581D000
		public void EndAction(); // 0x0000000187837BD4-0x0000000187837BE0
		public void EndAction(bool success); // 0x000000018581C320-0x000000018581C340
		public void EndAction(bool? success); // 0x000000018581C360-0x000000018581C3D0
		public void Pause(); // 0x000000018CB2FF34-0x000000018CB2FF4C
		protected virtual void OnExecute(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnStop(bool interrupted); // 0x0000000186CEF860-0x0000000186CEF870
		protected virtual void OnStop(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnPause(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnResume(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[DoNotList]
	public class ConditionList : ConditionTask // TypeDefIndex: 77236
	{
		// Fields
		public ConditionsCheckMode checkMode; // 0x68
		public List<ConditionTask> conditions; // 0x70
	
		// Properties
		private bool allTrueRequired { get; } // 0x000000018581D490-0x000000018581D4A0 
		protected override string info { get; } // 0x000000018CB32348-0x000000018CB32554 
	
		// Nested types
		public enum ConditionsCheckMode // TypeDefIndex: 77235
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}
	
		// Constructors
		public ConditionList(); // 0x0000000186AB48D0-0x0000000186AB4930
	
		// Methods
		public override NodeCanvas.Framework.Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018CB32028-0x000000018CB3221C
		protected override void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnDisable(); // 0x000000018581C810-0x000000018581C8A0
		protected override bool OnCheck(); // 0x000000018581C8A0-0x000000018581CA10
		public override void OnDrawGizmosSelected(); // 0x000000018CB322A0-0x000000018CB32348
		public void AddCondition(ConditionTask condition); // 0x000000018CB31E30-0x000000018CB32028
		internal override string GetWarningOrError(); // 0x000000018CB3221C-0x000000018CB322A0
	}

	public abstract class ConditionTask<T> : ConditionTask // TypeDefIndex: 77237
		where T : class
	{
		// Properties
		public sealed override System.Type agentType { get; }
		public new T agent { get; }
	
		// Constructors
		protected ConditionTask();
	}

	public abstract class ConditionTask : NodeCanvas.Framework.Task // TypeDefIndex: 77239
	{
		// Fields
		[SerializeField]
		private bool _invert; // 0x58
		private int yieldReturn; // 0x5C
		private int yields; // 0x60
		private bool isRuntimeEnabled; // 0x64
	
		// Properties
		public bool invert { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Flip_d__13 : IEnumerator<object> // TypeDefIndex: 77238
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConditionTask __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Flip_d__13(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB3D618-0x000000018CB3D684
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB3D684-0x000000018CB3D6D0
		}
	
		// Constructors
		protected ConditionTask(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		public void Enable(Component agent, IBlackboard bb); // 0x000000018581CC90-0x000000018581CCD0
		public void Disable(); // 0x000000018581CEA0-0x000000018581CED0
		[Obsolete("Use \'Check\'")]
		public bool CheckCondition(Component agent, IBlackboard blackboard); // 0x000000018CB32554-0x000000018CB3255C
		public bool Check(Component agent, IBlackboard blackboard); // 0x000000018581CED0-0x000000018581CF30
		public bool CheckOnce(Component agent, IBlackboard blackboard); // 0x000000018CB3255C-0x000000018CB325AC
		protected void YieldReturn(bool value, bool keepValueUntilUsed = false /* Metadata: 0x02629E07 */); // 0x000000018CB32608-0x000000018CB32640
		[IteratorStateMachine(typeof(_Flip_d__13))]
		private IEnumerator Flip(); // 0x000000018CB325AC-0x000000018CB32608
		protected virtual void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual bool OnCheck(); // 0x00000001851A4410-0x00000001851A4420
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("[EventReceiver] is no longer used. Please use the \'.router\' property to subscribe/unsubscribe to events (in OnExecute/OnStop for actions and OnEnable/OnDisable for conditions). For custom events, use \'.router.onCustomEvent\'.")]
	public class EventReceiverAttribute : Attribute // TypeDefIndex: 77240
	{
		// Fields
		public readonly string[] eventMessages; // 0x10
	
		// Constructors
		public EventReceiverAttribute(params string[] args); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public interface ITaskSystem // TypeDefIndex: 77241
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
	public abstract class Task : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 77243
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
		public ITaskSystem ownerSystem { get; private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Component ownerSystemAgent { get; } // 0x000000018CB3D2AC-0x000000018CB3D300 
		public IBlackboard ownerSystemBlackboard { get; } // 0x00000001868C4860-0x00000001868C48B0 
		public float ownerSystemElapsedTime { get; } // 0x000000018CB3D300-0x000000018CB3D320 
		public bool isUserEnabled { get; internal set; } // 0x000000018581D000-0x000000018581D010 0x000000018CB3D610-0x000000018CB3D618
		public string obsolete { get; } // 0x000000018CB3D200-0x000000018CB3D2AC 
		public string name { get; } // 0x000000018CB3D124-0x000000018CB3D200 
		public string description { get; } // 0x000000018CB3D078-0x000000018CB3D124 
		public string summaryInfo { get; } // 0x000000018CB3D400-0x000000018CB3D560 
		protected virtual string info { get; } // 0x0000000188D3EC48-0x0000000188D3EC50 
		public virtual System.Type agentType { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public string agentInfo { get; } // 0x000000018CB3D018-0x000000018CB3D064 
		public string agentParameterName { get; } // 0x000000018CB3D064-0x000000018CB3D078 
		public bool agentIsOverride { get; set; } // 0x000000018581D1B0-0x000000018581D1C0 0x000000018CB3D560-0x000000018CB3D610
		public Component agent { get; } // 0x000000018581CB40-0x000000018581CBD0 
		public IBlackboard blackboard { get; } // 0x0000000187837BCC-0x0000000187837BD4 
		public EventRouter router { get; } // 0x000000018CB3D320-0x000000018CB3D400 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Field)]
		protected class GetFromAgentAttribute : Attribute // TypeDefIndex: 77242
		{
			// Constructors
			public GetFromAgentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public Task(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB3CF58-0x000000018CB3CFE0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public static T Create<T>(ITaskSystem newOwnerSystem)
			where T : Task;
		public static Task Create(System.Type type, ITaskSystem newOwnerSystem); // 0x000000018CB3C678-0x000000018CB3C7AC
		public virtual Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018CB3C7AC-0x000000018CB3C844
		public void Validate(ITaskSystem ownerSystem); // 0x000000018CB3CFE0-0x000000018CB3D018
		public void SetOwnerSystem(ITaskSystem newOwnerSystem); // 0x0000000187835950-0x0000000187835960
		protected bool Set(Component newAgent, IBlackboard newBB); // 0x000000018581D010-0x000000018581D1B0
		private bool Initialize(Component newAgent); // 0x000000018581D1C0-0x000000018581D2A0
		private bool InitializeFieldAttributes(Component newAgent); // 0x00000001857C3800-0x00000001857C39E0
		protected bool Error(string error, string tag = "Execution" /* Metadata: 0x02629E08 */); // 0x00000001843FFFF0-0x0000000184400000
		protected Coroutine StartCoroutine(IEnumerator routine); // 0x000000018CB3CE54-0x000000018CB3CED4
		protected void StopCoroutine(Coroutine routine); // 0x000000018CB3CED4-0x000000018CB3CF50
		protected void SendEvent(string name); // 0x000000018CB3CDFC-0x000000018CB3CE54
		protected void SendEvent<T>(string name, T value);
		internal virtual string GetWarningOrError(); // 0x000000018CB3C960-0x000000018CB3CDEC
		protected virtual string OnErrorCheck(); // 0x0000000185829EC0-0x0000000185829ED0
		private string GetHardError(); // 0x000000018CB3C844-0x000000018CB3C960
		protected virtual string OnInit(); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual void OnCreate(ITaskSystem ownerSystem); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnValidate(ITaskSystem ownerSystem); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("Use OnDrawGizmosSelected")]
		public virtual void OnDrawGizmos(); // 0x000000018CB3CDEC-0x000000018CB3CDFC
		public virtual void OnDrawGizmosSelected(); // 0x0000000186805BA0-0x0000000186805BB0
		public void ClearTaskData(); // 0x0000000187835938-0x0000000187835948
		protected virtual void OnClearTaskData(); // 0x0000000186805BA0-0x0000000186805BB0
		public override string ToString(); // 0x000000018CB3CF50-0x000000018CB3CF58
	}

	[CreateAssetMenu(menuName = "ParadoxNotion/CanvasCore/Blackboard Asset")]
	public class AssetBlackboard : ScriptableObject, ISerializationCallbackReceiver, IGlobalBlackboard // TypeDefIndex: 77244
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
		Dictionary<string, Variable> IBlackboard.variables { get; set; } // 0x00000001852A81D0-0x00000001852A8230 0x000000018CB2FF60-0x000000018CB2FF84
		UnityEngine.Object IBlackboard.unityContextObject { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		IBlackboard IBlackboard.parent { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		Component IBlackboard.propertiesBindTarget { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		string IBlackboard.independantVariablesFieldName { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public string identifier { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public string UID { get; } // 0x0000000182986470-0x0000000182986480 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018CB30118-0x000000018CB301A4
			remove; // 0x000000018CB30230-0x000000018CB302BC
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018CB301A4-0x000000018CB30230
			remove; // 0x000000018CB302BC-0x000000018CB30348
		}
	
		// Constructors
		public AssetBlackboard(); // 0x0000000185959440-0x0000000185959590
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB30110-0x000000018CB30118
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186E10AD0-0x0000000186E10AE0
		private void SelfSerialize(); // 0x000000018CB2FFA8-0x000000018CB300B0
		private void SelfDeserialize(); // 0x0000000186E10AE0-0x0000000186E10B90
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x00000001852A5850-0x00000001852A5870
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018CB2FF4C-0x000000018CB2FF60
		[ContextMenu("Show Json")]
		private void ShowJson(); // 0x000000018CB300B0-0x000000018CB30110
		public override string ToString(); // 0x000000018226EEA0-0x000000018226EEB0
		private void OnValidate(); // 0x000000018CB2FF84-0x000000018CB2FFA8
		private void OnEnable(); // 0x00000001852A3E00-0x00000001852A3E70
	}

	[Serializable]
	[fsAutoInstance(true)]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class BBParameter : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 77246
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
		public string targetVariableID { get; protected set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Variable varRef { get; protected set; } // 0x0000000182262130-0x0000000182262140 0x00000001852A7B20-0x00000001852A7B70
		public string name { get; set; } // 0x00000001829260F0-0x0000000182926100 0x000000018CB30EF4-0x000000018CB30F78
		public IBlackboard bb { get; set; } // 0x000000018225E800-0x000000018225E810 0x00000001852A78E0-0x00000001852A7A20
		public bool useBlackboard { get; set; } // 0x000000018C93AE88-0x000000018C93AE94 0x000000018CB30F78-0x000000018CB31004
		public bool isPresumedDynamic { get; } // 0x000000018CB30D88-0x000000018CB30E30 
		public bool isNone { get; } // 0x00000001852A5180-0x00000001852A51A0 
		public bool isNull { get; } // 0x000000018CB30D64-0x000000018CB30D88 
		public bool isNoneOrNull { get; } // 0x000000018CB30D34-0x000000018CB30D64 
		public bool isDefined { get; } // 0x000000018CB30D1C-0x000000018CB30D34 
		public System.Type refType { get; } // 0x000000018CB30E30-0x000000018CB30E58 
		public object value { get; set; } // 0x000000018CB30E58-0x000000018CB30E68 0x000000018CB31004-0x000000018CB31018
		public abstract System.Type varType { get; }
	
		// Events
		public event Action<Variable> onVariableReferenceChanged {
			add; // 0x000000018CB30C90-0x000000018CB30D1C
			remove; // 0x000000018CB30E68-0x000000018CB30EF4
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 77245
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SetBBFields_b__0(object o, fsData d); // 0x000000018CB3DD5C-0x000000018CB3DDE4
		}
	
		// Constructors
		public BBParameter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB30C78-0x000000018CB30C90
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public static BBParameter CreateInstance(System.Type t, IBlackboard bb); // 0x000000018CB30678-0x000000018CB307B0
		public static void SetBBFields(object target, IBlackboard bb); // 0x000000018CB308D8-0x000000018CB309C8
		protected abstract void SetDefaultValue();
		protected abstract void Bind(Variable data);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		public void SetTargetVariable(IBlackboard targetBB, Variable targetVariable); // 0x000000018CB309C8-0x000000018CB30B0C
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID); // 0x00000001852A7A20-0x00000001852A7B20
		public Variable PromoteToVariable(IBlackboard targetBB); // 0x000000018CB307B0-0x000000018CB308D8
		public sealed override string ToString(); // 0x000000018CB30B0C-0x000000018CB30C78
	}

	[Serializable]
	public class BBParameter<T> : BBParameter // TypeDefIndex: 77250
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
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 77247
		{
			// Fields
			public Func<object> convertFunc;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal T _BindGetter_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 77248
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
		private sealed class __c // TypeDefIndex: 77249
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
	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard // TypeDefIndex: 77251
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
		public BlackboardSource blackboard { get; } // 0x0000000182986470-0x0000000182986480 
		public AssetBlackboard parentBlackboard { get; } // 0x0000000182234E30-0x0000000182234E40 
		string IBlackboard.identifier { get; } // 0x000000018226EE80-0x000000018226EE90 
		Dictionary<string, Variable> IBlackboard.variables { get; set; } // 0x000000018CB314B4-0x000000018CB314D0 0x000000018CB314D0-0x000000018CB314F4
		Component IBlackboard.propertiesBindTarget { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		UnityEngine.Object IBlackboard.unityContextObject { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		IBlackboard IBlackboard.parent { get; } // 0x0000000182234E30-0x0000000182234E40 
		string IBlackboard.independantVariablesFieldName { get; } // 0x000000018CB31488-0x000000018CB314B4 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018CB31C00-0x000000018CB31C8C
			remove; // 0x000000018CB31D18-0x000000018CB31DA4
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018CB31C8C-0x000000018CB31D18
			remove; // 0x000000018CB31DA4-0x000000018CB31E30
		}
	
		// Constructors
		public Blackboard(); // 0x000000018CB31B90-0x000000018CB31C00
	
		// Methods
		public void SetParentBlackboard(AssetBlackboard bb); // 0x0000000187835500-0x0000000187835510
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB31B88-0x000000018CB31B90
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB31B80-0x000000018CB31B88
		public void SelfSerialize(); // 0x000000018CB31758-0x000000018CB31A5C
		public void SelfDeserialize(); // 0x000000018CB31594-0x000000018CB31758
		public string Serialize(List<UnityEngine.Object> references, bool pretyJson = false /* Metadata: 0x02629E12 */); // 0x000000018CB31A5C-0x000000018CB31B18
		public bool Deserialize(string json, List<UnityEngine.Object> references, bool removeMissingVariables = true /* Metadata: 0x02629E13 */); // 0x000000018CB312DC-0x000000018CB31388
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x000000018CB31460-0x000000018CB31474
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018CB31474-0x000000018CB31488
		protected virtual void Awake(); // 0x000000018CB3128C-0x000000018CB312DC
		public Variable AddVariable(string name, System.Type type); // 0x000000018CB31284-0x000000018CB3128C
		public Variable AddVariable(string name, object value); // 0x000000018CB3127C-0x000000018CB31284
		public Variable RemoveVariable(string name); // 0x000000018CB3152C-0x000000018CB31534
		public Variable GetVariable(string name, System.Type ofType = null); // 0x000000018CB31390-0x000000018CB31398
		public Variable GetVariableByID(string ID); // 0x000000018CB31388-0x000000018CB31390
		public Variable<T> GetVariable<T>(string name);
		public T GetVariableValue<T>(string name);
		public Variable SetVariableValue(string name, object value); // 0x000000018CB31B18-0x000000018CB31B20
		[Obsolete("Use GetVariableValue")]
		public T GetValue<T>(string name);
		[Obsolete("Use SetVariableValue")]
		public Variable SetValue(string name, object value); // 0x000000018CB31B18-0x000000018CB31B20
		[ContextMenu("Show Json")]
		private void ShowJson(); // 0x000000018CB31B20-0x000000018CB31B80
		public string Save(); // 0x000000018CB31570-0x000000018CB31594
		public string Save(string saveKey); // 0x000000018CB31534-0x000000018CB31570
		public bool Load(); // 0x000000018CB3143C-0x000000018CB31460
		public bool Load(string saveKey); // 0x000000018CB31398-0x000000018CB3143C
		protected virtual void OnValidate(); // 0x000000018CB314F4-0x000000018CB3152C
		public override string ToString(); // 0x000000018226EE80-0x000000018226EE90
	}

	[ExecuteInEditMode]
	public class GlobalBlackboard : NodeCanvas.Framework.Blackboard, IGlobalBlackboard // TypeDefIndex: 77254
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
		public string identifier { get; } // 0x0000000187232F80-0x0000000187232F90 
		public string UID { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public new string name { get; } // 0x0000000187232F80-0x0000000187232F90 
	
		// Nested types
		public enum SingletonMode // TypeDefIndex: 77252
		{
			DestroyComponentOnly = 0,
			DestroyEntireGameObject = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 77253
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Find_b__0(GlobalBlackboard b); // 0x000000018CB3DE24-0x000000018CB3DE4C
		}
	
		// Constructors
		public GlobalBlackboard(); // 0x000000018CB3304C-0x000000018CB330C8
		static GlobalBlackboard(); // 0x000000018CB32FC0-0x000000018CB3304C
	
		// Methods
		public static IEnumerable<GlobalBlackboard> GetAll(); // 0x000000018CB32BBC-0x000000018CB32C0C
		public static GlobalBlackboard Create(); // 0x000000018CB32A20-0x000000018CB32AC8
		public static GlobalBlackboard Find(string name); // 0x000000018CB32AC8-0x000000018CB32BBC
		protected void OnEnable(); // 0x000000018CB32C7C-0x000000018CB32E50
		protected void OnDisable(); // 0x000000018CB32C0C-0x000000018CB32C7C
		protected override void OnValidate(); // 0x000000018CB32E50-0x000000018CB32FC0
		public override string ToString(); // 0x0000000187232F80-0x0000000187232F90
		private bool IsPrefabAsset(); // 0x00000001843FFFF0-0x0000000184400000
	}

	public interface IBlackboard // TypeDefIndex: 77255
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

	public interface IGlobalBlackboard : IBlackboard // TypeDefIndex: 77256
	{
		// Properties
		string UID { get; }
	}

	[SpoofAOT]
	public static class IBlackboardExtensions // TypeDefIndex: 77259
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _GetAllParents_d__1 : IEnumerable<IBlackboard>, IEnumerator<IBlackboard> // TypeDefIndex: 77257
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
			IBlackboard IEnumerator<NodeCanvas.Framework.IBlackboard>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllParents_d__1(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB3D6D0-0x000000018CB3D780
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB3D824-0x000000018CB3D870
			[DebuggerHidden]
			IEnumerator<IBlackboard> IEnumerable<IBlackboard>.GetEnumerator(); // 0x000000018CB3D780-0x000000018CB3D81C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CB3D81C-0x000000018CB3D824
		}
	
		[CompilerGenerated]
		private sealed class _GetVariables_d__14 : IEnumerable<Variable>, IEnumerator<Variable> // TypeDefIndex: 77258
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
			Variable IEnumerator<NodeCanvas.Framework.Variable>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetVariables_d__14(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186CDFF60-0x0000000186CE0010
			private bool MoveNext(); // 0x00000001864B2100-0x00000001864B2710
			private void __m__Finally1(); // 0x000000018CB3D8C4-0x000000018CB3D910
			private void __m__Finally2(); // 0x00000001864B2710-0x00000001864B2750
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB3D878-0x000000018CB3D8C4
			[DebuggerHidden]
			IEnumerator<Variable> IEnumerable<Variable>.GetEnumerator(); // 0x0000000186A18E40-0x0000000186A18ED0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CB3D870-0x000000018CB3D878
		}
	
		// Extension methods
		public static IBlackboard GetRoot(this IBlackboard blackboard); // 0x000000018CB33FA4-0x000000018CB33FE4
		[IteratorStateMachine(typeof(_GetAllParents_d__1))]
		public static IEnumerable<IBlackboard> GetAllParents(this IBlackboard blackboard, bool includeSelf); // 0x000000018CB33F24-0x000000018CB33FA4
		public static bool IsPartOf(this IBlackboard blackboard, IBlackboard child); // 0x000000018CB33FE4-0x000000018CB34024
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName, T value);
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName);
		public static Variable AddVariable(this IBlackboard blackboard, string varName, object value); // 0x00000001852A6140-0x00000001852A61B0
		public static Variable AddVariable(this IBlackboard blackboard, string varName, System.Type type); // 0x00000001852A6440-0x00000001852A6540
		public static Variable RemoveVariable(this IBlackboard blackboard, string varName); // 0x000000018CB34478-0x000000018CB345A4
		public static T GetVariableValue<T>(this IBlackboard blackboard, string varName);
		public static Variable SetVariableValue(this IBlackboard blackboard, string varName, object value); // 0x000000018CB345A4-0x000000018CB346BC
		public static void InitializePropertiesBinding(this IBlackboard blackboard, Component target, bool callSetter); // 0x00000001852A55C0-0x00000001852A57D0
		public static Variable<T> GetVariable<T>(this IBlackboard blackboard, string varName);
		public static Variable GetVariable(this IBlackboard blackboard, string varName, System.Type ofType = null); // 0x00000001852A7B70-0x00000001852A7CB0
		public static Variable GetVariableByID(this IBlackboard blackboard, string ID); // 0x00000001852A7CB0-0x00000001852A8160
		[IteratorStateMachine(typeof(_GetVariables_d__14))]
		public static IEnumerable<Variable> GetVariables(this IBlackboard blackboard, System.Type ofType = null); // 0x00000001852A49B0-0x00000001852A4A40
		public static Variable ChangeVariableType(this IBlackboard blackboard, Variable target, System.Type newType); // 0x000000018CB33D48-0x000000018CB33F24
		public static void OverwriteFrom(this IBlackboard blackboard, IBlackboard sourceBlackboard, bool removeMissingVariables = true /* Metadata: 0x02629E16 */); // 0x000000018CB34024-0x000000018CB34478
	}

	public static class BlackboardHelpers // TypeDefIndex: 77261
	{
		// Fields
		private static readonly ConcurrentDictionary<System.Type, System.Type> s_variableTypeCache; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77260
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, System.Type> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E7820-0x00000001871E7880
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Type _CreateVariableType_b__1_0(System.Type t); // 0x0000000186E01530-0x0000000186E01630
		}
	
		// Constructors
		static BlackboardHelpers(); // 0x0000000185B7AEE0-0x0000000185B7AF70
	
		// Methods
		public static System.Type CreateVariableType(System.Type valueType); // 0x00000001852A5870-0x00000001852A59A0
	}

	[Serializable]
	[fsUninitialized]
	[SpoofAOT]
	public abstract class Variable // TypeDefIndex: 77264
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
		public string name { get; set; } // 0x00000001829260F0-0x0000000182926100 0x00000001852A57D0-0x00000001852A5850
		public string ID { get; } // 0x00000001852A8160-0x00000001852A81D0 
		public object value { get; set; } // 0x0000000187835928-0x0000000187835938 0x0000000187835914-0x0000000187835928
		public bool isExposedPublic { get; set; } // 0x00000001852A50C0-0x00000001852A50E0 0x0000000182246E60-0x0000000182246E70
		public bool debugBoundValue { get; set; } // 0x000000018225E090-0x000000018225E0A0 0x000000018225E0A0-0x000000018225E0B0
		public bool isPropertyBound { get; } // 0x00000001852A50E0-0x00000001852A5110 
		public abstract bool isDataBound { get; }
		public abstract System.Type varType { get; }
		public abstract string propertyPath { get; set; }
	
		// Events
		public event Action<string> onNameChanged {
			add; // 0x000000018CB3E6A4-0x000000018CB3E730
			remove; // 0x000000018CB3E850-0x000000018CB3E8DC
		}
		public event Action<object> onValueChanged {
			add; // 0x000000018CB3E730-0x000000018CB3E7BC
			remove; // 0x00000001852A5030-0x00000001852A50C0
		}
		public event Action onDestroy {
			add; // 0x000000018CB3E610-0x000000018CB3E6A4
			remove; // 0x000000018CB3E7BC-0x000000018CB3E850
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 77262
		{
			// Fields
			public Variable __4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _GetGetConverter_b__0(); // 0x00000001852A4B30-0x00000001852A4B60
			internal object _GetGetConverter_b__1(); // 0x000000018CB3E288-0x000000018CB3E2C4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 77263
		{
			// Fields
			public Variable __4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetSetConverter_b__0(object x); // 0x000000018CB3E2C4-0x000000018CB3E2E8
			internal void _GetSetConverter_b__1(object x); // 0x000000018CB3E2E8-0x000000018CB3E324
		}
	
		// Constructors
		public Variable(); // 0x000000018595A0F0-0x000000018595A1C0
		public Variable(string name, string ID); // 0x0000000185381AC0-0x0000000185381AF0
	
		// Methods
		public abstract void BindProperty(MemberInfo prop, GameObject target = null);
		public abstract void UnBind();
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x02629E17 */);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		public abstract void ResetDefaultValue();
		public abstract void RecordDefaultValue();
		internal void OnDestroy(); // 0x000000018CB3E5E8-0x000000018CB3E5FC
		public Variable Duplicate(IBlackboard targetBB); // 0x000000018CB3E4DC-0x000000018CB3E5E8
		protected bool HasValueChangeEvent(); // 0x0000000186409880-0x0000000186409890
		protected void TryInvokeValueChangeEvent(object value); // 0x000000018CB3E5FC-0x000000018CB3E610
		public bool CanConvertTo(System.Type toType); // 0x00000001852A8AF0-0x00000001852A8B10
		public Func<object> GetGetConverter(System.Type toType); // 0x00000001852A8B10-0x00000001852A8C80
		public bool CanConvertFrom(System.Type fromType); // 0x000000018CB3E4C4-0x000000018CB3E4DC
		public Action<object> GetSetConverter(System.Type fromType); // 0x00000001863C2F60-0x00000001863C30C0
		public override string ToString(); // 0x00000001829260F0-0x0000000182926100
	}

	public class Variable<T> : Variable // TypeDefIndex: 77269
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
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 77265
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
		private sealed class __c__DisplayClass31_1 // TypeDefIndex: 77266
		{
			// Fields
			public T value;
	
			// Constructors
			public __c__DisplayClass31_1();
	
			// Methods
			internal T _InitializePropertyBinding_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_2 // TypeDefIndex: 77267
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
		private sealed class __c // TypeDefIndex: 77268
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
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x02629E18 */);
	}

	public class VariableSeperator // TypeDefIndex: 77270
	{
		// Fields
		[CompilerGenerated]
		private bool _isEditingName_k__BackingField; // 0x10
	
		// Properties
		public bool isEditingName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public VariableSeperator(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace NodeCanvas.Framework.Internal
{
	public struct GraphLoadData // TypeDefIndex: 77271
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
	public class GraphSource : ISerializationCollector // TypeDefIndex: 77272
	{
		// Fields
		private List<NodeCanvas.Framework.Task> m_allTasks; // 0x10
		public List<BBParameter> m_allParameters; // 0x18
		public const float FRAMEWORK_VERSION = 3.25f; // Metadata: 0x02629E19
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
		public List<NodeCanvas.Framework.Task> allTasks { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public List<BBParameter> allParameters { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float version { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public string category { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public string comments { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public Vector2 translation { get; set; } // 0x0000000187254400-0x0000000187254420 0x00000001855D8A50-0x00000001855D8A60
		public float zoomFactor { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public string type { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public List<NodeCanvas.Framework.Node> nodes { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public List<Connection> connections { get; private set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public BlackboardSource localBlackboard { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public object derivedData { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
	
		// Constructors
		public GraphSource(); // 0x0000000185959220-0x00000001859593C0
	
		// Methods
		void ISerializationCollector.OnPush(ISerializationCollector parent); // 0x0000000185958FA0-0x0000000185959070
		void ISerializationCollector.OnCollect(ISerializationCollectable child, int depth); // 0x00000001857C7C90-0x00000001857C7D50
		void ISerializationCollector.OnPop(ISerializationCollector parent); // 0x0000000186805BA0-0x0000000186805BB0
		public GraphSource Pack(NodeCanvas.Framework.Graph graph); // 0x000000018CB33ABC-0x000000018CB33C9C
		public GraphSource Unpack(NodeCanvas.Framework.Graph graph); // 0x00000001852A6740-0x00000001852A69E0
		public GraphSource SetMetaData(GraphSource source); // 0x000000018CB33CE4-0x000000018CB33D48
		public void PurgeRedundantReferences(); // 0x000000018CB33C9C-0x000000018CB33CE4
	}

	[Description("Please resolve the MissingConnection issue by either replacing the connection, importing the missing connection type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public sealed class MissingConnection : Connection, IMissingRecoverable // TypeDefIndex: 77273
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x30
		[SerializeField]
		private string _recoveryState; // 0x38
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Constructors
		public MissingConnection(); // 0x0000000187240330-0x0000000187240340
	}

	[Description("Please resolve the MissingNode issue by either replacing the node, importing the missing node type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public sealed class MissingNode : NodeCanvas.Framework.Node, IMissingRecoverable // TypeDefIndex: 77274
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x98
		[SerializeField]
		private string _recoveryState; // 0xA0
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public override string name { get; } // 0x000000018CB34A6C-0x000000018CB34AC0 
		public override System.Type outConnectionType { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool canSelfConnect { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override Alignment2x2 commentsAlignment { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override Alignment2x2 iconAlignment { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public MissingNode(); // 0x0000000186B55770-0x0000000186B55780
	}

	[Serializable]
	public class ReflectedAction : ReflectedActionWrapper // TypeDefIndex: 77275
	{
		// Fields
		private ActionCall call; // 0x18
	
		// Constructors
		public ReflectedAction(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override BBParameter[] GetVariables(); // 0x000000018CB369F4-0x000000018CB36A28
		public override void Init(object instance); // 0x000000018CB36A28-0x000000018CB36AAC
		public override void Call(); // 0x000000018CB369CC-0x000000018CB369F4
	}

	[Serializable]
	[SpoofAOT]
	public class ReflectedAction<T1> : ReflectedActionWrapper // TypeDefIndex: 77276
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
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper // TypeDefIndex: 77277
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
	public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper // TypeDefIndex: 77278
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
	public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper // TypeDefIndex: 77279
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
	public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper // TypeDefIndex: 77280
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
	public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper // TypeDefIndex: 77281
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
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper // TypeDefIndex: 77282
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
	public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper // TypeDefIndex: 77283
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
	public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper // TypeDefIndex: 77284
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
	public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper // TypeDefIndex: 77285
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
	public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper // TypeDefIndex: 77286
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
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper // TypeDefIndex: 77287
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
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper // TypeDefIndex: 77288
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

	public abstract class ReflectedWrapper : IReflectedWrapper // TypeDefIndex: 77289
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo _targetMethod; // 0x10
	
		// Constructors
		public ReflectedWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018CB36EB0-0x000000018CB36F58
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001829260F0-0x0000000182926100
		public void SetVariablesBB(IBlackboard bb); // 0x000000018CB36F7C-0x000000018CB36FEC
		public SerializedMethodInfo GetSerializedMethod(); // 0x00000001829260F0-0x0000000182926100
		public MethodInfo GetMethod(); // 0x000000018CB36F58-0x000000018CB36F68
		public bool HasChanged(); // 0x000000018CB36F68-0x000000018CB36F7C
		public string AsString(); // 0x000000018CB36E90-0x000000018CB36EB0
		public override string ToString(); // 0x000000018CB36FEC-0x000000018CB36FF4
		public abstract BBParameter[] GetVariables();
		public abstract void Init(object instance);
	}

	public abstract class ReflectedActionWrapper : ReflectedWrapper // TypeDefIndex: 77290
	{
		// Constructors
		protected ReflectedActionWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static new ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018CB36624-0x000000018CB369CC
		public abstract void Call();
	}

	public abstract class ReflectedFunctionWrapper : ReflectedWrapper // TypeDefIndex: 77291
	{
		// Constructors
		protected ReflectedFunctionWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static new ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018CB36AAC-0x000000018CB36E90
		public abstract object Call();
	}

	[Description("Please resolve the MissingAction issue by either replacing the action, importing the missing action type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public class MissingAction : ActionTask, IMissingRecoverable // TypeDefIndex: 77292
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x68
		[SerializeField]
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		protected override string info { get; } // 0x000000018CB3496C-0x000000018CB349D8 
	
		// Constructors
		public MissingAction(); // 0x000000018723B3B0-0x000000018723B3C0
	}

	[Description("Please resolve the MissingCondition issue by either replacing the condition, importing the missing condition type, or refactoring the type in GraphRefactor.")]
	[DoNotList]
	public class MissingCondition : ConditionTask, IMissingRecoverable // TypeDefIndex: 77293
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x68
		[SerializeField]
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		protected override string info { get; } // 0x000000018CB34A00-0x000000018CB34A6C 
	
		// Constructors
		public MissingCondition(); // 0x000000018723B3A0-0x000000018723B3B0
	}

	[Serializable]
	[fsAutoInstance(false)]
	public sealed class TaskAgentParameter : BBParameter<UnityEngine.Object> // TypeDefIndex: 77294
	{
		// Fields
		[SerializeField]
		private System.Type _type; // 0x50
	
		// Properties
		public override System.Type varType { get; } // 0x000000018CB3C618-0x000000018CB3C678 
		public new UnityEngine.Object value { get; set; } // 0x000000018CB3C570-0x000000018CB3C618 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Constructors
		public TaskAgentParameter(); // 0x000000018CB3C548-0x000000018CB3C570
	
		// Methods
		public override object GetValueBoxed(); // 0x000000018CB3C454-0x000000018CB3C45C
		public override void SetValueBoxed(object newValue); // 0x000000018CB3C4F4-0x000000018CB3C548
		public void SetType(System.Type newType); // 0x000000018CB3C45C-0x000000018CB3C4F4
	}

	[Serializable]
	public class BBMappingParameter : BBObjectParameter // TypeDefIndex: 77295
	{
		// Fields
		[SerializeField]
		private string _targetSubGraphVariableID; // 0x60
		[SerializeField]
		private bool _canRead; // 0x68
		[SerializeField]
		private bool _canWrite; // 0x69
	
		// Properties
		public string targetSubGraphVariableID { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public bool canRead { get; set; } // 0x000000018226EF80-0x000000018226EF90 0x000000018226EF90-0x000000018226EFA0
		public bool canWrite { get; set; } // 0x0000000187233360-0x0000000187233370 0x00000001872333C0-0x00000001872333D0
	
		// Constructors
		public BBMappingParameter(); // 0x000000018CB30348-0x000000018CB30350
		public BBMappingParameter(Variable subVariable); // 0x000000018CB30350-0x000000018CB303B0
	}

	[Serializable]
	public class BBObjectParameter : BBParameter<object>, ISerializationCallbackReceiver // TypeDefIndex: 77296
	{
		// Fields
		[SerializeField]
		private string _type; // 0x50
		[CompilerGenerated]
		private System.Type _type_k__BackingField; // 0x58
	
		// Properties
		private System.Type type { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public override System.Type varType { get; } // 0x0000000186740A30-0x0000000186740AB0 
	
		// Constructors
		public BBObjectParameter(); // 0x000000018CB30600-0x000000018CB30678
		public BBObjectParameter(System.Type t); // 0x000000018CB305BC-0x000000018CB30600
		public BBObjectParameter(BBParameter source); // 0x000000018CB3052C-0x000000018CB305BC
	
		// Methods
		new void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB304BC-0x000000018CB3052C
		new void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186A9F790-0x0000000186A9F800
		public void SetType(System.Type t); // 0x000000018CB303B0-0x000000018CB304BC
	}

	[Serializable]
	public class BlackboardSource : IBlackboard // TypeDefIndex: 77297
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
		public string identifier { get; } // 0x000000018CB31138-0x000000018CB31164 
		public Dictionary<string, Variable> variables { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public IBlackboard parent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public UnityEngine.Object unityContextObject { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public Component propertiesBindTarget { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		string IBlackboard.independantVariablesFieldName { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018CB31020-0x000000018CB310AC
			remove; // 0x000000018CB31164-0x000000018CB311F0
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018CB310AC-0x000000018CB31138
			remove; // 0x000000018CB311F0-0x000000018CB3127C
		}
	
		// Constructors
		public BlackboardSource(); // 0x00000001859593C0-0x0000000185959440
	
		// Methods
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x000000018B6FF868-0x000000018B6FF87C
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018CB2FF4C-0x000000018CB2FF60
		public override string ToString(); // 0x000000018CB31018-0x000000018CB31020
	}

	public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType> // TypeDefIndex: 77298
	{
		// Constructors
		public fsBBParameterProcessor(); // 0x000000018CB3EB70-0x000000018CB3EC08
	
		// Methods
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x000000018CB3E8DC-0x000000018CB3EB70
	}

	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable // TypeDefIndex: 77299
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x50
		[SerializeField]
		private string _recoveryState; // 0x58
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
	
		// Constructors
		public MissingBBParameterType(); // 0x000000018CB349D8-0x000000018CB34A00
	}

	public class MissingVariableType : Variable<object>, IMissingRecoverable // TypeDefIndex: 77300
	{
		// Fields
		[SerializeField]
		private string _missingType; // 0x70
		[SerializeField]
		private string _recoveryState; // 0x78
	
		// Properties
		public string missingType { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public string recoveryState { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
	
		// Constructors
		public MissingVariableType(); // 0x000000018CB34AC0-0x000000018CB34AF4
	}
}

namespace NodeCanvas.StateMachines
{
	[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/FSM Asset")]
	[GraphInfo(packageName = "NodeCanvas", docsURL = "https://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "https://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "https://nodecanvas.paradoxnotion.com/forums-page/")]
	public class FSM : NodeCanvas.Framework.Graph // TypeDefIndex: 77037
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
		public FSMState currentState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872360B0-0x00000001872360C0 0x0000000188C247F0-0x0000000188C24804
		public FSMState previousState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872354B0-0x00000001872354C0 0x0000000188D62F7C-0x0000000188D62F90
		public string currentStateName { get; } // 0x000000018CB0C8BC-0x000000018CB0C8E8 
		public string previousStateName { get; } // 0x000000018CB0C8E8-0x000000018CB0C914 
		public override System.Type baseNodeType { get; } // 0x000000018CB0C86C-0x000000018CB0C8BC 
		public override bool requiresAgent { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool requiresPrimeNode { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool isTree { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool allowBlackboardOverrides { get; } // 0x00000001851A4410-0x00000001851A4420 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool canDelayDeserializeAndOptimizeClone { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Events
		public event Action<IState> onStateEnter {
			add; // 0x000000018CB0C62C-0x000000018CB0C6BC
			remove; // 0x000000018CB0C914-0x000000018CB0C9A4
		}
		public event Action<IState> onStateUpdate {
			add; // 0x000000018CB0C7DC-0x000000018CB0C86C
			remove; // 0x000000018CB0CAC4-0x000000018CB0CB54
		}
		public event Action<IState> onStateExit {
			add; // 0x000000018CB0C6BC-0x000000018CB0C74C
			remove; // 0x000000018CB0C9A4-0x000000018CB0CA34
		}
		public event Action<IState> onStateTransition {
			add; // 0x000000018CB0C74C-0x000000018CB0C7DC
			remove; // 0x000000018CB0CA34-0x000000018CB0CAC4
		}
	
		// Nested types
		public enum TransitionCallMode // TypeDefIndex: 77034
		{
			Normal = 0,
			Stacked = 1,
			Clean = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77035
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IUpdatable, bool> __9__45_0; // 0x08
			public static Func<NodeCanvas.Framework.Node, bool> __9__49_0; // 0x10
			public static Func<NodeCanvas.Framework.Node, string> __9__49_1; // 0x18
	
			// Constructors
			static __c(); // 0x000000018CB1B5E4-0x000000018CB1B648
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _OnGraphUpdate_b__45_0(IUpdatable n); // 0x000000018CB1B4E8-0x000000018CB1B50C
			internal bool _GetStateNames_b__49_0(NodeCanvas.Framework.Node n); // 0x000000018CB1B3D0-0x000000018CB1B410
			internal string _GetStateNames_b__49_1(NodeCanvas.Framework.Node n); // 0x000000018CB1B410-0x000000018CB1B430
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0 // TypeDefIndex: 77036
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass50_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetStateWithName_b__0(NodeCanvas.Framework.Node n); // 0x000000018CB1B50C-0x000000018CB1B580
		}
	
		// Constructors
		public FSM(); // 0x000000018CB0C5E0-0x000000018CB0C62C
	
		// Methods
		protected override void OnGraphInitialize(); // 0x000000018CB0BDCC-0x000000018CB0BF8C
		protected override void OnGraphStarted(); // 0x000000018CB0BF8C-0x000000018CB0C010
		protected override void OnGraphUpdate(); // 0x000000018CB0C090-0x000000018CB0C374
		protected override void OnGraphStoped(); // 0x000000018CB0C010-0x000000018CB0C090
		public bool EnterState(FSMState newState, TransitionCallMode callMode); // 0x000000018CB0B784-0x000000018CB0B938
		public FSMState TriggerState(string stateName, TransitionCallMode callMode); // 0x000000018CB0C3D8-0x000000018CB0C424
		public string[] GetStateNames(); // 0x000000018CB0BADC-0x000000018CB0BCD8
		public FSMState GetStateWithName(string name); // 0x000000018CB0BCD8-0x000000018CB0BDCC
		private void GatherCallbackReceivers(); // 0x000000018CB0B938-0x000000018CB0BADC
		public FSMState PeekStack(); // 0x000000018CB0C374-0x000000018CB0C3D8
		[CompilerGenerated]
		private void _GatherCallbackReceivers_b__51_0(IState x); // 0x000000018CB0C424-0x000000018CB0C4B8
		[CompilerGenerated]
		private void _GatherCallbackReceivers_b__51_1(IState x); // 0x000000018CB0C4B8-0x000000018CB0C54C
		[CompilerGenerated]
		private void _GatherCallbackReceivers_b__51_2(IState x); // 0x000000018CB0C54C-0x000000018CB0C5E0
	}

	public class FSMConnection : Connection, ITaskAssignable<ConditionTask> // TypeDefIndex: 77038
	{
		// Fields
		[SerializeField]
		private FSM.TransitionCallMode _transitionCallMode; // 0x30
		[SerializeField]
		private ConditionTask _condition; // 0x38
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000182986470-0x0000000182986480 0x000000018CB0ABD0-0x000000018CB0AC24
		public FSM.TransitionCallMode transitionCallMode { get; private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Constructors
		public FSMConnection(); // 0x0000000187240330-0x0000000187240340
	
		// Methods
		public void EnableCondition(Component agent, IBlackboard blackboard); // 0x000000018CB0AB08-0x000000018CB0AB1C
		public void DisableCondition(); // 0x000000018CB0AAF4-0x000000018CB0AB08
		public void PerformTransition(); // 0x000000018CB0AB1C-0x000000018CB0ABD0
	}

	public abstract class FSMNode : NodeCanvas.Framework.Node // TypeDefIndex: 77039
	{
		// Properties
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool canSelfConnect { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override int maxInConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public sealed override System.Type outConnectionType { get; } // 0x000000018CB0AC60-0x000000018CB0ACB0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x00000001845BA780-0x00000001845BA790 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x00000001845BA780-0x00000001845BA790 
		public FSM FSM { get; } // 0x000000018CB0AC24-0x000000018CB0AC60 
	
		// Constructors
		protected FSMNode(); // 0x0000000186B55770-0x0000000186B55780
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMNodeNested<T> : FSMNode, IGraphAssignable<T> // TypeDefIndex: 77040
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
	public class FSMOwner : GraphOwner<FSM> // TypeDefIndex: 77041
	{
		// Properties
		public string currentRootStateName { get; } // 0x000000018CB0B138-0x000000018CB0B1D0 
		public string previousRootStateName { get; } // 0x000000018CB0B1F4-0x000000018CB0B28C 
		public string currentDeepStateName { get; } // 0x000000018CB0B114-0x000000018CB0B138 
		public string previousDeepStateName { get; } // 0x000000018CB0B1D0-0x000000018CB0B1F4 
	
		// Constructors
		public FSMOwner(); // 0x000000018CB0B0E0-0x000000018CB0B114
	
		// Methods
		public IState GetCurrentState(bool includeSubFSMs = true /* Metadata: 0x02629D53 */); // 0x000000018CB0ACB0-0x000000018CB0ADE0
		public IState GetPreviousState(bool includeSubFSMs = true /* Metadata: 0x02629D54 */); // 0x000000018CB0ADE0-0x000000018CB0AF84
		public IState TriggerState(string stateName); // 0x000000018CB0B01C-0x000000018CB0B028
		public IState TriggerState(string stateName, FSM.TransitionCallMode callMode); // 0x000000018CB0B028-0x000000018CB0B0E0
		public string[] GetStateNames(); // 0x000000018CB0AF84-0x000000018CB0B01C
	}

	[Color("ff6d53")]
	public abstract class FSMState : FSMNode, IState // TypeDefIndex: 77043
	{
		// Fields
		[SerializeField]
		private TransitionEvaluationMode _transitionEvaluation; // 0x98
		private bool _hasInit; // 0x9C
	
		// Properties
		public override bool allowAsPrime { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool canSelfConnect { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override int maxInConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public TransitionEvaluationMode transitionEvaluation { get; set; } // 0x0000000182271AC0-0x0000000182271AD0 0x0000000182271B20-0x0000000182271B30
	
		// Nested types
		public enum TransitionEvaluationMode // TypeDefIndex: 77042
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}
	
		// Constructors
		protected FSMState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public FSMConnection[] GetTransitions(); // 0x000000018CB0B450-0x000000018CB0B570
		public void Finish(); // 0x000000018CB0B420-0x000000018CB0B430
		public void Finish(bool inSuccess); // 0x000000018CB0B430-0x000000018CB0B450
		public void Finish(NodeCanvas.Framework.Status status); // 0x000000018CB0B418-0x000000018CB0B420
		public override void OnGraphPaused(); // 0x000000018CB0B6B0-0x000000018CB0B6C4
		protected override bool CanConnectFromSource(NodeCanvas.Framework.Node sourceNode); // 0x000000018CB0B28C-0x000000018CB0B2A4
		protected override bool CanConnectToTarget(NodeCanvas.Framework.Node targetNode); // 0x000000018CB0B2A4-0x000000018CB0B2BC
		protected sealed override NodeCanvas.Framework.Status OnExecute(Component agent, IBlackboard bb); // 0x000000018CB0B570-0x000000018CB0B6B0
		public bool CheckTransitions(); // 0x000000018CB0B2BC-0x000000018CB0B418
		protected sealed override void OnReset(); // 0x000000018CB0B6C4-0x000000018CB0B784
		protected virtual void OnInit(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnEnter(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnExit(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnPause(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("SubGraphs")]
	[Color("ffe4e1")]
	public abstract class FSMStateNested<T> : FSMState, IGraphAssignable<T> // TypeDefIndex: 77044
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

	public interface IState // TypeDefIndex: 77045
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

	public interface IStateCallbackReceiver // TypeDefIndex: 77046
	{
		// Methods
		void OnStateEnter(IState state);
		void OnStateUpdate(IState state);
		void OnStateExit(IState state);
	}

	[Description("Execute a number of Action Tasks OnEnter. All actions will be stoped OnExit. This state is Finished when all Actions are finished as well")]
	[Name("Action State", 100)]
	public class ActionState : FSMState, ITaskAssignable // TypeDefIndex: 77047
	{
		// Fields
		[SerializeField]
		private ActionList _actionList; // 0xA0
		[SerializeField]
		private bool _repeatStateActions; // 0xA8
	
		// Properties
		public NodeCanvas.Framework.Task task { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x000000018CB1C450-0x000000018CB1C4A8
		public ActionList actionList { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public bool repeatStateActions { get; set; } // 0x000000018225E110-0x000000018225E120 0x000000018225E120-0x000000018225E130
	
		// Constructors
		public ActionState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB1C384-0x000000018CB1C450
		protected override void OnEnter(); // 0x000000018CB1C2B8-0x000000018CB1C2C8
		protected override void OnUpdate(); // 0x000000018CB1C310-0x000000018CB1C384
		protected override void OnExit(); // 0x000000018CB1C2C8-0x000000018CB1C2EC
		protected override void OnPause(); // 0x000000018CB1C2EC-0x000000018CB1C310
	}

	[Color("b3ff7f")]
	[Description("The transitions of this node will be constantly checked. If any becomes true, that transition will take place. This is not a state.")]
	[Name("Any State", 0)]
	public class AnyState : FSMNode, IUpdatable // TypeDefIndex: 77048
	{
		// Fields
		[Tooltip("If enabled, a transition to an already running state will not happen.")]
		public bool dontRetriggerStates; // 0x98
	
		// Properties
		public override string name { get; } // 0x000000018CB1C9B4-0x000000018CB1C9E0 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public AnyState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB1C818-0x000000018CB1C900
		public override void OnGraphStoped(); // 0x000000018CB1C900-0x000000018CB1C9B4
		void IUpdatable.Update(); // 0x000000018CB1C638-0x000000018CB1C818
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub FSM in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub FSM", -1)]
	public class ConcurrentSubFSM : FSMNodeNested<FSM>, IUpdatable // TypeDefIndex: 77049
	{
		// Fields
		[ExposeField]
		[Name("Parallel FSM", 0)]
		[SerializeField]
		protected BBParameter<FSM> _subFSM; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override FSM subGraph { get; set; } // 0x000000018CB1D824-0x000000018CB1D86C 0x000000018CB1D86C-0x000000018CB1D8C4
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public ConcurrentSubFSM(); // 0x000000018CB1D7F0-0x000000018CB1D824
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB1D710-0x000000018CB1D7F0
		void IUpdatable.Update(); // 0x000000018CB1D708-0x000000018CB1D710
		[CompilerGenerated]
		private void _OnGraphStarted_b__14_0(bool result); // 0x000000018CB0B430-0x000000018CB0B450
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub Behaviour Tree in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub Behaviour Tree", -1)]
	public class ConcurrentSubTree : FSMNodeNested<BehaviourTree>, IUpdatable // TypeDefIndex: 77050
	{
		// Fields
		[ExposeField]
		[Name("Parallel Tree", 0)]
		[SerializeField]
		protected BBParameter<BehaviourTree> _subTree; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override BehaviourTree subGraph { get; set; } // 0x000000018CB1DB8C-0x000000018CB1DBD4 0x000000018CB1DBD4-0x000000018CB1DC2C
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public ConcurrentSubTree(); // 0x000000018CB1DB58-0x000000018CB1DB8C
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB1DA78-0x000000018CB1DB58
		void IUpdatable.Update(); // 0x000000018CB1D708-0x000000018CB1D710
		[CompilerGenerated]
		private void _OnGraphStarted_b__14_0(bool result); // 0x000000018CB0B430-0x000000018CB0B450
	}

	[Color("6ebbff")]
	[Description("This node has no functionality and you can use this for organization.\nIn comparison to an empty Action State, Transitions here are immediately evaluated in the same frame that this node is entered.")]
	[Name("Pass", 98)]
	public class EmptyState : FSMState // TypeDefIndex: 77051
	{
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
	
		// Constructors
		public EmptyState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		protected override void OnEnter(); // 0x000000018CB2278C-0x000000018CB227B4
	}

	[Description("Execute a Behaviour Tree OnEnter. OnExit that Behavior Tree will be stoped or paused based on the relevant specified setting. You can optionaly specify a Success Event and a Failure Event which will be sent when the BT\'s root node status returns either of the two. If so, use alongside with a CheckEvent on a transition.")]
	[DropReferenceType(typeof(BehaviourTree))]
	[Icon("BT", false, "")]
	[Name("Sub BehaviourTree", 0)]
	public class NestedBTState : FSMStateNested<BehaviourTree> // TypeDefIndex: 77054
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
		public override BehaviourTree subGraph { get; set; } // 0x000000018CB29498-0x000000018CB294E0 0x000000018CB294E0-0x000000018CB29538
		public override BBParameter subGraphParameter { get; } // 0x0000000187232C80-0x0000000187232C90 
	
		// Nested types
		public enum BTExecutionMode // TypeDefIndex: 77052
		{
			Once = 0,
			Repeat = 1
		}
	
		public enum BTExitMode // TypeDefIndex: 77053
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedBTState(); // 0x000000018CB29458-0x000000018CB29498
	
		// Methods
		protected override void OnEnter(); // 0x000000018CB29098-0x000000018CB29270
		protected override void OnUpdate(); // 0x000000018CB29398-0x000000018CB29458
		private void OnFinish(bool success); // 0x000000018CB29318-0x000000018CB29398
		protected override void OnExit(); // 0x000000018CB29270-0x000000018CB29318
	}

	[Description("Execute the assigned Dialogue Tree OnEnter and stop it OnExit. Optionaly an event can be sent for whether the dialogue ended in Success or Failure. This can be controled by using the \'Finish\' Dialogue Node inside the Dialogue Tree. Use a \'CheckEvent\' condition to make use of those events. The \'Instigator\' Actor of the Dialogue Tree will be set to this graph agent.")]
	[DropReferenceType(typeof(DialogueTree))]
	[Icon("Dialogue", false, "")]
	[Name("Sub Dialogue", 0)]
	public class NestedDTState : FSMStateNested<DialogueTree> // TypeDefIndex: 77055
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
		public override DialogueTree subGraph { get; set; } // 0x000000018CB2971C-0x000000018CB29764 0x000000018CB29764-0x000000018CB297BC
		public override BBParameter subGraphParameter { get; } // 0x0000000187232C80-0x0000000187232C90 
	
		// Constructors
		public NestedDTState(); // 0x000000018CB296E8-0x000000018CB2971C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CB29538-0x000000018CB29614
		protected override void OnUpdate(); // 0x000000018CB29694-0x000000018CB296E8
		protected override void OnExit(); // 0x000000018CB29614-0x000000018CB29694
		private void OnDialogueFinished(bool success); // 0x000000018CB22F34-0x000000018CB22FAC
	}

	[Description("Execute a sub FSM OnEnter, and Stop that FSM OnExit. This state is Finished only when and if the sub FSM is finished as well.")]
	[DropReferenceType(typeof(FSM))]
	[Icon("FSM", false, "")]
	[Name("Sub FSM", 0)]
	public class NestedFSMState : FSMStateNested<FSM> // TypeDefIndex: 77057
	{
		// Fields
		[ExposeField]
		[Name("Sub FSM", 0)]
		[SerializeField]
		private BBParameter<FSM> _nestedFSM; // 0xB8
		[Tooltip("What will happen to the sub FSM when this state exits.")]
		public FSMExitMode exitMode; // 0xC0
	
		// Properties
		public override FSM subGraph { get; set; } // 0x000000018CB29C70-0x000000018CB29CB8 0x000000018CB29CB8-0x000000018CB29D10
		public override BBParameter subGraphParameter { get; } // 0x0000000187232C80-0x0000000187232C90 
	
		// Nested types
		public enum FSMExitMode // TypeDefIndex: 77056
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedFSMState(); // 0x000000018CB29C3C-0x000000018CB29C70
	
		// Methods
		protected override void OnEnter(); // 0x000000018CB29A58-0x000000018CB29B40
		protected override void OnUpdate(); // 0x000000018CB29BE8-0x000000018CB29C3C
		protected override void OnExit(); // 0x000000018CB29B40-0x000000018CB29BE8
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM starts/enters, if Conditions are met. This is not a state.")]
	[Icon("MacroIn", false, "")]
	[Name("On FSM Enter", 0)]
	public class OnFSMEnter : FSMNode, IUpdatable // TypeDefIndex: 77058
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public OnFSMEnter(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB2A690-0x000000018CB2A804
		public override void OnGraphStarted(); // 0x000000018CB2A568-0x000000018CB2A644
		public override void OnGraphStoped(); // 0x000000018CB2A644-0x000000018CB2A690
		void IUpdatable.Update(); // 0x000000018CB2A4FC-0x000000018CB2A568
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM stops/exits, if Conditions are met. Note that the actions will only execute for 1 frame. This is not a state.")]
	[Icon("MacroOut", false, "")]
	[Name("On FSM Exit", 0)]
	public class OnFSMExit : FSMNode // TypeDefIndex: 77059
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public OnFSMExit(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB2A928-0x000000018CB2AA9C
		public override void OnGraphStarted(); // 0x000000018CB2A804-0x000000018CB2A85C
		public override void OnGraphStoped(); // 0x000000018CB2A85C-0x000000018CB2A928
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions repeatedly and in parallel to any other FSM state while the FSM is running. Conditions are optional. This is not a state.")]
	[Icon("Repeat", false, "")]
	[Name("On FSM Update", 0)]
	public class OnFSMUpdate : FSMNode, IUpdatable // TypeDefIndex: 77060
	{
		// Fields
		[SerializeField]
		private NodeCanvas.Framework.ConditionList _conditionList; // 0x98
		[SerializeField]
		private ActionList _actionList; // 0xA0
	
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public OnFSMUpdate(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB2AB64-0x000000018CB2ACD8
		public override void OnGraphStarted(); // 0x000000018CB2A804-0x000000018CB2A85C
		public override void OnGraphStoped(); // 0x000000018CB2A644-0x000000018CB2A690
		void IUpdatable.Update(); // 0x000000018CB2AA9C-0x000000018CB2AB64
	}

	[Description("The Super Action State provides finer control on when to execute actions. This state is never Finished by it\'s own if there is any Actions in the OnUpdate list and thus OnFinish transitions will never be called in that case. OnExit Actions are only called for 1 frame when the state exits.")]
	[Name("Action State (Super)", 99)]
	public class SuperActionState : FSMState // TypeDefIndex: 77061
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
		public SuperActionState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB2D48C-0x000000018CB2D668
		protected override void OnEnter(); // 0x000000018CB2D2A4-0x000000018CB2D2B8
		protected override void OnUpdate(); // 0x000000018CB2D3A4-0x000000018CB2D48C
		protected override void OnExit(); // 0x000000018CB2D2B8-0x000000018CB2D368
		protected override void OnPause(); // 0x000000018CB2D368-0x000000018CB2D3A4
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions with optional conditional requirement and in parallel to any other state, as soon as the FSM is started. All actions will prematurely be stoped as soon as the FSM stops as well. This is not a state.")]
	[Icon("Repeat", false, "")]
	[Name("Parallel", 0)]
	[Obsolete("Use On FSM Update node")]
	public class ConcurrentState : FSMNode, IUpdatable // TypeDefIndex: 77062
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
		public NodeCanvas.Framework.ConditionList conditionList { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public ActionList actionList { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public bool repeatStateActions { get; set; } // 0x000000018225E110-0x000000018225E120 0x000000018225E120-0x000000018225E130
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public ConcurrentState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB1D5B8-0x000000018CB1D708
		public override void OnGraphStarted(); // 0x000000018CB1D504-0x000000018CB1D564
		public override void OnGraphStoped(); // 0x000000018CB1D564-0x000000018CB1D5B8
		public override void OnGraphPaused(); // 0x000000018CB1C2EC-0x000000018CB1C310
		void IUpdatable.Update(); // 0x000000018CB1D3F8-0x000000018CB1D504
	}

	[Color("ff64cb")]
	[Description("Execute a number of Actions when the FSM enters/starts and when it exits/stops. This is not a state.")]
	[Icon("MacroIn", false, "")]
	[Name("Enter | Exit", 0)]
	[Obsolete("Use On FSM Enter and On FSM Exit nodes")]
	public class EnterExitState : FSMNode, IUpdatable // TypeDefIndex: 77063
	{
		// Fields
		[SerializeField]
		private ActionList _actionListEnter; // 0x98
		[SerializeField]
		private ActionList _actionListExit; // 0xA0
	
		// Properties
		public ActionList actionListEnter { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public ActionList actionListExit { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public EnterExitState(); // 0x0000000186B55770-0x0000000186B55780
	
		// Methods
		public override void OnValidate(NodeCanvas.Framework.Graph assignedGraph); // 0x000000018CB2291C-0x000000018CB22A54
		public override void OnGraphStarted(); // 0x000000018CB22820-0x000000018CB22888
		public override void OnGraphStoped(); // 0x000000018CB22888-0x000000018CB2291C
		void IUpdatable.Update(); // 0x000000018CB227B4-0x000000018CB22820
	}

	[Category("SubGraphs")]
	[Color("ff64cb")]
	[Description("Execute a Sub FlowScript in parallel and for as long as this FSM is running.")]
	[Name("Parallel Sub FlowScript", -1)]
	public class ConcurrentSubFlowScript : FSMNodeNested<FlowScript>, IUpdatable // TypeDefIndex: 77064
	{
		// Fields
		[ExposeField]
		[Name("Parallel FlowScript", 0)]
		[SerializeField]
		protected BBParameter<FlowScript> _subFlowScript; // 0xB0
	
		// Properties
		public override string name { get; } // 0x000000018CB1C1E4-0x000000018CB1C208 
		public override int maxInConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override int maxOutConnections { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool allowAsPrime { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override FlowScript subGraph { get; set; } // 0x000000018CB1D9D8-0x000000018CB1DA20 0x000000018CB1DA20-0x000000018CB1DA78
		public override BBParameter subGraphParameter { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Constructors
		public ConcurrentSubFlowScript(); // 0x000000018CB1D9A4-0x000000018CB1D9D8
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018CB1D8C4-0x000000018CB1D9A4
		void IUpdatable.Update(); // 0x000000018CB1D708-0x000000018CB1D710
		[CompilerGenerated]
		private void _OnGraphStarted_b__14_0(bool result); // 0x000000018CB0B430-0x000000018CB0B450
	}

	[Description("Adds a FlowCanvas FlowScript as a nested State of the FSM. The FlowScript State is never finished by itself, unless a \'Finish\' node is used in the FlowScript. Success/Failure events can optionlay be used alongside with a CheckEvent on state transitions to catch whether the FlowScript Finished in success or failure.")]
	[DropReferenceType(typeof(FlowScript))]
	[Name("Sub FlowScript", 0)]
	public class FlowScriptState : FSMStateNested<FlowScript> // TypeDefIndex: 77065
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
		public override FlowScript subGraph { get; set; } // 0x000000018CB23034-0x000000018CB2307C 0x000000018CB2307C-0x000000018CB230D4
		public override BBParameter subGraphParameter { get; } // 0x0000000187232C80-0x0000000187232C90 
	
		// Constructors
		public FlowScriptState(); // 0x000000018CB23000-0x000000018CB23034
	
		// Methods
		protected override void OnEnter(); // 0x000000018CB22DC8-0x000000018CB22EA4
		protected override void OnUpdate(); // 0x000000018CB22FAC-0x000000018CB23000
		private void OnFlowScriptFinished(bool success); // 0x000000018CB22F34-0x000000018CB22FAC
		protected override void OnExit(); // 0x000000018CB22EA4-0x000000018CB22F34
	}
}

namespace NodeCanvas.Tasks.Actions
{
	[Category("Animation")]
	public class PlayAnimationAdvanced : ActionTask<UnityEngine.Animation> // TypeDefIndex: 76890
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
		protected override string info { get; } // 0x000000018CB1608C-0x000000018CB160E4 
	
		// Constructors
		public PlayAnimationAdvanced(); // 0x000000018CB16008-0x000000018CB1608C
	
		// Methods
		protected override string OnInit(); // 0x000000018CB15E88-0x000000018CB15F6C
		protected override void OnExecute(); // 0x000000018CB159C0-0x000000018CB15E88
		protected override void OnUpdate(); // 0x000000018CB15F6C-0x000000018CB16008
		private Transform FindTransform(Transform parent, string name); // 0x000000018CB158DC-0x000000018CB159C0
	}

	[Category("Animation")]
	public class PlayAnimationSimple : ActionTask<UnityEngine.Animation> // TypeDefIndex: 76891
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
		protected override string info { get; } // 0x000000018CB16568-0x000000018CB165C0 
	
		// Constructors
		public PlayAnimationSimple(); // 0x000000018CB16524-0x000000018CB16568
		static PlayAnimationSimple(); // 0x000000018CB16498-0x000000018CB16524
	
		// Methods
		protected override string OnInit(); // 0x000000018CB16330-0x000000018CB16414
		protected override void OnExecute(); // 0x000000018CB160E4-0x000000018CB16330
		protected override void OnUpdate(); // 0x000000018CB16414-0x000000018CB16498
	}

	[Category("Animator")]
	[Name("Play Animation", 0)]
	public class MecanimPlayAnimation : ActionTask<Animator> // TypeDefIndex: 76892
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
		protected override string info { get; } // 0x000000018CB13DC8-0x000000018CB13E30 
	
		// Constructors
		public MecanimPlayAnimation(); // 0x000000018CB13D7C-0x000000018CB13DC8
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB13A84-0x000000018CB13BF0
		protected override void OnUpdate(); // 0x000000018CB13BF0-0x000000018CB13D7C
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Bool", 0)]
	public class MecanimSetBool : ActionTask<Animator> // TypeDefIndex: 76893
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<bool> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB13FBC-0x000000018CB1406C 
	
		// Constructors
		public MecanimSetBool(); // 0x000000018CB13F80-0x000000018CB13FBC
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB13E30-0x000000018CB13F80
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Float", 0)]
	public class MecanimSetFloat : ActionTask<Animator> // TypeDefIndex: 76894
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<float> setTo; // 0x78
		[SliderField(0, 1)]
		public float transitTime; // 0x80
		private float currentValue; // 0x84
	
		// Properties
		protected override string info { get; } // 0x000000018CB143E0-0x000000018CB14490 
	
		// Constructors
		public MecanimSetFloat(); // 0x000000018CB14390-0x000000018CB143E0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB14158-0x000000018CB141DC
		protected override void OnUpdate(); // 0x000000018CB141DC-0x000000018CB14290
		private float Get(); // 0x000000018CB1406C-0x000000018CB14158
		private void Set(float newValue); // 0x000000018CB14290-0x000000018CB14390
	}

	[Category("Animator")]
	[Name("Set IK", 0)]
	public class MecanimSetIK : ActionTask<Animator> // TypeDefIndex: 76895
	{
		// Fields
		public AvatarIKGoal IKGoal; // 0x68
		[RequiredField]
		public BBParameter<GameObject> goal; // 0x70
		public BBParameter<float> weight; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB14724-0x000000018CB147E4 
	
		// Constructors
		public MecanimSetIK(); // 0x000000018CB146E8-0x000000018CB14724
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB145B8-0x000000018CB14650
		protected override void OnStop(); // 0x000000018CB14650-0x000000018CB146E8
		private void OnAnimatorIK(EventData<int> msg); // 0x000000018CB14490-0x000000018CB145B8
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Integer", 0)]
	public class MecanimSetInt : ActionTask<Animator> // TypeDefIndex: 76896
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<int> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB14964-0x000000018CB14A14 
	
		// Constructors
		public MecanimSetInt(); // 0x000000018CB14928-0x000000018CB14964
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB147E4-0x000000018CB14928
	}

	[Category("Animator")]
	[Name("Set Layer Weight", 0)]
	public class MecanimSetLayerWeight : ActionTask<Animator> // TypeDefIndex: 76897
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
		[SliderField(0, 1)]
		public BBParameter<float> layerWeight; // 0x70
		[SliderField(0, 1)]
		public float transitTime; // 0x78
		private float currentValue; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x000000018CB14BF8-0x000000018CB14C9C 
	
		// Constructors
		public MecanimSetLayerWeight(); // 0x000000018CB14BBC-0x000000018CB14BF8
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB14A14-0x000000018CB14A98
		protected override void OnUpdate(); // 0x000000018CB14A98-0x000000018CB14BBC
	}

	[Category("Animator")]
	[Name("Set Look At", 0)]
	public class MecanimSetLookAt : ActionTask<Animator> // TypeDefIndex: 76898
	{
		// Fields
		public BBParameter<GameObject> targetPosition; // 0x68
		public BBParameter<float> targetWeight; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB14F20-0x000000018CB14F80 
	
		// Constructors
		public MecanimSetLookAt(); // 0x000000018CB14EE4-0x000000018CB14F20
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB14DB4-0x000000018CB14E4C
		protected override void OnStop(); // 0x000000018CB14E4C-0x000000018CB14EE4
		private void OnAnimatorIK(EventData<int> msg); // 0x000000018CB14C9C-0x000000018CB14DB4
	}

	[Category("Animator")]
	[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
	[Name("Set Parameter Trigger", 0)]
	public class MecanimSetTrigger : ActionTask<Animator> // TypeDefIndex: 76899
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB150B4-0x000000018CB15160 
	
		// Constructors
		public MecanimSetTrigger(); // 0x000000018CB15078-0x000000018CB150B4
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB14F80-0x000000018CB15078
	}

	[Category("Application")]
	public class LoadScene : ActionTask // TypeDefIndex: 76900
	{
		// Fields
		[RequiredField]
		public BBParameter<string> sceneName; // 0x68
		public BBParameter<LoadSceneMode> mode; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB13890-0x000000018CB138D0 
	
		// Constructors
		public LoadScene(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB137E0-0x000000018CB13890
	}

	[Category("Audio")]
	public class PlayAudioAtPosition : ActionTask<Transform> // TypeDefIndex: 76901
	{
		// Fields
		[RequiredField]
		public BBParameter<AudioClip> audioClip; // 0x68
		[SliderField(0, 1)]
		public float volume; // 0x70
		public bool waitActionFinish; // 0x74
	
		// Properties
		protected override string info { get; } // 0x000000018CB16748-0x000000018CB167A0 
	
		// Constructors
		public PlayAudioAtPosition(); // 0x000000018CB166FC-0x000000018CB16748
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB165C0-0x000000018CB1667C
		protected override void OnUpdate(); // 0x000000018CB1667C-0x000000018CB166FC
	}

	[Category("\u272B Blackboard")]
	[Description("Create a new Vector out of 3 floats and save it to the blackboard")]
	public class ComposeVector : ActionTask // TypeDefIndex: 76902
	{
		// Fields
		public BBParameter<float> x; // 0x68
		public BBParameter<float> y; // 0x70
		public BBParameter<float> z; // 0x78
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CB070D4-0x000000018CB07138 
	
		// Constructors
		public ComposeVector(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB06FF4-0x000000018CB070D4
	}

	[Category("\u272B Blackboard")]
	[Description("Create up to 3 floats from a Vector and save them to blackboard")]
	public class DecomposeVector : ActionTask // TypeDefIndex: 76903
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
		protected override string info { get; } // 0x000000018CB08364-0x000000018CB083C4 
	
		// Constructors
		public DecomposeVector(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0825C-0x000000018CB08364
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class AddElementToDictionary<T> : ActionTask // TypeDefIndex: 76904
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
	public class GetDictionaryElement<T> : ActionTask // TypeDefIndex: 76905
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
	public class EvaluateCurve : ActionTask // TypeDefIndex: 76906
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
		public EvaluateCurve(); // 0x000000018CB0867C-0x000000018CB086F8
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB08508-0x000000018CB0867C
	}

	[Category("\u272B Blackboard")]
	[Description("Stores the agent gameobject on the blackboard.")]
	public class GetSelf : ActionTask // TypeDefIndex: 76907
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x68
	
		// Constructors
		public GetSelf(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB110AC-0x000000018CB11128
	}

	[Category("\u272B Blackboard")]
	[Description("Use this to get a variable on any blackboard by overriding the agent")]
	public class GetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 76908
	{
		// Fields
		[RequiredField]
		public BBParameter<string> targetVariableName; // 0x68
		[BlackboardOnly]
		public BBObjectParameter saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB103EC-0x000000018CB10430 
	
		// Constructors
		public GetOtherBlackboardVariable(); // 0x000000018CB103B0-0x000000018CB103EC
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB102E4-0x000000018CB103B0
	}

	[Category("\u272B Blackboard")]
	[Name("Get Variable To String", 0)]
	public class GetToString : ActionTask // TypeDefIndex: 76909
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> variable; // 0x68
		[BlackboardOnly]
		public BBParameter<string> toString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB111E8-0x000000018CB1122C 
	
		// Constructors
		public GetToString(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB11128-0x000000018CB111E8
	}

	[Category("\u272B Blackboard/Lists")]
	public class AddElementToList<T> : ActionTask // TypeDefIndex: 76910
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
	public class ClearList : ActionTask // TypeDefIndex: 76911
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB06FB4-0x000000018CB06FF4 
	
		// Constructors
		public ClearList(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB06F50-0x000000018CB06FB4
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Get the closer game object to the agent from within a list of game objects and save it in the blackboard.")]
	public class GetCloserGameObjectInList : ActionTask<Transform> // TypeDefIndex: 76912
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> list; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0E3D4-0x000000018CB0E478 
	
		// Constructors
		public GetCloserGameObjectInList(); // 0x000000018CB0E398-0x000000018CB0E3D4
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0E0C8-0x000000018CB0E398
	}

	[Category("\u272B Blackboard/Lists")]
	public class GetIndexOfElement<T> : ActionTask // TypeDefIndex: 76913
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
	public class GetListCount : ActionTask // TypeDefIndex: 76914
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
		[BlackboardOnly]
		public BBParameter<int> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB10124-0x000000018CB10168 
	
		// Constructors
		public GetListCount(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB10094-0x000000018CB10124
	}

	[Category("\u272B Blackboard/Lists")]
	public class InsertElementToList<T> : ActionTask // TypeDefIndex: 76915
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
	public class PickListElement<T> : ActionTask // TypeDefIndex: 76916
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
	public class PickRandomListElement<T> : ActionTask // TypeDefIndex: 76917
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
	public class RemoveElementFromList<T> : ActionTask // TypeDefIndex: 76918
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
	public class SetListElement<T> : ActionTask // TypeDefIndex: 76919
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
	public class ShuffleList : ActionTask // TypeDefIndex: 76920
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Constructors
		public ShuffleList(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1A348-0x000000018CB1A448
	}

	[Category("\u272B Blackboard/Lists")]
	[Description("Will sort the gameobjects in the target list by their distance to the agent (closer first) and save that list to the blackboard")]
	public class SortGameObjectListByDistance : ActionTask<Transform> // TypeDefIndex: 76921
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<List<GameObject>> targetList; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
		public bool reverse; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB1A6A0-0x000000018CB1A744 
	
		// Constructors
		public SortGameObjectListByDistance(); // 0x000000018CB1A664-0x000000018CB1A6A0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1A448-0x000000018CB1A5A0
		[CompilerGenerated]
		private float _OnExecute_b__5_0(GameObject go); // 0x000000018CB1A5A0-0x000000018CB1A664
	}

	[Category("\u272B Blackboard")]
	[Description("Loads the blackboard variables previously saved in the provided PlayerPrefs key if at all. Returns false if no saves found or load was failed")]
	public class LoadBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 76922
	{
		// Fields
		[RequiredField]
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB13788-0x000000018CB137E0 
	
		// Constructors
		public LoadBlackboard(); // 0x000000018CB1374C-0x000000018CB13788
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB136C0-0x000000018CB1374C
	}

	[Category("\u272B Blackboard")]
	public class NormalizeVector : ActionTask // TypeDefIndex: 76923
	{
		// Fields
		public BBParameter<Vector3> targetVector; // 0x68
		public BBParameter<float> multiply; // 0x70
	
		// Constructors
		public NormalizeVector(); // 0x000000018CB15888-0x000000018CB158DC
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB15774-0x000000018CB15888
	}

	[Category("\u272B Blackboard")]
	public class SampleCurve : ActionTask // TypeDefIndex: 76924
	{
		// Fields
		[RequiredField]
		public BBParameter<AnimationCurve> curve; // 0x68
		[SliderField(0, 1)]
		public BBParameter<float> sampleAt; // 0x70
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x78
	
		// Constructors
		public SampleCurve(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB170F0-0x000000018CB171B4
	}

	[Category("\u272B Blackboard")]
	[Description("Saves the blackboard variables in the provided key and to be loaded later on")]
	public class SaveBlackboard : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 76925
	{
		// Fields
		[RequiredField]
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB1727C-0x000000018CB172D4 
	
		// Constructors
		public SaveBlackboard(); // 0x000000018CB17240-0x000000018CB1727C
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB171B4-0x000000018CB17240
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard boolean variable")]
	public class SetBoolean : ActionTask // TypeDefIndex: 76927
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<bool> boolVariable; // 0x68
		public BoolSetModes setTo; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB17EA8-0x000000018CB17F90 
	
		// Nested types
		public enum BoolSetModes // TypeDefIndex: 76926
		{
			False = 0,
			True = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetBoolean(); // 0x0000000187254330-0x0000000187254340
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB17E10-0x000000018CB17EA8
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard boolean variable at random between min and max value")]
	public class SetBooleanRandom : ActionTask // TypeDefIndex: 76928
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> boolVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB17D9C-0x000000018CB17E10 
	
		// Constructors
		public SetBooleanRandom(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB17D28-0x000000018CB17D9C
	}

	[Category("\u272B Blackboard")]
	public class SetEnum : ActionTask // TypeDefIndex: 76929
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB18108-0x000000018CB18190 
	
		// Constructors
		public SetEnum(); // 0x000000018CB18014-0x000000018CB18108
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB17F90-0x000000018CB18014
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard float variable")]
	public class SetFloat : ActionTask // TypeDefIndex: 76930
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<float> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CB188B8-0x000000018CB189E4 
	
		// Constructors
		public SetFloat(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB187C8-0x000000018CB188B8
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard float variable at random between min and max value")]
	public class SetFloatRandom : ActionTask // TypeDefIndex: 76931
	{
		// Fields
		public BBParameter<float> minValue; // 0x68
		public BBParameter<float> maxValue; // 0x70
		[BlackboardOnly]
		public BBParameter<float> floatVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB1866C-0x000000018CB187C8 
	
		// Constructors
		public SetFloatRandom(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018581C4F0-0x000000018581C5C0
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard integer variable")]
	[Name("Set Integer", 0)]
	public class SetInt : ActionTask // TypeDefIndex: 76932
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<int> valueA; // 0x68
		public OperationMethod Operation; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB18C9C-0x000000018CB18D18 
	
		// Constructors
		public SetInt(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB18BF0-0x000000018CB18C9C
	}

	[Category("\u272B Blackboard")]
	[Description("Set a blackboard integer variable at random between min and max value")]
	[Name("Set Integer Random", 0)]
	public class SetIntRandom : ActionTask // TypeDefIndex: 76933
	{
		// Fields
		public BBParameter<int> minValue; // 0x68
		public BBParameter<int> maxValue; // 0x70
		[BlackboardOnly]
		public BBParameter<int> intVariable; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB18A94-0x000000018CB18BF0 
	
		// Constructors
		public SetIntRandom(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB189E4-0x000000018CB18A94
	}

	[Category("\u272B Blackboard")]
	[Description("Use this to set a variable on any blackboard by overriding the agent")]
	public class SetOtherBlackboardVariable : ActionTask<NodeCanvas.Framework.Blackboard> // TypeDefIndex: 76934
	{
		// Fields
		[RequiredField]
		public BBParameter<string> targetVariableName; // 0x68
		public BBObjectParameter newValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB19254-0x000000018CB192F0 
	
		// Constructors
		public SetOtherBlackboardVariable(); // 0x000000018CB19218-0x000000018CB19254
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB19158-0x000000018CB19218
	}

	[Category("\u272B Blackboard")]
	public class SetVariable<T> : ActionTask // TypeDefIndex: 76935
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
	public class SetVector3 : ActionTask // TypeDefIndex: 76936
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> valueA; // 0x68
		public OperationMethod operation; // 0x70
		public BBParameter<Vector3> valueB; // 0x78
		public bool perSecond; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CB19CE0-0x000000018CB19E0C 
	
		// Constructors
		public SetVector3(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB19BB4-0x000000018CB19CE0
	}

	[Category("\u272B Blackboard")]
	[Description("Triggers a boolean variable for 1 frame to True then back to False")]
	public class TriggerBoolean : ActionTask // TypeDefIndex: 76938
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<bool> variable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB1B054-0x000000018CB1B094 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Flip_d__4 : IEnumerator<object> // TypeDefIndex: 76937
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TriggerBoolean __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Flip_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB1B094-0x000000018CB1B120
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB1B120-0x000000018CB1B16C
		}
	
		// Constructors
		public TriggerBoolean(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1AFC0-0x000000018CB1B054
		[IteratorStateMachine(typeof(_Flip_d__4))]
		private IEnumerator Flip(); // 0x000000018CB1AF64-0x000000018CB1AFC0
	}

	[Category("Camera")]
	public class FadeIn : ActionTask // TypeDefIndex: 76939
	{
		// Constructors
		public FadeIn(); // 0x000000018723B3B0-0x000000018723B3C0
	}

	[Category("Camera")]
	public class FadeOut : ActionTask // TypeDefIndex: 76940
	{
		// Constructors
		public FadeOut(); // 0x000000018723B3B0-0x000000018723B3C0
	}

	[Category("Dialogue")]
	[Description("You can use a variable inline with the text by using brackets likeso: [myVarName] or [Global/myVarName].\nThe bracket will be replaced with the variable value ToString")]
	[Icon("Dialogue", false, "")]
	public class Say : ActionTask<IDialogueActor> // TypeDefIndex: 76941
	{
		// Fields
		public Statement statement; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB17650-0x000000018CB176C8 
	
		// Constructors
		public Say(); // 0x000000018CB175C4-0x000000018CB17650
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB174B8-0x000000018CB175C4
	}

	[Category("Dialogue")]
	[Description("A random statement will be chosen each time for the actor to say")]
	[Icon("Dialogue", false, "")]
	public class SayRandom : ActionTask<IDialogueActor> // TypeDefIndex: 76942
	{
		// Fields
		public List<Statement> statements; // 0x68
	
		// Constructors
		public SayRandom(); // 0x000000018CB1742C-0x000000018CB174B8
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB172D4-0x000000018CB1742C
	}

	[Category("Dialogue")]
	[Description("Starts the Dialogue Tree assigned on a Dialogue Tree Controller object with specified agent used for \'Instigator\'.")]
	[Icon("Dialogue", false, "")]
	public class StartDialogueTree : ActionTask<IDialogueActor> // TypeDefIndex: 76943
	{
		// Fields
		[RequiredField]
		public BBParameter<DialogueTreeController> dialogueTreeController; // 0x68
		public bool waitActionFinish; // 0x70
		public bool isPrefab; // 0x71
		private DialogueTreeController instance; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB1AA08-0x000000018CB1AA48 
	
		// Constructors
		public StartDialogueTree(); // 0x000000018CB1A9C4-0x000000018CB1AA08
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1A744-0x000000018CB1A8E0
		[CompilerGenerated]
		private void _OnExecute_b__6_0(bool success); // 0x000000018CB1A8E0-0x000000018CB1A964
		[CompilerGenerated]
		private void _OnExecute_b__6_1(bool success); // 0x000000018CB1A964-0x000000018CB1A9C4
	}

	[Category("GameObject")]
	public class CreateGameObject : ActionTask // TypeDefIndex: 76944
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x80
	
		// Constructors
		public CreateGameObject(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB07138-0x000000018CB072B8
	}

	[Category("GameObject")]
	public class CreatePrimitive : ActionTask // TypeDefIndex: 76945
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		public BBParameter<PrimitiveType> type; // 0x80
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x88
	
		// Constructors
		public CreatePrimitive(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB072B8-0x000000018CB07450
	}

	[Category("GameObject")]
	public class DestroyGameObject : ActionTask<Transform> // TypeDefIndex: 76946
	{
		// Fields
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB084C0-0x000000018CB08508 
	
		// Constructors
		public DestroyGameObject(); // 0x000000018CB08484-0x000000018CB084C0
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB083C4-0x000000018CB08484
	}

	[Category("GameObject")]
	[Description("Action will end in Failure if no objects are found")]
	public class FindAllWithLayer : ActionTask // TypeDefIndex: 76947
	{
		// Fields
		[RequiredField]
		public BBParameter<LayerMask> targetLayers; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0CC34-0x000000018CB0CCD8 
	
		// Constructors
		public FindAllWithLayer(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0CB54-0x000000018CB0CC34
	}

	[Category("GameObject")]
	[Description("Note that this is slow.\nAction will end in Failure if no objects are found")]
	public class FindAllWithName : ActionTask // TypeDefIndex: 76948
	{
		// Fields
		[RequiredField]
		public BBParameter<string> searchName; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0CED4-0x000000018CB0CF78 
	
		// Constructors
		public FindAllWithName(); // 0x000000018CB0CE74-0x000000018CB0CED4
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0CCD8-0x000000018CB0CE74
	}

	[Category("GameObject")]
	[Description("Action will end in Failure if no objects are found")]
	public class FindAllWithTag : ActionTask // TypeDefIndex: 76949
	{
		// Fields
		[RequiredField]
		[TagField]
		public BBParameter<string> searchTag; // 0x68
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0D0B8-0x000000018CB0D15C 
	
		// Constructors
		public FindAllWithTag(); // 0x000000018CB0D058-0x000000018CB0D0B8
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0CF78-0x000000018CB0D058
	}

	[Category("GameObject")]
	[Description("Find a transform child by name within the agent\'s transform")]
	public class FindChildByName : ActionTask<Transform> // TypeDefIndex: 76950
	{
		// Fields
		[RequiredField]
		public BBParameter<string> childName; // 0x68
		[BlackboardOnly]
		public BBParameter<Transform> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0D270-0x000000018CB0D2D4 
	
		// Constructors
		public FindChildByName(); // 0x000000018CB0D234-0x000000018CB0D270
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0D15C-0x000000018CB0D234
	}

	[Category("GameObject")]
	[Description("Find the closest game object of tag to the agent")]
	public class FindClosestWithTag : ActionTask<Transform> // TypeDefIndex: 76951
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
		public FindClosestWithTag(); // 0x000000018CB0D66C-0x000000018CB0D6A8
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0D3A0-0x000000018CB0D66C
	}

	[Category("GameObject")]
	[Description("Note that this is very slow")]
	public class FindObjectOfType<T> : ActionTask // TypeDefIndex: 76952
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
	public class FindObjectsOfType<T> : ActionTask // TypeDefIndex: 76954
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
		private sealed class __c // TypeDefIndex: 76953
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
	public class FindWithName : ActionTask // TypeDefIndex: 76955
	{
		// Fields
		[RequiredField]
		public BBParameter<string> gameObjectName; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0D734-0x000000018CB0D7D8 
	
		// Constructors
		public FindWithName(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0D6A8-0x000000018CB0D734
	}

	[Category("GameObject")]
	public class FindWithTag : ActionTask // TypeDefIndex: 76956
	{
		// Fields
		[RequiredField]
		[TagField]
		public string searchTag; // 0x68
		[BlackboardOnly]
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0D88C-0x000000018CB0D91C 
	
		// Constructors
		public FindWithTag(); // 0x000000018CB0D844-0x000000018CB0D88C
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0D7D8-0x000000018CB0D844
	}

	[Category("GameObject")]
	public class GetAllChildGameObjects : ActionTask<Transform> // TypeDefIndex: 76958
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs; // 0x68
		public bool recursive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0E024-0x000000018CB0E0C8 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76957
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, GameObject> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB1B710-0x000000018CB1B774
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal GameObject _OnExecute_b__4_0(Transform t); // 0x000000018A07367C-0x000000018A07369C
		}
	
		// Constructors
		public GetAllChildGameObjects(); // 0x000000018CB0DFE8-0x000000018CB0E024
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0DC20-0x000000018CB0DFE8
		private List<Transform> Get(Transform parent); // 0x000000018CB0D9BC-0x000000018CB0DC20
	}

	[Category("GameObject")]
	public class GetComponent<T> : ActionTask<Transform> // TypeDefIndex: 76959
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
	public class GetDistance : ActionTask<Transform> // TypeDefIndex: 76960
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0E5DC-0x000000018CB0E634 
	
		// Constructors
		public GetDistance(); // 0x000000018CB0E5A0-0x000000018CB0E5DC
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0E478-0x000000018CB0E5A0
	}

	[Category("GameObject")]
	[Obsolete("Use Get Property instead")]
	public class GetGameObjectPosition : ActionTask<Transform> // TypeDefIndex: 76961
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB0EC10-0x000000018CB0ECA8 
	
		// Constructors
		public GetGameObjectPosition(); // 0x000000018CB0EBD4-0x000000018CB0EC10
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0EB30-0x000000018CB0EBD4
	}

	[Category("GameObject")]
	public class InstantiateGameObject : ActionTask<Transform> // TypeDefIndex: 76962
	{
		// Fields
		public BBParameter<Transform> parent; // 0x68
		public BBParameter<Vector3> clonePosition; // 0x70
		public BBParameter<Vector3> cloneRotation; // 0x78
		[BlackboardOnly]
		public BBParameter<GameObject> saveCloneAs; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CB12874-0x000000018CB12A58 
	
		// Constructors
		public InstantiateGameObject(); // 0x000000018CB12838-0x000000018CB12874
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB12674-0x000000018CB12838
	}

	[Category("GameObject")]
	public class LookAt : ActionTask<Transform> // TypeDefIndex: 76963
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> lookTarget; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB13A24-0x000000018CB13A84 
	
		// Constructors
		public LookAt(); // 0x000000018CB139E8-0x000000018CB13A24
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB139E0-0x000000018CB139E8
		protected override void OnUpdate(); // 0x000000018CB139E0-0x000000018CB139E8
		private void DoLook(); // 0x000000018CB138D0-0x000000018CB139E0
	}

	[Category("GameObject")]
	public class RemoveComponent<T> : ActionTask<Transform> // TypeDefIndex: 76964
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
	public class SetObjectActive : ActionTask<Transform> // TypeDefIndex: 76966
	{
		// Fields
		public SetActiveMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB18E1C-0x000000018CB18E98 
	
		// Nested types
		public enum SetActiveMode // TypeDefIndex: 76965
		{
			Deactivate = 0,
			Activate = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectActive(); // 0x000000018CB18DD0-0x000000018CB18E1C
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB18D18-0x000000018CB18DD0
	}

	[Category("GameObject")]
	[Description("Set the monobehaviour\'s enabled state.")]
	[Name("Set Enabled", 0)]
	public class SetObjectEnabled : ActionTask<MonoBehaviour> // TypeDefIndex: 76968
	{
		// Fields
		public SetEnableMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB18F7C-0x000000018CB18FF8 
	
		// Nested types
		public enum SetEnableMode // TypeDefIndex: 76967
		{
			Disable = 0,
			Enable = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectEnabled(); // 0x000000018CB18F30-0x000000018CB18F7C
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB18E98-0x000000018CB18F30
	}

	[Category("GameObject")]
	[Description("Set the Renderer active state, thus making the object visible or invisible.")]
	[Name("Set Visibility", 0)]
	public class SetObjectVisibility : ActionTask<Renderer> // TypeDefIndex: 76970
	{
		// Fields
		public SetVisibleMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB190DC-0x000000018CB19158 
	
		// Nested types
		public enum SetVisibleMode // TypeDefIndex: 76969
		{
			Hide = 0,
			Show = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectVisibility(); // 0x000000018CB19090-0x000000018CB190DC
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB18FF8-0x000000018CB19090
	}

	[Category("Input (Legacy System)")]
	public class GetInputAxis : ActionTask // TypeDefIndex: 76971
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
		public GetInputAxis(); // 0x000000018CB0EF6C-0x000000018CB0F02C
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0EF64-0x000000018CB0EF6C
		protected override void OnUpdate(); // 0x000000018CB0EF64-0x000000018CB0EF6C
		private void Do(); // 0x000000018CB0ECA8-0x000000018CB0EF64
	}

	[Category("Input (Legacy System)")]
	public class GetMousePosition : ActionTask // TypeDefIndex: 76972
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Constructors
		public GetMousePosition(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB101F0-0x000000018CB101F8
		protected override void OnUpdate(); // 0x000000018CB101F0-0x000000018CB101F8
		private void Do(); // 0x000000018CB10168-0x000000018CB101F0
	}

	[Category("Input (Legacy System)")]
	public class GetMouseScrollDelta : ActionTask // TypeDefIndex: 76973
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB10284-0x000000018CB102E4 
	
		// Constructors
		public GetMouseScrollDelta(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1027C-0x000000018CB10284
		protected override void OnUpdate(); // 0x000000018CB1027C-0x000000018CB10284
		private void Do(); // 0x000000018CB101F8-0x000000018CB1027C
	}

	[Category("Input (Legacy System)")]
	public class WaitMousePick : ActionTask // TypeDefIndex: 76975
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
		protected override string info { get; } // 0x000000018CB1BCB0-0x000000018CB1BD14 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 76974
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick(); // 0x0000000187254370-0x0000000187254390
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB1BAF0-0x000000018CB1BCB0
	}

	[Category("Input (Legacy System)")]
	public class WaitMousePick2D : ActionTask // TypeDefIndex: 76977
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
		protected override string info { get; } // 0x000000018CB1BA8C-0x000000018CB1BAF0 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 76976
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick2D(); // 0x0000000187254370-0x0000000187254390
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB1B820-0x000000018CB1BA8C
	}

	[Category("Movement/Direct")]
	[Name("Curve Tween", 0)]
	public class CurveTransformTween : ActionTask<Transform> // TypeDefIndex: 76981
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
		public enum TransformMode // TypeDefIndex: 76978
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}
	
		public enum TweenMode // TypeDefIndex: 76979
		{
			Absolute = 0,
			Additive = 1
		}
	
		public enum PlayMode // TypeDefIndex: 76980
		{
			Normal = 0,
			PingPong = 1
		}
	
		// Constructors
		public CurveTransformTween(); // 0x000000018CB078A4-0x000000018CB07958
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB07450-0x000000018CB07684
		protected override void OnUpdate(); // 0x000000018CB07684-0x000000018CB078A4
	}

	[Category("Movement/Direct")]
	[Description("Move & turn the agent based on input values provided ranging from -1 to 1, per second (using delta time)")]
	public class InputMove : ActionTask<Transform> // TypeDefIndex: 76982
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
		public InputMove(); // 0x000000018CB125E8-0x000000018CB12674
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB120A0-0x000000018CB125E8
	}

	[Category("Movement/Direct")]
	[Description("Moves the agent away from target per frame without pathfinding")]
	public class MoveAway : ActionTask<Transform> // TypeDefIndex: 76983
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveAway(); // 0x000000018CB153EC-0x000000018CB1546C
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB15160-0x000000018CB153EC
	}

	[Category("Movement/Direct")]
	[Description("Moves the agent towards to target per frame without pathfinding")]
	public class MoveTowards : ActionTask<Transform> // TypeDefIndex: 76984
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveTowards(); // 0x000000018CB156F4-0x000000018CB15774
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB1546C-0x000000018CB156F4
	}

	[Category("Movement/Direct")]
	[Description("Rotate the agent away from target per frame")]
	public class RotateAway : ActionTask<Transform> // TypeDefIndex: 76985
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
		public RotateAway(); // 0x000000018CB16BE8-0x000000018CB16CAC
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB16844-0x000000018CB16BE8
	}

	[Category("Movement/Direct")]
	[Description("Rotate the agent towards the target per frame")]
	public class RotateTowards : ActionTask<Transform> // TypeDefIndex: 76986
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
		public RotateTowards(); // 0x000000018CB1702C-0x000000018CB170F0
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB16CAC-0x000000018CB1702C
	}

	[Category("Movement/Pathfinding")]
	[Description("Find the closes Navigation Mesh position to the target position")]
	[Name("Find Closest NavMesh Edge", 0)]
	public class FindClosestEdge : ActionTask // TypeDefIndex: 76987
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		[BlackboardOnly]
		public BBParameter<Vector3> saveFoundPosition; // 0x70
		private NavMeshHit hit; // 0x78
	
		// Constructors
		public FindClosestEdge(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0D2D4-0x000000018CB0D3A0
	}

	[Category("Physics")]
	public class GetLinecastInfo : ActionTask<Transform> // TypeDefIndex: 76988
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
		public GetLinecastInfo(); // 0x000000018CB10038-0x000000018CB10094
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0FDC8-0x000000018CB10038
		public override void OnDrawGizmosSelected(); // 0x000000018CB0FC68-0x000000018CB0FDC8
	}

	[Category("Physics")]
	public class GetLinecastInfo2D : ActionTask<Transform> // TypeDefIndex: 76989
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
		public GetLinecastInfo2D(); // 0x000000018CB0FC1C-0x000000018CB0FC68
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0F940-0x000000018CB0FC1C
		public override void OnDrawGizmosSelected(); // 0x000000018CB0F7E0-0x000000018CB0F940
	}

	[Category("Physics")]
	[Description("Get hit info for ALL objects in the linecast, in Lists")]
	public class GetLinecastInfo2DAll : ActionTask<Transform> // TypeDefIndex: 76991
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
		private sealed class __c // TypeDefIndex: 76990
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RaycastHit2D, GameObject> __9__7_0; // 0x08
			public static Func<RaycastHit2D, float> __9__7_1; // 0x10
			public static Func<RaycastHit2D, Vector3> __9__7_3; // 0x18
	
			// Constructors
			static __c(); // 0x000000018CB1B6AC-0x000000018CB1B710
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal GameObject _OnExecute_b__7_0(RaycastHit2D h); // 0x000000018CB1B47C-0x000000018CB1B4A4
			internal float _OnExecute_b__7_1(RaycastHit2D h); // 0x0000000187254340-0x0000000187254350
			internal Vector3 _OnExecute_b__7_3(RaycastHit2D h); // 0x0000000187254350-0x0000000187254370
		}
	
		// Constructors
		public GetLinecastInfo2DAll(); // 0x000000018CB0F794-0x000000018CB0F7E0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0F18C-0x000000018CB0F6DC
		public override void OnDrawGizmosSelected(); // 0x000000018CB0F02C-0x000000018CB0F18C
		[CompilerGenerated]
		private Vector3 _OnExecute_b__7_2(RaycastHit2D h); // 0x000000018CB0F6DC-0x000000018CB0F794
	}

	[Category("Physics")]
	[Description("Gets a lists of game objects that are in the physics overlap sphere at the position of the agent, excluding the agent")]
	public class GetOverlapSphereObjects : ActionTask<Transform> // TypeDefIndex: 76993
	{
		// Fields
		public LayerMask layerMask; // 0x68
		public BBParameter<float> radius; // 0x70
		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveObjectsAs; // 0x78
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76992
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ECSColliderResultProxy, GameObject> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB1B580-0x000000018CB1B5E4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal GameObject _OnExecute_b__3_0(ECSColliderResultProxy c); // 0x000000018CB1B430-0x000000018CB1B47C
		}
	
		// Constructors
		public GetOverlapSphereObjects(); // 0x000000018CB107CC-0x000000018CB10834
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB10530-0x000000018CB107CC
		public override void OnDrawGizmosSelected(); // 0x000000018CB10430-0x000000018CB10530
	}

	[Category("\u272B Reflected")]
	[Description("Execute a function on a script and save the return if any.\nIf function is an IEnumerator it will execute as a coroutine.")]
	[Name("Execute Function", 10)]
	public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 76995
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
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		public override System.Type agentType { get; } // 0x000000018CB08FAC-0x000000018CB09070 
		protected override string info { get; } // 0x000000018CB09070-0x000000018CB093F0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _InternalCoroutine_d__17 : IEnumerator<object> // TypeDefIndex: 76994
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ExecuteFunction_Multiplatform __4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _InternalCoroutine_d__17(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB1B294-0x000000018CB1B384
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB1B384-0x000000018CB1B3D0
		}
	
		// Constructors
		public ExecuteFunction_Multiplatform(); // 0x000000018CB08F2C-0x000000018CB08FAC
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB08C24-0x000000018CB08C4C
		protected override string OnInit(); // 0x000000018CB08A90-0x000000018CB08C24
		protected override void OnExecute(); // 0x000000018CB087E8-0x000000018CB08A90
		protected override void OnStop(); // 0x00000001872542E0-0x00000001872542F0
		[IteratorStateMachine(typeof(_InternalCoroutine_d__17))]
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x000000018CB08770-0x000000018CB087E8
		private void SetMethod(MethodInfo method); // 0x000000018CB08C4C-0x000000018CB08F2C
	}

	internal class GetField_0 // TypeDefIndex: 76996
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string fieldName; // 0x18
	
		// Constructors
		public GetField_0(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("\u272B Reflected")]
	[Description("Get a variable of a script and save it to the blackboard")]
	[fsMigrateVersions(new System.Type[1] {typeof(GetField_0) })]
	[Name("Get Field", 6)]
	public class GetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.GetField_0> // TypeDefIndex: 76997
	{
		// Fields
		[SerializeField]
		protected SerializedFieldInfo field; // 0x68
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter saveAs; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get; } // 0x000000018B80FFD8-0x000000018B80FFE8 
		public override System.Type agentType { get; } // 0x000000018CB0E8EC-0x000000018CB0E9BC 
		protected override string info { get; } // 0x000000018CB0E9BC-0x000000018CB0EB30 
	
		// Constructors
		public GetField(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		void IMigratable<GetField_0>.Migrate(GetField_0 model); // 0x000000018CB0E784-0x000000018CB0E83C
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		protected override string OnInit(); // 0x000000018CB0E6EC-0x000000018CB0E784
		protected override void OnExecute(); // 0x000000018CB0E634-0x000000018CB0E6EC
		private void SetTargetField(System.Reflection.FieldInfo newField); // 0x000000018CB0E83C-0x000000018CB0E8EC
	}

	[Category("\u272B Reflected")]
	[Description("Get a property of a script and save it to the blackboard")]
	[Name("Get Property", 8)]
	public class GetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 76998
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[BlackboardOnly]
		[SerializeField]
		protected BBObjectParameter returnValue; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		public override System.Type agentType { get; } // 0x000000018CB10A50-0x000000018CB10B14 
		protected override string info { get; } // 0x000000018CB10B14-0x000000018CB10C7C 
	
		// Constructors
		public GetProperty_Multiplatform(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB10978-0x000000018CB109A0
		protected override string OnInit(); // 0x000000018CB108F0-0x000000018CB10978
		protected override void OnExecute(); // 0x000000018CB10834-0x000000018CB108F0
		private void SetMethod(MethodInfo method); // 0x000000018CB109A0-0x000000018CB10A50
	}

	[Category("\u272B Reflected")]
	[Description("Calls a function that has signature of \'public Status NAME()\' or \'public Status NAME(T)\'. You should return Status.Success, Failure or Running within that function.")]
	[Name("Implemented Action", 9)]
	public class ImplementedAction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 76999
	{
		// Fields
		[SerializeField]
		private SerializedMethodInfo method; // 0x68
		[SerializeField]
		private List<BBObjectParameter> parameters; // 0x70
		private NodeCanvas.Framework.Status actionStatus; // 0x78
		private object[] args; // 0x80
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		public override System.Type agentType { get; } // 0x000000018CB11A0C-0x000000018CB11AD0 
		protected override string info { get; } // 0x000000018CB11AD0-0x000000018CB11C8C 
	
		// Constructors
		public ImplementedAction_Multiplatform(); // 0x000000018CB11988-0x000000018CB11A0C
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB117E8-0x000000018CB11810
		protected override string OnInit(); // 0x000000018CB115A0-0x000000018CB11684
		protected override void OnUpdate(); // 0x000000018CB11684-0x000000018CB117E8
		protected override void OnStop(); // 0x0000000187254300-0x0000000187254310
		private void SetMethod(MethodInfo method); // 0x000000018CB11810-0x000000018CB11988
	}

	[Category("\u272B Reflected")]
	[Description("SendMessage to the agent, optionaly with an argument")]
	public class SendMessage : ActionTask<Transform> // TypeDefIndex: 77000
	{
		// Fields
		[RequiredField]
		public BBParameter<string> methodName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB17CE8-0x000000018CB17D28 
	
		// Constructors
		public SendMessage(); // 0x000000018CB17CAC-0x000000018CB17CE8
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB17C20-0x000000018CB17CAC
	}

	[Category("\u272B Reflected")]
	[Description("SendMessage to the agent, optionaly with an argument")]
	public class SendMessage<T> : ActionTask<Transform> // TypeDefIndex: 77001
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
	public class SendMessageToType<T> : ActionTask // TypeDefIndex: 77002
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

	internal class SetField_0 // TypeDefIndex: 77003
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string fieldName; // 0x18
	
		// Constructors
		public SetField_0(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("\u272B Reflected")]
	[Description("Set a variable on a script")]
	[fsMigrateVersions(new System.Type[1] {typeof(SetField_0) })]
	[Name("Set Field", 5)]
	public class SetField : ActionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Actions.SetField_0> // TypeDefIndex: 77004
	{
		// Fields
		[SerializeField]
		protected SerializedFieldInfo field; // 0x68
		[SerializeField]
		protected BBObjectParameter setValue; // 0x70
	
		// Properties
		private System.Reflection.FieldInfo targetField { get; } // 0x000000018B80FFD8-0x000000018B80FFE8 
		public override System.Type agentType { get; } // 0x000000018CB18448-0x000000018CB18518 
		protected override string info { get; } // 0x000000018CB18518-0x000000018CB1866C 
	
		// Constructors
		public SetField(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		void IMigratable<SetField_0>.Migrate(SetField_0 model); // 0x000000018CB182E0-0x000000018CB18398
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		protected override string OnInit(); // 0x000000018CB18248-0x000000018CB182E0
		protected override void OnExecute(); // 0x000000018CB18190-0x000000018CB18248
		private void SetTargetField(System.Reflection.FieldInfo newField); // 0x000000018CB18398-0x000000018CB18448
	}

	[Category("\u272B Reflected")]
	[Description("Set a property on a script")]
	[Name("Set Property", 7)]
	public class SetProperty_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 77005
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected BBObjectParameter parameter; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		public override System.Type agentType { get; } // 0x000000018CB19558-0x000000018CB1961C 
		protected override string info { get; } // 0x000000018CB1961C-0x000000018CB19784 
	
		// Constructors
		public SetProperty_Multiplatform(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB19464-0x000000018CB1948C
		protected override string OnInit(); // 0x000000018CB193DC-0x000000018CB19464
		protected override void OnExecute(); // 0x000000018CB192F0-0x000000018CB193DC
		private void SetMethod(MethodInfo method); // 0x000000018CB1948C-0x000000018CB19558
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nExecute a function on a script, of up to 6 parameters and save the return if any. If function is an IEnumerator it will execute as a coroutine.")]
	[Name("Execute Function (Desktop Only)", 10)]
	public class ExecuteFunction : ActionTask, IReflectedWrapper // TypeDefIndex: 77007
	{
		// Fields
		[SerializeField]
		protected ReflectedWrapper functionWrapper; // 0x68
		private bool routineRunning; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		public override System.Type agentType { get; } // 0x000000018CB097FC-0x000000018CB098C0 
		protected override string info { get; } // 0x000000018CB098C0-0x000000018CB09D28 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _InternalCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 77006
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ExecuteFunction __4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _InternalCoroutine_d__13(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB1B16C-0x000000018CB1B248
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB1B248-0x000000018CB1B294
		}
	
		// Constructors
		public ExecuteFunction(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018CB093F0-0x000000018CB09400
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB0975C-0x000000018CB097A8
		protected override string OnInit(); // 0x000000018CB09600-0x000000018CB0975C
		protected override void OnExecute(); // 0x000000018CB09400-0x000000018CB09600
		protected override void OnStop(); // 0x0000000187253E20-0x0000000187253E30
		[IteratorStateMachine(typeof(_InternalCoroutine_d__13))]
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x000000018CB086F8-0x000000018CB08770
		private void SetMethod(MethodInfo method); // 0x000000018CB097A8-0x000000018CB097FC
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nGet a property of a script and save it to the blackboard")]
	[Name("Get Property (Desktop Only)", 8)]
	public class GetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 77008
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		public override System.Type agentType { get; } // 0x000000018CB10E74-0x000000018CB10F38 
		protected override string info { get; } // 0x000000018CB10F38-0x000000018CB110AC 
	
		// Constructors
		public GetProperty(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018CB093F0-0x000000018CB09400
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB10DD4-0x000000018CB10E20
		protected override string OnInit(); // 0x000000018CB10CB8-0x000000018CB10DD4
		protected override void OnExecute(); // 0x000000018CB10C7C-0x000000018CB10CB8
		private void SetMethod(MethodInfo method); // 0x000000018CB10E20-0x000000018CB10E74
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCalls a function that has signature of \'public Status NAME()\' or \'public Status NAME(T)\'. You should return Status.Success, Failure or Running within that function.")]
	[Name("Implemented Action (Desktop Only)", 9)]
	public class ImplementedAction : ActionTask, IReflectedWrapper // TypeDefIndex: 77009
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		private NodeCanvas.Framework.Status actionStatus; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		public override System.Type agentType { get; } // 0x000000018CB11E18-0x000000018CB11EDC 
		protected override string info { get; } // 0x000000018CB11EDC-0x000000018CB120A0 
	
		// Constructors
		public ImplementedAction(); // 0x0000000187254320-0x0000000187254330
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018CB093F0-0x000000018CB09400
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB10DD4-0x000000018CB10E20
		protected override string OnInit(); // 0x000000018CB11C8C-0x000000018CB11DA8
		protected override void OnUpdate(); // 0x000000018CB11DA8-0x000000018CB11E18
		protected override void OnStop(); // 0x0000000187254310-0x0000000187254320
		private void SetMethod(MethodInfo method); // 0x000000018CB10E20-0x000000018CB10E74
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nSet a property on a script.")]
	[Name("Set Property (Desktop Only)", 7)]
	public class SetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 77010
	{
		// Fields
		[SerializeField]
		protected ReflectedActionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		public override System.Type agentType { get; } // 0x000000018CB1997C-0x000000018CB19A40 
		protected override string info { get; } // 0x000000018CB19A40-0x000000018CB19BB4 
	
		// Constructors
		public SetProperty(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x000000018CB093F0-0x000000018CB09400
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB198DC-0x000000018CB19928
		protected override string OnInit(); // 0x000000018CB197C0-0x000000018CB198DC
		protected override void OnExecute(); // 0x000000018CB19784-0x000000018CB197C0
		private void SetMethod(MethodInfo method); // 0x000000018CB19928-0x000000018CB1997C
	}

	[Category("\u272B Utility")]
	[Description("Plays a \'Beep\' in editor only")]
	public class DebugBeep : ActionTask // TypeDefIndex: 77011
	{
		// Constructors
		public DebugBeep(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000187837BD4-0x0000000187837BE0
	}

	[Category("\u272B Utility")]
	public class DebugDrawLine : ActionTask // TypeDefIndex: 77012
	{
		// Fields
		public BBParameter<Vector3> from; // 0x68
		public BBParameter<Vector3> to; // 0x70
		public UnityEngine.Color color; // 0x78
		public float timeToShow; // 0x88
	
		// Constructors
		public DebugDrawLine(); // 0x000000018CB07A60-0x000000018CB07A90
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB07958-0x000000018CB07A60
	}

	[Category("\u272B Utility")]
	[Description("Display a UI label on the agent\'s position if seconds to run is not 0 and also logs the message, which can also be mapped to any variable.")]
	[Name("Debug Log", 0)]
	public class DebugLogText : ActionTask<Transform> // TypeDefIndex: 77015
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
		protected override string info { get; } // 0x000000018CB08064-0x000000018CB08134 
	
		// Nested types
		public enum LogMode // TypeDefIndex: 77013
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}
	
		public enum VerboseMode // TypeDefIndex: 77014
		{
			LogAndDisplayLabel = 0,
			LogOnly = 1,
			DisplayLabelOnly = 2
		}
	
		// Constructors
		public DebugLogText(); // 0x000000018CB07FE8-0x000000018CB08064
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB07A90-0x000000018CB07BD8
		protected override void OnStop(); // 0x000000018CB07F04-0x000000018CB07FB4
		protected override void OnUpdate(); // 0x000000018CB07FB4-0x000000018CB07FE8
		private void OnGUI(); // 0x000000018CB07BD8-0x000000018CB07F04
	}

	[Category("\u272B Utility")]
	[Description("Logs the value of a variable in the console")]
	[Obsolete("Use Debug Log Text")]
	public class DebugLogVariable : ActionTask // TypeDefIndex: 77016
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> log; // 0x68
		public BBParameter<string> prefix; // 0x70
		public float secondsToRun; // 0x78
		public CompactStatus finishStatus; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x000000018CB08164-0x000000018CB0825C 
	
		// Constructors
		public DebugLogVariable(); // 0x00000001872542C0-0x00000001872542E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnUpdate(); // 0x000000018CB08134-0x000000018CB08164
	}

	[Category("\u272B Utility")]
	[Description("Force Finish the current graph this Task is assigned to.")]
	public class ForceFinishGraph : ActionTask // TypeDefIndex: 77017
	{
		// Fields
		public CompactStatus finishStatus; // 0x68
	
		// Constructors
		public ForceFinishGraph(); // 0x00000001872542F0-0x0000000187254300
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB0D91C-0x000000018CB0D9BC
	}

	[Category("\u272B Utility")]
	[Description("Start, Resume, Pause, Stop a GraphOwner\'s behaviour")]
	[Name("Control Graph Owner", 0)]
	public class GraphOwnerControl : ActionTask<GraphOwner> // TypeDefIndex: 77020
	{
		// Fields
		public Control control; // 0x68
		public bool waitActionFinish; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x000000018CB11514-0x000000018CB115A0 
	
		// Nested types
		public enum Control // TypeDefIndex: 77018
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		[CompilerGenerated]
		private sealed class _YieldDo_d__6 : IEnumerator<object> // TypeDefIndex: 77019
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GraphOwnerControl __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _YieldDo_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB1B774-0x000000018CB1B7D4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB1B7D4-0x000000018CB1B820
		}
	
		// Constructors
		public GraphOwnerControl(); // 0x000000018CB114D0-0x000000018CB11514
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB112D0-0x000000018CB1140C
		[IteratorStateMachine(typeof(_YieldDo_d__6))]
		private IEnumerator YieldDo(); // 0x000000018CB11474-0x000000018CB114D0
		private void Do(); // 0x000000018CB1122C-0x000000018CB112D0
		protected override void OnStop(); // 0x000000018CB1140C-0x000000018CB1146C
		[CompilerGenerated]
		private void _OnExecute_b__5_0(bool s); // 0x000000018CB1146C-0x000000018CB11474
	}

	[Category("\u272B Utility")]
	[Description("An action that will simply run forever and never finish")]
	public class RunForever : ActionTask // TypeDefIndex: 77021
	{
		// Constructors
		public RunForever(); // 0x000000018723B3B0-0x000000018723B3C0
	}

	[Category("\u272B Utility")]
	[Description("Send a graph event. If global is true, all graph owners in scene will receive this event. Use along with the \'Check Event\' Condition")]
	public class SendEvent : ActionTask<GraphOwner> // TypeDefIndex: 77022
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> delay; // 0x70
		public bool sendGlobal; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB17A8C-0x000000018CB17C20 
	
		// Constructors
		public SendEvent(); // 0x000000018CB17A50-0x000000018CB17A8C
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB17928-0x000000018CB17A50
	}

	[Category("\u272B Utility")]
	[Description("Send a graph event with T value. If global is true, all graph owners in scene will receive this event. Use along with the \'Check Event\' Condition")]
	public class SendEvent<T> : ActionTask<GraphOwner> // TypeDefIndex: 77023
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
	public class SendEventToObjects : ActionTask // TypeDefIndex: 77024
	{
		// Fields
		[RequiredField]
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		[RequiredField]
		public BBParameter<string> eventName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB178E4-0x000000018CB17928 
	
		// Constructors
		public SendEventToObjects(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB176C8-0x000000018CB178E4
	}

	[Category("\u272B Utility")]
	[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
	public class SendEventToObjects<T> : ActionTask // TypeDefIndex: 77025
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
	public class ShoutEvent : ActionTask<Transform> // TypeDefIndex: 77026
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
		protected override string info { get; } // 0x000000018CB1A2F0-0x000000018CB1A348 
	
		// Constructors
		public ShoutEvent(); // 0x000000018CB1A270-0x000000018CB1A2F0
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB19F5C-0x000000018CB1A000
		protected override void OnUpdate(); // 0x000000018CB1A000-0x000000018CB1A270
		public override void OnDrawGizmosSelected(); // 0x000000018CB19E0C-0x000000018CB19F5C
	}

	[Category("\u272B Utility")]
	[Description("Switch the entire Behaviour Tree of BehaviourTreeOwner")]
	public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner> // TypeDefIndex: 77027
	{
		// Fields
		[RequiredField]
		public BBParameter<BehaviourTree> behaviourTree; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB1AB20-0x000000018CB1AB60 
	
		// Constructors
		public SwitchBehaviourTree(); // 0x000000018CB1AAE4-0x000000018CB1AB20
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1AA48-0x000000018CB1AAE4
	}

	[Category("\u272B Utility")]
	[Description("Switch the entire FSM of FSMTreeOwner")]
	public class SwitchFSM : ActionTask<FSMOwner> // TypeDefIndex: 77028
	{
		// Fields
		[RequiredField]
		public BBParameter<FSM> fsm; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB1AC38-0x000000018CB1AC78 
	
		// Constructors
		public SwitchFSM(); // 0x000000018CB1ABFC-0x000000018CB1AC38
	
		// Methods
		protected override void OnExecute(); // 0x000000018CB1AB60-0x000000018CB1ABFC
	}

	[Category("\u272B Utility")]
	public class Wait : ActionTask // TypeDefIndex: 77029
	{
		// Fields
		public BBParameter<float> waitTime; // 0x68
		public CompactStatus finishStatus; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB1BDE4-0x000000018CB1C01C 
	
		// Constructors
		public Wait(); // 0x000000018CB1BD88-0x000000018CB1BDE4
	
		// Methods
		protected override void OnUpdate(); // 0x000000018CB1BD14-0x000000018CB1BD88
	}

	[Category("GameObject")]
	[Description("Checks the current speed of the agent against a value based on it\'s Rigidbody velocity")]
	public class CheckSpeed : ConditionTask<Rigidbody> // TypeDefIndex: 77030
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<float> value; // 0x70
		[SliderField(0f, 0.1f)]
		public float differenceThreshold; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB0694C-0x000000018CB069C8 
	
		// Constructors
		public CheckSpeed(); // 0x000000018CB06900-0x000000018CB0694C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB06844-0x000000018CB06900
	}

	[Obsolete("Execute Function now supports static functions as well")]
	public class ExecuteStaticFunction : ActionTask, ISubParametersContainer // TypeDefIndex: 77031
	{
		// Fields
		[SerializeField]
		protected ReflectedWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		protected override string info { get; } // 0x000000018CB0A74C-0x000000018CB0AAF4 
	
		// Constructors
		public ExecuteStaticFunction(); // 0x000000018723B3B0-0x000000018723B3C0
	
		// Methods
		BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x000000018CB0A568-0x000000018CB0A588
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB0975C-0x000000018CB097A8
		protected override string OnInit(); // 0x000000018CB0A66C-0x000000018CB0A74C
		protected override void OnExecute(); // 0x000000018CB0A588-0x000000018CB0A66C
		private void SetMethod(MethodInfo method); // 0x000000018CB097A8-0x000000018CB097FC
	}

	[Obsolete("Execute Function now supports static functions as well")]
	public class ExecuteStaticFunction_Multiplatform : ActionTask // TypeDefIndex: 77033
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
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		protected override string info { get; } // 0x000000018CB0A254-0x000000018CB0A568 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77032
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<BBObjectParameter, object> __9__9_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB1B648-0x000000018CB1B6AC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _OnExecute_b__9_0(BBObjectParameter p); // 0x000000018CB1B4A4-0x000000018CB1B4E8
		}
	
		// Constructors
		public ExecuteStaticFunction_Multiplatform(); // 0x000000018CB0A1D4-0x000000018CB0A254
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CB09F48-0x000000018CB09F70
		protected override string OnInit(); // 0x000000018CB09EC0-0x000000018CB09F48
		protected override void OnExecute(); // 0x000000018CB09D28-0x000000018CB09EC0
		private void SetMethod(MethodInfo method); // 0x000000018CB09F70-0x000000018CB0A1D4
	}
}

namespace NodeCanvas.Tasks.Conditions
{
	[Category("\u272B Utility")]
	[Description("Invoke a defined Signal with agent as the target and optionally global.")]
	public class InvokeSignal : ActionTask<Transform> // TypeDefIndex: 76808
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		public bool global; // 0x70
		[SerializeField]
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x78
		private object[] args; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CAFF1A4-0x000000018CAFF1C8 
	
		// Constructors
		public InvokeSignal(); // 0x000000018CAFF118-0x000000018CAFF1A4
	
		// Methods
		protected override string OnInit(); // 0x000000018CAFF080-0x000000018CAFF118
		protected override void OnExecute(); // 0x000000018CAFEECC-0x000000018CAFF080
	}

	[Category("Animator")]
	[Name("Check Parameter Bool", 0)]
	public class MecanimCheckBool : ConditionTask<Animator> // TypeDefIndex: 76809
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public BBParameter<bool> value; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB019E0-0x000000018CB01A88 
	
		// Constructors
		public MecanimCheckBool(); // 0x000000018CB019A4-0x000000018CB019E0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB018F8-0x000000018CB019A4
	}

	[Category("Animator")]
	[Name("Check Parameter Float", 0)]
	public class MecanimCheckFloat : ConditionTask<Animator> // TypeDefIndex: 76810
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<float> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB01B94-0x000000018CB01C34 
	
		// Constructors
		public MecanimCheckFloat(); // 0x000000018CB01B58-0x000000018CB01B94
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB01A88-0x000000018CB01B58
	}

	[Category("Animator")]
	[Name("Check Parameter Int", 0)]
	public class MecanimCheckInt : ConditionTask<Animator> // TypeDefIndex: 76811
	{
		// Fields
		[RequiredField]
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<int> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB01D24-0x000000018CB01DC4 
	
		// Constructors
		public MecanimCheckInt(); // 0x000000018CB01CE8-0x000000018CB01D24
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB01C34-0x000000018CB01CE8
	}

	[Category("Animator")]
	[Name("Is In Transition", 0)]
	public class MecanimIsInTransition : ConditionTask<Animator> // TypeDefIndex: 76812
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB01E80-0x000000018CB01EAC 
	
		// Constructors
		public MecanimIsInTransition(); // 0x000000018CB01E44-0x000000018CB01E80
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB01DC4-0x000000018CB01E44
	}

	[Category("\u272B Blackboard")]
	public class CheckBoolean : ConditionTask // TypeDefIndex: 76813
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> valueA; // 0x68
		public BBParameter<bool> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAF4560-0x000000018CAF45E8 
	
		// Constructors
		public CheckBoolean(); // 0x000000018CAF4510-0x000000018CAF4560
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF44A4-0x000000018CAF4510
	}

	[Category("\u272B Blackboard")]
	[Description("Check if a boolean variable is true and if so, it is immediately reset to false.")]
	public class CheckBooleanTrigger : ConditionTask // TypeDefIndex: 76814
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<bool> trigger; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAF4464-0x000000018CAF44A4 
	
		// Constructors
		public CheckBooleanTrigger(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF43F0-0x000000018CAF4464
	}

	[Category("\u272B Blackboard")]
	public class CheckEnum : ConditionTask // TypeDefIndex: 76815
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter valueA; // 0x68
		public BBObjectParameter valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAF7CCC-0x000000018CAF7D54 
	
		// Constructors
		public CheckEnum(); // 0x000000018CAF7BD8-0x000000018CAF7CCC
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF7B64-0x000000018CAF7BD8
	}

	[Category("\u272B Blackboard")]
	public class CheckFloat : ConditionTask // TypeDefIndex: 76816
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<float> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> valueB; // 0x78
		[SliderField(0f, 0.1f)]
		public float differenceThreshold; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CAF8608-0x000000018CAF8684 
	
		// Constructors
		public CheckFloat(); // 0x0000000187254140-0x0000000187254160
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF8580-0x000000018CAF8608
	}

	[Category("\u272B Blackboard")]
	public class CheckInt : ConditionTask // TypeDefIndex: 76817
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<int> valueA; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CAF8608-0x000000018CAF8684 
	
		// Constructors
		public CheckInt(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF9A28-0x000000018CAF9AA0
	}

	[Category("\u272B Blackboard")]
	[Description("Check whether or not a variable is null")]
	public class CheckNull : ConditionTask // TypeDefIndex: 76818
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<object> variable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAFB9C4-0x000000018CAFBA20 
	
		// Constructors
		public CheckNull(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFB978-0x000000018CAFB9C4
	}

	[Category("\u272B Blackboard")]
	public class CheckString : ConditionTask // TypeDefIndex: 76819
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<string> valueA; // 0x68
		public BBParameter<string> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAFC628-0x000000018CAFC6B0 
	
		// Constructors
		public CheckString(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFC5B4-0x000000018CAFC628
	}

	[Category("\u272B Blackboard")]
	[Obsolete("Use CheckVariable(T)")]
	public class CheckUnityObject : ConditionTask // TypeDefIndex: 76820
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<UnityEngine.Object> valueA; // 0x68
		public BBParameter<UnityEngine.Object> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAFDA98-0x000000018CAFDB20 
	
		// Constructors
		public CheckUnityObject(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFDA08-0x000000018CAFDA98
	}

	[Category("\u272B Blackboard")]
	[Description("It\'s best to use the respective Condition for a type if existant since they support operations as well")]
	public class CheckVariable<T> : ConditionTask // TypeDefIndex: 76821
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
	public class CheckVectorDistance : ConditionTask // TypeDefIndex: 76822
	{
		// Fields
		[BlackboardOnly]
		public BBParameter<Vector3> vectorA; // 0x68
		[BlackboardOnly]
		public BBParameter<Vector3> vectorB; // 0x70
		public CompareMethod comparison; // 0x78
		public BBParameter<float> distance; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CAFDC14-0x000000018CAFDD14 
	
		// Constructors
		public CheckVectorDistance(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFDB20-0x000000018CAFDC14
	}

	[Category("\u272B Blackboard/Dictionaries")]
	public class TryGetValue<T> : ConditionTask // TypeDefIndex: 76823
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
	public class ListContainsElement<T> : ConditionTask // TypeDefIndex: 76824
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
	public class ListIsEmpty : ConditionTask // TypeDefIndex: 76825
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAFFBD8-0x000000018CAFFC18 
	
		// Constructors
		public ListIsEmpty(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFFB7C-0x000000018CAFFBD8
	}

	[Category("\u272B Blackboard")]
	[Name("On Variable Changed", 0)]
	public class BBVariableChanged : ConditionTask // TypeDefIndex: 76826
	{
		// Fields
		[BlackboardOnly]
		public BBObjectParameter targetVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAF0494-0x000000018CAF04F0 
	
		// Constructors
		public BBVariableChanged(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override string OnInit(); // 0x000000018CAF0434-0x000000018CAF0484
		protected override void OnEnable(); // 0x000000018CAF039C-0x000000018CAF0434
		protected override void OnDisable(); // 0x000000018CAF0304-0x000000018CAF039C
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void OnValueChanged(object varValue); // 0x000000018CAF0484-0x000000018CAF0494
	}

	[Category("\u272B Blackboard")]
	public class StringContains : ConditionTask // TypeDefIndex: 76827
	{
		// Fields
		[BlackboardOnly]
		[RequiredField]
		public BBParameter<string> targetString; // 0x68
		public BBParameter<string> checkString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB0516C-0x000000018CB051B0 
	
		// Constructors
		public StringContains(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB050F0-0x000000018CB0516C
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget : ConditionTask<Transform> // TypeDefIndex: 76828
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
		protected override string info { get; } // 0x000000018CAF4390-0x000000018CAF43F0 
	
		// Constructors
		public CanSeeTarget(); // 0x000000018CAF42C0-0x000000018CAF4390
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF3788-0x000000018CAF3C9C
		public override void OnDrawGizmosSelected(); // 0x000000018CAF3C9C-0x000000018CAF42C0
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTarget2D : ConditionTask<Transform> // TypeDefIndex: 76829
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
		protected override string info { get; } // 0x000000018CAF10F4-0x000000018CAF1154 
	
		// Constructors
		public CanSeeTarget2D(); // 0x000000018CAF1024-0x000000018CAF10F4
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF04F0-0x000000018CAF0968
		public override void OnDrawGizmosSelected(); // 0x000000018CAF0968-0x000000018CAF1024
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTargetAny : ConditionTask<Transform> // TypeDefIndex: 76830
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
		protected override string info { get; } // 0x000000018CAF3728-0x000000018CAF3788 
	
		// Constructors
		public CanSeeTargetAny(); // 0x000000018CAF3658-0x000000018CAF3728
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF241C-0x000000018CAF2F74
		public override void OnDrawGizmosSelected(); // 0x000000018CAF2F74-0x000000018CAF3598
		[CompilerGenerated]
		private float _OnCheck_b__11_0(GameObject x); // 0x000000018CAF3598-0x000000018CAF3658
	}

	[Category("GameObject")]
	[Description("A combination of line of sight and view angle check")]
	public class CanSeeTargetAny2D : ConditionTask<Transform> // TypeDefIndex: 76831
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
		protected override string info { get; } // 0x000000018CAF23BC-0x000000018CAF241C 
	
		// Constructors
		public CanSeeTargetAny2D(); // 0x000000018CAF22EC-0x000000018CAF23BC
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF1154-0x000000018CAF1B94
		public override void OnDrawGizmosSelected(); // 0x000000018CAF1B94-0x000000018CAF222C
		[CompilerGenerated]
		private float _OnCheck_b__10_0(GameObject x); // 0x000000018CAF222C-0x000000018CAF22EC
	}

	[Category("GameObject")]
	[Name("Target Within Distance", 0)]
	public class CheckDistanceToGameObject : ConditionTask<Transform> // TypeDefIndex: 76832
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CAF7A58-0x000000018CAF7B64 
	
		// Constructors
		public CheckDistanceToGameObject(); // 0x000000018CAF79E8-0x000000018CAF7A58
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF77CC-0x000000018CAF7900
		public override void OnDrawGizmosSelected(); // 0x000000018CAF7900-0x000000018CAF79E8
	}

	[Category("GameObject")]
	[Name("Target Within Distance 2D", 0)]
	public class CheckDistanceToGameObject2D : ConditionTask<Transform> // TypeDefIndex: 76833
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField(0f, 0.1f)]
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018CAF6694-0x000000018CAF67A0 
	
		// Constructors
		public CheckDistanceToGameObject2D(); // 0x000000018CAF6624-0x000000018CAF6694
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF63CC-0x000000018CAF6508
		public override void OnDrawGizmosSelected(); // 0x000000018CAF6508-0x000000018CAF6624
	}

	[Category("GameObject")]
	[Name("Any Target Within Distance", 0)]
	public class CheckDistanceToGameObjectAny : ConditionTask<Transform> // TypeDefIndex: 76834
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
		protected override string info { get; } // 0x000000018CAF76C0-0x000000018CAF77CC 
	
		// Constructors
		public CheckDistanceToGameObjectAny(); // 0x000000018CAF7650-0x000000018CAF76C0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF6FE0-0x000000018CAF74A8
		public override void OnDrawGizmosSelected(); // 0x000000018CAF74A8-0x000000018CAF7590
		[CompilerGenerated]
		private float _OnCheck_b__8_0(GameObject x); // 0x000000018CAF7590-0x000000018CAF7650
	}

	[Category("GameObject")]
	[Name("Any Target Within Distance 2D", 0)]
	public class CheckDistanceToGameObjectAny2D : ConditionTask<Transform> // TypeDefIndex: 76835
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
		protected override string info { get; } // 0x000000018CAF6ED4-0x000000018CAF6FE0 
	
		// Constructors
		public CheckDistanceToGameObjectAny2D(); // 0x000000018CAF6E64-0x000000018CAF6ED4
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF67A0-0x000000018CAF6C74
		public override void OnDrawGizmosSelected(); // 0x000000018CAF6C74-0x000000018CAF6D90
		[CompilerGenerated]
		private float _OnCheck_b__8_0(GameObject x); // 0x000000018CAF6D90-0x000000018CAF6E64
	}

	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	[Name("Target In Line Of Sight", 0)]
	public class CheckLOS : ConditionTask<Transform> // TypeDefIndex: 76836
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
		protected override string info { get; } // 0x000000018CAFA714-0x000000018CAFA76C 
	
		// Constructors
		public CheckLOS(); // 0x000000018CAFA6B8-0x000000018CAFA714
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFA234-0x000000018CAFA4E8
		public override void OnDrawGizmosSelected(); // 0x000000018CAFA4E8-0x000000018CAFA6B8
	}

	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	[Name("Target In Line Of Sight 2D", 0)]
	public class CheckLOS2D : ConditionTask<Transform> // TypeDefIndex: 76838
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
		protected override string info { get; } // 0x000000018CAFA1DC-0x000000018CAFA234 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 76837
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RaycastHit2D, Collider2D> __9__7_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB06054-0x000000018CB060B8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Collider2D _OnCheck_b__7_0(RaycastHit2D h); // 0x000000018CB05908-0x000000018CB0591C
		}
	
		// Constructors
		public CheckLOS2D(); // 0x000000018CAFA180-0x000000018CAFA1DC
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF9B88-0x000000018CAF9FC4
		public override void OnDrawGizmosSelected(); // 0x000000018CAF9FC4-0x000000018CAFA180
	}

	[Category("GameObject")]
	public class HasComponent<T> : ConditionTask<Transform> // TypeDefIndex: 76839
		where T : Component
	{
		// Constructors
		public HasComponent();
	
		// Methods
		protected override bool OnCheck();
	}

	[Category("GameObject")]
	public class IsActive : ConditionTask<Transform> // TypeDefIndex: 76840
	{
		// Properties
		protected override string info { get; } // 0x000000018CAFF264-0x000000018CAFF2AC 
	
		// Constructors
		public IsActive(); // 0x000000018CAFF228-0x000000018CAFF264
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFF1C8-0x000000018CAFF228
	}

	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	[Name("Target In View Angle", 0)]
	public class IsInFront : ConditionTask<Transform> // TypeDefIndex: 76841
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAFFA5C-0x000000018CAFFAB8 
	
		// Constructors
		public IsInFront(); // 0x000000018CAFF9FC-0x000000018CAFFA5C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFF6C4-0x000000018CAFF834
		public override void OnDrawGizmosSelected(); // 0x000000018CAFF834-0x000000018CAFF9FC
	}

	[Category("GameObject")]
	[Description("Checks whether the target is in the view angle of the agent")]
	[Name("Target In View Angle 2D", 0)]
	public class IsInFront2D : ConditionTask<Transform> // TypeDefIndex: 76842
	{
		// Fields
		[RequiredField]
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField(1, 180)]
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAFF668-0x000000018CAFF6C4 
	
		// Constructors
		public IsInFront2D(); // 0x000000018CAFF608-0x000000018CAFF668
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFF2AC-0x000000018CAFF41C
		public override void OnDrawGizmosSelected(); // 0x000000018CAFF41C-0x000000018CAFF608
	}

	[Category("GameObject")]
	public class IsWithinLayerMask : ConditionTask<Transform> // TypeDefIndex: 76843
	{
		// Fields
		public BBParameter<LayerMask> targetLayers; // 0x68
	
		// Constructors
		public IsWithinLayerMask(); // 0x000000018CAFFB40-0x000000018CAFFB7C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFFAB8-0x000000018CAFFB40
	}

	[Category("Input (Legacy System)")]
	public class CheckButtonInput : ConditionTask // TypeDefIndex: 76844
	{
		// Fields
		public PressTypes pressType; // 0x68
		[RequiredField]
		public BBParameter<string> buttonName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAF46FC-0x000000018CAF4794 
	
		// Constructors
		public CheckButtonInput(); // 0x000000018CAF469C-0x000000018CAF46FC
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF45E8-0x000000018CAF469C
	}

	[Category("Input (Legacy System)")]
	public class CheckKeyboardInput : ConditionTask // TypeDefIndex: 76845
	{
		// Fields
		public PressTypes pressType; // 0x68
		public KeyCode key; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x000000018CAF9AD4-0x000000018CAF9B88 
	
		// Constructors
		public CheckKeyboardInput(); // 0x0000000187254160-0x0000000187254170
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF9AA0-0x000000018CAF9AD4
	}

	[Category("Input (Legacy System)")]
	public class CheckMousePick : ConditionTask // TypeDefIndex: 76846
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
		protected override string info { get; } // 0x000000018CAFB52C-0x000000018CAFB648 
	
		// Constructors
		public CheckMousePick(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFB374-0x000000018CAFB52C
	}

	[Category("Input (Legacy System)")]
	public class CheckMousePick2D : ConditionTask // TypeDefIndex: 76847
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
		protected override string info { get; } // 0x000000018CAFB228-0x000000018CAFB374 
	
		// Constructors
		public CheckMousePick2D(); // 0x0000000187254170-0x0000000187254190
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFAFC8-0x000000018CAFB228
	}

	internal class CheckCSharpEvent_0 // TypeDefIndex: 76848
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckCSharpEvent_0(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class CheckCSharpEvent_0<T> // TypeDefIndex: 76849
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckCSharpEvent_0();
	}

	internal class CheckCSharpEventValue_0<T> // TypeDefIndex: 76850
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
	internal class CheckStaticCSharpEvent // TypeDefIndex: 76851
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckStaticCSharpEvent(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[fsMigrateTo(typeof(CheckCSharpEvent<T>))]
	internal class CheckStaticCSharpEvent<T> // TypeDefIndex: 76852
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
	public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent> // TypeDefIndex: 76853
	{
		// Fields
		[SerializeField]
		private SerializedEventInfo eventInfo; // 0x68
		private Delegate handler; // 0x70
	
		// Properties
		private EventInfo targetEvent { get; } // 0x000000018B80FFD8-0x000000018B80FFE8 
		public override System.Type agentType { get; } // 0x000000018CAF4C0C-0x000000018CAF4CE0 
		protected override string info { get; } // 0x000000018CAF4CE0-0x000000018CAF4DB8 
	
		// Constructors
		public CheckCSharpEvent(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		void IMigratable<CheckCSharpEvent_0>.Migrate(CheckCSharpEvent_0 model); // 0x000000018CAF49FC-0x000000018CAF4AC0
		void IMigratable<CheckStaticCSharpEvent>.Migrate(CheckStaticCSharpEvent model); // 0x000000018CAF4AC0-0x000000018CAF4B84
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		protected override string OnInit(); // 0x000000018CAF48DC-0x000000018CAF49FC
		protected override void OnEnable(); // 0x000000018CAF4838-0x000000018CAF48DC
		protected override void OnDisable(); // 0x000000018CAF4794-0x000000018CAF4838
		public void Raised(); // 0x000000018CAF0484-0x000000018CAF0494
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void SetTargetEvent(EventInfo info); // 0x000000018CAF4B84-0x000000018CAF4C0C
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised.\n(eg public event System.Action<T> [name])")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckCSharpEvent_0<T>) })]
	public class CheckCSharpEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>> // TypeDefIndex: 76854
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
	public class CheckCSharpEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>> // TypeDefIndex: 76855
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

	internal class CheckField_0 // TypeDefIndex: 76856
	{
		// Fields
		[SerializeField]
		public BBParameter checkValue; // 0x10
		[SerializeField]
		public System.Type targetType; // 0x18
		[SerializeField]
		public string fieldName; // 0x20
	
		// Constructors
		public CheckField_0(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Category("\u272B Reflected")]
	[Description("Check a field on a script and return if it\'s equal or not to a value")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckField_0) })]
	[Name("Check Field", 8)]
	public class CheckField : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0> // TypeDefIndex: 76857
	{
		// Fields
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x68
		[SerializeField]
		protected CompareMethod comparison; // 0x70
		[SerializeField]
		protected SerializedFieldInfo field; // 0x78
	
		// Properties
		private System.Reflection.FieldInfo targetField { get; } // 0x000000018CAF8570-0x000000018CAF8580 
		public override System.Type agentType { get; } // 0x000000018CAF82A4-0x000000018CAF8374 
		protected override string info { get; } // 0x000000018CAF8374-0x000000018CAF8570 
	
		// Constructors
		public CheckField(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		void IMigratable<CheckField_0>.Migrate(CheckField_0 model); // 0x000000018CAF8060-0x000000018CAF81EC
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001829CD170-0x00000001829CD180
		protected override string OnInit(); // 0x000000018CAF7FC8-0x000000018CAF8060
		protected override bool OnCheck(); // 0x000000018CAF7D54-0x000000018CAF7FC8
		private void SetTargetField(System.Reflection.FieldInfo newField); // 0x000000018CAF81EC-0x000000018CAF82A4
	}

	[Category("\u272B Reflected")]
	[Description("Call a function on a component and return whether or not the return value is equal to the check value")]
	[Name("Check Function", 10)]
	public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 76858
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
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		public override System.Type agentType { get; } // 0x000000018CAF8EC8-0x000000018CAF8F8C 
		protected override string info { get; } // 0x000000018CAF8F8C-0x000000018CAF9258 
	
		// Constructors
		public CheckFunction_Multiplatform(); // 0x000000018CAF8E48-0x000000018CAF8EC8
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CAF8BDC-0x000000018CAF8C04
		protected override string OnInit(); // 0x000000018CAF8A4C-0x000000018CAF8BDC
		protected override bool OnCheck(); // 0x000000018CAF8684-0x000000018CAF8A4C
		private void SetMethod(MethodInfo method); // 0x000000018CAF8C04-0x000000018CAF8E48
	}

	[Category("\u272B Reflected")]
	[Description("Check a property on a script and return if it\'s equal or not to the check value")]
	[Name("Check Property", 9)]
	public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 76859
	{
		// Fields
		[SerializeField]
		protected SerializedMethodInfo method; // 0x68
		[SerializeField]
		protected BBObjectParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9258-0x000000018CAF9268 
		public override System.Type agentType { get; } // 0x000000018CAFBDEC-0x000000018CAFBEB0 
		protected override string info { get; } // 0x000000018CAFBEB0-0x000000018CAFC03C 
	
		// Constructors
		public CheckProperty_Multiplatform(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CAFBD0C-0x000000018CAFBD34
		protected override string OnInit(); // 0x000000018CAFBCA4-0x000000018CAFBD0C
		protected override bool OnCheck(); // 0x000000018CAFBA20-0x000000018CAFBCA4
		private void SetMethod(MethodInfo method); // 0x000000018CAFBD34-0x000000018CAFBDEC
	}

	internal class CheckUnityEvent_0 // TypeDefIndex: 76860
	{
		// Fields
		[SerializeField]
		public System.Type targetType; // 0x10
		[SerializeField]
		public string eventName; // 0x18
	
		// Constructors
		public CheckUnityEvent_0(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class CheckUnityEvent_0<T> // TypeDefIndex: 76861
	{
		// Fields
		[SerializeField]
		public System.Type targetType;
		[SerializeField]
		public string eventName;
	
		// Constructors
		public CheckUnityEvent_0();
	}

	internal class CheckUnityEventValue_0<T> // TypeDefIndex: 76862
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
	public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0> // TypeDefIndex: 76863
	{
		// Fields
		[SerializeField]
		private SerializedUnityEventInfo _eventInfo; // 0x68
		private UnityEvent unityEvent; // 0x70
	
		// Properties
		private MemberInfo targetMember { get; } // 0x000000018B89007C-0x000000018B890090 
		private bool isStatic { get; } // 0x000000018B890044-0x000000018B890064 
		private System.Type eventType { get; } // 0x000000018B88E590-0x000000018B88E5B0 
		private System.Reflection.FieldInfo targetEventField { get; } // 0x000000018B890064-0x000000018B890070 
		private PropertyInfo targetEventProp { get; } // 0x000000018B890070-0x000000018B89007C 
		public override System.Type agentType { get; } // 0x000000018CAFD878-0x000000018CAFD930 
		protected override string info { get; } // 0x000000018CAFD930-0x000000018CAFDA08 
	
		// Constructors
		public CheckUnityEvent(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		void IMigratable<CheckUnityEvent_0>.Migrate(CheckUnityEvent_0 model); // 0x000000018CAFD738-0x000000018CAFD7F0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x0000000187232F80-0x0000000187232F90
		protected override string OnInit(); // 0x000000018CAFD5BC-0x000000018CAFD738
		protected override void OnEnable(); // 0x000000018CAFD528-0x000000018CAFD5BC
		protected override void OnDisable(); // 0x000000018CAFD494-0x000000018CAFD528
		public void Raised(); // 0x000000018CAF0484-0x000000018CAF0494
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void SetTargetEvent(MemberInfo newMember); // 0x000000018CAFD7F0-0x000000018CAFD878
	}

	[Category("\u272B Reflected/Events")]
	[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised.")]
	[fsMigrateVersions(new System.Type[1] {typeof(CheckUnityEvent_0<T>) })]
	public class CheckUnityEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>> // TypeDefIndex: 76864
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
	public class CheckUnityEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T>> // TypeDefIndex: 76865
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
	public class CheckFunction : ConditionTask // TypeDefIndex: 76866
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField]
		protected BBParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		public override System.Type agentType { get; } // 0x000000018CAF9674-0x000000018CAF9738 
		protected override string info { get; } // 0x000000018CAF9738-0x000000018CAF9A08 
	
		// Constructors
		public CheckFunction(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CAF9590-0x000000018CAF95DC
		protected override string OnInit(); // 0x000000018CAF9474-0x000000018CAF9590
		protected override bool OnCheck(); // 0x000000018CAF9268-0x000000018CAF9474
		private void SetMethod(MethodInfo method); // 0x000000018CAF95DC-0x000000018CAF9674
	}

	[Category("\u272B Reflected/Faster Versions (Desktop Platforms Only)")]
	[Description("This version works in destop/JIT platform only.\n\nCheck a property on a script and return if it\'s equal or not to the check value")]
	[Name("Check Property (Desktop Only)", 0)]
	public class CheckProperty : ConditionTask // TypeDefIndex: 76867
	{
		// Fields
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField]
		protected BBParameter checkValue; // 0x70
		[SerializeField]
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018CAF9A08-0x000000018CAF9A28 
		public override System.Type agentType { get; } // 0x000000018CAFC364-0x000000018CAFC428 
		protected override string info { get; } // 0x000000018CAFC428-0x000000018CAFC5B4 
	
		// Constructors
		public CheckProperty(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018CAF9590-0x000000018CAF95DC
		protected override string OnInit(); // 0x000000018CAFC248-0x000000018CAFC364
		protected override bool OnCheck(); // 0x000000018CAFC03C-0x000000018CAFC248
		private void SetMethod(MethodInfo method); // 0x000000018CAF95DC-0x000000018CAF9674
	}

	[Category("System Events")]
	[Name("Check Collision", 0)]
	public class CheckCollision_Rigidbody : ConditionTask<Rigidbody> // TypeDefIndex: 76868
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
		protected override string info { get; } // 0x000000018CAF6200-0x000000018CAF62BC 
	
		// Constructors
		public CheckCollision_Rigidbody(); // 0x000000018CAF61AC-0x000000018CAF6200
	
		// Methods
		protected override void OnEnable(); // 0x000000018CAF60B8-0x000000018CAF61AC
		protected override void OnDisable(); // 0x000000018CAF5FC4-0x000000018CAF60B8
		protected override bool OnCheck(); // 0x000000018CAF4DB8-0x000000018CAF4DCC
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data); // 0x000000018CAF5D58-0x000000018CAF5EF8
		public void OnCollisionExit(EventData<UnityEngine.Collision> data); // 0x000000018CAF5EF8-0x000000018CAF5FC4
	}

	[Category("System Events")]
	[DoNotList]
	public class CheckCollision : ConditionTask<Collider> // TypeDefIndex: 76869
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
		protected override string info { get; } // 0x000000018CAF6310-0x000000018CAF63CC 
	
		// Constructors
		public CheckCollision(); // 0x000000018CAF62BC-0x000000018CAF6310
	
		// Methods
		protected override void OnEnable(); // 0x000000018CAF5C64-0x000000018CAF5D58
		protected override void OnDisable(); // 0x000000018CAF5B70-0x000000018CAF5C64
		protected override bool OnCheck(); // 0x000000018CAF4DB8-0x000000018CAF4DCC
		public void OnCollisionEnter(EventData<UnityEngine.Collision> data); // 0x000000018CAF5904-0x000000018CAF5AA4
		public void OnCollisionExit(EventData<UnityEngine.Collision> data); // 0x000000018CAF5AA4-0x000000018CAF5B70
	}

	[Category("System Events")]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D_Rigidbody : ConditionTask<Rigidbody2D> // TypeDefIndex: 76870
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
		protected override string info { get; } // 0x000000018CAF5738-0x000000018CAF57F4 
	
		// Constructors
		public CheckCollision2D_Rigidbody(); // 0x000000018CAF56E4-0x000000018CAF5738
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF4DB8-0x000000018CAF4DCC
		protected override void OnEnable(); // 0x000000018CAF55F0-0x000000018CAF56E4
		protected override void OnDisable(); // 0x000000018CAF54FC-0x000000018CAF55F0
		private void OnCollisionEnter2D(EventData<Collision2D> data); // 0x000000018CAF5258-0x000000018CAF5430
		private void OnCollisionExit2D(EventData<Collision2D> data); // 0x000000018CAF5430-0x000000018CAF54FC
	}

	[Category("System Events")]
	[DoNotList]
	[Name("Check Collision 2D", 0)]
	public class CheckCollision2D : ConditionTask<Collider2D> // TypeDefIndex: 76871
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
		protected override string info { get; } // 0x000000018CAF5848-0x000000018CAF5904 
	
		// Constructors
		public CheckCollision2D(); // 0x000000018CAF57F4-0x000000018CAF5848
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAF4DB8-0x000000018CAF4DCC
		protected override void OnEnable(); // 0x000000018CAF5164-0x000000018CAF5258
		protected override void OnDisable(); // 0x000000018CAF5070-0x000000018CAF5164
		private void OnCollisionEnter2D(EventData<Collision2D> data); // 0x000000018CAF4DCC-0x000000018CAF4FA4
		private void OnCollisionExit2D(EventData<Collision2D> data); // 0x000000018CAF4FA4-0x000000018CAF5070
	}

	[Category("System Events")]
	public class CheckMouse : ConditionTask<Collider> // TypeDefIndex: 76872
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAFB924-0x000000018CAFB978 
	
		// Constructors
		public CheckMouse(); // 0x000000018CAFB8E8-0x000000018CAFB924
	
		// Methods
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		protected override void OnEnable(); // 0x000000018CAFB798-0x000000018CAFB8E8
		protected override void OnDisable(); // 0x000000018CAFB648-0x000000018CAFB798
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018CAFAA0C-0x000000018CAFAA20
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018CAFAA20-0x000000018CAFAA34
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018CAFAA34-0x000000018CAFAA48
	}

	[Category("System Events")]
	[Name("Check Mouse 2D", 0)]
	public class CheckMouse2D : ConditionTask<Collider2D> // TypeDefIndex: 76873
	{
		// Fields
		public MouseInteractionTypes checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAFAA84-0x000000018CAFAAD8 
	
		// Constructors
		public CheckMouse2D(); // 0x000000018CAFAA48-0x000000018CAFAA84
	
		// Methods
		protected override void OnEnable(); // 0x000000018CAFA8BC-0x000000018CAFAA0C
		protected override void OnDisable(); // 0x000000018CAFA76C-0x000000018CAFA8BC
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void OnMouseEnter(ParadoxNotion.EventData msg); // 0x000000018CAFAA0C-0x000000018CAFAA20
		private void OnMouseExit(ParadoxNotion.EventData msg); // 0x000000018CAFAA20-0x000000018CAFAA34
		private void OnMouseOver(ParadoxNotion.EventData msg); // 0x000000018CAFAA34-0x000000018CAFAA48
	}

	[Category("System Events")]
	public class CheckMouseClick : ConditionTask<Collider> // TypeDefIndex: 76874
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAFAF74-0x000000018CAFAFC8 
	
		// Constructors
		public CheckMouseClick(); // 0x000000018CAFAF38-0x000000018CAFAF74
	
		// Methods
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		protected override void OnEnable(); // 0x000000018CAFAE44-0x000000018CAFAF38
		protected override void OnDisable(); // 0x000000018CAFAD50-0x000000018CAFAE44
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018CAFAA0C-0x000000018CAFAA20
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018CAFAA20-0x000000018CAFAA34
	}

	[Category("System Events")]
	[Name("Check Mouse Click 2D", 0)]
	public class CheckMouseClick2D : ConditionTask<Collider2D> // TypeDefIndex: 76875
	{
		// Fields
		public MouseClickEvent checkType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CAFACFC-0x000000018CAFAD50 
	
		// Constructors
		public CheckMouseClick2D(); // 0x000000018CAFACC0-0x000000018CAFACFC
	
		// Methods
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		protected override void OnEnable(); // 0x000000018CAFABCC-0x000000018CAFACC0
		protected override void OnDisable(); // 0x000000018CAFAAD8-0x000000018CAFABCC
		private void OnMouseDown(ParadoxNotion.EventData msg); // 0x000000018CAFAA0C-0x000000018CAFAA20
		private void OnMouseUp(ParadoxNotion.EventData msg); // 0x000000018CAFAA20-0x000000018CAFAA34
	}

	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	[Name("Check Trigger", 0)]
	public class CheckTrigger_Transform : ConditionTask<Transform> // TypeDefIndex: 76876
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
		protected override string info { get; } // 0x000000018CAFD2C8-0x000000018CAFD384 
	
		// Constructors
		public CheckTrigger_Transform(); // 0x000000018CAFD274-0x000000018CAFD2C8
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFCB58-0x000000018CAFCB6C
		protected override void OnEnable(); // 0x000000018CAFCFE4-0x000000018CAFD0D8
		protected override void OnDisable(); // 0x000000018CAFCEF0-0x000000018CAFCFE4
		public void OnTriggerEnter(EventData<Collider> data); // 0x000000018CAFD0D8-0x000000018CAFD1A8
		public void OnTriggerExit(EventData<Collider> data); // 0x000000018CAFD1A8-0x000000018CAFD274
	}

	[Category("System Events")]
	[DoNotList]
	public class CheckTrigger : ConditionTask<Collider> // TypeDefIndex: 76877
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
		protected override string info { get; } // 0x000000018CAFD3D8-0x000000018CAFD494 
	
		// Constructors
		public CheckTrigger(); // 0x000000018CAFD384-0x000000018CAFD3D8
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFCB58-0x000000018CAFCB6C
		protected override void OnEnable(); // 0x000000018CAFCC60-0x000000018CAFCD54
		protected override void OnDisable(); // 0x000000018CAFCB6C-0x000000018CAFCC60
		public void OnTriggerEnter(EventData<Collider> data); // 0x000000018CAFCD54-0x000000018CAFCE24
		public void OnTriggerExit(EventData<Collider> data); // 0x000000018CAFCE24-0x000000018CAFCEF0
	}

	[Category("System Events")]
	[Description("The agent is type of Transform so that Triggers can either work with a Collider or a Rigidbody attached.")]
	[Name("Check Trigger 2D", 0)]
	public class CheckTrigger2D_Transform : ConditionTask<Transform> // TypeDefIndex: 76878
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
		protected override string info { get; } // 0x000000018CAFCA9C-0x000000018CAFCB58 
	
		// Constructors
		public CheckTrigger2D_Transform(); // 0x000000018CAFCA48-0x000000018CAFCA9C
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFC6B0-0x000000018CAFC6C4
		protected override void OnEnable(); // 0x000000018CAFC7B8-0x000000018CAFC8AC
		protected override void OnDisable(); // 0x000000018CAFC6C4-0x000000018CAFC7B8
		public void OnTriggerEnter2D(EventData<Collider2D> data); // 0x000000018CAFC8AC-0x000000018CAFC97C
		public void OnTriggerExit2D(EventData<Collider2D> data); // 0x000000018CAFC97C-0x000000018CAFCA48
	}

	[Category("System Events")]
	[DoNotList]
	[Name("Check Trigger 2D", 0)]
	public class CheckTrigger2D : ConditionTask<Collider2D> // TypeDefIndex: 76879
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
		protected override string info { get; } // 0x000000018CB06E94-0x000000018CB06F50 
	
		// Constructors
		public CheckTrigger2D(); // 0x000000018CB06E40-0x000000018CB06E94
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CAFC6B0-0x000000018CAFC6C4
		protected override void OnEnable(); // 0x000000018CB06BB0-0x000000018CB06CA4
		protected override void OnDisable(); // 0x000000018CB06ABC-0x000000018CB06BB0
		public void OnTriggerEnter2D(EventData<Collider2D> data); // 0x000000018CB06CA4-0x000000018CB06D74
		public void OnTriggerExit2D(EventData<Collider2D> data); // 0x000000018CB06D74-0x000000018CB06E40
	}

	[Category("UGUI")]
	public class ButtonClicked : ConditionTask // TypeDefIndex: 76880
	{
		// Fields
		[RequiredField]
		public BBParameter<UnityEngine.UI.Button> button; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB06174-0x000000018CB061CC 
	
		// Constructors
		public ButtonClicked(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override string OnInit(); // 0x000000018CB060B8-0x000000018CB06174
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void OnClick(); // 0x000000018CAF0484-0x000000018CAF0494
	}

	[Category("UGUI")]
	[Description("Returns true when the selected event is triggered on the selected agent.\nYou can use this for both GUI and 3D objects.\nPlease make sure that Unity Event Systems are setup correctly")]
	public class InterceptEvent : ConditionTask<Transform> // TypeDefIndex: 76881
	{
		// Fields
		public EventTriggerType eventType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB13634-0x000000018CB136C0 
	
		// Constructors
		public InterceptEvent(); // 0x000000018CB135F8-0x000000018CB13634
	
		// Methods
		protected override void OnEnable(); // 0x000000018CB13028-0x000000018CB135F8
		protected override void OnDisable(); // 0x000000018CB12A58-0x000000018CB13028
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void OnPointerEnter(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnPointerExit(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnPointerDown(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnPointerUp(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnPointerClick(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnDrag(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnDrop(EventData<PointerEventData> eventData); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnScroll(EventData<PointerEventData> data); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnUpdateSelected(EventData<BaseEventData> eventData); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnSelect(EventData<BaseEventData> eventData); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnDeselect(EventData<BaseEventData> eventData); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnMove(EventData<AxisEventData> eventData); // 0x000000018CAF0484-0x000000018CAF0494
		private void OnSubmit(EventData<BaseEventData> eventData); // 0x000000018CAF0484-0x000000018CAF0494
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and return true for one frame")]
	public class CheckEvent : ConditionTask<GraphOwner> // TypeDefIndex: 76882
	{
		// Fields
		[RequiredField]
		public BBParameter<string> eventName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB063B8-0x000000018CB06420 
	
		// Constructors
		public CheckEvent(); // 0x000000018CB0637C-0x000000018CB063B8
	
		// Methods
		protected override void OnEnable(); // 0x000000018CB062E4-0x000000018CB0637C
		protected override void OnDisable(); // 0x000000018CB0624C-0x000000018CB062E4
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
		private void OnCustomEvent(string eventName, ParadoxNotion.IEventData data); // 0x000000018CB061CC-0x000000018CB0624C
	}

	[Category("\u272B Utility")]
	[Description("Check if an event is received and return true for one frame. Optionaly save the received event\'s value")]
	public class CheckEvent<T> : ConditionTask<GraphOwner> // TypeDefIndex: 76883
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
	public class CheckEventValue<T> : ConditionTask<GraphOwner> // TypeDefIndex: 76884
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
	public class CheckSignal : ConditionTask<Transform> // TypeDefIndex: 76885
	{
		// Fields
		public BBParameter<SignalDefinition> signalDefinition; // 0x68
		[SerializeField]
		private Dictionary<string, BBObjectParameter> argumentsMap; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CAFF1A4-0x000000018CAFF1C8 
	
		// Constructors
		public CheckSignal(); // 0x000000018CB067B8-0x000000018CB06844
	
		// Methods
		protected override string OnInit(); // 0x000000018CB065DC-0x000000018CB0662C
		protected override void OnEnable(); // 0x000000018CB064D0-0x000000018CB065DC
		protected override void OnDisable(); // 0x000000018CB06420-0x000000018CB064D0
		private void OnSignalInvoke(Transform sender, Transform receiver, bool isGlobal, params object[] args); // 0x000000018CB0662C-0x000000018CB067B8
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
	}

	[Category("\u272B Utility")]
	[Description("Check the parent state status. This condition is only meant to be used along with an FSM system.")]
	public class CheckStateStatus : ConditionTask // TypeDefIndex: 76886
	{
		// Fields
		public CompactStatus status; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018CB06A5C-0x000000018CB06ABC 
	
		// Constructors
		public CheckStateStatus(); // 0x00000001872542B0-0x00000001872542C0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018CB069C8-0x000000018CB06A5C
	}

	[Category("\u272B Utility")]
	[Description("Simply use to debug return true or false by inverting the condition if needed")]
	public class DebugCondition : ConditionTask // TypeDefIndex: 76887
	{
		// Constructors
		public DebugCondition(); // 0x000000018723B3A0-0x000000018723B3B0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001843FFFF0-0x0000000184400000
	}

	[Category("\u272B Utility")]
	[Description("Return true or false based on the probability settings.")]
	public class Probability : ConditionTask // TypeDefIndex: 76888
	{
		// Fields
		public BBParameter<float> probability; // 0x68
		public BBParameter<float> maxValue; // 0x70
		private bool success; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018CB167A0-0x000000018CB16844 
	
		// Constructors
		public Probability(); // 0x0000000186B558A0-0x0000000186B55920
	
		// Methods
		protected override void OnEnable(); // 0x000000018581C5C0-0x000000018581C650
		protected override bool OnCheck(); // 0x000000018226EFA0-0x000000018226EFB0
	}

	[Category("\u272B Utility")]
	[Description("Will return true after a specific amount of time has passed and false while still counting down")]
	public class Timeout : ConditionTask // TypeDefIndex: 76889
	{
		// Fields
		public BBParameter<float> timeout; // 0x68
		private float currentTime; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018CB1AEE0-0x000000018CB1AF64 
	
		// Constructors
		public Timeout(); // 0x000000018CB1AE8C-0x000000018CB1AEE0
	
		// Methods
		protected override void OnEnable(); // 0x000000018CB1ADF4-0x000000018CB1AE8C
		protected override void OnDisable(); // 0x000000018CB1AD5C-0x000000018CB1ADF4
		private void MoveNext(); // 0x000000018CB1AC78-0x000000018CB1ACF4
		protected override bool OnCheck(); // 0x000000018CB1ACF4-0x000000018CB1AD5C
	}
}

namespace ParadoxNotion
{
	public delegate void ActionCall(); // TypeDefIndex: 77301; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void ActionCall<T1>(T1 a); // TypeDefIndex: 77302; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2>(T1 a, T2 b); // TypeDefIndex: 77303; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c); // TypeDefIndex: 77304; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 77305; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 77306; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 77307; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 77308; 0x00000000-0x00000000

	public delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 77309; 0x00000000-0x00000000

	public delegate TResult FunctionCall<TResult>(); // TypeDefIndex: 77310; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, TResult>(T1 a); // TypeDefIndex: 77311; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b); // TypeDefIndex: 77312; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c); // TypeDefIndex: 77313; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 77314; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 77315; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 77316; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g); // TypeDefIndex: 77317; 0x00000000-0x00000000

	public delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h); // TypeDefIndex: 77318; 0x00000000-0x00000000

	[Serializable]
	public sealed class DynamicParameterDefinition : ISerializationCallbackReceiver // TypeDefIndex: 77319
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
		public string ID { get; private set; } // 0x000000018CB327B0-0x000000018CB327E0 0x0000000184FD2410-0x0000000184FD2420
		public string name { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public System.Type type { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public DynamicParameterDefinition(); // 0x0000000186805BA0-0x0000000186805BB0
		public DynamicParameterDefinition(string name, System.Type type); // 0x000000018CB32710-0x000000018CB327B0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB326A0-0x000000018CB32710
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB32640-0x000000018CB326A0
	}

	public enum CompareMethod // TypeDefIndex: 77320
	{
		EqualTo = 0,
		GreaterThan = 1,
		LessThan = 2,
		GreaterOrEqualTo = 3,
		LessOrEqualTo = 4
	}

	public enum OperationMethod // TypeDefIndex: 77321
	{
		Set = 0,
		Add = 1,
		Subtract = 2,
		Multiply = 3,
		Divide = 4
	}

	public enum ButtonKeys // TypeDefIndex: 77322
	{
		Left = 0,
		Right = 1,
		Middle = 2
	}

	public enum PressTypes // TypeDefIndex: 77323
	{
		Down = 0,
		Up = 1,
		Pressed = 2
	}

	public enum MouseClickEvent // TypeDefIndex: 77324
	{
		MouseDown = 0,
		MouseUp = 1
	}

	public enum TriggerTypes // TypeDefIndex: 77325
	{
		TriggerEnter = 0,
		TriggerExit = 1,
		TriggerStay = 2
	}

	public enum CollisionTypes // TypeDefIndex: 77326
	{
		CollisionEnter = 0,
		CollisionExit = 1,
		CollisionStay = 2
	}

	public enum MouseInteractionTypes // TypeDefIndex: 77327
	{
		MouseEnter = 0,
		MouseExit = 1,
		MouseOver = 2
	}

	public enum CompactStatus // TypeDefIndex: 77328
	{
		Failure = 0,
		Success = 1
	}

	public enum PlayDirections // TypeDefIndex: 77329
	{
		Forward = 0,
		Backward = 1,
		Toggle = 2
	}

	public enum PlanarDirection // TypeDefIndex: 77330
	{
		Horizontal = 0,
		Vertical = 1,
		Auto = 2
	}

	public enum Alignment2x2 // TypeDefIndex: 77331
	{
		Default = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4
	}

	public enum Alignment3x3 // TypeDefIndex: 77332
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

	public class HierarchyTree // TypeDefIndex: 77335
	{
		// Nested types
		public class Element // TypeDefIndex: 77334
		{
			// Fields
			private object _reference; // 0x10
			private Element _parent; // 0x18
			private List<Element> _children; // 0x20
	
			// Properties
			public object reference { get; } // 0x00000001829260F0-0x0000000182926100 
			public Element parent { get; } // 0x0000000182234E30-0x0000000182234E40 
			public IEnumerable<Element> children { get; } // 0x000000018225E800-0x000000018225E810 
	
			// Nested types
			[CompilerGenerated]
			private sealed class _GetAllChildrenReferencesOfType_d__15<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 77333
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
			public Element(object reference); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public Element AddChild(Element child); // 0x000000018CB327E0-0x000000018CB328A4
			public void RemoveChild(Element child); // 0x000000018CB3295C-0x000000018CB329B0
			public Element GetRoot(); // 0x000000018CB32948-0x000000018CB3295C
			public Element FindReferenceElement(object target); // 0x000000018CB328A4-0x000000018CB32948
			public T GetFirstParentReferenceOfType<T>();
			[IteratorStateMachine(typeof(_GetAllChildrenReferencesOfType_d__15<T>))]
			public IEnumerable<T> GetAllChildrenReferencesOfType<T>();
		}
	
		// Constructors
		public HierarchyTree(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IEventData // TypeDefIndex: 77336
	{
		// Properties
		GameObject receiver { get; }
		object sender { get; }
		object valueBoxed { get; }
	}

	public struct EventData : ParadoxNotion.IEventData // TypeDefIndex: 77337
	{
		// Fields
		[CompilerGenerated]
		private GameObject _receiver_k__BackingField; // 0x00
		[CompilerGenerated]
		private object _sender_k__BackingField; // 0x08
		[CompilerGenerated]
		private object _value_k__BackingField; // 0x10
	
		// Properties
		public GameObject receiver { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public object sender { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public object value { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public object valueBoxed { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public EventData(object value, GameObject receiver, object sender); // 0x000000018CB329EC-0x000000018CB32A20
		public EventData(GameObject receiver, object sender); // 0x000000018CB329B0-0x000000018CB329EC
	}

	public struct EventData<T> : ParadoxNotion.IEventData // TypeDefIndex: 77338
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

	public static class OperationTools // TypeDefIndex: 77339
	{
		// Methods
		public static string GetOperationString(OperationMethod om); // 0x000000018CB36304-0x000000018CB363C0
		public static float Operate(float a, float b, OperationMethod om, float delta = 1f /* Metadata: 0x02629E4E */); // 0x000000018CB365DC-0x000000018CB36624
		public static int Operate(int a, int b, OperationMethod om); // 0x000000018CB365A0-0x000000018CB365DC
		public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f /* Metadata: 0x02629E52 */); // 0x000000018CB363C0-0x000000018CB365A0
		public static string GetCompareString(CompareMethod cm); // 0x000000018CB36248-0x000000018CB36304
		public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint); // 0x000000018581C4A0-0x000000018581C4F0
		public static bool Compare(int a, int b, CompareMethod cm); // 0x000000018CB36208-0x000000018CB36248
	}

	public static class ReflectionTools // TypeDefIndex: 77346
	{
		// Fields
		public const System.Reflection.BindingFlags FLAGS_ALL = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.FlattenHierarchy; // Metadata: 0x02629E5D
		public const System.Reflection.BindingFlags FLAGS_ALL_DECLARED = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic; // Metadata: 0x02629E5F
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
		public const string METHOD_SPECIAL_NAME_GET = "get_"; // Metadata: 0x02629E60
		public const string METHOD_SPECIAL_NAME_SET = "set_"; // Metadata: 0x02629E65
		public const string METHOD_SPECIAL_NAME_ADD = "add_"; // Metadata: 0x02629E6A
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_"; // Metadata: 0x02629E6F
		public const string METHOD_SPECIAL_NAME_OP = "op_"; // Metadata: 0x02629E77
	
		// Properties
		private static Assembly[] loadedAssemblies { get; } // 0x000000018CB3C3A4-0x000000018CB3C454 
	
		// Nested types
		public enum MethodType // TypeDefIndex: 77340
		{
			Normal = 0,
			PropertyAccessor = 1,
			Event = 2,
			Operator = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 77341
		{
			// Fields
			public bool includeObsolete; // 0x10
			public Func<System.Type, bool> __9__2; // 0x18
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetAllTypes_b__2(System.Type t); // 0x000000018CB4B5A8-0x000000018CB4B614
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77342
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__33_0; // 0x08
			public static Func<System.Type, string> __9__33_1; // 0x10
			public static Func<ParameterInfo, System.Type> __9__102_0; // 0x18
			public static Func<ParameterInfo, System.Type> __9__110_0; // 0x20
	
			// Constructors
			static __c(); // 0x000000018CB4BC78-0x000000018CB4BCDC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _GetAllTypes_b__33_0(System.Type t); // 0x000000018CB4AD4C-0x000000018CB4AD6C
			internal string _GetAllTypes_b__33_1(System.Type t); // 0x000000018CB4AD6C-0x000000018CB4ADB8
			internal System.Type _RTCreateDelegate_b__102_0(ParameterInfo p); // 0x0000000188E4BE2C-0x0000000188E4BE44
			internal System.Type _GetBaseDefinition_b__110_0(ParameterInfo p); // 0x0000000188E4BE2C-0x0000000188E4BE44
		}
	
		[CompilerGenerated]
		private sealed class _RTGetAttributesRecursive_d__99<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 77343
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
		private sealed class __c__DisplayClass128_0<T, TResult> // TypeDefIndex: 77344
		{
			// Fields
			public System.Reflection.FieldInfo info;
	
			// Constructors
			public __c__DisplayClass128_0();
	
			// Methods
			internal TResult _GetFieldGetter_b__0(T instance);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_0<T, TValue> // TypeDefIndex: 77345
		{
			// Fields
			public System.Reflection.FieldInfo info;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal void _GetFieldSetter_b__0(T instance, TValue value);
		}
	
		// Constructors
		static ReflectionTools(); // 0x00000001867EE710-0x00000001867EF280
	
		// Methods
		public static void FlushMem(); // 0x00000001867EDA80-0x00000001867EE210
		public static System.Type GetType(string typeFullName); // 0x000000018CB39938-0x000000018CB39988
		public static System.Type GetType(string typeFullName, System.Type fallbackAssignable); // 0x00000001857C4D20-0x00000001857C4D70
		public static System.Type GetType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x02629E56 */, System.Type fallbackAssignable = null); // 0x00000001857C4BD0-0x00000001857C4D20
		private static System.Type GetTypeDirect(string typeFullName); // 0x00000001858DE8F0-0x00000001858DE990
		private static System.Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x02629E57 */, System.Type fallbackAssignable = null); // 0x000000018CB3BCE8-0x000000018CB3C1F0
		private static System.Type TryResolveDeserializeFromAttribute(string typeName); // 0x000000018CB3BBCC-0x000000018CB3BCE8
		private static System.Type TryResolveWithoutNamespace(string typeName, System.Type fallbackAssignable = null); // 0x000000018CB3C1F0-0x000000018CB3C3A4
		public static System.Type[] GetAllTypes(bool includeObsolete); // 0x000000018CB383B4-0x000000018CB38820
		public static System.Type[] GetImplementationsOf(System.Type baseType); // 0x000000018CB3926C-0x000000018CB3945C
		public static object[] SingleTempArgsArray(object arg); // 0x000000018CB3B73C-0x000000018CB3B7C4
		public static string FriendlyTypeName(string fullName); // 0x000000018CB38210-0x000000018CB3830C
		public static System.Type[] RTGetEmptyTypes(); // 0x000000018CB3A480-0x000000018CB3A4D0
		private static bool MemberResolvedFromDeserializeAttribute(MemberInfo member, string targetName); // 0x000000018CB39F44-0x000000018CB39FBC
		public static Delegate ConvertDelegate(Delegate originalDelegate, System.Type targetDelegateType); // 0x000000018CB36FF4-0x000000018CB37034
		public static bool TryConvert(System.Type fromType, System.Type toType, out UnaryExpression exp); // 0x000000018CB3B7C4-0x000000018CB3B8C8
		public static void DigFields(object root, Predicate<System.Reflection.FieldInfo> move, Action<object> push, Action<object> pop); // 0x000000018CB370EC-0x000000018CB376B8
		public static Func<T, TResult> GetFieldGetter<T, TResult>(System.Reflection.FieldInfo info);
		public static Action<T, TValue> GetFieldSetter<T, TValue>(System.Reflection.FieldInfo info);
	
		// Extension methods
		public static MethodType GetMethodSpecialType(this MethodBase method); // 0x000000018CB3945C-0x000000018CB398B8
		public static string FriendlyName(this System.Type t, bool compileSafe = false /* Metadata: 0x02629E58 */); // 0x000000018CB37CEC-0x000000018CB38210
		public static string FriendlyName(this MemberInfo info); // 0x000000018CB37BF0-0x000000018CB37CEC
		public static string FriendlyName(this MethodBase method); // 0x000000018CB376B8-0x000000018CB37710
		public static string FriendlyName(this MethodBase method, out MethodType specialNameType); // 0x000000018CB37710-0x000000018CB37BF0
		public static string SignatureName(this MethodBase method); // 0x000000018CB3B354-0x000000018CB3B73C
		public static System.Type RTReflectedOrDeclaredType(this MemberInfo member); // 0x000000018CB3B0D8-0x000000018CB3B14C
		public static bool RTIsAssignableFrom(this System.Type type, System.Type other); // 0x00000001857C4680-0x00000001857C46B0
		public static bool RTIsAssignableTo(this System.Type type, System.Type other); // 0x00000001857C4630-0x00000001857C4680
		public static bool RTIsAbstract(this System.Type type); // 0x000000018CB3AFD0-0x000000018CB3AFEC
		public static bool RTIsValueType(this System.Type type); // 0x000000018CB3B0B8-0x000000018CB3B0D8
		public static bool RTIsArray(this System.Type type); // 0x000000018CB3AFEC-0x000000018CB3B00C
		public static bool RTIsInterface(this System.Type type); // 0x000000018CB3B09C-0x000000018CB3B0B8
		public static bool RTIsSubclassOf(this System.Type type, System.Type other); // 0x000000018581D430-0x000000018581D490
		public static bool RTIsGenericParameter(this System.Type type); // 0x000000018CB3B05C-0x000000018CB3B07C
		public static bool RTIsGenericType(this System.Type type); // 0x000000018CB3B07C-0x000000018CB3B09C
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop); // 0x000000018CB3AB74-0x000000018CB3AB90
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop); // 0x000000018CB3AFB4-0x000000018CB3AFD0
		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del); // 0x000000018CB3A314-0x000000018CB3A334
		public static System.Type RTMakeGenericType(this System.Type type, params System.Type[] typeArgs); // 0x0000000186E01630-0x0000000186E01660
		public static System.Type[] RTGetGenericArguments(this System.Type type); // 0x00000001863EB240-0x00000001863EB350
		public static System.Type[] RTGetGenericArguments(this MethodInfo method); // 0x000000018CB3AA6C-0x000000018CB3AB74
		public static System.Type RTGetElementType(this System.Type type); // 0x000000018CB3A430-0x000000018CB3A480
		public static bool RTIsByRef(this System.Type type); // 0x000000018CB3B00C-0x000000018CB3B05C
		public static object CreateObject(this System.Type type); // 0x000000018CB3709C-0x000000018CB370EC
		public static object CreateObjectUninitialized(this System.Type type); // 0x000000018CB37034-0x000000018CB3709C
		public static ConstructorInfo RTGetDefaultConstructor(this System.Type type); // 0x00000001858C6680-0x00000001858C6750
		public static ConstructorInfo RTGetConstructor(this System.Type type, System.Type[] paramTypes); // 0x000000018CB3A1C8-0x000000018CB3A314
		public static MethodInfo RTGetMethod(this System.Type type, string name); // 0x000000018CB3AB90-0x000000018CB3AC74
		public static MethodInfo RTGetMethod(this System.Type type, string name, System.Type[] paramTypes, System.Type returnType = null, System.Type[] genericArgumentTypes = null); // 0x000000018CB3AC74-0x000000018CB3AED0
		public static System.Reflection.FieldInfo RTGetField(this System.Type type, string name, bool includePrivateBase = false /* Metadata: 0x02629E59 */); // 0x000000018CB3A944-0x000000018CB3AA6C
		public static PropertyInfo RTGetProperty(this System.Type type, string name); // 0x0000000186689620-0x00000001866896E0
		public static MemberInfo RTGetFieldOrProp(this System.Type type, string name); // 0x000000018CB3A7D8-0x000000018CB3A944
		public static EventInfo RTGetEvent(this System.Type type, string name); // 0x000000018CB3A4D0-0x000000018CB3A5B4
		public static object RTGetFieldOrPropValue(this MemberInfo member, object instance, int index = -1 /* Metadata: 0x02629E5A */); // 0x000000018CB3A698-0x000000018CB3A7D8
		public static void RTSetFieldOrPropValue(this MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x02629E5B */); // 0x000000018CB3B14C-0x000000018CB3B298
		public static ConstructorInfo[] RTGetConstructors(this System.Type type); // 0x00000001858C5740-0x00000001858C5860
		public static MethodInfo[] RTGetMethods(this System.Type type); // 0x000000018CB3AED0-0x000000018CB3AFB4
		public static System.Reflection.FieldInfo[] RTGetFields(this System.Type type); // 0x00000001857C3660-0x00000001857C3740
		public static PropertyInfo[] RTGetProperties(this System.Type type); // 0x00000001866896E0-0x00000001866897C0
		public static EventInfo[] RTGetEvents(this System.Type type); // 0x000000018CB3A5B4-0x000000018CB3A698
		public static object[] RTGetAllAttributes(this System.Type type); // 0x00000001857C46B0-0x00000001857C47C0
		public static bool RTIsDefined<T>(this System.Type type, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this System.Type type, System.Type attributeType, bool inherited); // 0x0000000186743C10-0x0000000186743DB0
		public static T RTGetAttribute<T>(this System.Type type, bool inherited)
			where T : Attribute;
		public static Attribute RTGetAttribute(this System.Type type, System.Type attributeType, bool inherited); // 0x00000001857C44F0-0x00000001857C4630
		public static object[] RTGetAllAttributes(this MemberInfo member); // 0x00000001857C4410-0x00000001857C44F0
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this MemberInfo member, System.Type attributeType, bool inherited); // 0x00000001857C3FC0-0x00000001857C41F0
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static Attribute RTGetAttribute(this MemberInfo member, System.Type attributeType, bool inherited); // 0x00000001857C41F0-0x00000001857C4410
		[IteratorStateMachine(typeof(_RTGetAttributesRecursive_d__99<T>))]
		public static IEnumerable<T> RTGetAttributesRecursive<T>(this System.Type type)
			where T : Attribute;
		public static ParameterInfo[] RTGetDelegateTypeParameters(this System.Type delegateType); // 0x000000018CB3A334-0x000000018CB3A430
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
			where T : Delegate;
		public static Delegate RTCreateDelegate(this MethodInfo method, System.Type type, object instance); // 0x000000018CB39FBC-0x000000018CB3A1C8
		public static bool IsReadOnly(this System.Reflection.FieldInfo field); // 0x000000018CB39E7C-0x000000018CB39EB4
		public static bool IsConstant(this System.Reflection.FieldInfo field); // 0x000000018CB39A68-0x000000018CB39AC8
		public static bool IsStatic(this EventInfo info); // 0x000000018CB39EFC-0x000000018CB39F44
		public static bool IsStatic(this PropertyInfo info); // 0x000000018CB39EB4-0x000000018CB39EFC
		public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters); // 0x000000018CB39DA0-0x000000018CB39E34
		public static bool IsObsolete(this MemberInfo member, bool inherited = true /* Metadata: 0x02629E5C */); // 0x000000018CB39C20-0x000000018CB39DA0
		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x000000018CB3889C-0x000000018CB38BA0
		public static System.Reflection.FieldInfo GetBaseDefinition(this System.Reflection.FieldInfo fieldInfo); // 0x000000018CB38820-0x000000018CB3889C
		public static MethodInfo[] GetExtensionMethods(this System.Type targetType); // 0x000000018CB38D40-0x000000018CB39030
		public static bool IsExtensionMethod(this MethodInfo method); // 0x000000018CB39B9C-0x000000018CB39BF0
		public static bool IsPropertyAccessor(this MethodInfo method); // 0x000000018CB39E34-0x000000018CB39E7C
		public static bool IsIndexerProperty(this PropertyInfo property); // 0x000000018CB39BF0-0x000000018CB39C20
		public static bool IsAutoProperty(this PropertyInfo property); // 0x000000018CB39988-0x000000018CB39A68
		public static PropertyInfo GetAccessorProperty(this MethodInfo method); // 0x000000018CB3830C-0x000000018CB383B4
		public static bool IsEnumerableCollection(this System.Type type); // 0x000000018CB39AC8-0x000000018CB39B9C
		public static System.Type GetEnumerableElementType(this System.Type type); // 0x000000018CB38BA0-0x000000018CB38D40
		public static System.Type GetSingleGenericArgument(this System.Type type); // 0x000000018CB398B8-0x000000018CB39938
		public static System.Type GetFirstGenericParameterConstraintType(this System.Type type); // 0x000000018CB39144-0x000000018CB3926C
		public static System.Type GetFirstGenericParameterConstraintType(this MethodInfo method); // 0x000000018CB39030-0x000000018CB39144
		public static bool TryMakeGeneric(this System.Type def, System.Type argType, out System.Type result); // 0x000000018CB3B8C8-0x000000018CB3BA50
		public static bool TryMakeGeneric(this MethodInfo def, System.Type argType, out MethodInfo result); // 0x000000018CB3BA50-0x000000018CB3BBCC
		public static Array Resize(this Array array, int newSize); // 0x000000018CB3B298-0x000000018CB3B354
	}

	public static class TypeConverter // TypeDefIndex: 77350
	{
		// Fields
		[CompilerGenerated]
		private static CustomConverter customConverter; // 0x00
	
		// Events
		public static event CustomConverter customConverter {
			add; // 0x000000018CB4AAA8-0x000000018CB4AB50
			remove; // 0x000000018CB4AB50-0x000000018CB4ABF8
		}
	
		// Nested types
		public delegate Func<object, object> CustomConverter(System.Type fromType, System.Type toType); // TypeDefIndex: 77347; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 77348
		{
			// Fields
			public System.Type toType; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _Get_b__2(object value); // 0x000000018CB4B614-0x000000018CB4B718
			internal object _Get_b__4(object value); // 0x000000018CB4B718-0x000000018CB4B7C4
			internal object _Get_b__6(object value); // 0x000000018CB4B7C4-0x000000018CB4B880
			internal object _Get_b__7(object value); // 0x000000018CB4B880-0x000000018CB4B92C
			internal object _Get_b__8(object value); // 0x000000018CB4B92C-0x000000018CB4B9E8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77349
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
			static __c(); // 0x00000001871E7520-0x00000001871E7580
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _Get_b__4_0(object value); // 0x000000018459BB50-0x000000018459BB60
			internal object _Get_b__4_1(object value); // 0x000000018CB4B27C-0x000000018CB4B2C8
			internal object _Get_b__4_3(object value); // 0x000000018CB4B2C8-0x000000018CB4B30C
			internal object _Get_b__4_5(object value); // 0x000000018CB4B30C-0x000000018CB4B3AC
			internal object _Get_b__4_9(object value); // 0x000000018CB4B3AC-0x000000018CB4B488
			internal object _Get_b__4_10(object value); // 0x000000018CB4ADF0-0x000000018CB4AED8
			internal object _Get_b__4_11(object value); // 0x000000018CB4AED8-0x000000018CB4AFAC
			internal object _Get_b__4_12(object value); // 0x000000018CB4AFAC-0x000000018CB4B08C
			internal object _Get_b__4_13(object value); // 0x000000018CB4B08C-0x000000018CB4B10C
			internal object _Get_b__4_14(object value); // 0x000000018CB4B10C-0x000000018CB4B18C
			internal object _Get_b__4_15(object value); // 0x000000018CB4B18C-0x000000018CB4B204
			internal object _Get_b__4_16(object value); // 0x000000018CB4B204-0x000000018CB4B27C
		}
	
		// Methods
		public static Func<object, object> Get(System.Type fromType, System.Type toType); // 0x00000001863C30C0-0x00000001863C3890
		public static bool CanConvert(System.Type fromType, System.Type toType); // 0x000000018CB4AA90-0x000000018CB4AAA8
	}

	public static class ColorUtils // TypeDefIndex: 77351
	{
		// Fields
		private static Dictionary<Color32, string> colorHexCache; // 0x00
		private static Dictionary<string, UnityEngine.Color> hexColorCache; // 0x08
		private static Dictionary<ValueTuple<int, int, Gradient, float>, Texture2D> gradientTextureCache; // 0x10
		private static Dictionary<ValueTuple<UnityEngine.Color, float, UnityEngine.Color, float>, Gradient> gradientCache; // 0x18
		private static Dictionary<string, Gradient> menuItemRibbonGradientCache; // 0x20
	
		// Constructors
		static ColorUtils(); // 0x0000000186E0F130-0x0000000186E0F3A0
	
		// Methods
		public static UnityEngine.Color Grey(float value); // 0x0000000187254460-0x0000000187254480
		public static string ColorToHex(Color32 color); // 0x000000018CB3EC08-0x000000018CB3ED80
		public static UnityEngine.Color HexToColor(string hex); // 0x0000000185B3B600-0x0000000185B3B8C0
		public static Texture2D CreateGradientTexture(int width, int height, Gradient gradient, float rotateDegree); // 0x000000018CB3ED80-0x000000018CB3F030
		public static Gradient CreateGradient(UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio); // 0x000000018CB3F030-0x000000018CB3F2E4
		public static Gradient GetMenuItemRibbonGradientOfNodeFullPath(string fullPath); // 0x000000018CB3F2E4-0x000000018CB3F36C
		public static void RegisterMenuItemRibbonGradientOfNodeFullPath(string fullPath, UnityEngine.Color colorLeft, float colorLeftRatio, UnityEngine.Color colorRight, float colorRightRatio); // 0x000000018CB3F36C-0x000000018CB3F448
	
		// Extension methods
		public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha); // 0x0000000187254480-0x00000001872544A0
	}

	public static class CurveUtils // TypeDefIndex: 77352
	{
		// Fields
		private const float POS_CHECK_RES = 100f; // Metadata: 0x02629E7F
		private const float POS_CHECK_DISTANCE = 10f; // Metadata: 0x02629E83
	
		// Methods
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t); // 0x000000018CB3F448-0x000000018CB3F570
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition); // 0x000000018CB3F570-0x000000018CB3F5A8
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm); // 0x000000018CB3F5A8-0x000000018CB3F790
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x000000018CB3F984-0x000000018CB3FA40
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x000000018CB3F790-0x000000018CB3F984
	}

	public static class GUIStyleUtils // TypeDefIndex: 77353
	{
		// Extension methods
		public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018CB44C90-0x000000018CB44D40
		public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018CB44DF0-0x000000018CB44EA0
		public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018CB44BE0-0x000000018CB44C90
		public static GUIStyle Overflow(this GUIStyle style, int left, int right, int top, int bottom); // 0x000000018CB44D40-0x000000018CB44DF0
		public static GUIStyle TextAlignment(this GUIStyle style, TextAnchor anchor); // 0x000000018CB44EC8-0x000000018CB44EF0
		public static GUIStyle RichText(this GUIStyle style, bool rich); // 0x000000018CB44EA0-0x000000018CB44EC8
	}

	public static class LayerUtils // TypeDefIndex: 77354
	{
		// Methods
		public static LayerMask CreateFromNames(params string[] layerNames); // 0x000000018CB45C28-0x000000018CB45C30
		public static LayerMask CreateFromNumbers(params int[] layerNumbers); // 0x000000018CB45C30-0x000000018CB45C38
		public static LayerMask LayerNamesToMask(params string[] layerNames); // 0x000000018CB45C38-0x000000018CB45CA0
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers); // 0x000000018CB45CA0-0x000000018CB45CE0
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask mask); // 0x00000001872544A0-0x00000001872544B0
		public static LayerMask AddToMask(this LayerMask mask, params string[] layerNames); // 0x000000018CB45B28-0x000000018CB45B48
		public static LayerMask RemoveFromMask(this LayerMask mask, params string[] layerNames); // 0x000000018CB45E80-0x000000018CB45EA4
		public static bool ContainsAnyLayer(this LayerMask mask, params string[] layerNames); // 0x000000018CB45BB8-0x000000018CB45C28
		public static bool ContainsAllLayers(this LayerMask mask, params string[] layerNames); // 0x000000018CB45B48-0x000000018CB45BB8
		public static string[] MaskToNames(this LayerMask mask); // 0x000000018CB45CE0-0x000000018CB45DB8
		public static string MaskToString(this LayerMask mask); // 0x000000018CB45E44-0x000000018CB45E80
		public static string MaskToString(this LayerMask mask, string delimiter); // 0x000000018CB45DB8-0x000000018CB45E44
	}

	public static class ObjectUtils // TypeDefIndex: 77356
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 77355
		{
			// Fields
			public GameObject exclude; // 0x10
			public LayerMask mask; // 0x18
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindGameObjectsWithinLayerMask_b__0(GameObject x); // 0x000000018CB4B9E8-0x000000018CB4BA5C
		}
	
		// Methods
		public static bool AnyEquals(object a, object b); // 0x000000018CB471B8-0x000000018CB4727C
		public static IEnumerable<GameObject> FindGameObjectsWithinLayerMask(LayerMask mask, GameObject exclude = null); // 0x000000018CB4727C-0x000000018CB47378
	
		// Extension methods
		public static List<T> Shuffle<T>(this List<T> list);
		public static bool Is<T>(this object o, out ref T result);
		public static T GetAddComponent<T>(this GameObject gameObject)
			where T : Component;
		public static Component TransformToType(this Component current, System.Type type); // 0x000000018581D2A0-0x000000018581D430
		public static bool IsInLayerMask(this GameObject gameObject, LayerMask mask); // 0x000000018CB47378-0x000000018CB473A8
	}

	public static class RectUtils // TypeDefIndex: 77357
	{
		// Methods
		public static Rect GetBoundRect(params Rect[] rects); // 0x000000018CB474DC-0x000000018CB475FC
		public static Rect GetBoundRect(params Vector2[] positions); // 0x000000018CB475FC-0x000000018CB47710
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b); // 0x000000018CB473A8-0x000000018CB473F4
		public static Rect ExpandBy(this Rect rect, float margin); // 0x000000018CB4745C-0x000000018CB47498
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin); // 0x000000018CB47498-0x000000018CB474DC
		public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom); // 0x000000018CB473F4-0x000000018CB4745C
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer); // 0x000000018CB47790-0x000000018CB478C8
		public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer); // 0x000000018CB47710-0x000000018CB47790
	}

	public static class StringUtils // TypeDefIndex: 77358
	{
		// Fields
		public const string SPACE = " "; // Metadata: 0x02629E89
		public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Metadata: 0x02629E8B
		public static readonly char[] CHAR_SPACE_ARRAY; // 0x00
		private static Dictionary<string, string> splitCaseCache; // 0x08
	
		// Constructors
		static StringUtils(); // 0x000000018CB4A61C-0x000000018CB4A738
	
		// Methods
		public static string GetAlphabetLetter(int index); // 0x000000018CB497B8-0x000000018CB49848
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x02629E87 */); // 0x000000018CB49B48-0x000000018CB49EE0
		public static bool SearchMatch(string input, string leafName, string categoryName = "" /* Metadata: 0x02629E88 */); // 0x000000018CB49EE0-0x000000018CB4A214
	
		// Extension methods
		public static string SplitCamelCase(this string s); // 0x000000018CB4A214-0x000000018CB4A3B8
		public static string CapitalizeFirst(this string s); // 0x000000018CB496C8-0x000000018CB4977C
		public static string CapLength(this string s, int max); // 0x000000018CB49654-0x000000018CB496C8
		public static string GetCapitals(this string s); // 0x000000018CB49848-0x000000018CB49950
		public static string FormatError(this string input); // 0x000000018CB4977C-0x000000018CB497B8
		public static string GetStringWithinOuter(this string input, char from, char to); // 0x000000018CB499E4-0x000000018CB49A4C
		public static string GetStringWithinInner(this string input, char from, char to); // 0x000000018CB49950-0x000000018CB499E4
		public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process); // 0x000000018CB49A4C-0x000000018CB49B48
		public static string ToStringAdvanced(this object o); // 0x000000018CB4A3B8-0x000000018CB4A61C
	}

	public class WeakReferenceList<T> // TypeDefIndex: 77359
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

	public class WeakReferenceTable<TKey, TValue> // TypeDefIndex: 77360
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
	public enum EaseType // TypeDefIndex: 77460
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

	public static class Easing // TypeDefIndex: 77461
	{
		// Methods
		public static float Ease(ParadoxNotion.Animation.EaseType type, float from, float to, float t); // 0x000000018CB511EC-0x000000018CB51270
		public static Vector3 Ease(ParadoxNotion.Animation.EaseType type, Vector3 from, Vector3 to, float t); // 0x000000018CB51108-0x000000018CB511EC
		public static Quaternion Ease(ParadoxNotion.Animation.EaseType type, Quaternion from, Quaternion to, float t); // 0x000000018CB51044-0x000000018CB51108
		public static UnityEngine.Color Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t); // 0x000000018CB51270-0x000000018CB5132C
		public static Func<float, float> Function(ParadoxNotion.Animation.EaseType type); // 0x000000018CB514FC-0x000000018CB51C2C
		public static float Linear(float t); // 0x0000000186805BA0-0x0000000186805BB0
		public static float QuadraticIn(float t); // 0x00000001872355E0-0x00000001872355F0
		public static float QuadraticOut(float t); // 0x00000001872546A0-0x00000001872546C0
		public static float QuadraticInOut(float t); // 0x000000018CB51C2C-0x000000018CB51C88
		public static float QuarticIn(float t); // 0x00000001872546C0-0x00000001872546D0
		public static float QuarticOut(float t); // 0x00000001872546D0-0x0000000187254700
		public static float QuarticInOut(float t); // 0x000000018CB51C88-0x000000018CB51CDC
		public static float QuinticIn(float t); // 0x0000000187254700-0x0000000187254720
		public static float QuinticOut(float t); // 0x0000000187254720-0x0000000187254750
		public static float QuinticInOut(float t); // 0x000000018CB51CDC-0x000000018CB51D38
		public static float CubicIn(float t); // 0x00000001872367F0-0x0000000187236800
		public static float CubicOut(float t); // 0x0000000187254590-0x00000001872545B0
		public static float CubicInOut(float t); // 0x000000018CB50FDC-0x000000018CB51044
		public static float SinusoidalIn(float t); // 0x000000018CB51D38-0x000000018CB51D68
		public static float SinusoidalOut(float t); // 0x000000018CB51D68-0x000000018CB51D80
		public static float SinusoidalInOut(float t); // 0x0000000187254750-0x0000000187254780
		public static float ExponentialIn(float t); // 0x000000018CB5148C-0x000000018CB514B8
		public static float ExponentialOut(float t); // 0x000000018CB514B8-0x000000018CB514FC
		public static float ExponentialInOut(float t); // 0x000000018CB5140C-0x000000018CB5148C
		public static float CircularIn(float t); // 0x0000000187254500-0x0000000187254560
		public static float CircularOut(float t); // 0x0000000187254560-0x0000000187254590
		public static float CircularInOut(float t); // 0x000000018CB50F78-0x000000018CB50FDC
		public static float ElasticIn(float t); // 0x00000001872545B0-0x0000000187254630
		public static float ElasticOut(float t); // 0x0000000187254630-0x00000001872546A0
		public static float ElasticInOut(float t); // 0x000000018CB5132C-0x000000018CB5140C
		public static float BounceIn(float t); // 0x000000018CB50EAC-0x000000018CB50EE0
		public static float BounceOut(float t); // 0x000000018CB50EE0-0x000000018CB50F78
		public static float BounceInOut(float t); // 0x000000018CB50E40-0x000000018CB50EAC
		public static float BackIn(float t); // 0x00000001872544B0-0x00000001872544D0
		public static float BackOut(float t); // 0x00000001872544D0-0x0000000187254500
		public static float BackInOut(float t); // 0x000000018CB50DD8-0x000000018CB50E40
	}
}

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class SpoofAOTAttribute : Attribute // TypeDefIndex: 77462
	{
		// Constructors
		public SpoofAOTAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class CancelSpoofAOTAttribute : Attribute // TypeDefIndex: 77463
	{
		// Constructors
		public CancelSpoofAOTAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DoNotListAttribute : Attribute // TypeDefIndex: 77464
	{
		// Constructors
		public DoNotListAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ProtectedSingletonAttribute : Attribute // TypeDefIndex: 77465
	{
		// Constructors
		public ProtectedSingletonAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ExecutionPriorityAttribute : Attribute // TypeDefIndex: 77466
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public ExecutionPriorityAttribute(int priority); // 0x0000000182234E90-0x0000000182234EA0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ExposeAsDefinitionAttribute : Attribute // TypeDefIndex: 77467
	{
		// Constructors
		public ExposeAsDefinitionAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ExposeFieldAttribute : Attribute // TypeDefIndex: 77468
	{
		// Constructors
		public ExposeFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class NodeCanvasOdinOnlyAttribute : Attribute // TypeDefIndex: 77469
	{
		// Constructors
		public NodeCanvasOdinOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ListInspectorOptionAttribute : Attribute // TypeDefIndex: 77470
	{
		// Fields
		public readonly bool allowAdd; // 0x10
		public readonly bool allowRemove; // 0x11
		public readonly bool showFoldout; // 0x12
	
		// Constructors
		public ListInspectorOptionAttribute(bool allowAdd, bool allowRemove, bool alwaysExpanded); // 0x0000000187254780-0x0000000187254790
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class NameAttribute : Attribute // TypeDefIndex: 77471
	{
		// Fields
		public readonly string name; // 0x10
		public readonly int priority; // 0x18
	
		// Constructors
		public NameAttribute(string name, int priority = 0 /* Metadata: 0x02629F0F */); // 0x0000000186BC5250-0x0000000186BC5270
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 77472
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute(string category); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 77473
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute(string description); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class IconAttribute : Attribute // TypeDefIndex: 77474
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly bool fixedColor; // 0x18
		public readonly string runtimeIconTypeCallback; // 0x20
		public readonly System.Type fromType; // 0x28
	
		// Constructors
		public IconAttribute(string iconName = "" /* Metadata: 0x02629F10 */, bool fixedColor = false /* Metadata: 0x02629F11 */, string runtimeIconTypeCallback = "" /* Metadata: 0x02629F12 */); // 0x0000000186C9B4C0-0x0000000186C9B4F0
		public IconAttribute(System.Type fromType); // 0x0000000185CA30F0-0x0000000185CA3100
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ColorAttribute : Attribute // TypeDefIndex: 77475
	{
		// Fields
		public readonly string hexColor; // 0x10
	
		// Constructors
		public ColorAttribute(string hexColor); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class ColorGradientAttribute : Attribute // TypeDefIndex: 77476
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get; } // 0x000000018CB50D10-0x000000018CB50D74 
		public UnityEngine.Color colorRight { get; } // 0x000000018CB50D74-0x000000018CB50DD8 
	
		// Constructors
		public ColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02629F13 */); // 0x000000018CB50CCC-0x000000018CB50D10
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class NodeMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 77477
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get; } // 0x000000018CB548E4-0x000000018CB54948 
		public UnityEngine.Color colorRight { get; } // 0x000000018CB54948-0x000000018CB549AC 
	
		// Constructors
		public NodeMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02629F17 */); // 0x000000018CB50CCC-0x000000018CB50D10
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class NodeCategoryMenuItemColorGradientAttribute : Attribute // TypeDefIndex: 77478
	{
		// Fields
		public readonly string hexColorLeft; // 0x10
		public readonly float colorLeftRatio; // 0x18
		public readonly string hexColorRight; // 0x20
		public readonly float colorRightRatio; // 0x28
		public readonly float rotateDegree; // 0x2C
	
		// Properties
		public UnityEngine.Color colorLeft { get; } // 0x000000018CB5481C-0x000000018CB54880 
		public UnityEngine.Color colorRight { get; } // 0x000000018CB54880-0x000000018CB548E4 
	
		// Constructors
		public NodeCategoryMenuItemColorGradientAttribute(string hexColorLeft, float colorLeftRatio, string hexColorRight, float colorRightRatio, float rotateDegree = 0f /* Metadata: 0x02629F1B */); // 0x000000018CB50CCC-0x000000018CB50D10
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Conditional("UNITY_EDITOR")]
	public class HideAttribute : Attribute // TypeDefIndex: 77479
	{
		// Constructors
		public HideAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public abstract class DrawerAttribute : Attribute // TypeDefIndex: 77480
	{
		// Properties
		public virtual int priority { get; } // 0x00000001872537B0-0x00000001872537C0 
		public virtual bool isDecorator { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		protected DrawerAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HeaderAttribute : DrawerAttribute // TypeDefIndex: 77481
	{
		// Fields
		public readonly string title; // 0x10
	
		// Properties
		public override bool isDecorator { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public HeaderAttribute(string title); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DimIfDefaultAttribute : DrawerAttribute // TypeDefIndex: 77482
	{
		// Properties
		public override bool isDecorator { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override int priority { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public DimIfDefaultAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : DrawerAttribute // TypeDefIndex: 77483
	{
		// Fields
		public readonly string fieldName; // 0x10
		public readonly int checkValue; // 0x18
	
		// Properties
		public override bool isDecorator { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override int priority { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public ShowIfAttribute(string fieldName, int checkValue); // 0x0000000186C749A0-0x0000000186C749C0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredFieldAttribute : DrawerAttribute // TypeDefIndex: 77484
	{
		// Properties
		public override bool isDecorator { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override int priority { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Constructors
		public RequiredFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowButtonAttribute : DrawerAttribute // TypeDefIndex: 77485
	{
		// Fields
		public readonly string buttonTitle; // 0x10
		public readonly string methodName; // 0x18
	
		// Properties
		public override bool isDecorator { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override int priority { get; } // 0x00000001872396E0-0x00000001872396F0 
	
		// Constructors
		public ShowButtonAttribute(string buttonTitle, string methodnameCallback); // 0x0000000185381AC0-0x0000000185381AF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : DrawerAttribute // TypeDefIndex: 77486
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Properties
		public override bool isDecorator { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override int priority { get; } // 0x00000001845BA780-0x00000001845BA790 
	
		// Constructors
		public CallbackAttribute(string methodName); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class MinValueAttribute : DrawerAttribute // TypeDefIndex: 77487
	{
		// Fields
		public readonly float min; // 0x10
	
		// Properties
		public override int priority { get; } // 0x0000000187239C70-0x0000000187239C80 
	
		// Constructors
		public MinValueAttribute(float min); // 0x0000000187235230-0x0000000187235240
		public MinValueAttribute(int min); // 0x0000000187254790-0x00000001872547A0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DelayedFieldAttribute : DrawerAttribute // TypeDefIndex: 77488
	{
		// Constructors
		public DelayedFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class LayerFieldAttribute : DrawerAttribute // TypeDefIndex: 77489
	{
		// Constructors
		public LayerFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class TagFieldAttribute : DrawerAttribute // TypeDefIndex: 77490
	{
		// Constructors
		public TagFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class TextAreaFieldAttribute : DrawerAttribute // TypeDefIndex: 77491
	{
		// Fields
		public readonly int numberOfLines; // 0x10
	
		// Constructors
		public TextAreaFieldAttribute(int numberOfLines); // 0x0000000182234E90-0x0000000182234EA0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class PopupFieldAttribute : DrawerAttribute // TypeDefIndex: 77492
	{
		// Fields
		public readonly object[] options; // 0x10
	
		// Constructors
		public PopupFieldAttribute(params object[] options); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SliderFieldAttribute : DrawerAttribute // TypeDefIndex: 77493
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public SliderFieldAttribute(float min, float max); // 0x0000000187240DF0-0x0000000187240E00
		public SliderFieldAttribute(int min, int max); // 0x00000001872547A0-0x00000001872547C0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ForceObjectFieldAttribute : DrawerAttribute // TypeDefIndex: 77494
	{
		// Constructors
		public ForceObjectFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class UndoUtility // TypeDefIndex: 77495
	{
		// Fields
		[CompilerGenerated]
		private static string _lastOperationName_k__BackingField; // 0x00
	
		// Properties
		public static string lastOperationName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CB55534-0x000000018CB5556C 0x000000018CB5556C-0x000000018CB555BC
	
		// Methods
		[Conditional("UNITY_EDITOR")]
		public static void RecordObject(UnityEngine.Object target, string name, bool forceIgnoreScene = false /* Metadata: 0x02629F1F */); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void RecordObjectComplete(UnityEngine.Object target, string name, bool forceIgnore = false /* Metadata: 0x02629F20 */); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void SetDirty(UnityEngine.Object target); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void RecordObject(UnityEngine.Object target, string name, Action operation); // 0x000000018CB55518-0x000000018CB55534
		[Conditional("UNITY_EDITOR")]
		public static void RecordObjectComplete(UnityEngine.Object target, string name, Action operation); // 0x000000018CB55518-0x000000018CB55534
		public static string GetLastOperationNameOr(string operation); // 0x000000018CB554EC-0x000000018CB55518
		public static void CheckUndo(UnityEngine.Object target, string name); // 0x000000018CB5543C-0x000000018CB554EC
		public static void CheckDirty(UnityEngine.Object target); // 0x000000018CB553FC-0x000000018CB5543C
	}
}

namespace ParadoxNotion.Serialization
{
	public class DeserializeFromAttribute : Attribute // TypeDefIndex: 77381
	{
		// Fields
		public readonly string previousTypeFullName; // 0x10
	
		// Constructors
		public DeserializeFromAttribute(string previousTypeFullName); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor // TypeDefIndex: 77384
		where TMissing : TCanProcess, IMissingRecoverable
	{
		// Fields
		private const string FIELD_NAME_TYPE = "_missingType"; // Metadata: 0x02629EA9
		private const string FIELD_NAME_STATE = "_recoveryState"; // Metadata: 0x02629EB6
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 77382
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
		private sealed class __c // TypeDefIndex: 77383
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

	public class fsUnityObjectConverter : fsConverter // TypeDefIndex: 77385
	{
		// Constructors
		public fsUnityObjectConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x00000001869C4480-0x00000001869C4520
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB50310-0x000000018CB504FC
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x00000001865A7D60-0x00000001865A7EE0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000185829EC0-0x0000000185829ED0
	}

	public interface IMissingRecoverable // TypeDefIndex: 77386
	{
		// Properties
		string missingType { get; set; }
		string recoveryState { get; set; }
	}

	public interface ISerializedMethodBaseInfo : ISerializedReflectedInfo // TypeDefIndex: 77387
	{
		// Methods
		MethodBase GetMethodBase();
		bool HasChanged();
	}

	public interface ISerializedReflectedInfo : ISerializationCallbackReceiver // TypeDefIndex: 77388
	{
		// Methods
		MemberInfo AsMemberInfo();
		string AsString();
	}

	public static class JSONSerializer // TypeDefIndex: 77389
	{
		// Fields
		public static bool enableCache; // 0x00
		private static object serializerLock; // 0x08
		private static fsSerializer serializer; // 0x10
		private static Dictionary<string, fsData> dataCache; // 0x18
	
		// Constructors
		static JSONSerializer(); // 0x000000018699E3B0-0x000000018699E430
	
		// Methods
		public static void FlushMem(); // 0x000000018699E430-0x000000018699E560
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void __FlushDataCache(); // 0x000000018699E560-0x000000018699E610
		public static string Serialize(System.Type type, object instance, List<UnityEngine.Object> references = null, bool pretyJson = false /* Metadata: 0x02629EC5 */); // 0x000000018CB45534-0x000000018CB45994
		public static T Deserialize<T>(string json, List<UnityEngine.Object> references = null);
		public static object Deserialize(System.Type type, string json, List<UnityEngine.Object> references = null); // 0x000000018CB4508C-0x000000018CB450F8
		public static T TryDeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> references = null)
			where T : class;
		public static object TryDeserializeOverwrite(object instance, string json, List<UnityEngine.Object> references = null); // 0x000000018CB45A9C-0x000000018CB45B28
		private static object Internal_Deserialize(System.Type type, string json, List<UnityEngine.Object> references, object instance); // 0x00000001852A3140-0x00000001852A3870
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object, fsData> call); // 0x000000018CB45114-0x000000018CB45304
		public static void SerializeAndExecuteNoCycles(System.Type type, object instance, Action<object> beforeCall, Action<object, fsData> afterCall); // 0x000000018CB45304-0x000000018CB45534
		public static T Clone<T>(T original);
		public static object Clone(object original); // 0x000000018CB44EF0-0x000000018CB44FB8
		public static void CopySerialized(object source, object target); // 0x000000018CB44FB8-0x000000018CB4508C
		public static void ShowData(string json, string fileName = "" /* Metadata: 0x02629EC6 */); // 0x000000018CB45994-0x000000018CB45A9C
		public static string PrettifyJson(string json); // 0x000000018CB450F8-0x000000018CB45114
	}

	[Serializable]
	public sealed class SerializationPair // TypeDefIndex: 77390
	{
		// Fields
		public string _json; // 0x10
		public List<UnityEngine.Object> _references; // 0x18
	
		// Constructors
		public SerializationPair(); // 0x000000018CB478C8-0x000000018CB47940
	}

	[Serializable]
	public class SerializedConstructorInfo : ISerializedMethodBaseInfo // TypeDefIndex: 77393
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
		private sealed class __c // TypeDefIndex: 77391
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, string> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB4BC14-0x000000018CB4BC78
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__4_0(ParameterInfo p); // 0x000000018CB4B488-0x000000018CB4B4B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 77392
		{
			// Fields
			public System.Type[] parameterTypes; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__0(ConstructorInfo c); // 0x000000018CB4BA5C-0x000000018CB4BA98
		}
	
		// Constructors
		public SerializedConstructorInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		public SerializedConstructorInfo(ConstructorInfo constructor); // 0x000000018CB47F8C-0x000000018CB47FA0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB47D0C-0x000000018CB47F8C
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB479FC-0x000000018CB47D0C
		public MemberInfo AsMemberInfo(); // 0x000000018225E800-0x000000018225E810
		public MethodBase GetMethodBase(); // 0x000000018225E800-0x000000018225E810
		public bool HasChanged(); // 0x000000018225DF70-0x000000018225DF80
		public string AsString(); // 0x000000018CB47940-0x000000018CB479F4
		public override string ToString(); // 0x000000018CB479F4-0x000000018CB479FC
		public static implicit operator ConstructorInfo(SerializedConstructorInfo value); // 0x000000018CB47FA0-0x000000018CB47FB0
	}

	[Serializable]
	public class SerializedEventInfo : ISerializedReflectedInfo // TypeDefIndex: 77394
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private EventInfo _event; // 0x18
	
		// Constructors
		public SerializedEventInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		public SerializedEventInfo(EventInfo info); // 0x0000000187835500-0x0000000187835510
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB48118-0x000000018CB481D4
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB48018-0x000000018CB48118
		public MemberInfo AsMemberInfo(); // 0x0000000182234E30-0x0000000182234E40
		public string AsString(); // 0x000000018CB47FB0-0x000000018CB48010
		public override string ToString(); // 0x000000018CB48010-0x000000018CB48018
		public static implicit operator EventInfo(SerializedEventInfo value); // 0x000000018CB481D4-0x000000018CB481E4
	}

	[Serializable]
	public class SerializedFieldInfo : ISerializedReflectedInfo // TypeDefIndex: 77395
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Reflection.FieldInfo _field; // 0x18
	
		// Constructors
		public SerializedFieldInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		public SerializedFieldInfo(System.Reflection.FieldInfo info); // 0x0000000187835500-0x0000000187835510
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB48360-0x000000018CB4841C
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB4825C-0x000000018CB48360
		public MemberInfo AsMemberInfo(); // 0x0000000182234E30-0x0000000182234E40
		public string AsString(); // 0x000000018CB481E4-0x000000018CB48254
		public override string ToString(); // 0x000000018CB48254-0x000000018CB4825C
		public static implicit operator System.Reflection.FieldInfo(SerializedFieldInfo value); // 0x000000018CB481D4-0x000000018CB481E4
	}

	[Serializable]
	public class SerializedMethodInfo : ISerializedMethodBaseInfo // TypeDefIndex: 77398
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
		private sealed class __c // TypeDefIndex: 77396
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, string> __9__5_0; // 0x08
			public static Func<System.Type, string> __9__5_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018CB4BB4C-0x000000018CB4BBB0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__5_0(ParameterInfo p); // 0x000000018CB4B488-0x000000018CB4B4B0
			internal string _UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize_b__5_1(System.Type a); // 0x000000018CB4B4B0-0x000000018CB4B4D0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 77397
		{
			// Fields
			public string name; // 0x10
			public System.Type[] parameterTypes; // 0x18
			public bool isSerializedGeneric; // 0x20
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__0(MethodInfo m); // 0x000000018CB4BA98-0x000000018CB4BB18
			internal bool _UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize_b__1(MethodInfo m); // 0x000000018CB4BB18-0x000000018CB4BB4C
		}
	
		// Constructors
		public SerializedMethodInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		public SerializedMethodInfo(MethodInfo method); // 0x000000018CB48EC8-0x000000018CB48EDC
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB48A74-0x000000018CB48EC8
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB484D8-0x000000018CB48A74
		public MemberInfo AsMemberInfo(); // 0x0000000182262130-0x0000000182262140
		public MethodBase GetMethodBase(); // 0x0000000182262130-0x0000000182262140
		public bool HasChanged(); // 0x00000001822434B0-0x00000001822434C0
		public string AsString(); // 0x000000018CB4841C-0x000000018CB484D0
		public override string ToString(); // 0x000000018CB484D0-0x000000018CB484D8
		public static implicit operator MethodInfo(SerializedMethodInfo value); // 0x000000018CB48EDC-0x000000018CB48EEC
	}

	[Serializable]
	public class SerializedTypeInfo : ISerializedReflectedInfo // TypeDefIndex: 77399
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private System.Type _type; // 0x18
	
		// Constructors
		public SerializedTypeInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		public SerializedTypeInfo(System.Type info); // 0x000000018CA8CBA4-0x000000018CA8CBD0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB48F54-0x000000018CB48FC4
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB48EEC-0x000000018CB48F54
		public MemberInfo AsMemberInfo(); // 0x0000000182234E30-0x0000000182234E40
		public string AsString(); // 0x00000001829260F0-0x0000000182926100
		public override string ToString(); // 0x00000001829260F0-0x0000000182926100
		public static implicit operator System.Type(SerializedTypeInfo value); // 0x000000018CB481D4-0x000000018CB481E4
	}

	[Serializable]
	public class SerializedUnityEventInfo : ISerializedReflectedInfo // TypeDefIndex: 77400
	{
		// Fields
		[SerializeField]
		private string _baseInfo; // 0x10
		[NonSerialized]
		private MemberInfo _memberInfo; // 0x18
	
		// Properties
		public bool isStatic { get; } // 0x000000018CB4941C-0x000000018CB494F4 
		public System.Type memberType { get; } // 0x000000018CB494F4-0x000000018CB495C4 
	
		// Constructors
		public SerializedUnityEventInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		public SerializedUnityEventInfo(System.Reflection.FieldInfo info); // 0x0000000187835500-0x0000000187835510
		public SerializedUnityEventInfo(PropertyInfo info); // 0x0000000187835500-0x0000000187835510
		public SerializedUnityEventInfo(MemberInfo info); // 0x000000018CB49350-0x000000018CB4941C
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CB49294-0x000000018CB49350
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CB4903C-0x000000018CB49294
		public MemberInfo AsMemberInfo(); // 0x0000000182234E30-0x0000000182234E40
		public string AsString(); // 0x000000018CB48FC4-0x000000018CB49034
		public override string ToString(); // 0x000000018CB49034-0x000000018CB4903C
		public static implicit operator System.Reflection.FieldInfo(SerializedUnityEventInfo value); // 0x000000018CB4960C-0x000000018CB49654
		public static implicit operator PropertyInfo(SerializedUnityEventInfo value); // 0x000000018CB495C4-0x000000018CB4960C
	}
}

namespace ParadoxNotion.Serialization.FullSerializer
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 77401
	{
		// Fields
		public string MemberName; // 0x10
	
		// Constructors
		public fsForwardAttribute(string memberName); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsWriteOnlyAttribute : Attribute // TypeDefIndex: 77402
	{
		// Constructors
		public fsWriteOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsReadOnlyAttribute : Attribute // TypeDefIndex: 77403
	{
		// Constructors
		public fsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 77404
	{
		// Constructors
		public fsIgnoreAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsIgnoreInBuildAttribute : Attribute // TypeDefIndex: 77405
	{
		// Constructors
		public fsIgnoreInBuildAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class fsSerializeAsAttribute : Attribute // TypeDefIndex: 77406
	{
		// Fields
		public readonly string Name; // 0x10
	
		// Constructors
		public fsSerializeAsAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public fsSerializeAsAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateToAttribute : Attribute // TypeDefIndex: 77407
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public fsMigrateToAttribute(System.Type targetType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsMigrateVersionsAttribute : Attribute // TypeDefIndex: 77408
	{
		// Fields
		public readonly System.Type[] previousTypes; // 0x10
	
		// Constructors
		public fsMigrateVersionsAttribute(params System.Type[] previousTypes); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class fsSerializeAsReference : Attribute // TypeDefIndex: 77409
	{
		// Constructors
		public fsSerializeAsReference(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class fsDeserializeOverwrite : Attribute // TypeDefIndex: 77410
	{
		// Constructors
		public fsDeserializeOverwrite(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class fsUninitialized : Attribute // TypeDefIndex: 77411
	{
		// Constructors
		public fsUninitialized(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class fsAutoInstance : Attribute // TypeDefIndex: 77412
	{
		// Fields
		public readonly bool makeInstance; // 0x10
	
		// Constructors
		public fsAutoInstance(bool makeInstance = true /* Metadata: 0x02629EC7 */); // 0x0000000182A819C0-0x0000000182A819D0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 77413
	{
		// Fields
		public System.Type Converter; // 0x10
		public System.Type Processor; // 0x18
	
		// Constructors
		public fsObjectAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class fsBaseConverter // TypeDefIndex: 77415
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77414
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsDataType, string> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB4BBB0-0x000000018CB4BC14
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _FailExpectedType_b__6_0(fsDataType t); // 0x000000018CB4ACFC-0x000000018CB4AD4C
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType); // 0x00000001857C77D0-0x00000001857C7810
		public virtual bool RequestCycleSupport(System.Type storageType); // 0x000000018CB4C2A4-0x000000018CB4C334
		public virtual bool RequestInheritanceSupport(System.Type storageType); // 0x000000018CB4C334-0x000000018CB4C358
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types); // 0x000000018CB4BF58-0x000000018CB4C2A4
		protected fsResult CheckType(fsData data, fsDataType type); // 0x00000001857C55E0-0x00000001857C5700
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x000000018CB4BD40-0x000000018CB4BDB0
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x000000018CB4BDB0-0x000000018CB4BF58
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value);
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 77416
	{
		// Constructors
		protected fsConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public class fsCyclicReferenceManager // TypeDefIndex: 77418
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 77417
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x0000000186805BA0-0x0000000186805BB0
			static ObjectReferenceEqualityComparator(); // 0x00000001871E7C40-0x00000001871E7CA0
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x000000018A797384-0x000000018A79738C
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000187251670-0x0000000187251680
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x000000018699F370-0x000000018699F470
	
		// Methods
		public void Clear(); // 0x00000001852A2FF0-0x00000001852A3060
		public bool Enter(); // 0x00000001857C6E20-0x00000001857C6E30
		public bool Exit(); // 0x00000001852A2F90-0x00000001852A2FF0
		public object GetReferenceObject(int id); // 0x00000001865F6E20-0x00000001865F6E70
		public void AddReferenceWithId(int id, object reference); // 0x0000000186800220-0x0000000186800250
		public int GetReferenceId(object item); // 0x000000018CB4C358-0x000000018CB4C400
		public bool IsReference(object item); // 0x000000018CB4C400-0x000000018CB4C470
		public void MarkSerialized(object item); // 0x000000018CB4C470-0x000000018CB4C5A0
	}

	public enum fsDataType // TypeDefIndex: 77419
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 77420
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x00000001857C5700-0x00000001857C57C0 
		public bool IsNull { get; } // 0x00000001857C6E10-0x00000001857C6E20 
		public bool IsDouble { get; } // 0x0000000186734740-0x0000000186734760 
		public bool IsInt64 { get; } // 0x00000001865A7FF0-0x00000001865A8010 
		public bool IsBool { get; } // 0x000000018CB4CEA8-0x000000018CB4CEF4 
		public bool IsString { get; } // 0x00000001857C4BB0-0x00000001857C4BD0 
		public bool IsDictionary { get; } // 0x00000001857C6EF0-0x00000001857C6F40 
		public bool IsList { get; } // 0x000000018CB4CEF4-0x000000018CB4CF38 
		public double AsDouble { get; } // 0x000000018CB4CE9C-0x000000018CB4CEA8 
		public long AsInt64 { get; } // 0x000000018783C458-0x000000018783C464 
		public bool AsBool { get; } // 0x000000018CB4CE90-0x000000018CB4CE9C 
		public string AsString { get; } // 0x0000000187837B0C-0x0000000187837B18 
		public Dictionary<string, fsData> AsDictionary { get; } // 0x0000000187837B00-0x0000000187837B0C 
		public List<fsData> AsList { get; } // 0x0000000187837AF4-0x0000000187837B00 
	
		// Constructors
		public fsData(); // 0x00000001863017D0-0x00000001863017F0
		public fsData(bool boolean); // 0x00000001863017A0-0x00000001863017D0
		public fsData(double f); // 0x00000001857C4B70-0x00000001857C4BB0
		public fsData(long i); // 0x00000001857C3590-0x00000001857C35D0
		public fsData(string str); // 0x0000000184FD2410-0x0000000184FD2420
		public fsData(Dictionary<string, fsData> dict); // 0x0000000184FD2410-0x0000000184FD2420
		public fsData(List<fsData> list); // 0x0000000184FD2410-0x0000000184FD2420
		static fsData(); // 0x00000001863013D0-0x00000001863014E0
	
		// Methods
		public static fsData CreateDictionary(); // 0x000000018CB4C6B0-0x000000018CB4C7A4
		public static fsData CreateList(); // 0x000000018CB4C7A4-0x000000018CB4C83C
		public static fsData CreateList(int capacity); // 0x000000018CB4C83C-0x000000018CB4C8D8
		internal void BecomeDictionary(); // 0x000000018CB4C5A0-0x000000018CB4C644
		internal fsData Clone(); // 0x000000018CB4C644-0x000000018CB4C6B0
		private T Cast<T>();
		public override string ToString(); // 0x000000018CB4CE88-0x000000018CB4CE90
		public override bool Equals(object obj); // 0x000000018CB4C8D8-0x000000018CB4C93C
		public bool Equals(fsData other); // 0x000000018CB4C93C-0x000000018CB4CE88
		public static bool operator ==(fsData a, fsData b); // 0x000000018CB4CF38-0x000000018CB4D008
		public static bool operator !=(fsData a, fsData b); // 0x000000018CB4D008-0x000000018CB4D05C
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 77421
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 77422
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

	public static class fsGlobalConfig // TypeDefIndex: 77423
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
		static fsGlobalConfig(); // 0x0000000186E04820-0x0000000186E04A60
	}

	public class fsJsonParser // TypeDefIndex: 77424
	{
		// Fields
		private int _start; // 0x10
		private string _input; // 0x18
		private readonly StringBuilder _cachedStringBuilder; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x0000000185787150-0x0000000185787200
	
		// Methods
		private fsResult MakeFailure(string message); // 0x000000018CB4D05C-0x000000018CB4D1E8
		private bool TryMoveNext(); // 0x00000001851A8B20-0x00000001851A8B50
		private bool HasValue(); // 0x0000000187834F60-0x0000000187834F6C
		private bool HasValue(int offset); // 0x00000001851A9460-0x00000001851A94A0
		private char Character(); // 0x0000000187834F54-0x0000000187834F60
		private char Character(int offset); // 0x00000001851A94A0-0x00000001851A94E0
		private void SkipSpace(); // 0x00000001851A91D0-0x00000001851A9460
		private bool IsHex(char c); // 0x00000001861FA100-0x00000001861FA120
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x00000001861FA220-0x00000001861FA260
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x00000001861FA120-0x00000001861FA220
		private fsResult TryUnescapeChar(out char escaped); // 0x00000001861F9ED0-0x00000001861FA100
		private fsResult TryParseExact(string content); // 0x00000001863016D0-0x00000001863017A0
		private fsResult TryParseTrue(out fsData data); // 0x0000000186301600-0x00000001863016D0
		private fsResult TryParseFalse(out fsData data); // 0x00000001863014E0-0x0000000186301600
		private fsResult TryParseNull(out fsData data); // 0x000000018CB4D1E8-0x000000018CB4D2E8
		private bool IsSeparator(char c); // 0x00000001857C53B0-0x00000001857C5400
		private fsResult TryParseNumber(out fsData data); // 0x00000001857C50D0-0x00000001857C53B0
		private fsResult TryParseString(out string str); // 0x00000001851A8800-0x00000001851A8B20
		private fsResult TryParseArray(out fsData arr); // 0x00000001857C4950-0x00000001857C4B70
		private fsResult TryParseObject(out fsData obj); // 0x00000001857C5B70-0x00000001857C5FE0
		private fsResult RunParse(out fsData data); // 0x00000001857C5FE0-0x00000001857C6250
		public static fsResult Parse(string input, out fsData data); // 0x00000001852A3960-0x00000001852A3A30
		public static fsData Parse(string input); // 0x00000001852A3870-0x00000001852A3910
	}

	public static class fsJsonPrinter // TypeDefIndex: 77425
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x000000018CB4E590-0x000000018CB4E5FC
		private static string EscapeString(string str); // 0x000000018CB4E2E8-0x000000018CB4E590
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x000000018CB4D2E8-0x000000018CB4D8CC
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x000000018CB4D8CC-0x000000018CB4E038
		public static string ToJson(fsData data, bool pretty); // 0x000000018CB4E774-0x000000018CB4E798
		public static void PrettyJson(fsData data, TextWriter outputStream); // 0x000000018CB4E5FC-0x000000018CB4E608
		public static string PrettyJson(fsData data); // 0x000000018CB4E608-0x000000018CB4E774
		public static void CompressedJson(fsData data, StreamWriter outputStream); // 0x000000018CB4E1A4-0x000000018CB4E1AC
		public static string CompressedJson(fsData data); // 0x000000018CB4E038-0x000000018CB4E1A4
		private static string ConvertDoubleToString(double d); // 0x000000018CB4E1AC-0x000000018CB4E2E8
	}

	public class fsMetaProperty // TypeDefIndex: 77426
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
		public System.Reflection.FieldInfo Field { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string JsonName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public System.Type StorageType { get; } // 0x00000001857C6250-0x00000001857C6280 
		public string MemberName { get; } // 0x000000018CB4E798-0x000000018CB4E7BC 
		public bool ReadOnly { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public bool WriteOnly { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E090-0x000000018225E0A0 0x000000018225E0A0-0x000000018225E0B0
		public bool AutoInstance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EDE0-0x000000018226EDF0 0x000000018226EDF0-0x000000018226EE00
		public bool AsReference { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE40-0x000000018226EE50 0x000000018226EE50-0x000000018226EE60
	
		// Constructors
		internal fsMetaProperty(System.Reflection.FieldInfo field); // 0x00000001857C47C0-0x00000001857C4950
	
		// Methods
		public object Read(object context); // 0x000000018AF88464-0x000000018AF88488
		public void Write(object context, object value); // 0x00000001857C57F0-0x00000001857C5810
	}

	public class fsMetaType // TypeDefIndex: 77430
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
		public System.Type reflectedType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public fsMetaProperty[] Properties { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool DeserializeOverwriteRequest { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
	
		// Nested types
		private delegate object ObjectGenerator(); // TypeDefIndex: 77427; 0x0000000185B44B70-0x0000000185B44B80
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 77428
		{
			// Fields
			public System.Type reflectedType; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _GetGenerator_b__0(); // 0x000000018CB4B4D0-0x000000018CB4B568
			internal object _GetGenerator_b__1(); // 0x000000018CB4B568-0x000000018CB4B578
			internal object _GetGenerator_b__2(); // 0x000000018CB4B578-0x000000018CB4B5A8
			internal object _GetGenerator_b__4(); // 0x0000000186308880-0x00000001863088B0
			internal object _GetGenerator_b__5(); // 0x00000001857C5400-0x00000001857C5420
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77429
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ObjectGenerator __9__21_3; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB4BCDC-0x000000018CB4BD40
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _GetGenerator_b__21_3(); // 0x000000018CB4ADB8-0x000000018CB4ADF0
		}
	
		// Constructors
		private fsMetaType(System.Type reflectedType); // 0x00000001858C52F0-0x00000001858C5400
		static fsMetaType(); // 0x000000018699E720-0x000000018699E810
	
		// Methods
		public static fsMetaType Get(System.Type type); // 0x00000001857C54F0-0x00000001857C55E0
		public static void FlushMem(); // 0x000000018699E610-0x000000018699E720
		private static void CollectProperties(List<fsMetaProperty> properties, System.Type reflectedType); // 0x00000001857C39E0-0x00000001857C3BA0
		public static bool CanSerializeField(System.Reflection.FieldInfo field); // 0x00000001857C3C60-0x00000001857C3F30
		private static ObjectGenerator GetGenerator(System.Type reflectedType); // 0x00000001858C5400-0x00000001858C56D0
		private static bool HasDefaultConstructor(System.Type reflectedType); // 0x00000001858C5860-0x00000001858C5930
		public object GetDefaultInstance(); // 0x000000018CB4E7BC-0x000000018CB4E8B0
		public object CreateInstance(); // 0x00000001857C5470-0x00000001857C54F0
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 77431
	{
		// Constructors
		protected fsObjectProcessor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual bool CanProcess(System.Type type); // 0x000000018CB4E8B0-0x000000018CB4E8FC
		public virtual void OnBeforeSerialize(System.Type storageType, object instance); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAfterDeserialize(System.Type storageType, object instance); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct fsResult // TypeDefIndex: 77432
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x000000018526F920-0x000000018526F930 
		public bool Succeeded { get; } // 0x00000001844AD2A0-0x00000001844AD2B0 
		public bool HasWarnings { get; } // 0x00000001852A3A30-0x00000001852A3A70 
		public Exception AsException { get; } // 0x000000018CB4EC14-0x000000018CB4ED2C 
		public IEnumerable<string> RawMessages { get; } // 0x000000018CB4EE0C-0x000000018CB4EE64 
		public string FormattedMessages { get; } // 0x000000018CB4ED2C-0x000000018CB4EE0C 
	
		// Constructors
		static fsResult(); // 0x0000000187113860-0x0000000187113900
	
		// Methods
		public static fsResult Warn(string warning); // 0x000000018CB4EB64-0x000000018CB4EC14
		public static fsResult Fail(string warning); // 0x000000018CB4EA6C-0x000000018CB4EB18
		public void AddMessage(string message); // 0x000000018CB4E8FC-0x000000018CB4E9AC
		public void AddMessages(fsResult result); // 0x00000001857C57C0-0x00000001857C57F0
		private fsResult Merge(fsResult other); // 0x00000001857C6FB0-0x00000001857C7010
		public static fsResult operator +(fsResult a, fsResult b); // 0x00000001857C6F40-0x00000001857C6FB0
		public fsResult AssertSuccess(); // 0x00000001852A3910-0x00000001852A3960
		public fsResult AssertSuccessWithoutWarnings(); // 0x000000018CB4E9AC-0x000000018CB4EA6C
		public override string ToString(); // 0x000000018CB4EB18-0x000000018CB4EB64
	}

	public class fsSerializer // TypeDefIndex: 77435
	{
		// Fields
		public const string KEY_OBJECT_REFERENCE = "$ref"; // Metadata: 0x02629ECF
		public const string KEY_OBJECT_DEFINITION = "$id"; // Metadata: 0x02629ED4
		public const string KEY_INSTANCE_TYPE = "$type"; // Metadata: 0x02629ED8
		public const string KEY_VERSION = "$version"; // Metadata: 0x02629EDE
		public const string KEY_CONTENT = "$content"; // Metadata: 0x02629EE7
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
		public List<UnityEngine.Object> ReferencesDatabase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public bool IgnoreSerializeCycleReferences { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EF80-0x000000018226EF90 0x000000018226EF90-0x000000018226EFA0
	
		// Events
		public event Action<object> onBeforeObjectSerialized {
			add; // 0x000000018CB5016C-0x000000018CB501F8
			remove; // 0x000000018CB50284-0x000000018CB50310
		}
		public event Action<object, fsData> onAfterObjectSerialized {
			add; // 0x000000018CB500E0-0x000000018CB5016C
			remove; // 0x000000018CB501F8-0x000000018CB50284
		}
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 77433
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x000000018699F2B0-0x000000018699F370
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x000000018CB57508-0x000000018CB5763C
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x000000018CB5763C-0x000000018CB57804
			public void Clear(); // 0x00000001852A30D0-0x00000001852A3140
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77434
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__58_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB55398-0x000000018CB553FC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _TryDeserializeMigration_b__58_0(MethodInfo m); // 0x000000018CB55344-0x000000018CB55398
		}
	
		// Constructors
		public fsSerializer(); // 0x000000018699E810-0x000000018699EF60
	
		// Methods
		public static bool IsReservedKeyword(string key); // 0x00000001863EC300-0x00000001863F3D30
		public static void RemoveMetaData(ref fsData data); // 0x000000018CB4F45C-0x000000018CB4F5C8
		private static void EnsureDictionary(ref fsData data); // 0x000000018CB4EE64-0x000000018CB4EF0C
		private static bool IsObjectReference(fsData data); // 0x00000001857C6E30-0x00000001857C6EF0
		private static bool IsObjectDefinition(fsData data); // 0x00000001857C6280-0x00000001857C6340
		private static bool IsVersioned(fsData data); // 0x000000018CB4F3E0-0x000000018CB4F45C
		private static bool IsTypeSpecified(fsData data); // 0x00000001857C6340-0x00000001857C6400
		private static bool IsWrappedData(fsData data); // 0x00000001857C6400-0x00000001857C64C0
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018CB4F2F4-0x000000018CB4F3E0
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018CB4F288-0x000000018CB4F2F4
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data); // 0x00000001857C7330-0x00000001857C7390
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x00000001857C72D0-0x00000001857C7330
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x00000001857C7410-0x00000001857C74C0
		public void PurgeTemporaryData(); // 0x00000001852A3060-0x00000001852A30D0
		private List<fsObjectProcessor> GetProcessors(System.Type type); // 0x00000001857C7010-0x00000001857C7120
		public void AddConverter(fsBaseConverter converter); // 0x000000018699EF60-0x000000018699F0A0
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType); // 0x00000001857C7120-0x00000001857C72D0
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data); // 0x000000018CB4FDF4-0x000000018CB4FE30
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType); // 0x000000018CB4FE30-0x000000018CB500E0
		private fsResult Internal_Serialize(System.Type storageType, object instance, out fsData data, System.Type overrideConverterType); // 0x000000018CB4EF0C-0x000000018CB4F288
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result); // 0x0000000187837AB8-0x0000000187837AF4
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType); // 0x00000001857C64C0-0x00000001857C6650
		private fsResult Internal_Deserialize(fsData data, System.Type storageType, ref object result, System.Type overrideConverterType); // 0x00000001857C6650-0x00000001857C6E10
		private void TryPush(object o); // 0x00000001857C75A0-0x00000001857C77D0
		private void TryPop(object o); // 0x00000001857C74C0-0x00000001857C75A0
		private void TrySerializeVersioning(object currentInstance, ref fsData data); // 0x000000018CB4FC94-0x000000018CB4FDF4
		private void TryDeserializeVersioning(ref object currentInstance, ref fsData currentData); // 0x00000001857C7390-0x00000001857C7410
		private void TryDeserializeMigration(ref object currentInstance, ref fsData currentData, System.Type previousType, object previousInstance); // 0x000000018CB4F5C8-0x000000018CB4FC94
	}

	public interface IMigratable // TypeDefIndex: 77436
	{
	}

	public interface IMigratable<T> : IMigratable // TypeDefIndex: 77437
	{
		// Methods
		void Migrate(T model);
	}

	public interface ISerializationCollector : ISerializationCollectable // TypeDefIndex: 77438
	{
		// Methods
		void OnPush(ISerializationCollector parent);
		void OnCollect(ISerializationCollectable child, int depth);
		void OnPop(ISerializationCollector parent);
	}

	public interface ISerializationCollectable // TypeDefIndex: 77439
	{
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 77440
	{
		// Constructors
		public fsArrayConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000186BA99D0-0x0000000186BA99F0
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB56320-0x000000018CB56504
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018CB560B4-0x000000018CB56320
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB5605C-0x000000018CB560B4
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 77441
	{
		// Constructors
		public fsDictionaryConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000186A02480-0x0000000186A02520
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000186C1DA60-0x0000000186C1DAD0
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018CB56504-0x000000018CB56A74
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x00000001863EB350-0x00000001863EC300
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 77442
	{
		// Constructors
		public fsEnumConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000186B5F3F0-0x0000000186B5F410
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override object CreateInstance(fsData data, System.Type storageType); // 0x00000001868E7010-0x00000001868E7070
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB56A74-0x000000018CB56F34
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x00000001865A7EE0-0x00000001865A7FF0
		private static bool ArrayContains<T>(T[] values, T value);
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 77443
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x000000018CB574E4-0x000000018CB57508
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018CB56F34-0x000000018CB56F90
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x000000018CB56FE8-0x000000018CB571D0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB57370-0x000000018CB574E4
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018CB571D0-0x000000018CB57370
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB56F90-0x000000018CB56FE8
	}

	public class fsListConverter : fsConverter // TypeDefIndex: 77444
	{
		// Constructors
		public fsListConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000186A0A2B0-0x0000000186A0A350
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000186722BA0-0x0000000186722BF0
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018CB57804-0x000000018CB57A88
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x00000001857C4D70-0x00000001857C50D0
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 77445
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x00000001868B7310-0x00000001868B73F0
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		private static bool UseBool(System.Type type); // 0x00000001857C7C40-0x00000001857C7C90
		private static bool UseInt64(System.Type type); // 0x0000000186197C60-0x0000000186197F70
		private static bool UseDouble(System.Type type); // 0x00000001857C7D50-0x00000001857CC460
		private static bool UseString(System.Type type); // 0x000000018643DFA0-0x000000018643DFF0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB57A88-0x000000018CB5803C
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType); // 0x00000001857C7810-0x00000001857C7C40
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 77446
	{
		// Constructors
		public fsReflectedConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x0000000186997EF0-0x0000000186997FA0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB5803C-0x000000018CB58398
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x00000001857C5810-0x00000001857C5B70
		public override object CreateInstance(fsData data, System.Type storageType); // 0x00000001857C5420-0x00000001857C5470
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 77447
	{
		// Constructors
		public fsTypeConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x00000001869C9550-0x00000001869C95E0
		public override bool RequestCycleSupport(System.Type type); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type type); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018CB584E0-0x000000018CB5950C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018CB58398-0x000000018CB584E0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000187239520-0x0000000187239530
	}
}

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 77448
	{
		// Constructors
		public AnimationCurve_DirectConverter(); // 0x000000018699F0A0-0x000000018699F0D0
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized); // 0x000000018CB5078C-0x000000018CB50960
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model); // 0x000000018CB5054C-0x000000018CB5078C
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB504FC-0x000000018CB5054C
	}

	public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 77449
	{
		// Constructors
		public Bounds_DirectConverter(); // 0x000000018699F0D0-0x000000018699F100
	
		// Methods
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized); // 0x000000018CB50B58-0x000000018CB50CCC
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model); // 0x000000018CB509B4-0x000000018CB50B58
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB50960-0x000000018CB509B4
	}

	public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 77450
	{
		// Constructors
		public Gradient_DirectConverter(); // 0x000000018699F160-0x000000018699F190
	
		// Methods
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized); // 0x000000018CB53DDC-0x000000018CB53F68
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model); // 0x000000018CB53C04-0x000000018CB53DDC
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB53BB4-0x000000018CB53C04
	}

	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState> // TypeDefIndex: 77451
	{
		// Constructors
		public GUIStyleState_DirectConverter(); // 0x000000018699F100-0x000000018699F130
	
		// Methods
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized); // 0x000000018CB51FB8-0x000000018CB52154
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model); // 0x000000018CB51DD0-0x000000018CB51FB8
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB51D80-0x000000018CB51DD0
	}

	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 77452
	{
		// Constructors
		public GUIStyle_DirectConverter(); // 0x000000018699F130-0x000000018699F160
	
		// Methods
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized); // 0x000000018CB530F0-0x000000018CB53BB4
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model); // 0x000000018CB521A4-0x000000018CB530F0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB52154-0x000000018CB521A4
	}

	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 77453
	{
		// Constructors
		public Keyframe_DirectConverter(); // 0x000000018699F190-0x000000018699F1C0
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized); // 0x000000018CB5439C-0x000000018CB545F0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model); // 0x000000018CB54100-0x000000018CB5439C
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB540A8-0x000000018CB54100
	}

	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 77454
	{
		// Constructors
		public LayerMask_DirectConverter(); // 0x000000018699F1C0-0x000000018699F1F0
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized); // 0x000000018CB54734-0x000000018CB5481C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model); // 0x000000018CB54630-0x000000018CB54734
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB545F0-0x000000018CB54630
	}

	public class RectOffset_DirectConverter : fsDirectConverter<RectOffset> // TypeDefIndex: 77455
	{
		// Constructors
		public RectOffset_DirectConverter(); // 0x000000018699F1F0-0x000000018699F220
	
		// Methods
		protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized); // 0x000000018CB54C98-0x000000018CB54EA8
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model); // 0x000000018CB549FC-0x000000018CB54C98
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB549AC-0x000000018CB549FC
	}

	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 77456
	{
		// Constructors
		public Rect_DirectConverter(); // 0x000000018699F220-0x000000018699F250
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized); // 0x000000018CB55144-0x000000018CB55344
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model); // 0x000000018CB54EE8-0x000000018CB55144
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB54EA8-0x000000018CB54EE8
	}

	public class Vector2Int_DirectConverter : fsDirectConverter<Vector2Int> // TypeDefIndex: 77457
	{
		// Constructors
		public Vector2Int_DirectConverter(); // 0x000000018699F250-0x000000018699F280
	
		// Methods
		protected override fsResult DoSerialize(Vector2Int model, Dictionary<string, fsData> serialized); // 0x000000018CB55700-0x000000018CB557E4
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2Int model); // 0x000000018CB555FC-0x000000018CB55700
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB555BC-0x000000018CB555FC
	}

	public class Vector2_DirectConverter : fsDirectConverter<Vector2> // TypeDefIndex: 77458
	{
		// Constructors
		public Vector2_DirectConverter(); // 0x000000018CB55A28-0x000000018CB55A50
	
		// Methods
		protected override fsResult DoSerialize(Vector2 model, Dictionary<string, fsData> serialized); // 0x000000018CB55944-0x000000018CB55A28
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2 model); // 0x000000018CB55830-0x000000018CB55944
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB557E4-0x000000018CB55830
	}

	public class Vector3Int_DirectConverter : fsDirectConverter<Vector3Int> // TypeDefIndex: 77459
	{
		// Constructors
		public Vector3Int_DirectConverter(); // 0x000000018699F280-0x000000018699F2B0
	
		// Methods
		protected override fsResult DoSerialize(Vector3Int model, Dictionary<string, fsData> serialized); // 0x000000018CB55BD8-0x000000018CB55CE8
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector3Int model); // 0x000000018CB55AA0-0x000000018CB55BD8
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018CB55A50-0x000000018CB55AA0
	}
}

namespace ParadoxNotion.Services
{
	public class EventRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IDropHandler // TypeDefIndex: 77364
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
			add; // 0x000000018CB42964-0x000000018CB429F0
			remove; // 0x000000018CB442E8-0x000000018CB44374
		}
		public event EventDelegate<PointerEventData> onPointerExit {
			add; // 0x000000018CB429F0-0x000000018CB42A7C
			remove; // 0x000000018CB44374-0x000000018CB44400
		}
		public event EventDelegate<PointerEventData> onPointerDown {
			add; // 0x000000018CB428D8-0x000000018CB42964
			remove; // 0x000000018CB4425C-0x000000018CB442E8
		}
		public event EventDelegate<PointerEventData> onPointerUp {
			add; // 0x000000018CB42A7C-0x000000018CB42B08
			remove; // 0x000000018CB44400-0x000000018CB4448C
		}
		public event EventDelegate<PointerEventData> onPointerClick {
			add; // 0x000000018CB4284C-0x000000018CB428D8
			remove; // 0x000000018CB441D0-0x000000018CB4425C
		}
		public event EventDelegate<PointerEventData> onDrag {
			add; // 0x000000018CB42158-0x000000018CB421E4
			remove; // 0x000000018CB43ADC-0x000000018CB43B68
		}
		public event EventDelegate<PointerEventData> onDrop {
			add; // 0x000000018CB4227C-0x000000018CB42308
			remove; // 0x000000018CB43C00-0x000000018CB43C8C
		}
		public event EventDelegate<PointerEventData> onScroll {
			add; // 0x000000018CB42B98-0x000000018CB42C24
			remove; // 0x000000018CB4451C-0x000000018CB445A8
		}
		public event EventDelegate<BaseEventData> onUpdateSelected {
			add; // 0x000000018CB431D0-0x000000018CB4325C
			remove; // 0x000000018CB44B54-0x000000018CB44BE0
		}
		public event EventDelegate<BaseEventData> onSelect {
			add; // 0x000000018CB42C24-0x000000018CB42CB0
			remove; // 0x000000018CB445A8-0x000000018CB44634
		}
		public event EventDelegate<BaseEventData> onDeselect {
			add; // 0x000000018CB41F9C-0x000000018CB42028
			remove; // 0x000000018CB43920-0x000000018CB439AC
		}
		public event EventDelegate<AxisEventData> onMove {
			add; // 0x000000018CB42730-0x000000018CB427BC
			remove; // 0x000000018CB440B4-0x000000018CB44140
		}
		public event EventDelegate<BaseEventData> onSubmit {
			add; // 0x000000018CB42CB0-0x000000018CB42D40
			remove; // 0x000000018CB44634-0x000000018CB446C4
		}
		public event EventDelegate onMouseDown {
			add; // 0x000000018CB423A0-0x000000018CB42438
			remove; // 0x000000018CB43D24-0x000000018CB43DBC
		}
		public event EventDelegate onMouseDrag {
			add; // 0x000000018CB42438-0x000000018CB424D0
			remove; // 0x000000018CB43DBC-0x000000018CB43E54
		}
		public event EventDelegate onMouseEnter {
			add; // 0x000000018CB424D0-0x000000018CB42568
			remove; // 0x000000018CB43E54-0x000000018CB43EEC
		}
		public event EventDelegate onMouseExit {
			add; // 0x000000018CB42568-0x000000018CB42600
			remove; // 0x000000018CB43EEC-0x000000018CB43F84
		}
		public event EventDelegate onMouseOver {
			add; // 0x000000018CB42600-0x000000018CB42698
			remove; // 0x000000018CB43F84-0x000000018CB4401C
		}
		public event EventDelegate onMouseUp {
			add; // 0x000000018CB42698-0x000000018CB42730
			remove; // 0x000000018CB4401C-0x000000018CB440B4
		}
		public event EventDelegate onEnable {
			add; // 0x000000018CB42308-0x000000018CB423A0
			remove; // 0x000000018CB43C8C-0x000000018CB43D24
		}
		public event EventDelegate onDisable {
			add; // 0x000000018CB420C0-0x000000018CB42158
			remove; // 0x000000018CB43A44-0x000000018CB43ADC
		}
		public event EventDelegate onDestroy {
			add; // 0x000000018CB42028-0x000000018CB420C0
			remove; // 0x000000018CB439AC-0x000000018CB43A44
		}
		public event EventDelegate onTransformChildrenChanged {
			add; // 0x000000018CB42D40-0x000000018CB42DD8
			remove; // 0x000000018CB446C4-0x000000018CB4475C
		}
		public event EventDelegate onTransformParentChanged {
			add; // 0x000000018CB42DD8-0x000000018CB42E70
			remove; // 0x000000018CB4475C-0x000000018CB447F4
		}
		public event EventDelegate<int> onAnimatorIK {
			add; // 0x000000018CB418A4-0x000000018CB41934
			remove; // 0x000000018CB4325C-0x000000018CB432EC
		}
		public event EventDelegate onAnimatorMove {
			add; // 0x000000018CB41934-0x000000018CB419E4
			remove; // 0x000000018CB432EC-0x000000018CB43368
		}
		public event EventDelegate onBecameInvisible {
			add; // 0x000000018CB419E4-0x000000018CB41A7C
			remove; // 0x000000018CB43368-0x000000018CB43400
		}
		public event EventDelegate onBecameVisible {
			add; // 0x000000018CB41A7C-0x000000018CB41B14
			remove; // 0x000000018CB43400-0x000000018CB43498
		}
		public event EventDelegate<ControllerColliderHit> onControllerColliderHit {
			add; // 0x000000018CB41E74-0x000000018CB41F04
			remove; // 0x000000018CB437F8-0x000000018CB43888
		}
		public event EventDelegate<GameObject> onParticleCollision {
			add; // 0x000000018CB427BC-0x000000018CB4284C
			remove; // 0x000000018CB44140-0x000000018CB441D0
		}
		public event EventDelegate<UnityEngine.Collision> onCollisionEnter {
			add; // 0x000000018CB41BA4-0x000000018CB41C34
			remove; // 0x000000018CB43528-0x000000018CB435B8
		}
		public event EventDelegate<UnityEngine.Collision> onCollisionExit {
			add; // 0x000000018CB41CC4-0x000000018CB41D54
			remove; // 0x000000018CB43648-0x000000018CB436D8
		}
		public event EventDelegate<UnityEngine.Collision> onCollisionStay {
			add; // 0x000000018CB41DE4-0x000000018CB41E74
			remove; // 0x000000018CB43768-0x000000018CB437F8
		}
		public event EventDelegate<Collision2D> onCollisionEnter2D {
			add; // 0x000000018CB41B14-0x000000018CB41BA4
			remove; // 0x000000018CB43498-0x000000018CB43528
		}
		public event EventDelegate<Collision2D> onCollisionExit2D {
			add; // 0x000000018CB41C34-0x000000018CB41CC4
			remove; // 0x000000018CB435B8-0x000000018CB43648
		}
		public event EventDelegate<Collision2D> onCollisionStay2D {
			add; // 0x000000018CB41D54-0x000000018CB41DE4
			remove; // 0x000000018CB436D8-0x000000018CB43768
		}
		public event EventDelegate<Collider> onTriggerEnter {
			add; // 0x000000018CB42F00-0x000000018CB42F90
			remove; // 0x000000018CB44884-0x000000018CB44914
		}
		public event EventDelegate<Collider> onTriggerExit {
			add; // 0x000000018CB43020-0x000000018CB430B0
			remove; // 0x000000018CB449A4-0x000000018CB44A34
		}
		public event EventDelegate<Collider> onTriggerStay {
			add; // 0x000000018CB43140-0x000000018CB431D0
			remove; // 0x000000018CB44AC4-0x000000018CB44B54
		}
		public event EventDelegate<Collider2D> onTriggerEnter2D {
			add; // 0x000000018CB42E70-0x000000018CB42F00
			remove; // 0x000000018CB447F4-0x000000018CB44884
		}
		public event EventDelegate<Collider2D> onTriggerExit2D {
			add; // 0x000000018CB42F90-0x000000018CB43020
			remove; // 0x000000018CB44914-0x000000018CB449A4
		}
		public event EventDelegate<Collider2D> onTriggerStay2D {
			add; // 0x000000018CB430B0-0x000000018CB43140
			remove; // 0x000000018CB44A34-0x000000018CB44AC4
		}
		public event Action<RenderTexture, RenderTexture> onRenderImage {
			add; // 0x000000018CB42B08-0x000000018CB42B98
			remove; // 0x000000018CB4448C-0x000000018CB4451C
		}
		public event EventDelegate onDrawGizmos {
			add; // 0x000000018CB421E4-0x000000018CB4227C
			remove; // 0x000000018CB43B68-0x000000018CB43C00
		}
		public event CustomEventDelegate onCustomEvent {
			add; // 0x000000018CB41F04-0x000000018CB41F9C
			remove; // 0x000000018CB43888-0x000000018CB43920
		}
	
		// Nested types
		public delegate void EventDelegate(ParadoxNotion.EventData msg); // TypeDefIndex: 77361; 0x00000001852BC110-0x00000001852BC140
	
		public delegate void EventDelegate<T>(EventData<T> msg); // TypeDefIndex: 77362; 0x00000000-0x00000000
	
		public delegate void CustomEventDelegate(string name, ParadoxNotion.IEventData data); // TypeDefIndex: 77363; 0x00000001859B7730-0x00000001859B7740
	
		// Constructors
		public EventRouter(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x000000018CB413B0-0x000000018CB41464
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x000000018CB41464-0x000000018CB41518
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018CB412FC-0x000000018CB413B0
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018CB41518-0x000000018CB415CC
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x000000018CB41248-0x000000018CB412FC
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018CB41028-0x000000018CB410DC
		void IDropHandler.OnDrop(PointerEventData eventData); // 0x000000018CB410DC-0x000000018CB41190
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x000000018CB415CC-0x000000018CB41680
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData); // 0x000000018CB417F0-0x000000018CB418A4
		void ISelectHandler.OnSelect(BaseEventData eventData); // 0x000000018CB41680-0x000000018CB41734
		void IDeselectHandler.OnDeselect(BaseEventData eventData); // 0x000000018CB40F74-0x000000018CB41028
		void IMoveHandler.OnMove(AxisEventData eventData); // 0x000000018CB41190-0x000000018CB41248
		void ISubmitHandler.OnSubmit(BaseEventData eventData); // 0x000000018CB41734-0x000000018CB417F0
		private void OnMouseDown(); // 0x000000018CB40630-0x000000018CB406B0
		private void OnMouseDrag(); // 0x000000018CB406B0-0x000000018CB40730
		private void OnMouseEnter(); // 0x000000018CB40730-0x000000018CB407B0
		private void OnMouseExit(); // 0x000000018CB407B0-0x000000018CB40830
		private void OnMouseOver(); // 0x000000018CB40830-0x000000018CB408B0
		private void OnMouseUp(); // 0x000000018CB408B0-0x000000018CB40930
		private void OnEnable(); // 0x000000018CB405B0-0x000000018CB40630
		private void OnDisable(); // 0x000000018CB404B0-0x000000018CB40530
		private void OnDestroy(); // 0x000000018CB40430-0x000000018CB404B0
		private void OnTransformChildrenChanged(); // 0x000000018CB40A0C-0x000000018CB40A8C
		private void OnTransformParentChanged(); // 0x000000018CB40A8C-0x000000018CB40B0C
		private void OnAnimatorIK(int layerIndex); // 0x000000018CB3FD4C-0x000000018CB3FE08
		private void OnBecameInvisible(); // 0x000000018CB3FE08-0x000000018CB3FE88
		private void OnBecameVisible(); // 0x000000018CB3FE88-0x000000018CB3FF08
		private void OnControllerColliderHit(ControllerColliderHit hit); // 0x000000018CB40370-0x000000018CB40430
		private void OnParticleCollision(GameObject other); // 0x000000018CB40930-0x000000018CB409F0
		private void OnCollisionEnter(UnityEngine.Collision collisionInfo); // 0x000000018CB3FFC4-0x000000018CB40080
		private void OnCollisionExit(UnityEngine.Collision collisionInfo); // 0x000000018CB4013C-0x000000018CB401F8
		private void OnCollisionStay(UnityEngine.Collision collisionInfo); // 0x000000018CB402B4-0x000000018CB40370
		private void OnCollisionEnter2D(Collision2D collisionInfo); // 0x000000018CB3FF08-0x000000018CB3FFC4
		private void OnCollisionExit2D(Collision2D collisionInfo); // 0x000000018CB40080-0x000000018CB4013C
		private void OnCollisionStay2D(Collision2D collisionInfo); // 0x000000018CB401F8-0x000000018CB402B4
		private void OnTriggerEnter(Collider other); // 0x000000018CB40BC8-0x000000018CB40C84
		private void OnTriggerExit(Collider other); // 0x000000018CB40D40-0x000000018CB40DFC
		private void OnTriggerStay(Collider other); // 0x000000018CB40EB8-0x000000018CB40F74
		private void OnTriggerEnter2D(Collider2D other); // 0x000000018CB40B0C-0x000000018CB40BC8
		private void OnTriggerExit2D(Collider2D other); // 0x000000018CB40C84-0x000000018CB40D40
		private void OnTriggerStay2D(Collider2D other); // 0x000000018CB40DFC-0x000000018CB40EB8
		private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x000000018CB409F0-0x000000018CB40A0C
		private void OnDrawGizmos(); // 0x000000018CB40530-0x000000018CB405B0
		public void InvokeCustomEvent(string name, object value, object sender); // 0x000000018CB3FC68-0x000000018CB3FD4C
		public void InvokeCustomEvent<T>(string name, T value, object sender);
	}

	public class EventRouterAnimatorMove : MonoBehaviour // TypeDefIndex: 77365
	{
		// Fields
		[CompilerGenerated]
		private EventRouter.EventDelegate onAnimatorMove; // 0x18
	
		// Events
		public event EventRouter.EventDelegate onAnimatorMove {
			add; // 0x000000018CB3FB40-0x000000018CB3FBD4
			remove; // 0x000000018CB3FBD4-0x000000018CB3FC68
		}
	
		// Constructors
		public EventRouterAnimatorMove(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnAnimatorMove(); // 0x000000018CB3FAC4-0x000000018CB3FB40
	}

	public static class Logger // TypeDefIndex: 77368
	{
		// Fields
		private static List<LogHandler> subscribers; // 0x00
	
		// Nested types
		public struct Message // TypeDefIndex: 77366
		{
			// Fields
			private WeakReference<object> _contextRef; // 0x00
			public UnityEngine.LogType type; // 0x08
			public string text; // 0x10
			public string tag; // 0x18
	
			// Properties
			public object context { get; set; } // 0x000000018CB46994-0x000000018CB469F0 0x000000018CB469F0-0x000000018CB46A74
	
			// Methods
			public bool IsValid(); // 0x000000018CB30D1C-0x000000018CB30D34
		}
	
		public delegate bool LogHandler(Message message); // TypeDefIndex: 77367; 0x000000018634EC90-0x000000018634ECC0
	
		// Constructors
		static Logger(); // 0x000000018CB46908-0x000000018CB46994
	
		// Methods
		public static void AddListener(LogHandler callback); // 0x000000018CB45F28-0x000000018CB45F98
		public static void RemoveListener(LogHandler callback); // 0x000000018CB46898-0x000000018CB46908
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void Log(object message, string tag = null, object context = null); // 0x000000018CB4682C-0x000000018CB46898
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(object message, string tag = null, object context = null); // 0x000000018CB467C0-0x000000018CB4682C
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogError(object message, string tag = null, object context = null); // 0x000000018CB466E8-0x000000018CB46754
		public static void LogException(Exception exception, string tag = null, object context = null); // 0x000000018CB46754-0x000000018CB467C0
		private static void Internal_Log(UnityEngine.LogType type, object message, string tag, object context); // 0x000000018CB460C4-0x000000018CB466E8
		private static void ForwardToUnity(UnityEngine.LogType type, object message, string tag, object context); // 0x000000018CB45F98-0x000000018CB460C4
	}

	public class MonoManager : MonoBehaviour // TypeDefIndex: 77370
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
		public static MonoManager current { get; } // 0x0000000186DBA290-0x0000000186DBA4D0 
	
		// Events
		public event Action onUpdate {
			add; // 0x000000018CB46E48-0x000000018CB46EDC
			remove; // 0x0000000185BC0DE0-0x0000000185BC0E80
		}
		public event Action onLateUpdate {
			add; // 0x000000018CB46DB4-0x000000018CB46E48
			remove; // 0x000000018CB47124-0x000000018CB471B8
		}
		public event Action onFixedUpdate {
			add; // 0x000000018CB46C8C-0x000000018CB46D20
			remove; // 0x000000018CB46FFC-0x000000018CB47090
		}
		public event Action onApplicationQuit {
			add; // 0x000000018CB46BF8-0x000000018CB46C8C
			remove; // 0x000000018CB46F68-0x000000018CB46FFC
		}
		public event Action<bool> onApplicationPause {
			add; // 0x000000018CB46B6C-0x000000018CB46BF8
			remove; // 0x000000018CB46EDC-0x000000018CB46F68
		}
		public event Action onGUI {
			add; // 0x000000018CB46D20-0x000000018CB46DB4
			remove; // 0x000000018CB47090-0x000000018CB47124
		}
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 77369
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}
	
		// Constructors
		public MonoManager(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Purge(); // 0x00000001872200B0-0x00000001872200F0
		public static void Create(); // 0x000000018CB46AB8-0x000000018CB46B0C
		public void AddUpdateCall(UpdateMode mode, Action call); // 0x000000018CB46A74-0x000000018CB46AB8
		public void RemoveUpdateCall(UpdateMode mode, Action call); // 0x0000000185BC0A80-0x0000000185BC0AB0
		protected void Awake(); // 0x00000001870D6120-0x00000001870D6230
		protected void OnApplicationQuit(); // 0x000000018CB46B20-0x000000018CB46B6C
		protected void OnApplicationPause(bool isPause); // 0x000000018CB46B0C-0x000000018CB46B20
		protected void Update(); // 0x00000001865B6CB0-0x00000001865B6CD0
		protected void LateUpdate(); // 0x00000001865B6C90-0x00000001865B6CB0
		protected void FixedUpdate(); // 0x0000000186493330-0x0000000186493350
	}

	public static class Threader // TypeDefIndex: 77380
	{
		// Fields
		[CompilerGenerated]
		private static bool _applicationIsPlaying_k__BackingField; // 0x00
	
		// Properties
		public static bool applicationIsPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CB4A9C0-0x000000018CB4AA10 0x000000018CB4AA3C-0x000000018CB4AA90
		public static bool isMainThread { get; } // 0x000000018CB4AA10-0x000000018CB4AA3C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 77371
		{
			// Fields
			public Action function; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _StartAction_b__0(); // 0x00000001890ADBF0-0x00000001890ADC0C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0<T1> // TypeDefIndex: 77372
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
		private sealed class __c__DisplayClass10_0<T1, T2> // TypeDefIndex: 77373
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
		private sealed class __c__DisplayClass11_0<T1, T2, T3> // TypeDefIndex: 77374
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
		private sealed class __c__DisplayClass12_0<TResult> // TypeDefIndex: 77375
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
		private sealed class __c__DisplayClass13_0<TResult, T1> // TypeDefIndex: 77376
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
		private sealed class __c__DisplayClass14_0<TResult, T1, T2> // TypeDefIndex: 77377
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
		private sealed class __c__DisplayClass15_0<TResult, T1, T2, T3> // TypeDefIndex: 77378
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
		private sealed class _ThreadMonitor_d__17 : IEnumerator<object> // TypeDefIndex: 77379
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Thread thread; // 0x20
			public Action callback; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _ThreadMonitor_d__17(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CB4ABF8-0x000000018CB4ACB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB4ACB0-0x000000018CB4ACFC
		}
	
		// Constructors
		static Threader(); // 0x00000001871F5EC0-0x00000001871F5F30
	
		// Methods
		public static void ManuallySyncIsPlaying(); // 0x000000018CB4A7C4-0x000000018CB4A814
		public static Thread StartAction(Thread thread, Action function, Action callback = null); // 0x000000018CB4A814-0x000000018CB4A948
		public static Thread StartAction<T1>(Thread thread, Action<T1> function, T1 parameter1, Action callback = null);
		public static Thread StartAction<T1, T2>(Thread thread, Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null);
		public static Thread StartAction<T1, T2, T3>(Thread thread, Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null);
		public static Thread StartFunction<TResult>(Thread thread, Func<TResult> function, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1>(Thread thread, Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2>(Thread thread, Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null);
		public static Thread StartFunction<TResult, T1, T2, T3>(Thread thread, Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null);
		private static void Begin(Thread thread, Action callback); // 0x000000018CB4A738-0x000000018CB4A7C4
		[IteratorStateMachine(typeof(_ThreadMonitor_d__17))]
		private static IEnumerator ThreadMonitor(Thread thread, Action callback); // 0x000000018CB4A948-0x000000018CB4A9C0
	}
}
