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

// Image 87: Unity.VisualScripting.Flow.dll - Assembly: Unity.VisualScripting.Flow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90075-90128

namespace Unity.VisualScripting
{
	public sealed class ControlConnection : UnitConnection<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.ControlInput>, IUnitConnection // TypeDefIndex: 90076
	{
		// Properties
		public override ControlOutput source { get; } // 0x000000018D4AA858-0x000000018D4AA8C0 
		public override ControlInput destination { get; } // 0x000000018D4AA77C-0x000000018D4AA7E4 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get; } // 0x000000018D4AA63C-0x000000018D4AA644 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get; } // 0x000000018D4AA634-0x000000018D4AA63C 
		public override bool sourceExists { get; } // 0x000000018D4AA7E4-0x000000018D4AA858 
		public override bool destinationExists { get; } // 0x000000018D4AA708-0x000000018D4AA77C 
	
		// Constructors
		public ControlConnection(ControlOutput source, ControlInput destination); // 0x000000018D4AA644-0x000000018D4AA708
	}

	public sealed class InvalidConnection : UnitConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IUnitConnection // TypeDefIndex: 90077
	{
		// Properties
		public override IUnitOutputPort source { get; } // 0x000000018D4AD234-0x000000018D4AD2E8 
		public override IUnitInputPort destination { get; } // 0x000000018D4AD0CC-0x000000018D4AD180 
		public IUnitOutputPort validSource { get; } // 0x000000018D4AD504-0x000000018D4AD5B8 
		public IUnitInputPort validDestination { get; } // 0x000000018D4AD39C-0x000000018D4AD450 
		public override bool sourceExists { get; } // 0x000000018D4AD180-0x000000018D4AD234 
		public override bool destinationExists { get; } // 0x000000018D4AD018-0x000000018D4AD0CC 
		public bool validSourceExists { get; } // 0x000000018D4AD450-0x000000018D4AD504 
		public bool validDestinationExists { get; } // 0x000000018D4AD2E8-0x000000018D4AD39C 
	
		// Constructors
		public InvalidConnection(IUnitOutputPort source, IUnitInputPort destination); // 0x000000018D4ACFC0-0x000000018D4AD018
	
		// Methods
		public override bool HandleDependencies(); // 0x000000018D4ACB24-0x000000018D4ACD00
		[CompilerGenerated]
		private bool _get_source_b__4_0(IUnitOutputPort p); // 0x000000018D4ACE08-0x000000018D4ACE60
		[CompilerGenerated]
		private bool _get_destination_b__6_0(IUnitInputPort p); // 0x000000018D4ACD58-0x000000018D4ACDB0
		[CompilerGenerated]
		private bool _get_validSource_b__8_0(IUnitOutputPort p); // 0x000000018D4ACF68-0x000000018D4ACFC0
		[CompilerGenerated]
		private bool _get_validDestination_b__10_0(IUnitInputPort p); // 0x000000018D4ACEB8-0x000000018D4ACF10
		[CompilerGenerated]
		private bool _get_sourceExists_b__12_0(IUnitOutputPort p); // 0x000000018D4ACDB0-0x000000018D4ACE08
		[CompilerGenerated]
		private bool _get_destinationExists_b__14_0(IUnitInputPort p); // 0x000000018D4ACD00-0x000000018D4ACD58
		[CompilerGenerated]
		private bool _get_validSourceExists_b__16_0(IUnitOutputPort p); // 0x000000018D4ACF10-0x000000018D4ACF68
		[CompilerGenerated]
		private bool _get_validDestinationExists_b__18_0(IUnitInputPort p); // 0x000000018D4ACE60-0x000000018D4ACEB8
	}

	public interface IUnitConnection : IConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IGraphElementWithDebugData // TypeDefIndex: 90078
	{
	}

	public interface IUnitConnectionDebugData : IGraphElementDebugData // TypeDefIndex: 90079
	{
		// Properties
		int lastInvokeFrame { set; }
		float lastInvokeTime { set; }
	}

	public interface IUnitRelation : IConnection<Unity.VisualScripting.IUnitPort, Unity.VisualScripting.IUnitPort> // TypeDefIndex: 90080
	{
	}

	public abstract class UnitConnection<TSourcePort, TDestinationPort> : GraphElement<Unity.VisualScripting.FlowGraph>, IConnection<TSourcePort, TDestinationPort> // TypeDefIndex: 90081
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

