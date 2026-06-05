/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using HoudiniEngineUnity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Splines;
using UnityEngine.Tilemaps;

// Image 18: HoudiniEngineUnity.dll - Assembly: HoudiniEngineUnity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 50457-50903

internal sealed class __f__AnonymousType0<_owner_j__TPar, _houdiniVersionRequired_j__TPar> // TypeDefIndex: 50458
{
	// Fields
	private readonly _owner_j__TPar _owner_i__Field;
	private readonly _houdiniVersionRequired_j__TPar _houdiniVersionRequired_i__Field;

	// Properties
	public _owner_j__TPar owner { get => default; }
	public _houdiniVersionRequired_j__TPar houdiniVersionRequired { get => default; }

	// Constructors
	public __f__AnonymousType0() {} // Dummy constructor
	public __f__AnonymousType0(_owner_j__TPar owner, _houdiniVersionRequired_j__TPar houdiniVersionRequired) {}

	// Methods
	public override bool Equals(object value) => default;
	public override int GetHashCode() => default;
	public override string ToString() => default;
}

public class HEU_BoundingVolume : MonoBehaviour // TypeDefIndex: 50459
{
	// Properties
	public Collider BoundingCollider { get => default; } // 0x000000018A8E79DC-0x000000018A8E7A18 

	// Constructors
	public HEU_BoundingVolume() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	public List<GameObject> GetAllIntersectingObjects() => default; // 0x000000018A8E77A4-0x000000018A8E79DC
}

public class HEU_ExampleEvergreenQuery // TypeDefIndex: 50460
{
	// Constructors
	public HEU_ExampleEvergreenQuery() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public static void StartQuery() {} // 0x000000018A8ECC78-0x000000018A8ECE58
	public static HEU_HoudiniAsset QueryHoudiniAsset(GameObject rootGO) => default; // 0x000000018A8EC970-0x000000018A8ECAEC
	public static void CookAsset(HEU_HoudiniAsset houdiniAsset) {} // 0x000000018A8EC650-0x000000018A8EC664
	public static void ChangeParmsAndCook(HEU_HoudiniAsset houdiniAsset) {} // 0x000000018A8EC2E0-0x000000018A8EC650
	public static void QueryObjects(HEU_HoudiniAsset houdiniAsset) {} // 0x000000018A8ECAEC-0x000000018A8ECB68
	public static void QueryGeoParts(HEU_SessionBase session, ref HAPI_GeoInfo geoInfo) {} // 0x000000018A8EC8AC-0x000000018A8EC970
	public static void QueryPartAttributeByOwner(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner owner, int count, StringBuilder sb) {} // 0x000000018A8ECB68-0x000000018A8ECC78
	public static void QueryAttributeByStorageType(HEU_SessionBase session, int geoID, int partID, ref HAPI_AttributeInfo attrInfo, string attrName) {} // 0x000000018A8EC664-0x000000018A8EC7E0
	public static void QueryAttribute(HEU_HoudiniAsset houdiniAsset, string objName, string geoName, int partID, string attrName) {} // 0x000000018A8EC7E0-0x000000018A8EC8AC
}

public class HEU_ExampleInstanceCustomAttribute : MonoBehaviour // TypeDefIndex: 50461
{
	// Constructors
	public HEU_ExampleInstanceCustomAttribute() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	private void InstancerCallback() {} // 0x000000018A8ECE58-0x000000018A8ED1D8
	private static void LogArray<T>(string name, T[] arr, int tupleSize) {}
	private static void LogAttr(HEU_OutputAttribute outAttr) {} // 0x000000018A8ED1D8-0x000000018A8ED304
}

public class HEU_ScriptCallbackExample : MonoBehaviour // TypeDefIndex: 50462
{
	// Fields
	public string _msg; // 0x18

	// Constructors
	public HEU_ScriptCallbackExample() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	private void AssetCallbackWithMsg(string msg) {} // 0x000000018A9039B4-0x000000018A903A38
	private void AssetCallbackNoMsg() {} // 0x000000018A903960-0x000000018A9039B4
}

public class HEU_ScriptMeshInputUVLayoutExample // TypeDefIndex: 50464
{
	// Nested types
	public enum OutputMode // TypeDefIndex: 50463
	{
		COPY = 0,
		REPLACE = 1
	}

	// Constructors
	public HEU_ScriptMeshInputUVLayoutExample() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public static void ApplyUVLayoutTo(GameObject[] gameObjects, OutputMode outputMode, string output_name_suffix) {} // 0x000000018A903A38-0x000000018A903B98
}

public class HEU_ScriptParameterExample : MonoBehaviour // TypeDefIndex: 50465
{
	// Fields
	public GameObject _evergreenGameObject; // 0x18
	private HEU_HoudiniAsset _evergreenAsset; // 0x20
	public float _updateRate; // 0x28
	public float _scale; // 0x2C

	// Constructors
	public HEU_ScriptParameterExample() {} // 0x000000018A903B98-0x000000018A903BB0
}

public class HEU_AssetEventReceiverTest : MonoBehaviour // TypeDefIndex: 50466
{
	// Constructors
	public HEU_AssetEventReceiverTest() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	public void ReloadCallback(HEU_ReloadEventData Data) {} // 0x000000018A8E6734-0x000000018A8E6898
	public void CookedCallback(HEU_CookedEventData Data) {} // 0x000000018A8E65D0-0x000000018A8E6734
	public void BakedCallback(HEU_BakedEventData Data) {} // 0x000000018A8E646C-0x000000018A8E65D0
}

namespace HoudiniEngineUnity
{
	public enum HEU_AssetEventType // TypeDefIndex: 50467
	{
		UNKNOWN = 0,
		RELOAD = 1,
		COOK = 2,
		BAKE_NEW = 3,
		BAKE_UPDATE = 4
	}

	public class HEU_AssetEventData // TypeDefIndex: 50468
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public bool CookSuccess; // 0x18
		public List<GameObject> OutputObjects; // 0x20
		public HEU_AssetEventType EventType; // 0x28
	
		// Constructors
		public HEU_AssetEventData() {} // Dummy constructor
		public HEU_AssetEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects) {} // 0x00000001851974C0-0x00000001851974F0
	}

	public class HEU_ReloadEventData : HEU_AssetEventData // TypeDefIndex: 50469
	{
		// Constructors
		public HEU_ReloadEventData() {} // Dummy constructor
		public HEU_ReloadEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects) {} // 0x000000018A90393C-0x000000018A903960
	}

	public class HEU_CookedEventData : HEU_AssetEventData // TypeDefIndex: 50470
	{
		// Constructors
		public HEU_CookedEventData() {} // Dummy constructor
		public HEU_CookedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects) {} // 0x000000018A8E7A54-0x000000018A8E7A78
	}

	public class HEU_BakedEventData : HEU_AssetEventData // TypeDefIndex: 50471
	{
		// Fields
		public bool IsNewBake; // 0x30
	
		// Constructors
		public HEU_BakedEventData() {} // Dummy constructor
		public HEU_BakedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects, bool isNewBake) {} // 0x000000018A8E7774-0x000000018A8E77A4
	}

	public class HEU_PreAssetEventData // TypeDefIndex: 50472
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public HEU_AssetEventType AssetType; // 0x18
	
		// Constructors
		public HEU_PreAssetEventData() {} // Dummy constructor
		public HEU_PreAssetEventData(HEU_HoudiniAsset asset, HEU_AssetEventType assetType) {} // 0x00000001845D7850-0x00000001845D7870
	}

	[Serializable]
	public class HEU_ReloadDataEvent : UnityEvent<HEU_ReloadEventData> // TypeDefIndex: 50473
	{
		// Constructors
		public HEU_ReloadDataEvent() {} // 0x000000018A903900-0x000000018A90393C
	}

	[Serializable]
	public class HEU_CookedDataEvent : UnityEvent<HEU_CookedEventData> // TypeDefIndex: 50474
	{
		// Constructors
		public HEU_CookedDataEvent() {} // 0x000000018A8E7A18-0x000000018A8E7A54
	}

	[Serializable]
	public class HEU_BakedDataEvent : UnityEvent<HEU_BakedEventData> // TypeDefIndex: 50475
	{
		// Constructors
		public HEU_BakedDataEvent() {} // 0x000000018A8E7738-0x000000018A8E7774
	}

	[Serializable]
	public class HEU_PreAssetEvent : UnityEvent<HEU_PreAssetEventData> // TypeDefIndex: 50476
	{
		// Constructors
		public HEU_PreAssetEvent() {} // 0x000000018A903804-0x000000018A903840
	}

	[Serializable]
	public class HEU_AssetPreset // TypeDefIndex: 50477
	{
		// Fields
		public char[] _identifier; // 0x10
		public int _version; // 0x18
		public string _assetOPName; // 0x20
		public byte[] _parameterPreset; // 0x28
		public List<string> _curveNames; // 0x30
		public List<byte[]> _curvePresets; // 0x38
		public List<HEU_InputPreset> inputPresets; // 0x40
		public List<HEU_VolumeCachePreset> volumeCachePresets; // 0x48
	
		// Constructors
		public HEU_AssetPreset() {} // 0x000000018A8E7444-0x000000018A8E759C
	}

	[Serializable]
	public class HEU_InputPreset // TypeDefIndex: 50478
	{
		// Fields
		internal HEU_InputNode.InputObjectType _inputObjectType; // 0x10
		public List<HEU_InputObjectPreset> _inputObjectPresets; // 0x18
		public string _inputAssetName; // 0x20
		public int _inputIndex; // 0x28
		public string _inputName; // 0x30
		public bool _keepWorldTransform; // 0x38
		public bool _packGeometryBeforeMerging; // 0x39
		public List<HEU_InputAssetPreset> _inputAssetPresets; // 0x40
	
		// Properties
		public HEU_InputObjectTypeWrapper InputObjectType { get => default; set {} } // 0x000000018A9037D8-0x000000018A9037E4 0x000000018A9037E4-0x000000018A903804
	
		// Constructors
		public HEU_InputPreset() {} // 0x000000018A903718-0x000000018A9037D8
	}

	[Serializable]
	public class HEU_InputObjectPreset // TypeDefIndex: 50479
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
		public HEU_InputObjectPreset() {} // 0x000000018A9036B8-0x000000018A903718
	}

	[Serializable]
	public class HEU_InputAssetPreset // TypeDefIndex: 50480
	{
		// Fields
		public string _gameObjectName; // 0x10
	
		// Constructors
		public HEU_InputAssetPreset() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_VolumeLayerPreset // TypeDefIndex: 50481
	{
		// Fields
		public string _layerName; // 0x10
		public float _strength; // 0x18
		public bool _uiExpanded; // 0x1C
		public int _tile; // 0x20
	
		// Constructors
		public HEU_VolumeLayerPreset() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_VolumeCachePreset // TypeDefIndex: 50482
	{
		// Fields
		public string _objName; // 0x10
		public string _geoName; // 0x18
		public bool _uiExpanded; // 0x20
		public List<HEU_VolumeLayerPreset> _volumeLayersPresets; // 0x28
		public string _terrainDataPath; // 0x30
		public int _tile; // 0x38
	
		// Constructors
		public HEU_VolumeCachePreset() {} // 0x000000018A903FC8-0x000000018A904040
	}

	[Serializable]
	internal class HEU_RecookPreset // TypeDefIndex: 50483
	{
		// Fields
		public List<HEU_VolumeCachePreset> _volumeCachePresets; // 0x10
		public List<HEU_InputPreset> _inputPresets; // 0x18
	
		// Constructors
		public HEU_RecookPreset() {} // 0x000000018A903840-0x000000018A903900
	}

	public static class HEU_AssetPresetUtility // TypeDefIndex: 50484
	{
		// Fields
		public static char[] PRESET_IDENTIFIER; // 0x00
		public static int PRESET_VERSION; // 0x08
	
		// Constructors
		static HEU_AssetPresetUtility() {} // 0x000000018A8E73C0-0x000000018A8E7444
	
		// Methods
		public static void SaveAssetPresetToFile(HEU_HoudiniAsset asset, string filePath) {} // 0x000000018A8E6E44-0x000000018A8E73C0
		public static void LoadPresetFileIntoAssetAndCook(HEU_HoudiniAsset asset, string filePath) {} // 0x000000018A8E6898-0x000000018A8E6E44
	}

	public class HEU_Vector3SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 50485
	{
		// Constructors
		public HEU_Vector3SerializationSurrogate() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context) {} // 0x000000018A903D80-0x000000018A903E48
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) => default; // 0x000000018A903E48-0x000000018A903FC8
	}

	public class HEU_Vector2SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 50486
	{
		// Constructors
		public HEU_Vector2SerializationSurrogate() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context) {} // 0x000000018A903BB0-0x000000018A903C54
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) => default; // 0x000000018A903C54-0x000000018A903D80
	}

	internal class HEU_AssetSerializedMetaData : ScriptableObject, IEquivable<HEU_AssetSerializedMetaData> // TypeDefIndex: 50487
	{
		// Fields
		private bool _softDeleted; // 0x18
		private Dictionary<string, List<CurveNodeData>> _savedCurveNodeData; // 0x20
		private Dictionary<string, HEU_InputCurveInfo> _savedInputCurveInfo; // 0x28
	
		// Properties
		public bool SoftDeleted { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public Dictionary<string, List<CurveNodeData>> SavedCurveNodeData { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Dictionary<string, HEU_InputCurveInfo> SavedInputCurveInfo { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public HEU_AssetSerializedMetaData() {} // 0x000000018A8E7630-0x000000018A8E76F8
	
		// Methods
		public bool IsEquivalentTo(HEU_AssetSerializedMetaData other) => default; // 0x000000018A8E759C-0x000000018A8E7630
	}

	internal class HEU_AssetUpdater // TypeDefIndex: 50488
	{
		// Constructors
		static HEU_AssetUpdater() {} // 0x0000000185492010-0x0000000185492020
		public HEU_AssetUpdater() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void OnBeforeAssemblyReload() {} // 0x000000018A8E76F8-0x000000018A8E7738
		private static void Update() {} // 0x0000000185492010-0x0000000185492020
		public static void AddAssetForUpdate(HEU_HoudiniAsset asset) {} // 0x0000000185492010-0x0000000185492020
		public static void RemoveAsset(HEU_HoudiniAsset asset) {} // 0x0000000185492010-0x0000000185492020
		public static void AddNodeSyncForUpdate(HEU_BaseSync nodeSync) {} // 0x0000000185492010-0x0000000185492020
		public static void RemoveNodeSync(HEU_BaseSync nodeSync) {} // 0x0000000185492010-0x0000000185492020
		private static void OnPrefabInstanceUpdate(GameObject instance) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class CurveNodeData : IEquivable<CurveNodeData> // TypeDefIndex: 50489
	{
		// Fields
		public Vector3 position; // 0x10
		public Vector3 rotation; // 0x1C
		public Vector3 scale; // 0x28
		public int curveCountIndex; // 0x34
	
		// Constructors
		public CurveNodeData() {} // 0x000000018A8E62E0-0x000000018A8E6340
		public CurveNodeData(Vector3 position) {} // 0x000000018A8E6270-0x000000018A8E62E0
		public CurveNodeData(Vector3 position, Quaternion rotation) {} // 0x000000018A8E6340-0x000000018A8E63C8
		public CurveNodeData(Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x000000018A8E63C8-0x000000018A8E646C
		public CurveNodeData(CurveNodeData other) {} // 0x000000018A8E61D0-0x000000018A8E6270
	
		// Methods
		public Quaternion GetRotation() => default; // 0x000000018A8E6004-0x000000018A8E6040
		public bool IsEquivalentTo(CurveNodeData other) => default; // 0x000000018A8E6040-0x000000018A8E61D0
	}

	[Serializable]
	public class HEU_InputCurveInfo // TypeDefIndex: 50490
	{
		// Fields
		public HAPI_CurveType curveType; // 0x10
		public int order; // 0x14
		public bool closed; // 0x18
		public bool reverse; // 0x19
		public HAPI_InputCurveMethod inputMethod; // 0x1C
		public HAPI_InputCurveParameterization breakpointParameterization; // 0x20
	
		// Constructors
		public HEU_InputCurveInfo() {} // 0x0000000185FCE020-0x0000000185FCE030
	
		// Methods
		public static HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HAPI_InputCurveInfo curveInfo) => default; // 0x000000018A90345C-0x000000018A9034E0
		public static string[] GetCurveTypeNames() => default; // 0x000000018A903588-0x000000018A903630
		public static string[] GetInputMethodNames() => default; // 0x000000018A903630-0x000000018A9036B8
		public static string[] GetBreakpointParameterizationNames() => default; // 0x000000018A9034E0-0x000000018A903588
	}

	[Serializable]
	public enum HEU_CurveDataType // TypeDefIndex: 50491
	{
		INVALID = 0,
		GEO_COORDS_PARAM = 1,
		HAPI_COORDS_PARAM = 2,
		POSITION_ATTRIBUTE = 3
	}

	public class HEU_Curve : ScriptableObject, IHEU_Curve, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Curve> // TypeDefIndex: 50499
	{
		// Fields
		[NonSerialized]
		private int _geoID; // 0x18
		[NonSerialized]
		private int _partID; // 0x1C
		private List<CurveNodeData> _curveNodeData; // 0x20
		private Vector3[] _vertices; // 0x28
		private bool _isEditable; // 0x30
		private HEU_Parameters _parameters; // 0x38
		private bool _bUploadParameterPreset; // 0x40
		private string _curveName; // 0x48
		private GameObject _targetGameObject; // 0x50
		private bool _isGeoCurve; // 0x58
		private CurveEditState _editState; // 0x5C
		public static Interaction PreferredNextInteractionMode; // 0x00
		private HEU_HoudiniAsset _parentAsset; // 0x60
		private bool _bIsInputCurve; // 0x68
		private bool _bIsPartCurve; // 0x69
		private bool _cachedCurveInfoValid; // 0x6A
		private int[] _cachedCurveCounts; // 0x70
		private int[] _cachedCurveCountSums; // 0x78
		private HEU_CurveDataType _curveDataType; // 0x80
		private HEU_InputCurveInfo _inputCurveInfo; // 0x88
	
		// Properties
		public GameObject TargetGameObject { get => default; set {} } // 0x0000000185FB0660-0x0000000185FB0670 0x0000000183F80460-0x0000000183F80470
		public int GeoID { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public int PartID { get => default; } // 0x000000018140C930-0x000000018140C940 
		public List<CurveNodeData> CurveNodeData { get => default; } // 0x000000018A8E96CC-0x000000018A8E9760 
		public HEU_Parameters Parameters { get => default; } // 0x000000018A8EA4B0-0x000000018A8EA51C 
		public string CurveName { get => default; } // 0x00000001838F2E40-0x00000001838F3710 
		public bool IsInputCurve { get => default; } // 0x00000001814294C0-0x00000001814294D0 
		public bool IsPartCurve { get => default; } // 0x0000000181BE64B0-0x0000000181BE64C0 
		public HEU_InputCurveInfo InputCurveInfo { get => default; } // 0x000000018A8EA764-0x000000018A8EA7E4 
		public CurveEditState EditState { get => default; } // 0x000000018A8EA938-0x000000018A8EAA7C 
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x000000018A8EA7E4-0x000000018A8EA868 
		public HEU_CurveDataType CurveDataType { get => default; } // 0x000000018A8E8FB4-0x000000018A8E905C 
	
		// Nested types
		public enum CurveEditState // TypeDefIndex: 50492
		{
			INVALID = 0,
			GENERATED = 1,
			EDITING = 2,
			REQUIRES_GENERATION = 3
		}
	
		public enum Interaction // TypeDefIndex: 50493
		{
			VIEW = 0,
			ADD = 1,
			EDIT = 2
		}
	
		internal enum CurveDrawCollision // TypeDefIndex: 50494
		{
			COLLIDERS = 0,
			LAYERMASK = 1
		}
	
		private sealed class __c__DisplayClass60_0 // TypeDefIndex: 50495
		{
			// Fields
			public List<Vector3> points; // 0x10
	
			// Constructors
			public __c__DisplayClass60_0() {} // 0x0000000181460F60-0x0000000181460F70
	
			// Methods
			internal void _GetAllPoints_b__0(CurveNodeData transform) {} // 0x0000000184A4E570-0x0000000184A4E580
		}
	
		private sealed class __c__DisplayClass87_0 // TypeDefIndex: 50496
		{
			// Fields
			public List<Vector3> positions; // 0x10
			public bool hasRotations; // 0x18
			public List<Quaternion> rotations; // 0x20
			public bool hasScales; // 0x28
			public List<Vector3> scales; // 0x30
			public List<int> curveCountIndices; // 0x38
	
			// Constructors
			public __c__DisplayClass87_0() {} // 0x00000001813AE560-0x00000001813AE570
	
			// Methods
			internal void _UpdateCurveInputForCurveParts_b__0(CurveNodeData data) {} // 0x00000001813AE570-0x00000001813AE580
		}
	
		private sealed class __c__DisplayClass88_0 // TypeDefIndex: 50497
		{
			// Fields
			public List<Vector3> positions; // 0x10
			public List<Quaternion> rotations; // 0x18
			public List<Vector3> scales; // 0x20
	
			// Constructors
			public __c__DisplayClass88_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal void _UpdateCurveInputForCustomAttributes_b__0(CurveNodeData data) {} // 0x00000001813ECBC0-0x00000001813ECBD0
			internal void _UpdateCurveInputForCustomAttributes_b__1(int nIndex1, int nIndex2, float fCoeff, int nInsertIndex) {} // 0x00000001813ECF20-0x00000001813ECF30
			internal void _UpdateCurveInputForCustomAttributes_b__2(int nIndex, int nInsertIndex) {} // 0x0000000185FB09E0-0x0000000185FB09F0
		}
	
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 50498
		{
			// Fields
			public List<Vector3> rotations; // 0x10
			public List<Vector3> scales; // 0x18
	
			// Constructors
			public __c__DisplayClass90_0() {} // 0x0000000185FB09C0-0x0000000185FB09D0
	
			// Methods
			internal void _UpdatePoints_b__0(CurveNodeData data) {} // 0x0000000185FB0510-0x0000000185FB0520
		}
	
		// Constructors
		public HEU_Curve() {} // 0x00000001838FB640-0x00000001838FBAB0
	
		// Methods
		internal void SetUploadParameterPreset(bool bValue) {} // 0x000000018A8EAA7C-0x000000018A8EAB50
		public HEU_SessionBase GetSession() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public void Recook() {} // 0x000000018A8E8D7C-0x000000018A8E8E8C
		public void Rebuild() {} // 0x000000018A8E913C-0x000000018A8E917C
		public bool IsEditable() => default; // 0x000000018A8E9A54-0x000000018A8E9B4C
		public bool IsGeoCurve() => default; // 0x000000018A8E99AC-0x000000018A8E9A54
		public void SetCurveName(string name) {} // 0x000000018A8E7B14-0x000000018A8E7C0C
		public void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x02062C5E */) {} // 0x000000018A8E7A78-0x000000018A8E7B14
		public void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02062C5F */) {} // 0x000000018A8EA51C-0x000000018A8EA5B4
		public void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x02062C60 */) {} // 0x000000018A8E7C0C-0x000000018A8E7C98
		public Vector3 GetCurvePoint(int pointIndex) => default; // 0x000000018A8EA45C-0x000000018A8EA4B0
		public List<CurveNodeData> GetAllPointTransforms() => default; // 0x000000018A8EA730-0x000000018A8EA764
		public List<Vector3> GetAllPoints() => default; // 0x000000018A8E9760-0x000000018A8E9828
		public int GetNumPoints() => default; // 0x000000018A8E9828-0x000000018A8E993C
		public void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x02062C61 */) {} // 0x000000018A8E8358-0x000000018A8E8604
		public void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02062C62 */) {} // 0x000000018A8E7C98-0x000000018A8E8034
		public void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x02062C63 */) {} // 0x000000018A8EBFEC-0x000000018A8EC258
		public void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02062C64 */) {} // 0x000000018A8E8F6C-0x000000018A8E8FB4
		public void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x02062C65 */) {} // 0x000000018A8EAB50-0x000000018A8EABA8
		public void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x02062C66 */) {} // 0x000000018A8E8034-0x000000018A8E8260
		public void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x02062C67 */) {} // 0x000000018A8EBE88-0x000000018A8EBF70
		public void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x02062C68 */) {} // 0x000000018A8EA5B4-0x000000018A8EA674
		public Vector3 GetTransformedPoint(int pointIndex) => default; // 0x000000018A8EA868-0x000000018A8EA938
		public List<Vector3> GetTransformedPoints() => default; // 0x000000018A8EB644-0x000000018A8EB760
		public List<CurveNodeData> DuplicateCurveNodeData() => default; // 0x000000018A8E8EFC-0x000000018A8E8F6C
		internal static HEU_Curve CreateSetupCurve(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool isEditable, string curveName, int geoID, int partID, bool bGeoCurve) => default; // 0x000000018A8E89AC-0x000000018A8E8D7C
		private void UsePreviousCurveData(string curveName) {} // 0x000000018A8E8604-0x000000018A8E89AC
		private HEU_CurveDataType GetCurveDataType(HEU_SessionBase session) => default; // 0x000000018A8E9E64-0x000000018A8E9E9C
		internal bool ShouldKeepNode(HEU_SessionBase session) => default; // 0x000000018A8E917C-0x000000018A8E91C8
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02062C69 */) {} // 0x000000018A8EAD58-0x000000018A8EB2A8
		internal void UploadParameterPreset(HEU_SessionBase session, int geoID, HEU_HoudiniAsset parentAsset) {} // 0x000000018A8EB2A8-0x000000018A8EB644
		internal void ResetCurveParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) {} // 0x000000018A8EABA8-0x000000018A8EAC50
		internal void SetCurveParameterPreset(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, byte[] parameterPreset) {} // 0x000000018A8EB760-0x000000018A8EBE88
		internal void UpdateCurve(HEU_SessionBase session, int partId) {} // 0x000000018A8E9E9C-0x000000018A8EA45C
		private static int[] GetCurveCounts(HEU_SessionBase session, int geoId, int partID) => default; // 0x000000018A8E9440-0x000000018A8E96CC
		internal void GenerateMesh(GameObject inGameObject, HEU_SessionBase session) {} // 0x000000018A8E91C8-0x000000018A8E9440
		internal void GenerateMeshForSingleObject(GameObject targetObject, Vector3[] vertexList) {} // 0x0000000183F804F0-0x0000000183F80500
		internal void OnPresyncParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) {} // 0x000000018A8E993C-0x000000018A8E99AC
		internal static int GetOrderForCurveType(int requestedOrder, HAPI_CurveType curveType) => default; // 0x000000018A8E90CC-0x000000018A8E913C
		internal bool UpdateCurveInputForCurveParts(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) => default; // 0x000000018A8E905C-0x000000018A8E90CC
		internal bool UpdateCurveInputForCustomAttributes(HEU_SessionBase session, HEU_HoudiniAsset parentAsset) => default; // 0x00000001813B8590-0x00000001813B85A0
		internal void SyncFromParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bNewCurve) {} // 0x000000018A8EA674-0x000000018A8EA730
		private void UpdatePoints(HEU_SessionBase session) {} // 0x000000018A8E82DC-0x000000018A8E8358
		internal void ProjectToCollidersInternal(HEU_HoudiniAsset parentAsset, Vector3 rayDirection, float rayDistance) {} // 0x000000018A8EBF70-0x000000018A8EBFEC
		public static string GetPointsString(List<CurveNodeData> points) => default; // 0x000000018A8E8260-0x000000018A8E82DC
		public static string GetPointsString(List<Vector3> points) => default; // 0x000000018A8EAC50-0x000000018A8EAD58
		internal void SetEditState(CurveEditState editState) {} // 0x000000018A8E8E8C-0x000000018A8E8EFC
		internal Vector3 GetTransformedPosition(Vector3 inPosition) => default; // 0x000000018A8E9E3C-0x000000018A8E9E64
		internal Vector3 GetInvertedTransformedPosition(Vector3 inPosition) => default; // 0x000000018A8E9B4C-0x000000018A8E9E3C
		internal Vector3 GetInvertedTransformedDirection(Vector3 inPosition) => default; // 0x000000018A8EC258-0x000000018A8EC2E0
		internal Vector3[] GetVertices() => default; // 0x0000000185492010-0x0000000185492020
		internal void SetCurveGeometryVisibilityInternal(bool bVisible) {} // 0x00000001838F68D0-0x00000001838F6C90
		internal void DownloadPresetData(HEU_SessionBase session) {} // 0x0000000185492010-0x0000000185492020
		internal void UploadPresetData(HEU_SessionBase session) {} // 0x00000001838F6C90-0x00000001838F7800
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session) {} // 0x0000000185492010-0x0000000185492020
		private void UpdateCachedCurveInfo(HEU_SessionBase session, bool copyCurveSettings) {} // 0x00000001838F7800-0x00000001838F8030
		internal int GetCurveCountIndexFromPositionIndex(int positionIndex) => default; // 0x00000001838F8030-0x00000001838F9C30
		private static bool IsMeshCurve(HEU_SessionBase session, int geoID, int partID) => default; // 0x00000001838F9C30-0x00000001838FB640
		public bool IsEquivalentTo(HEU_Curve other) => default; // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_GeneratedOutput : IEquivable<HEU_GeneratedOutput> // TypeDefIndex: 50500
	{
		// Fields
		public HEU_GeneratedOutputData _outputData; // 0x10
		public List<HEU_GeneratedOutputData> _childOutputs; // 0x18
		private bool isInstancer; // 0x20
	
		// Properties
		public bool IsInstancer { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
	
		// Constructors
		public HEU_GeneratedOutput() {} // 0x000000018A8EE798-0x000000018A8EE844
	
		// Methods
		public static void ResetMaterialOverrides(HEU_GeneratedOutput output) {} // 0x000000018A8EE528-0x000000018A8EE670
		public static void ResetMaterialOverrides(HEU_GeneratedOutputData outputData) {} // 0x000000018A8EE670-0x000000018A8EE728
		public static Material[] GetGeneratedMaterialsForGameObject(HEU_GeneratedOutput output, GameObject inGameObject) => default; // 0x000000018A8EDEDC-0x000000018A8EE098
		public static bool HasLODGroup(HEU_GeneratedOutput output) => default; // 0x000000018A8EE098-0x000000018A8EE0E0
		public static bool IsOutputUsingMaterial(Material checkMaterial, HEU_GeneratedOutput output) => default; // 0x000000018A8EE3C8-0x000000018A8EE528
		public static bool IsOutputDataUsingMaterial(Material checkMaterial, HEU_GeneratedOutputData outputData) => default; // 0x000000018A8EE25C-0x000000018A8EE3C8
		public static void ClearGeneratedMaterialReferences(HEU_GeneratedOutputData generatedOutputData) {} // 0x000000018A8ED674-0x000000018A8ED698
		public static void DestroyAllGeneratedColliders(HEU_GeneratedOutputData outputData) {} // 0x000000018A8ED9A4-0x000000018A8EDB7C
		public static void DestroyGeneratedOutput(HEU_GeneratedOutput generatedOutput) {} // 0x000000018A8EDD38-0x000000018A8EDEDC
		public static void DestroyGeneratedOutputChildren(HEU_GeneratedOutput generatedOutput) {} // 0x000000018A8EDB7C-0x000000018A8EDCE0
		public static void DestroyGeneratedOutputData(HEU_GeneratedOutputData generatedOutputData, bool bDontDeletePersistantResources) {} // 0x000000018A8EDCE0-0x000000018A8EDD38
		public static void ClearMaterialsNoLongerUsed(Material[] materialsToCheck, Material[] materialsInUse) {} // 0x000000018A8ED698-0x000000018A8ED768
		public static void CopyMaterialOverrides(HEU_GeneratedOutputData sourceOutputData, HEU_GeneratedOutputData destOutputData) {} // 0x000000018A8ED768-0x000000018A8ED9A4
		internal void WriteOutputToAssetCache(GameObject parentObject, string outputPath, bool bIsInstancer) {} // 0x000000018A8EE728-0x000000018A8EE798
		internal static void BakeGameObjectComponents(GameObject sourceGO, GameObject targetGO, string assetName, string outputPath, bool bIsInstancer) {} // 0x000000018A8ED52C-0x000000018A8ED674
		public bool IsEquivalentTo(HEU_GeneratedOutput other) => default; // 0x000000018A8EE0E0-0x000000018A8EE25C
	}

	[Serializable]
	public class HEU_GeneratedOutputData : IEquivable<HEU_GeneratedOutputData> // TypeDefIndex: 50501
	{
		// Fields
		public GameObject _gameObject; // 0x10
		public Material[] _renderMaterials; // 0x18
		public List<Collider> _colliders; // 0x20
	
		// Constructors
		public HEU_GeneratedOutputData() {} // 0x000000018A8ED4B4-0x000000018A8ED52C
	
		// Methods
		public bool IsEquivalentTo(HEU_GeneratedOutputData other) => default; // 0x000000018A8ED304-0x000000018A8ED4B4
	}

	public class HEU_GeoNode : ScriptableObject, IHEU_GeoNode, IHEU_HoudiniAssetSubcomponent, ISerializationCallbackReceiver, IEquivable<HEU_GeoNode> // TypeDefIndex: 50502
	{
		// Fields
		private HAPI_GeoInfo _geoInfo; // 0x18
		private string _geoName; // 0x40
		private List<HEU_PartData> _parts; // 0x48
		private HEU_ObjectNode _containerObjectNode; // 0x50
		private HEU_InputNode _inputNode; // 0x58
		private HEU_Curve _geoCurve; // 0x60
		private HEU_VolumeCache _volumeCache; // 0x68
		private List<HEU_VolumeCache> _volumeCaches; // 0x70
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x000000018A8F2660-0x000000018A8F26CC 
		public int GeoID { get => default; } // 0x00000001813B88B0-0x00000001813B88C0 
		public HAPI_GeoInfo GeoInfo { get => default; } // 0x0000000185FC6B40-0x0000000185FC6B60 
		public string GeoName { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public HAPI_GeoType GeoType { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public bool Editable { get => default; } // 0x0000000185FB0810-0x0000000185FB0820 
		public bool Displayable { get => default; } // 0x000000018A8F25E0-0x000000018A8F2660 
		public List<HEU_PartData> Parts { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public HEU_ObjectNode ObjectNode { get => default; } // 0x0000000181460F60-0x0000000181460F70 
		public HEU_InputNode InputNode { get => default; } // 0x00000001813F1630-0x00000001813F1640 
		public HEU_Curve GeoCurve { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public List<HEU_VolumeCache> VolumeCaches { get => default; } // 0x0000000181460F70-0x0000000181460F80 
	
		// Constructors
		public HEU_GeoNode() {} // 0x000000018A8F25C0-0x000000018A8F25E0
	
		// Methods
		public void OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		public void OnAfterDeserialize() {} // 0x000000018A8F082C-0x000000018A8F0920
		public HEU_SessionBase GetSession() => default; // 0x000000018A8EFF74-0x000000018A8F0018
		public void Recook() {} // 0x000000018A8F193C-0x000000018A8F19B0
		public bool IsVisible() => default; // 0x000000018A8F0810-0x000000018A8F082C
		public bool IsIntermediate() => default; // 0x000000018A802F38-0x000000018A802F40
		public bool IsIntermediateOrEditable() => default; // 0x000000018A8F06CC-0x000000018A8F06E4
		public bool IsGeoInputType() => default; // 0x000000018A8F06B8-0x000000018A8F06CC
		public bool IsGeoCurveType() => default; // 0x0000000187B8E454-0x0000000187B8E45C
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02062C73 */) {} // 0x000000018A8EEB90-0x000000018A8EED68
		public void RemoveAndDestroyPart(HEU_PartData part) {} // 0x000000018A8F19B0-0x000000018A8F1A14
		public void GetOutputGameObjects(List<GameObject> outputObjects) {} // 0x000000018A8EFB9C-0x000000018A8EFCC0
		public void GetOutput(List<HEU_GeneratedOutput> outputs) {} // 0x000000018A8EFCC0-0x000000018A8EFDE4
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x000000018A8EFA44-0x000000018A8EFB9C
		public HEU_PartData GetPartFromPartID(int partID) => default; // 0x000000018A8EFDE4-0x000000018A8EFE94
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly) {} // 0x000000018A8EF4A8-0x000000018A8EF6A4
		public List<HEU_PartData> GetParts() => default; // 0x00000001813ECF20-0x00000001813ECF30
		public void HideAllGeometry() {} // 0x000000018A8F02A4-0x000000018A8F0338
		public void DisableAllColliders() {} // 0x000000018A8EEEF0-0x000000018A8EEF84
		public HEU_VolumeCache GetVolumeCacheByTileIndex(int tileIndex) => default; // 0x000000018A8F0018-0x000000018A8F0154
		internal void Reset() {} // 0x000000018A8F1A14-0x000000018A8F1AC4
		internal void Initialize(HEU_SessionBase session, HAPI_GeoInfo geoInfo, HEU_ObjectNode containerObjectNode) {} // 0x000000018A8F0338-0x000000018A8F0454
		internal bool DoesThisRequirePotentialCook() => default; // 0x000000018A8EEF84-0x000000018A8EEFCC
		internal void UpdateGeo(HEU_SessionBase session) {} // 0x000000018A8F2248-0x000000018A8F25C0
		internal void ProcessUnityScriptAttribute(HEU_SessionBase session) {} // 0x000000018A8F12B0-0x000000018A8F1464
		private void ProcessPart(HEU_SessionBase session, int partID, ref HAPI_PartInfo partInfo, ref HEU_PartData partData) {} // 0x000000018A8F0B18-0x000000018A8F12B0
		private void SetupGameObjectAndTransform(HEU_PartData partData, HEU_HoudiniAsset parentAsset) {} // 0x000000018A8F1D70-0x000000018A8F2020
		internal void GetPartsByOutputType(List<HEU_PartData> meshParts, List<HEU_PartData> volumeParts) {} // 0x000000018A8EFE94-0x000000018A8EFF74
		internal void GeneratePartInstances(HEU_SessionBase session) {} // 0x000000018A8EF144-0x000000018A8EF384
		internal void GenerateAttributesStore(HEU_SessionBase session) {} // 0x000000018A8EEFCC-0x000000018A8EF06C
		private void ProcessGeoCurve(HEU_SessionBase session) {} // 0x000000018A8F0920-0x000000018A8F0B18
		private void SetupGeoCurveGameObjectAndTransform(HEU_Curve curve) {} // 0x000000018A8F2020-0x000000018A8F21EC
		internal void ClearObjectInstances() {} // 0x000000018A8EEB08-0x000000018A8EEB90
		internal void SetGeoInfo(HAPI_GeoInfo geoInfo) {} // 0x000000018A8F1CEC-0x000000018A8F1D70
		internal string GeneratePartFullName(string partName) => default; // 0x000000018A8EF06C-0x000000018A8EF144
		internal string GenerateGeoCurveName() => default; // 0x00000001813FF010-0x00000001813FF020
		internal bool HasGeoNodeChanged(HEU_SessionBase session) => default; // 0x000000018A8F026C-0x000000018A8F02A4
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform) {} // 0x000000018A8EE844-0x000000018A8EE968
		internal void GetDebugInfo(StringBuilder sb) {} // 0x000000018A8EF6A4-0x000000018A8EFA44
		internal bool IsUsingMaterial(HEU_MaterialData materialData) => default; // 0x000000018A8F06E4-0x000000018A8F0810
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x000000018A8EF384-0x000000018A8EF4A8
		internal bool HasAttribInstancer() => default; // 0x000000018A8F0154-0x000000018A8F026C
		internal void SetAttributeModifiersOnPartOutputs(HEU_SessionBase session) {} // 0x000000018A8F1AC4-0x000000018A8F1CEC
		internal void CalculateVisiblity(bool bParentVisibility) {} // 0x000000018A8EE9F8-0x000000018A8EEB08
		internal void CalculateColliderState() {} // 0x000000018A8EE968-0x000000018A8EE9F8
		internal void ProcessVolumeParts(HEU_SessionBase session, List<HEU_PartData> volumeParts, bool bRebuild) {} // 0x000000018A8F1464-0x000000018A8F193C
		internal void DestroyVolumeCache() {} // 0x000000018A8EED68-0x000000018A8EEEF0
		public override string ToString() => default; // 0x000000018A8F21EC-0x000000018A8F2248
		public bool IsEquivalentTo(HEU_GeoNode other) => default; // 0x000000018A8F0454-0x000000018A8F06B8
	}

	public sealed class HEU_HoudiniAsset : MonoBehaviour, IHEU_HoudiniAsset, IEquivable<HEU_HoudiniAsset> // TypeDefIndex: 50512
	{
		// Fields
		private HEU_AssetType _assetType; // 0x18
		private HAPI_AssetInfo _assetInfo; // 0x1C
		private HAPI_NodeInfo _nodeInfo; // 0x5C
		private string _assetName; // 0xA0
		private string _assetOpName; // 0xA8
		private string _assetHelp; // 0xB0
		[NonSerialized]
		private int _assetID; // 0xB8
		private string _assetPath; // 0xC0
		private bool _loadAssetFromMemory; // 0xC8
		private bool _alwaysOverwriteOnLoad; // 0xC9
		private UnityEngine.Object _assetFileObject; // 0xD0
		private List<HEU_ObjectNode> _objectNodes; // 0xD8
		private GameObject _rootGameObject; // 0xE0
		private List<HEU_MaterialData> _materialCache; // 0xE8
		private HEU_Parameters _parameters; // 0xF0
		private Matrix4x4 _lastSyncedTransformMatrix; // 0xF8
		private List<Matrix4x4> _lastSyncedChildTransformMatrices; // 0x138
		private string _assetCacheFolderPath; // 0x140
		private string[] _subassetNames; // 0x148
		private int _selectedSubassetIndex; // 0x150
		private HEU_AssetPreset _savedAssetPreset; // 0x158
		private HEU_RecookPreset _recookPreset; // 0x160
		private int _totalCookCount; // 0x168
		private AssetBuildAction _requestBuildAction; // 0x16C
		private bool _checkParameterChangeForCook; // 0x170
		private bool _skipCookCheck; // 0x171
		private bool _uploadParameters; // 0x172
		private bool _forceUploadInputs; // 0x173
		private bool _upstreamCookChanged; // 0x174
		private AssetCookStatus _cookStatus; // 0x178
		private AssetCookResult _lastCookResult; // 0x17C
		private bool _isCookingAssetReloaded; // 0x180
		private bool _bForceUpdate; // 0x181
		private long _sessionID; // 0x188
		private bool _WarnedPrefabNotSupported_k__BackingField; // 0x190
		private bool _uiLocked; // 0x191
		private bool _showHDAOptions; // 0x192
		private bool _showGenerateSection; // 0x193
		private bool _showBakeSection; // 0x194
		private bool _showEventsSection; // 0x195
		private bool _showCurvesSection; // 0x196
		private bool _showInputNodesSection; // 0x197
		private bool _showToolsSection; // 0x198
		private bool _showTerrainSection; // 0x199
		private HEU_InstanceInputUIState _instanceInputUIState; // 0x1A0
		private HEU_ReloadDataEvent _reloadDataEvent; // 0x1A8
		private HEU_CookedDataEvent _cookedDataEvent; // 0x1B0
		private HEU_BakedDataEvent _bakedDataEvent; // 0x1B8
		private HEU_PreAssetEvent _preAssetEvent; // 0x1C0
		private UpdateUIDelegate _refreshUIDelegate; // 0x1C8
		private HEU_CookedDataEvent _downstreamConnectionCookedEvent; // 0x1D0
		private bool _generateUVs; // 0x1D8
		private bool _generateTangents; // 0x1D9
		private bool _generateNormals; // 0x1DA
		private bool _pushTransformToHoudini; // 0x1DB
		private bool _transformChangeTriggersCooks; // 0x1DC
		private bool _cookingTriggersDownCooks; // 0x1DD
		private bool _autoCookOnParameterChange; // 0x1DE
		private bool _ignoreNonDisplayNodes; // 0x1DF
		private bool _useOutputNodes; // 0x1E0
		private bool _generateMeshUsingPoints; // 0x1E1
		private bool _useLODGroups; // 0x1E2
		private bool _splitGeosByGroup; // 0x1E3
		private bool _sessionSyncAutoCook; // 0x1E4
		private bool _bakeUpdateKeepPreviousTransformValues; // 0x1E5
		private bool _pauseCooking; // 0x1E6
		private bool _curveEditorEnabled; // 0x1E7
		private List<HEU_Curve> _curves; // 0x1E8
		private HEU_Curve.CurveDrawCollision _curveDrawCollision; // 0x1F0
		private List<Collider> _curveDrawColliders; // 0x1F8
		private LayerMask _curveDrawLayerMask; // 0x200
		private float _curveProjectMaxDistance; // 0x204
		private Vector3 _curveProjectDirection; // 0x208
		private bool _curveProjectDirectionToView; // 0x214
		private bool _curveDisableScaleRotation; // 0x215
		private bool _curveFrameSelectedNodes; // 0x216
		private float _curveFrameSelectedNodeDistance; // 0x218
		private List<HEU_InputNode> _inputNodes; // 0x220
		private List<HEU_Handle> _handles; // 0x228
		private bool _handlesEnabled; // 0x230
		private List<HEU_VolumeCache> _volumeCaches; // 0x238
		private List<HEU_AttributesStore> _attributeStores; // 0x240
		private bool _editableNodesToolsEnabled; // 0x248
		private HEU_ToolsInfo _toolsInfo; // 0x250
		private HEU_AssetSerializedMetaData _serializedMetaData; // 0x258
		private bool _pendingAutoCookOnMouseRelease; // 0x260
	
		// Properties
		public bool LoadAssetFromMemory { get => default; set {} } // 0x0000000185FCDE10-0x0000000185FCDE20 0x0000000185FCDFA0-0x0000000185FCDFB0
		public bool AlwaysOverwriteOnLoad { get => default; set {} } // 0x0000000185FBA3A0-0x0000000185FBA3B0 0x0000000185FCE010-0x0000000185FCE020
		public bool GenerateUVs { get => default; set {} } // 0x0000000185FCDDE0-0x0000000185FCDDF0 0x0000000185FCDF60-0x0000000185FCDF70
		public bool GenerateTangents { get => default; set {} } // 0x0000000185FCDE80-0x0000000185FCDE90 0x0000000185FCE000-0x0000000185FCE010
		public bool GenerateNormals { get => default; set {} } // 0x0000000185FBC420-0x0000000185FBC430 0x0000000185FCDFE0-0x0000000185FCDFF0
		public bool PushTransformToHoudini { get => default; set {} } // 0x0000000185FB8E10-0x0000000185FB8E20 0x0000000185FCDFD0-0x0000000185FCDFE0
		public bool TransformChangeTriggersCooks { get => default; set {} } // 0x0000000181C96DC0-0x0000000181C97DA0 0x0000000185FCDEB0-0x0000000185FCDEC0
		public bool CookingTriggersDownCooks { get => default; set {} } // 0x0000000185FBC430-0x0000000185FBC440 0x0000000185FCDFB0-0x0000000185FCDFC0
		public bool AutoCookOnParameterChange { get => default; set {} } // 0x0000000185FCDDB0-0x0000000185FCDDC0 0x0000000185FCDEE0-0x0000000185FCDEF0
		public bool IgnoreNonDisplayNodes { get => default; set {} } // 0x000000018A9033EC-0x000000018A9033FC 0x000000018A903420-0x000000018A903440
		public bool UseOutputNodes { get => default; set {} } // 0x0000000185FCDD10-0x0000000185FCDD20 0x0000000185FCDD40-0x0000000185FCDD50
		public bool GenerateMeshUsingPoints { get => default; set {} } // 0x0000000185FBACE0-0x0000000185FBACF0 0x0000000185FCDF40-0x0000000185FCDF50
		public bool UseLODGroups { get => default; set {} } // 0x0000000185FBC4E0-0x0000000185FBC500 0x0000000185FCDF20-0x0000000185FCDF40
		public bool SplitGeosByGroup { get => default; set {} } // 0x0000000185FCDDD0-0x0000000185FCDDE0 0x0000000185FCDF10-0x0000000185FCDF20
		public bool SessionSyncAutoCook { get => default; set {} } // 0x0000000185FCDD90-0x0000000185FCDDA0 0x0000000185FCDED0-0x0000000185FCDEE0
		public bool BakeUpdateKeepPreviousTransformValues { get => default; set {} } // 0x0000000185FCDDC0-0x0000000185FCDDD0 0x0000000185FCDF00-0x0000000185FCDF10
		public bool PauseCooking { get => default; set {} } // 0x0000000185FBAC00-0x0000000185FBAC10 0x0000000185FCDEF0-0x0000000185FCDF00
		public bool CurveEditorEnabled { get => default; set {} } // 0x0000000185FB93F0-0x0000000185FB9400 0x0000000185FBC770-0x0000000185FBC780
		public HEU_CurveDrawCollisionWrapper CurveDrawCollision { get => default; set {} } // 0x0000000185FBCD90-0x0000000185FBCDA0 0x0000000185FCDF50-0x0000000185FCDF60
		public LayerMask CurveDrawLayerMask { get => default; set {} } // 0x000000018A9033B0-0x000000018A9033DC 0x0000000185FCDD50-0x0000000185FCDD80
		public float CurveProjectMaxDistance { get => default; set {} } // 0x0000000185FCDE20-0x0000000185FCDE50 0x0000000185FB0520-0x0000000185FB0530
		public Vector3 CurveProjectDirection { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x000000018346D8F0-0x000000018346D900
		public bool CurveProjectDirectionToView { get => default; set {} } // 0x0000000185FB9570-0x0000000185FB9580 0x0000000181B388F0-0x0000000181B38900
		public bool CurveDisableScaleRotation { get => default; set {} } // 0x000000018646E428-0x000000018646E430 0x0000000185FB25D0-0x0000000185FB25E0
		public bool CurveFrameSelectedNodes { get => default; set {} } // 0x0000000185FB2360-0x0000000185FB2370 0x0000000185FB87A0-0x0000000185FB87B0
		public float CurveFrameSelectedNodeDistance { get => default; set {} } // 0x0000000185FB85F0-0x0000000185FB8600 0x0000000185FB8610-0x0000000185FB8620
		public bool HandlesEnabled { get => default; set {} } // 0x0000000185FCDE60-0x0000000185FCDE70 0x000000018A9033DC-0x000000018A9033EC
		public bool EditableNodesToolsEnabled { get => default; set {} } // 0x000000018A9033FC-0x000000018A903420 0x0000000185FB8360-0x0000000185FB8370
		public HEU_AssetTypeWrapper AssetType { get => default; } // 0x0000000185FB18A0-0x0000000185FB18B0 
		public HAPI_AssetInfo AssetInfo { get => default; } // 0x0000000185FB8890-0x0000000185FB88A0 
		public HAPI_NodeInfo NodeInfo { get => default; } // 0x0000000185FB8850-0x0000000185FB8860 
		public string AssetName { get => default; } // 0x0000000185FB82E0-0x0000000185FB82F0 
		public string AssetOpName { get => default; } // 0x0000000185FB8350-0x0000000185FB8360 
		public string AssetHelp { get => default; } // 0x0000000181BE0A10-0x0000000181BE0A20 
		public int AssetID { get => default; } // 0x0000000185FB7F50-0x0000000185FB7F60 
		public string AssetPath { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public GameObject OwnerGameObject { get => default; } // 0x0000000185FCDD00-0x0000000185FCDD10 
		public GameObject RootGameObject { get => default; } // 0x0000000185FBF070-0x0000000185FBF080 
		public List<HEU_MaterialData> MaterialCache { get => default; } // 0x0000000181BE0A00-0x0000000181BE0A10 
		public HEU_Parameters Parameters { get => default; } // 0x0000000181BE0A30-0x0000000181BE0A40 
		public string AssetCacheFolder { get => default; } // 0x0000000185FB82F0-0x0000000185FB8300 
		public string[] SubassetNames { get => default; } // 0x00000001864734C0-0x00000001864734D4 
		public int SelectedSubassetIndex { get => default; } // 0x0000000185FB8420-0x0000000185FB8430 
		public HEU_AssetCookStatusWrapper CookStatus { get => default; } // 0x0000000186473568-0x000000018647357C 
		public HEU_AssetCookResultWrapper LastCookResult { get => default; } // 0x0000000185FCDDA0-0x0000000185FCDDB0 
		public long SessionID { get => default; } // 0x0000000185FB1890-0x0000000185FB18A0 
		public List<HEU_Curve> Curves { get => default; } // 0x0000000185FCDD10-0x0000000185FCDD20 
		public List<HEU_InputNode> InputNodes { get => default; } // 0x0000000185FCDD40-0x0000000185FCDD50 
		public List<HEU_VolumeCache> VolumeCaches { get => default; } // 0x0000000185FB8620-0x0000000185FB8630 
		public HEU_ReloadDataEvent ReloadDataEvent { get => default; } // 0x0000000185FB8770-0x0000000185FB8780 
		public HEU_CookedDataEvent CookedDataEvent { get => default; } // 0x0000000185FB8470-0x0000000185FB8480 
		public HEU_BakedDataEvent BakedDataEvent { get => default; } // 0x0000000185FB8860-0x0000000185FB8870 
		public HEU_PreAssetEvent PreAssetEvent { get => default; } // 0x0000000185FB9340-0x0000000185FB9350 
		internal HEU_AssetType AssetTypeInternal { get => default; } // 0x000000018A903440-0x000000018A90345C 
		internal bool WarnedPrefabNotSupported { get; set; } // 0x00000001840A27C0-0x00000001840A27D0 0x000000018A8F8388-0x000000018A8F8708
		internal HEU_InstanceInputUIState InstanceInputUIState { get => default; set {} } // 0x000000018A8F76D0-0x000000018A8F7960 0x000000018A8F4574-0x000000018A8F4888
		internal UpdateUIDelegate RefreshUIDelegate { get => default; set {} } // 0x000000018A8F4888-0x000000018A8F49E0 0x000000018A8F3320-0x000000018A8F3998
		internal HEU_Curve.CurveDrawCollision CurveDrawCollisionInternal { get => default; } // 0x000000018A8F3998-0x000000018A8F4574 
		internal List<HEU_Handle> Handles { get => default; } // 0x000000018A8F9BFC-0x000000018A8F9D68 
		internal List<HEU_AttributesStore> AttributeStores { get => default; } // 0x000000018A8F2820-0x000000018A8F28A8 
		internal HEU_ToolsInfo ToolsInfo { get => default; } // 0x000000018A8FFA30-0x000000018A8FFA8C 
		internal HEU_AssetSerializedMetaData SerializedMetaData { get => default; } // 0x000000018A8F51E8-0x000000018A8F5234 
		internal bool PendingAutoCookOnMouseRelease { get => default; set {} } // 0x000000018A8FA294-0x000000018A8FA3D8 0x000000018A8F97A8-0x000000018A8F98F0
	
		// Nested types
		internal enum HEU_AssetType // TypeDefIndex: 50503
		{
			TYPE_INVALID = 0,
			TYPE_HDA = 1,
			TYPE_CURVE = 2,
			TYPE_INPUT = 3
		}
	
		internal enum AssetBuildAction // TypeDefIndex: 50504
		{
			NONE = 0,
			RELOAD = 1,
			COOK = 2,
			INVALID = 3,
			STRIP_HEDATA = 4,
			DUPLICATE = 5,
			RESET_PARAMS = 6
		}
	
		internal enum AssetCookStatus // TypeDefIndex: 50505
		{
			NONE = 0,
			COOKING = 1,
			POSTCOOK = 2,
			LOADING = 3,
			POSTLOAD = 4,
			PRELOAD = 5,
			SELECT_SUBASSET = 6
		}
	
		internal enum AssetCookResult // TypeDefIndex: 50506
		{
			NONE = 0,
			SUCCESS = 1,
			ERRORED = 2
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 50507; 0x0000000185FB8CE0-0x0000000185FB8CF0
	
		private enum AssetInstantiationMethod // TypeDefIndex: 50508
		{
			DEFAULT = 0,
			DUPLICATED = 1,
			UNDO = 2
		}
	
		private sealed class __c__DisplayClass262_0 // TypeDefIndex: 50509
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass262_0() {} // 0x0000000185FB92F0-0x0000000185FB9300
	
			// Methods
			internal void _BakeToExistingPrefab_b__0(Transform trans) {} // 0x0000000185FCDF90-0x0000000185FCDFA0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 50510
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
			static __c() {} // 0x0000000185FCDE00-0x0000000185FCDE10
			public __c() {} // 0x0000000185FCDF80-0x0000000185FCDF90
	
			// Methods
			internal bool _GetNonParameterInputNodes_b__274_0(HEU_InputNode node) => default; // 0x0000000185FCDDF0-0x0000000185FCDE00
			internal bool _DoPostCookWork_b__312_0(HEU_ObjectNode obj) => default; // 0x0000000185FCDF70-0x0000000185FCDF80
			internal bool _UploadCurvesParameters_b__335_0(HEU_Curve curve) => default; // 0x0000000185FCDE50-0x0000000185FCDE60
			internal bool _UploadAttributeValues_b__336_0(HEU_AttributesStore store) => default; // 0x0000000185FCDFC0-0x0000000185FCDFD0
			internal bool _ClearInvalidCurves_b__373_0(HEU_Curve curve) => default; // 0x0000000185FCDE70-0x0000000185FCDE80
			internal bool _ClearInvalidLists_b__404_0(HEU_ObjectNode node) => default; // 0x0000000185FCDFF0-0x0000000185FCE000
			internal bool _ClearInvalidLists_b__404_1(HEU_Curve curve) => default; // 0x0000000185FBD850-0x0000000185FBD860
			internal bool _ClearInvalidLists_b__404_2(HEU_MaterialData data) => default; // 0x0000000185FCDEC0-0x0000000185FCDED0
		}
	
		private sealed class __c__DisplayClass405_0 // TypeDefIndex: 50511
		{
			// Fields
			public HEU_HoudiniAsset newAsset; // 0x10
			public int i; // 0x18
			public Predicate<HEU_Curve> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass405_0() {} // 0x0000000185FCDD80-0x0000000185FCDD90
	
			// Methods
			internal bool _CopyPropertiesTo_b__0(HEU_Curve curve) => default; // 0x0000000185FCDEA0-0x0000000185FCDEB0
		}
	
		// Constructors
		public HEU_HoudiniAsset() {} // 0x00000001839047E0-0x0000000183904C10
	
		// Methods
		internal AssetCookStatus GetCookStatus() => default; // 0x00000001840A27C0-0x00000001840A27D0
		internal AssetCookResult GetLastCookResult() => default; // 0x00000001840A27C0-0x00000001840A27D0
		internal List<Collider> GetCurveDrawColliders() => default; // 0x000000018A8FCC2C-0x000000018A8FCC68
		internal LayerMask GetCurveDrawLayerMask() => default; // 0x000000018A8FB2F4-0x000000018A8FB41C
		internal void SetCurveDrawLayerMask(LayerMask mask) {} // 0x000000018A8FB544-0x000000018A8FB66C
		public bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x02062C74 */, bool bAsync = false /* Metadata: 0x02062C75 */, bool bSkipCookCheck = true /* Metadata: 0x02062C76 */, bool bUploadParameters = true /* Metadata: 0x02062C77 */) => default; // 0x000000018A8FA220-0x000000018A8FA294
		public bool RequestReload(bool bAsync = false /* Metadata: 0x02062C78 */) => default; // 0x000000018A8FA8C4-0x000000018A8FAD44
		public bool RequestResetParameters(bool bAsync = false /* Metadata: 0x02062C79 */) => default; // 0x000000018A8FB960-0x000000018A8FB9A4
		public GameObject DuplicateAsset(GameObject newRootGameObject = null) => default; // 0x000000018A8F98F0-0x000000018A8F9968
		public bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x02062C7A */) => default; // 0x000000018A8FAD44-0x000000018A8FB014
		public GameObject BakeToNewPrefab(string destinationPrefabPath = null) => default; // 0x000000018A8FB41C-0x000000018A8FB544
		public GameObject BakeToNewStandalone() => default; // 0x000000018A8FA60C-0x000000018A8FA768
		public bool BakeToExistingPrefab(GameObject bakeTargetGO) => default; // 0x000000018A9006AC-0x000000018A900A90
		public bool BakeToExistingStandalone(GameObject bakeTargetGO) => default; // 0x000000018A8FBF54-0x000000018A8FC06C
		public bool IsAssetValid() => default; // 0x000000018A8F79C4-0x000000018A8F7ADC
		public bool GetOutputGameObjects(List<GameObject> outputObjects) => default; // 0x000000018A8FA768-0x000000018A8FA8C4
		public bool GetOutput(List<HEU_GeneratedOutput> outputs) => default; // 0x000000018A8F5644-0x000000018A8F568C
		public HEU_Curve GetCurve(string curveName) => default; // 0x000000018A8FFB94-0x000000018A8FFCAC
		public bool AddCurveDrawCollider(Collider newCollider) => default; // 0x000000018A900550-0x000000018A9006AC
		public bool RemoveCurveDrawCollider(Collider collider) => default; // 0x00000001838F3710-0x00000001838F68D0
		public bool ClearCurveDrawColliders() => default; // 0x000000018A8FB18C-0x000000018A8FB2F4
		public HEU_InputNode GetInputNode(string inputName) => default; // 0x000000018A8FC074-0x000000018A8FC134
		public HEU_InputNode GetAssetInputNode(string inputName) => default; // 0x000000018A8FB78C-0x000000018A8FB8C8
		public HEU_InputNode GetInputNodeByIndex(int index) => default; // 0x000000018A8FB66C-0x000000018A8FB78C
		public List<HEU_InputNode> GetNonParameterInputNodes() => default; // 0x000000018A8FE0BC-0x000000018A8FE1E8
		public int GetVolumeCacheCount() => default; // 0x000000018A8FE1E8-0x000000018A8FE254
		public HEU_SessionBase GetAssetSession(bool bCreateIfInvalid) => default; // 0x000000018A900E38-0x000000018A90122C
		public HEU_ObjectNode GetObjectNodeByName(string objName) => default; // 0x000000018A8F4C10-0x000000018A8F4C88
		public void GetOutputGeoNodes(List<HEU_GeoNode> outputGeoNodes) {} // 0x000000018A8FCBDC-0x000000018A8FCBF8
		public HEU_PartData GetInternalHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x0000000185492010-0x0000000185492020
		public void ResetParametersToDefault() {} // 0x0000000185FCDD20-0x0000000185FCDD30
		public void HideAllGeometry() {} // 0x0000000185492010-0x0000000185492020
		public void DisableAllColliders() {} // 0x0000000185492010-0x0000000185492020
		public HEU_MaterialData GetMaterialData(Material material) => default; // 0x0000000185492010-0x0000000185492020
		public void ClearMaterialCache() {} // 0x0000000185492010-0x0000000185492020
		public void RemoveMaterial(Material material) {} // 0x000000018A900280-0x000000018A900294
		public void ResetMaterialOverrides() {} // 0x0000000185FCDCE0-0x0000000185FCDD00
		public HEU_AssetPreset GetAssetPreset(bool sceneRelativeGameObjects) => default; // 0x000000018A8FBF3C-0x000000018A8FBF54
		public HEU_PDGAssetLink GetOrCreatePDGAssetLink() => default; // 0x000000018A8FF354-0x000000018A8FF58C
		public static HEU_HoudiniAssetRoot InstantiateHDA(string filePath, bool bAsync = false /* Metadata: 0x02062C7B */, Vector3 initialPosition = default) => default; // 0x000000018A8FCB20-0x000000018A8FCBDC
		public static HEU_PartData GetSceneHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x000000018A901250-0x000000018A9013CC
		public static HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(GameObject outputGameObject) => default; // 0x000000018A8F87A4-0x000000018A8F8DBC
		public static bool IsHoudiniAssetOutput(GameObject go) => default; // 0x000000018A8FF6CC-0x000000018A8FF7EC
		public static bool IsHoudiniAssetRoot(GameObject go) => default; // 0x000000018A8FF7EC-0x000000018A8FF9D8
		internal void SetupAsset(HEU_AssetType assetType, string filePath, GameObject rootGameObject, HEU_SessionBase session) {} // 0x000000018A8F7B6C-0x000000018A8F7EB0
		internal void CleanUpAndDisable() {} // 0x000000018A8FE254-0x000000018A8FE2C4
		internal bool IsAssetSavedInScene() => default; // 0x000000018A8FEC3C-0x000000018A8FEC70
		private void Awake() {} // 0x000000018A8F8708-0x000000018A8F87A4
		internal void InvalidateAsset() {} // 0x000000018A8FCA64-0x000000018A8FCB20
		private void OnEnable() {} // 0x000000018A8FC28C-0x000000018A8FC9A4
		private void OnDestroy() {} // 0x000000018A8FC134-0x000000018A8FC28C
		internal void AssetUpdate() {} // 0x0000000185FCDD30-0x0000000185FCDD40
		internal void PostAssetUpdate() {} // 0x000000018A8FEF78-0x000000018A8FF354
		internal void RequestBakeInPlace() {} // 0x000000018A90122C-0x000000018A901250
		internal void ClearBuildRequest() {} // 0x000000018A8FEDC8-0x000000018A8FEF78
		private bool HasValidAssetPath() => default; // 0x000000018A8F7EB0-0x000000018A8F8304
		private void ProcessRebuild(bool bPromptForSubasset, int desiredSubassetIndex) {} // 0x000000018A8F79B0-0x000000018A8F79C4
		private void InvokeReloadEvent(bool bCookSuccess, List<GameObject> outputObjects) {} // 0x000000018A8F4D88-0x000000018A8F4FB0
		private bool StartRebuild(bool bPromptForSubasset, int desiredSubassetIndex) => default; // 0x000000018A8F7960-0x000000018A8F79B0
		private bool FinishRebuild() => default; // 0x000000018A8F9594-0x000000018A8F97A8
		private bool RecookAsync(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync) => default; // 0x000000018A8F8304-0x000000018A8F8388
		private bool RecookBlocking(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync) => default; // 0x000000018A902ED8-0x000000018A9030BC
		private void DoPostCookWork(HEU_SessionBase session) {} // 0x000000018A902204-0x000000018A90229C
		internal bool IsValidForInteraction(ref string errorMessage) => default; // 0x000000018A8FE2C4-0x000000018A8FE5A0
		private void OnValidate() {} // 0x000000018A8F7028-0x000000018A8F7150
		private void ExecutePostCookCallbacks() {} // 0x000000018A8F7150-0x000000018A8F74A4
		private void InvokePostCookEvent(bool bCookSuccess, List<GameObject> outputObjects) {} // 0x000000018A8F8DBC-0x000000018A8F8DF0
		private bool InternalStartRecook(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync) => default; // 0x000000018A9028AC-0x000000018A902D08
		private void InternalSetAssetID(int assetID) {} // 0x000000018A902308-0x000000018A9028AC
		private void SetCookStatus(AssetCookStatus status, AssetCookResult result) {} // 0x000000018A9014B0-0x000000018A9015F8
		private void ProcessPoskCook() {} // 0x000000018A902D08-0x000000018A902ED8
		private bool StartHoudiniCookNode(HEU_SessionBase session) => default; // 0x000000018A8FBB48-0x000000018A8FBC98
		private void ProcessHoudiniCookStatus(bool bAsync) {} // 0x000000018A8FEA68-0x000000018A8FEB80
		internal bool DoesAssetRequireRecook() => default; // 0x000000018A8F7594-0x000000018A8F76A8
		internal void DeleteSessionDataOnly() {} // 0x000000018A9017C8-0x000000018A901EFC
		private void CleanUpInputNodes() {} // 0x000000018A8F74A4-0x000000018A8F7594
		internal void DeleteAssetCacheData(bool bRegisterUndo) {} // 0x000000018A8F945C-0x000000018A8F9594
		private void GenerateParameters(HEU_SessionBase session) {} // 0x000000018A8FEBB4-0x000000018A8FEBF8
		private void DownloadParameterPresetFromHoudini(HEU_SessionBase session) {} // 0x000000018A8F9968-0x000000018A8F9AC8
		private void UploadParameterPresetToHoudini(HEU_SessionBase session) {} // 0x000000018A8F8DF0-0x000000018A8F8F18
		private void UpdateParameterInputsToHoudini(HEU_SessionBase session, bool bForceUpdate) {} // 0x000000018A8F90E0-0x000000018A8F945C
		private bool LoadAssetFileWithSubasset(HEU_SessionBase session, bool bPromptForSubasset, int desiredSubassetIndex) => default; // 0x000000018A8F8F18-0x000000018A8F90E0
		private bool CreateAndCookAsset(HEU_SessionBase session, int subassetIndex, out int newAssetID, bool bCookTemplatedGeos) {
			newAssetID = default;
			return default;
		} // 0x000000018A8F4C88-0x000000018A8F4D88
		private void CreateAssetInputs(HEU_SessionBase session) {} // 0x000000018A8F9EA0-0x000000018A8F9FDC
		public void ForceUploadParameters(HEU_SessionBase session) {} // 0x0000000185FB8620-0x0000000185FB8630
		private void UploadCurvesParameters(HEU_SessionBase session, bool bCheckParamsChanged) {} // 0x000000018A8FEBF8-0x000000018A8FEC3C
		private void UploadAttributeValues(HEU_SessionBase session) {} // 0x000000018A8FB014-0x000000018A8FB0D0
		private void SyncDirtyAttributesToHoudini(HEU_SessionBase session) {} // 0x000000018A8FB0D0-0x000000018A8FB18C
		private void UploadInputNodes(HEU_SessionBase session, bool bForceUpdate, bool bUpdateAll) {} // 0x000000018A8FC9A4-0x000000018A8FCA64
		internal bool HasInputNodeTransformChanged() => default; // 0x000000018A8F568C-0x000000018A8F5BC0
		private void NotifyInputNodesCookFinished() {} // 0x000000018A8FEB80-0x000000018A8FEBB4
		private bool CreateObjects(HEU_SessionBase session) => default; // 0x000000018A8F5BC0-0x000000018A8F5C50
		private void UpdateAllObjectNodes(HEU_SessionBase session) {} // 0x000000018A8F7ADC-0x000000018A8F7B6C
		private HEU_ObjectNode CreateObjectNode(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo, ref HAPI_Transform objectTranform) => default; // 0x000000018A8F292C-0x000000018A8F29AC
		private void GenerateObjectsGeometry(HEU_SessionBase session, bool bRebuild) {} // 0x000000018A8FFAE4-0x000000018A8FFB3C
		internal int NumAttributeStores() => default; // 0x000000018A8F4FB0-0x000000018A8F51E8
		internal HEU_AttributesStore GetAttributeStore(string geoName, int partID) => default; // 0x000000018A9020DC-0x000000018A902204
		private void GenerateAttributesStore(HEU_SessionBase session) {} // 0x000000018A8FF58C-0x000000018A8FF6CC
		private void GenerateInstances(HEU_SessionBase session) {} // 0x000000018A8F9FDC-0x000000018A8FA220
		private void GenerateHandles(HEU_SessionBase session) {} // 0x000000018A9030BC-0x000000018A903128
		internal void CleanUpHandles() {} // 0x000000018A901EFC-0x000000018A9020DC
		internal HEU_Handle GetHandleByName(string handleName) => default; // 0x000000018A8FFCAC-0x000000018A900094
		internal List<HEU_Handle> GetHandles() => default; // 0x000000018A8FCBF8-0x000000018A8FCC2C
		internal int NumHandles() => default; // 0x000000018A8FBC98-0x000000018A8FBF3C
		internal HAPI_Transform GetObjectTransform(HEU_SessionBase session, int objectID) => default; // 0x000000018A8F9AC8-0x000000018A8F9BFC
		internal HEU_ObjectNode GetObjectWithID(int objId) => default; // 0x000000018A8F5234-0x000000018A8F535C
		private void InvokeBakedEvent(bool bSuccess, List<GameObject> outputObjects, bool isNewBake) {} // 0x000000018A8F9D68-0x000000018A8F9EA0
		private GameObject CloneAssetWithoutHDA(ref string bakedAssetPath, bool bWriteMeshesToAssetDatabase, bool bReconnectPrefabInstances) => default; // 0x000000018A8F28A8-0x000000018A8F292C
		internal void NotifyUpstreamCooked(HEU_CookedEventData Data) {} // 0x000000018A8FFA8C-0x000000018A8FFAE4
		internal void ConnectToUpstream(HEU_HoudiniAsset upstreamAsset) {} // 0x0000000185FB8890-0x0000000185FB88A0
		internal void DisconnectFromUpstream(HEU_HoudiniAsset upstreamAsset) {} // 0x000000018A8F29AC-0x000000018A8F2A30
		private void AddDownstreamConnection(UnityAction<HEU_CookedEventData> receiver) {} // 0x000000018A8FFB3C-0x000000018A8FFB94
		private void RemoveDownstreamConnection(UnityAction<HEU_CookedEventData> receiver) {} // 0x000000018A8FC06C-0x000000018A8FC074
		private void ClearAllUpstreamConnections() {} // 0x000000018A8F2A9C-0x000000018A8F2B20
		private void UpdateInputsOnAssetRecreation(HEU_SessionBase session) {} // 0x000000018A9000F8-0x000000018A90017C
		internal void ReconnectInputsUpstreamNotifications() {} // 0x000000018A8F26CC-0x000000018A8F2820
		internal void GetHoudiniTransformAndApply(HEU_SessionBase session) {} // 0x000000018A8FF9D8-0x000000018A8FFA30
		internal void UploadUnityTransform(HEU_SessionBase session, bool bOnlySendIfChangedFromLastSync) {} // 0x000000018A90017C-0x000000018A900280
		private void UpdateHoudiniMaterials(HEU_SessionBase session) {} // 0x000000018A8FEC70-0x000000018A8FEDC8
		private void RemoveUnusedMaterials() {} // 0x000000018A8F2A30-0x000000018A8F2A9C
		internal bool IsAssetValidInHoudini(HEU_SessionBase session) => default; // 0x000000018A900A90-0x000000018A900C60
		internal bool HasTransformChangedSinceLastUpdate() => default; // 0x000000018A8FB8C8-0x000000018A8FB960
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x000000018A8F4AF8-0x000000018A8F4C10
		internal void ClearInvalidCurves() {} // 0x000000018A8F49E0-0x000000018A8F4AF8
		internal int GetEditableCurveCount() => default; // 0x000000018A8FE5A0-0x000000018A8FEA68
		internal void AddCurve(HEU_Curve curve) {} // 0x000000018A8F2E38-0x000000018A8F2ED8
		internal void RemoveCurve(HEU_Curve curve) {} // 0x000000018A8F2B20-0x000000018A8F2E38
		internal List<HEU_InputNode> GetInputNodes() => default; // 0x000000018A8FB9A4-0x000000018A8FBB48
		internal void AddInputNode(HEU_InputNode node) {} // 0x000000018A900094-0x000000018A9000F8
		internal void RemoveInputNode(HEU_InputNode node) {} // 0x000000018A8F2ED8-0x000000018A8F3290
		internal void InputNodeNotifyRemoved(HEU_InputNode node) {} // 0x000000018A9015F8-0x000000018A9017C8
		internal void AddVolumeCache(HEU_VolumeCache cache) {} // 0x000000018A90229C-0x000000018A9022F4
		internal void RemoveVolumeCache(HEU_VolumeCache cache) {} // 0x000000018A9022F4-0x000000018A902308
		internal void AddAttributeStore(HEU_AttributesStore attributeStore) {} // 0x000000018A900294-0x000000018A900550
		internal void RemoveAttributeStore(HEU_AttributesStore attributeStore) {} // 0x000000018A8FA464-0x000000018A8FA60C
		internal void ReorderAttributeStore(int oldIndex, int newIndex) {} // 0x000000018A8FA3D8-0x000000018A8FA464
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos) {} // 0x000000018A8F535C-0x000000018A8F5644
		internal void AddToAssetDBCache(string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref UnityEngine.Object targetAssetDBObject) {} // 0x000000018A8F5C50-0x000000018A8F7028
		internal static void SetCurvesVisibilityInScene(bool bShow) {} // 0x000000018A900C60-0x000000018A900E38
		internal string GetValidAssetCacheFolderPath() => default; // 0x000000018A9013CC-0x000000018A9014B0
		internal void CalculateVisibility() {} // 0x000000018A8F32B0-0x000000018A8F32F8
		internal void CalculateColliderState() {} // 0x000000018A8F32B0-0x000000018A8F32F8
		internal void LoadAssetPresetAndCook(HEU_AssetPreset assetPreset) {} // 0x000000018A8F3290-0x000000018A8F32B0
		internal void ApplyRecookPreset() {} // 0x000000018A8F3290-0x000000018A8F32B0
		private bool ApplyInputPresets(HEU_SessionBase session, List<HEU_InputPreset> inputPresets, bool bAddMissingInputsToRecookPreset) => default; // 0x000000018A8F76A8-0x000000018A8F76C0
		internal HEU_VolumeCachePreset GetVolumeCachePreset(string objName, string geoName, int tile) => default; // 0x000000018A8F76C0-0x000000018A8F76D0
		internal void RemoveVolumeCachePreset(HEU_VolumeCachePreset preset) {} // 0x000000018A8F32F8-0x000000018A8F3320
		private bool ApplyVolumeCachePresets(List<HEU_VolumeCachePreset> volumeCachePresets) => default; // 0x000000018A8F32F8-0x000000018A8F3320
		internal void SyncInternalParametersForUndoCompare() {} // 0x000000018A8FCC68-0x000000018A8FE0BC
		internal bool UpdateSessionSync() => default; // 0x000000018A903128-0x000000018A9033B0
		internal void UpdateTotalCookCount() {} // 0x00000001864BC330-0x00000001864BC3F4
		private void ResetAndCopyInstantiatedProperties(HEU_HoudiniAsset newAsset) {} // 0x00000001864BC320-0x00000001864BC330
		private AssetInstantiationMethod GetInstantiationMethod() => default; // 0x00000001864BC2FC-0x00000001864BC320
		private HEU_HoudiniAsset GetInstantiatedObject() => default; // 0x00000001864BB614-0x00000001864BB734
		private void ClearInvalidLists() {} // 0x0000000185492010-0x0000000185492020
		private void CopyPropertiesTo(HEU_HoudiniAsset newAsset) {} // 0x00000001839040C0-0x00000001839047E0
		internal void SetSoftDeleted() {} // 0x000000018A918070-0x000000018A9180D4
		private void SyncChildTransforms() {} // 0x0000000185492010-0x0000000185492020
		internal static HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(AssetCookStatus assetCookStatus) => default; // 0x0000000183902680-0x0000000183902F40
		internal static AssetCookStatus AssetCookStatus_WrapperToInternal(HEU_AssetCookStatusWrapper assetCookStatus) => default; // 0x0000000183901DC0-0x0000000183902680
		internal static HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(AssetCookResult assetCookResult) => default; // 0x0000000183903800-0x00000001839040C0
		internal static AssetCookResult AssetCookResult_WrapperToInternal(HEU_AssetCookResultWrapper assetCookResult) => default; // 0x0000000183902F40-0x0000000183903800
		internal static HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HEU_Curve.CurveDrawCollision curveDrawCollision) => default; // 0x00000001838FFAC0-0x0000000183900380
		internal static HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HEU_CurveDrawCollisionWrapper curveDrawCollision) => default; // 0x0000000183900380-0x0000000183900C40
		internal static HEU_AssetTypeWrapper AssetType_InternalToWrapper(HEU_AssetType assetType) => default; // 0x0000000183900C40-0x0000000183901500
		internal static HEU_AssetType AssetType_WrapperToInternal(HEU_AssetTypeWrapper assetType) => default; // 0x0000000183901500-0x0000000183901DC0
		public bool IsEquivalentTo(HEU_HoudiniAsset asset) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class HEU_HoudiniAssetRoot : MonoBehaviour // TypeDefIndex: 50513
	{
		// Fields
		internal HEU_HoudiniAsset _houdiniAsset; // 0x18
		internal List<GameObject> _bakeTargets; // 0x20
	
		// Properties
		public HEU_HoudiniAsset HoudiniAsset { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public List<GameObject> BakeTargets { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Constructors
		public HEU_HoudiniAssetRoot() {} // 0x000000018A9083BC-0x000000018A90843C
	
		// Methods
		private void OnDestroy() {} // 0x000000018A9081B0-0x000000018A908254
		internal void RemoveHoudiniEngineAssetData() {} // 0x000000018A908254-0x000000018A908300
		internal void ClearHoudiniEngineReferences() {} // 0x000000018A90814C-0x000000018A9081A0
		internal static void DestroyRootComponent(HEU_HoudiniAssetRoot assetRoot) {} // 0x000000018A9081A0-0x000000018A9081B0
		internal void Reset() {} // 0x000000018A908300-0x000000018A9083BC
	}

	public class HEU_InputNode : ScriptableObject, IHEU_InputNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_InputNode> // TypeDefIndex: 50518
	{
		// Fields
		private InputNodeType _inputNodeType; // 0x18
		private InputObjectType _inputObjectType; // 0x1C
		private InputObjectType _pendingInputObjectType; // 0x20
		private List<HEU_InputObjectInfo> _inputObjects; // 0x28
		private List<int> _inputObjectsConnectedAssetIDs; // 0x30
		private GameObject _inputAsset; // 0x38
		private GameObject _connectedInputAsset; // 0x40
		private List<HEU_InputHDAInfo> _inputAssetInfos; // 0x48
		private int _nodeID; // 0x50
		private int _inputIndex; // 0x54
		private bool _requiresCook; // 0x58
		private bool _requiresUpload; // 0x59
		private string _inputName; // 0x60
		private string _labelName; // 0x68
		internal string _paramName; // 0x70
		private int _connectedNodeID; // 0x78
		private bool _keepWorldTransform; // 0x7C
		private bool _packGeometryBeforeMerging; // 0x7D
		private HEU_HoudiniAsset _parentAsset; // 0x80
		private HEU_InputInterfaceMeshSettings _meshSettings; // 0x88
		private HEU_InputInterfaceTilemapSettings _tilemapSettings; // 0x90
		private HEU_InputInterfaceSplineSettings _splineSettings; // 0x98
		internal bool _usingSelectFromHierarchy; // 0xA0
		public HEU_InputNodeUICache _uiCache; // 0xA8
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x000000018140CF50-0x000000018140CF60 
		public bool KeepWorldTransform { get => default; set {} } // 0x0000000185FBA020-0x0000000185FBA030 0x0000000185FBA040-0x0000000185FBA050
		public bool PackGeometryBeforeMerging { get => default; set {} } // 0x0000000185FCDC00-0x0000000185FCDC10 0x0000000185FCE040-0x0000000185FCE050
		public HEU_InputNodeTypeWrapper NodeType { get => default; } // 0x000000018A90CC0C-0x000000018A90CC2C 
		public HEU_InputObjectTypeWrapper ObjectType { get => default; } // 0x000000018A90CC2C-0x000000018A90CC38 
		public HEU_InputObjectTypeWrapper PendingObjectType { get => default; set {} } // 0x000000018A90CC38-0x000000018A90CC44 0x000000018A90CC44-0x000000018A90CC64
		public int InputNodeID { get => default; } // 0x0000000185FB0680-0x0000000185FB0690 
		public string InputName { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public string LabelName { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public string ParamName { get => default; } // 0x0000000181460F70-0x0000000181460F80 
		public HEU_InputInterfaceMeshSettings MeshSettings { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		public HEU_InputInterfaceTilemapSettings TilemapSettings { get => default; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 
		public HEU_InputInterfaceSplineSettings SplineSettings { get => default; } // 0x0000000181E336C0-0x0000000181E336D0 
		internal InputNodeType InputType { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		internal List<HEU_InputObjectInfo> InputObjects { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		internal List<HEU_InputHDAInfo> InputAssetInfos { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		internal bool RequiresCook { get => default; set {} } // 0x0000000181BE64B0-0x0000000181BE64C0 0x0000000181BE64C0-0x0000000181BE64D0
		internal bool RequiresUpload { get => default; set {} } // 0x0000000185FB9F90-0x0000000185FB9FA0 0x0000000185FBCA00-0x0000000185FBCA10
	
		// Nested types
		internal enum InputNodeType // TypeDefIndex: 50514
		{
			CONNECTION = 0,
			NODE = 1,
			PARAMETER = 2
		}
	
		[Serializable]
		internal enum InputObjectType // TypeDefIndex: 50515
		{
			HDA = 0,
			UNITY_MESH = 1,
			CURVE = 2,
			TERRAIN = 3,
			BOUNDING_BOX = 4,
			TILEMAP = 5
		}
	
		public enum InternalObjectType // TypeDefIndex: 50516
		{
			UNKNOWN = 0,
			HDA = 1,
			UNITY_MESH = 2
		}
	
		public enum InputActions // TypeDefIndex: 50517
		{
			ACTION = 0,
			DELETE = 1,
			INSERT = 2
		}
	
		// Constructors
		public HEU_InputNode() {} // 0x000000018A90C8BC-0x000000018A90CC0C
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x000000018A909958-0x000000018A9099F0
		public void Recook() {} // 0x000000018A90B0C0-0x000000018A90B12C
		public bool IsAssetInput() => default; // 0x000000018847A644-0x000000018847A64C
		public int NumInputEntries() => default; // 0x000000018A90AE20-0x000000018A90AE94
		public GameObject GetInputEntryGameObject(int index) => default; // 0x000000018A9095A8-0x000000018A9097BC
		public GameObject[] GetInputEntryGameObjects() => default; // 0x000000018A9097BC-0x000000018A909914
		public void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x02062C94 */) {} // 0x000000018A90B888-0x000000018A90BAE4
		public void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x02062C95 */) {} // 0x000000018A90A06C-0x000000018A90A2C8
		public void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x02062C96 */) {} // 0x000000018A90861C-0x000000018A9086BC
		public void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x02062C97 */) {} // 0x000000018A90B40C-0x000000018A90B450
		public void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x02062C98 */) {} // 0x000000018A9087FC-0x000000018A908864
		public void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x02062C99 */) {} // 0x000000018A90B194-0x000000018A90B3BC
		public void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x02062C9A */) {} // 0x000000018A90B12C-0x000000018A90B194
		public void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x02062C9B */) {} // 0x000000018A90B7D0-0x000000018A90B888
		public void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x02062C9C */) {} // 0x000000018A90B70C-0x000000018A90B7D0
		public void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x02062C9D */) {} // 0x000000018A90B57C-0x000000018A90B644
		public void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x02062C9E */) {} // 0x000000018A90B644-0x000000018A90B70C
		public bool AreAnyInputHDAsConnected() => default; // 0x000000018A9086BC-0x000000018A9087FC
		public int GetConnectedInputCount() => default; // 0x000000018A909478-0x000000018A9094EC
		public int GetConnectedNodeID(int index) => default; // 0x000000018A9094EC-0x000000018A9095A8
		public void LoadPreset(HEU_InputPreset inputPreset) {} // 0x000000018A90A784-0x000000018A90A7BC
		public void PopulateInputPreset(HEU_InputPreset inputPreset, bool sceneRelativeGameObjects) {} // 0x00000001838FBAB0-0x00000001838FDD30
		internal static HEU_InputNode CreateSetupInput(int nodeID, int inputIndex, string inputName, string labelName, InputNodeType inputNodeType, HEU_HoudiniAsset parentAsset) => default; // 0x000000018A908FA0-0x000000018A909054
		internal void SetInputNodeID(int nodeID) {} // 0x0000000185FB06B0-0x0000000185FB06C0
		internal void DestroyAllData(HEU_SessionBase session) {} // 0x000000018A909054-0x000000018A909098
		private void ResetInputObjectTransforms() {} // 0x000000018A90B49C-0x000000018A90B57C
		internal void ResetInputNode(HEU_SessionBase session) {} // 0x000000018A90B450-0x000000018A90B49C
		internal HEU_InputObjectInfo AddInputEntryAtEndMesh(GameObject newEntryGameObject) => default; // 0x000000018A9085E0-0x000000018A90861C
		internal HEU_InputHDAInfo AddInputEntryAtEndHDA(GameObject newEntryGameObject) => default; // 0x000000018A9085A4-0x000000018A9085E0
		internal void ChangeInputType(HEU_SessionBase session, InputObjectType newType) {} // 0x000000018A908864-0x000000018A908894
		internal void ResetConnectionForForceUpdate(HEU_SessionBase session) {} // 0x000000018A90B3BC-0x000000018A90B40C
		internal void UploadInput(HEU_SessionBase session) {} // 0x000000018A90BED4-0x000000018A90C274
		private void UploadHDAInput(HEU_SessionBase session) {} // 0x000000018A90BC50-0x000000018A90BD78
		private void UploadUnityInput(HEU_SessionBase session) {} // 0x000000018A90C38C-0x000000018A90C8BC
		internal void ReconnectToUpstreamAsset() {} // 0x000000018A90AE94-0x000000018A90B0C0
		private HEU_InputObjectInfo CreateInputObjectInfo(GameObject inputGameObject) => default; // 0x000000018A908F2C-0x000000018A908FA0
		private HEU_InputHDAInfo CreateInputHDAInfo(GameObject inputGameObject) => default; // 0x000000018A908EC4-0x000000018A908F2C
		private HEU_InputObjectInfo InternalAddInputObjectAtEnd(GameObject newInputGameObject) => default; // 0x000000018A90A334-0x000000018A90A3A0
		private HEU_InputHDAInfo InternalAddInputHDAAtEnd(GameObject newInputHDA) => default; // 0x000000018A90A2C8-0x000000018A90A334
		private void DisconnectConnectedMergeNode(HEU_SessionBase session) {} // 0x000000018A909228-0x000000018A90935C
		private void ClearConnectedInputHDAs() {} // 0x000000018A908894-0x000000018A908A60
		private void ConnectToMergeObject(HEU_SessionBase session) {} // 0x000000018A908A78-0x000000018A908B1C
		private void DisconnectAndDestroyInputs(HEU_SessionBase session) {} // 0x000000018A909098-0x000000018A909228
		internal bool UploadObjectMergeTransformType(HEU_SessionBase session) => default; // 0x000000018A90C300-0x000000018A90C38C
		private bool UploadObjectMergePackGeometry(HEU_SessionBase session) => default; // 0x000000018A90C274-0x000000018A90C300
		internal bool HasInputNodeTransformChanged() => default; // 0x000000018A909BB0-0x000000018A90A01C
		internal void UploadInputObjectTransforms(HEU_SessionBase session) {} // 0x000000018A90BD78-0x000000018A90BED4
		internal void UpdateOnAssetRecreation(HEU_SessionBase session) {} // 0x000000018A90BAE4-0x000000018A90BC50
		internal void CopyInputValuesTo(HEU_SessionBase session, HEU_InputNode destInputNode) {} // 0x000000018A908B1C-0x000000018A908EC4
		internal void LoadPreset(HEU_SessionBase session, HEU_InputPreset inputPreset) {} // 0x000000018A90A7BC-0x000000018A90ADA8
		private bool FindAddToInputHDA(string gameObjectName) => default; // 0x000000018A90935C-0x000000018A909478
		internal void NotifyParentRemovedInput() {} // 0x000000018A90ADA8-0x000000018A90AE20
		internal void ClearUICache() {} // 0x000000018A908A60-0x000000018A908A78
		internal void HandleSelectedObjectsForInputObjects(GameObject[] selectedObjects) {} // 0x000000018A909AD0-0x000000018A909BB0
		internal void HandleSelectedObjectsForInputHDAs(GameObject[] selectedObjects) {} // 0x000000018A9099F0-0x000000018A909AD0
		public bool IsEquivalentTo(HEU_InputNode other) => default; // 0x000000018A90A3A0-0x000000018A90A784
		internal static InternalObjectType GetInternalObjectType(InputObjectType type) => default; // 0x000000018A909914-0x000000018A909958
		internal static HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(InputNodeType inputNodeType) => default; // 0x000000018A8F3290-0x000000018A8F32B0
		internal static InputNodeType InputNodeType_InternalToWrapper(HEU_InputNodeTypeWrapper inputNodeType) => default; // 0x000000018A8F3290-0x000000018A8F32B0
		internal static HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(InputObjectType inputType) => default; // 0x000000018A90A01C-0x000000018A90A06C
		internal static InputObjectType InputObjectType_WrapperToInternal(HEU_InputObjectTypeWrapper inputType) => default; // 0x000000018A90A01C-0x000000018A90A06C
	}

	[Serializable]
	internal class HEU_InputObjectInfo : IEquivable<HEU_InputObjectInfo> // TypeDefIndex: 50519
	{
		// Fields
		public GameObject _gameObject; // 0x10
		public Terrain _terrainReference; // 0x18
		public HEU_BoundingVolume _boundingVolumeReference; // 0x20
		public Tilemap _tilemapReference; // 0x28
		public Matrix4x4 _syncdTransform; // 0x30
		public List<Matrix4x4> _syncdChildTransforms; // 0x70
		public bool _useTransformOffset; // 0x78
		public Vector3 _translateOffset; // 0x7C
		public Vector3 _rotateOffset; // 0x88
		public Vector3 _scaleOffset; // 0x94
		public System.Type _inputInterfaceType; // 0xA0
	
		// Constructors
		public HEU_InputObjectInfo() {} // 0x000000018A90D0AC-0x000000018A90D1A8
	
		// Methods
		public void CopyTo(HEU_InputObjectInfo destObject) {} // 0x000000018A90CC64-0x000000018A90CD68
		internal void SetReferencesFromGameObject() {} // 0x000000018A90CFC4-0x000000018A90D0AC
		public bool IsEquivalentTo(HEU_InputObjectInfo other) => default; // 0x000000018A90CD68-0x000000018A90CFC4
	}

	[Serializable]
	internal class HEU_InputHDAInfo : IEquivable<HEU_InputHDAInfo> // TypeDefIndex: 50520
	{
		// Fields
		public GameObject _pendingGO; // 0x10
		public GameObject _connectedGO; // 0x18
		public int _connectedInputNodeID; // 0x20
		public int _connectedMergeNodeID; // 0x24
	
		// Constructors
		public HEU_InputHDAInfo() {} // 0x0000000185FCE030-0x0000000185FCE040
	
		// Methods
		public void CopyTo(HEU_InputHDAInfo destInfo) {} // 0x000000018A90843C-0x000000018A908480
		public bool IsEquivalentTo(HEU_InputHDAInfo other) => default; // 0x000000018A908480-0x000000018A9084E4
	}

	public class HEU_InputNodeUICache // TypeDefIndex: 50523
	{
		// Fields
		public List<HEU_InputObjectUICache> _inputObjectCache; // 0x10
		public List<HEU_InputAssetUICache> _inputAssetCache; // 0x18
	
		// Nested types
		public class HEU_InputObjectUICache // TypeDefIndex: 50521
		{
			// Constructors
			public HEU_InputObjectUICache() {} // 0x000000018A9084E4-0x000000018A9085A4
		}
	
		public class HEU_InputAssetUICache // TypeDefIndex: 50522
		{
			// Constructors
			public HEU_InputAssetUICache() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public HEU_InputNodeUICache() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal class HEU_InstanceInputUIState : ScriptableObject, IEquivable<HEU_InstanceInputUIState> // TypeDefIndex: 50524
	{
		// Fields
		public bool _showInstanceInputs; // 0x18
		public int _numInputsToShowUI; // 0x1C
		public int _inputsPageIndexUI; // 0x20
	
		// Constructors
		public HEU_InstanceInputUIState() {} // 0x000000018A90D328-0x000000018A90D33C
	
		// Methods
		internal void CopyTo(HEU_InstanceInputUIState dest) {} // 0x000000018A90D1A8-0x000000018A90D1D0
		public bool IsEquivalentTo(HEU_InstanceInputUIState other) => default; // 0x000000018A90D1D0-0x000000018A90D328
	}

	public class HEU_ObjectInstanceInfo : ScriptableObject, IEquivable<HEU_ObjectInstanceInfo> // TypeDefIndex: 50525
	{
		// Fields
		public List<HEU_InstancedInput> _instancedInputs; // 0x18
		public HEU_PartData _partTarget; // 0x20
		public int _instancedObjectNodeID; // 0x28
		public string _instancedObjectPath; // 0x30
		public List<GameObject> _instances; // 0x38
	
		// Constructors
		public HEU_ObjectInstanceInfo() {} // 0x000000018A90D614-0x000000018A90D6E0
	
		// Methods
		public bool IsEquivalentTo(HEU_ObjectInstanceInfo other) => default; // 0x000000018A90D4F4-0x000000018A90D614
	}

	[Serializable]
	public class HEU_InstancedInput : IEquivable<HEU_InstancedInput> // TypeDefIndex: 50526
	{
		// Fields
		public GameObject _instancedGameObject; // 0x10
		public Vector3 _rotationOffset; // 0x18
		public Vector3 _scaleOffset; // 0x24
	
		// Constructors
		public HEU_InstancedInput() {} // 0x000000018A90D4C8-0x000000018A90D4F4
	
		// Methods
		public bool IsEquivalentTo(HEU_InstancedInput other) => default; // 0x000000018A90D33C-0x000000018A90D4C8
	}

	public class HEU_ObjectNode : ScriptableObject, IHEU_ObjectNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_ObjectNode> // TypeDefIndex: 50527
	{
		// Fields
		private string _objName; // 0x18
		private HEU_HoudiniAsset _parentAsset; // 0x20
		private HAPI_ObjectInfo _objectInfo; // 0x28
		private List<HEU_GeoNode> _geoNodes; // 0x48
		private HAPI_Transform _objectTransform; // 0x50
		internal List<int> _recentlyDestroyedParts; // 0x78
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public int ObjectID { get => default; } // 0x0000000185FB0790-0x0000000185FB07A0 
		public string ObjectName { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public HAPI_ObjectInfo ObjectInfo { get => default; } // 0x0000000185FBEEC0-0x0000000185FBEEE0 
		public List<HEU_GeoNode> GeoNodes { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public HAPI_Transform ObjectTransform { get => default; } // 0x0000000185FCE070-0x0000000185FCE090 
	
		// Constructors
		public HEU_ObjectNode() {} // 0x000000018A9104FC-0x000000018A910588
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x000000018A90F7FC-0x000000018A90F890
		public void Recook() {} // 0x000000018A9100E0-0x000000018A910144
		public bool IsInstanced() => default; // 0x0000000185FB0B90-0x0000000185FB0BA0
		public bool IsVisible() => default; // 0x0000000185FB0C40-0x0000000185FB0C50
		public bool IsUsingMaterial(HEU_MaterialData materialData) => default; // 0x000000018A90FD40-0x000000018A90FE6C
		public void GetOutputGameObjects(List<GameObject> outputObjects) {} // 0x000000018A90F460-0x000000018A90F584
		public void GetOutput(List<HEU_GeneratedOutput> outputs) {} // 0x000000018A90F6D8-0x000000018A90F7FC
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject) => default; // 0x000000018A90F308-0x000000018A90F460
		public HEU_GeoNode GetGeoNode(string geoName) => default; // 0x000000018A90F1C8-0x000000018A90F308
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly) {} // 0x000000018A90EDFC-0x000000018A90EF30
		public void GetOutputGeoNodes(List<HEU_GeoNode> outGeoNodes) {} // 0x000000018A90F584-0x000000018A90F6D8
		public void HideAllGeometry() {} // 0x000000018A90F890-0x000000018A90F9A4
		public void DisableAllColliders() {} // 0x000000018A90DD68-0x000000018A90DE7C
		public bool IsInstancer() => default; // 0x000000018A90FC1C-0x000000018A90FD40
		internal void Reset() {} // 0x000000018A910144-0x000000018A910244
		private void SyncWithObjectInfo(HEU_SessionBase session) {} // 0x000000018A910244-0x000000018A910314
		internal void Initialize(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, HAPI_Transform objectTranform, HEU_HoudiniAsset parentAsset, bool bUseOutputNodes, bool bGetEditableNodes) {} // 0x00000001838FDD30-0x00000001838FFAC0
		internal void GatherAllAssetOutputsLegacy(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, ref List<HEU_GeoNode> geoNodes) {} // 0x000000018A90DE7C-0x000000018A90DF28
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02062CAE */) {} // 0x000000018A90DC90-0x000000018A90DD68
		private HEU_GeoNode CreateGeoNode(HEU_SessionBase session, HAPI_GeoInfo geoInfo) => default; // 0x000000018A90DBE4-0x000000018A90DC90
		internal void GetDebugInfo(StringBuilder sb) {} // 0x000000018A90EF30-0x000000018A90F1C8
		internal void SetObjectInfo(HAPI_ObjectInfo newObjectInfo) {} // 0x0000000185FCE050-0x0000000185FCE070
		internal void UpdateObject(HEU_SessionBase session, bool bForceUpdate) {} // 0x000000018A910370-0x000000018A9104FC
		internal void GenerateGeometry(HEU_SessionBase session, bool bRebuild) {} // 0x000000018A90E04C-0x000000018A90E7B4
		internal void GeneratePartInstances(HEU_SessionBase session) {} // 0x000000018A90EB94-0x000000018A90ECB8
		internal void GenerateAttributesStore(HEU_SessionBase session) {} // 0x000000018A90DF28-0x000000018A90E04C
		internal void ApplyObjectTransformToGeoNodes() {} // 0x000000018A90D6E0-0x000000018A90D800
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x000000018A90ECB8-0x000000018A90EDFC
		internal void GenerateObjectInstances(HEU_SessionBase session) {} // 0x000000018A90E7B4-0x000000018A90EB94
		internal void ClearObjectInstances(HEU_SessionBase session) {} // 0x000000018A90DA34-0x000000018A90DBE4
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos) {} // 0x000000018A90FE6C-0x000000018A90FFBC
		internal void ProcessUnityScriptAttributes(HEU_SessionBase session) {} // 0x000000018A90FFBC-0x000000018A9100E0
		internal void CalculateVisibility() {} // 0x000000018A90D914-0x000000018A90DA34
		internal void CalculateColliderState() {} // 0x000000018A90D800-0x000000018A90D914
		public override string ToString() => default; // 0x000000018A910314-0x000000018A910370
		public bool IsEquivalentTo(HEU_ObjectNode other) => default; // 0x000000018A90F9A4-0x000000018A90FC1C
	}

	public class HEU_PartData : ScriptableObject, IHEU_PartData, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_PartData> // TypeDefIndex: 50533
	{
		// Fields
		private int _partID; // 0x18
		private string _partName; // 0x20
		private int _objectNodeID; // 0x28
		private int _geoID; // 0x2C
		private HAPI_PartType _partType; // 0x30
		private HEU_GeoNode _geoNode; // 0x38
		private bool _isAttribInstancer; // 0x40
		private bool _isPartInstanced; // 0x41
		private int _partPointCount; // 0x44
		private bool _isObjectInstancer; // 0x48
		internal bool _objectInstancesGenerated; // 0x49
		private List<HEU_ObjectInstanceInfo> _objectInstanceInfos; // 0x50
		private Vector3 _terrainOffsetPosition; // 0x58
		private UnityEngine.Object _assetDBTerrainData; // 0x68
		private bool _isPartEditable; // 0x70
		private PartOutputType _partOutputType; // 0x74
		private HEU_Curve _curve; // 0x78
		private HEU_AttributesStore _attributesStore; // 0x80
		private bool _haveInstancesBeenGenerated; // 0x88
		private int _meshVertexCount; // 0x8C
		private HEU_GeneratedOutput _generatedOutput; // 0x90
		private string _volumeLayerName; // 0x98
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 
		public int PartID { get => default; } // 0x000000018A917D34-0x000000018A917D5C 
		public string PartName { get => default; } // 0x000000018A917CB0-0x000000018A917D34 
		public int GeoID { get => default; } // 0x000000018A9169C0-0x000000018A916A64 
		public HAPI_PartType PartType { get => default; } // 0x000000018A917310-0x000000018A917384 
		public HEU_GeoNode ParentGeoNode { get => default; } // 0x000000018A917110-0x000000018A917118 
		public List<HEU_ObjectInstanceInfo> ObjectInstanceInfos { get => default; } // 0x0000000185FB0650-0x0000000185FB0660 
		public HEU_Curve Curve { get => default; } // 0x000000018A9170F4-0x000000018A917108 
		public int MeshVertexCount { get => default; } // 0x0000000185FB0D70-0x0000000185FB0D80 
		public HEU_GeneratedOutput GeneratedOutput { get => default; } // 0x0000000183908D10-0x0000000183908D20 
		public GameObject OutputGameObject { get => default; } // 0x0000000185FB0750-0x0000000185FB0760 
	
		// Nested types
		public enum PartOutputType // TypeDefIndex: 50528
		{
			NONE = 0,
			MESH = 1,
			VOLUME = 2,
			CURVE = 3,
			INSTANCER = 4
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 50529
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<LOD> __9__96_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018A917D5C-0x000000018A917DCC
			public __c() {} // 0x00000001813AE560-0x00000001813AE570
	
			// Methods
			internal int _CopyGameObjectComponents_b__96_0(LOD a, LOD b) => default; // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		private sealed class __c__DisplayClass97_0 // TypeDefIndex: 50530
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass97_0() {} // 0x0000000185FB0630-0x0000000185FB0640
	
			// Methods
			internal void _CopyChildGameObjects_b__0(Transform trans) {} // 0x00000001813CFF60-0x00000001813CFF70
		}
	
		private sealed class __c__DisplayClass99_0 // TypeDefIndex: 50531
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass99_0() {} // 0x00000001813ECBC0-0x00000001813ECBD0
	
			// Methods
			internal void _BakePartToGameObject_b__0(Transform trans) {} // 0x0000000181460F60-0x0000000181460F70
		}
	
		private sealed class __c__DisplayClass99_1 // TypeDefIndex: 50532
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass99_1() {} // 0x0000000183060C50-0x0000000183060C60
	
			// Methods
			internal void _BakePartToGameObject_b__1(Transform trans) {} // 0x000000018349D720-0x000000018349D730
		}
	
		// Constructors
		public HEU_PartData() {} // 0x000000018A917120-0x000000018A917128
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x000000018A917108-0x000000018A917110
		public void Recook() {} // 0x000000018A917118-0x000000018A917120
		public bool IsPartInstancer() => default; // 0x0000000185FB0950-0x0000000185FB0960
		public bool IsAttribInstancer() => default; // 0x000000018316BFD0-0x000000018316BFE0
		public bool IsInstancerAnyType() => default; // 0x000000018A9173A8-0x000000018A9175A0
		public bool IsPartInstanced() => default; // 0x000000018A9175A0-0x000000018A9175D0
		public int GetPartPointCount() => default; // 0x00000001873350D4-0x00000001873350E8
		public bool IsObjectInstancer() => default; // 0x0000000181E336C0-0x0000000181E336D0
		public bool IsPartVolume() => default; // 0x000000018A913FBC-0x000000018A9140F4
		public bool IsPartCurve() => default; // 0x000000018A917128-0x000000018A917154
		public bool IsPartMesh() => default; // 0x000000018A9168B4-0x000000018A916958
		public bool IsPartEditable() => default; // 0x000000018A916958-0x000000018A9169C0
		public bool HaveInstancesBeenGenerated() => default; // 0x000000018A9166D0-0x000000018A916740
		public void SetGameObjectName(string partName) {} // 0x000000018A911354-0x000000018A911380
		public void SetGameObject(GameObject gameObject) {} // 0x000000018A911480-0x000000018A911568
		public void SetVolumeLayerName(string name) {} // 0x000000018A916484-0x000000018A916508
		public string GetVolumeLayerName() => default; // 0x000000018A917898-0x000000018A917A60
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02062CAF */) {} // 0x000000018A917384-0x000000018A9173A8
		public bool IsUsingMaterial(HEU_MaterialData materialData) => default; // 0x000000018A9167F0-0x000000018A9168B4
		public void GetOutputGameObjects(List<GameObject> outputObjects) {} // 0x000000018A916740-0x000000018A9167F0
		public void GetOutput(List<HEU_GeneratedOutput> outputs) {} // 0x0000000185FB99C0-0x0000000185FB99D0
		public HEU_PartData GetHDAPartWithGameObject(GameObject inGameObject) => default; // 0x000000018A9176F4-0x000000018A917898
		public void CalculateVisibility(bool bParentVisibility, bool bParentDisplayGeo) {} // 0x000000018A916A64-0x000000018A916C20
		public void ClearInstances() {} // 0x000000018A9105C4-0x000000018A9106FC
		public HEU_Curve GetCurve(bool bEditableOnly) => default; // 0x000000018A916508-0x000000018A9166D0
		public void SetVisiblity(bool bVisibility) {} // 0x000000018A916344-0x000000018A9163E8
		public void SetColliderState(bool bEnabled) {} // 0x000000018A9163E8-0x000000018A916484
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(string path) => default; // 0x0000000185FB0770-0x0000000185FB0780
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(int objNodeID) => default; // 0x000000018A911788-0x000000018A911840
		public void SetTerrainOffsetPosition(Vector3 offsetPosition) {} // 0x000000018A911568-0x000000018A911788
		public void SetTerrainData(TerrainData terrainData, string exportPathRelative, string exportPathUser) {} // 0x000000018A911380-0x000000018A91139C
		internal void Initialize(HEU_SessionBase session, int partID, int geoID, int objectNodeID, HEU_GeoNode geoNode, ref HAPI_PartInfo partInfo, PartOutputType partOutputType, bool isEditable, bool isObjectInstancer, bool isAttribInstancer) {} // 0x000000018A91139C-0x000000018A911438
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform) {} // 0x000000018A911438-0x000000018A911480
		internal void GetDebugInfo(StringBuilder sb) {} // 0x000000018A9161B0-0x000000018A916344
		internal void GetClonableObjects(List<GameObject> clonableObjects) {} // 0x000000018A914354-0x000000018A9147BC
		internal void GetClonableParts(List<HEU_PartData> clonableParts) {} // 0x000000018A914E38-0x000000018A9151AC
		private void SetObjectInstancer(bool bObjectInstancer) {} // 0x000000018A9147BC-0x000000018A914E38
		private void ClearObjectInstanceInfos() {} // 0x000000018A9151AC-0x000000018A915D7C
		internal void ClearInvalidObjectInstanceInfos() {} // 0x000000018A913A7C-0x000000018A913E70
		internal void ClearGeneratedData() {} // 0x000000018A9142B8-0x000000018A914354
		internal void ClearGeneratedMeshOutput() {} // 0x000000018A9110B8-0x000000018A911354
		internal void ClearGeneratedVolumeOutput() {} // 0x000000018A911CA8-0x000000018A913A7C
		internal bool GeneratePartInstances(HEU_SessionBase session) => default; // 0x000000018A9118F8-0x000000018A911CA8
		internal void GenerateInstancesFromObjectID(HEU_SessionBase session, int objectNodeID, string[] instancePrefixes, string[] instanceMaterialPaths) {} // 0x000000018A910F78-0x000000018A9110B8
		internal void GenerateInstancesFromObject(HEU_SessionBase session, HEU_ObjectNode sourceObject, string[] instancePrefixes, string[] instanceMaterialPaths) {} // 0x000000018A9106FC-0x000000018A910E2C
		internal void GenerateInstancesFromObjectIds(HEU_SessionBase session, string[] instancePrefixes, string[] instanceMaterialPaths) {} // 0x000000018A910E2C-0x000000018A910F78
		internal void GenerateInstancesFromUnityAssetPathAttribute(HEU_SessionBase session, string unityInstanceAttr) {} // 0x000000018A915D7C-0x000000018A9161B0
		private void CreateNewInstanceFromObject(GameObject sourceObject, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, int instancedObjectNodeID, string instancedObjectPath, Vector3 rotationOffset, Vector3 scaleOffset, string[] instancePrefixes, string[] instanceMaterialPaths, GameObject collisionSrcGO, bool copyParentFlags = true /* Metadata: 0x02062CB0 */) {} // 0x000000018A9171A8-0x000000018A917310
		internal void GenerateAttributesStore(HEU_SessionBase session) {} // 0x000000018A917B2C-0x000000018A917C54
		internal void CalculateColliderState() {} // 0x000000018A917A60-0x000000018A917B2C
		private static void CopyGameObjectComponents(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, List<HoudiniEngineUnity.TransformData> lodTransformValues) {} // 0x000000018A9140F4-0x000000018A9141D8
		private static void CopyChildGameObjects(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bKeepPreviousTransformValues) {} // 0x000000018A917154-0x000000018A9171A8
		internal GameObject BakePartToNewGameObject(Transform parentTransform, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances) => default; // 0x000000018A9175D0-0x000000018A9176F4
		internal static void BakePartToGameObject(HEU_PartData partData, GameObject srcGO, GameObject targetGO, string assetName, bool bIsInstancer, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues) {} // 0x0000000181460F60-0x0000000181460F70
		internal void BakePartToGameObject(GameObject targetGO, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues) {} // 0x000000018A913E70-0x000000018A913FBC
		internal bool GenerateMesh(HEU_SessionBase session, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups) => default; // 0x000000018A910588-0x000000018A9105C4
		internal void ProcessCurvePart(HEU_SessionBase session, int partId) {} // 0x000000018A917C54-0x000000018A917CB0
		internal void SyncAttributesStore(HEU_SessionBase session, int geoID, ref HAPI_PartInfo partInfo) {} // 0x000000018A91420C-0x000000018A9142B8
		internal void SetupAttributeGeometry(HEU_SessionBase session) {} // 0x000000018A9141D8-0x000000018A91420C
		internal void DestroyAttributesStore() {} // 0x000000018A911840-0x000000018A9118F8
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos) {} // 0x000000018A916C20-0x000000018A9170F4
		internal void SetObjectInstanceInfos(List<HEU_ObjectInstanceInfo> sourceObjectInstanceInfos) {} // 0x000000018A91800C-0x000000018A918070
		internal List<HEU_ObjectInstanceInfo> GetObjectInstanceInfos() => default; // 0x0000000185492010-0x0000000185492020
		private HEU_ObjectInstanceInfo CreateObjectInstanceInfo(GameObject instancedObject, int instancedObjectNodeID, string instancedObjectPath) => default; // 0x000000018A917DCC-0x000000018A917DE4
		internal static string AppendBakedCloneName(string name) => default; // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x000000018A917DE4-0x000000018A917E9C
		internal static void DestroyParts(List<HEU_PartData> parts, bool bIsRebuild = false /* Metadata: 0x02062CB1 */) {} // 0x0000000185492010-0x0000000185492020
		internal static void DestroyPart(HEU_PartData part, bool bIsRebuild = false /* Metadata: 0x02062CB2 */) {} // 0x000000018A917E9C-0x000000018A917F54
		internal static bool ComposeUnityInstanceSplitHierarchy(HEU_SessionBase session, int geoID, int partID, Transform parentTransform, int numInstances, ref Transform[] instanceToChildTransform) => default; // 0x0000000185492010-0x0000000185492020
		public bool IsEquivalentTo(HEU_PartData other) => default; // 0x000000018A917F54-0x000000018A91800C
	}

	[Serializable]
	internal sealed class HEU_AttributeData : IEquivable<HEU_AttributeData> // TypeDefIndex: 50536
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
		public enum AttributeType // TypeDefIndex: 50534
		{
			UNDEFINED = -1,
			BOOL = 0,
			INT = 1,
			FLOAT = 2,
			STRING = 3,
			MAX = 4
		}
	
		public enum AttributeState // TypeDefIndex: 50535
		{
			INVALID = 0,
			SYNCED = 1,
			LOCAL_DIRTY = 2
		}
	
		// Constructors
		public HEU_AttributeData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsColorAttribute() => default; // 0x000000018A904CA0-0x000000018A904CF8
		internal void CopyValuesTo(HEU_AttributeData destAttrData) {} // 0x000000018A904B6C-0x000000018A904CA0
		public bool IsEquivalentTo(HEU_AttributeData other) => default; // 0x000000018A904CF8-0x000000018A905004
	}

	internal class HEU_AttributesStore : ScriptableObject, IEquivable<HEU_AttributesStore> // TypeDefIndex: 50538
	{
		// Fields
		private int _geoID; // 0x18
		private int _partID; // 0x1C
		private string _geoName; // 0x20
		private List<HEU_AttributeData> _attributeDatas; // 0x28
		private bool _hasColorAttribute; // 0x30
		private Material _localMaterial; // 0x38
		private Transform _outputTransform; // 0x40
		private Vector3[] _positionAttributeValues; // 0x48
		private int[] _vertexIndices; // 0x50
		private GameObject _outputGameObject; // 0x58
		private Mesh _outputMesh; // 0x60
		private Material[] _outputMaterials; // 0x68
		private MeshCollider _outputCollider; // 0x70
		private Mesh _outputColliderMesh; // 0x78
		private MeshCollider _outputMeshCollider; // 0x80
		private MeshCollider _localMeshCollider; // 0x88
		private bool _outputMeshRendererInitiallyEnabled; // 0x90
		private bool _outputMeshColliderInitiallyEnabled; // 0x91
	
		// Properties
		public int GeoID { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public int PartID { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public string GeoName { get => default; } // 0x000000018A9054E8-0x000000018A9055FC 
		public Transform OutputTransform { get => default; } // 0x000000018A9073EC-0x000000018A9077B4 
		public Mesh OutputMesh { get => default; } // 0x000000018A905FDC-0x000000018A906100 
	
		// Nested types
		public delegate void SetAttributeValueFunc(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // TypeDefIndex: 50537; 0x00000001813AE570-0x00000001813AE580
	
		// Constructors
		public HEU_AttributesStore() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		public bool HasColorAttribute() => default; // 0x000000018A907A40-0x000000018A907CC0
		public void DestroyAllData(HEU_HoudiniAsset asset) {} // 0x000000018A907CC0-0x000000018A907D24
		public void SyncAllAttributesFrom(HEU_SessionBase session, HEU_HoudiniAsset asset, int geoID, ref HAPI_PartInfo partInfo, GameObject outputGameObject) {} // 0x000000018A9068CC-0x000000018A906FA4
		public void SetupMeshAndMaterials(HEU_HoudiniAsset asset, HAPI_PartType partType, GameObject outputGameObject) {} // 0x000000018A905EE4-0x000000018A905F54
		public bool HasDirtyAttributes() => default; // 0x000000018A907E74-0x000000018A907FD0
		public void SyncDirtyAttributesToHoudini(HEU_SessionBase session) {} // 0x000000018A907D24-0x000000018A907E74
		private void PopulateAttributeData(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData, ref HAPI_AttributeInfo attributeInfo) {} // 0x000000018A906FA4-0x000000018A906FDC
		private void GetAttributesList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributesList, HAPI_AttributeOwner ownerType, int attributeCount) {} // 0x000000018A907FD0-0x000000018A90807C
		private void UpdateAttribute(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData) {} // 0x000000018A9071BC-0x000000018A9071D8
		private void UpdateAttributeList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributeDataList) {} // 0x000000018A9071A0-0x000000018A9071BC
		public void RefreshUpstreamInputs(HEU_SessionBase session) {} // 0x000000018A905430-0x000000018A9054E8
		public bool UploadAttributeViaMeshInput(HEU_SessionBase session, int geoID, int partID) => default; // 0x000000018A905970-0x000000018A905AB0
		private static void SetAttributeDataSyncd(HEU_AttributeData attributeData) {} // 0x000000018A905AB0-0x000000018A905B20
		public static void SetAttributeDataDirty(HEU_AttributeData attributeData) {} // 0x000000018A905B20-0x000000018A905CB4
		public HEU_AttributeData CreateAttribute(string attributeName, ref HAPI_AttributeInfo attributeInfo) => default; // 0x000000018A905714-0x000000018A9058BC
		public HEU_AttributeData GetAttributeData(string name) => default; // 0x000000018A9055FC-0x000000018A905714
		public HEU_AttributeData GetAttributeData(int index) => default; // 0x000000018A9077B4-0x000000018A9078BC
		public List<string> GetAttributeNames() => default; // 0x000000018A906150-0x000000018A906228
		public void EnablePaintCollider() {} // 0x000000018A906100-0x000000018A906150
		public void DisablePaintCollider() {} // 0x000000018A905F54-0x000000018A905FBC
		public void ShowPaintMesh() {} // 0x000000018A906868-0x000000018A9068CC
		public void HidePaintMesh() {} // 0x000000018A90724C-0x000000018A9072C0
		public bool HasMeshForPainting() => default; // 0x000000018A9071D8-0x000000018A90724C
		public MeshCollider GetPaintMeshCollider() => default; // 0x000000018A9072C0-0x000000018A907348
		public void PaintAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools, int attributeIndex, float paintFactor, SetAttributeValueFunc setAttrFunc) {} // 0x000000018A907090-0x000000018A9071A0
		public static void SetAttributeEditValueInt(HEU_AttributeData attributeData, int startIndex, int[] values) {} // 0x000000018A9050B4-0x000000018A905180
		public static void SetAttributeEditValueFloat(HEU_AttributeData attributeData, int startIndex, float[] values) {} // 0x000000018A907974-0x000000018A907A40
		public static void SetAttributeEditValueString(HEU_AttributeData attributeData, int startIndex, string[] values) {} // 0x000000018A906758-0x000000018A906868
		public static void ReplaceAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A906FDC-0x000000018A907090
		public static void AddAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A905004-0x000000018A9050B4
		public static void SubtractAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A9078BC-0x000000018A907974
		public static void MultiplyAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A906698-0x000000018A906758
		public static void ReplaceAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A907348-0x000000018A9073EC
		public static void AddAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A9058BC-0x000000018A905970
		public static void SubtractAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A905180-0x000000018A905298
		public static void MultiplyAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A905FBC-0x000000018A905FCC
		public static void SetAttributeValueString(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor) {} // 0x000000018A905FCC-0x000000018A905FDC
		public void FillAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools) {} // 0x000000018A905CB4-0x000000018A905EE4
		public bool AreAttributesDirty() => default; // 0x000000018A905298-0x000000018A905430
		public void GetPositionAttributeValues(out Vector3[] positionArray) {
			positionArray = default;
		} // 0x000000018A906680-0x000000018A906698
		public void GetVertexIndices(out int[] indices) {
			indices = default;
		} // 0x000000018A906228-0x000000018A906680
		public static SetAttributeValueFunc GetAttributeSetValueFunction(HEU_AttributeData.AttributeType attrType, HEU_ToolsInfo.PaintMergeMode paintMergeMode) => default; // 0x000000018A90807C-0x000000018A90814C
		public void CopyAttributeValuesTo(HEU_AttributesStore destAttrStore) {} // 0x000000018A9335D8-0x000000018A9336AC
		public bool IsValidStore(HEU_SessionBase session) => default; // 0x00000001817C0490-0x00000001817C04B0
		public bool IsEquivalentTo(HEU_AttributesStore other) => default; // 0x000000018A93350C-0x000000018A9335D8
	}

	[Serializable]
	public class HEU_OutputAttribute // TypeDefIndex: 50539
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
		public HEU_OutputAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_OutputAttributeDictionary : HEU_SerializableDictionary<string, HEU_OutputAttribute> // TypeDefIndex: 50540
	{
		// Constructors
		public HEU_OutputAttributeDictionary() {} // 0x000000018A91DFA0-0x000000018A91DFC8
	}

	public class HEU_OutputAttributesStore : MonoBehaviour // TypeDefIndex: 50541
	{
		// Fields
		private HEU_OutputAttributeDictionary _attributes; // 0x18
	
		// Constructors
		public HEU_OutputAttributesStore() {} // 0x000000018A91E148-0x000000018A91E1B8
	
		// Methods
		public void SetAttribute(HEU_OutputAttribute attribute) {} // 0x000000018A91E078-0x000000018A91E148
		public HEU_OutputAttribute GetAttribute(string name) => default; // 0x000000018A91E010-0x000000018A91E078
		public void Clear() {} // 0x000000018A91DFC8-0x000000018A91E010
	}

	public static class HEU_AssetDatabase // TypeDefIndex: 50543
	{
		// Nested types
		public enum HEU_ImportAssetOptions // TypeDefIndex: 50542
		{
			Default = 0,
			ForceUpdate = 1,
			ForceSynchronousImport = 8,
			ImportRecursive = 256,
			DontDownloadFromCacheServer = 8192,
			ForceUncompressedImport = 16384
		}
	
		// Methods
		public static string GetAssetCachePath() => default; // 0x000000018A918FEC-0x000000018A919034
		public static string GetUnityProjectPath() => default; // 0x000000018A9197C8-0x000000018A919824
		public static string GetAssetRelativePath(string inFullPath) => default; // 0x000000018A919180-0x000000018A9192C0
		public static string GetPackagesRelativePath(string inFullPath) => default; // 0x000000018A919450-0x000000018A919570
		public static string GetValidAssetPath(string inPath) => default; // 0x000000018A919824-0x000000018A919B4C
		public static string GetAssetPath(UnityEngine.Object asset) => default; // 0x000000018A9190F0-0x000000018A919128
		public static string GetAssetPathWithSubAssetSupport(UnityEngine.Object asset) => default; // 0x000000018A9190B8-0x000000018A9190F0
		public static void GetSubAssetPathFromPath(string fullPath, out string mainPath, out string subPath) {
			mainPath = default;
			subPath = default;
		} // 0x000000018A919570-0x000000018A9196E0
		private static string GetAssetRelativePathStart() => default; // 0x000000018A919128-0x000000018A919180
		private static string GetPackagesRelativePathStart() => default; // 0x000000018A9193F8-0x000000018A919450
		public static string GetAssetFullPath(string inPath) => default; // 0x000000018A919034-0x000000018A919080
		public static bool IsPathRelativeToAssets(string inPath) => default; // 0x000000018A919DA4-0x000000018A919E28
		public static bool IsPathRelativeToPackages(string inPath) => default; // 0x000000018A919E28-0x000000018A919EAC
		public static string GetAssetRootPath(UnityEngine.Object asset) => default; // 0x000000018A9192C0-0x000000018A9192F8
		public static string GetUniqueAssetPath(string path) => default; // 0x000000018A919790-0x000000018A9197C8
		public static string GetAssetOrScenePath(UnityEngine.Object inputObject) => default; // 0x000000018A919080-0x000000018A9190B8
		public static bool IsPathInAssetCache(string path) => default; // 0x000000018A919C98-0x000000018A919DA4
		public static bool IsPathInAssetCacheBakedFolder(string path) => default; // 0x000000018A919C28-0x000000018A919C60
		public static bool IsPathInAssetCacheWorkingFolder(string path) => default; // 0x000000018A919C60-0x000000018A919C98
		public static bool IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset) => default; // 0x000000018A919B80-0x000000018A919BB8
		public static bool IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset) => default; // 0x000000018A919BB8-0x000000018A919BF0
		public static string CreateAssetCacheFolder(string suggestedAssetPath, int hash = 0 /* Metadata: 0x02062CC1 */) => default; // 0x000000018A918DA0-0x000000018A918DD8
		public static void DeleteAssetCacheFolder(string assetCacheFolderPath) {} // 0x000000018A918EE0-0x000000018A918F14
		public static void DeleteAsset(UnityEngine.Object asset) {} // 0x000000018A918F48-0x000000018A918F7C
		public static void DeleteAssetAtPath(string path) {} // 0x000000018A918EAC-0x000000018A918EE0
		public static void DeleteAssetIfInBakedFolder(UnityEngine.Object asset) {} // 0x000000018A918F14-0x000000018A918F48
		public static bool ContainsAsset(UnityEngine.Object assetObject) => default; // 0x000000018A918BE4-0x000000018A918C1C
		public static bool CopyAsset(string path, string newPath) => default; // 0x000000018A918CFC-0x000000018A918D34
		public static UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, string copyAssetFolder, string relativePath, System.Type type, bool bOverwriteExisting) => default; // 0x000000018A918CC4-0x000000018A918CFC
		public static UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting) => default; // 0x000000018A918C8C-0x000000018A918CC4
		public static UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting) => default; // 0x000000018A918C1C-0x000000018A918C54
		public static UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, string targetPath, System.Type type) => default; // 0x000000018A918C54-0x000000018A918C8C
		public static UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type) => default; // 0x000000018A918D34-0x000000018A918D6C
		public static void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, string assetCacheRoot, string relativeFolderPath, string assetFileName, System.Type type, bool bOverwriteExisting) {} // 0x000000018A918E0C-0x000000018A918E40
		public static void CreateAsset(UnityEngine.Object asset, string path) {} // 0x000000018A918DD8-0x000000018A918E0C
		public static void CreateAddObjectInAssetCacheFolder(string assetName, string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref string exportRootPath, ref UnityEngine.Object assetDBObject) {} // 0x000000018A918D6C-0x000000018A918DA0
		public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject) {} // 0x000000018A9188EC-0x000000018A918920
		public static void SaveAndRefreshDatabase() {} // 0x0000000185492010-0x0000000185492020
		public static void SaveAssetDatabase() {} // 0x0000000185492010-0x0000000185492020
		public static void RefreshAssetDatabase() {} // 0x0000000185492010-0x0000000185492020
		public static UnityEngine.Object LoadAssetAtPath(string assetPath, System.Type type) => default; // 0x000000018A919F1C-0x000000018A919F54
		public static UnityEngine.Object LoadSubAssetAtPath(string mainPath, string subAssetPath) => default; // 0x000000018A919F54-0x000000018A919FEC
		public static UnityEngine.Object[] LoadAllAssetsAtPath(string assetPath) => default; // 0x000000018A919EE4-0x000000018A919F1C
		public static UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(string assetPath) => default; // 0x000000018A919EAC-0x000000018A919EE4
		public static void ImportAsset(string assetPath, HEU_ImportAssetOptions heuOptions) {} // 0x000000018A919B4C-0x000000018A919B80
		public static string GetAssetWorkingPath() => default; // 0x000000018A9193C0-0x000000018A9193F8
		public static string GetAssetBakedPath() => default; // 0x000000018A918FB4-0x000000018A918FEC
		public static string GetAssetBakedPathWithAssetName(string assetName) => default; // 0x000000018A918F7C-0x000000018A918FB4
		public static string CreateUniqueBakePath(string assetName) => default; // 0x000000018A918E74-0x000000018A918EAC
		public static void CreatePathWithFolders(string inPath) {} // 0x000000018A918E40-0x000000018A918E74
		public static string AppendMeshesPathToAssetFolder(string inAssetCacheFolder) => default; // 0x000000018A9189D8-0x000000018A918A54
		public static string AppendTexturesPathToAssetFolder(string inAssetCacheFolder) => default; // 0x000000018A918B68-0x000000018A918BE4
		public static string AppendMaterialsPathToAssetFolder(string inAssetCacheFolder) => default; // 0x000000018A918920-0x000000018A91899C
		public static string AppendTerrainPathToAssetFolder(string inAssetCacheFolder) => default; // 0x000000018A918AEC-0x000000018A918B68
		public static string[] GetAssetSubFolders() => default; // 0x000000018A9192F8-0x000000018A9193C0
		public static string AppendPrefabPath(string inAssetCacheFolder, string assetName) => default; // 0x000000018A918A54-0x000000018A918AEC
		public static string AppendMeshesAssetFileName(string assetName) => default; // 0x000000018A91899C-0x000000018A9189D8
		public static bool IsSubAsset(UnityEngine.Object obj) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static string[] GetAssetPathsFromAssetBundle(string assetBundleFileName) => default; // 0x00000001813AE580-0x00000001813AE590
		public static bool IsAssetSavedInScene(GameObject go) => default; // 0x000000018A919BF0-0x000000018A919C28
		public static void SelectAssetAtPath(string path) {} // 0x0000000185492010-0x0000000185492020
		public static void PrintDependencies(GameObject targetGO) {} // 0x0000000185492010-0x0000000185492020
		public static string GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj) => default; // 0x000000018A9196E0-0x000000018A919790
		public static bool IsValidFolderName(string name) => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static T LoadUnityAssetFromUniqueAssetPath<T>(string assetPath)
			where T : UnityEngine.Object => default;
		public static T GetBuiltinExtraResource<T>(string resourceName)
			where T : UnityEngine.Object => default;
	}

	public class HEU_Defines // TypeDefIndex: 50544
	{
		// Fields
		public const string HEU_PRODUCT_NAME = "HoudiniEngine"; // Metadata: 0x02062CCF
		public const string HEU_NAME = "Houdini Engine"; // Metadata: 0x02062CDD
		public static string HEU_PLUGIN_PATH; // 0x00
		public static string HEU_TEXTURES_PATH; // 0x08
		public static string HEU_BAKED_ASSETS_PATH; // 0x10
		public static string HEU_ENGINE_ASSETS; // 0x18
		public const string HAPI_PATH = "HAPI_PATH"; // Metadata: 0x02062CEC
		public const string HEU_ENVPATH_PREFIX = "HEU_ENVPATH_"; // Metadata: 0x02062CF6
		public const string HEU_ENVPATH_KEY = "$"; // Metadata: 0x02062D03
		public const int HEU_INVALID_NODE_ID = -1; // Metadata: 0x02062D05
		public const string HEU_DEFAULT_ASSET_NAME = "HoudiniAssetRoot"; // Metadata: 0x02062D06
		public const string HEU_SESSION_PIPENAME = "hapi"; // Metadata: 0x02062D17
		public const string HEU_SESSION_LOCALHOST = "localhost"; // Metadata: 0x02062D1C
		public const int HEU_SESSION_PORT = 9090; // Metadata: 0x02062D26
		public const string HEU_SESSION_SHARED_MEMORY_NAME = "hapi"; // Metadata: 0x02062D2A
		public const int HEU_SESSION_SHARED_MEMORY_BUFFER_SIZE = 100; // Metadata: 0x02062D2F
		public const HAPI_ThriftSharedMemoryBufferType HEU_SESSION_SHARED_MEMORY_BUFFER_TYPE = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER; // Metadata: 0x02062D31
		public const float HEU_SESSION_TIMEOUT = 100000f; // Metadata: 0x02062D32
		public const bool HEU_SESSION_AUTOCLOSE = true; // Metadata: 0x02062D36
		public const int HAPI_MAX_PAGE_SIZE = 500000; // Metadata: 0x02062D37
		public const int HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW = 3; // Metadata: 0x02062D3B
		public const int HAPI_MAX_VERTICES_PER_FACE = 3; // Metadata: 0x02062D3C
		public const bool HAPI_CURVE_REFINE_TO_LINEAR = true; // Metadata: 0x02062D3D
		public const float HAPI_CURVE_LOD = 8f; // Metadata: 0x02062D3E
		public const float HAPI_VOLUME_POSITION_MULT = 2f; // Metadata: 0x02062D42
		public const float HAPI_VOLUME_SURFACE_MAX_PT_PER_C = 64000f; // Metadata: 0x02062D46
		public const float HAPI_VOLUME_SURFACE_DELTA_MULT = 1.2f; // Metadata: 0x02062D4A
		public const float HAPI_VOLUME_SURFACE_PT_SIZE_MULT = 1800f; // Metadata: 0x02062D4E
		public const string DEFAULT_TOP_NODE_FILTER = "HE_"; // Metadata: 0x02062D52
		public const string DEFAULT_TOP_OUTPUT_FILTER = "HE_OUT_"; // Metadata: 0x02062D56
		public const string HAPI_ATTRIB_ORIENT = "orient"; // Metadata: 0x02062D5E
		public const string HAPI_ATTRIB_ROTATION = "rot"; // Metadata: 0x02062D65
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x02062D69
		public const string HAPI_ATTRIB_ALPHA = "Alpha"; // Metadata: 0x02062D6F
		public const string HAPI_HANDLE_TRANSFORM = "xform"; // Metadata: 0x02062D75
		public const int HAPI_MAX_UVS = 8; // Metadata: 0x02062D7B
		public const string HAPI_OBJMERGE_TRANSFORM_PARAM = "xformtype"; // Metadata: 0x02062D7C
		public const string HAPI_OBJMERGE_PACK_GEOMETRY = "pack"; // Metadata: 0x02062D86
		public const string HAPI_OBJPATH_1_PARAM = "objpath1"; // Metadata: 0x02062D8B
		public const string NO_EXISTING_SESSION = "No existing session."; // Metadata: 0x02062D94
		public const string HEU_ERROR_TITLE = "Houdini Engine Error"; // Metadata: 0x02062DA9
		public const string HEU_INSTALL_INFO = "Houdini Engine Installation Info"; // Metadata: 0x02062DBE
		public const string PLUGIN_STORE_KEYS = "HoudiniEnginePluginKeys"; // Metadata: 0x02062DDF
		public const string PLUGIN_STORE_DATA = "HoudiniEnginePluginData"; // Metadata: 0x02062DF7
		public const string PLUGIN_SESSION_DATA = "HoudiniEngineSession"; // Metadata: 0x02062E0F
		public const string PLUGIN_SETTINGS_FILE = "heu_settings.ini"; // Metadata: 0x02062E24
		public const string PLUGIN_SESSION_FILE = "heu_session.txt"; // Metadata: 0x02062E35
		public const string COOK_LOGS_FILE = "cook_logs_file.txt"; // Metadata: 0x02062E45
		public const string DEFAULT_COLLISION_GEO = "collision_geo"; // Metadata: 0x02062E58
		public const string DEFAULT_RENDERED_COLLISION_GEO = "rendered_collision_geo"; // Metadata: 0x02062E66
		public const string DEFAULT_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo"; // Metadata: 0x02062E7D
		public const string DEFAULT_CONVEX_COLLISION_GEO = "convex"; // Metadata: 0x02062E9B
		public const string DEFAULT_SIMPLE_COLLISION_GEO = "collision_geo_simple"; // Metadata: 0x02062EA2
		public const string DEFAULT_SIMPLE_RENDERED_COLLISION_GEO = "rendered_collision_geo_simple"; // Metadata: 0x02062EB7
		public const string DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo_simple"; // Metadata: 0x02062ED5
		public const string DEFAULT_COLLISION_TRIGGER = "trigger"; // Metadata: 0x02062EFA
		public const string DEFAULT_UNITY_MATERIAL_ATTR = "unity_material"; // Metadata: 0x02062F02
		public const string DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR = "unity_sub_material_name"; // Metadata: 0x02062F11
		public const string DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR = "unity_sub_material_index"; // Metadata: 0x02062F29
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR = "unity_hf_texture_diffuse"; // Metadata: 0x02062F42
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR = "unity_hf_texture_mask"; // Metadata: 0x02062F5B
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR = "unity_hf_texture_normal"; // Metadata: 0x02062F71
		public const string DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR = "unity_hf_normal_scale"; // Metadata: 0x02062F89
		public const string DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR = "unity_hf_metallic"; // Metadata: 0x02062F9F
		public const string DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR = "unity_hf_smoothness"; // Metadata: 0x02062FB1
		public const string DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR = "unity_hf_specular"; // Metadata: 0x02062FC5
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR = "unity_hf_tile_offset"; // Metadata: 0x02062FD7
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR = "unity_hf_tile_size"; // Metadata: 0x02062FEC
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR = "unity_hf_terraindata_file"; // Metadata: 0x02062FFF
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR = "unity_hf_terraindata_export_file"; // Metadata: 0x02063019
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR = "unity_hf_terrainlayer_file"; // Metadata: 0x0206303A
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH = "unity_hf_terraindata_export_path"; // Metadata: 0x02063055
		public const string DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE = "unity_hf_height_range"; // Metadata: 0x02063076
		public const string DEFAULT_UNITY_HEIGHTFIELD_YPOS = "unity_hf_ypos"; // Metadata: 0x0206308C
		public const string HEIGHTFIELD_TREEPROTOTYPE = "unity_hf_tree_prototype"; // Metadata: 0x0206309A
		public const string HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX = "unity_hf_treeinstance_prototypeindex"; // Metadata: 0x020630B2
		public const string HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE = "unity_hf_treeinstance_heightscale"; // Metadata: 0x020630D7
		public const string HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE = "unity_hf_treeinstance_widthscale"; // Metadata: 0x020630F9
		public const string HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR = "unity_hf_treeinstance_lightmapcolor"; // Metadata: 0x0206311A
		public const string HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH = "unity_hf_detail_resolution_patch"; // Metadata: 0x0206313E
		public const string HEIGHTFIELD_UNITY_TILE = "unity_hf_tile"; // Metadata: 0x0206315F
		public const string HEIGHTFIELD_DETAIL_DISTANCE = "unity_hf_detail_distance"; // Metadata: 0x0206316D
		public const string HEIGHTFIELD_DETAIL_DENSITY = "unity_hf_detail_density"; // Metadata: 0x02063186
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB = "unity_hf_detail_prototype_prefab"; // Metadata: 0x0206319E
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE = "unity_hf_detail_prototype_texture"; // Metadata: 0x020631BF
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR = "unity_hf_detail_prototype_bendfactor"; // Metadata: 0x020631E1
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR = "unity_hf_detail_prototype_drycolor"; // Metadata: 0x02063206
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR = "unity_hf_detail_prototype_healthycolor"; // Metadata: 0x02063229
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT = "unity_hf_detail_prototype_maxheight"; // Metadata: 0x02063250
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH = "unity_hf_detail_prototype_maxwidth"; // Metadata: 0x02063274
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT = "unity_hf_detail_prototype_minheight"; // Metadata: 0x02063297
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH = "unity_hf_detail_prototype_minwidth"; // Metadata: 0x020632BB
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD = "unity_hf_detail_prototype_noisespread"; // Metadata: 0x020632DE
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE = "unity_hf_detail_prototype_rendermode"; // Metadata: 0x02063304
		public const string HEIGHTFIELD_LAYER_ATTR_TYPE = "unity_hf_layer_type"; // Metadata: 0x02063329
		public const string HEIGHTFIELD_LAYER_TYPE_DETAIL = "detail"; // Metadata: 0x0206333D
		public const string HAPI_HEIGHTFIELD_TILE_ATTR = "tile"; // Metadata: 0x02063344
		public const string HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT = "height"; // Metadata: 0x02063349
		public const string HAPI_HEIGHTFIELD_LAYERNAME_MASK = "mask"; // Metadata: 0x02063350
		public const string MAT_OGL_DIFF_ATTR = "ogl_diff"; // Metadata: 0x02063355
		public const string MAT_DIFF_ATTR = "basecolor"; // Metadata: 0x0206335E
		public const string MAT_OGL_TEX1_ATTR = "ogl_tex1"; // Metadata: 0x02063368
		public const string MAT_OGL_TEX1_ATTR_ENABLED = "ogl_use_tex1"; // Metadata: 0x02063371
		public const string MAT_BASECOLOR_ATTR = "basecolor_texture"; // Metadata: 0x0206337E
		public const string MAT_BASECOLOR_ATTR_ENABLED = "basecolor_useTexture"; // Metadata: 0x02063390
		public const string MAT_MAP_ATTR = "map"; // Metadata: 0x020633A5
		public const string MAT_OGL_NORMAL_ATTR = "ogl_normalmap"; // Metadata: 0x020633A9
		public const string MAT_NORMAL_ATTR = "baseNormal_texture"; // Metadata: 0x020633B7
		public const string MAT_NORMAL_ATTR_ENABLED = "baseBumpAndNormal_enable"; // Metadata: 0x020633CA
		public const string MAT_OGL_SPEC_ATTR = "ogl_spec"; // Metadata: 0x020633E3
		public const string MAT_SPEC_ATTR = "reflect"; // Metadata: 0x020633EC
		public const string MAT_OGL_SPEC_MAP_ATTR = "ogl_specmap"; // Metadata: 0x020633F4
		public const string MAT_OGL_SPEC_MAP_ATTR_ENABLED = "ogl_use_specmap"; // Metadata: 0x02063400
		public const string MAT_SPEC_MAP_ATTR = "reflect_texture"; // Metadata: 0x02063410
		public const string MAT_SPEC_MAP_ATTR_ENABLED = "reflect_useTexture"; // Metadata: 0x02063420
		public const string MAT_OGL_ROUGH_ATTR = "ogl_rough"; // Metadata: 0x02063433
		public const string MAT_ROUGH_ATTR = "rough"; // Metadata: 0x0206343D
		public const string MAT_OGL_ROUGH_MAP_ATTR = "ogl_roughmap"; // Metadata: 0x02063443
		public const string MAT_OGL_ROUGH_MAP_ATTR_ENABLED = "ogl_use_roughmap"; // Metadata: 0x02063450
		public const string MAT_ROUGH_MAP_ATTR = "rough_texture"; // Metadata: 0x02063461
		public const string MAT_ROUGH_MAP_ATTR_ENABLED = "rough_useTexture"; // Metadata: 0x0206346F
		public const string MAT_OGL_METALLIC_ATTR = "ogl_metallic"; // Metadata: 0x02063480
		public const string MAT_METALLIC_ATTR = "metallic"; // Metadata: 0x0206348D
		public const string MAT_OGL_METALLIC_MAP_ATTR = "ogl_metallicmap"; // Metadata: 0x02063496
		public const string MAT_OGL_METALLIC_MAP_ATTR_ENABLED = "ogl_use_metallicmap"; // Metadata: 0x020634A6
		public const string MAT_METALLIC_MAP_ATTR = "metallic_texture"; // Metadata: 0x020634BA
		public const string MAT_METALLIC_MAP_ATTR_ENABLED = "metallic_useTexture"; // Metadata: 0x020634CB
		public const string MAT_OGL_EMISSIVE_ATTR = "ogl_emit"; // Metadata: 0x020634DF
		public const string MAT_EMISSIVE_ATTR = "emitcolor"; // Metadata: 0x020634E8
		public const string MAT_OGL_EMISSIVE_MAP_ATTR = "ogl_emissionmap"; // Metadata: 0x020634F2
		public const string MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED = "ogl_use_emissionmap"; // Metadata: 0x02063502
		public const string MAT_EMISSIVE_MAP_ATTR = "emitcolor_texture"; // Metadata: 0x02063516
		public const string MAT_EMISSIVE_MAP_ATTR_ENABLED = "emitcolor_useTexture"; // Metadata: 0x02063528
		public const string MAT_OGL_ALPHA_ATTR = "ogl_alpha"; // Metadata: 0x0206353D
		public const string MAT_ALPHA_ATTR = "opac"; // Metadata: 0x02063547
		public const string MAT_OGL_OPACITY_MAP_ATTR = "ogl_opacitymap"; // Metadata: 0x0206354C
		public const string MAT_OGL_OPACITY_MAP_ATTR_ENABLED = "ogl_use_opacitymap"; // Metadata: 0x0206355B
		public const string MAT_OPACITY_MAP_ATTR = "opaccolor_texture"; // Metadata: 0x0206356E
		public const string MAT_OPACITY_MAP_ATTR_ENABLED = "opaccolor_useTexture"; // Metadata: 0x02063580
		public const string MAT_OGL_TRANSPARENCY_ATTR = "ogl_transparency"; // Metadata: 0x02063595
		public const string MAT_OGL_TRANSPARENCY_ATTR_ENABLED = "ogl_use_alpha_transparency"; // Metadata: 0x020635A6
		public const string MAT_OGL_OCCLUSION_MAP_ATTR = "ogl_occlusionmap"; // Metadata: 0x020635C1
		public const string MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED = "ogl_use_occlusionmap"; // Metadata: 0x020635D2
		public const string CURVE_COORDS_PARAM = "coords"; // Metadata: 0x020635E7
		public const string CURVE_TYPE_PARAM = "type"; // Metadata: 0x020635EE
		public const string CURVE_METHOD_PARAM = "method"; // Metadata: 0x020635F3
		public const string CURVE_CLOSE_PARAM = "close"; // Metadata: 0x020635FA
		public const string CURVE_REVERSE_PARAM = "reverse"; // Metadata: 0x02063600
		public const string HENGINE_STORE_ATTR = "hengine_attr_store"; // Metadata: 0x02063608
		public const string DEFAULT_UNITY_TAG_ATTR = "unity_tag"; // Metadata: 0x0206361B
		public const string DEFAULT_UNITY_SCRIPT_ATTR = "unity_script"; // Metadata: 0x02063625
		public const string DEFAULT_UNITY_INSTANCE_ATTR = "unity_instance"; // Metadata: 0x02063632
		public const string UNITY_USE_INSTANCE_FLAGS_ATTR = "unity_use_instance_flags"; // Metadata: 0x02063641
		public const string DEFAULT_UNITY_INPUT_MESH_ATTR = "unity_input_mesh_name"; // Metadata: 0x0206365A
		public const string DEFAULT_UNITY_STATIC_ATTR = "unity_static"; // Metadata: 0x02063670
		public const string DEFAULT_UNITY_LAYER_ATTR = "unity_layer"; // Metadata: 0x0206367D
		public const string DEFAULT_UNITY_MESH_READABLE = "unity_mesh_readable"; // Metadata: 0x02063689
		public const string DEFAULT_INSTANCE_PREFIX_ATTR = "instance_prefix"; // Metadata: 0x0206369D
		public const string UNITY_SHADER_COLOR = "_Color"; // Metadata: 0x020636AD
		public const string UNITY_SHADER_SPEC_COLOR = "_SpecColor"; // Metadata: 0x020636B4
		public const string UNITY_SHADER_SPEC_MAP = "_SpecMap"; // Metadata: 0x020636BF
		public const string UNITY_SHADER_METALLIC = "_Metallic"; // Metadata: 0x020636C8
		public const string UNITY_SHADER_METALLIC_MAP = "_MetallicMap"; // Metadata: 0x020636D2
		public const string UNITY_SHADER_BUMP_MAP = "_BumpMap"; // Metadata: 0x020636DF
		public const string UNITY_SHADER_EMISSION_COLOR = "_EmissionColor"; // Metadata: 0x020636E8
		public const string UNITY_SHADER_EMISSION_MAP = "_EmissionMap"; // Metadata: 0x020636F7
		public const string UNITY_SHADER_SMOOTHNESS = "_Smoothness"; // Metadata: 0x02063704
		public const string UNITY_SHADER_SMOOTHNESS_MAP = "_SmoothnessMap"; // Metadata: 0x02063710
		public const string UNITY_SHADER_SHININESS = "_Shininess"; // Metadata: 0x0206371F
		public const string UNITY_SHADER_OCCLUSION = "_Occlusion"; // Metadata: 0x0206372A
		public const string UNITY_SHADER_OCCLUSION_MAP = "_OcclusionMap"; // Metadata: 0x02063735
		public const string UNITY_SHADER_OPACITY = "_Opacity"; // Metadata: 0x02063743
		public const string UNITY_SHADER_OPACITY_MAP = "_OpacityMap"; // Metadata: 0x0206374C
		public const string UNITY_EDITORONLY_TAG = "EditorOnly"; // Metadata: 0x02063758
		public const string UNITY_HDADATA_NAME = "HDA_Data"; // Metadata: 0x02063763
		public const string HOUDINI_SHADER_PREFIX = "Houdini/"; // Metadata: 0x0206376C
		public const string DEFAULT_STANDARD_SHADER = "HoudiniStandard"; // Metadata: 0x02063775
		public const string DEFAULT_VERTEXCOLOR_SHADER = "HoudiniStandard"; // Metadata: 0x02063785
		public const string DEFAULT_TRANSPARENT_SHADER = "HoudiniStandardAlpha"; // Metadata: 0x02063795
		public const string DEFAULT_STANDARD_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x020637AA
		public const string DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x020637BA
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x020637D5
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x020637E5
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR = "HoudiniSpecularAlpha"; // Metadata: 0x02063800
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY = "Legacy/AlphaSpecularVertexColor"; // Metadata: 0x02063815
		public const string DEFAULT_CURVE_SHADER = "LineShader"; // Metadata: 0x02063835
		public const string DEFAULT_TERRAIN_SHADER = "Nature/Terrain/Standard"; // Metadata: 0x02063840
		public const string DEFAULT_STANDARD_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x02063858
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x02063869
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP = "HDRP/StandardLitAlpha"; // Metadata: 0x0206387A
		public const string DEFAULT_STANDARD_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x02063890
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x020638A1
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR = "HDRP/SpecularLitAlpha"; // Metadata: 0x020638B2
		public const string DEFAULT_CURVE_SHADER_HDRP = "HDRP/Color"; // Metadata: 0x020638C8
		public const string DEFAULT_TERRAIN_SHADER_HDRP = "HDRP/TerrainLit"; // Metadata: 0x020638D3
		public const string DEFAULT_STANDARD_SHADER_URP = "URP/StandardLit"; // Metadata: 0x020638E3
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP = "URP/StandardLit"; // Metadata: 0x020638F3
		public const string DEFAULT_TRANSPARENT_SHADER_URP = "URP/StandardLitAlpha"; // Metadata: 0x02063903
		public const string DEFAULT_STANDARD_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x02063918
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x02063928
		public const string DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR = "URP/SpecularLitAlpha"; // Metadata: 0x02063938
		public const string DEFAULT_CURVE_SHADER_URP = "URP/Color"; // Metadata: 0x0206394D
		public const string DEFAULT_TERRAIN_SHADER_URP = "Universal Render Pipeline/Terrain/Lit"; // Metadata: 0x02063957
		public const string DEFAULT_UNITY_BUILTIN_RESOURCES = "Resources/unity_builtin_extra"; // Metadata: 0x0206397D
		public const string DEFAULT_TERRAIN_MATERIAL_PATH = "Resources/unity_builtin_extra::name::Default-Terrain-Standard"; // Metadata: 0x0206399B
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_HDRP = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipelineResources/Material/DefaultHDTerrainMaterial.mat"; // Metadata: 0x020639D9
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_URP = "Packages/com.unity.render-pipelines.universal/Runtime/Materials/TerrainLit.mat"; // Metadata: 0x02063A54
		public const string DEFAULT_MATERIAL = "HEU_DEFAULT_MATERIAL"; // Metadata: 0x02063AA4
		public static int DEFAULT_MATERIAL_KEY; // 0x20
		public const string EDITABLE_MATERIAL = "HEU_EDITABLE_MATERIAL"; // Metadata: 0x02063AB9
		public static int EDITABLE_MATERIAL_KEY; // 0x24
		public const int HEU_INVALID_MATERIAL = -1; // Metadata: 0x02063ACF
		public const string HEU_ASSET_CACHE_PATH = "HoudiniEngineAssetCache"; // Metadata: 0x02063AD0
		public const string HEU_WORKING_PATH = "Working"; // Metadata: 0x02063AE8
		public const string HEU_BAKED_PATH = "Baked"; // Metadata: 0x02063AF0
		public const string HEU_BAKED_HDA = "_bakedHDA"; // Metadata: 0x02063AF6
		public const string HEU_BAKED_CLONE = "_bakedClone"; // Metadata: 0x02063B00
		public const string HEU_INSTANCE = "_Instance"; // Metadata: 0x02063B0C
		public const string HEU_INSTANCE_PATTERN = "_Instance\\d*\\z"; // Metadata: 0x02063B16
		public const string HEU_INSTANCE_SPLIT_ATTR = "unity_split_attr"; // Metadata: 0x02063B25
		public const string HEU_DEFAULT_GEO_GROUP_NAME = "main_geo"; // Metadata: 0x02063B36
		public const string HEU_DEFAULT_LOD_NAME = "lod"; // Metadata: 0x02063B3F
		public const string HEU_UNITY_LOD_TRANSITION_ATTR = "lod_screensizes"; // Metadata: 0x02063B43
		public const string HEU_SUBASSET = "SUBASSET::"; // Metadata: 0x02063B53
		public const string HEU_HENGINE_TOOLS_SHIPPED_FOLDER = "<HFS>/engine/tools"; // Metadata: 0x02063B5E
		public const string HEU_HENGINE_SHIPPED_SHELF = "Default"; // Metadata: 0x02063B71
		public const string HEU_PATH_KEY_PROJECT = "<PROJECT_PATH>"; // Metadata: 0x02063B79
		public const string HEU_PATH_KEY_PLUGIN = "<PLUGIN_PATH>"; // Metadata: 0x02063B88
		public const string HEU_PATH_KEY_HFS = "<HFS>"; // Metadata: 0x02063B96
		public const string HEU_PATH_KEY_TOOL = "HOUDINI_TOOL_PATH"; // Metadata: 0x02063B9C
		public const string HEU_USERMSG_NONEDITOR_NOT_SUPPORTED = "Houdini Engine does not support non-Editor asset creation at this time!"; // Metadata: 0x02063BAE
		public const string HEU_TERRAIN_SPLAT_DEFAULT = "Textures/heu_terrain_default_splat"; // Metadata: 0x02063BF7
		public const string HEU_FOLDER_MESHES = "Meshes"; // Metadata: 0x02063C1A
		public const string HEU_FOLDER_MATERIALS = "Materials"; // Metadata: 0x02063C21
		public const string HEU_FOLDER_TERRAIN = "Terrain"; // Metadata: 0x02063C2B
		public const string HEU_FOLDER_TILE = "Tile"; // Metadata: 0x02063C33
		public const string HEU_FOLDER_TEXTURES = "Textures"; // Metadata: 0x02063C38
		public const string HEU_EXT_ASSET = ".asset"; // Metadata: 0x02063C41
		public const string HEU_EXT_MAT = ".mat"; // Metadata: 0x02063C48
		public const string HEU_EXT_TERRAINDATA = ".terraindata"; // Metadata: 0x02063C4D
		public const string HEU_EXT_TERRAINLAYER = ".terrainlayer"; // Metadata: 0x02063C5A
		public const string HEU_KEY_CTRL = "Ctrl"; // Metadata: 0x02063C68
	
		// Constructors
		public HEU_Defines() {} // 0x0000000185492010-0x0000000185492020
		static HEU_Defines() {} // 0x000000018A919FEC-0x000000018A91A1B8
	}

	public static class HEU_HAPIUtility // TypeDefIndex: 50545
	{
		// Methods
		public static string GetHoudiniEngineInstallationInfo() => default; // 0x000000018A91BE2C-0x000000018A91BE58
		public static string GetEnvironmentPath() => default; // 0x000000018A91B7E0-0x000000018A91B850
		public static string GetRealPathFromHFSPath(string inPath) => default; // 0x000000018A91C534-0x000000018A91C658
		public static bool DoesMappedPathExist(string inPath) => default; // 0x000000018A91B0A0-0x000000018A91B110
		public static bool IsHoudiniAssetFile(string filePath) => default; // 0x000000018A91C870-0x000000018A91C988
		public static string FindHoudiniAssetFileInPathWithExt(string filePath) => default; // 0x000000018A91B110-0x000000018A91B28C
		public static void Log(string message) {} // 0x000000018A91CEA8-0x000000018A91CEB0
		public static void LogWarning(string message) {} // 0x000000018A91CEA0-0x000000018A91CEA8
		public static void LogError(string message) {} // 0x000000018A91CE98-0x000000018A91CEA0
		public static string LocateValidFilePath(UnityEngine.Object inObject) => default; // 0x000000018A91CE3C-0x000000018A91CE98
		public static string LocateValidFilePath(string assetName, string inFilePath) => default; // 0x00000001834A4750-0x00000001834A4760
		public static GameObject InstantiateHDA(string filePath, Vector3 initialPosition, HEU_SessionBase session, bool bBuildAsync, bool bLoadFromMemory = false /* Metadata: 0x02063C6D */, bool bAlwaysOverwriteOnLoad = false /* Metadata: 0x02063C6E */, GameObject rootGO = null) => default; // 0x000000018A91C658-0x000000018A91C870
		public static bool LoadHDAFile(HEU_SessionBase session, string assetPath, out int assetLibraryID, out string[] assetNames) {
			assetLibraryID = default;
			assetNames = default;
			return default;
		} // 0x000000018A91CD88-0x000000018A91CE3C
		public static bool CreateAndCookAssetNode(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID) {
			newAssetID = default;
			return default;
		} // 0x000000018A91AAFC-0x000000018A91AB68
		public static bool CreateAndCookCurveAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID) {
			newAssetID = default;
			return default;
		} // 0x000000018A91AB68-0x000000018A91ABBC
		public static bool CreateAndCookInputAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID) {
			newAssetID = default;
			return default;
		} // 0x000000018A91ABBC-0x000000018A91AC24
		public static bool CookNodeInHoudini(HEU_SessionBase session, int nodeID, bool bCookTemplatedGeos, string assetName) => default; // 0x000000018A91A8C0-0x000000018A91A8D8
		public static bool CookNodeInHoudiniWithOptions(HEU_SessionBase session, int nodeID, HAPI_CookOptions options, string assetName) => default; // 0x000000018A91A8C0-0x000000018A91A8D8
		public static HAPI_CookOptions GetDefaultCookOptions(HEU_SessionBase session) => default; // 0x000000018A91B7A4-0x000000018A91B7E0
		public static bool ProcessHoudiniCookStatus(HEU_SessionBase session, string assetName) => default; // 0x000000018A91CEB0-0x000000018A91CF30
		public static GameObject CreateNewAsset(HEU_AssetTypeWrapper assetType, string rootName = "HoudiniAsset" /* Metadata: 0x02063C6F */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02063C7C */, GameObject rootGO = null) => default; // 0x000000018A91AC24-0x000000018A91AC78
		internal static GameObject CreateNewAsset(HEU_HoudiniAsset.HEU_AssetType assetType, string rootName = "HoudiniAsset" /* Metadata: 0x02063C7D */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02063C8A */, GameObject rootGO = null) => default; // 0x000000018A91AC78-0x000000018A91AD2C
		public static GameObject CreateNewCurveAsset(string name = "HoudiniCurve" /* Metadata: 0x02063C8B */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02063C98 */, GameObject rootGO = null) => default; // 0x000000018A91AD2C-0x000000018A91AD60
		public static GameObject CreateNewInputAsset(string name = "HoudiniInput" /* Metadata: 0x02063C99 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x02063CA6 */, GameObject rootGO = null) => default; // 0x000000018A91AD60-0x000000018A91AD94
		public static GameObject LoadGeoWithNewGeoSync(HEU_SessionBase session = null) => default; // 0x00000001813AE580-0x00000001813AE590
		public static void DestroyChildren(Transform inTransform) {} // 0x000000018A91AD94-0x000000018A91B090
		public static void DestroyGameObject(GameObject gameObect, bool bRegisterUndo = false /* Metadata: 0x02063CA7 */) {} // 0x000000018A91B090-0x000000018A91B0A0
		public static void DestroyChildrenWithComponent<T>(GameObject gameObject)
			where T : Component {}
		public static bool IsNodeValidInHoudini(HEU_SessionBase session, int nodeID) => default; // 0x000000018A91C988-0x000000018A91C9A4
		public static HEU_HoudiniAssetRoot GetAssetInScene(int assetID) => default; // 0x000000018A91B6C4-0x000000018A91B7A4
		public static void ApplyWorldTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform) {} // 0x000000018A91A64C-0x000000018A91A8C0
		public static void ApplyLocalTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform) {} // 0x000000018A91A3E8-0x000000018A91A598
		public static void ApplyLocalTransfromFromHoudiniToUnityForInstance(ref HAPI_Transform hapiTransform, Transform unityTransform) {} // 0x000000018A91A1B8-0x000000018A91A3E8
		public static void ApplyMatrixToLocalTransform(ref Matrix4x4 matrix, Transform transform) {} // 0x000000018A91A598-0x000000018A91A64C
		public static Matrix4x4 GetMatrixFromHAPITransform(ref HAPI_Transform hapiTransform, bool bConvertToUnity = true /* Metadata: 0x02063CA8 */) => default; // 0x000000018A91BF08-0x000000018A91C12C
		public static Quaternion GetQuaternion(ref Matrix4x4 m) => default; // 0x000000018A91C330-0x000000018A91C534
		public static Vector3 GetPosition(ref Matrix4x4 m) => default; // 0x000000018A91C2E4-0x000000018A91C330
		public static void SetMatrixPosition(ref Matrix4x4 m, ref Vector3 position) {} // 0x000000018A91CF30-0x000000018A91CF7C
		public static Vector3 GetScale(ref Matrix4x4 m) => default; // 0x0000000185FCE1A0-0x0000000185FCE290
		public static HAPI_TransformEuler GetHAPITransformFromMatrix(ref Matrix4x4 mat) => default; // 0x000000018A91B850-0x000000018A91BA3C
		public static HAPI_TransformEuler GetHAPITransform(ref Vector3 p, ref Vector3 r, ref Vector3 s) => default; // 0x000000018A91BC98-0x000000018A91BE2C
		public static HAPI_Transform GetHAPITransformQuatFromMatrix(ref Matrix4x4 mat) => default; // 0x000000018A91BA3C-0x000000018A91BC98
		public static Matrix4x4 GetMatrix4x4(ref Vector3 p, ref Vector3 r, ref Vector3 s) => default; // 0x000000018A91BE58-0x000000018A91BF08
		public static bool IsSameTransform(ref Matrix4x4 transformMatrix, ref Vector3 p, ref Vector3 r, ref Vector3 s) => default; // 0x000000018A91CA00-0x000000018A91CAB8
		public static bool IsEqualTol(float a, float b, float t = 1E-05f /* Metadata: 0x02063CA9 */) => default; // 0x000000018781C434-0x000000018781C448
		public static bool IsTransformEqual(ref HAPI_Transform transA, ref HAPI_Transform transB) => default; // 0x000000018A91CAE4-0x000000018A91CC8C
		public static bool IsViewportEqual(ref HAPI_Viewport viewA, ref HAPI_Viewport viewB) => default; // 0x000000018A91CC8C-0x000000018A91CD88
		public static bool IsSessionSyncEqual(ref HAPI_SessionSyncInfo syncA, ref HAPI_SessionSyncInfo syncB) => default; // 0x000000018A91CAB8-0x000000018A91CAD0
		public static bool DoesGeoPartHaveAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo) => default; // 0x000000018A91A8C0-0x000000018A91A8D8
		public static void SetAnimationCurveTangentModes(AnimationCurve animCurve, List<int> tangentValues) {} // 0x0000000185492010-0x0000000185492020
		public static bool IsSupportedPolygonType(HAPI_PartType partType) => default; // 0x000000018A91CAD0-0x000000018A91CAE4
		public static int GetParentNodeID(HEU_SessionBase session, int nodeID) => default; // 0x000000018A91C2C4-0x000000018A91C2E4
		public static bool GetObjectInfos(HEU_SessionBase session, int assetID, ref HAPI_NodeInfo nodeInfo, out HAPI_ObjectInfo[] objectInfos, out HAPI_Transform[] objectTransforms) {
			objectInfos = default;
			objectTransforms = default;
			return default;
		} // 0x000000018A91C12C-0x000000018A91C28C
		public static bool ContainsSopNodes(HEU_SessionBase session, int nodeId) => default; // 0x000000018A91A8C0-0x000000018A91A8D8
		public static bool IsObjNodeFullyVisible(HEU_SessionBase session, HashSet<int> allObjectIds, int inRootNodeId, int inChildNodeId) => default; // 0x000000018A91C9A4-0x000000018A91CA00
		public static bool GetOutputIndex(HEU_SessionBase session, int nodeId, ref int outputIndex) => default; // 0x000000018A91C28C-0x000000018A91C2C4
		internal static void GatherAllAssetGeoInfos(HEU_SessionBase session, HAPI_AssetInfo assetInfo, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, bool bGetEditableNodes, ref List<HAPI_GeoInfo> outGeoInfos) {} // 0x0000000183904C10-0x0000000183905A00
		internal static void GatherAllObjectGeoInfos(HEU_SessionBase session, int assetId, bool bUseOutputNodes, ref List<HAPI_GeoInfo> outGeoInfos) {} // 0x000000018A91B628-0x000000018A91B6C4
		private static void GatherAllAssetOutputs(HEU_SessionBase session, int nodeId, bool bUseOutputNodes, bool bOutputTemplatedGeos, ref List<HAPI_GeoInfo> outGeoInfos) {} // 0x000000018A91B28C-0x000000018A91B628
		public static string ToHapiVariableName(string name) => default; // 0x000000018A91CF7C-0x000000018A91D008
		public static void ConvertPositionUnityToHoudini(ref Vector3 position) {} // 0x0000000185FCE130-0x0000000185FCE140
		public static void ConvertPositionUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ) {
			outputX = default;
			outputY = default;
			outputZ = default;
		} // 0x0000000185FCE110-0x0000000185FCE130
		public static Vector3 ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ) => default; // 0x0000000185FCE0F0-0x0000000185FCE110
		public static Vector3 ConvertPositionUnityToHoudini(Vector3 inputVec) => default; // 0x0000000185FCE0C0-0x0000000185FCE0F0
		public static void ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ, ref Vector3 outputVec) {} // 0x0000000185FCE140-0x0000000185FCE160
		public static void ConvertRotationUnityToHoudini(ref Quaternion rotation) {} // 0x000000018A91AA1C-0x000000018A91AA8C
		public static void ConvertRotationUnityToHoudini(Quaternion rotation, out float outputX, out float outputY, out float outputZ, out float outputW) {
			outputX = default;
			outputY = default;
			outputZ = default;
			outputW = default;
		} // 0x000000018A91A8D8-0x000000018A91A98C
		public static Quaternion ConvertRotationUnityToHoudini(float inputX, float inputY, float inputZ, float inputW) => default; // 0x000000018A91A98C-0x000000018A91AA1C
		public static Quaternion ConvertRotationUnityToHoudini(Quaternion inputQuat) => default; // 0x000000018A91AA8C-0x000000018A91AAFC
		public static void ConvertScaleUnityToHoudini(ref Vector3 position) {} // 0x0000000185492010-0x0000000185492020
		public static void ConvertScaleUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ) {
			outputX = default;
			outputY = default;
			outputZ = default;
		} // 0x0000000185FCE160-0x0000000185FCE180
		public static Vector3 ConvertScaleUnityToHoudini(float inputX, float inputY, float inputZ) => default; // 0x0000000185FCE180-0x0000000185FCE1A0
		public static Vector3 ConvertScaleUnityToHoudini(Vector3 inputVec) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
	}

	public class HEU_HoudiniEngineError : Exception // TypeDefIndex: 50546
	{
		// Fields
		protected string _errorMsg; // 0x90
	
		// Constructors
		public HEU_HoudiniEngineError() {} // 0x000000018A91DF38-0x000000018A91DFA0
		public HEU_HoudiniEngineError(string errorMsg) {} // 0x000000018A91DEB0-0x000000018A91DF38
	
		// Methods
		public override string ToString() => default; // 0x0000000181B5FFD0-0x0000000181B5FFE0
	}

	public class HEU_Platform // TypeDefIndex: 50547
	{
		// Fields
		private static string _lastErrorMsg; // 0x00
		private static string _libPath; // 0x08
		private static bool _pathSet; // 0x10
	
		// Properties
		public static string LibPath { get => default; } // 0x000000018A92B7E0-0x000000018A92B830 
		public static bool IsPathSet { get => default; } // 0x000000018A92B790-0x000000018A92B7E0 
		public static char DirectorySeparator { get => default; } // 0x0000000185FB7330-0x0000000185FB7340 
		public static string DirectorySeparatorStr { get => default; } // 0x000000018A92B764-0x000000018A92B790 
	
		// Constructors
		static HEU_Platform() {} // 0x000000018A92B75C-0x000000018A92B764
		public HEU_Platform() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static string GetHoudiniEnginePath() => default; // 0x000000018A92B05C-0x000000018A92B0B4
		public static string GetHoudiniEngineDefaultPath() => default; // 0x000000018A92ADD4-0x000000018A92AFD0
		public static string GetSavedHoudiniPath() => default; // 0x000000018A92B0D4-0x000000018A92B1F0
		public static void SetHapiClientName() {} // 0x000000018A92B55C-0x000000018A92B5A4
		public static void SetHoudiniEnginePath() {} // 0x0000000185492010-0x0000000185492020
		public static string GetAllFoldersInPath(string path) => default; // 0x000000018A92AA30-0x000000018A92AAE0
		private static void GetAllFoldersInPathHelper(string inPath, StringBuilder pathBuilder) {} // 0x000000018A92A910-0x000000018A92AA30
		public static string[] GetFilesInFolder(string folderPath, string searchPattern, bool bRecursive) => default; // 0x000000018A92AB88-0x000000018A92ACA0
		public static string GetFileName(string path) => default; // 0x000000018A92AB3C-0x000000018A92AB88
		public static string GetFileNameWithoutExtension(string path) => default; // 0x000000018A92AAF0-0x000000018A92AB3C
		public static string GetFolderPath(string path, bool bRemoveDirectorySeparatorAtEnd = false /* Metadata: 0x02063CAD */) => default; // 0x000000018A92ACA0-0x000000018A92AD88
		public static string BuildPath(string folder1, string folder2, object[] args) => default; // 0x000000018A92A798-0x000000018A92A8A8
		public static string TrimLastDirectorySeparator(string inPath) => default; // 0x000000018A92B5A4-0x000000018A92B634
		public static bool DoesPathExist(string inPath) => default; // 0x000000018A92A8E0-0x000000018A92A910
		public static bool DoesFileExist(string inPath) => default; // 0x000000018A92A8D8-0x000000018A92A8E0
		public static bool DoesDirectoryExist(string inPath) => default; // 0x000000018A92A8D0-0x000000018A92A8D8
		public static bool CreateDirectory(string inPath) => default; // 0x000000018A92A8A8-0x000000018A92A8D0
		public static string GetParentDirectory(string inPath) => default; // 0x000000018A92B0B4-0x000000018A92B0D4
		public static string GetFullPath(string inPath) => default; // 0x000000018A92AD88-0x000000018A92ADD4
		public static bool IsPathRooted(string inPath) => default; // 0x000000018A92B1F0-0x000000018A92B23C
		public static void WriteBytes(string path, byte[] bytes) {} // 0x000000018A92B754-0x000000018A92B75C
		public static bool WriteAllText(string path, string text) => default; // 0x000000018A92B634-0x000000018A92B754
		public static string ReadAllText(string path) => default; // 0x000000018A92B404-0x000000018A92B55C
		public static string GetEnvironmentValue(string key) => default; // 0x000000018A92AAE0-0x000000018A92AAF0
		public static string GetHoudiniEngineEnvironmentFilePathFull() => default; // 0x000000018A92AFD0-0x000000018A92B05C
		public static bool LoadFileIntoMemory(string path, out byte[] buffer) {
			buffer = default;
			return default;
		} // 0x000000018A92B23C-0x000000018A92B404
	}

	public static class HEU_PlatformWin // TypeDefIndex: 50549
	{
		// Fields
		public static UIntPtr HKEY_LOCAL_MACHINE; // 0x00
		public static UIntPtr HKEY_CURRENT_USER; // 0x08
	
		// Nested types
		public enum RegSAM // TypeDefIndex: 50548
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
		static HEU_PlatformWin() {} // 0x000000018A92A744-0x000000018A92A798
	
		// Methods
		private static extern uint RegOpenKeyEx(UIntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out int phkResult); // 0x000000018A92A580-0x000000018A92A644
		public static extern int RegQueryValueEx(int hKey, string lpValueName, int lpReserved, ref uint lpType, StringBuilder lpData, ref uint lpcbData); // 0x000000018A92A644-0x000000018A92A744
		private static extern uint RegCloseKey(int hKey); // 0x000000018A92A508-0x000000018A92A580
		public static string GetRegistryKeyValue(UIntPtr rootKey, string keyName, RegSAM is32or64Key, string inPropertyName) => default; // 0x000000018A92A278-0x000000018A92A430
		public static string GetRegistryKeyvalue_x86(UIntPtr rootKey, string keyName, string inPropertyName) => default; // 0x000000018A92A49C-0x000000018A92A508
		public static string GetRegistryKeyvalue_x64(UIntPtr rootKey, string keyName, string inPropertyName) => default; // 0x000000018A92A430-0x000000018A92A49C
		public static string GetApplicationPath(string appName) => default; // 0x000000018A929F38-0x000000018A92A278
	}

	public static class HEU_PluginSettings // TypeDefIndex: 50550
	{
		// Fields
		public static Action<bool> s_onEnableRawHoudiniChanged; // 0x00
	
		// Properties
		public static string HoudiniEngineEnvFilePath { get; set; } // 0x000000018A92C528-0x000000018A92C59C 0x000000018A92E05C-0x000000018A92E0C4
		public static bool EnableRawHoudini { get; set; } // 0x000000018A92C2A4-0x000000018A92C304 0x000000018A92DE38-0x000000018A92DF08
		public static bool CookingEnabled { get; set; } // 0x000000018A92BAF8-0x000000018A92BB58 0x000000018A92DB20-0x000000018A92DB70
		public static bool CookingTriggersDownstreamCooks { get; set; } // 0x000000018A92BB58-0x000000018A92BBB8 0x000000018A92DB70-0x000000018A92DBC0
		public static bool CookDisabledGameObjects { get; set; } // 0x000000018A92B978-0x000000018A92B9D8 0x000000018A92D9E0-0x000000018A92DA30
		public static bool CookTemplatedGeos { get; set; } // 0x000000018A92BA98-0x000000018A92BAF8 0x000000018A92DAD0-0x000000018A92DB20
		public static bool PushUnityTransformToHoudini { get; set; } // 0x000000018A92CBBC-0x000000018A92CC1C 0x000000018A92E56C-0x000000018A92E5BC
		public static bool TransformChangeTriggersCooks { get; set; } // 0x000000018A92D1D4-0x000000018A92D234 0x000000018A92EA38-0x000000018A92EA88
		public static bool ChildTransformChangeTriggersCooks { get; set; } // 0x000000018A92B8A4-0x000000018A92B904 0x000000018A92D93C-0x000000018A92D98C
		public static string CollisionGroupName { get; set; } // 0x000000018A92B904-0x000000018A92B978 0x000000018A92D98C-0x000000018A92D9E0
		public static string RenderedCollisionGroupName { get; set; } // 0x000000018A92CC1C-0x000000018A92CC90 0x000000018A92E5BC-0x000000018A92E610
		public static string RenderedConvexCollisionGroupName { get; set; } // 0x000000018A92CC90-0x000000018A92CD04 0x000000018A92E610-0x000000018A92E664
		public static string UnityMaterialAttribName { get; set; } // 0x000000018A92D390-0x000000018A92D404 0x000000018A92EB84-0x000000018A92EBD8
		public static string UnitySubMaterialAttribName { get; set; } // 0x000000018A92D4EC-0x000000018A92D560 0x000000018A92EC80-0x000000018A92ECD4
		public static string UnitySubMaterialIndexAttribName { get; set; } // 0x000000018A92D560-0x000000018A92D5D4 0x000000018A92ECD4-0x000000018A92ED28
		public static string UnityTagAttributeName { get; set; } // 0x000000018A92D5D4-0x000000018A92D648 0x000000018A92ED28-0x000000018A92ED7C
		public static string UnityStaticAttributeName { get; set; } // 0x000000018A92D478-0x000000018A92D4EC 0x000000018A92EC2C-0x000000018A92EC80
		public static string UnityScriptAttributeName { get; set; } // 0x000000018A92D404-0x000000018A92D478 0x000000018A92EBD8-0x000000018A92EC2C
		public static string UnityLayerAttributeName { get; set; } // 0x000000018A92D31C-0x000000018A92D390 0x000000018A92EB30-0x000000018A92EB84
		public static float ImageGamma { get; set; } // 0x000000018A92C610-0x000000018A92C678 0x000000018A92E118-0x000000018A92E170
		public static float NormalGenerationThresholdAngle { get; set; } // 0x000000018A92CB54-0x000000018A92CBBC 0x000000018A92E514-0x000000018A92E56C
		public static string LastLoadHDAPath { get; set; } // 0x000000018A92C970-0x000000018A92C9E4 0x000000018A92E3B0-0x000000018A92E404
		public static string LastLoadHIPPath { get; set; } // 0x000000018A92C9E4-0x000000018A92CA58 0x000000018A92E404-0x000000018A92E458
		public static string InstanceAttr { get; set; } // 0x000000018A92C814-0x000000018A92C888 0x000000018A92E2B4-0x000000018A92E308
		public static string UnityInstanceAttr { get; set; } // 0x000000018A92D2A8-0x000000018A92D31C 0x000000018A92EADC-0x000000018A92EB30
		public static string UnityInputMeshAttr { get; set; } // 0x000000018A92D234-0x000000018A92D2A8 0x000000018A92EA88-0x000000018A92EADC
		public static UnityEngine.Color LineColor { get; set; } // 0x000000018A92CA58-0x000000018A92CAF0 0x000000018A92E458-0x000000018A92E4C4
		public static bool UseHybridCurveEditing { get; set; } // 0x000000018A92D708-0x000000018A92D768 0x000000018A92EE1C-0x000000018A92EE6C
		public static string EditorOnly_Tag { get; set; } // 0x000000018A92C230-0x000000018A92C2A4 0x000000018A92DDB4-0x000000018A92DE38
		public static string HDAData_Name { get; set; } // 0x000000018A92C304-0x000000018A92C378 0x000000018A92DF08-0x000000018A92DF5C
		public static SessionMode Session_Mode { get; set; } // 0x000000018A92CE38-0x000000018A92CEA0 0x000000018A92E758-0x000000018A92E7A8
		public static string Session_PipeName { get; set; } // 0x000000018A92CEA0-0x000000018A92CF14 0x000000018A92E7A8-0x000000018A92E7FC
		public static string Session_Localhost { get; set; } // 0x000000018A92CDC4-0x000000018A92CE38 0x000000018A92E704-0x000000018A92E758
		public static int Session_Port { get; set; } // 0x000000018A92CF14-0x000000018A92CF78 0x000000018A92E7FC-0x000000018A92E84C
		public static string Session_SharedMemoryName { get; set; } // 0x0000000183906C20-0x00000001839074C0 0x00000001839086F0-0x0000000183908D00
		public static int Session_SharedMemoryBufferSize { get; set; } // 0x0000000183906000-0x0000000183906610 0x0000000183907AD0-0x00000001839080E0
		public static HAPI_ThriftSharedMemoryBufferType Session_SharedMemoryBufferType { get; set; } // 0x0000000183906610-0x0000000183906C20 0x00000001839080E0-0x00000001839086F0
		public static float Session_Timeout { get; set; } // 0x000000018A92CF78-0x000000018A92CFE0 0x000000018A92E84C-0x000000018A92E8A4
		public static bool Session_AutoClose { get; set; } // 0x000000018A92CD64-0x000000018A92CDC4 0x000000018A92E6B4-0x000000018A92E704
		public static bool Curves_ShowInSceneView { get; set; } // 0x000000018A92BBB8-0x000000018A92BC18 0x000000018A92DBC0-0x000000018A92DC10
		public static string AssetCachePath { get; set; } // 0x000000018A92B830-0x000000018A92B8A4 0x000000018A92D8E8-0x000000018A92D93C
		public static bool UseFullPathNamesForOutput { get; set; } // 0x000000018A92D648-0x000000018A92D6A8 0x000000018A92ED7C-0x000000018A92EDCC
		public static List<string> HEngineToolsShelves { get; set; } // 0x000000018A92C3D8-0x000000018A92C43C 0x000000018A92DFAC-0x000000018A92E008
		public static int HEngineShelfSelectedIndex { get; set; } // 0x000000018A92C378-0x000000018A92C3D8 0x000000018A92DF5C-0x000000018A92DFAC
		public static string DefaultTerrainMaterial { get; set; } // 0x000000018A92BEB4-0x000000018A92BF28 0x000000018A92DCB8-0x000000018A92DD0C
		public static string TerrainSplatTextureDefault { get; set; } // 0x000000018A92D160-0x000000018A92D1D4 0x000000018A92E9E4-0x000000018A92EA38
		public static string DefaultStandardShader { get; set; } // 0x000000018A92BD30-0x000000018A92BEB4 0x000000018A92DC64-0x000000018A92DCB8
		public static string DefaultVertexColorShader { get; set; } // 0x000000018A92C0AC-0x000000018A92C230 0x000000018A92DD60-0x000000018A92DDB4
		public static string DefaultTransparentShader { get; set; } // 0x000000018A92BF28-0x000000018A92C0AC 0x000000018A92DD0C-0x000000018A92DD60
		public static string DefaultCurveShader { get; set; } // 0x000000018A92BC18-0x000000018A92BD30 0x000000018A92DC10-0x000000018A92DC64
		public static bool SupportHoudiniBoxType { get; set; } // 0x000000018A92D0A0-0x000000018A92D100 0x000000018A92E944-0x000000018A92E994
		public static bool SupportHoudiniSphereType { get; set; } // 0x000000018A92D100-0x000000018A92D160 0x000000018A92E994-0x000000018A92E9E4
		public static bool SetCurrentThreadToInvariantCulture { get; set; } // 0x000000018A92CFE0-0x000000018A92D040 0x000000018A92E8A4-0x000000018A92E8F4
		public static string HoudiniDebugLaunchPath { get; set; } // 0x000000018A92C43C-0x000000018A92C528 0x000000018A92E008-0x000000018A92E05C
		public static string LastExportPath { get; set; } // 0x000000018A92C888-0x000000018A92C8FC 0x000000018A92E308-0x000000018A92E35C
		public static int InputSelectionFilterLocation { get; set; } // 0x000000018A92C678-0x000000018A92C6DC 0x000000018A92E170-0x000000018A92E1C0
		public static int InputSelectionFilterState { get; set; } // 0x000000018A92C7B0-0x000000018A92C814 0x000000018A92E264-0x000000018A92E2B4
		public static bool InputSelectionFilterRoots { get; set; } // 0x000000018A92C750-0x000000018A92C7B0 0x000000018A92E214-0x000000018A92E264
		public static string InputSelectionFilterName { get; set; } // 0x000000018A92C6DC-0x000000018A92C750 0x000000018A92E1C0-0x000000018A92E214
		public static bool CookOptionSplitGeosByGroup { get; set; } // 0x000000018A92BA38-0x000000018A92BA98 0x000000018A92DA80-0x000000018A92DAD0
		public static int MaxVerticesPerPrimitive { get; set; } // 0x000000018A92CAF0-0x000000018A92CB54 0x000000018A92E4C4-0x000000018A92E514
		public static string HoudiniInstallPath { get; set; } // 0x000000018A92C59C-0x000000018A92C610 0x000000018A92E0C4-0x000000018A92E118
		public static string LastHoudiniVersion { get; set; } // 0x000000018A92C8FC-0x000000018A92C970 0x000000018A92E35C-0x000000018A92E3B0
		public static bool SessionSyncAutoCook { get; set; } // 0x000000018A92CD04-0x000000018A92CD64 0x000000018A92E664-0x000000018A92E6B4
		public static bool WriteCookLogs { get; set; } // 0x000000018A92D888-0x000000018A92D8E8 0x000000018A92EF5C-0x000000018A92EFAC
		public static bool UseHDRColor { get; set; } // 0x000000018A92D6A8-0x000000018A92D708 0x000000018A92EDCC-0x000000018A92EE1C
		public static bool UseSpecularShader { get; set; } // 0x000000018A92D828-0x000000018A92D888 0x000000018A92EF0C-0x000000018A92EF5C
		public static bool UseLegacyShaders { get; set; } // 0x000000018A92D7C8-0x000000018A92D828 0x000000018A92EEBC-0x000000018A92EF0C
		public static bool ShortenFolderPaths { get; set; } // 0x000000018A92D040-0x000000018A92D0A0 0x000000018A92E8F4-0x000000018A92E944
		public static bool UseLegacyInputCurves { get; set; } // 0x000000018A92D768-0x000000018A92D7C8 0x000000018A92EE6C-0x000000018A92EEBC
		public static bool CookOnMouseUp { get; set; } // 0x000000018A92B9D8-0x000000018A92BA38 0x000000018A92DA30-0x000000018A92DA80
		public static bool EditableNodesToolsEnabled { get; set; } // 0x0000000183905A00-0x0000000183906000 0x00000001839074C0-0x0000000183907AD0
	}

	public class HEU_PluginStorage // TypeDefIndex: 50554
	{
		// Fields
		protected Dictionary<string, StoreData> _dataMap; // 0x10
		private Dictionary<string, string> _envPathMap; // 0x18
		protected bool _requiresSave; // 0x20
		private static HEU_PluginStorage _instance; // 0x00
		public const string PluginSettingsLine1 = "Houdini Engine for Unity Plugin Settings"; // Metadata: 0x02063CCE
		public const string PluginSettingsLine2 = "Version="; // Metadata: 0x02063CF7
		public const string PluginSettingsVersion = "1.0"; // Metadata: 0x02063D00
	
		// Properties
		public bool RequiresSave { get => default; } // 0x000000018A92FB64-0x000000018A92FC4C 
		public static HEU_PluginStorage Instance { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		protected enum DataType // TypeDefIndex: 50551
		{
			BOOL = 0,
			INT = 1,
			LONG = 2,
			FLOAT = 3,
			STRING = 4
		}
	
		[Serializable]
		protected class StoreData // TypeDefIndex: 50552
		{
			// Fields
			public DataType _type; // 0x10
			public string _valueStr; // 0x18
	
			// Constructors
			public StoreData() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		[Serializable]
		private class StoreDataArray<T> // TypeDefIndex: 50553
		{
			// Fields
			public T[] _array;
	
			// Constructors
			public StoreDataArray() {} // 0x00000001813ECBF0-0x00000001813ECC00
		}
	
		// Constructors
		public HEU_PluginStorage() {}
	
		// Methods
		public Dictionary<string, string> GetEnvironmentPathMap() => default; // 0x000000018A9313F4-0x000000018A931448
		public static void InstantiateAndLoad() {}
		public static void SetCurrentCulture(bool useInvariant) {} // 0x000000018A931208-0x000000018A9312CC
		private T[] GetJSONArray<T>(string jsonArray) => default; // 0x000000018A930F44-0x000000018A931008
		public void Set(string key, bool value) {} // 0x000000018A930E80-0x000000018A930F44
		public void Set(string key, int value) {} // 0x000000018A931144-0x000000018A931208
		public void Set(string key, long value) {} // 0x000000018A930DE8-0x000000018A930E80
		public void Set(string key, float value) {} // 0x000000018A931008-0x000000018A931144
		public void Set(string key, string value) {} // 0x000000018A92F8CC-0x000000018A92F9A0
		public void Set(string key, List<string> values, char delimiter = ';' /* Metadata: 0x02063CCA */) {} // 0x000000018A92F5D8-0x000000018A92F6AC
		public bool Get(string key, out bool value, bool defaultValue) {
			value = default;
			return default;
		} // 0x000000018A92F7F8-0x000000018A92F8CC
		public bool Get(string key, out int value, int defaultValue) {
			value = default;
			return default;
		} // 0x000000018A92FA64-0x000000018A92FB64
		public bool Get(string key, out long value, long defaultValue) {
			value = default;
			return default;
		} // 0x000000018A92F9A0-0x000000018A92FA64
		public bool Get(string key, out float value, float defaultValue) {
			value = default;
			return default;
		} // 0x000000018A92F6AC-0x000000018A92F7F8
		public bool Get(string key, out string value, string defaultValue) {
			value = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public bool Get(string key, out List<string> values, char delimiter = ';' /* Metadata: 0x02063CCC */) {
			values = default;
			return default;
		} // 0x000000018A930894-0x000000018A9308E0
		protected virtual void MarkDirtyForSave() {} // 0x000000018A9312CC-0x000000018A93137C
		public static void SaveIfRequired() {} // 0x000000018A9308E0-0x000000018A930D38
		public static string SettingsFilePath() => default; // 0x000000018A930084-0x000000018A930894
		public virtual bool SavePluginData(string file = null) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool LoadPluginData(string file = null) => default; // 0x000000018A92EFAC-0x000000018A92F064
		private bool ReadFromEditorPrefs() => default; // 0x000000018A93003C-0x000000018A930084
		public static void ClearPluginData() {} // 0x000000018A930D38-0x000000018A930DE8
		public static void LoadFromSavedFile() {} // 0x0000000185492010-0x0000000185492020
		public static string SessionFilePath() => default; // 0x000000018A92FC4C-0x000000018A92FCAC
		public static void SaveAllSessionData(List<HEU_SessionBase> allSessions, string path = null) {} // 0x0000000185492010-0x0000000185492020
		public static List<HEU_SessionData> LoadAllSessionData(string path = null) => default; // 0x000000018A92FCAC-0x000000018A93003C
		public static void DeleteAllSavedSessionData(string file = null) {} // 0x000000018A92F308-0x000000018A92F5D8
		public void LoadAssetEnvironmentPaths() {} // 0x000000018A92F064-0x000000018A92F308
		public string ConvertRealPathToEnvKeyedPath(string inPath) => default; // 0x000000018A93137C-0x000000018A9313F4
		public string ConvertEnvKeyedPathToReal(string inPath) => default; // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal class HEU_Handle : ScriptableObject, IEquivable<HEU_Handle> // TypeDefIndex: 50556
	{
		// Fields
		private string _handleName; // 0x18
		private HEU_HandleType _handleType; // 0x20
		private int _handleIndex; // 0x24
		private HEU_HandleParamBinding _handleParamTranslateBinding; // 0x28
		private HEU_HandleParamBinding _handleParamRotateBinding; // 0x30
		private HEU_HandleParamBinding _handleParamScaleBinding; // 0x38
		private Vector3 _handlePosition; // 0x40
		private Quaternion _handleRotation; // 0x4C
		private Vector3 _handleScale; // 0x5C
		private HAPI_RSTOrder _rstOrder; // 0x68
		private HAPI_XYZOrder _xyzOrder; // 0x6C
		private HAPI_TransformEuler _convertedTransformEuler; // 0x70
	
		// Properties
		public string HandleName { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public HEU_HandleType HandleType { get => default; } // 0x00000001813B88B0-0x00000001813B88C0 
		public HAPI_RSTOrder RSTOrder { get => default; } // 0x0000000185FB0B00-0x0000000185FB0B10 
		public HAPI_XYZOrder XYZOrder { get => default; } // 0x0000000185FB09F0-0x0000000185FB0A00 
		public HAPI_TransformEuler ConvertedTransformEuler { get => default; } // 0x0000000185FCE290-0x0000000185FCE2C0 
		public Vector3 HandlePosition { get => default; } // 0x0000000185FB3620-0x0000000185FB3640 
		public Quaternion HandleRotation { get => default; } // 0x0000000185FBFB90-0x0000000185FBFBA0 
		public Vector3 HandleScale { get => default; } // 0x0000000185FCE2C0-0x0000000185FCE2E0 
	
		// Nested types
		public enum HEU_HandleType // TypeDefIndex: 50555
		{
			XFORM = 0,
			UNSUPPORTED = 1
		}
	
		// Constructors
		public HEU_Handle() {} // 0x000000018A91DE48-0x000000018A91DEB0
	
		// Methods
		public bool HasTranslateHandle() => default; // 0x00000001878567E4-0x00000001878567F0
		public bool HasRotateHandle() => default; // 0x000000018A6AD3DC-0x000000018A6AD3E8
		public bool HasScaleHandle() => default; // 0x0000000188251750-0x000000018825175C
		public bool IsTranslateHandleDisabled() => default; // 0x000000018A91DD10-0x000000018A91DD24
		public bool IsRotateHandleDisabled() => default; // 0x000000018A91DCD4-0x000000018A91DCE8
		public bool IsScaleHandleDisabled() => default; // 0x000000018A91DCE8-0x000000018A91DCFC
		public HEU_HandleParamBinding GetTranslateBinding() => default; // 0x00000001813B8590-0x00000001813B85A0
		public HEU_HandleParamBinding GetRotateBinding() => default; // 0x00000001813B51D0-0x00000001813B51E0
		public HEU_HandleParamBinding GetScaleBinding() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
		public bool SetupHandle(HEU_SessionBase session, int assetID, int handleIndex, string handleName, HEU_HandleType handleType, ref HAPI_HandleInfo handleInfo, HEU_Parameters parameters) => default; // 0x000000018A91DD24-0x000000018A91DE48
		public void CleanUp() {} // 0x000000018A91D21C-0x000000018A91D254
		public void GenerateTransform(HEU_SessionBase session, HEU_Parameters parameters) {} // 0x000000018A91D254-0x000000018A91D66C
		public bool GetUpdatedPosition(HEU_HoudiniAsset asset, ref Vector3 inPosition) => default; // 0x000000018A91D66C-0x000000018A91D728
		public bool GetUpdatedRotation(HEU_HoudiniAsset asset, ref Quaternion inRotation) => default; // 0x000000018A91D728-0x000000018A91D85C
		public static bool IsSpecialRSTOrder(HAPI_RSTOrder rstOrder) => default; // 0x000000018A91DCFC-0x000000018A91DD10
		public bool IsEquivalentTo(HEU_Handle other) => default; // 0x000000018A91D85C-0x000000018A91DCD4
	}

	[Serializable]
	internal class HEU_HandleParamBinding : IEquivable<HEU_HandleParamBinding> // TypeDefIndex: 50558
	{
		// Fields
		public HEU_HandleParamType _paramType; // 0x10
		public int _parmID; // 0x14
		public string _paramName; // 0x18
		public bool _bDisabled; // 0x20
		public bool[] _boundChannels; // 0x28
	
		// Nested types
		public enum HEU_HandleParamType // TypeDefIndex: 50557
		{
			TRANSLATE = 0,
			ROTATE = 1,
			SCALE = 2
		}
	
		// Constructors
		public HEU_HandleParamBinding() {} // 0x000000018A91D1D4-0x000000018A91D21C
	
		// Methods
		public bool IsEquivalentTo(HEU_HandleParamBinding other) => default; // 0x000000018A91D008-0x000000018A91D1D4
	}

	public static class HEU_HAPIConstants // TypeDefIndex: 50559
	{
		// Fields
		public const int HAPI_POSITION_VECTOR_SIZE = 3; // Metadata: 0x02063D0E
		public const int HAPI_SCALE_VECTOR_SIZE = 3; // Metadata: 0x02063D0F
		public const int HAPI_SHEAR_VECTOR_SIZE = 3; // Metadata: 0x02063D10
		public const int HAPI_NORMAL_VECTOR_SIZE = 3; // Metadata: 0x02063D11
		public const int HAPI_QUATERNION_VECTOR_SIZE = 4; // Metadata: 0x02063D12
		public const int HAPI_EULER_VECTOR_SIZE = 3; // Metadata: 0x02063D13
		public const int HAPI_UV_VECTOR_SIZE = 2; // Metadata: 0x02063D14
		public const int HAPI_COLOR_VECTOR_SIZE = 4; // Metadata: 0x02063D15
		public const int HAPI_CV_VECTOR_SIZE = 4; // Metadata: 0x02063D16
		public const int HAPI_PRIM_MIN_VERTEX_COUNT = 1; // Metadata: 0x02063D17
		public const int HAPI_PRIM_MAX_VERTEX_COUNT = 16; // Metadata: 0x02063D18
		public const int HAPI_INVALID_PARM_ID = -1; // Metadata: 0x02063D19
		public const int HAPI_MAX_NUM_CONNECTIONS = 128; // Metadata: 0x02063D1A
		public const string HAPI_ATTRIB_POSITION = "P"; // Metadata: 0x02063D1C
		public const string HAPI_ATTRIB_UV = "uv"; // Metadata: 0x02063D1E
		public const string HAPI_ATTRIB_UV2 = "uv2"; // Metadata: 0x02063D21
		public const string HAPI_ATTRIB_NORMAL = "N"; // Metadata: 0x02063D25
		public const string HAPI_ATTRIB_TANGENT = "tangentu"; // Metadata: 0x02063D27
		public const string HAPI_ATTRIB_TANGENT2 = "tangentv"; // Metadata: 0x02063D30
		public const string HAPI_ATTRIB_COLOR = "Cd"; // Metadata: 0x02063D39
		public const string HAPI_ATTRIB_NAME = "name"; // Metadata: 0x02063D3C
		public const string HAPI_ATTRIB_INSTANCE = "instance"; // Metadata: 0x02063D41
		public const string HAPI_ATTRIB_ROT = "rot"; // Metadata: 0x02063D4A
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x02063D4E
		public const string HAPI_UNGROUPED_GROUP_NAME = "__ungrouped_group"; // Metadata: 0x02063D54
		public const string HAPI_RAW_FORMAT_NAME = "HAPI_RAW"; // Metadata: 0x02063D66
		public const string HAPI_PNG_FORMAT_NAME = "PNG"; // Metadata: 0x02063D6F
		public const string HAPI_JPEG_FORMAT_NAME = "JPEG"; // Metadata: 0x02063D73
		public const string HAPI_BMP_FORMAT_NAME = "Bitmap"; // Metadata: 0x02063D78
		public const string HAPI_TIFF_FORMAT_NAME = "TIFF"; // Metadata: 0x02063D7F
		public const string HAPI_TGA_FORMAT_NAME = "Targa"; // Metadata: 0x02063D84
		public const string HAPI_DEFAULT_IMAGE_FORMAT_NAME = "PNG"; // Metadata: 0x02063D8A
		public const string HAPI_GLOBAL_NODES_NODE_NAME = "GlobalNodes"; // Metadata: 0x02063D8E
		public const string HAPI_ENV_HIP = "HIP"; // Metadata: 0x02063D9A
		public const string HAPI_ENV_JOB = "JOB"; // Metadata: 0x02063D9E
		public const string HAPI_ENV_CLIENT_NAME = "HAPI_CLIENT_NAME"; // Metadata: 0x02063DA2
		public const string HAPI_CACHE_COP2_COOK = "Old COP Cook Cache"; // Metadata: 0x02063DB3
		public const string HAPI_CACHE_COP2_FLIPBOOK = "Composite View Cache"; // Metadata: 0x02063DC6
		public const string HAPI_CACHE_IMAGE = "Image Cache"; // Metadata: 0x02063DDB
		public const string HAPI_CACHE_OBJ = "Object Transform Cache"; // Metadata: 0x02063DE7
		public const string HAPI_CACHE_GL_TEXTURE = "OpenGL Texture Cache"; // Metadata: 0x02063DFE
		public const string HAPI_CACHE_GL_VERTEX = "OpenGL Vertex Cache"; // Metadata: 0x02063E13
		public const string HAPI_CACHE_SOP = "SOP Cache"; // Metadata: 0x02063E27
		public const string HAPI_CACHE_VEX = "VEX File Cache"; // Metadata: 0x02063E31
		public const string HAPI_ATTRIB_INPUT_CURVE_COORDS = "hapi_input_curve_coords"; // Metadata: 0x02063E40
	}

	public enum HAPI_License // TypeDefIndex: 50560
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

	public enum HAPI_StatusType // TypeDefIndex: 50561
	{
		HAPI_STATUS_CALL_RESULT = 0,
		HAPI_STATUS_COOK_RESULT = 1,
		HAPI_STATUS_COOK_STATE = 2,
		HAPI_STATUS_MAX = 3
	}

	public enum HAPI_StatusVerbosity // TypeDefIndex: 50562
	{
		HAPI_STATUSVERBOSITY_0 = 0,
		HAPI_STATUSVERBOSITY_ERRORS = 0,
		HAPI_STATUSVERBOSITY_1 = 1,
		HAPI_STATUSVERBOSITY_WARNINGS = 1,
		HAPI_STATUSVERBOSITY_2 = 2,
		HAPI_STATUSVERBOSITY_ALL = 2,
		HAPI_STATUSVERBOSITY_MESSAGES = 2
	}

	public enum HAPI_JobStatus // TypeDefIndex: 50563
	{
		HAPI_JOB_STATUS_RUNNING = 0,
		HAPI_JOB_STATUS_IDLE = 1,
		HAPI_JOB_STATUS_MAX = 2
	}

	public enum HAPI_Result // TypeDefIndex: 50564
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

	public enum HAPI_ErrorCode // TypeDefIndex: 50565
	{
		HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND = 1,
		HAPI_ERRORCODE_PYTHON_NODE_ERROR = 2
	}

	public enum HAPI_SessionType // TypeDefIndex: 50566
	{
		HAPI_SESSION_INPROCESS = 0,
		HAPI_SESSION_THRIFT = 1,
		HAPI_SESSION_CUSTOM1 = 2,
		HAPI_SESSION_CUSTOM2 = 3,
		HAPI_SESSION_CUSTOM3 = 4,
		HAPI_SESSION_MAX = 5
	}

	public enum HAPI_State // TypeDefIndex: 50567
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

	public enum HAPI_PackedPrimInstancingMode // TypeDefIndex: 50568
	{
		HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID = -1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED = 0,
		HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY = 1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT = 2,
		HAPI_PACKEDPRIM_INSTANCING_MODE_MAX = 3
	}

	public enum HAPI_Permissions // TypeDefIndex: 50569
	{
		HAPI_PERMISSIONS_NON_APPLICABLE = 0,
		HAPI_PERMISSIONS_READ_WRITE = 1,
		HAPI_PERMISSIONS_READ_ONLY = 2,
		HAPI_PERMISSIONS_WRITE_ONLY = 3,
		HAPI_PERMISSIONS_MAX = 4
	}

	public enum HAPI_RampType // TypeDefIndex: 50570
	{
		HAPI_RAMPTYPE_INVALID = -1,
		HAPI_RAMPTYPE_FLOAT = 0,
		HAPI_RAMPTYPE_COLOR = 1,
		HAPI_RAMPTYPE_MAX = 2
	}

	public enum HAPI_ParmType // TypeDefIndex: 50571
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

	public enum HAPI_PrmScriptType // TypeDefIndex: 50572
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

	public enum HAPI_ChoiceListType // TypeDefIndex: 50573
	{
		HAPI_CHOICELISTTYPE_NONE = 0,
		HAPI_CHOICELISTTYPE_NORMAL = 1,
		HAPI_CHOICELISTTYPE_MINI = 2,
		HAPI_CHOICELISTTYPE_REPLACE = 3,
		HAPI_CHOICELISTTYPE_TOGGLE = 4
	}

	public enum HAPI_PresetType // TypeDefIndex: 50574
	{
		HAPI_PRESETTYPE_INVALID = -1,
		HAPI_PRESETTYPE_BINARY = 0,
		HAPI_PRESETTYPE_IDX = 1,
		HAPI_PRESETTYPE_MAX = 2
	}

	public enum HAPI_NodeType // TypeDefIndex: 50575
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

	public enum HAPI_NodeFlags // TypeDefIndex: 50576
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

	public enum HAPI_GroupType // TypeDefIndex: 50577
	{
		HAPI_GROUPTYPE_INVALID = -1,
		HAPI_GROUPTYPE_POINT = 0,
		HAPI_GROUPTYPE_PRIM = 1,
		HAPI_GROUPTYPE_EDGE = 2,
		HAPI_GROUPTYPE_MAX = 3
	}

	public enum HAPI_AttributeOwner // TypeDefIndex: 50578
	{
		HAPI_ATTROWNER_INVALID = -1,
		HAPI_ATTROWNER_VERTEX = 0,
		HAPI_ATTROWNER_POINT = 1,
		HAPI_ATTROWNER_PRIM = 2,
		HAPI_ATTROWNER_DETAIL = 3,
		HAPI_ATTROWNER_MAX = 4
	}

	public enum HAPI_CurveType // TypeDefIndex: 50579
	{
		HAPI_CURVETYPE_INVALID = -1,
		HAPI_CURVETYPE_LINEAR = 0,
		HAPI_CURVETYPE_NURBS = 1,
		HAPI_CURVETYPE_BEZIER = 2,
		HAPI_CURVETYPE_MAX = 3
	}

	public enum HAPI_InputCurveMethod // TypeDefIndex: 50580
	{
		HAPI_CURVEMETHOD_INVALID = -1,
		HAPI_CURVEMETHOD_CVS = 0,
		HAPI_CURVEMETHOD_BREAKPOINTS = 1,
		HAPI_CURVEMETHOD_MAX = 2
	}

	public enum HAPI_InputCurveParameterization // TypeDefIndex: 50581
	{
		HAPI_CURVEPARAMETERIZATION_INVALID = -1,
		HAPI_CURVEPARAMETERIZATION_UNIFORM = 0,
		HAPI_CURVEPARAMETERIZATION_CHORD = 1,
		HAPI_CURVEPARAMETERIZATION_CENTRIPETAL = 2,
		HAPI_CURVEPARAMETERIZATION_MAX = 3
	}

	public enum HAPI_VolumeType // TypeDefIndex: 50582
	{
		HAPI_VOLUMETYPE_INVALID = -1,
		HAPI_VOLUMETYPE_HOUDINI = 0,
		HAPI_VOLUMETYPE_VDB = 1,
		HAPI_VOLUMETYPE_MAX = 2
	}

	public enum HAPI_VolumeVisualType // TypeDefIndex: 50583
	{
		HAPI_VOLUMEVISTYPE_INVALID = -1,
		HAPI_VOLUMEVISTYPE_SMOKE = 0,
		HAPI_VOLUMEVISTYPE_RAINBOW = 1,
		HAPI_VOLUMEVISTYPE_ISO = 2,
		HAPI_VOLUMEVISTYPE_INVISIBLE = 3,
		HAPI_VOLUMEVISTYPE_HEIGHTFIELD = 4,
		HAPI_VOLUMEVISTYPE_MAX = 5
	}

	public enum HAPI_StorageType // TypeDefIndex: 50584
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

	public enum HAPI_AttributeTypeInfo // TypeDefIndex: 50585
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

	public enum HAPI_GeoType // TypeDefIndex: 50586
	{
		HAPI_GEOTYPE_INVALID = -1,
		HAPI_GEOTYPE_DEFAULT = 0,
		HAPI_GEOTYPE_INTERMEDIATE = 1,
		HAPI_GEOTYPE_INPUT = 2,
		HAPI_GEOTYPE_CURVE = 3,
		HAPI_GEOTYPE_MAX = 4
	}

	public enum HAPI_PartType // TypeDefIndex: 50587
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

	public enum HAPI_InputType // TypeDefIndex: 50588
	{
		HAPI_INPUT_INVALID = -1,
		HAPI_INPUT_TRANSFORM = 0,
		HAPI_INPUT_GEOMETRY = 1,
		HAPI_INPUT_MAX = 2
	}

	public enum HAPI_CurveOrders // TypeDefIndex: 50589
	{
		HAPI_CURVE_ORDER_VARYING = 0,
		HAPI_CURVE_ORDER_INVALID = 1,
		HAPI_CURVE_ORDER_LINEAR = 2,
		HAPI_CURVE_ORDER_QUADRATIC = 3,
		HAPI_CURVE_ORDER_CUBIC = 4
	}

	public enum HAPI_TransformComponent // TypeDefIndex: 50590
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

	public enum HAPI_RSTOrder // TypeDefIndex: 50591
	{
		HAPI_TRS = 0,
		HAPI_TSR = 1,
		HAPI_RTS = 2,
		HAPI_RST = 3,
		HAPI_STR = 4,
		HAPI_SRT = 5,
		HAPI_RSTORDER_DEFAULT = 5
	}

	public enum HAPI_XYZOrder // TypeDefIndex: 50592
	{
		HAPI_XYZ = 0,
		HAPI_XYZORDER_DEFAULT = 0,
		HAPI_XZY = 1,
		HAPI_YXZ = 2,
		HAPI_YZX = 3,
		HAPI_ZXY = 4,
		HAPI_ZYX = 5
	}

	public enum HAPI_ImageDataFormat // TypeDefIndex: 50593
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

	public enum HAPI_ImagePacking // TypeDefIndex: 50594
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

	public enum HAPI_EnvIntType // TypeDefIndex: 50595
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

	public enum HAPI_SessionEnvIntType // TypeDefIndex: 50596
	{
		HAPI_SESSIONENVINT_INVALID = -1,
		HAPI_SESSIONENVINT_LICENSE = 100,
		HAPI_SESSIONENVINT_MAX = 101
	}

	public enum HAPI_CacheProperty // TypeDefIndex: 50597
	{
		HAPI_CACHEPROP_CURRENT = 0,
		HAPI_CACHEPROP_HAS_MIN = 1,
		HAPI_CACHEPROP_MIN = 2,
		HAPI_CACHEPROP_HAS_MAX = 3,
		HAPI_CACHEPROP_MAX = 4,
		HAPI_CACHEPROP_CULL_LEVEL = 5
	}

	public enum HAPI_HeightFieldSampling // TypeDefIndex: 50598
	{
		HAPI_HEIGHTFIELD_SAMPLING_CENTER = 0,
		HAPI_HEIGHTFIELD_SAMPLING_CORNER = 1
	}

	public enum HAPI_PDG_State // TypeDefIndex: 50599
	{
		HAPI_PDG_STATE_READY = 0,
		HAPI_PDG_STATE_MAX_READY_STATE = 0,
		HAPI_PDG_STATE_COOKING = 1,
		HAPI_PDG_STATE_MAX = 2
	}

	public enum HAPI_PDG_EventType // TypeDefIndex: 50600
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

	public enum HAPI_PDG_WorkItemState // TypeDefIndex: 50601
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

	public enum HAPI_TCP_PortType // TypeDefIndex: 50602
	{
		HAPI_TCP_PORT_ANY = 0,
		HAPI_TCP_PORT_RANGE = 1,
		HAPI_TCP_PORT_LIST = 2
	}

	public enum HAPI_ThriftSharedMemoryBufferType // TypeDefIndex: 50603
	{
		HAPI_THRIFT_SHARED_MEMORY_FIXED_LENGTH_BUFFER = 0,
		HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER = 1
	}

	public static class HEU_HAPIFunctions // TypeDefIndex: 50604
	{
	}

	[Serializable]
	public struct HAPI_Transform // TypeDefIndex: 50605
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
		} // 0x000000018A918728-0x000000018A9187F0
	
		// Methods
		public void Init() {} // 0x000000018A918668-0x000000018A918728
	}

	[Serializable]
	public struct HAPI_TransformEuler // TypeDefIndex: 50606
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
		} // 0x000000018A9185A0-0x000000018A918668
	
		// Methods
		public void Init() {} // 0x000000018A9184FC-0x000000018A9185A0
	}

	[Serializable]
	public struct HAPI_Session // TypeDefIndex: 50607
	{
		// Fields
		public HAPI_SessionType type; // 0x00
		public long id; // 0x08
	}

	[Serializable]
	public struct HAPI_SessionInfo // TypeDefIndex: 50608
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

	public struct HAPI_ThriftServerOptions // TypeDefIndex: 50609
	{
		// Fields
		public bool autoClose; // 0x00
		public float timeoutMs; // 0x04
		public HAPI_StatusVerbosity verbosity; // 0x08
		public HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType; // 0x0C
		public long sharedMemoryBufferSize; // 0x10
	}

	public struct HAPI_TimelineOptions // TypeDefIndex: 50610
	{
		// Fields
		public double fps; // 0x00
		public double startTime; // 0x08
		public double endTime; // 0x10
	}

	[Serializable]
	public struct HAPI_AssetInfo // TypeDefIndex: 50611
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

	public struct HAPI_CookOptions // TypeDefIndex: 50612
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
	public struct HAPI_NodeInfo // TypeDefIndex: 50613
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
	public struct HAPI_ParmInfo // TypeDefIndex: 50614
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
		public bool isInt() => default; // 0x000000018A9181D4-0x000000018A9181F4
		public bool isFloat() => default; // 0x000000018A9181C0-0x000000018A9181D4
		public bool isString() => default; // 0x000000018A918230-0x000000018A918250
		public bool isPath() => default; // 0x000000018A918218-0x000000018A918230
		public bool isNode() => default; // 0x000000018A9181F4-0x000000018A918204
		public bool isNonValue() => default; // 0x000000018A918204-0x000000018A918218
	}

	[Serializable]
	public struct HAPI_ParmChoiceInfo // TypeDefIndex: 50615
	{
		// Fields
		public int parentParmId; // 0x00
		public int labelSH; // 0x04
		public int valueSH; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleInfo // TypeDefIndex: 50616
	{
		// Fields
		public int nameSH; // 0x00
		public int typeNameSH; // 0x04
		public int bindingsCount; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleBindingInfo // TypeDefIndex: 50617
	{
		// Fields
		public int handleParmNameSH; // 0x00
		public int assetParmNameSH; // 0x04
		public int assetParmId; // 0x08
		public int assetParmIndex; // 0x0C
	}

	[Serializable]
	public struct HAPI_ObjectInfo // TypeDefIndex: 50618
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
	public struct HAPI_GeoInfo // TypeDefIndex: 50619
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
		public int getGroupCountByType(HAPI_GroupType type) => default; // 0x000000018A91815C-0x000000018A918170
	}

	public struct HAPI_PartInfo // TypeDefIndex: 50620
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
		public int pointAttributeCount { get => default; set {} } // 0x000000018A9182C0-0x000000018A9182F4 0x000000018A9183EC-0x000000018A91842C
		public int primitiveAttributeCount { get => default; set {} } // 0x000000018A9182F4-0x000000018A918328 0x000000018A91842C-0x000000018A91846C
		public int vertexAttributeCount { get => default; set {} } // 0x000000018A918328-0x000000018A91835C 0x000000018A91846C-0x000000018A9184AC
		public int detailAttributeCount { get => default; set {} } // 0x000000018A91828C-0x000000018A9182C0 0x000000018A9183AC-0x000000018A9183EC
	
		// Methods
		public int getElementCountByAttributeOwner(HAPI_AttributeOwner owner) => default; // 0x000000018A918250-0x000000018A918278
		public int getElementCountByGroupType(HAPI_GroupType type) => default; // 0x000000018A918278-0x000000018A91828C
		public void init() {} // 0x000000018A91835C-0x000000018A9183AC
	}

	[Serializable]
	public struct HAPI_AttributeInfo // TypeDefIndex: 50621
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
		} // 0x0000000185FCE090-0x0000000185FCE0C0
	}

	public struct HAPI_MaterialInfo // TypeDefIndex: 50622
	{
		// Fields
		public int nodeId; // 0x00
		public bool exists; // 0x04
		public bool hasChanged; // 0x05
	}

	public struct HAPI_ImageFileFormat // TypeDefIndex: 50623
	{
		// Fields
		public int nameSH; // 0x00
		public int descriptionSH; // 0x04
		public int defaultExtensionSH; // 0x08
	}

	public struct HAPI_ImageInfo // TypeDefIndex: 50624
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

	public struct HAPI_Keyframe // TypeDefIndex: 50625
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
		} // 0x0000000185FB2B40-0x0000000185FB2B60
	}

	public struct HAPI_VolumeInfo // TypeDefIndex: 50626
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

	public struct HAPI_VolumeTileInfo // TypeDefIndex: 50627
	{
		// Fields
		public int minX; // 0x00
		public int minY; // 0x04
		public int minZ; // 0x08
		public bool isValid; // 0x0C
	}

	public struct HAPI_VolumeVisualInfo // TypeDefIndex: 50628
	{
		// Fields
		public HAPI_VolumeVisualType type; // 0x00
		public float iso; // 0x04
		public float density; // 0x08
	}

	public struct HAPI_CurveInfo // TypeDefIndex: 50629
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

	public struct HAPI_InputCurveInfo // TypeDefIndex: 50630
	{
		// Fields
		public HAPI_CurveType curveType; // 0x00
		public int order; // 0x04
		public bool closed; // 0x08
		public bool reverse; // 0x09
		public HAPI_InputCurveMethod inputMethod; // 0x0C
		public HAPI_InputCurveParameterization breakpointParameterization; // 0x10
	
		// Methods
		public void FillData(HEU_InputCurveInfo curveInfo) {} // 0x000000018A918170-0x000000018A9181C0
	}

	public struct HAPI_BoxInfo // TypeDefIndex: 50631
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
		} // 0x000000018A9180D4-0x000000018A91815C
	}

	public struct HAPI_SphereInfo // TypeDefIndex: 50632
	{
		// Fields
		public float[] center; // 0x00
		public float radius; // 0x08
	
		// Constructors
		public HAPI_SphereInfo(bool initialize_fields) {
			center = default;
			radius = default;
		} // 0x000000018A9184AC-0x000000018A9184FC
	}

	public struct HAPI_PDG_EventInfo // TypeDefIndex: 50633
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

	public struct HAPI_PDG_WorkItemInfo // TypeDefIndex: 50634
	{
		// Fields
		public int index; // 0x00
		public int outputFileCount; // 0x04
		public int nameSH; // 0x08
	}

	public struct HAPI_PDG_WorkItemOutputFile // TypeDefIndex: 50635
	{
		// Fields
		public int filePathSH; // 0x00
		public int tagSH; // 0x04
		public long hash; // 0x08
	}

	[Serializable]
	public struct HAPI_Viewport // TypeDefIndex: 50636
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
		} // 0x000000018A918868-0x000000018A9188EC
	
		// Methods
		public void Init() {} // 0x000000018A9187F0-0x000000018A918868
	}

	[Serializable]
	public struct HAPI_SessionSyncInfo // TypeDefIndex: 50637
	{
		// Fields
		public bool cookUsingHoudiniTime; // 0x00
		public bool syncViewport; // 0x01
	}

	public struct HAPI_CompositorOptions // TypeDefIndex: 50638
	{
		// Fields
		public int maximumResolutionX; // 0x00
		public int maximumResolutionY; // 0x04
	}

	public class HEU_HARCImports // TypeDefIndex: 50639
	{
		// Constructors
		public HEU_HARCImports() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HEU_HoudiniVersion // TypeDefIndex: 50640
	{
		// Fields
		public const int HOUDINI_MAJOR = 21; // Metadata: 0x0206402A
		public const int HOUDINI_MINOR = 0; // Metadata: 0x0206402B
		public const int HOUDINI_BUILD = 631; // Metadata: 0x0206402C
		public const int HOUDINI_PATCH = 0; // Metadata: 0x0206402E
		public const string HOUDINI_VERSION_STRING = "21.0.631"; // Metadata: 0x0206402F
		public const int HOUDINI_ENGINE_MAJOR = 8; // Metadata: 0x02064038
		public const int HOUDINI_ENGINE_MINOR = 0; // Metadata: 0x02064039
		public const int HOUDINI_ENGINE_API = 3; // Metadata: 0x0206403A
		public const int UNITY_PLUGIN_VERSION = 2; // Metadata: 0x0206403B
		public const string HAPI_BIN_PATH = "/bin"; // Metadata: 0x0206403C
		public const string HAPI_LIBRARY = "libHAPIL"; // Metadata: 0x02064041
		public const string HARC_LIBRARY = "libHARC"; // Metadata: 0x0206404A
		public const string SIDEFX_SOFTWARE_REGISTRY = "SOFTWARE\\Side Effects Software\\"; // Metadata: 0x02064052
	
		// Constructors
		public HEU_HoudiniVersion() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HTC_APIConstants // TypeDefIndex: 50641
	{
		// Fields
		public const string HOUDINI_MASTER_SERVER_HOSTNAME = "tech.houdini.int.hypergryph.com"; // Metadata: 0x02064072
		public const int HOUDINI_MASTER_QUERY_FOR_UNITY_PORT = 20240; // Metadata: 0x02064092
		public const int TCP_HEADER_SIZE = 4; // Metadata: 0x02064096
		public const int MAX_ERROR_INFO_SIZE = 256; // Metadata: 0x02064097
	
		// Constructors
		public HTC_APIConstants() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HTC_VERSION // TypeDefIndex: 50642
	{
		// Fields
		public const string LIBRARY = "HTCLib"; // Metadata: 0x02064099
	
		// Constructors
		public HTC_VERSION() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HoudiniConstsIdentifier // TypeDefIndex: 50643
	{
		// Fields
		public const string HOUDINI_VERSION = "19.5"; // Metadata: 0x020640A0
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x020640A5
	
		// Constructors
		public HoudiniConstsIdentifier() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class HTC_APIFunctions // TypeDefIndex: 50644
	{
		// Constructors
		public HTC_APIFunctions() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static extern void InitHoudiniTcpClient(string address, int port, bool use_ip, [In, Out] StringBuilder error_msg); // 0x000000018A931558-0x000000018A931638
		internal static extern void GetHarsInfo(ref HarsInfo harsInfo, [In, Out] StringBuilder error_msg); // 0x000000018A931448-0x000000018A931558
		internal static extern void UninitializeHoudiniTcpClient([In, Out] StringBuilder error_msg); // 0x000000018A931638-0x000000018A9316D8
	}

	internal struct HarsInfo // TypeDefIndex: 50645
	{
		// Fields
		public string hars_address; // 0x00
		public int port; // 0x08
	}

	internal struct GenericMessage // TypeDefIndex: 50646
	{
		// Fields
		public string protocol; // 0x00
		public object body; // 0x08
	}

	public static class Logger // TypeDefIndex: 50647
	{
		// Methods
		public static void LogError(string msg) {} // 0x000000018A933428-0x000000018A933474
		public static void LogWarning(string msg) {} // 0x000000018A9334C0-0x000000018A93350C
		public static void LogInfo(string msg) {} // 0x000000018A933474-0x000000018A9334C0
	}

	public class HTC_SessionManager : IDisposable // TypeDefIndex: 50648
	{
		// Fields
		private bool disposedValue; // 0x10
		private static HTC_SessionManager instance_; // 0x00
	
		// Properties
		public static HTC_SessionManager Instance { get => default; } // 0x000000018A9321A8-0x000000018A93222C 
	
		// Constructors
		private HTC_SessionManager() {} // 0x000000018A9319B8-0x000000018A9321A8
	
		// Methods
		~HTC_SessionManager() {} // 0x000000018A931884-0x000000018A9318F8
		protected virtual void Dispose(bool disposing) {} // 0x000000018A931790-0x000000018A931884
		public void Dispose() {} // 0x000000018A931740-0x000000018A931790
		public bool GetOrRequestAvailableHARSInfo(out string harsAddress, out int harsPort, out string errorInfo) {
			harsAddress = default;
			harsPort = default;
			errorInfo = default;
			return default;
		} // 0x000000018A9318F8-0x000000018A9319B8
		public static void Close() {} // 0x000000018A9316D8-0x000000018A931740
	}

	public static class HTC_Utils // TypeDefIndex: 50649
	{
		// Fields
		private static readonly string CurrentUnityProjectPrefix; // 0x00
	
		// Constructors
		static HTC_Utils() {} // 0x000000018A932434-0x000000018A9324E0
	
		// Methods
		public static string GetUnityPathFromSystemPath(string systemPath) => default; // 0x000000018A93222C-0x000000018A932434
	}

	public static class HoudiniExtTools // TypeDefIndex: 50650
	{
		// Fields
		private static readonly string LOCAL_IP_ADDRESS; // 0x00
		private static readonly string REMOTE_HOUDINI_SMB_PATH_PREFIX; // 0x08
		private static readonly string REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX; // 0x10
		public const string REMOTE_HOUDINI_HDA_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_hda"; // Metadata: 0x020640D3
		public const string REMOTE_HOUDINI_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_share"; // Metadata: 0x02064107
		public const string LINUX_MOUNT_DIR_PREFIX = "/mnt/houdini_share"; // Metadata: 0x0206413D
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x02064150
	
		// Properties
		private static long DefaultSessionID { get; } // 0x000000018A9333D8-0x000000018A933428 
	
		// Constructors
		static HoudiniExtTools() {} // 0x000000018A9332DC-0x000000018A9333D8
	
		// Methods
		private static long GetSessionID(long sessionId) => default; // 0x000000018A933018-0x000000018A933064
		public static string GetDefaultDirectoryOnTheSMB() => default; // 0x000000018A932AE0-0x000000018A932B30
		public static string GetDefaultSessionDirectoryOnTheSMB(long sessionId = -1 /* Metadata: 0x020640AA */) => default; // 0x000000018A932B5C-0x000000018A932BFC
		public static string ConvertLocalDirPathToSessionDirPath(string localPath, bool doMd5 = true /* Metadata: 0x020640B2 */, long sessionId = -1 /* Metadata: 0x020640B3 */) => default; // 0x000000018A932764-0x000000018A932894
		public static string ConvertLocalDebugFilePathToSessionDebugFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x020640BB */) => default; // 0x000000018A93266C-0x000000018A932764
		public static string ConvertLocalFilePathToSessionFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x020640C3 */) => default; // 0x000000018A932894-0x000000018A932A80
		public static bool IsLocalPath(string path) => default; // 0x000000018A933064-0x000000018A9332DC
		public static string GetMD5WithString(string str) => default; // 0x000000018A932F14-0x000000018A933018
		public static string GetLocalIPv4() => default; // 0x000000018A932C28-0x000000018A932F14
		public static string GetHoudiniSMBUrl() => default; // 0x000000018A932BFC-0x000000018A932C28
		public static string GetDefaultCachePath(long sessionId = -1 /* Metadata: 0x020640CB */) => default; // 0x000000018A932A80-0x000000018A932AE0
		public static string GetDefaultHdaPath() => default; // 0x000000018A932B30-0x000000018A932B5C
	}

	public static class HoudiniExtBridge // TypeDefIndex: 50651
	{
		// Methods
		public static bool GetParametersFromHDA(byte[] hdaBytes, out HEU_Parameters parameters, out List<HEU_InputNode> inputNodes) {
			parameters = default;
			inputNodes = default;
			return default;
		} // 0x000000018A932520-0x000000018A93266C
		public static void AddInputNodeToHoudiniAsset(HEU_HoudiniAsset asset, HEU_InputNode node) {} // 0x000000018A9324E0-0x000000018A9324FC
		public static void Clear(HEU_Parameters parameters) {} // 0x000000018A9324FC-0x000000018A932520
	}

	[Serializable]
	public sealed class HEU_ParameterData : IEquivable<HEU_ParameterData> // TypeDefIndex: 50652
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
		public int ParmID { get => default; } // 0x00000001834A0D40-0x00000001834A0D50 
		public int ParentID { get => default; } // 0x00000001834A0D60-0x00000001834A0D70 
		public int ChildIndex { get => default; } // 0x0000000185FB2320-0x0000000185FB2330 
		public int ParmSize { get => default; } // 0x0000000185FB9570-0x0000000185FB9580 
		public int IntMin { get => default; } // 0x000000018A91EAD8-0x000000018A91EAE8 
		public int IntMax { get => default; } // 0x000000018A91EAC8-0x000000018A91EAD8 
		public int IntUIMin { get => default; } // 0x000000018A91EAF8-0x000000018A91EB08 
		public int IntUIMax { get => default; } // 0x000000018A91EAE8-0x000000018A91EAF8 
		public float FloatMin { get => default; } // 0x0000000185FBAB60-0x0000000185FBAB70 
		public float FloatMax { get => default; } // 0x0000000185FB9BE0-0x0000000185FB9BF0 
		public float FloatUIMin { get => default; } // 0x0000000181AF1800-0x0000000181AF1810 
		public float FloatUIMax { get => default; } // 0x0000000185FB9660-0x0000000185FB9670 
	
		// Constructors
		public HEU_ParameterData() {} // 0x000000018A91EA50-0x000000018A91EAC8
	
		// Methods
		public bool IsInt() => default; // 0x000000018A91E97C-0x000000018A91E988
		public bool IsFloat() => default; // 0x000000018A91E964-0x000000018A91E970
		public bool IsString() => default; // 0x000000018A91E9B8-0x000000018A91E9C4
		public bool IsPathFile() => default; // 0x000000018A91E988-0x000000018A91E9A0
		public bool HasMin() => default; // 0x0000000185FBC890-0x0000000185FBC8A0
		public bool HasMax() => default; // 0x0000000185FCE2E0-0x0000000185FCE2F0
		public bool HasUIMin() => default; // 0x0000000185FCE300-0x0000000185FCE310
		public bool HasUIMax() => default; // 0x0000000185FCE2F0-0x0000000185FCE300
		public bool IsContainer() => default; // 0x000000018A91E1DC-0x000000018A91E220
		public bool IsMultiParam() => default; // 0x0000000187A7566C-0x0000000187A75678
		public bool IsRamp() => default; // 0x000000018A91E9A0-0x000000018A91E9B8
		public bool IsFloatRamp() => default; // 0x000000018A91E958-0x000000018A91E964
		public bool IsColorRamp() => default; // 0x000000018A91E1C4-0x000000018A91E1D0
		public bool IsToggle() => default; // 0x000000018A91E9C4-0x000000018A91E9D0
		public bool IsColor() => default; // 0x000000018A91E1D0-0x000000018A91E1DC
		public bool IsFolder() => default; // 0x000000018A91E970-0x000000018A91E97C
		public bool IsButton() => default; // 0x000000018A91E1B8-0x000000018A91E1C4
		public Vector3 ToVector3() => default; // 0x000000018A91E9D0-0x000000018A91EA50
		public bool IsAssetPath() => default; // 0x0000000185FB9470-0x0000000185FB9480
		public bool IsEquivalentTo(HEU_ParameterData other) => default; // 0x000000018A91E220-0x000000018A91E958
	}

	public enum HEU_ModifierActionWrapper // TypeDefIndex: 50653
	{
		MULTIPARM_INSERT = 0,
		MULTIPARM_REMOVE = 1,
		MULTIPARM_CLEAR = 2,
		SET_FLOAT = 3,
		SET_INT = 4
	}

	[Serializable]
	public class HEU_ParameterModifier : IEquivable<HEU_ParameterModifier> // TypeDefIndex: 50655
	{
		// Fields
		private int _parameterIndex; // 0x10
		internal ModifierAction _action; // 0x14
		private int _instanceIndex; // 0x18
		private int _modifierValue; // 0x1C
		private float _floatValue; // 0x20
		private int _intValue; // 0x24
	
		// Properties
		public int ParameterIndex { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public HEU_ModifierActionWrapper Action { get => default; set {} } // 0x000000018A91EDE0-0x000000018A91EDEC 0x000000018A91EDEC-0x000000018A91EE0C
		public int InstanceIndex { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public int ModifierValue { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public float FloatValue { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public int IntValue { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
	
		// Nested types
		internal enum ModifierAction // TypeDefIndex: 50654
		{
			MULTIPARM_INSERT = 0,
			MULTIPARM_REMOVE = 1,
			MULTIPARM_CLEAR = 2,
			SET_FLOAT = 3,
			SET_INT = 4
		}
	
		// Constructors
		public HEU_ParameterModifier() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static HEU_ParameterModifier GetNewModifier(HEU_ModifierActionWrapper action, int parameterIndex, int instanceIndex, int modifierValue) => default; // 0x000000018A91EB08-0x000000018A91EB50
		internal static HEU_ParameterModifier GetNewModifier(ModifierAction action, int parameterIndex, int instanceIndex, int modifierValue) => default; // 0x000000018A91EB50-0x000000018A91EBC4
		public bool IsEquivalentTo(HEU_ParameterModifier other) => default; // 0x000000018A91EBC4-0x000000018A91EDAC
		internal static HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(ModifierAction action) => default; // 0x000000018A91EDAC-0x000000018A91EDE0
		internal static ModifierAction ModifierAction_WrapperToInternal(HEU_ModifierActionWrapper action) => default; // 0x000000018A91EDAC-0x000000018A91EDE0
	}

	public class HEU_Parameters : ScriptableObject, IHEU_Parameters, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Parameters> // TypeDefIndex: 50658
	{
		// Fields
		[NonSerialized]
		private int _nodeID; // 0x18
		internal string _uiLabel; // 0x20
		private int[] _paramInts; // 0x28
		private float[] _paramFloats; // 0x30
		private string[] _paramStrings; // 0x38
		private HAPI_ParmChoiceInfo[] _paramChoices; // 0x40
		private List<int> _rootParameters; // 0x48
		private List<HEU_ParameterData> _parameterList; // 0x50
		private List<HEU_ParameterModifier> _parameterModifiers; // 0x58
		private bool _regenerateParameters; // 0x60
		private byte[] _presetData; // 0x68
		private byte[] _defaultPresetData; // 0x70
		private bool _validParameters; // 0x78
		private bool _showParameters; // 0x79
		private bool _recacheUI; // 0x7A
		private HEU_HoudiniAsset _parentAsset; // 0x80
	
		// Properties
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x00000001813AE9C0-0x00000001813AE9D0 
		public bool ShowParameters { get => default; set {} } // 0x00000001813ECF20-0x00000001813ECF30 0x00000001813F1630-0x00000001813F1640
		public int NodeID { get => default; internal set {} } // 0x000000018386C570-0x000000018386C580 0x000000018386C580-0x000000018386C590
		public List<int> RootParameters { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public List<HEU_ParameterModifier> ParameterModifiers { get => default; } // 0x0000000185A62990-0x0000000185A629A0 
		internal bool RequiresRegeneration { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x0000000185FB2E60-0x0000000185FB2E70
		internal bool RecacheUI { get => default; set {} } // 0x000000018A926C24-0x000000018A926C8C 0x0000000181460F60-0x0000000181460F70
	
		// Nested types
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 50656
		{
			// Fields
			public int parentID; // 0x10
			public Predicate<HAPI_ParmInfo> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass82_0() {} // 0x000000018140CF50-0x000000018140CF60
	
			// Methods
			internal bool _Initialize_b__0(HAPI_ParmInfo p) => default; // 0x0000000185FB2E50-0x0000000185FB2E60
		}
	
		private sealed class __c__DisplayClass83_0 // TypeDefIndex: 50657
		{
			// Fields
			public int parentID; // 0x10
			public Predicate<HAPI_ParmInfo> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass83_0() {} // 0x0000000185FB2EB0-0x0000000185FB2EC0
	
			// Methods
			internal bool _Initialize4HGTool_b__0(HAPI_ParmInfo p) => default; // 0x00000001813AE560-0x00000001813AE570
		}
	
		// Constructors
		public HEU_Parameters() {} // 0x0000000187EBD7DC-0x0000000187EBD8E8
	
		// Methods
		internal byte[] GetPresetData() => default; // 0x0000000185FB2EC0-0x0000000185FB2ED0
		internal void SetPresetData(byte[] data) {} // 0x0000000185FB0DA0-0x0000000185FB0DB0
		internal byte[] GetDefaultPresetData() => default; // 0x000000018A921878-0x000000018A921910
		public bool AreParametersValid() => default; // 0x000000018A9215B0-0x000000018A921620
		public HEU_SessionBase GetSession() => default; // 0x000000018A921620-0x000000018A921760
		public void Recook() {} // 0x000000018A921490-0x000000018A9215B0
		public List<HEU_ParameterData> GetParameters() => default; // 0x000000018A926D14-0x000000018A926D80
		public HEU_ParameterData GetParameter(int listIndex) => default; // 0x000000018A921CF4-0x000000018A9221A0
		public HEU_ParameterData GetParameter(string name) => default; // 0x000000018A926F2C-0x000000018A926F74
		public HEU_ParameterData GetParameterWithParmID(int parmID) => default; // 0x000000018A927BC0-0x000000018A927DC8
		public void RemoveParameter(int listIndex) {} // 0x000000018A91FFEC-0x000000018A9201E0
		public bool HaveParametersChanged() => default; // 0x000000018A927DC8-0x000000018A928024
		public bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x0206415F */) => default; // 0x000000018A9201E0-0x000000018A920378
		public bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x02064160 */, bool bRecookAsset = false /* Metadata: 0x02064161 */) => default; // 0x000000018A927604-0x000000018A927730
		public bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x02064162 */) {
			value = default;
			return default;
		} // 0x000000018A91F9A8-0x000000018A91FAC8
		public bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x02064163 */) => default; // 0x000000018A9284BC-0x000000018A9286C4
		public bool GetFloatParameterValues(string parameterName, out float[] values) {
			values = default;
			return default;
		} // 0x000000018A920B80-0x000000018A920D74
		public bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x02064164 */) => default; // 0x000000018A9286C4-0x000000018A928928
		public bool GetColorParameterValue(string parameterName, out UnityEngine.Color value) {
			value = default;
			return default;
		} // 0x000000018A920D74-0x000000018A920F10
		public bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x02064165 */, bool bRecookAsset = false /* Metadata: 0x02064166 */) => default; // 0x000000018A927434-0x000000018A927604
		public bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x02064167 */) {
			value = default;
			return default;
		} // 0x000000018A91F800-0x000000018A91F9A8
		public bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x02064168 */) => default; // 0x000000018A927318-0x000000018A927434
		public bool GetIntParameterValues(string parameterName, out int[] values) {
			values = default;
			return default;
		} // 0x000000018A91F6F4-0x000000018A91F800
		public bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x02064169 */) => default; // 0x000000018A928F88-0x000000018A929190
		public bool GetChoiceParameterValue(string parameterName, out int value) {
			value = default;
			return default;
		} // 0x000000018A921910-0x000000018A921B2C
		public bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x0206416A */, bool bRecookAsset = false /* Metadata: 0x0206416B */) => default; // 0x000000018A929190-0x000000018A929400
		public bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x0206416C */) {
			value = default;
			return default;
		} // 0x000000018A921B2C-0x000000018A921CB0
		public bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x0206416D */, bool bRecookAsset = false /* Metadata: 0x0206416E */) => default; // 0x000000018A926F74-0x000000018A92713C
		public bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x0206416F */) {
			value = default;
			return default;
		} // 0x000000018A92713C-0x000000018A927318
		public bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x02064170 */) => default; // 0x000000018A91F3B0-0x000000018A91F528
		public bool GetStringParameterValues(string parameterName, out string[] values) {
			values = default;
			return default;
		} // 0x000000018A91F528-0x000000018A91F6F4
		public bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x02064171 */, bool bRecookAsset = false /* Metadata: 0x02064172 */) => default; // 0x000000018A928D14-0x000000018A928F88
		public bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x02064173 */) => default; // 0x000000018A921760-0x000000018A921878
		public bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x02064174 */) {
			value = default;
			return default;
		} // 0x000000018A928024-0x000000018A92831C
		public bool GetAssetRefParameterValues(string parameterName, out GameObject[] values) {
			values = default;
			return default;
		} // 0x000000018A920378-0x000000018A92066C
		public bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x02064175 */) => default; // 0x000000018A92831C-0x000000018A9284BC
		public bool GetRampParameterNumPoints(string parameterName, out int numPoints) {
			numPoints = default;
			return default;
		} // 0x000000018A92066C-0x000000018A9208A0
		public bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x02064176 */, bool bRecookAsset = false /* Metadata: 0x02064177 */) => default; // 0x000000018A927730-0x000000018A927A14
		public bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType) {
			pointPosition = default;
			pointValue = default;
			interpolationType = default;
			return default;
		} // 0x000000018A91FAC8-0x000000018A91FDB4
		public bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x02064178 */) => default; // 0x000000018A927A14-0x000000018A927BC0
		public bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints) {
			rampPoints = default;
			return default;
		} // 0x000000018A91FDB4-0x000000018A91FFEC
		public bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x02064179 */, bool bRecookAsset = false /* Metadata: 0x0206417A */) => default; // 0x000000018A929914-0x000000018A929A50
		public bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType) {
			pointPosition = default;
			pointValue = default;
			interpolationType = default;
			return default;
		} // 0x000000018A928928-0x000000018A928D14
		public bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x0206417B */) => default; // 0x000000018A9210AC-0x000000018A921490
		public bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints) {
			rampPoints = default;
			return default;
		} // 0x000000018A9242E4-0x000000018A92645C
		public bool TriggerButtonParameter(string parameterName) => default; // 0x000000018A9221A0-0x000000018A9242E4
		public bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecook = true /* Metadata: 0x0206417C */) => default; // 0x000000018A929400-0x000000018A92980C
		public bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples) {
			parameterTuples = default;
			return default;
		} // 0x000000018A929CF4-0x000000018A929DF8
		internal bool Initialize(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, Dictionary<string, HEU_ParameterData> previousParamFolders, Dictionary<string, HEU_InputNode> previousParamInputNodes, HEU_HoudiniAsset parentAsset) => default; // 0x000000018A92645C-0x000000018A9264E4
		internal bool Initialize4HGTool(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, int parentNodeId) => default; // 0x000000018A926C8C-0x000000018A926D14
		private void SetupRampParameter(HEU_ParameterData rampParameter) {} // 0x000000018A91F2A8-0x000000018A91F318
		internal bool UploadValuesToHoudini(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bDoCheck = true /* Metadata: 0x0206417D */, bool bForceUploadInputs = false /* Metadata: 0x0206417E */) => default; // 0x000000018A921CB0-0x000000018A921CF4
		internal void InsertInstanceToMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToAdd) {} // 0x000000018A9267C0-0x000000018A926C24
		internal void RemoveInstancesFromMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToRemove) {} // 0x000000018A920F10-0x000000018A9210AC
		internal void ClearInstancesFromMultiParm(int unityParamIndex) {} // 0x000000018A9208A0-0x000000018A920B80
		internal bool HasModifiersPending() => default; // 0x000000018A91F364-0x000000018A91F3B0
		internal void ProcessModifiers(HEU_SessionBase session) {} // 0x000000018A929CCC-0x000000018A929CF4
		internal void GetParameterDataForUIRestore(Dictionary<string, HEU_ParameterData> folderParams, Dictionary<string, HEU_InputNode> inputNodeParams) {} // 0x000000018A91F318-0x000000018A91F364
		internal void GetInputNodeConnectionObjects(List<GameObject> inputNodeObjects) {} // 0x000000018A929AE0-0x000000018A929CCC
		internal void DownloadPresetData(HEU_SessionBase session) {} // 0x000000018A929A50-0x000000018A929AE0
		internal void UploadPresetData(HEU_SessionBase session) {} // 0x000000018A9298E4-0x000000018A929914
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session) {} // 0x000000018A92980C-0x000000018A9298E4
		internal void UploadParameterInputs(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bForceUpdate) {} // 0x000000018A91EE0C-0x000000018A91F2A8
		internal void UpdateTransformParameters(HEU_SessionBase session, ref HAPI_TransformEuler HAPITransform) {} // 0x000000018A926D80-0x000000018A926F2C
		internal void SyncParameterFromHoudini(HEU_SessionBase session, string parameterName) {} // 0x000000018A9264E4-0x000000018A9267C0
		internal void SyncInternalParametersForUndoCompare(HEU_SessionBase session) {} // 0x000000018A929DF8-0x000000018A929F38
		internal void CleanUp() {} // 0x0000000185492010-0x0000000185492020
		internal void ResetAllToDefault(HEU_SessionBase session) {} // 0x0000000187EBD7DC-0x0000000187EBD8E8
		public bool IsEquivalentTo(HEU_Parameters other) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class HEU_ParameterUtility // TypeDefIndex: 50659
	{
		// Methods
		public static bool GetToggle(HEU_HoudiniAsset asset, string paramName, out bool outValue) {
			outValue = default;
			return default;
		} // 0x000000018A93FA68-0x000000018A93FB2C
		public static bool SetToggle(HEU_HoudiniAsset asset, string paramName, bool setValue) => default; // 0x000000018A940094-0x000000018A940158
		public static bool GetInt(HEU_HoudiniAsset asset, string paramName, out int outValue) {
			outValue = default;
			return default;
		} // 0x000000018A93F65C-0x000000018A93F720
		public static bool SetInt(HEU_HoudiniAsset asset, string paramName, int setValue) => default; // 0x000000018A93FF0C-0x000000018A93FFD0
		public static bool GetFloat(HEU_HoudiniAsset asset, string paramName, out float outValue) {
			outValue = default;
			return default;
		} // 0x000000018A93F408-0x000000018A93F4CC
		public static bool GetFloats(HEU_HoudiniAsset asset, string paramName, out float[] outValues) {
			outValues = default;
			return default;
		} // 0x000000018A93F4CC-0x000000018A93F590
		public static bool SetFloat(HEU_HoudiniAsset asset, string paramName, float setValue) => default; // 0x000000018A93FCB8-0x000000018A93FD7C
		public static bool SetFloats(HEU_HoudiniAsset asset, string paramName, float[] setValues) => default; // 0x000000018A93FD7C-0x000000018A93FE3C
		public static bool GetString(HEU_HoudiniAsset asset, string paramName, out string outValue) {
			outValue = default;
			return default;
		} // 0x000000018A93F99C-0x000000018A93FA68
		public static bool SetString(HEU_HoudiniAsset asset, string paramName, string setValue) => default; // 0x000000018A93FFD0-0x000000018A940094
		public static bool SetChoice(HEU_HoudiniAsset asset, string paramName, int setValue) => default; // 0x000000018A93FB2C-0x000000018A93FBEC
		public static bool GetChoice(HEU_HoudiniAsset asset, string paramName, out int outValue) {
			outValue = default;
			return default;
		} // 0x000000018A93F280-0x000000018A93F33C
		public static bool SetInputNode(HEU_HoudiniAsset asset, string paramName, GameObject obj, int index) => default; // 0x000000018A93FE3C-0x000000018A93FF0C
		public static bool GetInputNode(HEU_HoudiniAsset asset, string paramName, int index, out GameObject obj) {
			obj = default;
			return default;
		} // 0x000000018A93F590-0x000000018A93F65C
		public static bool GetColor(HEU_HoudiniAsset asset, string paramName, out UnityEngine.Color getValue) {
			getValue = default;
			return default;
		} // 0x000000018A93F33C-0x000000018A93F408
		public static bool SetColor(HEU_HoudiniAsset asset, string paramName, UnityEngine.Color setValue) => default; // 0x000000018A93FBEC-0x000000018A93FCB8
		public static int GetParameterIndexFromName(HEU_SessionBase session, HAPI_ParmInfo[] parameters, string parameterName) => default; // 0x000000018A93F8E0-0x000000018A93F99C
		public static int GetParameterIndexFromNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName) => default; // 0x000000018A93F8AC-0x000000018A93F8E0
		public static int FindTextureParamByNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, string useTextureParmName) => default; // 0x000000018A93F194-0x000000018A93F280
		public static bool GetParameterFloatValue(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, float defaultValue, out float returnValue) {
			returnValue = default;
			return default;
		} // 0x000000018A93F800-0x000000018A93F8AC
		public static bool GetParameterColor3Value(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, UnityEngine.Color defaultValue, out UnityEngine.Color outputColor) {
			outputColor = default;
			return default;
		} // 0x000000018A93F720-0x000000018A93F800
	}

	[Serializable]
	public class HEU_PDGCookedDataEvent : UnityEvent<HEU_PDGCookedEventData> // TypeDefIndex: 50660
	{
		// Constructors
		public HEU_PDGCookedDataEvent() {} // 0x000000018A93E8F4-0x000000018A93E930
	}

	public class HEU_PDGCookedEventData // TypeDefIndex: 50661
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_TOPNodeData TopNodeData; // 0x18
	
		// Constructors
		public HEU_PDGCookedEventData() {} // Dummy constructor
		public HEU_PDGCookedEventData(bool bSuccess, HEU_TOPNodeData bTopNodeData) {} // 0x000000018470BFE0-0x000000018470BFF0
	}

	public class HEU_PDGAssetLink : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 50666
	{
		// Fields
		private HEU_PDGCookedDataEvent _cookedDataEvent; // 0x18
		private string _assetPath; // 0x20
		private GameObject _assetGO; // 0x28
		private string _assetName; // 0x30
		private int _assetID; // 0x38
		private HEU_HoudiniAsset _heu; // 0x40
		private List<HEU_TOPNetworkData> _topNetworks; // 0x48
		private string[] _topNetworkNames; // 0x50
		private int _selectedTOPNetwork; // 0x58
		private LinkState _linkState; // 0x5C
		private bool _autoCook; // 0x60
		private bool _useHEngineData; // 0x61
		public UpdateUIDelegate _repaintUIDelegate; // 0x68
		public HEU_WorkItemTally _workItemTally; // 0x70
		private GameObject _loadRootGameObject; // 0x78
		private string _outputCachePathRoot; // 0x80
		private bool _bUseTOPNodeFilter; // 0x88
		private bool _bUseTOPOutputFilter; // 0x89
		private string _topNodeFilter; // 0x90
		private string _topOutputFilter; // 0x98
		private int _numLoadingResults; // 0xA0
		private int _numTotalResults; // 0xA4
	
		// Properties
		public bool AutoCook { get => default; set {} } // 0x0000000185FBCA10-0x0000000185FBCA20 0x0000000181B5FFD0-0x0000000181B5FFE0
		public bool UseHEngineData { get => default; set {} } // 0x00000001873CBEA8-0x00000001873CBEBC 0x0000000181E336C0-0x0000000181E336D0
		public bool UseTOPNodeFilter { get => default; set {} } // 0x00000001873350D4-0x00000001873350E8 0x00000001813FF010-0x00000001813FF020
		public bool UseTOPOutputFilter { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x00000001813B8590-0x00000001813B85A0
		public string TopNodeFilter { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001813E5E30-0x00000001813E5E40
		public string TopOutputFilter { get => default; set {} } // 0x00000001813ECF20-0x00000001813ECF30 0x0000000181460F60-0x0000000181460F70
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x0000000183F80450-0x0000000183F80460 
		public string AssetPath { get => default; } // 0x000000018A93E8C8-0x000000018A93E8F4 
		public GameObject AssetGO { get => default; } // 0x0000000183060C50-0x0000000183060C60 
		public string AssetName { get => default; } // 0x000000018140CF50-0x000000018140CF60 
		public int AssetID { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public List<HEU_TOPNetworkData> TopNetworks { get => default; } // 0x0000000183F80460-0x0000000183F80470 
		public string[] TopNetworkNames { get => default; } // 0x000000018A93E210-0x000000018A93E3A0 
		public int SelectedTOPNetwork { get => default; } // 0x000000018A93E06C-0x000000018A93E074 
		public HEU_LinkStateWrapper PDGLinkState { get => default; } // 0x000000018A93DD1C-0x000000018A93DFA8 
		public GameObject LoadRootGameObject { get => default; } // 0x000000018A93C1F8-0x000000018A93C344 
		public string OutputCachePathRoot { get => default; } // 0x000000018A93E074-0x000000018A93E0C8 
		public HEU_PDGCookedDataEvent CookedDataEvent { get => default; } // 0x000000018A93E0C8-0x000000018A93E120 
		internal LinkState AssetLinkStateInternal { get => default; } // 0x000000018A93C344-0x000000018A93C350 
	
		// Nested types
		internal enum LinkState // TypeDefIndex: 50662
		{
			INACTIVE = 0,
			LINKING = 1,
			LINKED = 2,
			ERROR_NOT_LINKED = 3
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 50663; 0x000000018386C580-0x000000018386C590
	
		private sealed class __c__DisplayClass107_0 // TypeDefIndex: 50664
		{
			// Fields
			public HEU_PDGAssetLink __4__this; // 0x10
			public Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced; // 0x18
			public HEU_TOPNodeData topNode; // 0x20
	
			// Constructors
			public __c__DisplayClass107_0() {} // 0x000000018316BFD0-0x000000018316BFE0
		}
	
		private sealed class __c__DisplayClass107_1 // TypeDefIndex: 50665
		{
			// Fields
			public HEU_GeoSync geoSync; // 0x10
			public __c__DisplayClass107_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass107_1() {} // 0x0000000185FB0AB0-0x0000000185FB0AC0
	
			// Methods
			internal void _LoadResults_b__0(HEU_SyncedEventData Data) {} // 0x0000000185FB3080-0x0000000185FB3090
		}
	
		// Constructors
		public HEU_PDGAssetLink() {} // 0x000000018A9433B8-0x000000018A943490
	
		// Methods
		public void Setup(HEU_HoudiniAsset hdaAsset) {} // 0x000000018A93C350-0x000000018A93C3CC
		public void Reset() {} // 0x000000018A93C474-0x000000018A93C4E4
		public void Refresh() {} // 0x000000018A93BEEC-0x000000018A93BF14
		public List<KeyValuePair<int, HEU_TOPNodeData>> GetNonHiddenTOPNodes(HEU_TOPNetworkData topNetwork) => default; // 0x000000018A93BEEC-0x000000018A93BF14
		public void SelectTOPNetwork(int newIndex) {} // 0x000000018A93C0C4-0x000000018A93C0E4
		public void SelectTOPNode(HEU_TOPNetworkData network, int newIndex) {} // 0x000000018A93BEA8-0x000000018A93BEEC
		public HEU_TOPNetworkData GetSelectedTOPNetwork() => default; // 0x000000018A93B928-0x000000018A93B938
		public HEU_TOPNodeData GetSelectedTOPNode() => default; // 0x000000018A93B928-0x000000018A93B938
		public HEU_TOPNetworkData GetTOPNetwork(int index) => default; // 0x000000018A93C0E4-0x000000018A93C158
		public void DirtyTOPNode(HEU_TOPNodeData topNode) {} // 0x000000018A93C65C-0x000000018A93C7C0
		public void CookTOPNode(HEU_TOPNodeData topNode) {} // 0x000000018A93C58C-0x000000018A93C65C
		public void DirtyAll() {} // 0x000000018A93C3CC-0x000000018A93C474
		public void CookOutput() {} // 0x000000018A93C4E4-0x000000018A93C58C
		public void PauseCook() {} // 0x0000000185492010-0x0000000185492020
		public void CancelCook() {} // 0x0000000185492010-0x0000000185492020
		public HEU_SessionBase GetHAPISession() => default; // 0x0000000185492010-0x0000000185492020
		public HEU_TOPNodeData GetTOPNode(int nodeID) => default; // 0x0000000185492010-0x0000000185492020
		public string GetTOPNodeStatus(HEU_TOPNodeData topNode) => default; // 0x000000018A93D0E0-0x000000018A93D0F0
		public static HEU_TOPNetworkData GetTOPNetworkByName(string name, List<HEU_TOPNetworkData> topNetworks) => default; // 0x000000018A93D0A8-0x000000018A93D0E0
		public static HEU_TOPNodeData GetTOPNodeByName(string name, List<HEU_TOPNodeData> topNodes) => default; // 0x000000018A93D080-0x000000018A93D0A8
		private void Awake() {} // 0x000000018A93D080-0x000000018A93D0A8
		public void OnBeforeSerialize() {} // 0x000000018A93D884-0x000000018A93D9CC
		public void OnAfterDeserialize() {} // 0x000000018A93D9CC-0x000000018A93DBA4
		private void HandleInitialLoad() {} // 0x000000018A93DBA4-0x000000018A93DD1C
		private void OnDestroy() {} // 0x000000018A93B938-0x000000018A93BC04
		private void NotifyAssetCooked(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> generatedOutputs) {} // 0x000000018A93BC04-0x000000018A93BD18
		private void NotifyAssetCooked(HEU_CookedEventData cookedEventData) {} // 0x000000018A93BD18-0x000000018A93BE14
		private void NotifyAssetCooked(HEU_ReloadEventData reloadEventData) {} // 0x000000018A93BE14-0x000000018A93BE38
		private void PopulateFromHDA() {} // 0x000000018A93BE38-0x000000018A93BEA8
		public bool PopulateTOPNetworks() => default; // 0x000000018A93E3A0-0x000000018A93E414
		private bool PopulateTOPNodes(HEU_SessionBase session, HEU_TOPNetworkData topNetwork, int[] topNodeIDs, bool useHEngineData) => default; // 0x000000018A93C7C0-0x000000018A93C90C
		private void ClearAllTOPData() {} // 0x000000018A93BF14-0x000000018A93C0C4
		private static void ClearTOPNetworkWorkItemResults(HEU_TOPNetworkData topNetwork) {} // 0x000000018A93C90C-0x000000018A93D080
		internal static void ClearTOPNodeWorkItemResults(HEU_TOPNodeData topNode) {} // 0x000000018A93C158-0x000000018A93C1F8
		internal static void ClearWorkItemResultByID(HEU_TOPNodeData topNode, int workItemID) {} // 0x000000018A93DFA8-0x000000018A93DFC0
		private static void ClearWorkItemResult(HEU_TOPNodeData topNode, HEU_TOPWorkResult result) {} // 0x000000018A93E414-0x000000018A93E7B8
		internal void UpdateTOPNodeResultsVisibility(HEU_TOPNodeData topNode) {} // 0x000000018A93DFC0-0x000000018A93E06C
		private static HEU_TOPWorkResult GetWorkResultByID(HEU_TOPNodeData topNode, int workItemID) => default; // 0x000000018A93D148-0x000000018A93D4C4
		private static void DestroyWorkItemResultData(HEU_TOPNodeData topNode, HEU_TOPWorkResult result) {} // 0x000000018A93D4C4-0x000000018A93D824
		internal void LoadResults(HEU_SessionBase session, HEU_TOPNodeData topNode, HAPI_PDG_WorkItemInfo workItemInfo, HAPI_PDG_WorkItemOutputFile[] resultInfos, int workItemID, Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced) {} // 0x000000018A93D824-0x000000018A93D884
		private Transform GetLoadRootTransform() => default; // 0x000000018A93E120-0x000000018A93E210
		public void RepaintUI() {} // 0x000000018A93D0F0-0x000000018A93D148
		public void UpdateWorkItemTally() {} // 0x000000018A8F32F8-0x000000018A8F3320
		internal void ResetTOPNetworkWorkItemTally(HEU_TOPNetworkData topNetwork) {} // 0x000000018A8F32F8-0x000000018A8F3320
		internal void OnTOPNodeFilterChanged(string filter) {} // 0x000000018A93E7B8-0x000000018A93E8C8
		internal void OnTOPOutputFilterChanged(string filter) {} // 0x00000001864BC330-0x00000001864BC3F4
		private static void ParseHEngineData(HEU_SessionBase session, int topNodeID, ref HAPI_NodeInfo nodeInfo, ref TOPNodeTags nodeTags) {} // 0x00000001864BC320-0x00000001864BC330
		private void SetupTopNetworkNames(HEU_TOPNetworkData topNetwork) {} // 0x00000001864BC2FC-0x00000001864BC320
		private void OnSyncComplete(HEU_PDGCookedEventData Data) {} // 0x00000001864BB614-0x00000001864BB734
		internal static HEU_LinkStateWrapper LinkState_InternalToWrapper(LinkState linkState) => default; // 0x0000000185492010-0x0000000185492020
		internal static LinkState LinkState_WrapperToInternal(HEU_LinkStateWrapper linkState) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class TOPNodeTags // TypeDefIndex: 50667
	{
		// Fields
		public bool _show; // 0x10
		public bool _autoload; // 0x11
		public bool _showHEngineData; // 0x12
		public bool _autoloadHEngineData; // 0x13
	
		// Constructors
		public TOPNodeTags() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_TOPNetworkData // TypeDefIndex: 50668
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
		public HEU_TOPNetworkData() {} // 0x000000018A9429B0-0x000000018A942A78
	}

	[Serializable]
	public class HEU_TOPNodeData // TypeDefIndex: 50670
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
		public HEU_WorkItemTally _workItemTally; // 0x48
	
		// Nested types
		public enum PDGState // TypeDefIndex: 50669
		{
			NONE = 0,
			DIRTIED = 1,
			DIRTYING = 2,
			COOKING = 3,
			COOK_COMPLETE = 4,
			COOK_FAILED = 5
		}
	
		// Constructors
		public HEU_TOPNodeData() {} // 0x000000018A942B04-0x000000018A942BD4
	
		// Methods
		public void Reset() {} // 0x000000018A942AD8-0x000000018A942B04
		public bool AreAllWorkItemsComplete() => default; // 0x000000018A942AB8-0x000000018A942AD8
		public bool AnyWorkItemsFailed() => default; // 0x000000018A942A78-0x000000018A942A98
		public bool AnyWorkItemsPending() => default; // 0x000000018A942A98-0x000000018A942AB8
	}

	[Serializable]
	public class HEU_TOPWorkResult // TypeDefIndex: 50671
	{
		// Fields
		public int _workItemIndex; // 0x10
		public int _workItemID; // 0x14
		public List<GameObject> _generatedGOs; // 0x18
	
		// Constructors
		public HEU_TOPWorkResult() {} // 0x000000018A942BD4-0x000000018A942C54
	}

	[Serializable]
	public class HEU_WorkItemTally // TypeDefIndex: 50672
	{
		// Fields
		public int _totalWorkItems; // 0x10
		public int _waitingWorkItems; // 0x14
		public int _scheduledWorkItems; // 0x18
		public int _cookingWorkItems; // 0x1C
		public int _cookedWorkItems; // 0x20
		public int _erroredWorkItems; // 0x24
	
		// Constructors
		public HEU_WorkItemTally() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ZeroAll() {} // 0x0000000185FCE4E0-0x0000000185FCE4F0
		public bool AreAllWorkItemsComplete() => default; // 0x000000018A943308-0x000000018A943328
		public bool AnyWorkItemsFailed() => default; // 0x000000018A9432E4-0x000000018A9432EC
		public bool AnyWorkItemsPending() => default; // 0x000000018A9432EC-0x000000018A943308
		public string ProgressRatio() => default; // 0x000000018A943328-0x000000018A9433B8
	}

	public class HEU_PDGSession // TypeDefIndex: 50676
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
		private StringBuilder _pdgEventMessages; // 0x60
		private string[] _eventMessageColorCode; // 0x68
	
		// Properties
		public Action<HEU_PDGCookedEventData> CookedDataEvent { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018A943490-0x000000018A9434C0
	
		// Nested types
		private delegate void OnWorkItemLoadResultsDelegate(HEU_SyncedEventData OnSynced); // TypeDefIndex: 50673; 0x000000018A93F044-0x000000018A93F194
	
		private enum EventMessageColor // TypeDefIndex: 50674
		{
			DEFAULT = 0,
			WARNING = 1,
			ERROR = 2
		}
	
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 50675
		{
			// Fields
			public int[] allNetworkNodeIds; // 0x10
			public int idx; // 0x18
			public Predicate<int> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _GetNonBypassedNetworkIds_b__0(int id) => default; // 0x000000018A93EA04-0x000000018A93EACC
		}
	
		// Constructors
		public HEU_PDGSession() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static HEU_PDGSession GetPDGSession() => default; // 0x0000000185492010-0x0000000185492020
		public void AddAsset(HEU_PDGAssetLink asset) {} // 0x0000000185492010-0x0000000185492020
		public void RemoveAsset(HEU_PDGAssetLink asset) {} // 0x000000018A93EF94-0x000000018A93EFA0
		private void Update() {} // 0x000000018A93E950-0x000000018A93EA04
		private void CleanUp() {} // 0x000000018A93ECCC-0x000000018A93EDD0
		private void UpdatePDGContext() {} // 0x000000018A93EFE8-0x000000018A93F044
		public void ReinitializePDGContext() {} // 0x000000018A93EE94-0x000000018A93EED4
		private void ProcessPDGEvent(HEU_SessionBase session, int contextID, ref HAPI_PDG_EventInfo eventInfo) {} // 0x000000018A93EF14-0x000000018A93EF54
		private void OnWorkItemLoadResults(HEU_TOPNodeData topNode, HEU_SyncedEventData OnSynced) {} // 0x000000018A93EDEC-0x000000018A93EE20
		private void CheckCallback(HEU_TOPNodeData topNode) {} // 0x000000018A93EE60-0x000000018A93EE94
		private bool GetTOPAssetLinkAndNode(int nodeID, out HEU_PDGAssetLink assetLink, out HEU_TOPNodeData topNode) {
			assetLink = default;
			topNode = default;
			return default;
		} // 0x000000018A93EF54-0x000000018A93EF94
		private void SetTOPNodePDGState(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, HEU_TOPNodeData.PDGState pdgState) {} // 0x000000018A93EED4-0x000000018A93EF14
		private void NotifyTOPNodePDGStateClear(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode) {} // 0x000000018A93EE20-0x000000018A93EE60
		private void NotifyTOPNodeTotalWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x0000000185FCE360-0x0000000185FCE380
		private void NotifyTOPNodeCookedWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode) {} // 0x000000018A93EFA0-0x000000018A93EFE8
		private void NotifyTOPNodeErrorWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode) {} // 0x000000018A93EACC-0x000000018A93EB10
		private void NotifyTOPNodeWaitingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x000000018A93EB58-0x000000018A93EBA8
		private void NotifyTOPNodeScheduledWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x0000000185492010-0x0000000185492020
		private void NotifyTOPNodeCookingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc) {} // 0x0000000185492010-0x0000000185492020
		private static void ResetPDGEventInfo(ref HAPI_PDG_EventInfo eventInfo) {} // 0x0000000185492010-0x0000000185492020
		private void SetErrorState(string msg, bool bLogIt) {} // 0x0000000185492010-0x0000000185492020
		private void ClearErrorState() {} // 0x00000001814A81B0-0x00000001814A81C0
		public HEU_SessionBase GetHAPIPDGSession(bool bCreate = true /* Metadata: 0x02064189 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public void CookTOPNetworkOutputNode(HEU_TOPNetworkData topNetwork, Action<HEU_PDGCookedEventData> OnCook = null) {} // 0x00000001814A81B0-0x00000001814A81C0
		public void PauseCook(HEU_TOPNetworkData topNetwork) {} // 0x000000018A93E930-0x000000018A93E950
		public void CancelCook(HEU_TOPNetworkData topNetwork) {} // 0x000000018A93EB34-0x000000018A93EB58
		public void ClearWorkItemResult(HEU_SessionBase session, int contextID, HAPI_PDG_EventInfo eventInfo, HEU_TOPNodeData topNode) {} // 0x000000018A93EB10-0x000000018A93EB34
		public bool DirtyTOPNode(int nodeID) => default; // 0x000000018A93EBA8-0x000000018A93EC3C
		public bool CookTOPNode(int nodeID) => default; // 0x000000018A93EDD0-0x000000018A93EDEC
		public bool DirtyAll(int nodeID) => default; // 0x0000000185FCE350-0x0000000185FCE360
		public void AddEventMessage(string msg) {} // 0x00000001813ECF20-0x00000001813ECF30
		public string GetEventMessages() => default; // 0x000000018571FEC0-0x000000018571FED0
		public void ClearEventMessages() {} // 0x0000000187893E40-0x0000000187893F64
		public static int[] GetNonBypassedNetworkIds(HEU_SessionBase session, int assetId) => default; // 0x00000001833EEC70-0x00000001833EEC80
		public static bool IsPDGAsset(HEU_SessionBase session, int assetId) => default; // 0x0000000185A264E0-0x0000000185A26510
		private void ResetCallbackVariables() {} // 0x00000001864BB614-0x00000001864BB734
	}

	public interface IHEU_Curve // TypeDefIndex: 50677
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
		void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x0206418D */);
		void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0206418E */);
		void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x0206418F */);
		Vector3 GetCurvePoint(int pointIndex);
		List<CurveNodeData> GetAllPointTransforms();
		List<Vector3> GetAllPoints();
		int GetNumPoints();
		void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x02064190 */);
		void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02064191 */);
		void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x02064192 */);
		void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x02064193 */);
		void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x02064194 */);
		void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x02064195 */);
		void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x02064196 */);
		void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x02064197 */);
		Vector3 GetTransformedPoint(int pointIndex);
		List<Vector3> GetTransformedPoints();
		List<CurveNodeData> DuplicateCurveNodeData();
	}

	public interface IHEU_GeoNode // TypeDefIndex: 50678
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
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x02064198 */);
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

	public enum HEU_AssetCookStatusWrapper // TypeDefIndex: 50679
	{
		NONE = 0,
		COOKING = 1,
		POSTCOOK = 2,
		LOADING = 3,
		POSTLOAD = 4,
		PRELOAD = 5,
		SELECT_SUBASSET = 6
	}

	public enum HEU_AssetCookResultWrapper // TypeDefIndex: 50680
	{
		NONE = 0,
		SUCCESS = 1,
		ERRORED = 2
	}

	public enum HEU_CurveDrawCollisionWrapper // TypeDefIndex: 50681
	{
		INVALID = 0,
		COLLIDERS = 1,
		LAYERMASK = 2
	}

	public enum HEU_AssetTypeWrapper // TypeDefIndex: 50682
	{
		TYPE_INVALID = 0,
		TYPE_HDA = 1,
		TYPE_CURVE = 2,
		TYPE_INPUT = 3
	}

	public interface IHEU_HoudiniAsset // TypeDefIndex: 50683
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
		bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x020641AA */, bool bAsync = false /* Metadata: 0x020641AB */, bool bSkipCookCheck = true /* Metadata: 0x020641AC */, bool bUploadParameters = true /* Metadata: 0x020641AD */);
		bool RequestReload(bool bAsync = false /* Metadata: 0x020641AE */);
		bool RequestResetParameters(bool bAsync = false /* Metadata: 0x020641AF */);
		GameObject DuplicateAsset(GameObject newRootGameObject = null);
		bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x020641B0 */);
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

	public interface IHEU_HoudiniAssetSubcomponent // TypeDefIndex: 50684
	{
		// Properties
		HEU_HoudiniAsset ParentAsset { get; }
	
		// Methods
		HEU_SessionBase GetSession();
		void Recook();
	}

	public enum HEU_InputNodeTypeWrapper // TypeDefIndex: 50685
	{
		CONNECTION = 0,
		NODE = 1,
		PARAMETER = 2
	}

	public enum HEU_InputObjectTypeWrapper // TypeDefIndex: 50686
	{
		HDA = 0,
		UNITY_MESH = 1,
		CURVE = 2,
		TERRAIN = 3,
		BOUNDING_BOX = 4,
		TILEMAP = 5
	}

	public interface IHEU_InputNode // TypeDefIndex: 50687
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
		void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x020641BA */);
		void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x020641BB */);
		void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x020641BC */);
		void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x020641BD */);
		void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x020641BE */);
		void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x020641BF */);
		void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x020641C0 */);
		void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x020641C1 */);
		void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x020641C2 */);
		void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x020641C3 */);
		void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x020641C4 */);
		bool AreAnyInputHDAsConnected();
		int GetConnectedInputCount();
		int GetConnectedNodeID(int index);
		void LoadPreset(HEU_InputPreset inputPreset);
		void PopulateInputPreset(HEU_InputPreset inputPreset, bool sceneRelativeGameObjects);
	}

	public enum HEU_MaterialSourceWrapper // TypeDefIndex: 50688
	{
		DEFAULT = 0,
		HOUDINI = 1,
		UNITY = 2,
		SUBSTANCE = 3
	}

	public interface IHEU_MaterialData // TypeDefIndex: 50689
	{
		// Properties
		Material Material { get; }
		HEU_MaterialSourceWrapper MaterialSource { get; }
		int MaterialKey { get; set; }
	
		// Methods
		bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath);
		bool IsExistingMaterial();
	}

	public interface IHEU_ObjectNode // TypeDefIndex: 50690
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

	public enum HEU_HoudiniRampInterpolationTypeWrapper // TypeDefIndex: 50691
	{
		CONSTANT = 0,
		LINEAR = 1,
		CATMULL_ROM = 2
	}

	public class HEU_RampPointWrapper // TypeDefIndex: 50692
	{
		// Fields
		private float _Position_k__BackingField; // 0x10
		private HEU_HoudiniRampInterpolationTypeWrapper _Interpolation_k__BackingField; // 0x14
	
		// Properties
		public float Position { get; set; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 0x0000000181A6E380-0x0000000181A6E390
		public HEU_HoudiniRampInterpolationTypeWrapper Interpolation { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
	
		// Constructors
		public HEU_RampPointWrapper() {} // Dummy constructor
		public HEU_RampPointWrapper(float position = 0f /* Metadata: 0x020641CC */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x020641D0 */) {} // 0x0000000185FCE380-0x0000000185FCE390
	}

	public class HEU_FloatRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 50693
	{
		// Fields
		private float _Value_k__BackingField; // 0x18
	
		// Properties
		public float Value { get; set; } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
	
		// Constructors
		public HEU_FloatRampPointWrapper() {} // Dummy constructor
		public HEU_FloatRampPointWrapper(float position = 0f /* Metadata: 0x020641D1 */, float value = 0f /* Metadata: 0x020641D5 */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x020641D9 */) {} // 0x0000000185FCE340-0x0000000185FCE350
	}

	public class HEU_ColorRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 50694
	{
		// Fields
		private UnityEngine.Color _Value_k__BackingField; // 0x18
	
		// Properties
		public UnityEngine.Color Value { get; set; } // 0x0000000185FB30D0-0x0000000185FB30E0 0x0000000185FB30E0-0x0000000185FB30F0
	
		// Constructors
		public HEU_ColorRampPointWrapper() {} // Dummy constructor
		public HEU_ColorRampPointWrapper(float position = 0f /* Metadata: 0x020641DA */, UnityEngine.Color value = default, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x020641DE */) {} // 0x0000000185FCE320-0x0000000185FCE340
	}

	public class HEU_ParameterTupleWrapper // TypeDefIndex: 50695
	{
		// Fields
		internal bool[] _boolValues; // 0x10
		internal int[] _intValues; // 0x18
		internal float[] _floatValues; // 0x20
		internal string[] _stringValues; // 0x28
		internal HEU_FloatRampPointWrapper[] _floatRampValues; // 0x30
		internal HEU_ColorRampPointWrapper[] _colorRampValues; // 0x38
	
		// Properties
		public bool[] BoolValues { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public int[] IntValues { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float[] FloatValues { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string[] StringValues { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public HEU_FloatRampPointWrapper[] FloatRampValues { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public HEU_ColorRampPointWrapper[] ColorRampValues { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		public HEU_ParameterTupleWrapper() {} // 0x0000000185492010-0x0000000185492020
		public HEU_ParameterTupleWrapper(bool[] boolValues) {} // 0x0000000184096E30-0x0000000184096EF0
		public HEU_ParameterTupleWrapper(int[] intValues) {} // 0x0000000184088E70-0x0000000184088E80
		public HEU_ParameterTupleWrapper(float[] floatValues) {} // 0x000000018646EE40-0x000000018646EE50
		public HEU_ParameterTupleWrapper(string[] stringValues) {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public HEU_ParameterTupleWrapper(HEU_FloatRampPointWrapper[] floatRampValues) {} // 0x00000001864721F0-0x0000000186472200
		public HEU_ParameterTupleWrapper(HEU_ColorRampPointWrapper[] colorRampValues) {} // 0x0000000185A16440-0x0000000185A16450
	}

	public interface IHEU_Parameters // TypeDefIndex: 50696
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
		bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x020641DF */);
		bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x020641E0 */, bool bRecookAsset = false /* Metadata: 0x020641E1 */);
		bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x020641E2 */);
		bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x020641E3 */);
		bool GetFloatParameterValues(string parameterName, out float[] values);
		bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x020641E4 */);
		bool GetColorParameterValue(string parameterName, out UnityEngine.Color value);
		bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x020641E5 */, bool bRecookAsset = false /* Metadata: 0x020641E6 */);
		bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x020641E7 */);
		bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x020641E8 */);
		bool GetIntParameterValues(string parameterName, out int[] values);
		bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x020641E9 */);
		bool GetChoiceParameterValue(string parameterName, out int value);
		bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x020641EA */, bool bRecookAsset = false /* Metadata: 0x020641EB */);
		bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x020641EC */);
		bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x020641ED */, bool bRecookAsset = false /* Metadata: 0x020641EE */);
		bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x020641EF */);
		bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x020641F0 */);
		bool GetStringParameterValues(string parameterName, out string[] values);
		bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x020641F1 */, bool bRecookAsset = false /* Metadata: 0x020641F2 */);
		bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x020641F3 */);
		bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x020641F4 */);
		bool GetAssetRefParameterValues(string parameterName, out GameObject[] values);
		bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x020641F5 */);
		bool GetRampParameterNumPoints(string parameterName, out int numPoints);
		bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x020641F6 */, bool bRecookAsset = false /* Metadata: 0x020641F7 */);
		bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x020641F8 */);
		bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints);
		bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x020641F9 */, bool bRecookAsset = false /* Metadata: 0x020641FA */);
		bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x020641FB */);
		bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints);
		bool TriggerButtonParameter(string parameterName);
		bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecookAsset = false /* Metadata: 0x020641FC */);
		bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples);
	}

	public interface IHEU_PartData // TypeDefIndex: 50697
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
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x020641FD */);
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

	public enum HEU_LinkStateWrapper // TypeDefIndex: 50698
	{
		INACTIVE = 0,
		LINKING = 1,
		LINKED = 2,
		ERROR_NOT_LINKED = 3
	}

	public interface IHEU_PDGAssetLink // TypeDefIndex: 50699
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

	public interface IHEU_VolumeCache // TypeDefIndex: 50700
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

	public class HEU_MaterialData : ScriptableObject, IHEU_MaterialData, IEquivable<HEU_MaterialData> // TypeDefIndex: 50702
	{
		// Fields
		internal Material _material; // 0x18
		internal Source _materialSource; // 0x20
		internal int _materialKey; // 0x24
	
		// Properties
		public Material Material { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public HEU_MaterialSourceWrapper MaterialSource { get => default; } // 0x000000018A939210-0x000000018A93923C 
		public int MaterialKey { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
	
		// Nested types
		internal enum Source // TypeDefIndex: 50701
		{
			DEFAULT = 0,
			HOUDINI = 1,
			UNITY = 2,
			SUBSTANCE = 3
		}
	
		// Constructors
		public HEU_MaterialData() {} // 0x000000018A939200-0x000000018A939210
	
		// Methods
		public bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath) => default; // 0x000000018A938818-0x000000018A938B20
		public bool IsExistingMaterial() => default; // 0x000000018A9387C0-0x000000018A9387D4
		private bool UseLegacyShaders(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath, HEU_SessionBase session, HAPI_NodeInfo nodeInfo, HAPI_ParmInfo[] parmInfos) => default; // 0x000000018A938B20-0x000000018A939200
		internal static string GetTextureFileNameFromMaterialParam(HEU_SessionBase session, int nodeID, HAPI_ParmInfo parmInfo) => default; // 0x000000018A938520-0x000000018A938624
		internal static bool IsTransparentMaterial(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters) => default; // 0x000000018A9387D4-0x000000018A938818
		internal static bool GetMaterialAlpha(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, float defaultValue, out float alpha) {
			alpha = default;
			return default;
		} // 0x000000018A9382AC-0x000000018A938420
		internal static string GetSupportedFileFormat(HEU_SessionBase session, ref HAPI_ImageInfo imageInfo) => default; // 0x000000018A938420-0x000000018A938520
		public bool IsEquivalentTo(HEU_MaterialData other) => default; // 0x000000018A938624-0x000000018A9387C0
		internal static Source MaterialSource_WrapperToInternal(HEU_MaterialSourceWrapper materialSource) => default; // 0x000000018A8F32F8-0x000000018A8F3320
		internal static HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(Source materialSource) => default; // 0x000000018A8F32F8-0x000000018A8F3320
	}

	public class HEU_MaterialFactory // TypeDefIndex: 50703
	{
		// Fields
		public static Material _defaultStandardMaterial; // 0x00
	
		// Constructors
		public HEU_MaterialFactory() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static Shader FindShader(string shaderName) => default; // 0x000000018A93A580-0x000000018A93A5B8
		public static Shader FindPluginShader(string shaderName) => default; // 0x000000018A93A548-0x000000018A93A580
		public static Material GetNewMaterialWithShader(string assetCacheFolderPath, string shaderName, string materialName = "" /* Metadata: 0x02064206 */, bool bWriteToFile = true /* Metadata: 0x02064207 */) => default; // 0x000000018A93A9EC-0x000000018A93ABBC
		public static Material CreateNewHoudiniStandardMaterial(string assetCacheFolderPath, string materialName, bool bWriteToFile) => default; // 0x000000018A9395D8-0x000000018A939624
		public static void WriteMaterialToAssetCache(Material material, string assetCacheFolderPath, string materialName, bool bOverwriteExisting) {} // 0x000000018A93B5B4-0x000000018A93B68C
		public static bool DoesMaterialExistInAssetCache(Material material) => default; // 0x000000018A939938-0x000000018A93995C
		public static void DestroyNonAssetMaterial(Material material, bool bRegisterUndo) {} // 0x000000018A9398C4-0x000000018A939938
		public static void DeleteAssetMaterial(Material material) {} // 0x000000018A9398BC-0x000000018A9398C4
		public static Texture2D RenderAndExtractImageToTexture(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, int textureParmID, string textureName, string assetCacheFolderPath, bool isNormalMap, bool invertTexture = false /* Metadata: 0x02064208 */) => default; // 0x000000018A93B4EC-0x000000018A93B5AC
		private static Texture2D ExtractHoudiniImageToTexturePNGJPEG(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes) => default; // 0x000000018A939A00-0x000000018A93A4E0
		private static Texture2D ExtractHoudiniImageToTextureRaw(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes) => default; // 0x000000018A93A4E0-0x000000018A93A548
		public static Texture2D ExtractHoudiniImageToTextureFile(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes, string assetCacheFolderPath) => default; // 0x000000018A93997C-0x000000018A939A00
		public static Material LoadUnityMaterial(string materialPath) => default; // 0x000000018A93B1E4-0x000000018A93B4D0
		public static Material LoadSubstanceMaterialWithName(string materialPath, string substanceName) => default; // 0x000000018A93AF50-0x000000018A93B0DC
		public static Material LoadSubstanceMaterialWithIndex(string materialPath, int substanceMaterialIndex) => default; // 0x000000018A93AD88-0x000000018A93AF50
		public static int GetUnitySubstanceMaterialKey(string unityMaterialPath, string substanceName, int substanceIndex) => default; // 0x000000018A93AC8C-0x000000018A93AD88
		public static int MaterialNameToKey(string materialName) => default; // 0x0000000185FAD9D0-0x0000000185FAD9F0
		public static void EnableGPUInstancing(Material material) {} // 0x000000018A93995C-0x000000018A93997C
		public static bool MaterialHasGPUInstancingEnabled(Material material) => default; // 0x000000018A93B4D0-0x000000018A93B4EC
		public static Material CopyMaterial(Material material) => default; // 0x000000018A93923C-0x000000018A93929C
		public static Material GetDefaultStandardMaterial() => default; // 0x000000018A93A654-0x000000018A93A704
		public static Texture2D LoadTexture(string path) => default; // 0x000000018A93B0DC-0x000000018A93B1E4
		public static Texture2D WhiteTexture() => default; // 0x000000018A93B5AC-0x000000018A93B5B4
		public static HEU_MaterialData CreateUnitySubstanceMaterialData(int materialKey, string materialPath, string substanceName, int substanceIndex, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018A939624-0x000000018A9398BC
		public static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialSourceWrapper sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018A939470-0x000000018A9394CC
		internal static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialData.Source sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018A9394CC-0x000000018A9395D8
		public static HEU_MaterialData GetOrCreateDefaultMaterialInCache(HEU_SessionBase session, int geoID, int partID, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018A93ABBC-0x000000018A93AC8C
		public static HEU_MaterialData GetMaterialDataFromCache(int materialKey, List<HEU_MaterialData> materialCache) => default; // 0x000000018A93A704-0x000000018A93A820
		public static string GenerateDefaultMaterialName(int geoID, int partID) => default; // 0x000000018A93A5B8-0x000000018A93A654
		public static HEU_MaterialData CreateHoudiniMaterialData(HEU_SessionBase session, int assetID, int materialID, int geoID, int partID, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018A93929C-0x000000018A939470
		public static Dictionary<int, HEU_MaterialData> GetMaterialDataMapFromCache(List<HEU_MaterialData> materialCache) => default; // 0x000000018A93A820-0x000000018A93A9EC
	}

	public class HEU_UnityMaterialInfo // TypeDefIndex: 50704
	{
		// Fields
		public string _unityMaterialPath; // 0x10
		public string _substancePath; // 0x18
		public int _substanceIndex; // 0x20
	
		// Constructors
		public HEU_UnityMaterialInfo() {} // Dummy constructor
		public HEU_UnityMaterialInfo(string unityMaterialPath, string substancePath, int substanceIndex) {} // 0x00000001859D9860-0x00000001859D9890
	}

	public class HEU_SessionBase // TypeDefIndex: 50705
	{
		// Fields
		protected HEU_SessionData _sessionData; // 0x10
		private bool _UserNotifiedSessionInvalid_k__BackingField; // 0x18
		private string _sessionErrorMsg; // 0x20
		private bool _LogErrorOverride_k__BackingField; // 0x28
		private bool _ThrowErrorOverride_k__BackingField; // 0x29
		private HAPI_Result _LastCallResultCode_k__BackingField; // 0x2C
	
		// Properties
		public bool UserNotifiedSessionInvalid { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public SessionConnectionState ConnectionState { get => default; set {} } // 0x000000018A9405F0-0x000000018A940604 0x000000018A940618-0x000000018A940628
		public SessionMode ThisSessionMode { get => default; set {} } // 0x000000018A940604-0x000000018A940618 0x000000018A940628-0x000000018A940638
		public bool LogErrorOverride { get; set; } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
		public bool ThrowErrorOverride { get; set; } // 0x00000001813B34D0-0x00000001813B34E0 0x00000001813B4850-0x00000001813B4860
		public HAPI_Result LastCallResultCode { get; set; } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
	
		// Constructors
		public HEU_SessionBase() {} // 0x0000000185FCE4C0-0x0000000185FCE4D0
	
		// Methods
		public string GetSessionErrorMsg() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public bool IsSessionSync() => default; // 0x000000018A940320-0x000000018A940338
		public virtual HEU_HoudiniAsset GetRegisteredAssetFromID(int id) => default; // 0x00000001813AE580-0x00000001813AE590
		public virtual bool IsAssetRegistered(HEU_HoudiniAsset asset) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual void RegisterAsset(HEU_HoudiniAsset asset) {} // 0x0000000185492010-0x0000000185492020
		public virtual void UnregisterAsset(int id) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ReregisterOnAwake(HEU_HoudiniAsset asset) {} // 0x0000000185492010-0x0000000185492020
		public virtual void SetSessionErrorMsg(string msg, bool bLogError = false /* Metadata: 0x02064209 */) {} // 0x000000018A940580-0x000000018A9405B8
		public virtual void SetSessionConnectionErrorMsg(string introMsg, HAPI_Result result, bool bIsHARSRunning, bool bLogError = false /* Metadata: 0x0206420A */) {} // 0x000000018A9403C4-0x000000018A940580
		public virtual void SetLibraryErrorMsg(bool bLogError = false /* Metadata: 0x0206420B */) {} // 0x000000018A940338-0x000000018A9403C4
		protected virtual bool CreateSessionData(bool bOverwriteExisting, bool bIsDefaultSession) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CreateInProcessSession(bool bIsDefaultSession) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CreateThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x0206420C */, int serverPort = 9090 /* Metadata: 0x02064216 */, bool autoClose = true /* Metadata: 0x0206421A */, float timeout = 100000f /* Metadata: 0x0206421B */, bool bLogError = true /* Metadata: 0x0206421F */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CreateThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x02064220 */, bool autoClose = true /* Metadata: 0x02064225 */, float timeout = 100000f /* Metadata: 0x02064226 */, bool bLogError = true /* Metadata: 0x0206422A */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CreateThriftSharedMemorySession(bool bIsDefaultSession, string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER /* Metadata: 0x0206422B */, int sharedMemoryBufferSize = 100 /* Metadata: 0x0206422C */, bool autoClose = true /* Metadata: 0x0206422E */, float timeout = 100000f /* Metadata: 0x0206422F */, bool bLogError = true /* Metadata: 0x02064233 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CreateCustomSession(bool bIsDefaultSession) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ConnectThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x02064234 */, int serverPort = 9090 /* Metadata: 0x0206423E */, bool autoClose = true /* Metadata: 0x02064242 */, float timeout = 100000f /* Metadata: 0x02064243 */, bool logError = true /* Metadata: 0x02064247 */, bool autoInitialize = true /* Metadata: 0x02064248 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ConnectThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x02064249 */, bool autoClose = true /* Metadata: 0x0206424E */, float timeout = 100000f /* Metadata: 0x0206424F */, bool logError = true /* Metadata: 0x02064253 */, bool autoInitialize = true /* Metadata: 0x02064254 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ConnectThriftSharedMemorySession(bool bIsDefaultSession, string sharedMemoryName = "hapi" /* Metadata: 0x02064255 */, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER /* Metadata: 0x0206425A */, int sharedMemoryBufferSize = 100 /* Metadata: 0x0206425B */, bool autoClose = true /* Metadata: 0x0206425D */, float timeout = 100000f /* Metadata: 0x0206425E */, bool logError = true /* Metadata: 0x02064262 */, bool autoInitialize = true /* Metadata: 0x02064263 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CloseSession() => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected virtual bool CheckAndCloseExistingSession() => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected virtual void ClearSessionInfo() {} // 0x000000018A940158-0x000000018A9401A0
		public void SetSessionData(HEU_SessionData sessionData) {} // 0x0000000184096E30-0x0000000184096EF0
		public HEU_SessionData GetSessionData() => default; // 0x000000018346D130-0x000000018346D140
		public virtual string GetSessionInfo() => default; // 0x000000018A9402C8-0x000000018A9402F4
		public virtual bool IsSessionValid() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RestartSession() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public string GetLastSessionError() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public virtual bool CheckVersionMatch() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool InitializeSession(HEU_SessionData sessionData) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool HandleStatusResult(HAPI_Result result, string prependMsg, bool bThrowError, bool bLogError) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual void SetServerEnvString(string name, string value) {} // 0x0000000185492010-0x0000000185492020
		public virtual bool GetServerEnvString(string name, out string value) {
			value = default;
			return default;
		} // 0x000000018A9402AC-0x000000018A9402C8
		public virtual bool GetServerEnvVarCount(out int env_count) {
			env_count = default;
			return default;
		} // 0x0000000185FCE420-0x0000000185FCE430
		public virtual bool GetCallResult(out HAPI_Result result) {
			result = default;
			return default;
		} // 0x0000000185FCE420-0x0000000185FCE430
		public virtual bool GetCookResult(out HAPI_Result result) {
			result = default;
			return default;
		} // 0x0000000185FCE420-0x0000000185FCE430
		public virtual bool GetCookState(out HAPI_State state) {
			state = default;
			return default;
		} // 0x0000000185FCE420-0x0000000185FCE430
		public virtual string GetStatusString(HAPI_StatusType statusType, HAPI_StatusVerbosity verbosity) => default; // 0x000000018A9402F4-0x000000018A940320
		public virtual string ComposeNodeCookResult(int nodeId, HAPI_StatusVerbosity verbosity) => default; // 0x000000018A9401A0-0x000000018A9401CC
		public virtual int GetEnvInt(HAPI_EnvIntType intType) => default; // 0x00000001813AE580-0x00000001813AE590
		public virtual int GetSessionEnvInt(HAPI_SessionEnvIntType intType, bool bLogError) => default; // 0x00000001813AE580-0x00000001813AE590
		public virtual bool GetString(int stringHandle, ref string resultString, int bufferLength) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual int GetStringBufferLength(int stringHandle) => default; // 0x00000001813AE580-0x00000001813AE590
		public virtual int CheckForSpecificErrors(int nodeID, int errorsToCheck) => default; // 0x00000001813AE580-0x00000001813AE590
		public virtual double GetTime() => default; // 0x0000000183908D00-0x0000000183908D10
		public virtual bool SetTime(double time) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetUseHoudiniTime() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetUseHoudiniTime(bool enable) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool LoadAssetLibraryFromFile(string assetPath, bool bAllowOverwrite, out int libraryID) {
			libraryID = default;
			return default;
		} // 0x0000000185FCE430-0x0000000185FCE440
		public virtual bool LoadAssetLibraryFromMemory(byte[] buffer, bool bAllowOverwrite, out int libraryID) {
			libraryID = default;
			return default;
		} // 0x0000000185FCE430-0x0000000185FCE440
		public virtual bool CreateNode(int parentNodeID, string operatorName, string nodeLabel, bool bCookOnCreation, out int newNodeID) {
			newNodeID = default;
			return default;
		} // 0x0000000185FCE410-0x0000000185FCE420
		public virtual void DeleteNode(int nodeID) {} // 0x0000000185492010-0x0000000185492020
		public virtual bool CookNode(int nodeID, bool bCookTemplatedGeos, bool bSplitGeosByGroup = false /* Metadata: 0x02064264 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CookNodeWithOptions(int nodeID, HAPI_CookOptions cookOptions) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RenameNode(int nodeID, string newName) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ConnectNodeInput(int nodeID, int inputIndex, int nodeIDToConnect, int outputIndex = 0 /* Metadata: 0x02064265 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool DisconnectNodeInput(int nodeID, int inputIndex, bool bLogError) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool QueryNodeInput(int nodeID, int inputIndex, out int connectedNodeID, bool bLogError) {
			connectedNodeID = default;
			return default;
		} // 0x0000000185FCE460-0x0000000185FCE470
		public virtual bool GetNodeInputName(int nodeID, int inputIndex, out int nodeNameIndex) {
			nodeNameIndex = default;
			return default;
		} // 0x0000000185FCE430-0x0000000185FCE440
		public virtual bool GetAvailableAssetCount(int libraryID, out int assetCount) {
			assetCount = default;
			return default;
		} // 0x0000000185FCE390-0x0000000185FCE3A0
		public virtual bool GetAvailableAssets(int libraryID, ref int[] assetNames, int assetCount) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAssetInfo(int nodeID, ref HAPI_AssetInfo assetInfo, bool bLogError = true /* Metadata: 0x02064266 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetNodeInfo(int nodeID, ref HAPI_NodeInfo nodeInfo, bool bLogError = true /* Metadata: 0x02064267 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetNodePath(int nodeID, int relativeNodeID, out string path) {
			path = default;
			return default;
		} // 0x0000000188CF2F80-0x0000000188CF2F9C
		public virtual bool IsNodeValid(int nodeID, int uniqueNodeID) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ComposeChildNodeList(int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, ref int count, bool bLogError = true /* Metadata: 0x02064268 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetComposedChildNodeList(int parentNodeID, int[] childNodeIDs, int count, bool bLogError = true /* Metadata: 0x02064269 */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool LoadHIPFile(string fileName, bool bCookOnLoad) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SaveHIPFile(string fileName, bool bLockNodes) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetObjectInfo(int nodeID, ref HAPI_ObjectInfo objectInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetObjectTransform(int nodeID, int relativeToNodeID, HAPI_RSTOrder rstOrder, ref HAPI_Transform hapiTransform) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetObjectTransform(int nodeID, ref HAPI_TransformEuler hapiTransform) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ComposeObjectList(int nodeID, out int objectCount) {
			objectCount = default;
			return default;
		} // 0x0000000185FCE390-0x0000000185FCE3A0
		public virtual bool GetComposedObjectList(int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length) {
			objectInfos = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetComposedObjectTransforms(int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length) {
			transforms = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetDisplayGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = false /* Metadata: 0x0206426A */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetOutputGeoCount(int nodeID, out int count, bool bLogError = false /* Metadata: 0x0206426B */) {
			count = default;
			return default;
		} // 0x0000000185FCE390-0x0000000185FCE3A0
		public virtual bool GetOutputGeoInfos(int nodeID, ref HAPI_GeoInfo[] geoInfosArray, int count, bool bLogError = false /* Metadata: 0x0206426C */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = true /* Metadata: 0x0206426D */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeInfo(int nodeID, int partID, string name, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeNames(int nodeID, int partID, HAPI_AttributeOwner owner, ref string[] attributeNames, int count) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] dataArray, int start, int length) {
			dataArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out float[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, ref float[] data, int dataLength, ref int[] sizesArray, int start, int sizesLength) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeFloat64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out double[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeUInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out byte[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out sbyte[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out short[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out long[] data, int start, int length) {
			data = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetGroupNames(int nodeID, HAPI_GroupType groupType, ref int[] names, int count) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length) {
			membershipArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetGroupCountOnPackedInstancePart(int nodeID, int partID, out int pointGroupCount, out int primitiveGroupCount) {
			pointGroupCount = default;
			primitiveGroupCount = default;
			return default;
		} // 0x0000000185FCE440-0x0000000185FCE450
		public virtual bool GetGroupNamesOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, ref int[] groupNamesArray, int groupCount) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetGroupMembershipOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length) {
			membershipArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetInstancedPartIds(int nodeID, int partID, out int[] instancedPartsArray, int start, int length) {
			instancedPartsArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetInstancerPartTransforms(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length) {
			transformsArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetInstanceTransformsOnPart(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length) {
			transformsArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetInstancedObjectIds(int nodeID, out int[] instanced_node_id_array, int start, int length) {
			instanced_node_id_array = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length) {
			faceCounts = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length, bool bLogError) {
			faceCounts = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetVertexList(int nodeID, int partID, out int[] vertexList, int start, int length) {
			vertexList = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetBoxInfo(int nodeID, int partID, ref HAPI_BoxInfo boxInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetSphereInfo(int nodeID, int partID, ref HAPI_SphereInfo sphereInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetCurveCounts(int nodeID, int partID, out int[] counts, int start, int length) {
			counts = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetCurveOrders(int nodeID, int partID, out int[] orders, int start, int length) {
			orders = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetCurveKnots(int nodeID, int partID, out float[] knots, int start, int length) {
			knots = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo inputCurveInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetFaceCount(int nodeID, int partID, int[] faceCounts, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetVertexList(int nodeID, int partID, int[] vertexList, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, int[] data, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, sbyte[] data, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, short[] data, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, long[] data, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int dataLength, int[] sizesArray, int start, int sizesLength) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, string[] data, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool AddAttribute(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool AddGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool DeleteGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, out int[] membershipArray, int start, int length) {
			membershipArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool CommitGeo(int nodeID) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RevertGeo(int nodeID) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetCurveCounts(int nodeID, int partID, int[] counts, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetCurveOrders(int nodeID, int partID, int[] orders, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetCurveKnots(int nodeID, int partID, float[] knots, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo curveInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetInputCurvePositions(int nodeID, int partID, float[] positionsArray, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetInputCurvePositionsRotationsScales(int nodeID, int partID, float[] positionsArray, int start, int length, float[] rotationsArray, int rotationsStart, int rotationsLength, float[] scalesArray, int scalesStart, int scalesLength) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetMaterialOnPart(int nodeID, int partID, ref HAPI_MaterialInfo materialInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetMaterialNodeIDsOnFaces(int nodeID, int partID, ref bool bSingleFaceMaterial, out int[] materialNodeIDs, int faceCount) {
			materialNodeIDs = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetMaterialInfo(int materialNodeID, ref HAPI_MaterialInfo materialInfo, bool bLogError = true /* Metadata: 0x0206426E */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RenderTextureToImage(int materialNodeID, int parmID, bool bLogError = true /* Metadata: 0x0206426F */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RenderCOPToImage(int copNodeID) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ExtractImageToMemory(int nodeID, string fileFormat, string imagePlanes, out byte[] buffer) {
			buffer = default;
			return default;
		} // 0x000000018A9401E8-0x000000018A94022C
		public virtual bool GetImagePlanes(int nodeID, out int[] imagePlanes, int numImagePlanes) {
			imagePlanes = default;
			return default;
		} // 0x000000018A94022C-0x000000018A940264
		public virtual bool ExtractImageToFile(int nodeID, string fileFormat, string imagePlanes, string destinationFolderPath, out string destinationFilePath) {
			destinationFilePath = default;
			return default;
		} // 0x000000018A9401CC-0x000000018A9401E8
		public virtual bool GetParams(int nodeID, out HAPI_ParmInfo[] parmInfos, int start, int length) {
			parmInfos = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParmTagName(int nodeID, int parmID, int tagIndex, out int tagName) {
			tagName = default;
			return default;
		} // 0x0000000185FCE450-0x0000000185FCE460
		public virtual bool GetParmTagValue(int nodeID, int parmID, string tagName, out int tagValue) {
			tagValue = default;
			return default;
		} // 0x0000000185FCE450-0x0000000185FCE460
		public virtual bool ParmHasTag(int nodeID, int parmID, string tagName, ref bool hasTag) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParamIntValues(int nodeID, out int[] values, int start, int length) {
			values = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParamIntValue(int nodeID, string parmName, int index, out int value) {
			value = default;
			return default;
		} // 0x0000000185FCE450-0x0000000185FCE460
		public virtual bool GetParamFloatValues(int nodeID, out float[] values, int start, int length) {
			values = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParamFloatValue(int nodeID, string parmName, int index, out float value) {
			value = default;
			return default;
		} // 0x0000000185FCE450-0x0000000185FCE460
		public virtual bool GetParamStringValues(int nodeID, out int[] values, int start, int length) {
			values = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParamStringValue(int nodeID, string parmName, int index, out int value) {
			value = default;
			return default;
		} // 0x0000000185FCE450-0x0000000185FCE460
		public virtual bool GetParamNodeValue(int nodeID, string paramName, out int nodeValue) {
			nodeValue = default;
			return default;
		} // 0x0000000185FCE460-0x0000000185FCE470
		public virtual bool GetParamChoiceValues(int nodeID, out HAPI_ParmChoiceInfo[] values, int start, int length) {
			values = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamIntValues(int nodeID, ref int[] values, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamIntValue(int nodeID, string paramName, int index, int value) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamFloatValues(int nodeID, ref float[] values, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamFloatValue(int nodeID, string paramName, int index, float value) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamStringValue(int nodeID, string strValue, int parmID, int index) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamStringValue(int nodeID, string parmName, string parmValue, int index) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetParamNodeValue(int nodeID, string paramName, int nodeValueID) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool InsertMultiparmInstance(int nodeID, int parmID, int instancePosition) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RemoveMultiParmInstance(int nodeID, int parmID, int instancePosition) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParmWithTag(int nodeID, string tagName, ref int parmID) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RevertParmToDefault(int nodeID, string parm_name, int index) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RevertParmToDefaults(int nodeID, string parm_name) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetParmIDFromName(int nodeID, string parmName, out int parmID) {
			parmID = default;
			return default;
		} // 0x0000000185FCE460-0x0000000185FCE470
		public virtual bool GetParmStringValue(int nodeID, string parmName, int index, bool evaluate, out int value) {
			value = default;
			return default;
		} // 0x0000000185FCE470-0x0000000185FCE480
		public virtual bool CreateInputNode(out int nodeID, string name) {
			nodeID = default;
			return default;
		} // 0x0000000185FCE400-0x0000000185FCE410
		public virtual bool CreateInputCurveNode(out int nodeID, string name) {
			nodeID = default;
			return default;
		} // 0x0000000185FCE400-0x0000000185FCE410
		public virtual bool CreateHeightFieldInput(int parentNodeID, string name, int xSize, int ySize, float voxelSize, HAPI_HeightFieldSampling sampling, out int heightfieldNodeID, out int heightNodeID, out int maskNodeID, out int mergeNodeID) {
			heightfieldNodeID = default;
			heightNodeID = default;
			maskNodeID = default;
			mergeNodeID = default;
			return default;
		} // 0x0000000185FCE3C0-0x0000000185FCE3F0
		public virtual bool CreateHeightfieldInputVolumeNode(int parentNodeID, out int newNodeID, string name, int xSize, int ySize, float voxelSize) {
			newNodeID = default;
			return default;
		} // 0x0000000185FCE3F0-0x0000000185FCE400
		public virtual bool GetPreset(int nodeID, out byte[] presetData) {
			presetData = default;
			return default;
		} // 0x000000018A940264-0x000000018A9402AC
		public virtual bool SetPreset(int nodeID, byte[] presetData) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetHeightFieldData(int nodeID, int partID, float[] valuesArray, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetVolumeTileFloatData(int nodeID, int partID, ref HAPI_VolumeTileInfo tileInfo, float[] valuesArray, int length) => default; // 0x000000018A9405B8-0x000000018A9405F0
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
		} // 0x0000000185FCE480-0x0000000185FCE4C0
		public virtual bool SetHeightFieldData(int nodeID, int partID, string name, float[] valuesArray, int start, int length) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetActiveCacheCount(out int activeCacheCount) {
			activeCacheCount = default;
			return default;
		} // 0x0000000185FCE420-0x0000000185FCE430
		public virtual bool GetActiveCacheNames(out int[] cacheNamesArray, int activeCacheCount) {
			cacheNamesArray = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, out int propertyValue) {
			propertyValue = default;
			return default;
		} // 0x0000000185FCE430-0x0000000185FCE440
		public virtual bool SetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, int propertyValue) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SaveGeoToFile(int nodeID, string fileName) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool LoadGeoFromFile(int nodeID, string file_name) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SaveNodeToFile(int nodeID, string fileName) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool LoadNodeFromFile(string file_name, int parentNodeID, string nodeLabel, bool cook_on_load, out int newNodeID) {
			newNodeID = default;
			return default;
		} // 0x0000000185FCE410-0x0000000185FCE420
		public virtual bool GetGeoSize(int nodeID, string format, out int size) {
			size = default;
			return default;
		} // 0x0000000185FCE430-0x0000000185FCE440
		public virtual bool GetHandleInfo(int nodeID, out HAPI_HandleInfo[] handleInfos, int start, int length) {
			handleInfos = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetHandleBindingInfo(int nodeID, int handleIndex, out HAPI_HandleBindingInfo[] handleBindingInfos, int start, int length) {
			handleBindingInfos = default;
			return default;
		} // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ConvertTransform(ref HAPI_TransformEuler inTransform, HAPI_RSTOrder RSTOrder, HAPI_XYZOrder ROTOrder, out HAPI_TransformEuler outTransform) {
			outTransform = default;
			return default;
		} // 0x0000000185FCE3A0-0x0000000185FCE3C0
		public virtual bool GetTotalCookCount(int nodeID, int nodeTypeFilter, int nodeFlagFilter, bool includeChildren, out int count) {
			count = default;
			return default;
		} // 0x0000000185FCE470-0x0000000185FCE480
		public virtual bool SetSessionSync(bool enable) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetViewport(ref HAPI_Viewport viewport) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetViewport(ref HAPI_Viewport viewport) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool GetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool SetNodeDisplay(int node_id, int onOff) => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	[Serializable]
	public enum SessionConnectionState // TypeDefIndex: 50706
	{
		NOT_CONNECTED = 0,
		CONNECTED = 1,
		FAILED_TO_CONNECT = 2
	}

	[Serializable]
	public enum SessionMode // TypeDefIndex: 50707
	{
		Socket = 0,
		Pipe = 1,
		SharedMemory = 2
	}

	[Serializable]
	public sealed class HEU_SessionData // TypeDefIndex: 50708
	{
		// Fields
		public static long INVALID_SESSION_ID; // 0x00
		public HAPI_Session _HAPISession; // 0x10
		private int _serverProcessID; // 0x20
		private bool _initialized; // 0x24
		private string _pipeName; // 0x28
		private int _port; // 0x30
		private string _sharedMemoryName; // 0x38
		private HAPI_ThriftSharedMemoryBufferType _sharedMemoryBufferType; // 0x40
		private int _sharedMemoryBufferSize; // 0x44
		private string _sessionClassType; // 0x48
		private bool _isDefaultSession; // 0x50
		private HEU_SessionSyncData _sessionSync; // 0x58
		private SessionConnectionState _connectionState; // 0x60
		private SessionMode _sessionMode; // 0x64
	
		// Properties
		public long SessionID { get => default; set {} } // 0x000000018A940788-0x000000018A9407D8 0x0000000181448AC0-0x0000000181448AD0
		public int ProcessID { get => default; set {} } // 0x0000000185FBE2F0-0x0000000185FBE300 0x00000001813B9430-0x00000001813B9440
		public HAPI_SessionType SessionType { get => default; set {} } // 0x00000001813AE580-0x00000001813AE590 0x0000000181378230-0x0000000181378240
		public bool IsInitialized { get => default; set {} } // 0x00000001814A81B0-0x00000001814A81C0 0x0000000185FB0820-0x0000000185FB0830
		public bool IsValidSessionID { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public string PipeName { get => default; set {} } // 0x000000018A9406E4-0x000000018A940710 0x0000000184A4EDC0-0x0000000184A4EDD0
		public int Port { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public string SharedMemoryName { get => default; set {} } // 0x0000000183908D20-0x0000000183909010 0x000000018142E6F0-0x000000018142E750
		public HAPI_ThriftSharedMemoryBufferType SharedMemoryBufferType { get => default; set {} } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public int SharedMemoryBufferSize { get => default; set {} } // 0x0000000183908D10-0x0000000183908D20 0x0000000183909010-0x0000000183909020
		public System.Type SessionClassType { get => default; set {} } // 0x000000018A940710-0x000000018A940788 0x000000018A9407D8-0x000000018A940808
		public bool IsDefaultSession { get => default; set {} } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
		public bool IsSessionSync { get => default; } // 0x0000000187E45764-0x0000000187E45770 
		public SessionConnectionState ThisConnectionMode { get => default; set {} } // 0x000000018143E3B0-0x000000018143E3C0 0x000000018143E3C0-0x000000018143E3D0
		public SessionMode ThisSessionMode { get => default; set {} } // 0x0000000185FB2020-0x0000000185FB2030 0x0000000185FB2030-0x0000000185FB2040
	
		// Constructors
		public HEU_SessionData() {} // 0x0000000185FBD7E0-0x0000000185FBD7F0
		static HEU_SessionData() {} // 0x000000018A9406A8-0x000000018A9406E4
	
		// Methods
		public HEU_SessionSyncData GetOrCreateSessionSync() => default; // 0x000000018A940638-0x000000018A9406A8
		public HEU_SessionSyncData GetSessionSync() => default; // 0x00000001813F1630-0x00000001813F1640
		public void SetSessionSync(HEU_SessionSyncData syncData) {} // 0x0000000186472DB0-0x0000000186472DC0
	}

	public class HEU_SessionHAPI : HEU_SessionBase // TypeDefIndex: 50709
	{
		// Constructors
		public HEU_SessionHAPI() {} // 0x0000000185FCE4C0-0x0000000185FCE4D0
	}

	public static class HEU_SessionManager // TypeDefIndex: 50711
	{
		// Fields
		private static HEU_SessionBase _defaultSession; // 0x00
		private static Dictionary<long, HEU_SessionBase> _sessionMap; // 0x08
		public static CreateSessionFromTypeDelegate _createSessionFromTypeDelegate; // 0x10
	
		// Nested types
		public delegate HEU_SessionBase CreateSessionFromTypeDelegate(System.Type type); // TypeDefIndex: 50710; 0x000000018A940F10-0x000000018A940F54
	
		// Constructors
		static HEU_SessionManager() {} // 0x00000001864750A8-0x00000001864751CC
	
		// Methods
		public static HEU_SessionBase CreateSessionObject() => default; // 0x000000018A94276C-0x000000018A9427E4
		public static HEU_SessionBase CreateSessionFromType(System.Type type) => default; // 0x000000018A941A00-0x000000018A941A80
		public static HEU_SessionBase GetDefaultSession() => default; // 0x000000018A942650-0x000000018A9426F8
		public static void RegisterSession(long sessionID, HEU_SessionBase session) {} // 0x000000018A941E18-0x000000018A942248
		public static void UnregisterSession(long sessionID) {} // 0x000000018A941C90-0x000000018A941D9C
		public static HEU_SessionBase GetSessionWithID(long sessionID) => default; // 0x000000018A9414D0-0x000000018A94195C
		public static void SaveAllSessionData() {} // 0x000000018A940E90-0x000000018A940F10
		public static void LoadAllSessionData() {} // 0x000000018A941018-0x000000018A941098
		private static void InternalValidateSceneAssets() {} // 0x000000018A940F98-0x000000018A941018
		public static HEU_SessionBase GetOrCreateDefaultSession(bool bNotifyUserError = true /* Metadata: 0x02064276 */) => default; // 0x00000001839099E0-0x000000018390A050
		public static bool CreateInProcessSession() => default; // 0x000000018A940E10-0x000000018A940E90
		public static bool CreateThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout, bool logError) => default; // 0x000000018A940D90-0x000000018A940E10
		public static bool CreateThriftPipeSession(string pipeName, bool autoClose, float timeout, bool logError) => default; // 0x000000018A940D10-0x000000018A940D90
		public static bool CreateThriftSharedMemorySession(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout, bool logError) => default; // 0x0000000183909370-0x00000001839099E0
		public static bool CreateCustomSession() => default; // 0x000000018A9424C4-0x000000018A942528
		public static bool ConnectThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout) => default; // 0x000000018A940C94-0x000000018A940D10
		public static bool ConnectThriftPipeSession(string pipeName, bool autoClose, float timeout) => default; // 0x000000018A940C18-0x000000018A940C94
		public static bool ConnectThriftSharedMemorySession(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout) => default; // 0x0000000183909020-0x0000000183909370
		public static void RecreateDefaultSessionData() {} // 0x000000018A941C28-0x000000018A941C90
		public static bool ConnectSessionSyncUsingThriftSocket(string hostName, int serverPort, bool autoClose, float timeout, bool logError) => default; // 0x000000018A940B7C-0x000000018A940C18
		public static bool ConnectSessionSyncUsingThriftPipe(string pipeName, bool autoClose, float timeout, bool logError) => default; // 0x000000018A9408D8-0x000000018A940B7C
		public static bool ConnectSessionSyncUsingThriftSharedMemory(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout, bool logError) => default; // 0x000000018A940808-0x000000018A94089C
		public static bool InitializeDefaultSession() => default; // 0x000000018A94195C-0x000000018A9419A0
		public static bool CloseDefaultSession() => default; // 0x000000018A9419A0-0x000000018A941A00
		public static void CloseAllSessions() {} // 0x000000018A9422BC-0x000000018A94232C
		private static void CheckAndCloseExistingSession() {} // 0x000000018A9425AC-0x000000018A942650
		public static HEU_SessionData GetSessionData() => default; // 0x000000018A9427E4-0x000000018A94282C
		public static string GetSessionInfo() => default; // 0x000000018A9413B8-0x000000018A941410
		public static bool LoadStoredDefaultSession() => default; // 0x000000018A94089C-0x000000018A9408D8
		public static bool RestartSession() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static bool ValidatePluginSession(HEU_SessionBase session = null) => default; // 0x000000018A941260-0x000000018A94128C
		public static string GetLastSessionError() => default; // 0x000000018A941D9C-0x000000018A941E18
		public static bool CheckVersionMatch() => default; // 0x000000018A942248-0x000000018A9422BC
		public static bool ClearConnectionError() => default; // 0x000000018A9426F8-0x000000018A94276C
		public static string GetConnectionError(bool clear) => default; // 0x0000000185779060-0x0000000185779070
		public static bool IsHARSProcessRunning(int processID) => default; // 0x000000018A94232C-0x000000018A9423E0
		public static bool LoadSessionFromHIP(bool bCookNodes, HEU_SessionBase session = null) => default; // 0x000000018A9423E0-0x000000018A9424C4
		public static bool SaveSessionToHIP(bool bLockNodes, HEU_SessionBase session = null) => default; // 0x000000018A94128C-0x000000018A9412D0
		public static string GetHoudiniPathOnMacOS(string houdiniPath) => default; // 0x000000018A941B58-0x000000018A941BC0
		public static bool OpenHoudini(string args) => default; // 0x000000018A941A80-0x000000018A941B58
		public static bool OpenSessionInHoudini(HEU_SessionBase session = null) => default; // 0x000000018A941378-0x000000018A9413B8
		public static HAPI_License GetCurrentLicense(bool bLogError) => default; // 0x000000018A941340-0x000000018A941378
		public static string GetString(int stringHandle, HEU_SessionBase session = null) => default; // 0x000000018A941470-0x000000018A9414D0
		public static string[] GetStringValuesFromStringIndices(int[] strIndices) => default; // 0x000000018A941410-0x000000018A941470
		public static string[] GetGroupNames(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, bool isInstanced) => default; // 0x000000018A941098-0x000000018A9410E4
		public static bool GetGroupMembership(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref int[] membership, bool isInstanced) => default; // 0x000000018A9410E4-0x000000018A9411A0
		public static string GetNodeName(int nodeID, HEU_SessionBase session = null) => default; // 0x000000018A9411A0-0x000000018A941260
		public static bool GetNodeInputName(int nodeID, int inputIndex, out string inputName) {
			inputName = default;
			return default;
		} // 0x000000018A941BC0-0x000000018A941C28
		public static bool GetComposedChildNodeList(HEU_SessionBase session, int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, out int[] childNodeIDs, bool bLogIfError = true /* Metadata: 0x02064277 */) {
			childNodeIDs = default;
			return default;
		} // 0x000000018A94282C-0x000000018A9428C0
		public static bool GetComposedObjectListMemorySafe(HEU_SessionBase session, int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length) {
			objectInfos = default;
			return default;
		} // 0x0000000188FF6620-0x0000000188FF6744
		public static bool GetComposedObjectTransformsMemorySafe(HEU_SessionBase session, int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length) {
			transforms = default;
			return default;
		} // 0x00000001817C2F70-0x00000001817C2F80
		public static string GetUniqueMaterialShopName(int assetID, int materialID) => default; // 0x0000000185A264E0-0x0000000185A26510
	}

	public static class HEU_SessionPDG // TypeDefIndex: 50712
	{
	}

	[Serializable]
	public class HEU_SessionSyncData // TypeDefIndex: 50714
	{
		// Fields
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
		public Status SyncStatus { get => default; set {} } // 0x000000018A942978-0x000000018A942988 0x0000000185FCE4D0-0x0000000185FCE4E0
	
		// Nested types
		public enum Status // TypeDefIndex: 50713
		{
			Stopped = 0,
			Started = 1,
			Connecting = 2,
			Initializing = 3,
			Connected = 4
		}
	
		// Constructors
		public HEU_SessionSyncData() {} // 0x000000018A9428C0-0x000000018A942978
	}

	public class HEU_AssetSync : HEU_BaseSync // TypeDefIndex: 50716
	{
		// Fields
		public AssetSyncCallback _onAssetLoaded; // 0x88
		public string _assetPath; // 0x90
	
		// Nested types
		public delegate void AssetSyncCallback(HEU_AssetSync assetSync); // TypeDefIndex: 50715; 0x000000018A9337E0-0x000000018A9337E8
	
		// Constructors
		public HEU_AssetSync() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void OnEnable() {} // 0x000000018A933850-0x000000018A9338A4
		private new void OnDestroy() {} // 0x000000018A9338A4-0x000000018A93391C
		public void InitializeAsset(HEU_SessionBase session, string assetPath, string nodeName, Transform parent, Vector3 startPosition) {} // 0x000000018A9337E8-0x000000018A933824
		private HEU_ThreadedTaskLoadGeo CreateThreadedTask() => default; // 0x000000018A933824-0x000000018A933850
		public void SetLoadCallback(HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback) {} // 0x000000018A93391C-0x000000018A933924
		protected override void SetupLoadTask(HEU_SessionBase session) {} // 0x0000000187893E40-0x0000000187893F64
		public override void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x00000001833EEC70-0x00000001833EEC80
		public override void Resync() {} // 0x0000000185A264E0-0x0000000185A26510
	}

	public class HEU_SyncedEventData // TypeDefIndex: 50717
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_ThreadedTaskLoadGeo.HEU_LoadData TopNodeData; // 0x18
		public HEU_BaseSync OutputObject; // 0x20
	
		// Constructors
		public HEU_SyncedEventData() {} // Dummy constructor
		public HEU_SyncedEventData(bool bSuccess, HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HEU_BaseSync bOutputObject) {} // 0x000000018A942988-0x000000018A9429B0
	}

	public class HEU_BaseSync : MonoBehaviour // TypeDefIndex: 50718
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
		public Action<HEU_SyncedEventData> OnSynced { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
	
		// Constructors
		public HEU_BaseSync() {} // 0x000000018A938020-0x000000018A9381A8
	
		// Methods
		private void Awake() {} // 0x0000000185492010-0x0000000185492020
		private void OnDestroy() {} // 0x000000018A9337E0-0x000000018A9337E8
		public virtual void DeleteSessionData() {} // 0x000000018A9348D4-0x000000018A9348F8
		public virtual void DestroyGeneratedData() {} // 0x000000018A9348F8-0x000000018A934900
		protected virtual void Initialize() {} // 0x0000000185FCE310-0x0000000185FCE320
		public virtual HEU_SessionBase GetHoudiniSession(bool bCreateIfNotFound) => default; // 0x000000018A93781C-0x000000018A9378C4
		private int GetParentNodeID(HEU_SessionBase session) => default; // 0x000000018A937920-0x000000018A93793C
		public void Log(string msg) {} // 0x000000018A937950-0x000000018A937A14
		public void ClearLog() {} // 0x000000018A934534-0x000000018A934750
		public void Error(string error) {} // 0x000000018A934B40-0x000000018A934B60
		public bool IsLoaded() => default; // 0x000000018A93793C-0x000000018A937950
		public virtual void StartSync() {} // 0x000000018A937E8C-0x000000018A937F50
		protected virtual void SetupLoadTask(HEU_SessionBase session) {} // 0x0000000185492010-0x0000000185492020
		public virtual void StopSync() {} // 0x000000018A937F50-0x000000018A937FAC
		public virtual void Resync() {} // 0x000000018A937C80-0x000000018A937CAC
		public virtual void Bake() {} // 0x000000018A9341FC-0x000000018A934534
		public virtual void Unload() {} // 0x000000018A937FAC-0x000000018A938020
		public virtual void Reset() {} // 0x000000018A937BD4-0x000000018A937C80
		public virtual void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x000000018A937A14-0x000000018A937B18
		public virtual void GenerateObjects(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x000000018A936418-0x000000018A936498
		public virtual void GenerateGeometry(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, int objIndex) {} // 0x000000018A934C10-0x000000018A934D18
		public void OnStopped(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x000000018A937B18-0x000000018A937BD4
		private void GenerateTerrain(int cookNodeId, List<HEU_LoadBufferVolume> terrainBuffers) {} // 0x000000018A936498-0x000000018A93781C
		private void GenerateMesh(int cookNodeId, List<HEU_LoadBufferMesh> meshBuffers) {} // 0x000000018A935E80-0x000000018A936418
		private void GenerateAllInstancers(int cookNodeId, List<HEU_LoadBufferInstancer> instancerBuffers, HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) {} // 0x000000018A934B60-0x000000018A934C10
		private void GenerateInstancer(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap) {} // 0x000000018A934D18-0x000000018A934FB0
		private void GenerateInstancesFromNodeIDs(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap, Transform instanceRootTransform) {} // 0x000000018A9357E8-0x000000018A935E80
		private void GenerateInstancesFromAssetPaths(HEU_LoadBufferInstancer instancerBuffer, Transform instanceRootTransform) {} // 0x000000018A934FB0-0x000000018A9357E8
		private void CreateNewInstanceFromObject(GameObject assetSourceGO, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, string[] instancePrefixes, string instanceName, GameObject collisionSourceGO) {} // 0x000000018A934750-0x000000018A9348D4
		private void ApplyAttributeModifiersOnGameObjectOutput(HEU_SessionBase session, int geoID, int partId, ref GameObject go) {} // 0x000000018A934184-0x000000018A9341FC
		private void DestroyOutputs() {} // 0x000000018A934900-0x000000018A934B40
		private void SetOutputVisiblity(HEU_LoadBufferBase buffer) {} // 0x000000018A937CAC-0x000000018A937E8C
		private string GetOutputCacheDirectory() => default; // 0x000000018A9378C4-0x000000018A937920
		public void SetOutputCacheDirectory(string directory) {} // 0x0000000185F05C80-0x0000000185F05C90
		private void AddGeneratedOutputFilePath(string path) {} // 0x000000018A9340FC-0x000000018A934184
		public virtual void SyncUpdate() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public struct HEU_GenerateOptions // TypeDefIndex: 50719
	{
		// Fields
		public bool _generateUVs; // 0x00
		public bool _generateTangents; // 0x01
		public bool _generateNormals; // 0x02
		public bool _useLODGroups; // 0x03
		public bool _splitPoints; // 0x04
	}

	public class HEU_GeoSync : HEU_BaseSync // TypeDefIndex: 50720
	{
		// Fields
		public string _filePath; // 0x88
	
		// Constructors
		public HEU_GeoSync() {} // 0x000000018A93825C-0x000000018A9382AC
	
		// Methods
		protected override void SetupLoadTask(HEU_SessionBase session) {} // 0x000000018A9381A8-0x000000018A93825C
	}

	public class HEU_NodeSync : HEU_BaseSync // TypeDefIndex: 50721
	{
		// Fields
		public string _nodeSaveFilePath; // 0x88
	
		// Constructors
		public HEU_NodeSync() {} // 0x000000018A93391C-0x000000018A933924
	
		// Methods
		private void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		private new void OnDestroy() {} // 0x000000018A9337E0-0x000000018A9337E8
		public void InitializeFromHoudini(HEU_SessionBase session, int nodeID, string nodeName, string filePath) {} // 0x000000018A93B730-0x000000018A93B7B8
		protected override void SetupLoadTask(HEU_SessionBase session) {} // 0x000000018A93B834-0x000000018A93B8E4
		public bool SaveNodeToFile(string filePath) => default; // 0x000000018A93B7B8-0x000000018A93B834
		public static void CreateNodeSync(HEU_SessionBase session, string opName, string nodeNabel) {} // 0x000000018A93B68C-0x000000018A93B730
		public override void Resync() {} // 0x000000018A933824-0x000000018A933850
		public override void SyncUpdate() {} // 0x000000018A93B8E4-0x000000018A93B928
	}

	public abstract class HEU_Task // TypeDefIndex: 50725
	{
		// Fields
		public TaskStatus _status; // 0x10
		public TaskResult _result; // 0x14
		private Guid _guid; // 0x18
		public TaskCallback _taskCompletedDelegate; // 0x28
	
		// Properties
		public Guid TaskGuid { get; }
	
		// Nested types
		public enum TaskStatus // TypeDefIndex: 50722
		{
			NONE = 0,
			PENDING_START = 1,
			STARTED = 2,
			REQUIRE_UPDATE = 3,
			PENDING_COMPLETE = 4,
			COMPLETED = 5,
			UNUSED = 6
		}
	
		public enum TaskResult // TypeDefIndex: 50723
		{
			NONE = 0,
			SUCCESS = 1,
			FAILED = 2,
			KILLED = 3
		}
	
		public delegate void TaskCallback(HEU_Task task); // TypeDefIndex: 50724; 0x000000018A9432C0-0x000000018A9432E4
	
		// Constructors
		public HEU_Task() {}
	
		// Methods
		public abstract void DoTask(); // 0x0000000187893E40-0x0000000187893F64
		public virtual void UpdateTask() {} // 0x00000001833EEC70-0x00000001833EEC80
		public abstract void KillTask(); // 0x0000000185A264E0-0x0000000185A26510
		public abstract void CompleteTask(TaskResult result); // 0x00000001864BB614-0x00000001864BB734
	}

	public class HEU_AssetTask : HEU_Task // TypeDefIndex: 50727
	{
		// Fields
		public BuildType _buildType; // 0x30
		public HEU_HoudiniAsset _asset; // 0x38
		public string _assetPath; // 0x40
		public Vector3 _position; // 0x48
		public bool _buildResult; // 0x54
		public long _forceSessionID; // 0x58
	
		// Nested types
		public enum BuildType // TypeDefIndex: 50726
		{
			NONE = 0,
			LOAD = 1,
			COOK = 2,
			RELOAD = 3
		}
	
		// Constructors
		public HEU_AssetTask() {} // 0x000000018A93408C-0x000000018A9340FC
	
		// Methods
		public HEU_SessionBase GetTaskSession() => default; // 0x000000018A933EA0-0x000000018A933F30
		public override void DoTask() {} // 0x000000018A933B04-0x000000018A933EA0
		public override void KillTask() {} // 0x000000018A933F30-0x000000018A93408C
		public override void CompleteTask(TaskResult result) {} // 0x000000018A933924-0x000000018A933A80
		private void CookCompletedCallback(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> outputs) {} // 0x000000018A933AA8-0x000000018A933B04
		private void CookCompletedCallback(HEU_CookedEventData cookedEventData) {} // 0x000000018A933A80-0x000000018A933AA8
		private void CookCompletedCallback(HEU_ReloadEventData reloadEventData) {} // 0x000000018A933A80-0x000000018A933AA8
	}

	public class HEU_TaskManager // TypeDefIndex: 50728
	{
		// Fields
		private static List<HEU_Task> _tasks; // 0x00
		private static List<HEU_Task> _pendingAdd; // 0x08
		private static List<HEU_Task> _pendingRemove; // 0x10
	
		// Constructors
		static HEU_TaskManager() {} // 0x000000018A943194-0x000000018A9432C0
		public HEU_TaskManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void Update() {} // 0x0000000185492010-0x0000000185492020
		public static HEU_Task GetTask(Guid taskGuid) => default; // 0x000000018A942DA4-0x000000018A942F1C
		public static void AddTask(HEU_Task task) {} // 0x000000018A942C54-0x000000018A942D4C
		public static void KillTask(HEU_Task task, bool bRemove) {} // 0x000000018A942F6C-0x000000018A94302C
		public static void KillTask(Guid taskGuid, bool bRemove) {} // 0x000000018A94302C-0x000000018A9430A8
		public static void RemoveTask(HEU_Task task) {} // 0x000000018A9430A8-0x000000018A943194
		public static void ExecuteTask(HEU_Task task) {} // 0x000000018A942D70-0x000000018A942DA4
		public static void CompleteTask(HEU_Task task, HEU_Task.TaskResult result) {} // 0x000000018A942D4C-0x000000018A942D70
		private static void InternalCompleteTask(HEU_Task task) {} // 0x000000018A942F1C-0x000000018A942F6C
	}

	public class HEU_LoadBufferBase // TypeDefIndex: 50729
	{
		// Fields
		public int _id; // 0x10
		public string _name; // 0x18
		public bool _bInstanced; // 0x20
		public bool _bInstancer; // 0x21
		public HEU_GeneratedOutput _generatedOutput; // 0x28
	
		// Constructors
		public HEU_LoadBufferBase() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void InitializeBuffer(int id, string name, bool bInstanced, bool bInstancer) {} // 0x000000018A952288-0x000000018A9522B4
	}

	public class HEU_LoadBufferMesh : HEU_LoadBufferBase // TypeDefIndex: 50730
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
		public HEU_LoadBufferMesh() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HEU_LoadBufferVolume : HEU_LoadBufferBase // TypeDefIndex: 50731
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
		public HEU_LoadBufferVolume() {} // 0x000000018A9522EC-0x000000018A952404
	}

	public class HEU_LoadBufferVolumeLayer // TypeDefIndex: 50732
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
		public HEU_LoadBufferVolumeLayer() {} // 0x000000018A9522B4-0x000000018A9522EC
	}

	public class HEU_LoadBufferInstancer : HEU_LoadBufferBase // TypeDefIndex: 50733
	{
		// Fields
		public HAPI_Transform[] _instanceTransforms; // 0x30
		public string[] _instancePrefixes; // 0x38
		public int[] _instanceNodeIDs; // 0x40
		public string[] _assetPaths; // 0x48
		public string[] _collisionAssetPaths; // 0x50
	
		// Constructors
		public HEU_LoadBufferInstancer() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HEU_ThreadedTask // TypeDefIndex: 50734
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
		public string TaskName { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public bool IsComplete { get => default; set {} } // 0x000000018A95723C-0x000000018A9572E8 0x000000018A957440-0x000000018A9574EC
		public bool IsActive { get => default; set {} } // 0x000000018A957190-0x000000018A95723C 0x000000018A957394-0x000000018A957440
		public bool StopRequested { get => default; set {} } // 0x000000018A9572E8-0x000000018A957394 0x000000018A9574EC-0x000000018A957598
		public System.Threading.ThreadPriority Priority { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public bool IsBackground { get => default; set {} } // 0x0000000185FB08C0-0x0000000185FB08D0 0x0000000185FB08D0-0x0000000185FB08E0
	
		// Constructors
		public HEU_ThreadedTask() {} // 0x000000018A95713C-0x000000018A957190
	
		// Methods
		public virtual void Start() {} // 0x000000018A956F54-0x000000018A9570A4
		public virtual void Stop() {} // 0x000000018A9570A4-0x000000018A9570E4
		public virtual void Abort() {} // 0x000000018A956E64-0x000000018A956E94
		public virtual void Reset() {} // 0x000000018A956E94-0x000000018A956F2C
		public virtual void Update() {} // 0x000000018A9570E4-0x000000018A95713C
		protected virtual void DoWork() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnComplete() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnStopped() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void CleanUp() {} // 0x0000000185492010-0x0000000185492020
		private void Run() {} // 0x000000018A956F2C-0x000000018A956F54
	}

	public class HEU_ThreadedTaskLoadGeo : HEU_ThreadedTask // TypeDefIndex: 50741
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
		public enum LoadType // TypeDefIndex: 50735
		{
			FILE = 0,
			NODE = 1,
			ASSET = 2
		}
	
		public class HEU_LoadData // TypeDefIndex: 50737
		{
			// Fields
			public int _cookNodeID; // 0x10
			public LoadStatus _loadStatus; // 0x14
			public StringBuilder _logStr; // 0x18
			public HEU_SessionBase _session; // 0x20
			public List<HEU_LoadObject> _loadedObjects; // 0x28
			public Dictionary<int, HEU_LoadBufferBase> _idBuffersMap; // 0x30
	
			// Nested types
			public enum LoadStatus // TypeDefIndex: 50736
			{
				NONE = 0,
				STARTED = 1,
				SUCCESS = 2,
				ERROR = 3
			}
	
			// Constructors
			public HEU_LoadData() {} // 0x000000018A956CC8-0x000000018A956E10
		}
	
		public class HEU_LoadObject // TypeDefIndex: 50738
		{
			// Fields
			public int _objectNodeID; // 0x10
			public int _displayNodeID; // 0x14
			public List<HEU_LoadBufferVolume> _terrainBuffers; // 0x18
			public List<HEU_LoadBufferMesh> _meshBuffers; // 0x20
			public List<HEU_LoadBufferInstancer> _instancerBuffers; // 0x28
	
			// Constructors
			public HEU_LoadObject() {} // 0x000000018A956C98-0x000000018A956CC8
		}
	
		public enum HEU_LoadCallbackType // TypeDefIndex: 50739
		{
			PRECOOK = 0,
			POSTCOOK = 1
		}
	
		public delegate void HEU_LoadCallback(HEU_SessionBase session, HEU_LoadData loadData, HEU_LoadCallbackType callbackType); // TypeDefIndex: 50740; 0x000000018A956C34-0x000000018A956C68
	
		// Constructors
		public HEU_ThreadedTaskLoadGeo() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		public void SetupLoad(HEU_SessionBase session, HEU_BaseSync ownerSync, LoadType loadType, int cookNodeID, string name, string filePath) {} // 0x000000018A9530E0-0x000000018A95316C
		public void SetupLoadNode(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string name) {} // 0x000000018A956724-0x000000018A956778
		public void SetupLoadFile(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string filePath) {} // 0x000000018A956434-0x000000018A956724
		public void SetupLoadAsset(HEU_SessionBase session, HEU_BaseSync ownerSync, string assetPath, string name) {} // 0x000000018A952BA0-0x000000018A9530E0
		public void SetLoadCallback(HEU_LoadCallback loadCallback) {} // 0x000000018A953350-0x000000018A9534B8
		protected override void DoWork() {} // 0x000000018A953250-0x000000018A953350
		protected virtual bool CookNode(HEU_SessionBase session, int cookNodeID) => default; // 0x000000018A9568F8-0x000000018A95697C
		protected virtual bool LoadObjectBuffers(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo) => default; // 0x000000018A956800-0x000000018A956888
		protected virtual bool LoadNodeBuffer(HEU_SessionBase session, int nodeID, HEU_LoadObject loadObject) => default; // 0x000000018A956888-0x000000018A9568F8
		protected virtual void BuildBufferIDsMap(HEU_LoadData loadData) {} // 0x000000018A6AC070-0x000000018A6AC084
		public virtual bool DoFileLoad() => default; // 0x000000018A9531C4-0x000000018A953250
		public virtual bool DoAssetLoad() => default; // 0x000000018A952A78-0x000000018A952BA0
		private bool QueryParts(int nodeID, ref List<HAPI_PartInfo> meshParts, ref List<HAPI_PartInfo> volumeParts, ref List<HAPI_PartInfo> instancerParts, ref List<HAPI_PartInfo> curveParts, ref List<HAPI_PartInfo> scatterInstancerParts) => default; // 0x000000018A9569B8-0x000000018A956C34
		protected override void OnComplete() {} // 0x000000018A95316C-0x000000018A9531C4
		protected override void OnStopped() {} // 0x000000018A955F84-0x000000018A955FA0
		protected override void CleanUp() {} // 0x000000018A955FA0-0x000000018A955FBC
		private string CreateLogString(HEU_LoadData.LoadStatus status, string logStr) => default; // 0x000000018A95697C-0x000000018A9569B8
		private void AppendLog(HEU_LoadData.LoadStatus status, string logStr) {} // 0x000000018A956E10-0x000000018A956E1C
		private void SetLog(HEU_LoadData.LoadStatus status, string logStr) {} // 0x000000018A9543B8-0x000000018A955F84
		private bool CreateFileNode(out int fileNodeID) {
			fileNodeID = default;
			return default;
		} // 0x000000018A956778-0x000000018A956800
		public virtual int GetCookNodeID() => default; // 0x000000018A9560E4-0x000000018A9561D4
		private int GetDisplayNodeID(int objNodeID) => default; // 0x000000018A9561D4-0x000000018A956324
		private bool SetFileParm(int fileNodeID, string filePath) => default; // 0x000000018A956324-0x000000018A956434
		private void Sleep() {} // 0x000000018A9538F8-0x000000018A953F98
		public bool GenerateTerrainBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> volumeParts, List<HAPI_PartInfo> scatterInstancerParts, out List<HEU_LoadBufferVolume> volumeBuffers) {
			volumeBuffers = default;
			return default;
		} // 0x000000018A953558-0x000000018A9538F8
		private void LoadStringFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref string strValue) {} // 0x000000018A953F98-0x000000018A954270
		private void LoadFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue) {} // 0x000000018A954270-0x000000018A9543B8
		private void LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue) {} // 0x000000018A955FBC-0x000000018A9560D8
		private void LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue) {} // 0x000000018A9560D8-0x000000018A9560E4
		public bool GenerateMeshBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> meshParts, bool bSplitPoints, bool bUseLODGroups, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, HEU_LoadObject loadObject, out List<HEU_LoadBufferMesh> meshBuffers) {
			meshBuffers = default;
			return default;
		} // 0x000000018A956E1C-0x000000018A956E64
		public bool GenerateInstancerBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> instancerParts, out List<HEU_LoadBufferInstancer> instancerBuffers) {
			instancerBuffers = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo) => default; // 0x0000000185492010-0x0000000185492020
		private HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo) => default; // 0x000000018A2DDB2C-0x000000018A2DDC54
		public static HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(int tileIndex, List<HEU_LoadBufferVolume> buffers) => default; // 0x0000000181A578C0-0x0000000181A578E0
		public static string GetValidAssetCacheFolderPath(string name) => default; // 0x000000018A952404-0x000000018A95248C
	}

	public class HEU_ThreadManager // TypeDefIndex: 50742
	{
		// Fields
		private static HEU_ThreadManager _instance; // 0x00
		private List<HEU_ThreadedTask> _tasks; // 0x10
		private List<HEU_ThreadedTask> _pendingAdd; // 0x18
		private List<HEU_ThreadedTask> _pendingRemove; // 0x20
	
		// Properties
		public static HEU_ThreadManager Instance { get => default; } // 0x000000018A952A40-0x000000018A952A78 
	
		// Constructors
		public HEU_ThreadManager() {} // 0x000000018A952964-0x000000018A952A40
	
		// Methods
		private static void CreateInstance() {} // 0x0000000185492010-0x0000000185492020
		~HEU_ThreadManager() {} // 0x000000018A952528-0x000000018A952578
		public void Register() {} // 0x0000000185492010-0x0000000185492020
		public void Unregister() {} // 0x0000000185492010-0x0000000185492020
		public void Update() {} // 0x000000018A952614-0x000000018A952964
		public void AddTask(HEU_ThreadedTask task) {} // 0x000000018A95248C-0x000000018A952528
		public void RemoveTask(HEU_ThreadedTask task) {} // 0x000000018A952578-0x000000018A952614
	}

	public class HEU_CookLogs // TypeDefIndex: 50743
	{
		// Fields
		private static HEU_CookLogs _instance; // 0x00
		private StringBuilder _cookLogs; // 0x10
		private int _currentCookLogCount; // 0x18
		private const int MAX_COOK_LOG_COUNT = 9001; // Metadata: 0x02064296
		private string _lastLogStr; // 0x20
		private bool _uniqueStrOnly; // 0x28
		public const long MaxLogSize = 50000000; // Metadata: 0x0206429A
	
		// Properties
		public static HEU_CookLogs Instance { get => default; } // 0x000000018A943A70-0x000000018A943B00 
	
		// Constructors
		public HEU_CookLogs() {} // 0x000000018A9439E4-0x000000018A943A70
	
		// Methods
		public string GetCookLogString() => default; // 0x0000000189C2B140-0x0000000189C2B164
		public void AppendCookLog(string logStr) {} // 0x000000018A9434C0-0x000000018A9435DC
		public void ClearCookLog() {} // 0x000000018A9435DC-0x000000018A943648
		public string GetCookLogFilePath() => default; // 0x000000018A9436D0-0x000000018A943780
		public void DeleteCookingFile() {} // 0x000000018A943648-0x000000018A9436D0
		public void WriteToLogFile(string logStr, bool checkLastLogStr = true /* Metadata: 0x02064295 */) {} // 0x000000018A943808-0x000000018A9439E4
		public long GetFileSizeOfLogFile() => default; // 0x000000018A943780-0x000000018A943808
	}

	public static class HEU_EditorUtility // TypeDefIndex: 50745
	{
		// Nested types
		public enum HEU_ReplacePrefabOptions // TypeDefIndex: 50744
		{
			Default = 0,
			ConnectToPrefab = 1,
			ReplaceNameBased = 2
		}
	
		// Methods
		public static void MarkSceneDirty() {} // 0x0000000185492010-0x0000000185492020
		public static void SelectObject(GameObject gameObject) {} // 0x0000000185492010-0x0000000185492020
		public static void SelectObjects(GameObject[] gameObjects) {} // 0x0000000185492010-0x0000000185492020
		public static Vector3 GetSelectedObjectsMeanPosition() => default; // 0x0000000186472A7C-0x0000000186472A94
		public static Matrix4x4 GetSelectedObjectsMeanTransform() => default; // 0x000000018A944354-0x000000018A944390
		public static GameObject SaveAsPrefabAsset(string path, GameObject go) => default; // 0x000000018A944664-0x000000018A94469C
		public static bool PrefabIsAddedComponentOverride(Component comp) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static bool IsEditorPlaying() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab, HEU_ReplacePrefabOptions heuOptions) => default; // 0x000000018A94462C-0x000000018A944664
		public static bool IsPrefabInstance(GameObject go) => default; // 0x000000018A944518-0x000000018A944550
		public static bool IsPrefabAsset(GameObject go) => default; // 0x000000018A9444E0-0x000000018A944518
		public static bool IsEditingInPrefabMode(GameObject obj) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static bool IsDisconnectedPrefabInstance(GameObject go) => default; // 0x000000018A944470-0x000000018A9444A8
		public static UnityEngine.Object GetPrefabAsset(GameObject go) => default; // 0x000000018A9442A4-0x000000018A9442DC
		public static string GetPrefabAssetPath(UnityEngine.Object obj) => default; // 0x000000018A94426C-0x000000018A9442A4
		public static void DisconnectPrefabInstance(GameObject instance) {} // 0x000000018A943D38-0x000000018A943D6C
		public static UnityEngine.Object InstantiatePrefab(GameObject prefabOriginal) => default; // 0x000000018A944438-0x000000018A944470
		public static GameObject InstantiateGameObject(GameObject sourceGameObject, Transform parentTransform, bool instantiateInWorldSpace, bool bRegisterUndo) => default; // 0x000000018A9443C8-0x000000018A944438
		public static Component AddComponent<T>(GameObject target, bool bRegisterUndo) => default;
		public static void UndoRecordObject(UnityEngine.Object objectToUndo, string name) {} // 0x0000000185492010-0x0000000185492020
		public static void UndoCollapseCurrentGroup() {} // 0x0000000185492010-0x0000000185492020
		public static UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj) => default; // 0x000000018A943C24-0x000000018A943C5C
		public static bool IsPersistant(UnityEngine.Object obj) => default; // 0x000000018A9444A8-0x000000018A9444E0
		public static string GetUniqueNameForSibling(Transform parentTransform, string name) => default; // 0x000000018A944390-0x000000018A9443C8
		public static void DisplayProgressBar(string title, string info, float progress) {} // 0x000000018A943E34-0x000000018A943E68
		public static void ClearProgressBar() {} // 0x000000018A943BF0-0x000000018A943C24
		public static bool IsEditorNotInPlayModeAndNotGoingToPlayMode() => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		public static bool DisplayDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x020642A2 */) => default; // 0x000000018A943D6C-0x000000018A943DC4
		public static bool DisplayErrorDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x020642A3 */) => default; // 0x000000018A943DC4-0x000000018A943E34
		public static void RevealInFinder(string path) {} // 0x0000000185492010-0x0000000185492020
		public static void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj) {} // 0x0000000185492010-0x0000000185492020
		public static void SetStatic(GameObject go, bool bStatic, bool bIncludeChildren) {} // 0x0000000185492010-0x0000000185492020
		public static void SetIsHidden(GameObject go, bool isHidden, bool bIncludeChildren) {} // 0x0000000185492010-0x0000000185492020
		public static GameObject[] GetSelectedObjects() => default; // 0x00000001813AE580-0x00000001813AE590
		public static HEU_HoudiniAssetRoot[] GetSelectedAssetRoots() => default; // 0x000000018A9442DC-0x000000018A944354
		public static HEU_HoudiniAssetRoot[] GetAllAssetRoots() => default; // 0x000000018A9441C0-0x000000018A944214
		public static void CookSelected() {} // 0x000000018A943D1C-0x000000018A943D38
		public static void CookAll() {} // 0x000000018A943C5C-0x000000018A943C78
		public static void CookAssets(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x000000018A943C78-0x000000018A943D1C
		public static void RebuildSelected() {} // 0x000000018A944610-0x000000018A94462C
		public static void RebuildAll() {} // 0x000000018A944550-0x000000018A94456C
		public static void RebuildAssets(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x000000018A94456C-0x000000018A944610
		public static void BakeAndReplaceSelectedInScene() {} // 0x000000018A943BD4-0x000000018A943BF0
		public static void BakeAndReplaceAllInScene() {} // 0x000000018A943B00-0x000000018A943B1C
		public static void BakeAndReplaceAssets(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x000000018A943B1C-0x000000018A943BD4
		public static void ExportSelectedAssetsToGeoFiles() {} // 0x000000018A9441A4-0x000000018A9441C0
		public static void ExportAllAssetsToGeoFiles() {} // 0x000000018A943EA0-0x000000018A943EBC
		public static void ExportAssetsToGeoFiles(HEU_HoudiniAssetRoot[] rootAssets) {} // 0x000000018A943EBC-0x000000018A9441A4
		public static string EditorSaveFolderPanel(string title, string folder, string defaultName) => default; // 0x000000018A943E68-0x000000018A943EA0
		public static void QuerySelectedMeshTopology() {} // 0x0000000185492010-0x0000000185492020
		public static string GetObjectParentFolder(GameObject parentObject, HashSet<Material> generatedMaterials) => default; // 0x000000018A944240-0x000000018A94426C
		private static string GetObjectParentFolderHelper(int instanceID) => default; // 0x000000018A944214-0x000000018A944240
		public static void RepaintScene() {} // 0x0000000185492010-0x0000000185492020
		public static void SetTextureToNormalMap(string filename) {} // 0x0000000185492010-0x0000000185492020
		public static bool ReleasedMouse() => default; // 0x00000001840A27C0-0x00000001840A27D0
	}

	public static class HEU_Extensions // TypeDefIndex: 50746
	{
		// Methods
		public static List<R> Map<T, R>(IEnumerable<T> self, Func<T, R> selector) => default;
		public static T Reduce<T>(IEnumerable<T> self, Func<T, T, T> func) => default;
		public static List<T> Filter<T>(IEnumerable<T> self, Func<T, bool> predicate) => default;
		public static bool IsValidIndex<T>(List<T> self, int index) => default;
		public static bool IsEquivalentList<T>(List<T> self, List<T> other) => default;
		public static bool ApproximatelyEquals(Quaternion quatA, Quaternion value) => default; // 0x000000018A94469C-0x000000018A9446E8
		public static List<U> ConvertList<T, U>(List<T> self) => default;
		public static List<IEquivable<T>> ConvertListToEquivable<T>(List<T> self) => default;
		public static IEquivable<T>[] ConvertArrayToEquivable<T>(T[] self) => default;
		public static bool ApproximatelyEquals(float self, float other, float epsilon = 0.001f /* Metadata: 0x020642A7 */) => default; // 0x00000001878CA664-0x00000001878CA678
		public static byte[] AsByteArray(string self) => default; // 0x000000018A9446E8-0x000000018A944754
		public static string AsString(byte[] buffer) => default; // 0x000000018A944754-0x000000018A9447B8
		public static Vector3 SwapXAndY(Vector3 self) => default; // 0x0000000185FCE4F0-0x0000000185FCE520
		public static Vector3 SwapXAndZ(Vector3 self) => default; // 0x0000000185FCE520-0x0000000185FCE540
		public static Vector3 SwapYAndZ(Vector3 self) => default; // 0x0000000185FCE540-0x0000000185FCE570
		public static Vector3 DecomposeToPosition(Matrix4x4 self) => default; // 0x000000018A91C2E4-0x000000018A91C330
		public static Quaternion DecomposeToRotation(Matrix4x4 self) => default; // 0x000000018A9447B8-0x000000018A944880
		public static Vector3 DecomposeToScale(Matrix4x4 self) => default; // 0x000000018A944880-0x000000018A944938
	}

	public static class ArrayExtensions // TypeDefIndex: 50747
	{
		// Methods
		public static void Init<T>(T[] array, T defaultValue) {}
		public static void Init<T>(List<T> array, T defaultValue) {}
		public static void CopyToWithResize<T>(T[] srcArray, ref ref T[] destArray) {}
		public static bool IsEquivalentArray<T>(T[] arr, T[] other) => default;
		public static bool IsNull<T>(T[] arr) => default;
	}

	public static class DictionaryExtensions // TypeDefIndex: 50748
	{
		// Methods
		public static void AddOrSet<T, U>(Dictionary<T, U> dict, T key, U value) {}
	}

	public struct TransformData // TypeDefIndex: 50749
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
		} // 0x000000018A95775C-0x000000018A957824
	
		// Methods
		public void CopyTo(Transform other, bool copyParent) {} // 0x000000018A9576B8-0x000000018A95775C
		public void CopyToLocal(Transform other, bool copyParent) {} // 0x000000018A957610-0x000000018A9576B8
	}

	public class HEU_GeneralUtility // TypeDefIndex: 50755
	{
		// Nested types
		public delegate bool GetArray1ArgDel<T>(int arg1, out T[] data, int start, int length); // TypeDefIndex: 50750; 0x00000000-0x00000000
	
		public delegate bool GetArray2ArgDel<ARG2, T>(int arg1, ARG2 arg2, out T[] data, int start, int length); // TypeDefIndex: 50751; 0x00000000-0x00000000
	
		public delegate bool GetArray3ArgDel<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, out T[] data, int start, int length); // TypeDefIndex: 50752; 0x00000000-0x00000000
	
		public delegate bool GetAttributeArrayInputFunc<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, out T[] items, int start, int end); // TypeDefIndex: 50753; 0x000000018A946D90-0x000000018A946E58
	
		public delegate bool SetAttributeArrayFunc<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, int start, int end); // TypeDefIndex: 50754; 0x000000018A91A8C0-0x000000018A91A8D8
	
		// Constructors
		public HEU_GeneralUtility() {}
	
		// Methods
		public static bool GetArray1Arg<T>(int arg1, GetArray1ArgDel<T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		} // 0x000000018A9490FC-0x000000018A949264
		public static bool GetArray2Arg<ARG2, T>(int arg1, ARG2 arg2, GetArray2ArgDel<ARG2, T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		} // 0x000000018A9457BC-0x000000018A94583C
		public static bool GetArray3Arg<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, GetArray3ArgDel<ARG3, ARG2, T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		} // 0x000000018A94583C-0x000000018A945A84
		private static bool GetArray<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, GetArray1ArgDel<T> func1, GetArray2ArgDel<ARG2, T> func2, GetArray3ArgDel<ARG3, ARG2, T> func3, out T[] data, int start, int count, int tupleSize) {
			data = default;
			return default;
		} // 0x000000018A945664-0x000000018A945720
		public static bool SetArray1Arg<T>(int arg1, GetArray1ArgDel<T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		} // 0x000000018A944938-0x000000018A944A4C
		public static bool SetArray2Arg<ARG2, T>(int arg1, ARG2 arg2, GetArray2ArgDel<ARG2, T> func, out T[] data, int start, int count) {
			data = default;
			return default;
		} // 0x000000018A9455A8-0x000000018A945664
		public static bool SetArray<ARG2, T>(int arg1, ARG2 arg2, GetArray1ArgDel<T> func1, GetArray2ArgDel<ARG2, T> func2, out T[] data, int start, int count, int tupleSize) {
			data = default;
			return default;
		} // 0x000000018A9474B0-0x000000018A9476A8
		public static bool DoArrayElementsMatch<T>(T[] array1, T[] array2) => default; // 0x000000018A947248-0x000000018A9474B0
		public static bool DoArrayElementsMatch<T>(T[] array1, int startOffset1, T[] array2, int startOffset2, int length) => default; // 0x000000018A947914-0x000000018A947954
		public static bool GetAttributeArray<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, T[] items, GetAttributeArrayInputFunc<T> getFunc, int count) => default; // 0x000000018A947B6C-0x000000018A947BAC
		public static bool GetAttribute<T>(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref ref T[] data, GetAttributeArrayInputFunc<T> getFunc) => default; // 0x000000018A947798-0x000000018A9478DC
		public static bool GetAttributeStrict<T>(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner attrOwner, string name, ref HAPI_AttributeInfo info, ref ref T[] data, GetAttributeArrayInputFunc<T> getFunc) => default; // 0x000000018A9476A8-0x000000018A947760
		public static void GetAttributeStringDataHelper(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] data) {} // 0x000000018A948020-0x000000018A948028
		public static string[] GetAttributeStringData(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo) => default; // 0x000000018A947760-0x000000018A947798
		public static string[] GetAttributeDataAsString(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo) => default; // 0x000000018A9478DC-0x000000018A947914
		public static bool SetAttributeArray<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc, int count, int start = 0 /* Metadata: 0x020642AB */) => default;
		public static bool SetAttribute<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc) => default; // 0x000000018A945DB8-0x000000018A945E94
		public static bool CheckAttributeExists(HEU_SessionBase session, int geoID, int partID, string attribName, HAPI_AttributeOwner attribOwner) => default; // 0x000000018A945F90-0x000000018A94601C
		public static bool GetAttributeInfo(HEU_SessionBase session, int geoID, int partID, string attribName, ref HAPI_AttributeInfo attribInfo) => default; // 0x000000018A946480-0x000000018A9465C4
		public static bool HasValidInstanceAttribute(HEU_SessionBase session, int geoID, int partID, string attribName) => default;
		public static void UpdateGeneratedAttributeStore(HEU_SessionBase session, int geoID, int partID, GameObject go) {} // 0x000000018A946204-0x000000018A946238
		public static HEU_OutputAttribute CreateOutputAttributeHelper(string attrName, ref HAPI_AttributeInfo attrInfo) => default; // 0x000000018A945CEC-0x000000018A945CF8
		public static HEU_OutputAttribute CreateOutputAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo) => default; // 0x000000018A945BE0-0x000000018A945CEC
		public static void CopyWorldTransformValues(Transform src, Transform dest) {} // 0x000000018A946238-0x000000018A9463A4
		public static void ApplyTransformTo(Transform src, Transform target) {} // 0x000000018A947954-0x000000018A947A94
		public static void CopyLocalTransformValues(Transform src, Transform dest) {} // 0x000000018A948C9C-0x000000018A948DD8
		public static List<GameObject> GetChildGameObjects(GameObject parentGO) => default; // 0x000000018A94601C-0x000000018A946204
		public static List<GameObject> GetChildGameObjectsWithNamePattern(GameObject parentGO, string pattern, bool bExclude) => default; // 0x000000018A945E94-0x000000018A945F90
		public static List<GameObject> GetInstanceChildObjects(GameObject parentGO) => default; // 0x000000018A9463A4-0x000000018A946480
		public static List<GameObject> GetNonInstanceChildObjects(GameObject parentGO) => default; // 0x000000018A948BEC-0x000000018A948C9C
		public static GameObject GetGameObjectByName(List<GameObject> goList, string name) => default; // 0x000000018A948A84-0x000000018A948B3C
		public static GameObject GetGameObjectByNameInProjectOnly(string name) => default; // 0x000000018A948B3C-0x000000018A948BEC
		public static bool IsGameObjectInProject(GameObject go) => default; // 0x000000018A9489CC-0x000000018A948A84
		public static GameObject GetGameObjectByNameInScene(string name) => default; // 0x000000018A9451E0-0x000000018A94537C
		public static HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(string name) => default; // 0x000000018A949004-0x000000018A9490FC
		public static T GetOrCreateComponent<T>(GameObject gameObject)
			where T : Component => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static void DestroyGeneratedComponents(GameObject gameObject) {} // 0x000000018A948DD8-0x000000018A948E9C
		public static void DestroyGeneratedMeshComponents(GameObject gameObject) {} // 0x000000018A948F40-0x000000018A949004
		public static void DestroyTerrainComponents(GameObject gameObject) {} // 0x000000018A9454AC-0x000000018A94551C
		public static void DestroyComponent<T>(GameObject gameObject)
			where T : Component {} // 0x000000018A9480FC-0x000000018A94816C
		public static void DestroyImmediate(UnityEngine.Object obj, bool bAllowDestroyingAssets = false /* Metadata: 0x020642AC */, bool bRegisterUndo = false /* Metadata: 0x020642AD */) {} // 0x000000018A9480B0-0x000000018A9480FC
		public static void DestroyBakedGameObjects(List<GameObject> gameObjectsToDestroy) {} // 0x000000018A947EC0-0x000000018A947EF8
		public static void DestroyBakedGameObjectsWithEndName(List<GameObject> gameObjectsToDestroy, string endName) {} // 0x000000018A944B68-0x000000018A944C6C
		public static void DestroyLODGroup(GameObject targetGO, bool bDontDeletePersistantResources) {} // 0x000000018A944A4C-0x000000018A944B68
		public static List<Transform> GetLODTransforms(GameObject targetGO) => default; // 0x000000018A948480-0x000000018A948578
		public static void SetLODTransformValues(GameObject targetGO, List<HoudiniEngineUnity.TransformData> transformData) {} // 0x000000018A947EF8-0x000000018A947FD0
		public static void DestroyGeneratedMeshMaterialsLODGroups(GameObject targetGO, bool bDontDeletePersistantResources) {} // 0x000000018A947144-0x000000018A947248
		public static void DestroyGeneratedMaterial(Material material) {} // 0x000000018A946E58-0x000000018A947144
		public static void DestroyMeshCollider(MeshCollider meshCollider, bool bDontDeletePersistantResources) {} // 0x000000018A946B60-0x000000018A946C40
		public static void SetGameObjectRenderVisiblity(GameObject gameObject, bool bVisible) {} // 0x000000018A946C60-0x000000018A946D40
		public static void SetGameObjectChildrenRenderVisibility(GameObject gameObject, bool bVisible) {} // 0x000000018A946A10-0x000000018A946AE4
		public static void SetGameObjectColliderState(GameObject gameObject, bool bEnabled) {} // 0x000000018A947FD0-0x000000018A947FF4
		public static void SetGameObjectChildrenColliderState(GameObject gameObject, bool bVisible) {} // 0x000000018A944C6C-0x000000018A945188
		public static string ColorToString(UnityEngine.Color c) => default; // 0x000000018A948028-0x000000018A9480B0
		public static UnityEngine.Color StringToColor(string colorString) => default; // 0x000000018A9465C4-0x000000018A946A10
		public static bool DoesUnityTagExist(string tagName) => default; // 0x0000000185492010-0x0000000185492020
		public static void SetLayer(GameObject rootGO, int layer, bool bIncludeChildren) {} // 0x000000018A94816C-0x000000018A948318
		public static void SetTag(GameObject rootGO, string tag, bool bIncludeChildren) {} // 0x000000018A948578-0x000000018A948678
		public static void CopyFlags(GameObject srcGO, GameObject dstGO, bool bIncludeChildren) {} // 0x000000018A948934-0x000000018A9489CC
		public static bool IsMouseWithinSceneView(Camera camera, Vector2 mousePosition) => default; // 0x000000018A948E9C-0x000000018A948F40
		public static bool IsMouseOverRect(Camera camera, Vector2 mousePosition, ref Rect rect) => default; // 0x000000018A94551C-0x000000018A9455A8
		public static System.Type GetSystemTypeByName(string typeName) => default; // 0x000000018A947A94-0x000000018A947B6C
		public static void AssignUnityTag(HEU_SessionBase session, int geoID, int partID, GameObject gameObject) {} // 0x000000018A948808-0x000000018A948934
		public static void AssignUnityLayer(HEU_SessionBase session, int geoID, int partID, GameObject gameObject) {} // 0x000000018A9486E8-0x000000018A948808
		public static void MakeStaticIfHasAttribute(HEU_SessionBase session, int geoID, int partID, GameObject gameObject) {} // 0x000000018A945188-0x000000018A9451E0
		public static string GetUnityScriptAttributeValue(HEU_SessionBase session, int geoID, int partID) => default; // 0x0000000185FCE570-0x0000000185FCE5A0
		public static string GetAttributeStringValueSingle(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner) => default; // 0x000000018A948318-0x000000018A948480
		public static string GetAttributeStringValueSingleStrict(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner) => default; // 0x000000018A947E64-0x000000018A947EC0
		public static bool GetAttributeFloatSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out float value) {
			value = default;
			return default;
		} // 0x000000018A947BAC-0x000000018A947E64
		public static bool GetAttributeIntSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out int value) {
			value = default;
			return default;
		} // 0x000000018A94537C-0x000000018A9454AC
		public static bool GetAttributeColorSingle(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color value) => default; // 0x000000018A945CF8-0x000000018A945DB8
		public static bool HasAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner) => default; // 0x000000018A945A84-0x000000018A945BE0
		public static void AttachScriptWithInvokeFunction(string scriptSet, GameObject gameObject) {} // 0x000000018A945720-0x000000018A9457BC
		public static bool IsInCameraView(Camera camera, Vector3 point) => default; // 0x000000018A948678-0x000000018A9486E8
		internal static List<HEU_Handle> FindOrGenerateHandles(HEU_SessionBase session, ref HAPI_AssetInfo assetInfo, int assetID, string assetName, HEU_Parameters parameters, List<HEU_Handle> currentHandles) => default; // 0x0000000185492010-0x0000000185492020
		public static void CopyComponents(GameObject srcGO, GameObject destGO) {}
		public static Texture LoadTextureFromFile(string filePath) => default;
		public static Texture2D MakeTexture(int width, int height, UnityEngine.Color color) => default;
		public static string ReplaceFirstOccurrence(string srcStr, string searchStr, string replaceStr) => default;
		public static void SetParentWithCleanTransform(Transform parentTransform, Transform childTransform) {}
		public static void CopyHAPITransform(ref HAPI_Transform src, ref HAPI_Transform dest) {}
		public static string GetMaterialAttributeValueFromPart(HEU_SessionBase session, int geoID, int partID) => default;
		public static void ReplaceColliderMeshFromMeshFilter(GameObject targetGO, GameObject sourceColliderGO) {}
		public static void ReplaceColliderMeshFromMeshCollider(GameObject targetGO, GameObject sourceColliderGO) {}
		public static float BiLerpf(float p00, float p10, float p01, float p11, float fracX, float fracY) => default;
		public static float Fractionalf(float value) => default;
		public static string LongestCommonPrefix(List<string> list) => default;
		public static string GetRawOperatorName(string assetOpName) => default;
		public static GameObject GetPrefabFromPath(string path) => default;
		public static void ComposeNChildren(GameObject parent, int n, ref List<GameObject> childGameObjects, bool destroyIfExists = false /* Metadata: 0x020642AE */) {}
		private static void DestroyChildWithName(Transform parent, string name) {}
		public static void DestroyAutoGeneratedChildren(GameObject parent) {}
		public static GameObject CreateNewGameObject(string name = "" /* Metadata: 0x020642AF */) => default;
		public static void RenameGameObject(GameObject obj, string name) {}
	}

	public class ReverseCompare : System.Collections.IComparer // TypeDefIndex: 50756
	{
		// Constructors
		public ReverseCompare() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public int Compare(object x, object y) => default; // 0x000000018A957598-0x000000018A957610
	}

	public class HEU_GenerateGeoCache // TypeDefIndex: 50760
	{
		// Fields
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
		public HEU_MeshIndexFormat _meshIndexFormat; // 0x2B0
	
		// Properties
		public int GeoID { get => default; } // 0x000000018390A050-0x000000018390B170 
		public int PartID { get => default; } // 0x000000018A95120C-0x000000018A9515C8 
		public int AssetID { get; set; } // 0x000000018A9507C0-0x000000018A950A38 0x000000018A949B84-0x000000018A949C90
	
		// Nested types
		public class HEU_ColliderInfo // TypeDefIndex: 50758
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
			public enum ColliderType // TypeDefIndex: 50757
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
			public HEU_ColliderInfo() {} // 0x00000001813AE570-0x00000001813AE580
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 50759
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Material> __9__64_0; // 0x08
			public static Comparison<float> __9__66_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001813E5E30-0x00000001813E5E40
			public __c() {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
	
			// Methods
			internal bool _GetFinalMaterialsFromComparingNewWithPrevious_b__64_0(Material material) => default; // 0x0000000181378230-0x0000000181378240
			internal int _GenerateLODMeshesFromGeoGroups_b__66_0(float a, float b) => default; // 0x000000018A950A38-0x000000018A950AF0
		}
	
		// Constructors
		public HEU_GenerateGeoCache() {} // 0x000000018390FF10-0x000000018390FF50
	
		// Methods
		public static HEU_GenerateGeoCache GetPopulatedGeoCache(HEU_SessionBase session, int assetID, int geoID, int partID, bool bUseLODGroups, List<HEU_MaterialData> materialCache, string assetCacheFolderPath) => default; // 0x000000018A950E74-0x000000018A95120C
		public void GetStringAttributes(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] stringIndices, ref List<string> stringTable) {} // 0x000000018A950D94-0x000000018A950E74
		public void PopulateUnityMaterialData(HEU_SessionBase session) {} // 0x000000018A951EDC-0x000000018A95201C
		public static int GetMaterialKeyFromAttributeIndex(HEU_GenerateGeoCache geoCache, int attributeIndex, out string unityMaterialName, out string substanceName, out int substanceIndex) {
			unityMaterialName = default;
			substanceName = default;
			substanceIndex = default;
			return default;
		} // 0x000000018A951888-0x000000018A951EDC
		public static void CreateMaterialInfoEntryFromAttributeIndex(HEU_GenerateGeoCache geoCache, int materialAttributeIndex) {} // 0x000000018A950484-0x000000018A9507C0
		public bool PopulateGeometryData(HEU_SessionBase session, bool bUseLODGroups) => default; // 0x000000018A950274-0x000000018A950484
		public static void ParseLODTransitionAttribute(HEU_SessionBase session, int geoID, int partID, ref float[] LODTransitionValues) {} // 0x000000018A94E00C-0x000000018A94EA04
		public static void UpdateColliders(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData) {} // 0x000000018A94EA04-0x000000018A950274
		public static void UpdateCollider(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData, HEU_ColliderInfo colliderInfo) {} // 0x000000018A94960C-0x000000018A949B84
		private static void GetFinalMaterialsFromComparingNewWithPrevious(GameObject gameObject, Material[] previousMaterials, Material[] newMaterials, ref Material[] finalMaterials) {} // 0x000000018A949398-0x000000018A94960C
		public static bool GenerateMeshFromSingleGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced) => default; // 0x000000018A949C90-0x000000018A949F20
		public static bool GenerateLODMeshesFromGeoGroups(HEU_SessionBase session, List<HEU_GeoGroup> GeoGroupMeshes, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced) => default; // 0x000000018A9515C8-0x000000018A951888
		public static bool GenerateMeshFromGeoGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced, out Mesh newMesh, out Material[] newMaterials) {
			newMesh = default;
			newMaterials = default;
			return default;
		} // 0x000000018A94BB38-0x000000018A94E00C
		public static Mesh CombineQuadMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> subMeshIndices, bool bGenerateNormals) => default; // 0x000000018A949F20-0x000000018A94BB38
		public static Mesh CombineMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> submeshIndices, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat) => default; // 0x000000018A950AF0-0x000000018A950D94
		public static Mesh CreateMeshFromMeshData(HEU_MeshData submesh, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat) => default; // 0x000000018A949264-0x000000018A949398
		public static void TransferRegularAttributesToVertices(int[] groupVertexList, int[] allFaceCounts, List<int> groupFaces, List<int> groupVertexOffset, ref HAPI_AttributeInfo attribInfo, float[] inData, ref float[] outData) {} // 0x000000018A95201C-0x000000018A952288
		public static bool GenerateGeoGroupUsingGeoCacheVertices(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey) {
			LODGroupMeshes = default;
			defaultMaterialKey = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public static bool GenerateGeoGroupUsingGeoCachePoints(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey) {
			LODGroupMeshes = default;
			defaultMaterialKey = default;
			return default;
		} // 0x000000018A9671A4-0x000000018A967208
		private static void GetSubmeshIDForFace(HEU_GenerateGeoCache geoCache, int faceMaterialID, int groupFace, int vertexFaceIndex, int[] groupVertexList, int defaultMaterialKey, ref int submeshID, ref int singleFaceUnityMaterialKey, ref int singleFaceHoudiniMaterialKey) {} // 0x0000000185492010-0x0000000185492020
		public static MeshTopology CalculateGroupMeshTopology(List<int> groupFaces, int[] allFaceCounts) => default; // 0x000000018390FF50-0x0000000183910FA0
	}

	public class HEU_GeoGroup : IComparable<HEU_GeoGroup> // TypeDefIndex: 50761
	{
		// Fields
		public string _groupName; // 0x10
		public Dictionary<int, HEU_MeshData> _subMeshesMap; // 0x18
		public List<HEU_VertexEntry>[] _sharedNormalIndices; // 0x20
	
		// Constructors
		public HEU_GeoGroup() {} // 0x000000018A957950-0x000000018A9579C8
	
		// Methods
		public int CompareTo(HEU_GeoGroup other) => default; // 0x000000018A957824-0x000000018A95785C
		public void SetupNormalIndices(int indicesCount) {} // 0x000000018A95785C-0x000000018A957950
	}

	public class HEU_VertexEntry // TypeDefIndex: 50762
	{
		// Fields
		public int _meshKey; // 0x10
		public int _vertexIndex; // 0x14
		public int _normalIndex; // 0x18
	
		// Constructors
		public HEU_VertexEntry() {} // Dummy constructor
		public HEU_VertexEntry(int meshKey, int vertexIndex, int normalIndex) {} // 0x0000000185FB25C0-0x0000000185FB25D0
	}

	public static class HEU_GeometryUtility // TypeDefIndex: 50763
	{
		// Methods
		public static Vector2[] GeneratePerTriangle(Mesh meshSrc) => default; // 0x000000018A958F00-0x000000018A958F38
		public static void GenerateSecondaryUVSet(Mesh meshsrc) {} // 0x000000018A958F38-0x000000018A958F6C
		public static void CalculateMeshTangents(Mesh mesh) {} // 0x000000018A9579C8-0x000000018A95816C
		public static Mesh GenerateCubeMeshFromPoints(Vector3[] points, UnityEngine.Color[] pointsColor, float size = 1f /* Metadata: 0x020642B7 */) => default; // 0x000000018A95816C-0x000000018A958F00
		public static string GetInstanceOutputName(string partName, string[] userPrefix, int index) => default; // 0x000000018A958F6C-0x000000018A95901C
	}

	public class HEU_InputData // TypeDefIndex: 50764
	{
		// Fields
		public GameObject _inputObject; // 0x10
	
		// Constructors
		public HEU_InputData() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class HEU_InputInterface // TypeDefIndex: 50765
	{
		// Fields
		public const int DEFAULT_PRIORITY = 100; // Metadata: 0x020642BB
		protected int _priority; // 0x10
	
		// Properties
		public int Priority { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		protected HEU_InputInterface() {} // Dummy constructor
		public HEU_InputInterface(int priority) {} // 0x0000000181378230-0x0000000181378240
	
		// Methods
		public void RegisterInterface() {} // 0x000000018A95E904-0x000000018A95E950
		public abstract bool IsThisInputObjectSupported(GameObject inputObject);
		public abstract bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID);
	}

	[Serializable]
	public class HEU_InputInterfaceMeshSettings // TypeDefIndex: 50766
	{
		// Fields
		private bool _exportColliders; // 0x10
	
		// Properties
		public bool ExportColliders { get => default; set {} } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public HEU_InputInterfaceMeshSettings() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HEU_InputInterfaceMesh : HEU_InputInterface // TypeDefIndex: 50771
	{
		// Fields
		private HEU_InputInterfaceMeshSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataMeshes : HEU_InputData // TypeDefIndex: 50767
		{
			// Fields
			public List<HEU_InputDataMesh> _inputMeshes; // 0x18
			public bool _hasLOD; // 0x20
	
			// Constructors
			public HEU_InputDataMeshes() {} // 0x000000018390FF00-0x000000018390FF10
		}
	
		public enum HEU_InputColliderType // TypeDefIndex: 50768
		{
			NONE = 0,
			BOX = 1,
			SPHERE = 2,
			CAPSULE = 3,
			MESH = 4
		}
	
		public class HEU_InputDataCollider // TypeDefIndex: 50769
		{
			// Fields
			public Collider _collider; // 0x10
			public HEU_InputColliderType _colliderType; // 0x18
	
			// Constructors
			public HEU_InputDataCollider() {} // 0x0000000184088E70-0x0000000184088E80
		}
	
		public class HEU_InputDataMesh // TypeDefIndex: 50770
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
			public HEU_InputDataMesh() {} // 0x000000018A959168-0x000000018A9592A8
		}
	
		// Constructors
		private HEU_InputInterfaceMesh() {} // 0x000000018A959CDC-0x000000018A959DF8
	
		// Methods
		public void Initialize(HEU_InputInterfaceMeshSettings settings) {} // 0x000000018A959C58-0x000000018A959CDC
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A95AABC-0x000000018A95BEE4
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x000000018A95A588-0x000000018A95AABC
		public static void GetUVsFromMesh(Mesh mesh, Vector2[] srcUVs, List<Vector3> destUVs, int index) {} // 0x000000018A959DF8-0x000000018A959F6C
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData) => default; // 0x000000018A95C1C8-0x000000018A95C340
		internal bool UploadColliderData(HEU_SessionBase session, int mergeNodeID, HEU_InputDataMeshes inputData, int parentNodeId) => default; // 0x000000018A959F6C-0x000000018A95A588
		internal bool UploadBoxColliderData(HEU_SessionBase session, BoxCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A95BEE4-0x000000018A95C1C8
		internal bool UploadSphereColliderData(HEU_SessionBase session, SphereCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A959A68-0x000000018A959B58
		internal bool UploadCapsuleColliderData(HEU_SessionBase session, CapsuleCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A9590F4-0x000000018A959168
		internal bool UploadMeshColliderData(HEU_SessionBase session, MeshCollider collider, int inputIndex, int parentNodeID, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A959790-0x000000018A959A68
		internal string GetColliderGroupBaseName(Collider collider, bool bIsConvex = false /* Metadata: 0x020642BD */, bool bIsSimple = false /* Metadata: 0x020642BE */, bool bIsRendered = false /* Metadata: 0x020642BF */) => default; // 0x000000018A9592A8-0x000000018A959790
		internal bool CreateInputNodeForCollider(HEU_SessionBase session, out int outNodeID, int parentNodeId, int colliderIndex, string colliderName, float[] colliderVertices, int[] colliderIndices) {
			outNodeID = default;
			return default;
		} // 0x000000018A959B58-0x000000018A959C58
		public HEU_InputDataMeshes GenerateMeshDatasFromGameObject(GameObject inputObject, bool bExportColliders = false /* Metadata: 0x020642C0 */) => default; // 0x000000018A95901C-0x000000018A959094
		public static HEU_InputDataMesh CreateSingleMeshData(GameObject meshGameObject, bool bExportColliders) => default; // 0x0000000185492010-0x0000000185492020
		private static Mesh GetMeshFromObject(GameObject meshGameObject) => default; // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_InputInterfaceSplineSettings // TypeDefIndex: 50772
	{
		// Fields
		private float _samplingResolution; // 0x10
	
		// Properties
		public float SamplingResolution { get => default; set {} } // 0x0000000181DCCCE0-0x0000000181DCCCF0 0x0000000181A6E380-0x0000000181A6E390
	
		// Constructors
		public HEU_InputInterfaceSplineSettings() {} // 0x000000018390B790-0x000000018390B7A0
	}

	public class HEU_InputInterfaceSpline : HEU_InputInterface // TypeDefIndex: 50775
	{
		// Fields
		private HEU_InputInterfaceSplineSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataSpline // TypeDefIndex: 50773
		{
			// Fields
			public Spline _spline; // 0x10
			public bool _closed; // 0x18
			public int _count; // 0x1C
			public float _length; // 0x20
			public BezierKnot[] _knots; // 0x28
	
			// Constructors
			public HEU_InputDataSpline() {} // 0x000000018390FF00-0x000000018390FF10
		}
	
		public class HEU_InputDataSplineContainer : HEU_InputData // TypeDefIndex: 50774
		{
			// Fields
			public List<HEU_InputDataSpline> _inputSplines; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataSplineContainer() {} // 0x000000018390E8B0-0x000000018390EC20
		}
	
		// Constructors
		private HEU_InputInterfaceSpline() {} // 0x000000018390EC20-0x000000018390F7B0
	
		// Methods
		public void Initialize(HEU_InputInterfaceSplineSettings settings) {} // 0x000000018390B7A0-0x000000018390D1A0
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x000000018390D1A0-0x000000018390E8B0
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018390F7B0-0x000000018390FF00
		public HEU_InputDataSplineContainer GenerateSplineDataFromGameObject(GameObject inputObject) => default; // 0x0000000185492010-0x0000000185492020
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputDataSpline inputSpline, Matrix4x4 localToWorld) => default; // 0x000000018390B170-0x000000018390B790
	}

	public class HEU_InputInterfaceTerrain : HEU_InputInterface // TypeDefIndex: 50777
	{
		// Nested types
		public class HEU_InputDataTerrain : HEU_InputData // TypeDefIndex: 50776
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
			public HEU_InputDataTerrain() {} // 0x000000018390FF00-0x000000018390FF10
		}
	
		// Constructors
		public HEU_InputInterfaceTerrain() {} // 0x000000018A95C3B8-0x000000018A95C534
	
		// Methods
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A95CA04-0x000000018A95CB08
		private bool SetMaskLayer(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo) => default; // 0x000000018A95C904-0x000000018A95C99C
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x000000018A95C340-0x000000018A95C3B8
		public bool CreateHeightFieldInputNode(HEU_SessionBase session, HEU_InputDataTerrain idt) => default; // 0x000000018A95D248-0x000000018A95D334
		public bool UploadHeightValuesWithTransform(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo volumeInfo) => default; // 0x000000018A95CD54-0x000000018A95D248
		public bool UploadAlphaMaps(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo, out bool bMaskSet) {
			bMaskSet = default;
			return default;
		} // 0x000000018A95C99C-0x000000018A95CA04
		public bool SetHeightFieldData(HEU_SessionBase session, int volumeNodeID, int partID, float[] heightValues, string heightFieldName, ref HAPI_VolumeInfo baseVolumeInfo) => default; // 0x000000018A95CB08-0x000000018A95CB8C
		public bool SetTerrainDataAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData) => default; // 0x000000018A95CB8C-0x000000018A95CC10
		public bool SetTerrainLayerAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainLayer terrainLayer) => default; // 0x000000018A95CC30-0x000000018A95CD54
		public void SetTreePrototypes(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData) {} // 0x000000018A95CC10-0x000000018A95CC30
		public void SetTreeInstances(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData) {} // 0x000000018A95C534-0x000000018A95C904
		public HEU_InputDataTerrain GenerateTerrainDataFromGameObject(GameObject inputObject) => default; // 0x000000018A959094-0x000000018A9590F4
	}

	[Serializable]
	public class HEU_InputInterfaceTilemapSettings // TypeDefIndex: 50778
	{
		// Fields
		public bool _createGroupsForTiles; // 0x10
		public bool _exportUnusedTiles; // 0x11
		public bool _applyTileColor; // 0x12
		public bool _applyTilemapOrientation; // 0x13
	
		// Constructors
		public HEU_InputInterfaceTilemapSettings() {} // 0x0000000185FCE5A0-0x0000000185FCE5B0
	}

	public class HEU_InputInterfaceTilemap : HEU_InputInterface // TypeDefIndex: 50780
	{
		// Fields
		private HEU_InputInterfaceTilemapSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataTilemap : HEU_InputData // TypeDefIndex: 50779
		{
			// Fields
			public Tilemap _tilemap; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataTilemap() {} // 0x000000018390FF00-0x000000018390FF10
		}
	
		// Constructors
		private HEU_InputInterfaceTilemap() {} // 0x000000018A95D4D8-0x000000018A95D544
	
		// Methods
		public void Initialize(HEU_InputInterfaceTilemapSettings settings) {} // 0x000000018A95D334-0x000000018A95D40C
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID) {
			inputNodeID = default;
			return default;
		} // 0x000000018A95D544-0x000000018A95D5D8
		public override bool IsThisInputObjectSupported(GameObject inputObject) => default; // 0x000000018A95D5D8-0x000000018A95E904
		private bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData) => default; // 0x000000018A95D40C-0x000000018A95D4D8
		public HEU_InputDataTilemap GenerateTilemapDataFromGameObject(GameObject inputObject) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class HEU_InputMeshUtility // TypeDefIndex: 50781
	{
		// Methods
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem) => default; // 0x000000018A95EAA0-0x000000018A95EBF8
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, ref HAPI_PartInfo partInfo) => default; // 0x000000018A95EE2C-0x000000018A95EF84
		public static bool SetMeshVertexAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, int[] indices, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem) => default; // 0x000000018A95EF84-0x000000018A95F0D8
		public static bool SetMeshVertexFloatAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, int[] indices, ref HAPI_PartInfo partInfo) => default; // 0x000000018A95F0D8-0x000000018A95F22C
		public static bool UploadMeshIntoHoudiniNode(HEU_SessionBase session, int assetNodeID, int objectID, int geoID, ref Mesh mesh) => default; // 0x000000018A95F22C-0x000000018A95F454
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3Int[] data, ref HAPI_PartInfo partInfo) => default; // 0x000000018A95EBF8-0x000000018A95ED48
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, string[] data, ref HAPI_PartInfo partInfo) => default; // 0x000000018A95ED48-0x000000018A95EE2C
		public static bool SetMeshDetailAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3 data, ref HAPI_PartInfo partInfo) => default; // 0x000000018A95E950-0x000000018A95EAA0
	}

	public static class HEU_InputUtility // TypeDefIndex: 50782
	{
		// Fields
		private static List<HEU_InputInterface> _inputInterfaces; // 0x00
	
		// Constructors
		static HEU_InputUtility() {} // 0x000000018A96006C-0x000000018A9600F8
	
		// Methods
		public static int GetHighestPriority() => default; // 0x000000018A95F7C4-0x000000018A95F868
		public static void RegisterInputInterface(HEU_InputInterface inputInterface) {} // 0x000000018A95FB68-0x000000018A95FD6C
		public static void UnregisterInputInterface(HEU_InputInterface inputInterface) {} // 0x000000018A95FD6C-0x000000018A95FDDC
		public static HEU_InputInterface GetInputInterfaceByType(System.Type type) => default; // 0x000000018A95F868-0x000000018A95F994
		public static HEU_InputInterface GetInputInterface(GameObject inputObject) => default; // 0x000000018A95FA60-0x000000018A95FB68
		internal static HEU_InputInterface GetInputInterface(HEU_InputObjectInfo inputObjectInfo) => default; // 0x000000018A95F994-0x000000018A95FA60
		internal static bool CreateInputNodeWithMultiObjects(HEU_SessionBase session, int assetID, ref int connectMergeID, ref List<HEU_InputObjectInfo> inputObjects, ref List<int> inputObjectsConnectedAssetIDs, HEU_InputNode inputNode) => default; // 0x000000018A95F510-0x000000018A95F668
		internal static bool CreateInputNodeWithMultiAssets(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, ref int connectMergeID, ref List<HEU_InputHDAInfo> inputAssetInfos, bool bKeepWorldTransform, int mergeParentID = -1 /* Metadata: 0x020642C6 */) => default; // 0x000000018A95F454-0x000000018A95F510
		internal static bool UploadInputObjectTransform(HEU_SessionBase session, HEU_InputObjectInfo inputObject, int inputNodeID, bool bKeepWorldTransform) => default; // 0x000000018A95FDDC-0x000000018A96006C
		public static void GetChildrenTransforms(Transform transform, ref List<Matrix4x4> childTransforms) {} // 0x000000018A95F668-0x000000018A95F7C4
	}

	public class HEU_Logger // TypeDefIndex: 50783
	{
		// Constructors
		public HEU_Logger() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void Log(string text) {} // 0x000000018A9603D4-0x000000018A960420
		public static void LogFormat(string text, object[] args) {} // 0x000000018A960230-0x000000018A96028C
		public static void LogWarning(string text) {} // 0x000000018A960388-0x000000018A9603D4
		public static void LogWarningFormat(string text, object[] args) {} // 0x000000018A960328-0x000000018A960388
		public static void LogError(string text) {} // 0x000000018A960168-0x000000018A9601B4
		public static void LogErrorFormat(string text, object[] args) {} // 0x000000018A960108-0x000000018A960168
		public static void LogError(Exception ex) {} // 0x000000018A9601B4-0x000000018A960230
		public static void LogAssertion(string text) {} // 0x000000018A960100-0x000000018A960108
		public static void LogAssertionFormat(string text, object[] args) {} // 0x000000018A9600F8-0x000000018A960100
		private static void LogToCookLogsIfOn(string text) {} // 0x000000018A9602E8-0x000000018A960328
		private static void LogToCookLogsIfOnFormat(string text, object[] args) {} // 0x000000018A96028C-0x000000018A9602E8
	}

	public class HEU_MeshData // TypeDefIndex: 50784
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
		public HEU_MeshData() {} // 0x000000018A960420-0x000000018A960658
	}

	[Serializable]
	public class HEU_MeshIndexFormat // TypeDefIndex: 50785
	{
		// Fields
		public IndexFormat _indexFormat; // 0x10
	
		// Constructors
		public HEU_MeshIndexFormat() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void CalculateIndexFormat(int numVertices) {} // 0x000000018A960658-0x000000018A9606B4
		public void SetFormatForMesh(Mesh mesh) {} // 0x000000018A9606B4-0x000000018A9606D8
	}

	public enum HEU_PipelineType // TypeDefIndex: 50786
	{
		Unsupported = 0,
		BiRP = 1,
		URP = 2,
		HDRP = 3
	}

	public class HEU_RenderingPipelineDefines // TypeDefIndex: 50787
	{
		// Constructors
		static HEU_RenderingPipelineDefines() {} // 0x000000018A960A50-0x000000018A960A58
		public HEU_RenderingPipelineDefines() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void UpdateDefines() {} // 0x000000018A96098C-0x000000018A960A50
		public static HEU_PipelineType GetPipeline() => default; // 0x000000018A9607DC-0x000000018A9608E8
		private static void AddDefine(string define) {} // 0x000000018A9606D8-0x000000018A96077C
		public static void RemoveDefine(string define) {} // 0x000000018A9608E8-0x000000018A96098C
		public static List<string> GetDefines() => default; // 0x000000018A96077C-0x000000018A9607DC
		public static void SetDefines(List<string> definesList) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HEU_SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ISerializationCallbackReceiver // TypeDefIndex: 50788
	{
		// Fields
		[NonSerialized]
		private Dictionary<TKey, TValue> _dictionary;
		private TKey[] _keys;
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
	public class HEU_ShelfToolData // TypeDefIndex: 50790
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
		public enum ToolType // TypeDefIndex: 50789
		{
			GENERATOR = 0,
			OPERATOR_SINGLE = 1,
			OPERATOR_MULTI = 2,
			BATCH = 3
		}
	
		// Constructors
		public HEU_ShelfToolData() {} // 0x000000018A960A58-0x000000018A960AFC
	}

	[Serializable]
	public class HEU_Shelf // TypeDefIndex: 50791
	{
		// Fields
		public string _shelfName; // 0x10
		public string _shelfPath; // 0x18
		public bool _defaultShelf; // 0x20
		public List<HEU_ShelfToolData> _tools; // 0x28
	
		// Constructors
		public HEU_Shelf() {} // 0x000000018A963EA0-0x000000018A963F18
	}

	public class HEU_ShelfTools // TypeDefIndex: 50793
	{
		// Fields
		private static List<HEU_Shelf> _shelves; // 0x00
		private static bool _shelvesLoaded; // 0x08
		private static int _currentSelectedShelf; // 0x0C
		public const string TARGET_ALL = "all"; // Metadata: 0x020642CF
		public const string TARGET_UNITY = "unity"; // Metadata: 0x020642D3
	
		// Nested types
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 50792
		{
			// Fields
			public string shelfName; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x000000018A960C9C-0x000000018A960CEC
	
			// Methods
			internal bool _AddShelf_b__0(HEU_Shelf shelf) => default; // 0x000000018A963D30-0x000000018A963D80
		}
	
		// Constructors
		public HEU_ShelfTools() {} // 0x0000000185492010-0x0000000185492020
		static HEU_ShelfTools() {} // 0x0000000187C26954-0x0000000187C2697C
	
		// Methods
		public static bool AreShelvesLoaded() => default; // 0x000000018A960CEC-0x000000018A960D50
		public static void SetReloadShelves() {} // 0x000000018A961D14-0x000000018A961D70
		public static void ClearShelves() {} // 0x000000018A961CC4-0x000000018A961D14
		public static int GetNumShelves() => default; // 0x000000018A963CDC-0x000000018A963D30
		public static int GetCurrentShelfIndex() => default; // 0x000000018A961F18-0x000000018A961FBC
		public static void SetCurrentShelf(int index) {} // 0x000000018A961DBC-0x000000018A961F18
		public static HEU_Shelf GetShelf(int index) => default; // 0x000000018A961D70-0x000000018A961DBC
		public static HEU_Shelf GetShelf(string shelfName) => default; // 0x000000018A961FBC-0x000000018A96209C
		public static string GetShelfStorageEntry(string shelfName, string shelfPath) => default; // 0x000000018A962650-0x000000018A962D2C
		public static void GetSplitShelfEntry(string shelfEntry, out string shelfName, out string shelfPath) {
			shelfName = default;
			shelfPath = default;
		} // 0x000000018A963774-0x000000018A963998
		public static void LoadShelves() {} // 0x000000018A962D2C-0x000000018A962EC8
		public static bool LoadToolsFromDirectory(string folderPath, out List<HEU_ShelfToolData> tools) {
			tools = default;
			return default;
		} // 0x000000018A962EC8-0x000000018A963774
		public static HEU_ShelfToolData LoadToolFromJsonFile(string jsonFilePath) => default; // 0x000000018A960AFC-0x000000018A960C9C
		public static HEU_ShelfToolData LoadToolFromJsonString(string json, string jsonFilePath) => default; // 0x000000018A963998-0x000000018A963AC8
		public static HEU_Shelf AddShelf(string shelfName, string shelfPath) => default; // 0x000000018A963AC8-0x000000018A963CDC
		public static void RemoveShelf(int shelfIndex) {} // 0x000000018A961A14-0x000000018A961CC4
		public static void SaveShelf() {} // 0x000000018A960DB0-0x000000018A960F4C
		public static void ExecuteTool(int toolSlot) {} // 0x000000018A9624C0-0x000000018A962650
		public static void ExecuteToolGenerator(string toolName, string toolPath, Vector3 targetPosition, Quaternion targetRotation, Vector3 targetScale) {} // 0x000000018A962430-0x000000018A9624C0
		public static bool IsValidInputMesh(GameObject gameObject) => default; // 0x000000018A963D80-0x000000018A963E00
		public static bool IsValidInputHDA(GameObject gameObject) => default; // 0x000000018A960F4C-0x000000018A961080
		private static bool ShouldUseHDA(GameObject[] gameObjectList) => default; // 0x000000018A96149C-0x000000018A961A14
		public static void ExecuteToolNoInput(string toolName, string toolPath) {} // 0x000000018A961080-0x000000018A96149C
		public static void ExecuteToolOperatorSingle(string toolName, string toolPath, GameObject[] inputObjects) {} // 0x000000018A960D50-0x000000018A960DB0
		public static void ExecuteToolOperatorMultiple(string toolName, string toolPath, GameObject[] inputObjects) {} // 0x000000018A962374-0x000000018A962430
		public static void ExecuteToolBatch(string toolName, string toolPath, GameObject[] batchObjects) {} // 0x000000018A96220C-0x000000018A962374
		public static string GetToolResourcePath(HEU_ShelfToolData tool, string inPath, string ext) => default; // 0x000000018A96209C-0x000000018A96220C
		public static string GetToolIconPath(HEU_ShelfToolData tool, string inPath) => default; // 0x0000000185492010-0x0000000185492020
		public static string GetToolAssetPath(HEU_ShelfToolData tool, string inPath) => default; // 0x000000018A963E00-0x000000018A963EA0
	}

	public enum JSONNodeType // TypeDefIndex: 50794
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

	public enum JSONTextMode // TypeDefIndex: 50795
	{
		Compact = 0,
		Indent = 1
	}

	public abstract class JSONNode // TypeDefIndex: 50803
	{
		// Fields
		public static bool forceASCII; // 0x00
		public static bool longAsString; // 0x01
		private static StringBuilder m_EscapeBuilder; // 0x80000000
		public static JSONContainerType VectorContainerType; // 0x04
		public static JSONContainerType QuaternionContainerType; // 0x08
		public static JSONContainerType RectContainerType; // 0x0C
	
		// Properties
		public abstract JSONNodeType Tag { get; } // 0x000000018A966D30-0x000000018A966D70 
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A966E5C-0x000000018A966EAC 0x000000018A96681C-0x000000018A96685C
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x000000018A966D70-0x000000018A966DC8 0x000000018A966FEC-0x000000018A96702C
		public virtual string Value { get; set; } // 0x000000018A966934-0x000000018A966984 0x000000018A966BE8-0x000000018A966C28
		public virtual int Count { get; } // 0x000000018A9669CC-0x000000018A966A8C 
		public virtual bool IsNumber { get; } // 0x000000018A966FAC-0x000000018A966FEC 
		public virtual bool IsString { get; } // 0x000000018A966984-0x000000018A9669CC 
		public virtual bool IsBoolean { get; } // 0x000000018A966DE4-0x000000018A966E24 
		public virtual bool IsNull { get; } // 0x000000018A966E24-0x000000018A966E5C 
		public virtual bool IsArray { get; } // 0x000000018A966734-0x000000018A96681C 
		public virtual bool IsObject { get; } // 0x000000018A967064-0x000000018A967078 
		public virtual bool Inline { get; set; } // 0x000000018406FBE0-0x000000018406FBF0 0x0000000185FB0F10-0x0000000185FB0F20
		public virtual IEnumerable<JSONNode> Children { get; } // 0x000000018A966A8C-0x000000018A966B28 
		public IEnumerable<JSONNode> DeepChildren { get; } // 0x000000018A966B28-0x000000018A966BE8 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x000000018A966F90-0x000000018A966FAC 
		public KeyEnumerator Keys { get; } // 0x000000018A96702C-0x000000018A967064 
		public ValueEnumerator Values { get; } // 0x000000018A966C88-0x000000018A966CB8 
		public virtual double AsDouble { get; set; } // 0x000000018A966C28-0x000000018A966C58 0x000000018A966C58-0x000000018A966C88
		public virtual int AsInt { get; set; } // 0x000000018A966DC8-0x000000018A966DE4 0x000000018A96507C-0x000000018A965164
		public virtual float AsFloat { get; set; } // 0x000000018A965164-0x000000018A965204 0x000000018A965204-0x000000018A96521C
		public virtual bool AsBool { get; set; } // 0x000000018A965E60-0x000000018A965F58 0x000000018A96521C-0x000000018A965398
		public virtual long AsLong { get; set; } // 0x000000018A965398-0x000000018A965480 0x000000018A965480-0x000000018A9654D0
		public virtual JSONArray AsArray { get; } // 0x000000018A965F58-0x000000018A966098 
		public virtual JSONObject AsObject { get; } // 0x000000018A9654D0-0x000000018A9656AC 
		internal static StringBuilder EscapeBuilder { get; } // 0x000000018A9672AC-0x000000018A967350 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 50797
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get => default; }
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
			// Nested types
			private enum Type // TypeDefIndex: 50796
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
			} // 0x00000001813AE580-0x00000001813AE590
			public Enumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public struct ValueEnumerator // TypeDefIndex: 50798
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x000000018A966708-0x000000018A966734
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x0000000185492010-0x0000000185492020
			public ValueEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			public bool MoveNext() => default; // 0x00000001814A81B0-0x00000001814A81C0
			public ValueEnumerator GetEnumerator() => default; // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 50799
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x00000001814A81B0-0x00000001814A81C0
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x00000001814A81B0-0x00000001814A81C0
			public KeyEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			public bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			public KeyEnumerator GetEnumerator() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 50800
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get => default; } // 0x00000001813AE580-0x00000001813AE590 
			object IEnumerator.Current { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
			// Constructors
			public LinqEnumerator() {} // Dummy constructor
			internal LinqEnumerator(JSONNode aNode) {} // 0x000000018A963F18-0x000000018A963F60
	
			// Methods
			public bool MoveNext() => default; // 0x00000001834A4750-0x00000001834A4760
			public void Dispose() {} // 0x000000018A96647C-0x000000018A9664D0
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator() => default; // 0x000000018A9664D0-0x000000018A966540
			public void Reset() {} // 0x000000018A9656E8-0x000000018A96576C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A96576C-0x000000018A9657FC
		}
	
		private sealed class _get_Children_d__40 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 50801
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get => default; } // 0x000000018A9665F4-0x000000018A9666A8 
			object IEnumerator.Current { get => default; } // 0x000000018A96633C-0x000000018A9663C8 
	
			// Constructors
			public _get_Children_d__40() {} // Dummy constructor
			public _get_Children_d__40(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default; // 0x000000018A9666A8-0x000000018A966708
			void IEnumerator.Reset() {} // 0x000000018A9665F4-0x000000018A9666A8
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018A9670E4-0x000000018A967148
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A9663E4-0x000000018A966400
		}
	
		private sealed class _get_DeepChildren_d__42 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 50802
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONNode __4__this; // 0x28
			private IEnumerator<JSONNode> __7__wrap1; // 0x30
			private IEnumerator<JSONNode> __7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get => default; } // 0x000000018A966400-0x000000018A966440 
			object IEnumerator.Current { get => default; } // 0x000000018A966264-0x000000018A9662A0 
	
			// Constructors
			public _get_DeepChildren_d__42() {} // Dummy constructor
			public _get_DeepChildren_d__42(int __1__state) {} // 0x000000018A96715C-0x000000018A967174
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A9663C8-0x000000018A9663E4
			private bool MoveNext() => default; // 0x000000018A967148-0x000000018A96715C
			private void __m__Finally1() {} // 0x000000018A9662A0-0x000000018A96633C
			private void __m__Finally2() {} // 0x000000018A967078-0x000000018A9670E4
			void IEnumerator.Reset() {} // 0x000000018A967174-0x000000018A9671A4
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018A966440-0x000000018A96647C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A96685C-0x000000018A9668BC
		}
	
		// Constructors
		protected JSONNode() {} // 0x000000018A97AA48-0x000000018A97AA50
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x000000018A966540-0x000000018A9665F4
		public virtual void Add(JSONNode aItem) {} // 0x000000018A963F60-0x000000018A9641C8
		public virtual JSONNode Remove(string aKey) => default; // 0x000000018A96424C-0x000000018A9643A0
		public virtual JSONNode Remove(int aIndex) => default; // 0x000000018A9643A0-0x000000018A964930
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x000000018A9641C8-0x000000018A96424C
		public override string ToString() => default; // 0x000000018A9668BC-0x000000018A966934
		public virtual string ToString(int aIndent) => default; // 0x000000018A966F18-0x000000018A966F90
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018A966CB8-0x000000018A966D30
		public abstract Enumerator GetEnumerator(); // 0x000000018A966EAC-0x000000018A966F18
		public static implicit operator JSONNode(string s) => default; // 0x000000018A9656AC-0x000000018A9656E8
		public static implicit operator string(JSONNode d) => default; // 0x000000018A966098-0x000000018A966264
		public static implicit operator JSONNode(double n) => default; // 0x000000018A964A14-0x000000018A964BF0
		public static implicit operator double(JSONNode d) => default; // 0x000000018A9649D8-0x000000018A964A14
		public static implicit operator JSONNode(float n) => default; // 0x000000018A965890-0x000000018A965A5C
		public static implicit operator float(JSONNode d) => default; // 0x000000018A964EA0-0x000000018A96507C
		public static implicit operator JSONNode(int n) => default; // 0x000000018A964E6C-0x000000018A964EA0
		public static implicit operator int(JSONNode d) => default; // 0x000000018A965C94-0x000000018A965E60
		public static implicit operator JSONNode(long n) => default; // 0x000000018A964BF0-0x000000018A964E04
		public static implicit operator long(JSONNode d) => default; // 0x000000018A964E04-0x000000018A964E6C
		public static implicit operator JSONNode(bool b) => default; // 0x000000018A965A5C-0x000000018A965C94
		public static implicit operator bool(JSONNode d) => default; // 0x000000018A964930-0x000000018A9649D8
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue) => default; // 0x000000018A9657FC-0x000000018A965890
		public static bool operator ==(JSONNode a, object b) => default; // 0x0000000185492010-0x0000000185492020
		public static bool operator !=(JSONNode a, object b) => default; // 0x000000018646D60C-0x000000018646D614
		public override bool Equals(object obj) => default; // 0x000000018A967278-0x000000018A9672AC
		public override int GetHashCode() => default; // 0x0000000184C6C480-0x0000000184C6C4D0
		internal static string Escape(string aText) => default; // 0x000000018A967208-0x000000018A967278
		private static JSONNode ParseElement(string token, bool quoted) => default; // 0x000000018A9716B8-0x000000018A971750
		public static JSONNode Parse(string aJSON) => default; // 0x000000018A9715E4-0x000000018A971684
		private static JSONNode GetContainer(JSONContainerType aType) => default; // 0x000000018A971684-0x000000018A9716B8
		public static implicit operator JSONNode(Vector2 aVec) => default; // 0x000000018A97AC1C-0x000000018A97ADE0
		public static implicit operator JSONNode(Vector3 aVec) => default; // 0x000000018A9715DC-0x000000018A9715E4
		public static implicit operator JSONNode(Vector4 aVec) => default; // 0x0000000185FCE5F0-0x0000000185FCE620
		public static implicit operator JSONNode(Quaternion aRot) => default; // 0x000000018A9716B8-0x000000018A971750
		public static implicit operator JSONNode(Rect aRect) => default; // 0x000000018A9715E4-0x000000018A971684
		public static implicit operator JSONNode(RectOffset aRect) => default; // 0x000000018A971684-0x000000018A9716B8
		public static implicit operator Vector2(JSONNode aNode) => default; // 0x000000018A971750-0x000000018A971790
		public static implicit operator Vector3(JSONNode aNode) => default; // 0x000000018A9715DC-0x000000018A9715E4
		public static implicit operator Vector4(JSONNode aNode) => default; // 0x0000000185FCE5F0-0x0000000185FCE620
		public static implicit operator Quaternion(JSONNode aNode) => default; // 0x000000018A971964-0x000000018A9719E0
		public static implicit operator Rect(JSONNode aNode) => default; // 0x000000018A9719E0-0x000000018A971A0C
		public static implicit operator RectOffset(JSONNode aNode) => default; // 0x000000018A97190C-0x000000018A971964
		public Vector2 ReadVector2(Vector2 aDefault) => default; // 0x000000018A971830-0x000000018A97183C
		public Vector2 ReadVector2(string aXName, string aYName) => default; // 0x000000018A971790-0x000000018A9717CC
		public Vector2 ReadVector2() => default; // 0x000000018A9717CC-0x000000018A971830
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x020642E4 */, string aYName = "y" /* Metadata: 0x020642E6 */) => default; // 0x000000018A97183C-0x000000018A9718A8
		public Vector3 ReadVector3(Vector3 aDefault) => default; // 0x000000018A9718A8-0x000000018A97190C
		public Vector3 ReadVector3(string aXName, string aYName, string aZName) => default; // 0x0000000184775050-0x0000000184775070
		public Vector3 ReadVector3() => default; // 0x0000000185492010-0x0000000185492020
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x020642E8 */, string aYName = "y" /* Metadata: 0x020642EA */, string aZName = "z" /* Metadata: 0x020642EC */) => default; // 0x0000000185FADBE0-0x0000000185FADBF0
		public Vector4 ReadVector4(Vector4 aDefault) => default; // 0x0000000181377E40-0x0000000181377E50
		public Vector4 ReadVector4() => default; // 0x000000018A97A578-0x000000018A97A5C4
		public JSONNode WriteVector4(Vector4 aVec) => default; // 0x0000000181377E40-0x0000000181377E50
		public Quaternion ReadQuaternion(Quaternion aDefault) => default; // 0x000000018A97A4F8-0x000000018A97A570
		public Quaternion ReadQuaternion() => default; // 0x000000018A97A570-0x000000018A97A578
		public JSONNode WriteQuaternion(Quaternion aRot) => default; // 0x0000000184775050-0x0000000184775070
		public Rect ReadRect(Rect aDefault) => default; // 0x000000018A97AA9C-0x000000018A97AB88
		public Rect ReadRect() => default; // 0x000000018A97A5C4-0x000000018A97A9BC
		public JSONNode WriteRect(Rect aRect) => default; // 0x000000018A97AB88-0x000000018A97ABD0
		public RectOffset ReadRectOffset(RectOffset aDefault) => default; // 0x000000018A97ABD0-0x000000018A97AC1C
		public RectOffset ReadRectOffset() => default; // 0x0000000181377E40-0x0000000181377E50
		public JSONNode WriteRectOffset(RectOffset aRect) => default; // 0x000000018A97AA50-0x000000018A97AA9C
		public Matrix4x4 ReadMatrix() => default; // 0x0000000181377E40-0x0000000181377E50
		public JSONNode WriteMatrix(Matrix4x4 aMatrix) => default; // 0x000000018A97A9BC-0x000000018A97AA48
	}

	public class JSONArray : JSONNode // TypeDefIndex: 50805
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x000000018A96F508-0x000000018A96F548 0x000000018A96F0AC-0x000000018A96F134
		public override JSONNodeType Tag { get => default; } // 0x000000018A96F1C4-0x000000018A96F268 
		public override bool IsArray { get => default; } // 0x000000018A96F268-0x000000018A96F2C0 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A96F2C0-0x000000018A96F420 0x000000018A96F420-0x000000018A96F498
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000184775050-0x0000000184775070 0x000000018A97A03C-0x000000018A97A0B4
		public override int Count { get => default; } // 0x000000018A979D14-0x000000018A979F5C 
		public override IEnumerable<JSONNode> Children { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class _get_Children_d__22 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 50804
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONArray __4__this; // 0x28
			private List<JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get => default; } // 0x000000018A96F134-0x000000018A96F1C4 
			object IEnumerator.Current { get => default; } // 0x000000018A96F648-0x000000018A96F71C 
	
			// Constructors
			public _get_Children_d__22() {} // Dummy constructor
			public _get_Children_d__22(int __1__state) {} // 0x00000001813C0430-0x00000001813C0440
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001813C0520-0x00000001813C0530
			private bool MoveNext() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
			private void __m__Finally1() {} // 0x00000001840A27C0-0x00000001840A27D0
			void IEnumerator.Reset() {} // 0x000000018A96F5A8-0x000000018A96F648
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018A96F548-0x000000018A96F5A8
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A96F71C-0x000000018A96F7A4
		}
	
		// Constructors
		public JSONArray() {} // 0x000000018A979FE8-0x000000018A979FF0
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018A96F498-0x000000018A96F508
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018A97A0B4-0x000000018A97A0F0
		public override JSONNode Remove(int aIndex) => default; // 0x0000000181377E40-0x0000000181377E50
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018A979FF0-0x000000018A97A03C
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A979F5C-0x000000018A979FE8
	}

	public class JSONObject : JSONNode // TypeDefIndex: 50808
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get => default; set {} } // 0x000000018A970C9C-0x000000018A970D54 0x000000018A970A30-0x000000018A970AF0
		public override JSONNodeType Tag { get => default; } // 0x000000018A970AF0-0x000000018A970C9C 
		public override bool IsObject { get => default; } // 0x000000018A9710F4-0x000000018A971164 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018A97107C-0x000000018A9710F4 0x0000000185492010-0x0000000185492020
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A9795C4-0x000000018A97960C 0x0000000184775050-0x0000000184775070
		public override int Count { get => default; } // 0x000000018A97A444-0x000000018A97A4BC 
		public override IEnumerable<JSONNode> Children { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 50806
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x00000001813C0430-0x00000001813C0440
	
			// Methods
			internal bool _Remove_b__0(KeyValuePair<string, JSONNode> k) => default; // 0x00000001813C0520-0x00000001813C0530
		}
	
		private sealed class _get_Children_d__23 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 50807
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONObject __4__this; // 0x28
			private Dictionary<string, JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { get => default; } // 0x000000018A9712F0-0x000000018A9713D8 
			object IEnumerator.Current { get => default; } // 0x000000018A9713D8-0x000000018A9714C4 
	
			// Constructors
			public _get_Children_d__23() {} // Dummy constructor
			public _get_Children_d__23(int __1__state) {} // 0x0000000181C6A970-0x0000000181C6A980
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001840A27C0-0x00000001840A27D0
			private bool MoveNext() => default; // 0x000000018A97098C-0x000000018A970A30
			private void __m__Finally1() {} // 0x000000018A9711A4-0x000000018A971264
			void IEnumerator.Reset() {} // 0x000000018A971264-0x000000018A9712F0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator() => default; // 0x000000018A971164-0x000000018A9711A4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A970840-0x000000018A97098C
		}
	
		// Constructors
		public JSONObject() {} // 0x000000018A97A3F0-0x000000018A97A3F8
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x000000018A970D54-0x000000018A97107C
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018A97A0F0-0x000000018A97A364
		public override JSONNode Remove(string aKey) => default; // 0x000000018A97A4BC-0x000000018A97A4F8
		public override JSONNode Remove(int aIndex) => default; // 0x0000000181377E40-0x0000000181377E50
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018A97A3F8-0x000000018A97A444
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A97A364-0x000000018A97A3F0
	}

	public class JSONString : JSONNode // TypeDefIndex: 50809
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
		public override bool IsString { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public JSONString() {} // Dummy constructor
		public JSONString(string aData) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A971568-0x000000018A9715D4
		public override bool Equals(object obj) => default; // 0x000000018A9714C4-0x000000018A971568
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 50810
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
		public override bool IsNumber { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018A970774-0x000000018A9707C0 0x000000018A9707C0-0x000000018A970840
		public override double AsDouble { get => default; set {} } // 0x0000000185FC3350-0x0000000185FC3360 0x0000000185FAFF60-0x0000000185FAFF70
		public override long AsLong { get => default; set {} } // 0x0000000185FCE5D0-0x0000000185FCE5E0 0x0000000185FCE5E0-0x0000000185FCE5F0
	
		// Constructors
		public JSONNumber() {} // Dummy constructor
		public JSONNumber(double aData) {} // 0x0000000185FAFF60-0x0000000185FAFF70
		public JSONNumber(string aData) {} // 0x000000018A96F8B4-0x000000018A96F8C8
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A970740-0x000000018A970774
		private static bool IsNumeric(object value) => default; // 0x000000018A9705F8-0x000000018A970740
		public override bool Equals(object obj) => default; // 0x000000018A970518-0x000000018A9705EC
		public override int GetHashCode() => default; // 0x000000018A9705EC-0x000000018A9705F8
	}

	public class JSONBool : JSONNode // TypeDefIndex: 50811
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181D409B0-0x0000000181D40CF0 
		public override bool IsBoolean { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018A96F8C8-0x000000018A96F914 0x000000018A96F914-0x000000018A96F978
		public override bool AsBool { get => default; set {} } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public JSONBool() {} // Dummy constructor
		public JSONBool(bool aData) {} // 0x000000018184FBD0-0x000000018184FBE0
		public JSONBool(string aData) {} // 0x000000018A96F8B4-0x000000018A96F8C8
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A96F848-0x000000018A96F8B4
		public override bool Equals(object obj) => default; // 0x000000018A96F7A4-0x000000018A96F800
		public override int GetHashCode() => default; // 0x000000018A96F800-0x000000018A96F848
	}

	public class JSONNull : JSONNode // TypeDefIndex: 50812
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181D27740-0x0000000181D27750 
		public override bool IsNull { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string Value { get => default; set {} } // 0x000000018A9704EC-0x000000018A970518 0x0000000185492010-0x0000000185492020
		public override bool AsBool { get => default; set {} } // 0x00000001814A81B0-0x00000001814A81C0 0x0000000185492010-0x0000000185492020
	
		// Constructors
		private JSONNull() {} // 0x0000000185492010-0x0000000185492020
		static JSONNull() {} // 0x000000018A970474-0x000000018A9704EC
	
		// Methods
		public static JSONNull CreateOrGet() => default; // 0x000000018A970368-0x000000018A9703D4
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		public override bool Equals(object obj) => default; // 0x000000018A9703D4-0x000000018A97042C
		public override int GetHashCode() => default; // 0x00000001813AE580-0x00000001813AE590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A97042C-0x000000018A970474
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 50813
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get => default; } // 0x0000000181B9FE80-0x0000000181B9FE90 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018A96FE80-0x000000018A96FEE0 0x000000018A970230-0x000000018A9702C4
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018A96FEE0-0x000000018A96FF50 0x000000018A9702C4-0x000000018A970368
		public override int AsInt { get => default; set {} } // 0x000000018A96FCB8-0x000000018A96FD20 0x000000018A9700BC-0x000000018A970134
		public override float AsFloat { get => default; set {} } // 0x000000018A96FC50-0x000000018A96FCB8 0x000000018A970044-0x000000018A9700BC
		public override double AsDouble { get => default; set {} } // 0x000000018A96FBE8-0x000000018A96FC50 0x000000018A96FFD0-0x000000018A970044
		public override long AsLong { get => default; set {} } // 0x000000018A96FD20-0x000000018A96FE08 0x000000018A970134-0x000000018A970230
		public override bool AsBool { get => default; set {} } // 0x000000018A96FB80-0x000000018A96FBE8 0x000000018A96FF60-0x000000018A96FFD0
		public override JSONArray AsArray { get => default; } // 0x000000018A96FB08-0x000000018A96FB80 
		public override JSONObject AsObject { get => default; } // 0x000000018A96FE08-0x000000018A96FE80 
	
		// Constructors
		public JSONLazyCreator() {} // Dummy constructor
		public JSONLazyCreator(JSONNode aNode) {} // 0x00000001846A0F60-0x00000001846A0F90
		public JSONLazyCreator(JSONNode aNode, string aKey) {} // 0x00000001841BC230-0x00000001841BC260
	
		// Methods
		public override Enumerator GetEnumerator() => default; // 0x0000000185FC18D0-0x0000000185FC18F0
		private T Set<T>(T aVal)
			where T : JSONNode => default;
		public override void Add(JSONNode aItem) {} // 0x000000018A96FA1C-0x000000018A96FAB0
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018A96F978-0x000000018A96FA1C
		public static bool operator ==(JSONLazyCreator a, object b) => default; // 0x000000018A96FAB0-0x000000018A96FAC0
		public static bool operator !=(JSONLazyCreator a, object b) => default; // 0x000000018A96FF50-0x000000018A96FF60
		public override bool Equals(object obj) => default; // 0x000000018A96FAB0-0x000000018A96FAC0
		public override int GetHashCode() => default; // 0x00000001813AE580-0x00000001813AE590
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018A96FAC0-0x000000018A96FB08
	}

	public static class JSON // TypeDefIndex: 50814
	{
		// Methods
		public static JSONNode Parse(string aJSON) => default; // 0x000000018A9715D4-0x000000018A9715DC
	}

	public enum JSONContainerType // TypeDefIndex: 50815
	{
		Array = 0,
		Object = 1
	}

	public static class HEU_TerrainUtility // TypeDefIndex: 50816
	{
		// Methods
		public static bool GenerateTerrainFromVolume(HEU_SessionBase session, ref HAPI_VolumeInfo volumeInfo, int geoID, int partID, GameObject gameObject, ref TerrainData terrainData, out Vector3 volumePositionOffset, ref Terrain terrain, string bakedMaterialPath) {
			volumePositionOffset = default;
			return default;
		} // 0x000000018A9683AC-0x000000018A968CE8
		public static void SetTerrainMaterial(Terrain terrain, string specifiedMaterialName, string bakedMaterialPath = "" /* Metadata: 0x020642F3 */) {} // 0x000000018A96AC74-0x000000018A96ADE0
		public static string GetDefaultTerrainShaderName() => default; // 0x000000018A968DD8-0x000000018A968E58
		public static string GetDefaultTerrainMaterialPath() => default; // 0x000000018A968D58-0x000000018A968DD8
		public static float[] GetNormalizedHeightmapFromPartWithMinMax(HEU_SessionBase session, int geoID, int partID, int heightMapWidth, int heightMapHeight, ref float minHeight, ref float maxHeight, ref float heightRange, bool bUseHeightRangeOverride) => default; // 0x000000018A969210-0x000000018A969290
		public static int[,] GetDetailMapFromPart(HEU_SessionBase session, int geoID, int partID, out int detailResolution) {
			detailResolution = default;
			return default;
		} // 0x000000018A968E58-0x000000018A968EE8
		public static bool GetHeightmapFromPart(HEU_SessionBase session, int xLength, int yLength, int geoID, int partID, ref float[] heightValues, ref float minHeight, ref float maxHeight) => default; // 0x000000018A969098-0x000000018A969210
		public static float[,] ConvertHeightMapHoudiniToUnity(int heightMapWidth, int heightMapHeight, float[] heightValues) => default; // 0x000000018A9682D0-0x000000018A9683AC
		public static float[,,] ConvertHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, List<float[]> heightFields) => default; // 0x000000018A96818C-0x000000018A9682D0
		public static float[,,] AppendConvertedHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, float[,,] existingAlphaMaps, List<float[]> heightFields, float[] strengths, List<int> alphaMapIndices) => default; // 0x000000018A967634-0x000000018A96782C
		public static Vector3 GetVolumePositionOffset(HEU_SessionBase session, int geoID, int partID, Vector3 volumePosition, float terrainSizeX, float heightMapSize, int mapWidth, int mapHeight, float minHeight) => default; // 0x000000018A969650-0x000000018A96973C
		public static List<HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HEU_SessionBase session, int geoID, int partID) => default; // 0x000000018A96955C-0x000000018A969650
		public static void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, ref HEU_VolumeScatterTrees scatterTrees, bool throwWarningIfNoTileAttribute) {} // 0x000000018A969E30-0x000000018A96A9DC
		public static void ApplyScatterTrees(TerrainData terrainData, HEU_VolumeScatterTrees scatterTrees, int tileIndex) {} // 0x000000018A967CA0-0x000000018A96818C
		public static void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailPrototype detailPrototype) {} // 0x000000018A969A0C-0x000000018A969E30
		public static void PopulateDetailProperties(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailProperties detailProperties) {} // 0x000000018A96973C-0x000000018A969A0C
		public static void ApplyDetailLayers(Terrain terrain, TerrainData terrainData, HEU_DetailProperties detailProperties, List<HEU_DetailPrototype> heuDetailPrototypes, List<int[,]> convertedDetailMaps) {} // 0x000000018A96782C-0x000000018A967CA0
		private static int GetTerrainLayerIndexByName(string layerName, TerrainLayer[] terrainLayers) => default; // 0x000000018A969358-0x000000018A9694C4
		public static int GetTerrainLayerIndex(TerrainLayer layer, TerrainLayer[] terrainLayers) => default; // 0x000000018A9694C4-0x000000018A96955C
		public static bool VolumeLayerHasAttributes(HEU_SessionBase session, int geoID, int partID) => default; // 0x000000018A96ADE0-0x000000018A96AF70
		public static HFLayerType GetHeightfieldLayerType(HEU_SessionBase session, int geoID, int partID, string volumeName) => default; // 0x000000018A968F5C-0x000000018A969098
		public static float GetHeightRangeFromHeightfield(HEU_SessionBase session, int geoID, int partID) => default; // 0x000000018A968EE8-0x000000018A968F5C
		public static string GetTerrainDataExportPathFromHeightfieldAttribute(HEU_SessionBase session, int geoID, int partID) => default; // 0x000000018A969290-0x000000018A969358
		public static float[] ResampleData(float[] data, int oldWidth, int oldHeight, int newWidth, int newHeight) => default; // 0x000000018A96A9DC-0x000000018A96AC74
		public static bool GetAttributeTile(HEU_SessionBase session, int geoID, int partID, out int outTileAttribute) {
			outTileAttribute = default;
			return default;
		} // 0x000000018A968CE8-0x000000018A968D58
	}

	public interface IEquivable<T> // TypeDefIndex: 50817
	{
		// Methods
		bool IsEquivalentTo(T other);
	}

	public interface IEquivableWrapperClass<T> : IEquivable<T> // TypeDefIndex: 50818
		where T : class
	{
		// Methods
		bool IsNull();
	}

	internal class HEU_TestHelpers // TypeDefIndex: 50821
	{
		// Nested types
		public class RequireStruct<T> // TypeDefIndex: 50819
			where T : struct
		{
			// Constructors
			public RequireStruct() {}
		}
	
		public class RequireClass<T> // TypeDefIndex: 50820
			where T : class
		{
			// Constructors
			public RequireClass() {} // 0x000000018A96B0D4-0x000000018A96B1D0
		}
	
		// Constructors
		public HEU_TestHelpers() {}
	
		// Methods
		public static bool AssertTrueLogEquivalent<T>(T a, T b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x020642F4 */, string optional2 = "" /* Metadata: 0x020642F5 */, string optional3 = "" /* Metadata: 0x020642F6 */, RequireStruct<T> _ = null)
			where T : struct => default;
		public static bool AssertTrueLogEquivalent(GameObject a, GameObject b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x020642F7 */, string optional2 = "" /* Metadata: 0x020642F8 */, string optional3 = "" /* Metadata: 0x020642F9 */) => default;
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T> a, IEquivable<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x020642FA */, string optional2 = "" /* Metadata: 0x020642FB */, string optional3 = "" /* Metadata: 0x020642FC */) => default; // 0x000000018A96B1D0-0x000000018A96B2A0
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x020642FD */, string optional2 = "" /* Metadata: 0x020642FE */, string optional3 = "" /* Metadata: 0x020642FF */)
			where T : class => default;
		public static bool AssertTrueLogEquivalent(string a, string b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064300 */, string optional2 = "" /* Metadata: 0x02064301 */, string optional3 = "" /* Metadata: 0x02064302 */) => default;
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064303 */, string optional2 = "" /* Metadata: 0x02064304 */, string optional3 = "" /* Metadata: 0x02064305 */, RequireStruct<T> _ = null)
			where T : struct => default;
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064306 */, string optional2 = "" /* Metadata: 0x02064307 */, string optional3 = "" /* Metadata: 0x02064308 */, RequireClass<T> _ = null)
			where T : class => default;
		public static bool AssertTrueLogEquivalent<T>(List<IEquivable<T>> a, List<IEquivable<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064309 */, string optional2 = "" /* Metadata: 0x0206430A */, string optional3 = "" /* Metadata: 0x0206430B */) => default;
		public static bool AssertTrueLogEquivalent<T>(List<IEquivableWrapperClass<T>> a, List<IEquivableWrapperClass<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0206430C */, string optional2 = "" /* Metadata: 0x0206430D */, string optional3 = "" /* Metadata: 0x0206430E */)
			where T : class => default; // 0x000000018A96AF70-0x000000018A96B0D4
		public static bool AssertTrueLogEquivalent<T>(T[] a, T[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0206430F */, string optional2 = "" /* Metadata: 0x02064310 */, string optional3 = "" /* Metadata: 0x02064311 */)
			where T : struct => default;
		public static bool AssertTrueLogEquivalent(string[] a, string[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064312 */, string optional2 = "" /* Metadata: 0x02064313 */, string optional3 = "" /* Metadata: 0x02064314 */) => default;
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T>[] a, IEquivable<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064315 */, string optional2 = "" /* Metadata: 0x02064316 */, string optional3 = "" /* Metadata: 0x02064317 */) => default; // 0x000000018A96B2A0-0x000000018A96B3E4
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T>[] a, IEquivableWrapperClass<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x02064318 */, string optional2 = "" /* Metadata: 0x02064319 */, string optional3 = "" /* Metadata: 0x0206431A */)
			where T : class => default;
		public static void PrintTestLogAndSetResult(bool expression, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0206431B */, string optional2 = "" /* Metadata: 0x0206431C */, string optional3 = "" /* Metadata: 0x0206431D */) {} // 0x000000018A96B3E4-0x000000018A96B624
		public static bool ShouldBeTested<T>(T a, T b, ref bool bResult, string header = "" /* Metadata: 0x0206431E */, string subject = "" /* Metadata: 0x0206431F */)
			where T : class => default;
		public static bool ShouldBeTested(GameObject a, GameObject b, ref bool bResult, string header = "" /* Metadata: 0x02064320 */, string subject = "" /* Metadata: 0x02064321 */) => default;
		public static bool ShouldBeTested<T>(IEquivable<T> a, IEquivable<T> b, ref bool bResult, string header = "" /* Metadata: 0x02064322 */, string subject = "" /* Metadata: 0x02064323 */) => default;
		public static bool ShouldBeTested<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool bResult, string header = "" /* Metadata: 0x02064324 */, string subject = "" /* Metadata: 0x02064325 */)
			where T : class => default;
		private static bool ShouldBeTested<T>(List<T> a, List<T> b, ref bool bResult, string header = "" /* Metadata: 0x02064326 */, string subject = "" /* Metadata: 0x02064327 */) => default; // 0x000000018A96B624-0x000000018A96B6B8
		public static bool ShouldBeTested<T>(T[] a, T[] b, ref bool bResult, string header = "" /* Metadata: 0x02064328 */, string subject = "" /* Metadata: 0x02064329 */) => default; // 0x000000018A96B6B8-0x000000018A96BD10
		public static bool ShouldBeTested(string a, string b, ref bool bResult, string header = "" /* Metadata: 0x0206432A */, string subject = "" /* Metadata: 0x0206432B */) => default; // 0x0000000185492010-0x0000000185492020
		public static bool TestOutputObjectEquivalence(GameObject a, GameObject b) => default;
	}

	public class Test_HAPI_AssetInfo : IEquivable<Test_HAPI_AssetInfo> // TypeDefIndex: 50822
	{
		// Fields
		public HAPI_AssetInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AssetInfo() {} // Dummy constructor
		public Test_HAPI_AssetInfo(HAPI_AssetInfo self) {} // 0x0000000185FC5C40-0x0000000185FC5C60
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AssetInfo other) => default; // 0x000000018A973130-0x000000018A97330C
	}

	public static class Test_HAPI_AssetInfo_Extensions // TypeDefIndex: 50823
	{
		// Methods
		public static Test_HAPI_AssetInfo ToTestObject(HAPI_AssetInfo self) => default; // 0x000000018A9730CC-0x000000018A973130
	}

	public class Test_HAPI_NodeInfo : IEquivable<Test_HAPI_NodeInfo> // TypeDefIndex: 50824
	{
		// Fields
		public HAPI_NodeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_NodeInfo() {} // Dummy constructor
		public Test_HAPI_NodeInfo(HAPI_NodeInfo self) {} // 0x0000000185FCE640-0x0000000185FCE670
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_NodeInfo other) => default; // 0x000000018A97385C-0x000000018A973BD0
	}

	public static class Test_HAPI_NodeInfo_Extensions // TypeDefIndex: 50825
	{
		// Methods
		public static Test_HAPI_NodeInfo ToTestObject(HAPI_NodeInfo self) => default; // 0x000000018A9737EC-0x000000018A97385C
	}

	public class Test_HAPI_ObjectInfo : IEquivable<Test_HAPI_ObjectInfo> // TypeDefIndex: 50826
	{
		// Fields
		public HAPI_ObjectInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ObjectInfo() {} // Dummy constructor
		public Test_HAPI_ObjectInfo(HAPI_ObjectInfo self) {} // 0x0000000185FC5CB0-0x0000000185FC5CD0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ObjectInfo other) => default; // 0x000000018A973C30-0x000000018A973D5C
	}

	public static class Test_HAPI_ObjectInfo_Extensions // TypeDefIndex: 50827
	{
		// Methods
		public static Test_HAPI_ObjectInfo ToTestObject(HAPI_ObjectInfo self) => default; // 0x000000018A973BD0-0x000000018A973C30
	}

	public class Test_HAPI_Transform : IEquivable<Test_HAPI_Transform> // TypeDefIndex: 50828
	{
		// Fields
		public HAPI_Transform self; // 0x10
	
		// Constructors
		public Test_HAPI_Transform() {} // Dummy constructor
		public Test_HAPI_Transform(HAPI_Transform self) {} // 0x000000018A9747FC-0x000000018A974820
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_Transform other) => default; // 0x000000018A9748A0-0x000000018A974934
	}

	public static class Test_HAPI_Transform_Extensions // TypeDefIndex: 50829
	{
		// Methods
		public static Test_HAPI_Transform ToTestObject(HAPI_Transform self) => default; // 0x000000018A974820-0x000000018A9748A0
	}

	public class Test_HAPI_GeoInfo : IEquivable<Test_HAPI_GeoInfo> // TypeDefIndex: 50830
	{
		// Fields
		public HAPI_GeoInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_GeoInfo() {} // Dummy constructor
		public Test_HAPI_GeoInfo(HAPI_GeoInfo self) {} // 0x0000000185FC5C20-0x0000000185FC5C40
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_GeoInfo other) => default; // 0x000000018A9734CC-0x000000018A9737EC
	}

	public static class Test_HAPI_GeoInfo_Extensions // TypeDefIndex: 50831
	{
		// Methods
		public static Test_HAPI_GeoInfo ToTestObject(HAPI_GeoInfo self) => default; // 0x000000018A97346C-0x000000018A9734CC
	}

	public class Test_HAPI_AttributeInfo : IEquivable<Test_HAPI_AttributeInfo> // TypeDefIndex: 50832
	{
		// Fields
		public HAPI_AttributeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AttributeInfo() {} // Dummy constructor
		public Test_HAPI_AttributeInfo(HAPI_AttributeInfo self) {} // 0x0000000185FCE620-0x0000000185FCE640
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AttributeInfo other) => default; // 0x000000018A973368-0x000000018A97346C
	}

	public static class Test_HAPI_AttributeInfo_Extensions // TypeDefIndex: 50833
	{
		// Methods
		public static Test_HAPI_AttributeInfo ToTestObject(HAPI_AttributeInfo self) => default; // 0x000000018A97330C-0x000000018A973368
	}

	public class Test_HAPI_TransformEuler : IEquivable<Test_HAPI_TransformEuler> // TypeDefIndex: 50834
	{
		// Fields
		public HAPI_TransformEuler self; // 0x10
	
		// Constructors
		public Test_HAPI_TransformEuler() {} // Dummy constructor
		public Test_HAPI_TransformEuler(HAPI_TransformEuler self) {} // 0x000000018A9747FC-0x000000018A974820
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_TransformEuler other) => default; // 0x000000018A974724-0x000000018A9747FC
	}

	public static class Test_HAPI_TransformEuler_Extensions // TypeDefIndex: 50835
	{
		// Methods
		public static Test_HAPI_TransformEuler ToTestObject(HAPI_TransformEuler self) => default; // 0x000000018A9746A4-0x000000018A974724
	}

	public class Test_HAPI_ParmInfo : IEquivable<Test_HAPI_ParmInfo> // TypeDefIndex: 50836
	{
		// Fields
		public HAPI_ParmInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ParmInfo() {} // Dummy constructor
		public Test_HAPI_ParmInfo(HAPI_ParmInfo self) {} // 0x0000000185FCE670-0x0000000185FCE6D0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ParmInfo other) => default; // 0x000000018A973DFC-0x000000018A9746A4
	}

	public static class Test_HAPI_ParmInfo_Extensions // TypeDefIndex: 50837
	{
		// Methods
		public static Test_HAPI_ParmInfo ToTestObject(HAPI_ParmInfo self) => default; // 0x000000018A973D5C-0x000000018A973DFC
	}

	public class Test_LODGroup : IEquivableWrapperClass<Test_LODGroup> // TypeDefIndex: 50838
	{
		// Fields
		public LODGroup self; // 0x10
	
		// Constructors
		public Test_LODGroup() {} // Dummy constructor
		public Test_LODGroup(LODGroup self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A974DC4-0x000000018A974E14
		public bool IsEquivalentTo(Test_LODGroup other) => default; // 0x000000018A974BA4-0x000000018A974DC4
	}

	public static class Test_LODGroup_Extensions // TypeDefIndex: 50840
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50839
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<LODGroup, Test_LODGroup> __9__1_0; // 0x08
			public static Converter<LODGroup, Test_LODGroup> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A974934-0x000000018A974994
			public __c() {} // 0x000000018A974AA0-0x000000018A974BA4
	
			// Methods
			internal Test_LODGroup _ToTestObject_b__1_0(LODGroup lod) => default; // 0x000000018A974994-0x000000018A974AA0
			internal Test_LODGroup _ToTestObject_b__2_0(LODGroup lod) => default; // 0x000000018A979BE8-0x000000018A979C4C
		}
	
		// Methods
		public static Test_LODGroup ToTestObject(LODGroup self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_LODGroup[] ToTestObject(LODGroup[] self) => default; // 0x000000018A9789C8-0x000000018A978A28
		public static List<Test_LODGroup> ToTestObject(List<LODGroup> self) => default; // 0x000000018A978F68-0x000000018A978FC8
	}

	public class Test_Transform : IEquivableWrapperClass<Test_Transform> // TypeDefIndex: 50841
	{
		// Fields
		public Transform self; // 0x10
	
		// Constructors
		public Test_Transform() {} // Dummy constructor
		public Test_Transform(Transform self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A9783F8-0x000000018A978448
		public bool IsEquivalentTo(Test_Transform other) => default; // 0x000000018A978274-0x000000018A9783F8
	}

	public static class Test_Transform_Extensions // TypeDefIndex: 50843
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50842
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Transform, Test_Transform> __9__1_0; // 0x08
			public static Converter<Transform, Test_Transform> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A978004-0x000000018A978064
			public __c() {} // 0x000000018A978170-0x000000018A978274
	
			// Methods
			internal Test_Transform _ToTestObject_b__1_0(Transform lod) => default; // 0x000000018A978064-0x000000018A978170
			internal Test_Transform _ToTestObject_b__2_0(Transform lod) => default; // 0x000000018A9796D4-0x000000018A979738
		}
	
		// Methods
		public static Test_Transform ToTestObject(Transform self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Transform[] ToTestObject(Transform[] self) => default; // 0x000000018A978A88-0x000000018A978AE8
		public static List<Test_Transform> ToTestObject(List<Transform> self) => default; // 0x000000018A979444-0x000000018A9794A4
	}

	public class Test_Material : IEquivableWrapperClass<Test_Material> // TypeDefIndex: 50844
	{
		// Fields
		public Material self; // 0x10
	
		// Constructors
		public Test_Material() {} // Dummy constructor
		public Test_Material(Material self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A975358-0x000000018A9753A8
		public bool IsEquivalentTo(Test_Material other) => default; // 0x000000018A975184-0x000000018A975358
	}

	public static class Test_Material_Extensions // TypeDefIndex: 50846
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50845
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Material, Test_Material> __9__1_0; // 0x08
			public static Converter<Material, Test_Material> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A974FF8-0x000000018A975058
			public __c() {} // 0x000000018A975058-0x000000018A975184
	
			// Methods
			internal Test_Material _ToTestObject_b__1_0(Material lod) => default; // 0x000000018A974EEC-0x000000018A974FF8
			internal Test_Material _ToTestObject_b__2_0(Material lod) => default; // 0x000000018A979738-0x000000018A97979C
		}
	
		// Methods
		public static Test_Material ToTestObject(Material self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Material[] ToTestObject(Material[] self) => default; // 0x000000018A978BA8-0x000000018A978C08
		public static List<Test_Material> ToTestObject(List<Material> self) => default; // 0x000000018A979028-0x000000018A979088
	}

	public class Test_Collider : IEquivableWrapperClass<Test_Collider> // TypeDefIndex: 50847
	{
		// Fields
		public Collider self; // 0x10
	
		// Constructors
		public Test_Collider() {} // Dummy constructor
		public Test_Collider(Collider self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A972D10-0x000000018A972D60
		public bool IsEquivalentTo(Test_Collider other) => default; // 0x000000018A97286C-0x000000018A972D10
	}

	public static class Test_Collider_Extensions // TypeDefIndex: 50849
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50848
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Collider, Test_Collider> __9__1_0; // 0x08
			public static Converter<Collider, Test_Collider> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A97280C-0x000000018A97286C
			public __c() {} // 0x000000018A972708-0x000000018A97280C
	
			// Methods
			internal Test_Collider _ToTestObject_b__1_0(Collider lod) => default; // 0x000000018A9725FC-0x000000018A972708
			internal Test_Collider _ToTestObject_b__2_0(Collider lod) => default; // 0x000000018A979800-0x000000018A979864
		}
	
		// Methods
		public static Test_Collider ToTestObject(Collider self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Collider[] ToTestObject(Collider[] self) => default; // 0x000000018A97890C-0x000000018A97896C
		public static List<Test_Collider> ToTestObject(List<Collider> self) => default; // 0x000000018A979148-0x000000018A9791A8
	}

	public class Test_BoxCollider : IEquivableWrapperClass<Test_BoxCollider> // TypeDefIndex: 50850
	{
		// Fields
		public BoxCollider self; // 0x10
	
		// Constructors
		public Test_BoxCollider() {} // Dummy constructor
		public Test_BoxCollider(BoxCollider self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A972164-0x000000018A9721B4
		public bool IsEquivalentTo(Test_BoxCollider other) => default; // 0x000000018A971FD8-0x000000018A972164
	}

	public static class Test_BoxCollider_Extensions // TypeDefIndex: 50852
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50851
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<BoxCollider, Test_BoxCollider> __9__1_0; // 0x08
			public static Converter<BoxCollider, Test_BoxCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A971F78-0x000000018A971FD8
			public __c() {} // 0x000000018A971D68-0x000000018A971E6C
	
			// Methods
			internal Test_BoxCollider _ToTestObject_b__1_0(BoxCollider lod) => default; // 0x000000018A971E6C-0x000000018A971F78
			internal Test_BoxCollider _ToTestObject_b__2_0(BoxCollider lod) => default; // 0x000000018A97960C-0x000000018A979670
		}
	
		// Methods
		public static Test_BoxCollider ToTestObject(BoxCollider self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_BoxCollider[] ToTestObject(BoxCollider[] self) => default; // 0x000000018A978A28-0x000000018A978A88
		public static List<Test_BoxCollider> ToTestObject(List<BoxCollider> self) => default; // 0x000000018A979564-0x000000018A9795C4
	}

	public class Test_SphereCollider : IEquivableWrapperClass<Test_SphereCollider> // TypeDefIndex: 50853
	{
		// Fields
		public SphereCollider self; // 0x10
	
		// Constructors
		public Test_SphereCollider() {} // Dummy constructor
		public Test_SphereCollider(SphereCollider self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A97699C-0x000000018A9769EC
		public bool IsEquivalentTo(Test_SphereCollider other) => default; // 0x000000018A976834-0x000000018A97699C
	}

	public static class Test_SphereCollider_Extensions // TypeDefIndex: 50855
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50854
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<SphereCollider, Test_SphereCollider> __9__1_0; // 0x08
			public static Converter<SphereCollider, Test_SphereCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A9766C8-0x000000018A976728
			public __c() {} // 0x000000018A9765C4-0x000000018A9766C8
	
			// Methods
			internal Test_SphereCollider _ToTestObject_b__1_0(SphereCollider lod) => default; // 0x000000018A976728-0x000000018A976834
			internal Test_SphereCollider _ToTestObject_b__2_0(SphereCollider lod) => default; // 0x000000018A9799F4-0x000000018A979A58
		}
	
		// Methods
		public static Test_SphereCollider ToTestObject(SphereCollider self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_SphereCollider[] ToTestObject(SphereCollider[] self) => default; // 0x000000018A978DE8-0x000000018A978E48
		public static List<Test_SphereCollider> ToTestObject(List<SphereCollider> self) => default; // 0x000000018A979268-0x000000018A9792C8
	}

	public class Test_CapsuleCollider : IEquivableWrapperClass<Test_CapsuleCollider> // TypeDefIndex: 50856
	{
		// Fields
		public CapsuleCollider self; // 0x10
	
		// Constructors
		public Test_CapsuleCollider() {} // Dummy constructor
		public Test_CapsuleCollider(CapsuleCollider self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A9725AC-0x000000018A9725FC
		public bool IsEquivalentTo(Test_CapsuleCollider other) => default; // 0x000000018A972424-0x000000018A9725AC
	}

	public static class Test_CapsuleCollider_Extensions // TypeDefIndex: 50858
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50857
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<CapsuleCollider, Test_CapsuleCollider> __9__1_0; // 0x08
			public static Converter<CapsuleCollider, Test_CapsuleCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A9721B4-0x000000018A972214
			public __c() {} // 0x000000018A972320-0x000000018A972424
	
			// Methods
			internal Test_CapsuleCollider _ToTestObject_b__1_0(CapsuleCollider lod) => default; // 0x000000018A972214-0x000000018A972320
			internal Test_CapsuleCollider _ToTestObject_b__2_0(CapsuleCollider lod) => default; // 0x000000018A97979C-0x000000018A979800
		}
	
		// Methods
		public static Test_CapsuleCollider ToTestObject(CapsuleCollider self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_CapsuleCollider[] ToTestObject(CapsuleCollider[] self) => default; // 0x000000018A978B48-0x000000018A978BA8
		public static List<Test_CapsuleCollider> ToTestObject(List<CapsuleCollider> self) => default; // 0x000000018A979208-0x000000018A979268
	}

	public class Test_MeshCollider : IEquivableWrapperClass<Test_MeshCollider> // TypeDefIndex: 50859
	{
		// Fields
		public MeshCollider self; // 0x10
	
		// Constructors
		public Test_MeshCollider() {} // Dummy constructor
		public Test_MeshCollider(MeshCollider self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A9756F0-0x000000018A975740
		public bool IsEquivalentTo(Test_MeshCollider other) => default; // 0x000000018A975618-0x000000018A9756F0
	}

	public static class Test_MeshCollider_Extensions // TypeDefIndex: 50861
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50860
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshCollider, Test_MeshCollider> __9__1_0; // 0x08
			public static Converter<MeshCollider, Test_MeshCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A9753A8-0x000000018A975408
			public __c() {} // 0x000000018A975408-0x000000018A97550C
	
			// Methods
			internal Test_MeshCollider _ToTestObject_b__1_0(MeshCollider lod) => default; // 0x000000018A97550C-0x000000018A975618
			internal Test_MeshCollider _ToTestObject_b__2_0(MeshCollider lod) => default; // 0x000000018A979ABC-0x000000018A979B20
		}
	
		// Methods
		public static Test_MeshCollider ToTestObject(MeshCollider self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_MeshCollider[] ToTestObject(MeshCollider[] self) => default; // 0x000000018A9788AC-0x000000018A97890C
		public static List<Test_MeshCollider> ToTestObject(List<MeshCollider> self) => default; // 0x000000018A979088-0x000000018A9790E8
	}

	public class Test_Mesh : IEquivableWrapperClass<Test_Mesh> // TypeDefIndex: 50862
	{
		// Fields
		public Mesh self; // 0x10
	
		// Constructors
		public Test_Mesh() {} // Dummy constructor
		public Test_Mesh(Mesh self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A976574-0x000000018A9765C4
		public bool IsEquivalentTo(Test_Mesh other) => default; // 0x000000018A9761B8-0x000000018A976574
	}

	public static class Test_Mesh_Extensions // TypeDefIndex: 50864
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50863
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Mesh, Test_Mesh> __9__1_0; // 0x08
			public static Converter<Mesh, Test_Mesh> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A975F48-0x000000018A975FA8
			public __c() {} // 0x000000018A9760B4-0x000000018A9761B8
	
			// Methods
			internal Test_Mesh _ToTestObject_b__1_0(Mesh lod) => default; // 0x000000018A975FA8-0x000000018A9760B4
			internal Test_Mesh _ToTestObject_b__2_0(Mesh lod) => default; // 0x000000018A979990-0x000000018A9799F4
		}
	
		// Methods
		public static Test_Mesh ToTestObject(Mesh self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Mesh[] ToTestObject(Mesh[] self) => default; // 0x000000018A978C08-0x000000018A978C68
		public static List<Test_Mesh> ToTestObject(List<Mesh> self) => default; // 0x000000018A978F08-0x000000018A978F68
	}

	public class Test_MeshRenderer : IEquivableWrapperClass<Test_MeshRenderer> // TypeDefIndex: 50865
	{
		// Fields
		public MeshRenderer self; // 0x10
	
		// Constructors
		public Test_MeshRenderer() {} // Dummy constructor
		public Test_MeshRenderer(MeshRenderer self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A975EF8-0x000000018A975F48
		public bool IsEquivalentTo(Test_MeshRenderer other) => default; // 0x000000018A975DD4-0x000000018A975EF8
	}

	public static class Test_MeshRenderer_Extensions // TypeDefIndex: 50867
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50866
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshRenderer, Test_MeshRenderer> __9__1_0; // 0x08
			public static Converter<MeshRenderer, Test_MeshRenderer> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A975B64-0x000000018A975BC4
			public __c() {} // 0x000000018A975CD0-0x000000018A975DD4
	
			// Methods
			internal Test_MeshRenderer _ToTestObject_b__1_0(MeshRenderer lod) => default; // 0x000000018A975BC4-0x000000018A975CD0
			internal Test_MeshRenderer _ToTestObject_b__2_0(MeshRenderer lod) => default; // 0x000000018A979864-0x000000018A9798C8
		}
	
		// Methods
		public static Test_MeshRenderer ToTestObject(MeshRenderer self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_MeshRenderer[] ToTestObject(MeshRenderer[] self) => default; // 0x000000018A978EA8-0x000000018A978F08
		public static List<Test_MeshRenderer> ToTestObject(List<MeshRenderer> self) => default; // 0x000000018A979504-0x000000018A979564
	}

	public class Test_MeshFilter : IEquivableWrapperClass<Test_MeshFilter> // TypeDefIndex: 50868
	{
		// Fields
		public MeshFilter self; // 0x10
	
		// Constructors
		public Test_MeshFilter() {} // Dummy constructor
		public Test_MeshFilter(MeshFilter self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A975B14-0x000000018A975B64
		public bool IsEquivalentTo(Test_MeshFilter other) => default; // 0x000000018A9759B0-0x000000018A975B14
	}

	public static class Test_MeshFilter_Extensions // TypeDefIndex: 50870
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50869
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshFilter, Test_MeshFilter> __9__1_0; // 0x08
			public static Converter<MeshFilter, Test_MeshFilter> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A975950-0x000000018A9759B0
			public __c() {} // 0x000000018A97584C-0x000000018A975950
	
			// Methods
			internal Test_MeshFilter _ToTestObject_b__1_0(MeshFilter lod) => default; // 0x000000018A975740-0x000000018A97584C
			internal Test_MeshFilter _ToTestObject_b__2_0(MeshFilter lod) => default; // 0x000000018A979CB0-0x000000018A979D14
		}
	
		// Methods
		public static Test_MeshFilter ToTestObject(MeshFilter self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_MeshFilter[] ToTestObject(MeshFilter[] self) => default; // 0x000000018A978D88-0x000000018A978DE8
		public static List<Test_MeshFilter> ToTestObject(List<MeshFilter> self) => default; // 0x000000018A978FC8-0x000000018A979028
	}

	public class Test_LayerMask : IEquivable<Test_LayerMask> // TypeDefIndex: 50871
	{
		// Fields
		public LayerMask self; // 0x10
	
		// Constructors
		public Test_LayerMask() {} // Dummy constructor
		public Test_LayerMask(LayerMask self) {} // 0x0000000181378230-0x0000000181378240
	
		// Methods
		public bool IsEquivalentTo(Test_LayerMask other) => default; // 0x000000018A974E58-0x000000018A974EEC
	}

	public static class Test_LayerMask_Extensions // TypeDefIndex: 50872
	{
		// Methods
		public static Test_LayerMask ToTestObject(LayerMask self) => default; // 0x000000018A974E14-0x000000018A974E58
	}

	public class Test_Gradient : IEquivableWrapperClass<Test_Gradient> // TypeDefIndex: 50873
	{
		// Fields
		public Gradient self; // 0x10
	
		// Constructors
		public Test_Gradient() {} // Dummy constructor
		public Test_Gradient(Gradient self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001841C04C0-0x00000001841C04D0
		public bool IsEquivalentTo(Test_Gradient other) => default; // 0x000000018A972FD0-0x000000018A9730CC
	}

	public static class Test_Gradient_Extensions // TypeDefIndex: 50875
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50874
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Gradient, Test_Gradient> __9__1_0; // 0x08
			public static Converter<Gradient, Test_Gradient> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A972F70-0x000000018A972FD0
			public __c() {} // 0x000000018A972E6C-0x000000018A972F70
	
			// Methods
			internal Test_Gradient _ToTestObject_b__1_0(Gradient lod) => default; // 0x000000018A972D60-0x000000018A972E6C
			internal Test_Gradient _ToTestObject_b__2_0(Gradient lod) => default; // 0x000000018A979A58-0x000000018A979ABC
		}
	
		// Methods
		public static Test_Gradient ToTestObject(Gradient self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Gradient[] ToTestObject(Gradient[] self) => default; // 0x000000018A978E48-0x000000018A978EA8
		public static List<Test_Gradient> ToTestObject(List<Gradient> self) => default; // 0x000000018A9790E8-0x000000018A979148
	}

	public class Test_AnimationCurve : IEquivableWrapperClass<Test_AnimationCurve> // TypeDefIndex: 50876
	{
		// Fields
		public AnimationCurve self; // 0x10
	
		// Constructors
		public Test_AnimationCurve() {} // Dummy constructor
		public Test_AnimationCurve(AnimationCurve self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x00000001841C04C0-0x00000001841C04D0
		public bool IsEquivalentTo(Test_AnimationCurve other) => default; // 0x000000018A971C7C-0x000000018A971D68
	}

	public static class Test_AnimationCurve_Extensions // TypeDefIndex: 50878
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50877
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<AnimationCurve, Test_AnimationCurve> __9__1_0; // 0x08
			public static Converter<AnimationCurve, Test_AnimationCurve> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A971A0C-0x000000018A971A6C
			public __c() {} // 0x000000018A971A6C-0x000000018A971B70
	
			// Methods
			internal Test_AnimationCurve _ToTestObject_b__1_0(AnimationCurve lod) => default; // 0x000000018A971B70-0x000000018A971C7C
			internal Test_AnimationCurve _ToTestObject_b__2_0(AnimationCurve lod) => default; // 0x000000018A97992C-0x000000018A979990
		}
	
		// Methods
		public static Test_AnimationCurve ToTestObject(AnimationCurve self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_AnimationCurve[] ToTestObject(AnimationCurve[] self) => default; // 0x000000018A978C68-0x000000018A978CC8
		public static List<Test_AnimationCurve> ToTestObject(List<AnimationCurve> self) => default; // 0x000000018A9793E4-0x000000018A979444
	}

	public class Test_TerrainLayer : IEquivableWrapperClass<Test_TerrainLayer> // TypeDefIndex: 50879
	{
		// Fields
		public TerrainLayer self; // 0x10
	
		// Constructors
		public Test_TerrainLayer() {} // Dummy constructor
		public Test_TerrainLayer(TerrainLayer self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A9777BC-0x000000018A97780C
		public bool IsEquivalentTo(Test_TerrainLayer other) => default; // 0x000000018A9773F4-0x000000018A9777BC
	}

	public static class Test_TerrainLayer_Extensions // TypeDefIndex: 50881
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50880
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TerrainLayer, Test_TerrainLayer> __9__1_0; // 0x08
			public static Converter<TerrainLayer, Test_TerrainLayer> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A977184-0x000000018A9771E4
			public __c() {} // 0x000000018A9772F0-0x000000018A9773F4
	
			// Methods
			internal Test_TerrainLayer _ToTestObject_b__1_0(TerrainLayer lod) => default; // 0x000000018A9771E4-0x000000018A9772F0
			internal Test_TerrainLayer _ToTestObject_b__2_0(TerrainLayer lod) => default; // 0x000000018A979B20-0x000000018A979B84
		}
	
		// Methods
		public static Test_TerrainLayer ToTestObject(TerrainLayer self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_TerrainLayer[] ToTestObject(TerrainLayer[] self) => default; // 0x000000018A978AE8-0x000000018A978B48
		public static List<Test_TerrainLayer> ToTestObject(List<TerrainLayer> self) => default; // 0x000000018A979384-0x000000018A9793E4
	}

	public class Test_Texture2D : IEquivableWrapperClass<Test_Texture2D> // TypeDefIndex: 50882
	{
		// Fields
		public Texture2D self; // 0x10
	
		// Constructors
		public Test_Texture2D() {} // Dummy constructor
		public Test_Texture2D(Texture2D self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A977FB4-0x000000018A978004
		public bool IsEquivalentTo(Test_Texture2D other) => default; // 0x000000018A977E88-0x000000018A977FB4
	}

	public static class Test_Texture2D_Extensions // TypeDefIndex: 50884
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50883
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Texture2D, Test_Texture2D> __9__1_0; // 0x08
			public static Converter<Texture2D, Test_Texture2D> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A977C18-0x000000018A977C78
			public __c() {} // 0x000000018A977C78-0x000000018A977D7C
	
			// Methods
			internal Test_Texture2D _ToTestObject_b__1_0(Texture2D lod) => default; // 0x000000018A977D7C-0x000000018A977E88
			internal Test_Texture2D _ToTestObject_b__2_0(Texture2D lod) => default; // 0x000000018A979C4C-0x000000018A979CB0
		}
	
		// Methods
		public static Test_Texture2D ToTestObject(Texture2D self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Texture2D[] ToTestObject(Texture2D[] self) => default; // 0x000000018A97884C-0x000000018A9788AC
		public static List<Test_Texture2D> ToTestObject(List<Texture2D> self) => default; // 0x000000018A9794A4-0x000000018A979504
	}

	public class Test_TreeInstance : IEquivable<Test_TreeInstance> // TypeDefIndex: 50885
	{
		// Fields
		public TreeInstance self; // 0x10
	
		// Constructors
		public Test_TreeInstance() {} // Dummy constructor
		public Test_TreeInstance(TreeInstance self) {} // 0x0000000185FCE620-0x0000000185FCE640
	
		// Methods
		public bool IsEquivalentTo(Test_TreeInstance other) => default; // 0x000000018A9786B4-0x000000018A97884C
	}

	public static class Test_TreeInstance_Extensions // TypeDefIndex: 50887
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50886
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TreeInstance, Test_TreeInstance> __9__1_0; // 0x08
			public static Converter<TreeInstance, Test_TreeInstance> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A97854C-0x000000018A9785A8
			public __c() {} // 0x000000018A978448-0x000000018A97854C
	
			// Methods
			internal Test_TreeInstance _ToTestObject_b__1_0(TreeInstance lod) => default; // 0x000000018A9785A8-0x000000018A9786B4
			internal Test_TreeInstance _ToTestObject_b__2_0(TreeInstance lod) => default; // 0x000000018A9798C8-0x000000018A97992C
		}
	
		// Methods
		public static Test_TreeInstance ToTestObject(TreeInstance self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_TreeInstance[] ToTestObject(TreeInstance[] self) => default; // 0x000000018A97896C-0x000000018A9789C8
		public static List<Test_TreeInstance> ToTestObject(List<TreeInstance> self) => default; // 0x000000018A9792C8-0x000000018A979324
	}

	public class Test_TerrainData : IEquivableWrapperClass<Test_TerrainData> // TypeDefIndex: 50888
	{
		// Fields
		public TerrainData self; // 0x10
	
		// Constructors
		public Test_TerrainData() {} // Dummy constructor
		public Test_TerrainData(TerrainData self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A977134-0x000000018A977184
		public bool IsEquivalentTo(Test_TerrainData other) => default; // 0x000000018A976C5C-0x000000018A977134
	}

	public static class Test_TerrainData_Extensions // TypeDefIndex: 50890
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50889
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TerrainData, Test_TerrainData> __9__1_0; // 0x08
			public static Converter<TerrainData, Test_TerrainData> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A976BFC-0x000000018A976C5C
			public __c() {} // 0x000000018A976AF8-0x000000018A976BFC
	
			// Methods
			internal Test_TerrainData _ToTestObject_b__1_0(TerrainData lod) => default; // 0x000000018A9769EC-0x000000018A976AF8
			internal Test_TerrainData _ToTestObject_b__2_0(TerrainData lod) => default; // 0x000000018A979B84-0x000000018A979BE8
		}
	
		// Methods
		public static Test_TerrainData ToTestObject(TerrainData self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_TerrainData[] ToTestObject(TerrainData[] self) => default; // 0x000000018A978D28-0x000000018A978D88
		public static List<Test_TerrainData> ToTestObject(List<TerrainData> self) => default; // 0x000000018A979324-0x000000018A979384
	}

	public class Test_Terrain : IEquivableWrapperClass<Test_Terrain> // TypeDefIndex: 50891
	{
		// Fields
		public Terrain self; // 0x10
	
		// Constructors
		public Test_Terrain() {} // Dummy constructor
		public Test_Terrain(Terrain self) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsNull() => default; // 0x000000018A977BC8-0x000000018A977C18
		public bool IsEquivalentTo(Test_Terrain other) => default; // 0x000000018A977A7C-0x000000018A977BC8
	}

	public static class Test_Terrain_Extensions // TypeDefIndex: 50893
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50892
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Terrain, Test_Terrain> __9__1_0; // 0x08
			public static Converter<Terrain, Test_Terrain> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A97780C-0x000000018A97786C
			public __c() {} // 0x000000018A97786C-0x000000018A977970
	
			// Methods
			internal Test_Terrain _ToTestObject_b__1_0(Terrain lod) => default; // 0x000000018A977970-0x000000018A977A7C
			internal Test_Terrain _ToTestObject_b__2_0(Terrain lod) => default; // 0x000000018A979670-0x000000018A9796D4
		}
	
		// Methods
		public static Test_Terrain ToTestObject(Terrain self) => default; // 0x0000000185492010-0x0000000185492020
		public static Test_Terrain[] ToTestObject(Terrain[] self) => default; // 0x000000018A978CC8-0x000000018A978D28
		public static List<Test_Terrain> ToTestObject(List<Terrain> self) => default; // 0x000000018A9791A8-0x000000018A979208
	}

	[Serializable]
	internal class HEU_ToolsInfo : ScriptableObject, IEquivable<HEU_ToolsInfo> // TypeDefIndex: 50896
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
		public enum PaintMergeMode // TypeDefIndex: 50894
		{
			REPLACE = 0,
			ADD = 1,
			SUBTRACT = 2,
			MULTIPLY = 3
		}
	
		public enum PaintMeshVisibility // TypeDefIndex: 50895
		{
			AUTO = 0,
			SHOW = 1,
			HIDE = 2
		}
	
		// Constructors
		public HEU_ToolsInfo() {} // 0x000000018A96C254-0x000000018A96C354
	
		// Methods
		public bool IsEquivalentTo(HEU_ToolsInfo other) => default; // 0x000000018A96BD10-0x000000018A96C254
	}

	public enum HFLayerType // TypeDefIndex: 50897
	{
		DEFAULT = 0,
		HEIGHT = 1,
		MASK = 2,
		DETAIL = 3
	}

	[Serializable]
	public class HEU_VolumeLayer : IEquivable<HEU_VolumeLayer> // TypeDefIndex: 50898
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
		internal HEU_PartData _part; // 0x48
	
		// Constructors
		public HEU_VolumeLayer() {} // 0x0000000185FB7390-0x0000000185FB73A0
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeLayer other) => default; // 0x000000018A96EAFC-0x000000018A96EDD8
	}

	public class HEU_VolumeScatterTrees : IEquivable<HEU_VolumeScatterTrees> // TypeDefIndex: 50899
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
		public HEU_VolumeScatterTrees() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeScatterTrees other) => default; // 0x000000018A96EDD8-0x000000018A96F0AC
	}

	public class HEU_TreePrototypeInfo : IEquivable<HEU_TreePrototypeInfo> // TypeDefIndex: 50900
	{
		// Fields
		public string _prefabPath; // 0x10
		public float _bendfactor; // 0x18
	
		// Constructors
		public HEU_TreePrototypeInfo() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsEquivalentTo(HEU_TreePrototypeInfo other) => default; // 0x000000018A96C354-0x000000018A96C468
	}

	public class HEU_DetailProperties : IEquivable<HEU_DetailProperties> // TypeDefIndex: 50901
	{
		// Fields
		public float _detailDistance; // 0x10
		public float _detailDensity; // 0x14
		public int _detailResolution; // 0x18
		public int _detailResolutionPerPatch; // 0x1C
	
		// Constructors
		public HEU_DetailProperties() {} // 0x0000000185FCE5B0-0x0000000185FCE5D0
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailProperties other) => default; // 0x000000018A967350-0x000000018A9674B0
	}

	public class HEU_DetailPrototype : IEquivable<HEU_DetailPrototype> // TypeDefIndex: 50902
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
		public HEU_DetailPrototype() {} // 0x000000018A96757C-0x000000018A967634
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailPrototype other) => default; // 0x000000018A9674B0-0x000000018A96757C
	}

	public class HEU_VolumeCache : ScriptableObject, IHEU_VolumeCache, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_VolumeCache> // TypeDefIndex: 50903
	{
		// Fields
		private HEU_GeoNode _ownerNode; // 0x18
		private List<HEU_VolumeLayer> _layers; // 0x20
		private List<HEU_VolumeLayer> _updatedLayers; // 0x28
		private int _tileIndex; // 0x30
		private bool _isDirty; // 0x34
		private string _geoName; // 0x38
		private string _objName; // 0x40
		public bool _uiExpanded; // 0x48
		private TerrainData _terrainData; // 0x50
		private HEU_VolumeScatterTrees _scatterTrees; // 0x58
		private HEU_DetailProperties _detailProperties; // 0x60
		private HEU_HoudiniAsset _parentAsset; // 0x68
	
		// Properties
		public List<HEU_VolumeLayer> Layers { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public int TileIndex { get => default; } // 0x00000001813CFF60-0x00000001813CFF70 
		public string ObjectName { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public string GeoName { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public TerrainData TerrainData { get => default; } // 0x0000000181460F60-0x0000000181460F70 
		public HEU_VolumeScatterTrees ScatterTrees { get => default; } // 0x00000001813F1630-0x00000001813F1640 
		public HEU_DetailProperties DetailProperties { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public HEU_HoudiniAsset ParentAsset { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public bool IsDirty { get => default; set {} } // 0x0000000185FB0B90-0x0000000185FB0BA0 0x0000000185FB0BB0-0x0000000185FB0BC0
		public bool UIExpanded { get => default; set {} } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
	
		// Constructors
		public HEU_VolumeCache() {} // 0x000000018A96EA78-0x000000018A96EAFC
	
		// Methods
		public HEU_SessionBase GetSession() => default; // 0x000000018A96CFC8-0x000000018A96D05C
		public void Recook() {} // 0x000000018A96E0B4-0x000000018A96E11C
		public void ResetParameters() {} // 0x000000018A96E11C-0x000000018A96E288
		public HEU_VolumeLayer GetLayer(string layerName) => default; // 0x000000018A96CE1C-0x000000018A96CF5C
		public void PopulatePreset(HEU_VolumeCachePreset cachePreset) {} // 0x000000018A96DDF0-0x000000018A96E078
		public bool ApplyPreset(HEU_VolumeCachePreset volumeCachePreset) => default; // 0x000000018A96C468-0x000000018A96C6F8
		internal static List<HEU_VolumeCache> UpdateVolumeCachesFromParts(HEU_SessionBase session, HEU_GeoNode ownerNode, List<HEU_PartData> volumeParts, List<HEU_VolumeCache> volumeCaches) => default; // 0x000000018A96E38C-0x000000018A96EA78
		internal void Initialize(HEU_GeoNode ownerNode, int tileIndex) {} // 0x000000018A96D05C-0x000000018A96D14C
		internal void StartUpdateLayers() {} // 0x000000018A96E288-0x000000018A96E300
		internal void FinishUpdateLayers() {} // 0x000000018A96CAB8-0x000000018A96CAE8
		private void GetPartLayerAttributes(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer) {} // 0x000000018A96CF5C-0x000000018A96CFC8
		private bool LoadLayerTextureFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, out Texture2D outTexture) {
			outTexture = default;
			return default;
		} // 0x000000018A96DBAC-0x000000018A96DC9C
		private bool LoadLayerFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue) => default; // 0x000000018A96D6B4-0x000000018A96D7AC
		private bool LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue) => default; // 0x000000018A96D548-0x000000018A96D6B4
		private bool LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue) => default; // 0x000000018A96DC9C-0x000000018A96DDB4
		internal void UpdateLayerFromPart(HEU_SessionBase session, HEU_PartData part) {} // 0x000000018A96E300-0x000000018A96E38C
		internal void GenerateTerrainWithAlphamaps(HEU_SessionBase session, HEU_HoudiniAsset houdiniAsset, bool bRebuild) {} // 0x000000018A96CAE8-0x000000018A96CE1C
		public void LoadLayerPropertiesFromAttributes(HEU_SessionBase session, int geoID, int partID, TerrainLayer terrainLayer, bool bNewTerrainLayer, Texture2D defaultTexture) {} // 0x000000018A96D7AC-0x000000018A96DBAC
		internal void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, bool throwWarningIfNoTileAttribute) {} // 0x000000018A96E078-0x000000018A96E0B4
		internal void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer) {} // 0x000000018A96DDB4-0x000000018A96DDF0
		internal void CopyValuesTo(HEU_VolumeCache destCache) {} // 0x000000018A96C874-0x000000018A96CAB8
		internal static void CopyDetailProperties(HEU_DetailProperties srcProp, HEU_DetailProperties destProp) {} // 0x000000018A96C6F8-0x000000018A96C728
		internal static void CopyLayer(HEU_VolumeLayer srcLayer, HEU_VolumeLayer destLayer) {} // 0x000000018A96C728-0x000000018A96C804
		internal static void CopyPrototype(HEU_DetailPrototype srcProto, HEU_DetailPrototype destProto) {} // 0x000000018A96C804-0x000000018A96C874
		internal static Texture2D LoadDefaultSplatTexture() => default; // 0x000000018A96D4E0-0x000000018A96D548
		internal static Texture2D LoadAssetTexture(string path) => default; // 0x000000018A96D414-0x000000018A96D4E0
		public bool IsEquivalentTo(HEU_VolumeCache other) => default; // 0x000000018A96D14C-0x000000018A96D414
	}
}
