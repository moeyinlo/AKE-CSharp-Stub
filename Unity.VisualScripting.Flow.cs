/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

// Image 84: Unity.VisualScripting.Flow.dll - Assembly: Unity.VisualScripting.Flow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60144-60197

namespace Unity.VisualScripting
{
	public sealed class ControlConnection : UnitConnection<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.ControlInput>, IUnitConnection // TypeDefIndex: 60145
	{
		// Properties
		public override ControlOutput source { get => default; } // 0x000000018BE8FCAC-0x000000018BE8FD14 
		public override ControlInput destination { get => default; } // 0x000000018BE8FBD0-0x000000018BE8FC38 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get => default; } // 0x000000018BE8FA90-0x000000018BE8FA98 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get => default; } // 0x000000018BE8FA88-0x000000018BE8FA90 
		public override bool sourceExists { get => default; } // 0x000000018BE8FC38-0x000000018BE8FCAC 
		public override bool destinationExists { get => default; } // 0x000000018BE8FB5C-0x000000018BE8FBD0 
	
		// Constructors
		public ControlConnection() {} // Dummy constructor
		public ControlConnection(ControlOutput source, ControlInput destination) {} // 0x000000018BE8FA98-0x000000018BE8FB5C
	}

	public sealed class InvalidConnection : UnitConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IUnitConnection // TypeDefIndex: 60146
	{
		// Properties
		public override IUnitOutputPort source { get => default; } // 0x000000018BE9268C-0x000000018BE92740 
		public override IUnitInputPort destination { get => default; } // 0x000000018BE92524-0x000000018BE925D8 
		public IUnitOutputPort validSource { get => default; } // 0x000000018BE9295C-0x000000018BE92A10 
		public IUnitInputPort validDestination { get => default; } // 0x000000018BE927F4-0x000000018BE928A8 
		public override bool sourceExists { get => default; } // 0x000000018BE925D8-0x000000018BE9268C 
		public override bool destinationExists { get => default; } // 0x000000018BE92470-0x000000018BE92524 
		public bool validSourceExists { get => default; } // 0x000000018BE928A8-0x000000018BE9295C 
		public bool validDestinationExists { get => default; } // 0x000000018BE92740-0x000000018BE927F4 
	
		// Constructors
		public InvalidConnection() {} // Dummy constructor
		public InvalidConnection(IUnitOutputPort source, IUnitInputPort destination) {} // 0x000000018BE92418-0x000000018BE92470
	
		// Methods
		public override bool HandleDependencies() => default; // 0x000000018BE91F7C-0x000000018BE92158
		private bool _get_source_b__4_0(IUnitOutputPort p) => default; // 0x000000018BE92260-0x000000018BE922B8
		private bool _get_destination_b__6_0(IUnitInputPort p) => default; // 0x000000018BE921B0-0x000000018BE92208
		private bool _get_validSource_b__8_0(IUnitOutputPort p) => default; // 0x000000018BE923C0-0x000000018BE92418
		private bool _get_validDestination_b__10_0(IUnitInputPort p) => default; // 0x000000018BE92310-0x000000018BE92368
		private bool _get_sourceExists_b__12_0(IUnitOutputPort p) => default; // 0x000000018BE92208-0x000000018BE92260
		private bool _get_destinationExists_b__14_0(IUnitInputPort p) => default; // 0x000000018BE92158-0x000000018BE921B0
		private bool _get_validSourceExists_b__16_0(IUnitOutputPort p) => default; // 0x000000018BE92368-0x000000018BE923C0
		private bool _get_validDestinationExists_b__18_0(IUnitInputPort p) => default; // 0x000000018BE922B8-0x000000018BE92310
	}

	public interface IUnitConnection : IConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IGraphElementWithDebugData // TypeDefIndex: 60147
	{
	}

	public interface IUnitConnectionDebugData : IGraphElementDebugData // TypeDefIndex: 60148
	{
		// Properties
		int lastInvokeFrame { get; set; }
		float lastInvokeTime { get; set; }
	}

	public interface IUnitRelation : IConnection<Unity.VisualScripting.IUnitPort, Unity.VisualScripting.IUnitPort> // TypeDefIndex: 60149
	{
	}