	public class UnitConnectionDebugData : IUnitConnectionDebugData // TypeDefIndex: 90082
	{
		// Fields
		[CompilerGenerated]
		private int _lastInvokeFrame_k__BackingField; // 0x10
		[CompilerGenerated]
		private float _lastInvokeTime_k__BackingField; // 0x14
		[CompilerGenerated]
		private Exception _runtimeException_k__BackingField; // 0x18
	
		// Properties
		public int lastInvokeFrame { [CompilerGenerated] set; } // 0x0000000182234E90-0x0000000182234EA0
		public float lastInvokeTime { [CompilerGenerated] set; } // 0x0000000187235C70-0x0000000187235C80
		public Exception runtimeException { [CompilerGenerated] set; } // 0x0000000187835500-0x0000000187835510
	}

	public sealed class ValueConnection : UnitConnection<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.ValueInput>, IUnitConnection // TypeDefIndex: 90084
	{
		// Properties
		public override ValueOutput source { get; } // 0x000000018D4AF5E0-0x000000018D4AF648 
		public override ValueInput destination { get; } // 0x000000018D4AF504-0x000000018D4AF56C 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get; } // 0x000000018D4AA63C-0x000000018D4AA644 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get; } // 0x000000018D4AA634-0x000000018D4AA63C 
		public override bool sourceExists { get; } // 0x000000018D4AF56C-0x000000018D4AF5E0 
		public override bool destinationExists { get; } // 0x000000018D4AF490-0x000000018D4AF504 
	
		// Nested types
		public class DebugData : UnitConnectionDebugData // TypeDefIndex: 90083
		{
			// Fields
			[CompilerGenerated]
			private object _lastValue_k__BackingField; // 0x20
			[CompilerGenerated]
			private bool _assignedLastValue_k__BackingField; // 0x28
	
			// Properties
			public object lastValue { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
			public bool assignedLastValue { [CompilerGenerated] set; } // 0x000000018225DF80-0x000000018225DF90
		}
	
