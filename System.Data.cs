/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

// Image 19: System.Data.dll - Assembly: System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 49925-50154
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Data.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Data.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Data.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("System.Web, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: InternalsVisibleTo("System.Design, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

internal static class SR // TypeDefIndex: 49926
{
	// Methods
	internal static string GetString(string name) => default; // 0x000000018339AE90-0x000000018339AEA0
	internal static string Format(string resourceFormat, object p1) => default; // 0x000000018976B7EC-0x000000018976B848
	internal static string Format(string resourceFormat, object p1, object p2) => default; // 0x000000018976B77C-0x000000018976B7EC
	internal static string Format(string resourceFormat, object p1, object p2, object p3) => default; // 0x000000018976B6FC-0x000000018976B77C
}

namespace System.Data
{
	public enum AcceptRejectRule // TypeDefIndex: 49927
	{
		None = 0,
		Cascade = 1
	}

	internal enum AggregateType // TypeDefIndex: 49928
	{
		None = 0,
		Sum = 4,
		Mean = 5,
		Min = 6,
		Max = 7,
		First = 8,
		Count = 9,
		Var = 10,
		StDev = 11
	}

	public class InternalDataCollectionBase : ICollection // TypeDefIndex: 49929
	{
		// Fields
		internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x00
	
		// Properties
		[Browsable(false)]
		public virtual int Count { get => default; } // 0x000000018976B4BC-0x000000018976B4E4 
		[Browsable(false)]
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		[Browsable(false)]
		public object SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		protected virtual ArrayList List { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public InternalDataCollectionBase() {} // 0x000000018350B670-0x000000018350B680
		static InternalDataCollectionBase() {} // 0x000000018976B438-0x000000018976B4BC
	
		// Methods
		public virtual void CopyTo(Array ar, int index) {} // 0x000000018976B324-0x000000018976B364
		public virtual IEnumerator GetEnumerator() => default; // 0x000000018976B364-0x000000018976B38C
		internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) => default; // 0x000000018976B38C-0x000000018976B438
	}

	internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 49930
	{
		// Fields
		private static readonly System.Type[] s_types; // 0x00
		private StandardValuesCollection _values; // 0x10
	
		// Constructors
		public ColumnTypeConverter() {} // 0x000000018350B670-0x000000018350B680
		static ColumnTypeConverter() {} // 0x0000000189756E00-0x0000000189757644
	
		// Methods
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x0000000189756694-0x0000000189756728
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001897568D4-0x0000000189756CDC
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189756600-0x0000000189756694
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189756728-0x00000001897568D4
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x0000000189756CDC-0x0000000189756E00
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	[EventSource(Name = "System.Data.DataCommonEventSource")]
	internal class DataCommonEventSource : EventSource // TypeDefIndex: 49931
	{
		// Fields
		internal static readonly DataCommonEventSource Log; // 0x00
		private static long s_nextScopeId; // 0x08
	
		// Constructors
		public DataCommonEventSource() {} // 0x0000000184277134-0x000000018427713C
		static DataCommonEventSource() {} // 0x0000000189762810-0x0000000189762894
	
		// Methods
		[Event(1, Level = EventLevel.Informational)]
		internal void Trace(string message) {} // 0x0000000189762800-0x0000000189762810
		[NonEvent]
		internal void Trace<T0>(string format, T0 arg0) {}
		[NonEvent]
		internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) {}
		[NonEvent]
		internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) {}
		[NonEvent]
		internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		[NonEvent]
		internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		[NonEvent]
		internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
		[Event(2, Level = EventLevel.Verbose)]
		internal long EnterScope(string message) => default; // 0x0000000189762794-0x00000001897627F0
		[NonEvent]
		internal long EnterScope<T1>(string format, T1 arg1) => default;
		[NonEvent]
		internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) => default;
		[NonEvent]
		internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) => default;
		[NonEvent]
		internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		[Event(3, Level = EventLevel.Verbose)]
		internal void ExitScope(long scopeId) {} // 0x00000001897627F0-0x0000000189762800
	}

	[DefaultProperty("ConstraintName")]
	[TypeConverter(typeof(ConstraintConverter))]
	public abstract class Constraint // TypeDefIndex: 49932
	{
		// Fields
		private string _schemaName; // 0x10
		private bool _inCollection; // 0x18
		private DataSet _dataSet; // 0x20
		internal string _name; // 0x28
		internal PropertyCollection _extendedProperties; // 0x30
	
		// Properties
		[DefaultValue("")]
		public virtual string ConstraintName { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000189759EC4-0x000000018975A05C
		internal string SchemaName { get; set; } // 0x0000000189759EB0-0x0000000189759EC4 0x000000018975A0A0-0x000000018975A0BC
		internal virtual bool InCollection { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x000000018975A05C-0x000000018975A0A0
		public abstract DataTable Table { get; }
		[Browsable(false)]
		public PropertyCollection ExtendedProperties { get; } // 0x0000000189759E3C-0x0000000189759EB0 
		[CLSCompliant(false)]
		protected virtual DataSet _DataSet { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		protected Constraint() {} // 0x0000000189759DD4-0x0000000189759E3C
	
		// Methods
		internal abstract bool ContainsColumn(DataColumn column);
		internal abstract bool CanEnableConstraint();
		internal abstract Constraint Clone(DataSet destination);
		internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);
		internal void CheckConstraint() {} // 0x0000000189759C70-0x0000000189759CB8
		internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);
		internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);
		internal abstract void CheckConstraint(DataRow row, DataRowAction action);
		internal abstract void CheckState();
		protected void CheckStateForProperty() {} // 0x0000000189759CB8-0x0000000189759DD4
		internal abstract bool IsConstraintViolated();
		public override string ToString() => default; // 0x0000000183D4EAC0-0x0000000183D4EAD0
	}

	[DefaultEvent("CollectionChanged")]
	public sealed class ConstraintCollection : InternalDataCollectionBase // TypeDefIndex: 49933
	{
		// Fields
		private readonly DataTable _table; // 0x10
		private readonly ArrayList _list; // 0x18
		private int _defaultNameIndex; // 0x20
		private CollectionChangeEventHandler _onCollectionChanged; // 0x28
		private System.Data.Constraint[] _delayLoadingConstraints; // 0x30
		private bool _fLoadForeignKeyConstraintsOnly; // 0x38
	
		// Properties
		protected override ArrayList List { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public System.Data.Constraint this[int index] { get => default; } // 0x00000001897590A0-0x0000000189759150 
		internal DataTable Table { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public System.Data.Constraint this[string name] { get => default; } // 0x0000000189759150-0x0000000189759208 
	
		// Constructors
		public ConstraintCollection() {} // Dummy constructor
		internal ConstraintCollection(DataTable table) {} // 0x0000000189759000-0x00000001897590A0
	
		// Methods
		public void Add(System.Data.Constraint constraint) {} // 0x000000018975777C-0x0000000189757788
		internal void Add(System.Data.Constraint constraint, bool addUniqueWhenAddingForeign) {} // 0x000000018975783C-0x0000000189757C44
		public System.Data.Constraint Add(string name, DataColumn[] columns, bool primaryKey) => default; // 0x0000000189757788-0x000000018975783C
		private void AddUniqueConstraint(UniqueConstraint constraint) {} // 0x00000001897576B8-0x000000018975777C
		private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) {} // 0x0000000189757644-0x00000001897576B8
		private bool AutoGenerated(System.Data.Constraint constraint) => default; // 0x0000000189757CCC-0x0000000189757D44
		private void ArrayAdd(System.Data.Constraint constraint) {} // 0x0000000189757C44-0x0000000189757C78
		private void ArrayRemove(System.Data.Constraint constraint) {} // 0x0000000189757C78-0x0000000189757CAC
		internal string AssignName() => default; // 0x0000000189757CAC-0x0000000189757CCC
		private void BaseAdd(System.Data.Constraint constraint) {} // 0x0000000189757D44-0x0000000189757DD0
		private void BaseGroupSwitch(System.Data.Constraint[] oldArray, int oldLength, System.Data.Constraint[] newArray, int newLength) {} // 0x0000000189757DD0-0x0000000189757F48
		private void BaseRemove(System.Data.Constraint constraint) {} // 0x0000000189757F48-0x0000000189758198
		internal bool CanRemove(System.Data.Constraint constraint, bool fThrowException) => default; // 0x0000000189758198-0x00000001897581F4
		public void Clear() {} // 0x00000001897581F4-0x0000000189758594
		public bool Contains(string name) => default; // 0x0000000189758604-0x000000018975861C
		internal bool Contains(string name, bool caseSensitive) => default; // 0x000000018975861C-0x00000001897586DC
		internal System.Data.Constraint FindConstraint(System.Data.Constraint constraint) => default; // 0x00000001897586DC-0x00000001897587EC
		internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) => default; // 0x00000001897588EC-0x00000001897589C4
		internal UniqueConstraint FindKeyConstraint(DataColumn column) => default; // 0x00000001897589C4-0x0000000189758A88
		internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) => default; // 0x00000001897587EC-0x00000001897588EC
		private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) => default; // 0x0000000189758594-0x0000000189758604
		internal int InternalIndexOf(string constraintName) => default; // 0x0000000189758A88-0x0000000189758BB0
		private string MakeName(int index) => default; // 0x0000000189758BB0-0x0000000189758C3C
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent) {} // 0x0000000189758C3C-0x0000000189758C58
		internal void RegisterName(string name) {} // 0x0000000189758C58-0x0000000189758E28
		public void Remove(System.Data.Constraint constraint) {} // 0x0000000189758E28-0x0000000189758F78
		internal void UnregisterName(string name) {} // 0x0000000189758F78-0x0000000189759000
	}

	internal sealed class ConstraintConverter : ExpandableObjectConverter // TypeDefIndex: 49934
	{
		// Constructors
		public ConstraintConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x0000000189759208-0x000000018975929C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x000000018975929C-0x00000001897599FC
	}

	internal class ConstraintEnumerator // TypeDefIndex: 49935
	{
		// Fields
		private IEnumerator _tables; // 0x10
		private IEnumerator _constraints; // 0x18
		private System.Data.Constraint _currentObject; // 0x20
	
		// Properties
		protected System.Data.Constraint CurrentObject { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public ConstraintEnumerator() {} // Dummy constructor
		public ConstraintEnumerator(DataSet dataSet) {} // 0x0000000189759BBC-0x0000000189759C0C
	
		// Methods
		public bool GetNext() => default; // 0x00000001897599FC-0x0000000189759BBC
		public System.Data.Constraint GetConstraint() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		protected virtual bool IsValidCandidate(System.Data.Constraint constraint) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator // TypeDefIndex: 49936
	{
		// Constructors
		public ForeignKeyConstraintEnumerator() {} // Dummy constructor
		public ForeignKeyConstraintEnumerator(DataSet dataSet) {} // 0x000000018976B2B8-0x000000018976B2C0
	
		// Methods
		protected override bool IsValidCandidate(System.Data.Constraint constraint) => default; // 0x000000018976B278-0x000000018976B2B8
		public ForeignKeyConstraint GetForeignKeyConstraint() => default; // 0x000000018976B23C-0x000000018976B278
	}

	internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 49937
	{
		// Fields
		private readonly DataTable _table; // 0x28
	
		// Constructors
		public ChildForeignKeyConstraintEnumerator() {} // Dummy constructor
		public ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) {} // 0x00000001897565D0-0x0000000189756600
	
		// Methods
		protected override bool IsValidCandidate(System.Data.Constraint constraint) => default; // 0x0000000189756548-0x00000001897565D0
	}

	internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 49938
	{
		// Fields
		private readonly DataTable _table; // 0x28
	
		// Constructors
		public ParentForeignKeyConstraintEnumerator() {} // Dummy constructor
		public ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) {} // 0x00000001897565D0-0x0000000189756600
	
		// Methods
		protected override bool IsValidCandidate(System.Data.Constraint constraint) => default; // 0x000000018976B5AC-0x000000018976B634
	}

	[DefaultProperty("ColumnName")]
	[DesignTimeVisible(false)]
	[ToolboxItem(false)]
	public class DataColumn : MarshalByValueComponent // TypeDefIndex: 49939
	{
		// Fields
		private bool _allowNull; // 0x20
		private string _caption; // 0x28
		private string _columnName; // 0x30
		private System.Type _dataType; // 0x38
		private StorageType _storageType; // 0x40
		internal object _defaultValue; // 0x48
		private DataSetDateTime _dateTimeMode; // 0x50
		private DataExpression _expression; // 0x58
		private int _maxLength; // 0x60
		private int _ordinal; // 0x64
		private bool _readOnly; // 0x68
		internal Index _sortIndex; // 0x70
		internal DataTable _table; // 0x78
		private bool _unique; // 0x80
		internal MappingType _columnMapping; // 0x84
		internal int _hashCode; // 0x88
		internal int _errors; // 0x8C
		private bool _isSqlType; // 0x90
		private bool _implementsINullable; // 0x91
		private bool _implementsIChangeTracking; // 0x92
		private bool _implementsIRevertibleChangeTracking; // 0x93
		private bool _implementsIXMLSerializable; // 0x94
		private bool _defaultValueIsNull; // 0x95
		internal List<DataColumn> _dependentColumns; // 0x98
		internal PropertyCollection _extendedProperties; // 0xA0
		private DataStorage _storage; // 0xA8
		private AutoIncrementValue _autoInc; // 0xB0
		internal string _columnUri; // 0xB8
		private string _columnPrefix; // 0xC0
		internal string _encodedColumnName; // 0xC8
		internal SimpleType _simpleType; // 0xD0
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0xD8
	
		// Properties
		[DefaultValue(true)]
		public bool AllowDBNull { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x000000018975F9D0-0x000000018975FB28
		[DefaultValue(false)]
		[RefreshProperties(RefreshProperties.All)]
		public bool AutoIncrement { get => default; set {} } // 0x000000018975F4A8-0x000000018975F4C4 0x000000018975FDA8-0x000000018975FF6C
		internal object AutoIncrementCurrent { get => default; set {} } // 0x000000018975F3E0-0x000000018975F44C 0x000000018975FB28-0x000000018975FC18
		internal AutoIncrementValue AutoInc { get => default; } // 0x000000018975F2F4-0x000000018975F3E0 
		[DefaultValue(0)]
		public long AutoIncrementSeed { get => default; set {} } // 0x000000018975F44C-0x000000018975F478 0x000000018975FC18-0x000000018975FCE0
		[DefaultValue(1)]
		public long AutoIncrementStep { get => default; set {} } // 0x000000018975F478-0x000000018975F4A8 0x000000018975FCE0-0x000000018975FDA8
		public string Caption { get => default; set {} } // 0x000000018975F4C4-0x000000018975F4D8 0x000000018975FF6C-0x0000000189760000
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.All)]
		public string ColumnName { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x000000018976027C-0x00000001897607EC
		internal string EncodedColumnName { get => default; } // 0x000000018975F5FC-0x000000018975F670 
		internal IFormatProvider FormatProvider { get => default; } // 0x000000018975F738-0x000000018975F78C 
		internal CultureInfo Locale { get => default; } // 0x000000018975F834-0x000000018975F88C 
		internal int ObjectID { get => default; } // 0x0000000183D50EE0-0x0000000183D50EF0 
		[DefaultValue("")]
		public string Prefix { get => default; set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x000000018976221C-0x000000018976236C
		internal bool Computed { get => default; } // 0x0000000185C72CF8-0x0000000185C72D04 
		internal DataExpression DataExpression { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		[DefaultValue(typeof(string))]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(ColumnTypeConverter))]
		public System.Type DataType { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x00000001897607EC-0x0000000189761018
		[DefaultValue(DataSetDateTime.UnspecifiedLocal)]
		[RefreshProperties(RefreshProperties.All)]
		public DataSetDateTime DateTimeMode { get => default; set {} } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000189761018-0x0000000189761174
		[TypeConverter(typeof(DefaultValueTypeConverter))]
		public object DefaultValue { get => default; set {} } // 0x000000018975F4D8-0x000000018975F5FC 0x0000000189761174-0x0000000189761468
		internal bool DefaultValueIsNull { get => default; } // 0x0000000183D52050-0x0000000183D52060 
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.All)]
		public string Expression { get => default; set {} } // 0x000000018975F670-0x000000018975F6BC 0x0000000189761468-0x0000000189761CDC
		[Browsable(false)]
		public PropertyCollection ExtendedProperties { get => default; } // 0x000000018975F6BC-0x000000018975F738 
		internal bool HasData { get => default; } // 0x0000000185D62028-0x0000000185D62034 
		internal bool ImplementsINullable { get => default; } // 0x0000000183D50B80-0x0000000183D50B90 
		internal bool ImplementsIChangeTracking { get => default; } // 0x0000000183D50B90-0x0000000183D50BA0 
		internal bool ImplementsIRevertibleChangeTracking { get => default; } // 0x0000000183D75420-0x0000000183D75430 
		internal bool IsValueType { get => default; } // 0x000000018975F7EC-0x000000018975F80C 
		internal bool IsSqlType { get => default; } // 0x0000000183D58A70-0x0000000183D58A80 
		[DefaultValue(-1)]
		public int MaxLength { get => default; set {} } // 0x0000000183D4F050-0x0000000183D4F060 0x0000000189761E6C-0x00000001897620F4
		public string Namespace { get => default; set {} } // 0x000000018975F88C-0x000000018975F8FC 0x00000001897620F4-0x000000018976221C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Ordinal { get => default; } // 0x0000000183D50B30-0x0000000183D50B40 
		[DefaultValue(false)]
		public bool ReadOnly { get => default; set {} } // 0x0000000183D4F3F0-0x0000000183D4F400 0x000000018976236C-0x0000000189762440
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Index SortIndex { get => default; } // 0x000000018975F8FC-0x000000018975F9D0 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataTable Table { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		internal object this[int record] { get => default; set {} } // 0x000000018975F80C-0x000000018975F834 0x0000000189761CDC-0x0000000189761E6C
		[DefaultValue(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Unique { get => default; set {} } // 0x0000000183D4F360-0x0000000183D4F370 0x0000000189762490-0x0000000189762794
		internal string XmlDataType { get; set; } // 0x0000000183D51140-0x0000000183D51150 0x000000018589D964-0x000000018589D978
		internal SimpleType SimpleType { get => default; set {} } // 0x0000000183D50050-0x0000000183D50060 0x0000000189762440-0x0000000189762490
		[DefaultValue(MappingType.Element)]
		public virtual MappingType ColumnMapping { get => default; set {} } // 0x0000000183D4F370-0x0000000183D4F380 0x0000000189760000-0x000000018976027C
		internal bool IsCustomType { get => default; } // 0x000000018975F78C-0x000000018975F7EC 
		internal bool ImplementsIXMLSerializable { get => default; } // 0x0000000183D6CD80-0x0000000183D6CD90 
	
		// Constructors
		public DataColumn() {} // 0x000000018975EF70-0x000000018975EFEC
		public DataColumn(string columnName, System.Type dataType) {} // 0x000000018975EF4C-0x000000018975EF70
		public DataColumn(string columnName, System.Type dataType, string expr, MappingType type) {} // 0x000000018975EFEC-0x000000018975F2F4
	
		// Methods
		private void UpdateColumnType(System.Type type, StorageType typeCode) {} // 0x000000018975EE68-0x000000018975EF4C
		internal string GetColumnValueAsString(DataRow row, DataRowVersion version) => default; // 0x000000018975DD24-0x000000018975DDBC
		private void SetMaxLengthSimpleType() {} // 0x000000018975E9E8-0x000000018975EAA0
		internal void SetOrdinalInternal(int ordinal) {} // 0x000000018975EAA0-0x000000018975EBD8
		internal void SetTable(DataTable table) {} // 0x000000018975EC28-0x000000018975ECF4
		private DataRow GetDataRow(int index) => default; // 0x000000018975DDBC-0x000000018975DDE4
		internal void InitializeRecord(int record) {} // 0x000000018975E004-0x000000018975E048
		internal void SetValue(int record, object value) {} // 0x000000018975ECF4-0x000000018975EE04
		internal void FreeRecord(int record) {} // 0x000000018975DC30-0x000000018975DC60
		internal void InternalUnique(bool value) {} // 0x0000000183D4F380-0x0000000183D4F390
		internal void CheckColumnConstraint(DataRow row, DataRowAction action) {} // 0x000000018975CE44-0x000000018975CE98
		internal bool CheckMaxLength() => default; // 0x000000018975CF08-0x000000018975D118
		internal void CheckMaxLength(DataRow dr) {} // 0x000000018975CE98-0x000000018975CF08
		protected internal void CheckNotAllowNull() {} // 0x000000018975D118-0x000000018975D400
		internal void CheckNullable(DataRow row) {} // 0x000000018975D400-0x000000018975D47C
		protected void CheckUnique() {} // 0x000000018975D47C-0x000000018975D4D4
		internal int Compare(int record1, int record2) => default; // 0x000000018975DA28-0x000000018975DA54
		internal bool CompareValueTo(int record1, object value, bool checkType) => default; // 0x000000018975D874-0x000000018975D9FC
		internal int CompareValueTo(int record1, object value) => default; // 0x000000018975D9FC-0x000000018975DA28
		internal object ConvertValue(object value) => default; // 0x000000018975DB0C-0x000000018975DB34
		internal void Copy(int srcRecordNo, int dstRecordNo) {} // 0x000000018975DC04-0x000000018975DC30
		internal DataColumn Clone() => default; // 0x000000018975D4D4-0x000000018975D874
		internal object GetAggregateValue(int[] records, AggregateType kind) => default; // 0x000000018975DC60-0x000000018975DD24
		private int GetStringLength(int record) => default; // 0x000000018975DE20-0x000000018975DE48
		internal void Init(int record) {} // 0x000000018975DF70-0x000000018975E004
		internal static bool IsAutoIncrementType(System.Type dataType) => default; // 0x000000018975E0C8-0x000000018975E2B4
		internal bool IsValueCustomTypeInstance(object value) => default; // 0x000000018975E7E8-0x000000018975E874
		internal bool IsInRelation() => default; // 0x000000018975E2B4-0x000000018975E3B4
		internal bool IsMaxLengthViolated() => default; // 0x000000018975E3B4-0x000000018975E6C8
		internal bool IsNotAllowDBNullViolated() => default; // 0x000000018975E6C8-0x000000018975E7E8
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) {} // 0x000000018975E874-0x000000018975E894
		protected internal void RaisePropertyChanging(string name) {} // 0x000000018975E894-0x000000018975E90C
		private void InsureStorage() {} // 0x000000018975E048-0x000000018975E0C8
		internal void SetCapacity(int capacity) {} // 0x000000018975E9A8-0x000000018975E9E8
		internal void OnSetDataSet() {} // 0x000000018350B670-0x000000018350B680
		public override string ToString() => default; // 0x000000018975EE04-0x000000018975EE68
		internal object ConvertXmlToObject(string s) => default; // 0x000000018975DB34-0x000000018975DB74
		internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) => default; // 0x000000018975DB74-0x000000018975DBDC
		internal string ConvertObjectToXml(object value) => default; // 0x000000018975DA54-0x000000018975DA94
		internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) {} // 0x000000018975DA94-0x000000018975DB0C
		internal object GetEmptyColumnStore(int recordCount) => default; // 0x000000018975DDE4-0x000000018975DE20
		internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018975DBDC-0x000000018975DC04
		internal void SetStorage(object store, BitArray nullbits) {} // 0x000000018975EBD8-0x000000018975EC28
		internal void AddDependentColumn(DataColumn expressionColumn) {} // 0x000000018975CD74-0x000000018975CE44
		internal void RemoveDependentColumn(DataColumn expressionColumn) {} // 0x000000018975E90C-0x000000018975E9A8
		internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) {} // 0x000000018975DE48-0x000000018975DF70
	}

	internal abstract class AutoIncrementValue // TypeDefIndex: 49940
	{
		// Properties
		internal bool Auto { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		internal abstract object Current { get; set; }
		internal abstract long Seed { get; set; }
		internal abstract long Step { get; set; }
		internal abstract System.Type DataType { get; }
	
		// Constructors
		protected AutoIncrementValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal abstract void SetCurrent(object value, IFormatProvider formatProvider);
		internal abstract void SetCurrentAndIncrement(object value);
		internal abstract void MoveAfter();
		internal AutoIncrementValue Clone() => default; // 0x0000000189756458-0x0000000189756548
	}

	internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 49941
	{
		// Fields
		private long _current; // 0x18
		private long _seed; // 0x20
		private long _step; // 0x28
	
		// Properties
		internal override object Current { get => default; set {} } // 0x0000000189756270-0x00000001897562B8 0x0000000189756308-0x0000000189756358
		internal override System.Type DataType { get => default; } // 0x00000001897562B8-0x0000000189756308 
		internal override long Seed { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000189756358-0x00000001897563DC
		internal override long Step { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x00000001897563DC-0x0000000189756458
	
		// Constructors
		public AutoIncrementInt64() {} // 0x0000000183D75410-0x0000000183D75420
	
		// Methods
		internal override void MoveAfter() {} // 0x0000000183D75400-0x0000000183D75410
		internal override void SetCurrent(object value, IFormatProvider formatProvider) {} // 0x000000018975620C-0x0000000189756270
		internal override void SetCurrentAndIncrement(object value) {} // 0x00000001897560F8-0x000000018975620C
		private bool BoundaryCheck(BigInteger value) => default; // 0x0000000189756048-0x00000001897560F8
	}

	internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 49942
	{
		// Fields
		private BigInteger _current; // 0x18
		private long _seed; // 0x28
		private BigInteger _step; // 0x30
	
		// Properties
		internal override object Current { get => default; set {} } // 0x0000000189755C80-0x0000000189755CC8 0x0000000189755D78-0x0000000189755DD0
		internal override System.Type DataType { get => default; } // 0x0000000189755CC8-0x0000000189755D18 
		internal override long Seed { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000189755DD0-0x0000000189755EB4
		internal override long Step { get => default; set {} } // 0x0000000189755D18-0x0000000189755D78 0x0000000189755EB4-0x0000000189756048
	
		// Constructors
		public AutoIncrementBigInteger() {} // 0x0000000189755C28-0x0000000189755C80
	
		// Methods
		internal override void MoveAfter() {} // 0x0000000189755AB4-0x0000000189755B3C
		internal override void SetCurrent(object value, IFormatProvider formatProvider) {} // 0x0000000189755BFC-0x0000000189755C28
		internal override void SetCurrentAndIncrement(object value) {} // 0x0000000189755B3C-0x0000000189755BFC
		private bool BoundaryCheck(BigInteger value) => default; // 0x00000001897559B4-0x0000000189755AB4
	}

	public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 49943
	{
		// Fields
		private DataColumn _column; // 0x10
	
		// Properties
		public object ProposedValue { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public DataColumnChangeEventArgs() {} // Dummy constructor
		internal DataColumnChangeEventArgs(DataRow row) {} // 0x000000018975A0BC-0x000000018975A114
		public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value) {} // 0x000000018975A114-0x000000018975A198
	
		// Methods
		internal void InitializeColumnChangeEvent(DataColumn column, object value) {} // 0x0000000182CC1260-0x0000000182CC1290
	}

	public delegate void DataColumnChangeEventHandler(object sender, DataColumnChangeEventArgs e); // TypeDefIndex: 49944; 0x0000000182065C10-0x0000000182065C20

	[DefaultEvent("CollectionChanged")]
	public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 49945
	{
		// Fields
		private readonly DataTable _table; // 0x10
		private readonly ArrayList _list; // 0x18
		private int _defaultNameIndex; // 0x20
		private DataColumn[] _delayedAddRangeColumns; // 0x28
		private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
		private bool _fInClear; // 0x38
		private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
		private int _nColumnsImplementingIChangeTracking; // 0x48
		private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	
		// Properties
		protected override ArrayList List { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal DataColumn[] ColumnsImplementingIChangeTracking { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		internal int ColumnsImplementingIChangeTrackingCount { get => default; } // 0x0000000183D4EC50-0x0000000183D4EC60 
		internal int ColumnsImplementingIRevertibleChangeTrackingCount { get => default; } // 0x0000000183D4EDF0-0x0000000183D4EE00 
		public DataColumn this[int index] { get => default; } // 0x000000018975C4B4-0x000000018975C5A0 
		public DataColumn this[string name] { get => default; } // 0x000000018975C5A0-0x000000018975C6C0 
		internal DataColumn this[string name, string ns] { get => default; } // 0x000000018975C414-0x000000018975C4B4 
	
		// Events
		public event CollectionChangeEventHandler CollectionChanged;
		internal event CollectionChangeEventHandler ColumnPropertyChanged;
	
		// Constructors
		public DataColumnCollection() {} // Dummy constructor
		internal DataColumnCollection(DataTable table) {} // 0x000000018975C1DC-0x000000018975C2EC
	
		// Methods
		public void Add(DataColumn column) {} // 0x000000018975A49C-0x000000018975A4AC
		internal void AddAt(int index, DataColumn column) {} // 0x000000018975A198-0x000000018975A3F0
		private void ArrayAdd(DataColumn column) {} // 0x000000018975A4F4-0x000000018975A560
		private void ArrayAdd(int index, DataColumn column) {} // 0x000000018975A4AC-0x000000018975A4F4
		private void ArrayRemove(DataColumn column) {} // 0x000000018975A560-0x000000018975A674
		internal string AssignName() => default; // 0x000000018975A674-0x000000018975A6E4
		private void BaseAdd(DataColumn column) {} // 0x000000018975A6E4-0x000000018975A9C4
		private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) {} // 0x000000018975A9C4-0x000000018975ABB0
		private void BaseRemove(DataColumn column) {} // 0x000000018975ABB0-0x000000018975AC74
		internal bool CanRemove(DataColumn column, bool fThrowException) => default; // 0x000000018975ACCC-0x000000018975B59C
		private void CheckIChangeTracking(DataColumn column) {} // 0x000000018975B59C-0x000000018975B5D4
		public void Clear() {} // 0x000000018975B5D4-0x000000018975B8A0
		public bool Contains(string name) => default; // 0x000000018975B93C-0x000000018975B9C0
		internal bool Contains(string name, bool caseSensitive) => default; // 0x000000018975B8A0-0x000000018975B93C
		public int IndexOf(string columnName) => default; // 0x000000018975BAF8-0x000000018975BBEC
		internal int IndexOfCaseInsensitive(string name) => default; // 0x000000018975B9C0-0x000000018975BAF8
		private string MakeName(int index) => default; // 0x000000018975BBEC-0x000000018975BC78
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent) {} // 0x000000018975BC78-0x000000018975BCEC
		private void OnCollectionChanging(CollectionChangeEventArgs ccevent) {} // 0x000000018975BCEC-0x000000018975BD08
		internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) {} // 0x000000018975BD08-0x000000018975BD54
		internal void RegisterColumnName(string name, DataColumn column) {} // 0x000000018975BD54-0x000000018975BF48
		internal bool CanRegisterName(string name) => default; // 0x000000018975AC74-0x000000018975ACCC
		public void Remove(DataColumn column) {} // 0x000000018975C024-0x000000018975C118
		internal void UnregisterName(string name) {} // 0x000000018975C118-0x000000018975C1DC
		private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) {} // 0x000000018975A3F0-0x000000018975A49C
		private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) {} // 0x000000018975BF48-0x000000018975C024
	}

	internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 49946
	{
		// Properties
		public override AttributeCollection Attributes { get => default; } // 0x000000018975CB74-0x000000018975CCE4 
		internal DataColumn Column { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public override System.Type ComponentType { get => default; } // 0x000000018975CCE4-0x000000018975CD34 
		public override bool IsReadOnly { get => default; } // 0x000000018975CD34-0x000000018975CD54 
		public override System.Type PropertyType { get => default; } // 0x000000018975CD54-0x000000018975CD74 
	
		// Constructors
		public DataColumnPropertyDescriptor() {} // Dummy constructor
		internal DataColumnPropertyDescriptor(DataColumn dataColumn) {} // 0x000000018975CB2C-0x000000018975CB74
	
		// Methods
		public override bool Equals(object other) => default; // 0x000000018975C8C4-0x000000018975C924
		public override int GetHashCode() => default; // 0x000000018975C924-0x000000018975C948
		public override bool CanResetValue(object component) => default; // 0x000000018975C7E8-0x000000018975C8C4
		public override object GetValue(object component) => default; // 0x000000018975C948-0x000000018975C9BC
		public override void ResetValue(object component) {} // 0x000000018975C9BC-0x000000018975CA68
		public override void SetValue(object component, object value) {} // 0x000000018975CA68-0x000000018975CB2C
		public override bool ShouldSerializeValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	internal sealed class DataError // TypeDefIndex: 49948
	{
		// Fields
		private string _rowError; // 0x10
		private int _count; // 0x18
		private ColumnError[] _errorList; // 0x20
	
		// Properties
		internal string Text { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189762E5C-0x0000000189762E64
		internal bool HasErrors { get => default; } // 0x0000000189762E30-0x0000000189762E5C 
	
		// Nested types
		internal struct ColumnError // TypeDefIndex: 49947
		{
			// Fields
			internal DataColumn _column; // 0x00
			internal string _error; // 0x08
		}
	
		// Constructors
		internal DataError() {} // 0x0000000189762DE8-0x0000000189762E30
		internal DataError(string rowError) {} // 0x0000000189762D84-0x0000000189762DE8
	
		// Methods
		internal void SetColumnError(DataColumn column, string error) {} // 0x0000000189762C04-0x0000000189762D28
		internal string GetColumnError(DataColumn column) => default; // 0x00000001897629A4-0x0000000189762A38
		internal void Clear(DataColumn column) {} // 0x0000000189762894-0x000000018976291C
		internal void Clear() {} // 0x000000018976291C-0x00000001897629A4
		internal DataColumn[] GetColumnsInError() => default; // 0x0000000189762A38-0x0000000189762ADC
		private void SetText(string errorText) {} // 0x0000000189762D28-0x0000000189762D84
		internal int IndexOf(DataColumn column) => default; // 0x0000000189762ADC-0x0000000189762C04
	}

	[Serializable]
	public class DataException : SystemException // TypeDefIndex: 49949
	{
		// Constructors
		protected DataException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
		public DataException() {} // 0x0000000189762E84-0x0000000189762EC8
		public DataException(string s) {} // 0x0000000189762E64-0x0000000189762E84
		public DataException(string s, Exception innerException) {} // 0x00000001891A5918-0x00000001891A5920
	}

	[Serializable]
	public class ConstraintException : DataException // TypeDefIndex: 49950
	{
		// Constructors
		protected ConstraintException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public ConstraintException() {} // 0x0000000189759C0C-0x0000000189759C50
		public ConstraintException(string s) {} // 0x0000000189759C50-0x0000000189759C70
	}

	[Serializable]
	public class DeletedRowInaccessibleException : DataException // TypeDefIndex: 49951
	{
		// Constructors
		protected DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public DeletedRowInaccessibleException() {} // 0x00000001897666A8-0x00000001897666EC
		public DeletedRowInaccessibleException(string s) {} // 0x00000001897666EC-0x000000018976670C
	}

	[Serializable]
	public class DuplicateNameException : DataException // TypeDefIndex: 49952
	{
		// Constructors
		protected DuplicateNameException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public DuplicateNameException() {} // 0x000000018976672C-0x0000000189766770
		public DuplicateNameException(string s) {} // 0x000000018976670C-0x000000018976672C
	}

	[Serializable]
	public class InRowChangingEventException : DataException // TypeDefIndex: 49953
	{
		// Constructors
		protected InRowChangingEventException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public InRowChangingEventException() {} // 0x000000018976B2C0-0x000000018976B304
		public InRowChangingEventException(string s) {} // 0x000000018976B304-0x000000018976B324
	}

	[Serializable]
	public class InvalidConstraintException : DataException // TypeDefIndex: 49954
	{
		// Constructors
		protected InvalidConstraintException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public InvalidConstraintException() {} // 0x000000018976B504-0x000000018976B548
		public InvalidConstraintException(string s) {} // 0x000000018976B4E4-0x000000018976B504
	}

	[Serializable]
	public class NoNullAllowedException : DataException // TypeDefIndex: 49955
	{
		// Constructors
		protected NoNullAllowedException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public NoNullAllowedException() {} // 0x000000018976B568-0x000000018976B5AC
		public NoNullAllowedException(string s) {} // 0x000000018976B548-0x000000018976B568
	}

	[Serializable]
	public class ReadOnlyException : DataException // TypeDefIndex: 49956
	{
		// Constructors
		protected ReadOnlyException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public ReadOnlyException() {} // 0x000000018976B634-0x000000018976B678
		public ReadOnlyException(string s) {} // 0x000000018976B678-0x000000018976B698
	}

	[Serializable]
	public class RowNotInTableException : DataException // TypeDefIndex: 49957
	{
		// Constructors
		protected RowNotInTableException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public RowNotInTableException() {} // 0x000000018976B698-0x000000018976B6DC
		public RowNotInTableException(string s) {} // 0x000000018976B6DC-0x000000018976B6FC
	}

	[Serializable]
	public class VersionNotFoundException : DataException // TypeDefIndex: 49958
	{
		// Constructors
		protected VersionNotFoundException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public VersionNotFoundException() {} // 0x000000018976B848-0x000000018976B88C
		public VersionNotFoundException(string s) {} // 0x000000018976B88C-0x000000018976B8AC
	}

	internal static class ExceptionBuilder // TypeDefIndex: 49959
	{
		// Methods
		private static void TraceException(string trace, Exception e) {} // 0x000000018976A818-0x000000018976A89C
		internal static Exception TraceExceptionAsReturnValue(Exception e) => default; // 0x000000018976A758-0x000000018976A798
		internal static Exception TraceExceptionForCapture(Exception e) => default; // 0x000000018976A798-0x000000018976A7D8
		internal static Exception TraceExceptionWithoutRethrow(Exception e) => default; // 0x000000018976A7D8-0x000000018976A818
		internal static Exception _Argument(string error) => default; // 0x000000018976AC8C-0x000000018976ACF4
		internal static Exception _Argument(string error, Exception innerException) => default; // 0x000000018976AC14-0x000000018976AC8C
		private static Exception _ArgumentNull(string paramName, string msg) => default; // 0x000000018976AB24-0x000000018976AB9C
		internal static Exception _ArgumentOutOfRange(string paramName, string msg) => default; // 0x000000018976AB9C-0x000000018976AC14
		private static Exception _IndexOutOfRange(string error) => default; // 0x000000018976AEFC-0x000000018976AF64
		private static Exception _InvalidOperation(string error) => default; // 0x000000018976B034-0x000000018976B09C
		private static Exception _InvalidEnumArgumentException(string error) => default; // 0x000000018976AFCC-0x000000018976B034
		private static Exception _InvalidEnumArgumentException<T>(T value) => default;
		private static void ThrowDataException(string error, Exception innerException) {} // 0x000000018976A664-0x000000018976A6D4
		private static Exception _Data(string error) => default; // 0x000000018976AD5C-0x000000018976ADC4
		private static Exception _Constraint(string error) => default; // 0x000000018976ACF4-0x000000018976AD5C
		private static Exception _InvalidConstraint(string error) => default; // 0x000000018976AF64-0x000000018976AFCC
		private static Exception _DeletedRowInaccessible(string error) => default; // 0x000000018976ADC4-0x000000018976AE2C
		private static Exception _DuplicateName(string error) => default; // 0x000000018976AE2C-0x000000018976AE94
		private static Exception _InRowChangingEvent(string error) => default; // 0x000000018976AE94-0x000000018976AEFC
		private static Exception _NoNullAllowed(string error) => default; // 0x000000018976B09C-0x000000018976B104
		private static Exception _ReadOnly(string error) => default; // 0x000000018976B104-0x000000018976B16C
		private static Exception _RowNotInTable(string error) => default; // 0x000000018976B16C-0x000000018976B1D4
		private static Exception _VersionNotFound(string error) => default; // 0x000000018976B1D4-0x000000018976B23C
		public static Exception ArgumentNull(string paramName) => default; // 0x00000001897668AC-0x00000001897668F8
		public static Exception ArgumentOutOfRange(string paramName) => default; // 0x00000001897668F8-0x0000000189766944
		public static Exception BadObjectPropertyAccess(string error) => default; // 0x0000000189766A90-0x0000000189766AD8
		public static Exception CaseInsensitiveNameConflict(string name) => default; // 0x0000000189767490-0x00000001897674D8
		public static Exception NamespaceNameConflict(string name) => default; // 0x0000000189769200-0x0000000189769248
		public static Exception InvalidOffsetLength() => default; // 0x0000000189768960-0x0000000189768994
		public static Exception ColumnNotInTheTable(string column, string table) => default; // 0x00000001897675F0-0x0000000189767648
		public static Exception ColumnNotInAnyTable() => default; // 0x00000001897675BC-0x00000001897675F0
		public static Exception ColumnOutOfRange(int index) => default; // 0x0000000189767648-0x00000001897676BC
		public static Exception ColumnOutOfRange(string column) => default; // 0x00000001897676BC-0x0000000189767704
		public static Exception CannotAddColumn1(string column) => default; // 0x0000000189766CE0-0x0000000189766D28
		public static Exception CannotAddColumn2(string column) => default; // 0x0000000189766D28-0x0000000189766D70
		public static Exception CannotAddColumn3() => default; // 0x0000000189766D70-0x0000000189766DA4
		public static Exception CannotAddColumn4(string column) => default; // 0x0000000189766DA4-0x0000000189766DEC
		public static Exception CannotAddDuplicate(string column) => default; // 0x0000000189766E7C-0x0000000189766EC4
		public static Exception CannotAddDuplicate2(string table) => default; // 0x0000000189766DEC-0x0000000189766E34
		public static Exception CannotAddDuplicate3(string table) => default; // 0x0000000189766E34-0x0000000189766E7C
		public static Exception CannotRemoveColumn() => default; // 0x000000018976703C-0x0000000189767070
		public static Exception CannotRemovePrimaryKey() => default; // 0x0000000189767120-0x0000000189767154
		public static Exception CannotRemoveChildKey(string relation) => default; // 0x0000000189766FF4-0x000000018976703C
		public static Exception CannotRemoveConstraint(string constraint, string table) => default; // 0x0000000189767070-0x00000001897670C8
		public static Exception CannotRemoveExpression(string column, string expression) => default; // 0x00000001897670C8-0x0000000189767120
		public static Exception AddPrimaryKeyConstraint() => default; // 0x00000001897667D8-0x000000018976680C
		public static Exception NoConstraintName() => default; // 0x000000018976932C-0x0000000189769360
		public static Exception ConstraintViolation(string constraint) => default; // 0x0000000189767958-0x00000001897679A0
		public static string KeysToString(object[] keys) => default; // 0x0000000189768DF4-0x0000000189768EE4
		public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) => default; // 0x000000018976A960-0x000000018976AABC
		public static Exception ConstraintViolation(DataColumn[] columns, object[] values) => default; // 0x000000018976793C-0x0000000189767958
		public static Exception ConstraintOutOfRange(int index) => default; // 0x0000000189767860-0x00000001897678D4
		public static Exception DuplicateConstraint(string constraint) => default; // 0x0000000189767E98-0x0000000189767EE0
		public static Exception DuplicateConstraintName(string constraint) => default; // 0x0000000189767E08-0x0000000189767E50
		public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) => default; // 0x0000000189769248-0x00000001897692B0
		public static Exception UniqueConstraintViolation() => default; // 0x000000018976AABC-0x000000018976AAF0
		public static Exception ConstraintForeignTable() => default; // 0x000000018976782C-0x0000000189767860
		public static Exception ConstraintParentValues() => default; // 0x00000001897678D4-0x0000000189767908
		public static Exception ConstraintAddFailed(DataTable table) => default; // 0x00000001897677D4-0x000000018976782C
		public static Exception ConstraintRemoveFailed() => default; // 0x0000000189767908-0x000000018976793C
		public static Exception FailedCascadeDelete(string constraint) => default; // 0x0000000189768280-0x00000001897682C8
		public static Exception FailedCascadeUpdate(string constraint) => default; // 0x00000001897682C8-0x0000000189768310
		public static Exception FailedClearParentTable(string table, string constraint, string childTable) => default; // 0x0000000189768310-0x0000000189768378
		public static Exception ForeignKeyViolation(string constraint, object[] keys) => default; // 0x0000000189768378-0x00000001897683D8
		public static Exception RemoveParentRow(ForeignKeyConstraint constraint) => default; // 0x0000000189769CEC-0x0000000189769D40
		public static string MaxLengthViolationText(string columnName) => default; // 0x0000000189768F80-0x0000000189768FBC
		public static string NotAllowDBNullViolationText(string columnName) => default; // 0x0000000189769478-0x00000001897694B4
		public static Exception CantAddConstraintToMultipleNestedTable(string tableName) => default; // 0x000000018976736C-0x00000001897673B4
		public static Exception AutoIncrementAndExpression() => default; // 0x00000001897669E0-0x0000000189766A14
		public static Exception AutoIncrementAndDefaultValue() => default; // 0x00000001897669AC-0x00000001897669E0
		public static Exception AutoIncrementSeed() => default; // 0x0000000189766A5C-0x0000000189766A90
		public static Exception CantChangeDataType() => default; // 0x00000001897673B4-0x00000001897673E8
		public static Exception NullDataType() => default; // 0x00000001897694E8-0x000000018976951C
		public static Exception ColumnNameRequired() => default; // 0x0000000189767588-0x00000001897675BC
		public static Exception DefaultValueAndAutoIncrement() => default; // 0x0000000189767B50-0x0000000189767B84
		public static Exception DefaultValueDataType(string column, System.Type defaultType, System.Type columnType, Exception inner) => default; // 0x0000000189767C2C-0x0000000189767D24
		public static Exception DefaultValueColumnDataType(string column, System.Type defaultType, System.Type columnType, Exception inner) => default; // 0x0000000189767B84-0x0000000189767C2C
		public static Exception ExpressionAndUnique() => default; // 0x00000001897681C4-0x00000001897681F8
		public static Exception ExpressionAndReadOnly() => default; // 0x0000000189768190-0x00000001897681C4
		public static Exception ExpressionAndConstraint(DataColumn column, System.Data.Constraint constraint) => default; // 0x0000000189768128-0x0000000189768190
		public static Exception ExpressionInConstraint(DataColumn column) => default; // 0x000000018976822C-0x0000000189768280
		public static Exception ExpressionCircular() => default; // 0x00000001897681F8-0x000000018976822C
		public static Exception NonUniqueValues(string column) => default; // 0x0000000189769430-0x0000000189769478
		public static Exception NullKeyValues(string column) => default; // 0x000000018976951C-0x0000000189769564
		public static Exception NullValues(string column) => default; // 0x0000000189769598-0x00000001897695E0
		public static Exception ReadOnlyAndExpression() => default; // 0x00000001897697D4-0x0000000189769808
		public static Exception ReadOnly(string column) => default; // 0x0000000189769808-0x0000000189769850
		public static Exception UniqueAndExpression() => default; // 0x000000018976A92C-0x000000018976A960
		public static Exception SetFailed(object value, DataColumn column, System.Type type, Exception innerException) => default; // 0x000000018976A154-0x000000018976A238
		public static Exception CannotSetToNull(DataColumn column) => default; // 0x0000000189767318-0x000000018976736C
		public static Exception LongerThanMaxLength(DataColumn column) => default; // 0x0000000189768EE4-0x0000000189768F38
		public static Exception CannotSetMaxLength(DataColumn column, int value) => default; // 0x00000001897671DC-0x0000000189767268
		public static Exception CannotSetMaxLength2(DataColumn column) => default; // 0x0000000189767188-0x00000001897671DC
		public static Exception CannotSetSimpleContentType(string columnName, System.Type type) => default; // 0x0000000189767268-0x00000001897672C0
		public static Exception CannotSetSimpleContent(string columnName, System.Type type) => default; // 0x00000001897672C0-0x0000000189767318
		public static Exception CannotChangeNamespace(string columnName) => default; // 0x0000000189766F0C-0x0000000189766F54
		public static Exception HasToBeStringType(DataColumn column) => default; // 0x000000018976850C-0x0000000189768560
		public static Exception AutoIncrementCannotSetIfHasData(string typeName) => default; // 0x0000000189766A14-0x0000000189766A5C
		public static Exception INullableUDTwithoutStaticNull(string typeName) => default; // 0x00000001897685A8-0x00000001897685F0
		public static Exception IComparableNotImplemented(string typeName) => default; // 0x0000000189768560-0x00000001897685A8
		public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) => default; // 0x000000018976A89C-0x000000018976A8E4
		public static Exception InvalidDataColumnMapping(System.Type type) => default; // 0x00000001897687E0-0x0000000189768840
		public static Exception CannotSetDateTimeModeForNonDateTimeColumns() => default; // 0x0000000189767154-0x0000000189767188
		public static Exception InvalidDateTimeMode(DataSetDateTime mode) => default; // 0x0000000189768840-0x0000000189768878
		public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) => default; // 0x00000001897673E8-0x0000000189767490
		public static Exception ColumnTypeNotSupported() => default; // 0x000000018976774C-0x00000001897677A0
		public static Exception SetFailed(string name) => default; // 0x000000018976A238-0x000000018976A280
		public static Exception CanNotUse() => default; // 0x0000000189766C78-0x0000000189766CAC
		public static Exception SetIListObject() => default; // 0x000000018976A280-0x000000018976A2B4
		public static Exception AddNewNotAllowNull() => default; // 0x00000001897667A4-0x00000001897667D8
		public static Exception NotOpen() => default; // 0x00000001897694B4-0x00000001897694E8
		public static Exception CreateChildView() => default; // 0x0000000189767A24-0x0000000189767A58
		public static Exception CanNotDelete() => default; // 0x0000000189766B40-0x0000000189766B74
		public static Exception GetElementIndex(int index) => default; // 0x0000000189768440-0x00000001897684B4
		public static Exception AddExternalObject() => default; // 0x0000000189766770-0x00000001897667A4
		public static Exception CanNotClear() => default; // 0x0000000189766B0C-0x0000000189766B40
		public static Exception InsertExternalObject() => default; // 0x00000001897686EC-0x0000000189768720
		public static Exception RemoveExternalObject() => default; // 0x0000000189769CB8-0x0000000189769CEC
		public static Exception KeyTableMismatch() => default; // 0x0000000189768D4C-0x0000000189768D80
		public static Exception KeyNoColumns() => default; // 0x0000000189768D18-0x0000000189768D4C
		public static Exception KeyTooManyColumns(int cols) => default; // 0x0000000189768D80-0x0000000189768DF4
		public static Exception KeyDuplicateColumns(string columnName) => default; // 0x0000000189768C68-0x0000000189768CB0
		public static Exception RelationDataSetMismatch() => default; // 0x00000001897699B0-0x00000001897699E4
		public static Exception ColumnsTypeMismatch() => default; // 0x00000001897677A0-0x00000001897677D4
		public static Exception KeyLengthMismatch() => default; // 0x0000000189768CB0-0x0000000189768CE4
		public static Exception KeyLengthZero() => default; // 0x0000000189768CE4-0x0000000189768D18
		public static Exception ForeignRelation() => default; // 0x00000001897683D8-0x000000018976840C
		public static Exception KeyColumnsIdentical() => default; // 0x0000000189768C34-0x0000000189768C68
		public static Exception RelationForeignTable(string t1, string t2) => default; // 0x0000000189769A80-0x0000000189769AD8
		public static Exception GetParentRowTableMismatch(string t1, string t2) => default; // 0x00000001897684B4-0x000000018976850C
		public static Exception SetParentRowTableMismatch(string t1, string t2) => default; // 0x000000018976A2B4-0x000000018976A30C
		public static Exception RelationForeignRow() => default; // 0x0000000189769A4C-0x0000000189769A80
		public static Exception RelationNestedReadOnly() => default; // 0x0000000189769AD8-0x0000000189769B0C
		public static Exception TableCantBeNestedInTwoTables(string tableName) => default; // 0x000000018976A410-0x000000018976A458
		public static Exception LoopInNestedRelations(string tableName) => default; // 0x0000000189768F38-0x0000000189768F80
		public static Exception RelationDoesNotExist() => default; // 0x0000000189769A18-0x0000000189769A4C
		public static Exception ParentOrChildColumnsDoNotHaveDataSet() => default; // 0x00000001897695E0-0x0000000189769614
		public static Exception InValidNestedRelation(string childTableName) => default; // 0x00000001897685F0-0x0000000189768638
		public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) => default; // 0x0000000189768994-0x00000001897689DC
		public static Exception RowNotInTheDataSet() => default; // 0x0000000189769F80-0x0000000189769FB4
		public static Exception RowNotInTheTable() => default; // 0x0000000189769FB4-0x0000000189769FE8
		public static Exception EditInRowChanging() => default; // 0x0000000189768010-0x0000000189768044
		public static Exception EndEditInRowChanging() => default; // 0x000000018976808C-0x00000001897680C0
		public static Exception BeginEditInRowChanging() => default; // 0x0000000189766AD8-0x0000000189766B0C
		public static Exception CancelEditInRowChanging() => default; // 0x0000000189766CAC-0x0000000189766CE0
		public static Exception DeleteInRowDeleting() => default; // 0x0000000189767D24-0x0000000189767D58
		public static Exception ValueArrayLength() => default; // 0x000000018976AAF0-0x000000018976AB24
		public static Exception NoCurrentData() => default; // 0x0000000189769360-0x0000000189769394
		public static Exception NoOriginalData() => default; // 0x0000000189769394-0x00000001897693C8
		public static Exception NoProposedData() => default; // 0x00000001897693C8-0x00000001897693FC
		public static Exception RowRemovedFromTheTable() => default; // 0x000000018976A05C-0x000000018976A090
		public static Exception DeletedRowInaccessible() => default; // 0x0000000189767D58-0x0000000189767D8C
		public static Exception RowAlreadyDeleted() => default; // 0x0000000189769DB8-0x0000000189769DEC
		public static Exception RowEmpty() => default; // 0x0000000189769E88-0x0000000189769EBC
		public static Exception InvalidRowVersion() => default; // 0x0000000189768AC8-0x0000000189768AFC
		public static Exception RowOutOfRange(int index) => default; // 0x0000000189769FE8-0x000000018976A05C
		public static Exception RowInsertTwice(int index, string tableName) => default; // 0x0000000189769F04-0x0000000189769F80
		public static Exception RowInsertMissing(string tableName) => default; // 0x0000000189769EBC-0x0000000189769F04
		public static Exception RowAlreadyRemoved() => default; // 0x0000000189769E54-0x0000000189769E88
		public static Exception MultipleParents() => default; // 0x0000000189769198-0x00000001897691CC
		public static Exception InvalidRowState(DataRowState state) => default; // 0x0000000189768A90-0x0000000189768AC8
		public static Exception InvalidRowBitPattern() => default; // 0x0000000189768A5C-0x0000000189768A90
		internal static Exception SetDataSetNameToEmpty() => default; // 0x000000018976A120-0x000000018976A154
		internal static Exception SetDataSetNameConflicting(string name) => default; // 0x000000018976A0D8-0x000000018976A120
		public static Exception DataSetUnsupportedSchema(string ns) => default; // 0x0000000189767A58-0x0000000189767AA0
		public static Exception MergeMissingDefinition(string obj) => default; // 0x0000000189768FC4-0x000000018976900C
		public static Exception TablesInDifferentSets() => default; // 0x000000018976A630-0x000000018976A664
		public static Exception RelationAlreadyExists() => default; // 0x0000000189769884-0x00000001897698B8
		public static Exception RowAlreadyInOtherCollection() => default; // 0x0000000189769DEC-0x0000000189769E20
		public static Exception RowAlreadyInTheCollection() => default; // 0x0000000189769E20-0x0000000189769E54
		public static Exception RecordStateRange() => default; // 0x0000000189769850-0x0000000189769884
		public static Exception IndexKeyLength(int length, int keyLength) => default; // 0x0000000189768638-0x00000001897686EC
		public static Exception RemovePrimaryKey(DataTable table) => default; // 0x0000000189769D40-0x0000000189769DB8
		public static Exception RelationAlreadyInOtherDataSet() => default; // 0x00000001897698B8-0x00000001897698EC
		public static Exception RelationAlreadyInTheDataSet() => default; // 0x00000001897698EC-0x0000000189769920
		public static Exception RelationNotInTheDataSet(string relation) => default; // 0x0000000189769B0C-0x0000000189769B54
		public static Exception RelationOutOfRange(object index) => default; // 0x0000000189769B54-0x0000000189769BC0
		public static Exception DuplicateRelation(string relation) => default; // 0x0000000189767F28-0x0000000189767F70
		public static Exception RelationTableNull() => default; // 0x0000000189769C50-0x0000000189769C84
		public static Exception RelationDataSetNull() => default; // 0x00000001897699E4-0x0000000189769A18
		public static Exception RelationTableWasRemoved() => default; // 0x0000000189769C84-0x0000000189769CB8
		public static Exception ParentTableMismatch() => default; // 0x0000000189769614-0x0000000189769648
		public static Exception ChildTableMismatch() => default; // 0x000000018976750C-0x0000000189767540
		public static Exception EnforceConstraint() => default; // 0x00000001897680C0-0x00000001897680F4
		public static Exception CaseLocaleMismatch() => default; // 0x00000001897674D8-0x000000018976750C
		public static Exception CannotChangeCaseLocale() => default; // 0x0000000189766EC4-0x0000000189766ED0
		public static Exception CannotChangeCaseLocale(Exception innerException) => default; // 0x0000000189766ED0-0x0000000189766F0C
		public static Exception InvalidRemotingFormat(System.Data.SerializationFormat mode) => default; // 0x0000000189768A24-0x0000000189768A5C
		public static Exception TableForeignPrimaryKey() => default; // 0x000000018976A458-0x000000018976A48C
		public static Exception TableCannotAddToSimpleContent() => default; // 0x000000018976A3DC-0x000000018976A410
		public static Exception NoTableName() => default; // 0x00000001897693FC-0x0000000189769430
		public static Exception MultipleTextOnlyColumns() => default; // 0x00000001897691CC-0x0000000189769200
		public static Exception InvalidSortString(string sort) => default; // 0x0000000189768B44-0x0000000189768B8C
		public static Exception DuplicateTableName(string table) => default; // 0x0000000189767FC8-0x0000000189768010
		public static Exception DuplicateTableName2(string table, string ns) => default; // 0x0000000189767F70-0x0000000189767FC8
		public static Exception SelfnestedDatasetConflictingName(string table) => default; // 0x000000018976A090-0x000000018976A0D8
		public static Exception DatasetConflictingName(string table) => default; // 0x0000000189767AD4-0x0000000189767B1C
		public static Exception TableAlreadyInOtherDataSet() => default; // 0x000000018976A374-0x000000018976A3A8
		public static Exception TableAlreadyInTheDataSet() => default; // 0x000000018976A3A8-0x000000018976A3DC
		public static Exception TableOutOfRange(int index) => default; // 0x000000018976A5BC-0x000000018976A630
		public static Exception TableNotInTheDataSet(string table) => default; // 0x000000018976A574-0x000000018976A5BC
		public static Exception TableInRelation() => default; // 0x000000018976A4F8-0x000000018976A52C
		public static Exception TableInConstraint(DataTable table, System.Data.Constraint constraint) => default; // 0x000000018976A48C-0x000000018976A4F8
		public static Exception CanNotSerializeDataTableHierarchy() => default; // 0x0000000189766BDC-0x0000000189766C10
		public static Exception CanNotRemoteDataTable() => default; // 0x0000000189766BA8-0x0000000189766BDC
		public static Exception CanNotSetRemotingFormat() => default; // 0x0000000189766C44-0x0000000189766C78
		public static Exception CanNotSerializeDataTableWithEmptyName() => default; // 0x0000000189766C10-0x0000000189766C44
		public static Exception TableNotFound(string tableName) => default; // 0x000000018976A52C-0x000000018976A574
		public static Exception AggregateException(AggregateType aggregateType, System.Type type) => default; // 0x000000018976680C-0x00000001897668AC
		public static Exception InvalidStorageType(TypeCode typecode) => default; // 0x0000000189768B8C-0x0000000189768C00
		public static Exception RangeArgument(int min, int max) => default; // 0x000000018976973C-0x00000001897697D4
		public static Exception NullRange() => default; // 0x0000000189769564-0x0000000189769598
		public static Exception NegativeMinimumCapacity() => default; // 0x00000001897692B0-0x00000001897692E4
		public static Exception ProblematicChars(char charValue) => default; // 0x0000000189769690-0x000000018976973C
		public static Exception StorageSetFailed() => default; // 0x000000018976A340-0x000000018976A374
		public static Exception SimpleTypeNotSupported() => default; // 0x000000018976A30C-0x000000018976A340
		public static Exception MissingAttribute(string attribute) => default; // 0x0000000189769098-0x00000001897690E0
		public static Exception MissingAttribute(string element, string attribute) => default; // 0x0000000189769040-0x0000000189769098
		public static Exception InvalidAttributeValue(string name, string value) => default; // 0x0000000189768788-0x00000001897687E0
		public static Exception AttributeValues(string name, string value1, string value2) => default; // 0x0000000189766944-0x00000001897669AC
		public static Exception ElementTypeNotFound(string name) => default; // 0x0000000189768044-0x000000018976808C
		public static Exception RelationParentNameMissing(string rel) => default; // 0x0000000189769BC0-0x0000000189769C08
		public static Exception RelationChildNameMissing(string rel) => default; // 0x0000000189769968-0x00000001897699B0
		public static Exception RelationTableKeyMissing(string rel) => default; // 0x0000000189769C08-0x0000000189769C50
		public static Exception RelationChildKeyMissing(string rel) => default; // 0x0000000189769920-0x0000000189769968
		public static Exception UndefinedDatatype(string name) => default; // 0x000000018976A8E4-0x000000018976A92C
		public static Exception DatatypeNotDefined() => default; // 0x0000000189767B1C-0x0000000189767B50
		public static Exception MismatchKeyLength() => default; // 0x000000018976900C-0x0000000189769040
		public static Exception InvalidField(string name) => default; // 0x00000001897688D0-0x0000000189768918
		public static Exception InvalidSelector(string name) => default; // 0x0000000189768AFC-0x0000000189768B44
		public static Exception CircularComplexType(string name) => default; // 0x0000000189767540-0x0000000189767588
		public static Exception CannotInstantiateAbstract(string name) => default; // 0x0000000189766FAC-0x0000000189766FF4
		public static Exception InvalidKey(string name) => default; // 0x0000000189768918-0x0000000189768960
		public static Exception DiffgramMissingTable(string name) => default; // 0x0000000189767DC0-0x0000000189767E08
		public static Exception DiffgramMissingSQL() => default; // 0x0000000189767D8C-0x0000000189767DC0
		public static Exception DuplicateConstraintRead(string str) => default; // 0x0000000189767E50-0x0000000189767E98
		public static Exception ColumnTypeConflict(string name) => default; // 0x0000000189767704-0x000000018976774C
		public static Exception CannotConvert(string name, string type) => default; // 0x0000000189766F54-0x0000000189766FAC
		public static Exception MissingRefer(string name) => default; // 0x00000001897690E0-0x0000000189769150
		public static Exception InvalidPrefix(string name) => default; // 0x00000001897689DC-0x0000000189768A24
		public static Exception CanNotDeserializeObjectType() => default; // 0x0000000189766B74-0x0000000189766BA8
		public static Exception IsDataSetAttributeMissingInSchema() => default; // 0x0000000189768C00-0x0000000189768C34
		public static Exception TooManyIsDataSetAtributeInSchema() => default; // 0x000000018976A724-0x000000018976A758
		public static Exception NestedCircular(string name) => default; // 0x00000001897692E4-0x000000018976932C
		public static Exception MultipleParentRows(string tableQName) => default; // 0x0000000189769150-0x0000000189769198
		public static Exception PolymorphismNotSupported(string typeName) => default; // 0x0000000189769648-0x0000000189769690
		public static Exception DataTableInferenceNotSupported() => default; // 0x0000000189767AA0-0x0000000189767AD4
		internal static void ThrowMultipleTargetConverter(Exception innerException) {} // 0x000000018976A6D4-0x000000018976A724
		public static Exception DuplicateDeclaration(string name) => default; // 0x0000000189767EE0-0x0000000189767F28
		public static Exception FoundEntity() => default; // 0x000000018976840C-0x0000000189768440
		public static Exception MergeFailed(string name) => default; // 0x0000000189768FBC-0x0000000189768FC4
		public static Exception ConvertFailed(System.Type type1, System.Type type2) => default; // 0x00000001897679A0-0x0000000189767A24
		internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) => default; // 0x0000000189768878-0x00000001897688D0
		internal static Exception InternalRBTreeError(RBTreeError internalError) => default; // 0x0000000189768720-0x0000000189768788
		public static Exception EnumeratorModified() => default; // 0x00000001897680F4-0x0000000189768128
	}

	[IsReadOnly]
	internal struct DataKey // TypeDefIndex: 49960
	{
		// Fields
		private readonly DataColumn[] _columns; // 0x00
	
		// Properties
		internal DataColumn[] ColumnsReference { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		internal bool HasValue { get => default; } // 0x00000001822B4F90-0x00000001822B4FA0 
		internal DataTable Table { get => default; } // 0x00000001897637C8-0x00000001897637F8 
	
		// Constructors
		internal DataKey(DataColumn[] columns, bool copyColumns) : this() {
			_columns = default;
		} // 0x00000001897635A0-0x00000001897637C8
	
		// Methods
		internal void CheckState() {} // 0x0000000189762EC8-0x0000000189762FB8
		internal bool ColumnsEqual(DataKey key) => default; // 0x0000000189763050-0x000000018976305C
		internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) => default; // 0x0000000189762FB8-0x0000000189763050
		internal bool ContainsColumn(DataColumn column) => default; // 0x000000018976305C-0x00000001897630A0
		public override int GetHashCode() => default; // 0x0000000189763214-0x0000000189763264
		public override bool Equals(object value) => default; // 0x0000000189763120-0x0000000189763174
		internal bool Equals(DataKey value) => default; // 0x00000001897630A0-0x0000000189763120
		internal string[] GetColumnNames() => default; // 0x0000000189763174-0x0000000189763214
		internal IndexField[] GetIndexDesc() => default; // 0x0000000189763264-0x000000018976332C
		internal object[] GetKeyValues(int record) => default; // 0x000000018976332C-0x0000000189763400
		internal Index GetSortIndex() => default; // 0x0000000189763464-0x0000000189763474
		internal Index GetSortIndex(DataViewRowState recordStates) => default; // 0x0000000189763400-0x0000000189763464
		internal bool RecordsEqual(int record1, int record2) => default; // 0x0000000189763474-0x00000001897634F0
		internal DataColumn[] ToArray() => default; // 0x00000001897634F0-0x00000001897635A0
	}

	[DefaultProperty("RelationName")]
	[TypeConverter(typeof(RelationshipConverter))]
	public class DataRelation // TypeDefIndex: 49961
	{
		// Fields
		private DataSet _dataSet; // 0x10
		internal PropertyCollection _extendedProperties; // 0x18
		internal string _relationName; // 0x20
		private DataKey _childKey; // 0x28
		private DataKey _parentKey; // 0x30
		private UniqueConstraint _parentKeyConstraint; // 0x38
		private ForeignKeyConstraint _childKeyConstraint; // 0x40
		internal string[] _parentColumnNames; // 0x48
		internal string[] _childColumnNames; // 0x50
		internal string _parentTableName; // 0x58
		internal string _childTableName; // 0x60
		internal string _parentTableNamespace; // 0x68
		internal string _childTableNamespace; // 0x70
		internal bool _nested; // 0x78
		internal bool _createConstraints; // 0x79
		private bool _checkMultipleNested; // 0x7A
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0x7C
	
		// Properties
		public virtual DataColumn[] ChildColumns { get => default; } // 0x0000000189765904-0x0000000189765924 
		internal DataColumn[] ChildColumnsReference { get => default; } // 0x00000001897658E8-0x0000000189765904 
		internal DataKey ChildKey { get => default; } // 0x00000001897658E8-0x0000000189765904 
		public virtual DataTable ChildTable { get => default; } // 0x0000000189765940-0x0000000189765960 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual DataSet DataSet { get => default; } // 0x0000000189765960-0x000000018976597C 
		internal string[] ParentColumnNames { get => default; } // 0x0000000189765A0C-0x0000000189765A18 
		internal string[] ChildColumnNames { get => default; } // 0x00000001897658DC-0x00000001897658E8 
		public virtual DataColumn[] ParentColumns { get => default; } // 0x0000000189765A18-0x0000000189765A38 
		internal DataColumn[] ParentColumnsReference { get => default; } // 0x0000000181003830-0x0000000181003840 
		internal DataKey ParentKey { get => default; } // 0x0000000189765A54-0x0000000189765A70 
		public virtual DataTable ParentTable { get => default; } // 0x0000000189765A70-0x0000000189765A90 
		[DefaultValue("")]
		public virtual string RelationName { get => default; } // 0x000000018976504C-0x0000000189765068 
		[DefaultValue(false)]
		public virtual bool Nested { get => default; set {} } // 0x00000001897659F0-0x0000000189765A0C 0x0000000189765A90-0x00000001897666A8
		public virtual UniqueConstraint ParentKeyConstraint { get => default; } // 0x0000000189765A38-0x0000000189765A54 
		public virtual ForeignKeyConstraint ChildKeyConstraint { get => default; } // 0x0000000189765924-0x0000000189765940 
		[Browsable(false)]
		public PropertyCollection ExtendedProperties { get => default; } // 0x000000018976597C-0x00000001897659F0 
		internal bool CheckMultipleNested { get => default; set {} } // 0x0000000183D51AF0-0x0000000183D51B00 0x0000000183D51B50-0x0000000183D51B60
		internal int ObjectID { get => default; } // 0x0000000183D4EC90-0x0000000183D4ECA0 
	
		// Constructors
		public DataRelation() {} // Dummy constructor
		public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) {} // 0x0000000189765408-0x00000001897655E0
		public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) {} // 0x00000001897656A4-0x00000001897656C0
		public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) {} // 0x00000001897655E0-0x00000001897656A4
		[Browsable(false)]
		public DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) {} // 0x00000001897657E0-0x00000001897658DC
		[Browsable(false)]
		public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) {} // 0x00000001897656C0-0x00000001897657E0
	
		// Methods
		private static bool IsKeyNull(object[] values) => default; // 0x0000000189764E84-0x0000000189764F08
		internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) => default; // 0x0000000189764A54-0x0000000189764AF0
		internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) => default; // 0x0000000189764C48-0x0000000189764CE0
		internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) => default; // 0x0000000189764AF0-0x0000000189764C48
		internal void SetDataSet(DataSet dataSet) {} // 0x0000000189765038-0x000000018976504C
		internal void CheckNamespaceValidityForNestedRelations(string ns) {} // 0x00000001897637F8-0x0000000189763A34
		internal void CheckNestedRelations() {} // 0x0000000189763A34-0x0000000189763D64
		internal void SetParentKeyConstraint(UniqueConstraint value) {} // 0x000000018388FF30-0x000000018388FF40
		internal void SetChildKeyConstraint(ForeignKeyConstraint value) {} // 0x0000000183CB2D80-0x0000000183CB2D90
		internal void CheckState() {} // 0x0000000189763E7C-0x00000001897640F0
		protected void CheckStateForProperty() {} // 0x0000000189763D64-0x0000000189763E7C
		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) {} // 0x00000001897646C4-0x0000000189764A54
		internal DataRelation Clone(DataSet destination) => default; // 0x00000001897640F0-0x00000001897646C4
		protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) {} // 0x0000000189764F08-0x0000000189764FC0
		protected internal void RaisePropertyChanging(string name) {} // 0x0000000189764FC0-0x0000000189765038
		public override string ToString() => default; // 0x000000018976504C-0x0000000189765068
		internal void ValidateMultipleNestedRelations() {} // 0x0000000189765068-0x0000000189765408
		private bool IsAutoGenerated(DataColumn col) => default; // 0x0000000189764CE0-0x0000000189764E84
	}

	[DefaultEvent("CollectionChanged")]
	[DefaultProperty("Table")]
	public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 49964
	{
		// Fields
		private DataRelation _inTransition; // 0x10
		private int _defaultNameIndex; // 0x18
		private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
		private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0x30
	
		// Properties
		internal int ObjectID { get; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public abstract DataRelation this[int index] { get => default; }
		public abstract DataRelation this[string name] { get => default; }
	
		// Events
		public event CollectionChangeEventHandler CollectionChanged;
	
		// Nested types
		internal sealed class DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 49962
		{
			// Fields
			private readonly DataTable _table; // 0x38
			private readonly ArrayList _relations; // 0x40
			private readonly bool _fParentCollection; // 0x48
	
			// Properties
			protected override ArrayList List { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
			public override DataRelation this[int index] { get => default; } // 0x0000000189794034-0x00000001897940F4 
			public override DataRelation this[string name] { get => default; } // 0x0000000189793F7C-0x0000000189794034 
	
			// Events
			internal event CollectionChangeEventHandler RelationPropertyChanged;
	
			// Constructors
			public DataTableRelationCollection() {} // Dummy constructor
			internal DataTableRelationCollection(DataTable table, bool fParentCollection) {} // 0x0000000189793E30-0x0000000189793EE8
	
			// Methods
			private void EnsureDataSet() {} // 0x0000000189793C44-0x0000000189793C90
			protected override DataSet GetDataSet() => default; // 0x0000000189793C90-0x0000000189793CBC
			private void AddCache(DataRelation relation) {} // 0x0000000189793B44-0x0000000189793B88
			protected override void AddCore(DataRelation relation) {} // 0x0000000189793B88-0x0000000189793C44
			private void RemoveCache(DataRelation relation) {} // 0x0000000189793CBC-0x0000000189793D74
			protected override void RemoveCore(DataRelation relation) {} // 0x0000000189793D74-0x0000000189793E30
		}
	
		internal sealed class DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 49963
		{
			// Fields
			private readonly DataSet _dataSet; // 0x38
			private readonly ArrayList _relations; // 0x40
			private DataRelation[] _delayLoadingRelations; // 0x48
	
			// Properties
			protected override ArrayList List { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
			public override DataRelation this[int index] { get => default; } // 0x00000001897872D0-0x0000000189787390 
			public override DataRelation this[string name] { get => default; } // 0x0000000189787218-0x00000001897872D0 
	
			// Constructors
			public DataSetRelationCollection() {} // Dummy constructor
			internal DataSetRelationCollection(DataSet dataSet) {} // 0x0000000189787170-0x0000000189787218
	
			// Methods
			public override void Clear() {} // 0x0000000189786EEC-0x0000000189786F34
			protected override DataSet GetDataSet() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
			protected override void AddCore(DataRelation relation) {} // 0x0000000189786974-0x0000000189786EEC
			protected override void RemoveCore(DataRelation relation) {} // 0x0000000189786F34-0x0000000189787170
		}
	
		// Constructors
		protected DataRelationCollection() {} // 0x00000001897825C0-0x000000018978262C
	
		// Methods
		public void Add(DataRelation relation) {} // 0x000000018978160C-0x00000001897818AC
		protected virtual void AddCore(DataRelation relation) {} // 0x00000001897813A0-0x000000018978160C
		internal string AssignName() => default; // 0x00000001897818AC-0x00000001897818CC
		public virtual void Clear() {} // 0x00000001897818CC-0x0000000189781B08
		public virtual bool Contains(string name) => default; // 0x0000000189781B08-0x0000000189781B20
		internal int InternalIndexOf(string name) => default; // 0x0000000189781B20-0x0000000189781C50
		protected abstract DataSet GetDataSet();
		private string MakeName(int index) => default; // 0x0000000189781C50-0x0000000189781CDC
		protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) {} // 0x0000000189781CDC-0x0000000189781D8C
		protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) {} // 0x0000000189781D8C-0x0000000189781E3C
		internal void RegisterName(string name) {} // 0x0000000189781E3C-0x0000000189781FD4
		public void Remove(DataRelation relation) {} // 0x00000001897821E4-0x00000001897824AC
		public void RemoveAt(int index) {} // 0x0000000189781FD4-0x0000000189782050
		protected virtual void RemoveCore(DataRelation relation) {} // 0x0000000189782050-0x00000001897821E4
		internal void UnregisterName(string name) {} // 0x00000001897824AC-0x00000001897825C0
	}

	internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 49965
	{
		// Properties
		internal DataRelation Relation { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public override System.Type ComponentType { get => default; } // 0x0000000189782938-0x0000000189782988 
		public override bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override System.Type PropertyType { get => default; } // 0x0000000189782988-0x00000001897829D8 
	
		// Constructors
		public DataRelationPropertyDescriptor() {} // Dummy constructor
		internal DataRelationPropertyDescriptor(DataRelation dataRelation) {} // 0x00000001897828E4-0x0000000189782938
	
		// Methods
		public override bool Equals(object other) => default; // 0x000000018978280C-0x000000018978286C
		public override int GetHashCode() => default; // 0x000000018975C924-0x000000018975C948
		public override bool CanResetValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
		public override object GetValue(object component) => default; // 0x000000018978286C-0x00000001897828E4
		public override void ResetValue(object component) {} // 0x000000018350B670-0x000000018350B680
		public override void SetValue(object component, object value) {} // 0x000000018350B670-0x000000018350B680
		public override bool ShouldSerializeValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public class DataRow // TypeDefIndex: 49966
	{
		// Fields
		private readonly DataTable _table; // 0x10
		private readonly DataColumnCollection _columns; // 0x18
		internal int _oldRecord; // 0x20
		internal int _newRecord; // 0x24
		internal int _tempRecord; // 0x28
		internal long _rowID; // 0x30
		internal DataRowAction _action; // 0x38
		internal bool _inChangingEvent; // 0x3C
		internal bool _inDeletingEvent; // 0x3D
		internal bool _inCascade; // 0x3E
		private DataColumn _lastChangedColumn; // 0x40
		private int _countColumnChange; // 0x48
		private DataError _error; // 0x50
		private int _rbTreeNodeId; // 0x58
		private static int s_objectTypeCount; // 0x00
		internal readonly int _objectID; // 0x5C
	
		// Properties
		internal DataColumn LastChangedColumn { get => default; set {} } // 0x0000000189785E0C-0x0000000189785E1C 0x000000018978677C-0x000000018978678C
		internal bool HasPropertyChanged { get => default; } // 0x0000000189785D6C-0x0000000189785D74 
		internal int RBTreeNodeId { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x000000018978678C-0x0000000189786824
		public string RowError { get => default; set {} } // 0x0000000189785E1C-0x0000000189785E6C 0x0000000189786824-0x000000018978694C
		internal long rowID { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x000000018978694C-0x0000000189786974
		public DataRowState RowState { get => default; } // 0x0000000189785E6C-0x0000000189785FB8 
		public DataTable Table { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public object this[string columnName] { set {} } // 0x00000001897863FC-0x0000000189786430
		public object this[DataColumn column] { get => default; set {} } // 0x0000000189785DC8-0x0000000189785E0C 0x0000000189786430-0x000000018978677C
		public object this[DataColumn column, DataRowVersion version] { get => default; } // 0x0000000189785D74-0x0000000189785DC8 
		public object[] ItemArray { set {} } // 0x0000000189785FB8-0x00000001897863FC
		public bool HasErrors { get => default; } // 0x0000000189785D54-0x0000000189785D6C 
	
		// Constructors
		public DataRow() {} // Dummy constructor
		protected internal DataRow(DataRowBuilder builder) {} // 0x0000000189785CAC-0x0000000189785D54
	
		// Methods
		private void RowErrorChanged() {} // 0x0000000189785398-0x00000001897853E4
		internal void CheckForLoops(DataRelation rel) {} // 0x0000000189783DB8-0x0000000189783E90
		internal int GetNestedParentCount() => default; // 0x0000000189784734-0x00000001897847E0
		public void AcceptChanges() {} // 0x00000001897838C4-0x0000000189783C0C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void BeginEdit() {} // 0x0000000189783CC8-0x0000000189783CD0
		private bool BeginEditInternal() => default; // 0x0000000189783C0C-0x0000000189783CC8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void CancelEdit() {} // 0x0000000189783CD0-0x0000000189783D2C
		private void CheckColumn(DataColumn column) {} // 0x0000000189783D2C-0x0000000189783DB8
		internal void CheckInTable() {} // 0x0000000189783E90-0x0000000189783ECC
		public void Delete() {} // 0x0000000189784208-0x0000000189784260
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void EndEdit() {} // 0x0000000189784260-0x0000000189784334
		public void SetColumnError(int columnIndex, string error) {} // 0x0000000189785600-0x0000000189785678
		public void SetColumnError(DataColumn column, string error) {} // 0x00000001897853E4-0x0000000189785600
		public string GetColumnError(DataColumn column) => default; // 0x0000000189784470-0x000000018978450C
		public void ClearErrors() {} // 0x0000000189783F00-0x0000000189783F30
		internal void ClearError(DataColumn column) {} // 0x0000000189783ECC-0x0000000189783F00
		public DataColumn[] GetColumnsInError() => default; // 0x0000000189784564-0x00000001897845BC
		public DataRow[] GetChildRows(DataRelation relation) => default; // 0x0000000189784334-0x0000000189784344
		public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) => default; // 0x0000000189784344-0x0000000189784470
		internal DataColumn GetDataColumn(string columnName) => default; // 0x00000001897845FC-0x000000018978466C
		public DataRow GetParentRow(DataRelation relation) => default; // 0x00000001897849E8-0x00000001897849F8
		public DataRow GetParentRow(DataRelation relation, DataRowVersion version) => default; // 0x00000001897848CC-0x00000001897849E8
		internal DataRow GetNestedParentRow(DataRowVersion version) => default; // 0x00000001897847E0-0x000000018978488C
		public DataRow[] GetParentRows(DataRelation relation) => default; // 0x0000000189784B24-0x0000000189784B34
		public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) => default; // 0x00000001897849F8-0x0000000189784B24
		internal object[] GetColumnValues(DataColumn[] columns) => default; // 0x0000000189784554-0x0000000189784564
		internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) => default; // 0x000000018978450C-0x0000000189784554
		internal object[] GetKeyValues(DataKey key) => default; // 0x00000001897846E8-0x000000018978470C
		internal object[] GetKeyValues(DataKey key, DataRowVersion version) => default; // 0x000000018978470C-0x0000000189784734
		internal int GetCurrentRecordNo() => default; // 0x00000001897845BC-0x00000001897845FC
		internal int GetDefaultRecord() => default; // 0x000000018978466C-0x00000001897846C0
		internal int GetOriginalRecordNo() => default; // 0x000000018978488C-0x00000001897848CC
		private int GetProposedRecordNo() => default; // 0x0000000189784B34-0x0000000189784B74
		internal int GetRecordFromVersion(DataRowVersion version) => default; // 0x0000000189784B74-0x0000000189784BF4
		internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) => default; // 0x00000001897846C0-0x00000001897846E8
		internal DataViewRowState GetRecordState(int record) => default; // 0x0000000189784BF4-0x0000000189784C38
		internal bool HasKeyChanged(DataKey key) => default; // 0x0000000189784C38-0x0000000189784C5C
		internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) => default; // 0x0000000189784C5C-0x0000000189784CDC
		public bool HasVersion(DataRowVersion version) => default; // 0x0000000189784CDC-0x0000000189784D4C
		internal bool HaveValuesChanged(DataColumn[] columns) => default; // 0x0000000189784D4C-0x0000000189784D70
		internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) => default; // 0x0000000189784D70-0x0000000189784E04
		public void RejectChanges() {} // 0x0000000189784E04-0x0000000189785378
		internal void ResetLastChangedColumn() {} // 0x0000000189785378-0x0000000189785398
		internal void SetKeyValues(DataKey key, object[] keyValues) {} // 0x0000000189785678-0x0000000189785770
		internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) {} // 0x0000000189785770-0x00000001897859E0
		internal void SetParentRowToDBNull() {} // 0x00000001897859E0-0x0000000189785B58
		internal void SetParentRowToDBNull(DataRelation relation) {} // 0x0000000189785B58-0x0000000189785CAC
		internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) => default; // 0x0000000189783F30-0x0000000189784208
	}

	public sealed class DataRowBuilder // TypeDefIndex: 49967
	{
		// Fields
		internal readonly DataTable _table; // 0x10
		internal int _record; // 0x18
	
		// Constructors
		public DataRowBuilder() {} // Dummy constructor
		internal DataRowBuilder(DataTable table, int record) {} // 0x0000000182738A30-0x0000000182738A50
	}

	[Flags]
	public enum DataRowAction // TypeDefIndex: 49968
	{
		Nothing = 0,
		Delete = 1,
		Change = 2,
		Rollback = 4,
		Commit = 8,
		Add = 16,
		ChangeOriginal = 32,
		ChangeCurrentAndOriginal = 64
	}

	public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 49969
	{
		// Constructors
		public DataRowChangeEventArgs() {} // Dummy constructor
		public DataRowChangeEventArgs(DataRow row, DataRowAction action) {} // 0x00000001897829D8-0x0000000189782A38
	}

	public delegate void DataRowChangeEventHandler(object sender, DataRowChangeEventArgs e); // TypeDefIndex: 49970; 0x0000000182065C10-0x0000000182065C20

	public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 49972
	{
		// Fields
		private readonly DataTable _table; // 0x10
		private readonly DataRowTree _list; // 0x18
		internal int _nullInList; // 0x20
	
		// Properties
		public override int Count { get => default; } // 0x0000000189783084-0x00000001897830C4 
		public DataRow this[int index] { get => default; } // 0x00000001897830C4-0x0000000189783118 
	
		// Nested types
		private sealed class DataRowTree : RBTree<DataRow> // TypeDefIndex: 49971
		{
			// Constructors
			internal DataRowTree() {} // 0x00000001897831F4-0x0000000189783234
	
			// Methods
			protected override int CompareNode(DataRow record1, DataRow record2) => default; // 0x0000000189783194-0x00000001897831C4
			protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) => default; // 0x00000001897831C4-0x00000001897831F4
		}
	
		// Constructors
		public DataRowCollection() {} // Dummy constructor
		internal DataRowCollection(DataTable table) {} // 0x0000000189782FEC-0x0000000189783084
	
		// Methods
		public void Add(DataRow row) {} // 0x0000000189782AA8-0x0000000189782AD0
		internal void DiffInsertAt(DataRow row, int pos) {} // 0x0000000189782D54-0x0000000189782F20
		public int IndexOf(DataRow row) => default; // 0x0000000189782F68-0x0000000189782FEC
		internal DataRow AddWithColumnEvents(params object[] values) => default; // 0x0000000189782A38-0x0000000189782AA8
		internal void ArrayAdd(DataRow row) {} // 0x0000000189782AD0-0x0000000189782B38
		internal void ArrayInsert(DataRow row, int pos) {} // 0x0000000189782B80-0x0000000189782BF8
		internal void ArrayClear() {} // 0x0000000189782B38-0x0000000189782B80
		internal void ArrayRemove(DataRow row) {} // 0x0000000189782BF8-0x0000000189782C8C
		public override void CopyTo(Array ar, int index) {} // 0x0000000189782CF0-0x0000000189782D54
		public void CopyTo(DataRow[] array, int index) {} // 0x0000000189782C8C-0x0000000189782CF0
		public override IEnumerator GetEnumerator() => default; // 0x0000000189782F20-0x0000000189782F68
	}

	internal delegate void DataRowCreatedEventHandler(object sender, DataRow r); // TypeDefIndex: 49973; 0x0000000182065C10-0x0000000182065C20

	internal delegate void DataSetClearEventhandler(object sender, DataTable table); // TypeDefIndex: 49974; 0x0000000182065C10-0x0000000182065C20

	[Flags]
	public enum DataRowState // TypeDefIndex: 49975
	{
		Detached = 1,
		Unchanged = 2,
		Added = 4,
		Deleted = 8,
		Modified = 16
	}

	public enum DataRowVersion // TypeDefIndex: 49976
	{
		Original = 256,
		Current = 512,
		Proposed = 1024,
		Default = 1536
	}

	[DefaultMember("Item")]
	public class DataRowView : ICustomTypeDescriptor, INotifyPropertyChanged // TypeDefIndex: 49977
	{
		// Fields
		private readonly DataView _dataView; // 0x10
		private readonly DataRow _row; // 0x18
		private bool _delayBeginEdit; // 0x20
		private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x00
	
		// Properties
		public DataView DataView { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		private DataRowVersion RowVersionDefault { get => default; } // 0x0000000189783800-0x0000000189783830 
		public DataRow Row { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool IsNew { get => default; } // 0x00000001897837DC-0x0000000189783800 
	
		// Events
		public event PropertyChangedEventHandler PropertyChanged;
	
		// Constructors
		public DataRowView() {} // Dummy constructor
		internal DataRowView(DataView dataView, DataRow row) {} // 0x0000000182676770-0x00000001826767A0
		static DataRowView() {} // 0x00000001897836C8-0x0000000189783748
	
		// Methods
		public override bool Equals(object other) => default; // 0x000000018232CE30-0x000000018232CE40
		public override int GetHashCode() => default; // 0x0000000183D4A220-0x0000000183D4A250
		internal int GetRecord() => default; // 0x000000018978346C-0x000000018978349C
		internal bool HasRecord() => default; // 0x000000018978349C-0x00000001897834CC
		internal object GetColumnValue(DataColumn column) => default; // 0x000000018978342C-0x000000018978346C
		internal void SetColumnValue(DataColumn column, object value) {} // 0x000000018978355C-0x00000001897835F8
		public DataView CreateChildView(DataRelation relation, bool followParent) => default; // 0x0000000189783234-0x00000001897833D4
		public DataView CreateChildView(DataRelation relation) => default; // 0x00000001897833D4-0x00000001897833E0
		public void EndEdit() {} // 0x00000001897833E0-0x000000018978342C
		internal void RaisePropertyChangedEvent(string propName) {} // 0x00000001897834CC-0x000000018978355C
		AttributeCollection ICustomTypeDescriptor.GetAttributes() => default; // 0x00000001897835F8-0x000000018978364C
		TypeConverter ICustomTypeDescriptor.GetConverter() => default; // 0x0000000181002730-0x0000000181002740
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() => default; // 0x00000001892D18EC-0x00000001892D18F4
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes) => default; // 0x000000018978364C-0x00000001897836C8
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	public enum SerializationFormat // TypeDefIndex: 49978
	{
		Xml = 0,
		Binary = 1
	}

	[Serializable]
	[DefaultProperty("DataSetName")]
	[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[XmlRoot("DataSet")]
	[XmlSchemaProvider("GetDataSetSchema")]
	public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 49979
	{
		// Fields
		private DataViewManager _defaultViewManager; // 0x20
		private readonly DataTableCollection _tableCollection; // 0x28
		private readonly DataRelationCollection _relationCollection; // 0x30
		internal PropertyCollection _extendedProperties; // 0x38
		private string _dataSetName; // 0x40
		private string _datasetPrefix; // 0x48
		internal string _namespaceURI; // 0x50
		private bool _enforceConstraints; // 0x58
		private bool _caseSensitive; // 0x59
		private CultureInfo _culture; // 0x60
		private bool _cultureUserSet; // 0x68
		internal bool _fInReadXml; // 0x69
		internal bool _fInLoadDiffgram; // 0x6A
		internal bool _fTopLevelTable; // 0x6B
		internal bool _fInitInProgress; // 0x6C
		internal bool _fEnableCascading; // 0x6D
		internal bool _fIsSchemaLoading; // 0x6E
		internal string _mainTableName; // 0x70
		private System.Data.SerializationFormat _remotingFormat; // 0x78
		private object _defaultViewManagerLock; // 0x80
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0x88
		private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x08
		internal bool _useDataSetSchemaOnly; // 0x8C
		internal bool _udtIsWrapped; // 0x8D
	
		// Properties
		[DefaultValue(System.Data.SerializationFormat.Xml)]
		public System.Data.SerializationFormat RemotingFormat { get => default; set {} } // 0x0000000183D4EC40-0x0000000183D4EC50 0x0000000189791670-0x0000000189791708
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual SchemaSerializationMode SchemaSerializationMode { get => default; } // 0x0000000181168950-0x0000000181168960 
		[DefaultValue(false)]
		public bool CaseSensitive { get => default; set {} } // 0x0000000183D589D0-0x0000000183D589E0 0x0000000189790A94-0x0000000189790D78
		[DefaultValue(true)]
		public bool EnforceConstraints { get => default; set {} } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000189790ED0-0x0000000189791014
		[DefaultValue("")]
		public string DataSetName { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000189790D78-0x0000000189790ED0
		[DefaultValue("")]
		public string Namespace { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000189791170-0x0000000189791564
		[DefaultValue("")]
		public string Prefix { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000189791564-0x0000000189791670
		[Browsable(false)]
		public PropertyCollection ExtendedProperties { get => default; } // 0x0000000189790A20-0x0000000189790A94 
		public CultureInfo Locale { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x0000000189791014-0x0000000189791170
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ISite Site { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataRelationCollection Relations { get => default; } // 0x0000000181003830-0x0000000181003840 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataTableCollection Tables { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		internal string MainTableName { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		internal int ObjectID { get => default; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 
	
		// Constructors
		public DataSet() {} // 0x00000001897905F4-0x0000000189790854
		public DataSet(string dataSetName) {} // 0x00000001897909F0-0x0000000189790A20
		protected DataSet(SerializationInfo info, StreamingContext context) {} // 0x00000001897909C8-0x00000001897909F0
		protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema) {} // 0x0000000189790854-0x00000001897909C8
	
		// Methods
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001897897C8-0x00000001897897F4
		protected virtual void InitializeDerivedDataSet() {} // 0x000000018350B670-0x000000018350B680
		private void SerializeDataSet(SerializationInfo info, StreamingContext context, System.Data.SerializationFormat remotingFormat) {} // 0x000000018978E144-0x000000018978E6B4
		internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, System.Data.SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) {} // 0x00000001897888C4-0x000000018978893C
		private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, System.Data.SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) {} // 0x0000000189788474-0x00000001897888C4
		private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, System.Data.SerializationFormat remotingFormat) {} // 0x0000000189788084-0x0000000189788230
		private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) {} // 0x000000018978E008-0x000000018978E144
		private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) {} // 0x0000000189788230-0x0000000189788474
		private void SerializeRelations(SerializationInfo info, StreamingContext context) {} // 0x000000018978E6B4-0x000000018978ECB0
		private void DeserializeRelations(SerializationInfo info, StreamingContext context) {} // 0x000000018978893C-0x0000000189788F64
		internal void FailedEnableConstraints() {} // 0x0000000189789518-0x000000018978954C
		internal void RestoreEnforceConstraints(bool value) {} // 0x0000000183D4F7F0-0x0000000183D4F800
		internal void EnableConstraints() {} // 0x0000000189788F64-0x00000001897893E8
		internal void SetLocaleValue(CultureInfo value, bool userSet) {} // 0x000000018978ECB0-0x000000018978F4FC
		internal bool ShouldSerializeLocale() => default; // 0x0000000183D4F3F0-0x0000000183D4F400
		public void Clear() {} // 0x0000000189787390-0x0000000189787528
		public virtual DataSet Clone() => default; // 0x0000000189787528-0x0000000189788084
		internal int EstimatedXmlStringSize() => default; // 0x00000001897893E8-0x0000000189789518
		internal string GetRemotingDiffGram(DataTable table) => default; // 0x00000001897897F4-0x0000000189789914
		internal string GetXmlSchemaForRemoting(DataTable table) => default; // 0x0000000189789914-0x0000000189789A70
		public void ReadXmlSchema(XmlReader reader) {} // 0x000000018978B4D4-0x000000018978B4E0
		internal void ReadXmlSchema(XmlReader reader, bool denyResolving) {} // 0x000000018978B4E0-0x000000018978BC0C
		internal bool MoveToElement(XmlReader reader, int depth) => default; // 0x0000000189775878-0x0000000189775908
		private static void MoveToElement(XmlReader reader) {} // 0x000000018978A280-0x000000018978A2E0
		internal void ReadEndElement(XmlReader reader) {} // 0x0000000189776FF8-0x0000000189777064
		internal void ReadXSDSchema(XmlReader reader, bool denyResolving) {} // 0x000000018978A61C-0x000000018978A84C
		internal void ReadXDRSchema(XmlReader reader) {} // 0x000000018978A500-0x000000018978A61C
		private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<System.Type, string> multipleTargetConverter) {} // 0x00000001897900C4-0x0000000189790338
		public XmlReadMode ReadXml(XmlReader reader) => default; // 0x000000018978DDD8-0x000000018978DDE4
		internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) => default; // 0x000000018978CD98-0x000000018978DDD8
		internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) {} // 0x0000000189789A70-0x0000000189789D5C
		private bool IsEmpty() => default; // 0x0000000189789D5C-0x0000000189789EEC
		private void ReadXmlDiffgram(XmlReader reader) {} // 0x000000018978A84C-0x000000018978B4D4
		public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) => default; // 0x000000018978BEF0-0x000000018978BF0C
		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) => default; // 0x000000018978BF0C-0x000000018978CD98
		public void WriteXml(XmlWriter writer, XmlWriteMode mode) {} // 0x0000000189790338-0x00000001897905F4
		public void Merge(DataSet dataSet) {} // 0x0000000189789EEC-0x000000018978A04C
		public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) {} // 0x000000018978A04C-0x000000018978A280
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) {} // 0x000000018978A384-0x000000018978A3A4
		internal void OnMergeFailed(MergeFailedEventArgs mfevent) {} // 0x000000018978A320-0x000000018978A384
		internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) {} // 0x000000018978A3D4-0x000000018978A488
		internal void OnDataRowCreated(DataRow row) {} // 0x000000018978A300-0x000000018978A320
		internal void OnClearFunctionCalled(DataTable table) {} // 0x000000018978A2E0-0x000000018978A300
		protected internal virtual void OnRemoveTable(DataTable table) {} // 0x000000018350B670-0x000000018350B680
		internal void OnRemovedTable(DataTable table) {} // 0x000000018978A3A4-0x000000018978A3D4
		protected virtual void OnRemoveRelation(DataRelation relation) {} // 0x000000018350B670-0x000000018350B680
		internal void OnRemoveRelationHack(DataRelation relation) {} // 0x000000018350B670-0x000000018350B680
		protected internal void RaisePropertyChanging(string name) {} // 0x000000018978A488-0x000000018978A500
		internal DataTable[] TopLevelTables() => default; // 0x000000018978F7FC-0x000000018978F808
		internal DataTable[] TopLevelTables(bool forSchema) => default; // 0x000000018978F808-0x000000018978F9DC
		public virtual void Reset() {} // 0x000000018978DDE4-0x000000018978E008
		internal bool ValidateCaseConstraint() => default; // 0x000000018978F9DC-0x000000018978FD28
		internal bool ValidateLocaleConstraint() => default; // 0x000000018978FD28-0x00000001897900C4
		protected virtual void ReadXmlSerializable(XmlReader reader) {} // 0x000000018978BC0C-0x000000018978BEF0
		public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) => default; // 0x000000018978954C-0x00000001897897C8
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x000000018978F4FC-0x000000018978F698
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x000000018978F698-0x000000018978F7B4
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x000000018978F7B4-0x000000018978F7FC
	}

	public enum DataSetDateTime // TypeDefIndex: 49980
	{
		Local = 1,
		Unspecified = 2,
		UnspecifiedLocal = 3,
		Utc = 4
	}

	[Serializable]
	[DefaultEvent("RowChanging")]
	[DefaultProperty("TableName")]
	[DesignTimeVisible(false)]
	[ToolboxItem(false)]
	[XmlSchemaProvider("GetDataTableSchema")]
	public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 49983
	{
		// Fields
		private DataSet _dataSet; // 0x20
		private DataView _defaultView; // 0x28
		internal long _nextRowID; // 0x30
		internal readonly DataRowCollection _rowCollection; // 0x38
		internal readonly DataColumnCollection _columnCollection; // 0x40
		private readonly ConstraintCollection _constraintCollection; // 0x48
		private int _elementColumnCount; // 0x50
		internal DataRelationCollection _parentRelationsCollection; // 0x58
		internal DataRelationCollection _childRelationsCollection; // 0x60
		internal readonly RecordManager _recordManager; // 0x68
		internal readonly List<Index> _indexes; // 0x70
		private List<Index> _shadowIndexes; // 0x78
		private int _shadowCount; // 0x80
		internal PropertyCollection _extendedProperties; // 0x88
		private string _tableName; // 0x90
		internal string _tableNamespace; // 0x98
		private string _tablePrefix; // 0xA0
		internal DataExpression _displayExpression; // 0xA8
		internal bool _fNestedInDataset; // 0xB0
		private CultureInfo _culture; // 0xB8
		private bool _cultureUserSet; // 0xC0
		private CompareInfo _compareInfo; // 0xC8
		private CompareOptions _compareFlags; // 0xD0
		private IFormatProvider _formatProvider; // 0xD8
		private StringComparer _hashCodeProvider; // 0xE0
		private bool _caseSensitive; // 0xE8
		private bool _caseSensitiveUserSet; // 0xE9
		internal string _encodedTableName; // 0xF0
		internal DataColumn _xmlText; // 0xF8
		internal DataColumn _colUnique; // 0x100
		internal decimal _minOccurs; // 0x108
		internal decimal _maxOccurs; // 0x118
		internal bool _repeatableElement; // 0x128
		private object _typeName; // 0x130
		internal UniqueConstraint _primaryKey; // 0x138
		internal IndexField[] _primaryIndex; // 0x140
		private DataColumn[] _delayedSetPrimaryKey; // 0x148
		private Index _loadIndex; // 0x150
		private Index _loadIndexwithOriginalAdded; // 0x158
		private Index _loadIndexwithCurrentDeleted; // 0x160
		private int _suspendIndexEvents; // 0x168
		private bool _inDataLoad; // 0x16C
		private bool _schemaLoading; // 0x16D
		private bool _enforceConstraints; // 0x16E
		internal bool _suspendEnforceConstraints; // 0x16F
		protected internal bool fInitInProgress; // 0x170
		private bool _inLoad; // 0x171
		internal bool _fInLoadDiffgram; // 0x172
		private byte _isTypedDataTable; // 0x173
		private DataRow[] _emptyDataRowArray; // 0x178
		private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
		private DataRelation[] _nestedParentRelations; // 0x188
		internal List<DataColumn> _dependentColumns; // 0x190
		private bool _mergingData; // 0x198
		private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
		private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
		private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
		private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
		private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
		private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
		private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
		private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
		private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
		private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
		private readonly DataRowBuilder _rowBuilder; // 0x1F0
		internal readonly List<DataView> _delayedViews; // 0x1F8
		private readonly List<DataViewListener> _dataViewListeners; // 0x200
		internal Hashtable _rowDiffId; // 0x208
		internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
		internal int _ukColumnPositionForInference; // 0x218
		private System.Data.SerializationFormat _remotingFormat; // 0x21C
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0x220
	
		// Properties
		public bool CaseSensitive { get => default; set {} } // 0x0000000183D554A0-0x0000000183D554B0 0x000000018977FE94-0x000000018977FF4C
		internal bool AreIndexEventsSuspended { get => default; } // 0x000000018977F288-0x000000018977F294 
		private bool IsTypedDataTable { get => default; } // 0x000000018977F560-0x000000018977F5F4 
		internal bool SelfNested { get => default; } // 0x000000018977FB80-0x000000018977FE28 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal List<Index> LiveIndexes { get => default; } // 0x000000018977F5F4-0x000000018977F688 
		[DefaultValue(System.Data.SerializationFormat.Xml)]
		public System.Data.SerializationFormat RemotingFormat { get => default; set {} } // 0x0000000183D75460-0x0000000183D75470 0x0000000189780C08-0x0000000189780C7C
		internal int UKColumnPositionForInference { get => default; set {} } // 0x0000000183D5A730-0x0000000183D5A740 0x0000000183D5A740-0x0000000183D5A750
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataRelationCollection ChildRelations { get => default; } // 0x000000018977F294-0x000000018977F30C 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataColumnCollection Columns { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		private CompareInfo CompareInfo { get => default; } // 0x000000018977F30C-0x000000018977F35C 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ConstraintCollection Constraints { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataSet DataSet { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal string DisplayExpressionInternal { get => default; } // 0x000000018977F35C-0x000000018977F3B8 
		internal bool EnforceConstraints { get => default; set {} } // 0x000000018977F430-0x000000018977F454 0x000000018977FF94-0x000000018977FFD0
		internal bool SuspendEnforceConstraints { get => default; set {} } // 0x0000000183D75480-0x0000000183D75490 0x0000000183D754B0-0x0000000183D754C0
		[Browsable(false)]
		public PropertyCollection ExtendedProperties { get => default; } // 0x000000018977F454-0x000000018977F4D0 
		internal IFormatProvider FormatProvider { get => default; } // 0x000000018977F4D0-0x000000018977F560 
		public CultureInfo Locale { get => default; set {} } // 0x0000000183D4E750-0x0000000183D4E760 0x000000018977FFD0-0x000000018978044C
		[DefaultValue(50)]
		public int MinimumCapacity { get => default; set {} } // 0x000000018977F688-0x000000018977F6A4 0x000000018978044C-0x0000000189780478
		internal int RecordCapacity { get => default; } // 0x000000018977FAE8-0x000000018977FB04 
		internal int ElementColumnCount { get => default; set {} } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x000000018977FF4C-0x000000018977FF94
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DataRelationCollection ParentRelations { get => default; } // 0x000000018977FA10-0x000000018977FA88 
		internal bool MergingData { get => default; set {} } // 0x0000000183D5AF90-0x0000000183D5AFA0 0x0000000183D5B0F0-0x0000000183D5B100
		internal DataRelation[] NestedParentRelations { get => default; } // 0x0000000183D56AF0-0x0000000183D56B00 
		internal bool SchemaLoading { get => default; } // 0x0000000183D75470-0x0000000183D75480 
		internal int NestedParentsCount { get => default; } // 0x000000018977F75C-0x000000018977FA10 
		[TypeConverter(typeof(PrimaryKeyTypeConverter))]
		public DataColumn[] PrimaryKey { get => default; set {} } // 0x000000018977FA88-0x000000018977FAE8 0x0000000189780870-0x0000000189780C08
		[Browsable(false)]
		public DataRowCollection Rows { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.All)]
		public string TableName { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x0000000189780C7C-0x0000000189781270
		internal string EncodedTableName { get => default; } // 0x000000018977F3B8-0x000000018977F430 
		public string Namespace { get => default; set {} } // 0x000000018977F6A4-0x000000018977F728 0x0000000189780478-0x0000000189780720
		[DefaultValue("")]
		public string Prefix { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000189780720-0x0000000189780870
		internal DataColumn XmlText { get => default; set {} } // 0x0000000183D50160-0x0000000183D50170 0x0000000189781270-0x000000018978132C
		internal decimal MaxOccurs { get => default; set {} } // 0x0000000183D75430-0x0000000183D75440 0x0000000183D75490-0x0000000183D754A0
		internal decimal MinOccurs { get => default; set {} } // 0x0000000183D75440-0x0000000183D75450 0x0000000183D754A0-0x0000000183D754B0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ISite Site { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		internal bool NeedColumnChangeEvents { get => default; } // 0x000000018977F728-0x000000018977F75C 
		internal XmlQualifiedName TypeName { get => default; set {} } // 0x000000018977FE28-0x000000018977FE94 0x0000000184275CCC-0x0000000184275CE0
		internal Hashtable RowDiffId { get => default; } // 0x000000018977FB04-0x000000018977FB80 
		internal int ObjectID { get => default; } // 0x0000000183D75450-0x0000000183D75460 
	
		// Nested types
		internal struct RowDiffIdUsageSection // TypeDefIndex: 49981
		{
			// Fields
			private DataTable _targetTable; // 0x00
	
			// Methods
			internal void Prepare(DataTable table) {} // 0x0000000189796B10-0x0000000189796B48
		}
	
		internal struct DSRowDiffIdUsageSection // TypeDefIndex: 49982
		{
			// Fields
			private DataSet _targetDS; // 0x00
	
			// Methods
			internal void Prepare(DataSet ds) {} // 0x000000018978132C-0x00000001897813A0
		}
	
		// Constructors
		public DataTable() {} // 0x000000018977EC04-0x000000018977F0C0
		public DataTable(string tableName) {} // 0x000000018977F0C0-0x000000018977F12C
		protected DataTable(SerializationInfo info, StreamingContext context) {} // 0x000000018977F12C-0x000000018977F288
	
		// Methods
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189773860-0x000000018977392C
		private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat) {} // 0x000000018977B1FC-0x000000018977B4D8
		internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, System.Data.SerializationFormat remotingFormat) {} // 0x000000018976F820-0x000000018976FB68
		internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) {} // 0x000000018977BBB0-0x000000018977C7C0
		internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) {} // 0x00000001897704C8-0x0000000189771198
		internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) {} // 0x000000018977AC60-0x000000018977B1FC
		internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) {} // 0x000000018976EF08-0x000000018976F820
		internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) {} // 0x000000018977B4D8-0x000000018977B614
		internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) {} // 0x000000018976FB68-0x000000018976FCB0
		internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) {} // 0x000000018977B614-0x000000018977BBB0
		internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) {} // 0x000000018976FCB0-0x00000001897704C8
		private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) => default; // 0x000000018976E638-0x000000018976E6E0
		internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) {} // 0x0000000189773B34-0x0000000189773D50
		private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) {} // 0x000000018976E410-0x000000018976E638
		internal void RestoreIndexEvents(bool forceReset) {} // 0x000000018977A794-0x000000018977AADC
		internal void SuspendIndexEvents() {} // 0x000000018977E21C-0x000000018977E2B4
		internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) => default; // 0x000000018977C7C0-0x000000018977CA98
		internal bool ShouldSerializeCaseSensitive() => default; // 0x0000000183D58EB0-0x0000000183D58EC0
		private void ResetConstraints() {} // 0x000000018977A3C8-0x000000018977A3E8
		internal void SetDataSet(DataSet dataSet) {} // 0x000000018977CA98-0x000000018977CB38
		internal void EnableConstraints() {} // 0x00000001897714D8-0x000000018977186C
		internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) => default; // 0x000000018977CBB4-0x000000018977D11C
		internal bool ShouldSerializeLocale() => default; // 0x0000000183D583F0-0x0000000183D58400
		internal void CacheNestedParent() {} // 0x000000018976BCF4-0x000000018976BD1C
		private DataRelation[] FindNestedParentRelations() => default; // 0x0000000189772DA0-0x0000000189772FFC
		private string GetInheritedNamespace(List<DataTable> visitedTables) => default; // 0x000000018977367C-0x0000000189773860
		internal bool IsNamespaceInherited() => default; // 0x0000000189774EB8-0x0000000189774EC4
		internal void CheckCascadingNamespaceConflict(string realNamespace) {} // 0x000000018976BDE4-0x000000018976C054
		internal void CheckNamespaceValidityForNestedRelations(string realNamespace) {} // 0x000000018976C774-0x000000018976CB04
		internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) {} // 0x000000018976C56C-0x000000018976C774
		internal void DoRaiseNamespaceChange() {} // 0x0000000189771198-0x00000001897714D8
		internal void SetKeyValues(DataKey key, object[] keyValues, int record) {} // 0x000000018977CB38-0x000000018977CBB4
		internal DataRow FindByIndex(Index ndx, object[] key) => default; // 0x0000000189772CC4-0x0000000189772D40
		internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) => default; // 0x0000000189772D40-0x0000000189772DA0
		private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) {} // 0x000000018977D11C-0x000000018977D1C4
		internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) => default; // 0x0000000189774F1C-0x0000000189775624
		protected virtual DataTable CreateInstance() => default; // 0x000000018976E914-0x000000018976E968
		public virtual DataTable Clone() => default; // 0x000000018976E164-0x000000018976E170
		internal DataTable Clone(DataSet cloneDS) => default; // 0x000000018976DFA8-0x000000018976E164
		private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) => default; // 0x0000000189774010-0x0000000189774204
		private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) => default; // 0x000000018976D13C-0x000000018976D4C8
		private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) => default; // 0x000000018976D4C8-0x000000018976DFA8
		internal void AddRow(DataRow row, int proposedID) {} // 0x000000018976BA4C-0x000000018976BA6C
		internal void InsertRow(DataRow row, int proposedID, int pos) {} // 0x0000000189774CF4-0x0000000189774D14
		internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) {} // 0x0000000189774844-0x0000000189774CF4
		internal void CheckNotModifying(DataRow row) {} // 0x000000018976CB04-0x000000018976CB30
		public void Clear() {} // 0x000000018976CB30-0x000000018976CB3C
		internal void Clear(bool clearAll) {} // 0x000000018976CB3C-0x000000018976D13C
		internal void CascadeAll(DataRow row, DataRowAction action) {} // 0x000000018976BD1C-0x000000018976BDE4
		internal void CommitRow(DataRow row) {} // 0x000000018976E170-0x000000018976E200
		internal int Compare(string s1, string s2) => default; // 0x000000018976E340-0x000000018976E35C
		internal int Compare(string s1, string s2, CompareInfo comparer) => default; // 0x000000018976E200-0x000000018976E340
		internal int IndexOf(string s1, string s2) => default; // 0x0000000189774204-0x000000018977425C
		internal bool IsSuffix(string s1, string s2) => default; // 0x0000000189774EC4-0x0000000189774F1C
		public object Compute(string expression, string filter) => default; // 0x000000018976E35C-0x000000018976E410
		internal void DeleteRow(DataRow row) {} // 0x000000018976EEA4-0x000000018976EF08
		internal string FormatSortString(IndexField[] indexDesc) => default; // 0x0000000189772FFC-0x00000001897730F8
		internal void FreeRecord(ref int record) {} // 0x00000001897730F8-0x0000000189773118
		internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) => default; // 0x0000000189773630-0x000000018977367C
		internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) => default; // 0x0000000189773334-0x0000000189773630
		internal List<DataViewListener> GetListeners() => default; // 0x0000000183D56BB0-0x0000000183D56BC0
		internal int GetSpecialHashCode(string name) => default; // 0x0000000189773F3C-0x0000000189774010
		internal void InsertRow(DataRow row, long proposedID) {} // 0x00000001897743D0-0x0000000189774844
		internal int NewRecord() => default; // 0x0000000189775964-0x0000000189775974
		internal int NewUninitializedRecord() => default; // 0x0000000189775D08-0x0000000189775D28
		internal int NewRecord(int sourceRecord) => default; // 0x0000000189775974-0x0000000189775A54
		internal DataRow NewEmptyRow() => default; // 0x0000000189775908-0x0000000189775964
		private DataRow NewUninitializedRow() => default; // 0x0000000189775D28-0x0000000189775D4C
		public DataRow NewRow() => default; // 0x0000000189775CCC-0x0000000189775D08
		internal DataRow CreateEmptyRow() => default; // 0x000000018976E6E0-0x000000018976E914
		private void NewRowCreated(DataRow row) {} // 0x0000000189775B58-0x0000000189775BDC
		internal DataRow NewRow(int record) => default; // 0x0000000189775C3C-0x0000000189775CCC
		protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) => default; // 0x0000000189775BDC-0x0000000189775C3C
		protected virtual System.Type GetRowType() => default; // 0x0000000189773D50-0x0000000189773DA0
		protected internal DataRow[] NewRowArray(int size) => default; // 0x0000000189775A54-0x0000000189775B58
		protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) {} // 0x0000000189775E04-0x0000000189775EBC
		protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) {} // 0x0000000189775D4C-0x0000000189775E04
		protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) {} // 0x0000000189775EBC-0x0000000189775F74
		internal void OnRemoveColumnInternal(DataColumn column) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRemoveColumn(DataColumn column) {} // 0x000000018350B670-0x000000018350B680
		private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) => default; // 0x0000000189775F74-0x0000000189776020
		private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) => default; // 0x00000001897760D8-0x0000000189776184
		protected virtual void OnRowChanged(DataRowChangeEventArgs e) {} // 0x0000000189776020-0x00000001897760D8
		protected virtual void OnRowChanging(DataRowChangeEventArgs e) {} // 0x0000000189776184-0x000000018977623C
		protected virtual void OnRowDeleting(DataRowChangeEventArgs e) {} // 0x00000001897762F4-0x00000001897763AC
		protected virtual void OnRowDeleted(DataRowChangeEventArgs e) {} // 0x000000018977623C-0x00000001897762F4
		protected virtual void OnTableCleared(DataTableClearEventArgs e) {} // 0x00000001897763AC-0x0000000189776464
		protected virtual void OnTableClearing(DataTableClearEventArgs e) {} // 0x0000000189776464-0x000000018977651C
		protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) {} // 0x000000018977651C-0x00000001897765D4
		internal IndexField[] ParseSortString(string sortString) => default; // 0x00000001897765D4-0x00000001897768E4
		internal void RaisePropertyChanging(string name) {} // 0x00000001897768E4-0x000000018977695C
		internal void RecordChanged(int record) {} // 0x0000000189779A84-0x0000000189779B9C
		internal void RecordChanged(int[] oldIndex, int[] newIndex) {} // 0x0000000189779B9C-0x0000000189779D00
		internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) {} // 0x0000000189779EB8-0x0000000189779FF0
		internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) {} // 0x0000000189779D00-0x0000000189779EB8
		internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) => default; // 0x000000018977A078-0x000000018977A22C
		internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) => default; // 0x000000018977425C-0x00000001897743D0
		internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) {} // 0x000000018977E090-0x000000018977E21C
		internal void RemoveRow(DataRow row, bool check) {} // 0x000000018977A22C-0x000000018977A3C8
		public virtual void Reset() {} // 0x000000018977A578-0x000000018977A75C
		internal void ResetIndexes() {} // 0x000000018977A3E8-0x000000018977A3F4
		internal void ResetInternalIndexes(DataColumn column) {} // 0x000000018977A3F4-0x000000018977A578
		internal void RollbackRow(DataRow row) {} // 0x000000018977AAF8-0x000000018977AB54
		private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) => default; // 0x000000018977695C-0x0000000189776B34
		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) => default; // 0x0000000189776CC0-0x0000000189776FF8
		private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) => default; // 0x0000000189776B34-0x0000000189776CC0
		public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) => default; // 0x000000018977AB54-0x000000018977AC60
		internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = DataRowAction.Nothing | DataRowAction.Change /* Metadata: 0x01FBEC0D */, bool isInMerge = false /* Metadata: 0x01FBEC0E */, bool fireEvent = true /* Metadata: 0x01FBEC0F */, bool suppressEnsurePropertyChanged = false /* Metadata: 0x01FBEC10 */) {} // 0x000000018977DC68-0x000000018977DCD8
		private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) {
			deferredException = default;
		} // 0x000000018977D1C4-0x000000018977DC68
		internal void SetOldRecord(DataRow row, int proposedRecord) {} // 0x000000018977DCD8-0x000000018977DFC4
		private void RestoreShadowIndexes() {} // 0x000000018977AADC-0x000000018977AAF8
		private void SetShadowIndexes() {} // 0x000000018977DFC4-0x000000018977E000
		internal void ShadowIndexCopy() {} // 0x000000018977E000-0x000000018977E090
		public override string ToString() => default; // 0x000000018977E3BC-0x000000018977E428
		internal bool UpdatingCurrent(DataRow row, DataRowAction action) => default; // 0x000000018977E428-0x000000018977E44C
		internal DataColumn AddUniqueKey(int position) => default; // 0x000000018976BA7C-0x000000018976BCF4
		internal DataColumn AddUniqueKey() => default; // 0x000000018976BA6C-0x000000018976BA7C
		internal DataColumn AddForeignKey(DataColumn parentKey) => default; // 0x000000018976B994-0x000000018976BA4C
		internal void UpdatePropertyDescriptorCollectionCache() {} // 0x0000000185BB11D8-0x0000000185BB11F0
		internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) => default; // 0x000000018977392C-0x0000000189773B34
		public void Merge(DataTable table) {} // 0x0000000189775624-0x0000000189775644
		public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) {} // 0x0000000189775644-0x0000000189775878
		public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) {} // 0x000000018977E774-0x000000018977EC04
		private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) => default; // 0x000000018976C4A8-0x000000018976C56C
		private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) => default; // 0x000000018976C054-0x000000018976C4A8
		public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) {} // 0x000000018977E44C-0x000000018977E774
		private void RestoreConstraint(bool originalEnforceConstraint) {} // 0x000000018977A75C-0x000000018977A794
		private bool IsEmptyXml(XmlReader reader) => default; // 0x0000000189774D14-0x0000000189774EB8
		internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) => default; // 0x0000000189778B98-0x0000000189779A84
		internal void ReadEndElement(XmlReader reader) {} // 0x0000000189776FF8-0x0000000189777064
		internal void ReadXDRSchema(XmlReader reader) {} // 0x0000000189777064-0x00000001897770CC
		internal bool MoveToElement(XmlReader reader, int depth) => default; // 0x0000000189775878-0x0000000189775908
		private void ReadXmlDiffgram(XmlReader reader) {} // 0x0000000189777218-0x0000000189777BB0
		internal void ReadXSDSchema(XmlReader reader, bool denyResolving) {} // 0x00000001897770CC-0x0000000189777218
		internal void ReadXmlSchema(XmlReader reader, bool denyResolving) {} // 0x0000000189777BB0-0x0000000189778B78
		private void CreateTableList(DataTable currentTable, List<DataTable> tableList) {} // 0x000000018976EC90-0x000000018976EEA4
		private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) {} // 0x000000018976E968-0x000000018976EC90
		public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) => default; // 0x0000000189773118-0x0000000189773334
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x000000018977E2B4-0x000000018977E2BC
		protected virtual XmlSchema GetSchema() => default; // 0x0000000189773DA0-0x0000000189773F3C
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x000000018977E2BC-0x000000018977E378
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x000000018977E378-0x000000018977E3BC
		protected virtual void ReadXmlSerializable(XmlReader reader) {} // 0x0000000189778B78-0x0000000189778B98
		internal void AddDependentColumn(DataColumn expressionColumn) {} // 0x000000018976B8AC-0x000000018976B994
		internal void RemoveDependentColumn(DataColumn expressionColumn) {} // 0x0000000189779FF0-0x000000018977A078
		internal void EvaluateExpressions() {} // 0x00000001897724A0-0x00000001897726C8
		internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) {} // 0x00000001897726C8-0x0000000189772CC4
		internal void EvaluateExpressions(DataColumn column) {} // 0x0000000189772254-0x00000001897724A0
		internal void EvaluateDependentExpressions(DataColumn column) {} // 0x0000000189772118-0x0000000189772254
		internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) {} // 0x000000018977186C-0x0000000189772118
	}

	public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 49984
	{
		// Constructors
		public DataTableClearEventArgs() {} // Dummy constructor
		public DataTableClearEventArgs(DataTable dataTable) {} // 0x0000000189791708-0x0000000189791760
	}

	public delegate void DataTableClearEventHandler(object sender, DataTableClearEventArgs e); // TypeDefIndex: 49985; 0x0000000182065C10-0x0000000182065C20

	[DefaultEvent("CollectionChanged")]
	[ListBindable(false)]
	public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 49986
	{
		// Fields
		private readonly DataSet _dataSet; // 0x10
		private readonly ArrayList _list; // 0x18
		private int _defaultNameIndex; // 0x20
		private DataTable[] _delayedAddRangeTables; // 0x28
		private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
		private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0x40
	
		// Properties
		protected override ArrayList List { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal int ObjectID { get => default; } // 0x0000000183D4ED80-0x0000000183D4ED90 
		public DataTable this[int index] { get => default; } // 0x0000000189793918-0x0000000189793A04 
		public DataTable this[string name] { get => default; } // 0x000000018979384C-0x0000000189793918 
		public DataTable this[string name, string tableNamespace] { get => default; } // 0x0000000189793A04-0x0000000189793AEC 
	
		// Constructors
		public DataTableCollection() {} // Dummy constructor
		internal DataTableCollection(DataSet dataSet) {} // 0x0000000189793708-0x000000018979384C
	
		// Methods
		internal DataTable GetTable(string name, string ns) => default; // 0x00000001897929B4-0x0000000189792AA4
		internal DataTable GetTableSmart(string name, string ns) => default; // 0x00000001897928A8-0x00000001897929B4
		public void Add(DataTable table) {} // 0x0000000189791760-0x0000000189791A94
		private void ArrayAdd(DataTable table) {} // 0x0000000189791A94-0x0000000189791AB8
		internal string AssignName() => default; // 0x0000000189791AB8-0x0000000189791B00
		private void BaseAdd(DataTable table) {} // 0x0000000189791B00-0x0000000189791C8C
		private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) {} // 0x0000000189791C8C-0x0000000189791DFC
		private void BaseRemove(DataTable table) {} // 0x0000000189791DFC-0x0000000189791E7C
		internal bool CanRemove(DataTable table, bool fThrowException) => default; // 0x0000000189791E7C-0x00000001897923C4
		public void Clear() {} // 0x00000001897923C4-0x0000000189792648
		public bool Contains(string name) => default; // 0x0000000189792740-0x0000000189792758
		internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) => default; // 0x0000000189792758-0x00000001897928A8
		internal bool Contains(string name, bool caseSensitive) => default; // 0x0000000189792648-0x0000000189792740
		public int IndexOf(DataTable table) => default; // 0x0000000189792B50-0x0000000189792BF4
		public int IndexOf(string tableName) => default; // 0x0000000189792AA4-0x0000000189792AC0
		internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) => default; // 0x0000000189792AC0-0x0000000189792B50
		internal void ReplaceFromInference(List<DataTable> tableList) {} // 0x00000001897935B8-0x0000000189793604
		internal int InternalIndexOf(string tableName) => default; // 0x0000000189792BF4-0x0000000189792D8C
		internal int InternalIndexOf(string tableName, string tableNamespace) => default; // 0x0000000189792D8C-0x0000000189792EF4
		private string MakeName(int index) => default; // 0x0000000189792EF4-0x0000000189792F80
		private void OnCollectionChanged(CollectionChangeEventArgs ccevent) {} // 0x0000000189792F80-0x0000000189793030
		private void OnCollectionChanging(CollectionChangeEventArgs ccevent) {} // 0x0000000189793030-0x00000001897930E0
		internal void RegisterName(string name, string tbNamespace) {} // 0x00000001897930E0-0x0000000189793308
		public void Remove(DataTable table) {} // 0x0000000189793308-0x00000001897935B8
		internal void UnregisterName(string name) {} // 0x0000000189793604-0x0000000189793708
	}

	public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 49987
	{
		// Constructors
		public DataTableNewRowEventArgs() {} // Dummy constructor
		public DataTableNewRowEventArgs(DataRow dataRow) {} // 0x0000000189793AEC-0x0000000189793B44
	}

	public delegate void DataTableNewRowEventHandler(object sender, DataTableNewRowEventArgs e); // TypeDefIndex: 49988; 0x0000000182065C10-0x0000000182065C20

	internal sealed class DataTableTypeConverter : ReferenceConverter // TypeDefIndex: 49989
	{
		// Constructors
		public DataTableTypeConverter() {} // 0x0000000189794188-0x0000000189794210
	
		// Methods
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[DefaultEvent("PositionChanged")]
	[DefaultProperty("Table")]
	public class DataView : MarshalByValueComponent, IBindingList // TypeDefIndex: 49991
	{
		// Fields
		private DataViewManager _dataViewManager; // 0x20
		private DataTable _table; // 0x28
		private bool _locked; // 0x30
		private Index _index; // 0x38
		private Dictionary<string, Index> _findIndexes; // 0x40
		private string _sort; // 0x48
		private Comparison<DataRow> _comparison; // 0x50
		private IFilter _rowFilter; // 0x58
		private DataViewRowState _recordStates; // 0x60
		private bool _shouldOpen; // 0x64
		private bool _open; // 0x65
		private bool _allowNew; // 0x66
		private bool _allowEdit; // 0x67
		private bool _allowDelete; // 0x68
		private bool _applyDefaultSort; // 0x69
		internal DataRow _addNewRow; // 0x70
		private ListChangedEventArgs _addNewMoved; // 0x78
		private ListChangedEventHandler _onListChanged; // 0x80
		internal static ListChangedEventArgs s_resetEventArgs; // 0x00
		private DataViewRowState _delayedRecordStates; // 0x88
		private bool _fEndInitInProgress; // 0x8C
		private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x90
		private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0x98
		private DataViewListener _dvListener; // 0xA0
		private static int s_objectTypeCount; // 0x08
		private readonly int _objectID; // 0xA8
	
		// Properties
		[DefaultValue(true)]
		public bool AllowDelete { get => default; } // 0x0000000183D4F3F0-0x0000000183D4F400 
		[DefaultValue(true)]
		public bool AllowNew { get => default; } // 0x0000000183D5CAA0-0x0000000183D5CAB0 
		[Browsable(false)]
		public int Count { get => default; } // 0x0000000189796A54-0x0000000189796A98 
		private int CountFromIndex { get => default; } // 0x0000000189796A30-0x0000000189796A54 
		[Browsable(false)]
		public DataViewManager DataViewManager { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[Browsable(false)]
		protected bool IsOpen { get => default; } // 0x0000000183D5CA70-0x0000000183D5CA80 
		bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		[DefaultValue(DataViewRowState.None | DataViewRowState.Unchanged | DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.CurrentRows)]
		public DataViewRowState RowStateFilter { get => default; } // 0x0000000183D4F050-0x0000000183D4F060 
		[DefaultValue("")]
		public string Sort { get => default; } // 0x0000000189796ABC-0x0000000189796B10 
		internal Comparison<DataRow> SortComparison { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		object ICollection.SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.All)]
		[TypeConverter(typeof(DataTableTypeConverter))]
		public DataTable Table { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		object IList.this[int recordIndex] { get => default; set {} } // 0x0000000189796378-0x0000000189796380 0x0000000189796380-0x00000001897963A8
		public DataRowView this[int recordIndex] { get => default; } // 0x0000000189796A98-0x0000000189796ABC 
		bool IList.IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		bool IList.IsFixedSize { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		internal int ObjectID { get => default; } // 0x0000000183D51860-0x0000000183D51870 
	
		// Nested types
		private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 49990
		{
			// Fields
			internal static readonly DataRowReferenceComparer s_default; // 0x00
	
			// Constructors
			private DataRowReferenceComparer() {} // 0x000000018350B670-0x000000018350B680
			static DataRowReferenceComparer() {} // 0x0000000189783130-0x0000000189783194
	
			// Methods
			public bool Equals(DataRow x, DataRow y) => default; // 0x0000000186DDEAAC-0x0000000186DDEAB4
			public int GetHashCode(DataRow obj) => default; // 0x0000000189783118-0x0000000189783130
		}
	
		// Constructors
		public DataView() {} // Dummy constructor
		internal DataView(DataTable table, bool locked) {} // 0x000000018979676C-0x0000000189796A30
		static DataView() {} // 0x00000001897966E8-0x000000018979676C
	
		// Methods
		public virtual DataRowView AddNew() => default; // 0x0000000189794210-0x00000001897945E4
		private void CheckOpen() {} // 0x00000001897945E4-0x0000000189794620
		protected void Close() {} // 0x0000000189794790-0x00000001897947CC
		public void CopyTo(Array array, int index) {} // 0x0000000189794944-0x0000000189794A7C
		private void CopyTo(DataRowView[] array, int index) {} // 0x0000000189794A7C-0x0000000189794BD4
		public void Delete(int index) {} // 0x0000000189794D68-0x0000000189794D8C
		internal void Delete(DataRow row) {} // 0x0000000189794BD4-0x0000000189794D68
		protected override void Dispose(bool disposing) {} // 0x0000000189794D8C-0x0000000189794DC0
		internal void FinishAddNew(bool success) {} // 0x0000000189794DC0-0x0000000189794F60
		public IEnumerator GetEnumerator() => default; // 0x0000000189794F60-0x0000000189794FD4
		int IList.Add(object value) => default; // 0x0000000189796188-0x00000001897961E8
		void IList.Clear() {} // 0x00000001897961E8-0x0000000189796210
		bool IList.Contains(object value) => default; // 0x0000000189796210-0x000000018979626C
		int IList.IndexOf(object value) => default; // 0x000000018979626C-0x00000001897962C0
		internal int IndexOf(DataRowView rowview) => default; // 0x00000001897952FC-0x00000001897953B8
		private int IndexOfDataRowView(DataRowView rowview) => default; // 0x000000018979529C-0x00000001897952FC
		void IList.Insert(int index, object value) {} // 0x00000001897962C0-0x00000001897962E8
		void IList.Remove(object value) {} // 0x00000001897962F0-0x0000000189796378
		void IList.RemoveAt(int index) {} // 0x00000001897962E8-0x00000001897962F0
		internal virtual IFilter GetFilter() => default; // 0x0000000183D4EAA0-0x0000000183D4EAB0
		private int GetRecord(int recordIndex) => default; // 0x0000000189794FD4-0x0000000189795058
		internal DataRow GetRow(int index) => default; // 0x00000001897950EC-0x0000000189795184
		private DataRowView GetRowView(int record) => default; // 0x00000001897950B0-0x00000001897950EC
		private DataRowView GetRowView(DataRow dr) => default; // 0x0000000189795058-0x00000001897950B0
		protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) {} // 0x000000018979522C-0x000000018979529C
		internal void IndexListChangedInternal(ListChangedEventArgs e) {} // 0x0000000189795184-0x000000018979522C
		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) {} // 0x00000001897953B8-0x0000000189795660
		protected virtual void OnListChanged(ListChangedEventArgs e) {} // 0x0000000189795660-0x0000000189795968
		protected void Reset() {} // 0x0000000189795D08-0x0000000189795D34
		internal void ResetRowViewCache() {} // 0x0000000189795AD8-0x0000000189795D08
		internal void SetDataViewManager(DataViewManager dataViewManager) {} // 0x0000000189795D34-0x0000000189795F40
		internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) {} // 0x000000018979616C-0x0000000189796188
		internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) {} // 0x0000000189795F40-0x000000018979616C
		protected void UpdateIndex() {} // 0x00000001897966CC-0x00000001897966DC
		protected virtual void UpdateIndex(bool force) {} // 0x00000001897966DC-0x00000001897966E8
		internal void UpdateIndex(bool force, bool fireEvent) {} // 0x00000001897963A8-0x00000001897966CC
		internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) {} // 0x0000000189794620-0x0000000189794790
		internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) {} // 0x0000000189795968-0x0000000189795AD8
		protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) {} // 0x00000001897947D4-0x0000000189794944
		internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) {} // 0x00000001897947CC-0x00000001897947D4
	}

	internal sealed class DataViewListener // TypeDefIndex: 49992
	{
		// Fields
		private readonly WeakReference _dvWeak; // 0x10
		private DataTable _table; // 0x18
		private Index _index; // 0x20
		internal readonly int _objectID; // 0x28
	
		// Constructors
		public DataViewListener() {} // Dummy constructor
		internal DataViewListener(DataView dv) {} // 0x000000018979F1F8-0x000000018979F280
	
		// Methods
		private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) {} // 0x000000018979E6B8-0x000000018979E748
		private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) {} // 0x000000018979E914-0x000000018979E9A4
		private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) {} // 0x000000018979E768-0x000000018979E7F8
		internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) {} // 0x000000018979E874-0x000000018979E914
		internal void IndexListChanged(ListChangedEventArgs e) {} // 0x000000018979E7F8-0x000000018979E874
		internal void RegisterMetaDataEvents(DataTable table) {} // 0x000000018979EC08-0x000000018979EDF8
		internal void UnregisterMetaDataEvents() {} // 0x000000018979F1EC-0x000000018979F1F8
		private void UnregisterMetaDataEvents(bool updateListeners) {} // 0x000000018979EEDC-0x000000018979F1EC
		internal void RegisterListChangedEvent(Index index) {} // 0x000000018979E9A4-0x000000018979EA78
		internal void UnregisterListChangedEvent() {} // 0x000000018979EDF8-0x000000018979EEDC
		private void CleanUp(bool updateListeners) {} // 0x000000018979E748-0x000000018979E768
		private void RegisterListener(DataTable table) {} // 0x000000018979EA78-0x000000018979EC08
	}

	public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 49993
	{
		// Fields
		private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
		internal int _nViews; // 0x28
		private static NotSupportedException s_notSupported; // 0x00
	
		// Properties
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataViewSettingCollection DataViewSettings { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public DataViewManager() {} // Dummy constructor
		static DataViewManager() {} // 0x000000018979F280-0x000000018979F2FC
	}

	[Flags]
	public enum DataViewRowState // TypeDefIndex: 49994
	{
		None = 0,
		Unchanged = 2,
		Added = 4,
		Deleted = 8,
		ModifiedCurrent = 16,
		CurrentRows = 22,
		ModifiedOriginal = 32,
		OriginalRows = 42
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class DataViewSetting // TypeDefIndex: 49995
	{
		// Fields
		private DataViewManager _dataViewManager; // 0x10
		private DataTable _table; // 0x18
		private string _sort; // 0x20
		private string _rowFilter; // 0x28
		private DataViewRowState _rowStateFilter; // 0x30
		private bool _applyDefaultSort; // 0x34
	
		// Properties
		public bool ApplyDefaultSort { get => default; } // 0x0000000183D4F570-0x0000000183D4F580 
		public string RowFilter { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public DataViewRowState RowStateFilter { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public string Sort { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		internal DataViewSetting() {} // 0x000000018979F4B0-0x000000018979F520
	
		// Methods
		internal void SetDataViewManager(DataViewManager dataViewManager) {} // 0x0000000189765038-0x000000018976504C
		internal void SetDataTable(DataTable table) {} // 0x000000018979F49C-0x000000018979F4B0
	}

	public class DataViewSettingCollection // TypeDefIndex: 49996
	{
		// Fields
		private readonly DataViewManager _dataViewManager; // 0x10
		private readonly Hashtable _list; // 0x18
	
		// Properties
		public virtual DataViewSetting this[DataTable table] { get => default; set {} } // 0x000000018979F320-0x000000018979F3FC 0x000000018979F3FC-0x000000018979F49C
	
		// Constructors
		public DataViewSettingCollection() {} // Dummy constructor
	
		// Methods
		internal void Remove(DataTable table) {} // 0x000000018979F2FC-0x000000018979F320
	}

	internal sealed class DefaultValueTypeConverter : StringConverter // TypeDefIndex: 49997
	{
		// Constructors
		public DefaultValueTypeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x000000018979F670-0x000000018979F7DC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x000000018979F520-0x000000018979F670
	}

	internal enum Aggregate // TypeDefIndex: 49998
	{
		None = -1,
		Sum = 30,
		Avg = 31,
		Min = 32,
		Max = 33,
		Count = 34,
		StDev = 35,
		Var = 37
	}

	internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 49999
	{
		// Fields
		private readonly AggregateType _type; // 0x18
		private readonly Aggregate _aggregate; // 0x1C
		private readonly bool _local; // 0x20
		private readonly string _relationName; // 0x28
		private readonly string _columnName; // 0x30
		private DataTable _childTable; // 0x38
		private DataColumn _column; // 0x40
		private DataRelation _relation; // 0x48
	
		// Constructors
		public AggregateNode() {} // Dummy constructor
		internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName) {} // 0x00000001897973EC-0x000000018979740C
		internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) {} // 0x00000001897972B8-0x00000001897973EC
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x0000000189796B48-0x0000000189796DC8
		internal static void Bind(DataRelation relation, List<DataColumn> list) {} // 0x0000000189796DC8-0x0000000189796EEC
		internal override object Eval() => default; // 0x0000000189796F28-0x0000000189796F3C
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x0000000189796FD8-0x00000001897972B0
		internal override object Eval(int[] records) => default; // 0x0000000189796F3C-0x0000000189796FD8
		internal override bool IsConstant() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool IsTableConstant() => default; // 0x0000000183D4EF90-0x0000000183D4EFA0
		internal override bool HasLocalAggregate() => default; // 0x0000000183D4EF90-0x0000000183D4EFA0
		internal override bool HasRemoteAggregate() => default; // 0x00000001897972B0-0x00000001897972B8
		internal override bool DependsOn(DataColumn column) => default; // 0x0000000189796EEC-0x0000000189796F28
		internal override ExpressionNode Optimize() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	internal class BinaryNode : ExpressionNode // TypeDefIndex: 50001
	{
		// Fields
		internal int _op; // 0x18
		internal ExpressionNode _left; // 0x20
		internal ExpressionNode _right; // 0x28
	
		// Nested types
		private enum DataTypePrecedence // TypeDefIndex: 50000
		{
			SqlBinary = -10,
			SqlBytes = -9,
			Char = -8,
			SqlChars = -7,
			SqlXml = -6,
			String = -5,
			SqlString = -4,
			SqlGuid = -3,
			Boolean = -2,
			SqlBoolean = -1,
			Error = 0,
			SByte = 1,
			SqlByte = 2,
			Byte = 3,
			Int16 = 4,
			SqlInt16 = 5,
			UInt16 = 6,
			Int32 = 7,
			SqlInt32 = 8,
			UInt32 = 9,
			Int64 = 10,
			SqlInt64 = 11,
			UInt64 = 12,
			SqlMoney = 13,
			Decimal = 14,
			SqlDecimal = 15,
			Single = 16,
			SqlSingle = 17,
			Double = 18,
			SqlDouble = 19,
			TimeSpan = 20,
			DateTime = 23,
			DateTimeOffset = 24,
			SqlDateTime = 25
		}
	
		// Constructors
		public BinaryNode() {} // Dummy constructor
		internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) {} // 0x000000018979CFEC-0x000000018979D02C
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x0000000189798170-0x00000001897981D4
		internal override object Eval() => default; // 0x0000000189796F28-0x0000000189796F3C
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x000000018979C168-0x000000018979C198
		internal override object Eval(int[] recordNos) => default; // 0x000000018979C0F8-0x000000018979C12C
		internal override bool IsConstant() => default; // 0x000000018979C554-0x000000018979C598
		internal override bool IsTableConstant() => default; // 0x000000018979C638-0x000000018979C67C
		internal override bool HasLocalAggregate() => default; // 0x000000018979C4C4-0x000000018979C50C
		internal override bool HasRemoteAggregate() => default; // 0x000000018979C50C-0x000000018979C554
		internal override bool DependsOn(DataColumn column) => default; // 0x00000001897981D4-0x000000018979822C
		internal override ExpressionNode Optimize() => default; // 0x000000018979C67C-0x000000018979C928
		internal void SetTypeMismatchError(int op, System.Type left, System.Type right) {} // 0x000000018979CEBC-0x000000018979CEF4
		private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) => default; // 0x000000018979C12C-0x000000018979C168
		internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) => default; // 0x000000018979740C-0x0000000189797430
		internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) => default; // 0x0000000189797430-0x0000000189798170
		private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) => default; // 0x000000018979822C-0x000000018979C0F8
		private DataTypePrecedence GetPrecedence(StorageType storageType) => default; // 0x000000018979C324-0x000000018979C4C4
		private static StorageType GetPrecedenceType(DataTypePrecedence code) => default; // 0x000000018979C198-0x000000018979C324
		private bool IsMixed(StorageType left, StorageType right) => default; // 0x000000018979C5E8-0x000000018979C638
		private bool IsMixedSql(StorageType left, StorageType right) => default; // 0x000000018979C598-0x000000018979C5E8
		internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) => default; // 0x000000018979CBFC-0x000000018979CEBC
		internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) => default; // 0x000000018979C928-0x000000018979CBFC
		private int SqlResultType(int typeCode) => default; // 0x000000018979CEF4-0x000000018979CFEC
	}

	internal sealed class LikeNode : BinaryNode // TypeDefIndex: 50002
	{
		// Fields
		private int _kind; // 0x30
		private string _pattern; // 0x38
	
		// Constructors
		public LikeNode() {} // Dummy constructor
		internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) {} // 0x00000001897A7AE4-0x00000001897A7AF4
	
		// Methods
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x00000001897A7644-0x00000001897A7AE4
		internal string AnalyzePattern(string pat) => default; // 0x00000001897A7334-0x00000001897A7644
	}

	internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 50003
	{
		// Fields
		internal readonly object _val; // 0x18
	
		// Constructors
		public ConstNode() {} // Dummy constructor
		internal ConstNode(DataTable table, System.Data.ValueType type, object constant) {} // 0x000000018979DC30-0x000000018979DC4C
		internal ConstNode(DataTable table, System.Data.ValueType type, object constant, bool fParseQuotes) {} // 0x000000018979D97C-0x000000018979DC30
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x000000018426FEE0-0x000000018426FEF0
		internal override object Eval() => default; // 0x0000000181041090-0x00000001810410A0
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x000000018979D02C-0x000000018979D03C
		internal override object Eval(int[] recordNos) => default; // 0x000000018979D02C-0x000000018979D03C
		internal override bool IsConstant() => default; // 0x000000018232EB60-0x000000018232EB70
		internal override bool IsTableConstant() => default; // 0x000000018232EB60-0x000000018232EB70
		internal override bool HasLocalAggregate() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool HasRemoteAggregate() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override ExpressionNode Optimize() => default; // 0x000000018339AE90-0x000000018339AEA0
		private object SmallestDecimal(object constant) => default; // 0x000000018979D03C-0x000000018979D434
		private object SmallestNumeric(object constant) => default; // 0x000000018979D434-0x000000018979D97C
	}

	internal sealed class DataExpression : IFilter // TypeDefIndex: 50004
	{
		// Fields
		internal string _originalExpression; // 0x10
		private bool _parsed; // 0x18
		private bool _bound; // 0x19
		private ExpressionNode _expr; // 0x20
		private DataTable _table; // 0x28
		private readonly StorageType _storageType; // 0x30
		private readonly System.Type _dataType; // 0x38
		private DataColumn[] _dependency; // 0x40
	
		// Properties
		internal string Expression { get => default; } // 0x000000018979E678-0x000000018979E6B8 
		internal ExpressionNode ExpressionNode { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal bool HasValue { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
	
		// Constructors
		public DataExpression() {} // Dummy constructor
		internal DataExpression(DataTable table, string expression) {} // 0x000000018979E4EC-0x000000018979E508
		internal DataExpression(DataTable table, string expression, System.Type type) {} // 0x000000018979E508-0x000000018979E678
	
		// Methods
		internal void Bind(DataTable table) {} // 0x000000018979DC4C-0x000000018979DD48
		internal bool DependsOn(DataColumn column) => default; // 0x000000018979DD48-0x000000018979DD68
		internal object Evaluate() => default; // 0x000000018979DF5C-0x000000018979DF6C
		internal object Evaluate(DataRow row, DataRowVersion version) => default; // 0x000000018979DD68-0x000000018979DF4C
		internal object Evaluate(DataRow[] rows) => default; // 0x000000018979DF4C-0x000000018979DF5C
		internal object Evaluate(DataRow[] rows, DataRowVersion version) => default; // 0x000000018979DF6C-0x000000018979E0E4
		public bool Invoke(DataRow row, DataRowVersion version) => default; // 0x000000018979E124-0x000000018979E214
		internal DataColumn[] GetDependency() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		internal bool IsTableAggregate() => default; // 0x000000018979E214-0x000000018979E234
		internal static bool IsUnknown(object value) => default; // 0x000000018979E234-0x000000018979E280
		internal bool HasLocalAggregate() => default; // 0x000000018979E0E4-0x000000018979E104
		internal bool HasRemoteAggregate() => default; // 0x000000018979E104-0x000000018979E124
		internal static bool ToBoolean(object value) => default; // 0x000000018979E280-0x000000018979E4EC
	}

	internal abstract class ExpressionNode // TypeDefIndex: 50005
	{
		// Fields
		private DataTable _table; // 0x10
	
		// Properties
		internal IFormatProvider FormatProvider { get; } // 0x00000001897A0B0C-0x00000001897A0B60 
		internal virtual bool IsSqlColumn { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected DataTable table { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		protected ExpressionNode() {} // Dummy constructor
		protected ExpressionNode(DataTable table) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		protected void BindTable(DataTable table) {} // 0x000000018426FEE0-0x000000018426FEF0
		internal abstract void Bind(DataTable table, List<DataColumn> list);
		internal abstract object Eval();
		internal abstract object Eval(DataRow row, DataRowVersion version);
		internal abstract object Eval(int[] recordNos);
		internal abstract bool IsConstant();
		internal abstract bool IsTableConstant();
		internal abstract bool HasLocalAggregate();
		internal abstract bool HasRemoteAggregate();
		internal abstract ExpressionNode Optimize();
		internal virtual bool DependsOn(DataColumn column) => default; // 0x000000018115F4C0-0x000000018115F530
		internal static bool IsInteger(StorageType type) => default; // 0x00000001897A0A28-0x00000001897A0A44
		internal static bool IsIntegerSql(StorageType type) => default; // 0x00000001897A0A0C-0x00000001897A0A28
		internal static bool IsSigned(StorageType type) => default; // 0x00000001897A0ABC-0x00000001897A0AD4
		internal static bool IsSignedSql(StorageType type) => default; // 0x00000001897A0A9C-0x00000001897A0ABC
		internal static bool IsUnsigned(StorageType type) => default; // 0x00000001897A0AF0-0x00000001897A0B0C
		internal static bool IsUnsignedSql(StorageType type) => default; // 0x00000001897A0AD4-0x00000001897A0AF0
		internal static bool IsNumeric(StorageType type) => default; // 0x00000001897A0A70-0x00000001897A0A9C
		internal static bool IsNumericSql(StorageType type) => default; // 0x00000001897A0A44-0x00000001897A0A70
		internal static bool IsFloat(StorageType type) => default; // 0x00000001897A09F8-0x00000001897A0A0C
		internal static bool IsFloatSql(StorageType type) => default; // 0x00000001897A09D8-0x00000001897A09F8
	}

	internal enum ValueType // TypeDefIndex: 50006
	{
		Unknown = -1,
		Null = 0,
		Bool = 1,
		Numeric = 2,
		Str = 3,
		Float = 4,
		Decimal = 5,
		Object = 6,
		Date = 7
	}

	internal enum Nodes // TypeDefIndex: 50007
	{
		Noop = 0,
		Unop = 1,
		UnopSpec = 2,
		Binop = 3,
		BinopSpec = 4,
		Zop = 5,
		Call = 6,
		Const = 7,
		Name = 8,
		Paren = 9,
		Conv = 10
	}

	internal sealed class ExpressionParser // TypeDefIndex: 50009
	{
		// Fields
		private static readonly ReservedWords[] s_reservedwords; // 0x00
		private char _escape; // 0x10
		private char _decimalSeparator; // 0x12
		private char _listSeparator; // 0x14
		private char _exponentL; // 0x16
		private char _exponentU; // 0x18
		internal char[] _text; // 0x20
		internal int _pos; // 0x28
		internal int _start; // 0x2C
		internal Tokens _token; // 0x30
		internal int _op; // 0x34
		internal OperatorInfo[] _ops; // 0x38
		internal int _topOperator; // 0x40
		internal int _topNode; // 0x44
		private readonly DataTable _table; // 0x48
		internal ExpressionNode[] _nodeStack; // 0x50
		internal int _prevOperand; // 0x58
		internal ExpressionNode _expression; // 0x60
	
		// Nested types
		[IsReadOnly]
		private struct ReservedWords // TypeDefIndex: 50008
		{
			// Fields
			internal readonly string _word; // 0x00
			internal readonly Tokens _token; // 0x08
			internal readonly int _op; // 0x0C
	
			// Constructors
			internal ReservedWords(string word, Tokens token, int op) {
				_word = default;
				_token = default;
				_op = default;
			} // 0x000000018426FA34-0x000000018426FA54
		}
	
		// Constructors
		public ExpressionParser() {} // Dummy constructor
		internal ExpressionParser(DataTable table) {} // 0x00000001897A3318-0x00000001897A33B8
		static ExpressionParser() {} // 0x00000001897A2EF0-0x00000001897A3318
	
		// Methods
		internal void LoadExpression(string data) {} // 0x00000001897A1050-0x00000001897A113C
		internal void StartScan() {} // 0x00000001897A2E70-0x00000001897A2EF0
		internal ExpressionNode Parse() => default; // 0x00000001897A14B4-0x00000001897A234C
		private ExpressionNode ParseAggregateArgument(FunctionId aggregate) => default; // 0x00000001897A1224-0x00000001897A14B4
		private ExpressionNode NodePop() => default; // 0x00000001897A1174-0x00000001897A11AC
		private ExpressionNode NodePeek() => default; // 0x00000001897A113C-0x00000001897A1174
		private void NodePush(ExpressionNode node) {} // 0x00000001897A11AC-0x00000001897A1224
		private void BuildExpression(int pri) {} // 0x00000001897A0B60-0x00000001897A0DDC
		internal void CheckToken(Tokens token) {} // 0x00000001897A0DDC-0x00000001897A0E1C
		internal Tokens Scan() => default; // 0x00000001897A29FC-0x00000001897A2E70
		private void ScanNumeric() {} // 0x00000001897A2578-0x00000001897A26DC
		private void ScanName() {} // 0x00000001897A240C-0x00000001897A2464
		private void ScanName(char chEnd, char esc, string charsToEscape) {} // 0x00000001897A2464-0x00000001897A2578
		private void ScanDate() {} // 0x00000001897A234C-0x00000001897A240C
		private void ScanBinaryConstant() {} // 0x000000018350B670-0x000000018350B680
		private void ScanReserved() {} // 0x00000001897A26DC-0x00000001897A28C0
		private void ScanString(char escape) {} // 0x00000001897A28C0-0x00000001897A2974
		internal void ScanToken(Tokens token) {} // 0x00000001897A2974-0x00000001897A29A4
		private void ScanWhite() {} // 0x00000001897A29A4-0x00000001897A29FC
		private bool IsWhiteSpace(char ch) => default; // 0x00000001897A1040-0x00000001897A1050
		private bool IsAlphaNumeric(char ch) => default; // 0x00000001897A0E1C-0x00000001897A0F70
		private bool IsDigit(char ch) => default; // 0x00000001897A1010-0x00000001897A1040
		private bool IsAlpha(char ch) => default; // 0x00000001897A0F70-0x00000001897A1010
	}

	internal enum Tokens // TypeDefIndex: 50010
	{
		None = 0,
		Name = 1,
		Numeric = 2,
		Decimal = 3,
		Float = 4,
		BinaryConst = 5,
		StringConst = 6,
		Date = 7,
		ListSeparator = 8,
		LeftParen = 9,
		RightParen = 10,
		ZeroOp = 11,
		UnaryOp = 12,
		BinaryOp = 13,
		Child = 14,
		Parent = 15,
		Dot = 16,
		Unknown = 17,
		EOS = 18
	}

	internal sealed class OperatorInfo // TypeDefIndex: 50011
	{
		// Fields
		internal Nodes _type; // 0x10
		internal int _op; // 0x14
		internal int _priority; // 0x18
	
		// Constructors
		public OperatorInfo() {} // Dummy constructor
		internal OperatorInfo(Nodes type, int op, int pri) {} // 0x0000000183D51130-0x0000000183D51140
	}

	[Serializable]
	public class InvalidExpressionException : DataException // TypeDefIndex: 50012
	{
		// Constructors
		protected InvalidExpressionException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		public InvalidExpressionException() {} // 0x000000018979F7DC-0x000000018979F7E4
		public InvalidExpressionException(string s) {} // 0x0000000189762E64-0x0000000189762E84
	}

	[Serializable]
	public class EvaluateException : InvalidExpressionException // TypeDefIndex: 50013
	{
		// Constructors
		protected EvaluateException(SerializationInfo info, StreamingContext context) {} // 0x000000018979F7E4-0x000000018979F804
		public EvaluateException() {} // 0x000000018979F7DC-0x000000018979F7E4
		public EvaluateException(string s) {} // 0x0000000189762E64-0x0000000189762E84
	}

	[Serializable]
	public class SyntaxErrorException : InvalidExpressionException // TypeDefIndex: 50014
	{
		// Constructors
		protected SyntaxErrorException(SerializationInfo info, StreamingContext context) {} // 0x000000018979F7E4-0x000000018979F804
		public SyntaxErrorException() {} // 0x000000018979F7DC-0x000000018979F7E4
		public SyntaxErrorException(string s) {} // 0x0000000189762E64-0x0000000189762E84
	}

	internal sealed class ExprException // TypeDefIndex: 50015
	{
		// Constructors
		public ExprException() {} // Dummy constructor
	
		// Methods
		private static OverflowException _Overflow(string error) => default; // 0x00000001897A0900-0x00000001897A096C
		private static InvalidExpressionException _Expr(string error) => default; // 0x00000001897A0894-0x00000001897A0900
		private static SyntaxErrorException _Syntax(string error) => default; // 0x00000001897A096C-0x00000001897A09D8
		private static EvaluateException _Eval(string error) => default; // 0x00000001897A0828-0x00000001897A0894
		private static EvaluateException _Eval(string error, Exception innerException) => default; // 0x00000001897A07BC-0x00000001897A0828
		public static Exception InvokeArgument() => default; // 0x00000001897A0090-0x00000001897A00C4
		public static Exception NYI(string moreinfo) => default; // 0x00000001897A0268-0x00000001897A02B0
		public static Exception MissingOperand(OperatorInfo before) => default; // 0x00000001897A0174-0x00000001897A01EC
		public static Exception MissingOperator(string token) => default; // 0x00000001897A01EC-0x00000001897A0234
		public static Exception TypeMismatch(string expr) => default; // 0x00000001897A0464-0x00000001897A04AC
		public static Exception FunctionArgumentOutOfRange(string arg, string func) => default; // 0x000000018979FD50-0x000000018979FDA8
		public static Exception ExpressionTooComplex() => default; // 0x000000018979FC44-0x000000018979FC78
		public static Exception UnboundName(string name) => default; // 0x00000001897A04AC-0x00000001897A04F4
		public static Exception InvalidString(string str) => default; // 0x000000018979FFCC-0x00000001897A0014
		public static Exception UndefinedFunction(string name) => default; // 0x00000001897A04F4-0x00000001897A053C
		public static Exception SyntaxError() => default; // 0x00000001897A0344-0x00000001897A0378
		public static Exception FunctionArgumentCount(string name) => default; // 0x000000018979FD08-0x000000018979FD50
		public static Exception MissingRightParen() => default; // 0x00000001897A0234-0x00000001897A0268
		public static Exception UnknownToken(string token, int position) => default; // 0x00000001897A0620-0x00000001897A069C
		public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) => default; // 0x00000001897A053C-0x00000001897A0620
		public static Exception DatatypeConvertion(System.Type type1, System.Type type2) => default; // 0x000000018979FAF8-0x000000018979FB7C
		public static Exception DatavalueConvertion(object value, System.Type type, Exception innerException) => default; // 0x000000018979FB7C-0x000000018979FC10
		public static Exception InvalidName(string name) => default; // 0x000000018979FF3C-0x000000018979FF84
		public static Exception InvalidDate(string date) => default; // 0x000000018979FE10-0x000000018979FE58
		public static Exception NonConstantArgument() => default; // 0x00000001897A02B0-0x00000001897A02E4
		public static Exception InvalidPattern(string pat) => default; // 0x000000018979FF84-0x000000018979FFCC
		public static Exception InWithoutParentheses() => default; // 0x000000018979FDDC-0x000000018979FE10
		public static Exception InWithoutList() => default; // 0x000000018979FDA8-0x000000018979FDDC
		public static Exception InvalidIsSyntax() => default; // 0x000000018979FE8C-0x000000018979FEC0
		public static Exception Overflow(System.Type type) => default; // 0x00000001897A02E4-0x00000001897A0344
		public static Exception ArgumentType(string function, int arg, System.Type type) => default; // 0x000000018979F9B4-0x000000018979FA68
		public static Exception ArgumentTypeInteger(string function, int arg) => default; // 0x000000018979F938-0x000000018979F9B4
		public static Exception TypeMismatchInBinop(int op, System.Type type1, System.Type type2) => default; // 0x00000001897A03AC-0x00000001897A0464
		public static Exception AmbiguousBinop(int op, System.Type type1, System.Type type2) => default; // 0x000000018979F880-0x000000018979F938
		public static Exception UnsupportedOperator(int op) => default; // 0x00000001897A0754-0x00000001897A07BC
		public static Exception InvalidNameBracketing(string name) => default; // 0x000000018979FEF4-0x000000018979FF3C
		public static Exception MissingOperandBefore(string op) => default; // 0x00000001897A012C-0x00000001897A0174
		public static Exception TooManyRightParentheses() => default; // 0x00000001897A0378-0x00000001897A03AC
		public static Exception UnresolvedRelation(string name, string expr) => default; // 0x00000001897A069C-0x00000001897A06F4
		internal static EvaluateException BindFailure(string relationName) => default; // 0x000000018979FA68-0x000000018979FAB0
		public static Exception AggregateArgument() => default; // 0x000000018979F804-0x000000018979F838
		public static Exception AggregateUnbound(string expr) => default; // 0x000000018979F838-0x000000018979F880
		public static Exception EvalNoContext() => default; // 0x000000018979FC10-0x000000018979FC44
		public static Exception ExpressionUnbound(string expr) => default; // 0x000000018979FC78-0x000000018979FCC0
		public static Exception ComputeNotAggregate(string expr) => default; // 0x000000018979FAB0-0x000000018979FAF8
		public static Exception FilterConvertion(string expr) => default; // 0x000000018979FCC0-0x000000018979FD08
		public static Exception LookupArgument() => default; // 0x00000001897A00C4-0x00000001897A00F8
		public static Exception InvalidType(string typeName) => default; // 0x00000001897A0048-0x00000001897A0090
		public static Exception InvalidHoursArgument() => default; // 0x000000018979FE58-0x000000018979FE8C
		public static Exception InvalidMinutesArgument() => default; // 0x000000018979FEC0-0x000000018979FEF4
		public static Exception InvalidTimeZoneRange() => default; // 0x00000001897A0014-0x00000001897A0048
		public static Exception MismatchKindandTimeSpan() => default; // 0x00000001897A00F8-0x00000001897A012C
		public static Exception UnsupportedDataType(System.Type type) => default; // 0x00000001897A06F4-0x00000001897A0754
	}

	internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 50016
	{
		// Fields
		internal readonly string _name; // 0x18
		internal readonly int _info; // 0x20
		internal int _argumentCount; // 0x24
		internal ExpressionNode[] _arguments; // 0x28
		private static readonly Function[] s_funcs; // 0x00
	
		// Properties
		internal FunctionId Aggregate { get => default; } // 0x00000001897A69F4-0x00000001897A6A78 
		internal bool IsAggregate { get => default; } // 0x00000001897A6A78-0x00000001897A6C7C 
	
		// Constructors
		public FunctionNode() {} // Dummy constructor
		internal FunctionNode(DataTable table, string name) {} // 0x00000001897A68E0-0x00000001897A69F4
		static FunctionNode() {} // 0x00000001897A5EBC-0x00000001897A68E0
	
		// Methods
		internal void AddArgument(ExpressionNode argument) {} // 0x00000001897A33B8-0x00000001897A3560
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x00000001897A3560-0x00000001897A3800
		internal override object Eval() => default; // 0x0000000189796F28-0x0000000189796F3C
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x00000001897A5030-0x00000001897A593C
		internal override object Eval(int[] recordNos) => default; // 0x00000001897A593C-0x00000001897A5974
		internal override bool IsConstant() => default; // 0x00000001897A5C78-0x00000001897A5CD8
		internal override bool IsTableConstant() => default; // 0x00000001897A5CD8-0x00000001897A5D3C
		internal override bool HasLocalAggregate() => default; // 0x00000001897A5BB0-0x00000001897A5C14
		internal override bool HasRemoteAggregate() => default; // 0x00000001897A5C14-0x00000001897A5C78
		internal override bool DependsOn(DataColumn column) => default; // 0x00000001897A3A28-0x00000001897A3A9C
		internal override ExpressionNode Optimize() => default; // 0x00000001897A5D3C-0x00000001897A5EBC
		private System.Type GetDataType(ExpressionNode node) => default; // 0x00000001897A5974-0x00000001897A5BB0
		private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) => default; // 0x00000001897A3A9C-0x00000001897A5030
		internal void Check() {} // 0x00000001897A3800-0x00000001897A3A28
	}

	internal enum FunctionId // TypeDefIndex: 50017
	{
		none = -1,
		Ascii = 0,
		Char = 1,
		Charindex = 2,
		Difference = 3,
		Len = 4,
		Lower = 5,
		LTrim = 6,
		Patindex = 7,
		Replicate = 8,
		Reverse = 9,
		Right = 10,
		RTrim = 11,
		Soundex = 12,
		Space = 13,
		Str = 14,
		Stuff = 15,
		Substring = 16,
		Upper = 17,
		IsNull = 18,
		Iif = 19,
		Convert = 20,
		cInt = 21,
		cBool = 22,
		cDate = 23,
		cDbl = 24,
		cStr = 25,
		Abs = 26,
		Acos = 27,
		In = 28,
		Trim = 29,
		Sum = 30,
		Avg = 31,
		Min = 32,
		Max = 33,
		Count = 34,
		StDev = 35,
		Var = 37,
		DateTimeOffset = 38
	}

	internal sealed class Function // TypeDefIndex: 50018
	{
		// Fields
		internal readonly string _name; // 0x10
		internal readonly FunctionId _id; // 0x18
		internal readonly System.Type _result; // 0x20
		internal readonly bool _isValidateArguments; // 0x28
		internal readonly bool _isVariantArgumentList; // 0x29
		internal readonly int _argumentCount; // 0x2C
		internal readonly System.Type[] _parameters; // 0x30
		internal static string[] s_functionName; // 0x00
	
		// Constructors
		public Function() {} // Dummy constructor
		internal Function(string name, FunctionId id, System.Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, System.Type a1, System.Type a2, System.Type a3) {} // 0x00000001897A71D4-0x00000001897A7334
		static Function() {} // 0x00000001897A6C7C-0x00000001897A71D4
	}

	internal interface IFilter // TypeDefIndex: 50019
	{
		// Methods
		bool Invoke(DataRow row, DataRowVersion version);
	}

	internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 50020
	{
		// Fields
		private readonly string _relationName; // 0x18
		private readonly string _columnName; // 0x20
		private DataColumn _column; // 0x28
		private DataRelation _relation; // 0x30
	
		// Constructors
		public LookupNode() {} // Dummy constructor
		internal LookupNode(DataTable table, string columnName, string relationName) {} // 0x00000001897A7EB4-0x00000001897A7EEC
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x00000001897A7AF4-0x00000001897A7D50
		internal override object Eval() => default; // 0x00000001897A7D58-0x00000001897A7D80
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x00000001897A7DB8-0x00000001897A7EB4
		internal override object Eval(int[] recordNos) => default; // 0x00000001897A7D80-0x00000001897A7DB8
		internal override bool IsConstant() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool IsTableConstant() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool HasLocalAggregate() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool HasRemoteAggregate() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool DependsOn(DataColumn column) => default; // 0x00000001897A7D50-0x00000001897A7D58
		internal override ExpressionNode Optimize() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	internal sealed class NameNode : ExpressionNode // TypeDefIndex: 50021
	{
		// Fields
		internal string _name; // 0x18
		internal bool _found; // 0x20
		internal DataColumn _column; // 0x28
	
		// Properties
		internal override bool IsSqlColumn { get => default; } // 0x00000001897A8544-0x00000001897A85F8 
	
		// Constructors
		public NameNode() {} // Dummy constructor
		internal NameNode(DataTable table, char[] text, int start, int pos) {} // 0x00000001897A8500-0x00000001897A8544
		internal NameNode(DataTable table, string name) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x00000001897A7EEC-0x00000001897A80FC
		internal override object Eval() => default; // 0x00000001897A8238-0x00000001897A8260
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x00000001897A8138-0x00000001897A8200
		internal override object Eval(int[] records) => default; // 0x00000001897A8200-0x00000001897A8238
		internal override bool IsConstant() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool IsTableConstant() => default; // 0x00000001897A82A0-0x00000001897A82C0
		internal override bool HasLocalAggregate() => default; // 0x00000001897A8260-0x00000001897A8280
		internal override bool HasRemoteAggregate() => default; // 0x00000001897A8280-0x00000001897A82A0
		internal override bool DependsOn(DataColumn column) => default; // 0x00000001897A80FC-0x00000001897A8138
		internal override ExpressionNode Optimize() => default; // 0x000000018339AE90-0x000000018339AEA0
		internal static string ParseName(char[] text, int start, int pos) => default; // 0x00000001897A82C0-0x00000001897A8500
	}

	internal sealed class Operators // TypeDefIndex: 50022
	{
		// Fields
		private static readonly int[] s_priority; // 0x00
		private static readonly string[] s_looks; // 0x08
	
		// Constructors
		public Operators() {} // Dummy constructor
		static Operators() {} // 0x00000001897B0914-0x00000001897B0ED0
	
		// Methods
		internal static bool IsArithmetical(int op) => default; // 0x00000001897B07A8-0x00000001897B07BC
		internal static bool IsLogical(int op) => default; // 0x00000001897B07BC-0x00000001897B07D8
		internal static bool IsRelational(int op) => default; // 0x00000001897B07D8-0x00000001897B07E8
		internal static int Priority(int op) => default; // 0x00000001897B07E8-0x00000001897B0874
		internal static string ToString(int op) => default; // 0x00000001897B0874-0x00000001897B0914
	}

	internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 50023
	{
		// Fields
		internal readonly int _op; // 0x18
		internal ExpressionNode _right; // 0x20
	
		// Constructors
		public UnaryNode() {} // Dummy constructor
		internal UnaryNode(DataTable table, int op, ExpressionNode right) {} // 0x0000000183020510-0x0000000183020540
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x00000001897B6E24-0x00000001897B6E5C
		internal override object Eval() => default; // 0x0000000189796F28-0x0000000189796F3C
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x00000001897B75C0-0x00000001897B7608
		internal override object Eval(int[] recordNos) => default; // 0x00000001897B75A0-0x00000001897B75C0
		private object EvalUnaryOp(int op, object vl) => default; // 0x00000001897B6E80-0x00000001897B75A0
		internal override bool IsConstant() => default; // 0x00000001897B7650-0x00000001897B7674
		internal override bool IsTableConstant() => default; // 0x00000001897B7674-0x00000001897B7698
		internal override bool HasLocalAggregate() => default; // 0x00000001897B7608-0x00000001897B762C
		internal override bool HasRemoteAggregate() => default; // 0x00000001897B762C-0x00000001897B7650
		internal override bool DependsOn(DataColumn column) => default; // 0x00000001897B6E5C-0x00000001897B6E80
		internal override ExpressionNode Optimize() => default; // 0x00000001897B7698-0x00000001897B7754
	}

	internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 50024
	{
		// Fields
		internal readonly int _op; // 0x18
	
		// Constructors
		public ZeroOpNode() {} // Dummy constructor
		internal ZeroOpNode(int op) {} // 0x00000001897BBAC8-0x00000001897BBAEC
	
		// Methods
		internal override void Bind(DataTable table, List<DataColumn> list) {} // 0x000000018350B670-0x000000018350B680
		internal override object Eval() => default; // 0x00000001897BBA40-0x00000001897BBAC8
		internal override object Eval(DataRow row, DataRowVersion version) => default; // 0x000000018979D02C-0x000000018979D03C
		internal override object Eval(int[] recordNos) => default; // 0x000000018979D02C-0x000000018979D03C
		internal override bool IsConstant() => default; // 0x000000018232EB60-0x000000018232EB70
		internal override bool IsTableConstant() => default; // 0x000000018232EB60-0x000000018232EB70
		internal override bool HasLocalAggregate() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override bool HasRemoteAggregate() => default; // 0x000000018115F4C0-0x000000018115F530
		internal override ExpressionNode Optimize() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	[DefaultProperty("ConstraintName")]
	public class ForeignKeyConstraint : System.Data.Constraint // TypeDefIndex: 50025
	{
		// Fields
		internal System.Data.Rule _deleteRule; // 0x38
		internal System.Data.Rule _updateRule; // 0x3C
		internal AcceptRejectRule _acceptRejectRule; // 0x40
		private DataKey _childKey; // 0x48
		private DataKey _parentKey; // 0x50
		internal string _constraintName; // 0x58
		internal string[] _parentColumnNames; // 0x60
		internal string[] _childColumnNames; // 0x68
		internal string _parentTableName; // 0x70
	
		// Properties
		internal DataKey ChildKey { get => default; } // 0x00000001897AAE40-0x00000001897AAE5C 
		[ReadOnly(true)]
		public virtual DataColumn[] Columns { get => default; } // 0x00000001897AAE5C-0x00000001897AAE7C 
		[ReadOnly(true)]
		public override DataTable Table { get => default; } // 0x00000001897AAF00-0x00000001897AAF20 
		internal string[] ParentColumnNames { get => default; } // 0x00000001897AAE98-0x00000001897AAEA4 
		internal string[] ChildColumnNames { get => default; } // 0x00000001897AAE34-0x00000001897AAE40 
		[DefaultValue(AcceptRejectRule.None)]
		public virtual AcceptRejectRule AcceptRejectRule { get => default; set {} } // 0x00000001897AAE18-0x00000001897AAE34 0x00000001897AAF3C-0x00000001897AAF8C
		[DefaultValue(System.Data.Rule.Cascade)]
		public virtual System.Data.Rule DeleteRule { get => default; set {} } // 0x00000001897AAE7C-0x00000001897AAE98 0x00000001897AAF8C-0x00000001897AAFDC
		[ReadOnly(true)]
		public virtual DataColumn[] RelatedColumns { get => default; } // 0x00000001897AAEC0-0x00000001897AAEE0 
		internal DataColumn[] RelatedColumnsReference { get => default; } // 0x00000001897AAEA4-0x00000001897AAEC0 
		internal DataKey ParentKey { get => default; } // 0x00000001897AAEA4-0x00000001897AAEC0 
		[ReadOnly(true)]
		public virtual DataTable RelatedTable { get => default; } // 0x00000001897AAEE0-0x00000001897AAF00 
		[DefaultValue(System.Data.Rule.Cascade)]
		public virtual System.Data.Rule UpdateRule { get => default; set {} } // 0x00000001897AAF20-0x00000001897AAF3C 0x00000001897AAFDC-0x00000001897AB02C
	
		// Constructors
		public ForeignKeyConstraint() {} // Dummy constructor
		public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) {} // 0x00000001897AAD94-0x00000001897AADB4
		public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) {} // 0x00000001897AADB4-0x00000001897AAE18
		[Browsable(false)]
		public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) {} // 0x00000001897AACFC-0x00000001897AAD94
	
		// Methods
		internal override void CheckCanAddToCollection(ConstraintCollection constraints) {} // 0x00000001897A92CC-0x00000001897A93C4
		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) => default; // 0x000000018232EB60-0x000000018232EB70
		internal bool IsKeyNull(object[] values) => default; // 0x00000001897AAA08-0x00000001897AAA8C
		internal override bool IsConstraintViolated() => default; // 0x00000001897AA868-0x00000001897AAA08
		internal override bool CanEnableConstraint() => default; // 0x00000001897A85F8-0x00000001897A8724
		internal void CascadeCommit(DataRow row) {} // 0x00000001897A8724-0x00000001897A887C
		internal void CascadeDelete(DataRow row) {} // 0x00000001897A887C-0x00000001897A8CD4
		internal void CascadeRollback(DataRow row) {} // 0x00000001897A8CD4-0x00000001897A8EC4
		internal void CascadeUpdate(DataRow row) {} // 0x00000001897A8EC4-0x00000001897A92CC
		internal void CheckCanClearParentTable(DataTable table) {} // 0x00000001897A93C4-0x00000001897A9480
		internal void CheckCanRemoveParentRow(DataRow row) {} // 0x00000001897A9480-0x00000001897A952C
		internal void CheckCascade(DataRow row, DataRowAction action) {} // 0x00000001897A952C-0x00000001897A969C
		internal override void CheckConstraint(DataRow childRow, DataRowAction action) {} // 0x00000001897A969C-0x00000001897A9944
		private void NonVirtualCheckState() {} // 0x00000001897AAA8C-0x00000001897AACFC
		internal override void CheckState() {} // 0x00000001897A9944-0x00000001897A994C
		internal override bool ContainsColumn(DataColumn column) => default; // 0x00000001897AA510-0x00000001897AA550
		internal override System.Data.Constraint Clone(DataSet destination) => default; // 0x00000001897AA500-0x00000001897AA510
		internal override System.Data.Constraint Clone(DataSet destination, bool ignorNSforTableLookup) => default; // 0x00000001897A994C-0x00000001897AA024
		internal ForeignKeyConstraint Clone(DataTable destination) => default; // 0x00000001897AA024-0x00000001897AA500
		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) {} // 0x00000001897AA550-0x00000001897AA718
		public override bool Equals(object key) => default; // 0x00000001897AA718-0x00000001897AA7DC
		public override int GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		internal DataRelation FindParentRelation() => default; // 0x00000001897AA7DC-0x00000001897AA868
	}

	public enum MappingType // TypeDefIndex: 50026
	{
		Element = 1,
		Attribute = 2,
		SimpleContent = 3,
		Hidden = 4
	}

	public class MergeFailedEventArgs : EventArgs // TypeDefIndex: 50027
	{
		// Properties
		public string Conflict { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public MergeFailedEventArgs() {} // Dummy constructor
		public MergeFailedEventArgs(DataTable table, string conflict) {} // 0x00000001897AE1A8-0x00000001897AE214
	}

	public delegate void MergeFailedEventHandler(object sender, MergeFailedEventArgs e); // TypeDefIndex: 50028; 0x0000000182065C10-0x0000000182065C20

	internal sealed class Merger // TypeDefIndex: 50029
	{
		// Fields
		private DataSet _dataSet; // 0x10
		private DataTable _dataTable; // 0x18
		private bool _preserveChanges; // 0x20
		private MissingSchemaAction _missingSchemaAction; // 0x24
		private bool _isStandAlonetable; // 0x28
		private bool _IgnoreNSforTableLookup; // 0x29
	
		// Constructors
		public Merger() {} // Dummy constructor
		internal Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) {} // 0x00000001897B0774-0x00000001897B07A8
		internal Merger(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) {} // 0x00000001897B073C-0x00000001897B0774
	
		// Methods
		internal void MergeDataSet(DataSet source) {} // 0x00000001897AE650-0x00000001897AF03C
		internal void MergeTable(DataTable src) {} // 0x00000001897B00E4-0x00000001897B0380
		private void MergeTable(DataTable src, DataTable dst) {} // 0x00000001897B0380-0x00000001897B073C
		private DataTable MergeSchema(DataTable table) => default; // 0x00000001897AF900-0x00000001897B0040
		private void MergeTableData(DataTable src) {} // 0x00000001897B0040-0x00000001897B00E4
		private void MergeConstraints(DataSet source) {} // 0x00000001897AE34C-0x00000001897AE3BC
		private void MergeConstraints(DataTable table) {} // 0x00000001897AE3BC-0x00000001897AE650
		private void MergeRelation(DataRelation relation) {} // 0x00000001897AF120-0x00000001897AF900
		private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) {} // 0x00000001897AF03C-0x00000001897AF120
		private DataKey GetSrcKey(DataTable src, DataTable dst) => default; // 0x00000001897AE214-0x00000001897AE34C
	}

	public enum MissingSchemaAction // TypeDefIndex: 50030
	{
		Add = 1,
		Ignore = 2,
		Error = 3,
		AddWithKey = 4
	}

	internal sealed class PrimaryKeyTypeConverter : ReferenceConverter // TypeDefIndex: 50031
	{
		// Constructors
		public PrimaryKeyTypeConverter() {} // 0x00000001897B10B0-0x00000001897B1138
	
		// Methods
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001897B0ED0-0x00000001897B0F64
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001897B0F64-0x00000001897B10B0
	}

	[Serializable]
	public class PropertyCollection : Hashtable, ICloneable // TypeDefIndex: 50032
	{
		// Constructors
		public PropertyCollection() {} // 0x0000000184270E50-0x0000000184270E64
		protected PropertyCollection(SerializationInfo info, StreamingContext context) {} // 0x00000001897B12F8-0x00000001897B1318
	
		// Methods
		public override object Clone() => default; // 0x00000001897B1138-0x00000001897B12F8
	}

	internal struct Range // TypeDefIndex: 50033
	{
		// Fields
		private int _min; // 0x00
		private int _max; // 0x04
		private bool _isNotNull; // 0x08
	
		// Properties
		public int Count { get => default; } // 0x00000001897B139C-0x00000001897B13B0 
		public bool IsNull { get => default; } // 0x00000001857FD3F0-0x00000001857FD3F8 
		public int Min { get => default; } // 0x00000001897B13B0-0x00000001897B13C8 
	
		// Constructors
		public Range(int min, int max) : this() {
			_min = default;
			_max = default;
			_isNotNull = default;
		} // 0x00000001897B1354-0x00000001897B139C
	
		// Methods
		internal void CheckNull() {} // 0x00000001897B1318-0x00000001897B1354
	}

	internal enum RBTreeError // TypeDefIndex: 50034
	{
		InvalidPageSize = 1,
		PagePositionInSlotInUse = 3,
		NoFreeSlots = 4,
		InvalidStateinInsert = 5,
		InvalidNextSizeInDelete = 7,
		InvalidStateinDelete = 8,
		InvalidNodeSizeinDelete = 9,
		InvalidStateinEndDelete = 10,
		CannotRotateInvalidsuccessorNodeinDelete = 11,
		IndexOutOFRangeinGetNodeByIndex = 13,
		RBDeleteFixup = 14,
		UnsupportedAccessMethod1 = 15,
		UnsupportedAccessMethod2 = 16,
		UnsupportedAccessMethodInNonNillRootSubtree = 17,
		AttachedNodeWithZerorbTreeNodeId = 18,
		CompareNodeInDataRowTree = 19,
		CompareSateliteTreeNodeInDataRowTree = 20,
		NestedSatelliteTreeEnumerator = 21
	}

	internal enum TreeAccessMethod // TypeDefIndex: 50035
	{
		KEY_SEARCH_AND_INDEX = 1,
		INDEX_ONLY = 2
	}

	internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 50041
	{
		// Fields
		private TreePage[] _pageTable;
		private int[] _pageTableMap;
		private int _inUsePageCount;
		private int _nextFreePageLine;
		public int root;
		private int _version;
		private int _inUseNodeCount;
		private int _inUseSatelliteTreeCount;
		private readonly TreeAccessMethod _accessMethod;
	
		// Properties
		public int Count { get; }
		public bool HasDuplicates { get; }
		public K this[int index] { get => default; }
	
		// Nested types
		private enum NodeColor // TypeDefIndex: 50036
		{
			red = 0,
			black = 1
		}
	
		private struct Node // TypeDefIndex: 50037
		{
			// Fields
			internal int _selfId;
			internal int _leftId;
			internal int _rightId;
			internal int _parentId;
			internal int _nextId;
			internal int _subTreeSize;
			internal K _keyOfNode;
			internal System.Data.RBTree<K> _nodeColor;
		}
	
		[IsReadOnly]
		private struct NodePath // TypeDefIndex: 50038
		{
			// Fields
			internal readonly int _nodeID;
			internal readonly int _mainTreeNodeID;
	
			// Constructors
			internal NodePath(int nodeID, int mainTreeNodeID) {
				_nodeID = default;
				_mainTreeNodeID = default;
			}
		}
	
		private sealed class TreePage // TypeDefIndex: 50039
		{
			// Fields
			internal readonly Node<K>[] _slots;
			internal readonly int[] _slotMap;
			private int _inUseCount;
			private int _pageId;
			private int _nextFreeSlotLine;
	
			// Properties
			internal int InUseCount { get => default; set {} }
			internal int PageId { get => default; set {} }
	
			// Constructors
			public TreePage() {} // Dummy constructor
			internal TreePage(int size) {}
	
			// Methods
			internal int AllocSlot(RBTree<K> tree) => default;
		}
	
		internal struct RBTreeEnumerator : IEnumerator<K> // TypeDefIndex: 50040
		{
			// Fields
			private readonly RBTree<K> _tree;
			private readonly int _version;
			private int _index;
			private int _mainTreeNodeId;
			private K _current;
	
			// Properties
			public K Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal RBTreeEnumerator(RBTree<K> tree) : this() {
				_tree = default;
				_version = default;
				_index = default;
				_mainTreeNodeId = default;
				_current = default;
			}
			internal RBTreeEnumerator(RBTree<K> tree, int position) : this() {
				_tree = default;
				_version = default;
				_index = default;
				_mainTreeNodeId = default;
				_current = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		protected RBTree() {} // Dummy constructor
		protected RBTree(TreeAccessMethod accessMethod) {}
	
		// Methods
		protected abstract int CompareNode(K record1, K record2);
		protected abstract int CompareSateliteTreeNode(K record1, K record2);
		private void InitTree() {}
		private void FreePage(TreePage page) {}
		private TreePage AllocPage(int size) => default;
		private void MarkPageFull(TreePage page) {}
		private void MarkPageFree(TreePage page) {}
		private static int GetIntValueFromBitMap(uint bitMap) => default;
		private void FreeNode(int nodeId) {}
		private int GetIndexOfPageWithFreeSlot(bool allocatedPage) => default;
		private int GetNewNode(K key) => default;
		private int Successor(int x_id) => default;
		private bool Successor(ref int nodeId, ref int mainTreeNodeId) => default;
		private int Minimum(int x_id) => default;
		private int LeftRotate(int root_id, int x_id, int mainTreeNode) => default;
		private int RightRotate(int root_id, int x_id, int mainTreeNode) => default;
		private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) => default;
		public void UpdateNodeKey(K currentKey, K newKey) {}
		public K DeleteByIndex(int i) => default;
		public int RBDelete(int z_id) => default;
		private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) => default;
		private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) => default;
		private int SearchSubTree(int root_id, K key) => default;
		private NodePath GetNodeByKey(K key) => default;
		public int GetIndexByKey(K key) => default;
		public int GetIndexByNode(int node) => default;
		private int GetIndexByNodePath(NodePath path) => default;
		private int ComputeIndexByNode(int nodeId) => default;
		private int ComputeIndexWithSatelliteByNode(int nodeId) => default;
		private NodePath GetNodeByIndex(int userIndex) => default;
		private int ComputeNodeByIndex(int index, out int satelliteRootId) {
			satelliteRootId = default;
			return default;
		}
		private int ComputeNodeByIndex(int x_id, int index) => default;
		public int Insert(K item) => default;
		public int Add(K item) => default;
		public IEnumerator GetEnumerator() => default;
		public int IndexOf(int nodeId, K item) => default;
		public int Insert(int position, K item) => default;
		public int InsertAt(int position, K item, bool append) => default;
		public void RemoveAt(int position) {}
		public void Clear() {}
		public void CopyTo(Array array, int index) {}
		public void CopyTo(K[] array, int index) {}
		private void SetRight(int nodeId, int rightNodeId) {}
		private void SetLeft(int nodeId, int leftNodeId) {}
		private void SetParent(int nodeId, int parentNodeId) {}
		private void SetColor(int nodeId, NodeColor color) {}
		private void SetKey(int nodeId, K key) {}
		private void SetNext(int nodeId, int nextNodeId) {}
		private void SetSubTreeSize(int nodeId, int size) {}
		private void IncreaseSize(int nodeId) {}
		private void RecomputeSize(int nodeId) {}
		private void DecreaseSize(int nodeId) {}
		public int Right(int nodeId) => default;
		public int Left(int nodeId) => default;
		public int Parent(int nodeId) => default;
		private NodeColor color(int nodeId) => default;
		public int Next(int nodeId) => default;
		public int SubTreeSize(int nodeId) => default;
		public K Key(int nodeId) => default;
	}

	internal sealed class RecordManager // TypeDefIndex: 50042
	{
		// Fields
		private readonly DataTable _table; // 0x10
		private int _lastFreeRecord; // 0x18
		private int _minimumCapacity; // 0x1C
		private int _recordCapacity; // 0x20
		private readonly List<int> _freeRecordList; // 0x28
		private DataRow[] _rows; // 0x30
	
		// Properties
		internal int LastFreeRecord { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		internal int MinimumCapacity { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x00000001897B1CB8-0x00000001897B1CF4
		internal int RecordCapacity { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x00000001897B1CF4-0x00000001897B1D7C
		internal DataRow this[int record] { get => default; set {} } // 0x00000001897B1C40-0x00000001897B1C6C 0x00000001897B1C6C-0x00000001897B1CB8
	
		// Constructors
		public RecordManager() {} // Dummy constructor
		internal RecordManager(DataTable table) {} // 0x00000001897B1B74-0x00000001897B1C40
	
		// Methods
		private void GrowRecordCapacity() {} // 0x00000001897B191C-0x00000001897B1A20
		internal static int NewCapacity(int capacity) => default; // 0x00000001897B1A40-0x00000001897B1A50
		private int NormalizedMinimumCapacity(int capacity) => default; // 0x00000001897B1B08-0x00000001897B1B40
		internal int NewRecordBase() => default; // 0x00000001897B1A50-0x00000001897B1B08
		internal void FreeRecord(ref int record) {} // 0x00000001897B1820-0x00000001897B191C
		internal void Clear(bool clearAll) {} // 0x00000001897B13C8-0x00000001897B157C
		internal int ImportRecord(DataTable src, int record) => default; // 0x00000001897B1A20-0x00000001897B1A40
		internal int CopyRecord(DataTable src, int record, int copy) => default; // 0x00000001897B157C-0x00000001897B1820
		internal void SetRowCache(DataRow[] newRows) {} // 0x00000001897B1B40-0x00000001897B1B74
	}

	internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 50043
	{
		// Fields
		private readonly DataKey? _parentKey; // 0xB0
		private readonly DataKey _childKey; // 0xC0
		private readonly DataRowView _parentRowView; // 0xC8
		private readonly object[] _filterValues; // 0xD0
	
		// Constructors
		public RelatedView() {} // Dummy constructor
		public RelatedView(DataColumn[] columns, object[] values) {} // 0x00000001897B1F9C-0x00000001897B20E8
		public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) {} // 0x00000001897B20E8-0x00000001897B2224
	
		// Methods
		private object[] GetParentValues() => default; // 0x00000001897B1DEC-0x00000001897B1E88
		public bool Invoke(DataRow row, DataRowVersion version) => default; // 0x00000001897B1E88-0x00000001897B1F70
		internal override IFilter GetFilter() => default; // 0x000000018339AE90-0x000000018339AEA0
		public override DataRowView AddNew() => default; // 0x00000001897B1D7C-0x00000001897B1DEC
		internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) {} // 0x00000001897B1F70-0x00000001897B1F9C
	}

	internal sealed class RelationshipConverter : ExpandableObjectConverter // TypeDefIndex: 50044
	{
		// Constructors
		public RelationshipConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001897B2224-0x00000001897B22B8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001897B22B8-0x00000001897B2B5C
	}

	public enum Rule // TypeDefIndex: 50045
	{
		None = 0,
		Cascade = 1,
		SetNull = 2,
		SetDefault = 3
	}

	public enum SchemaSerializationMode // TypeDefIndex: 50046
	{
		IncludeSchema = 1,
		ExcludeSchema = 2
	}

	internal sealed class Select // TypeDefIndex: 50048
	{
		// Fields
		private readonly DataTable _table; // 0x10
		private readonly IndexField[] _indexFields; // 0x18
		private DataViewRowState _recordStates; // 0x20
		private DataExpression _rowFilter; // 0x28
		private ExpressionNode _expression; // 0x30
		private Index _index; // 0x38
		private int[] _records; // 0x40
		private int _recordCount; // 0x48
		private ExpressionNode _linearExpression; // 0x50
		private bool _candidatesForBinarySearch; // 0x58
		private ColumnInfo[] _candidateColumns; // 0x60
		private int _nCandidates; // 0x68
		private int _matchedCandidates; // 0x6C
	
		// Nested types
		private sealed class ColumnInfo // TypeDefIndex: 50047
		{
			// Fields
			public bool flag; // 0x10
			public bool equalsOperator; // 0x11
			public BinaryNode expr; // 0x18
	
			// Constructors
			public ColumnInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public Select() {} // Dummy constructor
		public Select(DataTable table, string filterExpression, string sort, DataViewRowState recordStates) {} // 0x00000001897B5674-0x00000001897B5760
	
		// Methods
		private bool IsSupportedOperator(int op) => default; // 0x00000001897B5234-0x00000001897B524C
		private void AnalyzeExpression(BinaryNode expr) {} // 0x00000001897B2CE4-0x00000001897B30FC
		private bool CompareSortIndexDesc(IndexField[] fields) => default; // 0x00000001897B35C8-0x00000001897B36FC
		private bool FindSortIndex() => default; // 0x00000001897B4900-0x00000001897B4B24
		private int CompareClosestCandidateIndexDesc(IndexField[] fields) => default; // 0x00000001897B32B8-0x00000001897B3360
		private bool FindClosestCandidateIndex() => default; // 0x00000001897B453C-0x00000001897B47CC
		private void InitCandidateColumns() {} // 0x00000001897B5088-0x00000001897B51B0
		private void CreateIndex() {} // 0x00000001897B36FC-0x00000001897B3D54
		private bool IsOperatorIn(ExpressionNode enode) => default; // 0x00000001897B51B0-0x00000001897B5234
		private void BuildLinearExpression() {} // 0x00000001897B30FC-0x00000001897B32B8
		public DataRow[] SelectRows() => default; // 0x00000001897B524C-0x00000001897B5524
		public DataRow[] GetRows() => default; // 0x00000001897B4FD4-0x00000001897B5088
		private bool AcceptRecord(int record) => default; // 0x00000001897B2B5C-0x00000001897B2CE4
		private int Eval(BinaryNode expr, DataRow row, DataRowVersion version) => default; // 0x00000001897B3D54-0x00000001897B4408
		private int Evaluate(int record) => default; // 0x00000001897B4408-0x00000001897B453C
		private int FindFirstMatchingRecord() => default; // 0x00000001897B47CC-0x00000001897B4868
		private int FindLastMatchingRecord(int lo) => default; // 0x00000001897B4868-0x00000001897B4900
		private System.Data.Range GetBinaryFilteredRecords() => default; // 0x00000001897B4B24-0x00000001897B4BD4
		private int[] GetLinearFilteredRecords(System.Data.Range range) => default; // 0x00000001897B4BD4-0x00000001897B4DFC
		private DataRow[] GetLinearFilteredRows(System.Data.Range range) => default; // 0x00000001897B4DFC-0x00000001897B4FD4
		private int CompareRecords(int record1, int record2) => default; // 0x00000001897B3360-0x00000001897B35C8
		private void Sort(int left, int right) {} // 0x00000001897B5524-0x00000001897B5674
	}

	[IsReadOnly]
	internal struct IndexField // TypeDefIndex: 50049
	{
		// Fields
		public readonly DataColumn Column; // 0x00
		public readonly bool IsDescending; // 0x08
	
		// Constructors
		internal IndexField(DataColumn column, bool isDescending) {
			Column = default;
			IsDescending = default;
		} // 0x00000001871B198C-0x00000001871B19A8
	
		// Methods
		public static bool operator ==(IndexField if1, IndexField if2) => default; // 0x00000001897AB124-0x00000001897AB13C
		public override bool Equals(object obj) => default; // 0x00000001897AB02C-0x00000001897AB0B0
		public override int GetHashCode() => default; // 0x00000001897AB0B0-0x00000001897AB124
	}

	internal sealed class Index // TypeDefIndex: 50053
	{
		// Fields
		private readonly DataTable _table; // 0x10
		internal readonly IndexField[] _indexFields; // 0x18
		private readonly Comparison<DataRow> _comparison; // 0x20
		private readonly DataViewRowState _recordStates; // 0x28
		private WeakReference _rowFilter; // 0x30
		private IndexTree _records; // 0x38
		private int _recordCount; // 0x40
		private int _refCount; // 0x44
		private Listeners<DataViewListener> _listeners; // 0x48
		private bool _suspendEvents; // 0x50
		private readonly bool _isSharable; // 0x51
		private readonly bool _hasRemoteAggregate; // 0x52
		private static int s_objectTypeCount; // 0x00
		private readonly int _objectID; // 0x54
	
		// Properties
		internal bool HasRemoteAggregate { get => default; } // 0x0000000183D58990-0x0000000183D589A0 
		internal int ObjectID { get => default; } // 0x0000000183D4EEC0-0x0000000183D4EED0 
		public DataViewRowState RecordStates { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public IFilter RowFilter { get => default; } // 0x00000001897AE150-0x00000001897AE1A8 
		public bool HasDuplicates { get => default; } // 0x00000001897AE10C-0x00000001897AE150 
		public int RecordCount { get => default; } // 0x0000000183D4ED80-0x0000000183D4ED90 
		public bool IsSharable { get => default; } // 0x0000000183D518F0-0x0000000183D51900 
		public int RefCount { get => default; } // 0x0000000183D4EE80-0x0000000183D4EE90 
		private bool DoListChanged { get => default; } // 0x00000001897AE0A4-0x00000001897AE10C 
		internal DataTable Table { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Nested types
		private sealed class IndexTree : RBTree<int> // TypeDefIndex: 50050
		{
			// Fields
			private readonly Index _index; // 0x40
	
			// Constructors
			public IndexTree() {} // Dummy constructor
			internal IndexTree(Index index) {} // 0x00000001897AB17C-0x00000001897AB1D4
	
			// Methods
			protected override int CompareNode(int record1, int record2) => default; // 0x00000001897AB13C-0x00000001897AB15C
			protected override int CompareSateliteTreeNode(int record1, int record2) => default; // 0x00000001897AB15C-0x00000001897AB17C
		}
	
		// Constructors
		public Index() {} // Dummy constructor
		public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) {} // 0x00000001897AE078-0x00000001897AE0A4
		public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) {} // 0x00000001897ADCFC-0x00000001897ADD6C
		private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) {} // 0x00000001897ADD6C-0x00000001897AE078
	
		// Methods
		private static IndexField[] GetAllFields(DataColumnCollection columns) => default; // 0x00000001897AC15C-0x00000001897AC21C
		public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) => default; // 0x00000001897ABA84-0x00000001897ABB40
		public int GetRecord(int recordIndex) => default; // 0x00000001897AC5E4-0x00000001897AC638
		private bool AcceptRecord(int record) => default; // 0x00000001897AB2DC-0x00000001897AB30C
		private bool AcceptRecord(int record, IFilter filter) => default; // 0x00000001897AB1D4-0x00000001897AB2DC
		internal void ListChangedAdd(DataViewListener listener) {} // 0x00000001897AD060-0x00000001897AD0B4
		internal void ListChangedRemove(DataViewListener listener) {} // 0x00000001897AD0B4-0x00000001897AD108
		public void AddRef() {} // 0x00000001897AB30C-0x00000001897AB4A0
		public int RemoveRef() => default; // 0x00000001897ADAA0-0x00000001897ADC40
		private void ApplyChangeAction(int record, int action, int changeRecord) {} // 0x00000001897AB4A0-0x00000001897AB518
		public bool CheckUnique() => default; // 0x00000001897AB518-0x00000001897AB52C
		private int CompareRecords(int record1, int record2) => default; // 0x00000001897AB814-0x00000001897AB960
		private int CompareDataRows(int record1, int record2) => default; // 0x00000001897AB52C-0x00000001897AB5B4
		private int CompareDuplicateRecords(int record1, int record2) => default; // 0x00000001897AB5B4-0x00000001897AB758
		private int CompareRecordToKey(int record1, object[] vals) => default; // 0x00000001897AB758-0x00000001897AB814
		public void DeleteRecordFromIndex(int recordIndex) {} // 0x00000001897AB960-0x00000001897AB96C
		private void DeleteRecord(int recordIndex) {} // 0x00000001897ABA78-0x00000001897ABA84
		private void DeleteRecord(int recordIndex, bool fireEvent) {} // 0x00000001897AB96C-0x00000001897ABA78
		public RBTree<int> GetEnumerator(int startIndex) => default; // 0x00000001897AC238-0x00000001897AC2A4
		public int GetIndex(int record) => default; // 0x00000001897AC2A4-0x00000001897AC2F8
		private int GetIndex(int record, int changeRecord) => default; // 0x00000001897AC2F8-0x00000001897AC4B8
		public object[] GetUniqueKeyValues() => default; // 0x00000001897AC7F0-0x00000001897AC8BC
		private int FindNodeByKey(object originalKey) => default; // 0x00000001897ABC18-0x00000001897ABE10
		private int FindNodeByKeys(object[] originalKey) => default; // 0x00000001897ABE10-0x00000001897ABFF8
		private int FindNodeByKeyRecord(int record) => default; // 0x00000001897ABB40-0x00000001897ABC18
		private System.Data.Range GetRangeFromNode(int nodeId) => default; // 0x00000001897AC4B8-0x00000001897AC5E4
		public System.Data.Range FindRecords(object key) => default; // 0x00000001897AC048-0x00000001897AC098
		public System.Data.Range FindRecords(object[] key) => default; // 0x00000001897ABFF8-0x00000001897AC048
		internal void FireResetEvent() {} // 0x00000001897AC098-0x00000001897AC15C
		private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) => default; // 0x00000001897AC21C-0x00000001897AC238
		private static int GetReplaceAction(DataViewRowState oldState) => default; // 0x00000001897AC638-0x00000001897AC650
		public DataRow GetRow(int i) => default; // 0x00000001897AC650-0x00000001897AC688
		public DataRow[] GetRows(object[] values) => default; // 0x00000001897AC7AC-0x00000001897AC7F0
		public DataRow[] GetRows(System.Data.Range range) => default; // 0x00000001897AC688-0x00000001897AC7AC
		private void InitRecords(IFilter filter) {} // 0x00000001897ACA50-0x00000001897ACDE0
		public int InsertRecordToIndex(int record) => default; // 0x00000001897ACDE0-0x00000001897ACE20
		private int InsertRecord(int record, bool fireEvent) => default; // 0x00000001897ACE20-0x00000001897AD018
		public bool IsKeyInIndex(object key) => default; // 0x00000001897AD018-0x00000001897AD030
		public bool IsKeyInIndex(object[] key) => default; // 0x00000001897AD030-0x00000001897AD048
		public bool IsKeyRecordInIndex(int record) => default; // 0x00000001897AD048-0x00000001897AD060
		private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) {} // 0x00000001897AD2BC-0x00000001897AD368
		private void OnListChanged(ListChangedType changedType, int index) {} // 0x00000001897AD228-0x00000001897AD2BC
		private void OnListChanged(ListChangedEventArgs e) {} // 0x00000001897AD368-0x00000001897AD4F4
		private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) {} // 0x00000001897AD108-0x00000001897AD228
		public void Reset() {} // 0x00000001897ADC40-0x00000001897ADCFC
		public void RecordChanged(int record) {} // 0x00000001897AD5F0-0x00000001897AD6B8
		public void RecordChanged(int oldIndex, int newIndex) {} // 0x00000001897AD4F4-0x00000001897AD5F0
		public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) {} // 0x00000001897AD9B0-0x00000001897ADAA0
		public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) {} // 0x00000001897AD6B8-0x00000001897AD9B0
		private void GetUniqueKeyValues(List<object[]> list, int curNodeId) {} // 0x00000001897AC8BC-0x00000001897ACA50
		internal static int IndexOfReference<T>(List<T> list, T item)
			where T : class => default;
	}

	internal sealed class Listeners<TElem> // TypeDefIndex: 50056
		where TElem : class
	{
		// Fields
		private readonly List<TElem> _listeners;
		private readonly Func<bool> _filter;
		private readonly int _objectID;
		private int _listenerReaderCount;
	
		// Properties
		internal bool HasListeners { get => default; }
	
		// Nested types
		internal delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 50054; 0x00000000-0x00000000
	
		internal delegate TResult Func<T1, TResult>(T1 arg1); // TypeDefIndex: 50055; 0x00000000-0x00000000
	
		// Constructors
		public Listeners() {} // Dummy constructor
		internal Listeners(int ObjectID, Func<bool> notifyFilter) {}
	
		// Methods
		internal void Add(TElem listener) {}
		internal int IndexOfReference(TElem listener) => default;
		internal void Remove(TElem listener) {}
		internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Action<T1, T2, T3> action) {}
		private void RemoveNullListeners(int nullIndex) {}
	}

	[Serializable]
	internal sealed class SimpleType : ISerializable // TypeDefIndex: 50057
	{
		// Fields
		private string _baseType; // 0x10
		private SimpleType _baseSimpleType; // 0x18
		private XmlQualifiedName _xmlBaseType; // 0x20
		private string _name; // 0x28
		private int _length; // 0x30
		private int _minLength; // 0x34
		private int _maxLength; // 0x38
		private string _pattern; // 0x40
		private string _ns; // 0x48
		private string _maxExclusive; // 0x50
		private string _maxInclusive; // 0x58
		private string _minExclusive; // 0x60
		private string _minInclusive; // 0x68
		internal string _enumeration; // 0x70
	
		// Properties
		internal string BaseType { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		internal XmlQualifiedName XmlBaseType { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal string Name { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		internal string Namespace { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal int Length { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		internal int MaxLength { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		internal SimpleType BaseSimpleType { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public string SimpleTypeQualifiedName { get => default; } // 0x00000001897B6D00-0x00000001897B6D60 
	
		// Constructors
		public SimpleType() {} // Dummy constructor
		internal SimpleType(string baseType) {} // 0x00000001897B69E0-0x00000001897B6B24
		internal SimpleType(XmlSchemaSimpleType node) {} // 0x00000001897B6B24-0x00000001897B6D00
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001897B65BC-0x00000001897B6608
		internal void LoadTypeValues(XmlSchemaSimpleType node) {} // 0x00000001897B5C68-0x00000001897B6554
		internal bool IsPlainString() => default; // 0x00000001897B5B60-0x00000001897B5C68
		internal string QualifiedName(string name) => default; // 0x00000001897B6554-0x00000001897B65BC
		internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) => default; // 0x00000001897B6608-0x00000001897B69E0
		internal static SimpleType CreateEnumeratedType(string values) => default; // 0x00000001897B58C4-0x00000001897B5940
		internal static SimpleType CreateByteArrayType(string encoding) => default; // 0x00000001897B5860-0x00000001897B58C4
		internal static SimpleType CreateLimitedStringType(int length) => default; // 0x00000001897B5940-0x00000001897B59B4
		internal static SimpleType CreateSimpleType(StorageType typeCode, System.Type type) => default; // 0x00000001897B59B4-0x00000001897B5A70
		internal string HasConflictingDefinition(SimpleType otherSimpleType) => default; // 0x00000001897B5A70-0x00000001897B5B60
		internal bool CanHaveMaxLength() => default; // 0x00000001897B5760-0x00000001897B57BC
		internal void ConvertToAnnonymousSimpleType() {} // 0x00000001897B57BC-0x00000001897B5860
	}

	[DefaultProperty("ConstraintName")]
	public class UniqueConstraint : System.Data.Constraint // TypeDefIndex: 50058
	{
		// Fields
		private DataKey _key; // 0x38
		private Index _constraintIndex; // 0x40
		internal bool _bPrimaryKey; // 0x48
		internal string _constraintName; // 0x50
		internal string[] _columnNames; // 0x58
	
		// Properties
		internal string[] ColumnNames { get => default; } // 0x00000001897B876C-0x00000001897B8778 
		internal Index ConstraintIndex { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[ReadOnly(true)]
		public virtual DataColumn[] Columns { get => default; } // 0x00000001897B8778-0x00000001897B8784 
		internal DataColumn[] ColumnsReference { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public bool IsPrimaryKey { get => default; } // 0x00000001897B8784-0x00000001897B87C0 
		internal override bool InCollection { set {} } // 0x00000001897B87D8-0x00000001897B8820
		internal DataKey Key { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[ReadOnly(true)]
		public override DataTable Table { get => default; } // 0x00000001897B87C0-0x00000001897B87D8 
	
		// Constructors
		public UniqueConstraint() {} // Dummy constructor
		public UniqueConstraint(DataColumn column) {} // 0x00000001897B85EC-0x00000001897B8680
		public UniqueConstraint(string name, DataColumn[] columns) {} // 0x00000001897B8680-0x00000001897B86C0
		public UniqueConstraint(DataColumn[] columns) {} // 0x00000001897B85B8-0x00000001897B85EC
		[Browsable(false)]
		public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey) {} // 0x00000001897B8710-0x00000001897B876C
		public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey) {} // 0x00000001897B86C0-0x00000001897B8710
	
		// Methods
		internal void ConstraintIndexClear() {} // 0x00000001897B81F8-0x00000001897B8230
		internal void ConstraintIndexInitialize() {} // 0x00000001897B8230-0x00000001897B8274
		internal override void CheckState() {} // 0x00000001897B79F8-0x00000001897B7A04
		private void NonVirtualCheckState() {} // 0x00000001897B79F8-0x00000001897B7A04
		internal override void CheckCanAddToCollection(ConstraintCollection constraints) {} // 0x000000018350B670-0x000000018350B680
		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) => default; // 0x00000001897B7754-0x00000001897B78CC
		internal override bool CanEnableConstraint() => default; // 0x00000001897B78CC-0x00000001897B7914
		internal override bool IsConstraintViolated() => default; // 0x00000001897B83D4-0x00000001897B85B8
		internal override void CheckConstraint(DataRow row, DataRowAction action) {} // 0x00000001897B7914-0x00000001897B79F8
		internal override bool ContainsColumn(DataColumn column) => default; // 0x00000001897B8274-0x00000001897B8280
		internal override System.Data.Constraint Clone(DataSet destination) => default; // 0x00000001897AA500-0x00000001897AA510
		internal override System.Data.Constraint Clone(DataSet destination, bool ignorNSforTableLookup) => default; // 0x00000001897B7D84-0x00000001897B81F8
		internal UniqueConstraint Clone(DataTable table) => default; // 0x00000001897B7A04-0x00000001897B7D84
		private void Create(string constraintName, DataColumn[] columns) {} // 0x00000001897B8280-0x00000001897B834C
		public override bool Equals(object key2) => default; // 0x00000001897B834C-0x00000001897B83D4
		public override int GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 50060
	{
		// Fields
		internal string _schemaName; // 0x10
		internal string _schemaUri; // 0x18
		internal XmlElement _schemaRoot; // 0x20
		internal DataSet _ds; // 0x28
		private static readonly char[] s_colonArray; // 0x00
		private static NameType[] s_mapNameTypeXdr; // 0x08
		private static NameType s_enumerationNameType; // 0x10
	
		// Nested types
		private sealed class NameType : IComparable // TypeDefIndex: 50059
		{
			// Fields
			public string name; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public NameType() {} // Dummy constructor
			public NameType(string n, System.Type t) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			public int CompareTo(object obj) => default; // 0x00000001897BBAEC-0x00000001897BBB60
		}
	
		// Constructors
		public XDRSchema() {} // Dummy constructor
		internal XDRSchema(DataSet ds, bool fInline) {} // 0x00000001897BB9B0-0x00000001897BBA40
		static XDRSchema() {} // 0x00000001897BAAEC-0x00000001897BB9B0
	
		// Methods
		internal void LoadSchema(XmlElement schemaRoot, DataSet ds) {} // 0x00000001897BA7B0-0x00000001897BA9AC
		internal XmlElement FindTypeNode(XmlElement node) => default; // 0x00000001897B88E4-0x00000001897B8BAC
		internal bool IsTextOnlyContent(XmlElement node) => default; // 0x00000001897BA4DC-0x00000001897BA67C
		internal bool IsXDRField(XmlElement node, XmlElement typeNode) => default; // 0x00000001897BA67C-0x00000001897BA7B0
		internal DataTable HandleTable(XmlElement node) => default; // 0x00000001897B9928-0x00000001897B9AAC
		private static NameType FindNameType(string name) => default; // 0x00000001897B8820-0x00000001897B88E4
		private System.Type ParseDataType(string dt, string dtValues) => default; // 0x00000001897BA9AC-0x00000001897BAAEC
		internal string GetInstanceName(XmlElement node) => default; // 0x00000001897B8BAC-0x00000001897B8D1C
		internal void HandleColumn(XmlElement node, DataTable table) {} // 0x00000001897B90D8-0x00000001897B9928
		internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) {} // 0x00000001897B90B4-0x00000001897B90D8
		internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) {} // 0x00000001897B8D1C-0x00000001897B90B4
		internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) {} // 0x00000001897B9AAC-0x00000001897B9C24
		internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) => default; // 0x00000001897B9E90-0x00000001897BA4DC
		internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) => default; // 0x00000001897B9C24-0x00000001897B9E90
	}

	internal sealed class XMLDiffLoader // TypeDefIndex: 50061
	{
		// Fields
		private ArrayList _tables; // 0x10
		private DataSet _dataSet; // 0x18
		private DataTable _dataTable; // 0x20
	
		// Constructors
		public XMLDiffLoader() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) {} // 0x00000001897BBF40-0x00000001897BC094
		private void CreateTablesHierarchy(DataTable dt) {} // 0x00000001897BBBD4-0x00000001897BBDD8
		internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) {} // 0x00000001897BC094-0x00000001897BC250
		internal void ProcessDiffs(DataSet ds, XmlReader ssync) {} // 0x00000001897BC250-0x00000001897BC4FC
		internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) {} // 0x00000001897BC4FC-0x00000001897BC798
		internal void ProcessErrors(DataSet ds, XmlReader ssync) {} // 0x00000001897BCB2C-0x00000001897BCE0C
		internal void ProcessErrors(ArrayList dt, XmlReader ssync) {} // 0x00000001897BC798-0x00000001897BCB2C
		private DataTable GetTable(string tableName, string ns) => default; // 0x00000001897BBDD8-0x00000001897BBF40
		private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) => default; // 0x00000001897BCE0C-0x00000001897BE114
		internal void SkipWhitespaces(XmlReader reader) {} // 0x00000001897BE114-0x00000001897BE164
	}

	internal class XMLSchema // TypeDefIndex: 50062
	{
		// Constructors
		public XMLSchema() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static TypeConverter GetConverter(System.Type type) => default; // 0x00000001897BE410-0x00000001897BE45C
		internal static void SetProperties(object instance, XmlAttributeCollection attrs) {} // 0x00000001897BE45C-0x00000001897BE7CC
		internal static bool FEqualIdentity(XmlNode node, string name, string ns) => default; // 0x00000001897BE164-0x00000001897BE1D4
		internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) => default; // 0x00000001897BE2DC-0x00000001897BE410
		internal static string GenUniqueColumnName(string proposedName, DataTable table) => default; // 0x00000001897BE1D4-0x00000001897BE2DC
	}

	internal sealed class ConstraintTable // TypeDefIndex: 50063
	{
		// Fields
		public DataTable table; // 0x10
		public XmlSchemaIdentityConstraint constraint; // 0x18
	
		// Constructors
		public ConstraintTable() {} // Dummy constructor
		public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c) {} // 0x0000000182676770-0x00000001826767A0
	}

	internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 50065
	{
		// Fields
		private XmlSchemaSet _schemaSet; // 0x10
		private XmlSchemaElement _dsElement; // 0x18
		private DataSet _ds; // 0x20
		private string _schemaName; // 0x28
		private ArrayList _columnExpressions; // 0x30
		private Hashtable _constraintNodes; // 0x38
		private ArrayList _refTables; // 0x40
		private ArrayList _complexTypes; // 0x48
		private XmlSchemaObjectCollection _annotations; // 0x50
		private XmlSchemaObjectCollection _elements; // 0x58
		private Hashtable _attributes; // 0x60
		private Hashtable _elementsTable; // 0x68
		private Hashtable _attributeGroups; // 0x70
		private Hashtable _schemaTypes; // 0x78
		private Hashtable _expressions; // 0x80
		private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
		private Hashtable _udSimpleTypes; // 0x90
		private Hashtable _existingSimpleTypeMap; // 0x98
		private bool _fromInference; // 0xA0
		private static readonly NameType[] s_mapNameTypeXsd; // 0x00
	
		// Properties
		internal bool FromInference { get => default; set {} } // 0x0000000183D50A40-0x0000000183D50A50 0x0000000183D50A60-0x0000000183D50A70
	
		// Nested types
		private sealed class NameType : IComparable // TypeDefIndex: 50064
		{
			// Fields
			public readonly string name; // 0x10
			public readonly System.Type type; // 0x18
	
			// Constructors
			public NameType() {} // Dummy constructor
			public NameType(string n, System.Type t) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			public int CompareTo(object obj) => default; // 0x00000001897BBB60-0x00000001897BBBD4
		}
	
		// Constructors
		public XSDSchema() {} // 0x000000018350B670-0x000000018350B680
		static XSDSchema() {} // 0x00000001897CF038-0x00000001897D013C
	
		// Methods
		private void CollectElementsAnnotations(XmlSchema schema) {} // 0x00000001897BF334-0x00000001897BF3B8
		private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) {} // 0x00000001897BEBC4-0x00000001897BF334
		internal static string QualifiedName(string name) => default; // 0x00000001897CE520-0x00000001897CE588
		internal static void SetProperties(object instance, XmlAttribute[] attrs) {} // 0x00000001897CEA08-0x00000001897CEE44
		private static void SetExtProperties(object instance, XmlAttribute[] attrs) {} // 0x00000001897CE74C-0x00000001897CEA08
		private void HandleColumnExpression(object instance, XmlAttribute[] attrs) {} // 0x00000001897C1A28-0x00000001897C1BE8
		internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) => default; // 0x00000001897BFF88-0x00000001897C0080
		private static void SetExtProperties(object instance, XmlAttributeCollection attrs) {} // 0x00000001897CE588-0x00000001897CE74C
		internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) {} // 0x00000001897C657C-0x00000001897C6660
		internal void HandleRelation(XmlElement node, bool fNested) {} // 0x00000001897C6660-0x00000001897C6E74
		private bool HasAttributes(XmlSchemaObjectCollection attributes) => default; // 0x00000001897C8254-0x00000001897C83E8
		private bool IsDatasetParticle(XmlSchemaParticle pt) => default; // 0x00000001897CAD64-0x00000001897CB1D4
		private int DatasetElementCount(XmlSchemaObjectCollection elements) => default; // 0x00000001897BF3B8-0x00000001897BF548
		private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) => default; // 0x00000001897BF548-0x00000001897BF8F0
		public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) {} // 0x00000001897CE3B8-0x00000001897CE3E4
		public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) {} // 0x00000001897CB48C-0x00000001897CE3B8
		private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) {} // 0x00000001897C6E74-0x00000001897C70AC
		internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) => default; // 0x00000001897C02E8-0x00000001897C04C4
		internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) {} // 0x00000001897C5C60-0x00000001897C657C
		internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) {} // 0x00000001897C1814-0x00000001897C1A28
		private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) {} // 0x00000001897C1530-0x00000001897C1814
		internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) {} // 0x00000001897C1BE8-0x00000001897C21BC
		internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) => default; // 0x00000001897C04C4-0x00000001897C05D0
		internal DataColumn FindField(DataTable table, string field) => default; // 0x00000001897BF8F0-0x00000001897BFA70
		internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) => default; // 0x00000001897BE998-0x00000001897BEBC4
		internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) => default; // 0x00000001897BFD8C-0x00000001897BFEBC
		internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) => default; // 0x00000001897C082C-0x00000001897C089C
		internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) => default; // 0x00000001897CEE44-0x00000001897CEEAC
		internal static System.Data.Rule TranslateRule(string strRule) => default; // 0x00000001897CEEAC-0x00000001897CEF6C
		internal void HandleKeyref(XmlSchemaKeyref keyref) {} // 0x00000001897C54A4-0x00000001897C5C60
		internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) {} // 0x00000001897C21BC-0x00000001897C2608
		internal DataTable InstantiateSimpleTable(XmlSchemaElement node) => default; // 0x00000001897C83E8-0x00000001897C8B44
		internal string GetInstanceName(XmlSchemaAnnotated node) => default; // 0x00000001897BFEBC-0x00000001897BFF88
		internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) => default; // 0x00000001897C8B44-0x00000001897CAD64
		public static System.Type XsdtoClr(string xsdTypeName) => default; // 0x00000001897CEF6C-0x00000001897CF038
		private static NameType FindNameType(string name) => default; // 0x00000001897BFA70-0x00000001897BFB30
		private System.Type ParseDataType(string dt) => default; // 0x00000001897CE3E4-0x00000001897CE520
		internal static bool IsXsdType(string name) => default; // 0x00000001897CB434-0x00000001897CB48C
		internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) => default; // 0x00000001897BFB30-0x00000001897BFD8C
		internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) {} // 0x00000001897C77CC-0x00000001897C8100
		internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) {} // 0x00000001897C70AC-0x00000001897C77CC
		internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) {} // 0x00000001897C0B28-0x00000001897C1530
		internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) {} // 0x00000001897C47BC-0x00000001897C54A4
		internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) {} // 0x00000001897C2608-0x00000001897C47BC
		private void AddTablesToList(List<DataTable> tableList, DataTable dt) {} // 0x00000001897BE7CC-0x00000001897BE998
		private string GetPrefix(string ns) => default; // 0x00000001897C05D0-0x00000001897C082C
		private string GetNamespaceFromPrefix(string prefix) => default; // 0x00000001897C0080-0x00000001897C02E8
		private string GetTableNamespace(XmlSchemaIdentityConstraint key) => default; // 0x00000001897C09A8-0x00000001897C0B28
		private string GetTableName(XmlSchemaIdentityConstraint key) => default; // 0x00000001897C089C-0x00000001897C09A8
		internal bool IsTable(XmlSchemaElement node) => default; // 0x00000001897CB1D4-0x00000001897CB434
		internal DataTable HandleTable(XmlSchemaElement node) => default; // 0x00000001897C8100-0x00000001897C8254
	}

	internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 50066
	{
		// Fields
		private List<string> _namespacesToIgnore; // 0x30
	
		// Constructors
		public XmlIgnoreNamespaceReader() {} // Dummy constructor
		internal XmlIgnoreNamespaceReader(XmlDocument xdoc, string[] namespacesToIgnore) {} // 0x00000001897D4AB4-0x00000001897D4B4C
	
		// Methods
		public override bool MoveToFirstAttribute() => default; // 0x00000001897D48DC-0x00000001897D49C4
		public override bool MoveToNextAttribute() => default; // 0x00000001897D49C4-0x00000001897D4AB4
	}

	internal sealed class XmlDataLoader // TypeDefIndex: 50067
	{
		// Fields
		private DataSet _dataSet; // 0x10
		private XmlToDatasetMap _nodeToSchemaMap; // 0x18
		private Hashtable _nodeToRowMap; // 0x20
		private Stack _childRowsStack; // 0x28
		private Hashtable _htableExcludedNS; // 0x30
		private bool _fIsXdr; // 0x38
		internal bool _isDiffgram; // 0x39
		private XmlElement _topMostNode; // 0x40
		private bool _ignoreSchema; // 0x48
		private DataTable _dataTable; // 0x50
		private bool _isTableLevel; // 0x58
		private bool _fromInference; // 0x59
		private XmlReader _dataReader; // 0x60
		private object _XSD_XMLNS_NS; // 0x68
		private object _XDR_SCHEMA; // 0x70
		private object _XDRNS; // 0x78
		private object _SQL_SYNC; // 0x80
		private object _UPDGNS; // 0x88
		private object _XSD_SCHEMA; // 0x90
		private object _XSDNS; // 0x98
		private object _DFFNS; // 0xA0
		private object _MSDNS; // 0xA8
		private object _DIFFID; // 0xB0
		private object _HASCHANGES; // 0xB8
		private object _ROWORDER; // 0xC0
	
		// Properties
		internal bool FromInference { get => default; set {} } // 0x0000000183D589D0-0x0000000183D589E0 0x0000000183D5B3E0-0x0000000183D5B3F0
	
		// Constructors
		public XmlDataLoader() {} // Dummy constructor
		internal XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema) {} // 0x00000001897D45B8-0x00000001897D4650
		internal XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) {} // 0x00000001897D47F4-0x00000001897D48DC
		internal XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema) {} // 0x00000001897D4650-0x00000001897D46FC
		internal XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) {} // 0x00000001897D46FC-0x00000001897D47F4
	
		// Methods
		private void AttachRows(DataRow parentRow, XmlNode parentElement) {} // 0x00000001897D013C-0x00000001897D0264
		private int CountNonNSAttributes(XmlNode node) => default; // 0x00000001897D0264-0x00000001897D0330
		private string GetValueForTextOnlyColums(XmlNode n) => default; // 0x00000001897D08B4-0x00000001897D0A5C
		private string GetInitialTextFromNodes(ref XmlNode n) => default; // 0x00000001897D05BC-0x00000001897D07B8
		private DataColumn GetTextOnlyColumn(DataRow row) => default; // 0x00000001897D081C-0x00000001897D08B4
		internal DataRow GetRowFromElement(XmlElement e) => default; // 0x00000001897D07B8-0x00000001897D081C
		internal bool FColumnElement(XmlElement e) => default; // 0x00000001897D0330-0x00000001897D03FC
		private bool FExcludedNamespace(string ns) => default; // 0x00000001897D03FC-0x00000001897D0474
		private bool FIgnoreNamespace(XmlNode node) => default; // 0x00000001897D04F0-0x00000001897D05BC
		private bool FIgnoreNamespace(XmlReader node) => default; // 0x00000001897D0474-0x00000001897D04F0
		internal bool IsTextLikeNode(XmlNodeType n) => default; // 0x00000001897D0CF0-0x00000001897D0D38
		internal bool IsTextOnly(DataColumn c) => default; // 0x00000001897D0D38-0x00000001897D0D58
		internal void LoadData(XmlDocument xdoc) {} // 0x00000001897D1594-0x00000001897D1834
		private void LoadRowData(DataRow row, XmlElement rowElement) {} // 0x00000001897D1B88-0x00000001897D2500
		private void LoadRows(DataRow parentRow, XmlNode parentElement) {} // 0x00000001897D2500-0x00000001897D27D0
		private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) {} // 0x00000001897D456C-0x00000001897D45B8
		private void InitNameTable() {} // 0x00000001897D0A5C-0x00000001897D0CF0
		internal void LoadData(XmlReader reader) {} // 0x00000001897D1834-0x00000001897D1B88
		private void LoadTopMostTable(DataTable table) {} // 0x00000001897D32CC-0x00000001897D4378
		private void LoadTable(DataTable table, bool isNested) {} // 0x00000001897D27D0-0x00000001897D32CC
		private void LoadColumn(DataColumn column, object[] foundColumns) {} // 0x00000001897D0D58-0x00000001897D1594
		private bool ProcessXsdSchema() => default; // 0x00000001897D4378-0x00000001897D456C
	}

	public enum XmlReadMode // TypeDefIndex: 50068
	{
		Auto = 0,
		ReadSchema = 1,
		IgnoreSchema = 2,
		InferSchema = 3,
		DiffGram = 4,
		Fragment = 5,
		InferTypedSchema = 6
	}

	internal sealed class XmlToDatasetMap // TypeDefIndex: 50072
	{
		// Fields
		private XmlNodeIdHashtable _tableSchemaMap; // 0x10
		private TableSchemaInfo _lastTableSchemaInfo; // 0x18
	
		// Nested types
		private sealed class XmlNodeIdentety // TypeDefIndex: 50069
		{
			// Fields
			public string LocalName; // 0x10
			public string NamespaceURI; // 0x18
	
			// Constructors
			public XmlNodeIdentety() {} // Dummy constructor
			public XmlNodeIdentety(string localName, string namespaceURI) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
			public override bool Equals(object obj) => default; // 0x00000001897DB534-0x00000001897DB5C0
		}
	
		internal sealed class XmlNodeIdHashtable : Hashtable // TypeDefIndex: 50070
		{
			// Fields
			private XmlNodeIdentety _id; // 0x50
	
			// Properties
			public object this[XmlNode node] { get => default; } // 0x00000001897DB42C-0x00000001897DB4B0 
			public object this[XmlReader dataReader] { get => default; } // 0x00000001897DB4B0-0x00000001897DB534 
			public object this[DataTable table] { get => default; } // 0x00000001897DB3AC-0x00000001897DB42C 
			public object this[string name] { get => default; } // 0x00000001897DB320-0x00000001897DB3AC 
	
			// Constructors
			public XmlNodeIdHashtable() {} // Dummy constructor
			public XmlNodeIdHashtable(int capacity) {} // 0x00000001897DB268-0x00000001897DB320
		}
	
		private sealed class TableSchemaInfo // TypeDefIndex: 50071
		{
			// Fields
			public DataTable TableSchema; // 0x10
			public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18
	
			// Constructors
			public TableSchemaInfo() {} // Dummy constructor
			public TableSchemaInfo(DataTable tableSchema) {} // 0x00000001897D74F0-0x00000001897D758C
		}
	
		// Constructors
		public XmlToDatasetMap() {} // Dummy constructor
		public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable) {} // 0x00000001897DD8F8-0x00000001897DD900
		public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet) {} // 0x00000001897DD8E8-0x00000001897DD8F0
		public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable) {} // 0x00000001897DD900-0x00000001897DD908
		public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable) {} // 0x00000001897DD8F0-0x00000001897DD8F8
	
		// Methods
		internal static bool IsMappedColumn(DataColumn c) => default; // 0x00000001897DD8C8-0x00000001897DD8E8
		private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) => default; // 0x00000001897DB8CC-0x00000001897DB9F8
		private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) => default; // 0x00000001897DB9F8-0x00000001897DBB84
		private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) => default; // 0x00000001897DB5C0-0x00000001897DB708
		private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) => default; // 0x00000001897DB708-0x00000001897DB8CC
		private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) {} // 0x00000001897DBB84-0x00000001897DBEF8
		private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) {} // 0x00000001897DC108-0x00000001897DC8B8
		private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) {} // 0x00000001897DBEF8-0x00000001897DC108
		private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) {} // 0x00000001897DC8B8-0x00000001897DD008
		private ArrayList GetSelfAndDescendants(DataTable dt) => default; // 0x00000001897DD3E8-0x00000001897DD694
		public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) => default; // 0x00000001897DD008-0x00000001897DD1AC
		public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) => default; // 0x00000001897DD1AC-0x00000001897DD30C
		public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) => default; // 0x00000001897DD30C-0x00000001897DD3E8
		public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) => default; // 0x00000001897DD694-0x00000001897DD768
		private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) {} // 0x00000001897DD768-0x00000001897DD8C8
	}

	public enum XmlWriteMode // TypeDefIndex: 50073
	{
		WriteSchema = 0,
		IgnoreSchema = 1,
		DiffGram = 2
	}

	internal enum SchemaFormat // TypeDefIndex: 50074
	{
		Public = 1,
		Remoting = 2,
		WebService = 3,
		RemotingSkipSchema = 4,
		WebServiceSkipSchema = 5
	}

	internal sealed class XmlTreeGen // TypeDefIndex: 50075
	{
		// Fields
		private ArrayList _constraintNames; // 0x10
		private Hashtable _namespaces; // 0x18
		private Hashtable _autogenerated; // 0x20
		private Hashtable _prefixes; // 0x28
		private DataSet _ds; // 0x30
		private ArrayList _tables; // 0x38
		private ArrayList _relations; // 0x40
		private XmlDocument _dc; // 0x48
		private XmlElement _sRoot; // 0x50
		private int _prefixCount; // 0x58
		private SchemaFormat _schFormat; // 0x5C
		private string _filePath; // 0x60
		private string _fileName; // 0x68
		private string _fileExt; // 0x70
		private XmlElement _dsElement; // 0x78
		private XmlElement _constraintSeparator; // 0x80
		private Converter<System.Type, string> _targetConverter; // 0x88
	
		// Constructors
		public XmlTreeGen() {} // Dummy constructor
		internal XmlTreeGen(SchemaFormat format) {} // 0x00000001897EA504-0x00000001897EA5A4
	
		// Methods
		internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) {} // 0x00000001897DDE60-0x00000001897DDE6C
		internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, System.Type type) {} // 0x00000001897DDE6C-0x00000001897DE42C
		internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) {} // 0x00000001897DE42C-0x00000001897DE568
		internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) {} // 0x00000001897DE568-0x00000001897DECB0
		internal static string XmlDataTypeName(System.Type type) => default; // 0x00000001897E9B84-0x00000001897EA4E0
		private void GenerateConstraintNames(DataTable table, bool fromTable) {} // 0x00000001897E0910-0x00000001897E0DD0
		private void GenerateConstraintNames(ArrayList tables) {} // 0x00000001897E0600-0x00000001897E0694
		private void GenerateConstraintNames(DataSet ds) {} // 0x00000001897E0694-0x00000001897E0910
		private static bool _PropsNotEmpty(PropertyCollection props) => default; // 0x00000001897EA4E0-0x00000001897EA504
		private bool HaveExtendedProperties(DataSet ds) => default; // 0x00000001897E470C-0x00000001897E4854
		internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) {} // 0x00000001897E99AC-0x00000001897E9B84
		internal static void ValidateColumnMapping(System.Type columnType) {} // 0x00000001897E9940-0x00000001897E99AC
		internal void SetupAutoGenerated(DataSet ds) {} // 0x00000001897E8BC8-0x00000001897E8E40
		internal void SetupAutoGenerated(ArrayList dt) {} // 0x00000001897E97CC-0x00000001897E985C
		internal void SetupAutoGenerated(DataTable dt) {} // 0x00000001897E8E40-0x00000001897E97CC
		private void CreateTablesHierarchy(DataTable dt) {} // 0x00000001897DF7C0-0x00000001897DFAEC
		private void CreateRelations(DataTable dt) {} // 0x00000001897DF4B0-0x00000001897DF7C0
		private DataTable[] CreateToplevelTables() => default; // 0x00000001897DFAEC-0x00000001897DFD14
		internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) {} // 0x00000001897E4F7C-0x00000001897E88BC
		internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) => default; // 0x00000001897E4AF4-0x00000001897E4F7C
		internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) => default; // 0x00000001897DFD14-0x00000001897E0298
		internal void SetPath(XmlWriter xw) {} // 0x00000001897E8A60-0x00000001897E8BC8
		internal void Save(DataSet ds, XmlWriter xw) {} // 0x00000001897E4A20-0x00000001897E4A40
		internal void Save(DataTable dt, XmlWriter xw) {} // 0x00000001897E4A40-0x00000001897E4AF4
		internal void Save(DataSet ds, DataTable dt, XmlWriter xw) {} // 0x00000001897E48B0-0x00000001897E48CC
		internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) {} // 0x00000001897E488C-0x00000001897E48B0
		internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<System.Type, string> multipleTargetConverter) {} // 0x00000001897E48CC-0x00000001897E4A20
		internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) => default; // 0x00000001897E1C3C-0x00000001897E219C
		private static XmlElement FindSimpleType(XmlElement schema, string name) => default; // 0x00000001897E0298-0x00000001897E036C
		internal XmlElement GetSchema(string NamespaceURI) => default; // 0x00000001897E0DD0-0x00000001897E0FE8
		internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) {} // 0x00000001897E0FE8-0x00000001897E13C0
		internal void AddColumnProperties(DataColumn col, XmlElement root) {} // 0x00000001897DD908-0x00000001897DDE60
		private string FindTargetNamespace(DataTable table) => default; // 0x00000001897E036C-0x00000001897E0470
		internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) => default; // 0x00000001897E13C0-0x00000001897E1C3C
		internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) => default; // 0x00000001897E985C-0x00000001897E98B8
		internal static string TranslateRule(System.Data.Rule rule) => default; // 0x00000001897E98B8-0x00000001897E9940
		internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) {} // 0x00000001897DECB0-0x00000001897DED4C
		internal XmlElement FindTypeNode(XmlElement node, string strType) => default; // 0x00000001897E0470-0x00000001897E0600
		internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) => default; // 0x00000001897E4408-0x00000001897E4424
		private bool HasMixedColumns(DataTable table) => default; // 0x00000001897E4424-0x00000001897E470C
		internal static bool AutoGenerated(DataColumn col) => default; // 0x00000001897DEFEC-0x00000001897DF4B0
		internal static bool AutoGenerated(DataRelation rel) => default; // 0x00000001897DEF18-0x00000001897DEFEC
		internal static bool AutoGenerated(UniqueConstraint unique) => default; // 0x00000001897DED4C-0x00000001897DEDF8
		private bool AutoGenerated(ForeignKeyConstraint fk) => default; // 0x00000001897DEDF8-0x00000001897DEE08
		internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) => default; // 0x00000001897DEE08-0x00000001897DEF18
		private bool IsAutoGenerated(object o) => default; // 0x00000001897E4854-0x00000001897E488C
		internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) => default; // 0x00000001897E219C-0x00000001897E4408
		private void SetMSDataAttribute(XmlElement root, System.Type type) {} // 0x00000001897E88BC-0x00000001897E8A60
	}

	internal sealed class NewDiffgramGen // TypeDefIndex: 50076
	{
		// Fields
		internal XmlDocument _doc; // 0x10
		internal DataSet _ds; // 0x18
		internal DataTable _dt; // 0x20
		internal XmlWriter _xmlw; // 0x28
		private bool _fBefore; // 0x30
		private bool _fErrors; // 0x31
		internal Hashtable _rowsOrder; // 0x38
		private ArrayList _tables; // 0x40
		private bool _writeHierarchy; // 0x48
	
		// Constructors
		public NewDiffgramGen() {} // Dummy constructor
		internal NewDiffgramGen(DataSet ds) {} // 0x00000001897D73BC-0x00000001897D74F0
		internal NewDiffgramGen(DataTable dt, bool writeHierarchy) {} // 0x00000001897D72AC-0x00000001897D73BC
	
		// Methods
		private void CreateTableHierarchy(DataTable dt) {} // 0x00000001897D5570-0x00000001897D589C
		private void DoAssignments(ArrayList tables) {} // 0x00000001897D589C-0x00000001897D5A84
		private bool EmptyData() => default; // 0x00000001897D5A84-0x00000001897D5B40
		internal void Save(XmlWriter xmlw) {} // 0x00000001897D72A0-0x00000001897D72AC
		internal void Save(XmlWriter xmlw, DataTable table) {} // 0x00000001897D6F20-0x00000001897D72A0
		private void GenerateTable(DataTable table) {} // 0x00000001897D6E4C-0x00000001897D6EC8
		private void GenerateTableErrors(DataTable table) {} // 0x00000001897D68FC-0x00000001897D6E4C
		private void GenerateRow(DataRow row) {} // 0x00000001897D6350-0x00000001897D68FC
		private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) {} // 0x00000001897D5B40-0x00000001897D6350
		internal static string QualifiedName(string prefix, string name) => default; // 0x00000001897D6EC8-0x00000001897D6F20
	}

	internal sealed class XmlDataTreeWriter // TypeDefIndex: 50077
	{
		// Fields
		private XmlWriter _xmlw; // 0x10
		private DataSet _ds; // 0x18
		private DataTable _dt; // 0x20
		private ArrayList _dTables; // 0x28
		private DataTable[] _topLevelTables; // 0x30
		private bool _fFromTable; // 0x38
		private bool _isDiffgram; // 0x39
		private Hashtable _rowsOrder; // 0x40
		private bool _writeHierarchy; // 0x48
	
		// Constructors
		public XmlDataTreeWriter() {} // Dummy constructor
		internal XmlDataTreeWriter(DataSet ds) {} // 0x00000001897DAF44-0x00000001897DB268
		internal XmlDataTreeWriter(DataTable dt, bool writeHierarchy) {} // 0x00000001897DADD4-0x00000001897DAF44
	
		// Methods
		private DataTable[] CreateToplevelTables() => default; // 0x00000001897D78B8-0x00000001897D7AE0
		private void CreateTablesHierarchy(DataTable dt) {} // 0x00000001897D758C-0x00000001897D78B8
		internal static bool RowHasErrors(DataRow row) => default; // 0x00000001897D7E88-0x00000001897D7F4C
		internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) {} // 0x00000001897D7F4C-0x00000001897D85BC
		internal void Save(XmlWriter xw, bool writeSchema) {} // 0x00000001897D85BC-0x00000001897D8EEC
		private ArrayList GetNestedChildRelations(DataRow row) => default; // 0x00000001897D7AE0-0x00000001897D7E00
		internal void XmlDataRowWriter(DataRow row, string encodedTableName) {} // 0x00000001897D8EEC-0x00000001897DADD4
		internal static bool PreserveSpace(object value) => default; // 0x00000001897D7E00-0x00000001897D7E88
	}

	internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 50078
	{
		// Fields
		private XmlWriter _xmltextWriter; // 0x18
	
		// Properties
		internal Stream BaseStream { get => default; } // 0x00000001897D54FC-0x00000001897D554C 
		public override WriteState WriteState { get => default; } // 0x00000001897D554C-0x00000001897D5570 
	
		// Constructors
		public DataTextWriter() {} // Dummy constructor
		private DataTextWriter(XmlWriter w) {} // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		internal static XmlWriter CreateWriter(XmlWriter xw) => default; // 0x00000001897D50EC-0x00000001897D514C
		public override void WriteStartDocument() {} // 0x00000001897D5410-0x00000001897D5434
		public override void WriteStartDocument(bool standalone) {} // 0x00000001897D5434-0x00000001897D545C
		public override void WriteEndDocument() {} // 0x000000018922E594-0x000000018922E5B8
		public override void WriteDocType(string name, string pubid, string sysid, string subset) {} // 0x00000001897D5294-0x00000001897D52D0
		public override void WriteStartElement(string prefix, string localName, string ns) {} // 0x00000001897D545C-0x00000001897D548C
		public override void WriteEndElement() {} // 0x00000001897D52F4-0x00000001897D5318
		public override void WriteFullEndElement() {} // 0x00000001897D533C-0x00000001897D5360
		public override void WriteStartAttribute(string prefix, string localName, string ns) {} // 0x00000001897D53E0-0x00000001897D5410
		public override void WriteEndAttribute() {} // 0x00000001897D52D0-0x00000001897D52F4
		public override void WriteCData(string text) {} // 0x00000001897D51F4-0x00000001897D5218
		public override void WriteComment(string text) {} // 0x00000001897D5270-0x00000001897D5294
		public override void WriteProcessingInstruction(string name, string text) {} // 0x00000001897D5360-0x00000001897D538C
		public override void WriteEntityRef(string name) {} // 0x00000001897D5318-0x00000001897D533C
		public override void WriteCharEntity(char ch) {} // 0x00000001897D5218-0x00000001897D5240
		public override void WriteWhitespace(string ws) {} // 0x00000001897D54D8-0x00000001897D54FC
		public override void WriteString(string text) {} // 0x00000001897D548C-0x00000001897D54B0
		public override void WriteSurrogateCharEntity(char lowChar, char highChar) {} // 0x00000001897D54B0-0x00000001897D54D8
		public override void WriteChars(char[] buffer, int index, int count) {} // 0x00000001897D5240-0x00000001897D5270
		public override void WriteRaw(char[] buffer, int index, int count) {} // 0x00000001897D538C-0x00000001897D53BC
		public override void WriteRaw(string data) {} // 0x00000001897D53BC-0x00000001897D53E0
		public override void WriteBase64(byte[] buffer, int index, int count) {} // 0x00000001897D5194-0x00000001897D51C4
		public override void WriteBinHex(byte[] buffer, int index, int count) {} // 0x00000001897D51C4-0x00000001897D51F4
		public override void Close() {} // 0x00000001897D50C8-0x00000001897D50EC
		public override void Flush() {} // 0x00000001897D514C-0x00000001897D5170
		public override string LookupPrefix(string ns) => default; // 0x00000001897D5170-0x00000001897D5194
	}

	internal sealed class DataTextReader : XmlReader // TypeDefIndex: 50079
	{
		// Fields
		private XmlReader _xmlreader; // 0x10
	
		// Properties
		public override XmlReaderSettings Settings { get => default; } // 0x00000001897D5040-0x00000001897D505C 
		public override XmlNodeType NodeType { get => default; } // 0x00000001897D4FB0-0x00000001897D4FD4 
		public override string Name { get => default; } // 0x00000001897D4F8C-0x00000001897D4FB0 
		public override string LocalName { get => default; } // 0x00000001893B57E4-0x00000001893B5808 
		public override string NamespaceURI { get => default; } // 0x00000001892EFBE8-0x00000001892EFC0C 
		public override string Prefix { get => default; } // 0x00000001897D4FD4-0x00000001897D4FF8 
		public override bool HasValue { get => default; } // 0x00000001897D4EFC-0x00000001897D4F20 
		public override string Value { get => default; } // 0x00000001897D505C-0x00000001897D5080 
		public override int Depth { get => default; } // 0x00000001897D4EB4-0x00000001897D4ED8 
		public override string BaseURI { get => default; } // 0x00000001897D4E48-0x00000001897D4E6C 
		public override bool IsEmptyElement { get => default; } // 0x00000001897D4F44-0x00000001897D4F68 
		public override bool IsDefault { get => default; } // 0x00000001897D4F20-0x00000001897D4F44 
		public override char QuoteChar { get => default; } // 0x00000001897D4FF8-0x00000001897D501C 
		public override XmlSpace XmlSpace { get => default; } // 0x00000001897D50A4-0x00000001897D50C8 
		public override string XmlLang { get => default; } // 0x00000001897D5080-0x00000001897D50A4 
		public override int AttributeCount { get => default; } // 0x00000001897D4E24-0x00000001897D4E48 
		public override bool EOF { get => default; } // 0x00000001897D4ED8-0x00000001897D4EFC 
		public override ReadState ReadState { get => default; } // 0x00000001897D501C-0x00000001897D5040 
		public override XmlNameTable NameTable { get => default; } // 0x00000001897D4F68-0x00000001897D4F8C 
		public override bool CanResolveEntity { get => default; } // 0x00000001897D4E90-0x00000001897D4EB4 
		public override bool CanReadValueChunk { get => default; } // 0x00000001897D4E6C-0x00000001897D4E90 
	
		// Constructors
		public DataTextReader() {} // Dummy constructor
		private DataTextReader(XmlReader input) {} // 0x00000001897D4DCC-0x00000001897D4E24
	
		// Methods
		internal static XmlReader CreateReader(XmlReader xr) => default; // 0x00000001897D4B70-0x00000001897D4BD0
		public override string GetAttribute(string name) => default; // 0x00000001897D4BF8-0x00000001897D4C1C
		public override string GetAttribute(string localName, string namespaceURI) => default; // 0x00000001897D4BD0-0x00000001897D4BF8
		public override string GetAttribute(int i) => default; // 0x00000001897D4C1C-0x00000001897D4C40
		public override bool MoveToAttribute(string name) => default; // 0x00000001897D4C64-0x00000001897D4C88
		public override void MoveToAttribute(int i) {} // 0x00000001897D4C88-0x00000001897D4CAC
		public override bool MoveToFirstAttribute() => default; // 0x00000001897D4CD0-0x00000001897D4CF4
		public override bool MoveToNextAttribute() => default; // 0x00000001897D4CF4-0x00000001897D4D18
		public override bool MoveToElement() => default; // 0x00000001897D4CAC-0x00000001897D4CD0
		public override bool ReadAttributeValue() => default; // 0x00000001897D4D18-0x00000001897D4D3C
		public override bool Read() => default; // 0x00000001897D4D60-0x00000001897D4D84
		public override void Close() {} // 0x00000001897D4B4C-0x00000001897D4B70
		public override void Skip() {} // 0x00000001897D4DA8-0x00000001897D4DCC
		public override string LookupNamespace(string prefix) => default; // 0x00000001897D4C40-0x00000001897D4C64
		public override void ResolveEntity() {} // 0x00000001897D4D84-0x00000001897D4DA8
		public override string ReadString() => default; // 0x00000001897D4D3C-0x00000001897D4D60
	}
}

namespace System.Data.Common
{
	internal static class ADP // TypeDefIndex: 50106
	{
		// Fields
		private static readonly System.Type s_stackOverflowType; // 0x00
		private static readonly System.Type s_outOfMemoryType; // 0x08
		private static readonly System.Type s_threadAbortType; // 0x10
		private static readonly System.Type s_nullReferenceType; // 0x18
		private static readonly System.Type s_accessViolationType; // 0x20
		private static readonly System.Type s_securityType; // 0x28
		internal static readonly string StrEmpty; // 0x30
		internal static readonly string[] AzureSqlServerEndpoints; // 0x38
		internal static readonly IntPtr PtrZero; // 0x40
		internal static readonly int PtrSize; // 0x48
	
		// Constructors
		static ADP() {} // 0x0000000189802778-0x0000000189802A84
	
		// Methods
		private static void TraceException(string trace, Exception e) {} // 0x0000000189802654-0x00000001898026D8
		internal static void TraceExceptionAsReturnValue(Exception e) {} // 0x00000001898025AC-0x0000000189802600
		internal static void TraceExceptionWithoutRethrow(Exception e) {} // 0x0000000189802600-0x0000000189802654
		internal static ArgumentException Argument(string error) => default; // 0x0000000189801E8C-0x0000000189801F10
		internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) => default; // 0x0000000189801D74-0x0000000189801DF8
		internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) => default; // 0x0000000189801DF8-0x0000000189801E8C
		internal static InvalidOperationException InvalidOperation(string error) => default; // 0x00000001898020F4-0x0000000189802178
		internal static NotSupportedException NotSupported(string error) => default; // 0x0000000189802528-0x00000001898025AC
		internal static bool IsCatchableExceptionType(Exception e) => default; // 0x0000000189802250-0x00000001898023D8
		internal static bool IsCatchableOrSecurityExceptionType(Exception e) => default; // 0x00000001898023D8-0x0000000189802528
		internal static ArgumentOutOfRangeException InvalidEnumerationValue(System.Type type, int value) => default; // 0x0000000189801F94-0x0000000189802070
		internal static Exception InvalidSeekOrigin(string parameterName) => default; // 0x00000001898021FC-0x0000000189802250
		internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) => default; // 0x0000000189801F10-0x0000000189801F94
		internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) => default; // 0x0000000189802070-0x00000001898020F4
		internal static ArgumentOutOfRangeException InvalidRule(System.Data.Rule value) => default; // 0x0000000189802178-0x00000001898021FC
		internal static Exception WrongType(System.Type got, System.Type expected) => default; // 0x00000001898026D8-0x0000000189802778
	}

	internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 50107
	{
		// Fields
		private BigInteger[] _values; // 0x50
	
		// Constructors
		public BigIntegerStorage() {} // Dummy constructor
		internal BigIntegerStorage(DataColumn column) {} // 0x0000000189803E50-0x0000000189803F40
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189802A84-0x0000000189802AB8
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189802BB8-0x0000000189802CB0
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189802AB8-0x0000000189802BB8
		internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) => default; // 0x0000000189803378-0x00000001898038F0
		internal static object ConvertFromBigInteger(BigInteger value, System.Type type, IFormatProvider formatProvider) => default; // 0x0000000189802CB0-0x00000001898032E4
		public override object ConvertValue(object value) => default; // 0x00000001898038F0-0x0000000189803978
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189803AE0-0x0000000189803B5C
		public override object Get(int record) => default; // 0x0000000189803B94-0x0000000189803C28
		public override void Set(int record, object value) {} // 0x0000000189803D6C-0x0000000189803E50
		public override void SetCapacity(int capacity) {} // 0x0000000189803C28-0x0000000189803CF0
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189803978-0x0000000189803A08
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898032E4-0x0000000189803378
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189803B5C-0x0000000189803B94
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189803A08-0x0000000189803AE0
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189803CF0-0x0000000189803D6C
	}

	internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 50108
	{
		// Fields
		private bool[] _values; // 0x50
	
		// Constructors
		public BooleanStorage() {} // Dummy constructor
		internal BooleanStorage(DataColumn column) {} // 0x000000018980494C-0x0000000189804A20
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189803F40-0x0000000189804220
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x00000001898042FC-0x00000001898043C4
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189804220-0x00000001898042FC
		public override object ConvertValue(object value) => default; // 0x0000000189804420-0x00000001898044D0
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189804614-0x0000000189804674
		public override object Get(int record) => default; // 0x00000001898046AC-0x000000018980472C
		public override void Set(int record, object value) {} // 0x0000000189804870-0x000000018980494C
		public override void SetCapacity(int capacity) {} // 0x000000018980472C-0x00000001898047F4
		public override object ConvertXmlToObject(string s) => default; // 0x00000001898044D0-0x0000000189804534
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898043C4-0x0000000189804420
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189804674-0x00000001898046AC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189804534-0x0000000189804614
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x00000001898047F4-0x0000000189804870
	}

	internal sealed class ByteStorage : DataStorage // TypeDefIndex: 50109
	{
		// Fields
		private byte[] _values; // 0x50
	
		// Constructors
		public ByteStorage() {} // Dummy constructor
		internal ByteStorage(DataColumn column) {} // 0x00000001898057D0-0x00000001898058A4
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189804A20-0x0000000189805120
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x00000001898051EC-0x0000000189805250
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189805120-0x00000001898051EC
		public override object ConvertValue(object value) => default; // 0x00000001898052AC-0x000000018980535C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189805498-0x00000001898054F8
		public override object Get(int record) => default; // 0x0000000189805530-0x00000001898055B0
		public override void Set(int record, object value) {} // 0x00000001898056F4-0x00000001898057D0
		public override void SetCapacity(int capacity) {} // 0x00000001898055B0-0x0000000189805678
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980535C-0x00000001898053C0
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189805250-0x00000001898052AC
		protected override object GetEmptyStorage(int recordCount) => default; // 0x00000001898054F8-0x0000000189805530
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x00000001898053C0-0x0000000189805498
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189805678-0x00000001898056F4
	}

	internal sealed class CharStorage : DataStorage // TypeDefIndex: 50110
	{
		// Fields
		private char[] _values; // 0x50
	
		// Constructors
		public CharStorage() {} // Dummy constructor
		internal CharStorage(DataColumn column) {} // 0x000000018980634C-0x0000000189806420
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x00000001898058A4-0x0000000189805BC4
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189805CA0-0x0000000189805D58
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189805BC4-0x0000000189805CA0
		public override object ConvertValue(object value) => default; // 0x0000000189805DB4-0x0000000189805E68
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189805FA4-0x0000000189806004
		public override object Get(int record) => default; // 0x000000018980603C-0x00000001898060CC
		public override void Set(int record, object value) {} // 0x0000000189806210-0x000000018980634C
		public override void SetCapacity(int capacity) {} // 0x00000001898060CC-0x0000000189806194
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189805E68-0x0000000189805ECC
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189805D58-0x0000000189805DB4
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189806004-0x000000018980603C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189805ECC-0x0000000189805FA4
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189806194-0x0000000189806210
	}

	internal enum StorageType // TypeDefIndex: 50111
	{
		Empty = 0,
		Object = 1,
		DBNull = 2,
		Boolean = 3,
		Char = 4,
		SByte = 5,
		Byte = 6,
		Int16 = 7,
		UInt16 = 8,
		Int32 = 9,
		UInt32 = 10,
		Int64 = 11,
		UInt64 = 12,
		Single = 13,
		Double = 14,
		Decimal = 15,
		DateTime = 16,
		TimeSpan = 17,
		String = 18,
		Guid = 19,
		ByteArray = 20,
		CharArray = 21,
		Type = 22,
		DateTimeOffset = 23,
		BigInteger = 24,
		Uri = 25,
		SqlBinary = 26,
		SqlBoolean = 27,
		SqlByte = 28,
		SqlBytes = 29,
		SqlChars = 30,
		SqlDateTime = 31,
		SqlDecimal = 32,
		SqlDouble = 33,
		SqlGuid = 34,
		SqlInt16 = 35,
		SqlInt32 = 36,
		SqlInt64 = 37,
		SqlMoney = 38,
		SqlSingle = 39,
		SqlString = 40
	}

	internal abstract class DataStorage // TypeDefIndex: 50112
	{
		// Fields
		private static readonly System.Type[] s_storageClassType; // 0x00
		internal readonly DataColumn _column; // 0x10
		internal readonly DataTable _table; // 0x18
		internal readonly System.Type _dataType; // 0x20
		internal readonly StorageType _storageTypeCode; // 0x28
		private BitArray _dbNullBits; // 0x30
		private readonly object _defaultValue; // 0x38
		internal readonly object _nullValue; // 0x40
		internal readonly bool _isCloneable; // 0x48
		internal readonly bool _isCustomDefinedType; // 0x49
		internal readonly bool _isStringType; // 0x4A
		internal readonly bool _isValueType; // 0x4B
		private static readonly System.Func<System.Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x08
		private static readonly ConcurrentDictionary<System.Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10
	
		// Properties
		internal DataSetDateTime DateTimeMode { get; } // 0x00000001860927C0-0x00000001860927DC 
		internal IFormatProvider FormatProvider { get; } // 0x0000000189808664-0x0000000189808684 
	
		// Constructors
		protected DataStorage() {} // Dummy constructor
		protected DataStorage(DataColumn column, System.Type type, object defaultValue, StorageType storageType) {} // 0x00000001898085CC-0x0000000189808664
		protected DataStorage(DataColumn column, System.Type type, object defaultValue, object nullValue, StorageType storageType) {} // 0x0000000189808488-0x00000001898084B8
		protected DataStorage(DataColumn column, System.Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) {} // 0x00000001898084B8-0x00000001898085CC
		static DataStorage() {} // 0x0000000189807A54-0x0000000189808488
	
		// Methods
		public virtual object Aggregate(int[] recordNos, AggregateType kind) => default; // 0x00000001898064C4-0x00000001898064D8
		public object AggregateCount(int[] recordNos) => default; // 0x0000000189806420-0x00000001898064C4
		protected int CompareBits(int recordNo1, int recordNo2) => default; // 0x00000001898064D8-0x000000018980653C
		public abstract int Compare(int recordNo1, int recordNo2);
		public abstract int CompareValueTo(int recordNo1, object value);
		public virtual object ConvertValue(object value) => default; // 0x0000000183D51810-0x0000000183D51820
		protected void CopyBits(int srcRecordNo, int dstRecordNo) {} // 0x00000001898065AC-0x00000001898065F0
		public abstract void Copy(int recordNo1, int recordNo2);
		public abstract object Get(int recordNo);
		protected object GetBits(int recordNo) => default; // 0x0000000189807104-0x0000000189807138
		public virtual int GetStringLength(int record) => default; // 0x0000000183D56910-0x0000000183D56920
		protected bool HasValue(int recordNo) => default; // 0x00000001898073D4-0x00000001898073F8
		public virtual bool IsNull(int recordNo) => default; // 0x0000000189807748-0x0000000189807768
		public abstract void Set(int recordNo, object value);
		protected void SetNullBit(int recordNo, bool flag) {} // 0x00000001898079E8-0x0000000189807A08
		public virtual void SetCapacity(int capacity) {} // 0x0000000189807958-0x00000001898079E8
		public abstract object ConvertXmlToObject(string s);
		public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) => default; // 0x0000000189806578-0x00000001898065AC
		public abstract string ConvertObjectToXml(object value);
		public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) {} // 0x000000018980653C-0x0000000189806578
		public static DataStorage CreateStorage(DataColumn column, System.Type dataType, StorageType typeCode) => default; // 0x0000000189806650-0x000000018980700C
		internal static StorageType GetStorageType(System.Type dataType) => default; // 0x00000001898071A4-0x000000018980728C
		internal static System.Type GetTypeStorage(StorageType storageType) => default; // 0x000000018980728C-0x00000001898072F0
		internal static bool IsTypeCustomType(System.Type type) => default; // 0x000000018980790C-0x0000000189807958
		internal static bool IsTypeCustomType(StorageType typeCode) => default; // 0x00000001898078FC-0x000000018980790C
		internal static bool IsSqlType(StorageType storageType) => default; // 0x00000001898078F4-0x00000001898078FC
		public static bool IsSqlType(System.Type dataType) => default; // 0x000000018980782C-0x00000001898078F4
		private static bool DetermineIfValueType(StorageType typeCode, System.Type dataType) => default; // 0x000000018980700C-0x0000000189807104
		internal static void ImplementsInterfaces(StorageType typeCode, System.Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) {
			sqlType = default;
			nullable = default;
			xmlSerializable = default;
			changeTracking = default;
			revertibleChangeTracking = default;
		} // 0x0000000189807494-0x00000001898075E0
		private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(System.Type dataType) => default; // 0x00000001898075E0-0x0000000189807748
		internal static bool ImplementsINullableValue(StorageType typeCode, System.Type dataType) => default; // 0x00000001898073F8-0x0000000189807494
		public static bool IsObjectNull(object value) => default; // 0x0000000189807768-0x00000001898077E0
		public static bool IsObjectSqlNull(object value) => default; // 0x00000001898077E0-0x000000018980782C
		internal object GetEmptyStorageInternal(int recordCount) => default; // 0x0000000189807138-0x000000018980714C
		internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) {} // 0x00000001898065F0-0x0000000189806650
		internal void SetStorageInternal(object store, BitArray nullbits) {} // 0x0000000189807A08-0x0000000189807A54
		protected abstract object GetEmptyStorage(int recordCount);
		protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);
		protected abstract void SetStorage(object store, BitArray nullbits);
		protected void SetNullStorage(BitArray nullbits) {} // 0x0000000184270470-0x0000000184270480
		internal static System.Type GetType(string value) => default; // 0x00000001898072F0-0x00000001898073D4
		internal static string GetQualifiedName(System.Type type) => default; // 0x000000018980714C-0x00000001898071A4
	}

	internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 50113
	{
		// Fields
		private static readonly DateTimeOffset s_defaultValue; // 0x00
		private DateTimeOffset[] _values; // 0x50
	
		// Constructors
		public DateTimeOffsetStorage() {} // Dummy constructor
		internal DateTimeOffsetStorage(DataColumn column) {} // 0x00000001898093DC-0x00000001898094DC
		static DateTimeOffsetStorage() {} // 0x000000018980937C-0x00000001898093DC
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189808684-0x0000000189808AB8
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189808C04-0x0000000189808D90
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189808AB8-0x0000000189808C04
		public override object ConvertValue(object value) => default; // 0x0000000189808DF8-0x0000000189808E70
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189808FB8-0x0000000189809034
		public override object Get(int record) => default; // 0x000000018980906C-0x0000000189809154
		public override void Set(int record, object value) {} // 0x0000000189809298-0x000000018980937C
		public override void SetCapacity(int capacity) {} // 0x0000000189809154-0x000000018980921C
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189808E70-0x0000000189808EE0
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189808D90-0x0000000189808DF8
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189809034-0x000000018980906C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189808EE0-0x0000000189808FB8
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980921C-0x0000000189809298
	}

	internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 50114
	{
		// Fields
		private static readonly System.DateTime s_defaultValue; // 0x00
		private System.DateTime[] _values; // 0x50
	
		// Constructors
		public DateTimeStorage() {} // Dummy constructor
		internal DateTimeStorage(DataColumn column) {} // 0x000000018980A4C8-0x000000018980A5C4
		static DateTimeStorage() {} // 0x000000018980A468-0x000000018980A4C8
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x00000001898094DC-0x00000001898098D0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x00000001898099E4-0x0000000189809B24
		public override int CompareValueTo(int recordNo, object value) => default; // 0x00000001898098D0-0x00000001898099E4
		public override object ConvertValue(object value) => default; // 0x0000000189809BBC-0x0000000189809C70
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189809E20-0x0000000189809E94
		public override object Get(int record) => default; // 0x0000000189809ECC-0x0000000189809FA4
		public override void Set(int record, object value) {} // 0x000000018980A20C-0x000000018980A468
		public override void SetCapacity(int capacity) {} // 0x0000000189809FA4-0x000000018980A06C
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189809C70-0x0000000189809D00
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189809B24-0x0000000189809BBC
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189809E94-0x0000000189809ECC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189809D00-0x0000000189809E20
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980A06C-0x000000018980A20C
	}

	internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 50115
	{
		// Fields
		private static readonly decimal s_defaultValue; // 0x00
		private decimal[] _values; // 0x50
	
		// Constructors
		public DecimalStorage() {} // Dummy constructor
		internal DecimalStorage(DataColumn column) {} // 0x000000018980B74C-0x000000018980B840
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018980A5C4-0x000000018980AE98
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018980AFD8-0x000000018980B14C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018980AE98-0x000000018980AFD8
		public override object ConvertValue(object value) => default; // 0x000000018980B1B4-0x000000018980B270
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018980B3B8-0x000000018980B434
		public override object Get(int record) => default; // 0x000000018980B46C-0x000000018980B4F4
		public override void Set(int record, object value) {} // 0x000000018980B638-0x000000018980B74C
		public override void SetCapacity(int capacity) {} // 0x000000018980B4F4-0x000000018980B5BC
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980B270-0x000000018980B2E0
		public override string ConvertObjectToXml(object value) => default; // 0x000000018980B14C-0x000000018980B1B4
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018980B434-0x000000018980B46C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018980B2E0-0x000000018980B3B8
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980B5BC-0x000000018980B638
	}

	internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 50116
	{
		// Fields
		private double[] _values; // 0x50
	
		// Constructors
		public DoubleStorage() {} // Dummy constructor
		internal DoubleStorage(DataColumn column) {} // 0x000000018980C564-0x000000018980C63C
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018980B840-0x000000018980BE70
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018980BF48-0x000000018980BFD0
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018980BE70-0x000000018980BF48
		public override object ConvertValue(object value) => default; // 0x000000018980C02C-0x000000018980C0E0
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018980C21C-0x000000018980C27C
		public override object Get(int record) => default; // 0x000000018980C2B4-0x000000018980C340
		public override void Set(int record, object value) {} // 0x000000018980C484-0x000000018980C564
		public override void SetCapacity(int capacity) {} // 0x000000018980C340-0x000000018980C408
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980C0E0-0x000000018980C144
		public override string ConvertObjectToXml(object value) => default; // 0x000000018980BFD0-0x000000018980C02C
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018980C27C-0x000000018980C2B4
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018980C144-0x000000018980C21C
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980C408-0x000000018980C484
	}

	internal sealed class Int16Storage : DataStorage // TypeDefIndex: 50117
	{
		// Fields
		private short[] _values; // 0x50
	
		// Constructors
		public Int16Storage() {} // Dummy constructor
		internal Int16Storage(DataColumn column) {} // 0x000000018980D400-0x000000018980D4D4
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018980C63C-0x000000018980CD94
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018980CE5C-0x000000018980CEC8
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018980CD94-0x000000018980CE5C
		public override object ConvertValue(object value) => default; // 0x000000018980CF24-0x000000018980CFD8
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189805FA4-0x0000000189806004
		public override object Get(int record) => default; // 0x000000018980D14C-0x000000018980D1DC
		public override void Set(int record, object value) {} // 0x000000018980D320-0x000000018980D400
		public override void SetCapacity(int capacity) {} // 0x000000018980D1DC-0x000000018980D2A4
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980CFD8-0x000000018980D03C
		public override string ConvertObjectToXml(object value) => default; // 0x000000018980CEC8-0x000000018980CF24
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018980D114-0x000000018980D14C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018980D03C-0x000000018980D114
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980D2A4-0x000000018980D320
	}

	internal sealed class Int32Storage : DataStorage // TypeDefIndex: 50118
	{
		// Fields
		private int[] _values; // 0x50
	
		// Constructors
		public Int32Storage() {} // Dummy constructor
		internal Int32Storage(DataColumn column) {} // 0x000000018980E2C0-0x000000018980E394
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018980D4D4-0x000000018980DC00
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018980DCC8-0x000000018980DD40
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018980DC00-0x000000018980DCC8
		public override object ConvertValue(object value) => default; // 0x000000018980DD9C-0x000000018980DE4C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018980DF88-0x000000018980DFE8
		public override object Get(int record) => default; // 0x000000018980E020-0x000000018980E0A0
		public override void Set(int record, object value) {} // 0x000000018980E1E4-0x000000018980E2C0
		public override void SetCapacity(int capacity) {} // 0x000000018980E0A0-0x000000018980E168
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980DE4C-0x000000018980DEB0
		public override string ConvertObjectToXml(object value) => default; // 0x000000018980DD40-0x000000018980DD9C
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018980DFE8-0x000000018980E020
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018980DEB0-0x000000018980DF88
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980E168-0x000000018980E1E4
	}

	internal sealed class Int64Storage : DataStorage // TypeDefIndex: 50119
	{
		// Fields
		private long[] _values; // 0x50
	
		// Constructors
		public Int64Storage() {} // Dummy constructor
		internal Int64Storage(DataColumn column) {} // 0x000000018980F184-0x000000018980F258
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018980E394-0x000000018980EAB0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018980EB7C-0x000000018980EBF8
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018980EAB0-0x000000018980EB7C
		public override object ConvertValue(object value) => default; // 0x000000018980EC54-0x000000018980ED08
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018980EE44-0x000000018980EEA4
		public override object Get(int record) => default; // 0x000000018980EEDC-0x000000018980EF60
		public override void Set(int record, object value) {} // 0x000000018980F0A4-0x000000018980F184
		public override void SetCapacity(int capacity) {} // 0x000000018980EF60-0x000000018980F028
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980ED08-0x000000018980ED6C
		public override string ConvertObjectToXml(object value) => default; // 0x000000018980EBF8-0x000000018980EC54
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018980EEA4-0x000000018980EEDC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018980ED6C-0x000000018980EE44
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018980F028-0x000000018980F0A4
	}

	internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 50122
	{
		// Fields
		private static readonly object s_defaultValue; // 0x00
		private object[] _values; // 0x50
		private readonly bool _implementsIXmlSerializable; // 0x58
		private static readonly object s_tempAssemblyCacheLock; // 0x08
		private static Dictionary<KeyValuePair<System.Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
		private static readonly XmlSerializerFactory s_serializerFactory; // 0x18
	
		// Nested types
		private enum Families // TypeDefIndex: 50120
		{
			DATETIME = 0,
			NUMBER = 1,
			STRING = 2,
			BOOLEAN = 3,
			ARRAY = 4
		}
	
		private class TempAssemblyComparer : IEqualityComparer<KeyValuePair<System.Type, XmlRootAttribute>> // TypeDefIndex: 50121
		{
			// Fields
			internal static readonly IEqualityComparer<KeyValuePair<System.Type, XmlRootAttribute>> s_default; // 0x00
	
			// Constructors
			private TempAssemblyComparer() {} // 0x000000018350B670-0x000000018350B680
			static TempAssemblyComparer() {} // 0x0000000189819E90-0x0000000189819F60
	
			// Methods
			public bool Equals(KeyValuePair<System.Type, XmlRootAttribute> x, KeyValuePair<System.Type, XmlRootAttribute> y) => default; // 0x0000000189819CCC-0x0000000189819E10
			public int GetHashCode(KeyValuePair<System.Type, XmlRootAttribute> obj) => default; // 0x0000000189819E10-0x0000000189819E90
		}
	
		// Constructors
		public ObjectStorage() {} // Dummy constructor
		internal ObjectStorage(DataColumn column, System.Type type) {} // 0x0000000189811E1C-0x0000000189811F88
		static ObjectStorage() {} // 0x0000000189811D40-0x0000000189811E1C
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018980F258-0x000000018980F28C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018980F89C-0x000000018980FA0C
		public override int CompareValueTo(int recordNo1, object value) => default; // 0x000000018980F3E8-0x000000018980F520
		private int CompareTo(object valueNo1, object valueNo2) => default; // 0x000000018980F28C-0x000000018980F3E8
		private int CompareWithFamilies(object valueNo1, object valueNo2) => default; // 0x000000018980F520-0x000000018980F89C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x00000001898109D0-0x0000000189810A2C
		public override object Get(int recordNo) => default; // 0x0000000189811300-0x0000000189811338
		private Families GetFamily(System.Type dataType) => default; // 0x0000000189810A64-0x0000000189810B74
		public override bool IsNull(int record) => default; // 0x0000000189811338-0x0000000189811368
		public override void Set(int recordNo, object value) {} // 0x0000000189811590-0x0000000189811C34
		public override void SetCapacity(int capacity) {} // 0x0000000189811368-0x0000000189811420
		public override object ConvertXmlToObject(string s) => default; // 0x000000018980FF40-0x000000018981034C
		public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) => default; // 0x000000018981034C-0x000000018981082C
		public override string ConvertObjectToXml(object value) => default; // 0x000000018980FAE4-0x000000018980FF40
		public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) {} // 0x000000018980FA0C-0x000000018980FAE4
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189810A2C-0x0000000189810A64
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981082C-0x00000001898109D0
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189811420-0x0000000189811590
		internal static void VerifyIDynamicMetaObjectProvider(System.Type type) {} // 0x0000000189811C34-0x0000000189811D40
		internal static XmlSerializer GetXmlSerializer(System.Type type) => default; // 0x0000000189810B74-0x0000000189810BDC
		internal static XmlSerializer GetXmlSerializer(System.Type type, XmlRootAttribute attribute) => default; // 0x0000000189810BDC-0x0000000189811300
	}

	internal sealed class SByteStorage : DataStorage // TypeDefIndex: 50123
	{
		// Fields
		private sbyte[] _values; // 0x50
	
		// Constructors
		public SByteStorage() {} // Dummy constructor
		public SByteStorage(DataColumn column) {} // 0x0000000189812CE0-0x0000000189812DB4
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189811F88-0x0000000189812690
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018981275C-0x00000001898127C0
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189812690-0x000000018981275C
		public override object ConvertValue(object value) => default; // 0x000000018981281C-0x00000001898128CC
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189805498-0x00000001898054F8
		public override object Get(int record) => default; // 0x0000000189812A40-0x0000000189812AC0
		public override void Set(int record, object value) {} // 0x0000000189812C04-0x0000000189812CE0
		public override void SetCapacity(int capacity) {} // 0x0000000189812AC0-0x0000000189812B88
		public override object ConvertXmlToObject(string s) => default; // 0x00000001898128CC-0x0000000189812930
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898127C0-0x000000018981281C
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189812A08-0x0000000189812A40
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189812930-0x0000000189812A08
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189812B88-0x0000000189812C04
	}

	internal static class SqlConvert // TypeDefIndex: 50124
	{
		// Methods
		public static SqlByte ConvertToSqlByte(object value) => default; // 0x000000018981786C-0x00000001898179D8
		public static SqlInt16 ConvertToSqlInt16(object value) => default; // 0x00000001898189AC-0x0000000189818B94
		public static SqlInt32 ConvertToSqlInt32(object value) => default; // 0x0000000189818B94-0x0000000189818E3C
		public static SqlInt64 ConvertToSqlInt64(object value) => default; // 0x0000000189818E3C-0x00000001898191E4
		public static SqlDouble ConvertToSqlDouble(object value) => default; // 0x00000001898182A4-0x000000018981883C
		public static SqlDecimal ConvertToSqlDecimal(object value) => default; // 0x0000000189817DA0-0x00000001898182A4
		public static SqlSingle ConvertToSqlSingle(object value) => default; // 0x000000018981965C-0x0000000189819B3C
		public static SqlMoney ConvertToSqlMoney(object value) => default; // 0x00000001898191E4-0x000000018981965C
		public static SqlDateTime ConvertToSqlDateTime(object value) => default; // 0x0000000189817C10-0x0000000189817DA0
		public static SqlBoolean ConvertToSqlBoolean(object value) => default; // 0x000000018981770C-0x000000018981786C
		public static SqlGuid ConvertToSqlGuid(object value) => default; // 0x000000018981883C-0x00000001898189AC
		public static SqlBinary ConvertToSqlBinary(object value) => default; // 0x00000001898175A8-0x000000018981770C
		public static SqlString ConvertToSqlString(object value) => default; // 0x0000000189819B3C-0x0000000189819CCC
		public static SqlChars ConvertToSqlChars(object value) => default; // 0x0000000189817AF4-0x0000000189817C10
		public static SqlBytes ConvertToSqlBytes(object value) => default; // 0x00000001898179D8-0x0000000189817AF4
		public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) => default; // 0x0000000189817538-0x00000001898175A8
		public static object ChangeTypeForDefaultValue(object value, System.Type type, IFormatProvider formatProvider) => default; // 0x0000000189815D24-0x0000000189815E98
		public static object ChangeType2(object value, StorageType stype, System.Type type, IFormatProvider formatProvider) => default; // 0x0000000189814DE8-0x0000000189815D24
		public static object ChangeTypeForXML(object value, System.Type type) => default; // 0x0000000189815E98-0x0000000189817538
	}

	internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 50125
	{
		// Fields
		private SqlBinary[] _values; // 0x50
	
		// Constructors
		public SqlBinaryStorage() {} // Dummy constructor
		public SqlBinaryStorage(DataColumn column) {} // 0x00000001898137F4-0x0000000189813904
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189812DB4-0x0000000189812FB0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189813040-0x00000001898130D8
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189812FB0-0x0000000189813040
		public override object ConvertValue(object value) => default; // 0x0000000189813260-0x00000001898132C4
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189813540-0x0000000189813588
		public override object Get(int record) => default; // 0x00000001898135C0-0x0000000189813630
		public override bool IsNull(int record) => default; // 0x0000000189813630-0x0000000189813698
		public override void Set(int record, object value) {} // 0x00000001898137B4-0x00000001898137F4
		public override void SetCapacity(int capacity) {} // 0x0000000189813698-0x0000000189813750
		public override object ConvertXmlToObject(string s) => default; // 0x00000001898132C4-0x0000000189813478
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898130D8-0x0000000189813260
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189813588-0x00000001898135C0
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189813478-0x0000000189813540
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189813750-0x00000001898137B4
	}

	internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 50126
	{
		// Fields
		private SqlByte[] _values; // 0x50
	
		// Constructors
		public SqlByteStorage() {} // Dummy constructor
		public SqlByteStorage(DataColumn column) {} // 0x0000000189814CD4-0x0000000189814DE8
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189813904-0x0000000189814478
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189814508-0x00000001898145A0
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189814478-0x0000000189814508
		public override object ConvertValue(object value) => default; // 0x0000000189814728-0x000000018981478C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189814A18-0x0000000189814A64
		public override object Get(int record) => default; // 0x0000000189814A9C-0x0000000189814B0C
		public override bool IsNull(int record) => default; // 0x0000000189814B0C-0x0000000189814B74
		public override void Set(int record, object value) {} // 0x0000000189814C90-0x0000000189814CD4
		public override void SetCapacity(int capacity) {} // 0x0000000189814B74-0x0000000189814C2C
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981478C-0x0000000189814940
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898145A0-0x0000000189814728
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189814A64-0x0000000189814A9C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189814940-0x0000000189814A18
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189814C2C-0x0000000189814C90
	}

	internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 50127
	{
		// Fields
		private SqlBytes[] _values; // 0x50
	
		// Constructors
		public SqlBytesStorage() {} // Dummy constructor
		public SqlBytesStorage(DataColumn column) {} // 0x000000018981C324-0x000000018981C3F8
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018981BA68-0x000000018981BC3C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000181002730-0x0000000181002740
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000181002730-0x0000000181002740
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018981C074-0x000000018981C0B0
		public override object Get(int record) => default; // 0x000000018981C0E8-0x000000018981C114
		public override bool IsNull(int record) => default; // 0x000000018981C114-0x000000018981C14C
		public override void Set(int record, object value) {} // 0x000000018981C268-0x000000018981C324
		public override void SetCapacity(int capacity) {} // 0x000000018981C14C-0x000000018981C204
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981BDC4-0x000000018981BF98
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981BC3C-0x000000018981BDC4
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018981C0B0-0x000000018981C0E8
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981BF98-0x000000018981C074
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018981C204-0x000000018981C268
	}

	internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 50128
	{
		// Fields
		private SqlChars[] _values; // 0x50
	
		// Constructors
		public SqlCharsStorage() {} // Dummy constructor
		public SqlCharsStorage(DataColumn column) {} // 0x000000018981CC30-0x000000018981CD04
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018981C3F8-0x000000018981C5CC
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000181002730-0x0000000181002740
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000181002730-0x0000000181002740
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018981C074-0x000000018981C0B0
		public override object Get(int record) => default; // 0x000000018981C0E8-0x000000018981C114
		public override bool IsNull(int record) => default; // 0x000000018981C114-0x000000018981C14C
		public override void Set(int record, object value) {} // 0x000000018981CB74-0x000000018981CC30
		public override void SetCapacity(int capacity) {} // 0x000000018981CA58-0x000000018981CB10
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981C754-0x000000018981C944
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981C5CC-0x000000018981C754
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018981CA20-0x000000018981CA58
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981C944-0x000000018981CA20
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018981CB10-0x000000018981CB74
	}

	internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 50129
	{
		// Fields
		private SqlDateTime[] _values; // 0x50
	
		// Constructors
		public SqlDateTimeStorage() {} // Dummy constructor
		public SqlDateTimeStorage(DataColumn column) {} // 0x000000018981DAC0-0x000000018981DBFC
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018981CD04-0x000000018981D1DC
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018981D284-0x000000018981D32C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018981D1DC-0x000000018981D284
		public override object ConvertValue(object value) => default; // 0x000000018981D4B4-0x000000018981D528
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018981D7D8-0x000000018981D834
		public override object Get(int record) => default; // 0x000000018981D86C-0x000000018981D8E4
		public override bool IsNull(int record) => default; // 0x000000018981D8E4-0x000000018981D948
		public override void Set(int record, object value) {} // 0x000000018981DA64-0x000000018981DAC0
		public override void SetCapacity(int capacity) {} // 0x000000018981D948-0x000000018981DA00
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981D528-0x000000018981D6F8
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981D32C-0x000000018981D4B4
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018981D834-0x000000018981D86C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981D6F8-0x000000018981D7D8
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018981DA00-0x000000018981DA64
	}

	internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 50130
	{
		// Fields
		private SqlDecimal[] _values; // 0x50
	
		// Constructors
		public SqlDecimalStorage() {} // Dummy constructor
		public SqlDecimalStorage(DataColumn column) {} // 0x000000018981F0C4-0x000000018981F1FC
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018981DBFC-0x000000018981E7E4
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018981E888-0x000000018981E930
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018981E7E4-0x000000018981E888
		public override object ConvertValue(object value) => default; // 0x000000018981EAB8-0x000000018981EB2C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018981EDD8-0x000000018981EE34
		public override object Get(int record) => default; // 0x000000018981EE6C-0x000000018981EEE4
		public override bool IsNull(int record) => default; // 0x000000018981EEE4-0x000000018981EF4C
		public override void Set(int record, object value) {} // 0x000000018981F068-0x000000018981F0C4
		public override void SetCapacity(int capacity) {} // 0x000000018981EF4C-0x000000018981F004
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981EB2C-0x000000018981ECF0
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981E930-0x000000018981EAB8
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018981EE34-0x000000018981EE6C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981ECF0-0x000000018981EDD8
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018981F004-0x000000018981F068
	}

	internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 50131
	{
		// Fields
		private SqlDouble[] _values; // 0x50
	
		// Constructors
		public SqlDoubleStorage() {} // Dummy constructor
		public SqlDoubleStorage(DataColumn column) {} // 0x0000000189820580-0x00000001898206A0
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018981F1FC-0x000000018981FCE4
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018981FD80-0x000000018981FE20
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018981FCE4-0x000000018981FD80
		public override object ConvertValue(object value) => default; // 0x000000018981FFA8-0x0000000189820014
		public override void Copy(int recordNo1, int recordNo2) {} // 0x00000001898202B0-0x0000000189820304
		public override object Get(int record) => default; // 0x000000018982033C-0x00000001898203AC
		public override bool IsNull(int record) => default; // 0x00000001898203AC-0x0000000189820410
		public override void Set(int record, object value) {} // 0x000000018982052C-0x0000000189820580
		public override void SetCapacity(int capacity) {} // 0x0000000189820410-0x00000001898204C8
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189820014-0x00000001898201D8
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981FE20-0x000000018981FFA8
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189820304-0x000000018982033C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x00000001898201D8-0x00000001898202B0
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x00000001898204C8-0x000000018982052C
	}

	internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 50132
	{
		// Fields
		private SqlGuid[] _values; // 0x50
	
		// Constructors
		public SqlGuidStorage() {} // Dummy constructor
		public SqlGuidStorage(DataColumn column) {} // 0x0000000189821098-0x00000001898211A8
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x00000001898206A0-0x000000018982089C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018982092C-0x00000001898209C4
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018982089C-0x000000018982092C
		public override object ConvertValue(object value) => default; // 0x0000000189820B4C-0x0000000189820BB0
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189813540-0x0000000189813588
		public override object Get(int record) => default; // 0x0000000189820E64-0x0000000189820ED4
		public override bool IsNull(int record) => default; // 0x0000000189820ED4-0x0000000189820F3C
		public override void Set(int record, object value) {} // 0x0000000189821058-0x0000000189821098
		public override void SetCapacity(int capacity) {} // 0x0000000189820F3C-0x0000000189820FF4
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189820BB0-0x0000000189820D64
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898209C4-0x0000000189820B4C
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189820E2C-0x0000000189820E64
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189820D64-0x0000000189820E2C
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189820FF4-0x0000000189821058
	}

	internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 50133
	{
		// Fields
		private SqlInt16[] _values; // 0x50
	
		// Constructors
		public SqlInt16Storage() {} // Dummy constructor
		public SqlInt16Storage(DataColumn column) {} // 0x000000018982255C-0x000000018982266C
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x00000001898211A8-0x0000000189821D0C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189821D9C-0x0000000189821E34
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189821D0C-0x0000000189821D9C
		public override object ConvertValue(object value) => default; // 0x0000000189821FBC-0x0000000189822020
		public override void Copy(int recordNo1, int recordNo2) {} // 0x00000001898222A8-0x00000001898222F4
		public override object Get(int record) => default; // 0x000000018982232C-0x0000000189822398
		public override bool IsNull(int record) => default; // 0x0000000189822398-0x0000000189822400
		public override void Set(int record, object value) {} // 0x000000018982251C-0x000000018982255C
		public override void SetCapacity(int capacity) {} // 0x0000000189822400-0x00000001898224B8
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189822020-0x00000001898221D4
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189821E34-0x0000000189821FBC
		protected override object GetEmptyStorage(int recordCount) => default; // 0x00000001898222F4-0x000000018982232C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x00000001898221D4-0x00000001898222A8
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x00000001898224B8-0x000000018982251C
	}

	internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 50134
	{
		// Fields
		private SqlInt32[] _values; // 0x50
	
		// Constructors
		public SqlInt32Storage() {} // Dummy constructor
		public SqlInt32Storage(DataColumn column) {} // 0x0000000189823A0C-0x0000000189823B1C
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018982266C-0x00000001898231B0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189823240-0x00000001898232D8
		public override int CompareValueTo(int recordNo, object value) => default; // 0x00000001898231B0-0x0000000189823240
		public override object ConvertValue(object value) => default; // 0x0000000189823460-0x00000001898234C4
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189823750-0x000000018982379C
		public override object Get(int record) => default; // 0x00000001898237D4-0x0000000189823844
		public override bool IsNull(int record) => default; // 0x0000000189823844-0x00000001898238AC
		public override void Set(int record, object value) {} // 0x00000001898239C8-0x0000000189823A0C
		public override void SetCapacity(int capacity) {} // 0x00000001898238AC-0x0000000189823964
		public override object ConvertXmlToObject(string s) => default; // 0x00000001898234C4-0x0000000189823678
		public override string ConvertObjectToXml(object value) => default; // 0x00000001898232D8-0x0000000189823460
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018982379C-0x00000001898237D4
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189823678-0x0000000189823750
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189823964-0x00000001898239C8
	}

	internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 50135
	{
		// Fields
		private SqlInt64[] _values; // 0x50
	
		// Constructors
		public SqlInt64Storage() {} // Dummy constructor
		public SqlInt64Storage(DataColumn column) {} // 0x0000000189824F38-0x0000000189825058
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189823B1C-0x00000001898246F0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018982478C-0x000000018982482C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x00000001898246F0-0x000000018982478C
		public override object ConvertValue(object value) => default; // 0x00000001898249B4-0x0000000189824A20
		public override void Copy(int recordNo1, int recordNo2) {} // 0x00000001898202B0-0x0000000189820304
		public override object Get(int record) => default; // 0x0000000189824CF4-0x0000000189824D64
		public override bool IsNull(int record) => default; // 0x0000000189824D64-0x0000000189824DC8
		public override void Set(int record, object value) {} // 0x0000000189824EE4-0x0000000189824F38
		public override void SetCapacity(int capacity) {} // 0x0000000189824DC8-0x0000000189824E80
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189824A20-0x0000000189824BE4
		public override string ConvertObjectToXml(object value) => default; // 0x000000018982482C-0x00000001898249B4
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189824CBC-0x0000000189824CF4
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189824BE4-0x0000000189824CBC
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189824E80-0x0000000189824EE4
	}

	internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 50136
	{
		// Fields
		private SqlMoney[] _values; // 0x50
	
		// Constructors
		public SqlMoneyStorage() {} // Dummy constructor
		public SqlMoneyStorage(DataColumn column) {} // 0x00000001898264BC-0x00000001898265DC
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189825058-0x0000000189825C74
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189825D10-0x0000000189825DB0
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189825C74-0x0000000189825D10
		public override object ConvertValue(object value) => default; // 0x0000000189825F38-0x0000000189825FA4
		public override void Copy(int recordNo1, int recordNo2) {} // 0x00000001898202B0-0x0000000189820304
		public override object Get(int record) => default; // 0x0000000189826278-0x00000001898262E8
		public override bool IsNull(int record) => default; // 0x00000001898262E8-0x000000018982634C
		public override void Set(int record, object value) {} // 0x0000000189826468-0x00000001898264BC
		public override void SetCapacity(int capacity) {} // 0x000000018982634C-0x0000000189826404
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189825FA4-0x0000000189826168
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189825DB0-0x0000000189825F38
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189826240-0x0000000189826278
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189826168-0x0000000189826240
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189826404-0x0000000189826468
	}

	internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 50137
	{
		// Fields
		private SqlSingle[] _values; // 0x50
	
		// Constructors
		public SqlSingleStorage() {} // Dummy constructor
		public SqlSingleStorage(DataColumn column) {} // 0x00000001898278F4-0x0000000189827A04
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x00000001898265DC-0x00000001898270E4
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189827174-0x000000018982720C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x00000001898270E4-0x0000000189827174
		public override object ConvertValue(object value) => default; // 0x0000000189827394-0x00000001898273F8
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189823750-0x000000018982379C
		public override object Get(int record) => default; // 0x00000001898276BC-0x000000018982772C
		public override bool IsNull(int record) => default; // 0x000000018982772C-0x0000000189827794
		public override void Set(int record, object value) {} // 0x00000001898278B0-0x00000001898278F4
		public override void SetCapacity(int capacity) {} // 0x0000000189827794-0x000000018982784C
		public override object ConvertXmlToObject(string s) => default; // 0x00000001898273F8-0x00000001898275AC
		public override string ConvertObjectToXml(object value) => default; // 0x000000018982720C-0x0000000189827394
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189827684-0x00000001898276BC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x00000001898275AC-0x0000000189827684
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018982784C-0x00000001898278B0
	}

	internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 50138
	{
		// Fields
		private SqlString[] _values; // 0x50
	
		// Constructors
		public SqlStringStorage() {} // Dummy constructor
		public SqlStringStorage(DataColumn column) {} // 0x00000001898287A8-0x00000001898288DC
	
		// Methods
		public override object Aggregate(int[] recordNos, AggregateType kind) => default; // 0x0000000189827A04-0x0000000189827D3C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189827DF0-0x0000000189827E84
		public int Compare(SqlString valueNo1, SqlString valueNo2) => default; // 0x0000000189827E84-0x0000000189827F64
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189827D3C-0x0000000189827DF0
		public override object ConvertValue(object value) => default; // 0x00000001898280EC-0x0000000189828160
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018982840C-0x0000000189828468
		public override object Get(int record) => default; // 0x000000018982854C-0x00000001898285C4
		public override int GetStringLength(int record) => default; // 0x00000001898284A0-0x000000018982854C
		public override bool IsNull(int record) => default; // 0x00000001898285C4-0x0000000189828630
		public override void Set(int record, object value) {} // 0x000000018982874C-0x00000001898287A8
		public override void SetCapacity(int capacity) {} // 0x0000000189828630-0x00000001898286E8
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189828160-0x0000000189828324
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189827F64-0x00000001898280EC
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189828468-0x00000001898284A0
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189828324-0x000000018982840C
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x00000001898286E8-0x000000018982874C
	}

	internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 50139
	{
		// Fields
		private SqlBoolean[] _values; // 0x50
	
		// Constructors
		public SqlBooleanStorage() {} // Dummy constructor
		public SqlBooleanStorage(DataColumn column) {} // 0x000000018981B958-0x000000018981BA68
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018981AD94-0x000000018981B10C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018981B198-0x000000018981B230
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018981B10C-0x000000018981B198
		public override object ConvertValue(object value) => default; // 0x000000018981B3B8-0x000000018981B41C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018981B6A4-0x000000018981B6F0
		public override object Get(int record) => default; // 0x000000018981B728-0x000000018981B794
		public override bool IsNull(int record) => default; // 0x000000018981B794-0x000000018981B7FC
		public override void Set(int record, object value) {} // 0x000000018981B918-0x000000018981B958
		public override void SetCapacity(int capacity) {} // 0x000000018981B7FC-0x000000018981B8B4
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981B41C-0x000000018981B5D0
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981B230-0x000000018981B3B8
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018981B6F0-0x000000018981B728
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981B5D0-0x000000018981B6A4
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018981B8B4-0x000000018981B918
	}

	internal sealed class SingleStorage : DataStorage // TypeDefIndex: 50140
	{
		// Fields
		private float[] _values; // 0x50
	
		// Constructors
		public SingleStorage() {} // Dummy constructor
		public SingleStorage(DataColumn column) {} // 0x000000018981ACC0-0x000000018981AD94
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x0000000189819F60-0x000000018981A5D0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018981A6A8-0x000000018981A72C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018981A5D0-0x000000018981A6A8
		public override object ConvertValue(object value) => default; // 0x000000018981A788-0x000000018981A83C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018981A978-0x000000018981A9D8
		public override object Get(int record) => default; // 0x000000018981AA10-0x000000018981AA9C
		public override void Set(int record, object value) {} // 0x000000018981ABE0-0x000000018981ACC0
		public override void SetCapacity(int capacity) {} // 0x000000018981AA9C-0x000000018981AB64
		public override object ConvertXmlToObject(string s) => default; // 0x000000018981A83C-0x000000018981A8A0
		public override string ConvertObjectToXml(object value) => default; // 0x000000018981A72C-0x000000018981A788
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018981A9D8-0x000000018981AA10
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018981A8A0-0x000000018981A978
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018981AB64-0x000000018981ABE0
	}

	internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 50142
	{
		// Fields
		private object[] _values; // 0x50
		private readonly bool _implementsIXmlSerializable; // 0x58
		private readonly bool _implementsIComparable; // 0x59
		private static readonly ConcurrentDictionary<System.Type, object> s_typeToNull; // 0x00
	
		// Constructors
		public SqlUdtStorage() {} // Dummy constructor
		public SqlUdtStorage(DataColumn column, System.Type type) {} // 0x00000001898299C0-0x0000000189829A34
		private SqlUdtStorage(DataColumn column, System.Type type, object nullValue) {} // 0x0000000189829870-0x00000001898299C0
		static SqlUdtStorage() {} // 0x00000001898297E4-0x0000000189829870
	
		// Methods
		internal static object GetStaticNullForUdtType(System.Type type) => default; // 0x00000001898293F0-0x00000001898294F8
		public override bool IsNull(int record) => default; // 0x00000001898294F8-0x0000000189829578
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x00000001898288DC-0x0000000189828910
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189828A80-0x0000000189828AC0
		public override int CompareValueTo(int recordNo1, object value) => default; // 0x0000000189828910-0x0000000189828A80
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189829340-0x00000001898293B8
		public override object Get(int recordNo) => default; // 0x000000018981C0E8-0x000000018981C114
		public override void Set(int recordNo, object value) {} // 0x00000001898296A4-0x00000001898297E4
		public override void SetCapacity(int capacity) {} // 0x0000000189829578-0x0000000189829640
		public override object ConvertXmlToObject(string s) => default; // 0x0000000189828F50-0x000000018982924C
		public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) => default; // 0x0000000189828D7C-0x0000000189828F50
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189828B8C-0x0000000189828D7C
		public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) {} // 0x0000000189828AC0-0x0000000189828B8C
		protected override object GetEmptyStorage(int recordCount) => default; // 0x00000001898293B8-0x00000001898293F0
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018982924C-0x0000000189829340
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x0000000189829640-0x00000001898296A4
	}

	internal sealed class StringStorage : DataStorage // TypeDefIndex: 50143
	{
		// Fields
		private string[] _values; // 0x50
	
		// Constructors
		public StringStorage() {} // Dummy constructor
		public StringStorage(DataColumn column) {} // 0x000000018982A124-0x000000018982A1F0
	
		// Methods
		public override object Aggregate(int[] recordNos, AggregateType kind) => default; // 0x0000000189829A34-0x0000000189829C7C
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x0000000189829D40-0x0000000189829DB8
		public override int CompareValueTo(int recordNo, object value) => default; // 0x0000000189829C7C-0x0000000189829D40
		public override object ConvertValue(object value) => default; // 0x0000000189829E00-0x0000000189829E2C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189829F08-0x0000000189829F44
		public override object Get(int recordNo) => default; // 0x0000000189811300-0x0000000189811338
		public override int GetStringLength(int record) => default; // 0x0000000189829F7C-0x0000000189829FB0
		public override bool IsNull(int record) => default; // 0x0000000189811338-0x0000000189811368
		public override void Set(int record, object value) {} // 0x000000018982A0CC-0x000000018982A124
		public override void SetCapacity(int capacity) {} // 0x0000000189829FB0-0x000000018982A068
		public override object ConvertXmlToObject(string s) => default; // 0x0000000183D51810-0x0000000183D51820
		public override string ConvertObjectToXml(object value) => default; // 0x0000000189829DB8-0x0000000189829E00
		protected override object GetEmptyStorage(int recordCount) => default; // 0x0000000189829F44-0x0000000189829F7C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x0000000189829E2C-0x0000000189829F08
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018982A068-0x000000018982A0CC
	}

	internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 50144
	{
		// Fields
		private static readonly TimeSpan s_defaultValue; // 0x00
		private TimeSpan[] _values; // 0x50
	
		// Constructors
		public TimeSpanStorage() {} // Dummy constructor
		public TimeSpanStorage(DataColumn column) {} // 0x000000018982B404-0x000000018982B500
		static TimeSpanStorage() {} // 0x000000018982B3A4-0x000000018982B404
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018982A1F0-0x000000018982AAD0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018982ABF0-0x000000018982AD18
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018982AAD0-0x000000018982ABF0
		private static TimeSpan ConvertToTimeSpan(object value) => default; // 0x000000018982AD74-0x000000018982AEE0
		public override object ConvertValue(object value) => default; // 0x000000018982AEE0-0x000000018982AF68
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189809E20-0x0000000189809E94
		public override object Get(int record) => default; // 0x000000018982B0DC-0x000000018982B1A0
		public override void Set(int record, object value) {} // 0x000000018982B2E4-0x000000018982B3A4
		public override void SetCapacity(int capacity) {} // 0x000000018982B1A0-0x000000018982B268
		public override object ConvertXmlToObject(string s) => default; // 0x000000018982AF68-0x000000018982AFCC
		public override string ConvertObjectToXml(object value) => default; // 0x000000018982AD18-0x000000018982AD74
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018982B0A4-0x000000018982B0DC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018982AFCC-0x000000018982B0A4
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018982B268-0x000000018982B2E4
	}

	internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 50145
	{
		// Fields
		private static readonly ushort s_defaultValue; // 0x00
		private ushort[] _values; // 0x50
	
		// Constructors
		public UInt16Storage() {} // Dummy constructor
		public UInt16Storage(DataColumn column) {} // 0x000000018982C480-0x000000018982C570
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018982B608-0x000000018982BD80
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018982BE68-0x000000018982BF20
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018982BD80-0x000000018982BE68
		public override object ConvertValue(object value) => default; // 0x000000018982BF7C-0x000000018982C030
		public override void Copy(int recordNo1, int recordNo2) {} // 0x0000000189805FA4-0x0000000189806004
		public override object Get(int record) => default; // 0x000000018982C1A4-0x000000018982C240
		public override void Set(int record, object value) {} // 0x000000018982C384-0x000000018982C480
		public override void SetCapacity(int capacity) {} // 0x000000018982C240-0x000000018982C308
		public override object ConvertXmlToObject(string s) => default; // 0x000000018982C030-0x000000018982C094
		public override string ConvertObjectToXml(object value) => default; // 0x000000018982BF20-0x000000018982BF7C
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018982C16C-0x000000018982C1A4
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018982C094-0x000000018982C16C
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018982C308-0x000000018982C384
	}

	internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 50146
	{
		// Fields
		private static readonly uint s_defaultValue; // 0x00
		private uint[] _values; // 0x50
	
		// Constructors
		public UInt32Storage() {} // Dummy constructor
		public UInt32Storage(DataColumn column) {} // 0x000000018982D3C4-0x000000018982D4B4
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018982C570-0x000000018982CCD0
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018982CDB0-0x000000018982CE6C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018982CCD0-0x000000018982CDB0
		public override object ConvertValue(object value) => default; // 0x000000018982CEC8-0x000000018982CF78
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018980DF88-0x000000018980DFE8
		public override object Get(int record) => default; // 0x000000018982D0EC-0x000000018982D188
		public override void Set(int record, object value) {} // 0x000000018982D2CC-0x000000018982D3C4
		public override void SetCapacity(int capacity) {} // 0x000000018982D188-0x000000018982D250
		public override object ConvertXmlToObject(string s) => default; // 0x000000018982CF78-0x000000018982CFDC
		public override string ConvertObjectToXml(object value) => default; // 0x000000018982CE6C-0x000000018982CEC8
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018982D0B4-0x000000018982D0EC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018982CFDC-0x000000018982D0B4
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018982D250-0x000000018982D2CC
	}

	internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 50147
	{
		// Fields
		private static readonly ulong s_defaultValue; // 0x00
		private ulong[] _values; // 0x50
	
		// Constructors
		public UInt64Storage() {} // Dummy constructor
		public UInt64Storage(DataColumn column) {} // 0x000000018982E37C-0x000000018982E46C
	
		// Methods
		public override object Aggregate(int[] records, AggregateType kind) => default; // 0x000000018982D4B4-0x000000018982DC78
		public override int Compare(int recordNo1, int recordNo2) => default; // 0x000000018982DD5C-0x000000018982DE1C
		public override int CompareValueTo(int recordNo, object value) => default; // 0x000000018982DC78-0x000000018982DD5C
		public override object ConvertValue(object value) => default; // 0x000000018982DE78-0x000000018982DF2C
		public override void Copy(int recordNo1, int recordNo2) {} // 0x000000018980EE44-0x000000018980EEA4
		public override object Get(int record) => default; // 0x000000018982E0A0-0x000000018982E13C
		public override void Set(int record, object value) {} // 0x000000018982E280-0x000000018982E37C
		public override void SetCapacity(int capacity) {} // 0x000000018982E13C-0x000000018982E204
		public override object ConvertXmlToObject(string s) => default; // 0x000000018982DF2C-0x000000018982DF90
		public override string ConvertObjectToXml(object value) => default; // 0x000000018982DE1C-0x000000018982DE78
		protected override object GetEmptyStorage(int recordCount) => default; // 0x000000018982E068-0x000000018982E0A0
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) {} // 0x000000018982DF90-0x000000018982E068
		protected override void SetStorage(object store, BitArray nullbits) {} // 0x000000018982E204-0x000000018982E280
	}
}

namespace System.Data.SqlTypes
{
	internal static class SQLResource // TypeDefIndex: 50080
	{
		// Properties
		internal static string NullString { get; } // 0x00000001897EA7F4-0x00000001897EA820 
		internal static string ArithOverflowMessage { get; } // 0x00000001897EA694-0x00000001897EA6C0 
		internal static string DivideByZeroMessage { get; } // 0x00000001897EA770-0x00000001897EA79C 
		internal static string NullValueMessage { get; } // 0x00000001897EA820-0x00000001897EA84C 
		internal static string TruncationMessage { get; } // 0x00000001897EA878-0x00000001897EA8A4 
		internal static string DateTimeOverflowMessage { get; } // 0x00000001897EA744-0x00000001897EA770 
		internal static string ConcatDiffCollationMessage { get; } // 0x00000001897EA6EC-0x00000001897EA718 
		internal static string CompareDiffCollationMessage { get; } // 0x00000001897EA6C0-0x00000001897EA6EC 
		internal static string ConversionOverflowMessage { get; } // 0x00000001897EA718-0x00000001897EA744 
		internal static string TimeZoneSpecifiedMessage { get; } // 0x00000001897EA84C-0x00000001897EA878 
		internal static string InvalidPrecScaleMessage { get; } // 0x00000001897EA7C8-0x00000001897EA7F4 
		internal static string FormatMessage { get; } // 0x00000001897EA79C-0x00000001897EA7C8 
	
		// Methods
		internal static string InvalidOpStreamClosed(string method) => default; // 0x00000001897EA5A4-0x00000001897EA5E0
		internal static string InvalidOpStreamNonWritable(string method) => default; // 0x00000001897EA658-0x00000001897EA694
		internal static string InvalidOpStreamNonReadable(string method) => default; // 0x00000001897EA5E0-0x00000001897EA61C
		internal static string InvalidOpStreamNonSeekable(string method) => default; // 0x00000001897EA61C-0x00000001897EA658
	}

	public interface INullable // TypeDefIndex: 50081
	{
		// Properties
		bool IsNull { get; }
	}

	[Serializable]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50082
	{
		// Fields
		private byte[] _value; // 0x00
		public static readonly SqlBinary Null; // 0x00
	
		// Properties
		public bool IsNull { get => default; } // 0x0000000182361C20-0x0000000182361C30 
		public byte[] Value { get => default; } // 0x00000001897EB168-0x00000001897EB22C 
	
		// Constructors
		private SqlBinary(bool fNull) : this() {
			_value = default;
		} // 0x000000018426F744-0x000000018426F750
		public SqlBinary(byte[] value) : this() {
			_value = default;
		} // 0x00000001897EB0F0-0x00000001897EB168
		static SqlBinary() {
			Null = default;
		} // 0x00000001897EB090-0x00000001897EB0F0
	
		// Methods
		public static implicit operator SqlBinary(byte[] x) => default; // 0x00000001897EB3C4-0x00000001897EB3EC
		public override string ToString() => default; // 0x00000001897EAFD0-0x00000001897EB090
		private static EComparison PerformCompareByte(byte[] x, byte[] y) => default; // 0x00000001897EACF0-0x00000001897EADBC
		public static SqlBoolean operator ==(SqlBinary x, SqlBinary y) => default; // 0x00000001897EB22C-0x00000001897EB2F8
		public static SqlBoolean operator <(SqlBinary x, SqlBinary y) => default; // 0x00000001897EB3EC-0x00000001897EB4B8
		public static SqlBoolean operator >(SqlBinary x, SqlBinary y) => default; // 0x00000001897EB2F8-0x00000001897EB3C4
		public int CompareTo(object value) => default; // 0x00000001897EA9A0-0x00000001897EAA90
		public int CompareTo(SqlBinary value) => default; // 0x00000001897EA8A4-0x00000001897EA9A0
		public override bool Equals(object value) => default; // 0x00000001897EAA90-0x00000001897EAB88
		internal static int HashByteArray(byte[] rgbValue, int length) => default; // 0x00000001897EAC94-0x00000001897EACF0
		public override int GetHashCode() => default; // 0x00000001897EAB88-0x00000001897EAC1C
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897EADBC-0x00000001897EAEE0
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897EAEE0-0x00000001897EAFD0
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897EAC1C-0x00000001897EAC94
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50083
	{
		// Fields
		private byte m_value; // 0x00
		public static readonly SqlBoolean True; // 0x00
		public static readonly SqlBoolean False; // 0x01
		public static readonly SqlBoolean Null; // 0x02
		public static readonly SqlBoolean Zero; // 0x03
		public static readonly SqlBoolean One; // 0x04
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public bool Value { get => default; } // 0x00000001897EBCD8-0x00000001897EBD38 
		public bool IsTrue { get => default; } // 0x00000001897EBCD0-0x00000001897EBCD8 
		public bool IsFalse { get => default; } // 0x00000001897EBCC8-0x00000001897EBCD0 
		public byte ByteValue { get => default; } // 0x00000001897EBC40-0x00000001897EBCC8 
	
		// Constructors
		public SqlBoolean(bool value) : this() {
			m_value = default;
		} // 0x00000001897EBC38-0x00000001897EBC40
		public SqlBoolean(int value) : this() {
			m_value = default;
		} // 0x00000001897EBBD8-0x00000001897EBC24
		private SqlBoolean(int value, bool fNull) : this() {
			m_value = default;
		} // 0x00000001897EBC24-0x00000001897EBC38
		static SqlBoolean() {
			True = default;
			False = default;
			Null = default;
			Zero = default;
			One = default;
		} // 0x00000001897EBB28-0x00000001897EBBD8
	
		// Methods
		public static implicit operator SqlBoolean(bool x) => default; // 0x00000001897EBF08-0x00000001897EBF10
		public static bool op_True(SqlBoolean x) => default; // 0x00000001897EBF10-0x00000001897EBF58
		public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y) => default; // 0x00000001897EBD38-0x00000001897EBDE0
		public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y) => default; // 0x00000001897EBDE0-0x00000001897EBE88
		public override string ToString() => default; // 0x00000001897EBAA0-0x00000001897EBB28
		public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y) => default; // 0x00000001897EBE88-0x00000001897EBF08
		public static SqlBoolean And(SqlBoolean x, SqlBoolean y) => default; // 0x00000001897EB4B8-0x00000001897EB514
		public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) => default; // 0x00000001897EB888-0x00000001897EB8E4
		public int CompareTo(object value) => default; // 0x00000001897EB5D8-0x00000001897EB6C4
		public int CompareTo(SqlBoolean value) => default; // 0x00000001897EB514-0x00000001897EB5D8
		public override bool Equals(object value) => default; // 0x00000001897EB6C4-0x00000001897EB79C
		public override int GetHashCode() => default; // 0x00000001897EB79C-0x00000001897EB810
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897EB8E4-0x00000001897EB9BC
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897EB9BC-0x00000001897EBAA0
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897EB810-0x00000001897EB888
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50084
	{
		// Fields
		private bool m_fNotNull; // 0x00
		private byte m_value; // 0x01
		private static readonly int s_iBitNotByteMax; // 0x00
		public static readonly SqlByte Null; // 0x04
		public static readonly SqlByte Zero; // 0x06
		public static readonly SqlByte MinValue; // 0x08
		public static readonly SqlByte MaxValue; // 0x0A
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public byte Value { get => default; } // 0x00000001897EC75C-0x00000001897EC7B4 
	
		// Constructors
		private SqlByte(bool fNull) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D754C0-0x0000000183D754D0
		public SqlByte(byte value) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D685E0-0x0000000183D685F0
		static SqlByte() {
			s_iBitNotByteMax = default;
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897EC6AC-0x00000001897EC75C
	
		// Methods
		public static implicit operator SqlByte(byte x) => default; // 0x0000000183D754D0-0x0000000183D754E0
		public override string ToString() => default; // 0x00000001897EC654-0x00000001897EC6AC
		public static SqlByte operator +(SqlByte x, SqlByte y) => default; // 0x00000001897EC7B4-0x00000001897EC8C8
		public static SqlByte operator -(SqlByte x, SqlByte y) => default; // 0x00000001897ECDE4-0x00000001897ECEF8
		public static SqlByte operator *(SqlByte x, SqlByte y) => default; // 0x00000001897ECCCC-0x00000001897ECDE4
		public static SqlByte operator /(SqlByte x, SqlByte y) => default; // 0x00000001897EC8C8-0x00000001897EC9C0
		public static explicit operator SqlByte(SqlInt64 x) => default; // 0x00000001897ECA5C-0x00000001897ECB94
		public static SqlBoolean operator ==(SqlByte x, SqlByte y) => default; // 0x00000001897EC9C0-0x00000001897ECA5C
		public static SqlBoolean operator <(SqlByte x, SqlByte y) => default; // 0x00000001897ECC30-0x00000001897ECCCC
		public static SqlBoolean operator >(SqlByte x, SqlByte y) => default; // 0x00000001897ECB94-0x00000001897ECC30
		public static SqlBoolean LessThan(SqlByte x, SqlByte y) => default; // 0x00000001897EC36C-0x00000001897EC3C8
		public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) => default; // 0x00000001897EC310-0x00000001897EC36C
		public SqlDouble ToSqlDouble() => default; // 0x00000001897EC594-0x00000001897EC5F4
		public SqlInt64 ToSqlInt64() => default; // 0x00000001897EC5F4-0x00000001897EC654
		public int CompareTo(object value) => default; // 0x00000001897EC054-0x00000001897EC144
		public int CompareTo(SqlByte value) => default; // 0x00000001897EBF58-0x00000001897EC054
		public override bool Equals(object value) => default; // 0x00000001897EC144-0x00000001897EC23C
		public override int GetHashCode() => default; // 0x00000001897EC23C-0x00000001897EC298
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897EC3C8-0x00000001897EC4A4
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897EC4A4-0x00000001897EC594
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897EC298-0x00000001897EC310
	}

	internal enum SqlBytesCharsState // TypeDefIndex: 50085
	{
		Null = 0,
		Buffer = 1,
		Stream = 3
	}

	[Serializable]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 50086
	{
		// Fields
		internal byte[] _rgbBuf; // 0x10
		private long _lCurLen; // 0x18
		internal Stream _stream; // 0x20
		private SqlBytesCharsState _state; // 0x28
		private byte[] _rgbWorkBuf; // 0x30
	
		// Properties
		public bool IsNull { get => default; } // 0x000000018564D8A8-0x000000018564D8B0 
		public byte[] Buffer { get => default; } // 0x00000001897ED4C0-0x00000001897ED4E8 
		public long Length { get => default; } // 0x00000001897ED4E8-0x00000001897ED560 
		public byte[] Value { get => default; } // 0x00000001897ED5B4-0x00000001897ED7B0 
		public static SqlBytes Null { get => default; } // 0x00000001897ED560-0x00000001897ED5B4 
	
		// Constructors
		public SqlBytes() {} // 0x00000001897ED3D0-0x00000001897ED3D8
		public SqlBytes(byte[] buffer) {} // 0x00000001897ED45C-0x00000001897ED4C0
		public SqlBytes(SqlBinary value) {} // 0x00000001897ED3D8-0x00000001897ED45C
	
		// Methods
		public void SetNull() {} // 0x00000001897ED120-0x00000001897ED148
		private void CopyStreamToBuffer() {} // 0x00000001897ECEF8-0x00000001897ED058
		internal bool FStream() => default; // 0x00000001856B0004-0x00000001856B000C
		private void SetBuffer(byte[] buffer) {} // 0x00000001897ED0D0-0x00000001897ED120
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader r) {} // 0x00000001897ED194-0x00000001897ED2D0
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897ED2D0-0x00000001897ED3D0
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897ED058-0x00000001897ED0D0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001897ED148-0x00000001897ED194
	}

	[Serializable]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 50087
	{
		// Fields
		internal char[] _rgchBuf; // 0x10
		private long _lCurLen; // 0x18
		internal SqlStreamChars _stream; // 0x20
		private SqlBytesCharsState _state; // 0x28
		private char[] _rgchWorkBuf; // 0x30
	
		// Properties
		public bool IsNull { get => default; } // 0x000000018564D8A8-0x000000018564D8B0 
		public char[] Buffer { get => default; } // 0x00000001897EDC34-0x00000001897EDC5C 
		public long Length { get => default; } // 0x00000001897EDC5C-0x00000001897EDCD4 
		public char[] Value { get => default; } // 0x00000001897EDD28-0x00000001897EDF24 
		public static SqlChars Null { get => default; } // 0x00000001897EDCD4-0x00000001897EDD28 
	
		// Constructors
		public SqlChars() {} // 0x00000001897ED3D0-0x00000001897ED3D8
		public SqlChars(char[] buffer) {} // 0x00000001897ED45C-0x00000001897ED4C0
		public SqlChars(SqlString value) {} // 0x00000001897EDBA4-0x00000001897EDC34
	
		// Methods
		public void SetNull() {} // 0x00000001897ED120-0x00000001897ED148
		internal bool FStream() => default; // 0x00000001856B0004-0x00000001856B000C
		private void CopyStreamToBuffer() {} // 0x00000001897ED7B0-0x00000001897ED910
		private void SetBuffer(char[] buffer) {} // 0x00000001897ED0D0-0x00000001897ED120
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader r) {} // 0x00000001897ED9D4-0x00000001897EDAB8
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897EDAB8-0x00000001897EDBA4
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897ED910-0x00000001897ED988
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001897ED988-0x00000001897ED9D4
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50088
	{
		// Fields
		private bool m_fNotNull; // 0x00
		private int m_day; // 0x04
		private int m_time; // 0x08
		private static readonly double s_SQLTicksPerMillisecond; // 0x00
		public static readonly int SQLTicksPerSecond; // 0x08
		public static readonly int SQLTicksPerMinute; // 0x0C
		public static readonly int SQLTicksPerHour; // 0x10
		private static readonly int s_SQLTicksPerDay; // 0x14
		private static readonly long s_ticksPerSecond; // 0x18
		private static readonly System.DateTime s_SQLBaseDate; // 0x20
		private static readonly long s_SQLBaseDateTicks; // 0x28
		private static readonly int s_minYear; // 0x30
		private static readonly int s_maxYear; // 0x34
		private static readonly int s_minDay; // 0x38
		private static readonly int s_maxDay; // 0x3C
		private static readonly int s_minTime; // 0x40
		private static readonly int s_maxTime; // 0x44
		private static readonly int s_dayBase; // 0x48
		private static readonly int[] s_daysToMonth365; // 0x50
		private static readonly int[] s_daysToMonth366; // 0x58
		private static readonly System.DateTime s_minDateTime; // 0x60
		private static readonly System.DateTime s_maxDateTime; // 0x68
		private static readonly TimeSpan s_minTimeSpan; // 0x70
		private static readonly TimeSpan s_maxTimeSpan; // 0x78
		private static readonly string s_ISO8601_DateTimeFormat; // 0x80
		private static readonly string[] s_dateTimeFormats; // 0x88
		public static readonly SqlDateTime MinValue; // 0x90
		public static readonly SqlDateTime MaxValue; // 0x9C
		public static readonly SqlDateTime Null; // 0xA8
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public System.DateTime Value { get => default; } // 0x00000001897EF3C0-0x00000001897EF46C 
		public int DayTicks { get => default; } // 0x00000001897EF310-0x00000001897EF368 
		public int TimeTicks { get => default; } // 0x00000001897EF368-0x00000001897EF3C0 
	
		// Constructors
		private SqlDateTime(bool fNull) : this() {
			m_fNotNull = default;
			m_day = default;
			m_time = default;
		} // 0x0000000183D754E0-0x0000000183D754F0
		public SqlDateTime(System.DateTime value) : this() {
			m_fNotNull = default;
			m_day = default;
			m_time = default;
		} // 0x00000001897EF1A4-0x00000001897EF208
		public SqlDateTime(int dayTicks, int timeTicks) : this() {
			m_fNotNull = default;
			m_day = default;
			m_time = default;
		} // 0x00000001897EF208-0x00000001897EF310
		static SqlDateTime() {
			s_SQLTicksPerMillisecond = default;
			SQLTicksPerSecond = default;
			SQLTicksPerMinute = default;
			SQLTicksPerHour = default;
			s_SQLTicksPerDay = default;
			s_ticksPerSecond = default;
			s_SQLBaseDate = default;
			s_SQLBaseDateTicks = default;
			s_minYear = default;
			s_maxYear = default;
			s_minDay = default;
			s_maxDay = default;
			s_minTime = default;
			s_maxTime = default;
			s_dayBase = default;
			s_daysToMonth365 = default;
			s_daysToMonth366 = default;
			s_minDateTime = default;
			s_maxDateTime = default;
			s_minTimeSpan = default;
			s_maxTimeSpan = default;
			s_ISO8601_DateTimeFormat = default;
			s_dateTimeFormats = default;
			MinValue = default;
			MaxValue = default;
			Null = default;
		} // 0x00000001897EEBF4-0x00000001897EF1A4
	
		// Methods
		private static TimeSpan ToTimeSpan(SqlDateTime value) => default; // 0x00000001897EEB80-0x00000001897EEBF4
		private static System.DateTime ToDateTime(SqlDateTime value) => default; // 0x00000001897EEA48-0x00000001897EEAD4
		private static SqlDateTime FromTimeSpan(TimeSpan value) => default; // 0x00000001897EE3BC-0x00000001897EE57C
		private static SqlDateTime FromDateTime(System.DateTime value) => default; // 0x00000001897EE2C8-0x00000001897EE3BC
		public static implicit operator SqlDateTime(System.DateTime value) => default; // 0x00000001897EF5B8-0x00000001897EF5DC
		public override string ToString() => default; // 0x00000001897EEAD4-0x00000001897EEB80
		public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y) => default; // 0x00000001897EF46C-0x00000001897EF510
		public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y) => default; // 0x00000001897EF5DC-0x00000001897EF684
		public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y) => default; // 0x00000001897EF510-0x00000001897EF5B8
		public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) => default; // 0x00000001897EE6EC-0x00000001897EE764
		public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) => default; // 0x00000001897EE674-0x00000001897EE6EC
		public int CompareTo(object value) => default; // 0x00000001897EDF24-0x00000001897EE030
		public int CompareTo(SqlDateTime value) => default; // 0x00000001897EE030-0x00000001897EE194
		public override bool Equals(object value) => default; // 0x00000001897EE194-0x00000001897EE2C8
		public override int GetHashCode() => default; // 0x00000001897EE57C-0x00000001897EE5FC
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897EE764-0x00000001897EE920
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897EE920-0x00000001897EEA48
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897EE5FC-0x00000001897EE674
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50089
	{
		// Fields
		internal byte _bStatus; // 0x00
		internal byte _bLen; // 0x01
		internal byte _bPrec; // 0x02
		internal byte _bScale; // 0x03
		internal uint _data1; // 0x04
		internal uint _data2; // 0x08
		internal uint _data3; // 0x0C
		internal uint _data4; // 0x10
		private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x00
		public static readonly byte MaxPrecision; // 0x01
		public static readonly byte MaxScale; // 0x02
		private static readonly byte s_bNullMask; // 0x03
		private static readonly byte s_bIsNull; // 0x04
		private static readonly byte s_bNotNull; // 0x05
		private static readonly byte s_bReverseNullMask; // 0x06
		private static readonly byte s_bSignMask; // 0x07
		private static readonly byte s_bPositive; // 0x08
		private static readonly byte s_bNegative; // 0x09
		private static readonly byte s_bReverseSignMask; // 0x0A
		private static readonly uint s_uiZero; // 0x0C
		private static readonly int s_cNumeMax; // 0x10
		private static readonly long s_lInt32Base; // 0x18
		private static readonly ulong s_ulInt32Base; // 0x20
		private static readonly ulong s_ulInt32BaseForMod; // 0x28
		internal static readonly ulong s_llMax; // 0x30
		private static readonly uint s_ulBase10; // 0x38
		private static readonly double s_DUINT_BASE; // 0x40
		private static readonly double s_DUINT_BASE2; // 0x48
		private static readonly double s_DUINT_BASE3; // 0x50
		private static readonly double s_DMAX_NUME; // 0x58
		private static readonly uint s_DBL_DIG; // 0x60
		private static readonly byte s_cNumeDivScaleMin; // 0x64
		private static readonly uint[] s_rgulShiftBase; // 0x68
		private static readonly uint[] s_decimalHelpersLo; // 0x70
		private static readonly uint[] s_decimalHelpersMid; // 0x78
		private static readonly uint[] s_decimalHelpersHi; // 0x80
		private static readonly uint[] s_decimalHelpersHiHi; // 0x88
		private static readonly byte[] s_rgCLenFromPrec; // 0x90
		private static readonly uint s_ulT1; // 0x98
		private static readonly uint s_ulT2; // 0x9C
		private static readonly uint s_ulT3; // 0xA0
		private static readonly uint s_ulT4; // 0xA4
		private static readonly uint s_ulT5; // 0xA8
		private static readonly uint s_ulT6; // 0xAC
		private static readonly uint s_ulT7; // 0xB0
		private static readonly uint s_ulT8; // 0xB4
		private static readonly uint s_ulT9; // 0xB8
		private static readonly ulong s_dwlT10; // 0xC0
		private static readonly ulong s_dwlT11; // 0xC8
		private static readonly ulong s_dwlT12; // 0xD0
		private static readonly ulong s_dwlT13; // 0xD8
		private static readonly ulong s_dwlT14; // 0xE0
		private static readonly ulong s_dwlT15; // 0xE8
		private static readonly ulong s_dwlT16; // 0xF0
		private static readonly ulong s_dwlT17; // 0xF8
		private static readonly ulong s_dwlT18; // 0x100
		private static readonly ulong s_dwlT19; // 0x108
		public static readonly SqlDecimal Null; // 0x110
		public static readonly SqlDecimal MinValue; // 0x124
		public static readonly SqlDecimal MaxValue; // 0x138
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001897F3970-0x00000001897F39C4 
		public decimal Value { get => default; } // 0x00000001897F3B00-0x00000001897F3B60 
		public bool IsPositive { get => default; } // 0x00000001897F39C4-0x00000001897F3A74 
		public byte Scale { get => default; } // 0x00000001897F3A74-0x00000001897F3B00 
		public int[] Data { get => default; } // 0x00000001897F388C-0x00000001897F3970 
	
		// Constructors
		private SqlDecimal(bool fNull) : this() {
			_bStatus = default;
			_bLen = default;
			_bPrec = default;
			_bScale = default;
			_data1 = default;
			_data2 = default;
			_data3 = default;
			_data4 = default;
		} // 0x00000001897F34C8-0x00000001897F3520
		public SqlDecimal(decimal value) : this() {
			_bStatus = default;
			_bLen = default;
			_bPrec = default;
			_bScale = default;
			_data1 = default;
			_data2 = default;
			_data3 = default;
			_data4 = default;
		} // 0x00000001897F3738-0x00000001897F388C
		public SqlDecimal(int value) : this() {
			_bStatus = default;
			_bLen = default;
			_bPrec = default;
			_bScale = default;
			_data1 = default;
			_data2 = default;
			_data3 = default;
			_data4 = default;
		} // 0x00000001897F33F8-0x00000001897F34C8
		public SqlDecimal(long value) : this() {
			_bStatus = default;
			_bLen = default;
			_bPrec = default;
			_bScale = default;
			_data1 = default;
			_data2 = default;
			_data3 = default;
			_data4 = default;
		} // 0x00000001897F3520-0x00000001897F35F8
		private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) : this() {
			_bStatus = default;
			_bLen = default;
			_bPrec = default;
			_bScale = default;
			_data1 = default;
			_data2 = default;
			_data3 = default;
			_data4 = default;
		} // 0x00000001897F35F8-0x00000001897F3738
		static SqlDecimal() {
			s_NUMERIC_MAX_PRECISION = default;
			MaxPrecision = default;
			MaxScale = default;
			s_bNullMask = default;
			s_bIsNull = default;
			s_bNotNull = default;
			s_bReverseNullMask = default;
			s_bSignMask = default;
			s_bPositive = default;
			s_bNegative = default;
			s_bReverseSignMask = default;
			s_uiZero = default;
			s_cNumeMax = default;
			s_lInt32Base = default;
			s_ulInt32Base = default;
			s_ulInt32BaseForMod = default;
			s_llMax = default;
			s_ulBase10 = default;
			s_DUINT_BASE = default;
			s_DUINT_BASE2 = default;
			s_DUINT_BASE3 = default;
			s_DMAX_NUME = default;
			s_DBL_DIG = default;
			s_cNumeDivScaleMin = default;
			s_rgulShiftBase = default;
			s_decimalHelpersLo = default;
			s_decimalHelpersMid = default;
			s_decimalHelpersHi = default;
			s_decimalHelpersHiHi = default;
			s_rgCLenFromPrec = default;
			s_ulT1 = default;
			s_ulT2 = default;
			s_ulT3 = default;
			s_ulT4 = default;
			s_ulT5 = default;
			s_ulT6 = default;
			s_ulT7 = default;
			s_ulT8 = default;
			s_ulT9 = default;
			s_dwlT10 = default;
			s_dwlT11 = default;
			s_dwlT12 = default;
			s_dwlT13 = default;
			s_dwlT14 = default;
			s_dwlT15 = default;
			s_dwlT16 = default;
			s_dwlT17 = default;
			s_dwlT18 = default;
			s_dwlT19 = default;
			Null = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897F2CB0-0x00000001897F33F8
	
		// Methods
		private byte CalculatePrecision() => default; // 0x00000001897EFF1C-0x00000001897F00FC
		private bool VerifyPrecision(byte precision) => default; // 0x00000001897F2A58-0x00000001897F2C40
		private void SetPositive() {} // 0x00000001897F1FB4-0x00000001897F200C
		private void SetSignBit(bool fPositive) {} // 0x00000001897F200C-0x00000001897F2080
		public override string ToString() => default; // 0x00000001897F27BC-0x00000001897F2A58
		public static SqlDecimal Parse(string s) => default; // 0x00000001897F1A40-0x00000001897F1FB4
		public double ToDouble() => default; // 0x00000001897F24D4-0x00000001897F2654
		private decimal ToDecimal() => default; // 0x00000001897F2378-0x00000001897F24D4
		public static implicit operator SqlDecimal(decimal x) => default; // 0x00000001897F47C0-0x00000001897F47F4
		public static implicit operator SqlDecimal(long x) => default; // 0x00000001897F47F4-0x00000001897F4844
		public static SqlDecimal operator -(SqlDecimal x) => default; // 0x00000001897F56D4-0x00000001897F57C0
		public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F3B60-0x00000001897F419C
		public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F5614-0x00000001897F56D4
		public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F4CC0-0x00000001897F5614
		public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F419C-0x00000001897F4628
		public static implicit operator SqlDecimal(SqlByte x) => default; // 0x00000001897F49B8-0x00000001897F4A74
		public static implicit operator SqlDecimal(SqlInt16 x) => default; // 0x00000001897F4844-0x00000001897F4900
		public static implicit operator SqlDecimal(SqlInt32 x) => default; // 0x00000001897F4B3C-0x00000001897F4BF8
		public static implicit operator SqlDecimal(SqlInt64 x) => default; // 0x00000001897F4900-0x00000001897F49B8
		public static implicit operator SqlDecimal(SqlMoney x) => default; // 0x00000001897F4A74-0x00000001897F4B3C
		private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) {} // 0x00000001897F2C40-0x00000001897F2CB0
		private bool FZero() => default; // 0x00000001897F0A34-0x00000001897F0A48
		private bool FGt10_38() => default; // 0x00000001897F09B4-0x00000001897F09E8
		private bool FGt10_38(uint[] rglData) => default; // 0x00000001897F09E8-0x00000001897F0A34
		private static byte BGetPrecUI4(uint value) => default; // 0x00000001897EFB4C-0x00000001897EFC90
		private static byte BGetPrecUI8(ulong dwlVal) => default; // 0x00000001897EFC90-0x00000001897EFF1C
		private void AddULong(uint ulAdd) {} // 0x00000001897EF684-0x00000001897EF884
		private void MultByULong(uint uiMultiplier) {} // 0x00000001897F1804-0x00000001897F1A40
		private uint DivByULong(uint iDivisor) => default; // 0x00000001897F06BC-0x00000001897F0864
		internal void AdjustScale(int digits, bool fRound) {} // 0x00000001897EF884-0x00000001897EFB4C
		private int LAbsCmp(SqlDecimal snumOp) => default; // 0x00000001897F0C40-0x00000001897F0DB0
		private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) {
			ciulD = default;
		} // 0x00000001897F1690-0x00000001897F16E0
		private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) {
			ciulD = default;
		} // 0x00000001897F17D8-0x00000001897F1804
		private static void MpNormalize(uint[] rgulU, ref int ciulU) {} // 0x00000001897F17A0-0x00000001897F17D8
		private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) {} // 0x00000001897F16E0-0x00000001897F17A0
		private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) {
			iulR = default;
		} // 0x00000001897F0E24-0x00000001897F0EFC
		internal static ulong DWL(uint lo, uint hi) => default; // 0x0000000183D75500-0x0000000183D75510
		private static uint HI(ulong x) => default; // 0x0000000183D68B20-0x0000000183D68B30
		private static uint LO(ulong x) => default; // 0x0000000183D517B0-0x0000000183D517C0
		private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) {
			ciulQ = default;
			ciulR = default;
		} // 0x00000001897F0EFC-0x00000001897F1690
		private EComparison CompareNm(SqlDecimal snumOp) => default; // 0x00000001897F01CC-0x00000001897F0444
		private static void CheckValidPrecScale(byte bPrec, byte bScale) {} // 0x00000001897F00FC-0x00000001897F01CC
		public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F4628-0x00000001897F46F4
		public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F4BF8-0x00000001897F4CC0
		public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F46F4-0x00000001897F47C0
		public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F0DB0-0x00000001897F0E24
		public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) => default; // 0x00000001897F0BCC-0x00000001897F0C40
		public SqlDouble ToSqlDouble() => default; // 0x00000001897F2654-0x00000001897F26CC
		public SqlInt64 ToSqlInt64() => default; // 0x00000001897F26CC-0x00000001897F2744
		public SqlMoney ToSqlMoney() => default; // 0x00000001897F2744-0x00000001897F27BC
		private static char ChFromDigit(uint uiDigit) => default; // 0x0000000183D754F0-0x0000000183D75500
		private void StoreFromWorkingArray(uint[] rguiData) {} // 0x00000001897F20E4-0x00000001897F2130
		private void SetToZero() {} // 0x00000001897F2080-0x00000001897F20E4
		public int CompareTo(object value) => default; // 0x00000001897F05B4-0x00000001897F06BC
		public int CompareTo(SqlDecimal value) => default; // 0x00000001897F0444-0x00000001897F05B4
		public override bool Equals(object value) => default; // 0x00000001897F0864-0x00000001897F09B4
		public override int GetHashCode() => default; // 0x00000001897F0A48-0x00000001897F0B54
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897F2130-0x00000001897F2290
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897F2290-0x00000001897F2378
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897F0B54-0x00000001897F0BCC
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50090
	{
		// Fields
		private bool m_fNotNull; // 0x00
		private double m_value; // 0x08
		public static readonly SqlDouble Null; // 0x00
		public static readonly SqlDouble Zero; // 0x10
		public static readonly SqlDouble MinValue; // 0x20
		public static readonly SqlDouble MaxValue; // 0x30
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public double Value { get => default; } // 0x00000001897F60B4-0x00000001897F6110 
	
		// Constructors
		private SqlDouble(bool fNull) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D75510-0x0000000183D75520
		public SqlDouble(double value) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x00000001897F6028-0x00000001897F60B4
		static SqlDouble() {
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897F5F48-0x00000001897F6028
	
		// Methods
		public static implicit operator SqlDouble(double x) => default; // 0x00000001897F66DC-0x00000001897F66FC
		public override string ToString() => default; // 0x00000001897F5EF0-0x00000001897F5F48
		public static SqlDouble operator -(SqlDouble x) => default; // 0x00000001897F6C84-0x00000001897F6D10
		public static SqlDouble operator +(SqlDouble x, SqlDouble y) => default; // 0x00000001897F6110-0x00000001897F6228
		public static SqlDouble operator -(SqlDouble x, SqlDouble y) => default; // 0x00000001897F6B6C-0x00000001897F6C84
		public static SqlDouble operator *(SqlDouble x, SqlDouble y) => default; // 0x00000001897F6A54-0x00000001897F6B6C
		public static SqlDouble operator /(SqlDouble x, SqlDouble y) => default; // 0x00000001897F6228-0x00000001897F63A4
		public static implicit operator SqlDouble(SqlByte x) => default; // 0x00000001897F690C-0x00000001897F69C0
		public static implicit operator SqlDouble(SqlInt16 x) => default; // 0x00000001897F685C-0x00000001897F690C
		public static implicit operator SqlDouble(SqlInt32 x) => default; // 0x00000001897F66FC-0x00000001897F67AC
		public static implicit operator SqlDouble(SqlInt64 x) => default; // 0x00000001897F64DC-0x00000001897F6588
		public static implicit operator SqlDouble(SqlSingle x) => default; // 0x00000001897F67AC-0x00000001897F685C
		public static implicit operator SqlDouble(SqlMoney x) => default; // 0x00000001897F6638-0x00000001897F66DC
		public static implicit operator SqlDouble(SqlDecimal x) => default; // 0x00000001897F6588-0x00000001897F6638
		public static SqlBoolean operator ==(SqlDouble x, SqlDouble y) => default; // 0x00000001897F63A4-0x00000001897F6448
		public static SqlBoolean operator <(SqlDouble x, SqlDouble y) => default; // 0x00000001897F69C0-0x00000001897F6A54
		public static SqlBoolean operator >(SqlDouble x, SqlDouble y) => default; // 0x00000001897F6448-0x00000001897F64DC
		public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) => default; // 0x00000001897F5C50-0x00000001897F5CB8
		public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) => default; // 0x00000001897F5BE8-0x00000001897F5C50
		public SqlSingle ToSqlSingle() => default; // 0x00000001897F5E90-0x00000001897F5EF0
		public int CompareTo(object value) => default; // 0x00000001897F57C0-0x00000001897F58C0
		public int CompareTo(SqlDouble value) => default; // 0x00000001897F58C0-0x00000001897F59F8
		public override bool Equals(object value) => default; // 0x00000001897F59F8-0x00000001897F5B08
		public override int GetHashCode() => default; // 0x00000001897F5B08-0x00000001897F5B70
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897F5CB8-0x00000001897F5D94
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897F5D94-0x00000001897F5E90
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897F5B70-0x00000001897F5BE8
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50091
	{
		// Fields
		private static readonly int s_sizeOfGuid; // 0x00
		private static readonly int[] s_rgiGuidOrder; // 0x08
		private byte[] m_value; // 0x00
		public static readonly SqlGuid Null; // 0x10
	
		// Properties
		public bool IsNull { get => default; } // 0x0000000182361C20-0x0000000182361C30 
		public Guid Value { get => default; } // 0x00000001897F756C-0x00000001897F7610 
	
		// Constructors
		private SqlGuid(bool fNull) : this() {
			m_value = default;
		} // 0x000000018426F744-0x000000018426F750
		public SqlGuid(Guid g) : this() {
			m_value = default;
		} // 0x00000001897F7544-0x00000001897F756C
		static SqlGuid() {
			s_sizeOfGuid = default;
			s_rgiGuidOrder = default;
			Null = default;
		} // 0x00000001897F7460-0x00000001897F7544
	
		// Methods
		public static implicit operator SqlGuid(Guid x) => default; // 0x00000001897F7760-0x00000001897F7794
		public override string ToString() => default; // 0x00000001897F73F4-0x00000001897F7460
		private static EComparison Compare(SqlGuid x, SqlGuid y) => default; // 0x00000001897F6EFC-0x00000001897F6FF4
		public static SqlBoolean operator ==(SqlGuid x, SqlGuid y) => default; // 0x00000001897F7610-0x00000001897F76B8
		public static SqlBoolean operator <(SqlGuid x, SqlGuid y) => default; // 0x00000001897F7794-0x00000001897F7838
		public static SqlBoolean operator >(SqlGuid x, SqlGuid y) => default; // 0x00000001897F76B8-0x00000001897F7760
		public int CompareTo(object value) => default; // 0x00000001897F6D10-0x00000001897F6E00
		public int CompareTo(SqlGuid value) => default; // 0x00000001897F6E00-0x00000001897F6EFC
		public override bool Equals(object value) => default; // 0x00000001897F6FF4-0x00000001897F70EC
		public override int GetHashCode() => default; // 0x00000001897F70EC-0x00000001897F716C
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897F71E4-0x00000001897F72DC
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897F72DC-0x00000001897F73F4
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897F716C-0x00000001897F71E4
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50092
	{
		// Fields
		private bool m_fNotNull; // 0x00
		private short m_value; // 0x02
		private static readonly int s_MASKI2; // 0x00
		public static readonly SqlInt16 Null; // 0x04
		public static readonly SqlInt16 Zero; // 0x08
		public static readonly SqlInt16 MinValue; // 0x0C
		public static readonly SqlInt16 MaxValue; // 0x10
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public short Value { get => default; } // 0x00000001897F8030-0x00000001897F808C 
	
		// Constructors
		private SqlInt16(bool fNull) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D75520-0x0000000183D75530
		public SqlInt16(short value) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D68620-0x0000000183D68630
		static SqlInt16() {
			s_MASKI2 = default;
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897F7F78-0x00000001897F8030
	
		// Methods
		public static implicit operator SqlInt16(short x) => default; // 0x0000000183D75530-0x0000000183D75550
		public override string ToString() => default; // 0x00000001897F7F20-0x00000001897F7F78
		public static SqlInt16 operator -(SqlInt16 x) => default; // 0x00000001897F8878-0x00000001897F88F0
		public static SqlInt16 operator +(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F808C-0x00000001897F818C
		public static SqlInt16 operator -(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F8778-0x00000001897F8878
		public static SqlInt16 operator *(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F8648-0x00000001897F8778
		public static SqlInt16 operator /(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F818C-0x00000001897F82E8
		public static implicit operator SqlInt16(SqlByte x) => default; // 0x00000001897F8518-0x00000001897F85B0
		public static explicit operator SqlInt16(SqlInt64 x) => default; // 0x00000001897F8380-0x00000001897F8480
		public static SqlBoolean operator ==(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F82E8-0x00000001897F8380
		public static SqlBoolean operator <(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F85B0-0x00000001897F8648
		public static SqlBoolean operator >(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F8480-0x00000001897F8518
		public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F7C3C-0x00000001897F7C94
		public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) => default; // 0x00000001897F7BE4-0x00000001897F7C3C
		public SqlDouble ToSqlDouble() => default; // 0x00000001897F7E60-0x00000001897F7EC0
		public SqlInt64 ToSqlInt64() => default; // 0x00000001897F7EC0-0x00000001897F7F20
		public int CompareTo(object value) => default; // 0x00000001897F7838-0x00000001897F7924
		public int CompareTo(SqlInt16 value) => default; // 0x00000001897F7924-0x00000001897F7A14
		public override bool Equals(object value) => default; // 0x00000001897F7A14-0x00000001897F7B08
		public override int GetHashCode() => default; // 0x00000001897F7B08-0x00000001897F7B6C
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897F7C94-0x00000001897F7D70
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897F7D70-0x00000001897F7E60
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897F7B6C-0x00000001897F7BE4
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50093
	{
		// Fields
		private bool m_fNotNull; // 0x00
		private int m_value; // 0x04
		private static readonly long s_iIntMin; // 0x00
		private static readonly long s_lBitNotIntMax; // 0x08
		public static readonly SqlInt32 Null; // 0x10
		public static readonly SqlInt32 Zero; // 0x18
		public static readonly SqlInt32 MinValue; // 0x20
		public static readonly SqlInt32 MaxValue; // 0x28
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public int Value { get => default; } // 0x00000001897F9128-0x00000001897F91AC 
	
		// Constructors
		private SqlInt32(bool fNull) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D75550-0x0000000183D75560
		public SqlInt32(int value) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D68530-0x0000000183D68540
		static SqlInt32() {
			s_iIntMin = default;
			s_lBitNotIntMax = default;
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897F9054-0x00000001897F9128
	
		// Methods
		public static implicit operator SqlInt32(int x) => default; // 0x0000000183D75560-0x0000000183D75580
		public override string ToString() => default; // 0x00000001897F8FFC-0x00000001897F9054
		public static SqlInt32 operator -(SqlInt32 x) => default; // 0x00000001897F9AAC-0x00000001897F9B28
		public static SqlInt32 operator +(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F91AC-0x00000001897F92D0
		public static SqlInt32 operator -(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F998C-0x00000001897F9AAC
		public static SqlInt32 operator *(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F9850-0x00000001897F998C
		public static SqlInt32 operator /(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F92D0-0x00000001897F9444
		public static implicit operator SqlInt32(SqlByte x) => default; // 0x00000001897F9680-0x00000001897F971C
		public static implicit operator SqlInt32(SqlInt16 x) => default; // 0x00000001897F971C-0x00000001897F97B4
		public static explicit operator SqlInt32(SqlInt64 x) => default; // 0x00000001897F94E0-0x00000001897F95E4
		private static bool SameSignInt(int x, int y) => default; // 0x00000001897F8D60-0x00000001897F8D70
		public static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F9444-0x00000001897F94E0
		public static SqlBoolean operator <(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F97B4-0x00000001897F9850
		public static SqlBoolean operator >(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F95E4-0x00000001897F9680
		public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F8D04-0x00000001897F8D60
		public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) => default; // 0x00000001897F8CA8-0x00000001897F8D04
		public SqlDouble ToSqlDouble() => default; // 0x00000001897F8F3C-0x00000001897F8F9C
		public SqlInt64 ToSqlInt64() => default; // 0x00000001897F8F9C-0x00000001897F8FFC
		public int CompareTo(object value) => default; // 0x00000001897F89EC-0x00000001897F8ADC
		public int CompareTo(SqlInt32 value) => default; // 0x00000001897F88F0-0x00000001897F89EC
		public override bool Equals(object value) => default; // 0x00000001897F8ADC-0x00000001897F8BD4
		public override int GetHashCode() => default; // 0x00000001897F8BD4-0x00000001897F8C30
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897F8D70-0x00000001897F8E4C
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897F8E4C-0x00000001897F8F3C
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897F8C30-0x00000001897F8CA8
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50094
	{
		// Fields
		private bool m_fNotNull; // 0x00
		private long m_value; // 0x08
		private static readonly long s_lLowIntMask; // 0x00
		private static readonly long s_lHighIntMask; // 0x08
		public static readonly SqlInt64 Null; // 0x10
		public static readonly SqlInt64 Zero; // 0x20
		public static readonly SqlInt64 MinValue; // 0x30
		public static readonly SqlInt64 MaxValue; // 0x40
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public long Value { get => default; } // 0x00000001897FA550-0x00000001897FA5AC 
	
		// Constructors
		private SqlInt64(bool fNull) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D75510-0x0000000183D75520
		public SqlInt64(long value) : this() {
			m_fNotNull = default;
			m_value = default;
		} // 0x0000000183D68540-0x0000000183D68550
		static SqlInt64() {
			s_lLowIntMask = default;
			s_lHighIntMask = default;
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897FA45C-0x00000001897FA550
	
		// Methods
		public static implicit operator SqlInt64(long x) => default; // 0x0000000183D75580-0x0000000183D755A0
		public override string ToString() => default; // 0x00000001897FA404-0x00000001897FA45C
		public static SqlInt64 operator -(SqlInt64 x) => default; // 0x00000001897FB3DC-0x00000001897FB460
		public static SqlInt64 operator +(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FA5AC-0x00000001897FA6E0
		public static SqlInt64 operator -(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FB2A8-0x00000001897FB3DC
		public static SqlInt64 operator *(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FAF98-0x00000001897FB2A8
		public static SqlInt64 operator /(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FA6E0-0x00000001897FA848
		public static SqlInt64 operator %(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FAE30-0x00000001897FAF98
		public static implicit operator SqlInt64(SqlByte x) => default; // 0x00000001897FACF4-0x00000001897FAD9C
		public static implicit operator SqlInt64(SqlInt16 x) => default; // 0x00000001897FAC4C-0x00000001897FACF4
		public static implicit operator SqlInt64(SqlInt32 x) => default; // 0x00000001897FABA4-0x00000001897FAC4C
		public static explicit operator SqlInt64(SqlDecimal x) => default; // 0x00000001897FA8DC-0x00000001897FAB10
		private static bool SameSignLong(long x, long y) => default; // 0x00000001897FA018-0x00000001897FA02C
		public static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FA848-0x00000001897FA8DC
		public static SqlBoolean operator <(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FAD9C-0x00000001897FAE30
		public static SqlBoolean operator >(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897FAB10-0x00000001897FABA4
		public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897F9FB0-0x00000001897FA018
		public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) => default; // 0x00000001897F9F48-0x00000001897F9FB0
		public SqlByte ToSqlByte() => default; // 0x00000001897FA1F8-0x00000001897FA258
		public SqlDouble ToSqlDouble() => default; // 0x00000001897FA2D0-0x00000001897FA344
		public SqlInt16 ToSqlInt16() => default; // 0x00000001897FA344-0x00000001897FA3A4
		public SqlInt32 ToSqlInt32() => default; // 0x00000001897FA3A4-0x00000001897FA404
		public SqlDecimal ToSqlDecimal() => default; // 0x00000001897FA258-0x00000001897FA2D0
		public int CompareTo(object value) => default; // 0x00000001897F9C60-0x00000001897F9D60
		public int CompareTo(SqlInt64 value) => default; // 0x00000001897F9B28-0x00000001897F9C60
		public override bool Equals(object value) => default; // 0x00000001897F9D60-0x00000001897F9E70
		public override int GetHashCode() => default; // 0x00000001897F9E70-0x00000001897F9ED0
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897FA02C-0x00000001897FA108
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897FA108-0x00000001897FA1F8
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897F9ED0-0x00000001897F9F48
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50095
	{
		// Fields
		private bool _fNotNull; // 0x00
		private long _value; // 0x08
		internal static readonly int s_iMoneyScale; // 0x00
		private static readonly long s_lTickBase; // 0x08
		private static readonly double s_dTickBase; // 0x10
		private static readonly long s_minLong; // 0x18
		private static readonly long s_maxLong; // 0x20
		public static readonly SqlMoney Null; // 0x28
		public static readonly SqlMoney Zero; // 0x38
		public static readonly SqlMoney MinValue; // 0x48
		public static readonly SqlMoney MaxValue; // 0x58
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public decimal Value { get => default; } // 0x00000001897FC2FC-0x00000001897FC3A4 
	
		// Constructors
		private SqlMoney(bool fNull) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x0000000183D75510-0x0000000183D75520
		internal SqlMoney(long value, int ignored) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x0000000183D68540-0x0000000183D68550
		public SqlMoney(int value) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x00000001897FC0D0-0x00000001897FC130
		public SqlMoney(long value) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x00000001897FBFEC-0x00000001897FC0D0
		public SqlMoney(decimal value) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x00000001897FC130-0x00000001897FC2FC
		static SqlMoney() {
			s_iMoneyScale = default;
			s_lTickBase = default;
			s_dTickBase = default;
			s_minLong = default;
			s_maxLong = default;
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897FBE98-0x00000001897FBFEC
	
		// Methods
		public decimal ToDecimal() => default; // 0x00000001897FBB88-0x00000001897FBC84
		public double ToDouble() => default; // 0x00000001897FBC84-0x00000001897FBD04
		public static implicit operator SqlMoney(decimal x) => default; // 0x00000001897FC908-0x00000001897FC938
		public static implicit operator SqlMoney(long x) => default; // 0x00000001897FCA90-0x00000001897FCAD8
		public override string ToString() => default; // 0x00000001897FBDF0-0x00000001897FBE98
		public static SqlMoney operator -(SqlMoney x) => default; // 0x00000001897FCEE0-0x00000001897FCFC0
		public static SqlMoney operator +(SqlMoney x, SqlMoney y) => default; // 0x00000001897FC3A4-0x00000001897FC53C
		public static SqlMoney operator -(SqlMoney x, SqlMoney y) => default; // 0x00000001897FCD4C-0x00000001897FCEE0
		public static SqlMoney operator *(SqlMoney x, SqlMoney y) => default; // 0x00000001897FCC14-0x00000001897FCD4C
		public static SqlMoney operator /(SqlMoney x, SqlMoney y) => default; // 0x00000001897FC53C-0x00000001897FC674
		public static implicit operator SqlMoney(SqlByte x) => default; // 0x00000001897FC9E4-0x00000001897FCA90
		public static implicit operator SqlMoney(SqlInt16 x) => default; // 0x00000001897FC85C-0x00000001897FC908
		public static implicit operator SqlMoney(SqlInt32 x) => default; // 0x00000001897FC938-0x00000001897FC9E4
		public static implicit operator SqlMoney(SqlInt64 x) => default; // 0x00000001897FCAD8-0x00000001897FCB80
		public static explicit operator SqlMoney(SqlDecimal x) => default; // 0x00000001897FC708-0x00000001897FC7C8
		public static SqlBoolean operator ==(SqlMoney x, SqlMoney y) => default; // 0x00000001897FC674-0x00000001897FC708
		public static SqlBoolean operator <(SqlMoney x, SqlMoney y) => default; // 0x00000001897FCB80-0x00000001897FCC14
		public static SqlBoolean operator >(SqlMoney x, SqlMoney y) => default; // 0x00000001897FC7C8-0x00000001897FC85C
		public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) => default; // 0x00000001897FB8D4-0x00000001897FB93C
		public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) => default; // 0x00000001897FB86C-0x00000001897FB8D4
		public SqlDouble ToSqlDouble() => default; // 0x00000001897FBD7C-0x00000001897FBDF0
		public SqlDecimal ToSqlDecimal() => default; // 0x00000001897FBD04-0x00000001897FBD7C
		public int CompareTo(object value) => default; // 0x00000001897FB598-0x00000001897FB698
		public int CompareTo(SqlMoney value) => default; // 0x00000001897FB460-0x00000001897FB598
		public override bool Equals(object value) => default; // 0x00000001897FB698-0x00000001897FB7A8
		public override int GetHashCode() => default; // 0x00000001897FB7A8-0x00000001897FB7F4
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897FB93C-0x00000001897FBA6C
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897FBA6C-0x00000001897FBB88
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897FB7F4-0x00000001897FB86C
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50096
	{
		// Fields
		private bool _fNotNull; // 0x00
		private float _value; // 0x04
		public static readonly SqlSingle Null; // 0x00
		public static readonly SqlSingle Zero; // 0x08
		public static readonly SqlSingle MinValue; // 0x10
		public static readonly SqlSingle MaxValue; // 0x18
	
		// Properties
		public bool IsNull { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public float Value { get => default; } // 0x00000001897FD9F4-0x00000001897FDA50 
	
		// Constructors
		private SqlSingle(bool fNull) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x0000000183D75550-0x0000000183D75560
		public SqlSingle(float value) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x00000001897FD968-0x00000001897FD9F4
		public SqlSingle(double value) : this() {
			_fNotNull = default;
			_value = default;
		} // 0x00000001897FD910-0x00000001897FD968
		static SqlSingle() {
			Null = default;
			Zero = default;
			MinValue = default;
			MaxValue = default;
		} // 0x00000001897FD838-0x00000001897FD910
	
		// Methods
		public static implicit operator SqlSingle(float x) => default; // 0x00000001897FE1E4-0x00000001897FE20C
		public override string ToString() => default; // 0x00000001897FD7E0-0x00000001897FD838
		public static SqlSingle operator -(SqlSingle x) => default; // 0x00000001897FE580-0x00000001897FE604
		public static SqlSingle operator +(SqlSingle x, SqlSingle y) => default; // 0x00000001897FDA50-0x00000001897FDB68
		public static SqlSingle operator -(SqlSingle x, SqlSingle y) => default; // 0x00000001897FE468-0x00000001897FE580
		public static SqlSingle operator *(SqlSingle x, SqlSingle y) => default; // 0x00000001897FE350-0x00000001897FE468
		public static SqlSingle operator /(SqlSingle x, SqlSingle y) => default; // 0x00000001897FDB68-0x00000001897FDCE0
		public static implicit operator SqlSingle(SqlByte x) => default; // 0x00000001897FE140-0x00000001897FE1E4
		public static implicit operator SqlSingle(SqlInt16 x) => default; // 0x00000001897FE0A0-0x00000001897FE140
		public static implicit operator SqlSingle(SqlInt32 x) => default; // 0x00000001897FE20C-0x00000001897FE2B0
		public static implicit operator SqlSingle(SqlInt64 x) => default; // 0x00000001897FE000-0x00000001897FE0A0
		public static implicit operator SqlSingle(SqlMoney x) => default; // 0x00000001897FDEC4-0x00000001897FDF5C
		public static implicit operator SqlSingle(SqlDecimal x) => default; // 0x00000001897FDF5C-0x00000001897FE000
		public static explicit operator SqlSingle(SqlDouble x) => default; // 0x00000001897FDD8C-0x00000001897FDE24
		public static SqlBoolean operator ==(SqlSingle x, SqlSingle y) => default; // 0x00000001897FDCE0-0x00000001897FDD8C
		public static SqlBoolean operator <(SqlSingle x, SqlSingle y) => default; // 0x00000001897FE2B0-0x00000001897FE350
		public static SqlBoolean operator >(SqlSingle x, SqlSingle y) => default; // 0x00000001897FDE24-0x00000001897FDEC4
		public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) => default; // 0x00000001897FD54C-0x00000001897FD5A8
		public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) => default; // 0x00000001897FD4F0-0x00000001897FD54C
		public SqlDouble ToSqlDouble() => default; // 0x00000001897FD780-0x00000001897FD7E0
		public int CompareTo(object value) => default; // 0x00000001897FD228-0x00000001897FD318
		public int CompareTo(SqlSingle value) => default; // 0x00000001897FD12C-0x00000001897FD228
		public override bool Equals(object value) => default; // 0x00000001897FD318-0x00000001897FD410
		public override int GetHashCode() => default; // 0x00000001897FD410-0x00000001897FD478
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897FD5A8-0x00000001897FD684
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897FD684-0x00000001897FD780
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897FD478-0x00000001897FD4F0
	}

	[Flags]
	public enum SqlCompareOptions // TypeDefIndex: 50097
	{
		None = 0,
		IgnoreCase = 1,
		IgnoreNonSpace = 2,
		IgnoreKanaType = 8,
		IgnoreWidth = 16,
		BinarySort2 = 16384,
		BinarySort = 32768
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 50098
	{
		// Fields
		private string m_value; // 0x00
		private CompareInfo m_cmpInfo; // 0x08
		private int m_lcid; // 0x10
		private SqlCompareOptions m_flag; // 0x14
		private bool m_fNotNull; // 0x18
		public static readonly SqlString Null; // 0x00
		internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
		public static readonly int IgnoreCase; // 0x28
		public static readonly int IgnoreWidth; // 0x2C
		public static readonly int IgnoreNonSpace; // 0x30
		public static readonly int IgnoreKanaType; // 0x34
		public static readonly int BinarySort; // 0x38
		public static readonly int BinarySort2; // 0x3C
		private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
		private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
		internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
		internal static readonly int s_lcidUSEnglish; // 0x4C
		private static readonly int s_lcidBinary; // 0x50
	
		// Properties
		public bool IsNull { get => default; } // 0x0000000183D032E0-0x0000000183D032F0 
		public string Value { get => default; } // 0x00000001897FFA4C-0x00000001897FFAD0 
	
		// Constructors
		private SqlString(bool fNull) : this() {
			m_value = default;
			m_cmpInfo = default;
			m_lcid = default;
			m_flag = default;
			m_fNotNull = default;
		} // 0x00000001897FFA20-0x00000001897FFA4C
		public SqlString(string data, int lcid, SqlCompareOptions compareOptions) : this() {
			m_value = default;
			m_cmpInfo = default;
			m_lcid = default;
			m_flag = default;
			m_fNotNull = default;
		} // 0x00000001897FF840-0x00000001897FF8D0
		public SqlString(string data) : this() {
			m_value = default;
			m_cmpInfo = default;
			m_lcid = default;
			m_flag = default;
			m_fNotNull = default;
		} // 0x00000001897FF8D0-0x00000001897FF970
		private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) : this() {
			m_value = default;
			m_cmpInfo = default;
			m_lcid = default;
			m_flag = default;
			m_fNotNull = default;
		} // 0x00000001897FF970-0x00000001897FFA20
		static SqlString() {
			Null = default;
			s_unicodeEncoding = default;
			IgnoreCase = default;
			IgnoreWidth = default;
			IgnoreNonSpace = default;
			IgnoreKanaType = default;
			BinarySort = default;
			BinarySort2 = default;
			s_iDefaultFlag = default;
			s_iValidCompareOptionMask = default;
			s_iValidSqlCompareOptionMask = default;
			s_lcidUSEnglish = default;
			s_lcidBinary = default;
		} // 0x00000001897FF688-0x00000001897FF840
	
		// Methods
		private void SetCompareInfo() {} // 0x00000001897FF0C4-0x00000001897FF13C
		public static implicit operator SqlString(string x) => default; // 0x00000001897FFCC4-0x00000001897FFCE8
		public override string ToString() => default; // 0x00000001897FF598-0x00000001897FF5E4
		public static SqlString operator +(SqlString x, SqlString y) => default; // 0x00000001897FFAD0-0x00000001897FFC48
		private static int StringCompare(SqlString x, SqlString y) => default; // 0x00000001897FF13C-0x00000001897FF400
		private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) => default; // 0x00000001897FEBAC-0x00000001897FECC0
		public static SqlBoolean operator ==(SqlString x, SqlString y) => default; // 0x00000001897FFC48-0x00000001897FFCC4
		private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) {} // 0x00000001897FF5E4-0x00000001897FF688
		public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) => default; // 0x00000001897FE90C-0x00000001897FE9C0
		private bool FBinarySort() => default; // 0x00000001897FEE14-0x00000001897FEE60
		private static int CompareBinary(SqlString x, SqlString y) => default; // 0x00000001897FE74C-0x00000001897FE90C
		private static int CompareBinary2(SqlString x, SqlString y) => default; // 0x00000001897FE604-0x00000001897FE74C
		public int CompareTo(object value) => default; // 0x00000001897FE9C0-0x00000001897FEAD4
		public int CompareTo(SqlString value) => default; // 0x00000001897FEAD4-0x00000001897FEBAC
		public override bool Equals(object value) => default; // 0x00000001897FECC0-0x00000001897FEE14
		public override int GetHashCode() => default; // 0x00000001897FEE60-0x00000001897FF04C
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x00000001897FF400-0x00000001897FF4CC
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001897FF4CC-0x00000001897FF598
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x00000001897FF04C-0x00000001897FF0C4
	}

	internal enum EComparison // TypeDefIndex: 50099
	{
		LT = 0,
		LE = 1,
		EQ = 2,
		GE = 3,
		GT = 4,
		NE = 5
	}

	[Serializable]
	public class SqlTypeException : SystemException // TypeDefIndex: 50100
	{
		// Constructors
		public SqlTypeException() {} // 0x00000001897FFF44-0x00000001897FFF84
		public SqlTypeException(string message) {} // 0x00000001897FFF38-0x00000001897FFF44
		public SqlTypeException(string message, Exception e) {} // 0x00000001897FFF18-0x00000001897FFF38
		protected SqlTypeException(SerializationInfo si, StreamingContext sc) {} // 0x00000001897FFF84-0x00000001897FFFD8
	
		// Methods
		private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) => default; // 0x00000001897FFE54-0x00000001897FFF18
	}

	[Serializable]
	public sealed class SqlNullValueException : SqlTypeException // TypeDefIndex: 50101
	{
		// Constructors
		public SqlNullValueException() {} // 0x00000001897FD084-0x00000001897FD0AC
		public SqlNullValueException(string message) {} // 0x00000001897FD120-0x00000001897FD12C
		public SqlNullValueException(string message, Exception e) {} // 0x00000001897FD0AC-0x00000001897FD0CC
		private SqlNullValueException(SerializationInfo si, StreamingContext sc) {} // 0x00000001897FD0CC-0x00000001897FD120
	
		// Methods
		private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) => default; // 0x00000001897FCFC0-0x00000001897FD084
	}

	[Serializable]
	public sealed class SqlTruncateException : SqlTypeException // TypeDefIndex: 50102
	{
		// Constructors
		public SqlTruncateException() {} // 0x00000001897FFDCC-0x00000001897FFDF4
		public SqlTruncateException(string message) {} // 0x00000001897FFE48-0x00000001897FFE54
		public SqlTruncateException(string message, Exception e) {} // 0x00000001897FFDAC-0x00000001897FFDCC
		private SqlTruncateException(SerializationInfo si, StreamingContext sc) {} // 0x00000001897FFDF4-0x00000001897FFE48
	
		// Methods
		private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) => default; // 0x00000001897FFCE8-0x00000001897FFDAC
	}

	internal abstract class SqlStreamChars // TypeDefIndex: 50103
	{
		// Properties
		public abstract long Length { get; }
		public abstract long Position { get; }
	
		// Constructors
		protected SqlStreamChars() {} // Dummy constructor
	
		// Methods
		public abstract int Read(char[] buffer, int offset, int count);
		public abstract long Seek(long offset, SeekOrigin origin);
	}

	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 50104
	{
		// Fields
		private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x00
		private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x08
		private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
		private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
		private MethodInfo _createSqlReaderMethodInfo; // 0x10
		private bool _fNotNull; // 0x18
		private Stream _stream; // 0x20
		private bool _firstCreateReader; // 0x28
	
		// Properties
		private static MethodInfo CreateSqlReaderMethodInfo { get => default; } // 0x0000000189801604-0x0000000189801D74 
		public bool IsNull { get => default; } // 0x0000000183D032E0-0x0000000183D032F0 
	
		// Constructors
		public SqlXml() {} // 0x00000001898015FC-0x0000000189801604
		static SqlXml() {} // 0x00000001898014D4-0x00000001898015FC
	
		// Methods
		public XmlReader CreateReader() => default; // 0x0000000189800E08-0x0000000189800F50
		internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false /* Metadata: 0x01FBECDA */, bool throwTargetInvocationExceptions = false /* Metadata: 0x01FBECDB */) => default; // 0x0000000189801004-0x000000018980118C
		private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() => default; // 0x0000000189800F50-0x0000000189801004
		private void SetNull() {} // 0x0000000189801204-0x000000018980122C
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader r) {} // 0x000000018980122C-0x00000001898013C8
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x00000001898013C8-0x00000001898014D4
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) => default; // 0x000000018980118C-0x0000000189801204
	}

	internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 50105
	{
		// Fields
		private Stream _stream; // 0x28
		private long _lPosition; // 0x30
		private bool _isClosed; // 0x38
	
		// Properties
		public override bool CanRead { get => default; } // 0x0000000189800BD4-0x0000000189800C0C 
		public override bool CanSeek { get => default; } // 0x0000000189800C0C-0x0000000189800C44 
		public override bool CanWrite { get => default; } // 0x0000000189800C44-0x0000000189800C7C 
		public override long Length { get => default; } // 0x0000000189800C7C-0x0000000189800CE4 
		public override long Position { get => default; set {} } // 0x0000000189800CE4-0x0000000189800D38 0x0000000189800D38-0x0000000189800E08
	
		// Constructors
		public SqlXmlStreamWrapper() {} // Dummy constructor
		internal SqlXmlStreamWrapper(Stream stream) {} // 0x0000000189800B78-0x0000000189800BD4
	
		// Methods
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x00000001898003CC-0x0000000189800614
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x00000001898001B4-0x00000001898003CC
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189800964-0x0000000189800B78
		public override int ReadByte() => default; // 0x00000001898000B4-0x00000001898001B4
		public override void WriteByte(byte value) {} // 0x000000018980089C-0x0000000189800964
		public override void SetLength(long value) {} // 0x0000000189800614-0x0000000189800698
		public override void Flush() {} // 0x000000018980002C-0x0000000189800048
		protected override void Dispose(bool disposing) {} // 0x00000001897FFFD8-0x000000018980002C
		private void ThrowIfStreamCannotSeek(string method) {} // 0x000000018980071C-0x00000001898007A0
		private void ThrowIfStreamCannotRead(string method) {} // 0x0000000189800698-0x000000018980071C
		private void ThrowIfStreamCannotWrite(string method) {} // 0x00000001898007A0-0x0000000189800824
		private void ThrowIfStreamClosed(string method) {} // 0x0000000189800824-0x000000018980089C
		private bool IsStreamClosed() => default; // 0x0000000189800048-0x00000001898000B4
	}
}