	public abstract class UnitConnection<TSourcePort, TDestinationPort> : GraphElement<Unity.VisualScripting.FlowGraph>, IConnection<TSourcePort, TDestinationPort> // TypeDefIndex: 60150
		where TSourcePort : class, IUnitOutputPort
		where TDestinationPort : class, IUnitInputPort
	{
		// Fields
		private IUnit _sourceUnit_k__BackingField;
		private string _sourceKey_k__BackingField;
		private IUnit _destinationUnit_k__BackingField;
		private string _destinationKey_k__BackingField;
	
		// Properties
		protected IUnit sourceUnit { get; private set; }
		protected string sourceKey { get; private set; }
		protected IUnit destinationUnit { get; private set; }
		protected string destinationKey { get; private set; }
		public abstract TSourcePort source { get; }
		public abstract TDestinationPort destination { get; }
		public override int dependencyOrder { get; }
		public abstract bool sourceExists { get; }
		public abstract bool destinationExists { get; }
	
		// Constructors
		protected UnitConnection() {} // Dummy constructor
		protected UnitConnection(TSourcePort source, TDestinationPort destination) {}
	
		// Methods
		public override bool HandleDependencies() => default;
	}

	public class UnitConnectionDebugData : IUnitConnectionDebugData // TypeDefIndex: 60151
	{
		// Fields
		private int _lastInvokeFrame_k__BackingField; // 0x10
		private float _lastInvokeTime_k__BackingField; // 0x14
		private Exception _runtimeException_k__BackingField; // 0x18
	
		// Properties
		public int lastInvokeFrame { get; set; } // 0x0000000181378230-0x0000000181378240
		public float lastInvokeTime { get; set; } // 0x0000000181A6E390-0x0000000181A6FA00
		public Exception runtimeException { get; set; } // 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public UnitConnectionDebugData() {} // Dummy constructor
	}

	public sealed class ValueConnection : UnitConnection<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.ValueInput>, IUnitConnection // TypeDefIndex: 60153
	{
		// Properties
		public override ValueOutput source { get => default; } // 0x000000018BE8FA90-0x000000018BE8FA98 
		public override ValueInput destination { get => default; } // 0x000000018BE8FA88-0x000000018BE8FA90 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get => default; } // 0x000000018BE949B8-0x000000018BE94A2C 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get => default; } // 0x000000018BE948DC-0x000000018BE94950 
		public override bool sourceExists { get => default; } // 0x000000018646EE40-0x000000018646EE50 
		public override bool destinationExists { get => default; } // 0x00000001813B4840-0x00000001813B4850 
	
		// Nested types
		public class DebugData : UnitConnectionDebugData // TypeDefIndex: 60152
		{
			// Fields
			private object _lastValue_k__BackingField; // 0x20
			private bool _assignedLastValue_k__BackingField; // 0x28
	
			// Properties
			public object lastValue { get; set; } // 0x000000018BE94758-0x000000018BE948DC
			public bool assignedLastValue { get; set; } // 0x000000018BE94A2C-0x000000018BE94A94
	
			// Constructors
			public DebugData() {} // Dummy constructor
		}
	
		// Constructors
		public ValueConnection() {} // Dummy constructor
		public ValueConnection(ValueOutput source, ValueInput destination) {} // 0x000000018BE94950-0x000000018BE949B8
	}