		// Constructors
		public ValueConnection(ValueOutput source, ValueInput destination); // 0x000000018D4AF30C-0x000000018D4AF490
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class PortLabelHiddenAttribute : Attribute // TypeDefIndex: 90085
	{
		// Constructors
		public PortLabelHiddenAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public sealed class SpecialUnitAttribute : Attribute // TypeDefIndex: 90086
	{
		// Constructors
		public SpecialUnitAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class UnitHeaderInspectableAttribute : Attribute // TypeDefIndex: 90087
	{
		// Constructors
		public UnitHeaderInspectableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitShortTitleAttribute : Attribute // TypeDefIndex: 90088
	{
		// Fields
		[CompilerGenerated]
		private string _title_k__BackingField; // 0x10
	
		// Properties
		private string title { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public UnitShortTitleAttribute(string title); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitTitleAttribute : Attribute // TypeDefIndex: 90089
	{
		// Fields
		[CompilerGenerated]
		private string _title_k__BackingField; // 0x10
	
		// Properties
		private string title { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public UnitTitleAttribute(string title); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public sealed class Flow : IPoolable, IDisposable // TypeDefIndex: 90092
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
		public GraphStack stack { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		private MonoBehaviour coroutineRunner { [CompilerGenerated] set; } // 0x00000001870EAAD0-0x00000001870EAAE0
		private bool isCoroutine { [CompilerGenerated] set; } // 0x000000018226ECD0-0x000000018226ECE0
		public bool isPrediction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		public bool enableDebug { get; } // 0x000000018D4ACAF4-0x000000018D4ACB24 
	
		// Nested types
		private struct RecursionNode : IEquatable<RecursionNode> // TypeDefIndex: 90090
		{
			// Fields
			[CompilerGenerated]
			private readonly IUnitPort _port_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly IGraphParent _context_k__BackingField; // 0x08
	
			// Properties
			public IUnitPort port { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
			public IGraphParent context { [CompilerGenerated] [IsReadOnly] get; } // 0x00000001844AFA30-0x00000001844AFA40 
	
			// Constructors
			public RecursionNode(IUnitPort port, GraphPointer pointer); // 0x000000018D4ADFC4-0x000000018D4AE000
	
			// Methods
			public bool Equals(RecursionNode other); // 0x000000018D4ADF6C-0x000000018D4ADF84
			public override bool Equals(object obj); // 0x000000018D4ADEFC-0x000000018D4ADF6C
			public override int GetHashCode(); // 0x000000018D4ADF84-0x000000018D4ADFC4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90091
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Flow> __9__35_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D4AE1D8-0x000000018D4AE23C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Flow _New_b__35_0(); // 0x000000018D4AE000-0x000000018D4AE050
		}
	
		// Constructors
		private Flow(); // 0x000000018D4AC9A8-0x000000018D4ACAF4
	
		// Methods
		public static Flow New(GraphReference reference); // 0x000000018D4AC348-0x000000018D4AC4E8
		void IPoolable.New(); // 0x000000018D4AC960-0x000000018D4AC9A8
		public void Dispose(); // 0x000000018D4AB7FC-0x000000018D4AB8B4
		void IPoolable.Free(); // 0x000000018D4AC5A8-0x000000018D4AC960
		public void Invoke(ControlOutput output); // 0x000000018D4AC164-0x000000018D4AC348
		private RecursionNode BeforeInvoke(ControlOutput output, RecursionNode recursionNode); // 0x000000018D4AB5AC-0x000000018D4AB7FC
		private void AfterInvoke(ControlOutput output, RecursionNode recursionNode); // 0x000000018D4AB558-0x000000018D4AB5AC
		private ControlOutput InvokeDelegate(ControlInput input); // 0x000000018D4ABFF4-0x000000018D4AC164
		public object GetValue(ValueInput input); // 0x000000018D4ABD84-0x000000018D4ABF84
		private object GetValue(ValueOutput output); // 0x000000018D4AB998-0x000000018D4ABD84
		public object GetValue(ValueInput input, System.Type type); // 0x000000018D4ABF84-0x000000018D4ABFF4
		public T GetValue<T>(ValueInput input);
		public bool TryGetDefaultValue(ValueInput input, out object defaultValue); // 0x000000018D4AC4E8-0x000000018D4AC5A8
		private object GetValueDelegate(ValueOutput output); // 0x000000018D4AB8B4-0x000000018D4AB998
	}

	[System.ComponentModel.DisplayName("Script Graph")]
	[SerializationVersion("A", new System.Type[0])]
	public sealed class FlowGraph : Graph, IGraph // TypeDefIndex: 90093
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
		public GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> controlConnections { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		[DoNotSerialize]
		public GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> valueConnections { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		[DoNotSerialize]
		public GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> invalidConnections { [CompilerGenerated] get; } // 0x00000001829600D0-0x00000001829600E0 
	}

	[SerializationVersion("A", new System.Type[0])]
	[SpecialUnit]
	public abstract class EventUnit<TArgs> : Unit, IUnit // TypeDefIndex: 90094
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

	public abstract class ManualEventUnit<TArgs> : EventUnit<TArgs> // TypeDefIndex: 90095
	{
		// Properties
		protected abstract string hookName { get; }
	
		// Constructors
		protected ManualEventUnit();
	}

	[SpecialUnit]
	[UnitShortTitle("Missing Script!")]
	[UnitTitle("Node script is missing!")]
	public sealed class MissingType : Unit // TypeDefIndex: 90096
	{
		// Methods
		protected override void Definition(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IUnit : IGraphElementWithDebugData // TypeDefIndex: 90097
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

	public interface IUnitDebugData : IGraphElementDebugData // TypeDefIndex: 90098
	{
		// Properties
		int lastInvokeFrame { set; }
		float lastInvokeTime { set; }
	}

	public sealed class ControlInput : UnitPort<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ControlConnection>, IUnitInputPort // TypeDefIndex: 90101
	{
		// Fields
		internal readonly Func<Flow, ControlOutput> action; // 0x20
	
		// Properties
		public bool requiresCoroutine { get; } // 0x000000018C9D85BC-0x000000018C9D85C8 
		public override IEnumerable<ControlConnection> validConnections { get; } // 0x000000018D4AAE1C-0x000000018D4AAEA4 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018D4AAC7C-0x000000018D4AAD04 
		public override IEnumerable<ControlOutput> validConnectedPorts { get; } // 0x000000018D4AAD04-0x000000018D4AAE1C 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get; } // 0x000000018D4AAB64-0x000000018D4AAC7C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90099
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ControlConnection, ControlOutput> __9__14_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__16_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D4AE174-0x000000018D4AE1D8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ControlOutput _get_validConnectedPorts_b__14_0(ControlConnection c); // 0x000000018D4AE090-0x000000018D4AE0A8
			internal IUnitOutputPort _get_invalidConnectedPorts_b__16_0(InvalidConnection c); // 0x000000018D4AE050-0x000000018D4AE070
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 90100
		{
			// Fields
			public ControlOutput port; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ControlConnection c); // 0x000000018D4AE0E8-0x000000018D4AE110
		}
	
		// Methods
		public override bool CanConnectToValid(ControlOutput port); // 0x00000001851A4410-0x00000001851A4420
		public override void ConnectToValid(ControlOutput port); // 0x000000018D4AA90C-0x000000018D4AA9E8
		public override void ConnectToInvalid(IUnitOutputPort port); // 0x000000018D4AA8C0-0x000000018D4AA90C
		public override void DisconnectFromValid(ControlOutput port); // 0x000000018D4AAA34-0x000000018D4AAB64
		public override void DisconnectFromInvalid(IUnitOutputPort port); // 0x000000018D4AA9E8-0x000000018D4AAA34
	}

	public sealed class ControlOutput : UnitPort<Unity.VisualScripting.ControlInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ControlConnection>, IUnitOutputPort // TypeDefIndex: 90104
	{
		// Properties
		public override IEnumerable<ControlConnection> validConnections { get; } // 0x000000018D4AB4D0-0x000000018D4AB558 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018D4AB330-0x000000018D4AB3B8 
		public override IEnumerable<ControlInput> validConnectedPorts { get; } // 0x000000018D4AB3B8-0x000000018D4AB4D0 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get; } // 0x000000018D4AB218-0x000000018D4AB330 
		public ControlConnection connection { get; } // 0x000000018D4AB190-0x000000018D4AB200 
		public override bool hasValidConnection { get; } // 0x000000018D4AB200-0x000000018D4AB218 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90102
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ControlConnection, ControlInput> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D4AE23C-0x000000018D4AE2A0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ControlInput _get_validConnectedPorts_b__6_0(ControlConnection c); // 0x000000018D4AE0A8-0x000000018D4AE0C0
			internal IUnitInputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c); // 0x000000018D4AE070-0x000000018D4AE090
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 90103
		{
			// Fields
			public ControlInput port; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ControlConnection c); // 0x000000018D4AE0C0-0x000000018D4AE0E8
		}
	
		// Constructors
		public ControlOutput(string key); // 0x000000018D4AB148-0x000000018D4AB190
	
		// Methods
		public override bool CanConnectToValid(ControlInput port); // 0x00000001851A4410-0x00000001851A4420
		public override void ConnectToValid(ControlInput port); // 0x000000018D4AAEF0-0x000000018D4AAFCC
		public override void ConnectToInvalid(IUnitInputPort port); // 0x000000018D4AAEA4-0x000000018D4AAEF0
		public override void DisconnectFromValid(ControlInput port); // 0x000000018D4AB018-0x000000018D4AB148
		public override void DisconnectFromInvalid(IUnitInputPort port); // 0x000000018D4AAFCC-0x000000018D4AB018
	}

	public sealed class InvalidInput : UnitPort<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.InvalidConnection>, IUnitInputPort // TypeDefIndex: 90106
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get; } // 0x000000018D4AD990-0x000000018D4ADA18 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018D4AD848-0x000000018D4AD878 
		public override IEnumerable<IUnitOutputPort> validConnectedPorts { get; } // 0x000000018D4AD878-0x000000018D4AD990 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get; } // 0x000000018D4AD730-0x000000018D4AD848 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90105
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InvalidConnection, IUnitOutputPort> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D4AE110-0x000000018D4AE174
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal IUnitOutputPort _get_validConnectedPorts_b__6_0(InvalidConnection c); // 0x000000018D4AE050-0x000000018D4AE070
			internal IUnitOutputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c); // 0x000000018D4AE050-0x000000018D4AE070
		}
	
		// Constructors
		public InvalidInput(string key); // 0x000000018D4AD6E8-0x000000018D4AD730
	
		// Methods
		public override bool CanConnectToValid(IUnitOutputPort port); // 0x00000001843FFFF0-0x0000000184400000
		public override void ConnectToValid(IUnitOutputPort port); // 0x000000018D4AD604-0x000000018D4AD650
		public override void ConnectToInvalid(IUnitOutputPort port); // 0x000000018D4AD5B8-0x000000018D4AD604
		public override void DisconnectFromValid(IUnitOutputPort port); // 0x000000018D4AD69C-0x000000018D4AD6E8
		public override void DisconnectFromInvalid(IUnitOutputPort port); // 0x000000018D4AD650-0x000000018D4AD69C
	}

	public sealed class InvalidOutput : UnitPort<Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.InvalidConnection>, IUnitOutputPort // TypeDefIndex: 90108
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get; } // 0x000000018D4ADDF0-0x000000018D4ADE78 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018D4ADCA8-0x000000018D4ADCD8 
		public override IEnumerable<IUnitInputPort> validConnectedPorts { get; } // 0x000000018D4ADCD8-0x000000018D4ADDF0 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get; } // 0x000000018D4ADB90-0x000000018D4ADCA8 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90107
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<InvalidConnection, IUnitInputPort> __9__6_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__8_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D4AE304-0x000000018D4AE368
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal IUnitInputPort _get_validConnectedPorts_b__6_0(InvalidConnection c); // 0x000000018D4AE070-0x000000018D4AE090
			internal IUnitInputPort _get_invalidConnectedPorts_b__8_0(InvalidConnection c); // 0x000000018D4AE070-0x000000018D4AE090
		}
	
		// Constructors
		public InvalidOutput(string key); // 0x000000018D4ADB48-0x000000018D4ADB90
	
		// Methods
		public override bool CanConnectToValid(IUnitInputPort port); // 0x00000001843FFFF0-0x0000000184400000
		public override void ConnectToValid(IUnitInputPort port); // 0x000000018D4ADA64-0x000000018D4ADAB0
		public override void ConnectToInvalid(IUnitInputPort port); // 0x000000018D4ADA18-0x000000018D4ADA64
		public override void DisconnectFromValid(IUnitInputPort port); // 0x000000018D4ADAFC-0x000000018D4ADB48
		public override void DisconnectFromInvalid(IUnitInputPort port); // 0x000000018D4ADAB0-0x000000018D4ADAFC
	}

	public interface IUnitInputPort : IUnitPort // TypeDefIndex: 90109
	{
	}

	public interface IUnitOutputPort : IUnitPort // TypeDefIndex: 90110
	{
	}

	public interface IUnitPort // TypeDefIndex: 90111
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

	public interface IUnitPortCollection<TPort> : IKeyedCollection<string, TPort> // TypeDefIndex: 90112
		where TPort : IUnitPort
	{
	}

	public interface IUnitValuePort : IUnitPort // TypeDefIndex: 90113
	{
	}

	public sealed class MissingValuePortInputException : Exception // TypeDefIndex: 90114
	{
		// Constructors
		public MissingValuePortInputException(string key); // 0x000000018D4ADE78-0x000000018D4ADEFC
	}

	public abstract class UnitPort<TValidOther, TInvalidOther, TExternalConnection> : IUnitPort // TypeDefIndex: 90117
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
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 90115
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
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 90116
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

	public sealed class UnitPortCollection<TPort> : KeyedCollection<string, TPort>, IUnitPortCollection<TPort> // TypeDefIndex: 90118
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

	public sealed class ValueInput : UnitPort<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitInputPort // TypeDefIndex: 90121
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type _type_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _nullMeansSelf_k__BackingField; // 0x28
		private static readonly HashSet<System.Type> typesWithDefaultValues; // 0x00
	
		// Properties
		public System.Type type { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public override IEnumerable<ValueConnection> validConnections { get; } // 0x000000018D4B028C-0x000000018D4B0314 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018D4B00EC-0x000000018D4B0174 
		public override IEnumerable<ValueOutput> validConnectedPorts { get; } // 0x000000018D4B0174-0x000000018D4B028C 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get; } // 0x000000018D4AFFD4-0x000000018D4B00EC 
		public bool nullMeansSelf { [CompilerGenerated] get; } // 0x000000018225DF70-0x000000018225DF80 
		public ValueConnection connection { get; } // 0x000000018D4AFF4C-0x000000018D4AFFBC 
		public override bool hasValidConnection { get; } // 0x000000018D4AFFBC-0x000000018D4AFFD4 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90119
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueConnection, ValueOutput> __9__11_0; // 0x08
			public static Func<InvalidConnection, IUnitOutputPort> __9__13_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D4AE368-0x000000018D4AE3CC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ValueOutput _get_validConnectedPorts_b__11_0(ValueConnection c); // 0x000000018D4AE090-0x000000018D4AE0A8
			internal IUnitOutputPort _get_invalidConnectedPorts_b__13_0(InvalidConnection c); // 0x000000018D4AE050-0x000000018D4AE070
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 90120
		{
			// Fields
			public ValueOutput port; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ValueConnection c); // 0x000000018D4AE0E8-0x000000018D4AE110
		}
	
		// Constructors
		public ValueInput(string key, System.Type type); // 0x000000018D4AFE8C-0x000000018D4AFF4C
		static ValueInput(); // 0x000000018D4AFC14-0x000000018D4AFE8C
	
		// Methods
		public void SetDefaultValue(object value); // 0x000000018D4AF964-0x000000018D4AFAD8
		public override bool CanConnectToValid(ValueOutput port); // 0x000000018D4AF648-0x000000018D4AF6C0
		public override void ConnectToValid(ValueOutput port); // 0x000000018D4AF70C-0x000000018D4AF7E8
		public override void ConnectToInvalid(IUnitOutputPort port); // 0x000000018D4AF6C0-0x000000018D4AF70C
		public override void DisconnectFromValid(ValueOutput port); // 0x000000018D4AF834-0x000000018D4AF964
		public override void DisconnectFromInvalid(IUnitOutputPort port); // 0x000000018D4AF7E8-0x000000018D4AF834
		public static bool SupportsDefaultValue(System.Type type); // 0x000000018D4AFAD8-0x000000018D4AFC14
	}

