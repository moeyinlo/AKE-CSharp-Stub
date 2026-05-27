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

// Image 84: Unity.VisualScripting.Flow.dll - Assembly: Unity.VisualScripting.Flow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59119-59172
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
	public sealed class ControlConnection : UnitConnection<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.ControlInput>, IUnitConnection // TypeDefIndex: 59120
	{
		// Properties
		public override ControlOutput source { get => default; } // 0x0000000189D77E9C-0x0000000189D77F04 
		public override ControlInput destination { get => default; } // 0x0000000189D77DC0-0x0000000189D77E28 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get => default; } // 0x0000000189D77C80-0x0000000189D77C88 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get => default; } // 0x0000000189D77C78-0x0000000189D77C80 
		public override bool sourceExists { get => default; } // 0x0000000189D77E28-0x0000000189D77E9C 
		public override bool destinationExists { get => default; } // 0x0000000189D77D4C-0x0000000189D77DC0 
	
		// Constructors
		public ControlConnection() {} // Dummy constructor
		public ControlConnection(ControlOutput source, ControlInput destination) {} // 0x0000000189D77C88-0x0000000189D77D4C
	}

	public sealed class InvalidConnection : UnitConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IUnitConnection // TypeDefIndex: 59121
	{
		// Properties
		public override IUnitOutputPort source { get => default; } // 0x0000000189D7A87C-0x0000000189D7A930 
		public override IUnitInputPort destination { get => default; } // 0x0000000189D7A714-0x0000000189D7A7C8 
		public IUnitOutputPort validSource { get => default; } // 0x0000000189D7AB4C-0x0000000189D7AC00 
		public IUnitInputPort validDestination { get => default; } // 0x0000000189D7A9E4-0x0000000189D7AA98 
		public override bool sourceExists { get => default; } // 0x0000000189D7A7C8-0x0000000189D7A87C 
		public override bool destinationExists { get => default; } // 0x0000000189D7A660-0x0000000189D7A714 
		public bool validSourceExists { get => default; } // 0x0000000189D7AA98-0x0000000189D7AB4C 
		public bool validDestinationExists { get => default; } // 0x0000000189D7A930-0x0000000189D7A9E4 
	
		// Constructors
		public InvalidConnection() {} // Dummy constructor
		public InvalidConnection(IUnitOutputPort source, IUnitInputPort destination) {} // 0x0000000189D7A608-0x0000000189D7A660
	
		// Methods
		public override bool HandleDependencies() => default; // 0x0000000189D7A16C-0x0000000189D7A348
	}

	public interface IUnitConnection : IConnection<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitInputPort>, IGraphElementWithDebugData // TypeDefIndex: 59122
	{
	}

	public interface IUnitConnectionDebugData : IGraphElementDebugData // TypeDefIndex: 59123
	{
		// Properties
		int lastInvokeFrame { get; set; }
		float lastInvokeTime { get; set; }
	}

	public interface IUnitRelation : IConnection<Unity.VisualScripting.IUnitPort, Unity.VisualScripting.IUnitPort> // TypeDefIndex: 59124
	{
	}

	public abstract class UnitConnection<TSourcePort, TDestinationPort> : GraphElement<Unity.VisualScripting.FlowGraph>, IConnection<TSourcePort, TDestinationPort> // TypeDefIndex: 59125
		where TSourcePort : class, IUnitOutputPort
		where TDestinationPort : class, IUnitInputPort
	{
		// Properties
		[Serialize]
		protected IUnit sourceUnit { get; private set; }
		[Serialize]
		protected string sourceKey { get; private set; }
		[Serialize]
		protected IUnit destinationUnit { get; private set; }
		[Serialize]
		protected string destinationKey { get; private set; }
		[DoNotSerialize]
		public abstract TSourcePort source { get; }
		[DoNotSerialize]
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

	public class UnitConnectionDebugData : IUnitConnectionDebugData // TypeDefIndex: 59126
	{
		// Properties
		public int lastInvokeFrame { get; set; } // 0x00000001810410F0-0x0000000181041100
		public float lastInvokeTime { get; set; } // 0x0000000183D51940-0x0000000183D51950
		public Exception runtimeException { get; set; } // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public UnitConnectionDebugData() {} // Dummy constructor
	}

	public sealed class ValueConnection : UnitConnection<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.ValueInput>, IUnitConnection // TypeDefIndex: 59128
	{
		// Properties
		public override ValueOutput source { get => default; } // 0x0000000189D7CC1C-0x0000000189D7CC84 
		public override ValueInput destination { get => default; } // 0x0000000189D7CB40-0x0000000189D7CBA8 
		IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.source { get => default; } // 0x0000000189D77C80-0x0000000189D77C88 
		IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.destination { get => default; } // 0x0000000189D77C78-0x0000000189D77C80 
		public override bool sourceExists { get => default; } // 0x0000000189D7CBA8-0x0000000189D7CC1C 
		public override bool destinationExists { get => default; } // 0x0000000189D7CACC-0x0000000189D7CB40 
	
		// Nested types
		public class DebugData : UnitConnectionDebugData // TypeDefIndex: 59127
		{
			// Properties
			public object lastValue { get; set; } // 0x0000000184271930-0x0000000184271940
			public bool assignedLastValue { get; set; } // 0x0000000183D4ED60-0x0000000183D4ED70
	
			// Constructors
			public DebugData() {} // Dummy constructor
		}
	
		// Constructors
		public ValueConnection() {} // Dummy constructor
		public ValueConnection(ValueOutput source, ValueInput destination) {} // 0x0000000189D7C948-0x0000000189D7CACC
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class PortLabelHiddenAttribute : Attribute // TypeDefIndex: 59129
	{
		// Constructors
		public PortLabelHiddenAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public sealed class SpecialUnitAttribute : Attribute // TypeDefIndex: 59130
	{
		// Constructors
		public SpecialUnitAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class UnitHeaderInspectableAttribute : Attribute // TypeDefIndex: 59131
	{
		// Constructors
		public UnitHeaderInspectableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitShortTitleAttribute : Attribute // TypeDefIndex: 59132
	{
		// Properties
		private string title { get; set; } // 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public UnitShortTitleAttribute() {} // Dummy constructor
		public UnitShortTitleAttribute(string title) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class UnitTitleAttribute : Attribute // TypeDefIndex: 59133
	{
		// Properties
		private string title { get; set; } // 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public UnitTitleAttribute() {} // Dummy constructor
		public UnitTitleAttribute(string title) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public sealed class Flow : IPoolable, IDisposable // TypeDefIndex: 59136
	{
		// Fields
		private Recursion<RecursionNode> recursion; // 0x18
		private readonly Dictionary<IUnitValuePort, object> locals; // 0x20
		public readonly VariableDeclarations variables; // 0x28
		private readonly Stack<int> loops; // 0x30
		private readonly HashSet<GraphStack> preservedStacks; // 0x38
		private ICollection<Flow> activeCoroutinesRegistry; // 0x48
		private bool coroutineStopRequested; // 0x50
		private IEnumerator coroutineEnumerator; // 0x58
		private bool disposed; // 0x61
		public int loopIdentifier; // 0x64
	
		// Properties
		public GraphStack stack { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		private MonoBehaviour coroutineRunner { get; set; } // 0x0000000183CB2D80-0x0000000183CB2D90
		private bool isCoroutine { get; set; } // 0x0000000183D51900-0x0000000183D51910
		public bool isPrediction { get; private set; } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183D519B0-0x0000000183D519C0
		public bool enableDebug { get => default; } // 0x0000000189D7A13C-0x0000000189D7A16C 
	
		// Nested types
		private struct RecursionNode : IEquatable<RecursionNode> // TypeDefIndex: 59134
		{
			// Properties
			public IUnitPort port { [IsReadOnly] get; } // 0x00000001820C61B0-0x00000001820C61C0 
			public IGraphParent context { [IsReadOnly] get; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
			// Constructors
			public RecursionNode(IUnitPort port, GraphPointer pointer) : this() {} // 0x0000000189D7B60C-0x0000000189D7B648
	
			// Methods
			public bool Equals(RecursionNode other) => default; // 0x0000000189D7B5B4-0x0000000189D7B5CC
			public override bool Equals(object obj) => default; // 0x0000000189D7B544-0x0000000189D7B5B4
			public override int GetHashCode() => default; // 0x0000000189D7B5CC-0x0000000189D7B60C
		}
	
		// Constructors
		private Flow() {} // 0x0000000189D79FF0-0x0000000189D7A13C
	
		// Methods
		public static Flow New(GraphReference reference) => default; // 0x0000000189D799A4-0x0000000189D79B44
		void IPoolable.New() {} // 0x0000000189D79FA8-0x0000000189D79FF0
		public void Dispose() {} // 0x0000000189D78E40-0x0000000189D78EF8
		void IPoolable.Free() {} // 0x0000000189D79C04-0x0000000189D79FA8
		public void Invoke(ControlOutput output) {} // 0x0000000189D797A8-0x0000000189D799A4
		private RecursionNode BeforeInvoke(ControlOutput output, RecursionNode recursionNode) => default; // 0x0000000189D78BF0-0x0000000189D78E40
		private void AfterInvoke(ControlOutput output, RecursionNode recursionNode) {} // 0x0000000189D78B9C-0x0000000189D78BF0
		private ControlOutput InvokeDelegate(ControlInput input) => default; // 0x0000000189D79638-0x0000000189D797A8
		public object GetValue(ValueInput input) => default; // 0x0000000189D793CC-0x0000000189D795C8
		private object GetValue(ValueOutput output) => default; // 0x0000000189D78FDC-0x0000000189D793CC
		public object GetValue(ValueInput input, System.Type type) => default; // 0x0000000189D795C8-0x0000000189D79638
		public T GetValue<T>(ValueInput input) => default;
		public bool TryGetDefaultValue(ValueInput input, out object defaultValue) {
			defaultValue = default;
			return default;
		} // 0x0000000189D79B44-0x0000000189D79C04
		private object GetValueDelegate(ValueOutput output) => default; // 0x0000000189D78EF8-0x0000000189D78FDC
	}

	[System.ComponentModel.DisplayName("Script Graph")]
	[SerializationVersion("A", new System.Type[0])]
	public sealed class FlowGraph : Graph, IGraph // TypeDefIndex: 59137
	{
		// Properties
		[DoNotSerialize]
		public GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> controlConnections { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DoNotSerialize]
		public GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> valueConnections { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DoNotSerialize]
		public GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> invalidConnections { get; } // 0x0000000181003830-0x0000000181003840 
	
		// Constructors
		public FlowGraph() {} // Dummy constructor
	}

	[SerializationVersion("A", new System.Type[0])]
	[SpecialUnit]
	public abstract class EventUnit<TArgs> : Unit, IUnit // TypeDefIndex: 59138
	{
		// Properties
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlOutput trigger { get; private set; }
		new FlowGraph IUnit.graph { get; }
	
		// Constructors
		protected EventUnit() {}
	
		// Methods
		protected override void Definition() {}
	}

	public abstract class ManualEventUnit<TArgs> : EventUnit<TArgs> // TypeDefIndex: 59139
	{
		// Properties
		protected abstract string hookName { get; }
	
		// Constructors
		protected ManualEventUnit() {}
	}

	[SpecialUnit]
	[UnitShortTitle("Missing Script!")]
	[UnitTitle("Node script is missing!")]
	public sealed class MissingType : Unit // TypeDefIndex: 59140
	{
		// Constructors
		public MissingType() {} // Dummy constructor
	
		// Methods
		protected override void Definition() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IUnit : IGraphElementWithDebugData // TypeDefIndex: 59141
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

	public interface IUnitDebugData : IGraphElementDebugData // TypeDefIndex: 59142
	{
		// Properties
		int lastInvokeFrame { get; set; }
		float lastInvokeTime { get; set; }
	}

	public sealed class ControlInput : UnitPort<Unity.VisualScripting.ControlOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ControlConnection>, IUnitInputPort // TypeDefIndex: 59145
	{
		// Fields
		internal readonly Func<Flow, ControlOutput> action; // 0x20
	
		// Properties
		public bool requiresCoroutine { get => default; } // 0x00000001892233D8-0x00000001892233E4 
		public override IEnumerable<ControlConnection> validConnections { get => default; } // 0x0000000189D78460-0x0000000189D784E8 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x0000000189D782C0-0x0000000189D78348 
		public override IEnumerable<ControlOutput> validConnectedPorts { get => default; } // 0x0000000189D78348-0x0000000189D78460 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get => default; } // 0x0000000189D781A8-0x0000000189D782C0 
	
		// Constructors
		public ControlInput() {} // Dummy constructor
	
		// Methods
		public override bool CanConnectToValid(ControlOutput port) => default; // 0x000000018232EB60-0x000000018232EB70
		public override void ConnectToValid(ControlOutput port) {} // 0x0000000189D77F50-0x0000000189D7802C
		public override void ConnectToInvalid(IUnitOutputPort port) {} // 0x0000000189D77F04-0x0000000189D77F50
		public override void DisconnectFromValid(ControlOutput port) {} // 0x0000000189D78078-0x0000000189D781A8
		public override void DisconnectFromInvalid(IUnitOutputPort port) {} // 0x0000000189D7802C-0x0000000189D78078
	}

	public sealed class ControlOutput : UnitPort<Unity.VisualScripting.ControlInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ControlConnection>, IUnitOutputPort // TypeDefIndex: 59148
	{
		// Properties
		public override IEnumerable<ControlConnection> validConnections { get => default; } // 0x0000000189D78B14-0x0000000189D78B9C 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x0000000189D78974-0x0000000189D789FC 
		public override IEnumerable<ControlInput> validConnectedPorts { get => default; } // 0x0000000189D789FC-0x0000000189D78B14 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get => default; } // 0x0000000189D7885C-0x0000000189D78974 
		public ControlConnection connection { get => default; } // 0x0000000189D787D4-0x0000000189D78844 
		public override bool hasValidConnection { get => default; } // 0x0000000189D78844-0x0000000189D7885C 
	
		// Constructors
		public ControlOutput() {} // Dummy constructor
		public ControlOutput(string key) {} // 0x0000000189D7878C-0x0000000189D787D4
	
		// Methods
		public override bool CanConnectToValid(ControlInput port) => default; // 0x000000018232EB60-0x000000018232EB70
		public override void ConnectToValid(ControlInput port) {} // 0x0000000189D78534-0x0000000189D78610
		public override void ConnectToInvalid(IUnitInputPort port) {} // 0x0000000189D784E8-0x0000000189D78534
		public override void DisconnectFromValid(ControlInput port) {} // 0x0000000189D7865C-0x0000000189D7878C
		public override void DisconnectFromInvalid(IUnitInputPort port) {} // 0x0000000189D78610-0x0000000189D7865C
	}

	public sealed class InvalidInput : UnitPort<Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.InvalidConnection>, IUnitInputPort // TypeDefIndex: 59150
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get => default; } // 0x0000000189D7AFD8-0x0000000189D7B060 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x0000000189D7AE90-0x0000000189D7AEC0 
		public override IEnumerable<IUnitOutputPort> validConnectedPorts { get => default; } // 0x0000000189D7AEC0-0x0000000189D7AFD8 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get => default; } // 0x0000000189D7AD78-0x0000000189D7AE90 
	
		// Constructors
		public InvalidInput() {} // Dummy constructor
		public InvalidInput(string key) {} // 0x0000000189D7AD30-0x0000000189D7AD78
	
		// Methods
		public override bool CanConnectToValid(IUnitOutputPort port) => default; // 0x000000018115F4C0-0x000000018115F530
		public override void ConnectToValid(IUnitOutputPort port) {} // 0x0000000189D7AC4C-0x0000000189D7AC98
		public override void ConnectToInvalid(IUnitOutputPort port) {} // 0x0000000189D7AC00-0x0000000189D7AC4C
		public override void DisconnectFromValid(IUnitOutputPort port) {} // 0x0000000189D7ACE4-0x0000000189D7AD30
		public override void DisconnectFromInvalid(IUnitOutputPort port) {} // 0x0000000189D7AC98-0x0000000189D7ACE4
	}

	public sealed class InvalidOutput : UnitPort<Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.InvalidConnection>, IUnitOutputPort // TypeDefIndex: 59152
	{
		// Properties
		public override IEnumerable<InvalidConnection> validConnections { get => default; } // 0x0000000189D7B438-0x0000000189D7B4C0 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x0000000189D7B2F0-0x0000000189D7B320 
		public override IEnumerable<IUnitInputPort> validConnectedPorts { get => default; } // 0x0000000189D7B320-0x0000000189D7B438 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get => default; } // 0x0000000189D7B1D8-0x0000000189D7B2F0 
	
		// Constructors
		public InvalidOutput() {} // Dummy constructor
		public InvalidOutput(string key) {} // 0x0000000189D7B190-0x0000000189D7B1D8
	
		// Methods
		public override bool CanConnectToValid(IUnitInputPort port) => default; // 0x000000018115F4C0-0x000000018115F530
		public override void ConnectToValid(IUnitInputPort port) {} // 0x0000000189D7B0AC-0x0000000189D7B0F8
		public override void ConnectToInvalid(IUnitInputPort port) {} // 0x0000000189D7B060-0x0000000189D7B0AC
		public override void DisconnectFromValid(IUnitInputPort port) {} // 0x0000000189D7B144-0x0000000189D7B190
		public override void DisconnectFromInvalid(IUnitInputPort port) {} // 0x0000000189D7B0F8-0x0000000189D7B144
	}

	public interface IUnitInputPort : IUnitPort // TypeDefIndex: 59153
	{
	}

	public interface IUnitOutputPort : IUnitPort // TypeDefIndex: 59154
	{
	}

	public interface IUnitPort // TypeDefIndex: 59155
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

	public interface IUnitPortCollection<TPort> : IKeyedCollection<string, TPort> // TypeDefIndex: 59156
		where TPort : IUnitPort
	{
	}

	public interface IUnitValuePort : IUnitPort // TypeDefIndex: 59157
	{
	}

	public sealed class MissingValuePortInputException : Exception // TypeDefIndex: 59158
	{
		// Constructors
		public MissingValuePortInputException() {} // Dummy constructor
		public MissingValuePortInputException(string key) {} // 0x0000000189D7B4C0-0x0000000189D7B544
	}

	public abstract class UnitPort<TValidOther, TInvalidOther, TExternalConnection> : IUnitPort // TypeDefIndex: 59161
		where TValidOther : IUnitPort
		where TInvalidOther : IUnitPort
		where TExternalConnection : IUnitConnection
	{
		// Properties
		public IUnit unit { get; set; }
		public string key { get; }
		public abstract IEnumerable<TExternalConnection> validConnections { get; }
		public abstract IEnumerable<InvalidConnection> invalidConnections { get; }
		public abstract IEnumerable<TValidOther> validConnectedPorts { get; }
		public abstract IEnumerable<TInvalidOther> invalidConnectedPorts { get; }
		public virtual bool hasValidConnection { get; }
	
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

	public sealed class UnitPortCollection<TPort> : KeyedCollection<string, TPort>, IUnitPortCollection<TPort> // TypeDefIndex: 59162
		where TPort : IUnitPort
	{
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

	public sealed class ValueInput : UnitPort<Unity.VisualScripting.ValueOutput, Unity.VisualScripting.IUnitOutputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitInputPort // TypeDefIndex: 59165
	{
		// Fields
		private static readonly HashSet<System.Type> typesWithDefaultValues; // 0x00
	
		// Properties
		public System.Type type { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public override IEnumerable<ValueConnection> validConnections { get => default; } // 0x0000000189D7D8D0-0x0000000189D7D958 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x0000000189D7D730-0x0000000189D7D7B8 
		public override IEnumerable<ValueOutput> validConnectedPorts { get => default; } // 0x0000000189D7D7B8-0x0000000189D7D8D0 
		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts { get => default; } // 0x0000000189D7D618-0x0000000189D7D730 
		public bool nullMeansSelf { get; } // 0x0000000183D4ED50-0x0000000183D4ED60 
		public ValueConnection connection { get => default; } // 0x0000000189D7D590-0x0000000189D7D600 
		public override bool hasValidConnection { get => default; } // 0x0000000189D7D600-0x0000000189D7D618 
	
		// Constructors
		public ValueInput() {} // Dummy constructor
		public ValueInput(string key, System.Type type) {} // 0x0000000189D7D4D0-0x0000000189D7D590
		static ValueInput() {} // 0x0000000189D7D258-0x0000000189D7D4D0
	
		// Methods
		public void SetDefaultValue(object value) {} // 0x0000000189D7CFA0-0x0000000189D7D11C
		public override bool CanConnectToValid(ValueOutput port) => default; // 0x0000000189D7CC84-0x0000000189D7CCFC
		public override void ConnectToValid(ValueOutput port) {} // 0x0000000189D7CD48-0x0000000189D7CE24
		public override void ConnectToInvalid(IUnitOutputPort port) {} // 0x0000000189D7CCFC-0x0000000189D7CD48
		public override void DisconnectFromValid(ValueOutput port) {} // 0x0000000189D7CE70-0x0000000189D7CFA0
		public override void DisconnectFromInvalid(IUnitOutputPort port) {} // 0x0000000189D7CE24-0x0000000189D7CE70
		public static bool SupportsDefaultValue(System.Type type) => default; // 0x0000000189D7D11C-0x0000000189D7D258
	}

	public sealed class ValueOutput : UnitPort<Unity.VisualScripting.ValueInput, Unity.VisualScripting.IUnitInputPort, Unity.VisualScripting.ValueConnection>, IUnitValuePort, IUnitOutputPort // TypeDefIndex: 59168
	{
		// Fields
		internal readonly Func<Flow, object> getValue; // 0x20
	
		// Properties
		public bool supportsFetch { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		public System.Type type { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override IEnumerable<ValueConnection> validConnections { get => default; } // 0x0000000189D7E030-0x0000000189D7E0B8 
		public override IEnumerable<InvalidConnection> invalidConnections { get => default; } // 0x0000000189D7DE90-0x0000000189D7DF18 
		public override IEnumerable<ValueInput> validConnectedPorts { get => default; } // 0x0000000189D7DF18-0x0000000189D7E030 
		public override IEnumerable<IUnitInputPort> invalidConnectedPorts { get => default; } // 0x0000000189D7DD78-0x0000000189D7DE90 
	
		// Constructors
		public ValueOutput() {} // Dummy constructor
		public ValueOutput(string key, System.Type type, Func<Flow, object> getValue) {} // 0x0000000189D7DC64-0x0000000189D7DD78
	
		// Methods
		public override bool CanConnectToValid(ValueInput port) => default; // 0x0000000189D7D958-0x0000000189D7D9C0
		public override void ConnectToValid(ValueInput port) {} // 0x0000000189D7DA0C-0x0000000189D7DAE8
		public override void ConnectToInvalid(IUnitInputPort port) {} // 0x0000000189D7D9C0-0x0000000189D7DA0C
		public override void DisconnectFromValid(ValueInput port) {} // 0x0000000189D7DB34-0x0000000189D7DC64
		public override void DisconnectFromInvalid(IUnitInputPort port) {} // 0x0000000189D7DAE8-0x0000000189D7DB34
	}

	[SerializationVersion("A", new System.Type[0])]
	public abstract class Unit : GraphElement<Unity.VisualScripting.FlowGraph>, IUnit // TypeDefIndex: 59170
	{
		// Properties
		[DoNotSerialize]
		public IUnitPortCollection<ControlInput> controlInputs { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DoNotSerialize]
		public IUnitPortCollection<ControlOutput> controlOutputs { get; } // 0x0000000181003830-0x0000000181003840 
		[DoNotSerialize]
		public IUnitPortCollection<ValueInput> valueInputs { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[DoNotSerialize]
		public IUnitPortCollection<ValueOutput> valueOutputs { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[DoNotSerialize]
		public IUnitPortCollection<InvalidInput> invalidInputs { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		[DoNotSerialize]
		public IUnitPortCollection<InvalidOutput> invalidOutputs { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> inputs { get; } // 0x0000000189D7C638-0x0000000189D7C70C 
		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> outputs { get; } // 0x0000000189D7C70C-0x0000000189D7C7E0 
		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> validInputs { get; } // 0x0000000189D7C7E0-0x0000000189D7C894 
		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> validOutputs { get; } // 0x0000000189D7C894-0x0000000189D7C948 
		[Serialize]
		public Dictionary<string, object> defaultValues { get; private set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		[DoNotSerialize]
		private IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> relations { get; set; } // 0x00000001838C5570-0x00000001838C5580
		[DoNotSerialize]
		protected virtual bool isControlRoot { get; set; } // 0x0000000183D4F290-0x0000000183D4F2A0
		FlowGraph IUnit.graph { get; } // 0x0000000189D7C1EC-0x0000000189D7C224 
	
		// Constructors
		protected Unit() {} // 0x0000000189D7C388-0x0000000189D7C638
	
		// Methods
		protected abstract void Definition();
		public void PortsChanged() {} // 0x0000000185DA555C-0x0000000185DA556C
		protected void EnsureUniqueInput(string key) {} // 0x0000000189D7BF84-0x0000000189D7C0B8
		protected void EnsureUniqueOutput(string key) {} // 0x0000000189D7C0B8-0x0000000189D7C1EC
		protected ControlOutput ControlOutput(string key) => default; // 0x0000000189D7BEEC-0x0000000189D7BF84
		protected ValueInput ValueInput(System.Type type, string key) => default; // 0x0000000189D7C224-0x0000000189D7C2CC
		protected ValueInput ValueInput<T>(string key) => default;
		protected ValueInput ValueInput<T>(string key, T @default) => default;
		protected ValueOutput ValueOutput(System.Type type, string key, Func<Flow, object> getValue) => default; // 0x0000000189D7C2CC-0x0000000189D7C388
		protected ValueOutput ValueOutput<T>(string key, Func<Flow, T> getValue) => default;
	}

	[AttributeUsage(AttributeTargets.Class)]
	[fsObject(Converter = typeof(UnitCategoryConverter))]
	public class UnitCategory : Attribute // TypeDefIndex: 59171
	{
		// Properties
		public string fullName { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public UnitCategory() {} // Dummy constructor
		public UnitCategory(string fullName) {} // 0x0000000189D7BD28-0x0000000189D7BEEC
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189D7BC7C-0x0000000189D7BD04
		public override int GetHashCode() => default; // 0x0000000189D7BD04-0x0000000189D7BD28
		public override string ToString() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
	}

	public class UnitCategoryConverter : fsDirectConverter // TypeDefIndex: 59172
	{
		// Properties
		public override System.Type ModelType { get => default; } // 0x0000000189D7BC2C-0x0000000189D7BC7C 
	
		// Constructors
		public UnitCategoryConverter() {} // Dummy constructor
	
		// Methods
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D7BB44-0x0000000189D7BC2C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D7BA14-0x0000000189D7BB44
	}
}