	public class PortLabelHiddenAttribute : Attribute // TypeDefIndex: 60154
	{
		// Constructors
		public PortLabelHiddenAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class SpecialUnitAttribute : Attribute // TypeDefIndex: 60155
	{
		// Constructors
		public SpecialUnitAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class UnitHeaderInspectableAttribute : Attribute // TypeDefIndex: 60156
	{
		// Constructors
		public UnitHeaderInspectableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class UnitShortTitleAttribute : Attribute // TypeDefIndex: 60157
	{
		// Fields
		private string _title_k__BackingField; // 0x10
	
		// Properties
		private string title { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public UnitShortTitleAttribute() {} // Dummy constructor
		public UnitShortTitleAttribute(string title) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class UnitTitleAttribute : Attribute // TypeDefIndex: 60158
	{
		// Fields
		private string _title_k__BackingField; // 0x10
	
		// Properties
		private string title { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public UnitTitleAttribute() {} // Dummy constructor
		public UnitTitleAttribute(string title) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class Flow : IPoolable, IDisposable // TypeDefIndex: 60161
	{
		// Fields
		private GraphStack _stack_k__BackingField; // 0x10
		private Recursion<RecursionNode> recursion; // 0x18
		private readonly Dictionary<IUnitValuePort, object> locals; // 0x20
		public readonly VariableDeclarations variables; // 0x28
		private readonly Stack<int> loops; // 0x30
		private readonly HashSet<GraphStack> preservedStacks; // 0x38
		private MonoBehaviour _coroutineRunner_k__BackingField; // 0x40
		private ICollection<Flow> activeCoroutinesRegistry; // 0x48
		private bool coroutineStopRequested; // 0x50
		private bool _isCoroutine_k__BackingField; // 0x51
		private IEnumerator coroutineEnumerator; // 0x58
		private bool _isPrediction_k__BackingField; // 0x60
		private bool disposed; // 0x61
		public int loopIdentifier; // 0x64
	
		// Properties
		public GraphStack stack { get; private set; } // 0x000000018BE91DB8-0x000000018BE91E00 0x000000018BE90C50-0x000000018BE90D08
		private MonoBehaviour coroutineRunner { get; set; } // 0x000000018BE91A14-0x000000018BE91DB8
		private bool isCoroutine { get; set; } // 0x000000018BE915B8-0x000000018BE917B4
		public bool isPrediction { get; private set; } // 0x000000018BE90A00-0x000000018BE90C50 0x000000018BE909AC-0x000000018BE90A00
		public bool enableDebug { get => default; } // 0x000000018BE91448-0x000000018BE915B8 
	
		// Nested types
		private struct RecursionNode : IEquatable<RecursionNode> // TypeDefIndex: 60159
		{
			// Fields
			private readonly IUnitPort _port_k__BackingField; // 0x00
			private readonly IGraphParent _context_k__BackingField; // 0x08
	
			// Properties
			public IUnitPort port { get; } // 0x000000018346D130-0x000000018346D140 
			public IGraphParent context { get; } // 0x0000000184096E30-0x0000000184096EF0 
	
			// Constructors
			public RecursionNode(IUnitPort port, GraphPointer pointer) : this() {
				<port>k__BackingField = default;
				<context>k__BackingField = default;
			} // 0x0000000185F05C80-0x0000000185F05C90
	
			// Methods
			public bool Equals(RecursionNode other) => default; // 0x00000001813AF350-0x00000001813AF360
			public override bool Equals(object obj) => default; // 0x000000018386C570-0x000000018386C580
			public override int GetHashCode() => default; // 0x000000018386C580-0x000000018386C590
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60160
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Flow> __9__35_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE91F4C-0x000000018BE91F7C
			public __c() {} // 0x000000018BE91E00-0x000000018BE91F4C
	
			// Methods
			internal Flow _New_b__35_0() => default; // 0x000000018BE917B4-0x000000018BE91954
		}
	
		// Constructors
		private Flow() {} // 0x000000018BE911DC-0x000000018BE913D8
	
		// Methods
		public static Flow New(GraphReference reference) => default; // 0x000000018BE90DEC-0x000000018BE911DC
		void IPoolable.New() {} // 0x000000018BE913D8-0x000000018BE91448
		public void Dispose() {}
		void IPoolable.Free() {} // 0x000000018BE91954-0x000000018BE91A14
		public void Invoke(ControlOutput output) {} // 0x000000018BE90D08-0x000000018BE90DEC
		private RecursionNode BeforeInvoke(ControlOutput output, RecursionNode recursionNode) => default; // 0x00000001834AFB60-0x00000001834AFB70
		private void AfterInvoke(ControlOutput output, RecursionNode recursionNode) {} // 0x000000018357A260-0x000000018357A270
		private ControlOutput InvokeDelegate(ControlInput input) => default; // 0x000000018BE9341C-0x000000018BE93458
		public object GetValue(ValueInput input) => default; // 0x000000018BE933C4-0x000000018BE933DC
		private object GetValue(ValueOutput output) => default; // 0x000000018BE93354-0x000000018BE933C4
		public object GetValue(ValueInput input, System.Type type) => default; // 0x000000018BE933DC-0x000000018BE9341C
		public T GetValue<T>(ValueInput input) => default; // 0x000000018BE93630-0x000000018BE93694
		public bool TryGetDefaultValue(ValueInput input, out object defaultValue) {
			defaultValue = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private object GetValueDelegate(ValueOutput output) => default; // 0x000000018BE93458-0x000000018BE934A8
	}

	public sealed class FlowGraph : Graph, IGraph // TypeDefIndex: 60162
	{
		// Fields
		private GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> _controlConnections_k__BackingField; // 0x20
		private GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> _valueConnections_k__BackingField; // 0x28
		private GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> _invalidConnections_k__BackingField; // 0x30
	
		// Properties
		public GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> controlConnections { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> valueConnections { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> invalidConnections { get; } // 0x00000001813B51D0-0x00000001813B51E0 
	
		// Constructors
		public FlowGraph() {} // Dummy constructor
	}

	public abstract class EventUnit<TArgs> : Unit, IUnit // TypeDefIndex: 60163
	{
		// Fields
		private ControlOutput _trigger_k__BackingField;
	
		// Properties
		public ControlOutput trigger { get; private set; }
		new FlowGraph IUnit.graph { get; }
	
		// Constructors
		protected EventUnit() {}
	
		// Methods
		protected override void Definition() {}
	}

	public abstract class ManualEventUnit<TArgs> : EventUnit<TArgs> // TypeDefIndex: 60164
	{
		// Properties
		protected abstract string hookName { get; }
	
		// Constructors
		protected ManualEventUnit() {}
	}

	public sealed class MissingType : Unit // TypeDefIndex: 60165
	{
		// Constructors
		public MissingType() {} // Dummy constructor
	
		// Methods
		protected override void Definition() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IUnit : IGraphElementWithDebugData // TypeDefIndex: 60166
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

	public interface IUnitDebugData : IGraphElementDebugData // TypeDefIndex: 60167
	{
		// Properties
		int lastInvokeFrame { get; set; }
		float lastInvokeTime { get; set; }
	}

	public sealed class ControlInput : UnitPort<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ControlConnection>, IUnitInputPort // TypeDefIndex: 60170
	{
		// Fields
		internal readonly Func<Flow, ControlOutput> action; // 0x20
	
		// Properties
		public bool requiresCoroutine { get => default; } // 0x000000018BE8FD60-0x000000018BE8FE3C 
		public override IEnumerable<ControlConnection> validConnections { get => default; } // 0x000000018BE8FD14-0x000000018BE8FD60 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x000000018BE8FE88-0x000000018BE8FFB8 
		public override IEnumerable<ControlOutput> validConnectedPorts { get => default; } // 0x000000018BE8FE3C-0x000000018BE8FE88 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get => default; } // 0x000000018BE935CC-0x000000018BE93630 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60168
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ControlConnection, ControlOutput> __9__14_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__16_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B34D6B0-0x000000018B34D6BC
			public __c() {} // 0x000000018BE90270-0x000000018BE902F8
	
			// Methods
			internal ControlOutput _get_validConnectedPorts_b__14_0(ControlConnection c) => default; // 0x000000018BE900D0-0x000000018BE90158
			internal IUnitOutputPort _get_invalidConnectedPorts_b__16_0(InvalidConnection c) => default; // 0x000000018BE90158-0x000000018BE90270
		}
	
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 60169
		{
			// Fields
			public ControlOutput port; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0() {} // 0x000000018BE8FFB8-0x000000018BE900D0
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ControlConnection c) => default; // 0x00000001840A27C0-0x00000001840A27D0
		}
	
		// Constructors
		public ControlInput() {} // Dummy constructor
	
		// Methods
		public override bool CanConnectToValid(ControlOutput port) => default; // 0x0000000185492010-0x0000000185492020
		public override void ConnectToValid(ControlOutput port) {} // 0x000000018BE934E8-0x000000018BE93500
		public override void ConnectToInvalid(IUnitOutputPort port) {} // 0x000000018BE934A8-0x000000018BE934C8
		public override void DisconnectFromValid(ControlOutput port) {} // 0x0000000185492010-0x0000000185492020
		public override void DisconnectFromInvalid(IUnitOutputPort port) {} // 0x000000018BE93540-0x000000018BE93568
	}

	public sealed class ControlOutput : UnitPort<Unity.VisualScripting.ControlInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ControlConnection>, IUnitOutputPort // TypeDefIndex: 60173
	{
		// Properties
		public override IEnumerable<ControlConnection> validConnections { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x000000018BE90344-0x000000018BE90420 
		public override IEnumerable<ControlInput> validConnectedPorts { get => default; } // 0x000000018BE902F8-0x000000018BE90344 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get => default; } // 0x000000018BE9046C-0x000000018BE9059C 
		public ControlConnection connection { get => default; } // 0x000000018BE90420-0x000000018BE9046C 
		public override bool hasValidConnection { get => default; } // 0x000000018BE93694-0x000000018BE936F8 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60171
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ControlConnection, ControlInput> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE9059C-0x000000018BE905E4
			public __c() {} // 0x000000018BE90924-0x000000018BE909AC
	
			// Methods
			internal ControlInput _get_validConnectedPorts_b__6_0(ControlConnection c) => default; // 0x000000018BE90784-0x000000018BE9080C
			internal IUnitInputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c) => default; // 0x000000018BE9080C-0x000000018BE90924
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 60172
		{
			// Fields
			public ControlInput port; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x000000018BE9066C-0x000000018BE90784
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ControlConnection c) => default; // 0x000000018BE905E4-0x000000018BE90654
		}
	
		// Constructors
		public ControlOutput() {} // Dummy constructor
		public ControlOutput(string key) {} // 0x000000018BE90654-0x000000018BE9066C
	
		// Methods
		public override bool CanConnectToValid(ControlInput port) => default; // 0x0000000185492010-0x0000000185492020
		public override void ConnectToValid(ControlInput port) {} // 0x000000018BE93500-0x000000018BE93518
		public override void ConnectToInvalid(IUnitInputPort port) {} // 0x000000018BE934C8-0x000000018BE934E8
		public override void DisconnectFromValid(ControlInput port) {} // 0x0000000185492010-0x0000000185492020
		public override void DisconnectFromInvalid(IUnitInputPort port) {} // 0x000000018BE93518-0x000000018BE93540
	}

	public sealed class InvalidInput : UnitPort<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.InvalidConnection>, IUnitInputPort // TypeDefIndex: 60175
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x000000018BE92A5C-0x000000018BE92AA8 
		public override IEnumerable<IUnitOutputPort> validConnectedPorts { get => default; } // 0x000000018BE92A10-0x000000018BE92A5C 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get => default; } // 0x000000018BE92AF4-0x000000018BE92B40 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60174
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InvalidConnection, IUnitOutputPort> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE92B40-0x000000018BE92B88
			public __c() {} // 0x000000018BE92DE8-0x000000018BE92E70
	
			// Methods
			internal IUnitOutputPort _get_validConnectedPorts_b__6_0(InvalidConnection c) => default; // 0x000000018BE92CA0-0x000000018BE92CD0
			internal IUnitOutputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c) => default; // 0x000000018BE92CD0-0x000000018BE92DE8
		}
	
		// Constructors
		public InvalidInput() {} // Dummy constructor
		public InvalidInput(string key) {} // 0x000000018BE92B88-0x000000018BE92CA0
	
		// Methods
		public override bool CanConnectToValid(IUnitOutputPort port) => default; // 0x000000018BE92AA8-0x000000018BE92AF4
		public override void ConnectToValid(IUnitOutputPort port) {} // 0x000000018BE93568-0x000000018BE935CC
		public override void ConnectToInvalid(IUnitOutputPort port) {} // 0x0000000185492010-0x0000000185492020
		public override void DisconnectFromValid(IUnitOutputPort port) {} // 0x000000018BE934A8-0x000000018BE934C8
		public override void DisconnectFromInvalid(IUnitOutputPort port) {} // 0x000000018BE934A8-0x000000018BE934C8
	}

	public sealed class InvalidOutput : UnitPort<Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.InvalidConnection>, IUnitOutputPort // TypeDefIndex: 60177
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x000000018BE92EBC-0x000000018BE92F08 
		public override IEnumerable<IUnitInputPort> validConnectedPorts { get => default; } // 0x000000018BE92E70-0x000000018BE92EBC 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get => default; } // 0x000000018BE92F54-0x000000018BE92FA0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60176
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InvalidConnection, IUnitInputPort> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE92FA0-0x000000018BE92FE8
			public __c() {} // 0x000000018BE93248-0x000000018BE932D0
	
			// Methods
			internal IUnitInputPort _get_validConnectedPorts_b__6_0(InvalidConnection c) => default; // 0x000000018BE93100-0x000000018BE93130
			internal IUnitInputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c) => default; // 0x000000018BE93130-0x000000018BE93248
		}
	
		// Constructors
		public InvalidOutput() {} // Dummy constructor
		public InvalidOutput(string key) {} // 0x000000018BE92FE8-0x000000018BE93100
	
		// Methods
		public override bool CanConnectToValid(IUnitInputPort port) => default; // 0x000000018BE92F08-0x000000018BE92F54
		public override void ConnectToValid(IUnitInputPort port) {} // 0x000000018BE9375C-0x000000018BE937C0
		public override void ConnectToInvalid(IUnitInputPort port) {} // 0x0000000185492010-0x0000000185492020
		public override void DisconnectFromValid(IUnitInputPort port) {} // 0x000000018BE934C8-0x000000018BE934E8
		public override void DisconnectFromInvalid(IUnitInputPort port) {} // 0x000000018BE934C8-0x000000018BE934E8
	}

	public interface IUnitInputPort : IUnitPort // TypeDefIndex: 60178
	{
	}

	public interface IUnitOutputPort : IUnitPort // TypeDefIndex: 60179
	{
	}

	public interface IUnitPort // TypeDefIndex: 60180
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

	public interface IUnitPortCollection<TPort> : IKeyedCollection<string, TPort> // TypeDefIndex: 60181
		where TPort : IUnitPort
	{
	}

	public interface IUnitValuePort : IUnitPort // TypeDefIndex: 60182
	{
	}

	public sealed class MissingValuePortInputException : Exception // TypeDefIndex: 60183
	{
		// Constructors
		public MissingValuePortInputException() {} // Dummy constructor
		public MissingValuePortInputException(string key) {} // 0x000000018BE932D0-0x000000018BE93354
	}

	public abstract class UnitPort<TValidOther, TInvalidOther, TExternalConnection> : IUnitPort // TypeDefIndex: 60186
		where TValidOther : IUnitPort
		where TInvalidOther : IUnitPort
		where TExternalConnection : IUnitConnection
	{
		// Fields
		private IUnit _unit_k__BackingField;
		private readonly string _key_k__BackingField;
	
		// Properties
		public IUnit unit { get; set; }
		public string key { get; }
		public abstract IEnumerable<TExternalConnection> validConnections { get; }
		public abstract IEnumerable<InvalidConnection> invalidConnections { get; }
		public abstract IEnumerable<TValidOther> validConnectedPorts { get; }
		public abstract IEnumerable<TInvalidOther> invalidConnectedPorts { get; }
		public virtual bool hasValidConnection { get; }
	
		// Nested types
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 60184
		{
			// Fields
			public IUnitOutputPort source;
			public IUnitInputPort destination;
	
			// Constructors
			public __c__DisplayClass45_0() {}
	
			// Methods
			internal bool _ConnectInvalid_b__0(InvalidConnection c) => default;
		}
	
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 60185
		{
			// Fields
			public IUnitOutputPort source;
			public IUnitInputPort destination;
	
			// Constructors
			public __c__DisplayClass46_0() {}
	
			// Methods
			internal bool _DisconnectInvalid_b__0(InvalidConnection c) => default;
		}
	
		// Constructors
		protected UnitPort() {} // Dummy constructor
		protected UnitPort(string key) {}
	
		// Methods
		private bool CanConnectTo(IUnitPort port) => default;
		public bool CanValidlyConnectTo(IUnitPort port) => default;
		public bool CanInvalidlyConnectTo(IUnitPort port) => default;
		public void ValidlyConnectTo(IUnitPort port) {}
		public void InvalidlyConnectTo(IUnitPort port) {}
		public void Disconnect() {}
		public abstract bool CanConnectToValid(TValidOther port);
		public bool CanConnectToInvalid(TInvalidOther port) => default;
		public abstract void ConnectToValid(TValidOther port);
		public abstract void ConnectToInvalid(TInvalidOther port);
		public abstract void DisconnectFromValid(TValidOther port);
		public abstract void DisconnectFromInvalid(TInvalidOther port);
		protected void ConnectInvalid(IUnitOutputPort source, IUnitInputPort destination) {}
		protected void DisconnectInvalid(IUnitOutputPort source, IUnitInputPort destination) {}
	}

	public sealed class UnitPortCollection<TPort> : KeyedCollection<string, TPort>, IUnitPortCollection<TPort> // TypeDefIndex: 60187
		where TPort : IUnitPort
	{
		// Fields
		private readonly IUnit _unit_k__BackingField;
	
		// Properties
		public IUnit unit { get; }
		TPort Unity.VisualScripting.IKeyedCollection<System.String,TPort>.this[string key] { get => default; }
	
		// Constructors
		public UnitPortCollection() {} // Dummy constructor
		public UnitPortCollection(IUnit unit) {}
	
		// Methods
		private void BeforeAdd(TPort port) {}
		private void AfterAdd(TPort port) {}
		private void BeforeRemove(TPort port) {}
		private void AfterRemove(TPort port) {}
		protected override string GetKeyForItem(TPort item) => default;
		protected override void InsertItem(int index, TPort item) {}
		protected override void RemoveItem(int index) {}
		protected override void SetItem(int index, TPort item) {}
		protected override void ClearItems() {}
		bool IKeyedCollection<string, TPort>.Contains(string key) => default;
	}

	public sealed class ValueInput : UnitPort<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitInputPort // TypeDefIndex: 60190
	{
		// Fields
		private readonly System.Type _type_k__BackingField; // 0x20
		private bool _nullMeansSelf_k__BackingField; // 0x28
		private static readonly HashSet<System.Type> typesWithDefaultValues; // 0x00
	
		// Properties
		public System.Type type { get; } // 0x000000018BE953A0-0x000000018BE95410 
		public override IEnumerable<ValueConnection> validConnections { get => default; } // 0x000000018BE95410-0x000000018BE95428 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x000000018BE94DB0-0x000000018BE94F2C 
		public override IEnumerable<ValueOutput> validConnectedPorts { get => default; } // 0x000000018BE94A94-0x000000018BE94B0C 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get => default; } // 0x000000018BE94B58-0x000000018BE94C34 
		public bool nullMeansSelf { get; } // 0x000000018BE94B0C-0x000000018BE94B58 
		public ValueConnection connection { get => default; } // 0x000000018BE94C80-0x000000018BE94DB0 
		public override bool hasValidConnection { get => default; } // 0x000000018BE94C34-0x000000018BE94C80 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60188
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueConnection, ValueOutput> __9__11_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__13_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE952E0-0x000000018BE953A0
			public __c() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal ValueOutput _get_validConnectedPorts_b__11_0(ValueConnection c) => default; // 0x000000018BE956E0-0x000000018BE95768
			internal IUnitOutputPort _get_invalidConnectedPorts_b__13_0(InvalidConnection c) => default; // 0x000000018BE95540-0x000000018BE955C8
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 60189
		{
			// Fields
			public ValueOutput port; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x000000018BE955C8-0x000000018BE956E0
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ValueConnection c) => default; // 0x000000018BE95428-0x000000018BE95540
		}
	
		// Constructors
		public ValueInput() {} // Dummy constructor
		public ValueInput(string key, System.Type type) {} // 0x00000001813B31B0-0x00000001813B31C0
		static ValueInput() {} // 0x000000018BE93540-0x000000018BE93568
	
		// Methods
		public void SetDefaultValue(object value) {} // 0x000000018BE94F2C-0x000000018BE95068
		public override bool CanConnectToValid(ValueOutput port) => default; // 0x000000018BE95068-0x000000018BE952E0
		public override void ConnectToValid(ValueOutput port) {} // 0x000000018BE937C0-0x000000018BE93824
		public override void ConnectToInvalid(IUnitOutputPort port) {} // 0x0000000185492010-0x0000000185492020
		public override void DisconnectFromValid(ValueOutput port) {} // 0x000000018BE934E8-0x000000018BE93500
		public override void DisconnectFromInvalid(IUnitOutputPort port) {} // 0x000000018BE934A8-0x000000018BE934C8
		public static bool SupportsDefaultValue(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ValueOutput : UnitPort<Unity.VisualScripting.ValueInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitOutputPort // TypeDefIndex: 60193
	{
		// Fields
		internal readonly Func<Flow, object> getValue; // 0x20
		private readonly System.Type _type_k__BackingField; // 0x28
	
		// Properties
		public bool supportsFetch { get => default; } // 0x000000018BE95768-0x000000018BE957D0 
		public System.Type type { get; } // 0x000000018BE9581C-0x000000018BE958F8 
		public override IEnumerable<ValueConnection> validConnections { get => default; } // 0x000000018BE957D0-0x000000018BE9581C 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x000000018BE95944-0x000000018BE95A74 
		public override IEnumerable<ValueInput> validConnectedPorts { get => default; } // 0x000000018BE958F8-0x000000018BE95944 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get => default; } // 0x000000018BE936F8-0x000000018BE9375C 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60191
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueConnection, ValueInput> __9__16_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__18_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE95A74-0x000000018BE95B88
			public __c() {} // 0x000000018A69B84C-0x000000018A69B858
	
			// Methods
			internal ValueInput _get_validConnectedPorts_b__16_0(ValueConnection c) => default; // 0x00000001813B8590-0x00000001813B85A0
			internal IUnitInputPort _get_invalidConnectedPorts_b__18_0(InvalidConnection c) => default; // 0x000000018BE95E40-0x000000018BE95EC8
		}
	
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 60192
		{
			// Fields
			public ValueInput port; // 0x10
	
			// Constructors
			public __c__DisplayClass22_0() {} // 0x000000018BE95CA0-0x000000018BE95D28
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ValueConnection c) => default; // 0x000000018BE95D28-0x000000018BE95E40
		}
	
		// Constructors
		public ValueOutput() {} // Dummy constructor
		public ValueOutput(string key, System.Type type, Func<Flow, object> getValue) {} // 0x000000018BE95B88-0x000000018BE95CA0
	
		// Methods
		public override bool CanConnectToValid(ValueInput port) => default; // 0x0000000185492010-0x0000000185492020
		public override void ConnectToValid(ValueInput port) {} // 0x000000018BE93500-0x000000018BE93518
		public override void ConnectToInvalid(IUnitInputPort port) {} // 0x000000018BE934C8-0x000000018BE934E8
		public override void DisconnectFromValid(ValueInput port) {} // 0x0000000185492010-0x0000000185492020
		public override void DisconnectFromInvalid(IUnitInputPort port) {} // 0x000000018BE93518-0x000000018BE93540
	}