	public sealed class ValueOutput : UnitPort<Unity.VisualScripting.ValueInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitOutputPort // TypeDefIndex: 90124
	{
		// Fields
		internal readonly Func<Flow, object> getValue; // 0x20
		[CompilerGenerated]
		private readonly System.Type _type_k__BackingField; // 0x28
	
		// Properties
		public bool supportsFetch { get; } // 0x000000018CEC4378-0x000000018CEC4384 
		public System.Type type { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		public override IEnumerable<ValueConnection> validConnections { get; } // 0x000000018D4B09EC-0x000000018D4B0A74 
		public override IEnumerable<InvalidConnection> invalidConnections { get; } // 0x000000018D4B084C-0x000000018D4B08D4 
		public override IEnumerable<ValueInput> validConnectedPorts { get; } // 0x000000018D4B08D4-0x000000018D4B09EC 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get; } // 0x000000018D4B0734-0x000000018D4B084C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90122
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueConnection, ValueInput> __9__16_0; // 0x08
			public static Func<InvalidConnection, IUnitInputPort> __9__18_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D4AE2A0-0x000000018D4AE304
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ValueInput _get_validConnectedPorts_b__16_0(ValueConnection c); // 0x000000018D4AE0A8-0x000000018D4AE0C0
			internal IUnitInputPort _get_invalidConnectedPorts_b__18_0(InvalidConnection c); // 0x000000018D4AE070-0x000000018D4AE090
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 90123
		{
			// Fields
			public ValueInput port; // 0x10
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _DisconnectFromValid_b__0(ValueConnection c); // 0x000000018D4AE0C0-0x000000018D4AE0E8
		}
	
		// Constructors
		public ValueOutput(string key, System.Type type, Func<Flow, object> getValue); // 0x000000018D4B0620-0x000000018D4B0734
	
		// Methods
		public override bool CanConnectToValid(ValueInput port); // 0x000000018D4B0314-0x000000018D4B037C
		public override void ConnectToValid(ValueInput port); // 0x000000018D4B03C8-0x000000018D4B04A4
		public override void ConnectToInvalid(IUnitInputPort port); // 0x000000018D4B037C-0x000000018D4B03C8
		public override void DisconnectFromValid(ValueInput port); // 0x000000018D4B04F0-0x000000018D4B0620
		public override void DisconnectFromInvalid(IUnitInputPort port); // 0x000000018D4B04A4-0x000000018D4B04F0
	}

