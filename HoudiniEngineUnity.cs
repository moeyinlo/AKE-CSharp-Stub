/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using HoudiniEngineUnity;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.Splines;
using UnityEngine.Tilemaps;

// Image 18: HoudiniEngineUnity.dll - Assembly: HoudiniEngineUnity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52896-53342
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class __f__AnonymousType0<_owner_j__TPar, _houdiniVersionRequired_j__TPar> // TypeDefIndex: 52897
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _owner_j__TPar _owner_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _houdiniVersionRequired_j__TPar _houdiniVersionRequired_i__Field;

	// Properties
	public _owner_j__TPar owner { get; }
	public _houdiniVersionRequired_j__TPar houdiniVersionRequired { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType0(_owner_j__TPar owner, _houdiniVersionRequired_j__TPar houdiniVersionRequired);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

public class HEU_BoundingVolume : MonoBehaviour // TypeDefIndex: 52898
{
	// Properties
	public Collider BoundingCollider { get; } // 0x0000000189D38148-0x0000000189D38184 

	// Constructors
	public HEU_BoundingVolume(); // 0x0000000185393520-0x0000000185393538

	// Methods
	public List<GameObject> GetAllIntersectingObjects(); // 0x0000000189D37F10-0x0000000189D38148
}

public class HEU_ExampleEvergreenQuery // TypeDefIndex: 52899
{
	// Constructors
	public HEU_ExampleEvergreenQuery(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public static void StartQuery(); // 0x0000000189D3D364-0x0000000189D3D544
	public static HEU_HoudiniAsset QueryHoudiniAsset(GameObject rootGO); // 0x0000000189D3D05C-0x0000000189D3D1D8
	public static void CookAsset(HEU_HoudiniAsset houdiniAsset); // 0x0000000189D3CD3C-0x0000000189D3CD50
	public static void ChangeParmsAndCook(HEU_HoudiniAsset houdiniAsset); // 0x0000000189D3C9CC-0x0000000189D3CD3C
	public static void QueryObjects(HEU_HoudiniAsset houdiniAsset); // 0x0000000189D3D1D8-0x0000000189D3D254
	public static void QueryGeoParts(HEU_SessionBase session, ref HAPI_GeoInfo geoInfo); // 0x0000000189D3CF98-0x0000000189D3D05C
	public static void QueryPartAttributeByOwner(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner owner, int count, StringBuilder sb); // 0x0000000189D3D254-0x0000000189D3D364
	public static void QueryAttributeByStorageType(HEU_SessionBase session, int geoID, int partID, ref HAPI_AttributeInfo attrInfo, string attrName); // 0x0000000189D3CD50-0x0000000189D3CECC
	public static void QueryAttribute(HEU_HoudiniAsset houdiniAsset, string objName, string geoName, int partID, string attrName); // 0x0000000189D3CECC-0x0000000189D3CF98
}

[ExecuteInEditMode]
public class HEU_ExampleInstanceCustomAttribute : MonoBehaviour // TypeDefIndex: 52900
{
	// Constructors
	public HEU_ExampleInstanceCustomAttribute(); // 0x0000000185393520-0x0000000185393538

	// Methods
	private void InstancerCallback(); // 0x0000000189D3D544-0x0000000189D3D8C4
	private static void LogArray<T>(string name, T[] arr, int tupleSize);
	private static void LogAttr(HEU_OutputAttribute outAttr); // 0x0000000189D3D8C4-0x0000000189D3D9F0
}

[ExecuteInEditMode]
public class HEU_ScriptCallbackExample : MonoBehaviour // TypeDefIndex: 52901
{
	// Fields
	public string _msg; // 0x18

	// Constructors
	public HEU_ScriptCallbackExample(); // 0x0000000185393520-0x0000000185393538

	// Methods
	private void AssetCallbackWithMsg(string msg); // 0x0000000189D53BE8-0x0000000189D53C6C
	private void AssetCallbackNoMsg(); // 0x0000000189D53B94-0x0000000189D53BE8
}

public class HEU_ScriptMeshInputUVLayoutExample // TypeDefIndex: 52903
{
	// Nested types
	public enum OutputMode // TypeDefIndex: 52902
	{
		COPY = 0,
		REPLACE = 1
	}

	// Constructors
	public HEU_ScriptMeshInputUVLayoutExample(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public static void ApplyUVLayoutTo(GameObject[] gameObjects, OutputMode outputMode, string output_name_suffix); // 0x0000000189D53C6C-0x0000000189D53DCC
}

public class HEU_ScriptParameterExample : MonoBehaviour // TypeDefIndex: 52904
{
	// Fields
	public GameObject _evergreenGameObject; // 0x18
	private HEU_HoudiniAsset _evergreenAsset; // 0x20
	public float _updateRate; // 0x28
	public float _scale; // 0x2C

	// Constructors
	public HEU_ScriptParameterExample(); // 0x0000000189D53DCC-0x0000000189D53DF0
}

public class HEU_AssetEventReceiverTest : MonoBehaviour // TypeDefIndex: 52905
{
	// Constructors
	public HEU_AssetEventReceiverTest(); // 0x0000000185393520-0x0000000185393538

	// Methods
	public void ReloadCallback(HEU_ReloadEventData Data); // 0x0000000189D36ED8-0x0000000189D3703C
	public void CookedCallback(HEU_CookedEventData Data); // 0x0000000189D36D74-0x0000000189D36ED8
	public void BakedCallback(HEU_BakedEventData Data); // 0x0000000189D36C10-0x0000000189D36D74
}

namespace HoudiniEngineUnity
{
	public enum HEU_AssetEventType // TypeDefIndex: 52906
	{
		UNKNOWN = 0,
		RELOAD = 1,
		COOK = 2,
		BAKE_NEW = 3,
		BAKE_UPDATE = 4
	}

	public class HEU_AssetEventData // TypeDefIndex: 52907
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public bool CookSuccess; // 0x18
		public List<GameObject> OutputObjects; // 0x20
		public HEU_AssetEventType EventType; // 0x28
	
		// Constructors
		public HEU_AssetEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects); // 0x0000000184044A30-0x0000000184044A60
	}

	public class HEU_ReloadEventData : HEU_AssetEventData // TypeDefIndex: 52908
	{
		// Constructors
		public HEU_ReloadEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects); // 0x0000000189D53B70-0x0000000189D53B94
	}

	public class HEU_CookedEventData : HEU_AssetEventData // TypeDefIndex: 52909
	{
		// Constructors
		public HEU_CookedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects); // 0x0000000189D381C0-0x0000000189D381E4
	}

	public class HEU_BakedEventData : HEU_AssetEventData // TypeDefIndex: 52910
	{
		// Fields
		public bool IsNewBake; // 0x30
	
		// Constructors
		public HEU_BakedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects, bool isNewBake); // 0x0000000189D37EE0-0x0000000189D37F10
	}

	public class HEU_PreAssetEventData // TypeDefIndex: 52911
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public HEU_AssetEventType AssetType; // 0x18
	
		// Constructors
		public HEU_PreAssetEventData(HEU_HoudiniAsset asset, HEU_AssetEventType assetType); // 0x0000000183B46FF0-0x0000000183B47040
	}

	[Serializable]
	public class HEU_ReloadDataEvent : UnityEvent<HEU_ReloadEventData> // TypeDefIndex: 52912
	{
		// Constructors
		public HEU_ReloadDataEvent(); // 0x0000000189D53B34-0x0000000189D53B70
	}

	[Serializable]
	public class HEU_CookedDataEvent : UnityEvent<HEU_CookedEventData> // TypeDefIndex: 52913
	{
		// Constructors
		public HEU_CookedDataEvent(); // 0x0000000189D38184-0x0000000189D381C0
	}

	[Serializable]
	public class HEU_BakedDataEvent : UnityEvent<HEU_BakedEventData> // TypeDefIndex: 52914
	{
		// Constructors
		public HEU_BakedDataEvent(); // 0x0000000189D37EA4-0x0000000189D37EE0
	}

	[Serializable]
	public class HEU_PreAssetEvent : UnityEvent<HEU_PreAssetEventData> // TypeDefIndex: 52915
	{
		// Constructors
		public HEU_PreAssetEvent(); // 0x0000000189D53A38-0x0000000189D53A74
	}

	[Serializable]
	public class HEU_AssetPreset // TypeDefIndex: 52916
	{
		// Fields
		public char[] _identifier; // 0x10
		public int _version; // 0x18
		public string _assetOPName; // 0x20
		public byte[] _parameterPreset; // 0x28
		public List<string> _curveNames; // 0x30
		public List<byte[]> _curvePresets; // 0x38
		[OptionalField(VersionAdded = 2)]
		public List<HEU_InputPreset> inputPresets; // 0x40
		[OptionalField(VersionAdded = 3)]
		public List<HEU_VolumeCachePreset> volumeCachePresets; // 0x48
	
		// Constructors
		public HEU_AssetPreset(); // 0x0000000189D37BB0-0x0000000189D37D08
	}

	[Serializable]
	public class HEU_InputPreset // TypeDefIndex: 52917
	{
		// Fields
		[SerializeField]
		internal HEU_InputNode.InputObjectType _inputObjectType; // 0x10
		public List<HEU_InputObjectPreset> _inputObjectPresets; // 0x18
		public string _inputAssetName; // 0x20
		public int _inputIndex; // 0x28
		public string _inputName; // 0x30
		public bool _keepWorldTransform; // 0x38
		public bool _packGeometryBeforeMerging; // 0x39
		[OptionalField(VersionAdded = 4)]
		public List<HEU_InputAssetPreset> _inputAssetPresets; // 0x40
	
		// Properties
		public HEU_InputObjectTypeWrapper InputObjectType { get; set; } // 0x0000000189D53A0C-0x0000000189D53A18 0x0000000189D53A18-0x0000000189D53A38
	
		// Constructors
		public HEU_InputPreset(); // 0x0000000189D5394C-0x0000000189D53A0C
	}

	[Serializable]
	public class HEU_InputObjectPreset // TypeDefIndex: 52918
	{
		// Fields
		public string _gameObjectName; // 0x10
		public bool _isSceneObject; // 0x18
		[NonSerialized]
		public GameObject _gameObject; // 0x20
		public bool _useTransformOffset; // 0x28
		public Vector3 _translateOffset; // 0x2C
		public Vector3 _rotateOffset; // 0x38
		public Vector3 _scaleOffset; // 0x44
	
		// Constructors
		public HEU_InputObjectPreset(); // 0x0000000189D538EC-0x0000000189D5394C
	}

	[Serializable]
	public class HEU_InputAssetPreset // TypeDefIndex: 52919
	{
		// Fields
		public string _gameObjectName; // 0x10
	
		// Constructors
		public HEU_InputAssetPreset(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class HEU_VolumeLayerPreset // TypeDefIndex: 52920
	{
		// Fields
		public string _layerName; // 0x10
		public float _strength; // 0x18
		public bool _uiExpanded; // 0x1C
		[OptionalField(VersionAdded = 5)]
		public int _tile; // 0x20
	
		// Constructors
		public HEU_VolumeLayerPreset(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class HEU_VolumeCachePreset // TypeDefIndex: 52921
	{
		// Fields
		public string _objName; // 0x10
		public string _geoName; // 0x18
		public bool _uiExpanded; // 0x20
		public List<HEU_VolumeLayerPreset> _volumeLayersPresets; // 0x28
		[OptionalField(VersionAdded = 6)]
		public string _terrainDataPath; // 0x30
		[OptionalField(VersionAdded = 6)]
		public int _tile; // 0x38
	
		// Constructors
		public HEU_VolumeCachePreset(); // 0x0000000189D54218-0x0000000189D54290
	}

	[Serializable]
	internal class HEU_RecookPreset // TypeDefIndex: 52922
	{
		// Fields
		public List<HEU_VolumeCachePreset> _volumeCachePresets; // 0x10
		public List<HEU_InputPreset> _inputPresets; // 0x18
	
		// Constructors
		public HEU_RecookPreset(); // 0x0000000189D53A74-0x0000000189D53B34
	}

	public static class HEU_AssetPresetUtility // TypeDefIndex: 52923
	{
		// Fields
		public static char[] PRESET_IDENTIFIER; // 0x00
		public static int PRESET_VERSION; // 0x08
	
		// Constructors
		static HEU_AssetPresetUtility(); // 0x0000000189D37B2C-0x0000000189D37BB0
	
		// Methods
		public static void SaveAssetPresetToFile(HEU_HoudiniAsset asset, string filePath); // 0x0000000189D375E8-0x0000000189D37B2C
		public static void LoadPresetFileIntoAssetAndCook(HEU_HoudiniAsset asset, string filePath); // 0x0000000189D3703C-0x0000000189D375E8
	}

	public class HEU_Vector3SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 52924
	{
		// Constructors
		public HEU_Vector3SerializationSurrogate(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context); // 0x0000000189D53FC0-0x0000000189D54088
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector); // 0x0000000189D54088-0x0000000189D54218
	}

	public class HEU_Vector2SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 52925
	{
		// Constructors
		public HEU_Vector2SerializationSurrogate(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context); // 0x0000000189D53DF0-0x0000000189D53E94
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector); // 0x0000000189D53E94-0x0000000189D53FC0
	}

	internal class HEU_AssetSerializedMetaData : ScriptableObject, IEquivable<HEU_AssetSerializedMetaData> // TypeDefIndex: 52926
	{
		// Fields
		[SerializeField]
		private bool _softDeleted; // 0x18
		[SerializeField]
		private Dictionary<string, List<CurveNodeData>> _savedCurveNodeData; // 0x20
		[SerializeField]
		private Dictionary<string, HEU_InputCurveInfo> _savedInputCurveInfo; // 0x28
	
		// Properties
		public bool SoftDeleted { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public Dictionary<string, List<CurveNodeData>> SavedCurveNodeData { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Dictionary<string, HEU_InputCurveInfo> SavedInputCurveInfo { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		public HEU_AssetSerializedMetaData(); // 0x0000000189D37D9C-0x0000000189D37E64
	
		// Methods
		public bool IsEquivalentTo(HEU_AssetSerializedMetaData other); // 0x0000000189D37D08-0x0000000189D37D9C
	}

	internal class HEU_AssetUpdater // TypeDefIndex: 52927
	{
		// Constructors
		static HEU_AssetUpdater(); // 0x00000001841E1670-0x00000001841E1680
		public HEU_AssetUpdater(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static void OnBeforeAssemblyReload(); // 0x0000000189D37E64-0x0000000189D37EA4
		private static void Update(); // 0x00000001841E1670-0x00000001841E1680
		public static void AddAssetForUpdate(HEU_HoudiniAsset asset); // 0x00000001841E1670-0x00000001841E1680
		public static void RemoveAsset(HEU_HoudiniAsset asset); // 0x00000001841E1670-0x00000001841E1680
		public static void AddNodeSyncForUpdate(HEU_BaseSync nodeSync); // 0x00000001841E1670-0x00000001841E1680
		public static void RemoveNodeSync(HEU_BaseSync nodeSync); // 0x00000001841E1670-0x00000001841E1680
		private static void OnPrefabInstanceUpdate(GameObject instance); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class CurveNodeData : IEquivable<CurveNodeData> // TypeDefIndex: 52928
	{
		// Fields
		[SerializeField]
		public Vector3 position; // 0x10
		[SerializeField]
		public Vector3 rotation; // 0x1C
		[SerializeField]
		public Vector3 scale; // 0x28
		[HideInInspector]
		[SerializeField]
		public int curveCountIndex; // 0x34
	
		// Constructors
		public CurveNodeData(); // 0x0000000189D36A84-0x0000000189D36AE4
		public CurveNodeData(Vector3 position); // 0x0000000189D36A14-0x0000000189D36A84
		public CurveNodeData(Vector3 position, Quaternion rotation); // 0x0000000189D36AE4-0x0000000189D36B6C
		public CurveNodeData(Vector3 position, Quaternion rotation, Vector3 scale); // 0x0000000189D36B6C-0x0000000189D36C10
		public CurveNodeData(CurveNodeData other); // 0x0000000189D36974-0x0000000189D36A14
	
		// Methods
		public Quaternion GetRotation(); // 0x0000000189D367A8-0x0000000189D367E4
		public bool IsEquivalentTo(CurveNodeData other); // 0x0000000189D367E4-0x0000000189D36974
	}

	[Serializable]
	public class HEU_InputCurveInfo // TypeDefIndex: 52929
	{
		// Fields
		public HAPI_CurveType curveType; // 0x10
		[Range(2f, 11f)]
		public int order; // 0x14
		public bool closed; // 0x18
		public bool reverse; // 0x19
		public HAPI_InputCurveMethod inputMethod; // 0x1C
		public HAPI_InputCurveParameterization breakpointParameterization; // 0x20
	
		// Constructors
		public HEU_InputCurveInfo(); // 0x0000000184DA2680-0x0000000184DA2690
	
		// Methods
		public static HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HAPI_InputCurveInfo curveInfo); // 0x0000000189D53690-0x0000000189D53714
		public static string[] GetCurveTypeNames(); // 0x0000000189D537BC-0x0000000189D53864
		public static string[] GetInputMethodNames(); // 0x0000000189D53864-0x0000000189D538EC
		public static string[] GetBreakpointParameterizationNames(); // 0x0000000189D53714-0x0000000189D537BC
	}

	[Serializable]
	public enum HEU_CurveDataType // TypeDefIndex: 52930
	{
		INVALID = 0,
		GEO_COORDS_PARAM = 1,
		HAPI_COORDS_PARAM = 2,
		POSITION_ATTRIBUTE = 3
	}

	public class HEU_Curve : ScriptableObject, IHEU_Curve, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Curve> // TypeDefIndex: 52938
	{
		// Fields
		[NonSerialized]
		private int _geoID; // 0x18
		[NonSerialized]
		private int _partID; // 0x1C
		[SerializeField]
		private List<CurveNodeData> _curveNodeData; // 0x20
		[SerializeField]
		private Vector3[] _vertices; // 0x28
		[SerializeField]
		private bool _isEditable; // 0x30
		[SerializeField]
		private HEU_Parameters _parameters; // 0x38
		[SerializeField]
		private bool _bUploadParameterPreset; // 0x40
		[SerializeField]
		private string _curveName; // 0x48
		[SerializeField]
		private GameObject _targetGameObject; // 0x50
		[SerializeField]
		private bool _isGeoCurve; // 0x58
		[SerializeField]
		private CurveEditState _editState; // 0x5C
		public static Interaction PreferredNextInteractionMode; // 0x00
		[SerializeField]
		private HEU_HoudiniAsset _parentAsset; // 0x60
		[SerializeField]
		private bool _bIsInputCurve; // 0x68
		[SerializeField]
		private bool _bIsPartCurve; // 0x69
		[SerializeField]
		private bool _cachedCurveInfoValid; // 0x6A
		[SerializeField]
		private int[] _cachedCurveCounts; // 0x70
		private int[] _cachedCurveCountSums; // 0x78
		[SerializeField]
		private HEU_CurveDataType _curveDataType; // 0x80
		[SerializeField]
		private HEU_InputCurveInfo _inputCurveInfo; // 0x88
	
		// Properties
		public GameObject TargetGameObject { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public int GeoID { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public int PartID { get; } // 0x0000000184D86310-0x0000000184D86320 
		public List<CurveNodeData> CurveNodeData { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public HEU_Parameters Parameters { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public string CurveName { get; } // 0x0000000184D86200-0x0000000184D86210 
		public bool IsInputCurve { get; } // 0x0000000184D86B40-0x0000000184D86B50 
		public bool IsPartCurve { get; } // 0x0000000184D86B10-0x0000000184D86B20 
		public HEU_InputCurveInfo InputCurveInfo { get; } // 0x0000000184D861F0-0x0000000184D86200 
		public CurveEditState EditState { get; } // 0x0000000184D86560-0x0000000184D86570 
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000184D86280-0x0000000184D86290 
		public HEU_CurveDataType CurveDataType { get; } // 0x0000000184D863A0-0x0000000184D863B0 
	
		// Nested types
		public enum CurveEditState // TypeDefIndex: 52931
		{
			INVALID = 0,
			GENERATED = 1,
			EDITING = 2,
			REQUIRES_GENERATION = 3
		}
	
		public enum Interaction // TypeDefIndex: 52932
		{
			VIEW = 0,
			ADD = 1,
			EDIT = 2
		}
	
		internal enum CurveDrawCollision // TypeDefIndex: 52933
		{
			COLLIDERS = 0,
			LAYERMASK = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0 // TypeDefIndex: 52934
		{
			// Fields
			public List<Vector3> points; // 0x10
	
			// Constructors
			public __c__DisplayClass60_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetAllPoints_b__0(CurveNodeData transform); // 0x0000000189D54290-0x0000000189D54300
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_0 // TypeDefIndex: 52935
		{
			// Fields
			public List<Vector3> positions; // 0x10
			public bool hasRotations; // 0x18
			public List<Quaternion> rotations; // 0x20
			public bool hasScales; // 0x28
			public List<Vector3> scales; // 0x30
			public List<int> curveCountIndices; // 0x38
	
			// Constructors
			public __c__DisplayClass87_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _UpdateCurveInputForCurveParts_b__0(CurveNodeData data); // 0x0000000189D54300-0x0000000189D54420
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass88_0 // TypeDefIndex: 52936
		{
			// Fields
			public List<Vector3> positions; // 0x10
			public List<Quaternion> rotations; // 0x18
			public List<Vector3> scales; // 0x20
	
			// Constructors
			public __c__DisplayClass88_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _UpdateCurveInputForCustomAttributes_b__0(CurveNodeData data); // 0x0000000189D54420-0x0000000189D54510
			internal void _UpdateCurveInputForCustomAttributes_b__1(int nIndex1, int nIndex2, float fCoeff, int nInsertIndex); // 0x0000000189D54510-0x0000000189D54800
			internal void _UpdateCurveInputForCustomAttributes_b__2(int nIndex, int nInsertIndex); // 0x0000000189D54800-0x0000000189D549F8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 52937
		{
			// Fields
			public List<Vector3> rotations; // 0x10
			public List<Vector3> scales; // 0x18
	
			// Constructors
			public __c__DisplayClass90_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _UpdatePoints_b__0(CurveNodeData data); // 0x0000000189D549F8-0x0000000189D54A94
		}
	
		// Constructors
		public HEU_Curve(); // 0x0000000189D3C944-0x0000000189D3C9CC
	
		// Methods
		internal void SetUploadParameterPreset(bool bValue); // 0x0000000182D480B0-0x0000000182D480C0
		public HEU_SessionBase GetSession(); // 0x0000000189D39D50-0x0000000189D39DE4
		public void Recook(); // 0x0000000189D3AB9C-0x0000000189D3AC08
		public void Rebuild(); // 0x0000000189D3AB34-0x0000000189D3AB9C
		public bool IsEditable(); // 0x0000000184D865F0-0x0000000184D86600
		public bool IsGeoCurve(); // 0x0000000184D86F70-0x0000000184D86F80
		public void SetCurveName(string name); // 0x0000000189D3AE50-0x0000000189D3AED0
		public void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x02331E76 */); // 0x0000000189D3B168-0x0000000189D3B23C
		public void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02331E77 */); // 0x0000000189D3B024-0x0000000189D3B168
		public void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x02331E78 */); // 0x0000000189D3AED0-0x0000000189D3AF54
		public Vector3 GetCurvePoint(int pointIndex); // 0x0000000189D39638-0x0000000189D396E0
		public List<CurveNodeData> GetAllPointTransforms(); // 0x0000000184D862C0-0x0000000184D862D0
		public List<Vector3> GetAllPoints(); // 0x0000000189D39400-0x0000000189D39510
		public int GetNumPoints(); // 0x0000000189D397C0-0x0000000189D39800
		public void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x02331E79 */); // 0x0000000189D3A0D8-0x0000000189D3A1D0
		public void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02331E7A */); // 0x0000000189D3A030-0x0000000189D3A0D8
		public void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x02331E7B */); // 0x0000000189D38280-0x0000000189D38378
		public void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02331E7C */); // 0x0000000189D381E4-0x0000000189D38280
		public void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x02331E7D */); // 0x0000000189D3AC08-0x0000000189D3ACA0
		public void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x02331E7E */); // 0x0000000189D38378-0x0000000189D38404
		public void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x02331E7F */); // 0x0000000189D3AAE0-0x0000000189D3AB34
		public void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x02331E80 */); // 0x0000000189D3AE1C-0x0000000189D3AE50
		public Vector3 GetTransformedPoint(int pointIndex); // 0x0000000189D39DE4-0x0000000189D39EAC
		public List<Vector3> GetTransformedPoints(); // 0x0000000189D39EAC-0x0000000189D39FC0
		public List<CurveNodeData> DuplicateCurveNodeData(); // 0x0000000189D38AC4-0x0000000189D38C88
		internal static HEU_Curve CreateSetupCurve(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool isEditable, string curveName, int geoID, int partID, bool bGeoCurve); // 0x0000000189D38404-0x0000000189D387A0
		private void UsePreviousCurveData(string curveName); // 0x0000000189D3C6D8-0x0000000189D3C944
		private HEU_CurveDataType GetCurveDataType(HEU_SessionBase session); // 0x0000000189D395F0-0x0000000189D39638
		internal bool ShouldKeepNode(HEU_SessionBase session); // 0x0000000189D3B23C-0x0000000189D3B294
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02331E81 */); // 0x0000000189D387A0-0x0000000189D389CC
		internal void UploadParameterPreset(HEU_SessionBase session, int geoID, HEU_HoudiniAsset parentAsset); // 0x0000000189D3C574-0x0000000189D3C65C
		internal void ResetCurveParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x0000000189D3ACA0-0x0000000189D3AD60
		internal void SetCurveParameterPreset(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, byte[] parameterPreset); // 0x0000000189D3AF54-0x0000000189D3B024
		internal void UpdateCurve(HEU_SessionBase session, int partId); // 0x0000000189D3BD30-0x0000000189D3BE4C
		private static int[] GetCurveCounts(HEU_SessionBase session, int geoId, int partID); // 0x0000000189D39580-0x0000000189D395F0
		internal void GenerateMesh(GameObject inGameObject, HEU_SessionBase session); // 0x0000000189D39030-0x0000000189D39400
		internal void GenerateMeshForSingleObject(GameObject targetObject, Vector3[] vertexList); // 0x0000000189D38C88-0x0000000189D39030
		internal void OnPresyncParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x0000000189D3A4E8-0x0000000189D3A520
		internal static int GetOrderForCurveType(int requestedOrder, HAPI_CurveType curveType); // 0x0000000189D39800-0x0000000189D3984C
		internal bool UpdateCurveInputForCurveParts(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x0000000189D3B444-0x0000000189D3B994
		internal bool UpdateCurveInputForCustomAttributes(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x0000000189D3B994-0x0000000189D3BD30
		internal void SyncFromParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bNewCurve); // 0x0000000189D3B294-0x0000000189D3B33C
		private void UpdatePoints(HEU_SessionBase session); // 0x0000000189D3BE4C-0x0000000189D3C574
		internal void ProjectToCollidersInternal(HEU_HoudiniAsset parentAsset, Vector3 rayDirection, float rayDistance); // 0x0000000189D3A520-0x0000000189D3AAE0
		public static string GetPointsString(List<CurveNodeData> points); // 0x0000000189D39AC4-0x0000000189D39D50
		public static string GetPointsString(List<Vector3> points); // 0x0000000189D3984C-0x0000000189D39AC4
		internal void SetEditState(CurveEditState editState); // 0x0000000184D865C0-0x0000000184D865D0
		internal Vector3 GetTransformedPosition(Vector3 inPosition); // 0x0000000189D39FC0-0x0000000189D3A030
		internal Vector3 GetInvertedTransformedPosition(Vector3 inPosition); // 0x0000000189D39750-0x0000000189D397C0
		internal Vector3 GetInvertedTransformedDirection(Vector3 inPosition); // 0x0000000189D396E0-0x0000000189D39750
		internal Vector3[] GetVertices(); // 0x0000000184D86240-0x0000000184D86250
		internal void SetCurveGeometryVisibilityInternal(bool bVisible); // 0x0000000189D3AD60-0x0000000189D3AE1C
		internal void DownloadPresetData(HEU_SessionBase session); // 0x0000000189D38A48-0x0000000189D38AC4
		internal void UploadPresetData(HEU_SessionBase session); // 0x0000000189D3C65C-0x0000000189D3C6D8
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session); // 0x0000000189D389CC-0x0000000189D38A48
		private void UpdateCachedCurveInfo(HEU_SessionBase session, bool copyCurveSettings); // 0x0000000189D3B33C-0x0000000189D3B444
		internal int GetCurveCountIndexFromPositionIndex(int positionIndex); // 0x0000000189D39510-0x0000000189D39580
		private static bool IsMeshCurve(HEU_SessionBase session, int geoID, int partID); // 0x0000000189D3A4C0-0x0000000189D3A4E8
		public bool IsEquivalentTo(HEU_Curve other); // 0x0000000189D3A1D0-0x0000000189D3A4C0
	}

	[Serializable]
	public class HEU_GeneratedOutput : IEquivable<HEU_GeneratedOutput> // TypeDefIndex: 52939
	{
		// Fields
		public HEU_GeneratedOutputData _outputData; // 0x10
		public List<HEU_GeneratedOutputData> _childOutputs; // 0x18
		[SerializeField]
		private bool isInstancer; // 0x20
	
		// Properties
		public bool IsInstancer { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
	
		// Constructors
		public HEU_GeneratedOutput(); // 0x0000000189D3EE84-0x0000000189D3EF30
	
		// Methods
		public static void ResetMaterialOverrides(HEU_GeneratedOutput output); // 0x0000000189D3EC14-0x0000000189D3ED5C
		public static void ResetMaterialOverrides(HEU_GeneratedOutputData outputData); // 0x0000000189D3ED5C-0x0000000189D3EE14
		public static Material[] GetGeneratedMaterialsForGameObject(HEU_GeneratedOutput output, GameObject inGameObject); // 0x0000000189D3E5C8-0x0000000189D3E784
		public static bool HasLODGroup(HEU_GeneratedOutput output); // 0x0000000189D3E784-0x0000000189D3E7CC
		public static bool IsOutputUsingMaterial(Material checkMaterial, HEU_GeneratedOutput output); // 0x0000000189D3EAB4-0x0000000189D3EC14
		public static bool IsOutputDataUsingMaterial(Material checkMaterial, HEU_GeneratedOutputData outputData); // 0x0000000189D3E948-0x0000000189D3EAB4
		public static void ClearGeneratedMaterialReferences(HEU_GeneratedOutputData generatedOutputData); // 0x0000000189D3DD60-0x0000000189D3DD84
		public static void DestroyAllGeneratedColliders(HEU_GeneratedOutputData outputData); // 0x0000000189D3E090-0x0000000189D3E268
		public static void DestroyGeneratedOutput(HEU_GeneratedOutput generatedOutput); // 0x0000000189D3E424-0x0000000189D3E5C8
		public static void DestroyGeneratedOutputChildren(HEU_GeneratedOutput generatedOutput); // 0x0000000189D3E268-0x0000000189D3E3CC
		public static void DestroyGeneratedOutputData(HEU_GeneratedOutputData generatedOutputData, bool bDontDeletePersistantResources); // 0x0000000189D3E3CC-0x0000000189D3E424
		public static void ClearMaterialsNoLongerUsed(Material[] materialsToCheck, Material[] materialsInUse); // 0x0000000189D3DD84-0x0000000189D3DE54
		public static void CopyMaterialOverrides(HEU_GeneratedOutputData sourceOutputData, HEU_GeneratedOutputData destOutputData); // 0x0000000189D3DE54-0x0000000189D3E090
		internal void WriteOutputToAssetCache(GameObject parentObject, string outputPath, bool bIsInstancer); // 0x0000000189D3EE14-0x0000000189D3EE84
		internal static void BakeGameObjectComponents(GameObject sourceGO, GameObject targetGO, string assetName, string outputPath, bool bIsInstancer); // 0x0000000189D3DC18-0x0000000189D3DD60
		public bool IsEquivalentTo(HEU_GeneratedOutput other); // 0x0000000189D3E7CC-0x0000000189D3E948
	}

	[Serializable]
	public class HEU_GeneratedOutputData : IEquivable<HEU_GeneratedOutputData> // TypeDefIndex: 52940
	{
		// Fields
		public GameObject _gameObject; // 0x10
		public Material[] _renderMaterials; // 0x18
		public List<Collider> _colliders; // 0x20
	
		// Constructors
		public HEU_GeneratedOutputData(); // 0x0000000189D3DBA0-0x0000000189D3DC18
	
		// Methods
		public bool IsEquivalentTo(HEU_GeneratedOutputData other); // 0x0000000189D3D9F0-0x0000000189D3DBA0
	}

	public class HEU_GeoNode : ScriptableObject, IHEU_GeoNode, IHEU_HoudiniAssetSubcomponent, ISerializationCallbackReceiver, IEquivable<HEU_GeoNode> // TypeDefIndex: 52941
	{
		// Fields
		[SerializeField]
		private HAPI_GeoInfo _geoInfo; // 0x18
		[SerializeField]
		private string _geoName; // 0x40
		[SerializeField]
		private List<HEU_PartData> _parts; // 0x48
		[SerializeField]
		private HEU_ObjectNode _containerObjectNode; // 0x50
		[SerializeField]
		private HEU_InputNode _inputNode; // 0x58
		[SerializeField]
		private HEU_Curve _geoCurve; // 0x60
		[SerializeField]
		private HEU_VolumeCache _volumeCache; // 0x68
		[SerializeField]
		private List<HEU_VolumeCache> _volumeCaches; // 0x70
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000189D42D6C-0x0000000189D42DD8 
		public int GeoID { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
		public HAPI_GeoInfo GeoInfo { get; } // 0x0000000184D9A780-0x0000000184D9A7A0 
		public string GeoName { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public HAPI_GeoType GeoType { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public bool Editable { get; } // 0x0000000184D86870-0x0000000184D86880 
		public bool Displayable { get; } // 0x0000000189D42CEC-0x0000000189D42D6C 
		public List<HEU_PartData> Parts { get; } // 0x0000000184D86200-0x0000000184D86210 
		public HEU_ObjectNode ObjectNode { get; } // 0x0000000184D86270-0x0000000184D86280 
		public HEU_InputNode InputNode { get; } // 0x0000000182E56440-0x0000000182E56460 
		public HEU_Curve GeoCurve { get; } // 0x0000000184D86280-0x0000000184D86290 
		public List<HEU_VolumeCache> VolumeCaches { get; } // 0x0000000184D862B0-0x0000000184D862C0 
	
		// Constructors
		public HEU_GeoNode(); // 0x0000000189D42CCC-0x0000000189D42CEC
	
		// Methods
		public void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		public void OnAfterDeserialize(); // 0x0000000189D40F28-0x0000000189D4101C
		public HEU_SessionBase GetSession(); // 0x0000000189D40660-0x0000000189D40704
		public void Recook(); // 0x0000000189D42038-0x0000000189D420AC
		public bool IsVisible(); // 0x0000000189D40F0C-0x0000000189D40F28
		public bool IsIntermediate(); // 0x0000000189D40DD8-0x0000000189D40DE0
		public bool IsIntermediateOrEditable(); // 0x0000000189D40DC0-0x0000000189D40DD8
		public bool IsGeoInputType(); // 0x0000000189D40DAC-0x0000000189D40DC0
		public bool IsGeoCurveType(); // 0x0000000189D40DA4-0x0000000189D40DAC
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02331E8B */); // 0x0000000189D3F27C-0x0000000189D3F454
		public void RemoveAndDestroyPart(HEU_PartData part); // 0x0000000189D420AC-0x0000000189D42110
		public void GetOutputGameObjects(List<GameObject> outputObjects); // 0x0000000189D40288-0x0000000189D403AC
		public void GetOutput(List<HEU_GeneratedOutput> outputs); // 0x0000000189D403AC-0x0000000189D404D0
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject); // 0x0000000189D40130-0x0000000189D40288
		public HEU_PartData GetPartFromPartID(int partID); // 0x0000000189D404D0-0x0000000189D40580
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly); // 0x0000000189D3FB94-0x0000000189D3FD90
		public List<HEU_PartData> GetParts(); // 0x0000000184D86200-0x0000000184D86210
		public void HideAllGeometry(); // 0x0000000189D40990-0x0000000189D40A24
		public void DisableAllColliders(); // 0x0000000189D3F5DC-0x0000000189D3F670
		public HEU_VolumeCache GetVolumeCacheByTileIndex(int tileIndex); // 0x0000000189D40704-0x0000000189D40840
		internal void Reset(); // 0x0000000189D42110-0x0000000189D421C0
		internal void Initialize(HEU_SessionBase session, HAPI_GeoInfo geoInfo, HEU_ObjectNode containerObjectNode); // 0x0000000189D40A24-0x0000000189D40B40
		internal bool DoesThisRequirePotentialCook(); // 0x0000000189D3F670-0x0000000189D3F6B8
		internal void UpdateGeo(HEU_SessionBase session); // 0x0000000189D42944-0x0000000189D42CCC
		internal void ProcessUnityScriptAttribute(HEU_SessionBase session); // 0x0000000189D419AC-0x0000000189D41B60
		private void ProcessPart(HEU_SessionBase session, int partID, ref HAPI_PartInfo partInfo, ref HEU_PartData partData); // 0x0000000189D41214-0x0000000189D419AC
		private void SetupGameObjectAndTransform(HEU_PartData partData, HEU_HoudiniAsset parentAsset); // 0x0000000189D4246C-0x0000000189D4271C
		internal void GetPartsByOutputType(List<HEU_PartData> meshParts, List<HEU_PartData> volumeParts); // 0x0000000189D40580-0x0000000189D40660
		internal void GeneratePartInstances(HEU_SessionBase session); // 0x0000000189D3F830-0x0000000189D3FA70
		internal void GenerateAttributesStore(HEU_SessionBase session); // 0x0000000189D3F6B8-0x0000000189D3F758
		private void ProcessGeoCurve(HEU_SessionBase session); // 0x0000000189D4101C-0x0000000189D41214
		private void SetupGeoCurveGameObjectAndTransform(HEU_Curve curve); // 0x0000000189D4271C-0x0000000189D428E8
		internal void ClearObjectInstances(); // 0x0000000189D3F1F4-0x0000000189D3F27C
		internal void SetGeoInfo(HAPI_GeoInfo geoInfo); // 0x0000000189D423E8-0x0000000189D4246C
		internal string GeneratePartFullName(string partName); // 0x0000000189D3F758-0x0000000189D3F830
		internal string GenerateGeoCurveName(); // 0x0000000184D85A60-0x0000000184D85A70
		internal bool HasGeoNodeChanged(HEU_SessionBase session); // 0x0000000189D40958-0x0000000189D40990
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform); // 0x0000000189D3EF30-0x0000000189D3F054
		internal void GetDebugInfo(StringBuilder sb); // 0x0000000189D3FD90-0x0000000189D40130
		internal bool IsUsingMaterial(HEU_MaterialData materialData); // 0x0000000189D40DE0-0x0000000189D40F0C
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x0000000189D3FA70-0x0000000189D3FB94
		internal bool HasAttribInstancer(); // 0x0000000189D40840-0x0000000189D40958
		internal void SetAttributeModifiersOnPartOutputs(HEU_SessionBase session); // 0x0000000189D421C0-0x0000000189D423E8
		internal void CalculateVisiblity(bool bParentVisibility); // 0x0000000189D3F0E4-0x0000000189D3F1F4
		internal void CalculateColliderState(); // 0x0000000189D3F054-0x0000000189D3F0E4
		internal void ProcessVolumeParts(HEU_SessionBase session, List<HEU_PartData> volumeParts, bool bRebuild); // 0x0000000189D41B60-0x0000000189D42038
		internal void DestroyVolumeCache(); // 0x0000000189D3F454-0x0000000189D3F5DC
		public override string ToString(); // 0x0000000189D428E8-0x0000000189D42944
		public bool IsEquivalentTo(HEU_GeoNode other); // 0x0000000189D40B40-0x0000000189D40DA4
	}

	[ExecuteInEditMode]
	public sealed class HEU_HoudiniAsset : MonoBehaviour, IHEU_HoudiniAsset, IEquivable<HEU_HoudiniAsset> // TypeDefIndex: 52951
	{
		// Fields
		[SerializeField]
		private HEU_AssetType _assetType; // 0x18
		[SerializeField]
		private HAPI_AssetInfo _assetInfo; // 0x1C
		[SerializeField]
		private HAPI_NodeInfo _nodeInfo; // 0x5C
		[SerializeField]
		private string _assetName; // 0xA0
		[SerializeField]
		private string _assetOpName; // 0xA8
		[SerializeField]
		private string _assetHelp; // 0xB0
		[NonSerialized]
		private int _assetID; // 0xB8
		[SerializeField]
		private string _assetPath; // 0xC0
		[SerializeField]
		private bool _loadAssetFromMemory; // 0xC8
		[SerializeField]
		private bool _alwaysOverwriteOnLoad; // 0xC9
		[SerializeField]
		private UnityEngine.Object _assetFileObject; // 0xD0
		[SerializeField]
		private List<HEU_ObjectNode> _objectNodes; // 0xD8
		[SerializeField]
		private GameObject _rootGameObject; // 0xE0
		[SerializeField]
		private List<HEU_MaterialData> _materialCache; // 0xE8
		[SerializeField]
		private HEU_Parameters _parameters; // 0xF0
		[SerializeField]
		private Matrix4x4 _lastSyncedTransformMatrix; // 0xF8
		[SerializeField]
		private List<Matrix4x4> _lastSyncedChildTransformMatrices; // 0x138
		[SerializeField]
		private string _assetCacheFolderPath; // 0x140
		[SerializeField]
		private string[] _subassetNames; // 0x148
		[SerializeField]
		private int _selectedSubassetIndex; // 0x150
		private HEU_AssetPreset _savedAssetPreset; // 0x158
		private HEU_RecookPreset _recookPreset; // 0x160
		[SerializeField]
		private int _totalCookCount; // 0x168
		[SerializeField]
		private AssetBuildAction _requestBuildAction; // 0x16C
		[SerializeField]
		private bool _checkParameterChangeForCook; // 0x170
		[SerializeField]
		private bool _skipCookCheck; // 0x171
		[SerializeField]
		private bool _uploadParameters; // 0x172
		[SerializeField]
		private bool _forceUploadInputs; // 0x173
		[SerializeField]
		private bool _upstreamCookChanged; // 0x174
		[SerializeField]
		private AssetCookStatus _cookStatus; // 0x178
		[SerializeField]
		private AssetCookResult _lastCookResult; // 0x17C
		[SerializeField]
		private bool _isCookingAssetReloaded; // 0x180
		private bool _bForceUpdate; // 0x181
		[SerializeField]
		private long _sessionID; // 0x188
		[CompilerGenerated]
		[SerializeField]
		private bool _WarnedPrefabNotSupported_k__BackingField; // 0x190
		[SerializeField]
		private bool _uiLocked; // 0x191
		[SerializeField]
		private bool _showHDAOptions; // 0x192
		[SerializeField]
		private bool _showGenerateSection; // 0x193
		[SerializeField]
		private bool _showBakeSection; // 0x194
		[SerializeField]
		private bool _showEventsSection; // 0x195
		[SerializeField]
		private bool _showCurvesSection; // 0x196
		[SerializeField]
		private bool _showInputNodesSection; // 0x197
		[SerializeField]
		private bool _showToolsSection; // 0x198
		[SerializeField]
		private bool _showTerrainSection; // 0x199
		[SerializeField]
		private HEU_InstanceInputUIState _instanceInputUIState; // 0x1A0
		[SerializeField]
		private HEU_ReloadDataEvent _reloadDataEvent; // 0x1A8
		[SerializeField]
		private HEU_CookedDataEvent _cookedDataEvent; // 0x1B0
		[SerializeField]
		private HEU_BakedDataEvent _bakedDataEvent; // 0x1B8
		[SerializeField]
		private HEU_PreAssetEvent _preAssetEvent; // 0x1C0
		[SerializeField]
		private UpdateUIDelegate _refreshUIDelegate; // 0x1C8
		private HEU_CookedDataEvent _downstreamConnectionCookedEvent; // 0x1D0
		[SerializeField]
		private bool _generateUVs; // 0x1D8
		[SerializeField]
		private bool _generateTangents; // 0x1D9
		[SerializeField]
		private bool _generateNormals; // 0x1DA
		[SerializeField]
		private bool _pushTransformToHoudini; // 0x1DB
		[SerializeField]
		private bool _transformChangeTriggersCooks; // 0x1DC
		[SerializeField]
		private bool _cookingTriggersDownCooks; // 0x1DD
		[SerializeField]
		private bool _autoCookOnParameterChange; // 0x1DE
		[SerializeField]
		private bool _ignoreNonDisplayNodes; // 0x1DF
		[SerializeField]
		private bool _useOutputNodes; // 0x1E0
		[SerializeField]
		private bool _generateMeshUsingPoints; // 0x1E1
		[SerializeField]
		private bool _useLODGroups; // 0x1E2
		[SerializeField]
		private bool _splitGeosByGroup; // 0x1E3
		[SerializeField]
		private bool _sessionSyncAutoCook; // 0x1E4
		[SerializeField]
		private bool _bakeUpdateKeepPreviousTransformValues; // 0x1E5
		private bool _pauseCooking; // 0x1E6
		[SerializeField]
		private bool _curveEditorEnabled; // 0x1E7
		[SerializeField]
		private List<HEU_Curve> _curves; // 0x1E8
		[SerializeField]
		private HEU_Curve.CurveDrawCollision _curveDrawCollision; // 0x1F0
		[SerializeField]
		private List<Collider> _curveDrawColliders; // 0x1F8
		[SerializeField]
		private LayerMask _curveDrawLayerMask; // 0x200
		[SerializeField]
		private float _curveProjectMaxDistance; // 0x204
		[SerializeField]
		private Vector3 _curveProjectDirection; // 0x208
		[SerializeField]
		private bool _curveProjectDirectionToView; // 0x214
		[SerializeField]
		private bool _curveDisableScaleRotation; // 0x215
		[SerializeField]
		private bool _curveFrameSelectedNodes; // 0x216
		[SerializeField]
		private float _curveFrameSelectedNodeDistance; // 0x218
		[SerializeField]
		private List<HEU_InputNode> _inputNodes; // 0x220
		[SerializeField]
		private List<HEU_Handle> _handles; // 0x228
		[SerializeField]
		private bool _handlesEnabled; // 0x230
		[SerializeField]
		private List<HEU_VolumeCache> _volumeCaches; // 0x238
		[SerializeField]
		private List<HEU_AttributesStore> _attributeStores; // 0x240
		[SerializeField]
		private bool _editableNodesToolsEnabled; // 0x248
		[SerializeField]
		private HEU_ToolsInfo _toolsInfo; // 0x250
		[HideInInspector]
		[SerializeField]
		private HEU_AssetSerializedMetaData _serializedMetaData; // 0x258
		private bool _pendingAutoCookOnMouseRelease; // 0x260
	
		// Properties
		public bool LoadAssetFromMemory { get; set; } // 0x0000000184D8E270-0x0000000184D8E280 0x0000000184D8E290-0x0000000184D8E2A0
		public bool AlwaysOverwriteOnLoad { get; set; } // 0x0000000184DA2350-0x0000000184DA2360 0x0000000184DA2520-0x0000000184DA2530
		public bool GenerateUVs { get; set; } // 0x0000000184DA2460-0x0000000184DA2470 0x0000000184DA2600-0x0000000184DA2610
		public bool GenerateTangents { get; set; } // 0x0000000184DA2450-0x0000000184DA2460 0x0000000184DA25F0-0x0000000184DA2600
		public bool GenerateNormals { get; set; } // 0x0000000184DA2440-0x0000000184DA2450 0x0000000184DA25E0-0x0000000184DA25F0
		public bool PushTransformToHoudini { get; set; } // 0x0000000184DA24C0-0x0000000184DA24D0 0x0000000184DA2630-0x0000000184DA2640
		public bool TransformChangeTriggersCooks { get; set; } // 0x0000000184DA2500-0x0000000184DA2510 0x0000000184DA2660-0x0000000184DA2670
		public bool CookingTriggersDownCooks { get; set; } // 0x0000000184DA23B0-0x0000000184DA23C0 0x0000000184DA2550-0x0000000184DA2560
		public bool AutoCookOnParameterChange { get; set; } // 0x0000000184DA2390-0x0000000184DA23A0 0x0000000184DA2530-0x0000000184DA2540
		public bool IgnoreNonDisplayNodes { get; set; } // 0x0000000184DA2480-0x0000000184DA2490 0x0000000184DA2620-0x0000000184DA2630
		public bool UseOutputNodes { get; set; } // 0x0000000184D91ED0-0x0000000184D91EE0 0x0000000184D91EE0-0x0000000184D91EF0
		public bool GenerateMeshUsingPoints { get; set; } // 0x0000000184DA2430-0x0000000184DA2440 0x0000000184DA25D0-0x0000000184DA25E0
		public bool UseLODGroups { get; set; } // 0x0000000184DA2510-0x0000000184DA2520 0x0000000184DA2670-0x0000000184DA2680
		public bool SplitGeosByGroup { get; set; } // 0x0000000184DA24F0-0x0000000184DA2500 0x0000000184DA2650-0x0000000184DA2660
		public bool SessionSyncAutoCook { get; set; } // 0x0000000184DA24E0-0x0000000184DA24F0 0x0000000184DA2640-0x0000000184DA2650
		public bool BakeUpdateKeepPreviousTransformValues { get; set; } // 0x0000000184DA23A0-0x0000000184DA23B0 0x0000000184DA2540-0x0000000184DA2550
		public bool PauseCooking { get; set; } // 0x0000000184D90890-0x0000000184D908A0 0x0000000184D908B0-0x0000000184D908C0
		public bool CurveEditorEnabled { get; set; } // 0x0000000184D908A0-0x0000000184D908B0 0x0000000184D908C0-0x0000000184D908D0
		public HEU_CurveDrawCollisionWrapper CurveDrawCollision { get; set; } // 0x0000000189D53620-0x0000000189D53630 0x0000000189D53654-0x0000000189D53674
		public LayerMask CurveDrawLayerMask { get; set; } // 0x0000000184DA2310-0x0000000184DA2320 0x0000000184DA2340-0x0000000184DA2350
		public float CurveProjectMaxDistance { get; set; } // 0x0000000184DA2420-0x0000000184DA2430 0x0000000184DA25C0-0x0000000184DA25D0
		public Vector3 CurveProjectDirection { get; set; } // 0x0000000184DA2400-0x0000000184DA2420 0x0000000184DA25A0-0x0000000184DA25C0
		public bool CurveProjectDirectionToView { get; set; } // 0x0000000184DA23F0-0x0000000184DA2400 0x0000000184DA2590-0x0000000184DA25A0
		public bool CurveDisableScaleRotation { get; set; } // 0x0000000184D8E560-0x0000000184D8E570 0x0000000184DA2560-0x0000000184DA2570
		public bool CurveFrameSelectedNodes { get; set; } // 0x0000000184DA23E0-0x0000000184DA23F0 0x0000000184DA2580-0x0000000184DA2590
		public float CurveFrameSelectedNodeDistance { get; set; } // 0x0000000184DA23D0-0x0000000184DA23E0 0x0000000184DA2570-0x0000000184DA2580
		public bool HandlesEnabled { get; set; } // 0x0000000184DA2470-0x0000000184DA2480 0x0000000184DA2610-0x0000000184DA2620
		public bool EditableNodesToolsEnabled { get; set; } // 0x0000000184D90930-0x0000000184D90940 0x0000000184D90960-0x0000000184D90970
		public HEU_AssetTypeWrapper AssetType { get; } // 0x0000000189D535E4-0x0000000189D53610 
		public HAPI_AssetInfo AssetInfo { get; } // 0x0000000184DA2360-0x0000000184DA2390 
		public HAPI_NodeInfo NodeInfo { get; } // 0x0000000184DA2490-0x0000000184DA24C0 
		public string AssetName { get; } // 0x0000000184D86210-0x0000000184D86220 
		public string AssetOpName { get; } // 0x0000000184D86290-0x0000000184D862A0 
		public string AssetHelp { get; } // 0x0000000184D86250-0x0000000184D86260 
		public int AssetID { get; } // 0x0000000184D8E580-0x0000000184D8E590 
		public string AssetPath { get; } // 0x0000000184D892F0-0x0000000184D89300 
		public GameObject OwnerGameObject { get; } // 0x00000001853916BC-0x00000001853916C4 
		public GameObject RootGameObject { get; } // 0x0000000184D8D1C0-0x0000000184D8D1D0 
		public List<HEU_MaterialData> MaterialCache { get; } // 0x0000000184D88590-0x0000000184D885A0 
		public HEU_Parameters Parameters { get; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 
		public string AssetCacheFolder { get; } // 0x0000000184D8DA60-0x0000000184D8DA70 
		public string[] SubassetNames { get; } // 0x0000000184D8DAC0-0x0000000184D8DAD0 
		public int SelectedSubassetIndex { get; } // 0x0000000184DA24D0-0x0000000184DA24E0 
		public HEU_AssetCookStatusWrapper CookStatus { get; } // 0x0000000189D53610-0x0000000189D53620 
		public HEU_AssetCookResultWrapper LastCookResult { get; } // 0x0000000189D53630-0x0000000189D53654 
		public long SessionID { get; } // 0x0000000184D8DA20-0x0000000184D8DA30 
		public List<HEU_Curve> Curves { get; } // 0x0000000184D87930-0x0000000184D87940 
		public List<HEU_InputNode> InputNodes { get; } // 0x0000000184D8D870-0x0000000184D8D880 
		public List<HEU_VolumeCache> VolumeCaches { get; } // 0x0000000184D8DAD0-0x0000000184D8DAE0 
		public HEU_ReloadDataEvent ReloadDataEvent { get; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 
		public HEU_CookedDataEvent CookedDataEvent { get; } // 0x0000000184D8D960-0x0000000184D8D970 
		public HEU_BakedDataEvent BakedDataEvent { get; } // 0x0000000184D8DA90-0x0000000184D8DAA0 
		public HEU_PreAssetEvent PreAssetEvent { get; } // 0x0000000184D8DA80-0x0000000184D8DA90 
		internal HEU_AssetType AssetTypeInternal { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		internal bool WarnedPrefabNotSupported { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8FB60-0x0000000184D8FB70 0x0000000184D8FC50-0x0000000184D8FC60
		internal HEU_InstanceInputUIState InstanceInputUIState { get; set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		internal UpdateUIDelegate RefreshUIDelegate { get; set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		internal HEU_Curve.CurveDrawCollision CurveDrawCollisionInternal { get; } // 0x0000000184DA23C0-0x0000000184DA23D0 
		internal List<HEU_Handle> Handles { get; } // 0x0000000184D8D440-0x0000000184D8D450 
		internal List<HEU_AttributesStore> AttributeStores { get; } // 0x0000000184D8DE80-0x0000000184D8DE90 
		internal HEU_ToolsInfo ToolsInfo { get; } // 0x0000000184D8DCE0-0x0000000184D8DCF0 
		internal HEU_AssetSerializedMetaData SerializedMetaData { get; } // 0x0000000184D8DE70-0x0000000184D8DE80 
		internal bool PendingAutoCookOnMouseRelease { get; set; } // 0x0000000184D8F3F0-0x0000000184D8F400 0x0000000189D53674-0x0000000189D53690
	
		// Nested types
		internal enum HEU_AssetType // TypeDefIndex: 52942
		{
			TYPE_INVALID = 0,
			TYPE_HDA = 1,
			TYPE_CURVE = 2,
			TYPE_INPUT = 3
		}
	
		internal enum AssetBuildAction // TypeDefIndex: 52943
		{
			NONE = 0,
			RELOAD = 1,
			COOK = 2,
			INVALID = 3,
			STRIP_HEDATA = 4,
			DUPLICATE = 5,
			RESET_PARAMS = 6
		}
	
		internal enum AssetCookStatus // TypeDefIndex: 52944
		{
			NONE = 0,
			COOKING = 1,
			POSTCOOK = 2,
			LOADING = 3,
			POSTLOAD = 4,
			PRELOAD = 5,
			SELECT_SUBASSET = 6
		}
	
		internal enum AssetCookResult // TypeDefIndex: 52945
		{
			NONE = 0,
			SUCCESS = 1,
			ERRORED = 2
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 52946; 0x00000001853DEDB8-0x00000001853DEDC8
	
		private enum AssetInstantiationMethod // TypeDefIndex: 52947
		{
			DEFAULT = 0,
			DUPLICATED = 1,
			UNDO = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass262_0 // TypeDefIndex: 52948
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass262_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _BakeToExistingPrefab_b__0(Transform trans); // 0x0000000189D691FC-0x0000000189D692B4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52949
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<HEU_InputNode, bool> __9__274_0; // 0x08
			public static Func<HEU_ObjectNode, bool> __9__312_0; // 0x10
			public static Func<HEU_Curve, bool> __9__335_0; // 0x18
			public static Func<HEU_AttributesStore, bool> __9__336_0; // 0x20
			public static Func<HEU_Curve, bool> __9__373_0; // 0x28
			public static Func<HEU_ObjectNode, bool> __9__404_0; // 0x30
			public static Func<HEU_Curve, bool> __9__404_1; // 0x38
			public static Func<HEU_MaterialData, bool> __9__404_2; // 0x40
	
			// Constructors
			static __c(); // 0x0000000189D695C0-0x0000000189D69624
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetNonParameterInputNodes_b__274_0(HEU_InputNode node); // 0x0000000189D69118-0x0000000189D69164
			internal bool _DoPostCookWork_b__312_0(HEU_ObjectNode obj); // 0x0000000189D690CC-0x0000000189D69118
			internal bool _UploadCurvesParameters_b__335_0(HEU_Curve curve); // 0x0000000189D691B0-0x0000000189D691FC
			internal bool _UploadAttributeValues_b__336_0(HEU_AttributesStore store); // 0x0000000189D69164-0x0000000189D691B0
			internal bool _ClearInvalidCurves_b__373_0(HEU_Curve curve); // 0x0000000189D68F84-0x0000000189D68FD0
			internal bool _ClearInvalidLists_b__404_0(HEU_ObjectNode node); // 0x0000000189D68FD0-0x0000000189D6901C
			internal bool _ClearInvalidLists_b__404_1(HEU_Curve curve); // 0x0000000189D6901C-0x0000000189D69068
			internal bool _ClearInvalidLists_b__404_2(HEU_MaterialData data); // 0x0000000189D69068-0x0000000189D690B4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass405_0 // TypeDefIndex: 52950
		{
			// Fields
			public HEU_HoudiniAsset newAsset; // 0x10
			public int i; // 0x18
			public Predicate<HEU_Curve> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass405_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CopyPropertiesTo_b__0(HEU_Curve curve); // 0x0000000189D692B4-0x0000000189D69334
		}
	
		// Constructors
		public HEU_HoudiniAsset(); // 0x0000000189D5335C-0x0000000189D535E4
	
		// Methods
		internal AssetCookStatus GetCookStatus(); // 0x0000000184DA2300-0x0000000184DA2310
		internal AssetCookResult GetLastCookResult(); // 0x0000000184D92A50-0x0000000184D92A60
		internal List<Collider> GetCurveDrawColliders(); // 0x0000000184D87920-0x0000000184D87930
		internal LayerMask GetCurveDrawLayerMask(); // 0x0000000184DA2310-0x0000000184DA2320
		internal void SetCurveDrawLayerMask(LayerMask mask); // 0x0000000184DA2340-0x0000000184DA2350
		public bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x02331E8C */, bool bAsync = false /* Metadata: 0x02331E8D */, bool bSkipCookCheck = true /* Metadata: 0x02331E8E */, bool bUploadParameters = true /* Metadata: 0x02331E8F */); // 0x0000000182FFF600-0x0000000182FFF610
		public bool RequestReload(bool bAsync = false /* Metadata: 0x02331E90 */); // 0x0000000182FFF600-0x0000000182FFF610
		public bool RequestResetParameters(bool bAsync = false /* Metadata: 0x02331E91 */); // 0x0000000182FFF600-0x0000000182FFF610
		public GameObject DuplicateAsset(GameObject newRootGameObject = null); // 0x0000000189D4866C-0x0000000189D489EC
		public bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x02331E92 */); // 0x0000000189D479B4-0x0000000189D47C44
		public GameObject BakeToNewPrefab(string destinationPrefabPath = null); // 0x0000000189D44B40-0x0000000189D44E54
		public GameObject BakeToNewStandalone(); // 0x0000000189D44E54-0x0000000189D44FAC
		public bool BakeToExistingPrefab(GameObject bakeTargetGO); // 0x0000000189D43A2C-0x0000000189D43F64
		public bool BakeToExistingStandalone(GameObject bakeTargetGO); // 0x0000000189D43F64-0x0000000189D44B40
		public bool IsAssetValid(); // 0x0000000189D4D490-0x0000000189D4D4CC
		public bool GetOutputGameObjects(List<GameObject> outputObjects); // 0x0000000189D4BC18-0x0000000189D4BD40
		public bool GetOutput(List<HEU_GeneratedOutput> outputs); // 0x0000000189D4BE68-0x0000000189D4BF90
		public HEU_Curve GetCurve(string curveName); // 0x0000000189D4A5A4-0x0000000189D4A710
		public bool AddCurveDrawCollider(Collider newCollider); // 0x0000000189D42F2C-0x0000000189D42FB4
		public bool RemoveCurveDrawCollider(Collider collider); // 0x0000000189D4FD40-0x0000000189D4FD9C
		public bool ClearCurveDrawColliders(); // 0x0000000189D457B4-0x0000000189D45800
		public HEU_InputNode GetInputNode(string inputName); // 0x0000000189D4ACAC-0x0000000189D4ADF0
		public HEU_InputNode GetAssetInputNode(string inputName); // 0x0000000189D49A8C-0x0000000189D49BD4
		public HEU_InputNode GetInputNodeByIndex(int index); // 0x0000000189D4AC38-0x0000000189D4ACAC
		public List<HEU_InputNode> GetNonParameterInputNodes(); // 0x0000000189D4B2DC-0x0000000189D4B668
		public int GetVolumeCacheCount(); // 0x0000000189D4C284-0x0000000189D4C2C8
		public HEU_SessionBase GetAssetSession(bool bCreateIfInvalid); // 0x0000000189D4A298-0x0000000189D4A310
		public HEU_ObjectNode GetObjectNodeByName(string objName); // 0x0000000189D4B668-0x0000000189D4B938
		public void GetOutputGeoNodes(List<HEU_GeoNode> outputGeoNodes); // 0x0000000189D4BD40-0x0000000189D4BE68
		public HEU_PartData GetInternalHDAPartWithGameObject(GameObject outputGameObject); // 0x0000000189D4B024-0x0000000189D4B180
		public void ResetParametersToDefault(); // 0x0000000189D509BC-0x0000000189D50DA0
		public void HideAllGeometry(); // 0x0000000189D4C878-0x0000000189D4C990
		public void DisableAllColliders(); // 0x0000000189D47CA8-0x0000000189D47DC0
		public HEU_MaterialData GetMaterialData(Material material); // 0x0000000189D4B180-0x0000000189D4B2DC
		public void ClearMaterialCache(); // 0x0000000189D45C10-0x0000000189D45C58
		public void RemoveMaterial(Material material); // 0x0000000189D4FEA4-0x0000000189D4FFBC
		public void ResetMaterialOverrides(); // 0x0000000189D50860-0x0000000189D509BC
		public HEU_AssetPreset GetAssetPreset(bool sceneRelativeGameObjects); // 0x0000000189D49BD4-0x0000000189D4A298
		public HEU_PDGAssetLink GetOrCreatePDGAssetLink(); // 0x0000000189D4BAB0-0x0000000189D4BC18
		public static HEU_HoudiniAssetRoot InstantiateHDA(string filePath, bool bAsync = false /* Metadata: 0x02331E93 */, Vector3 initialPosition = default); // 0x0000000189D4C998-0x0000000189D4CA58
		public static HEU_PartData GetSceneHDAPartWithGameObject(GameObject outputGameObject); // 0x0000000189D4C0B0-0x0000000189D4C1EC
		public static HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(GameObject outputGameObject); // 0x0000000189D4BF90-0x0000000189D4C0B0
		public static bool IsHoudiniAssetOutput(GameObject go); // 0x0000000189D4E3CC-0x0000000189D4E4F8
		public static bool IsHoudiniAssetRoot(GameObject go); // 0x0000000189D4E4F8-0x0000000189D4E564
		internal void SetupAsset(HEU_AssetType assetType, string filePath, GameObject rootGameObject, HEU_SessionBase session); // 0x0000000189D51148-0x0000000189D5153C
		internal void CleanUpAndDisable(); // 0x0000000189D451DC-0x0000000189D45254
		internal bool IsAssetSavedInScene(); // 0x0000000189D4D440-0x0000000189D4D45C
		private void Awake(); // 0x00000001841E1670-0x00000001841E1680
		internal void InvalidateAsset(); // 0x0000000184DA2320-0x0000000184DA2330
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
		internal void AssetUpdate(); // 0x00000001841E1670-0x00000001841E1680
		internal void PostAssetUpdate(); // 0x00000001841E1670-0x00000001841E1680
		internal void RequestBakeInPlace(); // 0x0000000189D50590-0x0000000189D505A4
		internal void ClearBuildRequest(); // 0x0000000184DA22E0-0x0000000184DA2300
		private bool HasValidAssetPath(); // 0x0000000189D4C860-0x0000000189D4C878
		private void ProcessRebuild(bool bPromptForSubasset, int desiredSubassetIndex); // 0x0000000189D4F664-0x0000000189D4F89C
		private void InvokeReloadEvent(bool bCookSuccess, List<GameObject> outputObjects); // 0x0000000189D4D384-0x0000000189D4D440
		private bool StartRebuild(bool bPromptForSubasset, int desiredSubassetIndex); // 0x0000000189D51560-0x0000000189D516DC
		private bool FinishRebuild(); // 0x0000000189D48A88-0x0000000189D490A0
		private bool RecookAsync(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync); // 0x0000000189D4F9DC-0x0000000189D4FAFC
		private bool RecookBlocking(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync); // 0x0000000189D4FAFC-0x0000000189D4FCE8
		private void DoPostCookWork(HEU_SessionBase session); // 0x0000000189D47E50-0x0000000189D48194
		internal bool IsValidForInteraction(ref string errorMessage); // 0x0000000189D4E564-0x0000000189D4E5D4
		private void OnValidate(); // 0x0000000189D4EF4C-0x0000000189D4EF80
		private void ExecutePostCookCallbacks(); // 0x0000000189D489EC-0x0000000189D48A88
		private void InvokePostCookEvent(bool bCookSuccess, List<GameObject> outputObjects); // 0x0000000189D4D2C8-0x0000000189D4D384
		private bool InternalStartRecook(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync); // 0x0000000189D4CBB0-0x0000000189D4D208
		private void InternalSetAssetID(int assetID); // 0x0000000189D4CA58-0x0000000189D4CBB0
		private void SetCookStatus(AssetCookStatus status, AssetCookResult result); // 0x0000000184DA2330-0x0000000184DA2340
		private void ProcessPoskCook(); // 0x0000000189D4F288-0x0000000189D4F664
		private bool StartHoudiniCookNode(HEU_SessionBase session); // 0x0000000189D5153C-0x0000000189D51560
		private void ProcessHoudiniCookStatus(bool bAsync); // 0x0000000189D4F0D8-0x0000000189D4F288
		internal bool DoesAssetRequireRecook(); // 0x0000000189D48194-0x0000000189D485E8
		internal void DeleteSessionDataOnly(); // 0x0000000189D47C94-0x0000000189D47CA8
		private void CleanUpInputNodes(); // 0x0000000189D45354-0x0000000189D4557C
		internal void DeleteAssetCacheData(bool bRegisterUndo); // 0x0000000189D47C44-0x0000000189D47C94
		private void GenerateParameters(HEU_SessionBase session); // 0x0000000189D49878-0x0000000189D49A8C
		private void DownloadParameterPresetFromHoudini(HEU_SessionBase session); // 0x0000000189D485E8-0x0000000189D4866C
		private void UploadParameterPresetToHoudini(HEU_SessionBase session); // 0x0000000189D5310C-0x0000000189D532F0
		private void UpdateParameterInputsToHoudini(HEU_SessionBase session, bool bForceUpdate); // 0x0000000189D52514-0x0000000189D525AC
		private bool LoadAssetFileWithSubasset(HEU_SessionBase session, bool bPromptForSubasset, int desiredSubassetIndex); // 0x0000000189D4E5D4-0x0000000189D4E8B0
		private bool CreateAndCookAsset(HEU_SessionBase session, int subassetIndex, out int newAssetID, bool bCookTemplatedGeos); // 0x0000000189D4730C-0x0000000189D47434
		private void CreateAssetInputs(HEU_SessionBase session); // 0x0000000189D47434-0x0000000189D47788
		public void ForceUploadParameters(HEU_SessionBase session); // 0x0000000189D490A0-0x0000000189D490D4
		private void UploadCurvesParameters(HEU_SessionBase session, bool bCheckParamsChanged); // 0x0000000189D52BBC-0x0000000189D52F3C
		private void UploadAttributeValues(HEU_SessionBase session); // 0x0000000189D52618-0x0000000189D52BBC
		private void SyncDirtyAttributesToHoudini(HEU_SessionBase session); // 0x0000000189D517C0-0x0000000189D51908
		private void UploadInputNodes(HEU_SessionBase session, bool bForceUpdate, bool bUpdateAll); // 0x0000000189D52F3C-0x0000000189D5310C
		internal bool HasInputNodeTransformChanged(); // 0x0000000189D4C46C-0x0000000189D4C5BC
		private void NotifyInputNodesCookFinished(); // 0x0000000189D4ED78-0x0000000189D4EE90
		private bool CreateObjects(HEU_SessionBase session); // 0x0000000189D47878-0x0000000189D4798C
		private void UpdateAllObjectNodes(HEU_SessionBase session); // 0x0000000189D51AD8-0x0000000189D5220C
		private HEU_ObjectNode CreateObjectNode(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo, ref HAPI_Transform objectTranform); // 0x0000000189D47788-0x0000000189D47878
		private void GenerateObjectsGeometry(HEU_SessionBase session, bool bRebuild); // 0x0000000189D49740-0x0000000189D49878
		internal int NumAttributeStores(); // 0x0000000189D4EEC4-0x0000000189D4EF08
		internal HEU_AttributesStore GetAttributeStore(string geoName, int partID); // 0x0000000189D4A310-0x0000000189D4A470
		private void GenerateAttributesStore(HEU_SessionBase session); // 0x0000000189D490D4-0x0000000189D491FC
		private void GenerateInstances(HEU_SessionBase session); // 0x0000000189D493C4-0x0000000189D49740
		private void GenerateHandles(HEU_SessionBase session); // 0x0000000189D491FC-0x0000000189D493C4
		internal void CleanUpHandles(); // 0x0000000189D45254-0x0000000189D45354
		internal HEU_Handle GetHandleByName(string handleName); // 0x0000000189D4A848-0x0000000189D4A984
		internal List<HEU_Handle> GetHandles(); // 0x0000000184D8D440-0x0000000184D8D450
		internal int NumHandles(); // 0x0000000189D4EF08-0x0000000189D4EF4C
		internal HAPI_Transform GetObjectTransform(HEU_SessionBase session, int objectID); // 0x0000000189D4B938-0x0000000189D4B9F4
		internal HEU_ObjectNode GetObjectWithID(int objId); // 0x0000000189D4B9F4-0x0000000189D4BAB0
		private void InvokeBakedEvent(bool bSuccess, List<GameObject> outputObjects, bool isNewBake); // 0x0000000189D4D208-0x0000000189D4D2C8
		private GameObject CloneAssetWithoutHDA(ref string bakedAssetPath, bool bWriteMeshesToAssetDatabase, bool bReconnectPrefabInstances); // 0x0000000189D45C58-0x0000000189D4618C
		internal void NotifyUpstreamCooked(HEU_CookedEventData Data); // 0x0000000189D4EE90-0x0000000189D4EEC4
		internal void ConnectToUpstream(HEU_HoudiniAsset upstreamAsset); // 0x0000000189D4618C-0x0000000189D4621C
		internal void DisconnectFromUpstream(HEU_HoudiniAsset upstreamAsset); // 0x0000000189D47DC0-0x0000000189D47E50
		private void AddDownstreamConnection(UnityAction<HEU_CookedEventData> receiver); // 0x0000000189D43038-0x0000000189D430B8
		private void RemoveDownstreamConnection(UnityAction<HEU_CookedEventData> receiver); // 0x0000000189D4FDF4-0x0000000189D4FE4C
		private void ClearAllUpstreamConnections(); // 0x0000000189D4557C-0x0000000189D457B4
		private void UpdateInputsOnAssetRecreation(HEU_SessionBase session); // 0x0000000189D523EC-0x0000000189D52514
		internal void ReconnectInputsUpstreamNotifications(); // 0x0000000189D4F89C-0x0000000189D4F9DC
		internal void GetHoudiniTransformAndApply(HEU_SessionBase session); // 0x0000000189D4A984-0x0000000189D4AC38
		internal void UploadUnityTransform(HEU_SessionBase session, bool bOnlySendIfChangedFromLastSync); // 0x0000000189D532F0-0x0000000189D5335C
		private void UpdateHoudiniMaterials(HEU_SessionBase session); // 0x0000000189D5220C-0x0000000189D523EC
		private void RemoveUnusedMaterials(); // 0x0000000189D4FFBC-0x0000000189D503A4
		internal bool IsAssetValidInHoudini(HEU_SessionBase session); // 0x0000000189D4D45C-0x0000000189D4D490
		internal bool HasTransformChangedSinceLastUpdate(); // 0x0000000189D4C5BC-0x0000000189D4C860
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x0000000189D4A470-0x0000000189D4A5A4
		internal void ClearInvalidCurves(); // 0x0000000189D45800-0x0000000189D45928
		internal int GetEditableCurveCount(); // 0x0000000189D4A710-0x0000000189D4A848
		internal void AddCurve(HEU_Curve curve); // 0x0000000189D42FB4-0x0000000189D43038
		internal void RemoveCurve(HEU_Curve curve); // 0x0000000189D4FD9C-0x0000000189D4FDF4
		internal List<HEU_InputNode> GetInputNodes(); // 0x0000000184D8D870-0x0000000184D8D880
		internal void AddInputNode(HEU_InputNode node); // 0x0000000189D430B8-0x0000000189D4313C
		internal void RemoveInputNode(HEU_InputNode node); // 0x0000000189D4FE4C-0x0000000189D4FEA4
		internal void InputNodeNotifyRemoved(HEU_InputNode node); // 0x0000000189D4C990-0x0000000189D4C998
		internal void AddVolumeCache(HEU_VolumeCache cache); // 0x0000000189D431A8-0x0000000189D4322C
		internal void RemoveVolumeCache(HEU_VolumeCache cache); // 0x0000000189D50408-0x0000000189D5048C
		internal void AddAttributeStore(HEU_AttributesStore attributeStore); // 0x0000000189D42DD8-0x0000000189D42F2C
		internal void RemoveAttributeStore(HEU_AttributesStore attributeStore); // 0x0000000189D4FCE8-0x0000000189D4FD40
		internal void ReorderAttributeStore(int oldIndex, int newIndex); // 0x0000000189D5048C-0x0000000189D50590
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos); // 0x0000000189D4EF80-0x0000000189D4F0D8
		internal void AddToAssetDBCache(string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref UnityEngine.Object targetAssetDBObject); // 0x0000000189D4313C-0x0000000189D431A8
		internal static void SetCurvesVisibilityInScene(bool bShow); // 0x0000000189D50DA0-0x0000000189D50F70
		internal string GetValidAssetCacheFolderPath(); // 0x0000000189D4C1EC-0x0000000189D4C284
		internal void CalculateVisibility(); // 0x0000000189D450C4-0x0000000189D451DC
		internal void CalculateColliderState(); // 0x0000000189D44FAC-0x0000000189D450C4
		internal void LoadAssetPresetAndCook(HEU_AssetPreset assetPreset); // 0x0000000189D4E8B0-0x0000000189D4ED78
		internal void ApplyRecookPreset(); // 0x0000000189D43544-0x0000000189D435E4
		private bool ApplyInputPresets(HEU_SessionBase session, List<HEU_InputPreset> inputPresets, bool bAddMissingInputsToRecookPreset); // 0x0000000189D4322C-0x0000000189D43544
		internal HEU_VolumeCachePreset GetVolumeCachePreset(string objName, string geoName, int tile); // 0x0000000189D4C2C8-0x0000000189D4C46C
		internal void RemoveVolumeCachePreset(HEU_VolumeCachePreset preset); // 0x0000000189D503A4-0x0000000189D50408
		private bool ApplyVolumeCachePresets(List<HEU_VolumeCachePreset> volumeCachePresets); // 0x0000000189D435E4-0x0000000189D4399C
		internal void SyncInternalParametersForUndoCompare(); // 0x0000000189D51908-0x0000000189D51AD8
		internal bool UpdateSessionSync(); // 0x0000000189D525AC-0x0000000189D52604
		internal void UpdateTotalCookCount(); // 0x0000000189D52604-0x0000000189D52618
		private void ResetAndCopyInstantiatedProperties(HEU_HoudiniAsset newAsset); // 0x0000000189D505A4-0x0000000189D50860
		private AssetInstantiationMethod GetInstantiationMethod(); // 0x0000000189D4AE7C-0x0000000189D4B024
		private HEU_HoudiniAsset GetInstantiatedObject(); // 0x0000000189D4ADF0-0x0000000189D4AE7C
		private void ClearInvalidLists(); // 0x0000000189D45928-0x0000000189D45C10
		private void CopyPropertiesTo(HEU_HoudiniAsset newAsset); // 0x0000000189D4621C-0x0000000189D4730C
		internal void SetSoftDeleted(); // 0x0000000189D50F70-0x0000000189D51148
		private void SyncChildTransforms(); // 0x0000000189D516DC-0x0000000189D517C0
		internal static HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(AssetCookStatus assetCookStatus); // 0x0000000189D439BC-0x0000000189D43A04
		internal static AssetCookStatus AssetCookStatus_WrapperToInternal(HEU_AssetCookStatusWrapper assetCookStatus); // 0x0000000189D439BC-0x0000000189D43A04
		internal static HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(AssetCookResult assetCookResult); // 0x0000000189D4399C-0x0000000189D439BC
		internal static AssetCookResult AssetCookResult_WrapperToInternal(HEU_AssetCookResultWrapper assetCookResult); // 0x0000000189D4399C-0x0000000189D439BC
		internal static HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HEU_Curve.CurveDrawCollision curveDrawCollision); // 0x0000000189D4798C-0x0000000189D479A4
		internal static HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HEU_CurveDrawCollisionWrapper curveDrawCollision); // 0x0000000189D479A4-0x0000000189D479B4
		internal static HEU_AssetTypeWrapper AssetType_InternalToWrapper(HEU_AssetType assetType); // 0x0000000189D43A04-0x0000000189D43A2C
		internal static HEU_AssetType AssetType_WrapperToInternal(HEU_AssetTypeWrapper assetType); // 0x0000000189D43A04-0x0000000189D43A2C
		public bool IsEquivalentTo(HEU_HoudiniAsset asset); // 0x0000000189D4D4CC-0x0000000189D4E3CC
	}

	[ExecuteInEditMode]
	[SelectionBase]
	public class HEU_HoudiniAssetRoot : MonoBehaviour // TypeDefIndex: 52952
	{
		// Fields
		[SerializeField]
		internal HEU_HoudiniAsset _houdiniAsset; // 0x18
		[SerializeField]
		internal List<GameObject> _bakeTargets; // 0x20
	
		// Properties
		public HEU_HoudiniAsset HoudiniAsset { get; } // 0x000000018385B100-0x000000018385B110 
		public List<GameObject> BakeTargets { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Constructors
		public HEU_HoudiniAssetRoot(); // 0x0000000189D58E10-0x0000000189D58E90
	
		// Methods
		private void OnDestroy(); // 0x0000000189D58C04-0x0000000189D58CA8
		internal void RemoveHoudiniEngineAssetData(); // 0x0000000189D58CA8-0x0000000189D58D54
		internal void ClearHoudiniEngineReferences(); // 0x0000000189D58BA0-0x0000000189D58BF4
		internal static void DestroyRootComponent(HEU_HoudiniAssetRoot assetRoot); // 0x0000000189D58BF4-0x0000000189D58C04
		internal void Reset(); // 0x0000000189D58D54-0x0000000189D58E10
	}

	public class HEU_InputNode : ScriptableObject, IHEU_InputNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_InputNode> // TypeDefIndex: 52957
	{
		// Fields
		[SerializeField]
		private InputNodeType _inputNodeType; // 0x18
		[SerializeField]
		private InputObjectType _inputObjectType; // 0x1C
		[SerializeField]
		private InputObjectType _pendingInputObjectType; // 0x20
		[SerializeField]
		private List<HEU_InputObjectInfo> _inputObjects; // 0x28
		[SerializeField]
		private List<int> _inputObjectsConnectedAssetIDs; // 0x30
		[SerializeField]
		private GameObject _inputAsset; // 0x38
		[SerializeField]
		private GameObject _connectedInputAsset; // 0x40
		[SerializeField]
		private List<HEU_InputHDAInfo> _inputAssetInfos; // 0x48
		[SerializeField]
		private int _nodeID; // 0x50
		[SerializeField]
		private int _inputIndex; // 0x54
		[SerializeField]
		private bool _requiresCook; // 0x58
		[SerializeField]
		private bool _requiresUpload; // 0x59
		[SerializeField]
		private string _inputName; // 0x60
		[SerializeField]
		private string _labelName; // 0x68
		[SerializeField]
		internal string _paramName; // 0x70
		[SerializeField]
		private int _connectedNodeID; // 0x78
		[SerializeField]
		private bool _keepWorldTransform; // 0x7C
		[SerializeField]
		private bool _packGeometryBeforeMerging; // 0x7D
		[SerializeField]
		private HEU_HoudiniAsset _parentAsset; // 0x80
		[SerializeField]
		private HEU_InputInterfaceMeshSettings _meshSettings; // 0x88
		[SerializeField]
		private HEU_InputInterfaceTilemapSettings _tilemapSettings; // 0x90
		[SerializeField]
		private HEU_InputInterfaceSplineSettings _splineSettings; // 0x98
		[SerializeField]
		internal bool _usingSelectFromHierarchy; // 0xA0
		public HEU_InputNodeUICache _uiCache; // 0xA8
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000184D86260-0x0000000184D86270 
		public bool KeepWorldTransform { get; set; } // 0x0000000184D92E50-0x0000000184D92E60 0x0000000184D92E60-0x0000000184D92E70
		public bool PackGeometryBeforeMerging { get; set; } // 0x0000000184DA26A0-0x0000000184DA26B0 0x0000000184DA26B0-0x0000000184DA26C0
		public HEU_InputNodeTypeWrapper NodeType { get; } // 0x0000000189D5DBC0-0x0000000189D5DBE0 
		public HEU_InputObjectTypeWrapper ObjectType { get; } // 0x0000000189D5DBE0-0x0000000189D5DBEC 
		public HEU_InputObjectTypeWrapper PendingObjectType { get; set; } // 0x0000000189D5DBEC-0x0000000189D5DBF8 0x0000000189D5DBF8-0x0000000189D5DC18
		public int InputNodeID { get; } // 0x0000000184D86550-0x0000000184D86560 
		public string InputName { get; } // 0x0000000184D86280-0x0000000184D86290 
		public string LabelName { get; } // 0x0000000184D86230-0x0000000184D86240 
		public string ParamName { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public HEU_InputInterfaceMeshSettings MeshSettings { get; } // 0x0000000184D861F0-0x0000000184D86200 
		public HEU_InputInterfaceTilemapSettings TilemapSettings { get; } // 0x0000000184D86220-0x0000000184D86230 
		public HEU_InputInterfaceSplineSettings SplineSettings { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		internal InputNodeType InputType { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		internal List<HEU_InputObjectInfo> InputObjects { get; } // 0x0000000184D86240-0x0000000184D86250 
		internal List<HEU_InputHDAInfo> InputAssetInfos { get; } // 0x0000000184D86200-0x0000000184D86210 
		internal bool RequiresCook { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
		internal bool RequiresUpload { get; set; } // 0x0000000184D8EF10-0x0000000184D8EF20 0x0000000184D8EF20-0x0000000184D8EF30
	
		// Nested types
		internal enum InputNodeType // TypeDefIndex: 52953
		{
			CONNECTION = 0,
			NODE = 1,
			PARAMETER = 2
		}
	
		[Serializable]
		internal enum InputObjectType // TypeDefIndex: 52954
		{
			HDA = 0,
			UNITY_MESH = 1,
			CURVE = 2,
			TERRAIN = 3,
			BOUNDING_BOX = 4,
			TILEMAP = 5
		}
	
		public enum InternalObjectType // TypeDefIndex: 52955
		{
			UNKNOWN = 0,
			HDA = 1,
			UNITY_MESH = 2
		}
	
		public enum InputActions // TypeDefIndex: 52956
		{
			ACTION = 0,
			DELETE = 1,
			INSERT = 2
		}
	
		// Constructors
		public HEU_InputNode(); // 0x0000000189D5D9F0-0x0000000189D5DBC0
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x0000000189D5A3AC-0x0000000189D5A444
		public void Recook(); // 0x0000000189D5C1F8-0x0000000189D5C264
		public bool IsAssetInput(); // 0x0000000189D5ADF4-0x0000000189D5ADFC
		public int NumInputEntries(); // 0x0000000189D5B844-0x0000000189D5B8B8
		public GameObject GetInputEntryGameObject(int index); // 0x0000000189D59FFC-0x0000000189D5A210
		public GameObject[] GetInputEntryGameObjects(); // 0x0000000189D5A210-0x0000000189D5A368
		public void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x02331EAC */); // 0x0000000189D5C9BC-0x0000000189D5CC18
		public void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x02331EAD */); // 0x0000000189D5AAC0-0x0000000189D5AD1C
		public void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x02331EAE */); // 0x0000000189D59070-0x0000000189D59110
		public void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x02331EAF */); // 0x0000000189D5C544-0x0000000189D5C588
		public void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x02331EB0 */); // 0x0000000189D59250-0x0000000189D592B8
		public void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x02331EB1 */); // 0x0000000189D5C2CC-0x0000000189D5C4F4
		public void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x02331EB2 */); // 0x0000000189D5C264-0x0000000189D5C2CC
		public void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x02331EB3 */); // 0x0000000189D5C904-0x0000000189D5C9BC
		public void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x02331EB4 */); // 0x0000000189D5C840-0x0000000189D5C904
		public void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x02331EB5 */); // 0x0000000189D5C6B0-0x0000000189D5C778
		public void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x02331EB6 */); // 0x0000000189D5C778-0x0000000189D5C840
		public bool AreAnyInputHDAsConnected(); // 0x0000000189D59110-0x0000000189D59250
		public int GetConnectedInputCount(); // 0x0000000189D59ECC-0x0000000189D59F40
		public int GetConnectedNodeID(int index); // 0x0000000189D59F40-0x0000000189D59FFC
		public void LoadPreset(HEU_InputPreset inputPreset); // 0x0000000189D5B1E0-0x0000000189D5B218
		public void PopulateInputPreset(HEU_InputPreset inputPreset, bool sceneRelativeGameObjects); // 0x0000000189D5B8B8-0x0000000189D5BFCC
		internal static HEU_InputNode CreateSetupInput(int nodeID, int inputIndex, string inputName, string labelName, InputNodeType inputNodeType, HEU_HoudiniAsset parentAsset); // 0x0000000189D599F4-0x0000000189D59AA8
		internal void SetInputNodeID(int nodeID); // 0x0000000184D865A0-0x0000000184D865B0
		internal void DestroyAllData(HEU_SessionBase session); // 0x0000000189D59AA8-0x0000000189D59AEC
		private void ResetInputObjectTransforms(); // 0x0000000189D5C5D4-0x0000000189D5C6B0
		internal void ResetInputNode(HEU_SessionBase session); // 0x0000000189D5C588-0x0000000189D5C5D4
		internal HEU_InputObjectInfo AddInputEntryAtEndMesh(GameObject newEntryGameObject); // 0x0000000189D59034-0x0000000189D59070
		internal HEU_InputHDAInfo AddInputEntryAtEndHDA(GameObject newEntryGameObject); // 0x0000000189D58FF8-0x0000000189D59034
		internal void ChangeInputType(HEU_SessionBase session, InputObjectType newType); // 0x0000000189D592B8-0x0000000189D592E8
		internal void ResetConnectionForForceUpdate(HEU_SessionBase session); // 0x0000000189D5C4F4-0x0000000189D5C544
		internal void UploadInput(HEU_SessionBase session); // 0x0000000189D5D008-0x0000000189D5D3A8
		private void UploadHDAInput(HEU_SessionBase session); // 0x0000000189D5CD84-0x0000000189D5CEAC
		private void UploadUnityInput(HEU_SessionBase session); // 0x0000000189D5D4C0-0x0000000189D5D9F0
		internal void ReconnectToUpstreamAsset(); // 0x0000000189D5BFCC-0x0000000189D5C1F8
		private HEU_InputObjectInfo CreateInputObjectInfo(GameObject inputGameObject); // 0x0000000189D59980-0x0000000189D599F4
		private HEU_InputHDAInfo CreateInputHDAInfo(GameObject inputGameObject); // 0x0000000189D59918-0x0000000189D59980
		private HEU_InputObjectInfo InternalAddInputObjectAtEnd(GameObject newInputGameObject); // 0x0000000189D5AD88-0x0000000189D5ADF4
		private HEU_InputHDAInfo InternalAddInputHDAAtEnd(GameObject newInputHDA); // 0x0000000189D5AD1C-0x0000000189D5AD88
		private void DisconnectConnectedMergeNode(HEU_SessionBase session); // 0x0000000189D59C7C-0x0000000189D59DB0
		private void ClearConnectedInputHDAs(); // 0x0000000189D592E8-0x0000000189D594B4
		private void ConnectToMergeObject(HEU_SessionBase session); // 0x0000000189D594CC-0x0000000189D59570
		private void DisconnectAndDestroyInputs(HEU_SessionBase session); // 0x0000000189D59AEC-0x0000000189D59C7C
		internal bool UploadObjectMergeTransformType(HEU_SessionBase session); // 0x0000000189D5D434-0x0000000189D5D4C0
		private bool UploadObjectMergePackGeometry(HEU_SessionBase session); // 0x0000000189D5D3A8-0x0000000189D5D434
		internal bool HasInputNodeTransformChanged(); // 0x0000000189D5A604-0x0000000189D5AA70
		internal void UploadInputObjectTransforms(HEU_SessionBase session); // 0x0000000189D5CEAC-0x0000000189D5D008
		internal void UpdateOnAssetRecreation(HEU_SessionBase session); // 0x0000000189D5CC18-0x0000000189D5CD84
		internal void CopyInputValuesTo(HEU_SessionBase session, HEU_InputNode destInputNode); // 0x0000000189D59570-0x0000000189D59918
		internal void LoadPreset(HEU_SessionBase session, HEU_InputPreset inputPreset); // 0x0000000189D5B218-0x0000000189D5B7CC
		private bool FindAddToInputHDA(string gameObjectName); // 0x0000000189D59DB0-0x0000000189D59ECC
		internal void NotifyParentRemovedInput(); // 0x0000000189D5B7CC-0x0000000189D5B844
		internal void ClearUICache(); // 0x0000000189D594B4-0x0000000189D594CC
		internal void HandleSelectedObjectsForInputObjects(GameObject[] selectedObjects); // 0x0000000189D5A524-0x0000000189D5A604
		internal void HandleSelectedObjectsForInputHDAs(GameObject[] selectedObjects); // 0x0000000189D5A444-0x0000000189D5A524
		public bool IsEquivalentTo(HEU_InputNode other); // 0x0000000189D5ADFC-0x0000000189D5B1E0
		internal static InternalObjectType GetInternalObjectType(InputObjectType type); // 0x0000000189D5A368-0x0000000189D5A3AC
		internal static HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(InputNodeType inputNodeType); // 0x0000000189D4399C-0x0000000189D439BC
		internal static InputNodeType InputNodeType_InternalToWrapper(HEU_InputNodeTypeWrapper inputNodeType); // 0x0000000189D4399C-0x0000000189D439BC
		internal static HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(InputObjectType inputType); // 0x0000000189D5AA70-0x0000000189D5AAC0
		internal static InputObjectType InputObjectType_WrapperToInternal(HEU_InputObjectTypeWrapper inputType); // 0x0000000189D5AA70-0x0000000189D5AAC0
	}

	[Serializable]
	internal class HEU_InputObjectInfo : IEquivable<HEU_InputObjectInfo> // TypeDefIndex: 52958
	{
		// Fields
		public GameObject _gameObject; // 0x10
		[HideInInspector]
		public Terrain _terrainReference; // 0x18
		[HideInInspector]
		public HEU_BoundingVolume _boundingVolumeReference; // 0x20
		[HideInInspector]
		public Tilemap _tilemapReference; // 0x28
		public Matrix4x4 _syncdTransform; // 0x30
		public List<Matrix4x4> _syncdChildTransforms; // 0x70
		[FormerlySerializedAs("_useTransformOverride")]
		public bool _useTransformOffset; // 0x78
		[FormerlySerializedAs("_translateOverride")]
		public Vector3 _translateOffset; // 0x7C
		[FormerlySerializedAs("_rotateOverride")]
		public Vector3 _rotateOffset; // 0x88
		[FormerlySerializedAs("_scaleOverride")]
		public Vector3 _scaleOffset; // 0x94
		public System.Type _inputInterfaceType; // 0xA0
	
		// Constructors
		public HEU_InputObjectInfo(); // 0x0000000189D5E060-0x0000000189D5E160
	
		// Methods
		public void CopyTo(HEU_InputObjectInfo destObject); // 0x0000000189D5DC18-0x0000000189D5DD1C
		internal void SetReferencesFromGameObject(); // 0x0000000189D5DF78-0x0000000189D5E060
		public bool IsEquivalentTo(HEU_InputObjectInfo other); // 0x0000000189D5DD1C-0x0000000189D5DF78
	}

	[Serializable]
	internal class HEU_InputHDAInfo : IEquivable<HEU_InputHDAInfo> // TypeDefIndex: 52959
	{
		// Fields
		public GameObject _pendingGO; // 0x10
		public GameObject _connectedGO; // 0x18
		public int _connectedInputNodeID; // 0x20
		public int _connectedMergeNodeID; // 0x24
	
		// Constructors
		public HEU_InputHDAInfo(); // 0x0000000184DA2690-0x0000000184DA26A0
	
		// Methods
		public void CopyTo(HEU_InputHDAInfo destInfo); // 0x0000000189D58E90-0x0000000189D58ED4
		public bool IsEquivalentTo(HEU_InputHDAInfo other); // 0x0000000189D58ED4-0x0000000189D58F38
	}

	public class HEU_InputNodeUICache // TypeDefIndex: 52962
	{
		// Fields
		public List<HEU_InputObjectUICache> _inputObjectCache; // 0x10
		public List<HEU_InputAssetUICache> _inputAssetCache; // 0x18
	
		// Nested types
		public class HEU_InputObjectUICache // TypeDefIndex: 52960
		{
			// Constructors
			public HEU_InputObjectUICache(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class HEU_InputAssetUICache // TypeDefIndex: 52961
		{
			// Constructors
			public HEU_InputAssetUICache(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public HEU_InputNodeUICache(); // 0x0000000189D58F38-0x0000000189D58FF8
	}

	[Serializable]
	internal class HEU_InstanceInputUIState : ScriptableObject, IEquivable<HEU_InstanceInputUIState> // TypeDefIndex: 52963
	{
		// Fields
		public bool _showInstanceInputs; // 0x18
		public int _numInputsToShowUI; // 0x1C
		public int _inputsPageIndexUI; // 0x20
	
		// Constructors
		public HEU_InstanceInputUIState(); // 0x0000000189D5E2E0-0x0000000189D5E2F4
	
		// Methods
		internal void CopyTo(HEU_InstanceInputUIState dest); // 0x0000000189D5E160-0x0000000189D5E188
		public bool IsEquivalentTo(HEU_InstanceInputUIState other); // 0x0000000189D5E188-0x0000000189D5E2E0
	}

	public class HEU_ObjectInstanceInfo : ScriptableObject, IEquivable<HEU_ObjectInstanceInfo> // TypeDefIndex: 52964
	{
		// Fields
		public List<HEU_InstancedInput> _instancedInputs; // 0x18
		public HEU_PartData _partTarget; // 0x20
		public int _instancedObjectNodeID; // 0x28
		public string _instancedObjectPath; // 0x30
		public List<GameObject> _instances; // 0x38
	
		// Constructors
		public HEU_ObjectInstanceInfo(); // 0x0000000189D5E5CC-0x0000000189D5E698
	
		// Methods
		public bool IsEquivalentTo(HEU_ObjectInstanceInfo other); // 0x0000000189D5E4AC-0x0000000189D5E5CC
	}

	[Serializable]
	public class HEU_InstancedInput : IEquivable<HEU_InstancedInput> // TypeDefIndex: 52965
	{
		// Fields
		public GameObject _instancedGameObject; // 0x10
		public Vector3 _rotationOffset; // 0x18
		public Vector3 _scaleOffset; // 0x24
	
		// Constructors
		public HEU_InstancedInput(); // 0x0000000189D5E480-0x0000000189D5E4AC
	
		// Methods
		public bool IsEquivalentTo(HEU_InstancedInput other); // 0x0000000189D5E2F4-0x0000000189D5E480
	}

	public class HEU_ObjectNode : ScriptableObject, IHEU_ObjectNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_ObjectNode> // TypeDefIndex: 52966
	{
		// Fields
		[SerializeField]
		private string _objName; // 0x18
		[SerializeField]
		private HEU_HoudiniAsset _parentAsset; // 0x20
		[SerializeField]
		private HAPI_ObjectInfo _objectInfo; // 0x28
		[SerializeField]
		private List<HEU_GeoNode> _geoNodes; // 0x48
		[SerializeField]
		private HAPI_Transform _objectTransform; // 0x50
		internal List<int> _recentlyDestroyedParts; // 0x78
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public int ObjectID { get; } // 0x0000000184D86640-0x0000000184D86650 
		public string ObjectName { get; } // 0x000000018385B100-0x000000018385B110 
		public HAPI_ObjectInfo ObjectInfo { get; } // 0x0000000184DA26E0-0x0000000184DA2700 
		public List<HEU_GeoNode> GeoNodes { get; } // 0x0000000184D86200-0x0000000184D86210 
		public HAPI_Transform ObjectTransform { get; } // 0x0000000184DA2700-0x0000000184DA2720 
	
		// Constructors
		public HEU_ObjectNode(); // 0x0000000189D616B4-0x0000000189D61740
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x0000000189D607B4-0x0000000189D60848
		public void Recook(); // 0x0000000189D61298-0x0000000189D612FC
		public bool IsInstanced(); // 0x0000000184D86A90-0x0000000184D86AA0
		public bool IsVisible(); // 0x0000000184D86DC0-0x0000000184D86DD0
		public bool IsUsingMaterial(HEU_MaterialData materialData); // 0x0000000189D60EF8-0x0000000189D61024
		public void GetOutputGameObjects(List<GameObject> outputObjects); // 0x0000000189D60418-0x0000000189D6053C
		public void GetOutput(List<HEU_GeneratedOutput> outputs); // 0x0000000189D60690-0x0000000189D607B4
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject); // 0x0000000189D602C0-0x0000000189D60418
		public HEU_GeoNode GetGeoNode(string geoName); // 0x0000000189D60180-0x0000000189D602C0
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly); // 0x0000000189D5FDB4-0x0000000189D5FEE8
		public void GetOutputGeoNodes(List<HEU_GeoNode> outGeoNodes); // 0x0000000189D6053C-0x0000000189D60690
		public void HideAllGeometry(); // 0x0000000189D60848-0x0000000189D6095C
		public void DisableAllColliders(); // 0x0000000189D5ED20-0x0000000189D5EE34
		public bool IsInstancer(); // 0x0000000189D60DD4-0x0000000189D60EF8
		internal void Reset(); // 0x0000000189D612FC-0x0000000189D613FC
		private void SyncWithObjectInfo(HEU_SessionBase session); // 0x0000000189D613FC-0x0000000189D614CC
		internal void Initialize(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, HAPI_Transform objectTranform, HEU_HoudiniAsset parentAsset, bool bUseOutputNodes, bool bGetEditableNodes); // 0x0000000189D6095C-0x0000000189D60B5C
		internal void GatherAllAssetOutputsLegacy(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, ref List<HEU_GeoNode> geoNodes); // 0x0000000189D5EE34-0x0000000189D5EEE0
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02331EC6 */); // 0x0000000189D5EC48-0x0000000189D5ED20
		private HEU_GeoNode CreateGeoNode(HEU_SessionBase session, HAPI_GeoInfo geoInfo); // 0x0000000189D5EB9C-0x0000000189D5EC48
		internal void GetDebugInfo(StringBuilder sb); // 0x0000000189D5FEE8-0x0000000189D60180
		internal void SetObjectInfo(HAPI_ObjectInfo newObjectInfo); // 0x0000000184DA26C0-0x0000000184DA26E0
		internal void UpdateObject(HEU_SessionBase session, bool bForceUpdate); // 0x0000000189D61528-0x0000000189D616B4
		internal void GenerateGeometry(HEU_SessionBase session, bool bRebuild); // 0x0000000189D5F004-0x0000000189D5F76C
		internal void GeneratePartInstances(HEU_SessionBase session); // 0x0000000189D5FB4C-0x0000000189D5FC70
		internal void GenerateAttributesStore(HEU_SessionBase session); // 0x0000000189D5EEE0-0x0000000189D5F004
		internal void ApplyObjectTransformToGeoNodes(); // 0x0000000189D5E698-0x0000000189D5E7B8
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x0000000189D5FC70-0x0000000189D5FDB4
		internal void GenerateObjectInstances(HEU_SessionBase session); // 0x0000000189D5F76C-0x0000000189D5FB4C
		internal void ClearObjectInstances(HEU_SessionBase session); // 0x0000000189D5E9EC-0x0000000189D5EB9C
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos); // 0x0000000189D61024-0x0000000189D61174
		internal void ProcessUnityScriptAttributes(HEU_SessionBase session); // 0x0000000189D61174-0x0000000189D61298
		internal void CalculateVisibility(); // 0x0000000189D5E8CC-0x0000000189D5E9EC
		internal void CalculateColliderState(); // 0x0000000189D5E7B8-0x0000000189D5E8CC
		public override string ToString(); // 0x0000000189D614CC-0x0000000189D61528
		public bool IsEquivalentTo(HEU_ObjectNode other); // 0x0000000189D60B5C-0x0000000189D60DD4
	}

	public class HEU_PartData : ScriptableObject, IHEU_PartData, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_PartData> // TypeDefIndex: 52972
	{
		// Fields
		[SerializeField]
		private int _partID; // 0x18
		[SerializeField]
		private string _partName; // 0x20
		[SerializeField]
		private int _objectNodeID; // 0x28
		[SerializeField]
		private int _geoID; // 0x2C
		[SerializeField]
		private HAPI_PartType _partType; // 0x30
		[SerializeField]
		private HEU_GeoNode _geoNode; // 0x38
		[SerializeField]
		private bool _isAttribInstancer; // 0x40
		[SerializeField]
		private bool _isPartInstanced; // 0x41
		[SerializeField]
		private int _partPointCount; // 0x44
		[SerializeField]
		private bool _isObjectInstancer; // 0x48
		[SerializeField]
		internal bool _objectInstancesGenerated; // 0x49
		[SerializeField]
		private List<HEU_ObjectInstanceInfo> _objectInstanceInfos; // 0x50
		[SerializeField]
		private Vector3 _terrainOffsetPosition; // 0x58
		[SerializeField]
		private UnityEngine.Object _assetDBTerrainData; // 0x68
		[SerializeField]
		private bool _isPartEditable; // 0x70
		[SerializeField]
		private PartOutputType _partOutputType; // 0x74
		[SerializeField]
		private HEU_Curve _curve; // 0x78
		[SerializeField]
		private HEU_AttributesStore _attributesStore; // 0x80
		[SerializeField]
		private bool _haveInstancesBeenGenerated; // 0x88
		[SerializeField]
		private int _meshVertexCount; // 0x8C
		[SerializeField]
		private HEU_GeneratedOutput _generatedOutput; // 0x90
		[SerializeField]
		private string _volumeLayerName; // 0x98
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000189D68F14-0x0000000189D68F84 
		public int PartID { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public string PartName { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public int GeoID { get; } // 0x0000000184D86710-0x0000000184D86720 
		public HAPI_PartType PartType { get; } // 0x0000000184D864F0-0x0000000184D86500 
		public HEU_GeoNode ParentGeoNode { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public List<HEU_ObjectInstanceInfo> ObjectInstanceInfos { get; } // 0x0000000184D86270-0x0000000184D86280 
		public HEU_Curve Curve { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public int MeshVertexCount { get; } // 0x0000000184D90C40-0x0000000184D90C50 
		public HEU_GeneratedOutput GeneratedOutput { get; } // 0x0000000184D86220-0x0000000184D86230 
		public GameObject OutputGameObject { get; } // 0x0000000189D68EEC-0x0000000189D68F14 
	
		// Nested types
		public enum PartOutputType // TypeDefIndex: 52967
		{
			NONE = 0,
			MESH = 1,
			VOLUME = 2,
			CURVE = 3,
			INSTANCER = 4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 52968
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<LOD> __9__96_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189D6955C-0x0000000189D695C0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _CopyGameObjectComponents_b__96_0(LOD a, LOD b); // 0x0000000189D690B4-0x0000000189D690CC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0 // TypeDefIndex: 52969
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass97_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CopyChildGameObjects_b__0(Transform trans); // 0x0000000189D69334-0x0000000189D693EC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0 // TypeDefIndex: 52970
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass99_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _BakePartToGameObject_b__0(Transform trans); // 0x0000000189D693EC-0x0000000189D694A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_1 // TypeDefIndex: 52971
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass99_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _BakePartToGameObject_b__1(Transform trans); // 0x0000000189D694A4-0x0000000189D6955C
		}
	
		// Constructors
		public HEU_PartData(); // 0x0000000189D68E68-0x0000000189D68EEC
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x0000000189D67B78-0x0000000189D67C1C
		public void Recook(); // 0x0000000189D684C8-0x0000000189D6853C
		public bool IsPartInstancer(); // 0x0000000189D682C8-0x0000000189D682D0
		public bool IsAttribInstancer(); // 0x0000000182D480A0-0x0000000182D480B0
		public bool IsInstancerAnyType(); // 0x0000000189D682AC-0x0000000189D682C0
		public bool IsPartInstanced(); // 0x0000000184D86F40-0x0000000184D86F50
		public int GetPartPointCount(); // 0x0000000184D86530-0x0000000184D86540
		public bool IsObjectInstancer(); // 0x0000000184D867D0-0x0000000184D867E0
		public bool IsPartVolume(); // 0x0000000189D682D8-0x0000000189D682E0
		public bool IsPartCurve(); // 0x0000000189D682C0-0x0000000189D682C8
		public bool IsPartMesh(); // 0x0000000189D682D0-0x0000000189D682D8
		public bool IsPartEditable(); // 0x0000000184D86A50-0x0000000184D86A60
		public bool HaveInstancesBeenGenerated(); // 0x00000001811F2750-0x00000001811F2760
		public void SetGameObjectName(string partName); // 0x0000000189D68560-0x0000000189D68758
		public void SetGameObject(GameObject gameObject); // 0x0000000189D68758-0x0000000189D68788
		public void SetVolumeLayerName(string name); // 0x0000000186352D0C-0x0000000186352D20
		public string GetVolumeLayerName(); // 0x0000000184D85EE0-0x0000000184D85EF0
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02331EC7 */); // 0x0000000189D65174-0x0000000189D652AC
		public bool IsUsingMaterial(HEU_MaterialData materialData); // 0x0000000189D682E0-0x0000000189D6830C
		public void GetOutputGameObjects(List<GameObject> outputObjects); // 0x0000000189D67A6C-0x0000000189D67B10
		public void GetOutput(List<HEU_GeneratedOutput> outputs); // 0x0000000189D67B10-0x0000000189D67B78
		public HEU_PartData GetHDAPartWithGameObject(GameObject inGameObject); // 0x0000000189D67888-0x0000000189D678F8
		public void CalculateVisibility(bool bParentVisibility, bool bParentDisplayGeo); // 0x0000000189D6250C-0x0000000189D62538
		public void ClearInstances(); // 0x0000000189D62638-0x0000000189D62720
		public HEU_Curve GetCurve(bool bEditableOnly); // 0x0000000189D6763C-0x0000000189D676C0
		public void SetVisiblity(bool bVisibility); // 0x0000000189D68A50-0x0000000189D68C18
		public void SetColliderState(bool bEnabled); // 0x0000000189D6853C-0x0000000189D68560
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(string path); // 0x0000000189D679A8-0x0000000189D67A6C
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(int objNodeID); // 0x0000000189D678F8-0x0000000189D679A8
		public void SetTerrainOffsetPosition(Vector3 offsetPosition); // 0x0000000184DA2720-0x0000000184DA2730
		public void SetTerrainData(TerrainData terrainData, string exportPathRelative, string exportPathUser); // 0x0000000189D688AC-0x0000000189D68A50
		internal void Initialize(HEU_SessionBase session, int partID, int geoID, int objectNodeID, HEU_GeoNode geoNode, ref HAPI_PartInfo partInfo, PartOutputType partOutputType, bool isEditable, bool isObjectInstancer, bool isAttribInstancer); // 0x0000000189D67C1C-0x0000000189D67DD8
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform); // 0x0000000189D6177C-0x0000000189D618B4
		internal void GetDebugInfo(StringBuilder sb); // 0x0000000189D676C0-0x0000000189D67888
		internal void GetClonableObjects(List<GameObject> clonableObjects); // 0x0000000189D674FC-0x0000000189D675A0
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x0000000189D675A0-0x0000000189D6763C
		private void SetObjectInstancer(bool bObjectInstancer); // 0x0000000184D86810-0x0000000184D86820
		private void ClearObjectInstanceInfos(); // 0x0000000189D62940-0x0000000189D629F8
		internal void ClearInvalidObjectInstanceInfos(); // 0x0000000189D62720-0x0000000189D62940
		internal void ClearGeneratedData(); // 0x0000000189D62538-0x0000000189D62554
		internal void ClearGeneratedMeshOutput(); // 0x0000000189D62554-0x0000000189D625F0
		internal void ClearGeneratedVolumeOutput(); // 0x0000000189D625F0-0x0000000189D62638
		internal bool GeneratePartInstances(HEU_SessionBase session); // 0x0000000189D67368-0x0000000189D674FC
		internal void GenerateInstancesFromObjectID(HEU_SessionBase session, int objectNodeID, string[] instancePrefixes, string[] instanceMaterialPaths); // 0x0000000189D6550C-0x0000000189D65974
		internal void GenerateInstancesFromObject(HEU_SessionBase session, HEU_ObjectNode sourceObject, string[] instancePrefixes, string[] instanceMaterialPaths); // 0x0000000189D65FF0-0x0000000189D66364
		internal void GenerateInstancesFromObjectIds(HEU_SessionBase session, string[] instancePrefixes, string[] instanceMaterialPaths); // 0x0000000189D65974-0x0000000189D65FF0
		internal void GenerateInstancesFromUnityAssetPathAttribute(HEU_SessionBase session, string unityInstanceAttr); // 0x0000000189D66364-0x0000000189D66F34
		private void CreateNewInstanceFromObject(GameObject sourceObject, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, int instancedObjectNodeID, string instancedObjectPath, Vector3 rotationOffset, Vector3 scaleOffset, string[] instancePrefixes, string[] instanceMaterialPaths, GameObject collisionSrcGO, bool copyParentFlags = true /* Metadata: 0x02331EC8 */); // 0x0000000189D64C34-0x0000000189D65028
		internal void GenerateAttributesStore(HEU_SessionBase session); // 0x0000000189D65470-0x0000000189D6550C
		internal void CalculateColliderState(); // 0x0000000189D62270-0x0000000189D6250C
		private static void CopyGameObjectComponents(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, List<HoudiniEngineUnity.TransformData> lodTransformValues); // 0x0000000189D62E60-0x0000000189D64C34
		private static void CopyChildGameObjects(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bKeepPreviousTransformValues); // 0x0000000189D62AB0-0x0000000189D62E60
		internal GameObject BakePartToNewGameObject(Transform parentTransform, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances); // 0x0000000189D62130-0x0000000189D62270
		internal static void BakePartToGameObject(HEU_PartData partData, GameObject srcGO, GameObject targetGO, string assetName, bool bIsInstancer, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues); // 0x0000000189D618B4-0x0000000189D61FE4
		internal void BakePartToGameObject(GameObject targetGO, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues); // 0x0000000189D61FE4-0x0000000189D62130
		internal bool GenerateMesh(HEU_SessionBase session, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups); // 0x0000000189D66F34-0x0000000189D67368
		internal void ProcessCurvePart(HEU_SessionBase session, int partId); // 0x0000000189D68360-0x0000000189D684C8
		internal void SyncAttributesStore(HEU_SessionBase session, int geoID, ref HAPI_PartInfo partInfo); // 0x0000000189D68CE4-0x0000000189D68E0C
		internal void SetupAttributeGeometry(HEU_SessionBase session); // 0x0000000189D68C18-0x0000000189D68CE4
		internal void DestroyAttributesStore(); // 0x0000000189D652AC-0x0000000189D65390
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos); // 0x0000000189D6830C-0x0000000189D68360
		internal void SetObjectInstanceInfos(List<HEU_ObjectInstanceInfo> sourceObjectInstanceInfos); // 0x0000000189D68788-0x0000000189D688AC
		internal List<HEU_ObjectInstanceInfo> GetObjectInstanceInfos(); // 0x0000000184D86270-0x0000000184D86280
		private HEU_ObjectInstanceInfo CreateObjectInstanceInfo(GameObject instancedObject, int instancedObjectNodeID, string instancedObjectPath); // 0x0000000189D65028-0x0000000189D65174
		internal static string AppendBakedCloneName(string name); // 0x0000000189D61740-0x0000000189D6177C
		public override string ToString(); // 0x0000000189D68E0C-0x0000000189D68E68
		internal static void DestroyParts(List<HEU_PartData> parts, bool bIsRebuild = false /* Metadata: 0x02331EC9 */); // 0x0000000189D653C4-0x0000000189D65470
		internal static void DestroyPart(HEU_PartData part, bool bIsRebuild = false /* Metadata: 0x02331ECA */); // 0x0000000189D65390-0x0000000189D653C4
		internal static bool ComposeUnityInstanceSplitHierarchy(HEU_SessionBase session, int geoID, int partID, Transform parentTransform, int numInstances, ref Transform[] instanceToChildTransform); // 0x0000000189D629F8-0x0000000189D62AB0
		public bool IsEquivalentTo(HEU_PartData other); // 0x0000000189D67DD8-0x0000000189D682AC
	}

	[Serializable]
	internal sealed class HEU_AttributeData : IEquivable<HEU_AttributeData> // TypeDefIndex: 52975
	{
		// Fields
		public HAPI_AttributeInfo _attributeInfo; // 0x10
		public string _name; // 0x38
		public AttributeType _attributeType; // 0x40
		public int[] _intValues; // 0x48
		public float[] _floatValues; // 0x50
		public string[] _stringValues; // 0x58
		public AttributeState _attributeState; // 0x60
	
		// Nested types
		public enum AttributeType // TypeDefIndex: 52973
		{
			UNDEFINED = -1,
			BOOL = 0,
			INT = 1,
			FLOAT = 2,
			STRING = 3,
			MAX = 4
		}
	
		public enum AttributeState // TypeDefIndex: 52974
		{
			INVALID = 0,
			SYNCED = 1,
			LOCAL_DIRTY = 2
		}
	
		// Constructors
		public HEU_AttributeData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsColorAttribute(); // 0x0000000189D556F4-0x0000000189D5574C
		internal void CopyValuesTo(HEU_AttributeData destAttrData); // 0x0000000189D555C0-0x0000000189D556F4
		public bool IsEquivalentTo(HEU_AttributeData other); // 0x0000000189D5574C-0x0000000189D55A58
	}

	internal class HEU_AttributesStore : ScriptableObject, IEquivable<HEU_AttributesStore> // TypeDefIndex: 52977
	{
		// Fields
		[SerializeField]
		private int _geoID; // 0x18
		[SerializeField]
		private int _partID; // 0x1C
		[SerializeField]
		private string _geoName; // 0x20
		[SerializeField]
		private List<HEU_AttributeData> _attributeDatas; // 0x28
		[SerializeField]
		private bool _hasColorAttribute; // 0x30
		[SerializeField]
		private Material _localMaterial; // 0x38
		[SerializeField]
		private Transform _outputTransform; // 0x40
		private Vector3[] _positionAttributeValues; // 0x48
		private int[] _vertexIndices; // 0x50
		[SerializeField]
		private GameObject _outputGameObject; // 0x58
		[SerializeField]
		private Mesh _outputMesh; // 0x60
		[SerializeField]
		private Material[] _outputMaterials; // 0x68
		[SerializeField]
		private MeshCollider _outputCollider; // 0x70
		[SerializeField]
		private Mesh _outputColliderMesh; // 0x78
		[SerializeField]
		private MeshCollider _outputMeshCollider; // 0x80
		[SerializeField]
		private MeshCollider _localMeshCollider; // 0x88
		[SerializeField]
		private bool _outputMeshRendererInitiallyEnabled; // 0x90
		[SerializeField]
		private bool _outputMeshColliderInitiallyEnabled; // 0x91
	
		// Properties
		public int GeoID { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public int PartID { get; } // 0x0000000184D86310-0x0000000184D86320 
		public string GeoName { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Transform OutputTransform { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public Mesh OutputMesh { get; } // 0x0000000184D86280-0x0000000184D86290 
	
		// Nested types
		public delegate void SetAttributeValueFunc(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // TypeDefIndex: 52976; 0x00000001814DD080-0x00000001814DD0A0
	
		// Constructors
		public HEU_AttributesStore(); // 0x0000000189D58AD0-0x0000000189D58BA0
	
		// Methods
		public bool HasColorAttribute(); // 0x0000000184D865F0-0x0000000184D86600
		public void DestroyAllData(HEU_HoudiniAsset asset); // 0x0000000189D55F3C-0x0000000189D56050
		public void SyncAllAttributesFrom(HEU_SessionBase session, HEU_HoudiniAsset asset, int geoID, ref HAPI_PartInfo partInfo, GameObject outputGameObject); // 0x0000000189D58494-0x0000000189D58714
		public void SetupMeshAndMaterials(HEU_HoudiniAsset asset, HAPI_PartType partType, GameObject outputGameObject); // 0x0000000189D57E40-0x0000000189D58208
		public bool HasDirtyAttributes(); // 0x0000000189D56A30-0x0000000189D56B54
		public void SyncDirtyAttributesToHoudini(HEU_SessionBase session); // 0x0000000189D58714-0x0000000189D58778
		private void PopulateAttributeData(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData, ref HAPI_AttributeInfo attributeInfo); // 0x0000000189D57320-0x0000000189D579F8
		private void GetAttributesList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributesList, HAPI_AttributeOwner ownerType, int attributeCount); // 0x0000000189D56938-0x0000000189D569A8
		private void UpdateAttribute(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData); // 0x0000000189D588C8-0x0000000189D58A24
		private void UpdateAttributeList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributeDataList); // 0x0000000189D58778-0x0000000189D588C8
		public void RefreshUpstreamInputs(HEU_SessionBase session); // 0x0000000189D579F8-0x0000000189D57A30
		public bool UploadAttributeViaMeshInput(HEU_SessionBase session, int geoID, int partID); // 0x0000000189D58A24-0x0000000189D58AD0
		private static void SetAttributeDataSyncd(HEU_AttributeData attributeData); // 0x0000000189D57C10-0x0000000189D57C2C
		public static void SetAttributeDataDirty(HEU_AttributeData attributeData); // 0x0000000189D57BF4-0x0000000189D57C10
		public HEU_AttributeData CreateAttribute(string attributeName, ref HAPI_AttributeInfo attributeInfo); // 0x0000000189D55E84-0x0000000189D55F3C
		public HEU_AttributeData GetAttributeData(string name); // 0x0000000189D563C4-0x0000000189D56504
		public HEU_AttributeData GetAttributeData(int index); // 0x0000000189D56504-0x0000000189D56574
		public List<string> GetAttributeNames(); // 0x0000000189D56574-0x0000000189D56708
		public void EnablePaintCollider(); // 0x0000000189D56168-0x0000000189D56310
		public void DisablePaintCollider(); // 0x0000000189D56050-0x0000000189D56168
		public void ShowPaintMesh(); // 0x0000000189D58208-0x0000000189D58310
		public void HidePaintMesh(); // 0x0000000189D56BA4-0x0000000189D56C7C
		public bool HasMeshForPainting(); // 0x0000000189D56B54-0x0000000189D56BA4
		public MeshCollider GetPaintMeshCollider(); // 0x0000000189D569A8-0x0000000189D56A10
		public void PaintAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools, int attributeIndex, float paintFactor, SetAttributeValueFunc setAttrFunc); // 0x0000000189D572BC-0x0000000189D57320
		public static void SetAttributeEditValueInt(HEU_AttributeData attributeData, int startIndex, int[] values); // 0x0000000189D57CA0-0x0000000189D57D14
		public static void SetAttributeEditValueFloat(HEU_AttributeData attributeData, int startIndex, float[] values); // 0x0000000189D57C2C-0x0000000189D57CA0
		public static void SetAttributeEditValueString(HEU_AttributeData attributeData, int startIndex, string[] values); // 0x0000000189D57D14-0x0000000189D57D9C
		public static void ReplaceAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D57AE4-0x0000000189D57BF4
		public static void AddAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D55B08-0x0000000189D55BD4
		public static void SubtractAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D583C8-0x0000000189D58494
		public static void MultiplyAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D571AC-0x0000000189D572BC
		public static void ReplaceAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D57A30-0x0000000189D57AE4
		public static void AddAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D55A58-0x0000000189D55B08
		public static void SubtractAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D58310-0x0000000189D583C8
		public static void MultiplyAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D570EC-0x0000000189D571AC
		public static void SetAttributeValueString(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x0000000189D57D9C-0x0000000189D57E40
		public void FillAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools); // 0x0000000189D56310-0x0000000189D563C4
		public bool AreAttributesDirty(); // 0x0000000189D55BD4-0x0000000189D55CEC
		public void GetPositionAttributeValues(out Vector3[] positionArray); // 0x0000000189D56A10-0x0000000189D56A20
		public void GetVertexIndices(out int[] indices); // 0x0000000189D56A20-0x0000000189D56A30
		public static SetAttributeValueFunc GetAttributeSetValueFunction(HEU_AttributeData.AttributeType attrType, HEU_ToolsInfo.PaintMergeMode paintMergeMode); // 0x0000000189D56708-0x0000000189D56938
		public void CopyAttributeValuesTo(HEU_AttributesStore destAttrStore); // 0x0000000189D55CEC-0x0000000189D55E84
		public bool IsValidStore(HEU_SessionBase session); // 0x0000000189D570D4-0x0000000189D570EC
		public bool IsEquivalentTo(HEU_AttributesStore other); // 0x0000000189D56C7C-0x0000000189D570D4
	}

	[Serializable]
	public class HEU_OutputAttribute // TypeDefIndex: 52978
	{
		// Fields
		public string _name; // 0x10
		public HAPI_AttributeOwner _class; // 0x18
		public HAPI_StorageType _type; // 0x1C
		public int _count; // 0x20
		public int _tupleSize; // 0x24
		public int[] _intValues; // 0x28
		public float[] _floatValues; // 0x30
		public string[] _stringValues; // 0x38
	
		// Constructors
		public HEU_OutputAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class HEU_OutputAttributeDictionary : HEU_SerializableDictionary<string, HEU_OutputAttribute> // TypeDefIndex: 52979
	{
		// Constructors
		public HEU_OutputAttributeDictionary(); // 0x0000000189D6F830-0x0000000189D6F858
	}

	public class HEU_OutputAttributesStore : MonoBehaviour // TypeDefIndex: 52980
	{
		// Fields
		[SerializeField]
		private HEU_OutputAttributeDictionary _attributes; // 0x18
	
		// Constructors
		public HEU_OutputAttributesStore(); // 0x0000000189D6F9D8-0x0000000189D6FA48
	
		// Methods
		public void SetAttribute(HEU_OutputAttribute attribute); // 0x0000000189D6F908-0x0000000189D6F9D8
		public HEU_OutputAttribute GetAttribute(string name); // 0x0000000189D6F8A0-0x0000000189D6F908
		public void Clear(); // 0x0000000189D6F858-0x0000000189D6F8A0
	}

	public static class HEU_AssetDatabase // TypeDefIndex: 52982
	{
		// Nested types
		public enum HEU_ImportAssetOptions // TypeDefIndex: 52981
		{
			Default = 0,
			ForceUpdate = 1,
			ForceSynchronousImport = 8,
			ImportRecursive = 256,
			DontDownloadFromCacheServer = 8192,
			ForceUncompressedImport = 16384
		}
	
		// Methods
		public static string GetAssetCachePath(); // 0x0000000189D6A53C-0x0000000189D6A584
		public static string GetUnityProjectPath(); // 0x0000000189D6AD18-0x0000000189D6AD74
		public static string GetAssetRelativePath(string inFullPath); // 0x0000000189D6A6D0-0x0000000189D6A810
		public static string GetPackagesRelativePath(string inFullPath); // 0x0000000189D6A9A0-0x0000000189D6AAC0
		public static string GetValidAssetPath(string inPath); // 0x0000000189D6AD74-0x0000000189D6B09C
		public static string GetAssetPath(UnityEngine.Object asset); // 0x0000000189D6A640-0x0000000189D6A678
		public static string GetAssetPathWithSubAssetSupport(UnityEngine.Object asset); // 0x0000000189D6A608-0x0000000189D6A640
		public static void GetSubAssetPathFromPath(string fullPath, out string mainPath, out string subPath); // 0x0000000189D6AAC0-0x0000000189D6AC30
		private static string GetAssetRelativePathStart(); // 0x0000000189D6A678-0x0000000189D6A6D0
		private static string GetPackagesRelativePathStart(); // 0x0000000189D6A948-0x0000000189D6A9A0
		public static string GetAssetFullPath(string inPath); // 0x0000000189D6A584-0x0000000189D6A5D0
		public static bool IsPathRelativeToAssets(string inPath); // 0x0000000189D6B2F4-0x0000000189D6B378
		public static bool IsPathRelativeToPackages(string inPath); // 0x0000000189D6B378-0x0000000189D6B3FC
		public static string GetAssetRootPath(UnityEngine.Object asset); // 0x0000000189D6A810-0x0000000189D6A848
		public static string GetUniqueAssetPath(string path); // 0x0000000189D6ACE0-0x0000000189D6AD18
		public static string GetAssetOrScenePath(UnityEngine.Object inputObject); // 0x0000000189D6A5D0-0x0000000189D6A608
		public static bool IsPathInAssetCache(string path); // 0x0000000189D6B1E8-0x0000000189D6B2F4
		public static bool IsPathInAssetCacheBakedFolder(string path); // 0x0000000189D6B178-0x0000000189D6B1B0
		public static bool IsPathInAssetCacheWorkingFolder(string path); // 0x0000000189D6B1B0-0x0000000189D6B1E8
		public static bool IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset); // 0x0000000189D6B0D0-0x0000000189D6B108
		public static bool IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset); // 0x0000000189D6B108-0x0000000189D6B140
		public static string CreateAssetCacheFolder(string suggestedAssetPath, int hash = 0 /* Metadata: 0x02331ED9 */); // 0x0000000189D6A2F0-0x0000000189D6A328
		public static void DeleteAssetCacheFolder(string assetCacheFolderPath); // 0x0000000189D6A430-0x0000000189D6A464
		public static void DeleteAsset(UnityEngine.Object asset); // 0x0000000189D6A498-0x0000000189D6A4CC
		public static void DeleteAssetAtPath(string path); // 0x0000000189D6A3FC-0x0000000189D6A430
		public static void DeleteAssetIfInBakedFolder(UnityEngine.Object asset); // 0x0000000189D6A464-0x0000000189D6A498
		public static bool ContainsAsset(UnityEngine.Object assetObject); // 0x0000000189D6A134-0x0000000189D6A16C
		public static bool CopyAsset(string path, string newPath); // 0x0000000189D6A24C-0x0000000189D6A284
		public static UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, string copyAssetFolder, string relativePath, System.Type type, bool bOverwriteExisting); // 0x0000000189D6A214-0x0000000189D6A24C
		public static UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting); // 0x0000000189D6A1DC-0x0000000189D6A214
		public static UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting); // 0x0000000189D6A16C-0x0000000189D6A1A4
		public static UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, string targetPath, System.Type type); // 0x0000000189D6A1A4-0x0000000189D6A1DC
		public static UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type); // 0x0000000189D6A284-0x0000000189D6A2BC
		public static void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, string assetCacheRoot, string relativeFolderPath, string assetFileName, System.Type type, bool bOverwriteExisting); // 0x0000000189D6A35C-0x0000000189D6A390
		public static void CreateAsset(UnityEngine.Object asset, string path); // 0x0000000189D6A328-0x0000000189D6A35C
		public static void CreateAddObjectInAssetCacheFolder(string assetName, string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref string exportRootPath, ref UnityEngine.Object assetDBObject); // 0x0000000189D6A2BC-0x0000000189D6A2F0
		public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject); // 0x0000000189D69E3C-0x0000000189D69E70
		public static void SaveAndRefreshDatabase(); // 0x00000001841E1670-0x00000001841E1680
		public static void SaveAssetDatabase(); // 0x00000001841E1670-0x00000001841E1680
		public static void RefreshAssetDatabase(); // 0x00000001841E1670-0x00000001841E1680
		public static UnityEngine.Object LoadAssetAtPath(string assetPath, System.Type type); // 0x0000000189D6B46C-0x0000000189D6B4A4
		public static UnityEngine.Object LoadSubAssetAtPath(string mainPath, string subAssetPath); // 0x0000000189D6B4A4-0x0000000189D6B53C
		public static UnityEngine.Object[] LoadAllAssetsAtPath(string assetPath); // 0x0000000189D6B434-0x0000000189D6B46C
		public static UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(string assetPath); // 0x0000000189D6B3FC-0x0000000189D6B434
		public static void ImportAsset(string assetPath, HEU_ImportAssetOptions heuOptions); // 0x0000000189D6B09C-0x0000000189D6B0D0
		public static string GetAssetWorkingPath(); // 0x0000000189D6A910-0x0000000189D6A948
		public static string GetAssetBakedPath(); // 0x0000000189D6A504-0x0000000189D6A53C
		public static string GetAssetBakedPathWithAssetName(string assetName); // 0x0000000189D6A4CC-0x0000000189D6A504
		public static string CreateUniqueBakePath(string assetName); // 0x0000000189D6A3C4-0x0000000189D6A3FC
		public static void CreatePathWithFolders(string inPath); // 0x0000000189D6A390-0x0000000189D6A3C4
		public static string AppendMeshesPathToAssetFolder(string inAssetCacheFolder); // 0x0000000189D69F28-0x0000000189D69FA4
		public static string AppendTexturesPathToAssetFolder(string inAssetCacheFolder); // 0x0000000189D6A0B8-0x0000000189D6A134
		public static string AppendMaterialsPathToAssetFolder(string inAssetCacheFolder); // 0x0000000189D69E70-0x0000000189D69EEC
		public static string AppendTerrainPathToAssetFolder(string inAssetCacheFolder); // 0x0000000189D6A03C-0x0000000189D6A0B8
		public static string[] GetAssetSubFolders(); // 0x0000000189D6A848-0x0000000189D6A910
		public static string AppendPrefabPath(string inAssetCacheFolder, string assetName); // 0x0000000189D69FA4-0x0000000189D6A03C
		public static string AppendMeshesAssetFileName(string assetName); // 0x0000000189D69EEC-0x0000000189D69F28
		public static bool IsSubAsset(UnityEngine.Object obj); // 0x00000001812081B0-0x0000000181208610
		public static string[] GetAssetPathsFromAssetBundle(string assetBundleFileName); // 0x00000001811EC580-0x00000001811EC590
		public static bool IsAssetSavedInScene(GameObject go); // 0x0000000189D6B140-0x0000000189D6B178
		public static void SelectAssetAtPath(string path); // 0x00000001841E1670-0x00000001841E1680
		public static void PrintDependencies(GameObject targetGO); // 0x00000001841E1670-0x00000001841E1680
		public static string GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj); // 0x0000000189D6AC30-0x0000000189D6ACE0
		public static bool IsValidFolderName(string name); // 0x0000000182FFF600-0x0000000182FFF610
		public static T LoadUnityAssetFromUniqueAssetPath<T>(string assetPath)
			where T : UnityEngine.Object;
		public static T GetBuiltinExtraResource<T>(string resourceName)
			where T : UnityEngine.Object;
	}

	public class HEU_Defines // TypeDefIndex: 52983
	{
		// Fields
		public const string HEU_PRODUCT_NAME = "HoudiniEngine"; // Metadata: 0x02331EE7
		public const string HEU_NAME = "Houdini Engine"; // Metadata: 0x02331EF5
		public static string HEU_PLUGIN_PATH; // 0x00
		public static string HEU_TEXTURES_PATH; // 0x08
		public static string HEU_BAKED_ASSETS_PATH; // 0x10
		public static string HEU_ENGINE_ASSETS; // 0x18
		public const string HAPI_PATH = "HAPI_PATH"; // Metadata: 0x02331F04
		public const string HEU_ENVPATH_PREFIX = "HEU_ENVPATH_"; // Metadata: 0x02331F0E
		public const string HEU_ENVPATH_KEY = "$"; // Metadata: 0x02331F1B
		public const int HEU_INVALID_NODE_ID = -1; // Metadata: 0x02331F1D
		public const string HEU_DEFAULT_ASSET_NAME = "HoudiniAssetRoot"; // Metadata: 0x02331F1E
		public const string HEU_SESSION_PIPENAME = "hapi"; // Metadata: 0x02331F2F
		public const string HEU_SESSION_LOCALHOST = "localhost"; // Metadata: 0x02331F34
		public const int HEU_SESSION_PORT = 9090; // Metadata: 0x02331F3E
		public const string HEU_SESSION_SHARED_MEMORY_NAME = "hapi"; // Metadata: 0x02331F42
		public const int HEU_SESSION_SHARED_MEMORY_BUFFER_SIZE = 100; // Metadata: 0x02331F47
		public const HAPI_ThriftSharedMemoryBufferType HEU_SESSION_SHARED_MEMORY_BUFFER_TYPE = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER; // Metadata: 0x02331F49
		public const float HEU_SESSION_TIMEOUT = 100000f; // Metadata: 0x02331F4A
		public const bool HEU_SESSION_AUTOCLOSE = true; // Metadata: 0x02331F4E
		public const int HAPI_MAX_PAGE_SIZE = 500000; // Metadata: 0x02331F4F
		public const int HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW = 3; // Metadata: 0x02331F53
		public const int HAPI_MAX_VERTICES_PER_FACE = 3; // Metadata: 0x02331F54
		public const bool HAPI_CURVE_REFINE_TO_LINEAR = true; // Metadata: 0x02331F55
		public const float HAPI_CURVE_LOD = 8f; // Metadata: 0x02331F56
		public const float HAPI_VOLUME_POSITION_MULT = 2f; // Metadata: 0x02331F5A
		public const float HAPI_VOLUME_SURFACE_MAX_PT_PER_C = 64000f; // Metadata: 0x02331F5E
		public const float HAPI_VOLUME_SURFACE_DELTA_MULT = 1.2f; // Metadata: 0x02331F62
		public const float HAPI_VOLUME_SURFACE_PT_SIZE_MULT = 1800f; // Metadata: 0x02331F66
		public const string DEFAULT_TOP_NODE_FILTER = "HE_"; // Metadata: 0x02331F6A
		public const string DEFAULT_TOP_OUTPUT_FILTER = "HE_OUT_"; // Metadata: 0x02331F6E
		public const string HAPI_ATTRIB_ORIENT = "orient"; // Metadata: 0x02331F76
		public const string HAPI_ATTRIB_ROTATION = "rot"; // Metadata: 0x02331F7D
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x02331F81
		public const string HAPI_ATTRIB_ALPHA = "Alpha"; // Metadata: 0x02331F87
		public const string HAPI_HANDLE_TRANSFORM = "xform"; // Metadata: 0x02331F8D
		public const int HAPI_MAX_UVS = 8; // Metadata: 0x02331F93
		public const string HAPI_OBJMERGE_TRANSFORM_PARAM = "xformtype"; // Metadata: 0x02331F94
		public const string HAPI_OBJMERGE_PACK_GEOMETRY = "pack"; // Metadata: 0x02331F9E
		public const string HAPI_OBJPATH_1_PARAM = "objpath1"; // Metadata: 0x02331FA3
		public const string NO_EXISTING_SESSION = "No existing session."; // Metadata: 0x02331FAC
		public const string HEU_ERROR_TITLE = "Houdini Engine Error"; // Metadata: 0x02331FC1
		public const string HEU_INSTALL_INFO = "Houdini Engine Installation Info"; // Metadata: 0x02331FD6
		public const string PLUGIN_STORE_KEYS = "HoudiniEnginePluginKeys"; // Metadata: 0x02331FF7
		public const string PLUGIN_STORE_DATA = "HoudiniEnginePluginData"; // Metadata: 0x0233200F
		public const string PLUGIN_SESSION_DATA = "HoudiniEngineSession"; // Metadata: 0x02332027
		public const string PLUGIN_SETTINGS_FILE = "heu_settings.ini"; // Metadata: 0x0233203C
		public const string PLUGIN_SESSION_FILE = "heu_session.txt"; // Metadata: 0x0233204D
		public const string COOK_LOGS_FILE = "cook_logs_file.txt"; // Metadata: 0x0233205D
		public const string DEFAULT_COLLISION_GEO = "collision_geo"; // Metadata: 0x02332070
		public const string DEFAULT_RENDERED_COLLISION_GEO = "rendered_collision_geo"; // Metadata: 0x0233207E
		public const string DEFAULT_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo"; // Metadata: 0x02332095
		public const string DEFAULT_CONVEX_COLLISION_GEO = "convex"; // Metadata: 0x023320B3
		public const string DEFAULT_SIMPLE_COLLISION_GEO = "collision_geo_simple"; // Metadata: 0x023320BA
		public const string DEFAULT_SIMPLE_RENDERED_COLLISION_GEO = "rendered_collision_geo_simple"; // Metadata: 0x023320CF
		public const string DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo_simple"; // Metadata: 0x023320ED
		public const string DEFAULT_COLLISION_TRIGGER = "trigger"; // Metadata: 0x02332112
		public const string DEFAULT_UNITY_MATERIAL_ATTR = "unity_material"; // Metadata: 0x0233211A
		public const string DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR = "unity_sub_material_name"; // Metadata: 0x02332129
		public const string DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR = "unity_sub_material_index"; // Metadata: 0x02332141
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR = "unity_hf_texture_diffuse"; // Metadata: 0x0233215A
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR = "unity_hf_texture_mask"; // Metadata: 0x02332173
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR = "unity_hf_texture_normal"; // Metadata: 0x02332189
		public const string DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR = "unity_hf_normal_scale"; // Metadata: 0x023321A1
		public const string DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR = "unity_hf_metallic"; // Metadata: 0x023321B7
		public const string DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR = "unity_hf_smoothness"; // Metadata: 0x023321C9
		public const string DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR = "unity_hf_specular"; // Metadata: 0x023321DD
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR = "unity_hf_tile_offset"; // Metadata: 0x023321EF
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR = "unity_hf_tile_size"; // Metadata: 0x02332204
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR = "unity_hf_terraindata_file"; // Metadata: 0x02332217
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR = "unity_hf_terraindata_export_file"; // Metadata: 0x02332231
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR = "unity_hf_terrainlayer_file"; // Metadata: 0x02332252
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH = "unity_hf_terraindata_export_path"; // Metadata: 0x0233226D
		public const string DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE = "unity_hf_height_range"; // Metadata: 0x0233228E
		public const string DEFAULT_UNITY_HEIGHTFIELD_YPOS = "unity_hf_ypos"; // Metadata: 0x023322A4
		public const string HEIGHTFIELD_TREEPROTOTYPE = "unity_hf_tree_prototype"; // Metadata: 0x023322B2
		public const string HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX = "unity_hf_treeinstance_prototypeindex"; // Metadata: 0x023322CA
		public const string HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE = "unity_hf_treeinstance_heightscale"; // Metadata: 0x023322EF
		public const string HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE = "unity_hf_treeinstance_widthscale"; // Metadata: 0x02332311
		public const string HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR = "unity_hf_treeinstance_lightmapcolor"; // Metadata: 0x02332332
		public const string HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH = "unity_hf_detail_resolution_patch"; // Metadata: 0x02332356
		public const string HEIGHTFIELD_UNITY_TILE = "unity_hf_tile"; // Metadata: 0x02332377
		public const string HEIGHTFIELD_DETAIL_DISTANCE = "unity_hf_detail_distance"; // Metadata: 0x02332385
		public const string HEIGHTFIELD_DETAIL_DENSITY = "unity_hf_detail_density"; // Metadata: 0x0233239E
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB = "unity_hf_detail_prototype_prefab"; // Metadata: 0x023323B6
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE = "unity_hf_detail_prototype_texture"; // Metadata: 0x023323D7
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR = "unity_hf_detail_prototype_bendfactor"; // Metadata: 0x023323F9
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR = "unity_hf_detail_prototype_drycolor"; // Metadata: 0x0233241E
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR = "unity_hf_detail_prototype_healthycolor"; // Metadata: 0x02332441
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT = "unity_hf_detail_prototype_maxheight"; // Metadata: 0x02332468
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH = "unity_hf_detail_prototype_maxwidth"; // Metadata: 0x0233248C
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT = "unity_hf_detail_prototype_minheight"; // Metadata: 0x023324AF
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH = "unity_hf_detail_prototype_minwidth"; // Metadata: 0x023324D3
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD = "unity_hf_detail_prototype_noisespread"; // Metadata: 0x023324F6
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE = "unity_hf_detail_prototype_rendermode"; // Metadata: 0x0233251C
		public const string HEIGHTFIELD_LAYER_ATTR_TYPE = "unity_hf_layer_type"; // Metadata: 0x02332541
		public const string HEIGHTFIELD_LAYER_TYPE_DETAIL = "detail"; // Metadata: 0x02332555
		public const string HAPI_HEIGHTFIELD_TILE_ATTR = "tile"; // Metadata: 0x0233255C
		public const string HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT = "height"; // Metadata: 0x02332561
		public const string HAPI_HEIGHTFIELD_LAYERNAME_MASK = "mask"; // Metadata: 0x02332568
		public const string MAT_OGL_DIFF_ATTR = "ogl_diff"; // Metadata: 0x0233256D
		public const string MAT_DIFF_ATTR = "basecolor"; // Metadata: 0x02332576
		public const string MAT_OGL_TEX1_ATTR = "ogl_tex1"; // Metadata: 0x02332580
		public const string MAT_OGL_TEX1_ATTR_ENABLED = "ogl_use_tex1"; // Metadata: 0x02332589
		public const string MAT_BASECOLOR_ATTR = "basecolor_texture"; // Metadata: 0x02332596
		public const string MAT_BASECOLOR_ATTR_ENABLED = "basecolor_useTexture"; // Metadata: 0x023325A8
		public const string MAT_MAP_ATTR = "map"; // Metadata: 0x023325BD
		public const string MAT_OGL_NORMAL_ATTR = "ogl_normalmap"; // Metadata: 0x023325C1
		public const string MAT_NORMAL_ATTR = "baseNormal_texture"; // Metadata: 0x023325CF
		public const string MAT_NORMAL_ATTR_ENABLED = "baseBumpAndNormal_enable"; // Metadata: 0x023325E2
		public const string MAT_OGL_SPEC_ATTR = "ogl_spec"; // Metadata: 0x023325FB
		public const string MAT_SPEC_ATTR = "reflect"; // Metadata: 0x02332604
		public const string MAT_OGL_SPEC_MAP_ATTR = "ogl_specmap"; // Metadata: 0x0233260C
		public const string MAT_OGL_SPEC_MAP_ATTR_ENABLED = "ogl_use_specmap"; // Metadata: 0x02332618
		public const string MAT_SPEC_MAP_ATTR = "reflect_texture"; // Metadata: 0x02332628
		public const string MAT_SPEC_MAP_ATTR_ENABLED = "reflect_useTexture"; // Metadata: 0x02332638
		public const string MAT_OGL_ROUGH_ATTR = "ogl_rough"; // Metadata: 0x0233264B
		public const string MAT_ROUGH_ATTR = "rough"; // Metadata: 0x02332655
		public const string MAT_OGL_ROUGH_MAP_ATTR = "ogl_roughmap"; // Metadata: 0x0233265B
		public const string MAT_OGL_ROUGH_MAP_ATTR_ENABLED = "ogl_use_roughmap"; // Metadata: 0x02332668
		public const string MAT_ROUGH_MAP_ATTR = "rough_texture"; // Metadata: 0x02332679
		public const string MAT_ROUGH_MAP_ATTR_ENABLED = "rough_useTexture"; // Metadata: 0x02332687
		public const string MAT_OGL_METALLIC_ATTR = "ogl_metallic"; // Metadata: 0x02332698
		public const string MAT_METALLIC_ATTR = "metallic"; // Metadata: 0x023326A5
		public const string MAT_OGL_METALLIC_MAP_ATTR = "ogl_metallicmap"; // Metadata: 0x023326AE
		public const string MAT_OGL_METALLIC_MAP_ATTR_ENABLED = "ogl_use_metallicmap"; // Metadata: 0x023326BE
		public const string MAT_METALLIC_MAP_ATTR = "metallic_texture"; // Metadata: 0x023326D2
		public const string MAT_METALLIC_MAP_ATTR_ENABLED = "metallic_useTexture"; // Metadata: 0x023326E3
		public const string MAT_OGL_EMISSIVE_ATTR = "ogl_emit"; // Metadata: 0x023326F7
		public const string MAT_EMISSIVE_ATTR = "emitcolor"; // Metadata: 0x02332700
		public const string MAT_OGL_EMISSIVE_MAP_ATTR = "ogl_emissionmap"; // Metadata: 0x0233270A
		public const string MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED = "ogl_use_emissionmap"; // Metadata: 0x0233271A
		public const string MAT_EMISSIVE_MAP_ATTR = "emitcolor_texture"; // Metadata: 0x0233272E
		public const string MAT_EMISSIVE_MAP_ATTR_ENABLED = "emitcolor_useTexture"; // Metadata: 0x02332740
		public const string MAT_OGL_ALPHA_ATTR = "ogl_alpha"; // Metadata: 0x02332755
		public const string MAT_ALPHA_ATTR = "opac"; // Metadata: 0x0233275F
		public const string MAT_OGL_OPACITY_MAP_ATTR = "ogl_opacitymap"; // Metadata: 0x02332764
		public const string MAT_OGL_OPACITY_MAP_ATTR_ENABLED = "ogl_use_opacitymap"; // Metadata: 0x02332773
		public const string MAT_OPACITY_MAP_ATTR = "opaccolor_texture"; // Metadata: 0x02332786
		public const string MAT_OPACITY_MAP_ATTR_ENABLED = "opaccolor_useTexture"; // Metadata: 0x02332798
		public const string MAT_OGL_TRANSPARENCY_ATTR = "ogl_transparency"; // Metadata: 0x023327AD
		public const string MAT_OGL_TRANSPARENCY_ATTR_ENABLED = "ogl_use_alpha_transparency"; // Metadata: 0x023327BE
		public const string MAT_OGL_OCCLUSION_MAP_ATTR = "ogl_occlusionmap"; // Metadata: 0x023327D9
		public const string MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED = "ogl_use_occlusionmap"; // Metadata: 0x023327EA
		public const string CURVE_COORDS_PARAM = "coords"; // Metadata: 0x023327FF
		public const string CURVE_TYPE_PARAM = "type"; // Metadata: 0x02332806
		public const string CURVE_METHOD_PARAM = "method"; // Metadata: 0x0233280B
		public const string CURVE_CLOSE_PARAM = "close"; // Metadata: 0x02332812
		public const string CURVE_REVERSE_PARAM = "reverse"; // Metadata: 0x02332818
		public const string HENGINE_STORE_ATTR = "hengine_attr_store"; // Metadata: 0x02332820
		public const string DEFAULT_UNITY_TAG_ATTR = "unity_tag"; // Metadata: 0x02332833
		public const string DEFAULT_UNITY_SCRIPT_ATTR = "unity_script"; // Metadata: 0x0233283D
		public const string DEFAULT_UNITY_INSTANCE_ATTR = "unity_instance"; // Metadata: 0x0233284A
		public const string UNITY_USE_INSTANCE_FLAGS_ATTR = "unity_use_instance_flags"; // Metadata: 0x02332859
		public const string DEFAULT_UNITY_INPUT_MESH_ATTR = "unity_input_mesh_name"; // Metadata: 0x02332872
		public const string DEFAULT_UNITY_STATIC_ATTR = "unity_static"; // Metadata: 0x02332888
		public const string DEFAULT_UNITY_LAYER_ATTR = "unity_layer"; // Metadata: 0x02332895
		public const string DEFAULT_UNITY_MESH_READABLE = "unity_mesh_readable"; // Metadata: 0x023328A1
		public const string DEFAULT_INSTANCE_PREFIX_ATTR = "instance_prefix"; // Metadata: 0x023328B5
		public const string UNITY_SHADER_COLOR = "_Color"; // Metadata: 0x023328C5
		public const string UNITY_SHADER_SPEC_COLOR = "_SpecColor"; // Metadata: 0x023328CC
		public const string UNITY_SHADER_SPEC_MAP = "_SpecMap"; // Metadata: 0x023328D7
		public const string UNITY_SHADER_METALLIC = "_Metallic"; // Metadata: 0x023328E0
		public const string UNITY_SHADER_METALLIC_MAP = "_MetallicMap"; // Metadata: 0x023328EA
		public const string UNITY_SHADER_BUMP_MAP = "_BumpMap"; // Metadata: 0x023328F7
		public const string UNITY_SHADER_EMISSION_COLOR = "_EmissionColor"; // Metadata: 0x02332900
		public const string UNITY_SHADER_EMISSION_MAP = "_EmissionMap"; // Metadata: 0x0233290F
		public const string UNITY_SHADER_SMOOTHNESS = "_Smoothness"; // Metadata: 0x0233291C
		public const string UNITY_SHADER_SMOOTHNESS_MAP = "_SmoothnessMap"; // Metadata: 0x02332928
		public const string UNITY_SHADER_SHININESS = "_Shininess"; // Metadata: 0x02332937
		public const string UNITY_SHADER_OCCLUSION = "_Occlusion"; // Metadata: 0x02332942
		public const string UNITY_SHADER_OCCLUSION_MAP = "_OcclusionMap"; // Metadata: 0x0233294D
		public const string UNITY_SHADER_OPACITY = "_Opacity"; // Metadata: 0x0233295B
		public const string UNITY_SHADER_OPACITY_MAP = "_OpacityMap"; // Metadata: 0x02332964
		public const string UNITY_EDITORONLY_TAG = "EditorOnly"; // Metadata: 0x02332970
		public const string UNITY_HDADATA_NAME = "HDA_Data"; // Metadata: 0x0233297B
		public const string HOUDINI_SHADER_PREFIX = "Houdini/"; // Metadata: 0x02332984
		public const string DEFAULT_STANDARD_SHADER = "HoudiniStandard"; // Metadata: 0x0233298D
		public const string DEFAULT_VERTEXCOLOR_SHADER = "HoudiniStandard"; // Metadata: 0x0233299D
		public const string DEFAULT_TRANSPARENT_SHADER = "HoudiniStandardAlpha"; // Metadata: 0x023329AD
		public const string DEFAULT_STANDARD_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x023329C2
		public const string DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x023329D2
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x023329ED
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x023329FD
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR = "HoudiniSpecularAlpha"; // Metadata: 0x02332A18
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY = "Legacy/AlphaSpecularVertexColor"; // Metadata: 0x02332A2D
		public const string DEFAULT_CURVE_SHADER = "LineShader"; // Metadata: 0x02332A4D
		public const string DEFAULT_TERRAIN_SHADER = "Nature/Terrain/Standard"; // Metadata: 0x02332A58
		public const string DEFAULT_STANDARD_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x02332A70
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x02332A81
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP = "HDRP/StandardLitAlpha"; // Metadata: 0x02332A92
		public const string DEFAULT_STANDARD_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x02332AA8
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x02332AB9
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR = "HDRP/SpecularLitAlpha"; // Metadata: 0x02332ACA
		public const string DEFAULT_CURVE_SHADER_HDRP = "HDRP/Color"; // Metadata: 0x02332AE0
		public const string DEFAULT_TERRAIN_SHADER_HDRP = "HDRP/TerrainLit"; // Metadata: 0x02332AEB
		public const string DEFAULT_STANDARD_SHADER_URP = "URP/StandardLit"; // Metadata: 0x02332AFB
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP = "URP/StandardLit"; // Metadata: 0x02332B0B
		public const string DEFAULT_TRANSPARENT_SHADER_URP = "URP/StandardLitAlpha"; // Metadata: 0x02332B1B
		public const string DEFAULT_STANDARD_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x02332B30
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x02332B40
		public const string DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR = "URP/SpecularLitAlpha"; // Metadata: 0x02332B50
		public const string DEFAULT_CURVE_SHADER_URP = "URP/Color"; // Metadata: 0x02332B65
		public const string DEFAULT_TERRAIN_SHADER_URP = "Universal Render Pipeline/Terrain/Lit"; // Metadata: 0x02332B6F
		public const string DEFAULT_UNITY_BUILTIN_RESOURCES = "Resources/unity_builtin_extra"; // Metadata: 0x02332B95
		public const string DEFAULT_TERRAIN_MATERIAL_PATH = "Resources/unity_builtin_extra::name::Default-Terrain-Standard"; // Metadata: 0x02332BB3
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_HDRP = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipelineResources/Material/DefaultHDTerrainMaterial.mat"; // Metadata: 0x02332BF1
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_URP = "Packages/com.unity.render-pipelines.universal/Runtime/Materials/TerrainLit.mat"; // Metadata: 0x02332C6C
		public const string DEFAULT_MATERIAL = "HEU_DEFAULT_MATERIAL"; // Metadata: 0x02332CBC
		public static int DEFAULT_MATERIAL_KEY; // 0x20
		public const string EDITABLE_MATERIAL = "HEU_EDITABLE_MATERIAL"; // Metadata: 0x02332CD1
		public static int EDITABLE_MATERIAL_KEY; // 0x24
		public const int HEU_INVALID_MATERIAL = -1; // Metadata: 0x02332CE7
		public const string HEU_ASSET_CACHE_PATH = "HoudiniEngineAssetCache"; // Metadata: 0x02332CE8
		public const string HEU_WORKING_PATH = "Working"; // Metadata: 0x02332D00
		public const string HEU_BAKED_PATH = "Baked"; // Metadata: 0x02332D08
		public const string HEU_BAKED_HDA = "_bakedHDA"; // Metadata: 0x02332D0E
		public const string HEU_BAKED_CLONE = "_bakedClone"; // Metadata: 0x02332D18
		public const string HEU_INSTANCE = "_Instance"; // Metadata: 0x02332D24
		public const string HEU_INSTANCE_PATTERN = "_Instance\\d*\\z"; // Metadata: 0x02332D2E
		public const string HEU_INSTANCE_SPLIT_ATTR = "unity_split_attr"; // Metadata: 0x02332D3D
		public const string HEU_DEFAULT_GEO_GROUP_NAME = "main_geo"; // Metadata: 0x02332D4E
		public const string HEU_DEFAULT_LOD_NAME = "lod"; // Metadata: 0x02332D57
		public const string HEU_UNITY_LOD_TRANSITION_ATTR = "lod_screensizes"; // Metadata: 0x02332D5B
		public const string HEU_SUBASSET = "SUBASSET::"; // Metadata: 0x02332D6B
		public const string HEU_HENGINE_TOOLS_SHIPPED_FOLDER = "<HFS>/engine/tools"; // Metadata: 0x02332D76
		public const string HEU_HENGINE_SHIPPED_SHELF = "Default"; // Metadata: 0x02332D89
		public const string HEU_PATH_KEY_PROJECT = "<PROJECT_PATH>"; // Metadata: 0x02332D91
		public const string HEU_PATH_KEY_PLUGIN = "<PLUGIN_PATH>"; // Metadata: 0x02332DA0
		public const string HEU_PATH_KEY_HFS = "<HFS>"; // Metadata: 0x02332DAE
		public const string HEU_PATH_KEY_TOOL = "HOUDINI_TOOL_PATH"; // Metadata: 0x02332DB4
		public const string HEU_USERMSG_NONEDITOR_NOT_SUPPORTED = "Houdini Engine does not support non-Editor asset creation at this time!"; // Metadata: 0x02332DC6
		public const string HEU_TERRAIN_SPLAT_DEFAULT = "Textures/heu_terrain_default_splat"; // Metadata: 0x02332E0F
		public const string HEU_FOLDER_MESHES = "Meshes"; // Metadata: 0x02332E32
		public const string HEU_FOLDER_MATERIALS = "Materials"; // Metadata: 0x02332E39
		public const string HEU_FOLDER_TERRAIN = "Terrain"; // Metadata: 0x02332E43
		public const string HEU_FOLDER_TILE = "Tile"; // Metadata: 0x02332E4B
		public const string HEU_FOLDER_TEXTURES = "Textures"; // Metadata: 0x02332E50
		public const string HEU_EXT_ASSET = ".asset"; // Metadata: 0x02332E59
		public const string HEU_EXT_MAT = ".mat"; // Metadata: 0x02332E60
		public const string HEU_EXT_TERRAINDATA = ".terraindata"; // Metadata: 0x02332E65
		public const string HEU_EXT_TERRAINLAYER = ".terrainlayer"; // Metadata: 0x02332E72
		public const string HEU_KEY_CTRL = "Ctrl"; // Metadata: 0x02332E80
	
		// Constructors
		public HEU_Defines(); // 0x00000001841E1670-0x00000001841E1680
		static HEU_Defines(); // 0x0000000189D6B53C-0x0000000189D6B708
	}

	public static class HEU_HAPIUtility // TypeDefIndex: 52984
	{
		// Methods
		public static string GetHoudiniEngineInstallationInfo(); // 0x0000000189D6D4F8-0x0000000189D6D524
		public static string GetEnvironmentPath(); // 0x0000000189D6CEAC-0x0000000189D6CF1C
		public static string GetRealPathFromHFSPath(string inPath); // 0x0000000189D6DDC4-0x0000000189D6DEE8
		public static bool DoesMappedPathExist(string inPath); // 0x0000000189D6C5F0-0x0000000189D6C660
		public static bool IsHoudiniAssetFile(string filePath); // 0x0000000189D6E100-0x0000000189D6E218
		public static string FindHoudiniAssetFileInPathWithExt(string filePath); // 0x0000000189D6C660-0x0000000189D6C7DC
		public static void Log(string message); // 0x0000000189D6E738-0x0000000189D6E740
		public static void LogWarning(string message); // 0x0000000189D6E730-0x0000000189D6E738
		public static void LogError(string message); // 0x0000000189D6E728-0x0000000189D6E730
		public static string LocateValidFilePath(UnityEngine.Object inObject); // 0x0000000189D6E6CC-0x0000000189D6E728
		public static string LocateValidFilePath(string assetName, string inFilePath); // 0x0000000184D88C30-0x0000000184D88C40
		public static GameObject InstantiateHDA(string filePath, Vector3 initialPosition, HEU_SessionBase session, bool bBuildAsync, bool bLoadFromMemory = false /* Metadata: 0x02332E85 */, bool bAlwaysOverwriteOnLoad = false /* Metadata: 0x02332E86 */, GameObject rootGO = null); // 0x0000000189D6DEE8-0x0000000189D6E100
		public static bool LoadHDAFile(HEU_SessionBase session, string assetPath, out int assetLibraryID, out string[] assetNames); // 0x0000000189D6E618-0x0000000189D6E6CC
		public static bool CreateAndCookAssetNode(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID); // 0x0000000189D6C04C-0x0000000189D6C0B8
		public static bool CreateAndCookCurveAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID); // 0x0000000189D6C0B8-0x0000000189D6C10C
		public static bool CreateAndCookInputAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID); // 0x0000000189D6C10C-0x0000000189D6C174
		public static bool CookNodeInHoudini(HEU_SessionBase session, int nodeID, bool bCookTemplatedGeos, string assetName); // 0x0000000189D6BE10-0x0000000189D6BE28
		public static bool CookNodeInHoudiniWithOptions(HEU_SessionBase session, int nodeID, HAPI_CookOptions options, string assetName); // 0x0000000189D6BE10-0x0000000189D6BE28
		public static HAPI_CookOptions GetDefaultCookOptions(HEU_SessionBase session); // 0x0000000189D6CE70-0x0000000189D6CEAC
		public static bool ProcessHoudiniCookStatus(HEU_SessionBase session, string assetName); // 0x0000000189D6E740-0x0000000189D6E7C0
		public static GameObject CreateNewAsset(HEU_AssetTypeWrapper assetType, string rootName = "HoudiniAsset" /* Metadata: 0x02332E87 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02332E94 */, GameObject rootGO = null); // 0x0000000189D6C174-0x0000000189D6C1C8
		internal static GameObject CreateNewAsset(HEU_HoudiniAsset.HEU_AssetType assetType, string rootName = "HoudiniAsset" /* Metadata: 0x02332E95 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02332EA2 */, GameObject rootGO = null); // 0x0000000189D6C1C8-0x0000000189D6C27C
		public static GameObject CreateNewCurveAsset(string name = "HoudiniCurve" /* Metadata: 0x02332EA3 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02332EB0 */, GameObject rootGO = null); // 0x0000000189D6C27C-0x0000000189D6C2B0
		public static GameObject CreateNewInputAsset(string name = "HoudiniInput" /* Metadata: 0x02332EB1 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02332EBE */, GameObject rootGO = null); // 0x0000000189D6C2B0-0x0000000189D6C2E4
		public static GameObject LoadGeoWithNewGeoSync(HEU_SessionBase session = null); // 0x00000001811EC580-0x00000001811EC590
		public static void DestroyChildren(Transform inTransform); // 0x0000000189D6C2E4-0x0000000189D6C5E0
		public static void DestroyGameObject(GameObject gameObect, bool bRegisterUndo = false /* Metadata: 0x02332EBF */); // 0x0000000189D6C5E0-0x0000000189D6C5F0
		public static void DestroyChildrenWithComponent<T>(GameObject gameObject)
			where T : Component;
		public static bool IsNodeValidInHoudini(HEU_SessionBase session, int nodeID); // 0x0000000189D6E218-0x0000000189D6E234
		public static HEU_HoudiniAssetRoot GetAssetInScene(int assetID); // 0x0000000189D6CD90-0x0000000189D6CE70
		public static void ApplyWorldTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform); // 0x0000000189D6BB9C-0x0000000189D6BE10
		public static void ApplyLocalTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform); // 0x0000000189D6B938-0x0000000189D6BAE8
		public static void ApplyLocalTransfromFromHoudiniToUnityForInstance(ref HAPI_Transform hapiTransform, Transform unityTransform); // 0x0000000189D6B708-0x0000000189D6B938
		public static void ApplyMatrixToLocalTransform(ref Matrix4x4 matrix, Transform transform); // 0x0000000189D6BAE8-0x0000000189D6BB9C
		public static Matrix4x4 GetMatrixFromHAPITransform(ref HAPI_Transform hapiTransform, bool bConvertToUnity = true /* Metadata: 0x02332EC0 */); // 0x0000000189D6D5D4-0x0000000189D6D7F8
		public static Quaternion GetQuaternion(ref Matrix4x4 m); // 0x0000000189D6D9FC-0x0000000189D6DDC4
		public static Vector3 GetPosition(ref Matrix4x4 m); // 0x0000000189D6D9B0-0x0000000189D6D9FC
		public static void SetMatrixPosition(ref Matrix4x4 m, ref Vector3 position); // 0x0000000189D6E7C0-0x0000000189D6E80C
		public static Vector3 GetScale(ref Matrix4x4 m); // 0x0000000184DA2840-0x0000000184DA2930
		public static HAPI_TransformEuler GetHAPITransformFromMatrix(ref Matrix4x4 mat); // 0x0000000189D6CF1C-0x0000000189D6D108
		public static HAPI_TransformEuler GetHAPITransform(ref Vector3 p, ref Vector3 r, ref Vector3 s); // 0x0000000189D6D364-0x0000000189D6D4F8
		public static HAPI_Transform GetHAPITransformQuatFromMatrix(ref Matrix4x4 mat); // 0x0000000189D6D108-0x0000000189D6D364
		public static Matrix4x4 GetMatrix4x4(ref Vector3 p, ref Vector3 r, ref Vector3 s); // 0x0000000189D6D524-0x0000000189D6D5D4
		public static bool IsSameTransform(ref Matrix4x4 transformMatrix, ref Vector3 p, ref Vector3 r, ref Vector3 s); // 0x0000000189D6E290-0x0000000189D6E348
		public static bool IsEqualTol(float a, float b, float t = 1E-05f /* Metadata: 0x02332EC1 */); // 0x0000000183418B30-0x0000000183418F00
		public static bool IsTransformEqual(ref HAPI_Transform transA, ref HAPI_Transform transB); // 0x0000000189D6E374-0x0000000189D6E51C
		public static bool IsViewportEqual(ref HAPI_Viewport viewA, ref HAPI_Viewport viewB); // 0x0000000189D6E51C-0x0000000189D6E618
		public static bool IsSessionSyncEqual(ref HAPI_SessionSyncInfo syncA, ref HAPI_SessionSyncInfo syncB); // 0x0000000189D6E348-0x0000000189D6E360
		public static bool DoesGeoPartHaveAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo); // 0x0000000189D6BE10-0x0000000189D6BE28
		public static void SetAnimationCurveTangentModes(AnimationCurve animCurve, List<int> tangentValues); // 0x00000001841E1670-0x00000001841E1680
		public static bool IsSupportedPolygonType(HAPI_PartType partType); // 0x0000000189D6E360-0x0000000189D6E374
		public static int GetParentNodeID(HEU_SessionBase session, int nodeID); // 0x0000000189D6D990-0x0000000189D6D9B0
		public static bool GetObjectInfos(HEU_SessionBase session, int assetID, ref HAPI_NodeInfo nodeInfo, out HAPI_ObjectInfo[] objectInfos, out HAPI_Transform[] objectTransforms); // 0x0000000189D6D7F8-0x0000000189D6D958
		public static bool ContainsSopNodes(HEU_SessionBase session, int nodeId); // 0x0000000189D6BE10-0x0000000189D6BE28
		public static bool IsObjNodeFullyVisible(HEU_SessionBase session, HashSet<int> allObjectIds, int inRootNodeId, int inChildNodeId); // 0x0000000189D6E234-0x0000000189D6E290
		public static bool GetOutputIndex(HEU_SessionBase session, int nodeId, ref int outputIndex); // 0x0000000189D6D958-0x0000000189D6D990
		internal static void GatherAllAssetGeoInfos(HEU_SessionBase session, HAPI_AssetInfo assetInfo, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, bool bGetEditableNodes, ref List<HAPI_GeoInfo> outGeoInfos); // 0x0000000189D6C7DC-0x0000000189D6C904
		internal static void GatherAllObjectGeoInfos(HEU_SessionBase session, int assetId, bool bUseOutputNodes, ref List<HAPI_GeoInfo> outGeoInfos); // 0x0000000189D6CCF4-0x0000000189D6CD90
		private static void GatherAllAssetOutputs(HEU_SessionBase session, int nodeId, bool bUseOutputNodes, bool bOutputTemplatedGeos, ref List<HAPI_GeoInfo> outGeoInfos); // 0x0000000189D6C904-0x0000000189D6CCF4
		public static string ToHapiVariableName(string name); // 0x0000000189D6E80C-0x0000000189D6E898
		public static void ConvertPositionUnityToHoudini(ref Vector3 position); // 0x0000000184DA27D0-0x0000000184DA27E0
		public static void ConvertPositionUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ); // 0x0000000184DA27B0-0x0000000184DA27D0
		public static Vector3 ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ); // 0x0000000184DA2790-0x0000000184DA27B0
		public static Vector3 ConvertPositionUnityToHoudini(Vector3 inputVec); // 0x0000000184DA2760-0x0000000184DA2790
		public static void ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ, ref Vector3 outputVec); // 0x0000000184DA27E0-0x0000000184DA2800
		public static void ConvertRotationUnityToHoudini(ref Quaternion rotation); // 0x0000000189D6BF6C-0x0000000189D6BFDC
		public static void ConvertRotationUnityToHoudini(Quaternion rotation, out float outputX, out float outputY, out float outputZ, out float outputW); // 0x0000000189D6BE28-0x0000000189D6BEDC
		public static Quaternion ConvertRotationUnityToHoudini(float inputX, float inputY, float inputZ, float inputW); // 0x0000000189D6BEDC-0x0000000189D6BF6C
		public static Quaternion ConvertRotationUnityToHoudini(Quaternion inputQuat); // 0x0000000189D6BFDC-0x0000000189D6C04C
		public static void ConvertScaleUnityToHoudini(ref Vector3 position); // 0x00000001841E1670-0x00000001841E1680
		public static void ConvertScaleUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ); // 0x0000000184DA2800-0x0000000184DA2820
		public static Vector3 ConvertScaleUnityToHoudini(float inputX, float inputY, float inputZ); // 0x0000000184DA2820-0x0000000184DA2840
		public static Vector3 ConvertScaleUnityToHoudini(Vector3 inputVec); // 0x0000000184D93250-0x0000000184D93270
	}

	public class HEU_HoudiniEngineError : Exception // TypeDefIndex: 52985
	{
		// Fields
		protected string _errorMsg; // 0x90
	
		// Constructors
		public HEU_HoudiniEngineError(); // 0x0000000189D6F7C8-0x0000000189D6F830
		public HEU_HoudiniEngineError(string errorMsg); // 0x0000000189D6F740-0x0000000189D6F7C8
	
		// Methods
		public override string ToString(); // 0x0000000184D86220-0x0000000184D86230
	}

	public class HEU_Platform // TypeDefIndex: 52986
	{
		// Fields
		private static string _lastErrorMsg; // 0x00
		private static string _libPath; // 0x08
		private static bool _pathSet; // 0x10
	
		// Properties
		public static string LibPath { get; } // 0x0000000189D7D048-0x0000000189D7D098 
		public static bool IsPathSet { get; } // 0x0000000189D7CFF8-0x0000000189D7D048 
		public static char DirectorySeparator { get; } // 0x0000000184DA29E0-0x0000000184DA29F0 
		public static string DirectorySeparatorStr { get; } // 0x0000000189D7CFCC-0x0000000189D7CFF8 
	
		// Constructors
		static HEU_Platform(); // 0x0000000189D7CFC4-0x0000000189D7CFCC
		public HEU_Platform(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string GetHoudiniEnginePath(); // 0x0000000189D7C8C4-0x0000000189D7C91C
		public static string GetHoudiniEngineDefaultPath(); // 0x0000000189D7C63C-0x0000000189D7C838
		public static string GetSavedHoudiniPath(); // 0x0000000189D7C93C-0x0000000189D7CA58
		public static void SetHapiClientName(); // 0x0000000189D7CDC4-0x0000000189D7CE0C
		public static void SetHoudiniEnginePath(); // 0x00000001841E1670-0x00000001841E1680
		public static string GetAllFoldersInPath(string path); // 0x0000000189D7C298-0x0000000189D7C348
		private static void GetAllFoldersInPathHelper(string inPath, StringBuilder pathBuilder); // 0x0000000189D7C178-0x0000000189D7C298
		public static string[] GetFilesInFolder(string folderPath, string searchPattern, bool bRecursive); // 0x0000000189D7C3F0-0x0000000189D7C508
		public static string GetFileName(string path); // 0x0000000189D7C3A4-0x0000000189D7C3F0
		public static string GetFileNameWithoutExtension(string path); // 0x0000000189D7C358-0x0000000189D7C3A4
		public static string GetFolderPath(string path, bool bRemoveDirectorySeparatorAtEnd = false /* Metadata: 0x02332EC5 */); // 0x0000000189D7C508-0x0000000189D7C5F0
		public static string BuildPath(string folder1, string folder2, params object[] args); // 0x0000000189D7C000-0x0000000189D7C110
		public static string TrimLastDirectorySeparator(string inPath); // 0x0000000189D7CE0C-0x0000000189D7CE9C
		public static bool DoesPathExist(string inPath); // 0x0000000189D7C148-0x0000000189D7C178
		public static bool DoesFileExist(string inPath); // 0x0000000189D7C140-0x0000000189D7C148
		public static bool DoesDirectoryExist(string inPath); // 0x0000000189D7C138-0x0000000189D7C140
		public static bool CreateDirectory(string inPath); // 0x0000000189D7C110-0x0000000189D7C138
		public static string GetParentDirectory(string inPath); // 0x0000000189D7C91C-0x0000000189D7C93C
		public static string GetFullPath(string inPath); // 0x0000000189D7C5F0-0x0000000189D7C63C
		public static bool IsPathRooted(string inPath); // 0x0000000189D7CA58-0x0000000189D7CAA4
		public static void WriteBytes(string path, byte[] bytes); // 0x0000000189D7CFBC-0x0000000189D7CFC4
		public static bool WriteAllText(string path, string text); // 0x0000000189D7CE9C-0x0000000189D7CFBC
		public static string ReadAllText(string path); // 0x0000000189D7CC6C-0x0000000189D7CDC4
		public static string GetEnvironmentValue(string key); // 0x0000000189D7C348-0x0000000189D7C358
		public static string GetHoudiniEngineEnvironmentFilePathFull(); // 0x0000000189D7C838-0x0000000189D7C8C4
		public static bool LoadFileIntoMemory(string path, out byte[] buffer); // 0x0000000189D7CAA4-0x0000000189D7CC6C
	}

	public static class HEU_PlatformWin // TypeDefIndex: 52988
	{
		// Fields
		public static UIntPtr HKEY_LOCAL_MACHINE; // 0x00
		public static UIntPtr HKEY_CURRENT_USER; // 0x08
	
		// Nested types
		public enum RegSAM // TypeDefIndex: 52987
		{
			QueryValue = 1,
			SetValue = 2,
			CreateSubKey = 4,
			EnumerateSubKeys = 8,
			Notify = 16,
			CreateLink = 32,
			WOW64_64Key = 256,
			WOW64_32Key = 512,
			WOW64_Res = 768,
			Write = 131078,
			Read = 131097,
			Execute = 131097,
			AllAccess = 983103
		}
	
		// Constructors
		static HEU_PlatformWin(); // 0x0000000189D7BFAC-0x0000000189D7C000
	
		// Methods
		private static extern uint RegOpenKeyEx(UIntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out int phkResult); // 0x0000000189D7BDE8-0x0000000189D7BEAC
		public static extern int RegQueryValueEx(int hKey, string lpValueName, int lpReserved, ref uint lpType, StringBuilder lpData, ref uint lpcbData); // 0x0000000189D7BEAC-0x0000000189D7BFAC
		private static extern uint RegCloseKey(int hKey); // 0x0000000189D7BD70-0x0000000189D7BDE8
		public static string GetRegistryKeyValue(UIntPtr rootKey, string keyName, RegSAM is32or64Key, string inPropertyName); // 0x0000000189D7BA98-0x0000000189D7BC98
		public static string GetRegistryKeyvalue_x86(UIntPtr rootKey, string keyName, string inPropertyName); // 0x0000000189D7BD04-0x0000000189D7BD70
		public static string GetRegistryKeyvalue_x64(UIntPtr rootKey, string keyName, string inPropertyName); // 0x0000000189D7BC98-0x0000000189D7BD04
		public static string GetApplicationPath(string appName); // 0x0000000189D7B758-0x0000000189D7BA98
	}

	public static class HEU_PluginSettings // TypeDefIndex: 52989
	{
		// Fields
		public static Action<bool> s_onEnableRawHoudiniChanged; // 0x00
	
		// Properties
		public static string HoudiniEngineEnvFilePath { get; set; } // 0x0000000189D7DDF0-0x0000000189D7DE64 0x0000000189D7FAB0-0x0000000189D7FB18
		public static bool EnableRawHoudini { get; set; } // 0x0000000189D7DB6C-0x0000000189D7DBCC 0x0000000189D7F88C-0x0000000189D7F95C
		public static bool CookingEnabled { get; set; } // 0x0000000189D7D360-0x0000000189D7D3C0 0x0000000189D7F524-0x0000000189D7F574
		public static bool CookingTriggersDownstreamCooks { get; set; } // 0x0000000189D7D3C0-0x0000000189D7D420 0x0000000189D7F574-0x0000000189D7F5C4
		public static bool CookDisabledGameObjects { get; set; } // 0x0000000189D7D1E0-0x0000000189D7D240 0x0000000189D7F3E4-0x0000000189D7F434
		public static bool CookTemplatedGeos { get; set; } // 0x0000000189D7D300-0x0000000189D7D360 0x0000000189D7F4D4-0x0000000189D7F524
		public static bool PushUnityTransformToHoudini { get; set; } // 0x0000000189D7E484-0x0000000189D7E4E4 0x0000000189D7FFC0-0x0000000189D80010
		public static bool TransformChangeTriggersCooks { get; set; } // 0x0000000189D7EBD8-0x0000000189D7EC38 0x0000000189D80580-0x0000000189D805D0
		public static bool ChildTransformChangeTriggersCooks { get; set; } // 0x0000000189D7D10C-0x0000000189D7D16C 0x0000000189D7F340-0x0000000189D7F390
		public static string CollisionGroupName { get; set; } // 0x0000000189D7D16C-0x0000000189D7D1E0 0x0000000189D7F390-0x0000000189D7F3E4
		public static string RenderedCollisionGroupName { get; set; } // 0x0000000189D7E4E4-0x0000000189D7E558 0x0000000189D80010-0x0000000189D80064
		public static string RenderedConvexCollisionGroupName { get; set; } // 0x0000000189D7E558-0x0000000189D7E5CC 0x0000000189D80064-0x0000000189D800B8
		public static string UnityMaterialAttribName { get; set; } // 0x0000000189D7ED94-0x0000000189D7EE08 0x0000000189D806CC-0x0000000189D80720
		public static string UnitySubMaterialAttribName { get; set; } // 0x0000000189D7EEF0-0x0000000189D7EF64 0x0000000189D807C8-0x0000000189D8081C
		public static string UnitySubMaterialIndexAttribName { get; set; } // 0x0000000189D7EF64-0x0000000189D7EFD8 0x0000000189D8081C-0x0000000189D80870
		public static string UnityTagAttributeName { get; set; } // 0x0000000189D7EFD8-0x0000000189D7F04C 0x0000000189D80870-0x0000000189D808C4
		public static string UnityStaticAttributeName { get; set; } // 0x0000000189D7EE7C-0x0000000189D7EEF0 0x0000000189D80774-0x0000000189D807C8
		public static string UnityScriptAttributeName { get; set; } // 0x0000000189D7EE08-0x0000000189D7EE7C 0x0000000189D80720-0x0000000189D80774
		public static string UnityLayerAttributeName { get; set; } // 0x0000000189D7ED20-0x0000000189D7ED94 0x0000000189D80678-0x0000000189D806CC
		public static float ImageGamma { get; set; } // 0x0000000189D7DED8-0x0000000189D7DF40 0x0000000189D7FB6C-0x0000000189D7FBC4
		public static float NormalGenerationThresholdAngle { get; set; } // 0x0000000189D7E41C-0x0000000189D7E484 0x0000000189D7FF68-0x0000000189D7FFC0
		public static string LastLoadHDAPath { get; set; } // 0x0000000189D7E238-0x0000000189D7E2AC 0x0000000189D7FE04-0x0000000189D7FE58
		public static string LastLoadHIPPath { get; set; } // 0x0000000189D7E2AC-0x0000000189D7E320 0x0000000189D7FE58-0x0000000189D7FEAC
		public static string InstanceAttr { get; set; } // 0x0000000189D7E0DC-0x0000000189D7E150 0x0000000189D7FD08-0x0000000189D7FD5C
		public static string UnityInstanceAttr { get; set; } // 0x0000000189D7ECAC-0x0000000189D7ED20 0x0000000189D80624-0x0000000189D80678
		public static string UnityInputMeshAttr { get; set; } // 0x0000000189D7EC38-0x0000000189D7ECAC 0x0000000189D805D0-0x0000000189D80624
		public static UnityEngine.Color LineColor { get; set; } // 0x0000000189D7E320-0x0000000189D7E3B8 0x0000000189D7FEAC-0x0000000189D7FF18
		public static bool UseHybridCurveEditing { get; set; } // 0x0000000189D7F10C-0x0000000189D7F16C 0x0000000189D80964-0x0000000189D809B4
		public static string EditorOnly_Tag { get; set; } // 0x0000000189D7DAF8-0x0000000189D7DB6C 0x0000000189D7F808-0x0000000189D7F88C
		public static string HDAData_Name { get; set; } // 0x0000000189D7DBCC-0x0000000189D7DC40 0x0000000189D7F95C-0x0000000189D7F9B0
		public static SessionMode Session_Mode { get; set; } // 0x0000000189D7E700-0x0000000189D7E768 0x0000000189D801AC-0x0000000189D801FC
		public static string Session_PipeName { get; set; } // 0x0000000189D7E768-0x0000000189D7E7DC 0x0000000189D801FC-0x0000000189D80250
		public static string Session_Localhost { get; set; } // 0x0000000189D7E68C-0x0000000189D7E700 0x0000000189D80158-0x0000000189D801AC
		public static int Session_Port { get; set; } // 0x0000000189D7E7DC-0x0000000189D7E840 0x0000000189D80250-0x0000000189D802A0
		public static string Session_SharedMemoryName { get; set; } // 0x0000000189D7E908-0x0000000189D7E97C 0x0000000189D80340-0x0000000189D80394
		public static int Session_SharedMemoryBufferSize { get; set; } // 0x0000000189D7E840-0x0000000189D7E8A4 0x0000000189D802A0-0x0000000189D802F0
		public static HAPI_ThriftSharedMemoryBufferType Session_SharedMemoryBufferType { get; set; } // 0x0000000189D7E8A4-0x0000000189D7E908 0x0000000189D802F0-0x0000000189D80340
		public static float Session_Timeout { get; set; } // 0x0000000189D7E97C-0x0000000189D7E9E4 0x0000000189D80394-0x0000000189D803EC
		public static bool Session_AutoClose { get; set; } // 0x0000000189D7E62C-0x0000000189D7E68C 0x0000000189D80108-0x0000000189D80158
		public static bool Curves_ShowInSceneView { get; set; } // 0x0000000189D7D420-0x0000000189D7D480 0x0000000189D7F5C4-0x0000000189D7F614
		public static string AssetCachePath { get; set; } // 0x0000000189D7D098-0x0000000189D7D10C 0x0000000189D7F2EC-0x0000000189D7F340
		public static bool UseFullPathNamesForOutput { get; set; } // 0x0000000189D7F04C-0x0000000189D7F0AC 0x0000000189D808C4-0x0000000189D80914
		public static List<string> HEngineToolsShelves { get; set; } // 0x0000000189D7DCA0-0x0000000189D7DD04 0x0000000189D7FA00-0x0000000189D7FA5C
		public static int HEngineShelfSelectedIndex { get; set; } // 0x0000000189D7DC40-0x0000000189D7DCA0 0x0000000189D7F9B0-0x0000000189D7FA00
		public static string DefaultTerrainMaterial { get; set; } // 0x0000000189D7D71C-0x0000000189D7D790 0x0000000189D7F6BC-0x0000000189D7F710
		public static string TerrainSplatTextureDefault { get; set; } // 0x0000000189D7EB64-0x0000000189D7EBD8 0x0000000189D8052C-0x0000000189D80580
		public static string DefaultStandardShader { get; set; } // 0x0000000189D7D598-0x0000000189D7D71C 0x0000000189D7F668-0x0000000189D7F6BC
		public static string DefaultVertexColorShader { get; set; } // 0x0000000189D7D914-0x0000000189D7DA98 0x0000000189D7F764-0x0000000189D7F7B8
		public static string DefaultTransparentShader { get; set; } // 0x0000000189D7D790-0x0000000189D7D914 0x0000000189D7F710-0x0000000189D7F764
		public static string DefaultCurveShader { get; set; } // 0x0000000189D7D480-0x0000000189D7D598 0x0000000189D7F614-0x0000000189D7F668
		public static bool SupportHoudiniBoxType { get; set; } // 0x0000000189D7EAA4-0x0000000189D7EB04 0x0000000189D8048C-0x0000000189D804DC
		public static bool SupportHoudiniSphereType { get; set; } // 0x0000000189D7EB04-0x0000000189D7EB64 0x0000000189D804DC-0x0000000189D8052C
		public static bool SetCurrentThreadToInvariantCulture { get; set; } // 0x0000000189D7E9E4-0x0000000189D7EA44 0x0000000189D803EC-0x0000000189D8043C
		public static string HoudiniDebugLaunchPath { get; set; } // 0x0000000189D7DD04-0x0000000189D7DDF0 0x0000000189D7FA5C-0x0000000189D7FAB0
		public static string LastExportPath { get; set; } // 0x0000000189D7E150-0x0000000189D7E1C4 0x0000000189D7FD5C-0x0000000189D7FDB0
		public static int InputSelectionFilterLocation { get; set; } // 0x0000000189D7DF40-0x0000000189D7DFA4 0x0000000189D7FBC4-0x0000000189D7FC14
		public static int InputSelectionFilterState { get; set; } // 0x0000000189D7E078-0x0000000189D7E0DC 0x0000000189D7FCB8-0x0000000189D7FD08
		public static bool InputSelectionFilterRoots { get; set; } // 0x0000000189D7E018-0x0000000189D7E078 0x0000000189D7FC68-0x0000000189D7FCB8
		public static string InputSelectionFilterName { get; set; } // 0x0000000189D7DFA4-0x0000000189D7E018 0x0000000189D7FC14-0x0000000189D7FC68
		public static bool CookOptionSplitGeosByGroup { get; set; } // 0x0000000189D7D2A0-0x0000000189D7D300 0x0000000189D7F484-0x0000000189D7F4D4
		public static int MaxVerticesPerPrimitive { get; set; } // 0x0000000189D7E3B8-0x0000000189D7E41C 0x0000000189D7FF18-0x0000000189D7FF68
		public static string HoudiniInstallPath { get; set; } // 0x0000000189D7DE64-0x0000000189D7DED8 0x0000000189D7FB18-0x0000000189D7FB6C
		public static string LastHoudiniVersion { get; set; } // 0x0000000189D7E1C4-0x0000000189D7E238 0x0000000189D7FDB0-0x0000000189D7FE04
		public static bool SessionSyncAutoCook { get; set; } // 0x0000000189D7E5CC-0x0000000189D7E62C 0x0000000189D800B8-0x0000000189D80108
		public static bool WriteCookLogs { get; set; } // 0x0000000189D7F28C-0x0000000189D7F2EC 0x0000000189D80AA4-0x0000000189D80AF4
		public static bool UseHDRColor { get; set; } // 0x0000000189D7F0AC-0x0000000189D7F10C 0x0000000189D80914-0x0000000189D80964
		public static bool UseSpecularShader { get; set; } // 0x0000000189D7F22C-0x0000000189D7F28C 0x0000000189D80A54-0x0000000189D80AA4
		public static bool UseLegacyShaders { get; set; } // 0x0000000189D7F1CC-0x0000000189D7F22C 0x0000000189D80A04-0x0000000189D80A54
		public static bool ShortenFolderPaths { get; set; } // 0x0000000189D7EA44-0x0000000189D7EAA4 0x0000000189D8043C-0x0000000189D8048C
		public static bool UseLegacyInputCurves { get; set; } // 0x0000000189D7F16C-0x0000000189D7F1CC 0x0000000189D809B4-0x0000000189D80A04
		public static bool CookOnMouseUp { get; set; } // 0x0000000189D7D240-0x0000000189D7D2A0 0x0000000189D7F434-0x0000000189D7F484
		public static bool EditableNodesToolsEnabled { get; set; } // 0x0000000189D7DA98-0x0000000189D7DAF8 0x0000000189D7F7B8-0x0000000189D7F808
	}

	public class HEU_PluginStorage // TypeDefIndex: 52993
	{
		// Fields
		protected Dictionary<string, StoreData> _dataMap; // 0x10
		private Dictionary<string, string> _envPathMap; // 0x18
		protected bool _requiresSave; // 0x20
		private static HEU_PluginStorage _instance; // 0x00
		public const string PluginSettingsLine1 = "Houdini Engine for Unity Plugin Settings"; // Metadata: 0x02332EE6
		public const string PluginSettingsLine2 = "Version="; // Metadata: 0x02332F0F
		public const string PluginSettingsVersion = "1.0"; // Metadata: 0x02332F18
	
		// Properties
		public bool RequiresSave { get; } // 0x0000000184D866B0-0x0000000184D866C0 
		public static HEU_PluginStorage Instance { get; } // 0x0000000189D82F3C-0x0000000189D82F90 
	
		// Nested types
		protected enum DataType // TypeDefIndex: 52990
		{
			BOOL = 0,
			INT = 1,
			LONG = 2,
			FLOAT = 3,
			STRING = 4
		}
	
		[Serializable]
		protected class StoreData // TypeDefIndex: 52991
		{
			// Fields
			public DataType _type; // 0x10
			public string _valueStr; // 0x18
	
			// Constructors
			public StoreData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		private class StoreDataArray<T> // TypeDefIndex: 52992
		{
			// Fields
			public T[] _array;
	
			// Constructors
			public StoreDataArray();
		}
	
		// Constructors
		public HEU_PluginStorage(); // 0x0000000189D82EC4-0x0000000189D82F3C
	
		// Methods
		public Dictionary<string, string> GetEnvironmentPathMap(); // 0x000000018385B100-0x000000018385B110
		public static void InstantiateAndLoad(); // 0x0000000189D816AC-0x0000000189D81794
		public static void SetCurrentCulture(bool useInvariant); // 0x00000001841E1670-0x00000001841E1680
		private T[] GetJSONArray<T>(string jsonArray);
		public void Set(string key, bool value); // 0x0000000189D82D50-0x0000000189D82E14
		public void Set(string key, int value); // 0x0000000189D82A8C-0x0000000189D82B50
		public void Set(string key, long value); // 0x0000000189D829C8-0x0000000189D82A8C
		public void Set(string key, float value); // 0x0000000189D82C8C-0x0000000189D82D50
		public void Set(string key, string value); // 0x0000000189D82930-0x0000000189D829C8
		public void Set(string key, List<string> values, char delimiter = ';' /* Metadata: 0x02332EE2 */); // 0x0000000189D82B50-0x0000000189D82C8C
		public bool Get(string key, out bool value, bool defaultValue); // 0x0000000189D81414-0x0000000189D814E8
		public bool Get(string key, out int value, int defaultValue); // 0x0000000189D81120-0x0000000189D811F4
		public bool Get(string key, out long value, long defaultValue); // 0x0000000189D81340-0x0000000189D81414
		public bool Get(string key, out float value, float defaultValue); // 0x0000000189D815AC-0x0000000189D816AC
		public bool Get(string key, out string value, string defaultValue); // 0x0000000189D814E8-0x0000000189D815AC
		public bool Get(string key, out List<string> values, char delimiter = ';' /* Metadata: 0x02332EE4 */); // 0x0000000189D811F4-0x0000000189D81340
		protected virtual void MarkDirtyForSave(); // 0x00000001841E1670-0x00000001841E1680
		public static void SaveIfRequired(); // 0x0000000189D823DC-0x0000000189D82428
		public static string SettingsFilePath(); // 0x0000000189D82E14-0x0000000189D82EC4
		public virtual bool SavePluginData(string file = null); // 0x0000000189D82428-0x0000000189D82880
		public virtual bool LoadPluginData(string file = null); // 0x0000000189D81BCC-0x0000000189D823DC
		private bool ReadFromEditorPrefs(); // 0x00000001812081B0-0x0000000181208610
		public static void ClearPluginData(); // 0x0000000189D80AF4-0x0000000189D80BAC
		public static void LoadFromSavedFile(); // 0x0000000189D81B84-0x0000000189D81BCC
		public static string SessionFilePath(); // 0x0000000189D82880-0x0000000189D82930
		public static void SaveAllSessionData(List<HEU_SessionBase> allSessions, string path = null); // 0x00000001841E1670-0x00000001841E1680
		public static List<HEU_SessionData> LoadAllSessionData(string path = null); // 0x0000000189D81794-0x0000000189D817F4
		public static void DeleteAllSavedSessionData(string file = null); // 0x00000001841E1670-0x00000001841E1680
		public void LoadAssetEnvironmentPaths(); // 0x0000000189D817F4-0x0000000189D81B84
		public string ConvertRealPathToEnvKeyedPath(string inPath); // 0x0000000189D80E50-0x0000000189D81120
		public string ConvertEnvKeyedPathToReal(string inPath); // 0x0000000189D80BAC-0x0000000189D80E50
	}

	[Serializable]
	internal class HEU_Handle : ScriptableObject, IEquivable<HEU_Handle> // TypeDefIndex: 52995
	{
		// Fields
		[SerializeField]
		private string _handleName; // 0x18
		[SerializeField]
		private HEU_HandleType _handleType; // 0x20
		[SerializeField]
		private int _handleIndex; // 0x24
		[SerializeField]
		private HEU_HandleParamBinding _handleParamTranslateBinding; // 0x28
		[SerializeField]
		private HEU_HandleParamBinding _handleParamRotateBinding; // 0x30
		[SerializeField]
		private HEU_HandleParamBinding _handleParamScaleBinding; // 0x38
		[SerializeField]
		private Vector3 _handlePosition; // 0x40
		[SerializeField]
		private Quaternion _handleRotation; // 0x4C
		[SerializeField]
		private Vector3 _handleScale; // 0x5C
		[SerializeField]
		private HAPI_RSTOrder _rstOrder; // 0x68
		[SerializeField]
		private HAPI_XYZOrder _xyzOrder; // 0x6C
		[SerializeField]
		private HAPI_TransformEuler _convertedTransformEuler; // 0x70
	
		// Properties
		public string HandleName { get; } // 0x000000018385B100-0x000000018385B110 
		public HEU_HandleType HandleType { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
		public HAPI_RSTOrder RSTOrder { get; } // 0x0000000184D86CF0-0x0000000184D86D00 
		public HAPI_XYZOrder XYZOrder { get; } // 0x0000000184D86B50-0x0000000184D86B60 
		public HAPI_TransformEuler ConvertedTransformEuler { get; } // 0x0000000184DA2930-0x0000000184DA2960 
		public Vector3 HandlePosition { get; } // 0x0000000184D89660-0x0000000184D89680 
		public Quaternion HandleRotation { get; } // 0x0000000184D8D360-0x0000000184D8D370 
		public Vector3 HandleScale { get; } // 0x0000000184DA2960-0x0000000184DA2980 
	
		// Nested types
		public enum HEU_HandleType // TypeDefIndex: 52994
		{
			XFORM = 0,
			UNSUPPORTED = 1
		}
	
		// Constructors
		public HEU_Handle(); // 0x0000000189D6F6D8-0x0000000189D6F740
	
		// Methods
		public bool HasTranslateHandle(); // 0x00000001868C60A8-0x00000001868C60B4
		public bool HasRotateHandle(); // 0x0000000189B11948-0x0000000189B11954
		public bool HasScaleHandle(); // 0x0000000189B0008C-0x0000000189B00098
		public bool IsTranslateHandleDisabled(); // 0x0000000189D6F5A0-0x0000000189D6F5B4
		public bool IsRotateHandleDisabled(); // 0x0000000189D6F564-0x0000000189D6F578
		public bool IsScaleHandleDisabled(); // 0x0000000189D6F578-0x0000000189D6F58C
		public HEU_HandleParamBinding GetTranslateBinding(); // 0x0000000184D86240-0x0000000184D86250
		public HEU_HandleParamBinding GetRotateBinding(); // 0x00000001811F36E0-0x00000001811F36F0
		public HEU_HandleParamBinding GetScaleBinding(); // 0x0000000184D85A50-0x0000000184D85A60
		public bool SetupHandle(HEU_SessionBase session, int assetID, int handleIndex, string handleName, HEU_HandleType handleType, ref HAPI_HandleInfo handleInfo, HEU_Parameters parameters); // 0x0000000189D6F5B4-0x0000000189D6F6D8
		public void CleanUp(); // 0x0000000189D6EAAC-0x0000000189D6EAE4
		public void GenerateTransform(HEU_SessionBase session, HEU_Parameters parameters); // 0x0000000189D6EAE4-0x0000000189D6EEFC
		public bool GetUpdatedPosition(HEU_HoudiniAsset asset, ref Vector3 inPosition); // 0x0000000189D6EEFC-0x0000000189D6EFB8
		public bool GetUpdatedRotation(HEU_HoudiniAsset asset, ref Quaternion inRotation); // 0x0000000189D6EFB8-0x0000000189D6F0EC
		public static bool IsSpecialRSTOrder(HAPI_RSTOrder rstOrder); // 0x0000000189D6F58C-0x0000000189D6F5A0
		public bool IsEquivalentTo(HEU_Handle other); // 0x0000000189D6F0EC-0x0000000189D6F564
	}

	[Serializable]
	internal class HEU_HandleParamBinding : IEquivable<HEU_HandleParamBinding> // TypeDefIndex: 52997
	{
		// Fields
		public HEU_HandleParamType _paramType; // 0x10
		public int _parmID; // 0x14
		public string _paramName; // 0x18
		public bool _bDisabled; // 0x20
		public bool[] _boundChannels; // 0x28
	
		// Nested types
		public enum HEU_HandleParamType // TypeDefIndex: 52996
		{
			TRANSLATE = 0,
			ROTATE = 1,
			SCALE = 2
		}
	
		// Constructors
		public HEU_HandleParamBinding(); // 0x0000000189D6EA64-0x0000000189D6EAAC
	
		// Methods
		public bool IsEquivalentTo(HEU_HandleParamBinding other); // 0x0000000189D6E898-0x0000000189D6EA64
	}

	public static class HEU_HAPIConstants // TypeDefIndex: 52998
	{
		// Fields
		public const int HAPI_POSITION_VECTOR_SIZE = 3; // Metadata: 0x02332F26
		public const int HAPI_SCALE_VECTOR_SIZE = 3; // Metadata: 0x02332F27
		public const int HAPI_SHEAR_VECTOR_SIZE = 3; // Metadata: 0x02332F28
		public const int HAPI_NORMAL_VECTOR_SIZE = 3; // Metadata: 0x02332F29
		public const int HAPI_QUATERNION_VECTOR_SIZE = 4; // Metadata: 0x02332F2A
		public const int HAPI_EULER_VECTOR_SIZE = 3; // Metadata: 0x02332F2B
		public const int HAPI_UV_VECTOR_SIZE = 2; // Metadata: 0x02332F2C
		public const int HAPI_COLOR_VECTOR_SIZE = 4; // Metadata: 0x02332F2D
		public const int HAPI_CV_VECTOR_SIZE = 4; // Metadata: 0x02332F2E
		public const int HAPI_PRIM_MIN_VERTEX_COUNT = 1; // Metadata: 0x02332F2F
		public const int HAPI_PRIM_MAX_VERTEX_COUNT = 16; // Metadata: 0x02332F30
		public const int HAPI_INVALID_PARM_ID = -1; // Metadata: 0x02332F31
		public const int HAPI_MAX_NUM_CONNECTIONS = 128; // Metadata: 0x02332F32
		public const string HAPI_ATTRIB_POSITION = "P"; // Metadata: 0x02332F34
		public const string HAPI_ATTRIB_UV = "uv"; // Metadata: 0x02332F36
		public const string HAPI_ATTRIB_UV2 = "uv2"; // Metadata: 0x02332F39
		public const string HAPI_ATTRIB_NORMAL = "N"; // Metadata: 0x02332F3D
		public const string HAPI_ATTRIB_TANGENT = "tangentu"; // Metadata: 0x02332F3F
		public const string HAPI_ATTRIB_TANGENT2 = "tangentv"; // Metadata: 0x02332F48
		public const string HAPI_ATTRIB_COLOR = "Cd"; // Metadata: 0x02332F51
		public const string HAPI_ATTRIB_NAME = "name"; // Metadata: 0x02332F54
		public const string HAPI_ATTRIB_INSTANCE = "instance"; // Metadata: 0x02332F59
		public const string HAPI_ATTRIB_ROT = "rot"; // Metadata: 0x02332F62
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x02332F66
		public const string HAPI_UNGROUPED_GROUP_NAME = "__ungrouped_group"; // Metadata: 0x02332F6C
		public const string HAPI_RAW_FORMAT_NAME = "HAPI_RAW"; // Metadata: 0x02332F7E
		public const string HAPI_PNG_FORMAT_NAME = "PNG"; // Metadata: 0x02332F87
		public const string HAPI_JPEG_FORMAT_NAME = "JPEG"; // Metadata: 0x02332F8B
		public const string HAPI_BMP_FORMAT_NAME = "Bitmap"; // Metadata: 0x02332F90
		public const string HAPI_TIFF_FORMAT_NAME = "TIFF"; // Metadata: 0x02332F97
		public const string HAPI_TGA_FORMAT_NAME = "Targa"; // Metadata: 0x02332F9C
		public const string HAPI_DEFAULT_IMAGE_FORMAT_NAME = "PNG"; // Metadata: 0x02332FA2
		public const string HAPI_GLOBAL_NODES_NODE_NAME = "GlobalNodes"; // Metadata: 0x02332FA6
		public const string HAPI_ENV_HIP = "HIP"; // Metadata: 0x02332FB2
		public const string HAPI_ENV_JOB = "JOB"; // Metadata: 0x02332FB6
		public const string HAPI_ENV_CLIENT_NAME = "HAPI_CLIENT_NAME"; // Metadata: 0x02332FBA
		public const string HAPI_CACHE_COP2_COOK = "Old COP Cook Cache"; // Metadata: 0x02332FCB
		public const string HAPI_CACHE_COP2_FLIPBOOK = "Composite View Cache"; // Metadata: 0x02332FDE
		public const string HAPI_CACHE_IMAGE = "Image Cache"; // Metadata: 0x02332FF3
		public const string HAPI_CACHE_OBJ = "Object Transform Cache"; // Metadata: 0x02332FFF
		public const string HAPI_CACHE_GL_TEXTURE = "OpenGL Texture Cache"; // Metadata: 0x02333016
		public const string HAPI_CACHE_GL_VERTEX = "OpenGL Vertex Cache"; // Metadata: 0x0233302B
		public const string HAPI_CACHE_SOP = "SOP Cache"; // Metadata: 0x0233303F
		public const string HAPI_CACHE_VEX = "VEX File Cache"; // Metadata: 0x02333049
		public const string HAPI_ATTRIB_INPUT_CURVE_COORDS = "hapi_input_curve_coords"; // Metadata: 0x02333058
	}

	public enum HAPI_License // TypeDefIndex: 52999
	{
		HAPI_LICENSE_NONE = 0,
		HAPI_LICENSE_HOUDINI_ENGINE = 1,
		HAPI_LICENSE_HOUDINI = 2,
		HAPI_LICENSE_HOUDINI_FX = 3,
		HAPI_LICENSE_HOUDINI_ENGINE_INDIE = 4,
		HAPI_LICENSE_HOUDINI_INDIE = 5,
		HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL = 6,
		HAPI_LICENSE_HOUDINI_EDUCATION = 7,
		HAPI_LICENSE_HOUDINI_ENGINE_EDUCATION = 8,
		HAPI_LICENSE_MAX = 9
	}

	public enum HAPI_StatusType // TypeDefIndex: 53000
	{
		HAPI_STATUS_CALL_RESULT = 0,
		HAPI_STATUS_COOK_RESULT = 1,
		HAPI_STATUS_COOK_STATE = 2,
		HAPI_STATUS_MAX = 3
	}

	public enum HAPI_StatusVerbosity // TypeDefIndex: 53001
	{
		HAPI_STATUSVERBOSITY_0 = 0,
		HAPI_STATUSVERBOSITY_ERRORS = 0,
		HAPI_STATUSVERBOSITY_1 = 1,
		HAPI_STATUSVERBOSITY_WARNINGS = 1,
		HAPI_STATUSVERBOSITY_2 = 2,
		HAPI_STATUSVERBOSITY_ALL = 2,
		HAPI_STATUSVERBOSITY_MESSAGES = 2
	}

	public enum HAPI_JobStatus // TypeDefIndex: 53002
	{
		HAPI_JOB_STATUS_RUNNING = 0,
		HAPI_JOB_STATUS_IDLE = 1,
		HAPI_JOB_STATUS_MAX = 2
	}

	public enum HAPI_Result // TypeDefIndex: 53003
	{
		HAPI_RESULT_SUCCESS = 0,
		HAPI_RESULT_FAILURE = 1,
		HAPI_RESULT_ALREADY_INITIALIZED = 2,
		HAPI_RESULT_NOT_INITIALIZED = 3,
		HAPI_RESULT_CANT_LOADFILE = 4,
		HAPI_RESULT_PARM_SET_FAILED = 5,
		HAPI_RESULT_INVALID_ARGUMENT = 6,
		HAPI_RESULT_CANT_LOAD_GEO = 7,
		HAPI_RESULT_CANT_GENERATE_PRESET = 8,
		HAPI_RESULT_CANT_LOAD_PRESET = 9,
		HAPI_RESULT_ASSET_DEF_ALREADY_LOADED = 10,
		HAPI_RESULT_NO_LICENSE_FOUND = 110,
		HAPI_RESULT_DISALLOWED_NC_LICENSE_FOUND = 120,
		HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_C_LICENSE = 130,
		HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_LC_LICENSE = 140,
		HAPI_RESULT_DISALLOWED_LC_ASSET_WITH_C_LICENSE = 150,
		HAPI_RESULT_DISALLOWED_HENGINEINDIE_W_3PARTY_PLUGIN = 160,
		HAPI_RESULT_SHARED_MEMORY_BUFFER_OVERFLOW = 170,
		HAPI_RESULT_INVALID_SHARED_MEMORY_BUFFER = 180,
		HAPI_RESULT_ASSET_INVALID = 200,
		HAPI_RESULT_NODE_INVALID = 210,
		HAPI_RESULT_USER_INTERRUPTED = 300,
		HAPI_RESULT_INVALID_SESSION = 400
	}

	[Flags]
	public enum HAPI_ErrorCode // TypeDefIndex: 53004
	{
		HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND = 1,
		HAPI_ERRORCODE_PYTHON_NODE_ERROR = 2
	}

	public enum HAPI_SessionType // TypeDefIndex: 53005
	{
		HAPI_SESSION_INPROCESS = 0,
		HAPI_SESSION_THRIFT = 1,
		HAPI_SESSION_CUSTOM1 = 2,
		HAPI_SESSION_CUSTOM2 = 3,
		HAPI_SESSION_CUSTOM3 = 4,
		HAPI_SESSION_MAX = 5
	}

	public enum HAPI_State // TypeDefIndex: 53006
	{
		HAPI_STATE_READY = 0,
		HAPI_STATE_READY_WITH_FATAL_ERRORS = 1,
		HAPI_STATE_READY_WITH_COOK_ERRORS = 2,
		HAPI_STATE_MAX_READY_STATE = 2,
		HAPI_STATE_STARTING_COOK = 3,
		HAPI_STATE_COOKING = 4,
		HAPI_STATE_STARTING_LOAD = 5,
		HAPI_STATE_LOADING = 6,
		HAPI_STATE_MAX = 7
	}

	public enum HAPI_PackedPrimInstancingMode // TypeDefIndex: 53007
	{
		HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID = -1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED = 0,
		HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY = 1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT = 2,
		HAPI_PACKEDPRIM_INSTANCING_MODE_MAX = 3
	}

	public enum HAPI_Permissions // TypeDefIndex: 53008
	{
		HAPI_PERMISSIONS_NON_APPLICABLE = 0,
		HAPI_PERMISSIONS_READ_WRITE = 1,
		HAPI_PERMISSIONS_READ_ONLY = 2,
		HAPI_PERMISSIONS_WRITE_ONLY = 3,
		HAPI_PERMISSIONS_MAX = 4
	}

	public enum HAPI_RampType // TypeDefIndex: 53009
	{
		HAPI_RAMPTYPE_INVALID = -1,
		HAPI_RAMPTYPE_FLOAT = 0,
		HAPI_RAMPTYPE_COLOR = 1,
		HAPI_RAMPTYPE_MAX = 2
	}

	public enum HAPI_ParmType // TypeDefIndex: 53010
	{
		HAPI_PARMTYPE_INT = 0,
		HAPI_PARMTYPE_INT_START = 0,
		HAPI_PARMTYPE_MULTIPARMLIST = 1,
		HAPI_PARMTYPE_TOGGLE = 2,
		HAPI_PARMTYPE_BUTTON = 3,
		HAPI_PARMTYPE_INT_END = 3,
		HAPI_PARMTYPE_FLOAT = 4,
		HAPI_PARMTYPE_FLOAT_START = 4,
		HAPI_PARMTYPE_COLOR = 5,
		HAPI_PARMTYPE_FLOAT_END = 5,
		HAPI_PARMTYPE_STRING = 6,
		HAPI_PARMTYPE_STRING_START = 6,
		HAPI_PARMTYPE_PATH_FILE = 7,
		HAPI_PARMTYPE_PATH_START = 7,
		HAPI_PARMTYPE_PATH_FILE_GEO = 8,
		HAPI_PARMTYPE_PATH_FILE_IMAGE = 9,
		HAPI_PARMTYPE_PATH_END = 9,
		HAPI_PARMTYPE_NODE = 10,
		HAPI_PARMTYPE_STRING_END = 10,
		HAPI_PARMTYPE_NODE_START = 10,
		HAPI_PARMTYPE_NODE_END = 10,
		HAPI_PARMTYPE_FOLDERLIST = 11,
		HAPI_PARMTYPE_CONTAINER_START = 11,
		HAPI_PARMTYPE_FOLDERLIST_RADIO = 12,
		HAPI_PARMTYPE_CONTAINER_END = 12,
		HAPI_PARMTYPE_FOLDER = 13,
		HAPI_PARMTYPE_NONVALUE_START = 13,
		HAPI_PARMTYPE_LABEL = 14,
		HAPI_PARMTYPE_SEPARATOR = 15,
		HAPI_PARMTYPE_NONVALUE_END = 15,
		HAPI_PARMTYPE_PATH_FILE_DIR = 16,
		HAPI_PARMTYPE_MAX = 17
	}

	public enum HAPI_PrmScriptType // TypeDefIndex: 53011
	{
		HAPI_PRM_SCRIPT_TYPE_INT = 0,
		HAPI_PRM_SCRIPT_TYPE_FLOAT = 1,
		HAPI_PRM_SCRIPT_TYPE_ANGLE = 2,
		HAPI_PRM_SCRIPT_TYPE_STRING = 3,
		HAPI_PRM_SCRIPT_TYPE_FILE = 4,
		HAPI_PRM_SCRIPT_TYPE_DIRECTORY = 5,
		HAPI_PRM_SCRIPT_TYPE_IMAGE = 6,
		HAPI_PRM_SCRIPT_TYPE_GEOMETRY = 7,
		HAPI_PRM_SCRIPT_TYPE_TOGGLE = 8,
		HAPI_PRM_SCRIPT_TYPE_BUTTON = 9,
		HAPI_PRM_SCRIPT_TYPE_VECTOR2 = 10,
		HAPI_PRM_SCRIPT_TYPE_VECTOR3 = 11,
		HAPI_PRM_SCRIPT_TYPE_VECTOR4 = 12,
		HAPI_PRM_SCRIPT_TYPE_INTVECTOR2 = 13,
		HAPI_PRM_SCRIPT_TYPE_INTVECTOR3 = 14,
		HAPI_PRM_SCRIPT_TYPE_INTVECTOR4 = 15,
		HAPI_PRM_SCRIPT_TYPE_UV = 16,
		HAPI_PRM_SCRIPT_TYPE_UVW = 17,
		HAPI_PRM_SCRIPT_TYPE_DIR = 18,
		HAPI_PRM_SCRIPT_TYPE_COLOR = 19,
		HAPI_PRM_SCRIPT_TYPE_COLOR4 = 20,
		HAPI_PRM_SCRIPT_TYPE_HUECIRCLE = 21,
		HAPI_PRM_SCRIPT_TYPE_OPPATH = 22,
		HAPI_PRM_SCRIPT_TYPE_OPLIST = 23,
		HAPI_PRM_SCRIPT_TYPE_OBJECT = 24,
		HAPI_PRM_SCRIPT_TYPE_OBJECTLIST = 25,
		HAPI_PRM_SCRIPT_TYPE_RENDER = 26,
		HAPI_PRM_SCRIPT_TYPE_SEPARATOR = 27,
		HAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA = 28,
		HAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT = 29,
		HAPI_PRM_SCRIPT_TYPE_LABEL = 30,
		HAPI_PRM_SCRIPT_TYPE_RGBAMASK = 31,
		HAPI_PRM_SCRIPT_TYPE_ORDINAL = 32,
		HAPI_PRM_SCRIPT_TYPE_RAMP_FLT = 33,
		HAPI_PRM_SCRIPT_TYPE_RAMP_RGB = 34,
		HAPI_PRM_SCRIPT_TYPE_FLOAT_LOG = 35,
		HAPI_PRM_SCRIPT_TYPE_INT_LOG = 36,
		HAPI_PRM_SCRIPT_TYPE_DATA = 37,
		HAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX = 38,
		HAPI_PRM_SCRIPT_TYPE_INT_MINMAX = 39,
		HAPI_PRM_SCRIPT_TYPE_INT_STARTEND = 40,
		HAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP = 41,
		HAPI_PRM_SCRIPT_TYPE_ICONSTRIP = 42,
		HAPI_PRM_SCRIPT_TYPE_GROUPRADIO = 1000,
		HAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE = 1001,
		HAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE = 1002,
		HAPI_PRM_SCRIPT_TYPE_GROUP = 1003
	}

	public enum HAPI_ChoiceListType // TypeDefIndex: 53012
	{
		HAPI_CHOICELISTTYPE_NONE = 0,
		HAPI_CHOICELISTTYPE_NORMAL = 1,
		HAPI_CHOICELISTTYPE_MINI = 2,
		HAPI_CHOICELISTTYPE_REPLACE = 3,
		HAPI_CHOICELISTTYPE_TOGGLE = 4
	}

	public enum HAPI_PresetType // TypeDefIndex: 53013
	{
		HAPI_PRESETTYPE_INVALID = -1,
		HAPI_PRESETTYPE_BINARY = 0,
		HAPI_PRESETTYPE_IDX = 1,
		HAPI_PRESETTYPE_MAX = 2
	}

	[Flags]
	public enum HAPI_NodeType // TypeDefIndex: 53014
	{
		HAPI_NODETYPE_ANY = -1,
		HAPI_NODETYPE_NONE = 0,
		HAPI_NODETYPE_OBJ = 1,
		HAPI_NODETYPE_SOP = 2,
		HAPI_NODETYPE_CHOP = 4,
		HAPI_NODETYPE_ROP = 8,
		HAPI_NODETYPE_SHOP = 16,
		HAPI_NODETYPE_COP2 = 32,
		HAPI_NODETYPE_VOP = 64,
		HAPI_NODETYPE_DOP = 128,
		HAPI_NODETYPE_TOP = 256,
		HAPI_NODETYPE_COP = 512,
		HAPI_NODETYPE_LOP = 1024
	}

	[Flags]
	public enum HAPI_NodeFlags // TypeDefIndex: 53015
	{
		HAPI_NODEFLAGS_ANY = -1,
		HAPI_NODEFLAGS_NONE = 0,
		HAPI_NODEFLAGS_DISPLAY = 1,
		HAPI_NODEFLAGS_RENDER = 2,
		HAPI_NODEFLAGS_TEMPLATED = 4,
		HAPI_NODEFLAGS_LOCKED = 8,
		HAPI_NODEFLAGS_EDITABLE = 16,
		HAPI_NODEFLAGS_BYPASS = 32,
		HAPI_NODEFLAGS_NETWORK = 64,
		HAPI_NODEFLAGS_OBJ_GEOMETRY = 128,
		HAPI_NODEFLAGS_OBJ_CAMERA = 256,
		HAPI_NODEFLAGS_OBJ_LIGHT = 512,
		HAPI_NODEFLAGS_OBJ_SUBNET = 1024,
		HAPI_NODEFLAGS_SOP_CURVE = 2048,
		HAPI_NODEFLAGS_SOP_GUIDE = 4096,
		HAPI_NODEFLAGS_TOP_NONSCHEDULER = 8192,
		HAPI_NODEFLAGS_NON_BYPASS = 16384
	}

	public enum HAPI_GroupType // TypeDefIndex: 53016
	{
		HAPI_GROUPTYPE_INVALID = -1,
		HAPI_GROUPTYPE_POINT = 0,
		HAPI_GROUPTYPE_PRIM = 1,
		HAPI_GROUPTYPE_EDGE = 2,
		HAPI_GROUPTYPE_MAX = 3
	}

	public enum HAPI_AttributeOwner // TypeDefIndex: 53017
	{
		HAPI_ATTROWNER_INVALID = -1,
		HAPI_ATTROWNER_VERTEX = 0,
		HAPI_ATTROWNER_POINT = 1,
		HAPI_ATTROWNER_PRIM = 2,
		HAPI_ATTROWNER_DETAIL = 3,
		HAPI_ATTROWNER_MAX = 4
	}

	public enum HAPI_CurveType // TypeDefIndex: 53018
	{
		HAPI_CURVETYPE_INVALID = -1,
		HAPI_CURVETYPE_LINEAR = 0,
		HAPI_CURVETYPE_NURBS = 1,
		HAPI_CURVETYPE_BEZIER = 2,
		HAPI_CURVETYPE_MAX = 3
	}

	public enum HAPI_InputCurveMethod // TypeDefIndex: 53019
	{
		HAPI_CURVEMETHOD_INVALID = -1,
		HAPI_CURVEMETHOD_CVS = 0,
		HAPI_CURVEMETHOD_BREAKPOINTS = 1,
		HAPI_CURVEMETHOD_MAX = 2
	}

	public enum HAPI_InputCurveParameterization // TypeDefIndex: 53020
	{
		HAPI_CURVEPARAMETERIZATION_INVALID = -1,
		HAPI_CURVEPARAMETERIZATION_UNIFORM = 0,
		HAPI_CURVEPARAMETERIZATION_CHORD = 1,
		HAPI_CURVEPARAMETERIZATION_CENTRIPETAL = 2,
		HAPI_CURVEPARAMETERIZATION_MAX = 3
	}

	public enum HAPI_VolumeType // TypeDefIndex: 53021
	{
		HAPI_VOLUMETYPE_INVALID = -1,
		HAPI_VOLUMETYPE_HOUDINI = 0,
		HAPI_VOLUMETYPE_VDB = 1,
		HAPI_VOLUMETYPE_MAX = 2
	}

	public enum HAPI_VolumeVisualType // TypeDefIndex: 53022
	{
		HAPI_VOLUMEVISTYPE_INVALID = -1,
		HAPI_VOLUMEVISTYPE_SMOKE = 0,
		HAPI_VOLUMEVISTYPE_RAINBOW = 1,
		HAPI_VOLUMEVISTYPE_ISO = 2,
		HAPI_VOLUMEVISTYPE_INVISIBLE = 3,
		HAPI_VOLUMEVISTYPE_HEIGHTFIELD = 4,
		HAPI_VOLUMEVISTYPE_MAX = 5
	}

	public enum HAPI_StorageType // TypeDefIndex: 53023
	{
		HAPI_STORAGETYPE_INVALID = -1,
		HAPI_STORAGETYPE_INT = 0,
		HAPI_STORAGETYPE_INT64 = 1,
		HAPI_STORAGETYPE_FLOAT = 2,
		HAPI_STORAGETYPE_FLOAT64 = 3,
		HAPI_STORAGETYPE_STRING = 4,
		HAPI_STORAGETYPE_UINT8 = 5,
		HAPI_STORAGETYPE_INT8 = 6,
		HAPI_STORAGETYPE_INT16 = 7,
		HAPI_STORAGETYPE_DICTIONARY = 8,
		HAPI_STORAGETYPE_INT_ARRAY = 9,
		HAPI_STORAGETYPE_INT64_ARRAY = 10,
		HAPI_STORAGETYPE_FLOAT_ARRAY = 11,
		HAPI_STORAGETYPE_FLOAT64_ARRAY = 12,
		HAPI_STORAGETYPE_STRING_ARRAY = 13,
		HAPI_STORAGETYPE_UINT8_ARRAY = 14,
		HAPI_STORAGETYPE_INT8_ARRAY = 15,
		HAPI_STORAGETYPE_INT16_ARRAY = 16,
		HAPI_STORAGETYPE_DICTIONARY_ARRAY = 17,
		HAPI_STORAGETYPE_MAX = 18
	}

	public enum HAPI_AttributeTypeInfo // TypeDefIndex: 53024
	{
		HAPI_ATTRIBUTE_TYPE_INVALID = -1,
		HAPI_ATTRIBUTE_TYPE_NONE = 0,
		HAPI_ATTRIBUTE_TYPE_POINT = 1,
		HAPI_ATTRIBUTE_TYPE_HPOINT = 2,
		HAPI_ATTRIBUTE_TYPE_VECTOR = 3,
		HAPI_ATTRIBUTE_TYPE_NORMAL = 4,
		HAPI_ATTRIBUTE_TYPE_COLOR = 5,
		HAPI_ATTRIBUTE_TYPE_QUATERNION = 6,
		HAPI_ATTRIBUTE_TYPE_MATRIX3 = 7,
		HAPI_ATTRIBUTE_TYPE_MATRIX = 8,
		HAPI_ATTRIBUTE_TYPE_ST = 9,
		HAPI_ATTRIBUTE_TYPE_HIDDEN = 10,
		HAPI_ATTRIBUTE_TYPE_BOX2 = 11,
		HAPI_ATTRIBUTE_TYPE_BOX = 12,
		HAPI_ATTRIBUTE_TYPE_TEXTURE = 13,
		HAPI_ATTRIBUTE_TYPE_MAX = 14
	}

	public enum HAPI_GeoType // TypeDefIndex: 53025
	{
		HAPI_GEOTYPE_INVALID = -1,
		HAPI_GEOTYPE_DEFAULT = 0,
		HAPI_GEOTYPE_INTERMEDIATE = 1,
		HAPI_GEOTYPE_INPUT = 2,
		HAPI_GEOTYPE_CURVE = 3,
		HAPI_GEOTYPE_MAX = 4
	}

	public enum HAPI_PartType // TypeDefIndex: 53026
	{
		HAPI_PARTTYPE_INVALID = -1,
		HAPI_PARTTYPE_MESH = 0,
		HAPI_PARTTYPE_CURVE = 1,
		HAPI_PARTTYPE_VOLUME = 2,
		HAPI_PARTTYPE_INSTANCER = 3,
		HAPI_PARTTYPE_BOX = 4,
		HAPI_PARTTYPE_SPHERE = 5,
		HAPI_PARTTYPE_MAX = 6
	}

	public enum HAPI_InputType // TypeDefIndex: 53027
	{
		HAPI_INPUT_INVALID = -1,
		HAPI_INPUT_TRANSFORM = 0,
		HAPI_INPUT_GEOMETRY = 1,
		HAPI_INPUT_MAX = 2
	}

	public enum HAPI_CurveOrders // TypeDefIndex: 53028
	{
		HAPI_CURVE_ORDER_VARYING = 0,
		HAPI_CURVE_ORDER_INVALID = 1,
		HAPI_CURVE_ORDER_LINEAR = 2,
		HAPI_CURVE_ORDER_QUADRATIC = 3,
		HAPI_CURVE_ORDER_CUBIC = 4
	}

	public enum HAPI_TransformComponent // TypeDefIndex: 53029
	{
		HAPI_TRANSFORM_TX = 0,
		HAPI_TRANSFORM_TY = 1,
		HAPI_TRANSFORM_TZ = 2,
		HAPI_TRANSFORM_RX = 3,
		HAPI_TRANSFORM_RY = 4,
		HAPI_TRANSFORM_RZ = 5,
		HAPI_TRANSFORM_QX = 6,
		HAPI_TRANSFORM_QY = 7,
		HAPI_TRANSFORM_QZ = 8,
		HAPI_TRANSFORM_QW = 9,
		HAPI_TRANSFORM_SX = 10,
		HAPI_TRANSFORM_SY = 11,
		HAPI_TRANSFORM_SZ = 12
	}

	public enum HAPI_RSTOrder // TypeDefIndex: 53030
	{
		HAPI_TRS = 0,
		HAPI_TSR = 1,
		HAPI_RTS = 2,
		HAPI_RST = 3,
		HAPI_STR = 4,
		HAPI_SRT = 5,
		HAPI_RSTORDER_DEFAULT = 5
	}

	public enum HAPI_XYZOrder // TypeDefIndex: 53031
	{
		HAPI_XYZ = 0,
		HAPI_XYZORDER_DEFAULT = 0,
		HAPI_XZY = 1,
		HAPI_YXZ = 2,
		HAPI_YZX = 3,
		HAPI_ZXY = 4,
		HAPI_ZYX = 5
	}

	public enum HAPI_ImageDataFormat // TypeDefIndex: 53032
	{
		HAPI_IMAGE_DATA_UNKNOWN = -1,
		HAPI_IMAGE_DATA_INT8 = 0,
		HAPI_IMAGE_DATA_DEFAULT = 0,
		HAPI_IMAGE_DATA_INT16 = 1,
		HAPI_IMAGE_DATA_INT32 = 2,
		HAPI_IMAGE_DATA_FLOAT16 = 3,
		HAPI_IMAGE_DATA_FLOAT32 = 4,
		HAPI_IMAGE_DATA_MAX = 5
	}

	public enum HAPI_ImagePacking // TypeDefIndex: 53033
	{
		HAPI_IMAGE_PACKING_UNKNOWN = -1,
		HAPI_IMAGE_PACKING_SINGLE = 0,
		HAPI_IMAGE_PACKING_DUAL = 1,
		HAPI_IMAGE_PACKING_RGB = 2,
		HAPI_IMAGE_PACKING_DEFAULT3 = 2,
		HAPI_IMAGE_PACKING_BGR = 3,
		HAPI_IMAGE_PACKING_RGBA = 4,
		HAPI_IMAGE_PACKING_DEFAULT4 = 4,
		HAPI_IMAGE_PACKING_ABGR = 5,
		HAPI_IMAGE_PACKING_MAX = 6
	}

	public enum HAPI_EnvIntType // TypeDefIndex: 53034
	{
		HAPI_ENVINT_INVALID = -1,
		HAPI_ENVINT_VERSION_HOUDINI_MAJOR = 100,
		HAPI_ENVINT_VERSION_HOUDINI_MINOR = 110,
		HAPI_ENVINT_VERSION_HOUDINI_BUILD = 120,
		HAPI_ENVINT_VERSION_HOUDINI_PATCH = 130,
		HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MAJOR = 200,
		HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MINOR = 210,
		HAPI_ENVINT_VERSION_HOUDINI_ENGINE_API = 220,
		HAPI_ENVINT_MAX = 221
	}

	public enum HAPI_SessionEnvIntType // TypeDefIndex: 53035
	{
		HAPI_SESSIONENVINT_INVALID = -1,
		HAPI_SESSIONENVINT_LICENSE = 100,
		HAPI_SESSIONENVINT_MAX = 101
	}

	public enum HAPI_CacheProperty // TypeDefIndex: 53036
	{
		HAPI_CACHEPROP_CURRENT = 0,
		HAPI_CACHEPROP_HAS_MIN = 1,
		HAPI_CACHEPROP_MIN = 2,
		HAPI_CACHEPROP_HAS_MAX = 3,
		HAPI_CACHEPROP_MAX = 4,
		HAPI_CACHEPROP_CULL_LEVEL = 5
	}

	public enum HAPI_HeightFieldSampling // TypeDefIndex: 53037
	{
		HAPI_HEIGHTFIELD_SAMPLING_CENTER = 0,
		HAPI_HEIGHTFIELD_SAMPLING_CORNER = 1
	}

	public enum HAPI_PDG_State // TypeDefIndex: 53038
	{
		HAPI_PDG_STATE_READY = 0,
		HAPI_PDG_STATE_MAX_READY_STATE = 0,
		HAPI_PDG_STATE_COOKING = 1,
		HAPI_PDG_STATE_MAX = 2
	}

	public enum HAPI_PDG_EventType // TypeDefIndex: 53039
	{
		HAPI_PDG_EVENT_NULL = 0,
		HAPI_PDG_EVENT_WORKITEM_ADD = 1,
		HAPI_PDG_EVENT_WORKITEM_REMOVE = 2,
		HAPI_PDG_EVENT_WORKITEM_STATE_CHANGE = 3,
		HAPI_PDG_EVENT_WORKITEM_ADD_DEP = 4,
		HAPI_PDG_EVENT_WORKITEM_REMOVE_DEP = 5,
		HAPI_PDG_EVENT_WORKITEM_ADD_PARENT = 6,
		HAPI_PDG_EVENT_WORKITEM_REMOVE_PARENT = 7,
		HAPI_PDG_EVENT_NODE_CLEAR = 8,
		HAPI_PDG_EVENT_COOK_ERROR = 9,
		HAPI_PDG_EVENT_COOK_WARNING = 10,
		HAPI_PDG_EVENT_COOK_COMPLETE = 11,
		HAPI_PDG_EVENT_DIRTY_START = 12,
		HAPI_PDG_EVENT_DIRTY_STOP = 13,
		HAPI_PDG_EVENT_DIRTY_ALL = 14,
		HAPI_PDG_EVENT_UI_SELECT = 15,
		HAPI_PDG_EVENT_NODE_CREATE = 16,
		HAPI_PDG_EVENT_NODE_REMOVE = 17,
		HAPI_PDG_EVENT_NODE_RENAME = 18,
		HAPI_PDG_EVENT_NODE_CONNECT = 19,
		HAPI_PDG_EVENT_NODE_DISCONNECT = 20,
		HAPI_PDG_EVENT_NODE_FIRST_COOK = 21,
		HAPI_PDG_EVENT_WORKITEM_SET_INT = 22,
		HAPI_PDG_EVENT_WORKITEM_SET_FLOAT = 23,
		HAPI_PDG_EVENT_WORKITEM_SET_STRING = 24,
		HAPI_PDG_EVENT_WORKITEM_SET_FILE = 25,
		HAPI_PDG_EVENT_WORKITEM_SET_DICT = 26,
		HAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT = 27,
		HAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY = 28,
		HAPI_PDG_EVENT_WORKITEM_MERGE = 29,
		HAPI_PDG_EVENT_WORKITEM_RESULT = 30,
		HAPI_PDG_EVENT_WORKITEM_PRIORITY = 31,
		HAPI_PDG_EVENT_COOK_START = 32,
		HAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR = 33,
		HAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR = 34,
		HAPI_PDG_EVENT_NODE_PROGRESS_UPDATE = 35,
		HAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED = 36,
		HAPI_PDG_EVENT_ALL = 37,
		HAPI_PDG_EVENT_LOG = 38,
		HAPI_PDG_EVENT_SCHEDULER_ADDED = 39,
		HAPI_PDG_EVENT_SCHEDULER_REMOVED = 40,
		HAPI_PDG_EVENT_SET_SCHEDULER = 41,
		HAPI_PDG_EVENT_SERVICE_MANAGER_ALL = 42,
		HAPI_PDG_EVENT_NODE_COOKED = 43,
		HAPI_PDG_EVENT_NODE_GENERATED = 44,
		HAPI_PDG_EVENT_WORKITEM_FRAME = 45,
		HAPI_PDG_CONTEXT_EVENTS = 46
	}

	public enum HAPI_PDG_WorkItemState // TypeDefIndex: 53040
	{
		HAPI_PDG_WORKITEM_UNDEFINED = 0,
		HAPI_PDG_WORKITEM_UNCOOKED = 1,
		HAPI_PDG_WORKITEM_WAITING = 2,
		HAPI_PDG_WORKITEM_SCHEDULED = 3,
		HAPI_PDG_WORKITEM_COOKING = 4,
		HAPI_PDG_WORKITEM_COOKED_SUCCESS = 5,
		HAPI_PDG_WORKITEM_COOKED_CACHE = 6,
		HAPI_PDG_WORKITEM_COOKED_FAIL = 7,
		HAPI_PDG_WORKITEM_COOKED_CANCEL = 8,
		HAPI_PDG_WORKITEM_DIRTY = 9
	}

	public enum HAPI_TCP_PortType // TypeDefIndex: 53041
	{
		HAPI_TCP_PORT_ANY = 0,
		HAPI_TCP_PORT_RANGE = 1,
		HAPI_TCP_PORT_LIST = 2
	}

	public enum HAPI_ThriftSharedMemoryBufferType // TypeDefIndex: 53042
	{
		HAPI_THRIFT_SHARED_MEMORY_FIXED_LENGTH_BUFFER = 0,
		HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER = 1
	}

	public static class HEU_HAPIFunctions // TypeDefIndex: 53043
	{
	}

	[Serializable]
	public struct HAPI_Transform // TypeDefIndex: 53044
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationQuaternion; // 0x08
		public float[] scale; // 0x10
		public float[] shear; // 0x18
		public HAPI_RSTOrder rstOrder; // 0x20
	
		// Constructors
		public HAPI_Transform(bool initializeFields); // 0x0000000189D69C78-0x0000000189D69D40
	
		// Methods
		public void Init(); // 0x0000000189D69BB8-0x0000000189D69C78
	}

	[Serializable]
	public struct HAPI_TransformEuler // TypeDefIndex: 53045
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationEuler; // 0x08
		public float[] scale; // 0x10
		public float[] shear; // 0x18
		public HAPI_XYZOrder rotationOrder; // 0x20
		public HAPI_RSTOrder rstOrder; // 0x24
	
		// Constructors
		public HAPI_TransformEuler(bool initializeFields); // 0x0000000189D69AF0-0x0000000189D69BB8
	
		// Methods
		public void Init(); // 0x0000000189D69A4C-0x0000000189D69AF0
	}

	[Serializable]
	public struct HAPI_Session // TypeDefIndex: 53046
	{
		// Fields
		public HAPI_SessionType type; // 0x00
		public long id; // 0x08
	}

	[Serializable]
	public struct HAPI_SessionInfo // TypeDefIndex: 53047
	{
		// Fields
		public int connectionCount; // 0x00
		public HAPI_TCP_PortType portType; // 0x04
		public int minPort; // 0x08
		public int maxPort; // 0x0C
		public int[] ports; // 0x10
		public HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType; // 0x18
		public long sharedMemoryBufferSize; // 0x20
		public bool enableSharedMemoryDataTransfer; // 0x28
	}

	public struct HAPI_ThriftServerOptions // TypeDefIndex: 53048
	{
		// Fields
		public bool autoClose; // 0x00
		public float timeoutMs; // 0x04
		public HAPI_StatusVerbosity verbosity; // 0x08
		public HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType; // 0x0C
		public long sharedMemoryBufferSize; // 0x10
	}

	public struct HAPI_TimelineOptions // TypeDefIndex: 53049
	{
		// Fields
		public double fps; // 0x00
		public double startTime; // 0x08
		public double endTime; // 0x10
	}

	[Serializable]
	public struct HAPI_AssetInfo // TypeDefIndex: 53050
	{
		// Fields
		public int nodeId; // 0x00
		public int objectNodeId; // 0x04
		public bool hasEverCooked; // 0x08
		public int nameSH; // 0x0C
		public int labelSH; // 0x10
		public int filePathSH; // 0x14
		public int versionSH; // 0x18
		public int fullOpNameSH; // 0x1C
		public int helpTextSH; // 0x20
		public int helpURLSH; // 0x24
		public int objectCount; // 0x28
		public int handleCount; // 0x2C
		public int transformInputCount; // 0x30
		public int geoInputCount; // 0x34
		public int geoOutputCount; // 0x38
		public bool haveObjectsChanged; // 0x3C
		public bool haveMaterialsChanged; // 0x3D
	}

	public struct HAPI_CookOptions // TypeDefIndex: 53051
	{
		// Fields
		public bool splitGeosByGroup; // 0x00
		public int splitGroupSH; // 0x04
		public bool splitGeosByAttribute; // 0x08
		public int splitAttrSH; // 0x0C
		public int maxVerticesPerPrimitive; // 0x10
		public bool refineCurveToLinear; // 0x14
		public float curveRefineLOD; // 0x18
		public bool clearErrorsAndWarnings; // 0x1C
		public bool cookTemplatedGeos; // 0x1D
		public bool splitPointsByVertexAttributes; // 0x1E
		public HAPI_PackedPrimInstancingMode packedPrimInstancingMode; // 0x20
		public bool handleBoxPartTypes; // 0x24
		public bool handleSpherePartTypes; // 0x25
		public bool checkPartChanges; // 0x26
		public bool cacheMeshTopology; // 0x27
		public bool preferOutputNodes; // 0x28
		public int extraFlags; // 0x2C
	}

	[Serializable]
	public struct HAPI_NodeInfo // TypeDefIndex: 53052
	{
		// Fields
		public int id; // 0x00
		public int parentId; // 0x04
		public int nameSH; // 0x08
		public HAPI_NodeType type; // 0x0C
		public bool isValid; // 0x10
		public int totalCookCount; // 0x14
		public int uniqueHoudiniNodeId; // 0x18
		public int internalNodePathSH; // 0x1C
		public int parmCount; // 0x20
		public int parmIntValueCount; // 0x24
		public int parmFloatValueCount; // 0x28
		public int parmStringValueCount; // 0x2C
		public int parmChoiceCount; // 0x30
		public int childNodeCount; // 0x34
		public int inputCount; // 0x38
		public int outputCount; // 0x3C
		public bool createdPostAssetLoad; // 0x40
		public bool isTimeDependent; // 0x41
	}

	[Serializable]
	public struct HAPI_ParmInfo // TypeDefIndex: 53053
	{
		// Fields
		public int id; // 0x00
		public int parentId; // 0x04
		public int childIndex; // 0x08
		public HAPI_ParmType type; // 0x0C
		public HAPI_PrmScriptType scriptType; // 0x10
		public int typeInfoSH; // 0x14
		public HAPI_Permissions permissions; // 0x18
		public int tagCount; // 0x1C
		public int size; // 0x20
		public HAPI_ChoiceListType choiceListType; // 0x24
		public int choiceCount; // 0x28
		public int nameSH; // 0x2C
		public int labelSH; // 0x30
		public int templateNameSH; // 0x34
		public int helpSH; // 0x38
		public bool hasMin; // 0x3C
		public bool hasMax; // 0x3D
		public bool hasUIMin; // 0x3E
		public bool hasUIMax; // 0x3F
		public float min; // 0x40
		public float max; // 0x44
		public float UIMin; // 0x48
		public float UIMax; // 0x4C
		public bool invisible; // 0x50
		public bool disabled; // 0x51
		public bool spare; // 0x52
		public bool joinNext; // 0x53
		public bool labelNone; // 0x54
		public int intValuesIndex; // 0x58
		public int floatValuesIndex; // 0x5C
		public int stringValuesIndex; // 0x60
		public int choiceIndex; // 0x64
		public HAPI_NodeType inputNodeType; // 0x68
		public HAPI_NodeFlags inputNodeFlag; // 0x6C
		public bool isChildOfMultiParm; // 0x70
		public int instanceNum; // 0x74
		public int instanceLength; // 0x78
		public int instanceCount; // 0x7C
		public int instanceStartOffset; // 0x80
		public HAPI_RampType rampType; // 0x84
		public int visibilityConditionSH; // 0x88
		public int disabledConditionSH; // 0x8C
		public bool useMenuItemTokenAsValue; // 0x90
	
		// Methods
		public bool isInt(); // 0x0000000189D69724-0x0000000189D69744
		public bool isFloat(); // 0x0000000189D69710-0x0000000189D69724
		public bool isString(); // 0x0000000189D69780-0x0000000189D697A0
		public bool isPath(); // 0x0000000189D69768-0x0000000189D69780
		public bool isNode(); // 0x0000000189D69744-0x0000000189D69754
		public bool isNonValue(); // 0x0000000189D69754-0x0000000189D69768
	}

	[Serializable]
	public struct HAPI_ParmChoiceInfo // TypeDefIndex: 53054
	{
		// Fields
		public int parentParmId; // 0x00
		public int labelSH; // 0x04
		public int valueSH; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleInfo // TypeDefIndex: 53055
	{
		// Fields
		public int nameSH; // 0x00
		public int typeNameSH; // 0x04
		public int bindingsCount; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleBindingInfo // TypeDefIndex: 53056
	{
		// Fields
		public int handleParmNameSH; // 0x00
		public int assetParmNameSH; // 0x04
		public int assetParmId; // 0x08
		public int assetParmIndex; // 0x0C
	}

	[Serializable]
	public struct HAPI_ObjectInfo // TypeDefIndex: 53057
	{
		// Fields
		public int nameSH; // 0x00
		public int objectInstancePathSH; // 0x04
		public bool hasTransformChanged; // 0x08
		public bool haveGeosChanged; // 0x09
		public bool isVisible; // 0x0A
		public bool isInstancer; // 0x0B
		public bool isInstanced; // 0x0C
		public int geoCount; // 0x10
		public int nodeId; // 0x14
		public int objectToInstanceId; // 0x18
	}

	[Serializable]
	public struct HAPI_GeoInfo // TypeDefIndex: 53058
	{
		// Fields
		public HAPI_GeoType type; // 0x00
		public int nameSH; // 0x04
		public int nodeId; // 0x08
		public bool isEditable; // 0x0C
		public bool isTemplated; // 0x0D
		public bool isDisplayGeo; // 0x0E
		public bool hasGeoChanged; // 0x0F
		public bool hasMaterialChanged; // 0x10
		public int pointGroupCount; // 0x14
		public int primitiveGroupCount; // 0x18
		public int edgeGroupCount; // 0x1C
		public int partCount; // 0x20
	
		// Methods
		public int getGroupCountByType(HAPI_GroupType type); // 0x0000000189D696AC-0x0000000189D696C0
	}

	public struct HAPI_PartInfo // TypeDefIndex: 53059
	{
		// Fields
		public int id; // 0x00
		public int nameSH; // 0x04
		public HAPI_PartType type; // 0x08
		public int faceCount; // 0x0C
		public int vertexCount; // 0x10
		public int pointCount; // 0x14
		public int[] attributeCounts; // 0x18
		public bool isInstanced; // 0x20
		public int instancedPartCount; // 0x24
		public int instanceCount; // 0x28
		public bool hasChanged; // 0x2C
	
		// Properties
		public int pointAttributeCount { get; set; } // 0x0000000189D69810-0x0000000189D69844 0x0000000189D6993C-0x0000000189D6997C
		public int primitiveAttributeCount { get; set; } // 0x0000000189D69844-0x0000000189D69878 0x0000000189D6997C-0x0000000189D699BC
		public int vertexAttributeCount { get; set; } // 0x0000000189D69878-0x0000000189D698AC 0x0000000189D699BC-0x0000000189D699FC
		public int detailAttributeCount { get; set; } // 0x0000000189D697DC-0x0000000189D69810 0x0000000189D698FC-0x0000000189D6993C
	
		// Methods
		public int getElementCountByAttributeOwner(HAPI_AttributeOwner owner); // 0x0000000189D697A0-0x0000000189D697C8
		public int getElementCountByGroupType(HAPI_GroupType type); // 0x0000000189D697C8-0x0000000189D697DC
		public void init(); // 0x0000000189D698AC-0x0000000189D698FC
	}

	[Serializable]
	public struct HAPI_AttributeInfo // TypeDefIndex: 53060
	{
		// Fields
		public bool exists; // 0x00
		public HAPI_AttributeOwner owner; // 0x04
		public HAPI_StorageType storage; // 0x08
		public HAPI_AttributeOwner originalOwner; // 0x0C
		public int count; // 0x10
		public int tupleSize; // 0x14
		public long totalArrayElements; // 0x18
		public HAPI_AttributeTypeInfo typeInfo; // 0x20
	
		// Constructors
		public HAPI_AttributeInfo(string ignored = null); // 0x0000000184DA2730-0x0000000184DA2760
	}

	public struct HAPI_MaterialInfo // TypeDefIndex: 53061
	{
		// Fields
		public int nodeId; // 0x00
		public bool exists; // 0x04
		public bool hasChanged; // 0x05
	}

	public struct HAPI_ImageFileFormat // TypeDefIndex: 53062
	{
		// Fields
		public int nameSH; // 0x00
		public int descriptionSH; // 0x04
		public int defaultExtensionSH; // 0x08
	}

	public struct HAPI_ImageInfo // TypeDefIndex: 53063
	{
		// Fields
		public int imageFileFormatNameSH; // 0x00
		public int xRes; // 0x04
		public int yRes; // 0x08
		public HAPI_ImageDataFormat dataFormat; // 0x0C
		public bool interleaved; // 0x10
		public HAPI_ImagePacking packing; // 0x14
		public double gamma; // 0x18
	}

	public struct HAPI_Keyframe // TypeDefIndex: 53064
	{
		// Fields
		public float time; // 0x00
		public float value; // 0x04
		public float inTangent; // 0x08
		public float outTangent; // 0x0C
	
		// Constructors
		public HAPI_Keyframe(float t, float v, float in_tangent, float out_tangent); // 0x0000000184D88AD0-0x0000000184D88AF0
	}

	public struct HAPI_VolumeInfo // TypeDefIndex: 53065
	{
		// Fields
		public int nameSH; // 0x00
		public HAPI_VolumeType type; // 0x04
		public int xLength; // 0x08
		public int yLength; // 0x0C
		public int zLength; // 0x10
		public int minX; // 0x14
		public int minY; // 0x18
		public int minZ; // 0x1C
		public int tupleSize; // 0x20
		public HAPI_StorageType storage; // 0x24
		public int tileSize; // 0x28
		public HAPI_Transform transform; // 0x30
		public bool hasTaper; // 0x58
		public float xTaper; // 0x5C
		public float yTaper; // 0x60
	}

	public struct HAPI_VolumeTileInfo // TypeDefIndex: 53066
	{
		// Fields
		public int minX; // 0x00
		public int minY; // 0x04
		public int minZ; // 0x08
		public bool isValid; // 0x0C
	}

	public struct HAPI_VolumeVisualInfo // TypeDefIndex: 53067
	{
		// Fields
		public HAPI_VolumeVisualType type; // 0x00
		public float iso; // 0x04
		public float density; // 0x08
	}

	public struct HAPI_CurveInfo // TypeDefIndex: 53068
	{
		// Fields
		public HAPI_CurveType curveType; // 0x00
		public int curveCount; // 0x04
		public int vertexCount; // 0x08
		public int knotCount; // 0x0C
		public bool isPeriodic; // 0x10
		public bool isRational; // 0x11
		public int order; // 0x14
		public bool hasKnots; // 0x18
		public bool isClosed; // 0x19
	}

	public struct HAPI_InputCurveInfo // TypeDefIndex: 53069
	{
		// Fields
		public HAPI_CurveType curveType; // 0x00
		public int order; // 0x04
		public bool closed; // 0x08
		public bool reverse; // 0x09
		public HAPI_InputCurveMethod inputMethod; // 0x0C
		public HAPI_InputCurveParameterization breakpointParameterization; // 0x10
	
		// Methods
		public void FillData(HEU_InputCurveInfo curveInfo); // 0x0000000189D696C0-0x0000000189D69710
	}

	public struct HAPI_BoxInfo // TypeDefIndex: 53070
	{
		// Fields
		public float[] center; // 0x00
		public float[] size; // 0x08
		public float[] rotation; // 0x10
	
		// Constructors
		public HAPI_BoxInfo(bool initialize_fields); // 0x0000000189D69624-0x0000000189D696AC
	}

	public struct HAPI_SphereInfo // TypeDefIndex: 53071
	{
		// Fields
		public float[] center; // 0x00
		public float radius; // 0x08
	
		// Constructors
		public HAPI_SphereInfo(bool initialize_fields); // 0x0000000189D699FC-0x0000000189D69A4C
	}

	public struct HAPI_PDG_EventInfo // TypeDefIndex: 53072
	{
		// Fields
		public int nodeId; // 0x00
		public int workItemId; // 0x04
		public int dependencyId; // 0x08
		public int currentState; // 0x0C
		public int lastState; // 0x10
		public int eventType; // 0x14
		public int msgSH; // 0x18
	}

	public struct HAPI_PDG_WorkItemInfo // TypeDefIndex: 53073
	{
		// Fields
		public int index; // 0x00
		public int outputFileCount; // 0x04
		public int nameSH; // 0x08
	}

	public struct HAPI_PDG_WorkItemOutputFile // TypeDefIndex: 53074
	{
		// Fields
		public int filePathSH; // 0x00
		public int tagSH; // 0x04
		public long hash; // 0x08
	}

	[Serializable]
	public struct HAPI_Viewport // TypeDefIndex: 53075
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationQuaternion; // 0x08
		public float offset; // 0x10
	
		// Constructors
		public HAPI_Viewport(bool initializeFields); // 0x0000000189D69DB8-0x0000000189D69E3C
	
		// Methods
		public void Init(); // 0x0000000189D69D40-0x0000000189D69DB8
	}

	[Serializable]
	public struct HAPI_SessionSyncInfo // TypeDefIndex: 53076
	{
		// Fields
		public bool cookUsingHoudiniTime; // 0x00
		public bool syncViewport; // 0x01
	}

	public struct HAPI_CompositorOptions // TypeDefIndex: 53077
	{
		// Fields
		public int maximumResolutionX; // 0x00
		public int maximumResolutionY; // 0x04
	}

	public class HEU_HARCImports // TypeDefIndex: 53078
	{
		// Constructors
		public HEU_HARCImports(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HEU_HoudiniVersion // TypeDefIndex: 53079
	{
		// Fields
		public const int HOUDINI_MAJOR = 21; // Metadata: 0x02333242
		public const int HOUDINI_MINOR = 0; // Metadata: 0x02333243
		public const int HOUDINI_BUILD = 631; // Metadata: 0x02333244
		public const int HOUDINI_PATCH = 0; // Metadata: 0x02333246
		public const string HOUDINI_VERSION_STRING = "21.0.631"; // Metadata: 0x02333247
		public const int HOUDINI_ENGINE_MAJOR = 8; // Metadata: 0x02333250
		public const int HOUDINI_ENGINE_MINOR = 0; // Metadata: 0x02333251
		public const int HOUDINI_ENGINE_API = 3; // Metadata: 0x02333252
		public const int UNITY_PLUGIN_VERSION = 2; // Metadata: 0x02333253
		public const string HAPI_BIN_PATH = "/bin"; // Metadata: 0x02333254
		public const string HAPI_LIBRARY = "libHAPIL"; // Metadata: 0x02333259
		public const string HARC_LIBRARY = "libHARC"; // Metadata: 0x02333262
		public const string SIDEFX_SOFTWARE_REGISTRY = "SOFTWARE\\Side Effects Software\\"; // Metadata: 0x0233326A
	
		// Constructors
		public HEU_HoudiniVersion(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HTC_APIConstants // TypeDefIndex: 53080
	{
		// Fields
		public const string HOUDINI_MASTER_SERVER_HOSTNAME = "tech.houdini.int.hypergryph.com"; // Metadata: 0x0233328A
		public const int HOUDINI_MASTER_QUERY_FOR_UNITY_PORT = 20240; // Metadata: 0x023332AA
		public const int TCP_HEADER_SIZE = 4; // Metadata: 0x023332AE
		public const int MAX_ERROR_INFO_SIZE = 256; // Metadata: 0x023332AF
	
		// Constructors
		public HTC_APIConstants(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HTC_VERSION // TypeDefIndex: 53081
	{
		// Fields
		public const string LIBRARY = "HTCLib"; // Metadata: 0x023332B1
	
		// Constructors
		public HTC_VERSION(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HoudiniConstsIdentifier // TypeDefIndex: 53082
	{
		// Fields
		public const string HOUDINI_VERSION = "19.5"; // Metadata: 0x023332B8
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x023332BD
	
		// Constructors
		public HoudiniConstsIdentifier(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class HTC_APIFunctions // TypeDefIndex: 53083
	{
		// Constructors
		public HTC_APIFunctions(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal static extern void InitHoudiniTcpClient(string address, int port, bool use_ip, [In, Out] StringBuilder error_msg); // 0x0000000189D830A0-0x0000000189D83180
		internal static extern void GetHarsInfo(ref HarsInfo harsInfo, [In, Out] StringBuilder error_msg); // 0x0000000189D82F90-0x0000000189D830A0
		internal static extern void UninitializeHoudiniTcpClient([In, Out] StringBuilder error_msg); // 0x0000000189D83180-0x0000000189D83220
	}

	internal struct HarsInfo // TypeDefIndex: 53084
	{
		// Fields
		public string hars_address; // 0x00
		public int port; // 0x08
	}

	internal struct GenericMessage // TypeDefIndex: 53085
	{
		// Fields
		[JsonProperty("protocol")]
		public string protocol; // 0x00
		[JsonProperty("body")]
		public object body; // 0x08
	}

	public static class Logger // TypeDefIndex: 53086
	{
		// Methods
		public static void LogError(string msg); // 0x0000000189D84FDC-0x0000000189D85028
		public static void LogWarning(string msg); // 0x0000000189D85074-0x0000000189D850C0
		public static void LogInfo(string msg); // 0x0000000189D85028-0x0000000189D85074
	}

	public class HTC_SessionManager : IDisposable // TypeDefIndex: 53087
	{
		// Fields
		private bool disposedValue; // 0x10
		private static HTC_SessionManager instance_; // 0x00
	
		// Properties
		public static HTC_SessionManager Instance { get; } // 0x0000000189D83D5C-0x0000000189D83DE0 
	
		// Constructors
		private HTC_SessionManager(); // 0x0000000189D83500-0x0000000189D83D5C
	
		// Methods
		~HTC_SessionManager(); // 0x0000000189D833CC-0x0000000189D83440
		protected virtual void Dispose(bool disposing); // 0x0000000189D832D8-0x0000000189D833CC
		public void Dispose(); // 0x0000000189D83288-0x0000000189D832D8
		public bool GetOrRequestAvailableHARSInfo(out string harsAddress, out int harsPort, out string errorInfo); // 0x0000000189D83440-0x0000000189D83500
		public static void Close(); // 0x0000000189D83220-0x0000000189D83288
	}

	public static class HTC_Utils // TypeDefIndex: 53088
	{
		// Fields
		private static readonly string CurrentUnityProjectPrefix; // 0x00
	
		// Constructors
		static HTC_Utils(); // 0x0000000189D83FE8-0x0000000189D84094
	
		// Methods
		public static string GetUnityPathFromSystemPath(string systemPath); // 0x0000000189D83DE0-0x0000000189D83FE8
	}

	public static class HoudiniExtTools // TypeDefIndex: 53089
	{
		// Fields
		private static readonly string LOCAL_IP_ADDRESS; // 0x00
		private static readonly string REMOTE_HOUDINI_SMB_PATH_PREFIX; // 0x08
		private static readonly string REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX; // 0x10
		public const string REMOTE_HOUDINI_HDA_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_hda"; // Metadata: 0x023332EB
		public const string REMOTE_HOUDINI_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_share"; // Metadata: 0x0233331F
		public const string LINUX_MOUNT_DIR_PREFIX = "/mnt/houdini_share"; // Metadata: 0x02333355
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x02333368
	
		// Properties
		private static long DefaultSessionID { get; } // 0x0000000189D84F8C-0x0000000189D84FDC 
	
		// Constructors
		static HoudiniExtTools(); // 0x0000000189D84E90-0x0000000189D84F8C
	
		// Methods
		private static long GetSessionID(long sessionId); // 0x0000000189D84BCC-0x0000000189D84C18
		public static string GetDefaultDirectoryOnTheSMB(); // 0x0000000189D84694-0x0000000189D846E4
		public static string GetDefaultSessionDirectoryOnTheSMB(long sessionId = -1 /* Metadata: 0x023332C2 */); // 0x0000000189D84710-0x0000000189D847B0
		public static string ConvertLocalDirPathToSessionDirPath(string localPath, bool doMd5 = true /* Metadata: 0x023332CA */, long sessionId = -1 /* Metadata: 0x023332CB */); // 0x0000000189D84318-0x0000000189D84448
		public static string ConvertLocalDebugFilePathToSessionDebugFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x023332D3 */); // 0x0000000189D84220-0x0000000189D84318
		public static string ConvertLocalFilePathToSessionFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x023332DB */); // 0x0000000189D84448-0x0000000189D84634
		public static bool IsLocalPath(string path); // 0x0000000189D84C18-0x0000000189D84E90
		public static string GetMD5WithString(string str); // 0x0000000189D84AC8-0x0000000189D84BCC
		public static string GetLocalIPv4(); // 0x0000000189D847DC-0x0000000189D84AC8
		public static string GetHoudiniSMBUrl(); // 0x0000000189D847B0-0x0000000189D847DC
		public static string GetDefaultCachePath(long sessionId = -1 /* Metadata: 0x023332E3 */); // 0x0000000189D84634-0x0000000189D84694
		public static string GetDefaultHdaPath(); // 0x0000000189D846E4-0x0000000189D84710
	}

	public static class HoudiniExtBridge // TypeDefIndex: 53090
	{
		// Methods
		public static bool GetParametersFromHDA(byte[] hdaBytes, out HEU_Parameters parameters, out List<HEU_InputNode> inputNodes); // 0x0000000189D840D4-0x0000000189D84220
		public static void AddInputNodeToHoudiniAsset(HEU_HoudiniAsset asset, HEU_InputNode node); // 0x0000000189D84094-0x0000000189D840B0
	
		// Extension methods
		public static void Clear(this HEU_Parameters parameters); // 0x0000000189D840B0-0x0000000189D840D4
	}

	[Serializable]
	public sealed class HEU_ParameterData : IEquivable<HEU_ParameterData> // TypeDefIndex: 53091
	{
		// Fields
		public int _unityIndex; // 0x10
		public string _name; // 0x18
		public string _labelName; // 0x20
		public string _help; // 0x28
		public List<int> _childParameterIDs; // 0x30
		public int _choiceValue; // 0x38
		public int[] _intValues; // 0x40
		public float[] _floatValues; // 0x48
		public string[] _stringValues; // 0x50
		public bool _toggle; // 0x58
		public UnityEngine.Color _color; // 0x5C
		public Gradient _gradient; // 0x70
		public AnimationCurve _animCurve; // 0x78
		public GUIContent[] _choiceLabels; // 0x80
		public string[] _choiceStringValues; // 0x88
		public int[] _choiceIntValues; // 0x90
		public HAPI_ParmInfo _parmInfo; // 0x98
		public bool _showChildren; // 0x12C
		public string _fileTypeInfo; // 0x130
		public int _folderListChildrenProcessed; // 0x138
		public int _tabSelectedIndex; // 0x13C
		public HEU_InputNode _paramInputNode; // 0x140
		public bool _hasAssetPathTag; // 0x148
	
		// Properties
		public int ParmID { get; } // 0x0000000184D862D0-0x0000000184D862E0 
		public int ParentID { get; } // 0x0000000184D86C60-0x0000000184D86C70 
		public int ChildIndex { get; } // 0x0000000184D88CD0-0x0000000184D88CE0 
		public int ParmSize { get; } // 0x0000000184D8E580-0x0000000184D8E590 
		public int IntMin { get; } // 0x0000000189D70374-0x0000000189D70384 
		public int IntMax { get; } // 0x0000000189D70364-0x0000000189D70374 
		public int IntUIMin { get; } // 0x0000000189D70394-0x0000000189D703A4 
		public int IntUIMax { get; } // 0x0000000189D70384-0x0000000189D70394 
		public float FloatMin { get; } // 0x0000000184D9DFB0-0x0000000184D9DFC0 
		public float FloatMax { get; } // 0x0000000184DA29C0-0x0000000184DA29D0 
		public float FloatUIMin { get; } // 0x0000000184D8E2D0-0x0000000184D8E2E0 
		public float FloatUIMax { get; } // 0x0000000184DA29D0-0x0000000184DA29E0 
	
		// Constructors
		public HEU_ParameterData(); // 0x0000000189D702EC-0x0000000189D70364
	
		// Methods
		public bool IsInt(); // 0x0000000189D7020C-0x0000000189D70218
		public bool IsFloat(); // 0x0000000189D701F4-0x0000000189D70200
		public bool IsString(); // 0x0000000189D70254-0x0000000189D70260
		public bool IsPathFile(); // 0x0000000189D70224-0x0000000189D7023C
		public bool HasMin(); // 0x0000000184DA2990-0x0000000184DA29A0
		public bool HasMax(); // 0x0000000184DA2980-0x0000000184DA2990
		public bool HasUIMin(); // 0x0000000184DA29B0-0x0000000184DA29C0
		public bool HasUIMax(); // 0x0000000184DA29A0-0x0000000184DA29B0
		public bool IsContainer(); // 0x0000000189D6FA6C-0x0000000189D6FAB0
		public bool IsMultiParam(); // 0x0000000189D70218-0x0000000189D70224
		public bool IsRamp(); // 0x0000000189D7023C-0x0000000189D70254
		public bool IsFloatRamp(); // 0x0000000189D701E8-0x0000000189D701F4
		public bool IsColorRamp(); // 0x0000000189D6FA54-0x0000000189D6FA60
		public bool IsToggle(); // 0x0000000189D70260-0x0000000189D7026C
		public bool IsColor(); // 0x0000000189D6FA60-0x0000000189D6FA6C
		public bool IsFolder(); // 0x0000000189D70200-0x0000000189D7020C
		public bool IsButton(); // 0x0000000189D6FA48-0x0000000189D6FA54
		public Vector3 ToVector3(); // 0x0000000189D7026C-0x0000000189D702EC
		public bool IsAssetPath(); // 0x0000000184D8FE60-0x0000000184D8FE70
		public bool IsEquivalentTo(HEU_ParameterData other); // 0x0000000189D6FAB0-0x0000000189D701E8
	}

	public enum HEU_ModifierActionWrapper // TypeDefIndex: 53092
	{
		MULTIPARM_INSERT = 0,
		MULTIPARM_REMOVE = 1,
		MULTIPARM_CLEAR = 2,
		SET_FLOAT = 3,
		SET_INT = 4
	}

	[Serializable]
	public class HEU_ParameterModifier : IEquivable<HEU_ParameterModifier> // TypeDefIndex: 53094
	{
		// Fields
		[SerializeField]
		private int _parameterIndex; // 0x10
		[SerializeField]
		internal ModifierAction _action; // 0x14
		[SerializeField]
		private int _instanceIndex; // 0x18
		[SerializeField]
		private int _modifierValue; // 0x1C
		[SerializeField]
		private float _floatValue; // 0x20
		[SerializeField]
		private int _intValue; // 0x24
	
		// Properties
		public int ParameterIndex { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public HEU_ModifierActionWrapper Action { get; set; } // 0x0000000189D7067C-0x0000000189D70688 0x0000000189D70688-0x0000000189D706A8
		public int InstanceIndex { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public int ModifierValue { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public float FloatValue { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public int IntValue { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
	
		// Nested types
		internal enum ModifierAction // TypeDefIndex: 53093
		{
			MULTIPARM_INSERT = 0,
			MULTIPARM_REMOVE = 1,
			MULTIPARM_CLEAR = 2,
			SET_FLOAT = 3,
			SET_INT = 4
		}
	
		// Constructors
		public HEU_ParameterModifier(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static HEU_ParameterModifier GetNewModifier(HEU_ModifierActionWrapper action, int parameterIndex, int instanceIndex, int modifierValue); // 0x0000000189D703A4-0x0000000189D703EC
		internal static HEU_ParameterModifier GetNewModifier(ModifierAction action, int parameterIndex, int instanceIndex, int modifierValue); // 0x0000000189D703EC-0x0000000189D70460
		public bool IsEquivalentTo(HEU_ParameterModifier other); // 0x0000000189D70460-0x0000000189D70648
		internal static HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(ModifierAction action); // 0x0000000189D70648-0x0000000189D7067C
		internal static ModifierAction ModifierAction_WrapperToInternal(HEU_ModifierActionWrapper action); // 0x0000000189D70648-0x0000000189D7067C
	}

	public class HEU_Parameters : ScriptableObject, IHEU_Parameters, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Parameters> // TypeDefIndex: 53097
	{
		// Fields
		[NonSerialized]
		private int _nodeID; // 0x18
		[SerializeField]
		internal string _uiLabel; // 0x20
		[SerializeField]
		private int[] _paramInts; // 0x28
		[SerializeField]
		private float[] _paramFloats; // 0x30
		[SerializeField]
		private string[] _paramStrings; // 0x38
		[SerializeField]
		private HAPI_ParmChoiceInfo[] _paramChoices; // 0x40
		[SerializeField]
		private List<int> _rootParameters; // 0x48
		[SerializeField]
		private List<HEU_ParameterData> _parameterList; // 0x50
		[SerializeField]
		private List<HEU_ParameterModifier> _parameterModifiers; // 0x58
		[SerializeField]
		private bool _regenerateParameters; // 0x60
		[SerializeField]
		private byte[] _presetData; // 0x68
		[SerializeField]
		private byte[] _defaultPresetData; // 0x70
		[SerializeField]
		private bool _validParameters; // 0x78
		[HideInInspector]
		[SerializeField]
		private bool _showParameters; // 0x79
		private bool _recacheUI; // 0x7A
		[SerializeField]
		private HEU_HoudiniAsset _parentAsset; // 0x80
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000184D86260-0x0000000184D86270 
		public bool ShowParameters { get; set; } // 0x0000000184D88E40-0x0000000184D88E50 0x0000000184D88E90-0x0000000184D88EA0
		public int NodeID { get; internal set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public List<int> RootParameters { get; } // 0x0000000184D86200-0x0000000184D86210 
		public List<HEU_ParameterModifier> ParameterModifiers { get; } // 0x0000000182E56440-0x0000000182E56460 
		internal bool RequiresRegeneration { get; set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000184D88350-0x0000000184D88360
		internal bool RecacheUI { get; set; } // 0x0000000184D88E50-0x0000000184D88E60 0x0000000184D88EA0-0x0000000184D88EB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 53095
		{
			// Fields
			public int parentID; // 0x10
			public Predicate<HAPI_ParmInfo> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass82_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Initialize_b__0(HAPI_ParmInfo p); // 0x000000018702DACC-0x000000018702DAD8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0 // TypeDefIndex: 53096
		{
			// Fields
			public int parentID; // 0x10
			public Predicate<HAPI_ParmInfo> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass83_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Initialize4HGTool_b__0(HAPI_ParmInfo p); // 0x000000018702DACC-0x000000018702DAD8
		}
	
		// Constructors
		public HEU_Parameters(); // 0x0000000189D7B618-0x0000000189D7B758
	
		// Methods
		internal byte[] GetPresetData(); // 0x0000000184D86230-0x0000000184D86240
		internal void SetPresetData(byte[] data); // 0x000000018485F170-0x000000018485F180
		internal byte[] GetDefaultPresetData(); // 0x0000000184D862B0-0x0000000184D862C0
		public bool AreParametersValid(); // 0x0000000184D86F90-0x0000000184D86FA0
		public HEU_SessionBase GetSession(); // 0x0000000189D73114-0x0000000189D731AC
		public void Recook(); // 0x0000000189D78444-0x0000000189D784AC
		public List<HEU_ParameterData> GetParameters(); // 0x0000000184D86270-0x0000000184D86280
		public HEU_ParameterData GetParameter(int listIndex); // 0x0000000189D72E4C-0x0000000189D72EBC
		public HEU_ParameterData GetParameter(string name); // 0x0000000189D72EBC-0x0000000189D72FFC
		public HEU_ParameterData GetParameterWithParmID(int parmID); // 0x0000000189D72D2C-0x0000000189D72E4C
		public void RemoveParameter(int listIndex); // 0x0000000189D78534-0x0000000189D785A0
		public bool HaveParametersChanged(); // 0x0000000189D73590-0x0000000189D73A3C
		public bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x02333377 */); // 0x0000000189D7874C-0x0000000189D78794
		public bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x02333378 */, bool bRecookAsset = false /* Metadata: 0x02333379 */); // 0x0000000189D793E0-0x0000000189D795E8
		public bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x0233337A */); // 0x0000000189D71888-0x0000000189D71A7C
		public bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x0233337B */); // 0x0000000189D795E8-0x0000000189D79844
		public bool GetFloatParameterValues(string parameterName, out float[] values); // 0x0000000189D71A7C-0x0000000189D71C14
		public bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x0233337C */); // 0x0000000189D78E24-0x0000000189D78F50
		public bool GetColorParameterValue(string parameterName, out UnityEngine.Color value); // 0x0000000189D71244-0x0000000189D71364
		public bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x0233337D */, bool bRecookAsset = false /* Metadata: 0x0233337E */); // 0x0000000189D79CDC-0x0000000189D79EE4
		public bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x0233337F */); // 0x0000000189D7241C-0x0000000189D72610
		public bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x02333380 */); // 0x0000000189D79EE4-0x0000000189D7A148
		public bool GetIntParameterValues(string parameterName, out int[] values); // 0x0000000189D72610-0x0000000189D727AC
		public bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x02333381 */); // 0x0000000189D78C54-0x0000000189D78E24
		public bool GetChoiceParameterValue(string parameterName, out int value); // 0x0000000189D7109C-0x0000000189D71244
		public bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x02333382 */, bool bRecookAsset = false /* Metadata: 0x02333383 */); // 0x0000000189D78B38-0x0000000189D78C54
		public bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x02333384 */); // 0x0000000189D70F90-0x0000000189D7109C
		public bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x02333385 */, bool bRecookAsset = false /* Metadata: 0x02333386 */); // 0x0000000189D7A7A8-0x0000000189D7A9B0
		public bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x02333387 */); // 0x0000000189D731AC-0x0000000189D733C8
		public bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x02333388 */); // 0x0000000189D7A9B0-0x0000000189D7AC20
		public bool GetStringParameterValues(string parameterName, out string[] values); // 0x0000000189D733C8-0x0000000189D7354C
		public bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x02333389 */, bool bRecookAsset = false /* Metadata: 0x0233338A */); // 0x0000000189D78794-0x0000000189D7895C
		public bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x0233338B */); // 0x0000000189D7895C-0x0000000189D78B38
		public bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x0233338C */); // 0x0000000189D70C4C-0x0000000189D70DC4
		public bool GetAssetRefParameterValues(string parameterName, out GameObject[] values); // 0x0000000189D70DC4-0x0000000189D70F90
		public bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x0233338D */); // 0x0000000189D7A534-0x0000000189D7A7A8
		public bool GetRampParameterNumPoints(string parameterName, out int numPoints); // 0x0000000189D72FFC-0x0000000189D73114
		public bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0233338E */, bool bRecookAsset = false /* Metadata: 0x0233338F */); // 0x0000000189D79844-0x0000000189D79B3C
		public bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType); // 0x0000000189D71C14-0x0000000189D71F08
		public bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x02333390 */); // 0x0000000189D79B3C-0x0000000189D79CDC
		public bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints); // 0x0000000189D71F08-0x0000000189D7213C
		public bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x02333391 */, bool bRecookAsset = false /* Metadata: 0x02333392 */); // 0x0000000189D78F50-0x0000000189D79234
		public bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType); // 0x0000000189D71364-0x0000000189D71650
		public bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x02333393 */); // 0x0000000189D79234-0x0000000189D793E0
		public bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints); // 0x0000000189D71650-0x0000000189D71888
		public bool TriggerButtonParameter(string parameterName); // 0x0000000189D7B134-0x0000000189D7B270
		public bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecook = true /* Metadata: 0x02333394 */); // 0x0000000189D7A148-0x0000000189D7A534
		public bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples); // 0x0000000189D72948-0x0000000189D72D2C
		internal bool Initialize(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, Dictionary<string, HEU_ParameterData> previousParamFolders, Dictionary<string, HEU_InputNode> previousParamInputNodes, HEU_HoudiniAsset parentAsset); // 0x0000000189D75B80-0x0000000189D77CF8
		internal bool Initialize4HGTool(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, int parentNodeId); // 0x0000000189D73A3C-0x0000000189D75B80
		private void SetupRampParameter(HEU_ParameterData rampParameter); // 0x0000000189D7AC20-0x0000000189D7B02C
		internal bool UploadValuesToHoudini(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bDoCheck = true /* Metadata: 0x02333395 */, bool bForceUploadInputs = false /* Metadata: 0x02333396 */); // 0x0000000189D7B514-0x0000000189D7B618
		internal void InsertInstanceToMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToAdd); // 0x0000000189D77CF8-0x0000000189D77D80
		internal void RemoveInstancesFromMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToRemove); // 0x0000000189D784AC-0x0000000189D78534
		internal void ClearInstancesFromMultiParm(int unityParamIndex); // 0x0000000189D70B44-0x0000000189D70BB4
		internal bool HasModifiersPending(); // 0x0000000189D7354C-0x0000000189D73590
		internal void ProcessModifiers(HEU_SessionBase session); // 0x0000000189D77FE0-0x0000000189D78444
		internal void GetParameterDataForUIRestore(Dictionary<string, HEU_ParameterData> folderParams, Dictionary<string, HEU_InputNode> inputNodeParams); // 0x0000000189D727AC-0x0000000189D72948
		internal void GetInputNodeConnectionObjects(List<GameObject> inputNodeObjects); // 0x0000000189D7213C-0x0000000189D7241C
		internal void DownloadPresetData(HEU_SessionBase session); // 0x0000000189D70C00-0x0000000189D70C4C
		internal void UploadPresetData(HEU_SessionBase session); // 0x0000000189D7B4EC-0x0000000189D7B514
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session); // 0x0000000189D70BB4-0x0000000189D70C00
		internal void UploadParameterInputs(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bForceUpdate); // 0x0000000189D7B300-0x0000000189D7B4EC
		internal void UpdateTransformParameters(HEU_SessionBase session, ref HAPI_TransformEuler HAPITransform); // 0x0000000189D7B270-0x0000000189D7B300
		internal void SyncParameterFromHoudini(HEU_SessionBase session, string parameterName); // 0x0000000189D7B104-0x0000000189D7B134
		internal void SyncInternalParametersForUndoCompare(HEU_SessionBase session); // 0x0000000189D7B02C-0x0000000189D7B104
		internal void CleanUp(); // 0x0000000189D706A8-0x0000000189D70B44
		internal void ResetAllToDefault(HEU_SessionBase session); // 0x0000000189D785A0-0x0000000189D7874C
		public bool IsEquivalentTo(HEU_Parameters other); // 0x0000000189D77D80-0x0000000189D77FE0
	}

	public static class HEU_ParameterUtility // TypeDefIndex: 53098
	{
		// Methods
		public static bool GetToggle(HEU_HoudiniAsset asset, string paramName, out bool outValue); // 0x0000000189D90A64-0x0000000189D90B28
		public static bool SetToggle(HEU_HoudiniAsset asset, string paramName, bool setValue); // 0x0000000189D91090-0x0000000189D91154
		public static bool GetInt(HEU_HoudiniAsset asset, string paramName, out int outValue); // 0x0000000189D90658-0x0000000189D9071C
		public static bool SetInt(HEU_HoudiniAsset asset, string paramName, int setValue); // 0x0000000189D90F08-0x0000000189D90FCC
		public static bool GetFloat(HEU_HoudiniAsset asset, string paramName, out float outValue); // 0x0000000189D90404-0x0000000189D904C8
		public static bool GetFloats(HEU_HoudiniAsset asset, string paramName, out float[] outValues); // 0x0000000189D904C8-0x0000000189D9058C
		public static bool SetFloat(HEU_HoudiniAsset asset, string paramName, float setValue); // 0x0000000189D90CB4-0x0000000189D90D78
		public static bool SetFloats(HEU_HoudiniAsset asset, string paramName, float[] setValues); // 0x0000000189D90D78-0x0000000189D90E38
		public static bool GetString(HEU_HoudiniAsset asset, string paramName, out string outValue); // 0x0000000189D90998-0x0000000189D90A64
		public static bool SetString(HEU_HoudiniAsset asset, string paramName, string setValue); // 0x0000000189D90FCC-0x0000000189D91090
		public static bool SetChoice(HEU_HoudiniAsset asset, string paramName, int setValue); // 0x0000000189D90B28-0x0000000189D90BE8
		public static bool GetChoice(HEU_HoudiniAsset asset, string paramName, out int outValue); // 0x0000000189D9027C-0x0000000189D90338
		public static bool SetInputNode(HEU_HoudiniAsset asset, string paramName, GameObject obj, int index); // 0x0000000189D90E38-0x0000000189D90F08
		public static bool GetInputNode(HEU_HoudiniAsset asset, string paramName, int index, out GameObject obj); // 0x0000000189D9058C-0x0000000189D90658
		public static bool GetColor(HEU_HoudiniAsset asset, string paramName, out UnityEngine.Color getValue); // 0x0000000189D90338-0x0000000189D90404
		public static bool SetColor(HEU_HoudiniAsset asset, string paramName, UnityEngine.Color setValue); // 0x0000000189D90BE8-0x0000000189D90CB4
		public static int GetParameterIndexFromName(HEU_SessionBase session, HAPI_ParmInfo[] parameters, string parameterName); // 0x0000000189D908DC-0x0000000189D90998
		public static int GetParameterIndexFromNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName); // 0x0000000189D908A8-0x0000000189D908DC
		public static int FindTextureParamByNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, string useTextureParmName); // 0x0000000189D90190-0x0000000189D9027C
		public static bool GetParameterFloatValue(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, float defaultValue, out float returnValue); // 0x0000000189D907FC-0x0000000189D908A8
		public static bool GetParameterColor3Value(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, UnityEngine.Color defaultValue, out UnityEngine.Color outputColor); // 0x0000000189D9071C-0x0000000189D907FC
	}

	[Serializable]
	public class HEU_PDGCookedDataEvent : UnityEvent<HEU_PDGCookedEventData> // TypeDefIndex: 53099
	{
		// Constructors
		public HEU_PDGCookedDataEvent(); // 0x0000000189D8F8F0-0x0000000189D8F92C
	}

	public class HEU_PDGCookedEventData // TypeDefIndex: 53100
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_TOPNodeData TopNodeData; // 0x18
	
		// Constructors
		public HEU_PDGCookedEventData(bool bSuccess, HEU_TOPNodeData bTopNodeData); // 0x0000000183219380-0x0000000183219390
	}

	[ExecuteInEditMode]
	public class HEU_PDGAssetLink : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 53105
	{
		// Fields
		[SerializeField]
		private HEU_PDGCookedDataEvent _cookedDataEvent; // 0x18
		[SerializeField]
		private string _assetPath; // 0x20
		[SerializeField]
		private GameObject _assetGO; // 0x28
		[SerializeField]
		private string _assetName; // 0x30
		[SerializeField]
		private int _assetID; // 0x38
		[SerializeField]
		private HEU_HoudiniAsset _heu; // 0x40
		[SerializeField]
		private List<HEU_TOPNetworkData> _topNetworks; // 0x48
		[SerializeField]
		private string[] _topNetworkNames; // 0x50
		[SerializeField]
		private int _selectedTOPNetwork; // 0x58
		[SerializeField]
		private LinkState _linkState; // 0x5C
		[SerializeField]
		private bool _autoCook; // 0x60
		[SerializeField]
		private bool _useHEngineData; // 0x61
		public UpdateUIDelegate _repaintUIDelegate; // 0x68
		public HEU_WorkItemTally _workItemTally; // 0x70
		[SerializeField]
		private GameObject _loadRootGameObject; // 0x78
		[SerializeField]
		private string _outputCachePathRoot; // 0x80
		[SerializeField]
		private bool _bUseTOPNodeFilter; // 0x88
		[SerializeField]
		private bool _bUseTOPOutputFilter; // 0x89
		[SerializeField]
		private string _topNodeFilter; // 0x90
		[SerializeField]
		private string _topOutputFilter; // 0x98
		private int _numLoadingResults; // 0xA0
		private int _numTotalResults; // 0xA4
	
		// Properties
		public bool AutoCook { get; set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000184D88350-0x0000000184D88360
		public bool UseHEngineData { get; set; } // 0x0000000184D892D0-0x0000000184D892E0 0x0000000184D8FF40-0x0000000184D8FF50
		public bool UseTOPNodeFilter { get; set; } // 0x00000001811F2750-0x00000001811F2760 0x00000001811F2760-0x00000001811F2770
		public bool UseTOPOutputFilter { get; set; } // 0x0000000184D89060-0x0000000184D89070 0x0000000184D90C50-0x0000000184D90C60
		public string TopNodeFilter { get; set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public string TopOutputFilter { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public string AssetPath { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public GameObject AssetGO { get; } // 0x0000000184D86240-0x0000000184D86250 
		public string AssetName { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public int AssetID { get; } // 0x0000000184D863B0-0x0000000184D863C0 
		public List<HEU_TOPNetworkData> TopNetworks { get; } // 0x0000000184D86200-0x0000000184D86210 
		public string[] TopNetworkNames { get; } // 0x0000000184D86270-0x0000000184D86280 
		public int SelectedTOPNetwork { get; } // 0x0000000184D86570-0x0000000184D86580 
		public HEU_LinkStateWrapper PDGLinkState { get; } // 0x0000000189D8F8C4-0x0000000189D8F8F0 
		public GameObject LoadRootGameObject { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public string OutputCachePathRoot { get; } // 0x0000000184D86260-0x0000000184D86270 
		public HEU_PDGCookedDataEvent CookedDataEvent { get; } // 0x000000018385B100-0x000000018385B110 
		internal LinkState AssetLinkStateInternal { get; } // 0x0000000184D86560-0x0000000184D86570 
	
		// Nested types
		internal enum LinkState // TypeDefIndex: 53101
		{
			INACTIVE = 0,
			LINKING = 1,
			LINKED = 2,
			ERROR_NOT_LINKED = 3
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 53102; 0x00000001853DEDB8-0x00000001853DEDC8
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0 // TypeDefIndex: 53103
		{
			// Fields
			public HEU_PDGAssetLink __4__this; // 0x10
			public Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced; // 0x18
			public HEU_TOPNodeData topNode; // 0x20
	
			// Constructors
			public __c__DisplayClass107_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_1 // TypeDefIndex: 53104
		{
			// Fields
			public HEU_GeoSync geoSync; // 0x10
			public __c__DisplayClass107_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass107_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadResults_b__0(HEU_SyncedEventData Data); // 0x0000000189D9455C-0x0000000189D94634
		}
	
		// Constructors
		public HEU_PDGAssetLink(); // 0x0000000189D8F7B4-0x0000000189D8F8C4
	
		// Methods
		public void Setup(HEU_HoudiniAsset hdaAsset); // 0x0000000189D8F20C-0x0000000189D8F39C
		public void Reset(); // 0x0000000189D8F068-0x0000000189D8F070
		public void Refresh(); // 0x0000000189D8ED18-0x0000000189D8EFA4
		public List<KeyValuePair<int, HEU_TOPNodeData>> GetNonHiddenTOPNodes(HEU_TOPNetworkData topNetwork); // 0x0000000189D8D1F4-0x0000000189D8D340
		public void SelectTOPNetwork(int newIndex); // 0x0000000189D8F070-0x0000000189D8F0C4
		public void SelectTOPNode(HEU_TOPNetworkData network, int newIndex); // 0x0000000189D8F0C4-0x0000000189D8F11C
		public HEU_TOPNetworkData GetSelectedTOPNetwork(); // 0x0000000189D8D340-0x0000000189D8D34C
		public HEU_TOPNodeData GetSelectedTOPNode(); // 0x0000000189D8D34C-0x0000000189D8D3C8
		public HEU_TOPNetworkData GetTOPNetwork(int index); // 0x0000000189D8D470-0x0000000189D8D4E0
		public void DirtyTOPNode(HEU_TOPNodeData topNode); // 0x0000000189D8CEE8-0x0000000189D8CF10
		public void CookTOPNode(HEU_TOPNodeData topNode); // 0x0000000189D8CEE8-0x0000000189D8CF10
		public void DirtyAll(); // 0x0000000189D8D0C0-0x0000000189D8D0E0
		public void CookOutput(); // 0x0000000189D8CEA4-0x0000000189D8CEE8
		public void PauseCook(); // 0x0000000189D8C924-0x0000000189D8C934
		public void CancelCook(); // 0x0000000189D8C924-0x0000000189D8C934
		public HEU_SessionBase GetHAPISession(); // 0x0000000189D8D0E0-0x0000000189D8D154
		public HEU_TOPNodeData GetTOPNode(int nodeID); // 0x0000000189D8D658-0x0000000189D8D7BC
		public string GetTOPNodeStatus(HEU_TOPNodeData topNode); // 0x0000000189D8D588-0x0000000189D8D658
		public static HEU_TOPNetworkData GetTOPNetworkByName(string name, List<HEU_TOPNetworkData> topNetworks); // 0x0000000189D8D3C8-0x0000000189D8D470
		public static HEU_TOPNodeData GetTOPNodeByName(string name, List<HEU_TOPNodeData> topNodes); // 0x0000000189D8D4E0-0x0000000189D8D588
		private void Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		public void OnAfterDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		private void HandleInitialLoad(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x0000000189D8E0DC-0x0000000189D8E0EC
		private void NotifyAssetCooked(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> generatedOutputs); // 0x0000000189D8E0A4-0x0000000189D8E0DC
		private void NotifyAssetCooked(HEU_CookedEventData cookedEventData); // 0x0000000189D8E07C-0x0000000189D8E0A4
		private void NotifyAssetCooked(HEU_ReloadEventData reloadEventData); // 0x0000000189D8E07C-0x0000000189D8E0A4
		private void PopulateFromHDA(); // 0x0000000189D8E880-0x0000000189D8E9C8
		public bool PopulateTOPNetworks(); // 0x0000000189D8E9C8-0x0000000189D8EBA0
		private bool PopulateTOPNodes(HEU_SessionBase session, HEU_TOPNetworkData topNetwork, int[] topNodeIDs, bool useHEngineData); // 0x0000000189D8EBA0-0x0000000189D8ED18
		private void ClearAllTOPData(); // 0x0000000189D8C934-0x0000000189D8CC00
		private static void ClearTOPNetworkWorkItemResults(HEU_TOPNetworkData topNetwork); // 0x0000000189D8CC00-0x0000000189D8CD14
		internal static void ClearTOPNodeWorkItemResults(HEU_TOPNodeData topNode); // 0x0000000189D8CD14-0x0000000189D8CE10
		internal static void ClearWorkItemResultByID(HEU_TOPNodeData topNode, int workItemID); // 0x0000000189D8CE10-0x0000000189D8CE34
		private static void ClearWorkItemResult(HEU_TOPNodeData topNode, HEU_TOPWorkResult result); // 0x0000000189D8CE34-0x0000000189D8CEA4
		internal void UpdateTOPNodeResultsVisibility(HEU_TOPNodeData topNode); // 0x0000000189D8F39C-0x0000000189D8F410
		private static HEU_TOPWorkResult GetWorkResultByID(HEU_TOPNodeData topNode, int workItemID); // 0x0000000189D8D7BC-0x0000000189D8D908
		private static void DestroyWorkItemResultData(HEU_TOPNodeData topNode, HEU_TOPWorkResult result); // 0x0000000189D8CF10-0x0000000189D8D0C0
		internal void LoadResults(HEU_SessionBase session, HEU_TOPNodeData topNode, HAPI_PDG_WorkItemInfo workItemInfo, HAPI_PDG_WorkItemOutputFile[] resultInfos, int workItemID, Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced); // 0x0000000189D8D908-0x0000000189D8E07C
		private Transform GetLoadRootTransform(); // 0x0000000189D8D154-0x0000000189D8D1F4
		public void RepaintUI(); // 0x0000000189D8EFA4-0x0000000189D8EFBC
		public void UpdateWorkItemTally(); // 0x0000000189D8F410-0x0000000189D8F7B4
		internal void ResetTOPNetworkWorkItemTally(HEU_TOPNetworkData topNetwork); // 0x0000000189D8EFBC-0x0000000189D8F068
		internal void OnTOPNodeFilterChanged(string filter); // 0x0000000189D8E144-0x0000000189D8E4C0
		internal void OnTOPOutputFilterChanged(string filter); // 0x0000000189D8E4C0-0x0000000189D8E820
		private static void ParseHEngineData(HEU_SessionBase session, int topNodeID, ref HAPI_NodeInfo nodeInfo, ref TOPNodeTags nodeTags); // 0x0000000189D8E820-0x0000000189D8E880
		private void SetupTopNetworkNames(HEU_TOPNetworkData topNetwork); // 0x0000000189D8F11C-0x0000000189D8F20C
		private void OnSyncComplete(HEU_PDGCookedEventData Data); // 0x0000000189D8E0EC-0x0000000189D8E144
		internal static HEU_LinkStateWrapper LinkState_InternalToWrapper(LinkState linkState); // 0x0000000189D43A04-0x0000000189D43A2C
		internal static LinkState LinkState_WrapperToInternal(HEU_LinkStateWrapper linkState); // 0x0000000189D43A04-0x0000000189D43A2C
	}

	public class TOPNodeTags // TypeDefIndex: 53106
	{
		// Fields
		public bool _show; // 0x10
		public bool _autoload; // 0x11
		public bool _showHEngineData; // 0x12
		public bool _autoloadHEngineData; // 0x13
	
		// Constructors
		public TOPNodeTags(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class HEU_TOPNetworkData // TypeDefIndex: 53107
	{
		// Fields
		public int _nodeID; // 0x10
		public string _nodeName; // 0x18
		public List<HEU_TOPNodeData> _topNodes; // 0x20
		public string[] _topNodeNames; // 0x28
		public int _selectedTOPIndex; // 0x30
		public string _parentName; // 0x38
		public TOPNodeTags _tags; // 0x40
	
		// Constructors
		public HEU_TOPNetworkData(); // 0x0000000189D93B54-0x0000000189D93C1C
	}

	[Serializable]
	public class HEU_TOPNodeData // TypeDefIndex: 53109
	{
		// Fields
		public int _nodeID; // 0x10
		public string _nodeName; // 0x18
		public string _parentName; // 0x20
		public GameObject _workResultParentGO; // 0x28
		public List<HEU_TOPWorkResult> _workResults; // 0x30
		public TOPNodeTags _tags; // 0x38
		public bool _showResults; // 0x40
		public PDGState _pdgState; // 0x44
		[SerializeField]
		public HEU_WorkItemTally _workItemTally; // 0x48
	
		// Nested types
		public enum PDGState // TypeDefIndex: 53108
		{
			NONE = 0,
			DIRTIED = 1,
			DIRTYING = 2,
			COOKING = 3,
			COOK_COMPLETE = 4,
			COOK_FAILED = 5
		}
	
		// Constructors
		public HEU_TOPNodeData(); // 0x0000000189D93CA8-0x0000000189D93D78
	
		// Methods
		public void Reset(); // 0x0000000189D93C7C-0x0000000189D93CA8
		public bool AreAllWorkItemsComplete(); // 0x0000000189D93C5C-0x0000000189D93C7C
		public bool AnyWorkItemsFailed(); // 0x0000000189D93C1C-0x0000000189D93C3C
		public bool AnyWorkItemsPending(); // 0x0000000189D93C3C-0x0000000189D93C5C
	}

	[Serializable]
	public class HEU_TOPWorkResult // TypeDefIndex: 53110
	{
		// Fields
		public int _workItemIndex; // 0x10
		public int _workItemID; // 0x14
		public List<GameObject> _generatedGOs; // 0x18
	
		// Constructors
		public HEU_TOPWorkResult(); // 0x0000000189D93D78-0x0000000189D93DF8
	}

	[Serializable]
	public class HEU_WorkItemTally // TypeDefIndex: 53111
	{
		// Fields
		public int _totalWorkItems; // 0x10
		public int _waitingWorkItems; // 0x14
		public int _scheduledWorkItems; // 0x18
		public int _cookingWorkItems; // 0x1C
		public int _cookedWorkItems; // 0x20
		public int _erroredWorkItems; // 0x24
	
		// Constructors
		public HEU_WorkItemTally(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void ZeroAll(); // 0x0000000184DA2BD0-0x0000000184DA2BE0
		public bool AreAllWorkItemsComplete(); // 0x0000000189D944AC-0x0000000189D944CC
		public bool AnyWorkItemsFailed(); // 0x0000000189D94488-0x0000000189D94490
		public bool AnyWorkItemsPending(); // 0x0000000189D94490-0x0000000189D944AC
		public string ProgressRatio(); // 0x0000000189D944CC-0x0000000189D9455C
	}

	public class HEU_PDGSession // TypeDefIndex: 53115
	{
		// Fields
		private static HEU_PDGSession _pdgSession; // 0x00
		private List<HEU_PDGAssetLink> _pdgAssets; // 0x10
		public int _pdgMaxProcessEvents; // 0x18
		public HAPI_PDG_EventInfo[] _pdgQueryEvents; // 0x20
		public int[] _pdgContextIDs; // 0x28
		public bool _errored; // 0x30
		public string _errorMsg; // 0x38
		public HAPI_PDG_State _pdgState; // 0x40
		private Action<HEU_PDGCookedEventData> _cookedDataEvent; // 0x48
		private bool _pendingCallback; // 0x50
		private int _numItemsCompleted; // 0x54
		private int _totalNumItems; // 0x58
		private bool _callbackSuccess; // 0x5C
		[SerializeField]
		private StringBuilder _pdgEventMessages; // 0x60
		private string[] _eventMessageColorCode; // 0x68
	
		// Properties
		public Action<HEU_PDGCookedEventData> CookedDataEvent { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
		// Nested types
		private delegate void OnWorkItemLoadResultsDelegate(HEU_SyncedEventData OnSynced); // TypeDefIndex: 53112; 0x0000000182B46B90-0x0000000182B46BA0
	
		private enum EventMessageColor // TypeDefIndex: 53113
		{
			DEFAULT = 0,
			WARNING = 1,
			ERROR = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 53114
		{
			// Fields
			public int[] allNetworkNodeIds; // 0x10
			public int idx; // 0x18
			public Predicate<int> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetNonBypassedNetworkIds_b__0(int id); // 0x0000000189D94634-0x0000000189D94664
		}
	
		// Constructors
		public HEU_PDGSession(); // 0x0000000189D90040-0x0000000189D90190
	
		// Methods
		public static HEU_PDGSession GetPDGSession(); // 0x0000000189D8FC38-0x0000000189D8FCC8
		public void AddAsset(HEU_PDGAssetLink asset); // 0x00000001841E1670-0x00000001841E1680
		public void RemoveAsset(HEU_PDGAssetLink asset); // 0x00000001841E1670-0x00000001841E1680
		private void Update(); // 0x00000001841E1670-0x00000001841E1680
		private void CleanUp(); // 0x0000000189D8FA00-0x0000000189D8FAC8
		private void UpdatePDGContext(); // 0x00000001841E1670-0x00000001841E1680
		public void ReinitializePDGContext(); // 0x00000001841E1670-0x00000001841E1680
		private void ProcessPDGEvent(HEU_SessionBase session, int contextID, ref HAPI_PDG_EventInfo eventInfo); // 0x00000001841E1670-0x00000001841E1680
		private void OnWorkItemLoadResults(HEU_TOPNodeData topNode, HEU_SyncedEventData OnSynced); // 0x0000000189D8FF90-0x0000000189D8FF9C
		private void CheckCallback(HEU_TOPNodeData topNode); // 0x0000000189D8F94C-0x0000000189D8FA00
		private bool GetTOPAssetLinkAndNode(int nodeID, out HEU_PDGAssetLink assetLink, out HEU_TOPNodeData topNode); // 0x0000000189D8FCC8-0x0000000189D8FDCC
		private void SetTOPNodePDGState(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, HEU_TOPNodeData.PDGState pdgState); // 0x0000000189D8FFE4-0x0000000189D90040
		private void NotifyTOPNodePDGStateClear(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode); // 0x0000000189D8FE90-0x0000000189D8FED0
		private void NotifyTOPNodeTotalWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x0000000189D8FF10-0x0000000189D8FF50
		private void NotifyTOPNodeCookedWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode); // 0x0000000189D8FDE8-0x0000000189D8FE1C
		private void NotifyTOPNodeErrorWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode); // 0x0000000189D8FE5C-0x0000000189D8FE90
		private void NotifyTOPNodeWaitingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x0000000189D8FF50-0x0000000189D8FF90
		private void NotifyTOPNodeScheduledWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x0000000189D8FED0-0x0000000189D8FF10
		private void NotifyTOPNodeCookingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x0000000189D8FE1C-0x0000000189D8FE5C
		private static void ResetPDGEventInfo(ref HAPI_PDG_EventInfo eventInfo); // 0x0000000184DA2A40-0x0000000184DA2A60
		private void SetErrorState(string msg, bool bLogIt); // 0x0000000189D8FF9C-0x0000000189D8FFE4
		private void ClearErrorState(); // 0x0000000189D8FAC8-0x0000000189D8FB0C
		public HEU_SessionBase GetHAPIPDGSession(bool bCreate = true /* Metadata: 0x023333A1 */); // 0x0000000189D8FB54-0x0000000189D8FBA4
		public void CookTOPNetworkOutputNode(HEU_TOPNetworkData topNetwork, Action<HEU_PDGCookedEventData> OnCook = null); // 0x00000001841E1670-0x00000001841E1680
		public void PauseCook(HEU_TOPNetworkData topNetwork); // 0x00000001841E1670-0x00000001841E1680
		public void CancelCook(HEU_TOPNetworkData topNetwork); // 0x00000001841E1670-0x00000001841E1680
		public void ClearWorkItemResult(HEU_SessionBase session, int contextID, HAPI_PDG_EventInfo eventInfo, HEU_TOPNodeData topNode); // 0x00000001841E1670-0x00000001841E1680
		public bool DirtyTOPNode(int nodeID); // 0x00000001812081B0-0x0000000181208610
		public bool CookTOPNode(int nodeID); // 0x00000001812081B0-0x0000000181208610
		public bool DirtyAll(int nodeID); // 0x00000001812081B0-0x0000000181208610
		public void AddEventMessage(string msg); // 0x0000000189D8F92C-0x0000000189D8F94C
		public string GetEventMessages(); // 0x0000000189D8FB30-0x0000000189D8FB54
		public void ClearEventMessages(); // 0x0000000189D8FB0C-0x0000000189D8FB30
		public static int[] GetNonBypassedNetworkIds(HEU_SessionBase session, int assetId); // 0x0000000189D8FBA4-0x0000000189D8FC38
		public static bool IsPDGAsset(HEU_SessionBase session, int assetId); // 0x0000000189D8FDCC-0x0000000189D8FDE8
		private void ResetCallbackVariables(); // 0x0000000184DA2A30-0x0000000184DA2A40
	}

	public interface IHEU_Curve // TypeDefIndex: 53116
	{
		// Properties
		GameObject TargetGameObject { get; set; }
		int GeoID { get; }
		int PartID { get; }
		List<CurveNodeData> CurveNodeData { get; }
		HEU_Parameters Parameters { get; }
		string CurveName { get; }
		bool IsInputCurve { get; }
		bool IsPartCurve { get; }
		HEU_InputCurveInfo InputCurveInfo { get; }
	
		// Methods
		bool IsEditable();
		bool IsGeoCurve();
		void SetCurveName(string name);
		void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x023333A5 */);
		void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x023333A6 */);
		void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x023333A7 */);
		Vector3 GetCurvePoint(int pointIndex);
		List<CurveNodeData> GetAllPointTransforms();
		List<Vector3> GetAllPoints();
		int GetNumPoints();
		void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x023333A8 */);
		void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x023333A9 */);
		void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x023333AA */);
		void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x023333AB */);
		void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x023333AC */);
		void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x023333AD */);
		void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x023333AE */);
		void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x023333AF */);
		Vector3 GetTransformedPoint(int pointIndex);
		List<Vector3> GetTransformedPoints();
		List<CurveNodeData> DuplicateCurveNodeData();
	}

	public interface IHEU_GeoNode // TypeDefIndex: 53117
	{
		// Properties
		int GeoID { get; }
		HAPI_GeoInfo GeoInfo { get; }
		string GeoName { get; }
		HAPI_GeoType GeoType { get; }
		bool Editable { get; }
		bool Displayable { get; }
		List<HEU_PartData> Parts { get; }
		HEU_ObjectNode ObjectNode { get; }
		HEU_InputNode InputNode { get; }
		HEU_Curve GeoCurve { get; }
		List<HEU_VolumeCache> VolumeCaches { get; }
	
		// Methods
		bool IsVisible();
		bool IsIntermediate();
		bool IsIntermediateOrEditable();
		bool IsGeoInputType();
		bool IsGeoCurveType();
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x023333B0 */);
		void RemoveAndDestroyPart(HEU_PartData part);
		void GetOutputGameObjects(List<GameObject> outputObjects);
		void GetOutput(List<HEU_GeneratedOutput> outputs);
		HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject);
		HEU_PartData GetPartFromPartID(int partID);
		void GetCurves(List<HEU_Curve> curves, bool bEditableOnly);
		List<HEU_PartData> GetParts();
		void HideAllGeometry();
		void DisableAllColliders();
		HEU_VolumeCache GetVolumeCacheByTileIndex(int tileIndex);
	}

	public enum HEU_AssetCookStatusWrapper // TypeDefIndex: 53118
	{
		NONE = 0,
		COOKING = 1,
		POSTCOOK = 2,
		LOADING = 3,
		POSTLOAD = 4,
		PRELOAD = 5,
		SELECT_SUBASSET = 6
	}

	public enum HEU_AssetCookResultWrapper // TypeDefIndex: 53119
	{
		NONE = 0,
		SUCCESS = 1,
		ERRORED = 2
	}

	public enum HEU_CurveDrawCollisionWrapper // TypeDefIndex: 53120
	{
		INVALID = 0,
		COLLIDERS = 1,
		LAYERMASK = 2
	}

	public enum HEU_AssetTypeWrapper // TypeDefIndex: 53121
	{
		TYPE_INVALID = 0,
		TYPE_HDA = 1,
		TYPE_CURVE = 2,
		TYPE_INPUT = 3
	}

	public interface IHEU_HoudiniAsset // TypeDefIndex: 53122
	{
		// Properties
		bool LoadAssetFromMemory { get; set; }
		bool AlwaysOverwriteOnLoad { get; set; }
		bool GenerateUVs { get; set; }
		bool GenerateTangents { get; set; }
		bool GenerateNormals { get; set; }
		bool PushTransformToHoudini { get; set; }
		bool TransformChangeTriggersCooks { get; set; }
		bool CookingTriggersDownCooks { get; set; }
		bool AutoCookOnParameterChange { get; set; }
		bool IgnoreNonDisplayNodes { get; set; }
		bool UseOutputNodes { get; set; }
		bool GenerateMeshUsingPoints { get; set; }
		bool UseLODGroups { get; set; }
		bool SplitGeosByGroup { get; set; }
		bool SessionSyncAutoCook { get; set; }
		bool BakeUpdateKeepPreviousTransformValues { get; set; }
		bool PauseCooking { get; set; }
		bool CurveEditorEnabled { get; set; }
		HEU_CurveDrawCollisionWrapper CurveDrawCollision { get; set; }
		LayerMask CurveDrawLayerMask { get; set; }
		float CurveProjectMaxDistance { get; set; }
		Vector3 CurveProjectDirection { get; set; }
		bool CurveProjectDirectionToView { get; set; }
		bool CurveDisableScaleRotation { get; set; }
		bool CurveFrameSelectedNodes { get; set; }
		float CurveFrameSelectedNodeDistance { get; set; }
		bool HandlesEnabled { get; set; }
		bool EditableNodesToolsEnabled { get; set; }
		HEU_AssetTypeWrapper AssetType { get; }
		HAPI_AssetInfo AssetInfo { get; }
		HAPI_NodeInfo NodeInfo { get; }
		string AssetName { get; }
		string AssetOpName { get; }
		string AssetHelp { get; }
		int AssetID { get; }
		string AssetPath { get; }
		GameObject OwnerGameObject { get; }
		GameObject RootGameObject { get; }
		List<HEU_MaterialData> MaterialCache { get; }
		HEU_Parameters Parameters { get; }
		string AssetCacheFolder { get; }
		string[] SubassetNames { get; }
		int SelectedSubassetIndex { get; }
		HEU_AssetCookStatusWrapper CookStatus { get; }
		HEU_AssetCookResultWrapper LastCookResult { get; }
		long SessionID { get; }
		List<HEU_Curve> Curves { get; }
		List<HEU_InputNode> InputNodes { get; }
		List<HEU_VolumeCache> VolumeCaches { get; }
		HEU_ReloadDataEvent ReloadDataEvent { get; }
		HEU_CookedDataEvent CookedDataEvent { get; }
		HEU_BakedDataEvent BakedDataEvent { get; }
		HEU_PreAssetEvent PreAssetEvent { get; }
	
		// Methods
		bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x023333C2 */, bool bAsync = false /* Metadata: 0x023333C3 */, bool bSkipCookCheck = true /* Metadata: 0x023333C4 */, bool bUploadParameters = true /* Metadata: 0x023333C5 */);
		bool RequestReload(bool bAsync = false /* Metadata: 0x023333C6 */);
		bool RequestResetParameters(bool bAsync = false /* Metadata: 0x023333C7 */);
		GameObject DuplicateAsset(GameObject newRootGameObject = null);
		bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x023333C8 */);
		GameObject BakeToNewPrefab(string destinationPrefabPath = null);
		GameObject BakeToNewStandalone();
		bool BakeToExistingPrefab(GameObject bakeTargetGO);
		bool BakeToExistingStandalone(GameObject bakeTargetGO);
		bool IsAssetValid();
		bool GetOutputGameObjects(List<GameObject> outputObjects);
		bool GetOutput(List<HEU_GeneratedOutput> outputs);
		HEU_Curve GetCurve(string curveName);
		bool AddCurveDrawCollider(Collider newCollider);
		bool RemoveCurveDrawCollider(Collider collider);
		bool ClearCurveDrawColliders();
		HEU_InputNode GetInputNode(string inputName);
		HEU_InputNode GetAssetInputNode(string inputName);
		HEU_InputNode GetInputNodeByIndex(int index);
		List<HEU_InputNode> GetNonParameterInputNodes();
		int GetVolumeCacheCount();
		HEU_SessionBase GetAssetSession(bool bCreateIfInvalid);
		HEU_ObjectNode GetObjectNodeByName(string objName);
		void GetOutputGeoNodes(List<HEU_GeoNode> outputGeoNodes);
		HEU_PartData GetInternalHDAPartWithGameObject(GameObject outputGameObject);
		void ResetParametersToDefault();
		void HideAllGeometry();
		void DisableAllColliders();
		HEU_MaterialData GetMaterialData(Material material);
		void ClearMaterialCache();
		void RemoveMaterial(Material material);
		void ResetMaterialOverrides();
		HEU_AssetPreset GetAssetPreset(bool sceneRelativeObjects);
		HEU_PDGAssetLink GetOrCreatePDGAssetLink();
	}

	public interface IHEU_HoudiniAssetSubcomponent // TypeDefIndex: 53123
	{
		// Properties
		HEU_HoudiniAsset ParentAsset { get; }
	
		// Methods
		HEU_SessionBase GetSession();
		void Recook();
	}

	public enum HEU_InputNodeTypeWrapper // TypeDefIndex: 53124
	{
		CONNECTION = 0,
		NODE = 1,
		PARAMETER = 2
	}

	public enum HEU_InputObjectTypeWrapper // TypeDefIndex: 53125
	{
		HDA = 0,
		UNITY_MESH = 1,
		CURVE = 2,
		TERRAIN = 3,
		BOUNDING_BOX = 4,
		TILEMAP = 5
	}

	public interface IHEU_InputNode // TypeDefIndex: 53126
	{
		// Properties
		bool KeepWorldTransform { get; set; }
		bool PackGeometryBeforeMerging { get; set; }
		HEU_InputNodeTypeWrapper NodeType { get; }
		HEU_InputObjectTypeWrapper ObjectType { get; }
		HEU_InputObjectTypeWrapper PendingObjectType { get; }
		int InputNodeID { get; }
		string InputName { get; }
		string LabelName { get; }
		string ParamName { get; }
		HEU_InputInterfaceMeshSettings MeshSettings { get; }
		HEU_InputInterfaceTilemapSettings TilemapSettings { get; }
		HEU_InputInterfaceSplineSettings SplineSettings { get; }
	
		// Methods
		bool IsAssetInput();
		int NumInputEntries();
		GameObject GetInputEntryGameObject(int index);
		GameObject[] GetInputEntryGameObjects();
		void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x023333D2 */);
		void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x023333D3 */);
		void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x023333D4 */);
		void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x023333D5 */);
		void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x023333D6 */);
		void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x023333D7 */);
		void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x023333D8 */);
		void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x023333D9 */);
		void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x023333DA */);
		void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x023333DB */);
		void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x023333DC */);
		bool AreAnyInputHDAsConnected();
		int GetConnectedInputCount();
		int GetConnectedNodeID(int index);
		void LoadPreset(HEU_InputPreset inputPreset);
		void PopulateInputPreset(HEU_InputPreset inputPreset, bool sceneRelativeGameObjects);
	}

	public enum HEU_MaterialSourceWrapper // TypeDefIndex: 53127
	{
		DEFAULT = 0,
		HOUDINI = 1,
		UNITY = 2,
		SUBSTANCE = 3
	}

	public interface IHEU_MaterialData // TypeDefIndex: 53128
	{
		// Properties
		Material Material { get; }
		HEU_MaterialSourceWrapper MaterialSource { get; }
		int MaterialKey { get; set; }
	
		// Methods
		bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath);
		bool IsExistingMaterial();
	}

	public interface IHEU_ObjectNode // TypeDefIndex: 53129
	{
		// Properties
		int ObjectID { get; }
		string ObjectName { get; }
		HAPI_ObjectInfo ObjectInfo { get; }
		List<HEU_GeoNode> GeoNodes { get; }
		HAPI_Transform ObjectTransform { get; }
	
		// Methods
		bool IsInstanced();
		bool IsVisible();
		bool IsUsingMaterial(HEU_MaterialData materialData);
		void GetOutputGameObjects(List<GameObject> outputObjects);
		void GetOutput(List<HEU_GeneratedOutput> outputs);
		HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject);
		HEU_GeoNode GetGeoNode(string geoName);
		void GetCurves(List<HEU_Curve> curves, bool bEditableOnly);
		void GetOutputGeoNodes(List<HEU_GeoNode> outGeoNodes);
		void HideAllGeometry();
		void DisableAllColliders();
		bool IsInstancer();
	}

	public enum HEU_HoudiniRampInterpolationTypeWrapper // TypeDefIndex: 53130
	{
		CONSTANT = 0,
		LINEAR = 1,
		CATMULL_ROM = 2
	}

	public class HEU_RampPointWrapper // TypeDefIndex: 53131
	{
		// Fields
		[CompilerGenerated]
		private float _Position_k__BackingField; // 0x10
		[CompilerGenerated]
		private HEU_HoudiniRampInterpolationTypeWrapper _Interpolation_k__BackingField; // 0x14
	
		// Properties
		public float Position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
		public HEU_HoudiniRampInterpolationTypeWrapper Interpolation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
	
		// Constructors
		public HEU_RampPointWrapper(float position = 0f /* Metadata: 0x023333E4 */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x023333E8 */); // 0x0000000184DA2A60-0x0000000184DA2A70
	}

	public class HEU_FloatRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 53132
	{
		// Fields
		[CompilerGenerated]
		private float _Value_k__BackingField; // 0x18
	
		// Properties
		public float Value { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
	
		// Constructors
		public HEU_FloatRampPointWrapper(float position = 0f /* Metadata: 0x023333E9 */, float value = 0f /* Metadata: 0x023333ED */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x023333F1 */); // 0x0000000184DA2A20-0x0000000184DA2A30
	}

	public class HEU_ColorRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 53133
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.Color _Value_k__BackingField; // 0x18
	
		// Properties
		public UnityEngine.Color Value { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
	
		// Constructors
		public HEU_ColorRampPointWrapper(float position = 0f /* Metadata: 0x023333F2 */, UnityEngine.Color value = default, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x023333F6 */); // 0x0000000184DA2A00-0x0000000184DA2A20
	}

	public class HEU_ParameterTupleWrapper // TypeDefIndex: 53134
	{
		// Fields
		internal bool[] _boolValues; // 0x10
		internal int[] _intValues; // 0x18
		internal float[] _floatValues; // 0x20
		internal string[] _stringValues; // 0x28
		internal HEU_FloatRampPointWrapper[] _floatRampValues; // 0x30
		internal HEU_ColorRampPointWrapper[] _colorRampValues; // 0x38
	
		// Properties
		public bool[] BoolValues { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public int[] IntValues { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float[] FloatValues { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string[] StringValues { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public HEU_FloatRampPointWrapper[] FloatRampValues { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public HEU_ColorRampPointWrapper[] ColorRampValues { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
	
		// Constructors
		public HEU_ParameterTupleWrapper(); // 0x00000001841E1670-0x00000001841E1680
		public HEU_ParameterTupleWrapper(bool[] boolValues); // 0x00000001853908C0-0x00000001853908D0
		public HEU_ParameterTupleWrapper(int[] intValues); // 0x0000000185392C40-0x0000000185392C50
		public HEU_ParameterTupleWrapper(float[] floatValues); // 0x0000000185390F40-0x0000000185390F50
		public HEU_ParameterTupleWrapper(string[] stringValues); // 0x0000000182FDB880-0x0000000182FDB890
		public HEU_ParameterTupleWrapper(HEU_FloatRampPointWrapper[] floatRampValues); // 0x0000000185396200-0x0000000185396210
		public HEU_ParameterTupleWrapper(HEU_ColorRampPointWrapper[] colorRampValues); // 0x00000001846A91B0-0x00000001846A91C0
	}

	public interface IHEU_Parameters // TypeDefIndex: 53135
	{
		// Properties
		bool ShowParameters { get; set; }
		int NodeID { get; }
		List<int> RootParameters { get; }
		List<HEU_ParameterModifier> ParameterModifiers { get; }
	
		// Methods
		bool AreParametersValid();
		List<HEU_ParameterData> GetParameters();
		HEU_ParameterData GetParameter(int listIndex);
		HEU_ParameterData GetParameter(string name);
		HEU_ParameterData GetParameterWithParmID(int parmID);
		void RemoveParameter(int listIndex);
		bool HaveParametersChanged();
		bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x023333F7 */);
		bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x023333F8 */, bool bRecookAsset = false /* Metadata: 0x023333F9 */);
		bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x023333FA */);
		bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x023333FB */);
		bool GetFloatParameterValues(string parameterName, out float[] values);
		bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x023333FC */);
		bool GetColorParameterValue(string parameterName, out UnityEngine.Color value);
		bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x023333FD */, bool bRecookAsset = false /* Metadata: 0x023333FE */);
		bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x023333FF */);
		bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x02333400 */);
		bool GetIntParameterValues(string parameterName, out int[] values);
		bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x02333401 */);
		bool GetChoiceParameterValue(string parameterName, out int value);
		bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x02333402 */, bool bRecookAsset = false /* Metadata: 0x02333403 */);
		bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x02333404 */);
		bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x02333405 */, bool bRecookAsset = false /* Metadata: 0x02333406 */);
		bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x02333407 */);
		bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x02333408 */);
		bool GetStringParameterValues(string parameterName, out string[] values);
		bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x02333409 */, bool bRecookAsset = false /* Metadata: 0x0233340A */);
		bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x0233340B */);
		bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x0233340C */);
		bool GetAssetRefParameterValues(string parameterName, out GameObject[] values);
		bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x0233340D */);
		bool GetRampParameterNumPoints(string parameterName, out int numPoints);
		bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0233340E */, bool bRecookAsset = false /* Metadata: 0x0233340F */);
		bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x02333410 */);
		bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints);
		bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x02333411 */, bool bRecookAsset = false /* Metadata: 0x02333412 */);
		bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x02333413 */);
		bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints);
		bool TriggerButtonParameter(string parameterName);
		bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecookAsset = false /* Metadata: 0x02333414 */);
		bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples);
	}

	public interface IHEU_PartData // TypeDefIndex: 53136
	{
		// Properties
		int PartID { get; }
		string PartName { get; }
		int GeoID { get; }
		HAPI_PartType PartType { get; }
		HEU_GeoNode ParentGeoNode { get; }
		List<HEU_ObjectInstanceInfo> ObjectInstanceInfos { get; }
		HEU_Curve Curve { get; }
		int MeshVertexCount { get; }
		HEU_GeneratedOutput GeneratedOutput { get; }
		GameObject OutputGameObject { get; }
	
		// Methods
		bool IsPartInstancer();
		bool IsAttribInstancer();
		bool IsInstancerAnyType();
		bool IsPartInstanced();
		int GetPartPointCount();
		bool IsObjectInstancer();
		bool IsPartVolume();
		bool IsPartCurve();
		bool IsPartMesh();
		bool IsPartEditable();
		bool HaveInstancesBeenGenerated();
		void SetGameObjectName(string partName);
		void SetGameObject(GameObject gameObject);
		void SetVolumeLayerName(string name);
		string GetVolumeLayerName();
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02333415 */);
		bool IsUsingMaterial(HEU_MaterialData materialData);
		void GetOutputGameObjects(List<GameObject> outputObjects);
		void GetOutput(List<HEU_GeneratedOutput> outputs);
		HEU_PartData GetHDAPartWithGameObject(GameObject inGameObject);
		void ClearInstances();
		HEU_Curve GetCurve(bool bEditableOnly);
		void SetVisiblity(bool bVisibility);
		void SetColliderState(bool bEnabled);
		HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(string path);
		HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(int objNodeID);
		void SetTerrainOffsetPosition(Vector3 offsetPosition);
		void SetTerrainData(TerrainData terrainData, string exportPathRelative, string exportPathUser);
	}

	public enum HEU_LinkStateWrapper // TypeDefIndex: 53137
	{
		INACTIVE = 0,
		LINKING = 1,
		LINKED = 2,
		ERROR_NOT_LINKED = 3
	}

	public interface IHEU_PDGAssetLink // TypeDefIndex: 53138
	{
		// Properties
		bool AutoCook { get; set; }
		bool UseHEngineData { get; set; }
		bool UseTOPNodeFilter { get; set; }
		bool UseTOPOutputFilter { get; set; }
		string TopNodeFilter { get; set; }
		string TopOutputFilter { get; set; }
		HEU_HoudiniAsset ParentAsset { get; }
		string AssetPath { get; }
		GameObject AssetGO { get; }
		string AssetName { get; }
		int AssetID { get; }
		List<HEU_TOPNetworkData> TopNetworks { get; }
		string[] TopNetworkNames { get; }
		int SelectedTOPNetwork { get; }
		HEU_LinkStateWrapper PDGLinkState { get; }
		GameObject LoadRootGameObject { get; }
		string OutputCachePathRoot { get; }
	
		// Methods
		void Setup(HEU_HoudiniAsset hdaAsset);
		void Reset();
		void Refresh();
		List<KeyValuePair<int, HEU_TOPNodeData>> GetNonHiddenTOPNodes(HEU_TOPNetworkData topNetwork);
		void SelectTOPNetwork(int newIndex);
		void SelectTOPNode(HEU_TOPNetworkData network, int newIndex);
		HEU_TOPNetworkData GetSelectedTOPNetwork();
		HEU_TOPNodeData GetSelectedTOPNode();
		HEU_TOPNetworkData GetTOPNetwork(int index);
		void DirtyTOPNode(HEU_TOPNodeData topNode);
		void CookTOPNode(HEU_TOPNodeData topNode);
		void DirtyAll();
		void CookOutput();
		void PauseCook();
		void CancelCook();
		HEU_SessionBase GetHAPISession();
		HEU_TOPNodeData GetTOPNode(int nodeID);
		string GetTOPNodeStatus(HEU_TOPNodeData topNode);
	}

	public interface IHEU_VolumeCache // TypeDefIndex: 53139
	{
		// Properties
		List<HEU_VolumeLayer> Layers { get; }
		int TileIndex { get; }
		string ObjectName { get; }
		string GeoName { get; }
		TerrainData TerrainData { get; }
		HEU_VolumeScatterTrees ScatterTrees { get; }
		HEU_DetailProperties DetailProperties { get; }
	
		// Methods
		void ResetParameters();
		HEU_VolumeLayer GetLayer(string layerName);
		void PopulatePreset(HEU_VolumeCachePreset cachePreset);
		bool ApplyPreset(HEU_VolumeCachePreset volumeCachePreset);
	}

	public class HEU_MaterialData : ScriptableObject, IHEU_MaterialData, IEquivable<HEU_MaterialData> // TypeDefIndex: 53141
	{
		// Fields
		[SerializeField]
		internal Material _material; // 0x18
		[SerializeField]
		internal Source _materialSource; // 0x20
		[SerializeField]
		internal int _materialKey; // 0x24
	
		// Properties
		public Material Material { get; } // 0x000000018385B100-0x000000018385B110 
		public HEU_MaterialSourceWrapper MaterialSource { get; } // 0x0000000189D8ACD8-0x0000000189D8AD04 
		public int MaterialKey { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
	
		// Nested types
		internal enum Source // TypeDefIndex: 53140
		{
			DEFAULT = 0,
			HOUDINI = 1,
			UNITY = 2,
			SUBSTANCE = 3
		}
	
		// Constructors
		public HEU_MaterialData(); // 0x0000000189D8ACC8-0x0000000189D8ACD8
	
		// Methods
		public bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath); // 0x0000000189D8A2E0-0x0000000189D8A5E8
		public bool IsExistingMaterial(); // 0x0000000189D8A288-0x0000000189D8A29C
		private bool UseLegacyShaders(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath, HEU_SessionBase session, HAPI_NodeInfo nodeInfo, HAPI_ParmInfo[] parmInfos); // 0x0000000189D8A5E8-0x0000000189D8ACC8
		internal static string GetTextureFileNameFromMaterialParam(HEU_SessionBase session, int nodeID, HAPI_ParmInfo parmInfo); // 0x0000000189D89FE8-0x0000000189D8A0EC
		internal static bool IsTransparentMaterial(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters); // 0x0000000189D8A29C-0x0000000189D8A2E0
		internal static bool GetMaterialAlpha(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, float defaultValue, out float alpha); // 0x0000000189D89D74-0x0000000189D89EE8
		internal static string GetSupportedFileFormat(HEU_SessionBase session, ref HAPI_ImageInfo imageInfo); // 0x0000000189D89EE8-0x0000000189D89FE8
		public bool IsEquivalentTo(HEU_MaterialData other); // 0x0000000189D8A0EC-0x0000000189D8A288
		internal static Source MaterialSource_WrapperToInternal(HEU_MaterialSourceWrapper materialSource); // 0x0000000189D43A04-0x0000000189D43A2C
		internal static HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(Source materialSource); // 0x0000000189D43A04-0x0000000189D43A2C
	}

	public class HEU_MaterialFactory // TypeDefIndex: 53142
	{
		// Fields
		public static Material _defaultStandardMaterial; // 0x00
	
		// Constructors
		public HEU_MaterialFactory(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static Shader FindShader(string shaderName); // 0x0000000189D8B57C-0x0000000189D8B5B4
		public static Shader FindPluginShader(string shaderName); // 0x0000000189D8B544-0x0000000189D8B57C
		public static Material GetNewMaterialWithShader(string assetCacheFolderPath, string shaderName, string materialName = "" /* Metadata: 0x0233341E */, bool bWriteToFile = true /* Metadata: 0x0233341F */); // 0x0000000189D8B9E8-0x0000000189D8BBB8
		public static Material CreateNewHoudiniStandardMaterial(string assetCacheFolderPath, string materialName, bool bWriteToFile); // 0x0000000189D8B058-0x0000000189D8B0A4
		public static void WriteMaterialToAssetCache(Material material, string assetCacheFolderPath, string materialName, bool bOverwriteExisting); // 0x0000000189D8C5B0-0x0000000189D8C688
		public static bool DoesMaterialExistInAssetCache(Material material); // 0x0000000189D8B3B8-0x0000000189D8B3DC
		public static void DestroyNonAssetMaterial(Material material, bool bRegisterUndo); // 0x0000000189D8B344-0x0000000189D8B3B8
		public static void DeleteAssetMaterial(Material material); // 0x0000000189D8B33C-0x0000000189D8B344
		public static Texture2D RenderAndExtractImageToTexture(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, int textureParmID, string textureName, string assetCacheFolderPath, bool isNormalMap, bool invertTexture = false /* Metadata: 0x02333420 */); // 0x0000000189D8C4E8-0x0000000189D8C5A8
		private static Texture2D ExtractHoudiniImageToTexturePNGJPEG(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes); // 0x0000000189D8B480-0x0000000189D8B4DC
		private static Texture2D ExtractHoudiniImageToTextureRaw(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes); // 0x0000000189D8B4DC-0x0000000189D8B544
		public static Texture2D ExtractHoudiniImageToTextureFile(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes, string assetCacheFolderPath); // 0x0000000189D8B3FC-0x0000000189D8B480
		public static Material LoadUnityMaterial(string materialPath); // 0x0000000189D8C1E0-0x0000000189D8C4CC
		public static Material LoadSubstanceMaterialWithName(string materialPath, string substanceName); // 0x0000000189D8BF4C-0x0000000189D8C0D8
		public static Material LoadSubstanceMaterialWithIndex(string materialPath, int substanceMaterialIndex); // 0x0000000189D8BD84-0x0000000189D8BF4C
		public static int GetUnitySubstanceMaterialKey(string unityMaterialPath, string substanceName, int substanceIndex); // 0x0000000189D8BC88-0x0000000189D8BD84
		public static int MaterialNameToKey(string materialName); // 0x00000001853E31AC-0x00000001853E31CC
		public static void EnableGPUInstancing(Material material); // 0x0000000189D8B3DC-0x0000000189D8B3FC
		public static bool MaterialHasGPUInstancingEnabled(Material material); // 0x0000000189D8C4CC-0x0000000189D8C4E8
		public static Material CopyMaterial(Material material); // 0x0000000189D8AD04-0x0000000189D8AD64
		public static Material GetDefaultStandardMaterial(); // 0x0000000189D8B650-0x0000000189D8B700
		public static Texture2D LoadTexture(string path); // 0x0000000189D8C0D8-0x0000000189D8C1E0
		public static Texture2D WhiteTexture(); // 0x0000000189D8C5A8-0x0000000189D8C5B0
		public static HEU_MaterialData CreateUnitySubstanceMaterialData(int materialKey, string materialPath, string substanceName, int substanceIndex, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x0000000189D8B0A4-0x0000000189D8B33C
		public static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialSourceWrapper sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x0000000189D8AEF0-0x0000000189D8AF4C
		internal static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialData.Source sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x0000000189D8AF4C-0x0000000189D8B058
		public static HEU_MaterialData GetOrCreateDefaultMaterialInCache(HEU_SessionBase session, int geoID, int partID, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x0000000189D8BBB8-0x0000000189D8BC88
		public static HEU_MaterialData GetMaterialDataFromCache(int materialKey, List<HEU_MaterialData> materialCache); // 0x0000000189D8B700-0x0000000189D8B81C
		public static string GenerateDefaultMaterialName(int geoID, int partID); // 0x0000000189D8B5B4-0x0000000189D8B650
		public static HEU_MaterialData CreateHoudiniMaterialData(HEU_SessionBase session, int assetID, int materialID, int geoID, int partID, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x0000000189D8AD64-0x0000000189D8AEF0
		public static Dictionary<int, HEU_MaterialData> GetMaterialDataMapFromCache(List<HEU_MaterialData> materialCache); // 0x0000000189D8B81C-0x0000000189D8B9E8
	}

	public class HEU_UnityMaterialInfo // TypeDefIndex: 53143
	{
		// Fields
		public string _unityMaterialPath; // 0x10
		public string _substancePath; // 0x18
		public int _substanceIndex; // 0x20
	
		// Constructors
		public HEU_UnityMaterialInfo(string unityMaterialPath, string substancePath, int substanceIndex); // 0x00000001847E1B40-0x00000001847E1B70
	}

	public class HEU_SessionBase // TypeDefIndex: 53144
	{
		// Fields
		protected HEU_SessionData _sessionData; // 0x10
		[CompilerGenerated]
		private bool _UserNotifiedSessionInvalid_k__BackingField; // 0x18
		private string _sessionErrorMsg; // 0x20
		[CompilerGenerated]
		private bool _LogErrorOverride_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _ThrowErrorOverride_k__BackingField; // 0x29
		[CompilerGenerated]
		private HAPI_Result _LastCallResultCode_k__BackingField; // 0x2C
	
		// Properties
		public bool UserNotifiedSessionInvalid { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public SessionConnectionState ConnectionState { get; set; } // 0x0000000189D915EC-0x0000000189D91600 0x0000000189D91614-0x0000000189D91624
		public SessionMode ThisSessionMode { get; set; } // 0x0000000189D91600-0x0000000189D91614 0x0000000189D91624-0x0000000189D91634
		public bool LogErrorOverride { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public bool ThrowErrorOverride { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		public HAPI_Result LastCallResultCode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
	
		// Constructors
		public HEU_SessionBase(); // 0x0000000184DA2BA0-0x0000000184DA2BB0
	
		// Methods
		public string GetSessionErrorMsg(); // 0x0000000184D862C0-0x0000000184D862D0
		public bool IsSessionSync(); // 0x0000000189D9131C-0x0000000189D91334
		public virtual HEU_HoudiniAsset GetRegisteredAssetFromID(int id); // 0x00000001811EC580-0x00000001811EC590
		public virtual bool IsAssetRegistered(HEU_HoudiniAsset asset); // 0x00000001812081B0-0x0000000181208610
		public virtual void RegisterAsset(HEU_HoudiniAsset asset); // 0x00000001841E1670-0x00000001841E1680
		public virtual void UnregisterAsset(int id); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ReregisterOnAwake(HEU_HoudiniAsset asset); // 0x00000001841E1670-0x00000001841E1680
		public virtual void SetSessionErrorMsg(string msg, bool bLogError = false /* Metadata: 0x02333421 */); // 0x0000000189D9157C-0x0000000189D915B4
		public virtual void SetSessionConnectionErrorMsg(string introMsg, HAPI_Result result, bool bIsHARSRunning, bool bLogError = false /* Metadata: 0x02333422 */); // 0x0000000189D913C0-0x0000000189D9157C
		public virtual void SetLibraryErrorMsg(bool bLogError = false /* Metadata: 0x02333423 */); // 0x0000000189D91334-0x0000000189D913C0
		protected virtual bool CreateSessionData(bool bOverwriteExisting, bool bIsDefaultSession); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CreateInProcessSession(bool bIsDefaultSession); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CreateThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x02333424 */, int serverPort = 9090 /* Metadata: 0x0233342E */, bool autoClose = true /* Metadata: 0x02333432 */, float timeout = 100000f /* Metadata: 0x02333433 */, bool bLogError = true /* Metadata: 0x02333437 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CreateThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x02333438 */, bool autoClose = true /* Metadata: 0x0233343D */, float timeout = 100000f /* Metadata: 0x0233343E */, bool bLogError = true /* Metadata: 0x02333442 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CreateThriftSharedMemorySession(bool bIsDefaultSession, string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER /* Metadata: 0x02333443 */, int sharedMemoryBufferSize = 100 /* Metadata: 0x02333444 */, bool autoClose = true /* Metadata: 0x02333446 */, float timeout = 100000f /* Metadata: 0x02333447 */, bool bLogError = true /* Metadata: 0x0233344B */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CreateCustomSession(bool bIsDefaultSession); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ConnectThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x0233344C */, int serverPort = 9090 /* Metadata: 0x02333456 */, bool autoClose = true /* Metadata: 0x0233345A */, float timeout = 100000f /* Metadata: 0x0233345B */, bool logError = true /* Metadata: 0x0233345F */, bool autoInitialize = true /* Metadata: 0x02333460 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ConnectThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x02333461 */, bool autoClose = true /* Metadata: 0x02333466 */, float timeout = 100000f /* Metadata: 0x02333467 */, bool logError = true /* Metadata: 0x0233346B */, bool autoInitialize = true /* Metadata: 0x0233346C */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ConnectThriftSharedMemorySession(bool bIsDefaultSession, string sharedMemoryName = "hapi" /* Metadata: 0x0233346D */, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER /* Metadata: 0x02333472 */, int sharedMemoryBufferSize = 100 /* Metadata: 0x02333473 */, bool autoClose = true /* Metadata: 0x02333475 */, float timeout = 100000f /* Metadata: 0x02333476 */, bool logError = true /* Metadata: 0x0233347A */, bool autoInitialize = true /* Metadata: 0x0233347B */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CloseSession(); // 0x00000001812081B0-0x0000000181208610
		protected virtual bool CheckAndCloseExistingSession(); // 0x00000001812081B0-0x0000000181208610
		protected virtual void ClearSessionInfo(); // 0x0000000189D91154-0x0000000189D9119C
		public void SetSessionData(HEU_SessionData sessionData); // 0x00000001853908C0-0x00000001853908D0
		public HEU_SessionData GetSessionData(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public virtual string GetSessionInfo(); // 0x0000000189D912C4-0x0000000189D912F0
		public virtual bool IsSessionValid(); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RestartSession(); // 0x00000001812081B0-0x0000000181208610
		public string GetLastSessionError(); // 0x0000000184D862C0-0x0000000184D862D0
		public virtual bool CheckVersionMatch(); // 0x00000001812081B0-0x0000000181208610
		public virtual bool InitializeSession(HEU_SessionData sessionData); // 0x00000001812081B0-0x0000000181208610
		public virtual bool HandleStatusResult(HAPI_Result result, string prependMsg, bool bThrowError, bool bLogError); // 0x00000001812081B0-0x0000000181208610
		public virtual void SetServerEnvString(string name, string value); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool GetServerEnvString(string name, out string value); // 0x0000000189D912A8-0x0000000189D912C4
		public virtual bool GetServerEnvVarCount(out int env_count); // 0x0000000184DA2B00-0x0000000184DA2B10
		public virtual bool GetCallResult(out HAPI_Result result); // 0x0000000184DA2B00-0x0000000184DA2B10
		public virtual bool GetCookResult(out HAPI_Result result); // 0x0000000184DA2B00-0x0000000184DA2B10
		public virtual bool GetCookState(out HAPI_State state); // 0x0000000184DA2B00-0x0000000184DA2B10
		public virtual string GetStatusString(HAPI_StatusType statusType, HAPI_StatusVerbosity verbosity); // 0x0000000189D912F0-0x0000000189D9131C
		public virtual string ComposeNodeCookResult(int nodeId, HAPI_StatusVerbosity verbosity); // 0x0000000189D9119C-0x0000000189D911C8
		public virtual int GetEnvInt(HAPI_EnvIntType intType); // 0x00000001811EC580-0x00000001811EC590
		public virtual int GetSessionEnvInt(HAPI_SessionEnvIntType intType, bool bLogError); // 0x00000001811EC580-0x00000001811EC590
		public virtual bool GetString(int stringHandle, ref string resultString, int bufferLength); // 0x00000001812081B0-0x0000000181208610
		public virtual int GetStringBufferLength(int stringHandle); // 0x00000001811EC580-0x00000001811EC590
		public virtual int CheckForSpecificErrors(int nodeID, int errorsToCheck); // 0x00000001811EC580-0x00000001811EC590
		public virtual double GetTime(); // 0x0000000184D879D0-0x0000000184D879E0
		public virtual bool SetTime(double time); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetUseHoudiniTime(); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetUseHoudiniTime(bool enable); // 0x00000001812081B0-0x0000000181208610
		public virtual bool LoadAssetLibraryFromFile(string assetPath, bool bAllowOverwrite, out int libraryID); // 0x0000000184DA2B10-0x0000000184DA2B20
		public virtual bool LoadAssetLibraryFromMemory(byte[] buffer, bool bAllowOverwrite, out int libraryID); // 0x0000000184DA2B10-0x0000000184DA2B20
		public virtual bool CreateNode(int parentNodeID, string operatorName, string nodeLabel, bool bCookOnCreation, out int newNodeID); // 0x0000000184DA2AF0-0x0000000184DA2B00
		public virtual void DeleteNode(int nodeID); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool CookNode(int nodeID, bool bCookTemplatedGeos, bool bSplitGeosByGroup = false /* Metadata: 0x0233347C */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CookNodeWithOptions(int nodeID, HAPI_CookOptions cookOptions); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RenameNode(int nodeID, string newName); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ConnectNodeInput(int nodeID, int inputIndex, int nodeIDToConnect, int outputIndex = 0 /* Metadata: 0x0233347D */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool DisconnectNodeInput(int nodeID, int inputIndex, bool bLogError); // 0x00000001812081B0-0x0000000181208610
		public virtual bool QueryNodeInput(int nodeID, int inputIndex, out int connectedNodeID, bool bLogError); // 0x0000000184DA2B40-0x0000000184DA2B50
		public virtual bool GetNodeInputName(int nodeID, int inputIndex, out int nodeNameIndex); // 0x0000000184DA2B10-0x0000000184DA2B20
		public virtual bool GetAvailableAssetCount(int libraryID, out int assetCount); // 0x0000000184DA2A70-0x0000000184DA2A80
		public virtual bool GetAvailableAssets(int libraryID, ref int[] assetNames, int assetCount); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAssetInfo(int nodeID, ref HAPI_AssetInfo assetInfo, bool bLogError = true /* Metadata: 0x0233347E */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetNodeInfo(int nodeID, ref HAPI_NodeInfo nodeInfo, bool bLogError = true /* Metadata: 0x0233347F */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetNodePath(int nodeID, int relativeNodeID, out string path); // 0x00000001880165E0-0x00000001880165FC
		public virtual bool IsNodeValid(int nodeID, int uniqueNodeID); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ComposeChildNodeList(int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, ref int count, bool bLogError = true /* Metadata: 0x02333480 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetComposedChildNodeList(int parentNodeID, int[] childNodeIDs, int count, bool bLogError = true /* Metadata: 0x02333481 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool LoadHIPFile(string fileName, bool bCookOnLoad); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SaveHIPFile(string fileName, bool bLockNodes); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetObjectInfo(int nodeID, ref HAPI_ObjectInfo objectInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetObjectTransform(int nodeID, int relativeToNodeID, HAPI_RSTOrder rstOrder, ref HAPI_Transform hapiTransform); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetObjectTransform(int nodeID, ref HAPI_TransformEuler hapiTransform); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ComposeObjectList(int nodeID, out int objectCount); // 0x0000000184DA2A70-0x0000000184DA2A80
		public virtual bool GetComposedObjectList(int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetComposedObjectTransforms(int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetDisplayGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = false /* Metadata: 0x02333482 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetOutputGeoCount(int nodeID, out int count, bool bLogError = false /* Metadata: 0x02333483 */); // 0x0000000184DA2A70-0x0000000184DA2A80
		public virtual bool GetOutputGeoInfos(int nodeID, ref HAPI_GeoInfo[] geoInfosArray, int count, bool bLogError = false /* Metadata: 0x02333484 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = true /* Metadata: 0x02333485 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeInfo(int nodeID, int partID, string name, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeNames(int nodeID, int partID, HAPI_AttributeOwner owner, ref string[] attributeNames, int count); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] dataArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out float[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, ref float[] data, int dataLength, ref int[] sizesArray, int start, int sizesLength); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeFloat64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out double[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeUInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out byte[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out sbyte[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out short[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out long[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetGroupNames(int nodeID, HAPI_GroupType groupType, ref int[] names, int count); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetGroupCountOnPackedInstancePart(int nodeID, int partID, out int pointGroupCount, out int primitiveGroupCount); // 0x0000000184DA2B20-0x0000000184DA2B30
		public virtual bool GetGroupNamesOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, ref int[] groupNamesArray, int groupCount); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetGroupMembershipOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetInstancedPartIds(int nodeID, int partID, out int[] instancedPartsArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetInstancerPartTransforms(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetInstanceTransformsOnPart(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetInstancedObjectIds(int nodeID, out int[] instanced_node_id_array, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length, bool bLogError); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetVertexList(int nodeID, int partID, out int[] vertexList, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetBoxInfo(int nodeID, int partID, ref HAPI_BoxInfo boxInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetSphereInfo(int nodeID, int partID, ref HAPI_SphereInfo sphereInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetCurveCounts(int nodeID, int partID, out int[] counts, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetCurveOrders(int nodeID, int partID, out int[] orders, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetCurveKnots(int nodeID, int partID, out float[] knots, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo inputCurveInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetFaceCount(int nodeID, int partID, int[] faceCounts, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetVertexList(int nodeID, int partID, int[] vertexList, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, int[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, sbyte[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, short[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, long[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int dataLength, int[] sizesArray, int start, int sizesLength); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, string[] data, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool AddAttribute(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool AddGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName); // 0x00000001812081B0-0x0000000181208610
		public virtual bool DeleteGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, out int[] membershipArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool CommitGeo(int nodeID); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RevertGeo(int nodeID); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetCurveCounts(int nodeID, int partID, int[] counts, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetCurveOrders(int nodeID, int partID, int[] orders, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetCurveKnots(int nodeID, int partID, float[] knots, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo curveInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetInputCurvePositions(int nodeID, int partID, float[] positionsArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetInputCurvePositionsRotationsScales(int nodeID, int partID, float[] positionsArray, int start, int length, float[] rotationsArray, int rotationsStart, int rotationsLength, float[] scalesArray, int scalesStart, int scalesLength); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetMaterialOnPart(int nodeID, int partID, ref HAPI_MaterialInfo materialInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetMaterialNodeIDsOnFaces(int nodeID, int partID, ref bool bSingleFaceMaterial, out int[] materialNodeIDs, int faceCount); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetMaterialInfo(int materialNodeID, ref HAPI_MaterialInfo materialInfo, bool bLogError = true /* Metadata: 0x02333486 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RenderTextureToImage(int materialNodeID, int parmID, bool bLogError = true /* Metadata: 0x02333487 */); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RenderCOPToImage(int copNodeID); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ExtractImageToMemory(int nodeID, string fileFormat, string imagePlanes, out byte[] buffer); // 0x0000000189D911E4-0x0000000189D91228
		public virtual bool GetImagePlanes(int nodeID, out int[] imagePlanes, int numImagePlanes); // 0x0000000189D91228-0x0000000189D91260
		public virtual bool ExtractImageToFile(int nodeID, string fileFormat, string imagePlanes, string destinationFolderPath, out string destinationFilePath); // 0x0000000189D911C8-0x0000000189D911E4
		public virtual bool GetParams(int nodeID, out HAPI_ParmInfo[] parmInfos, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParmTagName(int nodeID, int parmID, int tagIndex, out int tagName); // 0x0000000184DA2B30-0x0000000184DA2B40
		public virtual bool GetParmTagValue(int nodeID, int parmID, string tagName, out int tagValue); // 0x0000000184DA2B30-0x0000000184DA2B40
		public virtual bool ParmHasTag(int nodeID, int parmID, string tagName, ref bool hasTag); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParamIntValues(int nodeID, out int[] values, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParamIntValue(int nodeID, string parmName, int index, out int value); // 0x0000000184DA2B30-0x0000000184DA2B40
		public virtual bool GetParamFloatValues(int nodeID, out float[] values, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParamFloatValue(int nodeID, string parmName, int index, out float value); // 0x0000000184DA2B30-0x0000000184DA2B40
		public virtual bool GetParamStringValues(int nodeID, out int[] values, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParamStringValue(int nodeID, string parmName, int index, out int value); // 0x0000000184DA2B30-0x0000000184DA2B40
		public virtual bool GetParamNodeValue(int nodeID, string paramName, out int nodeValue); // 0x0000000184DA2B40-0x0000000184DA2B50
		public virtual bool GetParamChoiceValues(int nodeID, out HAPI_ParmChoiceInfo[] values, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamIntValues(int nodeID, ref int[] values, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamIntValue(int nodeID, string paramName, int index, int value); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamFloatValues(int nodeID, ref float[] values, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamFloatValue(int nodeID, string paramName, int index, float value); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamStringValue(int nodeID, string strValue, int parmID, int index); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamStringValue(int nodeID, string parmName, string parmValue, int index); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetParamNodeValue(int nodeID, string paramName, int nodeValueID); // 0x00000001812081B0-0x0000000181208610
		public virtual bool InsertMultiparmInstance(int nodeID, int parmID, int instancePosition); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RemoveMultiParmInstance(int nodeID, int parmID, int instancePosition); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParmWithTag(int nodeID, string tagName, ref int parmID); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RevertParmToDefault(int nodeID, string parm_name, int index); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RevertParmToDefaults(int nodeID, string parm_name); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetParmIDFromName(int nodeID, string parmName, out int parmID); // 0x0000000184DA2B40-0x0000000184DA2B50
		public virtual bool GetParmStringValue(int nodeID, string parmName, int index, bool evaluate, out int value); // 0x0000000184DA2B50-0x0000000184DA2B60
		public virtual bool CreateInputNode(out int nodeID, string name); // 0x0000000184DA2AE0-0x0000000184DA2AF0
		public virtual bool CreateInputCurveNode(out int nodeID, string name); // 0x0000000184DA2AE0-0x0000000184DA2AF0
		public virtual bool CreateHeightFieldInput(int parentNodeID, string name, int xSize, int ySize, float voxelSize, HAPI_HeightFieldSampling sampling, out int heightfieldNodeID, out int heightNodeID, out int maskNodeID, out int mergeNodeID); // 0x0000000184DA2AA0-0x0000000184DA2AD0
		public virtual bool CreateHeightfieldInputVolumeNode(int parentNodeID, out int newNodeID, string name, int xSize, int ySize, float voxelSize); // 0x0000000184DA2AD0-0x0000000184DA2AE0
		public virtual bool GetPreset(int nodeID, out byte[] presetData); // 0x0000000189D91260-0x0000000189D912A8
		public virtual bool SetPreset(int nodeID, byte[] presetData); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetHeightFieldData(int nodeID, int partID, float[] valuesArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetVolumeTileFloatData(int nodeID, int partID, ref HAPI_VolumeTileInfo tileInfo, float[] valuesArray, int length); // 0x0000000189D915B4-0x0000000189D915EC
		public virtual bool GetVolumeBounds(int nodeID, int partID, out float x_min, out float y_min, out float z_min, out float x_max, out float y_max, out float z_max, out float x_center, out float y_center, out float z_center); // 0x0000000184DA2B60-0x0000000184DA2BA0
		public virtual bool SetHeightFieldData(int nodeID, int partID, string name, float[] valuesArray, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetActiveCacheCount(out int activeCacheCount); // 0x0000000184DA2B00-0x0000000184DA2B10
		public virtual bool GetActiveCacheNames(out int[] cacheNamesArray, int activeCacheCount); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, out int propertyValue); // 0x0000000184DA2B10-0x0000000184DA2B20
		public virtual bool SetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, int propertyValue); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SaveGeoToFile(int nodeID, string fileName); // 0x00000001812081B0-0x0000000181208610
		public virtual bool LoadGeoFromFile(int nodeID, string file_name); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SaveNodeToFile(int nodeID, string fileName); // 0x00000001812081B0-0x0000000181208610
		public virtual bool LoadNodeFromFile(string file_name, int parentNodeID, string nodeLabel, bool cook_on_load, out int newNodeID); // 0x0000000184DA2AF0-0x0000000184DA2B00
		public virtual bool GetGeoSize(int nodeID, string format, out int size); // 0x0000000184DA2B10-0x0000000184DA2B20
		public virtual bool GetHandleInfo(int nodeID, out HAPI_HandleInfo[] handleInfos, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetHandleBindingInfo(int nodeID, int handleIndex, out HAPI_HandleBindingInfo[] handleBindingInfos, int start, int length); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ConvertTransform(ref HAPI_TransformEuler inTransform, HAPI_RSTOrder RSTOrder, HAPI_XYZOrder ROTOrder, out HAPI_TransformEuler outTransform); // 0x0000000184DA2A80-0x0000000184DA2AA0
		public virtual bool GetTotalCookCount(int nodeID, int nodeTypeFilter, int nodeFlagFilter, bool includeChildren, out int count); // 0x0000000184DA2B50-0x0000000184DA2B60
		public virtual bool SetSessionSync(bool enable); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetViewport(ref HAPI_Viewport viewport); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetViewport(ref HAPI_Viewport viewport); // 0x00000001812081B0-0x0000000181208610
		public virtual bool GetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo); // 0x00000001812081B0-0x0000000181208610
		public virtual bool SetNodeDisplay(int node_id, int onOff); // 0x00000001812081B0-0x0000000181208610
	}

	[Serializable]
	public enum SessionConnectionState // TypeDefIndex: 53145
	{
		NOT_CONNECTED = 0,
		CONNECTED = 1,
		FAILED_TO_CONNECT = 2
	}

	[Serializable]
	public enum SessionMode // TypeDefIndex: 53146
	{
		Socket = 0,
		Pipe = 1,
		SharedMemory = 2
	}

	[Serializable]
	public sealed class HEU_SessionData // TypeDefIndex: 53147
	{
		// Fields
		public static long INVALID_SESSION_ID; // 0x00
		public HAPI_Session _HAPISession; // 0x10
		[SerializeField]
		private int _serverProcessID; // 0x20
		[SerializeField]
		private bool _initialized; // 0x24
		[SerializeField]
		private string _pipeName; // 0x28
		[SerializeField]
		private int _port; // 0x30
		[SerializeField]
		private string _sharedMemoryName; // 0x38
		[SerializeField]
		private HAPI_ThriftSharedMemoryBufferType _sharedMemoryBufferType; // 0x40
		[SerializeField]
		private int _sharedMemoryBufferSize; // 0x44
		[SerializeField]
		private string _sessionClassType; // 0x48
		[SerializeField]
		private bool _isDefaultSession; // 0x50
		[SerializeField]
		private HEU_SessionSyncData _sessionSync; // 0x58
		[SerializeField]
		private SessionConnectionState _connectionState; // 0x60
		[SerializeField]
		private SessionMode _sessionMode; // 0x64
	
		// Properties
		public long SessionID { get; set; } // 0x0000000189D91784-0x0000000189D917D4 0x00000001811EC9D0-0x00000001811EC9E0
		public int ProcessID { get; set; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 0x0000000184D86330-0x0000000184D86340
		public HAPI_SessionType SessionType { get; set; } // 0x00000001811EC580-0x00000001811EC590 0x00000001814F51F0-0x00000001814F5220
		public bool IsInitialized { get; set; } // 0x00000001812081B0-0x0000000181208610 0x0000000184D86880-0x0000000184D86890
		public bool IsValidSessionID { get; } // 0x00000001812081B0-0x0000000181208610 
		public string PipeName { get; set; } // 0x0000000189D916E0-0x0000000189D9170C 0x0000000182FDB880-0x0000000182FDB890
		public int Port { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public string SharedMemoryName { get; set; } // 0x0000000189D917D4-0x0000000189D91800 0x00000001846A91B0-0x00000001846A91C0
		public HAPI_ThriftSharedMemoryBufferType SharedMemoryBufferType { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public int SharedMemoryBufferSize { get; set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public System.Type SessionClassType { get; set; } // 0x0000000189D9170C-0x0000000189D91784 0x0000000189D91800-0x0000000189D91830
		public bool IsDefaultSession { get; set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
		public bool IsSessionSync { get; } // 0x0000000189B00064-0x0000000189B00070 
		public SessionConnectionState ThisConnectionMode { get; set; } // 0x0000000184D86790-0x0000000184D867A0 0x0000000184D86D50-0x0000000184D86D60
		public SessionMode ThisSessionMode { get; set; } // 0x0000000184D88110-0x0000000184D88120 0x0000000184D88120-0x0000000184D88130
	
		// Constructors
		public HEU_SessionData(); // 0x0000000184D91890-0x0000000184D918A0
		static HEU_SessionData(); // 0x0000000189D916A4-0x0000000189D916E0
	
		// Methods
		public HEU_SessionSyncData GetOrCreateSessionSync(); // 0x0000000189D91634-0x0000000189D916A4
		public HEU_SessionSyncData GetSessionSync(); // 0x0000000182E56440-0x0000000182E56460
		public void SetSessionSync(HEU_SessionSyncData syncData); // 0x00000001836E5590-0x00000001836E55A0
	}

	public class HEU_SessionHAPI : HEU_SessionBase // TypeDefIndex: 53148
	{
		// Constructors
		public HEU_SessionHAPI(); // 0x0000000184DA2BA0-0x0000000184DA2BB0
	}

	public static class HEU_SessionManager // TypeDefIndex: 53150
	{
		// Fields
		private static HEU_SessionBase _defaultSession; // 0x00
		private static Dictionary<long, HEU_SessionBase> _sessionMap; // 0x08
		public static CreateSessionFromTypeDelegate _createSessionFromTypeDelegate; // 0x10
	
		// Nested types
		public delegate HEU_SessionBase CreateSessionFromTypeDelegate(System.Type type); // TypeDefIndex: 53149; 0x00000001814E2060-0x00000001814E2070
	
		// Constructors
		static HEU_SessionManager(); // 0x0000000189D939D0-0x0000000189D93A64
	
		// Methods
		public static HEU_SessionBase CreateSessionObject(); // 0x0000000189D92078-0x0000000189D920BC
		public static HEU_SessionBase CreateSessionFromType(System.Type type); // 0x0000000189D92034-0x0000000189D92078
		public static HEU_SessionBase GetDefaultSession(); // 0x0000000189D92474-0x0000000189D924E4
		public static void RegisterSession(long sessionID, HEU_SessionBase session); // 0x0000000189D936CC-0x0000000189D93750
		public static void UnregisterSession(long sessionID); // 0x0000000189D93910-0x0000000189D93988
		public static HEU_SessionBase GetSessionWithID(long sessionID); // 0x0000000189D92BA4-0x0000000189D92C24
		public static void SaveAllSessionData(); // 0x0000000189D937F4-0x0000000189D9389C
		public static void LoadAllSessionData(); // 0x0000000189D92FBC-0x0000000189D933EC
		private static void InternalValidateSceneAssets(); // 0x0000000189D92E34-0x0000000189D92F40
		public static HEU_SessionBase GetOrCreateDefaultSession(bool bNotifyUserError = true /* Metadata: 0x0233348E */); // 0x0000000189D92674-0x0000000189D92B00
		public static bool CreateInProcessSession(); // 0x0000000189D91FB4-0x0000000189D92034
		public static bool CreateThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout, bool logError); // 0x0000000189D921BC-0x0000000189D9223C
		public static bool CreateThriftPipeSession(string pipeName, bool autoClose, float timeout, bool logError); // 0x0000000189D920BC-0x0000000189D9213C
		public static bool CreateThriftSharedMemorySession(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout, bool logError); // 0x0000000189D9213C-0x0000000189D921BC
		public static bool CreateCustomSession(); // 0x0000000189D91F34-0x0000000189D91FB4
		public static bool ConnectThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout); // 0x0000000189D91EB4-0x0000000189D91F34
		public static bool ConnectThriftPipeSession(string pipeName, bool autoClose, float timeout); // 0x0000000189D91DB4-0x0000000189D91E34
		public static bool ConnectThriftSharedMemorySession(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout); // 0x0000000189D91E34-0x0000000189D91EB4
		public static void RecreateDefaultSessionData(); // 0x0000000189D93668-0x0000000189D936CC
		public static bool ConnectSessionSyncUsingThriftSocket(string hostName, int serverPort, bool autoClose, float timeout, bool logError); // 0x0000000189D91D38-0x0000000189D91DB4
		public static bool ConnectSessionSyncUsingThriftPipe(string pipeName, bool autoClose, float timeout, bool logError); // 0x0000000189D91C40-0x0000000189D91CBC
		public static bool ConnectSessionSyncUsingThriftSharedMemory(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout, bool logError); // 0x0000000189D91CBC-0x0000000189D91D38
		public static bool InitializeDefaultSession(); // 0x0000000189D92DCC-0x0000000189D92E34
		public static bool CloseDefaultSession(); // 0x0000000189D91BA4-0x0000000189D91C40
		public static void CloseAllSessions(); // 0x0000000189D91900-0x0000000189D91BA4
		private static void CheckAndCloseExistingSession(); // 0x0000000189D91830-0x0000000189D918C4
		public static HEU_SessionData GetSessionData(); // 0x0000000189D92B00-0x0000000189D92B44
		public static string GetSessionInfo(); // 0x0000000189D92B44-0x0000000189D92BA4
		public static bool LoadStoredDefaultSession(); // 0x0000000189D93460-0x0000000189D934D0
		public static bool RestartSession(); // 0x0000000189D93750-0x0000000189D937F4
		public static bool ValidatePluginSession(HEU_SessionBase session = null); // 0x0000000189D93988-0x0000000189D939D0
		public static string GetLastSessionError(); // 0x0000000189D9255C-0x0000000189D925B4
		public static bool CheckVersionMatch(); // 0x0000000189D918C4-0x0000000189D91900
		public static bool ClearConnectionError(); // 0x0000000182FFF600-0x0000000182FFF610
		public static string GetConnectionError(bool clear); // 0x0000000189D92404-0x0000000189D92430
		public static bool IsHARSProcessRunning(int processID); // 0x0000000189D92F40-0x0000000189D92FBC
		public static bool LoadSessionFromHIP(bool bCookNodes, HEU_SessionBase session = null); // 0x0000000189D933EC-0x0000000189D93460
		public static bool SaveSessionToHIP(bool bLockNodes, HEU_SessionBase session = null); // 0x0000000189D9389C-0x0000000189D93910
		public static string GetHoudiniPathOnMacOS(string houdiniPath); // 0x000000018464E630-0x000000018464E640
		public static bool OpenHoudini(string args); // 0x0000000189D934D0-0x0000000189D93584
		public static bool OpenSessionInHoudini(HEU_SessionBase session = null); // 0x0000000189D93584-0x0000000189D93668
		public static HAPI_License GetCurrentLicense(bool bLogError); // 0x0000000189D92430-0x0000000189D92474
		public static string GetString(int stringHandle, HEU_SessionBase session = null); // 0x0000000189D92CFC-0x0000000189D92D64
		public static string[] GetStringValuesFromStringIndices(int[] strIndices); // 0x0000000189D92C24-0x0000000189D92CFC
		public static string[] GetGroupNames(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, bool isInstanced); // 0x0000000189D9251C-0x0000000189D9255C
		public static bool GetGroupMembership(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref int[] membership, bool isInstanced); // 0x0000000189D924E4-0x0000000189D9251C
		public static string GetNodeName(int nodeID, HEU_SessionBase session = null); // 0x0000000189D92614-0x0000000189D92674
		public static bool GetNodeInputName(int nodeID, int inputIndex, out string inputName); // 0x0000000189D925B4-0x0000000189D92614
		public static bool GetComposedChildNodeList(HEU_SessionBase session, int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, out int[] childNodeIDs, bool bLogIfError = true /* Metadata: 0x0233348F */); // 0x0000000189D9223C-0x0000000189D92288
		public static bool GetComposedObjectListMemorySafe(HEU_SessionBase session, int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length); // 0x0000000189D92288-0x0000000189D92344
		public static bool GetComposedObjectTransformsMemorySafe(HEU_SessionBase session, int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length); // 0x0000000189D92344-0x0000000189D92404
		public static string GetUniqueMaterialShopName(int assetID, int materialID); // 0x0000000189D92D64-0x0000000189D92DCC
	}

	public static class HEU_SessionPDG // TypeDefIndex: 53151
	{
	}

	[Serializable]
	public class HEU_SessionSyncData // TypeDefIndex: 53153
	{
		// Fields
		[SerializeField]
		private int _status; // 0x10
		public float _timeLastUpdate; // 0x14
		public float _timeStartConnection; // 0x18
		public string _newNodeName; // 0x20
		public int _nodeTypeIndex; // 0x28
		public bool _validForConnection; // 0x2C
		public HAPI_Viewport _viewportHAPI; // 0x30
		public HAPI_Viewport _viewportLocal; // 0x48
		public bool _viewportJustUpdated; // 0x60
		public HAPI_SessionSyncInfo _syncInfo; // 0x61
	
		// Properties
		public Status SyncStatus { get; set; } // 0x0000000189D93B1C-0x0000000189D93B2C 0x0000000184DA2BC0-0x0000000184DA2BD0
	
		// Nested types
		public enum Status // TypeDefIndex: 53152
		{
			Stopped = 0,
			Started = 1,
			Connecting = 2,
			Initializing = 3,
			Connected = 4
		}
	
		// Constructors
		public HEU_SessionSyncData(); // 0x0000000189D93A64-0x0000000189D93B1C
	}

	public class HEU_AssetSync : HEU_BaseSync // TypeDefIndex: 53155
	{
		// Fields
		public AssetSyncCallback _onAssetLoaded; // 0x88
		public string _assetPath; // 0x90
	
		// Nested types
		public delegate void AssetSyncCallback(HEU_AssetSync assetSync); // TypeDefIndex: 53154; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public HEU_AssetSync(); // 0x0000000189D854D0-0x0000000189D854D8
	
		// Methods
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		private new void OnDestroy(); // 0x0000000189D85394-0x0000000189D8539C
		public void InitializeAsset(HEU_SessionBase session, string assetPath, string nodeName, Transform parent, Vector3 startPosition); // 0x0000000189D852BC-0x0000000189D85394
		private HEU_ThreadedTaskLoadGeo CreateThreadedTask(); // 0x0000000189D85260-0x0000000189D852BC
		public void SetLoadCallback(HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback); // 0x0000000189D85404-0x0000000189D85458
		protected override void SetupLoadTask(HEU_SessionBase session); // 0x0000000189D85458-0x0000000189D854D0
		public override void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x0000000189D8539C-0x0000000189D853D8
		public override void Resync(); // 0x0000000189D853D8-0x0000000189D85404
	}

	public class HEU_SyncedEventData // TypeDefIndex: 53156
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_ThreadedTaskLoadGeo.HEU_LoadData TopNodeData; // 0x18
		public HEU_BaseSync OutputObject; // 0x20
	
		// Constructors
		public HEU_SyncedEventData(bool bSuccess, HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HEU_BaseSync bOutputObject); // 0x0000000189D93B2C-0x0000000189D93B54
	}

	[ExecuteInEditMode]
	public class HEU_BaseSync : MonoBehaviour // TypeDefIndex: 53157
	{
		// Fields
		public int _cookNodeID; // 0x18
		public long _sessionID; // 0x20
		public string _nodeName; // 0x28
		public bool _initialized; // 0x30
		public bool _syncing; // 0x31
		public bool _deleteParent; // 0x32
		public List<HEU_GeneratedOutput> _generatedOutputs; // 0x38
		public string _outputCacheDirectory; // 0x40
		public List<string> _outputCacheFilePaths; // 0x48
		public HEU_GenerateOptions _generateOptions; // 0x50
		public StringBuilder _log; // 0x58
		public StringBuilder _error; // 0x60
		public bool _sessionSyncAutoCook; // 0x68
		private Action<HEU_SyncedEventData> _onSynced; // 0x70
		protected HEU_ThreadedTaskLoadGeo _loadTask; // 0x78
		protected int _totalCookCount; // 0x80
		protected bool _firstSyncComplete; // 0x84
	
		// Properties
		public Action<HEU_SyncedEventData> OnSynced { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
	
		// Constructors
		public HEU_BaseSync(); // 0x0000000189D89AE8-0x0000000189D89C70
	
		// Methods
		private void Awake(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x0000000189D85394-0x0000000189D8539C
		public virtual void DeleteSessionData(); // 0x0000000189D8639C-0x0000000189D863C0
		public virtual void DestroyGeneratedData(); // 0x0000000189D863C0-0x0000000189D863C8
		protected virtual void Initialize(); // 0x0000000184DA29F0-0x0000000184DA2A00
		public virtual HEU_SessionBase GetHoudiniSession(bool bCreateIfNotFound); // 0x0000000189D892E4-0x0000000189D8938C
		private int GetParentNodeID(HEU_SessionBase session); // 0x0000000189D893E8-0x0000000189D89404
		public void Log(string msg); // 0x0000000189D89418-0x0000000189D894DC
		public void ClearLog(); // 0x0000000189D860E8-0x0000000189D86218
		public void Error(string error); // 0x0000000189D86608-0x0000000189D86628
		public bool IsLoaded(); // 0x0000000189D89404-0x0000000189D89418
		public virtual void StartSync(); // 0x0000000189D89954-0x0000000189D89A18
		protected virtual void SetupLoadTask(HEU_SessionBase session); // 0x00000001841E1670-0x00000001841E1680
		public virtual void StopSync(); // 0x0000000189D89A18-0x0000000189D89A74
		public virtual void Resync(); // 0x0000000189D89748-0x0000000189D89774
		public virtual void Bake(); // 0x0000000189D85DB0-0x0000000189D860E8
		public virtual void Unload(); // 0x0000000189D89A74-0x0000000189D89AE8
		public virtual void Reset(); // 0x0000000189D8969C-0x0000000189D89748
		public virtual void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x0000000189D894DC-0x0000000189D895E0
		public virtual void GenerateObjects(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x0000000189D87EE0-0x0000000189D87F60
		public virtual void GenerateGeometry(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, int objIndex); // 0x0000000189D866D8-0x0000000189D867E0
		public void OnStopped(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x0000000189D895E0-0x0000000189D8969C
		private void GenerateTerrain(int cookNodeId, List<HEU_LoadBufferVolume> terrainBuffers); // 0x0000000189D87F60-0x0000000189D892E4
		private void GenerateMesh(int cookNodeId, List<HEU_LoadBufferMesh> meshBuffers); // 0x0000000189D87948-0x0000000189D87EE0
		private void GenerateAllInstancers(int cookNodeId, List<HEU_LoadBufferInstancer> instancerBuffers, HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x0000000189D86628-0x0000000189D866D8
		private void GenerateInstancer(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap); // 0x0000000189D867E0-0x0000000189D86A78
		private void GenerateInstancesFromNodeIDs(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap, Transform instanceRootTransform); // 0x0000000189D872B0-0x0000000189D87948
		private void GenerateInstancesFromAssetPaths(HEU_LoadBufferInstancer instancerBuffer, Transform instanceRootTransform); // 0x0000000189D86A78-0x0000000189D872B0
		private void CreateNewInstanceFromObject(GameObject assetSourceGO, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, string[] instancePrefixes, string instanceName, GameObject collisionSourceGO); // 0x0000000189D86218-0x0000000189D8639C
		private void ApplyAttributeModifiersOnGameObjectOutput(HEU_SessionBase session, int geoID, int partId, ref GameObject go); // 0x0000000189D85D38-0x0000000189D85DB0
		private void DestroyOutputs(); // 0x0000000189D863C8-0x0000000189D86608
		private void SetOutputVisiblity(HEU_LoadBufferBase buffer); // 0x0000000189D89774-0x0000000189D89954
		private string GetOutputCacheDirectory(); // 0x0000000189D8938C-0x0000000189D893E8
		public void SetOutputCacheDirectory(string directory); // 0x00000001842B4AE0-0x00000001842B4AF0
		private void AddGeneratedOutputFilePath(string path); // 0x0000000189D85CB0-0x0000000189D85D38
		public virtual void SyncUpdate(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public struct HEU_GenerateOptions // TypeDefIndex: 53158
	{
		// Fields
		public bool _generateUVs; // 0x00
		public bool _generateTangents; // 0x01
		public bool _generateNormals; // 0x02
		public bool _useLODGroups; // 0x03
		public bool _splitPoints; // 0x04
	}

	public class HEU_GeoSync : HEU_BaseSync // TypeDefIndex: 53159
	{
		// Fields
		public string _filePath; // 0x88
	
		// Constructors
		public HEU_GeoSync(); // 0x0000000189D89D24-0x0000000189D89D74
	
		// Methods
		protected override void SetupLoadTask(HEU_SessionBase session); // 0x0000000189D89C70-0x0000000189D89D24
	}

	public class HEU_NodeSync : HEU_BaseSync // TypeDefIndex: 53160
	{
		// Fields
		public string _nodeSaveFilePath; // 0x88
	
		// Constructors
		public HEU_NodeSync(); // 0x0000000189D854D0-0x0000000189D854D8
	
		// Methods
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		private new void OnDestroy(); // 0x0000000189D85394-0x0000000189D8539C
		public void InitializeFromHoudini(HEU_SessionBase session, int nodeID, string nodeName, string filePath); // 0x0000000189D8C72C-0x0000000189D8C7B4
		protected override void SetupLoadTask(HEU_SessionBase session); // 0x0000000189D8C830-0x0000000189D8C8E0
		public bool SaveNodeToFile(string filePath); // 0x0000000189D8C7B4-0x0000000189D8C830
		public static void CreateNodeSync(HEU_SessionBase session, string opName, string nodeNabel); // 0x0000000189D8C688-0x0000000189D8C72C
		public override void Resync(); // 0x0000000189D853D8-0x0000000189D85404
		public override void SyncUpdate(); // 0x0000000189D8C8E0-0x0000000189D8C924
	}

	public abstract class HEU_Task // TypeDefIndex: 53164
	{
		// Fields
		public TaskStatus _status; // 0x10
		public TaskResult _result; // 0x14
		private Guid _guid; // 0x18
		public TaskCallback _taskCompletedDelegate; // 0x28
	
		// Properties
		public Guid TaskGuid { get; } // 0x0000000184D890C0-0x0000000184D890D0 
	
		// Nested types
		public enum TaskStatus // TypeDefIndex: 53161
		{
			NONE = 0,
			PENDING_START = 1,
			STARTED = 2,
			REQUIRE_UPDATE = 3,
			PENDING_COMPLETE = 4,
			COMPLETED = 5,
			UNUSED = 6
		}
	
		public enum TaskResult // TypeDefIndex: 53162
		{
			NONE = 0,
			SUCCESS = 1,
			FAILED = 2,
			KILLED = 3
		}
	
		public delegate void TaskCallback(HEU_Task task); // TypeDefIndex: 53163; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public HEU_Task(); // 0x0000000189D94464-0x0000000189D94488
	
		// Methods
		public abstract void DoTask();
		public virtual void UpdateTask(); // 0x00000001841E1670-0x00000001841E1680
		public abstract void KillTask();
		public abstract void CompleteTask(TaskResult result);
	}

	public class HEU_AssetTask : HEU_Task // TypeDefIndex: 53166
	{
		// Fields
		public BuildType _buildType; // 0x30
		public HEU_HoudiniAsset _asset; // 0x38
		public string _assetPath; // 0x40
		public Vector3 _position; // 0x48
		public bool _buildResult; // 0x54
		public long _forceSessionID; // 0x58
	
		// Nested types
		public enum BuildType // TypeDefIndex: 53165
		{
			NONE = 0,
			LOAD = 1,
			COOK = 2,
			RELOAD = 3
		}
	
		// Constructors
		public HEU_AssetTask(); // 0x0000000189D85C40-0x0000000189D85CB0
	
		// Methods
		public HEU_SessionBase GetTaskSession(); // 0x0000000189D85A54-0x0000000189D85AE4
		public override void DoTask(); // 0x0000000189D856B8-0x0000000189D85A54
		public override void KillTask(); // 0x0000000189D85AE4-0x0000000189D85C40
		public override void CompleteTask(TaskResult result); // 0x0000000189D854D8-0x0000000189D85634
		private void CookCompletedCallback(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> outputs); // 0x0000000189D8565C-0x0000000189D856B8
		private void CookCompletedCallback(HEU_CookedEventData cookedEventData); // 0x0000000189D85634-0x0000000189D8565C
		private void CookCompletedCallback(HEU_ReloadEventData reloadEventData); // 0x0000000189D85634-0x0000000189D8565C
	}

	public class HEU_TaskManager // TypeDefIndex: 53167
	{
		// Fields
		private static List<HEU_Task> _tasks; // 0x00
		private static List<HEU_Task> _pendingAdd; // 0x08
		private static List<HEU_Task> _pendingRemove; // 0x10
	
		// Constructors
		static HEU_TaskManager(); // 0x0000000189D94338-0x0000000189D94464
		public HEU_TaskManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static void Update(); // 0x00000001841E1670-0x00000001841E1680
		public static HEU_Task GetTask(Guid taskGuid); // 0x0000000189D93F48-0x0000000189D940C0
		public static void AddTask(HEU_Task task); // 0x0000000189D93DF8-0x0000000189D93EF0
		public static void KillTask(HEU_Task task, bool bRemove); // 0x0000000189D94110-0x0000000189D941D0
		public static void KillTask(Guid taskGuid, bool bRemove); // 0x0000000189D941D0-0x0000000189D9424C
		public static void RemoveTask(HEU_Task task); // 0x0000000189D9424C-0x0000000189D94338
		public static void ExecuteTask(HEU_Task task); // 0x0000000189D93F14-0x0000000189D93F48
		public static void CompleteTask(HEU_Task task, HEU_Task.TaskResult result); // 0x0000000189D93EF0-0x0000000189D93F14
		private static void InternalCompleteTask(HEU_Task task); // 0x0000000189D940C0-0x0000000189D94110
	}

	public class HEU_LoadBufferBase // TypeDefIndex: 53168
	{
		// Fields
		public int _id; // 0x10
		public string _name; // 0x18
		public bool _bInstanced; // 0x20
		public bool _bInstancer; // 0x21
		public HEU_GeneratedOutput _generatedOutput; // 0x28
	
		// Constructors
		public HEU_LoadBufferBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void InitializeBuffer(int id, string name, bool bInstanced, bool bInstancer); // 0x0000000189DA3330-0x0000000189DA335C
	}

	public class HEU_LoadBufferMesh : HEU_LoadBufferBase // TypeDefIndex: 53169
	{
		// Fields
		public HEU_GenerateGeoCache _geoCache; // 0x30
		public List<HEU_GeoGroup> _LODGroupMeshes; // 0x38
		public int _defaultMaterialKey; // 0x40
		public bool _bGenerateUVs; // 0x44
		public bool _bGenerateTangents; // 0x45
		public bool _bGenerateNormals; // 0x46
		public bool _bPartInstanced; // 0x47
	
		// Constructors
		public HEU_LoadBufferMesh(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HEU_LoadBufferVolume : HEU_LoadBufferBase // TypeDefIndex: 53170
	{
		// Fields
		public int _tileIndex; // 0x30
		public List<HEU_LoadBufferVolumeLayer> _splatLayers; // 0x38
		public int _heightMapWidth; // 0x40
		public int _heightMapHeight; // 0x44
		public float[,] _heightMap; // 0x48
		public float[,,] _splatMaps; // 0x50
		public float _terrainSizeX; // 0x58
		public float _terrainSizeY; // 0x5C
		public float _heightRange; // 0x60
		public Vector3 _position; // 0x64
		public string _terrainDataPath; // 0x70
		public string _terrainDataExportPath; // 0x78
		public HEU_VolumeScatterTrees _scatterTrees; // 0x80
		public List<HEU_DetailPrototype> _detailPrototypes; // 0x88
		public List<int[,]> _detailMaps; // 0x90
		public HEU_DetailProperties _detailProperties; // 0x98
		public string _specifiedTerrainMaterialName; // 0xA0
	
		// Constructors
		public HEU_LoadBufferVolume(); // 0x0000000189DA3394-0x0000000189DA34AC
	}

	public class HEU_LoadBufferVolumeLayer // TypeDefIndex: 53171
	{
		// Fields
		public string _layerName; // 0x10
		public int _partID; // 0x18
		public int _heightMapWidth; // 0x1C
		public int _heightMapHeight; // 0x20
		public float _strength; // 0x24
		public string _diffuseTexturePath; // 0x28
		public string _maskTexturePath; // 0x30
		public float _metallic; // 0x38
		public string _normalTexturePath; // 0x40
		public float _normalScale; // 0x48
		public float _smoothness; // 0x4C
		public UnityEngine.Color _specularColor; // 0x50
		public Vector2 _tileSize; // 0x60
		public Vector2 _tileOffset; // 0x68
		public bool _uiExpanded; // 0x70
		public int _tile; // 0x74
		public float[] _normalizedHeights; // 0x78
		public float _minHeight; // 0x80
		public float _maxHeight; // 0x84
		public float _heightRange; // 0x88
		public float _terrainSizeX; // 0x8C
		public float _terrainSizeY; // 0x90
		public Vector3 _position; // 0x94
		public Vector3 _minBounds; // 0xA0
		public Vector3 _maxBounds; // 0xAC
		public Vector3 _center; // 0xB8
		public string _layerPath; // 0xC8
		public bool _hasLayerAttributes; // 0xD0
		public HFLayerType _layerType; // 0xD4
	
		// Constructors
		public HEU_LoadBufferVolumeLayer(); // 0x0000000189DA335C-0x0000000189DA3394
	}

	public class HEU_LoadBufferInstancer : HEU_LoadBufferBase // TypeDefIndex: 53172
	{
		// Fields
		public HAPI_Transform[] _instanceTransforms; // 0x30
		public string[] _instancePrefixes; // 0x38
		public int[] _instanceNodeIDs; // 0x40
		public string[] _assetPaths; // 0x48
		public string[] _collisionAssetPaths; // 0x50
	
		// Constructors
		public HEU_LoadBufferInstancer(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HEU_ThreadedTask // TypeDefIndex: 53173
	{
		// Fields
		private bool _isComplete; // 0x10
		private bool _isActive; // 0x11
		private bool _stopRequested; // 0x12
		private object _lockHandle; // 0x18
		private Thread _thread; // 0x20
		private System.Threading.ThreadPriority _priority; // 0x28
		private bool _isBackground; // 0x2C
		protected string _name; // 0x30
	
		// Properties
		public string TaskName { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public bool IsComplete { get; set; } // 0x0000000189DA8030-0x0000000189DA80DC 0x0000000189DA8234-0x0000000189DA82E0
		public bool IsActive { get; set; } // 0x0000000189DA7F84-0x0000000189DA8030 0x0000000189DA8188-0x0000000189DA8234
		public bool StopRequested { get; set; } // 0x0000000189DA80DC-0x0000000189DA8188 0x0000000189DA82E0-0x0000000189DA838C
		public System.Threading.ThreadPriority Priority { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public bool IsBackground { get; set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
	
		// Constructors
		public HEU_ThreadedTask(); // 0x0000000189DA7F30-0x0000000189DA7F84
	
		// Methods
		public virtual void Start(); // 0x0000000189DA7D48-0x0000000189DA7E98
		public virtual void Stop(); // 0x0000000189DA7E98-0x0000000189DA7ED8
		public virtual void Abort(); // 0x0000000189DA7C58-0x0000000189DA7C88
		public virtual void Reset(); // 0x0000000189DA7C88-0x0000000189DA7D20
		public virtual void Update(); // 0x0000000189DA7ED8-0x0000000189DA7F30
		protected virtual void DoWork(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnComplete(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnStopped(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void CleanUp(); // 0x00000001841E1670-0x00000001841E1680
		private void Run(); // 0x0000000189DA7D20-0x0000000189DA7D48
	}

	public class HEU_ThreadedTaskLoadGeo : HEU_ThreadedTask // TypeDefIndex: 53180
	{
		// Fields
		private HEU_BaseSync _ownerSync; // 0x38
		private HEU_SessionBase _session; // 0x40
		private HEU_GenerateOptions _generateOptions; // 0x48
		protected string _assetCachePath; // 0x50
		private LoadType _loadType; // 0x58
		private string _filePath; // 0x60
		private HEU_LoadData _loadData; // 0x68
		private HEU_LoadCallback _loadCallback; // 0x70
	
		// Nested types
		public enum LoadType // TypeDefIndex: 53174
		{
			FILE = 0,
			NODE = 1,
			ASSET = 2
		}
	
		public class HEU_LoadData // TypeDefIndex: 53176
		{
			// Fields
			public int _cookNodeID; // 0x10
			public LoadStatus _loadStatus; // 0x14
			public StringBuilder _logStr; // 0x18
			public HEU_SessionBase _session; // 0x20
			public List<HEU_LoadObject> _loadedObjects; // 0x28
			public Dictionary<int, HEU_LoadBufferBase> _idBuffersMap; // 0x30
	
			// Nested types
			public enum LoadStatus // TypeDefIndex: 53175
			{
				NONE = 0,
				STARTED = 1,
				SUCCESS = 2,
				ERROR = 3
			}
	
			// Constructors
			public HEU_LoadData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class HEU_LoadObject // TypeDefIndex: 53177
		{
			// Fields
			public int _objectNodeID; // 0x10
			public int _displayNodeID; // 0x14
			public List<HEU_LoadBufferVolume> _terrainBuffers; // 0x18
			public List<HEU_LoadBufferMesh> _meshBuffers; // 0x20
			public List<HEU_LoadBufferInstancer> _instancerBuffers; // 0x28
	
			// Constructors
			public HEU_LoadObject(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public enum HEU_LoadCallbackType // TypeDefIndex: 53178
		{
			PRECOOK = 0,
			POSTCOOK = 1
		}
	
		public delegate void HEU_LoadCallback(HEU_SessionBase session, HEU_LoadData loadData, HEU_LoadCallbackType callbackType); // TypeDefIndex: 53179; 0x0000000181546280-0x00000001815462A0
	
		// Constructors
		public HEU_ThreadedTaskLoadGeo(); // 0x0000000189DA7C10-0x0000000189DA7C58
	
		// Methods
		public void SetupLoad(HEU_SessionBase session, HEU_BaseSync ownerSync, LoadType loadType, int cookNodeID, string name, string filePath); // 0x0000000189DA7ABC-0x0000000189DA7C04
		public void SetupLoadNode(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string name); // 0x0000000189DA7A8C-0x0000000189DA7ABC
		public void SetupLoadFile(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string filePath); // 0x0000000189DA7A5C-0x0000000189DA7A8C
		public void SetupLoadAsset(HEU_SessionBase session, HEU_BaseSync ownerSync, string assetPath, string name); // 0x0000000189DA7A28-0x0000000189DA7A5C
		public void SetLoadCallback(HEU_LoadCallback loadCallback); // 0x00000001863AD760-0x00000001863AD770
		protected override void DoWork(); // 0x0000000189DA4560-0x0000000189DA4600
		protected virtual bool CookNode(HEU_SessionBase session, int cookNodeID); // 0x0000000189DA4188-0x0000000189DA4214
		protected virtual bool LoadObjectBuffers(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo); // 0x0000000189DA75F4-0x0000000189DA7648
		protected virtual bool LoadNodeBuffer(HEU_SessionBase session, int nodeID, HEU_LoadObject loadObject); // 0x0000000189DA7304-0x0000000189DA75F4
		protected virtual void BuildBufferIDsMap(HEU_LoadData loadData); // 0x0000000189DA3C48-0x0000000189DA4188
		public virtual bool DoFileLoad(); // 0x0000000189DA43F8-0x0000000189DA4560
		public virtual bool DoAssetLoad(); // 0x0000000189DA42F8-0x0000000189DA43F8
		private bool QueryParts(int nodeID, ref List<HAPI_PartInfo> meshParts, ref List<HAPI_PartInfo> volumeParts, ref List<HAPI_PartInfo> instancerParts, ref List<HAPI_PartInfo> curveParts, ref List<HAPI_PartInfo> scatterInstancerParts); // 0x0000000189DA77C8-0x0000000189DA784C
		protected override void OnComplete(); // 0x0000000189DA76D0-0x0000000189DA7758
		protected override void OnStopped(); // 0x0000000189DA7758-0x0000000189DA77C8
		protected override void CleanUp(); // 0x0000000189B105DC-0x0000000189B105F0
		private string CreateLogString(HEU_LoadData.LoadStatus status, string logStr); // 0x0000000189DA426C-0x0000000189DA42F8
		private void AppendLog(HEU_LoadData.LoadStatus status, string logStr); // 0x0000000189DA3B20-0x0000000189DA3C48
		private void SetLog(HEU_LoadData.LoadStatus status, string logStr); // 0x0000000189DA7888-0x0000000189DA7A28
		private bool CreateFileNode(out int fileNodeID); // 0x0000000189DA4214-0x0000000189DA426C
		public virtual int GetCookNodeID(); // 0x0000000189DA6E54-0x0000000189DA6E70
		private int GetDisplayNodeID(int objNodeID); // 0x0000000189DA6E70-0x0000000189DA6E8C
		private bool SetFileParm(int fileNodeID, string filePath); // 0x0000000189DA784C-0x0000000189DA7888
		private void Sleep(); // 0x0000000189DA7C04-0x0000000189DA7C10
		public bool GenerateTerrainBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> volumeParts, List<HAPI_PartInfo> scatterInstancerParts, out List<HEU_LoadBufferVolume> volumeBuffers); // 0x0000000189DA5380-0x0000000189DA6E54
		private void LoadStringFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref string strValue); // 0x0000000189DA7648-0x0000000189DA76D0
		private void LoadFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue); // 0x0000000189DA6FB4-0x0000000189DA70A4
		private void LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue); // 0x0000000189DA70A4-0x0000000189DA71F4
		private void LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue); // 0x0000000189DA71F4-0x0000000189DA7304
		public bool GenerateMeshBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> meshParts, bool bSplitPoints, bool bUseLODGroups, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, HEU_LoadObject loadObject, out List<HEU_LoadBufferMesh> meshBuffers); // 0x0000000189DA49A0-0x0000000189DA4F60
		public bool GenerateInstancerBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> instancerParts, out List<HEU_LoadBufferInstancer> instancerBuffers); // 0x0000000189DA4600-0x0000000189DA49A0
		private HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo); // 0x0000000189DA4F60-0x0000000189DA5238
		private HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo); // 0x0000000189DA5238-0x0000000189DA5380
		public static HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(int tileIndex, List<HEU_LoadBufferVolume> buffers); // 0x0000000189DA6E8C-0x0000000189DA6FA8
		public static string GetValidAssetCacheFolderPath(string name); // 0x0000000189DA6FA8-0x0000000189DA6FB4
	}

	public class HEU_ThreadManager // TypeDefIndex: 53181
	{
		// Fields
		private static HEU_ThreadManager _instance; // 0x00
		private List<HEU_ThreadedTask> _tasks; // 0x10
		private List<HEU_ThreadedTask> _pendingAdd; // 0x18
		private List<HEU_ThreadedTask> _pendingRemove; // 0x20
	
		// Properties
		public static HEU_ThreadManager Instance { get; } // 0x0000000189DA3AE8-0x0000000189DA3B20 
	
		// Constructors
		public HEU_ThreadManager(); // 0x0000000189DA3A0C-0x0000000189DA3AE8
	
		// Methods
		private static void CreateInstance(); // 0x00000001841E1670-0x00000001841E1680
		~HEU_ThreadManager(); // 0x0000000189DA35D0-0x0000000189DA3620
		public void Register(); // 0x00000001841E1670-0x00000001841E1680
		public void Unregister(); // 0x00000001841E1670-0x00000001841E1680
		public void Update(); // 0x0000000189DA36BC-0x0000000189DA3A0C
		public void AddTask(HEU_ThreadedTask task); // 0x0000000189DA3534-0x0000000189DA35D0
		public void RemoveTask(HEU_ThreadedTask task); // 0x0000000189DA3620-0x0000000189DA36BC
	}

	public class HEU_CookLogs // TypeDefIndex: 53182
	{
		// Fields
		private static HEU_CookLogs _instance; // 0x00
		private StringBuilder _cookLogs; // 0x10
		private int _currentCookLogCount; // 0x18
		private const int MAX_COOK_LOG_COUNT = 9001; // Metadata: 0x023334AE
		private string _lastLogStr; // 0x20
		private bool _uniqueStrOnly; // 0x28
		public const long MaxLogSize = 50000000; // Metadata: 0x023334B2
	
		// Properties
		public static HEU_CookLogs Instance { get; } // 0x0000000189D94C14-0x0000000189D94CA4 
	
		// Constructors
		public HEU_CookLogs(); // 0x0000000189D94B88-0x0000000189D94C14
	
		// Methods
		public string GetCookLogString(); // 0x0000000189043210-0x0000000189043234
		public void AppendCookLog(string logStr); // 0x0000000189D94664-0x0000000189D94780
		public void ClearCookLog(); // 0x0000000189D94780-0x0000000189D947EC
		public string GetCookLogFilePath(); // 0x0000000189D94874-0x0000000189D94924
		public void DeleteCookingFile(); // 0x0000000189D947EC-0x0000000189D94874
		public void WriteToLogFile(string logStr, bool checkLastLogStr = true /* Metadata: 0x023334AD */); // 0x0000000189D949AC-0x0000000189D94B88
		public long GetFileSizeOfLogFile(); // 0x0000000189D94924-0x0000000189D949AC
	}

	public static class HEU_EditorUtility // TypeDefIndex: 53184
	{
		// Nested types
		public enum HEU_ReplacePrefabOptions // TypeDefIndex: 53183
		{
			Default = 0,
			ConnectToPrefab = 1,
			ReplaceNameBased = 2
		}
	
		// Methods
		public static void MarkSceneDirty(); // 0x00000001841E1670-0x00000001841E1680
		public static void SelectObject(GameObject gameObject); // 0x00000001841E1670-0x00000001841E1680
		public static void SelectObjects(GameObject[] gameObjects); // 0x00000001841E1670-0x00000001841E1680
		public static Vector3 GetSelectedObjectsMeanPosition(); // 0x0000000189D954F8-0x0000000189D95510
		public static Matrix4x4 GetSelectedObjectsMeanTransform(); // 0x0000000184DA2BE0-0x0000000184DA2C20
		public static GameObject SaveAsPrefabAsset(string path, GameObject go); // 0x0000000189D957E4-0x0000000189D9581C
		public static bool PrefabIsAddedComponentOverride(Component comp); // 0x00000001812081B0-0x0000000181208610
		public static bool IsEditorPlaying(); // 0x00000001812081B0-0x0000000181208610
		public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab, HEU_ReplacePrefabOptions heuOptions); // 0x0000000189D957AC-0x0000000189D957E4
		public static bool IsPrefabInstance(GameObject go); // 0x0000000189D95698-0x0000000189D956D0
		public static bool IsPrefabAsset(GameObject go); // 0x0000000189D95660-0x0000000189D95698
		public static bool IsEditingInPrefabMode(GameObject obj); // 0x00000001812081B0-0x0000000181208610
		public static bool IsDisconnectedPrefabInstance(GameObject go); // 0x0000000189D955F0-0x0000000189D95628
		public static UnityEngine.Object GetPrefabAsset(GameObject go); // 0x0000000189D95448-0x0000000189D95480
		public static string GetPrefabAssetPath(UnityEngine.Object obj); // 0x0000000189D95410-0x0000000189D95448
		public static void DisconnectPrefabInstance(GameObject instance); // 0x0000000189D94EDC-0x0000000189D94F10
		public static UnityEngine.Object InstantiatePrefab(GameObject prefabOriginal); // 0x0000000189D955B8-0x0000000189D955F0
		public static GameObject InstantiateGameObject(GameObject sourceGameObject, Transform parentTransform, bool instantiateInWorldSpace, bool bRegisterUndo); // 0x0000000189D95548-0x0000000189D955B8
		public static Component AddComponent<T>(GameObject target, bool bRegisterUndo);
		public static void UndoRecordObject(UnityEngine.Object objectToUndo, string name); // 0x00000001841E1670-0x00000001841E1680
		public static void UndoCollapseCurrentGroup(); // 0x00000001841E1670-0x00000001841E1680
		public static UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj); // 0x0000000189D94DC8-0x0000000189D94E00
		public static bool IsPersistant(UnityEngine.Object obj); // 0x0000000189D95628-0x0000000189D95660
		public static string GetUniqueNameForSibling(Transform parentTransform, string name); // 0x0000000189D95510-0x0000000189D95548
		public static void DisplayProgressBar(string title, string info, float progress); // 0x0000000189D94FD8-0x0000000189D9500C
		public static void ClearProgressBar(); // 0x0000000189D94D94-0x0000000189D94DC8
		public static bool IsEditorNotInPlayModeAndNotGoingToPlayMode(); // 0x0000000184D85B20-0x0000000184D85B30
		public static bool DisplayDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x023334BA */); // 0x0000000189D94F10-0x0000000189D94F68
		public static bool DisplayErrorDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x023334BB */); // 0x0000000189D94F68-0x0000000189D94FD8
		public static void RevealInFinder(string path); // 0x00000001841E1670-0x00000001841E1680
		public static void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj); // 0x00000001841E1670-0x00000001841E1680
		public static void SetStatic(GameObject go, bool bStatic, bool bIncludeChildren); // 0x00000001841E1670-0x00000001841E1680
		public static void SetIsHidden(GameObject go, bool isHidden, bool bIncludeChildren); // 0x00000001841E1670-0x00000001841E1680
		public static GameObject[] GetSelectedObjects(); // 0x00000001811EC580-0x00000001811EC590
		public static HEU_HoudiniAssetRoot[] GetSelectedAssetRoots(); // 0x0000000189D95480-0x0000000189D954F8
		public static HEU_HoudiniAssetRoot[] GetAllAssetRoots(); // 0x0000000189D95364-0x0000000189D953B8
		public static void CookSelected(); // 0x0000000189D94EC0-0x0000000189D94EDC
		public static void CookAll(); // 0x0000000189D94E00-0x0000000189D94E1C
		public static void CookAssets(HEU_HoudiniAssetRoot[] rootAssets); // 0x0000000189D94E1C-0x0000000189D94EC0
		public static void RebuildSelected(); // 0x0000000189D95790-0x0000000189D957AC
		public static void RebuildAll(); // 0x0000000189D956D0-0x0000000189D956EC
		public static void RebuildAssets(HEU_HoudiniAssetRoot[] rootAssets); // 0x0000000189D956EC-0x0000000189D95790
		public static void BakeAndReplaceSelectedInScene(); // 0x0000000189D94D78-0x0000000189D94D94
		public static void BakeAndReplaceAllInScene(); // 0x0000000189D94CA4-0x0000000189D94CC0
		public static void BakeAndReplaceAssets(HEU_HoudiniAssetRoot[] rootAssets); // 0x0000000189D94CC0-0x0000000189D94D78
		public static void ExportSelectedAssetsToGeoFiles(); // 0x0000000189D95348-0x0000000189D95364
		public static void ExportAllAssetsToGeoFiles(); // 0x0000000189D95044-0x0000000189D95060
		public static void ExportAssetsToGeoFiles(HEU_HoudiniAssetRoot[] rootAssets); // 0x0000000189D95060-0x0000000189D95348
		public static string EditorSaveFolderPanel(string title, string folder, string defaultName); // 0x0000000189D9500C-0x0000000189D95044
		public static void QuerySelectedMeshTopology(); // 0x00000001841E1670-0x00000001841E1680
		public static string GetObjectParentFolder(GameObject parentObject, HashSet<Material> generatedMaterials); // 0x0000000189D953E4-0x0000000189D95410
		private static string GetObjectParentFolderHelper(int instanceID); // 0x0000000189D953B8-0x0000000189D953E4
		public static void RepaintScene(); // 0x00000001841E1670-0x00000001841E1680
		public static void SetTextureToNormalMap(string filename); // 0x00000001841E1670-0x00000001841E1680
		public static bool ReleasedMouse(); // 0x0000000182FFF600-0x0000000182FFF610
	}

	public static class HEU_Extensions // TypeDefIndex: 53185
	{
		// Extension methods
		public static List<R> Map<T, R>(this IEnumerable<T> self, Func<T, R> selector);
		public static T Reduce<T>(this IEnumerable<T> self, Func<T, T, T> func);
		public static List<T> Filter<T>(this IEnumerable<T> self, Func<T, bool> predicate);
		public static bool IsValidIndex<T>(this List<T> self, int index);
		public static bool IsEquivalentList<T>(this List<T> self, List<T> other);
		public static bool ApproximatelyEquals(this Quaternion quatA, Quaternion value); // 0x0000000189D9581C-0x0000000189D95868
		public static List<U> ConvertList<T, U>(this List<T> self);
		public static List<IEquivable<T>> ConvertListToEquivable<T>(this List<T> self);
		public static IEquivable<T>[] ConvertArrayToEquivable<T>(this T[] self);
		public static bool ApproximatelyEquals(this float self, float other, float epsilon = 0.001f /* Metadata: 0x023334BF */); // 0x0000000186935188-0x000000018693519C
		public static byte[] AsByteArray(this string self); // 0x0000000189D95868-0x0000000189D958D4
		public static string AsString(this byte[] buffer); // 0x0000000189D958D4-0x0000000189D95938
		public static Vector3 SwapXAndY(this Vector3 self); // 0x0000000184DA2C20-0x0000000184DA2C50
		public static Vector3 SwapXAndZ(this Vector3 self); // 0x0000000184DA2C50-0x0000000184DA2C70
		public static Vector3 SwapYAndZ(this Vector3 self); // 0x0000000184DA2C70-0x0000000184DA2CA0
		public static Vector3 DecomposeToPosition(this Matrix4x4 self); // 0x0000000189D6D9B0-0x0000000189D6D9FC
		public static Quaternion DecomposeToRotation(this Matrix4x4 self); // 0x0000000189D95938-0x0000000189D95A00
		public static Vector3 DecomposeToScale(this Matrix4x4 self); // 0x0000000189D95A00-0x0000000189D95AB8
	}

	public static class ArrayExtensions // TypeDefIndex: 53186
	{
		// Extension methods
		public static void Init<T>(this T[] array, T defaultValue);
		public static void Init<T>(this List<T> array, T defaultValue);
		public static void CopyToWithResize<T>(this T[] srcArray, ref ref T[] destArray);
		public static bool IsEquivalentArray<T>(this T[] arr, T[] other);
		public static bool IsNull<T>(this T[] arr);
	}

	public static class DictionaryExtensions // TypeDefIndex: 53187
	{
		// Extension methods
		public static void AddOrSet<T, U>(this Dictionary<T, U> dict, T key, U value);
	}

	public struct TransformData // TypeDefIndex: 53188
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 localPosition; // 0x1C
		public Vector3 localScale; // 0x28
		public Quaternion localRotation; // 0x34
		public Transform parent; // 0x48
	
		// Constructors
		public TransformData(Transform other); // 0x0000000189DA8550-0x0000000189DA8618
	
		// Methods
		public void CopyTo(Transform other, bool copyParent); // 0x0000000189DA84AC-0x0000000189DA8550
		public void CopyToLocal(Transform other, bool copyParent); // 0x0000000189DA8404-0x0000000189DA84AC
	}

	public class HEU_GeneralUtility // TypeDefIndex: 53194
	{
		// Nested types
		public delegate bool GetArray1ArgDel<T>(int arg1, out T[] data, int start, int length); // TypeDefIndex: 53189; 0x00000000-0x00000000
	
		public delegate bool GetArray2ArgDel<ARG2, T>(int arg1, ARG2 arg2, out T[] data, int start, int length); // TypeDefIndex: 53190; 0x00000000-0x00000000
	
		public delegate bool GetArray3ArgDel<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, out T[] data, int start, int length); // TypeDefIndex: 53191; 0x00000000-0x00000000
	
		public delegate bool GetAttributeArrayInputFunc<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, out T[] items, int start, int end); // TypeDefIndex: 53192; 0x00000000-0x00000000
	
		public delegate bool SetAttributeArrayFunc<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, int start, int end); // TypeDefIndex: 53193; 0x00000000-0x00000000
	
		// Constructors
		public HEU_GeneralUtility(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool GetArray1Arg<T>(int arg1, GetArray1ArgDel<T> func, out T[] data, int start, int count);
		public static bool GetArray2Arg<ARG2, T>(int arg1, ARG2 arg2, GetArray2ArgDel<ARG2, T> func, out T[] data, int start, int count);
		public static bool GetArray3Arg<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, GetArray3ArgDel<ARG3, ARG2, T> func, out T[] data, int start, int count);
		private static bool GetArray<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, GetArray1ArgDel<T> func1, GetArray2ArgDel<ARG2, T> func2, GetArray3ArgDel<ARG3, ARG2, T> func3, out T[] data, int start, int count, int tupleSize);
		public static bool SetArray1Arg<T>(int arg1, GetArray1ArgDel<T> func, out T[] data, int start, int count);
		public static bool SetArray2Arg<ARG2, T>(int arg1, ARG2 arg2, GetArray2ArgDel<ARG2, T> func, out T[] data, int start, int count);
		public static bool SetArray<ARG2, T>(int arg1, ARG2 arg2, GetArray1ArgDel<T> func1, GetArray2ArgDel<ARG2, T> func2, out T[] data, int start, int count, int tupleSize);
		public static bool DoArrayElementsMatch<T>(T[] array1, T[] array2);
		public static bool DoArrayElementsMatch<T>(T[] array1, int startOffset1, T[] array2, int startOffset2, int length);
		public static bool GetAttributeArray<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, T[] items, GetAttributeArrayInputFunc<T> getFunc, int count);
		public static bool GetAttribute<T>(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref ref T[] data, GetAttributeArrayInputFunc<T> getFunc);
		public static bool GetAttributeStrict<T>(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner attrOwner, string name, ref HAPI_AttributeInfo info, ref ref T[] data, GetAttributeArrayInputFunc<T> getFunc);
		public static void GetAttributeStringDataHelper(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] data); // 0x0000000189D97EC0-0x0000000189D97F10
		public static string[] GetAttributeStringData(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo); // 0x0000000189D97F10-0x0000000189D97FD8
		public static string[] GetAttributeDataAsString(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo); // 0x0000000189D97C64-0x0000000189D97CE0
		public static bool SetAttributeArray<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc, int count, int start = 0 /* Metadata: 0x023334C3 */);
		public static bool SetAttribute<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc);
		public static bool CheckAttributeExists(HEU_SessionBase session, int geoID, int partID, string attribName, HAPI_AttributeOwner attribOwner); // 0x0000000189D6BE10-0x0000000189D6BE28
		public static bool GetAttributeInfo(HEU_SessionBase session, int geoID, int partID, string attribName, ref HAPI_AttributeInfo attribInfo); // 0x0000000189D97DC0-0x0000000189D97DE0
		public static bool HasValidInstanceAttribute(HEU_SessionBase session, int geoID, int partID, string attribName); // 0x0000000189D99174-0x0000000189D991A0
		public static void UpdateGeneratedAttributeStore(HEU_SessionBase session, int geoID, int partID, GameObject go); // 0x0000000189D9A27C-0x0000000189D9A3E4
		public static HEU_OutputAttribute CreateOutputAttributeHelper(string attrName, ref HAPI_AttributeInfo attrInfo); // 0x0000000189D9693C-0x0000000189D969BC
		public static HEU_OutputAttribute CreateOutputAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo); // 0x0000000189D969BC-0x0000000189D96C04
		public static void CopyWorldTransformValues(Transform src, Transform dest); // 0x0000000189D967E4-0x0000000189D968A0
		public static void ApplyTransformTo(Transform src, Transform target); // 0x0000000189D95AB8-0x0000000189D95BCC
		public static void CopyLocalTransformValues(Transform src, Transform dest); // 0x0000000189D96728-0x0000000189D967E4
		public static List<GameObject> GetChildGameObjects(GameObject parentGO); // 0x0000000189D98630-0x0000000189D98828
		public static List<GameObject> GetChildGameObjectsWithNamePattern(GameObject parentGO, string pattern, bool bExclude); // 0x0000000189D983C8-0x0000000189D98630
		public static List<GameObject> GetInstanceChildObjects(GameObject parentGO); // 0x0000000189D98A94-0x0000000189D98AD4
		public static List<GameObject> GetNonInstanceChildObjects(GameObject parentGO); // 0x0000000189D98CEC-0x0000000189D98D2C
		public static GameObject GetGameObjectByName(List<GameObject> goList, string name); // 0x0000000189D98918-0x0000000189D98A5C
		public static GameObject GetGameObjectByNameInProjectOnly(string name); // 0x0000000189D98828-0x0000000189D988E0
		public static bool IsGameObjectInProject(GameObject go); // 0x0000000189D991A0-0x0000000189D991A8
		public static GameObject GetGameObjectByNameInScene(string name); // 0x0000000189D988E0-0x0000000189D98918
		public static HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(string name); // 0x0000000189D98A5C-0x0000000189D98A94
		public static T GetOrCreateComponent<T>(GameObject gameObject)
			where T : Component;
		public static void DestroyGeneratedComponents(GameObject gameObject); // 0x0000000189D96F38-0x0000000189D97014
		public static void DestroyGeneratedMeshComponents(GameObject gameObject); // 0x0000000189D97110-0x0000000189D9719C
		public static void DestroyTerrainComponents(GameObject gameObject); // 0x0000000189D97600-0x0000000189D97744
		public static void DestroyComponent<T>(GameObject gameObject)
			where T : Component;
		public static void DestroyImmediate(UnityEngine.Object obj, bool bAllowDestroyingAssets = false /* Metadata: 0x023334C4 */, bool bRegisterUndo = false /* Metadata: 0x023334C5 */); // 0x0000000189D97384-0x0000000189D973B8
		public static void DestroyBakedGameObjects(List<GameObject> gameObjectsToDestroy); // 0x0000000189D96E6C-0x0000000189D96E78
		public static void DestroyBakedGameObjectsWithEndName(List<GameObject> gameObjectsToDestroy, string endName); // 0x0000000189D96D60-0x0000000189D96E6C
		public static void DestroyLODGroup(GameObject targetGO, bool bDontDeletePersistantResources); // 0x0000000189D973B8-0x0000000189D97524
		public static List<Transform> GetLODTransforms(GameObject targetGO); // 0x0000000189D98AD4-0x0000000189D98C14
		public static void SetLODTransformValues(GameObject targetGO, List<HoudiniEngineUnity.TransformData> transformData); // 0x0000000189D99E1C-0x0000000189D99F58
		public static void DestroyGeneratedMeshMaterialsLODGroups(GameObject targetGO, bool bDontDeletePersistantResources); // 0x0000000189D9719C-0x0000000189D97384
		public static void DestroyGeneratedMaterial(Material material); // 0x0000000189D97014-0x0000000189D97110
		public static void DestroyMeshCollider(MeshCollider meshCollider, bool bDontDeletePersistantResources); // 0x0000000189D97524-0x0000000189D97600
		public static void SetGameObjectRenderVisiblity(GameObject gameObject, bool bVisible); // 0x0000000189D99D6C-0x0000000189D99E1C
		public static void SetGameObjectChildrenRenderVisibility(GameObject gameObject, bool bVisible); // 0x0000000189D99C04-0x0000000189D99CBC
		public static void SetGameObjectColliderState(GameObject gameObject, bool bEnabled); // 0x0000000189D99CBC-0x0000000189D99D6C
		public static void SetGameObjectChildrenColliderState(GameObject gameObject, bool bVisible); // 0x0000000189D99B4C-0x0000000189D99C04
		public static string ColorToString(UnityEngine.Color c); // 0x0000000189D96360-0x0000000189D964FC
		public static UnityEngine.Color StringToColor(string colorString); // 0x0000000189D9A184-0x0000000189D9A27C
		public static bool DoesUnityTagExist(string tagName); // 0x0000000182FFF600-0x0000000182FFF610
		public static void SetLayer(GameObject rootGO, int layer, bool bIncludeChildren); // 0x0000000189D99F58-0x0000000189D9A01C
		public static void SetTag(GameObject rootGO, string tag, bool bIncludeChildren); // 0x0000000189D9A0C0-0x0000000189D9A184
		public static void CopyFlags(GameObject srcGO, GameObject dstGO, bool bIncludeChildren); // 0x0000000189D9662C-0x0000000189D9669C
		public static bool IsMouseWithinSceneView(Camera camera, Vector2 mousePosition); // 0x0000000189D9927C-0x0000000189D992EC
		public static bool IsMouseOverRect(Camera camera, Vector2 mousePosition, ref Rect rect); // 0x0000000189D99230-0x0000000189D9927C
		public static System.Type GetSystemTypeByName(string typeName); // 0x0000000189D99040-0x0000000189D99078
		public static void AssignUnityTag(HEU_SessionBase session, int geoID, int partID, GameObject gameObject); // 0x0000000189D95CE8-0x0000000189D95DEC
		public static void AssignUnityLayer(HEU_SessionBase session, int geoID, int partID, GameObject gameObject); // 0x0000000189D95BCC-0x0000000189D95CE8
		public static void MakeStaticIfHasAttribute(HEU_SessionBase session, int geoID, int partID, GameObject gameObject); // 0x0000000189D99600-0x0000000189D996F8
		public static string GetUnityScriptAttributeValue(HEU_SessionBase session, int geoID, int partID); // 0x0000000189D99078-0x0000000189D99150
		public static string GetAttributeStringValueSingle(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner); // 0x0000000189D982C4-0x0000000189D983C8
		public static string GetAttributeStringValueSingleStrict(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner); // 0x0000000189D97FD8-0x0000000189D982C4
		public static bool GetAttributeFloatSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out float value); // 0x0000000189D97CE0-0x0000000189D97DC0
		public static bool GetAttributeIntSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out int value); // 0x0000000189D97DE0-0x0000000189D97EC0
		public static bool GetAttributeColorSingle(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color value); // 0x0000000189D97B90-0x0000000189D97C64
		public static bool HasAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner); // 0x0000000189D99150-0x0000000189D99174
		public static void AttachScriptWithInvokeFunction(string scriptSet, GameObject gameObject); // 0x0000000189D95DEC-0x0000000189D96308
		public static bool IsInCameraView(Camera camera, Vector3 point); // 0x0000000189D991A8-0x0000000189D99230
		internal static List<HEU_Handle> FindOrGenerateHandles(HEU_SessionBase session, ref HAPI_AssetInfo assetInfo, int assetID, string assetName, HEU_Parameters parameters, List<HEU_Handle> currentHandles); // 0x0000000189D97744-0x0000000189D97B90
		public static void CopyComponents(GameObject srcGO, GameObject destGO); // 0x00000001841E1670-0x00000001841E1680
		public static Texture LoadTextureFromFile(string filePath); // 0x0000000189D992EC-0x0000000189D99498
		public static Texture2D MakeTexture(int width, int height, UnityEngine.Color color); // 0x0000000189D996F8-0x0000000189D997F8
		public static string ReplaceFirstOccurrence(string srcStr, string searchStr, string replaceStr); // 0x0000000189D99AB4-0x0000000189D99B4C
		public static void SetParentWithCleanTransform(Transform parentTransform, Transform childTransform); // 0x0000000189D9A01C-0x0000000189D9A0C0
		public static void CopyHAPITransform(ref HAPI_Transform src, ref HAPI_Transform dest); // 0x0000000189D9669C-0x0000000189D96728
		public static string GetMaterialAttributeValueFromPart(HEU_SessionBase session, int geoID, int partID); // 0x0000000189D98C14-0x0000000189D98CEC
		public static void ReplaceColliderMeshFromMeshFilter(GameObject targetGO, GameObject sourceColliderGO); // 0x0000000189D99988-0x0000000189D99AB4
		public static void ReplaceColliderMeshFromMeshCollider(GameObject targetGO, GameObject sourceColliderGO); // 0x0000000189D99868-0x0000000189D99988
		public static float BiLerpf(float p00, float p10, float p01, float p11, float fracX, float fracY); // 0x0000000189D96308-0x0000000189D96360
		public static float Fractionalf(float value); // 0x0000000184DA2CA0-0x0000000184DA2CD0
		public static string LongestCommonPrefix(List<string> list); // 0x0000000189D99498-0x0000000189D99600
		public static string GetRawOperatorName(string assetOpName); // 0x0000000189D98FE4-0x0000000189D99040
		public static GameObject GetPrefabFromPath(string path); // 0x0000000189D98D2C-0x0000000189D98FE4
		public static void ComposeNChildren(GameObject parent, int n, ref List<GameObject> childGameObjects, bool destroyIfExists = false /* Metadata: 0x023334C6 */); // 0x0000000189D964FC-0x0000000189D9662C
		private static void DestroyChildWithName(Transform parent, string name); // 0x0000000189D96E78-0x0000000189D96F38
		public static void DestroyAutoGeneratedChildren(GameObject parent); // 0x0000000189D96C04-0x0000000189D96D60
		public static GameObject CreateNewGameObject(string name = "" /* Metadata: 0x023334C7 */); // 0x0000000189D968A0-0x0000000189D9693C
		public static void RenameGameObject(GameObject obj, string name); // 0x0000000189D997F8-0x0000000189D99868
	}

	public class ReverseCompare : System.Collections.IComparer // TypeDefIndex: 53195
	{
		// Constructors
		public ReverseCompare(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public int Compare(object x, object y); // 0x0000000189DA838C-0x0000000189DA8404
	}

	public class HEU_GenerateGeoCache // TypeDefIndex: 53199
	{
		// Fields
		[CompilerGenerated]
		private int _AssetID_k__BackingField; // 0x10
		public HAPI_GeoInfo _geoInfo; // 0x14
		public HAPI_PartInfo _partInfo; // 0x38
		public string _partName; // 0x68
		public int[] _vertexList; // 0x70
		public int[] _faceCounts; // 0x78
		public int[] _houdiniMaterialIDs; // 0x80
		public bool _singleFaceUnityMaterial; // 0x88
		public bool _singleFaceHoudiniMaterial; // 0x89
		public Dictionary<int, HEU_UnityMaterialInfo> _unityMaterialInfos; // 0x90
		public HAPI_AttributeInfo _unityMaterialAttrInfo; // 0x98
		public int[] _unityMaterialAttrName; // 0xC0
		public List<string> _unityMaterialAttrStringsMap; // 0xC8
		public HAPI_AttributeInfo _substanceMaterialAttrNameInfo; // 0xD0
		public int[] _substanceMaterialAttrName; // 0xF8
		public List<string> _substanceMaterialAttrStringsMap; // 0x100
		public HAPI_AttributeInfo _substanceMaterialAttrIndexInfo; // 0x108
		public int[] _substanceMaterialAttrIndex; // 0x130
		public List<HEU_MaterialData> _inUseMaterials; // 0x138
		public HAPI_AttributeInfo _posAttrInfo; // 0x140
		public HAPI_AttributeInfo[] _uvsAttrInfo; // 0x168
		public HAPI_AttributeInfo _normalAttrInfo; // 0x170
		public HAPI_AttributeInfo _colorAttrInfo; // 0x198
		public HAPI_AttributeInfo _alphaAttrInfo; // 0x1C0
		public HAPI_AttributeInfo _tangentAttrInfo; // 0x1E8
		public float[] _posAttr; // 0x210
		public float[][] _uvsAttr; // 0x218
		public float[] _normalAttr; // 0x220
		public float[] _colorAttr; // 0x228
		public float[] _alphaAttr; // 0x230
		public float[] _tangentAttr; // 0x238
		public string[] _groups; // 0x240
		public bool _hasGroupGeometry; // 0x248
		public Dictionary<string, int[]> _groupSplitVertexIndices; // 0x250
		public Dictionary<string, List<int>> _groupSplitFaceIndices; // 0x258
		public Dictionary<string, List<int>> _groupVertexOffsets; // 0x260
		public int[] _allCollisionVertexList; // 0x268
		public int[] _allCollisionFaceIndices; // 0x270
		public float _normalCosineThreshold; // 0x278
		public bool _hasLODGroups; // 0x27C
		public float[] _LODTransitionValues; // 0x280
		public bool _isMeshReadWrite; // 0x288
		public List<HEU_ColliderInfo> _colliderInfos; // 0x290
		public List<HEU_MaterialData> _materialCache; // 0x298
		public Dictionary<int, HEU_MaterialData> _materialIDToDataMap; // 0x2A0
		public string _assetCacheFolderPath; // 0x2A8
		[SerializeField]
		public HEU_MeshIndexFormat _meshIndexFormat; // 0x2B0
	
		// Properties
		public int GeoID { get; } // 0x0000000184D86310-0x0000000184D86320 
		public int PartID { get; } // 0x0000000184D863B0-0x0000000184D863C0 
		public int AssetID { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	
		// Nested types
		public class HEU_ColliderInfo // TypeDefIndex: 53197
		{
			// Fields
			public ColliderType _colliderType; // 0x10
			public Vector3 _colliderCenter; // 0x14
			public Vector3 _colliderSize; // 0x20
			public float _colliderRadius; // 0x2C
			public bool _convexCollider; // 0x30
			public string _collisionGroupName; // 0x38
			public Vector3[] _collisionVertices; // 0x40
			public int[] _collisionIndices; // 0x48
			public MeshTopology _meshTopology; // 0x50
			public bool _isTrigger; // 0x54
	
			// Nested types
			public enum ColliderType // TypeDefIndex: 53196
			{
				NONE = 0,
				BOX = 1,
				SPHERE = 2,
				MESH = 3,
				SIMPLE_BOX = 4,
				SIMPLE_SPHERE = 5,
				SIMPLE_CAPSULE = 6
			}
	
			// Constructors
			public HEU_ColliderInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53198
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Material> __9__64_0; // 0x08
			public static Comparison<float> __9__66_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DB8710-0x0000000189DB8774
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetFinalMaterialsFromComparingNewWithPrevious_b__64_0(Material material); // 0x0000000189DB86C4-0x0000000189DB8710
			internal int _GenerateLODMeshesFromGeoGroups_b__66_0(float a, float b); // 0x0000000189DB86A8-0x0000000189DB86C4
		}
	
		// Constructors
		public HEU_GenerateGeoCache(); // 0x0000000189DA30C4-0x0000000189DA3330
	
		// Methods
		public static HEU_GenerateGeoCache GetPopulatedGeoCache(HEU_SessionBase session, int assetID, int geoID, int partID, bool bUseLODGroups, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x0000000189DA1A44-0x0000000189DA1AFC
		public void GetStringAttributes(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] stringIndices, ref List<string> stringTable); // 0x0000000189DA1AFC-0x0000000189DA1C5C
		public void PopulateUnityMaterialData(HEU_SessionBase session); // 0x0000000189DA2378-0x0000000189DA2670
		public static int GetMaterialKeyFromAttributeIndex(HEU_GenerateGeoCache geoCache, int attributeIndex, out string unityMaterialName, out string substanceName, out int substanceIndex); // 0x0000000189DA18BC-0x0000000189DA1A44
		public static void CreateMaterialInfoEntryFromAttributeIndex(HEU_GenerateGeoCache geoCache, int materialAttributeIndex); // 0x0000000189D9AD08-0x0000000189D9AE14
		public bool PopulateGeometryData(HEU_SessionBase session, bool bUseLODGroups); // 0x0000000189DA1FE0-0x0000000189DA2378
		public static void ParseLODTransitionAttribute(HEU_SessionBase session, int geoID, int partID, ref float[] LODTransitionValues); // 0x0000000189DA1F00-0x0000000189DA1FE0
		public static void UpdateColliders(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData); // 0x0000000189DA2F84-0x0000000189DA30C4
		public static void UpdateCollider(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData, HEU_ColliderInfo colliderInfo); // 0x0000000189DA2930-0x0000000189DA2F84
		private static void GetFinalMaterialsFromComparingNewWithPrevious(GameObject gameObject, Material[] previousMaterials, Material[] newMaterials, ref Material[] finalMaterials); // 0x0000000189DA1580-0x0000000189DA18BC
		public static bool GenerateMeshFromSingleGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced); // 0x0000000189DA1370-0x0000000189DA1580
		public static bool GenerateLODMeshesFromGeoGroups(HEU_SessionBase session, List<HEU_GeoGroup> GeoGroupMeshes, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced); // 0x0000000189D9F190-0x0000000189D9FB88
		public static bool GenerateMeshFromGeoGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced, out Mesh newMesh, out Material[] newMaterials); // 0x0000000189D9FB88-0x0000000189DA1370
		public static Mesh CombineQuadMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> subMeshIndices, bool bGenerateNormals); // 0x0000000189D9A790-0x0000000189D9AD08
		public static Mesh CombineMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> submeshIndices, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat); // 0x0000000189D9A518-0x0000000189D9A790
		public static Mesh CreateMeshFromMeshData(HEU_MeshData submesh, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat); // 0x0000000189D9AE14-0x0000000189D9B0A4
		public static void TransferRegularAttributesToVertices(int[] groupVertexList, int[] allFaceCounts, List<int> groupFaces, List<int> groupVertexOffset, ref HAPI_AttributeInfo attribInfo, float[] inData, ref float[] outData); // 0x0000000189DA2670-0x0000000189DA2930
		public static bool GenerateGeoGroupUsingGeoCacheVertices(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey); // 0x0000000189D9CCBC-0x0000000189D9F190
		public static bool GenerateGeoGroupUsingGeoCachePoints(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey); // 0x0000000189D9B0A4-0x0000000189D9CCBC
		private static void GetSubmeshIDForFace(HEU_GenerateGeoCache geoCache, int faceMaterialID, int groupFace, int vertexFaceIndex, int[] groupVertexList, int defaultMaterialKey, ref int submeshID, ref int singleFaceUnityMaterialKey, ref int singleFaceHoudiniMaterialKey); // 0x0000000189DA1C5C-0x0000000189DA1F00
		public static MeshTopology CalculateGroupMeshTopology(List<int> groupFaces, int[] allFaceCounts); // 0x0000000189D9A3E4-0x0000000189D9A518
	}

	public class HEU_GeoGroup : IComparable<HEU_GeoGroup> // TypeDefIndex: 53200
	{
		// Fields
		public string _groupName; // 0x10
		public Dictionary<int, HEU_MeshData> _subMeshesMap; // 0x18
		public List<HEU_VertexEntry>[] _sharedNormalIndices; // 0x20
	
		// Constructors
		public HEU_GeoGroup(); // 0x0000000189DA8744-0x0000000189DA87BC
	
		// Methods
		public int CompareTo(HEU_GeoGroup other); // 0x0000000189DA8618-0x0000000189DA8650
		public void SetupNormalIndices(int indicesCount); // 0x0000000189DA8650-0x0000000189DA8744
	}

	public class HEU_VertexEntry // TypeDefIndex: 53201
	{
		// Fields
		public int _meshKey; // 0x10
		public int _vertexIndex; // 0x14
		public int _normalIndex; // 0x18
	
		// Constructors
		public HEU_VertexEntry(int meshKey, int vertexIndex, int normalIndex); // 0x0000000184D88580-0x0000000184D88590
	}

	public static class HEU_GeometryUtility // TypeDefIndex: 53202
	{
		// Methods
		public static Vector2[] GeneratePerTriangle(Mesh meshSrc); // 0x0000000189DA9CF4-0x0000000189DA9D2C
		public static void GenerateSecondaryUVSet(Mesh meshsrc); // 0x0000000189DA9D2C-0x0000000189DA9D60
		public static void CalculateMeshTangents(Mesh mesh); // 0x0000000189DA87BC-0x0000000189DA8F60
		public static Mesh GenerateCubeMeshFromPoints(Vector3[] points, UnityEngine.Color[] pointsColor, float size = 1f /* Metadata: 0x023334CF */); // 0x0000000189DA8F60-0x0000000189DA9CF4
		public static string GetInstanceOutputName(string partName, string[] userPrefix, int index); // 0x0000000189DA9D60-0x0000000189DA9E10
	}

	public class HEU_InputData // TypeDefIndex: 53203
	{
		// Fields
		public GameObject _inputObject; // 0x10
	
		// Constructors
		public HEU_InputData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class HEU_InputInterface // TypeDefIndex: 53204
	{
		// Fields
		public const int DEFAULT_PRIORITY = 100; // Metadata: 0x023334D3
		protected int _priority; // 0x10
	
		// Properties
		public int Priority { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public HEU_InputInterface(int priority); // 0x00000001814F51F0-0x00000001814F5220
	
		// Methods
		public void RegisterInterface(); // 0x0000000189DAFE14-0x0000000189DAFE60
		public abstract bool IsThisInputObjectSupported(GameObject inputObject);
		public abstract bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID);
	}

	[Serializable]
	public class HEU_InputInterfaceMeshSettings // TypeDefIndex: 53205
	{
		// Fields
		[SerializeField]
		private bool _exportColliders; // 0x10
	
		// Properties
		public bool ExportColliders { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public HEU_InputInterfaceMeshSettings(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class HEU_InputInterfaceMesh : HEU_InputInterface // TypeDefIndex: 53210
	{
		// Fields
		private HEU_InputInterfaceMeshSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataMeshes : HEU_InputData // TypeDefIndex: 53206
		{
			// Fields
			public List<HEU_InputDataMesh> _inputMeshes; // 0x18
			public bool _hasLOD; // 0x20
	
			// Constructors
			public HEU_InputDataMeshes(); // 0x0000000189DA9E10-0x0000000189DA9E88
		}
	
		public enum HEU_InputColliderType // TypeDefIndex: 53207
		{
			NONE = 0,
			BOX = 1,
			SPHERE = 2,
			CAPSULE = 3,
			MESH = 4
		}
	
		public class HEU_InputDataCollider // TypeDefIndex: 53208
		{
			// Fields
			public Collider _collider; // 0x10
			public HEU_InputColliderType _colliderType; // 0x18
	
			// Constructors
			public HEU_InputDataCollider(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class HEU_InputDataMesh // TypeDefIndex: 53209
		{
			// Fields
			public Mesh _mesh; // 0x10
			public Material[] _materials; // 0x18
			public string _meshPath; // 0x20
			public string _meshName; // 0x28
			public int _numVertices; // 0x30
			public int _numSubMeshes; // 0x34
			public uint[] _indexStart; // 0x38
			public uint[] _indexCount; // 0x40
			public float _LODScreenTransition; // 0x48
			public Transform _transform; // 0x50
			public List<HEU_InputDataCollider> _colliders; // 0x58
	
			// Constructors
			public HEU_InputDataMesh(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		private HEU_InputInterfaceMesh(); // 0x0000000184DA2CD0-0x0000000184DA2CE0
	
		// Methods
		public void Initialize(HEU_InputInterfaceMeshSettings settings); // 0x0000000185392C40-0x0000000185392C50
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x0000000189DA9FD4-0x0000000189DAA114
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x0000000189DAAB48-0x0000000189DAAC64
		public static void GetUVsFromMesh(Mesh mesh, Vector2[] srcUVs, List<Vector3> destUVs, int index); // 0x0000000189DAAAC4-0x0000000189DAAB48
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData); // 0x0000000189DAB928-0x0000000189DACD54
		internal bool UploadColliderData(HEU_SessionBase session, int mergeNodeID, HEU_InputDataMeshes inputData, int parentNodeId); // 0x0000000189DAB3F4-0x0000000189DAB928
		internal bool UploadBoxColliderData(HEU_SessionBase session, BoxCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x0000000189DAAC64-0x0000000189DAADD8
		internal bool UploadSphereColliderData(HEU_SessionBase session, SphereCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x0000000189DAD038-0x0000000189DAD1B0
		internal bool UploadCapsuleColliderData(HEU_SessionBase session, CapsuleCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x0000000189DAADD8-0x0000000189DAB3F4
		internal bool UploadMeshColliderData(HEU_SessionBase session, MeshCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x0000000189DACD54-0x0000000189DAD038
		internal string GetColliderGroupBaseName(Collider collider, bool bIsConvex = false /* Metadata: 0x023334D5 */, bool bIsSimple = false /* Metadata: 0x023334D6 */, bool bIsRendered = false /* Metadata: 0x023334D7 */); // 0x0000000189DAA8D4-0x0000000189DAA9C4
		internal bool CreateInputNodeForCollider(HEU_SessionBase session, out int outNodeID, int parentNodeId, int colliderIndex, string colliderName, float[] colliderVertices, int[] colliderIndices); // 0x0000000189DA9F60-0x0000000189DA9FD4
		public HEU_InputDataMeshes GenerateMeshDatasFromGameObject(GameObject inputObject, bool bExportColliders = false /* Metadata: 0x023334D8 */); // 0x0000000189DAA5FC-0x0000000189DAA8D4
		public static HEU_InputDataMesh CreateSingleMeshData(GameObject meshGameObject, bool bExportColliders); // 0x0000000189DAA114-0x0000000189DAA5FC
		private static Mesh GetMeshFromObject(GameObject meshGameObject); // 0x0000000189DAA9C4-0x0000000189DAAAC4
	}

	[Serializable]
	public class HEU_InputInterfaceSplineSettings // TypeDefIndex: 53211
	{
		// Fields
		[SerializeField]
		private float _samplingResolution; // 0x10
	
		// Properties
		public float SamplingResolution { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
	
		// Constructors
		public HEU_InputInterfaceSplineSettings(); // 0x0000000184DA2CE0-0x0000000184DA2CF0
	}

	public class HEU_InputInterfaceSpline : HEU_InputInterface // TypeDefIndex: 53214
	{
		// Fields
		private HEU_InputInterfaceSplineSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataSpline // TypeDefIndex: 53212
		{
			// Fields
			public Spline _spline; // 0x10
			public bool _closed; // 0x18
			public int _count; // 0x1C
			public float _length; // 0x20
			public BezierKnot[] _knots; // 0x28
	
			// Constructors
			public HEU_InputDataSpline(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class HEU_InputDataSplineContainer : HEU_InputData // TypeDefIndex: 53213
		{
			// Fields
			public List<HEU_InputDataSpline> _inputSplines; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataSplineContainer(); // 0x0000000189DA9E88-0x0000000189DA9F00
		}
	
		// Constructors
		private HEU_InputInterfaceSpline(); // 0x0000000184DA2CD0-0x0000000184DA2CE0
	
		// Methods
		public void Initialize(HEU_InputInterfaceSplineSettings settings); // 0x0000000189DAD6C8-0x0000000189DAD734
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x0000000189DAD734-0x0000000189DAD7C8
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x0000000189DAD1B0-0x0000000189DAD338
		public HEU_InputDataSplineContainer GenerateSplineDataFromGameObject(GameObject inputObject); // 0x0000000189DAD338-0x0000000189DAD6C8
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputDataSpline inputSpline, Matrix4x4 localToWorld); // 0x0000000189DAD7C8-0x0000000189DAD850
	}

	public class HEU_InputInterfaceTerrain : HEU_InputInterface // TypeDefIndex: 53216
	{
		// Nested types
		public class HEU_InputDataTerrain : HEU_InputData // TypeDefIndex: 53215
		{
			// Fields
			public string _heightFieldName; // 0x18
			public int _parentNodeID; // 0x20
			public float _voxelSize; // 0x24
			public Terrain _terrain; // 0x28
			public TerrainData _terrainData; // 0x30
			public int _numPointsX; // 0x38
			public int _numPointsY; // 0x3C
			public HAPI_Transform _transform; // 0x40
			public float _heightScale; // 0x68
			public int _heightfieldNodeID; // 0x6C
			public int _heightNodeID; // 0x70
			public int _maskNodeID; // 0x74
			public int _mergeNodeID; // 0x78
	
			// Constructors
			public HEU_InputDataTerrain(); // 0x0000000189DA9F00-0x0000000189DA9F60
		}
	
		// Constructors
		public HEU_InputInterfaceTerrain(); // 0x0000000184DA2CD0-0x0000000184DA2CE0
	
		// Methods
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x0000000189DAD8C8-0x0000000189DADA44
		private bool SetMaskLayer(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo); // 0x0000000189DADF14-0x0000000189DAE018
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x0000000189DADE14-0x0000000189DADEAC
		public bool CreateHeightFieldInputNode(HEU_SessionBase session, HEU_InputDataTerrain idt); // 0x0000000189DAD850-0x0000000189DAD8C8
		public bool UploadHeightValuesWithTransform(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo volumeInfo); // 0x0000000189DAE758-0x0000000189DAE844
		public bool UploadAlphaMaps(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo, out bool bMaskSet); // 0x0000000189DAE264-0x0000000189DAE758
		public bool SetHeightFieldData(HEU_SessionBase session, int volumeNodeID, int partID, float[] heightValues, string heightFieldName, ref HAPI_VolumeInfo baseVolumeInfo); // 0x0000000189DADEAC-0x0000000189DADF14
		public bool SetTerrainDataAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData); // 0x0000000189DAE018-0x0000000189DAE09C
		public bool SetTerrainLayerAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainLayer terrainLayer); // 0x0000000189DAE09C-0x0000000189DAE120
		public void SetTreePrototypes(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData); // 0x0000000189DAE140-0x0000000189DAE264
		public void SetTreeInstances(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData); // 0x0000000189DAE120-0x0000000189DAE140
		public HEU_InputDataTerrain GenerateTerrainDataFromGameObject(GameObject inputObject); // 0x0000000189DADA44-0x0000000189DADE14
	}

	[Serializable]
	public class HEU_InputInterfaceTilemapSettings // TypeDefIndex: 53217
	{
		// Fields
		public bool _createGroupsForTiles; // 0x10
		public bool _exportUnusedTiles; // 0x11
		public bool _applyTileColor; // 0x12
		public bool _applyTilemapOrientation; // 0x13
	
		// Constructors
		public HEU_InputInterfaceTilemapSettings(); // 0x0000000184DA2CF0-0x0000000184DA2D00
	}

	public class HEU_InputInterfaceTilemap : HEU_InputInterface // TypeDefIndex: 53219
	{
		// Fields
		private HEU_InputInterfaceTilemapSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataTilemap : HEU_InputData // TypeDefIndex: 53218
		{
			// Fields
			public Tilemap _tilemap; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataTilemap(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		private HEU_InputInterfaceTilemap(); // 0x0000000184DA2CD0-0x0000000184DA2CE0
	
		// Methods
		public void Initialize(HEU_InputInterfaceTilemapSettings settings); // 0x0000000189DAE9E8-0x0000000189DAEA54
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x0000000189DAE844-0x0000000189DAE91C
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x0000000189DAEA54-0x0000000189DAEAE8
		private bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData); // 0x0000000189DAEAE8-0x0000000189DAFE14
		public HEU_InputDataTilemap GenerateTilemapDataFromGameObject(GameObject inputObject); // 0x0000000189DAE91C-0x0000000189DAE9E8
	}

	public static class HEU_InputMeshUtility // TypeDefIndex: 53220
	{
		// Methods
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem); // 0x0000000189DAFFB0-0x0000000189DB0108
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, ref HAPI_PartInfo partInfo); // 0x0000000189DB033C-0x0000000189DB0494
		public static bool SetMeshVertexAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, int[] indices, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem); // 0x0000000189DB0494-0x0000000189DB05E8
		public static bool SetMeshVertexFloatAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, int[] indices, ref HAPI_PartInfo partInfo); // 0x0000000189DB05E8-0x0000000189DB073C
		public static bool UploadMeshIntoHoudiniNode(HEU_SessionBase session, int assetNodeID, int objectID, int geoID, ref Mesh mesh); // 0x0000000189DB073C-0x0000000189DB0964
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3Int[] data, ref HAPI_PartInfo partInfo); // 0x0000000189DB0108-0x0000000189DB0258
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, string[] data, ref HAPI_PartInfo partInfo); // 0x0000000189DB0258-0x0000000189DB033C
		public static bool SetMeshDetailAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3 data, ref HAPI_PartInfo partInfo); // 0x0000000189DAFE60-0x0000000189DAFFB0
	}

	public static class HEU_InputUtility // TypeDefIndex: 53221
	{
		// Fields
		private static List<HEU_InputInterface> _inputInterfaces; // 0x00
	
		// Constructors
		static HEU_InputUtility(); // 0x0000000189DB156C-0x0000000189DB15F8
	
		// Methods
		public static int GetHighestPriority(); // 0x0000000189DB0CD4-0x0000000189DB0D78
		public static void RegisterInputInterface(HEU_InputInterface inputInterface); // 0x0000000189DB1078-0x0000000189DB1278
		public static void UnregisterInputInterface(HEU_InputInterface inputInterface); // 0x0000000189DB1278-0x0000000189DB12E8
		public static HEU_InputInterface GetInputInterfaceByType(System.Type type); // 0x0000000189DB0D78-0x0000000189DB0EA4
		public static HEU_InputInterface GetInputInterface(GameObject inputObject); // 0x0000000189DB0F70-0x0000000189DB1078
		internal static HEU_InputInterface GetInputInterface(HEU_InputObjectInfo inputObjectInfo); // 0x0000000189DB0EA4-0x0000000189DB0F70
		internal static bool CreateInputNodeWithMultiObjects(HEU_SessionBase session, int assetID, ref int connectMergeID, ref List<HEU_InputObjectInfo> inputObjects, ref List<int> inputObjectsConnectedAssetIDs, HEU_InputNode inputNode); // 0x0000000189DB0A20-0x0000000189DB0B78
		internal static bool CreateInputNodeWithMultiAssets(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, ref int connectMergeID, ref List<HEU_InputHDAInfo> inputAssetInfos, bool bKeepWorldTransform, int mergeParentID = -1 /* Metadata: 0x023334DE */); // 0x0000000189DB0964-0x0000000189DB0A20
		internal static bool UploadInputObjectTransform(HEU_SessionBase session, HEU_InputObjectInfo inputObject, int inputNodeID, bool bKeepWorldTransform); // 0x0000000189DB12E8-0x0000000189DB156C
		public static void GetChildrenTransforms(Transform transform, ref List<Matrix4x4> childTransforms); // 0x0000000189DB0B78-0x0000000189DB0CD4
	}

	public class HEU_Logger // TypeDefIndex: 53222
	{
		// Constructors
		public HEU_Logger(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void Log(string text); // 0x0000000189DB18D4-0x0000000189DB1920
		public static void LogFormat(string text, params object[] args); // 0x0000000189DB1730-0x0000000189DB178C
		public static void LogWarning(string text); // 0x0000000189DB1888-0x0000000189DB18D4
		public static void LogWarningFormat(string text, params object[] args); // 0x0000000189DB1828-0x0000000189DB1888
		public static void LogError(string text); // 0x0000000189DB1668-0x0000000189DB16B4
		public static void LogErrorFormat(string text, params object[] args); // 0x0000000189DB1608-0x0000000189DB1668
		public static void LogError(Exception ex); // 0x0000000189DB16B4-0x0000000189DB1730
		public static void LogAssertion(string text); // 0x0000000189DB1600-0x0000000189DB1608
		public static void LogAssertionFormat(string text, params object[] args); // 0x0000000189DB15F8-0x0000000189DB1600
		private static void LogToCookLogsIfOn(string text); // 0x0000000189DB17E8-0x0000000189DB1828
		private static void LogToCookLogsIfOnFormat(string text, params object[] args); // 0x0000000189DB178C-0x0000000189DB17E8
	}

	public class HEU_MeshData // TypeDefIndex: 53223
	{
		// Fields
		public List<int> _indices; // 0x10
		public List<Vector3> _vertices; // 0x18
		public List<Color32> _colors; // 0x20
		public List<Vector3> _normals; // 0x28
		public List<Vector4> _tangents; // 0x30
		public List<Vector4>[] _uvs; // 0x38
		public List<Vector3> _triangleNormals; // 0x40
		public Dictionary<int, int> _pointIndexToMeshIndexMap; // 0x48
		public MeshTopology _meshTopology; // 0x50
	
		// Constructors
		public HEU_MeshData(); // 0x0000000189DB1920-0x0000000189DB1B58
	}

	[Serializable]
	public class HEU_MeshIndexFormat // TypeDefIndex: 53224
	{
		// Fields
		public IndexFormat _indexFormat; // 0x10
	
		// Constructors
		public HEU_MeshIndexFormat(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void CalculateIndexFormat(int numVertices); // 0x0000000189DB1B58-0x0000000189DB1BB4
		public void SetFormatForMesh(Mesh mesh); // 0x0000000189DB1BB4-0x0000000189DB1BD8
	}

	public enum HEU_PipelineType // TypeDefIndex: 53225
	{
		Unsupported = 0,
		BiRP = 1,
		URP = 2,
		HDRP = 3
	}

	public class HEU_RenderingPipelineDefines // TypeDefIndex: 53226
	{
		// Constructors
		static HEU_RenderingPipelineDefines(); // 0x0000000189DB1F50-0x0000000189DB1F58
		public HEU_RenderingPipelineDefines(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static void UpdateDefines(); // 0x0000000189DB1E8C-0x0000000189DB1F50
		public static HEU_PipelineType GetPipeline(); // 0x0000000189DB1CDC-0x0000000189DB1DE8
		private static void AddDefine(string define); // 0x0000000189DB1BD8-0x0000000189DB1C7C
		public static void RemoveDefine(string define); // 0x0000000189DB1DE8-0x0000000189DB1E8C
		public static List<string> GetDefines(); // 0x0000000189DB1C7C-0x0000000189DB1CDC
		public static void SetDefines(List<string> definesList); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class HEU_SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ISerializationCallbackReceiver // TypeDefIndex: 53227
	{
		// Fields
		[NonSerialized]
		private Dictionary<TKey, TValue> _dictionary;
		[SerializeField]
		private TKey[] _keys;
		[SerializeField]
		private TValue[] _values;
	
		// Properties
		public TValue this[TKey key] { get => default; set {} }
		public ICollection<TKey> Keys { get; }
		public ICollection<TValue> Values { get; }
		public int Count { get; }
		public bool IsReadOnly { get; }
	
		// Constructors
		public HEU_SerializableDictionary();
	
		// Methods
		public void Add(TKey key, TValue value);
		public void Add(KeyValuePair<TKey, TValue> item);
		public void Clear();
		public bool Contains(KeyValuePair<TKey, TValue> item);
		public bool ContainsKey(TKey key);
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
		public bool Remove(TKey key);
		public bool Remove(KeyValuePair<TKey, TValue> item);
		public bool TryGetValue(TKey key, out ref TValue value);
		IEnumerator IEnumerable.GetEnumerator();
		public void OnAfterDeserialize();
		public void OnBeforeSerialize();
	}

	[Serializable]
	public class HEU_ShelfToolData // TypeDefIndex: 53229
	{
		// Fields
		public string _name; // 0x10
		public ToolType _toolType; // 0x18
		public string _toolTip; // 0x20
		public string _iconPath; // 0x28
		public string _assetPath; // 0x30
		public string _helpURL; // 0x38
		public string[] _targets; // 0x40
		public string _jsonPath; // 0x48
	
		// Nested types
		public enum ToolType // TypeDefIndex: 53228
		{
			GENERATOR = 0,
			OPERATOR_SINGLE = 1,
			OPERATOR_MULTI = 2,
			BATCH = 3
		}
	
		// Constructors
		public HEU_ShelfToolData(); // 0x0000000189DB1F58-0x0000000189DB1FFC
	}

	[Serializable]
	public class HEU_Shelf // TypeDefIndex: 53230
	{
		// Fields
		public string _shelfName; // 0x10
		public string _shelfPath; // 0x18
		public bool _defaultShelf; // 0x20
		public List<HEU_ShelfToolData> _tools; // 0x28
	
		// Constructors
		public HEU_Shelf(); // 0x0000000189DB5398-0x0000000189DB5410
	}

	public class HEU_ShelfTools // TypeDefIndex: 53232
	{
		// Fields
		[SerializeField]
		private static List<HEU_Shelf> _shelves; // 0x00
		[SerializeField]
		private static bool _shelvesLoaded; // 0x08
		[SerializeField]
		private static int _currentSelectedShelf; // 0x0C
		public const string TARGET_ALL = "all"; // Metadata: 0x023334E7
		public const string TARGET_UNITY = "unity"; // Metadata: 0x023334EB
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 53231
		{
			// Fields
			public string shelfName; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddShelf_b__0(HEU_Shelf shelf); // 0x0000000186CC7538-0x0000000186CC7560
		}
	
		// Constructors
		public HEU_ShelfTools(); // 0x00000001841E1670-0x00000001841E1680
		static HEU_ShelfTools(); // 0x0000000189DB52F8-0x0000000189DB5398
	
		// Methods
		public static bool AreShelvesLoaded(); // 0x0000000189DB219C-0x0000000189DB21EC
		public static void SetReloadShelves(); // 0x0000000189DB5228-0x0000000189DB5278
		public static void ClearShelves(); // 0x0000000189DB21EC-0x0000000189DB2250
		public static int GetNumShelves(); // 0x0000000189DB320C-0x0000000189DB3268
		public static int GetCurrentShelfIndex(); // 0x0000000189DB31BC-0x0000000189DB320C
		public static void SetCurrentShelf(int index); // 0x0000000189DB51D4-0x0000000189DB5228
		public static HEU_Shelf GetShelf(int index); // 0x0000000189DB3410-0x0000000189DB34B4
		public static HEU_Shelf GetShelf(string shelfName); // 0x0000000189DB32B4-0x0000000189DB3410
		public static string GetShelfStorageEntry(string shelfName, string shelfPath); // 0x0000000189DB3268-0x0000000189DB32B4
		public static void GetSplitShelfEntry(string shelfEntry, out string shelfName, out string shelfPath); // 0x0000000189DB34B4-0x0000000189DB3594
		public static void LoadShelves(); // 0x0000000189DB3B48-0x0000000189DB4224
		public static bool LoadToolsFromDirectory(string folderPath, out List<HEU_ShelfToolData> tools); // 0x0000000189DB4C6C-0x0000000189DB4E90
		public static HEU_ShelfToolData LoadToolFromJsonFile(string jsonFilePath); // 0x0000000189DB4224-0x0000000189DB43C0
		public static HEU_ShelfToolData LoadToolFromJsonString(string json, string jsonFilePath); // 0x0000000189DB43C0-0x0000000189DB4C6C
		public static HEU_Shelf AddShelf(string shelfName, string shelfPath); // 0x0000000189DB1FFC-0x0000000189DB219C
		public static void RemoveShelf(int shelfIndex); // 0x0000000189DB4E90-0x0000000189DB4FC0
		public static void SaveShelf(); // 0x0000000189DB4FC0-0x0000000189DB51D4
		public static void ExecuteTool(int toolSlot); // 0x0000000189DB2F14-0x0000000189DB31BC
		public static void ExecuteToolGenerator(string toolName, string toolPath, Vector3 targetPosition, Quaternion targetRotation, Vector3 targetScale); // 0x0000000189DB22B0-0x0000000189DB244C
		public static bool IsValidInputMesh(GameObject gameObject); // 0x0000000189DB39B8-0x0000000189DB3B48
		public static bool IsValidInputHDA(GameObject gameObject); // 0x0000000189DB3928-0x0000000189DB39B8
		private static bool ShouldUseHDA(GameObject[] gameObjectList); // 0x0000000189DB5278-0x0000000189DB52F8
		public static void ExecuteToolNoInput(string toolName, string toolPath); // 0x0000000189DB244C-0x0000000189DB2580
		public static void ExecuteToolOperatorSingle(string toolName, string toolPath, GameObject[] inputObjects); // 0x0000000189DB299C-0x0000000189DB2F14
		public static void ExecuteToolOperatorMultiple(string toolName, string toolPath, GameObject[] inputObjects); // 0x0000000189DB2580-0x0000000189DB299C
		public static void ExecuteToolBatch(string toolName, string toolPath, GameObject[] batchObjects); // 0x0000000189DB2250-0x0000000189DB22B0
		public static string GetToolResourcePath(HEU_ShelfToolData tool, string inPath, string ext); // 0x0000000189DB386C-0x0000000189DB3928
		public static string GetToolIconPath(HEU_ShelfToolData tool, string inPath); // 0x0000000189DB3704-0x0000000189DB386C
		public static string GetToolAssetPath(HEU_ShelfToolData tool, string inPath); // 0x0000000189DB3594-0x0000000189DB3704
	}

	public enum JSONNodeType // TypeDefIndex: 53233
	{
		Array = 1,
		Object = 2,
		String = 3,
		Number = 4,
		NullValue = 5,
		Boolean = 6,
		None = 7,
		Custom = 255
	}

	public enum JSONTextMode // TypeDefIndex: 53234
	{
		Compact = 0,
		Indent = 1
	}

	public abstract class JSONNode // TypeDefIndex: 53242
	{
		// Fields
		public static bool forceASCII; // 0x00
		public static bool longAsString; // 0x01
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder; // 0x80000000
		public static JSONContainerType VectorContainerType; // 0x04
		public static JSONContainerType QuaternionContainerType; // 0x08
		public static JSONContainerType RectContainerType; // 0x0C
	
		// Properties
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		public virtual string Value { get; set; } // 0x0000000189DB7C0C-0x0000000189DB7C38 0x00000001841E1670-0x00000001841E1680
		public virtual int Count { get; } // 0x00000001811EC580-0x00000001811EC590 
		public virtual bool IsNumber { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsString { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsBoolean { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsNull { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsArray { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool IsObject { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool Inline { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__40))] get; } // 0x0000000189DB7980-0x0000000189DB79D4 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine(typeof(_get_DeepChildren_d__42))] get; } // 0x0000000189DB79D4-0x0000000189DB7A44 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x0000000189DB7BAC-0x0000000189DB7C0C 
		public KeyEnumerator Keys { get; } // 0x0000000189DB7AF8-0x0000000189DB7BAC 
		public ValueEnumerator Values { get; } // 0x0000000189DB7AF8-0x0000000189DB7BAC 
		public virtual double AsDouble { get; set; } // 0x0000000189DB7840-0x0000000189DB78CC 0x0000000189DB85E8-0x0000000189DB864C
		public virtual int AsInt { get; set; } // 0x0000000189DB78E8-0x0000000189DB7904 0x0000000189DB8660-0x0000000189DB8678
		public virtual float AsFloat { get; set; } // 0x0000000189DB78CC-0x0000000189DB78E8 0x0000000189DB864C-0x0000000189DB8660
		public virtual bool AsBool { get; set; } // 0x0000000189DB77A4-0x0000000189DB7840 0x0000000189DB857C-0x0000000189DB85E8
		public virtual long AsLong { get; set; } // 0x0000000189DB7904-0x0000000189DB7944 0x0000000189DB8678-0x0000000189DB86A8
		public virtual JSONArray AsArray { get; } // 0x0000000189DB7768-0x0000000189DB77A4 
		public virtual JSONObject AsObject { get; } // 0x0000000189DB7944-0x0000000189DB7980 
		internal static StringBuilder EscapeBuilder { get; } // 0x0000000189DB7A44-0x0000000189DB7AF8 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 53236
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get; } // 0x00000001868B8E74-0x00000001868B8E7C 
			public KeyValuePair<string, JSONNode> Current { get; } // 0x0000000189DB8818-0x0000000189DB88BC 
	
			// Nested types
			private enum Type // TypeDefIndex: 53235
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum); // 0x0000000189DB87E4-0x0000000189DB8818
			public Enumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000184B0C3F0-0x0000000184B0C440
	
			// Methods
			public bool MoveNext(); // 0x0000000189DB8774-0x0000000189DB87E4
		}
	
		public struct ValueEnumerator // TypeDefIndex: 53237
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get; } // 0x0000000189DCBB70-0x0000000189DCBBB0 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum); // 0x0000000189DC2BA0-0x0000000189DC2C38
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000189DC2ACC-0x0000000189DC2B6C
			public ValueEnumerator(Enumerator aEnumerator); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
			// Methods
			public bool MoveNext(); // 0x0000000189DC2AC4-0x0000000189DC2ACC
			public ValueEnumerator GetEnumerator(); // 0x0000000184DA2D60-0x0000000184DA2D90
		}
	
		public struct KeyEnumerator // TypeDefIndex: 53238
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get; } // 0x0000000189DC2C38-0x0000000189DC2C78 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum); // 0x0000000189DC2BA0-0x0000000189DC2C38
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000189DC2ACC-0x0000000189DC2B6C
			public KeyEnumerator(Enumerator aEnumerator); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
			// Methods
			public bool MoveNext(); // 0x0000000189DC2AC4-0x0000000189DC2ACC
			public KeyEnumerator GetEnumerator(); // 0x0000000184DA2D60-0x0000000184DA2D90
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 53239
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get; } // 0x0000000189DC2EC8-0x0000000189DC2EF4 
			object IEnumerator.Current { get; } // 0x0000000189DC2DF4-0x0000000189DC2E4C 
	
			// Constructors
			internal LinqEnumerator(JSONNode aNode); // 0x0000000189DC2E4C-0x0000000189DC2EC8
	
			// Methods
			public bool MoveNext(); // 0x0000000189DC2D18-0x0000000189DC2D24
			public void Dispose(); // 0x0000000189DC2C78-0x0000000189DC2CB4
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator(); // 0x0000000189DC2CB4-0x0000000189DC2D18
			public void Reset(); // 0x0000000189DC2D24-0x0000000189DC2D90
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189DC2D90-0x0000000189DC2DF4
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__40 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 53240
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__40(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184D83CA0-0x0000000184D83CB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DCB4CC-0x0000000189DCB518
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000189DCB44C-0x0000000189DCB4C4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189DCB4C4-0x0000000189DCB4CC
		}
	
		[CompilerGenerated]
		private sealed class _get_DeepChildren_d__42 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 53241
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONNode __4__this; // 0x28
			private IEnumerator<JSONNode> __7__wrap1; // 0x30
			private IEnumerator<JSONNode> __7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_DeepChildren_d__42(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000189DCB9F0-0x0000000189DCBADC
			private bool MoveNext(); // 0x0000000189DCB518-0x0000000189DCB910
			private void __m__Finally1(); // 0x0000000189DCBADC-0x0000000189DCBB24
			private void __m__Finally2(); // 0x0000000189DCBB24-0x0000000189DCBB70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DCB9A4-0x0000000189DCB9F0
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000189DCB910-0x0000000189DCB99C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189DCB99C-0x0000000189DCB9A4
		}
	
		// Constructors
		protected JSONNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem); // 0x00000001841E1670-0x00000001841E1680
		public virtual void Add(JSONNode aItem); // 0x0000000189DB5410-0x0000000189DB5458
		public virtual JSONNode Remove(string aKey); // 0x00000001811EC580-0x00000001811EC590
		public virtual JSONNode Remove(int aIndex); // 0x00000001811EC580-0x00000001811EC590
		public virtual JSONNode Remove(JSONNode aNode); // 0x0000000184D88C30-0x0000000184D88C40
		public override string ToString(); // 0x0000000189DB6BEC-0x0000000189DB6C70
		public virtual string ToString(int aIndent); // 0x0000000189DB6C70-0x0000000189DB6D00
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s); // 0x0000000189DB7D60-0x0000000189DB7DC0
		public static implicit operator string(JSONNode d); // 0x0000000189DB8234-0x0000000189DB8274
		public static implicit operator JSONNode(double n); // 0x0000000189DB8360-0x0000000189DB83B0
		public static implicit operator double(JSONNode d); // 0x0000000189DB7D20-0x0000000189DB7D60
		public static implicit operator JSONNode(float n); // 0x0000000189DB8274-0x0000000189DB82CC
		public static implicit operator float(JSONNode d); // 0x0000000189DB84F0-0x0000000189DB8530
		public static implicit operator JSONNode(int n); // 0x0000000189DB7E38-0x0000000189DB7E88
		public static implicit operator int(JSONNode d); // 0x0000000189DB80EC-0x0000000189DB812C
		public static implicit operator JSONNode(long n); // 0x0000000189DB7ED0-0x0000000189DB7F90
		public static implicit operator long(JSONNode d); // 0x0000000189DB84B0-0x0000000189DB84F0
		public static implicit operator JSONNode(bool b); // 0x0000000189DB7E88-0x0000000189DB7ED0
		public static implicit operator bool(JSONNode d); // 0x0000000189DB82E8-0x0000000189DB8328
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue); // 0x0000000189DB8328-0x0000000189DB8360
		public static bool operator ==(JSONNode a, object b); // 0x0000000189DB7C38-0x0000000189DB7D20
		public static bool operator !=(JSONNode a, object b); // 0x0000000189DB8568-0x0000000189DB857C
		public override bool Equals(object obj); // 0x0000000182FB1840-0x0000000182FB1850
		public override int GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
		internal static string Escape(string aText); // 0x0000000189DB5458-0x0000000189DB56C0
		private static JSONNode ParseElement(string token, bool quoted); // 0x0000000189DB5744-0x0000000189DB5898
		public static JSONNode Parse(string aJSON); // 0x0000000189DB5898-0x0000000189DB5E28
		private static JSONNode GetContainer(JSONContainerType aType); // 0x0000000189DB56C0-0x0000000189DB5744
		public static implicit operator JSONNode(Vector2 aVec); // 0x0000000189DB7F90-0x0000000189DB802C
		public static implicit operator JSONNode(Vector3 aVec); // 0x0000000189DB802C-0x0000000189DB80EC
		public static implicit operator JSONNode(Vector4 aVec); // 0x0000000189DB7DC0-0x0000000189DB7E38
		public static implicit operator JSONNode(Quaternion aRot); // 0x0000000189DB841C-0x0000000189DB8494
		public static implicit operator JSONNode(Rect aRect); // 0x0000000189DB81BC-0x0000000189DB8234
		public static implicit operator JSONNode(RectOffset aRect); // 0x0000000189DB83B0-0x0000000189DB841C
		public static implicit operator Vector2(JSONNode aNode); // 0x0000000189DB8494-0x0000000189DB84B0
		public static implicit operator Vector3(JSONNode aNode); // 0x0000000189DB8530-0x0000000189DB8568
		public static implicit operator Vector4(JSONNode aNode); // 0x0000000189DB818C-0x0000000189DB81BC
		public static implicit operator Quaternion(JSONNode aNode); // 0x0000000189DB812C-0x0000000189DB815C
		public static implicit operator Rect(JSONNode aNode); // 0x0000000189DB815C-0x0000000189DB818C
		public static implicit operator RectOffset(JSONNode aNode); // 0x0000000189DB82CC-0x0000000189DB82E8
		public Vector2 ReadVector2(Vector2 aDefault); // 0x0000000189DB6580-0x0000000189DB6668
		public Vector2 ReadVector2(string aXName, string aYName); // 0x0000000189DB6668-0x0000000189DB6708
		public Vector2 ReadVector2(); // 0x0000000189DB6708-0x0000000189DB6720
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x023334FC */, string aYName = "y" /* Metadata: 0x023334FE */); // 0x0000000189DB7364-0x0000000189DB745C
		public Vector3 ReadVector3(Vector3 aDefault); // 0x0000000189DB6720-0x0000000189DB689C
		public Vector3 ReadVector3(string aXName, string aYName, string aZName); // 0x0000000189DB689C-0x0000000189DB6984
		public Vector3 ReadVector3(); // 0x0000000189DB6984-0x0000000189DB69D4
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x02333500 */, string aYName = "y" /* Metadata: 0x02333502 */, string aZName = "z" /* Metadata: 0x02333504 */); // 0x0000000189DB745C-0x0000000189DB759C
		public Vector4 ReadVector4(Vector4 aDefault); // 0x0000000189DB69D4-0x0000000189DB6BB0
		public Vector4 ReadVector4(); // 0x0000000189DB6BB0-0x0000000189DB6BEC
		public JSONNode WriteVector4(Vector4 aVec); // 0x0000000189DB759C-0x0000000189DB7768
		public Quaternion ReadQuaternion(Quaternion aDefault); // 0x0000000189DB5F18-0x0000000189DB60F4
		public Quaternion ReadQuaternion(); // 0x0000000189DB5EDC-0x0000000189DB5F18
		public JSONNode WriteQuaternion(Quaternion aRot); // 0x0000000189DB6D94-0x0000000189DB6F60
		public Rect ReadRect(Rect aDefault); // 0x0000000189DB63A4-0x0000000189DB6580
		public Rect ReadRect(); // 0x0000000189DB6370-0x0000000189DB63A4
		public JSONNode WriteRect(Rect aRect); // 0x0000000189DB7198-0x0000000189DB7364
		public RectOffset ReadRectOffset(RectOffset aDefault); // 0x0000000189DB60F4-0x0000000189DB6308
		public RectOffset ReadRectOffset(); // 0x0000000189DB6308-0x0000000189DB6370
		public JSONNode WriteRectOffset(RectOffset aRect); // 0x0000000189DB6F60-0x0000000189DB7198
		public Matrix4x4 ReadMatrix(); // 0x0000000189DB5E28-0x0000000189DB5EDC
		public JSONNode WriteMatrix(Matrix4x4 aMatrix); // 0x0000000189DB6D00-0x0000000189DB6D94
	}

	public class JSONArray : JSONNode // TypeDefIndex: 53244
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public override JSONNodeType Tag { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public override bool IsArray { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000189DC0A88-0x0000000189DC0B28 0x0000000189DC0B28-0x0000000189DC0BFC
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000189DC0A28-0x0000000189DC0A88 0x0000000189DC0BFC-0x0000000189DC0C84
		public override int Count { get; } // 0x0000000189DC09E8-0x0000000189DC0A28 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__22))] get; } // 0x0000000189DC0978-0x0000000189DC09E8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_Children_d__22 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 53243
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONArray __4__this; // 0x28
			private List<JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__22(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000189DCAF90-0x0000000189DCB008
			private bool MoveNext(); // 0x0000000189DCAC68-0x0000000189DCAEB0
			private void __m__Finally1(); // 0x0000000189DCB008-0x0000000189DCB044
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DCAF44-0x0000000189DCAF90
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000189DCAEB0-0x0000000189DCAF3C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189DCAF3C-0x0000000189DCAF44
		}
	
		// Constructors
		public JSONArray(); // 0x0000000189DC0900-0x0000000189DC0978
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000189DC0614-0x0000000189DC06A4
		public override void Add(string aKey, JSONNode aItem); // 0x0000000189DC058C-0x0000000189DC0614
		public override JSONNode Remove(int aIndex); // 0x0000000189DC06A4-0x0000000189DC0748
		public override JSONNode Remove(JSONNode aNode); // 0x0000000189DC0748-0x0000000189DC07A0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC07A0-0x0000000189DC0900
	}

	public class JSONObject : JSONNode // TypeDefIndex: 53247
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public override JSONNodeType Tag { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public override bool IsObject { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000189DC268C-0x0000000189DC274C 0x0000000189DC27D8-0x0000000189DC28C0
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000189DC274C-0x0000000189DC27D8 0x0000000189DC28C0-0x0000000189DC29AC
		public override int Count { get; } // 0x0000000189DC264C-0x0000000189DC268C 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__23))] get; } // 0x0000000189DC25DC-0x0000000189DC264C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 53245
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Remove_b__0(KeyValuePair<string, JSONNode> k); // 0x0000000189DCA518-0x0000000189DCA560
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__23 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 53246
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONObject __4__this; // 0x28
			private Dictionary<string, JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__23(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000189DCB398-0x0000000189DCB410
			private bool MoveNext(); // 0x0000000189DCB044-0x0000000189DCB2B8
			private void __m__Finally1(); // 0x0000000189DCB410-0x0000000189DCB44C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DCB34C-0x0000000189DCB398
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000189DCB2B8-0x0000000189DCB344
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189DCB344-0x0000000189DCB34C
		}
	
		// Constructors
		public JSONObject(); // 0x0000000189DC2564-0x0000000189DC25DC
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000189DC1E74-0x0000000189DC1F18
		public override void Add(string aKey, JSONNode aItem); // 0x0000000189DC1D28-0x0000000189DC1E74
		public override JSONNode Remove(string aKey); // 0x0000000189DC2184-0x0000000189DC223C
		public override JSONNode Remove(int aIndex); // 0x0000000189DC1F18-0x0000000189DC1FD8
		public override JSONNode Remove(JSONNode aNode); // 0x0000000189DC1FD8-0x0000000189DC2184
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC223C-0x0000000189DC2564
	}

	public class JSONString : JSONNode // TypeDefIndex: 53248
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D8C9E0-0x0000000184D8C9F0 
		public override bool IsString { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public JSONString(string aData); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC2A50-0x0000000189DC2ABC
		public override bool Equals(object obj); // 0x0000000189DC29AC-0x0000000189DC2A50
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 53249
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public override bool IsNumber { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x0000000189DC1C5C-0x0000000189DC1CA8 0x0000000189DC1CA8-0x0000000189DC1D28
		public override double AsDouble { get; set; } // 0x0000000184D96320-0x0000000184D96330 0x0000000184D85BA0-0x0000000184D85BB0
		public override long AsLong { get; set; } // 0x0000000184DA2D40-0x0000000184DA2D50 0x0000000184DA2D50-0x0000000184DA2D60
	
		// Constructors
		public JSONNumber(double aData); // 0x0000000184D85BA0-0x0000000184D85BB0
		public JSONNumber(string aData); // 0x0000000189DC0D94-0x0000000189DC0DA8
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC1C28-0x0000000189DC1C5C
		private static bool IsNumeric(object value); // 0x0000000189DC1AE0-0x0000000189DC1C28
		public override bool Equals(object obj); // 0x0000000189DC1A00-0x0000000189DC1AD4
		public override int GetHashCode(); // 0x0000000189DC1AD4-0x0000000189DC1AE0
	}

	public class JSONBool : JSONNode // TypeDefIndex: 53250
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D9EC60-0x0000000184D9EC70 
		public override bool IsBoolean { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x0000000189DC0DA8-0x0000000189DC0DFC 0x0000000189DC0DFC-0x0000000189DC0E60
		public override bool AsBool { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
	
		// Constructors
		public JSONBool(bool aData); // 0x0000000184D86130-0x0000000184D86140
		public JSONBool(string aData); // 0x0000000189DC0D94-0x0000000189DC0DA8
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC0D28-0x0000000189DC0D94
		public override bool Equals(object obj); // 0x0000000189DC0C84-0x0000000189DC0CE0
		public override int GetHashCode(); // 0x0000000189DC0CE0-0x0000000189DC0D28
	}

	public class JSONNull : JSONNode // TypeDefIndex: 53251
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
		public override bool IsNull { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override string Value { get; set; } // 0x0000000189DC19D4-0x0000000189DC1A00 0x00000001841E1670-0x00000001841E1680
		public override bool AsBool { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
	
		// Constructors
		private JSONNull(); // 0x00000001841E1670-0x00000001841E1680
		static JSONNull(); // 0x0000000189DC195C-0x0000000189DC19D4
	
		// Methods
		public static JSONNull CreateOrGet(); // 0x0000000189DC1850-0x0000000189DC18BC
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		public override bool Equals(object obj); // 0x0000000189DC18BC-0x0000000189DC1914
		public override int GetHashCode(); // 0x00000001811EC580-0x00000001811EC590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC1914-0x0000000189DC195C
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 53252
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000184D9BE00-0x0000000184D9BE10 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000189DC1368-0x0000000189DC13C8 0x0000000189DC1718-0x0000000189DC17AC
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000189DC13C8-0x0000000189DC1438 0x0000000189DC17AC-0x0000000189DC1850
		public override int AsInt { get; set; } // 0x0000000189DC11A0-0x0000000189DC1208 0x0000000189DC15A4-0x0000000189DC161C
		public override float AsFloat { get; set; } // 0x0000000189DC1138-0x0000000189DC11A0 0x0000000189DC152C-0x0000000189DC15A4
		public override double AsDouble { get; set; } // 0x0000000189DC10D0-0x0000000189DC1138 0x0000000189DC14B8-0x0000000189DC152C
		public override long AsLong { get; set; } // 0x0000000189DC1208-0x0000000189DC12F0 0x0000000189DC161C-0x0000000189DC1718
		public override bool AsBool { get; set; } // 0x0000000189DC1068-0x0000000189DC10D0 0x0000000189DC1448-0x0000000189DC14B8
		public override JSONArray AsArray { get; } // 0x0000000189DC0FF0-0x0000000189DC1068 
		public override JSONObject AsObject { get; } // 0x0000000189DC12F0-0x0000000189DC1368 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x0000000183E8CD90-0x0000000183E8CDC0
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x00000001832AF420-0x00000001832AF450
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000184DA2D20-0x0000000184DA2D40
		private T Set<T>(T aVal)
			where T : JSONNode;
		public override void Add(JSONNode aItem); // 0x0000000189DC0F04-0x0000000189DC0F98
		public override void Add(string aKey, JSONNode aItem); // 0x0000000189DC0E60-0x0000000189DC0F04
		public static bool operator ==(JSONLazyCreator a, object b); // 0x0000000189DC0F98-0x0000000189DC0FA8
		public static bool operator !=(JSONLazyCreator a, object b); // 0x0000000189DC1438-0x0000000189DC1448
		public override bool Equals(object obj); // 0x0000000189DC0F98-0x0000000189DC0FA8
		public override int GetHashCode(); // 0x00000001811EC580-0x00000001811EC590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000189DC0FA8-0x0000000189DC0FF0
	}

	public static class JSON // TypeDefIndex: 53253
	{
		// Methods
		public static JSONNode Parse(string aJSON); // 0x0000000189DC2ABC-0x0000000189DC2AC4
	}

	public enum JSONContainerType // TypeDefIndex: 53254
	{
		Array = 0,
		Object = 1
	}

	public static class HEU_TerrainUtility // TypeDefIndex: 53255
	{
		// Methods
		public static bool GenerateTerrainFromVolume(HEU_SessionBase session, ref HAPI_VolumeInfo volumeInfo, int geoID, int partID, GameObject gameObject, ref TerrainData terrainData, out Vector3 volumePositionOffset, ref Terrain terrain, string bakedMaterialPath); // 0x0000000189DB9884-0x0000000189DBA1C0
		public static void SetTerrainMaterial(Terrain terrain, string specifiedMaterialName, string bakedMaterialPath = "" /* Metadata: 0x0233350B */); // 0x0000000189DBC14C-0x0000000189DBC2B8
		public static string GetDefaultTerrainShaderName(); // 0x0000000189DBA2B0-0x0000000189DBA330
		public static string GetDefaultTerrainMaterialPath(); // 0x0000000189DBA230-0x0000000189DBA2B0
		public static float[] GetNormalizedHeightmapFromPartWithMinMax(HEU_SessionBase session, int geoID, int partID, int heightMapWidth, int heightMapHeight, ref float minHeight, ref float maxHeight, ref float heightRange, bool bUseHeightRangeOverride); // 0x0000000189DBA6E8-0x0000000189DBA768
		public static int[,] GetDetailMapFromPart(HEU_SessionBase session, int geoID, int partID, out int detailResolution); // 0x0000000189DBA330-0x0000000189DBA3C0
		public static bool GetHeightmapFromPart(HEU_SessionBase session, int xLength, int yLength, int geoID, int partID, ref float[] heightValues, ref float minHeight, ref float maxHeight); // 0x0000000189DBA570-0x0000000189DBA6E8
		public static float[,] ConvertHeightMapHoudiniToUnity(int heightMapWidth, int heightMapHeight, float[] heightValues); // 0x0000000189DB97A8-0x0000000189DB9884
		public static float[,,] ConvertHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, List<float[]> heightFields); // 0x0000000189DB9664-0x0000000189DB97A8
		public static float[,,] AppendConvertedHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, float[,,] existingAlphaMaps, List<float[]> heightFields, float[] strengths, List<int> alphaMapIndices); // 0x0000000189DB8BA0-0x0000000189DB8D98
		public static Vector3 GetVolumePositionOffset(HEU_SessionBase session, int geoID, int partID, Vector3 volumePosition, float terrainSizeX, float heightMapSize, int mapWidth, int mapHeight, float minHeight); // 0x0000000189DBAB28-0x0000000189DBAC14
		public static List<HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HEU_SessionBase session, int geoID, int partID); // 0x0000000189DBAA34-0x0000000189DBAB28
		public static void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, ref HEU_VolumeScatterTrees scatterTrees, bool throwWarningIfNoTileAttribute); // 0x0000000189DBB308-0x0000000189DBBEB4
		public static void ApplyScatterTrees(TerrainData terrainData, HEU_VolumeScatterTrees scatterTrees, int tileIndex); // 0x0000000189DB9178-0x0000000189DB9664
		public static void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailPrototype detailPrototype); // 0x0000000189DBAEE4-0x0000000189DBB308
		public static void PopulateDetailProperties(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailProperties detailProperties); // 0x0000000189DBAC14-0x0000000189DBAEE4
		public static void ApplyDetailLayers(Terrain terrain, TerrainData terrainData, HEU_DetailProperties detailProperties, List<HEU_DetailPrototype> heuDetailPrototypes, List<int[,]> convertedDetailMaps); // 0x0000000189DB8D98-0x0000000189DB9178
		private static int GetTerrainLayerIndexByName(string layerName, TerrainLayer[] terrainLayers); // 0x0000000189DBA830-0x0000000189DBA99C
		public static int GetTerrainLayerIndex(TerrainLayer layer, TerrainLayer[] terrainLayers); // 0x0000000189DBA99C-0x0000000189DBAA34
		public static bool VolumeLayerHasAttributes(HEU_SessionBase session, int geoID, int partID); // 0x0000000189DBC2B8-0x0000000189DBC448
		public static HFLayerType GetHeightfieldLayerType(HEU_SessionBase session, int geoID, int partID, string volumeName); // 0x0000000189DBA434-0x0000000189DBA570
		public static float GetHeightRangeFromHeightfield(HEU_SessionBase session, int geoID, int partID); // 0x0000000189DBA3C0-0x0000000189DBA434
		public static string GetTerrainDataExportPathFromHeightfieldAttribute(HEU_SessionBase session, int geoID, int partID); // 0x0000000189DBA768-0x0000000189DBA830
		public static float[] ResampleData(float[] data, int oldWidth, int oldHeight, int newWidth, int newHeight); // 0x0000000189DBBEB4-0x0000000189DBC14C
		public static bool GetAttributeTile(HEU_SessionBase session, int geoID, int partID, out int outTileAttribute); // 0x0000000189DBA1C0-0x0000000189DBA230
	}

	public interface IEquivable<T> // TypeDefIndex: 53256
	{
		// Methods
		bool IsEquivalentTo(T other);
	}

	public interface IEquivableWrapperClass<T> : IEquivable<T> // TypeDefIndex: 53257
		where T : class
	{
		// Methods
		bool IsNull();
	}

	internal class HEU_TestHelpers // TypeDefIndex: 53260
	{
		// Nested types
		public class RequireStruct<T> // TypeDefIndex: 53258
			where T : struct
		{
			// Constructors
			public RequireStruct();
		}
	
		public class RequireClass<T> // TypeDefIndex: 53259
			where T : class
		{
			// Constructors
			public RequireClass();
		}
	
		// Constructors
		public HEU_TestHelpers(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool AssertTrueLogEquivalent<T>(T a, T b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0233350C */, string optional2 = "" /* Metadata: 0x0233350D */, string optional3 = "" /* Metadata: 0x0233350E */, RequireStruct<T> _ = null)
			where T : struct;
		public static bool AssertTrueLogEquivalent(GameObject a, GameObject b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0233350F */, string optional2 = "" /* Metadata: 0x02333510 */, string optional3 = "" /* Metadata: 0x02333511 */); // 0x0000000189DBC5AC-0x0000000189DBC6A8
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T> a, IEquivable<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333512 */, string optional2 = "" /* Metadata: 0x02333513 */, string optional3 = "" /* Metadata: 0x02333514 */);
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333515 */, string optional2 = "" /* Metadata: 0x02333516 */, string optional3 = "" /* Metadata: 0x02333517 */)
			where T : class;
		public static bool AssertTrueLogEquivalent(string a, string b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333518 */, string optional2 = "" /* Metadata: 0x02333519 */, string optional3 = "" /* Metadata: 0x0233351A */); // 0x0000000189DBC6A8-0x0000000189DBC778
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0233351B */, string optional2 = "" /* Metadata: 0x0233351C */, string optional3 = "" /* Metadata: 0x0233351D */, RequireStruct<T> _ = null)
			where T : struct;
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0233351E */, string optional2 = "" /* Metadata: 0x0233351F */, string optional3 = "" /* Metadata: 0x02333520 */, RequireClass<T> _ = null)
			where T : class;
		public static bool AssertTrueLogEquivalent<T>(List<IEquivable<T>> a, List<IEquivable<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333521 */, string optional2 = "" /* Metadata: 0x02333522 */, string optional3 = "" /* Metadata: 0x02333523 */);
		public static bool AssertTrueLogEquivalent<T>(List<IEquivableWrapperClass<T>> a, List<IEquivableWrapperClass<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333524 */, string optional2 = "" /* Metadata: 0x02333525 */, string optional3 = "" /* Metadata: 0x02333526 */)
			where T : class;
		public static bool AssertTrueLogEquivalent<T>(T[] a, T[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333527 */, string optional2 = "" /* Metadata: 0x02333528 */, string optional3 = "" /* Metadata: 0x02333529 */)
			where T : struct;
		public static bool AssertTrueLogEquivalent(string[] a, string[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0233352A */, string optional2 = "" /* Metadata: 0x0233352B */, string optional3 = "" /* Metadata: 0x0233352C */); // 0x0000000189DBC448-0x0000000189DBC5AC
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T>[] a, IEquivable<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0233352D */, string optional2 = "" /* Metadata: 0x0233352E */, string optional3 = "" /* Metadata: 0x0233352F */);
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T>[] a, IEquivableWrapperClass<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333530 */, string optional2 = "" /* Metadata: 0x02333531 */, string optional3 = "" /* Metadata: 0x02333532 */)
			where T : class;
		public static void PrintTestLogAndSetResult(bool expression, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02333533 */, string optional2 = "" /* Metadata: 0x02333534 */, string optional3 = "" /* Metadata: 0x02333535 */); // 0x0000000189DBC778-0x0000000189DBC8BC
		public static bool ShouldBeTested<T>(T a, T b, ref bool bResult, string header = "" /* Metadata: 0x02333536 */, string subject = "" /* Metadata: 0x02333537 */)
			where T : class;
		public static bool ShouldBeTested(GameObject a, GameObject b, ref bool bResult, string header = "" /* Metadata: 0x02333538 */, string subject = "" /* Metadata: 0x02333539 */); // 0x0000000189DBC8BC-0x0000000189DBCB04
		public static bool ShouldBeTested<T>(IEquivable<T> a, IEquivable<T> b, ref bool bResult, string header = "" /* Metadata: 0x0233353A */, string subject = "" /* Metadata: 0x0233353B */);
		public static bool ShouldBeTested<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool bResult, string header = "" /* Metadata: 0x0233353C */, string subject = "" /* Metadata: 0x0233353D */)
			where T : class;
		private static bool ShouldBeTested<T>(List<T> a, List<T> b, ref bool bResult, string header = "" /* Metadata: 0x0233353E */, string subject = "" /* Metadata: 0x0233353F */);
		public static bool ShouldBeTested<T>(T[] a, T[] b, ref bool bResult, string header = "" /* Metadata: 0x02333540 */, string subject = "" /* Metadata: 0x02333541 */);
		public static bool ShouldBeTested(string a, string b, ref bool bResult, string header = "" /* Metadata: 0x02333542 */, string subject = "" /* Metadata: 0x02333543 */); // 0x0000000189DBCB04-0x0000000189DBCB98
		public static bool TestOutputObjectEquivalence(GameObject a, GameObject b); // 0x0000000189DBCB98-0x0000000189DBD1F0
	}

	public class Test_HAPI_AssetInfo : IEquivable<Test_HAPI_AssetInfo> // TypeDefIndex: 53261
	{
		// Fields
		public HAPI_AssetInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AssetInfo(HAPI_AssetInfo self); // 0x0000000184D997E0-0x0000000184D99800
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AssetInfo other); // 0x0000000189DC45F0-0x0000000189DC47CC
	}

	public static class Test_HAPI_AssetInfo_Extensions // TypeDefIndex: 53262
	{
		// Extension methods
		public static Test_HAPI_AssetInfo ToTestObject(this HAPI_AssetInfo self); // 0x0000000189DC458C-0x0000000189DC45F0
	}

	public class Test_HAPI_NodeInfo : IEquivable<Test_HAPI_NodeInfo> // TypeDefIndex: 53263
	{
		// Fields
		public HAPI_NodeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_NodeInfo(HAPI_NodeInfo self); // 0x0000000184DA2DB0-0x0000000184DA2DE0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_NodeInfo other); // 0x0000000189DC4C00-0x0000000189DC4E08
	}

	public static class Test_HAPI_NodeInfo_Extensions // TypeDefIndex: 53264
	{
		// Extension methods
		public static Test_HAPI_NodeInfo ToTestObject(this HAPI_NodeInfo self); // 0x0000000189DC4B90-0x0000000189DC4C00
	}

	public class Test_HAPI_ObjectInfo : IEquivable<Test_HAPI_ObjectInfo> // TypeDefIndex: 53265
	{
		// Fields
		public HAPI_ObjectInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ObjectInfo(HAPI_ObjectInfo self); // 0x0000000184D99850-0x0000000184D99870
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ObjectInfo other); // 0x0000000189DC4E68-0x0000000189DC4F94
	}

	public static class Test_HAPI_ObjectInfo_Extensions // TypeDefIndex: 53266
	{
		// Extension methods
		public static Test_HAPI_ObjectInfo ToTestObject(this HAPI_ObjectInfo self); // 0x0000000189DC4E08-0x0000000189DC4E68
	}

	public class Test_HAPI_Transform : IEquivable<Test_HAPI_Transform> // TypeDefIndex: 53267
	{
		// Fields
		public HAPI_Transform self; // 0x10
	
		// Constructors
		public Test_HAPI_Transform(HAPI_Transform self); // 0x0000000189DC5750-0x0000000189DC5774
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_Transform other); // 0x0000000189DC57F4-0x0000000189DC5888
	}

	public static class Test_HAPI_Transform_Extensions // TypeDefIndex: 53268
	{
		// Extension methods
		public static Test_HAPI_Transform ToTestObject(this HAPI_Transform self); // 0x0000000189DC5774-0x0000000189DC57F4
	}

	public class Test_HAPI_GeoInfo : IEquivable<Test_HAPI_GeoInfo> // TypeDefIndex: 53269
	{
		// Fields
		public HAPI_GeoInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_GeoInfo(HAPI_GeoInfo self); // 0x0000000184D997C0-0x0000000184D997E0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_GeoInfo other); // 0x0000000189DC498C-0x0000000189DC4B90
	}

	public static class Test_HAPI_GeoInfo_Extensions // TypeDefIndex: 53270
	{
		// Extension methods
		public static Test_HAPI_GeoInfo ToTestObject(this HAPI_GeoInfo self); // 0x0000000189DC492C-0x0000000189DC498C
	}

	public class Test_HAPI_AttributeInfo : IEquivable<Test_HAPI_AttributeInfo> // TypeDefIndex: 53271
	{
		// Fields
		public HAPI_AttributeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AttributeInfo(HAPI_AttributeInfo self); // 0x0000000184DA2D90-0x0000000184DA2DB0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AttributeInfo other); // 0x0000000189DC4828-0x0000000189DC492C
	}

	public static class Test_HAPI_AttributeInfo_Extensions // TypeDefIndex: 53272
	{
		// Extension methods
		public static Test_HAPI_AttributeInfo ToTestObject(this HAPI_AttributeInfo self); // 0x0000000189DC47CC-0x0000000189DC4828
	}

	public class Test_HAPI_TransformEuler : IEquivable<Test_HAPI_TransformEuler> // TypeDefIndex: 53273
	{
		// Fields
		public HAPI_TransformEuler self; // 0x10
	
		// Constructors
		public Test_HAPI_TransformEuler(HAPI_TransformEuler self); // 0x0000000189DC5750-0x0000000189DC5774
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_TransformEuler other); // 0x0000000189DC5678-0x0000000189DC5750
	}

	public static class Test_HAPI_TransformEuler_Extensions // TypeDefIndex: 53274
	{
		// Extension methods
		public static Test_HAPI_TransformEuler ToTestObject(this HAPI_TransformEuler self); // 0x0000000189DC55F8-0x0000000189DC5678
	}

	public class Test_HAPI_ParmInfo : IEquivable<Test_HAPI_ParmInfo> // TypeDefIndex: 53275
	{
		// Fields
		public HAPI_ParmInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ParmInfo(HAPI_ParmInfo self); // 0x0000000184DA2DE0-0x0000000184DA2E40
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ParmInfo other); // 0x0000000189DC5034-0x0000000189DC55F8
	}

	public static class Test_HAPI_ParmInfo_Extensions // TypeDefIndex: 53276
	{
		// Extension methods
		public static Test_HAPI_ParmInfo ToTestObject(this HAPI_ParmInfo self); // 0x0000000189DC4F94-0x0000000189DC5034
	}

	public class Test_LODGroup : IEquivableWrapperClass<Test_LODGroup> // TypeDefIndex: 53277
	{
		// Fields
		public LODGroup self; // 0x10
	
		// Constructors
		public Test_LODGroup(LODGroup self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC5D18-0x0000000189DC5D68
		public bool IsEquivalentTo(Test_LODGroup other); // 0x0000000189DC5AF8-0x0000000189DC5D18
	}

	public static class Test_LODGroup_Extensions // TypeDefIndex: 53279
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53278
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<LODGroup, Test_LODGroup> __9__1_0; // 0x08
			public static Converter<LODGroup, Test_LODGroup> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCAB3C-0x0000000189DCABA0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_LODGroup _ToTestObject_b__1_0(LODGroup lod); // 0x0000000189DC991C-0x0000000189DC997C
			internal Test_LODGroup _ToTestObject_b__2_0(LODGroup lod); // 0x0000000189DC9EBC-0x0000000189DC9F1C
		}
	
		// Extension methods
		public static Test_LODGroup ToTestObject(this LODGroup self); // 0x0000000189DC5888-0x0000000189DC58E8
		public static Test_LODGroup[] ToTestObject(this LODGroup[] self); // 0x0000000189DC59F4-0x0000000189DC5AF8
		public static List<Test_LODGroup> ToTestObject(this List<LODGroup> self); // 0x0000000189DC58E8-0x0000000189DC59F4
	}

	public class Test_Transform : IEquivableWrapperClass<Test_Transform> // TypeDefIndex: 53280
	{
		// Fields
		public Transform self; // 0x10
	
		// Constructors
		public Test_Transform(Transform self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC934C-0x0000000189DC939C
		public bool IsEquivalentTo(Test_Transform other); // 0x0000000189DC91C8-0x0000000189DC934C
	}

	public static class Test_Transform_Extensions // TypeDefIndex: 53282
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53281
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Transform, Test_Transform> __9__1_0; // 0x08
			public static Converter<Transform, Test_Transform> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA628-0x0000000189DCA68C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Transform _ToTestObject_b__1_0(Transform lod); // 0x0000000189DC99DC-0x0000000189DC9A3C
			internal Test_Transform _ToTestObject_b__2_0(Transform lod); // 0x0000000189DCA398-0x0000000189DCA3F8
		}
	
		// Extension methods
		public static Test_Transform ToTestObject(this Transform self); // 0x0000000189DC8F58-0x0000000189DC8FB8
		public static Test_Transform[] ToTestObject(this Transform[] self); // 0x0000000189DC90C4-0x0000000189DC91C8
		public static List<Test_Transform> ToTestObject(this List<Transform> self); // 0x0000000189DC8FB8-0x0000000189DC90C4
	}

	public class Test_Material : IEquivableWrapperClass<Test_Material> // TypeDefIndex: 53283
	{
		// Fields
		public Material self; // 0x10
	
		// Constructors
		public Test_Material(Material self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC62AC-0x0000000189DC62FC
		public bool IsEquivalentTo(Test_Material other); // 0x0000000189DC60D8-0x0000000189DC62AC
	}

	public static class Test_Material_Extensions // TypeDefIndex: 53285
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53284
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Material, Test_Material> __9__1_0; // 0x08
			public static Converter<Material, Test_Material> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA68C-0x0000000189DCA6F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Material _ToTestObject_b__1_0(Material lod); // 0x0000000189DC9AFC-0x0000000189DC9B5C
			internal Test_Material _ToTestObject_b__2_0(Material lod); // 0x0000000189DC9F7C-0x0000000189DC9FDC
		}
	
		// Extension methods
		public static Test_Material ToTestObject(this Material self); // 0x0000000189DC5F4C-0x0000000189DC5FAC
		public static Test_Material[] ToTestObject(this Material[] self); // 0x0000000189DC5FAC-0x0000000189DC60D8
		public static List<Test_Material> ToTestObject(this List<Material> self); // 0x0000000189DC5E40-0x0000000189DC5F4C
	}

	public class Test_Collider : IEquivableWrapperClass<Test_Collider> // TypeDefIndex: 53286
	{
		// Fields
		public Collider self; // 0x10
	
		// Constructors
		public Test_Collider(Collider self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC41D0-0x0000000189DC4220
		public bool IsEquivalentTo(Test_Collider other); // 0x0000000189DC3D54-0x0000000189DC41D0
	}

	public static class Test_Collider_Extensions // TypeDefIndex: 53288
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53287
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Collider, Test_Collider> __9__1_0; // 0x08
			public static Converter<Collider, Test_Collider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA754-0x0000000189DCA7B8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Collider _ToTestObject_b__1_0(Collider lod); // 0x0000000189DC9860-0x0000000189DC98C0
			internal Test_Collider _ToTestObject_b__2_0(Collider lod); // 0x0000000189DCA09C-0x0000000189DCA0FC
		}
	
		// Extension methods
		public static Test_Collider ToTestObject(this Collider self); // 0x0000000189DC3CF4-0x0000000189DC3D54
		public static Test_Collider[] ToTestObject(this Collider[] self); // 0x0000000189DC3BF0-0x0000000189DC3CF4
		public static List<Test_Collider> ToTestObject(this List<Collider> self); // 0x0000000189DC3AE4-0x0000000189DC3BF0
	}

	public class Test_BoxCollider : IEquivableWrapperClass<Test_BoxCollider> // TypeDefIndex: 53289
	{
		// Fields
		public BoxCollider self; // 0x10
	
		// Constructors
		public Test_BoxCollider(BoxCollider self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC364C-0x0000000189DC369C
		public bool IsEquivalentTo(Test_BoxCollider other); // 0x0000000189DC34C0-0x0000000189DC364C
	}

	public static class Test_BoxCollider_Extensions // TypeDefIndex: 53291
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53290
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<BoxCollider, Test_BoxCollider> __9__1_0; // 0x08
			public static Converter<BoxCollider, Test_BoxCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA560-0x0000000189DCA5C4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_BoxCollider _ToTestObject_b__1_0(BoxCollider lod); // 0x0000000189DC997C-0x0000000189DC99DC
			internal Test_BoxCollider _ToTestObject_b__2_0(BoxCollider lod); // 0x0000000189DCA4B8-0x0000000189DCA518
		}
	
		// Extension methods
		public static Test_BoxCollider ToTestObject(this BoxCollider self); // 0x0000000189DC3460-0x0000000189DC34C0
		public static Test_BoxCollider[] ToTestObject(this BoxCollider[] self); // 0x0000000189DC3250-0x0000000189DC3354
		public static List<Test_BoxCollider> ToTestObject(this List<BoxCollider> self); // 0x0000000189DC3354-0x0000000189DC3460
	}

	public class Test_SphereCollider : IEquivableWrapperClass<Test_SphereCollider> // TypeDefIndex: 53292
	{
		// Fields
		public SphereCollider self; // 0x10
	
		// Constructors
		public Test_SphereCollider(SphereCollider self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC78F0-0x0000000189DC7940
		public bool IsEquivalentTo(Test_SphereCollider other); // 0x0000000189DC7788-0x0000000189DC78F0
	}

	public static class Test_SphereCollider_Extensions // TypeDefIndex: 53294
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53293
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<SphereCollider, Test_SphereCollider> __9__1_0; // 0x08
			public static Converter<SphereCollider, Test_SphereCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA948-0x0000000189DCA9AC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_SphereCollider _ToTestObject_b__1_0(SphereCollider lod); // 0x0000000189DC9D3C-0x0000000189DC9D9C
			internal Test_SphereCollider _ToTestObject_b__2_0(SphereCollider lod); // 0x0000000189DCA1BC-0x0000000189DCA21C
		}
	
		// Extension methods
		public static Test_SphereCollider ToTestObject(this SphereCollider self); // 0x0000000189DC761C-0x0000000189DC767C
		public static Test_SphereCollider[] ToTestObject(this SphereCollider[] self); // 0x0000000189DC7518-0x0000000189DC761C
		public static List<Test_SphereCollider> ToTestObject(this List<SphereCollider> self); // 0x0000000189DC767C-0x0000000189DC7788
	}

	public class Test_CapsuleCollider : IEquivableWrapperClass<Test_CapsuleCollider> // TypeDefIndex: 53295
	{
		// Fields
		public CapsuleCollider self; // 0x10
	
		// Constructors
		public Test_CapsuleCollider(CapsuleCollider self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC3A94-0x0000000189DC3AE4
		public bool IsEquivalentTo(Test_CapsuleCollider other); // 0x0000000189DC390C-0x0000000189DC3A94
	}

	public static class Test_CapsuleCollider_Extensions // TypeDefIndex: 53297
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53296
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<CapsuleCollider, Test_CapsuleCollider> __9__1_0; // 0x08
			public static Converter<CapsuleCollider, Test_CapsuleCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA6F0-0x0000000189DCA754
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_CapsuleCollider _ToTestObject_b__1_0(CapsuleCollider lod); // 0x0000000189DC9A9C-0x0000000189DC9AFC
			internal Test_CapsuleCollider _ToTestObject_b__2_0(CapsuleCollider lod); // 0x0000000189DCA15C-0x0000000189DCA1BC
		}
	
		// Extension methods
		public static Test_CapsuleCollider ToTestObject(this CapsuleCollider self); // 0x0000000189DC369C-0x0000000189DC36FC
		public static Test_CapsuleCollider[] ToTestObject(this CapsuleCollider[] self); // 0x0000000189DC3808-0x0000000189DC390C
		public static List<Test_CapsuleCollider> ToTestObject(this List<CapsuleCollider> self); // 0x0000000189DC36FC-0x0000000189DC3808
	}

	public class Test_MeshCollider : IEquivableWrapperClass<Test_MeshCollider> // TypeDefIndex: 53298
	{
		// Fields
		public MeshCollider self; // 0x10
	
		// Constructors
		public Test_MeshCollider(MeshCollider self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC6644-0x0000000189DC6694
		public bool IsEquivalentTo(Test_MeshCollider other); // 0x0000000189DC656C-0x0000000189DC6644
	}

	public static class Test_MeshCollider_Extensions // TypeDefIndex: 53300
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53299
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshCollider, Test_MeshCollider> __9__1_0; // 0x08
			public static Converter<MeshCollider, Test_MeshCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCAA10-0x0000000189DCAA74
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_MeshCollider _ToTestObject_b__1_0(MeshCollider lod); // 0x0000000189DC9800-0x0000000189DC9860
			internal Test_MeshCollider _ToTestObject_b__2_0(MeshCollider lod); // 0x0000000189DC9FDC-0x0000000189DCA03C
		}
	
		// Extension methods
		public static Test_MeshCollider ToTestObject(this MeshCollider self); // 0x0000000189DC62FC-0x0000000189DC635C
		public static Test_MeshCollider[] ToTestObject(this MeshCollider[] self); // 0x0000000189DC635C-0x0000000189DC6460
		public static List<Test_MeshCollider> ToTestObject(this List<MeshCollider> self); // 0x0000000189DC6460-0x0000000189DC656C
	}

	public class Test_Mesh : IEquivableWrapperClass<Test_Mesh> // TypeDefIndex: 53301
	{
		// Fields
		public Mesh self; // 0x10
	
		// Constructors
		public Test_Mesh(Mesh self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC74C8-0x0000000189DC7518
		public bool IsEquivalentTo(Test_Mesh other); // 0x0000000189DC710C-0x0000000189DC74C8
	}

	public static class Test_Mesh_Extensions // TypeDefIndex: 53303
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53302
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Mesh, Test_Mesh> __9__1_0; // 0x08
			public static Converter<Mesh, Test_Mesh> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA8E4-0x0000000189DCA948
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Mesh _ToTestObject_b__1_0(Mesh lod); // 0x0000000189DC9B5C-0x0000000189DC9BBC
			internal Test_Mesh _ToTestObject_b__2_0(Mesh lod); // 0x0000000189DC9E5C-0x0000000189DC9EBC
		}
	
		// Extension methods
		public static Test_Mesh ToTestObject(this Mesh self); // 0x0000000189DC6E9C-0x0000000189DC6EFC
		public static Test_Mesh[] ToTestObject(this Mesh[] self); // 0x0000000189DC7008-0x0000000189DC710C
		public static List<Test_Mesh> ToTestObject(this List<Mesh> self); // 0x0000000189DC6EFC-0x0000000189DC7008
	}

	public class Test_MeshRenderer : IEquivableWrapperClass<Test_MeshRenderer> // TypeDefIndex: 53304
	{
		// Fields
		public MeshRenderer self; // 0x10
	
		// Constructors
		public Test_MeshRenderer(MeshRenderer self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC6E4C-0x0000000189DC6E9C
		public bool IsEquivalentTo(Test_MeshRenderer other); // 0x0000000189DC6D28-0x0000000189DC6E4C
	}

	public static class Test_MeshRenderer_Extensions // TypeDefIndex: 53306
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53305
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshRenderer, Test_MeshRenderer> __9__1_0; // 0x08
			public static Converter<MeshRenderer, Test_MeshRenderer> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA7B8-0x0000000189DCA81C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_MeshRenderer _ToTestObject_b__1_0(MeshRenderer lod); // 0x0000000189DC9DFC-0x0000000189DC9E5C
			internal Test_MeshRenderer _ToTestObject_b__2_0(MeshRenderer lod); // 0x0000000189DCA458-0x0000000189DCA4B8
		}
	
		// Extension methods
		public static Test_MeshRenderer ToTestObject(this MeshRenderer self); // 0x0000000189DC6AB8-0x0000000189DC6B18
		public static Test_MeshRenderer[] ToTestObject(this MeshRenderer[] self); // 0x0000000189DC6C24-0x0000000189DC6D28
		public static List<Test_MeshRenderer> ToTestObject(this List<MeshRenderer> self); // 0x0000000189DC6B18-0x0000000189DC6C24
	}

	public class Test_MeshFilter : IEquivableWrapperClass<Test_MeshFilter> // TypeDefIndex: 53307
	{
		// Fields
		public MeshFilter self; // 0x10
	
		// Constructors
		public Test_MeshFilter(MeshFilter self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC6A68-0x0000000189DC6AB8
		public bool IsEquivalentTo(Test_MeshFilter other); // 0x0000000189DC6904-0x0000000189DC6A68
	}

	public static class Test_MeshFilter_Extensions // TypeDefIndex: 53309
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53308
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshFilter, Test_MeshFilter> __9__1_0; // 0x08
			public static Converter<MeshFilter, Test_MeshFilter> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCAC04-0x0000000189DCAC68
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_MeshFilter _ToTestObject_b__1_0(MeshFilter lod); // 0x0000000189DC9CDC-0x0000000189DC9D3C
			internal Test_MeshFilter _ToTestObject_b__2_0(MeshFilter lod); // 0x0000000189DC9F1C-0x0000000189DC9F7C
		}
	
		// Extension methods
		public static Test_MeshFilter ToTestObject(this MeshFilter self); // 0x0000000189DC68A4-0x0000000189DC6904
		public static Test_MeshFilter[] ToTestObject(this MeshFilter[] self); // 0x0000000189DC67A0-0x0000000189DC68A4
		public static List<Test_MeshFilter> ToTestObject(this List<MeshFilter> self); // 0x0000000189DC6694-0x0000000189DC67A0
	}

	public class Test_LayerMask : IEquivable<Test_LayerMask> // TypeDefIndex: 53310
	{
		// Fields
		public LayerMask self; // 0x10
	
		// Constructors
		public Test_LayerMask(LayerMask self); // 0x00000001814F51F0-0x00000001814F5220
	
		// Methods
		public bool IsEquivalentTo(Test_LayerMask other); // 0x0000000189DC5DAC-0x0000000189DC5E40
	}

	public static class Test_LayerMask_Extensions // TypeDefIndex: 53311
	{
		// Extension methods
		public static Test_LayerMask ToTestObject(this LayerMask self); // 0x0000000189DC5D68-0x0000000189DC5DAC
	}

	public class Test_Gradient : IEquivableWrapperClass<Test_Gradient> // TypeDefIndex: 53312
	{
		// Fields
		public Gradient self; // 0x10
	
		// Constructors
		public Test_Gradient(Gradient self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000183BA32C0-0x0000000183BA32D0
		public bool IsEquivalentTo(Test_Gradient other); // 0x0000000189DC4490-0x0000000189DC458C
	}

	public static class Test_Gradient_Extensions // TypeDefIndex: 53314
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53313
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Gradient, Test_Gradient> __9__1_0; // 0x08
			public static Converter<Gradient, Test_Gradient> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA9AC-0x0000000189DCAA10
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Gradient _ToTestObject_b__1_0(Gradient lod); // 0x0000000189DC9D9C-0x0000000189DC9DFC
			internal Test_Gradient _ToTestObject_b__2_0(Gradient lod); // 0x0000000189DCA03C-0x0000000189DCA09C
		}
	
		// Extension methods
		public static Test_Gradient ToTestObject(this Gradient self); // 0x0000000189DC4430-0x0000000189DC4490
		public static Test_Gradient[] ToTestObject(this Gradient[] self); // 0x0000000189DC432C-0x0000000189DC4430
		public static List<Test_Gradient> ToTestObject(this List<Gradient> self); // 0x0000000189DC4220-0x0000000189DC432C
	}

	public class Test_AnimationCurve : IEquivableWrapperClass<Test_AnimationCurve> // TypeDefIndex: 53315
	{
		// Fields
		public AnimationCurve self; // 0x10
	
		// Constructors
		public Test_AnimationCurve(AnimationCurve self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000183BA32C0-0x0000000183BA32D0
		public bool IsEquivalentTo(Test_AnimationCurve other); // 0x0000000189DC3164-0x0000000189DC3250
	}

	public static class Test_AnimationCurve_Extensions // TypeDefIndex: 53317
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53316
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<AnimationCurve, Test_AnimationCurve> __9__1_0; // 0x08
			public static Converter<AnimationCurve, Test_AnimationCurve> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA880-0x0000000189DCA8E4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_AnimationCurve _ToTestObject_b__1_0(AnimationCurve lod); // 0x0000000189DC9BBC-0x0000000189DC9C1C
			internal Test_AnimationCurve _ToTestObject_b__2_0(AnimationCurve lod); // 0x0000000189DCA338-0x0000000189DCA398
		}
	
		// Extension methods
		public static Test_AnimationCurve ToTestObject(this AnimationCurve self); // 0x0000000189DC2EF4-0x0000000189DC2F54
		public static Test_AnimationCurve[] ToTestObject(this AnimationCurve[] self); // 0x0000000189DC2F54-0x0000000189DC3058
		public static List<Test_AnimationCurve> ToTestObject(this List<AnimationCurve> self); // 0x0000000189DC3058-0x0000000189DC3164
	}

	public class Test_TerrainLayer : IEquivableWrapperClass<Test_TerrainLayer> // TypeDefIndex: 53318
	{
		// Fields
		public TerrainLayer self; // 0x10
	
		// Constructors
		public Test_TerrainLayer(TerrainLayer self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC8710-0x0000000189DC8760
		public bool IsEquivalentTo(Test_TerrainLayer other); // 0x0000000189DC8348-0x0000000189DC8710
	}

	public static class Test_TerrainLayer_Extensions // TypeDefIndex: 53320
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53319
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TerrainLayer, Test_TerrainLayer> __9__1_0; // 0x08
			public static Converter<TerrainLayer, Test_TerrainLayer> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCAA74-0x0000000189DCAAD8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_TerrainLayer _ToTestObject_b__1_0(TerrainLayer lod); // 0x0000000189DC9A3C-0x0000000189DC9A9C
			internal Test_TerrainLayer _ToTestObject_b__2_0(TerrainLayer lod); // 0x0000000189DCA2D8-0x0000000189DCA338
		}
	
		// Extension methods
		public static Test_TerrainLayer ToTestObject(this TerrainLayer self); // 0x0000000189DC80D8-0x0000000189DC8138
		public static Test_TerrainLayer[] ToTestObject(this TerrainLayer[] self); // 0x0000000189DC8244-0x0000000189DC8348
		public static List<Test_TerrainLayer> ToTestObject(this List<TerrainLayer> self); // 0x0000000189DC8138-0x0000000189DC8244
	}

	public class Test_Texture2D : IEquivableWrapperClass<Test_Texture2D> // TypeDefIndex: 53321
	{
		// Fields
		public Texture2D self; // 0x10
	
		// Constructors
		public Test_Texture2D(Texture2D self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC8F08-0x0000000189DC8F58
		public bool IsEquivalentTo(Test_Texture2D other); // 0x0000000189DC8DDC-0x0000000189DC8F08
	}

	public static class Test_Texture2D_Extensions // TypeDefIndex: 53323
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53322
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Texture2D, Test_Texture2D> __9__1_0; // 0x08
			public static Converter<Texture2D, Test_Texture2D> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCABA0-0x0000000189DCAC04
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Texture2D _ToTestObject_b__1_0(Texture2D lod); // 0x0000000189DC97A0-0x0000000189DC9800
			internal Test_Texture2D _ToTestObject_b__2_0(Texture2D lod); // 0x0000000189DCA3F8-0x0000000189DCA458
		}
	
		// Extension methods
		public static Test_Texture2D ToTestObject(this Texture2D self); // 0x0000000189DC8B6C-0x0000000189DC8BCC
		public static Test_Texture2D[] ToTestObject(this Texture2D[] self); // 0x0000000189DC8BCC-0x0000000189DC8CD0
		public static List<Test_Texture2D> ToTestObject(this List<Texture2D> self); // 0x0000000189DC8CD0-0x0000000189DC8DDC
	}

	public class Test_TreeInstance : IEquivable<Test_TreeInstance> // TypeDefIndex: 53324
	{
		// Fields
		public TreeInstance self; // 0x10
	
		// Constructors
		public Test_TreeInstance(TreeInstance self); // 0x0000000184DA2D90-0x0000000184DA2DB0
	
		// Methods
		public bool IsEquivalentTo(Test_TreeInstance other); // 0x0000000189DC9608-0x0000000189DC97A0
	}

	public static class Test_TreeInstance_Extensions // TypeDefIndex: 53326
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53325
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TreeInstance, Test_TreeInstance> __9__1_0; // 0x08
			public static Converter<TreeInstance, Test_TreeInstance> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA81C-0x0000000189DCA880
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_TreeInstance _ToTestObject_b__1_0(TreeInstance lod); // 0x0000000189DC98C0-0x0000000189DC991C
			internal Test_TreeInstance _ToTestObject_b__2_0(TreeInstance lod); // 0x0000000189DCA21C-0x0000000189DCA278
		}
	
		// Extension methods
		public static Test_TreeInstance ToTestObject(this TreeInstance self); // 0x0000000189DC94A0-0x0000000189DC94FC
		public static Test_TreeInstance[] ToTestObject(this TreeInstance[] self); // 0x0000000189DC939C-0x0000000189DC94A0
		public static List<Test_TreeInstance> ToTestObject(this List<TreeInstance> self); // 0x0000000189DC94FC-0x0000000189DC9608
	}

	public class Test_TerrainData : IEquivableWrapperClass<Test_TerrainData> // TypeDefIndex: 53327
	{
		// Fields
		public TerrainData self; // 0x10
	
		// Constructors
		public Test_TerrainData(TerrainData self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC8088-0x0000000189DC80D8
		public bool IsEquivalentTo(Test_TerrainData other); // 0x0000000189DC7BB0-0x0000000189DC8088
	}

	public static class Test_TerrainData_Extensions // TypeDefIndex: 53329
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53328
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TerrainData, Test_TerrainData> __9__1_0; // 0x08
			public static Converter<TerrainData, Test_TerrainData> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCAAD8-0x0000000189DCAB3C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_TerrainData _ToTestObject_b__1_0(TerrainData lod); // 0x0000000189DC9C7C-0x0000000189DC9CDC
			internal Test_TerrainData _ToTestObject_b__2_0(TerrainData lod); // 0x0000000189DCA278-0x0000000189DCA2D8
		}
	
		// Extension methods
		public static Test_TerrainData ToTestObject(this TerrainData self); // 0x0000000189DC7B50-0x0000000189DC7BB0
		public static Test_TerrainData[] ToTestObject(this TerrainData[] self); // 0x0000000189DC7A4C-0x0000000189DC7B50
		public static List<Test_TerrainData> ToTestObject(this List<TerrainData> self); // 0x0000000189DC7940-0x0000000189DC7A4C
	}

	public class Test_Terrain : IEquivableWrapperClass<Test_Terrain> // TypeDefIndex: 53330
	{
		// Fields
		public Terrain self; // 0x10
	
		// Constructors
		public Test_Terrain(Terrain self); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsNull(); // 0x0000000189DC8B1C-0x0000000189DC8B6C
		public bool IsEquivalentTo(Test_Terrain other); // 0x0000000189DC89D0-0x0000000189DC8B1C
	}

	public static class Test_Terrain_Extensions // TypeDefIndex: 53332
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 53331
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Terrain, Test_Terrain> __9__1_0; // 0x08
			public static Converter<Terrain, Test_Terrain> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189DCA5C4-0x0000000189DCA628
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Test_Terrain _ToTestObject_b__1_0(Terrain lod); // 0x0000000189DC9C1C-0x0000000189DC9C7C
			internal Test_Terrain _ToTestObject_b__2_0(Terrain lod); // 0x0000000189DCA0FC-0x0000000189DCA15C
		}
	
		// Extension methods
		public static Test_Terrain ToTestObject(this Terrain self); // 0x0000000189DC8760-0x0000000189DC87C0
		public static Test_Terrain[] ToTestObject(this Terrain[] self); // 0x0000000189DC87C0-0x0000000189DC88C4
		public static List<Test_Terrain> ToTestObject(this List<Terrain> self); // 0x0000000189DC88C4-0x0000000189DC89D0
	}

	[Serializable]
	internal class HEU_ToolsInfo : ScriptableObject, IEquivable<HEU_ToolsInfo> // TypeDefIndex: 53335
	{
		// Fields
		public float _paintBrushSize; // 0x18
		public float _paintBrushOpacity; // 0x1C
		public int[] _paintIntValue; // 0x20
		public float[] _paintFloatValue; // 0x28
		public string[] _paintStringValue; // 0x30
		public int _lastAttributesGeoID; // 0x38
		public int _lastAttributesPartID; // 0x3C
		public string _lastAttributeNodeName; // 0x40
		public string _lastAttributeName; // 0x48
		public UnityEngine.Color _brushHandleColor; // 0x50
		public UnityEngine.Color _affectedAreaPaintColor; // 0x60
		public bool _liveUpdate; // 0x70
		public bool _isPainting; // 0x71
		public float _editPointBoxSize; // 0x74
		public UnityEngine.Color _editPointBoxUnselectedColor; // 0x78
		public UnityEngine.Color _editPointBoxSelectedColor; // 0x88
		public bool _recacheRequired; // 0x98
		public PaintMergeMode _paintMergeMode; // 0x9C
		public bool _showOnlyEditGeometry; // 0xA0
		public bool _alwaysCookUpstream; // 0xA1
		public PaintMeshVisibility _paintMeshVisiblity; // 0xA4
	
		// Nested types
		public enum PaintMergeMode // TypeDefIndex: 53333
		{
			REPLACE = 0,
			ADD = 1,
			SUBTRACT = 2,
			MULTIPLY = 3
		}
	
		public enum PaintMeshVisibility // TypeDefIndex: 53334
		{
			AUTO = 0,
			SHOW = 1,
			HIDE = 2
		}
	
		// Constructors
		public HEU_ToolsInfo(); // 0x0000000189DBD734-0x0000000189DBD834
	
		// Methods
		public bool IsEquivalentTo(HEU_ToolsInfo other); // 0x0000000189DBD1F0-0x0000000189DBD734
	}

	public enum HFLayerType // TypeDefIndex: 53336
	{
		DEFAULT = 0,
		HEIGHT = 1,
		MASK = 2,
		DETAIL = 3
	}

	[Serializable]
	public class HEU_VolumeLayer : IEquivable<HEU_VolumeLayer> // TypeDefIndex: 53337
	{
		// Fields
		public string _layerName; // 0x10
		public float _strength; // 0x18
		public bool _uiExpanded; // 0x1C
		public int _tile; // 0x20
		public int _xLength; // 0x24
		public int _yLength; // 0x28
		[NonSerialized]
		public bool _hasLayerAttributes; // 0x2C
		public TerrainLayer _terrainLayer; // 0x30
		public HFLayerType _layerType; // 0x38
		public HEU_DetailPrototype _detailPrototype; // 0x40
		[SerializeField]
		internal HEU_PartData _part; // 0x48
	
		// Constructors
		public HEU_VolumeLayer(); // 0x0000000184D8CF30-0x0000000184D8CF40
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeLayer other); // 0x0000000189DBFFDC-0x0000000189DC02B8
	}

	public class HEU_VolumeScatterTrees : IEquivable<HEU_VolumeScatterTrees> // TypeDefIndex: 53338
	{
		// Fields
		public List<HEU_TreePrototypeInfo> _treePrototypInfos; // 0x10
		public Color32[] _colors; // 0x18
		public float[] _heightScales; // 0x20
		public Color32[] _lightmapColors; // 0x28
		public Vector3[] _positions; // 0x30
		public int[] _prototypeIndices; // 0x38
		public float[] _rotations; // 0x40
		public float[] _widthScales; // 0x48
		public int[] _terrainTiles; // 0x50
	
		// Constructors
		public HEU_VolumeScatterTrees(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeScatterTrees other); // 0x0000000189DC02B8-0x0000000189DC058C
	}

	public class HEU_TreePrototypeInfo : IEquivable<HEU_TreePrototypeInfo> // TypeDefIndex: 53339
	{
		// Fields
		public string _prefabPath; // 0x10
		public float _bendfactor; // 0x18
	
		// Constructors
		public HEU_TreePrototypeInfo(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsEquivalentTo(HEU_TreePrototypeInfo other); // 0x0000000189DBD834-0x0000000189DBD948
	}

	public class HEU_DetailProperties : IEquivable<HEU_DetailProperties> // TypeDefIndex: 53340
	{
		// Fields
		public float _detailDistance; // 0x10
		public float _detailDensity; // 0x14
		public int _detailResolution; // 0x18
		public int _detailResolutionPerPatch; // 0x1C
	
		// Constructors
		public HEU_DetailProperties(); // 0x0000000184DA2D00-0x0000000184DA2D20
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailProperties other); // 0x0000000189DB88BC-0x0000000189DB8A1C
	}

	public class HEU_DetailPrototype : IEquivable<HEU_DetailPrototype> // TypeDefIndex: 53341
	{
		// Fields
		public string _prototypePrefab; // 0x10
		public string _prototypeTexture; // 0x18
		public float _bendFactor; // 0x20
		public UnityEngine.Color _dryColor; // 0x24
		public UnityEngine.Color _healthyColor; // 0x34
		public float _maxHeight; // 0x44
		public float _maxWidth; // 0x48
		public float _minHeight; // 0x4C
		public float _minWidth; // 0x50
		public float _noiseSpread; // 0x54
		public int _renderMode; // 0x58
	
		// Constructors
		public HEU_DetailPrototype(); // 0x0000000189DB8AE8-0x0000000189DB8BA0
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailPrototype other); // 0x0000000189DB8A1C-0x0000000189DB8AE8
	}

	public class HEU_VolumeCache : ScriptableObject, IHEU_VolumeCache, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_VolumeCache> // TypeDefIndex: 53342
	{
		// Fields
		[SerializeField]
		private HEU_GeoNode _ownerNode; // 0x18
		[SerializeField]
		private List<HEU_VolumeLayer> _layers; // 0x20
		private List<HEU_VolumeLayer> _updatedLayers; // 0x28
		[SerializeField]
		private int _tileIndex; // 0x30
		[SerializeField]
		private bool _isDirty; // 0x34
		[SerializeField]
		private string _geoName; // 0x38
		[SerializeField]
		private string _objName; // 0x40
		public bool _uiExpanded; // 0x48
		[SerializeField]
		private TerrainData _terrainData; // 0x50
		[SerializeField]
		private HEU_VolumeScatterTrees _scatterTrees; // 0x58
		[SerializeField]
		private HEU_DetailProperties _detailProperties; // 0x60
		[SerializeField]
		private HEU_HoudiniAsset _parentAsset; // 0x68
	
		// Properties
		public List<HEU_VolumeLayer> Layers { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public int TileIndex { get; } // 0x0000000184D864F0-0x0000000184D86500 
		public string ObjectName { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public string GeoName { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public TerrainData TerrainData { get; } // 0x0000000184D86270-0x0000000184D86280 
		public HEU_VolumeScatterTrees ScatterTrees { get; } // 0x0000000182E56440-0x0000000182E56460 
		public HEU_DetailProperties DetailProperties { get; } // 0x0000000184D86280-0x0000000184D86290 
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000184D86230-0x0000000184D86240 
		public bool IsDirty { get; set; } // 0x0000000184D86A90-0x0000000184D86AA0 0x0000000184D86AA0-0x0000000184D86AB0
		public bool UIExpanded { get; set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
	
		// Constructors
		public HEU_VolumeCache(); // 0x0000000189DBFF58-0x0000000189DBFFDC
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x0000000189DBE4A8-0x0000000189DBE53C
		public void Recook(); // 0x0000000189DBF594-0x0000000189DBF5FC
		public void ResetParameters(); // 0x0000000189DBF5FC-0x0000000189DBF768
		public HEU_VolumeLayer GetLayer(string layerName); // 0x0000000189DBE2FC-0x0000000189DBE43C
		public void PopulatePreset(HEU_VolumeCachePreset cachePreset); // 0x0000000189DBF2D0-0x0000000189DBF558
		public bool ApplyPreset(HEU_VolumeCachePreset volumeCachePreset); // 0x0000000189DBD948-0x0000000189DBDBD8
		internal static List<HEU_VolumeCache> UpdateVolumeCachesFromParts(HEU_SessionBase session, HEU_GeoNode ownerNode, List<HEU_PartData> volumeParts, List<HEU_VolumeCache> volumeCaches); // 0x0000000189DBF86C-0x0000000189DBFF58
		internal void Initialize(HEU_GeoNode ownerNode, int tileIndex); // 0x0000000189DBE53C-0x0000000189DBE62C
		internal void StartUpdateLayers(); // 0x0000000189DBF768-0x0000000189DBF7E0
		internal void FinishUpdateLayers(); // 0x0000000189DBDF98-0x0000000189DBDFC8
		private void GetPartLayerAttributes(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer); // 0x0000000189DBE43C-0x0000000189DBE4A8
		private bool LoadLayerTextureFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, out Texture2D outTexture); // 0x0000000189DBF08C-0x0000000189DBF17C
		private bool LoadLayerFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue); // 0x0000000189DBEB94-0x0000000189DBEC8C
		private bool LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue); // 0x0000000189DBEA28-0x0000000189DBEB94
		private bool LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue); // 0x0000000189DBF17C-0x0000000189DBF294
		internal void UpdateLayerFromPart(HEU_SessionBase session, HEU_PartData part); // 0x0000000189DBF7E0-0x0000000189DBF86C
		internal void GenerateTerrainWithAlphamaps(HEU_SessionBase session, HEU_HoudiniAsset houdiniAsset, bool bRebuild); // 0x0000000189DBDFC8-0x0000000189DBE2FC
		public void LoadLayerPropertiesFromAttributes(HEU_SessionBase session, int geoID, int partID, TerrainLayer terrainLayer, bool bNewTerrainLayer, Texture2D defaultTexture); // 0x0000000189DBEC8C-0x0000000189DBF08C
		internal void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, bool throwWarningIfNoTileAttribute); // 0x0000000189DBF558-0x0000000189DBF594
		internal void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer); // 0x0000000189DBF294-0x0000000189DBF2D0
		internal void CopyValuesTo(HEU_VolumeCache destCache); // 0x0000000189DBDD54-0x0000000189DBDF98
		internal static void CopyDetailProperties(HEU_DetailProperties srcProp, HEU_DetailProperties destProp); // 0x0000000189DBDBD8-0x0000000189DBDC08
		internal static void CopyLayer(HEU_VolumeLayer srcLayer, HEU_VolumeLayer destLayer); // 0x0000000189DBDC08-0x0000000189DBDCE4
		internal static void CopyPrototype(HEU_DetailPrototype srcProto, HEU_DetailPrototype destProto); // 0x0000000189DBDCE4-0x0000000189DBDD54
		internal static Texture2D LoadDefaultSplatTexture(); // 0x0000000189DBE9C0-0x0000000189DBEA28
		internal static Texture2D LoadAssetTexture(string path); // 0x0000000189DBE8F4-0x0000000189DBE9C0
		public bool IsEquivalentTo(HEU_VolumeCache other); // 0x0000000189DBE62C-0x0000000189DBE8F4
	}
}
