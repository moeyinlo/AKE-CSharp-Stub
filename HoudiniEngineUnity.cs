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

// Image 17: HoudiniEngineUnity.dll - Assembly: HoudiniEngineUnity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 78140-78586

[CompilerGenerated]
internal sealed class __f__AnonymousType0<_owner_j__TPar, _houdiniVersionRequired_j__TPar> // TypeDefIndex: 78141
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

public class HEU_BoundingVolume : MonoBehaviour // TypeDefIndex: 78142
{
	// Properties
	public Collider BoundingCollider { get; } // 0x000000018C17E688-0x000000018C17E6C4 

	// Constructors
	public HEU_BoundingVolume(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	public List<GameObject> GetAllIntersectingObjects(); // 0x000000018C17E444-0x000000018C17E688
}

public class HEU_ExampleEvergreenQuery // TypeDefIndex: 78143
{
	// Constructors
	public HEU_ExampleEvergreenQuery(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	public static void StartQuery(); // 0x000000018C183958-0x000000018C183B40
	public static HEU_HoudiniAsset QueryHoudiniAsset(GameObject rootGO); // 0x000000018C183650-0x000000018C1837CC
	public static void CookAsset(HEU_HoudiniAsset houdiniAsset); // 0x000000018C183330-0x000000018C183344
	public static void ChangeParmsAndCook(HEU_HoudiniAsset houdiniAsset); // 0x000000018C182FCC-0x000000018C183330
	public static void QueryObjects(HEU_HoudiniAsset houdiniAsset); // 0x000000018C1837CC-0x000000018C183848
	public static void QueryGeoParts(HEU_SessionBase session, ref HAPI_GeoInfo geoInfo); // 0x000000018C18358C-0x000000018C183650
	public static void QueryPartAttributeByOwner(HEU_SessionBase session, int geoID, int partID, HAPI_AttributeOwner owner, int count, StringBuilder sb); // 0x000000018C183848-0x000000018C183958
	public static void QueryAttributeByStorageType(HEU_SessionBase session, int geoID, int partID, ref HAPI_AttributeInfo attrInfo, string attrName); // 0x000000018C183344-0x000000018C1834C0
	public static void QueryAttribute(HEU_HoudiniAsset houdiniAsset, string objName, string geoName, int partID, string attrName); // 0x000000018C1834C0-0x000000018C18358C
}

[ExecuteInEditMode]
public class HEU_ExampleInstanceCustomAttribute : MonoBehaviour // TypeDefIndex: 78144
{
	// Constructors
	public HEU_ExampleInstanceCustomAttribute(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	private void InstancerCallback(); // 0x000000018C183B40-0x000000018C183EC0
	private static void LogArray<T>(string name, T[] arr, int tupleSize);
	private static void LogAttr(HEU_OutputAttribute outAttr); // 0x000000018C183EC0-0x000000018C183FEC
}

[ExecuteInEditMode]
public class HEU_ScriptCallbackExample : MonoBehaviour // TypeDefIndex: 78145
{
	// Fields
	public string _msg; // 0x18

	// Constructors
	public HEU_ScriptCallbackExample(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	private void AssetCallbackWithMsg(string msg); // 0x000000018C19A420-0x000000018C19A4A4
	private void AssetCallbackNoMsg(); // 0x000000018C19A3CC-0x000000018C19A420
}

public class HEU_ScriptMeshInputUVLayoutExample // TypeDefIndex: 78147
{
	// Nested types
	public enum OutputMode // TypeDefIndex: 78146
	{
		COPY = 0,
		REPLACE = 1
	}

	// Constructors
	public HEU_ScriptMeshInputUVLayoutExample(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	public static void ApplyUVLayoutTo(GameObject[] gameObjects, OutputMode outputMode, string output_name_suffix); // 0x000000018C19A4A4-0x000000018C19A604
}

public class HEU_ScriptParameterExample : MonoBehaviour // TypeDefIndex: 78148
{
	// Fields
	public GameObject _evergreenGameObject; // 0x18
	private HEU_HoudiniAsset _evergreenAsset; // 0x20
	public float _updateRate; // 0x28
	public float _scale; // 0x2C

	// Constructors
	public HEU_ScriptParameterExample(); // 0x000000018C19A604-0x000000018C19A628
}

public class HEU_AssetEventReceiverTest : MonoBehaviour // TypeDefIndex: 78149
{
	// Constructors
	public HEU_AssetEventReceiverTest(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	public void ReloadCallback(HEU_ReloadEventData Data); // 0x000000018C17D390-0x000000018C17D4F4
	public void CookedCallback(HEU_CookedEventData Data); // 0x000000018C17D22C-0x000000018C17D390
	public void BakedCallback(HEU_BakedEventData Data); // 0x000000018C17D0C8-0x000000018C17D22C
}

namespace HoudiniEngineUnity
{
	public enum HEU_AssetEventType // TypeDefIndex: 78150
	{
		UNKNOWN = 0,
		RELOAD = 1,
		COOK = 2,
		BAKE_NEW = 3,
		BAKE_UPDATE = 4
	}

	public class HEU_AssetEventData // TypeDefIndex: 78151
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public bool CookSuccess; // 0x18
		public List<GameObject> OutputObjects; // 0x20
		public HEU_AssetEventType EventType; // 0x28
	
		// Constructors
		public HEU_AssetEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects); // 0x000000018C17D098-0x000000018C17D0C8
	}

	public class HEU_ReloadEventData : HEU_AssetEventData // TypeDefIndex: 78152
	{
		// Constructors
		public HEU_ReloadEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects); // 0x000000018C19A3A8-0x000000018C19A3CC
	}

	public class HEU_CookedEventData : HEU_AssetEventData // TypeDefIndex: 78153
	{
		// Constructors
		public HEU_CookedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects); // 0x000000018C17E700-0x000000018C17E724
	}

	public class HEU_BakedEventData : HEU_AssetEventData // TypeDefIndex: 78154
	{
		// Fields
		public bool IsNewBake; // 0x30
	
		// Constructors
		public HEU_BakedEventData(HEU_HoudiniAsset asset, bool successful, List<GameObject> outputObjects, bool isNewBake); // 0x000000018C17E414-0x000000018C17E444
	}

	public class HEU_PreAssetEventData // TypeDefIndex: 78155
	{
		// Fields
		public HEU_HoudiniAsset Asset; // 0x10
		public HEU_AssetEventType AssetType; // 0x18
	
		// Constructors
		public HEU_PreAssetEventData(HEU_HoudiniAsset asset, HEU_AssetEventType assetType); // 0x00000001856B50C0-0x00000001856B50E0
	}

	[Serializable]
	public class HEU_ReloadDataEvent : UnityEvent<HEU_ReloadEventData> // TypeDefIndex: 78156
	{
		// Constructors
		public HEU_ReloadDataEvent(); // 0x000000018C19A36C-0x000000018C19A3A8
	}

	[Serializable]
	public class HEU_CookedDataEvent : UnityEvent<HEU_CookedEventData> // TypeDefIndex: 78157
	{
		// Constructors
		public HEU_CookedDataEvent(); // 0x000000018C17E6C4-0x000000018C17E700
	}

	[Serializable]
	public class HEU_BakedDataEvent : UnityEvent<HEU_BakedEventData> // TypeDefIndex: 78158
	{
		// Constructors
		public HEU_BakedDataEvent(); // 0x000000018C17E3D8-0x000000018C17E414
	}

	[Serializable]
	public class HEU_PreAssetEvent : UnityEvent<HEU_PreAssetEventData> // TypeDefIndex: 78159
	{
		// Constructors
		public HEU_PreAssetEvent(); // 0x000000018C19A270-0x000000018C19A2AC
	}

	[Serializable]
	public class HEU_AssetPreset // TypeDefIndex: 78160
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
		public HEU_AssetPreset(); // 0x000000018C17E0E4-0x000000018C17E23C
	}

	[Serializable]
	public class HEU_InputPreset // TypeDefIndex: 78161
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
		public HEU_InputObjectTypeWrapper InputObjectType { get; set; } // 0x000000018C19A244-0x000000018C19A250 0x000000018C19A250-0x000000018C19A270
	
		// Constructors
		public HEU_InputPreset(); // 0x000000018C19A184-0x000000018C19A244
	}

	[Serializable]
	public class HEU_InputObjectPreset // TypeDefIndex: 78162
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
		public HEU_InputObjectPreset(); // 0x000000018C19A124-0x000000018C19A184
	}

	[Serializable]
	public class HEU_InputAssetPreset // TypeDefIndex: 78163
	{
		// Fields
		public string _gameObjectName; // 0x10
	
		// Constructors
		public HEU_InputAssetPreset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class HEU_VolumeLayerPreset // TypeDefIndex: 78164
	{
		// Fields
		public string _layerName; // 0x10
		public float _strength; // 0x18
		public bool _uiExpanded; // 0x1C
		[OptionalField(VersionAdded = 5)]
		public int _tile; // 0x20
	
		// Constructors
		public HEU_VolumeLayerPreset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class HEU_VolumeCachePreset // TypeDefIndex: 78165
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
		public HEU_VolumeCachePreset(); // 0x000000018C19AA50-0x000000018C19AAC8
	}

	[Serializable]
	internal class HEU_RecookPreset // TypeDefIndex: 78166
	{
		// Fields
		public List<HEU_VolumeCachePreset> _volumeCachePresets; // 0x10
		public List<HEU_InputPreset> _inputPresets; // 0x18
	
		// Constructors
		public HEU_RecookPreset(); // 0x000000018C19A2AC-0x000000018C19A36C
	}

	public static class HEU_AssetPresetUtility // TypeDefIndex: 78167
	{
		// Fields
		public static char[] PRESET_IDENTIFIER; // 0x00
		public static int PRESET_VERSION; // 0x08
	
		// Constructors
		static HEU_AssetPresetUtility(); // 0x000000018C17E060-0x000000018C17E0E4
	
		// Methods
		public static void SaveAssetPresetToFile(HEU_HoudiniAsset asset, string filePath); // 0x000000018C17DAA0-0x000000018C17E060
		public static void LoadPresetFileIntoAssetAndCook(HEU_HoudiniAsset asset, string filePath); // 0x000000018C17D4F4-0x000000018C17DAA0
	}

	public class HEU_Vector3SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 78168
	{
		// Constructors
		public HEU_Vector3SerializationSurrogate(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context); // 0x000000018C19A7F8-0x000000018C19A8C0
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector); // 0x000000018C19A8C0-0x000000018C19AA50
	}

	public class HEU_Vector2SerializationSurrogate : ISerializationSurrogate // TypeDefIndex: 78169
	{
		// Constructors
		public HEU_Vector2SerializationSurrogate(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		void ISerializationSurrogate.GetObjectData(object obj, SerializationInfo info, StreamingContext context); // 0x000000018C19A628-0x000000018C19A6CC
		object ISerializationSurrogate.SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector); // 0x000000018C19A6CC-0x000000018C19A7F8
	}

	internal class HEU_AssetSerializedMetaData : ScriptableObject, IEquivable<HEU_AssetSerializedMetaData> // TypeDefIndex: 78170
	{
		// Fields
		[SerializeField]
		private bool _softDeleted; // 0x18
		[SerializeField]
		private Dictionary<string, List<CurveNodeData>> _savedCurveNodeData; // 0x20
		[SerializeField]
		private Dictionary<string, HEU_InputCurveInfo> _savedInputCurveInfo; // 0x28
	
		// Properties
		public bool SoftDeleted { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public Dictionary<string, List<CurveNodeData>> SavedCurveNodeData { get; } // 0x000000018225E800-0x000000018225E810 
		public Dictionary<string, HEU_InputCurveInfo> SavedInputCurveInfo { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		public HEU_AssetSerializedMetaData(); // 0x000000018C17E2D0-0x000000018C17E398
	
		// Methods
		public bool IsEquivalentTo(HEU_AssetSerializedMetaData other); // 0x000000018C17E23C-0x000000018C17E2D0
	}

	internal class HEU_AssetUpdater // TypeDefIndex: 78171
	{
		// Constructors
		static HEU_AssetUpdater(); // 0x0000000186805BA0-0x0000000186805BB0
		public HEU_AssetUpdater(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static void OnBeforeAssemblyReload(); // 0x000000018C17E398-0x000000018C17E3D8
		private static void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void AddAssetForUpdate(HEU_HoudiniAsset asset); // 0x0000000186805BA0-0x0000000186805BB0
		public static void RemoveAsset(HEU_HoudiniAsset asset); // 0x0000000186805BA0-0x0000000186805BB0
		public static void AddNodeSyncForUpdate(HEU_BaseSync nodeSync); // 0x0000000186805BA0-0x0000000186805BB0
		public static void RemoveNodeSync(HEU_BaseSync nodeSync); // 0x0000000186805BA0-0x0000000186805BB0
		private static void OnPrefabInstanceUpdate(GameObject instance); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class CurveNodeData : IEquivable<CurveNodeData> // TypeDefIndex: 78172
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
		public CurveNodeData(); // 0x000000018C17CF0C-0x000000018C17CF6C
		public CurveNodeData(Vector3 position); // 0x000000018C17CE9C-0x000000018C17CF0C
		public CurveNodeData(Vector3 position, Quaternion rotation); // 0x000000018C17CF6C-0x000000018C17CFF4
		public CurveNodeData(Vector3 position, Quaternion rotation, Vector3 scale); // 0x000000018C17CFF4-0x000000018C17D098
		public CurveNodeData(CurveNodeData other); // 0x000000018C17CDFC-0x000000018C17CE9C
	
		// Methods
		public Quaternion GetRotation(); // 0x000000018C17CC30-0x000000018C17CC6C
		public bool IsEquivalentTo(CurveNodeData other); // 0x000000018C17CC6C-0x000000018C17CDFC
	}

	[Serializable]
	public class HEU_InputCurveInfo // TypeDefIndex: 78173
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
		public HEU_InputCurveInfo(); // 0x0000000187250310-0x0000000187250320
	
		// Methods
		public static HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HAPI_InputCurveInfo curveInfo); // 0x000000018C199EC8-0x000000018C199F4C
		public static string[] GetCurveTypeNames(); // 0x000000018C199FF4-0x000000018C19A09C
		public static string[] GetInputMethodNames(); // 0x000000018C19A09C-0x000000018C19A124
		public static string[] GetBreakpointParameterizationNames(); // 0x000000018C199F4C-0x000000018C199FF4
	}

	[Serializable]
	public enum HEU_CurveDataType // TypeDefIndex: 78174
	{
		INVALID = 0,
		GEO_COORDS_PARAM = 1,
		HAPI_COORDS_PARAM = 2,
		POSITION_ATTRIBUTE = 3
	}

	public class HEU_Curve : ScriptableObject, IHEU_Curve, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Curve> // TypeDefIndex: 78182
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
		public GameObject TargetGameObject { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public int GeoID { get; } // 0x00000001844AF510-0x00000001844AF520 
		public int PartID { get; } // 0x0000000187233000-0x0000000187233010 
		public List<CurveNodeData> CurveNodeData { get; } // 0x000000018225E800-0x000000018225E810 
		public HEU_Parameters Parameters { get; } // 0x0000000182986470-0x0000000182986480 
		public string CurveName { get; } // 0x000000018226EE80-0x000000018226EE90 
		public bool IsInputCurve { get; } // 0x000000018226EF80-0x000000018226EF90 
		public bool IsPartCurve { get; } // 0x0000000187233360-0x0000000187233370 
		public HEU_InputCurveInfo InputCurveInfo { get; } // 0x0000000187232F50-0x0000000187232F60 
		public CurveEditState EditState { get; } // 0x0000000187233600-0x0000000187233610 
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public HEU_CurveDataType CurveDataType { get; } // 0x0000000187233080-0x0000000187233090 
	
		// Nested types
		public enum CurveEditState // TypeDefIndex: 78175
		{
			INVALID = 0,
			GENERATED = 1,
			EDITING = 2,
			REQUIRES_GENERATION = 3
		}
	
		public enum Interaction // TypeDefIndex: 78176
		{
			VIEW = 0,
			ADD = 1,
			EDIT = 2
		}
	
		internal enum CurveDrawCollision // TypeDefIndex: 78177
		{
			COLLIDERS = 0,
			LAYERMASK = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0 // TypeDefIndex: 78178
		{
			// Fields
			public List<Vector3> points; // 0x10
	
			// Constructors
			public __c__DisplayClass60_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetAllPoints_b__0(CurveNodeData transform); // 0x000000018C19AAC8-0x000000018C19AB38
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_0 // TypeDefIndex: 78179
		{
			// Fields
			public List<Vector3> positions; // 0x10
			public bool hasRotations; // 0x18
			public List<Quaternion> rotations; // 0x20
			public bool hasScales; // 0x28
			public List<Vector3> scales; // 0x30
			public List<int> curveCountIndices; // 0x38
	
			// Constructors
			public __c__DisplayClass87_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _UpdateCurveInputForCurveParts_b__0(CurveNodeData data); // 0x000000018C19AB38-0x000000018C19AC58
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass88_0 // TypeDefIndex: 78180
		{
			// Fields
			public List<Vector3> positions; // 0x10
			public List<Quaternion> rotations; // 0x18
			public List<Vector3> scales; // 0x20
	
			// Constructors
			public __c__DisplayClass88_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _UpdateCurveInputForCustomAttributes_b__0(CurveNodeData data); // 0x000000018C19AC58-0x000000018C19AD48
			internal void _UpdateCurveInputForCustomAttributes_b__1(int nIndex1, int nIndex2, float fCoeff, int nInsertIndex); // 0x000000018C19AD48-0x000000018C19B030
			internal void _UpdateCurveInputForCustomAttributes_b__2(int nIndex, int nInsertIndex); // 0x000000018C19B030-0x000000018C19B210
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 78181
		{
			// Fields
			public List<Vector3> rotations; // 0x10
			public List<Vector3> scales; // 0x18
	
			// Constructors
			public __c__DisplayClass90_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _UpdatePoints_b__0(CurveNodeData data); // 0x000000018C19B210-0x000000018C19B2AC
		}
	
		// Constructors
		public HEU_Curve(); // 0x000000018C182F40-0x000000018C182FCC
	
		// Methods
		internal void SetUploadParameterPreset(bool bValue); // 0x000000018225DFC0-0x000000018225DFD0
		public HEU_SessionBase GetSession(); // 0x000000018C1802EC-0x000000018C180380
		public void Recook(); // 0x000000018C181144-0x000000018C1811B0
		public void Rebuild(); // 0x000000018C1810D8-0x000000018C181144
		public bool IsEditable(); // 0x00000001822434B0-0x00000001822434C0
		public bool IsGeoCurve(); // 0x000000018226EBE0-0x000000018226EBF0
		public void SetCurveName(string name); // 0x000000018C1813FC-0x000000018C18147C
		public void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x0262A2B4 */); // 0x000000018C181718-0x000000018C1817EC
		public void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0262A2B5 */); // 0x000000018C1815D4-0x000000018C181718
		public void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x0262A2B6 */); // 0x000000018C18147C-0x000000018C181500
		public Vector3 GetCurvePoint(int pointIndex); // 0x000000018C17FBA8-0x000000018C17FC50
		public List<CurveNodeData> GetAllPointTransforms(); // 0x000000018225E800-0x000000018225E810
		public List<Vector3> GetAllPoints(); // 0x000000018C17F970-0x000000018C17FA80
		public int GetNumPoints(); // 0x000000018C17FD30-0x000000018C17FD70
		public void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x0262A2B7 */); // 0x000000018C180674-0x000000018C18076C
		public void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0262A2B8 */); // 0x000000018C1805CC-0x000000018C180674
		public void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x0262A2B9 */); // 0x000000018C17E7C0-0x000000018C17E8B8
		public void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0262A2BA */); // 0x000000018C17E724-0x000000018C17E7C0
		public void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x0262A2BB */); // 0x000000018C1811B0-0x000000018C181248
		public void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x0262A2BC */); // 0x000000018C17E8B8-0x000000018C17E944
		public void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x0262A2BD */); // 0x000000018C181084-0x000000018C1810D8
		public void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x0262A2BE */); // 0x000000018C1813C8-0x000000018C1813FC
		public Vector3 GetTransformedPoint(int pointIndex); // 0x000000018C180380-0x000000018C180448
		public List<Vector3> GetTransformedPoints(); // 0x000000018C180448-0x000000018C18055C
		public List<CurveNodeData> DuplicateCurveNodeData(); // 0x000000018C17F00C-0x000000018C17F1E4
		internal static HEU_Curve CreateSetupCurve(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool isEditable, string curveName, int geoID, int partID, bool bGeoCurve); // 0x000000018C17E944-0x000000018C17ECE4
		private void UsePreviousCurveData(string curveName); // 0x000000018C182CD4-0x000000018C182F40
		private HEU_CurveDataType GetCurveDataType(HEU_SessionBase session); // 0x000000018C17FB60-0x000000018C17FBA8
		internal bool ShouldKeepNode(HEU_SessionBase session); // 0x000000018C1817EC-0x000000018C181844
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x0262A2BF */); // 0x000000018C17ECE4-0x000000018C17EF14
		internal void UploadParameterPreset(HEU_SessionBase session, int geoID, HEU_HoudiniAsset parentAsset); // 0x000000018C182B6C-0x000000018C182C58
		internal void ResetCurveParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x000000018C181248-0x000000018C18130C
		internal void SetCurveParameterPreset(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, byte[] parameterPreset); // 0x000000018C181500-0x000000018C1815D4
		internal void UpdateCurve(HEU_SessionBase session, int partId); // 0x000000018C1822E0-0x000000018C182410
		private static int[] GetCurveCounts(HEU_SessionBase session, int geoId, int partID); // 0x000000018C17FAF0-0x000000018C17FB60
		internal void GenerateMesh(GameObject inGameObject, HEU_SessionBase session); // 0x000000018C17F594-0x000000018C17F970
		internal void GenerateMeshForSingleObject(GameObject targetObject, Vector3[] vertexList); // 0x000000018C17F1E4-0x000000018C17F594
		internal void OnPresyncParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x000000018C180A8C-0x000000018C180AC4
		internal static int GetOrderForCurveType(int requestedOrder, HAPI_CurveType curveType); // 0x000000018C17FD70-0x000000018C17FDBC
		internal bool UpdateCurveInputForCurveParts(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x000000018C1819F4-0x000000018C181F44
		internal bool UpdateCurveInputForCustomAttributes(HEU_SessionBase session, HEU_HoudiniAsset parentAsset); // 0x000000018C181F44-0x000000018C1822E0
		internal void SyncFromParameters(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bNewCurve); // 0x000000018C181844-0x000000018C1818EC
		private void UpdatePoints(HEU_SessionBase session); // 0x000000018C182410-0x000000018C182B6C
		internal void ProjectToCollidersInternal(HEU_HoudiniAsset parentAsset, Vector3 rayDirection, float rayDistance); // 0x000000018C180AC4-0x000000018C181084
		public static string GetPointsString(List<CurveNodeData> points); // 0x000000018C180048-0x000000018C1802EC
		public static string GetPointsString(List<Vector3> points); // 0x000000018C17FDBC-0x000000018C180048
		internal void SetEditState(CurveEditState editState); // 0x0000000187233630-0x0000000187233640
		internal Vector3 GetTransformedPosition(Vector3 inPosition); // 0x000000018C18055C-0x000000018C1805CC
		internal Vector3 GetInvertedTransformedPosition(Vector3 inPosition); // 0x000000018C17FCC0-0x000000018C17FD30
		internal Vector3 GetInvertedTransformedDirection(Vector3 inPosition); // 0x000000018C17FC50-0x000000018C17FCC0
		internal Vector3[] GetVertices(); // 0x0000000182262130-0x0000000182262140
		internal void SetCurveGeometryVisibilityInternal(bool bVisible); // 0x000000018C18130C-0x000000018C1813C8
		internal void DownloadPresetData(HEU_SessionBase session); // 0x000000018C17EF90-0x000000018C17F00C
		internal void UploadPresetData(HEU_SessionBase session); // 0x000000018C182C58-0x000000018C182CD4
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session); // 0x000000018C17EF14-0x000000018C17EF90
		private void UpdateCachedCurveInfo(HEU_SessionBase session, bool copyCurveSettings); // 0x000000018C1818EC-0x000000018C1819F4
		internal int GetCurveCountIndexFromPositionIndex(int positionIndex); // 0x000000018C17FA80-0x000000018C17FAF0
		private static bool IsMeshCurve(HEU_SessionBase session, int geoID, int partID); // 0x000000018C180A64-0x000000018C180A8C
		public bool IsEquivalentTo(HEU_Curve other); // 0x000000018C18076C-0x000000018C180A64
	}

	[Serializable]
	public class HEU_GeneratedOutput : IEquivable<HEU_GeneratedOutput> // TypeDefIndex: 78183
	{
		// Fields
		public HEU_GeneratedOutputData _outputData; // 0x10
		public List<HEU_GeneratedOutputData> _childOutputs; // 0x18
		[SerializeField]
		private bool isInstancer; // 0x20
	
		// Properties
		public bool IsInstancer { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
	
		// Constructors
		public HEU_GeneratedOutput(); // 0x000000018C1854BC-0x000000018C185568
	
		// Methods
		public static void ResetMaterialOverrides(HEU_GeneratedOutput output); // 0x000000018C185244-0x000000018C185390
		public static void ResetMaterialOverrides(HEU_GeneratedOutputData outputData); // 0x000000018C185390-0x000000018C185448
		public static Material[] GetGeneratedMaterialsForGameObject(HEU_GeneratedOutput output, GameObject inGameObject); // 0x000000018C184BEC-0x000000018C184DA8
		public static bool HasLODGroup(HEU_GeneratedOutput output); // 0x000000018C184DA8-0x000000018C184DF0
		public static bool IsOutputUsingMaterial(Material checkMaterial, HEU_GeneratedOutput output); // 0x000000018C1850DC-0x000000018C185244
		public static bool IsOutputDataUsingMaterial(Material checkMaterial, HEU_GeneratedOutputData outputData); // 0x000000018C184F6C-0x000000018C1850DC
		public static void ClearGeneratedMaterialReferences(HEU_GeneratedOutputData generatedOutputData); // 0x000000018C184364-0x000000018C184388
		public static void DestroyAllGeneratedColliders(HEU_GeneratedOutputData outputData); // 0x000000018C1846B0-0x000000018C184888
		public static void DestroyGeneratedOutput(HEU_GeneratedOutput generatedOutput); // 0x000000018C184A44-0x000000018C184BEC
		public static void DestroyGeneratedOutputChildren(HEU_GeneratedOutput generatedOutput); // 0x000000018C184888-0x000000018C1849EC
		public static void DestroyGeneratedOutputData(HEU_GeneratedOutputData generatedOutputData, bool bDontDeletePersistantResources); // 0x000000018C1849EC-0x000000018C184A44
		public static void ClearMaterialsNoLongerUsed(Material[] materialsToCheck, Material[] materialsInUse); // 0x000000018C184388-0x000000018C184464
		public static void CopyMaterialOverrides(HEU_GeneratedOutputData sourceOutputData, HEU_GeneratedOutputData destOutputData); // 0x000000018C184464-0x000000018C1846B0
		internal void WriteOutputToAssetCache(GameObject parentObject, string outputPath, bool bIsInstancer); // 0x000000018C185448-0x000000018C1854BC
		internal static void BakeGameObjectComponents(GameObject sourceGO, GameObject targetGO, string assetName, string outputPath, bool bIsInstancer); // 0x000000018C184218-0x000000018C184364
		public bool IsEquivalentTo(HEU_GeneratedOutput other); // 0x000000018C184DF0-0x000000018C184F6C
	}

	[Serializable]
	public class HEU_GeneratedOutputData : IEquivable<HEU_GeneratedOutputData> // TypeDefIndex: 78184
	{
		// Fields
		public GameObject _gameObject; // 0x10
		public Material[] _renderMaterials; // 0x18
		public List<Collider> _colliders; // 0x20
	
		// Constructors
		public HEU_GeneratedOutputData(); // 0x000000018C1841A0-0x000000018C184218
	
		// Methods
		public bool IsEquivalentTo(HEU_GeneratedOutputData other); // 0x000000018C183FEC-0x000000018C1841A0
	}

	public class HEU_GeoNode : ScriptableObject, IHEU_GeoNode, IHEU_HoudiniAssetSubcomponent, ISerializationCallbackReceiver, IEquivable<HEU_GeoNode> // TypeDefIndex: 78185
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
		public HEU_HoudiniAsset ParentAsset { get; } // 0x000000018C189410-0x000000018C18947C 
		public int GeoID { get; } // 0x000000018226A850-0x000000018226A860 
		public HAPI_GeoInfo GeoInfo { get; } // 0x0000000187248950-0x0000000187248970 
		public string GeoName { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public HAPI_GeoType GeoType { get; } // 0x00000001844AF510-0x00000001844AF520 
		public bool Editable { get; } // 0x000000018223FE80-0x000000018223FE90 
		public bool Displayable { get; } // 0x000000018C189390-0x000000018C189410 
		public List<HEU_PartData> Parts { get; } // 0x000000018226EE80-0x000000018226EE90 
		public HEU_ObjectNode ObjectNode { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public HEU_InputNode InputNode { get; } // 0x0000000187232F70-0x0000000187232F80 
		public HEU_Curve GeoCurve { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public List<HEU_VolumeCache> VolumeCaches { get; } // 0x0000000187232FC0-0x0000000187232FD0 
	
		// Constructors
		public HEU_GeoNode(); // 0x000000018C189370-0x000000018C189390
	
		// Methods
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnAfterDeserialize(); // 0x000000018C187578-0x000000018C187670
		public HEU_SessionBase GetSession(); // 0x000000018C186CB8-0x000000018C186D5C
		public void Recook(); // 0x000000018C1886B0-0x000000018C188724
		public bool IsVisible(); // 0x000000018C18755C-0x000000018C187578
		public bool IsIntermediate(); // 0x0000000187834660-0x0000000187834668
		public bool IsIntermediateOrEditable(); // 0x000000018C187414-0x000000018C18742C
		public bool IsGeoInputType(); // 0x000000018C187400-0x000000018C187414
		public bool IsGeoCurveType(); // 0x000000018783D5F4-0x000000018783D5FC
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x0262A2C9 */); // 0x000000018C1858B8-0x000000018C185A94
		public void RemoveAndDestroyPart(HEU_PartData part); // 0x000000018C188724-0x000000018C188788
		public void GetOutputGameObjects(List<GameObject> outputObjects); // 0x000000018C1868D8-0x000000018C186A00
		public void GetOutput(List<HEU_GeneratedOutput> outputs); // 0x000000018C186A00-0x000000018C186B28
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject); // 0x000000018C18677C-0x000000018C1868D8
		public HEU_PartData GetPartFromPartID(int partID); // 0x000000018C186B28-0x000000018C186BD8
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly); // 0x000000018C1861DC-0x000000018C1863D8
		public List<HEU_PartData> GetParts(); // 0x000000018226EE80-0x000000018226EE90
		public void HideAllGeometry(); // 0x000000018C186FE8-0x000000018C18707C
		public void DisableAllColliders(); // 0x000000018C185C20-0x000000018C185CB4
		public HEU_VolumeCache GetVolumeCacheByTileIndex(int tileIndex); // 0x000000018C186D5C-0x000000018C186E98
		internal void Reset(); // 0x000000018C188788-0x000000018C18884C
		internal void Initialize(HEU_SessionBase session, HAPI_GeoInfo geoInfo, HEU_ObjectNode containerObjectNode); // 0x000000018C18707C-0x000000018C187198
		internal bool DoesThisRequirePotentialCook(); // 0x000000018C185CB4-0x000000018C185CFC
		internal void UpdateGeo(HEU_SessionBase session); // 0x000000018C188FD8-0x000000018C189370
		internal void ProcessUnityScriptAttribute(HEU_SessionBase session); // 0x000000018C188020-0x000000018C1881C8
		private void ProcessPart(HEU_SessionBase session, int partID, ref HAPI_PartInfo partInfo, ref HEU_PartData partData); // 0x000000018C187878-0x000000018C188020
		private void SetupGameObjectAndTransform(HEU_PartData partData, HEU_HoudiniAsset parentAsset); // 0x000000018C188B00-0x000000018C188DB0
		internal void GetPartsByOutputType(List<HEU_PartData> meshParts, List<HEU_PartData> volumeParts); // 0x000000018C186BD8-0x000000018C186CB8
		internal void GeneratePartInstances(HEU_SessionBase session); // 0x000000018C185E74-0x000000018C1860B4
		internal void GenerateAttributesStore(HEU_SessionBase session); // 0x000000018C185CFC-0x000000018C185D9C
		private void ProcessGeoCurve(HEU_SessionBase session); // 0x000000018C187670-0x000000018C187878
		private void SetupGeoCurveGameObjectAndTransform(HEU_Curve curve); // 0x000000018C188DB0-0x000000018C188F7C
		internal void ClearObjectInstances(); // 0x000000018C185830-0x000000018C1858B8
		internal void SetGeoInfo(HAPI_GeoInfo geoInfo); // 0x000000018C188A7C-0x000000018C188B00
		internal string GeneratePartFullName(string partName); // 0x000000018C185D9C-0x000000018C185E74
		internal string GenerateGeoCurveName(); // 0x000000018226EEA0-0x000000018226EEB0
		internal bool HasGeoNodeChanged(HEU_SessionBase session); // 0x000000018C186FB0-0x000000018C186FE8
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform); // 0x000000018C185568-0x000000018C185690
		internal void GetDebugInfo(StringBuilder sb); // 0x000000018C1863D8-0x000000018C18677C
		internal bool IsUsingMaterial(HEU_MaterialData materialData); // 0x000000018C18742C-0x000000018C18755C
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x000000018C1860B4-0x000000018C1861DC
		internal bool HasAttribInstancer(); // 0x000000018C186E98-0x000000018C186FB0
		internal void SetAttributeModifiersOnPartOutputs(HEU_SessionBase session); // 0x000000018C18884C-0x000000018C188A7C
		internal void CalculateVisiblity(bool bParentVisibility); // 0x000000018C185720-0x000000018C185830
		internal void CalculateColliderState(); // 0x000000018C185690-0x000000018C185720
		internal void ProcessVolumeParts(HEU_SessionBase session, List<HEU_PartData> volumeParts, bool bRebuild); // 0x000000018C1881C8-0x000000018C1886B0
		internal void DestroyVolumeCache(); // 0x000000018C185A94-0x000000018C185C20
		public override string ToString(); // 0x000000018C188F7C-0x000000018C188FD8
		public bool IsEquivalentTo(HEU_GeoNode other); // 0x000000018C187198-0x000000018C187400
	}

	[ExecuteInEditMode]
	public sealed class HEU_HoudiniAsset : MonoBehaviour, IHEU_HoudiniAsset, IEquivable<HEU_HoudiniAsset> // TypeDefIndex: 78195
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
		public bool LoadAssetFromMemory { get; set; } // 0x000000018723B680-0x000000018723B690 0x000000018723B6A0-0x000000018723B6B0
		public bool AlwaysOverwriteOnLoad { get; set; } // 0x000000018723FA10-0x000000018723FA20 0x000000018723FA30-0x000000018723FA40
		public bool GenerateUVs { get; set; } // 0x000000018723D860-0x000000018723D870 0x000000018723D9C0-0x000000018723D9D0
		public bool GenerateTangents { get; set; } // 0x0000000187250120-0x0000000187250130 0x0000000187250290-0x00000001872502A0
		public bool GenerateNormals { get; set; } // 0x0000000187250110-0x0000000187250120 0x0000000187250280-0x0000000187250290
		public bool PushTransformToHoudini { get; set; } // 0x0000000187250190-0x00000001872501A0 0x00000001872502C0-0x00000001872502D0
		public bool TransformChangeTriggersCooks { get; set; } // 0x00000001872501C0-0x00000001872501D0 0x00000001872502E0-0x00000001872502F0
		public bool CookingTriggersDownCooks { get; set; } // 0x00000001872500A0-0x00000001872500B0 0x0000000187250210-0x0000000187250220
		public bool AutoCookOnParameterChange { get; set; } // 0x0000000187250080-0x0000000187250090 0x00000001872501F0-0x0000000187250200
		public bool IgnoreNonDisplayNodes { get; set; } // 0x0000000187250140-0x0000000187250150 0x00000001872502B0-0x00000001872502C0
		public bool UseOutputNodes { get; set; } // 0x00000001872501E0-0x00000001872501F0 0x0000000187250300-0x0000000187250310
		public bool GenerateMeshUsingPoints { get; set; } // 0x0000000187250100-0x0000000187250110 0x0000000187250270-0x0000000187250280
		public bool UseLODGroups { get; set; } // 0x00000001872501D0-0x00000001872501E0 0x00000001872502F0-0x0000000187250300
		public bool SplitGeosByGroup { get; set; } // 0x00000001872501B0-0x00000001872501C0 0x00000001872502D0-0x00000001872502E0
		public bool SessionSyncAutoCook { get; set; } // 0x000000018723C420-0x000000018723C430 0x000000018723C4D0-0x000000018723C4E0
		public bool BakeUpdateKeepPreviousTransformValues { get; set; } // 0x0000000187250090-0x00000001872500A0 0x0000000187250200-0x0000000187250210
		public bool PauseCooking { get; set; } // 0x000000018723E770-0x000000018723E780 0x000000018723E790-0x000000018723E7A0
		public bool CurveEditorEnabled { get; set; } // 0x000000018723E780-0x000000018723E790 0x000000018723E7A0-0x000000018723E7B0
		public HEU_CurveDrawCollisionWrapper CurveDrawCollision { get; set; } // 0x000000018C199E58-0x000000018C199E68 0x000000018C199E8C-0x000000018C199EAC
		public LayerMask CurveDrawLayerMask { get; set; } // 0x0000000187250010-0x0000000187250020 0x0000000187250040-0x0000000187250050
		public float CurveProjectMaxDistance { get; set; } // 0x0000000187240860-0x0000000187240870 0x00000001872408F0-0x0000000187240900
		public Vector3 CurveProjectDirection { get; set; } // 0x0000000187240840-0x0000000187240860 0x00000001872408D0-0x00000001872408F0
		public bool CurveProjectDirectionToView { get; set; } // 0x00000001872500E0-0x00000001872500F0 0x0000000187250250-0x0000000187250260
		public bool CurveDisableScaleRotation { get; set; } // 0x000000018723B910-0x000000018723B920 0x0000000187250220-0x0000000187250230
		public bool CurveFrameSelectedNodes { get; set; } // 0x00000001872500D0-0x00000001872500E0 0x0000000187250240-0x0000000187250250
		public float CurveFrameSelectedNodeDistance { get; set; } // 0x00000001872500C0-0x00000001872500D0 0x0000000187250230-0x0000000187250240
		public bool HandlesEnabled { get; set; } // 0x0000000187250130-0x0000000187250140 0x00000001872502A0-0x00000001872502B0
		public bool EditableNodesToolsEnabled { get; set; } // 0x00000001872500F0-0x0000000187250100 0x0000000187250260-0x0000000187250270
		public HEU_AssetTypeWrapper AssetType { get; } // 0x000000018C199E1C-0x000000018C199E48 
		public HAPI_AssetInfo AssetInfo { get; } // 0x0000000187250050-0x0000000187250080 
		public HAPI_NodeInfo NodeInfo { get; } // 0x0000000187250150-0x0000000187250180 
		public string AssetName { get; } // 0x0000000187232F60-0x0000000187232F70 
		public string AssetOpName { get; } // 0x0000000187232FB0-0x0000000187232FC0 
		public string AssetHelp { get; } // 0x0000000187232F90-0x0000000187232FA0 
		public int AssetID { get; } // 0x000000018723B930-0x000000018723B940 
		public string AssetPath { get; } // 0x0000000187236200-0x0000000187236210 
		public GameObject OwnerGameObject { get; } // 0x0000000187834B68-0x0000000187834B70 
		public GameObject RootGameObject { get; } // 0x00000001872360B0-0x00000001872360C0 
		public List<HEU_MaterialData> MaterialCache { get; } // 0x00000001872354B0-0x00000001872354C0 
		public HEU_Parameters Parameters { get; } // 0x000000018723C070-0x000000018723C080 
		public string AssetCacheFolder { get; } // 0x000000018723BE50-0x000000018723BE60 
		public string[] SubassetNames { get; } // 0x000000018723BEA0-0x000000018723BEB0 
		public int SelectedSubassetIndex { get; } // 0x00000001872501A0-0x00000001872501B0 
		public HEU_AssetCookStatusWrapper CookStatus { get; } // 0x000000018C199E48-0x000000018C199E58 
		public HEU_AssetCookResultWrapper LastCookResult { get; } // 0x000000018C199E68-0x000000018C199E8C 
		public long SessionID { get; } // 0x000000018723B990-0x000000018723B9A0 
		public List<HEU_Curve> Curves { get; } // 0x000000018723C100-0x000000018723C110 
		public List<HEU_InputNode> InputNodes { get; } // 0x000000018723BD00-0x000000018723BD10 
		public List<HEU_VolumeCache> VolumeCaches { get; } // 0x000000018723BEC0-0x000000018723BED0 
		public HEU_ReloadDataEvent ReloadDataEvent { get; } // 0x000000018723BDE0-0x000000018723BDF0 
		public HEU_CookedDataEvent CookedDataEvent { get; } // 0x000000018723BD90-0x000000018723BDA0 
		public HEU_BakedDataEvent BakedDataEvent { get; } // 0x000000018723BE80-0x000000018723BE90 
		public HEU_PreAssetEvent PreAssetEvent { get; } // 0x000000018723BE70-0x000000018723BE80 
		internal HEU_AssetType AssetTypeInternal { get; } // 0x00000001844AF510-0x00000001844AF520 
		internal bool WarnedPrefabNotSupported { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018429EF40-0x000000018429EF50 0x000000018429EFF0-0x000000018429F000
		internal HEU_InstanceInputUIState InstanceInputUIState { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x0000000188DC4728-0x0000000188DC473C
		internal UpdateUIDelegate RefreshUIDelegate { get; set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		internal HEU_Curve.CurveDrawCollision CurveDrawCollisionInternal { get; } // 0x00000001872500B0-0x00000001872500C0 
		internal List<HEU_Handle> Handles { get; } // 0x000000018723B240-0x000000018723B250 
		internal List<HEU_AttributesStore> AttributeStores { get; } // 0x000000018723BEB0-0x000000018723BEC0 
		internal HEU_ToolsInfo ToolsInfo { get; } // 0x000000018723BCE0-0x000000018723BCF0 
		internal HEU_AssetSerializedMetaData SerializedMetaData { get; } // 0x000000018723C030-0x000000018723C040 
		internal bool PendingAutoCookOnMouseRelease { get; set; } // 0x0000000187250180-0x0000000187250190 0x000000018C199EAC-0x000000018C199EC8
	
		// Nested types
		internal enum HEU_AssetType // TypeDefIndex: 78186
		{
			TYPE_INVALID = 0,
			TYPE_HDA = 1,
			TYPE_CURVE = 2,
			TYPE_INPUT = 3
		}
	
		internal enum AssetBuildAction // TypeDefIndex: 78187
		{
			NONE = 0,
			RELOAD = 1,
			COOK = 2,
			INVALID = 3,
			STRIP_HEDATA = 4,
			DUPLICATE = 5,
			RESET_PARAMS = 6
		}
	
		internal enum AssetCookStatus // TypeDefIndex: 78188
		{
			NONE = 0,
			COOKING = 1,
			POSTCOOK = 2,
			LOADING = 3,
			POSTLOAD = 4,
			PRELOAD = 5,
			SELECT_SUBASSET = 6
		}
	
		internal enum AssetCookResult // TypeDefIndex: 78189
		{
			NONE = 0,
			SUCCESS = 1,
			ERRORED = 2
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 78190; 0x0000000185B44B70-0x0000000185B44B80
	
		private enum AssetInstantiationMethod // TypeDefIndex: 78191
		{
			DEFAULT = 0,
			DUPLICATED = 1,
			UNDO = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass262_0 // TypeDefIndex: 78192
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass262_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _BakeToExistingPrefab_b__0(Transform trans); // 0x000000018C1AFD1C-0x000000018C1AFDD4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78193
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
			static __c(); // 0x000000018C1B00E0-0x000000018C1B0144
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetNonParameterInputNodes_b__274_0(HEU_InputNode node); // 0x000000018C1AFC38-0x000000018C1AFC84
			internal bool _DoPostCookWork_b__312_0(HEU_ObjectNode obj); // 0x000000018C1AFBEC-0x000000018C1AFC38
			internal bool _UploadCurvesParameters_b__335_0(HEU_Curve curve); // 0x000000018C1AFCD0-0x000000018C1AFD1C
			internal bool _UploadAttributeValues_b__336_0(HEU_AttributesStore store); // 0x000000018C1AFC84-0x000000018C1AFCD0
			internal bool _ClearInvalidCurves_b__373_0(HEU_Curve curve); // 0x000000018C1AFAA4-0x000000018C1AFAF0
			internal bool _ClearInvalidLists_b__404_0(HEU_ObjectNode node); // 0x000000018C1AFAF0-0x000000018C1AFB3C
			internal bool _ClearInvalidLists_b__404_1(HEU_Curve curve); // 0x000000018C1AFB3C-0x000000018C1AFB88
			internal bool _ClearInvalidLists_b__404_2(HEU_MaterialData data); // 0x000000018C1AFB88-0x000000018C1AFBD4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass405_0 // TypeDefIndex: 78194
		{
			// Fields
			public HEU_HoudiniAsset newAsset; // 0x10
			public int i; // 0x18
			public Predicate<HEU_Curve> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass405_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CopyPropertiesTo_b__0(HEU_Curve curve); // 0x000000018C1AFDD4-0x000000018C1AFE54
		}
	
		// Constructors
		public HEU_HoudiniAsset(); // 0x000000018C199B90-0x000000018C199E1C
	
		// Methods
		internal AssetCookStatus GetCookStatus(); // 0x0000000187233DD0-0x0000000187233DE0
		internal AssetCookResult GetLastCookResult(); // 0x000000018723E950-0x000000018723E960
		internal List<Collider> GetCurveDrawColliders(); // 0x00000001872347A0-0x00000001872347B0
		internal LayerMask GetCurveDrawLayerMask(); // 0x0000000187250010-0x0000000187250020
		internal void SetCurveDrawLayerMask(LayerMask mask); // 0x0000000187250040-0x0000000187250050
		public bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x0262A2CA */, bool bAsync = false /* Metadata: 0x0262A2CB */, bool bSkipCookCheck = true /* Metadata: 0x0262A2CC */, bool bUploadParameters = true /* Metadata: 0x0262A2CD */); // 0x00000001851A4410-0x00000001851A4420
		public bool RequestReload(bool bAsync = false /* Metadata: 0x0262A2CE */); // 0x00000001851A4410-0x00000001851A4420
		public bool RequestResetParameters(bool bAsync = false /* Metadata: 0x0262A2CF */); // 0x00000001851A4410-0x00000001851A4420
		public GameObject DuplicateAsset(GameObject newRootGameObject = null); // 0x000000018C18EDB4-0x000000018C18F140
		public bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x0262A2D0 */); // 0x000000018C18E0E8-0x000000018C18E380
		public GameObject BakeToNewPrefab(string destinationPrefabPath = null); // 0x000000018C18B210-0x000000018C18B544
		public GameObject BakeToNewStandalone(); // 0x000000018C18B544-0x000000018C18B6B0
		public bool BakeToExistingPrefab(GameObject bakeTargetGO); // 0x000000018C18A0CC-0x000000018C18A610
		public bool BakeToExistingStandalone(GameObject bakeTargetGO); // 0x000000018C18A610-0x000000018C18B210
		public bool IsAssetValid(); // 0x000000018C193C4C-0x000000018C193C88
		public bool GetOutputGameObjects(List<GameObject> outputObjects); // 0x000000018C1923B0-0x000000018C1924DC
		public bool GetOutput(List<HEU_GeneratedOutput> outputs); // 0x000000018C192604-0x000000018C192730
		public HEU_Curve GetCurve(string curveName); // 0x000000018C190D10-0x000000018C190E80
		public bool AddCurveDrawCollider(Collider newCollider); // 0x000000018C1895D0-0x000000018C189658
		public bool RemoveCurveDrawCollider(Collider collider); // 0x000000018C19652C-0x000000018C196588
		public bool ClearCurveDrawColliders(); // 0x000000018C18BEB8-0x000000018C18BF04
		public HEU_InputNode GetInputNode(string inputName); // 0x000000018C191430-0x000000018C191574
		public HEU_InputNode GetAssetInputNode(string inputName); // 0x000000018C1901FC-0x000000018C190348
		public HEU_InputNode GetInputNodeByIndex(int index); // 0x000000018C1913BC-0x000000018C191430
		public List<HEU_InputNode> GetNonParameterInputNodes(); // 0x000000018C191A6C-0x000000018C191DFC
		public int GetVolumeCacheCount(); // 0x000000018C192A24-0x000000018C192A68
		public HEU_SessionBase GetAssetSession(bool bCreateIfInvalid); // 0x000000018C190A08-0x000000018C190A80
		public HEU_ObjectNode GetObjectNodeByName(string objName); // 0x000000018C191DFC-0x000000018C1920D0
		public void GetOutputGeoNodes(List<HEU_GeoNode> outputGeoNodes); // 0x000000018C1924DC-0x000000018C192604
		public HEU_PartData GetInternalHDAPartWithGameObject(GameObject outputGameObject); // 0x000000018C1917AC-0x000000018C19190C
		public void ResetParametersToDefault(); // 0x000000018C1971C8-0x000000018C1975B4
		public void HideAllGeometry(); // 0x000000018C19302C-0x000000018C193144
		public void DisableAllColliders(); // 0x000000018C18E3E4-0x000000018C18E4FC
		public HEU_MaterialData GetMaterialData(Material material); // 0x000000018C19190C-0x000000018C191A6C
		public void ClearMaterialCache(); // 0x000000018C18C314-0x000000018C18C35C
		public void RemoveMaterial(Material material); // 0x000000018C196690-0x000000018C1967A8
		public void ResetMaterialOverrides(); // 0x000000018C19705C-0x000000018C1971C8
		public HEU_AssetPreset GetAssetPreset(bool sceneRelativeGameObjects); // 0x000000018C190348-0x000000018C190A08
		public HEU_PDGAssetLink GetOrCreatePDGAssetLink(); // 0x000000018C192248-0x000000018C1923B0
		public static HEU_HoudiniAssetRoot InstantiateHDA(string filePath, bool bAsync = false /* Metadata: 0x0262A2D1 */, Vector3 initialPosition = default); // 0x000000018C19314C-0x000000018C193214
		public static HEU_PartData GetSceneHDAPartWithGameObject(GameObject outputGameObject); // 0x000000018C192850-0x000000018C19298C
		public static HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(GameObject outputGameObject); // 0x000000018C192730-0x000000018C192850
		public static bool IsHoudiniAssetOutput(GameObject go); // 0x000000018C194B88-0x000000018C194CB4
		public static bool IsHoudiniAssetRoot(GameObject go); // 0x000000018C194CB4-0x000000018C194D20
		internal void SetupAsset(HEU_AssetType assetType, string filePath, GameObject rootGameObject, HEU_SessionBase session); // 0x000000018C197960-0x000000018C197D5C
		internal void CleanUpAndDisable(); // 0x000000018C18B8E0-0x000000018C18B95C
		internal bool IsAssetSavedInScene(); // 0x000000018C193BFC-0x000000018C193C18
		private void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		internal void InvalidateAsset(); // 0x0000000187250020-0x0000000187250030
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		internal void AssetUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		internal void PostAssetUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		internal void RequestBakeInPlace(); // 0x000000018C196D80-0x000000018C196D94
		internal void ClearBuildRequest(); // 0x000000018724FFF0-0x0000000187250010
		private bool HasValidAssetPath(); // 0x000000018C193014-0x000000018C19302C
		private void ProcessRebuild(bool bPromptForSubasset, int desiredSubassetIndex); // 0x000000018C195E40-0x000000018C196078
		private void InvokeReloadEvent(bool bCookSuccess, List<GameObject> outputObjects); // 0x000000018C193B40-0x000000018C193BFC
		private bool StartRebuild(bool bPromptForSubasset, int desiredSubassetIndex); // 0x000000018C197D80-0x000000018C197F04
		private bool FinishRebuild(); // 0x000000018C18F1DC-0x000000018C18F800
		private bool RecookAsync(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync); // 0x000000018C1961BC-0x000000018C1962E0
		private bool RecookBlocking(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync); // 0x000000018C1962E0-0x000000018C1964D4
		private void DoPostCookWork(HEU_SessionBase session); // 0x000000018C18E58C-0x000000018C18E8D4
		internal bool IsValidForInteraction(ref string errorMessage); // 0x000000018C194D20-0x000000018C194D90
		private void OnValidate(); // 0x000000018C195718-0x000000018C19574C
		private void ExecutePostCookCallbacks(); // 0x000000018C18F140-0x000000018C18F1DC
		private void InvokePostCookEvent(bool bCookSuccess, List<GameObject> outputObjects); // 0x000000018C193A84-0x000000018C193B40
		private bool InternalStartRecook(bool bCheckParamsChanged, bool bSkipCookCheck, bool bUploadParameters, bool bUploadParameterPreset, bool bForceUploadInputs, bool bCookingSessionSync); // 0x000000018C19336C-0x000000018C1939C0
		private void InternalSetAssetID(int assetID); // 0x000000018C193214-0x000000018C19336C
		private void SetCookStatus(AssetCookStatus status, AssetCookResult result); // 0x0000000187250030-0x0000000187250040
		private void ProcessPoskCook(); // 0x000000018C195A58-0x000000018C195E40
		private bool StartHoudiniCookNode(HEU_SessionBase session); // 0x000000018C197D5C-0x000000018C197D80
		private void ProcessHoudiniCookStatus(bool bAsync); // 0x000000018C1958A4-0x000000018C195A58
		internal bool DoesAssetRequireRecook(); // 0x000000018C18E8D4-0x000000018C18ED30
		internal void DeleteSessionDataOnly(); // 0x000000018C18E3D0-0x000000018C18E3E4
		private void CleanUpInputNodes(); // 0x000000018C18BA58-0x000000018C18BC80
		internal void DeleteAssetCacheData(bool bRegisterUndo); // 0x000000018C18E380-0x000000018C18E3D0
		private void GenerateParameters(HEU_SessionBase session); // 0x000000018C18FFE8-0x000000018C1901FC
		private void DownloadParameterPresetFromHoudini(HEU_SessionBase session); // 0x000000018C18ED30-0x000000018C18EDB4
		private void UploadParameterPresetToHoudini(HEU_SessionBase session); // 0x000000018C199948-0x000000018C199B24
		private void UpdateParameterInputsToHoudini(HEU_SessionBase session, bool bForceUpdate); // 0x000000018C198D3C-0x000000018C198DD8
		private bool LoadAssetFileWithSubasset(HEU_SessionBase session, bool bPromptForSubasset, int desiredSubassetIndex); // 0x000000018C194D90-0x000000018C195078
		private bool CreateAndCookAsset(HEU_SessionBase session, int subassetIndex, out int newAssetID, bool bCookTemplatedGeos); // 0x000000018C18DA2C-0x000000018C18DB58
		private void CreateAssetInputs(HEU_SessionBase session); // 0x000000018C18DB58-0x000000018C18DEB0
		public void ForceUploadParameters(HEU_SessionBase session); // 0x000000018C18F800-0x000000018C18F834
		private void UploadCurvesParameters(HEU_SessionBase session, bool bCheckParamsChanged); // 0x000000018C1993F0-0x000000018C199774
		private void UploadAttributeValues(HEU_SessionBase session); // 0x000000018C198E44-0x000000018C1993F0
		private void SyncDirtyAttributesToHoudini(HEU_SessionBase session); // 0x000000018C197FEC-0x000000018C19812C
		private void UploadInputNodes(HEU_SessionBase session, bool bForceUpdate, bool bUpdateAll); // 0x000000018C199774-0x000000018C199948
		internal bool HasInputNodeTransformChanged(); // 0x000000018C192C14-0x000000018C192D68
		private void NotifyInputNodesCookFinished(); // 0x000000018C195540-0x000000018C19565C
		private bool CreateObjects(HEU_SessionBase session); // 0x000000018C18DFA0-0x000000018C18E0C0
		private void UpdateAllObjectNodes(HEU_SessionBase session); // 0x000000018C1982F4-0x000000018C198A30
		private HEU_ObjectNode CreateObjectNode(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo, ref HAPI_Transform objectTranform); // 0x000000018C18DEB0-0x000000018C18DFA0
		private void GenerateObjectsGeometry(HEU_SessionBase session, bool bRebuild); // 0x000000018C18FEB0-0x000000018C18FFE8
		internal int NumAttributeStores(); // 0x000000018C195690-0x000000018C1956D4
		internal HEU_AttributesStore GetAttributeStore(string geoName, int partID); // 0x000000018C190A80-0x000000018C190BD8
		private void GenerateAttributesStore(HEU_SessionBase session); // 0x000000018C18F834-0x000000018C18F95C
		private void GenerateInstances(HEU_SessionBase session); // 0x000000018C18FB28-0x000000018C18FEB0
		private void GenerateHandles(HEU_SessionBase session); // 0x000000018C18F95C-0x000000018C18FB28
		internal void CleanUpHandles(); // 0x000000018C18B95C-0x000000018C18BA58
		internal HEU_Handle GetHandleByName(string handleName); // 0x000000018C190FB8-0x000000018C191108
		internal List<HEU_Handle> GetHandles(); // 0x000000018723B240-0x000000018723B250
		internal int NumHandles(); // 0x000000018C1956D4-0x000000018C195718
		internal HAPI_Transform GetObjectTransform(HEU_SessionBase session, int objectID); // 0x000000018C1920D0-0x000000018C19218C
		internal HEU_ObjectNode GetObjectWithID(int objId); // 0x000000018C19218C-0x000000018C192248
		private void InvokeBakedEvent(bool bSuccess, List<GameObject> outputObjects, bool isNewBake); // 0x000000018C1939C0-0x000000018C193A84
		private GameObject CloneAssetWithoutHDA(ref string bakedAssetPath, bool bWriteMeshesToAssetDatabase, bool bReconnectPrefabInstances); // 0x000000018C18C35C-0x000000018C18C8A0
		internal void NotifyUpstreamCooked(HEU_CookedEventData Data); // 0x000000018C19565C-0x000000018C195690
		internal void ConnectToUpstream(HEU_HoudiniAsset upstreamAsset); // 0x000000018C18C8A0-0x000000018C18C930
		internal void DisconnectFromUpstream(HEU_HoudiniAsset upstreamAsset); // 0x000000018C18E4FC-0x000000018C18E58C
		private void AddDownstreamConnection(UnityAction<HEU_CookedEventData> receiver); // 0x000000018C1896DC-0x000000018C18975C
		private void RemoveDownstreamConnection(UnityAction<HEU_CookedEventData> receiver); // 0x000000018C1965E0-0x000000018C196638
		private void ClearAllUpstreamConnections(); // 0x000000018C18BC80-0x000000018C18BEB8
		private void UpdateInputsOnAssetRecreation(HEU_SessionBase session); // 0x000000018C198C14-0x000000018C198D3C
		internal void ReconnectInputsUpstreamNotifications(); // 0x000000018C196078-0x000000018C1961BC
		internal void GetHoudiniTransformAndApply(HEU_SessionBase session); // 0x000000018C191108-0x000000018C1913BC
		internal void UploadUnityTransform(HEU_SessionBase session, bool bOnlySendIfChangedFromLastSync); // 0x000000018C199B24-0x000000018C199B90
		private void UpdateHoudiniMaterials(HEU_SessionBase session); // 0x000000018C198A30-0x000000018C198C14
		private void RemoveUnusedMaterials(); // 0x000000018C1967A8-0x000000018C196B94
		internal bool IsAssetValidInHoudini(HEU_SessionBase session); // 0x000000018C193C18-0x000000018C193C4C
		internal bool HasTransformChangedSinceLastUpdate(); // 0x000000018C192D68-0x000000018C193014
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x000000018C190BD8-0x000000018C190D10
		internal void ClearInvalidCurves(); // 0x000000018C18BF04-0x000000018C18C02C
		internal int GetEditableCurveCount(); // 0x000000018C190E80-0x000000018C190FB8
		internal void AddCurve(HEU_Curve curve); // 0x000000018C189658-0x000000018C1896DC
		internal void RemoveCurve(HEU_Curve curve); // 0x000000018C196588-0x000000018C1965E0
		internal List<HEU_InputNode> GetInputNodes(); // 0x000000018723BD00-0x000000018723BD10
		internal void AddInputNode(HEU_InputNode node); // 0x000000018C18975C-0x000000018C1897E0
		internal void RemoveInputNode(HEU_InputNode node); // 0x000000018C196638-0x000000018C196690
		internal void InputNodeNotifyRemoved(HEU_InputNode node); // 0x000000018C193144-0x000000018C19314C
		internal void AddVolumeCache(HEU_VolumeCache cache); // 0x000000018C189850-0x000000018C1898D4
		internal void RemoveVolumeCache(HEU_VolumeCache cache); // 0x000000018C196BF8-0x000000018C196C7C
		internal void AddAttributeStore(HEU_AttributesStore attributeStore); // 0x000000018C18947C-0x000000018C1895D0
		internal void RemoveAttributeStore(HEU_AttributesStore attributeStore); // 0x000000018C1964D4-0x000000018C19652C
		internal void ReorderAttributeStore(int oldIndex, int newIndex); // 0x000000018C196C7C-0x000000018C196D80
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos); // 0x000000018C19574C-0x000000018C1958A4
		internal void AddToAssetDBCache(string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref UnityEngine.Object targetAssetDBObject); // 0x000000018C1897E0-0x000000018C189850
		internal static void SetCurvesVisibilityInScene(bool bShow); // 0x000000018C1975B4-0x000000018C197784
		internal string GetValidAssetCacheFolderPath(); // 0x000000018C19298C-0x000000018C192A24
		internal void CalculateVisibility(); // 0x000000018C18B7C8-0x000000018C18B8E0
		internal void CalculateColliderState(); // 0x000000018C18B6B0-0x000000018C18B7C8
		internal void LoadAssetPresetAndCook(HEU_AssetPreset assetPreset); // 0x000000018C195078-0x000000018C195540
		internal void ApplyRecookPreset(); // 0x000000018C189BEC-0x000000018C189C94
		private bool ApplyInputPresets(HEU_SessionBase session, List<HEU_InputPreset> inputPresets, bool bAddMissingInputsToRecookPreset); // 0x000000018C1898D4-0x000000018C189BEC
		internal HEU_VolumeCachePreset GetVolumeCachePreset(string objName, string geoName, int tile); // 0x000000018C192A68-0x000000018C192C14
		internal void RemoveVolumeCachePreset(HEU_VolumeCachePreset preset); // 0x000000018C196B94-0x000000018C196BF8
		private bool ApplyVolumeCachePresets(List<HEU_VolumeCachePreset> volumeCachePresets); // 0x000000018C189C94-0x000000018C18A03C
		internal void SyncInternalParametersForUndoCompare(); // 0x000000018C19812C-0x000000018C1982F4
		internal bool UpdateSessionSync(); // 0x000000018C198DD8-0x000000018C198E30
		internal void UpdateTotalCookCount(); // 0x000000018C198E30-0x000000018C198E44
		private void ResetAndCopyInstantiatedProperties(HEU_HoudiniAsset newAsset); // 0x000000018C196D94-0x000000018C19705C
		private AssetInstantiationMethod GetInstantiationMethod(); // 0x000000018C191600-0x000000018C1917AC
		private HEU_HoudiniAsset GetInstantiatedObject(); // 0x000000018C191574-0x000000018C191600
		private void ClearInvalidLists(); // 0x000000018C18C02C-0x000000018C18C314
		private void CopyPropertiesTo(HEU_HoudiniAsset newAsset); // 0x000000018C18C930-0x000000018C18DA2C
		internal void SetSoftDeleted(); // 0x000000018C197784-0x000000018C197960
		private void SyncChildTransforms(); // 0x000000018C197F04-0x000000018C197FEC
		internal static HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(AssetCookStatus assetCookStatus); // 0x000000018C18A05C-0x000000018C18A0A4
		internal static AssetCookStatus AssetCookStatus_WrapperToInternal(HEU_AssetCookStatusWrapper assetCookStatus); // 0x000000018C18A05C-0x000000018C18A0A4
		internal static HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(AssetCookResult assetCookResult); // 0x000000018C18A03C-0x000000018C18A05C
		internal static AssetCookResult AssetCookResult_WrapperToInternal(HEU_AssetCookResultWrapper assetCookResult); // 0x000000018C18A03C-0x000000018C18A05C
		internal static HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HEU_Curve.CurveDrawCollision curveDrawCollision); // 0x000000018C18E0C0-0x000000018C18E0D8
		internal static HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HEU_CurveDrawCollisionWrapper curveDrawCollision); // 0x000000018C18E0D8-0x000000018C18E0E8
		internal static HEU_AssetTypeWrapper AssetType_InternalToWrapper(HEU_AssetType assetType); // 0x000000018C18A0A4-0x000000018C18A0CC
		internal static HEU_AssetType AssetType_WrapperToInternal(HEU_AssetTypeWrapper assetType); // 0x000000018C18A0A4-0x000000018C18A0CC
		public bool IsEquivalentTo(HEU_HoudiniAsset asset); // 0x000000018C193C88-0x000000018C194B88
	}

	[ExecuteInEditMode]
	[SelectionBase]
	public class HEU_HoudiniAssetRoot : MonoBehaviour // TypeDefIndex: 78196
	{
		// Fields
		[SerializeField]
		internal HEU_HoudiniAsset _houdiniAsset; // 0x18
		[SerializeField]
		internal List<GameObject> _bakeTargets; // 0x20
	
		// Properties
		public HEU_HoudiniAsset HoudiniAsset { get; } // 0x0000000182234E30-0x0000000182234E40 
		public List<GameObject> BakeTargets { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Constructors
		public HEU_HoudiniAssetRoot(); // 0x000000018C19F7B4-0x000000018C19F834
	
		// Methods
		private void OnDestroy(); // 0x000000018C19F5A4-0x000000018C19F648
		internal void RemoveHoudiniEngineAssetData(); // 0x000000018C19F648-0x000000018C19F6F8
		internal void ClearHoudiniEngineReferences(); // 0x000000018C19F53C-0x000000018C19F594
		internal static void DestroyRootComponent(HEU_HoudiniAssetRoot assetRoot); // 0x000000018C19F594-0x000000018C19F5A4
		internal void Reset(); // 0x000000018C19F6F8-0x000000018C19F7B4
	}

	public class HEU_InputNode : ScriptableObject, IHEU_InputNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_InputNode> // TypeDefIndex: 78201
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
		public HEU_HoudiniAsset ParentAsset { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public bool KeepWorldTransform { get; set; } // 0x0000000182271C00-0x0000000182271C10 0x0000000182271C10-0x0000000182271C20
		public bool PackGeometryBeforeMerging { get; set; } // 0x0000000184D8E890-0x0000000184D8E8A0 0x0000000184D8E8A0-0x0000000184D8E8B0
		public HEU_InputNodeTypeWrapper NodeType { get; } // 0x000000018C1A4588-0x000000018C1A45A8 
		public HEU_InputObjectTypeWrapper ObjectType { get; } // 0x000000018C1A45A8-0x000000018C1A45B4 
		public HEU_InputObjectTypeWrapper PendingObjectType { get; set; } // 0x000000018C1A45B4-0x000000018C1A45C0 0x000000018C1A45C0-0x000000018C1A45E0
		public int InputNodeID { get; } // 0x0000000187233280-0x0000000187233290 
		public string InputName { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public string LabelName { get; } // 0x0000000187232F80-0x0000000187232F90 
		public string ParamName { get; } // 0x0000000187232FC0-0x0000000187232FD0 
		public HEU_InputInterfaceMeshSettings MeshSettings { get; } // 0x0000000187232F50-0x0000000187232F60 
		public HEU_InputInterfaceTilemapSettings TilemapSettings { get; } // 0x0000000182271B70-0x0000000182271B80 
		public HEU_InputInterfaceSplineSettings SplineSettings { get; } // 0x0000000187232C70-0x0000000187232C80 
		internal InputNodeType InputType { get; } // 0x00000001844AF510-0x00000001844AF520 
		internal List<HEU_InputObjectInfo> InputObjects { get; } // 0x0000000182262130-0x0000000182262140 
		internal List<HEU_InputHDAInfo> InputAssetInfos { get; } // 0x000000018226EE80-0x000000018226EE90 
		internal bool RequiresCook { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
		internal bool RequiresUpload { get; set; } // 0x0000000182271B50-0x0000000182271B60 0x0000000182271B60-0x0000000182271B70
	
		// Nested types
		internal enum InputNodeType // TypeDefIndex: 78197
		{
			CONNECTION = 0,
			NODE = 1,
			PARAMETER = 2
		}
	
		[Serializable]
		internal enum InputObjectType // TypeDefIndex: 78198
		{
			HDA = 0,
			UNITY_MESH = 1,
			CURVE = 2,
			TERRAIN = 3,
			BOUNDING_BOX = 4,
			TILEMAP = 5
		}
	
		public enum InternalObjectType // TypeDefIndex: 78199
		{
			UNKNOWN = 0,
			HDA = 1,
			UNITY_MESH = 2
		}
	
		public enum InputActions // TypeDefIndex: 78200
		{
			ACTION = 0,
			DELETE = 1,
			INSERT = 2
		}
	
		// Constructors
		public HEU_InputNode(); // 0x000000018C1A43B4-0x000000018C1A4588
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x000000018C1A0D40-0x000000018C1A0DD8
		public void Recook(); // 0x000000018C1A2B90-0x000000018C1A2BFC
		public bool IsAssetInput(); // 0x000000018C1A1780-0x000000018C1A1788
		public int NumInputEntries(); // 0x000000018C1A21E8-0x000000018C1A225C
		public GameObject GetInputEntryGameObject(int index); // 0x000000018C1A0990-0x000000018C1A0BA4
		public GameObject[] GetInputEntryGameObjects(); // 0x000000018C1A0BA4-0x000000018C1A0CFC
		public void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x0262A2EA */); // 0x000000018C1A335C-0x000000018C1A35B8
		public void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x0262A2EB */); // 0x000000018C1A144C-0x000000018C1A16A8
		public void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x0262A2EC */); // 0x000000018C19FA14-0x000000018C19FAB4
		public void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x0262A2ED */); // 0x000000018C1A2EDC-0x000000018C1A2F20
		public void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x0262A2EE */); // 0x000000018C19FBF8-0x000000018C19FC60
		public void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x0262A2EF */); // 0x000000018C1A2C64-0x000000018C1A2E8C
		public void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x0262A2F0 */); // 0x000000018C1A2BFC-0x000000018C1A2C64
		public void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x0262A2F1 */); // 0x000000018C1A32A4-0x000000018C1A335C
		public void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x0262A2F2 */); // 0x000000018C1A31E0-0x000000018C1A32A4
		public void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x0262A2F3 */); // 0x000000018C1A3050-0x000000018C1A3118
		public void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x0262A2F4 */); // 0x000000018C1A3118-0x000000018C1A31E0
		public bool AreAnyInputHDAsConnected(); // 0x000000018C19FAB4-0x000000018C19FBF8
		public int GetConnectedInputCount(); // 0x000000018C1A0860-0x000000018C1A08D4
		public int GetConnectedNodeID(int index); // 0x000000018C1A08D4-0x000000018C1A0990
		public void LoadPreset(HEU_InputPreset inputPreset); // 0x000000018C1A1B84-0x000000018C1A1BBC
		public void PopulateInputPreset(HEU_InputPreset inputPreset, bool sceneRelativeGameObjects); // 0x000000018C1A225C-0x000000018C1A296C
		internal static HEU_InputNode CreateSetupInput(int nodeID, int inputIndex, string inputName, string labelName, InputNodeType inputNodeType, HEU_HoudiniAsset parentAsset); // 0x000000018C1A0380-0x000000018C1A0434
		internal void SetInputNodeID(int nodeID); // 0x00000001854CCF30-0x00000001854CCF40
		internal void DestroyAllData(HEU_SessionBase session); // 0x000000018C1A0434-0x000000018C1A0478
		private void ResetInputObjectTransforms(); // 0x000000018C1A2F6C-0x000000018C1A3050
		internal void ResetInputNode(HEU_SessionBase session); // 0x000000018C1A2F20-0x000000018C1A2F6C
		internal HEU_InputObjectInfo AddInputEntryAtEndMesh(GameObject newEntryGameObject); // 0x000000018C19F9D8-0x000000018C19FA14
		internal HEU_InputHDAInfo AddInputEntryAtEndHDA(GameObject newEntryGameObject); // 0x000000018C19F99C-0x000000018C19F9D8
		internal void ChangeInputType(HEU_SessionBase session, InputObjectType newType); // 0x000000018C19FC60-0x000000018C19FC90
		internal void ResetConnectionForForceUpdate(HEU_SessionBase session); // 0x000000018C1A2E8C-0x000000018C1A2EDC
		internal void UploadInput(HEU_SessionBase session); // 0x000000018C1A39C4-0x000000018C1A3D68
		private void UploadHDAInput(HEU_SessionBase session); // 0x000000018C1A373C-0x000000018C1A3868
		private void UploadUnityInput(HEU_SessionBase session); // 0x000000018C1A3E80-0x000000018C1A43B4
		internal void ReconnectToUpstreamAsset(); // 0x000000018C1A296C-0x000000018C1A2B90
		private HEU_InputObjectInfo CreateInputObjectInfo(GameObject inputGameObject); // 0x000000018C1A030C-0x000000018C1A0380
		private HEU_InputHDAInfo CreateInputHDAInfo(GameObject inputGameObject); // 0x000000018C1A02A4-0x000000018C1A030C
		private HEU_InputObjectInfo InternalAddInputObjectAtEnd(GameObject newInputGameObject); // 0x000000018C1A1714-0x000000018C1A1780
		private HEU_InputHDAInfo InternalAddInputHDAAtEnd(GameObject newInputHDA); // 0x000000018C1A16A8-0x000000018C1A1714
		private void DisconnectConnectedMergeNode(HEU_SessionBase session); // 0x000000018C1A0610-0x000000018C1A0744
		private void ClearConnectedInputHDAs(); // 0x000000018C19FC90-0x000000018C19FE64
		private void ConnectToMergeObject(HEU_SessionBase session); // 0x000000018C19FE7C-0x000000018C19FF20
		private void DisconnectAndDestroyInputs(HEU_SessionBase session); // 0x000000018C1A0478-0x000000018C1A0610
		internal bool UploadObjectMergeTransformType(HEU_SessionBase session); // 0x000000018C1A3DF4-0x000000018C1A3E80
		private bool UploadObjectMergePackGeometry(HEU_SessionBase session); // 0x000000018C1A3D68-0x000000018C1A3DF4
		internal bool HasInputNodeTransformChanged(); // 0x000000018C1A0F98-0x000000018C1A13FC
		internal void UploadInputObjectTransforms(HEU_SessionBase session); // 0x000000018C1A3868-0x000000018C1A39C4
		internal void UpdateOnAssetRecreation(HEU_SessionBase session); // 0x000000018C1A35B8-0x000000018C1A373C
		internal void CopyInputValuesTo(HEU_SessionBase session, HEU_InputNode destInputNode); // 0x000000018C19FF20-0x000000018C1A02A4
		internal void LoadPreset(HEU_SessionBase session, HEU_InputPreset inputPreset); // 0x000000018C1A1BBC-0x000000018C1A2170
		private bool FindAddToInputHDA(string gameObjectName); // 0x000000018C1A0744-0x000000018C1A0860
		internal void NotifyParentRemovedInput(); // 0x000000018C1A2170-0x000000018C1A21E8
		internal void ClearUICache(); // 0x000000018C19FE64-0x000000018C19FE7C
		internal void HandleSelectedObjectsForInputObjects(GameObject[] selectedObjects); // 0x000000018C1A0EB8-0x000000018C1A0F98
		internal void HandleSelectedObjectsForInputHDAs(GameObject[] selectedObjects); // 0x000000018C1A0DD8-0x000000018C1A0EB8
		public bool IsEquivalentTo(HEU_InputNode other); // 0x000000018C1A1788-0x000000018C1A1B84
		internal static InternalObjectType GetInternalObjectType(InputObjectType type); // 0x000000018C1A0CFC-0x000000018C1A0D40
		internal static HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(InputNodeType inputNodeType); // 0x000000018C18A03C-0x000000018C18A05C
		internal static InputNodeType InputNodeType_InternalToWrapper(HEU_InputNodeTypeWrapper inputNodeType); // 0x000000018C18A03C-0x000000018C18A05C
		internal static HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(InputObjectType inputType); // 0x000000018C1A13FC-0x000000018C1A144C
		internal static InputObjectType InputObjectType_WrapperToInternal(HEU_InputObjectTypeWrapper inputType); // 0x000000018C1A13FC-0x000000018C1A144C
	}

	[Serializable]
	internal class HEU_InputObjectInfo : IEquivable<HEU_InputObjectInfo> // TypeDefIndex: 78202
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
		public HEU_InputObjectInfo(); // 0x000000018C1A4A28-0x000000018C1A4B28
	
		// Methods
		public void CopyTo(HEU_InputObjectInfo destObject); // 0x000000018C1A45E0-0x000000018C1A46E4
		internal void SetReferencesFromGameObject(); // 0x000000018C1A4940-0x000000018C1A4A28
		public bool IsEquivalentTo(HEU_InputObjectInfo other); // 0x000000018C1A46E4-0x000000018C1A4940
	}

	[Serializable]
	internal class HEU_InputHDAInfo : IEquivable<HEU_InputHDAInfo> // TypeDefIndex: 78203
	{
		// Fields
		public GameObject _pendingGO; // 0x10
		public GameObject _connectedGO; // 0x18
		public int _connectedInputNodeID; // 0x20
		public int _connectedMergeNodeID; // 0x24
	
		// Constructors
		public HEU_InputHDAInfo(); // 0x0000000187250320-0x0000000187250330
	
		// Methods
		public void CopyTo(HEU_InputHDAInfo destInfo); // 0x000000018C19F834-0x000000018C19F878
		public bool IsEquivalentTo(HEU_InputHDAInfo other); // 0x000000018C19F878-0x000000018C19F8DC
	}

	public class HEU_InputNodeUICache // TypeDefIndex: 78206
	{
		// Fields
		public List<HEU_InputObjectUICache> _inputObjectCache; // 0x10
		public List<HEU_InputAssetUICache> _inputAssetCache; // 0x18
	
		// Nested types
		public class HEU_InputObjectUICache // TypeDefIndex: 78204
		{
			// Constructors
			public HEU_InputObjectUICache(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class HEU_InputAssetUICache // TypeDefIndex: 78205
		{
			// Constructors
			public HEU_InputAssetUICache(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public HEU_InputNodeUICache(); // 0x000000018C19F8DC-0x000000018C19F99C
	}

	[Serializable]
	internal class HEU_InstanceInputUIState : ScriptableObject, IEquivable<HEU_InstanceInputUIState> // TypeDefIndex: 78207
	{
		// Fields
		public bool _showInstanceInputs; // 0x18
		public int _numInputsToShowUI; // 0x1C
		public int _inputsPageIndexUI; // 0x20
	
		// Constructors
		public HEU_InstanceInputUIState(); // 0x000000018C1A4CA8-0x000000018C1A4CBC
	
		// Methods
		internal void CopyTo(HEU_InstanceInputUIState dest); // 0x000000018C1A4B28-0x000000018C1A4B50
		public bool IsEquivalentTo(HEU_InstanceInputUIState other); // 0x000000018C1A4B50-0x000000018C1A4CA8
	}

	public class HEU_ObjectInstanceInfo : ScriptableObject, IEquivable<HEU_ObjectInstanceInfo> // TypeDefIndex: 78208
	{
		// Fields
		public List<HEU_InstancedInput> _instancedInputs; // 0x18
		public HEU_PartData _partTarget; // 0x20
		public int _instancedObjectNodeID; // 0x28
		public string _instancedObjectPath; // 0x30
		public List<GameObject> _instances; // 0x38
	
		// Constructors
		public HEU_ObjectInstanceInfo(); // 0x000000018C1A4F9C-0x000000018C1A506C
	
		// Methods
		public bool IsEquivalentTo(HEU_ObjectInstanceInfo other); // 0x000000018C1A4E78-0x000000018C1A4F9C
	}

	[Serializable]
	public class HEU_InstancedInput : IEquivable<HEU_InstancedInput> // TypeDefIndex: 78209
	{
		// Fields
		public GameObject _instancedGameObject; // 0x10
		public Vector3 _rotationOffset; // 0x18
		public Vector3 _scaleOffset; // 0x24
	
		// Constructors
		public HEU_InstancedInput(); // 0x000000018C1A4E4C-0x000000018C1A4E78
	
		// Methods
		public bool IsEquivalentTo(HEU_InstancedInput other); // 0x000000018C1A4CBC-0x000000018C1A4E4C
	}

	public class HEU_ObjectNode : ScriptableObject, IHEU_ObjectNode, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_ObjectNode> // TypeDefIndex: 78210
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
		public HEU_HoudiniAsset ParentAsset { get; } // 0x000000018225E800-0x000000018225E810 
		public int ObjectID { get; } // 0x000000018226F000-0x000000018226F010 
		public string ObjectName { get; } // 0x0000000182234E30-0x0000000182234E40 
		public HAPI_ObjectInfo ObjectInfo { get; } // 0x0000000187250350-0x0000000187250370 
		public List<HEU_GeoNode> GeoNodes { get; } // 0x000000018226EE80-0x000000018226EE90 
		public HAPI_Transform ObjectTransform { get; } // 0x0000000187250370-0x0000000187250390 
	
		// Constructors
		public HEU_ObjectNode(); // 0x000000018C1A80E8-0x000000018C1A8174
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x000000018C1A71CC-0x000000018C1A7260
		public void Recook(); // 0x000000018C1A7CCC-0x000000018C1A7D30
		public bool IsInstanced(); // 0x000000018226EBB0-0x000000018226EBC0
		public bool IsVisible(); // 0x000000018226EE20-0x000000018226EE30
		public bool IsUsingMaterial(HEU_MaterialData materialData); // 0x000000018C1A7924-0x000000018C1A7A54
		public void GetOutputGameObjects(List<GameObject> outputObjects); // 0x000000018C1A6E24-0x000000018C1A6F4C
		public void GetOutput(List<HEU_GeneratedOutput> outputs); // 0x000000018C1A70A4-0x000000018C1A71CC
		public HEU_PartData GetHDAPartWithGameObject(GameObject outputGameObject); // 0x000000018C1A6CC8-0x000000018C1A6E24
		public HEU_GeoNode GetGeoNode(string geoName); // 0x000000018C1A6B84-0x000000018C1A6CC8
		public void GetCurves(List<HEU_Curve> curves, bool bEditableOnly); // 0x000000018C1A67B0-0x000000018C1A68E8
		public void GetOutputGeoNodes(List<HEU_GeoNode> outGeoNodes); // 0x000000018C1A6F4C-0x000000018C1A70A4
		public void HideAllGeometry(); // 0x000000018C1A7260-0x000000018C1A7378
		public void DisableAllColliders(); // 0x000000018C1A5700-0x000000018C1A5818
		public bool IsInstancer(); // 0x000000018C1A7800-0x000000018C1A7924
		internal void Reset(); // 0x000000018C1A7D30-0x000000018C1A7E30
		private void SyncWithObjectInfo(HEU_SessionBase session); // 0x000000018C1A7E30-0x000000018C1A7F00
		internal void Initialize(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, HAPI_Transform objectTranform, HEU_HoudiniAsset parentAsset, bool bUseOutputNodes, bool bGetEditableNodes); // 0x000000018C1A7378-0x000000018C1A7584
		internal void GatherAllAssetOutputsLegacy(HEU_SessionBase session, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, ref List<HEU_GeoNode> geoNodes); // 0x000000018C1A5818-0x000000018C1A58C4
		internal void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x0262A304 */); // 0x000000018C1A562C-0x000000018C1A5700
		private HEU_GeoNode CreateGeoNode(HEU_SessionBase session, HAPI_GeoInfo geoInfo); // 0x000000018C1A557C-0x000000018C1A562C
		internal void GetDebugInfo(StringBuilder sb); // 0x000000018C1A68E8-0x000000018C1A6B84
		internal void SetObjectInfo(HAPI_ObjectInfo newObjectInfo); // 0x0000000187250330-0x0000000187250350
		internal void UpdateObject(HEU_SessionBase session, bool bForceUpdate); // 0x000000018C1A7F5C-0x000000018C1A80E8
		internal void GenerateGeometry(HEU_SessionBase session, bool bRebuild); // 0x000000018C1A59EC-0x000000018C1A614C
		internal void GeneratePartInstances(HEU_SessionBase session); // 0x000000018C1A654C-0x000000018C1A6674
		internal void GenerateAttributesStore(HEU_SessionBase session); // 0x000000018C1A58C4-0x000000018C1A59EC
		internal void ApplyObjectTransformToGeoNodes(); // 0x000000018C1A506C-0x000000018C1A5190
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x000000018C1A6674-0x000000018C1A67B0
		internal void GenerateObjectInstances(HEU_SessionBase session); // 0x000000018C1A614C-0x000000018C1A654C
		internal void ClearObjectInstances(HEU_SessionBase session); // 0x000000018C1A53CC-0x000000018C1A557C
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos); // 0x000000018C1A7A54-0x000000018C1A7BA4
		internal void ProcessUnityScriptAttributes(HEU_SessionBase session); // 0x000000018C1A7BA4-0x000000018C1A7CCC
		internal void CalculateVisibility(); // 0x000000018C1A52A8-0x000000018C1A53CC
		internal void CalculateColliderState(); // 0x000000018C1A5190-0x000000018C1A52A8
		public override string ToString(); // 0x000000018C1A7F00-0x000000018C1A7F5C
		public bool IsEquivalentTo(HEU_ObjectNode other); // 0x000000018C1A7584-0x000000018C1A7800
	}

	public class HEU_PartData : ScriptableObject, IHEU_PartData, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_PartData> // TypeDefIndex: 78216
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
		public HEU_HoudiniAsset ParentAsset { get; } // 0x000000018C1AFA34-0x000000018C1AFAA4 
		public int PartID { get; } // 0x00000001844AF510-0x00000001844AF520 
		public string PartName { get; } // 0x000000018225E800-0x000000018225E810 
		public int GeoID { get; } // 0x0000000182271A80-0x0000000182271A90 
		public HAPI_PartType PartType { get; } // 0x000000018226EBA0-0x000000018226EBB0 
		public HEU_GeoNode ParentGeoNode { get; } // 0x0000000182986470-0x0000000182986480 
		public List<HEU_ObjectInstanceInfo> ObjectInstanceInfos { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public HEU_Curve Curve { get; } // 0x00000001829CD170-0x00000001829CD180 
		public int MeshVertexCount { get; } // 0x0000000187233660-0x0000000187233670 
		public HEU_GeneratedOutput GeneratedOutput { get; } // 0x0000000182271B70-0x0000000182271B80 
		public GameObject OutputGameObject { get; } // 0x000000018C1AFA0C-0x000000018C1AFA34 
	
		// Nested types
		public enum PartOutputType // TypeDefIndex: 78211
		{
			NONE = 0,
			MESH = 1,
			VOLUME = 2,
			CURVE = 3,
			INSTANCER = 4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78212
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<LOD> __9__96_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C1B007C-0x000000018C1B00E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _CopyGameObjectComponents_b__96_0(LOD a, LOD b); // 0x000000018C1AFBD4-0x000000018C1AFBEC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0 // TypeDefIndex: 78213
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass97_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CopyChildGameObjects_b__0(Transform trans); // 0x000000018C1AFE54-0x000000018C1AFF0C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0 // TypeDefIndex: 78214
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass99_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _BakePartToGameObject_b__0(Transform trans); // 0x000000018C1AFF0C-0x000000018C1AFFC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_1 // TypeDefIndex: 78215
		{
			// Fields
			public List<HoudiniEngineUnity.TransformData> previousTransformValues; // 0x10
	
			// Constructors
			public __c__DisplayClass99_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _BakePartToGameObject_b__1(Transform trans); // 0x000000018C1AFFC4-0x000000018C1B007C
		}
	
		// Constructors
		public HEU_PartData(); // 0x000000018C1AF984-0x000000018C1AFA0C
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x000000018C1AE674-0x000000018C1AE718
		public void Recook(); // 0x000000018C1AEFD0-0x000000018C1AF044
		public bool IsPartInstancer(); // 0x000000018783D870-0x000000018783D878
		public bool IsAttribInstancer(); // 0x000000018225DFB0-0x000000018225DFC0
		public bool IsInstancerAnyType(); // 0x000000018C1AEDB4-0x000000018C1AEDC8
		public bool IsPartInstanced(); // 0x000000018226EE60-0x000000018226EE70
		public int GetPartPointCount(); // 0x0000000182271C40-0x0000000182271C50
		public bool IsObjectInstancer(); // 0x000000018223CB60-0x000000018223CB70
		public bool IsPartVolume(); // 0x000000018C1AEDD8-0x000000018C1AEDE0
		public bool IsPartCurve(); // 0x000000018C1AEDC8-0x000000018C1AEDD0
		public bool IsPartMesh(); // 0x000000018C1AEDD0-0x000000018C1AEDD8
		public bool IsPartEditable(); // 0x0000000182271A20-0x0000000182271A30
		public bool HaveInstancesBeenGenerated(); // 0x000000018236FC60-0x000000018236FC70
		public void SetGameObjectName(string partName); // 0x000000018C1AF068-0x000000018C1AF260
		public void SetGameObject(GameObject gameObject); // 0x000000018C1AF260-0x000000018C1AF290
		public void SetVolumeLayerName(string name); // 0x00000001887DE51C-0x00000001887DE530
		public string GetVolumeLayerName(); // 0x0000000187232C70-0x0000000187232C80
		public void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x0262A305 */); // 0x000000018C1ABBE8-0x000000018C1ABD24
		public bool IsUsingMaterial(HEU_MaterialData materialData); // 0x000000018C1AEDE0-0x000000018C1AEE0C
		public void GetOutputGameObjects(List<GameObject> outputObjects); // 0x000000018C1AE568-0x000000018C1AE60C
		public void GetOutput(List<HEU_GeneratedOutput> outputs); // 0x000000018C1AE60C-0x000000018C1AE674
		public HEU_PartData GetHDAPartWithGameObject(GameObject inGameObject); // 0x000000018C1AE384-0x000000018C1AE3F4
		public void CalculateVisibility(bool bParentVisibility, bool bParentDisplayGeo); // 0x000000018C1A8F6C-0x000000018C1A8F98
		public void ClearInstances(); // 0x000000018C1A909C-0x000000018C1A9184
		public HEU_Curve GetCurve(bool bEditableOnly); // 0x000000018C1AE138-0x000000018C1AE1BC
		public void SetVisiblity(bool bVisibility); // 0x000000018C1AF560-0x000000018C1AF72C
		public void SetColliderState(bool bEnabled); // 0x000000018C1AF044-0x000000018C1AF068
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(string path); // 0x000000018C1AE4A4-0x000000018C1AE568
		public HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(int objNodeID); // 0x000000018C1AE3F4-0x000000018C1AE4A4
		public void SetTerrainOffsetPosition(Vector3 offsetPosition); // 0x0000000187250390-0x00000001872503A0
		public void SetTerrainData(TerrainData terrainData, string exportPathRelative, string exportPathUser); // 0x000000018C1AF3B4-0x000000018C1AF560
		internal void Initialize(HEU_SessionBase session, int partID, int geoID, int objectNodeID, HEU_GeoNode geoNode, ref HAPI_PartInfo partInfo, PartOutputType partOutputType, bool isEditable, bool isObjectInstancer, bool isAttribInstancer); // 0x000000018C1AE718-0x000000018C1AE8D8
		internal void ApplyHAPITransform(ref HAPI_Transform hapiTransform); // 0x000000018C1A81B0-0x000000018C1A82FC
		internal void GetDebugInfo(StringBuilder sb); // 0x000000018C1AE1BC-0x000000018C1AE384
		internal void GetClonableObjects(List<GameObject> clonableObjects); // 0x000000018C1ADFF8-0x000000018C1AE09C
		internal void GetClonableParts(List<HEU_PartData> clonableParts); // 0x000000018C1AE09C-0x000000018C1AE138
		private void SetObjectInstancer(bool bObjectInstancer); // 0x000000018223CB70-0x000000018223CB80
		private void ClearObjectInstanceInfos(); // 0x000000018C1A93A4-0x000000018C1A945C
		internal void ClearInvalidObjectInstanceInfos(); // 0x000000018C1A9184-0x000000018C1A93A4
		internal void ClearGeneratedData(); // 0x000000018C1A8F98-0x000000018C1A8FB4
		internal void ClearGeneratedMeshOutput(); // 0x000000018C1A8FB4-0x000000018C1A9050
		internal void ClearGeneratedVolumeOutput(); // 0x000000018C1A9050-0x000000018C1A909C
		internal bool GeneratePartInstances(HEU_SessionBase session); // 0x000000018C1ADE64-0x000000018C1ADFF8
		internal void GenerateInstancesFromObjectID(HEU_SessionBase session, int objectNodeID, string[] instancePrefixes, string[] instanceMaterialPaths); // 0x000000018C1ABF8C-0x000000018C1AC3D0
		internal void GenerateInstancesFromObject(HEU_SessionBase session, HEU_ObjectNode sourceObject, string[] instancePrefixes, string[] instanceMaterialPaths); // 0x000000018C1ACA90-0x000000018C1ACDE8
		internal void GenerateInstancesFromObjectIds(HEU_SessionBase session, string[] instancePrefixes, string[] instanceMaterialPaths); // 0x000000018C1AC3D0-0x000000018C1ACA90
		internal void GenerateInstancesFromUnityAssetPathAttribute(HEU_SessionBase session, string unityInstanceAttr); // 0x000000018C1ACDE8-0x000000018C1ADA24
		private void CreateNewInstanceFromObject(GameObject sourceObject, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, int instancedObjectNodeID, string instancedObjectPath, Vector3 rotationOffset, Vector3 scaleOffset, string[] instancePrefixes, string[] instanceMaterialPaths, GameObject collisionSrcGO, bool copyParentFlags = true /* Metadata: 0x0262A306 */); // 0x000000018C1AB6A4-0x000000018C1ABA9C
		internal void GenerateAttributesStore(HEU_SessionBase session); // 0x000000018C1ABEEC-0x000000018C1ABF8C
		internal void CalculateColliderState(); // 0x000000018C1A8CCC-0x000000018C1A8F6C
		private static void CopyGameObjectComponents(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, List<HoudiniEngineUnity.TransformData> lodTransformValues); // 0x000000018C1A98D8-0x000000018C1AB6A4
		private static void CopyChildGameObjects(HEU_PartData partData, GameObject sourceGO, GameObject targetGO, string assetName, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bKeepPreviousTransformValues); // 0x000000018C1A9524-0x000000018C1A98D8
		internal GameObject BakePartToNewGameObject(Transform parentTransform, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances); // 0x000000018C1A8B88-0x000000018C1A8CCC
		internal static void BakePartToGameObject(HEU_PartData partData, GameObject srcGO, GameObject targetGO, string assetName, bool bIsInstancer, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues); // 0x000000018C1A82FC-0x000000018C1A8A38
		internal void BakePartToGameObject(GameObject targetGO, bool bDeleteExistingComponents, bool bDontDeletePersistantResources, bool bWriteMeshesToAssetDatabase, ref string bakedAssetPath, Dictionary<Mesh, Mesh> sourceToTargetMeshMap, Dictionary<Material, Material> sourceToCopiedMaterials, ref UnityEngine.Object assetDBObject, string assetObjectFileName, bool bReconnectPrefabInstances, bool bKeepPreviousTransformValues); // 0x000000018C1A8A38-0x000000018C1A8B88
		internal bool GenerateMesh(HEU_SessionBase session, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups); // 0x000000018C1ADA24-0x000000018C1ADE64
		internal void ProcessCurvePart(HEU_SessionBase session, int partId); // 0x000000018C1AEE60-0x000000018C1AEFD0
		internal void SyncAttributesStore(HEU_SessionBase session, int geoID, ref HAPI_PartInfo partInfo); // 0x000000018C1AF7FC-0x000000018C1AF928
		internal void SetupAttributeGeometry(HEU_SessionBase session); // 0x000000018C1AF72C-0x000000018C1AF7FC
		internal void DestroyAttributesStore(); // 0x000000018C1ABD24-0x000000018C1ABE0C
		internal void PopulateObjectInstanceInfos(List<HEU_ObjectInstanceInfo> objInstanceInfos); // 0x000000018C1AEE0C-0x000000018C1AEE60
		internal void SetObjectInstanceInfos(List<HEU_ObjectInstanceInfo> sourceObjectInstanceInfos); // 0x000000018C1AF290-0x000000018C1AF3B4
		internal List<HEU_ObjectInstanceInfo> GetObjectInstanceInfos(); // 0x000000018226EBD0-0x000000018226EBE0
		private HEU_ObjectInstanceInfo CreateObjectInstanceInfo(GameObject instancedObject, int instancedObjectNodeID, string instancedObjectPath); // 0x000000018C1ABA9C-0x000000018C1ABBE8
		internal static string AppendBakedCloneName(string name); // 0x000000018C1A8174-0x000000018C1A81B0
		public override string ToString(); // 0x000000018C1AF928-0x000000018C1AF984
		internal static void DestroyParts(List<HEU_PartData> parts, bool bIsRebuild = false /* Metadata: 0x0262A307 */); // 0x000000018C1ABE40-0x000000018C1ABEEC
		internal static void DestroyPart(HEU_PartData part, bool bIsRebuild = false /* Metadata: 0x0262A308 */); // 0x000000018C1ABE0C-0x000000018C1ABE40
		internal static bool ComposeUnityInstanceSplitHierarchy(HEU_SessionBase session, int geoID, int partID, Transform parentTransform, int numInstances, ref Transform[] instanceToChildTransform); // 0x000000018C1A945C-0x000000018C1A9524
		public bool IsEquivalentTo(HEU_PartData other); // 0x000000018C1AE8D8-0x000000018C1AEDB4
	}

	[Serializable]
	internal sealed class HEU_AttributeData : IEquivable<HEU_AttributeData> // TypeDefIndex: 78219
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
		public enum AttributeType // TypeDefIndex: 78217
		{
			UNDEFINED = -1,
			BOOL = 0,
			INT = 1,
			FLOAT = 2,
			STRING = 3,
			MAX = 4
		}
	
		public enum AttributeState // TypeDefIndex: 78218
		{
			INVALID = 0,
			SYNCED = 1,
			LOCAL_DIRTY = 2
		}
	
		// Constructors
		public HEU_AttributeData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsColorAttribute(); // 0x000000018C19BF3C-0x000000018C19BF94
		internal void CopyValuesTo(HEU_AttributeData destAttrData); // 0x000000018C19BE08-0x000000018C19BF3C
		public bool IsEquivalentTo(HEU_AttributeData other); // 0x000000018C19BF94-0x000000018C19C2AC
	}

	internal class HEU_AttributesStore : ScriptableObject, IEquivable<HEU_AttributesStore> // TypeDefIndex: 78221
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
		public int GeoID { get; } // 0x00000001844AF510-0x00000001844AF520 
		public int PartID { get; } // 0x0000000187233000-0x0000000187233010 
		public string GeoName { get; } // 0x000000018225E800-0x000000018225E810 
		public Transform OutputTransform { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public Mesh OutputMesh { get; } // 0x0000000187232FA0-0x0000000187232FB0 
	
		// Nested types
		public delegate void SetAttributeValueFunc(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // TypeDefIndex: 78220; 0x00000001812083C0-0x00000001812083E0
	
		// Constructors
		public HEU_AttributesStore(); // 0x000000018C19F46C-0x000000018C19F53C
	
		// Methods
		public bool HasColorAttribute(); // 0x00000001822434B0-0x00000001822434C0
		public void DestroyAllData(HEU_HoudiniAsset asset); // 0x000000018C19C7B8-0x000000018C19C8E8
		public void SyncAllAttributesFrom(HEU_SessionBase session, HEU_HoudiniAsset asset, int geoID, ref HAPI_PartInfo partInfo, GameObject outputGameObject); // 0x000000018C19EE24-0x000000018C19F0A4
		public void SetupMeshAndMaterials(HEU_HoudiniAsset asset, HAPI_PartType partType, GameObject outputGameObject); // 0x000000018C19E78C-0x000000018C19EB6C
		public bool HasDirtyAttributes(); // 0x000000018C19D2E8-0x000000018C19D410
		public void SyncDirtyAttributesToHoudini(HEU_SessionBase session); // 0x000000018C19F0A4-0x000000018C19F10C
		private void PopulateAttributeData(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData, ref HAPI_AttributeInfo attributeInfo); // 0x000000018C19DBEC-0x000000018C19E2B4
		private void GetAttributesList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributesList, HAPI_AttributeOwner ownerType, int attributeCount); // 0x000000018C19D1F0-0x000000018C19D260
		private void UpdateAttribute(HEU_SessionBase session, int geoID, int partID, HEU_AttributeData attributeData); // 0x000000018C19F264-0x000000018C19F3C0
		private void UpdateAttributeList(HEU_SessionBase session, int geoID, int partID, List<HEU_AttributeData> attributeDataList); // 0x000000018C19F10C-0x000000018C19F264
		public void RefreshUpstreamInputs(HEU_SessionBase session); // 0x000000018C19E2B4-0x000000018C19E2EC
		public bool UploadAttributeViaMeshInput(HEU_SessionBase session, int geoID, int partID); // 0x000000018C19F3C0-0x000000018C19F46C
		private static void SetAttributeDataSyncd(HEU_AttributeData attributeData); // 0x000000018C19E4E0-0x000000018C19E4FC
		public static void SetAttributeDataDirty(HEU_AttributeData attributeData); // 0x000000018C19E4C4-0x000000018C19E4E0
		public HEU_AttributeData CreateAttribute(string attributeName, ref HAPI_AttributeInfo attributeInfo); // 0x000000018C19C6FC-0x000000018C19C7B8
		public HEU_AttributeData GetAttributeData(string name); // 0x000000018C19CC74-0x000000018C19CDB8
		public HEU_AttributeData GetAttributeData(int index); // 0x000000018C19CDB8-0x000000018C19CE28
		public List<string> GetAttributeNames(); // 0x000000018C19CE28-0x000000018C19CFC0
		public void EnablePaintCollider(); // 0x000000018C19CA0C-0x000000018C19CBB4
		public void DisablePaintCollider(); // 0x000000018C19C8E8-0x000000018C19CA0C
		public void ShowPaintMesh(); // 0x000000018C19EB6C-0x000000018C19EC78
		public void HidePaintMesh(); // 0x000000018C19D460-0x000000018C19D53C
		public bool HasMeshForPainting(); // 0x000000018C19D410-0x000000018C19D460
		public MeshCollider GetPaintMeshCollider(); // 0x000000018C19D260-0x000000018C19D2C8
		public void PaintAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools, int attributeIndex, float paintFactor, SetAttributeValueFunc setAttrFunc); // 0x000000018C19DB84-0x000000018C19DBEC
		public static void SetAttributeEditValueInt(HEU_AttributeData attributeData, int startIndex, int[] values); // 0x000000018C19E59C-0x000000018C19E63C
		public static void SetAttributeEditValueFloat(HEU_AttributeData attributeData, int startIndex, float[] values); // 0x000000018C19E4FC-0x000000018C19E59C
		public static void SetAttributeEditValueString(HEU_AttributeData attributeData, int startIndex, string[] values); // 0x000000018C19E63C-0x000000018C19E6D8
		public static void ReplaceAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19E3B0-0x000000018C19E4C4
		public static void AddAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19C378-0x000000018C19C454
		public static void SubtractAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19ED48-0x000000018C19EE24
		public static void MultiplyAttributeValueInt(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19DA78-0x000000018C19DB84
		public static void ReplaceAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19E2EC-0x000000018C19E3B0
		public static void AddAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19C2AC-0x000000018C19C378
		public static void SubtractAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19EC78-0x000000018C19ED48
		public static void MultiplyAttributeValueFloat(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19D9B4-0x000000018C19DA78
		public static void SetAttributeValueString(HEU_AttributeData attributeData, int targetIndex, HEU_ToolsInfo sourceTools, int sourceIndex, float factor); // 0x000000018C19E6D8-0x000000018C19E78C
		public void FillAttribute(HEU_AttributeData attributeData, HEU_ToolsInfo sourceTools); // 0x000000018C19CBB4-0x000000018C19CC74
		public bool AreAttributesDirty(); // 0x000000018C19C454-0x000000018C19C56C
		public void GetPositionAttributeValues(out Vector3[] positionArray); // 0x000000018C19D2C8-0x000000018C19D2D8
		public void GetVertexIndices(out int[] indices); // 0x000000018C19D2D8-0x000000018C19D2E8
		public static SetAttributeValueFunc GetAttributeSetValueFunction(HEU_AttributeData.AttributeType attrType, HEU_ToolsInfo.PaintMergeMode paintMergeMode); // 0x000000018C19CFC0-0x000000018C19D1F0
		public void CopyAttributeValuesTo(HEU_AttributesStore destAttrStore); // 0x000000018C19C56C-0x000000018C19C6FC
		public bool IsValidStore(HEU_SessionBase session); // 0x000000018C19D99C-0x000000018C19D9B4
		public bool IsEquivalentTo(HEU_AttributesStore other); // 0x000000018C19D53C-0x000000018C19D99C
	}

	[Serializable]
	public class HEU_OutputAttribute // TypeDefIndex: 78222
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
		public HEU_OutputAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class HEU_OutputAttributeDictionary : HEU_SerializableDictionary<string, HEU_OutputAttribute> // TypeDefIndex: 78223
	{
		// Constructors
		public HEU_OutputAttributeDictionary(); // 0x000000018C1B64C4-0x000000018C1B64EC
	}

	public class HEU_OutputAttributesStore : MonoBehaviour // TypeDefIndex: 78224
	{
		// Fields
		[SerializeField]
		private HEU_OutputAttributeDictionary _attributes; // 0x18
	
		// Constructors
		public HEU_OutputAttributesStore(); // 0x000000018C1B666C-0x000000018C1B66DC
	
		// Methods
		public void SetAttribute(HEU_OutputAttribute attribute); // 0x000000018C1B659C-0x000000018C1B666C
		public HEU_OutputAttribute GetAttribute(string name); // 0x000000018C1B6534-0x000000018C1B659C
		public void Clear(); // 0x000000018C1B64EC-0x000000018C1B6534
	}

	public static class HEU_AssetDatabase // TypeDefIndex: 78226
	{
		// Nested types
		public enum HEU_ImportAssetOptions // TypeDefIndex: 78225
		{
			Default = 0,
			ForceUpdate = 1,
			ForceSynchronousImport = 8,
			ImportRecursive = 256,
			DontDownloadFromCacheServer = 8192,
			ForceUncompressedImport = 16384
		}
	
		// Methods
		public static string GetAssetCachePath(); // 0x000000018C1B10D8-0x000000018C1B1120
		public static string GetUnityProjectPath(); // 0x000000018C1B18B8-0x000000018C1B1914
		public static string GetAssetRelativePath(string inFullPath); // 0x000000018C1B126C-0x000000018C1B13AC
		public static string GetPackagesRelativePath(string inFullPath); // 0x000000018C1B153C-0x000000018C1B165C
		public static string GetValidAssetPath(string inPath); // 0x000000018C1B1914-0x000000018C1B1C3C
		public static string GetAssetPath(UnityEngine.Object asset); // 0x000000018C1B11DC-0x000000018C1B1214
		public static string GetAssetPathWithSubAssetSupport(UnityEngine.Object asset); // 0x000000018C1B11A4-0x000000018C1B11DC
		public static void GetSubAssetPathFromPath(string fullPath, out string mainPath, out string subPath); // 0x000000018C1B165C-0x000000018C1B17D0
		private static string GetAssetRelativePathStart(); // 0x000000018C1B1214-0x000000018C1B126C
		private static string GetPackagesRelativePathStart(); // 0x000000018C1B14E4-0x000000018C1B153C
		public static string GetAssetFullPath(string inPath); // 0x000000018C1B1120-0x000000018C1B116C
		public static bool IsPathRelativeToAssets(string inPath); // 0x000000018C1B1E94-0x000000018C1B1F18
		public static bool IsPathRelativeToPackages(string inPath); // 0x000000018C1B1F18-0x000000018C1B1F9C
		public static string GetAssetRootPath(UnityEngine.Object asset); // 0x000000018C1B13AC-0x000000018C1B13E4
		public static string GetUniqueAssetPath(string path); // 0x000000018C1B1880-0x000000018C1B18B8
		public static string GetAssetOrScenePath(UnityEngine.Object inputObject); // 0x000000018C1B116C-0x000000018C1B11A4
		public static bool IsPathInAssetCache(string path); // 0x000000018C1B1D88-0x000000018C1B1E94
		public static bool IsPathInAssetCacheBakedFolder(string path); // 0x000000018C1B1D18-0x000000018C1B1D50
		public static bool IsPathInAssetCacheWorkingFolder(string path); // 0x000000018C1B1D50-0x000000018C1B1D88
		public static bool IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset); // 0x000000018C1B1C70-0x000000018C1B1CA8
		public static bool IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset); // 0x000000018C1B1CA8-0x000000018C1B1CE0
		public static string CreateAssetCacheFolder(string suggestedAssetPath, int hash = 0 /* Metadata: 0x0262A317 */); // 0x000000018C1B0E8C-0x000000018C1B0EC4
		public static void DeleteAssetCacheFolder(string assetCacheFolderPath); // 0x000000018C1B0FCC-0x000000018C1B1000
		public static void DeleteAsset(UnityEngine.Object asset); // 0x000000018C1B1034-0x000000018C1B1068
		public static void DeleteAssetAtPath(string path); // 0x000000018C1B0F98-0x000000018C1B0FCC
		public static void DeleteAssetIfInBakedFolder(UnityEngine.Object asset); // 0x000000018C1B1000-0x000000018C1B1034
		public static bool ContainsAsset(UnityEngine.Object assetObject); // 0x000000018C1B0CD0-0x000000018C1B0D08
		public static bool CopyAsset(string path, string newPath); // 0x000000018C1B0DE8-0x000000018C1B0E20
		public static UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, string copyAssetFolder, string relativePath, System.Type type, bool bOverwriteExisting); // 0x000000018C1B0DB0-0x000000018C1B0DE8
		public static UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting); // 0x000000018C1B0D78-0x000000018C1B0DB0
		public static UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type, bool bOverwriteExisting); // 0x000000018C1B0D08-0x000000018C1B0D40
		public static UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, string targetPath, System.Type type); // 0x000000018C1B0D40-0x000000018C1B0D78
		public static UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, string copyPath, System.Type type); // 0x000000018C1B0E20-0x000000018C1B0E58
		public static void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, string assetCacheRoot, string relativeFolderPath, string assetFileName, System.Type type, bool bOverwriteExisting); // 0x000000018C1B0EF8-0x000000018C1B0F2C
		public static void CreateAsset(UnityEngine.Object asset, string path); // 0x000000018C1B0EC4-0x000000018C1B0EF8
		public static void CreateAddObjectInAssetCacheFolder(string assetName, string assetObjectFileName, UnityEngine.Object objectToAdd, string relativeFolderPath, ref string exportRootPath, ref UnityEngine.Object assetDBObject); // 0x000000018C1B0E58-0x000000018C1B0E8C
		public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject); // 0x000000018C1B09D8-0x000000018C1B0A0C
		public static void SaveAndRefreshDatabase(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SaveAssetDatabase(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void RefreshAssetDatabase(); // 0x0000000186805BA0-0x0000000186805BB0
		public static UnityEngine.Object LoadAssetAtPath(string assetPath, System.Type type); // 0x000000018C1B200C-0x000000018C1B2044
		public static UnityEngine.Object LoadSubAssetAtPath(string mainPath, string subAssetPath); // 0x000000018C1B2044-0x000000018C1B20F0
		public static UnityEngine.Object[] LoadAllAssetsAtPath(string assetPath); // 0x000000018C1B1FD4-0x000000018C1B200C
		public static UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(string assetPath); // 0x000000018C1B1F9C-0x000000018C1B1FD4
		public static void ImportAsset(string assetPath, HEU_ImportAssetOptions heuOptions); // 0x000000018C1B1C3C-0x000000018C1B1C70
		public static string GetAssetWorkingPath(); // 0x000000018C1B14AC-0x000000018C1B14E4
		public static string GetAssetBakedPath(); // 0x000000018C1B10A0-0x000000018C1B10D8
		public static string GetAssetBakedPathWithAssetName(string assetName); // 0x000000018C1B1068-0x000000018C1B10A0
		public static string CreateUniqueBakePath(string assetName); // 0x000000018C1B0F60-0x000000018C1B0F98
		public static void CreatePathWithFolders(string inPath); // 0x000000018C1B0F2C-0x000000018C1B0F60
		public static string AppendMeshesPathToAssetFolder(string inAssetCacheFolder); // 0x000000018C1B0AC4-0x000000018C1B0B40
		public static string AppendTexturesPathToAssetFolder(string inAssetCacheFolder); // 0x000000018C1B0C54-0x000000018C1B0CD0
		public static string AppendMaterialsPathToAssetFolder(string inAssetCacheFolder); // 0x000000018C1B0A0C-0x000000018C1B0A88
		public static string AppendTerrainPathToAssetFolder(string inAssetCacheFolder); // 0x000000018C1B0BD8-0x000000018C1B0C54
		public static string[] GetAssetSubFolders(); // 0x000000018C1B13E4-0x000000018C1B14AC
		public static string AppendPrefabPath(string inAssetCacheFolder, string assetName); // 0x000000018C1B0B40-0x000000018C1B0BD8
		public static string AppendMeshesAssetFileName(string assetName); // 0x000000018C1B0A88-0x000000018C1B0AC4
		public static bool IsSubAsset(UnityEngine.Object obj); // 0x00000001843FFFF0-0x0000000184400000
		public static string[] GetAssetPathsFromAssetBundle(string assetBundleFileName); // 0x0000000185829EC0-0x0000000185829ED0
		public static bool IsAssetSavedInScene(GameObject go); // 0x000000018C1B1CE0-0x000000018C1B1D18
		public static void SelectAssetAtPath(string path); // 0x0000000186805BA0-0x0000000186805BB0
		public static void PrintDependencies(GameObject targetGO); // 0x0000000186805BA0-0x0000000186805BB0
		public static string GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj); // 0x000000018C1B17D0-0x000000018C1B1880
		public static bool IsValidFolderName(string name); // 0x00000001851A4410-0x00000001851A4420
		public static T LoadUnityAssetFromUniqueAssetPath<T>(string assetPath)
			where T : UnityEngine.Object;
		public static T GetBuiltinExtraResource<T>(string resourceName)
			where T : UnityEngine.Object;
	}

	public class HEU_Defines // TypeDefIndex: 78227
	{
		// Fields
		public const string HEU_PRODUCT_NAME = "HoudiniEngine"; // Metadata: 0x0262A325
		public const string HEU_NAME = "Houdini Engine"; // Metadata: 0x0262A333
		public static string HEU_PLUGIN_PATH; // 0x00
		public static string HEU_TEXTURES_PATH; // 0x08
		public static string HEU_BAKED_ASSETS_PATH; // 0x10
		public static string HEU_ENGINE_ASSETS; // 0x18
		public const string HAPI_PATH = "HAPI_PATH"; // Metadata: 0x0262A342
		public const string HEU_ENVPATH_PREFIX = "HEU_ENVPATH_"; // Metadata: 0x0262A34C
		public const string HEU_ENVPATH_KEY = "$"; // Metadata: 0x0262A359
		public const int HEU_INVALID_NODE_ID = -1; // Metadata: 0x0262A35B
		public const string HEU_DEFAULT_ASSET_NAME = "HoudiniAssetRoot"; // Metadata: 0x0262A35C
		public const string HEU_SESSION_PIPENAME = "hapi"; // Metadata: 0x0262A36D
		public const string HEU_SESSION_LOCALHOST = "localhost"; // Metadata: 0x0262A372
		public const int HEU_SESSION_PORT = 9090; // Metadata: 0x0262A37C
		public const string HEU_SESSION_SHARED_MEMORY_NAME = "hapi"; // Metadata: 0x0262A380
		public const int HEU_SESSION_SHARED_MEMORY_BUFFER_SIZE = 100; // Metadata: 0x0262A385
		public const HAPI_ThriftSharedMemoryBufferType HEU_SESSION_SHARED_MEMORY_BUFFER_TYPE = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER; // Metadata: 0x0262A387
		public const float HEU_SESSION_TIMEOUT = 100000f; // Metadata: 0x0262A388
		public const bool HEU_SESSION_AUTOCLOSE = true; // Metadata: 0x0262A38C
		public const int HAPI_MAX_PAGE_SIZE = 500000; // Metadata: 0x0262A38D
		public const int HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW = 3; // Metadata: 0x0262A391
		public const int HAPI_MAX_VERTICES_PER_FACE = 3; // Metadata: 0x0262A392
		public const bool HAPI_CURVE_REFINE_TO_LINEAR = true; // Metadata: 0x0262A393
		public const float HAPI_CURVE_LOD = 8f; // Metadata: 0x0262A394
		public const float HAPI_VOLUME_POSITION_MULT = 2f; // Metadata: 0x0262A398
		public const float HAPI_VOLUME_SURFACE_MAX_PT_PER_C = 64000f; // Metadata: 0x0262A39C
		public const float HAPI_VOLUME_SURFACE_DELTA_MULT = 1.2f; // Metadata: 0x0262A3A0
		public const float HAPI_VOLUME_SURFACE_PT_SIZE_MULT = 1800f; // Metadata: 0x0262A3A4
		public const string DEFAULT_TOP_NODE_FILTER = "HE_"; // Metadata: 0x0262A3A8
		public const string DEFAULT_TOP_OUTPUT_FILTER = "HE_OUT_"; // Metadata: 0x0262A3AC
		public const string HAPI_ATTRIB_ORIENT = "orient"; // Metadata: 0x0262A3B4
		public const string HAPI_ATTRIB_ROTATION = "rot"; // Metadata: 0x0262A3BB
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x0262A3BF
		public const string HAPI_ATTRIB_ALPHA = "Alpha"; // Metadata: 0x0262A3C5
		public const string HAPI_HANDLE_TRANSFORM = "xform"; // Metadata: 0x0262A3CB
		public const int HAPI_MAX_UVS = 8; // Metadata: 0x0262A3D1
		public const string HAPI_OBJMERGE_TRANSFORM_PARAM = "xformtype"; // Metadata: 0x0262A3D2
		public const string HAPI_OBJMERGE_PACK_GEOMETRY = "pack"; // Metadata: 0x0262A3DC
		public const string HAPI_OBJPATH_1_PARAM = "objpath1"; // Metadata: 0x0262A3E1
		public const string NO_EXISTING_SESSION = "No existing session."; // Metadata: 0x0262A3EA
		public const string HEU_ERROR_TITLE = "Houdini Engine Error"; // Metadata: 0x0262A3FF
		public const string HEU_INSTALL_INFO = "Houdini Engine Installation Info"; // Metadata: 0x0262A414
		public const string PLUGIN_STORE_KEYS = "HoudiniEnginePluginKeys"; // Metadata: 0x0262A435
		public const string PLUGIN_STORE_DATA = "HoudiniEnginePluginData"; // Metadata: 0x0262A44D
		public const string PLUGIN_SESSION_DATA = "HoudiniEngineSession"; // Metadata: 0x0262A465
		public const string PLUGIN_SETTINGS_FILE = "heu_settings.ini"; // Metadata: 0x0262A47A
		public const string PLUGIN_SESSION_FILE = "heu_session.txt"; // Metadata: 0x0262A48B
		public const string COOK_LOGS_FILE = "cook_logs_file.txt"; // Metadata: 0x0262A49B
		public const string DEFAULT_COLLISION_GEO = "collision_geo"; // Metadata: 0x0262A4AE
		public const string DEFAULT_RENDERED_COLLISION_GEO = "rendered_collision_geo"; // Metadata: 0x0262A4BC
		public const string DEFAULT_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo"; // Metadata: 0x0262A4D3
		public const string DEFAULT_CONVEX_COLLISION_GEO = "convex"; // Metadata: 0x0262A4F1
		public const string DEFAULT_SIMPLE_COLLISION_GEO = "collision_geo_simple"; // Metadata: 0x0262A4F8
		public const string DEFAULT_SIMPLE_RENDERED_COLLISION_GEO = "rendered_collision_geo_simple"; // Metadata: 0x0262A50D
		public const string DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO = "rendered_convex_collision_geo_simple"; // Metadata: 0x0262A52B
		public const string DEFAULT_COLLISION_TRIGGER = "trigger"; // Metadata: 0x0262A550
		public const string DEFAULT_UNITY_MATERIAL_ATTR = "unity_material"; // Metadata: 0x0262A558
		public const string DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR = "unity_sub_material_name"; // Metadata: 0x0262A567
		public const string DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR = "unity_sub_material_index"; // Metadata: 0x0262A57F
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR = "unity_hf_texture_diffuse"; // Metadata: 0x0262A598
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR = "unity_hf_texture_mask"; // Metadata: 0x0262A5B1
		public const string DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR = "unity_hf_texture_normal"; // Metadata: 0x0262A5C7
		public const string DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR = "unity_hf_normal_scale"; // Metadata: 0x0262A5DF
		public const string DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR = "unity_hf_metallic"; // Metadata: 0x0262A5F5
		public const string DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR = "unity_hf_smoothness"; // Metadata: 0x0262A607
		public const string DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR = "unity_hf_specular"; // Metadata: 0x0262A61B
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR = "unity_hf_tile_offset"; // Metadata: 0x0262A62D
		public const string DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR = "unity_hf_tile_size"; // Metadata: 0x0262A642
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR = "unity_hf_terraindata_file"; // Metadata: 0x0262A655
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR = "unity_hf_terraindata_export_file"; // Metadata: 0x0262A66F
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR = "unity_hf_terrainlayer_file"; // Metadata: 0x0262A690
		public const string DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH = "unity_hf_terraindata_export_path"; // Metadata: 0x0262A6AB
		public const string DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE = "unity_hf_height_range"; // Metadata: 0x0262A6CC
		public const string DEFAULT_UNITY_HEIGHTFIELD_YPOS = "unity_hf_ypos"; // Metadata: 0x0262A6E2
		public const string HEIGHTFIELD_TREEPROTOTYPE = "unity_hf_tree_prototype"; // Metadata: 0x0262A6F0
		public const string HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX = "unity_hf_treeinstance_prototypeindex"; // Metadata: 0x0262A708
		public const string HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE = "unity_hf_treeinstance_heightscale"; // Metadata: 0x0262A72D
		public const string HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE = "unity_hf_treeinstance_widthscale"; // Metadata: 0x0262A74F
		public const string HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR = "unity_hf_treeinstance_lightmapcolor"; // Metadata: 0x0262A770
		public const string HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH = "unity_hf_detail_resolution_patch"; // Metadata: 0x0262A794
		public const string HEIGHTFIELD_UNITY_TILE = "unity_hf_tile"; // Metadata: 0x0262A7B5
		public const string HEIGHTFIELD_DETAIL_DISTANCE = "unity_hf_detail_distance"; // Metadata: 0x0262A7C3
		public const string HEIGHTFIELD_DETAIL_DENSITY = "unity_hf_detail_density"; // Metadata: 0x0262A7DC
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB = "unity_hf_detail_prototype_prefab"; // Metadata: 0x0262A7F4
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE = "unity_hf_detail_prototype_texture"; // Metadata: 0x0262A815
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR = "unity_hf_detail_prototype_bendfactor"; // Metadata: 0x0262A837
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR = "unity_hf_detail_prototype_drycolor"; // Metadata: 0x0262A85C
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR = "unity_hf_detail_prototype_healthycolor"; // Metadata: 0x0262A87F
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT = "unity_hf_detail_prototype_maxheight"; // Metadata: 0x0262A8A6
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH = "unity_hf_detail_prototype_maxwidth"; // Metadata: 0x0262A8CA
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT = "unity_hf_detail_prototype_minheight"; // Metadata: 0x0262A8ED
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH = "unity_hf_detail_prototype_minwidth"; // Metadata: 0x0262A911
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD = "unity_hf_detail_prototype_noisespread"; // Metadata: 0x0262A934
		public const string HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE = "unity_hf_detail_prototype_rendermode"; // Metadata: 0x0262A95A
		public const string HEIGHTFIELD_LAYER_ATTR_TYPE = "unity_hf_layer_type"; // Metadata: 0x0262A97F
		public const string HEIGHTFIELD_LAYER_TYPE_DETAIL = "detail"; // Metadata: 0x0262A993
		public const string HAPI_HEIGHTFIELD_TILE_ATTR = "tile"; // Metadata: 0x0262A99A
		public const string HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT = "height"; // Metadata: 0x0262A99F
		public const string HAPI_HEIGHTFIELD_LAYERNAME_MASK = "mask"; // Metadata: 0x0262A9A6
		public const string MAT_OGL_DIFF_ATTR = "ogl_diff"; // Metadata: 0x0262A9AB
		public const string MAT_DIFF_ATTR = "basecolor"; // Metadata: 0x0262A9B4
		public const string MAT_OGL_TEX1_ATTR = "ogl_tex1"; // Metadata: 0x0262A9BE
		public const string MAT_OGL_TEX1_ATTR_ENABLED = "ogl_use_tex1"; // Metadata: 0x0262A9C7
		public const string MAT_BASECOLOR_ATTR = "basecolor_texture"; // Metadata: 0x0262A9D4
		public const string MAT_BASECOLOR_ATTR_ENABLED = "basecolor_useTexture"; // Metadata: 0x0262A9E6
		public const string MAT_MAP_ATTR = "map"; // Metadata: 0x0262A9FB
		public const string MAT_OGL_NORMAL_ATTR = "ogl_normalmap"; // Metadata: 0x0262A9FF
		public const string MAT_NORMAL_ATTR = "baseNormal_texture"; // Metadata: 0x0262AA0D
		public const string MAT_NORMAL_ATTR_ENABLED = "baseBumpAndNormal_enable"; // Metadata: 0x0262AA20
		public const string MAT_OGL_SPEC_ATTR = "ogl_spec"; // Metadata: 0x0262AA39
		public const string MAT_SPEC_ATTR = "reflect"; // Metadata: 0x0262AA42
		public const string MAT_OGL_SPEC_MAP_ATTR = "ogl_specmap"; // Metadata: 0x0262AA4A
		public const string MAT_OGL_SPEC_MAP_ATTR_ENABLED = "ogl_use_specmap"; // Metadata: 0x0262AA56
		public const string MAT_SPEC_MAP_ATTR = "reflect_texture"; // Metadata: 0x0262AA66
		public const string MAT_SPEC_MAP_ATTR_ENABLED = "reflect_useTexture"; // Metadata: 0x0262AA76
		public const string MAT_OGL_ROUGH_ATTR = "ogl_rough"; // Metadata: 0x0262AA89
		public const string MAT_ROUGH_ATTR = "rough"; // Metadata: 0x0262AA93
		public const string MAT_OGL_ROUGH_MAP_ATTR = "ogl_roughmap"; // Metadata: 0x0262AA99
		public const string MAT_OGL_ROUGH_MAP_ATTR_ENABLED = "ogl_use_roughmap"; // Metadata: 0x0262AAA6
		public const string MAT_ROUGH_MAP_ATTR = "rough_texture"; // Metadata: 0x0262AAB7
		public const string MAT_ROUGH_MAP_ATTR_ENABLED = "rough_useTexture"; // Metadata: 0x0262AAC5
		public const string MAT_OGL_METALLIC_ATTR = "ogl_metallic"; // Metadata: 0x0262AAD6
		public const string MAT_METALLIC_ATTR = "metallic"; // Metadata: 0x0262AAE3
		public const string MAT_OGL_METALLIC_MAP_ATTR = "ogl_metallicmap"; // Metadata: 0x0262AAEC
		public const string MAT_OGL_METALLIC_MAP_ATTR_ENABLED = "ogl_use_metallicmap"; // Metadata: 0x0262AAFC
		public const string MAT_METALLIC_MAP_ATTR = "metallic_texture"; // Metadata: 0x0262AB10
		public const string MAT_METALLIC_MAP_ATTR_ENABLED = "metallic_useTexture"; // Metadata: 0x0262AB21
		public const string MAT_OGL_EMISSIVE_ATTR = "ogl_emit"; // Metadata: 0x0262AB35
		public const string MAT_EMISSIVE_ATTR = "emitcolor"; // Metadata: 0x0262AB3E
		public const string MAT_OGL_EMISSIVE_MAP_ATTR = "ogl_emissionmap"; // Metadata: 0x0262AB48
		public const string MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED = "ogl_use_emissionmap"; // Metadata: 0x0262AB58
		public const string MAT_EMISSIVE_MAP_ATTR = "emitcolor_texture"; // Metadata: 0x0262AB6C
		public const string MAT_EMISSIVE_MAP_ATTR_ENABLED = "emitcolor_useTexture"; // Metadata: 0x0262AB7E
		public const string MAT_OGL_ALPHA_ATTR = "ogl_alpha"; // Metadata: 0x0262AB93
		public const string MAT_ALPHA_ATTR = "opac"; // Metadata: 0x0262AB9D
		public const string MAT_OGL_OPACITY_MAP_ATTR = "ogl_opacitymap"; // Metadata: 0x0262ABA2
		public const string MAT_OGL_OPACITY_MAP_ATTR_ENABLED = "ogl_use_opacitymap"; // Metadata: 0x0262ABB1
		public const string MAT_OPACITY_MAP_ATTR = "opaccolor_texture"; // Metadata: 0x0262ABC4
		public const string MAT_OPACITY_MAP_ATTR_ENABLED = "opaccolor_useTexture"; // Metadata: 0x0262ABD6
		public const string MAT_OGL_TRANSPARENCY_ATTR = "ogl_transparency"; // Metadata: 0x0262ABEB
		public const string MAT_OGL_TRANSPARENCY_ATTR_ENABLED = "ogl_use_alpha_transparency"; // Metadata: 0x0262ABFC
		public const string MAT_OGL_OCCLUSION_MAP_ATTR = "ogl_occlusionmap"; // Metadata: 0x0262AC17
		public const string MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED = "ogl_use_occlusionmap"; // Metadata: 0x0262AC28
		public const string CURVE_COORDS_PARAM = "coords"; // Metadata: 0x0262AC3D
		public const string CURVE_TYPE_PARAM = "type"; // Metadata: 0x0262AC44
		public const string CURVE_METHOD_PARAM = "method"; // Metadata: 0x0262AC49
		public const string CURVE_CLOSE_PARAM = "close"; // Metadata: 0x0262AC50
		public const string CURVE_REVERSE_PARAM = "reverse"; // Metadata: 0x0262AC56
		public const string HENGINE_STORE_ATTR = "hengine_attr_store"; // Metadata: 0x0262AC5E
		public const string DEFAULT_UNITY_TAG_ATTR = "unity_tag"; // Metadata: 0x0262AC71
		public const string DEFAULT_UNITY_SCRIPT_ATTR = "unity_script"; // Metadata: 0x0262AC7B
		public const string DEFAULT_UNITY_INSTANCE_ATTR = "unity_instance"; // Metadata: 0x0262AC88
		public const string UNITY_USE_INSTANCE_FLAGS_ATTR = "unity_use_instance_flags"; // Metadata: 0x0262AC97
		public const string DEFAULT_UNITY_INPUT_MESH_ATTR = "unity_input_mesh_name"; // Metadata: 0x0262ACB0
		public const string DEFAULT_UNITY_STATIC_ATTR = "unity_static"; // Metadata: 0x0262ACC6
		public const string DEFAULT_UNITY_LAYER_ATTR = "unity_layer"; // Metadata: 0x0262ACD3
		public const string DEFAULT_UNITY_MESH_READABLE = "unity_mesh_readable"; // Metadata: 0x0262ACDF
		public const string DEFAULT_INSTANCE_PREFIX_ATTR = "instance_prefix"; // Metadata: 0x0262ACF3
		public const string UNITY_SHADER_COLOR = "_Color"; // Metadata: 0x0262AD03
		public const string UNITY_SHADER_SPEC_COLOR = "_SpecColor"; // Metadata: 0x0262AD0A
		public const string UNITY_SHADER_SPEC_MAP = "_SpecMap"; // Metadata: 0x0262AD15
		public const string UNITY_SHADER_METALLIC = "_Metallic"; // Metadata: 0x0262AD1E
		public const string UNITY_SHADER_METALLIC_MAP = "_MetallicMap"; // Metadata: 0x0262AD28
		public const string UNITY_SHADER_BUMP_MAP = "_BumpMap"; // Metadata: 0x0262AD35
		public const string UNITY_SHADER_EMISSION_COLOR = "_EmissionColor"; // Metadata: 0x0262AD3E
		public const string UNITY_SHADER_EMISSION_MAP = "_EmissionMap"; // Metadata: 0x0262AD4D
		public const string UNITY_SHADER_SMOOTHNESS = "_Smoothness"; // Metadata: 0x0262AD5A
		public const string UNITY_SHADER_SMOOTHNESS_MAP = "_SmoothnessMap"; // Metadata: 0x0262AD66
		public const string UNITY_SHADER_SHININESS = "_Shininess"; // Metadata: 0x0262AD75
		public const string UNITY_SHADER_OCCLUSION = "_Occlusion"; // Metadata: 0x0262AD80
		public const string UNITY_SHADER_OCCLUSION_MAP = "_OcclusionMap"; // Metadata: 0x0262AD8B
		public const string UNITY_SHADER_OPACITY = "_Opacity"; // Metadata: 0x0262AD99
		public const string UNITY_SHADER_OPACITY_MAP = "_OpacityMap"; // Metadata: 0x0262ADA2
		public const string UNITY_EDITORONLY_TAG = "EditorOnly"; // Metadata: 0x0262ADAE
		public const string UNITY_HDADATA_NAME = "HDA_Data"; // Metadata: 0x0262ADB9
		public const string HOUDINI_SHADER_PREFIX = "Houdini/"; // Metadata: 0x0262ADC2
		public const string DEFAULT_STANDARD_SHADER = "HoudiniStandard"; // Metadata: 0x0262ADCB
		public const string DEFAULT_VERTEXCOLOR_SHADER = "HoudiniStandard"; // Metadata: 0x0262ADDB
		public const string DEFAULT_TRANSPARENT_SHADER = "HoudiniStandardAlpha"; // Metadata: 0x0262ADEB
		public const string DEFAULT_STANDARD_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x0262AE00
		public const string DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x0262AE10
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR = "HoudiniSpecular"; // Metadata: 0x0262AE2B
		public const string DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY = "Legacy/SpecularVertexColor"; // Metadata: 0x0262AE3B
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR = "HoudiniSpecularAlpha"; // Metadata: 0x0262AE56
		public const string DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY = "Legacy/AlphaSpecularVertexColor"; // Metadata: 0x0262AE6B
		public const string DEFAULT_CURVE_SHADER = "LineShader"; // Metadata: 0x0262AE8B
		public const string DEFAULT_TERRAIN_SHADER = "Nature/Terrain/Standard"; // Metadata: 0x0262AE96
		public const string DEFAULT_STANDARD_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x0262AEAE
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP = "HDRP/StandardLit"; // Metadata: 0x0262AEBF
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP = "HDRP/StandardLitAlpha"; // Metadata: 0x0262AED0
		public const string DEFAULT_STANDARD_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x0262AEE6
		public const string DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR = "HDRP/SpecularLit"; // Metadata: 0x0262AEF7
		public const string DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR = "HDRP/SpecularLitAlpha"; // Metadata: 0x0262AF08
		public const string DEFAULT_CURVE_SHADER_HDRP = "HDRP/Color"; // Metadata: 0x0262AF1E
		public const string DEFAULT_TERRAIN_SHADER_HDRP = "HDRP/TerrainLit"; // Metadata: 0x0262AF29
		public const string DEFAULT_STANDARD_SHADER_URP = "URP/StandardLit"; // Metadata: 0x0262AF39
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP = "URP/StandardLit"; // Metadata: 0x0262AF49
		public const string DEFAULT_TRANSPARENT_SHADER_URP = "URP/StandardLitAlpha"; // Metadata: 0x0262AF59
		public const string DEFAULT_STANDARD_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x0262AF6E
		public const string DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR = "URP/SpecularLit"; // Metadata: 0x0262AF7E
		public const string DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR = "URP/SpecularLitAlpha"; // Metadata: 0x0262AF8E
		public const string DEFAULT_CURVE_SHADER_URP = "URP/Color"; // Metadata: 0x0262AFA3
		public const string DEFAULT_TERRAIN_SHADER_URP = "Universal Render Pipeline/Terrain/Lit"; // Metadata: 0x0262AFAD
		public const string DEFAULT_UNITY_BUILTIN_RESOURCES = "Resources/unity_builtin_extra"; // Metadata: 0x0262AFD3
		public const string DEFAULT_TERRAIN_MATERIAL_PATH = "Resources/unity_builtin_extra::name::Default-Terrain-Standard"; // Metadata: 0x0262AFF1
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_HDRP = "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipelineResources/Material/DefaultHDTerrainMaterial.mat"; // Metadata: 0x0262B02F
		public const string DEFAULT_TERRAIN_MATERIAL_PATH_URP = "Packages/com.unity.render-pipelines.universal/Runtime/Materials/TerrainLit.mat"; // Metadata: 0x0262B0AA
		public const string DEFAULT_MATERIAL = "HEU_DEFAULT_MATERIAL"; // Metadata: 0x0262B0FA
		public static int DEFAULT_MATERIAL_KEY; // 0x20
		public const string EDITABLE_MATERIAL = "HEU_EDITABLE_MATERIAL"; // Metadata: 0x0262B10F
		public static int EDITABLE_MATERIAL_KEY; // 0x24
		public const int HEU_INVALID_MATERIAL = -1; // Metadata: 0x0262B125
		public const string HEU_ASSET_CACHE_PATH = "HoudiniEngineAssetCache"; // Metadata: 0x0262B126
		public const string HEU_WORKING_PATH = "Working"; // Metadata: 0x0262B13E
		public const string HEU_BAKED_PATH = "Baked"; // Metadata: 0x0262B146
		public const string HEU_BAKED_HDA = "_bakedHDA"; // Metadata: 0x0262B14C
		public const string HEU_BAKED_CLONE = "_bakedClone"; // Metadata: 0x0262B156
		public const string HEU_INSTANCE = "_Instance"; // Metadata: 0x0262B162
		public const string HEU_INSTANCE_PATTERN = "_Instance\\d*\\z"; // Metadata: 0x0262B16C
		public const string HEU_INSTANCE_SPLIT_ATTR = "unity_split_attr"; // Metadata: 0x0262B17B
		public const string HEU_DEFAULT_GEO_GROUP_NAME = "main_geo"; // Metadata: 0x0262B18C
		public const string HEU_DEFAULT_LOD_NAME = "lod"; // Metadata: 0x0262B195
		public const string HEU_UNITY_LOD_TRANSITION_ATTR = "lod_screensizes"; // Metadata: 0x0262B199
		public const string HEU_SUBASSET = "SUBASSET::"; // Metadata: 0x0262B1A9
		public const string HEU_HENGINE_TOOLS_SHIPPED_FOLDER = "<HFS>/engine/tools"; // Metadata: 0x0262B1B4
		public const string HEU_HENGINE_SHIPPED_SHELF = "Default"; // Metadata: 0x0262B1C7
		public const string HEU_PATH_KEY_PROJECT = "<PROJECT_PATH>"; // Metadata: 0x0262B1CF
		public const string HEU_PATH_KEY_PLUGIN = "<PLUGIN_PATH>"; // Metadata: 0x0262B1DE
		public const string HEU_PATH_KEY_HFS = "<HFS>"; // Metadata: 0x0262B1EC
		public const string HEU_PATH_KEY_TOOL = "HOUDINI_TOOL_PATH"; // Metadata: 0x0262B1F2
		public const string HEU_USERMSG_NONEDITOR_NOT_SUPPORTED = "Houdini Engine does not support non-Editor asset creation at this time!"; // Metadata: 0x0262B204
		public const string HEU_TERRAIN_SPLAT_DEFAULT = "Textures/heu_terrain_default_splat"; // Metadata: 0x0262B24D
		public const string HEU_FOLDER_MESHES = "Meshes"; // Metadata: 0x0262B270
		public const string HEU_FOLDER_MATERIALS = "Materials"; // Metadata: 0x0262B277
		public const string HEU_FOLDER_TERRAIN = "Terrain"; // Metadata: 0x0262B281
		public const string HEU_FOLDER_TILE = "Tile"; // Metadata: 0x0262B289
		public const string HEU_FOLDER_TEXTURES = "Textures"; // Metadata: 0x0262B28E
		public const string HEU_EXT_ASSET = ".asset"; // Metadata: 0x0262B297
		public const string HEU_EXT_MAT = ".mat"; // Metadata: 0x0262B29E
		public const string HEU_EXT_TERRAINDATA = ".terraindata"; // Metadata: 0x0262B2A3
		public const string HEU_EXT_TERRAINLAYER = ".terrainlayer"; // Metadata: 0x0262B2B0
		public const string HEU_KEY_CTRL = "Ctrl"; // Metadata: 0x0262B2BE
	
		// Constructors
		public HEU_Defines(); // 0x0000000186805BA0-0x0000000186805BB0
		static HEU_Defines(); // 0x000000018C1B20F0-0x000000018C1B22BC
	}

	public static class HEU_HAPIUtility // TypeDefIndex: 78228
	{
		// Methods
		public static string GetHoudiniEngineInstallationInfo(); // 0x000000018C1B40F0-0x000000018C1B411C
		public static string GetEnvironmentPath(); // 0x000000018C1B3AA4-0x000000018C1B3B14
		public static string GetRealPathFromHFSPath(string inPath); // 0x000000018C1B49C0-0x000000018C1B4AE4
		public static bool DoesMappedPathExist(string inPath); // 0x000000018C1B31A0-0x000000018C1B3210
		public static bool IsHoudiniAssetFile(string filePath); // 0x000000018C1B4D00-0x000000018C1B4E18
		public static string FindHoudiniAssetFileInPathWithExt(string filePath); // 0x000000018C1B3210-0x000000018C1B3398
		public static void Log(string message); // 0x000000018C1B53B8-0x000000018C1B53C0
		public static void LogWarning(string message); // 0x000000018C1B53B0-0x000000018C1B53B8
		public static void LogError(string message); // 0x000000018C1B53A8-0x000000018C1B53B0
		public static string LocateValidFilePath(UnityEngine.Object inObject); // 0x000000018C1B534C-0x000000018C1B53A8
		public static string LocateValidFilePath(string assetName, string inFilePath); // 0x000000018459BB50-0x000000018459BB60
		public static GameObject InstantiateHDA(string filePath, Vector3 initialPosition, HEU_SessionBase session, bool bBuildAsync, bool bLoadFromMemory = false /* Metadata: 0x0262B2C3 */, bool bAlwaysOverwriteOnLoad = false /* Metadata: 0x0262B2C4 */, GameObject rootGO = null); // 0x000000018C1B4AE4-0x000000018C1B4D00
		public static bool LoadHDAFile(HEU_SessionBase session, string assetPath, out int assetLibraryID, out string[] assetNames); // 0x000000018C1B5294-0x000000018C1B534C
		public static bool CreateAndCookAssetNode(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID); // 0x000000018C1B2C00-0x000000018C1B2C70
		public static bool CreateAndCookCurveAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID); // 0x000000018C1B2C70-0x000000018C1B2CC8
		public static bool CreateAndCookInputAsset(HEU_SessionBase session, string assetName, bool bCookTemplatedGeos, out int newAssetID); // 0x000000018C1B2CC8-0x000000018C1B2D30
		public static bool CookNodeInHoudini(HEU_SessionBase session, int nodeID, bool bCookTemplatedGeos, string assetName); // 0x000000018C1B29C4-0x000000018C1B29DC
		public static bool CookNodeInHoudiniWithOptions(HEU_SessionBase session, int nodeID, HAPI_CookOptions options, string assetName); // 0x000000018C1B29C4-0x000000018C1B29DC
		public static HAPI_CookOptions GetDefaultCookOptions(HEU_SessionBase session); // 0x000000018C1B3A68-0x000000018C1B3AA4
		public static bool ProcessHoudiniCookStatus(HEU_SessionBase session, string assetName); // 0x000000018C1B53C0-0x000000018C1B5440
		public static GameObject CreateNewAsset(HEU_AssetTypeWrapper assetType, string rootName = "HoudiniAsset" /* Metadata: 0x0262B2C5 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x0262B2D2 */, GameObject rootGO = null); // 0x000000018C1B2D30-0x000000018C1B2D84
		internal static GameObject CreateNewAsset(HEU_HoudiniAsset.HEU_AssetType assetType, string rootName = "HoudiniAsset" /* Metadata: 0x0262B2D3 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x0262B2E0 */, GameObject rootGO = null); // 0x000000018C1B2D84-0x000000018C1B2E38
		public static GameObject CreateNewCurveAsset(string name = "HoudiniCurve" /* Metadata: 0x0262B2E1 */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x0262B2EE */, GameObject rootGO = null); // 0x000000018C1B2E38-0x000000018C1B2E6C
		public static GameObject CreateNewInputAsset(string name = "HoudiniInput" /* Metadata: 0x0262B2EF */, Transform parentTransform = null, HEU_SessionBase session = null, bool bBuildAsync = true /* Metadata: 0x0262B2FC */, GameObject rootGO = null); // 0x000000018C1B2E6C-0x000000018C1B2EA0
		public static GameObject LoadGeoWithNewGeoSync(HEU_SessionBase session = null); // 0x0000000185829EC0-0x0000000185829ED0
		public static void DestroyChildren(Transform inTransform); // 0x000000018C1B2EA0-0x000000018C1B3190
		public static void DestroyGameObject(GameObject gameObect, bool bRegisterUndo = false /* Metadata: 0x0262B2FD */); // 0x000000018C1B3190-0x000000018C1B31A0
		public static void DestroyChildrenWithComponent<T>(GameObject gameObject)
			where T : Component;
		public static bool IsNodeValidInHoudini(HEU_SessionBase session, int nodeID); // 0x000000018C1B4E18-0x000000018C1B4E34
		public static HEU_HoudiniAssetRoot GetAssetInScene(int assetID); // 0x000000018C1B397C-0x000000018C1B3A68
		public static void ApplyWorldTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform); // 0x000000018C1B2750-0x000000018C1B29C4
		public static void ApplyLocalTransfromFromHoudiniToUnity(ref HAPI_Transform hapiTransform, Transform unityTransform); // 0x000000018C1B24EC-0x000000018C1B269C
		public static void ApplyLocalTransfromFromHoudiniToUnityForInstance(ref HAPI_Transform hapiTransform, Transform unityTransform); // 0x000000018C1B22BC-0x000000018C1B24EC
		public static void ApplyMatrixToLocalTransform(ref Matrix4x4 matrix, Transform transform); // 0x000000018C1B269C-0x000000018C1B2750
		public static Matrix4x4 GetMatrixFromHAPITransform(ref HAPI_Transform hapiTransform, bool bConvertToUnity = true /* Metadata: 0x0262B2FE */); // 0x000000018C1B41CC-0x000000018C1B43F4
		public static Quaternion GetQuaternion(ref Matrix4x4 m); // 0x000000018C1B45F8-0x000000018C1B49C0
		public static Vector3 GetPosition(ref Matrix4x4 m); // 0x000000018C1B45AC-0x000000018C1B45F8
		public static void SetMatrixPosition(ref Matrix4x4 m, ref Vector3 position); // 0x000000018C1B5440-0x000000018C1B548C
		public static Vector3 GetScale(ref Matrix4x4 m); // 0x00000001872504B0-0x00000001872505A0
		public static HAPI_TransformEuler GetHAPITransformFromMatrix(ref Matrix4x4 mat); // 0x000000018C1B3B14-0x000000018C1B3D00
		public static HAPI_TransformEuler GetHAPITransform(ref Vector3 p, ref Vector3 r, ref Vector3 s); // 0x000000018C1B3F5C-0x000000018C1B40F0
		public static HAPI_Transform GetHAPITransformQuatFromMatrix(ref Matrix4x4 mat); // 0x000000018C1B3D00-0x000000018C1B3F5C
		public static Matrix4x4 GetMatrix4x4(ref Vector3 p, ref Vector3 r, ref Vector3 s); // 0x000000018C1B411C-0x000000018C1B41CC
		public static bool IsSameTransform(ref Matrix4x4 transformMatrix, ref Vector3 p, ref Vector3 r, ref Vector3 s); // 0x000000018C1B4E90-0x000000018C1B4F4C
		public static bool IsEqualTol(float a, float b, float t = 1E-05f /* Metadata: 0x0262B2FF */); // 0x0000000186429B00-0x0000000186429B20
		public static bool IsTransformEqual(ref HAPI_Transform transA, ref HAPI_Transform transB); // 0x000000018C1B4F78-0x000000018C1B516C
		public static bool IsViewportEqual(ref HAPI_Viewport viewA, ref HAPI_Viewport viewB); // 0x000000018C1B516C-0x000000018C1B5294
		public static bool IsSessionSyncEqual(ref HAPI_SessionSyncInfo syncA, ref HAPI_SessionSyncInfo syncB); // 0x000000018C1B4F4C-0x000000018C1B4F64
		public static bool DoesGeoPartHaveAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo); // 0x000000018C1B29C4-0x000000018C1B29DC
		public static void SetAnimationCurveTangentModes(AnimationCurve animCurve, List<int> tangentValues); // 0x0000000186805BA0-0x0000000186805BB0
		public static bool IsSupportedPolygonType(HAPI_PartType partType); // 0x000000018C1B4F64-0x000000018C1B4F78
		public static int GetParentNodeID(HEU_SessionBase session, int nodeID); // 0x000000018C1B458C-0x000000018C1B45AC
		public static bool GetObjectInfos(HEU_SessionBase session, int assetID, ref HAPI_NodeInfo nodeInfo, out HAPI_ObjectInfo[] objectInfos, out HAPI_Transform[] objectTransforms); // 0x000000018C1B43F4-0x000000018C1B4554
		public static bool ContainsSopNodes(HEU_SessionBase session, int nodeId); // 0x000000018C1B29C4-0x000000018C1B29DC
		public static bool IsObjNodeFullyVisible(HEU_SessionBase session, HashSet<int> allObjectIds, int inRootNodeId, int inChildNodeId); // 0x000000018C1B4E34-0x000000018C1B4E90
		public static bool GetOutputIndex(HEU_SessionBase session, int nodeId, ref int outputIndex); // 0x000000018C1B4554-0x000000018C1B458C
		internal static void GatherAllAssetGeoInfos(HEU_SessionBase session, HAPI_AssetInfo assetInfo, HAPI_ObjectInfo objectInfo, bool bUseOutputNodes, bool bGetEditableNodes, ref List<HAPI_GeoInfo> outGeoInfos); // 0x000000018C1B3398-0x000000018C1B34C0
		internal static void GatherAllObjectGeoInfos(HEU_SessionBase session, int assetId, bool bUseOutputNodes, ref List<HAPI_GeoInfo> outGeoInfos); // 0x000000018C1B38E0-0x000000018C1B397C
		private static void GatherAllAssetOutputs(HEU_SessionBase session, int nodeId, bool bUseOutputNodes, bool bOutputTemplatedGeos, ref List<HAPI_GeoInfo> outGeoInfos); // 0x000000018C1B34C0-0x000000018C1B38E0
		public static string ToHapiVariableName(string name); // 0x000000018C1B548C-0x000000018C1B54FC
		public static void ConvertPositionUnityToHoudini(ref Vector3 position); // 0x0000000187250440-0x0000000187250450
		public static void ConvertPositionUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ); // 0x0000000187250420-0x0000000187250440
		public static Vector3 ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ); // 0x0000000187250400-0x0000000187250420
		public static Vector3 ConvertPositionUnityToHoudini(Vector3 inputVec); // 0x00000001872503D0-0x0000000187250400
		public static void ConvertPositionUnityToHoudini(float inputX, float inputY, float inputZ, ref Vector3 outputVec); // 0x0000000187250450-0x0000000187250470
		public static void ConvertRotationUnityToHoudini(ref Quaternion rotation); // 0x000000018C1B2B20-0x000000018C1B2B90
		public static void ConvertRotationUnityToHoudini(Quaternion rotation, out float outputX, out float outputY, out float outputZ, out float outputW); // 0x000000018C1B29DC-0x000000018C1B2A90
		public static Quaternion ConvertRotationUnityToHoudini(float inputX, float inputY, float inputZ, float inputW); // 0x000000018C1B2A90-0x000000018C1B2B20
		public static Quaternion ConvertRotationUnityToHoudini(Quaternion inputQuat); // 0x000000018C1B2B90-0x000000018C1B2C00
		public static void ConvertScaleUnityToHoudini(ref Vector3 position); // 0x0000000186805BA0-0x0000000186805BB0
		public static void ConvertScaleUnityToHoudini(Vector3 position, out float outputX, out float outputY, out float outputZ); // 0x0000000187250470-0x0000000187250490
		public static Vector3 ConvertScaleUnityToHoudini(float inputX, float inputY, float inputZ); // 0x0000000187250490-0x00000001872504B0
		public static Vector3 ConvertScaleUnityToHoudini(Vector3 inputVec); // 0x000000018723AE60-0x000000018723AE80
	}

	public class HEU_HoudiniEngineError : Exception // TypeDefIndex: 78229
	{
		// Fields
		protected string _errorMsg; // 0x90
	
		// Constructors
		public HEU_HoudiniEngineError(); // 0x000000018C1B645C-0x000000018C1B64C4
		public HEU_HoudiniEngineError(string errorMsg); // 0x000000018C1B63D4-0x000000018C1B645C
	
		// Methods
		public override string ToString(); // 0x0000000182271B70-0x0000000182271B80
	}

	public class HEU_Platform // TypeDefIndex: 78230
	{
		// Fields
		private static string _lastErrorMsg; // 0x00
		private static string _libPath; // 0x08
		private static bool _pathSet; // 0x10
	
		// Properties
		public static string LibPath { get; } // 0x000000018C1C3D9C-0x000000018C1C3DEC 
		public static bool IsPathSet { get; } // 0x000000018C1C3D4C-0x000000018C1C3D9C 
		public static char DirectorySeparator { get; } // 0x0000000187239D60-0x0000000187239D70 
		public static string DirectorySeparatorStr { get; } // 0x000000018C1C3D20-0x000000018C1C3D4C 
	
		// Constructors
		static HEU_Platform(); // 0x000000018C1C3D18-0x000000018C1C3D20
		public HEU_Platform(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static string GetHoudiniEnginePath(); // 0x000000018C1C360C-0x000000018C1C3664
		public static string GetHoudiniEngineDefaultPath(); // 0x000000018C1C3388-0x000000018C1C3580
		public static string GetSavedHoudiniPath(); // 0x000000018C1C3684-0x000000018C1C37A8
		public static void SetHapiClientName(); // 0x000000018C1C3B18-0x000000018C1C3B60
		public static void SetHoudiniEnginePath(); // 0x0000000186805BA0-0x0000000186805BB0
		public static string GetAllFoldersInPath(string path); // 0x000000018C1C2FE4-0x000000018C1C3094
		private static void GetAllFoldersInPathHelper(string inPath, StringBuilder pathBuilder); // 0x000000018C1C2EB4-0x000000018C1C2FE4
		public static string[] GetFilesInFolder(string folderPath, string searchPattern, bool bRecursive); // 0x000000018C1C313C-0x000000018C1C3254
		public static string GetFileName(string path); // 0x000000018C1C30F0-0x000000018C1C313C
		public static string GetFileNameWithoutExtension(string path); // 0x000000018C1C30A4-0x000000018C1C30F0
		public static string GetFolderPath(string path, bool bRemoveDirectorySeparatorAtEnd = false /* Metadata: 0x0262B303 */); // 0x000000018C1C3254-0x000000018C1C333C
		public static string BuildPath(string folder1, string folder2, params object[] args); // 0x000000018C1C2D38-0x000000018C1C2E4C
		public static string TrimLastDirectorySeparator(string inPath); // 0x000000018C1C3B60-0x000000018C1C3BF0
		public static bool DoesPathExist(string inPath); // 0x000000018C1C2E84-0x000000018C1C2EB4
		public static bool DoesFileExist(string inPath); // 0x000000018C1C2E7C-0x000000018C1C2E84
		public static bool DoesDirectoryExist(string inPath); // 0x000000018C1C2E74-0x000000018C1C2E7C
		public static bool CreateDirectory(string inPath); // 0x000000018C1C2E4C-0x000000018C1C2E74
		public static string GetParentDirectory(string inPath); // 0x000000018C1C3664-0x000000018C1C3684
		public static string GetFullPath(string inPath); // 0x000000018C1C333C-0x000000018C1C3388
		public static bool IsPathRooted(string inPath); // 0x000000018C1C37A8-0x000000018C1C37F4
		public static void WriteBytes(string path, byte[] bytes); // 0x000000018C1C3D10-0x000000018C1C3D18
		public static bool WriteAllText(string path, string text); // 0x000000018C1C3BF0-0x000000018C1C3D10
		public static string ReadAllText(string path); // 0x000000018C1C39C0-0x000000018C1C3B18
		public static string GetEnvironmentValue(string key); // 0x000000018C1C3094-0x000000018C1C30A4
		public static string GetHoudiniEngineEnvironmentFilePathFull(); // 0x000000018C1C3580-0x000000018C1C360C
		public static bool LoadFileIntoMemory(string path, out byte[] buffer); // 0x000000018C1C37F4-0x000000018C1C39C0
	}

	public static class HEU_PlatformWin // TypeDefIndex: 78232
	{
		// Fields
		public static UIntPtr HKEY_LOCAL_MACHINE; // 0x00
		public static UIntPtr HKEY_CURRENT_USER; // 0x08
	
		// Nested types
		public enum RegSAM // TypeDefIndex: 78231
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
		static HEU_PlatformWin(); // 0x000000018C1C2CE4-0x000000018C1C2D38
	
		// Methods
		private static extern uint RegOpenKeyEx(UIntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out int phkResult); // 0x000000018C1C2B20-0x000000018C1C2BE4
		public static extern int RegQueryValueEx(int hKey, string lpValueName, int lpReserved, ref uint lpType, StringBuilder lpData, ref uint lpcbData); // 0x000000018C1C2BE4-0x000000018C1C2CE4
		private static extern uint RegCloseKey(int hKey); // 0x000000018C1C2AA8-0x000000018C1C2B20
		public static string GetRegistryKeyValue(UIntPtr rootKey, string keyName, RegSAM is32or64Key, string inPropertyName); // 0x000000018C1C27C4-0x000000018C1C29C8
		public static string GetRegistryKeyvalue_x86(UIntPtr rootKey, string keyName, string inPropertyName); // 0x000000018C1C2A38-0x000000018C1C2AA8
		public static string GetRegistryKeyvalue_x64(UIntPtr rootKey, string keyName, string inPropertyName); // 0x000000018C1C29C8-0x000000018C1C2A38
		public static string GetApplicationPath(string appName); // 0x000000018C1C2490-0x000000018C1C27C4
	}

	public static class HEU_PluginSettings // TypeDefIndex: 78233
	{
		// Fields
		public static Action<bool> s_onEnableRawHoudiniChanged; // 0x00
	
		// Properties
		public static string HoudiniEngineEnvFilePath { get; set; } // 0x000000018C1C4B98-0x000000018C1C4C10 0x000000018C1C68F0-0x000000018C1C6958
		public static bool EnableRawHoudini { get; set; } // 0x000000018C1C48F8-0x000000018C1C4958 0x000000018C1C66C0-0x000000018C1C6798
		public static bool CookingEnabled { get; set; } // 0x000000018C1C40BC-0x000000018C1C411C 0x000000018C1C6358-0x000000018C1C63A8
		public static bool CookingTriggersDownstreamCooks { get; set; } // 0x000000018C1C411C-0x000000018C1C417C 0x000000018C1C63A8-0x000000018C1C63F8
		public static bool CookDisabledGameObjects { get; set; } // 0x000000018C1C3F3C-0x000000018C1C3F9C 0x000000018C1C6218-0x000000018C1C6268
		public static bool CookTemplatedGeos { get; set; } // 0x000000018C1C405C-0x000000018C1C40BC 0x000000018C1C6308-0x000000018C1C6358
		public static bool PushUnityTransformToHoudini { get; set; } // 0x000000018C1C526C-0x000000018C1C52CC 0x000000018C1C6E00-0x000000018C1C6E50
		public static bool TransformChangeTriggersCooks { get; set; } // 0x000000018C1C59E8-0x000000018C1C5A48 0x000000018C1C73C0-0x000000018C1C7410
		public static bool ChildTransformChangeTriggersCooks { get; set; } // 0x000000018C1C3E64-0x000000018C1C3EC4 0x000000018C1C6174-0x000000018C1C61C4
		public static string CollisionGroupName { get; set; } // 0x000000018C1C3EC4-0x000000018C1C3F3C 0x000000018C1C61C4-0x000000018C1C6218
		public static string RenderedCollisionGroupName { get; set; } // 0x000000018C1C52CC-0x000000018C1C5344 0x000000018C1C6E50-0x000000018C1C6EA4
		public static string RenderedConvexCollisionGroupName { get; set; } // 0x000000018C1C5344-0x000000018C1C53BC 0x000000018C1C6EA4-0x000000018C1C6EF8
		public static string UnityMaterialAttribName { get; set; } // 0x000000018C1C5BB0-0x000000018C1C5C28 0x000000018C1C750C-0x000000018C1C7560
		public static string UnitySubMaterialAttribName { get; set; } // 0x000000018C1C5D18-0x000000018C1C5D90 0x000000018C1C7608-0x000000018C1C765C
		public static string UnitySubMaterialIndexAttribName { get; set; } // 0x000000018C1C5D90-0x000000018C1C5E08 0x000000018C1C765C-0x000000018C1C76B0
		public static string UnityTagAttributeName { get; set; } // 0x000000018C1C5E08-0x000000018C1C5E80 0x000000018C1C76B0-0x000000018C1C7704
		public static string UnityStaticAttributeName { get; set; } // 0x000000018C1C5CA0-0x000000018C1C5D18 0x000000018C1C75B4-0x000000018C1C7608
		public static string UnityScriptAttributeName { get; set; } // 0x000000018C1C5C28-0x000000018C1C5CA0 0x000000018C1C7560-0x000000018C1C75B4
		public static string UnityLayerAttributeName { get; set; } // 0x000000018C1C5B38-0x000000018C1C5BB0 0x000000018C1C74B8-0x000000018C1C750C
		public static float ImageGamma { get; set; } // 0x000000018C1C4C88-0x000000018C1C4CF4 0x000000018C1C69AC-0x000000018C1C6A04
		public static float NormalGenerationThresholdAngle { get; set; } // 0x000000018C1C5200-0x000000018C1C526C 0x000000018C1C6DA8-0x000000018C1C6E00
		public static string LastLoadHDAPath { get; set; } // 0x000000018C1C5004-0x000000018C1C507C 0x000000018C1C6C44-0x000000018C1C6C98
		public static string LastLoadHIPPath { get; set; } // 0x000000018C1C507C-0x000000018C1C50F4 0x000000018C1C6C98-0x000000018C1C6CEC
		public static string InstanceAttr { get; set; } // 0x000000018C1C4E9C-0x000000018C1C4F14 0x000000018C1C6B48-0x000000018C1C6B9C
		public static string UnityInstanceAttr { get; set; } // 0x000000018C1C5AC0-0x000000018C1C5B38 0x000000018C1C7464-0x000000018C1C74B8
		public static string UnityInputMeshAttr { get; set; } // 0x000000018C1C5A48-0x000000018C1C5AC0 0x000000018C1C7410-0x000000018C1C7464
		public static UnityEngine.Color LineColor { get; set; } // 0x000000018C1C50F4-0x000000018C1C5198 0x000000018C1C6CEC-0x000000018C1C6D58
		public static bool UseHybridCurveEditing { get; set; } // 0x000000018C1C5F40-0x000000018C1C5FA0 0x000000018C1C77A4-0x000000018C1C77F4
		public static string EditorOnly_Tag { get; set; } // 0x000000018C1C4880-0x000000018C1C48F8 0x000000018C1C663C-0x000000018C1C66C0
		public static string HDAData_Name { get; set; } // 0x000000018C1C4958-0x000000018C1C49D0 0x000000018C1C6798-0x000000018C1C67EC
		public static SessionMode Session_Mode { get; set; } // 0x000000018C1C54F4-0x000000018C1C555C 0x000000018C1C6FEC-0x000000018C1C703C
		public static string Session_PipeName { get; set; } // 0x000000018C1C555C-0x000000018C1C55D4 0x000000018C1C703C-0x000000018C1C7090
		public static string Session_Localhost { get; set; } // 0x000000018C1C547C-0x000000018C1C54F4 0x000000018C1C6F98-0x000000018C1C6FEC
		public static int Session_Port { get; set; } // 0x000000018C1C55D4-0x000000018C1C563C 0x000000018C1C7090-0x000000018C1C70E0
		public static string Session_SharedMemoryName { get; set; } // 0x000000018C1C570C-0x000000018C1C5784 0x000000018C1C7180-0x000000018C1C71D4
		public static int Session_SharedMemoryBufferSize { get; set; } // 0x000000018C1C563C-0x000000018C1C56A4 0x000000018C1C70E0-0x000000018C1C7130
		public static HAPI_ThriftSharedMemoryBufferType Session_SharedMemoryBufferType { get; set; } // 0x000000018C1C56A4-0x000000018C1C570C 0x000000018C1C7130-0x000000018C1C7180
		public static float Session_Timeout { get; set; } // 0x000000018C1C5784-0x000000018C1C57F0 0x000000018C1C71D4-0x000000018C1C722C
		public static bool Session_AutoClose { get; set; } // 0x000000018C1C541C-0x000000018C1C547C 0x000000018C1C6F48-0x000000018C1C6F98
		public static bool Curves_ShowInSceneView { get; set; } // 0x000000018C1C417C-0x000000018C1C41DC 0x000000018C1C63F8-0x000000018C1C6448
		public static string AssetCachePath { get; set; } // 0x000000018C1C3DEC-0x000000018C1C3E64 0x000000018C1C6120-0x000000018C1C6174
		public static bool UseFullPathNamesForOutput { get; set; } // 0x000000018C1C5E80-0x000000018C1C5EE0 0x000000018C1C7704-0x000000018C1C7754
		public static List<string> HEngineToolsShelves { get; set; } // 0x000000018C1C4A34-0x000000018C1C4A9C 0x000000018C1C683C-0x000000018C1C689C
		public static int HEngineShelfSelectedIndex { get; set; } // 0x000000018C1C49D0-0x000000018C1C4A34 0x000000018C1C67EC-0x000000018C1C683C
		public static string DefaultTerrainMaterial { get; set; } // 0x000000018C1C4488-0x000000018C1C4500 0x000000018C1C64F0-0x000000018C1C6544
		public static string TerrainSplatTextureDefault { get; set; } // 0x000000018C1C5970-0x000000018C1C59E8 0x000000018C1C736C-0x000000018C1C73C0
		public static string DefaultStandardShader { get; set; } // 0x000000018C1C42F8-0x000000018C1C4488 0x000000018C1C649C-0x000000018C1C64F0
		public static string DefaultVertexColorShader { get; set; } // 0x000000018C1C4690-0x000000018C1C4820 0x000000018C1C6598-0x000000018C1C65EC
		public static string DefaultTransparentShader { get; set; } // 0x000000018C1C4500-0x000000018C1C4690 0x000000018C1C6544-0x000000018C1C6598
		public static string DefaultCurveShader { get; set; } // 0x000000018C1C41DC-0x000000018C1C42F8 0x000000018C1C6448-0x000000018C1C649C
		public static bool SupportHoudiniBoxType { get; set; } // 0x000000018C1C58B0-0x000000018C1C5910 0x000000018C1C72CC-0x000000018C1C731C
		public static bool SupportHoudiniSphereType { get; set; } // 0x000000018C1C5910-0x000000018C1C5970 0x000000018C1C731C-0x000000018C1C736C
		public static bool SetCurrentThreadToInvariantCulture { get; set; } // 0x000000018C1C57F0-0x000000018C1C5850 0x000000018C1C722C-0x000000018C1C727C
		public static string HoudiniDebugLaunchPath { get; set; } // 0x000000018C1C4A9C-0x000000018C1C4B98 0x000000018C1C689C-0x000000018C1C68F0
		public static string LastExportPath { get; set; } // 0x000000018C1C4F14-0x000000018C1C4F8C 0x000000018C1C6B9C-0x000000018C1C6BF0
		public static int InputSelectionFilterLocation { get; set; } // 0x000000018C1C4CF4-0x000000018C1C4D5C 0x000000018C1C6A04-0x000000018C1C6A54
		public static int InputSelectionFilterState { get; set; } // 0x000000018C1C4E34-0x000000018C1C4E9C 0x000000018C1C6AF8-0x000000018C1C6B48
		public static bool InputSelectionFilterRoots { get; set; } // 0x000000018C1C4DD4-0x000000018C1C4E34 0x000000018C1C6AA8-0x000000018C1C6AF8
		public static string InputSelectionFilterName { get; set; } // 0x000000018C1C4D5C-0x000000018C1C4DD4 0x000000018C1C6A54-0x000000018C1C6AA8
		public static bool CookOptionSplitGeosByGroup { get; set; } // 0x000000018C1C3FFC-0x000000018C1C405C 0x000000018C1C62B8-0x000000018C1C6308
		public static int MaxVerticesPerPrimitive { get; set; } // 0x000000018C1C5198-0x000000018C1C5200 0x000000018C1C6D58-0x000000018C1C6DA8
		public static string HoudiniInstallPath { get; set; } // 0x000000018C1C4C10-0x000000018C1C4C88 0x000000018C1C6958-0x000000018C1C69AC
		public static string LastHoudiniVersion { get; set; } // 0x000000018C1C4F8C-0x000000018C1C5004 0x000000018C1C6BF0-0x000000018C1C6C44
		public static bool SessionSyncAutoCook { get; set; } // 0x000000018C1C53BC-0x000000018C1C541C 0x000000018C1C6EF8-0x000000018C1C6F48
		public static bool WriteCookLogs { get; set; } // 0x000000018C1C60C0-0x000000018C1C6120 0x000000018C1C78E4-0x000000018C1C7934
		public static bool UseHDRColor { get; set; } // 0x000000018C1C5EE0-0x000000018C1C5F40 0x000000018C1C7754-0x000000018C1C77A4
		public static bool UseSpecularShader { get; set; } // 0x000000018C1C6060-0x000000018C1C60C0 0x000000018C1C7894-0x000000018C1C78E4
		public static bool UseLegacyShaders { get; set; } // 0x000000018C1C6000-0x000000018C1C6060 0x000000018C1C7844-0x000000018C1C7894
		public static bool ShortenFolderPaths { get; set; } // 0x000000018C1C5850-0x000000018C1C58B0 0x000000018C1C727C-0x000000018C1C72CC
		public static bool UseLegacyInputCurves { get; set; } // 0x000000018C1C5FA0-0x000000018C1C6000 0x000000018C1C77F4-0x000000018C1C7844
		public static bool CookOnMouseUp { get; set; } // 0x000000018C1C3F9C-0x000000018C1C3FFC 0x000000018C1C6268-0x000000018C1C62B8
		public static bool EditableNodesToolsEnabled { get; set; } // 0x000000018C1C4820-0x000000018C1C4880 0x000000018C1C65EC-0x000000018C1C663C
	}

	public class HEU_PluginStorage // TypeDefIndex: 78237
	{
		// Fields
		protected Dictionary<string, StoreData> _dataMap; // 0x10
		private Dictionary<string, string> _envPathMap; // 0x18
		protected bool _requiresSave; // 0x20
		private static HEU_PluginStorage _instance; // 0x00
		public const string PluginSettingsLine1 = "Houdini Engine for Unity Plugin Settings"; // Metadata: 0x0262B324
		public const string PluginSettingsLine2 = "Version="; // Metadata: 0x0262B34D
		public const string PluginSettingsVersion = "1.0"; // Metadata: 0x0262B356
	
		// Properties
		public bool RequiresSave { get; } // 0x0000000182246E50-0x0000000182246E60 
		public static HEU_PluginStorage Instance { get; } // 0x000000018C1C9DBC-0x000000018C1C9E10 
	
		// Nested types
		protected enum DataType // TypeDefIndex: 78234
		{
			BOOL = 0,
			INT = 1,
			LONG = 2,
			FLOAT = 3,
			STRING = 4
		}
	
		[Serializable]
		protected class StoreData // TypeDefIndex: 78235
		{
			// Fields
			public DataType _type; // 0x10
			public string _valueStr; // 0x18
	
			// Constructors
			public StoreData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		private class StoreDataArray<T> // TypeDefIndex: 78236
		{
			// Fields
			public T[] _array;
	
			// Constructors
			public StoreDataArray();
		}
	
		// Constructors
		public HEU_PluginStorage(); // 0x000000018C1C9D44-0x000000018C1C9DBC
	
		// Methods
		public Dictionary<string, string> GetEnvironmentPathMap(); // 0x0000000182234E30-0x0000000182234E40
		public static void InstantiateAndLoad(); // 0x000000018C1C850C-0x000000018C1C85F4
		public static void SetCurrentCulture(bool useInvariant); // 0x0000000186805BA0-0x0000000186805BB0
		private T[] GetJSONArray<T>(string jsonArray);
		public void Set(string key, bool value); // 0x000000018C1C9BD0-0x000000018C1C9C94
		public void Set(string key, int value); // 0x000000018C1C9908-0x000000018C1C99CC
		public void Set(string key, long value); // 0x000000018C1C9844-0x000000018C1C9908
		public void Set(string key, float value); // 0x000000018C1C9B0C-0x000000018C1C9BD0
		public void Set(string key, string value); // 0x000000018C1C97AC-0x000000018C1C9844
		public void Set(string key, List<string> values, char delimiter = ';' /* Metadata: 0x0262B320 */); // 0x000000018C1C99CC-0x000000018C1C9B0C
		public bool Get(string key, out bool value, bool defaultValue); // 0x000000018C1C8274-0x000000018C1C8348
		public bool Get(string key, out int value, int defaultValue); // 0x000000018C1C7F64-0x000000018C1C8038
		public bool Get(string key, out long value, long defaultValue); // 0x000000018C1C81A0-0x000000018C1C8274
		public bool Get(string key, out float value, float defaultValue); // 0x000000018C1C840C-0x000000018C1C850C
		public bool Get(string key, out string value, string defaultValue); // 0x000000018C1C8348-0x000000018C1C840C
		public bool Get(string key, out List<string> values, char delimiter = ';' /* Metadata: 0x0262B322 */); // 0x000000018C1C8038-0x000000018C1C81A0
		protected virtual void MarkDirtyForSave(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SaveIfRequired(); // 0x000000018C1C9254-0x000000018C1C92A0
		public static string SettingsFilePath(); // 0x000000018C1C9C94-0x000000018C1C9D44
		public virtual bool SavePluginData(string file = null); // 0x000000018C1C92A0-0x000000018C1C96FC
		public virtual bool LoadPluginData(string file = null); // 0x000000018C1C8A40-0x000000018C1C9254
		private bool ReadFromEditorPrefs(); // 0x00000001843FFFF0-0x0000000184400000
		public static void ClearPluginData(); // 0x000000018C1C7934-0x000000018C1C79EC
		public static void LoadFromSavedFile(); // 0x000000018C1C89F8-0x000000018C1C8A40
		public static string SessionFilePath(); // 0x000000018C1C96FC-0x000000018C1C97AC
		public static void SaveAllSessionData(List<HEU_SessionBase> allSessions, string path = null); // 0x0000000186805BA0-0x0000000186805BB0
		public static List<HEU_SessionData> LoadAllSessionData(string path = null); // 0x000000018C1C85F4-0x000000018C1C8654
		public static void DeleteAllSavedSessionData(string file = null); // 0x0000000186805BA0-0x0000000186805BB0
		public void LoadAssetEnvironmentPaths(); // 0x000000018C1C8654-0x000000018C1C89F8
		public string ConvertRealPathToEnvKeyedPath(string inPath); // 0x000000018C1C7C94-0x000000018C1C7F64
		public string ConvertEnvKeyedPathToReal(string inPath); // 0x000000018C1C79EC-0x000000018C1C7C94
	}

	[Serializable]
	internal class HEU_Handle : ScriptableObject, IEquivable<HEU_Handle> // TypeDefIndex: 78239
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
		public string HandleName { get; } // 0x0000000182234E30-0x0000000182234E40 
		public HEU_HandleType HandleType { get; } // 0x000000018226A850-0x000000018226A860 
		public HAPI_RSTOrder RSTOrder { get; } // 0x0000000182271AE0-0x0000000182271AF0 
		public HAPI_XYZOrder XYZOrder { get; } // 0x00000001872333A0-0x00000001872333B0 
		public HAPI_TransformEuler ConvertedTransformEuler { get; } // 0x00000001872505A0-0x00000001872505D0 
		public Vector3 HandlePosition { get; } // 0x0000000187236520-0x0000000187236540 
		public Quaternion HandleRotation { get; } // 0x000000018723B3D0-0x000000018723B3E0 
		public Vector3 HandleScale { get; } // 0x00000001872505D0-0x00000001872505F0 
	
		// Nested types
		public enum HEU_HandleType // TypeDefIndex: 78238
		{
			XFORM = 0,
			UNSUPPORTED = 1
		}
	
		// Constructors
		public HEU_Handle(); // 0x000000018C1B636C-0x000000018C1B63D4
	
		// Methods
		public bool HasTranslateHandle(); // 0x0000000188BC4884-0x0000000188BC4890
		public bool HasRotateHandle(); // 0x000000018C1B5D60-0x000000018C1B5D6C
		public bool HasScaleHandle(); // 0x000000018C1B5D6C-0x000000018C1B5D78
		public bool IsTranslateHandleDisabled(); // 0x000000018C1B6234-0x000000018C1B6248
		public bool IsRotateHandleDisabled(); // 0x000000018C1B61F8-0x000000018C1B620C
		public bool IsScaleHandleDisabled(); // 0x000000018C1B620C-0x000000018C1B6220
		public HEU_HandleParamBinding GetTranslateBinding(); // 0x0000000182262130-0x0000000182262140
		public HEU_HandleParamBinding GetRotateBinding(); // 0x00000001829600D0-0x00000001829600E0
		public HEU_HandleParamBinding GetScaleBinding(); // 0x0000000182986470-0x0000000182986480
		public bool SetupHandle(HEU_SessionBase session, int assetID, int handleIndex, string handleName, HEU_HandleType handleType, ref HAPI_HandleInfo handleInfo, HEU_Parameters parameters); // 0x000000018C1B6248-0x000000018C1B636C
		public void CleanUp(); // 0x000000018C1B5718-0x000000018C1B5750
		public void GenerateTransform(HEU_SessionBase session, HEU_Parameters parameters); // 0x000000018C1B5750-0x000000018C1B5B68
		public bool GetUpdatedPosition(HEU_HoudiniAsset asset, ref Vector3 inPosition); // 0x000000018C1B5B68-0x000000018C1B5C24
		public bool GetUpdatedRotation(HEU_HoudiniAsset asset, ref Quaternion inRotation); // 0x000000018C1B5C24-0x000000018C1B5D60
		public static bool IsSpecialRSTOrder(HAPI_RSTOrder rstOrder); // 0x000000018C1B6220-0x000000018C1B6234
		public bool IsEquivalentTo(HEU_Handle other); // 0x000000018C1B5D78-0x000000018C1B61F8
	}

	[Serializable]
	internal class HEU_HandleParamBinding : IEquivable<HEU_HandleParamBinding> // TypeDefIndex: 78241
	{
		// Fields
		public HEU_HandleParamType _paramType; // 0x10
		public int _parmID; // 0x14
		public string _paramName; // 0x18
		public bool _bDisabled; // 0x20
		public bool[] _boundChannels; // 0x28
	
		// Nested types
		public enum HEU_HandleParamType // TypeDefIndex: 78240
		{
			TRANSLATE = 0,
			ROTATE = 1,
			SCALE = 2
		}
	
		// Constructors
		public HEU_HandleParamBinding(); // 0x000000018C1B56D0-0x000000018C1B5718
	
		// Methods
		public bool IsEquivalentTo(HEU_HandleParamBinding other); // 0x000000018C1B54FC-0x000000018C1B56D0
	}

	public static class HEU_HAPIConstants // TypeDefIndex: 78242
	{
		// Fields
		public const int HAPI_POSITION_VECTOR_SIZE = 3; // Metadata: 0x0262B364
		public const int HAPI_SCALE_VECTOR_SIZE = 3; // Metadata: 0x0262B365
		public const int HAPI_SHEAR_VECTOR_SIZE = 3; // Metadata: 0x0262B366
		public const int HAPI_NORMAL_VECTOR_SIZE = 3; // Metadata: 0x0262B367
		public const int HAPI_QUATERNION_VECTOR_SIZE = 4; // Metadata: 0x0262B368
		public const int HAPI_EULER_VECTOR_SIZE = 3; // Metadata: 0x0262B369
		public const int HAPI_UV_VECTOR_SIZE = 2; // Metadata: 0x0262B36A
		public const int HAPI_COLOR_VECTOR_SIZE = 4; // Metadata: 0x0262B36B
		public const int HAPI_CV_VECTOR_SIZE = 4; // Metadata: 0x0262B36C
		public const int HAPI_PRIM_MIN_VERTEX_COUNT = 1; // Metadata: 0x0262B36D
		public const int HAPI_PRIM_MAX_VERTEX_COUNT = 16; // Metadata: 0x0262B36E
		public const int HAPI_INVALID_PARM_ID = -1; // Metadata: 0x0262B36F
		public const int HAPI_MAX_NUM_CONNECTIONS = 128; // Metadata: 0x0262B370
		public const string HAPI_ATTRIB_POSITION = "P"; // Metadata: 0x0262B372
		public const string HAPI_ATTRIB_UV = "uv"; // Metadata: 0x0262B374
		public const string HAPI_ATTRIB_UV2 = "uv2"; // Metadata: 0x0262B377
		public const string HAPI_ATTRIB_NORMAL = "N"; // Metadata: 0x0262B37B
		public const string HAPI_ATTRIB_TANGENT = "tangentu"; // Metadata: 0x0262B37D
		public const string HAPI_ATTRIB_TANGENT2 = "tangentv"; // Metadata: 0x0262B386
		public const string HAPI_ATTRIB_COLOR = "Cd"; // Metadata: 0x0262B38F
		public const string HAPI_ATTRIB_NAME = "name"; // Metadata: 0x0262B392
		public const string HAPI_ATTRIB_INSTANCE = "instance"; // Metadata: 0x0262B397
		public const string HAPI_ATTRIB_ROT = "rot"; // Metadata: 0x0262B3A0
		public const string HAPI_ATTRIB_SCALE = "scale"; // Metadata: 0x0262B3A4
		public const string HAPI_UNGROUPED_GROUP_NAME = "__ungrouped_group"; // Metadata: 0x0262B3AA
		public const string HAPI_RAW_FORMAT_NAME = "HAPI_RAW"; // Metadata: 0x0262B3BC
		public const string HAPI_PNG_FORMAT_NAME = "PNG"; // Metadata: 0x0262B3C5
		public const string HAPI_JPEG_FORMAT_NAME = "JPEG"; // Metadata: 0x0262B3C9
		public const string HAPI_BMP_FORMAT_NAME = "Bitmap"; // Metadata: 0x0262B3CE
		public const string HAPI_TIFF_FORMAT_NAME = "TIFF"; // Metadata: 0x0262B3D5
		public const string HAPI_TGA_FORMAT_NAME = "Targa"; // Metadata: 0x0262B3DA
		public const string HAPI_DEFAULT_IMAGE_FORMAT_NAME = "PNG"; // Metadata: 0x0262B3E0
		public const string HAPI_GLOBAL_NODES_NODE_NAME = "GlobalNodes"; // Metadata: 0x0262B3E4
		public const string HAPI_ENV_HIP = "HIP"; // Metadata: 0x0262B3F0
		public const string HAPI_ENV_JOB = "JOB"; // Metadata: 0x0262B3F4
		public const string HAPI_ENV_CLIENT_NAME = "HAPI_CLIENT_NAME"; // Metadata: 0x0262B3F8
		public const string HAPI_CACHE_COP2_COOK = "Old COP Cook Cache"; // Metadata: 0x0262B409
		public const string HAPI_CACHE_COP2_FLIPBOOK = "Composite View Cache"; // Metadata: 0x0262B41C
		public const string HAPI_CACHE_IMAGE = "Image Cache"; // Metadata: 0x0262B431
		public const string HAPI_CACHE_OBJ = "Object Transform Cache"; // Metadata: 0x0262B43D
		public const string HAPI_CACHE_GL_TEXTURE = "OpenGL Texture Cache"; // Metadata: 0x0262B454
		public const string HAPI_CACHE_GL_VERTEX = "OpenGL Vertex Cache"; // Metadata: 0x0262B469
		public const string HAPI_CACHE_SOP = "SOP Cache"; // Metadata: 0x0262B47D
		public const string HAPI_CACHE_VEX = "VEX File Cache"; // Metadata: 0x0262B487
		public const string HAPI_ATTRIB_INPUT_CURVE_COORDS = "hapi_input_curve_coords"; // Metadata: 0x0262B496
	}

	public enum HAPI_License // TypeDefIndex: 78243
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

	public enum HAPI_StatusType // TypeDefIndex: 78244
	{
		HAPI_STATUS_CALL_RESULT = 0,
		HAPI_STATUS_COOK_RESULT = 1,
		HAPI_STATUS_COOK_STATE = 2,
		HAPI_STATUS_MAX = 3
	}

	public enum HAPI_StatusVerbosity // TypeDefIndex: 78245
	{
		HAPI_STATUSVERBOSITY_0 = 0,
		HAPI_STATUSVERBOSITY_ERRORS = 0,
		HAPI_STATUSVERBOSITY_1 = 1,
		HAPI_STATUSVERBOSITY_WARNINGS = 1,
		HAPI_STATUSVERBOSITY_2 = 2,
		HAPI_STATUSVERBOSITY_ALL = 2,
		HAPI_STATUSVERBOSITY_MESSAGES = 2
	}

	public enum HAPI_JobStatus // TypeDefIndex: 78246
	{
		HAPI_JOB_STATUS_RUNNING = 0,
		HAPI_JOB_STATUS_IDLE = 1,
		HAPI_JOB_STATUS_MAX = 2
	}

	public enum HAPI_Result // TypeDefIndex: 78247
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
	public enum HAPI_ErrorCode // TypeDefIndex: 78248
	{
		HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND = 1,
		HAPI_ERRORCODE_PYTHON_NODE_ERROR = 2
	}

	public enum HAPI_SessionType // TypeDefIndex: 78249
	{
		HAPI_SESSION_INPROCESS = 0,
		HAPI_SESSION_THRIFT = 1,
		HAPI_SESSION_CUSTOM1 = 2,
		HAPI_SESSION_CUSTOM2 = 3,
		HAPI_SESSION_CUSTOM3 = 4,
		HAPI_SESSION_MAX = 5
	}

	public enum HAPI_State // TypeDefIndex: 78250
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

	public enum HAPI_PackedPrimInstancingMode // TypeDefIndex: 78251
	{
		HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID = -1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED = 0,
		HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY = 1,
		HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT = 2,
		HAPI_PACKEDPRIM_INSTANCING_MODE_MAX = 3
	}

	public enum HAPI_Permissions // TypeDefIndex: 78252
	{
		HAPI_PERMISSIONS_NON_APPLICABLE = 0,
		HAPI_PERMISSIONS_READ_WRITE = 1,
		HAPI_PERMISSIONS_READ_ONLY = 2,
		HAPI_PERMISSIONS_WRITE_ONLY = 3,
		HAPI_PERMISSIONS_MAX = 4
	}

	public enum HAPI_RampType // TypeDefIndex: 78253
	{
		HAPI_RAMPTYPE_INVALID = -1,
		HAPI_RAMPTYPE_FLOAT = 0,
		HAPI_RAMPTYPE_COLOR = 1,
		HAPI_RAMPTYPE_MAX = 2
	}

	public enum HAPI_ParmType // TypeDefIndex: 78254
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

	public enum HAPI_PrmScriptType // TypeDefIndex: 78255
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

	public enum HAPI_ChoiceListType // TypeDefIndex: 78256
	{
		HAPI_CHOICELISTTYPE_NONE = 0,
		HAPI_CHOICELISTTYPE_NORMAL = 1,
		HAPI_CHOICELISTTYPE_MINI = 2,
		HAPI_CHOICELISTTYPE_REPLACE = 3,
		HAPI_CHOICELISTTYPE_TOGGLE = 4
	}

	public enum HAPI_PresetType // TypeDefIndex: 78257
	{
		HAPI_PRESETTYPE_INVALID = -1,
		HAPI_PRESETTYPE_BINARY = 0,
		HAPI_PRESETTYPE_IDX = 1,
		HAPI_PRESETTYPE_MAX = 2
	}

	[Flags]
	public enum HAPI_NodeType // TypeDefIndex: 78258
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
	public enum HAPI_NodeFlags // TypeDefIndex: 78259
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

	public enum HAPI_GroupType // TypeDefIndex: 78260
	{
		HAPI_GROUPTYPE_INVALID = -1,
		HAPI_GROUPTYPE_POINT = 0,
		HAPI_GROUPTYPE_PRIM = 1,
		HAPI_GROUPTYPE_EDGE = 2,
		HAPI_GROUPTYPE_MAX = 3
	}

	public enum HAPI_AttributeOwner // TypeDefIndex: 78261
	{
		HAPI_ATTROWNER_INVALID = -1,
		HAPI_ATTROWNER_VERTEX = 0,
		HAPI_ATTROWNER_POINT = 1,
		HAPI_ATTROWNER_PRIM = 2,
		HAPI_ATTROWNER_DETAIL = 3,
		HAPI_ATTROWNER_MAX = 4
	}

	public enum HAPI_CurveType // TypeDefIndex: 78262
	{
		HAPI_CURVETYPE_INVALID = -1,
		HAPI_CURVETYPE_LINEAR = 0,
		HAPI_CURVETYPE_NURBS = 1,
		HAPI_CURVETYPE_BEZIER = 2,
		HAPI_CURVETYPE_MAX = 3
	}

	public enum HAPI_InputCurveMethod // TypeDefIndex: 78263
	{
		HAPI_CURVEMETHOD_INVALID = -1,
		HAPI_CURVEMETHOD_CVS = 0,
		HAPI_CURVEMETHOD_BREAKPOINTS = 1,
		HAPI_CURVEMETHOD_MAX = 2
	}

	public enum HAPI_InputCurveParameterization // TypeDefIndex: 78264
	{
		HAPI_CURVEPARAMETERIZATION_INVALID = -1,
		HAPI_CURVEPARAMETERIZATION_UNIFORM = 0,
		HAPI_CURVEPARAMETERIZATION_CHORD = 1,
		HAPI_CURVEPARAMETERIZATION_CENTRIPETAL = 2,
		HAPI_CURVEPARAMETERIZATION_MAX = 3
	}

	public enum HAPI_VolumeType // TypeDefIndex: 78265
	{
		HAPI_VOLUMETYPE_INVALID = -1,
		HAPI_VOLUMETYPE_HOUDINI = 0,
		HAPI_VOLUMETYPE_VDB = 1,
		HAPI_VOLUMETYPE_MAX = 2
	}

	public enum HAPI_VolumeVisualType // TypeDefIndex: 78266
	{
		HAPI_VOLUMEVISTYPE_INVALID = -1,
		HAPI_VOLUMEVISTYPE_SMOKE = 0,
		HAPI_VOLUMEVISTYPE_RAINBOW = 1,
		HAPI_VOLUMEVISTYPE_ISO = 2,
		HAPI_VOLUMEVISTYPE_INVISIBLE = 3,
		HAPI_VOLUMEVISTYPE_HEIGHTFIELD = 4,
		HAPI_VOLUMEVISTYPE_MAX = 5
	}

	public enum HAPI_StorageType // TypeDefIndex: 78267
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

	public enum HAPI_AttributeTypeInfo // TypeDefIndex: 78268
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

	public enum HAPI_GeoType // TypeDefIndex: 78269
	{
		HAPI_GEOTYPE_INVALID = -1,
		HAPI_GEOTYPE_DEFAULT = 0,
		HAPI_GEOTYPE_INTERMEDIATE = 1,
		HAPI_GEOTYPE_INPUT = 2,
		HAPI_GEOTYPE_CURVE = 3,
		HAPI_GEOTYPE_MAX = 4
	}

	public enum HAPI_PartType // TypeDefIndex: 78270
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

	public enum HAPI_InputType // TypeDefIndex: 78271
	{
		HAPI_INPUT_INVALID = -1,
		HAPI_INPUT_TRANSFORM = 0,
		HAPI_INPUT_GEOMETRY = 1,
		HAPI_INPUT_MAX = 2
	}

	public enum HAPI_CurveOrders // TypeDefIndex: 78272
	{
		HAPI_CURVE_ORDER_VARYING = 0,
		HAPI_CURVE_ORDER_INVALID = 1,
		HAPI_CURVE_ORDER_LINEAR = 2,
		HAPI_CURVE_ORDER_QUADRATIC = 3,
		HAPI_CURVE_ORDER_CUBIC = 4
	}

	public enum HAPI_TransformComponent // TypeDefIndex: 78273
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

	public enum HAPI_RSTOrder // TypeDefIndex: 78274
	{
		HAPI_TRS = 0,
		HAPI_TSR = 1,
		HAPI_RTS = 2,
		HAPI_RST = 3,
		HAPI_STR = 4,
		HAPI_SRT = 5,
		HAPI_RSTORDER_DEFAULT = 5
	}

	public enum HAPI_XYZOrder // TypeDefIndex: 78275
	{
		HAPI_XYZ = 0,
		HAPI_XYZORDER_DEFAULT = 0,
		HAPI_XZY = 1,
		HAPI_YXZ = 2,
		HAPI_YZX = 3,
		HAPI_ZXY = 4,
		HAPI_ZYX = 5
	}

	public enum HAPI_ImageDataFormat // TypeDefIndex: 78276
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

	public enum HAPI_ImagePacking // TypeDefIndex: 78277
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

	public enum HAPI_EnvIntType // TypeDefIndex: 78278
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

	public enum HAPI_SessionEnvIntType // TypeDefIndex: 78279
	{
		HAPI_SESSIONENVINT_INVALID = -1,
		HAPI_SESSIONENVINT_LICENSE = 100,
		HAPI_SESSIONENVINT_MAX = 101
	}

	public enum HAPI_CacheProperty // TypeDefIndex: 78280
	{
		HAPI_CACHEPROP_CURRENT = 0,
		HAPI_CACHEPROP_HAS_MIN = 1,
		HAPI_CACHEPROP_MIN = 2,
		HAPI_CACHEPROP_HAS_MAX = 3,
		HAPI_CACHEPROP_MAX = 4,
		HAPI_CACHEPROP_CULL_LEVEL = 5
	}

	public enum HAPI_HeightFieldSampling // TypeDefIndex: 78281
	{
		HAPI_HEIGHTFIELD_SAMPLING_CENTER = 0,
		HAPI_HEIGHTFIELD_SAMPLING_CORNER = 1
	}

	public enum HAPI_PDG_State // TypeDefIndex: 78282
	{
		HAPI_PDG_STATE_READY = 0,
		HAPI_PDG_STATE_MAX_READY_STATE = 0,
		HAPI_PDG_STATE_COOKING = 1,
		HAPI_PDG_STATE_MAX = 2
	}

	public enum HAPI_PDG_EventType // TypeDefIndex: 78283
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

	public enum HAPI_PDG_WorkItemState // TypeDefIndex: 78284
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

	public enum HAPI_TCP_PortType // TypeDefIndex: 78285
	{
		HAPI_TCP_PORT_ANY = 0,
		HAPI_TCP_PORT_RANGE = 1,
		HAPI_TCP_PORT_LIST = 2
	}

	public enum HAPI_ThriftSharedMemoryBufferType // TypeDefIndex: 78286
	{
		HAPI_THRIFT_SHARED_MEMORY_FIXED_LENGTH_BUFFER = 0,
		HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER = 1
	}

	public static class HEU_HAPIFunctions // TypeDefIndex: 78287
	{
	}

	[Serializable]
	public struct HAPI_Transform // TypeDefIndex: 78288
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationQuaternion; // 0x08
		public float[] scale; // 0x10
		public float[] shear; // 0x18
		public HAPI_RSTOrder rstOrder; // 0x20
	
		// Constructors
		public HAPI_Transform(bool initializeFields); // 0x000000018C1B0804-0x000000018C1B08CC
	
		// Methods
		public void Init(); // 0x000000018C1B0704-0x000000018C1B0804
	}

	[Serializable]
	public struct HAPI_TransformEuler // TypeDefIndex: 78289
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationEuler; // 0x08
		public float[] scale; // 0x10
		public float[] shear; // 0x18
		public HAPI_XYZOrder rotationOrder; // 0x20
		public HAPI_RSTOrder rstOrder; // 0x24
	
		// Constructors
		public HAPI_TransformEuler(bool initializeFields); // 0x000000018C1B063C-0x000000018C1B0704
	
		// Methods
		public void Init(); // 0x000000018C1B056C-0x000000018C1B063C
	}

	[Serializable]
	public struct HAPI_Session // TypeDefIndex: 78290
	{
		// Fields
		public HAPI_SessionType type; // 0x00
		public long id; // 0x08
	}

	[Serializable]
	public struct HAPI_SessionInfo // TypeDefIndex: 78291
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

	public struct HAPI_ThriftServerOptions // TypeDefIndex: 78292
	{
		// Fields
		public bool autoClose; // 0x00
		public float timeoutMs; // 0x04
		public HAPI_StatusVerbosity verbosity; // 0x08
		public HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType; // 0x0C
		public long sharedMemoryBufferSize; // 0x10
	}

	public struct HAPI_TimelineOptions // TypeDefIndex: 78293
	{
		// Fields
		public double fps; // 0x00
		public double startTime; // 0x08
		public double endTime; // 0x10
	}

	[Serializable]
	public struct HAPI_AssetInfo // TypeDefIndex: 78294
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

	public struct HAPI_CookOptions // TypeDefIndex: 78295
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
	public struct HAPI_NodeInfo // TypeDefIndex: 78296
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
	public struct HAPI_ParmInfo // TypeDefIndex: 78297
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
		public bool isInt(); // 0x000000018C1B0244-0x000000018C1B0264
		public bool isFloat(); // 0x000000018C1B0230-0x000000018C1B0244
		public bool isString(); // 0x000000018C1B02A0-0x000000018C1B02C0
		public bool isPath(); // 0x000000018C1B0288-0x000000018C1B02A0
		public bool isNode(); // 0x000000018C1B0264-0x000000018C1B0274
		public bool isNonValue(); // 0x000000018C1B0274-0x000000018C1B0288
	}

	[Serializable]
	public struct HAPI_ParmChoiceInfo // TypeDefIndex: 78298
	{
		// Fields
		public int parentParmId; // 0x00
		public int labelSH; // 0x04
		public int valueSH; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleInfo // TypeDefIndex: 78299
	{
		// Fields
		public int nameSH; // 0x00
		public int typeNameSH; // 0x04
		public int bindingsCount; // 0x08
	}

	[Serializable]
	public struct HAPI_HandleBindingInfo // TypeDefIndex: 78300
	{
		// Fields
		public int handleParmNameSH; // 0x00
		public int assetParmNameSH; // 0x04
		public int assetParmId; // 0x08
		public int assetParmIndex; // 0x0C
	}

	[Serializable]
	public struct HAPI_ObjectInfo // TypeDefIndex: 78301
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
	public struct HAPI_GeoInfo // TypeDefIndex: 78302
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
		public int getGroupCountByType(HAPI_GroupType type); // 0x000000018C1B01CC-0x000000018C1B01E0
	}

	public struct HAPI_PartInfo // TypeDefIndex: 78303
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
		public int pointAttributeCount { get; set; } // 0x000000018C1B0330-0x000000018C1B0364 0x000000018C1B045C-0x000000018C1B049C
		public int primitiveAttributeCount { get; set; } // 0x000000018C1B0364-0x000000018C1B0398 0x000000018C1B049C-0x000000018C1B04DC
		public int vertexAttributeCount { get; set; } // 0x000000018C1B0398-0x000000018C1B03CC 0x000000018C1B04DC-0x000000018C1B051C
		public int detailAttributeCount { get; set; } // 0x000000018C1B02FC-0x000000018C1B0330 0x000000018C1B041C-0x000000018C1B045C
	
		// Methods
		public int getElementCountByAttributeOwner(HAPI_AttributeOwner owner); // 0x000000018C1B02C0-0x000000018C1B02E8
		public int getElementCountByGroupType(HAPI_GroupType type); // 0x000000018C1B02E8-0x000000018C1B02FC
		public void init(); // 0x000000018C1B03CC-0x000000018C1B041C
	}

	[Serializable]
	public struct HAPI_AttributeInfo // TypeDefIndex: 78304
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
		public HAPI_AttributeInfo(string ignored = null); // 0x00000001872503A0-0x00000001872503D0
	}

	public struct HAPI_MaterialInfo // TypeDefIndex: 78305
	{
		// Fields
		public int nodeId; // 0x00
		public bool exists; // 0x04
		public bool hasChanged; // 0x05
	}

	public struct HAPI_ImageFileFormat // TypeDefIndex: 78306
	{
		// Fields
		public int nameSH; // 0x00
		public int descriptionSH; // 0x04
		public int defaultExtensionSH; // 0x08
	}

	public struct HAPI_ImageInfo // TypeDefIndex: 78307
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

	public struct HAPI_Keyframe // TypeDefIndex: 78308
	{
		// Fields
		public float time; // 0x00
		public float value; // 0x04
		public float inTangent; // 0x08
		public float outTangent; // 0x0C
	
		// Constructors
		public HAPI_Keyframe(float t, float v, float in_tangent, float out_tangent); // 0x00000001872359D0-0x00000001872359F0
	}

	public struct HAPI_VolumeInfo // TypeDefIndex: 78309
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

	public struct HAPI_VolumeTileInfo // TypeDefIndex: 78310
	{
		// Fields
		public int minX; // 0x00
		public int minY; // 0x04
		public int minZ; // 0x08
		public bool isValid; // 0x0C
	}

	public struct HAPI_VolumeVisualInfo // TypeDefIndex: 78311
	{
		// Fields
		public HAPI_VolumeVisualType type; // 0x00
		public float iso; // 0x04
		public float density; // 0x08
	}

	public struct HAPI_CurveInfo // TypeDefIndex: 78312
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

	public struct HAPI_InputCurveInfo // TypeDefIndex: 78313
	{
		// Fields
		public HAPI_CurveType curveType; // 0x00
		public int order; // 0x04
		public bool closed; // 0x08
		public bool reverse; // 0x09
		public HAPI_InputCurveMethod inputMethod; // 0x0C
		public HAPI_InputCurveParameterization breakpointParameterization; // 0x10
	
		// Methods
		public void FillData(HEU_InputCurveInfo curveInfo); // 0x000000018C1B01E0-0x000000018C1B0230
	}

	public struct HAPI_BoxInfo // TypeDefIndex: 78314
	{
		// Fields
		public float[] center; // 0x00
		public float[] size; // 0x08
		public float[] rotation; // 0x10
	
		// Constructors
		public HAPI_BoxInfo(bool initialize_fields); // 0x000000018C1B0144-0x000000018C1B01CC
	}

	public struct HAPI_SphereInfo // TypeDefIndex: 78315
	{
		// Fields
		public float[] center; // 0x00
		public float radius; // 0x08
	
		// Constructors
		public HAPI_SphereInfo(bool initialize_fields); // 0x000000018C1B051C-0x000000018C1B056C
	}

	public struct HAPI_PDG_EventInfo // TypeDefIndex: 78316
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

	public struct HAPI_PDG_WorkItemInfo // TypeDefIndex: 78317
	{
		// Fields
		public int index; // 0x00
		public int outputFileCount; // 0x04
		public int nameSH; // 0x08
	}

	public struct HAPI_PDG_WorkItemOutputFile // TypeDefIndex: 78318
	{
		// Fields
		public int filePathSH; // 0x00
		public int tagSH; // 0x04
		public long hash; // 0x08
	}

	[Serializable]
	public struct HAPI_Viewport // TypeDefIndex: 78319
	{
		// Fields
		public float[] position; // 0x00
		public float[] rotationQuaternion; // 0x08
		public float offset; // 0x10
	
		// Constructors
		public HAPI_Viewport(bool initializeFields); // 0x000000018C1B0950-0x000000018C1B09D8
	
		// Methods
		public void Init(); // 0x000000018C1B08CC-0x000000018C1B0950
	}

	[Serializable]
	public struct HAPI_SessionSyncInfo // TypeDefIndex: 78320
	{
		// Fields
		public bool cookUsingHoudiniTime; // 0x00
		public bool syncViewport; // 0x01
	}

	public struct HAPI_CompositorOptions // TypeDefIndex: 78321
	{
		// Fields
		public int maximumResolutionX; // 0x00
		public int maximumResolutionY; // 0x04
	}

	public class HEU_HARCImports // TypeDefIndex: 78322
	{
		// Constructors
		public HEU_HARCImports(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HEU_HoudiniVersion // TypeDefIndex: 78323
	{
		// Fields
		public const int HOUDINI_MAJOR = 21; // Metadata: 0x0262B680
		public const int HOUDINI_MINOR = 0; // Metadata: 0x0262B681
		public const int HOUDINI_BUILD = 631; // Metadata: 0x0262B682
		public const int HOUDINI_PATCH = 0; // Metadata: 0x0262B684
		public const string HOUDINI_VERSION_STRING = "21.0.631"; // Metadata: 0x0262B685
		public const int HOUDINI_ENGINE_MAJOR = 8; // Metadata: 0x0262B68E
		public const int HOUDINI_ENGINE_MINOR = 0; // Metadata: 0x0262B68F
		public const int HOUDINI_ENGINE_API = 3; // Metadata: 0x0262B690
		public const int UNITY_PLUGIN_VERSION = 2; // Metadata: 0x0262B691
		public const string HAPI_BIN_PATH = "/bin"; // Metadata: 0x0262B692
		public const string HAPI_LIBRARY = "libHAPIL"; // Metadata: 0x0262B697
		public const string HARC_LIBRARY = "libHARC"; // Metadata: 0x0262B6A0
		public const string SIDEFX_SOFTWARE_REGISTRY = "SOFTWARE\\Side Effects Software\\"; // Metadata: 0x0262B6A8
	
		// Constructors
		public HEU_HoudiniVersion(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HTC_APIConstants // TypeDefIndex: 78324
	{
		// Fields
		public const string HOUDINI_MASTER_SERVER_HOSTNAME = "tech.houdini.int.hypergryph.com"; // Metadata: 0x0262B6C8
		public const int HOUDINI_MASTER_QUERY_FOR_UNITY_PORT = 20240; // Metadata: 0x0262B6E8
		public const int TCP_HEADER_SIZE = 4; // Metadata: 0x0262B6EC
		public const int MAX_ERROR_INFO_SIZE = 256; // Metadata: 0x0262B6ED
	
		// Constructors
		public HTC_APIConstants(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HTC_VERSION // TypeDefIndex: 78325
	{
		// Fields
		public const string LIBRARY = "HTCLib"; // Metadata: 0x0262B6EF
	
		// Constructors
		public HTC_VERSION(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HoudiniConstsIdentifier // TypeDefIndex: 78326
	{
		// Fields
		public const string HOUDINI_VERSION = "19.5"; // Metadata: 0x0262B6F6
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x0262B6FB
	
		// Constructors
		public HoudiniConstsIdentifier(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class HTC_APIFunctions // TypeDefIndex: 78327
	{
		// Constructors
		public HTC_APIFunctions(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal static extern void InitHoudiniTcpClient(string address, int port, bool use_ip, [In, Out] StringBuilder error_msg); // 0x000000018C1C9F20-0x000000018C1CA000
		internal static extern void GetHarsInfo(ref HarsInfo harsInfo, [In, Out] StringBuilder error_msg); // 0x000000018C1C9E10-0x000000018C1C9F20
		internal static extern void UninitializeHoudiniTcpClient([In, Out] StringBuilder error_msg); // 0x000000018C1CA000-0x000000018C1CA0A0
	}

	internal struct HarsInfo // TypeDefIndex: 78328
	{
		// Fields
		public string hars_address; // 0x00
		public int port; // 0x08
	}

	internal struct GenericMessage // TypeDefIndex: 78329
	{
		// Fields
		[JsonProperty("protocol")]
		public string protocol; // 0x00
		[JsonProperty("body")]
		public object body; // 0x08
	}

	public static class Logger // TypeDefIndex: 78330
	{
		// Methods
		public static void LogError(string msg); // 0x000000018C1CBEC8-0x000000018C1CBF14
		public static void LogWarning(string msg); // 0x000000018C1CBF60-0x000000018C1CBFAC
		public static void LogInfo(string msg); // 0x000000018C1CBF14-0x000000018C1CBF60
	}

	public class HTC_SessionManager : IDisposable // TypeDefIndex: 78331
	{
		// Fields
		private bool disposedValue; // 0x10
		private static HTC_SessionManager instance_; // 0x00
	
		// Properties
		public static HTC_SessionManager Instance { get; } // 0x000000018C1CAC14-0x000000018C1CAC98 
	
		// Constructors
		private HTC_SessionManager(); // 0x000000018C1CA388-0x000000018C1CAC14
	
		// Methods
		~HTC_SessionManager(); // 0x000000018C1CA250-0x000000018C1CA2C8
		protected virtual void Dispose(bool disposing); // 0x000000018C1CA15C-0x000000018C1CA250
		public void Dispose(); // 0x000000018C1CA10C-0x000000018C1CA15C
		public bool GetOrRequestAvailableHARSInfo(out string harsAddress, out int harsPort, out string errorInfo); // 0x000000018C1CA2C8-0x000000018C1CA388
		public static void Close(); // 0x000000018C1CA0A0-0x000000018C1CA10C
	}

	public static class HTC_Utils // TypeDefIndex: 78332
	{
		// Fields
		private static readonly string CurrentUnityProjectPrefix; // 0x00
	
		// Constructors
		static HTC_Utils(); // 0x000000018C1CAEA0-0x000000018C1CAF4C
	
		// Methods
		public static string GetUnityPathFromSystemPath(string systemPath); // 0x000000018C1CAC98-0x000000018C1CAEA0
	}

	public static class HoudiniExtTools // TypeDefIndex: 78333
	{
		// Fields
		private static readonly string LOCAL_IP_ADDRESS; // 0x00
		private static readonly string REMOTE_HOUDINI_SMB_PATH_PREFIX; // 0x08
		private static readonly string REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX; // 0x10
		public const string REMOTE_HOUDINI_HDA_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_hda"; // Metadata: 0x0262B729
		public const string REMOTE_HOUDINI_SMB_URL = "//hgshare.int.hypergryph.com/techcenter/houdini_share"; // Metadata: 0x0262B75D
		public const string LINUX_MOUNT_DIR_PREFIX = "/mnt/houdini_share"; // Metadata: 0x0262B793
		public const string PROJECT_TAG = "rm42"; // Metadata: 0x0262B7A6
	
		// Properties
		private static long DefaultSessionID { get; } // 0x000000018C1CBE78-0x000000018C1CBEC8 
	
		// Constructors
		static HoudiniExtTools(); // 0x000000018C1CBD7C-0x000000018C1CBE78
	
		// Methods
		private static long GetSessionID(long sessionId); // 0x000000018C1CBAA0-0x000000018C1CBAEC
		public static string GetDefaultDirectoryOnTheSMB(); // 0x000000018C1CB554-0x000000018C1CB5A4
		public static string GetDefaultSessionDirectoryOnTheSMB(long sessionId = -1 /* Metadata: 0x0262B700 */); // 0x000000018C1CB5D0-0x000000018C1CB670
		public static string ConvertLocalDirPathToSessionDirPath(string localPath, bool doMd5 = true /* Metadata: 0x0262B708 */, long sessionId = -1 /* Metadata: 0x0262B709 */); // 0x000000018C1CB1D4-0x000000018C1CB308
		public static string ConvertLocalDebugFilePathToSessionDebugFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x0262B711 */); // 0x000000018C1CB0DC-0x000000018C1CB1D4
		public static string ConvertLocalFilePathToSessionFilePath(string localFilePath, long sessionId = -1 /* Metadata: 0x0262B719 */); // 0x000000018C1CB308-0x000000018C1CB4F4
		public static bool IsLocalPath(string path); // 0x000000018C1CBAEC-0x000000018C1CBD7C
		public static string GetMD5WithString(string str); // 0x000000018C1CB98C-0x000000018C1CBAA0
		public static string GetLocalIPv4(); // 0x000000018C1CB69C-0x000000018C1CB98C
		public static string GetHoudiniSMBUrl(); // 0x000000018C1CB670-0x000000018C1CB69C
		public static string GetDefaultCachePath(long sessionId = -1 /* Metadata: 0x0262B721 */); // 0x000000018C1CB4F4-0x000000018C1CB554
		public static string GetDefaultHdaPath(); // 0x000000018C1CB5A4-0x000000018C1CB5D0
	}

	public static class HoudiniExtBridge // TypeDefIndex: 78334
	{
		// Methods
		public static bool GetParametersFromHDA(byte[] hdaBytes, out HEU_Parameters parameters, out List<HEU_InputNode> inputNodes); // 0x000000018C1CAF8C-0x000000018C1CB0DC
		public static void AddInputNodeToHoudiniAsset(HEU_HoudiniAsset asset, HEU_InputNode node); // 0x000000018C1CAF4C-0x000000018C1CAF68
	
		// Extension methods
		public static void Clear(this HEU_Parameters parameters); // 0x000000018C1CAF68-0x000000018C1CAF8C
	}

	[Serializable]
	public sealed class HEU_ParameterData : IEquivable<HEU_ParameterData> // TypeDefIndex: 78335
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
		public int ParmID { get; } // 0x0000000182271AC0-0x0000000182271AD0 
		public int ParentID { get; } // 0x0000000182271AF0-0x0000000182271B00 
		public int ChildIndex { get; } // 0x0000000187235C10-0x0000000187235C20 
		public int ParmSize { get; } // 0x000000018723B930-0x000000018723B940 
		public int IntMin { get; } // 0x000000018C1B7018-0x000000018C1B7028 
		public int IntMax { get; } // 0x000000018C1B7008-0x000000018C1B7018 
		public int IntUIMin { get; } // 0x000000018C1B7038-0x000000018C1B7048 
		public int IntUIMax { get; } // 0x000000018C1B7028-0x000000018C1B7038 
		public float FloatMin { get; } // 0x000000018724C030-0x000000018724C040 
		public float FloatMax { get; } // 0x0000000187250630-0x0000000187250640 
		public float FloatUIMin { get; } // 0x000000018723B6E0-0x000000018723B6F0 
		public float FloatUIMax { get; } // 0x0000000187250640-0x0000000187250650 
	
		// Constructors
		public HEU_ParameterData(); // 0x000000018C1B6F90-0x000000018C1B7008
	
		// Methods
		public bool IsInt(); // 0x000000018C1B6EB0-0x000000018C1B6EBC
		public bool IsFloat(); // 0x000000018C1B6E98-0x000000018C1B6EA4
		public bool IsString(); // 0x000000018C1B6EF8-0x000000018C1B6F04
		public bool IsPathFile(); // 0x000000018C1B6EC8-0x000000018C1B6EE0
		public bool HasMin(); // 0x0000000187250600-0x0000000187250610
		public bool HasMax(); // 0x00000001872505F0-0x0000000187250600
		public bool HasUIMin(); // 0x0000000187250620-0x0000000187250630
		public bool HasUIMax(); // 0x0000000187250610-0x0000000187250620
		public bool IsContainer(); // 0x000000018C1B6700-0x000000018C1B6744
		public bool IsMultiParam(); // 0x000000018C1B6EBC-0x000000018C1B6EC8
		public bool IsRamp(); // 0x000000018C1B6EE0-0x000000018C1B6EF8
		public bool IsFloatRamp(); // 0x000000018C1B6E8C-0x000000018C1B6E98
		public bool IsColorRamp(); // 0x000000018C1B66E8-0x000000018C1B66F4
		public bool IsToggle(); // 0x000000018C1B6F04-0x000000018C1B6F10
		public bool IsColor(); // 0x000000018C1B66F4-0x000000018C1B6700
		public bool IsFolder(); // 0x000000018C1B6EA4-0x000000018C1B6EB0
		public bool IsButton(); // 0x000000018C1B66DC-0x000000018C1B66E8
		public Vector3 ToVector3(); // 0x000000018C1B6F10-0x000000018C1B6F90
		public bool IsAssetPath(); // 0x0000000184F6ABE0-0x0000000184F6ABF0
		public bool IsEquivalentTo(HEU_ParameterData other); // 0x000000018C1B6744-0x000000018C1B6E8C
	}

	public enum HEU_ModifierActionWrapper // TypeDefIndex: 78336
	{
		MULTIPARM_INSERT = 0,
		MULTIPARM_REMOVE = 1,
		MULTIPARM_CLEAR = 2,
		SET_FLOAT = 3,
		SET_INT = 4
	}

	[Serializable]
	public class HEU_ParameterModifier : IEquivable<HEU_ParameterModifier> // TypeDefIndex: 78338
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
		public int ParameterIndex { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public HEU_ModifierActionWrapper Action { get; set; } // 0x000000018C1B7324-0x000000018C1B7330 0x000000018C1B7330-0x000000018C1B7350
		public int InstanceIndex { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public int ModifierValue { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public float FloatValue { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public int IntValue { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
	
		// Nested types
		internal enum ModifierAction // TypeDefIndex: 78337
		{
			MULTIPARM_INSERT = 0,
			MULTIPARM_REMOVE = 1,
			MULTIPARM_CLEAR = 2,
			SET_FLOAT = 3,
			SET_INT = 4
		}
	
		// Constructors
		public HEU_ParameterModifier(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static HEU_ParameterModifier GetNewModifier(HEU_ModifierActionWrapper action, int parameterIndex, int instanceIndex, int modifierValue); // 0x000000018C1B7048-0x000000018C1B7090
		internal static HEU_ParameterModifier GetNewModifier(ModifierAction action, int parameterIndex, int instanceIndex, int modifierValue); // 0x000000018C1B7090-0x000000018C1B7104
		public bool IsEquivalentTo(HEU_ParameterModifier other); // 0x000000018C1B7104-0x000000018C1B72F0
		internal static HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(ModifierAction action); // 0x000000018C1B72F0-0x000000018C1B7324
		internal static ModifierAction ModifierAction_WrapperToInternal(HEU_ModifierActionWrapper action); // 0x000000018C1B72F0-0x000000018C1B7324
	}

	public class HEU_Parameters : ScriptableObject, IHEU_Parameters, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_Parameters> // TypeDefIndex: 78341
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
		public HEU_HoudiniAsset ParentAsset { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public bool ShowParameters { get; set; } // 0x0000000187235D90-0x0000000187235DA0 0x0000000187235DE0-0x0000000187235DF0
		public int NodeID { get; internal set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public List<int> RootParameters { get; } // 0x000000018226EE80-0x000000018226EE90 
		public List<HEU_ParameterModifier> ParameterModifiers { get; } // 0x0000000187232F70-0x0000000187232F80 
		internal bool RequiresRegeneration { get; set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		internal bool RecacheUI { get; set; } // 0x0000000187235DA0-0x0000000187235DB0 0x0000000187235DF0-0x0000000187235E00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 78339
		{
			// Fields
			public int parentID; // 0x10
			public Predicate<HAPI_ParmInfo> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass82_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Initialize_b__0(HAPI_ParmInfo p); // 0x0000000182A92250-0x0000000182A92270
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0 // TypeDefIndex: 78340
		{
			// Fields
			public int parentID; // 0x10
			public Predicate<HAPI_ParmInfo> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass83_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Initialize4HGTool_b__0(HAPI_ParmInfo p); // 0x0000000182A92250-0x0000000182A92270
		}
	
		// Constructors
		public HEU_Parameters(); // 0x000000018C1C2350-0x000000018C1C2490
	
		// Methods
		internal byte[] GetPresetData(); // 0x0000000187232F80-0x0000000187232F90
		internal void SetPresetData(byte[] data); // 0x0000000186B19440-0x0000000186B19450
		internal byte[] GetDefaultPresetData(); // 0x0000000187232FC0-0x0000000187232FD0
		public bool AreParametersValid(); // 0x000000018226EFA0-0x000000018226EFB0
		public HEU_SessionBase GetSession(); // 0x000000018C1B9E28-0x000000018C1B9EC0
		public void Recook(); // 0x000000018C1BF1A8-0x000000018C1BF210
		public List<HEU_ParameterData> GetParameters(); // 0x000000018226EBD0-0x000000018226EBE0
		public HEU_ParameterData GetParameter(int listIndex); // 0x000000018C1B9B58-0x000000018C1B9BC8
		public HEU_ParameterData GetParameter(string name); // 0x000000018C1B9BC8-0x000000018C1B9D0C
		public HEU_ParameterData GetParameterWithParmID(int parmID); // 0x000000018C1B9A34-0x000000018C1B9B58
		public void RemoveParameter(int listIndex); // 0x000000018C1BF29C-0x000000018C1BF308
		public bool HaveParametersChanged(); // 0x000000018C1BA2B8-0x000000018C1BA74C
		public bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x0262B7B5 */); // 0x000000018C1BF4B8-0x000000018C1BF500
		public bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x0262B7B6 */, bool bRecookAsset = false /* Metadata: 0x0262B7B7 */); // 0x000000018C1C0140-0x000000018C1C0348
		public bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x0262B7B8 */); // 0x000000018C1B856C-0x000000018C1B8764
		public bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x0262B7B9 */); // 0x000000018C1C0348-0x000000018C1C05A8
		public bool GetFloatParameterValues(string parameterName, out float[] values); // 0x000000018C1B8764-0x000000018C1B88FC
		public bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x0262B7BA */); // 0x000000018C1BFB90-0x000000018C1BFCBC
		public bool GetColorParameterValue(string parameterName, out UnityEngine.Color value); // 0x000000018C1B7F08-0x000000018C1B8028
		public bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x0262B7BB */, bool bRecookAsset = false /* Metadata: 0x0262B7BC */); // 0x000000018C1C0A30-0x000000018C1C0C38
		public bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x0262B7BD */); // 0x000000018C1B911C-0x000000018C1B9314
		public bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x0262B7BE */); // 0x000000018C1C0C38-0x000000018C1C0E98
		public bool GetIntParameterValues(string parameterName, out int[] values); // 0x000000018C1B9314-0x000000018C1B94B4
		public bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x0262B7BF */); // 0x000000018C1BF9C0-0x000000018C1BFB90
		public bool GetChoiceParameterValue(string parameterName, out int value); // 0x000000018C1B7D60-0x000000018C1B7F08
		public bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x0262B7C0 */, bool bRecookAsset = false /* Metadata: 0x0262B7C1 */); // 0x000000018C1BF8A4-0x000000018C1BF9C0
		public bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x0262B7C2 */); // 0x000000018C1B7C54-0x000000018C1B7D60
		public bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x0262B7C3 */, bool bRecookAsset = false /* Metadata: 0x0262B7C4 */); // 0x000000018C1C14F8-0x000000018C1C1700
		public bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x0262B7C5 */); // 0x000000018C1B9EC0-0x000000018C1BA0DC
		public bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x0262B7C6 */); // 0x000000018C1C1700-0x000000018C1C196C
		public bool GetStringParameterValues(string parameterName, out string[] values); // 0x000000018C1BA0DC-0x000000018C1BA274
		public bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x0262B7C7 */, bool bRecookAsset = false /* Metadata: 0x0262B7C8 */); // 0x000000018C1BF500-0x000000018C1BF6C8
		public bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x0262B7C9 */); // 0x000000018C1BF6C8-0x000000018C1BF8A4
		public bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x0262B7CA */); // 0x000000018C1B790C-0x000000018C1B7A88
		public bool GetAssetRefParameterValues(string parameterName, out GameObject[] values); // 0x000000018C1B7A88-0x000000018C1B7C54
		public bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x0262B7CB */); // 0x000000018C1C1298-0x000000018C1C14F8
		public bool GetRampParameterNumPoints(string parameterName, out int numPoints); // 0x000000018C1B9D0C-0x000000018C1B9E28
		public bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B7CC */, bool bRecookAsset = false /* Metadata: 0x0262B7CD */); // 0x000000018C1C05A8-0x000000018C1C08A0
		public bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType); // 0x000000018C1B88FC-0x000000018C1B8BF0
		public bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x0262B7CE */); // 0x000000018C1C08A0-0x000000018C1C0A30
		public bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints); // 0x000000018C1B8BF0-0x000000018C1B8E44
		public bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B7CF */, bool bRecookAsset = false /* Metadata: 0x0262B7D0 */); // 0x000000018C1BFCBC-0x000000018C1BFFA0
		public bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType); // 0x000000018C1B8028-0x000000018C1B8318
		public bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x0262B7D1 */); // 0x000000018C1BFFA0-0x000000018C1C0140
		public bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints); // 0x000000018C1B8318-0x000000018C1B856C
		public bool TriggerButtonParameter(string parameterName); // 0x000000018C1C1E80-0x000000018C1C1FBC
		public bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecook = true /* Metadata: 0x0262B7D2 */); // 0x000000018C1C0E98-0x000000018C1C1298
		public bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples); // 0x000000018C1B9650-0x000000018C1B9A34
		internal bool Initialize(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, Dictionary<string, HEU_ParameterData> previousParamFolders, Dictionary<string, HEU_InputNode> previousParamInputNodes, HEU_HoudiniAsset parentAsset); // 0x000000018C1BC8B4-0x000000018C1BEA54
		internal bool Initialize4HGTool(HEU_SessionBase session, int nodeID, ref HAPI_NodeInfo nodeInfo, int parentNodeId); // 0x000000018C1BA74C-0x000000018C1BC8B4
		private void SetupRampParameter(HEU_ParameterData rampParameter); // 0x000000018C1C196C-0x000000018C1C1D78
		internal bool UploadValuesToHoudini(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bDoCheck = true /* Metadata: 0x0262B7D3 */, bool bForceUploadInputs = false /* Metadata: 0x0262B7D4 */); // 0x000000018C1C224C-0x000000018C1C2350
		internal void InsertInstanceToMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToAdd); // 0x000000018C1BEA54-0x000000018C1BEADC
		internal void RemoveInstancesFromMultiParm(int unityParamIndex, int instanceIndex, int numInstancesToRemove); // 0x000000018C1BF210-0x000000018C1BF29C
		internal void ClearInstancesFromMultiParm(int unityParamIndex); // 0x000000018C1B77FC-0x000000018C1B786C
		internal bool HasModifiersPending(); // 0x000000018C1BA274-0x000000018C1BA2B8
		internal void ProcessModifiers(HEU_SessionBase session); // 0x000000018C1BED44-0x000000018C1BF1A8
		internal void GetParameterDataForUIRestore(Dictionary<string, HEU_ParameterData> folderParams, Dictionary<string, HEU_InputNode> inputNodeParams); // 0x000000018C1B94B4-0x000000018C1B9650
		internal void GetInputNodeConnectionObjects(List<GameObject> inputNodeObjects); // 0x000000018C1B8E44-0x000000018C1B911C
		internal void DownloadPresetData(HEU_SessionBase session); // 0x000000018C1B78BC-0x000000018C1B790C
		internal void UploadPresetData(HEU_SessionBase session); // 0x000000018C1C2224-0x000000018C1C224C
		internal void DownloadAsDefaultPresetData(HEU_SessionBase session); // 0x000000018C1B786C-0x000000018C1B78BC
		internal void UploadParameterInputs(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, bool bForceUpdate); // 0x000000018C1C204C-0x000000018C1C2224
		internal void UpdateTransformParameters(HEU_SessionBase session, ref HAPI_TransformEuler HAPITransform); // 0x000000018C1C1FBC-0x000000018C1C204C
		internal void SyncParameterFromHoudini(HEU_SessionBase session, string parameterName); // 0x000000018C1C1E50-0x000000018C1C1E80
		internal void SyncInternalParametersForUndoCompare(HEU_SessionBase session); // 0x000000018C1C1D78-0x000000018C1C1E50
		internal void CleanUp(); // 0x000000018C1B7350-0x000000018C1B77FC
		internal void ResetAllToDefault(HEU_SessionBase session); // 0x000000018C1BF308-0x000000018C1BF4B8
		public bool IsEquivalentTo(HEU_Parameters other); // 0x000000018C1BEADC-0x000000018C1BED44
	}

	public static class HEU_ParameterUtility // TypeDefIndex: 78342
	{
		// Methods
		public static bool GetToggle(HEU_HoudiniAsset asset, string paramName, out bool outValue); // 0x000000018C1D7A80-0x000000018C1D7B44
		public static bool SetToggle(HEU_HoudiniAsset asset, string paramName, bool setValue); // 0x000000018C1D80C4-0x000000018C1D818C
		public static bool GetInt(HEU_HoudiniAsset asset, string paramName, out int outValue); // 0x000000018C1D7664-0x000000018C1D772C
		public static bool SetInt(HEU_HoudiniAsset asset, string paramName, int setValue); // 0x000000018C1D7F34-0x000000018C1D7FFC
		public static bool GetFloat(HEU_HoudiniAsset asset, string paramName, out float outValue); // 0x000000018C1D7404-0x000000018C1D74CC
		public static bool GetFloats(HEU_HoudiniAsset asset, string paramName, out float[] outValues); // 0x000000018C1D74CC-0x000000018C1D7594
		public static bool SetFloat(HEU_HoudiniAsset asset, string paramName, float setValue); // 0x000000018C1D7CD4-0x000000018C1D7D9C
		public static bool SetFloats(HEU_HoudiniAsset asset, string paramName, float[] setValues); // 0x000000018C1D7D9C-0x000000018C1D7E60
		public static bool GetString(HEU_HoudiniAsset asset, string paramName, out string outValue); // 0x000000018C1D79B0-0x000000018C1D7A80
		public static bool SetString(HEU_HoudiniAsset asset, string paramName, string setValue); // 0x000000018C1D7FFC-0x000000018C1D80C4
		public static bool SetChoice(HEU_HoudiniAsset asset, string paramName, int setValue); // 0x000000018C1D7B44-0x000000018C1D7C08
		public static bool GetChoice(HEU_HoudiniAsset asset, string paramName, out int outValue); // 0x000000018C1D7278-0x000000018C1D7338
		public static bool SetInputNode(HEU_HoudiniAsset asset, string paramName, GameObject obj, int index); // 0x000000018C1D7E60-0x000000018C1D7F34
		public static bool GetInputNode(HEU_HoudiniAsset asset, string paramName, int index, out GameObject obj); // 0x000000018C1D7594-0x000000018C1D7664
		public static bool GetColor(HEU_HoudiniAsset asset, string paramName, out UnityEngine.Color getValue); // 0x000000018C1D7338-0x000000018C1D7404
		public static bool SetColor(HEU_HoudiniAsset asset, string paramName, UnityEngine.Color setValue); // 0x000000018C1D7C08-0x000000018C1D7CD4
		public static int GetParameterIndexFromName(HEU_SessionBase session, HAPI_ParmInfo[] parameters, string parameterName); // 0x000000018C1D78F4-0x000000018C1D79B0
		public static int GetParameterIndexFromNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName); // 0x000000018C1D78C0-0x000000018C1D78F4
		public static int FindTextureParamByNameOrTag(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, string useTextureParmName); // 0x000000018C1D7184-0x000000018C1D7278
		public static bool GetParameterFloatValue(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, float defaultValue, out float returnValue); // 0x000000018C1D7810-0x000000018C1D78C0
		public static bool GetParameterColor3Value(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, string parameterName, UnityEngine.Color defaultValue, out UnityEngine.Color outputColor); // 0x000000018C1D772C-0x000000018C1D7810
	}

	[Serializable]
	public class HEU_PDGCookedDataEvent : UnityEvent<HEU_PDGCookedEventData> // TypeDefIndex: 78343
	{
		// Constructors
		public HEU_PDGCookedDataEvent(); // 0x000000018C1D68DC-0x000000018C1D6918
	}

	public class HEU_PDGCookedEventData // TypeDefIndex: 78344
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_TOPNodeData TopNodeData; // 0x18
	
		// Constructors
		public HEU_PDGCookedEventData(bool bSuccess, HEU_TOPNodeData bTopNodeData); // 0x00000001851E8C10-0x00000001851E8C20
	}

	[ExecuteInEditMode]
	public class HEU_PDGAssetLink : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 78349
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
		public bool AutoCook { get; set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		public bool UseHEngineData { get; set; } // 0x00000001872361E0-0x00000001872361F0 0x000000018723EB60-0x000000018723EB70
		public bool UseTOPNodeFilter { get; set; } // 0x000000018236FC60-0x000000018236FC70 0x000000018236FC70-0x000000018236FC80
		public bool UseTOPOutputFilter { get; set; } // 0x0000000187235FA0-0x0000000187235FB0 0x000000018723EB40-0x000000018723EB50
		public string TopNodeFilter { get; set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public string TopOutputFilter { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public HEU_HoudiniAsset ParentAsset { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public string AssetPath { get; } // 0x000000018225E800-0x000000018225E810 
		public GameObject AssetGO { get; } // 0x0000000182262130-0x0000000182262140 
		public string AssetName { get; } // 0x00000001829600D0-0x00000001829600E0 
		public int AssetID { get; } // 0x00000001829600C0-0x00000001829600D0 
		public List<HEU_TOPNetworkData> TopNetworks { get; } // 0x000000018226EE80-0x000000018226EE90 
		public string[] TopNetworkNames { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public int SelectedTOPNetwork { get; } // 0x00000001872331A0-0x00000001872331B0 
		public HEU_LinkStateWrapper PDGLinkState { get; } // 0x000000018C1D68B0-0x000000018C1D68DC 
		public GameObject LoadRootGameObject { get; } // 0x00000001829CD170-0x00000001829CD180 
		public string OutputCachePathRoot { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public HEU_PDGCookedDataEvent CookedDataEvent { get; } // 0x0000000182234E30-0x0000000182234E40 
		internal LinkState AssetLinkStateInternal { get; } // 0x0000000187233600-0x0000000187233610 
	
		// Nested types
		internal enum LinkState // TypeDefIndex: 78345
		{
			INACTIVE = 0,
			LINKING = 1,
			LINKED = 2,
			ERROR_NOT_LINKED = 3
		}
	
		public delegate void UpdateUIDelegate(); // TypeDefIndex: 78346; 0x0000000185B44B70-0x0000000185B44B80
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0 // TypeDefIndex: 78347
		{
			// Fields
			public HEU_PDGAssetLink __4__this; // 0x10
			public Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced; // 0x18
			public HEU_TOPNodeData topNode; // 0x20
	
			// Constructors
			public __c__DisplayClass107_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_1 // TypeDefIndex: 78348
		{
			// Fields
			public HEU_GeoSync geoSync; // 0x10
			public __c__DisplayClass107_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass107_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadResults_b__0(HEU_SyncedEventData Data); // 0x000000018C1DB674-0x000000018C1DB750
		}
	
		// Constructors
		public HEU_PDGAssetLink(); // 0x000000018C1D679C-0x000000018C1D68B0
	
		// Methods
		public void Setup(HEU_HoudiniAsset hdaAsset); // 0x000000018C1D61F4-0x000000018C1D6384
		public void Reset(); // 0x000000018C1D6050-0x000000018C1D6058
		public void Refresh(); // 0x000000018C1D5CF4-0x000000018C1D5F88
		public List<KeyValuePair<int, HEU_TOPNodeData>> GetNonHiddenTOPNodes(HEU_TOPNetworkData topNetwork); // 0x000000018C1D419C-0x000000018C1D42F0
		public void SelectTOPNetwork(int newIndex); // 0x000000018C1D6058-0x000000018C1D60AC
		public void SelectTOPNode(HEU_TOPNetworkData network, int newIndex); // 0x000000018C1D60AC-0x000000018C1D6104
		public HEU_TOPNetworkData GetSelectedTOPNetwork(); // 0x000000018C1D42F0-0x000000018C1D42FC
		public HEU_TOPNodeData GetSelectedTOPNode(); // 0x000000018C1D42FC-0x000000018C1D4378
		public HEU_TOPNetworkData GetTOPNetwork(int index); // 0x000000018C1D4420-0x000000018C1D4490
		public void DirtyTOPNode(HEU_TOPNodeData topNode); // 0x000000018C1D3E90-0x000000018C1D3EB8
		public void CookTOPNode(HEU_TOPNodeData topNode); // 0x000000018C1D3E90-0x000000018C1D3EB8
		public void DirtyAll(); // 0x000000018C1D4068-0x000000018C1D4088
		public void CookOutput(); // 0x000000018C1D3E4C-0x000000018C1D3E90
		public void PauseCook(); // 0x000000018C1D38BC-0x000000018C1D38CC
		public void CancelCook(); // 0x000000018C1D38BC-0x000000018C1D38CC
		public HEU_SessionBase GetHAPISession(); // 0x000000018C1D4088-0x000000018C1D40FC
		public HEU_TOPNodeData GetTOPNode(int nodeID); // 0x000000018C1D4608-0x000000018C1D476C
		public string GetTOPNodeStatus(HEU_TOPNodeData topNode); // 0x000000018C1D4538-0x000000018C1D4608
		public static HEU_TOPNetworkData GetTOPNetworkByName(string name, List<HEU_TOPNetworkData> topNetworks); // 0x000000018C1D4378-0x000000018C1D4420
		public static HEU_TOPNodeData GetTOPNodeByName(string name, List<HEU_TOPNodeData> topNodes); // 0x000000018C1D4490-0x000000018C1D4538
		private void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnAfterDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		private void HandleInitialLoad(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x000000018C1D50A0-0x000000018C1D50B0
		private void NotifyAssetCooked(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> generatedOutputs); // 0x000000018C1D5068-0x000000018C1D50A0
		private void NotifyAssetCooked(HEU_CookedEventData cookedEventData); // 0x000000018C1D5040-0x000000018C1D5068
		private void NotifyAssetCooked(HEU_ReloadEventData reloadEventData); // 0x000000018C1D5040-0x000000018C1D5068
		private void PopulateFromHDA(); // 0x000000018C1D585C-0x000000018C1D59A4
		public bool PopulateTOPNetworks(); // 0x000000018C1D59A4-0x000000018C1D5B7C
		private bool PopulateTOPNodes(HEU_SessionBase session, HEU_TOPNetworkData topNetwork, int[] topNodeIDs, bool useHEngineData); // 0x000000018C1D5B7C-0x000000018C1D5CF4
		private void ClearAllTOPData(); // 0x000000018C1D38CC-0x000000018C1D3BA4
		private static void ClearTOPNetworkWorkItemResults(HEU_TOPNetworkData topNetwork); // 0x000000018C1D3BA4-0x000000018C1D3CBC
		internal static void ClearTOPNodeWorkItemResults(HEU_TOPNodeData topNode); // 0x000000018C1D3CBC-0x000000018C1D3DB8
		internal static void ClearWorkItemResultByID(HEU_TOPNodeData topNode, int workItemID); // 0x000000018C1D3DB8-0x000000018C1D3DDC
		private static void ClearWorkItemResult(HEU_TOPNodeData topNode, HEU_TOPWorkResult result); // 0x000000018C1D3DDC-0x000000018C1D3E4C
		internal void UpdateTOPNodeResultsVisibility(HEU_TOPNodeData topNode); // 0x000000018C1D6384-0x000000018C1D63F8
		private static HEU_TOPWorkResult GetWorkResultByID(HEU_TOPNodeData topNode, int workItemID); // 0x000000018C1D476C-0x000000018C1D48C8
		private static void DestroyWorkItemResultData(HEU_TOPNodeData topNode, HEU_TOPWorkResult result); // 0x000000018C1D3EB8-0x000000018C1D4068
		internal void LoadResults(HEU_SessionBase session, HEU_TOPNodeData topNode, HAPI_PDG_WorkItemInfo workItemInfo, HAPI_PDG_WorkItemOutputFile[] resultInfos, int workItemID, Action<HEU_TOPNodeData, HEU_SyncedEventData> OnSynced); // 0x000000018C1D48C8-0x000000018C1D5040
		private Transform GetLoadRootTransform(); // 0x000000018C1D40FC-0x000000018C1D419C
		public void RepaintUI(); // 0x000000018C1D5F88-0x000000018C1D5FA4
		public void UpdateWorkItemTally(); // 0x000000018C1D63F8-0x000000018C1D679C
		internal void ResetTOPNetworkWorkItemTally(HEU_TOPNetworkData topNetwork); // 0x000000018C1D5FA4-0x000000018C1D6050
		internal void OnTOPNodeFilterChanged(string filter); // 0x000000018C1D5108-0x000000018C1D5488
		internal void OnTOPOutputFilterChanged(string filter); // 0x000000018C1D5488-0x000000018C1D57FC
		private static void ParseHEngineData(HEU_SessionBase session, int topNodeID, ref HAPI_NodeInfo nodeInfo, ref TOPNodeTags nodeTags); // 0x000000018C1D57FC-0x000000018C1D585C
		private void SetupTopNetworkNames(HEU_TOPNetworkData topNetwork); // 0x000000018C1D6104-0x000000018C1D61F4
		private void OnSyncComplete(HEU_PDGCookedEventData Data); // 0x000000018C1D50B0-0x000000018C1D5108
		internal static HEU_LinkStateWrapper LinkState_InternalToWrapper(LinkState linkState); // 0x000000018C18A0A4-0x000000018C18A0CC
		internal static LinkState LinkState_WrapperToInternal(HEU_LinkStateWrapper linkState); // 0x000000018C18A0A4-0x000000018C18A0CC
	}

	public class TOPNodeTags // TypeDefIndex: 78350
	{
		// Fields
		public bool _show; // 0x10
		public bool _autoload; // 0x11
		public bool _showHEngineData; // 0x12
		public bool _autoloadHEngineData; // 0x13
	
		// Constructors
		public TOPNodeTags(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class HEU_TOPNetworkData // TypeDefIndex: 78351
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
		public HEU_TOPNetworkData(); // 0x000000018C1DAC00-0x000000018C1DACC8
	}

	[Serializable]
	public class HEU_TOPNodeData // TypeDefIndex: 78353
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
		public enum PDGState // TypeDefIndex: 78352
		{
			NONE = 0,
			DIRTIED = 1,
			DIRTYING = 2,
			COOKING = 3,
			COOK_COMPLETE = 4,
			COOK_FAILED = 5
		}
	
		// Constructors
		public HEU_TOPNodeData(); // 0x000000018C1DAD54-0x000000018C1DAE24
	
		// Methods
		public void Reset(); // 0x000000018C1DAD28-0x000000018C1DAD54
		public bool AreAllWorkItemsComplete(); // 0x000000018C1DAD08-0x000000018C1DAD28
		public bool AnyWorkItemsFailed(); // 0x000000018C1DACC8-0x000000018C1DACE8
		public bool AnyWorkItemsPending(); // 0x000000018C1DACE8-0x000000018C1DAD08
	}

	[Serializable]
	public class HEU_TOPWorkResult // TypeDefIndex: 78354
	{
		// Fields
		public int _workItemIndex; // 0x10
		public int _workItemID; // 0x14
		public List<GameObject> _generatedGOs; // 0x18
	
		// Constructors
		public HEU_TOPWorkResult(); // 0x000000018C1DAE24-0x000000018C1DAEA4
	}

	[Serializable]
	public class HEU_WorkItemTally // TypeDefIndex: 78355
	{
		// Fields
		public int _totalWorkItems; // 0x10
		public int _waitingWorkItems; // 0x14
		public int _scheduledWorkItems; // 0x18
		public int _cookingWorkItems; // 0x1C
		public int _cookedWorkItems; // 0x20
		public int _erroredWorkItems; // 0x24
	
		// Constructors
		public HEU_WorkItemTally(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void ZeroAll(); // 0x0000000187250820-0x0000000187250830
		public bool AreAllWorkItemsComplete(); // 0x000000018C1DB5C4-0x000000018C1DB5E4
		public bool AnyWorkItemsFailed(); // 0x000000018C1DB5A0-0x000000018C1DB5A8
		public bool AnyWorkItemsPending(); // 0x000000018C1DB5A8-0x000000018C1DB5C4
		public string ProgressRatio(); // 0x000000018C1DB5E4-0x000000018C1DB674
	}

	public class HEU_PDGSession // TypeDefIndex: 78359
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
		public Action<HEU_PDGCookedEventData> CookedDataEvent { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
		// Nested types
		private delegate void OnWorkItemLoadResultsDelegate(HEU_SyncedEventData OnSynced); // TypeDefIndex: 78356; 0x0000000185B78EA0-0x0000000185B78EB0
	
		private enum EventMessageColor // TypeDefIndex: 78357
		{
			DEFAULT = 0,
			WARNING = 1,
			ERROR = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 78358
		{
			// Fields
			public int[] allNetworkNodeIds; // 0x10
			public int idx; // 0x18
			public Predicate<int> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetNonBypassedNetworkIds_b__0(int id); // 0x000000018C1DB750-0x000000018C1DB780
		}
	
		// Constructors
		public HEU_PDGSession(); // 0x000000018C1D7034-0x000000018C1D7184
	
		// Methods
		public static HEU_PDGSession GetPDGSession(); // 0x000000018C1D6C24-0x000000018C1D6CB4
		public void AddAsset(HEU_PDGAssetLink asset); // 0x0000000186805BA0-0x0000000186805BB0
		public void RemoveAsset(HEU_PDGAssetLink asset); // 0x0000000186805BA0-0x0000000186805BB0
		private void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		private void CleanUp(); // 0x000000018C1D69EC-0x000000018C1D6AB4
		private void UpdatePDGContext(); // 0x0000000186805BA0-0x0000000186805BB0
		public void ReinitializePDGContext(); // 0x0000000186805BA0-0x0000000186805BB0
		private void ProcessPDGEvent(HEU_SessionBase session, int contextID, ref HAPI_PDG_EventInfo eventInfo); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnWorkItemLoadResults(HEU_TOPNodeData topNode, HEU_SyncedEventData OnSynced); // 0x000000018C1D6F84-0x000000018C1D6F90
		private void CheckCallback(HEU_TOPNodeData topNode); // 0x000000018C1D6938-0x000000018C1D69EC
		private bool GetTOPAssetLinkAndNode(int nodeID, out HEU_PDGAssetLink assetLink, out HEU_TOPNodeData topNode); // 0x000000018C1D6CB4-0x000000018C1D6DC0
		private void SetTOPNodePDGState(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, HEU_TOPNodeData.PDGState pdgState); // 0x000000018C1D6FD8-0x000000018C1D7034
		private void NotifyTOPNodePDGStateClear(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode); // 0x000000018C1D6E84-0x000000018C1D6EC4
		private void NotifyTOPNodeTotalWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x000000018C1D6F04-0x000000018C1D6F44
		private void NotifyTOPNodeCookedWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode); // 0x000000018C1D6DDC-0x000000018C1D6E10
		private void NotifyTOPNodeErrorWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode); // 0x000000018C1D6E50-0x000000018C1D6E84
		private void NotifyTOPNodeWaitingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x000000018C1D6F44-0x000000018C1D6F84
		private void NotifyTOPNodeScheduledWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x000000018C1D6EC4-0x000000018C1D6F04
		private void NotifyTOPNodeCookingWorkItem(HEU_PDGAssetLink assetLink, HEU_TOPNodeData topNode, int inc); // 0x000000018C1D6E10-0x000000018C1D6E50
		private static void ResetPDGEventInfo(ref HAPI_PDG_EventInfo eventInfo); // 0x00000001872506A0-0x00000001872506C0
		private void SetErrorState(string msg, bool bLogIt); // 0x000000018C1D6F90-0x000000018C1D6FD8
		private void ClearErrorState(); // 0x000000018C1D6AB4-0x000000018C1D6AF8
		public HEU_SessionBase GetHAPIPDGSession(bool bCreate = true /* Metadata: 0x0262B7DF */); // 0x000000018C1D6B40-0x000000018C1D6B90
		public void CookTOPNetworkOutputNode(HEU_TOPNetworkData topNetwork, Action<HEU_PDGCookedEventData> OnCook = null); // 0x0000000186805BA0-0x0000000186805BB0
		public void PauseCook(HEU_TOPNetworkData topNetwork); // 0x0000000186805BA0-0x0000000186805BB0
		public void CancelCook(HEU_TOPNetworkData topNetwork); // 0x0000000186805BA0-0x0000000186805BB0
		public void ClearWorkItemResult(HEU_SessionBase session, int contextID, HAPI_PDG_EventInfo eventInfo, HEU_TOPNodeData topNode); // 0x0000000186805BA0-0x0000000186805BB0
		public bool DirtyTOPNode(int nodeID); // 0x00000001843FFFF0-0x0000000184400000
		public bool CookTOPNode(int nodeID); // 0x00000001843FFFF0-0x0000000184400000
		public bool DirtyAll(int nodeID); // 0x00000001843FFFF0-0x0000000184400000
		public void AddEventMessage(string msg); // 0x000000018C1D6918-0x000000018C1D6938
		public string GetEventMessages(); // 0x000000018C1D6B1C-0x000000018C1D6B40
		public void ClearEventMessages(); // 0x000000018C1D6AF8-0x000000018C1D6B1C
		public static int[] GetNonBypassedNetworkIds(HEU_SessionBase session, int assetId); // 0x000000018C1D6B90-0x000000018C1D6C24
		public static bool IsPDGAsset(HEU_SessionBase session, int assetId); // 0x000000018C1D6DC0-0x000000018C1D6DDC
		private void ResetCallbackVariables(); // 0x0000000187250690-0x00000001872506A0
	}

	public interface IHEU_Curve // TypeDefIndex: 78360
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
		void SetCurvePoint(int pointIndex, Vector3 newPosition, bool bRecookAsset = false /* Metadata: 0x0262B7E3 */);
		void SetCurvePoint(int pointIndex, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0262B7E4 */);
		void SetCurveNodeData(List<CurveNodeData> curveNodeData, bool bRecookAsset = false /* Metadata: 0x0262B7E5 */);
		Vector3 GetCurvePoint(int pointIndex);
		List<CurveNodeData> GetAllPointTransforms();
		List<Vector3> GetAllPoints();
		int GetNumPoints();
		void InsertCurvePoint(int index, Vector3 position, bool bRecookAsset = false /* Metadata: 0x0262B7E6 */);
		void InsertCurvePoint(int index, CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0262B7E7 */);
		void AddCurvePointToEnd(Vector3 position, bool bRecookAsset = false /* Metadata: 0x0262B7E8 */);
		void AddCurvePointToEnd(CurveNodeData curveData, bool bRecookAsset = false /* Metadata: 0x0262B7E9 */);
		void RemoveCurvePoint(int pointIndex, bool bRecookAsset = false /* Metadata: 0x0262B7EA */);
		void ClearCurveNodeData(bool bRecookAsset = false /* Metadata: 0x0262B7EB */);
		void ProjectToColliders(Vector3 rayDirection, float rayDistance, bool bRecookAsset = false /* Metadata: 0x0262B7EC */);
		void SetCurveGeometryVisibility(bool bVisible, bool bRecookAsset = false /* Metadata: 0x0262B7ED */);
		Vector3 GetTransformedPoint(int pointIndex);
		List<Vector3> GetTransformedPoints();
		List<CurveNodeData> DuplicateCurveNodeData();
	}

	public interface IHEU_GeoNode // TypeDefIndex: 78361
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
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x0262B7EE */);
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

	public enum HEU_AssetCookStatusWrapper // TypeDefIndex: 78362
	{
		NONE = 0,
		COOKING = 1,
		POSTCOOK = 2,
		LOADING = 3,
		POSTLOAD = 4,
		PRELOAD = 5,
		SELECT_SUBASSET = 6
	}

	public enum HEU_AssetCookResultWrapper // TypeDefIndex: 78363
	{
		NONE = 0,
		SUCCESS = 1,
		ERRORED = 2
	}

	public enum HEU_CurveDrawCollisionWrapper // TypeDefIndex: 78364
	{
		INVALID = 0,
		COLLIDERS = 1,
		LAYERMASK = 2
	}

	public enum HEU_AssetTypeWrapper // TypeDefIndex: 78365
	{
		TYPE_INVALID = 0,
		TYPE_HDA = 1,
		TYPE_CURVE = 2,
		TYPE_INPUT = 3
	}

	public interface IHEU_HoudiniAsset // TypeDefIndex: 78366
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
		bool RequestCook(bool bCheckParametersChanged = true /* Metadata: 0x0262B800 */, bool bAsync = false /* Metadata: 0x0262B801 */, bool bSkipCookCheck = true /* Metadata: 0x0262B802 */, bool bUploadParameters = true /* Metadata: 0x0262B803 */);
		bool RequestReload(bool bAsync = false /* Metadata: 0x0262B804 */);
		bool RequestResetParameters(bool bAsync = false /* Metadata: 0x0262B805 */);
		GameObject DuplicateAsset(GameObject newRootGameObject = null);
		bool DeleteAllGeneratedData(bool bIsRebuild = false /* Metadata: 0x0262B806 */);
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

	public interface IHEU_HoudiniAssetSubcomponent // TypeDefIndex: 78367
	{
		// Properties
		HEU_HoudiniAsset ParentAsset { get; }
	
		// Methods
		HEU_SessionBase GetSession();
		void Recook();
	}

	public enum HEU_InputNodeTypeWrapper // TypeDefIndex: 78368
	{
		CONNECTION = 0,
		NODE = 1,
		PARAMETER = 2
	}

	public enum HEU_InputObjectTypeWrapper // TypeDefIndex: 78369
	{
		HDA = 0,
		UNITY_MESH = 1,
		CURVE = 2,
		TERRAIN = 3,
		BOUNDING_BOX = 4,
		TILEMAP = 5
	}

	public interface IHEU_InputNode // TypeDefIndex: 78370
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
		void SetInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x0262B810 */);
		void InsertInputEntry(int index, GameObject newInputGameObject, bool bRecookAsset = false /* Metadata: 0x0262B811 */);
		void AddInputEntryAtEnd(GameObject newEntryGameObject, bool bRecookAsset = false /* Metadata: 0x0262B812 */);
		void ResetInputNode(bool bRecookAsset = false /* Metadata: 0x0262B813 */);
		void ChangeInputType(HEU_InputObjectTypeWrapper newType, bool bRecookAsset = false /* Metadata: 0x0262B814 */);
		void RemoveInputEntry(int index, bool bRecookAsset = false /* Metadata: 0x0262B815 */);
		void RemoveAllInputEntries(bool bRecookAsset = false /* Metadata: 0x0262B816 */);
		void SetInputEntryObjectUseTransformOffset(int index, bool value, bool bRecookAsset = false /* Metadata: 0x0262B817 */);
		void SetInputEntryObjectTransformTranslateOffset(int index, Vector3 translateOffset, bool bRecookAsset = false /* Metadata: 0x0262B818 */);
		void SetInputEntryObjectTransformRotateOffset(int index, Vector3 rotateOffset, bool bRecookAsset = false /* Metadata: 0x0262B819 */);
		void SetInputEntryObjectTransformScaleOffset(int index, Vector3 scaleOffset, bool bRecookAsset = false /* Metadata: 0x0262B81A */);
		bool AreAnyInputHDAsConnected();
		int GetConnectedInputCount();
		int GetConnectedNodeID(int index);
		void LoadPreset(HEU_InputPreset inputPreset);
		void PopulateInputPreset(HEU_InputPreset inputPreset, bool sceneRelativeGameObjects);
	}

	public enum HEU_MaterialSourceWrapper // TypeDefIndex: 78371
	{
		DEFAULT = 0,
		HOUDINI = 1,
		UNITY = 2,
		SUBSTANCE = 3
	}

	public interface IHEU_MaterialData // TypeDefIndex: 78372
	{
		// Properties
		Material Material { get; }
		HEU_MaterialSourceWrapper MaterialSource { get; }
		int MaterialKey { get; set; }
	
		// Methods
		bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath);
		bool IsExistingMaterial();
	}

	public interface IHEU_ObjectNode // TypeDefIndex: 78373
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

	public enum HEU_HoudiniRampInterpolationTypeWrapper // TypeDefIndex: 78374
	{
		CONSTANT = 0,
		LINEAR = 1,
		CATMULL_ROM = 2
	}

	public class HEU_RampPointWrapper // TypeDefIndex: 78375
	{
		// Fields
		[CompilerGenerated]
		private float _Position_k__BackingField; // 0x10
		[CompilerGenerated]
		private HEU_HoudiniRampInterpolationTypeWrapper _Interpolation_k__BackingField; // 0x14
	
		// Properties
		public float Position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public HEU_HoudiniRampInterpolationTypeWrapper Interpolation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
	
		// Constructors
		public HEU_RampPointWrapper(float position = 0f /* Metadata: 0x0262B822 */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B826 */); // 0x00000001872506C0-0x00000001872506D0
	}

	public class HEU_FloatRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 78376
	{
		// Fields
		[CompilerGenerated]
		private float _Value_k__BackingField; // 0x18
	
		// Properties
		public float Value { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
	
		// Constructors
		public HEU_FloatRampPointWrapper(float position = 0f /* Metadata: 0x0262B827 */, float value = 0f /* Metadata: 0x0262B82B */, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B82F */); // 0x0000000187250680-0x0000000187250690
	}

	public class HEU_ColorRampPointWrapper : HEU_RampPointWrapper // TypeDefIndex: 78377
	{
		// Fields
		[CompilerGenerated]
		private UnityEngine.Color _Value_k__BackingField; // 0x18
	
		// Properties
		public UnityEngine.Color Value { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
	
		// Constructors
		public HEU_ColorRampPointWrapper(float position = 0f /* Metadata: 0x0262B830 */, UnityEngine.Color value = default, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B834 */); // 0x0000000187250660-0x0000000187250680
	}

	public class HEU_ParameterTupleWrapper // TypeDefIndex: 78378
	{
		// Fields
		internal bool[] _boolValues; // 0x10
		internal int[] _intValues; // 0x18
		internal float[] _floatValues; // 0x20
		internal string[] _stringValues; // 0x28
		internal HEU_FloatRampPointWrapper[] _floatRampValues; // 0x30
		internal HEU_ColorRampPointWrapper[] _colorRampValues; // 0x38
	
		// Properties
		public bool[] BoolValues { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public int[] IntValues { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float[] FloatValues { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string[] StringValues { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public HEU_FloatRampPointWrapper[] FloatRampValues { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public HEU_ColorRampPointWrapper[] ColorRampValues { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Constructors
		public HEU_ParameterTupleWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
		public HEU_ParameterTupleWrapper(bool[] boolValues); // 0x0000000184FD2410-0x0000000184FD2420
		public HEU_ParameterTupleWrapper(int[] intValues); // 0x0000000187835500-0x0000000187835510
		public HEU_ParameterTupleWrapper(float[] floatValues); // 0x0000000187835950-0x0000000187835960
		public HEU_ParameterTupleWrapper(string[] stringValues); // 0x0000000185CA30F0-0x0000000185CA3100
		public HEU_ParameterTupleWrapper(HEU_FloatRampPointWrapper[] floatRampValues); // 0x000000018783BA80-0x000000018783BA90
		public HEU_ParameterTupleWrapper(HEU_ColorRampPointWrapper[] colorRampValues); // 0x0000000186AB5C00-0x0000000186AB5C10
	}

	public interface IHEU_Parameters // TypeDefIndex: 78379
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
		bool ResetAllToDefault(bool bRecookAsset = false /* Metadata: 0x0262B835 */);
		bool SetFloatParameterValue(string parameterName, float value, int atIndex = 0 /* Metadata: 0x0262B836 */, bool bRecookAsset = false /* Metadata: 0x0262B837 */);
		bool GetFloatParameterValue(string parameterName, out float value, int atIndex = 0 /* Metadata: 0x0262B838 */);
		bool SetFloatParameterValues(string parameterName, float[] values, bool bRecookAsset = false /* Metadata: 0x0262B839 */);
		bool GetFloatParameterValues(string parameterName, out float[] values);
		bool SetColorParameterValue(string parameterName, UnityEngine.Color value, bool bRecookAsset = false /* Metadata: 0x0262B83A */);
		bool GetColorParameterValue(string parameterName, out UnityEngine.Color value);
		bool SetIntParameterValue(string parameterName, int value, int atIndex = 0 /* Metadata: 0x0262B83B */, bool bRecookAsset = false /* Metadata: 0x0262B83C */);
		bool GetIntParameterValue(string parameterName, out int value, int atIndex = 0 /* Metadata: 0x0262B83D */);
		bool SetIntParameterValues(string parameterName, int[] values, bool bRecookAsset = false /* Metadata: 0x0262B83E */);
		bool GetIntParameterValues(string parameterName, out int[] values);
		bool SetChoiceParameterValue(string parameterName, int value, bool bRecookAsset = false /* Metadata: 0x0262B83F */);
		bool GetChoiceParameterValue(string parameterName, out int value);
		bool SetBoolParameterValue(string parameterName, bool value, int atIndex = 0 /* Metadata: 0x0262B840 */, bool bRecookAsset = false /* Metadata: 0x0262B841 */);
		bool GetBoolParameterValue(string parameterName, out bool value, int atIndex = 0 /* Metadata: 0x0262B842 */);
		bool SetStringParameterValue(string parameterName, string value, int atIndex = 0 /* Metadata: 0x0262B843 */, bool bRecookAsset = false /* Metadata: 0x0262B844 */);
		bool GetStringParameterValue(string parameterName, out string value, int atIndex = 0 /* Metadata: 0x0262B845 */);
		bool SetStringParameterValues(string parameterName, string[] values, bool bRecookAsset = false /* Metadata: 0x0262B846 */);
		bool GetStringParameterValues(string parameterName, out string[] values);
		bool SetAssetRefParameterValue(string parameterName, GameObject value, int atIndex = 0 /* Metadata: 0x0262B847 */, bool bRecookAsset = false /* Metadata: 0x0262B848 */);
		bool GetAssetRefParameterValue(string parameterName, out GameObject value, int atIndex = 0 /* Metadata: 0x0262B849 */);
		bool SetAssetRefParameterValues(string parameterName, GameObject[] values, bool bRecookAsset = false /* Metadata: 0x0262B84A */);
		bool GetAssetRefParameterValues(string parameterName, out GameObject[] values);
		bool SetRampParameterNumPoints(string parameterName, int numPoints, bool bRecookAsset = false /* Metadata: 0x0262B84B */);
		bool GetRampParameterNumPoints(string parameterName, out int numPoints);
		bool SetFloatRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, float pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolationType = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B84C */, bool bRecookAsset = false /* Metadata: 0x0262B84D */);
		bool GetFloatRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out float pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetFloatRampParameterPoints(string parameterName, HEU_FloatRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x0262B84E */);
		bool GetFloatRampParameterPoints(string parameterName, out HEU_FloatRampPointWrapper[] rampPoints);
		bool SetColorRampParameterPointValue(string parameterName, int pointIndex, float pointPosition, UnityEngine.Color pointValue, HEU_HoudiniRampInterpolationTypeWrapper interpolation = HEU_HoudiniRampInterpolationTypeWrapper.LINEAR /* Metadata: 0x0262B84F */, bool bRecookAsset = false /* Metadata: 0x0262B850 */);
		bool GetColorRampParameterPointValue(string parameterName, int pointIndex, out float pointPosition, out UnityEngine.Color pointValue, out HEU_HoudiniRampInterpolationTypeWrapper interpolationType);
		bool SetColorRampParameterPoints(string parameterName, HEU_ColorRampPointWrapper[] rampPoints, bool bRecookAsset = false /* Metadata: 0x0262B851 */);
		bool GetColorRampParameterPoints(string parameterName, out HEU_ColorRampPointWrapper[] rampPoints);
		bool TriggerButtonParameter(string parameterName);
		bool SetParameterTuples(Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples, bool bRecookAsset = false /* Metadata: 0x0262B852 */);
		bool GetParameterTuples(out Dictionary<string, HEU_ParameterTupleWrapper> parameterTuples);
	}

	public interface IHEU_PartData // TypeDefIndex: 78380
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
		void DestroyAllData(bool bIsRebuild = false /* Metadata: 0x0262B853 */);
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

	public enum HEU_LinkStateWrapper // TypeDefIndex: 78381
	{
		INACTIVE = 0,
		LINKING = 1,
		LINKED = 2,
		ERROR_NOT_LINKED = 3
	}

	public interface IHEU_PDGAssetLink // TypeDefIndex: 78382
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

	public interface IHEU_VolumeCache // TypeDefIndex: 78383
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

	public class HEU_MaterialData : ScriptableObject, IHEU_MaterialData, IEquivable<HEU_MaterialData> // TypeDefIndex: 78385
	{
		// Fields
		[SerializeField]
		internal Material _material; // 0x18
		[SerializeField]
		internal Source _materialSource; // 0x20
		[SerializeField]
		internal int _materialKey; // 0x24
	
		// Properties
		public Material Material { get; } // 0x0000000182234E30-0x0000000182234E40 
		public HEU_MaterialSourceWrapper MaterialSource { get; } // 0x000000018C1D1C60-0x000000018C1D1C8C 
		public int MaterialKey { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
	
		// Nested types
		internal enum Source // TypeDefIndex: 78384
		{
			DEFAULT = 0,
			HOUDINI = 1,
			UNITY = 2,
			SUBSTANCE = 3
		}
	
		// Constructors
		public HEU_MaterialData(); // 0x000000018C1D1C50-0x000000018C1D1C60
	
		// Methods
		public bool UpdateMaterialFromHoudini(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath); // 0x000000018C1D1268-0x000000018C1D1570
		public bool IsExistingMaterial(); // 0x000000018C1D1210-0x000000018C1D1224
		private bool UseLegacyShaders(HAPI_MaterialInfo materialInfo, string assetCacheFolderPath, HEU_SessionBase session, HAPI_NodeInfo nodeInfo, HAPI_ParmInfo[] parmInfos); // 0x000000018C1D1570-0x000000018C1D1C50
		internal static string GetTextureFileNameFromMaterialParam(HEU_SessionBase session, int nodeID, HAPI_ParmInfo parmInfo); // 0x000000018C1D0F6C-0x000000018C1D1070
		internal static bool IsTransparentMaterial(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters); // 0x000000018C1D1224-0x000000018C1D1268
		internal static bool GetMaterialAlpha(HEU_SessionBase session, int nodeID, HAPI_ParmInfo[] parameters, float defaultValue, out float alpha); // 0x000000018C1D0CEC-0x000000018C1D0E6C
		internal static string GetSupportedFileFormat(HEU_SessionBase session, ref HAPI_ImageInfo imageInfo); // 0x000000018C1D0E6C-0x000000018C1D0F6C
		public bool IsEquivalentTo(HEU_MaterialData other); // 0x000000018C1D1070-0x000000018C1D1210
		internal static Source MaterialSource_WrapperToInternal(HEU_MaterialSourceWrapper materialSource); // 0x000000018C18A0A4-0x000000018C18A0CC
		internal static HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(Source materialSource); // 0x000000018C18A0A4-0x000000018C18A0CC
	}

	public class HEU_MaterialFactory // TypeDefIndex: 78386
	{
		// Fields
		public static Material _defaultStandardMaterial; // 0x00
	
		// Constructors
		public HEU_MaterialFactory(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static Shader FindShader(string shaderName); // 0x000000018C1D24FC-0x000000018C1D2534
		public static Shader FindPluginShader(string shaderName); // 0x000000018C1D24C4-0x000000018C1D24FC
		public static Material GetNewMaterialWithShader(string assetCacheFolderPath, string shaderName, string materialName = "" /* Metadata: 0x0262B85C */, bool bWriteToFile = true /* Metadata: 0x0262B85D */); // 0x000000018C1D296C-0x000000018C1D2B3C
		public static Material CreateNewHoudiniStandardMaterial(string assetCacheFolderPath, string materialName, bool bWriteToFile); // 0x000000018C1D1FD4-0x000000018C1D2020
		public static void WriteMaterialToAssetCache(Material material, string assetCacheFolderPath, string materialName, bool bOverwriteExisting); // 0x000000018C1D3540-0x000000018C1D361C
		public static bool DoesMaterialExistInAssetCache(Material material); // 0x000000018C1D2338-0x000000018C1D235C
		public static void DestroyNonAssetMaterial(Material material, bool bRegisterUndo); // 0x000000018C1D22C4-0x000000018C1D2338
		public static void DeleteAssetMaterial(Material material); // 0x000000018C1D22BC-0x000000018C1D22C4
		public static Texture2D RenderAndExtractImageToTexture(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, int textureParmID, string textureName, string assetCacheFolderPath, bool isNormalMap, bool invertTexture = false /* Metadata: 0x0262B85E */); // 0x000000018C1D3478-0x000000018C1D3538
		private static Texture2D ExtractHoudiniImageToTexturePNGJPEG(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes); // 0x000000018C1D2400-0x000000018C1D245C
		private static Texture2D ExtractHoudiniImageToTextureRaw(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes); // 0x000000018C1D245C-0x000000018C1D24C4
		public static Texture2D ExtractHoudiniImageToTextureFile(HEU_SessionBase session, HAPI_MaterialInfo materialInfo, string imagePlanes, string assetCacheFolderPath); // 0x000000018C1D237C-0x000000018C1D2400
		public static Material LoadUnityMaterial(string materialPath); // 0x000000018C1D3168-0x000000018C1D345C
		public static Material LoadSubstanceMaterialWithName(string materialPath, string substanceName); // 0x000000018C1D2ED4-0x000000018C1D3060
		public static Material LoadSubstanceMaterialWithIndex(string materialPath, int substanceMaterialIndex); // 0x000000018C1D2D0C-0x000000018C1D2ED4
		public static int GetUnitySubstanceMaterialKey(string unityMaterialPath, string substanceName, int substanceIndex); // 0x000000018C1D2C10-0x000000018C1D2D0C
		public static int MaterialNameToKey(string materialName); // 0x0000000187888618-0x0000000187888638
		public static void EnableGPUInstancing(Material material); // 0x000000018C1D235C-0x000000018C1D237C
		public static bool MaterialHasGPUInstancingEnabled(Material material); // 0x000000018C1D345C-0x000000018C1D3478
		public static Material CopyMaterial(Material material); // 0x000000018C1D1C8C-0x000000018C1D1CEC
		public static Material GetDefaultStandardMaterial(); // 0x000000018C1D25D0-0x000000018C1D2684
		public static Texture2D LoadTexture(string path); // 0x000000018C1D3060-0x000000018C1D3168
		public static Texture2D WhiteTexture(); // 0x000000018C1D3538-0x000000018C1D3540
		public static HEU_MaterialData CreateUnitySubstanceMaterialData(int materialKey, string materialPath, string substanceName, int substanceIndex, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x000000018C1D2020-0x000000018C1D22BC
		public static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialSourceWrapper sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x000000018C1D1E7C-0x000000018C1D1EC8
		internal static HEU_MaterialData CreateMaterialInCache(int materialKey, string materialName, HEU_MaterialData.Source sourceType, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x000000018C1D1EC8-0x000000018C1D1FD4
		public static HEU_MaterialData GetOrCreateDefaultMaterialInCache(HEU_SessionBase session, int geoID, int partID, bool bWriteToFile, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x000000018C1D2B3C-0x000000018C1D2C10
		public static HEU_MaterialData GetMaterialDataFromCache(int materialKey, List<HEU_MaterialData> materialCache); // 0x000000018C1D2684-0x000000018C1D27A0
		public static string GenerateDefaultMaterialName(int geoID, int partID); // 0x000000018C1D2534-0x000000018C1D25D0
		public static HEU_MaterialData CreateHoudiniMaterialData(HEU_SessionBase session, int assetID, int materialID, int geoID, int partID, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x000000018C1D1CEC-0x000000018C1D1E7C
		public static Dictionary<int, HEU_MaterialData> GetMaterialDataMapFromCache(List<HEU_MaterialData> materialCache); // 0x000000018C1D27A0-0x000000018C1D296C
	}

	public class HEU_UnityMaterialInfo // TypeDefIndex: 78387
	{
		// Fields
		public string _unityMaterialPath; // 0x10
		public string _substancePath; // 0x18
		public int _substanceIndex; // 0x20
	
		// Constructors
		public HEU_UnityMaterialInfo(string unityMaterialPath, string substancePath, int substanceIndex); // 0x000000018C19BD00-0x000000018C19BD30
	}

	public class HEU_SessionBase // TypeDefIndex: 78388
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
		public bool UserNotifiedSessionInvalid { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public SessionConnectionState ConnectionState { get; set; } // 0x000000018C1D8624-0x000000018C1D8638 0x000000018C1D864C-0x000000018C1D865C
		public SessionMode ThisSessionMode { get; set; } // 0x000000018C1D8638-0x000000018C1D864C 0x000000018C1D865C-0x000000018C1D866C
		public bool LogErrorOverride { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool ThrowErrorOverride { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		public HAPI_Result LastCallResultCode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
	
		// Constructors
		public HEU_SessionBase(); // 0x0000000187250800-0x0000000187250810
	
		// Methods
		public string GetSessionErrorMsg(); // 0x000000018225E800-0x000000018225E810
		public bool IsSessionSync(); // 0x000000018C1D8354-0x000000018C1D836C
		public virtual HEU_HoudiniAsset GetRegisteredAssetFromID(int id); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual bool IsAssetRegistered(HEU_HoudiniAsset asset); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void RegisterAsset(HEU_HoudiniAsset asset); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void UnregisterAsset(int id); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ReregisterOnAwake(HEU_HoudiniAsset asset); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void SetSessionErrorMsg(string msg, bool bLogError = false /* Metadata: 0x0262B85F */); // 0x000000018C1D85B4-0x000000018C1D85EC
		public virtual void SetSessionConnectionErrorMsg(string introMsg, HAPI_Result result, bool bIsHARSRunning, bool bLogError = false /* Metadata: 0x0262B860 */); // 0x000000018C1D83F8-0x000000018C1D85B4
		public virtual void SetLibraryErrorMsg(bool bLogError = false /* Metadata: 0x0262B861 */); // 0x000000018C1D836C-0x000000018C1D83F8
		protected virtual bool CreateSessionData(bool bOverwriteExisting, bool bIsDefaultSession); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CreateInProcessSession(bool bIsDefaultSession); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CreateThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x0262B862 */, int serverPort = 9090 /* Metadata: 0x0262B86C */, bool autoClose = true /* Metadata: 0x0262B870 */, float timeout = 100000f /* Metadata: 0x0262B871 */, bool bLogError = true /* Metadata: 0x0262B875 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CreateThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x0262B876 */, bool autoClose = true /* Metadata: 0x0262B87B */, float timeout = 100000f /* Metadata: 0x0262B87C */, bool bLogError = true /* Metadata: 0x0262B880 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CreateThriftSharedMemorySession(bool bIsDefaultSession, string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER /* Metadata: 0x0262B881 */, int sharedMemoryBufferSize = 100 /* Metadata: 0x0262B882 */, bool autoClose = true /* Metadata: 0x0262B884 */, float timeout = 100000f /* Metadata: 0x0262B885 */, bool bLogError = true /* Metadata: 0x0262B889 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CreateCustomSession(bool bIsDefaultSession); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ConnectThriftSocketSession(bool bIsDefaultSession, string hostName = "localhost" /* Metadata: 0x0262B88A */, int serverPort = 9090 /* Metadata: 0x0262B894 */, bool autoClose = true /* Metadata: 0x0262B898 */, float timeout = 100000f /* Metadata: 0x0262B899 */, bool logError = true /* Metadata: 0x0262B89D */, bool autoInitialize = true /* Metadata: 0x0262B89E */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ConnectThriftPipeSession(bool bIsDefaultSession, string pipeName = "hapi" /* Metadata: 0x0262B89F */, bool autoClose = true /* Metadata: 0x0262B8A4 */, float timeout = 100000f /* Metadata: 0x0262B8A5 */, bool logError = true /* Metadata: 0x0262B8A9 */, bool autoInitialize = true /* Metadata: 0x0262B8AA */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ConnectThriftSharedMemorySession(bool bIsDefaultSession, string sharedMemoryName = "hapi" /* Metadata: 0x0262B8AB */, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType = HAPI_ThriftSharedMemoryBufferType.HAPI_THRIFT_SHARED_MEMORY_RING_BUFFER /* Metadata: 0x0262B8B0 */, int sharedMemoryBufferSize = 100 /* Metadata: 0x0262B8B1 */, bool autoClose = true /* Metadata: 0x0262B8B3 */, float timeout = 100000f /* Metadata: 0x0262B8B4 */, bool logError = true /* Metadata: 0x0262B8B8 */, bool autoInitialize = true /* Metadata: 0x0262B8B9 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CloseSession(); // 0x00000001843FFFF0-0x0000000184400000
		protected virtual bool CheckAndCloseExistingSession(); // 0x00000001843FFFF0-0x0000000184400000
		protected virtual void ClearSessionInfo(); // 0x000000018C1D818C-0x000000018C1D81D4
		public void SetSessionData(HEU_SessionData sessionData); // 0x0000000184FD2410-0x0000000184FD2420
		public HEU_SessionData GetSessionData(); // 0x00000001829260F0-0x0000000182926100
		public virtual string GetSessionInfo(); // 0x000000018C1D82FC-0x000000018C1D8328
		public virtual bool IsSessionValid(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RestartSession(); // 0x00000001843FFFF0-0x0000000184400000
		public string GetLastSessionError(); // 0x000000018225E800-0x000000018225E810
		public virtual bool CheckVersionMatch(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool InitializeSession(HEU_SessionData sessionData); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool HandleStatusResult(HAPI_Result result, string prependMsg, bool bThrowError, bool bLogError); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void SetServerEnvString(string name, string value); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool GetServerEnvString(string name, out string value); // 0x000000018C1D82E0-0x000000018C1D82FC
		public virtual bool GetServerEnvVarCount(out int env_count); // 0x0000000187250760-0x0000000187250770
		public virtual bool GetCallResult(out HAPI_Result result); // 0x0000000187250760-0x0000000187250770
		public virtual bool GetCookResult(out HAPI_Result result); // 0x0000000187250760-0x0000000187250770
		public virtual bool GetCookState(out HAPI_State state); // 0x0000000187250760-0x0000000187250770
		public virtual string GetStatusString(HAPI_StatusType statusType, HAPI_StatusVerbosity verbosity); // 0x000000018C1D8328-0x000000018C1D8354
		public virtual string ComposeNodeCookResult(int nodeId, HAPI_StatusVerbosity verbosity); // 0x000000018C1D81D4-0x000000018C1D8200
		public virtual int GetEnvInt(HAPI_EnvIntType intType); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual int GetSessionEnvInt(HAPI_SessionEnvIntType intType, bool bLogError); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual bool GetString(int stringHandle, ref string resultString, int bufferLength); // 0x00000001843FFFF0-0x0000000184400000
		public virtual int GetStringBufferLength(int stringHandle); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual int CheckForSpecificErrors(int nodeID, int errorsToCheck); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual double GetTime(); // 0x0000000187234CD0-0x0000000187234CE0
		public virtual bool SetTime(double time); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetUseHoudiniTime(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetUseHoudiniTime(bool enable); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool LoadAssetLibraryFromFile(string assetPath, bool bAllowOverwrite, out int libraryID); // 0x0000000187250770-0x0000000187250780
		public virtual bool LoadAssetLibraryFromMemory(byte[] buffer, bool bAllowOverwrite, out int libraryID); // 0x0000000187250770-0x0000000187250780
		public virtual bool CreateNode(int parentNodeID, string operatorName, string nodeLabel, bool bCookOnCreation, out int newNodeID); // 0x0000000187250750-0x0000000187250760
		public virtual void DeleteNode(int nodeID); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool CookNode(int nodeID, bool bCookTemplatedGeos, bool bSplitGeosByGroup = false /* Metadata: 0x0262B8BA */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CookNodeWithOptions(int nodeID, HAPI_CookOptions cookOptions); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RenameNode(int nodeID, string newName); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ConnectNodeInput(int nodeID, int inputIndex, int nodeIDToConnect, int outputIndex = 0 /* Metadata: 0x0262B8BB */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool DisconnectNodeInput(int nodeID, int inputIndex, bool bLogError); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool QueryNodeInput(int nodeID, int inputIndex, out int connectedNodeID, bool bLogError); // 0x00000001872507A0-0x00000001872507B0
		public virtual bool GetNodeInputName(int nodeID, int inputIndex, out int nodeNameIndex); // 0x0000000187250770-0x0000000187250780
		public virtual bool GetAvailableAssetCount(int libraryID, out int assetCount); // 0x00000001872506D0-0x00000001872506E0
		public virtual bool GetAvailableAssets(int libraryID, ref int[] assetNames, int assetCount); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAssetInfo(int nodeID, ref HAPI_AssetInfo assetInfo, bool bLogError = true /* Metadata: 0x0262B8BC */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetNodeInfo(int nodeID, ref HAPI_NodeInfo nodeInfo, bool bLogError = true /* Metadata: 0x0262B8BD */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetNodePath(int nodeID, int relativeNodeID, out string path); // 0x000000018A4E2DE8-0x000000018A4E2E04
		public virtual bool IsNodeValid(int nodeID, int uniqueNodeID); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ComposeChildNodeList(int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, ref int count, bool bLogError = true /* Metadata: 0x0262B8BE */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetComposedChildNodeList(int parentNodeID, int[] childNodeIDs, int count, bool bLogError = true /* Metadata: 0x0262B8BF */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool LoadHIPFile(string fileName, bool bCookOnLoad); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SaveHIPFile(string fileName, bool bLockNodes); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetObjectInfo(int nodeID, ref HAPI_ObjectInfo objectInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetObjectTransform(int nodeID, int relativeToNodeID, HAPI_RSTOrder rstOrder, ref HAPI_Transform hapiTransform); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetObjectTransform(int nodeID, ref HAPI_TransformEuler hapiTransform); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ComposeObjectList(int nodeID, out int objectCount); // 0x00000001872506D0-0x00000001872506E0
		public virtual bool GetComposedObjectList(int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetComposedObjectTransforms(int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetDisplayGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = false /* Metadata: 0x0262B8C0 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetOutputGeoCount(int nodeID, out int count, bool bLogError = false /* Metadata: 0x0262B8C1 */); // 0x00000001872506D0-0x00000001872506E0
		public virtual bool GetOutputGeoInfos(int nodeID, ref HAPI_GeoInfo[] geoInfosArray, int count, bool bLogError = false /* Metadata: 0x0262B8C2 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetGeoInfo(int nodeID, ref HAPI_GeoInfo geoInfo, bool bLogError = true /* Metadata: 0x0262B8C3 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeInfo(int nodeID, int partID, string name, HAPI_AttributeOwner owner, ref HAPI_AttributeInfo attributeInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeNames(int nodeID, int partID, HAPI_AttributeOwner owner, ref string[] attributeNames, int count); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] dataArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out float[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, ref float[] data, int dataLength, ref int[] sizesArray, int start, int sizesLength); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeFloat64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out double[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out int[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeUInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out byte[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out sbyte[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out short[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attributeInfo, out long[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetGroupNames(int nodeID, HAPI_GroupType groupType, ref int[] names, int count); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetGroupCountOnPackedInstancePart(int nodeID, int partID, out int pointGroupCount, out int primitiveGroupCount); // 0x0000000187250780-0x0000000187250790
		public virtual bool GetGroupNamesOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, ref int[] groupNamesArray, int groupCount); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetGroupMembershipOnPackedInstancePart(int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref bool membershipArrayAllEqual, out int[] membershipArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetInstancedPartIds(int nodeID, int partID, out int[] instancedPartsArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetInstancerPartTransforms(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetInstanceTransformsOnPart(int nodeID, int partID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transformsArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetInstancedObjectIds(int nodeID, out int[] instanced_node_id_array, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetFaceCounts(int nodeID, int partID, out int[] faceCounts, int start, int length, bool bLogError); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetVertexList(int nodeID, int partID, out int[] vertexList, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetBoxInfo(int nodeID, int partID, ref HAPI_BoxInfo boxInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetSphereInfo(int nodeID, int partID, ref HAPI_SphereInfo sphereInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetCurveCounts(int nodeID, int partID, out int[] counts, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetCurveOrders(int nodeID, int partID, out int[] orders, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetCurveKnots(int nodeID, int partID, out float[] knots, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo inputCurveInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetPartInfo(int nodeID, int partID, ref HAPI_PartInfo partInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetFaceCount(int nodeID, int partID, int[] faceCounts, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetVertexList(int nodeID, int partID, int[] vertexList, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeIntData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, int[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeInt8Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, sbyte[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeInt16Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, short[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeInt64Data(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, long[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeFloatData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeFloatArrayData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, float[] data, int dataLength, int[] sizesArray, int start, int sizesLength); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetAttributeStringData(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo, string[] data, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool AddAttribute(int nodeID, int partID, string name, ref HAPI_AttributeInfo attrInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool AddGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool DeleteGroup(int nodeID, int partID, HAPI_GroupType groupType, string groupName); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetGroupMembership(int nodeID, int partID, HAPI_GroupType groupType, string groupName, out int[] membershipArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool CommitGeo(int nodeID); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RevertGeo(int nodeID); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetCurveInfo(int nodeID, int partID, ref HAPI_CurveInfo curveInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetCurveCounts(int nodeID, int partID, int[] counts, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetCurveOrders(int nodeID, int partID, int[] orders, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetCurveKnots(int nodeID, int partID, float[] knots, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetInputCurveInfo(int nodeID, int partID, ref HAPI_InputCurveInfo curveInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetInputCurvePositions(int nodeID, int partID, float[] positionsArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetInputCurvePositionsRotationsScales(int nodeID, int partID, float[] positionsArray, int start, int length, float[] rotationsArray, int rotationsStart, int rotationsLength, float[] scalesArray, int scalesStart, int scalesLength); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetMaterialOnPart(int nodeID, int partID, ref HAPI_MaterialInfo materialInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetMaterialNodeIDsOnFaces(int nodeID, int partID, ref bool bSingleFaceMaterial, out int[] materialNodeIDs, int faceCount); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetMaterialInfo(int materialNodeID, ref HAPI_MaterialInfo materialInfo, bool bLogError = true /* Metadata: 0x0262B8C4 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetImageInfo(int materialNodeID, ref HAPI_ImageInfo imageInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RenderTextureToImage(int materialNodeID, int parmID, bool bLogError = true /* Metadata: 0x0262B8C5 */); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RenderCOPToImage(int copNodeID); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ExtractImageToMemory(int nodeID, string fileFormat, string imagePlanes, out byte[] buffer); // 0x000000018C1D821C-0x000000018C1D8260
		public virtual bool GetImagePlanes(int nodeID, out int[] imagePlanes, int numImagePlanes); // 0x000000018C1D8260-0x000000018C1D8298
		public virtual bool ExtractImageToFile(int nodeID, string fileFormat, string imagePlanes, string destinationFolderPath, out string destinationFilePath); // 0x000000018C1D8200-0x000000018C1D821C
		public virtual bool GetParams(int nodeID, out HAPI_ParmInfo[] parmInfos, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParmTagName(int nodeID, int parmID, int tagIndex, out int tagName); // 0x0000000187250790-0x00000001872507A0
		public virtual bool GetParmTagValue(int nodeID, int parmID, string tagName, out int tagValue); // 0x0000000187250790-0x00000001872507A0
		public virtual bool ParmHasTag(int nodeID, int parmID, string tagName, ref bool hasTag); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParamIntValues(int nodeID, out int[] values, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParamIntValue(int nodeID, string parmName, int index, out int value); // 0x0000000187250790-0x00000001872507A0
		public virtual bool GetParamFloatValues(int nodeID, out float[] values, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParamFloatValue(int nodeID, string parmName, int index, out float value); // 0x0000000187250790-0x00000001872507A0
		public virtual bool GetParamStringValues(int nodeID, out int[] values, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParamStringValue(int nodeID, string parmName, int index, out int value); // 0x0000000187250790-0x00000001872507A0
		public virtual bool GetParamNodeValue(int nodeID, string paramName, out int nodeValue); // 0x00000001872507A0-0x00000001872507B0
		public virtual bool GetParamChoiceValues(int nodeID, out HAPI_ParmChoiceInfo[] values, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamIntValues(int nodeID, ref int[] values, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamIntValue(int nodeID, string paramName, int index, int value); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamFloatValues(int nodeID, ref float[] values, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamFloatValue(int nodeID, string paramName, int index, float value); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamStringValue(int nodeID, string strValue, int parmID, int index); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamStringValue(int nodeID, string parmName, string parmValue, int index); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetParamNodeValue(int nodeID, string paramName, int nodeValueID); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool InsertMultiparmInstance(int nodeID, int parmID, int instancePosition); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RemoveMultiParmInstance(int nodeID, int parmID, int instancePosition); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParmWithTag(int nodeID, string tagName, ref int parmID); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RevertParmToDefault(int nodeID, string parm_name, int index); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RevertParmToDefaults(int nodeID, string parm_name); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetParmIDFromName(int nodeID, string parmName, out int parmID); // 0x00000001872507A0-0x00000001872507B0
		public virtual bool GetParmStringValue(int nodeID, string parmName, int index, bool evaluate, out int value); // 0x00000001872507B0-0x00000001872507C0
		public virtual bool CreateInputNode(out int nodeID, string name); // 0x0000000187250740-0x0000000187250750
		public virtual bool CreateInputCurveNode(out int nodeID, string name); // 0x0000000187250740-0x0000000187250750
		public virtual bool CreateHeightFieldInput(int parentNodeID, string name, int xSize, int ySize, float voxelSize, HAPI_HeightFieldSampling sampling, out int heightfieldNodeID, out int heightNodeID, out int maskNodeID, out int mergeNodeID); // 0x0000000187250700-0x0000000187250730
		public virtual bool CreateHeightfieldInputVolumeNode(int parentNodeID, out int newNodeID, string name, int xSize, int ySize, float voxelSize); // 0x0000000187250730-0x0000000187250740
		public virtual bool GetPreset(int nodeID, out byte[] presetData); // 0x000000018C1D8298-0x000000018C1D82E0
		public virtual bool SetPreset(int nodeID, byte[] presetData); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetHeightFieldData(int nodeID, int partID, float[] valuesArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetVolumeInfo(int nodeID, int partID, ref HAPI_VolumeInfo volumeInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetVolumeTileFloatData(int nodeID, int partID, ref HAPI_VolumeTileInfo tileInfo, float[] valuesArray, int length); // 0x000000018C1D85EC-0x000000018C1D8624
		public virtual bool GetVolumeBounds(int nodeID, int partID, out float x_min, out float y_min, out float z_min, out float x_max, out float y_max, out float z_max, out float x_center, out float y_center, out float z_center); // 0x00000001872507C0-0x0000000187250800
		public virtual bool SetHeightFieldData(int nodeID, int partID, string name, float[] valuesArray, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetActiveCacheCount(out int activeCacheCount); // 0x0000000187250760-0x0000000187250770
		public virtual bool GetActiveCacheNames(out int[] cacheNamesArray, int activeCacheCount); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, out int propertyValue); // 0x0000000187250770-0x0000000187250780
		public virtual bool SetCacheProperty(string cacheName, HAPI_CacheProperty cacheProperty, int propertyValue); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SaveGeoToFile(int nodeID, string fileName); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool LoadGeoFromFile(int nodeID, string file_name); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SaveNodeToFile(int nodeID, string fileName); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool LoadNodeFromFile(string file_name, int parentNodeID, string nodeLabel, bool cook_on_load, out int newNodeID); // 0x0000000187250750-0x0000000187250760
		public virtual bool GetGeoSize(int nodeID, string format, out int size); // 0x0000000187250770-0x0000000187250780
		public virtual bool GetHandleInfo(int nodeID, out HAPI_HandleInfo[] handleInfos, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetHandleBindingInfo(int nodeID, int handleIndex, out HAPI_HandleBindingInfo[] handleBindingInfos, int start, int length); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ConvertTransform(ref HAPI_TransformEuler inTransform, HAPI_RSTOrder RSTOrder, HAPI_XYZOrder ROTOrder, out HAPI_TransformEuler outTransform); // 0x00000001872506E0-0x0000000187250700
		public virtual bool GetTotalCookCount(int nodeID, int nodeTypeFilter, int nodeFlagFilter, bool includeChildren, out int count); // 0x00000001872507B0-0x00000001872507C0
		public virtual bool SetSessionSync(bool enable); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetViewport(ref HAPI_Viewport viewport); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetViewport(ref HAPI_Viewport viewport); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool GetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetSessionSyncInfo(ref HAPI_SessionSyncInfo syncInfo); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool SetNodeDisplay(int node_id, int onOff); // 0x00000001843FFFF0-0x0000000184400000
	}

	[Serializable]
	public enum SessionConnectionState // TypeDefIndex: 78389
	{
		NOT_CONNECTED = 0,
		CONNECTED = 1,
		FAILED_TO_CONNECT = 2
	}

	[Serializable]
	public enum SessionMode // TypeDefIndex: 78390
	{
		Socket = 0,
		Pipe = 1,
		SharedMemory = 2
	}

	[Serializable]
	public sealed class HEU_SessionData // TypeDefIndex: 78391
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
		public long SessionID { get; set; } // 0x000000018C1D87C8-0x000000018C1D8818 0x000000018561CBD0-0x000000018561CBE0
		public int ProcessID { get; set; } // 0x0000000184E58B60-0x0000000184E58B70 0x0000000186036460-0x0000000186036470
		public HAPI_SessionType SessionType { get; set; } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000182234E90-0x0000000182234EA0
		public bool IsInitialized { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x000000018223FE90-0x000000018223FEA0
		public bool IsValidSessionID { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public string PipeName { get; set; } // 0x000000018C1D8724-0x000000018C1D8750 0x0000000185CA30F0-0x0000000185CA3100
		public int Port { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public string SharedMemoryName { get; set; } // 0x000000018C1D8818-0x000000018C1D8844 0x0000000186AB5C00-0x0000000186AB5C10
		public HAPI_ThriftSharedMemoryBufferType SharedMemoryBufferType { get; set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
		public int SharedMemoryBufferSize { get; set; } // 0x0000000182271C40-0x0000000182271C50 0x0000000182271C60-0x0000000182271C70
		public System.Type SessionClassType { get; set; } // 0x000000018C1D8750-0x000000018C1D87C8 0x000000018C1D8844-0x000000018C1D8874
		public bool IsDefaultSession { get; set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
		public bool IsSessionSync { get; } // 0x000000018C1D8718-0x000000018C1D8724 
		public SessionConnectionState ThisConnectionMode { get; set; } // 0x00000001872332A0-0x00000001872332B0 0x0000000185FF5E70-0x0000000185FF5F30
		public SessionMode ThisSessionMode { get; set; } // 0x0000000187233670-0x0000000187233680 0x0000000187233690-0x00000001872336A0
	
		// Constructors
		public HEU_SessionData(); // 0x00000001872407F0-0x0000000187240800
		static HEU_SessionData(); // 0x000000018C1D86DC-0x000000018C1D8718
	
		// Methods
		public HEU_SessionSyncData GetOrCreateSessionSync(); // 0x000000018C1D866C-0x000000018C1D86DC
		public HEU_SessionSyncData GetSessionSync(); // 0x0000000187232F70-0x0000000187232F80
		public void SetSessionSync(HEU_SessionSyncData syncData); // 0x00000001856B9750-0x00000001856B9760
	}

	public class HEU_SessionHAPI : HEU_SessionBase // TypeDefIndex: 78392
	{
		// Constructors
		public HEU_SessionHAPI(); // 0x0000000187250800-0x0000000187250810
	}

	public static class HEU_SessionManager // TypeDefIndex: 78394
	{
		// Fields
		private static HEU_SessionBase _defaultSession; // 0x00
		private static Dictionary<long, HEU_SessionBase> _sessionMap; // 0x08
		public static CreateSessionFromTypeDelegate _createSessionFromTypeDelegate; // 0x10
	
		// Nested types
		public delegate HEU_SessionBase CreateSessionFromTypeDelegate(System.Type type); // TypeDefIndex: 78393; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		static HEU_SessionManager(); // 0x000000018C1DAA7C-0x000000018C1DAB10
	
		// Methods
		public static HEU_SessionBase CreateSessionObject(); // 0x000000018C1D90C8-0x000000018C1D910C
		public static HEU_SessionBase CreateSessionFromType(System.Type type); // 0x000000018C1D9084-0x000000018C1D90C8
		public static HEU_SessionBase GetDefaultSession(); // 0x000000018C1D94C4-0x000000018C1D9534
		public static void RegisterSession(long sessionID, HEU_SessionBase session); // 0x000000018C1DA778-0x000000018C1DA7FC
		public static void UnregisterSession(long sessionID); // 0x000000018C1DA9BC-0x000000018C1DAA34
		public static HEU_SessionBase GetSessionWithID(long sessionID); // 0x000000018C1D9BF4-0x000000018C1D9C78
		public static void SaveAllSessionData(); // 0x000000018C1DA8A0-0x000000018C1DA948
		public static void LoadAllSessionData(); // 0x000000018C1DA048-0x000000018C1DA498
		private static void InternalValidateSceneAssets(); // 0x000000018C1D9E9C-0x000000018C1D9FCC
		public static HEU_SessionBase GetOrCreateDefaultSession(bool bNotifyUserError = true /* Metadata: 0x0262B8CC */); // 0x000000018C1D96C4-0x000000018C1D9B50
		public static bool CreateInProcessSession(); // 0x000000018C1D9004-0x000000018C1D9084
		public static bool CreateThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout, bool logError); // 0x000000018C1D920C-0x000000018C1D928C
		public static bool CreateThriftPipeSession(string pipeName, bool autoClose, float timeout, bool logError); // 0x000000018C1D910C-0x000000018C1D918C
		public static bool CreateThriftSharedMemorySession(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout, bool logError); // 0x000000018C1D918C-0x000000018C1D920C
		public static bool CreateCustomSession(); // 0x000000018C1D8F84-0x000000018C1D9004
		public static bool ConnectThriftSocketSession(string hostName, int serverPort, bool autoClose, float timeout); // 0x000000018C1D8F04-0x000000018C1D8F84
		public static bool ConnectThriftPipeSession(string pipeName, bool autoClose, float timeout); // 0x000000018C1D8E04-0x000000018C1D8E84
		public static bool ConnectThriftSharedMemorySession(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout); // 0x000000018C1D8E84-0x000000018C1D8F04
		public static void RecreateDefaultSessionData(); // 0x000000018C1DA714-0x000000018C1DA778
		public static bool ConnectSessionSyncUsingThriftSocket(string hostName, int serverPort, bool autoClose, float timeout, bool logError); // 0x000000018C1D8D88-0x000000018C1D8E04
		public static bool ConnectSessionSyncUsingThriftPipe(string pipeName, bool autoClose, float timeout, bool logError); // 0x000000018C1D8C90-0x000000018C1D8D0C
		public static bool ConnectSessionSyncUsingThriftSharedMemory(string sharedMemoryName, HAPI_ThriftSharedMemoryBufferType sharedMemoryBufferType, int sharedMemoryBufferSize, bool autoClose, float timeout, bool logError); // 0x000000018C1D8D0C-0x000000018C1D8D88
		public static bool InitializeDefaultSession(); // 0x000000018C1D9E34-0x000000018C1D9E9C
		public static bool CloseDefaultSession(); // 0x000000018C1D8BF0-0x000000018C1D8C90
		public static void CloseAllSessions(); // 0x000000018C1D8948-0x000000018C1D8BF0
		private static void CheckAndCloseExistingSession(); // 0x000000018C1D8874-0x000000018C1D890C
		public static HEU_SessionData GetSessionData(); // 0x000000018C1D9B50-0x000000018C1D9B94
		public static string GetSessionInfo(); // 0x000000018C1D9B94-0x000000018C1D9BF4
		public static bool LoadStoredDefaultSession(); // 0x000000018C1DA50C-0x000000018C1DA57C
		public static bool RestartSession(); // 0x000000018C1DA7FC-0x000000018C1DA8A0
		public static bool ValidatePluginSession(HEU_SessionBase session = null); // 0x000000018C1DAA34-0x000000018C1DAA7C
		public static string GetLastSessionError(); // 0x000000018C1D95AC-0x000000018C1D9604
		public static bool CheckVersionMatch(); // 0x000000018C1D890C-0x000000018C1D8948
		public static bool ClearConnectionError(); // 0x00000001851A4410-0x00000001851A4420
		public static string GetConnectionError(bool clear); // 0x000000018C1D9454-0x000000018C1D9480
		public static bool IsHARSProcessRunning(int processID); // 0x000000018C1D9FCC-0x000000018C1DA048
		public static bool LoadSessionFromHIP(bool bCookNodes, HEU_SessionBase session = null); // 0x000000018C1DA498-0x000000018C1DA50C
		public static bool SaveSessionToHIP(bool bLockNodes, HEU_SessionBase session = null); // 0x000000018C1DA948-0x000000018C1DA9BC
		public static string GetHoudiniPathOnMacOS(string houdiniPath); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static bool OpenHoudini(string args); // 0x000000018C1DA57C-0x000000018C1DA630
		public static bool OpenSessionInHoudini(HEU_SessionBase session = null); // 0x000000018C1DA630-0x000000018C1DA714
		public static HAPI_License GetCurrentLicense(bool bLogError); // 0x000000018C1D9480-0x000000018C1D94C4
		public static string GetString(int stringHandle, HEU_SessionBase session = null); // 0x000000018C1D9D64-0x000000018C1D9DCC
		public static string[] GetStringValuesFromStringIndices(int[] strIndices); // 0x000000018C1D9C78-0x000000018C1D9D64
		public static string[] GetGroupNames(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, bool isInstanced); // 0x000000018C1D956C-0x000000018C1D95AC
		public static bool GetGroupMembership(HEU_SessionBase session, int nodeID, int partID, HAPI_GroupType groupType, string groupName, ref int[] membership, bool isInstanced); // 0x000000018C1D9534-0x000000018C1D956C
		public static string GetNodeName(int nodeID, HEU_SessionBase session = null); // 0x000000018C1D9664-0x000000018C1D96C4
		public static bool GetNodeInputName(int nodeID, int inputIndex, out string inputName); // 0x000000018C1D9604-0x000000018C1D9664
		public static bool GetComposedChildNodeList(HEU_SessionBase session, int parentNodeID, int nodeTypeFilter, int nodeFlagFilter, bool bRecursive, out int[] childNodeIDs, bool bLogIfError = true /* Metadata: 0x0262B8CD */); // 0x000000018C1D928C-0x000000018C1D92D8
		public static bool GetComposedObjectListMemorySafe(HEU_SessionBase session, int nodeID, out HAPI_ObjectInfo[] objectInfos, int start, int length); // 0x000000018C1D92D8-0x000000018C1D9394
		public static bool GetComposedObjectTransformsMemorySafe(HEU_SessionBase session, int nodeID, HAPI_RSTOrder rstOrder, out HAPI_Transform[] transforms, int start, int length); // 0x000000018C1D9394-0x000000018C1D9454
		public static string GetUniqueMaterialShopName(int assetID, int materialID); // 0x000000018C1D9DCC-0x000000018C1D9E34
	}

	public static class HEU_SessionPDG // TypeDefIndex: 78395
	{
	}

	[Serializable]
	public class HEU_SessionSyncData // TypeDefIndex: 78397
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
		public Status SyncStatus { get; set; } // 0x000000018C1DABC8-0x000000018C1DABD8 0x0000000187250810-0x0000000187250820
	
		// Nested types
		public enum Status // TypeDefIndex: 78396
		{
			Stopped = 0,
			Started = 1,
			Connecting = 2,
			Initializing = 3,
			Connected = 4
		}
	
		// Constructors
		public HEU_SessionSyncData(); // 0x000000018C1DAB10-0x000000018C1DABC8
	}

	public class HEU_AssetSync : HEU_BaseSync // TypeDefIndex: 78399
	{
		// Fields
		public AssetSyncCallback _onAssetLoaded; // 0x88
		public string _assetPath; // 0x90
	
		// Nested types
		public delegate void AssetSyncCallback(HEU_AssetSync assetSync); // TypeDefIndex: 78398; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public HEU_AssetSync(); // 0x000000018C1CC3B0-0x000000018C1CC3B8
	
		// Methods
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		private new void OnDestroy(); // 0x000000018C1CC270-0x000000018C1CC278
		public void InitializeAsset(HEU_SessionBase session, string assetPath, string nodeName, Transform parent, Vector3 startPosition); // 0x000000018C1CC198-0x000000018C1CC270
		private HEU_ThreadedTaskLoadGeo CreateThreadedTask(); // 0x000000018C1CC13C-0x000000018C1CC198
		public void SetLoadCallback(HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback); // 0x000000018C1CC2E4-0x000000018C1CC338
		protected override void SetupLoadTask(HEU_SessionBase session); // 0x000000018C1CC338-0x000000018C1CC3B0
		public override void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x000000018C1CC278-0x000000018C1CC2B8
		public override void Resync(); // 0x000000018C1CC2B8-0x000000018C1CC2E4
	}

	public class HEU_SyncedEventData // TypeDefIndex: 78400
	{
		// Fields
		public bool CookSuccess; // 0x10
		public HEU_ThreadedTaskLoadGeo.HEU_LoadData TopNodeData; // 0x18
		public HEU_BaseSync OutputObject; // 0x20
	
		// Constructors
		public HEU_SyncedEventData(bool bSuccess, HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HEU_BaseSync bOutputObject); // 0x000000018C1DABD8-0x000000018C1DAC00
	}

	[ExecuteInEditMode]
	public class HEU_BaseSync : MonoBehaviour // TypeDefIndex: 78401
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
		public Action<HEU_SyncedEventData> OnSynced { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
	
		// Constructors
		public HEU_BaseSync(); // 0x000000018C1D0A58-0x000000018C1D0BE4
	
		// Methods
		private void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x000000018C1CC270-0x000000018C1CC278
		public virtual void DeleteSessionData(); // 0x000000018C1CD2A0-0x000000018C1CD2C8
		public virtual void DestroyGeneratedData(); // 0x000000018C1CD2C8-0x000000018C1CD2D0
		protected virtual void Initialize(); // 0x0000000187250650-0x0000000187250660
		public virtual HEU_SessionBase GetHoudiniSession(bool bCreateIfNotFound); // 0x000000018C1D024C-0x000000018C1D02F4
		private int GetParentNodeID(HEU_SessionBase session); // 0x000000018C1D0350-0x000000018C1D036C
		public void Log(string msg); // 0x000000018C1D0380-0x000000018C1D043C
		public void ClearLog(); // 0x000000018C1CCFF0-0x000000018C1CD118
		public void Error(string error); // 0x000000018C1CD514-0x000000018C1CD534
		public bool IsLoaded(); // 0x000000018C1D036C-0x000000018C1D0380
		public virtual void StartSync(); // 0x000000018C1D08BC-0x000000018C1D0988
		protected virtual void SetupLoadTask(HEU_SessionBase session); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void StopSync(); // 0x000000018C1D0988-0x000000018C1D09E4
		public virtual void Resync(); // 0x000000018C1D06B0-0x000000018C1D06DC
		public virtual void Bake(); // 0x000000018C1CCCB4-0x000000018C1CCFF0
		public virtual void Unload(); // 0x000000018C1D09E4-0x000000018C1D0A58
		public virtual void Reset(); // 0x000000018C1D0604-0x000000018C1D06B0
		public virtual void OnLoadComplete(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x000000018C1D043C-0x000000018C1D0544
		public virtual void GenerateObjects(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x000000018C1CEE30-0x000000018C1CEEB0
		public virtual void GenerateGeometry(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, int objIndex); // 0x000000018C1CD5E4-0x000000018C1CD6F0
		public void OnStopped(HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x000000018C1D0544-0x000000018C1D0604
		private void GenerateTerrain(int cookNodeId, List<HEU_LoadBufferVolume> terrainBuffers); // 0x000000018C1CEEB0-0x000000018C1D024C
		private void GenerateMesh(int cookNodeId, List<HEU_LoadBufferMesh> meshBuffers); // 0x000000018C1CE890-0x000000018C1CEE30
		private void GenerateAllInstancers(int cookNodeId, List<HEU_LoadBufferInstancer> instancerBuffers, HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData); // 0x000000018C1CD534-0x000000018C1CD5E4
		private void GenerateInstancer(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap); // 0x000000018C1CD6F0-0x000000018C1CD988
		private void GenerateInstancesFromNodeIDs(int cookNodeId, HEU_LoadBufferInstancer instancerBuffer, Dictionary<int, HEU_LoadBufferBase> idBuffersMap, Transform instanceRootTransform); // 0x000000018C1CE1C8-0x000000018C1CE890
		private void GenerateInstancesFromAssetPaths(HEU_LoadBufferInstancer instancerBuffer, Transform instanceRootTransform); // 0x000000018C1CD988-0x000000018C1CE1C8
		private void CreateNewInstanceFromObject(GameObject assetSourceGO, int instanceIndex, Transform parentTransform, ref HAPI_Transform hapiTransform, string[] instancePrefixes, string instanceName, GameObject collisionSourceGO); // 0x000000018C1CD118-0x000000018C1CD2A0
		private void ApplyAttributeModifiersOnGameObjectOutput(HEU_SessionBase session, int geoID, int partId, ref GameObject go); // 0x000000018C1CCC34-0x000000018C1CCCB4
		private void DestroyOutputs(); // 0x000000018C1CD2D0-0x000000018C1CD514
		private void SetOutputVisiblity(HEU_LoadBufferBase buffer); // 0x000000018C1D06DC-0x000000018C1D08BC
		private string GetOutputCacheDirectory(); // 0x000000018C1D02F4-0x000000018C1D0350
		public void SetOutputCacheDirectory(string directory); // 0x00000001870EAAD0-0x00000001870EAAE0
		private void AddGeneratedOutputFilePath(string path); // 0x000000018C1CCBAC-0x000000018C1CCC34
		public virtual void SyncUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public struct HEU_GenerateOptions // TypeDefIndex: 78402
	{
		// Fields
		public bool _generateUVs; // 0x00
		public bool _generateTangents; // 0x01
		public bool _generateNormals; // 0x02
		public bool _useLODGroups; // 0x03
		public bool _splitPoints; // 0x04
	}

	public class HEU_GeoSync : HEU_BaseSync // TypeDefIndex: 78403
	{
		// Fields
		public string _filePath; // 0x88
	
		// Constructors
		public HEU_GeoSync(); // 0x000000018C1D0C9C-0x000000018C1D0CEC
	
		// Methods
		protected override void SetupLoadTask(HEU_SessionBase session); // 0x000000018C1D0BE4-0x000000018C1D0C9C
	}

	public class HEU_NodeSync : HEU_BaseSync // TypeDefIndex: 78404
	{
		// Fields
		public string _nodeSaveFilePath; // 0x88
	
		// Constructors
		public HEU_NodeSync(); // 0x000000018C1CC3B0-0x000000018C1CC3B8
	
		// Methods
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		private new void OnDestroy(); // 0x000000018C1CC270-0x000000018C1CC278
		public void InitializeFromHoudini(HEU_SessionBase session, int nodeID, string nodeName, string filePath); // 0x000000018C1D36C0-0x000000018C1D3748
		protected override void SetupLoadTask(HEU_SessionBase session); // 0x000000018C1D37C4-0x000000018C1D3878
		public bool SaveNodeToFile(string filePath); // 0x000000018C1D3748-0x000000018C1D37C4
		public static void CreateNodeSync(HEU_SessionBase session, string opName, string nodeNabel); // 0x000000018C1D361C-0x000000018C1D36C0
		public override void Resync(); // 0x000000018C1CC2B8-0x000000018C1CC2E4
		public override void SyncUpdate(); // 0x000000018C1D3878-0x000000018C1D38BC
	}

	public abstract class HEU_Task // TypeDefIndex: 78408
	{
		// Fields
		public TaskStatus _status; // 0x10
		public TaskResult _result; // 0x14
		private Guid _guid; // 0x18
		public TaskCallback _taskCompletedDelegate; // 0x28
	
		// Properties
		public Guid TaskGuid { get; } // 0x00000001845C28E0-0x00000001845C28F0 
	
		// Nested types
		public enum TaskStatus // TypeDefIndex: 78405
		{
			NONE = 0,
			PENDING_START = 1,
			STARTED = 2,
			REQUIRE_UPDATE = 3,
			PENDING_COMPLETE = 4,
			COMPLETED = 5,
			UNUSED = 6
		}
	
		public enum TaskResult // TypeDefIndex: 78406
		{
			NONE = 0,
			SUCCESS = 1,
			FAILED = 2,
			KILLED = 3
		}
	
		public delegate void TaskCallback(HEU_Task task); // TypeDefIndex: 78407; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public HEU_Task(); // 0x000000018C1DB54C-0x000000018C1DB5A0
	
		// Methods
		public abstract void DoTask();
		public virtual void UpdateTask(); // 0x0000000186805BA0-0x0000000186805BB0
		public abstract void KillTask();
		public abstract void CompleteTask(TaskResult result);
	}

	public class HEU_AssetTask : HEU_Task // TypeDefIndex: 78410
	{
		// Fields
		public BuildType _buildType; // 0x30
		public HEU_HoudiniAsset _asset; // 0x38
		public string _assetPath; // 0x40
		public Vector3 _position; // 0x48
		public bool _buildResult; // 0x54
		public long _forceSessionID; // 0x58
	
		// Nested types
		public enum BuildType // TypeDefIndex: 78409
		{
			NONE = 0,
			LOAD = 1,
			COOK = 2,
			RELOAD = 3
		}
	
		// Constructors
		public HEU_AssetTask(); // 0x000000018C1CCB3C-0x000000018C1CCBAC
	
		// Methods
		public HEU_SessionBase GetTaskSession(); // 0x000000018C1CC950-0x000000018C1CC9E0
		public override void DoTask(); // 0x000000018C1CC598-0x000000018C1CC950
		public override void KillTask(); // 0x000000018C1CC9E0-0x000000018C1CCB3C
		public override void CompleteTask(TaskResult result); // 0x000000018C1CC3B8-0x000000018C1CC514
		private void CookCompletedCallback(HEU_HoudiniAsset asset, bool bSuccess, List<GameObject> outputs); // 0x000000018C1CC53C-0x000000018C1CC598
		private void CookCompletedCallback(HEU_CookedEventData cookedEventData); // 0x000000018C1CC514-0x000000018C1CC53C
		private void CookCompletedCallback(HEU_ReloadEventData reloadEventData); // 0x000000018C1CC514-0x000000018C1CC53C
	}

	public class HEU_TaskManager // TypeDefIndex: 78411
	{
		// Fields
		private static List<HEU_Task> _tasks; // 0x00
		private static List<HEU_Task> _pendingAdd; // 0x08
		private static List<HEU_Task> _pendingRemove; // 0x10
	
		// Constructors
		static HEU_TaskManager(); // 0x000000018C1DB420-0x000000018C1DB54C
		public HEU_TaskManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		public static HEU_Task GetTask(Guid taskGuid); // 0x000000018C1DAFF4-0x000000018C1DB1A4
		public static void AddTask(HEU_Task task); // 0x000000018C1DAEA4-0x000000018C1DAF9C
		public static void KillTask(HEU_Task task, bool bRemove); // 0x000000018C1DB1F8-0x000000018C1DB2B8
		public static void KillTask(Guid taskGuid, bool bRemove); // 0x000000018C1DB2B8-0x000000018C1DB334
		public static void RemoveTask(HEU_Task task); // 0x000000018C1DB334-0x000000018C1DB420
		public static void ExecuteTask(HEU_Task task); // 0x000000018C1DAFC0-0x000000018C1DAFF4
		public static void CompleteTask(HEU_Task task, HEU_Task.TaskResult result); // 0x000000018C1DAF9C-0x000000018C1DAFC0
		private static void InternalCompleteTask(HEU_Task task); // 0x000000018C1DB1A4-0x000000018C1DB1F8
	}

	public class HEU_LoadBufferBase // TypeDefIndex: 78412
	{
		// Fields
		public int _id; // 0x10
		public string _name; // 0x18
		public bool _bInstanced; // 0x20
		public bool _bInstancer; // 0x21
		public HEU_GeneratedOutput _generatedOutput; // 0x28
	
		// Constructors
		public HEU_LoadBufferBase(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void InitializeBuffer(int id, string name, bool bInstanced, bool bInstancer); // 0x000000018C1EA818-0x000000018C1EA844
	}

	public class HEU_LoadBufferMesh : HEU_LoadBufferBase // TypeDefIndex: 78413
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
		public HEU_LoadBufferMesh(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HEU_LoadBufferVolume : HEU_LoadBufferBase // TypeDefIndex: 78414
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
		public HEU_LoadBufferVolume(); // 0x000000018C1EA87C-0x000000018C1EA994
	}

	public class HEU_LoadBufferVolumeLayer // TypeDefIndex: 78415
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
		public HEU_LoadBufferVolumeLayer(); // 0x000000018C1EA844-0x000000018C1EA87C
	}

	public class HEU_LoadBufferInstancer : HEU_LoadBufferBase // TypeDefIndex: 78416
	{
		// Fields
		public HAPI_Transform[] _instanceTransforms; // 0x30
		public string[] _instancePrefixes; // 0x38
		public int[] _instanceNodeIDs; // 0x40
		public string[] _assetPaths; // 0x48
		public string[] _collisionAssetPaths; // 0x50
	
		// Constructors
		public HEU_LoadBufferInstancer(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HEU_ThreadedTask // TypeDefIndex: 78417
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
		public string TaskName { get; } // 0x00000001829600D0-0x00000001829600E0 
		public bool IsComplete { get; set; } // 0x000000018C1EF5EC-0x000000018C1EF68C 0x000000018C1EF7D0-0x000000018C1EF874
		public bool IsActive { get; set; } // 0x000000018C1EF54C-0x000000018C1EF5EC 0x000000018C1EF72C-0x000000018C1EF7D0
		public bool StopRequested { get; set; } // 0x000000018C1EF68C-0x000000018C1EF72C 0x000000018C1EF874-0x000000018C1EF918
		public System.Threading.ThreadPriority Priority { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public bool IsBackground { get; set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
	
		// Constructors
		public HEU_ThreadedTask(); // 0x000000018C1EF4F8-0x000000018C1EF54C
	
		// Methods
		public virtual void Start(); // 0x000000018C1EF310-0x000000018C1EF460
		public virtual void Stop(); // 0x000000018C1EF460-0x000000018C1EF4A0
		public virtual void Abort(); // 0x000000018C1EF21C-0x000000018C1EF24C
		public virtual void Reset(); // 0x000000018C1EF24C-0x000000018C1EF2E8
		public virtual void Update(); // 0x000000018C1EF4A0-0x000000018C1EF4F8
		protected virtual void DoWork(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnStopped(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void CleanUp(); // 0x0000000186805BA0-0x0000000186805BB0
		private void Run(); // 0x000000018C1EF2E8-0x000000018C1EF310
	}

	public class HEU_ThreadedTaskLoadGeo : HEU_ThreadedTask // TypeDefIndex: 78424
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
		public enum LoadType // TypeDefIndex: 78418
		{
			FILE = 0,
			NODE = 1,
			ASSET = 2
		}
	
		public class HEU_LoadData // TypeDefIndex: 78420
		{
			// Fields
			public int _cookNodeID; // 0x10
			public LoadStatus _loadStatus; // 0x14
			public StringBuilder _logStr; // 0x18
			public HEU_SessionBase _session; // 0x20
			public List<HEU_LoadObject> _loadedObjects; // 0x28
			public Dictionary<int, HEU_LoadBufferBase> _idBuffersMap; // 0x30
	
			// Nested types
			public enum LoadStatus // TypeDefIndex: 78419
			{
				NONE = 0,
				STARTED = 1,
				SUCCESS = 2,
				ERROR = 3
			}
	
			// Constructors
			public HEU_LoadData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class HEU_LoadObject // TypeDefIndex: 78421
		{
			// Fields
			public int _objectNodeID; // 0x10
			public int _displayNodeID; // 0x14
			public List<HEU_LoadBufferVolume> _terrainBuffers; // 0x18
			public List<HEU_LoadBufferMesh> _meshBuffers; // 0x20
			public List<HEU_LoadBufferInstancer> _instancerBuffers; // 0x28
	
			// Constructors
			public HEU_LoadObject(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public enum HEU_LoadCallbackType // TypeDefIndex: 78422
		{
			PRECOOK = 0,
			POSTCOOK = 1
		}
	
		public delegate void HEU_LoadCallback(HEU_SessionBase session, HEU_LoadData loadData, HEU_LoadCallbackType callbackType); // TypeDefIndex: 78423; 0x00000001811DF7F0-0x00000001811DF810
	
		// Constructors
		public HEU_ThreadedTaskLoadGeo(); // 0x000000018C1EF1D4-0x000000018C1EF21C
	
		// Methods
		public void SetupLoad(HEU_SessionBase session, HEU_BaseSync ownerSync, LoadType loadType, int cookNodeID, string name, string filePath); // 0x000000018C1EF07C-0x000000018C1EF1C8
		public void SetupLoadNode(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string name); // 0x000000018C1EF04C-0x000000018C1EF07C
		public void SetupLoadFile(HEU_SessionBase session, HEU_BaseSync ownerSync, int cookNodeID, string filePath); // 0x000000018C1EF01C-0x000000018C1EF04C
		public void SetupLoadAsset(HEU_SessionBase session, HEU_BaseSync ownerSync, string assetPath, string name); // 0x000000018C1EEFE8-0x000000018C1EF01C
		public void SetLoadCallback(HEU_LoadCallback loadCallback); // 0x0000000188800CD0-0x0000000188800CE0
		protected override void DoWork(); // 0x000000018C1EBA58-0x000000018C1EBAF8
		protected virtual bool CookNode(HEU_SessionBase session, int cookNodeID); // 0x000000018C1EB670-0x000000018C1EB6FC
		protected virtual bool LoadObjectBuffers(HEU_SessionBase session, ref HAPI_ObjectInfo objectInfo); // 0x000000018C1EEBAC-0x000000018C1EEC00
		protected virtual bool LoadNodeBuffer(HEU_SessionBase session, int nodeID, HEU_LoadObject loadObject); // 0x000000018C1EE8B0-0x000000018C1EEBAC
		protected virtual void BuildBufferIDsMap(HEU_LoadData loadData); // 0x000000018C1EB144-0x000000018C1EB65C
		public virtual bool DoFileLoad(); // 0x000000018C1EB8F0-0x000000018C1EBA58
		public virtual bool DoAssetLoad(); // 0x000000018C1EB7E4-0x000000018C1EB8F0
		private bool QueryParts(int nodeID, ref List<HAPI_PartInfo> meshParts, ref List<HAPI_PartInfo> volumeParts, ref List<HAPI_PartInfo> instancerParts, ref List<HAPI_PartInfo> curveParts, ref List<HAPI_PartInfo> scatterInstancerParts); // 0x000000018C1EED84-0x000000018C1EEE08
		protected override void OnComplete(); // 0x000000018C1EEC88-0x000000018C1EED14
		protected override void OnStopped(); // 0x000000018C1EED14-0x000000018C1EED84
		protected override void CleanUp(); // 0x000000018C1EB65C-0x000000018C1EB670
		private string CreateLogString(HEU_LoadData.LoadStatus status, string logStr); // 0x000000018C1EB754-0x000000018C1EB7E4
		private void AppendLog(HEU_LoadData.LoadStatus status, string logStr); // 0x000000018C1EB018-0x000000018C1EB144
		private void SetLog(HEU_LoadData.LoadStatus status, string logStr); // 0x000000018C1EEE44-0x000000018C1EEFE8
		private bool CreateFileNode(out int fileNodeID); // 0x000000018C1EB6FC-0x000000018C1EB754
		public virtual int GetCookNodeID(); // 0x000000018C1EE3EC-0x000000018C1EE408
		private int GetDisplayNodeID(int objNodeID); // 0x000000018C1EE408-0x000000018C1EE424
		private bool SetFileParm(int fileNodeID, string filePath); // 0x000000018C1EEE08-0x000000018C1EEE44
		private void Sleep(); // 0x000000018C1EF1C8-0x000000018C1EF1D4
		public bool GenerateTerrainBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> volumeParts, List<HAPI_PartInfo> scatterInstancerParts, out List<HEU_LoadBufferVolume> volumeBuffers); // 0x000000018C1EC8F0-0x000000018C1EE3EC
		private void LoadStringFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref string strValue); // 0x000000018C1EEC00-0x000000018C1EEC88
		private void LoadFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue); // 0x000000018C1EE54C-0x000000018C1EE64C
		private void LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue); // 0x000000018C1EE64C-0x000000018C1EE798
		private void LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue); // 0x000000018C1EE798-0x000000018C1EE8B0
		public bool GenerateMeshBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> meshParts, bool bSplitPoints, bool bUseLODGroups, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, HEU_LoadObject loadObject, out List<HEU_LoadBufferMesh> meshBuffers); // 0x000000018C1EBEB8-0x000000018C1EC488
		public bool GenerateInstancerBuffers(HEU_SessionBase session, int nodeID, List<HAPI_PartInfo> instancerParts, out List<HEU_LoadBufferInstancer> instancerBuffers); // 0x000000018C1EBAF8-0x000000018C1EBEB8
		private HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo); // 0x000000018C1EC488-0x000000018C1EC778
		private HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HEU_SessionBase session, int geoID, int partID, string partName, HAPI_PartInfo partInfo); // 0x000000018C1EC778-0x000000018C1EC8F0
		public static HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(int tileIndex, List<HEU_LoadBufferVolume> buffers); // 0x000000018C1EE424-0x000000018C1EE540
		public static string GetValidAssetCacheFolderPath(string name); // 0x000000018C1EE540-0x000000018C1EE54C
	}

	public class HEU_ThreadManager // TypeDefIndex: 78425
	{
		// Fields
		private static HEU_ThreadManager _instance; // 0x00
		private List<HEU_ThreadedTask> _tasks; // 0x10
		private List<HEU_ThreadedTask> _pendingAdd; // 0x18
		private List<HEU_ThreadedTask> _pendingRemove; // 0x20
	
		// Properties
		public static HEU_ThreadManager Instance { get; } // 0x000000018C1EAFE0-0x000000018C1EB018 
	
		// Constructors
		public HEU_ThreadManager(); // 0x000000018C1EAF04-0x000000018C1EAFE0
	
		// Methods
		private static void CreateInstance(); // 0x0000000186805BA0-0x0000000186805BB0
		~HEU_ThreadManager(); // 0x000000018C1EAABC-0x000000018C1EAB0C
		public void Register(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Unregister(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Update(); // 0x000000018C1EABA8-0x000000018C1EAF04
		public void AddTask(HEU_ThreadedTask task); // 0x000000018C1EAA20-0x000000018C1EAABC
		public void RemoveTask(HEU_ThreadedTask task); // 0x000000018C1EAB0C-0x000000018C1EABA8
	}

	public class HEU_CookLogs // TypeDefIndex: 78426
	{
		// Fields
		private static HEU_CookLogs _instance; // 0x00
		private StringBuilder _cookLogs; // 0x10
		private int _currentCookLogCount; // 0x18
		private const int MAX_COOK_LOG_COUNT = 9001; // Metadata: 0x0262B8EC
		private string _lastLogStr; // 0x20
		private bool _uniqueStrOnly; // 0x28
		public const long MaxLogSize = 50000000; // Metadata: 0x0262B8F0
	
		// Properties
		public static HEU_CookLogs Instance { get; } // 0x000000018C1DBD58-0x000000018C1DBDE8 
	
		// Constructors
		public HEU_CookLogs(); // 0x000000018C1DBCCC-0x000000018C1DBD58
	
		// Methods
		public string GetCookLogString(); // 0x000000018C1DBA38-0x000000018C1DBA5C
		public void AppendCookLog(string logStr); // 0x000000018C1DB780-0x000000018C1DB894
		public void ClearCookLog(); // 0x000000018C1DB894-0x000000018C1DB900
		public string GetCookLogFilePath(); // 0x000000018C1DB988-0x000000018C1DBA38
		public void DeleteCookingFile(); // 0x000000018C1DB900-0x000000018C1DB988
		public void WriteToLogFile(string logStr, bool checkLastLogStr = true /* Metadata: 0x0262B8EB */); // 0x000000018C1DBAE4-0x000000018C1DBCCC
		public long GetFileSizeOfLogFile(); // 0x000000018C1DBA5C-0x000000018C1DBAE4
	}

	public static class HEU_EditorUtility // TypeDefIndex: 78428
	{
		// Nested types
		public enum HEU_ReplacePrefabOptions // TypeDefIndex: 78427
		{
			Default = 0,
			ConnectToPrefab = 1,
			ReplaceNameBased = 2
		}
	
		// Methods
		public static void MarkSceneDirty(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SelectObject(GameObject gameObject); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SelectObjects(GameObject[] gameObjects); // 0x0000000186805BA0-0x0000000186805BB0
		public static Vector3 GetSelectedObjectsMeanPosition(); // 0x000000018C1DC668-0x000000018C1DC680
		public static Matrix4x4 GetSelectedObjectsMeanTransform(); // 0x0000000187250830-0x0000000187250870
		public static GameObject SaveAsPrefabAsset(string path, GameObject go); // 0x000000018C1DC960-0x000000018C1DC998
		public static bool PrefabIsAddedComponentOverride(Component comp); // 0x00000001843FFFF0-0x0000000184400000
		public static bool IsEditorPlaying(); // 0x00000001843FFFF0-0x0000000184400000
		public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab, HEU_ReplacePrefabOptions heuOptions); // 0x000000018C1DC928-0x000000018C1DC960
		public static bool IsPrefabInstance(GameObject go); // 0x000000018C1DC808-0x000000018C1DC840
		public static bool IsPrefabAsset(GameObject go); // 0x000000018C1DC7D0-0x000000018C1DC808
		public static bool IsEditingInPrefabMode(GameObject obj); // 0x00000001843FFFF0-0x0000000184400000
		public static bool IsDisconnectedPrefabInstance(GameObject go); // 0x000000018C1DC760-0x000000018C1DC798
		public static UnityEngine.Object GetPrefabAsset(GameObject go); // 0x000000018C1DC5B8-0x000000018C1DC5F0
		public static string GetPrefabAssetPath(UnityEngine.Object obj); // 0x000000018C1DC580-0x000000018C1DC5B8
		public static void DisconnectPrefabInstance(GameObject instance); // 0x000000018C1DC03C-0x000000018C1DC070
		public static UnityEngine.Object InstantiatePrefab(GameObject prefabOriginal); // 0x000000018C1DC728-0x000000018C1DC760
		public static GameObject InstantiateGameObject(GameObject sourceGameObject, Transform parentTransform, bool instantiateInWorldSpace, bool bRegisterUndo); // 0x000000018C1DC6B8-0x000000018C1DC728
		public static Component AddComponent<T>(GameObject target, bool bRegisterUndo);
		public static void UndoRecordObject(UnityEngine.Object objectToUndo, string name); // 0x0000000186805BA0-0x0000000186805BB0
		public static void UndoCollapseCurrentGroup(); // 0x0000000186805BA0-0x0000000186805BB0
		public static UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj); // 0x000000018C1DBF1C-0x000000018C1DBF54
		public static bool IsPersistant(UnityEngine.Object obj); // 0x000000018C1DC798-0x000000018C1DC7D0
		public static string GetUniqueNameForSibling(Transform parentTransform, string name); // 0x000000018C1DC680-0x000000018C1DC6B8
		public static void DisplayProgressBar(string title, string info, float progress); // 0x000000018C1DC13C-0x000000018C1DC170
		public static void ClearProgressBar(); // 0x000000018C1DBEE8-0x000000018C1DBF1C
		public static bool IsEditorNotInPlayModeAndNotGoingToPlayMode(); // 0x0000000187232850-0x0000000187232860
		public static bool DisplayDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x0262B8F8 */); // 0x000000018C1DC070-0x000000018C1DC0C8
		public static bool DisplayErrorDialog(string title, string message, string ok, string cancel = "" /* Metadata: 0x0262B8F9 */); // 0x000000018C1DC0C8-0x000000018C1DC13C
		public static void RevealInFinder(string path); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetStatic(GameObject go, bool bStatic, bool bIncludeChildren); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetIsHidden(GameObject go, bool isHidden, bool bIncludeChildren); // 0x0000000186805BA0-0x0000000186805BB0
		public static GameObject[] GetSelectedObjects(); // 0x0000000185829EC0-0x0000000185829ED0
		public static HEU_HoudiniAssetRoot[] GetSelectedAssetRoots(); // 0x000000018C1DC5F0-0x000000018C1DC668
		public static HEU_HoudiniAssetRoot[] GetAllAssetRoots(); // 0x000000018C1DC4D4-0x000000018C1DC528
		public static void CookSelected(); // 0x000000018C1DC020-0x000000018C1DC03C
		public static void CookAll(); // 0x000000018C1DBF54-0x000000018C1DBF70
		public static void CookAssets(HEU_HoudiniAssetRoot[] rootAssets); // 0x000000018C1DBF70-0x000000018C1DC020
		public static void RebuildSelected(); // 0x000000018C1DC90C-0x000000018C1DC928
		public static void RebuildAll(); // 0x000000018C1DC840-0x000000018C1DC85C
		public static void RebuildAssets(HEU_HoudiniAssetRoot[] rootAssets); // 0x000000018C1DC85C-0x000000018C1DC90C
		public static void BakeAndReplaceSelectedInScene(); // 0x000000018C1DBECC-0x000000018C1DBEE8
		public static void BakeAndReplaceAllInScene(); // 0x000000018C1DBDE8-0x000000018C1DBE04
		public static void BakeAndReplaceAssets(HEU_HoudiniAssetRoot[] rootAssets); // 0x000000018C1DBE04-0x000000018C1DBECC
		public static void ExportSelectedAssetsToGeoFiles(); // 0x000000018C1DC4B8-0x000000018C1DC4D4
		public static void ExportAllAssetsToGeoFiles(); // 0x000000018C1DC1A8-0x000000018C1DC1C4
		public static void ExportAssetsToGeoFiles(HEU_HoudiniAssetRoot[] rootAssets); // 0x000000018C1DC1C4-0x000000018C1DC4B8
		public static string EditorSaveFolderPanel(string title, string folder, string defaultName); // 0x000000018C1DC170-0x000000018C1DC1A8
		public static void QuerySelectedMeshTopology(); // 0x0000000186805BA0-0x0000000186805BB0
		public static string GetObjectParentFolder(GameObject parentObject, HashSet<Material> generatedMaterials); // 0x000000018C1DC554-0x000000018C1DC580
		private static string GetObjectParentFolderHelper(int instanceID); // 0x000000018C1DC528-0x000000018C1DC554
		public static void RepaintScene(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetTextureToNormalMap(string filename); // 0x0000000186805BA0-0x0000000186805BB0
		public static bool ReleasedMouse(); // 0x00000001851A4410-0x00000001851A4420
	}

	public static class HEU_Extensions // TypeDefIndex: 78429
	{
		// Extension methods
		public static List<R> Map<T, R>(this IEnumerable<T> self, Func<T, R> selector);
		public static T Reduce<T>(this IEnumerable<T> self, Func<T, T, T> func);
		public static List<T> Filter<T>(this IEnumerable<T> self, Func<T, bool> predicate);
		public static bool IsValidIndex<T>(this List<T> self, int index);
		public static bool IsEquivalentList<T>(this List<T> self, List<T> other);
		public static bool ApproximatelyEquals(this Quaternion quatA, Quaternion value); // 0x000000018C1DC998-0x000000018C1DC9E4
		public static List<U> ConvertList<T, U>(this List<T> self);
		public static List<IEquivable<T>> ConvertListToEquivable<T>(this List<T> self);
		public static IEquivable<T>[] ConvertArrayToEquivable<T>(this T[] self);
		public static bool ApproximatelyEquals(this float self, float other, float epsilon = 0.001f /* Metadata: 0x0262B8FD */); // 0x0000000188C5491C-0x0000000188C54930
		public static byte[] AsByteArray(this string self); // 0x000000018C1DC9E4-0x000000018C1DCA50
		public static string AsString(this byte[] buffer); // 0x000000018C1DCA50-0x000000018C1DCAB4
		public static Vector3 SwapXAndY(this Vector3 self); // 0x0000000187250870-0x00000001872508A0
		public static Vector3 SwapXAndZ(this Vector3 self); // 0x00000001872508A0-0x00000001872508C0
		public static Vector3 SwapYAndZ(this Vector3 self); // 0x00000001872508C0-0x00000001872508F0
		public static Vector3 DecomposeToPosition(this Matrix4x4 self); // 0x000000018C1B45AC-0x000000018C1B45F8
		public static Quaternion DecomposeToRotation(this Matrix4x4 self); // 0x000000018C1DCAB4-0x000000018C1DCB7C
		public static Vector3 DecomposeToScale(this Matrix4x4 self); // 0x000000018C1DCB7C-0x000000018C1DCC34
	}

	public static class ArrayExtensions // TypeDefIndex: 78430
	{
		// Extension methods
		public static void Init<T>(this T[] array, T defaultValue);
		public static void Init<T>(this List<T> array, T defaultValue);
		public static void CopyToWithResize<T>(this T[] srcArray, ref ref T[] destArray);
		public static bool IsEquivalentArray<T>(this T[] arr, T[] other);
		public static bool IsNull<T>(this T[] arr);
	}

	public static class DictionaryExtensions // TypeDefIndex: 78431
	{
		// Extension methods
		public static void AddOrSet<T, U>(this Dictionary<T, U> dict, T key, U value);
	}

	public struct TransformData // TypeDefIndex: 78432
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 localPosition; // 0x1C
		public Vector3 localScale; // 0x28
		public Quaternion localRotation; // 0x34
		public Transform parent; // 0x48
	
		// Constructors
		public TransformData(Transform other); // 0x000000018C1EFADC-0x000000018C1EFBA4
	
		// Methods
		public void CopyTo(Transform other, bool copyParent); // 0x000000018C1EFA38-0x000000018C1EFADC
		public void CopyToLocal(Transform other, bool copyParent); // 0x000000018C1EF990-0x000000018C1EFA38
	}

	public class HEU_GeneralUtility // TypeDefIndex: 78438
	{
		// Nested types
		public delegate bool GetArray1ArgDel<T>(int arg1, out T[] data, int start, int length); // TypeDefIndex: 78433; 0x00000000-0x00000000
	
		public delegate bool GetArray2ArgDel<ARG2, T>(int arg1, ARG2 arg2, out T[] data, int start, int length); // TypeDefIndex: 78434; 0x00000000-0x00000000
	
		public delegate bool GetArray3ArgDel<ARG3, ARG2, T>(int arg1, ARG2 arg2, ARG3 arg3, out T[] data, int start, int length); // TypeDefIndex: 78435; 0x00000000-0x00000000
	
		public delegate bool GetAttributeArrayInputFunc<T>(int geoID, int partID, string name, ref HAPI_AttributeInfo info, out T[] items, int start, int end); // TypeDefIndex: 78436; 0x00000000-0x00000000
	
		public delegate bool SetAttributeArrayFunc<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, int start, int end); // TypeDefIndex: 78437; 0x00000000-0x00000000
	
		// Constructors
		public HEU_GeneralUtility(); // 0x0000000186805BA0-0x0000000186805BB0
	
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
		public static void GetAttributeStringDataHelper(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] data); // 0x000000018C1DF0C8-0x000000018C1DF118
		public static string[] GetAttributeStringData(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo); // 0x000000018C1DF118-0x000000018C1DF1E0
		public static string[] GetAttributeDataAsString(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo attrInfo); // 0x000000018C1DEE4C-0x000000018C1DEEC8
		public static bool SetAttributeArray<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc, int count, int start = 0 /* Metadata: 0x0262B901 */);
		public static bool SetAttribute<T>(int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo, T[] items, SetAttributeArrayFunc<T> setFunc);
		public static bool CheckAttributeExists(HEU_SessionBase session, int geoID, int partID, string attribName, HAPI_AttributeOwner attribOwner); // 0x000000018C1B29C4-0x000000018C1B29DC
		public static bool GetAttributeInfo(HEU_SessionBase session, int geoID, int partID, string attribName, ref HAPI_AttributeInfo attribInfo); // 0x000000018C1DEFB8-0x000000018C1DEFD8
		public static bool HasValidInstanceAttribute(HEU_SessionBase session, int geoID, int partID, string attribName); // 0x000000018C1E03B4-0x000000018C1E03E0
		public static void UpdateGeneratedAttributeStore(HEU_SessionBase session, int geoID, int partID, GameObject go); // 0x000000018C1E1528-0x000000018C1E1698
		public static HEU_OutputAttribute CreateOutputAttributeHelper(string attrName, ref HAPI_AttributeInfo attrInfo); // 0x000000018C1DDB00-0x000000018C1DDB80
		public static HEU_OutputAttribute CreateOutputAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref HAPI_AttributeInfo attrInfo); // 0x000000018C1DDB80-0x000000018C1DDDC8
		public static void CopyWorldTransformValues(Transform src, Transform dest); // 0x000000018C1DD9A8-0x000000018C1DDA64
		public static void ApplyTransformTo(Transform src, Transform target); // 0x000000018C1DCC34-0x000000018C1DCD48
		public static void CopyLocalTransformValues(Transform src, Transform dest); // 0x000000018C1DD8EC-0x000000018C1DD9A8
		public static List<GameObject> GetChildGameObjects(GameObject parentGO); // 0x000000018C1DF840-0x000000018C1DFA3C
		public static List<GameObject> GetChildGameObjectsWithNamePattern(GameObject parentGO, string pattern, bool bExclude); // 0x000000018C1DF5E0-0x000000018C1DF840
		public static List<GameObject> GetInstanceChildObjects(GameObject parentGO); // 0x000000018C1DFCBC-0x000000018C1DFCFC
		public static List<GameObject> GetNonInstanceChildObjects(GameObject parentGO); // 0x000000018C1DFF20-0x000000018C1DFF60
		public static GameObject GetGameObjectByName(List<GameObject> goList, string name); // 0x000000018C1DFB3C-0x000000018C1DFC84
		public static GameObject GetGameObjectByNameInProjectOnly(string name); // 0x000000018C1DFA3C-0x000000018C1DFB04
		public static bool IsGameObjectInProject(GameObject go); // 0x000000018C1E03E0-0x000000018C1E03E8
		public static GameObject GetGameObjectByNameInScene(string name); // 0x000000018C1DFB04-0x000000018C1DFB3C
		public static HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(string name); // 0x000000018C1DFC84-0x000000018C1DFCBC
		public static T GetOrCreateComponent<T>(GameObject gameObject)
			where T : Component;
		public static void DestroyGeneratedComponents(GameObject gameObject); // 0x000000018C1DE0FC-0x000000018C1DE1D8
		public static void DestroyGeneratedMeshComponents(GameObject gameObject); // 0x000000018C1DE2D4-0x000000018C1DE360
		public static void DestroyTerrainComponents(GameObject gameObject); // 0x000000018C1DE7D8-0x000000018C1DE91C
		public static void DestroyComponent<T>(GameObject gameObject)
			where T : Component;
		public static void DestroyImmediate(UnityEngine.Object obj, bool bAllowDestroyingAssets = false /* Metadata: 0x0262B902 */, bool bRegisterUndo = false /* Metadata: 0x0262B903 */); // 0x000000018C1DE55C-0x000000018C1DE590
		public static void DestroyBakedGameObjects(List<GameObject> gameObjectsToDestroy); // 0x000000018C1DE030-0x000000018C1DE03C
		public static void DestroyBakedGameObjectsWithEndName(List<GameObject> gameObjectsToDestroy, string endName); // 0x000000018C1DDF24-0x000000018C1DE030
		public static void DestroyLODGroup(GameObject targetGO, bool bDontDeletePersistantResources); // 0x000000018C1DE590-0x000000018C1DE6FC
		public static List<Transform> GetLODTransforms(GameObject targetGO); // 0x000000018C1DFCFC-0x000000018C1DFE3C
		public static void SetLODTransformValues(GameObject targetGO, List<HoudiniEngineUnity.TransformData> transformData); // 0x000000018C1E1094-0x000000018C1E11D0
		public static void DestroyGeneratedMeshMaterialsLODGroups(GameObject targetGO, bool bDontDeletePersistantResources); // 0x000000018C1DE360-0x000000018C1DE55C
		public static void DestroyGeneratedMaterial(Material material); // 0x000000018C1DE1D8-0x000000018C1DE2D4
		public static void DestroyMeshCollider(MeshCollider meshCollider, bool bDontDeletePersistantResources); // 0x000000018C1DE6FC-0x000000018C1DE7D8
		public static void SetGameObjectRenderVisiblity(GameObject gameObject, bool bVisible); // 0x000000018C1E0FE4-0x000000018C1E1094
		public static void SetGameObjectChildrenRenderVisibility(GameObject gameObject, bool bVisible); // 0x000000018C1E0E70-0x000000018C1E0F34
		public static void SetGameObjectColliderState(GameObject gameObject, bool bEnabled); // 0x000000018C1E0F34-0x000000018C1E0FE4
		public static void SetGameObjectChildrenColliderState(GameObject gameObject, bool bVisible); // 0x000000018C1E0DAC-0x000000018C1E0E70
		public static string ColorToString(UnityEngine.Color c); // 0x000000018C1DD524-0x000000018C1DD6C0
		public static UnityEngine.Color StringToColor(string colorString); // 0x000000018C1E1418-0x000000018C1E1528
		public static bool DoesUnityTagExist(string tagName); // 0x00000001851A4410-0x00000001851A4420
		public static void SetLayer(GameObject rootGO, int layer, bool bIncludeChildren); // 0x000000018C1E11D0-0x000000018C1E12A0
		public static void SetTag(GameObject rootGO, string tag, bool bIncludeChildren); // 0x000000018C1E1344-0x000000018C1E1418
		public static void CopyFlags(GameObject srcGO, GameObject dstGO, bool bIncludeChildren); // 0x000000018C1DD7F0-0x000000018C1DD860
		public static bool IsMouseWithinSceneView(Camera camera, Vector2 mousePosition); // 0x000000018C1E04BC-0x000000018C1E052C
		public static bool IsMouseOverRect(Camera camera, Vector2 mousePosition, ref Rect rect); // 0x000000018C1E0470-0x000000018C1E04BC
		public static System.Type GetSystemTypeByName(string typeName); // 0x000000018C1E0274-0x000000018C1E02AC
		public static void AssignUnityTag(HEU_SessionBase session, int geoID, int partID, GameObject gameObject); // 0x000000018C1DCE84-0x000000018C1DCFA8
		public static void AssignUnityLayer(HEU_SessionBase session, int geoID, int partID, GameObject gameObject); // 0x000000018C1DCD48-0x000000018C1DCE84
		public static void MakeStaticIfHasAttribute(HEU_SessionBase session, int geoID, int partID, GameObject gameObject); // 0x000000018C1E0840-0x000000018C1E0958
		public static string GetUnityScriptAttributeValue(HEU_SessionBase session, int geoID, int partID); // 0x000000018C1E02AC-0x000000018C1E0390
		public static string GetAttributeStringValueSingle(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner); // 0x000000018C1DF4D0-0x000000018C1DF5E0
		public static string GetAttributeStringValueSingleStrict(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner); // 0x000000018C1DF1E0-0x000000018C1DF4D0
		public static bool GetAttributeFloatSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out float value); // 0x000000018C1DEEC8-0x000000018C1DEFB8
		public static bool GetAttributeIntSingle(HEU_SessionBase session, int geoID, int partID, string attrName, out int value); // 0x000000018C1DEFD8-0x000000018C1DF0C8
		public static bool GetAttributeColorSingle(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color value); // 0x000000018C1DED6C-0x000000018C1DEE4C
		public static bool HasAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, HAPI_AttributeOwner attrOwner); // 0x000000018C1E0390-0x000000018C1E03B4
		public static void AttachScriptWithInvokeFunction(string scriptSet, GameObject gameObject); // 0x000000018C1DCFA8-0x000000018C1DD4CC
		public static bool IsInCameraView(Camera camera, Vector3 point); // 0x000000018C1E03E8-0x000000018C1E0470
		internal static List<HEU_Handle> FindOrGenerateHandles(HEU_SessionBase session, ref HAPI_AssetInfo assetInfo, int assetID, string assetName, HEU_Parameters parameters, List<HEU_Handle> currentHandles); // 0x000000018C1DE91C-0x000000018C1DED6C
		public static void CopyComponents(GameObject srcGO, GameObject destGO); // 0x0000000186805BA0-0x0000000186805BB0
		public static Texture LoadTextureFromFile(string filePath); // 0x000000018C1E052C-0x000000018C1E06D8
		public static Texture2D MakeTexture(int width, int height, UnityEngine.Color color); // 0x000000018C1E0958-0x000000018C1E0A58
		public static string ReplaceFirstOccurrence(string srcStr, string searchStr, string replaceStr); // 0x000000018C1E0D14-0x000000018C1E0DAC
		public static void SetParentWithCleanTransform(Transform parentTransform, Transform childTransform); // 0x000000018C1E12A0-0x000000018C1E1344
		public static void CopyHAPITransform(ref HAPI_Transform src, ref HAPI_Transform dest); // 0x000000018C1DD860-0x000000018C1DD8EC
		public static string GetMaterialAttributeValueFromPart(HEU_SessionBase session, int geoID, int partID); // 0x000000018C1DFE3C-0x000000018C1DFF20
		public static void ReplaceColliderMeshFromMeshFilter(GameObject targetGO, GameObject sourceColliderGO); // 0x000000018C1E0BE8-0x000000018C1E0D14
		public static void ReplaceColliderMeshFromMeshCollider(GameObject targetGO, GameObject sourceColliderGO); // 0x000000018C1E0AC8-0x000000018C1E0BE8
		public static float BiLerpf(float p00, float p10, float p01, float p11, float fracX, float fracY); // 0x000000018C1DD4CC-0x000000018C1DD524
		public static float Fractionalf(float value); // 0x00000001872508F0-0x0000000187250920
		public static string LongestCommonPrefix(List<string> list); // 0x000000018C1E06D8-0x000000018C1E0840
		public static string GetRawOperatorName(string assetOpName); // 0x000000018C1E0218-0x000000018C1E0274
		public static GameObject GetPrefabFromPath(string path); // 0x000000018C1DFF60-0x000000018C1E0218
		public static void ComposeNChildren(GameObject parent, int n, ref List<GameObject> childGameObjects, bool destroyIfExists = false /* Metadata: 0x0262B904 */); // 0x000000018C1DD6C0-0x000000018C1DD7F0
		private static void DestroyChildWithName(Transform parent, string name); // 0x000000018C1DE03C-0x000000018C1DE0FC
		public static void DestroyAutoGeneratedChildren(GameObject parent); // 0x000000018C1DDDC8-0x000000018C1DDF24
		public static GameObject CreateNewGameObject(string name = "" /* Metadata: 0x0262B905 */); // 0x000000018C1DDA64-0x000000018C1DDB00
		public static void RenameGameObject(GameObject obj, string name); // 0x000000018C1E0A58-0x000000018C1E0AC8
	}

	public class ReverseCompare : System.Collections.IComparer // TypeDefIndex: 78439
	{
		// Constructors
		public ReverseCompare(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public int Compare(object x, object y); // 0x000000018C1EF918-0x000000018C1EF990
	}

	public class HEU_GenerateGeoCache // TypeDefIndex: 78443
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
		public int GeoID { get; } // 0x0000000187233000-0x0000000187233010 
		public int PartID { get; } // 0x00000001829600C0-0x00000001829600D0 
		public int AssetID { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
		// Nested types
		public class HEU_ColliderInfo // TypeDefIndex: 78441
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
			public enum ColliderType // TypeDefIndex: 78440
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
			public HEU_ColliderInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78442
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Material> __9__64_0; // 0x08
			public static Comparison<float> __9__66_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C1FFEB0-0x000000018C1FFF14
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetFinalMaterialsFromComparingNewWithPrevious_b__64_0(Material material); // 0x000000018C1FFE64-0x000000018C1FFEB0
			internal int _GenerateLODMeshesFromGeoGroups_b__66_0(float a, float b); // 0x000000018C1FFE48-0x000000018C1FFE64
		}
	
		// Constructors
		public HEU_GenerateGeoCache(); // 0x000000018C1EA5AC-0x000000018C1EA818
	
		// Methods
		public static HEU_GenerateGeoCache GetPopulatedGeoCache(HEU_SessionBase session, int assetID, int geoID, int partID, bool bUseLODGroups, List<HEU_MaterialData> materialCache, string assetCacheFolderPath); // 0x000000018C1E8EF0-0x000000018C1E8FA8
		public void GetStringAttributes(HEU_SessionBase session, int geoID, int partID, string name, ref HAPI_AttributeInfo info, ref int[] stringIndices, ref List<string> stringTable); // 0x000000018C1E8FA8-0x000000018C1E9108
		public void PopulateUnityMaterialData(HEU_SessionBase session); // 0x000000018C1E9834-0x000000018C1E9B2C
		public static int GetMaterialKeyFromAttributeIndex(HEU_GenerateGeoCache geoCache, int attributeIndex, out string unityMaterialName, out string substanceName, out int substanceIndex); // 0x000000018C1E8D60-0x000000018C1E8EF0
		public static void CreateMaterialInfoEntryFromAttributeIndex(HEU_GenerateGeoCache geoCache, int materialAttributeIndex); // 0x000000018C1E1FBC-0x000000018C1E20D8
		public bool PopulateGeometryData(HEU_SessionBase session, bool bUseLODGroups); // 0x000000018C1E9494-0x000000018C1E9834
		public static void ParseLODTransitionAttribute(HEU_SessionBase session, int geoID, int partID, ref float[] LODTransitionValues); // 0x000000018C1E93B0-0x000000018C1E9494
		public static void UpdateColliders(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData); // 0x000000018C1EA458-0x000000018C1EA5AC
		public static void UpdateCollider(HEU_GenerateGeoCache geoCache, HEU_GeneratedOutputData outputData, HEU_ColliderInfo colliderInfo); // 0x000000018C1E9E04-0x000000018C1EA458
		private static void GetFinalMaterialsFromComparingNewWithPrevious(GameObject gameObject, Material[] previousMaterials, Material[] newMaterials, ref Material[] finalMaterials); // 0x000000018C1E89D8-0x000000018C1E8D60
		public static bool GenerateMeshFromSingleGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced); // 0x000000018C1E87C8-0x000000018C1E89D8
		public static bool GenerateLODMeshesFromGeoGroups(HEU_SessionBase session, List<HEU_GeoGroup> GeoGroupMeshes, HEU_GenerateGeoCache geoCache, HEU_GeneratedOutput generatedOutput, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced); // 0x000000018C1E659C-0x000000018C1E6FEC
		public static bool GenerateMeshFromGeoGroup(HEU_SessionBase session, HEU_GeoGroup GeoGroup, HEU_GenerateGeoCache geoCache, int defaultMaterialKey, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bPartInstanced, out Mesh newMesh, out Material[] newMaterials); // 0x000000018C1E6FEC-0x000000018C1E87C8
		public static Mesh CombineQuadMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> subMeshIndices, bool bGenerateNormals); // 0x000000018C1E1A50-0x000000018C1E1FBC
		public static Mesh CombineMeshes(Dictionary<int, HEU_MeshData> subMeshesMap, List<int> submeshIndices, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat); // 0x000000018C1E17CC-0x000000018C1E1A50
		public static Mesh CreateMeshFromMeshData(HEU_MeshData submesh, bool bGenerateUVs, bool bGenerateNormals, HEU_MeshIndexFormat meshIndexFormat); // 0x000000018C1E20D8-0x000000018C1E2364
		public static void TransferRegularAttributesToVertices(int[] groupVertexList, int[] allFaceCounts, List<int> groupFaces, List<int> groupVertexOffset, ref HAPI_AttributeInfo attribInfo, float[] inData, ref float[] outData); // 0x000000018C1E9B2C-0x000000018C1E9E04
		public static bool GenerateGeoGroupUsingGeoCacheVertices(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey); // 0x000000018C1E4010-0x000000018C1E659C
		public static bool GenerateGeoGroupUsingGeoCachePoints(HEU_SessionBase session, HEU_GenerateGeoCache geoCache, bool bGenerateUVs, bool bGenerateTangents, bool bGenerateNormals, bool bUseLODGroups, bool bPartInstanced, out List<HEU_GeoGroup> LODGroupMeshes, out int defaultMaterialKey); // 0x000000018C1E2364-0x000000018C1E4010
		private static void GetSubmeshIDForFace(HEU_GenerateGeoCache geoCache, int faceMaterialID, int groupFace, int vertexFaceIndex, int[] groupVertexList, int defaultMaterialKey, ref int submeshID, ref int singleFaceUnityMaterialKey, ref int singleFaceHoudiniMaterialKey); // 0x000000018C1E9108-0x000000018C1E93B0
		public static MeshTopology CalculateGroupMeshTopology(List<int> groupFaces, int[] allFaceCounts); // 0x000000018C1E1698-0x000000018C1E17CC
	}

	public class HEU_GeoGroup : IComparable<HEU_GeoGroup> // TypeDefIndex: 78444
	{
		// Fields
		public string _groupName; // 0x10
		public Dictionary<int, HEU_MeshData> _subMeshesMap; // 0x18
		public List<HEU_VertexEntry>[] _sharedNormalIndices; // 0x20
	
		// Constructors
		public HEU_GeoGroup(); // 0x000000018C1EFCD4-0x000000018C1EFD4C
	
		// Methods
		public int CompareTo(HEU_GeoGroup other); // 0x000000018C1EFBA4-0x000000018C1EFBDC
		public void SetupNormalIndices(int indicesCount); // 0x000000018C1EFBDC-0x000000018C1EFCD4
	}

	public class HEU_VertexEntry // TypeDefIndex: 78445
	{
		// Fields
		public int _meshKey; // 0x10
		public int _vertexIndex; // 0x14
		public int _normalIndex; // 0x18
	
		// Constructors
		public HEU_VertexEntry(int meshKey, int vertexIndex, int normalIndex); // 0x0000000187235470-0x0000000187235480
	}

	public static class HEU_GeometryUtility // TypeDefIndex: 78446
	{
		// Methods
		public static Vector2[] GeneratePerTriangle(Mesh meshSrc); // 0x000000018C1F129C-0x000000018C1F12D4
		public static void GenerateSecondaryUVSet(Mesh meshsrc); // 0x000000018C1F12D4-0x000000018C1F1308
		public static void CalculateMeshTangents(Mesh mesh); // 0x000000018C1EFD4C-0x000000018C1F04FC
		public static Mesh GenerateCubeMeshFromPoints(Vector3[] points, UnityEngine.Color[] pointsColor, float size = 1f /* Metadata: 0x0262B90D */); // 0x000000018C1F04FC-0x000000018C1F129C
		public static string GetInstanceOutputName(string partName, string[] userPrefix, int index); // 0x000000018C1F1308-0x000000018C1F13B8
	}

	public class HEU_InputData // TypeDefIndex: 78447
	{
		// Fields
		public GameObject _inputObject; // 0x10
	
		// Constructors
		public HEU_InputData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class HEU_InputInterface // TypeDefIndex: 78448
	{
		// Fields
		public const int DEFAULT_PRIORITY = 100; // Metadata: 0x0262B911
		protected int _priority; // 0x10
	
		// Properties
		public int Priority { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public HEU_InputInterface(int priority); // 0x0000000182234E90-0x0000000182234EA0
	
		// Methods
		public void RegisterInterface(); // 0x000000018C1F74EC-0x000000018C1F7538
		public abstract bool IsThisInputObjectSupported(GameObject inputObject);
		public abstract bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID);
	}

	[Serializable]
	public class HEU_InputInterfaceMeshSettings // TypeDefIndex: 78449
	{
		// Fields
		[SerializeField]
		private bool _exportColliders; // 0x10
	
		// Properties
		public bool ExportColliders { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public HEU_InputInterfaceMeshSettings(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class HEU_InputInterfaceMesh : HEU_InputInterface // TypeDefIndex: 78454
	{
		// Fields
		private HEU_InputInterfaceMeshSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataMeshes : HEU_InputData // TypeDefIndex: 78450
		{
			// Fields
			public List<HEU_InputDataMesh> _inputMeshes; // 0x18
			public bool _hasLOD; // 0x20
	
			// Constructors
			public HEU_InputDataMeshes(); // 0x000000018C1F13B8-0x000000018C1F1430
		}
	
		public enum HEU_InputColliderType // TypeDefIndex: 78451
		{
			NONE = 0,
			BOX = 1,
			SPHERE = 2,
			CAPSULE = 3,
			MESH = 4
		}
	
		public class HEU_InputDataCollider // TypeDefIndex: 78452
		{
			// Fields
			public Collider _collider; // 0x10
			public HEU_InputColliderType _colliderType; // 0x18
	
			// Constructors
			public HEU_InputDataCollider(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class HEU_InputDataMesh // TypeDefIndex: 78453
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
			public HEU_InputDataMesh(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		private HEU_InputInterfaceMesh(); // 0x0000000187250920-0x0000000187250930
	
		// Methods
		public void Initialize(HEU_InputInterfaceMeshSettings settings); // 0x0000000187835500-0x0000000187835510
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x000000018C1F157C-0x000000018C1F16C0
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x000000018C1F2108-0x000000018C1F2224
		public static void GetUVsFromMesh(Mesh mesh, Vector2[] srcUVs, List<Vector3> destUVs, int index); // 0x000000018C1F2080-0x000000018C1F2108
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData); // 0x000000018C1F2F18-0x000000018C1F43A8
		internal bool UploadColliderData(HEU_SessionBase session, int mergeNodeID, HEU_InputDataMeshes inputData, int parentNodeId); // 0x000000018C1F29BC-0x000000018C1F2F18
		internal bool UploadBoxColliderData(HEU_SessionBase session, BoxCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x000000018C1F2224-0x000000018C1F2398
		internal bool UploadSphereColliderData(HEU_SessionBase session, SphereCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x000000018C1F4694-0x000000018C1F4810
		internal bool UploadCapsuleColliderData(HEU_SessionBase session, CapsuleCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x000000018C1F2398-0x000000018C1F29BC
		internal bool UploadMeshColliderData(HEU_SessionBase session, MeshCollider collider, int inputIndex, int parentNodeID, out int inputNodeID); // 0x000000018C1F43A8-0x000000018C1F4694
		internal string GetColliderGroupBaseName(Collider collider, bool bIsConvex = false /* Metadata: 0x0262B913 */, bool bIsSimple = false /* Metadata: 0x0262B914 */, bool bIsRendered = false /* Metadata: 0x0262B915 */); // 0x000000018C1F1E90-0x000000018C1F1F80
		internal bool CreateInputNodeForCollider(HEU_SessionBase session, out int outNodeID, int parentNodeId, int colliderIndex, string colliderName, float[] colliderVertices, int[] colliderIndices); // 0x000000018C1F1508-0x000000018C1F157C
		public HEU_InputDataMeshes GenerateMeshDatasFromGameObject(GameObject inputObject, bool bExportColliders = false /* Metadata: 0x0262B916 */); // 0x000000018C1F1BBC-0x000000018C1F1E90
		public static HEU_InputDataMesh CreateSingleMeshData(GameObject meshGameObject, bool bExportColliders); // 0x000000018C1F16C0-0x000000018C1F1BBC
		private static Mesh GetMeshFromObject(GameObject meshGameObject); // 0x000000018C1F1F80-0x000000018C1F2080
	}

	[Serializable]
	public class HEU_InputInterfaceSplineSettings // TypeDefIndex: 78455
	{
		// Fields
		[SerializeField]
		private float _samplingResolution; // 0x10
	
		// Properties
		public float SamplingResolution { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
	
		// Constructors
		public HEU_InputInterfaceSplineSettings(); // 0x0000000187250930-0x0000000187250940
	}

	public class HEU_InputInterfaceSpline : HEU_InputInterface // TypeDefIndex: 78458
	{
		// Fields
		private HEU_InputInterfaceSplineSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataSpline // TypeDefIndex: 78456
		{
			// Fields
			public Spline _spline; // 0x10
			public bool _closed; // 0x18
			public int _count; // 0x1C
			public float _length; // 0x20
			public BezierKnot[] _knots; // 0x28
	
			// Constructors
			public HEU_InputDataSpline(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class HEU_InputDataSplineContainer : HEU_InputData // TypeDefIndex: 78457
		{
			// Fields
			public List<HEU_InputDataSpline> _inputSplines; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataSplineContainer(); // 0x000000018C1F1430-0x000000018C1F14A8
		}
	
		// Constructors
		private HEU_InputInterfaceSpline(); // 0x0000000187250920-0x0000000187250930
	
		// Methods
		public void Initialize(HEU_InputInterfaceSplineSettings settings); // 0x000000018C1F4D44-0x000000018C1F4DB0
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x000000018C1F4DB0-0x000000018C1F4E44
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x000000018C1F4810-0x000000018C1F499C
		public HEU_InputDataSplineContainer GenerateSplineDataFromGameObject(GameObject inputObject); // 0x000000018C1F499C-0x000000018C1F4D44
		public bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputDataSpline inputSpline, Matrix4x4 localToWorld); // 0x000000018C1F4E44-0x000000018C1F4ECC
	}

	public class HEU_InputInterfaceTerrain : HEU_InputInterface // TypeDefIndex: 78460
	{
		// Nested types
		public class HEU_InputDataTerrain : HEU_InputData // TypeDefIndex: 78459
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
			public HEU_InputDataTerrain(); // 0x000000018C1F14A8-0x000000018C1F1508
		}
	
		// Constructors
		public HEU_InputInterfaceTerrain(); // 0x0000000187250920-0x0000000187250930
	
		// Methods
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x000000018C1F4F44-0x000000018C1F50E4
		private bool SetMaskLayer(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo); // 0x000000018C1F55C0-0x000000018C1F56C4
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x000000018C1F54C0-0x000000018C1F5558
		public bool CreateHeightFieldInputNode(HEU_SessionBase session, HEU_InputDataTerrain idt); // 0x000000018C1F4ECC-0x000000018C1F4F44
		public bool UploadHeightValuesWithTransform(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo volumeInfo); // 0x000000018C1F5E5C-0x000000018C1F5F48
		public bool UploadAlphaMaps(HEU_SessionBase session, HEU_InputDataTerrain idt, ref HAPI_VolumeInfo baseVolumeInfo, out bool bMaskSet); // 0x000000018C1F5910-0x000000018C1F5E5C
		public bool SetHeightFieldData(HEU_SessionBase session, int volumeNodeID, int partID, float[] heightValues, string heightFieldName, ref HAPI_VolumeInfo baseVolumeInfo); // 0x000000018C1F5558-0x000000018C1F55C0
		public bool SetTerrainDataAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData); // 0x000000018C1F56C4-0x000000018C1F5748
		public bool SetTerrainLayerAttributesToHeightField(HEU_SessionBase session, int geoNodeID, int partID, TerrainLayer terrainLayer); // 0x000000018C1F5748-0x000000018C1F57CC
		public void SetTreePrototypes(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData); // 0x000000018C1F57EC-0x000000018C1F5910
		public void SetTreeInstances(HEU_SessionBase session, int geoNodeID, int partID, TerrainData terrainData); // 0x000000018C1F57CC-0x000000018C1F57EC
		public HEU_InputDataTerrain GenerateTerrainDataFromGameObject(GameObject inputObject); // 0x000000018C1F50E4-0x000000018C1F54C0
	}

	[Serializable]
	public class HEU_InputInterfaceTilemapSettings // TypeDefIndex: 78461
	{
		// Fields
		public bool _createGroupsForTiles; // 0x10
		public bool _exportUnusedTiles; // 0x11
		public bool _applyTileColor; // 0x12
		public bool _applyTilemapOrientation; // 0x13
	
		// Constructors
		public HEU_InputInterfaceTilemapSettings(); // 0x0000000187250940-0x0000000187250950
	}

	public class HEU_InputInterfaceTilemap : HEU_InputInterface // TypeDefIndex: 78463
	{
		// Fields
		private HEU_InputInterfaceTilemapSettings settings; // 0x18
	
		// Nested types
		public class HEU_InputDataTilemap : HEU_InputData // TypeDefIndex: 78462
		{
			// Fields
			public Tilemap _tilemap; // 0x18
			public Transform _transform; // 0x20
	
			// Constructors
			public HEU_InputDataTilemap(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		private HEU_InputInterfaceTilemap(); // 0x0000000187250920-0x0000000187250930
	
		// Methods
		public void Initialize(HEU_InputInterfaceTilemapSettings settings); // 0x000000018C1F60F0-0x000000018C1F615C
		public override bool CreateInputNodeWithDataUpload(HEU_SessionBase session, int connectNodeID, GameObject inputObject, out int inputNodeID); // 0x000000018C1F5F48-0x000000018C1F6024
		public override bool IsThisInputObjectSupported(GameObject inputObject); // 0x000000018C1F615C-0x000000018C1F61F0
		private bool UploadData(HEU_SessionBase session, int inputNodeID, HEU_InputData inputData); // 0x000000018C1F61F0-0x000000018C1F74EC
		public HEU_InputDataTilemap GenerateTilemapDataFromGameObject(GameObject inputObject); // 0x000000018C1F6024-0x000000018C1F60F0
	}

	public static class HEU_InputMeshUtility // TypeDefIndex: 78464
	{
		// Methods
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem); // 0x000000018C1F7688-0x000000018C1F77E4
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, ref HAPI_PartInfo partInfo); // 0x000000018C1F7A20-0x000000018C1F7B7C
		public static bool SetMeshVertexAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3[] data, int[] indices, ref HAPI_PartInfo partInfo, bool bConvertToHoudiniCoordinateSystem); // 0x000000018C1F7B7C-0x000000018C1F7CD4
		public static bool SetMeshVertexFloatAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, float[] data, int[] indices, ref HAPI_PartInfo partInfo); // 0x000000018C1F7CD4-0x000000018C1F7E2C
		public static bool UploadMeshIntoHoudiniNode(HEU_SessionBase session, int assetNodeID, int objectID, int geoID, ref Mesh mesh); // 0x000000018C1F7E2C-0x000000018C1F8064
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3Int[] data, ref HAPI_PartInfo partInfo); // 0x000000018C1F77E4-0x000000018C1F7938
		public static bool SetMeshPointAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, string[] data, ref HAPI_PartInfo partInfo); // 0x000000018C1F7938-0x000000018C1F7A20
		public static bool SetMeshDetailAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, int tupleSize, Vector3 data, ref HAPI_PartInfo partInfo); // 0x000000018C1F7538-0x000000018C1F7688
	}

	public static class HEU_InputUtility // TypeDefIndex: 78465
	{
		// Fields
		private static List<HEU_InputInterface> _inputInterfaces; // 0x00
	
		// Constructors
		static HEU_InputUtility(); // 0x000000018C1F8C70-0x000000018C1F8CFC
	
		// Methods
		public static int GetHighestPriority(); // 0x000000018C1F83D4-0x000000018C1F8478
		public static void RegisterInputInterface(HEU_InputInterface inputInterface); // 0x000000018C1F8778-0x000000018C1F8978
		public static void UnregisterInputInterface(HEU_InputInterface inputInterface); // 0x000000018C1F8978-0x000000018C1F89E8
		public static HEU_InputInterface GetInputInterfaceByType(System.Type type); // 0x000000018C1F8478-0x000000018C1F85A4
		public static HEU_InputInterface GetInputInterface(GameObject inputObject); // 0x000000018C1F8670-0x000000018C1F8778
		internal static HEU_InputInterface GetInputInterface(HEU_InputObjectInfo inputObjectInfo); // 0x000000018C1F85A4-0x000000018C1F8670
		internal static bool CreateInputNodeWithMultiObjects(HEU_SessionBase session, int assetID, ref int connectMergeID, ref List<HEU_InputObjectInfo> inputObjects, ref List<int> inputObjectsConnectedAssetIDs, HEU_InputNode inputNode); // 0x000000018C1F8120-0x000000018C1F8278
		internal static bool CreateInputNodeWithMultiAssets(HEU_SessionBase session, HEU_HoudiniAsset parentAsset, ref int connectMergeID, ref List<HEU_InputHDAInfo> inputAssetInfos, bool bKeepWorldTransform, int mergeParentID = -1 /* Metadata: 0x0262B91C */); // 0x000000018C1F8064-0x000000018C1F8120
		internal static bool UploadInputObjectTransform(HEU_SessionBase session, HEU_InputObjectInfo inputObject, int inputNodeID, bool bKeepWorldTransform); // 0x000000018C1F89E8-0x000000018C1F8C70
		public static void GetChildrenTransforms(Transform transform, ref List<Matrix4x4> childTransforms); // 0x000000018C1F8278-0x000000018C1F83D4
	}

	public class HEU_Logger // TypeDefIndex: 78466
	{
		// Constructors
		public HEU_Logger(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void Log(string text); // 0x000000018C1F8FD8-0x000000018C1F9024
		public static void LogFormat(string text, params object[] args); // 0x000000018C1F8E34-0x000000018C1F8E90
		public static void LogWarning(string text); // 0x000000018C1F8F8C-0x000000018C1F8FD8
		public static void LogWarningFormat(string text, params object[] args); // 0x000000018C1F8F2C-0x000000018C1F8F8C
		public static void LogError(string text); // 0x000000018C1F8D6C-0x000000018C1F8DB8
		public static void LogErrorFormat(string text, params object[] args); // 0x000000018C1F8D0C-0x000000018C1F8D6C
		public static void LogError(Exception ex); // 0x000000018C1F8DB8-0x000000018C1F8E34
		public static void LogAssertion(string text); // 0x000000018C1F8D04-0x000000018C1F8D0C
		public static void LogAssertionFormat(string text, params object[] args); // 0x000000018C1F8CFC-0x000000018C1F8D04
		private static void LogToCookLogsIfOn(string text); // 0x000000018C1F8EEC-0x000000018C1F8F2C
		private static void LogToCookLogsIfOnFormat(string text, params object[] args); // 0x000000018C1F8E90-0x000000018C1F8EEC
	}

	public class HEU_MeshData // TypeDefIndex: 78467
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
		public HEU_MeshData(); // 0x000000018C1F9024-0x000000018C1F925C
	}

	[Serializable]
	public class HEU_MeshIndexFormat // TypeDefIndex: 78468
	{
		// Fields
		public IndexFormat _indexFormat; // 0x10
	
		// Constructors
		public HEU_MeshIndexFormat(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void CalculateIndexFormat(int numVertices); // 0x000000018C1F925C-0x000000018C1F92B8
		public void SetFormatForMesh(Mesh mesh); // 0x000000018C1F92B8-0x000000018C1F92DC
	}

	public enum HEU_PipelineType // TypeDefIndex: 78469
	{
		Unsupported = 0,
		BiRP = 1,
		URP = 2,
		HDRP = 3
	}

	public class HEU_RenderingPipelineDefines // TypeDefIndex: 78470
	{
		// Constructors
		static HEU_RenderingPipelineDefines(); // 0x000000018C1F9654-0x000000018C1F965C
		public HEU_RenderingPipelineDefines(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static void UpdateDefines(); // 0x000000018C1F9590-0x000000018C1F9654
		public static HEU_PipelineType GetPipeline(); // 0x000000018C1F93E0-0x000000018C1F94EC
		private static void AddDefine(string define); // 0x000000018C1F92DC-0x000000018C1F9380
		public static void RemoveDefine(string define); // 0x000000018C1F94EC-0x000000018C1F9590
		public static List<string> GetDefines(); // 0x000000018C1F9380-0x000000018C1F93E0
		public static void SetDefines(List<string> definesList); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class HEU_SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ISerializationCallbackReceiver // TypeDefIndex: 78471
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
	public class HEU_ShelfToolData // TypeDefIndex: 78473
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
		public enum ToolType // TypeDefIndex: 78472
		{
			GENERATOR = 0,
			OPERATOR_SINGLE = 1,
			OPERATOR_MULTI = 2,
			BATCH = 3
		}
	
		// Constructors
		public HEU_ShelfToolData(); // 0x000000018C1F965C-0x000000018C1F9700
	}

	[Serializable]
	public class HEU_Shelf // TypeDefIndex: 78474
	{
		// Fields
		public string _shelfName; // 0x10
		public string _shelfPath; // 0x18
		public bool _defaultShelf; // 0x20
		public List<HEU_ShelfToolData> _tools; // 0x28
	
		// Constructors
		public HEU_Shelf(); // 0x000000018C1FCB18-0x000000018C1FCB90
	}

	public class HEU_ShelfTools // TypeDefIndex: 78476
	{
		// Fields
		[SerializeField]
		private static List<HEU_Shelf> _shelves; // 0x00
		[SerializeField]
		private static bool _shelvesLoaded; // 0x08
		[SerializeField]
		private static int _currentSelectedShelf; // 0x0C
		public const string TARGET_ALL = "all"; // Metadata: 0x0262B925
		public const string TARGET_UNITY = "unity"; // Metadata: 0x0262B929
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 78475
		{
			// Fields
			public string shelfName; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddShelf_b__0(HEU_Shelf shelf); // 0x0000000185624DA0-0x0000000185624DD0
		}
	
		// Constructors
		public HEU_ShelfTools(); // 0x0000000186805BA0-0x0000000186805BB0
		static HEU_ShelfTools(); // 0x000000018C1FCA78-0x000000018C1FCB18
	
		// Methods
		public static bool AreShelvesLoaded(); // 0x000000018C1F98A0-0x000000018C1F98F0
		public static void SetReloadShelves(); // 0x000000018C1FC998-0x000000018C1FC9E8
		public static void ClearShelves(); // 0x000000018C1F98F0-0x000000018C1F9954
		public static int GetNumShelves(); // 0x000000018C1FA944-0x000000018C1FA9A0
		public static int GetCurrentShelfIndex(); // 0x000000018C1FA8F4-0x000000018C1FA944
		public static void SetCurrentShelf(int index); // 0x000000018C1FC944-0x000000018C1FC998
		public static HEU_Shelf GetShelf(int index); // 0x000000018C1FAB5C-0x000000018C1FAC00
		public static HEU_Shelf GetShelf(string shelfName); // 0x000000018C1FA9EC-0x000000018C1FAB5C
		public static string GetShelfStorageEntry(string shelfName, string shelfPath); // 0x000000018C1FA9A0-0x000000018C1FA9EC
		public static void GetSplitShelfEntry(string shelfEntry, out string shelfName, out string shelfPath); // 0x000000018C1FAC00-0x000000018C1FACE0
		public static void LoadShelves(); // 0x000000018C1FB294-0x000000018C1FB978
		public static bool LoadToolsFromDirectory(string folderPath, out List<HEU_ShelfToolData> tools); // 0x000000018C1FC3CC-0x000000018C1FC5EC
		public static HEU_ShelfToolData LoadToolFromJsonFile(string jsonFilePath); // 0x000000018C1FB978-0x000000018C1FBB14
		public static HEU_ShelfToolData LoadToolFromJsonString(string json, string jsonFilePath); // 0x000000018C1FBB14-0x000000018C1FC3CC
		public static HEU_Shelf AddShelf(string shelfName, string shelfPath); // 0x000000018C1F9700-0x000000018C1F98A0
		public static void RemoveShelf(int shelfIndex); // 0x000000018C1FC5EC-0x000000018C1FC71C
		public static void SaveShelf(); // 0x000000018C1FC71C-0x000000018C1FC944
		public static void ExecuteTool(int toolSlot); // 0x000000018C1FA64C-0x000000018C1FA8F4
		public static void ExecuteToolGenerator(string toolName, string toolPath, Vector3 targetPosition, Quaternion targetRotation, Vector3 targetScale); // 0x000000018C1F99B4-0x000000018C1F9B58
		public static bool IsValidInputMesh(GameObject gameObject); // 0x000000018C1FB104-0x000000018C1FB294
		public static bool IsValidInputHDA(GameObject gameObject); // 0x000000018C1FB074-0x000000018C1FB104
		private static bool ShouldUseHDA(GameObject[] gameObjectList); // 0x000000018C1FC9E8-0x000000018C1FCA78
		public static void ExecuteToolNoInput(string toolName, string toolPath); // 0x000000018C1F9B58-0x000000018C1F9C94
		public static void ExecuteToolOperatorSingle(string toolName, string toolPath, GameObject[] inputObjects); // 0x000000018C1FA0C8-0x000000018C1FA64C
		public static void ExecuteToolOperatorMultiple(string toolName, string toolPath, GameObject[] inputObjects); // 0x000000018C1F9C94-0x000000018C1FA0C8
		public static void ExecuteToolBatch(string toolName, string toolPath, GameObject[] batchObjects); // 0x000000018C1F9954-0x000000018C1F99B4
		public static string GetToolResourcePath(HEU_ShelfToolData tool, string inPath, string ext); // 0x000000018C1FAFB8-0x000000018C1FB074
		public static string GetToolIconPath(HEU_ShelfToolData tool, string inPath); // 0x000000018C1FAE50-0x000000018C1FAFB8
		public static string GetToolAssetPath(HEU_ShelfToolData tool, string inPath); // 0x000000018C1FACE0-0x000000018C1FAE50
	}

	public enum JSONNodeType // TypeDefIndex: 78477
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

	public enum JSONTextMode // TypeDefIndex: 78478
	{
		Compact = 0,
		Indent = 1
	}

	public abstract class JSONNode // TypeDefIndex: 78486
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
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		public virtual string Value { get; set; } // 0x000000018C1FF398-0x000000018C1FF3C4 0x0000000186805BA0-0x0000000186805BB0
		public virtual int Count { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public virtual bool IsNumber { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsString { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsBoolean { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsNull { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsArray { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool IsObject { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool Inline { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__40))] get; } // 0x000000018C1FF10C-0x000000018C1FF160 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine(typeof(_get_DeepChildren_d__42))] get; } // 0x000000018C1FF160-0x000000018C1FF1D0 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x000000018C1FF338-0x000000018C1FF398 
		public KeyEnumerator Keys { get; } // 0x000000018C1FF284-0x000000018C1FF338 
		public ValueEnumerator Values { get; } // 0x000000018C1FF284-0x000000018C1FF338 
		public virtual double AsDouble { get; set; } // 0x000000018C1FEFC8-0x000000018C1FF058 0x000000018C1FFD88-0x000000018C1FFDEC
		public virtual int AsInt { get; set; } // 0x000000018C1FF074-0x000000018C1FF090 0x000000018C1FFE00-0x000000018C1FFE18
		public virtual float AsFloat { get; set; } // 0x000000018C1FF058-0x000000018C1FF074 0x000000018C1FFDEC-0x000000018C1FFE00
		public virtual bool AsBool { get; set; } // 0x000000018C1FEF2C-0x000000018C1FEFC8 0x000000018C1FFD1C-0x000000018C1FFD88
		public virtual long AsLong { get; set; } // 0x000000018C1FF090-0x000000018C1FF0D0 0x000000018C1FFE18-0x000000018C1FFE48
		public virtual JSONArray AsArray { get; } // 0x000000018C1FEEF0-0x000000018C1FEF2C 
		public virtual JSONObject AsObject { get; } // 0x000000018C1FF0D0-0x000000018C1FF10C 
		internal static StringBuilder EscapeBuilder { get; } // 0x000000018C1FF1D0-0x000000018C1FF284 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 78480
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get; } // 0x00000001889F343C-0x00000001889F3444 
			public KeyValuePair<string, JSONNode> Current { get; } // 0x000000018C1FFFB8-0x000000018C20005C 
	
			// Nested types
			private enum Type // TypeDefIndex: 78479
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum); // 0x000000018C1FFF84-0x000000018C1FFFB8
			public Enumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000186F88940-0x0000000186F88990
	
			// Methods
			public bool MoveNext(); // 0x000000018C1FFF14-0x000000018C1FFF84
		}
	
		public struct ValueEnumerator // TypeDefIndex: 78481
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get; } // 0x000000018C2135E8-0x000000018C213628 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum); // 0x000000018C20A5C8-0x000000018C20A660
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018C20A4F4-0x000000018C20A594
			public ValueEnumerator(Enumerator aEnumerator); // 0x000000018C20A594-0x000000018C20A5C8
	
			// Methods
			public bool MoveNext(); // 0x000000018C20A4EC-0x000000018C20A4F4
			public ValueEnumerator GetEnumerator(); // 0x00000001872415C0-0x00000001872415F0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 78482
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get; } // 0x000000018C20A660-0x000000018C20A6A0 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum); // 0x000000018C20A5C8-0x000000018C20A660
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018C20A4F4-0x000000018C20A594
			public KeyEnumerator(Enumerator aEnumerator); // 0x000000018C20A594-0x000000018C20A5C8
	
			// Methods
			public bool MoveNext(); // 0x000000018C20A4EC-0x000000018C20A4F4
			public KeyEnumerator GetEnumerator(); // 0x00000001872415C0-0x00000001872415F0
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 78483
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get; } // 0x000000018C20A8F0-0x000000018C20A91C 
			object IEnumerator.Current { get; } // 0x000000018C20A81C-0x000000018C20A874 
	
			// Constructors
			internal LinqEnumerator(JSONNode aNode); // 0x000000018C20A874-0x000000018C20A8F0
	
			// Methods
			public bool MoveNext(); // 0x000000018C20A740-0x000000018C20A74C
			public void Dispose(); // 0x000000018C20A6A0-0x000000018C20A6DC
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator(); // 0x000000018C20A6DC-0x000000018C20A740
			public void Reset(); // 0x000000018C20A74C-0x000000018C20A7B8
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C20A7B8-0x000000018C20A81C
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__40 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 78484
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__40(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001870F8D80-0x00000001870F8D90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C212F34-0x000000018C212F80
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018C212EB0-0x000000018C212F2C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C212F2C-0x000000018C212F34
		}
	
		[CompilerGenerated]
		private sealed class _get_DeepChildren_d__42 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 78485
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONNode __4__this; // 0x28
			private IEnumerator<JSONNode> __7__wrap1; // 0x30
			private IEnumerator<JSONNode> __7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_DeepChildren_d__42(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018C213460-0x000000018C213550
			private bool MoveNext(); // 0x000000018C212F80-0x000000018C21337C
			private void __m__Finally1(); // 0x000000018C213550-0x000000018C21359C
			private void __m__Finally2(); // 0x000000018C21359C-0x000000018C2135E8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C213414-0x000000018C213460
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018C21337C-0x000000018C21340C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C21340C-0x000000018C213414
		}
	
		// Constructors
		protected JSONNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void Add(JSONNode aItem); // 0x000000018C1FCB90-0x000000018C1FCBD8
		public virtual JSONNode Remove(string aKey); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual JSONNode Remove(int aIndex); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual JSONNode Remove(JSONNode aNode); // 0x000000018459BB50-0x000000018459BB60
		public override string ToString(); // 0x000000018C1FE370-0x000000018C1FE3F8
		public virtual string ToString(int aIndent); // 0x000000018C1FE3F8-0x000000018C1FE488
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s); // 0x000000018C1FF4FC-0x000000018C1FF55C
		public static implicit operator string(JSONNode d); // 0x000000018C1FF9D4-0x000000018C1FFA14
		public static implicit operator JSONNode(double n); // 0x000000018C1FFB00-0x000000018C1FFB50
		public static implicit operator double(JSONNode d); // 0x000000018C1FF4BC-0x000000018C1FF4FC
		public static implicit operator JSONNode(float n); // 0x000000018C1FFA14-0x000000018C1FFA6C
		public static implicit operator float(JSONNode d); // 0x000000018C1FFC90-0x000000018C1FFCD0
		public static implicit operator JSONNode(int n); // 0x000000018C1FF5D4-0x000000018C1FF624
		public static implicit operator int(JSONNode d); // 0x000000018C1FF88C-0x000000018C1FF8CC
		public static implicit operator JSONNode(long n); // 0x000000018C1FF66C-0x000000018C1FF72C
		public static implicit operator long(JSONNode d); // 0x000000018C1FFC50-0x000000018C1FFC90
		public static implicit operator JSONNode(bool b); // 0x000000018C1FF624-0x000000018C1FF66C
		public static implicit operator bool(JSONNode d); // 0x000000018C1FFA88-0x000000018C1FFAC8
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue); // 0x000000018C1FFAC8-0x000000018C1FFB00
		public static bool operator ==(JSONNode a, object b); // 0x000000018C1FF3C4-0x000000018C1FF4BC
		public static bool operator !=(JSONNode a, object b); // 0x000000018C1FFD08-0x000000018C1FFD1C
		public override bool Equals(object obj); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public override int GetHashCode(); // 0x0000000187235B50-0x0000000187235B60
		internal static string Escape(string aText); // 0x000000018C1FCBD8-0x000000018C1FCE40
		private static JSONNode ParseElement(string token, bool quoted); // 0x000000018C1FCEC4-0x000000018C1FD01C
		public static JSONNode Parse(string aJSON); // 0x000000018C1FD01C-0x000000018C1FD5AC
		private static JSONNode GetContainer(JSONContainerType aType); // 0x000000018C1FCE40-0x000000018C1FCEC4
		public static implicit operator JSONNode(Vector2 aVec); // 0x000000018C1FF72C-0x000000018C1FF7C8
		public static implicit operator JSONNode(Vector3 aVec); // 0x000000018C1FF7C8-0x000000018C1FF88C
		public static implicit operator JSONNode(Vector4 aVec); // 0x000000018C1FF55C-0x000000018C1FF5D4
		public static implicit operator JSONNode(Quaternion aRot); // 0x000000018C1FFBBC-0x000000018C1FFC34
		public static implicit operator JSONNode(Rect aRect); // 0x000000018C1FF95C-0x000000018C1FF9D4
		public static implicit operator JSONNode(RectOffset aRect); // 0x000000018C1FFB50-0x000000018C1FFBBC
		public static implicit operator Vector2(JSONNode aNode); // 0x000000018C1FFC34-0x000000018C1FFC50
		public static implicit operator Vector3(JSONNode aNode); // 0x000000018C1FFCD0-0x000000018C1FFD08
		public static implicit operator Vector4(JSONNode aNode); // 0x000000018C1FF92C-0x000000018C1FF95C
		public static implicit operator Quaternion(JSONNode aNode); // 0x000000018C1FF8CC-0x000000018C1FF8FC
		public static implicit operator Rect(JSONNode aNode); // 0x000000018C1FF8FC-0x000000018C1FF92C
		public static implicit operator RectOffset(JSONNode aNode); // 0x000000018C1FFA6C-0x000000018C1FFA88
		public Vector2 ReadVector2(Vector2 aDefault); // 0x000000018C1FDD04-0x000000018C1FDDEC
		public Vector2 ReadVector2(string aXName, string aYName); // 0x000000018C1FDDEC-0x000000018C1FDE8C
		public Vector2 ReadVector2(); // 0x000000018C1FDE8C-0x000000018C1FDEA4
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x" /* Metadata: 0x0262B93A */, string aYName = "y" /* Metadata: 0x0262B93C */); // 0x000000018C1FEAEC-0x000000018C1FEBE4
		public Vector3 ReadVector3(Vector3 aDefault); // 0x000000018C1FDEA4-0x000000018C1FE020
		public Vector3 ReadVector3(string aXName, string aYName, string aZName); // 0x000000018C1FE020-0x000000018C1FE108
		public Vector3 ReadVector3(); // 0x000000018C1FE108-0x000000018C1FE158
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x" /* Metadata: 0x0262B93E */, string aYName = "y" /* Metadata: 0x0262B940 */, string aZName = "z" /* Metadata: 0x0262B942 */); // 0x000000018C1FEBE4-0x000000018C1FED24
		public Vector4 ReadVector4(Vector4 aDefault); // 0x000000018C1FE158-0x000000018C1FE334
		public Vector4 ReadVector4(); // 0x000000018C1FE334-0x000000018C1FE370
		public JSONNode WriteVector4(Vector4 aVec); // 0x000000018C1FED24-0x000000018C1FEEF0
		public Quaternion ReadQuaternion(Quaternion aDefault); // 0x000000018C1FD69C-0x000000018C1FD878
		public Quaternion ReadQuaternion(); // 0x000000018C1FD660-0x000000018C1FD69C
		public JSONNode WriteQuaternion(Quaternion aRot); // 0x000000018C1FE51C-0x000000018C1FE6E8
		public Rect ReadRect(Rect aDefault); // 0x000000018C1FDB28-0x000000018C1FDD04
		public Rect ReadRect(); // 0x000000018C1FDAF4-0x000000018C1FDB28
		public JSONNode WriteRect(Rect aRect); // 0x000000018C1FE920-0x000000018C1FEAEC
		public RectOffset ReadRectOffset(RectOffset aDefault); // 0x000000018C1FD878-0x000000018C1FDA8C
		public RectOffset ReadRectOffset(); // 0x000000018C1FDA8C-0x000000018C1FDAF4
		public JSONNode WriteRectOffset(RectOffset aRect); // 0x000000018C1FE6E8-0x000000018C1FE920
		public Matrix4x4 ReadMatrix(); // 0x000000018C1FD5AC-0x000000018C1FD660
		public JSONNode WriteMatrix(Matrix4x4 aMatrix); // 0x000000018C1FE488-0x000000018C1FE51C
	}

	public class JSONArray : JSONNode // TypeDefIndex: 78488
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public override JSONNodeType Tag { get; } // 0x00000001872328C0-0x00000001872328D0 
		public override bool IsArray { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C208470-0x000000018C208510 0x000000018C208510-0x000000018C2085E4
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018C208410-0x000000018C208470 0x000000018C2085E4-0x000000018C20866C
		public override int Count { get; } // 0x000000018C2083D0-0x000000018C208410 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__22))] get; } // 0x000000018C208360-0x000000018C2083D0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_Children_d__22 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 78487
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONArray __4__this; // 0x28
			private List<JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__22(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018C2129EC-0x000000018C212A64
			private bool MoveNext(); // 0x000000018C2126B8-0x000000018C212908
			private void __m__Finally1(); // 0x000000018C212A64-0x000000018C212AA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C2129A0-0x000000018C2129EC
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018C212908-0x000000018C212998
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C212998-0x000000018C2129A0
		}
	
		// Constructors
		public JSONArray(); // 0x000000018C2082E8-0x000000018C208360
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x000000018C207FFC-0x000000018C20808C
		public override void Add(string aKey, JSONNode aItem); // 0x000000018C207F74-0x000000018C207FFC
		public override JSONNode Remove(int aIndex); // 0x000000018C20808C-0x000000018C208130
		public override JSONNode Remove(JSONNode aNode); // 0x000000018C208130-0x000000018C208188
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C208188-0x000000018C2082E8
	}

	public class JSONObject : JSONNode // TypeDefIndex: 78491
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public override JSONNodeType Tag { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public override bool IsObject { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018C20A0B4-0x000000018C20A174 0x000000018C20A200-0x000000018C20A2E8
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C20A174-0x000000018C20A200 0x000000018C20A2E8-0x000000018C20A3D4
		public override int Count { get; } // 0x000000018C20A074-0x000000018C20A0B4 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine(typeof(_get_Children_d__23))] get; } // 0x000000018C20A004-0x000000018C20A074 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 78489
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Remove_b__0(KeyValuePair<string, JSONNode> k); // 0x000000018C211F68-0x000000018C211FB0
		}
	
		[CompilerGenerated]
		private sealed class _get_Children_d__23 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 78490
		{
			// Fields
			private int __1__state; // 0x10
			private JSONNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JSONObject __4__this; // 0x28
			private Dictionary<string, JSONNode> __7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<HoudiniEngineUnity.JSONNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_Children_d__23(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018C212DFC-0x000000018C212E74
			private bool MoveNext(); // 0x000000018C212AA0-0x000000018C212D18
			private void __m__Finally1(); // 0x000000018C212E74-0x000000018C212EB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C212DB0-0x000000018C212DFC
			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x000000018C212D18-0x000000018C212DA8
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018C212DA8-0x000000018C212DB0
		}
	
		// Constructors
		public JSONObject(); // 0x000000018C209F8C-0x000000018C20A004
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x000000018C209884-0x000000018C209928
		public override void Add(string aKey, JSONNode aItem); // 0x000000018C209720-0x000000018C209884
		public override JSONNode Remove(string aKey); // 0x000000018C209B94-0x000000018C209C4C
		public override JSONNode Remove(int aIndex); // 0x000000018C209928-0x000000018C2099E8
		public override JSONNode Remove(JSONNode aNode); // 0x000000018C2099E8-0x000000018C209B94
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C209C4C-0x000000018C209F8C
	}

	public class JSONString : JSONNode // TypeDefIndex: 78492
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x00000001872396E0-0x00000001872396F0 
		public override bool IsString { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public JSONString(string aData); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C20A478-0x000000018C20A4E4
		public override bool Equals(object obj); // 0x000000018C20A3D4-0x000000018C20A478
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
	}

	public class JSONNumber : JSONNode // TypeDefIndex: 78493
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x00000001845BA780-0x00000001845BA790 
		public override bool IsNumber { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x000000018C209654-0x000000018C2096A0 0x000000018C2096A0-0x000000018C209720
		public override double AsDouble { get; set; } // 0x0000000187244520-0x0000000187244530 0x0000000187247AC0-0x0000000187247AD0
		public override long AsLong { get; set; } // 0x0000000187250990-0x00000001872509A0 0x00000001872509A0-0x00000001872509B0
	
		// Constructors
		public JSONNumber(double aData); // 0x0000000187247AC0-0x0000000187247AD0
		public JSONNumber(string aData); // 0x000000018C20877C-0x000000018C208790
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C209620-0x000000018C209654
		private static bool IsNumeric(object value); // 0x000000018C2094D8-0x000000018C209620
		public override bool Equals(object obj); // 0x000000018C2093F8-0x000000018C2094CC
		public override int GetHashCode(); // 0x000000018C2094CC-0x000000018C2094D8
	}

	public class JSONBool : JSONNode // TypeDefIndex: 78494
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000187239C80-0x0000000187239C90 
		public override bool IsBoolean { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x000000018C208790-0x000000018C2087E4 0x000000018C2087E4-0x000000018C208848
		public override bool AsBool { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public JSONBool(bool aData); // 0x0000000182A819C0-0x0000000182A819D0
		public JSONBool(string aData); // 0x000000018C20877C-0x000000018C208790
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C208710-0x000000018C20877C
		public override bool Equals(object obj); // 0x000000018C20866C-0x000000018C2086C8
		public override int GetHashCode(); // 0x000000018C2086C8-0x000000018C208710
	}

	public class JSONNull : JSONNode // TypeDefIndex: 78495
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000187239C70-0x0000000187239C80 
		public override bool IsNull { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string Value { get; set; } // 0x000000018C2093CC-0x000000018C2093F8 0x0000000186805BA0-0x0000000186805BB0
		public override bool AsBool { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
	
		// Constructors
		private JSONNull(); // 0x0000000186805BA0-0x0000000186805BB0
		static JSONNull(); // 0x000000018C209354-0x000000018C2093CC
	
		// Methods
		public static JSONNull CreateOrGet(); // 0x000000018C209248-0x000000018C2092B4
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		public override bool Equals(object obj); // 0x000000018C2092B4-0x000000018C20930C
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C20930C-0x000000018C209354
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 78496
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000187239C90-0x0000000187239CA0 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018C208D60-0x000000018C208DC0 0x000000018C209110-0x000000018C2091A4
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018C208DC0-0x000000018C208E30 0x000000018C2091A4-0x000000018C209248
		public override int AsInt { get; set; } // 0x000000018C208B90-0x000000018C208BFC 0x000000018C208F9C-0x000000018C209014
		public override float AsFloat { get; set; } // 0x000000018C208B24-0x000000018C208B90 0x000000018C208F24-0x000000018C208F9C
		public override double AsDouble { get; set; } // 0x000000018C208AB8-0x000000018C208B24 0x000000018C208EB0-0x000000018C208F24
		public override long AsLong { get; set; } // 0x000000018C208BFC-0x000000018C208CE8 0x000000018C209014-0x000000018C209110
		public override bool AsBool { get; set; } // 0x000000018C208A50-0x000000018C208AB8 0x000000018C208E40-0x000000018C208EB0
		public override JSONArray AsArray { get; } // 0x000000018C2089D8-0x000000018C208A50 
		public override JSONObject AsObject { get; } // 0x000000018C208CE8-0x000000018C208D60 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x0000000186183450-0x0000000186183480
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x0000000185381AC0-0x0000000185381AF0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000187250970-0x0000000187250990
		private T Set<T>(T aVal)
			where T : JSONNode;
		public override void Add(JSONNode aItem); // 0x000000018C2088EC-0x000000018C208980
		public override void Add(string aKey, JSONNode aItem); // 0x000000018C208848-0x000000018C2088EC
		public static bool operator ==(JSONLazyCreator a, object b); // 0x000000018C208980-0x000000018C208990
		public static bool operator !=(JSONLazyCreator a, object b); // 0x000000018C208E30-0x000000018C208E40
		public override bool Equals(object obj); // 0x000000018C208980-0x000000018C208990
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018C208990-0x000000018C2089D8
	}

	public static class JSON // TypeDefIndex: 78497
	{
		// Methods
		public static JSONNode Parse(string aJSON); // 0x000000018C20A4E4-0x000000018C20A4EC
	}

	public enum JSONContainerType // TypeDefIndex: 78498
	{
		Array = 0,
		Object = 1
	}

	public static class HEU_TerrainUtility // TypeDefIndex: 78499
	{
		// Methods
		public static bool GenerateTerrainFromVolume(HEU_SessionBase session, ref HAPI_VolumeInfo volumeInfo, int geoID, int partID, GameObject gameObject, ref TerrainData terrainData, out Vector3 volumePositionOffset, ref Terrain terrain, string bakedMaterialPath); // 0x000000018C201030-0x000000018C20197C
		public static void SetTerrainMaterial(Terrain terrain, string specifiedMaterialName, string bakedMaterialPath = "" /* Metadata: 0x0262B949 */); // 0x000000018C203A94-0x000000018C203C08
		public static string GetDefaultTerrainShaderName(); // 0x000000018C201A6C-0x000000018C201AEC
		public static string GetDefaultTerrainMaterialPath(); // 0x000000018C2019EC-0x000000018C201A6C
		public static float[] GetNormalizedHeightmapFromPartWithMinMax(HEU_SessionBase session, int geoID, int partID, int heightMapWidth, int heightMapHeight, ref float minHeight, ref float maxHeight, ref float heightRange, bool bUseHeightRangeOverride); // 0x000000018C201ED0-0x000000018C201F50
		public static int[,] GetDetailMapFromPart(HEU_SessionBase session, int geoID, int partID, out int detailResolution); // 0x000000018C201AEC-0x000000018C201B80
		public static bool GetHeightmapFromPart(HEU_SessionBase session, int xLength, int yLength, int geoID, int partID, ref float[] heightValues, ref float minHeight, ref float maxHeight); // 0x000000018C201D48-0x000000018C201ED0
		public static float[,] ConvertHeightMapHoudiniToUnity(int heightMapWidth, int heightMapHeight, float[] heightValues); // 0x000000018C200F54-0x000000018C201030
		public static float[,,] ConvertHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, List<float[]> heightFields); // 0x000000018C200E10-0x000000018C200F54
		public static float[,,] AppendConvertedHeightFieldToAlphaMap(int heightMapWidth, int heightMapHeight, float[,,] existingAlphaMaps, List<float[]> heightFields, float[] strengths, List<int> alphaMapIndices); // 0x000000018C200344-0x000000018C20053C
		public static Vector3 GetVolumePositionOffset(HEU_SessionBase session, int geoID, int partID, Vector3 volumePosition, float terrainSizeX, float heightMapSize, int mapWidth, int mapHeight, float minHeight); // 0x000000018C20230C-0x000000018C202400
		public static List<HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HEU_SessionBase session, int geoID, int partID); // 0x000000018C202218-0x000000018C20230C
		public static void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, ref HEU_VolumeScatterTrees scatterTrees, bool throwWarningIfNoTileAttribute); // 0x000000018C202B5C-0x000000018C2037E8
		public static void ApplyScatterTrees(TerrainData terrainData, HEU_VolumeScatterTrees scatterTrees, int tileIndex); // 0x000000018C200920-0x000000018C200E10
		public static void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailPrototype detailPrototype); // 0x000000018C202718-0x000000018C202B5C
		public static void PopulateDetailProperties(HEU_SessionBase session, int geoID, int partID, ref HEU_DetailProperties detailProperties); // 0x000000018C202400-0x000000018C202718
		public static void ApplyDetailLayers(Terrain terrain, TerrainData terrainData, HEU_DetailProperties detailProperties, List<HEU_DetailPrototype> heuDetailPrototypes, List<int[,]> convertedDetailMaps); // 0x000000018C20053C-0x000000018C200920
		private static int GetTerrainLayerIndexByName(string layerName, TerrainLayer[] terrainLayers); // 0x000000018C202018-0x000000018C202174
		public static int GetTerrainLayerIndex(TerrainLayer layer, TerrainLayer[] terrainLayers); // 0x000000018C202174-0x000000018C202218
		public static bool VolumeLayerHasAttributes(HEU_SessionBase session, int geoID, int partID); // 0x000000018C203C08-0x000000018C203D98
		public static HFLayerType GetHeightfieldLayerType(HEU_SessionBase session, int geoID, int partID, string volumeName); // 0x000000018C201BF8-0x000000018C201D48
		public static float GetHeightRangeFromHeightfield(HEU_SessionBase session, int geoID, int partID); // 0x000000018C201B80-0x000000018C201BF8
		public static string GetTerrainDataExportPathFromHeightfieldAttribute(HEU_SessionBase session, int geoID, int partID); // 0x000000018C201F50-0x000000018C202018
		public static float[] ResampleData(float[] data, int oldWidth, int oldHeight, int newWidth, int newHeight); // 0x000000018C2037E8-0x000000018C203A94
		public static bool GetAttributeTile(HEU_SessionBase session, int geoID, int partID, out int outTileAttribute); // 0x000000018C20197C-0x000000018C2019EC
	}

	public interface IEquivable<T> // TypeDefIndex: 78500
	{
		// Methods
		bool IsEquivalentTo(T other);
	}

	public interface IEquivableWrapperClass<T> : IEquivable<T> // TypeDefIndex: 78501
		where T : class
	{
		// Methods
		bool IsNull();
	}

	internal class HEU_TestHelpers // TypeDefIndex: 78504
	{
		// Nested types
		public class RequireStruct<T> // TypeDefIndex: 78502
			where T : struct
		{
			// Constructors
			public RequireStruct();
		}
	
		public class RequireClass<T> // TypeDefIndex: 78503
			where T : class
		{
			// Constructors
			public RequireClass();
		}
	
		// Constructors
		public HEU_TestHelpers(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool AssertTrueLogEquivalent<T>(T a, T b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B94A */, string optional2 = "" /* Metadata: 0x0262B94B */, string optional3 = "" /* Metadata: 0x0262B94C */, RequireStruct<T> _ = null)
			where T : struct;
		public static bool AssertTrueLogEquivalent(GameObject a, GameObject b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B94D */, string optional2 = "" /* Metadata: 0x0262B94E */, string optional3 = "" /* Metadata: 0x0262B94F */); // 0x000000018C203F24-0x000000018C204024
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T> a, IEquivable<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B950 */, string optional2 = "" /* Metadata: 0x0262B951 */, string optional3 = "" /* Metadata: 0x0262B952 */);
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B953 */, string optional2 = "" /* Metadata: 0x0262B954 */, string optional3 = "" /* Metadata: 0x0262B955 */)
			where T : class;
		public static bool AssertTrueLogEquivalent(string a, string b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B956 */, string optional2 = "" /* Metadata: 0x0262B957 */, string optional3 = "" /* Metadata: 0x0262B958 */); // 0x000000018C204024-0x000000018C2040FC
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B959 */, string optional2 = "" /* Metadata: 0x0262B95A */, string optional3 = "" /* Metadata: 0x0262B95B */, RequireStruct<T> _ = null)
			where T : struct;
		public static bool AssertTrueLogEquivalent<T>(List<T> a, List<T> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B95C */, string optional2 = "" /* Metadata: 0x0262B95D */, string optional3 = "" /* Metadata: 0x0262B95E */, RequireClass<T> _ = null)
			where T : class;
		public static bool AssertTrueLogEquivalent<T>(List<IEquivable<T>> a, List<IEquivable<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B95F */, string optional2 = "" /* Metadata: 0x0262B960 */, string optional3 = "" /* Metadata: 0x0262B961 */);
		public static bool AssertTrueLogEquivalent<T>(List<IEquivableWrapperClass<T>> a, List<IEquivableWrapperClass<T>> b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B962 */, string optional2 = "" /* Metadata: 0x0262B963 */, string optional3 = "" /* Metadata: 0x0262B964 */)
			where T : class;
		public static bool AssertTrueLogEquivalent<T>(T[] a, T[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B965 */, string optional2 = "" /* Metadata: 0x0262B966 */, string optional3 = "" /* Metadata: 0x0262B967 */)
			where T : struct;
		public static bool AssertTrueLogEquivalent(string[] a, string[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B968 */, string optional2 = "" /* Metadata: 0x0262B969 */, string optional3 = "" /* Metadata: 0x0262B96A */); // 0x000000018C203D98-0x000000018C203F24
		public static bool AssertTrueLogEquivalent<T>(IEquivable<T>[] a, IEquivable<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B96B */, string optional2 = "" /* Metadata: 0x0262B96C */, string optional3 = "" /* Metadata: 0x0262B96D */);
		public static bool AssertTrueLogEquivalent<T>(IEquivableWrapperClass<T>[] a, IEquivableWrapperClass<T>[] b, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B96E */, string optional2 = "" /* Metadata: 0x0262B96F */, string optional3 = "" /* Metadata: 0x0262B970 */)
			where T : class;
		public static void PrintTestLogAndSetResult(bool expression, ref bool result, string header, string subject, string optional1 = "" /* Metadata: 0x0262B971 */, string optional2 = "" /* Metadata: 0x0262B972 */, string optional3 = "" /* Metadata: 0x0262B973 */); // 0x000000018C2040FC-0x000000018C204240
		public static bool ShouldBeTested<T>(T a, T b, ref bool bResult, string header = "" /* Metadata: 0x0262B974 */, string subject = "" /* Metadata: 0x0262B975 */)
			where T : class;
		public static bool ShouldBeTested(GameObject a, GameObject b, ref bool bResult, string header = "" /* Metadata: 0x0262B976 */, string subject = "" /* Metadata: 0x0262B977 */); // 0x000000018C204240-0x000000018C204488
		public static bool ShouldBeTested<T>(IEquivable<T> a, IEquivable<T> b, ref bool bResult, string header = "" /* Metadata: 0x0262B978 */, string subject = "" /* Metadata: 0x0262B979 */);
		public static bool ShouldBeTested<T>(IEquivableWrapperClass<T> a, IEquivableWrapperClass<T> b, ref bool bResult, string header = "" /* Metadata: 0x0262B97A */, string subject = "" /* Metadata: 0x0262B97B */)
			where T : class;
		private static bool ShouldBeTested<T>(List<T> a, List<T> b, ref bool bResult, string header = "" /* Metadata: 0x0262B97C */, string subject = "" /* Metadata: 0x0262B97D */);
		public static bool ShouldBeTested<T>(T[] a, T[] b, ref bool bResult, string header = "" /* Metadata: 0x0262B97E */, string subject = "" /* Metadata: 0x0262B97F */);
		public static bool ShouldBeTested(string a, string b, ref bool bResult, string header = "" /* Metadata: 0x0262B980 */, string subject = "" /* Metadata: 0x0262B981 */); // 0x000000018C204488-0x000000018C20451C
		public static bool TestOutputObjectEquivalence(GameObject a, GameObject b); // 0x000000018C20451C-0x000000018C204B74
	}

	public class Test_HAPI_AssetInfo : IEquivable<Test_HAPI_AssetInfo> // TypeDefIndex: 78505
	{
		// Fields
		public HAPI_AssetInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AssetInfo(HAPI_AssetInfo self); // 0x0000000187247A30-0x0000000187247A50
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AssetInfo other); // 0x000000018C20C020-0x000000018C20C1FC
	}

	public static class Test_HAPI_AssetInfo_Extensions // TypeDefIndex: 78506
	{
		// Extension methods
		public static Test_HAPI_AssetInfo ToTestObject(this HAPI_AssetInfo self); // 0x000000018C20BFBC-0x000000018C20C020
	}

	public class Test_HAPI_NodeInfo : IEquivable<Test_HAPI_NodeInfo> // TypeDefIndex: 78507
	{
		// Fields
		public HAPI_NodeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_NodeInfo(HAPI_NodeInfo self); // 0x00000001872509D0-0x0000000187250A00
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_NodeInfo other); // 0x000000018C20C638-0x000000018C20C840
	}

	public static class Test_HAPI_NodeInfo_Extensions // TypeDefIndex: 78508
	{
		// Extension methods
		public static Test_HAPI_NodeInfo ToTestObject(this HAPI_NodeInfo self); // 0x000000018C20C5C8-0x000000018C20C638
	}

	public class Test_HAPI_ObjectInfo : IEquivable<Test_HAPI_ObjectInfo> // TypeDefIndex: 78509
	{
		// Fields
		public HAPI_ObjectInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ObjectInfo(HAPI_ObjectInfo self); // 0x0000000187247AA0-0x0000000187247AC0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ObjectInfo other); // 0x000000018C20C8A0-0x000000018C20C9CC
	}

	public static class Test_HAPI_ObjectInfo_Extensions // TypeDefIndex: 78510
	{
		// Extension methods
		public static Test_HAPI_ObjectInfo ToTestObject(this HAPI_ObjectInfo self); // 0x000000018C20C840-0x000000018C20C8A0
	}

	public class Test_HAPI_Transform : IEquivable<Test_HAPI_Transform> // TypeDefIndex: 78511
	{
		// Fields
		public HAPI_Transform self; // 0x10
	
		// Constructors
		public Test_HAPI_Transform(HAPI_Transform self); // 0x000000018C20D198-0x000000018C20D1BC
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_Transform other); // 0x000000018C20D23C-0x000000018C20D2D0
	}

	public static class Test_HAPI_Transform_Extensions // TypeDefIndex: 78512
	{
		// Extension methods
		public static Test_HAPI_Transform ToTestObject(this HAPI_Transform self); // 0x000000018C20D1BC-0x000000018C20D23C
	}

	public class Test_HAPI_GeoInfo : IEquivable<Test_HAPI_GeoInfo> // TypeDefIndex: 78513
	{
		// Fields
		public HAPI_GeoInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_GeoInfo(HAPI_GeoInfo self); // 0x0000000187247A10-0x0000000187247A30
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_GeoInfo other); // 0x000000018C20C3C0-0x000000018C20C5C8
	}

	public static class Test_HAPI_GeoInfo_Extensions // TypeDefIndex: 78514
	{
		// Extension methods
		public static Test_HAPI_GeoInfo ToTestObject(this HAPI_GeoInfo self); // 0x000000018C20C360-0x000000018C20C3C0
	}

	public class Test_HAPI_AttributeInfo : IEquivable<Test_HAPI_AttributeInfo> // TypeDefIndex: 78515
	{
		// Fields
		public HAPI_AttributeInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_AttributeInfo(HAPI_AttributeInfo self); // 0x00000001872509B0-0x00000001872509D0
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_AttributeInfo other); // 0x000000018C20C258-0x000000018C20C360
	}

	public static class Test_HAPI_AttributeInfo_Extensions // TypeDefIndex: 78516
	{
		// Extension methods
		public static Test_HAPI_AttributeInfo ToTestObject(this HAPI_AttributeInfo self); // 0x000000018C20C1FC-0x000000018C20C258
	}

	public class Test_HAPI_TransformEuler : IEquivable<Test_HAPI_TransformEuler> // TypeDefIndex: 78517
	{
		// Fields
		public HAPI_TransformEuler self; // 0x10
	
		// Constructors
		public Test_HAPI_TransformEuler(HAPI_TransformEuler self); // 0x000000018C20D198-0x000000018C20D1BC
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_TransformEuler other); // 0x000000018C20D0C0-0x000000018C20D198
	}

	public static class Test_HAPI_TransformEuler_Extensions // TypeDefIndex: 78518
	{
		// Extension methods
		public static Test_HAPI_TransformEuler ToTestObject(this HAPI_TransformEuler self); // 0x000000018C20D040-0x000000018C20D0C0
	}

	public class Test_HAPI_ParmInfo : IEquivable<Test_HAPI_ParmInfo> // TypeDefIndex: 78519
	{
		// Fields
		public HAPI_ParmInfo self; // 0x10
	
		// Constructors
		public Test_HAPI_ParmInfo(HAPI_ParmInfo self); // 0x0000000187250A00-0x0000000187250A60
	
		// Methods
		public bool IsEquivalentTo(Test_HAPI_ParmInfo other); // 0x000000018C20CA6C-0x000000018C20D040
	}

	public static class Test_HAPI_ParmInfo_Extensions // TypeDefIndex: 78520
	{
		// Extension methods
		public static Test_HAPI_ParmInfo ToTestObject(this HAPI_ParmInfo self); // 0x000000018C20C9CC-0x000000018C20CA6C
	}

	public class Test_LODGroup : IEquivableWrapperClass<Test_LODGroup> // TypeDefIndex: 78521
	{
		// Fields
		public LODGroup self; // 0x10
	
		// Constructors
		public Test_LODGroup(LODGroup self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20D75C-0x000000018C20D7AC
		public bool IsEquivalentTo(Test_LODGroup other); // 0x000000018C20D540-0x000000018C20D75C
	}

	public static class Test_LODGroup_Extensions // TypeDefIndex: 78523
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78522
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<LODGroup, Test_LODGroup> __9__1_0; // 0x08
			public static Converter<LODGroup, Test_LODGroup> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C21258C-0x000000018C2125F0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_LODGroup _ToTestObject_b__1_0(LODGroup lod); // 0x000000018C21136C-0x000000018C2113CC
			internal Test_LODGroup _ToTestObject_b__2_0(LODGroup lod); // 0x000000018C21190C-0x000000018C21196C
		}
	
		// Extension methods
		public static Test_LODGroup ToTestObject(this LODGroup self); // 0x000000018C20D2D0-0x000000018C20D330
		public static Test_LODGroup[] ToTestObject(this LODGroup[] self); // 0x000000018C20D43C-0x000000018C20D540
		public static List<Test_LODGroup> ToTestObject(this List<LODGroup> self); // 0x000000018C20D330-0x000000018C20D43C
	}

	public class Test_Transform : IEquivableWrapperClass<Test_Transform> // TypeDefIndex: 78524
	{
		// Fields
		public Transform self; // 0x10
	
		// Constructors
		public Test_Transform(Transform self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C210D9C-0x000000018C210DEC
		public bool IsEquivalentTo(Test_Transform other); // 0x000000018C210C18-0x000000018C210D9C
	}

	public static class Test_Transform_Extensions // TypeDefIndex: 78526
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78525
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Transform, Test_Transform> __9__1_0; // 0x08
			public static Converter<Transform, Test_Transform> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212078-0x000000018C2120DC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Transform _ToTestObject_b__1_0(Transform lod); // 0x000000018C21142C-0x000000018C21148C
			internal Test_Transform _ToTestObject_b__2_0(Transform lod); // 0x000000018C211DE8-0x000000018C211E48
		}
	
		// Extension methods
		public static Test_Transform ToTestObject(this Transform self); // 0x000000018C2109A8-0x000000018C210A08
		public static Test_Transform[] ToTestObject(this Transform[] self); // 0x000000018C210B14-0x000000018C210C18
		public static List<Test_Transform> ToTestObject(this List<Transform> self); // 0x000000018C210A08-0x000000018C210B14
	}

	public class Test_Material : IEquivableWrapperClass<Test_Material> // TypeDefIndex: 78527
	{
		// Fields
		public Material self; // 0x10
	
		// Constructors
		public Test_Material(Material self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20DCF0-0x000000018C20DD40
		public bool IsEquivalentTo(Test_Material other); // 0x000000018C20DB1C-0x000000018C20DCF0
	}

	public static class Test_Material_Extensions // TypeDefIndex: 78529
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78528
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Material, Test_Material> __9__1_0; // 0x08
			public static Converter<Material, Test_Material> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C2120DC-0x000000018C212140
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Material _ToTestObject_b__1_0(Material lod); // 0x000000018C21154C-0x000000018C2115AC
			internal Test_Material _ToTestObject_b__2_0(Material lod); // 0x000000018C2119CC-0x000000018C211A2C
		}
	
		// Extension methods
		public static Test_Material ToTestObject(this Material self); // 0x000000018C20D990-0x000000018C20D9F0
		public static Test_Material[] ToTestObject(this Material[] self); // 0x000000018C20D9F0-0x000000018C20DB1C
		public static List<Test_Material> ToTestObject(this List<Material> self); // 0x000000018C20D884-0x000000018C20D990
	}

	public class Test_Collider : IEquivableWrapperClass<Test_Collider> // TypeDefIndex: 78530
	{
		// Fields
		public Collider self; // 0x10
	
		// Constructors
		public Test_Collider(Collider self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20BBFC-0x000000018C20BC4C
		public bool IsEquivalentTo(Test_Collider other); // 0x000000018C20B77C-0x000000018C20BBFC
	}

	public static class Test_Collider_Extensions // TypeDefIndex: 78532
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78531
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Collider, Test_Collider> __9__1_0; // 0x08
			public static Converter<Collider, Test_Collider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C2121A4-0x000000018C212208
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Collider _ToTestObject_b__1_0(Collider lod); // 0x000000018C2112B0-0x000000018C211310
			internal Test_Collider _ToTestObject_b__2_0(Collider lod); // 0x000000018C211AEC-0x000000018C211B4C
		}
	
		// Extension methods
		public static Test_Collider ToTestObject(this Collider self); // 0x000000018C20B71C-0x000000018C20B77C
		public static Test_Collider[] ToTestObject(this Collider[] self); // 0x000000018C20B618-0x000000018C20B71C
		public static List<Test_Collider> ToTestObject(this List<Collider> self); // 0x000000018C20B50C-0x000000018C20B618
	}

	public class Test_BoxCollider : IEquivableWrapperClass<Test_BoxCollider> // TypeDefIndex: 78533
	{
		// Fields
		public BoxCollider self; // 0x10
	
		// Constructors
		public Test_BoxCollider(BoxCollider self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20B074-0x000000018C20B0C4
		public bool IsEquivalentTo(Test_BoxCollider other); // 0x000000018C20AEE8-0x000000018C20B074
	}

	public static class Test_BoxCollider_Extensions // TypeDefIndex: 78535
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78534
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<BoxCollider, Test_BoxCollider> __9__1_0; // 0x08
			public static Converter<BoxCollider, Test_BoxCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C211FB0-0x000000018C212014
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_BoxCollider _ToTestObject_b__1_0(BoxCollider lod); // 0x000000018C2113CC-0x000000018C21142C
			internal Test_BoxCollider _ToTestObject_b__2_0(BoxCollider lod); // 0x000000018C211F08-0x000000018C211F68
		}
	
		// Extension methods
		public static Test_BoxCollider ToTestObject(this BoxCollider self); // 0x000000018C20AE88-0x000000018C20AEE8
		public static Test_BoxCollider[] ToTestObject(this BoxCollider[] self); // 0x000000018C20AC78-0x000000018C20AD7C
		public static List<Test_BoxCollider> ToTestObject(this List<BoxCollider> self); // 0x000000018C20AD7C-0x000000018C20AE88
	}

	public class Test_SphereCollider : IEquivableWrapperClass<Test_SphereCollider> // TypeDefIndex: 78536
	{
		// Fields
		public SphereCollider self; // 0x10
	
		// Constructors
		public Test_SphereCollider(SphereCollider self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20F338-0x000000018C20F388
		public bool IsEquivalentTo(Test_SphereCollider other); // 0x000000018C20F1D0-0x000000018C20F338
	}

	public static class Test_SphereCollider_Extensions // TypeDefIndex: 78538
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78537
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<SphereCollider, Test_SphereCollider> __9__1_0; // 0x08
			public static Converter<SphereCollider, Test_SphereCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212398-0x000000018C2123FC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_SphereCollider _ToTestObject_b__1_0(SphereCollider lod); // 0x000000018C21178C-0x000000018C2117EC
			internal Test_SphereCollider _ToTestObject_b__2_0(SphereCollider lod); // 0x000000018C211C0C-0x000000018C211C6C
		}
	
		// Extension methods
		public static Test_SphereCollider ToTestObject(this SphereCollider self); // 0x000000018C20F064-0x000000018C20F0C4
		public static Test_SphereCollider[] ToTestObject(this SphereCollider[] self); // 0x000000018C20EF60-0x000000018C20F064
		public static List<Test_SphereCollider> ToTestObject(this List<SphereCollider> self); // 0x000000018C20F0C4-0x000000018C20F1D0
	}

	public class Test_CapsuleCollider : IEquivableWrapperClass<Test_CapsuleCollider> // TypeDefIndex: 78539
	{
		// Fields
		public CapsuleCollider self; // 0x10
	
		// Constructors
		public Test_CapsuleCollider(CapsuleCollider self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20B4BC-0x000000018C20B50C
		public bool IsEquivalentTo(Test_CapsuleCollider other); // 0x000000018C20B334-0x000000018C20B4BC
	}

	public static class Test_CapsuleCollider_Extensions // TypeDefIndex: 78541
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78540
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<CapsuleCollider, Test_CapsuleCollider> __9__1_0; // 0x08
			public static Converter<CapsuleCollider, Test_CapsuleCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212140-0x000000018C2121A4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_CapsuleCollider _ToTestObject_b__1_0(CapsuleCollider lod); // 0x000000018C2114EC-0x000000018C21154C
			internal Test_CapsuleCollider _ToTestObject_b__2_0(CapsuleCollider lod); // 0x000000018C211BAC-0x000000018C211C0C
		}
	
		// Extension methods
		public static Test_CapsuleCollider ToTestObject(this CapsuleCollider self); // 0x000000018C20B0C4-0x000000018C20B124
		public static Test_CapsuleCollider[] ToTestObject(this CapsuleCollider[] self); // 0x000000018C20B230-0x000000018C20B334
		public static List<Test_CapsuleCollider> ToTestObject(this List<CapsuleCollider> self); // 0x000000018C20B124-0x000000018C20B230
	}

	public class Test_MeshCollider : IEquivableWrapperClass<Test_MeshCollider> // TypeDefIndex: 78542
	{
		// Fields
		public MeshCollider self; // 0x10
	
		// Constructors
		public Test_MeshCollider(MeshCollider self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20E088-0x000000018C20E0D8
		public bool IsEquivalentTo(Test_MeshCollider other); // 0x000000018C20DFB0-0x000000018C20E088
	}

	public static class Test_MeshCollider_Extensions // TypeDefIndex: 78544
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78543
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshCollider, Test_MeshCollider> __9__1_0; // 0x08
			public static Converter<MeshCollider, Test_MeshCollider> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212460-0x000000018C2124C4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_MeshCollider _ToTestObject_b__1_0(MeshCollider lod); // 0x000000018C211250-0x000000018C2112B0
			internal Test_MeshCollider _ToTestObject_b__2_0(MeshCollider lod); // 0x000000018C211A2C-0x000000018C211A8C
		}
	
		// Extension methods
		public static Test_MeshCollider ToTestObject(this MeshCollider self); // 0x000000018C20DD40-0x000000018C20DDA0
		public static Test_MeshCollider[] ToTestObject(this MeshCollider[] self); // 0x000000018C20DDA0-0x000000018C20DEA4
		public static List<Test_MeshCollider> ToTestObject(this List<MeshCollider> self); // 0x000000018C20DEA4-0x000000018C20DFB0
	}

	public class Test_Mesh : IEquivableWrapperClass<Test_Mesh> // TypeDefIndex: 78545
	{
		// Fields
		public Mesh self; // 0x10
	
		// Constructors
		public Test_Mesh(Mesh self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20EF10-0x000000018C20EF60
		public bool IsEquivalentTo(Test_Mesh other); // 0x000000018C20EB50-0x000000018C20EF10
	}

	public static class Test_Mesh_Extensions // TypeDefIndex: 78547
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78546
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Mesh, Test_Mesh> __9__1_0; // 0x08
			public static Converter<Mesh, Test_Mesh> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212334-0x000000018C212398
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Mesh _ToTestObject_b__1_0(Mesh lod); // 0x000000018C2115AC-0x000000018C21160C
			internal Test_Mesh _ToTestObject_b__2_0(Mesh lod); // 0x000000018C2118AC-0x000000018C21190C
		}
	
		// Extension methods
		public static Test_Mesh ToTestObject(this Mesh self); // 0x000000018C20E8E0-0x000000018C20E940
		public static Test_Mesh[] ToTestObject(this Mesh[] self); // 0x000000018C20EA4C-0x000000018C20EB50
		public static List<Test_Mesh> ToTestObject(this List<Mesh> self); // 0x000000018C20E940-0x000000018C20EA4C
	}

	public class Test_MeshRenderer : IEquivableWrapperClass<Test_MeshRenderer> // TypeDefIndex: 78548
	{
		// Fields
		public MeshRenderer self; // 0x10
	
		// Constructors
		public Test_MeshRenderer(MeshRenderer self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20E890-0x000000018C20E8E0
		public bool IsEquivalentTo(Test_MeshRenderer other); // 0x000000018C20E76C-0x000000018C20E890
	}

	public static class Test_MeshRenderer_Extensions // TypeDefIndex: 78550
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78549
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshRenderer, Test_MeshRenderer> __9__1_0; // 0x08
			public static Converter<MeshRenderer, Test_MeshRenderer> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212208-0x000000018C21226C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_MeshRenderer _ToTestObject_b__1_0(MeshRenderer lod); // 0x000000018C21184C-0x000000018C2118AC
			internal Test_MeshRenderer _ToTestObject_b__2_0(MeshRenderer lod); // 0x000000018C211EA8-0x000000018C211F08
		}
	
		// Extension methods
		public static Test_MeshRenderer ToTestObject(this MeshRenderer self); // 0x000000018C20E4FC-0x000000018C20E55C
		public static Test_MeshRenderer[] ToTestObject(this MeshRenderer[] self); // 0x000000018C20E668-0x000000018C20E76C
		public static List<Test_MeshRenderer> ToTestObject(this List<MeshRenderer> self); // 0x000000018C20E55C-0x000000018C20E668
	}

	public class Test_MeshFilter : IEquivableWrapperClass<Test_MeshFilter> // TypeDefIndex: 78551
	{
		// Fields
		public MeshFilter self; // 0x10
	
		// Constructors
		public Test_MeshFilter(MeshFilter self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20E4AC-0x000000018C20E4FC
		public bool IsEquivalentTo(Test_MeshFilter other); // 0x000000018C20E348-0x000000018C20E4AC
	}

	public static class Test_MeshFilter_Extensions // TypeDefIndex: 78553
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78552
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MeshFilter, Test_MeshFilter> __9__1_0; // 0x08
			public static Converter<MeshFilter, Test_MeshFilter> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212654-0x000000018C2126B8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_MeshFilter _ToTestObject_b__1_0(MeshFilter lod); // 0x000000018C21172C-0x000000018C21178C
			internal Test_MeshFilter _ToTestObject_b__2_0(MeshFilter lod); // 0x000000018C21196C-0x000000018C2119CC
		}
	
		// Extension methods
		public static Test_MeshFilter ToTestObject(this MeshFilter self); // 0x000000018C20E2E8-0x000000018C20E348
		public static Test_MeshFilter[] ToTestObject(this MeshFilter[] self); // 0x000000018C20E1E4-0x000000018C20E2E8
		public static List<Test_MeshFilter> ToTestObject(this List<MeshFilter> self); // 0x000000018C20E0D8-0x000000018C20E1E4
	}

	public class Test_LayerMask : IEquivable<Test_LayerMask> // TypeDefIndex: 78554
	{
		// Fields
		public LayerMask self; // 0x10
	
		// Constructors
		public Test_LayerMask(LayerMask self); // 0x0000000182234E90-0x0000000182234EA0
	
		// Methods
		public bool IsEquivalentTo(Test_LayerMask other); // 0x000000018C20D7F0-0x000000018C20D884
	}

	public static class Test_LayerMask_Extensions // TypeDefIndex: 78555
	{
		// Extension methods
		public static Test_LayerMask ToTestObject(this LayerMask self); // 0x000000018C20D7AC-0x000000018C20D7F0
	}

	public class Test_Gradient : IEquivableWrapperClass<Test_Gradient> // TypeDefIndex: 78556
	{
		// Fields
		public Gradient self; // 0x10
	
		// Constructors
		public Test_Gradient(Gradient self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x0000000185371DA0-0x0000000185371DB0
		public bool IsEquivalentTo(Test_Gradient other); // 0x000000018C20BEBC-0x000000018C20BFBC
	}

	public static class Test_Gradient_Extensions // TypeDefIndex: 78558
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78557
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Gradient, Test_Gradient> __9__1_0; // 0x08
			public static Converter<Gradient, Test_Gradient> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C2123FC-0x000000018C212460
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Gradient _ToTestObject_b__1_0(Gradient lod); // 0x000000018C2117EC-0x000000018C21184C
			internal Test_Gradient _ToTestObject_b__2_0(Gradient lod); // 0x000000018C211A8C-0x000000018C211AEC
		}
	
		// Extension methods
		public static Test_Gradient ToTestObject(this Gradient self); // 0x000000018C20BE5C-0x000000018C20BEBC
		public static Test_Gradient[] ToTestObject(this Gradient[] self); // 0x000000018C20BD58-0x000000018C20BE5C
		public static List<Test_Gradient> ToTestObject(this List<Gradient> self); // 0x000000018C20BC4C-0x000000018C20BD58
	}

	public class Test_AnimationCurve : IEquivableWrapperClass<Test_AnimationCurve> // TypeDefIndex: 78559
	{
		// Fields
		public AnimationCurve self; // 0x10
	
		// Constructors
		public Test_AnimationCurve(AnimationCurve self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x0000000185371DA0-0x0000000185371DB0
		public bool IsEquivalentTo(Test_AnimationCurve other); // 0x000000018C20AB8C-0x000000018C20AC78
	}

	public static class Test_AnimationCurve_Extensions // TypeDefIndex: 78561
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78560
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<AnimationCurve, Test_AnimationCurve> __9__1_0; // 0x08
			public static Converter<AnimationCurve, Test_AnimationCurve> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C2122D0-0x000000018C212334
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_AnimationCurve _ToTestObject_b__1_0(AnimationCurve lod); // 0x000000018C21160C-0x000000018C21166C
			internal Test_AnimationCurve _ToTestObject_b__2_0(AnimationCurve lod); // 0x000000018C211D88-0x000000018C211DE8
		}
	
		// Extension methods
		public static Test_AnimationCurve ToTestObject(this AnimationCurve self); // 0x000000018C20A91C-0x000000018C20A97C
		public static Test_AnimationCurve[] ToTestObject(this AnimationCurve[] self); // 0x000000018C20A97C-0x000000018C20AA80
		public static List<Test_AnimationCurve> ToTestObject(this List<AnimationCurve> self); // 0x000000018C20AA80-0x000000018C20AB8C
	}

	public class Test_TerrainLayer : IEquivableWrapperClass<Test_TerrainLayer> // TypeDefIndex: 78562
	{
		// Fields
		public TerrainLayer self; // 0x10
	
		// Constructors
		public Test_TerrainLayer(TerrainLayer self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C210160-0x000000018C2101B0
		public bool IsEquivalentTo(Test_TerrainLayer other); // 0x000000018C20FD98-0x000000018C210160
	}

	public static class Test_TerrainLayer_Extensions // TypeDefIndex: 78564
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78563
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TerrainLayer, Test_TerrainLayer> __9__1_0; // 0x08
			public static Converter<TerrainLayer, Test_TerrainLayer> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C2124C4-0x000000018C212528
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_TerrainLayer _ToTestObject_b__1_0(TerrainLayer lod); // 0x000000018C21148C-0x000000018C2114EC
			internal Test_TerrainLayer _ToTestObject_b__2_0(TerrainLayer lod); // 0x000000018C211D28-0x000000018C211D88
		}
	
		// Extension methods
		public static Test_TerrainLayer ToTestObject(this TerrainLayer self); // 0x000000018C20FB28-0x000000018C20FB88
		public static Test_TerrainLayer[] ToTestObject(this TerrainLayer[] self); // 0x000000018C20FC94-0x000000018C20FD98
		public static List<Test_TerrainLayer> ToTestObject(this List<TerrainLayer> self); // 0x000000018C20FB88-0x000000018C20FC94
	}

	public class Test_Texture2D : IEquivableWrapperClass<Test_Texture2D> // TypeDefIndex: 78565
	{
		// Fields
		public Texture2D self; // 0x10
	
		// Constructors
		public Test_Texture2D(Texture2D self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C210958-0x000000018C2109A8
		public bool IsEquivalentTo(Test_Texture2D other); // 0x000000018C21082C-0x000000018C210958
	}

	public static class Test_Texture2D_Extensions // TypeDefIndex: 78567
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78566
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Texture2D, Test_Texture2D> __9__1_0; // 0x08
			public static Converter<Texture2D, Test_Texture2D> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C2125F0-0x000000018C212654
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Texture2D _ToTestObject_b__1_0(Texture2D lod); // 0x000000018C2111F0-0x000000018C211250
			internal Test_Texture2D _ToTestObject_b__2_0(Texture2D lod); // 0x000000018C211E48-0x000000018C211EA8
		}
	
		// Extension methods
		public static Test_Texture2D ToTestObject(this Texture2D self); // 0x000000018C2105BC-0x000000018C21061C
		public static Test_Texture2D[] ToTestObject(this Texture2D[] self); // 0x000000018C21061C-0x000000018C210720
		public static List<Test_Texture2D> ToTestObject(this List<Texture2D> self); // 0x000000018C210720-0x000000018C21082C
	}

	public class Test_TreeInstance : IEquivable<Test_TreeInstance> // TypeDefIndex: 78568
	{
		// Fields
		public TreeInstance self; // 0x10
	
		// Constructors
		public Test_TreeInstance(TreeInstance self); // 0x00000001872509B0-0x00000001872509D0
	
		// Methods
		public bool IsEquivalentTo(Test_TreeInstance other); // 0x000000018C211058-0x000000018C2111F0
	}

	public static class Test_TreeInstance_Extensions // TypeDefIndex: 78570
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78569
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TreeInstance, Test_TreeInstance> __9__1_0; // 0x08
			public static Converter<TreeInstance, Test_TreeInstance> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C21226C-0x000000018C2122D0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_TreeInstance _ToTestObject_b__1_0(TreeInstance lod); // 0x000000018C211310-0x000000018C21136C
			internal Test_TreeInstance _ToTestObject_b__2_0(TreeInstance lod); // 0x000000018C211C6C-0x000000018C211CC8
		}
	
		// Extension methods
		public static Test_TreeInstance ToTestObject(this TreeInstance self); // 0x000000018C210EF0-0x000000018C210F4C
		public static Test_TreeInstance[] ToTestObject(this TreeInstance[] self); // 0x000000018C210DEC-0x000000018C210EF0
		public static List<Test_TreeInstance> ToTestObject(this List<TreeInstance> self); // 0x000000018C210F4C-0x000000018C211058
	}

	public class Test_TerrainData : IEquivableWrapperClass<Test_TerrainData> // TypeDefIndex: 78571
	{
		// Fields
		public TerrainData self; // 0x10
	
		// Constructors
		public Test_TerrainData(TerrainData self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C20FAD8-0x000000018C20FB28
		public bool IsEquivalentTo(Test_TerrainData other); // 0x000000018C20F5F8-0x000000018C20FAD8
	}

	public static class Test_TerrainData_Extensions // TypeDefIndex: 78573
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78572
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<TerrainData, Test_TerrainData> __9__1_0; // 0x08
			public static Converter<TerrainData, Test_TerrainData> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212528-0x000000018C21258C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_TerrainData _ToTestObject_b__1_0(TerrainData lod); // 0x000000018C2116CC-0x000000018C21172C
			internal Test_TerrainData _ToTestObject_b__2_0(TerrainData lod); // 0x000000018C211CC8-0x000000018C211D28
		}
	
		// Extension methods
		public static Test_TerrainData ToTestObject(this TerrainData self); // 0x000000018C20F598-0x000000018C20F5F8
		public static Test_TerrainData[] ToTestObject(this TerrainData[] self); // 0x000000018C20F494-0x000000018C20F598
		public static List<Test_TerrainData> ToTestObject(this List<TerrainData> self); // 0x000000018C20F388-0x000000018C20F494
	}

	public class Test_Terrain : IEquivableWrapperClass<Test_Terrain> // TypeDefIndex: 78574
	{
		// Fields
		public Terrain self; // 0x10
	
		// Constructors
		public Test_Terrain(Terrain self); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsNull(); // 0x000000018C21056C-0x000000018C2105BC
		public bool IsEquivalentTo(Test_Terrain other); // 0x000000018C210420-0x000000018C21056C
	}

	public static class Test_Terrain_Extensions // TypeDefIndex: 78576
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 78575
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<Terrain, Test_Terrain> __9__1_0; // 0x08
			public static Converter<Terrain, Test_Terrain> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018C212014-0x000000018C212078
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Test_Terrain _ToTestObject_b__1_0(Terrain lod); // 0x000000018C21166C-0x000000018C2116CC
			internal Test_Terrain _ToTestObject_b__2_0(Terrain lod); // 0x000000018C211B4C-0x000000018C211BAC
		}
	
		// Extension methods
		public static Test_Terrain ToTestObject(this Terrain self); // 0x000000018C2101B0-0x000000018C210210
		public static Test_Terrain[] ToTestObject(this Terrain[] self); // 0x000000018C210210-0x000000018C210314
		public static List<Test_Terrain> ToTestObject(this List<Terrain> self); // 0x000000018C210314-0x000000018C210420
	}

	[Serializable]
	internal class HEU_ToolsInfo : ScriptableObject, IEquivable<HEU_ToolsInfo> // TypeDefIndex: 78579
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
		public enum PaintMergeMode // TypeDefIndex: 78577
		{
			REPLACE = 0,
			ADD = 1,
			SUBTRACT = 2,
			MULTIPLY = 3
		}
	
		public enum PaintMeshVisibility // TypeDefIndex: 78578
		{
			AUTO = 0,
			SHOW = 1,
			HIDE = 2
		}
	
		// Constructors
		public HEU_ToolsInfo(); // 0x000000018C2050C4-0x000000018C2051C4
	
		// Methods
		public bool IsEquivalentTo(HEU_ToolsInfo other); // 0x000000018C204B74-0x000000018C2050C4
	}

	public enum HFLayerType // TypeDefIndex: 78580
	{
		DEFAULT = 0,
		HEIGHT = 1,
		MASK = 2,
		DETAIL = 3
	}

	[Serializable]
	public class HEU_VolumeLayer : IEquivable<HEU_VolumeLayer> // TypeDefIndex: 78581
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
		public HEU_VolumeLayer(); // 0x000000018723A910-0x000000018723A920
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeLayer other); // 0x000000018C2079B8-0x000000018C207C9C
	}

	public class HEU_VolumeScatterTrees : IEquivable<HEU_VolumeScatterTrees> // TypeDefIndex: 78582
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
		public HEU_VolumeScatterTrees(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsEquivalentTo(HEU_VolumeScatterTrees other); // 0x000000018C207C9C-0x000000018C207F74
	}

	public class HEU_TreePrototypeInfo : IEquivable<HEU_TreePrototypeInfo> // TypeDefIndex: 78583
	{
		// Fields
		public string _prefabPath; // 0x10
		public float _bendfactor; // 0x18
	
		// Constructors
		public HEU_TreePrototypeInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsEquivalentTo(HEU_TreePrototypeInfo other); // 0x000000018C2051C4-0x000000018C2052DC
	}

	public class HEU_DetailProperties : IEquivable<HEU_DetailProperties> // TypeDefIndex: 78584
	{
		// Fields
		public float _detailDistance; // 0x10
		public float _detailDensity; // 0x14
		public int _detailResolution; // 0x18
		public int _detailResolutionPerPatch; // 0x1C
	
		// Constructors
		public HEU_DetailProperties(); // 0x0000000187250950-0x0000000187250970
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailProperties other); // 0x000000018C20005C-0x000000018C2001BC
	}

	public class HEU_DetailPrototype : IEquivable<HEU_DetailPrototype> // TypeDefIndex: 78585
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
		public HEU_DetailPrototype(); // 0x000000018C20028C-0x000000018C200344
	
		// Methods
		public bool IsEquivalentTo(HEU_DetailPrototype other); // 0x000000018C2001BC-0x000000018C20028C
	}

	public class HEU_VolumeCache : ScriptableObject, IHEU_VolumeCache, IHEU_HoudiniAssetSubcomponent, IEquivable<HEU_VolumeCache> // TypeDefIndex: 78586
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
		public List<HEU_VolumeLayer> Layers { get; } // 0x000000018225E800-0x000000018225E810 
		public int TileIndex { get; } // 0x000000018226EBA0-0x000000018226EBB0 
		public string ObjectName { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public string GeoName { get; } // 0x0000000182986470-0x0000000182986480 
		public TerrainData TerrainData { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public HEU_VolumeScatterTrees ScatterTrees { get; } // 0x0000000187232F70-0x0000000187232F80 
		public HEU_DetailProperties DetailProperties { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		public HEU_HoudiniAsset ParentAsset { get; } // 0x0000000187232F80-0x0000000187232F90 
		public bool IsDirty { get; set; } // 0x000000018226EBB0-0x000000018226EBC0 0x000000018226EBC0-0x000000018226EBD0
		public bool UIExpanded { get; set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Constructors
		public HEU_VolumeCache(); // 0x000000018C207934-0x000000018C2079B8
	
		// Methods
		public HEU_SessionBase GetSession(); // 0x000000018C205E40-0x000000018C205ED4
		public void Recook(); // 0x000000018C206F54-0x000000018C206FBC
		public void ResetParameters(); // 0x000000018C206FBC-0x000000018C207134
		public HEU_VolumeLayer GetLayer(string layerName); // 0x000000018C205C8C-0x000000018C205DD0
		public void PopulatePreset(HEU_VolumeCachePreset cachePreset); // 0x000000018C206C9C-0x000000018C206F18
		public bool ApplyPreset(HEU_VolumeCachePreset volumeCachePreset); // 0x000000018C2052DC-0x000000018C205560
		internal static List<HEU_VolumeCache> UpdateVolumeCachesFromParts(HEU_SessionBase session, HEU_GeoNode ownerNode, List<HEU_PartData> volumeParts, List<HEU_VolumeCache> volumeCaches); // 0x000000018C207238-0x000000018C207934
		internal void Initialize(HEU_GeoNode ownerNode, int tileIndex); // 0x000000018C205ED4-0x000000018C205FD0
		internal void StartUpdateLayers(); // 0x000000018C207134-0x000000018C2071AC
		internal void FinishUpdateLayers(); // 0x000000018C205918-0x000000018C205948
		private void GetPartLayerAttributes(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer); // 0x000000018C205DD0-0x000000018C205E40
		private bool LoadLayerTextureFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, out Texture2D outTexture); // 0x000000018C206A44-0x000000018C206B44
		private bool LoadLayerFloatFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref float floatValue); // 0x000000018C206538-0x000000018C20663C
		private bool LoadLayerColorFromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref UnityEngine.Color colorValue); // 0x000000018C2063D0-0x000000018C206538
		private bool LoadLayerVector2FromAttribute(HEU_SessionBase session, int geoID, int partID, string attrName, ref Vector2 vectorValue); // 0x000000018C206B44-0x000000018C206C60
		internal void UpdateLayerFromPart(HEU_SessionBase session, HEU_PartData part); // 0x000000018C2071AC-0x000000018C207238
		internal void GenerateTerrainWithAlphamaps(HEU_SessionBase session, HEU_HoudiniAsset houdiniAsset, bool bRebuild); // 0x000000018C205948-0x000000018C205C8C
		public void LoadLayerPropertiesFromAttributes(HEU_SessionBase session, int geoID, int partID, TerrainLayer terrainLayer, bool bNewTerrainLayer, Texture2D defaultTexture); // 0x000000018C20663C-0x000000018C206A44
		internal void PopulateScatterTrees(HEU_SessionBase session, int geoID, int partID, int pointCount, bool throwWarningIfNoTileAttribute); // 0x000000018C206F18-0x000000018C206F54
		internal void PopulateDetailPrototype(HEU_SessionBase session, int geoID, int partID, HEU_VolumeLayer layer); // 0x000000018C206C60-0x000000018C206C9C
		internal void CopyValuesTo(HEU_VolumeCache destCache); // 0x000000018C2056CC-0x000000018C205918
		internal static void CopyDetailProperties(HEU_DetailProperties srcProp, HEU_DetailProperties destProp); // 0x000000018C205560-0x000000018C205590
		internal static void CopyLayer(HEU_VolumeLayer srcLayer, HEU_VolumeLayer destLayer); // 0x000000018C205590-0x000000018C205670
		internal static void CopyPrototype(HEU_DetailPrototype srcProto, HEU_DetailPrototype destProto); // 0x000000018C205670-0x000000018C2056CC
		internal static Texture2D LoadDefaultSplatTexture(); // 0x000000018C206368-0x000000018C2063D0
		internal static Texture2D LoadAssetTexture(string path); // 0x000000018C20629C-0x000000018C206368
		public bool IsEquivalentTo(HEU_VolumeCache other); // 0x000000018C205FD0-0x000000018C20629C
	}
}
