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
using UnityEngine.Tilemaps;

// Image 18: HoudiniEngineUnity.dll - Assembly: HoudiniEngineUnity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 49486-49924
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class HEU_BoundingVolume : MonoBehaviour // TypeDefIndex: 49488
{
	// Properties
	public Collider BoundingCollider { get => default; } // 0x00000001887D35D8-0x00000001887D3614 

	// Constructors
	public HEU_BoundingVolume() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	public List<GameObject> GetAllIntersectingObjects() => default; // 0x00000001887D33A0-0x00000001887D35D8
}

public class HEU_ExampleEvergreenQuery // TypeDefIndex: 49489
{
	// Constructors
	public HEU_ExampleEvergreenQuery() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public static void StartQuery() {} // 0x00000001887D899C-0x00000001887D8B7C
	public static HEU_HoudiniAsset QueryHoudiniAsset(GameObject rootGO) => default; // 0x00000001887D8694-0x00000001887D8810
	public static void CookAsset(HEU_HoudiniAsset houdiniAsset) {} // 0x00000001887D836C-0x00000001887D8380
	public static void ChangeParmsAndCook(HEU_HoudiniAsset houdiniAsset) {} // 0x00000001887D7FFC-0x00000001887D836C
	public static void QueryObjects(HEU_HoudiniAsset houdiniAsset) {} // 0x00000001887D8810-0x00000001887D888C
	public static void QueryGeoParts(HEU_SessionBase session, ref HAPI_GeoInfo geoInfo) {} // 0x00000001887D85D0-0x00000001887D8694
	public static void QueryPartAttributeByOwner(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner owner, int count, StringBuilder sb) {} // 0x00000001887D888C-0x00000001887D899C
	public static void QueryAttributeByStorageType(HEU_SessionBase session, int geoID, int partID, ref HAPI_AttributeInfo attrInfo, string attrName) {} // 0x00000001887D8380-0x00000001887D8504
	public static void QueryAttribute(HEU_HoudiniAsset houdiniAsset, string objName, string geoName, int partID, string attrName) {} // 0x00000001887D8504-0x00000001887D85D0
}

[ExecuteInEditMode]
public class HEU_ExampleInstanceCustomAttribute : MonoBehaviour // TypeDefIndex: 49490
{
	// Constructors
	public HEU_ExampleInstanceCustomAttribute() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void InstancerCallback() {} // 0x00000001887D8B7C-0x00000001887D8EFC
	private static void LogArray<T>(string name, T[] arr, int tupleSize) {}
	private static void LogAttr(HEU_OutputAttribute outAttr) {} // 0x00000001887D8EFC-0x00000001887D9028
}

[ExecuteInEditMode]
public class HEU_ScriptCallbackExample : MonoBehaviour // TypeDefIndex: 49491
{
	// Fields
	public string _msg; // 0x18

	// Constructors
	public HEU_ScriptCallbackExample() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void AssetCallbackWithMsg(string msg) {} // 0x00000001887EF628-0x00000001887EF6AC
	private void AssetCallbackNoMsg() {} // 0x00000001887EF5D4-0x00000001887EF628
}

public class HEU_ScriptMeshInputUVLayoutExample // TypeDefIndex: 49493
{
	// Nested types
	public enum OutputMode // TypeDefIndex: 49492
	{
		COPY = 0,
		REPLACE = 1
	}

	// Constructors
	public HEU_ScriptMeshInputUVLayoutExample() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public static void ApplyUVLayoutTo(GameObject[] gameObjects, OutputMode outputMode, string output_name_suffix) {} // 0x00000001887EF6AC-0x00000001887EF80C
}

public class HEU_ScriptParameterExample : MonoBehaviour // TypeDefIndex: 49494
{
	// Fields
	public GameObject _evergreenGameObject; // 0x18
	private HEU_HoudiniAsset _evergreenAsset; // 0x20
	public float _updateRate; // 0x28
	public float _scale; // 0x2C

	// Constructors
	public HEU_ScriptParameterExample() {} // 0x00000001887EF80C-0x00000001887EF824
}

public class HEU_AssetEventReceiverTest : MonoBehaviour // TypeDefIndex: 49495
{
	// Constructors
	public HEU_AssetEventReceiverTest() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	public void ReloadCallback(HEU_ReloadEventData Data) {} // 0x00000001887D2334-0x00000001887D2498
	public void CookedCallback(HEU_CookedEventData Data) {} // 0x00000001887D21D0-0x00000001887D2334
	public void BakedCallback(HEU_BakedEventData Data) {} // 0x00000001887D206C-0x00000001887D21D0
}

namespace HoudiniEngineUnity
{
	public enum HEU_AssetEventType // TypeDefIndex: 49496
	{
		UNKNOWN = 0,
		RELOAD = 1,
		COOK = 2,
		BAKE_NEW = 3,
		BAKE_UPDATE = 4
	}

	public class HEU_AssetEventData // TypeDefIndex: 49497
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public bool CookSuccess; // 0x18
		public List<GameObject> OutputObjects; // 0x20
		public HEU_AssetEventType EventType; // 0x28
	
		// Constructors
		public HEU_AssetEventData() {} // Dummy constructor
		public HEU_AssetEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects) {} // 0x0000000183240600-0x0000000183240630
	}

	public class HEU_ReloadEventData : HEU_AssetEventData // TypeDefIndex: 49498
	{
		// Constructors
		public HEU_ReloadEventData() {} // Dummy constructor
		public HEU_ReloadEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects) {} // 0x00000001887EF5B0-0x00000001887EF5D4
	}

	public class HEU_CookedEventData : HEU_AssetEventData // TypeDefIndex: 49499
	{
		// Constructors
		public HEU_CookedEventData() {} // Dummy constructor
		public HEU_CookedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects) {} // 0x00000001887D3650-0x00000001887D3674
	}

	public class HEU_BakedEventData : HEU_AssetEventData // TypeDefIndex: 49500
	{
		// Fields
		public bool IsNewBake; // 0x30
	
		// Constructors
		public HEU_BakedEventData() {} // Dummy constructor
		public HEU_BakedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects, bool isNewBake) {} // 0x00000001887D3370-0x00000001887D33A0
	}

	public class HEU_PreAssetEventData // TypeDefIndex: 49501
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public HEU_AssetEventType AssetType; // 0x18
	
		// Constructors
		public HEU_PreAssetEventData() {} // Dummy constructor
		public HEU_PreAssetEventData(HEU_HoudiniAsset asset, HEU_AssetEventType assetType) {} // 0x0000000182738A30-0x0000000182738A50
	}

	[Serializable]
	public class HEU_ReloadDataEvent : UnityEvent<HEU_ReloadEventData> // TypeDefIndex: 49502
	{
		// Constructors
		public HEU_ReloadDataEvent() {} // 0x00000001887EF574-0x00000001887EF5B0
	}

	[Serializable]
	public class HEU_CookedDataEvent : UnityEvent<HEU_CookedEventData> // TypeDefIndex: 49503
	{
		// Constructors
		public HEU_CookedDataEvent() {} // 0x00000001887D3614-0x00000001887D3650
	}

	[Serializable]
	public class HEU_BakedDataEvent : UnityEvent<HEU_BakedEventData> // TypeDefIndex: 49504
	{
		// Constructors
		public HEU_BakedDataEvent() {} // 0x00000001887D3334-0x00000001887D3370
	}

	[Serializable]
	public class HEU_PreAssetEvent : UnityEvent<HEU_PreAssetEventData> // TypeDefIndex: 49505
	{
		// Constructors
		public HEU_PreAssetEvent() {} // 0x00000001887EF478-0x00000001887EF4B4
	}

	[Serializable]
	public class HEU_AssetPreset // TypeDefIndex: 49506
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
		public HEU_AssetPreset() {} // 0x00000001887D3040-0x00000001887D3198
	}

	[Serializable]
	public class HEU_InputPreset // TypeDefIndex: 49507
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
		public HEU_InputObjectTypeWrapper InputObjectType { get => default; set {} } // 0x00000001887EF44C-0x00000001887EF458 0x00000001887EF458-0x00000001887EF478
	
		// Constructors
		public HEU_InputPreset() {} // 0x00000001887EF38C-0x00000001887EF44C
	}

	[Serializable]
	public class HEU_InputObjectPreset // TypeDefIndex: 49508
	{
		// Fields
		public string _gameObjectName; // 0x10
		public bool _isSceneObject; // 0x18
		public bool _useTransformOffset; // 0x19
		public Vector3 _translateOffset; // 0x1C
		public Vector3 _rotateOffset; // 0x28
		public Vector3 _scaleOffset; // 0x34
	
		// Constructors
		public HEU_InputObjectPreset() {} // 0x00000001887EF32C-0x00000001887EF38C
	}

	[Serializable]
	public class HEU_InputAssetPreset // TypeDefIndex: 49509
	{
		// Fields
		public string _gameObjectName; // 0x10
	
		// Constructors
		public HEU_InputAssetPreset() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class HEU_VolumeLayerPreset // TypeDefIndex: 49510
	{
		// Fields
		public string _layerName; // 0x10
		public float _strength; // 0x18
		public bool _uiExpanded; // 0x1C
		[OptionalField(VersionAdded = 5)]
		public int _tile; // 0x20
	
		// Constructors
		public HEU_VolumeLayerPreset() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class HEU_VolumeCachePreset // TypeDefIndex: 49511
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
		public HEU_VolumeCachePreset() {} // 0x00000001887EFC3C-0x00000001887EFCB4
	}

	[Serializable]
	internal class HEU_RecookPreset // TypeDefIndex: 49512
	{
		// Fields
		public List<HEU_VolumeCachePreset> _volumeCachePresets; // 0x10
		public List<HEU_InputPreset> _inputPresets; // 0x18
	
		// Constructors
		public HEU_RecookPreset() {} // 0x00000001887EF4B4-0x00000001887EF574
	}

	public static class HEU_AssetPresetUtility // TypeDefIndex: 49513
	{
		// Fields
		public static char[] PRESET_IDENTIFIER; // 0x00
		public static int PRESET_VERSION; // 0x08
	
		// Constructors
		static HEU_AssetPresetUtility() {} // 0x00000001887D2FBC-0x00000001887D3040
	
		// Methods
		public static void SaveAssetPresetToFile(HEU_HoudiniAsset asset, string filePath) {} // 0x00000001887D2A44-0x00000001887D2FBC
		public static void LoadPresetFileIntoAssetAndCook(HEU_HoudiniAsset asset, string filePath) {} // 0x00000001887D2498-0x00000001887D2A44
	}

	public class HEU_Vector3SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 49514
	{
		// Constructors
		public HEU_Vector3SerializationSurrogate() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context) {} // 0x00000001887EF9F4-0x00000001887EFABC
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) => default; // 0x00000001887EFABC-0x00000001887EFC3C
	}

	public class HEU_Vector2SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 49515
	{
		// Constructors
		public HEU_Vector2SerializationSurrogate() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context) {} // 0x00000001887EF824-0x00000001887EF8C8
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) => default; // 0x00000001887EF8C8-0x00000001887EF9F4
	}

	internal class HEU_AssetSerializedMetaData : ScriptableObject, IEquivable<HEU_AssetSerializedMetaData> // TypeDefIndex: 49516
	{
		// Fields
		[SerializeField]
		private bool _softDeleted; // 0x18
		[SerializeField]
		private Dictionary<string, List<CurveNodeData>> _savedCurveNodeData; // 0x20
		[SerializeField]
		private Dictionary<string, HEU_InputCurveInfo> _savedInputCurveInfo; // 0x28
	
		// Properties
		public bool SoftDeleted { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public Dictionary<string, List<CurveNodeData>> SavedCurveNodeData { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Dictionary<string, HEU_InputCurveInfo> SavedInputCurveInfo { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public HEU_AssetSerializedMetaData() {} // 0x00000001887D322C-0x00000001887D32F4
	
		// Methods
		public bool IsEquivalentTo(HEU_AssetSerializedMetaData other) => default; // 0x00000001887D3198-0x00000001887D322C
	}

	internal class HEU_AssetUpdater // TypeDefIndex: 49517
	{
		// Constructors
		static HEU_AssetUpdater() {} // 0x000000018350B670-0x000000018350B680
		public HEU_AssetUpdater() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static void OnBeforeAssemblyReload() {} // 0x00000001887D32F4-0x00000001887D3334
		private static void Update() {} // 0x000000018350B670-0x000000018350B680
		public static void AddAssetForUpdate(HEU_HoudiniAsset asset) {} // 0x000000018350B670-0x000000018350B680
		public static void RemoveAsset(HEU_HoudiniAsset asset) {} // 0x000000018350B670-0x000000018350B680
		public static void AddNodeSyncForUpdate(HEU_BaseSync nodeSync) {} // 0x000000018350B670-0x000000018350B680
		public static void RemoveNodeSync(HEU_BaseSync nodeSync) {} // 0x000000018350B670-0x000000018350B680
		private static void OnPrefabInstanceUpdate(GameObject instance) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class CurveNodeData : IEquivable<CurveNodeData> // TypeDefIndex: 49518
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
		public CurveNodeData() {} // 0x00000001887D1EE0-0x00000001887D1F40
		public CurveNodeData(Vector3 position) {} // 0x00000001887D1E70-0x00000001887D1EE0
		public CurveNodeData(Vector3 position, Quaternion rotation) {} // 0x00000001887D1F40-0x00000001887D1FC8
		public CurveNodeData(Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x00000001887D1FC8-0x00000001887D206C
		public CurveNodeData(CurveNodeData other) {} // 0x00000001887D1DD0-0x00000001887D1E70
	
		// Methods
		public Quaternion GetRotation() => default; // 0x00000001887D1C04-0x00000001887D1C40
		public bool IsEquivalentTo(CurveNodeData other) => default; // 0x00000001887D1C40-0x00000001887D1DD0
	}

	[Serializable]
	public class HEU_InputCurveInfo // TypeDefIndex: 49519
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
		public HEU_InputCurveInfo() {} // 0x0000000183D6D3C0-0x0000000183D6D3D0
	
		// Methods
		public static HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HAPI_InputCurveInfo curveInfo) => default; // 0x00000001887EF0D0-0x00000001887EF154
		public static string[] GetCurveTypeNames() => default; // 0x00000001887EF1FC-0x00000001887EF2A4
		public static string[] GetInputMethodNames() => default; // 0x00000001887EF2A4-0x00000001887EF32C
		public static string[] GetBreakpointParameterizationNames() => default; // 0x00000001887EF154-0x00000001887EF1FC
	}

	[Serializable]
	public enum HEU_CurveDataType // TypeDefIndex: 49520
	{
		INVALID = 0,
		GEO_COORDS_PARAM = 1,
		HAPI_COORDS_PARAM = 2,
		POSITION_ATTRIBUTE = 3
	}

	public class HEU_Curve : ScriptableObject, IHEU_Curve, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Curve> // TypeDefIndex: 49528
	{
		// Fields
		[SerializeField]
		private int _geoID; // 0x18
		[SerializeField]
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
		public GameObject TargetGameObject { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public int GeoID { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int PartID { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public List<CurveNodeData> CurveNodeData { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public HEU_Parameters Parameters { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public string CurveName { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public bool IsInputCurve { get => default; } // 0x0000000183D4F3F0-0x0000000183D4F400 
		public bool IsPartCurve { get => default; } // 0x0000000183D4F3C0-0x0000000183D4F3D0 
		public HEU_InputCurveInfo InputCurveInfo { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public CurveEditState EditState { get => default; } // 0x0000000183D4EEF0-0x0000000183D4EF00 
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public HEU_CurveDataType CurveDataType { get => default; } // 0x0000000183D4EC20-0x0000000183D4EC30 
	
		// Nested types
		public enum CurveEditState // TypeDefIndex: 49521
		{
			INVALID = 0,
			GENERATED = 1,
			EDITING = 2,
			REQUIRES_GENERATION = 3
		}
	
		public enum Interaction // TypeDefIndex: 49522
		{
			VIEW = 0,
			ADD = 1,
			EDIT = 2
		}
	
		internal enum CurveDrawCollision // TypeDefIndex: 49523
		{
			COLLIDERS = 0,
			LAYERMASK = 1
		}
	
		// Constructors
		public HEU_Curve() {} // 0x00000001887D7F78-0x00000001887D7FFC
	
		// Methods
		internal void SetUploadParameterPreset(bool bValue) {} // 0x0000000183D4EEB0-0x0000000183D4EEC0
		public HEU_SessionBase GetSession() => default; // 0x00000001887D52C8-0x00000001887D535C
		public void Recook() {} // 0x00000001887D60AC-0x00000001887D6118
		public bool IsEditable() => default; // 0x0000000183D4EF60-0x0000000183D4EF70
		public bool IsGeoCurve() => default; // 0x0000000183D4F7E0-0x0000000183D4F7F0
		public void SetCurveName(string name) {} // 0x00000001887D6360-0x00000001887D63E0
		public void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x01FBD54E */) {} // 0x00000001887D6678-0x00000001887D674C
		public void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x01FBD54F */) {} // 0x00000001887D6534-0x00000001887D6678
		public void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x01FBD550 */) {} // 0x00000001887D63E0-0x00000001887D6464
		public Vector3 GetCurvePoint(int pointIndex) => default; // 0x00000001887D4BB0-0x00000001887D4C58
		public List<CurveNodeData> GetAllPointTransforms() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public List<Vector3> GetAllPoints() => default; // 0x00000001887D4978-0x00000001887D4A88
		public int GetNumPoints() => default; // 0x00000001887D4D38-0x00000001887D4D78
		public void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x01FBD551 */) {} // 0x00000001887D5650-0x00000001887D5748
		public void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x01FBD552 */) {} // 0x00000001887D55A8-0x00000001887D5650
		public void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x01FBD553 */) {} // 0x00000001887D3710-0x00000001887D3808
		public void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x01FBD554 */) {} // 0x00000001887D3674-0x00000001887D3710
		public void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x01FBD555 */) {} // 0x00000001887D6118-0x00000001887D61B0
		public void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x01FBD556 */) {} // 0x00000001887D3808-0x00000001887D3894
		public void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x01FBD557 */) {} // 0x00000001887D6058-0x00000001887D60AC
		public void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x01FBD558 */) {} // 0x00000001887D632C-0x00000001887D6360
		public Vector3 GetTransformedPoint(int pointIndex) => default; // 0x00000001887D535C-0x00000001887D5424
		public List<Vector3> GetTransformedPoints() => default; // 0x00000001887D5424-0x00000001887D5538
		public List<CurveNodeData> DuplicateCurveNodeData() => default; // 0x00000001887D3F54-0x00000001887D4200
		internal static HEU_Curve CreateSetupCurve(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool isEditable, string curveName, int geoID, int partID, bool bGeoCurve) => default; // 0x00000001887D3894-0x00000001887D3C30
		private void UsePreviousCurveData(string curveName) {} // 0x00000001887D7D0C-0x00000001887D7F78
		private HEU_CurveDataType GetCurveDataType(HEU_SessionBase session) => default; // 0x00000001887D4B68-0x00000001887D4BB0
		internal bool ShouldKeepNode(HEU_SessionBase session) => default; // 0x00000001887D674C-0x00000001887D67A4
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x01FBD559 */) {} // 0x00000001887D3C30-0x00000001887D3E5C
		internal void UploadParameterPreset(HEU_SessionBase session, int geoID, HEU_HoudiniAsset parentAsset) {} // 0x00000001887D7BA8-0x00000001887D7C90
		internal void ResetCurveParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) {} // 0x00000001887D61B0-0x00000001887D6270
		internal void SetCurveParameterPreset(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, byte[] parameterPreset) {} // 0x00000001887D6464-0x00000001887D6534
		internal void UpdateCurve(HEU_SessionBase session, int partId) {} // 0x00000001887D7228-0x00000001887D73F8
		private static int[] GetCurveCounts(HEU_SessionBase session, int geoId, int partID) => default; // 0x00000001887D4AF8-0x00000001887D4B68
		internal void GenerateMesh(GameObject inGameObject, HEU_SessionBase session) {} // 0x00000001887D45A8-0x00000001887D4978
		internal void GenerateMeshForSingleObject(GameObject targetObject, Vector3[] vertexList) {} // 0x00000001887D4200-0x00000001887D45A8
		internal void OnPresyncParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) {} // 0x00000001887D5A60-0x00000001887D5A98
		internal static int GetOrderForCurveType(int requestedOrder, HAPI_CurveType curveType) => default; // 0x00000001887D4D78-0x00000001887D4DC4
		internal bool UpdateCurveInputForCurveParts(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) => default; // 0x00000001887D6954-0x00000001887D6E8C
		internal bool UpdateCurveInputForCustomAttributes(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) => default; // 0x00000001887D6E8C-0x00000001887D7228
		internal void SyncFromParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bNewCurve) {} // 0x00000001887D67A4-0x00000001887D684C
		private void UpdatePoints(HEU_SessionBase session) {} // 0x00000001887D73F8-0x00000001887D7BA8
		internal void ProjectToCollidersInternal(HEU_HoudiniAsset parentAsset, Vector3 rayDirection, float rayDistance) {} // 0x00000001887D5A98-0x00000001887D6058
		public static string GetPointsString(List<CurveNodeData> points) => default; // 0x00000001887D503C-0x00000001887D52C8
		public static string GetPointsString(List<Vector3> points) => default; // 0x00000001887D4DC4-0x00000001887D503C
		internal void SetEditState(CurveEditState editState) {} // 0x0000000183D4EF40-0x0000000183D4EF50
		internal Vector3 GetTransformedPosition(Vector3 inPosition) => default; // 0x00000001887D5538-0x00000001887D55A8
		internal Vector3 GetInvertedTransformedPosition(Vector3 inPosition) => default; // 0x00000001887D4CC8-0x00000001887D4D38
		internal Vector3 GetInvertedTransformedDirection(Vector3 inPosition) => default; // 0x00000001887D4C58-0x00000001887D4CC8
		internal Vector3[] GetVertices() => default; // 0x0000000183D4EAC0-0x0000000183D4EAD0
		internal void SetCurveGeometryVisibilityInternal(bool bVisible) {} // 0x00000001887D6270-0x00000001887D632C
		internal void DownloadPresetData(HEU_SessionBase session) {} // 0x00000001887D3ED8-0x00000001887D3F54
		internal void UploadPresetData(HEU_SessionBase session) {} // 0x00000001887D7C90-0x00000001887D7D0C
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session) {} // 0x00000001887D3E5C-0x00000001887D3ED8
		private void UpdateCachedCurveInfo(HEU_SessionBase session, bool copyCurveSettings) {} // 0x00000001887D684C-0x00000001887D6954
		internal int GetCurveCountIndexFromPositionIndex(int positionIndex) => default; // 0x00000001887D4A88-0x00000001887D4AF8
		private static bool IsMeshCurve(HEU_SessionBase session, int geoID, int partID) => default; // 0x00000001887D5A38-0x00000001887D5A60
		public bool IsEquivalentTo(HEU_Curve other) => default; // 0x00000001887D5748-0x00000001887D5A38
	}

	[Serializable]
	public class HEU_GeneratedOutput : IEquivable<HEU_GeneratedOutput> // TypeDefIndex: 49529
	{
		// Fields
		public HEU_GeneratedOutputData _outputData; // 0x10
		public List<HEU_GeneratedOutputData> _childOutputs; // 0x18
		[SerializeField]
		private bool isInstancer; // 0x20
	
		// Properties
		public bool IsInstancer { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
	
		// Constructors
		public HEU_GeneratedOutput() {} // 0x00000001887DA4BC-0x00000001887DA568
	
		// Methods
		public static void ResetMaterialOverrides(HEU_GeneratedOutput output) {} // 0x00000001887DA24C-0x00000001887DA394
		public static void ResetMaterialOverrides(HEU_GeneratedOutputData outputData) {} // 0x00000001887DA394-0x00000001887DA44C
		public static Material[] GetGeneratedMaterialsForGameObject(HEU_GeneratedOutput output, GameObject inGameObject) => default; // 0x00000001887D9C00-0x00000001887D9DBC
		public static bool HasLODGroup(HEU_GeneratedOutput output) => default; // 0x00000001887D9DBC-0x00000001887D9E04
		public static bool IsOutputUsingMaterial(Material checkMaterial, HEU_GeneratedOutput output) => default; // 0x00000001887DA0EC-0x00000001887DA24C
		public static bool IsOutputDataUsingMaterial(Material checkMaterial, HEU_GeneratedOutputData outputData) => default; // 0x00000001887D9F80-0x00000001887DA0EC
		public static void ClearGeneratedMaterialReferences(HEU_GeneratedOutputData generatedOutputData) {} // 0x00000001887D9398-0x00000001887D93BC
		public static void DestroyAllGeneratedColliders(HEU_GeneratedOutputData outputData) {} // 0x00000001887D96C8-0x00000001887D98A0
		public static void DestroyGeneratedOutput(HEU_GeneratedOutput generatedOutput) {} // 0x00000001887D9A5C-0x00000001887D9C00
		public static void DestroyGeneratedOutputChildren(HEU_GeneratedOutput generatedOutput) {} // 0x00000001887D98A0-0x00000001887D9A04
		public static void DestroyGeneratedOutputData(HEU_GeneratedOutputData generatedOutputData, bool bDontDeletePersistantResources) {} // 0x00000001887D9A04-0x00000001887D9A5C
		public static void ClearMaterialsNoLongerUsed(Material[] materialsToCheck, Material[] materialsInUse) {} // 0x00000001887D93BC-0x00000001887D948C
		public static void CopyMaterialOverrides(HEU_GeneratedOutputData sourceOutputData, HEU_GeneratedOutputData destOutputData) {} // 0x00000001887D948C-0x00000001887D96C8
		internal void WriteOutputToAssetCache(GameObject parentObject, string outputPath, bool bIsInstancer) {} // 0x00000001887DA44C-0x00000001887DA4BC
		internal static void BakeGameObjectComponents(GameObject sourceGO, GameObject targetGO, string assetName, string outputPath, bool bIsInstancer) {} // 0x00000001887D9250-0x00000001887D9398
		public bool IsEquivalentTo(HEU_GeneratedOutput other) => default; // 0x00000001887D9E04-0x00000001887D9F80
	}

	[Serializable]
	public class HEU_GeneratedOutputData : IEquivable<HEU_GeneratedOutputData> // TypeDefIndex: 49530
	{
		// Fields
		public GameObject _gameObject; // 0x10
		public Material[] _renderMaterials; // 0x18
		public List<Collider> _colliders; // 0x20
	
		// Constructors
		public HEU_GeneratedOutputData() {} // 0x00000001887D91D8-0x00000001887D9250
	
		// Methods
		public bool IsEquivalentTo(HEU_GeneratedOutputData other) => default; // 0x00000001887D9028-0x00000001887D91D8
	}

	public class HEU_GeoNode : ScriptableObject, IHEU_GeoNode, IHEU_HoudiniAssetSubcomponent, ISerializationCallbackReceiver, IEquivable<HEU_GeoNode> // TypeDefIndex: 49531
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
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x00000001887DE394-0x00000001887DE400 
		public int GeoID { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public HAPI_GeoInfo GeoInfo { get => default; } // 0x0000000183D65C80-0x0000000183D65CA0 
		public string GeoName { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public HAPI_GeoType GeoType { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public bool Editable { get => default; } // 0x0000000183D4F090-0x0000000183D4F0A0 
		public bool Displayable { get => default; } // 0x00000001887DE314-0x00000001887DE394 
		public List<HEU_PartData> Parts { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public HEU_ObjectNode ObjectNode { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public HEU_InputNode InputNode { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public HEU_Curve GeoCurve { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public List<HEU_VolumeCache> VolumeCaches { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
	
		// Constructors
		public HEU_GeoNode() {} // 0x00000001887DE2F4-0x00000001887DE314
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public void OnAfterDeserialize() {} // 0x00000001887DC550-0x00000001887DC644
		public HEU_SessionBase GetSession() => default; // 0x00000001887DBC98-0x00000001887DBD3C
		public void Recook() {} // 0x00000001887DD660-0x00000001887DD6D4
		public bool IsVisible() => default; // 0x00000001887DC534-0x00000001887DC550
		public bool IsIntermediate() => default; // 0x00000001886E1564-0x00000001886E156C
		public bool IsIntermediateOrEditable() => default; // 0x00000001887DC3F0-0x00000001887DC408
		public bool IsGeoInputType() => default; // 0x00000001887DC3DC-0x00000001887DC3F0
		public bool IsGeoCurveType() => default; // 0x00000001859BC74C-0x00000001859BC754
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x01FBD563 */) {} // 0x00000001887DA8B4-0x00000001887DAA8C
		public void RemoveAndDestroyPart(HEU_PartData part) {} // 0x00000001887DD6D4-0x00000001887DD738
		public void GetOutputGameObjects(List<GameObject> outputObjects) {} // 0x00000001887DB8C0-0x00000001887DB9E4
		public void GetOutput(List<HEU_GeneratedOutput> outputs) {} // 0x00000001887DB9E4-0x00000001887DBB08
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x00000001887DB768-0x00000001887DB8C0
		public HEU_PartData GetPartFromPartID(int partID) => default; // 0x00000001887DBB08-0x00000001887DBBB8
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly) {} // 0x00000001887DB1CC-0x00000001887DB3C8
		public List<HEU_PartData> GetParts() => default; // 0x0000000183D4EA70-0x0000000183D4EA80
		public void HideAllGeometry() {} // 0x00000001887DBFC8-0x00000001887DC05C
		public void DisableAllColliders() {} // 0x00000001887DAC14-0x00000001887DACA8
		public HEU_VolumeCache GetVolumeCacheByTileIndex(int tileIndex) => default; // 0x00000001887DBD3C-0x00000001887DBE78
		internal void Reset() {} // 0x00000001887DD738-0x00000001887DD7E8
		internal void Initialize(HEU_SessionBase session, HAPI_GeoInfo geoInfo, HEU_ObjectNode containerObjectNode) {} // 0x00000001887DC05C-0x00000001887DC178
		internal bool DoesThisRequirePotentialCook() => default; // 0x00000001887DACA8-0x00000001887DACF0
		internal void UpdateGeo(HEU_SessionBase session) {} // 0x00000001887DDF6C-0x00000001887DE2F4
		internal void ProcessUnityScriptAttribute(HEU_SessionBase session) {} // 0x00000001887DCFD4-0x00000001887DD188
		private void ProcessPart(HEU_SessionBase session, int partID, ref HAPI_PartInfo partInfo, ref HEU_PartData partData) {} // 0x00000001887DC83C-0x00000001887DCFD4
		private void SetupGameObjectAndTransform(HEU_PartData partData, HEU_HoudiniAsset parentAsset) {} // 0x00000001887DDA94-0x00000001887DDD44
		internal void GetPartsByOutputType(List<HEU_PartData> meshParts, List<HEU_PartData> volumeParts) {} // 0x00000001887DBBB8-0x00000001887DBC98
		internal void GeneratePartInstances(HEU_SessionBase session) {} // 0x00000001887DAE68-0x00000001887DB0A8
		internal void GenerateAttributesStore(HEU_SessionBase session) {} // 0x00000001887DACF0-0x00000001887DAD90
		private void ProcessGeoCurve(HEU_SessionBase session) {} // 0x00000001887DC644-0x00000001887DC83C
		private void SetupGeoCurveGameObjectAndTransform(HEU_Curve curve) {} // 0x00000001887DDD44-0x00000001887DDF10
		internal void ClearObjectInstances() {} // 0x00000001887DA82C-0x00000001887DA8B4
		internal void SetGeoInfo(HAPI_GeoInfo geoInfo) {} // 0x00000001887DDA10-0x00000001887DDA94
		internal string GeneratePartFullName(string partName) => default; // 0x00000001887DAD90-0x00000001887DAE68
		internal string GenerateGeoCurveName() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		internal bool HasGeoNodeChanged(HEU_SessionBase session) => default; // 0x00000001887DBF90-0x00000001887DBFC8
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform) {} // 0x00000001887DA568-0x00000001887DA68C
		internal void GetDebugInfo(StringBuilder sb) {} // 0x00000001887DB3C8-0x00000001887DB768
		internal bool IsUsingMaterial(HEU_MaterialData materialData) => default; // 0x00000001887DC408-0x00000001887DC534
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x00000001887DB0A8-0x00000001887DB1CC
		internal bool HasAttribInstancer() => default; // 0x00000001887DBE78-0x00000001887DBF90
		internal void SetAttributeModifiersOnPartOutputs(HEU_SessionBase session) {} // 0x00000001887DD7E8-0x00000001887DDA10
		internal void CalculateVisiblity(bool bParentVisibility) {} // 0x00000001887DA71C-0x00000001887DA82C
		internal void CalculateColliderState() {} // 0x00000001887DA68C-0x00000001887DA71C
		internal void ProcessVolumeParts(HEU_SessionBase session, List<HEU_PartData> volumeParts, bool bRebuild) {} // 0x00000001887DD188-0x00000001887DD660
		internal void DestroyVolumeCache() {} // 0x00000001887DAA8C-0x00000001887DAC14
		public override string ToString() => default; // 0x00000001887DDF10-0x00000001887DDF6C
		public bool IsEquivalentTo(HEU_GeoNode other) => default; // 0x00000001887DC178-0x00000001887DC3DC
	}

	[ExecuteInEditMode]
	public sealed class HEU_HoudiniAsset : MonoBehaviour, IHEU_HoudiniAsset, IEquivable<HEU_HoudiniAsset> // TypeDefIndex: 49541
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
		[SerializeField]
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
		[SerializeField]
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
		private bool _curveCookOnDrag; // 0x216
		[SerializeField]
		private bool _curveFrameSelectedNodes; // 0x217
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
		public bool LoadAssetFromMemory { get => default; set {} } // 0x0000000183D519D0-0x0000000183D519E0 0x0000000183D57500-0x0000000183D57510
		public bool AlwaysOverwriteOnLoad { get => default; set {} } // 0x0000000183D58400-0x0000000183D58410 0x0000000183D6D220-0x0000000183D6D230
		public bool GenerateUVs { get => default; set {} } // 0x0000000183D57B10-0x0000000183D57B20 0x0000000183D5A480-0x0000000183D5A490
		public bool GenerateTangents { get => default; set {} } // 0x0000000183D6D180-0x0000000183D6D190 0x0000000183D6D320-0x0000000183D6D330
		public bool GenerateNormals { get => default; set {} } // 0x0000000183D6D170-0x0000000183D6D180 0x0000000183D6D310-0x0000000183D6D320
		public bool PushTransformToHoudini { get => default; set {} } // 0x0000000183D6D1E0-0x0000000183D6D1F0 0x0000000183D6D360-0x0000000183D6D370
		public bool TransformChangeTriggersCooks { get => default; set {} } // 0x0000000183D6D200-0x0000000183D6D210 0x0000000183D6D390-0x0000000183D6D3A0
		public bool CookingTriggersDownCooks { get => default; set {} } // 0x0000000183D5C290-0x0000000183D5C2A0 0x0000000183D6D250-0x0000000183D6D260
		public bool AutoCookOnParameterChange { get => default; set {} } // 0x0000000183D6D100-0x0000000183D6D110 0x0000000183D6D230-0x0000000183D6D240
		public bool IgnoreNonDisplayNodes { get => default; set {} } // 0x0000000183D6D190-0x0000000183D6D1A0 0x0000000183D6D340-0x0000000183D6D350
		public bool UseOutputNodes { get => default; set {} } // 0x0000000183D58E20-0x0000000183D58E30 0x0000000183D6D3B0-0x0000000183D6D3C0
		public bool GenerateMeshUsingPoints { get => default; set {} } // 0x0000000183D6D160-0x0000000183D6D170 0x0000000183D6D300-0x0000000183D6D310
		public bool UseLODGroups { get => default; set {} } // 0x0000000183D6D210-0x0000000183D6D220 0x0000000183D6D3A0-0x0000000183D6D3B0
		public bool SplitGeosByGroup { get => default; set {} } // 0x0000000183D5ACA0-0x0000000183D5ACB0 0x0000000183D6D380-0x0000000183D6D390
		public bool SessionSyncAutoCook { get => default; set {} } // 0x0000000183D56B40-0x0000000183D56B50 0x0000000183D6D370-0x0000000183D6D380
		public bool BakeUpdateKeepPreviousTransformValues { get => default; set {} } // 0x0000000183D5ACB0-0x0000000183D5ACC0 0x0000000183D6D240-0x0000000183D6D250
		public bool PauseCooking { get => default; set {} } // 0x0000000183D6D1D0-0x0000000183D6D1E0 0x0000000183D6D350-0x0000000183D6D360
		public bool CurveEditorEnabled { get => default; set {} } // 0x0000000183D5ACD0-0x0000000183D5ACE0 0x0000000183D6D280-0x0000000183D6D290
		public HEU_CurveDrawCollisionWrapper CurveDrawCollision { get => default; set {} } // 0x00000001887EF07C-0x00000001887EF08C 0x00000001887EF0B0-0x00000001887EF0D0
		public LayerMask CurveDrawLayerMask { get => default; set {} } // 0x0000000183D5A250-0x0000000183D5A260 0x0000000183D5A290-0x0000000183D5A2A0
		public float CurveProjectMaxDistance { get => default; set {} } // 0x0000000183D59A40-0x0000000183D59A50 0x0000000183D6D2E0-0x0000000183D6D2F0
		public Vector3 CurveProjectDirection { get => default; set {} } // 0x0000000183D5AD60-0x0000000183D5AD80 0x0000000183D6D2C0-0x0000000183D6D2E0
		public bool CurveProjectDirectionToView { get => default; set {} } // 0x0000000183D6D150-0x0000000183D6D160 0x0000000183D6D2B0-0x0000000183D6D2C0
		public bool CurveDisableScaleRotation { get => default; set {} } // 0x0000000183D6D120-0x0000000183D6D130 0x0000000183D6D270-0x0000000183D6D280
		public bool CurveFrameSelectedNodes { get => default; set {} } // 0x0000000183D6D140-0x0000000183D6D150 0x0000000183D6D2A0-0x0000000183D6D2B0
		public float CurveFrameSelectedNodeDistance { get => default; set {} } // 0x0000000183D59960-0x0000000183D59970 0x0000000183D6D290-0x0000000183D6D2A0
		public bool HandlesEnabled { get => default; set {} } // 0x0000000183D57C20-0x0000000183D57C30 0x0000000183D6D330-0x0000000183D6D340
		public bool EditableNodesToolsEnabled { get => default; set {} } // 0x0000000183D5BEE0-0x0000000183D5BEF0 0x0000000183D6D2F0-0x0000000183D6D300
		public HEU_AssetTypeWrapper AssetType { get => default; } // 0x00000001887EF040-0x00000001887EF06C 
		public HAPI_AssetInfo AssetInfo { get => default; } // 0x0000000183D6D0D0-0x0000000183D6D100 
		public HAPI_NodeInfo NodeInfo { get => default; } // 0x0000000183D6D1A0-0x0000000183D6D1D0 
		public string AssetName { get => default; } // 0x0000000183D4EA80-0x0000000183D4EA90 
		public string AssetOpName { get => default; } // 0x0000000183D4EB10-0x0000000183D4EB20 
		public string AssetHelp { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
		public int AssetID { get => default; } // 0x0000000183D57DA0-0x0000000183D57DB0 
		public string AssetPath { get => default; } // 0x0000000183D50E60-0x0000000183D50E70 
		public GameObject OwnerGameObject { get => default; } // 0x000000018426FB4C-0x000000018426FB54 
		public GameObject RootGameObject { get => default; } // 0x0000000183D51140-0x0000000183D51150 
		public List<HEU_MaterialData> MaterialCache { get => default; } // 0x0000000183D50EA0-0x0000000183D50EB0 
		public HEU_Parameters Parameters { get => default; } // 0x0000000183D51950-0x0000000183D51960 
		public string AssetCacheFolder { get => default; } // 0x0000000183D57300-0x0000000183D57310 
		public string[] SubassetNames { get => default; } // 0x0000000183D571B0-0x0000000183D571C0 
		public int SelectedSubassetIndex { get => default; } // 0x0000000183D6D1F0-0x0000000183D6D200 
		public HEU_AssetCookStatusWrapper CookStatus { get => default; } // 0x00000001887EF06C-0x00000001887EF07C 
		public HEU_AssetCookResultWrapper LastCookResult { get => default; } // 0x00000001887EF08C-0x00000001887EF0B0 
		public long SessionID { get => default; } // 0x0000000183D56AF0-0x0000000183D56B00 
		public List<HEU_Curve> Curves { get => default; } // 0x0000000183D50350-0x0000000183D50360 
		public List<HEU_InputNode> InputNodes { get => default; } // 0x0000000183D57430-0x0000000183D57440 
		public List<HEU_VolumeCache> VolumeCaches { get => default; } // 0x0000000183D57220-0x0000000183D57230 
		public HEU_ReloadDataEvent ReloadDataEvent { get => default; } // 0x0000000183D57170-0x0000000183D57180 
		public HEU_CookedDataEvent CookedDataEvent { get => default; } // 0x0000000183D57160-0x0000000183D57170 
		public HEU_BakedDataEvent BakedDataEvent { get => default; } // 0x0000000183D57130-0x0000000183D57140 
		public HEU_PreAssetEvent PreAssetEvent { get => default; } // 0x0000000183D571E0-0x0000000183D571F0 
		internal HEU_AssetType AssetTypeInternal { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		[SerializeField]
		internal bool WarnedPrefabNotSupported { get; set; } // 0x0000000183D57C30-0x0000000183D57C40 0x0000000183D5A070-0x0000000183D5A080
		[SerializeField]
		internal HEU_InstanceInputUIState InstanceInputUIState { get => default; set {} } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000184275BD4-0x0000000184275BE8
		internal UpdateUIDelegate RefreshUIDelegate { get => default; set {} } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000184275C7C-0x0000000184275C90
		internal HEU_Curve.CurveDrawCollision CurveDrawCollisionInternal { get => default; } // 0x0000000183D6D130-0x0000000183D6D140 
		internal bool CurveCookOnDrag { get => default; set {} } // 0x0000000183D6D110-0x0000000183D6D120 0x0000000183D6D260-0x0000000183D6D270
		internal List<HEU_Handle> Handles { get => default; } // 0x0000000183D57480-0x0000000183D57490 
		internal List<HEU_AttributesStore> AttributeStores { get => default; } // 0x0000000183D56B10-0x0000000183D56B20 
		internal HEU_ToolsInfo ToolsInfo { get => default; } // 0x0000000183D57350-0x0000000183D57360 
		internal HEU_AssetSerializedMetaData SerializedMetaData { get => default; } // 0x0000000183D57440-0x0000000183D57450 
		internal bool PendingAutoCookOnMouseRelease { get => default; set {} } // 0x0000000183D57B60-0x0000000183D57B70 0x0000000183D59550-0x0000000183D59560
	
		// Nested types
		internal enum HEU_AssetType // TypeDefIndex: 49532
		{
			TYPE_INVALID = 0,
			TYPE_HDA = 1,
			TYPE_CURVE = 2,
			TYPE_INPUT = 3
		}
	
		internal enum AssetBuildAction // TypeDefIndex: 49533
		{
			NONE = 0,
			RELOAD = 1,
			COOK = 2,
			INVALID = 3,
			STRIP_HEDATA = 4,
			DUPLICATE = 5,
			RESET_PARAMS = 6
		}
	
		internal enum AssetCookStatus // TypeDefIndex: 49534
		{
			NONE = 0,
			COOKING = 1,
			POSTCOOK = 2,
			LOADING = 3,
			POSTLOAD = 4,
			PRELOAD = 5,
			SELECT_SUBASSET = 6
		}
	
		internal enum AssetCookResult // TypeDefIndex: 49535
		{
			NONE = 0,
			SUCCESS = 1,
			ERRORED = 2
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 49536; 0x00000001842BE03C-0x00000001842BE04C
	
		private enum AssetInstantiationMethod // TypeDefIndex: 49537
		{
			DEFAULT = 0,
			DUPLICATED = 1,
			UNDO = 2
		}
	
		// Constructors
		public HEU_HoudiniAsset() {} // 0x00000001887EEDC4-0x00000001887EF040
	
		// Methods
		internal AssetCookStatus GetCookStatus() => default; // 0x0000000183D6D0A0-0x0000000183D6D0B0
		internal AssetCookResult GetLastCookResult() => default; // 0x0000000183D5DB50-0x0000000183D5DB60
		internal List<Collider> GetCurveDrawColliders() => default; // 0x0000000183D50340-0x0000000183D50350
		internal LayerMask GetCurveDrawLayerMask() => default; // 0x0000000183D5A250-0x0000000183D5A260
		internal void SetCurveDrawLayerMask(LayerMask mask) {} // 0x0000000183D5A290-0x0000000183D5A2A0
		public bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x01FBD564 */, bool bAsync = false /* Metadata: 0x01FBD565 */, bool bSkipCookCheck = true /* Metadata: 0x01FBD566 */, bool bUploadParameters = true /* Metadata: 0x01FBD567 */) => default; // 0x000000018232EB60-0x000000018232EB70
		public bool RequestReload(bool bAsync = false /* Metadata: 0x01FBD568 */) => default; // 0x000000018232EB60-0x000000018232EB70
		public bool RequestResetParameters(bool bAsync = false /* Metadata: 0x01FBD569 */) => default; // 0x000000018232EB60-0x000000018232EB70
		public GameObject DuplicateAsset(GameObject newRootGameObject = null) => default; // 0x00000001887E3DE4-0x00000001887E4164
		public bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x01FBD56A */) => default; // 0x00000001887E312C-0x00000001887E33BC
		public GameObject BakeToNewPrefab(string destinationPrefabPath = null) => default; // 0x00000001887E02A8-0x00000001887E05BC
		public GameObject BakeToNewStandalone() => default; // 0x00000001887E05BC-0x00000001887E0714
		public bool BakeToExistingPrefab(GameObject bakeTargetGO) => default; // 0x00000001887DF054-0x00000001887DF6CC
		public bool BakeToExistingStandalone(GameObject bakeTargetGO) => default; // 0x00000001887DF6CC-0x00000001887E02A8
		public bool IsAssetValid() => default; // 0x00000001887E8DA0-0x00000001887E8DDC
		public bool GetOutputGameObjects(List<GameObject> outputObjects) => default; // 0x00000001887E7518-0x00000001887E7640
		public bool GetOutput(List<HEU_GeneratedOutput> outputs) => default; // 0x00000001887E7768-0x00000001887E7890
		public HEU_Curve GetCurve(string curveName) => default; // 0x00000001887E5E20-0x00000001887E5F8C
		public bool AddCurveDrawCollider(Collider newCollider) => default; // 0x00000001887DE554-0x00000001887DE5DC
		public bool RemoveCurveDrawCollider(Collider collider) => default; // 0x00000001887EB6D0-0x00000001887EB72C
		public bool ClearCurveDrawColliders() => default; // 0x00000001887E0F1C-0x00000001887E0F68
		public HEU_InputNode GetInputNode(string inputName) => default; // 0x00000001887E64B8-0x00000001887E65FC
		public HEU_InputNode GetAssetInputNode(string inputName) => default; // 0x00000001887E5204-0x00000001887E534C
		public HEU_InputNode GetInputNodeByIndex(int index) => default; // 0x00000001887E6444-0x00000001887E64B8
		public List<HEU_InputNode> GetNonParameterInputNodes() => default; // 0x00000001887E6AE8-0x00000001887E6F68
		public int GetVolumeCacheCount() => default; // 0x00000001887E7B84-0x00000001887E7BC8
		public HEU_SessionBase GetAssetSession(bool bCreateIfInvalid) => default; // 0x00000001887E5B14-0x00000001887E5B8C
		public HEU_ObjectNode GetObjectNodeByName(string objName) => default; // 0x00000001887E6F68-0x00000001887E7238
		public void GetOutputGeoNodes(List<HEU_GeoNode> outputGeoNodes) {} // 0x00000001887E7640-0x00000001887E7768
		public HEU_PartData GetInternalHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x00000001887E6830-0x00000001887E698C
		public void ResetParametersToDefault() {} // 0x00000001887EC34C-0x00000001887EC730
		public void HideAllGeometry() {} // 0x00000001887E8178-0x00000001887E8290
		public void DisableAllColliders() {} // 0x00000001887E3420-0x00000001887E3538
		public HEU_MaterialData GetMaterialData(Material material) => default; // 0x00000001887E698C-0x00000001887E6AE8
		public void ClearMaterialCache() {} // 0x00000001887E1378-0x00000001887E13C0
		public void RemoveMaterial(Material material) {} // 0x00000001887EB834-0x00000001887EB94C
		public void ResetMaterialOverrides() {} // 0x00000001887EC1F0-0x00000001887EC34C
		public HEU_AssetPreset GetAssetPreset() => default; // 0x00000001887E534C-0x00000001887E5B14
		public HEU_PDGAssetLink GetOrCreatePDGAssetLink() => default; // 0x00000001887E73B0-0x00000001887E7518
		public static HEU_HoudiniAssetRoot InstantiateHDA(string filePath, bool bAsync = false /* Metadata: 0x01FBD56B */, Vector3 initialPosition = default) => default; // 0x00000001887E8298-0x00000001887E8358
		public static HEU_PartData GetSceneHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x00000001887E79B0-0x00000001887E7AEC
		public static HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(GameObject outputGameObject) => default; // 0x00000001887E7890-0x00000001887E79B0
		public static bool IsHoudiniAssetOutput(GameObject go) => default; // 0x00000001887E9D5C-0x00000001887E9E88
		public static bool IsHoudiniAssetRoot(GameObject go) => default; // 0x00000001887E9E88-0x00000001887E9EF4
		internal void SetupAsset(HEU_AssetType assetType, string filePath, GameObject rootGameObject, HEU_SessionBase session) {} // 0x00000001887ECAD8-0x00000001887ECECC
		internal void CleanUpAndDisable() {} // 0x00000001887E0944-0x00000001887E09BC
		internal bool IsAssetSavedInScene() => default; // 0x00000001887E8D50-0x00000001887E8D6C
		private void Awake() {} // 0x000000018350B670-0x000000018350B680
		internal void InvalidateAsset() {} // 0x0000000183D6D0B0-0x0000000183D6D0C0
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x000000018350B670-0x000000018350B680
		internal void AssetUpdate() {} // 0x000000018350B670-0x000000018350B680
		internal void PostAssetUpdate() {} // 0x000000018350B670-0x000000018350B680
		internal void RequestBakeInPlace() {} // 0x00000001887EBF20-0x00000001887EBF34
		internal void ClearBuildRequest() {} // 0x0000000183D6D080-0x0000000183D6D0A0
		private bool HasValidAssetPath() => default; // 0x00000001887E8160-0x00000001887E8178
		private void ProcessRebuild(bool bPromptForSubasset, int desiredSubassetIndex) {} // 0x00000001887EAFF4-0x00000001887EB22C
		private void InvokeReloadEvent(bool bCookSuccess, List<GameObject> outputObjects) {} // 0x00000001887E8C94-0x00000001887E8D50
		private bool StartRebuild(bool bPromptForSubasset, int desiredSubassetIndex) => default; // 0x00000001887ECEF0-0x00000001887ED068
		private bool FinishRebuild() => default; // 0x00000001887E4200-0x00000001887E4818
		private bool RecookAsync(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync) => default; // 0x00000001887EB36C-0x00000001887EB48C
		private bool RecookBlocking(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync) => default; // 0x00000001887EB48C-0x00000001887EB678
		private void DoPostCookWork(HEU_SessionBase session) {} // 0x00000001887E35C8-0x00000001887E390C
		internal bool IsValidForInteraction(ref string errorMessage) => default; // 0x00000001887E9EF4-0x00000001887E9F64
		private void OnValidate() {} // 0x00000001887EA8DC-0x00000001887EA910
		private void ExecutePostCookCallbacks() {} // 0x00000001887E4164-0x00000001887E4200
		private void InvokePostCookEvent(bool bCookSuccess, List<GameObject> outputObjects) {} // 0x00000001887E8BD8-0x00000001887E8C94
		private bool InternalStartRecook(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync) => default; // 0x00000001887E84B0-0x00000001887E8B18
		private void InternalSetAssetID(int assetID) {} // 0x00000001887E8358-0x00000001887E84B0
		private void SetCookStatus(AssetCookStatus status, AssetCookResult result) {} // 0x0000000183D6D0C0-0x0000000183D6D0D0
		private void ProcessPoskCook() {} // 0x00000001887EAC18-0x00000001887EAFF4
		private bool StartHoudiniCookNode(HEU_SessionBase session) => default; // 0x00000001887ECECC-0x00000001887ECEF0
		private void ProcessHoudiniCookStatus(bool bAsync) {} // 0x00000001887EAA68-0x00000001887EAC18
		internal bool DoesAssetRequireRecook() => default; // 0x00000001887E390C-0x00000001887E3D60
		internal void DeleteSessionDataOnly() {} // 0x00000001887E340C-0x00000001887E3420
		private void CleanUpInputNodes() {} // 0x00000001887E0ABC-0x00000001887E0CE4
		internal void DeleteAssetCacheData(bool bRegisterUndo) {} // 0x00000001887E33BC-0x00000001887E340C
		private void GenerateParameters(HEU_SessionBase session) {} // 0x00000001887E4FF0-0x00000001887E5204
		private void DownloadParameterPresetFromHoudini(HEU_SessionBase session) {} // 0x00000001887E3D60-0x00000001887E3DE4
		private void UploadParameterPresetToHoudini(HEU_SessionBase session) {} // 0x00000001887EEB74-0x00000001887EED58
		private void UpdateParameterInputsToHoudini(HEU_SessionBase session, bool bForceUpdate) {} // 0x00000001887EDEA0-0x00000001887EDF38
		private bool LoadAssetFileWithSubasset(HEU_SessionBase session, bool bPromptForSubasset, int desiredSubassetIndex) => default; // 0x00000001887E9F64-0x00000001887EA240
		private bool CreateAndCookAsset(HEU_SessionBase session, int subassetIndex, out int newAssetID, bool bCookTemplatedGeos) {
			newAssetID = default;
			return default;
		} // 0x00000001887E2A90-0x00000001887E2BB8
		private void CreateAssetInputs(HEU_SessionBase session) {} // 0x00000001887E2BB8-0x00000001887E2F0C
		public void ForceUploadParameters(HEU_SessionBase session) {} // 0x00000001887E4818-0x00000001887E484C
		private void UploadCurvesParameters(HEU_SessionBase session, bool bCheckParamsChanged) {} // 0x00000001887EE548-0x00000001887EE9A4
		private void UploadAttributeValues(HEU_SessionBase session) {} // 0x00000001887EDFA4-0x00000001887EE548
		private void SyncDirtyAttributesToHoudini(HEU_SessionBase session) {} // 0x00000001887ED14C-0x00000001887ED294
		private void UploadInputNodes(HEU_SessionBase session, bool bForceUpdate, bool bUpdateAll) {} // 0x00000001887EE9A4-0x00000001887EEB74
		internal bool HasInputNodeTransformChanged() => default; // 0x00000001887E7D6C-0x00000001887E7EBC
		private void NotifyInputNodesCookFinished() {} // 0x00000001887EA708-0x00000001887EA820
		private bool CreateObjects(HEU_SessionBase session) => default; // 0x00000001887E2FF0-0x00000001887E3104
		private void UpdateAllObjectNodes(HEU_SessionBase session) {} // 0x00000001887ED464-0x00000001887EDB98
		private HEU_ObjectNode CreateObjectNode(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo, ref HAPI_Transform objectTranform) => default; // 0x00000001887E2F0C-0x00000001887E2FF0
		private void GenerateObjectsGeometry(HEU_SessionBase session, bool bRebuild) {} // 0x00000001887E4EB8-0x00000001887E4FF0
		internal int NumAttributeStores() => default; // 0x00000001887EA854-0x00000001887EA898
		internal HEU_AttributesStore GetAttributeStore(string geoName, int partID) => default; // 0x00000001887E5B8C-0x00000001887E5CEC
		private void GenerateAttributesStore(HEU_SessionBase session) {} // 0x00000001887E484C-0x00000001887E4974
		private void GenerateInstances(HEU_SessionBase session) {} // 0x00000001887E4B3C-0x00000001887E4EB8
		private void GenerateHandles(HEU_SessionBase session) {} // 0x00000001887E4974-0x00000001887E4B3C
		internal void CleanUpHandles() {} // 0x00000001887E09BC-0x00000001887E0ABC
		internal HEU_Handle GetHandleByName(string handleName) => default; // 0x00000001887E60C4-0x00000001887E6200
		internal List<HEU_Handle> GetHandles() => default; // 0x0000000183D57480-0x0000000183D57490
		internal int NumHandles() => default; // 0x00000001887EA898-0x00000001887EA8DC
		internal HAPI_Transform GetObjectTransform(HEU_SessionBase session, int objectID) => default; // 0x00000001887E7238-0x00000001887E72F4
		internal HEU_ObjectNode GetObjectWithID(int objId) => default; // 0x00000001887E72F4-0x00000001887E73B0
		private void InvokeBakedEvent(bool bSuccess, List<GameObject> outputObjects, bool isNewBake) {} // 0x00000001887E8B18-0x00000001887E8BD8
		private GameObject CloneAssetWithoutHDA(ref string bakedAssetPath, bool bWriteMeshesToAssetDatabase, bool bReconnectPrefabInstances) => default; // 0x00000001887E13C0-0x00000001887E18F4
		internal void NotifyUpstreamCooked(HEU_CookedEventData Data) {} // 0x00000001887EA820-0x00000001887EA854
		internal void ConnectToUpstream(HEU_HoudiniAsset upstreamAsset) {} // 0x00000001887E18F4-0x00000001887E1984
		internal void DisconnectFromUpstream(HEU_HoudiniAsset upstreamAsset) {} // 0x00000001887E3538-0x00000001887E35C8
		private void AddDownstreamConnection(UnityAction<HEU_CookedEventData> receiver) {} // 0x00000001887DE660-0x00000001887DE6E0
		private void RemoveDownstreamConnection(UnityAction<HEU_CookedEventData> receiver) {} // 0x00000001887EB784-0x00000001887EB7DC
		private void ClearAllUpstreamConnections() {} // 0x00000001887E0CE4-0x00000001887E0F1C
		private void UpdateInputsOnAssetRecreation(HEU_SessionBase session) {} // 0x00000001887EDD78-0x00000001887EDEA0
		internal void ReconnectInputsUpstreamNotifications() {} // 0x00000001887EB22C-0x00000001887EB36C
		internal void GetHoudiniTransformAndApply(HEU_SessionBase session) {} // 0x00000001887E6200-0x00000001887E6444
		internal void UploadUnityTransform(HEU_SessionBase session, bool bOnlySendIfChangedFromLastSync) {} // 0x00000001887EED58-0x00000001887EEDC4
		private void UpdateHoudiniMaterials(HEU_SessionBase session) {} // 0x00000001887EDB98-0x00000001887EDD78
		private void RemoveUnusedMaterials() {} // 0x00000001887EB94C-0x00000001887EBD34
		internal bool IsAssetValidInHoudini(HEU_SessionBase session) => default; // 0x00000001887E8D6C-0x00000001887E8DA0
		internal bool HasTransformChangedSinceLastUpdate() => default; // 0x00000001887E7EBC-0x00000001887E8160
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x00000001887E5CEC-0x00000001887E5E20
		internal void ClearInvalidCurves() {} // 0x00000001887E0F68-0x00000001887E1090
		internal int GetEditableCurveCount() => default; // 0x00000001887E5F8C-0x00000001887E60C4
		internal void AddCurve(HEU_Curve curve) {} // 0x00000001887DE5DC-0x00000001887DE660
		internal void RemoveCurve(HEU_Curve curve) {} // 0x00000001887EB72C-0x00000001887EB784
		internal List<HEU_InputNode> GetInputNodes() => default; // 0x0000000183D57430-0x0000000183D57440
		internal void AddInputNode(HEU_InputNode node) {} // 0x00000001887DE6E0-0x00000001887DE764
		internal void RemoveInputNode(HEU_InputNode node) {} // 0x00000001887EB7DC-0x00000001887EB834
		internal void InputNodeNotifyRemoved(HEU_InputNode node) {} // 0x00000001887E8290-0x00000001887E8298
		internal void AddVolumeCache(HEU_VolumeCache cache) {} // 0x00000001887DE7D0-0x00000001887DE854
		internal void RemoveVolumeCache(HEU_VolumeCache cache) {} // 0x00000001887EBD98-0x00000001887EBE1C
		internal void AddAttributeStore(HEU_AttributesStore attributeStore) {} // 0x00000001887DE400-0x00000001887DE554
		internal void RemoveAttributeStore(HEU_AttributesStore attributeStore) {} // 0x00000001887EB678-0x00000001887EB6D0
		internal void ReorderAttributeStore(int oldIndex, int newIndex) {} // 0x00000001887EBE1C-0x00000001887EBF20
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos) {} // 0x00000001887EA910-0x00000001887EAA68
		internal void AddToAssetDBCache(string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref UnityEngine.Object targetAssetDBObject) {} // 0x00000001887DE764-0x00000001887DE7D0
		internal static void SetCurvesVisibilityInScene(bool bShow) {} // 0x00000001887EC730-0x00000001887EC900
		internal string GetValidAssetCacheFolderPath() => default; // 0x00000001887E7AEC-0x00000001887E7B84
		internal void CalculateVisibility() {} // 0x00000001887E082C-0x00000001887E0944
		internal void CalculateColliderState() {} // 0x00000001887E0714-0x00000001887E082C
		internal void LoadAssetPresetAndCook(HEU_AssetPreset assetPreset) {} // 0x00000001887EA240-0x00000001887EA708
		internal void ApplyRecookPreset() {} // 0x00000001887DEB6C-0x00000001887DEC0C
		private bool ApplyInputPresets(HEU_SessionBase session, List<HEU_InputPreset> inputPresets, bool bAddMissingInputsToRecookPreset) => default; // 0x00000001887DE854-0x00000001887DEB6C
		internal HEU_VolumeCachePreset GetVolumeCachePreset(string objName, string geoName, int tile) => default; // 0x00000001887E7BC8-0x00000001887E7D6C
		internal void RemoveVolumeCachePreset(HEU_VolumeCachePreset preset) {} // 0x00000001887EBD34-0x00000001887EBD98
		private bool ApplyVolumeCachePresets(List<HEU_VolumeCachePreset> volumeCachePresets) => default; // 0x00000001887DEC0C-0x00000001887DEFC4
		internal void SyncInternalParametersForUndoCompare() {} // 0x00000001887ED294-0x00000001887ED464
		internal bool UpdateSessionSync() => default; // 0x00000001887EDF38-0x00000001887EDF90
		internal void UpdateTotalCookCount() {} // 0x00000001887EDF90-0x00000001887EDFA4
		private void ResetAndCopyInstantiatedProperties(HEU_HoudiniAsset newAsset) {} // 0x00000001887EBF34-0x00000001887EC1F0
		private AssetInstantiationMethod GetInstantiationMethod() => default; // 0x00000001887E6688-0x00000001887E6830
		private HEU_HoudiniAsset GetInstantiatedObject() => default; // 0x00000001887E65FC-0x00000001887E6688
		private void ClearInvalidLists() {} // 0x00000001887E1090-0x00000001887E1378
		private void CopyPropertiesTo(HEU_HoudiniAsset newAsset) {} // 0x00000001887E1984-0x00000001887E2A90
		internal void SetSoftDeleted() {} // 0x00000001887EC900-0x00000001887ECAD8
		private void SyncChildTransforms() {} // 0x00000001887ED068-0x00000001887ED14C
		internal static HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(AssetCookStatus assetCookStatus) => default; // 0x00000001887DEFE4-0x00000001887DF02C
		internal static AssetCookStatus AssetCookStatus_WrapperToInternal(HEU_AssetCookStatusWrapper assetCookStatus) => default; // 0x00000001887DEFE4-0x00000001887DF02C
		internal static HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(AssetCookResult assetCookResult) => default; // 0x00000001887DEFC4-0x00000001887DEFE4
		internal static AssetCookResult AssetCookResult_WrapperToInternal(HEU_AssetCookResultWrapper assetCookResult) => default; // 0x00000001887DEFC4-0x00000001887DEFE4
		internal static HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HEU_Curve.CurveDrawCollision curveDrawCollision) => default; // 0x00000001887E3104-0x00000001887E311C
		internal static HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HEU_CurveDrawCollisionWrapper curveDrawCollision) => default; // 0x00000001887E311C-0x00000001887E312C
		internal static HEU_AssetTypeWrapper AssetType_InternalToWrapper(HEU_AssetType assetType) => default; // 0x00000001887DF02C-0x00000001887DF054
		internal static HEU_AssetType AssetType_WrapperToInternal(HEU_AssetTypeWrapper assetType) => default; // 0x00000001887DF02C-0x00000001887DF054
		public bool IsEquivalentTo(HEU_HoudiniAsset asset) => default; // 0x00000001887E8DDC-0x00000001887E9D5C
	}

	[ExecuteInEditMode]
	[SelectionBase]
	public class HEU_HoudiniAssetRoot : MonoBehaviour // TypeDefIndex: 49542
	{
		// Fields
		[SerializeField]
		internal HEU_HoudiniAsset _houdiniAsset; // 0x18
		[SerializeField]
		internal List<GameObject> _bakeTargets; // 0x20
	
		// Properties
		public HEU_HoudiniAsset HoudiniAsset { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public List<GameObject> BakeTargets { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public HEU_HoudiniAssetRoot() {} // 0x00000001887F4820-0x00000001887F48A0
	
		// Methods
		private void OnDestroy() {} // 0x00000001887F4614-0x00000001887F46B8
		internal void RemoveHoudiniEngineAssetData() {} // 0x00000001887F46B8-0x00000001887F4764
		internal void ClearHoudiniEngineReferences() {} // 0x00000001887F45B0-0x00000001887F4604
		internal static void DestroyRootComponent(HEU_HoudiniAssetRoot assetRoot) {} // 0x00000001887F4604-0x00000001887F4614
		internal void Reset() {} // 0x00000001887F4764-0x00000001887F4820
	}

	public class HEU_InputNode : ScriptableObject, IHEU_InputNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_InputNode> // TypeDefIndex: 49547
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
		internal bool _usingSelectFromHierarchy; // 0x98
		public HEU_InputNodeUICache _uiCache; // 0xA0
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public bool KeepWorldTransform { get => default; set {} } // 0x0000000183D58A60-0x0000000183D58A70 0x0000000183D58A90-0x0000000183D58AA0
		public bool PackGeometryBeforeMerging { get => default; set {} } // 0x0000000183D6CFA0-0x0000000183D6CFB0 0x0000000183D6D3E0-0x0000000183D6D3F0
		public HEU_InputNodeTypeWrapper NodeType { get => default; } // 0x00000001887F9420-0x00000001887F9440 
		public HEU_InputObjectTypeWrapper ObjectType { get => default; } // 0x00000001887F9440-0x00000001887F944C 
		public HEU_InputObjectTypeWrapper PendingObjectType { get => default; set {} } // 0x00000001887F944C-0x00000001887F9458 0x00000001887F9458-0x00000001887F9478
		public int InputNodeID { get => default; } // 0x0000000183D4EED0-0x0000000183D4EEE0 
		public string InputName { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public string LabelName { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public string ParamName { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public HEU_InputInterfaceMeshSettings MeshSettings { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public HEU_InputInterfaceTilemapSettings TilemapSettings { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		internal InputNodeType InputType { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		internal List<HEU_InputObjectInfo> InputObjects { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		internal List<HEU_InputHDAInfo> InputAssetInfos { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal bool RequiresCook { get => default; set {} } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
		internal bool RequiresUpload { get => default; set {} } // 0x0000000183D589D0-0x0000000183D589E0 0x0000000183D5B3E0-0x0000000183D5B3F0
	
		// Nested types
		internal enum InputNodeType // TypeDefIndex: 49543
		{
			CONNECTION = 0,
			NODE = 1,
			PARAMETER = 2
		}
	
		[Serializable]
		internal enum InputObjectType // TypeDefIndex: 49544
		{
			HDA = 0,
			UNITY_MESH = 1,
			CURVE = 2,
			TERRAIN = 3,
			BOUNDING_BOX = 4,
			TILEMAP = 5
		}
	
		public enum InternalObjectType // TypeDefIndex: 49545
		{
			UNKNOWN = 0,
			HDA = 1,
			UNITY_MESH = 2
		}
	
		public enum InputActions // TypeDefIndex: 49546
		{
			ACTION = 0,
			DELETE = 1,
			INSERT = 2
		}
	
		// Constructors
		public HEU_InputNode() {} // 0x00000001887F9288-0x00000001887F9420
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x00000001887F5DBC-0x00000001887F5E54
		public void Recook() {} // 0x00000001887F7A8C-0x00000001887F7AF8
		public bool IsAssetInput() => default; // 0x00000001862FD96C-0x00000001862FD974
		public int NumInputEntries() => default; // 0x00000001887F71D4-0x00000001887F7248
		public GameObject GetInputEntryGameObject(int index) => default; // 0x00000001887F5A0C-0x00000001887F5C20
		public GameObject[] GetInputEntryGameObjects() => default; // 0x00000001887F5C20-0x00000001887F5D78
		public void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x01FBD584 */) {} // 0x00000001887F8254-0x00000001887F84B0
		public void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x01FBD585 */) {} // 0x00000001887F64D0-0x00000001887F672C
		public void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x01FBD586 */) {} // 0x00000001887F4A80-0x00000001887F4B20
		public void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x01FBD587 */) {} // 0x00000001887F7DD8-0x00000001887F7E1C
		public void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x01FBD588 */) {} // 0x00000001887F4C60-0x00000001887F4CC8
		public void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x01FBD589 */) {} // 0x00000001887F7B60-0x00000001887F7D88
		public void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x01FBD58A */) {} // 0x00000001887F7AF8-0x00000001887F7B60
		public void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x01FBD58B */) {} // 0x00000001887F819C-0x00000001887F8254
		public void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x01FBD58C */) {} // 0x00000001887F80D8-0x00000001887F819C
		public void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x01FBD58D */) {} // 0x00000001887F7F48-0x00000001887F8010
		public void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x01FBD58E */) {} // 0x00000001887F8010-0x00000001887F80D8
		public bool AreAnyInputHDAsConnected() => default; // 0x00000001887F4B20-0x00000001887F4C60
		public int GetConnectedInputCount() => default; // 0x00000001887F58DC-0x00000001887F5950
		public int GetConnectedNodeID(int index) => default; // 0x00000001887F5950-0x00000001887F5A0C
		public void LoadPreset(HEU_InputPreset inputPreset) {} // 0x00000001887F6BE8-0x00000001887F6C20
		public void PopulateInputPreset(HEU_InputPreset inputPreset) {} // 0x00000001887F7248-0x00000001887F7860
		internal static HEU_InputNode CreateSetupInput(int nodeID, int inputIndex, string inputName, string labelName, InputNodeType inputNodeType, HEU_HoudiniAsset parentAsset) => default; // 0x00000001887F5404-0x00000001887F54B8
		internal void SetInputNodeID(int nodeID) {} // 0x0000000183D4EF20-0x0000000183D4EF30
		internal void DestroyAllData(HEU_SessionBase session) {} // 0x00000001887F54B8-0x00000001887F54FC
		private void ResetInputObjectTransforms() {} // 0x00000001887F7E68-0x00000001887F7F48
		internal void ResetInputNode(HEU_SessionBase session) {} // 0x00000001887F7E1C-0x00000001887F7E68
		internal HEU_InputObjectInfo AddInputEntryAtEndMesh(GameObject newEntryGameObject) => default; // 0x00000001887F4A44-0x00000001887F4A80
		internal HEU_InputHDAInfo AddInputEntryAtEndHDA(GameObject newEntryGameObject) => default; // 0x00000001887F4A08-0x00000001887F4A44
		internal void ChangeInputType(HEU_SessionBase session, InputObjectType newType) {} // 0x00000001887F4CC8-0x00000001887F4CF8
		internal void ResetConnectionForForceUpdate(HEU_SessionBase session) {} // 0x00000001887F7D88-0x00000001887F7DD8
		internal void UploadInput(HEU_SessionBase session) {} // 0x00000001887F88A0-0x00000001887F8C40
		private void UploadHDAInput(HEU_SessionBase session) {} // 0x00000001887F861C-0x00000001887F8744
		private void UploadUnityInput(HEU_SessionBase session) {} // 0x00000001887F8D58-0x00000001887F9288
		internal void ReconnectToUpstreamAsset() {} // 0x00000001887F7860-0x00000001887F7A8C
		private HEU_InputObjectInfo CreateInputObjectInfo(GameObject inputGameObject) => default; // 0x00000001887F5390-0x00000001887F5404
		private HEU_InputHDAInfo CreateInputHDAInfo(GameObject inputGameObject) => default; // 0x00000001887F5328-0x00000001887F5390
		private HEU_InputObjectInfo InternalAddInputObjectAtEnd(GameObject newInputGameObject) => default; // 0x00000001887F6798-0x00000001887F6804
		private HEU_InputHDAInfo InternalAddInputHDAAtEnd(GameObject newInputHDA) => default; // 0x00000001887F672C-0x00000001887F6798
		private void DisconnectConnectedMergeNode(HEU_SessionBase session) {} // 0x00000001887F568C-0x00000001887F57C0
		private void ClearConnectedInputHDAs() {} // 0x00000001887F4CF8-0x00000001887F4EC4
		private void ConnectToMergeObject(HEU_SessionBase session) {} // 0x00000001887F4EDC-0x00000001887F4F80
		private void DisconnectAndDestroyInputs(HEU_SessionBase session) {} // 0x00000001887F54FC-0x00000001887F568C
		internal bool UploadObjectMergeTransformType(HEU_SessionBase session) => default; // 0x00000001887F8CCC-0x00000001887F8D58
		private bool UploadObjectMergePackGeometry(HEU_SessionBase session) => default; // 0x00000001887F8C40-0x00000001887F8CCC
		internal bool HasInputNodeTransformChanged() => default; // 0x00000001887F6014-0x00000001887F6480
		internal void UploadInputObjectTransforms(HEU_SessionBase session) {} // 0x00000001887F8744-0x00000001887F88A0
		internal void UpdateOnAssetRecreation(HEU_SessionBase session) {} // 0x00000001887F84B0-0x00000001887F861C
		internal void CopyInputValuesTo(HEU_SessionBase session, HEU_InputNode destInputNode) {} // 0x00000001887F4F80-0x00000001887F5328
		internal void LoadPreset(HEU_SessionBase session, HEU_InputPreset inputPreset) {} // 0x00000001887F6C20-0x00000001887F715C
		private bool FindAddToInputHDA(string gameObjectName) => default; // 0x00000001887F57C0-0x00000001887F58DC
		internal void NotifyParentRemovedInput() {} // 0x00000001887F715C-0x00000001887F71D4
		internal void ClearUICache() {} // 0x00000001887F4EC4-0x00000001887F4EDC
		internal void HandleSelectedObjectsForInputObjects(GameObject[] selectedObjects) {} // 0x00000001887F5F34-0x00000001887F6014
		internal void HandleSelectedObjectsForInputHDAs(GameObject[] selectedObjects) {} // 0x00000001887F5E54-0x00000001887F5F34
		public bool IsEquivalentTo(HEU_InputNode other) => default; // 0x00000001887F6804-0x00000001887F6BE8
		internal static InternalObjectType GetInternalObjectType(InputObjectType type) => default; // 0x00000001887F5D78-0x00000001887F5DBC
		internal static HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(InputNodeType inputNodeType) => default; // 0x00000001887DEFC4-0x00000001887DEFE4
		internal static InputNodeType InputNodeType_InternalToWrapper(HEU_InputNodeTypeWrapper inputNodeType) => default; // 0x00000001887DEFC4-0x00000001887DEFE4
		internal static HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(InputObjectType inputType) => default; // 0x00000001887F6480-0x00000001887F64D0
		internal static InputObjectType InputObjectType_WrapperToInternal(HEU_InputObjectTypeWrapper inputType) => default; // 0x00000001887F6480-0x00000001887F64D0
	}

	[Serializable]
	internal class HEU_InputObjectInfo : IEquivable<HEU_InputObjectInfo> // TypeDefIndex: 49548
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
		public HEU_InputObjectInfo() {} // 0x00000001887F98C0-0x00000001887F99BC
	
		// Methods
		public void CopyTo(HEU_InputObjectInfo destObject) {} // 0x00000001887F9478-0x00000001887F957C
		internal void SetReferencesFromGameObject() {} // 0x00000001887F97D8-0x00000001887F98C0
		public bool IsEquivalentTo(HEU_InputObjectInfo other) => default; // 0x00000001887F957C-0x00000001887F97D8
	}

	[Serializable]
	internal class HEU_InputHDAInfo : IEquivable<HEU_InputHDAInfo> // TypeDefIndex: 49549
	{
		// Fields
		public GameObject _pendingGO; // 0x10
		public GameObject _connectedGO; // 0x18
		public int _connectedInputNodeID; // 0x20
		public int _connectedMergeNodeID; // 0x24
	
		// Constructors
		public HEU_InputHDAInfo() {} // 0x0000000183D6D3D0-0x0000000183D6D3E0
	
		// Methods
		public void CopyTo(HEU_InputHDAInfo destInfo) {} // 0x00000001887F48A0-0x00000001887F48E4
		public bool IsEquivalentTo(HEU_InputHDAInfo other) => default; // 0x00000001887F48E4-0x00000001887F4948
	}

	public class HEU_InputNodeUICache // TypeDefIndex: 49552
	{
		// Fields
		public List<HEU_InputObjectUICache> _inputObjectCache; // 0x10
		public List<HEU_InputAssetUICache> _inputAssetCache; // 0x18
	
		// Nested types
		public class HEU_InputObjectUICache // TypeDefIndex: 49550
		{
			// Constructors
			public HEU_InputObjectUICache() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class HEU_InputAssetUICache // TypeDefIndex: 49551
		{
			// Constructors
			public HEU_InputAssetUICache() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public HEU_InputNodeUICache() {} // 0x00000001887F4948-0x00000001887F4A08
	}

	[Serializable]
	internal class HEU_InstanceInputUIState : ScriptableObject, IEquivable<HEU_InstanceInputUIState> // TypeDefIndex: 49553
	{
		// Fields
		public bool _showInstanceInputs; // 0x18
		public int _numInputsToShowUI; // 0x1C
		public int _inputsPageIndexUI; // 0x20
	
		// Constructors
		public HEU_InstanceInputUIState() {} // 0x00000001887F9B3C-0x00000001887F9B50
	
		// Methods
		internal void CopyTo(HEU_InstanceInputUIState dest) {} // 0x00000001887F99BC-0x00000001887F99E4
		public bool IsEquivalentTo(HEU_InstanceInputUIState other) => default; // 0x00000001887F99E4-0x00000001887F9B3C
	}

	public class HEU_ObjectInstanceInfo : ScriptableObject, IEquivable<HEU_ObjectInstanceInfo> // TypeDefIndex: 49554
	{
		// Fields
		public List<HEU_InstancedInput> _instancedInputs; // 0x18
		public HEU_PartData _partTarget; // 0x20
		public int _instancedObjectNodeID; // 0x28
		public string _instancedObjectPath; // 0x30
		public List<GameObject> _instances; // 0x38
	
		// Constructors
		public HEU_ObjectInstanceInfo() {} // 0x00000001887F9E28-0x00000001887F9EF4
	
		// Methods
		public bool IsEquivalentTo(HEU_ObjectInstanceInfo other) => default; // 0x00000001887F9D08-0x00000001887F9E28
	}

	[Serializable]
	public class HEU_InstancedInput : IEquivable<HEU_InstancedInput> // TypeDefIndex: 49555
	{
		// Fields
		public GameObject _instancedGameObject; // 0x10
		public Vector3 _rotationOffset; // 0x18
		public Vector3 _scaleOffset; // 0x24
	
		// Constructors
		public HEU_InstancedInput() {} // 0x00000001887F9CDC-0x00000001887F9D08
	
		// Methods
		public bool IsEquivalentTo(HEU_InstancedInput other) => default; // 0x00000001887F9B50-0x00000001887F9CDC
	}

	public class HEU_ObjectNode : ScriptableObject, IHEU_ObjectNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_ObjectNode> // TypeDefIndex: 49556
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
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int ObjectID { get => default; } // 0x0000000183D4ED90-0x0000000183D4EDA0 
		public string ObjectName { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public HAPI_ObjectInfo ObjectInfo { get => default; } // 0x0000000183D5D990-0x0000000183D5D9B0 
		public List<HEU_GeoNode> GeoNodes { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public HAPI_Transform ObjectTransform { get => default; } // 0x0000000183D6D410-0x0000000183D6D430 
	
		// Constructors
		public HEU_ObjectNode() {} // 0x00000001887FCF00-0x00000001887FCF8C
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x00000001887FC010-0x00000001887FC0A4
		public void Recook() {} // 0x00000001887FCAF0-0x00000001887FCB54
		public bool IsInstanced() => default; // 0x0000000183D4F570-0x0000000183D4F580
		public bool IsVisible() => default; // 0x0000000183D4F630-0x0000000183D4F640
		public bool IsUsingMaterial(HEU_MaterialData materialData) => default; // 0x00000001887FC750-0x00000001887FC87C
		public void GetOutputGameObjects(List<GameObject> outputObjects) {} // 0x00000001887FBC74-0x00000001887FBD98
		public void GetOutput(List<HEU_GeneratedOutput> outputs) {} // 0x00000001887FBEEC-0x00000001887FC010
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x00000001887FBB1C-0x00000001887FBC74
		public HEU_GeoNode GetGeoNode(string geoName) => default; // 0x00000001887FB9DC-0x00000001887FBB1C
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly) {} // 0x00000001887FB610-0x00000001887FB744
		public void GetOutputGeoNodes(List<HEU_GeoNode> outGeoNodes) {} // 0x00000001887FBD98-0x00000001887FBEEC
		public void HideAllGeometry() {} // 0x00000001887FC0A4-0x00000001887FC1B8
		public void DisableAllColliders() {} // 0x00000001887FA57C-0x00000001887FA690
		public bool IsInstancer() => default; // 0x00000001887FC62C-0x00000001887FC750
		internal void Reset() {} // 0x00000001887FCB54-0x00000001887FCC54
		private void SyncWithObjectInfo(HEU_SessionBase session) {} // 0x00000001887FCC54-0x00000001887FCD24
		internal void Initialize(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, HAPI_Transform objectTranform, HEU_HoudiniAsset parentAsset, bool bUseOutputNodes) {} // 0x00000001887FC1B8-0x00000001887FC3B4
		internal void GatherAllAssetOutputsLegacy(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, ref List<HEU_GeoNode> geoNodes) {} // 0x00000001887FA690-0x00000001887FA73C
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x01FBD59E */) {} // 0x00000001887FA4A4-0x00000001887FA57C
		private HEU_GeoNode CreateGeoNode(HEU_SessionBase session, HAPI_GeoInfo geoInfo) => default; // 0x00000001887FA3F8-0x00000001887FA4A4
		internal void GetDebugInfo(StringBuilder sb) {} // 0x00000001887FB744-0x00000001887FB9DC
		internal void SetObjectInfo(HAPI_ObjectInfo newObjectInfo) {} // 0x0000000183D6D3F0-0x0000000183D6D410
		internal void UpdateObject(HEU_SessionBase session, bool bForceUpdate) {} // 0x00000001887FCD80-0x00000001887FCF00
		internal void GenerateGeometry(HEU_SessionBase session, bool bRebuild) {} // 0x00000001887FA860-0x00000001887FAFC8
		internal void GeneratePartInstances(HEU_SessionBase session) {} // 0x00000001887FB3A8-0x00000001887FB4CC
		internal void GenerateAttributesStore(HEU_SessionBase session) {} // 0x00000001887FA73C-0x00000001887FA860
		internal void ApplyObjectTransformToGeoNodes() {} // 0x00000001887F9EF4-0x00000001887FA014
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x00000001887FB4CC-0x00000001887FB610
		internal void GenerateObjectInstances(HEU_SessionBase session) {} // 0x00000001887FAFC8-0x00000001887FB3A8
		internal void ClearObjectInstances(HEU_SessionBase session) {} // 0x00000001887FA248-0x00000001887FA3F8
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos) {} // 0x00000001887FC87C-0x00000001887FC9CC
		internal void ProcessUnityScriptAttributes(HEU_SessionBase session) {} // 0x00000001887FC9CC-0x00000001887FCAF0
		internal void CalculateVisibility() {} // 0x00000001887FA128-0x00000001887FA248
		internal void CalculateColliderState() {} // 0x00000001887FA014-0x00000001887FA128
		public override string ToString() => default; // 0x00000001887FCD24-0x00000001887FCD80
		public bool IsEquivalentTo(HEU_ObjectNode other) => default; // 0x00000001887FC3B4-0x00000001887FC62C
	}

	public class HEU_PartData : ScriptableObject, IHEU_PartData, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_PartData> // TypeDefIndex: 49562
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
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x00000001888047AC-0x000000018880481C 
		public int PartID { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public string PartName { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int GeoID { get => default; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		public HAPI_PartType PartType { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public HEU_GeoNode ParentGeoNode { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public List<HEU_ObjectInstanceInfo> ObjectInstanceInfos { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public HEU_Curve Curve { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public int MeshVertexCount { get => default; } // 0x0000000183D4F3D0-0x0000000183D4F3E0 
		public HEU_GeneratedOutput GeneratedOutput { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public GameObject OutputGameObject { get => default; } // 0x0000000188804784-0x00000001888047AC 
	
		// Nested types
		public enum PartOutputType // TypeDefIndex: 49557
		{
			NONE = 0,
			MESH = 1,
			VOLUME = 2,
			CURVE = 3,
			INSTANCER = 4
		}
	
		// Constructors
		public HEU_PartData() {} // 0x0000000188804700-0x0000000188804784
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x0000000188803410-0x00000001888034B4
		public void Recook() {} // 0x0000000188803D60-0x0000000188803DD4
		public bool IsPartInstancer() => default; // 0x0000000188803B60-0x0000000188803B68
		public bool IsAttribInstancer() => default; // 0x0000000183D4EE90-0x0000000183D4EEA0
		public bool IsInstancerAnyType() => default; // 0x0000000188803B44-0x0000000188803B58
		public bool IsPartInstanced() => default; // 0x0000000183D4F7B0-0x0000000183D4F7C0
		public int GetPartPointCount() => default; // 0x0000000183D4EE80-0x0000000183D4EE90
		public bool IsObjectInstancer() => default; // 0x0000000183D4EFE0-0x0000000183D4EFF0
		public bool IsPartVolume() => default; // 0x0000000188803B70-0x0000000188803B78
		public bool IsPartCurve() => default; // 0x0000000188803B58-0x0000000188803B60
		public bool IsPartMesh() => default; // 0x0000000188803B68-0x0000000188803B70
		public bool IsPartEditable() => default; // 0x0000000183D4F260-0x0000000183D4F270
		public bool HaveInstancesBeenGenerated() => default; // 0x0000000183D51D50-0x0000000183D51D60
		public void SetGameObjectName(string partName) {} // 0x0000000188803DF8-0x0000000188803FF0
		public void SetGameObject(GameObject gameObject) {} // 0x0000000188803FF0-0x0000000188804020
		public void SetVolumeLayerName(string name) {} // 0x00000001851417AC-0x00000001851417C0
		public string GetVolumeLayerName() => default; // 0x00000001811AC510-0x00000001811AC520
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x01FBD59F */) {} // 0x00000001888009C0-0x0000000188800AF8
		public bool IsUsingMaterial(HEU_MaterialData materialData) => default; // 0x0000000188803B78-0x0000000188803BA4
		public void GetOutputGameObjects(List<GameObject> outputObjects) {} // 0x0000000188803304-0x00000001888033A8
		public void GetOutput(List<HEU_GeneratedOutput> outputs) {} // 0x00000001888033A8-0x0000000188803410
		public HEU_PartData GetHDAPartWithGameObject(GameObject inGameObject) => default; // 0x0000000188803120-0x0000000188803190
		public void CalculateVisibility(bool bParentVisibility, bool bParentDisplayGeo) {} // 0x00000001887FDD58-0x00000001887FDD84
		public void ClearInstances() {} // 0x00000001887FDE84-0x00000001887FDF6C
		public HEU_Curve GetCurve(bool bEditableOnly) => default; // 0x0000000188802ED4-0x0000000188802F58
		public void SetVisiblity(bool bVisibility) {} // 0x00000001888042E8-0x00000001888044B0
		public void SetColliderState(bool bEnabled) {} // 0x0000000188803DD4-0x0000000188803DF8
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(string path) => default; // 0x0000000188803240-0x0000000188803304
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(int objNodeID) => default; // 0x0000000188803190-0x0000000188803240
		public void SetTerrainOffsetPosition(Vector3 offsetPosition) {} // 0x0000000183D58910-0x0000000183D58920
		public void SetTerrainData(TerrainData terrainData, string exportPathRelative, string exportPathUser) {} // 0x0000000188804144-0x00000001888042E8
		internal void Initialize(HEU_SessionBase session, int partID, int geoID, int objectNodeID, HEU_GeoNode geoNode, ref HAPI_PartInfo partInfo, PartOutputType partOutputType, bool isEditable, bool isObjectInstancer, bool isAttribInstancer) {} // 0x00000001888034B4-0x0000000188803670
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform) {} // 0x00000001887FCFC8-0x00000001887FD100
		internal void GetDebugInfo(StringBuilder sb) {} // 0x0000000188802F58-0x0000000188803120
		internal void GetClonableObjects(List<GameObject> clonableObjects) {} // 0x0000000188802D94-0x0000000188802E38
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x0000000188802E38-0x0000000188802ED4
		private void SetObjectInstancer(bool bObjectInstancer) {} // 0x0000000183D4F010-0x0000000183D4F020
		private void ClearObjectInstanceInfos() {} // 0x00000001887FE18C-0x00000001887FE244
		internal void ClearInvalidObjectInstanceInfos() {} // 0x00000001887FDF6C-0x00000001887FE18C
		internal void ClearGeneratedData() {} // 0x00000001887FDD84-0x00000001887FDDA0
		internal void ClearGeneratedMeshOutput() {} // 0x00000001887FDDA0-0x00000001887FDE3C
		internal void ClearGeneratedVolumeOutput() {} // 0x00000001887FDE3C-0x00000001887FDE84
		internal bool GeneratePartInstances(HEU_SessionBase session) => default; // 0x0000000188802C00-0x0000000188802D94
		internal void GenerateInstancesFromObjectID(HEU_SessionBase session, int objectNodeID, string[] instancePrefixes, string[] instanceMaterialPaths) {} // 0x0000000188800D58-0x00000001888011C0
		internal void GenerateInstancesFromObject(HEU_SessionBase session, HEU_ObjectNode sourceObject, string[] instancePrefixes, string[] instanceMaterialPaths) {} // 0x000000018880183C-0x0000000188801BB0
		internal void GenerateInstancesFromObjectIds(HEU_SessionBase session, string[] instancePrefixes, string[] instanceMaterialPaths) {} // 0x00000001888011C0-0x000000018880183C
		internal void GenerateInstancesFromUnityAssetPathAttribute(HEU_SessionBase session, string unityInstanceAttr) {} // 0x0000000188801BB0-0x00000001888027CC
		private void CreateNewInstanceFromObject(GameObject sourceObject, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, int instancedObjectNodeID, string instancedObjectPath, Vector3 rotationOffset, Vector3 scaleOffset, string[] instancePrefixes, string[] instanceMaterialPaths, GameObject collisionSrcGO, bool copyParentFlags = true /* Metadata: 0x01FBD5A0 */) {} // 0x0000000188800480-0x0000000188800874
		internal void GenerateAttributesStore(HEU_SessionBase session) {} // 0x0000000188800CBC-0x0000000188800D58
		internal void CalculateColliderState() {} // 0x00000001887FDABC-0x00000001887FDD58
		private static void CopyGameObjectComponents(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, List<HoudiniEngineUnity.TransformData> lodTransformValues) {} // 0x00000001887FE6AC-0x0000000188800480
		private static void CopyChildGameObjects(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bKeepPreviousTransformValues) {} // 0x00000001887FE2FC-0x00000001887FE6AC
		internal GameObject BakePartToNewGameObject(Transform parentTransform, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances) => default; // 0x00000001887FD97C-0x00000001887FDABC
		internal static void BakePartToGameObject(HEU_PartData partData, GameObject srcGO, GameObject targetGO, string assetName, bool bIsInstancer, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues) {} // 0x00000001887FD100-0x00000001887FD830
		internal void BakePartToGameObject(GameObject targetGO, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues) {} // 0x00000001887FD830-0x00000001887FD97C
		internal bool GenerateMesh(HEU_SessionBase session, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups) => default; // 0x00000001888027CC-0x0000000188802C00
		internal void ProcessCurvePart(HEU_SessionBase session, int partId) {} // 0x0000000188803BF8-0x0000000188803D60
		internal void SyncAttributesStore(HEU_SessionBase session, int geoID, ref HAPI_PartInfo partInfo) {} // 0x000000018880457C-0x00000001888046A4
		internal void SetupAttributeGeometry(HEU_SessionBase session) {} // 0x00000001888044B0-0x000000018880457C
		internal void DestroyAttributesStore() {} // 0x0000000188800AF8-0x0000000188800BDC
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos) {} // 0x0000000188803BA4-0x0000000188803BF8
		internal void SetObjectInstanceInfos(List<HEU_ObjectInstanceInfo> sourceObjectInstanceInfos) {} // 0x0000000188804020-0x0000000188804144
		internal List<HEU_ObjectInstanceInfo> GetObjectInstanceInfos() => default; // 0x0000000183D4EAF0-0x0000000183D4EB00
		private HEU_ObjectInstanceInfo CreateObjectInstanceInfo(GameObject instancedObject, int instancedObjectNodeID, string instancedObjectPath) => default; // 0x0000000188800874-0x00000001888009C0
		internal static string AppendBakedCloneName(string name) => default; // 0x00000001887FCF8C-0x00000001887FCFC8
		public override string ToString() => default; // 0x00000001888046A4-0x0000000188804700
		internal static void DestroyParts(List<HEU_PartData> parts, bool bIsRebuild = false /* Metadata: 0x01FBD5A1 */) {} // 0x0000000188800C10-0x0000000188800CBC
		internal static void DestroyPart(HEU_PartData part, bool bIsRebuild = false /* Metadata: 0x01FBD5A2 */) {} // 0x0000000188800BDC-0x0000000188800C10
		internal static bool ComposeUnityInstanceSplitHierarchy(HEU_SessionBase session, int geoID, int partID, Transform parentTransform, int numInstances, ref Transform[] instanceToChildTransform) => default; // 0x00000001887FE244-0x00000001887FE2FC
		public bool IsEquivalentTo(HEU_PartData other) => default; // 0x0000000188803670-0x0000000188803B44
	}

	[Serializable]
	internal sealed class HEU_AttributeData : IEquivable<HEU_AttributeData> // TypeDefIndex: 49565
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
		public enum AttributeType // TypeDefIndex: 49563
		{
			UNDEFINED = -1,
			BOOL = 0,
			INT = 1,
			FLOAT = 2,
			STRING = 3,
			MAX = 4
		}
	
		public enum AttributeState // TypeDefIndex: 49564
		{
			INVALID = 0,
			SYNCED = 1,
			LOCAL_DIRTY = 2
		}
	
		// Constructors
		public HEU_AttributeData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsColorAttribute() => default; // 0x00000001887F1118-0x00000001887F1170
		internal void CopyValuesTo(HEU_AttributeData destAttrData) {} // 0x00000001887F0FE4-0x00000001887F1118
		public bool IsEquivalentTo(HEU_AttributeData other) => default; // 0x00000001887F1170-0x00000001887F147C
	}

	internal class HEU_AttributesStore : ScriptableObject, IEquivable<HEU_AttributesStore> // TypeDefIndex: 49567
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
		public int GeoID { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int PartID { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public string GeoName { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Transform OutputTransform { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public Mesh OutputMesh { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
	
		// Nested types
		public delegate void SetAttributeValueFunc(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // TypeDefIndex: 49566; 0x0000000181028930-0x0000000181028950
	
		// Constructors
		public HEU_AttributesStore() {} // 0x00000001887F44E0-0x00000001887F45B0
	
		// Methods
		public bool HasColorAttribute() => default; // 0x0000000183D4EF60-0x0000000183D4EF70
		public void DestroyAllData(HEU_HoudiniAsset asset) {} // 0x00000001887F1960-0x00000001887F1A74
		public void SyncAllAttributesFrom(HEU_SessionBase session, HEU_HoudiniAsset asset, int geoID, ref HAPI_PartInfo partInfo, GameObject outputGameObject) {} // 0x00000001887F3EA4-0x00000001887F4124
		public void SetupMeshAndMaterials(HEU_HoudiniAsset asset, HAPI_PartType partType, GameObject outputGameObject) {} // 0x00000001887F3850-0x00000001887F3C18
		public bool HasDirtyAttributes() => default; // 0x00000001887F2454-0x00000001887F2578
		public void SyncDirtyAttributesToHoudini(HEU_SessionBase session) {} // 0x00000001887F4124-0x00000001887F4188
		private void PopulateAttributeData(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData, ref HAPI_AttributeInfo attributeInfo) {} // 0x00000001887F2D44-0x00000001887F3408
		private void GetAttributesList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributesList, HAPI_AttributeOwner ownerType, int attributeCount) {} // 0x00000001887F235C-0x00000001887F23CC
		private void UpdateAttribute(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData) {} // 0x00000001887F42D8-0x00000001887F4434
		private void UpdateAttributeList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributeDataList) {} // 0x00000001887F4188-0x00000001887F42D8
		public void RefreshUpstreamInputs(HEU_SessionBase session) {} // 0x00000001887F3408-0x00000001887F3440
		public bool UploadAttributeViaMeshInput(HEU_SessionBase session, int geoID, int partID) => default; // 0x00000001887F4434-0x00000001887F44E0
		private static void SetAttributeDataSyncd(HEU_AttributeData attributeData) {} // 0x00000001887F3620-0x00000001887F363C
		public static void SetAttributeDataDirty(HEU_AttributeData attributeData) {} // 0x00000001887F3604-0x00000001887F3620
		public HEU_AttributeData CreateAttribute(string attributeName, ref HAPI_AttributeInfo attributeInfo) => default; // 0x00000001887F18A8-0x00000001887F1960
		public HEU_AttributeData GetAttributeData(string name) => default; // 0x00000001887F1DE8-0x00000001887F1F28
		public HEU_AttributeData GetAttributeData(int index) => default; // 0x00000001887F1F28-0x00000001887F1F98
		public List<string> GetAttributeNames() => default; // 0x00000001887F1F98-0x00000001887F212C
		public void EnablePaintCollider() {} // 0x00000001887F1B8C-0x00000001887F1D34
		public void DisablePaintCollider() {} // 0x00000001887F1A74-0x00000001887F1B8C
		public void ShowPaintMesh() {} // 0x00000001887F3C18-0x00000001887F3D20
		public void HidePaintMesh() {} // 0x00000001887F25C8-0x00000001887F26A0
		public bool HasMeshForPainting() => default; // 0x00000001887F2578-0x00000001887F25C8
		public MeshCollider GetPaintMeshCollider() => default; // 0x00000001887F23CC-0x00000001887F2434
		public void PaintAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools, int attributeIndex, float paintFactor, SetAttributeValueFunc setAttrFunc) {} // 0x00000001887F2CE0-0x00000001887F2D44
		public static void SetAttributeEditValueInt(HEU_AttributeData attributeData, int startIndex, int[] values) {} // 0x00000001887F36B0-0x00000001887F3724
		public static void SetAttributeEditValueFloat(HEU_AttributeData attributeData, int startIndex, float[] values) {} // 0x00000001887F363C-0x00000001887F36B0
		public static void SetAttributeEditValueString(HEU_AttributeData attributeData, int startIndex, string[] values) {} // 0x00000001887F3724-0x00000001887F37AC
		public static void ReplaceAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F34F4-0x00000001887F3604
		public static void AddAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F152C-0x00000001887F15F8
		public static void SubtractAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F3DD8-0x00000001887F3EA4
		public static void MultiplyAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F2BD0-0x00000001887F2CE0
		public static void ReplaceAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F3440-0x00000001887F34F4
		public static void AddAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F147C-0x00000001887F152C
		public static void SubtractAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F3D20-0x00000001887F3DD8
		public static void MultiplyAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F2B10-0x00000001887F2BD0
		public static void SetAttributeValueString(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x00000001887F37AC-0x00000001887F3850
		public void FillAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools) {} // 0x00000001887F1D34-0x00000001887F1DE8
		public bool AreAttributesDirty() => default; // 0x00000001887F15F8-0x00000001887F1710
		public void GetPositionAttributeValues(out Vector3[] positionArray) {
			positionArray = default;
		} // 0x00000001887F2434-0x00000001887F2444
		public void GetVertexIndices(out int[] indices) {
			indices = default;
		} // 0x00000001887F2444-0x00000001887F2454
		public static SetAttributeValueFunc GetAttributeSetValueFunction(HEU_AttributeData.AttributeType attrType, HEU_ToolsInfo.PaintMergeMode paintMergeMode) => default; // 0x00000001887F212C-0x00000001887F235C
		public void CopyAttributeValuesTo(HEU_AttributesStore destAttrStore) {} // 0x00000001887F1710-0x00000001887F18A8
		public bool IsValidStore(HEU_SessionBase session) => default; // 0x00000001887F2AF8-0x00000001887F2B10
		public bool IsEquivalentTo(HEU_AttributesStore other) => default; // 0x00000001887F26A0-0x00000001887F2AF8
	}

	[Serializable]
	public class HEU_OutputAttribute // TypeDefIndex: 49568
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
		public HEU_OutputAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class HEU_OutputAttributeDictionary : HEU_SerializableDictionary<string, HEU_OutputAttribute> // TypeDefIndex: 49569
	{
		// Constructors
		public HEU_OutputAttributeDictionary() {} // 0x000000018880AF6C-0x000000018880AF94
	}

	public class HEU_OutputAttributesStore : MonoBehaviour // TypeDefIndex: 49570
	{
		// Fields
		[SerializeField]
		private HEU_OutputAttributeDictionary _attributes; // 0x18
	
		// Constructors
		public HEU_OutputAttributesStore() {} // 0x000000018880B114-0x000000018880B184
	
		// Methods
		public void SetAttribute(HEU_OutputAttribute attribute) {} // 0x000000018880B044-0x000000018880B114
		public HEU_OutputAttribute GetAttribute(string name) => default; // 0x000000018880AFDC-0x000000018880B044
		public void Clear() {} // 0x000000018880AF94-0x000000018880AFDC
	}

	public static class HEU_AssetDatabase // TypeDefIndex: 49572
	{
		// Nested types
		public enum HEU_ImportAssetOptions // TypeDefIndex: 49571
		{
			Default = 0,
			ForceUpdate = 1,
			ForceSynchronousImport = 8,
			ImportRecursive = 256,
			DontDownloadFromCacheServer = 8192,
			ForceUncompressedImport = 16384
		}
	
		// Methods
		public static string GetAssetCachePath() => default; // 0x0000000188805DD4-0x0000000188805E1C
		public static string GetUnityProjectPath() => default; // 0x00000001888065B0-0x000000018880660C
		public static string GetAssetRelativePath(string inFullPath) => default; // 0x0000000188805F68-0x00000001888060A8
		public static string GetPackagesRelativePath(string inFullPath) => default; // 0x0000000188806238-0x0000000188806358
		public static string GetValidAssetPath(string inPath) => default; // 0x000000018880660C-0x0000000188806934
		public static string GetAssetPath(UnityEngine.Object asset) => default; // 0x0000000188805ED8-0x0000000188805F10
		public static string GetAssetPathWithSubAssetSupport(UnityEngine.Object asset) => default; // 0x0000000188805EA0-0x0000000188805ED8
		public static void GetSubAssetPathFromPath(string fullPath, out string mainPath, out string subPath) {
			mainPath = default;
			subPath = default;
		} // 0x0000000188806358-0x00000001888064C8
		private static string GetAssetRelativePathStart() => default; // 0x0000000188805F10-0x0000000188805F68
		private static string GetPackagesRelativePathStart() => default; // 0x00000001888061E0-0x0000000188806238
		public static string GetAssetFullPath(string inPath) => default; // 0x0000000188805E1C-0x0000000188805E68
		public static bool IsPathRelativeToAssets(string inPath) => default; // 0x0000000188806B8C-0x0000000188806C10
		public static bool IsPathRelativeToPackages(string inPath) => default; // 0x0000000188806C10-0x0000000188806C94
		public static string GetAssetRootPath(UnityEngine.Object asset) => default; // 0x00000001888060A8-0x00000001888060E0
		public static string GetUniqueAssetPath(string path) => default; // 0x0000000188806578-0x00000001888065B0
		public static string GetAssetOrScenePath(UnityEngine.Object inputObject) => default; // 0x0000000188805E68-0x0000000188805EA0
		public static bool IsPathInAssetCache(string path) => default; // 0x0000000188806A80-0x0000000188806B8C
		public static bool IsPathInAssetCacheBakedFolder(string path) => default; // 0x0000000188806A10-0x0000000188806A48
		public static bool IsPathInAssetCacheWorkingFolder(string path) => default; // 0x0000000188806A48-0x0000000188806A80
		public static bool IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset) => default; // 0x0000000188806968-0x00000001888069A0
		public static bool IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset) => default; // 0x00000001888069A0-0x00000001888069D8
		public static string CreateAssetCacheFolder(string suggestedAssetPath, int hash = 0 /* Metadata: 0x01FBD5B1 */) => default; // 0x0000000188805B88-0x0000000188805BC0
		public static void DeleteAssetCacheFolder(string assetCacheFolderPath) {} // 0x0000000188805CC8-0x0000000188805CFC
		public static void DeleteAsset(UnityEngine.Object asset) {} // 0x0000000188805D30-0x0000000188805D64
		public static void DeleteAssetAtPath(string path) {} // 0x0000000188805C94-0x0000000188805CC8
		public static void DeleteAssetIfInBakedFolder(UnityEngine.Object asset) {} // 0x0000000188805CFC-0x0000000188805D30
		public static bool ContainsAsset(UnityEngine.Object assetObject) => default; // 0x00000001888059CC-0x0000000188805A04
		public static bool CopyAsset(string path, string newPath) => default; // 0x0000000188805AE4-0x0000000188805B1C
		public static UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, string copyAssetFolder, string relativePath, System.Type type, bool bOverwriteExisting) => default; // 0x0000000188805AAC-0x0000000188805AE4
		public static UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting) => default; // 0x0000000188805A74-0x0000000188805AAC
		public static UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting) => default; // 0x0000000188805A04-0x0000000188805A3C
		public static UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, string targetPath, System.Type type) => default; // 0x0000000188805A3C-0x0000000188805A74
		public static UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type) => default; // 0x0000000188805B1C-0x0000000188805B54
		public static void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, string assetCacheRoot, string relativeFolderPath, string assetFileName, System.Type type, bool bOverwriteExisting) {} // 0x0000000188805BF4-0x0000000188805C28
		public static void CreateAsset(UnityEngine.Object asset, string path) {} // 0x0000000188805BC0-0x0000000188805BF4
		public static void CreateAddObjectInAssetCacheFolder(string assetName, string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref string exportRootPath, ref UnityEngine.Object assetDBObject) {} // 0x0000000188805B54-0x0000000188805B88
		public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject) {} // 0x00000001888056D4-0x0000000188805708
		public static void SaveAndRefreshDatabase() {} // 0x000000018350B670-0x000000018350B680
		public static void SaveAssetDatabase() {} // 0x000000018350B670-0x000000018350B680
		public static void RefreshAssetDatabase() {} // 0x000000018350B670-0x000000018350B680
		public static UnityEngine.Object LoadAssetAtPath(string assetPath, System.Type type) => default; // 0x0000000188806D04-0x0000000188806D3C
		public static UnityEngine.Object LoadSubAssetAtPath(string mainPath, string subAssetPath) => default; // 0x0000000188806D3C-0x0000000188806DD4
		public static UnityEngine.Object[] LoadAllAssetsAtPath(string assetPath) => default; // 0x0000000188806CCC-0x0000000188806D04
		public static UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(string assetPath) => default; // 0x0000000188806C94-0x0000000188806CCC
		public static void ImportAsset(string assetPath, HEU_ImportAssetOptions heuOptions) {} // 0x0000000188806934-0x0000000188806968
		public static string GetAssetWorkingPath() => default; // 0x00000001888061A8-0x00000001888061E0
		public static string GetAssetBakedPath() => default; // 0x0000000188805D9C-0x0000000188805DD4
		public static string GetAssetBakedPathWithAssetName(string assetName) => default; // 0x0000000188805D64-0x0000000188805D9C
		public static string CreateUniqueBakePath(string assetName) => default; // 0x0000000188805C5C-0x0000000188805C94
		public static void CreatePathWithFolders(string inPath) {} // 0x0000000188805C28-0x0000000188805C5C
		public static string AppendMeshesPathToAssetFolder(string inAssetCacheFolder) => default; // 0x00000001888057C0-0x000000018880583C
		public static string AppendTexturesPathToAssetFolder(string inAssetCacheFolder) => default; // 0x0000000188805950-0x00000001888059CC
		public static string AppendMaterialsPathToAssetFolder(string inAssetCacheFolder) => default; // 0x0000000188805708-0x0000000188805784
		public static string AppendTerrainPathToAssetFolder(string inAssetCacheFolder) => default; // 0x00000001888058D4-0x0000000188805950
		public static string[] GetAssetSubFolders() => default; // 0x00000001888060E0-0x00000001888061A8
		public static string AppendPrefabPath(string inAssetCacheFolder, string assetName) => default; // 0x000000018880583C-0x00000001888058D4
		public static string AppendMeshesAssetFileName(string assetName) => default; // 0x0000000188805784-0x00000001888057C0
		public static bool IsSubAsset(UnityEngine.Object obj) => default; // 0x000000018115F4C0-0x000000018115F530
		public static string[] GetAssetPathsFromAssetBundle(string assetBundleFileName) => default; // 0x0000000181002730-0x0000000181002740
		public static bool IsAssetSavedInScene(GameObject go) => default; // 0x00000001888069D8-0x0000000188806A10
		public static void SelectAssetAtPath(string path) {} // 0x000000018350B670-0x000000018350B680
		public static void PrintDependencies(GameObject targetGO) {} // 0x000000018350B670-0x000000018350B680
		public static string GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj) => default; // 0x00000001888064C8-0x0000000188806578
		public static bool IsValidFolderName(string name) => default; // 0x000000018232EB60-0x000000018232EB70
		public static T LoadUnityAssetFromUniqueAssetPath<T>(string assetPath)
			where T : UnityEngine.Object => default;
		public static T GetBuiltinExtraResource<T>(string resourceName)
			where T : UnityEngine.Object => default;
	}

	public class HEU_Defines // TypeDefIndex: 49573
	{
		// Fields
		public const string HEU_PRODUCT_NAME = "HoudiniEngine"; // Metadata: 0x01FBD5BF
		public const string HEU_NAME = "Houdini Engine"; // Metadata: 0x01FBD5CD
		public static string HEU_PLUGIN_PATH; // 0x00
		public static string HEU_TEXTURES_PATH; // 0x08
		public static string HEU_BAKED_ASSETS_PATH; // 0x10
		public static string HEU_ENGINE_ASSETS; // 0x18
		public const string HAPI_PATH = "HAPI_PATH"; // Metadata: 0x01FBD5DC
		public const string HEU_ENVPATH_PREFIX = "HEU_ENVPATH_"; // Metadata: 0x01FBD5E6
		public const string HEU_ENVPATH_KEY = "$"; // Metadata: 0x01FBD5F3
		public const int HEU_INVALID_NODE_ID = -1; // Metadata: 0x01FBD5F5
		public const string HEU_DEFAULT_ASSET_NAME = "HoudiniAssetRoot"; // Metadata: 0x01FBD5F6
		public const string HEU_SESSION_PIPENAME = "hapi"; // Metadata: 0x01FBD607
		public const string HEU_SESSION_LOCALHOST = "localhost"; // Metadata: 0x01FBD60C
		public const int HEU_SESSION_PORT = 9090; // Metadata: 0x01FBD616
		public const float HEU_SESSION_TIMEOUT = 100000f; // Metadata: 0x01FBD61A
		public const bool HEU_SESSION_AUTOCLOSE = true; // Metadata: 0x01FBD61E
		public const int HAPI_MAX_PAGE_SIZE = 500000; // Metadata: 0x01FBD61F
		public const int HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW = 3; // Metadata: 0x01FBD623
		public const int HAPI_MAX_VERTICES_PER_FACE = 3; // Metadata: 0x01FBD624
		public const bool HAPI_CURVE_REFINE_TO_LINEAR = true; // Metadata: 0x01FBD625
		public const float HAPI_CURVE_LOD = 8f; // Metadata: 0x01FBD626
		public const float HAPI_VOLUME_POSITION_MULT = 2f; // Metadata: 0x01FBD62A
		public const float HAPI_VOLUME_SURFACE_MAX_PT_PER_C = 64000f; // Metadata: 0x01FBD62E
		public const float HAPI_VOLUME_SURFACE_DELTA_MULT = 1.2f; // Metadata: 0x01FBD632
		public const float HAPI_VOLUME_SURFACE_PT_SIZE_MULT = 1800f; // Metadata: 0x01FBD636
		public const string DEFAULT_TOP_NODE_FILTER = "HE_"; // Metadata: 0x01FBD63A
		public const string DEFAULT_TOP_OUTPUT_FILTER = "HE_OUT_"; // Metadata: 0x01FBD63E
		public const string HAPI_ATTRIB_ORIENT = "orient"; // Metadata: 0x01FBD646
		public const string HAPI_ATTRIB_ROTATION = "rot"; // Metadata: 0x01FBD64D
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x01FBD651
		public const string HAPI_ATTRIB_ALPHA = "Alpha"; // Metadata: 0x01FBD657
		public const string HAPI_HANDLE_TRANSFORM = "xform"; // Metadata: 0x01FBD65D
		public const int HAPI_MAX_UVS = 8; // Metadata: 0x01FBD663
		public const string HAPI_OBJMERGE_TRANSFORM_PARAM = "xformtype"; // Metadata: 0x01FBD664
		public const string HAPI_OBJMERGE_PACK_GEOMETRY = "pack"; // Metadata: 0x01FBD66E
		public const string HAPI_OBJPATH_1_PARAM = "objpath1"; // Metadata: 0x01FBD673
		public const string NO_EXISTING_SESSION = "No existing session."; // Metadata: 0x01FBD67C
		public const string HEU_ERROR_TITLE = "Houdini Engine Error"; // Metadata: 0x01FBD691
		public const string HEU_INSTALL_INFO = "Houdini Engine Installation Info"; // Metadata: 0x01FBD6A6
		public const string PLUGIN_STORE_KEYS = "HoudiniEnginePluginKeys"; // Metadata: 0x01FBD6C7
		public const string PLUGIN_STORE_DATA = "HoudiniEnginePluginData"; // Metadata: 0x01FBD6DF
		public const string PLUGIN_SESSION_DATA = "HoudiniEngineSession"; // Metadata: 0x01FBD6F7
		public const string PLUGIN_SETTINGS_FILE = "heu_settings.ini"; // Metadata: 0x01FBD70C
		public const string PLUGIN_SESSION_FILE = "heu_session.txt"; // Metadata: 0x01FBD71D
		public const string COOK_LOGS_FILE = "cook_logs_file.txt"; // Metadata: 0x01FBD72D
		public const string DEFAULT_COLLISION_GEO = "collision_geo"; // Metadata: 0x01FBD740
		public const string DEFAULT_RENDERED_COLLISION_GEO = "rendered_collision_geo"; // Metadata: 0x01FBD74E
		public const string DEFAULT_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo"; // Metadata: 0x01FBD765
		public const string DEFAULT_CONVEX_COLLISION_GEO = "convex"; // Metadata: 0x01FBD783
		public const string DEFAULT_SIMPLE_COLLISION_GEO = "collision_geo_simple"; // Metadata: 0x01FBD78A
		public const string DEFAULT_SIMPLE_RENDERED_COLLISION_GEO = "rendered_collision_geo_simple"; // Metadata: 0x01FBD79F
		public const string DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo_simple"; // Metadata: 0x01FBD7BD
		public const string DEFAULT_COLLISION_TRIGGER = "trigger"; // Metadata: 0x01FBD7E2
		public const string DEFAULT_UNITY_MATERIAL_ATTR = "unity_material"; // Metadata: 0x01FBD7EA
		public const string DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR = "unity_sub_material_name"; // Metadata: 0x01FBD7F9
		public const string DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR = "unity_sub_material_index"; // Metadata: 0x01FBD811
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR = "unity_hf_texture_diffuse"; // Metadata: 0x01FBD82A
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR = "unity_hf_texture_mask"; // Metadata: 0x01FBD843
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR = "unity_hf_texture_normal"; // Metadata: 0x01FBD859
		public const string DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR = "unity_hf_normal_scale"; // Metadata: 0x01FBD871
		public const string DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR = "unity_hf_metallic"; // Metadata: 0x01FBD887
		public const string DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR = "unity_hf_smoothness"; // Metadata: 0x01FBD899
		public const string DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR = "unity_hf_specular"; // Metadata: 0x01FBD8AD
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR = "unity_hf_tile_offset"; // Metadata: 0x01FBD8BF
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR = "unity_hf_tile_size"; // Metadata: 0x01FBD8D4
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR = "unity_hf_terraindata_file"; // Metadata: 0x01FBD8E7
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR = "unity_hf_terraindata_export_file"; // Metadata: 0x01FBD901
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR = "unity_hf_terrainlayer_file"; // Metadata: 0x01FBD922
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH = "unity_hf_terraindata_export_path"; // Metadata: 0x01FBD93D
		public const string DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE = "unity_hf_height_range"; // Metadata: 0x01FBD95E
		public const string DEFAULT_UNITY_HEIGHTFIELD_YPOS = "unity_hf_ypos"; // Metadata: 0x01FBD974
		public const string HEIGHTFIELD_TREEPROTOTYPE = "unity_hf_tree_prototype"; // Metadata: 0x01FBD982
		public const string HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX = "unity_hf_treeinstance_prototypeindex"; // Metadata: 0x01FBD99A
		public const string HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE = "unity_hf_treeinstance_heightscale"; // Metadata: 0x01FBD9BF
		public const string HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE = "unity_hf_treeinstance_widthscale"; // Metadata: 0x01FBD9E1
		public const string HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR = "unity_hf_treeinstance_lightmapcolor"; // Metadata: 0x01FBDA02
		public const string HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH = "unity_hf_detail_resolution_patch"; // Metadata: 0x01FBDA26
		public const string HEIGHTFIELD_UNITY_TILE = "unity_hf_tile"; // Metadata: 0x01FBDA47
		public const string HEIGHTFIELD_DETAIL_DISTANCE = "unity_hf_detail_distance"; // Metadata: 0x01FBDA55
		public const string HEIGHTFIELD_DETAIL_DENSITY = "unity_hf_detail_density"; // Metadata: 0x01FBDA6E
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB = "unity_hf_detail_prototype_prefab"; // Metadata: 0x01FBDA86
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE = "unity_hf_detail_prototype_texture"; // Metadata: 0x01FBDAA7
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR = "unity_hf_detail_prototype_bendfactor"; // Metadata: 0x01FBDAC9
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR = "unity_hf_detail_prototype_drycolor"; // Metadata: 0x01FBDAEE
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR = "unity_hf_detail_prototype_healthycolor"; // Metadata: 0x01FBDB11
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT = "unity_hf_detail_prototype_maxheight"; // Metadata: 0x01FBDB38
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH = "unity_hf_detail_prototype_maxwidth"; // Metadata: 0x01FBDB5C
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT = "unity_hf_detail_prototype_minheight"; // Metadata: 0x01FBDB7F
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH = "unity_hf_detail_prototype_minwidth"; // Metadata: 0x01FBDBA3
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD = "unity_hf_detail_prototype_noisespread"; // Metadata: 0x01FBDBC6
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE = "unity_hf_detail_prototype_rendermode"; // Metadata: 0x01FBDBEC
		public const string HEIGHTFIELD_LAYER_ATTR_TYPE = "unity_hf_layer_type"; // Metadata: 0x01FBDC11
		public const string HEIGHTFIELD_LAYER_TYPE_DETAIL = "detail"; // Metadata: 0x01FBDC25
		public const string HAPI_HEIGHTFIELD_TILE_ATTR = "tile"; // Metadata: 0x01FBDC2C
		public const string HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT = "height"; // Metadata: 0x01FBDC31
		public const string HAPI_HEIGHTFIELD_LAYERNAME_MASK = "mask"; // Metadata: 0x01FBDC38
		public const string MAT_OGL_DIFF_ATTR = "ogl_diff"; // Metadata: 0x01FBDC3D
		public const string MAT_DIFF_ATTR = "basecolor"; // Metadata: 0x01FBDC46
		public const string MAT_OGL_TEX1_ATTR = "ogl_tex1"; // Metadata: 0x01FBDC50
		public const string MAT_OGL_TEX1_ATTR_ENABLED = "ogl_use_tex1"; // Metadata: 0x01FBDC59
		public const string MAT_BASECOLOR_ATTR = "basecolor_texture"; // Metadata: 0x01FBDC66
		public const string MAT_BASECOLOR_ATTR_ENABLED = "basecolor_useTexture"; // Metadata: 0x01FBDC78
		public const string MAT_MAP_ATTR = "map"; // Metadata: 0x01FBDC8D
		public const string MAT_OGL_NORMAL_ATTR = "ogl_normalmap"; // Metadata: 0x01FBDC91
		public const string MAT_NORMAL_ATTR = "baseNormal_texture"; // Metadata: 0x01FBDC9F
		public const string MAT_NORMAL_ATTR_ENABLED = "baseBumpAndNormal_enable"; // Metadata: 0x01FBDCB2
		public const string MAT_OGL_SPEC_ATTR = "ogl_spec"; // Metadata: 0x01FBDCCB
		public const string MAT_SPEC_ATTR = "reflect"; // Metadata: 0x01FBDCD4
		public const string MAT_OGL_SPEC_MAP_ATTR = "ogl_specmap"; // Metadata: 0x01FBDCDC
		public const string MAT_OGL_SPEC_MAP_ATTR_ENABLED = "ogl_use_specmap"; // Metadata: 0x01FBDCE8
		public const string MAT_SPEC_MAP_ATTR = "reflect_texture"; // Metadata: 0x01FBDCF8
		public const string MAT_SPEC_MAP_ATTR_ENABLED = "reflect_useTexture"; // Metadata: 0x01FBDD08
		public const string MAT_OGL_ROUGH_ATTR = "ogl_rough"; // Metadata: 0x01FBDD1B
		public const string MAT_ROUGH_ATTR = "rough"; // Metadata: 0x01FBDD25
		public const string MAT_OGL_ROUGH_MAP_ATTR = "ogl_roughmap"; // Metadata: 0x01FBDD2B
		public const string MAT_OGL_ROUGH_MAP_ATTR_ENABLED = "ogl_use_roughmap"; // Metadata: 0x01FBDD38
		public const string MAT_ROUGH_MAP_ATTR = "rough_texture"; // Metadata: 0x01FBDD49
		public const string MAT_ROUGH_MAP_ATTR_ENABLED = "rough_useTexture"; // Metadata: 0x01FBDD57
		public const string MAT_OGL_METALLIC_ATTR = "ogl_metallic"; // Metadata: 0x01FBDD68
		public const string MAT_METALLIC_ATTR = "metallic"; // Metadata: 0x01FBDD75
		public const string MAT_OGL_METALLIC_MAP_ATTR = "ogl_metallicmap"; // Metadata: 0x01FBDD7E
		public const string MAT_OGL_METALLIC_MAP_ATTR_ENABLED = "ogl_use_metallicmap"; // Metadata: 0x01FBDD8E
		public const string MAT_METALLIC_MAP_ATTR = "metallic_texture"; // Metadata: 0x01FBDDA2
		public const string MAT_METALLIC_MAP_ATTR_ENABLED = "metallic_useTexture"; // Metadata: 0x01FBDDB3
		public const string MAT_OGL_EMISSIVE_ATTR = "ogl_emit"; // Metadata: 0x01FBDDC7
		public const string MAT_EMISSIVE_ATTR = "emitcolor"; // Metadata: 0x01FBDDD0
		public const string MAT_OGL_EMISSIVE_MAP_ATTR = "ogl_emissionmap"; // Metadata: 0x01FBDDDA
		public const string MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED = "ogl_use_emissionmap"; // Metadata: 0x01FBDDEA
		public const string MAT_EMISSIVE_MAP_ATTR = "emitcolor_texture"; // Metadata: 0x01FBDDFE
		public const string MAT_EMISSIVE_MAP_ATTR_ENABLED = "emitcolor_useTexture"; // Metadata: 0x01FBDE10
		public const string MAT_OGL_ALPHA_ATTR = "ogl_alpha"; // Metadata: 0x01FBDE25
		public const string MAT_ALPHA_ATTR = "opac"; // Metadata: 0x01FBDE2F
		public const string MAT_OGL_OPACITY_MAP_ATTR = "ogl_opacitymap"; // Metadata: 0x01FBDE34
		public const string MAT_OGL_OPACITY_MAP_ATTR_ENABLED = "ogl_use_opacitymap"; // Metadata: 0x01FBDE43
		public const string MAT_OPACITY_MAP_ATTR = "opaccolor_texture"; // Metadata: 0x01FBDE56
		public const string MAT_OPACITY_MAP_ATTR_ENABLED = "opaccolor_useTexture"; // Metadata: 0x01FBDE68
		public const string MAT_OGL_TRANSPARENCY_ATTR = "ogl_transparency"; // Metadata: 0x01FBDE7D
		public const string MAT_OGL_TRANSPARENCY_ATTR_ENABLED = "ogl_use_alpha_transparency"; // Metadata: 0x01FBDE8E
		public const string MAT_OGL_OCCLUSION_MAP_ATTR = "ogl_occlusionmap"; // Metadata: 0x01FBDEA9
		public const string MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED = "ogl_use_occlusionmap"; // Metadata: 0x01FBDEBA
		public const string CURVE_COORDS_PARAM = "coords"; // Metadata: 0x01FBDECF
		public const string CURVE_TYPE_PARAM = "type"; // Metadata: 0x01FBDED6
		public const string CURVE_METHOD_PARAM = "method"; // Metadata: 0x01FBDEDB
		public const string CURVE_CLOSE_PARAM = "close"; // Metadata: 0x01FBDEE2
		public const string CURVE_REVERSE_PARAM = "reverse"; // Metadata: 0x01FBDEE8
		public const string HENGINE_STORE_ATTR = "hengine_attr_store"; // Metadata: 0x01FBDEF0
		public const string DEFAULT_UNITY_TAG_ATTR = "unity_tag"; // Metadata: 0x01FBDF03
		public const string DEFAULT_UNITY_SCRIPT_ATTR = "unity_script"; // Metadata: 0x01FBDF0D
		public const string DEFAULT_UNITY_INSTANCE_ATTR = "unity_instance"; // Metadata: 0x01FBDF1A
		public const string UNITY_USE_INSTANCE_FLAGS_ATTR = "unity_use_instance_flags"; // Metadata: 0x01FBDF29
		public const string DEFAULT_UNITY_INPUT_MESH_ATTR = "unity_input_mesh_name"; // Metadata: 0x01FBDF42
		public const string DEFAULT_UNITY_STATIC_ATTR = "unity_static"; // Metadata: 0x01FBDF58
		public const string DEFAULT_UNITY_LAYER_ATTR = "unity_layer"; // Metadata: 0x01FBDF65
		public const string DEFAULT_UNITY_MESH_READABLE = "unity_mesh_readable"; // Metadata: 0x01FBDF71
		public const string DEFAULT_INSTANCE_PREFIX_ATTR = "instance_prefix"; // Metadata: 0x01FBDF85
		public const string UNITY_SHADER_COLOR = "_Color"; // Metadata: 0x01FBDF95
		public const string UNITY_SHADER_SPEC_COLOR = "_SpecColor"; // Metadata: 0x01FBDF9C
		public const string UNITY_SHADER_SPEC_MAP = "_SpecMap"; // Metadata: 0x01FBDFA7
		public const string UNITY_SHADER_METALLIC = "_Metallic"; // Metadata: 0x01FBDFB0
		public const string UNITY_SHADER_METALLIC_MAP = "_MetallicMap"; // Metadata: 0x01FBDFBA
		public const string UNITY_SHADER_BUMP_MAP = "_BumpMap"; // Metadata: 0x01FBDFC7
		public const string UNITY_SHADER_EMISSION_COLOR = "_EmissionColor"; // Metadata: 0x01FBDFD0
		public const string UNITY_SHADER_EMISSION_MAP = "_EmissionMap"; // Metadata: 0x01FBDFDF
		public const string UNITY_SHADER_SMOOTHNESS = "_Smoothness"; // Metadata: 0x01FBDFEC
		public const string UNITY_SHADER_SMOOTHNESS_MAP = "_SmoothnessMap"; // Metadata: 0x01FBDFF8
		public const string UNITY_SHADER_SHININESS = "_Shininess"; // Metadata: 0x01FBE007
		public const string UNITY_SHADER_OCCLUSION = "_Occlusion"; // Metadata: 0x01FBE012
		public const string UNITY_SHADER_OCCLUSION_MAP = "_OcclusionMap"; // Metadata: 0x01FBE01D
		public const string UNITY_SHADER_OPACITY = "_Opacity"; // Metadata: 0x01FBE02B
		public const string UNITY_SHADER_OPACITY_MAP = "_OpacityMap"; // Metadata: 0x01FBE034
		public const string UNITY_EDITORONLY_TAG = "EditorOnly"; // Metadata: 0x01FBE040
		public const string UNITY_HDADATA_NAME = "HDA_Data"; // Metadata: 0x01FBE04B
		public const string HOUDINI_SHADER_PREFIX = "Houdini/"; // Metadata: 0x01FBE054
		public const string DEFAULT_STANDARD_SHADER = "HoudiniStandard"; // Metadata: 0x01FBE05D
		public const string DEFAULT_VERTEXCOLOR_SHADER = "HoudiniStandard"; // Metadata: 0x01FBE06D
		public const string DEFAULT_TRANSPARENT_SHADER = "HoudiniStandardAlpha"; // Metadata: 0x01FBE07D
		public const string DEFAULT_STANDARD_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x01FBE092
		public const string DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x01FBE0A2
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x01FBE0BD
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x01FBE0CD
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR = "HoudiniSpecularAlpha"; // Metadata: 0x01FBE0E8
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY = "Legacy/AlphaSpecularVertexColor"; // Metadata: 0x01FBE0FD
		public const string DEFAULT_CURVE_SHADER = "LineShader"; // Metadata: 0x01FBE11D
		public const string DEFAULT_TERRAIN_SHADER = "Nature/Terrain/Standard"; // Metadata: 0x01FBE128
		public const string DEFAULT_STANDARD_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x01FBE140
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x01FBE151
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP = "HDRP/StandardLitAlpha"; // Metadata: 0x01FBE162
		public const string DEFAULT_STANDARD_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x01FBE178
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x01FBE189
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR = "HDRP/SpecularLitAlpha"; // Metadata: 0x01FBE19A
		public const string DEFAULT_CURVE_SHADER_HDRP = "HDRP/Color"; // Metadata: 0x01FBE1B0
		public const string DEFAULT_TERRAIN_SHADER_HDRP = "HDRP/TerrainLit"; // Metadata: 0x01FBE1BB
		public const string DEFAULT_STANDARD_SHADER_URP = "URP/StandardLit"; // Metadata: 0x01FBE1CB
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP = "URP/StandardLit"; // Metadata: 0x01FBE1DB
		public const string DEFAULT_TRANSPARENT_SHADER_URP = "URP/StandardLitAlpha"; // Metadata: 0x01FBE1EB
		public const string DEFAULT_STANDARD_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x01FBE200
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x01FBE210
		public const string DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR = "URP/SpecularLitAlpha"; // Metadata: 0x01FBE220
		public const string DEFAULT_CURVE_SHADER_URP = "URP/Color"; // Metadata: 0x01FBE235
		public const string DEFAULT_TERRAIN_SHADER_URP = "Universal Render Pipeline/Terrain/Lit"; // Metadata: 0x01FBE23F
		public const string DEFAULT_UNITY_BUILTIN_RESOURCES = "Resources/unity_builtin_extra"; // Metadata: 0x01FBE265
		public const string DEFAULT_TERRAIN_MATERIAL_PATH = "Resources/unity_builtin_extra::name::Default-Terrain-Standard"; // Metadata: 0x01FBE283
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_HDRP = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipelineResources/Material/DefaultHDTerrainMaterial.mat"; // Metadata: 0x01FBE2C1
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_URP = "Packages/com.unity.render-pipelines.universal/Runtime/Materials/TerrainLit.mat"; // Metadata: 0x01FBE33C
		public const string DEFAULT_MATERIAL = "HEU_DEFAULT_MATERIAL"; // Metadata: 0x01FBE38C
		public static int DEFAULT_MATERIAL_KEY; // 0x20
		public const string EDITABLE_MATERIAL = "HEU_EDITABLE_MATERIAL"; // Metadata: 0x01FBE3A1
		public static int EDITABLE_MATERIAL_KEY; // 0x24
		public const int HEU_INVALID_MATERIAL = -1; // Metadata: 0x01FBE3B7
		public const string HEU_ASSET_CACHE_PATH = "HoudiniEngineAssetCache"; // Metadata: 0x01FBE3B8
		public const string HEU_WORKING_PATH = "Working"; // Metadata: 0x01FBE3D0
		public const string HEU_BAKED_PATH = "Baked"; // Metadata: 0x01FBE3D8
		public const string HEU_BAKED_HDA = "_bakedHDA"; // Metadata: 0x01FBE3DE
		public const string HEU_BAKED_CLONE = "_bakedClone"; // Metadata: 0x01FBE3E8
		public const string HEU_INSTANCE = "_Instance"; // Metadata: 0x01FBE3F4
		public const string HEU_INSTANCE_PATTERN = "_Instance\\d*\\z"; // Metadata: 0x01FBE3FE
		public const string HEU_INSTANCE_SPLIT_ATTR = "unity_split_attr"; // Metadata: 0x01FBE40D
		public const string HEU_DEFAULT_GEO_GROUP_NAME = "main_geo"; // Metadata: 0x01FBE41E
		public const string HEU_DEFAULT_LOD_NAME = "lod"; // Metadata: 0x01FBE427
		public const string HEU_UNITY_LOD_TRANSITION_ATTR = "lod_screensizes"; // Metadata: 0x01FBE42B
		public const string HEU_SUBASSET = "SUBASSET::"; // Metadata: 0x01FBE43B
		public const string HEU_HENGINE_TOOLS_SHIPPED_FOLDER = "<HFS>/engine/tools"; // Metadata: 0x01FBE446
		public const string HEU_HENGINE_SHIPPED_SHELF = "Default"; // Metadata: 0x01FBE459
		public const string HEU_PATH_KEY_PROJECT = "<PROJECT_PATH>"; // Metadata: 0x01FBE461
		public const string HEU_PATH_KEY_PLUGIN = "<PLUGIN_PATH>"; // Metadata: 0x01FBE470
		public const string HEU_PATH_KEY_HFS = "<HFS>"; // Metadata: 0x01FBE47E
		public const string HEU_PATH_KEY_TOOL = "HOUDINI_TOOL_PATH"; // Metadata: 0x01FBE484
		public const string HEU_USERMSG_NONEDITOR_NOT_SUPPORTED = "Houdini Engine does not support non-Editor asset creation at this time!"; // Metadata: 0x01FBE496
		public const string HEU_TERRAIN_SPLAT_DEFAULT = "Textures/heu_terrain_default_splat"; // Metadata: 0x01FBE4DF
		public const string HEU_FOLDER_MESHES = "Meshes"; // Metadata: 0x01FBE502
		public const string HEU_FOLDER_MATERIALS = "Materials"; // Metadata: 0x01FBE509
		public const string HEU_FOLDER_TERRAIN = "Terrain"; // Metadata: 0x01FBE513
		public const string HEU_FOLDER_TILE = "Tile"; // Metadata: 0x01FBE51B
		public const string HEU_FOLDER_TEXTURES = "Textures"; // Metadata: 0x01FBE520
		public const string HEU_EXT_ASSET = ".asset"; // Metadata: 0x01FBE529
		public const string HEU_EXT_MAT = ".mat"; // Metadata: 0x01FBE530
		public const string HEU_EXT_TERRAINDATA = ".terraindata"; // Metadata: 0x01FBE535
		public const string HEU_EXT_TERRAINLAYER = ".terrainlayer"; // Metadata: 0x01FBE542
		public const string HEU_KEY_CTRL = "Ctrl"; // Metadata: 0x01FBE550
	
		// Constructors
		public HEU_Defines() {} // 0x000000018350B670-0x000000018350B680
		static HEU_Defines() {} // 0x0000000188806DD4-0x0000000188806FA0
	}

	public static class HEU_HAPIUtility // TypeDefIndex: 49574
	{
		// Methods
		public static string GetHoudiniEngineInstallationInfo() => default; // 0x0000000188808DF8-0x0000000188808E24
		public static string GetEnvironmentPath() => default; // 0x00000001888087AC-0x000000018880881C
		public static string GetRealPathFromHFSPath(string inPath) => default; // 0x0000000188809500-0x0000000188809624
		public static bool DoesMappedPathExist(string inPath) => default; // 0x0000000188807E88-0x0000000188807EF8
		public static bool IsHoudiniAssetFile(string filePath) => default; // 0x000000018880983C-0x0000000188809954
		public static string FindHoudiniAssetFileInPathWithExt(string filePath) => default; // 0x0000000188807EF8-0x0000000188808074
		public static void Log(string message) {} // 0x0000000188809E74-0x0000000188809E7C
		public static void LogWarning(string message) {} // 0x0000000188809E6C-0x0000000188809E74
		public static void LogError(string message) {} // 0x0000000188809E64-0x0000000188809E6C
		public static string LocateValidFilePath(UnityEngine.Object inObject) => default; // 0x0000000188809E08-0x0000000188809E64
		public static string LocateValidFilePath(string assetName, string inFilePath) => default; // 0x0000000183D51810-0x0000000183D51820
		public static GameObject InstantiateHDA(string filePath, Vector3 initialPosition, HEU_SessionBase session, bool bBuildAsync, bool bLoadFromMemory = false /* Metadata: 0x01FBE555 */, bool bAlwaysOverwriteOnLoad = false /* Metadata: 0x01FBE556 */, GameObject rootGO = null) => default; // 0x0000000188809624-0x000000018880983C
		public static bool LoadHDAFile(HEU_SessionBase session, string assetPath, out int assetLibraryID, out string[] assetNames) {
			assetLibraryID = default;
			assetNames = default;
			return default;
		} // 0x0000000188809D54-0x0000000188809E08
		public static bool CreateAndCookAssetNode(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID) {
			newAssetID = default;
			return default;
		} // 0x00000001888078E4-0x0000000188807950
		public static bool CreateAndCookCurveAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID) {
			newAssetID = default;
			return default;
		} // 0x0000000188807950-0x00000001888079A4
		public static bool CreateAndCookInputAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID) {
			newAssetID = default;
			return default;
		} // 0x00000001888079A4-0x0000000188807A0C
		public static bool CookNodeInHoudini(HEU_SessionBase session, int nodeID, bool bCookTemplatedGeos, string assetName) => default; // 0x00000001888076A8-0x00000001888076C0
		public static bool CookNodeInHoudiniWithOptions(HEU_SessionBase session, int nodeID, HAPI_CookOptions options, string assetName) => default; // 0x00000001888076A8-0x00000001888076C0
		public static HAPI_CookOptions GetDefaultCookOptions(HEU_SessionBase session) => default; // 0x0000000188808770-0x00000001888087AC
		public static bool ProcessHoudiniCookStatus(HEU_SessionBase session, string assetName) => default; // 0x0000000188809E7C-0x0000000188809EFC
		public static GameObject CreateNewAsset(HEU_AssetTypeWrapper assetType, string rootName = "HoudiniAsset" /* Metadata: 0x01FBE557 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x01FBE564 */, GameObject rootGO = null) => default; // 0x0000000188807A0C-0x0000000188807A60
		internal static GameObject CreateNewAsset(HEU_HoudiniAsset.HEU_AssetType assetType, string rootName = "HoudiniAsset" /* Metadata: 0x01FBE565 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x01FBE572 */, GameObject rootGO = null) => default; // 0x0000000188807A60-0x0000000188807B14
		public static GameObject CreateNewCurveAsset(string name = "HoudiniCurve" /* Metadata: 0x01FBE573 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x01FBE580 */, GameObject rootGO = null) => default; // 0x0000000188807B14-0x0000000188807B48
		public static GameObject CreateNewInputAsset(string name = "HoudiniInput" /* Metadata: 0x01FBE581 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x01FBE58E */, GameObject rootGO = null) => default; // 0x0000000188807B48-0x0000000188807B7C
		public static GameObject LoadGeoWithNewGeoSync(HEU_SessionBase session = null) => default; // 0x0000000181002730-0x0000000181002740
		public static void DestroyChildren(Transform inTransform) {} // 0x0000000188807B7C-0x0000000188807E78
		public static void DestroyGameObject(GameObject gameObect, bool bRegisterUndo = false /* Metadata: 0x01FBE58F */) {} // 0x0000000188807E78-0x0000000188807E88
		public static void DestroyChildrenWithComponent<T>(GameObject gameObject)
			where T : Component {}
		public static bool IsNodeValidInHoudini(HEU_SessionBase session, int nodeID) => default; // 0x0000000188809954-0x0000000188809970
		public static HEU_HoudiniAssetRoot GetAssetInScene(int assetID) => default; // 0x0000000188808690-0x0000000188808770
		public static void ApplyWorldTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform) {} // 0x0000000188807434-0x00000001888076A8
		public static void ApplyLocalTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform) {} // 0x00000001888071D0-0x0000000188807380
		public static void ApplyLocalTransfromFromHoudiniToUnityForInstance(ref HAPI_Transform hapiTransform, Transform unityTransform) {} // 0x0000000188806FA0-0x00000001888071D0
		public static void ApplyMatrixToLocalTransform(ref Matrix4x4 matrix, Transform transform) {} // 0x0000000188807380-0x0000000188807434
		public static Matrix4x4 GetMatrixFromHAPITransform(ref HAPI_Transform hapiTransform, bool bConvertToUnity = true /* Metadata: 0x01FBE590 */) => default; // 0x0000000188808ED4-0x00000001888090F8
		public static Quaternion GetQuaternion(ref Matrix4x4 m) => default; // 0x00000001888092FC-0x0000000188809500
		public static Vector3 GetPosition(ref Matrix4x4 m) => default; // 0x00000001888092B0-0x00000001888092FC
		public static void SetMatrixPosition(ref Matrix4x4 m, ref Vector3 position) {} // 0x0000000188809EFC-0x0000000188809F48
		public static Vector3 GetScale(ref Matrix4x4 m) => default; // 0x0000000183D6D540-0x0000000183D6D630
		public static HAPI_TransformEuler GetHAPITransformFromMatrix(ref Matrix4x4 mat) => default; // 0x000000018880881C-0x0000000188808A08
		public static HAPI_TransformEuler GetHAPITransform(ref Vector3 p, ref Vector3 r, ref Vector3 s) => default; // 0x0000000188808C64-0x0000000188808DF8
		public static HAPI_Transform GetHAPITransformQuatFromMatrix(ref Matrix4x4 mat) => default; // 0x0000000188808A08-0x0000000188808C64
		public static Matrix4x4 GetMatrix4x4(ref Vector3 p, ref Vector3 r, ref Vector3 s) => default; // 0x0000000188808E24-0x0000000188808ED4
		public static bool IsSameTransform(ref Matrix4x4 transformMatrix, ref Vector3 p, ref Vector3 r, ref Vector3 s) => default; // 0x00000001888099CC-0x0000000188809A84
		public static bool IsEqualTol(float a, float b, float t = 1E-05f /* Metadata: 0x01FBE591 */) => default; // 0x00000001856649E4-0x00000001856649F8
		public static bool IsTransformEqual(ref HAPI_Transform transA, ref HAPI_Transform transB) => default; // 0x0000000188809AB0-0x0000000188809C58
		public static bool IsViewportEqual(ref HAPI_Viewport viewA, ref HAPI_Viewport viewB) => default; // 0x0000000188809C58-0x0000000188809D54
		public static bool IsSessionSyncEqual(ref HAPI_SessionSyncInfo syncA, ref HAPI_SessionSyncInfo syncB) => default; // 0x0000000188809A84-0x0000000188809A9C
		public static bool DoesGeoPartHaveAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo) => default; // 0x00000001888076A8-0x00000001888076C0
		public static void SetAnimationCurveTangentModes(AnimationCurve animCurve, List<int> tangentValues) {} // 0x000000018350B670-0x000000018350B680
		public static bool IsSupportedPolygonType(HAPI_PartType partType) => default; // 0x0000000188809A9C-0x0000000188809AB0
		public static int GetParentNodeID(HEU_SessionBase session, int nodeID) => default; // 0x0000000188809290-0x00000001888092B0
		public static bool GetObjectInfos(HEU_SessionBase session, int assetID, ref HAPI_NodeInfo nodeInfo, out HAPI_ObjectInfo[] objectInfos, out HAPI_Transform[] objectTransforms) {
			objectInfos = default;
			objectTransforms = default;
			return default;
		} // 0x00000001888090F8-0x0000000188809258
		public static bool ContainsSopNodes(HEU_SessionBase session, int nodeId) => default; // 0x00000001888076A8-0x00000001888076C0
		public static bool IsObjNodeFullyVisible(HEU_SessionBase session, HashSet<int> allObjectIds, int inRootNodeId, int inChildNodeId) => default; // 0x0000000188809970-0x00000001888099CC
		public static bool GetOutputIndex(HEU_SessionBase session, int nodeId, ref int outputIndex) => default; // 0x0000000188809258-0x0000000188809290
		internal static void GatherAllAssetGeoInfos(HEU_SessionBase session, HAPI_AssetInfo assetInfo, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, ref List<HAPI_GeoInfo> outGeoInfos) {} // 0x0000000188808074-0x0000000188808190
		internal static void GatherAllObjectGeoInfos(HEU_SessionBase session, int assetId, bool bUseOutputNodes, ref List<HAPI_GeoInfo> outGeoInfos) {} // 0x00000001888085F4-0x0000000188808690
		private static void GatherAllAssetOutputs(HEU_SessionBase session, int nodeId, bool bUseOutputNodes, bool bOutputTemplatedGeos, ref List<HAPI_GeoInfo> outGeoInfos) {} // 0x0000000188808190-0x00000001888085F4
		public static string ToHapiVariableName(string name) => default; // 0x0000000188809F48-0x0000000188809FD4
		public static void ConvertPositionUnityToHoudini(ref Vector3 position) {} // 0x0000000183D6D4D0-0x0000000183D6D4E0
		public static void ConvertPositionUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ) {
			outputX = default;
			outputY = default;
			outputZ = default;
		} // 0x0000000183D6D4B0-0x0000000183D6D4D0
		public static Vector3 ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ) => default; // 0x0000000183D6D490-0x0000000183D6D4B0
		public static Vector3 ConvertPositionUnityToHoudini(Vector3 inputVec) => default; // 0x0000000183D6D460-0x0000000183D6D490
		public static void ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ, ref Vector3 outputVec) {} // 0x0000000183D6D4E0-0x0000000183D6D500
		public static void ConvertRotationUnityToHoudini(ref Quaternion rotation) {} // 0x0000000188807804-0x0000000188807874
		public static void ConvertRotationUnityToHoudini(Quaternion rotation, out float outputX, out float outputY, out float outputZ, out float outputW) {
			outputX = default;
			outputY = default;
			outputZ = default;
			outputW = default;
		} // 0x00000001888076C0-0x0000000188807774
		public static Quaternion ConvertRotationUnityToHoudini(float inputX, float inputY, float inputZ, float inputW) => default; // 0x0000000188807774-0x0000000188807804
		public static Quaternion ConvertRotationUnityToHoudini(Quaternion inputQuat) => default; // 0x0000000188807874-0x00000001888078E4
		public static void ConvertScaleUnityToHoudini(ref Vector3 position) {} // 0x000000018350B670-0x000000018350B680
		public static void ConvertScaleUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ) {
			outputX = default;
			outputY = default;
			outputZ = default;
		} // 0x0000000183D6D500-0x0000000183D6D520
		public static Vector3 ConvertScaleUnityToHoudini(float inputX, float inputY, float inputZ) => default; // 0x0000000183D6D520-0x0000000183D6D540
		public static Vector3 ConvertScaleUnityToHoudini(Vector3 inputVec) => default; // 0x0000000183D56520-0x0000000183D56540
	}

	public class HEU_HoudiniEngineError : Exception // TypeDefIndex: 49575
	{
		// Fields
		protected string _errorMsg; // 0x90
	
		// Constructors
		public HEU_HoudiniEngineError() {} // 0x000000018880AF04-0x000000018880AF6C
		public HEU_HoudiniEngineError(string errorMsg) {} // 0x000000018880AE7C-0x000000018880AF04
	
		// Methods
		public override string ToString() => default; // 0x0000000183D4EA90-0x0000000183D4EAA0
	}

	public class HEU_Platform // TypeDefIndex: 49576
	{
		// Fields
		private static string _lastErrorMsg; // 0x00
		private static string _libPath; // 0x08
		private static bool _pathSet; // 0x10
	
		// Properties
		public static string LibPath { get => default; } // 0x00000001888187A8-0x00000001888187F8 
		public static bool IsPathSet { get => default; } // 0x0000000188818758-0x00000001888187A8 
		public static char DirectorySeparator { get => default; } // 0x0000000183D56180-0x0000000183D56190 
		public static string DirectorySeparatorStr { get => default; } // 0x000000018881872C-0x0000000188818758 
	
		// Constructors
		static HEU_Platform() {} // 0x0000000188818724-0x000000018881872C
		public HEU_Platform() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static string GetHoudiniEnginePath() => default; // 0x0000000188818024-0x000000018881807C
		public static string GetHoudiniEngineDefaultPath() => default; // 0x0000000188817D9C-0x0000000188817F98
		public static string GetSavedHoudiniPath() => default; // 0x000000018881809C-0x00000001888181B8
		public static void SetHapiClientName() {} // 0x0000000188818524-0x000000018881856C
		public static void SetHoudiniEnginePath() {} // 0x000000018350B670-0x000000018350B680
		public static string GetAllFoldersInPath(string path) => default; // 0x00000001888179F8-0x0000000188817AA8
		private static void GetAllFoldersInPathHelper(string inPath, StringBuilder pathBuilder) {} // 0x00000001888178D8-0x00000001888179F8
		public static string[] GetFilesInFolder(string folderPath, string searchPattern, bool bRecursive) => default; // 0x0000000188817B50-0x0000000188817C68
		public static string GetFileName(string path) => default; // 0x0000000188817B04-0x0000000188817B50
		public static string GetFileNameWithoutExtension(string path) => default; // 0x0000000188817AB8-0x0000000188817B04
		public static string GetFolderPath(string path, bool bRemoveDirectorySeparatorAtEnd = false /* Metadata: 0x01FBE595 */) => default; // 0x0000000188817C68-0x0000000188817D50
		public static string BuildPath(string folder1, string folder2, params object[] args) => default; // 0x0000000188817760-0x0000000188817870
		public static string TrimLastDirectorySeparator(string inPath) => default; // 0x000000018881856C-0x00000001888185FC
		public static bool DoesPathExist(string inPath) => default; // 0x00000001888178A8-0x00000001888178D8
		public static bool DoesFileExist(string inPath) => default; // 0x00000001888178A0-0x00000001888178A8
		public static bool DoesDirectoryExist(string inPath) => default; // 0x0000000188817898-0x00000001888178A0
		public static bool CreateDirectory(string inPath) => default; // 0x0000000188817870-0x0000000188817898
		public static string GetParentDirectory(string inPath) => default; // 0x000000018881807C-0x000000018881809C
		public static string GetFullPath(string inPath) => default; // 0x0000000188817D50-0x0000000188817D9C
		public static bool IsPathRooted(string inPath) => default; // 0x00000001888181B8-0x0000000188818204
		public static void WriteBytes(string path, byte[] bytes) {} // 0x000000018881871C-0x0000000188818724
		public static bool WriteAllText(string path, string text) => default; // 0x00000001888185FC-0x000000018881871C
		public static string ReadAllText(string path) => default; // 0x00000001888183CC-0x0000000188818524
		public static string GetEnvironmentValue(string key) => default; // 0x0000000188817AA8-0x0000000188817AB8
		public static string GetHoudiniEngineEnvironmentFilePathFull() => default; // 0x0000000188817F98-0x0000000188818024
		public static bool LoadFileIntoMemory(string path, out byte[] buffer) {
			buffer = default;
			return default;
		} // 0x0000000188818204-0x00000001888183CC
	}

	public static class HEU_PlatformWin // TypeDefIndex: 49578
	{
		// Fields
		public static UIntPtr HKEY_LOCAL_MACHINE; // 0x00
		public static UIntPtr HKEY_CURRENT_USER; // 0x08
	
		// Nested types
		public enum RegSAM // TypeDefIndex: 49577
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
		static HEU_PlatformWin() {} // 0x000000018881770C-0x0000000188817760
	
		// Methods
		private static extern uint RegOpenKeyEx(UIntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out int phkResult); // 0x0000000188817548-0x000000018881760C
		public static extern int RegQueryValueEx(int hKey, string lpValueName, int lpReserved, ref uint lpType, StringBuilder lpData, ref uint lpcbData); // 0x000000018881760C-0x000000018881770C
		private static extern uint RegCloseKey(int hKey); // 0x00000001888174D0-0x0000000188817548
		public static string GetRegistryKeyValue(UIntPtr rootKey, string keyName, RegSAM is32or64Key, string inPropertyName) => default; // 0x0000000188817240-0x00000001888173F8
		public static string GetRegistryKeyvalue_x86(UIntPtr rootKey, string keyName, string inPropertyName) => default; // 0x0000000188817464-0x00000001888174D0
		public static string GetRegistryKeyvalue_x64(UIntPtr rootKey, string keyName, string inPropertyName) => default; // 0x00000001888173F8-0x0000000188817464
		public static string GetApplicationPath(string appName) => default; // 0x0000000188816EF0-0x0000000188817240
	}

	public static class HEU_PluginSettings // TypeDefIndex: 49579
	{
		// Fields
		public static Action<bool> s_onEnableRawHoudiniChanged; // 0x00
	
		// Properties
		public static string HoudiniEngineEnvFilePath { get; set; } // 0x00000001888194F0-0x0000000188819564 0x000000018881B024-0x000000018881B08C
		public static bool EnableRawHoudini { get; set; } // 0x000000018881926C-0x00000001888192CC 0x000000018881AE00-0x000000018881AED0
		public static bool CookingEnabled { get; set; } // 0x0000000188818AC0-0x0000000188818B20 0x000000018881AAE8-0x000000018881AB38
		public static bool CookingTriggersDownstreamCooks { get; set; } // 0x0000000188818B20-0x0000000188818B80 0x000000018881AB38-0x000000018881AB88
		public static bool CookDisabledGameObjects { get; set; } // 0x0000000188818940-0x00000001888189A0 0x000000018881A9A8-0x000000018881A9F8
		public static bool CookTemplatedGeos { get; set; } // 0x0000000188818A60-0x0000000188818AC0 0x000000018881AA98-0x000000018881AAE8
		public static bool PushUnityTransformToHoudini { get; set; } // 0x0000000188819B84-0x0000000188819BE4 0x000000018881B534-0x000000018881B584
		public static bool TransformChangeTriggersCooks { get; set; } // 0x000000018881A19C-0x000000018881A1FC 0x000000018881BA00-0x000000018881BA50
		public static bool ChildTransformChangeTriggersCooks { get; set; } // 0x000000018881886C-0x00000001888188CC 0x000000018881A904-0x000000018881A954
		public static string CollisionGroupName { get; set; } // 0x00000001888188CC-0x0000000188818940 0x000000018881A954-0x000000018881A9A8
		public static string RenderedCollisionGroupName { get; set; } // 0x0000000188819BE4-0x0000000188819C58 0x000000018881B584-0x000000018881B5D8
		public static string RenderedConvexCollisionGroupName { get; set; } // 0x0000000188819C58-0x0000000188819CCC 0x000000018881B5D8-0x000000018881B62C
		public static string UnityMaterialAttribName { get; set; } // 0x000000018881A358-0x000000018881A3CC 0x000000018881BB4C-0x000000018881BBA0
		public static string UnitySubMaterialAttribName { get; set; } // 0x000000018881A4B4-0x000000018881A528 0x000000018881BC48-0x000000018881BC9C
		public static string UnitySubMaterialIndexAttribName { get; set; } // 0x000000018881A528-0x000000018881A59C 0x000000018881BC9C-0x000000018881BCF0
		public static string UnityTagAttributeName { get; set; } // 0x000000018881A59C-0x000000018881A610 0x000000018881BCF0-0x000000018881BD44
		public static string UnityStaticAttributeName { get; set; } // 0x000000018881A440-0x000000018881A4B4 0x000000018881BBF4-0x000000018881BC48
		public static string UnityScriptAttributeName { get; set; } // 0x000000018881A3CC-0x000000018881A440 0x000000018881BBA0-0x000000018881BBF4
		public static string UnityLayerAttributeName { get; set; } // 0x000000018881A2E4-0x000000018881A358 0x000000018881BAF8-0x000000018881BB4C
		public static float ImageGamma { get; set; } // 0x00000001888195D8-0x0000000188819640 0x000000018881B0E0-0x000000018881B138
		public static float NormalGenerationThresholdAngle { get; set; } // 0x0000000188819B1C-0x0000000188819B84 0x000000018881B4DC-0x000000018881B534
		public static string LastLoadHDAPath { get; set; } // 0x0000000188819938-0x00000001888199AC 0x000000018881B378-0x000000018881B3CC
		public static string LastLoadHIPPath { get; set; } // 0x00000001888199AC-0x0000000188819A20 0x000000018881B3CC-0x000000018881B420
		public static string InstanceAttr { get; set; } // 0x00000001888197DC-0x0000000188819850 0x000000018881B27C-0x000000018881B2D0
		public static string UnityInstanceAttr { get; set; } // 0x000000018881A270-0x000000018881A2E4 0x000000018881BAA4-0x000000018881BAF8
		public static string UnityInputMeshAttr { get; set; } // 0x000000018881A1FC-0x000000018881A270 0x000000018881BA50-0x000000018881BAA4
		public static UnityEngine.Color LineColor { get; set; } // 0x0000000188819A20-0x0000000188819AB8 0x000000018881B420-0x000000018881B48C
		public static bool UseHybridCurveEditing { get; set; } // 0x000000018881A6D0-0x000000018881A730 0x000000018881BDE4-0x000000018881BE34
		public static string EditorOnly_Tag { get; set; } // 0x00000001888191F8-0x000000018881926C 0x000000018881AD7C-0x000000018881AE00
		public static string HDAData_Name { get; set; } // 0x00000001888192CC-0x0000000188819340 0x000000018881AED0-0x000000018881AF24
		public static SessionMode Session_Mode { get; set; } // 0x0000000188819E00-0x0000000188819E68 0x000000018881B720-0x000000018881B770
		public static string Session_PipeName { get; set; } // 0x0000000188819E68-0x0000000188819EDC 0x000000018881B770-0x000000018881B7C4
		public static string Session_Localhost { get; set; } // 0x0000000188819D8C-0x0000000188819E00 0x000000018881B6CC-0x000000018881B720
		public static int Session_Port { get; set; } // 0x0000000188819EDC-0x0000000188819F40 0x000000018881B7C4-0x000000018881B814
		public static float Session_Timeout { get; set; } // 0x0000000188819F40-0x0000000188819FA8 0x000000018881B814-0x000000018881B86C
		public static bool Session_AutoClose { get; set; } // 0x0000000188819D2C-0x0000000188819D8C 0x000000018881B67C-0x000000018881B6CC
		public static bool Curves_ShowInSceneView { get; set; } // 0x0000000188818B80-0x0000000188818BE0 0x000000018881AB88-0x000000018881ABD8
		public static string AssetCachePath { get; set; } // 0x00000001888187F8-0x000000018881886C 0x000000018881A8B0-0x000000018881A904
		public static bool UseFullPathNamesForOutput { get; set; } // 0x000000018881A610-0x000000018881A670 0x000000018881BD44-0x000000018881BD94
		public static List<string> HEngineToolsShelves { get; set; } // 0x00000001888193A0-0x0000000188819404 0x000000018881AF74-0x000000018881AFD0
		public static int HEngineShelfSelectedIndex { get; set; } // 0x0000000188819340-0x00000001888193A0 0x000000018881AF24-0x000000018881AF74
		public static string DefaultTerrainMaterial { get; set; } // 0x0000000188818E7C-0x0000000188818EF0 0x000000018881AC80-0x000000018881ACD4
		public static string TerrainSplatTextureDefault { get; set; } // 0x000000018881A128-0x000000018881A19C 0x000000018881B9AC-0x000000018881BA00
		public static string DefaultStandardShader { get; set; } // 0x0000000188818CF8-0x0000000188818E7C 0x000000018881AC2C-0x000000018881AC80
		public static string DefaultVertexColorShader { get; set; } // 0x0000000188819074-0x00000001888191F8 0x000000018881AD28-0x000000018881AD7C
		public static string DefaultTransparentShader { get; set; } // 0x0000000188818EF0-0x0000000188819074 0x000000018881ACD4-0x000000018881AD28
		public static string DefaultCurveShader { get; set; } // 0x0000000188818BE0-0x0000000188818CF8 0x000000018881ABD8-0x000000018881AC2C
		public static bool SupportHoudiniBoxType { get; set; } // 0x000000018881A068-0x000000018881A0C8 0x000000018881B90C-0x000000018881B95C
		public static bool SupportHoudiniSphereType { get; set; } // 0x000000018881A0C8-0x000000018881A128 0x000000018881B95C-0x000000018881B9AC
		public static bool SetCurrentThreadToInvariantCulture { get; set; } // 0x0000000188819FA8-0x000000018881A008 0x000000018881B86C-0x000000018881B8BC
		public static string HoudiniDebugLaunchPath { get; set; } // 0x0000000188819404-0x00000001888194F0 0x000000018881AFD0-0x000000018881B024
		public static string LastExportPath { get; set; } // 0x0000000188819850-0x00000001888198C4 0x000000018881B2D0-0x000000018881B324
		public static int InputSelectionFilterLocation { get; set; } // 0x0000000188819640-0x00000001888196A4 0x000000018881B138-0x000000018881B188
		public static int InputSelectionFilterState { get; set; } // 0x0000000188819778-0x00000001888197DC 0x000000018881B22C-0x000000018881B27C
		public static bool InputSelectionFilterRoots { get; set; } // 0x0000000188819718-0x0000000188819778 0x000000018881B1DC-0x000000018881B22C
		public static string InputSelectionFilterName { get; set; } // 0x00000001888196A4-0x0000000188819718 0x000000018881B188-0x000000018881B1DC
		public static bool CookOptionSplitGeosByGroup { get; set; } // 0x0000000188818A00-0x0000000188818A60 0x000000018881AA48-0x000000018881AA98
		public static int MaxVerticesPerPrimitive { get; set; } // 0x0000000188819AB8-0x0000000188819B1C 0x000000018881B48C-0x000000018881B4DC
		public static string HoudiniInstallPath { get; set; } // 0x0000000188819564-0x00000001888195D8 0x000000018881B08C-0x000000018881B0E0
		public static string LastHoudiniVersion { get; set; } // 0x00000001888198C4-0x0000000188819938 0x000000018881B324-0x000000018881B378
		public static bool SessionSyncAutoCook { get; set; } // 0x0000000188819CCC-0x0000000188819D2C 0x000000018881B62C-0x000000018881B67C
		public static bool WriteCookLogs { get; set; } // 0x000000018881A850-0x000000018881A8B0 0x000000018881BF24-0x000000018881BF74
		public static bool UseHDRColor { get; set; } // 0x000000018881A670-0x000000018881A6D0 0x000000018881BD94-0x000000018881BDE4
		public static bool UseSpecularShader { get; set; } // 0x000000018881A7F0-0x000000018881A850 0x000000018881BED4-0x000000018881BF24
		public static bool UseLegacyShaders { get; set; } // 0x000000018881A790-0x000000018881A7F0 0x000000018881BE84-0x000000018881BED4
		public static bool ShortenFolderPaths { get; set; } // 0x000000018881A008-0x000000018881A068 0x000000018881B8BC-0x000000018881B90C
		public static bool UseLegacyInputCurves { get; set; } // 0x000000018881A730-0x000000018881A790 0x000000018881BE34-0x000000018881BE84
		public static bool CookOnMouseUp { get; set; } // 0x00000001888189A0-0x0000000188818A00 0x000000018881A9F8-0x000000018881AA48
	}

	public class HEU_PluginStorage // TypeDefIndex: 49583
	{
		// Fields
		protected Dictionary<string, StoreData> _dataMap; // 0x10
		private Dictionary<string, string> _envPathMap; // 0x18
		protected bool _requiresSave; // 0x20
		private static HEU_PluginStorage _instance; // 0x00
		public const string PluginSettingsLine1 = "Houdini Engine for Unity Plugin Settings"; // Metadata: 0x01FBE5B6
		public const string PluginSettingsLine2 = "Version="; // Metadata: 0x01FBE5DF
		public const string PluginSettingsVersion = "1.0"; // Metadata: 0x01FBE5E8
	
		// Properties
		public bool RequiresSave { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		public static HEU_PluginStorage Instance { get => default; } // 0x000000018881E3BC-0x000000018881E410 
	
		// Nested types
		protected enum DataType // TypeDefIndex: 49580
		{
			BOOL = 0,
			INT = 1,
			LONG = 2,
			FLOAT = 3,
			STRING = 4
		}
	
		[Serializable]
		protected class StoreData // TypeDefIndex: 49581
		{
			// Fields
			public DataType _type; // 0x10
			public string _valueStr; // 0x18
	
			// Constructors
			public StoreData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		private class StoreDataArray<T> // TypeDefIndex: 49582
		{
			// Fields
			public T[] _array;
	
			// Constructors
			public StoreDataArray() {}
		}
	
		// Constructors
		public HEU_PluginStorage() {} // 0x000000018881E344-0x000000018881E3BC
	
		// Methods
		public Dictionary<string, string> GetEnvironmentPathMap() => default; // 0x0000000181041090-0x00000001810410A0
		public static void InstantiateAndLoad() {} // 0x000000018881CB2C-0x000000018881CC14
		public static void SetCurrentCulture(bool useInvariant) {} // 0x000000018350B670-0x000000018350B680
		private T[] GetJSONArray<T>(string jsonArray) => default;
		public void Set(string key, bool value) {} // 0x000000018881E1D0-0x000000018881E294
		public void Set(string key, int value) {} // 0x000000018881DF0C-0x000000018881DFD0
		public void Set(string key, long value) {} // 0x000000018881DE48-0x000000018881DF0C
		public void Set(string key, float value) {} // 0x000000018881E10C-0x000000018881E1D0
		public void Set(string key, string value) {} // 0x000000018881DDB0-0x000000018881DE48
		public void Set(string key, List<string> values, char delimiter = ';' /* Metadata: 0x01FBE5B2 */) {} // 0x000000018881DFD0-0x000000018881E10C
		public bool Get(string key, out bool value, bool defaultValue) {
			value = default;
			return default;
		} // 0x000000018881C894-0x000000018881C968
		public bool Get(string key, out int value, int defaultValue) {
			value = default;
			return default;
		} // 0x000000018881C5A0-0x000000018881C674
		public bool Get(string key, out long value, long defaultValue) {
			value = default;
			return default;
		} // 0x000000018881C7C0-0x000000018881C894
		public bool Get(string key, out float value, float defaultValue) {
			value = default;
			return default;
		} // 0x000000018881CA2C-0x000000018881CB2C
		public bool Get(string key, out string value, string defaultValue) {
			value = default;
			return default;
		} // 0x000000018881C968-0x000000018881CA2C
		public bool Get(string key, out List<string> values, char delimiter = ';' /* Metadata: 0x01FBE5B4 */) {
			values = default;
			return default;
		} // 0x000000018881C674-0x000000018881C7C0
		protected virtual void MarkDirtyForSave() {} // 0x000000018350B670-0x000000018350B680
		public static void SaveIfRequired() {} // 0x000000018881D85C-0x000000018881D8A8
		public static string SettingsFilePath() => default; // 0x000000018881E294-0x000000018881E344
		public virtual bool SavePluginData(string file = null) => default; // 0x000000018881D8A8-0x000000018881DD00
		public virtual bool LoadPluginData(string file = null) => default; // 0x000000018881D04C-0x000000018881D85C
		private bool ReadFromEditorPrefs() => default; // 0x000000018115F4C0-0x000000018115F530
		public static void ClearPluginData() {} // 0x000000018881BF74-0x000000018881C02C
		public static void LoadFromSavedFile() {} // 0x000000018881D004-0x000000018881D04C
		public static string SessionFilePath() => default; // 0x000000018881DD00-0x000000018881DDB0
		public static void SaveAllSessionData(List<HEU_SessionBase> allSessions, string path = null) {} // 0x000000018350B670-0x000000018350B680
		public static List<HEU_SessionData> LoadAllSessionData(string path = null) => default; // 0x000000018881CC14-0x000000018881CC74
		public static void DeleteAllSavedSessionData(string file = null) {} // 0x000000018350B670-0x000000018350B680
		public void LoadAssetEnvironmentPaths() {} // 0x000000018881CC74-0x000000018881D004
		public string ConvertRealPathToEnvKeyedPath(string inPath) => default; // 0x000000018881C2D0-0x000000018881C5A0
		public string ConvertEnvKeyedPathToReal(string inPath) => default; // 0x000000018881C02C-0x000000018881C2D0
	}

	[Serializable]
	internal class HEU_Handle : ScriptableObject, IEquivable<HEU_Handle> // TypeDefIndex: 49585
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
		public string HandleName { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public HEU_HandleType HandleType { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public HAPI_RSTOrder RSTOrder { get => default; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 
		public HAPI_XYZOrder XYZOrder { get => default; } // 0x0000000183D4F400-0x0000000183D4F410 
		public HAPI_TransformEuler ConvertedTransformEuler { get => default; } // 0x0000000183D6D630-0x0000000183D6D660 
		public Vector3 HandlePosition { get => default; } // 0x0000000183D52300-0x0000000183D52320 
		public Quaternion HandleRotation { get => default; } // 0x0000000183D5E6D0-0x0000000183D5E6E0 
		public Vector3 HandleScale { get => default; } // 0x0000000183D6D660-0x0000000183D6D680 
	
		// Nested types
		public enum HEU_HandleType // TypeDefIndex: 49584
		{
			XFORM = 0,
			UNSUPPORTED = 1
		}
	
		// Constructors
		public HEU_Handle() {} // 0x000000018880AE14-0x000000018880AE7C
	
		// Methods
		public bool HasTranslateHandle() => default; // 0x0000000185693D38-0x0000000185693D44
		public bool HasRotateHandle() => default; // 0x00000001885839D0-0x00000001885839DC
		public bool HasScaleHandle() => default; // 0x00000001860DAC58-0x00000001860DAC64
		public bool IsTranslateHandleDisabled() => default; // 0x000000018880ACDC-0x000000018880ACF0
		public bool IsRotateHandleDisabled() => default; // 0x000000018880ACA0-0x000000018880ACB4
		public bool IsScaleHandleDisabled() => default; // 0x000000018880ACB4-0x000000018880ACC8
		public HEU_HandleParamBinding GetTranslateBinding() => default; // 0x0000000183D4EAC0-0x0000000183D4EAD0
		public HEU_HandleParamBinding GetRotateBinding() => default; // 0x0000000181003830-0x0000000181003840
		public HEU_HandleParamBinding GetScaleBinding() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
		public bool SetupHandle(HEU_SessionBase session, int assetID, int handleIndex, string handleName, HEU_HandleType handleType, ref HAPI_HandleInfo handleInfo, HEU_Parameters parameters) => default; // 0x000000018880ACF0-0x000000018880AE14
		public void CleanUp() {} // 0x000000018880A1E8-0x000000018880A220
		public void GenerateTransform(HEU_SessionBase session, HEU_Parameters parameters) {} // 0x000000018880A220-0x000000018880A638
		public bool GetUpdatedPosition(HEU_HoudiniAsset asset, ref Vector3 inPosition) => default; // 0x000000018880A638-0x000000018880A6F4
		public bool GetUpdatedRotation(HEU_HoudiniAsset asset, ref Quaternion inRotation) => default; // 0x000000018880A6F4-0x000000018880A828
		public static bool IsSpecialRSTOrder(HAPI_RSTOrder rstOrder) => default; // 0x000000018880ACC8-0x000000018880ACDC
		public bool IsEquivalentTo(HEU_Handle other) => default; // 0x000000018880A828-0x000000018880ACA0
	}

	[Serializable]
	internal class HEU_HandleParamBinding : IEquivable<HEU_HandleParamBinding> // TypeDefIndex: 49587
	{
		// Fields
		public HEU_HandleParamType _paramType; // 0x10
		public int _parmID; // 0x14
		public string _paramName; // 0x18
		public bool _bDisabled; // 0x20
		public bool[] _boundChannels; // 0x28
	
		// Nested types
		public enum HEU_HandleParamType // TypeDefIndex: 49586
		{
			TRANSLATE = 0,
			ROTATE = 1,
			SCALE = 2
		}
	
		// Constructors
		public HEU_HandleParamBinding() {} // 0x000000018880A1A0-0x000000018880A1E8
	
		// Methods
		public bool IsEquivalentTo(HEU_HandleParamBinding other) => default; // 0x0000000188809FD4-0x000000018880A1A0
	}

	public static class HEU_HAPIConstants // TypeDefIndex: 49588
	{
		// Fields
		public const int HAPI_POSITION_VECTOR_SIZE = 3; // Metadata: 0x01FBE5F6
		public const int HAPI_SCALE_VECTOR_SIZE = 3; // Metadata: 0x01FBE5F7
		public const int HAPI_SHEAR_VECTOR_SIZE = 3; // Metadata: 0x01FBE5F8
		public const int HAPI_NORMAL_VECTOR_SIZE = 3; // Metadata: 0x01FBE5F9
		public const int HAPI_QUATERNION_VECTOR_SIZE = 4; // Metadata: 0x01FBE5FA
		public const int HAPI_EULER_VECTOR_SIZE = 3; // Metadata: 0x01FBE5FB
		public const int HAPI_UV_VECTOR_SIZE = 2; // Metadata: 0x01FBE5FC
		public const int HAPI_COLOR_VECTOR_SIZE = 4; // Metadata: 0x01FBE5FD
		public const int HAPI_CV_VECTOR_SIZE = 4; // Metadata: 0x01FBE5FE
		public const int HAPI_PRIM_MIN_VERTEX_COUNT = 1; // Metadata: 0x01FBE5FF
		public const int HAPI_PRIM_MAX_VERTEX_COUNT = 16; // Metadata: 0x01FBE600
		public const int HAPI_INVALID_PARM_ID = -1; // Metadata: 0x01FBE601
		public const string HAPI_ATTRIB_POSITION = "P"; // Metadata: 0x01FBE602
		public const string HAPI_ATTRIB_UV = "uv"; // Metadata: 0x01FBE604
		public const string HAPI_ATTRIB_UV2 = "uv2"; // Metadata: 0x01FBE607
		public const string HAPI_ATTRIB_NORMAL = "N"; // Metadata: 0x01FBE60B
		public const string HAPI_ATTRIB_TANGENT = "tangentu"; // Metadata: 0x01FBE60D
		public const string HAPI_ATTRIB_TANGENT2 = "tangentv"; // Metadata: 0x01FBE616
		public const string HAPI_ATTRIB_COLOR = "Cd"; // Metadata: 0x01FBE61F
		public const string HAPI_ATTRIB_NAME = "name"; // Metadata: 0x01FBE622
		public const string HAPI_ATTRIB_INSTANCE = "instance"; // Metadata: 0x01FBE627
		public const string HAPI_ATTRIB_ROT = "rot"; // Metadata: 0x01FBE630
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x01FBE634
		public const string HAPI_UNGROUPED_GROUP_NAME = "__ungrouped_group"; // Metadata: 0x01FBE63A
		public const string HAPI_RAW_FORMAT_NAME = "HAPI_RAW"; // Metadata: 0x01FBE64C
		public const string HAPI_PNG_FORMAT_NAME = "PNG"; // Metadata: 0x01FBE655
		public const string HAPI_JPEG_FORMAT_NAME = "JPEG"; // Metadata: 0x01FBE659
		public const string HAPI_BMP_FORMAT_NAME = "Bitmap"; // Metadata: 0x01FBE65E
		public const string HAPI_TIFF_FORMAT_NAME = "TIFF"; // Metadata: 0x01FBE665
		public const string HAPI_TGA_FORMAT_NAME = "Targa"; // Metadata: 0x01FBE66A
		public const string HAPI_DEFAULT_IMAGE_FORMAT_NAME = "PNG"; // Metadata: 0x01FBE670
		public const string HAPI_GLOBAL_NODES_NODE_NAME = "GlobalNodes"; // Metadata: 0x01FBE674
		public const string HAPI_ENV_HIP = "HIP"; // Metadata: 0x01FBE680
		public const string HAPI_ENV_JOB = "JOB"; // Metadata: 0x01FBE684
		public const string HAPI_ENV_CLIENT_NAME = "HAPI_CLIENT_NAME"; // Metadata: 0x01FBE688
		public const string HAPI_CACHE_COP_COOK = "COP Cook Cache"; // Metadata: 0x01FBE699
		public const string HAPI_CACHE_COP_FLIPBOOK = "COP Flipbook Cache"; // Metadata: 0x01FBE6A8
		public const string HAPI_CACHE_IMAGE = "Image Cache"; // Metadata: 0x01FBE6BB
		public const string HAPI_CACHE_OBJ = "Object Transform Cache"; // Metadata: 0x01FBE6C7
		public const string HAPI_CACHE_GL_TEXTURE = "OpenGL Texture Cache"; // Metadata: 0x01FBE6DE
		public const string HAPI_CACHE_GL_VERTEX = "OpenGL Vertex Cache"; // Metadata: 0x01FBE6F3
		public const string HAPI_CACHE_SOP = "SOP Cache"; // Metadata: 0x01FBE707
		public const string HAPI_CACHE_VEX = "VEX File Cache"; // Metadata: 0x01FBE711
		public const string HAPI_ATTRIB_INPUT_CURVE_COORDS = "hapi_input_curve_coords"; // Metadata: 0x01FBE720
	}

	public enum HAPI_License // TypeDefIndex: 49589
	{
		HAPI_LICENSE_NONE = 0,
		HAPI_LICENSE_HOUDINI_ENGINE = 1,
		HAPI_LICENSE_HOUDINI = 2,
		HAPI_LICENSE_HOUDINI_FX = 3,
		HAPI_LICENSE_HOUDINI_ENGINE_INDIE = 4,
		HAPI_LICENSE_HOUDINI_INDIE = 5,
		HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL = 6,
		HAPI_LICENSE_MAX = 7
	}

	public enum HAPI_StatusType // TypeDefIndex: 49590
	{
		HAPI_STATUS_CALL_RESULT = 0,
		HAPI_STATUS_COOK_RESULT = 1,
		HAPI_STATUS_COOK_STATE = 2,
		HAPI_STATUS_MAX = 3
	}

	public enum HAPI_StatusVerbosity // TypeDefIndex: 49591
	{
		HAPI_STATUSVERBOSITY_0 = 0,
		HAPI_STATUSVERBOSITY_ERRORS = 0,
		HAPI_STATUSVERBOSITY_1 = 1,
		HAPI_STATUSVERBOSITY_WARNINGS = 1,
		HAPI_STATUSVERBOSITY_2 = 2,
		HAPI_STATUSVERBOSITY_ALL = 2,
		HAPI_STATUSVERBOSITY_MESSAGES = 2
	}

	public enum HAPI_Result // TypeDefIndex: 49592
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
		HAPI_RESULT_ASSET_INVALID = 200,
		HAPI_RESULT_NODE_INVALID = 210,
		HAPI_RESULT_USER_INTERRUPTED = 300,
		HAPI_RESULT_INVALID_SESSION = 400
	}

	[Flags]
	public enum HAPI_ErrorCode // TypeDefIndex: 49593
	{
		HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND = 1,
		HAPI_ERRORCODE_PYTHON_NODE_ERROR = 2
	}

	public enum HAPI_SessionType // TypeDefIndex: 49594
	{
		HAPI_SESSION_INPROCESS = 0,
		HAPI_SESSION_THRIFT = 1,
		HAPI_SESSION_CUSTOM1 = 2,
		HAPI_SESSION_CUSTOM2 = 3,
		HAPI_SESSION_CUSTOM3 = 4,
		HAPI_SESSION_MAX = 5
	}

	public enum HAPI_State // TypeDefIndex: 49595
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

	public enum HAPI_PackedPrimInstancingMode // TypeDefIndex: 49596
	{
		HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID = -1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED = 0,
		HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY = 1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT = 2,
		HAPI_PACKEDPRIM_INSTANCING_MODE_MAX = 3
	}

	public enum HAPI_Permissions // TypeDefIndex: 49597
	{
		HAPI_PERMISSIONS_NON_APPLICABLE = 0,
		HAPI_PERMISSIONS_READ_WRITE = 1,
		HAPI_PERMISSIONS_READ_ONLY = 2,
		HAPI_PERMISSIONS_WRITE_ONLY = 3,
		HAPI_PERMISSIONS_MAX = 4
	}

	public enum HAPI_RampType // TypeDefIndex: 49598
	{
		HAPI_RAMPTYPE_INVALID = -1,
		HAPI_RAMPTYPE_FLOAT = 0,
		HAPI_RAMPTYPE_COLOR = 1,
		HAPI_RAMPTYPE_MAX = 2
	}

	public enum HAPI_ParmType // TypeDefIndex: 49599
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

	public enum HAPI_PrmScriptType // TypeDefIndex: 49600
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
		HAPI_PRM_SCRIPT_TYPE_OPPATH = 21,
		HAPI_PRM_SCRIPT_TYPE_OPLIST = 22,
		HAPI_PRM_SCRIPT_TYPE_OBJECT = 23,
		HAPI_PRM_SCRIPT_TYPE_OBJECTLIST = 24,
		HAPI_PRM_SCRIPT_TYPE_RENDER = 25,
		HAPI_PRM_SCRIPT_TYPE_SEPARATOR = 26,
		HAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA = 27,
		HAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT = 28,
		HAPI_PRM_SCRIPT_TYPE_LABEL = 29,
		HAPI_PRM_SCRIPT_TYPE_RGBAMASK = 30,
		HAPI_PRM_SCRIPT_TYPE_ORDINAL = 31,
		HAPI_PRM_SCRIPT_TYPE_RAMP_FLT = 32,
		HAPI_PRM_SCRIPT_TYPE_RAMP_RGB = 33,
		HAPI_PRM_SCRIPT_TYPE_FLOAT_LOG = 34,
		HAPI_PRM_SCRIPT_TYPE_INT_LOG = 35,
		HAPI_PRM_SCRIPT_TYPE_DATA = 36,
		HAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX = 37,
		HAPI_PRM_SCRIPT_TYPE_INT_MINMAX = 38,
		HAPI_PRM_SCRIPT_TYPE_INT_STARTEND = 39,
		HAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP = 40,
		HAPI_PRM_SCRIPT_TYPE_ICONSTRIP = 41,
		HAPI_PRM_SCRIPT_TYPE_GROUPRADIO = 1000,
		HAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE = 1001,
		HAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE = 1002,
		HAPI_PRM_SCRIPT_TYPE_GROUP = 1003
	}

	public enum HAPI_ChoiceListType // TypeDefIndex: 49601
	{
		HAPI_CHOICELISTTYPE_NONE = 0,
		HAPI_CHOICELISTTYPE_NORMAL = 1,
		HAPI_CHOICELISTTYPE_MINI = 2,
		HAPI_CHOICELISTTYPE_REPLACE = 3,
		HAPI_CHOICELISTTYPE_TOGGLE = 4
	}

	public enum HAPI_PresetType // TypeDefIndex: 49602
	{
		HAPI_PRESETTYPE_INVALID = -1,
		HAPI_PRESETTYPE_BINARY = 0,
		HAPI_PRESETTYPE_IDX = 1,
		HAPI_PRESETTYPE_MAX = 2
	}

	[Flags]
	public enum HAPI_NodeType // TypeDefIndex: 49603
	{
		HAPI_NODETYPE_ANY = -1,
		HAPI_NODETYPE_NONE = 0,
		HAPI_NODETYPE_OBJ = 1,
		HAPI_NODETYPE_SOP = 2,
		HAPI_NODETYPE_CHOP = 4,
		HAPI_NODETYPE_ROP = 8,
		HAPI_NODETYPE_SHOP = 16,
		HAPI_NODETYPE_COP = 32,
		HAPI_NODETYPE_VOP = 64,
		HAPI_NODETYPE_DOP = 128,
		HAPI_NODETYPE_TOP = 256
	}

	[Flags]
	public enum HAPI_NodeFlags // TypeDefIndex: 49604
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

	public enum HAPI_GroupType // TypeDefIndex: 49605
	{
		HAPI_GROUPTYPE_INVALID = -1,
		HAPI_GROUPTYPE_POINT = 0,
		HAPI_GROUPTYPE_PRIM = 1,
		HAPI_GROUPTYPE_EDGE = 2,
		HAPI_GROUPTYPE_MAX = 3
	}

	public enum HAPI_AttributeOwner // TypeDefIndex: 49606
	{
		HAPI_ATTROWNER_INVALID = -1,
		HAPI_ATTROWNER_VERTEX = 0,
		HAPI_ATTROWNER_POINT = 1,
		HAPI_ATTROWNER_PRIM = 2,
		HAPI_ATTROWNER_DETAIL = 3,
		HAPI_ATTROWNER_MAX = 4
	}

	public enum HAPI_CurveType // TypeDefIndex: 49607
	{
		HAPI_CURVETYPE_INVALID = -1,
		HAPI_CURVETYPE_LINEAR = 0,
		HAPI_CURVETYPE_NURBS = 1,
		HAPI_CURVETYPE_BEZIER = 2,
		HAPI_CURVETYPE_MAX = 3
	}

	public enum HAPI_InputCurveMethod // TypeDefIndex: 49608
	{
		HAPI_CURVEMETHOD_INVALID = -1,
		HAPI_CURVEMETHOD_CVS = 0,
		HAPI_CURVEMETHOD_BREAKPOINTS = 1,
		HAPI_CURVEMETHOD_MAX = 2
	}

	public enum HAPI_InputCurveParameterization // TypeDefIndex: 49609
	{
		HAPI_CURVEPARAMETERIZATION_INVALID = -1,
		HAPI_CURVEPARAMETERIZATION_UNIFORM = 0,
		HAPI_CURVEPARAMETERIZATION_CHORD = 1,
		HAPI_CURVEPARAMETERIZATION_CENTRIPETAL = 2,
		HAPI_CURVEPARAMETERIZATION_MAX = 3
	}

	public enum HAPI_VolumeType // TypeDefIndex: 49610
	{
		HAPI_VOLUMETYPE_INVALID = -1,
		HAPI_VOLUMETYPE_HOUDINI = 0,
		HAPI_VOLUMETYPE_VDB = 1,
		HAPI_VOLUMETYPE_MAX = 2
	}

	public enum HAPI_VolumeVisualType // TypeDefIndex: 49611
	{
		HAPI_VOLUMEVISTYPE_INVALID = -1,
		HAPI_VOLUMEVISTYPE_SMOKE = 0,
		HAPI_VOLUMEVISTYPE_RAINBOW = 1,
		HAPI_VOLUMEVISTYPE_ISO = 2,
		HAPI_VOLUMEVISTYPE_INVISIBLE = 3,
		HAPI_VOLUMEVISTYPE_HEIGHTFIELD = 4,
		HAPI_VOLUMEVISTYPE_MAX = 5
	}

	public enum HAPI_StorageType // TypeDefIndex: 49612
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
		HAPI_STORAGETYPE_INT_ARRAY = 8,
		HAPI_STORAGETYPE_INT64_ARRAY = 9,
		HAPI_STORAGETYPE_FLOAT_ARRAY = 10,
		HAPI_STORAGETYPE_FLOAT64_ARRAY = 11,
		HAPI_STORAGETYPE_STRING_ARRAY = 12,
		HAPI_STORAGETYPE_UINT8_ARRAY = 13,
		HAPI_STORAGETYPE_INT8_ARRAY = 14,
		HAPI_STORAGETYPE_INT16_ARRAY = 15,
		HAPI_STORAGETYPE_MAX = 16
	}

	public enum HAPI_AttributeTypeInfo // TypeDefIndex: 49613
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

	public enum HAPI_GeoType // TypeDefIndex: 49614
	{
		HAPI_GEOTYPE_INVALID = -1,
		HAPI_GEOTYPE_DEFAULT = 0,
		HAPI_GEOTYPE_INTERMEDIATE = 1,
		HAPI_GEOTYPE_INPUT = 2,
		HAPI_GEOTYPE_CURVE = 3,
		HAPI_GEOTYPE_MAX = 4
	}

	public enum HAPI_PartType // TypeDefIndex: 49615
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

	public enum HAPI_InputType // TypeDefIndex: 49616
	{
		HAPI_INPUT_INVALID = -1,
		HAPI_INPUT_TRANSFORM = 0,
		HAPI_INPUT_GEOMETRY = 1,
		HAPI_INPUT_MAX = 2
	}

	public enum HAPI_CurveOrders // TypeDefIndex: 49617
	{
		HAPI_CURVE_ORDER_VARYING = 0,
		HAPI_CURVE_ORDER_INVALID = 1,
		HAPI_CURVE_ORDER_LINEAR = 2,
		HAPI_CURVE_ORDER_QUADRATIC = 3,
		HAPI_CURVE_ORDER_CUBIC = 4
	}

	public enum HAPI_TransformComponent // TypeDefIndex: 49618
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

	public enum HAPI_RSTOrder // TypeDefIndex: 49619
	{
		HAPI_TRS = 0,
		HAPI_TSR = 1,
		HAPI_RTS = 2,
		HAPI_RST = 3,
		HAPI_STR = 4,
		HAPI_SRT = 5,
		HAPI_RSTORDER_DEFAULT = 5
	}

	public enum HAPI_XYZOrder // TypeDefIndex: 49620
	{
		HAPI_XYZ = 0,
		HAPI_XYZORDER_DEFAULT = 0,
		HAPI_XZY = 1,
		HAPI_YXZ = 2,
		HAPI_YZX = 3,
		HAPI_ZXY = 4,
		HAPI_ZYX = 5
	}

	public enum HAPI_ImageDataFormat // TypeDefIndex: 49621
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

	public enum HAPI_ImagePacking // TypeDefIndex: 49622
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

	public enum HAPI_EnvIntType // TypeDefIndex: 49623
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

	public enum HAPI_SessionEnvIntType // TypeDefIndex: 49624
	{
		HAPI_SESSIONENVINT_INVALID = -1,
		HAPI_SESSIONENVINT_LICENSE = 100,
		HAPI_SESSIONENVINT_MAX = 101
	}

	public enum HAPI_CacheProperty // TypeDefIndex: 49625
	{
		HAPI_CACHEPROP_CURRENT = 0,
		HAPI_CACHEPROP_HAS_MIN = 1,
		HAPI_CACHEPROP_MIN = 2,
		HAPI_CACHEPROP_HAS_MAX = 3,
		HAPI_CACHEPROP_MAX = 4,
		HAPI_CACHEPROP_CULL_LEVEL = 5
	}

	public enum HAPI_HeightFieldSampling // TypeDefIndex: 49626
	{
		HAPI_HEIGHTFIELD_SAMPLING_CENTER = 0,
		HAPI_HEIGHTFIELD_SAMPLING_CORNER = 1
	}

	public enum HAPI_PDG_State // TypeDefIndex: 49627
	{
		HAPI_PDG_STATE_READY = 0,
		HAPI_PDG_STATE_MAX_READY_STATE = 0,
		HAPI_PDG_STATE_COOKING = 1,
		HAPI_PDG_STATE_MAX = 2
	}

	public enum HAPI_PDG_EventType // TypeDefIndex: 49628
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
		HAPI_PDG_EVENT_WORKITEM_SET_INT = 21,
		HAPI_PDG_EVENT_WORKITEM_SET_FLOAT = 22,
		HAPI_PDG_EVENT_WORKITEM_SET_STRING = 23,
		HAPI_PDG_EVENT_WORKITEM_SET_FILE = 24,
		HAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT = 25,
		HAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY = 26,
		HAPI_PDG_EVENT_WORKITEM_MERGE = 27,
		HAPI_PDG_EVENT_WORKITEM_RESULT = 28,
		HAPI_PDG_EVENT_WORKITEM_PRIORITY = 29,
		HAPI_PDG_EVENT_COOK_START = 30,
		HAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR = 31,
		HAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR = 32,
		HAPI_PDG_EVENT_NODE_PROGRESS_UPDATE = 33,
		HAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED = 34,
		HAPI_PDG_EVENT_ALL = 35,
		HAPI_PDG_EVENT_LOG = 36,
		HAPI_PDG_EVENT_SCHEDULER_ADDED = 37,
		HAPI_PDG_EVENT_SCHEDULER_REMOVED = 38,
		HAPI_PDG_EVENT_SET_SCHEDULER = 39,
		HAPI_PDG_EVENT_SERVICE_MANAGER_ALL = 40,
		HAPI_PDG_EVENT_NODE_COOKED = 41,
		HAPI_PDG_EVENT_NODE_GENERATED = 42,
		HAPI_PDG_CONTEXT_EVENTS = 43
	}

	public enum HAPI_PDG_WorkItemState // TypeDefIndex: 49629
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

	public static class HEU_HAPIFunctions // TypeDefIndex: 49630
	{
	}

	public struct HAPI_Transform // TypeDefIndex: 49631
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationQuaternion; // 0x08
		public float[] scale; // 0x10
		public float[] shear; // 0x18
		public HAPI_RSTOrder rstOrder; // 0x20
	
		// Constructors
		public HAPI_Transform(bool initializeFields) {
			position = default;
			rotationQuaternion = default;
			scale = default;
			shear = default;
			rstOrder = default;
		} // 0x0000000188805510-0x00000001888055D8
	
		// Methods
		public void Init() {} // 0x0000000188805450-0x0000000188805510
	}

	[Serializable]
	public struct HAPI_TransformEuler // TypeDefIndex: 49632
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationEuler; // 0x08
		public float[] scale; // 0x10
		public float[] shear; // 0x18
		public HAPI_XYZOrder rotationOrder; // 0x20
		public HAPI_RSTOrder rstOrder; // 0x24
	
		// Constructors
		public HAPI_TransformEuler(bool initializeFields) {
			position = default;
			rotationEuler = default;
			scale = default;
			shear = default;
			rotationOrder = default;
			rstOrder = default;
		} // 0x0000000188805388-0x0000000188805450
	
		// Methods
		public void Init() {} // 0x00000001888052E4-0x0000000188805388
	}

	[Serializable]
	public struct HAPI_Session // TypeDefIndex: 49633
	{
		// Fields
		public HAPI_SessionType type; // 0x00
		public long id; // 0x08
	}

	public struct HAPI_ThriftServerOptions // TypeDefIndex: 49634
	{
		// Fields
		public bool autoClose; // 0x00
		public float timeoutMs; // 0x04
		public HAPI_StatusVerbosity verbosity; // 0x08
	}

	public struct HAPI_TimelineOptions // TypeDefIndex: 49635
	{
		// Fields
		public float fps; // 0x00
		public float startTime; // 0x04
		public float endTime; // 0x08
	}

	[Serializable]
	public struct HAPI_AssetInfo // TypeDefIndex: 49636
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

	public struct HAPI_CookOptions // TypeDefIndex: 49637
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
	public struct HAPI_NodeInfo // TypeDefIndex: 49638
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
	public struct HAPI_ParmInfo // TypeDefIndex: 49639
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
		public bool isInt() => default; // 0x0000000188804FBC-0x0000000188804FDC
		public bool isFloat() => default; // 0x0000000188804FA8-0x0000000188804FBC
		public bool isString() => default; // 0x0000000188805018-0x0000000188805038
		public bool isPath() => default; // 0x0000000188805000-0x0000000188805018
		public bool isNode() => default; // 0x0000000188804FDC-0x0000000188804FEC
		public bool isNonValue() => default; // 0x0000000188804FEC-0x0000000188805000
	}

	[Serializable]
	public struct HAPI_ParmChoiceInfo // TypeDefIndex: 49640
	{
		// Fields
		public int parentParmId; // 0x00
		public int labelSH; // 0x04
		public int valueSH; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleInfo // TypeDefIndex: 49641
	{
		// Fields
		public int nameSH; // 0x00
		public int typeNameSH; // 0x04
		public int bindingsCount; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleBindingInfo // TypeDefIndex: 49642
	{
		// Fields
		public int handleParmNameSH; // 0x00
		public int assetParmNameSH; // 0x04
		public int assetParmId; // 0x08
		public int assetParmIndex; // 0x0C
	}

	[Serializable]
	public struct HAPI_ObjectInfo // TypeDefIndex: 49643
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
	public struct HAPI_GeoInfo // TypeDefIndex: 49644
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
		public int getGroupCountByType(HAPI_GroupType type) => default; // 0x0000000188804F44-0x0000000188804F58
	}

	public struct HAPI_PartInfo // TypeDefIndex: 49645
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
		public int pointAttributeCount { get => default; set {} } // 0x00000001888050A8-0x00000001888050DC 0x00000001888051D4-0x0000000188805214
		public int primitiveAttributeCount { get => default; set {} } // 0x00000001888050DC-0x0000000188805110 0x0000000188805214-0x0000000188805254
		public int vertexAttributeCount { get => default; set {} } // 0x0000000188805110-0x0000000188805144 0x0000000188805254-0x0000000188805294
		public int detailAttributeCount { get => default; set {} } // 0x0000000188805074-0x00000001888050A8 0x0000000188805194-0x00000001888051D4
	
		// Methods
		public int getElementCountByAttributeOwner(HAPI_AttributeOwner owner) => default; // 0x0000000188805038-0x0000000188805060
		public int getElementCountByGroupType(HAPI_GroupType type) => default; // 0x0000000188805060-0x0000000188805074
		public void init() {} // 0x0000000188805144-0x0000000188805194
	}

	[Serializable]
	public struct HAPI_AttributeInfo // TypeDefIndex: 49646
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
		public HAPI_AttributeInfo(string ignored = null) {
			exists = default;
			owner = default;
			storage = default;
			originalOwner = default;
			count = default;
			tupleSize = default;
			totalArrayElements = default;
			typeInfo = default;
		} // 0x0000000183D6D430-0x0000000183D6D460
	}

	public struct HAPI_MaterialInfo // TypeDefIndex: 49647
	{
		// Fields
		public int nodeId; // 0x00
		public bool exists; // 0x04
		public bool hasChanged; // 0x05
	}

	public struct HAPI_ImageFileFormat // TypeDefIndex: 49648
	{
		// Fields
		public int nameSH; // 0x00
		public int descriptionSH; // 0x04
		public int defaultExtensionSH; // 0x08
	}

	public struct HAPI_ImageInfo // TypeDefIndex: 49649
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

	public struct HAPI_Keyframe // TypeDefIndex: 49650
	{
		// Fields
		public float time; // 0x00
		public float value; // 0x04
		public float inTangent; // 0x08
		public float outTangent; // 0x0C
	
		// Constructors
		public HAPI_Keyframe(float t, float v, float in_tangent, float out_tangent) {
			time = default;
			value = default;
			inTangent = default;
			outTangent = default;
		} // 0x0000000183D516B0-0x0000000183D516D0
	}

	public struct HAPI_VolumeInfo // TypeDefIndex: 49651
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

	public struct HAPI_VolumeTileInfo // TypeDefIndex: 49652
	{
		// Fields
		public int minX; // 0x00
		public int minY; // 0x04
		public int minZ; // 0x08
		public bool isValid; // 0x0C
	}

	public struct HAPI_VolumeVisualInfo // TypeDefIndex: 49653
	{
		// Fields
		public HAPI_VolumeVisualType type; // 0x00
		public float iso; // 0x04
		public float density; // 0x08
	}

	public struct HAPI_CurveInfo // TypeDefIndex: 49654
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

	public struct HAPI_InputCurveInfo // TypeDefIndex: 49655
	{
		// Fields
		public HAPI_CurveType curveType; // 0x00
		public int order; // 0x04
		public bool closed; // 0x08
		public bool reverse; // 0x09
		public HAPI_InputCurveMethod inputMethod; // 0x0C
		public HAPI_InputCurveParameterization breakpointParameterization; // 0x10
	
		// Methods
		public void FillData(HEU_InputCurveInfo curveInfo) {} // 0x0000000188804F58-0x0000000188804FA8
	}

	public struct HAPI_BoxInfo // TypeDefIndex: 49656
	{
		// Fields
		public float[] center; // 0x00
		public float[] size; // 0x08
		public float[] rotation; // 0x10
	
		// Constructors
		public HAPI_BoxInfo(bool initialize_fields) {
			center = default;
			size = default;
			rotation = default;
		} // 0x0000000188804EBC-0x0000000188804F44
	}

	public struct HAPI_SphereInfo // TypeDefIndex: 49657
	{
		// Fields
		public float[] center; // 0x00
		public float radius; // 0x08
	
		// Constructors
		public HAPI_SphereInfo(bool initialize_fields) {
			center = default;
			radius = default;
		} // 0x0000000188805294-0x00000001888052E4
	}

	public struct HAPI_PDG_EventInfo // TypeDefIndex: 49658
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

	public struct HAPI_PDG_WorkItemInfo // TypeDefIndex: 49659
	{
		// Fields
		public int index; // 0x00
		public int outputFileCount; // 0x04
		public int nameSH; // 0x08
	}

	public struct HAPI_PDG_WorkItemOutputFile // TypeDefIndex: 49660
	{
		// Fields
		public int filePathSH; // 0x00
		public int tagSH; // 0x04
		public long hash; // 0x08
	}

	[Serializable]
	public struct HAPI_Viewport // TypeDefIndex: 49661
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationQuaternion; // 0x08
		public float offset; // 0x10
	
		// Constructors
		public HAPI_Viewport(bool initializeFields) {
			position = default;
			rotationQuaternion = default;
			offset = default;
		} // 0x0000000188805650-0x00000001888056D4
	
		// Methods
		public void Init() {} // 0x00000001888055D8-0x0000000188805650
	}

	[Serializable]
	public struct HAPI_SessionSyncInfo // TypeDefIndex: 49662
	{
		// Fields
		public bool cookUsingHoudiniTime; // 0x00
		public bool syncViewport; // 0x01
	}

	public struct HAPI_CompositorOptions // TypeDefIndex: 49663
	{
		// Fields
		public int maximumResolutionX; // 0x00
		public int maximumResolutionY; // 0x04
	}

	public class HEU_HARCImports // TypeDefIndex: 49664
	{
		// Constructors
		public HEU_HARCImports() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HEU_HoudiniVersion // TypeDefIndex: 49665
	{
		// Fields
		public const int HOUDINI_MAJOR = 19; // Metadata: 0x01FBE8F2
		public const int HOUDINI_MINOR = 5; // Metadata: 0x01FBE8F3
		public const int HOUDINI_BUILD = 403; // Metadata: 0x01FBE8F4
		public const int HOUDINI_PATCH = 0; // Metadata: 0x01FBE8F6
		public const string HOUDINI_VERSION_STRING = "19.5.403"; // Metadata: 0x01FBE8F7
		public const int HOUDINI_ENGINE_MAJOR = 5; // Metadata: 0x01FBE900
		public const int HOUDINI_ENGINE_MINOR = 0; // Metadata: 0x01FBE901
		public const int HOUDINI_ENGINE_API = 1; // Metadata: 0x01FBE902
		public const int UNITY_PLUGIN_VERSION = 2; // Metadata: 0x01FBE903
		public const string HAPI_BIN_PATH = "/bin"; // Metadata: 0x01FBE904
		public const string HAPI_LIBRARY = "libHAPIL"; // Metadata: 0x01FBE909
		public const string HARC_LIBRARY = "libHARC"; // Metadata: 0x01FBE912
		public const string SIDEFX_SOFTWARE_REGISTRY = "SOFTWARE\\Side Effects Software\\"; // Metadata: 0x01FBE91A
	
		// Constructors
		public HEU_HoudiniVersion() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HTC_APIConstants // TypeDefIndex: 49666
	{
		// Fields
		public const string HOUDINI_MASTER_SERVER_HOSTNAME = "tech.houdini.int.hypergryph.com"; // Metadata: 0x01FBE93A
		public const int HOUDINI_MASTER_QUERY_FOR_UNITY_PORT = 20240; // Metadata: 0x01FBE95A
		public const int TCP_HEADER_SIZE = 4; // Metadata: 0x01FBE95E
		public const int MAX_ERROR_INFO_SIZE = 256; // Metadata: 0x01FBE95F
	
		// Constructors
		public HTC_APIConstants() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HTC_VERSION // TypeDefIndex: 49667
	{
		// Fields
		public const string LIBRARY = "HTCLib"; // Metadata: 0x01FBE961
	
		// Constructors
		public HTC_VERSION() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HoudiniConstsIdentifier // TypeDefIndex: 49668
	{
		// Fields
		public const string HOUDINI_VERSION = "19.5"; // Metadata: 0x01FBE968
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x01FBE96D
	
		// Constructors
		public HoudiniConstsIdentifier() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class HTC_APIFunctions // TypeDefIndex: 49669
	{
		// Constructors
		public HTC_APIFunctions() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static extern void InitHoudiniTcpClient(string address, int port, bool use_ip, [In, Out] StringBuilder error_msg); // 0x000000018881E520-0x000000018881E600
		internal static extern void GetHarsInfo(ref HarsInfo harsInfo, [In, Out] StringBuilder error_msg); // 0x000000018881E410-0x000000018881E520
		internal static extern void UninitializeHoudiniTcpClient([In, Out] StringBuilder error_msg); // 0x000000018881E600-0x000000018881E6A0
	}

	internal struct HarsInfo // TypeDefIndex: 49670
	{
		// Fields
		public string hars_address; // 0x00
		public int port; // 0x08
	}

	internal struct GenericMessage // TypeDefIndex: 49671
	{
		// Fields
		[JsonProperty("protocol")]
		public string protocol; // 0x00
		[JsonProperty("body")]
		public object body; // 0x08
	}

	public static class Logger // TypeDefIndex: 49672
	{
		// Methods
		public static void LogError(string msg) {} // 0x00000001888203F0-0x000000018882043C
		public static void LogWarning(string msg) {} // 0x0000000188820488-0x00000001888204D4
		public static void LogInfo(string msg) {} // 0x000000018882043C-0x0000000188820488
	}

	public class HTC_SessionManager : IDisposable // TypeDefIndex: 49673
	{
		// Fields
		private bool disposedValue; // 0x10
		private static HTC_SessionManager instance_; // 0x00
	
		// Properties
		public static HTC_SessionManager Instance { get => default; } // 0x000000018881F170-0x000000018881F1F4 
	
		// Constructors
		private HTC_SessionManager() {} // 0x000000018881E980-0x000000018881F170
	
		// Methods
		~HTC_SessionManager() {} // 0x000000018881E84C-0x000000018881E8C0
		protected virtual void Dispose(bool disposing) {} // 0x000000018881E758-0x000000018881E84C
		public void Dispose() {} // 0x000000018881E708-0x000000018881E758
		public bool GetOrRequestAvailableHARSInfo(out string harsAddress, out int harsPort, out string errorInfo) {
			harsAddress = default;
			harsPort = default;
			errorInfo = default;
			return default;
		} // 0x000000018881E8C0-0x000000018881E980
		public static void Close() {} // 0x000000018881E6A0-0x000000018881E708
	}

	public static class HTC_Utils // TypeDefIndex: 49674
	{
		// Fields
		private static readonly string CurrentUnityProjectPrefix; // 0x00
	
		// Constructors
		static HTC_Utils() {} // 0x000000018881F3FC-0x000000018881F4A8
	
		// Methods
		public static string GetUnityPathFromSystemPath(string systemPath) => default; // 0x000000018881F1F4-0x000000018881F3FC
	}

	public static class HoudiniExtTools // TypeDefIndex: 49675
	{
		// Fields
		private static readonly string LOCAL_IP_ADDRESS; // 0x00
		private static readonly string REMOTE_HOUDINI_SMB_PATH_PREFIX; // 0x08
		private static readonly string REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX; // 0x10
		public const string REMOTE_HOUDINI_HDA_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_hda"; // Metadata: 0x01FBE99B
		public const string REMOTE_HOUDINI_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_share"; // Metadata: 0x01FBE9CF
		public const string LINUX_MOUNT_DIR_PREFIX = "/mnt/houdini_share"; // Metadata: 0x01FBEA05
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x01FBEA18
	
		// Properties
		private static long DefaultSessionID { get; } // 0x00000001888203A0-0x00000001888203F0 
	
		// Constructors
		static HoudiniExtTools() {} // 0x00000001888202A4-0x00000001888203A0
	
		// Methods
		private static long GetSessionID(long sessionId) => default; // 0x000000018881FFE0-0x000000018882002C
		public static string GetDefaultDirectoryOnTheSMB() => default; // 0x000000018881FAA8-0x000000018881FAF8
		public static string GetDefaultSessionDirectoryOnTheSMB(long sessionId = -1 /* Metadata: 0x01FBE972 */) => default; // 0x000000018881FB24-0x000000018881FBC4
		public static string ConvertLocalDirPathToSessionDirPath(string localPath, bool doMd5 = true /* Metadata: 0x01FBE97A */, long sessionId = -1 /* Metadata: 0x01FBE97B */) => default; // 0x000000018881F72C-0x000000018881F85C
		public static string ConvertLocalDebugFilePathToSessionDebugFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x01FBE983 */) => default; // 0x000000018881F634-0x000000018881F72C
		public static string ConvertLocalFilePathToSessionFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x01FBE98B */) => default; // 0x000000018881F85C-0x000000018881FA48
		public static bool IsLocalPath(string path) => default; // 0x000000018882002C-0x00000001888202A4
		public static string GetMD5WithString(string str) => default; // 0x000000018881FEDC-0x000000018881FFE0
		public static string GetLocalIPv4() => default; // 0x000000018881FBF0-0x000000018881FEDC
		public static string GetHoudiniSMBUrl() => default; // 0x000000018881FBC4-0x000000018881FBF0
		public static string GetDefaultCachePath(long sessionId = -1 /* Metadata: 0x01FBE993 */) => default; // 0x000000018881FA48-0x000000018881FAA8
		public static string GetDefaultHdaPath() => default; // 0x000000018881FAF8-0x000000018881FB24
	}

	public static class HoudiniExtBridge // TypeDefIndex: 49676
	{
		// Methods
		public static bool GetParametersFromHDA(byte[] hdaBytes, out HEU_Parameters parameters, out List<HEU_InputNode> inputNodes) {
			parameters = default;
			inputNodes = default;
			return default;
		} // 0x000000018881F4E8-0x000000018881F634
		public static void AddInputNodeToHoudiniAsset(HEU_HoudiniAsset asset, HEU_InputNode node) {} // 0x000000018881F4A8-0x000000018881F4C4
	
		// Extension methods
		public static void Clear(this HEU_Parameters parameters) {} // 0x000000018881F4C4-0x000000018881F4E8
	}

	[Serializable]
	public sealed class HEU_ParameterData : IEquivable<HEU_ParameterData> // TypeDefIndex: 49677
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
		public int ParmID { get => default; } // 0x0000000183D4EB50-0x0000000183D4EB60 
		public int ParentID { get => default; } // 0x0000000183D51960-0x0000000183D51970 
		public int ChildIndex { get => default; } // 0x0000000183D50E50-0x0000000183D50E60 
		public int ParmSize { get => default; } // 0x0000000183D57DA0-0x0000000183D57DB0 
		public int IntMin { get => default; } // 0x000000018880BAA4-0x000000018880BAB4 
		public int IntMax { get => default; } // 0x000000018880BA94-0x000000018880BAA4 
		public int IntUIMin { get => default; } // 0x000000018880BAC4-0x000000018880BAD4 
		public int IntUIMax { get => default; } // 0x000000018880BAB4-0x000000018880BAC4 
		public float FloatMin { get => default; } // 0x0000000183D598B0-0x0000000183D598C0 
		public float FloatMax { get => default; } // 0x0000000183D583B0-0x0000000183D583C0 
		public float FloatUIMin { get => default; } // 0x0000000183D574D0-0x0000000183D574E0 
		public float FloatUIMax { get => default; } // 0x0000000183D58E00-0x0000000183D58E10 
	
		// Constructors
		public HEU_ParameterData() {} // 0x000000018880BA1C-0x000000018880BA94
	
		// Methods
		public bool IsInt() => default; // 0x000000018880B948-0x000000018880B954
		public bool IsFloat() => default; // 0x000000018880B930-0x000000018880B93C
		public bool IsString() => default; // 0x000000018880B984-0x000000018880B990
		public bool IsPathFile() => default; // 0x000000018880B954-0x000000018880B96C
		public bool HasMin() => default; // 0x0000000183D6D690-0x0000000183D6D6A0
		public bool HasMax() => default; // 0x0000000183D6D680-0x0000000183D6D690
		public bool HasUIMin() => default; // 0x0000000183D6D6B0-0x0000000183D6D6C0
		public bool HasUIMax() => default; // 0x0000000183D6D6A0-0x0000000183D6D6B0
		public bool IsContainer() => default; // 0x000000018880B1A8-0x000000018880B1EC
		public bool IsMultiParam() => default; // 0x000000018589F914-0x000000018589F920
		public bool IsRamp() => default; // 0x000000018880B96C-0x000000018880B984
		public bool IsFloatRamp() => default; // 0x000000018880B924-0x000000018880B930
		public bool IsColorRamp() => default; // 0x000000018880B190-0x000000018880B19C
		public bool IsToggle() => default; // 0x000000018880B990-0x000000018880B99C
		public bool IsColor() => default; // 0x000000018880B19C-0x000000018880B1A8
		public bool IsFolder() => default; // 0x000000018880B93C-0x000000018880B948
		public bool IsButton() => default; // 0x000000018880B184-0x000000018880B190
		public Vector3 ToVector3() => default; // 0x000000018880B99C-0x000000018880BA1C
		public bool IsAssetPath() => default; // 0x0000000183D57CB0-0x0000000183D57CC0
		public bool IsEquivalentTo(HEU_ParameterData other) => default; // 0x000000018880B1EC-0x000000018880B924
	}

	public enum HEU_ModifierActionWrapper // TypeDefIndex: 49678
	{
		MULTIPARM_INSERT = 0,
		MULTIPARM_REMOVE = 1,
		MULTIPARM_CLEAR = 2,
		SET_FLOAT = 3,
		SET_INT = 4
	}

	[Serializable]
	public class HEU_ParameterModifier : IEquivable<HEU_ParameterModifier> // TypeDefIndex: 49680
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
		public int ParameterIndex { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public HEU_ModifierActionWrapper Action { get => default; set {} } // 0x000000018880BDAC-0x000000018880BDB8 0x000000018880BDB8-0x000000018880BDD8
		public int InstanceIndex { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public int ModifierValue { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public float FloatValue { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public int IntValue { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
	
		// Nested types
		internal enum ModifierAction // TypeDefIndex: 49679
		{
			MULTIPARM_INSERT = 0,
			MULTIPARM_REMOVE = 1,
			MULTIPARM_CLEAR = 2,
			SET_FLOAT = 3,
			SET_INT = 4
		}
	
		// Constructors
		public HEU_ParameterModifier() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static HEU_ParameterModifier GetNewModifier(HEU_ModifierActionWrapper action, int parameterIndex, int instanceIndex, int modifierValue) => default; // 0x000000018880BAD4-0x000000018880BB1C
		internal static HEU_ParameterModifier GetNewModifier(ModifierAction action, int parameterIndex, int instanceIndex, int modifierValue) => default; // 0x000000018880BB1C-0x000000018880BB90
		public bool IsEquivalentTo(HEU_ParameterModifier other) => default; // 0x000000018880BB90-0x000000018880BD78
		internal static HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(ModifierAction action) => default; // 0x000000018880BD78-0x000000018880BDAC
		internal static ModifierAction ModifierAction_WrapperToInternal(HEU_ModifierActionWrapper action) => default; // 0x000000018880BD78-0x000000018880BDAC
	}

	public class HEU_Parameters : ScriptableObject, IHEU_Parameters, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Parameters> // TypeDefIndex: 49683
	{
		// Fields
		[SerializeField]
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
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public bool ShowParameters { get => default; set {} } // 0x0000000183D51AE0-0x0000000183D51AF0 0x0000000183D51B40-0x0000000183D51B50
		public int NodeID { get => default; internal set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public List<int> RootParameters { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public List<HEU_ParameterModifier> ParameterModifiers { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		internal bool RequiresRegeneration { get => default; set {} } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183D519B0-0x0000000183D519C0
		internal bool RecacheUI { get => default; set {} } // 0x0000000183D51AF0-0x0000000183D51B00 0x0000000183D51B50-0x0000000183D51B60
	
		// Constructors
		public HEU_Parameters() {} // 0x0000000188816DB4-0x0000000188816EF0
	
		// Methods
		internal byte[] GetPresetData() => default; // 0x0000000183D4EAB0-0x0000000183D4EAC0
		internal void SetPresetData(byte[] data) {} // 0x00000001838C5570-0x00000001838C5580
		internal byte[] GetDefaultPresetData() => default; // 0x0000000183D4EB30-0x0000000183D4EB40
		public bool AreParametersValid() => default; // 0x0000000183D4F800-0x0000000183D4F810
		public HEU_SessionBase GetSession() => default; // 0x000000018880E844-0x000000018880E8DC
		public void Recook() {} // 0x0000000188813BCC-0x0000000188813C34
		public List<HEU_ParameterData> GetParameters() => default; // 0x0000000183D4EAF0-0x0000000183D4EB00
		public HEU_ParameterData GetParameter(int listIndex) => default; // 0x000000018880E57C-0x000000018880E5EC
		public HEU_ParameterData GetParameter(string name) => default; // 0x000000018880E5EC-0x000000018880E72C
		public HEU_ParameterData GetParameterWithParmID(int parmID) => default; // 0x000000018880E45C-0x000000018880E57C
		public void RemoveParameter(int listIndex) {} // 0x0000000188813CBC-0x0000000188813D28
		public bool HaveParametersChanged() => default; // 0x000000018880ECC0-0x000000018880F16C
		public bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x01FBEA27 */) => default; // 0x0000000188813ED4-0x0000000188813F1C
		public bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x01FBEA28 */, bool bRecookAsset = false /* Metadata: 0x01FBEA29 */) => default; // 0x0000000188814B68-0x0000000188814D70
		public bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x01FBEA2A */) {
			value = default;
			return default;
		} // 0x000000018880CFB8-0x000000018880D1AC
		public bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x01FBEA2B */) => default; // 0x0000000188814D70-0x0000000188814FCC
		public bool GetFloatParameterValues(string parameterName, out float[] values) {
			values = default;
			return default;
		} // 0x000000018880D1AC-0x000000018880D344
		public bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x01FBEA2C */) => default; // 0x00000001888145AC-0x00000001888146D8
		public bool GetColorParameterValue(string parameterName, out UnityEngine.Color value) {
			value = default;
			return default;
		} // 0x000000018880C974-0x000000018880CA94
		public bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x01FBEA2D */, bool bRecookAsset = false /* Metadata: 0x01FBEA2E */) => default; // 0x0000000188815464-0x000000018881566C
		public bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x01FBEA2F */) {
			value = default;
			return default;
		} // 0x000000018880DB4C-0x000000018880DD40
		public bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x01FBEA30 */) => default; // 0x000000018881566C-0x00000001888158D0
		public bool GetIntParameterValues(string parameterName, out int[] values) {
			values = default;
			return default;
		} // 0x000000018880DD40-0x000000018880DEDC
		public bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x01FBEA31 */) => default; // 0x00000001888143DC-0x00000001888145AC
		public bool GetChoiceParameterValue(string parameterName, out int value) {
			value = default;
			return default;
		} // 0x000000018880C7CC-0x000000018880C974
		public bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x01FBEA32 */, bool bRecookAsset = false /* Metadata: 0x01FBEA33 */) => default; // 0x00000001888142C0-0x00000001888143DC
		public bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x01FBEA34 */) {
			value = default;
			return default;
		} // 0x000000018880C6C0-0x000000018880C7CC
		public bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x01FBEA35 */, bool bRecookAsset = false /* Metadata: 0x01FBEA36 */) => default; // 0x0000000188815F30-0x0000000188816144
		public bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x01FBEA37 */) {
			value = default;
			return default;
		} // 0x000000018880E8DC-0x000000018880EAF8
		public bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x01FBEA38 */) => default; // 0x0000000188816144-0x00000001888163BC
		public bool GetStringParameterValues(string parameterName, out string[] values) {
			values = default;
			return default;
		} // 0x000000018880EAF8-0x000000018880EC7C
		public bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x01FBEA39 */, bool bRecookAsset = false /* Metadata: 0x01FBEA3A */) => default; // 0x0000000188813F1C-0x00000001888140E4
		public bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x01FBEA3B */) => default; // 0x00000001888140E4-0x00000001888142C0
		public bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x01FBEA3C */) {
			value = default;
			return default;
		} // 0x000000018880C37C-0x000000018880C4F4
		public bool GetAssetRefParameterValues(string parameterName, out GameObject[] values) {
			values = default;
			return default;
		} // 0x000000018880C4F4-0x000000018880C6C0
		public bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x01FBEA3D */) => default; // 0x0000000188815CBC-0x0000000188815F30
		public bool GetRampParameterNumPoints(string parameterName, out int numPoints) {
			numPoints = default;
			return default;
		} // 0x000000018880E72C-0x000000018880E844
		public bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEA3E */, bool bRecookAsset = false /* Metadata: 0x01FBEA3F */) => default; // 0x0000000188814FCC-0x00000001888152C4
		public bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType) {
			pointPosition = default;
			pointValue = default;
			interpolationType = default;
			return default;
		} // 0x000000018880D344-0x000000018880D638
		public bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x01FBEA40 */) => default; // 0x00000001888152C4-0x0000000188815464
		public bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints) {
			rampPoints = default;
			return default;
		} // 0x000000018880D638-0x000000018880D86C
		public bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEA41 */, bool bRecookAsset = false /* Metadata: 0x01FBEA42 */) => default; // 0x00000001888146D8-0x00000001888149BC
		public bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType) {
			pointPosition = default;
			pointValue = default;
			interpolationType = default;
			return default;
		} // 0x000000018880CA94-0x000000018880CD80
		public bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x01FBEA43 */) => default; // 0x00000001888149BC-0x0000000188814B68
		public bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints) {
			rampPoints = default;
			return default;
		} // 0x000000018880CD80-0x000000018880CFB8
		public bool TriggerButtonParameter(string parameterName) => default; // 0x00000001888168D0-0x0000000188816A0C
		public bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecook = true /* Metadata: 0x01FBEA44 */) => default; // 0x00000001888158D0-0x0000000188815CBC
		public bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples) {
			parameterTuples = default;
			return default;
		} // 0x000000018880E078-0x000000018880E45C
		internal bool Initialize(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, Dictionary<string, HEU_ParameterData> previousParamFolders, Dictionary<string, HEU_InputNode> previousParamInputNodes, HEU_HoudiniAsset parentAsset) => default; // 0x00000001888112B0-0x0000000188813428
		internal bool Initialize4HGTool(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, int parentNodeId) => default; // 0x000000018880F16C-0x00000001888112B0
		private void SetupRampParameter(HEU_ParameterData rampParameter) {} // 0x00000001888163BC-0x00000001888167C8
		internal bool UploadValuesToHoudini(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bDoCheck = true /* Metadata: 0x01FBEA45 */, bool bForceUploadInputs = false /* Metadata: 0x01FBEA46 */) => default; // 0x0000000188816CB0-0x0000000188816DB4
		internal void InsertInstanceToMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToAdd) {} // 0x0000000188813428-0x00000001888134B0
		internal void RemoveInstancesFromMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToRemove) {} // 0x0000000188813C34-0x0000000188813CBC
		internal void ClearInstancesFromMultiParm(int unityParamIndex) {} // 0x000000018880C274-0x000000018880C2E4
		internal bool HasModifiersPending() => default; // 0x000000018880EC7C-0x000000018880ECC0
		internal void ProcessModifiers(HEU_SessionBase session) {} // 0x0000000188813768-0x0000000188813BCC
		internal void GetParameterDataForUIRestore(Dictionary<string, HEU_ParameterData> folderParams, Dictionary<string, HEU_InputNode> inputNodeParams) {} // 0x000000018880DEDC-0x000000018880E078
		internal void GetInputNodeConnectionObjects(List<GameObject> inputNodeObjects) {} // 0x000000018880D86C-0x000000018880DB4C
		internal void DownloadPresetData(HEU_SessionBase session) {} // 0x000000018880C330-0x000000018880C37C
		internal void UploadPresetData(HEU_SessionBase session) {} // 0x0000000188816C88-0x0000000188816CB0
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session) {} // 0x000000018880C2E4-0x000000018880C330
		internal void UploadParameterInputs(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bForceUpdate) {} // 0x0000000188816A9C-0x0000000188816C88
		internal void UpdateTransformParameters(HEU_SessionBase session, ref HAPI_TransformEuler HAPITransform) {} // 0x0000000188816A0C-0x0000000188816A9C
		internal void SyncParameterFromHoudini(HEU_SessionBase session, string parameterName) {} // 0x00000001888168A0-0x00000001888168D0
		internal void SyncInternalParametersForUndoCompare(HEU_SessionBase session) {} // 0x00000001888167C8-0x00000001888168A0
		internal void CleanUp() {} // 0x000000018880BDD8-0x000000018880C274
		internal void ResetAllToDefault(HEU_SessionBase session) {} // 0x0000000188813D28-0x0000000188813ED4
		public bool IsEquivalentTo(HEU_Parameters other) => default; // 0x00000001888134B0-0x0000000188813768
	}

	public static class HEU_ParameterUtility // TypeDefIndex: 49684
	{
		// Methods
		public static bool GetToggle(HEU_HoudiniAsset asset, string paramName, out bool outValue) {
			outValue = default;
			return default;
		} // 0x000000018882BEFC-0x000000018882BFC0
		public static bool SetToggle(HEU_HoudiniAsset asset, string paramName, bool setValue) => default; // 0x000000018882C528-0x000000018882C5EC
		public static bool GetInt(HEU_HoudiniAsset asset, string paramName, out int outValue) {
			outValue = default;
			return default;
		} // 0x000000018882BAF0-0x000000018882BBB4
		public static bool SetInt(HEU_HoudiniAsset asset, string paramName, int setValue) => default; // 0x000000018882C3A0-0x000000018882C464
		public static bool GetFloat(HEU_HoudiniAsset asset, string paramName, out float outValue) {
			outValue = default;
			return default;
		} // 0x000000018882B89C-0x000000018882B960
		public static bool GetFloats(HEU_HoudiniAsset asset, string paramName, out float[] outValues) {
			outValues = default;
			return default;
		} // 0x000000018882B960-0x000000018882BA24
		public static bool SetFloat(HEU_HoudiniAsset asset, string paramName, float setValue) => default; // 0x000000018882C14C-0x000000018882C210
		public static bool SetFloats(HEU_HoudiniAsset asset, string paramName, float[] setValues) => default; // 0x000000018882C210-0x000000018882C2D0
		public static bool GetString(HEU_HoudiniAsset asset, string paramName, out string outValue) {
			outValue = default;
			return default;
		} // 0x000000018882BE30-0x000000018882BEFC
		public static bool SetString(HEU_HoudiniAsset asset, string paramName, string setValue) => default; // 0x000000018882C464-0x000000018882C528
		public static bool SetChoice(HEU_HoudiniAsset asset, string paramName, int setValue) => default; // 0x000000018882BFC0-0x000000018882C080
		public static bool GetChoice(HEU_HoudiniAsset asset, string paramName, out int outValue) {
			outValue = default;
			return default;
		} // 0x000000018882B714-0x000000018882B7D0
		public static bool SetInputNode(HEU_HoudiniAsset asset, string paramName, GameObject obj, int index) => default; // 0x000000018882C2D0-0x000000018882C3A0
		public static bool GetInputNode(HEU_HoudiniAsset asset, string paramName, int index, out GameObject obj) {
			obj = default;
			return default;
		} // 0x000000018882BA24-0x000000018882BAF0
		public static bool GetColor(HEU_HoudiniAsset asset, string paramName, out UnityEngine.Color getValue) {
			getValue = default;
			return default;
		} // 0x000000018882B7D0-0x000000018882B89C
		public static bool SetColor(HEU_HoudiniAsset asset, string paramName, UnityEngine.Color setValue) => default; // 0x000000018882C080-0x000000018882C14C
		public static int GetParameterIndexFromName(HEU_SessionBase session, HAPI_ParmInfo[] parameters, string parameterName) => default; // 0x000000018882BD74-0x000000018882BE30
		public static int GetParameterIndexFromNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName) => default; // 0x000000018882BD40-0x000000018882BD74
		public static int FindTextureParamByNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, string useTextureParmName) => default; // 0x000000018882B628-0x000000018882B714
		public static bool GetParameterFloatValue(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, float defaultValue, out float returnValue) {
			returnValue = default;
			return default;
		} // 0x000000018882BC94-0x000000018882BD40
		public static bool GetParameterColor3Value(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, UnityEngine.Color defaultValue, out UnityEngine.Color outputColor) {
			outputColor = default;
			return default;
		} // 0x000000018882BBB4-0x000000018882BC94
	}

	[Serializable]
	public class HEU_PDGCookedDataEvent : UnityEvent<HEU_PDGCookedEventData> // TypeDefIndex: 49685
	{
		// Constructors
		public HEU_PDGCookedDataEvent() {} // 0x000000018882AD88-0x000000018882ADC4
	}

	public class HEU_PDGCookedEventData // TypeDefIndex: 49686
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_TOPNodeData TopNodeData; // 0x18
	
		// Constructors
		public HEU_PDGCookedEventData() {} // Dummy constructor
		public HEU_PDGCookedEventData(bool bSuccess, HEU_TOPNodeData bTopNodeData) {} // 0x0000000182F73D00-0x0000000182F73D10
	}

	[ExecuteInEditMode]
	public class HEU_PDGAssetLink : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 49691
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
		public bool AutoCook { get => default; set {} } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183D519B0-0x0000000183D519C0
		public bool UseHEngineData { get => default; set {} } // 0x0000000183D51F90-0x0000000183D51FA0 0x0000000183D5B410-0x0000000183D5B420
		public bool UseTOPNodeFilter { get => default; set {} } // 0x0000000183D51D50-0x0000000183D51D60 0x0000000183D56D40-0x0000000183D56D50
		public bool UseTOPOutputFilter { get => default; set {} } // 0x0000000183D51D10-0x0000000183D51D20 0x0000000183D5B370-0x0000000183D5B380
		public string TopNodeFilter { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		public string TopOutputFilter { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public string AssetPath { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public GameObject AssetGO { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public string AssetName { get => default; } // 0x0000000181003830-0x0000000181003840 
		public int AssetID { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
		public List<HEU_TOPNetworkData> TopNetworks { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public string[] TopNetworkNames { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public int SelectedTOPNetwork { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		public HEU_LinkStateWrapper PDGLinkState { get => default; } // 0x000000018882AD5C-0x000000018882AD88 
		public GameObject LoadRootGameObject { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public string OutputCachePathRoot { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public HEU_PDGCookedDataEvent CookedDataEvent { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal LinkState AssetLinkStateInternal { get => default; } // 0x0000000183D4EEF0-0x0000000183D4EF00 
	
		// Nested types
		internal enum LinkState // TypeDefIndex: 49687
		{
			INACTIVE = 0,
			LINKING = 1,
			LINKED = 2,
			ERROR_NOT_LINKED = 3
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 49688; 0x00000001842BE03C-0x00000001842BE04C
	
		// Constructors
		public HEU_PDGAssetLink() {} // 0x000000018882AC4C-0x000000018882AD5C
	
		// Methods
		public void Setup(HEU_HoudiniAsset hdaAsset) {} // 0x000000018882A6A4-0x000000018882A834
		public void Reset() {} // 0x000000018882A500-0x000000018882A508
		public void Refresh() {} // 0x000000018882A1B0-0x000000018882A43C
		public List<KeyValuePair<int, HEU_TOPNodeData>> GetNonHiddenTOPNodes(HEU_TOPNetworkData topNetwork) => default; // 0x000000018882868C-0x00000001888287D8
		public void SelectTOPNetwork(int newIndex) {} // 0x000000018882A508-0x000000018882A55C
		public void SelectTOPNode(HEU_TOPNetworkData network, int newIndex) {} // 0x000000018882A55C-0x000000018882A5B4
		public HEU_TOPNetworkData GetSelectedTOPNetwork() => default; // 0x00000001888287D8-0x00000001888287E4
		public HEU_TOPNodeData GetSelectedTOPNode() => default; // 0x00000001888287E4-0x0000000188828860
		public HEU_TOPNetworkData GetTOPNetwork(int index) => default; // 0x0000000188828908-0x0000000188828978
		public void DirtyTOPNode(HEU_TOPNodeData topNode) {} // 0x0000000188828380-0x00000001888283A8
		public void CookTOPNode(HEU_TOPNodeData topNode) {} // 0x0000000188828380-0x00000001888283A8
		public void DirtyAll() {} // 0x0000000188828558-0x0000000188828578
		public void CookOutput() {} // 0x000000018882833C-0x0000000188828380
		public void PauseCook() {} // 0x0000000188827DBC-0x0000000188827DCC
		public void CancelCook() {} // 0x0000000188827DBC-0x0000000188827DCC
		public HEU_SessionBase GetHAPISession() => default; // 0x0000000188828578-0x00000001888285EC
		public HEU_TOPNodeData GetTOPNode(int nodeID) => default; // 0x0000000188828AF0-0x0000000188828C54
		public string GetTOPNodeStatus(HEU_TOPNodeData topNode) => default; // 0x0000000188828A20-0x0000000188828AF0
		public static HEU_TOPNetworkData GetTOPNetworkByName(string name, List<HEU_TOPNetworkData> topNetworks) => default; // 0x0000000188828860-0x0000000188828908
		public static HEU_TOPNodeData GetTOPNodeByName(string name, List<HEU_TOPNodeData> topNodes) => default; // 0x0000000188828978-0x0000000188828A20
		private void Awake() {} // 0x000000018350B670-0x000000018350B680
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public void OnAfterDeserialize() {} // 0x000000018350B670-0x000000018350B680
		private void HandleInitialLoad() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x0000000188829574-0x0000000188829584
		private void NotifyAssetCooked(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> generatedOutputs) {} // 0x000000018882953C-0x0000000188829574
		private void NotifyAssetCooked(HEU_CookedEventData cookedEventData) {} // 0x0000000188829514-0x000000018882953C
		private void NotifyAssetCooked(HEU_ReloadEventData reloadEventData) {} // 0x0000000188829514-0x000000018882953C
		private void PopulateFromHDA() {} // 0x0000000188829D18-0x0000000188829E60
		public bool PopulateTOPNetworks() => default; // 0x0000000188829E60-0x000000018882A038
		private bool PopulateTOPNodes(HEU_SessionBase session, HEU_TOPNetworkData topNetwork, int[] topNodeIDs, bool useHEngineData) => default; // 0x000000018882A038-0x000000018882A1B0
		private void ClearAllTOPData() {} // 0x0000000188827DCC-0x0000000188828098
		private static void ClearTOPNetworkWorkItemResults(HEU_TOPNetworkData topNetwork) {} // 0x0000000188828098-0x00000001888281AC
		internal static void ClearTOPNodeWorkItemResults(HEU_TOPNodeData topNode) {} // 0x00000001888281AC-0x00000001888282A8
		internal static void ClearWorkItemResultByID(HEU_TOPNodeData topNode, int workItemID) {} // 0x00000001888282A8-0x00000001888282CC
		private static void ClearWorkItemResult(HEU_TOPNodeData topNode, HEU_TOPWorkResult result) {} // 0x00000001888282CC-0x000000018882833C
		internal void UpdateTOPNodeResultsVisibility(HEU_TOPNodeData topNode) {} // 0x000000018882A834-0x000000018882A8A8
		private static HEU_TOPWorkResult GetWorkResultByID(HEU_TOPNodeData topNode, int workItemID) => default; // 0x0000000188828C54-0x0000000188828DA0
		private static void DestroyWorkItemResultData(HEU_TOPNodeData topNode, HEU_TOPWorkResult result) {} // 0x00000001888283A8-0x0000000188828558
		internal void LoadResults(HEU_SessionBase session, HEU_TOPNodeData topNode, HAPI_PDG_WorkItemInfo workItemInfo, HAPI_PDG_WorkItemOutputFile[] resultInfos, int workItemID, Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced) {} // 0x0000000188828DA0-0x0000000188829514
		private Transform GetLoadRootTransform() => default; // 0x00000001888285EC-0x000000018882868C
		public void RepaintUI() {} // 0x000000018882A43C-0x000000018882A454
		public void UpdateWorkItemTally() {} // 0x000000018882A8A8-0x000000018882AC4C
		internal void ResetTOPNetworkWorkItemTally(HEU_TOPNetworkData topNetwork) {} // 0x000000018882A454-0x000000018882A500
		internal void OnTOPNodeFilterChanged(string filter) {} // 0x00000001888295DC-0x0000000188829958
		internal void OnTOPOutputFilterChanged(string filter) {} // 0x0000000188829958-0x0000000188829CB8
		private static void ParseHEngineData(HEU_SessionBase session, int topNodeID, ref HAPI_NodeInfo nodeInfo, ref TOPNodeTags nodeTags) {} // 0x0000000188829CB8-0x0000000188829D18
		private void SetupTopNetworkNames(HEU_TOPNetworkData topNetwork) {} // 0x000000018882A5B4-0x000000018882A6A4
		private void OnSyncComplete(HEU_PDGCookedEventData Data) {} // 0x0000000188829584-0x00000001888295DC
		internal static HEU_LinkStateWrapper LinkState_InternalToWrapper(LinkState linkState) => default; // 0x00000001887DF02C-0x00000001887DF054
		internal static LinkState LinkState_WrapperToInternal(HEU_LinkStateWrapper linkState) => default; // 0x00000001887DF02C-0x00000001887DF054
	}

	public class TOPNodeTags // TypeDefIndex: 49692
	{
		// Fields
		public bool _show; // 0x10
		public bool _autoload; // 0x11
		public bool _showHEngineData; // 0x12
		public bool _autoloadHEngineData; // 0x13
	
		// Constructors
		public TOPNodeTags() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class HEU_TOPNetworkData // TypeDefIndex: 49693
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
		public HEU_TOPNetworkData() {} // 0x000000018882EE44-0x000000018882EF0C
	}

	[Serializable]
	public class HEU_TOPNodeData // TypeDefIndex: 49695
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
		public enum PDGState // TypeDefIndex: 49694
		{
			NONE = 0,
			DIRTIED = 1,
			DIRTYING = 2,
			COOKING = 3,
			COOK_COMPLETE = 4,
			COOK_FAILED = 5
		}
	
		// Constructors
		public HEU_TOPNodeData() {} // 0x000000018882EF98-0x000000018882F068
	
		// Methods
		public void Reset() {} // 0x000000018882EF6C-0x000000018882EF98
		public bool AreAllWorkItemsComplete() => default; // 0x000000018882EF4C-0x000000018882EF6C
		public bool AnyWorkItemsFailed() => default; // 0x000000018882EF0C-0x000000018882EF2C
		public bool AnyWorkItemsPending() => default; // 0x000000018882EF2C-0x000000018882EF4C
	}

	[Serializable]
	public class HEU_TOPWorkResult // TypeDefIndex: 49696
	{
		// Fields
		public int _workItemIndex; // 0x10
		public int _workItemID; // 0x14
		public List<GameObject> _generatedGOs; // 0x18
	
		// Constructors
		public HEU_TOPWorkResult() {} // 0x000000018882F068-0x000000018882F0E8
	}

	[Serializable]
	public class HEU_WorkItemTally // TypeDefIndex: 49697
	{
		// Fields
		public int _totalWorkItems; // 0x10
		public int _waitingWorkItems; // 0x14
		public int _scheduledWorkItems; // 0x18
		public int _cookingWorkItems; // 0x1C
		public int _cookedWorkItems; // 0x20
		public int _erroredWorkItems; // 0x24
	
		// Constructors
		public HEU_WorkItemTally() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void ZeroAll() {} // 0x0000000183D6D890-0x0000000183D6D8A0
		public bool AreAllWorkItemsComplete() => default; // 0x000000018882F79C-0x000000018882F7BC
		public bool AnyWorkItemsFailed() => default; // 0x000000018882F778-0x000000018882F780
		public bool AnyWorkItemsPending() => default; // 0x000000018882F780-0x000000018882F79C
		public string ProgressRatio() => default; // 0x000000018882F7BC-0x000000018882F84C
	}

	public class HEU_PDGSession // TypeDefIndex: 49701
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
		public Action<HEU_PDGCookedEventData> CookedDataEvent { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
		// Nested types
		private delegate void OnWorkItemLoadResultsDelegate(HEU_SyncedEventData OnSynced); // TypeDefIndex: 49698; 0x0000000182149960-0x0000000182149970
	
		private enum EventMessageColor // TypeDefIndex: 49699
		{
			DEFAULT = 0,
			WARNING = 1,
			ERROR = 2
		}
	
		// Constructors
		public HEU_PDGSession() {} // 0x000000018882B4D8-0x000000018882B628
	
		// Methods
		public static HEU_PDGSession GetPDGSession() => default; // 0x000000018882B0D0-0x000000018882B160
		public void AddAsset(HEU_PDGAssetLink asset) {} // 0x000000018350B670-0x000000018350B680
		public void RemoveAsset(HEU_PDGAssetLink asset) {} // 0x000000018350B670-0x000000018350B680
		private void Update() {} // 0x000000018350B670-0x000000018350B680
		private void CleanUp() {} // 0x000000018882AE98-0x000000018882AF60
		private void UpdatePDGContext() {} // 0x000000018350B670-0x000000018350B680
		public void ReinitializePDGContext() {} // 0x000000018350B670-0x000000018350B680
		private void ProcessPDGEvent(HEU_SessionBase session, int contextID, ref HAPI_PDG_EventInfo eventInfo) {} // 0x000000018350B670-0x000000018350B680
		private void OnWorkItemLoadResults(HEU_TOPNodeData topNode, HEU_SyncedEventData OnSynced) {} // 0x000000018882B428-0x000000018882B434
		private void CheckCallback(HEU_TOPNodeData topNode) {} // 0x000000018882ADE4-0x000000018882AE98
		private bool GetTOPAssetLinkAndNode(int nodeID, out HEU_PDGAssetLink assetLink, out HEU_TOPNodeData topNode) {
			assetLink = default;
			topNode = default;
			return default;
		} // 0x000000018882B160-0x000000018882B264
		private void SetTOPNodePDGState(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, HEU_TOPNodeData.PDGState pdgState) {} // 0x000000018882B47C-0x000000018882B4D8
		private void NotifyTOPNodePDGStateClear(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode) {} // 0x000000018882B328-0x000000018882B368
		private void NotifyTOPNodeTotalWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x000000018882B3A8-0x000000018882B3E8
		private void NotifyTOPNodeCookedWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode) {} // 0x000000018882B280-0x000000018882B2B4
		private void NotifyTOPNodeErrorWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode) {} // 0x000000018882B2F4-0x000000018882B328
		private void NotifyTOPNodeWaitingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x000000018882B3E8-0x000000018882B428
		private void NotifyTOPNodeScheduledWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x000000018882B368-0x000000018882B3A8
		private void NotifyTOPNodeCookingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x000000018882B2B4-0x000000018882B2F4
		private static void ResetPDGEventInfo(ref HAPI_PDG_EventInfo eventInfo) {} // 0x0000000183D6D710-0x0000000183D6D730
		private void SetErrorState(string msg, bool bLogIt) {} // 0x000000018882B434-0x000000018882B47C
		private void ClearErrorState() {} // 0x000000018882AF60-0x000000018882AFA4
		public HEU_SessionBase GetHAPIPDGSession(bool bCreate = true /* Metadata: 0x01FBEA51 */) => default; // 0x000000018882AFEC-0x000000018882B03C
		public void CookTOPNetworkOutputNode(HEU_TOPNetworkData topNetwork, Action<HEU_PDGCookedEventData> OnCook = null) {} // 0x000000018350B670-0x000000018350B680
		public void PauseCook(HEU_TOPNetworkData topNetwork) {} // 0x000000018350B670-0x000000018350B680
		public void CancelCook(HEU_TOPNetworkData topNetwork) {} // 0x000000018350B670-0x000000018350B680
		public void ClearWorkItemResult(HEU_SessionBase session, int contextID, HAPI_PDG_EventInfo eventInfo, HEU_TOPNodeData topNode) {} // 0x000000018350B670-0x000000018350B680
		public bool DirtyTOPNode(int nodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public bool CookTOPNode(int nodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public bool DirtyAll(int nodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public void AddEventMessage(string msg) {} // 0x000000018882ADC4-0x000000018882ADE4
		public string GetEventMessages() => default; // 0x000000018882AFC8-0x000000018882AFEC
		public void ClearEventMessages() {} // 0x000000018882AFA4-0x000000018882AFC8
		public static int[] GetNonBypassedNetworkIds(HEU_SessionBase session, int assetId) => default; // 0x000000018882B03C-0x000000018882B0D0
		public static bool IsPDGAsset(HEU_SessionBase session, int assetId) => default; // 0x000000018882B264-0x000000018882B280
		private void ResetCallbackVariables() {} // 0x0000000183D6D700-0x0000000183D6D710
	}

	public interface IHEU_Curve // TypeDefIndex: 49702
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
		void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x01FBEA55 */);
		void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x01FBEA56 */);
		void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x01FBEA57 */);
		Vector3 GetCurvePoint(int pointIndex);
		List<CurveNodeData> GetAllPointTransforms();
		List<Vector3> GetAllPoints();
		int GetNumPoints();
		void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x01FBEA58 */);
		void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x01FBEA59 */);
		void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x01FBEA5A */);
		void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x01FBEA5B */);
		void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x01FBEA5C */);
		void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x01FBEA5D */);
		void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x01FBEA5E */);
		void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x01FBEA5F */);
		Vector3 GetTransformedPoint(int pointIndex);
		List<Vector3> GetTransformedPoints();
		List<CurveNodeData> DuplicateCurveNodeData();
	}

	public interface IHEU_GeoNode // TypeDefIndex: 49703
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
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x01FBEA60 */);
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

	public enum HEU_AssetCookStatusWrapper // TypeDefIndex: 49704
	{
		NONE = 0,
		COOKING = 1,
		POSTCOOK = 2,
		LOADING = 3,
		POSTLOAD = 4,
		PRELOAD = 5,
		SELECT_SUBASSET = 6
	}

	public enum HEU_AssetCookResultWrapper // TypeDefIndex: 49705
	{
		NONE = 0,
		SUCCESS = 1,
		ERRORED = 2
	}

	public enum HEU_CurveDrawCollisionWrapper // TypeDefIndex: 49706
	{
		INVALID = 0,
		COLLIDERS = 1,
		LAYERMASK = 2
	}

	public enum HEU_AssetTypeWrapper // TypeDefIndex: 49707
	{
		TYPE_INVALID = 0,
		TYPE_HDA = 1,
		TYPE_CURVE = 2,
		TYPE_INPUT = 3
	}

	public interface IHEU_HoudiniAsset // TypeDefIndex: 49708
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
		bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x01FBEA72 */, bool bAsync = false /* Metadata: 0x01FBEA73 */, bool bSkipCookCheck = true /* Metadata: 0x01FBEA74 */, bool bUploadParameters = true /* Metadata: 0x01FBEA75 */);
		bool RequestReload(bool bAsync = false /* Metadata: 0x01FBEA76 */);
		bool RequestResetParameters(bool bAsync = false /* Metadata: 0x01FBEA77 */);
		GameObject DuplicateAsset(GameObject newRootGameObject = null);
		bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x01FBEA78 */);
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
		HEU_AssetPreset GetAssetPreset();
		HEU_PDGAssetLink GetOrCreatePDGAssetLink();
	}

	public interface IHEU_HoudiniAssetSubcomponent // TypeDefIndex: 49709
	{
		// Properties
		HEU_HoudiniAsset ParentAsset { get; }
	
		// Methods
		HEU_SessionBase GetSession();
		void Recook();
	}

	public enum HEU_InputNodeTypeWrapper // TypeDefIndex: 49710
	{
		CONNECTION = 0,
		NODE = 1,
		PARAMETER = 2
	}

	public enum HEU_InputObjectTypeWrapper // TypeDefIndex: 49711
	{
		HDA = 0,
		UNITY_MESH = 1,
		CURVE = 2,
		TERRAIN = 3,
		BOUNDING_BOX = 4,
		TILEMAP = 5
	}

	public interface IHEU_InputNode // TypeDefIndex: 49712
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
	
		// Methods
		bool IsAssetInput();
		int NumInputEntries();
		GameObject GetInputEntryGameObject(int index);
		GameObject[] GetInputEntryGameObjects();
		void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x01FBEA82 */);
		void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x01FBEA83 */);
		void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x01FBEA84 */);
		void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x01FBEA85 */);
		void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x01FBEA86 */);
		void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x01FBEA87 */);
		void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x01FBEA88 */);
		void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x01FBEA89 */);
		void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x01FBEA8A */);
		void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x01FBEA8B */);
		void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x01FBEA8C */);
		bool AreAnyInputHDAsConnected();
		int GetConnectedInputCount();
		int GetConnectedNodeID(int index);
		void LoadPreset(HEU_InputPreset inputPreset);
		void PopulateInputPreset(HEU_InputPreset inputPreset);
	}

	public enum HEU_MaterialSourceWrapper // TypeDefIndex: 49713
	{
		DEFAULT = 0,
		HOUDINI = 1,
		UNITY = 2,
		SUBSTANCE = 3
	}

	public interface IHEU_MaterialData // TypeDefIndex: 49714
	{
		// Properties
		Material Material { get; }
		HEU_MaterialSourceWrapper MaterialSource { get; }
		int MaterialKey { get; set; }
	
		// Methods
		bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath);
		bool IsExistingMaterial();
	}

	public interface IHEU_ObjectNode // TypeDefIndex: 49715
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

	public enum HEU_HoudiniRampInterpolationTypeWrapper // TypeDefIndex: 49716
	{
		CONSTANT = 0,
		LINEAR = 1,
		CATMULL_ROM = 2
	}

	public class HEU_RampPointWrapper // TypeDefIndex: 49717
	{
		// Properties
		public float Position { get; set; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
		public HEU_HoudiniRampInterpolationTypeWrapper Interpolation { get; set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
	
		// Constructors
		public HEU_RampPointWrapper() {} // Dummy constructor
		public HEU_RampPointWrapper(float position = 0f /* Metadata: 0x01FBEA94 */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEA98 */) {} // 0x0000000183D6D730-0x0000000183D6D740
	}

	public class HEU_FloatRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 49718
	{
		// Properties
		public float Value { get; set; } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
	
		// Constructors
		public HEU_FloatRampPointWrapper() {} // Dummy constructor
		public HEU_FloatRampPointWrapper(float position = 0f /* Metadata: 0x01FBEA99 */, float value = 0f /* Metadata: 0x01FBEA9D */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEAA1 */) {} // 0x0000000183D6D6F0-0x0000000183D6D700
	}

	public class HEU_ColorRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 49719
	{
		// Properties
		public UnityEngine.Color Value { get; set; } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000183D51D90-0x0000000183D51DA0
	
		// Constructors
		public HEU_ColorRampPointWrapper() {} // Dummy constructor
		public HEU_ColorRampPointWrapper(float position = 0f /* Metadata: 0x01FBEAA2 */, UnityEngine.Color value = default, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEAA6 */) {} // 0x0000000183D6D6D0-0x0000000183D6D6F0
	}

	public class HEU_ParameterTupleWrapper // TypeDefIndex: 49720
	{
		// Fields
		internal bool[] _boolValues; // 0x10
		internal int[] _intValues; // 0x18
		internal float[] _floatValues; // 0x20
		internal string[] _stringValues; // 0x28
		internal HEU_FloatRampPointWrapper[] _floatRampValues; // 0x30
		internal HEU_ColorRampPointWrapper[] _colorRampValues; // 0x38
	
		// Properties
		public bool[] BoolValues { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public int[] IntValues { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float[] FloatValues { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string[] StringValues { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public HEU_FloatRampPointWrapper[] FloatRampValues { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public HEU_ColorRampPointWrapper[] ColorRampValues { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
	
		// Constructors
		public HEU_ParameterTupleWrapper() {} // 0x000000018350B670-0x000000018350B680
		public HEU_ParameterTupleWrapper(bool[] boolValues) {} // 0x000000018426FEE0-0x000000018426FEF0
		public HEU_ParameterTupleWrapper(int[] intValues) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public HEU_ParameterTupleWrapper(float[] floatValues) {} // 0x0000000184271930-0x0000000184271940
		public HEU_ParameterTupleWrapper(string[] stringValues) {} // 0x0000000182C92F10-0x0000000182C92F20
		public HEU_ParameterTupleWrapper(HEU_FloatRampPointWrapper[] floatRampValues) {} // 0x0000000184270470-0x0000000184270480
		public HEU_ParameterTupleWrapper(HEU_ColorRampPointWrapper[] colorRampValues) {} // 0x000000018388FF30-0x000000018388FF40
	}

	public interface IHEU_Parameters // TypeDefIndex: 49721
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
		bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x01FBEAA7 */);
		bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x01FBEAA8 */, bool bRecookAsset = false /* Metadata: 0x01FBEAA9 */);
		bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x01FBEAAA */);
		bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x01FBEAAB */);
		bool GetFloatParameterValues(string parameterName, out float[] values);
		bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x01FBEAAC */);
		bool GetColorParameterValue(string parameterName, out UnityEngine.Color value);
		bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x01FBEAAD */, bool bRecookAsset = false /* Metadata: 0x01FBEAAE */);
		bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x01FBEAAF */);
		bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x01FBEAB0 */);
		bool GetIntParameterValues(string parameterName, out int[] values);
		bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x01FBEAB1 */);
		bool GetChoiceParameterValue(string parameterName, out int value);
		bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x01FBEAB2 */, bool bRecookAsset = false /* Metadata: 0x01FBEAB3 */);
		bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x01FBEAB4 */);
		bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x01FBEAB5 */, bool bRecookAsset = false /* Metadata: 0x01FBEAB6 */);
		bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x01FBEAB7 */);
		bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x01FBEAB8 */);
		bool GetStringParameterValues(string parameterName, out string[] values);
		bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x01FBEAB9 */, bool bRecookAsset = false /* Metadata: 0x01FBEABA */);
		bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x01FBEABB */);
		bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x01FBEABC */);
		bool GetAssetRefParameterValues(string parameterName, out GameObject[] values);
		bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x01FBEABD */);
		bool GetRampParameterNumPoints(string parameterName, out int numPoints);
		bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEABE */, bool bRecookAsset = false /* Metadata: 0x01FBEABF */);
		bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x01FBEAC0 */);
		bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints);
		bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x01FBEAC1 */, bool bRecookAsset = false /* Metadata: 0x01FBEAC2 */);
		bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x01FBEAC3 */);
		bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints);
		bool TriggerButtonParameter(string parameterName);
		bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecookAsset = false /* Metadata: 0x01FBEAC4 */);
		bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples);
	}

	public interface IHEU_PartData // TypeDefIndex: 49722
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
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x01FBEAC5 */);
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

	public enum HEU_LinkStateWrapper // TypeDefIndex: 49723
	{
		INACTIVE = 0,
		LINKING = 1,
		LINKED = 2,
		ERROR_NOT_LINKED = 3
	}

	public interface IHEU_PDGAssetLink // TypeDefIndex: 49724
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

	public interface IHEU_VolumeCache // TypeDefIndex: 49725
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

	public class HEU_MaterialData : ScriptableObject, IHEU_MaterialData, IEquivable<HEU_MaterialData> // TypeDefIndex: 49727
	{
		// Fields
		[SerializeField]
		internal Material _material; // 0x18
		[SerializeField]
		internal Source _materialSource; // 0x20
		[SerializeField]
		internal int _materialKey; // 0x24
	
		// Properties
		public Material Material { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public HEU_MaterialSourceWrapper MaterialSource { get => default; } // 0x00000001888261D8-0x0000000188826204 
		public int MaterialKey { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
	
		// Nested types
		internal enum Source // TypeDefIndex: 49726
		{
			DEFAULT = 0,
			HOUDINI = 1,
			UNITY = 2,
			SUBSTANCE = 3
		}
	
		// Constructors
		public HEU_MaterialData() {} // 0x00000001888261C8-0x00000001888261D8
	
		// Methods
		public bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath) => default; // 0x00000001888257E0-0x0000000188825AE8
		public bool IsExistingMaterial() => default; // 0x0000000188825788-0x000000018882579C
		private bool UseLegacyShaders(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath, HEU_SessionBase session, HAPI_NodeInfo nodeInfo, HAPI_ParmInfo[] parmInfos) => default; // 0x0000000188825AE8-0x00000001888261C8
		internal static string GetTextureFileNameFromMaterialParam(HEU_SessionBase session, int nodeID, HAPI_ParmInfo parmInfo) => default; // 0x00000001888254E8-0x00000001888255EC
		internal static bool IsTransparentMaterial(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters) => default; // 0x000000018882579C-0x00000001888257E0
		internal static bool GetMaterialAlpha(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, float defaultValue, out float alpha) {
			alpha = default;
			return default;
		} // 0x0000000188825274-0x00000001888253E8
		internal static string GetSupportedFileFormat(HEU_SessionBase session, ref HAPI_ImageInfo imageInfo) => default; // 0x00000001888253E8-0x00000001888254E8
		public bool IsEquivalentTo(HEU_MaterialData other) => default; // 0x00000001888255EC-0x0000000188825788
		internal static Source MaterialSource_WrapperToInternal(HEU_MaterialSourceWrapper materialSource) => default; // 0x00000001887DF02C-0x00000001887DF054
		internal static HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(Source materialSource) => default; // 0x00000001887DF02C-0x00000001887DF054
	}

	public class HEU_MaterialFactory // TypeDefIndex: 49728
	{
		// Fields
		public static Material _defaultStandardMaterial; // 0x00
	
		// Constructors
		public HEU_MaterialFactory() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Shader FindShader(string shaderName) => default; // 0x0000000188826A14-0x0000000188826A4C
		public static Shader FindPluginShader(string shaderName) => default; // 0x00000001888269DC-0x0000000188826A14
		public static Material GetNewMaterialWithShader(string assetCacheFolderPath, string shaderName, string materialName = "" /* Metadata: 0x01FBEACE */, bool bWriteToFile = true /* Metadata: 0x01FBEACF */) => default; // 0x0000000188826E80-0x0000000188827050
		public static Material CreateNewHoudiniStandardMaterial(string assetCacheFolderPath, string materialName, bool bWriteToFile) => default; // 0x0000000188826514-0x0000000188826560
		public static void WriteMaterialToAssetCache(Material material, string assetCacheFolderPath, string materialName, bool bOverwriteExisting) {} // 0x0000000188827A48-0x0000000188827B20
		public static bool DoesMaterialExistInAssetCache(Material material) => default; // 0x0000000188826874-0x0000000188826898
		public static void DestroyNonAssetMaterial(Material material, bool bRegisterUndo) {} // 0x0000000188826800-0x0000000188826874
		public static void DeleteAssetMaterial(Material material) {} // 0x00000001888267F8-0x0000000188826800
		public static Texture2D RenderAndExtractImageToTexture(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, int textureParmID, string textureName, string assetCacheFolderPath, bool isNormalMap, bool invertTexture = false /* Metadata: 0x01FBEAD0 */) => default; // 0x0000000188827980-0x0000000188827A40
		private static Texture2D ExtractHoudiniImageToTexturePNGJPEG(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes) => default; // 0x000000018882693C-0x0000000188826974
		private static Texture2D ExtractHoudiniImageToTextureRaw(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes) => default; // 0x0000000188826974-0x00000001888269DC
		public static Texture2D ExtractHoudiniImageToTextureFile(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes, string assetCacheFolderPath) => default; // 0x00000001888268B8-0x000000018882693C
		public static Material LoadUnityMaterial(string materialPath) => default; // 0x0000000188827678-0x0000000188827964
		public static Material LoadSubstanceMaterialWithName(string materialPath, string substanceName) => default; // 0x00000001888273E4-0x0000000188827570
		public static Material LoadSubstanceMaterialWithIndex(string materialPath, int substanceMaterialIndex) => default; // 0x000000018882721C-0x00000001888273E4
		public static int GetUnitySubstanceMaterialKey(string unityMaterialPath, string substanceName, int substanceIndex) => default; // 0x0000000188827120-0x000000018882721C
		public static int MaterialNameToKey(string materialName) => default; // 0x0000000183D4C200-0x0000000183D4C220
		public static void EnableGPUInstancing(Material material) {} // 0x0000000188826898-0x00000001888268B8
		public static bool MaterialHasGPUInstancingEnabled(Material material) => default; // 0x0000000188827964-0x0000000188827980
		public static Material CopyMaterial(Material material) => default; // 0x0000000188826204-0x0000000188826264
		public static Material GetDefaultStandardMaterial() => default; // 0x0000000188826AE8-0x0000000188826B98
		public static Texture2D LoadTexture(string path) => default; // 0x0000000188827570-0x0000000188827678
		public static Texture2D WhiteTexture() => default; // 0x0000000188827A40-0x0000000188827A48
		public static HEU_MaterialData CreateUnitySubstanceMaterialData(int materialKey, string materialPath, string substanceName, int substanceIndex, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x0000000188826560-0x00000001888267F8
		public static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialSourceWrapper sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x00000001888263AC-0x0000000188826408
		internal static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialData.Source sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x0000000188826408-0x0000000188826514
		public static HEU_MaterialData GetOrCreateDefaultMaterialInCache(HEU_SessionBase session, int geoID, int partID, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x0000000188827050-0x0000000188827120
		public static HEU_MaterialData GetMaterialDataFromCache(int materialKey, List<HEU_MaterialData> materialCache) => default; // 0x0000000188826B98-0x0000000188826CB4
		public static string GenerateDefaultMaterialName(int geoID, int partID) => default; // 0x0000000188826A4C-0x0000000188826AE8
		public static HEU_MaterialData CreateHoudiniMaterialData(HEU_SessionBase session, int assetID, int materialID, int geoID, int partID, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x0000000188826264-0x00000001888263AC
		public static Dictionary<int, HEU_MaterialData> GetMaterialDataMapFromCache(List<HEU_MaterialData> materialCache) => default; // 0x0000000188826CB4-0x0000000188826E80
	}

	public class HEU_UnityMaterialInfo // TypeDefIndex: 49729
	{
		// Fields
		public string _unityMaterialPath; // 0x10
		public string _substancePath; // 0x18
		public int _substanceIndex; // 0x20
	
		// Constructors
		public HEU_UnityMaterialInfo() {} // Dummy constructor
		public HEU_UnityMaterialInfo(string unityMaterialPath, string substancePath, int substanceIndex) {} // 0x0000000183864580-0x00000001838645B0
	}

	public class HEU_SessionBase // TypeDefIndex: 49730
	{
		// Fields
		protected HEU_SessionData _sessionData; // 0x10
		private string _sessionErrorMsg; // 0x20
	
		// Properties
		public bool UserNotifiedSessionInvalid { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public SessionConnectionState ConnectionState { get => default; set {} } // 0x000000018882CA84-0x000000018882CA98 0x000000018882CAAC-0x000000018882CABC
		public SessionMode ThisSessionMode { get => default; set {} } // 0x000000018882CA98-0x000000018882CAAC 0x000000018882CABC-0x000000018882CACC
		public bool LogErrorOverride { get; set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public bool ThrowErrorOverride { get; set; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
		public HAPI_Result LastCallResultCode { get; set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
	
		// Constructors
		public HEU_SessionBase() {} // 0x0000000183D6D870-0x0000000183D6D880
	
		// Methods
		public string GetSessionErrorMsg() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public bool IsSessionSync() => default; // 0x000000018882C7B4-0x000000018882C7CC
		public virtual HEU_HoudiniAsset GetRegisteredAssetFromID(int id) => default; // 0x0000000181002730-0x0000000181002740
		public virtual bool IsAssetRegistered(HEU_HoudiniAsset asset) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void RegisterAsset(HEU_HoudiniAsset asset) {} // 0x000000018350B670-0x000000018350B680
		public virtual void UnregisterAsset(int id) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ReregisterOnAwake(HEU_HoudiniAsset asset) {} // 0x000000018350B670-0x000000018350B680
		public virtual void SetSessionErrorMsg(string msg, bool bLogError = false /* Metadata: 0x01FBEAD1 */) {} // 0x000000018882CA14-0x000000018882CA4C
		public virtual void SetSessionConnectionErrorMsg(string introMsg, HAPI_Result result, bool bIsHARSRunning, bool bLogError = false /* Metadata: 0x01FBEAD2 */) {} // 0x000000018882C858-0x000000018882CA14
		public virtual void SetLibraryErrorMsg(bool bLogError = false /* Metadata: 0x01FBEAD3 */) {} // 0x000000018882C7CC-0x000000018882C858
		protected virtual bool CreateSessionData(bool bOverwriteExisting, bool bIsDefaultSession) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CreateInProcessSession(bool bIsDefaultSession) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CreateThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x01FBEAD4 */, int serverPort = 9090 /* Metadata: 0x01FBEADE */, bool autoClose = true /* Metadata: 0x01FBEAE2 */, float timeout = 100000f /* Metadata: 0x01FBEAE3 */, bool bLogError = true /* Metadata: 0x01FBEAE7 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CreateThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x01FBEAE8 */, bool autoClose = true /* Metadata: 0x01FBEAED */, float timeout = 100000f /* Metadata: 0x01FBEAEE */, bool bLogError = true /* Metadata: 0x01FBEAF2 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CreateCustomSession(bool bIsDefaultSession) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ConnectThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x01FBEAF3 */, int serverPort = 9090 /* Metadata: 0x01FBEAFD */, bool autoClose = true /* Metadata: 0x01FBEB01 */, float timeout = 100000f /* Metadata: 0x01FBEB02 */, bool logError = true /* Metadata: 0x01FBEB06 */, bool autoInitialize = true /* Metadata: 0x01FBEB07 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ConnectThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x01FBEB08 */, bool autoClose = true /* Metadata: 0x01FBEB0D */, float timeout = 100000f /* Metadata: 0x01FBEB0E */, bool logError = true /* Metadata: 0x01FBEB12 */, bool autoInitialize = true /* Metadata: 0x01FBEB13 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CloseSession() => default; // 0x000000018115F4C0-0x000000018115F530
		protected virtual bool CheckAndCloseExistingSession() => default; // 0x000000018115F4C0-0x000000018115F530
		protected virtual void ClearSessionInfo() {} // 0x000000018882C5EC-0x000000018882C634
		public void SetSessionData(HEU_SessionData sessionData) {} // 0x000000018426FEE0-0x000000018426FEF0
		public HEU_SessionData GetSessionData() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public virtual string GetSessionInfo() => default; // 0x000000018882C75C-0x000000018882C788
		public virtual bool IsSessionValid() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RestartSession() => default; // 0x000000018115F4C0-0x000000018115F530
		public string GetLastSessionError() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public virtual bool CheckVersionMatch() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool InitializeSession(HEU_SessionData sessionData) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool HandleStatusResult(HAPI_Result result, string prependMsg, bool bThrowError, bool bLogError) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void SetServerEnvString(string name, string value) {} // 0x000000018350B670-0x000000018350B680
		public virtual bool GetServerEnvString(string name, out string value) {
			value = default;
			return default;
		} // 0x000000018882C740-0x000000018882C75C
		public virtual bool GetServerEnvVarCount(out int env_count) {
			env_count = default;
			return default;
		} // 0x0000000183D6D7D0-0x0000000183D6D7E0
		public virtual bool GetCallResult(out HAPI_Result result) {
			result = default;
			return default;
		} // 0x0000000183D6D7D0-0x0000000183D6D7E0
		public virtual bool GetCookResult(out HAPI_Result result) {
			result = default;
			return default;
		} // 0x0000000183D6D7D0-0x0000000183D6D7E0
		public virtual bool GetCookState(out HAPI_State state) {
			state = default;
			return default;
		} // 0x0000000183D6D7D0-0x0000000183D6D7E0
		public virtual string GetStatusString(HAPI_StatusType statusType, HAPI_StatusVerbosity verbosity) => default; // 0x000000018882C788-0x000000018882C7B4
		public virtual string ComposeNodeCookResult(int nodeId, HAPI_StatusVerbosity verbosity) => default; // 0x000000018882C634-0x000000018882C660
		public virtual int GetEnvInt(HAPI_EnvIntType intType) => default; // 0x0000000181002730-0x0000000181002740
		public virtual int GetSessionEnvInt(HAPI_SessionEnvIntType intType, bool bLogError) => default; // 0x0000000181002730-0x0000000181002740
		public virtual bool GetString(int stringHandle, ref string resultString, int bufferLength) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual int GetStringBufferLength(int stringHandle) => default; // 0x0000000181002730-0x0000000181002740
		public virtual int CheckForSpecificErrors(int nodeID, int errorsToCheck) => default; // 0x0000000181002730-0x0000000181002740
		public virtual float GetTime() => default; // 0x0000000183D503F0-0x0000000183D50400
		public virtual bool SetTime(float time) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetUseHoudiniTime() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetUseHoudiniTime(bool enable) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool LoadAssetLibraryFromFile(string assetPath, bool bAllowOverwrite, out int libraryID) {
			libraryID = default;
			return default;
		} // 0x0000000183D6D7E0-0x0000000183D6D7F0
		public virtual bool LoadAssetLibraryFromMemory(byte[] buffer, bool bAllowOverwrite, out int libraryID) {
			libraryID = default;
			return default;
		} // 0x0000000183D6D7E0-0x0000000183D6D7F0
		public virtual bool CreateNode(int parentNodeID, string operatorName, string nodeLabel, bool bCookOnCreation, out int newNodeID) {
			newNodeID = default;
			return default;
		} // 0x0000000183D6D7C0-0x0000000183D6D7D0
		public virtual void DeleteNode(int nodeID) {} // 0x000000018350B670-0x000000018350B680
		public virtual bool CookNode(int nodeID, bool bCookTemplatedGeos, bool bSplitGeosByGroup = false /* Metadata: 0x01FBEB14 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CookNodeWithOptions(int nodeID, HAPI_CookOptions cookOptions) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RenameNode(int nodeID, string newName) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ConnectNodeInput(int nodeID, int inputIndex, int nodeIDToConnect, int outputIndex = 0 /* Metadata: 0x01FBEB15 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool DisconnectNodeInput(int nodeID, int inputIndex, bool bLogError) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool QueryNodeInput(int nodeID, int inputIndex, out int connectedNodeID, bool bLogError) {
			connectedNodeID = default;
			return default;
		} // 0x0000000183D6D810-0x0000000183D6D820
		public virtual bool GetNodeInputName(int nodeID, int inputIndex, out int nodeNameIndex) {
			nodeNameIndex = default;
			return default;
		} // 0x0000000183D6D7E0-0x0000000183D6D7F0
		public virtual bool GetAvailableAssetCount(int libraryID, out int assetCount) {
			assetCount = default;
			return default;
		} // 0x0000000183D6D740-0x0000000183D6D750
		public virtual bool GetAvailableAssets(int libraryID, ref int[] assetNames, int assetCount) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAssetInfo(int nodeID, ref HAPI_AssetInfo assetInfo, bool bLogError = true /* Metadata: 0x01FBEB16 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetNodeInfo(int nodeID, ref HAPI_NodeInfo nodeInfo, bool bLogError = true /* Metadata: 0x01FBEB17 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetNodePath(int nodeID, int relativeNodeID, out string path) {
			path = default;
			return default;
		} // 0x0000000186B99BB0-0x0000000186B99BCC
		public virtual bool IsNodeValid(int nodeID, int uniqueNodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ComposeChildNodeList(int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, ref int count, bool bLogError = true /* Metadata: 0x01FBEB18 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetComposedChildNodeList(int parentNodeID, int[] childNodeIDs, int count, bool bLogError = true /* Metadata: 0x01FBEB19 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool LoadHIPFile(string fileName, bool bCookOnLoad) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SaveHIPFile(string fileName, bool bLockNodes) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetObjectInfo(int nodeID, ref HAPI_ObjectInfo objectInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetObjectTransform(int nodeID, int relativeToNodeID, HAPI_RSTOrder rstOrder, ref HAPI_Transform hapiTransform) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetObjectTransform(int nodeID, ref HAPI_TransformEuler hapiTransform) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ComposeObjectList(int nodeID, out int objectCount) {
			objectCount = default;
			return default;
		} // 0x0000000183D6D740-0x0000000183D6D750
		public virtual bool GetComposedObjectList(int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length) {
			objectInfos = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetComposedObjectTransforms(int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length) {
			transforms = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetDisplayGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = false /* Metadata: 0x01FBEB1A */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetOutputGeoCount(int nodeID, out int count, bool bLogError = false /* Metadata: 0x01FBEB1B */) {
			count = default;
			return default;
		} // 0x0000000183D6D740-0x0000000183D6D750
		public virtual bool GetOutputGeoInfos(int nodeID, ref HAPI_GeoInfo[] geoInfosArray, int count, bool bLogError = false /* Metadata: 0x01FBEB1C */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = true /* Metadata: 0x01FBEB1D */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeInfo(int nodeID, int partID, string name, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeNames(int nodeID, int partID, HAPI_AttributeOwner owner, ref string[] attributeNames, int count) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] dataArray, int start, int length) {
			dataArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out float[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, ref float[] data, int dataLength, ref int[] sizesArray, int start, int sizesLength) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeFloat64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out double[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeUInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out byte[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out sbyte[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out short[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out long[] data, int start, int length) {
			data = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetGroupNames(int nodeID, HAPI_GroupType groupType, ref int[] names, int count) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length) {
			membershipArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetGroupCountOnPackedInstancePart(int nodeID, int partID, out int pointGroupCount, out int primitiveGroupCount) {
			pointGroupCount = default;
			primitiveGroupCount = default;
			return default;
		} // 0x0000000183D6D7F0-0x0000000183D6D800
		public virtual bool GetGroupNamesOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, ref int[] groupNamesArray, int groupCount) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetGroupMembershipOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length) {
			membershipArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetInstancedPartIds(int nodeID, int partID, out int[] instancedPartsArray, int start, int length) {
			instancedPartsArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetInstancerPartTransforms(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length) {
			transformsArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetInstanceTransformsOnPart(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length) {
			transformsArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetInstancedObjectIds(int nodeID, out int[] instanced_node_id_array, int start, int length) {
			instanced_node_id_array = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length) {
			faceCounts = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length, bool bLogError) {
			faceCounts = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetVertexList(int nodeID, int partID, out int[] vertexList, int start, int length) {
			vertexList = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetBoxInfo(int nodeID, int partID, ref HAPI_BoxInfo boxInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetSphereInfo(int nodeID, int partID, ref HAPI_SphereInfo sphereInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetCurveCounts(int nodeID, int partID, out int[] counts, int start, int length) {
			counts = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetCurveOrders(int nodeID, int partID, out int[] orders, int start, int length) {
			orders = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetCurveKnots(int nodeID, int partID, out float[] knots, int start, int length) {
			knots = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo inputCurveInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetFaceCount(int nodeID, int partID, int[] faceCounts, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetVertexList(int nodeID, int partID, int[] vertexList, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, int[] data, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, sbyte[] data, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, short[] data, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, long[] data, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int dataLength, int[] sizesArray, int start, int sizesLength) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, string[] data, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool AddAttribute(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool AddGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool DeleteGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, out int[] membershipArray, int start, int length) {
			membershipArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool CommitGeo(int nodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RevertGeo(int nodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetCurveCounts(int nodeID, int partID, int[] counts, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetCurveOrders(int nodeID, int partID, int[] orders, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetCurveKnots(int nodeID, int partID, float[] knots, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo curveInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetInputCurvePositions(int nodeID, int partID, float[] positionsArray, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetInputCurvePositionsRotationsScales(int nodeID, int partID, float[] positionsArray, int start, int length, float[] rotationsArray, int rotationsStart, int rotationsLength, float[] scalesArray, int scalesStart, int scalesLength) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetMaterialOnPart(int nodeID, int partID, ref HAPI_MaterialInfo materialInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetMaterialNodeIDsOnFaces(int nodeID, int partID, ref bool bSingleFaceMaterial, out int[] materialNodeIDs, int faceCount) {
			materialNodeIDs = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetMaterialInfo(int materialNodeID, ref HAPI_MaterialInfo materialInfo, bool bLogError = true /* Metadata: 0x01FBEB1E */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RenderTextureToImage(int materialNodeID, int parmID, bool bLogError = true /* Metadata: 0x01FBEB1F */) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RenderCOPToImage(int copNodeID) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ExtractImageToMemory(int nodeID, string fileFormat, string imagePlanes, out byte[] buffer) {
			buffer = default;
			return default;
		} // 0x000000018882C67C-0x000000018882C6C0
		public virtual bool GetImagePlanes(int nodeID, out int[] imagePlanes, int numImagePlanes) {
			imagePlanes = default;
			return default;
		} // 0x000000018882C6C0-0x000000018882C6F8
		public virtual bool ExtractImageToFile(int nodeID, string fileFormat, string imagePlanes, string destinationFolderPath, out string destinationFilePath) {
			destinationFilePath = default;
			return default;
		} // 0x000000018882C660-0x000000018882C67C
		public virtual bool GetParams(int nodeID, out HAPI_ParmInfo[] parmInfos, int start, int length) {
			parmInfos = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParmTagName(int nodeID, int parmID, int tagIndex, out int tagName) {
			tagName = default;
			return default;
		} // 0x0000000183D6D800-0x0000000183D6D810
		public virtual bool GetParmTagValue(int nodeID, int parmID, string tagName, out int tagValue) {
			tagValue = default;
			return default;
		} // 0x0000000183D6D800-0x0000000183D6D810
		public virtual bool ParmHasTag(int nodeID, int parmID, string tagName, ref bool hasTag) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParamIntValues(int nodeID, out int[] values, int start, int length) {
			values = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParamIntValue(int nodeID, string parmName, int index, out int value) {
			value = default;
			return default;
		} // 0x0000000183D6D800-0x0000000183D6D810
		public virtual bool GetParamFloatValues(int nodeID, out float[] values, int start, int length) {
			values = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParamFloatValue(int nodeID, string parmName, int index, out float value) {
			value = default;
			return default;
		} // 0x0000000183D6D800-0x0000000183D6D810
		public virtual bool GetParamStringValues(int nodeID, out int[] values, int start, int length) {
			values = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParamStringValue(int nodeID, string parmName, int index, out int value) {
			value = default;
			return default;
		} // 0x0000000183D6D800-0x0000000183D6D810
		public virtual bool GetParamNodeValue(int nodeID, string paramName, out int nodeValue) {
			nodeValue = default;
			return default;
		} // 0x0000000183D6D810-0x0000000183D6D820
		public virtual bool GetParamChoiceValues(int nodeID, out HAPI_ParmChoiceInfo[] values, int start, int length) {
			values = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamIntValues(int nodeID, ref int[] values, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamIntValue(int nodeID, string paramName, int index, int value) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamFloatValues(int nodeID, ref float[] values, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamFloatValue(int nodeID, string paramName, int index, float value) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamStringValue(int nodeID, string strValue, int parmID, int index) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamStringValue(int nodeID, string parmName, string parmValue, int index) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetParamNodeValue(int nodeID, string paramName, int nodeValueID) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool InsertMultiparmInstance(int nodeID, int parmID, int instancePosition) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RemoveMultiParmInstance(int nodeID, int parmID, int instancePosition) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParmWithTag(int nodeID, string tagName, ref int parmID) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RevertParmToDefault(int nodeID, string parm_name, int index) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RevertParmToDefaults(int nodeID, string parm_name) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetParmIDFromName(int nodeID, string parmName, out int parmID) {
			parmID = default;
			return default;
		} // 0x0000000183D6D810-0x0000000183D6D820
		public virtual bool GetParmStringValue(int nodeID, string parmName, int index, bool evaluate, out int value) {
			value = default;
			return default;
		} // 0x0000000183D6D820-0x0000000183D6D830
		public virtual bool CreateInputNode(out int nodeID, string name) {
			nodeID = default;
			return default;
		} // 0x0000000183D6D7B0-0x0000000183D6D7C0
		public virtual bool CreateInputCurveNode(out int nodeID, string name) {
			nodeID = default;
			return default;
		} // 0x0000000183D6D7B0-0x0000000183D6D7C0
		public virtual bool CreateHeightFieldInput(int parentNodeID, string name, int xSize, int ySize, float voxelSize, HAPI_HeightFieldSampling sampling, out int heightfieldNodeID, out int heightNodeID, out int maskNodeID, out int mergeNodeID) {
			heightfieldNodeID = default;
			heightNodeID = default;
			maskNodeID = default;
			mergeNodeID = default;
			return default;
		} // 0x0000000183D6D770-0x0000000183D6D7A0
		public virtual bool CreateHeightfieldInputVolumeNode(int parentNodeID, out int newNodeID, string name, int xSize, int ySize, float voxelSize) {
			newNodeID = default;
			return default;
		} // 0x0000000183D6D7A0-0x0000000183D6D7B0
		public virtual bool GetPreset(int nodeID, out byte[] presetData) {
			presetData = default;
			return default;
		} // 0x000000018882C6F8-0x000000018882C740
		public virtual bool SetPreset(int nodeID, byte[] presetData) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetHeightFieldData(int nodeID, int partID, float[] valuesArray, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetVolumeTileFloatData(int nodeID, int partID, ref HAPI_VolumeTileInfo tileInfo, float[] valuesArray, int length) => default; // 0x000000018882CA4C-0x000000018882CA84
		public virtual bool GetVolumeBounds(int nodeID, int partID, out float x_min, out float y_min, out float z_min, out float x_max, out float y_max, out float z_max, out float x_center, out float y_center, out float z_center) {
			x_min = default;
			y_min = default;
			z_min = default;
			x_max = default;
			y_max = default;
			z_max = default;
			x_center = default;
			y_center = default;
			z_center = default;
			return default;
		} // 0x0000000183D6D830-0x0000000183D6D870
		public virtual bool SetHeightFieldData(int nodeID, int partID, string name, float[] valuesArray, int start, int length) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetActiveCacheCount(out int activeCacheCount) {
			activeCacheCount = default;
			return default;
		} // 0x0000000183D6D7D0-0x0000000183D6D7E0
		public virtual bool GetActiveCacheNames(out int[] cacheNamesArray, int activeCacheCount) {
			cacheNamesArray = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, out int propertyValue) {
			propertyValue = default;
			return default;
		} // 0x0000000183D6D7E0-0x0000000183D6D7F0
		public virtual bool SetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, int propertyValue) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SaveGeoToFile(int nodeID, string fileName) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool LoadGeoFromFile(int nodeID, string file_name) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SaveNodeToFile(int nodeID, string fileName) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool LoadNodeFromFile(string file_name, int parentNodeID, string nodeLabel, bool cook_on_load, out int newNodeID) {
			newNodeID = default;
			return default;
		} // 0x0000000183D6D7C0-0x0000000183D6D7D0
		public virtual bool GetGeoSize(int nodeID, string format, out int size) {
			size = default;
			return default;
		} // 0x0000000183D6D7E0-0x0000000183D6D7F0
		public virtual bool GetHandleInfo(int nodeID, out HAPI_HandleInfo[] handleInfos, int start, int length) {
			handleInfos = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetHandleBindingInfo(int nodeID, int handleIndex, out HAPI_HandleBindingInfo[] handleBindingInfos, int start, int length) {
			handleBindingInfos = default;
			return default;
		} // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ConvertTransform(ref HAPI_TransformEuler inTransform, HAPI_RSTOrder RSTOrder, HAPI_XYZOrder ROTOrder, out HAPI_TransformEuler outTransform) {
			outTransform = default;
			return default;
		} // 0x0000000183D6D750-0x0000000183D6D770
		public virtual bool GetTotalCookCount(int nodeID, int nodeTypeFilter, int nodeFlagFilter, bool includeChildren, out int count) {
			count = default;
			return default;
		} // 0x0000000183D6D820-0x0000000183D6D830
		public virtual bool SetSessionSync(bool enable) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetViewport(ref HAPI_Viewport viewport) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetViewport(ref HAPI_Viewport viewport) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool GetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool SetNodeDisplay(int node_id, int onOff) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[Serializable]
	public enum SessionConnectionState // TypeDefIndex: 49731
	{
		NOT_CONNECTED = 0,
		CONNECTED = 1,
		FAILED_TO_CONNECT = 2
	}

	[Serializable]
	public enum SessionMode // TypeDefIndex: 49732
	{
		Socket = 0,
		Pipe = 1
	}

	[Serializable]
	public sealed class HEU_SessionData // TypeDefIndex: 49733
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
		private string _sessionClassType; // 0x38
		[SerializeField]
		private bool _isDefaultSession; // 0x40
		[SerializeField]
		private HEU_SessionSyncData _sessionSync; // 0x48
		[SerializeField]
		private SessionConnectionState _connectionState; // 0x50
		[SerializeField]
		private SessionMode _sessionMode; // 0x54
	
		// Properties
		public long SessionID { get => default; set {} } // 0x000000018882CC1C-0x000000018882CC6C 0x0000000183D4EC10-0x0000000183D4EC20
		public int ProcessID { get => default; set {} } // 0x0000000183D5CD90-0x0000000183D5CDA0 0x0000000181003B60-0x0000000181003B70
		public HAPI_SessionType SessionType { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x00000001810410F0-0x0000000181041100
		public bool IsInitialized { get => default; set {} } // 0x000000018115F4C0-0x000000018115F530 0x0000000183D4F0A0-0x0000000183D4F0B0
		public bool IsValidSessionID { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public string PipeName { get => default; set {} } // 0x000000018882CB78-0x000000018882CBA4 0x0000000182C92F10-0x0000000182C92F20
		public int Port { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public System.Type SessionClassType { get => default; set {} } // 0x000000018882CBA4-0x000000018882CC1C 0x000000018882CC6C-0x000000018882CC9C
		public bool IsDefaultSession { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public bool IsSessionSync { get => default; } // 0x0000000185ED8890-0x0000000185ED889C 
		public SessionConnectionState ThisConnectionMode { get => default; set {} } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public SessionMode ThisSessionMode { get => default; set {} } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
	
		// Constructors
		public HEU_SessionData() {} // 0x0000000183D5C2D0-0x0000000183D5C2E0
		static HEU_SessionData() {} // 0x000000018882CB3C-0x000000018882CB78
	
		// Methods
		public HEU_SessionSyncData GetOrCreateSessionSync() => default; // 0x000000018882CACC-0x000000018882CB3C
		public HEU_SessionSyncData GetSessionSync() => default; // 0x0000000183D4EA70-0x0000000183D4EA80
		public void SetSessionSync(HEU_SessionSyncData syncData) {} // 0x0000000182692290-0x00000001826922A0
	}

	public class HEU_SessionHAPI : HEU_SessionBase // TypeDefIndex: 49734
	{
		// Constructors
		public HEU_SessionHAPI() {} // 0x0000000183D6D870-0x0000000183D6D880
	}

	public static class HEU_SessionManager // TypeDefIndex: 49736
	{
		// Fields
		private static HEU_SessionBase _defaultSession; // 0x00
		private static Dictionary<long, HEU_SessionBase> _sessionMap; // 0x08
		public static CreateSessionFromTypeDelegate _createSessionFromTypeDelegate; // 0x10
	
		// Nested types
		public delegate HEU_SessionBase CreateSessionFromTypeDelegate(System.Type type); // TypeDefIndex: 49735; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		static HEU_SessionManager() {} // 0x000000018882ECC0-0x000000018882ED54
	
		// Methods
		public static HEU_SessionBase CreateSessionObject() => default; // 0x000000018882D3E8-0x000000018882D42C
		public static HEU_SessionBase CreateSessionFromType(System.Type type) => default; // 0x000000018882D3A4-0x000000018882D3E8
		public static HEU_SessionBase GetDefaultSession() => default; // 0x000000018882D764-0x000000018882D7D4
		public static void RegisterSession(long sessionID, HEU_SessionBase session) {} // 0x000000018882E9BC-0x000000018882EA40
		public static void UnregisterSession(long sessionID) {} // 0x000000018882EC00-0x000000018882EC78
		public static HEU_SessionBase GetSessionWithID(long sessionID) => default; // 0x000000018882DE94-0x000000018882DF14
		public static void SaveAllSessionData() {} // 0x000000018882EAE4-0x000000018882EB8C
		public static void LoadAllSessionData() {} // 0x000000018882E2AC-0x000000018882E6DC
		private static void InternalValidateSceneAssets() {} // 0x000000018882E124-0x000000018882E230
		public static HEU_SessionBase GetOrCreateDefaultSession(bool bNotifyUserError = true /* Metadata: 0x01FBEB25 */) => default; // 0x000000018882D964-0x000000018882DDF0
		public static bool CreateInProcessSession() => default; // 0x000000018882D324-0x000000018882D3A4
		public static bool CreateThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout, bool logError) => default; // 0x000000018882D4AC-0x000000018882D52C
		public static bool CreateThriftPipeSession(string pipeName, bool autoClose, float timeout, bool logError) => default; // 0x000000018882D42C-0x000000018882D4AC
		public static bool CreateCustomSession() => default; // 0x000000018882D2A4-0x000000018882D324
		public static bool ConnectThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout) => default; // 0x000000018882D224-0x000000018882D2A4
		public static bool ConnectThriftPipeSession(string pipeName, bool autoClose, float timeout) => default; // 0x000000018882D1A4-0x000000018882D224
		public static void RecreateDefaultSessionData() {} // 0x000000018882E958-0x000000018882E9BC
		public static bool ConnectSessionSyncUsingThriftSocket(string hostName, int serverPort, bool autoClose, float timeout, bool logError) => default; // 0x000000018882D128-0x000000018882D1A4
		public static bool ConnectSessionSyncUsingThriftPipe(string pipeName, bool autoClose, float timeout, bool logError) => default; // 0x000000018882D0AC-0x000000018882D128
		public static bool InitializeDefaultSession() => default; // 0x000000018882E0BC-0x000000018882E124
		public static bool CloseDefaultSession() => default; // 0x000000018882D010-0x000000018882D0AC
		public static void CloseAllSessions() {} // 0x000000018882CD6C-0x000000018882D010
		private static void CheckAndCloseExistingSession() {} // 0x000000018882CC9C-0x000000018882CD30
		public static HEU_SessionData GetSessionData() => default; // 0x000000018882DDF0-0x000000018882DE34
		public static string GetSessionInfo() => default; // 0x000000018882DE34-0x000000018882DE94
		public static bool LoadStoredDefaultSession() => default; // 0x000000018882E750-0x000000018882E7C0
		public static bool RestartSession() => default; // 0x000000018882EA40-0x000000018882EAE4
		public static bool ValidatePluginSession(HEU_SessionBase session = null) => default; // 0x000000018882EC78-0x000000018882ECC0
		public static string GetLastSessionError() => default; // 0x000000018882D84C-0x000000018882D8A4
		public static bool CheckVersionMatch() => default; // 0x000000018882CD30-0x000000018882CD6C
		public static bool ClearConnectionError() => default; // 0x000000018232EB60-0x000000018232EB70
		public static string GetConnectionError(bool clear) => default; // 0x000000018882D6F4-0x000000018882D720
		public static bool IsHARSProcessRunning(int processID) => default; // 0x000000018882E230-0x000000018882E2AC
		public static bool LoadSessionFromHIP(bool bCookNodes, HEU_SessionBase session = null) => default; // 0x000000018882E6DC-0x000000018882E750
		public static bool SaveSessionToHIP(bool bLockNodes, HEU_SessionBase session = null) => default; // 0x000000018882EB8C-0x000000018882EC00
		public static string GetHoudiniPathOnMacOS(string houdiniPath) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static bool OpenHoudini(string args) => default; // 0x000000018882E7C0-0x000000018882E874
		public static bool OpenSessionInHoudini(HEU_SessionBase session = null) => default; // 0x000000018882E874-0x000000018882E958
		public static HAPI_License GetCurrentLicense(bool bLogError) => default; // 0x000000018882D720-0x000000018882D764
		public static string GetString(int stringHandle, HEU_SessionBase session = null) => default; // 0x000000018882DFEC-0x000000018882E054
		public static string[] GetStringValuesFromStringIndices(int[] strIndices) => default; // 0x000000018882DF14-0x000000018882DFEC
		public static string[] GetGroupNames(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, bool isInstanced) => default; // 0x000000018882D80C-0x000000018882D84C
		public static bool GetGroupMembership(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref int[] membership, bool isInstanced) => default; // 0x000000018882D7D4-0x000000018882D80C
		public static string GetNodeName(int nodeID, HEU_SessionBase session = null) => default; // 0x000000018882D904-0x000000018882D964
		public static bool GetNodeInputName(int nodeID, int inputIndex, out string inputName) {
			inputName = default;
			return default;
		} // 0x000000018882D8A4-0x000000018882D904
		public static bool GetComposedChildNodeList(HEU_SessionBase session, int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, out int[] childNodeIDs, bool bLogIfError = true /* Metadata: 0x01FBEB26 */) {
			childNodeIDs = default;
			return default;
		} // 0x000000018882D52C-0x000000018882D578
		public static bool GetComposedObjectListMemorySafe(HEU_SessionBase session, int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length) {
			objectInfos = default;
			return default;
		} // 0x000000018882D578-0x000000018882D634
		public static bool GetComposedObjectTransformsMemorySafe(HEU_SessionBase session, int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length) {
			transforms = default;
			return default;
		} // 0x000000018882D634-0x000000018882D6F4
		public static string GetUniqueMaterialShopName(int assetID, int materialID) => default; // 0x000000018882E054-0x000000018882E0BC
	}

	public static class HEU_SessionPDG // TypeDefIndex: 49737
	{
	}

	[Serializable]
	public class HEU_SessionSyncData // TypeDefIndex: 49739
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
		public Status SyncStatus { get => default; set {} } // 0x000000018882EE0C-0x000000018882EE1C 0x0000000183D6D880-0x0000000183D6D890
	
		// Nested types
		public enum Status // TypeDefIndex: 49738
		{
			Stopped = 0,
			Started = 1,
			Connecting = 2,
			Initializing = 3,
			Connected = 4
		}
	
		// Constructors
		public HEU_SessionSyncData() {} // 0x000000018882ED54-0x000000018882EE0C
	}

	public class HEU_AssetSync : HEU_BaseSync // TypeDefIndex: 49741
	{
		// Fields
		public AssetSyncCallback _onAssetLoaded; // 0x88
		public string _assetPath; // 0x90
	
		// Nested types
		public delegate void AssetSyncCallback(HEU_AssetSync assetSync); // TypeDefIndex: 49740; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public HEU_AssetSync() {} // 0x00000001888208E4-0x00000001888208EC
	
		// Methods
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		private new void OnDestroy() {} // 0x00000001888207A8-0x00000001888207B0
		public void InitializeAsset(HEU_SessionBase session, string assetPath, string nodeName, Transform parent, Vector3 startPosition) {} // 0x00000001888206D0-0x00000001888207A8
		private HEU_ThreadedTaskLoadGeo CreateThreadedTask() => default; // 0x0000000188820674-0x00000001888206D0
		public void SetLoadCallback(HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback) {} // 0x0000000188820818-0x000000018882086C
		protected override void SetupLoadTask(HEU_SessionBase session) {} // 0x000000018882086C-0x00000001888208E4
		public override void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x00000001888207B0-0x00000001888207EC
		public override void Resync() {} // 0x00000001888207EC-0x0000000188820818
	}

	public class HEU_SyncedEventData // TypeDefIndex: 49742
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_ThreadedTaskLoadGeo.HEU_LoadData TopNodeData; // 0x18
		public HEU_BaseSync OutputObject; // 0x20
	
		// Constructors
		public HEU_SyncedEventData() {} // Dummy constructor
		public HEU_SyncedEventData(bool bSuccess, HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HEU_BaseSync bOutputObject) {} // 0x000000018882EE1C-0x000000018882EE44
	}

	[ExecuteInEditMode]
	public class HEU_BaseSync : MonoBehaviour // TypeDefIndex: 49743
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
		public Action<HEU_SyncedEventData> OnSynced { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
	
		// Constructors
		public HEU_BaseSync() {} // 0x0000000188824FE8-0x0000000188825170
	
		// Methods
		private void Awake() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x00000001888207A8-0x00000001888207B0
		public virtual void DeleteSessionData() {} // 0x000000018882189C-0x00000001888218C0
		public virtual void DestroyGeneratedData() {} // 0x00000001888218C0-0x00000001888218C8
		protected virtual void Initialize() {} // 0x0000000183D6D6C0-0x0000000183D6D6D0
		public virtual HEU_SessionBase GetHoudiniSession(bool bCreateIfNotFound) => default; // 0x00000001888247E4-0x000000018882488C
		private int GetParentNodeID(HEU_SessionBase session) => default; // 0x00000001888248E8-0x0000000188824904
		public void Log(string msg) {} // 0x0000000188824918-0x00000001888249DC
		public void ClearLog() {} // 0x00000001888214FC-0x0000000188821718
		public void Error(string error) {} // 0x0000000188821B08-0x0000000188821B28
		public bool IsLoaded() => default; // 0x0000000188824904-0x0000000188824918
		public virtual void StartSync() {} // 0x0000000188824E54-0x0000000188824F18
		protected virtual void SetupLoadTask(HEU_SessionBase session) {} // 0x000000018350B670-0x000000018350B680
		public virtual void StopSync() {} // 0x0000000188824F18-0x0000000188824F74
		public virtual void Resync() {} // 0x0000000188824C48-0x0000000188824C74
		public virtual void Bake() {} // 0x00000001888211C4-0x00000001888214FC
		public virtual void Unload() {} // 0x0000000188824F74-0x0000000188824FE8
		public virtual void Reset() {} // 0x0000000188824B9C-0x0000000188824C48
		public virtual void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x00000001888249DC-0x0000000188824AE0
		public virtual void GenerateObjects(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x00000001888233E0-0x0000000188823460
		public virtual void GenerateGeometry(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, int objIndex) {} // 0x0000000188821BD8-0x0000000188821CE0
		public void OnStopped(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x0000000188824AE0-0x0000000188824B9C
		private void GenerateTerrain(int cookNodeId, List<HEU_LoadBufferVolume> terrainBuffers) {} // 0x0000000188823460-0x00000001888247E4
		private void GenerateMesh(int cookNodeId, List<HEU_LoadBufferMesh> meshBuffers) {} // 0x0000000188822E48-0x00000001888233E0
		private void GenerateAllInstancers(int cookNodeId, List<HEU_LoadBufferInstancer> instancerBuffers, HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x0000000188821B28-0x0000000188821BD8
		private void GenerateInstancer(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap) {} // 0x0000000188821CE0-0x0000000188821F78
		private void GenerateInstancesFromNodeIDs(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap, Transform instanceRootTransform) {} // 0x00000001888227B0-0x0000000188822E48
		private void GenerateInstancesFromAssetPaths(HEU_LoadBufferInstancer instancerBuffer, Transform instanceRootTransform) {} // 0x0000000188821F78-0x00000001888227B0
		private void CreateNewInstanceFromObject(GameObject assetSourceGO, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, string[] instancePrefixes, string instanceName, GameObject collisionSourceGO) {} // 0x0000000188821718-0x000000018882189C
		private void ApplyAttributeModifiersOnGameObjectOutput(HEU_SessionBase session, int geoID, int partId, ref GameObject go) {} // 0x000000018882114C-0x00000001888211C4
		private void DestroyOutputs() {} // 0x00000001888218C8-0x0000000188821B08
		private void SetOutputVisiblity(HEU_LoadBufferBase buffer) {} // 0x0000000188824C74-0x0000000188824E54
		private string GetOutputCacheDirectory() => default; // 0x000000018882488C-0x00000001888248E8
		public void SetOutputCacheDirectory(string directory) {} // 0x0000000183CB2D80-0x0000000183CB2D90
		private void AddGeneratedOutputFilePath(string path) {} // 0x00000001888210C4-0x000000018882114C
		public virtual void SyncUpdate() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public struct HEU_GenerateOptions // TypeDefIndex: 49744
	{
		// Fields
		public bool _generateUVs; // 0x00
		public bool _generateTangents; // 0x01
		public bool _generateNormals; // 0x02
		public bool _useLODGroups; // 0x03
		public bool _splitPoints; // 0x04
	}

	public class HEU_GeoSync : HEU_BaseSync // TypeDefIndex: 49745
	{
		// Fields
		public string _filePath; // 0x88
	
		// Constructors
		public HEU_GeoSync() {} // 0x0000000188825224-0x0000000188825274
	
		// Methods
		protected override void SetupLoadTask(HEU_SessionBase session) {} // 0x0000000188825170-0x0000000188825224
	}

	public class HEU_NodeSync : HEU_BaseSync // TypeDefIndex: 49746
	{
		// Fields
		public string _nodeSaveFilePath; // 0x88
	
		// Constructors
		public HEU_NodeSync() {} // 0x00000001888208E4-0x00000001888208EC
	
		// Methods
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		private new void OnDestroy() {} // 0x00000001888207A8-0x00000001888207B0
		public void InitializeFromHoudini(HEU_SessionBase session, int nodeID, string nodeName, string filePath) {} // 0x0000000188827BC4-0x0000000188827C4C
		protected override void SetupLoadTask(HEU_SessionBase session) {} // 0x0000000188827CC8-0x0000000188827D78
		public bool SaveNodeToFile(string filePath) => default; // 0x0000000188827C4C-0x0000000188827CC8
		public static void CreateNodeSync(HEU_SessionBase session, string opName, string nodeNabel) {} // 0x0000000188827B20-0x0000000188827BC4
		public override void Resync() {} // 0x00000001888207EC-0x0000000188820818
		public override void SyncUpdate() {} // 0x0000000188827D78-0x0000000188827DBC
	}

	public abstract class HEU_Task // TypeDefIndex: 49750
	{
		// Fields
		public TaskStatus _status; // 0x10
		public TaskResult _result; // 0x14
		private Guid _guid; // 0x18
		public TaskCallback _taskCompletedDelegate; // 0x28
	
		// Properties
		public Guid TaskGuid { get; } // 0x0000000183D51D80-0x0000000183D51D90 
	
		// Nested types
		public enum TaskStatus // TypeDefIndex: 49747
		{
			NONE = 0,
			PENDING_START = 1,
			STARTED = 2,
			REQUIRE_UPDATE = 3,
			PENDING_COMPLETE = 4,
			COMPLETED = 5,
			UNUSED = 6
		}
	
		public enum TaskResult // TypeDefIndex: 49748
		{
			NONE = 0,
			SUCCESS = 1,
			FAILED = 2,
			KILLED = 3
		}
	
		public delegate void TaskCallback(HEU_Task task); // TypeDefIndex: 49749; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public HEU_Task() {} // 0x000000018882F754-0x000000018882F778
	
		// Methods
		public abstract void DoTask();
		public virtual void UpdateTask() {} // 0x000000018350B670-0x000000018350B680
		public abstract void KillTask();
		public abstract void CompleteTask(TaskResult result);
	}

	public class HEU_AssetTask : HEU_Task // TypeDefIndex: 49752
	{
		// Fields
		public BuildType _buildType; // 0x30
		public HEU_HoudiniAsset _asset; // 0x38
		public string _assetPath; // 0x40
		public Vector3 _position; // 0x48
		public bool _buildResult; // 0x54
		public long _forceSessionID; // 0x58
	
		// Nested types
		public enum BuildType // TypeDefIndex: 49751
		{
			NONE = 0,
			LOAD = 1,
			COOK = 2,
			RELOAD = 3
		}
	
		// Constructors
		public HEU_AssetTask() {} // 0x0000000188821054-0x00000001888210C4
	
		// Methods
		public HEU_SessionBase GetTaskSession() => default; // 0x0000000188820E68-0x0000000188820EF8
		public override void DoTask() {} // 0x0000000188820ACC-0x0000000188820E68
		public override void KillTask() {} // 0x0000000188820EF8-0x0000000188821054
		public override void CompleteTask(TaskResult result) {} // 0x00000001888208EC-0x0000000188820A48
		private void CookCompletedCallback(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> outputs) {} // 0x0000000188820A70-0x0000000188820ACC
		private void CookCompletedCallback(HEU_CookedEventData cookedEventData) {} // 0x0000000188820A48-0x0000000188820A70
		private void CookCompletedCallback(HEU_ReloadEventData reloadEventData) {} // 0x0000000188820A48-0x0000000188820A70
	}

	public class HEU_TaskManager // TypeDefIndex: 49753
	{
		// Fields
		private static List<HEU_Task> _tasks; // 0x00
		private static List<HEU_Task> _pendingAdd; // 0x08
		private static List<HEU_Task> _pendingRemove; // 0x10
	
		// Constructors
		static HEU_TaskManager() {} // 0x000000018882F628-0x000000018882F754
		public HEU_TaskManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static void Update() {} // 0x000000018350B670-0x000000018350B680
		public static HEU_Task GetTask(Guid taskGuid) => default; // 0x000000018882F238-0x000000018882F3B0
		public static void AddTask(HEU_Task task) {} // 0x000000018882F0E8-0x000000018882F1E0
		public static void KillTask(HEU_Task task, bool bRemove) {} // 0x000000018882F400-0x000000018882F4C0
		public static void KillTask(Guid taskGuid, bool bRemove) {} // 0x000000018882F4C0-0x000000018882F53C
		public static void RemoveTask(HEU_Task task) {} // 0x000000018882F53C-0x000000018882F628
		public static void ExecuteTask(HEU_Task task) {} // 0x000000018882F204-0x000000018882F238
		public static void CompleteTask(HEU_Task task, HEU_Task.TaskResult result) {} // 0x000000018882F1E0-0x000000018882F204
		private static void InternalCompleteTask(HEU_Task task) {} // 0x000000018882F3B0-0x000000018882F400
	}

	public class HEU_LoadBufferBase // TypeDefIndex: 49754
	{
		// Fields
		public int _id; // 0x10
		public string _name; // 0x18
		public bool _bInstanced; // 0x20
		public bool _bInstancer; // 0x21
		public HEU_GeneratedOutput _generatedOutput; // 0x28
	
		// Constructors
		public HEU_LoadBufferBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void InitializeBuffer(int id, string name, bool bInstanced, bool bInstancer) {} // 0x000000018883F828-0x000000018883F854
	}

	public class HEU_LoadBufferMesh : HEU_LoadBufferBase // TypeDefIndex: 49755
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
		public HEU_LoadBufferMesh() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HEU_LoadBufferVolume : HEU_LoadBufferBase // TypeDefIndex: 49756
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
		public HEU_LoadBufferVolume() {} // 0x000000018883F88C-0x000000018883F9A4
	}

	public class HEU_LoadBufferVolumeLayer // TypeDefIndex: 49757
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
		public HEU_LoadBufferVolumeLayer() {} // 0x000000018883F854-0x000000018883F88C
	}

	public class HEU_LoadBufferInstancer : HEU_LoadBufferBase // TypeDefIndex: 49758
	{
		// Fields
		public HAPI_Transform[] _instanceTransforms; // 0x30
		public string[] _instancePrefixes; // 0x38
		public int[] _instanceNodeIDs; // 0x40
		public string[] _assetPaths; // 0x48
		public string[] _collisionAssetPaths; // 0x50
	
		// Constructors
		public HEU_LoadBufferInstancer() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HEU_ThreadedTask // TypeDefIndex: 49759
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
		public string TaskName { get => default; } // 0x0000000181003830-0x0000000181003840 
		public bool IsComplete { get => default; set {} } // 0x00000001888447DC-0x0000000188844888 0x00000001888449E0-0x0000000188844A8C
		public bool IsActive { get => default; set {} } // 0x0000000188844730-0x00000001888447DC 0x0000000188844934-0x00000001888449E0
		public bool StopRequested { get => default; set {} } // 0x0000000188844888-0x0000000188844934 0x0000000188844A8C-0x0000000188844B38
		public System.Threading.ThreadPriority Priority { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public bool IsBackground { get => default; set {} } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
	
		// Constructors
		public HEU_ThreadedTask() {} // 0x00000001888446DC-0x0000000188844730
	
		// Methods
		public virtual void Start() {} // 0x00000001888444F4-0x0000000188844644
		public virtual void Stop() {} // 0x0000000188844644-0x0000000188844684
		public virtual void Abort() {} // 0x0000000188844404-0x0000000188844434
		public virtual void Reset() {} // 0x0000000188844434-0x00000001888444CC
		public virtual void Update() {} // 0x0000000188844684-0x00000001888446DC
		protected virtual void DoWork() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnComplete() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnStopped() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void CleanUp() {} // 0x000000018350B670-0x000000018350B680
		private void Run() {} // 0x00000001888444CC-0x00000001888444F4
	}

	public class HEU_ThreadedTaskLoadGeo : HEU_ThreadedTask // TypeDefIndex: 49766
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
		public enum LoadType // TypeDefIndex: 49760
		{
			FILE = 0,
			NODE = 1,
			ASSET = 2
		}
	
		public class HEU_LoadData // TypeDefIndex: 49762
		{
			// Fields
			public int _cookNodeID; // 0x10
			public LoadStatus _loadStatus; // 0x14
			public StringBuilder _logStr; // 0x18
			public HEU_SessionBase _session; // 0x20
			public List<HEU_LoadObject> _loadedObjects; // 0x28
			public Dictionary<int, HEU_LoadBufferBase> _idBuffersMap; // 0x30
	
			// Nested types
			public enum LoadStatus // TypeDefIndex: 49761
			{
				NONE = 0,
				STARTED = 1,
				SUCCESS = 2,
				ERROR = 3
			}
	
			// Constructors
			public HEU_LoadData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class HEU_LoadObject // TypeDefIndex: 49763
		{
			// Fields
			public int _objectNodeID; // 0x10
			public int _displayNodeID; // 0x14
			public List<HEU_LoadBufferVolume> _terrainBuffers; // 0x18
			public List<HEU_LoadBufferMesh> _meshBuffers; // 0x20
			public List<HEU_LoadBufferInstancer> _instancerBuffers; // 0x28
	
			// Constructors
			public HEU_LoadObject() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public enum HEU_LoadCallbackType // TypeDefIndex: 49764
		{
			PRECOOK = 0,
			POSTCOOK = 1
		}
	
		public delegate void HEU_LoadCallback(HEU_SessionBase session, HEU_LoadData loadData, HEU_LoadCallbackType callbackType); // TypeDefIndex: 49765; 0x00000001811360D0-0x00000001811360F0
	
		// Constructors
		public HEU_ThreadedTaskLoadGeo() {} // 0x00000001888443BC-0x0000000188844404
	
		// Methods
		public void SetupLoad(HEU_SessionBase session, HEU_BaseSync ownerSync, LoadType loadType, int cookNodeID, string name, string filePath) {} // 0x0000000188844268-0x00000001888443B0
		public void SetupLoadNode(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string name) {} // 0x0000000188844238-0x0000000188844268
		public void SetupLoadFile(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string filePath) {} // 0x0000000188844208-0x0000000188844238
		public void SetupLoadAsset(HEU_SessionBase session, HEU_BaseSync ownerSync, string assetPath, string name) {} // 0x00000001888441D4-0x0000000188844208
		public void SetLoadCallback(HEU_LoadCallback loadCallback) {} // 0x000000018519C3C8-0x000000018519C3D8
		protected override void DoWork() {} // 0x0000000188840A58-0x0000000188840AF8
		protected virtual bool CookNode(HEU_SessionBase session, int cookNodeID) => default; // 0x0000000188840680-0x000000018884070C
		protected virtual bool LoadObjectBuffers(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo) => default; // 0x0000000188843CC4-0x0000000188843D18
		protected virtual bool LoadNodeBuffer(HEU_SessionBase session, int nodeID, HEU_LoadObject loadObject) => default; // 0x00000001888439D4-0x0000000188843CC4
		protected virtual void BuildBufferIDsMap(HEU_LoadData loadData) {} // 0x0000000188840140-0x0000000188840680
		public virtual bool DoFileLoad() => default; // 0x00000001888408F0-0x0000000188840A58
		public virtual bool DoAssetLoad() => default; // 0x00000001888407F0-0x00000001888408F0
		private bool QueryParts(int nodeID, ref List<HAPI_PartInfo> meshParts, ref List<HAPI_PartInfo> volumeParts, ref List<HAPI_PartInfo> instancerParts, ref List<HAPI_PartInfo> curveParts, ref List<HAPI_PartInfo> scatterInstancerParts) => default; // 0x0000000188843E98-0x0000000188843F1C
		protected override void OnComplete() {} // 0x0000000188843DA0-0x0000000188843E28
		protected override void OnStopped() {} // 0x0000000188843E28-0x0000000188843E98
		protected override void CleanUp() {} // 0x0000000188582664-0x0000000188582678
		private string CreateLogString(HEU_LoadData.LoadStatus status, string logStr) => default; // 0x0000000188840764-0x00000001888407F0
		private void AppendLog(HEU_LoadData.LoadStatus status, string logStr) {} // 0x0000000188840018-0x0000000188840140
		private void SetLog(HEU_LoadData.LoadStatus status, string logStr) {} // 0x0000000188843F58-0x00000001888441D4
		private bool CreateFileNode(out int fileNodeID) {
			fileNodeID = default;
			return default;
		} // 0x000000018884070C-0x0000000188840764
		public virtual int GetCookNodeID() => default; // 0x0000000188843524-0x0000000188843540
		private int GetDisplayNodeID(int objNodeID) => default; // 0x0000000188843540-0x000000018884355C
		private bool SetFileParm(int fileNodeID, string filePath) => default; // 0x0000000188843F1C-0x0000000188843F58
		private void Sleep() {} // 0x00000001888443B0-0x00000001888443BC
		public bool GenerateTerrainBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> volumeParts, List<HAPI_PartInfo> scatterInstancerParts, out List<HEU_LoadBufferVolume> volumeBuffers) {
			volumeBuffers = default;
			return default;
		} // 0x0000000188841958-0x0000000188843524
		private void LoadStringFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref string strValue) {} // 0x0000000188843D18-0x0000000188843DA0
		private void LoadFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue) {} // 0x0000000188843684-0x0000000188843774
		private void LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue) {} // 0x0000000188843774-0x00000001888438C4
		private void LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue) {} // 0x00000001888438C4-0x00000001888439D4
		public bool GenerateMeshBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> meshParts, bool bSplitPoints, bool bUseLODGroups, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, HEU_LoadObject loadObject, out List<HEU_LoadBufferMesh> meshBuffers) {
			meshBuffers = default;
			return default;
		} // 0x0000000188840E98-0x0000000188841538
		public bool GenerateInstancerBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> instancerParts, out List<HEU_LoadBufferInstancer> instancerBuffers) {
			instancerBuffers = default;
			return default;
		} // 0x0000000188840AF8-0x0000000188840E98
		private HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo) => default; // 0x0000000188841538-0x0000000188841810
		private HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo) => default; // 0x0000000188841810-0x0000000188841958
		public static HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(int tileIndex, List<HEU_LoadBufferVolume> buffers) => default; // 0x000000018884355C-0x0000000188843678
		public static string GetValidAssetCacheFolderPath(string name) => default; // 0x0000000188843678-0x0000000188843684
	}

	public class HEU_ThreadManager // TypeDefIndex: 49767
	{
		// Fields
		private static HEU_ThreadManager _instance; // 0x00
		private List<HEU_ThreadedTask> _tasks; // 0x10
		private List<HEU_ThreadedTask> _pendingAdd; // 0x18
		private List<HEU_ThreadedTask> _pendingRemove; // 0x20
	
		// Properties
		public static HEU_ThreadManager Instance { get => default; } // 0x000000018883FFE0-0x0000000188840018 
	
		// Constructors
		public HEU_ThreadManager() {} // 0x000000018883FF04-0x000000018883FFE0
	
		// Methods
		private static void CreateInstance() {} // 0x000000018350B670-0x000000018350B680
		~HEU_ThreadManager() {} // 0x000000018883FAC8-0x000000018883FB18
		public void Register() {} // 0x000000018350B670-0x000000018350B680
		public void Unregister() {} // 0x000000018350B670-0x000000018350B680
		public void Update() {} // 0x000000018883FBB4-0x000000018883FF04
		public void AddTask(HEU_ThreadedTask task) {} // 0x000000018883FA2C-0x000000018883FAC8
		public void RemoveTask(HEU_ThreadedTask task) {} // 0x000000018883FB18-0x000000018883FBB4
	}

	public class HEU_CookLogs // TypeDefIndex: 49768
	{
		// Fields
		private static HEU_CookLogs _instance; // 0x00
		private StringBuilder _cookLogs; // 0x10
		private int _currentCookLogCount; // 0x18
		private const int MAX_COOK_LOG_COUNT = 9001; // Metadata: 0x01FBEB45
		private string _lastLogStr; // 0x20
		private bool _uniqueStrOnly; // 0x28
		public const long MaxLogSize = 50000000; // Metadata: 0x01FBEB49
	
		// Properties
		public static HEU_CookLogs Instance { get => default; } // 0x000000018882FF04-0x000000018882FF94 
	
		// Constructors
		public HEU_CookLogs() {} // 0x000000018882FE78-0x000000018882FF04
	
		// Methods
		public string GetCookLogString() => default; // 0x0000000187ABAEF4-0x0000000187ABAF18
		public void AppendCookLog(string logStr) {} // 0x000000018882F954-0x000000018882FA70
		public void ClearCookLog() {} // 0x000000018882FA70-0x000000018882FADC
		public string GetCookLogFilePath() => default; // 0x000000018882FB64-0x000000018882FC14
		public void DeleteCookingFile() {} // 0x000000018882FADC-0x000000018882FB64
		public void WriteToLogFile(string logStr, bool checkLastLogStr = true /* Metadata: 0x01FBEB44 */) {} // 0x000000018882FC9C-0x000000018882FE78
		public long GetFileSizeOfLogFile() => default; // 0x000000018882FC14-0x000000018882FC9C
	}

	public static class HEU_EditorUtility // TypeDefIndex: 49770
	{
		// Nested types
		public enum HEU_ReplacePrefabOptions // TypeDefIndex: 49769
		{
			Default = 0,
			ConnectToPrefab = 1,
			ReplaceNameBased = 2
		}
	
		// Methods
		public static void MarkSceneDirty() {} // 0x000000018350B670-0x000000018350B680
		public static void SelectObject(GameObject gameObject) {} // 0x000000018350B670-0x000000018350B680
		public static void SelectObjects(GameObject[] gameObjects) {} // 0x000000018350B670-0x000000018350B680
		public static Vector3 GetSelectedObjectsMeanPosition() => default; // 0x0000000184274B08-0x0000000184274B20
		public static Matrix4x4 GetSelectedObjectsMeanTransform() => default; // 0x00000001888307E8-0x0000000188830824
		public static GameObject SaveAsPrefabAsset(string path, GameObject go) => default; // 0x0000000188830AF8-0x0000000188830B30
		public static bool PrefabIsAddedComponentOverride(Component comp) => default; // 0x000000018115F4C0-0x000000018115F530
		public static bool IsEditorPlaying() => default; // 0x000000018115F4C0-0x000000018115F530
		public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab, HEU_ReplacePrefabOptions heuOptions) => default; // 0x0000000188830AC0-0x0000000188830AF8
		public static bool IsPrefabInstance(GameObject go) => default; // 0x00000001888309AC-0x00000001888309E4
		public static bool IsPrefabAsset(GameObject go) => default; // 0x0000000188830974-0x00000001888309AC
		public static bool IsEditingInPrefabMode(GameObject obj) => default; // 0x000000018115F4C0-0x000000018115F530
		public static bool IsDisconnectedPrefabInstance(GameObject go) => default; // 0x0000000188830904-0x000000018883093C
		public static UnityEngine.Object GetPrefabAsset(GameObject go) => default; // 0x0000000188830738-0x0000000188830770
		public static string GetPrefabAssetPath(UnityEngine.Object obj) => default; // 0x0000000188830700-0x0000000188830738
		public static void DisconnectPrefabInstance(GameObject instance) {} // 0x00000001888301CC-0x0000000188830200
		public static UnityEngine.Object InstantiatePrefab(GameObject prefabOriginal) => default; // 0x00000001888308CC-0x0000000188830904
		public static GameObject InstantiateGameObject(GameObject sourceGameObject, Transform parentTransform, bool instantiateInWorldSpace, bool bRegisterUndo) => default; // 0x000000018883085C-0x00000001888308CC
		public static Component AddComponent<T>(GameObject target, bool bRegisterUndo) => default;
		public static void UndoRecordObject(UnityEngine.Object objectToUndo, string name) {} // 0x000000018350B670-0x000000018350B680
		public static void UndoCollapseCurrentGroup() {} // 0x000000018350B670-0x000000018350B680
		public static UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj) => default; // 0x00000001888300B8-0x00000001888300F0
		public static bool IsPersistant(UnityEngine.Object obj) => default; // 0x000000018883093C-0x0000000188830974
		public static string GetUniqueNameForSibling(Transform parentTransform, string name) => default; // 0x0000000188830824-0x000000018883085C
		public static void DisplayProgressBar(string title, string info, float progress) {} // 0x00000001888302C8-0x00000001888302FC
		public static void ClearProgressBar() {} // 0x0000000188830084-0x00000001888300B8
		public static bool IsEditorNotInPlayModeAndNotGoingToPlayMode() => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		public static bool DisplayDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x01FBEB51 */) => default; // 0x0000000188830200-0x0000000188830258
		public static bool DisplayErrorDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x01FBEB52 */) => default; // 0x0000000188830258-0x00000001888302C8
		public static void RevealInFinder(string path) {} // 0x000000018350B670-0x000000018350B680
		public static void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj) {} // 0x000000018350B670-0x000000018350B680
		public static void SetStatic(GameObject go, bool bStatic, bool bIncludeChildren) {} // 0x000000018350B670-0x000000018350B680
		public static void SetIsHidden(GameObject go, bool isHidden, bool bIncludeChildren) {} // 0x000000018350B670-0x000000018350B680
		public static GameObject[] GetSelectedObjects() => default; // 0x0000000181002730-0x0000000181002740
		public static HEU_HoudiniAssetRoot[] GetSelectedAssetRoots() => default; // 0x0000000188830770-0x00000001888307E8
		public static HEU_HoudiniAssetRoot[] GetAllAssetRoots() => default; // 0x0000000188830654-0x00000001888306A8
		public static void CookSelected() {} // 0x00000001888301B0-0x00000001888301CC
		public static void CookAll() {} // 0x00000001888300F0-0x000000018883010C
		public static void CookAssets(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x000000018883010C-0x00000001888301B0
		public static void RebuildSelected() {} // 0x0000000188830AA4-0x0000000188830AC0
		public static void RebuildAll() {} // 0x00000001888309E4-0x0000000188830A00
		public static void RebuildAssets(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x0000000188830A00-0x0000000188830AA4
		public static void BakeAndReplaceSelectedInScene() {} // 0x0000000188830068-0x0000000188830084
		public static void BakeAndReplaceAllInScene() {} // 0x000000018882FF94-0x000000018882FFB0
		public static void BakeAndReplaceAssets(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x000000018882FFB0-0x0000000188830068
		public static void ExportSelectedAssetsToGeoFiles() {} // 0x0000000188830638-0x0000000188830654
		public static void ExportAllAssetsToGeoFiles() {} // 0x0000000188830334-0x0000000188830350
		public static void ExportAssetsToGeoFiles(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x0000000188830350-0x0000000188830638
		public static string EditorSaveFolderPanel(string title, string folder, string defaultName) => default; // 0x00000001888302FC-0x0000000188830334
		public static void QuerySelectedMeshTopology() {} // 0x000000018350B670-0x000000018350B680
		public static string GetObjectParentFolder(GameObject parentObject, HashSet<Material> generatedMaterials) => default; // 0x00000001888306D4-0x0000000188830700
		private static string GetObjectParentFolderHelper(int instanceID) => default; // 0x00000001888306A8-0x00000001888306D4
		public static void RepaintScene() {} // 0x000000018350B670-0x000000018350B680
		public static void SetTextureToNormalMap(string filename) {} // 0x000000018350B670-0x000000018350B680
		public static bool ReleasedMouse() => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public static class HEU_Extensions // TypeDefIndex: 49771
	{
		// Extension methods
		public static List<R> Map<T, R>(this IEnumerable<T> self, Func<T, R> selector) => default;
		public static T Reduce<T>(this IEnumerable<T> self, Func<T, T, T> func) => default;
		public static List<T> Filter<T>(this IEnumerable<T> self, Func<T, bool> predicate) => default;
		public static bool IsValidIndex<T>(this List<T> self, int index) => default;
		public static bool IsEquivalentList<T>(this List<T> self, List<T> other) => default;
		public static bool ApproximatelyEquals(this Quaternion quatA, Quaternion value) => default; // 0x0000000188830B30-0x0000000188830B7C
		public static List<U> ConvertList<T, U>(this List<T> self) => default;
		public static List<IEquivable<T>> ConvertListToEquivable<T>(this List<T> self) => default;
		public static IEquivable<T>[] ConvertArrayToEquivable<T>(this T[] self) => default;
		public static bool ApproximatelyEquals(this float self, float other, float epsilon = 1E-06f /* Metadata: 0x01FBEB56 */) => default; // 0x0000000185717BC8-0x0000000185717BDC
		public static byte[] AsByteArray(this string self) => default; // 0x0000000188830B7C-0x0000000188830BE8
		public static string AsString(this byte[] buffer) => default; // 0x0000000188830BE8-0x0000000188830C4C
		public static Vector3 SwapXAndY(this Vector3 self) => default; // 0x0000000183D6D8A0-0x0000000183D6D8D0
		public static Vector3 SwapXAndZ(this Vector3 self) => default; // 0x0000000183D6D8D0-0x0000000183D6D8F0
		public static Vector3 SwapYAndZ(this Vector3 self) => default; // 0x0000000183D6D8F0-0x0000000183D6D920
		public static Vector3 DecomposeToPosition(this Matrix4x4 self) => default; // 0x00000001888092B0-0x00000001888092FC
		public static Quaternion DecomposeToRotation(this Matrix4x4 self) => default; // 0x0000000188830C4C-0x0000000188830D14
		public static Vector3 DecomposeToScale(this Matrix4x4 self) => default; // 0x0000000188830D14-0x0000000188830DCC
	}

	public static class ArrayExtensions // TypeDefIndex: 49772
	{
		// Extension methods
		public static void Init<T>(this T[] array, T defaultValue) {}
		public static void Init<T>(this List<T> array, T defaultValue) {}
		public static void CopyToWithResize<T>(this T[] srcArray, ref ref T[] destArray) {}
		public static bool IsEquivalentArray<T>(this T[] arr, T[] other) => default;
		public static bool IsNull<T>(this T[] arr) => default;
	}

	public static class DictionaryExtensions // TypeDefIndex: 49773
	{
		// Extension methods
		public static void AddOrSet<T, U>(this Dictionary<T, U> dict, T key, U value) {}
	}

	public struct TransformData // TypeDefIndex: 49774
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 localPosition; // 0x1C
		public Vector3 localScale; // 0x28
		public Quaternion localRotation; // 0x34
		public Transform parent; // 0x48
	
		// Constructors
		public TransformData(Transform other) {
			position = default;
			rotation = default;
			localPosition = default;
			localScale = default;
			localRotation = default;
			parent = default;
		} // 0x0000000188844CFC-0x0000000188844DC4
	
		// Methods
		public void CopyTo(Transform other, bool copyParent) {} // 0x0000000188844C58-0x0000000188844CFC
		public void CopyToLocal(Transform other, bool copyParent) {} // 0x0000000188844BB0-0x0000000188844C58
	}

	public class HEU_GeneralUtility // TypeDefIndex: 49780
	{
		// Nested types
		public delegate bool GetArray1ArgDel<T>(int arg1, out T[] data, int start, int length); // TypeDefIndex: 49775; 0x00000000-0x00000000
	
		public delegate bool GetArray2ArgDel<ARG2, T>(int arg1, ARG2 arg2, out T[] data, int start, int length); // TypeDefIndex: 49776; 0x00000000-0x00000000
	
		public delegate bool GetArray3ArgDel<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, out T[] data, int start, int length); // TypeDefIndex: 49777; 0x00000000-0x00000000
	
		public delegate bool GetAttributeArrayInputFunc<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, out T[] items, int start, int end); // TypeDefIndex: 49778; 0x00000000-0x00000000
	
		public delegate bool SetAttributeArrayFunc<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, int start, int end); // TypeDefIndex: 49779; 0x00000000-0x00000000
	
		// Constructors
		public HEU_GeneralUtility() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool GetArray1Arg<T>(int arg1, GetArray1ArgDel<T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		}
		public static bool GetArray2Arg<ARG2, T>(int arg1, ARG2 arg2, GetArray2ArgDel<ARG2, T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		}
		public static bool GetArray3Arg<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, GetArray3ArgDel<ARG3, ARG2, T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		}
		private static bool GetArray<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, GetArray1ArgDel<T> func1, GetArray2ArgDel<ARG2, T> func2, GetArray3ArgDel<ARG3, ARG2, T> func3, out T[] data, int start, int count, int tupleSize) {
			data = default;
			return default;
		}
		public static bool SetArray1Arg<T>(int arg1, GetArray1ArgDel<T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		}
		public static bool SetArray2Arg<ARG2, T>(int arg1, ARG2 arg2, GetArray2ArgDel<ARG2, T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		}
		public static bool SetArray<ARG2, T>(int arg1, ARG2 arg2, GetArray1ArgDel<T> func1, GetArray2ArgDel<ARG2, T> func2, out T[] data, int start, int count, int tupleSize) {
			data = default;
			return default;
		}
		public static bool DoArrayElementsMatch<T>(T[] array1, T[] array2) => default;
		public static bool DoArrayElementsMatch<T>(T[] array1, int startOffset1, T[] array2, int startOffset2, int length) => default;
		public static bool GetAttributeArray<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, T[] items, GetAttributeArrayInputFunc<T> getFunc, int count) => default;
		public static bool GetAttribute<T>(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref ref T[] data, GetAttributeArrayInputFunc<T> getFunc) => default;
		public static bool GetAttributeStrict<T>(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner attrOwner, string name, ref HAPI_AttributeInfo info, ref ref T[] data, GetAttributeArrayInputFunc<T> getFunc) => default;
		public static void GetAttributeStringDataHelper(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] data) {} // 0x0000000188833540-0x0000000188833590
		public static string[] GetAttributeStringData(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo) => default; // 0x0000000188833590-0x0000000188833648
		public static string[] GetAttributeDataAsString(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo) => default; // 0x0000000188833274-0x00000001888332F0
		public static bool SetAttributeArray<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc, int count, int start = 0 /* Metadata: 0x01FBEB5A */) => default;
		public static bool SetAttribute<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc) => default;
		public static bool CheckAttributeExists(HEU_SessionBase session, int geoID, int partID, string attribName, HAPI_AttributeOwner attribOwner) => default; // 0x00000001888076A8-0x00000001888076C0
		public static bool GetAttributeInfo(HEU_SessionBase session, int geoID, int partID, string attribName, ref HAPI_AttributeInfo attribInfo) => default; // 0x0000000188833408-0x0000000188833428
		public static bool HasValidInstanceAttribute(HEU_SessionBase session, int geoID, int partID, string attribName) => default; // 0x00000001888349C0-0x00000001888349EC
		public static void UpdateGeneratedAttributeStore(HEU_SessionBase session, int geoID, int partID, GameObject go) {} // 0x0000000188835AF4-0x0000000188835C5C
		public static HEU_OutputAttribute CreateOutputAttributeHelper(string attrName, ref HAPI_AttributeInfo attrInfo) => default; // 0x0000000188831EB0-0x0000000188831F30
		public static HEU_OutputAttribute CreateOutputAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo) => default; // 0x0000000188831F30-0x0000000188832170
		public static void CopyWorldTransformValues(Transform src, Transform dest) {} // 0x0000000188831D58-0x0000000188831E14
		public static void ApplyTransformTo(Transform src, Transform target) {} // 0x0000000188830DCC-0x0000000188830EE0
		public static void CopyLocalTransformValues(Transform src, Transform dest) {} // 0x0000000188831C9C-0x0000000188831D58
		public static List<GameObject> GetChildGameObjects(GameObject parentGO) => default; // 0x0000000188833DD4-0x0000000188833FCC
		public static List<GameObject> GetChildGameObjectsWithNamePattern(GameObject parentGO, string pattern, bool bExclude) => default; // 0x0000000188833B6C-0x0000000188833DD4
		public static List<GameObject> GetInstanceChildObjects(GameObject parentGO) => default; // 0x0000000188834238-0x0000000188834278
		public static List<GameObject> GetNonInstanceChildObjects(GameObject parentGO) => default; // 0x00000001888344E4-0x0000000188834524
		public static GameObject GetGameObjectByName(List<GameObject> goList, string name) => default; // 0x00000001888340BC-0x0000000188834200
		public static GameObject GetGameObjectByNameInProjectOnly(string name) => default; // 0x0000000188833FCC-0x0000000188834084
		public static bool IsGameObjectInProject(GameObject go) => default; // 0x00000001888349EC-0x00000001888349F4
		public static GameObject GetGameObjectByNameInScene(string name) => default; // 0x0000000188834084-0x00000001888340BC
		public static HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(string name) => default; // 0x0000000188834200-0x0000000188834238
		public static T GetOrCreateComponent<T>(GameObject gameObject)
			where T : Component => default;
		public static void DestroyGeneratedComponents(GameObject gameObject) {} // 0x00000001888324A4-0x0000000188832580
		public static void DestroyGeneratedMeshComponents(GameObject gameObject) {} // 0x000000018883267C-0x0000000188832708
		public static void DestroyTerrainComponents(GameObject gameObject) {} // 0x0000000188832B6C-0x0000000188832CB0
		public static void DestroyComponent<T>(GameObject gameObject)
			where T : Component {}
		public static void DestroyImmediate(UnityEngine.Object obj, bool bAllowDestroyingAssets = false /* Metadata: 0x01FBEB5B */, bool bRegisterUndo = false /* Metadata: 0x01FBEB5C */) {} // 0x00000001888328F0-0x0000000188832924
		public static void DestroyBakedGameObjects(List<GameObject> gameObjectsToDestroy) {} // 0x00000001888323D8-0x00000001888323E4
		public static void DestroyBakedGameObjectsWithEndName(List<GameObject> gameObjectsToDestroy, string endName) {} // 0x00000001888322CC-0x00000001888323D8
		public static void DestroyLODGroup(GameObject targetGO, bool bDontDeletePersistantResources) {} // 0x0000000188832924-0x0000000188832A90
		public static List<Transform> GetLODTransforms(GameObject targetGO) => default; // 0x0000000188834278-0x00000001888343B8
		public static void SetLODTransformValues(GameObject targetGO, List<HoudiniEngineUnity.TransformData> transformData) {} // 0x0000000188835694-0x00000001888357D0
		public static void DestroyGeneratedMeshMaterialsLODGroups(GameObject targetGO, bool bDontDeletePersistantResources) {} // 0x0000000188832708-0x00000001888328F0
		public static void DestroyGeneratedMaterial(Material material) {} // 0x0000000188832580-0x000000018883267C
		public static void DestroyMeshCollider(MeshCollider meshCollider, bool bDontDeletePersistantResources) {} // 0x0000000188832A90-0x0000000188832B6C
		public static void SetGameObjectRenderVisiblity(GameObject gameObject, bool bVisible) {} // 0x00000001888355E4-0x0000000188835694
		public static void SetGameObjectChildrenRenderVisibility(GameObject gameObject, bool bVisible) {} // 0x000000018883547C-0x0000000188835534
		public static void SetGameObjectColliderState(GameObject gameObject, bool bEnabled) {} // 0x0000000188835534-0x00000001888355E4
		public static void SetGameObjectChildrenColliderState(GameObject gameObject, bool bVisible) {} // 0x00000001888353C4-0x000000018883547C
		public static string ColorToString(UnityEngine.Color c) => default; // 0x00000001888318D4-0x0000000188831A70
		public static UnityEngine.Color StringToColor(string colorString) => default; // 0x00000001888359FC-0x0000000188835AF4
		public static bool DoesUnityTagExist(string tagName) => default; // 0x000000018232EB60-0x000000018232EB70
		public static void SetLayer(GameObject rootGO, int layer, bool bIncludeChildren) {} // 0x00000001888357D0-0x0000000188835894
		public static void SetTag(GameObject rootGO, string tag, bool bIncludeChildren) {} // 0x0000000188835938-0x00000001888359FC
		public static void CopyFlags(GameObject srcGO, GameObject dstGO, bool bIncludeChildren) {} // 0x0000000188831BA0-0x0000000188831C10
		public static bool IsMouseWithinSceneView(Camera camera, Vector2 mousePosition) => default; // 0x0000000188834AC8-0x0000000188834B38
		public static bool IsMouseOverRect(Camera camera, Vector2 mousePosition, ref Rect rect) => default; // 0x0000000188834A7C-0x0000000188834AC8
		public static System.Type GetSystemTypeByName(string typeName) => default; // 0x0000000188834838-0x0000000188834870
		public static void AssignUnityTag(HEU_SessionBase session, int geoID, int partID, GameObject gameObject) {} // 0x00000001888310C8-0x0000000188831360
		public static void AssignUnityLayer(HEU_SessionBase session, int geoID, int partID, GameObject gameObject) {} // 0x0000000188830EE0-0x00000001888310C8
		public static void MakeStaticIfHasAttribute(HEU_SessionBase session, int geoID, int partID, GameObject gameObject) {} // 0x0000000188834E4C-0x0000000188834F70
		public static string GetUnityScriptAttributeValue(HEU_SessionBase session, int geoID, int partID) => default; // 0x0000000188834870-0x000000018883499C
		public static string GetAttributeStringValueSingle(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner) => default; // 0x0000000188833934-0x0000000188833B6C
		public static string GetAttributeStringValueSingleStrict(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner) => default; // 0x0000000188833648-0x0000000188833934
		public static bool GetAttributeFloatSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out float value) {
			value = default;
			return default;
		} // 0x00000001888332F0-0x0000000188833408
		public static bool GetAttributeIntSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out int value) {
			value = default;
			return default;
		} // 0x0000000188833428-0x0000000188833540
		public static bool GetAttributeColorSingle(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color value) => default; // 0x00000001888330FC-0x0000000188833274
		public static bool HasAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner) => default; // 0x000000018883499C-0x00000001888349C0
		public static void AttachScriptWithInvokeFunction(string scriptSet, GameObject gameObject) {} // 0x0000000188831360-0x000000018883187C
		public static bool IsInCameraView(Camera camera, Vector3 point) => default; // 0x00000001888349F4-0x0000000188834A7C
		internal static List<HEU_Handle> FindOrGenerateHandles(HEU_SessionBase session, ref HAPI_AssetInfo assetInfo, int assetID, string assetName, HEU_Parameters parameters, List<HEU_Handle> currentHandles) => default; // 0x0000000188832CB0-0x00000001888330FC
		public static void CopyComponents(GameObject srcGO, GameObject destGO) {} // 0x000000018350B670-0x000000018350B680
		public static Texture LoadTextureFromFile(string filePath) => default; // 0x0000000188834B38-0x0000000188834CE4
		public static Texture2D MakeTexture(int width, int height, UnityEngine.Color color) => default; // 0x0000000188834F70-0x0000000188835070
		public static string ReplaceFirstOccurrence(string srcStr, string searchStr, string replaceStr) => default; // 0x000000018883532C-0x00000001888353C4
		public static void SetParentWithCleanTransform(Transform parentTransform, Transform childTransform) {} // 0x0000000188835894-0x0000000188835938
		public static void CopyHAPITransform(ref HAPI_Transform src, ref HAPI_Transform dest) {} // 0x0000000188831C10-0x0000000188831C9C
		public static string GetMaterialAttributeValueFromPart(HEU_SessionBase session, int geoID, int partID) => default; // 0x00000001888343B8-0x00000001888344E4
		public static void ReplaceColliderMeshFromMeshFilter(GameObject targetGO, GameObject sourceColliderGO) {} // 0x0000000188835200-0x000000018883532C
		public static void ReplaceColliderMeshFromMeshCollider(GameObject targetGO, GameObject sourceColliderGO) {} // 0x00000001888350E0-0x0000000188835200
		public static float BiLerpf(float p00, float p10, float p01, float p11, float fracX, float fracY) => default; // 0x000000018883187C-0x00000001888318D4
		public static float Fractionalf(float value) => default; // 0x0000000183D6D920-0x0000000183D6D950
		public static string LongestCommonPrefix(List<string> list) => default; // 0x0000000188834CE4-0x0000000188834E4C
		public static string GetRawOperatorName(string assetOpName) => default; // 0x00000001888347DC-0x0000000188834838
		public static GameObject GetPrefabFromPath(string path) => default; // 0x0000000188834524-0x00000001888347DC
		public static void ComposeNChildren(GameObject parent, int n, ref List<GameObject> childGameObjects, bool destroyIfExists = false /* Metadata: 0x01FBEB5D */) {} // 0x0000000188831A70-0x0000000188831BA0
		private static void DestroyChildWithName(Transform parent, string name) {} // 0x00000001888323E4-0x00000001888324A4
		public static void DestroyAutoGeneratedChildren(GameObject parent) {} // 0x0000000188832170-0x00000001888322CC
		public static GameObject CreateNewGameObject(string name = "" /* Metadata: 0x01FBEB5E */) => default; // 0x0000000188831E14-0x0000000188831EB0
		public static void RenameGameObject(GameObject obj, string name) {} // 0x0000000188835070-0x00000001888350E0
	}

	public class ReverseCompare : System.Collections.IComparer // TypeDefIndex: 49781
	{
		// Constructors
		public ReverseCompare() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public int Compare(object x, object y) => default; // 0x0000000188844B38-0x0000000188844BB0
	}

	public class HEU_GenerateGeoCache // TypeDefIndex: 49785
	{
		// Fields
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
		public Dictionary<int, string> _unityMaterialAttrStringsMap; // 0xC8
		public HAPI_AttributeInfo _substanceMaterialAttrNameInfo; // 0xD0
		public int[] _substanceMaterialAttrName; // 0xF8
		public Dictionary<int, string> _substanceMaterialAttrStringsMap; // 0x100
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
		public int GeoID { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public int PartID { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
		public int AssetID { get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
	
		// Nested types
		public class HEU_ColliderInfo // TypeDefIndex: 49783
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
			public enum ColliderType // TypeDefIndex: 49782
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
			public HEU_ColliderInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public HEU_GenerateGeoCache() {} // 0x000000018883F5BC-0x000000018883F828
	
		// Methods
		public static HEU_GenerateGeoCache GetPopulatedGeoCache(HEU_SessionBase session, int assetID, int geoID, int partID, bool bUseLODGroups, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018883D334-0x000000018883D3EC
		public void PopulateUnityMaterialData(HEU_SessionBase session) {} // 0x000000018883E61C-0x000000018883EB68
		public static int GetMaterialKeyFromAttributeIndex(HEU_GenerateGeoCache geoCache, int attributeIndex, out string unityMaterialName, out string substanceName, out int substanceIndex) {
			unityMaterialName = default;
			substanceName = default;
			substanceIndex = default;
			return default;
		} // 0x000000018883D1B8-0x000000018883D334
		public static void CreateMaterialInfoEntryFromAttributeIndex(HEU_GenerateGeoCache geoCache, int materialAttributeIndex) {} // 0x000000018883657C-0x0000000188836688
		public bool PopulateGeometryData(HEU_SessionBase session, bool bUseLODGroups) => default; // 0x000000018883D770-0x000000018883E61C
		public static void ParseLODTransitionAttribute(HEU_SessionBase session, int geoID, int partID, ref float[] LODTransitionValues) {} // 0x000000018883D690-0x000000018883D770
		public static void UpdateColliders(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData) {} // 0x000000018883F47C-0x000000018883F5BC
		public static void UpdateCollider(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData, HEU_ColliderInfo colliderInfo) {} // 0x000000018883EE28-0x000000018883F47C
		private static void GetFinalMaterialsFromComparingNewWithPrevious(GameObject gameObject, Material[] previousMaterials, Material[] newMaterials, ref Material[] finalMaterials) {} // 0x000000018883CE7C-0x000000018883D1B8
		public static bool GenerateMeshFromSingleGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced) => default; // 0x000000018883CC6C-0x000000018883CE7C
		public static bool GenerateLODMeshesFromGeoGroups(HEU_SessionBase session, List<HEU_GeoGroup> GeoGroupMeshes, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced) => default; // 0x000000018883AA04-0x000000018883B3FC
		public static bool GenerateMeshFromGeoGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced, out Mesh newMesh, out Material[] newMaterials) {
			newMesh = default;
			newMaterials = default;
			return default;
		} // 0x000000018883B3FC-0x000000018883CC6C
		public static Mesh CombineQuadMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> subMeshIndices, bool bGenerateNormals) => default; // 0x0000000188836004-0x000000018883657C
		public static Mesh CombineMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> submeshIndices, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat) => default; // 0x0000000188835D90-0x0000000188836004
		public static Mesh CreateMeshFromMeshData(HEU_MeshData submesh, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat) => default; // 0x0000000188836688-0x0000000188836918
		public static void TransferRegularAttributesToVertices(int[] groupVertexList, int[] allFaceCounts, List<int> groupFaces, List<int> groupVertexOffset, ref HAPI_AttributeInfo attribInfo, float[] inData, ref float[] outData) {} // 0x000000018883EB68-0x000000018883EE28
		public static bool GenerateGeoGroupUsingGeoCacheVertices(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey) {
			LODGroupMeshes = default;
			defaultMaterialKey = default;
			return default;
		} // 0x0000000188838530-0x000000018883AA04
		public static bool GenerateGeoGroupUsingGeoCachePoints(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey) {
			LODGroupMeshes = default;
			defaultMaterialKey = default;
			return default;
		} // 0x0000000188836918-0x0000000188838530
		private static void GetSubmeshIDForFace(HEU_GenerateGeoCache geoCache, int faceMaterialID, int groupFace, int vertexFaceIndex, int[] groupVertexList, int defaultMaterialKey, ref int submeshID, ref int singleFaceUnityMaterialKey, ref int singleFaceHoudiniMaterialKey) {} // 0x000000018883D3EC-0x000000018883D690
		public static MeshTopology CalculateGroupMeshTopology(List<int> groupFaces, int[] allFaceCounts) => default; // 0x0000000188835C5C-0x0000000188835D90
	}

	public class HEU_GeoGroup : IComparable<HEU_GeoGroup> // TypeDefIndex: 49786
	{
		// Fields
		public string _groupName; // 0x10
		public Dictionary<int, HEU_MeshData> _subMeshesMap; // 0x18
		public List<HEU_VertexEntry>[] _sharedNormalIndices; // 0x20
	
		// Constructors
		public HEU_GeoGroup() {} // 0x0000000188844EF0-0x0000000188844F68
	
		// Methods
		public int CompareTo(HEU_GeoGroup other) => default; // 0x0000000188844DC4-0x0000000188844DFC
		public void SetupNormalIndices(int indicesCount) {} // 0x0000000188844DFC-0x0000000188844EF0
	}

	public class HEU_VertexEntry // TypeDefIndex: 49787
	{
		// Fields
		public int _meshKey; // 0x10
		public int _vertexIndex; // 0x14
		public int _normalIndex; // 0x18
	
		// Constructors
		public HEU_VertexEntry() {} // Dummy constructor
		public HEU_VertexEntry(int meshKey, int vertexIndex, int normalIndex) {} // 0x0000000183D51130-0x0000000183D51140
	}

	public static class HEU_GeometryUtility // TypeDefIndex: 49788
	{
		// Methods
		public static Vector2[] GeneratePerTriangle(Mesh meshSrc) => default; // 0x00000001888464A0-0x00000001888464D8
		public static void GenerateSecondaryUVSet(Mesh meshsrc) {} // 0x00000001888464D8-0x000000018884650C
		public static void CalculateMeshTangents(Mesh mesh) {} // 0x0000000188844F68-0x000000018884570C
		public static Mesh GenerateCubeMeshFromPoints(Vector3[] points, UnityEngine.Color[] pointsColor, float size = 1f /* Metadata: 0x01FBEB66 */) => default; // 0x000000018884570C-0x00000001888464A0
		public static string GetInstanceOutputName(string partName, string[] userPrefix, int index) => default; // 0x000000018884650C-0x00000001888465BC
	}

	public class HEU_InputData // TypeDefIndex: 49789
	{
		// Fields
		public GameObject _inputObject; // 0x10
	
		// Constructors
		public HEU_InputData() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class HEU_InputInterface // TypeDefIndex: 49790
	{
		// Fields
		public const int DEFAULT_PRIORITY = 100; // Metadata: 0x01FBEB6A
		protected int _priority; // 0x10
	
		// Properties
		public int Priority { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		protected HEU_InputInterface() {} // Dummy constructor
		public HEU_InputInterface(int priority) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public void RegisterInterface() {} // 0x000000018884BEA4-0x000000018884BEF0
		public abstract bool IsThisInputObjectSupported(GameObject inputObject);
		public abstract bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID);
	}

	[Serializable]
	public class HEU_InputInterfaceMeshSettings // TypeDefIndex: 49791
	{
		// Fields
		[SerializeField]
		private bool _exportColliders; // 0x10
	
		// Properties
		public bool ExportColliders { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public HEU_InputInterfaceMeshSettings() {} // 0x000000018350B670-0x000000018350B680
	}

	public class HEU_InputInterfaceMesh : HEU_InputInterface // TypeDefIndex: 49796
	{
		// Fields
		private HEU_InputInterfaceMeshSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataMeshes : HEU_InputData // TypeDefIndex: 49792
		{
			// Fields
			public List<HEU_InputDataMesh> _inputMeshes; // 0x18
			public bool _hasLOD; // 0x20
	
			// Constructors
			public HEU_InputDataMeshes() {} // 0x00000001888465BC-0x0000000188846634
		}
	
		public enum HEU_InputColliderType // TypeDefIndex: 49793
		{
			NONE = 0,
			BOX = 1,
			SPHERE = 2,
			CAPSULE = 3,
			MESH = 4
		}
	
		public class HEU_InputDataCollider // TypeDefIndex: 49794
		{
			// Fields
			public Collider _collider; // 0x10
			public HEU_InputColliderType _colliderType; // 0x18
	
			// Constructors
			public HEU_InputDataCollider() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class HEU_InputDataMesh // TypeDefIndex: 49795
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
			public HEU_InputDataMesh() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		private HEU_InputInterfaceMesh() {} // 0x0000000183D6D950-0x0000000183D6D960
	
		// Methods
		public void Initialize(HEU_InputInterfaceMeshSettings settings) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x0000000188846708-0x0000000188846848
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x000000018884727C-0x0000000188847398
		public static void GetUVsFromMesh(Mesh mesh, Vector2[] srcUVs, List<Vector3> destUVs, int index) {} // 0x00000001888471F8-0x000000018884727C
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData) => default; // 0x000000018884805C-0x0000000188849484
		internal bool UploadColliderData(HEU_SessionBase session, int mergeNodeID, HEU_InputDataMeshes inputData, int parentNodeId) => default; // 0x0000000188847B28-0x000000018884805C
		internal bool UploadBoxColliderData(HEU_SessionBase session, BoxCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x0000000188847398-0x000000018884750C
		internal bool UploadSphereColliderData(HEU_SessionBase session, SphereCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x0000000188849768-0x00000001888498E0
		internal bool UploadCapsuleColliderData(HEU_SessionBase session, CapsuleCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018884750C-0x0000000188847B28
		internal bool UploadMeshColliderData(HEU_SessionBase session, MeshCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x0000000188849484-0x0000000188849768
		internal string GetColliderGroupBaseName(Collider collider, bool bIsConvex = false /* Metadata: 0x01FBEB6C */, bool bIsSimple = false /* Metadata: 0x01FBEB6D */, bool bIsRendered = false /* Metadata: 0x01FBEB6E */) => default; // 0x0000000188847008-0x00000001888470F8
		internal bool CreateInputNodeForCollider(HEU_SessionBase session, out int outNodeID, int parentNodeId, int colliderIndex, string colliderName, float[] colliderVertices, int[] colliderIndices) {
			outNodeID = default;
			return default;
		} // 0x0000000188846694-0x0000000188846708
		public HEU_InputDataMeshes GenerateMeshDatasFromGameObject(GameObject inputObject, bool bExportColliders = false /* Metadata: 0x01FBEB6F */) => default; // 0x0000000188846D30-0x0000000188847008
		public static HEU_InputDataMesh CreateSingleMeshData(GameObject meshGameObject, bool bExportColliders) => default; // 0x0000000188846848-0x0000000188846D30
		private static Mesh GetMeshFromObject(GameObject meshGameObject) => default; // 0x00000001888470F8-0x00000001888471F8
	}

	public class HEU_InputInterfaceTerrain : HEU_InputInterface // TypeDefIndex: 49798
	{
		// Nested types
		public class HEU_InputDataTerrain : HEU_InputData // TypeDefIndex: 49797
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
			public HEU_InputDataTerrain() {} // 0x0000000188846634-0x0000000188846694
		}
	
		// Constructors
		public HEU_InputInterfaceTerrain() {} // 0x0000000183D6D950-0x0000000183D6D960
	
		// Methods
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x0000000188849958-0x0000000188849AD4
		private bool SetMaskLayer(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo) => default; // 0x0000000188849FA4-0x000000018884A0A8
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x0000000188849EA4-0x0000000188849F3C
		public bool CreateHeightFieldInputNode(HEU_SessionBase session, HEU_InputDataTerrain idt) => default; // 0x00000001888498E0-0x0000000188849958
		public bool UploadHeightValuesWithTransform(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo volumeInfo) => default; // 0x000000018884A7E8-0x000000018884A8D4
		public bool UploadAlphaMaps(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo, out bool bMaskSet) {
			bMaskSet = default;
			return default;
		} // 0x000000018884A2F4-0x000000018884A7E8
		public bool SetHeightFieldData(HEU_SessionBase session, int volumeNodeID, int partID, float[] heightValues, string heightFieldName, ref HAPI_VolumeInfo baseVolumeInfo) => default; // 0x0000000188849F3C-0x0000000188849FA4
		public bool SetTerrainDataAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData) => default; // 0x000000018884A0A8-0x000000018884A12C
		public bool SetTerrainLayerAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainLayer terrainLayer) => default; // 0x000000018884A12C-0x000000018884A1B0
		public void SetTreePrototypes(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData) {} // 0x000000018884A1D0-0x000000018884A2F4
		public void SetTreeInstances(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData) {} // 0x000000018884A1B0-0x000000018884A1D0
		public HEU_InputDataTerrain GenerateTerrainDataFromGameObject(GameObject inputObject) => default; // 0x0000000188849AD4-0x0000000188849EA4
	}

	[Serializable]
	public class HEU_InputInterfaceTilemapSettings // TypeDefIndex: 49799
	{
		// Fields
		public bool _createGroupsForTiles; // 0x10
		public bool _exportUnusedTiles; // 0x11
		public bool _applyTileColor; // 0x12
		public bool _applyTilemapOrientation; // 0x13
	
		// Constructors
		public HEU_InputInterfaceTilemapSettings() {} // 0x0000000183D6D960-0x0000000183D6D970
	}

	public class HEU_InputInterfaceTilemap : HEU_InputInterface // TypeDefIndex: 49801
	{
		// Fields
		private HEU_InputInterfaceTilemapSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataTilemap : HEU_InputData // TypeDefIndex: 49800
		{
			// Fields
			public Tilemap _tilemap; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataTilemap() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		private HEU_InputInterfaceTilemap() {} // 0x0000000183D6D950-0x0000000183D6D960
	
		// Methods
		public void Initialize(HEU_InputInterfaceTilemapSettings settings) {} // 0x000000018884AA78-0x000000018884AAE4
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018884A8D4-0x000000018884A9AC
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x000000018884AAE4-0x000000018884AB78
		private bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData) => default; // 0x000000018884AB78-0x000000018884BEA4
		public HEU_InputDataTilemap GenerateTilemapDataFromGameObject(GameObject inputObject) => default; // 0x000000018884A9AC-0x000000018884AA78
	}

	public static class HEU_InputMeshUtility // TypeDefIndex: 49802
	{
		// Methods
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem) => default; // 0x000000018884C040-0x000000018884C198
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, ref HAPI_PartInfo partInfo) => default; // 0x000000018884C3CC-0x000000018884C524
		public static bool SetMeshVertexAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, int[] indices, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem) => default; // 0x000000018884C524-0x000000018884C678
		public static bool SetMeshVertexFloatAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, int[] indices, ref HAPI_PartInfo partInfo) => default; // 0x000000018884C678-0x000000018884C7CC
		public static bool UploadMeshIntoHoudiniNode(HEU_SessionBase session, int assetNodeID, int objectID, int geoID, ref Mesh mesh) => default; // 0x000000018884C7CC-0x000000018884C9F4
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3Int[] data, ref HAPI_PartInfo partInfo) => default; // 0x000000018884C198-0x000000018884C2E8
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, string[] data, ref HAPI_PartInfo partInfo) => default; // 0x000000018884C2E8-0x000000018884C3CC
		public static bool SetMeshDetailAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3 data, ref HAPI_PartInfo partInfo) => default; // 0x000000018884BEF0-0x000000018884C040
	}

	public static class HEU_InputUtility // TypeDefIndex: 49803
	{
		// Fields
		private static List<HEU_InputInterface> _inputInterfaces; // 0x00
	
		// Constructors
		static HEU_InputUtility() {} // 0x000000018884D5B0-0x000000018884D63C
	
		// Methods
		public static int GetHighestPriority() => default; // 0x000000018884CD4C-0x000000018884CDF0
		public static void RegisterInputInterface(HEU_InputInterface inputInterface) {} // 0x000000018884D0F0-0x000000018884D2B0
		public static void UnregisterInputInterface(HEU_InputInterface inputInterface) {} // 0x000000018884D2B0-0x000000018884D320
		public static HEU_InputInterface GetInputInterfaceByType(System.Type type) => default; // 0x000000018884CDF0-0x000000018884CF1C
		public static HEU_InputInterface GetInputInterface(GameObject inputObject) => default; // 0x000000018884CFE8-0x000000018884D0F0
		internal static HEU_InputInterface GetInputInterface(HEU_InputObjectInfo inputObjectInfo) => default; // 0x000000018884CF1C-0x000000018884CFE8
		internal static bool CreateInputNodeWithMultiObjects(HEU_SessionBase session, int assetID, ref int connectMergeID, ref List<HEU_InputObjectInfo> inputObjects, ref List<int> inputObjectsConnectedAssetIDs, HEU_InputNode inputNode) => default; // 0x000000018884CAB0-0x000000018884CBF0
		internal static bool CreateInputNodeWithMultiAssets(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, ref int connectMergeID, ref List<HEU_InputHDAInfo> inputAssetInfos, bool bKeepWorldTransform, int mergeParentID = -1 /* Metadata: 0x01FBEB75 */) => default; // 0x000000018884C9F4-0x000000018884CAB0
		internal static bool UploadInputObjectTransform(HEU_SessionBase session, HEU_InputObjectInfo inputObject, int inputNodeID, bool bKeepWorldTransform) => default; // 0x000000018884D320-0x000000018884D5B0
		public static void GetChildrenTransforms(Transform transform, ref List<Matrix4x4> childTransforms) {} // 0x000000018884CBF0-0x000000018884CD4C
	}

	public class HEU_Logger // TypeDefIndex: 49804
	{
		// Constructors
		public HEU_Logger() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void Log(string text) {} // 0x000000018884D918-0x000000018884D964
		public static void LogFormat(string text, params object[] args) {} // 0x000000018884D774-0x000000018884D7D0
		public static void LogWarning(string text) {} // 0x000000018884D8CC-0x000000018884D918
		public static void LogWarningFormat(string text, params object[] args) {} // 0x000000018884D86C-0x000000018884D8CC
		public static void LogError(string text) {} // 0x000000018884D6AC-0x000000018884D6F8
		public static void LogErrorFormat(string text, params object[] args) {} // 0x000000018884D64C-0x000000018884D6AC
		public static void LogError(Exception ex) {} // 0x000000018884D6F8-0x000000018884D774
		public static void LogAssertion(string text) {} // 0x000000018884D644-0x000000018884D64C
		public static void LogAssertionFormat(string text, params object[] args) {} // 0x000000018884D63C-0x000000018884D644
		private static void LogToCookLogsIfOn(string text) {} // 0x000000018884D82C-0x000000018884D86C
		private static void LogToCookLogsIfOnFormat(string text, params object[] args) {} // 0x000000018884D7D0-0x000000018884D82C
	}

	public class HEU_MeshData // TypeDefIndex: 49805
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
		public HEU_MeshData() {} // 0x000000018884D964-0x000000018884DB9C
	}

	[Serializable]
	public class HEU_MeshIndexFormat // TypeDefIndex: 49806
	{
		// Fields
		public IndexFormat _indexFormat; // 0x10
	
		// Constructors
		public HEU_MeshIndexFormat() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void CalculateIndexFormat(int numVertices) {} // 0x000000018884DB9C-0x000000018884DBF8
		public void SetFormatForMesh(Mesh mesh) {} // 0x000000018884DBF8-0x000000018884DC1C
	}

	public enum HEU_PipelineType // TypeDefIndex: 49807
	{
		Unsupported = 0,
		BiRP = 1,
		URP = 2,
		HDRP = 3
	}

	public class HEU_RenderingPipelineDefines // TypeDefIndex: 49808
	{
		// Constructors
		static HEU_RenderingPipelineDefines() {} // 0x000000018884DF94-0x000000018884DF9C
		public HEU_RenderingPipelineDefines() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static void UpdateDefines() {} // 0x000000018884DED0-0x000000018884DF94
		public static HEU_PipelineType GetPipeline() => default; // 0x000000018884DD20-0x000000018884DE2C
		private static void AddDefine(string define) {} // 0x000000018884DC1C-0x000000018884DCC0
		public static void RemoveDefine(string define) {} // 0x000000018884DE2C-0x000000018884DED0
		public static List<string> GetDefines() => default; // 0x000000018884DCC0-0x000000018884DD20
		public static void SetDefines(List<string> definesList) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class HEU_SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ISerializationCallbackReceiver // TypeDefIndex: 49809
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
		public ICollection<TKey> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Constructors
		public HEU_SerializableDictionary() {}
	
		// Methods
		public void Add(TKey key, TValue value) {}
		public void Add(KeyValuePair<TKey, TValue> item) {}
		public void Clear() {}
		public bool Contains(KeyValuePair<TKey, TValue> item) => default;
		public bool ContainsKey(TKey key) => default;
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		public bool Remove(TKey key) => default;
		public bool Remove(KeyValuePair<TKey, TValue> item) => default;
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		IEnumerator IEnumerable.GetEnumerator() => default;
		public void OnAfterDeserialize() {}
		public void OnBeforeSerialize() {}
	}

	[Serializable]
	public class HEU_ShelfToolData // TypeDefIndex: 49811
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
		public enum ToolType // TypeDefIndex: 49810
		{
			GENERATOR = 0,
			OPERATOR_SINGLE = 1,
			OPERATOR_MULTI = 2,
			BATCH = 3
		}
	
		// Constructors
		public HEU_ShelfToolData() {} // 0x000000018884DF9C-0x000000018884E040
	}

	[Serializable]
	public class HEU_Shelf // TypeDefIndex: 49812
	{
		// Fields
		public string _shelfName; // 0x10
		public string _shelfPath; // 0x18
		public bool _defaultShelf; // 0x20
		public List<HEU_ShelfToolData> _tools; // 0x28
	
		// Constructors
		public HEU_Shelf() {} // 0x00000001888513E4-0x000000018885145C
	}

	public class HEU_ShelfTools // TypeDefIndex: 49814
	{
		// Fields
		[SerializeField]
		private static List<HEU_Shelf> _shelves; // 0x00
		[SerializeField]
		private static bool _shelvesLoaded; // 0x08
		[SerializeField]
		private static int _currentSelectedShelf; // 0x0C
		public const string TARGET_ALL = "all"; // Metadata: 0x01FBEB7E
		public const string TARGET_UNITY = "unity"; // Metadata: 0x01FBEB82
	
		// Constructors
		public HEU_ShelfTools() {} // 0x000000018350B670-0x000000018350B680
		static HEU_ShelfTools() {} // 0x0000000188851344-0x00000001888513E4
	
		// Methods
		public static bool AreShelvesLoaded() => default; // 0x000000018884E1E0-0x000000018884E230
		public static void SetReloadShelves() {} // 0x0000000188851274-0x00000001888512C4
		public static void ClearShelves() {} // 0x000000018884E230-0x000000018884E294
		public static int GetNumShelves() => default; // 0x000000018884F258-0x000000018884F2B4
		public static int GetCurrentShelfIndex() => default; // 0x000000018884F208-0x000000018884F258
		public static void SetCurrentShelf(int index) {} // 0x0000000188851220-0x0000000188851274
		public static HEU_Shelf GetShelf(int index) => default; // 0x000000018884F45C-0x000000018884F500
		public static HEU_Shelf GetShelf(string shelfName) => default; // 0x000000018884F300-0x000000018884F45C
		public static string GetShelfStorageEntry(string shelfName, string shelfPath) => default; // 0x000000018884F2B4-0x000000018884F300
		public static void GetSplitShelfEntry(string shelfEntry, out string shelfName, out string shelfPath) {
			shelfName = default;
			shelfPath = default;
		} // 0x000000018884F500-0x000000018884F5E0
		public static void LoadShelves() {} // 0x000000018884FB94-0x0000000188850270
		public static bool LoadToolsFromDirectory(string folderPath, out List<HEU_ShelfToolData> tools) {
			tools = default;
			return default;
		} // 0x0000000188850CB8-0x0000000188850EDC
		public static HEU_ShelfToolData LoadToolFromJsonFile(string jsonFilePath) => default; // 0x0000000188850270-0x000000018885040C
		public static HEU_ShelfToolData LoadToolFromJsonString(string json, string jsonFilePath) => default; // 0x000000018885040C-0x0000000188850CB8
		public static HEU_Shelf AddShelf(string shelfName, string shelfPath) => default; // 0x000000018884E040-0x000000018884E1E0
		public static void RemoveShelf(int shelfIndex) {} // 0x0000000188850EDC-0x000000018885100C
		public static void SaveShelf() {} // 0x000000018885100C-0x0000000188851220
		public static void ExecuteTool(int toolSlot) {} // 0x000000018884EF58-0x000000018884F208
		public static void ExecuteToolGenerator(string toolName, string toolPath, Vector3 targetPosition, Quaternion targetRotation, Vector3 targetScale) {} // 0x000000018884E2F4-0x000000018884E490
		public static bool IsValidInputMesh(GameObject gameObject) => default; // 0x000000018884FA04-0x000000018884FB94
		public static bool IsValidInputHDA(GameObject gameObject) => default; // 0x000000018884F974-0x000000018884FA04
		private static bool ShouldUseHDA(GameObject[] gameObjectList) => default; // 0x00000001888512C4-0x0000000188851344
		public static void ExecuteToolNoInput(string toolName, string toolPath) {} // 0x000000018884E490-0x000000018884E5C4
		public static void ExecuteToolOperatorSingle(string toolName, string toolPath, GameObject[] inputObjects) {} // 0x000000018884E9E0-0x000000018884EF58
		public static void ExecuteToolOperatorMultiple(string toolName, string toolPath, GameObject[] inputObjects) {} // 0x000000018884E5C4-0x000000018884E9E0
		public static void ExecuteToolBatch(string toolName, string toolPath, GameObject[] batchObjects) {} // 0x000000018884E294-0x000000018884E2F4
		public static string GetToolResourcePath(HEU_ShelfToolData tool, string inPath, string ext) => default; // 0x000000018884F8B8-0x000000018884F974
		public static string GetToolIconPath(HEU_ShelfToolData tool, string inPath) => default; // 0x000000018884F750-0x000000018884F8B8
		public static string GetToolAssetPath(HEU_ShelfToolData tool, string inPath) => default; // 0x000000018884F5E0-0x000000018884F750
	}

	public enum JSONNodeType // TypeDefIndex: 49815
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

	public enum JSONTextMode // TypeDefIndex: 49816
	{
		Compact = 0,
		Indent = 1
	}

	public abstract class JSONNode // TypeDefIndex: 49824
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
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		public virtual string Value { get; set; } // 0x0000000188853C4C-0x0000000188853C78 0x000000018350B670-0x000000018350B680
		public virtual int Count { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual bool IsNumber { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsString { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsBoolean { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsNull { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsArray { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsObject { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool Inline { get; set; } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__40))] get; } // 0x00000001888539C0-0x0000000188853A14 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine(typeof(_get_DeepChildren_d__42))] get; } // 0x0000000188853A14-0x0000000188853A84 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x0000000188853BEC-0x0000000188853C4C 
		public KeyEnumerator Keys { get; } // 0x0000000188853B38-0x0000000188853BEC 
		public ValueEnumerator Values { get; } // 0x0000000188853B38-0x0000000188853BEC 
		public virtual double AsDouble { get; set; } // 0x0000000188853880-0x000000018885390C 0x0000000188854628-0x000000018885468C
		public virtual int AsInt { get; set; } // 0x0000000188853928-0x0000000188853944 0x00000001888546A0-0x00000001888546B8
		public virtual float AsFloat { get; set; } // 0x000000018885390C-0x0000000188853928 0x000000018885468C-0x00000001888546A0
		public virtual bool AsBool { get; set; } // 0x00000001888537E4-0x0000000188853880 0x00000001888545BC-0x0000000188854628
		public virtual long AsLong { get; set; } // 0x0000000188853944-0x0000000188853984 0x00000001888546B8-0x00000001888546E8
		public virtual JSONArray AsArray { get; } // 0x00000001888537A8-0x00000001888537E4 
		public virtual JSONObject AsObject { get; } // 0x0000000188853984-0x00000001888539C0 
		internal static StringBuilder EscapeBuilder { get; } // 0x0000000188853A84-0x0000000188853B38 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 49818
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get => default; } // 0x000000018426F724-0x000000018426F72C 
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x0000000188854858-0x00000001888548FC 
	
			// Nested types
			private enum Type // TypeDefIndex: 49817
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x0000000188854824-0x0000000188854858
			public Enumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x0000000183B109F0-0x0000000183B10A40
	
			// Methods
			public bool MoveNext() => default; // 0x00000001888547B4-0x0000000188854824
		}
	
		public struct ValueEnumerator // TypeDefIndex: 49819
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get => default; } // 0x0000000188867B98-0x0000000188867C78 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EBAC-0x000000018885EC44
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EAD8-0x000000018885EB78
			public ValueEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018885EB78-0x000000018885EBAC
	
			// Methods
			public bool MoveNext() => default; // 0x000000018885EAD0-0x000000018885EAD8
			public ValueEnumerator GetEnumerator() => default; // 0x0000000183D6D9B0-0x0000000183D6D9E0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 49820
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get => default; } // 0x000000018885EC44-0x000000018885EC84 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EBAC-0x000000018885EC44
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018885EAD8-0x000000018885EB78
			public KeyEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018885EB78-0x000000018885EBAC
	
			// Methods
			public bool MoveNext() => default; // 0x000000018885EAD0-0x000000018885EAD8
			public KeyEnumerator GetEnumerator() => default; // 0x0000000183D6D9B0-0x0000000183D6D9E0
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 49821
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x000000018885EED4-0x000000018885EF00 
			object IEnumerator.Current { get => default; } // 0x000000018885EE00-0x000000018885EE58 
	
			// Constructors
			public LinqEnumerator() {} // Dummy constructor
			internal LinqEnumerator(JSONNode aNode) {} // 0x000000018885EE58-0x000000018885EED4
	
			// Methods
			public bool MoveNext() => default; // 0x000000018885ED24-0x000000018885ED30
			public void Dispose() {} // 0x000000018885EC84-0x000000018885ECC0
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator() => default; // 0x000000018885ECC0-0x000000018885ED24
			public void Reset() {} // 0x000000018885ED30-0x000000018885ED9C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018885ED9C-0x000000018885EE00
		}
	
		// Constructors
		protected JSONNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x000000018350B670-0x000000018350B680
		public virtual void Add(JSONNode aItem) {} // 0x000000018885145C-0x00000001888514A4
		public virtual JSONNode Remove(string aKey) => default; // 0x0000000181002730-0x0000000181002740
		public virtual JSONNode Remove(int aIndex) => default; // 0x0000000181002730-0x0000000181002740
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x0000000183D51810-0x0000000183D51820
		public override string ToString() => default; // 0x0000000188852C2C-0x0000000188852CB0
		public virtual string ToString(int aIndent) => default; // 0x0000000188852CB0-0x0000000188852D40
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s) => default; // 0x0000000188853DA0-0x0000000188853E00
		public static implicit operator string(JSONNode d) => default; // 0x0000000188854274-0x00000001888542B4
		public static implicit operator JSONNode(double n) => default; // 0x00000001888543A0-0x00000001888543F0
		public static implicit operator double(JSONNode d) => default; // 0x0000000188853D60-0x0000000188853DA0
		public static implicit operator JSONNode(float n) => default; // 0x00000001888542B4-0x000000018885430C
		public static implicit operator float(JSONNode d) => default; // 0x0000000188854530-0x0000000188854570
		public static implicit operator JSONNode(int n) => default; // 0x0000000188853E78-0x0000000188853EC8
		public static implicit operator int(JSONNode d) => default; // 0x000000018885412C-0x000000018885416C
		public static implicit operator JSONNode(long n) => default; // 0x0000000188853F10-0x0000000188853FD0
		public static implicit operator long(JSONNode d) => default; // 0x00000001888544F0-0x0000000188854530
		public static implicit operator JSONNode(bool b) => default; // 0x0000000188853EC8-0x0000000188853F10
		public static implicit operator bool(JSONNode d) => default; // 0x0000000188854328-0x0000000188854368
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue) => default; // 0x0000000188854368-0x00000001888543A0
		public static bool operator ==(JSONNode a, object b) => default; // 0x0000000188853C78-0x0000000188853D60
		public static bool operator !=(JSONNode a, object b) => default; // 0x00000001888545A8-0x00000001888545BC
		public override bool Equals(object obj) => default; // 0x000000018232CE30-0x000000018232CE40
		public override int GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		internal static string Escape(string aText) => default; // 0x00000001888514A4-0x000000018885170C
		private static JSONNode ParseElement(string token, bool quoted) => default; // 0x0000000188851790-0x00000001888518E4
		public static JSONNode Parse(string aJSON) => default; // 0x00000001888518E4-0x0000000188851E74
		private static JSONNode GetContainer(JSONContainerType aType) => default; // 0x000000018885170C-0x0000000188851790
		public static implicit operator JSONNode(Vector2 aVec) => default; // 0x0000000188853FD0-0x000000018885406C
		public static implicit operator JSONNode(Vector3 aVec) => default; // 0x000000018885406C-0x000000018885412C
		public static implicit operator JSONNode(Vector4 aVec) => default; // 0x0000000188853E00-0x0000000188853E78
		public static implicit operator JSONNode(Quaternion aRot) => default; // 0x000000018885445C-0x00000001888544D4
		public static implicit operator JSONNode(Rect aRect) => default; // 0x00000001888541FC-0x0000000188854274
		public static implicit operator JSONNode(RectOffset aRect) => default; // 0x00000001888543F0-0x000000018885445C
		public static implicit operator Vector2(JSONNode aNode) => default; // 0x00000001888544D4-0x00000001888544F0
		public static implicit operator Vector3(JSONNode aNode) => default; // 0x0000000188854570-0x00000001888545A8
		public static implicit operator Vector4(JSONNode aNode) => default; // 0x00000001888541CC-0x00000001888541FC
		public static implicit operator Quaternion(JSONNode aNode) => default; // 0x000000018885416C-0x000000018885419C
		public static implicit operator Rect(JSONNode aNode) => default; // 0x000000018885419C-0x00000001888541CC
		public static implicit operator RectOffset(JSONNode aNode) => default; // 0x000000018885430C-0x0000000188854328
		public Vector2 ReadVector2(Vector2 aDefault) => default; // 0x00000001888525C0-0x00000001888526A8
		public Vector2 ReadVector2(string aXName, string aYName) => default; // 0x00000001888526A8-0x0000000188852748
		public Vector2 ReadVector2() => default; // 0x0000000188852748-0x0000000188852760
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x01FBEB93 */, string aYName = "y" /* Metadata: 0x01FBEB95 */) => default; // 0x00000001888533A4-0x000000018885349C
		public Vector3 ReadVector3(Vector3 aDefault) => default; // 0x0000000188852760-0x00000001888528DC
		public Vector3 ReadVector3(string aXName, string aYName, string aZName) => default; // 0x00000001888528DC-0x00000001888529C4
		public Vector3 ReadVector3() => default; // 0x00000001888529C4-0x0000000188852A14
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x01FBEB97 */, string aYName = "y" /* Metadata: 0x01FBEB99 */, string aZName = "z" /* Metadata: 0x01FBEB9B */) => default; // 0x000000018885349C-0x00000001888535DC
		public Vector4 ReadVector4(Vector4 aDefault) => default; // 0x0000000188852A14-0x0000000188852BF0
		public Vector4 ReadVector4() => default; // 0x0000000188852BF0-0x0000000188852C2C
		public JSONNode WriteVector4(Vector4 aVec) => default; // 0x00000001888535DC-0x00000001888537A8
		public Quaternion ReadQuaternion(Quaternion aDefault) => default; // 0x0000000188851F58-0x0000000188852134
		public Quaternion ReadQuaternion() => default; // 0x0000000188851F1C-0x0000000188851F58
		public JSONNode WriteQuaternion(Quaternion aRot) => default; // 0x0000000188852DD4-0x0000000188852FA0
		public Rect ReadRect(Rect aDefault) => default; // 0x00000001888523E4-0x00000001888525C0
		public Rect ReadRect() => default; // 0x00000001888523B0-0x00000001888523E4
		public JSONNode WriteRect(Rect aRect) => default; // 0x00000001888531D8-0x00000001888533A4
		public RectOffset ReadRectOffset(RectOffset aDefault) => default; // 0x0000000188852134-0x0000000188852348
		public RectOffset ReadRectOffset() => default; // 0x0000000188852348-0x00000001888523B0
		public JSONNode WriteRectOffset(RectOffset aRect) => default; // 0x0000000188852FA0-0x00000001888531D8
		public Matrix4x4 ReadMatrix() => default; // 0x0000000188851E74-0x0000000188851F1C
		public JSONNode WriteMatrix(Matrix4x4 aMatrix) => default; // 0x0000000188852D40-0x0000000188852DD4
	}

	public class JSONArray : JSONNode // TypeDefIndex: 49826
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public override JSONNodeType Tag { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override bool IsArray { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018885CA9C-0x000000018885CB3C 0x000000018885CB3C-0x000000018885CC10
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018885CA3C-0x000000018885CA9C 0x000000018885CC10-0x000000018885CC98
		public override int Count { get => default; } // 0x000000018885C9FC-0x000000018885CA3C 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__22))] get => default; } // 0x000000018885C98C-0x000000018885C9FC 
	
		// Constructors
		public JSONArray() {} // 0x000000018885C914-0x000000018885C98C
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018885C628-0x000000018885C6B8
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018885C5A0-0x000000018885C628
		public override JSONNode Remove(int aIndex) => default; // 0x000000018885C6B8-0x000000018885C75C
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018885C75C-0x000000018885C7B4
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885C7B4-0x000000018885C914
	}

	public class JSONObject : JSONNode // TypeDefIndex: 49829
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public override JSONNodeType Tag { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override bool IsObject { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018885E698-0x000000018885E758 0x000000018885E7E4-0x000000018885E8CC
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018885E758-0x000000018885E7E4 0x000000018885E8CC-0x000000018885E9B8
		public override int Count { get => default; } // 0x000000018885E658-0x000000018885E698 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__23))] get => default; } // 0x000000018885E5E8-0x000000018885E658 
	
		// Constructors
		public JSONObject() {} // 0x000000018885E570-0x000000018885E5E8
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018885DE80-0x000000018885DF24
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018885DD34-0x000000018885DE80
		public override JSONNode Remove(string aKey) => default; // 0x000000018885E190-0x000000018885E248
		public override JSONNode Remove(int aIndex) => default; // 0x000000018885DF24-0x000000018885DFE4
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018885DFE4-0x000000018885E190
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885E248-0x000000018885E570
	}

	public class JSONString : JSONNode // TypeDefIndex: 49830
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override bool IsString { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public JSONString() {} // Dummy constructor
		public JSONString(string aData) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885EA5C-0x000000018885EAC8
		public override bool Equals(object obj) => default; // 0x000000018885E9B8-0x000000018885EA5C
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 49831
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public override bool IsNumber { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x000000018885DC68-0x000000018885DCB4 0x000000018885DCB4-0x000000018885DD34
		public override double AsDouble { get => default; set {} } // 0x0000000183D61CF0-0x0000000183D61D00 0x0000000183D4E410-0x0000000183D4E420
		public override long AsLong { get => default; set {} } // 0x0000000183D6D990-0x0000000183D6D9A0 0x0000000183D6D9A0-0x0000000183D6D9B0
	
		// Constructors
		public JSONNumber() {} // Dummy constructor
		public JSONNumber(double aData) {} // 0x0000000183D4E410-0x0000000183D4E420
		public JSONNumber(string aData) {} // 0x000000018885CDA8-0x000000018885CDBC
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885DC34-0x000000018885DC68
		private static bool IsNumeric(object value) => default; // 0x000000018885DAEC-0x000000018885DC34
		public override bool Equals(object obj) => default; // 0x000000018885DA0C-0x000000018885DAE0
		public override int GetHashCode() => default; // 0x000000018885DAE0-0x000000018885DAEC
	}

	public class JSONBool : JSONNode // TypeDefIndex: 49832
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D51110-0x0000000183D51120 
		public override bool IsBoolean { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x000000018885CDBC-0x000000018885CE08 0x000000018885CE08-0x000000018885CE6C
		public override bool AsBool { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public JSONBool() {} // Dummy constructor
		public JSONBool(bool aData) {} // 0x0000000183D4E960-0x0000000183D4E970
		public JSONBool(string aData) {} // 0x000000018885CDA8-0x000000018885CDBC
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885CD3C-0x000000018885CDA8
		public override bool Equals(object obj) => default; // 0x000000018885CC98-0x000000018885CCF4
		public override int GetHashCode() => default; // 0x000000018885CCF4-0x000000018885CD3C
	}

	public class JSONNull : JSONNode // TypeDefIndex: 49833
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D51100-0x0000000183D51110 
		public override bool IsNull { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string Value { get => default; set {} } // 0x000000018885D9E0-0x000000018885DA0C 0x000000018350B670-0x000000018350B680
		public override bool AsBool { get => default; set {} } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
	
		// Constructors
		private JSONNull() {} // 0x000000018350B670-0x000000018350B680
		static JSONNull() {} // 0x000000018885D968-0x000000018885D9E0
	
		// Methods
		public static JSONNull CreateOrGet() => default; // 0x000000018885D85C-0x000000018885D8C8
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		public override bool Equals(object obj) => default; // 0x000000018885D8C8-0x000000018885D920
		public override int GetHashCode() => default; // 0x0000000181002730-0x0000000181002740
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885D920-0x000000018885D968
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 49834
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018885D374-0x000000018885D3D4 0x000000018885D724-0x000000018885D7B8
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018885D3D4-0x000000018885D444 0x000000018885D7B8-0x000000018885D85C
		public override int AsInt { get => default; set {} } // 0x000000018885D1AC-0x000000018885D214 0x000000018885D5B0-0x000000018885D628
		public override float AsFloat { get => default; set {} } // 0x000000018885D144-0x000000018885D1AC 0x000000018885D538-0x000000018885D5B0
		public override double AsDouble { get => default; set {} } // 0x000000018885D0DC-0x000000018885D144 0x000000018885D4C4-0x000000018885D538
		public override long AsLong { get => default; set {} } // 0x000000018885D214-0x000000018885D2FC 0x000000018885D628-0x000000018885D724
		public override bool AsBool { get => default; set {} } // 0x000000018885D074-0x000000018885D0DC 0x000000018885D454-0x000000018885D4C4
		public override JSONArray AsArray { get => default; } // 0x000000018885CFFC-0x000000018885D074 
		public override JSONObject AsObject { get => default; } // 0x000000018885D2FC-0x000000018885D374 
	
		// Constructors
		public JSONLazyCreator() {} // Dummy constructor
		public JSONLazyCreator(JSONNode aNode) {} // 0x0000000182E1A410-0x0000000182E1A440
		public JSONLazyCreator(JSONNode aNode, string aKey) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000183D60600-0x0000000183D60620
		private T Set<T>(T aVal)
			where T : JSONNode => default;
		public override void Add(JSONNode aItem) {} // 0x000000018885CF10-0x000000018885CFA4
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018885CE6C-0x000000018885CF10
		public static bool operator ==(JSONLazyCreator a, object b) => default; // 0x000000018885CFA4-0x000000018885CFB4
		public static bool operator !=(JSONLazyCreator a, object b) => default; // 0x000000018885D444-0x000000018885D454
		public override bool Equals(object obj) => default; // 0x000000018885CFA4-0x000000018885CFB4
		public override int GetHashCode() => default; // 0x0000000181002730-0x0000000181002740
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018885CFB4-0x000000018885CFFC
	}

	public static class JSON // TypeDefIndex: 49835
	{
		// Methods
		public static JSONNode Parse(string aJSON) => default; // 0x000000018885EAC8-0x000000018885EAD0
	}

	public enum JSONContainerType // TypeDefIndex: 49836
	{
		Array = 0,
		Object = 1
	}

	public static class HEU_TerrainUtility // TypeDefIndex: 49837
	{
		// Methods
		public static bool GenerateTerrainFromVolume(HEU_SessionBase session, ref HAPI_VolumeInfo volumeInfo, int geoID, int partID, GameObject gameObject, ref TerrainData terrainData, out Vector3 volumePositionOffset, ref Terrain terrain, string bakedMaterialPath) {
			volumePositionOffset = default;
			return default;
		} // 0x00000001888558B8-0x00000001888561F4
		public static void SetTerrainMaterial(Terrain terrain, string specifiedMaterialName, string bakedMaterialPath = "" /* Metadata: 0x01FBEBA2 */) {} // 0x0000000188858180-0x00000001888582EC
		public static string GetDefaultTerrainShaderName() => default; // 0x00000001888562E4-0x0000000188856364
		public static string GetDefaultTerrainMaterialPath() => default; // 0x0000000188856264-0x00000001888562E4
		public static float[] GetNormalizedHeightmapFromPartWithMinMax(HEU_SessionBase session, int geoID, int partID, int heightMapWidth, int heightMapHeight, ref float minHeight, ref float maxHeight, ref float heightRange, bool bUseHeightRangeOverride) => default; // 0x000000018885671C-0x000000018885679C
		public static int[,] GetDetailMapFromPart(HEU_SessionBase session, int geoID, int partID, out int detailResolution) {
			detailResolution = default;
			return default;
		} // 0x0000000188856364-0x00000001888563F4
		public static bool GetHeightmapFromPart(HEU_SessionBase session, int xLength, int yLength, int geoID, int partID, ref float[] heightValues, ref float minHeight, ref float maxHeight) => default; // 0x00000001888565A4-0x000000018885671C
		public static float[,] ConvertHeightMapHoudiniToUnity(int heightMapWidth, int heightMapHeight, float[] heightValues) => default; // 0x00000001888557DC-0x00000001888558B8
		public static float[,,] ConvertHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, List<float[]> heightFields) => default; // 0x0000000188855698-0x00000001888557DC
		public static float[,,] AppendConvertedHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, float[,,] existingAlphaMaps, List<float[]> heightFields, float[] strengths, List<int> alphaMapIndices) => default; // 0x0000000188854BE0-0x0000000188854DD8
		public static Vector3 GetVolumePositionOffset(HEU_SessionBase session, int geoID, int partID, Vector3 volumePosition, float terrainSizeX, float heightMapSize, int mapWidth, int mapHeight, float minHeight) => default; // 0x0000000188856B5C-0x0000000188856C48
		public static List<HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HEU_SessionBase session, int geoID, int partID) => default; // 0x0000000188856A68-0x0000000188856B5C
		public static void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, ref HEU_VolumeScatterTrees scatterTrees, bool throwWarningIfNoTileAttribute) {} // 0x000000018885733C-0x0000000188857EE8
		public static void ApplyScatterTrees(TerrainData terrainData, HEU_VolumeScatterTrees scatterTrees, int tileIndex) {} // 0x00000001888551AC-0x0000000188855698
		public static void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailPrototype detailPrototype) {} // 0x0000000188856F18-0x000000018885733C
		public static void PopulateDetailProperties(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailProperties detailProperties) {} // 0x0000000188856C48-0x0000000188856F18
		public static void ApplyDetailLayers(Terrain terrain, TerrainData terrainData, HEU_DetailProperties detailProperties, List<HEU_DetailPrototype> heuDetailPrototypes, List<int[,]> convertedDetailMaps) {} // 0x0000000188854DD8-0x00000001888551AC
		private static int GetTerrainLayerIndexByName(string layerName, TerrainLayer[] terrainLayers) => default; // 0x0000000188856864-0x00000001888569D0
		public static int GetTerrainLayerIndex(TerrainLayer layer, TerrainLayer[] terrainLayers) => default; // 0x00000001888569D0-0x0000000188856A68
		public static bool VolumeLayerHasAttributes(HEU_SessionBase session, int geoID, int partID) => default; // 0x00000001888582EC-0x000000018885847C
		public static HFLayerType GetHeightfieldLayerType(HEU_SessionBase session, int geoID, int partID, string volumeName) => default; // 0x0000000188856468-0x00000001888565A4
		public static float GetHeightRangeFromHeightfield(HEU_SessionBase session, int geoID, int partID) => default; // 0x00000001888563F4-0x0000000188856468
		public static string GetTerrainDataExportPathFromHeightfieldAttribute(HEU_SessionBase session, int geoID, int partID) => default; // 0x000000018885679C-0x0000000188856864
		public static float[] ResampleData(float[] data, int oldWidth, int oldHeight, int newWidth, int newHeight) => default; // 0x0000000188857EE8-0x0000000188858180
		public static bool GetAttributeTile(HEU_SessionBase session, int geoID, int partID, out int outTileAttribute) {
			outTileAttribute = default;
			return default;
		} // 0x00000001888561F4-0x0000000188856264
	}

	public interface IEquivable<T> // TypeDefIndex: 49838
	{
		// Methods
		bool IsEquivalentTo(T other);
	}

	public interface IEquivableWrapperClass<T> : IEquivable<T> // TypeDefIndex: 49839
		where T : class
	{
		// Methods
		bool IsNull();
	}

	internal class HEU_TestHelpers // TypeDefIndex: 49842
	{
		// Nested types
		public class RequireStruct<T> // TypeDefIndex: 49840
			where T : struct
		{
			// Constructors
			public RequireStruct() {}
		}
	
		public class RequireClass<T> // TypeDefIndex: 49841
			where T : class
		{
			// Constructors
			public RequireClass() {}
		}
	
		// Constructors
		public HEU_TestHelpers() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool AssertTrueLogEquivalent<T>(T a, T b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBA3 */, string optional2 = "" /* Metadata: 0x01FBEBA4 */, string optional3 = "" /* Metadata: 0x01FBEBA5 */, RequireStruct<T> _ = null)
			where T : struct => default;
		public static bool AssertTrueLogEquivalent(GameObject a, GameObject b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBA6 */, string optional2 = "" /* Metadata: 0x01FBEBA7 */, string optional3 = "" /* Metadata: 0x01FBEBA8 */) => default; // 0x00000001888585E0-0x00000001888586DC
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T> a, IEquivable<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBA9 */, string optional2 = "" /* Metadata: 0x01FBEBAA */, string optional3 = "" /* Metadata: 0x01FBEBAB */) => default;
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBAC */, string optional2 = "" /* Metadata: 0x01FBEBAD */, string optional3 = "" /* Metadata: 0x01FBEBAE */)
			where T : class => default;
		public static bool AssertTrueLogEquivalent(string a, string b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBAF */, string optional2 = "" /* Metadata: 0x01FBEBB0 */, string optional3 = "" /* Metadata: 0x01FBEBB1 */) => default; // 0x00000001888586DC-0x0000000188858794
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBB2 */, string optional2 = "" /* Metadata: 0x01FBEBB3 */, string optional3 = "" /* Metadata: 0x01FBEBB4 */, RequireStruct<T> _ = null)
			where T : struct => default;
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBB5 */, string optional2 = "" /* Metadata: 0x01FBEBB6 */, string optional3 = "" /* Metadata: 0x01FBEBB7 */, RequireClass<T> _ = null)
			where T : class => default;
		public static bool AssertTrueLogEquivalent<T>(List<IEquivable<T>> a, List<IEquivable<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBB8 */, string optional2 = "" /* Metadata: 0x01FBEBB9 */, string optional3 = "" /* Metadata: 0x01FBEBBA */) => default;
		public static bool AssertTrueLogEquivalent<T>(List<IEquivableWrapperClass<T>> a, List<IEquivableWrapperClass<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBBB */, string optional2 = "" /* Metadata: 0x01FBEBBC */, string optional3 = "" /* Metadata: 0x01FBEBBD */)
			where T : class => default;
		public static bool AssertTrueLogEquivalent<T>(T[] a, T[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBBE */, string optional2 = "" /* Metadata: 0x01FBEBBF */, string optional3 = "" /* Metadata: 0x01FBEBC0 */)
			where T : struct => default;
		public static bool AssertTrueLogEquivalent(string[] a, string[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBC1 */, string optional2 = "" /* Metadata: 0x01FBEBC2 */, string optional3 = "" /* Metadata: 0x01FBEBC3 */) => default; // 0x000000018885847C-0x00000001888585E0
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T>[] a, IEquivable<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBC4 */, string optional2 = "" /* Metadata: 0x01FBEBC5 */, string optional3 = "" /* Metadata: 0x01FBEBC6 */) => default;
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T>[] a, IEquivableWrapperClass<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBC7 */, string optional2 = "" /* Metadata: 0x01FBEBC8 */, string optional3 = "" /* Metadata: 0x01FBEBC9 */)
			where T : class => default;
		public static void PrintTestLogAndSetResult(bool expression, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x01FBEBCA */, string optional2 = "" /* Metadata: 0x01FBEBCB */, string optional3 = "" /* Metadata: 0x01FBEBCC */) {} // 0x0000000188858794-0x00000001888588D8
		public static bool ShouldBeTested<T>(T a, T b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBCD */, string subject = "" /* Metadata: 0x01FBEBCE */)
			where T : class => default;
		public static bool ShouldBeTested(GameObject a, GameObject b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBCF */, string subject = "" /* Metadata: 0x01FBEBD0 */) => default; // 0x00000001888588D8-0x0000000188858B18
		public static bool ShouldBeTested<T>(IEquivable<T> a, IEquivable<T> b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBD1 */, string subject = "" /* Metadata: 0x01FBEBD2 */) => default;
		public static bool ShouldBeTested<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBD3 */, string subject = "" /* Metadata: 0x01FBEBD4 */)
			where T : class => default;
		private static bool ShouldBeTested<T>(List<T> a, List<T> b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBD5 */, string subject = "" /* Metadata: 0x01FBEBD6 */) => default;
		public static bool ShouldBeTested<T>(T[] a, T[] b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBD7 */, string subject = "" /* Metadata: 0x01FBEBD8 */) => default;
		public static bool ShouldBeTested(string a, string b, ref bool bResult, string header = "" /* Metadata: 0x01FBEBD9 */, string subject = "" /* Metadata: 0x01FBEBDA */) => default; // 0x0000000188858B18-0x0000000188858BAC
		public static bool TestOutputObjectEquivalence(GameObject a, GameObject b) => default; // 0x0000000188858BAC-0x0000000188859204
	}

	public class Test_HAPI_AssetInfo : IEquivable<Test_HAPI_AssetInfo> // TypeDefIndex: 49843
	{
		// Fields
		public HAPI_AssetInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AssetInfo() {} // Dummy constructor
		public Test_HAPI_AssetInfo(HAPI_AssetInfo self) {} // 0x0000000183D64D80-0x0000000183D64DA0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AssetInfo other) => default; // 0x0000000188860560-0x000000018886073C
	}

	public static class Test_HAPI_AssetInfo_Extensions // TypeDefIndex: 49844
	{
		// Extension methods
		public static Test_HAPI_AssetInfo ToTestObject(this HAPI_AssetInfo self) => default; // 0x00000001888604FC-0x0000000188860560
	}

	public class Test_HAPI_NodeInfo : IEquivable<Test_HAPI_NodeInfo> // TypeDefIndex: 49845
	{
		// Fields
		public HAPI_NodeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_NodeInfo() {} // Dummy constructor
		public Test_HAPI_NodeInfo(HAPI_NodeInfo self) {} // 0x0000000183D6DA00-0x0000000183D6DA30
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_NodeInfo other) => default; // 0x0000000188860B9C-0x0000000188860DD0
	}

	public static class Test_HAPI_NodeInfo_Extensions // TypeDefIndex: 49846
	{
		// Extension methods
		public static Test_HAPI_NodeInfo ToTestObject(this HAPI_NodeInfo self) => default; // 0x0000000188860B2C-0x0000000188860B9C
	}

	public class Test_HAPI_ObjectInfo : IEquivable<Test_HAPI_ObjectInfo> // TypeDefIndex: 49847
	{
		// Fields
		public HAPI_ObjectInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ObjectInfo() {} // Dummy constructor
		public Test_HAPI_ObjectInfo(HAPI_ObjectInfo self) {} // 0x0000000183D64DF0-0x0000000183D64E10
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ObjectInfo other) => default; // 0x0000000188860E30-0x0000000188860F5C
	}

	public static class Test_HAPI_ObjectInfo_Extensions // TypeDefIndex: 49848
	{
		// Extension methods
		public static Test_HAPI_ObjectInfo ToTestObject(this HAPI_ObjectInfo self) => default; // 0x0000000188860DD0-0x0000000188860E30
	}

	public class Test_HAPI_Transform : IEquivable<Test_HAPI_Transform> // TypeDefIndex: 49849
	{
		// Fields
		public HAPI_Transform self; // 0x10
	
		// Constructors
		public Test_HAPI_Transform() {} // Dummy constructor
		public Test_HAPI_Transform(HAPI_Transform self) {} // 0x0000000188861778-0x000000018886179C
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_Transform other) => default; // 0x000000018886181C-0x00000001888618B0
	}

	public static class Test_HAPI_Transform_Extensions // TypeDefIndex: 49850
	{
		// Extension methods
		public static Test_HAPI_Transform ToTestObject(this HAPI_Transform self) => default; // 0x000000018886179C-0x000000018886181C
	}

	public class Test_HAPI_GeoInfo : IEquivable<Test_HAPI_GeoInfo> // TypeDefIndex: 49851
	{
		// Fields
		public HAPI_GeoInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_GeoInfo() {} // Dummy constructor
		public Test_HAPI_GeoInfo(HAPI_GeoInfo self) {} // 0x0000000183D64D60-0x0000000183D64D80
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_GeoInfo other) => default; // 0x00000001888608FC-0x0000000188860B2C
	}

	public static class Test_HAPI_GeoInfo_Extensions // TypeDefIndex: 49852
	{
		// Extension methods
		public static Test_HAPI_GeoInfo ToTestObject(this HAPI_GeoInfo self) => default; // 0x000000018886089C-0x00000001888608FC
	}

	public class Test_HAPI_AttributeInfo : IEquivable<Test_HAPI_AttributeInfo> // TypeDefIndex: 49853
	{
		// Fields
		public HAPI_AttributeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AttributeInfo() {} // Dummy constructor
		public Test_HAPI_AttributeInfo(HAPI_AttributeInfo self) {} // 0x0000000183D6D9E0-0x0000000183D6DA00
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AttributeInfo other) => default; // 0x0000000188860798-0x000000018886089C
	}

	public static class Test_HAPI_AttributeInfo_Extensions // TypeDefIndex: 49854
	{
		// Extension methods
		public static Test_HAPI_AttributeInfo ToTestObject(this HAPI_AttributeInfo self) => default; // 0x000000018886073C-0x0000000188860798
	}

	public class Test_HAPI_TransformEuler : IEquivable<Test_HAPI_TransformEuler> // TypeDefIndex: 49855
	{
		// Fields
		public HAPI_TransformEuler self; // 0x10
	
		// Constructors
		public Test_HAPI_TransformEuler() {} // Dummy constructor
		public Test_HAPI_TransformEuler(HAPI_TransformEuler self) {} // 0x0000000188861778-0x000000018886179C
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_TransformEuler other) => default; // 0x00000001888616A0-0x0000000188861778
	}

	public static class Test_HAPI_TransformEuler_Extensions // TypeDefIndex: 49856
	{
		// Extension methods
		public static Test_HAPI_TransformEuler ToTestObject(this HAPI_TransformEuler self) => default; // 0x0000000188861620-0x00000001888616A0
	}

	public class Test_HAPI_ParmInfo : IEquivable<Test_HAPI_ParmInfo> // TypeDefIndex: 49857
	{
		// Fields
		public HAPI_ParmInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ParmInfo() {} // Dummy constructor
		public Test_HAPI_ParmInfo(HAPI_ParmInfo self) {} // 0x0000000183D6DA30-0x0000000183D6DA90
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ParmInfo other) => default; // 0x0000000188860FFC-0x0000000188861620
	}

	public static class Test_HAPI_ParmInfo_Extensions // TypeDefIndex: 49858
	{
		// Extension methods
		public static Test_HAPI_ParmInfo ToTestObject(this HAPI_ParmInfo self) => default; // 0x0000000188860F5C-0x0000000188860FFC
	}

	public class Test_LODGroup : IEquivableWrapperClass<Test_LODGroup> // TypeDefIndex: 49859
	{
		// Fields
		public LODGroup self; // 0x10
	
		// Constructors
		public Test_LODGroup() {} // Dummy constructor
		public Test_LODGroup(LODGroup self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188861D40-0x0000000188861D90
		public bool IsEquivalentTo(Test_LODGroup other) => default; // 0x0000000188861B20-0x0000000188861D40
	}

	public static class Test_LODGroup_Extensions // TypeDefIndex: 49861
	{
		// Extension methods
		public static Test_LODGroup ToTestObject(this LODGroup self) => default; // 0x00000001888618B0-0x0000000188861910
		public static Test_LODGroup[] ToTestObject(this LODGroup[] self) => default; // 0x0000000188861A1C-0x0000000188861B20
		public static List<Test_LODGroup> ToTestObject(this List<LODGroup> self) => default; // 0x0000000188861910-0x0000000188861A1C
	}

	public class Test_Transform : IEquivableWrapperClass<Test_Transform> // TypeDefIndex: 49862
	{
		// Fields
		public Transform self; // 0x10
	
		// Constructors
		public Test_Transform() {} // Dummy constructor
		public Test_Transform(Transform self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188865374-0x00000001888653C4
		public bool IsEquivalentTo(Test_Transform other) => default; // 0x00000001888651F0-0x0000000188865374
	}

	public static class Test_Transform_Extensions // TypeDefIndex: 49864
	{
		// Extension methods
		public static Test_Transform ToTestObject(this Transform self) => default; // 0x0000000188864F80-0x0000000188864FE0
		public static Test_Transform[] ToTestObject(this Transform[] self) => default; // 0x00000001888650EC-0x00000001888651F0
		public static List<Test_Transform> ToTestObject(this List<Transform> self) => default; // 0x0000000188864FE0-0x00000001888650EC
	}

	public class Test_Material : IEquivableWrapperClass<Test_Material> // TypeDefIndex: 49865
	{
		// Fields
		public Material self; // 0x10
	
		// Constructors
		public Test_Material() {} // Dummy constructor
		public Test_Material(Material self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001888622D4-0x0000000188862324
		public bool IsEquivalentTo(Test_Material other) => default; // 0x0000000188862100-0x00000001888622D4
	}

	public static class Test_Material_Extensions // TypeDefIndex: 49867
	{
		// Extension methods
		public static Test_Material ToTestObject(this Material self) => default; // 0x0000000188861F74-0x0000000188861FD4
		public static Test_Material[] ToTestObject(this Material[] self) => default; // 0x0000000188861FD4-0x0000000188862100
		public static List<Test_Material> ToTestObject(this List<Material> self) => default; // 0x0000000188861E68-0x0000000188861F74
	}

	public class Test_Collider : IEquivableWrapperClass<Test_Collider> // TypeDefIndex: 49868
	{
		// Fields
		public Collider self; // 0x10
	
		// Constructors
		public Test_Collider() {} // Dummy constructor
		public Test_Collider(Collider self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188860140-0x0000000188860190
		public bool IsEquivalentTo(Test_Collider other) => default; // 0x000000018885FD60-0x0000000188860140
	}

	public static class Test_Collider_Extensions // TypeDefIndex: 49870
	{
		// Extension methods
		public static Test_Collider ToTestObject(this Collider self) => default; // 0x000000018885FD00-0x000000018885FD60
		public static Test_Collider[] ToTestObject(this Collider[] self) => default; // 0x000000018885FBFC-0x000000018885FD00
		public static List<Test_Collider> ToTestObject(this List<Collider> self) => default; // 0x000000018885FAF0-0x000000018885FBFC
	}

	public class Test_BoxCollider : IEquivableWrapperClass<Test_BoxCollider> // TypeDefIndex: 49871
	{
		// Fields
		public BoxCollider self; // 0x10
	
		// Constructors
		public Test_BoxCollider() {} // Dummy constructor
		public Test_BoxCollider(BoxCollider self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018885F658-0x000000018885F6A8
		public bool IsEquivalentTo(Test_BoxCollider other) => default; // 0x000000018885F4CC-0x000000018885F658
	}

	public static class Test_BoxCollider_Extensions // TypeDefIndex: 49873
	{
		// Extension methods
		public static Test_BoxCollider ToTestObject(this BoxCollider self) => default; // 0x000000018885F46C-0x000000018885F4CC
		public static Test_BoxCollider[] ToTestObject(this BoxCollider[] self) => default; // 0x000000018885F25C-0x000000018885F360
		public static List<Test_BoxCollider> ToTestObject(this List<BoxCollider> self) => default; // 0x000000018885F360-0x000000018885F46C
	}

	public class Test_SphereCollider : IEquivableWrapperClass<Test_SphereCollider> // TypeDefIndex: 49874
	{
		// Fields
		public SphereCollider self; // 0x10
	
		// Constructors
		public Test_SphereCollider() {} // Dummy constructor
		public Test_SphereCollider(SphereCollider self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188863918-0x0000000188863968
		public bool IsEquivalentTo(Test_SphereCollider other) => default; // 0x00000001888637B0-0x0000000188863918
	}

	public static class Test_SphereCollider_Extensions // TypeDefIndex: 49876
	{
		// Extension methods
		public static Test_SphereCollider ToTestObject(this SphereCollider self) => default; // 0x0000000188863644-0x00000001888636A4
		public static Test_SphereCollider[] ToTestObject(this SphereCollider[] self) => default; // 0x0000000188863540-0x0000000188863644
		public static List<Test_SphereCollider> ToTestObject(this List<SphereCollider> self) => default; // 0x00000001888636A4-0x00000001888637B0
	}

	public class Test_CapsuleCollider : IEquivableWrapperClass<Test_CapsuleCollider> // TypeDefIndex: 49877
	{
		// Fields
		public CapsuleCollider self; // 0x10
	
		// Constructors
		public Test_CapsuleCollider() {} // Dummy constructor
		public Test_CapsuleCollider(CapsuleCollider self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018885FAA0-0x000000018885FAF0
		public bool IsEquivalentTo(Test_CapsuleCollider other) => default; // 0x000000018885F918-0x000000018885FAA0
	}

	public static class Test_CapsuleCollider_Extensions // TypeDefIndex: 49879
	{
		// Extension methods
		public static Test_CapsuleCollider ToTestObject(this CapsuleCollider self) => default; // 0x000000018885F6A8-0x000000018885F708
		public static Test_CapsuleCollider[] ToTestObject(this CapsuleCollider[] self) => default; // 0x000000018885F814-0x000000018885F918
		public static List<Test_CapsuleCollider> ToTestObject(this List<CapsuleCollider> self) => default; // 0x000000018885F708-0x000000018885F814
	}

	public class Test_MeshCollider : IEquivableWrapperClass<Test_MeshCollider> // TypeDefIndex: 49880
	{
		// Fields
		public MeshCollider self; // 0x10
	
		// Constructors
		public Test_MeshCollider() {} // Dummy constructor
		public Test_MeshCollider(MeshCollider self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018886266C-0x00000001888626BC
		public bool IsEquivalentTo(Test_MeshCollider other) => default; // 0x0000000188862594-0x000000018886266C
	}

	public static class Test_MeshCollider_Extensions // TypeDefIndex: 49882
	{
		// Extension methods
		public static Test_MeshCollider ToTestObject(this MeshCollider self) => default; // 0x0000000188862324-0x0000000188862384
		public static Test_MeshCollider[] ToTestObject(this MeshCollider[] self) => default; // 0x0000000188862384-0x0000000188862488
		public static List<Test_MeshCollider> ToTestObject(this List<MeshCollider> self) => default; // 0x0000000188862488-0x0000000188862594
	}

	public class Test_Mesh : IEquivableWrapperClass<Test_Mesh> // TypeDefIndex: 49883
	{
		// Fields
		public Mesh self; // 0x10
	
		// Constructors
		public Test_Mesh() {} // Dummy constructor
		public Test_Mesh(Mesh self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001888634F0-0x0000000188863540
		public bool IsEquivalentTo(Test_Mesh other) => default; // 0x0000000188863134-0x00000001888634F0
	}

	public static class Test_Mesh_Extensions // TypeDefIndex: 49885
	{
		// Extension methods
		public static Test_Mesh ToTestObject(this Mesh self) => default; // 0x0000000188862EC4-0x0000000188862F24
		public static Test_Mesh[] ToTestObject(this Mesh[] self) => default; // 0x0000000188863030-0x0000000188863134
		public static List<Test_Mesh> ToTestObject(this List<Mesh> self) => default; // 0x0000000188862F24-0x0000000188863030
	}

	public class Test_MeshRenderer : IEquivableWrapperClass<Test_MeshRenderer> // TypeDefIndex: 49886
	{
		// Fields
		public MeshRenderer self; // 0x10
	
		// Constructors
		public Test_MeshRenderer() {} // Dummy constructor
		public Test_MeshRenderer(MeshRenderer self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188862E74-0x0000000188862EC4
		public bool IsEquivalentTo(Test_MeshRenderer other) => default; // 0x0000000188862D50-0x0000000188862E74
	}

	public static class Test_MeshRenderer_Extensions // TypeDefIndex: 49888
	{
		// Extension methods
		public static Test_MeshRenderer ToTestObject(this MeshRenderer self) => default; // 0x0000000188862AE0-0x0000000188862B40
		public static Test_MeshRenderer[] ToTestObject(this MeshRenderer[] self) => default; // 0x0000000188862C4C-0x0000000188862D50
		public static List<Test_MeshRenderer> ToTestObject(this List<MeshRenderer> self) => default; // 0x0000000188862B40-0x0000000188862C4C
	}

	public class Test_MeshFilter : IEquivableWrapperClass<Test_MeshFilter> // TypeDefIndex: 49889
	{
		// Fields
		public MeshFilter self; // 0x10
	
		// Constructors
		public Test_MeshFilter() {} // Dummy constructor
		public Test_MeshFilter(MeshFilter self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188862A90-0x0000000188862AE0
		public bool IsEquivalentTo(Test_MeshFilter other) => default; // 0x000000018886292C-0x0000000188862A90
	}

	public static class Test_MeshFilter_Extensions // TypeDefIndex: 49891
	{
		// Extension methods
		public static Test_MeshFilter ToTestObject(this MeshFilter self) => default; // 0x00000001888628CC-0x000000018886292C
		public static Test_MeshFilter[] ToTestObject(this MeshFilter[] self) => default; // 0x00000001888627C8-0x00000001888628CC
		public static List<Test_MeshFilter> ToTestObject(this List<MeshFilter> self) => default; // 0x00000001888626BC-0x00000001888627C8
	}

	public class Test_LayerMask : IEquivable<Test_LayerMask> // TypeDefIndex: 49892
	{
		// Fields
		public LayerMask self; // 0x10
	
		// Constructors
		public Test_LayerMask() {} // Dummy constructor
		public Test_LayerMask(LayerMask self) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public bool IsEquivalentTo(Test_LayerMask other) => default; // 0x0000000188861DD4-0x0000000188861E68
	}

	public static class Test_LayerMask_Extensions // TypeDefIndex: 49893
	{
		// Extension methods
		public static Test_LayerMask ToTestObject(this LayerMask self) => default; // 0x0000000188861D90-0x0000000188861DD4
	}

	public class Test_Gradient : IEquivableWrapperClass<Test_Gradient> // TypeDefIndex: 49894
	{
		// Fields
		public Gradient self; // 0x10
	
		// Constructors
		public Test_Gradient() {} // Dummy constructor
		public Test_Gradient(Gradient self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001825EB8A0-0x00000001825EB8B0
		public bool IsEquivalentTo(Test_Gradient other) => default; // 0x0000000188860400-0x00000001888604FC
	}

	public static class Test_Gradient_Extensions // TypeDefIndex: 49896
	{
		// Extension methods
		public static Test_Gradient ToTestObject(this Gradient self) => default; // 0x00000001888603A0-0x0000000188860400
		public static Test_Gradient[] ToTestObject(this Gradient[] self) => default; // 0x000000018886029C-0x00000001888603A0
		public static List<Test_Gradient> ToTestObject(this List<Gradient> self) => default; // 0x0000000188860190-0x000000018886029C
	}

	public class Test_AnimationCurve : IEquivableWrapperClass<Test_AnimationCurve> // TypeDefIndex: 49897
	{
		// Fields
		public AnimationCurve self; // 0x10
	
		// Constructors
		public Test_AnimationCurve() {} // Dummy constructor
		public Test_AnimationCurve(AnimationCurve self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001825EB8A0-0x00000001825EB8B0
		public bool IsEquivalentTo(Test_AnimationCurve other) => default; // 0x000000018885F170-0x000000018885F25C
	}

	public static class Test_AnimationCurve_Extensions // TypeDefIndex: 49899
	{
		// Extension methods
		public static Test_AnimationCurve ToTestObject(this AnimationCurve self) => default; // 0x000000018885EF00-0x000000018885EF60
		public static Test_AnimationCurve[] ToTestObject(this AnimationCurve[] self) => default; // 0x000000018885EF60-0x000000018885F064
		public static List<Test_AnimationCurve> ToTestObject(this List<AnimationCurve> self) => default; // 0x000000018885F064-0x000000018885F170
	}

	public class Test_TerrainLayer : IEquivableWrapperClass<Test_TerrainLayer> // TypeDefIndex: 49900
	{
		// Fields
		public TerrainLayer self; // 0x10
	
		// Constructors
		public Test_TerrainLayer() {} // Dummy constructor
		public Test_TerrainLayer(TerrainLayer self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188864738-0x0000000188864788
		public bool IsEquivalentTo(Test_TerrainLayer other) => default; // 0x0000000188864370-0x0000000188864738
	}

	public static class Test_TerrainLayer_Extensions // TypeDefIndex: 49902
	{
		// Extension methods
		public static Test_TerrainLayer ToTestObject(this TerrainLayer self) => default; // 0x0000000188864100-0x0000000188864160
		public static Test_TerrainLayer[] ToTestObject(this TerrainLayer[] self) => default; // 0x000000018886426C-0x0000000188864370
		public static List<Test_TerrainLayer> ToTestObject(this List<TerrainLayer> self) => default; // 0x0000000188864160-0x000000018886426C
	}

	public class Test_Texture2D : IEquivableWrapperClass<Test_Texture2D> // TypeDefIndex: 49903
	{
		// Fields
		public Texture2D self; // 0x10
	
		// Constructors
		public Test_Texture2D() {} // Dummy constructor
		public Test_Texture2D(Texture2D self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188864F30-0x0000000188864F80
		public bool IsEquivalentTo(Test_Texture2D other) => default; // 0x0000000188864E04-0x0000000188864F30
	}

	public static class Test_Texture2D_Extensions // TypeDefIndex: 49905
	{
		// Extension methods
		public static Test_Texture2D ToTestObject(this Texture2D self) => default; // 0x0000000188864B94-0x0000000188864BF4
		public static Test_Texture2D[] ToTestObject(this Texture2D[] self) => default; // 0x0000000188864BF4-0x0000000188864CF8
		public static List<Test_Texture2D> ToTestObject(this List<Texture2D> self) => default; // 0x0000000188864CF8-0x0000000188864E04
	}

	public class Test_TreeInstance : IEquivable<Test_TreeInstance> // TypeDefIndex: 49906
	{
		// Fields
		public TreeInstance self; // 0x10
	
		// Constructors
		public Test_TreeInstance() {} // Dummy constructor
		public Test_TreeInstance(TreeInstance self) {} // 0x0000000183D6D9E0-0x0000000183D6DA00
	
		// Methods
		public bool IsEquivalentTo(Test_TreeInstance other) => default; // 0x0000000188865630-0x00000001888657C8
	}

	public static class Test_TreeInstance_Extensions // TypeDefIndex: 49908
	{
		// Extension methods
		public static Test_TreeInstance ToTestObject(this TreeInstance self) => default; // 0x00000001888654C8-0x0000000188865524
		public static Test_TreeInstance[] ToTestObject(this TreeInstance[] self) => default; // 0x00000001888653C4-0x00000001888654C8
		public static List<Test_TreeInstance> ToTestObject(this List<TreeInstance> self) => default; // 0x0000000188865524-0x0000000188865630
	}

	public class Test_TerrainData : IEquivableWrapperClass<Test_TerrainData> // TypeDefIndex: 49909
	{
		// Fields
		public TerrainData self; // 0x10
	
		// Constructors
		public Test_TerrainData() {} // Dummy constructor
		public Test_TerrainData(TerrainData self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001888640B0-0x0000000188864100
		public bool IsEquivalentTo(Test_TerrainData other) => default; // 0x0000000188863BD8-0x00000001888640B0
	}

	public static class Test_TerrainData_Extensions // TypeDefIndex: 49911
	{
		// Extension methods
		public static Test_TerrainData ToTestObject(this TerrainData self) => default; // 0x0000000188863B78-0x0000000188863BD8
		public static Test_TerrainData[] ToTestObject(this TerrainData[] self) => default; // 0x0000000188863A74-0x0000000188863B78
		public static List<Test_TerrainData> ToTestObject(this List<TerrainData> self) => default; // 0x0000000188863968-0x0000000188863A74
	}

	public class Test_Terrain : IEquivableWrapperClass<Test_Terrain> // TypeDefIndex: 49912
	{
		// Fields
		public Terrain self; // 0x10
	
		// Constructors
		public Test_Terrain() {} // Dummy constructor
		public Test_Terrain(Terrain self) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsNull() => default; // 0x0000000188864B44-0x0000000188864B94
		public bool IsEquivalentTo(Test_Terrain other) => default; // 0x00000001888649F8-0x0000000188864B44
	}

	public static class Test_Terrain_Extensions // TypeDefIndex: 49914
	{
		// Extension methods
		public static Test_Terrain ToTestObject(this Terrain self) => default; // 0x0000000188864788-0x00000001888647E8
		public static Test_Terrain[] ToTestObject(this Terrain[] self) => default; // 0x00000001888647E8-0x00000001888648EC
		public static List<Test_Terrain> ToTestObject(this List<Terrain> self) => default; // 0x00000001888648EC-0x00000001888649F8
	}

	[Serializable]
	internal class HEU_ToolsInfo : ScriptableObject, IEquivable<HEU_ToolsInfo> // TypeDefIndex: 49917
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
		public enum PaintMergeMode // TypeDefIndex: 49915
		{
			REPLACE = 0,
			ADD = 1,
			SUBTRACT = 2,
			MULTIPLY = 3
		}
	
		public enum PaintMeshVisibility // TypeDefIndex: 49916
		{
			AUTO = 0,
			SHOW = 1,
			HIDE = 2
		}
	
		// Constructors
		public HEU_ToolsInfo() {} // 0x0000000188859748-0x0000000188859848
	
		// Methods
		public bool IsEquivalentTo(HEU_ToolsInfo other) => default; // 0x0000000188859204-0x0000000188859748
	}

	public enum HFLayerType // TypeDefIndex: 49918
	{
		DEFAULT = 0,
		HEIGHT = 1,
		MASK = 2,
		DETAIL = 3
	}

	[Serializable]
	public class HEU_VolumeLayer : IEquivable<HEU_VolumeLayer> // TypeDefIndex: 49919
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
		public HEU_VolumeLayer() {} // 0x0000000183D561E0-0x0000000183D561F0
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeLayer other) => default; // 0x000000018885BFF0-0x000000018885C2CC
	}

	public class HEU_VolumeScatterTrees : IEquivable<HEU_VolumeScatterTrees> // TypeDefIndex: 49920
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
		public HEU_VolumeScatterTrees() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeScatterTrees other) => default; // 0x000000018885C2CC-0x000000018885C5A0
	}

	public class HEU_TreePrototypeInfo : IEquivable<HEU_TreePrototypeInfo> // TypeDefIndex: 49921
	{
		// Fields
		public string _prefabPath; // 0x10
		public float _bendfactor; // 0x18
	
		// Constructors
		public HEU_TreePrototypeInfo() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsEquivalentTo(HEU_TreePrototypeInfo other) => default; // 0x0000000188859848-0x000000018885995C
	}

	public class HEU_DetailProperties : IEquivable<HEU_DetailProperties> // TypeDefIndex: 49922
	{
		// Fields
		public float _detailDistance; // 0x10
		public float _detailDensity; // 0x14
		public int _detailResolution; // 0x18
		public int _detailResolutionPerPatch; // 0x1C
	
		// Constructors
		public HEU_DetailProperties() {} // 0x0000000183D6D970-0x0000000183D6D990
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailProperties other) => default; // 0x00000001888548FC-0x0000000188854A5C
	}

	public class HEU_DetailPrototype : IEquivable<HEU_DetailPrototype> // TypeDefIndex: 49923
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
		public HEU_DetailPrototype() {} // 0x0000000188854B28-0x0000000188854BE0
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailPrototype other) => default; // 0x0000000188854A5C-0x0000000188854B28
	}

	public class HEU_VolumeCache : ScriptableObject, IHEU_VolumeCache, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_VolumeCache> // TypeDefIndex: 49924
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
		public List<HEU_VolumeLayer> Layers { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int TileIndex { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public string ObjectName { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public string GeoName { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public TerrainData TerrainData { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public HEU_VolumeScatterTrees ScatterTrees { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public HEU_DetailProperties DetailProperties { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public bool IsDirty { get => default; set {} } // 0x0000000183D4F570-0x0000000183D4F580 0x0000000183D4F590-0x0000000183D4F5A0
		public bool UIExpanded { get => default; set {} } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Constructors
		public HEU_VolumeCache() {} // 0x000000018885BF6C-0x000000018885BFF0
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x000000018885A4BC-0x000000018885A550
		public void Recook() {} // 0x000000018885B5A8-0x000000018885B610
		public void ResetParameters() {} // 0x000000018885B610-0x000000018885B77C
		public HEU_VolumeLayer GetLayer(string layerName) => default; // 0x000000018885A310-0x000000018885A450
		public void PopulatePreset(HEU_VolumeCachePreset cachePreset) {} // 0x000000018885B2E4-0x000000018885B56C
		public bool ApplyPreset(HEU_VolumeCachePreset volumeCachePreset) => default; // 0x000000018885995C-0x0000000188859BEC
		internal static List<HEU_VolumeCache> UpdateVolumeCachesFromParts(HEU_SessionBase session, HEU_GeoNode ownerNode, List<HEU_PartData> volumeParts, List<HEU_VolumeCache> volumeCaches) => default; // 0x000000018885B880-0x000000018885BF6C
		internal void Initialize(HEU_GeoNode ownerNode, int tileIndex) {} // 0x000000018885A550-0x000000018885A640
		internal void StartUpdateLayers() {} // 0x000000018885B77C-0x000000018885B7F4
		internal void FinishUpdateLayers() {} // 0x0000000188859FAC-0x0000000188859FDC
		private void GetPartLayerAttributes(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer) {} // 0x000000018885A450-0x000000018885A4BC
		private bool LoadLayerTextureFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, out Texture2D outTexture) {
			outTexture = default;
			return default;
		} // 0x000000018885B0A0-0x000000018885B190
		private bool LoadLayerFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue) => default; // 0x000000018885ABA8-0x000000018885ACA0
		private bool LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue) => default; // 0x000000018885AA3C-0x000000018885ABA8
		private bool LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue) => default; // 0x000000018885B190-0x000000018885B2A8
		internal void UpdateLayerFromPart(HEU_SessionBase session, HEU_PartData part) {} // 0x000000018885B7F4-0x000000018885B880
		internal void GenerateTerrainWithAlphamaps(HEU_SessionBase session, HEU_HoudiniAsset houdiniAsset, bool bRebuild) {} // 0x0000000188859FDC-0x000000018885A310
		public void LoadLayerPropertiesFromAttributes(HEU_SessionBase session, int geoID, int partID, TerrainLayer terrainLayer, bool bNewTerrainLayer, Texture2D defaultTexture) {} // 0x000000018885ACA0-0x000000018885B0A0
		internal void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, bool throwWarningIfNoTileAttribute) {} // 0x000000018885B56C-0x000000018885B5A8
		internal void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer) {} // 0x000000018885B2A8-0x000000018885B2E4
		internal void CopyValuesTo(HEU_VolumeCache destCache) {} // 0x0000000188859D68-0x0000000188859FAC
		internal static void CopyDetailProperties(HEU_DetailProperties srcProp, HEU_DetailProperties destProp) {} // 0x0000000188859BEC-0x0000000188859C1C
		internal static void CopyLayer(HEU_VolumeLayer srcLayer, HEU_VolumeLayer destLayer) {} // 0x0000000188859C1C-0x0000000188859CF8
		internal static void CopyPrototype(HEU_DetailPrototype srcProto, HEU_DetailPrototype destProto) {} // 0x0000000188859CF8-0x0000000188859D68
		internal static Texture2D LoadDefaultSplatTexture() => default; // 0x000000018885A9D4-0x000000018885AA3C
		internal static Texture2D LoadAssetTexture(string path) => default; // 0x000000018885A908-0x000000018885A9D4
		public bool IsEquivalentTo(HEU_VolumeCache other) => default; // 0x000000018885A640-0x000000018885A908
	}
}