	public abstract class Unit : GraphElement<Unity.VisualScripting.FlowGraph>, IUnit // TypeDefIndex: 60195
	{
		// Fields
		private readonly IUnitPortCollection<ControlInput> _controlInputs_k__BackingField; // 0x28
		private readonly IUnitPortCollection<ControlOutput> _controlOutputs_k__BackingField; // 0x30
		private readonly IUnitPortCollection<ValueInput> _valueInputs_k__BackingField; // 0x38
		private readonly IUnitPortCollection<ValueOutput> _valueOutputs_k__BackingField; // 0x40
		private readonly IUnitPortCollection<InvalidInput> _invalidInputs_k__BackingField; // 0x48
		private readonly IUnitPortCollection<InvalidOutput> _invalidOutputs_k__BackingField; // 0x50
		private Action onPortsChanged; // 0x58
		private Dictionary<string, object> _defaultValues_k__BackingField; // 0x60
		private IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> _relations_k__BackingField; // 0x68
		private bool _isControlRoot_k__BackingField; // 0x70
	
		// Properties
		public IUnitPortCollection<ControlInput> controlInputs { get; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public IUnitPortCollection<ControlOutput> controlOutputs { get; } // 0x00000001813FF010-0x00000001813FF020 
		public IUnitPortCollection<ValueInput> valueInputs { get; } // 0x00000001813ECF20-0x00000001813ECF30 
		public IUnitPortCollection<ValueOutput> valueOutputs { get; } // 0x0000000181460F60-0x0000000181460F70 
		public IUnitPortCollection<InvalidInput> invalidInputs { get; } // 0x000000018BE94448-0x000000018BE9451C 
		public IUnitPortCollection<InvalidOutput> invalidOutputs { get; } // 0x000000018BE9451C-0x000000018BE945F0 
		public IEnumerable<IUnitInputPort> inputs { get; } // 0x000000018BE945F0-0x000000018BE946A4 
		public IEnumerable<IUnitOutputPort> outputs { get; } // 0x000000018BE946A4-0x000000018BE94758 
		public IEnumerable<IUnitInputPort> validInputs { get; } // 0x0000000187F5B4C8-0x0000000187F5B4D8 
		public IEnumerable<IUnitOutputPort> validOutputs { get; } // 0x0000000185FB0530-0x0000000185FB0540 
		public Dictionary<string, object> defaultValues { get; private set; } // 0x0000000185A62990-0x0000000185A629A0 0x0000000185FB0970-0x0000000185FB0980
		private IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> relations { get; set; } // 0x000000018BE93D94-0x000000018BE93EC8
		protected virtual bool isControlRoot { get; set; } // 0x000000018BE93EC8-0x000000018BE93FFC
		FlowGraph IUnit.graph { get; }
	
		// Nested types
		private sealed class __c__DisplayClass86_0<T> // TypeDefIndex: 60194
		{
			// Fields
			public Func<Flow, T> getValue;
	
			// Constructors
			public __c__DisplayClass86_0() {} // 0x000000018BE94198-0x000000018BE94448
	
			// Methods
			internal object _ValueOutput_b__0(Flow recursion) => default;
		}
	
		// Constructors
		protected Unit() {} // 0x00000001813B8590-0x00000001813B85A0
	
		// Methods
		protected abstract void Definition(); // 0x00000001813B51D0-0x00000001813B51E0
		public void PortsChanged() {} // 0x0000000185AE8FE0-0x0000000185AE8FF0
		protected void EnsureUniqueInput(string key) {} // 0x000000018BE93CFC-0x000000018BE93D94
		protected void EnsureUniqueOutput(string key) {} // 0x000000018BE94034-0x000000018BE940DC
		protected ControlOutput ControlOutput(string key) => default;
		protected ValueInput ValueInput(System.Type type, string key) => default;
		protected ValueInput ValueInput<T>(string key) => default; // 0x000000018BE940DC-0x000000018BE94198
		protected ValueInput ValueInput<T>(string key, T @default) => default;
		protected ValueOutput ValueOutput(System.Type type, string key, Func<Flow, object> getValue) => default; // 0x000000018BE93FFC-0x000000018BE94034
		protected ValueOutput ValueOutput<T>(string key, Func<Flow, T> getValue) => default;
	}

	public class UnitCategory : Attribute // TypeDefIndex: 60196
	{
		// Fields
		private readonly UnitCategory _root_k__BackingField; // 0x10
		private readonly UnitCategory _parent_k__BackingField; // 0x18
		private readonly string _fullName_k__BackingField; // 0x20
		private readonly string _name_k__BackingField; // 0x28
		private readonly bool _isRoot_k__BackingField; // 0x30
	
		// Properties
		public string fullName { get; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Constructors
		public UnitCategory() {} // Dummy constructor
		public UnitCategory(string fullName) {} // 0x000000018BE93B38-0x000000018BE93CFC
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BE93A8C-0x000000018BE93B14
		public override int GetHashCode() => default; // 0x000000018BE93B14-0x000000018BE93B38
		public override string ToString() => default; // 0x00000001813B31A0-0x00000001813B31B0
	}

	public class UnitCategoryConverter : fsDirectConverter // TypeDefIndex: 60197
	{
		// Properties
		public override System.Type ModelType { get => default; } // 0x000000018BE93A3C-0x000000018BE93A8C 
	
		// Constructors
		public UnitCategoryConverter() {} // Dummy constructor
	
		// Methods
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE93954-0x000000018BE93A3C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE93824-0x000000018BE93954
	}
}
