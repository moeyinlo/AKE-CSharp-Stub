/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

// Image 87: Unity.VisualScripting.Flow.dll - Assembly: Unity.VisualScripting.Flow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62759-62812
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Tests")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Tests.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.Flow.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.State.Editor")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.State")]
[assembly: InternalsVisibleTo("Unity.VisualScripting.SettingsProvider.Editor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Unity.VisualScripting
{
	public sealed class ControlConnection : UnitConnection<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.ControlInput>, IUnitConnection // TypeDefIndex: 62760
	{
		// Properties
		public override ControlOutput source { get; } // 0x000000018B383588-0x000000018B3835F0 
		public override ControlInput destination { get; } // 0x000000018B3834AC-0x000000018B383514 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get; } // 0x000000018B38336C-0x000000018B383374 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get; } // 0x000000018B383364-0x000000018B38336C 
		public override bool sourceExists { get; } // 0x000000018B383514-0x000000018B383588 
		public override bool destinationExists { get; } // 0x000000018B383438-0x000000018B3834AC 
	
		// Constructors
		public ControlConnection(ControlOutput source, ControlInput destination); // 0x000000018B383374-0x000000018B383438
	}

	public sealed class InvalidConnection : UnitConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IUnitConnection // TypeDefIndex: 62761
	{
		// Properties
		public override IUnitOutputPort source { get; } // 0x000000018B385F68-0x000000018B38601C 
		public override IUnitInputPort destination { get; } // 0x000000018B385E00-0x000000018B385EB4 
		public IUnitOutputPort validSource { get; } // 0x000000018B386238-0x000000018B3862EC 
		public IUnitInputPort validDestination { get; } // 0x000000018B3860D0-0x000000018B386184 
		public override bool sourceExists { get; } // 0x000000018B385EB4-0x000000018B385F68 
		public override bool destinationExists { get; } // 0x000000018B385D4C-0x000000018B385E00 
		public bool validSourceExists { get; } // 0x000000018B386184-0x000000018B386238 
		public bool validDestinationExists { get; } // 0x000000018B38601C-0x000000018B3860D0 
	
		// Constructors
		public InvalidConnection(IUnitOutputPort source, IUnitInputPort destination); // 0x000000018B385CF4-0x000000018B385D4C
	
		// Methods
		public override bool HandleDependencies(); // 0x000000018B385858-0x000000018B385A34
		[CompilerGenerated]
		private bool _get_source_b__4_0(IUnitOutputPort p); // 0x000000018B385B3C-0x000000018B385B94
		[CompilerGenerated]
		private bool _get_destination_b__6_0(IUnitInputPort p); // 0x000000018B385A8C-0x000000018B385AE4
		[CompilerGenerated]
		private bool _get_validSource_b__8_0(IUnitOutputPort p); // 0x000000018B385C9C-0x000000018B385CF4
		[CompilerGenerated]
		private bool _get_validDestination_b__10_0(IUnitInputPort p); // 0x000000018B385BEC-0x000000018B385C44
		[CompilerGenerated]
		private bool _get_sourceExists_b__12_0(IUnitOutputPort p); // 0x000000018B385AE4-0x000000018B385B3C
		[CompilerGenerated]
		private bool _get_destinationExists_b__14_0(IUnitInputPort p); // 0x000000018B385A34-0x000000018B385A8C
		[CompilerGenerated]
		private bool _get_validSourceExists_b__16_0(IUnitOutputPort p); // 0x000000018B385C44-0x000000018B385C9C
		[CompilerGenerated]
		private bool _get_validDestinationExists_b__18_0(IUnitInputPort p); // 0x000000018B385B94-0x000000018B385BEC
	}

	public interface IUnitConnection : IConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IGraphElementWithDebugData // TypeDefIndex: 62762
	{
	}

	public interface IUnitConnectionDebugData : IGraphElementDebugData // TypeDefIndex: 62763
	{
		// Properties
		int lastInvokeFrame { set; }
		float lastInvokeTime { set; }
	}

	public interface IUnitRelation : IConnection<Unity.VisualScripting.IUnitPort, Unity.VisualScripting.IUnitPort> // TypeDefIndex: 62764
	{
	}

	public abstract class UnitConnection<TSourcePort, TDestinationPort> : GraphElement<Unity.VisualScripting.FlowGraph>, IConnection<TSourcePort, TDestinationPort> // TypeDefIndex: 62765
		where TSourcePort : class, IUnitOutputPort
		where TDestinationPort : class, IUnitInputPort
	{
		// Fields
		[CompilerGenerated]
		private IUnit _sourceUnit_k__BackingField;
		[CompilerGenerated]
		private string _sourceKey_k__BackingField;
		[CompilerGenerated]
		private IUnit _destinationUnit_k__BackingField;
		[CompilerGenerated]
		private string _destinationKey_k__BackingField;
	
		// Properties
		[Serialize]
		protected IUnit sourceUnit { [CompilerGenerated] get; [CompilerGenerated] private set; }
		[Serialize]
		protected string sourceKey { [CompilerGenerated] get; [CompilerGenerated] private set; }
		[Serialize]
		protected IUnit destinationUnit { [CompilerGenerated] get; [CompilerGenerated] private set; }
		[Serialize]
		protected string destinationKey { [CompilerGenerated] get; [CompilerGenerated] private set; }
		[DoNotSerialize]
		public abstract TSourcePort source { get; }
		[DoNotSerialize]
		public abstract TDestinationPort destination { get; }
		public override int dependencyOrder { get; }
		public abstract bool sourceExists { get; }
		public abstract bool destinationExists { get; }
	
		// Constructors
		protected UnitConnection(TSourcePort source, TDestinationPort destination);
	
		// Methods
		public override bool HandleDependencies();
	}

	public class UnitConnectionDebugData : IUnitConnectionDebugData // TypeDefIndex: 62766
	{
		// Fields
		[CompilerGenerated]
		private int _lastInvokeFrame_k__BackingField; // 0x10
		[CompilerGenerated]
		private float _lastInvokeTime_k__BackingField; // 0x14
		[CompilerGenerated]
		private Exception _runtimeException_k__BackingField; // 0x18
	
		// Properties
		public int lastInvokeFrame { [CompilerGenerated] set; } // 0x00000001814F51F0-0x00000001814F5220
		public float lastInvokeTime { [CompilerGenerated] set; } // 0x0000000184D88D50-0x0000000184D88D60
		public Exception runtimeException { [CompilerGenerated] set; } // 0x0000000185392C40-0x0000000185392C50
	}

	public sealed class ValueConnection : UnitConnection<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.ValueInput>, IUnitConnection // TypeDefIndex: 62768
	{
		// Properties
		public override ValueOutput source { get; } // 0x000000018B388308-0x000000018B388370 
		public override ValueInput destination { get; } // 0x000000018B38822C-0x000000018B388294 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get; } // 0x000000018B38336C-0x000000018B383374 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get; } // 0x000000018B383364-0x000000018B38336C 
		public override bool sourceExists { get; } // 0x000000018B388294-0x000000018B388308 
		public override bool destinationExists { get; } // 0x000000018B3881B8-0x000000018B38822C 
	
		// Nested types
		public class DebugData : UnitConnectionDebugData // TypeDefIndex: 62767
		{
			// Fields
			[CompilerGenerated]
			private object _lastValue_k__BackingField; // 0x20
			[CompilerGenerated]
			private bool _assignedLastValue_k__BackingField; // 0x28
	
			// Properties
			public object lastValue { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
			public bool assignedLastValue { [CompilerGenerated] set; } // 0x00000001811F33D0-0x00000001811F33E0
		}
	
		// Constructors
		public ValueConnection(ValueOutput source, ValueInput destination); // 0x000000018B388034-0x000000018B3881B8
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class PortLabelHiddenAttribute : Attribute // TypeDefIndex: 62769
	{
		// Constructors
		public PortLabelHiddenAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public sealed class SpecialUnitAttribute : Attribute // TypeDefIndex: 62770
	{
		// Constructors
		public SpecialUnitAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class UnitHeaderInspectableAttribute : Attribute // TypeDefIndex: 62771
	{
		// Constructors
		public UnitHeaderInspectableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitShortTitleAttribute : Attribute // TypeDefIndex: 62772
	{
		// Fields
		[CompilerGenerated]
		private string _title_k__BackingField; // 0x10
	
		// Properties
		private string title { [CompilerGenerated] set; } // 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public UnitShortTitleAttribute(string title); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitTitleAttribute : Attribute // TypeDefIndex: 62773
	{
		// Fields
		[CompilerGenerated]
		private string _title_k__BackingField; // 0x10
	
		// Properties
		private string title { [CompilerGenerated] set; } // 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public UnitTitleAttribute(string title); // 0x00000001853908C0-0x00000001853908D0
	}

	public sealed class Flow : IPoolable, IDisposable // TypeDefIndex: 62776
	{
		// Fields
		[CompilerGenerated]
		private GraphStack _stack_k__BackingField; // 0x10
		private Recursion<RecursionNode> recursion; // 0x18
		private readonly Dictionary<IUnitValuePort, object> locals; // 0x20
		public readonly VariableDeclarations variables; // 0x28
		private readonly Stack<int> loops; // 0x30
		private readonly HashSet<GraphStack> preservedStacks; // 0x38
		[CompilerGenerated]
		private MonoBehaviour _coroutineRunner_k__BackingField; // 0x40
		private ICollection<Flow> activeCoroutinesRegistry; // 0x48
		private bool coroutineStopRequested; // 0x50
		[CompilerGenerated]
		private bool _isCoroutine_k__BackingField; // 0x51
		private IEnumerator coroutineEnumerator; // 0x58
		[CompilerGenerated]
		private bool _isPrediction_k__BackingField; // 0x60
		private bool disposed; // 0x61
		public int loopIdentifier; // 0x64
	
		// Properties
		public GraphStack stack { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		private MonoBehaviour coroutineRunner { [CompilerGenerated] set; } // 0x00000001842B4AE0-0x00000001842B4AF0
		private bool isCoroutine { [CompilerGenerated] set; } // 0x0000000184D86830-0x0000000184D86840
		public bool isPrediction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000184D88350-0x0000000184D88360
		public bool enableDebug { get; } // 0x000000018B385828-0x000000018B385858 
	
		// Nested types
		private struct RecursionNode : IEquatable<RecursionNode> // TypeDefIndex: 62774
		{
			// Fields
			[CompilerGenerated]
			private readonly IUnitPort _port_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly IGraphParent _context_k__BackingField; // 0x08
	
			// Properties
			public IUnitPort port { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000182B76770-0x0000000182B76780 
			public IGraphParent context { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000184D88320-0x0000000184D88330 
	
			// Constructors
			public RecursionNode(IUnitPort port, GraphPointer pointer); // 0x000000018B386CF8-0x000000018B386D34
	
			// Methods
			public bool Equals(RecursionNode other); // 0x000000018B386CA0-0x000000018B386CB8
			public override bool Equals(object obj); // 0x000000018B386C30-0x000000018B386CA0
			public override int GetHashCode(); // 0x000000018B386CB8-0x000000018B386CF8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62775
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Flow> __9__35_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B386F0C-0x000000018B386F70
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Flow _New_b__35_0(); // 0x000000018B386D34-0x000000018B386D84
		}
	
		// Constructors
		private Flow(); // 0x000000018B3856DC-0x000000018B385828
	
		// Methods
		public static Flow New(GraphReference reference); // 0x000000018B385090-0x000000018B385230
		void IPoolable.New(); // 0x000000018B385694-0x000000018B3856DC
		public void Dispose(); // 0x000000018B38452C-0x000000018B3845E4
		void IPoolable.Free(); // 0x000000018B3852F0-0x000000018B385694
		public void Invoke(ControlOutput output); // 0x000000018B384E94-0x000000018B385090
		private RecursionNode BeforeInvoke(ControlOutput output, RecursionNode recursionNode); // 0x000000018B3842DC-0x000000018B38452C
		private void AfterInvoke(ControlOutput output, RecursionNode recursionNode); // 0x000000018B384288-0x000000018B3842DC
		private ControlOutput InvokeDelegate(ControlInput input); // 0x000000018B384D24-0x000000018B384E94
		public object GetValue(ValueInput input); // 0x000000018B384AB8-0x000000018B384CB4
		private object GetValue(ValueOutput output); // 0x000000018B3846C8-0x000000018B384AB8
		public object GetValue(ValueInput input, System.Type type); // 0x000000018B384CB4-0x000000018B384D24
		public T GetValue<T>(ValueInput input);
		public bool TryGetDefaultValue(ValueInput input, out object defaultValue); // 0x000000018B385230-0x000000018B3852F0
		private object GetValueDelegate(ValueOutput output); // 0x000000018B3845E4-0x000000018B3846C8
	}

	[System.ComponentModel.DisplayName("Script Graph")]
	[SerializationVersion("A", new System.Type[0])]
	public sealed class FlowGraph : Graph, IGraph // TypeDefIndex: 62777
	{
		// Fields
		[CompilerGenerated]
		private GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> _controlConnections_k__BackingField; // 0x20
		[CompilerGenerated]
		private GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> _valueConnections_k__BackingField; // 0x28
		[CompilerGenerated]
		private GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> _invalidConnections_k__BackingField; // 0x30
	
		// Properties
		[DoNotSerialize]
		public GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> controlConnections { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DoNotSerialize]
		public GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> valueConnections { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		[DoNotSerialize]
		public GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> invalidConnections { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
	}

	[SerializationVersion("A", new System.Type[0])]
	[SpecialUnit]
	public abstract class EventUnit<TArgs> : Unit, IUnit // TypeDefIndex: 62778
	{
		// Fields
		[CompilerGenerated]
		private ControlOutput _trigger_k__BackingField;
	
		// Properties
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlOutput trigger { [CompilerGenerated] get; [CompilerGenerated] private set; }
		new FlowGraph IUnit.graph { get; }
	
		// Constructors
		protected EventUnit();
	
		// Methods
		protected override void Definition();
	}

	public abstract class ManualEventUnit<TArgs> : EventUnit<TArgs> // TypeDefIndex: 62779
	{
		// Properties
		protected abstract string hookName { get; }
	
		// Constructors
		protected ManualEventUnit();
	}

	[SpecialUnit]
	[UnitShortTitle("Missing Script!")]
	[UnitTitle("Node script is missing!")]
	public sealed class MissingType : Unit // TypeDefIndex: 62780
	{
		// Methods
		protected override void Definition(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface IUnit : IGraphElementWithDebugData // TypeDefIndex: 62781
	{
		// Properties
		FlowGraph graph { get; }
		Dictionary<string, object> defaultValues { get; }
		IUnitPortCollection<ControlInput> controlInputs { get; }
		IUnitPortCollection<ControlOutput> controlOutputs { get; }
		IUnitPortCollection<ValueInput> valueInputs { get; }
		IUnitPortCollection<ValueOutput> valueOutputs { get; }
		IUnitPortCollection<InvalidInput> invalidInputs { get; }
		IUnitPortCollection<InvalidOutput> invalidOutputs { get; }
		IEnumerable<IUnitInputPort> inputs { get; }
		IEnumerable<IUnitOutputPort> outputs { get; }
		IEnumerable<IUnitInputPort> validInputs { get; }
		IEnumerable<IUnitOutputPort> validOutputs { get; }
	
		// Methods
		void PortsChanged();
	}

	public interface IUnitDebugData : IGraphElementDebugData // TypeDefIndex: 62782
	{
		// Properties
		int lastInvokeFrame { set; }
		float lastInvokeTime { set; }
	}

	public sealed class ControlInput : UnitPort<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ControlConnection>, IUnitInputPort // TypeDefIndex: 62785
	{
		// Fields
		internal readonly Func<Flow, ControlOutput> action; // 0x20
	
		// Properties
		public bool requiresCoroutine { get; } // 0x000000018A819158-0x000000018A819164 
		public override IEnumerable<ControlConnection> validConnections { get; } // 0x000000018B383B4C-0x000000018B383BD4 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018B3839AC-0x000000018B383A34 
		public override IEnumerable<ControlOutput> validConnectedPorts { get; } // 0x000000018B383A34-0x000000018B383B4C 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get; } // 0x000000018B383894-0x000000018B3839AC 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62783
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ControlConnection, ControlOutput> __9__14_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__16_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B386EA8-0x000000018B386F0C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ControlOutput _get_validConnectedPorts_b__14_0(ControlConnection c); // 0x000000018B386DC4-0x000000018B386DDC
			internal IUnitOutputPort _get_invalidConnectedPorts_b__16_0(InvalidConnection c); // 0x000000018B386D84-0x000000018B386DA4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 62784
		{
			// Fields
			public ControlOutput port; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ControlConnection c); // 0x000000018B386E1C-0x000000018B386E44
		}
	
		// Methods
		public override bool CanConnectToValid(ControlOutput port); // 0x0000000182FFF600-0x0000000182FFF610
		public override void ConnectToValid(ControlOutput port); // 0x000000018B38363C-0x000000018B383718
		public override void ConnectToInvalid(IUnitOutputPort port); // 0x000000018B3835F0-0x000000018B38363C
		public override void DisconnectFromValid(ControlOutput port); // 0x000000018B383764-0x000000018B383894
		public override void DisconnectFromInvalid(IUnitOutputPort port); // 0x000000018B383718-0x000000018B383764
	}

	public sealed class ControlOutput : UnitPort<Unity.VisualScripting.ControlInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ControlConnection>, IUnitOutputPort // TypeDefIndex: 62788
	{
		// Properties
		public override IEnumerable<ControlConnection> validConnections { get; } // 0x000000018B384200-0x000000018B384288 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018B384060-0x000000018B3840E8 
		public override IEnumerable<ControlInput> validConnectedPorts { get; } // 0x000000018B3840E8-0x000000018B384200 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get; } // 0x000000018B383F48-0x000000018B384060 
		public ControlConnection connection { get; } // 0x000000018B383EC0-0x000000018B383F30 
		public override bool hasValidConnection { get; } // 0x000000018B383F30-0x000000018B383F48 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62786
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ControlConnection, ControlInput> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B386F70-0x000000018B386FD4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ControlInput _get_validConnectedPorts_b__6_0(ControlConnection c); // 0x000000018B386DDC-0x000000018B386DF4
			internal IUnitInputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c); // 0x000000018B386DA4-0x000000018B386DC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 62787
		{
			// Fields
			public ControlInput port; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ControlConnection c); // 0x000000018B386DF4-0x000000018B386E1C
		}
	
		// Constructors
		public ControlOutput(string key); // 0x000000018B383E78-0x000000018B383EC0
	
		// Methods
		public override bool CanConnectToValid(ControlInput port); // 0x0000000182FFF600-0x0000000182FFF610
		public override void ConnectToValid(ControlInput port); // 0x000000018B383C20-0x000000018B383CFC
		public override void ConnectToInvalid(IUnitInputPort port); // 0x000000018B383BD4-0x000000018B383C20
		public override void DisconnectFromValid(ControlInput port); // 0x000000018B383D48-0x000000018B383E78
		public override void DisconnectFromInvalid(IUnitInputPort port); // 0x000000018B383CFC-0x000000018B383D48
	}

	public sealed class InvalidInput : UnitPort<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.InvalidConnection>, IUnitInputPort // TypeDefIndex: 62790
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get; } // 0x000000018B3866C4-0x000000018B38674C 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018B38657C-0x000000018B3865AC 
		public override IEnumerable<IUnitOutputPort> validConnectedPorts { get; } // 0x000000018B3865AC-0x000000018B3866C4 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get; } // 0x000000018B386464-0x000000018B38657C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62789
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InvalidConnection, IUnitOutputPort> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B386E44-0x000000018B386EA8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal IUnitOutputPort _get_validConnectedPorts_b__6_0(InvalidConnection c); // 0x000000018B386D84-0x000000018B386DA4
			internal IUnitOutputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c); // 0x000000018B386D84-0x000000018B386DA4
		}
	
		// Constructors
		public InvalidInput(string key); // 0x000000018B38641C-0x000000018B386464
	
		// Methods
		public override bool CanConnectToValid(IUnitOutputPort port); // 0x00000001812081B0-0x0000000181208610
		public override void ConnectToValid(IUnitOutputPort port); // 0x000000018B386338-0x000000018B386384
		public override void ConnectToInvalid(IUnitOutputPort port); // 0x000000018B3862EC-0x000000018B386338
		public override void DisconnectFromValid(IUnitOutputPort port); // 0x000000018B3863D0-0x000000018B38641C
		public override void DisconnectFromInvalid(IUnitOutputPort port); // 0x000000018B386384-0x000000018B3863D0
	}

	public sealed class InvalidOutput : UnitPort<Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.InvalidConnection>, IUnitOutputPort // TypeDefIndex: 62792
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get; } // 0x000000018B386B24-0x000000018B386BAC 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018B3869DC-0x000000018B386A0C 
		public override IEnumerable<IUnitInputPort> validConnectedPorts { get; } // 0x000000018B386A0C-0x000000018B386B24 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get; } // 0x000000018B3868C4-0x000000018B3869DC 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62791
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InvalidConnection, IUnitInputPort> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B387038-0x000000018B38709C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal IUnitInputPort _get_validConnectedPorts_b__6_0(InvalidConnection c); // 0x000000018B386DA4-0x000000018B386DC4
			internal IUnitInputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c); // 0x000000018B386DA4-0x000000018B386DC4
		}
	
		// Constructors
		public InvalidOutput(string key); // 0x000000018B38687C-0x000000018B3868C4
	
		// Methods
		public override bool CanConnectToValid(IUnitInputPort port); // 0x00000001812081B0-0x0000000181208610
		public override void ConnectToValid(IUnitInputPort port); // 0x000000018B386798-0x000000018B3867E4
		public override void ConnectToInvalid(IUnitInputPort port); // 0x000000018B38674C-0x000000018B386798
		public override void DisconnectFromValid(IUnitInputPort port); // 0x000000018B386830-0x000000018B38687C
		public override void DisconnectFromInvalid(IUnitInputPort port); // 0x000000018B3867E4-0x000000018B386830
	}

	public interface IUnitInputPort : IUnitPort // TypeDefIndex: 62793
	{
	}

	public interface IUnitOutputPort : IUnitPort // TypeDefIndex: 62794
	{
	}

	public interface IUnitPort // TypeDefIndex: 62795
	{
		// Properties
		IUnit unit { get; set; }
		string key { get; }
	
		// Methods
		bool CanInvalidlyConnectTo(IUnitPort port);
		bool CanValidlyConnectTo(IUnitPort port);
		void InvalidlyConnectTo(IUnitPort port);
		void ValidlyConnectTo(IUnitPort port);
	}

	public interface IUnitPortCollection<TPort> : IKeyedCollection<string, TPort> // TypeDefIndex: 62796
		where TPort : IUnitPort
	{
	}

	public interface IUnitValuePort : IUnitPort // TypeDefIndex: 62797
	{
	}

	public sealed class MissingValuePortInputException : Exception // TypeDefIndex: 62798
	{
		// Constructors
		public MissingValuePortInputException(string key); // 0x000000018B386BAC-0x000000018B386C30
	}

	public abstract class UnitPort<TValidOther, TInvalidOther, TExternalConnection> : IUnitPort // TypeDefIndex: 62801
		where TValidOther : IUnitPort
		where TInvalidOther : IUnitPort
		where TExternalConnection : IUnitConnection
	{
		// Fields
		[CompilerGenerated]
		private IUnit _unit_k__BackingField;
		[CompilerGenerated]
		private readonly string _key_k__BackingField;
	
		// Properties
		public IUnit unit { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string key { [CompilerGenerated] get; }
		public abstract IEnumerable<TExternalConnection> validConnections { get; }
		public abstract IEnumerable<InvalidConnection> invalidConnections { get; }
		public abstract IEnumerable<TValidOther> validConnectedPorts { get; }
		public abstract IEnumerable<TInvalidOther> invalidConnectedPorts { get; }
		public virtual bool hasValidConnection { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 62799
		{
			// Fields
			public IUnitOutputPort source;
			public IUnitInputPort destination;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal bool _ConnectInvalid_b__0(InvalidConnection c);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 62800
		{
			// Fields
			public IUnitOutputPort source;
			public IUnitInputPort destination;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal bool _DisconnectInvalid_b__0(InvalidConnection c);
		}
	
		// Constructors
		protected UnitPort(string key);
	
		// Methods
		private bool CanConnectTo(IUnitPort port);
		public bool CanValidlyConnectTo(IUnitPort port);
		public bool CanInvalidlyConnectTo(IUnitPort port);
		public void ValidlyConnectTo(IUnitPort port);
		public void InvalidlyConnectTo(IUnitPort port);
		public void Disconnect();
		public abstract bool CanConnectToValid(TValidOther port);
		public bool CanConnectToInvalid(TInvalidOther port);
		public abstract void ConnectToValid(TValidOther port);
		public abstract void ConnectToInvalid(TInvalidOther port);
		public abstract void DisconnectFromValid(TValidOther port);
		public abstract void DisconnectFromInvalid(TInvalidOther port);
		protected void ConnectInvalid(IUnitOutputPort source, IUnitInputPort destination);
		protected void DisconnectInvalid(IUnitOutputPort source, IUnitInputPort destination);
	}

	public sealed class UnitPortCollection<TPort> : KeyedCollection<string, TPort>, IUnitPortCollection<TPort> // TypeDefIndex: 62802
		where TPort : IUnitPort
	{
		// Fields
		[CompilerGenerated]
		private readonly IUnit _unit_k__BackingField;
	
		// Properties
		public IUnit unit { [CompilerGenerated] get; }
		TPort Unity.VisualScripting.IKeyedCollection<System.String,TPort>.this[string key] { get => default; }
	
		// Constructors
		public UnitPortCollection(IUnit unit);
	
		// Methods
		private void BeforeAdd(TPort port);
		private void AfterAdd(TPort port);
		private void BeforeRemove(TPort port);
		private void AfterRemove(TPort port);
		protected override string GetKeyForItem(TPort item);
		protected override void InsertItem(int index, TPort item);
		protected override void RemoveItem(int index);
		protected override void SetItem(int index, TPort item);
		protected override void ClearItems();
		bool IKeyedCollection<string, TPort>.Contains(string key);
	}

	public sealed class ValueInput : UnitPort<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitInputPort // TypeDefIndex: 62805
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type _type_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _nullMeansSelf_k__BackingField; // 0x28
		private static readonly HashSet<System.Type> typesWithDefaultValues; // 0x00
	
		// Properties
		public System.Type type { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public override IEnumerable<ValueConnection> validConnections { get; } // 0x000000018B388FBC-0x000000018B389044 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018B388E1C-0x000000018B388EA4 
		public override IEnumerable<ValueOutput> validConnectedPorts { get; } // 0x000000018B388EA4-0x000000018B388FBC 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get; } // 0x000000018B388D04-0x000000018B388E1C 
		public bool nullMeansSelf { [CompilerGenerated] get; } // 0x00000001811F33C0-0x00000001811F33D0 
		public ValueConnection connection { get; } // 0x000000018B388C7C-0x000000018B388CEC 
		public override bool hasValidConnection { get; } // 0x000000018B388CEC-0x000000018B388D04 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62803
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueConnection, ValueOutput> __9__11_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__13_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B38709C-0x000000018B387100
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ValueOutput _get_validConnectedPorts_b__11_0(ValueConnection c); // 0x000000018B386DC4-0x000000018B386DDC
			internal IUnitOutputPort _get_invalidConnectedPorts_b__13_0(InvalidConnection c); // 0x000000018B386D84-0x000000018B386DA4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 62804
		{
			// Fields
			public ValueOutput port; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ValueConnection c); // 0x000000018B386E1C-0x000000018B386E44
		}
	
		// Constructors
		public ValueInput(string key, System.Type type); // 0x000000018B388BBC-0x000000018B388C7C
		static ValueInput(); // 0x000000018B388944-0x000000018B388BBC
	
		// Methods
		public void SetDefaultValue(object value); // 0x000000018B38868C-0x000000018B388808
		public override bool CanConnectToValid(ValueOutput port); // 0x000000018B388370-0x000000018B3883E8
		public override void ConnectToValid(ValueOutput port); // 0x000000018B388434-0x000000018B388510
		public override void ConnectToInvalid(IUnitOutputPort port); // 0x000000018B3883E8-0x000000018B388434
		public override void DisconnectFromValid(ValueOutput port); // 0x000000018B38855C-0x000000018B38868C
		public override void DisconnectFromInvalid(IUnitOutputPort port); // 0x000000018B388510-0x000000018B38855C
		public static bool SupportsDefaultValue(System.Type type); // 0x000000018B388808-0x000000018B388944
	}

	public sealed class ValueOutput : UnitPort<Unity.VisualScripting.ValueInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitOutputPort // TypeDefIndex: 62808
	{
		// Fields
		internal readonly Func<Flow, object> getValue; // 0x20
		[CompilerGenerated]
		private readonly System.Type _type_k__BackingField; // 0x28
	
		// Properties
		public bool supportsFetch { get; } // 0x0000000189B00070-0x0000000189B0007C 
		public System.Type type { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public override IEnumerable<ValueConnection> validConnections { get; } // 0x000000018B38971C-0x000000018B3897A4 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018B38957C-0x000000018B389604 
		public override IEnumerable<ValueInput> validConnectedPorts { get; } // 0x000000018B389604-0x000000018B38971C 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get; } // 0x000000018B389464-0x000000018B38957C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62806
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueConnection, ValueInput> __9__16_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__18_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B386FD4-0x000000018B387038
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ValueInput _get_validConnectedPorts_b__16_0(ValueConnection c); // 0x000000018B386DDC-0x000000018B386DF4
			internal IUnitInputPort _get_invalidConnectedPorts_b__18_0(InvalidConnection c); // 0x000000018B386DA4-0x000000018B386DC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 62807
		{
			// Fields
			public ValueInput port; // 0x10
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ValueConnection c); // 0x000000018B386DF4-0x000000018B386E1C
		}
	
		// Constructors
		public ValueOutput(string key, System.Type type, Func<Flow, object> getValue); // 0x000000018B389350-0x000000018B389464
	
		// Methods
		public override bool CanConnectToValid(ValueInput port); // 0x000000018B389044-0x000000018B3890AC
		public override void ConnectToValid(ValueInput port); // 0x000000018B3890F8-0x000000018B3891D4
		public override void ConnectToInvalid(IUnitInputPort port); // 0x000000018B3890AC-0x000000018B3890F8
		public override void DisconnectFromValid(ValueInput port); // 0x000000018B389220-0x000000018B389350
		public override void DisconnectFromInvalid(IUnitInputPort port); // 0x000000018B3891D4-0x000000018B389220
	}

	[SerializationVersion("A", new System.Type[0])]
	public abstract class Unit : GraphElement<Unity.VisualScripting.FlowGraph>, IUnit // TypeDefIndex: 62810
	{
		// Fields
		[CompilerGenerated]
		private readonly IUnitPortCollection<ControlInput> _controlInputs_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly IUnitPortCollection<ControlOutput> _controlOutputs_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly IUnitPortCollection<ValueInput> _valueInputs_k__BackingField; // 0x38
		[CompilerGenerated]
		private readonly IUnitPortCollection<ValueOutput> _valueOutputs_k__BackingField; // 0x40
		[CompilerGenerated]
		private readonly IUnitPortCollection<InvalidInput> _invalidInputs_k__BackingField; // 0x48
		[CompilerGenerated]
		private readonly IUnitPortCollection<InvalidOutput> _invalidOutputs_k__BackingField; // 0x50
		[CompilerGenerated]
		private Action onPortsChanged; // 0x58
		[CompilerGenerated]
		private Dictionary<string, object> _defaultValues_k__BackingField; // 0x60
		[CompilerGenerated]
		private IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> _relations_k__BackingField; // 0x68
		[CompilerGenerated]
		private bool _isControlRoot_k__BackingField; // 0x70
	
		// Properties
		[DoNotSerialize]
		public IUnitPortCollection<ControlInput> controlInputs { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		[DoNotSerialize]
		public IUnitPortCollection<ControlOutput> controlOutputs { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
		[DoNotSerialize]
		public IUnitPortCollection<ValueInput> valueInputs { [CompilerGenerated] get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[DoNotSerialize]
		public IUnitPortCollection<ValueOutput> valueOutputs { [CompilerGenerated] get; } // 0x0000000184D85A60-0x0000000184D85A70 
		[DoNotSerialize]
		public IUnitPortCollection<InvalidInput> invalidInputs { [CompilerGenerated] get; } // 0x0000000184D86200-0x0000000184D86210 
		[DoNotSerialize]
		public IUnitPortCollection<InvalidOutput> invalidOutputs { [CompilerGenerated] get; } // 0x0000000184D86270-0x0000000184D86280 
		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> inputs { get; } // 0x000000018B387D24-0x000000018B387DF8 
		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> outputs { get; } // 0x000000018B387DF8-0x000000018B387ECC 
		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> validInputs { get; } // 0x000000018B387ECC-0x000000018B387F80 
		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> validOutputs { get; } // 0x000000018B387F80-0x000000018B388034 
		[Serialize]
		public Dictionary<string, object> defaultValues { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		[DoNotSerialize]
		private IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> relations { [CompilerGenerated] set; } // 0x000000018485F170-0x000000018485F180
		[DoNotSerialize]
		protected virtual bool isControlRoot { [CompilerGenerated] set; } // 0x0000000184D86A80-0x0000000184D86A90
		FlowGraph IUnit.graph { get; } // 0x000000018B3878D8-0x000000018B387910 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0<T> // TypeDefIndex: 62809
		{
			// Fields
			public Func<Flow, T> getValue;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal object _ValueOutput_b__0(Flow recursion);
		}
	
		// Constructors
		protected Unit(); // 0x000000018B387A74-0x000000018B387D24
	
		// Methods
		protected abstract void Definition();
		public void PortsChanged(); // 0x00000001870E89F8-0x00000001870E8A08
		protected void EnsureUniqueInput(string key); // 0x000000018B387670-0x000000018B3877A4
		protected void EnsureUniqueOutput(string key); // 0x000000018B3877A4-0x000000018B3878D8
		protected ControlOutput ControlOutput(string key); // 0x000000018B3875D8-0x000000018B387670
		protected ValueInput ValueInput(System.Type type, string key); // 0x000000018B387910-0x000000018B3879B8
		protected ValueInput ValueInput<T>(string key);
		protected ValueInput ValueInput<T>(string key, T @default);
		protected ValueOutput ValueOutput(System.Type type, string key, Func<Flow, object> getValue); // 0x000000018B3879B8-0x000000018B387A74
		protected ValueOutput ValueOutput<T>(string key, Func<Flow, T> getValue);
	}

	[AttributeUsage(AttributeTargets.Class)]
	[fsObject(Converter = typeof(UnitCategoryConverter))]
	public class UnitCategory : Attribute // TypeDefIndex: 62811
	{
		// Fields
		[CompilerGenerated]
		private readonly UnitCategory _root_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly UnitCategory _parent_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly string _fullName_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly string _name_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly bool _isRoot_k__BackingField; // 0x30
	
		// Properties
		public string fullName { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Constructors
		public UnitCategory(string fullName); // 0x000000018B387414-0x000000018B3875D8
	
		// Methods
		public override bool Equals(object obj); // 0x000000018B387368-0x000000018B3873F0
		public override int GetHashCode(); // 0x000000018B3873F0-0x000000018B387414
		public override string ToString(); // 0x0000000184D862C0-0x0000000184D862D0
	}

	public class UnitCategoryConverter : fsDirectConverter // TypeDefIndex: 62812
	{
		// Properties
		public override System.Type ModelType { get; } // 0x000000018B387318-0x000000018B387368 
	
		// Methods
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018B387230-0x000000018B387318
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018B387100-0x000000018B387230
	}
}