	[SerializationVersion("A", new System.Type[0])]
	public abstract class Unit : GraphElement<Unity.VisualScripting.FlowGraph>, IUnit // TypeDefIndex: 90126
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
		public IUnitPortCollection<ControlInput> controlInputs { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		[DoNotSerialize]
		public IUnitPortCollection<ControlOutput> controlOutputs { [CompilerGenerated] get; } // 0x00000001829600D0-0x00000001829600E0 
		[DoNotSerialize]
		public IUnitPortCollection<ValueInput> valueInputs { [CompilerGenerated] get; } // 0x0000000182986470-0x0000000182986480 
		[DoNotSerialize]
		public IUnitPortCollection<ValueOutput> valueOutputs { [CompilerGenerated] get; } // 0x000000018226EEA0-0x000000018226EEB0 
		[DoNotSerialize]
		public IUnitPortCollection<InvalidInput> invalidInputs { [CompilerGenerated] get; } // 0x000000018226EE80-0x000000018226EE90 
		[DoNotSerialize]
		public IUnitPortCollection<InvalidOutput> invalidOutputs { [CompilerGenerated] get; } // 0x000000018226EBD0-0x000000018226EBE0 
		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> inputs { get; } // 0x000000018D4AEFFC-0x000000018D4AF0D0 
		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> outputs { get; } // 0x000000018D4AF0D0-0x000000018D4AF1A4 
		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> validInputs { get; } // 0x000000018D4AF1A4-0x000000018D4AF258 
		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> validOutputs { get; } // 0x000000018D4AF258-0x000000018D4AF30C 
		[Serialize]
		public Dictionary<string, object> defaultValues { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		[DoNotSerialize]
		private IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> relations { [CompilerGenerated] set; } // 0x0000000186B19440-0x0000000186B19450
		[DoNotSerialize]
		protected virtual bool isControlRoot { [CompilerGenerated] set; } // 0x0000000182271A30-0x0000000182271A40
		FlowGraph IUnit.graph { get; } // 0x000000018D4AEBA4-0x000000018D4AEBDC 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0<T> // TypeDefIndex: 90125
		{
			// Fields
			public Func<Flow, T> getValue;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal object _ValueOutput_b__0(Flow recursion);
		}
	
		// Constructors
		protected Unit(); // 0x000000018D4AED44-0x000000018D4AEFFC
	
		// Methods
		protected abstract void Definition();
		public void PortsChanged(); // 0x00000001892B907C-0x00000001892B908C
		protected void EnsureUniqueInput(string key); // 0x000000018D4AE93C-0x000000018D4AEA70
		protected void EnsureUniqueOutput(string key); // 0x000000018D4AEA70-0x000000018D4AEBA4
		protected ControlOutput ControlOutput(string key); // 0x000000018D4AE8A4-0x000000018D4AE93C
		protected ValueInput ValueInput(System.Type type, string key); // 0x000000018D4AEBDC-0x000000018D4AEC84
		protected ValueInput ValueInput<T>(string key);
		protected ValueInput ValueInput<T>(string key, T @default);
		protected ValueOutput ValueOutput(System.Type type, string key, Func<Flow, object> getValue); // 0x000000018D4AEC84-0x000000018D4AED44
		protected ValueOutput ValueOutput<T>(string key, Func<Flow, T> getValue);
	}

	[AttributeUsage(AttributeTargets.Class)]
	[fsObject(Converter = typeof(UnitCategoryConverter))]
	public class UnitCategory : Attribute // TypeDefIndex: 90127
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
		public string fullName { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
	
		// Constructors
		public UnitCategory(string fullName); // 0x000000018D4AE6E0-0x000000018D4AE8A4
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D4AE634-0x000000018D4AE6BC
		public override int GetHashCode(); // 0x000000018D4AE6BC-0x000000018D4AE6E0
		public override string ToString(); // 0x000000018225E800-0x000000018225E810
	}

	public class UnitCategoryConverter : fsDirectConverter // TypeDefIndex: 90128
	{
		// Properties
		public override System.Type ModelType { get; } // 0x000000018D4AE5E4-0x000000018D4AE634 
	
		// Methods
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4AE4FC-0x000000018D4AE5E4
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D4AE3CC-0x000000018D4AE4FC
	}
}
